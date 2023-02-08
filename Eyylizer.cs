using System;

namespace Eyylizer
{
    public class Eyylizer
    {
        private static int MaxSpaces = 10000;
        private static string Ey = "ey";
	private static string _theBigEyy = "";

        public static string Build()
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

	public static void Display()
	{
            Console.WriteLine(Eyylizer.Build());
	}
    }
}
