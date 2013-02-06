using System.Collections.Generic;

namespace DevNext.Web.Models.ViewModel
{
    public class EventListView
    {
        public IEnumerable<UserGroupEvent> PastEvents { get; set; }
        public IEnumerable<UserGroupEvent> UpcomingEvents { get; set; }
    }
}