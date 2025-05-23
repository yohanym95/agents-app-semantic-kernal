using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace ConsoleApp7;

public class ProductSupportPlugin
{
    [KernelFunction]
    [Description("Retrieve recent product complaints")]
    public string GetComplaints()
    {
        return "Customers report frequent app crashes, rapid battery drain, and a confusing interface.";
    }
}