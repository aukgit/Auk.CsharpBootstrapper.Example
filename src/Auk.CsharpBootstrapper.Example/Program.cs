using System;
using System.Linq;
using Auk.CsharpBootstrapper.Example.Model;
using Auk.CsharpBootstrapper.Extensions;
using Auk.CsharpBootstrapper.Helper;
using Auk.CsharpBootstrapper.Implementations;
using Auk.CsharpBootstrapper.Model;

namespace Auk.CsharpBootstrapper.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Md. Alim Ul Karim
             */

            LogHelper.EnableDebugMode();

            //ApiHelper.
            //ParallelTaskHelper.
            //try
            //{
            //    throw new Exception("Hello World");
            //}
            //catch (Exception e)
            //{
            //    e.PathErrorLogAndThrow("Path");
            //    e.LogAndThrow("" , null, isThrow:true);
            //}
            //CommonIdentifier.op
            //StringHelper.CreateCsharpInterfaceAndClassCode();
            //PathHelper.GetPathCombineFromBase()
            //EnumHelper.
            //ActionHelper.
            // Lazy Getter
            // Action Runner
            //DirectoryHelper.
            //MutexHelper.
            //var threadedList = new ThreadSafeList<string>(5);
            // common cache
            // For loop running

            //var list = new List<string>();
            //list.Add("");
            //list.Add("Hello World");

            //LogHelper.LogModelWithStateData(null, list);
            var numberToRun = 5000000;

            //foreach (var i in range)
            //{
            //}

            //Parallel.For(
            //    0,
            //    numberToRun + 1,
            //    i =>
            //    {
            //        Console.Write(i);
            //    });

            //SequenceAnalysisHelper.RunActionsMaxParallel(range, i=> Console.Write(i) );

            //ProcessHelper.

            //MutexHelper.
            //FileHelper.
            var index = 0;

            var x = ActionHelper.LazyGetter(
                () =>
                {
                    Console.WriteLine(DateTime.Now + $" Index : {index}");
                    index++;

                    return Enumerable.Range(0, numberToRun).ToArray();
                });

            //var values = x.ValueAtOnce;
            //var values2 = x.ValueAtOnce;
            //var values3 = x.ValueAtOnce;

            //LogHelper.LogModelWithStateData(null, values3);

            //x.AttachRecallActionEvent(1, 7);

            //var index2 = 0;
            //var actionRunner = new ActionRunner(
            //    () =>
            //    {
            //        Console.WriteLine(DateTime.Now + $" Index : {index2}");
            //        index2++;

            //        if (index2 > 3)
            //        {
            //            throw new Exception("Hello World", new Exception("Inner Exception"));
            //        }
            //    },
            //    "Index Runner");

            //actionRunner.AttachRecallActionEvent(2, 10);
            //StringHelper.
            new CommonValidateResult<string>(true, "Sucess");
            var x2 = new CommonValidateResult<string>(false, "Failed");
            var person2 = new Person2();
            var person1 = new Person1();

            LogHelper.LogModelWithStateData(null, person1);
            LogHelper.LogModelWithStateData(null, person2);

            person2.SafeInjectPropertiesValuesWithSameNames(person1);

            LogHelper.LogModelWithStateData(null, person1);
            LogHelper.LogModelWithStateData(null, person2);

            Console.ReadKey();
        }
    }
}