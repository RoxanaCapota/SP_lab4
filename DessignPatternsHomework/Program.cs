using DessignPatternsHomework.Interfaces;
using DessignPatternsHomework.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace DessignPatternsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();

            timer.Start();

            ImageProxy img1 = new ImageProxy("Pamela Anderson");
            ImageProxy img2 = new ImageProxy("Kim Kardashian");
            ImageProxy img3 = new ImageProxy("Kirby Griffin");

            Section playboyS1 = new Section("Front Cover");
            playboyS1.Add(img1.LoadImage());

            Section playboyS2 = new Section("Summer Girls");
            playboyS2.Add(img2.LoadImage());
            playboyS2.Add(img3.LoadImage());

            Book playboy = new Book("Playboy");
            playboy.AddContent(playboyS1);
            playboy.AddContent(playboyS2);

            timer.Stop();

            Console.WriteLine($"Creation of the content took {timer.ElapsedMilliseconds} milliseconds\n\n");

            timer.Reset();
            timer.Start();
            
            playboyS1.Print();

            timer.Stop();

            Console.WriteLine($"\nPrinting of the section 1 took {timer.ElapsedMilliseconds} milliseconds\n");
           
            timer.Reset();
            timer.Start();

            playboyS1.Print();

            timer.Stop();

            Console.WriteLine($"\nPrinting of the section 1 took {timer.ElapsedMilliseconds} milliseconds");


        }
    }
}
