using System;
using System.Runtime.InteropServices;

namespace GoodocV4LinkOnDotNetSample
{
    public class APIWrapper
    {
        public delegate int Callback(IntPtr jsonData, uint length);

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_initw", CharSet = CharSet.Unicode)]
        public extern static int gdlInit(uint chartCode, string hospitalCode, int initType, Callback callback);

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_getrequestmessagew", CharSet = CharSet.Unicode)]
        public extern static int gdlGetReqeustMessage(out string json, out uint length);

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_sendrespnosew", CharSet = CharSet.Unicode)]
        public extern static int gdlSendResponse(string json, uint length);

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_sendrequestw", CharSet = CharSet.Unicode)]
        public extern static int gdlSendRequest(string json, uint length);

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_sendrequestparamw", CharSet = CharSet.Unicode)]
        public extern static int gdlSendRequestParam(string json, uint length, out string result, out uint resultLength);

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_getjobidw", CharSet = CharSet.Unicode)]
        public extern static int gdlGetJobId(out string id, out uint length);

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_geterrorstringw", CharSet = CharSet.Unicode)]
        public extern static int gdlGetErrorString(int code, out string errorText, out uint length);

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_setbridgeid", CharSet = CharSet.Unicode)]
        public extern static void gdlSetBridgeId(string bridgeId);

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_getbridgeid", CharSet = CharSet.Unicode)]
        public extern static string gdlGetBridgeId();

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_deinit", CharSet = CharSet.Unicode)]
        public extern static int gdlDeinit();

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_iswcalive", CharSet = CharSet.Unicode)]
        public extern static int gdlIsWebsocketAlive();

        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_loginw", CharSet = CharSet.Unicode)]
        public extern static int gdlLogin(uint chartCode, string id, string password);
    }
}
