using NUnit.Framework;
using POMFramework.PageObjects;
using POMFramework.Core;

namespace POMFramework
{
    // Main test class

    [TestFixture]
    public class HomepageTest : BaseTest
    {
        private  HomePage Home;
        private  InventoryPage Inventory;
        //private  CheckoutPage Checkout;
        [SetUp]
        public void Init()
        {
            //PageFactory.Init(Driver);
            //Home = (HomePage)PageFactory.CreatePage(Driver,"POMFramework.PageObjects.HomePage");
            //Inventory = (InventoryPage)PageFactory.CreatePage(Driver,"POMFramework.PageObjects.InventoryPage");
            //Checkout = (CheckoutPage)PageFactory.CreatePage(Driver,"POMFramework.PageObjects.CheckoutPage");

            Home = PageFactory.CreatePage<HomePage>(Driver, "POMFramework.PageObjects.HomePage");
            Inventory = PageFactory.CreatePage<InventoryPage>(Driver, "POMFramework.PageObjects.InventoryPage");
        }


        //[Test]
        //[Description("Login Test")]
        //[Author("Kevin Tuck")]

        //public void Valid_Login()
        //{
        //    //PageFactory.Home.GoTo();
        //    //PageFactory.Home.Login();
        //    //PageFactory.Inventory.LogOut();
        //    //Assert.IsTrue(PageFactory.Home.Map.LoginButton.Displayed);
        //    Home.GoTo();
        //    Home.Login();
        //    Inventory.LogOut();

        //    Assert.IsTrue(Home.Map.LoginButton.Displayed);

        //}

        //[Test]
        //[Description("Checkout test")]
        //[Author("Kevin Tuck")]

        //public void Buy_Most_Expensive_Item()
        //{
        //    PageFactory.Home.GoTo();
        //    PageFactory.Home.Login();
        //    PageFactory.Inventory.SortByMostExpensive();
        //    PageFactory.Inventory.AddItemToCart();
        //    PageFactory.Inventory.CheckOut();
        //    PageFactory.Checkout.EnterDetails("Example", "User", "A123");
        //    PageFactory.Checkout.FinishCheckout();

        //    Assert.IsTrue(PageFactory.Checkout.Map.PonyExpressImage.Displayed);
        //}

        [Test]
        [Description("Validate all items can be added to the cart")]
        [Author("Kevin Tuck")]

        public void Add_All_Items_To_Cart()
        {
            //PageFactory.Home.GoTo();
            //PageFactory.Home.Login();
            //PageFactory.Inventory.AddAllItemsToCart();

            //Assert.IsTrue(PageFactory.Inventory.Map.ShoppingCart.Text == "6");
            Home.GoTo();
            Home.Login();
            Inventory.AddAllItemsToCart();

            Assert.IsTrue(Inventory.Map.ShoppingCart.Text == "6");
        }
    }
}
