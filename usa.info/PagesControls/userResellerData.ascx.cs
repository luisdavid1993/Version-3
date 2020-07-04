using System;
//using streamingcpanel.Objects;
using streamingcpanel.DataAccess;


namespace streamingcpanel.PagesControls
{
    public partial class userResellerData : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                streamingcpanel.DataAccess.DACountries myDB = new streamingcpanel.DataAccess.DACountries();
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
                    throw (new Exception("Sorry, login and password must be diferent !"));
                }
                if (UCTBPassword.Text.Length < 5)
                {
                    throw (new Exception("Sorry, password len must be > 5 !"));
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
                myUser.User_UserState = Decimal.Parse(this.UCDropDownListUserState.SelectedValue);

              myUser.User_LocalTime = int.Parse(UCDropDownListTimeZone.SelectedValue);

 
                return myUser;
            }
            set
            {
                //Login Data

                UCLbelLoginData.Text = "Login Data (" + value.User_ID.ToString() + ") Setup Date: " + value.User_F_Alta;
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
                this.UCDropDownListUserState.SelectedValue = value.User_UserState.ToString();
                UCDropDownListTimeZone.SelectedValue = value.User_LocalTime.ToString();



            }
        }
    }
}