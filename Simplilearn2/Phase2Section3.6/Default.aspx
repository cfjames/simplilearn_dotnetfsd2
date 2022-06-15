<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Phase2Section3._6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function imageBtnClicked()
        {
            alert("Image Button clicked!");
        }
    </script>
    <div class="row">
        <div class="col-12 text-center">
            <asp:HiddenField ID="hidValidationToken" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="PASSPORT APPLICATION FORM" Font-Bold="true"></asp:Label> 
            <br />App:<asp:Label ID="lblHitCounterA" runat="server" Font-Bold="true"></asp:Label>
            <br />Session:<asp:Label ID="lblHitCounterS" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </div>
    <div class="row">
         <div class="col-6">
             <div class="row mt-5">
                 <div class="col-4">First Name*</div>
                 <div class="col-8"><asp:TextBox ID="fname" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox></div>
             </div>
         </div>
        <div class="col-6">
             <div class="row mt-5">
                 <div class="col-4">Last Name*</div>
                 <div class="col-8"><asp:TextBox ID="lname" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox></div>
             </div>
         </div>
        <div class="col-6">
             <div class="row mt-5">
                 <div class="col-4">Date of Birth*</div>
                 <div class="col-8"><asp:Calendar ID="dob" runat="server"></asp:Calendar></div>
             </div>
         </div>
        <div class="col-6">
             <div class="row mt-5">
                 <div class="col-4">Current Address*</div>
                 <div class="col-8">
                     <asp:ImageButton ID="ibGoogleMapsAddress" runat="server" Height="40"
                        ImageUrl="https://img.etimg.com/thumb/msid-69170499,width-643,imgsize-50756,resizemode-4/googlemaps1.jpg"
                        ImageAlign="Left" OnClick="ibGoogleMapsAddress_Click" OnClientClick="imageBtnClicked();"/> &nbsp;Click on icon to the left to launch Google Maps
                 </div>
             </div>
         </div>
         <div class="col-6">
             <div class="row mt-5">
                 <div class="col-4">Upload Photo*</div>
                 <div class="col-8">
                     <asp:FileUpload ID="FileUpload1" runat="server" />
                     <hr />
                     Sample image below:<br />
                     <asp:Image ID="imgUpload" runat="server" Height="300" Width="300" ImageUrl="https://visafoto.com/img/source355x388.jpg" />
                 </div>
             </div>
         </div>
        <asp:Panel ID="Panel1" runat="server" CssClass="bg-info row mt-5">
                 <div class="col-4">Employment Status</div>
                 <div class="col-8">
                     <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="true" value="0" runat="server" Text="&nbsp;Unemployed" GroupName="rbGroup" OnCheckedChanged="RadioButton1_CheckedChanged"/><br />
                     <asp:RadioButton ID="RadioButton2" value="1"  runat="server" Text="&nbsp;Private Company" GroupName="rbGroup" OnCheckedChanged="RadioButton2_CheckedChanged"/><br />
                     <asp:RadioButton ID="RadioButton3" value="2" runat="server" Text="&nbsp;Public Company" GroupName="rbGroup2"/><br />
                     <asp:RadioButton ID="RadioButton4" value="3" runat="server" Text="&nbsp;Self Employed" GroupName="rbGroup2"/><br />
                     <asp:RadioButton ID="RadioButton5" value="4" runat="server" Text="&nbsp;Business" GroupName="rbGroup2"/><br />
                 </div>
        </asp:Panel>
        <asp:Panel runat="server" CssClass="bg-info row mt-5">
                    <div class="col-4">Special Status</div>
                    <div class="col-7">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="&nbsp;Senior Citizen"/><br />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="&nbsp;Minor"/><br />
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="&nbsp;Armed Forces"/><br />
                        <asp:CheckBox ID="CheckBox4" runat="server" Text="&nbsp;Foreign Diplomat"/><br />
                        </div>
                 </asp:Panel>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="col-6">
                     <div class="row mt-5">
                         <div class="col-4">Category</div>
                         <div class="col-8">
                             <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged"></asp:DropDownList>
                         </div>
                     </div>
                 </div>
                <div class="col-6">
                     <div class="row mt-5">
                         <div class="col-4">SubCategory</div>
                         <div class="col-8">
                             <asp:DropDownList ID="ddlSubCat" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSubCat_SelectedIndexChanged"></asp:DropDownList>
                         </div>
                     </div>
                 </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <div class="row mt-5 border-top">
       <div class="col-12 text-center">
            <asp:Button runat="server" ID="btnSubmit" cssClass="btn btn-secondary" Text="Submit" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="HomePageFooterContent" ContentPlaceHolderID="FooterContent" runat="server">
    Some Additional Footer Content
</asp:Content>
