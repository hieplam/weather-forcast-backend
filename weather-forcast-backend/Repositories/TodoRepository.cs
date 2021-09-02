using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace weather_forcast_backend
{
    public interface ITodoRepository
    {
        List<Todo> GetAll();
        Todo GetById(int id);
        bool Create(List<Todo> entitiesToCreate);
        List<Todo> Update(List<Todo> entityToUpdate);
    }

    public class TodoRepository : ITodoRepository
    {
        private readonly AppDbContext dbContext;
        private readonly ILogger<TodoRepository> logger;

        public TodoRepository(AppDbContext dbContext, ILogger<TodoRepository> logger)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }
        public List<Todo> GetAll()
        {
            return dbContext.Todos.ToList();
        }

        public Todo GetById(int id)
        {
            return dbContext.Todos.FirstOrDefault(todo => todo.Id == id);
        }

        public bool Create(List<Todo> entitiesToCreate)
        {
            try
            {
                dbContext.Todos.AddRange(entitiesToCreate);
                dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex, "error when create todos with input:{entitiesToCreate}", entitiesToCreate);
                return false;
            }
        }

        public List<Todo> Update(List<Todo> entityToUpdate)
        {
            try
            {
                dbContext.Todos.UpdateRange(entityToUpdate);
                dbContext.SaveChanges();
                return entityToUpdate;
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex, "error when create todos with input:{entitiesToCreate}", entityToUpdate);
                throw;
            }
        }
    }
}
