using System;
using System.Collections.Generic;

namespace CoreWebMenu.Models
{
    public class TaskViewModel
    {
        public List<TaskModel> tasks { get; set; }
    }
    public class TaskModel
    {
        public string TaskId { get; set; }
        public string TaskNm { get; set; }
        public string TaskUrl { get; set; }
    }
}
