using System;
namespace InterfacePractice
{
    public interface IFeedable
    {
        void Eat();
        void Nap()
        {
            Console.WriteLine("snoooooooozzze");
        }
    }
}
