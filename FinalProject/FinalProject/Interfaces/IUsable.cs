using FinalProject.Models1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject.Interfaces
{
    public interface IUsable
    {
        ItemEffect[] Use(Character c);
    }
}