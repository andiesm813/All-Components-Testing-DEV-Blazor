using Bunit;
using Microsoft.Extensions.DependencyInjection;
using All_Components_Testing_DEV.Shared;

namespace TestAll_Components_Testing_DEV
{
	[Collection("All-Components Testing DEV")]
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbNavbarModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbButtonModule),
				typeof(IgbNavDrawerModule));
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}