using System;
using System.Collections.Generic;
using System.Linq;
using Auk.CsharpBootstrapper.Example.Model;
using Auk.CsharpBootstrapper.Extensions;
using Auk.CsharpBootstrapper.Helper;
using Auk.CsharpBootstrapper.Implementations;
using Auk.CsharpBootstrapper.Model;
using Auk.CsharpBootstrapper.StaticCache;
using log4net;

namespace Auk.CsharpBootstrapper.Example
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            /*
             * Md. Alim Ul Karim
             */

            LogHelper.EnableDebugMode();
            var configFilePath = PathHelper.GetPathCombineFromBase("Auk.CsharpBootstrapper.Example.log4net.config");
            LogHelper.GetConfiguredLog4Net(configFilePath);
            LogHelper.InjectLog4NetLogger(Log);

            var urlList = new List<string>();
            urlList.Add("https://www.nuget.org/packages/Auk.CsharpBootstrapper/1.1.1");
            urlList.Add("https://www.nuget.org/packages/Auk.CsharpBootstrapper/1.0.2");
            urlList.Add("https://www.nuget.org/packages/Auk.CsharpBootstrapper/1.1.3");
            urlList.Add("https://www.nuget.org/packages/Auk.CsharpBootstrapper/1.0.4");

            //var contents = ApiHelper.GetUrlsContents(urlList, true);


            //contents.Result.Select(
            //            w =>
            //            {
            //                var content = w.Content.Substring(0, 50);
            //                var url     = w.Url;


            //                LogHelper.QDebug(url, content);

            //                return w;
            //            })
            //        .ToArray();

            CommonCache.Set("s", new List<string>());
            CommonCache.Set("s", urlList);

            var person2 = SingletonHelper.Create(
                 () =>
                 {
                     Console.WriteLine(DateTime.Now);

                     return new Person2();
                 }, nameof(Person2));

            var person3 = SingletonHelper.Create(
                () =>
                {
                    Console.WriteLine(DateTime.Now);

                    return new Person2();
                },
                nameof(Person2));

            var person4 = SingletonHelper.Create(
                () =>
                {
                    Console.WriteLine(DateTime.Now);

                    return new Person2();
                },
                nameof(Person2));

            Console.WriteLine(person4 == person2);

            //CommonCache.LogPrint();

            //ApiHelper.
            //ParallelTaskHelper.
            //try
            //{
            //    throw new Exception("Hello World");
            //}
            //catch (Exception e)
            //{
            //    e.PathErrorLogAndThrow("Path");
            //    //e.LogAndThrow("", null, isThrow: true);
            //}

            //LogHelper.QInfo("Hello", "World");
            //LogHelper.QDebug("Hello", "World");
            //LogHelper.QFatal("Hello", "World");
            //LogHelper.QWarn("Hello", "World");

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

            Console.ReadKey();
        }
    }
}