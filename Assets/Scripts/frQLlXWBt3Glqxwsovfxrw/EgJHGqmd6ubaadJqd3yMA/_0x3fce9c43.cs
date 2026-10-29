using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

[Serializable]
public class _0x0ff72f50
{
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string payload = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string isMeta = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string meta = "";
}

public class _0x3fce9c43 : MonoBehaviour
{
    internal void Update()
    {
        if (_0x89b055f0 == null)
            return;
        if (_0x4247a1fe())
            _0x828a79a1();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x9a97cc8e();
        if (_0x876d70f6 && _0x61fa304f != null)
            _0x61fa304f.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private GameObject _0x9904033f;
    private bool _0xff6c6445()
    {
        if (_0x3dda637e())
            return true;
        if (_0x89b055f0 != null && _0x89b055f0.CanGoBack)
        {
            WLog(_0xc4bfa98a._0x009c6b41(new byte[36] { 245, 220, 207, 217, 202, 220, 207, 216, 157, 223, 220, 222, 214, 157, 144, 131, 157, 208, 220, 212, 211, 157, 234, 216, 223, 235, 212, 216, 202, 157, 250, 210, 255, 220, 222, 214 }, 189));
            _0x89b055f0.GoBack();
            return true;
        }

        return false;
    }

    private RectTransform _0x61fa304f;
    private string _0xdb9ed5f6()
    {
        return ((char)('a' + _0x3528aebe.Next(0, 26))).ToString();
    }

    private string _0x4258de55;
    private void MarkMainFrameCommitted(string _0xade32d3c)
    {
        _0x3a536d2f = true;
        string _0x62a8d322 = GetUrlHost(_0xade32d3c);
        if (!string.IsNullOrEmpty(_0x62a8d322))
            _0x4258de55 = _0x62a8d322;
    }

    private void OnApplicationFocus(bool _0xff139ff7)
    {
        isApplicationFocus = _0xff139ff7;
        if (_0xff139ff7 && _0x2e6deafb)
        {
            _0xa3fe219a();
        }
    }

    private void WLog(string _0x383d5b9f)
    {
#if B_LOGS
        {
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[7] { 87, 88, 105, 127, 120, 81, 44 }, 12) + _0x383d5b9f);
        }
#endif
    }

    internal string _0x56fb2387(string _0x5854b529)
    {
        int _0x4dc3621a = _0x5854b529.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[3] { 119, 122, 35 }, 30), StringComparison.OrdinalIgnoreCase);
        if (_0x4dc3621a < 0)
            return null;
        string _0x0450f90f = _0x5854b529.Substring(_0x4dc3621a + 3);
        int _0x4ac0f4fb = _0x0450f90f.IndexOf('&');
        return _0x4ac0f4fb >= 0 ? _0x0450f90f.Substring(0, _0x4ac0f4fb) : _0x0450f90f;
    }

    private bool _0x3a536d2f;
    private string _0x6abe5c92 { get; set; }

    private bool _0xfa9bbfbd = false;
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x407ecf3a();
    }

    // WEB VIEW LOGIC
    public bool _0x2e6deafb { get; set; }

    private void _0xde373cf5(string _0x1bc23da9)
    {
        _0xa3fe219a();
        StartCoroutine(_0x8abad77d(_0x1bc23da9));
    }

    internal void _0x9a97cc8e()
    {
        Rect _0x6b541993 = Screen.safeArea;
        Vector2 _0xcc38b7cc = new Vector2(Screen.width, Screen.height);
        if (_0x6b541993 == lastSafe && _0xcc38b7cc == lastSize)
            return;
        // Apply manual padding
        _0x6b541993.xMin += _0x70ed9741;
        _0x6b541993.xMax -= _0xa9f337a5;
        _0x6b541993.yMin += _0x6c65bb3e;
        _0x6b541993.yMax -= _0xa5ccb806;
        // Convert Unity safe area -> native WebView frame
        Rect _0x503fe0d5 = new Rect(_0x6b541993.x, _0xcc38b7cc.y - _0x6b541993.y - _0x6b541993.height, // Y flip for native coordinate system
 _0x6b541993.width, _0x6b541993.height);
        _0x89b055f0.Frame = _0x503fe0d5;
        lastSafe = Screen.safeArea;
        lastSize = _0xcc38b7cc;
    }

    private void _0x7e8d5465(string _0xf8908e57)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[34] { 187, 180, 133, 147, 148, 189, 192, 166, 133, 148, 131, 136, 192, 165, 152, 148, 146, 129, 192, 176, 149, 147, 136, 192, 164, 129, 148, 129, 192, 178, 129, 151, 218, 192 }, 224) + _0xf8908e57);
