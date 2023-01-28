using SQLite;

namespace MSTodoX.Model
{
    class AppSetting
    {
        public static string DbFileName = "MSTodoX_db.sqlite";

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string AppName { get; set; }
        public string Author { get; set; }
        public string AuthKey { get; set; }
    }
}
