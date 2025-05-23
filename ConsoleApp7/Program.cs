using ConsoleApp7;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Planning;

var builder = Kernel.CreateBuilder();

// Add OpenAI API Key and model for LLM functionality
builder.AddAzureOpenAIChatCompletion(
        "gpt-4o-2024-11-20",
        "API",
        "key")
    .Build();

// Register plugins for task execution
builder.Plugins.AddFromType<ProductSupportPlugin>();
builder.Plugins.AddFromType<SummarizerPlugin>();

var kernel = builder.Build();

// Create the Stepwise Planner


// Define the user's goal
string userGoal = "Summarize recent product complaints and suggest improvements.";
Console.WriteLine($"🧠 User Goal: {userGoal}");

#pragma warning disable SKEXP0060
var planner = new FunctionCallingStepwisePlanner();
#pragma warning restore SKEXP0060

Console.WriteLine("\n📋 Generating Plan...");

// Create the plan dynamically
#pragma warning disable SKEXP0060
var plan = await planner.ExecuteAsync(kernel, userGoal);

#pragma warning restore SKEXP0060


// Output the final result
#pragma warning disable SKEXP0060
Console.WriteLine("\n✅ Final Output:\n" + plan.FinalAnswer);
#pragma warning restore SKEXP0060
