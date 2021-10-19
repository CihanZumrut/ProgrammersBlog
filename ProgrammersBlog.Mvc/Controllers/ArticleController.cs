using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Mvc.Models;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public async Task<IActionResult> Search(string keyword, int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            var searchresult = await _articleService.SearchAsync(keyword, currentPage, pageSize, isAscending);
            if (searchresult.ResultStatus == ResultStatus.Success)
                return View(new ArticleSearchViewModel
                {
                    ArticleListDto = searchresult.Data,
                    Keyword = keyword
                });
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int articleId)
        {
            var articleResult = await _articleService.GetAsync(articleId);
            if (articleResult.ResultStatus == ResultStatus.Success)
            {
                return View(articleResult.Data);
            }

            return NotFound();
        }
    }
}
