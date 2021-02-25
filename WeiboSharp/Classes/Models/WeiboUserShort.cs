using System;

namespace WeiboSharp.Classes.Models
{
    [Serializable]
    public class WeiboUserShort
    {
        public bool IsVerified { get; set; }
        public bool IsPrivate { get; set; }
        public long Pk { get; set; }
        public string ProfilePicture { get; set; }
        public string ProfilePicUrl { get; set; }
        public string ProfilePictureId { get; set; } = "unknown";
        public string UserName { get; set; }
        public string FullName { get; set; }

        public static WeiboUserShort Empty => new WeiboUserShort { FullName = string.Empty, UserName = string.Empty };

        public bool Equals(WeiboUserShort user)
        {
            return Pk == user?.Pk;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as WeiboUserShort);
        }

        public override int GetHashCode()
        {
            return Pk.GetHashCode();
        }
    }
}