using System.Collections.Generic;
using System.Web.Mvc;

namespace DevNext.Web.Helpers
{
    public class TimeList
    {
        private static IEnumerable<SelectListItem> _timeList = new List<SelectListItem>
            {
                new SelectListItem {Text = "12:00 AM", Value = "12:00:00 AM"},
                new SelectListItem {Text = "12:30 AM", Value = "12:30:00 AM"},
                new SelectListItem {Text = "01:00 AM", Value = "01:00:00 AM"},
                new SelectListItem {Text = "01:30 AM", Value = "01:30:00 AM"},
                new SelectListItem {Text = "02:00 AM", Value = "02:00:00 AM"},
                new SelectListItem {Text = "02:30 AM", Value = "02:30:00 AM"},
                new SelectListItem {Text = "03:00 AM", Value = "03:00:00 AM"},
                new SelectListItem {Text = "03:30 AM", Value = "03:30:00 AM"},
                new SelectListItem {Text = "04:00 AM", Value = "04:00:00 AM"},
                new SelectListItem {Text = "04:30 AM", Value = "04:30:00 AM"},
                new SelectListItem {Text = "05:00 AM", Value = "05:00:00 AM"},
                new SelectListItem {Text = "05:30 AM", Value = "05:30:00 AM"},
                new SelectListItem {Text = "06:00 AM", Value = "06:00:00 AM"},
                new SelectListItem {Text = "06:30 AM", Value = "06:30:00 AM"},
                new SelectListItem {Text = "07:00 AM", Value = "07:00:00 AM"},
                new SelectListItem {Text = "07:30 AM", Value = "07:30:00 AM"},
                new SelectListItem {Text = "08:00 AM", Value = "08:00:00 AM"},
                new SelectListItem {Text = "08:30 AM", Value = "08:30:00 AM"},
                new SelectListItem {Text = "09:00 AM", Value = "09:00:00 AM"},
                new SelectListItem {Text = "09:30 AM", Value = "09:30:00 AM"},
                new SelectListItem {Text = "10:00 AM", Value = "10:00:00 AM"},
                new SelectListItem {Text = "10:30 AM", Value = "10:30:00 AM"},
                new SelectListItem {Text = "11:00 AM", Value = "11:00:00 AM"},
                new SelectListItem {Text = "11:30 AM", Value = "11:30:00 AM"},
                new SelectListItem {Text = "12:00 PM", Value = "12:00:00 PM"},
                new SelectListItem {Text = "12:30 PM", Value = "12:30:00 PM"},
                new SelectListItem {Text = "01:00 PM", Value = "01:00:00 PM"},
                new SelectListItem {Text = "01:30 PM", Value = "01:30:00 PM"},
                new SelectListItem {Text = "02:00 PM", Value = "02:00:00 PM"},
                new SelectListItem {Text = "02:30 PM", Value = "02:30:00 PM"},
                new SelectListItem {Text = "03:00 PM", Value = "03:00:00 PM"},
                new SelectListItem {Text = "03:30 PM", Value = "03:30:00 PM"},
                new SelectListItem {Text = "04:00 PM", Value = "04:00:00 PM"},
                new SelectListItem {Text = "04:30 PM", Value = "04:30:00 PM"},
                new SelectListItem {Text = "05:00 PM", Value = "05:00:00 PM"},
                new SelectListItem {Text = "05:30 PM", Value = "05:30:00 PM"},
                new SelectListItem {Text = "06:00 PM", Value = "06:00:00 PM"},
                new SelectListItem {Text = "06:30 PM", Value = "06:30:00 PM"},
                new SelectListItem {Text = "07:00 PM", Value = "07:00:00 PM"},
                new SelectListItem {Text = "07:30 PM", Value = "07:30:00 PM"},
                new SelectListItem {Text = "08:00 PM", Value = "08:00:00 PM"},
                new SelectListItem {Text = "08:30 PM", Value = "08:30:00 PM"},
                new SelectListItem {Text = "09:00 PM", Value = "09:00:00 PM"},
                new SelectListItem {Text = "09:30 PM", Value = "09:30:00 PM"},
                new SelectListItem {Text = "10:00 PM", Value = "10:00:00 PM"},
                new SelectListItem {Text = "10:30 PM", Value = "10:30:00 PM"},
                new SelectListItem {Text = "11:00 PM", Value = "11:00:00 PM"},
                new SelectListItem {Text = "11:30 PM", Value = "11:30:00 PM"},
            };

        public static IEnumerable<SelectListItem> TimeSelectList { get; private set; }
    }
}