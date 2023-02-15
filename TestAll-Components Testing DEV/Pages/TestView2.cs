using Bunit;
using Microsoft.Extensions.DependencyInjection;
using All_Components_Testing_DEV.Pages;

namespace TestAll_Components_Testing_DEV
{
	public class TestView2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<View2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}