
using AspMvcAssignment.Models;

namespace AspMvcAssignment.ViewModels
{
    public class PeopleViewModel
    {
        public List<Person> PeopleList { get; set; } = new List<Person>();
        public string Search { get; set; } = string.Empty;
        public List<Person> tempList { get; set; } = new List<Person>();

        public CreatePersonViewModel cpvm { get; set; } = new();


        public void FillPeople()
        {
            Person p1 = new(Guid.NewGuid().ToString(), "Agatha Christie", 85, "Devon");
            PeopleList.Add(p1);
            Person p2 = new(Guid.NewGuid().ToString(), "Dan Brown", 7, "New Hampshire");
            PeopleList.Add(p2);
            Person p3 = new(Guid.NewGuid().ToString(), "Yasuo Uchida", 130, "Tokyo");
            PeopleList.Add(p3);
            Person p4 = new(Guid.NewGuid().ToString(), "Ahmed Tawfik", 200, "Tanta");
            PeopleList.Add(p4);

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
