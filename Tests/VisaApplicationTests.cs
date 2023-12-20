using AFS_Visa_Processing_System.Models;
using AFS_Visa_Processing_System.Services;


namespace VisaProcessingTests
{
    public class VisaApplicationTests
    {
        VisaApplicationRepository visaApplicationRepository = new VisaApplicationRepository();

        // Given I am logged into the system.

        // When I submit the the specified documents and information

        // Then I should be notified that the application has been submitted successfully.
        [Fact]
        public void CreateVisaApplicationTest()
        {
            // Given a valid VisaApplication object

            VisaApplication visaApplication = new VisaApplication()
            { 
                
            };

            // When CreateApplication is called
            bool result = visaApplicationRepository.CreateVisaApplication(visaApplication);

            // Then it should return true
            Assert.True(result);
        }
        [Fact]
        public void GetVisaApplicationTest()
        {
            // Given a VisaApplicationRepository service

            // When GetVisaApplicationByID is called with the parameter 1
            VisaApplication result = visaApplicationRepository.GetVisaApplicationByID(1);

            // Then it should return a single populated VisaApplication object
            Assert.NotNull(result);
        }
    }
}