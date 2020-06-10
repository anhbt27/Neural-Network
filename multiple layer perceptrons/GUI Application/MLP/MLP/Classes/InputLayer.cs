using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Classes
{
    class InputLayer : ILayer
    {
        public ILayer NextLayer { get; set; }
        public double[,] Output { get; set; }
        public double[,] Error { get; set; }
        public void FeedForward(double[,] Input)
        {
            Output = Input;
            if (NextLayer != null)
            {
                NextLayer.FeedForward(Output);
            }
        }

        public double[,] getWeighMatrix()
        {
            return null;
        }
    }
}
