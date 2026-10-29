using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x0933e6ed : MonoBehaviour
{
    private void _0xdd1f8ef4()
    {
        if (this._0x55b730ac == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x06436add = Screen.safeArea;
        Vector2 _0x02121825 = _0x06436add.position;
        Vector2 _0x202b4449 = _0x06436add.position + _0x06436add.size;
        _0x02121825.x /= screenWidth;
        _0x02121825.y /= screenHeight;
        _0x202b4449.x /= screenWidth;
        _0x202b4449.y /= screenHeight;
        this._0x55b730ac.anchorMin = _0x02121825;
        this._0x55b730ac.anchorMax = _0x202b4449;
        this._0x55b730ac.offsetMin = Vector2.zero;
        this._0x55b730ac.offsetMax = Vector2.zero;
        if (this._0x74364e7b == null)
            return;
        Vector2 _0x106c4afe = _0x202b4449 - _0x02121825;
        float _0xa49c2686 = 2f - _0x106c4afe.x;
        float _0xda179a58 = 2f - _0x106c4afe.y;
        this._0x74364e7b.referenceResolution = this._0x519a4d19 * new Vector2(_0xa49c2686, _0xda179a58);
    }

    private void Awake()
    {
        if (!_0x7cec67b3.Contains(this))
            _0x7cec67b3.Add(this);
        this._0x27607786 = this.GetComponent<Canvas>();
        this._0x74364e7b = this.GetComponent<CanvasScaler>();
        if (this._0x74364e7b != null)
            this._0x519a4d19 = this._0x74364e7b.referenceResolution;
        this._0xa318c50b = this.GetComponent<RectTransform>();
        this._0x55b730ac = this.transform.Find(_0x4644c257._0x776df17c(new byte[8] { 26, 40, 47, 44, 8, 59, 44, 40 }, 73)) as RectTransform;
        if (!_0x259daf8e)
        {
            _0x15a8ab65 = Screen.orientation;
            _0xfe12805f.x = Screen.width;
            _0xfe12805f.y = Screen.height;
            _0x96f3b480 = Screen.safeArea;
            _0x259daf8e = true;
        }

        this._0xdd1f8ef4();
    }

    private Canvas _0x27607786;
    private static ScreenOrientation _0x15a8ab65 = ScreenOrientation.LandscapeLeft;
    private static void OrientationChanged()
    {
        _0x15a8ab65 = Screen.orientation;
        _0xfe12805f.x = Screen.width;
        _0xfe12805f.y = Screen.height;
        _0x96f3b480 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x1eb2fe2a.Invoke();
    }

    private static Vector2 _0xfe12805f = Vector2.zero;
    private static void SafeAreaChanged()
    {
        _0x96f3b480 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private CanvasScaler _0x74364e7b;
    private RectTransform _0xa318c50b;
    private static Rect _0x96f3b480 = Rect.zero;
    private RectTransform _0x55b730ac;
    private void Start()
    {
    }

    private Vector2 _0x519a4d19;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x20422cc5 = 0; _0x20422cc5 < _0x7cec67b3.Count; _0x20422cc5++)
            _0x7cec67b3[_0x20422cc5]._0xdd1f8ef4();
    }

    private void Update()
    {
        if (_0x7cec67b3.Count == 0 || _0x7cec67b3[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x15a8ab65)
            OrientationChanged();
        if (Screen.safeArea != _0x96f3b480)
            SafeAreaChanged();
        if (Screen.width != _0xfe12805f.x || Screen.height != _0xfe12805f.y)
            ResolutionChanged();
    }

    private static UnityEvent _0x1eb2fe2a = new();
    private static readonly List<_0x0933e6ed> _0x7cec67b3 = new();
    private static bool _0x259daf8e;
    private static void ResolutionChanged()
    {
        _0xfe12805f.x = Screen.width;
        _0xfe12805f.y = Screen.height;
        _0x96f3b480 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x1eb2fe2a.Invoke();
    }

    private void OnDestroy()
    {
        if (_0x7cec67b3 != null && _0x7cec67b3.Contains(this))
            _0x7cec67b3.Remove(this);
    }
}

internal static class _0x4644c257
{
    internal static string _0x776df17c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}