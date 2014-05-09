using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace CreateModel
{
    /// <summary>
    /// 待创建字段实体
    /// </summary>
    public class TableModel
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string sQLType;

        public string SQLType
        {
            get { return sQLType; }
            set { sQLType = value; }
        }


        private bool isNull;

        public bool IsNull
        {
            get { return isNull; }
            set { isNull = value; }
        }


        private string size;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }


        private bool mainKey;

        public bool MainKey
        {
            get { return mainKey; }
            set { mainKey = value; }
        }


        private bool iSIncreaseid;

        public bool ISIncreaseid
        {
            get { return iSIncreaseid; }
            set { iSIncreaseid = value; }
        }


        private bool iSdefaultValue;

        public bool ISdefaultValue
        {
            get { return iSdefaultValue; }
            set { iSdefaultValue = value; }
        }


        private string defalutValue;

        public string DefalutValue
        {
            get { return defalutValue; }
            set { defalutValue = value; }
        }

  
        private string tableName;

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        private string expandName;

        public string ExpandName
        {
            get { return expandName; }
            set { expandName = value; }
        }
    }
}
