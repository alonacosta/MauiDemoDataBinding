using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding.Pages;

public partial class NotifyBinding : ContentPage
{
	Product product = new Product();
	public NotifyBinding()
	{
		InitializeComponent();

		product = new Product 
		{
			Name = "iPhone 5",
			Price = 2000.00m,
			Stock = 5
		};
		BindingContext = product;
	}

    private async void btnUpdate_Clicked(object sender, EventArgs e)
    {
		product.Name = "Galaxy Samsung 10";
		product.Price = 4000.00m;
		product.Stock = 5;

		await DisplayAlert("Product Updated",
			$"{product.Name} - {product.Price} - {product.Stock}", "Ok");
    }
}