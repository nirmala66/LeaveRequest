using BusinessLogic.Services.Interfaces;
using Common.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
   public class HolidayService:IHolidayService
    {
        bool status = false;
        private readonly IHolidayRepository _holidayRepository;
        public HolidayService(IHolidayRepository holidayRepository)
        {
            _holidayRepository = holidayRepository;
        }
        public HolidayService() { }

        public List<Holiday> Get()
        {
            var result = _holidayRepository.Get();
            return result;
        }

        public Holiday Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _holidayRepository.Get(id);
                return result;
            }
        }

        public bool Insert(HolidayVM holidayVM)
        {
            if (string.IsNullOrWhiteSpace(holidayVM.HolidayName)||string.IsNullOrWhiteSpace(holidayVM.Day)||
                string.IsNullOrWhiteSpace(holidayVM.HolidayDate.ToString()))
            {
                return status;
            }
            else
            {
                var result = _holidayRepository.Insert(holidayVM);
                return result;

            }
        }

        public bool Update(int id, HolidayVM holidayVM)
        {
            if (string.IsNullOrWhiteSpace(holidayVM.HolidayName) || string.IsNullOrWhiteSpace(holidayVM.Day) ||
                 string.IsNullOrWhiteSpace(holidayVM.HolidayDate.ToString()))
            {
                return status;
            }
            else
            {
                var result = _holidayRepository.Update(id,holidayVM);
                return result;

            }
        }

        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _holidayRepository.Delete(id);
                return result;
            }
        }
    }
}
