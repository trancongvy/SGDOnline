using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Globalization;
using CDTLib;
using CDTSystem;
using CDTControl.CDTControl;

using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Configuration;

namespace CDT
{
    static class Program
    {
        [STAThread]
        [Obsolete]
        public static  void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(defaultValue: false);
            BonusSkins.Register();
            OfficeSkins.Register();
            string defaultStyle2 = "Money Twins";
            DefaultLookAndFeel defaultLookAndFeelMain2 = new DefaultLookAndFeel();
            if (defaultStyle2 != string.Empty)
            {
                defaultLookAndFeelMain2.LookAndFeel.SetSkinStyle(defaultStyle2);
            }
            string server = ConfigurationSettings.AppSettings["WebServer"];
            Config.NewKeyValue("WebServer", server);
            string productName3 = "CBASGD133";
            if (args.Length != 0)
            {
                productName3 = args[0];
            }
            string H_KEY = "HKEY_CURRENT_USER\\Software\\SGD\\";
            RegistryKey HKey = Registry.CurrentUser.OpenSubKey("Software\\SGD\\");
            if (HKey == null)
            {
                Registry.CurrentUser.CreateSubKey("Software\\SGD\\");
                HKey = Registry.CurrentUser.OpenSubKey("Software\\SGD\\");
            }
            string[] softList = HKey.GetSubKeyNames();
            string P_KEY2 = "";
            if (softList.Length > 1)
            {
                fSoftList fsl = new fSoftList();
                fsl.ShowDialog();
                productName3 = fsl.Productname;
                P_KEY2 = H_KEY + productName3 + "\\";
                if (productName3 == string.Empty)
                {
                    return;
                }
            }
            else if (softList.Length == 0)
            {
                productName3 = "CBASGD133";
                string subkey = "Software\\SGD\\" + productName3;
                P_KEY2 = H_KEY + productName3 + "\\";
                RegistryKey pKey = Registry.CurrentUser.OpenSubKey(subkey);
                if (pKey == null)
                {
                    Registry.CurrentUser.CreateSubKey(subkey);
                    Registry.SetValue(P_KEY2, "CompanyName", "SGD", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "Created", "0", RegistryValueKind.DWord);
                    Registry.SetValue(P_KEY2, "isDemo", "0", RegistryValueKind.DWord);
                    Registry.SetValue(P_KEY2, "Language", "0", RegistryValueKind.DWord);
                    Registry.SetValue(P_KEY2, "Package", "7", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "isOnline", "0", RegistryValueKind.DWord);
                    Registry.SetValue(P_KEY2, "Password", "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", RegistryValueKind.ExpandString);
                    Registry.SetValue(P_KEY2, "RegisterNumber", "", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "SavePassword", "True", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "StructDb", "SGD", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "RemoteServer", "SGD", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "Style", "Money Twins", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "SupportOnline", "SGD", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "UserName", "Admin", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "isRemote", "False", RegistryValueKind.String);
                    Registry.SetValue(P_KEY2, "SoftType", "0", RegistryValueKind.DWord);
                }
            }
            else
            {
                productName3 = softList[0];
                P_KEY2 = H_KEY + productName3 + "\\";
            }
            Config.NewKeyValue("ProductName", productName3);
            Config.NewKeyValue("H_KEY", P_KEY2);
            defaultStyle2 = Registry.GetValue(P_KEY2, "Style", string.Empty).ToString();
            defaultLookAndFeelMain2 = new DefaultLookAndFeel();
            if (defaultStyle2 != string.Empty)
            {
                defaultLookAndFeelMain2.LookAndFeel.SetSkinStyle(defaultStyle2);
            }
            string created = Registry.GetValue(P_KEY2, "Created", 0).ToString();

            int isOnline = 0;

            try { isOnline = (int)Registry.GetValue(P_KEY2, "isOnline", 0); } catch { }
            Config.NewKeyValue("H_KEY", P_KEY2);
            int SoftType = (int)Registry.GetValue(P_KEY2, "SoftType", 1);
            
