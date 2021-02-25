using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.ResponseWrappers;
using WeiboSharp.Classes.ResponseWrappers.Container;

namespace WeiboSharp.API.Processors
{
    public interface IContainerProcessor
    {
        Task<IResult<UserResponse>> GetUserByIdAsync(string id);

        Task<IResult<ContainerUserInfoData>> GetUserInfoByIdAsync(string id);
        Task<IResult<PageData>> GetUserPageById(string id, int page);

    }
}