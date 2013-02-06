using System.Linq;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using System.Xml;

namespace DevNext.Web.Controllers
{
    public class BlogFeedController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            const string devNextFeed = "http://feeds.feedburner.com/Devnext";
            const string eDotNetDevsFeed = "http://edotnetdevs.wordpress.com/feed/";
            SyndicationFeed devNextRssData;
            SyndicationFeed eDotNetDevsRssData;

            using (XmlReader reader = XmlReader.Create(devNextFeed))
            {
                devNextRssData = SyndicationFeed.Load(reader);
            }

            using (XmlReader reader = XmlReader.Create(eDotNetDevsFeed))
            {
                eDotNetDevsRssData = SyndicationFeed.Load(reader);
            }

            if (eDotNetDevsRssData != null && devNextRssData != null)
                return View(devNextRssData.Items.Concat(eDotNetDevsRssData.Items).OrderByDescending(item => item.PublishDate).Take(20).ToList());

            return View();
        }
    }
}