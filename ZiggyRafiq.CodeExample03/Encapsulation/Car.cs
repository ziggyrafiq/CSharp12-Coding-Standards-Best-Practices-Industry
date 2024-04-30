namespace ZiggyRafiq.CodeExample03.Encapsulation;

public class Car
{
    private string _model;

    public string Model
    {
        get { return _model; }
        private set
        {
            // Add validation if necessary
            _model = value;
        }
    }
    
    public Car(string model)
    {
        Model = model; // Using the property setter for encapsulation
    }

 
}