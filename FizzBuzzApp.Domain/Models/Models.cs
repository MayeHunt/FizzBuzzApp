using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp.Domain.Models
{
    public class FizzBuzzRangeRequest
    {
        public int? Start {  get; set; }
        public int? End { get; set; }
    }
}
