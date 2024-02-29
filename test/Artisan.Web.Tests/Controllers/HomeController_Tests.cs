using System.Threading.Tasks;
using Artisan.Models.TokenAuth;
using Artisan.Web.Controllers;
using Shouldly;
using Xunit;

namespace Artisan.Web.Tests.Controllers
{
    public class HomeController_Tests: ArtisanWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}