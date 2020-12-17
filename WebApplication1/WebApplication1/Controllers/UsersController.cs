using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using WebApplication1.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        UserManager<User> _userManager;

        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        [Authorize]
        public IActionResult Index() => View(_userManager.Users.ToList());


        public async Task<IActionResult> Block(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            user.Status="block";
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Index");
        }
    }
}