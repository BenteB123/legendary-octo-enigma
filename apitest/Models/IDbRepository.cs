
using apitest.Models;

public interface IDbRepository
{
    // public Task<List<Whish>> GetWhishes();
    public Task<Whish> GetWhish(int id);
    public Task<Whish> CreateWhish(Whish whish);
    // public Task<Whish> UpdateWhish(Whish whish);
    // public Task<Whish> DeleteWhish(int id);
    // public Task<List<Person>> GetPersons();
    // public Task<Person> GetPerson(int id);
    // public Task<Person> CreatePerson(Person person);
    // public Task<Person> UpdatePerson(Person person);
    // public Task<Person> DeletePerson(int id);
    // public Task<List<Group>> GetGroups();
    // public Task<Group> GetGroup(int id);
    // public Task<Group> CreateGroup(Group group);
    // public Task<Group> UpdateGroup(Group group);
    // public Task<Group> DeleteGroup(int id);
    
}