using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The cabinet. Built strictly backdrop -> frame -> window/content -> payline overlay:
/// uGUI draws later siblings on top, so a frame added last would cover every symbol it
/// is supposed to frame (§C.13/§C.63). The frame here is four brass bars with nothing
/// in the middle, which cannot hide content even if the order were ever disturbed.
/// </summary>
public sealed class _0xa8c064dc : MonoBehaviour
{
    private int _0x64ffe7a0;
    private _0xe0927a8a _0x22fd3097;
    private RectTransform _0x7f827c6f;
    private void _0xc3b4d548(RectTransform _0x064408a2, Vector2 _0x5a972336, Vector2 _0x175cee70)
    {
        if (_0x064408a2 == null)
        {
            return;
        }

        Vector2 _0xcbf0f7f8 = _0x175cee70 - _0x5a972336;
        _0x064408a2.anchoredPosition = _0x5a972336 + _0xcbf0f7f8 * 0.5f;
        _0x064408a2.sizeDelta = new Vector2(_0xcbf0f7f8.magnitude, 12f);
        _0x064408a2.localRotation = Quaternion.Euler(0f, 0f, Mathf.Atan2(_0xcbf0f7f8.y, _0xcbf0f7f8.x) * Mathf.Rad2Deg);
    }

    public void _0xc830b945(_0xe0927a8a _0x2b2dd152, _0xec8f07c1 _0xc1bfb719)
    {
        this._0x22fd3097 = _0x2b2dd152;
        RectTransform _0x034bcfbd = (RectTransform)this.transform;
        float _0x89b1cb52 = _0x2da34b06.CellSize + _0x2da34b06.CellGap;
        _0x98589ea5.Plate(_0x034bcfbd, _0xd09e91aa._0x120d39c9(new byte[12] { 139, 188, 188, 181, 155, 184, 186, 178, 189, 171, 182, 169 }, 217), _0x2b2dd152._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.96f), _0x98589ea5.Centre, Vector2.zero, new Vector2(1104f, 1104f), 2.0f);
        _0x98589ea5.Plate(_0x034bcfbd, _0xd09e91aa._0x120d39c9(new byte[10] { 243, 196, 196, 205, 247, 196, 205, 215, 196, 213 }, 161), _0x2b2dd152._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.BurgundyDeep, 0.45f), _0x98589ea5.Centre, Vector2.zero, new Vector2(1048f, 1048f), 2.2f);
        // The frame: four bars and four corner studs, drawn BEFORE the window.
        RectTransform _0x6782bc72 = _0x98589ea5.Node(_0x034bcfbd, _0xd09e91aa._0x120d39c9(new byte[9] { 75, 124, 124, 117, 95, 107, 120, 116, 124 }, 25), _0x98589ea5.Centre, Vector2.zero, new Vector2(1080f, 1080f));
        _0x98589ea5.Plate(_0x6782bc72, _0xd09e91aa._0x120d39c9(new byte[8] { 183, 131, 144, 156, 148, 165, 158, 129 }, 241), _0x2b2dd152._0xfa9196f7, _0x3fe280fb.Brass, _0x98589ea5.Centre, new Vector2(0f, 530f), new Vector2(1080f, 20f), 1.2f);
        _0x98589ea5.Plate(_0x6782bc72, _0xd09e91aa._0x120d39c9(new byte[11] { 247, 195, 208, 220, 212, 243, 222, 197, 197, 222, 220 }, 177), _0x2b2dd152._0xfa9196f7, _0x3fe280fb.Brass, _0x98589ea5.Centre, new Vector2(0f, -530f), new Vector2(1080f, 20f), 1.2f);
        _0x98589ea5.Plate(_0x6782bc72, _0xd09e91aa._0x120d39c9(new byte[9] { 255, 203, 216, 212, 220, 245, 220, 223, 205 }, 185), _0x2b2dd152._0xfa9196f7, _0x3fe280fb.Brass, _0x98589ea5.Centre, new Vector2(-530f, 0f), new Vector2(20f, 1080f), 1.2f);
        _0x98589ea5.Plate(_0x6782bc72, _0xd09e91aa._0x120d39c9(new byte[10] { 241, 197, 214, 218, 210, 229, 222, 208, 223, 195 }, 183), _0x2b2dd152._0xfa9196f7, _0x3fe280fb.Brass, _0x98589ea5.Centre, new Vector2(530f, 0f), new Vector2(20f, 1080f), 1.2f);
        for (int _0xc4ed38bd = 0; _0xc4ed38bd < 4; _0xc4ed38bd++)
        {
            float _0x1392f32c = (_0xc4ed38bd % 2 == 0 ? -1f : 1f) * 530f;
            float _0x9d0d0efa = (_0xc4ed38bd < 2 ? 1f : -1f) * 530f;
            _0x98589ea5.Plate(_0x6782bc72, _0xd09e91aa._0x120d39c9(new byte[9] { 153, 173, 190, 178, 186, 140, 171, 170, 187 }, 223), _0x2b2dd152._0xb1d3c259, _0x3fe280fb.Gold, _0x98589ea5.Centre, new Vector2(_0x1392f32c, _0x9d0d0efa), new Vector2(54f, 54f), 1.0f);
        }

        this._0x7f827c6f = _0x98589ea5.Node(_0x034bcfbd, _0xd09e91aa._0x120d39c9(new byte[10] { 229, 210, 210, 219, 224, 222, 217, 211, 216, 192 }, 183), _0x98589ea5.Centre, Vector2.zero, new Vector2(_0x2da34b06.BoardWindow, _0x2da34b06.BoardWindow));
        this._0x7f827c6f.gameObject.AddComponent<RectMask2D>();
        for (int _0x522d988e = 0; _0x522d988e < _0x2da34b06.ReelColumns; _0x522d988e++)
        {
            RectTransform _0x6b82c749 = _0x98589ea5.Node(this._0x7f827c6f, _0xd09e91aa._0x120d39c9(new byte[6] { 19, 63, 60, 37, 61, 62 }, 80), _0x98589ea5.Centre, new Vector2((_0x522d988e - 1) * _0x89b1cb52, 0f), new Vector2(_0x2da34b06.CellSize, _0x2da34b06.BoardWindow));
            _0x833f2fce _0x86a3ceee = _0x6b82c749.gameObject.AddComponent<_0x833f2fce>();
            _0x86a3ceee._0xa87c7a80(_0x2b2dd152, _0xc1bfb719, _0x2da34b06.CellSize, _0x89b1cb52);
            this._0x2ecae24e.Add(_0x86a3ceee);
        }

        this._0x8ab41b92 = _0x98589ea5.Node(_0x034bcfbd, _0xd09e91aa._0x120d39c9(new byte[14] { 46, 31, 7, 18, 23, 16, 27, 49, 8, 27, 12, 18, 31, 7 }, 126), _0x98589ea5.Centre, Vector2.zero, new Vector2(_0x2da34b06.BoardWindow, _0x2da34b06.BoardWindow));
        for (int _0xd53762c9 = 0; _0xd53762c9 < _0x2da34b06.ActiveLines; _0xd53762c9++)
        {
            RectTransform _0xfc2a06f2 = _0x98589ea5.Node(this._0x8ab41b92, _0xd09e91aa._0x120d39c9(new byte[7] { 18, 35, 59, 46, 43, 44, 39 }, 66), _0x98589ea5.Centre, Vector2.zero, new Vector2(_0x2da34b06.BoardWindow, _0x2da34b06.BoardWindow));
            Image _0x566e4aac = _0x98589ea5.Plate(_0xfc2a06f2, _0xd09e91aa._0x120d39c9(new byte[8] { 138, 188, 190, 180, 188, 183, 173, 152 }, 217), _0x2b2dd152._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.GoldLight, 0f), _0x98589ea5.Centre, Vector2.zero, new Vector2(10f, 10f), 1.0f);
            _0x98589ea5.Plate(_0xfc2a06f2, _0xd09e91aa._0x120d39c9(new byte[8] { 212, 226, 224, 234, 226, 233, 243, 197 }, 135), _0x2b2dd152._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.GoldLight, 0f), _0x98589ea5.Centre, Vector2.zero, new Vector2(10f, 10f), 1.0f);
            this._0x5a9507cf.Add(_0xfc2a06f2);
            this._0x7d655deb.Add(_0x566e4aac);
        }
    }

    /// <summary>A payout label rises off the board and fades, so a win is unmissable.</summary>
    public void _0x4be872c2(int _0x95943e37)
    {
        if (this._0x8ab41b92 == null)
        {
            return;
        }

        TextMeshProUGUI _0xc60a487b = _0x98589ea5.Label(this._0x8ab41b92, _0xd09e91aa._0x120d39c9(new byte[6] { 205, 252, 228, 242, 232, 233 }, 157), _0xd09e91aa._0x120d39c9(new byte[1] { 227 }, 200) + _0x2da34b06.Grouped(_0x95943e37), _0x2da34b06.NumberMax, _0x2da34b06.NumberMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, 0f), new Vector2(700f, 96f));
        RectTransform _0x92cf0202 = (RectTransform)_0xc60a487b.transform;
        if (_0xdfbe9389._0x5fbcf839)
        {
            DOVirtual.DelayedCall(0.8f, () => this._0xf695ab41(_0xc60a487b)).SetLink(this.gameObject);
            return;
        }

        _0x92cf0202.DOAnchorPosY(90f, 0.8f).SetEase(Ease.OutCubic).SetLink(_0x92cf0202.gameObject);
        _0xc60a487b.DOFade(0f, 0.8f).SetEase(Ease.InQuad).OnComplete(() => this._0xf695ab41(_0xc60a487b)).SetLink(_0xc60a487b.gameObject);
    }

    private readonly List<RectTransform> _0x5a9507cf = new List<RectTransform>();
    private void OnDestroy()
    {
        for (int _0x44e7ece6 = 0; _0x44e7ece6 < this._0x7d655deb.Count; _0x44e7ece6++)
        {
            if (this._0x7d655deb[_0x44e7ece6] != null)
            {
                DOTween.Kill(this._0x7d655deb[_0x44e7ece6]);
            }
        }
    }

    private RectTransform _0x8ab41b92;
    /// <summary>
    /// Rolls all three columns, staggered, and calls back once the last one lands.
    /// </summary>
    public void _0x90eb307d(_0xfe7794e1 _0x163cd1bd, int[] _0x88152b29, int[] _0xd8e42bba, float _0xabf2de57, float _0xf61aedfc, Action _0xbea148c8)
    {
        this._0xc45f82dd();
        this._0x64ffe7a0 = 0;
        this._0x6a5fe84f = _0xbea148c8;
        for (int _0x7d74ee50 = 0; _0x7d74ee50 < this._0x2ecae24e.Count; _0x7d74ee50++)
        {
            int[] _0x42cec3a5 = new int[3];
            for (int _0xc3f63259 = 0; _0xc3f63259 < 3; _0xc3f63259++)
            {
                _0x42cec3a5[_0xc3f63259] = _0xd8e42bba[_0xc3f63259 * _0x2da34b06.ReelColumns + _0x7d74ee50];
            }

            float _0x3a2fa4fb = _0xabf2de57 + _0x7d74ee50 * _0xf61aedfc;
            this._0x2ecae24e[_0x7d74ee50]._0xba1bc253(_0x163cd1bd._0x48ee6665[_0x7d74ee50], _0x88152b29[_0x7d74ee50], _0x42cec3a5, _0x3a2fa4fb, () => this._0x804afb4c());
        }
    }

    private Action _0x6a5fe84f;
    /// <summary>
    /// Lights the lines that paid: the matched cells punch, and a gold bar is drawn
    /// from cell centre to cell centre so a V or a diagonal reads as one line.
    /// </summary>
    public void _0xefdb20df(int[] _0x28bc400a, int[] _0xcad5990b)
    {
        int _0x9e53ca61 = 0;
        for (int _0xaab4fd32 = 0; _0xaab4fd32 < _0x28bc400a.Length && _0xaab4fd32 < this._0x5a9507cf.Count; _0xaab4fd32++)
        {
            if (_0xcad5990b[_0xaab4fd32] <= 0)
            {
                continue;
            }

            int[] _0xbd21a114 = _0x89690aec.LineRows(_0x28bc400a[_0xaab4fd32]);
            for (int _0x3d2c7e2d = 0; _0x3d2c7e2d < _0x2da34b06.ReelColumns; _0x3d2c7e2d++)
            {
                this._0x2ecae24e[_0x3d2c7e2d]._0x5ad7d907(_0xbd21a114[_0x3d2c7e2d])._0x8c5ddc14();
            }

            RectTransform _0x9ebf45c1 = this._0x5a9507cf[_0x9e53ca61];
            _0x9ebf45c1.gameObject.SetActive(true);
            this._0xc3b4d548(_0x9ebf45c1.GetChild(0) as RectTransform, this._0x30f3c682(0, _0xbd21a114[0]), this._0x30f3c682(1, _0xbd21a114[1]));
            this._0xc3b4d548(_0x9ebf45c1.GetChild(1) as RectTransform, this._0x30f3c682(1, _0xbd21a114[1]), this._0x30f3c682(2, _0xbd21a114[2]));
            this._0x445b387a(_0x9ebf45c1);
            _0x9e53ca61++;
        }
    }

    private void _0xf695ab41(TextMeshProUGUI _0xc32f3a35)
    {
        if (_0xc32f3a35 != null)
        {
            Destroy(_0xc32f3a35.gameObject);
        }
    }

    private void _0x445b387a(RectTransform _0xc2446d92)
    {
        for (int _0x9fc1a24e = 0; _0x9fc1a24e < _0xc2446d92.childCount; _0x9fc1a24e++)
        {
            Image _0x8d2f34e7 = _0xc2446d92.GetChild(_0x9fc1a24e).GetComponent<Image>();
            if (_0x8d2f34e7 == null)
            {
                continue;
            }

            _0x8d2f34e7.DOKill(false);
            _0x8d2f34e7.color = _0x3fe280fb.Fade(_0x3fe280fb.GoldLight, _0xdfbe9389._0x5fbcf839 ? 0.9f : 0f);
            if (_0xdfbe9389._0x5fbcf839)
            {
                continue;
            }

            _0x8d2f34e7.DOFade(0.95f, 0.45f).SetEase(Ease.OutQuad).SetLoops(2, LoopType.Yoyo).SetLink(_0x8d2f34e7.gameObject);
        }
    }

    private void _0x804afb4c()
    {
        _0xaf5af43d.Tick();
        this._0x64ffe7a0++;
        if (this._0x64ffe7a0 < this._0x2ecae24e.Count)
        {
            return;
        }

        Action _0xaaf5cb92 = this._0x6a5fe84f;
        this._0x6a5fe84f = null;
        if (_0xaaf5cb92 != null)
        {
            _0xaaf5cb92();
        }
    }

    private readonly List<_0x833f2fce> _0x2ecae24e = new List<_0x833f2fce>();
    public void _0xc45f82dd()
    {
        for (int _0xeca96714 = 0; _0xeca96714 < this._0x5a9507cf.Count; _0xeca96714++)
        {
            this._0x5a9507cf[_0xeca96714].gameObject.SetActive(false);
        }

        for (int _0x4e29fb44 = 0; _0x4e29fb44 < this._0x2ecae24e.Count; _0x4e29fb44++)
        {
            this._0x2ecae24e[_0x4e29fb44]._0xac3d1e20();
        }
    }

    private readonly List<Image> _0x7d655deb = new List<Image>();
    /// <summary>Cell centre in window space: column pitch across, row pitch down.</summary>
    private Vector2 _0x30f3c682(int _0xff9eda0e, int _0x99e9f33c)
    {
        float _0x017f1a2d = _0x2da34b06.CellSize + _0x2da34b06.CellGap;
        return new Vector2((_0xff9eda0e - 1) * _0x017f1a2d, (1 - _0x99e9f33c) * _0x017f1a2d);
    }

    public void _0x41efe262(int[] _0xea5a7be4)
    {
        for (int _0xf2e56a6a = 0; _0xf2e56a6a < this._0x2ecae24e.Count; _0xf2e56a6a++)
        {
            int[] _0x7ee483af = new int[3];
            for (int _0x65277ba0 = 0; _0x65277ba0 < 3; _0x65277ba0++)
            {
                _0x7ee483af[_0x65277ba0] = _0xea5a7be4[_0x65277ba0 * _0x2da34b06.ReelColumns + _0xf2e56a6a];
            }

            this._0x2ecae24e[_0xf2e56a6a]._0xa4fb488d(_0x7ee483af);
            this._0x2ecae24e[_0xf2e56a6a]._0xce21bddf(_0xf2e56a6a * 0.2f);
        }
    }
}

internal static class _0xd09e91aa
{
    internal static string _0x120d39c9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}