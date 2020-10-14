using ApiDotNetCore.Model;
namespace PeopleAPI.Repository
{
    public interface IPeopleRepository
    {
           //Metodos impostos para classe que implementam a interface
         public People GetPeople(int PersonID);
    }
}