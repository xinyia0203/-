using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{

    public class Websitelnfo
    {
        public const string SiteName = "课程管理系统";
        public string sitename { get; set; }
        public Websitelnfo()
        {
            sitename = SiteName;
        }
    }
}
