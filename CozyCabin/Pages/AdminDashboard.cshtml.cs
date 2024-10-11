using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CozyCabin.Models;

namespace CozyCabin.Pages
{
    public class AdminDashboardModel : PageModel
    {
        public List<Reservations> list = new List<Reservations>();
        public void OnGet()
        {
           // list = new DAL().pendingReservations(); 
        }
    }
}
