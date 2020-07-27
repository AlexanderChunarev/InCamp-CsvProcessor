namespace InCamp_CsvProcessor.models
{
    class EmployeeMap : CsvHelper.Configuration.ClassMap<Employee>
    {
        private const string EMPLOYEE_NAME = "Employee Name";
        private const string DATE = "Date";
        private const string WORK_HOURS = "Work Hours";

        public EmployeeMap()
        {
            Map(m => m.Name).Name(EMPLOYEE_NAME);
            Map(m => m.Date).Name(DATE);
            Map(m => m.Hours).Name(WORK_HOURS);
        }
    }
}
