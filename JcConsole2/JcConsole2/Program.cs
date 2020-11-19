using Dal.CM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcConsole2
{
    class Program
    {
        static DbCM db = new DbCM();

        static object bb = new object();

        static void Main(string[] args)
        {



            var as1 = db.TestModel1.Where(u => string.IsNullOrEmpty(u.Name)).ToList();
            Stopwatch sw = new Stopwatch();
            //开始测量代码运行时间
            sw.Start();

            List<int> intList = new List<int>();
            var intList2 = db.SYCM_ShiChangPaiHang.ToList().Sum(u => u.zongfangke.GetValueOrDefault(0));//.Where(u => intList.Contains(u.id)).Select(u => u.id).ToList();
            var costList = db.SYCM_ShiChangPaiHang.Where(u => intList.Contains(u.id)).ToList();
            List<Task> tsList = new List<Task>();

            int count = costList.Count / 200;
            for (int i = 1; i <= count + 1; i++)
            {
                var cList = costList.Skip((i - 1) * 200).Take(200).ToList();
                tsList.Add(Task.Run(() =>
                {
                    foreach (var item in cList)
                    {
                        item.isMonitored = false;
                        //db.Entry<SYCM_ShiChangPaiHang>(item).State = System.Data.Entity.EntityState.Modified;
                    }
                    lock (bb)
                    {
                        db.SaveChanges();
                    }
                }));
            }
            Task.WaitAll(tsList.ToArray());
            sw.Stop();
            TimeSpan timespan = sw.Elapsed;  //获取当前实例测量得出的总时间
            Console.WriteLine(timespan.TotalMilliseconds);
            Console.WriteLine("ad");
            Console.ReadKey();
        }
    }
}

