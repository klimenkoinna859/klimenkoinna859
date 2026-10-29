using System;
using UnityEngine;

/// <summary>
/// The balance of complimentary credits. They can never be bought, cashed out or
/// traded; if the balance would fall below the stake the house tops it up for free,
/// so the game can never reach a dead end and nothing is ever purchasable.
/// </summary>
public sealed class _0x236224c8 : MonoBehaviour
{
    public int _0x40983f27
    {
        get
        {
            return _0xdfbe9389._0x0eb1c673;
        }
    }

    public int _0xe74bc786
    {
        get
        {
            return _0xdfbe9389._0x8d6a1c71;
        }
    }

    /// <summary>
    /// Keeps the template's own coin plumbing in step with the balance, so any
    /// MoneyCount the template still shows agrees with this game's readout.
    /// </summary>
    private void _0xae6a0dc6()
    {
        if (_0x44f9825a.Instance == null)
        {
            return;
        }

        _0xdfe619ff._0xd23f50e2._0xf3225ca8 = _0xdfbe9389._0x8d6a1c71;
    }

    /// <summary>
    /// §C.59: no Awake. Anything that reads the ledger calls EnsureReady first, so the
    /// order of Start calls never matters.
    /// </summary>
    public void _0xff7f2904()
    {
        if (this._0x6c511ffb)
        {
            return;
        }

        this._0x6c511ffb = true;
        if (!PlayerPrefs.HasKey(_0x3b87862d._0x2fc88ce5(new byte[11] { 171, 166, 191, 226, 175, 190, 169, 168, 165, 184, 191 }, 204)))
        {
            _0xdfbe9389._0x8d6a1c71 = _0x2da34b06.StartingCredits;
        }

        this._0xae6a0dc6();
    }

    public void _0x6d835d64(int _0xd7584cc2)
    {
        _0xdfbe9389._0x0eb1c673 = _0xd7584cc2;
        _0xdfbe9389.Flush();
    }

    /// <summary>old, new, and whether this change was a free house grant.</summary>
    public event Action<int, int, bool> Changed;
    private void Start()
    {
        this._0xff7f2904();
    }

    private void _0x073b58dd(int _0x051013b3, int _0x6ac27785, bool _0xe63c9677)
    {
        _0xdfbe9389.Flush();
        this._0xae6a0dc6();
        if (this.Changed != null)
        {
            this.Changed(_0x051013b3, _0x6ac27785, _0xe63c9677);
        }
    }

    private bool _0x6c511ffb;
    /// <summary>
    /// Takes the stake for one spin. Tops the balance up first if it would not cover it.
    /// Returns true when a free grant was applied, so the HUD can say so.
    /// </summary>
    public bool _0xafb0e93e(int _0x24845769)
    {
        this._0xff7f2904();
        bool _0x3c77e88d = false;
        int _0x7ce48dec = _0xdfbe9389._0x8d6a1c71;
        if (_0x7ce48dec < _0x24845769)
        {
            _0xdfbe9389._0x8d6a1c71 = _0x7ce48dec + _0x2da34b06.HouseGrant;
            _0x3c77e88d = true;
            this._0x073b58dd(_0x7ce48dec, _0xdfbe9389._0x8d6a1c71, true);
            _0x7ce48dec = _0xdfbe9389._0x8d6a1c71;
        }

        _0xdfbe9389._0x8d6a1c71 = _0x7ce48dec - _0x24845769;
        this._0x073b58dd(_0x7ce48dec, _0xdfbe9389._0x8d6a1c71, false);
        return _0x3c77e88d;
    }

    public void _0xcffe7907(int _0x45aafb91)
    {
        if (_0x45aafb91 <= 0)
        {
            return;
        }

        this._0xff7f2904();
        int _0xb6d1ffdb = _0xdfbe9389._0x8d6a1c71;
        _0xdfbe9389._0x8d6a1c71 = _0xb6d1ffdb + _0x45aafb91;
        this._0x073b58dd(_0xb6d1ffdb, _0xdfbe9389._0x8d6a1c71, false);
    }
}

internal static class _0x3b87862d
{
    internal static string _0x2fc88ce5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}