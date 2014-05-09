using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;

namespace CreateModel
{
    public class SqlDataProvider
    {
        public static string conn = "Server=.;Database=bjjsweb2013;uid=sa;pwd=123;";//本地测试bjjsWeb数据库

        /// <summary>
        /// 获取表的字段
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable GetTableListByTableName(string tableName)
        {
            string sql = "select ID,Name,SQLType,IsNull,Size,MainKey,ISIncreaseid,ISdefaultValue,DefalutValue,TableName,ExpandName from AutoCreateModel where TableName=@TableName";
            SqlParameter[] sp = { new SqlParameter("@TableName", SqlDbType.NVarChar, 50) };
            sp[0].Value = tableName;
            DataSet ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, sql, sp);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        /// <summary>
        /// 添加一个字段
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddTableName(TableModel model)
        {
            string sql = "insert into AutoCreateModel(Name, SQLType, IsNull, Size, MainKey, ISIncreaseid, ISdefaultValue, DefalutValue, TableName,ID,ExpandName) values(@Name, @SQLType, @IsNull, @Size, @MainKey, @ISIncreaseid, @ISdefaultValue, @DefalutValue, @TableName,@ID,@ExpandName)";
            SqlParameter[] sp ={new SqlParameter("@Name", SqlDbType.NVarChar, 50),
                              new SqlParameter("@SQLType", SqlDbType.NVarChar, 50),
                              new SqlParameter("@IsNull", SqlDbType.Bit, 50),
                              new SqlParameter("@Size", SqlDbType.NVarChar, 50),
                              new SqlParameter("@MainKey", SqlDbType.Bit, 50),
                              new SqlParameter("@ISIncreaseid", SqlDbType.Bit, 50),
                              new SqlParameter("@ISdefaultValue", SqlDbType.Bit, 50),
                              new SqlParameter("@DefalutValue", SqlDbType.NVarChar, 50),
                              new SqlParameter("@TableName", SqlDbType.NVarChar, 50),
                               new SqlParameter("@TableName", SqlDbType.NVarChar, 50),
                               new SqlParameter("@TableName", SqlDbType.NVarChar, 50),};
            sp[0].Value = model.Name;
            sp[1].Value = model.SQLType;
            sp[2].Value = model.IsNull;
            sp[3].Value = model.MainKey;
            sp[4].Value = model.ISIncreaseid;
            sp[5].Value = model.ISdefaultValue;
            sp[6].Value = model.DefalutValue;
            sp[7].Value = model.TableName;
            return SqlHelper.ExecuteNonQuery(conn, CommandType.Text, sql, sp);
        }
    }
}
