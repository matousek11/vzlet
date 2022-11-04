using System;
using System.Collections.Generic;
using System.Text;

namespace vzlet.Models
{
    class MissionModel
    {
        public string mission_name;
        public string company_name;
        public MissionModel(string mission_name, string company_name)
        {
            this.mission_name = mission_name;
            this.company_name = company_name;
        }
    }
}
