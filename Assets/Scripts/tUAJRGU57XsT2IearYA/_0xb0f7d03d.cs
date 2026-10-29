using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A profile that lives on this device only: a tint for the emblem and one of six
/// preset aliases. There is no text input, no account and no sign-in anywhere.
/// </summary>
public sealed class _0xb0f7d03d : MonoBehaviour, _0x5ed4f0d4
{
    public void Refresh()
    {
        int _0x8fc1a68d = _0xdfbe9389._0xa862c4d3;
        int _0x02e8b7e0 = _0xdfbe9389._0xd3b1284a;
        if (this._0x4250c8fa != null)
        {
            this._0x4250c8fa.color = TintOf(_0x8fc1a68d);
        }

        for (int _0x5a53e788 = 0; _0x5a53e788 < this._0xd22fdcf4.Count; _0x5a53e788++)
        {
            bool _0xd4cbb4f7 = _0x5a53e788 == _0x8fc1a68d;
            this._0xd22fdcf4[_0x5a53e788].color = _0x3fe280fb.Fade(TintOf(_0x5a53e788), _0xd4cbb4f7 ? 1f : 0.45f);
            this._0xd22fdcf4[_0x5a53e788].transform.localScale = _0xd4cbb4f7 ? new Vector3(1.08f, 1.08f, 1f) : Vector3.one;
        }

        for (int _0xd584601d = 0; _0xd584601d < this._0xc79fc556.Count; _0xd584601d++)
        {
            bool _0x83619bde = _0xd584601d == _0x02e8b7e0;
            this._0xc79fc556[_0xd584601d]._0x3a14c276(_0x83619bde);
            this._0x8dc24265[_0xd584601d].color = _0x83619bde ? _0x3fe280fb.GoldLight : _0x3fe280fb.Cream;
        }

        _0xd6a1e4cb.SetText(this._0xab7760d6, _0x7a19c8cc._0x90363df3(new byte[5] { 122, 105, 102, 99, 8 }, 40) + _0xf7dacd0a._0xd708b43a + _0x7a19c8cc._0x90363df3(new byte[3] { 206, 195, 206 }, 238) + _0xdfbe9389._0x0f985d80 + _0x7a19c8cc._0x90363df3(new byte[8] { 111, 14, 12, 27, 28, 111, 98, 111 }, 79) + _0xf7dacd0a.CardsOwned() + _0x7a19c8cc._0x90363df3(new byte[6] { 119, 20, 22, 5, 19, 4 }, 87));
    }

