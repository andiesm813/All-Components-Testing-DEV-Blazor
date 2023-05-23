using Bunit;
using Microsoft.Extensions.DependencyInjection;
using All_Components_Testing_DEV.Pages;
using All_Components_Testing_DEV.Northwind;
using All_Components_Testing_DEV.Financial;

namespace TestAll_Components_Testing_DEV
{
	[Collection("All-Components Testing DEV")]
	public class TestView_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbGridModule),
				typeof(IgbTreeModule),
				typeof(IgbAvatarModule),
				typeof(IgbChipModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbCheckboxModule),
				typeof(IgbSwitchModule),
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule),
				typeof(IgbRatingModule),
				typeof(IgbSliderModule),
				typeof(IgbListModule),
				typeof(IgbDatePickerModule),
				typeof(IgbInputModule),
				typeof(IgbSelectModule),
				typeof(IgbTabsModule),
				typeof(IgbCalendarModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<View_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}