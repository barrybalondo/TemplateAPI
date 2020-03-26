using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Template.API.Infrastructure.Repositories;

namespace Template.API.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly ITemplateRepository _templateRepository;
        private readonly ILogger<TemplateService> _logger;

        public TemplateService(
            ITemplateRepository templateRepository,
            ILogger<TemplateService> logger)
        {
            _templateRepository = templateRepository;
            _logger = logger;
        }

        public async Task<Model.Template> GetTemplateByIdAsync(int id)
        {
            // Logging test.
            _logger.LogInformation($"Begin call TemplateService.GetTemplateByIdAsync for id {id}", id);

            var template = await _templateRepository.GetTemplateByIdAsync(id);

            // Do some bussiness logic.

            return template;
        }

        public async Task<IList<Model.Template>> GetTemplatesAsync()
        {
            // Logging test.
            _logger.LogInformation($"Begin call TemplateService.GetTemplatesAsync");

            var templates = await _templateRepository.GetTemplatesAsync();

            // Do some business logic.

            return templates;
        }
    }
}
