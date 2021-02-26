using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeiboSharp.Logger;

namespace WeiboSharp.Classes
{
    public class ProcessorHelper : IProcessorHelper
    {
        private IWeiboLogger _logger;

        public ProcessorHelper(IWeiboLogger logger)
        {
            _logger = logger;
        }

        public async Task<IResult<T>> HttpTryDo<T>(Func<Task<IResult<T>>> function)
        {
            try
            {
                return await function();
            }
            catch (HttpRequestException httpException)
            {
                _logger?.LogException(httpException);
                return Result.Fail(httpException, default(T), ResponseType.NetworkProblem);
            }
            catch (Exception exception)
            {
                _logger?.LogException(exception);
                return Result.Fail<T>(exception);
            }
        }
    }
}