using Dal.CM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcConsole2
{
    /// <summary>
    /// ef帮助类
    /// </summary>
    public class EfHelper
    {

        static DbCM db = new DbCM();
        static object bb = new object();

        /// <summary>
        /// ef 处理大批量修改数据   多线程
        /// </summary>
        public static void AsyncEditData() 
        {
            Stopwatch sw = new Stopwatch();
            //开始测量代码运行时间
            sw.Start();
            var costList = db.SYCM_ShiChangPaiHang.ToList();
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
        }

        /// <summary>
        /// ef 处理大批量修改数据 多线程   该公用 未完成
        /// </summary>
        public static void AsyncEditData2<T>(List<T> data, string props)
        {
            List<Task> tsList = new List<Task>();
            int count = data.Count / 200;
            List<string> propList = new List<string>();

            foreach (var item in props.Trim().Trim(',').Split(','))
            {
                propList.Add(item);
            }

            var type = typeof(T);

            for (int i = 1; i <= count + 1; i++)
            {
                var cList = data.Skip((i - 1) * 100).Take(100).ToList();
                //tsList.Add(Task.Run(action));
                //lock (bb)
                //{
                //    db.SaveChanges();
                //}
                tsList.Add(Task.Run(() =>
                {
                    foreach (var item in cList)
                    {
                        foreach (var prop in propList)
                        {
                            type.GetProperty(prop).SetValue(item,true);
                        }

                        //foreach (var item in collection)
                        //{

                        //}
                        //item.isMonitored = true;
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    }
                    lock (bb)
                    {
                        db.SaveChanges();
                    }
                }));
            }
            Task.WaitAll(tsList.ToArray());

        }



    }
}
