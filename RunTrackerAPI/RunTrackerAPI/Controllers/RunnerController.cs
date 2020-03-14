using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RunTrackerAPI.Models;
using RunTrackerAPI.Services;


namespace RunnersApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class RunnersController : ControllerBase
    {
        private readonly RunnerService _runnerService;

        public RunnersController(RunnerService runnerService)
        {
            _runnerService = runnerService;
        }

        [HttpGet]
        public ActionResult<List<Runner>> Get() =>
            _runnerService.Get();

        [HttpGet("{id:length(24)}", Name = "GetRunner")]
        public ActionResult<Runner> Get(string id)
        {
            var run = new Runner();

            var runner = _runnerService.Get(id);

            if (runner == null)
            {
                return NotFound();
            }

            return run;
        }

        [HttpPost]
        public ActionResult<Runner> Create(Runner runner)
        {
            _runnerService.Create(runner);

            return CreatedAtRoute("GetRunner", new { id = runner.Id.ToString() }, runner);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Runner runnerIn)
        {
            var runner = _runnerService.Get(id);

            if (runner == null)
            {
                return NotFound();
            }

            _runnerService.Update(id, runnerIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var runner = _runnerService.Get(id);

            if (runner == null)
            {
                return NotFound();
            }

            _runnerService.Remove(runner.Id);

            return NoContent();
        }
    }
}