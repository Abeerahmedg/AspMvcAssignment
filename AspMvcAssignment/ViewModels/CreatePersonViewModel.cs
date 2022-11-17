using AspMvcAssignment.Models;

namespace AspMvcAssignment.ViewModels
{
    public class CreatePersonViewModel
    {
         public string Name { get; set; }
        public int NumberOfBooks { get; set; }
        public string City { get; set; }
        public string Id = Guid.NewGuid().ToString();
       
        public void CreatePerson( string Id, string Name, int NumberOfBooks, string City)
        {
            
            Person person = new Person(Id, Name, NumberOfBooks, City);
            PeopleViewModel.PeopleList.Add(person);
        }
        public static void FillPeople()
        {
            Person p1 = new(Guid.NewGuid().ToString(), "Agatha Christie", 85,"Devon" );
          PeopleViewModel.PeopleList.Add(p1);
          Person p2 = new(Guid.NewGuid().ToString(), "Dan Brown", 7, "New Hampshire");
            PeopleViewModel.PeopleList.Add(p2);
            Person p3 = new(Guid.NewGuid().ToString(), "Yasuo Uchida", 130, "Tokyo");
            PeopleViewModel.PeopleList.Add(p3);
            Person p4 = new(Guid.NewGuid().ToString(), "Ahmed Tawfik", 200, "Tanta");
            PeopleViewModel.PeopleList.Add(p4);


        } 
    }
}
