using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.datagrid.Model
{
     public class Person
    {
        private static object myGrid;

        public string Name { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }


        public static List<Person> GetPeople()
        {
            List<Person> People = new List<Person>();


            var mohammad = new Person()
            {
                Name = "محمد",
                LastName = "عدالت",
                PhoneNumber = "09123456789"
            };
            People.Add(mohammad);


            var mohammadhosein = new Person()
            {
                Name = "محمدحسین",
                LastName = "نصراللهی",
                PhoneNumber = "09129876543"
            };
            People.Add(mohammadhosein);



            return People;
        }
    }
}
