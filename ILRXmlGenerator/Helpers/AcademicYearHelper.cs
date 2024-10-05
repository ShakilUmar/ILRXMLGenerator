namespace ILRXmlGenerator.Helpers
{
    public static class AcademicYearHelper
    {
        public static string ConvertAcademicYear(string input)
        {
            int baseYear;

            if (!int.TryParse(input.Substring(0, 2), out baseYear))
            {
                throw new ArgumentException("The first two characters must be numeric.");
            }

            int startYear = 2000 + baseYear;
            int endYear = startYear + 1;

            return $"{startYear}-{endYear.ToString().Substring(2)}";
        }

        public static int CalculateMonthDifference(DateTime startDate, DateTime endDate)
        {
            int monthDifference = (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;

            if (endDate.Day < startDate.Day)
            {
                monthDifference--;
            }

            return monthDifference;
        }
    }
}
