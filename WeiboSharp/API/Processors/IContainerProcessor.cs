using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.ResponseWrappers;
using WeiboSharp.Classes.ResponseWrappers.Container;

namespace WeiboSharp.API.Processors
{
    public interface IContainerProcessor
    {
        Task<IResult<UserResponse>> GetUserByIdAsync(string uid);

        Task<IResult<ContainerUserInfoData>> GetUserInfoByIdAsync(string uid);
        Task<IResult<PageData>> GetUserPageById(string uid, int page);

    }
}