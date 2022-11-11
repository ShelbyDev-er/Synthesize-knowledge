using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUD_training_be.Controllers
{
	[ApiController]
    [Route("[controller]")]
    public class PodController : ControllerBase
    {
		private readonly IPodService _podService;

		public PodController(IPodService podService)
		{
			_podService = podService;
		}

        [HttpGet]
        [Route("")]
        public List<PodResponseDto> GetPodList()
		{
			return _podService.GetAll();
        }
       
		  //      [HttpGet]
		  //      [Route("detail/{id}")]
		  //      public Pod GetPodDetail(int id)
		  //      {
		  //          Pod selectedPod = null;

		  //          foreach(var pod in podTypes)
				//	{
		  //              if (pod.Id == id)
		  //              {
		  //                  selectedPod = pod;
		  //                  break;
		  //              }
				//	}

		  //          return selectedPod;
		  //      }

		  //      [HttpPost]
		  //      [Route("")]
		  //      public Pod PostPodName(Pod data)
		  //      {
		  //          data.Id = podTypes.Count + 1;
		  //          podTypes.Add(data);
            
		  //          return podTypes[podTypes.Count - 1];
		  //      }

				//[HttpPut]
				//[Route("{id}")]
				//public IActionResult UpdatePod(int id, [FromBody] Pod data)
				//{
				//	for(var i = 0; i < podTypes.Count; i++)
				//	{
		  //              if (podTypes[i].Id == id)
				//		{
		  //                  podTypes[i] = data;
		  //                  break;
		  //              }
				//	}

				//	return NoContent();
				//}

				//[HttpDelete]
				//[Route("delete/pod/{id}")]
				//public List<Pod> Delete(int id)
				//{

		  //          // Soft delete vs hard delete
		  //          return podTypes;
			
				//}
	}
}