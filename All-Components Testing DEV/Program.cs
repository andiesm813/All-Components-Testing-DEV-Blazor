using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using All_Components_Testing_DEV;
using All_Components_Testing_DEV.Northwind;
using All_Components_Testing_DEV.Financial;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<INorthwindService>(sp => new NorthwindService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<IFinancialService>(sp => new FinancialService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbButtonModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbCardModule),
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
        typeof(IgbCalendarModule)
    );
}