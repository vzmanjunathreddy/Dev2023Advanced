using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.MSTest.UnitTesting
{
    [TestClass]
    public class ExcpectExceptionsTest
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TrainingTest()
        {
            ExceptionHelper exceptionHelper = new ExceptionHelper();

            exceptionHelper.ThankUAllForJoinTrainingProgram("");

         
        }
    }
}
