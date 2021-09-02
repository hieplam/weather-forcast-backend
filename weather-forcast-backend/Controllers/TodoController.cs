using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weather_forcast_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> logger;
        private readonly ITodoService todoService;
        public TodoController(ILogger<TodoController> logger, ITodoService todoService)
        {
            this.logger = logger;
            this.todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = todoService.GetAll();
                var res = new TodoResponse
                {
                    Data = result,
                    IsSuccess = true,
                    Message = "success"
                };
                return new JsonResult(res);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error when get all todo");
                return BadRequest(new TodoResponse
                {
                    IsSuccess = false,
                    Message = "unexpected error, please try again"
                });
            }   
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = todoService.GetById(id);
                var res = new TodoResponse
                {
                    IsSuccess = true,
                    Data = result,
                    Message = result == null ? "no record found" : "success",
                };
                return new JsonResult(res);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error when get todo by id: {id}", id);
                return BadRequest(new TodoResponse
                {
                    IsSuccess = false,
                    Message = "unexpected error, please try again"
                });
            }
        }
       
        [HttpPost]
        public IActionResult Create(List<Todo> entityToCreate)
        {
            try
            {
                var result = todoService.Create(entityToCreate);
                var res = new TodoResponse
                {
                    IsSuccess = true,
                    Message = result ? "create success" : "create failed",
                };
                return new JsonResult(res);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error when create todo entity: {entityToCreate}", entityToCreate);
                return BadRequest(new TodoResponse
                {
                    IsSuccess = false,
                    Message = "unexpected error, please try again"
                });
            }
        }

        [HttpPut]
        public IActionResult Update(List<Todo> entityToUpdate)
        {
            try
            {
                var result = todoService.Update(entityToUpdate);
                var res = new TodoResponse
                {
                    IsSuccess = true,
                    Message ="update success",
                    Data = result,
                };
                return new JsonResult(res);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "error when update todo entity: {entityToUpdate}", entityToUpdate);
                return BadRequest(new TodoResponse
                {
                    IsSuccess = false,
                    Message = "unexpected error, please try again"
                });
            }
        }
        public class TodoResponse
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
            public object Error { get; set; }
            public object Data { get; set; }
        }
    }
}
