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
    public class ExpandPageModel
    {
        private string tableCssStyle;//table表格样式

        public string TableCssStyle
        {
            get { return tableCssStyle; }
            set { tableCssStyle = value; }
        }
        private string tdCssStyle;//td样式

        public string TdCssStyle
        {
            get { return tdCssStyle; }
            set { tdCssStyle = value; }
        }
        private string thCssStyle;//th样式

        public string ThCssStyle
        {
            get { return thCssStyle; }
            set { thCssStyle = value; }
        }
        private string trCssStyle;//tr样式

        public string TrCssStyle
        {
            get { return trCssStyle; }
            set { trCssStyle = value; }
        }
        private bool isRequiredFieldValidator;//是否需要验证控件

        public bool IsRequiredFieldValidator
        {
            get { return isRequiredFieldValidator; }
            set { isRequiredFieldValidator = value; }
        }
        private bool isRequiredCancel;//是否需要重置按钮

        public bool IsRequiredCancel
        {
            get { return isRequiredCancel; }
            set { isRequiredCancel = value; }
        }
    }
}
