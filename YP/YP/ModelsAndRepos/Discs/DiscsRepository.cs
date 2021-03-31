
using System.Collections.Generic;
using System.Linq;
using Oracle.ManagedDataAccess.Client;
using Dapper;

namespace YP.ModelsAndRepos.Discs
{
    public class DiscsRepository : IDiscsRepository
    {
        readonly string connectionString =
            " Data Source= localhost:1521/xe; User Id=tester; Password=123;";


        public bool AddDisc(DiscModel disc)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql1 = "SELECT nvl(band_id, 0) FROM Bands WHERE band_id=:BID";
                string sql2 = "SELECT nvl(serial_number, 0) FROM Discs WHERE title=:DiscTITLE";
                string sql3 = "INSERT INTO Discs(title, band_id, wholesale_price, retail_price, date_of_release, " +
                    "saled_in_last_year, saled_in_current_year, how_much_left, " +
                    "wholesale_company, list_of_songs) " +
                    "VALUES(:DiscTITLE, :BID, :WHSP, :RTP, to_date(:DOR, 'dd.MM.yyyy'), " +
                    ":SILY, :SICY, :HML, :WHSC, :LOS)";
                string sql4 = "SELECT nvl(song_id, 0) FROM Songs WHERE song_name=:SN";
                string sql5 = "SELECT nvl(perfomance_id,0) FROM Performed_songs WHERE song_id=:SID";
                string sql6 = "INSERT INTO Disc_has_song(song_perf_id, disc_serial_num, song_number) " +
                    "VALUES(:SPI, :DSN, :SN)";


                db.Open();

                if (db.Query<string>(sql1, new { BID = disc.BandId }).FirstOrDefault() == null)
                {
                    return false;
                }

                if (db.Query<string>(sql2, new { DiscTITLE = disc.Title }).FirstOrDefault() != null)
                {
                    return false;
                }

                db.Execute(sql3, 
                    new { 
                    DiscTITLE = disc.Title, 
                    BID = disc.BandId, 
                    WHSP = disc.WholesalePrice,
                    RTP = disc.RetailPrice,
                    DOR = disc.DateOfRelease,
                    SILY = disc.SaledInLastYear,
                    SICY = disc.SaledInCurrentYear,
                    HML = disc.HowMuchLeft,
                    WHSC = disc.WholesaleCompany,
                    LOS = disc.ListOfSongs.Replace("|", " ")
                });

                string serialNum = db.Query<string>(sql2, new { DiscTITLE = disc.Title }).FirstOrDefault();

                if (serialNum == null)
                {
                    return false;
                }

                string[] songs = disc.ListOfSongs.Split(new char[] { '|' });

                foreach(string song in songs)
                {
                    string SID = db.Query<string>(sql4, new { SN = song.Substring(2)}).FirstOrDefault();

                    if (SID != null)
                    {
                        string PID = db.Query<string>(sql5, new { SID }).FirstOrDefault();

                        if (PID != null)
                        {
                            db.Execute(sql6, 
                                new { 
                                SPI = PID,
                                DSN = serialNum,
                                SN = song[0]
                            });
                        }
                    }
                }

                

                return true;

            }
        }

        public IEnumerable<DiscModel> GetAllDiscs()
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql = "SELECT title, band_id AS BandID, serial_number AS SerialNumber, " +
                    "wholesale_price AS WholesalePrice, retail_price AS RetailPrice, " +
                    "date_of_release AS DateOfRelease, " +
                    "saled_in_last_year AS SaledInLastYear, " +
                    "saled_in_current_year AS SaledInCurrentYear, " +
                    "how_much_left AS HowMuchLeft, " +
                    "wholesale_company AS WholesaleCompany, list_of_songs AS ListOfSongs " +
                    "FROM Discs";


                db.Open();
                return db.Query<DiscModel>(sql);
            }
        }

        public bool UpdateDisc(int serialNumber, int wholesalePrice, int retailPrice,
            int soldInCY, int howMuchLeft)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql1 = "SELECT nvl(serial_number, 0) FROM Discs WHERE serial_number=:SN";
                string sql2 = "UPDATE Discs SET wholesale_price = :WHP, retail_price = :REP, " +
                    "saled_in_current_year = :SICY, how_much_left = :HML " +
                    "WHERE serial_number = :SN";

                db.Open();

                if (db.Query<string>(sql1, new { SN = serialNumber }).FirstOrDefault() == null)
                {
                    return false;
                }

                db.Execute(sql2,
                    new
                    {
                        WHP = wholesalePrice,
                        REP = retailPrice,
                        SICY = soldInCY,
                        HML = howMuchLeft,
                        SN = serialNumber
                    });
                
                return true;

            }
        }

        public bool DeleteMusician(int serialNumber)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql1 = "SELECT nvl(serial_number, 0) FROM Discs WHERE serial_number=:SN";
                string sql2 = "DELETE FROM Discs WHERE serial_number = :SN";
                string sql3 = "DELETE FROM Disc_has_song WHERE disc_serial_num = :SN";

                db.Open();

                if (db.Query<string>(sql1, new { SN = serialNumber }).FirstOrDefault() == null)
                {
                    return false;
                }

                db.Execute(sql2, new { SN = serialNumber });
                db.Execute(sql3, new { SN = serialNumber });

                return true;

            }
        }
    }
}
