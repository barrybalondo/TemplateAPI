using System.Collections.Generic;
using System.Threading.Tasks;

namespace Template.API.Infrastructure.Repositories
{
    public interface ITemplateRepository
    {
        Task<Model.Template> GetTemplateByIdAsync(int id);
        Task<IList<Model.Template>> GetTemplatesAsync();
    }
}
