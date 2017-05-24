﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject.Interfaces
{
    public interface IEquipable
    {
        void Equip(Character c );
        void Remove(Character c);
    }
}