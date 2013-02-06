using DataAnnotationsExtensions.ClientValidation;

[assembly: WebActivator.PreApplicationStartMethod(typeof (DevNext.Web.App_Start.RegisterClientValidationExtensions), "Start")]

namespace DevNext.Web.App_Start
{
    public static class RegisterClientValidationExtensions
    {
        public static void Start()
        {
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();
        }
    }
}