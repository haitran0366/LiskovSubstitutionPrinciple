using System;

namespace LSP_Ex_
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service1();
            service.DoService();
        }
        // The point is that a Service can be replaced by a Service1.

        //Interface Segregation Principle
    }
}
