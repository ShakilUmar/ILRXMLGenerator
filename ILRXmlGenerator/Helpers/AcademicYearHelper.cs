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
    }
}
