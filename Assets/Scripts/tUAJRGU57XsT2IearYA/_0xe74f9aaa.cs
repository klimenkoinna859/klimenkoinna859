using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Four rows, every one of which does something the player can see or feel.
///
/// This game is silent by design, so it carries no speaker glyph and no loudness
/// slider: a control with nothing to control is a dead button. That slot is given to
/// haptics, reduced motion and reel speed, all three of which change what you see.
///
/// RESET confirms in place with a second tap rather than raising a popup - only pop
/// indices 6, 7 and 8 are known-good on this template and all three are spoken for.
/// </summary>
public sealed class _0xe74f9aaa : MonoBehaviour, _0x5ed4f0d4
{
    private void OnDestroy()
    {
        for (int _0x5258063c = 0; _0x5258063c < this._0x2c930af3.Count; _0x5258063c++)
        {
            if (this._0x2c930af3[_0x5258063c] != null)
            {
                DOTween.Kill(this._0x2c930af3[_0x5258063c]);
            }
        }

        for (int _0xdaeeab7e = 0; _0xdaeeab7e < this._0x7c02f580.Count; _0xdaeeab7e++)
        {
            if (this._0x7c02f580[_0xdaeeab7e] != null)
            {
                DOTween.Kill(this._0x7c02f580[_0xdaeeab7e].transform);
            }
        }
    }

