using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Template.API.Services
{
    public interface ITemplateService
    {
        Task<Model.Template> GetTemplateByIdAsync(int id);
        Task<IList<Model.Template>> GetTemplatesAsync();
    }
}
