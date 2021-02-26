using System;
using System.Threading.Tasks;

namespace WeiboSharp.Classes
{
    public interface IProcessorHelper
    {
        Task<IResult<T>> HttpTryDo<T>(Func<Task<IResult<T>>> function);
    }
}