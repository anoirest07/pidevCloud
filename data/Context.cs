﻿using System;
using System.Collections.Generic;
using System.domain.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class Context : DbContext
    {
        public Context() : base("name=DB")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
