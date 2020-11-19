using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JcConsole2
{
    public class PublicHelper
    {
        /// <summary>
        /// 拖动排序1
        /// </summary>
        /// <param name="fid">存在上下级时用  不存在上下级可不需要这个参数</param>
        /// <param name="id">操作数据id</param>
        /// <param name="id2">移动到谁的前面</param>
        public void RepositoryContentSort2(int fid, int id, int id2)
        {// id 操作数据id      id2移动到谁的前面   fid上级知识页id

            dynamic data1 = null;//dbRepositoryContent.getDefault("*", "where id =@Id", new { Id = id });
            if (data1 != null)
            {
                if (id2 > 0)
                {
                    dynamic data2 = null;// dbRepositoryContent.getDefault("*", "where id =@Id", new { Id = id2 });
                    if (data2 != null)
                    {
                        decimal sort = data2.Sort;
                        dynamic qReport = null;// dbRepositoryContent.getDefault("*", "where Fid=@fid and sort<@sort and Rsid=@Rsid order by sort desc", new { fid, sort = data2.Sort, Rsid = data1.Rsid });
                        var maxSort = qReport == null ? 0 : qReport.Sort;
                        data1.Sort = (sort + maxSort) / 2;
                    }
                }
                else//拖动到末尾
                {
                    dynamic qReport = null;// dbRepositoryContent.getDefault("*", "where Fid=@fid and Rsid=@Rsid order by sort desc", new { fid, Rsid = data1.Rsid });
                    data1.Sort = (qReport == null ? 0 : qReport.Sort) + 1000;
                }
                data1.Fid = fid;
                //dbRepositoryContent.Update(data1);
            }
        }

        /// <summary>
        /// 拖动排序2
        /// </summary>
        /// <param name="fid">存在上下级时用  不存在上下级可不需要这个参数</param>
        /// <param name="id">操作数据id</param>
        /// <param name="isUp">=1向上/前拖动 =0向下/后拖动</param>
        /// <param name="id2">移动到该数据前/后</param>
        /// <returns></returns>
        public void SortdbDocumentReport2(int fid, int id, int isUp, int id2)
        {

            dynamic report = null;//dbDocumentReport2.getDefault("*", "where id=@id", new { id = id });
            dynamic report2 = null; //dbDocumentReport2.getDefault("*", "where id=@id", new { id = id2 });
            if (report != null && report2 != null )
            {
                decimal sort = report2.sort;
                if (isUp == 1)//向上/前拖动
                {
                    dynamic qReport = null;// dbDocumentReport2.getDefault("*", "where fid=@fid and sort<@sort order by id desc", new { fid = fid, sort = sort });
                    var maxSort = qReport == null ? 0 : qReport.sort;
                    report.sort = (sort + maxSort) / 2;
                }
                else//向下/后拖动
                {
                    dynamic qReport = null;// dbDocumentReport2.getDefault("*", "where fid=@fid and sort>@sort order by id asc", new { fid = fid, sort = sort });
                    if (qReport == null)
                    {
                        report.sort = sort + 1000;
                    }
                    else
                    {
                        report.sort = (sort + qReport.sort) / 2;
                    }
                }
            }
          
            //dbDocumentReport2.Update(report);
        }

    }
}
