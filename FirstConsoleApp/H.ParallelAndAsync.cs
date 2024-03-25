using System;
using System.Threading;
public class ParallelAndAsync
{


    int[] numbers = [2334, 55678, 23415, 57564, 65432];
    private void CalculateSquare(int n)
    {
        var square = n*(long)n;
        Console.WriteLine($"Square of {n} is {square}");
        Thread.Sleep(1000);
    }

    //Sequential
    public void ProcessNumbers()
    {
        Console.WriteLine("SequentialLoop");
        foreach(var num in numbers)
        {
            CalculateSquare(num);
        }
    }
    //Parallel
    public void ProcessNUmbersParallel()
    {
        Console.WriteLine("Parallel loop");
        //TPL = task parallel library
        Parallel.ForEach(numbers, CalculateSquare);
    }
    //Asynchronous programming
//key points:
    //used in database query 
    //one task doesnot wait for another task to begin its process 
    //parallel programming is the sideeffect of the async programming
    //keywords: async, await

    public async Task MakeTea()
    {
       await IgniteGas();
       await BoilWaterinTeaPot();
       await PrepareMasla();
       await AddIngredients();
    
    }

    private async Task IgniteGas()
    {
        await Task.Delay(1000); //if a method return task then we can await that
    }

    private async Task<bool> BoilWaterinTeaPot()
    {
        return false;
    }

    private async Task PrepareMasla()
    {


    }

    private async Task AddIngredients()
    {

    }
    
}


