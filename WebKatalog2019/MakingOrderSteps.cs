using System;
using TechTalk.SpecFlow;

namespace WebKatalog2019
{
    [Binding]
    public class MakingOrderSteps
    {
        [Given(@"I Login with Username '(.*)' and Password '(.*)'")]
        public void GivenILoginWithUsernameAndPassword(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I make new order")]
        public void GivenIMakeNewOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I search for specific item with specific number '(.*)'")]
        public void GivenISearchForSpecificItemWithSpecificNumber(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I add item to order with amounts of : fv '(.*)', par '(.*)', WZ '(.*)'")]
        public void GivenIAddItemToOrderWithAmountsOfFvParWZ(string p0, string p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press realize order")]
        public void WhenIPressRealizeOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"\?")]
        public void Then()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
