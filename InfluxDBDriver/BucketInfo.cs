namespace InfluxDBDriver
{
    internal class BucketInfo
    {
        public string Name { get; set; }
        public long RetentionTime { get; set; }
        public BucketType Type { get; set; }

        public BucketInfo(string name, long retentionTime, BucketType type)
        {
            Name = name;
            RetentionTime = retentionTime;
            Type = type;
        }
    }
}
