using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //var product = new Product
            //{
            //    Name = "Iphone 5",
            //    Price = 1200.00m,
            //    Stock = 5

            //};

            //Binding productBinding = new Binding(); 
            //productBinding.Source = product;
            //productBinding.Path = "Name";

            //Binding nameBinding = new Binding { Source = product, Path = "Name", StringFormat= "Product: {0}" };
            //lblName.SetBinding(Label.TextProperty, nameBinding);

            //Binding priceBinding = new Binding { Source = product, Path = "Price", StringFormat = "Price: {0}" };
            //lblPrice.SetBinding(Label.TextProperty, priceBinding);

            //Binding stockBinding = new Binding { Source = product, Path = "Stock", StringFormat = "Stock: {0}" };
            //lblStock.SetBinding(Label.TextProperty, stockBinding);

            //lblName.SetBinding(Label.TextProperty, productBinding);

        }
    }

}
