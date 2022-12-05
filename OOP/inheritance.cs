using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BankTermial
    {
        protected string id;

        public BankTermial(string id)
        {
            this.id = id;
        }
        public virtual void Connect()
        {
            Console.WriteLine("General Connection");
        }
    }

    public class ModelXTerminal : BankTermial
    {
        public  ModelXTerminal(string id) : base(id)
            {

            }
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine("Additional connection");
        }
    }

    public class ModelYTerminal : BankTermial
    {
        public ModelYTerminal(string id) : base(id)
        {

        }
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine("Additional connection");
        }
    }
}
