using CozyCabin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CozyCabin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Chalet> list = new List<Chalet>();
        
        public void OnGet()
        {
            list = new DAL().chaletCards();
           
        }
    }
}
