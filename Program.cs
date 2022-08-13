using System;
using Logisticspase;


namespace Lesson3
{
    public class Work
    {   
        public static void Main(string[] arrou)
        {
            Person Dima = new Person(30);
            
            Dima.ChangeConstretirementAge = 105;  // Изменил через свойство пенсионный возраст
                                                  // конкретно для Dima
            
            Console.WriteLine(Dima.ChangeConstretirementAge);// Это для проверки
       
            Dima.CheckAge();
         
        }
       
    }


}

