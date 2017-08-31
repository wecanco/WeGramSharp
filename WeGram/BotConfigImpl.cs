using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.telegram.bot.structure;

namespace WindowsFormsApplication1
{
    public class BotConfigImpl : BotConfig
    {
        private string phoneNumber;

        public BotConfigImpl(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            setAuthfile(phoneNumber + ".auth");
        }

        
        public override string getPhoneNumber()
        {
            return phoneNumber;
        }


        
        public override string getBotToken()
        {
            return null;
        }


        
        public override bool isBot()
        {
            return false;
        }
    }
}
