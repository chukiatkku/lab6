using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Magikarp : pokemon
    {
        public Magikarp()
        {
            name = "Magikarp";
            id = 1;
            level = 1;
            type = PokemonType.water;
        }
    }
}
