using System;
using System.Collections.Generic;
using System.Text;

namespace vzlet.Models
{
    class RocketLaunchModel
    {
        public int id;
        public string name;
        public string provider_name;
        public string win_open;
        public RocketLaunchModel(int id, string name, string provider_name, string win_open)
        {
            this.id = id;
            this.name = name;
            this.provider_name = provider_name;
            this.win_open = win_open;
        }
    }
}
