using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Microsoft.Dynamics365.UIAutomation.Api.UCI.Elements
{
    public class Subgrid : Element
    {
        private readonly WebClient _client;

        private IWebElement gridContainer;

        public Subgrid(WebClient client)
        {
            _client = client;
        }

        public void SelectSubgrid(int index)
        {
            gridContainer = (IWebElement)_client.SelectSubGrid(index);
        }
    }
}
