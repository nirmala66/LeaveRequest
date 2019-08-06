using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Holiday: BaseModel
{ 
    public string HolidayName{get;set;}
    public string Day{get;set;}
    public DateTime? HolidayDate{get;set;}

    public Holiday(){}

    public Holiday(HolidayVM holidayVM)
    {
        this.HolidayDate=holidayVM.HolidayDate;
        this.HolidayName=holidayVM.HolidayName;
        this.Day=holidayVM.Day;
        this.CreateDate=DateTimeOffset.Now.LocalDateTime;
    }
    public void Update(HolidayVM holidayVM)
    {
        this.HolidayDate=holidayVM.HolidayDate;
        this.HolidayName=holidayVM.HolidayName;
        this.Day=holidayVM.Day;
        this.UpdateDate=DateTimeOffset.Now.LocalDateTime;
    }
    public void Delete()
    {
        this.IsDelete=true;
        this.DeleteDate=DateTimeOffset.Now.LocalDateTime;
    }
}
