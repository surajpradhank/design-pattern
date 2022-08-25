namespace FactoryDesignPattern;

public interface IEmployeeManager
{
    string GetBonus();
    string GetPay();
}
public class ContractEmployeeManager : IEmployeeManager
{
    public string GetBonus()
    {
        return "Contract Employee : 10,000";
    }

    public string GetPay()
    {
        return "Contract Employee : 20,000";
    }
}
public class PermanentEmployeeManager : IEmployeeManager

{
    public string GetBonus()
    {
        return "Permanent Employee : 30,000";
    }
    
    public string GetPay()
    {
        return "Permanent Employee : 40,000";
    }
}

public class EmployeeManagerFactory
{
    public  IEmployeeManager GetEmployeeManager(int employeeTypeID)
    {
        IEmployeeManager employeeManager;

        switch (employeeTypeID)
        {
            case 1:
                employeeManager = new PermanentEmployeeManager();
                return employeeManager;
            case 2:
                employeeManager = new ContractEmployeeManager();
                return employeeManager;

            // Now in the future if we have new Employee Type then we can add new case and
            // implement the new EEmployee Type

            default:
                throw new ApplicationException("Employee can not be created");
        }
    }
}


