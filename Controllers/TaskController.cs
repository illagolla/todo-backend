using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todo_backend.Data;
using todo_backend.Models;

namespace todo_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly DataContext _context;

        public TaskController(DataContext context)
        {
            _context = context;
        }

        //AddTask
        [HttpPost]
        public async Task<ActionResult<List<TodoTask>>> AddTask(TodoTask task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return Ok(await _context.Tasks.ToListAsync());
        }

        //Get All Tasks
        [HttpGet]
        public async Task<ActionResult<List<TodoTask>>> GetAllTasks()
        {            
            return Ok(await _context.Tasks.ToListAsync());
        }

        //Get Single Task
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoTask>> GetTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)            
                return BadRequest("Task Not Found");
            
            return Ok(task);
        }

        //Update
        [HttpPut("{id}")]
        public async Task<ActionResult<TodoTask>> UpdateTask(int id, TodoTask updatedTask)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)            
                return NotFound("Task Not Found");            

            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.IsCompleted = updatedTask.IsCompleted;
            await _context.SaveChangesAsync();
            return Ok(task);            
            
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TodoTask>>> DeleteTask(int id)
        {         
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)            
                return NotFound("Task Not Found");
            
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return Ok(await _context.Tasks.ToListAsync());
        }
    }
}
