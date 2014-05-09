using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;

namespace CreateModel
{
    public class AutoCreateController
    {
        SqlDataProvider dal = new SqlDataProvider();

        /// <summary>
        /// 获取当前表创建的字段
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable GetTableListByTableName(string tableName)
        {
            return dal.GetTableListByTableName(tableName);
        }

        public bool AddTableName(TableModel model)
        {
            return dal.AddTableName(model) > 0;
        }
    }
}