#endif
            }
        }

        var _0x8d57b3c6 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xf8908e57);
        StartCoroutine(_0x6fc45cad(_0x8d57b3c6));
    }

    internal Vector2 lastSize = Vector2.zero;
    // MAIN FLOW
    private bool _0xaa3ac1b5 { get; set; }

    static byte[] CompressBrotli(byte[] _0x1cbdde77)
    {
        using var _0xc864e153 = new MemoryStream();
        using (var _0x3c37c813 = new BrotliStream(_0xc864e153, SmallestCompression()))
            _0x3c37c813.Write(_0x1cbdde77, 0, _0x1cbdde77.Length);
        return _0xc864e153.ToArray();
    }

    static byte[] UnpackSmallest(byte[] _0x7ea614b1, byte _0xfef593ae)
    {
        if (_0xfef593ae == 0)
            return _0x7ea614b1;
        if (_0xfef593ae == 1)
            return DecompressBrotli(_0x7ea614b1);
        if (_0xfef593ae == 2)
            return DecompressDeflate(_0x7ea614b1);
        throw new FormatException();
    }

    async Task _0x4eb4f68e(string _0xfbe69a23, double _0x6e5a36ec, string _0x4b49f9a6)
    {
        var _0xe7bbc252 = new _0x0ff72f50
        {
            payload = _0x4b49f9a6 ?? ""
        };
        if (_0x6e5a36ec != 1d)
        {
            try
            {
                var _0x7bda6490 = await LeaderboardsService.Instance.GetPlayerScoreAsync(_0xfbe69a23, new GetPlayerScoreOptions { IncludeMetadata = true });
                var _0x350100e8 = ReadScoreMetadata(_0x7bda6490 != null ? _0x7bda6490.Metadata : null);
                if (!string.IsNullOrEmpty(_0x350100e8.isMeta) || !string.IsNullOrEmpty(_0x350100e8.meta))
                {
                    _0xe7bbc252.isMeta = _0x350100e8.isMeta;
                    _0xe7bbc252.meta = _0x350100e8.meta;
                }
            }
            catch (Exception)
            {
            }
        }

        await LeaderboardsService.Instance.AddPlayerScoreAsync(_0xfbe69a23, _0x6e5a36ec, new AddPlayerScoreOptions { Metadata = _0xe7bbc252 });
    }

    private string _0x7dbc9f0c = "";
    internal bool isDestroyedForce = false;
    private void _0x59fdfe72(UniWebView _0x475a19d1)
    {
        if (_0xa5bc27c9)
            return;
        _0xa5bc27c9 = true;
        _0x475a19d1.AddUrlScheme(_0xc4bfa98a._0x009c6b41(new byte[2] { 201, 218 }, 189));
        _0x475a19d1.AddUrlScheme(_0xc4bfa98a._0x009c6b41(new byte[6] { 155, 156, 134, 151, 156, 134 }, 242));
        _0x475a19d1.AddUrlScheme(_0xc4bfa98a._0x009c6b41(new byte[6] { 222, 210, 193, 216, 214, 199 }, 179));
        _0x475a19d1.OnMessageReceived += (_0xde6c8a96, _0x778ddd50) =>
        {
            if (TryOpenExternalLikeChrome(_0x778ddd50.RawMessage))
            {
                _0xb831dd26(false);
                return;
            }
        };
        _0x475a19d1.RegisterShouldHandleRequest(_0x220f6cbb =>
        {
            string _0x07bbc4f9 = _0x220f6cbb != null ? _0x220f6cbb.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x07bbc4f9))
                return true;
            WLog(_0xc4bfa98a._0x009c6b41(new byte[21] { 87, 108, 107, 113, 104, 96, 76, 101, 106, 96, 104, 97, 86, 97, 117, 113, 97, 119, 112, 62, 36 }, 4) + _0x07bbc4f9);
            if (TryOpenExternalLikeChrome(_0x07bbc4f9))
            {
                _0xb831dd26(false);
                return false;
            }

            if (_0x220f6cbb != null && _0x220f6cbb.IsMainFrame && IsGoogleAuthFlowUrl(_0x07bbc4f9) && !_0xbaaec083)
            {
                WLog(_0xc4bfa98a._0x009c6b41(new byte[62] { 64, 108, 100, 99, 45, 90, 104, 111, 91, 100, 104, 122, 45, 105, 104, 121, 104, 110, 121, 104, 105, 45, 74, 98, 98, 106, 97, 104, 45, 108, 120, 121, 101, 45, 88, 95, 65, 45, 32, 51, 45, 127, 104, 97, 98, 108, 105, 45, 122, 100, 121, 101, 45, 74, 98, 98, 106, 97, 104, 45, 88, 76 }, 13));
                _0xbaaec083 = true;
                _0xb831dd26(true);
                _0x89b055f0.SetUserAgent(_0xf1acf3aa());
                _0x89b055f0.Load(_0x07bbc4f9);
                return false;
            }

            return true;
        });
        _0x475a19d1.OnLoadingErrorReceived += (_0xde6c8a96, _0xa2788d44, _0x778ddd50, _0xa302f3ef) =>
        {
            WLog(_0xc4bfa98a._0x009c6b41(new byte[25] { 241, 221, 213, 210, 156, 235, 217, 222, 234, 213, 217, 203, 156, 249, 206, 206, 211, 206, 134, 156, 223, 211, 216, 217, 129 }, 188) + _0xa2788d44 + _0xc4bfa98a._0x009c6b41(new byte[9] { 191, 242, 250, 236, 236, 254, 248, 250, 162 }, 159) + _0x778ddd50);
            string _0xcd28284b = GetFailingUrl(_0xa302f3ef);
            if (string.IsNullOrEmpty(_0xcd28284b) || IsAboutBlank(_0xcd28284b))
                return;
            if (IsSslError(_0xa2788d44, _0x778ddd50) && _0xfdc5c0ce(_0xcd28284b))
            {
                WLog(_0xc4bfa98a._0x009c6b41(new byte[52] { 59, 21, 28, 29, 0, 23, 82, 33, 33, 62, 82, 23, 0, 0, 29, 0, 82, 29, 7, 6, 1, 27, 22, 23, 82, 6, 26, 23, 82, 31, 19, 27, 28, 82, 22, 29, 17, 7, 31, 23, 28, 6, 72, 82, 20, 19, 27, 30, 27, 28, 21, 79 }, 114) + _0xcd28284b + _0xc4bfa98a._0x009c6b41(new byte[6] { 122, 55, 59, 51, 52, 103 }, 90) + _0x4258de55 + _0xc4bfa98a._0x009c6b41(new byte[11] { 113, 50, 62, 60, 60, 56, 37, 37, 52, 53, 108 }, 81) + _0x3a536d2f);
                return;
            }

            _ = _0xb9802098(_0xc4bfa98a._0x009c6b41(new byte[8] { 130, 131, 170, 144, 135, 135, 154, 135 }, 245));
            WLog(_0xc4bfa98a._0x009c6b41(new byte[45] { 147, 191, 183, 176, 254, 137, 187, 188, 136, 183, 187, 169, 254, 184, 191, 183, 178, 183, 176, 185, 254, 139, 140, 146, 254, 243, 224, 254, 177, 174, 187, 176, 254, 187, 166, 170, 187, 172, 176, 191, 178, 178, 167, 228, 254 }, 222) + _0xcd28284b);
            StopCurrentFailedLoad(_0xde6c8a96);
            _0x87fc7fb2(_0xcd28284b);
        };
        _0x475a19d1.OnPageStarted += (_0xde6c8a96, _0xb55b983e) =>
        {
            _0xf72d1b0c = 0;
            if (_0x62e6d6d3 && IsAboutBlank(_0xb55b983e))
            {
                WLog(_0xc4bfa98a._0x009c6b41(new byte[27] { 167, 133, 146, 128, 150, 133, 154, 215, 150, 149, 152, 130, 131, 205, 149, 155, 150, 153, 156, 215, 132, 131, 150, 133, 131, 146, 147 }, 247));
                return;
            }

            _0x3a536d2f = false;
            string _0x18d5161d = GetUrlHost(_0xb55b983e);
            if (!string.IsNullOrEmpty(_0x18d5161d))
                _0x4258de55 = _0x18d5161d;
            WLog(_0xc4bfa98a._0x009c6b41(new byte[29] { 253, 209, 217, 222, 144, 231, 213, 210, 230, 217, 213, 199, 144, 255, 222, 224, 209, 215, 213, 227, 196, 209, 194, 196, 213, 212, 138, 144, 155 }, 176) + (Time.realtimeSinceStartup - _0xe675b7e4).ToString(_0xc4bfa98a._0x009c6b41(new byte[5] { 218, 196, 218, 218, 218 }, 234)) + _0xc4bfa98a._0x009c6b41(new byte[2] { 62, 109 }, 77) + _0xb55b983e);
            if (TryOpenExternalLikeChrome(_0xb55b983e))
            {
                StopCurrentFailedLoad(_0xde6c8a96);
                return;
            }

            if (ContainsIgnoreCase(_0xb55b983e, _0xc4bfa98a._0x009c6b41(new byte[8] { 129, 140, 140, 132, 203, 132, 149, 149 }, 229)) || ContainsIgnoreCase(_0xb55b983e, _0xc4bfa98a._0x009c6b41(new byte[15] { 166, 183, 175, 248, 161, 191, 178, 177, 179, 162, 248, 180, 186, 185, 177 }, 214)) || _0xb55b983e.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[25] { 178, 174, 174, 170, 169, 224, 245, 245, 184, 170, 189, 182, 181, 184, 187, 182, 188, 187, 172, 244, 182, 179, 172, 191, 245 }, 218), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xde6c8a96);
                OpenUrlExternally(_0xb55b983e);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xb55b983e))
            {
                _0xb831dd26(true);
                WLog(_0xc4bfa98a._0x009c6b41(new byte[41] { 150, 190, 190, 182, 189, 180, 241, 176, 164, 165, 185, 241, 183, 189, 190, 166, 241, 181, 180, 165, 180, 178, 165, 180, 181, 241, 252, 239, 241, 186, 180, 180, 161, 241, 167, 184, 162, 184, 179, 189, 180 }, 209));
                return;
            }

            _0x9e7df3c8 = true;
            _0xb831dd26(true);
            WLog(_0xc4bfa98a._0x009c6b41(new byte[43] { 190, 140, 139, 191, 128, 140, 158, 201, 133, 134, 136, 141, 128, 135, 142, 198, 155, 140, 141, 128, 155, 140, 138, 157, 128, 135, 142, 201, 196, 215, 201, 130, 140, 140, 153, 201, 159, 128, 154, 128, 139, 133, 140 }, 233));
        };
        _0x475a19d1.OnPageCommitted += (_0xde6c8a96, _0xb55b983e) =>
        {
            if (_0x62e6d6d3 && IsAboutBlank(_0xb55b983e))
                return;
            MarkMainFrameCommitted(_0xb55b983e);
            WLog(_0xc4bfa98a._0x009c6b41(new byte[31] { 179, 159, 151, 144, 222, 169, 155, 156, 168, 151, 155, 137, 222, 177, 144, 174, 159, 153, 155, 189, 145, 147, 147, 151, 138, 138, 155, 154, 196, 222, 213 }, 254) + (Time.realtimeSinceStartup - _0xe675b7e4).ToString(_0xc4bfa98a._0x009c6b41(new byte[5] { 148, 138, 148, 148, 148 }, 164)) + _0xc4bfa98a._0x009c6b41(new byte[2] { 44, 127 }, 95) + _0xb55b983e);
            if (!firstLoadShown && IsHttpUrl(_0xb55b983e))
            {
                firstLoadShown = true;
                _0x9e7df3c8 = false;
                _0xb831dd26(false);
                _0x7a590efa();
                _0x9a97cc8e();
                _0xde6c8a96.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xb9802098(_0xc4bfa98a._0x009c6b41(new byte[9] { 181, 180, 157, 173, 178, 167, 172, 167, 166 }, 194));
                WLog(_0xc4bfa98a._0x009c6b41(new byte[39] { 119, 91, 83, 84, 26, 109, 95, 88, 108, 83, 95, 77, 26, 73, 82, 85, 77, 84, 26, 85, 84, 26, 89, 85, 87, 87, 83, 78, 78, 95, 94, 26, 89, 85, 84, 78, 95, 84, 78 }, 58));
            }
        };
        _0x475a19d1.OnPageProgressChanged += (_0xde6c8a96, _0x75fe6357) =>
        {
            if (_0x62e6d6d3)
                return;
            if (!firstLoadShown && _0x75fe6357 >= 0.65f)
            {
                firstLoadShown = true;
                _0x9e7df3c8 = false;
                _0xb831dd26(false);
                _0x7a590efa();
                _0x9a97cc8e();
                _0xde6c8a96.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xb9802098(_0xc4bfa98a._0x009c6b41(new byte[9] { 104, 105, 64, 112, 111, 122, 113, 122, 123 }, 31));
                WLog(_0xc4bfa98a._0x009c6b41(new byte[32] { 64, 108, 100, 99, 45, 90, 104, 111, 91, 100, 104, 122, 45, 126, 101, 98, 122, 99, 45, 111, 116, 45, 125, 127, 98, 106, 127, 104, 126, 126, 55, 45 }, 13) + _0x75fe6357);
            }
        };
        _0x475a19d1.OnPageFinished += (_0xde6c8a96, _0xa2788d44, _0xb55b983e) =>
        {
            if (_0x62e6d6d3 && IsAboutBlank(_0xb55b983e))
            {
                _0x62e6d6d3 = false;
                WLog(_0xc4bfa98a._0x009c6b41(new byte[28] { 41, 11, 28, 14, 24, 11, 20, 89, 24, 27, 22, 12, 13, 67, 27, 21, 24, 23, 18, 89, 31, 16, 23, 16, 10, 17, 28, 29 }, 121));
                return;
            }

            WLog(_0xc4bfa98a._0x009c6b41(new byte[24] { 58, 22, 30, 25, 87, 32, 18, 21, 33, 30, 18, 0, 87, 49, 30, 25, 30, 4, 31, 18, 19, 77, 87, 92 }, 119) + (Time.realtimeSinceStartup - _0xe675b7e4).ToString(_0xc4bfa98a._0x009c6b41(new byte[5] { 155, 133, 155, 155, 155 }, 171)) + _0xc4bfa98a._0x009c6b41(new byte[7] { 181, 230, 165, 169, 162, 163, 251 }, 198) + _0xa2788d44 + _0xc4bfa98a._0x009c6b41(new byte[5] { 146, 199, 192, 222, 143 }, 178) + _0xb55b983e);
            if (_0xa2788d44 >= 200 && _0xa2788d44 < 400)
                MarkMainFrameCommitted(_0xb55b983e);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x9e7df3c8 = false;
                _0xb831dd26(false);
                _0x7a590efa();
                _0x9a97cc8e();
                _0xde6c8a96.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xb9802098(_0xc4bfa98a._0x009c6b41(new byte[9] { 97, 96, 73, 121, 102, 115, 120, 115, 114 }, 22));
                WLog(_0xc4bfa98a._0x009c6b41(new byte[33] { 239, 195, 203, 204, 130, 245, 199, 192, 244, 203, 199, 213, 130, 196, 203, 208, 209, 214, 130, 206, 205, 195, 198, 130, 193, 205, 207, 210, 206, 199, 214, 199, 198 }, 162));
            }
            else if (_0x9e7df3c8)
            {
                _0x9e7df3c8 = false;
                _0xb831dd26(false);
                _0xde6c8a96.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0xc4bfa98a._0x009c6b41(new byte[40] { 121, 85, 93, 90, 20, 99, 81, 86, 98, 93, 81, 67, 20, 103, 92, 91, 67, 20, 85, 82, 64, 81, 70, 20, 88, 91, 85, 80, 93, 90, 83, 20, 82, 93, 90, 93, 71, 92, 81, 80 }, 52));
            }
            else
            {
                _0xb831dd26(false);
            }

            if (_0xbaaec083 && !IsGoogleAuthFlowUrl(_0xb55b983e) && !IsGoogleAuthFlowUrl(_0xb55b983e))
            {
                WLog(_0xc4bfa98a._0x009c6b41(new byte[48] { 182, 158, 158, 150, 157, 148, 209, 144, 132, 133, 153, 209, 130, 148, 148, 156, 130, 209, 151, 152, 159, 152, 130, 153, 148, 149, 209, 220, 207, 209, 131, 148, 130, 133, 158, 131, 148, 209, 149, 148, 151, 144, 132, 157, 133, 209, 164, 176 }, 241));
                _0xbaaec083 = false;
                _0x89b055f0.SetUserAgent("");
            }
        };
        _0x475a19d1.OnShouldClose += _0xde6c8a96 =>
        {
            WLog(_0xc4bfa98a._0x009c6b41(new byte[41] { 78, 65, 112, 102, 97, 72, 53, 88, 116, 124, 123, 53, 66, 112, 119, 67, 124, 112, 98, 53, 90, 123, 70, 125, 122, 96, 121, 113, 86, 121, 122, 102, 112, 53, 124, 123, 99, 122, 126, 112, 113 }, 21));
            _0x828a79a1();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x475a19d1.SetPopupPageEventEnabled(true);
        bool _0x4587b00b = false;
        bool _0x857c235b = false;
        _0x475a19d1.OnMultipleWindowOpened += (_0xde6c8a96, _0x9ca1d180) =>
        {
            _0xde6c8a96.ScrollTo(0, 0, false);
            WLog(_0xc4bfa98a._0x009c6b41(new byte[43] { 21, 26, 43, 61, 58, 19, 110, 3, 47, 39, 32, 110, 25, 43, 44, 24, 39, 43, 57, 110, 3, 59, 34, 58, 39, 62, 34, 43, 25, 39, 32, 42, 33, 57, 110, 1, 62, 43, 32, 43, 42, 116, 110 }, 78) + _0x9ca1d180);
            var _0x7eb720f2 = _0x475a19d1.GetPopupWindow(_0x9ca1d180);
            if (_0x7eb720f2 == null)
                return;
            _0xc2b0209e.Add(_0x7eb720f2);
            Debug.Log($"[Test] Popup ID: {_0x7eb720f2.Id}");
            _0x7eb720f2.OnPageStarted += (_0xa71d95bb, _0xb55b983e) =>
            {
                WLog(_0xc4bfa98a._0x009c6b41(new byte[36] { 16, 31, 46, 56, 63, 22, 107, 27, 36, 59, 62, 59, 107, 28, 46, 41, 29, 34, 46, 60, 107, 4, 37, 27, 42, 44, 46, 24, 63, 42, 57, 63, 46, 47, 113, 107 }, 75) + _0xb55b983e);
                _0xf72d1b0c = 0;
                if (string.IsNullOrEmpty(_0xb55b983e) || IsAboutBlank(_0xb55b983e))
                    return;
                if (IsGoogleAuthFlowUrl(_0xb55b983e))
                {
                    WLog(_0xc4bfa98a._0x009c6b41(new byte[57] { 8, 7, 54, 32, 39, 14, 115, 3, 60, 35, 38, 35, 115, 20, 60, 60, 52, 63, 54, 115, 50, 38, 39, 59, 115, 53, 63, 60, 36, 115, 126, 109, 115, 32, 35, 60, 60, 53, 115, 20, 60, 60, 52, 63, 54, 115, 16, 59, 33, 60, 62, 54, 115, 6, 18, 105, 115 }, 83) + _0xb55b983e);
                    _0x4587b00b = false;
                    _0xd07d398a();
                    if (_0xa71d95bb != null && _0xa71d95bb.IsAlive)
                        _0xa71d95bb.EvaluateJavaScript(_0x6a56a3b4());
                    return;
                }

                if (_0x89b055f0 == null)
                    return;
                if (!_0x4587b00b)
                {
                    _0x4587b00b = true;
                    _0x89b055f0.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0xc4bfa98a._0x009c6b41(new byte[39] { 46, 33, 16, 6, 1, 40, 85, 37, 26, 5, 0, 5, 85, 20, 5, 5, 25, 12, 85, 34, 28, 27, 17, 26, 2, 6, 85, 17, 16, 6, 30, 1, 26, 5, 85, 32, 52, 79, 85 }, 117) + _0xb55b983e);
                }

                if (_0xa71d95bb != null && _0xa71d95bb.IsAlive)
                    _0xa71d95bb.EvaluateJavaScript(_0x8d9bc503());
                if (!_0x857c235b && _0xa71d95bb != null && _0xa71d95bb.IsAlive && IsHttpUrl(_0xb55b983e))
                {
                    _0x857c235b = true;
                }
            };
            _0x7eb720f2.OnPageFinished += (_0xa71d95bb, _0xa302f3ef) =>
            {
                string _0x1e759d5e = _0xa302f3ef != null ? _0xa302f3ef.data : string.Empty;
                WLog(_0xc4bfa98a._0x009c6b41(new byte[35] { 233, 230, 215, 193, 198, 239, 146, 226, 221, 194, 199, 194, 146, 229, 215, 208, 228, 219, 215, 197, 146, 244, 219, 220, 219, 193, 218, 215, 214, 136, 146, 199, 192, 222, 143 }, 178) + _0x1e759d5e);
                if (_0xa71d95bb == null || !_0xa71d95bb.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x1e759d5e))
                {
                    _0xd07d398a();
                    _0xa71d95bb.EvaluateJavaScript(_0x6a56a3b4());
                    return;
                }

                if (!_0x4587b00b)
                    return;
                _0xa71d95bb.EvaluateJavaScript(_0x8d9bc503());
            };
        };
        _0x475a19d1.OnMultipleWindowClosed += (_0xde6c8a96, _0x9ca1d180) =>
        {
            _0xc2b0209e.RemoveAll(_0x76991d02 => _0x76991d02 == null || _0x76991d02.Id == _0x9ca1d180 || !_0x76991d02.IsAlive);
            _0xb831dd26(false);
            if (_0xc2b0209e.Count == 0 && _0x89b055f0 != null)
            {
                _0x4587b00b = false;
                _0x857c235b = false;
                _0x02ddd3bc();
            }

            WLog(_0xc4bfa98a._0x009c6b41(new byte[43] { 66, 77, 124, 106, 109, 68, 57, 84, 120, 112, 119, 57, 78, 124, 123, 79, 112, 124, 110, 57, 84, 108, 117, 109, 112, 105, 117, 124, 78, 112, 119, 125, 118, 110, 57, 90, 117, 118, 106, 124, 125, 35, 57 }, 25) + _0x9ca1d180);
        };
        _0x475a19d1.RegisterOnRequestMediaCapturePermission(_0x220f6cbb =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    static byte[] PackSmallest(byte[] _0x8d986750, out byte _0xacd0ac49)
    {
        var _0xdb43aacb = CompressBrotli(_0x8d986750);
        var _0xcb4d413b = CompressDeflate(_0x8d986750);
        if (_0xdb43aacb.Length < _0x8d986750.Length && _0xdb43aacb.Length <= _0xcb4d413b.Length)
        {
            _0xacd0ac49 = 1;
            return _0xdb43aacb;
        }

        if (_0xcb4d413b.Length < _0x8d986750.Length)
        {
            _0xacd0ac49 = 2;
            return _0xcb4d413b;
        }

        _0xacd0ac49 = 0;
        return _0x8d986750;
    }

    private string _0xa6cbdfdf = "";
    private bool _0x45e04553(string _0xaaae17c4)
    {
        try
        {
            using (var _0xecae0ba2 = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[30] { 8, 4, 6, 69, 30, 5, 2, 31, 18, 88, 15, 69, 27, 7, 10, 18, 14, 25, 69, 62, 5, 2, 31, 18, 59, 7, 10, 18, 14, 25 }, 107)))
            using (var _0xd35d59fa = _0xecae0ba2.GetStatic<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[15] { 118, 96, 103, 103, 112, 123, 97, 84, 118, 97, 124, 99, 124, 97, 108 }, 21)))
            using (var _0x547cabc0 = _0xd35d59fa.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[17] { 75, 73, 88, 124, 77, 79, 71, 77, 75, 73, 97, 77, 66, 77, 75, 73, 94 }, 44)))
            using (var _0x00851df2 = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[22] { 123, 116, 126, 104, 117, 115, 126, 52, 121, 117, 116, 110, 127, 116, 110, 52, 83, 116, 110, 127, 116, 110 }, 26)))
            using (var _0xce4b2733 = _0x00851df2.CallStatic<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[8] { 90, 75, 88, 89, 79, 127, 88, 67 }, 42), _0xaaae17c4, 1))
            {
                string _0x45bb917b = _0xce4b2733.Call<string>(_0xc4bfa98a._0x009c6b41(new byte[14] { 51, 49, 32, 7, 32, 38, 61, 58, 51, 17, 44, 32, 38, 53 }, 84), _0xc4bfa98a._0x009c6b41(new byte[20] { 233, 249, 228, 252, 248, 238, 249, 212, 237, 234, 231, 231, 233, 234, 232, 224, 212, 254, 249, 231 }, 139));
                string _0x5926994c = _0xce4b2733.Call<string>(_0xc4bfa98a._0x009c6b41(new byte[10] { 130, 128, 145, 181, 132, 134, 142, 132, 130, 128 }, 229));
                _0xce4b2733.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[11] { 80, 85, 85, 114, 80, 69, 84, 86, 94, 67, 72 }, 49), _0xc4bfa98a._0x009c6b41(new byte[33] { 42, 37, 47, 57, 36, 34, 47, 101, 34, 37, 63, 46, 37, 63, 101, 40, 42, 63, 46, 44, 36, 57, 50, 101, 9, 25, 4, 28, 24, 10, 9, 7, 14 }, 75));
                _0xce4b2733.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[11] { 135, 144, 152, 154, 131, 144, 176, 141, 129, 135, 148 }, 245), _0xc4bfa98a._0x009c6b41(new byte[20] { 223, 207, 210, 202, 206, 216, 207, 226, 219, 220, 209, 209, 223, 220, 222, 214, 226, 200, 207, 209 }, 189));
                if (_0xce4b2733.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[15] { 61, 42, 60, 32, 35, 57, 42, 14, 44, 59, 38, 57, 38, 59, 54 }, 79), _0x547cabc0) != null)
                {
                    WLog(_0xc4bfa98a._0x009c6b41(new byte[24] { 22, 61, 39, 58, 56, 48, 25, 60, 62, 48, 117, 58, 37, 48, 59, 117, 60, 59, 33, 48, 59, 33, 111, 117 }, 85) + _0xaaae17c4);
                    _0xce4b2733.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[8] { 33, 36, 36, 6, 44, 33, 39, 51 }, 64), 0x10000000);
                    _0xd35d59fa.Call(_0xc4bfa98a._0x009c6b41(new byte[13] { 161, 166, 179, 160, 166, 147, 177, 166, 187, 164, 187, 166, 171 }, 210), _0xce4b2733);
                    return true;
                }

                if (_0x4b75ff61(_0x5926994c))
                    return true;
                if (!string.IsNullOrEmpty(_0x45bb917b))
                {
                    WLog(_0xc4bfa98a._0x009c6b41(new byte[28] { 221, 246, 236, 241, 243, 251, 210, 247, 245, 251, 190, 247, 240, 234, 251, 240, 234, 190, 248, 255, 242, 242, 252, 255, 253, 245, 164, 190 }, 158) + _0x45bb917b);
                    if (_0x534cefbd(_0x45bb917b))
                        return _0xa37aefba(_0x45bb917b, _0x5926994c);
                    return _0xfb5aba9a(_0x45bb917b);
                }

                WLog(_0xc4bfa98a._0x009c6b41(new byte[30] { 208, 251, 225, 252, 254, 246, 223, 250, 248, 246, 179, 250, 253, 231, 246, 253, 231, 179, 253, 252, 179, 251, 242, 253, 247, 255, 246, 225, 169, 179 }, 147) + _0xaaae17c4);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xc4bfa98a._0x009c6b41(new byte[26] { 180, 159, 133, 152, 154, 146, 187, 158, 156, 146, 215, 158, 153, 131, 146, 153, 131, 215, 145, 150, 158, 155, 146, 147, 205, 215 }, 247) + e.Message);
            return true;
        }
    }

    static byte[] Decode93(string _0x32f3971c)
    {
        var _0xb7733a6d = System.Numerics.BigInteger.Zero;
        var _0x392835be = new System.Numerics.BigInteger(TextAlphabet.Length);
        for (int _0x8562aec3 = 0; _0x8562aec3 < _0x32f3971c.Length; _0x8562aec3++)
        {
            char _0x4076c1c1 = _0x32f3971c[_0x8562aec3];
            if (_0x4076c1c1 >= _0x0e2df199.Length)
                throw new FormatException();
            int _0xfd94f97d = _0x0e2df199[_0x4076c1c1];
            if (_0xfd94f97d < 0)
                throw new FormatException();
            _0xb7733a6d = _0xb7733a6d * _0x392835be + _0xfd94f97d;
        }

        var _0x49616728 = ToBigEndian(_0xb7733a6d);
        if (_0x49616728.Length < 2 || _0x49616728[0] != 1)
            throw new FormatException();
        var _0x1c4eb9b7 = new byte[_0x49616728.Length - 1];
        Buffer.BlockCopy(_0x49616728, 1, _0x1c4eb9b7, 0, _0x1c4eb9b7.Length);
        return _0x1c4eb9b7;
    }

    private async Task<bool> _0xde0af158(int _0x264e36c3 = 5, int _0xacb5b241 = 500)
    {
        CommState _0xf97bb795 = default;
        int _0x2351fe53 = 0;
        do
        {
            try
            {
                _0xf97bb795 = await _0x99adb980();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[32] { 186, 181, 132, 146, 149, 188, 193, 144, 148, 132, 147, 152, 160, 146, 152, 143, 130, 179, 132, 146, 148, 141, 149, 146, 193, 132, 147, 147, 142, 147, 219, 193 }, 225) + e.Message);
                    }
