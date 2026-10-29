using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A free top-up once a day. Nothing here is bought; the cooldown is measured against
/// DateTime.UtcNow on this device and there is no network call anywhere.
/// </summary>
public sealed class _0x16434292 : MonoBehaviour, _0x5ed4f0d4
{
    private TextMeshProUGUI _0xcc85d0d0;
    private void _0xb1a9f78f()
    {
        if (!GiftReady())
        {
            return;
        }

        int _0x6dca155d = _0xdfbe9389._0xbb0a7f51 + 1;
        if (_0x6dca155d > _0x2da34b06.StreakLength)
        {
            _0x6dca155d = 1;
        }

        int _0xfd5235ee = _0x6dca155d >= _0x2da34b06.StreakLength ? _0x2da34b06.GiftStreakBonus : _0x2da34b06.GiftAmount;
        int _0xa9003f75 = _0xdfbe9389._0x8d6a1c71;
        _0xdfbe9389._0x8d6a1c71 = _0xa9003f75 + _0xfd5235ee;
        _0xdfbe9389._0xbb0a7f51 = _0x6dca155d;
        _0xdfbe9389._0x7d5e939c = DateTime.UtcNow.Ticks;
        if (_0x6dca155d >= _0x2da34b06.StreakLength)
        {
            _0xf7dacd0a.GrantCard(_0xdfbe9389.UtcDayNumber());
        }

        if (_0x6dca155d > _0xdfbe9389._0xe1ff0088)
        {
            _0xdfbe9389._0xe1ff0088 = _0x6dca155d;
        }

        _0xdfbe9389.Flush();
        _0xaf5af43d.Tick();
        _0x98589ea5.CountTo(this._0x4d2c118e, _0xa9003f75, _0xa9003f75 + _0xfd5235ee, _0x18d04c9b._0xa562bbd0(new byte[1] { 172 }, 135));
        this._0x09f38562();
        this.Refresh();
    }

    private void _0x6a485866()
    {
        if (this._0xc932da71 == null || _0xdfbe9389._0x5fbcf839)
        {
            return;
        }

        RectTransform _0xdafc6a00 = (RectTransform)this._0xc932da71.transform;
        _0xdafc6a00.DOKill(false);
        _0xdafc6a00.anchoredPosition = Vector2.zero;
        _0xdafc6a00.DOAnchorPosY(14f, 1.9f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0xdafc6a00.gameObject);
    }

    private TextMeshProUGUI _0x9db7a245;
    private TextMeshProUGUI _0x4d2c118e;
    private Image _0xc932da71;
    /// <summary>"NEXT GIFT IN 06:12" - the box is sized for the longest form of this.</summary>
    public static string CooldownText()
    {
        long _0x830d6bc1 = _0xdfbe9389._0x7d5e939c;
        if (_0x830d6bc1 <= 0)
        {
            return _0x18d04c9b._0xa562bbd0(new byte[5] { 44, 59, 63, 58, 39 }, 126);
        }

        TimeSpan _0x80bbedb4 = DateTime.UtcNow - new DateTime(_0x830d6bc1, DateTimeKind.Utc);
        double _0x6b1da24e = _0x2da34b06.GiftCooldownHours - _0x80bbedb4.TotalHours;
        if (_0x6b1da24e <= 0)
        {
            return _0x18d04c9b._0xa562bbd0(new byte[5] { 7, 16, 20, 17, 12 }, 85);
        }

        int _0x9eb30e0f = (int)_0x6b1da24e;
        int _0x195ac553 = (int)((_0x6b1da24e - _0x9eb30e0f) * 60);
        return _0x18d04c9b._0xa562bbd0(new byte[3] { 213, 210, 188 }, 156) + _0x9eb30e0f.ToString(_0x18d04c9b._0xa562bbd0(new byte[2] { 240, 240 }, 192)) + _0x18d04c9b._0xa562bbd0(new byte[2] { 229, 141 }, 173) + _0x195ac553.ToString(_0x18d04c9b._0xa562bbd0(new byte[2] { 197, 197 }, 245)) + _0x18d04c9b._0xa562bbd0(new byte[1] { 112 }, 61);
    }

