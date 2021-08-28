using FitnessAppMVC.Data;
using FitnessAppMVC.Form.Exercises;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessAppMVC.Controllers
{
    [ApiController]
    [Route("exercises")]
    //[Authorize(Roles = "administrator")]  // так будет доступ к контроллеру только у роли administrator
    public class ExercisesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ExercisesController(ApplicationDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        // этот запрос из ссылки. тут только отдается вьюха
        [HttpGet("/create")]
        public async Task<IActionResult> CreateNewView(CreateNewExercisesForm form) 
        {
            return View("CreateNew");
        }


        // это запрос из вьюхи
        [HttpPost("")]
        public async Task<IActionResult> CreateNew(CreateNewExercisesForm form)
        {
            var entity = await _dbContext.Exercises.AddAsync(new Models.Workout.Exercise
            {
                Name = form.Name,
                WorkoutType = form.WorkoutType
            });

            await _dbContext.SaveChangesAsync();

            return Json(entity.Entity.Id);
        }
    }
}
