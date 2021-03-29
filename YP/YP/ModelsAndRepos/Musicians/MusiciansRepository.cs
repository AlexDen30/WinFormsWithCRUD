using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Dapper;


namespace YP.ModelsAndRepos.Musicians
{
    public class MusiciansRepository : IMusiciansRepository
    {

        readonly string connectionString =
           " Data Source= localhost:1521/xe; User Id=tester; Password=123;";


        public bool AddMusician(string firstName, string surname,
            string bandName, string roleDesc)
        {

            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql1 = " SELECT nvl(musician_id, 0) FROM Musicians " +
                    "WHERE first_name = :FN AND surname = :SN";
                string sql2 = " SELECT nvl(role_id, 0) FROM Music_role " +
                    "WHERE discription_of_role = :DESCR";
                string sql3 = " INSERT INTO Music_role(discription_of_role) VALUES(:DESCR)";
                string sql4 = " INSERT INTO Musicians(first_name, surname, role_id) " +
                    "VALUES(:FN, :SN, :RID)";
                string sql5 = " SELECT nvl(band_id, 0) FROM Bands WHERE band_name = :BN";
                string sql6 = " INSERT INTO Musician_has_band(musician_id, band_id) VALUES(:MID, :BID)";

                db.Open();

                string MID = db.Query<string>(sql1, new { FN = firstName, SN = surname }).FirstOrDefault();

                if (MID != null)
                {
                    return false;
                }

                string RID = db.Query<string>(sql2, new { DESCR = roleDesc }).FirstOrDefault();

                if (RID == null)
                {
                    db.Execute(sql3, new { DESCR = roleDesc });
                    RID = db.Query<string>(sql2, new { DESCR = roleDesc }).FirstOrDefault();
                }

                db.Execute(sql4, new { FN = firstName, SN = surname, RID});

                MID = db.Query<string>(sql1, new { FN = firstName, SN = surname }).FirstOrDefault();

                string BID = db.Query<string>(sql5, new { BN = bandName }).FirstOrDefault();

                if (BID != null)
                {
                    db.Execute(sql6, new { MID, BID });
                }

                return true;
            }

        }

        public IEnumerable<MusicianModel> GetAllMusicians()
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql = "SELECT m.musician_id AS MusicianId, m.role_id AS RoleId, " +
                    "m.first_name AS FirstName, m.surname AS Surname, " +
                    "r.discription_of_role AS DiscriptionOfRole, b.band_name AS BandName " +
                    "FROM Musicians m LEFT OUTER JOIN Music_role r ON m.role_id = r.role_id " +
                    "LEFT OUTER JOIN Bands b ON b.band_id IN " +
                    " (SELECT band_id FROM Musician_has_band WHERE Musician_id = m.musician_id) ";


                db.Open();
                return db.Query<MusicianModel>(sql);
            }
        }

        public bool UpdateMusician(string firstName, string surname,
            string bandName, string roleDesc)
        {

            using (OracleConnection db = new OracleConnection(connectionString))
            {
                if (bandName == null && roleDesc == null)
                {
                    return false;
                }

                string sql1 = " SELECT nvl(band_id, 0) FROM Bands WHERE band_name = :BN";
                string sql2 = " SELECT nvl(musician_id, 0) FROM Musicians " +
                        "WHERE first_name = :FN AND surname = :SN";
                string sql3 = " SELECT nvl(role_id, 0) FROM Music_role " +
                        "WHERE discription_of_role = :DESCR";
                string sql4 = " INSERT INTO Music_role(discription_of_role) VALUES(:DESCR)";
                string sql5 = " UPDATE Musician_has_band SET band_id = :BID WHERE musician_id = :MID";
                //string sql51 = " INSERT INTO Musician_has_band(band_id, musician_id) VALUES (:BID ,:MID)";
                string sql6 = " UPDATE Musician SET role_id = :RID WHERE musician_id = :MID";

                db.Open();

                string MID = db.Query<string>(sql2, new { FN = firstName, SN = surname}).FirstOrDefault();
                

                if (MID == null)
                {
                    return false;
                }

                if (bandName != "")
                {
                    string BID = db.Query<string>(sql1, new { BN = bandName }).FirstOrDefault();

                    if (BID != null)
                    {
                        db.Execute(sql5, new { BID, MID });
                    }
                }
                
                if (roleDesc != "")
                {
                    string RID = db.Query<string>(sql3, new { DESCR = roleDesc }).FirstOrDefault();

                    if (RID == null)
                    {
                        db.Execute(sql4, new { DESCR = roleDesc });
                        RID = db.Query<string>(sql3, new { DESCR = roleDesc }).FirstOrDefault();
                    }

                    db.Execute(sql6, new { RID, MID });
                }
                

                return true;
            }
            
        }

        public bool DeleteMusician(string firstName, string surname)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql1 = " SELECT nvl(musician_id, 0) FROM Musicians " +
                        "WHERE first_name = :FN AND surname = :SN";
                string sql2 = " DELETE FROM Musicians WHERE first_name = :FN AND surname = :SN";
                string sql3 = " DELETE FROM Musician_has_band WHERE musician_id = :MID";


                db.Open();

                string MID = db.Query<string>(sql1, new { FN = firstName, SN = surname }).FirstOrDefault();


                if (MID == null)
                {
                    return false;
                }

                db.Execute(sql2, new { FN = firstName, SN = surname });
                db.Execute(sql3, new { MID });

                return true;
            }
        }
    }
}
