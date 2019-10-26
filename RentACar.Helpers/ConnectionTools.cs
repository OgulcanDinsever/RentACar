using RentACar.Helpers.Properties;

namespace RentACar.Helpers
{
    public class ConnectionTools
    {
        public static string ConnectionString
        {
            get
            {
                return Configuration.Default.ConnectionPath;
            }
        }
    }
}
