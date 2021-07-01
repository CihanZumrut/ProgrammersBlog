using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System.Collections.Generic;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryListDto : DtoGetBase
    {
        public IList<Category> Categories { get; set; }
    }
}
