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
<<<<<<< HEAD
       // List<Holiday> Get(string value);
=======
  //      List<Holiday> Get(string value);
>>>>>>> remotes/origin/08Agustus
        bool Insert(HolidayVM holidayVM);
        bool Update(int id, HolidayVM holidayVM);
        bool Delete(int id);
    }
}
