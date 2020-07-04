using System;
//using streamingcpanel.Objects;
using streamingcpanel.DataAccess;
using streamingcpanel;

namespace usa.info
{
    public partial class userAdminData : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                
                streamingcpanel.DataAccess.DACountries myDB = new DACountries();
                UCDropDownListCountry.DataSource = myDB.GetAllEnabledPaises();
                UCDropDownListCountry.DataBind();

                UCDropDownListTimeZone.DataSource = myDB.getTimeZones();
                UCDropDownListTimeZone.DataBind();

                myDB.cerrar();
            }

        }
        public void User_UserEdit()
        {
            UCTBLogin.Enabled = false;
        }
        public UserData User_SetGetUserData
        {
            get
            {
                UserData myUser = new UserData();
                //Login Data
                if (UCTBLogin.Text == UCTBPassword.Text)
                {
                    throw (new Exception("Usuario y Clave no pueden ser iguales !"));
                }
                if (UCTBPassword.Text.Length < 5)
                {
                    throw (new Exception("Clave debe ser mayor de 5 caracteres"));
                }
                myUser.User_USerLogin = UCTBLogin.Text.TrimEnd();
                myUser.User_UserPassword = UCTBPassword.Text.TrimEnd();
                //Personal Data
                myUser.User_name = UCTBName.Text.TrimEnd();
                myUser.User_USerEmail = UCTBEmail.Text.TrimEnd();
                myUser.User_UserPhone = UCTextBoxPhone.Text.TrimEnd();
                myUser.User_USerWebPage = UCTextBoxWebPage.Text.TrimEnd();
                myUser.User_UserCompany = UCTextBoxCompany.Text.TrimEnd();
                myUser.User_USerAddress = UCTextBoxAddress.Text.TrimEnd();
                myUser.User_USerCity = UCTextBoxCity.Text.TrimEnd();
                myUser.User_FK_UserCountry = Decimal.Parse(UCDropDownListCountry.SelectedValue);
                myUser.User_UserZipCode = UCTextBoxZip.Text.TrimEnd();

                //System Data
                myUser.User_UserType = Decimal.Parse(DropDownListType.SelectedValue);
                myUser.User_UserState = Decimal.Parse(this.UCDropDownListUserState.SelectedValue);



                //if (UCTBDateExpired.Text.Equals("")) UCTBDateExpired.Text = "1/1/2025";
                //myUser.User_F_Expired = DateTime.Parse(UCTBDateExpired.Text.TrimEnd()).ToShortDateString();

                //if (UCTextBoxNextPayment.Text.Equals("")) UCTextBoxNextPayment.Text = "1/1/2025";
                //myUser.User_F_NextPayment = DateTime.Parse(UCTextBoxNextPayment.Text.TrimEnd()).ToShortDateString();


                myUser.User_EsGratis = 0; // FilesTools.ConverToNumber(this.DropDownListGratis.SelectedValue);

                myUser.User_Description = UCTextBoxNotes.Text.TrimEnd();
                myUser.User_LocalTime = int.Parse(UCDropDownListTimeZone.SelectedValue);

                //UCDropDownListColor
                myUser.User_CRM = UCDropDownListColor.SelectedValue;
                myUser.User_Alert = this.UCTextBoxAlert.Text.Trim();//Alert

                return myUser;
            }
            set
            {
                //Login Data

                UCLbelLoginData.Text = "Cliente ID: " + value.User_ID.ToString() + " - Fecha Inicio: " + value.User_F_Alta;
                UCTBLogin.Text = value.User_USerLogin;
                if (!UCTBLogin.Text.Equals(""))
                    UCTBLogin.Enabled = false;
                else
                    UCTBLogin.Enabled = true;
                UCTBPassword.Text = value.User_UserPassword.Trim();
                //Personal Data
                UCTBName.Text = value.User_name.Trim();
                UCTBEmail.Text = value.User_USerEmail.Trim();
                UCTextBoxPhone.Text = value.User_UserPhone.Trim();
                UCTextBoxWebPage.Text = value.User_USerWebPage.Trim();
                UCTextBoxCompany.Text = value.User_UserCompany.Trim();
                UCTextBoxAddress.Text = value.User_USerAddress.Trim();
                UCTextBoxCity.Text = value.User_USerCity.Trim();
                UCDropDownListCountry.SelectedValue = value.User_FK_UserCountry.ToString();
                //UCDropDownListState.SelectedValue = value.UserFK_USAState.ToString();
                UCTextBoxZip.Text = value.User_UserZipCode.Trim();

                //System Data
                DropDownListType.SelectedValue = value.User_UserType.ToString();
                this.UCDropDownListUserState.SelectedValue = value.User_UserState.ToString();
                //this.UCTextBoxCRM.Text = value.User_CRM.TrimEnd();

                //UCTextBoxNextPayment.Text = value.User_F_NextPayment.Trim();
                //UCTBDateExpired.Text = value.User_F_Expired.Trim();

                if (value.User_EsGratis == 1)
                    this.DropDownListGratis.SelectedValue = "1";
                else
                    this.DropDownListGratis.SelectedValue = "0";

                UCTextBoxNotes.Text = value.User_Description.Trim();
                UCDropDownListTimeZone.SelectedValue = value.User_LocalTime.ToString();

                //UCDropDownListColor
                //myUser.User_CRM = this.UCTextBoxCRM.Text.TrimEnd();
                string color = value.User_CRM.Trim();
                if (color.Equals("")) color = "0";
                if (color.Length>1) color = "0";
                UCDropDownListColor.SelectedValue = color;
                this.UCTextBoxAlert.Text = value.User_Alert.Trim();//Alert

            }
        }
    }
}