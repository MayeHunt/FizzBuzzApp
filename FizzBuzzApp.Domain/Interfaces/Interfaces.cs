using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp.Domain.Interfaces
{
    public interface IFizzBuzzService
    {
        string GetFizzBuzz(int number);
    }
}
