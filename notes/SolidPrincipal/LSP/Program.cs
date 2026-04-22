//if b is child of a we should we should be able to use b everywhere
class Bird
{
    public virtual void fly()
    {

    }
}
class Ostrich:Bird
{
    public override void fly()
    {
        
    }

}
class Sparrow : IFlyingBird
{
    public void fly() { }
}

interface IBird
{

}
interface IFlyingBird
{
    void fly();
}

