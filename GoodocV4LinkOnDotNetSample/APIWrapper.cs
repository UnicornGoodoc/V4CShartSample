using System;
using System.Text;
using System.Runtime.InteropServices;

namespace GoodocV4LinkOnDotNetSample
{
    public class APIWrapper
    {
        /// <summary>
        /// typedef int(CALLBACK* GDL_FnCB)(void *pjson, unsigned int nlen);
        /// </summary>
        /// <param name="jsonData">콜백 함수로 리턴되는 void* 값</param>
        /// <param name="length">jsonData의 크기</param>
        /// <returns></returns>
        public delegate int Callback(IntPtr jsonData, uint length);

        /// <summary>
        /// int __stdcall gdl_initw(IN unsigned int nchartcode, IN LPCWSTR phospitalcode, IN int nInitType, IN GDL_FnCB cb);
        /// </summary>
        /// <param name="chartCode">차트 코드(보통 4자리)</param>
        /// <param name="hospitalCode">요양기관번호</param>
        /// <param name="initType">초기화 타입 0: 콜백, 1:폴링</param>
        /// <param name="callback">콜백 대리자. 만약 nInitType이 1이면 NULL</param>
        /// <returns></returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_initw", CharSet = CharSet.Unicode)]
        public extern static int gdlInit(uint chartCode, string hospitalCode, int initType, Callback callback);

        /// <summary>
        /// int __stdcall gdl_getrequestmessagew(IN OUT LPWSTR pjson, IN OUT unsigned int &nlen);
        /// polling 방식인 경우 서버 request를 받아 가는 함수
        /// </summary>
        /// <param name="buffer">서버 요청을 담아갈 버퍼</param>
        /// <param name="length">버퍼 크기(최소 4096 이상)</param>
        /// <returns></returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_getrequestmessagew", CharSet = CharSet.Unicode)]
        public extern static int gdlGetReqeustMessage(StringBuilder buffer, ref uint length);

        /// <summary>
        /// int __stdcall gdl_sendresponsew(IN LPCWSTR pjson, IN unsigned int nlen);
        /// 굿닥 요청에 대한 응답을 전송하는 함수의 unicode type
        /// </summary>
        /// <param name="response">응답 JSON string</param>
        /// <param name="length">응답 string 크기</param>
        /// <returns></returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_sendrespnosew", CharSet = CharSet.Unicode)]
        public extern static int gdlSendResponse(string response, uint length);

        /// <summary>
        /// LPCWSTR __stdcall gdl_sendrequestw(IN LPCWSTR pjson, IN unsigned int nlen);
        /// 서버로 요청을 전송하는 export 함수
        /// </summary>
        /// <param name="request">요청 JSON string</param>
        /// <param name="length">요청 string 크기</param>
        /// <returns></returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_sendrequestw", CharSet = CharSet.Unicode)]
        public extern static int gdlSendRequest(string request, uint length);

        /// <summary>
        /// int __stdcall gdl_sendrequestparamw(IN LPCWSTR pjson, IN unsigned int nlen, IN OUT LPWSTR pret, IN OUT unsigned int &nretlen);
        /// 서버로 요청을 전송하는 export 함수. 결과를 매개변수로 담는다.
        /// </summary>
        /// <param name="request">요청 JSON string</param>
        /// <param name="length">요청 string 크기</param>
        /// <param name="response">응답 버퍼</param>
        /// <param name="responseLength">응답 버퍼 크기(최소 4096)</param>
        /// <returns></returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_sendrequestparamw", CharSet = CharSet.Unicode)]
        public extern static int gdlSendRequestParam(string request, uint length, StringBuilder response, ref uint responseLength);

        /// <summary>
        /// int __stdcall gdl_getjobidw(IN OUT LPWSTR pid, IN OUT unsigned int &nlen);
        /// jobid를 생성하는 함수
        /// </summary>
        /// <param name="id">JobID를 저장할 버퍼</param>
        /// <param name="length">버퍼 크기(최소 37)</param>
        /// <returns></returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_getjobidw", CharSet = CharSet.Unicode)]
        public extern static int gdlGetJobId(StringBuilder id, ref uint length);

        /// <summary>
        /// int __stdcall gdl_geterrorstringw(IN int uncode, IN OUT LPWSTR pstring, IN OUT unsigned int &nlen);
        /// 에러코드에 대한 명세를 리턴하는 함수
        /// </summary>
        /// <param name="code">에러 코드</param>
        /// <param name="errorText">에러 텍스트를 저장할 버퍼</param>
        /// <param name="length">버퍼 크기(최소 256)</param>
        /// <returns></returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_geterrorstringw", CharSet = CharSet.Unicode)]
        public extern static int gdlGetErrorString(int code, StringBuilder errorText, ref uint length);

        /// <summary>
        /// void __stdcall gdl_setbridgeid(IN LPSTR pstring);
        /// (개발용) bridge id를 강제로 변경하는 TEST 함수.
        /// </summary>
        /// <param name="bridgeId">변경하려는 bridgeID</param>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_setbridgeid", CharSet = CharSet.Ansi)]
        public extern static void gdlSetBridgeId([MarshalAs(UnmanagedType.LPStr)] string bridgeId);

        /// <summary>
        /// LPCSTR __stdcall gdl_getbridgeid();
        /// (개발용) bridge id를 리턴하는 함수
        /// </summary>
        /// <returns>Bridge ID</returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_getbridgeid", CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string gdlGetBridgeId();

        /// <summary>
        /// int __stdcall gdl_deinit();
        /// 모든 내부 동작을 초기화 하는 함수
        /// </summary>
        /// <returns>200: 성공</returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_deinit", CharSet = CharSet.Unicode)]
        public extern static int gdlDeinit();

        /// <summary>
        /// int __stdcall gdl_iswcalive();
        /// 웹소켓이 살아있는지 체크
        /// </summary>
        /// <returns>살아 있으면 1, 죽어 있으면 0</returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_iswcalive", CharSet = CharSet.Unicode)]
        public extern static int gdlIsWebsocketAlive();

        /// <summary>
        /// int __stdcall gdl_loginw(IN unsigned int nchartcode, IN LPWSTR pid, IN LPWSTR pw);
        /// (비연동 전용) 로그인 함수
        /// </summary>
        /// <param name="chartCode">차트 코드</param>
        /// <param name="id">사용자 아이디</param>
        /// <param name="password">비밀번호</param>
        /// <returns>200: 성공</returns>
        [DllImport("C:\\goodoc\\bin\\gdbridge.dll", EntryPoint = "gdl_loginw", CharSet = CharSet.Unicode)]
        public extern static int gdlLogin(uint chartCode, string id, string password);
    }
}
