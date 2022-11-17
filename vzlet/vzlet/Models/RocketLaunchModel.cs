using System;
using System.Collections.Generic;
using System.Text;

namespace vzlet.Models
{
    class RocketLaunchModel
    {
        public int id;
        public string name;
        public string providerName;
        public string winOpen;
        public RocketLaunchModel(int id, string name, string providerName, string winOpen)
        {
            this.id = id;
            this.name = name;
            this.providerName = providerName;
            this.winOpen = winOpen;
        }
    }
}
