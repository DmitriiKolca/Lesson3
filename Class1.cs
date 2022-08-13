using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logisticspase
{
    public class Person
    {
        public static int retirementAge = 65;

        int enteredByUserAge;

        public int ChangeConstretirementAge 
        {
            set
            {
                if (value < 100 && value > 1)  
                { 
                    retirementAge = value;
                }                    
                else 
                {
                    retirementAge=65;
                    Console.WriteLine("Неверно введет пенсионный возраст");                    
                }                  
            }
            get
            {
                return retirementAge;
            }
        }// Свойство замены статической переменной пенсионного возраста

        public Person (int EnteredByUserAge)
        {
            enteredByUserAge = EnteredByUserAge;
            Console.WriteLine($"Конструктор введенный пользователем возраст {enteredByUserAge}");
        }// конструктор

        public void CheckAge() 
        {
            if (enteredByUserAge >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"До пенсионного возраста еще {retirementAge - enteredByUserAge}");

        } // Функция логики, возраст до пенсии
    }
}
