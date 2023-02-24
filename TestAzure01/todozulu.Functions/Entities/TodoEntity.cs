using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todozulu.Functions.Entities
{
    public class TodoEntity:TableEntity
    {        
        public DateTime CreatedTime { get; set; }
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
