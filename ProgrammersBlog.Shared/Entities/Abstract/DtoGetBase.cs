using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

namespace ProgrammersBlog.Shared.Entities.Abstract
{
    public abstract class DtogetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}