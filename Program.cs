using System;
using System.Collections.Generic;
namespace ConsoleApp4
{
        class Program
        {
            static void Main(string[] args)
            {
                List<Person> Human = new List<Person>();
                for (int i = 0; i < 6; i++)
                {
                    Human.Add(new Person());
                    Human[i].Input();
                    int age = Human[i].Age();
                    if (age <= 16)
                    {
                        Human[i].Change_name("Very Young");
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    Human[i].Output();
                }
                for (int i = 0; i < 6; i++)
                {

                    if (i == 5)
                    {
                        break;
                    }
                    for (int j = 0; j < 6; j++)
                    {
                        if (Human[i] == Human[j] && i != j)
                        {
                            Console.WriteLine("People with the same names: ");
                            Human[i].Output();
                            Human[j].Output();
                        }

                    }
                }
                Console.ReadLine();
            }
        }
        class Person
        {
            private string name;
            private DateTime birthday_year;

            public Person(string b, int a)
            {
                this.name = b;
                DateTime year = new DateTime(a, 1, 1, 1, 1, 1);
                this.birthday_year = year;
            }
            public Person()
            {
                this.name = "Ann";
                this.birthday_year = new DateTime(2010, 1, 1, 1, 1, 1);
            }
            public string Name
            {
                get
                {
                    return this.name;
                }
            }
            public DateTime Birthyear
            {
                get
                {
                    return this.birthday_year;
                }
            }
            public void Input()
            {
                Console.WriteLine("Enter name: ");
                this.name = Console.ReadLine();
                Console.WriteLine("Enter the year of birth: ");
                int a = Convert.ToInt32(Console.ReadLine());
                DateTime year = new DateTime(a, 1, 1, 1, 1, 1);
                this.birthday_year = year;
            }
            public void Output()
            {
                this.ToString();
            }
            public void ToString()
            {
                Console.WriteLine("Name: {0}\nBirthday year: {1}", this.name, this.birthday_year.Year);
            }
            public int Age()
            {
                DateTime now = DateTime.Today;
                int age = now.Year - this.birthday_year.Year;
                Console.WriteLine("Age: {0}", age);
                return age;
            }
            public void Change_name(string New_name)
            {
                this.name = New_name;
            }
            public static bool operator ==(Person first, Person second)
            {
                return first.name == second.name;
            }
            public static bool operator !=(Person first, Person second)
            {
                return !(first == second);
            }
        }
    }
