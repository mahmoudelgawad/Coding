using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    public class DisposableClass:IDisposable
    {
        ~DisposableClass()
        {
            //incase forgot to call Dispose()
            Dispose(false);
        }

        private void Dispose(bool isDisposingManagemendCode) 
        {
            if (isDisposingManagemendCode) 
            {
             // clean management code objects
            }

            // clean Unmanagement code objects
        }

        public void Dispose() 
        {
            //addition free management code logic
            Dispose(true);

            //ensure the destructor not cllaing and clean the object from first cycle
            GC.SuppressFinalize(this);
        }

    }


}
