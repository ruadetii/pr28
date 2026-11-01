using Microsoft.EntityFrameworkCore;

namespace TaskManager_Radosteva.Classes.Database
{
    public class Config
    {
        public static readonly string connection = "server=localhost;uid=root;pwd=;database=pr28;";
        public static MySqlServerVersion version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
