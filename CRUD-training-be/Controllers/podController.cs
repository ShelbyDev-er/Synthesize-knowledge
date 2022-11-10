using Microsoft.AspNetCore.Mvc;

namespace CRUD_training_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class podController : ControllerBase
    {
        private static readonly List<string> PodType = new List<string>
        {
            "dot", "redeo", "fizzy", "biffbar"
        };

        private readonly ILogger<podController> _logger;

        public podController(ILogger<podController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public List<string> GetPodList(){
            return PodType;
    }
        [HttpGet]
        [Route("detail/{id}")]
        public string GetPodDetail(int id)
        {
            return PodType[id];
        }

        [HttpPost]
        [Route("add/podName/{PodName}")]
        public string PostPodName(string PodName)
        {
            PodType.Add(PodName);
            return "";
        }

        [HttpDelete]
        [Route("delete/pod/{id}")]
        public string Delete(int id)
        {
            PodType.RemoveAt(id);
            return "";
        }

        [HttpPut]
        [Route("update/podName/{id}&{PodName}")]
        public string UpdatePod(int id, string PodName)
        {
            for(int i = 0; i < PodType.Count; i++)
            {
                if(PodType[i] == PodType[id])
                {
                    PodType[i] = PodName;
                }
            }
            return "";
        }
    };
}