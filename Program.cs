using System;

namespace Eyylizer
{
    public class Eyylizer
    {
        private const int MaxSpaces = 10000;
        private const string Ey = "ey";
	private string _theBigEyy = "";
	public string GetEyy :

        public string Build()
	{
            Random randNum = new Random();

            for (int i = 0; i < MaxSpaces; i++)
	    {
                _theBigEyy += Ey;
                for (int z = randNum.Next(1,9);z>0;z--)
                    _theBigEyy += " ";
	    }


	    return _theBigEyy;
	}

	public void Display()
	{
            Eyylizer e = new Eyylizer();
            Console.WriteLine(e.GetEyy);
	}
    }

    public class Program
    {
        internal static void Main()
        {
	    Eyylizer e = new Eyylizer();
	    e.Display();
        }
    }
}
