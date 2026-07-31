using Azure;
using Azure.Data.Tables;

namespace IceTask1cldv.Models

{
    public class Course : ITableEntity
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string PartitionKey {  get; set; }
        public string RowKey { get; set; }

     
        public ETag ETag { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
    }
}
