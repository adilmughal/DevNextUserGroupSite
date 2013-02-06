using System.Web.Configuration;
using Microsoft.Web.WebPages.OAuth;

namespace DevNext.Web.App_Start
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            string twitterConsumerKey = WebConfigurationManager.AppSettings["twitterConsumerKey"];
            string twitterConsumerSecret = WebConfigurationManager.AppSettings["twitterConsumerSecret"];
            string facebookAppId = WebConfigurationManager.AppSettings["facebookAppId"];
            string facebookAppSecretKey = WebConfigurationManager.AppSettings["facebookAppSecretKey"];

            OAuthWebSecurity.RegisterTwitterClient(consumerKey: twitterConsumerKey, consumerSecret: twitterConsumerSecret);
            OAuthWebSecurity.RegisterFacebookClient(appId: facebookAppId, appSecret: facebookAppSecretKey);
        }
    }
}