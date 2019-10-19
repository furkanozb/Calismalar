using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse.Flyweight
{
    public class Character
    {
        protected string symbol;


        public void Display(int pointSize,ListBox listbox)
        {
            listbox.Items.Add(this.symbol + "(pointsize" + pointSize + ")");
        }
    }
    public class CharacterFactor
    {
        private Dictionary<char, Character> _characters = new Dictionary<char, Character>();
        public Character this[char key]
        {
            get
            {
                Character character = null;
                if (_characters.ContainsKey(key))
                {
                    character = _characters[key];
                }
                else
                {
                    string name = this.GetType().Namespace + "." + "Character" + key.ToString();
                    character = (Character)Activator.CreateInstance(Type.GetType(name));
                }
                return character;
            }
        }

    }
    public class CharacterA : Character
    {
        public CharacterA()
        {
            symbol = "-.";
        }
    }
    public class CharacterB : Character
    {
        public CharacterB()
        {
            symbol = "-...";
        }
    }
    public class CharacterC : Character
    {
        public CharacterC()
        {
            symbol = "-.-.";
        }
    }
    public class CharacterD : Character
    {
        public CharacterD()
        {
            symbol = "-..";
        }
    }
    public class CharacterE : Character
    {
        public CharacterE()
        {
            symbol = ".";
        }
    }
    public class CharacterF : Character
    {
        public CharacterF()
        {
            symbol = "..-.";
        }
    }
    public class CharacterG : Character
    {
        public CharacterG()
        {
            symbol = "--.";
        }
    }
    public class CharacterH : Character
    {
        public CharacterH()
        {
            symbol = "....";
        }
    }
    public class CharacterI : Character
    {
        public CharacterI()
        {
            symbol = "..";
        }
    }
    public class CharacterJ : Character
    {
        public CharacterJ()
        {
            symbol = ".---";
        }
    }
    public class CharacterK : Character
    {
        public CharacterK()
        {
            symbol = "-.-";
        }
    }
    public class CharacterL : Character
    {
        public CharacterL()
        {
            symbol = ".-..";
        }
    }
    public class CharacterM : Character
    {
        public CharacterM()
        {
            symbol = "--";
        }
    }
    public class CharacterN : Character
    {
        public CharacterN()
        {
            symbol = "-.";
        }
    }

    public class CharacterT : Character
    {
        public CharacterT()
        {
            symbol = "-";
        }
    }
    public class CharacterU : Character
    {
        public CharacterU()
        {
            symbol = "..-";
        }
    }
    public class CharacterV : Character
    {
        public CharacterV()
        {
            symbol = "...-";
        }
    }
    public class CharacterW : Character
    {
        public CharacterW()
        {
            symbol = ".--";
        }
    }
    public class CharacterX : Character
    {
        public CharacterX()
        {
            symbol = "-..-";
        }
    }
    public class CharacterY : Character
    {
        public CharacterY()
        {
            symbol = "-.--";
        }
    }
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            symbol = "--..";
        }
    }


    public class CharacterO : Character
    {
        public CharacterO()
        {
            symbol = "---";
        }
    }
    public class CharacterP : Character
    {
        public CharacterP()
        {
            symbol = ".--.";
        }
    }
    public class CharacterQ : Character
    {
        public CharacterQ()
        {
            symbol = "--.-";
        }
    }
    public class CharacterR : Character
    {
        public CharacterR()
        {
            symbol = ".-.";
        }
    }
    public class CharacterS : Character
    {
        public CharacterS()
        {
            symbol = "...";
        }
    }


    public class Character1 : Character
    {
        public Character1()
        {
            symbol = "-..-";
        }
    }
    public class Character2 : Character
    {
        public Character2()
        {
            symbol = "..---";
        }
    }
    public class Character3 : Character
    {
        public Character3()
        {
            symbol = "...--";
        }
    }
    public class Character4 : Character
    {
        public Character4()
        {
            symbol = "....-";
        }
    }
    public class Character5 : Character
    {
        public Character5()
        {
            symbol = ".....";
        }
    }
    public class Character6 : Character
    {
        public Character6()
        {
            symbol = "-....";
        }
    }
    public class Character7 : Character
    {
        public Character7()
        {
            symbol = "--...";
        }
    }
    public class Character8 : Character
    {
        public Character8()
        {
            symbol = "---..";
        }
    }
    public class Character9 : Character
    {
        public Character9()
        {
            symbol = "----.";
        }
    }
    public class Character0 : Character
    {
        public Character0()
        {
            symbol = "-----";
        }
    }
}


