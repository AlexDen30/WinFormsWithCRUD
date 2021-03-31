
using System.Collections.Generic;
using System.Linq;
using Oracle.ManagedDataAccess.Client;
using Dapper;

namespace YP.ModelsAndRepos.Bands
{
    public class BandsRepository : IBandsRepository
    {

        readonly string connectionString = 
            " Data Source= localhost:1521/xe; User Id=tester; Password=123;";

        
        public bool AddBand(BandModel band)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string BN = band.BandName;
                string DOT = band.DiscriptionOfType;
                string sql2 = "SELECT nvl(type_id, 0) FROM Band_type WHERE discription_of_type = :DOT";
                string sql1 = "SELECT nvl(band_id, 0) FROM Bands WHERE band_name = :BN";
                string sql4 = "INSERT INTO Bands(band_name, type_id) " +
                    "VALUES (:BN, :TID)";
                string sql3 = "INSERT INTO Band_type(discription_of_type) VALUES(:DOT)";

                db.Open();

                string res1 = db.Query<string>(sql1, new { BN }).FirstOrDefault();
                
                if (res1 != null)
                {
                    return false;
                }

                string TID = db.Query<string>(sql2, new { DOT }).FirstOrDefault();

                if (TID == null)
                {
                    db.Execute(sql3, new { DOT });
                    TID = db.Query<string>(sql2, new { DOT }).FirstOrDefault();
                }

                db.Execute(sql4, new { BN, TID });

                return true;
            }
        }

        public IEnumerable<BandModel> GetAllBands()
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql = "SELECT b.band_id AS BandId, b.band_name AS BandName, " +
                    "t.type_id AS TypeId, t.discription_of_type AS DiscriptionOfType " +
                    "FROM Bands b JOIN Band_type t ON b.type_id = t.type_id ";

                
                db.Open();
                return db.Query<BandModel>(sql);
            }
        }

        public bool UpdateBandName(string oldName, string newName)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                
                string sql1 = "SELECT nvl(band_id, 0) FROM Bands WHERE band_name = :BANDNAME";
                string sql2 = "UPDATE Bands SET band_name = :NAME WHERE band_name = :BANDNAME";
                
                db.Open();

                string res1 = db.Query<string>(sql1, new { BANDNAME = oldName }).FirstOrDefault();

                if (res1 == "0")
                {
                    return false;
                }

                db.Execute(sql2, new { BANDNAME = oldName, NAME = newName });

                return true;
            }
        }

        public bool DeleteBand(string bandName)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql = "DELETE FROM Bands WHERE band_name = :NAME";
                string sql1 = "SELECT nvl(band_id, 0) FROM Bands WHERE band_name = :NAME";

                string res1 = db.Query<string>(sql1, new { NAME = bandName }).FirstOrDefault();

                if (res1 == "0")
                {
                    return false;
                }

                db.Open();
                db.Execute(sql, new { NAME = bandName });

                return true;
            }
        }
    }
}
