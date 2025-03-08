using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLesson
{
    internal class Cat
    {
        private string _name;
        
        public string Name
        {
            get
            {
                Console.WriteLine("Ura");
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                _name = value;
            }
        }

        public int Height { get; private set; }
        public int Weight { get; set; }
        public string Breed { get; set; }
        public int Sex { get; set; }

        public Cat()
        { }
        
        public Cat(string name)
        {
            Name = name;
        }

        public Cat(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
    }
}
