using System.Collections.Generic;

namespace weather_forcast_backend
{
    public interface IMemStore
    {
        void Store(UserInfo userInfo);
        IEnumerable<UserInfo> GetAll();
    }
    public class MemStoreSingleton : IMemStore
    {
        private List<UserInfo> _userInfos;
        public MemStoreSingleton()
        {
            _userInfos = new List<UserInfo>();
        }
        public void Store(UserInfo userInfo)
        {
            _userInfos.Add(userInfo);
        }
        public IEnumerable<UserInfo> GetAll()
        {
            return _userInfos;
        }
    }

    public class UserInfo
    {
        public string BrowserAgent { get; set; }
        public string RemoteAddress { get; set; }

        public long TimeStamp { get; set; }
    }
}
