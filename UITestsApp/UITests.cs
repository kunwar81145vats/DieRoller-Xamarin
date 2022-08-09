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

            Assert.IsTrue(app.Query(c => c.Marked("d4").Invoke("isChecked")).FirstOrDefault().Equals(true));

            app.Tap(c => c.Marked("d6"));

            Assert.IsTrue(app.Query(c => c.Marked("d6").Invoke("isChecked")).FirstOrDefault().Equals(true));

            app.Tap(c => c.Marked("d8"));

            Assert.IsTrue(app.Query(c => c.Marked("d8").Invoke("isChecked")).FirstOrDefault().Equals(true));

            app.Tap(c => c.Marked("d10"));

            Assert.IsTrue(app.Query(c => c.Marked("d10").Invoke("isChecked")).FirstOrDefault().Equals(true));

            app.Tap(c => c.Marked("d12"));

            Assert.IsTrue(app.Query(c => c.Marked("d12").Invoke("isChecked")).FirstOrDefault().Equals(true));

            app.Tap(c => c.Marked("d20"));

            Assert.IsTrue(app.Query(c => c.Marked("d20").Invoke("isChecked")).FirstOrDefault().Equals(true));
        }

        [Test]
        public void RollButtonsArePresent()
        {
            Assert.IsTrue(app.Query(c => c.Marked("Roll Once")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("Roll Twice")).Any());
        }

        [Test]
        public void RollOnceCanBeTapped()
        {
            app.Tap(c => c.Marked("Roll Once"));

            string resultOneText = app.Query(c => c.Id("ResultOne"))[0].Text;
            int resultVal = int.Parse(resultOneText);

            Assert.NotNull(resultVal);
        }

        [Test]
        public void RollTwiceCanBeTapped()
        {
            app.Tap(c => c.Marked("Roll Twice"));

            string resultOneText = app.Query(c => c.Id("resultOne"))[0].Text;
            int resultVal = int.Parse(resultOneText);

            Assert.NotNull(resultVal);

            string resultTwoText = app.Query(c => c.Id("resultTwice"))[0].Text;
            int resultValTwo = int.Parse(resultTwoText);

            Assert.NotNull(resultValTwo);
        }
    }
}