#endif
                }
            }

            if (_0xf97bb795.Ready)
                break;
            await Task.Delay(_0xacb5b241);
        }
        while (_0x2351fe53++ < _0x264e36c3);
        bool _0x2097cfdf = _0xf97bb795.Ready && _0xf97bb795.IsPrivacy;
        {
#if B_LOGS
            {
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[25] { 255, 240, 193, 215, 208, 249, 132, 237, 215, 244, 214, 205, 210, 197, 199, 221, 132, 214, 193, 215, 209, 200, 208, 158, 132 }, 164) + _0x2097cfdf);
            }
#endif
        }

        return _0x2097cfdf;
    }

    private string _0x22419dd8 = "";
    private IEnumerator _0x223f0ed2(string _0x2078045c)
    {
        if (Permission.HasUserAuthorizedPermission(_0x2078045c))
            yield break;
        bool _0x303399f1 = false;
        var _0x51c00050 = new PermissionCallbacks();
        _0x51c00050.PermissionGranted += _0xda1d787c => _0x303399f1 = true;
        _0x51c00050.PermissionDenied += _0xda1d787c => _0x303399f1 = true;
        Permission.RequestUserPermission(_0x2078045c, _0x51c00050);
        yield return new WaitUntil(() => _0x303399f1);
    }

    private async Task<bool> _0x09053d18()
    {
        {
#if B_LOGS
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[29] { 107, 100, 85, 67, 68, 109, 16, 121, 67, 96, 66, 89, 70, 81, 83, 73, 113, 94, 84, 99, 81, 70, 85, 84, 115, 88, 85, 83, 91 }, 48));
#endif
        }

        string _0xe08c99e7 = "";
        for (int _0x12eb1d07 = 0; _0x12eb1d07 < 2; _0x12eb1d07++)
        {
            if (await _0xde0af158(1, 100))
            {
                await _0xb9802098(_0xc4bfa98a._0x009c6b41(new byte[7] { 78, 64, 67, 79, 71, 73, 72 }, 44));
                _0x407ecf3a();
                return true;
            }

            _0xe08c99e7 = await _0x13475a2e(1, 100);
            if (!string.IsNullOrEmpty(_0xe08c99e7))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xe08c99e7))
            {
                if (!string.IsNullOrEmpty(_0x24549f26))
                {
                    _0xe08c99e7 = _0x2dc380c3(_0xe08c99e7, _0x24549f26);
                    {
#if B_LOGS
                        Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[53] { 185, 182, 135, 145, 150, 191, 194, 161, 131, 129, 138, 135, 134, 194, 132, 139, 140, 131, 142, 183, 144, 142, 194, 149, 139, 150, 138, 194, 145, 135, 140, 134, 139, 134, 194, 0, 100, 112, 194, 145, 138, 141, 149, 194, 181, 135, 128, 180, 139, 135, 149, 216, 194 }, 226) + _0xe08c99e7);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[39] { 84, 91, 106, 124, 123, 82, 47, 76, 110, 108, 103, 106, 107, 47, 105, 102, 97, 110, 99, 90, 125, 99, 47, 237, 137, 157, 47, 124, 103, 96, 120, 47, 88, 106, 109, 89, 102, 106, 120 }, 15));
#endif
                    }
                }

                _0xfa9bbfbd = true;
                _0xde373cf5(_0xe08c99e7);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[44] { 237, 226, 211, 197, 194, 235, 150, 243, 206, 213, 211, 198, 194, 223, 217, 216, 150, 193, 222, 223, 218, 211, 150, 213, 222, 211, 213, 221, 223, 216, 209, 150, 197, 215, 192, 211, 210, 150, 218, 223, 216, 221, 140, 150 }, 182) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    static byte[] DecompressBrotli(byte[] _0xacd650b2)
    {
        using var _0xb0620d73 = new MemoryStream(_0xacd650b2);
        using var _0xfc3381d7 = new BrotliStream(_0xb0620d73, CompressionMode.Decompress);
        using var _0x15c7aea3 = new MemoryStream();
        _0xfc3381d7.CopyTo(_0x15c7aea3);
        return _0x15c7aea3.ToArray();
    }

    private bool _0x62e6d6d3 = false;
    private string _0xb07c6a5e = "";
    private readonly string[] _0x4cd920c6 = new string[]
    {
        _0xc4bfa98a._0x009c6b41(new byte[60] { 170, 197, 212, 234, 122, 14, 50, 63, 122, 40, 63, 63, 54, 41, 122, 59, 40, 63, 122, 50, 53, 46, 122, 40, 51, 61, 50, 46, 122, 52, 53, 45, 122, 184, 218, 201, 122, 62, 53, 52, 184, 218, 195, 46, 122, 55, 51, 41, 41, 122, 35, 53, 47, 40, 122, 41, 42, 51, 52, 123 }, 90),
        _0xc4bfa98a._0x009c6b41(new byte[52] { 33, 78, 92, 81, 241, 152, 165, 241, 178, 190, 164, 189, 181, 241, 179, 180, 241, 168, 190, 164, 163, 241, 189, 164, 178, 186, 168, 241, 188, 190, 188, 180, 191, 165, 241, 51, 81, 66, 241, 166, 185, 168, 241, 162, 165, 190, 161, 241, 191, 190, 166, 238 }, 209),
        _0xc4bfa98a._0x009c6b41(new byte[66] { 107, 19, 40, 102, 49, 6, 169, 203, 224, 238, 169, 254, 224, 231, 250, 169, 232, 251, 236, 169, 225, 224, 253, 253, 224, 231, 238, 169, 228, 230, 251, 236, 169, 230, 239, 253, 236, 231, 169, 253, 230, 237, 232, 240, 169, 107, 9, 26, 169, 250, 253, 232, 240, 169, 224, 231, 169, 253, 225, 236, 169, 238, 232, 228, 236, 167 }, 137),
        _0xc4bfa98a._0x009c6b41(new byte[54] { 127, 16, 26, 29, 175, 219, 231, 230, 252, 175, 230, 252, 175, 255, 253, 230, 226, 234, 175, 251, 230, 226, 234, 175, 109, 15, 28, 175, 251, 231, 234, 175, 237, 234, 252, 251, 175, 255, 227, 238, 246, 234, 253, 252, 175, 255, 227, 238, 246, 175, 225, 224, 248, 161 }, 143),
        _0xc4bfa98a._0x009c6b41(new byte[48] { 142, 225, 234, 219, 94, 39, 17, 11, 12, 94, 9, 23, 16, 16, 23, 16, 25, 94, 13, 10, 12, 27, 31, 21, 94, 29, 17, 11, 18, 26, 94, 28, 27, 94, 17, 16, 27, 94, 13, 14, 23, 16, 94, 31, 9, 31, 7, 80 }, 126),
        _0xc4bfa98a._0x009c6b41(new byte[65] { 133, 234, 239, 245, 85, 63, 20, 22, 30, 5, 26, 1, 6, 85, 20, 7, 16, 85, 24, 26, 7, 16, 85, 20, 22, 1, 28, 3, 16, 85, 1, 26, 27, 28, 18, 29, 1, 85, 151, 245, 230, 85, 6, 1, 20, 12, 85, 20, 27, 17, 85, 1, 7, 12, 85, 12, 26, 0, 7, 85, 25, 0, 22, 30, 91 }, 117),
        _0xc4bfa98a._0x009c6b41(new byte[55] { 189, 210, 195, 255, 109, 8, 59, 40, 63, 52, 109, 62, 61, 36, 35, 109, 46, 34, 56, 35, 57, 62, 109, 175, 205, 222, 109, 57, 37, 40, 109, 35, 40, 53, 57, 109, 34, 35, 40, 109, 46, 34, 56, 33, 41, 109, 47, 40, 109, 52, 34, 56, 63, 62, 99 }, 77),
        _0xc4bfa98a._0x009c6b41(new byte[63] { 110, 33, 28, 99, 52, 3, 172, 220, 224, 237, 245, 233, 254, 255, 172, 254, 229, 235, 228, 248, 172, 226, 227, 251, 172, 237, 254, 233, 172, 251, 229, 226, 226, 229, 226, 235, 172, 110, 12, 31, 172, 232, 227, 226, 110, 12, 21, 248, 172, 251, 237, 224, 231, 172, 237, 251, 237, 245, 172, 245, 233, 248, 162 }, 140),
        _0xc4bfa98a._0x009c6b41(new byte[51] { 2, 109, 125, 116, 210, 189, 156, 158, 139, 210, 134, 154, 157, 129, 151, 210, 133, 154, 157, 210, 129, 134, 147, 139, 210, 155, 156, 210, 134, 154, 151, 210, 149, 147, 159, 151, 210, 133, 155, 156, 210, 134, 154, 151, 210, 130, 128, 155, 136, 151, 220 }, 242),
        _0xc4bfa98a._0x009c6b41(new byte[64] { 76, 52, 15, 65, 22, 33, 142, 227, 193, 195, 203, 192, 218, 219, 195, 142, 199, 221, 142, 203, 216, 203, 220, 215, 218, 198, 199, 192, 201, 142, 76, 46, 61, 142, 197, 203, 203, 222, 142, 221, 222, 199, 192, 192, 199, 192, 201, 142, 200, 193, 220, 142, 215, 193, 219, 220, 142, 205, 198, 207, 192, 205, 203, 128 }, 174)
    };
    private int _0x76473584 = -1;
    private bool _0x4247a1fe()
    {
        var _0x9fe9f541 = Keyboard.current;
        return _0x9fe9f541 != null && _0x9fe9f541.escapeKey.wasPressedThisFrame;
    }

    private static readonly string WindowsDesktopUserAgent = _0xc4bfa98a._0x009c6b41(new byte[111] { 67, 97, 116, 103, 98, 98, 111, 33, 59, 32, 62, 46, 38, 89, 103, 96, 106, 97, 121, 125, 46, 64, 90, 46, 63, 62, 32, 62, 53, 46, 89, 103, 96, 56, 58, 53, 46, 118, 56, 58, 39, 46, 79, 126, 126, 98, 107, 89, 107, 108, 69, 103, 122, 33, 59, 61, 57, 32, 61, 56, 46, 38, 69, 70, 90, 67, 66, 34, 46, 98, 103, 101, 107, 46, 73, 107, 109, 101, 97, 39, 46, 77, 102, 124, 97, 99, 107, 33, 63, 60, 62, 32, 62, 32, 62, 32, 62, 46, 93, 111, 104, 111, 124, 103, 33, 59, 61, 57, 32, 61, 56 }, 14);
    static byte[] ToBigEndian(System.Numerics.BigInteger _0x79da690f)
    {
        var _0xcbaba4c5 = _0x79da690f.ToByteArray();
        int _0x8456ddcb = _0xcbaba4c5.Length;
        if (_0x8456ddcb > 1 && _0xcbaba4c5[_0x8456ddcb - 1] == 0)
            _0x8456ddcb--;
        var _0xd5f3ca19 = new byte[_0x8456ddcb];
        for (int _0x1bfe4b07 = 0; _0x1bfe4b07 < _0x8456ddcb; _0x1bfe4b07++)
            _0xd5f3ca19[_0x1bfe4b07] = _0xcbaba4c5[_0x8456ddcb - 1 - _0x1bfe4b07];
        return _0xd5f3ca19;
    }

    internal bool isApplicationFocus = false;
    private UniWebViewPopup _0xfdc76b9f()
    {
        for (int _0x3a56f65d = _0xc2b0209e.Count - 1; _0x3a56f65d >= 0; _0x3a56f65d--)
        {
            var _0xcfb1db96 = _0xc2b0209e[_0x3a56f65d];
            if (_0xcfb1db96 != null && _0xcfb1db96.IsAlive)
                return _0xcfb1db96;
            _0xc2b0209e.RemoveAt(_0x3a56f65d);
        }

        return null;
    }

    private string _0x7cc5d92b(string _0xe163d081, string _0x0ddfb97b)
    {
        try
        {
            if (string.IsNullOrEmpty(_0xe163d081))
                return "";
            var _0xc8cdbcb5 = Decode93(_0xe163d081);
            if (_0xc8cdbcb5.Length < 5)
                return "";
            var _0x18994309 = new byte[4];
            Buffer.BlockCopy(_0xc8cdbcb5, 0, _0x18994309, 0, 4);
            var _0xfcc9f679 = new byte[_0xc8cdbcb5.Length - 4];
            Buffer.BlockCopy(_0xc8cdbcb5, 4, _0xfcc9f679, 0, _0xfcc9f679.Length);
            var _0xa4b8a138 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x0ddfb97b ?? ""));
            var _0xfb3f7dab = AesCtr(_0xfcc9f679, _0xa4b8a138, _0x18994309);
            var _0xfbc00877 = new byte[_0xfb3f7dab.Length - 1];
            Buffer.BlockCopy(_0xfb3f7dab, 1, _0xfbc00877, 0, _0xfbc00877.Length);
            return Encoding.UTF8.GetString(UnpackSmallest(_0xfbc00877, _0xfb3f7dab[0]));
        }
        catch (Exception)
        {
            return "";
        }
    }

    static byte[] CompressDeflate(byte[] _0x41db9ac5)
    {
        using var _0x6e365ecd = new MemoryStream();
        using (var _0xd919d743 = new DeflateStream(_0x6e365ecd, SmallestCompression()))
            _0xd919d743.Write(_0x41db9ac5, 0, _0x41db9ac5.Length);
        return _0x6e365ecd.ToArray();
    }

    private bool _0x489efd30 = false;
    private void _0x4a0618f0(string _0x95660f03)
    {
        Dictionary<string, object> _0x04df71fd;
        try
        {
            _0x04df71fd = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x95660f03);
        }
        catch
        {
            return;
        }

        var _0x7f4eb773 = ReadPushField(_0x04df71fd, _0xc4bfa98a._0x009c6b41(new byte[3] { 115, 116, 106 }, 6));
        if (string.IsNullOrWhiteSpace(_0x7f4eb773))
            return;
        _0x7f4eb773 = _0x7f4eb773.Trim();
        if (!IsHttpUrl(_0x7f4eb773))
            return;
        if (string.Equals(_0x7f4eb773, _0xa1a1c927, StringComparison.Ordinal))
            return;
        _0xa1a1c927 = _0x7f4eb773;
        OpenUrlExternally(_0x7f4eb773);
    }

    private void _0xb831dd26(bool _0x40d79a43)
    {
        _0xff1c0570();
        _0x9904033f.SetActive(_0x40d79a43);
        _0x876d70f6 = _0x40d79a43;
        if (_0x40d79a43)
        {
            _0x9904033f.transform.SetAsLastSibling();
            if (_0x61fa304f != null)
                _0x61fa304f.localRotation = Quaternion.identity;
        }
    }

    private IEnumerator _0x81efab39()
    {
        yield return _0x223f0ed2(Permission.Camera);
    }

    private bool IsSslError(int _0xdf114e68, string _0x5ff4cab3)
    {
        if (_0xdf114e68 == -1202 || _0xdf114e68 == -1200 || _0xdf114e68 == -11 || _0xdf114e68 == -202)
            return true;
        if (string.IsNullOrEmpty(_0x5ff4cab3))
            return false;
        return _0x5ff4cab3.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[3] { 178, 178, 173 }, 225), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5ff4cab3.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[11] { 70, 64, 87, 81, 76, 67, 76, 70, 68, 81, 64 }, 37), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5ff4cab3.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[4] { 169, 175, 184, 190 }, 234), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool TryOpenExternalLikeChrome(string _0x141eeb6d)
    {
        if (string.IsNullOrEmpty(_0x141eeb6d))
            return false;
        if (_0x141eeb6d.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[9] { 173, 170, 176, 161, 170, 176, 254, 235, 235 }, 196), StringComparison.OrdinalIgnoreCase))
            return _0x45e04553(_0x141eeb6d);
        if (_0x534cefbd(_0x141eeb6d))
            return _0xa37aefba(_0x141eeb6d, null);
        if (!_0x141eeb6d.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[7] { 254, 226, 226, 230, 172, 185, 185 }, 150), StringComparison.OrdinalIgnoreCase) && !_0x141eeb6d.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[8] { 15, 19, 19, 23, 20, 93, 72, 72 }, 103), StringComparison.OrdinalIgnoreCase) && !_0x141eeb6d.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[11] { 126, 125, 112, 106, 107, 37, 125, 115, 126, 113, 116 }, 31), StringComparison.OrdinalIgnoreCase))
        {
            return _0xfb5aba9a(_0x141eeb6d);
        }

        return false;
    }

    private Canvas _0xa7c5f9bc()
    {
        if (_0xaf72f939 != null)
            return _0xaf72f939;
        var _0x87c5239f = gameObject.GetComponentInChildren<Canvas>();
        if (_0x87c5239f == null)
        {
            var _0x6ab9fb35 = new GameObject(_0xc4bfa98a._0x009c6b41(new byte[6] { 160, 130, 141, 149, 130, 144 }, 227), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x87c5239f = _0x6ab9fb35.GetComponent<Canvas>();
            _0x87c5239f.transform.SetParent(transform, false);
            _0x87c5239f.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xaf72f939 = _0x87c5239f;
        return _0xaf72f939;
    }

    private int _0xa5ccb806 = 5, _0x6c65bb3e = 5, _0x70ed9741 = 5, _0xa9f337a5 = 5;
    private async void Start()
    {
        await _0x6973a186();
    }

    readonly struct CommState
    {
        public readonly bool Ready;
        public readonly bool IsPrivacy;
        public readonly string SavedLink;
        public CommState(bool _0x7b6659d4, bool _0x6b6c0b3e, string _0x24d856a3)
        {
            Ready = _0x7b6659d4;
            IsPrivacy = _0x6b6c0b3e;
            SavedLink = _0x24d856a3 ?? "";
        }
    }

    private IEnumerator _0x8abad77d(string _0x00547bb7)
    {
        if (_0x89b055f0 != null && _0x2e6deafb)
            yield break;
        _0x89b055f0 = gameObject.AddComponent<UniWebView>();
        _0x7afce704(_0x89b055f0);
        _0x59fdfe72(_0x89b055f0);
        _0x89b055f0.BackgroundColor = Color.clear;
        var _0xd064e1eb = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x9a97cc8e();
        yield return new WaitForEndOfFrame();
        _0x2e6deafb = true;
        _0xff1c0570();
        _0xb831dd26(true);
        _0x62e6d6d3 = false;
        _0xbaaec083 = false;
        _0xc2b0209e.Clear();
        _0x76473584 = -1;
        firstLoadShown = false;
        _0x9e7df3c8 = false;
        _0x489efd30 = false;
        _0x89b055f0.SetUserAgent("");
        _0xe675b7e4 = Time.realtimeSinceStartup;
        _0x89b055f0.Stop();
        _0x89b055f0.Load(_0x00547bb7);
        _0x89b055f0.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0xc4bfa98a._0x009c6b41(new byte[25] { 169, 133, 141, 138, 196, 179, 129, 134, 178, 141, 129, 147, 196, 173, 138, 141, 144, 141, 133, 136, 196, 183, 140, 139, 147 }, 228));
    }

    private bool _0x876d70f6 = false;
    private void StopCurrentFailedLoad(UniWebView _0xfd78d2ba)
    {
        _0xb831dd26(false);
        if (_0xfd78d2ba == null)
            return;
        _0xfd78d2ba.Stop();
        if (_0xfd78d2ba.CanGoBack)
            _0xfd78d2ba.GoBack();
    }

    private IEnumerator _0xf10c143f(IEnumerator _0x59cc933a, TaskCompletionSource<bool> _0xbd049d1c)
    {
        yield return _0x59cc933a;
        _0xbd049d1c.SetResult(true);
    }

    internal bool _0x534cefbd(string _0xcae34aab)
    {
        return _0xcae34aab.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[9] { 241, 253, 238, 247, 249, 232, 166, 179, 179 }, 156), StringComparison.OrdinalIgnoreCase) || _0xcae34aab.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[24] { 188, 160, 160, 164, 167, 238, 251, 251, 164, 184, 181, 173, 250, 179, 187, 187, 179, 184, 177, 250, 183, 187, 185, 251 }, 212), StringComparison.OrdinalIgnoreCase) || _0xcae34aab.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[23] { 18, 14, 14, 10, 64, 85, 85, 10, 22, 27, 3, 84, 29, 21, 21, 29, 22, 31, 84, 25, 21, 23, 85 }, 122), StringComparison.OrdinalIgnoreCase);
    }

    private AndroidJavaObject _0x63ce9f62 { get; set; }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x89b055f0 = null;
    internal Button _0x1a35abf4(string _0x2f9d66ac, Transform _0xa0b2bfc5)
    {
        var _0x523bb806 = new GameObject(_0x2f9d66ac + _0xc4bfa98a._0x009c6b41(new byte[3] { 238, 216, 194 }, 172), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xfb1f43a9 = _0x523bb806.GetComponent<RectTransform>();
        _0xfb1f43a9.SetParent(_0xa0b2bfc5, false);
        var _0x3988dd97 = _0x523bb806.GetComponent<Image>();
        _0x3988dd97.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xfc739c2b = _0x523bb806.GetComponent<Button>();
        var _0x87922e24 = _0xfc739c2b.colors;
        _0x87922e24.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x87922e24.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xfc739c2b.colors = _0x87922e24;
        var _0x8e85d410 = new GameObject(_0xc4bfa98a._0x009c6b41(new byte[4] { 235, 218, 199, 203 }, 191), typeof(RectTransform), typeof(Text));
        var _0x0c9b0e11 = _0x8e85d410.GetComponent<RectTransform>();
        _0x0c9b0e11.SetParent(_0x523bb806.transform, false);
        _0x0c9b0e11.anchorMin = Vector2.zero;
        _0x0c9b0e11.anchorMax = Vector2.one;
        _0x0c9b0e11.offsetMin = _0x0c9b0e11.offsetMax = Vector2.zero;
        var _0x2558a77e = _0x8e85d410.GetComponent<Text>();
        _0x2558a77e.text = _0x2f9d66ac;
        _0x2558a77e.alignment = TextAnchor.MiddleCenter;
        _0x2558a77e.color = Color.black;
        _0x2558a77e.font = Resources.GetBuiltinResource<Font>(_0xc4bfa98a._0x009c6b41(new byte[9] { 61, 14, 21, 29, 16, 82, 8, 8, 26 }, 124));
        _0x2558a77e.fontSize = 28;
        WLog(_0xc4bfa98a._0x009c6b41(new byte[14] { 140, 189, 170, 174, 187, 170, 141, 186, 187, 187, 160, 161, 239, 232 }, 207) + _0x2f9d66ac + _0xc4bfa98a._0x009c6b41(new byte[1] { 84 }, 115));
        return _0xfc739c2b;
    }

    static System.Numerics.BigInteger FromBigEndian(byte[] _0x4e8cc9bc)
    {
        var _0x6a3d5078 = new byte[_0x4e8cc9bc.Length + 1];
        for (int _0x817b0466 = 0; _0x817b0466 < _0x4e8cc9bc.Length; _0x817b0466++)
            _0x6a3d5078[_0x4e8cc9bc.Length - 1 - _0x817b0466] = _0x4e8cc9bc[_0x817b0466];
        return new System.Numerics.BigInteger(_0x6a3d5078);
    }

    private string _0x5fc8b7d6 = "";
    private bool _0xa5bc27c9 = false;
    private bool _0xfdc5c0ce(string _0xb89a4c12)
    {
        string _0x276dc696 = GetUrlHost(_0xb89a4c12);
        if (!string.IsNullOrEmpty(_0x276dc696) && !string.IsNullOrEmpty(_0x4258de55) && !string.Equals(_0x276dc696, _0x4258de55, StringComparison.OrdinalIgnoreCase))
            return true;
        return _0x3a536d2f;
    }

    private void _0xa3fe219a()
    {
        using (var _0xfd515cc3 = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[30] { 88, 84, 86, 21, 78, 85, 82, 79, 66, 8, 95, 21, 75, 87, 90, 66, 94, 73, 21, 110, 85, 82, 79, 66, 107, 87, 90, 66, 94, 73 }, 59)))
        using (var _0x55eb9226 = _0xfd515cc3.GetStatic<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[15] { 132, 146, 149, 149, 130, 137, 147, 166, 132, 147, 142, 145, 142, 147, 158 }, 231)))
        using (var _0x58a22cfb = _0x55eb9226.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[9] { 46, 44, 61, 0, 39, 61, 44, 39, 61 }, 73)))
        {
            if (_0x58a22cfb == null)
                return;
            using (var _0x10cf60b7 = _0x58a22cfb.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[9] { 108, 110, 127, 78, 115, 127, 121, 106, 120 }, 11)))
            {
                if (_0x10cf60b7 == null)
                    return;
                using (var _0x9c357c53 = new AndroidJavaObject(_0xc4bfa98a._0x009c6b41(new byte[19] { 29, 0, 21, 92, 24, 1, 29, 28, 92, 56, 33, 61, 60, 61, 16, 24, 23, 17, 6 }, 114)))
                using (var _0x7d8dd771 = _0x10cf60b7.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[6] { 147, 157, 129, 171, 157, 140 }, 248)))
                using (var _0xb214012e = _0x7d8dd771.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[8] { 208, 205, 220, 203, 216, 205, 214, 203 }, 185)))
                {
                    while (_0xb214012e.Call<bool>(_0xc4bfa98a._0x009c6b41(new byte[7] { 53, 60, 46, 19, 56, 37, 41 }, 93)))
                    {
                        string _0x84afa76d = _0xb214012e.Call<string>(_0xc4bfa98a._0x009c6b41(new byte[4] { 206, 197, 216, 212 }, 160));
                        using (var _0x40b69793 = _0x10cf60b7.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[3] { 172, 174, 191 }, 203), _0x84afa76d))
                        {
                            _0x9c357c53.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[3] { 241, 244, 245 }, 129), _0x84afa76d, _0x40b69793);
                        }
                    }

                    string _0xe05ddb73 = _0x9c357c53.Call<string>(_0xc4bfa98a._0x009c6b41(new byte[8] { 5, 30, 34, 5, 3, 24, 31, 22 }, 113));
                    if (!string.IsNullOrEmpty(_0xe05ddb73))
                    {
                        _0x4a0618f0(_0xe05ddb73);
                        _0x7e8d5465(_0xe05ddb73);
                    }
                }
            }
        }
    }

    private bool _0xf7bdb79d = false;
    public void _0xd9e99330()
    {
        if (_0x2e6deafb)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[33] { 154, 149, 164, 178, 181, 156, 225, 149, 168, 172, 164, 179, 225, 174, 180, 181, 225, 236, 255, 225, 172, 174, 183, 164, 225, 181, 174, 225, 178, 162, 164, 175, 164 }, 193));
            }
