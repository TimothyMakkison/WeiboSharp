using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.ResponseWrappers;

namespace WeiboSharp.API.Processors
{
    public interface IStatusesProcessor
    {
        /// <summary>
        /// Gets asynchronously retrieves Weibo content (Weibo post) by Bid or Id.
        /// </summary>
        /// <param name="identifier">Either alphanumeric bid or long id.</param>
        /// <returns>Weibo status in <see cref="StatusShowResponse"/> form. </returns>
        Task<IResult<StatusShowResponse>> ShowStatusAsync(string identifier);
    }
}