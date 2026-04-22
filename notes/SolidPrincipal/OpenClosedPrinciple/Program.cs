//Open or Closed Principle 
//class should be open for for extensions but closed for modifications
//You should add new features without modifying existing code

/*
class Discount
{
    public double GetDiscount(String customerType)
    {
        if (customerType == "Regular")
        {
            return amount * 0.1; // 10% discount for regular customers
        }
        else if (customerType == "Premium")
        {
            return amount * 0.2; // 20% discount for premium customers
        }
        else
        {
            return 0;
        }
    }
}*/

interface IdDiscount
{
       double getDiscount();

}
class StudentDiscount : IdDiscount
{
    public getDiscount()>=10
}
class TeacherDiscount : IdDiscount
{
    public getDiscount()>=20
}

