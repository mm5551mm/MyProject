using TechTalk.SpecFlow;

namespace MyProject.E2ETests.Steps;

[Binding]
public class LoginSteps
{
    [Given("user opens login page")]
    public void GivenUserOpensLoginPage()
    {
    }

    [When("user enters valid credentials")]
    public void WhenUserEntersValidCredentials()
    {
    }

    [Then("dashboard page should appear")]
    public void ThenDashboardPageShouldAppear()
    {
    }

    [When("user enters invalid credentials")]
    public void WhenUserEntersInvalidCredentials()
    {
    }

    [Then("error message should appear")]
    public void ThenErrorMessageShouldAppear()
    {
    }

    [When("user clicks login without entering data")]
    public void WhenUserClicksLoginWithoutEnteringData()
    {
    }

    [Then("validation message should appear")]
    public void ThenValidationMessageShouldAppear()
    {
    }
}