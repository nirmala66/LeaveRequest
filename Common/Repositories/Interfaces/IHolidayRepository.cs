using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IHolidayRepository
    {
        List<Holiday> Get();
        Holiday Get(int id);
        bool Insert(HolidayVM holidayVM);
        bool Update(int id, HolidayVM holidayVM);
        bool Delete(int id);
    }
}
