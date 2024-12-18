using Rosu_Lucian_Lab11x.Data;

namespace Rosu_Lucian_Lab11x
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; } = null!;
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
