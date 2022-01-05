using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webform.Context;

namespace Webform.Models
{
    public class HomeModel
    {
        public List<product> ListProduct { get; set; }
        public List<category> ListCategory { get; set; }


    }
}