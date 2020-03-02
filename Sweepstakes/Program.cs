using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Sweepstakes_test")]
namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            ContestantInformationCollectionTool ctool = new ContestantInformationCollectionTool();
            ctool.CollectValidatedEmail();
        }
    }
}
