using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Jett jett= new Jett();
            Reyna reyna= new Reyna();
            Raze raze= new Raze();  
            Neon neon= new Neon();
            Yoru yoru= new Yoru();
            Phoenix phoenix= new Phoenix();

            jett.entry();
            reyna.entry();
            raze.entry();   
            neon.entry();       
            yoru.entry();
            phoenix.entry();

            Console.ReadKey();
        }
    }
    class ValorantDuelist
    {
        public virtual void entry()
        {
            Console.WriteLine("The duelist goes in site");
        }
    }
    class Jett : ValorantDuelist
    {
        public override void entry()
        {
            Console.WriteLine("Jett dashes in");
        }

    }
    class Reyna : ValorantDuelist
    {
        public override void entry()
        {
            Console.WriteLine("Reyna kills an enemy");
        }
    }
    class Raze : ValorantDuelist
    {
        public override void entry()
        {
            Console.WriteLine("Raze satchels in");
        }
    }
    class Neon : ValorantDuelist
    {
        public override void entry()
        {
            Console.WriteLine("Neon runs and slides behind the enemy");
        }
    }
    class Yoru : ValorantDuelist
    {
        public override void entry()
        {
            Console.WriteLine("Yoru teleports on site");
        }
    }
    class Phoenix : ValorantDuelist
    {
        public override void entry()
        {
            Console.WriteLine("Phoenix blinds");
        }
    }
}
