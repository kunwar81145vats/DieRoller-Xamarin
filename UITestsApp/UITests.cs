using System;
using Newtonsoft.Json;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.iOS;
using NUnit.Framework;
using Xamarin.UITest.Queries;
using System.Linq;

namespace UITestApp
{
    [TestFixture(Platform.Android)]

    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void DieOptionsAreAvailable()
        {
            Assert.IsTrue(app.Query(c => c.Marked("d4")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d6")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d8")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d10")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d12")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d20")).Any());
        }

        [Test]
        public void OptionsCanBeChecked()
        {
            app.Tap(c => c.Marked("d4"));
            app.Tap(c => c.Marked("d6"));
            app.Tap(c => c.Marked("d8"));
            app.Tap(c => c.Marked("d10"));
            app.Tap(c => c.Marked("d12"));
            app.Tap(c => c.Marked("d20"));
        }
    }
}
