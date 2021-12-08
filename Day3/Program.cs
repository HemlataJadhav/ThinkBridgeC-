using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object for date class
            //Date date = new Date();
            ////date.SetData();
            //Console.WriteLine(date);

            ////second object for date class
            //Date date1 = new Date(10,"dec",2021);
            ////pass parameters using object initializer
            ////Date date1=new Date { }
            //Console.WriteLine(date1) ;

            ////Student student = new Student();
            //student.SetData();
            //Console.WriteLine(student.GetData());

            //creating object for employee class
            //Employee employee = new Employee();
            // //employee.Display();
            //Employee employee1 = new Employee( "arjun", 63452);
            //           // employee1.Display();
            //Console.WriteLine(employee);
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine(employee1);
            //Console.WriteLine("----------------------");
            //Employee employee2 = new Employee();
            //Console.WriteLine(employee2);
            //Console.ReadKey();
            ///
            //creating object for PropertiesDemo class


            //PropertiesDemo propertiesdemo = new PropertiesDemo();
            //propertiesdemo.Rollno = 11;
            //propertiesdemo.Student_name = "raj";
            //Console.WriteLine(propertiesdemo);

            //creating object for area of circle and rectangle

            //AreaOf_Ciicle_Rectangle aeaOf_Ciicle_Rectangle = new AreaOf_Ciicle_Rectangle(5,3,45);
            //Console.WriteLine(aeaOf_Ciicle_Rectangle);

            //Auto_Implemented_Property auto_Implemented_Property = new Auto_Implemented_Property();
            //auto_Implemented_Property.englishmarks = 76;
            //auto_Implemented_Property.mathmarks = 96;
            //auto_Implemented_Property.sciencemarks = 78;
            //Console.WriteLine(auto_Implemented_Property);

            //creating object for Method_overloading class
            //Method_Overloading method_Overloading = new Method_Overloading();
            //method_Overloading.Addition(20, 10);
            //method_Overloading.Addition(20, 10, 30);
            //method_Overloading.Addition(20.34, 24.65);
            //method_Overloading.Addition(12, 34.32);
            //Console.ReadKey();

            Inheritance_Demo inheritance_Demo = new Inheritance_Demo("test4", 53426, 4576);
            inheritance_Demo.CalculateSalary();
            Console.WriteLine(inheritance_Demo);

            Product_Manager product_Manager = new Product_Manager("abc", 5242, 243, 5476);
            product_Manager.NetDeduction();
            Console.WriteLine(product_Manager);
            Console.ReadKey();

        }
       }
    }
