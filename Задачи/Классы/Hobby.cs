using System;
using System.Collections.Generic;

namespace Задачи
{
    internal class Hobby
    {
        public delegate void HobbyDelegate(Hobbys hobby, List<Person> person);
        public static void Reaction(Hobbys hobby, List<Person> person)
        {
            for (int i = 0; person.Count > i; i++)
            {
                if (person[i].hobby.Equals(hobby))
                {
                    Console.WriteLine($"{person[i].name} кричит от радости");
                }
            }
        }
    }
}
