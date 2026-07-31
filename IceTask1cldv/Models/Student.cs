using Azure;
using Azure.Data.Tables;

namespace IceTask1cldv.Models
{
    public class Student : ITableEntity
    {
        public int studentId { get; set; }
        public string firstName { get; set; } 
        public string lastName {  get; set; } 
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}
