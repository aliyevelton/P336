using System.Runtime.InteropServices;

namespace PersonClass
{
    public class Person
    {
        public string name;
        public string surname;
        public int Age { get; set; }
        public string Name 
        {
            get => name;
            set
            {
                char firstLetter;
                firstLetter = value[0];
                if (char.IsUpper(firstLetter))
                {
                    if (value.Length >= 3 && value.Length <= 30)
                    {
                        name = value;
                    }
                }
                
            }
        }
        public string Surname 
        { 
            get => surname;
            set
            {
                char firsLetter = surname[0];
                if (char.IsUpper(firsLetter))
                {
                    surname = value;
                }
            }
        }
    }

    public class Student : Person
    {
        
        private int point;
        public int Point
        {
            get => point;
            set
            {
                if (value != 0)
                {
                    if (value >= 0 && value <= 100)
                    {
                        point = value;
                    }
                    else point = -1;

                }
                else point = -1;
            }
        }
    }
}
