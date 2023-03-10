using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.MSTest.UnitTesting
{
    public class ExceptionHelper
    {
        public string ThankUAllForJoinTrainingProgram(string talks)
        {
            if (string.IsNullOrWhiteSpace(talks))
            {
                throw new ArgumentNullException("None is intrested to talk .. very little i could do...!");
            }
            return "Thank you somuch for talking in training " + talks;
        }
    }
}