    public void _0x74de3ffc(_0xe0927a8a _0xc1121380, _0xf84cb8b0 _0x868d1c96, _0x9fb34e44 _0xa9c49390)
    {
        RectTransform _0x0bd93c26 = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0x0bd93c26, _0x7a19c8cc._0x90363df3(new byte[5] { 156, 187, 161, 167, 177 }, 212), _0xc1121380._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0x0bd93c26, _0x7a19c8cc._0x90363df3(new byte[4] { 93, 107, 121, 98 }, 10), _0xc1121380._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.58f), 0f, 2.0f);
        _0xf84cb8b0.Header(_0x0bd93c26, _0xc1121380, _0x868d1c96, _0x7a19c8cc._0x90363df3(new byte[7] { 219, 217, 196, 205, 194, 199, 206 }, 139), _0x7a19c8cc._0x90363df3(new byte[26] { 71, 64, 91, 70, 81, 80, 52, 91, 90, 52, 64, 92, 93, 71, 52, 80, 81, 66, 93, 87, 81, 52, 91, 90, 88, 77 }, 20));
        this._0xab7760d6 = _0x98589ea5.Label(_0x0bd93c26, _0x7a19c8cc._0x90363df3(new byte[7] { 115, 85, 77, 77, 65, 82, 89 }, 32), _0x7a19c8cc._0x90363df3(new byte[1] { 102 }, 75), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, -340f), new Vector2(1040f, 56f));
        this._0x52bbe558 = _0x98589ea5.Plate(_0x0bd93c26, _0x7a19c8cc._0x90363df3(new byte[4] { 68, 127, 120, 113 }, 22), _0xc1121380._0xb1d3c259, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.9f), new Vector2(0.5f, 0.74f), Vector2.zero, new Vector2(420f, 420f), 1.0f);
        this._0x4250c8fa = _0x98589ea5.Picture(_0x0bd93c26, _0x7a19c8cc._0x90363df3(new byte[6] { 234, 221, 202, 223, 202, 217 }, 171), _0xc1121380._0x9f010034, _0x3fe280fb.Gold, new Vector2(0.5f, 0.74f), Vector2.zero, new Vector2(300f, 300f));
        _0x98589ea5.Label(_0x0bd93c26, _0x7a19c8cc._0x90363df3(new byte[11] { 115, 78, 73, 83, 100, 70, 87, 83, 78, 72, 73 }, 39), _0x7a19c8cc._0x90363df3(new byte[12] { 121, 126, 100, 98, 116, 17, 114, 126, 125, 126, 100, 99 }, 49), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.62f), Vector2.zero, new Vector2(900f, 46f));
        for (int _0xac578a70 = 0; _0xac578a70 < 3; _0xac578a70++)
        {
            Button _0xe8e3ba34 = _0x98589ea5.IconButton(_0x0bd93c26, _0x7a19c8cc._0x90363df3(new byte[4] { 58, 7, 0, 26 }, 110), _0xc1121380._0xb1d3c259, _0xc1121380._0x294d71d8(0), TintOf(_0xac578a70), _0x3fe280fb.Cream, new Vector2(0.5f, 0.56f), new Vector2((_0xac578a70 - 1) * 190f, 0f), 150f, 1.0f);
            Image _0x51c4e5c2 = _0xe8e3ba34.GetComponent<Image>();
            this._0xd22fdcf4.Add(_0x51c4e5c2);
            int _0x1bbfd865 = _0xac578a70;
            _0x98589ea5.OnTap(_0xe8e3ba34, () => this._0xbdae5051(_0x1bbfd865));
        }

        _0x98589ea5.Label(_0x0bd93c26, _0x7a19c8cc._0x90363df3(new byte[12] { 39, 10, 15, 7, 21, 37, 7, 22, 18, 15, 9, 8 }, 102), _0x7a19c8cc._0x90363df3(new byte[27] { 140, 139, 147, 228, 144, 140, 129, 228, 140, 139, 145, 151, 129, 228, 133, 138, 138, 139, 145, 138, 135, 129, 151, 228, 157, 139, 145 }, 196), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.47f), Vector2.zero, new Vector2(1000f, 46f));
        for (int _0xecdd1b89 = 0; _0xecdd1b89 < 6; _0xecdd1b89++)
        {
            int _0xc50b00f0 = _0xecdd1b89 % 2;
            int _0x23ec982f = _0xecdd1b89 / 2;
            _0x9fb34e44 _0xaef792bf = Instantiate(_0xa9c49390, _0x0bd93c26, false);
            RectTransform _0xb1086de4 = _0xaef792bf._0x7693cccd;
            _0xb1086de4.anchorMin = new Vector2(0.5f, 0.42f);
            _0xb1086de4.anchorMax = new Vector2(0.5f, 0.42f);
            _0xb1086de4.anchoredPosition = new Vector2(_0xc50b00f0 == 0 ? -278f : 278f, -_0x23ec982f * 152f);
            _0xaef792bf._0x0d1f6abd(new Vector2(520f, 130f));
            _0xaef792bf._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
            Transform _0x3c11dbbb = _0xaef792bf._0xf9550e0d;
            TextMeshProUGUI _0x6565445d = _0x98589ea5.Label(_0x3c11dbbb, _0x7a19c8cc._0x90363df3(new byte[9] { 203, 230, 227, 235, 249, 196, 235, 231, 239 }, 138), _0xf7dacd0a.AliasName(_0xecdd1b89), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, _0x98589ea5.Centre, Vector2.zero, new Vector2(460f, 56f));
            Image _0x49dd5ba4 = _0x3c11dbbb.gameObject.AddComponent<Image>();
            _0x49dd5ba4.sprite = _0xc1121380._0xfa9196f7;
            _0x49dd5ba4.type = Image.Type.Sliced;
            _0x49dd5ba4.pixelsPerUnitMultiplier = 2.2f;
            _0x49dd5ba4.color = new Color(1f, 1f, 1f, 0f);
            _0x49dd5ba4.raycastTarget = true;
            Button _0x4ba8a04e = _0x3c11dbbb.gameObject.AddComponent<Button>();
            _0x4ba8a04e.targetGraphic = _0x49dd5ba4;
            _0x4ba8a04e.transition = Selectable.Transition.None;
            int _0x03370aa9 = _0xecdd1b89;
            _0x98589ea5.OnTap(_0x4ba8a04e, () => this._0xb77caca0(_0x03370aa9));
            this._0xc79fc556.Add(_0xaef792bf);
            this._0x8dc24265.Add(_0x6565445d);
        }

        _0x98589ea5.Label(_0x0bd93c26, _0x7a19c8cc._0x90363df3(new byte[11] { 194, 224, 253, 244, 251, 254, 247, 220, 253, 230, 247 }, 146), _0x7a19c8cc._0x90363df3(new byte[37] { 226, 224, 253, 244, 251, 254, 247, 146, 251, 225, 146, 225, 230, 253, 224, 247, 246, 146, 253, 252, 146, 230, 250, 251, 225, 146, 246, 247, 228, 251, 241, 247, 146, 253, 252, 254, 235 }, 178), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.BottomCentre, new Vector2(0f, 150f), new Vector2(1060f, 50f));
    }

    private readonly List<Image> _0xd22fdcf4 = new List<Image>();
    private TextMeshProUGUI _0xab7760d6;
    private Image _0x4250c8fa;
    private Image _0x52bbe558;
    private void OnDestroy()
    {
        if (this._0x4250c8fa != null)
        {
            DOTween.Kill(this._0x4250c8fa);
        }

        if (this._0x52bbe558 != null)
        {
            DOTween.Kill(this._0x52bbe558.transform);
        }
    }

    private static Color TintOf(int _0xabdbf9db)
    {
        if (_0xabdbf9db == 1)
        {
            return _0x3fe280fb.Rose;
        }

        return _0xabdbf9db == 2 ? _0x3fe280fb.Brass : _0x3fe280fb.Gold;
    }

    private void _0xb77caca0(int _0xb3dab873)
    {
        _0xdfbe9389._0xd3b1284a = _0xb3dab873;
        _0xaf5af43d.Tick();
        this.Refresh();
    }

    private void _0xbdae5051(int _0x5bd6a982)
    {
        _0xdfbe9389._0xa862c4d3 = _0x5bd6a982;
        _0xaf5af43d.Tick();
        if (this._0x4250c8fa != null && !_0xdfbe9389._0x5fbcf839)
        {
            this._0x4250c8fa.DOColor(TintOf(_0x5bd6a982), 0.25f).SetLink(this._0x4250c8fa.gameObject);
        }

        if (this._0x52bbe558 != null && !_0xdfbe9389._0x5fbcf839)
        {
            this._0x52bbe558.transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0f), 0.3f, 6, 0.6f).SetLink(this._0x52bbe558.gameObject);
        }

        this.Refresh();
    }

    private readonly List<TextMeshProUGUI> _0x8dc24265 = new List<TextMeshProUGUI>();
    private readonly List<_0x9fb34e44> _0xc79fc556 = new List<_0x9fb34e44>();
}

internal static class _0x7a19c8cc
{
    internal static string _0x90363df3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}