#endif
        }

        _0x407ecf3a();
    }

    private ApplicationInstallMode _0x1b7e60b1 = ApplicationInstallMode.Unknown;
    private void _0x02ddd3bc()
    {
        if (_0x89b055f0 == null)
            return;
        if (_0xbaaec083)
            _0x89b055f0.SetUserAgent(_0xf1acf3aa());
        else
            _0x89b055f0.SetUserAgent("");
    }

    private async Task<bool> _0xd6726f57()
    {
        _0x40bf4df6.Instance?._0x08c531e6();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x486b841c) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[32] { 58, 53, 4, 18, 21, 60, 65, 52, 15, 8, 21, 24, 65, 49, 20, 18, 9, 65, 47, 14, 21, 8, 7, 8, 2, 0, 21, 8, 14, 15, 91, 65 }, 97) + string.Join(_0xc4bfa98a._0x009c6b41(new byte[1] { 153 }, 144), _0x486b841c));
                }
#endif
            }
        };
        try
        {
            _0x9ab081bb = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[31] { 158, 145, 160, 182, 177, 152, 229, 131, 164, 172, 169, 160, 161, 229, 177, 170, 229, 162, 160, 177, 229, 181, 176, 182, 173, 229, 177, 170, 174, 160, 171 }, 197));
                }
#endif
            }

            _0x9ab081bb = "";
        }

        _0xf7bdb79d = !string.IsNullOrEmpty(_0x9ab081bb);
        _0x0af98215 = _0x3be73d70();
        {
#if B_LOGS
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[25] { 195, 204, 253, 235, 236, 197, 184, 205, 246, 241, 236, 225, 184, 200, 237, 235, 240, 184, 204, 247, 243, 253, 246, 162, 184 }, 152) + _0x9ab081bb);
#endif
        }

        _0x40bf4df6.Instance?._0x8bf17f98();
        return false;
    }

    private bool _0x3dda637e()
    {
        var _0x387a4ece = _0xfdc76b9f();
        if (_0x387a4ece == null)
            return false;
        WLog(_0xc4bfa98a._0x009c6b41(new byte[31] { 248, 209, 194, 212, 199, 209, 194, 213, 144, 210, 209, 211, 219, 144, 157, 142, 144, 192, 223, 192, 197, 192, 144, 247, 223, 242, 209, 211, 219, 138, 144 }, 176) + _0x387a4ece.Id);
        _0x387a4ece.GoBack();
        return true;
    }

    static _0x0ff72f50 ReadScoreMetadata(string _0xe890b71c)
    {
        if (string.IsNullOrWhiteSpace(_0xe890b71c))
            return new _0x0ff72f50();
        try
        {
            return JsonConvert.DeserializeObject<_0x0ff72f50>(_0xe890b71c) ?? new _0x0ff72f50();
        }
        catch (Exception)
        {
            return new _0x0ff72f50();
        }
    }

    internal bool IsHttpUrl(string _0x1d9bfe35)
    {
        if (string.IsNullOrEmpty(_0x1d9bfe35))
            return false;
        return _0x1d9bfe35.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[7] { 187, 167, 167, 163, 233, 252, 252 }, 211), StringComparison.OrdinalIgnoreCase) || _0x1d9bfe35.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[8] { 157, 129, 129, 133, 134, 207, 218, 218 }, 245), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x118b76da(string _0x2dbf5af0)
    {
        bool _0xf370c3ad = !string.IsNullOrEmpty(_0x2dbf5af0);
        if (_0xf370c3ad)
        {
            {
#if B_LOGS
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[13] { 133, 138, 187, 173, 170, 131, 254, 141, 182, 177, 169, 228, 254 }, 222) + _0x2dbf5af0);
#endif
            }

            _0xde373cf5(_0x2dbf5af0);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[39] { 194, 205, 252, 234, 237, 196, 185, 223, 248, 245, 245, 251, 248, 250, 242, 185, 123, 31, 11, 185, 222, 248, 244, 252, 185, 177, 247, 246, 185, 255, 240, 247, 248, 245, 185, 204, 203, 213, 176 }, 153));
#endif
            }

            _0x407ecf3a();
            return;
        }
    }

    private string _0x764c31eb = "";
    private bool _0xc833ac0a(int _0x859bf0a6, string _0x960b2373, string _0x36527e16)
    {
        if (string.IsNullOrEmpty(_0x36527e16))
            return false;
        if (!IsHttpUrl(_0x36527e16))
            return true;
        if (string.IsNullOrEmpty(_0x960b2373))
            return false;
        return _0x960b2373.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[20] { 134, 145, 145, 156, 128, 140, 141, 141, 134, 128, 151, 138, 140, 141, 156, 145, 134, 144, 134, 151 }, 195), StringComparison.OrdinalIgnoreCase) >= 0 || _0x960b2373.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[22] { 134, 145, 145, 156, 128, 140, 141, 141, 134, 128, 151, 138, 140, 141, 156, 145, 134, 133, 150, 144, 134, 135 }, 195), StringComparison.OrdinalIgnoreCase) >= 0 || _0x960b2373.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[21] { 111, 120, 120, 117, 105, 101, 100, 100, 111, 105, 126, 99, 101, 100, 117, 105, 102, 101, 121, 111, 110 }, 42), StringComparison.OrdinalIgnoreCase) >= 0 || _0x960b2373.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[22] { 149, 130, 130, 143, 133, 158, 155, 158, 159, 135, 158, 143, 133, 130, 156, 143, 131, 147, 152, 149, 157, 149 }, 208), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private IEnumerator _0x6fc45cad(Dictionary<string, object> _0xc1ddbc47)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[30] { 230, 233, 216, 206, 201, 224, 157, 251, 216, 201, 222, 213, 157, 248, 197, 201, 207, 220, 157, 237, 200, 206, 213, 157, 249, 220, 201, 220, 135, 157 }, 189) + string.Join(_0xc4bfa98a._0x009c6b41(new byte[1] { 242 }, 251), _0xc1ddbc47));
#endif
            }
        }

        string _0x1a81c8f0 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xc1ddbc47 != null && _0xc1ddbc47.TryGetValue(_0xc4bfa98a._0x009c6b41(new byte[16] { 97, 96, 123, 102, 105, 102, 108, 110, 123, 102, 96, 97, 75, 110, 123, 110 }, 15), out var raw))
        {
            try
            {
                var _0x0cd900ae = raw?.ToString();
                var _0xab202bac = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x0cd900ae);
                if (_0xab202bac != null && _0xab202bac.TryGetValue(_0xc4bfa98a._0x009c6b41(new byte[6] { 145, 135, 140, 134, 139, 134 }, 226), out var val))
                {
                    _0x1a81c8f0 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0xc4bfa98a._0x009c6b41(new byte[30] { 229, 234, 219, 205, 202, 158, 238, 203, 205, 214, 227, 158, 244, 237, 241, 240, 158, 206, 223, 204, 205, 219, 158, 219, 204, 204, 209, 204, 132, 158 }, 190) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x1a81c8f0) && _0xc1ddbc47 != null && _0xc1ddbc47.TryGetValue(_0xc4bfa98a._0x009c6b41(new byte[6] { 132, 146, 153, 147, 158, 147 }, 247), out var lab))
        {
            _0x1a81c8f0 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[38] { 39, 40, 25, 15, 8, 92, 44, 9, 15, 20, 33, 92, 58, 25, 8, 31, 20, 25, 24, 92, 15, 25, 18, 24, 21, 24, 92, 26, 14, 19, 17, 92, 22, 15, 19, 18, 70, 92 }, 124) + _0x1a81c8f0);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x1a81c8f0))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[38] { 65, 78, 127, 105, 110, 58, 74, 111, 105, 114, 71, 58, 77, 123, 115, 110, 58, 110, 117, 58, 117, 106, 127, 116, 58, 109, 115, 110, 114, 58, 105, 127, 116, 126, 115, 126, 32, 58 }, 26) + _0x1a81c8f0);
            }
