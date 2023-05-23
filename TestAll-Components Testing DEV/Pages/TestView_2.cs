using Bunit;
using Microsoft.Extensions.DependencyInjection;
using All_Components_Testing_DEV.Pages;

namespace TestAll_Components_Testing_DEV
{
	[Collection("All-Components Testing DEV")]
	public class TestView_2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule));
			var componentUnderTest = ctx.RenderComponent<View_2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}