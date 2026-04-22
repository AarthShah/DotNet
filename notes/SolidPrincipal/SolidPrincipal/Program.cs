            
            //Solid principal
            //it  is object oriented design principle
            //helps to write maintainable,clean preusable code
            //S= Single Responsibility principle
            //O= open or closed principle
            //L=Liskov substitution Principle
            //I=Interface segrigation Principle
            //D=Dependency Inversion Principle


            //Single Responsibility Principle (SRP)
            //A class should have only one reason to change
            //Onle class should do only one job (if class has more than one responsibilitythen it is hard to maintain)


class Student
{
    public string Name { get; set; }
    public void SaveStudentData ()
    {

        //Students data in DB
    }
    public void PrintReport()
    {
        //
    }
    //this is bad example to write SRP 
}