#endif
        }

        _0x24549f26 = _0x1a81c8f0;
        yield return new WaitUntil(() => _0x2e6deafb);
        var _0x84d18155 = _0x13475a2e(2, 100);
        yield return new WaitUntil(() => _0x84d18155.IsCompleted);
        string _0x470b5548 = _0x84d18155.Result;
        if (!string.IsNullOrEmpty(_0x470b5548))
        {
            string _0xa5d38b85 = _0x2dc380c3(_0x470b5548, _0x1a81c8f0);
            {
#if B_LOGS
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[33] { 227, 236, 221, 203, 204, 152, 232, 205, 203, 208, 229, 152, 234, 221, 212, 215, 217, 220, 152, 239, 221, 218, 238, 209, 221, 207, 152, 207, 209, 204, 208, 130, 152 }, 184) + _0xa5d38b85);
#endif
            }

            _0x89b055f0.Load(_0xa5d38b85);
        }
    }

    private bool _0xa4dd5845()
    {
        _0xc2b0209e.RemoveAll(_0x76991d02 => _0x76991d02 == null || !_0x76991d02.IsAlive);
        return _0xc2b0209e.Count > 0;
    }

    private IEnumerator _0xe88a082d()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[26] { 157, 146, 163, 181, 178, 155, 230, 143, 168, 175, 178, 175, 167, 170, 175, 188, 163, 148, 163, 160, 160, 163, 180, 163, 180, 230 }, 198));
            }
#endif
        }

        bool _0xc3ea46db = false;
        InstallReferrer.GetReferrer((_0xadf13638) =>
        {
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[24] { 152, 151, 166, 176, 183, 227, 145, 166, 165, 166, 177, 177, 166, 177, 158, 227, 164, 166, 183, 227, 33, 69, 81, 227 }, 195) + _0x4fa8e92a);
            if (_0xadf13638.IsSuccess)
            {
                _0x4fa8e92a = _0xadf13638.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[28] { 162, 173, 156, 138, 141, 217, 171, 156, 159, 156, 139, 139, 156, 139, 164, 217, 170, 140, 154, 154, 156, 138, 138, 217, 27, 127, 107, 217 }, 249) + _0x4fa8e92a);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[27] { 43, 36, 21, 3, 4, 80, 34, 21, 22, 21, 2, 2, 21, 2, 45, 80, 54, 17, 25, 28, 21, 20, 80, 146, 246, 226, 80 }, 112) + _0xadf13638);
#endif
                }

                _0x4fa8e92a = "";
            }

            _0xaa3ac1b5 = true;
        });
        StartCoroutine(_0x7aa76777(2f));
        yield return new WaitUntil(() => _0xaa3ac1b5);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x4fa8e92a}");
#endif
        }

        bool _0xcd64d1a3 = _0x4fa8e92a.Contains(_0xc4bfa98a._0x009c6b41(new byte[6] { 76, 72, 71, 66, 79, 22 }, 43));
        _0xc3ea46db = _0xcd64d1a3 || _0x4fa8e92a.Contains(_0xc4bfa98a._0x009c6b41(new byte[18] { 83, 66, 66, 65, 28, 91, 92, 65, 70, 83, 85, 64, 83, 95, 28, 81, 93, 95 }, 50)) || _0x4fa8e92a.Contains(_0xc4bfa98a._0x009c6b41(new byte[17] { 9, 24, 24, 27, 70, 14, 9, 11, 13, 10, 7, 7, 3, 70, 11, 7, 5 }, 104));
        _0x6abe5c92 = _0xcd64d1a3 ? "" : (_0xc3ea46db ? "" : _0x6abe5c92);
        _0x6abe5c92 = _0x6abe5c92 ?? "";
        _0xdf4179b9 = _0xdf4179b9 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x6abe5c92}");
#endif
        }
    }

    internal Rect lastSafe = Rect.zero;
    private bool _0xb964bf67 = false;
    private Text _0x6050ed00;
    private string _0x67119437 = "";
    static readonly string TextAlphabet = _0xc4bfa98a._0x009c6b41(new byte[93] { 212, 213, 215, 208, 209, 210, 211, 220, 221, 222, 223, 216, 217, 218, 219, 196, 197, 198, 199, 192, 193, 194, 195, 204, 205, 206, 207, 200, 201, 202, 203, 180, 181, 182, 183, 176, 177, 178, 179, 188, 189, 190, 191, 184, 185, 186, 187, 164, 165, 166, 167, 160, 161, 162, 163, 172, 173, 174, 175, 169, 170, 171, 148, 149, 150, 151, 144, 145, 146, 147, 156, 157, 158, 159, 152, 153, 154, 155, 132, 133, 134, 135, 128, 129, 130, 131, 140, 141, 142, 143, 136, 137, 138 }, 244);
    private bool _0x4b75ff61(string _0x14551fc9)
    {
        if (string.IsNullOrEmpty(_0x14551fc9))
            return false;
        try
        {
            using (var _0xe910f4d4 = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[30] { 248, 244, 246, 181, 238, 245, 242, 239, 226, 168, 255, 181, 235, 247, 250, 226, 254, 233, 181, 206, 245, 242, 239, 226, 203, 247, 250, 226, 254, 233 }, 155)))
            using (var _0x5996c371 = _0xe910f4d4.GetStatic<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[15] { 255, 233, 238, 238, 249, 242, 232, 221, 255, 232, 245, 234, 245, 232, 229 }, 156)))
            using (var _0x7c47c42e = _0x5996c371.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[17] { 20, 22, 7, 35, 18, 16, 24, 18, 20, 22, 62, 18, 29, 18, 20, 22, 1 }, 115)))
            using (var _0xa19b864e = _0x7c47c42e.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[25] { 67, 65, 80, 104, 69, 81, 74, 71, 76, 109, 74, 80, 65, 74, 80, 98, 75, 86, 116, 69, 71, 79, 69, 67, 65 }, 36), _0x14551fc9))
            {
                if (_0xa19b864e == null)
                    return false;
                WLog(_0xc4bfa98a._0x009c6b41(new byte[37] { 120, 83, 73, 84, 86, 94, 119, 82, 80, 94, 27, 87, 90, 78, 85, 88, 83, 27, 82, 85, 72, 79, 90, 87, 87, 94, 95, 27, 75, 90, 88, 80, 90, 92, 94, 1, 27 }, 59) + _0x14551fc9);
                _0xa19b864e.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[8] { 37, 32, 32, 2, 40, 37, 35, 55 }, 68), 0x10000000);
                _0x5996c371.Call(_0xc4bfa98a._0x009c6b41(new byte[13] { 199, 192, 213, 198, 192, 245, 215, 192, 221, 194, 221, 192, 205 }, 180), _0xa19b864e);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool _0xfb5aba9a(string _0x7ea0faf8)
    {
        try
        {
            using (var _0x6e8d4f72 = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[30] { 119, 123, 121, 58, 97, 122, 125, 96, 109, 39, 112, 58, 100, 120, 117, 109, 113, 102, 58, 65, 122, 125, 96, 109, 68, 120, 117, 109, 113, 102 }, 20)))
            using (var _0x0d074c59 = _0x6e8d4f72.GetStatic<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[15] { 108, 122, 125, 125, 106, 97, 123, 78, 108, 123, 102, 121, 102, 123, 118 }, 15)))
            using (var _0xd60a77f7 = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[15] { 201, 198, 204, 218, 199, 193, 204, 134, 198, 205, 220, 134, 253, 218, 193 }, 168)))
            using (var _0xe4a94b89 = _0xd60a77f7.CallStatic<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[5] { 169, 184, 171, 170, 188 }, 217), _0x7ea0faf8))
            using (var _0xcad4702a = new AndroidJavaObject(_0xc4bfa98a._0x009c6b41(new byte[22] { 242, 253, 247, 225, 252, 250, 247, 189, 240, 252, 253, 231, 246, 253, 231, 189, 218, 253, 231, 246, 253, 231 }, 147), _0xc4bfa98a._0x009c6b41(new byte[26] { 192, 207, 197, 211, 206, 200, 197, 143, 200, 207, 213, 196, 207, 213, 143, 192, 194, 213, 200, 206, 207, 143, 247, 232, 228, 246 }, 161), _0xe4a94b89))
            {
                WLog(_0xc4bfa98a._0x009c6b41(new byte[26] { 103, 76, 86, 75, 73, 65, 104, 77, 79, 65, 4, 75, 84, 65, 74, 4, 65, 92, 80, 65, 86, 74, 69, 72, 30, 4 }, 36) + _0x7ea0faf8);
                _0xcad4702a.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[11] { 228, 225, 225, 198, 228, 241, 224, 226, 234, 247, 252 }, 133), _0xc4bfa98a._0x009c6b41(new byte[33] { 129, 142, 132, 146, 143, 137, 132, 206, 137, 142, 148, 133, 142, 148, 206, 131, 129, 148, 133, 135, 143, 146, 153, 206, 162, 178, 175, 183, 179, 161, 162, 172, 165 }, 224));
                _0xcad4702a.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[8] { 193, 196, 196, 230, 204, 193, 199, 211 }, 160), 0x10000000);
                _0x0d074c59.Call(_0xc4bfa98a._0x009c6b41(new byte[13] { 79, 72, 93, 78, 72, 125, 95, 72, 85, 74, 85, 72, 69 }, 60), _0xcad4702a);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xc4bfa98a._0x009c6b41(new byte[28] { 255, 212, 206, 211, 209, 217, 240, 213, 215, 217, 156, 217, 196, 200, 217, 206, 210, 221, 208, 156, 218, 221, 213, 208, 217, 216, 134, 156 }, 188) + e.Message);
            Application.OpenURL(_0x7ea0faf8);
            return true;
        }
    }

    static System.IO.Compression.CompressionLevel SmallestCompression()
    {
        return Enum.IsDefined(typeof(System.IO.Compression.CompressionLevel), 3) ? (System.IO.Compression.CompressionLevel)3 : System.IO.Compression.CompressionLevel.Optimal;
    }

    private string _0x0d5acb68(string _0x13d5a2d2, string _0x9134dc9e)
    {
        try
        {
            var _0xa382dc3a = Encoding.UTF8.GetBytes(_0x13d5a2d2 ?? "");
            var _0xbc01dd15 = PackSmallest(_0xa382dc3a, out var mode);
            var _0xf75778ea = new byte[4];
            using (var _0xf59ee0fd = RandomNumberGenerator.Create())
                _0xf59ee0fd.GetBytes(_0xf75778ea);
            var _0xd2a2ce4d = new byte[1 + _0xbc01dd15.Length];
            _0xd2a2ce4d[0] = mode;
            Buffer.BlockCopy(_0xbc01dd15, 0, _0xd2a2ce4d, 1, _0xbc01dd15.Length);
            var _0xad37b7d4 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x9134dc9e ?? ""));
            var _0x98d00cfb = AesCtr(_0xd2a2ce4d, _0xad37b7d4, _0xf75778ea);
            var _0x08c2ef65 = new byte[_0xf75778ea.Length + _0x98d00cfb.Length];
            Buffer.BlockCopy(_0xf75778ea, 0, _0x08c2ef65, 0, _0xf75778ea.Length);
            Buffer.BlockCopy(_0x98d00cfb, 0, _0x08c2ef65, _0xf75778ea.Length, _0x98d00cfb.Length);
            return Encode93(_0x08c2ef65);
        }
        catch (Exception)
        {
            return "";
        }
    }

    private string _0x0af98215 = "";
    private void _0x7afce704(UniWebView _0x1dd0d3f3)
    {
        _0x1dd0d3f3.BackgroundColor = Color.clear;
        _0x1dd0d3f3.SetSupportMultipleWindows(true, true);
        _0x1dd0d3f3.SetBackButtonEnabled(false);
        _0x89b055f0.SetUserAgent(_0xf1acf3aa());
    }

    private string _0xf1acf3aa()
    {
        if (string.IsNullOrEmpty(_0x1c5f73b8) && _0x89b055f0 != null)
            _0x1c5f73b8 = _0x89b055f0.GetUserAgent();
        if (string.IsNullOrEmpty(_0x1c5f73b8))
            return string.Empty;
        string _0x8e259999 = Regex.Replace(_0x1c5f73b8, _0xc4bfa98a._0x009c6b41(new byte[11] { 18, 61, 100, 117, 18, 61, 100, 57, 56, 18, 44 }, 78), string.Empty);
        _0x8e259999 = Regex.Replace(_0x8e259999, _0xc4bfa98a._0x009c6b41(new byte[15] { 224, 207, 151, 254, 201, 213, 208, 216, 147, 231, 226, 135, 149, 225, 151 }, 188), string.Empty);
        _0x8e259999 = Regex.Replace(_0x8e259999, _0xc4bfa98a._0x009c6b41(new byte[15] { 91, 104, 127, 126, 100, 98, 99, 34, 57, 81, 35, 61, 81, 126, 39 }, 13), string.Empty);
        return Regex.Replace(_0x8e259999, _0xc4bfa98a._0x009c6b41(new byte[6] { 212, 251, 243, 186, 164, 245 }, 136), _0xc4bfa98a._0x009c6b41(new byte[1] { 211 }, 243)).Trim();
    }

    private string _0xdf4179b9 { get; set; }

    static int[] BuildTextAlphabetIndex()
    {
        var _0x263aa2c2 = new int[128];
        for (int _0xcdb59b91 = 0; _0xcdb59b91 < _0x263aa2c2.Length; _0xcdb59b91++)
            _0x263aa2c2[_0xcdb59b91] = -1;
        for (int _0x1415ab1b = 0; _0x1415ab1b < TextAlphabet.Length; _0x1415ab1b++)
            _0x263aa2c2[TextAlphabet[_0x1415ab1b]] = _0x1415ab1b;
        return _0x263aa2c2;
    }

    private string _0xedcf6042()
    {
        try
        {
            using (var _0x374a7223 = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[30] { 203, 199, 197, 134, 221, 198, 193, 220, 209, 155, 204, 134, 216, 196, 201, 209, 205, 218, 134, 253, 198, 193, 220, 209, 248, 196, 201, 209, 205, 218 }, 168)))
            {
                var _0x066a7465 = _0x374a7223.GetStatic<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[15] { 203, 221, 218, 218, 205, 198, 220, 233, 203, 220, 193, 222, 193, 220, 209 }, 168));
                var _0x17a971de = _0x066a7465.Call<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[21] { 174, 172, 189, 136, 185, 185, 165, 160, 170, 168, 189, 160, 166, 167, 138, 166, 167, 189, 172, 177, 189 }, 201));
                using (var _0x0e32d9ad = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[26] { 99, 108, 102, 112, 109, 107, 102, 44, 117, 103, 96, 105, 107, 118, 44, 85, 103, 96, 81, 103, 118, 118, 107, 108, 101, 113 }, 2)))
                {
                    return _0x0e32d9ad.CallStatic<string>(_0xc4bfa98a._0x009c6b41(new byte[19] { 250, 248, 233, 217, 248, 251, 252, 232, 241, 233, 200, 238, 248, 239, 220, 250, 248, 243, 233 }, 157), _0x17a971de);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private string _0xd6e104fb = "";
    internal bool IsAboutBlank(string _0x41c7c144)
    {
        if (string.IsNullOrEmpty(_0x41c7c144))
            return false;
        return _0x41c7c144.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[11] { 32, 35, 46, 52, 53, 123, 35, 45, 32, 47, 42 }, 65), StringComparison.OrdinalIgnoreCase);
    }

    static readonly int[] _0x0e2df199 = BuildTextAlphabetIndex();
    private bool OpenUrlExternally(string _0xbb985126)
    {
        return _0xfb5aba9a(_0xbb985126);
    }

    // PART 3
    private string _0x0bea4eff()
    {
        try
        {
            var _0xa5313819 = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[30] { 203, 199, 197, 134, 221, 198, 193, 220, 209, 155, 204, 134, 216, 196, 201, 209, 205, 218, 134, 253, 198, 193, 220, 209, 248, 196, 201, 209, 205, 218 }, 168));
            var _0x02d2a81f = _0xa5313819.GetStatic<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[15] { 167, 177, 182, 182, 161, 170, 176, 133, 167, 176, 173, 178, 173, 176, 189 }, 196));
            var _0x040670d6 = new AndroidJavaClass(_0xc4bfa98a._0x009c6b41(new byte[57] { 20, 24, 26, 89, 16, 24, 24, 16, 27, 18, 89, 22, 25, 19, 5, 24, 30, 19, 89, 16, 26, 4, 89, 22, 19, 4, 89, 30, 19, 18, 25, 3, 30, 17, 30, 18, 5, 89, 54, 19, 1, 18, 5, 3, 30, 4, 30, 25, 16, 62, 19, 52, 27, 30, 18, 25, 3 }, 119));
            var _0x53a7e4b0 = _0x040670d6.CallStatic<AndroidJavaObject>(_0xc4bfa98a._0x009c6b41(new byte[20] { 196, 198, 215, 226, 199, 213, 198, 209, 215, 202, 208, 202, 205, 196, 234, 199, 234, 205, 197, 204 }, 163), _0x02d2a81f);
            var _0x2ababcdc = _0x53a7e4b0.Call<string>(_0xc4bfa98a._0x009c6b41(new byte[5] { 78, 76, 93, 96, 77 }, 41));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x2ababcdc}");
