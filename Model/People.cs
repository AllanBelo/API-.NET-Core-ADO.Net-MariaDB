namespace ApiDotNetCore.Model
{
    public class People
    {
        //Atributos
        public int PersonID { get;  private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; } 
        public int Age { get; private set; }   
        //Construtor
          public People(int personID, string firstName, string lastName, int age)
          {
                PersonID = personID;
                FirstName =firstName;
                LastName = lastName;
                Age = age;
          }       
    }  
}