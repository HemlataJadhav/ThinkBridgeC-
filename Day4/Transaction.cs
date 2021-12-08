using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public interface ICustomer
    {
        string PrintDetails();
    }
    public interface IOrder
    {
        string PrintDetails();
    }
    public class Transaction : ICustomer, IOrder
    {

        //string PrintDetails();
        string ICustomer.PrintDetails()
        {
            throw new NotImplementedException();
        }

        string IOrder.PrintDetails()
        {
            throw new NotImplementedException();
        }
    }

}