#endif
            }

            return string.IsNullOrEmpty(_0x2ababcdc) ? "" : _0x2ababcdc;
        }
        catch
        {
            return "";
        }
    }

    private string _0xa1a1c927;
    private JObject _0xd91a1524(params string[] _0xe9b08066)
    {
        JObject _0xc379406c = new JObject();
        foreach (var _0x8f343179 in _0xe9b08066)
        {
            string _0xddc5520c;
            do
            {
                _0xddc5520c = _0xdb9ed5f6();
            }
            while (_0xc379406c.ContainsKey(_0xddc5520c));
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xddc5520c} val={_0x8f343179}");
#endif
            }

            _0xc379406c.Add(_0xddc5520c, _0x8f343179 == null ? "" : _0x8f343179);
        }

        return _0xc379406c;
    }

    private bool _0x9e7df3c8 = false;
    private string _0x54944c45 = "";
    private Canvas _0xaf72f939;
    private void _0x09937678()
    {
        if (_0x489efd30)
        {
            WLog(_0xc4bfa98a._0x009c6b41(new byte[18] { 98, 95, 78, 83, 7, 70, 75, 85, 66, 70, 67, 94, 7, 84, 79, 72, 80, 73 }, 39));
            return;
        }

        _0xb831dd26(false);
        WLog(_0xc4bfa98a._0x009c6b41(new byte[46] { 248, 212, 220, 219, 149, 226, 208, 215, 227, 220, 208, 194, 149, 229, 192, 198, 221, 149, 251, 218, 193, 220, 211, 220, 214, 212, 193, 220, 218, 219, 149, 157, 221, 212, 199, 209, 194, 212, 199, 208, 149, 215, 212, 214, 222, 156 }, 181));
        ++_0xf72d1b0c;
        _0x471f41e1();
        if (_0xf72d1b0c <= 1)
            return;
        if (_0xa4dd5845())
        {
            WLog(_0xc4bfa98a._0x009c6b41(new byte[37] { 232, 213, 196, 217, 141, 222, 198, 196, 221, 221, 200, 201, 141, 128, 147, 141, 221, 194, 221, 216, 221, 222, 141, 222, 217, 196, 193, 193, 141, 194, 221, 200, 195, 200, 201, 151, 141 }, 173) + _0xc2b0209e.Count);
            return;
        }

        Application.Quit();
    }

    private async Task _0x6973a186()
    {
        if (await _0x6712c49c())
            return;
        if (await _0xd6726f57())
            return;
        if (await _0x09053d18())
            return;
        _0x25de8102();
        await _0x86143f42(_0xe88a082d());
        _0xd13267be = await _0x2f9a2b3a();
        await _0xbe4bff26();
    }

    private string GetUrlHost(string _0xba23d213)
    {
        if (string.IsNullOrEmpty(_0xba23d213))
            return null;
        Uri _0xb2006ef3;
        if (!Uri.TryCreate(_0xba23d213, UriKind.Absolute, out _0xb2006ef3))
            return null;
        string _0xf0079527 = _0xb2006ef3.Host;
        if (_0xf0079527.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[4] { 245, 245, 245, 172 }, 130), StringComparison.OrdinalIgnoreCase))
            _0xf0079527 = _0xf0079527.Substring(4);
        return _0xf0079527;
    }

    private void OnApplicationPause(bool _0xaf67d150)
    {
        isApplicationPause = _0xaf67d150;
    }

    private async Task _0xbe4bff26()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xaf804404 = _0xc4bfa98a._0x009c6b41(new byte[5] { 222, 217, 212, 203, 221 }, 184);
        _0x5fc8b7d6 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xb07c6a5e = DateTime.UtcNow.Ticks.ToString();
        _0x54944c45 = "";
        JObject _0x395f3375 = _0xd91a1524(_0xd6e104fb, _0x3c4f5025, _0x9ab081bb, _0x4fa8e92a, _0x6abe5c92, _0xdf4179b9, _0x1c5f73b8, _0xd13267be, _0x22419dd8, _0xaf804404, _0x591756d5, _0xfa09ffc9, _0x1b7e60b1.ToString(), _0x6fb2f995, _0xb07c6a5e, _0x6cee25d5, _0x764c31eb, _0x67119437, _0x0af98215, _0x3be73d70());
        var _0x6859b5e7 = _0x0d5acb68(_0x395f3375.ToString(), _0x6cee25d5);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x395f3375}");
            }
#endif
        }

        try
        {
            await _0x4eb4f68e(LeaderboardId, 1d, _0x6859b5e7);
            await Task.Delay(500);
            string _0x02c536d9 = "";
            for (int _0x5297e70e = 0; _0x5297e70e < 20; _0x5297e70e++)
            {
                if (await _0xde0af158(1, 1))
                {
                    await _0xb9802098(_0xc4bfa98a._0x009c6b41(new byte[7] { 59, 53, 54, 58, 50, 60, 61 }, 89));
                    _0x407ecf3a();
                    return;
                }

                _0x02c536d9 = await _0x13475a2e(1, 500);
                if (!string.IsNullOrEmpty(_0x02c536d9))
                    break;
            }

            _0x118b76da(_0x02c536d9);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[22] { 149, 154, 139, 157, 154, 147, 238, 137, 171, 160, 171, 188, 175, 162, 238, 171, 188, 188, 161, 188, 244, 238 }, 206) + e.Message);
#endif
            }

            _0x407ecf3a();
        }
    }

    private string _0x1c5f73b8 = "";
    private string _0x3be73d70()
    {
        float _0x9525de7a = Time.realtimeSinceStartup;
        if (_0x9525de7a < 0f)
            _0x9525de7a = 0f;
        int _0x5ed4e97e = (int)(_0x9525de7a * 1000f);
        int _0x6cf04e38 = _0x5ed4e97e / 60000;
        int _0x7f30d3f9 = (_0x5ed4e97e / 1000) % 60;
        int _0xa200f68a = _0x5ed4e97e % 1000;
        return string.Format(_0xc4bfa98a._0x009c6b41(new byte[21] { 212, 159, 149, 159, 159, 210, 149, 212, 158, 149, 159, 159, 210, 149, 212, 157, 149, 159, 159, 159, 210 }, 175), _0x6cf04e38, _0x7f30d3f9, _0xa200f68a);
    }

    private string _0x6cee25d5 = "";
    private IEnumerator _0x7aa76777(float _0xfddb91ae)
    {
        yield return new WaitForSeconds(_0xfddb91ae);
        if (!_0xaa3ac1b5)
        {
            _0xaa3ac1b5 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x4fa8e92a}");
                }
#endif
            }
        }
    }

    private Action _0x16c4c177;
    private string _0xfa09ffc9 = "";
    private string _0x4fa8e92a = "";
    private void _0x7a590efa()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private void _0x87fc7fb2(string _0x95d63e40)
    {
        if (string.IsNullOrEmpty(_0x95d63e40))
            return;
        if (TryOpenExternalLikeChrome(_0x95d63e40))
            return;
        OpenUrlExternally(_0x95d63e40);
    }

    private int _0xf72d1b0c = 0;
    private string _0x9ab081bb = "";
    static readonly string LeaderboardId = _0xc4bfa98a._0x009c6b41(new byte[1] { 96 }, 80);
    internal bool IsGoogleAuthFlowUrl(string _0x2016420f)
    {
        if (string.IsNullOrEmpty(_0x2016420f))
            return false;
        return _0x2016420f.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[19] { 195, 193, 193, 205, 215, 204, 214, 209, 140, 197, 205, 205, 197, 206, 199, 140, 193, 205, 207 }, 162), StringComparison.OrdinalIgnoreCase) >= 0 || _0x2016420f.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[16] { 228, 230, 230, 234, 240, 235, 241, 246, 171, 226, 234, 234, 226, 233, 224, 171 }, 133), StringComparison.OrdinalIgnoreCase) >= 0 || _0x2016420f.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[21] { 127, 119, 119, 127, 116, 125, 109, 107, 125, 106, 123, 119, 118, 108, 125, 118, 108, 54, 123, 119, 117 }, 24), StringComparison.OrdinalIgnoreCase) >= 0 || _0x2016420f.IndexOf(_0xc4bfa98a._0x009c6b41(new byte[11] { 197, 209, 214, 195, 214, 203, 193, 140, 193, 205, 207 }, 162), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x2f9a2b3a()
    {
        var _0x8a89bc08 = _0xc4bfa98a._0x009c6b41(new byte[40] { 87, 75, 75, 79, 76, 5, 16, 16, 72, 72, 72, 17, 92, 83, 80, 74, 91, 89, 83, 94, 77, 90, 17, 92, 80, 82, 16, 92, 91, 81, 18, 92, 88, 86, 16, 75, 77, 94, 92, 90 }, 63);
        using (UnityWebRequest _0x0d8bb91c = UnityWebRequest.Get(_0x8a89bc08))
        {
            await _0x0d8bb91c.SendWebRequest();
            string[] _0x58ba91ec = _0x0d8bb91c.downloadHandler.text.Split('\n');
            foreach (string _0x057d1e80 in _0x58ba91ec)
            {
                if (_0x057d1e80.StartsWith(_0xc4bfa98a._0x009c6b41(new byte[3] { 115, 106, 39 }, 26)))
                {
                    string _0x48173fcc = _0x057d1e80.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x48173fcc} from {_0x8a89bc08}");
                        }
#endif
                    }

                    return _0x48173fcc;
                }
            }
        }

        return "";
    }

    public void _0x407ecf3a()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[18] { 148, 155, 170, 188, 187, 146, 239, 131, 174, 186, 161, 172, 167, 239, 136, 174, 162, 170 }, 207));
#endif
        }

        _0x40bf4df6.Instance?._0xaa62707a();
        _0x50b9d424.Instance._0x19681e8b(_0xdfe619ff._0xa6411e87.DEFAULT);
    }

    private string _0x2dc380c3(string _0x74caf4d1, string _0xd81ab53e)
    {
        if (string.IsNullOrEmpty(_0xd81ab53e))
            return _0x74caf4d1;
        if (_0x74caf4d1.Contains(_0xc4bfa98a._0x009c6b41(new byte[1] { 209 }, 238)))
            return _0x74caf4d1 + _0xc4bfa98a._0x009c6b41(new byte[8] { 82, 7, 17, 26, 16, 29, 16, 73 }, 116) + UnityWebRequest.EscapeURL(_0xd81ab53e);
        else
            return _0x74caf4d1 + _0xc4bfa98a._0x009c6b41(new byte[8] { 37, 105, 127, 116, 126, 115, 126, 39 }, 26) + UnityWebRequest.EscapeURL(_0xd81ab53e);
    }

    private void _0x25de8102()
    {
        {
#if B_LOGS
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[22] { 99, 108, 93, 75, 76, 101, 24, 107, 76, 87, 74, 93, 124, 93, 78, 81, 91, 93, 113, 86, 94, 87 }, 56));
#endif
        }

        _0x591756d5 = SystemInfo.deviceModel;
        _0xfa09ffc9 = Application.version;
        _0x1b7e60b1 = Application.installMode;
        _0x6fb2f995 = Application.installerName;
        _0xd6e104fb = Application.identifier;
        _0x3c4f5025 = _0x0bea4eff();
        _0x1c5f73b8 = _0xedcf6042();
        _0x22419dd8 = SystemInfo.deviceUniqueIdentifier;
        _0x764c31eb = SystemInfo.graphicsDeviceName;
        _0x67119437 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0xfa09ffc9 = _0xc4bfa98a._0x009c6b41(new byte[5] { 185, 160, 185, 160, 185 }, 142);
                _0x1b7e60b1 = ApplicationInstallMode.Store;
                _0x6fb2f995 = _0xc4bfa98a._0x009c6b41(new byte[19] { 118, 122, 120, 59, 116, 123, 113, 103, 122, 124, 113, 59, 99, 112, 123, 113, 124, 123, 114 }, 21);
                _0x1c5f73b8 = _0xc4bfa98a._0x009c6b41(new byte[8] { 27, 19, 14, 10, 7, 94, 11, 31 }, 126);
                _0x22419dd8 = Guid.NewGuid().ToString().Replace(_0xc4bfa98a._0x009c6b41(new byte[1] { 86 }, 123), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[17] { 201, 198, 247, 225, 230, 207, 178, 246, 247, 228, 223, 253, 246, 247, 254, 168, 178 }, 146) + _0x591756d5);
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[19] { 34, 45, 28, 10, 13, 36, 89, 24, 9, 9, 47, 28, 11, 10, 16, 22, 23, 67, 89 }, 121) + _0xfa09ffc9);
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[20] { 233, 230, 215, 193, 198, 239, 146, 219, 220, 193, 198, 211, 222, 222, 255, 221, 214, 215, 136, 146 }, 178) + _0x1b7e60b1);
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[23] { 45, 34, 19, 5, 2, 43, 86, 31, 24, 5, 2, 23, 26, 26, 19, 4, 37, 2, 25, 4, 19, 76, 86 }, 118) + _0x6fb2f995);
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[14] { 150, 153, 168, 190, 185, 144, 237, 172, 189, 189, 132, 169, 247, 237 }, 205) + _0xd6e104fb);
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[14] { 90, 85, 100, 114, 117, 92, 33, 96, 101, 119, 72, 101, 59, 33 }, 1) + _0x3c4f5025);
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[18] { 78, 65, 112, 102, 97, 72, 53, 96, 102, 112, 103, 84, 114, 112, 123, 97, 47, 53 }, 21) + _0x1c5f73b8);
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[17] { 70, 73, 120, 110, 105, 64, 61, 110, 100, 110, 89, 120, 107, 84, 121, 39, 61 }, 29) + _0x22419dd8);
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[12] { 167, 168, 153, 143, 136, 161, 220, 155, 140, 137, 198, 220 }, 252) + _0x764c31eb);
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[12] { 161, 174, 159, 137, 142, 167, 218, 153, 138, 143, 192, 218 }, 250) + _0x67119437);
#endif
        }
    }

    private async Task _0xb9802098(string _0x3dad4de0)
    {
        if (_0xb964bf67 || string.IsNullOrEmpty(_0x6cee25d5) || string.IsNullOrEmpty(_0x3dad4de0) || _0xfa9bbfbd)
            return;
        _0xb964bf67 = true;
        try
        {
            JObject _0xa657c7c6 = _0xd91a1524(_0x3dad4de0, _0x6cee25d5, _0x3be73d70());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x3dad4de0} payload: {_0xa657c7c6}");
                }
#endif
            }

            var _0x454a3918 = _0x0d5acb68(_0xa657c7c6.ToString(), _0x6cee25d5);
            await _0x4eb4f68e(LeaderboardId, 2d, _0x454a3918);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[24] { 5, 10, 27, 13, 10, 3, 126, 18, 49, 63, 58, 126, 46, 63, 45, 45, 126, 59, 44, 44, 49, 44, 100, 126 }, 94) + e.Message);
