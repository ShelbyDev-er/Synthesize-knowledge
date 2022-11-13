using Application.DTOs;
using Application.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
	public class PodService : IPodService
	{
		private static readonly List<PodModel> podTypes = new List<PodModel>
		{
			new PodModel
			{
				Id = 1,
				Name = "rodeoOOOO",
				Price = 200,
				IsDeleted = false
			},
			new PodModel
			{
				Id = 2,
				Name = "fizzy",
				Price = 250,
				IsDeleted = false
			},
			new PodModel
			{
				Id = 3,
				Name = "biffbar",
				Price = 3000,
				IsDeleted = true
			}
		};

		public PodResponseDto CreatePod(PodRequestDto data)
		{
			throw new NotImplementedException();
		}

		public List<PodResponseDto> GetAll()
		{

			var result = new List<PodResponseDto>();

			// Mapping from class PodModel -> PodResponseDto
			foreach (var pod in podTypes)
			{
				var podResponse = new PodResponseDto()
				{
					Id = pod.Id,
					Name = pod.Name,
					Price = pod.Price
				};
				result.Add(podResponse);
			}

			return result;	
		}

		public PodResponseDto GetDetails(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdatePod(PodRequestDto data)
		{
			throw new NotImplementedException();
		}
	}

	public class VapeService : IPodService
	{
		public PodResponseDto CreatePod(PodRequestDto data)
		{
			throw new NotImplementedException();
		}

		public List<PodResponseDto> GetAll()
		{
			throw new NotImplementedException();
		}

		public PodResponseDto GetDetails(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdatePod(PodRequestDto data)
		{

		}
	}
}
