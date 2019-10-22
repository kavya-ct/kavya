using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public interface Text
    {
        void print();
    }
    public class servic : Text
    {
        public void print()
        {
            Console.WriteLine("print........");
        }
    }
    public class client
    {
        private Text _set;
        public void run(Text serv)
        {
            this._set = serv;
            Console.WriteLine("start");
            this._set.print();
        }
    }
}