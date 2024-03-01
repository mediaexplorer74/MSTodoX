using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.Graph;

namespace MSTodoX.Model
{
    public class TodoItem
    {
        public string id { get; set; }
        public string subject { get; set; }
        public bool isCompleted { get; set; }

        public override string ToString() => subject;
    }
}
