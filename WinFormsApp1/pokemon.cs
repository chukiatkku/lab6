using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class pokemon
    {
        protected int id;
        protected string name;
        protected string name2;
        protected Image pic;
        protected int level;
        protected PokemonType type;
        protected PokemonAbilities abilities;
        protected int hp;
        protected int att;
        protected int def;
        protected int sAtt;
        protected int sDef;
        protected int speed;

        public string Name()
        {
            return name;
        }
        public Image picture()
        {
            return pic;
        }
    }

    
    public enum PokemonType {
        Grass,Poison,Electr,fairy,normal,water,dragon
    }
    public enum PokemonAbilities { 
        Overgrow,chlorophyII,lightning, Forecast, Anticipation, GaleWings, Protosynthesis, SwiftSwim, SuperLuck
    }
}
