using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoApp.Options
{
    public class EmailSettingOptions
    {
        public bool EnableEmailSystem { get; set; }
        public int EmailTimeoutInSeconds { get; set; }
        public List<string> EmailServer{ get; set; } = new List<string>();
        public AdminOptions EmailAdmin { get; set; } = new AdminOptions();
    }
}