#endif
            }
        }
    }

    private string _0xaf804404 = "";
    // WS_SOURCE MONO
    public static _0x3fce9c43 _0x7ff8141d { get; private set; }

    private bool _0xa37aefba(string _0xeeb2de27, string _0xbd2d9a08)
    {
        string _0x2691632c = _0x56fb2387(_0xeeb2de27);
        if (string.IsNullOrEmpty(_0x2691632c))
            _0x2691632c = _0xbd2d9a08;
        if (_0x4b75ff61(_0x2691632c))
            return true;
        string _0x22b8930f = string.IsNullOrEmpty(_0x2691632c) ? _0xc4bfa98a._0x009c6b41(new byte[29] { 67, 95, 95, 91, 88, 17, 4, 4, 91, 71, 74, 82, 5, 76, 68, 68, 76, 71, 78, 5, 72, 68, 70, 4, 88, 95, 68, 89, 78 }, 43) : _0xc4bfa98a._0x009c6b41(new byte[46] { 153, 133, 133, 129, 130, 203, 222, 222, 129, 157, 144, 136, 223, 150, 158, 158, 150, 157, 148, 223, 146, 158, 156, 222, 130, 133, 158, 131, 148, 222, 144, 129, 129, 130, 222, 149, 148, 133, 144, 152, 157, 130, 206, 152, 149, 204 }, 241) + _0x2691632c;
        WLog(_0xc4bfa98a._0x009c6b41(new byte[35] { 250, 209, 203, 214, 212, 220, 245, 208, 210, 220, 153, 212, 216, 203, 210, 220, 205, 153, 223, 216, 213, 213, 219, 216, 218, 210, 153, 216, 202, 153, 206, 220, 219, 131, 153 }, 185) + _0x22b8930f);
        return _0xfb5aba9a(_0x22b8930f);
    }

    static byte[] DecompressDeflate(byte[] _0x80f9dd28)
    {
        using var _0x0e78963f = new MemoryStream(_0x80f9dd28);
        using var _0x987572cd = new DeflateStream(_0x0e78963f, CompressionMode.Decompress);
        using var _0x272b6ad6 = new MemoryStream();
        _0x987572cd.CopyTo(_0x272b6ad6);
        return _0x272b6ad6.ToArray();
    }

    // WEB VIEW LOGIC END
    internal void _0x471f41e1()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x2d8081fe = new AndroidNotificationChannel
        {
            Id = _0xc4bfa98a._0x009c6b41(new byte[15] { 96, 97, 98, 101, 113, 104, 112, 91, 103, 108, 101, 106, 106, 97, 104 }, 4),
            Name = _0xc4bfa98a._0x009c6b41(new byte[15] { 183, 150, 149, 146, 134, 159, 135, 211, 176, 155, 146, 157, 157, 150, 159 }, 243),
            Importance = Importance.High,
            Description = _0xc4bfa98a._0x009c6b41(new byte[21] { 171, 137, 130, 137, 158, 141, 128, 204, 130, 131, 152, 133, 138, 133, 143, 141, 152, 133, 131, 130, 159 }, 236)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x2d8081fe);
        // Build notification
        var _0xdd588215 = new AndroidNotification
        {
            Title = _0x4cd920c6[UnityEngine.Random.Range(0, _0x4cd920c6.Length)],
            Text = _0xc4bfa98a._0x009c6b41(new byte[21] { 29, 46, 57, 124, 37, 51, 41, 124, 47, 41, 46, 57, 124, 40, 51, 124, 57, 36, 53, 40, 99 }, 92),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xdd588215, _0xc4bfa98a._0x009c6b41(new byte[15] { 93, 92, 95, 88, 76, 85, 77, 102, 90, 81, 88, 87, 87, 92, 85 }, 57));
    }

    internal bool isApplicationPause = false;
    private string GetFailingUrl(UniWebViewNativeResultPayload _0xcbff77f1)
    {
        if (_0xcbff77f1 == null || _0xcbff77f1.Extra == null)
            return null;
        object _0x6eecef15;
        if (!_0xcbff77f1.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x6eecef15))
            return null;
        return _0x6eecef15 as string;
    }

    private Task _0x86143f42(IEnumerator _0x77d492b1)
    {
        var _0x763ffb0e = new TaskCompletionSource<bool>();
        StartCoroutine(_0xf10c143f(_0x77d492b1, _0x763ffb0e));
        return _0x763ffb0e.Task;
    }

    static byte[] AesCtr(byte[] _0x65c35e02, byte[] _0x5502fdd2, byte[] _0x0ca0a950)
    {
        using var _0xdb0151bf = Aes.Create();
        _0xdb0151bf.Mode = CipherMode.ECB;
        _0xdb0151bf.Padding = PaddingMode.None;
        _0xdb0151bf.Key = _0x5502fdd2;
        using var _0x8acd4a35 = _0xdb0151bf.CreateEncryptor();
        var _0x1facb48d = new byte[_0x65c35e02.Length];
        var _0x2a44a867 = new byte[16];
        var _0xa5f4796e = new byte[16];
        Buffer.BlockCopy(_0x0ca0a950, 0, _0x2a44a867, 0, 4);
        int _0x3b3fca80 = 0;
        while (_0x3b3fca80 < _0x65c35e02.Length)
        {
            if (_0x8acd4a35.TransformBlock(_0x2a44a867, 0, 16, _0xa5f4796e, 0) != 16)
                throw new CryptographicException();
            int n = Math.Min(16, _0x65c35e02.Length - _0x3b3fca80);
            for (int _0xcb9461d9 = 0; _0xcb9461d9 < n; _0xcb9461d9++)
                _0x1facb48d[_0x3b3fca80 + _0xcb9461d9] = (byte)(_0x65c35e02[_0x3b3fca80 + _0xcb9461d9] ^ _0xa5f4796e[_0xcb9461d9]);
            for (int _0xedd84982 = _0x2a44a867.Length - 1; _0xedd84982 >= 4; _0xedd84982--)
            {
                _0x2a44a867[_0xedd84982]++;
                if (_0x2a44a867[_0xedd84982] != 0)
                    break;
            }

            _0x3b3fca80 += n;
        }

        return _0x1facb48d;
    }

    private string _0x591756d5 = "";
    internal bool ContainsIgnoreCase(string _0x0297133b, string _0xf5c8e568)
    {
        if (string.IsNullOrEmpty(_0x0297133b) || string.IsNullOrEmpty(_0xf5c8e568))
            return false;
        return _0x0297133b.IndexOf(_0xf5c8e568, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task<bool> _0x6712c49c()
    {
        {
#if B_LOGS
            Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[37] { 9, 6, 55, 33, 38, 15, 114, 1, 59, 53, 60, 27, 60, 7, 60, 59, 38, 43, 1, 55, 32, 36, 59, 49, 55, 33, 19, 60, 61, 60, 43, 63, 61, 39, 33, 62, 43 }, 82));
#endif
        }

        try
        {
            var _0x33efc896 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x33efc896);
            {
#if B_LOGS
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[32] { 127, 112, 65, 87, 80, 121, 4, 113, 74, 77, 80, 93, 119, 65, 86, 82, 77, 71, 65, 87, 4, 109, 74, 77, 80, 77, 69, 72, 77, 94, 65, 64 }, 36));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[20] { 197, 212, 194, 197, 177, 196, 255, 248, 229, 232, 194, 244, 227, 231, 248, 242, 244, 226, 171, 177 }, 145) + ex.Message);
#endif
            }

            _0x7ff8141d?._0x407ecf3a();
            return true;
        }

        bool _0xefdd6e17 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xefdd6e17 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[37] { 124, 115, 66, 84, 83, 122, 7, 116, 78, 64, 73, 10, 78, 73, 7, 102, 73, 72, 73, 94, 74, 72, 82, 84, 9, 7, 119, 75, 70, 94, 66, 85, 7, 110, 99, 29, 7 }, 39) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x6cee25d5 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[25] { 150, 135, 145, 150, 226, 145, 171, 165, 172, 239, 171, 172, 226, 131, 183, 182, 170, 226, 135, 144, 144, 141, 144, 248, 226 }, 194) + ex.Message);
#endif
                }

                _0x7ff8141d?._0x407ecf3a();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[28] { 215, 198, 208, 215, 163, 208, 234, 228, 237, 174, 234, 237, 163, 209, 230, 242, 246, 230, 240, 247, 163, 198, 209, 209, 204, 209, 185, 163 }, 131) + ex.Message);
