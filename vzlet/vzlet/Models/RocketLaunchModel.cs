using System;
using System.Collections.Generic;
using System.Text;

namespace vzlet.Models
{
    class RocketLaunchModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public string WinOpen { get; set; }
        public RocketLaunchModel(int id, string name, string providerName, string winOpen)
        {
            this.Id = id;
            this.Name = name;
            this.ProviderName = providerName;
            this.WinOpen = winOpen;
        }
    }
}
