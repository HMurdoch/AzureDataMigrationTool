using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_data_migration_v1.Pages
{
    public class FileToBlobStorage : PageModel
    {
        private readonly ILogger<FileToBlobStorage> _logger;

        public FileToBlobStorage(ILogger<FileToBlobStorage> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
