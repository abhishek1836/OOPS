/// we can~t create class private/protected but method does



using OOPS_Quespond_Logics;

{
    Patients p1 = new Patients(); // one instance of class or p1 object of class
    Patients p2 = new Patients(); // one instance of class or p2 object of class
    p1.name = "abhishek";
    p2.name = "Ram";
}
{
    Employee employee = new Employee(); // instance of employee class 
    employee.Validate(); /// abstraction happening here
    //abstraction happens during design phase
    //what has to shown public 
    //during excecution phase developer
    //uses encapsulation to implement the abstraction
    //enacapsultion implements abastraction
}
{
    Manager manager = new Manager();
    manager.management(); // inheritance is happeing here
                          // manager is a relationship with employee
}

{
    Hiding p = new ChildHiding(); // parent class refernce variable p
                                  // storing child class object
    p.Show();                    // parent class method will be called
}

{
    Manager overloading = new Manager();
    overloading.Test();
}
{

    Employee e = new Employee(); // polymorphsim
    e.Validate(); // runtime polymorphism
    e = new Supervisor();
    e.Validate(); //runtime polymorphism

}

{
    var v = new someclass(10);
    var v1 = new someclass(20);
    var v2 = v + v1;  /// opeator overloeading
}

{
    ILogics logics = new GoldCustomer1();  /// implementing interface
    logics.productname = "abc";

    ILogics_Logic e = new SilverCustomer1();
    e.Calculateintered();
    e.Calculatediscount();
}

{
    Constructor a = new Constructor(10); // passing valuing in the constuctor
}

{
    CopyConDemo b = new CopyConDemo(10); // passing value in the constructor
    b.dispaly();
    CopyConDemo b1 = new CopyConDemo(b); // copy constructor
    b1.dispaly();
    Console.ReadLine();
}


{
    StaticMeaning o = new StaticMeaning();
    //o.abc();
    StaticMeaning.abc(); /// <summary>
                         ///  static method is created.
                         /// </summary>
   // o.abc();

}


SealedClass a = new SealedClass();
a.Test(12);
