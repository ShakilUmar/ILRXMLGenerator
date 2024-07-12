using ILRXmlGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Xml;
using System.Xml.Linq;
using ILRXmlGenerator.Helpers;

namespace ILRXmlGenerator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new UserDetails();

            // Predefined academic years
            ViewBag.AcademicYears = new List<SelectListItem>
        {
            new SelectListItem { Value = "2324", Text = "2324" },
            new SelectListItem { Value = "2425", Text = "2425" }
        };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(UserDetails userDetails)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            // Re-populate the dropdown list if the form is re-displayed due to validation errors
            ViewBag.AcademicYears = new List<SelectListItem>
        {
            new SelectListItem { Value = "2324", Text = "2324" },
            new SelectListItem { Value = "2425", Text = "2425" }
        };

            return View(userDetails);
        }

        public IActionResult Success()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateXml(UserDetails userDetails)
        {
            if (ModelState.IsValid)
            {
                var xmlDocument = new XDocument(
                    new XElement("Message",
                        new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                        new XAttribute(XNamespace.Xmlns + "xsd", "http://www.w3.org/2001/XMLSchema"),
                        new XAttribute(XNamespace.Xmlns + "test", "ESFA/ILR/" + AcademicYearHelper.ConvertAcademicYear(userDetails.AcademicYear)),
                        new XElement("Header",
                            new XElement("CollectionDetails",
                                new XElement("Collection", "ILR"),
                                new XElement("Year", userDetails.AcademicYear),
                                new XElement("FilePreparationDate", DateTime.Now.Date.ToString("yyyy-MM-dd"))
                            ),
                            new XElement("Source",
                                new XElement("ProtectiveMarking", "OFFICIAL-SENSITIVE-Personal"),
                                new XElement("UKPRN", userDetails.UKPRN),
                                new XElement("SoftwareSupplier", "Software Supplier"),
                                new XElement("SoftwarePackage", "Software Package"),
                                new XElement("Release", "Release"),
                                new XElement("SerialNo", "1"),
                                new XElement("DateTime", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"))
                            )
                        ),
                        new XElement("LearningProvider",
                            new XElement("UKPRN", userDetails.UKPRN)
                        ),
                        new XElement("Learner",
                            new XElement("LearnRefNumber", userDetails.ULN),
                            new XElement("ULN", userDetails.ULN),
                            new XElement("FamilyName", userDetails.FamilyName),
                            new XElement("GivenNames", userDetails.GivenName),
                            new XElement("DateOfBirth", userDetails.DateOfBirth.ToString("yyyy-MM-dd")),
                            new XElement("Ethnicity", "31"),
                            new XElement("Sex", "F"),
                            new XElement("LLDDHealthProb", "2"),
                            new XElement("NINumber", "LJ000000A"),
                            new XElement("PostcodePrior", "M9 4EU"),
                            new XElement("Postcode", "M9 4EU"),
                            new XElement("AddLine1", "18 Address line road"),
                            new XElement("AddLine2", "Amington"),
                            new XElement("TelNo", "07855555555"),
                            new XElement("Email", "myemail@myemail.com"),
                            new XElement("PriorAttain",
                                new XElement("PriorLevel", "2"),
                                new XElement("DateLevelApp", "2021-04-17")
                            ),
                            new XElement("LearnerEmploymentStatus",
                                new XElement("EmpStat", "10"),
                                new XElement("DateEmpStatApp", "2019-04-17"),
                                new XElement("EmpId", "915862549"),
                                new XElement("EmploymentStatusMonitoring",
                                    new XElement("ESMType", "EII"),
                                    new XElement("ESMCode", "8")
                                ),
                                new XElement("EmploymentStatusMonitoring",
                                    new XElement("ESMType", "LOE"),
                                    new XElement("ESMCode", "4")
                                )
                            ),
                            new XElement("LearnerEmploymentStatus",
                                new XElement("EmpStat", "10"),
                                new XElement("DateEmpStatApp", "2022-11-15"),
                                new XElement("EmpId", "906662877"),
                                new XElement("EmploymentStatusMonitoring",
                                    new XElement("ESMType", "EII"),
                                    new XElement("ESMCode", "8")
                                ),
                                new XElement("EmploymentStatusMonitoring",
                                    new XElement("ESMType", "LOE"),
                                    new XElement("ESMCode", "4")
                                )
                            ),
                            new XElement("LearningDelivery",
                                new XElement("LearnAimRef", "ZPROG001"),
                                new XElement("AimType", "1"),
                                new XElement("AimSeqNumber", "1"),
                                new XElement("LearnStartDate", userDetails.LearnStartDate.ToString("yyyy-MM-dd")),
                                new XElement("LearnPlanEndDate", userDetails.LearnPlanEndDate.ToString("yyyy-MM-dd")),
                                new XElement("FundModel", "36"),
                                new XElement("PHours", "324"),
                                new XElement("OTJActHours", "344"),
                                new XElement("ProgType", "25"),
                                new XElement("StdCode", userDetails.StdCode),
                                new XElement("DelLocPostCode", "WS15 3JQ"),
                                new XElement("EPAOrgID", "EPA0061"),
                                new XElement("CompStatus", "2"),
                                new XElement("LearnActEndDate", "2024-08-15"),
                                new XElement("Outcome", "1"),
                                new XElement("AchDate", "2024-04-25"),
                                new XElement("SWSupAimId", "0c29a200c9d14749a90ce04a5b202ca6"),
                                new XElement("LearningDeliveryFAM",
                                    new XElement("LearnDelFAMType", "SOF"),
                                    new XElement("LearnDelFAMCode", "105")
                                ),
                                new XElement("LearningDeliveryFAM",
                                    new XElement("LearnDelFAMType", "RES"),
                                    new XElement("LearnDelFAMCode", "1")
                                ),
                                new XElement("LearningDeliveryFAM",
                                    new XElement("LearnDelFAMType", "ACT"),
                                    new XElement("LearnDelFAMCode", "2"),
                                    new XElement("LearnDelFAMDateFrom", "2023-08-15"),
                                    new XElement("LearnDelFAMDateTo", "2024-08-15")
                                ),
                                new XElement("AppFinRecord",
                                    new XElement("AFinType", "TNP"),
                                    new XElement("AFinCode", "1"),
                                    new XElement("AFinDate", "2023-08-15"),
                                    new XElement("AFinAmount", "3500")
                                ),
                                new XElement("AppFinRecord",
                                    new XElement("AFinType", "PMR"),
                                    new XElement("AFinCode", "1"),
                                    new XElement("AFinDate", "2023-08-15"),
                                    new XElement("AFinAmount", "291")
                                ),
                                new XElement("AppFinRecord",
                                    new XElement("AFinType", "TNP"),
                                    new XElement("AFinCode", "2"),
                                    new XElement("AFinDate", "2023-08-15"),
                                    new XElement("AFinAmount", "500")
                                )
                            ),
                            new XElement("LearningDelivery",
                                new XElement("LearnAimRef", "60152680"),
                                new XElement("AimType", "3"),
                                new XElement("AimSeqNumber", "2"),
                                new XElement("LearnStartDate", "2023-08-15"),
                                new XElement("LearnPlanEndDate", "2024-08-15"),
                                new XElement("FundModel", "36"),
                                new XElement("ProgType", "25"),
                                new XElement("StdCode", userDetails.StdCode),
                                new XElement("DelLocPostCode", "WS15 3JQ"),
                                new XElement("CompStatus", "2"),
                                new XElement("LearnActEndDate", "2024-08-15"),
                                new XElement("Outcome", "1"),
                                new XElement("SWSupAimId", "d2400c387a9d5647b260ecdb80867c55"),
                                new XElement("LearningDeliveryFAM",
                                    new XElement("LearnDelFAMType", "SOF"),
                                    new XElement("LearnDelFAMCode", "105")
                                )
                            )
                        )
                    )
                );


                var fileName = $"ILR-{userDetails.UKPRN}-{userDetails.AcademicYear}-{DateTime.Now.ToString("yyyyMMdd")}-000001-1.xml";

                var settings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "    "
                };

                using var xmlWriter = XmlWriter.Create(fileName, settings);
                xmlDocument.Save(xmlWriter);
            }

            return View("Index", userDetails);
        }
    }
}
