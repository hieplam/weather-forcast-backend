using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weather_forcast_backend
{
    public interface ITodoService
    {
        List<Todo> GetAll();
        Todo GetById(int id);
        bool Create(List<Todo> entitiesToCreate);
        List<Todo> Update(List<Todo> entityToUpdate);
    }
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository repo;
        public TodoService(ITodoRepository repo)
        {
            this.repo = repo;
        }

        public List<Todo> GetAll()
        {
            return repo.GetAll();
        }

        public Todo GetById(int id)
        {
            return repo.GetById(id);
        }
        public bool Create(List<Todo> entitiesToCreate)
        {
            return repo.Create(entitiesToCreate);
        }

        public List<Todo> Update(List<Todo> entityToUpdate)
        {
            return repo.Update(entityToUpdate);
        }
    }
}
