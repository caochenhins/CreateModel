<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreateSQL.ascx.cs" Inherits="CreateModel.CreateSQL" %>
<script type="text/javascript">
    var i = 1;
    function check() {
        i++;
        if (i%2==0) {
            document.getElementById('<%=TextBoxDefalutValue.ClientID%>').style.visibility = 'visible';
        }
        else {
            document.getElementById('<%=TextBoxDefalutValue.ClientID%>').style.visibility = 'hidden';
        }
    }
</script>
<div>
    <table style="position: relative">
        <tr>
            <th>创建表名</th>
            <td>
                <asp:TextBox ID="TextBoxTableName" runat="server" Width="60px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th><asp:Button ID="ButtonCreate" runat="server" Text="创建字段" OnClick="ButtonCreate_Click" /></th>
        </tr>
        <tr>
            <th>字段名</th>
            <td>
                <asp:TextBox ID="TextBoxName" runat="server" Width="60px"></asp:TextBox>
            </td>
            <th>数据库类型</th>
            <td>
                <asp:DropDownList ID="DropDownListSQLType" runat="server">
                    <asp:ListItem Selected="True" Value="nvarchar">nvarchar</asp:ListItem>
                    <asp:ListItem Value="DateTime">DateTime</asp:ListItem>
                    <asp:ListItem Value="int">int</asp:ListItem>
                    <asp:ListItem Value="ntext">ntext</asp:ListItem>
                    <asp:ListItem Value="bit">bit</asp:ListItem>
                </asp:DropDownList>
            </td>
            <th>允许为空</th>
            <td>
                <asp:CheckBox ID="CheckBoxIsNull" runat="server" />
            </td>
            <th>类型大小</th>
            <td>
                <asp:TextBox ID="TextBoxSize" runat="server" Width="60px"></asp:TextBox>
            </td>
            <th>主键</th>
            <td>
                <asp:CheckBox ID="CheckBoxMainKey" runat="server" />
            </td>
            <th>标量自增</th>
            <td>
                <asp:CheckBox ID="CheckBoxIncreaseid" runat="server" />
            </td>
            <th>默认值</th>
            <td>
                <asp:CheckBox ID="CheckBoxDefaultValue" runat="server" onclick="check()" /></td>
            <td>
                <asp:TextBox ID="TextBoxDefalutValue" runat="server" Width="60px" style="visibility:hidden;"></asp:TextBox></td>
        </tr>
        <tr>

        </tr>
        </table>
    <table>
        <tr>
            <th>序号</th>
            <th>字段名</th>
            <th>数据库类型</th>
            <th>允许为空</th>
            <th>类型大小</th>
            <th>主键</th>
            <th>标量自增</th>
            <th>默认值</th>
            <th>添加扩展字段</th>
            <th>操作</th>
        </tr>
    <asp:Repeater ID="RepeaterTable" runat="server">
        <ItemTemplate>
            
        </ItemTemplate>
    </asp:Repeater>
        </table>
</div>