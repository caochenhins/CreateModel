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
    /// 扩展字段实体
    /// </summary>
    public class ExpandModel
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string tableName;//待创建表名

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }
        private string textBoxName;//待创建表的字段名

        public string TextBoxName
        {
            get { return textBoxName; }
            set { textBoxName = value; }
        }
        private ControlTypeEnum controlType;//带创建字段生成的页面控件类型

        internal ControlTypeEnum ControlType
        {
            get { return controlType; }
            set { controlType = value; }
        }
        private string controlTypeProperty;//页面控制带的属性

        public string ControlTypeProperty
        {
            get { return controlTypeProperty; }
            set { controlTypeProperty = value; }
        }
        private string controlTypePropertyValue;//页面控件属性的值

        public string ControlTypePropertyValue
        {
            get { return controlTypePropertyValue; }
            set { controlTypePropertyValue = value; }
        }
        
    }
}
