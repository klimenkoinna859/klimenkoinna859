using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The game screen's own HUD, built out of this game's own objects - nothing is slipped
/// into a template placeholder, so stage 5da can switch the template's leftovers off
/// without taking any of this with them.
///
/// Back and Pause are authored here rather than reused from TopPanel: on this template
/// family the pipeline switches TopPanel's LEFT_BUTTON and RIGHT_BUTTON off on every
/// run, so content wired onto them would ship invisible. There is exactly one Back and
/// one Pause on this screen.
/// </summary>
public sealed class _0xd7901260 : MonoBehaviour
{
    /// <summary>One pip pops the moment it is earned, so a star is visible on a frame.</summary>
    public void _0x3449bc38(int _0xdad571b9)
    {
        if (_0xdad571b9 >= 0 && _0xdad571b9 < this._0x1e0af8b5.Count)
        {
            this._0x1e0af8b5[_0xdad571b9]._0x131241aa();
        }
    }

    private void _0xb05bf212()
    {
        if (this._0xc02f663f != null)
        {
            this._0xc02f663f();
        }
    }

    private TextMeshProUGUI _0xabea9dfc;
    private void _0x7d9324ce()
    {
        if (this._0x1b1f88e3 != null)
        {
            this._0x1b1f88e3();
        }
    }

    private TextMeshProUGUI _0xe7d26d3a;
    public RectTransform _0xc1ff266a { get; private set; }

    public void Refresh(_0x69cd18a4 _0x85905563, int _0x06fa1ab4)
    {
        _0xd6a1e4cb.SetText(this._0xac57f8eb, _0x2da34b06.Grouped(_0x06fa1ab4));
        _0xd6a1e4cb.SetText(this._0xe0ecc4b7, _0x85905563._0xaad3d859 + _0x71057ba7._0x8af27a84(new byte[3] { 48, 63, 48 }, 16) + _0x2da34b06.ActStarGoal);
        _0xd6a1e4cb.SetText(this._0x966b54dc, _0x85905563._0x4926cdc7 != null ? _0x85905563._0x4926cdc7._0xa70fdacb() : _0x71057ba7._0x8af27a84(new byte[1] { 148 }, 185));
        _0xd6a1e4cb.SetText(this._0xe7d26d3a, _0x71057ba7._0x8af27a84(new byte[6] { 197, 198, 223, 216, 197, 182 }, 150) + _0x85905563._0xd0b03e38 + _0x71057ba7._0x8af27a84(new byte[3] { 84, 91, 84 }, 116) + _0x2da34b06.SpinBudget);
        int _0xad8a0abf = _0xdfbe9389._0x0eb1c673;
        _0xd6a1e4cb.SetText(this._0x9d6080dd, _0x71057ba7._0x8af27a84(new byte[6] { 134, 129, 148, 158, 144, 245 }, 213) + _0xad8a0abf + _0x71057ba7._0x8af27a84(new byte[3] { 98, 111, 98 }, 66) + _0x2da34b06.ActiveLines + _0x71057ba7._0x8af27a84(new byte[6] { 166, 202, 207, 200, 195, 213 }, 134));
        for (int _0x5534a21d = 0; _0x5534a21d < this._0xd4fb4b4b.Count; _0x5534a21d++)
        {
            bool _0x65c43b76 = this._0x7cff1307[_0x5534a21d] == _0xad8a0abf;
            this._0x4fb734e4[_0x5534a21d].color = _0x65c43b76 ? _0x3fe280fb.Gold : _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.75f);
            this._0xeec11c12[_0x5534a21d].color = _0x65c43b76 ? _0x3fe280fb.Cream : _0x3fe280fb.CreamMuted;
            this._0xd4fb4b4b[_0x5534a21d].transform.localScale = _0x65c43b76 ? new Vector3(1.06f, 1.06f, 1f) : Vector3.one;
        }

        for (int _0xa9e0c269 = 0; _0xa9e0c269 < this._0x1e0af8b5.Count; _0xa9e0c269++)
        {
            this._0x1e0af8b5[_0xa9e0c269]._0x68264ad1(_0xa9e0c269 < _0x85905563._0xaad3d859, _0x3fe280fb.Gold);
        }

