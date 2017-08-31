using org.telegram.api;
using org.telegram.api.auth;
using org.telegram.api.engine;
using org.telegram.api.engine.storage;
using org.telegram.api.functions.auth;
using org.telegram.api.functions.channels;
using org.telegram.api.functions.help;
using org.telegram.api.functions.messages;
using org.telegram.api.functions.users;
using org.telegram.api.input.chat;
using org.telegram.api.input.peer;
using org.telegram.api.messages.chats;
using org.telegram.bot.handlers.interfaces;
using org.telegram.bot.kernel;
using org.telegram.bot.kernel.differenceparameters;
using org.telegram.bot.kernel.engine;
using org.telegram.bot.services;
using org.telegram.bot.structure;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using org.telegram.tl;
using org.telegram.api.functions.contacts;
using org.telegram.api.functions.account;
using org.telegram.api.functions.bots;
using org.telegram.api.contacts;
using org.telegram.api.messages;
using org.telegram.api.message;
using org.telegram.api.contact;
using org.telegram.api.user;
using System.Text;
using System.Diagnostics;
using org.telegram.api.updates;
/************************************/
// گروه نرم افزاری وی کن
// Telegram: @WeCanCo
// Site: WeCan-Co.ir
/************************************/

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public TelegramBot Bot;
        public TelegramNewApi NewApi;
        public BotConfig botConfig;
        public IUsersHandler usersHandler;
        public IChatsHandler chatsHandler;
        public IKernelComm ikc =null;
        public IDifferenceParametersService ids = null;

        LoginStatus BotStatus;

        public TelegramApi Api;
        public AppInfo appInfo;
        public AbsApiState ApiStatus = null;
        public ApiCallback ApiCallB = null;
        public string Device = "PC";
        public string systemVersion = "Win 10";
        public string AppVer = "1.0";
        public string Lang = "fa";

        private  int APIKEY = 6; // your api key
        private   string APIHASH = "eb06d4abfb49dc3eeb1aeb98ae0f581e"; // your api hash                                                       

        public bool IsConnected = false;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            PhoneNumT.Items.Clear();
            String[] allfiles = System.IO.Directory.GetFiles(Application.StartupPath, "*.auth", System.IO.SearchOption.AllDirectories);
            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                PhoneNumT.Items.Add(info.Name.Replace(".auth", ""));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PhoneNumT.Text.Trim() != "")
            {
                botConfig = new BotConfigImpl(PhoneNumT.Text.Trim().Replace(" ", ""));
                ikc = new KernelComm(APIKEY, ApiStatus);
                ikc.setLANGUAGE(Lang);
                ikc.setBotName(Device);
                ikc.setBotVersion(AppVer);
                ikc.setUrandomFileName(Application.StartupPath+"//000000");

                if (ConnectB.Text == "قطع اتصال")
                {
                    if (MessageBox.Show("سکشن شما باطل شود؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            TLRequestAuthLogOut logout = new TLRequestAuthLogOut();
                            Api.doRpcCall(logout);
                            File.Delete((PhoneNumT.Text + ".auth").Trim());
                            IsConnected = false;
                            NotifyBar.Text = "غیرفعال";
                            NotifyBar.ForeColor = Color.Red;
                            ConnectB.BackColor = Color.LightGray;
                            ConnectB.Text = "اتصال";
                            textBox3.Enabled = false;
                            button3.Enabled = false;
                        }
                        catch (RpcException ex)
                        {
                            NotifyBar.Text = ex.getMessage();
                        }
                    }
                }
                else
                {


                    try
                    {
                        NewApi = new TelegramNewApi(APIKEY, APIHASH, botConfig, ikc);
                        BotStatus = NewApi.GetStatus();
                        
                        switch (BotStatus.toString())
                        {
                            case "ALREADYLOGGED":
                                IsConnected = true;
                                TLNearestDc dcInfo = (TLNearestDc)NewApi.Api().doRpcCallNonAuth(new TLRequestHelpGetNearestDc());
                                NewApi.Api().switchToDc(dcInfo.getNearestDc());
                                NewApi.Api().getState().setPrimaryDc(dcInfo.getNearestDc());
                                Api = NewApi.Api();
                                NotifyBar.Text = "فعال " + "(" + PhoneNumT.Text + ")";
                                NotifyBar.ForeColor = Color.Green;
                                ConnectB.BackColor = Color.Red;
                                ConnectB.Text = "قطع اتصال";
                                textBox3.Enabled = true;
                                button3.Enabled = true;
                                VerfyCodeB.Enabled = false;
                                VerfyCodeT.Enabled = false;
                                break;
                            case "CODESENT":
                                IsConnected = false;
                                NotifyBar.Text = "کد ارسال شد. منتظر تایید...";
                                NotifyBar.ForeColor = Color.LightGoldenrodYellow;
                                VerfyCodeT.Enabled = true;
                                VerfyCodeB.Enabled = true;
                                break;
                            default:
                                IsConnected = false;
                                //NotifyBar.Text = BotStatus.toString();
                                NotifyBar.Text = "غیرفعال : " + BotStatus.toString();
                                NotifyBar.ForeColor = Color.Red;
                                break;
                        }

                        /*
                        if (BotStatus == LoginStatus.ALREADYLOGGED)
                        {
                        }

                        if (BotStatus == LoginStatus.CODESENT)
                        {
                        }
                        */


                    }
                    catch (RpcException ex)
                    {
                        IsConnected = false;
                        NotifyBar.Text = ex.getMessage();
                        BotLogger.severe("MAIN", ex);
                        NotifyBar.Text = "غیرفعال";
                        NotifyBar.ForeColor = Color.Red;
                    }

                }

            }else
            {
                NotifyBar.Text = "شمارهمراه صحیح وارد نمایید.";
                NotifyBar.ForeColor = Color.Red;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool success = NewApi.getKernelAuth().setAuthCode(VerfyCodeT.Text);
            if (success)
            {
                BotStatus = LoginStatus.ALREADYLOGGED;
            }

            if (BotStatus == LoginStatus.ALREADYLOGGED)
            {
                IsConnected = true;
                TLNearestDc dcInfo = (TLNearestDc)NewApi.Api().doRpcCallNonAuth(new TLRequestHelpGetNearestDc());
                NewApi.Api().switchToDc(dcInfo.getNearestDc());
                Api = NewApi.Api();
                NotifyBar.Text = "فعال " + "(" + PhoneNumT.Text + ")";
                NotifyBar.ForeColor = Color.Green;
                ConnectB.BackColor = Color.Red;
                ConnectB.Text = "قطع اتصال";
                textBox3.Enabled = true;
                button3.Enabled = true;
                VerfyCodeB.Enabled = false;
                VerfyCodeT.Enabled = false;
            }
            else
            {
                NotifyBar.Text = "شکست در فعالسازی (" + BotStatus + ")";
                NotifyBar.ForeColor = Color.Red;
                IsConnected = false;
                //throw new Exception("Failed to log in: " + BotStatus);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private TLContacts GetAllContacts()
        {

            try
            {
                TLRequestContactsGetContacts req = new TLRequestContactsGetContacts();
                req.setHash("");
                var res = NewApi.Api().doRpcCall(req);
                if (res == null)
                {
                    NotifyBar.Text = "درخواست نتیجه ای نداشت!";
                    NotifyBar.ForeColor = Color.Orange;
                    return null;
                }
                else
                {
                    TLContacts Contacts = (TLContacts)res;
                    return Contacts;

                }

            }
            catch (Exception ex)
            {
                NotifyBar.Text = "خطا: " + ex.Message;
                NotifyBar.ForeColor = Color.Red;
                return null;
            }


            
        }

        private TLUser SearchContact(string UsernamePhone)
        {
            try
            {
                TLRequestContactsGetContacts req = new TLRequestContactsGetContacts();
                req.setHash("");
                var res = NewApi.Api().doRpcCall(req);
                if (res == null)
                {
                    NotifyBar.Text = "درخواست نتیجه ای نداشت!";
                    NotifyBar.ForeColor = Color.Orange;
                    return null;
                }
                else
                {
                    TLContacts Contacts = (TLContacts)res;
                    foreach (TLUser contact in Contacts.getUsers())
                    {
                        if (contact.getUserName() == UsernamePhone.Trim() && contact.getPhone() == UsernamePhone.Trim()) {
                            return contact;
                        }
                    }


                }

            }
            catch (Exception ex)
            {
                NotifyBar.Text = "خطا: " + ex.Message;
                NotifyBar.ForeColor = Color.Red;
                return null;
            }

            return null;

        }

        private TLContactsFound SearchBotOrChannel(string BouUsername)
        {
            TLContactsFound res = null;
            if (BouUsername != "")
            {
                try
                {
                    TLRequestContactsSearch req = new TLRequestContactsSearch();
                    req.setLimit(1);
                    req.setQ(BouUsername.Trim());
                    res = (TLContactsFound)Api.doRpcCall(req);
                }
                catch (Exception ex)
                {
                    NotifyBar.Text = "خطا: "+ex.Message;
                    NotifyBar.ForeColor = Color.Red;
                }

            }
            return res;
        }

        private TLUser SearchUser2(string chanelUserName)
        {
            TLUser res = null;
            if (chanelUserName != "")
            {
                TLUserForeign uf = new TLUserForeign();
                uf.setUsername(chanelUserName.Replace("@", "").ToLower());

            }
            return res;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            if (NewApi.isAuthenticated())
            {
                TLInputPeerUser iuser = null;
                Random rand = new Random();

                string search = textBox1.Text.Trim().Replace("@", "").Replace("+","").Replace(" ","").ToLower();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (search == (dataGridView1[1, i].Value + "").ToLower() || search == (dataGridView1[2, i].Value + "").ToLower())
                    {
                        iuser = new TLInputPeerUser();
                        iuser.setUserId(Convert.ToInt32(dataGridView1[3, i].Value + ""));
                        iuser.setAccessHash(Convert.ToInt64(dataGridView1[4, i].Value + ""));

                        TLRequestMessagesSendMessage req = new TLRequestMessagesSendMessage();
                        req.setPeer(iuser);
                        req.setMessage(textBox3.Text);
                        req.setRandomId(rand.Next());
                        /*
                        TLRequestChannelsCreateChannel ch = new TLRequestChannelsCreateChannel();
                        ch.setTitle("title");
                        ch.setAbout("about");
                        TLUpdates res = (TLUpdates)Api.doRpcCall(ch);
                        
                        TLInputChannel chan = new TLInputChannel();
                        chan.setAccessHash(??????);
                        chan.setChannelId(???????);
                        TLRequestChannelsUpdateUsername upu = new TLRequestChannelsUpdateUsername();
                        upu.setChannel(chan);
                        upu.setUsername("username");
                        TLUpdates res2 = (TLUpdates)Api.doRpcCall(upu);
                        */


                        try
                        {
                            TLUpdates res = (TLUpdates)Api.doRpcCall(req);
                            //MessageBox.Show(string.Join(",", res));
                            NotifyBar.Text = "پیام به " + dataGridView1[1, i].Value + " (" + dataGridView1[2, i].Value + ") ارسال شد.";
                            NotifyBar.ForeColor = Color.Green;

                        }
                        catch (Exception ex)
                        {
                            NotifyBar.Text = "خطا: " + ex.Message;
                            NotifyBar.ForeColor = Color.Red;
                        }

                        break;
                    }
                }


            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            TLRequestContactsGetContacts req = new TLRequestContactsGetContacts();
            req.setHash(""); 
            var res = NewApi.Api().doRpcCall(req);
            if (res == null)
            {
                NotifyBar.Text = "درخواست نتیجه ای نداشت!";
                NotifyBar.ForeColor = Color.Orange;
            }
            else
            {
                dataGridView1.Rows.Clear();
                TLContacts Contacts = (TLContacts)res;
                foreach (TLUser contact in Contacts.getUsers())
                {
                    dataGridView1.Rows.Add(contact.getFirstName()+" "+contact.getLastName(), contact.getUserName(),contact.getPhone(), contact.getId(), contact.getAccessHash());
                }

            }
            
           

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //String process = Process.GetCurrentProcess().ProcessName;
           // Process.Start("cmd.exe", "/c taskkill /F /IM " + process + ".exe /T");
            Process.GetCurrentProcess().Kill();
            Application.ExitThread();

        }

        private void VerfyCodeT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("با کمک حداقلی،نقشی در توسعه این کتابخانه داشته باشید. کمک شما امیدی برای توسعه است.");
            System.Diagnostics.Process.Start("http://wecan-co.ir/payment");
        }
    }
}
