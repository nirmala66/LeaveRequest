using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class HolidayVM
{
    public string HolidayName { get; set; }
    public string Day { get; set; }
    public DateTime? HolidayDate { get; set; }

    public HolidayVM() { }

    public HolidayVM(string holidayname, string day, DateTime? holidaydate)
    {
        this.HolidayName = holidayname;
        this.Day = day;
        this.HolidayDate = holidaydate;
    }

    public void Update(string holidayname, string day, DateTime? holidaydate)
    {
        this.HolidayName = holidayname;
        this.Day = day;
        this.HolidayDate = holidaydate;
    }
}