            string extend =  "1";
            string Company = Registry.GetValue(P_KEY2, "CompanyName", "").ToString();
            CPUid Cpu = new CPUid(Company + productName3 + "SGDBPMOnline" + extend) ;
            string RegisterNumber = Registry.GetValue(P_KEY2, "RegisterNumber", "").ToString();
            if (RegisterNumber != Cpu.KeyString)
            {
                Config.NewKeyValue("isDemo", 1);
                if (MessageBox.Show("Bạn đang dùng phiên bản demo, bạn có muốn đăng ký lại không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RegisterF rf = new RegisterF();
                    rf.producName = productName3;
                    rf.ShowDialog();
                    Config.NewKeyValue("isDemo", 0);
                    if (rf.DialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            else
            {
                Config.NewKeyValue("isDemo", 0);
                Config.NewKeyValue("CompanyName", Company);
                Config.NewKeyValue("SoftType", SoftType);
                Config.NewKeyValue("isOnline", isOnline);
            }
            
            if (isOnline == 0)// Trường hợp off line
            {
                if (created == "0")//
                {
                    CreateData frmCreateData = new CreateData(productName3);
                    frmCreateData.ShowDialog();
                    if (frmCreateData.DialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                    Registry.SetValue(P_KEY2, "Created", 1);
                }
            }
            else
            {
                CPUid cpu = new CPUid(productName3);
                UserConnection u = new UserConnection();
                u.DatabaseName = productName3;
                u.ComputerName=cpu.MaMay;
                u.LicenceKey = "";// Registry.GetValue(P_KEY2, "EBA4330AABE2029DB278B8A049E33A07", ""); ;
                string ob = JsonConvert.SerializeObject(u);
                string re = GetConnection(ob);
                try
                {
                    u = JsonConvert.DeserializeObject<UserConnection>(re);
                    if (u != null)
                    {
                        string structName = Registry.GetValue(P_KEY2, "StructName", "").ToString();
                        string connection = Security.DeCode64(u.StructDb);
                        connection += ";Database=" + structName;
                        Config.NewKeyValue("StructConnection", Security.EnCode64(connection));
                       if(DateTime.Now> u.TimeEx)
                        {
                            MessageBox.Show("Máy bạn đã hết hạn sử dụng gói phần mềm này!");
                            return;
                        }    
                    }
                }
                catch  { }
            }
            SetEnvironment();
            
            Login frmLogin = new Login();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult != DialogResult.Cancel)
            {
                if (isOnline == 1)//Kiểm tra ngày hết hạn
                {
                    
                    try
                    {
                        //CDTControl.Log log = new CDTControl.Log();
                        //string uKey =  log.GetExDate(RegisterNumber);
                        //UserKey key = JsonConvert.DeserializeObject<UserKey>(uKey);
                        //DateTime Exdate = key.Exdate;
                        //if (DateTime.Now > Exdate)
                        //    MessageBox.Show("Máy bạn đã hết hạn sử dụng gói phần mềm này!");
                    }
                    catch { }
                }
                Application.Run(new Main(frmLogin.drUser, frmLogin.drPackage));
            }
        }
        static public string GetConnection(string ob)
        {
            string url = "https://www.phanmemsgd.com/SGDAPI/api/UserConnections1/PostGetConnection/";
            string sContentType = "application/json";
            HttpContent s = new StringContent(ob, Encoding.UTF8, sContentType);
            HttpClient oHttpClient = new HttpClient();
            try
            {
                Task<HttpResponseMessage> oTaskPostAsync = oHttpClient.PostAsync(url, s);
                if (oTaskPostAsync.Result.StatusCode == HttpStatusCode.BadRequest)
                {
                    return "";
                }
                if (oTaskPostAsync.Result.StatusCode == HttpStatusCode.OK || oTaskPostAsync.Result.StatusCode == HttpStatusCode.Created)
                {
                    return oTaskPostAsync.Result.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: true).GetAwaiter()
                        .GetResult();
                    //Get lại 

                }
                return "";
            }
            catch (Exception ex )
            {
                return "";
            }
        }
        private static void SetEnvironment()
        {
            CultureInfo CultureInfo2 = Application.CurrentCulture.Clone() as CultureInfo;
            CultureInfo2 = new CultureInfo("en-US");
            DateTimeFormatInfo dtInfo = new DateTimeFormatInfo();
            dtInfo.LongDatePattern = "MM/dd/yyyy h:mm:ss tt";
            dtInfo.ShortDatePattern = "MM/dd/yyyy";
            CultureInfo2.DateTimeFormat = dtInfo;
            Application.CurrentCulture = CultureInfo2;
            string H_KEY = Config.GetValue("H_KEY").ToString();
            string isRemote2 = "false";
            isRemote2 = Registry.GetValue(H_KEY, "isRemote", "false").ToString();
            Config.NewKeyValue("isRemote", isRemote2);
            Config.NewKeyValue("StartupPath", Application.StartupPath);
        }
    }
}