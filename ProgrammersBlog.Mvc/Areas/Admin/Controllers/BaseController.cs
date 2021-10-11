using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Mvc.Helpers.Abstract;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(UserManager<User> userManager, IMapper mapper, IImageHelper imagehelper)
        {
            UserManager = userManager;
            Mapper = mapper;
            ImageHelper = imagehelper;
        }
        
       protected UserManager<User> UserManager { get; }
       protected IMapper Mapper { get; }
       protected IImageHelper ImageHelper { get;  }
       protected User LoggedInUser => UserManager.GetUserAsync(HttpContext.User).Result;
    }
}
