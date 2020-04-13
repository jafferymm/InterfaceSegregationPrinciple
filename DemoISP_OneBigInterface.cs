using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{

    public class Document
    {

    }

    //One Big Interface With Lots Functionalities Attached to It
    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    //Only Prints, Yet has to Implement Everything Forceably
    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //Logic Implemented
        }

        public void Print(Document d)
        {
            //UnImplemented, and Not Needed. Needs to be documented in the API
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            //UnImplemented, and Not Needed. Needs to be documented in the API
            throw new NotImplementedException();
        }
    }

    public class DemoISP_OneBigInterface
    {
        static void Main(string[] args)
        {
        }
    }
}
