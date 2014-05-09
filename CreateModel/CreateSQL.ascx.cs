using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using EasySite.Entities.Modules;

namespace CreateModel
{
    public partial class CreateSQL : PortalModuleBase
    {
        AutoCreateController bll = new AutoCreateController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            TableModel tabmodel = new TableModel();
            tabmodel.TableName = TextBoxTableName.Text;
            tabmodel.Name = TextBoxName.Text;
            tabmodel.SQLType = DropDownListSQLType.SelectedValue;
            tabmodel.IsNull = CheckBoxIsNull.Checked;
            tabmodel.Size = TextBoxSize.Text;
            tabmodel.MainKey = CheckBoxMainKey.Checked;
            tabmodel.ISIncreaseid = CheckBoxIncreaseid.Checked;
            tabmodel.ISdefaultValue = CheckBoxDefaultValue.Checked;
            tabmodel.DefalutValue = TextBoxDefalutValue.Text;
            if (bll.AddTableName(tabmodel))
            {
                Binder(tabmodel);
            }
           

        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        /// <param name="tabModel"></param>
        public void Binder(TableModel tabModel)
        {
            RepeaterTable.DataSource = bll.GetTableListByTableName(tabModel.TableName);
            RepeaterTable.DataBind();
        }
    }
}