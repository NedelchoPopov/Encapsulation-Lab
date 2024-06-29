using System;
/*
5
Brandi Anderson 65
Andrew Williams 57
Newton Holland 27
Andrew Clark 44
Brandi Scott 35

5
Andrew Williams 65 2200
Newton Holland 57 3333
Rachelle Nelson 27 600
Brandi Scott 44 666.66
George Miller 35 559.4
20

5
Andrew Williams -6 2200
B Gomez 57 3333
Carolina Richards 27 670
Gilbert H 44 666.66
Joshua Anderson 35 300
20

5
Andrew Williams 20 2200
Newton Holland 57 3333
Rachelle Nelson 27 600
Grigor Dimitrov 25 666.66
Brandi Scott 35 555

*/
namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)

            {

                var cmdArgs = Console.ReadLine().Split();
                try 
                {
                    var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //persons.OrderBy(p => p.FirstName)

            //.ThenBy(p => p.Age)

            //.ToList()

            //.ForEach(p => Console.WriteLine(p.ToString()));
            //var parcentage = decimal.Parse(Console.ReadLine());

            //persons.ForEach(p => p.IncreaseSalary(parcentage));

            //persons.ForEach(p => Console.WriteLine(p.ToString()));
            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {

                team.AddPlayer(person);

            }

            Console.WriteLine(team.ToString());
        }
    }
}
