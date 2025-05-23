using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace ConsoleApp7;

public class SummarizerPlugin
{
    [KernelFunction]
    [Description("Summarize complaints and suggest improvements")]
    public string SummarizeAndSuggest(string input)
    {
        return $"Summary: {input.Substring(0, Math.Min(60, input.Length))}...\n" +
               "Suggestions: Fix crashes, optimize battery usage, and improve UI clarity.";
    }
}