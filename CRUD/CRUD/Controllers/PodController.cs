using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CRUD_training_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class podController : ControllerBase
    {
        private static readonly List<Pod> podTypes = new List<Pod>
        {
            new Pod
			{
                Id = 1,
                Name = "rodeo",
                Price = 200
			},
            new Pod
            {
                Id = 2,
                Name = "fizzy",
                Price = 250
            },
            new Pod
            {
                Id = 3,
                Name = "biffbar",
                Price = 3000,
                IsDeleted = false
            }
        };

        private readonly ILogger<podController> _logger;

        public podController(ILogger<podController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public List<Pod> GetPodList(){
            return podTypes;
        }
       
        [HttpGet]
        [Route("detail/{id}")]
        public Pod GetPodDetail(int id)
        {
            Pod selectedPod = null;

            foreach(var pod in podTypes)
			{
                if (pod.Id == id)
                {
                    selectedPod = pod;
                    break;
                }
			}

            return selectedPod;
        }

        [HttpPost]
        [Route("")]
        public Pod PostPodName(Pod data)
        {
            data.Id = podTypes.Count + 1;
            podTypes.Add(data);
            
            return podTypes[podTypes.Count - 1];
        }

		[HttpPut]
		[Route("{id}")]
		public IActionResult UpdatePod(int id, [FromBody] Pod data)
		{
			for(var i = 0; i < podTypes.Count; i++)
			{
                if (podTypes[i].Id == id)
				{
                    podTypes[i] = data;
                    break;
                }
			}

			return NoContent();
		}

		[HttpDelete]
		[Route("delete/pod/{id}")]
		public List<Pod> Delete(int id)
		{

            // Soft delete vs hard delete
            return podTypes;
			
		}
	};

    public class Pod
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public int Price { get; set; }
		public bool IsDeleted { get; set; }
	}
}