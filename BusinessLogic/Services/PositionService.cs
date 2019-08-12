using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class PositionService : IPositionService
    {
        bool status = false;

        private readonly IPositionRepository _positionRepository;
        public PositionService(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }
        public List<Position> Get()
        {
            var result = _positionRepository.Get();
            return result;
        }

        public Position Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _positionRepository.Get(id);
                return result;
            }
        }

        public bool Insert(PositionVM positionVM)
        {
            if (string.IsNullOrWhiteSpace(positionVM.Name))
            {
                return status;
            }
            else
            {
                var result = _positionRepository.Insert(positionVM);
                return result;
            }
        }
    }
}
