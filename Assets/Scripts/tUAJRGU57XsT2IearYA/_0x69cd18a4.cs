using System;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// The act: a spin budget, a star meter and the two ways an act can end.
///
/// §C.5: there is NO countdown and NO draining meter here. With zero taps the game
/// sits in idle for ever, so the review's capture window always lands on live
/// gameplay; the only thing that moves the act along is the player tapping SPIN, and
/// twenty-five spins at ~3.3 s each is well past the sixty-second floor.
/// </summary>
public sealed class _0x69cd18a4 : MonoBehaviour
{
    private void _0x7d866d8d()
    {
        this._0xeea61184 = StateFinished;
        _0xdfbe9389._0x6f7325e5 = _0xdfbe9389._0x6f7325e5 + 1;
        _0xdfbe9389.Flush();
        this._0x03928898();
        if (this._0xa660886f != null)
        {
            this._0xa660886f._0xd170bdd8(this._0xdf60b536, this._0x86949df5);
        }
    }

    private _0x236224c8 _0x79b6dbb2;
    private _0xa8c064dc _0xbbcdf770;
    private void _0x242c5545()
    {
        for (int _0x4a7c9b39 = 0; _0x4a7c9b39 < _0x2da34b06.ReelColumns; _0x4a7c9b39++)
        {
            _0xb6165fcc.ReadColumn(this._0x727eb468._0x48ee6665[_0x4a7c9b39], this._0x3a7d15dc[_0x4a7c9b39], _0x4a7c9b39, this._0xfb1f0e42);
        }
    }

    public const int StateResolving = 2;
    private int _0x6fbd5156;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private void _0x8d2f1da8()
    {
        for (int _0x80cf5f04 = 0; _0x80cf5f04 < _0x2da34b06.ReelColumns; _0x80cf5f04++)
        {
            this._0x3a7d15dc[_0x80cf5f04] = this._0x822ae222.Next(0, this._0x727eb468._0x48ee6665[_0x80cf5f04].Length);
        }
    }

    private _0xfe7794e1 _0x727eb468;
    private bool _0x4eacf4f8;
    private int[] _0xfb1f0e42;
    private void _0xd1f5b81a()
    {
        if (this._0xeea61184 != StateResolving)
        {
            return;
        }

        if (this._0xdf60b536 >= _0x2da34b06.ActStarGoal)
        {
            this._0x6df32fa8();
            return;
        }

        if (this._0x7f4a720c <= 0)
        {
            this._0x7d866d8d();
            return;
        }

        this._0xeea61184 = StateIdle;
        this._0x03928898();
    }

    /// <summary>Raised with the payout, the multiplier and whether the house topped up.</summary>
    public event Action<int, int, bool> SpinResolved;
    public int _0x489508e7
    {
        get
        {
            return this._0xeea61184;
        }
    }

