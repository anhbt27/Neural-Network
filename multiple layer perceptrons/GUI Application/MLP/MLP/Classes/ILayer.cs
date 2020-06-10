using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Classes
{
    interface ILayer
    {
        ILayer NextLayer { get; set; }
        double[,] Output { get; set; }
        double[,] Error { get; set; }
        double[,] getWeighMatrix();
        void FeedForward(double[,] Input);
    }
}