    private void _0xf186f01f(_0xe0927a8a _0xa66b4479, _0x9fb34e44 _0xb87abb5c, Transform _0x1181f821, int _0xce38d9f2, string _0x034b2282)
    {
        _0x9fb34e44 _0x4ea20a4d = Instantiate(_0xb87abb5c, _0x1181f821, false);
        RectTransform _0x56d82aab = _0x4ea20a4d._0x7693cccd;
        _0x56d82aab.anchorMin = _0x98589ea5.TopCentre;
        _0x56d82aab.anchorMax = _0x98589ea5.TopCentre;
        _0x56d82aab.anchoredPosition = new Vector2(0f, -560f - _0xce38d9f2 * 230f);
        _0x4ea20a4d._0x0d1f6abd(new Vector2(1080f, 190f));
        _0x4ea20a4d._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0xdd90b94b = _0x4ea20a4d._0xf9550e0d;
        _0x98589ea5.Plate(_0xdd90b94b, _0x58786d6c._0x36e14b49(new byte[3] { 87, 110, 119 }, 7), _0xa66b4479._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.85f), _0x98589ea5.Centre, new Vector2(_0x2da34b06.GutterCentre - 540f, 0f), new Vector2(_0x2da34b06.GutterWidth, 60f), 1.0f);
        TextMeshProUGUI _0x3f420339 = _0x98589ea5.Label(_0xdd90b94b, _0x58786d6c._0x36e14b49(new byte[7] { 209, 236, 244, 205, 226, 238, 230 }, 131), _0x034b2282, _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(129f + 230f - 540f, 24f), new Vector2(460f, 54f));
        _0x98589ea5.Label(_0xdd90b94b, _0x58786d6c._0x36e14b49(new byte[7] { 81, 108, 116, 75, 106, 109, 119 }, 3), this._0x7c49aa61(_0xce38d9f2), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(129f + 230f - 540f, -34f), new Vector2(460f, 44f));
        // A three-dot preview strip re-times itself when FAST REELS flips, so the row
        // shows its own effect instead of only changing a word.
        for (int _0x2f6c89bc = 0; _0x2f6c89bc < 3; _0x2f6c89bc++)
        {
            Image _0x3fc250a0 = _0x98589ea5.Plate(_0xdd90b94b, _0x58786d6c._0x36e14b49(new byte[10] { 215, 245, 226, 241, 238, 226, 240, 195, 232, 243 }, 135), _0xa66b4479._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Gold, 0.85f), _0x98589ea5.Centre, new Vector2(150f + _0x2f6c89bc * 46f, 0f), new Vector2(22f, 22f), 1.0f);
            if (_0xce38d9f2 == 2)
            {
                this._0x2c930af3.Add(_0x3fc250a0);
            }
        }

        Image _0x327d2114 = _0x98589ea5.Plate(_0xdd90b94b, _0x58786d6c._0x36e14b49(new byte[5] { 217, 255, 236, 238, 230 }, 141), _0xa66b4479._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.9f), _0x98589ea5.Centre, new Vector2(400f, 0f), new Vector2(180f, 80f), 1.0f);
        Image _0x288a0c7c = _0x98589ea5.Plate(_0xdd90b94b, _0x58786d6c._0x36e14b49(new byte[4] { 225, 196, 197, 200 }, 170), _0xa66b4479._0xb1d3c259, _0x3fe280fb.Cream, _0x98589ea5.Centre, new Vector2(352f, 0f), new Vector2(64f, 64f), 1.0f);
        Image _0xcffce7ef = _0xdd90b94b.gameObject.AddComponent<Image>();
        _0xcffce7ef.sprite = _0xa66b4479._0xfa9196f7;
        _0xcffce7ef.type = Image.Type.Sliced;
        _0xcffce7ef.pixelsPerUnitMultiplier = 2.2f;
        _0xcffce7ef.color = new Color(1f, 1f, 1f, 0f);
        _0xcffce7ef.raycastTarget = true;
        Button _0xc6757c0e = _0xdd90b94b.gameObject.AddComponent<Button>();
        _0xc6757c0e.targetGraphic = _0xcffce7ef;
        _0xc6757c0e.transition = Selectable.Transition.None;
        int _0xde886f0b = _0xce38d9f2;
        _0x98589ea5.OnTap(_0xc6757c0e, () => this._0x20a9db2d(_0xde886f0b));
        this._0x02fc3aea.Add(_0x4ea20a4d);
        this._0xb6b6ef44.Add(_0x3f420339);
        this._0xf689459e.Add(_0x327d2114);
        this._0x7c02f580.Add(_0x288a0c7c);
    }

    private readonly List<TextMeshProUGUI> _0xb6b6ef44 = new List<TextMeshProUGUI>();
    private _0x9fb34e44 _0x2ba79061;
    private readonly List<_0x9fb34e44> _0x02fc3aea = new List<_0x9fb34e44>();
    private void _0xa3dc206a()
    {
        if (!this._0x15ac6f9f)
        {
            this._0x15ac6f9f = true;
            _0xd6a1e4cb.SetText(this._0x15f02ac4, _0x58786d6c._0x36e14b49(new byte[20] { 27, 14, 31, 111, 14, 8, 14, 6, 1, 111, 27, 0, 111, 12, 0, 1, 9, 6, 29, 2 }, 79));
            this._0x15f02ac4.color = _0x3fe280fb.Rose;
            this._0x2ba79061._0x3a14c276(true);
            DOVirtual.DelayedCall(3f, () => this._0x53bd7c1d()).SetLink(this.gameObject);
            return;
        }

        _0xdfbe9389.WipeAll();
        this._0x15ac6f9f = false;
        _0xaf5af43d.Tick();
        this.Refresh();
        if (this._0xcfac00e6 != null)
        {
            this._0xcfac00e6.Show(_0xf84cb8b0.PageAgeGate);
        }
    }

    private bool _0x15ac6f9f;
    public void _0x6ab07f20(_0xe0927a8a _0x8a62f43c, _0xf84cb8b0 _0xc7379a54, _0x9fb34e44 _0x1bac8299)
    {
        this._0xcfac00e6 = _0xc7379a54;
        RectTransform _0x5e99fe64 = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0x5e99fe64, _0x58786d6c._0x36e14b49(new byte[5] { 184, 159, 133, 131, 149 }, 240), _0x8a62f43c._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0x5e99fe64, _0x58786d6c._0x36e14b49(new byte[4] { 209, 231, 245, 238 }, 134), _0x8a62f43c._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.58f), 0f, 2.0f);
        _0xf84cb8b0.Header(_0x5e99fe64, _0x8a62f43c, _0xc7379a54, _0x58786d6c._0x36e14b49(new byte[8] { 194, 212, 197, 197, 216, 223, 214, 194 }, 145), _0x58786d6c._0x36e14b49(new byte[32] { 23, 4, 23, 0, 11, 114, 0, 29, 5, 114, 26, 23, 0, 23, 114, 17, 26, 19, 28, 21, 23, 1, 114, 1, 29, 31, 23, 6, 26, 27, 28, 21 }, 82));
        string[] _0x98948f43 = new string[]
        {
            _0x58786d6c._0x36e14b49(new byte[7] { 218, 211, 194, 198, 219, 209, 193 }, 146),
            _0x58786d6c._0x36e14b49(new byte[14] { 166, 177, 176, 161, 183, 177, 176, 212, 185, 187, 160, 189, 187, 186 }, 244),
            _0x58786d6c._0x36e14b49(new byte[10] { 211, 212, 198, 193, 181, 199, 208, 208, 217, 198 }, 149)
        };
        for (int _0xe1cb1ea5 = 0; _0xe1cb1ea5 < _0x98948f43.Length; _0xe1cb1ea5++)
        {
            this._0xf186f01f(_0x8a62f43c, _0x1bac8299, _0x5e99fe64, _0xe1cb1ea5, _0x98948f43[_0xe1cb1ea5]);
        }

        this._0xd1b64670(_0x8a62f43c, _0x1bac8299, _0x5e99fe64);
        _0x98589ea5.Label(_0x5e99fe64, _0x58786d6c._0x36e14b49(new byte[12] { 84, 98, 115, 115, 110, 105, 96, 116, 73, 104, 115, 98 }, 7), _0x58786d6c._0x36e14b49(new byte[53] { 70, 85, 66, 67, 89, 95, 94, 48, 81, 94, 84, 48, 92, 85, 87, 81, 92, 48, 89, 94, 86, 95, 48, 81, 66, 85, 48, 67, 88, 95, 71, 94, 26, 89, 94, 48, 68, 88, 85, 48, 67, 68, 95, 66, 85, 48, 92, 89, 67, 68, 89, 94, 87 }, 16), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.BottomCentre, new Vector2(0f, 180f), new Vector2(1060f, 100f));
    }

    public void Refresh()
    {
        bool[] _0x38583dd1 = new bool[]
        {
            _0xdfbe9389._0xa93024f2,
            _0xdfbe9389._0x5fbcf839,
            _0xdfbe9389._0x967a3f5c
        };
        for (int _0xae80d2ce = 0; _0xae80d2ce < this._0x7c02f580.Count && _0xae80d2ce < _0x38583dd1.Length; _0xae80d2ce++)
        {
            bool _0xb1da52ac = _0x38583dd1[_0xae80d2ce];
            this._0xf689459e[_0xae80d2ce].color = _0xb1da52ac ? _0x3fe280fb.Fade(_0x3fe280fb.Gold, 0.85f) : _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.9f);
            this._0xb6b6ef44[_0xae80d2ce].color = _0xb1da52ac ? _0x3fe280fb.GoldLight : _0x3fe280fb.Cream;
            this._0x02fc3aea[_0xae80d2ce]._0x3a14c276(_0xb1da52ac);
            RectTransform _0x3ad4ae15 = (RectTransform)this._0x7c02f580[_0xae80d2ce].transform;
            _0x3ad4ae15.DOKill(false);
            float _0x5209e955 = _0xb1da52ac ? 448f : 352f;
            if (_0xdfbe9389._0x5fbcf839)
            {
                _0x3ad4ae15.anchoredPosition = new Vector2(_0x5209e955, 0f);
            }
            else
            {
                _0x3ad4ae15.DOAnchorPosX(_0x5209e955, 0.18f).SetEase(Ease.OutCubic).SetLink(_0x3ad4ae15.gameObject);
            }
        }

        this._0xd6bd206e();
        this._0x53bd7c1d();
    }

    private void _0x20a9db2d(int _0x7e69797f)
    {
        if (_0x7e69797f == 0)
        {
            _0xdfbe9389._0xa93024f2 = !_0xdfbe9389._0xa93024f2;
            _0xaf5af43d.Tick();
        }
        else if (_0x7e69797f == 1)
        {
            _0xdfbe9389._0x5fbcf839 = !_0xdfbe9389._0x5fbcf839;
        }
        else
        {
            _0xdfbe9389._0x967a3f5c = !_0xdfbe9389._0x967a3f5c;
        }

        this.Refresh();
    }

    private readonly List<Image> _0xf689459e = new List<Image>();
    private string _0x7c49aa61(int _0x2900a8c5)
    {
        switch (_0x2900a8c5)
        {
            case 0:
                return _0x58786d6c._0x36e14b49(new byte[30] { 76, 45, 94, 69, 66, 95, 89, 45, 79, 88, 87, 87, 45, 90, 69, 72, 67, 45, 76, 45, 95, 72, 72, 65, 45, 94, 89, 66, 93, 94 }, 13);
            case 1:
                return _0x58786d6c._0x36e14b49(new byte[22] { 133, 140, 129, 155, 136, 158, 237, 136, 155, 136, 159, 148, 237, 140, 131, 132, 128, 140, 153, 132, 130, 131 }, 205);
            default:
                return _0x58786d6c._0x36e14b49(new byte[28] { 82, 73, 78, 83, 85, 68, 83, 33, 82, 81, 72, 79, 82, 45, 33, 80, 84, 72, 66, 74, 68, 83, 33, 82, 85, 78, 81, 82 }, 1);
        }
    }

    private void _0xd1b64670(_0xe0927a8a _0x256ce806, _0x9fb34e44 _0x8ddbeddb, Transform _0x9fc759c0)
    {
        this._0x2ba79061 = Instantiate(_0x8ddbeddb, _0x9fc759c0, false);
        RectTransform _0xbe3dd41b = this._0x2ba79061._0x7693cccd;
        _0xbe3dd41b.anchorMin = _0x98589ea5.TopCentre;
        _0xbe3dd41b.anchorMax = _0x98589ea5.TopCentre;
        _0xbe3dd41b.anchoredPosition = new Vector2(0f, -1250f);
        this._0x2ba79061._0x0d1f6abd(new Vector2(1080f, 190f));
        this._0x2ba79061._0xf065af12(_0x3fe280fb.BurgundyDeep, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0xde0dd4d3 = this._0x2ba79061._0xf9550e0d;
        _0x98589ea5.Plate(_0xde0dd4d3, _0x58786d6c._0x36e14b49(new byte[3] { 0, 57, 32 }, 80), _0x256ce806._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Rose, 0.85f), _0x98589ea5.Centre, new Vector2(_0x2da34b06.GutterCentre - 540f, 0f), new Vector2(_0x2da34b06.GutterWidth, 60f), 1.0f);
        this._0x15f02ac4 = _0x98589ea5.Label(_0xde0dd4d3, _0x58786d6c._0x36e14b49(new byte[9] { 179, 132, 146, 132, 149, 175, 128, 140, 132 }, 225), _0x58786d6c._0x36e14b49(new byte[14] { 72, 95, 73, 95, 78, 58, 74, 72, 85, 93, 72, 95, 73, 73 }, 26), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(129f + 330f - 540f, 0f), new Vector2(660f, 56f));
        Image _0x33153a1a = _0xde0dd4d3.gameObject.AddComponent<Image>();
        _0x33153a1a.sprite = _0x256ce806._0xfa9196f7;
        _0x33153a1a.type = Image.Type.Sliced;
        _0x33153a1a.pixelsPerUnitMultiplier = 2.2f;
        _0x33153a1a.color = new Color(1f, 1f, 1f, 0f);
        _0x33153a1a.raycastTarget = true;
        Button _0xe96d3942 = _0xde0dd4d3.gameObject.AddComponent<Button>();
        _0xe96d3942.targetGraphic = _0x33153a1a;
        _0xe96d3942.transition = Selectable.Transition.None;
        _0x98589ea5.OnTap(_0xe96d3942, () => this._0xa3dc206a());
    }

    private readonly List<Image> _0x7c02f580 = new List<Image>();
    private _0xf84cb8b0 _0xcfac00e6;
    private void _0x53bd7c1d()
    {
        if (!this._0x15ac6f9f)
        {
            return;
        }

        this._0x15ac6f9f = false;
        _0xd6a1e4cb.SetText(this._0x15f02ac4, _0x58786d6c._0x36e14b49(new byte[14] { 146, 133, 147, 133, 148, 224, 144, 146, 143, 135, 146, 133, 147, 147 }, 192));
        this._0x15f02ac4.color = _0x3fe280fb.Cream;
        this._0x2ba79061._0x3a14c276(false);
    }

    private TextMeshProUGUI _0x15f02ac4;
    private readonly List<Image> _0x2c930af3 = new List<Image>();
    private void _0xd6bd206e()
    {
        float _0x17ef713a = _0xdfbe9389._0x967a3f5c ? 0.12f : 0.25f;
        for (int _0x73d2a406 = 0; _0x73d2a406 < this._0x2c930af3.Count; _0x73d2a406++)
        {
            Image _0x6c45bc9c = this._0x2c930af3[_0x73d2a406];
            _0x6c45bc9c.DOKill(false);
            _0x6c45bc9c.color = _0x3fe280fb.Fade(_0x3fe280fb.Gold, 0.85f);
            if (_0xdfbe9389._0x5fbcf839)
            {
                continue;
            }

            _0x6c45bc9c.DOFade(0.25f, _0x17ef713a * 2f).SetEase(Ease.InOutSine).SetDelay(_0x17ef713a * _0x73d2a406).SetLoops(-1, LoopType.Yoyo).SetLink(_0x6c45bc9c.gameObject);
        }
    }
}

internal static class _0x58786d6c
{
    internal static string _0x36e14b49(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}