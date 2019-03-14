using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class LinearRegression<T> where T : struct
    {
        private Dictionary<T,T> data;
        private double a;
        private double b;

        public LinearRegression(Dictionary<T, T> data)
        {
            this.data = data;
        }

        private void train()
        {
            dynamic AvgX = data.Average(s=>(dynamic)s.Key);
            dynamic AvgY = data.Average(s => (dynamic)s.Value);
            var tmpL = 0.0;
            var tmpM = 0.0;

            foreach (KeyValuePair<T, T> cur in data)
            {
                tmpL += cur.Value * (cur.Key - AvgX);
                tmpM += Math.Pow(cur.Key - AvgX, 2);
            }
            this.a = tmpL/tmpM;
            this.b = AvgY - AvgX * this.a;
        }

        public void Test (Dictionary<T,T> testData)
        {
            foreach (KeyValuePair<T, T> currnet in testData)
                Console.WriteLine("Value: {0} Value predicted : {1}", currnet.Value,Predict(currnet.Key));
        }

        public T Predict(T dataToPredict)
        {
            train();
            dynamic dataPr = dataToPredict;
            return (T)(this.a * dataPr + this.b);
        }

        public override string ToString()
        {
            return "y= "+this.a + " x + " + this.b;
        }
    }
}
