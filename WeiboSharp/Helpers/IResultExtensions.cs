using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using WeiboSharp.Classes;

namespace WeiboSharp.Helpers
{
    public static class IResultExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U Match<T, U>(this IResult<T> source, Func<T, U> succFunc, Func<U> failFunc)
        {
            return source.Succeeded
                ? succFunc(source.Value)
                : failFunc();
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IResult<U> Map<T,U>(this IResult<T> source, Func<T,U> function)
        {
            return source.Succeeded 
                ? Result.Success (function(source.Value)) 
                : new Result<U>(false, source.Info);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IResult<U> Map<T, U>(this IResult<T> source, Func<T, IResult<U>> function)
        {
            return source.Succeeded
                ? function(source.Value)
                : new Result<U>(false, source.Info);
        }
    }
}
