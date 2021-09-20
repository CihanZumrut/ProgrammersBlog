using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Abstract
{
    public interface ICommentService
    {
        Task<IDataResult<int>> Count();
        Task<IDataResult<int>> CountByNonDeleted();
    }
}
