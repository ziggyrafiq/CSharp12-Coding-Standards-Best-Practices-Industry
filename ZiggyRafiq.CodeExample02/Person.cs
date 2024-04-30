namespace ZiggyRafiq.CodeExample02;

/// <summary>
/// Represents a person.
/// </summary>
public class Person
{
    /// <summary>
    /// Gets or sets the person's name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    public Person()
    {
        // Default constructor
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the person.</param>
    public Person(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Gets the person's name.
    /// </summary>
    /// <returns>The name of the person.</returns>
    public string GetName()
    {
        return Name;
    }

    /// <summary>
    /// Sets the person's name.
    /// </summary>
    /// <param name="name">The name of the person.</param>
    public void SetName(string name)
    {
        Name = name;
    }
}

