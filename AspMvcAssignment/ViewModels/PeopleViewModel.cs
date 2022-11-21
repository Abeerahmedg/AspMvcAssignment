
using AspMvcAssignment.Models;

namespace AspMvcAssignment.ViewModels
{
    public class PeopleViewModel
    {
        public static List<Person> PeopleList = new List<Person>();
       // public string Search { get; set; }
        public List<Person> tempList = new List<Person>();

        public static void FillPeople()
        {
            Person p1 = new(Guid.NewGuid().ToString(), "Agatha Christie", 85, "Devon");
            PeopleViewModel.PeopleList.Add(p1);
            Person p2 = new(Guid.NewGuid().ToString(), "Dan Brown", 7, "New Hampshire");
            PeopleViewModel.PeopleList.Add(p2);
            Person p3 = new(Guid.NewGuid().ToString(), "Yasuo Uchida", 130, "Tokyo");
            PeopleViewModel.PeopleList.Add(p3);
            Person p4 = new(Guid.NewGuid().ToString(), "Ahmed Tawfik", 200, "Tanta");
            PeopleViewModel.PeopleList.Add(p4);

            //Person p = new() { Id = Guid.NewGuid().ToString(), Name = "Agatha Christie", NumberOfBooks = 85, City = "Devon" };
            //PeopleList.Add(p);
            //p = new() { Id = Guid.NewGuid().ToString(), Name = "Dan Brown", NumberOfBooks = 7, City = "New Hampshire" };
            //PeopleList.Add(p);
            //p = new() { Id = Guid.NewGuid().ToString(), Name = "Yasuo Uchida", NumberOfBooks = 130, City = "Tokyo" };
            //PeopleList.Add(p);
            //p = new() { Id = Guid.NewGuid().ToString(), Name = "Ahmed Tawfik", NumberOfBooks = 200, City = "Tanta" };
            //PeopleList.Add(p);

        }

    }
}
