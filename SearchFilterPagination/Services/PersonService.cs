using SearchFilterPagination.Models;

namespace SearchFilterPagination.Services
{
    public class PersonService
    {
        private static readonly List<Person> _Person = new()
        {
            new Person { Id = 1, Name = "Alice", Email = "alice@example.com", Department = "HR" },
            new Person { Id = 2, Name = "Bob", Email = "bob@example.com", Department = "IT" },
            new Person { Id = 3, Name = "Charlie", Email = "charlie@example.com", Department = "Finance" },
            new Person { Id = 4, Name = "Diana", Email = "diana@example.com", Department = "HR" },
            new Person { Id = 5, Name = "Eve", Email = "eve@example.com", Department = "IT" },
            new Person { Id = 6, Name = "Frank", Email = "frank@example.com", Department = "Finance" },
            new Person { Id = 7, Name = "Grace", Email = "grace@example.com", Department = "HR" },
            new Person { Id = 8, Name = "Hank", Email = "hank@example.com", Department = "IT" },
            new Person { Id = 9, Name = "Ivy", Email = "ivy@example.com", Department = "Finance" },
            new Person { Id = 10, Name = "Jack", Email = "jack@example.com", Department = "HR" },
            new Person { Id = 11, Name = "Liam", Email = "liam@example.com", Department = "IT" },
            new Person { Id = 12, Name = "Mona", Email = "mona@example.com", Department = "Finance" },
            new Person { Id = 13, Name = "Md Washim Akram", Email = "ws.akram330@email.com", Department = "IT" }
        };

        public Task<List<Person>> GetPeople() => Task.FromResult(_Person);
    }
}
