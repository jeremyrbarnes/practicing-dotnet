namespace MathOperationsApp;

public class ResultDisplay
{
    public ResultDisplay() { }

    public void Subscribe(MathOperations mathOperations)
    {
        mathOperations.OnAdditionPerformed += DisplayAdditionResult;
        mathOperations.OnSubtractionPerformed += DisplaySubtractionResult;
        mathOperations.OnAMultiplicationPerformed += DisplayMultiplicationResult;
        mathOperations.OnDivisionPerformed += DisplayDivisionResult;
    }

    private void DisplayAdditionResult(object sender, double result)
    {
        Console.WriteLine($"[Display] Addition Result: {result}");
    }

    private void DisplaySubtractionResult(object sender, double result)
    {
        Console.WriteLine($"[Display] Subtraction Result: {result}");
    }

    private void DisplayMultiplicationResult(object sender, double result)
    {
        Console.WriteLine($"[Display] Multiplication Result: {result}");
    }

    private void DisplayDivisionResult(object sender, double result)
    {
        Console.WriteLine($"[Display] Division Result: {result}");
    }
}
