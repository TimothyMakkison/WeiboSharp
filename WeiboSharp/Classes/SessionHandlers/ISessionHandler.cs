using WeiboSharp.API;

#if WINDOWS_UWP
using Windows.Storage;
#endif

namespace WeiboSharp.Classes.SessionHandlers
{
    public interface ISessionHandler
    {
        IWeiboApi WeiboApi { get; set; }
#if WINDOWS_UWP
        /// <summary>
        ///     File => Optional
        ///     <para>If you didn't set this, WeiboSharp will choose it automatically based on <see cref="WeiboApi"/> username!</para>
        /// </summary>
        StorageFile File { get; set; }
#else

        /// <summary>
        ///     Path to file
        /// </summary>
        string FilePath { get; set; }

#endif

        /// <summary>
        ///     Load and Set StateData to InstaApi
        /// </summary>
        void Load();

        /// <summary>
        ///     Save current StateData from InstaApi
        /// </summary>
        void Save();
    }
}