using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// One reel. The column holds a strip of twelve cells and rolls by moving the strip
/// nine pitches upward: the three cells that end up in the window were already dressed
/// with the landed symbols, so the reel never snaps or flickers at the stop.
/// </summary>
public sealed class _0x833f2fce : MonoBehaviour
{
    public void _0xce21bddf(float _0xac458578)
    {
        for (int _0x056952ab = 0; _0x056952ab < 3; _0x056952ab++)
        {
            this._0xabd3cfa7[_0x056952ab]._0x4af8c0c5(_0xac458578 + _0x056952ab * 0.12f);
        }
    }

    private float _0x40f7d692;
    /// <summary>The three cells currently in the window, top row first.</summary>
    public _0xec8f07c1 _0x5ad7d907(int _0x18018911)
    {
        return _0x18018911 >= 0 && _0x18018911 < 3 ? this._0xabd3cfa7[_0x18018911] : this._0xabd3cfa7[0];
    }

    /// <summary>Dresses the window without any motion - used for the opening board.</summary>
    public void _0xa4fb488d(int[] _0xfc77b71a)
    {
        for (int _0xc6531a10 = 0; _0xc6531a10 < 3 && _0xc6531a10 < _0xfc77b71a.Length; _0xc6531a10++)
        {
            this._0xabd3cfa7[_0xc6531a10]._0xd0d7d76a(_0xfc77b71a[_0xc6531a10], this._0xa38fb6c8._0x294d71d8(_0xfc77b71a[_0xc6531a10]));
        }

        for (int _0xc360bf61 = 3; _0xc360bf61 < this._0xabd3cfa7.Count; _0xc360bf61++)
        {
            int _0xd18a7597 = _0xfc77b71a[_0xc360bf61 % _0xfc77b71a.Length];
            this._0xabd3cfa7[_0xc360bf61]._0xd0d7d76a(_0xd18a7597, this._0xa38fb6c8._0x294d71d8(_0xd18a7597));
        }
    }

    private readonly List<_0xec8f07c1> _0xabd3cfa7 = new List<_0xec8f07c1>();
    private const int StripCells = 12;
    private Action _0x2fc4c0a6;
    private void _0x1bd05780(int[] _0x08378417)
    {
        for (int _0xdfc180bb = 0; _0xdfc180bb < 3; _0xdfc180bb++)
        {
            this._0xabd3cfa7[_0xdfc180bb]._0xd0d7d76a(_0x08378417[_0xdfc180bb], this._0xa38fb6c8._0x294d71d8(_0x08378417[_0xdfc180bb]));
        }

        this._0xc2530a3e.anchoredPosition = Vector2.zero;
        Action _0x70f58a1d = this._0x2fc4c0a6;
        this._0x2fc4c0a6 = null;
        if (_0x70f58a1d != null)
        {
            _0x70f58a1d();
        }
    }

    public void _0xac3d1e20()
    {
        for (int _0x1f55ba6a = 0; _0x1f55ba6a < 3; _0x1f55ba6a++)
        {
            this._0xabd3cfa7[_0x1f55ba6a]._0x2c28cfaf(false);
        }
    }

    private _0xe0927a8a _0xa38fb6c8;
    public void _0xa87c7a80(_0xe0927a8a _0x57dc9cea, _0xec8f07c1 _0x8da40f1a, float _0xe8053bcd, float _0x7c8e3a7b)
    {
        this._0xa38fb6c8 = _0x57dc9cea;
        this._0x40f7d692 = _0x7c8e3a7b;
        this._0xc2530a3e = _0x98589ea5.Node(this.transform, _0xcf85f6d3._0x4b1496c9(new byte[5] { 178, 149, 147, 136, 145 }, 225), _0x98589ea5.TopCentre, Vector2.zero, new Vector2(_0xe8053bcd, _0x7c8e3a7b * StripCells));
        this._0xc2530a3e.pivot = new Vector2(0.5f, 1f);
        for (int _0xe8013676 = 0; _0xe8013676 < StripCells; _0xe8013676++)
        {
            _0xec8f07c1 _0x021ef275 = Instantiate(_0x8da40f1a, this._0xc2530a3e, false);
            RectTransform _0x06894c63 = (RectTransform)_0x021ef275.transform;
            _0x06894c63.anchorMin = _0x98589ea5.TopCentre;
            _0x06894c63.anchorMax = _0x98589ea5.TopCentre;
            _0x06894c63.pivot = _0x98589ea5.Centre;
            _0x06894c63.sizeDelta = new Vector2(_0xe8053bcd, _0xe8053bcd);
            _0x06894c63.anchoredPosition = new Vector2(0f, -_0x7c8e3a7b * 0.5f - _0xe8013676 * _0x7c8e3a7b);
            this._0xabd3cfa7.Add(_0x021ef275);
        }
    }

    private void _0xccca3f49(int[] _0xc93b4226, float _0x382af899)
    {
        this._0xc2530a3e.DOAnchorPosY(this._0x40f7d692 * RollCells, _0x382af899 * 0.14f).SetEase(Ease.OutBack).OnComplete(() => this._0x1bd05780(_0xc93b4226)).SetLink(this._0xc2530a3e.gameObject);
    }

    /// <summary>
    /// Rolls to a landing. `landed` is the three symbols the window must show when the
    /// column stops; everything above them is filler drawn from the same strip.
    /// </summary>
    public void _0xba1bc253(int[] _0x10fce89a, int _0xc89ab2ca, int[] _0x0f2481e0, float _0x781120d3, Action _0x7e8594e0)
    {
        this._0x2fc4c0a6 = _0x7e8594e0;
        for (int _0x18786852 = 0; _0x18786852 < RollCells; _0x18786852++)
        {
            int _0x7156ab4a = _0x10fce89a[(_0xc89ab2ca + _0x18786852 * 2 + 5) % _0x10fce89a.Length];
            this._0xabd3cfa7[_0x18786852]._0xd0d7d76a(_0x7156ab4a, this._0xa38fb6c8._0x294d71d8(_0x7156ab4a));
        }

        for (int _0xc8df0216 = 0; _0xc8df0216 < 3; _0xc8df0216++)
        {
            int _0x40e831a6 = _0x0f2481e0[_0xc8df0216];
            this._0xabd3cfa7[RollCells + _0xc8df0216]._0xd0d7d76a(_0x40e831a6, this._0xa38fb6c8._0x294d71d8(_0x40e831a6));
        }

        this._0xc2530a3e.DOKill(false);
        this._0xc2530a3e.anchoredPosition = Vector2.zero;
        if (_0xdfbe9389._0x5fbcf839)
        {
            this._0x1bd05780(_0x0f2481e0);
            return;
        }

        this._0xc2530a3e.DOAnchorPosY(this._0x40f7d692 * RollCells + 26f, _0x781120d3 * 0.86f).SetEase(Ease.InOutQuad).OnComplete(() => this._0xccca3f49(_0x0f2481e0, _0x781120d3)).SetLink(this._0xc2530a3e.gameObject);
    }

    private RectTransform _0xc2530a3e;
    private void OnDestroy()
    {
        if (this._0xc2530a3e != null)
        {
            DOTween.Kill(this._0xc2530a3e);
        }
    }

    private const int RollCells = 9;
}

internal static class _0xcf85f6d3
{
    internal static string _0x4b1496c9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}