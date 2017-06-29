using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_V2
{
    /// <summary>
    /// This is the Person Super Class
    /// </summary>
    /// 
    class Person
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _name;
        private int _age;


        // PUBLIC PROPERTIES -------------------------------------------------------------------------------------------
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                this._age = value;
            }
        }

        // CONSTRUCTORS --------------------------------------------------------------------------------------------

        /// <summary>
        /// This is the constructor for the person class.  Ths constructor requires two arguements - name (string) and age (int).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // PUBLIC METHODS ------------------------------------------------------------------------------------------

        /// <summary>
        /// This method enables the person to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name + " is talking!");
        }
    }
}
