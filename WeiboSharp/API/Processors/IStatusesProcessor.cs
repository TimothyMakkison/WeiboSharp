using System.Threading.Tasks;
using WeiboSharp.Classes;
using WeiboSharp.Classes.ResponseWrappers;

namespace WeiboSharp.API.Processors
{
    public interface IStatusesProcessor
    {
        /// <summary>
        /// Asynchronously retrieves Weibo content (Weibo post) by Bid or Id.
        /// </summary>
        /// <param name="identifier">Either alphanumeric bid or long id.</param>
        /// <returns>Weibo status in <see cref="StatusShowResponse"/> form. </returns>
        Task<IResult<StatusShowResponse>> ShowStatusAsync(string identifier);

        /// <summary>
        /// Asynchronously retrieves extended Weibo content (Weibo post) by Bid or Id.
        /// </summary>
        /// <param name="identifier">Either alphanumeric bid or long id.</param>
        /// <returns>Weibo status in <see cref="StatusExtendedShowReponse"/> form. </returns>
        Task<IResult<StatusExtendedShowResponse>> GetExtendedStatusAsync(string identifier);

        /// <summary>
        /// Asynchronously retrieves repost timeline on a Weibo post by Bid or Id.
        /// </summary>
        /// <param name="identifier">Either alphanumeric bid or long id.</param>
        /// <param name="page">Page number.</param>
        /// <returns></returns>
        Task<IResult<StatusRepostTimelineResponse>> GetStatusRepostTimelineAsync(string identifier, int page);

        /// <summary>
        /// Asynchronously retrieves comment page on a Weibo post by Bid or Id.
        /// </summary>
        /// <param name="identifier">Either alphanumeric bid or long id.</param>
        /// <param name="page">Page number.</param>
        /// <returns></returns>
        Task<IResult<StatusShowCommentsResponse>> GetStatusComments(string identifier, int page);
    }
}