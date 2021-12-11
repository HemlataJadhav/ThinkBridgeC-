using System;
using ClassLibraryDemo;
using static Day5.Event_Demo;
using System.Reflection;


namespace Day5
{

    

    class Program
    {
        

        static void Main(string[] args)
        {

            //int num1 = 5, square,cube;
            //Calculate.Calculations(ref num1,out square,out cube);
            //Console.WriteLine("square:"+square);
            //Console.WriteLine("cube:"+cube);
            //

            //delegates----------------------------------------------

            // Delegates_Demo d1 = new Delegates_Demo();
            // Delegates_Demo.MyDelegate deleobj = new Delegates_Demo.MyDelegate(d1.Addition);//added method reference
            // //int result = deleobj.Invoke(20, 40);
            // //Console.WriteLine("addition::"+result);
            // deleobj += new Delegates_Demo.MyDelegate(d1.sub); //can add reference to the delegate object
            //// int res = deleobj.Invoke(23,3);
            // deleobj+=new Delegates_Demo.MyDelegate(d1.mul);
            // //deleobj -= new Delegates_Demo.MyDelegate(d1.sub);//can subtract reference of the method from delegate object
            // Delegate[] list=deleobj.GetInvocationList();
            // foreach (Delegate item in list)
            // {
            //     Console.WriteLine(item.Method);
            //     Console.WriteLine("res="+item.DynamicInvoke(10,23));

            // }

            //delegate_Event---------------------------------------------
            //Event_Demo event_Demo = new Event_Demo();
            //event_Demo.IsValid += new DisplayMsg(ErrorMsg);
            //int res = event_Demo.AcceptAge(12);
            //Console.WriteLine("age is::"+res);
            //Console.WriteLine(  "--------------------Bank  --------------------");
            Bank bank = new Bank(10000);
            bank.zeroBalDelegate += new ZeroBalDelegate(bank.zeroBalDelegate_Method);
            bank.withdrawDelegate += new WithdrawDelegate(bank.Cant_Withdraw);
            bank.lowBalDelegate += new LowBalDelegate(bank.Low_Bal);




            string checkbal=bank.Check_Bal();
            Console.WriteLine(checkbal);
            string withdraw=bank.AcceptWithdrawAmnt(100);
            Console.WriteLine(withdraw);
            bank.LowBal();

           // string res1 = bank.Less_Bal();
            //string res2 = bank.AcceptWithdrawAmnt(10000);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //string res3 = bank.ZeroBalance();
            //Console.WriteLine("zero bal event called"+res3);
            //Console.WriteLine(bank.Check_Bal());
            //Console.WriteLine("calling zero  bal method:"+bank.ZeroBalance()); 
            //Console.WriteLine("---------------------------------------------");
            ////Bank bank1 = new Bank(20000);
            //bank1.ZeroBal += new DisplayDetails2(bank.ZeroBalance);

            //bank1.LessBal += new DisplayDetails1(bank.Less_Bal);

            //bank1.CantWithdraw += new DisplayDetails(bank.AcceptWithdrawAmnt);


            //string res4 = bank1.ZeroBalance();

            //string res5 = bank1.Less_Bal();
            //string res6 = bank1.AcceptWithdrawAmnt(21000);
            //Console.WriteLine(res5);
            //Console.WriteLine(res6);
            //Console.WriteLine(bank1.Check_Bal());


           // Assembly asm = Assembly.LoadFrom(@"C:\ThinkSchool\ThinkBridgeC-\ClassLibraryDemo\bin\Debug\net5.0\ClassLibraryDemo.dll");
           // Console.WriteLine(asm.FullName);
           //Type[] typelist=asm.GetTypes();
           // foreach(Type type in typelist)
           // {
           //     Console.WriteLine(type.FullName);
           //     MethodInfo[] methodlist=type.GetMethods();
           //     foreach (MethodInfo method in methodlist)
           //     {
           //         Console.WriteLine("\t"+method.ReturnType+"  "+method.Name);
           //         ParameterInfo[] plist = method.GetParameters();
           //         foreach(ParameterInfo p in plist)
           //         {
           //             Console.WriteLine("\t "+p.ParameterType+"  "+p.Name);
           //         }
           //     }
           //     //create object of class then invoke it 
           //     try
           //     {
           //         object obj = asm.CreateInstance(type.FullName);
           //         object result =type.InvokeMember("Addition", BindingFlags.Public | BindingFlags.Instance |
           //             BindingFlags.InvokeMethod, null, obj, new object[] { 10, 20 });
           //         Console.WriteLine("addition is:"+result);
           //     }
           //     catch(Exception ex) { }
           // }
                Console.ReadKey();
        }
           // bank.LessBal += new DisplayDetails(bank.Less_Bal);
            //bank.CantWithdraw += new DisplayDetails(bank.AcceptWithdrawAmnt);






        }


}
