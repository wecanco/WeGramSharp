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
using org.telegram.api.messages.dialogs;
using System.Linq;
using org.telegram.api.chat.channel;
using org.telegram.api.chat;
using WTask = System.Threading.Tasks;
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

        private  int APIKEY = 185606; // your api key
        private  string APIHASH = "c7351fb30842b4abb27c72e5e1680506"; // your api hash                                                       

        public bool IsConnected = false;

        private void Loading(Control c,bool StartStop,string text="")
        {
            if (StartStop)
            {
                NotifyBar.ForeColor = Color.Orange;
                NotifyBar.Text = "کمی شکیبا باشید....";
                if (c != null)
                {
                    c.Enabled = false;
                }

                
            }
            else
            {
                NotifyBar.ForeColor = Color.Black;
                if (text == "")
                {
                    NotifyBar.Text = "انجام شد.";
                }
                else
                {
                    NotifyBar.Text = text;
                }
                if (c != null)
                {
                    c.Enabled = true;
                }
            }

            

        }
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
                            MessageTB.Enabled = false;
                            SendMessageB.Enabled = false;
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
                                MessageTB.Enabled = true;
                                SendMessageB.Enabled = true;
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
                MessageTB.Enabled = true;
                SendMessageB.Enabled = true;
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

        private async WTask.Task<TLContacts> GetAllContacts()
        {

            try
            {
                TLRequestContactsGetContacts req = new TLRequestContactsGetContacts();
                req.setHash("");
                //var res = NewApi.Api().doRpcCall(req);
                var res = await WTask.Task.Run(() => NewApi.Api().doRpcCall(req));
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

        private async WTask.Task<TLUser> SearchContact(string UsernamePhone)
        {
            try
            {
                TLRequestContactsGetContacts req = new TLRequestContactsGetContacts();
                req.setHash("");
                //var res = NewApi.Api().doRpcCall(req);
                var res = await WTask.Task.Run(() => NewApi.Api().doRpcCall(req));
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
                        if (contact.getUserName().ToLower() == UsernamePhone.Trim() || contact.getPhone() == UsernamePhone.Trim())
                        {
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

        private async WTask.Task<TLContactsFound> SearchBotOrChannel(string BouUsername)
        {
            TLContactsFound res = null;
            if (BouUsername != "")
            {
                try
                {
                    TLRequestContactsSearch req = new TLRequestContactsSearch();
                    req.setLimit(1);
                    req.setQ(BouUsername.Trim());
                    //res = (TLContactsFound)Api.doRpcCall(req);
                    res = await WTask.Task.Run(() => (TLContactsFound)Api.doRpcCall(req));
                }
                catch (Exception ex)
                {
                    NotifyBar.Text = "خطا: " + ex.Message;
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

        private async void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Loading(SendMessageB, true);
                string notify = "";
                if (NewApi.isAuthenticated())
                {
                    TLInputPeerUser iuser = null;
                    Random rand = new Random();

                    string search = textBox1.Text.Trim().Replace("@", "").Replace("+", "").Replace(" ", "").ToLower();
                    TLUser user = await FindPeer(search);

                    if (user != null)
                    {
                        TLInputPeerUser Puser = new TLInputPeerUser();
                        Puser.setAccessHash(user.getAccessHash());
                        Puser.setUserId(user.getId());


                        if (search == null || search == "")
                        {
                            search = user.getFirstName() + " " + user.getLastName();
                        }


                        TLRequestMessagesSendMessage req = new TLRequestMessagesSendMessage();
                        req.setRandomId(rand.Next());
                        req.setPeer(Puser);
                        req.setMessage(MessageTB.Text);


                        try
                        {
                            //TLUpdates res = (TLUpdates)Api.doRpcCall(req);
                            var res = await WTask.Task.Run(() => Api.doRpcCall(req));
                            //MessageBox.Show(string.Join(",", res));
                            notify = "پیام به " + search + " ارسال شد.";
                            //NotifyBar.ForeColor = Color.Green;

                        }
                        catch (Exception ex)
                        {
                            notify = "خطا: " + ex.Message;
                            //NotifyBar.ForeColor = Color.Red;
                        }

                    }

                }

                Loading(SendMessageB, false, notify);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           


           

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


        private async  WTask.Task GetMessages(int uID, long uAccess, string type = "chat")
        {
            Loading(null,true);
            TLRequestMessagesGetHistory reqH = new TLRequestMessagesGetHistory();
            reqH.setAddOffset(0);
            reqH.setLimit(100);
            reqH.setOffsetId(0);
            reqH.setOffsetDate(0);
            reqH.setMinId(0);
            reqH.setMaxId(999999);

            TLInputPeerUser upeer = new TLInputPeerUser();
            TLInputPeerChat cpeer = new TLInputPeerChat();
            TLInputPeerChannel chpeer = new TLInputPeerChannel();

            switch (type.ToLower())
            {
                case "user":
                    upeer = new TLInputPeerUser();
                    upeer.setAccessHash(uAccess);
                    upeer.setUserId(uID);
                    reqH.setPeer(upeer);
                    break;
                case "chat":
                    cpeer = new TLInputPeerChat();
                    cpeer.setChatId(uID);
                    reqH.setPeer(cpeer);
                    break;
                case "channel":
                    chpeer = new TLInputPeerChannel();
                    chpeer.setAccessHash(uAccess);
                    chpeer.setChannelId(uID);
                    reqH.setPeer(chpeer);
                    break;
                default:
                    break;
            }


            //var res = NewApi.Api().doRpcCall(reqH);
            var res = await WTask.Task.Run(() => NewApi.Api().doRpcCall(reqH));
            string notify = "";
            if (res == null)
            {
                notify = "درخواست نتیجه ای نداشت!";
                //NotifyBar.ForeColor = Color.Orange;
            }
            else
            {

                MessagesDGV.Rows.Clear();
                if (res.GetType() == typeof(TLMessages))
                {
                    try
                    {
                        TLMessages Messages = (TLMessages)res;
                        foreach (var msg in Messages.getMessages())
                        {
                            try
                            {
                                TLMessage message = (TLMessage)msg;
                                MessagesDGV.Rows.Add(message.getDate(), message.getId(), message.getMessage(), uID,uAccess);
                            }
                            catch { }
                        }
                    }
                    catch { }
                }
                else if (res.GetType() == typeof(TLMessagesSlice))
                {
                    try
                    {
                        TLMessagesSlice Messages = (TLMessagesSlice)res;
                        foreach (var msg in Messages.getMessages())
                        {
                            try
                            {
                                TLMessage message = (TLMessage)msg;
                                MessagesDGV.Rows.Add(message.getDate(), message.getId(), message.getMessage(), uID, uAccess);
                            }
                            catch { }
                        }
                    }
                    catch { }
                }
                else if (res.GetType() == typeof(TLChannelMessages))
                {
                    TLChannelMessages Messages = (TLChannelMessages)res;

                    foreach (var msg in Messages.getMessages())
                    {
                        try
                        {
                            TLMessage message = (TLMessage)msg;
                            MessagesDGV.Rows.Add(message.getDate(), message.getId(), message.getMessage(), uID, uAccess);
                        }
                        catch { }
                    }
                }



            }

            Loading(null, false, notify);

        }


        private async void GetContactsBT_Click(object sender, EventArgs e)
        {
            Loading(GetContactsBT, true);
            TLRequestContactsGetContacts req = new TLRequestContactsGetContacts();
            req.setHash("");
            //var res = NewApi.Api().doRpcCall(req);
            var res = await WTask.Task.Run(() => NewApi.Api().doRpcCall(req));
            if (res == null)
            {
                NotifyBar.Text = "درخواست نتیجه ای نداشت!";
                NotifyBar.ForeColor = Color.Orange;
            }
            else
            {
                ContactsDGV.Rows.Clear();
                TLContacts Contacts = (TLContacts)res;
                foreach (TLUser contact in Contacts.getUsers())
                {
                    ContactsDGV.Rows.Add(contact.getFirstName() + " " + contact.getLastName(), contact.getUserName(), contact.getPhone(), contact.getId(), contact.getAccessHash());
                }

            }
            GetContactsBT.Enabled = true;

        }

        private async void GetGroupsBT_Click(object sender, EventArgs e)
        {
            Loading(GetGroupsBT, true);
            TLRequestMessagesGetDialogs req = new TLRequestMessagesGetDialogs();
            req.setOffsetPeer(new TLInputPeerSelf());
            req.setOffsetDate(0);
            req.setLimit(1000);

            //var res = NewApi.Api().doRpcCall(req);
            var res = await WTask.Task.Run(() => NewApi.Api().doRpcCall(req));
            string notify = "";
            if (res == null)
            {
                notify = "درخواست نتیجه ای نداشت!";
                //NotifyBar.ForeColor = Color.Orange;
            }
            else
            {
                GroupsDGV.Rows.Clear();
                ChannelsDGV.Rows.Clear();
                TLDialogs Dailogs = (TLDialogs)res;
                /*
                var ChanGP = Dailogs.getChats().toArray()
                        .Where(x => x.GetType() == typeof(TLChannel))
                        .Cast<TLChannel>();
                */

                foreach (var dial in Dailogs.getChats())
                {
                    if (dial.GetType() == typeof(TLChat))
                    {
                        TLChat chat = (TLChat)dial;
                        GroupsDGV.Rows.Add(chat.getTitle(), "-", chat.getId(), 0);
                    }
                    else if (dial.GetType() == typeof(TLChannel))
                    {
                        TLChannel chat = (TLChannel)dial;
                        if ((chat.getId() + "").Substring(0, 3) != "100")
                        {
                            GroupsDGV.Rows.Add(chat.getTitle(), chat.getUsername(), chat.getId(), chat.getAccessHash());
                        }
                        else
                        {
                            ChannelsDGV.Rows.Add(chat.getTitle(), chat.getUsername(), chat.getId(), chat.getAccessHash());
                        }
                    }

                }

            }

            Loading(GetGroupsBT, false,notify);
        }

        private async void GroupsDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int chID = Convert.ToInt32(GroupsDGV[2, GroupsDGV.CurrentCell.RowIndex].Value + "");
            long access = Convert.ToInt64(GroupsDGV[3, GroupsDGV.CurrentCell.RowIndex].Value + "");
            if (access == 0)
            {
                await GetMessages(chID, access, "chat");
            }
            else
            {
                await GetMessages(chID, access, "channel");
            }

        }


        private async void ChannelsDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int chID = Convert.ToInt32(ChannelsDGV[2, ChannelsDGV.CurrentCell.RowIndex].Value + "");
            long access = Convert.ToInt64(ChannelsDGV[3, ChannelsDGV.CurrentCell.RowIndex].Value + "");
            await GetMessages(chID, access, "channel");
        }


        private async void ContactsDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chID = Convert.ToInt32(ContactsDGV[3, ContactsDGV.CurrentCell.RowIndex].Value + "");
            long access = Convert.ToInt64(ContactsDGV[4, ContactsDGV.CurrentCell.RowIndex].Value + "");
            await GetMessages(chID, access, "user");
        }

        private async void ChatsDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chID = Convert.ToInt32(ChatsDGV[3, ChatsDGV.CurrentCell.RowIndex].Value + "");
            long access = Convert.ToInt64(ChatsDGV[4, ChatsDGV.CurrentCell.RowIndex].Value + "");
            await GetMessages(chID, access, "user");
        }

        private async void GetChatsBT_Click(object sender, EventArgs e)
        {
            Loading(GetChatsBT, true);
            TLRequestMessagesGetDialogs req = new TLRequestMessagesGetDialogs();
            req.setOffsetPeer(new TLInputPeerSelf());
            req.setOffsetDate(0);
            req.setLimit(1000);

            //var res = NewApi.Api().doRpcCall(req);
            var res = await WTask.Task.Run(() => NewApi.Api().doRpcCall(req));
            if (res == null)
            {
                NotifyBar.Text = "درخواست نتیجه ای نداشت!";
                NotifyBar.ForeColor = Color.Orange;
            }
            else
            {
                ChatsDGV.Rows.Clear();
                TLDialogs Dailogs = (TLDialogs)res;
                foreach (TLUser user in Dailogs.getUsers())
                {
                    ChatsDGV.Rows.Add(user.getFirstName() + " " + user.getLastName(), user.getUserName(), user.getPhone(), user.getId(), user.getAccessHash());
                }

            }
            Loading(GetChatsBT, false);

        }

        private void MessagesDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MessageBOx.Text = MessagesDGV[2, MessagesDGV.CurrentCell.RowIndex].Value + "";
            MessageTB.Text = MessageBOx.Text;
            ForwardTB.Text = MessagesDGV[3, MessagesDGV.CurrentCell.RowIndex].Value+ "\r\n" + 
                MessagesDGV[4, MessagesDGV.CurrentCell.RowIndex].Value + "\r\n"+
                MessagesDGV[1, MessagesDGV.CurrentCell.RowIndex].Value + "\r\n" +
                MessageBOx.Text;
        }

        private async void ForwardB_Click(object sender, EventArgs e)
        {

            if (ForwardTB.Text.Trim() != "" && textBox1.Text.Trim() !="")
            {
                Loading(ForwardB, true);
                string notify = "";


                if (NewApi.isAuthenticated())
                {
                    TLInputPeerUser iuser = null;
                    Random rand = new Random();

                    string search = textBox1.Text.Trim().Replace("@", "").Replace("+", "").Replace(" ", "").ToLower();

                    TLUser user = await FindPeer(search);

                    if (user != null)
                    {
                        TLInputPeerUser Puser = new TLInputPeerUser();
                        Puser.setAccessHash(user.getAccessHash());
                        Puser.setUserId(user.getId());


                        if (search == null || search == "")
                        {
                            search = user.getFirstName() + " " + user.getLastName();
                        }

                        string[] lines = System.Text.RegularExpressions.Regex.Split(ForwardTB.Text.Trim(), "\r\n");
                        long Faccess = 0;
                        int FId = 0;
                        TLIntVector mId = new TLIntVector();
                        FId = Convert.ToInt32(lines[0].Trim() + "");
                        Faccess = Convert.ToInt64(lines[1].Trim() + "");
                        mId.add(Convert.ToInt32(lines[2].Trim() + ""));

                        TLInputPeerUser from = new TLInputPeerUser();
                        from.setAccessHash(Faccess);
                        from.setUserId(FId);

                        TLLongVector lRand = new TLLongVector();
                        lRand.add(rand.Next());

                        TLRequestMessagesForwardMessages req = new TLRequestMessagesForwardMessages();
                        req.setFromPeer(from);
                        req.setToPeer(Puser);
                        req.setId(mId);
                        req.setRandomId(lRand);
                        req.enableSilent(true);
                        req.enableWithMyScore(true);
                        
                        

                        try
                        {
                            //var res = Api.doRpcCall(req);
                            var res = await WTask.Task.Run(() => Api.doRpcCall(req));
                            notify = "پیام به " + search + " فوروارد شد.";
                            //NotifyBar.ForeColor = Color.Green;

                        }
                        catch (Exception ex)
                        {
                            notify = "خطا: " + ex.Message;
                            //NotifyBar.ForeColor = Color.Red;
                        }
                    }

                }

                Loading(ForwardB, false, notify);

            }

        }

        private async WTask.Task<TLUser> FindPeer(string search)
        {
            TLUser user = await SearchContact(search);
            if (user == null)
            {
                TLContactsFound ChBot = await SearchBotOrChannel(search);
                if (ChBot != null)
                {
                    foreach (TLUser us in ChBot.getUsers())
                    {
                        user = us;
                        break;
                    }

                }
            }
            

            return user;
        }





    }
}
