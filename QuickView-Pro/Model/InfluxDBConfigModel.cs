using System;

namespace QuickView_Pro
{
    public class InfluxDBConfigModel
    {
        public string UserName = "admin";

        public string PassWord = "12345678";

        public string Guid;

        public string Org = "FLDHMI";

        public string IPAddr = "http://localhost";

        public int Port = 8086;

        public string StoragePath;
    }
}
