using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    class ProblemDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public ProblemDescriptionAttribute(string description)
        {
            this.Description = description;
        }
    }
}
