using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataType
{
    class Custom
    {

    }

    struct Person_s
    {
        public int age;
        public string name;

        public Person_s(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }

    class Person_c
    {
        int age;
        string name;

        #region Property
        public int Age
        {
            get { return age;}
            set { age = value;}
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        public Person_c() { }

        public Person_c(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }

}
