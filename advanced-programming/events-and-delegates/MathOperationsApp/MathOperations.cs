namespace MathOperationsApp;

public class MathOperations
{
    public MathOperations() { }

    public EventHandler<double>? OnAdditionPerformed;
    public EventHandler<double>? OnSubtractionPerformed;
    public EventHandler<double>? OnAMultiplicationPerformed;
    public EventHandler<double>? OnDivisionPerformed;


    public void Add(double a, double b)
    {
        double result = a + b;
        OnAdditionPerformed?.Invoke(this, result);
    }
    public void Subtract(double a, double b)
    {
        double result = a - b;
        OnSubtractionPerformed?.Invoke(this, result);
    }
    public void Multiply(double a, double b)
    {
        double result = a * b;
        OnAMultiplicationPerformed?.Invoke(this, result);
    }
    public void Divide(double a, double b)
    {
        if (b == 0)
        {
            return;
        }
        double result = a / b;
        OnDivisionPerformed?.Invoke(this, result);
    }
}
