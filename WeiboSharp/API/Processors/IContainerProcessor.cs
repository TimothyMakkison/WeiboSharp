using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.ResponseWrappers;

namespace WeiboSharp.API.Processors
{
    public interface IContainerProcessor
    {
        Task<IResult<ContainerUserResponse>> GetUserByIdAsync(string uid);

        Task<IResult<ContainerInfoResponse>> GetUserInfoByIdAsync(string uid);

        Task<IResult<ContainerPageResponse>> GetUserPageAsync(string uid, int page);
    }
}