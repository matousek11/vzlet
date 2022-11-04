using System;
using System.Collections.Generic;
using System.Text;

namespace vzlet.Models
{
    class RocketLaunchModel
    {
        public int id;
        public string name;
        public int company_id;
        public string slug;
        public RocketLaunchModel(int id, string name, int company_id, string slug)
        {
            this.id = id;
            this.name = name;
            this.company_id = company_id;
            this.slug = slug;
        }
    }
}
