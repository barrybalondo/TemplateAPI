using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Template.API.Infrastructure.Repositories
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public TemplateRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<Model.Template> GetTemplateByIdAsync(int id)
        {
            var sql = @"SELECT Id, Data
                        FROM dbo.Template
                        WHERE Id = @Id";

            using var con = _connectionFactory.CreateConnection();
            return await con.QuerySingleOrDefaultAsync<Model.Template>(sql, new { Id = id });
        }

        public async Task<IList<Model.Template>> GetTemplatesAsync()
        {
            var sql = @"SELECT Id, Data
                        FROM dbo.Template";

            using var con = _connectionFactory.CreateConnection();
            var result = await con.QueryAsync<Model.Template>(sql);

            return result.ToList();
        }
    }
}
