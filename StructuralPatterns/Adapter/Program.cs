using Adapter.Adapter;
using Adapter.Client;
using Adapter.Service;
using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var roundHole = new RoundHole(1.0);
            var squarePeg = new SquarePeg(0.2);
            var squarePegAdapter = new SquarePegAdapter(squarePeg);
            Console.WriteLine("Peg fits? {0}", roundHole.Fits(squarePegAdapter));
        }
    }
}
