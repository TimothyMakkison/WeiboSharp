using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.ResponseWrappers;

namespace WeiboSharp.API.Processors
{
    public interface IStatusesProcessor
    {
        Task<IResult<PostContentResponse>> ShowStatusAsync(string identifier);
    }
}