using System.ComponentModel.DataAnnotations;
using WebApp.Pages;

namespace WebAppVS.UnitTests
{
    [TestClass]
    public class UnitTestLogin
    {
        [TestMethod]
        public void LoginPasswordShouldBeMandatory()
        {
            var type = typeof(LoginModel);
            var prop = type.GetProperty("Password");

            object[]? attributes = prop?.GetCustomAttributes(true);
            Attribute? required = null;
            foreach (var attr in attributes)
            {
                required = attr as RequiredAttribute;
                if (required != null) break;
            }
            Assert.IsNotNull(required,
                "Lebensmittelretter: Required attribute not set");
        }
    }
}