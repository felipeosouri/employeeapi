namespace Common.Extensions
{
    public static class Extensions
    {
        public static decimal GetAnnualSalary(this decimal amount, string ContractType)
        {
            decimal annualSalary = 0;

            if (ContractType == "Monthly")
                annualSalary = amount * 12;
            else if (ContractType == "Hourly")
                annualSalary = 120 * amount * 12;
            else
                annualSalary = 0;

            return annualSalary;
        }
    }
}