        bool _0x6a218328 = _0x85905563._0xff83ef8d;
        _0x98589ea5.SetEnabled(this._0x834245d8, this._0x6ce88483, this._0x11a30ec8, _0x6a218328, _0x3fe280fb.Gold, _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.55f), _0x3fe280fb.Cream, _0x3fe280fb.CreamMuted);
        _0xd6a1e4cb.SetText(this._0x11a30ec8, _0x85905563._0xd0b03e38 > 0 ? _0x71057ba7._0x8af27a84(new byte[4] { 231, 228, 253, 250 }, 180) : _0x71057ba7._0x8af27a84(new byte[8] { 201, 203, 220, 168, 199, 222, 205, 218 }, 136));
    }

    private void _0x1623e23e(int _0x98435649)
    {
        if (this._0x6de6b1d0 != null)
        {
            this._0x6de6b1d0(_0x98435649);
        }
    }

    private TextMeshProUGUI _0x9d6080dd;
    private void _0x723833ba(_0xe0927a8a _0xbf31db7c, _0xc5d7f584 _0xdd7029a5, Transform _0x2e8e173d)
    {
        for (int _0x24015bba = 0; _0x24015bba < _0x2da34b06.ActStarGoal; _0x24015bba++)
        {
            _0xc5d7f584 _0xd6665066 = Instantiate(_0xdd7029a5, _0x2e8e173d, false);
            RectTransform _0x735aca57 = (RectTransform)_0xd6665066.transform;
            _0x735aca57.anchorMin = _0x98589ea5.TopCentre;
            _0x735aca57.anchorMax = _0x98589ea5.TopCentre;
            _0x735aca57.sizeDelta = new Vector2(60f, 60f);
            _0x735aca57.anchoredPosition = new Vector2(-565f + 30f + _0x24015bba * 70f, -370f);
            this._0x1e0af8b5.Add(_0xd6665066);
        }

        this._0xe0ecc4b7 = _0x98589ea5.Label(_0x2e8e173d, _0x71057ba7._0x8af27a84(new byte[10] { 32, 8, 25, 8, 31, 46, 2, 24, 3, 25 }, 109), _0x71057ba7._0x8af27a84(new byte[6] { 157, 141, 130, 141, 156, 159 }, 173), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Right, _0x98589ea5.TopCentre, new Vector2(430f, -370f), new Vector2(240f, 66f));
        this._0x966b54dc = _0x98589ea5.Label(_0x2e8e173d, _0x71057ba7._0x8af27a84(new byte[7] { 184, 154, 141, 183, 152, 148, 156 }, 249), _0x71057ba7._0x8af27a84(new byte[1] { 236 }, 193), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Gold, TextAlignmentOptions.Left, _0x98589ea5.TopCentre, new Vector2(-300f, -470f), new Vector2(540f, 54f));
        this._0xe7d26d3a = _0x98589ea5.Label(_0x2e8e173d, _0x71057ba7._0x8af27a84(new byte[10] { 143, 172, 181, 178, 158, 169, 184, 187, 185, 168 }, 220), _0x71057ba7._0x8af27a84(new byte[1] { 175 }, 130), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Right, _0x98589ea5.TopCentre, new Vector2(320f, -470f), new Vector2(500f, 54f));
    }

    public void _0x1ba174cc(int _0x9479aafc, int _0xcda80748, bool _0x0dbceabf)
    {
        if (_0x9479aafc > 0)
        {
            _0xd6a1e4cb.SetText(this._0xabea9dfc, _0x71057ba7._0x8af27a84(new byte[12] { 19, 30, 12, 11, 127, 19, 22, 17, 26, 127, 127, 39 }, 95) + _0xcda80748 + _0x71057ba7._0x8af27a84(new byte[3] { 141, 141, 134 }, 173) + _0x2da34b06.Grouped(_0x9479aafc));
            this._0xabea9dfc.color = _0x3fe280fb.GoldLight;
        }
        else
        {
            _0xd6a1e4cb.SetText(this._0xabea9dfc, _0x71057ba7._0x8af27a84(new byte[7] { 64, 65, 46, 66, 71, 64, 75 }, 14));
            this._0xabea9dfc.color = _0x3fe280fb.CreamMuted;
        }

        if (!_0x0dbceabf)
        {
            _0xd6a1e4cb.SetText(this._0xb1057fb0, string.Empty);
            return;
        }

        _0xd6a1e4cb.SetText(this._0xb1057fb0, _0x71057ba7._0x8af27a84(new byte[21] { 113, 109, 96, 5, 109, 106, 112, 118, 96, 5, 113, 106, 117, 118, 5, 124, 106, 112, 5, 112, 117 }, 37));
        this._0xb1057fb0.color = _0x3fe280fb.GoldLight;
        DOVirtual.DelayedCall(2f, () => this._0x93a73ba8()).SetLink(this.gameObject);
    }

    /// <summary>Scenes are addressed by index, never by name (§C.1).</summary>
    private void _0xe26f794d()
    {
        if (_0x44f9825a.Instance != null)
        {
            _0x44f9825a.Instance._0x0e9ebb6d(_0xdfe619ff._0x2cdb8663.SCENE_0);
        }
    }

    public void _0x2291d38d(int _0x4c330c23, int _0x1cb23a89)
    {
        _0x98589ea5.CountTo(this._0xac57f8eb, _0x4c330c23, _0x1cb23a89, string.Empty);
    }

    private readonly List<_0xc5d7f584> _0x1e0af8b5 = new List<_0xc5d7f584>();
    private TextMeshProUGUI _0xe0ecc4b7;
    private Button _0x834245d8;
    private readonly List<Image> _0x4fb734e4 = new List<Image>();
    private void _0x93a73ba8()
    {
        _0xd6a1e4cb.SetText(this._0xb1057fb0, string.Empty);
    }

    private readonly int[] _0x7cff1307 = new int[]
    {
        10,
        25,
        50
    };
    private Action _0xc02f663f;
    private void _0x1d906f8c(_0xe0927a8a _0xa0d67d68, Transform _0xe88d9fa4)
    {
        _0x98589ea5.Plate(_0xe88d9fa4, _0x71057ba7._0x8af27a84(new byte[6] { 242, 201, 214, 228, 199, 212 }, 166), _0xa0d67d68._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Burgundy, 0.92f), _0x98589ea5.TopCentre, new Vector2(0f, -150f), new Vector2(1180f, 180f), 2.2f);
        _0x98589ea5.Plate(_0xe88d9fa4, _0x71057ba7._0x8af27a84(new byte[9] { 172, 151, 136, 186, 153, 138, 170, 145, 149 }, 248), _0xa0d67d68._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.55f), _0x98589ea5.TopCentre, new Vector2(0f, -240f), new Vector2(1180f, 4f), 1.0f);
        Button _0x3068cd8b = _0x98589ea5.IconButton(_0xe88d9fa4, _0x71057ba7._0x8af27a84(new byte[11] { 173, 142, 140, 132, 187, 128, 163, 128, 141, 141, 150 }, 239), _0xa0d67d68._0xb1d3c259, _0xa0d67d68._0x58e49a6e, _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.95f), _0x3fe280fb.GoldLight, _0x98589ea5.TopCentre, new Vector2(-470f, -150f), 120f, 1.1f);
        _0x98589ea5.OnTap(_0x3068cd8b, () => this._0xe26f794d());
        _0x98589ea5.Picture(_0xe88d9fa4, _0x71057ba7._0x8af27a84(new byte[10] { 119, 70, 81, 80, 93, 64, 119, 92, 93, 68 }, 52), _0xa0d67d68._0x294d71d8(0), _0x3fe280fb.GoldLight, _0x98589ea5.TopCentre, new Vector2(-110f, -150f), new Vector2(72f, 72f));
        this._0xac57f8eb = _0x98589ea5.Label(_0xe88d9fa4, _0x71057ba7._0x8af27a84(new byte[11] { 162, 147, 132, 133, 136, 149, 183, 128, 141, 148, 132 }, 225), _0x71057ba7._0x8af27a84(new byte[1] { 170 }, 154), _0x2da34b06.NumberMax, _0x2da34b06.NumberMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Left, _0x98589ea5.TopCentre, new Vector2(40f, -150f), new Vector2(320f, 84f));
        this._0xb1057fb0 = _0x98589ea5.Label(_0xe88d9fa4, _0x71057ba7._0x8af27a84(new byte[9] { 40, 29, 14, 1, 27, 33, 0, 27, 10 }, 111), string.Empty, _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, -272f), new Vector2(900f, 46f));
        Button _0x8469f90d = _0x98589ea5.IconButton(_0xe88d9fa4, _0x71057ba7._0x8af27a84(new byte[8] { 76, 125, 105, 111, 121, 93, 127, 104 }, 28), _0xa0d67d68._0xb1d3c259, _0xa0d67d68._0x1d92e735, _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.95f), _0x3fe280fb.GoldLight, _0x98589ea5.TopCentre, new Vector2(470f, -150f), 120f, 1.1f);
        _0x98589ea5.OnTap(_0x8469f90d, () => this._0xb05bf212());
    }

    private TMP_Text _0x11a30ec8;
    private readonly List<Button> _0xd4fb4b4b = new List<Button>();
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private Action _0x1b1f88e3;
    private readonly List<TMP_Text> _0xeec11c12 = new List<TMP_Text>();
    private TextMeshProUGUI _0xb1057fb0;
    public void _0x11420b04(_0xe0927a8a _0x2c52ad2b, _0xc5d7f584 _0xc3b2a49f, Action _0x29fb6fbd, Action _0xdd1dddfc, Action<int> _0x4543f7f9)
    {
        this._0x1b1f88e3 = _0x29fb6fbd;
        this._0xc02f663f = _0xdd1dddfc;
        this._0x6de6b1d0 = _0x4543f7f9;
        RectTransform _0xd8e70e07 = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0xd8e70e07, _0x71057ba7._0x8af27a84(new byte[5] { 157, 186, 160, 166, 176 }, 213), _0x2c52ad2b._0x64866bec, Color.white);
        _0x98589ea5.PlateFull(_0xd8e70e07, _0x71057ba7._0x8af27a84(new byte[9] { 52, 19, 9, 15, 25, 43, 29, 15, 20 }, 124), _0x2c52ad2b._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.30f), 0f, 2.0f);
        _0x98589ea5.Plate(_0xd8e70e07, _0x71057ba7._0x8af27a84(new byte[9] { 53, 3, 16, 1, 20, 61, 20, 23, 5 }, 113), _0x2c52ad2b._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.BurgundyDeep, 0.55f), new Vector2(0f, 0.5f), new Vector2(90f, 0f), new Vector2(180f, 2688f), 2.0f);
        _0x98589ea5.Plate(_0xd8e70e07, _0x71057ba7._0x8af27a84(new byte[10] { 74, 124, 111, 126, 107, 92, 103, 105, 102, 122 }, 14), _0x2c52ad2b._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.BurgundyDeep, 0.55f), new Vector2(1f, 0.5f), new Vector2(-90f, 0f), new Vector2(180f, 2688f), 2.0f);
        this._0x1d906f8c(_0x2c52ad2b, _0xd8e70e07);
        this._0x723833ba(_0x2c52ad2b, _0xc3b2a49f, _0xd8e70e07);
        this._0xc1ff266a = _0x98589ea5.Node(_0xd8e70e07, _0x71057ba7._0x8af27a84(new byte[9] { 190, 137, 137, 128, 174, 131, 141, 158, 136 }, 236), new Vector2(0.5f, 0.58f), Vector2.zero, new Vector2(_0x2da34b06.BoardSize, _0x2da34b06.BoardSize));
        this._0x2700582e(_0x2c52ad2b, _0xd8e70e07);
    }

    private TextMeshProUGUI _0xac57f8eb;
    private Image _0x6ce88483;
    private Action<int> _0x6de6b1d0;
    private TextMeshProUGUI _0x966b54dc;
    private void _0x2700582e(_0xe0927a8a _0x6d944f0c, Transform _0xe6c6ee9b)
    {
        _0x98589ea5.Plate(_0xe6c6ee9b, _0x71057ba7._0x8af27a84(new byte[13] { 155, 183, 182, 172, 170, 183, 180, 171, 139, 176, 189, 189, 172 }, 216), _0x6d944f0c._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Burgundy, 0.95f), _0x98589ea5.BottomCentre, new Vector2(0f, 494f), new Vector2(1242f, 988f), 2.2f);
        _0x98589ea5.Plate(_0xe6c6ee9b, _0x71057ba7._0x8af27a84(new byte[11] { 11, 39, 38, 60, 58, 39, 36, 59, 26, 33, 37 }, 72), _0x6d944f0c._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.55f), _0x98589ea5.BottomCentre, new Vector2(0f, 986f), new Vector2(1242f, 4f), 1.0f);
        for (int _0x0b07b2c2 = 0; _0x0b07b2c2 < this._0x7cff1307.Length; _0x0b07b2c2++)
        {
            Button _0x839755ff = _0x98589ea5.Cta(_0xe6c6ee9b, _0x71057ba7._0x8af27a84(new byte[5] { 89, 126, 107, 97, 111 }, 10), this._0x7cff1307[_0x0b07b2c2].ToString(), _0x6d944f0c._0x24421334, null, _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.75f), _0x3fe280fb.CreamMuted, _0x98589ea5.BottomCentre, new Vector2((_0x0b07b2c2 - 1) * 280f, 760f), new Vector2(240f, 110f), 1.6f);
            int _0xe3a11cb1 = this._0x7cff1307[_0x0b07b2c2];
            _0x98589ea5.OnTap(_0x839755ff, () => this._0x1623e23e(_0xe3a11cb1));
            this._0xd4fb4b4b.Add(_0x839755ff);
            this._0x4fb734e4.Add(_0x839755ff.GetComponent<Image>());
            this._0xeec11c12.Add(_0x839755ff.GetComponentInChildren<TMP_Text>(true));
        }

        this._0x9d6080dd = _0x98589ea5.Label(_0xe6c6ee9b, _0x71057ba7._0x8af27a84(new byte[12] { 81, 118, 99, 105, 103, 65, 99, 114, 118, 107, 109, 108 }, 2), _0x71057ba7._0x8af27a84(new byte[1] { 48 }, 29), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.BottomCentre, new Vector2(0f, 660f), new Vector2(1060f, 48f));
        this._0xabea9dfc = _0x98589ea5.Label(_0xe6c6ee9b, _0x71057ba7._0x8af27a84(new byte[7] { 182, 155, 137, 142, 173, 147, 148 }, 250), _0x71057ba7._0x8af27a84(new byte[7] { 60, 61, 82, 62, 59, 60, 55 }, 114), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.BottomCentre, new Vector2(0f, 540f), new Vector2(1100f, 70f));
        this._0x834245d8 = _0x98589ea5.Cta(_0xe6c6ee9b, _0x71057ba7._0x8af27a84(new byte[4] { 197, 230, 255, 248 }, 150), _0x71057ba7._0x8af27a84(new byte[4] { 165, 166, 191, 184 }, 246), _0x6d944f0c._0x24421334, _0x6d944f0c._0x294d71d8(4), _0x3fe280fb.Gold, _0x3fe280fb.Cream, _0x98589ea5.BottomCentre, new Vector2(0f, 309f), new Vector2(720f, 180f), 1.6f);
        this._0x6ce88483 = this._0x834245d8.GetComponent<Image>();
        this._0x11a30ec8 = this._0x834245d8.GetComponentInChildren<TMP_Text>(true);
        _0x98589ea5.OnTap(this._0x834245d8, () => this._0x7d9324ce());
        _0x98589ea5.Label(_0xe6c6ee9b, _0x71057ba7._0x8af27a84(new byte[8] { 252, 223, 198, 193, 231, 198, 193, 219 }, 175), _0x71057ba7._0x8af27a84(new byte[19] { 125, 104, 121, 9, 122, 121, 96, 103, 9, 125, 102, 9, 121, 108, 123, 111, 102, 123, 100 }, 41), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.BottomCentre, new Vector2(0f, 108f), new Vector2(1060f, 48f));
    }
}

internal static class _0x71057ba7
{
    internal static string _0x8af27a84(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}