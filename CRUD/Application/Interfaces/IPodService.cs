using Application.DTOs;
using Core.Models;
using System.Collections.Generic;

namespace Application.Interfaces
{
	public interface IPodService
	{
		List<PodResponseDto> GetAll();
		PodResponseDto GetDetails(int id);
		PodResponseDto CreatePod(PodRequestDto data);
		void UpdatePod(PodRequestDto data);
	}
}
