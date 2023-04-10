using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto_Beauty365.Models
{
    public class DB365Context : DbContext
    {

        public DB365Context() : base("BeautyConDB")
        {
        }



    }
}