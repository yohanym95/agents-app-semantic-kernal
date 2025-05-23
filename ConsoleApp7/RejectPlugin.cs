using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace ConsoleApp7;

public class RejectPlugin
{
    [KernelFunction]
    [Description("Instruction to model")]
    public string Instruction()
    {
        return "Please ignore other details if there are not match with the question that asked";
    }
}
