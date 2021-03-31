using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Dapper;

namespace YP.ModelsAndRepos.PerformedSongs
{
    public class SongsRepository : ISongsRepository
    {
        readonly string connectionString =
           " Data Source= localhost:1521/xe; User Id=tester; Password=123;";

        public bool AddPSong(string songName, string circumstOfPerf,
            int authorId)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql1 = "SELECT nvl(song_id, 0) FROM Songs " +
                    "WHERE song_name = :SN";
                string sql2 = "INSERT INTO Songs(song_name, СIRCUMSTANCES_OF_WRITING) " +
                    "VALUES(:SN, :COW)";
                string sql3 = "SELECT nvl(musician_id, 0) FROM Musicians WHERE musician_id = :MID";
                string sql4 = "INSERT INTO Author_of_a_song(author_id, song_id) VALUES(:MID, :SID)";
                string sql5 = "SELECT nvl(performance_id, 0) FROM Performed_songs " +
                    "WHERE circumstances_of_performance = :COP AND song = :SN";
                string sql6 = "INSERT INTO Performed_songs(circumstances_of_performance, song, song_id) " +
                    "VALUES(:COP, :SN, :SID)";

                db.Open();

                string MID = db.Query<string>(sql3, new { MID = authorId }).FirstOrDefault();
                if (MID == null)
                {
                    return false;
                }

                if (db.Query<string>(sql5, new { COP = circumstOfPerf, SN = songName }).FirstOrDefault() != null)
                {
                    return false;
                }

                string COW = "...";
                string SID = db.Query<string>(sql1, new { SN = songName }).FirstOrDefault();
                if (SID == null)
                {
                    db.Execute(sql2, new { SN = songName, COW });
                    SID = db.Query<string>(sql1, new { SN = songName }).FirstOrDefault();
                }

                db.Execute(sql4, new { MID, SID });
                db.Execute(sql6, new { COP = circumstOfPerf, SN = songName, SID });

                return true;
            }
                
        }

        public IEnumerable<PerformedSongModel> GetAllPSongs()
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql = "SELECT p.performance_id AS PerformanceId, p.song_id AS SongId, " +
                    "p.song AS SongName, " +
                    "p.circumstances_of_performance AS CircumstancesOfPerfomance, " +
                    "a.author_id AS AuthorId " +
                    "FROM Performed_songs p LEFT OUTER JOIN Author_of_a_song a " +
                    "ON p.song_id = a.song_id ";

                db.Open();
                return db.Query<PerformedSongModel>(sql);
            }
        }

        public bool UpdatePSong(int perfId, string newCirumstOfPerf)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql1 = "SELECT nvl(performance_id, 0) FROM Performed_songs " +
                    "WHERE performance_id = :PID";
                string sql2 = "UPDATE Performed_songs SET circumstances_of_performance = " +
                    ":COP WHERE performance_id = :PID";

                db.Open();

                if (db.Query<string>(sql1, new { PID = perfId }).FirstOrDefault() == null)
                {
                    return false;
                }

                db.Execute(sql2, new { COP = newCirumstOfPerf, PID = perfId });

                return true;
            }
        }

        public bool DeletePSong(int perfId)
        {
            using (OracleConnection db = new OracleConnection(connectionString))
            {
                string sql1 = "SELECT nvl(performance_id, 0) FROM Performed_songs " +
                    "WHERE performance_id = :PID";
                string sql2 = "DELETE Performed_songs WHERE performance_id = :PID";

                db.Open();

                if (db.Query<string>(sql1, new { PID = perfId }).FirstOrDefault() == null)
                {
                    return false;
                }

                db.Execute(sql2, new { PID = perfId });
                return true;
            }
        }
    }
}
