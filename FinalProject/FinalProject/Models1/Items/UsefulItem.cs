﻿using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject.Models1.Items
{
    public class UsefulItem : Item, IUsable
    {
        decimal stat = new decimal();
        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}