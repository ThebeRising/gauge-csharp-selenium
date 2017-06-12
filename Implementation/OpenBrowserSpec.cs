using System;
using System.Collections.Generic;
using System.Linq;

using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;

using GaugeCsharpSelenium.Implementation.Pages;

namespace GaugeCsharpSelenium.Implementation
{
    class SearchSpec
    {
        

        [Step("Open the browser")]
        public void OpenBrowser()
        {
          DriverFactory.Driver.Visit(OpenBrowserPage.localServer);
        }

        public void someFunction()
        {

        }

    }
}
