namespace ZiggyRafiq.CodeExample04.FactoryMethodPattern;
public class ConcreteCreator : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct();
    }
}