    private void _0x09f38562()
    {
        if (this._0xfba0b3b3 == null || _0xdfbe9389._0x5fbcf839)
        {
            return;
        }

        this._0xfba0b3b3.transform.localScale = Vector3.zero;
        this._0xfba0b3b3.color = _0x3fe280fb.Fade(_0x3fe280fb.GoldLight, 0.65f);
        this._0xfba0b3b3.transform.DOScale(1.3f, 0.45f).SetEase(Ease.OutQuad).SetLink(this._0xfba0b3b3.gameObject);
        this._0xfba0b3b3.DOFade(0f, 0.45f).SetEase(Ease.OutQuad).SetLink(this._0xfba0b3b3.gameObject);
    }

    private Button _0x6f762835;
    private _0xe0927a8a _0x188a9138;
    private readonly List<_0xc5d7f584> _0xe7171d24 = new List<_0xc5d7f584>();
    private void OnDestroy()
    {
        if (this._0xc932da71 != null)
        {
            DOTween.Kill(this._0xc932da71.transform);
        }

        if (this._0xfba0b3b3 != null)
        {
            DOTween.Kill(this._0xfba0b3b3);
            DOTween.Kill(this._0xfba0b3b3.transform);
        }
    }

    private TextMeshProUGUI _0xfebfd898;
    private Image _0xfba0b3b3;
    public void Refresh()
    {
        bool _0xdb0be9b1 = GiftReady();
        int _0xbae7f9bd = _0xdfbe9389._0xbb0a7f51;
        int _0xea90b95c = _0xbae7f9bd + 1 > _0x2da34b06.StreakLength ? 1 : _0xbae7f9bd + 1;
        int _0x0500e89d = _0xea90b95c >= _0x2da34b06.StreakLength ? _0x2da34b06.GiftStreakBonus : _0x2da34b06.GiftAmount;
        _0xd6a1e4cb.SetText(this._0xcc85d0d0, _0xdb0be9b1 ? _0x18d04c9b._0xa562bbd0(new byte[29] { 71, 91, 86, 51, 91, 92, 70, 64, 86, 51, 90, 64, 51, 85, 86, 86, 95, 90, 93, 84, 51, 84, 86, 93, 86, 65, 92, 70, 64 }, 19) : _0x18d04c9b._0xa562bbd0(new byte[18] { 94, 82, 80, 88, 61, 95, 92, 94, 86, 61, 73, 82, 80, 82, 79, 79, 82, 74 }, 29));
        _0xd6a1e4cb.SetText(this._0x4d2c118e, _0xdb0be9b1 ? _0x18d04c9b._0xa562bbd0(new byte[1] { 126 }, 85) + _0x2da34b06.Grouped(_0x0500e89d) : _0x18d04c9b._0xa562bbd0(new byte[10] { 178, 185, 164, 168, 220, 187, 181, 186, 168, 220 }, 252) + CooldownText());
        _0x98589ea5.SetEnabled(this._0x6f762835, this._0x5c8a14a7, this._0xfebfd898, _0xdb0be9b1, _0x3fe280fb.Gold, _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.55f), _0x3fe280fb.Cream, _0x3fe280fb.CreamMuted);
        _0xd6a1e4cb.SetText(this._0xfebfd898, _0xdb0be9b1 ? _0x18d04c9b._0xa562bbd0(new byte[10] { 103, 104, 101, 109, 105, 4, 99, 109, 98, 112 }, 36) : _0x18d04c9b._0xa562bbd0(new byte[7] { 29, 18, 31, 23, 19, 27, 26 }, 94));
        if (this._0xc932da71 != null)
        {
            this._0xc932da71.color = _0xdb0be9b1 ? Color.white : _0x3fe280fb.Fade(_0x3fe280fb.CreamMuted, 0.55f);
        }

