using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Template.API.Infrastructure
{
    // Contemplating if this class should have its own interface, or is it even
    // really needed at all and just inject the connectionString directly into
    // the repository. One main reason I added this, is to have a logic center
    // for switching database context for STAFF/PROD
    public class ConnectionFactory
    {
        private readonly TemplateSetting _setting;

        public ConnectionFactory(IOptions<TemplateSetting> setting)
        {
            _setting = setting.Value;
        }

        public DbConnection CreateConnection()
        {
            return new SqlConnection(_setting.DefaultConnectionString);
        }
    }
}
