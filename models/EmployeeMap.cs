namespace InCamp_CsvProcessor.models
{
    class EmployeeMap : CsvHelper.Configuration.ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Map(m => m.EmployeeName).Name("Employee Name");
            Map(m => m.Date).Name("Date");
            Map(m => m.Hours).Name("Work Hours");
        }
    }
}
