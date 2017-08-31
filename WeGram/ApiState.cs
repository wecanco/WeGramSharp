using org.telegram.api.engine.storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.telegram.api;
using org.telegram.api.auth;
using org.telegram.mtproto.state;

namespace WindowsFormsApplication1
{
    public class ApiState : AbsApiState
    {
        public void doAuth(org.telegram.api.auth.TLAuthorization tla)
        {
            throw new NotImplementedException();
        }

        public byte[] getAuthKey(int i)
        {
            throw new NotImplementedException();
        }

        public ConnectionInfo[] getAvailableConnections(int i)
        {
            throw new NotImplementedException();
        }

        public AbsMTProtoState getMtProtoState(int i)
        {
            throw new NotImplementedException();
        }

        public int getPrimaryDc()
        {
            throw new NotImplementedException();
        }

        public int getUserId()
        {
            throw new NotImplementedException();
        }

        public bool isAuthenticated()
        {
            throw new NotImplementedException();
        }

        public bool isAuthenticated(int i)
        {
            throw new NotImplementedException();
        }

        public void putAuthKey(int i, byte[] barr)
        {
            throw new NotImplementedException();
        }

        public void reset()
        {
            throw new NotImplementedException();
        }

        public void resetAuth()
        {
            throw new NotImplementedException();
        }

        public void setAuthenticated(int i, bool b)
        {
            throw new NotImplementedException();
        }

        public void setPrimaryDc(int i)
        {
            throw new NotImplementedException();
        }

        public void updateSettings(TLConfig tlc)
        {
            throw new NotImplementedException();
        }
    }
}
