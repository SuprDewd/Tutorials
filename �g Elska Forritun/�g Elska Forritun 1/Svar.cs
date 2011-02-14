using System;
using System.Collections.Generic;
using System.Numerics; // Þarf að referencea

public class Program
{
	public void Main()
	{
		Console.WriteLine(Poss(0, 0));
		Console.ReadLine();
	}

	private Dictionary<string, BigInteger> Mem = new Dictionary<string, BigInteger>();

	public BigInteger Poss(int x, int y)
	{
		if (x == 100 && y == 100) return BigInteger.One;

		string k = x > y ? x.ToString() + "," + y.ToString() : y.ToString() + "," + x.ToString();
		if (Mem.ContainsKey(k)) return Mem[k];

		BigInteger n = BigInteger.Zero;
		if (x <= 99 && y <= 99) n += Poss(x + 1, y + 1);
		if (x <= 99) n += Poss(x + 1, y);
		if (y <= 99) n += Poss(x, y + 1);

		Mem.Add(k, n);
		return n;
	}
}