    private void _0x1421860f()
    {
        if (this._0xeea61184 != StateSpinning)
        {
            return;
        }

        this._0xeea61184 = StateResolving;
        int _0x68343a0a = _0xdfbe9389._0x0eb1c673;
        int total = _0x89690aec.Resolve(this._0xfb1f0e42, this._0x727eb468._0xcacd9341, _0x68343a0a, this._0xd70693dc, this._0xee852ad2);
        int _0xd9bb8ffb = 0;
        int gained = 0;
        int paidLines = 0;
        for (int _0x6f6aad55 = 0; _0x6f6aad55 < this._0xd70693dc.Length; _0x6f6aad55++)
        {
            if (this._0xd70693dc[_0x6f6aad55] <= 0)
            {
                continue;
            }

            paidLines++;
            gained += this._0xee852ad2[_0x6f6aad55];
            int _0xe6c85d00 = _0x68343a0a > 0 ? this._0xd70693dc[_0x6f6aad55] / _0x68343a0a : 0;
            if (_0xe6c85d00 > _0xd9bb8ffb)
            {
                _0xd9bb8ffb = _0xe6c85d00;
            }
        }

        for (int _0x31188239 = 0; _0x31188239 < this._0xfb1f0e42.Length; _0x31188239++)
        {
            if (this._0xfb1f0e42[_0x31188239] == _0xb4264be6.Wild)
            {
                this._0x6fbd5156++;
            }
        }

        if (total > 0)
        {
            this._0x79b6dbb2._0xcffe7907(total);
            this._0x6dced9a2 += total;
            this._0xdf60b536 += gained;
            this._0x86949df5 += paidLines;
            this._0xbbcdf770._0xefdb20df(this._0x727eb468._0xcacd9341, this._0xd70693dc);
            this._0xbbcdf770._0x4be872c2(total);
            _0xf7dacd0a.AddXp(_0x2da34b06.XpPerLine * paidLines);
        }

        if (_0xd9bb8ffb > _0xdfbe9389._0x9b16a414)
        {
            _0xdfbe9389._0x9b16a414 = _0xd9bb8ffb;
        }

        _0xb29ed313.Report(0, paidLines);
        _0xb29ed313.ReportBest(2, this._0x6fbd5156);
        _0xb29ed313.ReportBest(3, this._0xdf60b536);
        _0xb29ed313.ReportBest(4, this._0x6dced9a2);
        _0xdfbe9389.Flush();
        if (this.SpinResolved != null)
        {
            this.SpinResolved(total, _0xd9bb8ffb, this._0x4eacf4f8);
        }

        this._0x03928898();
        DOVirtual.DelayedCall(_0x2da34b06.ResolveHold, () => this._0xd1f5b81a()).SetLink(this.gameObject);
    }

    private System.Random _0x822ae222;
    public void _0x5752994f()
    {
        if (this._0xeea61184 == StateFinished || this._0xeea61184 == StatePaused)
        {
            return;
        }

        this._0x651cd711 = StateIdle;
        this._0xeea61184 = StatePaused;
        this._0x03928898();
        if (this._0xa660886f != null)
        {
            this._0xa660886f._0xdfb3824b(_0xdfbe9389._0x8d6a1c71, this._0xdf60b536);
        }
    }

    public int _0xd0b03e38
    {
        get
        {
            return this._0x7f4a720c;
        }
    }

    private int _0x6dced9a2;
    private int _0xdf60b536;
    /// <summary>
    /// The template's own RESUME button only hides the pop; it never tells the game.
    /// The stage director watches the pop dimmer and calls this, so the run is never
    /// left frozen behind a pop that has already closed.
    /// </summary>
    public void _0xfbc0977d()
    {
        if (this._0xeea61184 != StatePaused)
        {
            return;
        }

        this._0xeea61184 = this._0x651cd711;
        this._0x03928898();
    }

    private int _0x651cd711 = StateIdle;
    private void _0x03928898()
    {
        if (this.Changed != null)
        {
            this.Changed();
        }
    }

    private int _0xeea61184 = StateIdle;
    public const int StateIdle = 0;
    public int _0x2c94e666
    {
        get
        {
            return this._0x6dced9a2;
        }
    }

    public void _0x966935c8()
    {
        if (!this._0xff83ef8d)
        {
            return;
        }

        int _0x4d67ddd8 = _0xdfbe9389._0x0eb1c673;
        bool _0x2d13394e = this._0x79b6dbb2._0xafb0e93e(_0x4d67ddd8);
        this._0x7f4a720c--;
        this._0xeea61184 = StateSpinning;
        _0xdfbe9389._0x2d763bef = _0xdfbe9389._0x2d763bef + 1;
        _0xb29ed313.Report(1, 1);
        _0xf7dacd0a.AddXp(_0x2da34b06.XpPerSpin);
        this._0x03928898();
        this._0x8d2f1da8();
        this._0x242c5545();
        float _0x46401897 = _0x2da34b06.SpinRoll * (_0xdfbe9389._0x967a3f5c ? 0.56f : 1f) * (_0xdfbe9389._0x5fbcf839 ? 0.5f : 1f);
        float _0x6ef930b6 = _0x2da34b06.SpinStagger * (_0xdfbe9389._0x967a3f5c ? 0.48f : 1f) * (_0xdfbe9389._0x5fbcf839 ? 0.5f : 1f);
        {
#if B_LOGS
            {
                Debug.Log($"[spin] left={this._0x7f4a720c} stake={_0x4d67ddd8} granted={_0x2d13394e} stops={this._0x3a7d15dc[0]},{this._0x3a7d15dc[1]},{this._0x3a7d15dc[2]}");
            }
#endif
        }

        this._0x4eacf4f8 = _0x2d13394e;
        this._0xbbcdf770._0x90eb307d(this._0x727eb468, this._0x3a7d15dc, this._0xfb1f0e42, _0x46401897, _0x6ef930b6, () => this._0x1421860f());
    }