        for (int _0x19f5113a = 0; _0x19f5113a < this._0xe7171d24.Count; _0x19f5113a++)
        {
            this._0xe7171d24[_0x19f5113a]._0x68264ad1(_0x19f5113a < _0xbae7f9bd, _0x3fe280fb.Gold);
        }

        _0xd6a1e4cb.SetText(this._0x9db7a245, _0x18d04c9b._0xa562bbd0(new byte[7] { 242, 245, 243, 228, 224, 234, 129 }, 161) + _0xbae7f9bd + _0x18d04c9b._0xa562bbd0(new byte[3] { 51, 60, 51 }, 19) + _0x2da34b06.StreakLength);
        this._0x6a485866();
    }

    private Image _0x5c8a14a7;
    public static bool GiftReady()
    {
        long _0x455dc6d3 = _0xdfbe9389._0x7d5e939c;
        if (_0x455dc6d3 <= 0)
        {
            return true;
        }

        TimeSpan _0x9788fbf4 = DateTime.UtcNow - new DateTime(_0x455dc6d3, DateTimeKind.Utc);
        return _0x9788fbf4.TotalHours >= _0x2da34b06.GiftCooldownHours;
    }

    public void _0x2d065ef4(_0xe0927a8a _0x6ebd3a4f, _0xf84cb8b0 _0x9ed3a3a4, _0x9fb34e44 _0x953d2b2b, _0xc5d7f584 _0xf866b815)
    {
        this._0x188a9138 = _0x6ebd3a4f;
        RectTransform _0x706cbc50 = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0x706cbc50, _0x18d04c9b._0xa562bbd0(new byte[5] { 190, 153, 131, 133, 147 }, 246), _0x6ebd3a4f._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0x706cbc50, _0x18d04c9b._0xa562bbd0(new byte[4] { 241, 199, 213, 206 }, 166), _0x6ebd3a4f._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.55f), 0f, 2.0f);
        _0xf84cb8b0.Header(_0x706cbc50, _0x6ebd3a4f, _0x9ed3a3a4, _0x18d04c9b._0xa562bbd0(new byte[10] { 4, 1, 9, 12, 25, 96, 7, 9, 6, 20 }, 64), _0x18d04c9b._0xa562bbd0(new byte[25] { 68, 69, 78, 43, 77, 89, 78, 78, 43, 95, 68, 91, 38, 94, 91, 43, 78, 93, 78, 89, 82, 43, 79, 74, 82 }, 11));
        this._0xfba0b3b3 = _0x98589ea5.Plate(_0x706cbc50, _0x18d04c9b._0xa562bbd0(new byte[5] { 159, 168, 175, 174, 169 }, 221), _0x6ebd3a4f._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.GoldLight, 0f), new Vector2(0.5f, 0.60f), Vector2.zero, new Vector2(620f, 620f), 1.1f);
        this._0xc932da71 = _0x98589ea5.Picture(_0x706cbc50, _0x18d04c9b._0xa562bbd0(new byte[7] { 150, 184, 183, 165, 147, 190, 169 }, 209), _0x6ebd3a4f._0x9f010034, Color.white, new Vector2(0.5f, 0.60f), Vector2.zero, new Vector2(460f, 460f));
        this._0xcc85d0d0 = _0x98589ea5.Label(_0x706cbc50, _0x18d04c9b._0xa562bbd0(new byte[9] { 179, 157, 146, 128, 160, 157, 128, 152, 145 }, 244), _0x18d04c9b._0xa562bbd0(new byte[1] { 202 }, 231), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.Gold, TextAlignmentOptions.Center, new Vector2(0.5f, 0.60f), new Vector2(0f, -300f), new Vector2(1020f, 70f));
        this._0x4d2c118e = _0x98589ea5.Label(_0x706cbc50, _0x18d04c9b._0xa562bbd0(new byte[10] { 170, 132, 139, 153, 172, 128, 130, 152, 131, 153 }, 237), _0x18d04c9b._0xa562bbd0(new byte[1] { 232 }, 197), _0x2da34b06.NumberMax, _0x2da34b06.NumberMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Center, new Vector2(0.5f, 0.60f), new Vector2(0f, -392f), new Vector2(1020f, 86f));
        _0x9fb34e44 _0xffb90b38 = Instantiate(_0x953d2b2b, _0x706cbc50, false);
        RectTransform _0xe67a3ac5 = _0xffb90b38._0x7693cccd;
        _0xe67a3ac5.anchorMin = new Vector2(0.5f, 0.34f);
        _0xe67a3ac5.anchorMax = new Vector2(0.5f, 0.34f);
        _0xe67a3ac5.anchoredPosition = Vector2.zero;
        _0xffb90b38._0x0d1f6abd(new Vector2(1080f, 230f));
        _0xffb90b38._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0x5a85d7ea = _0xffb90b38._0xf9550e0d;
        for (int _0x53636827 = 0; _0x53636827 < _0x2da34b06.StreakLength; _0x53636827++)
        {
            _0xc5d7f584 _0xae9c934e = Instantiate(_0xf866b815, _0x5a85d7ea, false);
            RectTransform _0xf73fb1b6 = (RectTransform)_0xae9c934e.transform;
            _0xf73fb1b6.anchorMin = _0x98589ea5.Centre;
            _0xf73fb1b6.anchorMax = _0x98589ea5.Centre;
            _0xf73fb1b6.sizeDelta = new Vector2(72f, 72f);
            _0xf73fb1b6.anchoredPosition = new Vector2((_0x53636827 - 3) * 100f, 26f);
            this._0xe7171d24.Add(_0xae9c934e);
        }

        this._0x9db7a245 = _0x98589ea5.Label(_0x5a85d7ea, _0x18d04c9b._0xa562bbd0(new byte[13] { 185, 158, 152, 143, 139, 129, 169, 139, 154, 158, 131, 133, 132 }, 234), _0x18d04c9b._0xa562bbd0(new byte[1] { 55 }, 26), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, -62f), new Vector2(1000f, 46f));
        this._0x6f762835 = _0x98589ea5.Cta(_0x706cbc50, _0x18d04c9b._0xa562bbd0(new byte[5] { 249, 214, 219, 211, 215 }, 186), _0x18d04c9b._0xa562bbd0(new byte[10] { 241, 254, 243, 251, 255, 146, 245, 251, 244, 230 }, 178), _0x6ebd3a4f._0x24421334, null, _0x3fe280fb.Gold, _0x3fe280fb.Cream, new Vector2(0.5f, 0.20f), Vector2.zero, new Vector2(760f, 160f), 1.6f);
        this._0x5c8a14a7 = this._0x6f762835.GetComponent<Image>();
        this._0xfebfd898 = this._0x6f762835.GetComponentInChildren<TMP_Text>(true) as TextMeshProUGUI;
        _0x98589ea5.OnTap(this._0x6f762835, () => this._0xb1a9f78f());
        _0x98589ea5.Label(_0x706cbc50, _0x18d04c9b._0xa562bbd0(new byte[8] { 40, 6, 9, 27, 33, 0, 27, 10 }, 111), _0x18d04c9b._0xa562bbd0(new byte[41] { 12, 9, 17, 104, 127, 104, 24, 9, 17, 27, 104, 99, 121, 104, 125, 120, 120, 104, 9, 6, 12, 104, 7, 6, 13, 104, 11, 7, 4, 4, 13, 11, 28, 1, 7, 6, 104, 11, 9, 26, 12 }, 72), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.20f), new Vector2(0f, -122f), new Vector2(1060f, 48f));
    }
}

internal static class _0x18d04c9b
{
    internal static string _0xa562bbd0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}