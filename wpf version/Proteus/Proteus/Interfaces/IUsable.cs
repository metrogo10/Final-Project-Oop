using Proteus.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proteus.Interfaces
{
    public interface IUsable
    {
        ItemEffect[] Use(Character c);
    }
}