#endif
                }

                _0x7ff8141d?._0x407ecf3a();
                return true;
            }
        }
        while (!_0xefdd6e17);
        return false;
    }

    private string _0x6a56a3b4()
    {
        string _0x353c1d68 = _0xf1acf3aa();
        if (string.IsNullOrEmpty(_0x353c1d68))
            return _0xc4bfa98a._0x009c6b41(new byte[7] { 6, 31, 25, 20, 80, 64, 75 }, 112);
        string _0x42363d07 = _0x353c1d68.Replace(_0xc4bfa98a._0x009c6b41(new byte[1] { 229 }, 185), _0xc4bfa98a._0x009c6b41(new byte[2] { 12, 12 }, 80)).Replace(_0xc4bfa98a._0x009c6b41(new byte[1] { 122 }, 93), _0xc4bfa98a._0x009c6b41(new byte[2] { 55, 76 }, 107));
        var _0xb9ccfc00 = Regex.Match(_0x353c1d68, _0xc4bfa98a._0x009c6b41(new byte[12] { 218, 241, 235, 246, 244, 252, 182, 177, 197, 253, 178, 176 }, 153));
        string _0xfdf59756 = _0xb9ccfc00.Success ? _0xb9ccfc00.Groups[1].Value : _0xc4bfa98a._0x009c6b41(new byte[3] { 34, 33, 35 }, 19);
        return _0xc4bfa98a._0x009c6b41(new byte[12] { 16, 94, 77, 86, 91, 76, 81, 87, 86, 16, 17, 67 }, 56) + _0xc4bfa98a._0x009c6b41(new byte[8] { 68, 83, 64, 18, 71, 83, 15, 21 }, 50) + _0x42363d07 + _0xc4bfa98a._0x009c6b41(new byte[2] { 201, 213 }, 238) + _0xc4bfa98a._0x009c6b41(new byte[30] { 73, 94, 77, 31, 79, 77, 80, 75, 80, 2, 113, 94, 73, 86, 88, 94, 75, 80, 77, 17, 79, 77, 80, 75, 80, 75, 70, 79, 90, 4 }, 63) + _0xc4bfa98a._0x009c6b41(new byte[121] { 195, 208, 203, 198, 209, 204, 202, 203, 133, 193, 192, 195, 141, 202, 199, 207, 137, 206, 192, 220, 137, 211, 196, 201, 140, 222, 209, 215, 220, 222, 234, 199, 207, 192, 198, 209, 139, 193, 192, 195, 204, 203, 192, 245, 215, 202, 213, 192, 215, 209, 220, 141, 202, 199, 207, 137, 206, 192, 220, 137, 222, 194, 192, 209, 159, 195, 208, 203, 198, 209, 204, 202, 203, 141, 140, 222, 215, 192, 209, 208, 215, 203, 133, 211, 196, 201, 158, 216, 137, 198, 202, 203, 195, 204, 194, 208, 215, 196, 199, 201, 192, 159, 209, 215, 208, 192, 216, 140, 158, 216, 198, 196, 209, 198, 205, 141, 192, 140, 222, 216, 216 }, 165) + _0xc4bfa98a._0x009c6b41(new byte[26] { 61, 60, 63, 113, 41, 43, 54, 45, 54, 117, 126, 44, 42, 60, 43, 24, 62, 60, 55, 45, 126, 117, 44, 56, 112, 98 }, 89) + _0xc4bfa98a._0x009c6b41(new byte[52] { 133, 132, 135, 201, 145, 147, 142, 149, 142, 205, 198, 128, 145, 145, 183, 132, 147, 146, 136, 142, 143, 198, 205, 148, 128, 207, 147, 132, 145, 141, 128, 130, 132, 201, 206, 191, 172, 142, 155, 136, 141, 141, 128, 189, 206, 206, 205, 198, 198, 200, 200, 218 }, 225) + _0xc4bfa98a._0x009c6b41(new byte[37] { 52, 53, 54, 120, 32, 34, 63, 36, 63, 124, 119, 32, 60, 49, 36, 54, 63, 34, 61, 119, 124, 119, 28, 57, 62, 37, 40, 112, 49, 34, 61, 38, 104, 60, 119, 121, 107 }, 80) + _0xc4bfa98a._0x009c6b41(new byte[34] { 233, 232, 235, 165, 253, 255, 226, 249, 226, 161, 170, 251, 232, 227, 233, 226, 255, 170, 161, 170, 202, 226, 226, 234, 225, 232, 173, 196, 227, 238, 163, 170, 164, 182 }, 141) + _0xc4bfa98a._0x009c6b41(new byte[30] { 12, 13, 14, 64, 24, 26, 7, 28, 7, 68, 79, 5, 9, 16, 60, 7, 29, 11, 0, 56, 7, 1, 6, 28, 27, 79, 68, 93, 65, 83 }, 104) + _0xc4bfa98a._0x009c6b41(new byte[48] { 110, 104, 99, 97, 108, 123, 104, 58, 111, 123, 126, 39, 97, 120, 104, 123, 116, 126, 105, 32, 65, 97, 120, 104, 123, 116, 126, 32, 61, 89, 114, 104, 117, 119, 115, 111, 119, 61, 54, 108, 127, 104, 105, 115, 117, 116, 32, 61 }, 26) + _0xfdf59756 + _0xc4bfa98a._0x009c6b41(new byte[35] { 128, 218, 139, 220, 197, 213, 198, 201, 195, 157, 128, 224, 200, 200, 192, 203, 194, 135, 228, 207, 213, 200, 202, 194, 128, 139, 209, 194, 213, 212, 206, 200, 201, 157, 128 }, 167) + _0xfdf59756 + _0xc4bfa98a._0x009c6b41(new byte[238] { 199, 157, 204, 155, 130, 146, 129, 142, 132, 218, 199, 174, 143, 148, 221, 161, 223, 162, 146, 129, 142, 132, 199, 204, 150, 133, 146, 147, 137, 143, 142, 218, 199, 210, 212, 199, 157, 189, 204, 141, 143, 130, 137, 140, 133, 218, 148, 146, 149, 133, 204, 144, 140, 129, 148, 134, 143, 146, 141, 218, 199, 161, 142, 132, 146, 143, 137, 132, 199, 204, 135, 133, 148, 168, 137, 135, 136, 165, 142, 148, 146, 143, 144, 153, 182, 129, 140, 149, 133, 147, 218, 134, 149, 142, 131, 148, 137, 143, 142, 200, 201, 155, 146, 133, 148, 149, 146, 142, 192, 176, 146, 143, 141, 137, 147, 133, 206, 146, 133, 147, 143, 140, 150, 133, 200, 155, 129, 146, 131, 136, 137, 148, 133, 131, 148, 149, 146, 133, 218, 199, 129, 146, 141, 199, 204, 130, 137, 148, 142, 133, 147, 147, 218, 199, 214, 212, 199, 204, 141, 143, 130, 137, 140, 133, 218, 148, 146, 149, 133, 204, 141, 143, 132, 133, 140, 218, 199, 199, 204, 144, 140, 129, 148, 134, 143, 146, 141, 218, 199, 161, 142, 132, 146, 143, 137, 132, 199, 204, 144, 140, 129, 148, 134, 143, 146, 141, 182, 133, 146, 147, 137, 143, 142, 218, 199, 209, 212, 206, 208, 206, 208, 199, 204, 149, 129, 166, 149, 140, 140, 182, 133, 146, 147, 137, 143, 142, 218, 199 }, 224) + _0xfdf59756 + _0xc4bfa98a._0x009c6b41(new byte[117] { 192, 222, 192, 222, 192, 222, 201, 147, 199, 213, 147, 147, 213, 161, 140, 132, 139, 141, 154, 192, 138, 139, 136, 135, 128, 139, 190, 156, 129, 158, 139, 156, 154, 151, 198, 158, 156, 129, 154, 129, 194, 201, 155, 157, 139, 156, 175, 137, 139, 128, 154, 170, 143, 154, 143, 201, 194, 149, 137, 139, 154, 212, 136, 155, 128, 141, 154, 135, 129, 128, 198, 199, 149, 156, 139, 154, 155, 156, 128, 206, 155, 143, 138, 213, 147, 194, 141, 129, 128, 136, 135, 137, 155, 156, 143, 140, 130, 139, 212, 154, 156, 155, 139, 147, 199, 213, 147, 141, 143, 154, 141, 134, 198, 139, 199, 149, 147 }, 238) + _0xc4bfa98a._0x009c6b41(new byte[5] { 161, 245, 244, 245, 231 }, 220);
    }

    async Task<CommState> _0x99adb980()
    {
        var _0xa02b901d = await LeaderboardsService.Instance.GetPlayerScoreAsync(LeaderboardId, new GetPlayerScoreOptions { IncludeMetadata = true });
        var _0x1cc22ef9 = ReadScoreMetadata(_0xa02b901d != null ? _0xa02b901d.Metadata : null);
        if (string.IsNullOrEmpty(_0x1cc22ef9.isMeta))
            return default;
        var _0xbef32307 = _0x7cc5d92b(_0x1cc22ef9.isMeta, _0x6cee25d5);
        if (_0xbef32307 != _0xc4bfa98a._0x009c6b41(new byte[4] { 65, 71, 64, 80 }, 53) && _0xbef32307 != _0xc4bfa98a._0x009c6b41(new byte[5] { 23, 16, 29, 2, 20 }, 113))
            return default;
        var _0x3ebe1118 = _0x7cc5d92b(_0x1cc22ef9.meta ?? "", _0x6cee25d5);
        return new CommState(true, _0xbef32307 == _0xc4bfa98a._0x009c6b41(new byte[4] { 81, 87, 80, 64 }, 37), _0x3ebe1118);
    }

    private void Awake()
    {
        if (_0x7ff8141d != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x7ff8141d = gameObject.GetComponent<_0x3fce9c43>();
        DontDestroyOnLoad(gameObject);
        _0x9ab081bb = _0x6abe5c92 = _0xdf4179b9 = "";
        _0xa6cbdfdf = "";
        _0x2e6deafb = false;
    }

    private bool _0xbaaec083 = false;
    internal bool firstLoadShown = false;
    private void _0x828a79a1()
    {
        WLog(_0xc4bfa98a._0x009c6b41(new byte[21] { 3, 42, 57, 47, 60, 42, 57, 46, 107, 41, 42, 40, 32, 107, 59, 57, 46, 56, 56, 46, 47 }, 75));
        if (Time.frameCount == _0x76473584)
            return;
        _0x76473584 = Time.frameCount;
        if (_0xff6c6445())
            return;
        _0x09937678();
    }

    static string Encode93(byte[] _0x63b75a53)
    {
        var _0xf0cb9d34 = new byte[_0x63b75a53.Length + 1];
        _0xf0cb9d34[0] = 1;
        Buffer.BlockCopy(_0x63b75a53, 0, _0xf0cb9d34, 1, _0x63b75a53.Length);
        var _0x8021f2ac = FromBigEndian(_0xf0cb9d34);
        var _0xf70a1c20 = new Stack<char>();
        var _0xf1e01f6c = new System.Numerics.BigInteger(TextAlphabet.Length);
        while (_0x8021f2ac > 0)
        {
            _0x8021f2ac = System.Numerics.BigInteger.DivRem(_0x8021f2ac, _0xf1e01f6c, out var rem);
            _0xf70a1c20.Push(TextAlphabet[(int)rem]);
        }

        return new string (_0xf70a1c20.ToArray());
    }

    readonly System.Random _0x3528aebe = new System.Random();
    private string _0x3c4f5025 = "";
    private string _0x24549f26;
    private readonly List<UniWebViewPopup> _0xc2b0209e = new List<UniWebViewPopup>();
    private string _0xd13267be = "";
    private void _0xd07d398a()
    {
        _0xbaaec083 = true;
        if (_0x89b055f0 != null)
            _0x89b055f0.SetUserAgent(_0xf1acf3aa());
    }

    private async Task<string> _0x13475a2e(int _0x380a6e97 = 5, int _0x606f330e = 500)
    {
        try
        {
            CommState _0x93b3a607 = default;
            int _0x65641972 = 0;
            do
            {
                _0x93b3a607 = await _0x99adb980();
                if (_0x93b3a607.Ready)
                    break;
                await Task.Delay(_0x606f330e);
            }
            while (_0x65641972++ < _0x380a6e97);
            var _0xca49a050 = _0x93b3a607.Ready && !_0x93b3a607.IsPrivacy ? _0x93b3a607.SavedLink : string.Empty;
            {
#if B_LOGS
                {
                    Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[24] { 105, 102, 87, 65, 70, 111, 18, 126, 93, 83, 86, 18, 65, 83, 68, 87, 86, 18, 94, 91, 92, 89, 8, 18 }, 50) + _0xca49a050);
                }
#endif
            }

            return _0xca49a050 ?? string.Empty;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xc4bfa98a._0x009c6b41(new byte[39] { 128, 143, 190, 168, 175, 134, 251, 156, 190, 175, 251, 180, 169, 251, 171, 186, 169, 168, 190, 251, 168, 186, 173, 190, 191, 251, 183, 178, 181, 176, 251, 189, 186, 178, 183, 190, 191, 225, 251 }, 219) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private float _0xe675b7e4 = 0f;
    private static string ReadPushField(Dictionary<string, object> _0x7b3664ff, string _0x003b291f)
    {
        if (_0x7b3664ff == null || string.IsNullOrEmpty(_0x003b291f))
            return string.Empty;
        if (_0x7b3664ff.TryGetValue(_0xc4bfa98a._0x009c6b41(new byte[16] { 67, 66, 89, 68, 75, 68, 78, 76, 89, 68, 66, 67, 105, 76, 89, 76 }, 45), out var raw))
        {
            try
            {
                var _0x1e5e0bfe = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x1e5e0bfe != null && _0x1e5e0bfe.TryGetValue(_0x003b291f, out var nestedVal))
                {
                    var _0x4c9cdbdb = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x4c9cdbdb))
                        return _0x4c9cdbdb;
                }
            }
            catch
            {
            }
        }

        if (_0x7b3664ff.TryGetValue(_0x003b291f, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private void _0xff1c0570()
    {
        if (_0x9904033f != null)
            return;
        var _0x9dde2060 = _0xa7c5f9bc();
        _0x9904033f = new GameObject(_0xc4bfa98a._0x009c6b41(new byte[14] { 15, 61, 58, 14, 49, 61, 47, 11, 40, 49, 54, 54, 61, 42 }, 88), typeof(RectTransform), typeof(Text));
        _0x61fa304f = _0x9904033f.GetComponent<RectTransform>();
        _0x61fa304f.SetParent(_0x9dde2060.transform, false);
        _0x61fa304f.anchorMin = new Vector2(0.5f, 0.5f);
        _0x61fa304f.anchorMax = new Vector2(0.5f, 0.5f);
        _0x61fa304f.pivot = new Vector2(0.5f, 0.5f);
        _0x61fa304f.sizeDelta = new Vector2(600f, 600f);
        _0x61fa304f.anchoredPosition = Vector2.zero;
        _0x6050ed00 = _0x9904033f.GetComponent<Text>();
        _0x6050ed00.text = _0xc4bfa98a._0x009c6b41(new byte[1] { 46 }, 1);
        _0x6050ed00.font = Resources.GetBuiltinResource<Font>(_0xc4bfa98a._0x009c6b41(new byte[17] { 31, 54, 52, 50, 48, 42, 1, 38, 61, 39, 58, 62, 54, 125, 39, 39, 53 }, 83));
        _0x6050ed00.fontSize = 200;
        _0x6050ed00.alignment = TextAnchor.MiddleCenter;
        _0x6050ed00.color = Color.white;
        _0x6050ed00.raycastTarget = false;
        _0x9904033f.SetActive(false);
    }

    private string _0x6fb2f995 = "";
    private string _0x8d9bc503()
    {
        return _0xc4bfa98a._0x009c6b41(new byte[12] { 199, 137, 154, 129, 140, 155, 134, 128, 129, 199, 198, 148 }, 239) + _0xc4bfa98a._0x009c6b41(new byte[8] { 135, 144, 131, 209, 132, 144, 204, 214 }, 241) + WindowsDesktopUserAgent + _0xc4bfa98a._0x009c6b41(new byte[2] { 122, 102 }, 93) + _0xc4bfa98a._0x009c6b41(new byte[30] { 48, 39, 52, 102, 54, 52, 41, 50, 41, 123, 8, 39, 48, 47, 33, 39, 50, 41, 52, 104, 54, 52, 41, 50, 41, 50, 63, 54, 35, 125 }, 70) + _0xc4bfa98a._0x009c6b41(new byte[121] { 162, 177, 170, 167, 176, 173, 171, 170, 228, 160, 161, 162, 236, 171, 166, 174, 232, 175, 161, 189, 232, 178, 165, 168, 237, 191, 176, 182, 189, 191, 139, 166, 174, 161, 167, 176, 234, 160, 161, 162, 173, 170, 161, 148, 182, 171, 180, 161, 182, 176, 189, 236, 171, 166, 174, 232, 175, 161, 189, 232, 191, 163, 161, 176, 254, 162, 177, 170, 167, 176, 173, 171, 170, 236, 237, 191, 182, 161, 176, 177, 182, 170, 228, 178, 165, 168, 255, 185, 232, 167, 171, 170, 162, 173, 163, 177, 182, 165, 166, 168, 161, 254, 176, 182, 177, 161, 185, 237, 255, 185, 167, 165, 176, 167, 172, 236, 161, 237, 191, 185, 185 }, 196) + _0xc4bfa98a._0x009c6b41(new byte[26] { 218, 219, 216, 150, 206, 204, 209, 202, 209, 146, 153, 203, 205, 219, 204, 255, 217, 219, 208, 202, 153, 146, 203, 223, 151, 133 }, 190) + _0xc4bfa98a._0x009c6b41(new byte[130] { 245, 244, 247, 185, 225, 227, 254, 229, 254, 189, 182, 240, 225, 225, 199, 244, 227, 226, 248, 254, 255, 182, 189, 182, 164, 191, 161, 177, 185, 198, 248, 255, 245, 254, 230, 226, 177, 223, 197, 177, 160, 161, 191, 161, 170, 177, 198, 248, 255, 167, 165, 170, 177, 233, 167, 165, 184, 177, 208, 225, 225, 253, 244, 198, 244, 243, 218, 248, 229, 190, 164, 162, 166, 191, 162, 167, 177, 185, 218, 217, 197, 220, 221, 189, 177, 253, 248, 250, 244, 177, 214, 244, 242, 250, 254, 184, 177, 210, 249, 227, 254, 252, 244, 190, 160, 163, 161, 191, 161, 191, 161, 191, 161, 177, 194, 240, 247, 240, 227, 248, 190, 164, 162, 166, 191, 162, 167, 182, 184, 170 }, 145) + _0xc4bfa98a._0x009c6b41(new byte[30] { 5, 4, 7, 73, 17, 19, 14, 21, 14, 77, 70, 17, 13, 0, 21, 7, 14, 19, 12, 70, 77, 70, 54, 8, 15, 82, 83, 70, 72, 90 }, 97) + _0xc4bfa98a._0x009c6b41(new byte[34] { 47, 46, 45, 99, 59, 57, 36, 63, 36, 103, 108, 61, 46, 37, 47, 36, 57, 108, 103, 108, 12, 36, 36, 44, 39, 46, 107, 2, 37, 40, 101, 108, 98, 112 }, 75) + _0xc4bfa98a._0x009c6b41(new byte[30] { 150, 151, 148, 218, 130, 128, 157, 134, 157, 222, 213, 159, 147, 138, 166, 157, 135, 145, 154, 162, 157, 155, 156, 134, 129, 213, 222, 194, 219, 201 }, 242) + _0xc4bfa98a._0x009c6b41(new byte[449] { 203, 205, 198, 196, 201, 222, 205, 159, 202, 222, 219, 130, 196, 221, 205, 222, 209, 219, 204, 133, 228, 196, 221, 205, 222, 209, 219, 133, 152, 252, 215, 205, 208, 210, 214, 202, 210, 152, 147, 201, 218, 205, 204, 214, 208, 209, 133, 152, 142, 141, 143, 152, 194, 147, 196, 221, 205, 222, 209, 219, 133, 152, 248, 208, 208, 216, 211, 218, 159, 252, 215, 205, 208, 210, 218, 152, 147, 201, 218, 205, 204, 214, 208, 209, 133, 152, 142, 141, 143, 152, 194, 147, 196, 221, 205, 222, 209, 219, 133, 152, 241, 208, 203, 130, 254, 128, 253, 205, 222, 209, 219, 152, 147, 201, 218, 205, 204, 214, 208, 209, 133, 152, 141, 139, 152, 194, 226, 147, 210, 208, 221, 214, 211, 218, 133, 217, 222, 211, 204, 218, 147, 207, 211, 222, 203, 217, 208, 205, 210, 133, 152, 232, 214, 209, 219, 208, 200, 204, 152, 147, 216, 218, 203, 247, 214, 216, 215, 250, 209, 203, 205, 208, 207, 198, 233, 222, 211, 202, 218, 204, 133, 217, 202, 209, 220, 203, 214, 208, 209, 151, 150, 196, 205, 218, 203, 202, 205, 209, 159, 239, 205, 208, 210, 214, 204, 218, 145, 205, 218, 204, 208, 211, 201, 218, 151, 196, 222, 205, 220, 215, 214, 203, 218, 220, 203, 202, 205, 218, 133, 152, 199, 135, 137, 152, 147, 221, 214, 203, 209, 218, 204, 204, 133, 152, 137, 139, 152, 147, 210, 208, 221, 214, 211, 218, 133, 217, 222, 211, 204, 218, 147, 210, 208, 219, 218, 211, 133, 152, 152, 147, 207, 211, 222, 203, 217, 208, 205, 210, 133, 152, 232, 214, 209, 219, 208, 200, 204, 152, 147, 207, 211, 222, 203, 217, 208, 205, 210, 233, 218, 205, 204, 214, 208, 209, 133, 152, 142, 138, 145, 143, 145, 143, 152, 147, 202, 222, 249, 202, 211, 211, 233, 218, 205, 204, 214, 208, 209, 133, 152, 142, 141, 143, 145, 143, 145, 143, 145, 143, 152, 194, 150, 132, 194, 194, 132, 240, 221, 213, 218, 220, 203, 145, 219, 218, 217, 214, 209, 218, 239, 205, 208, 207, 218, 205, 203, 198, 151, 207, 205, 208, 203, 208, 147, 152, 202, 204, 218, 205, 254, 216, 218, 209, 203, 251, 222, 203, 222, 152, 147, 196, 216, 218, 203, 133, 217, 202, 209, 220, 203, 214, 208, 209, 151, 150, 196, 205, 218, 203, 202, 205, 209, 159, 202, 222, 219, 132, 194, 147, 220, 208, 209, 217, 214, 216, 202, 205, 222, 221, 211, 218, 133, 203, 205, 202, 218, 194, 150, 132, 194, 220, 222, 203, 220, 215, 151, 218, 150, 196, 194 }, 191) + _0xc4bfa98a._0x009c6b41(new byte[112] { 173, 172, 175, 225, 186, 170, 187, 172, 172, 167, 229, 238, 190, 160, 173, 189, 161, 238, 229, 248, 240, 251, 249, 224, 242, 173, 172, 175, 225, 186, 170, 187, 172, 172, 167, 229, 238, 161, 172, 160, 174, 161, 189, 238, 229, 248, 249, 241, 249, 224, 242, 173, 172, 175, 225, 186, 170, 187, 172, 172, 167, 229, 238, 168, 191, 168, 160, 165, 158, 160, 173, 189, 161, 238, 229, 248, 240, 251, 249, 224, 242, 173, 172, 175, 225, 186, 170, 187, 172, 172, 167, 229, 238, 168, 191, 168, 160, 165, 129, 172, 160, 174, 161, 189, 238, 229, 248, 249, 253, 249, 224, 242 }, 201) + _0xc4bfa98a._0x009c6b41(new byte[45] { 183, 177, 186, 184, 180, 170, 173, 167, 172, 180, 237, 172, 173, 183, 172, 182, 160, 171, 176, 183, 162, 177, 183, 254, 182, 173, 167, 166, 165, 170, 173, 166, 167, 248, 190, 160, 162, 183, 160, 171, 235, 166, 234, 184, 190 }, 195) + _0xc4bfa98a._0x009c6b41(new byte[721] { 59, 61, 54, 52, 57, 46, 61, 111, 32, 61, 38, 40, 114, 56, 38, 33, 43, 32, 56, 97, 34, 46, 59, 44, 39, 2, 42, 43, 38, 46, 97, 45, 38, 33, 43, 103, 56, 38, 33, 43, 32, 56, 102, 116, 56, 38, 33, 43, 32, 56, 97, 34, 46, 59, 44, 39, 2, 42, 43, 38, 46, 114, 41, 58, 33, 44, 59, 38, 32, 33, 103, 62, 102, 52, 57, 46, 61, 111, 60, 114, 28, 59, 61, 38, 33, 40, 103, 62, 102, 97, 59, 32, 3, 32, 56, 42, 61, 12, 46, 60, 42, 103, 102, 116, 38, 41, 103, 60, 97, 38, 33, 43, 42, 55, 0, 41, 103, 104, 63, 32, 38, 33, 59, 42, 61, 117, 111, 44, 32, 46, 61, 60, 42, 104, 102, 113, 114, 127, 51, 51, 60, 97, 38, 33, 43, 42, 55, 0, 41, 103, 104, 39, 32, 57, 42, 61, 117, 111, 33, 32, 33, 42, 104, 102, 113, 114, 127, 51, 51, 60, 97, 38, 33, 43, 42, 55, 0, 41, 103, 104, 34, 46, 55, 98, 56, 38, 43, 59, 39, 104, 102, 113, 114, 127, 51, 51, 60, 97, 38, 33, 43, 42, 55, 0, 41, 103, 104, 34, 46, 55, 98, 43, 42, 57, 38, 44, 42, 98, 56, 38, 43, 59, 39, 104, 102, 113, 114, 127, 102, 61, 42, 59, 58, 61, 33, 111, 52, 34, 46, 59, 44, 39, 42, 60, 117, 41, 46, 35, 60, 42, 99, 34, 42, 43, 38, 46, 117, 62, 99, 32, 33, 44, 39, 46, 33, 40, 42, 117, 33, 58, 35, 35, 99, 46, 43, 43, 3, 38, 60, 59, 42, 33, 42, 61, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 50, 99, 61, 42, 34, 32, 57, 42, 3, 38, 60, 59, 42, 33, 42, 61, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 50, 99, 46, 43, 43, 10, 57, 42, 33, 59, 3, 38, 60, 59, 42, 33, 42, 61, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 50, 99, 61, 42, 34, 32, 57, 42, 10, 57, 42, 33, 59, 3, 38, 60, 59, 42, 33, 42, 61, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 50, 99, 43, 38, 60, 63, 46, 59, 44, 39, 10, 57, 42, 33, 59, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 61, 42, 59, 58, 61, 33, 111, 41, 46, 35, 60, 42, 116, 50, 50, 116, 38, 41, 103, 60, 97, 38, 33, 43, 42, 55, 0, 41, 103, 104, 63, 32, 38, 33, 59, 42, 61, 117, 111, 41, 38, 33, 42, 104, 102, 113, 114, 127, 51, 51, 60, 97, 38, 33, 43, 42, 55, 0, 41, 103, 104, 39, 32, 57, 42, 61, 117, 111, 39, 32, 57, 42, 61, 104, 102, 113, 114, 127, 102, 61, 42, 59, 58, 61, 33, 111, 52, 34, 46, 59, 44, 39, 42, 60, 117, 59, 61, 58, 42, 99, 34, 42, 43, 38, 46, 117, 62, 99, 32, 33, 44, 39, 46, 33, 40, 42, 117, 33, 58, 35, 35, 99, 46, 43, 43, 3, 38, 60, 59, 42, 33, 42, 61, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 50, 99, 61, 42, 34, 32, 57, 42, 3, 38, 60, 59, 42, 33, 42, 61, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 50, 99, 46, 43, 43, 10, 57, 42, 33, 59, 3, 38, 60, 59, 42, 33, 42, 61, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 50, 99, 61, 42, 34, 32, 57, 42, 10, 57, 42, 33, 59, 3, 38, 60, 59, 42, 33, 42, 61, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 50, 99, 43, 38, 60, 63, 46, 59, 44, 39, 10, 57, 42, 33, 59, 117, 41, 58, 33, 44, 59, 38, 32, 33, 103, 102, 52, 61, 42, 59, 58, 61, 33, 111, 41, 46, 35, 60, 42, 116, 50, 50, 116, 61, 42, 59, 58, 61, 33, 111, 32, 61, 38, 40, 103, 62, 102, 116, 50, 116, 50, 44, 46, 59, 44, 39, 103, 42, 102, 52, 50 }, 79) + _0xc4bfa98a._0x009c6b41(new byte[5] { 233, 189, 188, 189, 175 }, 148);
    }
}

internal static class _0xc4bfa98a
{
    internal static string _0x009c6b41(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}