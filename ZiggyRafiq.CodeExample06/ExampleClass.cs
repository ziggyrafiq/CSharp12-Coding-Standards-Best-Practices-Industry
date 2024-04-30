// Example of using Microsoft.CodeAnalysis.Analyzers
namespace ZiggyRafiq.CodeExample06;
public class ExampleClass
{
    public void ExampleMethod(string input)
    {
        // Potential issue: Unused parameter 'input'
        // Potential issue: Method 'ExampleMethod' is not documented
        // Potential issue: Method 'ExampleMethod' could be made static
        // Potential issue: Variable 'input' is assigned but its value is never used
        Console.WriteLine(input);
    }
}