    private _0x22a0a22b _0xa660886f;
    public int _0xaad3d859
    {
        get
        {
            return this._0xdf60b536;
        }
    }

    private int[] _0xd70693dc;
    private int[] _0x3a7d15dc;
    public const int StateSpinning = 1;
    private int _0x7f4a720c;
    public const int StateFinished = 3;
    public void _0x63e58808(_0xfe7794e1 _0xcfbcb7a6, _0xa8c064dc _0xbbc4dbb3, _0x236224c8 _0xc5c5e14a, _0x22a0a22b _0xd989ecbf)
    {
        this._0x727eb468 = _0xcfbcb7a6;
        this._0xbbcdf770 = _0xbbc4dbb3;
        this._0x79b6dbb2 = _0xc5c5e14a;
        this._0xa660886f = _0xd989ecbf;
        this._0x822ae222 = new System.Random(_0xcfbcb7a6._0x80e99c5c ^ 0x5F3A91);
        this._0xfb1f0e42 = new int[_0x2da34b06.ReelColumns * _0x2da34b06.ReelRows];
        this._0x3a7d15dc = new int[_0x2da34b06.ReelColumns];
        this._0xd70693dc = new int[_0xcfbcb7a6._0xcacd9341.Length];
        this._0xee852ad2 = new int[_0xcfbcb7a6._0xcacd9341.Length];
        this._0x7f4a720c = _0x2da34b06.SpinBudget;
        this._0xdf60b536 = 0;
        this._0x6dced9a2 = 0;
        this._0x6fbd5156 = 0;
        this._0x86949df5 = 0;
        this._0xeea61184 = StateIdle;
        this._0x8d2f1da8();
        this._0x242c5545();
        this._0xbbcdf770._0x41efe262(this._0xfb1f0e42);
        _0xdfbe9389._0xbed946ee = _0xdfbe9389._0xbed946ee + 1;
        _0xb29ed313.EnsureToday();
        _0xb29ed313.ReportBest(6, _0xf7dacd0a.UnlockedActCount());
        _0xdfbe9389.Flush();
        this._0x03928898();
    }

    private void _0x6df32fa8()
    {
        this._0xeea61184 = StateFinished;
        _0xdfbe9389._0x0f985d80 = _0xdfbe9389._0x0f985d80 + 1;
        _0xf7dacd0a.AddXp(_0x2da34b06.XpPerAct);
        _0xf7dacd0a.GrantCard(this._0x727eb468._0x80e99c5c);
        _0xb29ed313.Report(5, 1);
        int _0x9f44afcc = _0xdfbe9389._0xf4d88f87 + 1;
        if (_0x9f44afcc >= _0x2da34b06.ActCount || !_0xf7dacd0a.ActUnlocked(_0x9f44afcc))
        {
            _0x9f44afcc = 0;
        }

        _0xdfbe9389._0xf4d88f87 = _0x9f44afcc;
        _0xdfbe9389._0x6f7325e5 = _0xdfbe9389._0x6f7325e5 + 1;
        _0xdfbe9389.Flush();
        this._0x03928898();
        if (this._0xa660886f != null)
        {
            this._0xa660886f._0x2406c1e9(this._0xdf60b536, this._0x6dced9a2);
        }
    }

    private int[] _0xee852ad2;
    public _0xfe7794e1 _0x4926cdc7
    {
        get
        {
            return this._0x727eb468;
        }
    }

    /// <summary>Raised whenever anything the HUD shows has moved.</summary>
    public event Action Changed;
    public const int StatePaused = 4;
    private int _0x86949df5;
    public bool _0xff83ef8d
    {
        get
        {
            return this._0xeea61184 == StateIdle && this._0x7f4a720c > 0;
        }
    }
}