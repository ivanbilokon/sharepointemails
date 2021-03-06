﻿<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" %>
<SharePoint:RenderingTemplate ID="SPAssociationEditTemplate" runat="server">
<Template>
    <style type="text/css">
        .hiddencell {display:none;}
    </style>
  <script src="../_layouts/SharePointEmails/Scripts/SEAssociationFieldControl.js" type="text/javascript"></script>
  <asp:UpdatePanel runat="server" ID="updatePanel">
        <ContentTemplate>
         <table style="width: 100%;">
            <tr>
                <td>
                   <asp:GridView ID="grd_Asses" runat="server" EnableModelValidation="True" 
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" 
                    AutoGenerateSelectButton="True" DataKeyNames="ID" >
                    <Columns>
                        <asp:BoundField DataField="ID"  ItemStyle-CssClass="hiddencell" HeaderStyle-CssClass="hiddencell" />
                        <asp:BoundField DataField="Name" HeaderText="Association name" />
                        <asp:BoundField DataField="Type" HeaderText="Association type"/>        
                        <asp:BoundField DataField="Value" HeaderText="Association value"/>        
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <EmptyDataTemplate>No Data Found.</EmptyDataTemplate> 
                  </asp:GridView>
                </td>
                <td>
                      <asp:MultiView ID="mv_Main" runat="server" ActiveViewIndex="1" Visible="false">
                          <asp:View ID="v_Displaying" runat="server">
                            <dl>
                                <dt>Name</dt><dd><asp:Label ID="v_Displaing_lbl_Name" runat="server" /></dd>
                                <dt>Type</dt><dd><asp:Label ID="v_Displaying_lbl_Type" runat="server" /></dd>
                            </dl>
                            <asp:MultiView ID="v_Displaing_mv_Types" runat="server">
                                <asp:View ID="v_Displaying_v_ById" runat="server">
                                    <dl>
                                        <dt>Id</dt><dd><asp:Label ID="v_Displaying_v_ById_lbl_Id" runat="server"/></dd>
                                    </dl>
                                </asp:View>
                                <asp:View ID="v_Displaying_v_ByGroup" runat="server">
                                    <dl>
                                        <dt>Group</dt><dd><asp:Label ID="v_Displaying_v_ByGroup_lbl_Group" runat="server"/></dd>
                                    </dl>
                                </asp:View>
                                <asp:View ID="v_Displaying_v_ByCT" runat="server">
                                    <dl>
                                        <dt>CTId</dt><dd><asp:Label ID="v_Displaying_v_ByCT_lbl_CTId" runat="server"/></dd>
                                        <dt>Include children</dt><dd><asp:CheckBox ID="v_Displaying_v_ByCT_cb_IncludeChildren" runat="server" Enabled="false"/></dd>
                                    </dl>
                                </asp:View>
                            </asp:MultiView>
                          </asp:View>
                          <asp:View ID="v_Editing" runat="server">
                            <dl>
                                <dt>Name</dt><dd>  <asp:TextBox ID="v_Editing_tb_Name" runat="server" /></dd>
                                <dt>Type</dt><dd><asp:Label ID="v_Editing_lbl_Type" runat="server" /></dd>
                            </dl>
                             <asp:MultiView ID="v_Editing_mv_Types" runat="server">
                                <asp:View ID="v_Editing_v_ById" runat="server">
                                      <dl>
                                        <dt>Id</dt><dd><asp:TextBox ID="v_Editing_v_ById_tb_Id" runat="server"/></dd>
                                        <dt>Relative Url</dt><dd><asp:TextBox ID="v_Editing_v_ById_tb_Url" Text="/Lists/Shared Documents/" runat="server"/></dd>
                                        <dt>Item Type</dt><dd><asp:TextBox ID="v_Editing_v_ById_lbl_Type" runat="server"/></dd>
                                       </dl>
                                       <asp:Button ID="v_Editing_v_ById_btn_Resolve" runat="server" Text="Resolve"></asp:Button>
                                       <asp:Label ID="v_Editing_v_ById_lbl_Message" runat="server" EnableViewState="false"></asp:Label>
                                </asp:View>
                                <asp:View ID="v_Editing_v_ByGroup" runat="server">
                                    <dl>
                                        <dt>Group</dt><dd><asp:DropDownList ID="v_Editing_v_ByGroup_cb_Group" runat="server"/></dd>
                                    </dl>
                                </asp:View>
                                <asp:View ID="v_Editing_v_ByCT" runat="server">
                                     <dl>
                                        <dt>CTId</dt><dd><asp:TextBox ID="v_Editing_v_ByCT_tb_CTId" runat="server"/></dd>
                                        <dt>Include children</dt><dd><asp:CheckBox ID="v_Editing_v_ByCT_cb_IncludeChildren" runat="server"/></dd>
                                    </dl>
                                </asp:View>
                            </asp:MultiView>
                          </asp:View>
                     </asp:MultiView>
                </td>
            </tr>    
            <tr>
                <td>
                    <asp:Panel ID="p_Buttons" runat="server" >
                        <asp:Button ID="btn_Delete" runat="server" Text="Delete" />
                        <asp:Button ID="btn_Create" runat="server" Text="Show new" /> 
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="p_Create" runat="server" Visible="false" >
                        <table>
                            <tr>
                                <td>Name :</td>
                                <td><asp:TextBox ID="Create_tb_Name" runat="server">no name</asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Type :</td>
                                <td>
                                    <asp:DropDownList ID="Create_cb_AssType" runat="server" AutoPostBack="True">
                                        <asp:ListItem Value="1" Text="By Group" Selected="True"/>
                                        <asp:ListItem Value="2" Text="By Id" />
                                        <asp:ListItem Value="3" Text="By ContentType" />
                                   </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>Desc :</td>
                                <td><asp:TextBox ID="Create_tb_Desc" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                            </tr>
                        </table>
                        <asp:MultiView ID="mv_CreateMain" runat="server" ActiveViewIndex="1">
                           <asp:View ID="v_ById" runat="server" >
                               <asp:Panel ID="Panel1" runat="server">
                                 <table>
                                   <tr>
                                       <td>Item Id :</td>
                                       <td><asp:TextBox ID="Create_ById_tb_ItemId" runat="server" /></td>
                                   </tr>
                                  </table>
                               </asp:Panel>
                            </asp:View>
                           <asp:View ID="v_ByGroup" runat="server">
                                <asp:Panel ID="Panel2" runat="server"> 
                                    <table>
                                        <tr>
                                            <td>Group Type :</td>
                                            <td> 
                                                <asp:DropDownList ID="Create_ByGroup_cb_GroupType" runat="server">
                                                        <asp:ListItem Value="1" Text="AllList" Selected="True"/>
                                                        <asp:ListItem Value="2" Text="AllDiscusionBoard"/>
                                                        <asp:ListItem Value="3" Text="AllDocumentLibrary"/>
                                                        <asp:ListItem Value="4" Text="AllBlogs"/>   
                                                        <asp:ListItem Value="5" Text="AllTasks"/>   
                                                        <asp:ListItem Value="6" Text="AllMyTasks"/>   
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </asp:View>
                           <asp:View ID="v_ByCT" runat="server">
                                <asp:Panel ID="Panel3" runat="server"> 
                                    <table>
                                        <tr>
                                            <td>Content Type :</td>
                                            <td> 
                                                <asp:TextBox ID="Create_ByCT_tb_CTId" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                         <tr>
                                            <td>Including children :</td>
                                            <td> 
                                                <asp:CheckBox ID="Create_ByCT_cb_IncludingChildren" runat="server"></asp:CheckBox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </asp:View>
                        </asp:MultiView>

                        <asp:Button ID="btn_Add" runat="server" Text="Add" /><asp:Button ID="btn_Create_Hide" Visible="false" runat="server" Text="Hide"></asp:Button>
                        <asp:CustomValidator ID="cv_Create" runat="server" ErrorMessage="CustomValidator" ValidationGroup="CreateGroup" Visible="False"></asp:CustomValidator>
                        <asp:ValidationSummary ID="vs_Create" runat="server"  ValidationGroup="CreateGroup"/>
                    </asp:Panel>
                </td>
        </tr>    
        </table>
    </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress runat="server" ID="updateProgress" AssociatedUpdatePanelID="updatePanel">
           <ProgressTemplate>
                Processing...
            </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:CustomValidator ID="cv_General" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
    <asp:ValidationSummary ID="vs_Total" runat="server" />
</Template>
</SharePoint:RenderingTemplate>