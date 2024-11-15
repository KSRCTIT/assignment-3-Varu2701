[AttributeUsage(AttributeTargets.Method)]
public class RequiresPermissionAttribute : Attribute
{
    public string Permission { get; }
    public RequiresPermissionAttribute(string permission)
    {
        Permission = permission;
    }
}
public class HealthcareService
{
    [RequiresPermission("SensitiveDataAccess")]
    public void AccessPatientData()
    {
        // Code to access patient data
        Console.WriteLine("Accessing patient data...");
    }
}
public class HealthcareService
{
    [RequiresPermission("SensitiveDataAccess")]
    public void AccessPatientData()
    {
        // Code to access patient data
        Console.WriteLine("Accessing patient data...");
    }
}
<configuration>
  <runtime>
    <securityPolicy>
      <codeGroup class="UnionCodeGroup" version="1" PermissionSetName="FullTrust">
        <IMembershipCondition class="AllMembershipCondition"/>
      </codeGroup>
    </securityPolicy>
  </runtime>
</configuration>