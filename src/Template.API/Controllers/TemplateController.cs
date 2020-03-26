using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Template.API.Services;
using Template.API.ViewModel;

namespace Template.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class TemplateController : ControllerBase
    {
        private readonly ITemplateService _templateService;

        public TemplateController(ITemplateService templateService)
        {
            _templateService = templateService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TemplateViewModel), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<TemplateViewModel>> GetTemplateByGuidAsync(int id)
        {
            var template = await _templateService.GetTemplateByIdAsync(id);

            // Example of converting model into a viewmodel. You can you use automapper for this.
            return new TemplateViewModel()
            {
                Id = template.Id,
                Data = template.Data
            };
        }

        [HttpGet]
        [ProducesResponseType(typeof(TemplateViewModel), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<TemplateViewModel>>> GetTemplatesAsync()
        {
            var templates = await _templateService.GetTemplatesAsync();

            // Example of converting model into a viewmodel. You can you use automapper for this.
            var templatesViewModel = new List<TemplateViewModel>();

            foreach(var template in templates)
            {
                templatesViewModel.Add(new TemplateViewModel()
                {
                    Id = template.Id,
                    Data = template.Data
                });
            }

            return templatesViewModel.Count > 0
                ? templatesViewModel
                : null;
        }
    }
}
