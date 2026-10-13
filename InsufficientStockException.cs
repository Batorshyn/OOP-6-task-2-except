using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_6_task_2
{
    public class InsufficientStockException: Exception
    {
        public InsufficientStockException(string message) : base(message) { }
    }
}
