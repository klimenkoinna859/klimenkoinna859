using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xd3cde5f8 : MonoBehaviour
{
    private static UnityEvent _0x50ea2bcd = new();
    private static void OrientationChanged()
    {
        _0x45413ba6 = Screen.orientation;
        _0xa68a69dc.x = Screen.width;
        _0xa68a69dc.y = Screen.height;
        _0x50ea2bcd.Invoke();
    }

    private static Vector2 _0xa68a69dc = Vector2.zero;
    private void Update()
    {
        if (_0x9393f85b[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x45413ba6)
            OrientationChanged();
        if (Screen.safeArea != _0x477798c8)
            SafeAreaChanged();
        if (Screen.width != _0xa68a69dc.x || Screen.height != _0xa68a69dc.y)
            ResolutionChanged();
    }

    private void Awake()
    {
        if (!_0x9393f85b.Contains(this))
            _0x9393f85b.Add(this);
        this._0x2db4876b = this.GetComponent<Canvas>();
        this._0x4e84ed23 = this.GetComponent<RectTransform>();
        this._0xf1a5ec19 = this.transform.Find(_0xda4fd970._0xe6f31d19(new byte[8] { 152, 170, 173, 174, 138, 185, 174, 170 }, 203)) as RectTransform;
        if (!_0x96856785)
        {
            _0x45413ba6 = Screen.orientation;
            _0xa68a69dc.x = Screen.width;
            _0xa68a69dc.y = Screen.height;
            _0x477798c8 = Screen.safeArea;
            _0x96856785 = true;
        }

        this._0xa1bf1cef();
    }

    private static void SafeAreaChanged()
    {
        _0x477798c8 = Screen.safeArea;
        for (int _0x87bf481a = 0; _0x87bf481a < _0x9393f85b.Count; _0x87bf481a++)
            _0x9393f85b[_0x87bf481a]._0xa1bf1cef();
    }

    private static Rect _0x477798c8 = Rect.zero;
    private static void ResolutionChanged()
    {
        _0xa68a69dc.x = Screen.width;
        _0xa68a69dc.y = Screen.height;
        _0x50ea2bcd.Invoke();
    }

    private static readonly List<_0xd3cde5f8> _0x9393f85b = new();
    private RectTransform _0x4e84ed23;
    private static ScreenOrientation _0x45413ba6 = ScreenOrientation.LandscapeLeft;
    private RectTransform _0xf1a5ec19;
    private static bool _0x96856785;
    private void _0xa1bf1cef()
    {
        if (this._0xf1a5ec19 == null)
            return;
        Rect _0xca1aaaf8 = Screen.safeArea;
        Vector2 _0x686b2f42 = _0xca1aaaf8.position;
        Vector2 _0xb36669e0 = _0xca1aaaf8.position + _0xca1aaaf8.size;
        _0x686b2f42.x /= this._0x2db4876b.pixelRect.width;
        _0x686b2f42.y /= this._0x2db4876b.pixelRect.height;
        _0xb36669e0.x /= this._0x2db4876b.pixelRect.width;
        _0xb36669e0.y /= this._0x2db4876b.pixelRect.height;
        this._0xf1a5ec19.anchorMin = _0x686b2f42;
        this._0xf1a5ec19.anchorMax = _0xb36669e0;
    }

    private Canvas _0x2db4876b;
    private void OnDestroy()
    {
        if (_0x9393f85b != null && _0x9393f85b.Contains(this))
            _0x9393f85b.Remove(this);
    }
}

internal static class _0xda4fd970
{
    internal static string _0xe6f31d19(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}