using AFS_Visa_Processing_System.Models;
using AFS_Visa_Processing_System.Services;
using System.Net.Mail;


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
                VisaApplicationID = 0,
                User = new User()
                {
                    UserID = 1,
                    Role = "Applicant"
                },
                FullLegalName = "Bob Dale Jenkins",
                EmailAddress = "BobDale@gmail.com",
                DateOfBirth = new DateTime(1990, 10, 1),
                ContactNumber = 14567232129517,
                VisaType = VisaType.Business,
                PurposeOfStay = "To start a new business",
                CountryOfOrigin = "Ukraine",
                CountryOfDestination = "United Kingdom",
                Identification = Array.Empty<byte>(),
                ProofOfAddress = Array.Empty<byte>()
            };

            // When CreateApplication is called
            bool result = visaApplicationRepository.CreateVisaApplication(visaApplication);

            // Then it should return true
            Assert.True(result);
        }
    }
}