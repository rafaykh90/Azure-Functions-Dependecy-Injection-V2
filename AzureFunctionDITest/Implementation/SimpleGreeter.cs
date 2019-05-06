using System;
using AzureFunctionDITest.Interfaces;

namespace AzureFunctionDITest.Implementation
{
    public class SimpleGreeter : IGreeter
    {
        public string CreateGreetings(string name)
        {
            return $"Hello {name} from the Greeter";
        }
    }
}
