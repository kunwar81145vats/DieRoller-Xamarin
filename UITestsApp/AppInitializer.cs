using Xamarin.UITest;

namespace UITestApp
{
    static class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {

            return ConfigureApp
                .Android
                .InstalledApp("com.companyname.dieroller")
                .StartApp();
        }
    }
}

