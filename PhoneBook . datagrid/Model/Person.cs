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


            var saber = new Person()
            {
                Name = "صابر",
                LastName = "عدالت",
                PhoneNumber = "09129876541"
            };
            People.Add(saber);


            var saeid = new Person()
            {
                Name = "سعید",
                LastName = "انصاری",
                PhoneNumber = "09129876542"
            };
            People.Add(saeid);


            var hamed = new Person()
            {
                Name = "حامد",
                LastName = "عزیزی",
                PhoneNumber = "09129876544"
            };
            People.Add(hamed);


            var morteza = new Person()
            {
                Name = "مرتضی",
                LastName = "انصاری",
                PhoneNumber = "09129876545"
            };
            People.Add(morteza);


            var vali = new Person()
            {
                Name = "ولی",
                LastName = "اسدی",
                PhoneNumber = "09129876546"
            };
            People.Add(vali);


            var ali = new Person()
            {
                Name = "علی",
                LastName = "نصراللهی",
                PhoneNumber = "09129876547"
            };
            People.Add(ali);


            var mostafa = new Person()
            {
                Name = "مصطفی",
                LastName = "جعفری",
                PhoneNumber = "09129876548"
            };
            People.Add(mostafa);


            var mohammad2 = new Person()
            {
                Name = "محمد",
                LastName = "جعفری",
                PhoneNumber = "09129876549"
            };
            People.Add(mohammad2);



            return People;
        }
    }
}
