using System;
using UnityEngine;

/// <summary>
/// Builds an act. Nothing about an act is written out as coordinates: the three
/// 24-stop strips, the five live lines out of seven and the drape variant all come
/// from a seeded System.Random (§C.11) - never UnityEngine.Random, whose state is
/// global and shared with anything else that pulls on it.
///
/// Generated, then VERIFIED, then shown: 400 virtual spins must land the act's star
/// expectation and line hit-rate inside a playable window, or the strips are redrawn.
/// A hand-written layout exists only as the fallback, never as the game.
/// </summary>
public sealed class _0xb6165fcc : MonoBehaviour
{
    private int[][] _0xebab4bba(System.Random _0xe3951b5d, int _0x565d854d)
    {
        int[][] _0xbd57e2db = new int[_0x2da34b06.ReelColumns][];
        for (int _0x98df642e = 0; _0x98df642e < _0x2da34b06.ReelColumns; _0x98df642e++)
        {
            _0xbd57e2db[_0x98df642e] = this._0x891a377a(_0xe3951b5d, _0x565d854d, _0x98df642e);
        }

        return _0xbd57e2db;
    }

    /// <summary>Reads the three visible rows of a column from a landed stop index.</summary>
    public static void ReadColumn(int[] _0x4fb7af80, int _0xfe42d00a, int _0xa1cad489, int[] _0xada40872)
    {
        for (int _0x6f85f72b = 0; _0x6f85f72b < _0x2da34b06.ReelRows; _0x6f85f72b++)
        {
            _0xada40872[_0x6f85f72b * _0x2da34b06.ReelColumns + _0xa1cad489] = _0x4fb7af80[(_0xfe42d00a + _0x6f85f72b) % _0x4fb7af80.Length];
        }
    }

    /// <summary>Five of the seven candidates, drawn without repeats.</summary>
    private int[] _0xa58ed680(System.Random _0xae792b7a)
    {
        int[] _0x15a0e741 = new int[_0x2da34b06.CandidateLines];
        for (int _0xfe1a950c = 0; _0xfe1a950c < _0x15a0e741.Length; _0xfe1a950c++)
        {
            _0x15a0e741[_0xfe1a950c] = _0xfe1a950c;
        }

        for (int _0x15579b7c = _0x15a0e741.Length - 1; _0x15579b7c > 0; _0x15579b7c--)
        {
            int _0x54175c82 = _0xae792b7a.Next(0, _0x15579b7c + 1);
            int _0xada73c4c = _0x15a0e741[_0x15579b7c];
            _0x15a0e741[_0x15579b7c] = _0x15a0e741[_0x54175c82];
            _0x15a0e741[_0x54175c82] = _0xada73c4c;
        }

        int[] _0xb08ad80f = new int[_0x2da34b06.ActiveLines];
        Array.Copy(_0x15a0e741, _0xb08ad80f, _0x2da34b06.ActiveLines);
        Array.Sort(_0xb08ad80f);
        return _0xb08ad80f;
    }

    /// <summary>
    /// Four hundred virtual spins at the default stake. The act is playable when twelve
    /// stars are reachable inside twenty-five spins without being a formality.
    /// </summary>
    private bool _0xe7759f0f(int[][] _0x70d84697, int[] _0xd7ef7b40)
    {
        System.Random _0x254d417a = new System.Random(12345);
        int[] _0x8eee7bcf = new int[_0x2da34b06.ReelColumns * _0x2da34b06.ReelRows];
        int[] _0xf738963d = new int[_0xd7ef7b40.Length];
        int[] _0x24b5d46c = new int[_0xd7ef7b40.Length];
        int _0xe1ce5c4f = _0x2da34b06.DefaultStake;
        int _0x3d91359c = 0;
        int _0x48a92606 = 0;
        for (int _0xbf5a0b6d = 0; _0xbf5a0b6d < SimSpins; _0xbf5a0b6d++)
        {
            for (int _0x0aa0994e = 0; _0x0aa0994e < _0x2da34b06.ReelColumns; _0x0aa0994e++)
            {
                int _0xced56c56 = _0x254d417a.Next(0, _0x70d84697[_0x0aa0994e].Length);
                for (int _0x48af4740 = 0; _0x48af4740 < _0x2da34b06.ReelRows; _0x48af4740++)
                {
                    _0x8eee7bcf[_0x48af4740 * _0x2da34b06.ReelColumns + _0x0aa0994e] = _0x70d84697[_0x0aa0994e][(_0xced56c56 + _0x48af4740) % _0x70d84697[_0x0aa0994e].Length];
                }
            }

            _0x89690aec.Resolve(_0x8eee7bcf, _0xd7ef7b40, _0xe1ce5c4f, _0xf738963d, _0x24b5d46c);
            int spinStars = 0;
            for (int _0x15b253e5 = 0; _0x15b253e5 < _0x24b5d46c.Length; _0x15b253e5++)
            {
                spinStars += _0x24b5d46c[_0x15b253e5];
            }

            _0x3d91359c += spinStars;
            if (spinStars > 0)
            {
                _0x48a92606++;
            }
        }

        float _0xd66d14a9 = (float)_0x3d91359c / SimSpins * _0x2da34b06.SpinBudget;
        float _0x4802a043 = (float)_0x48a92606 / SimSpins;
        return _0xd66d14a9 >= MinExpectedStars && _0xd66d14a9 <= MaxExpectedStars && _0x4802a043 >= MinHitRate && _0x4802a043 <= MaxHitRate;
    }

    private const float MinHitRate = 0.28f;
    private const float MaxExpectedStars = 22f;
    public _0xfe7794e1 _0x30dee124(int _0xc0085977, int _0x4ed39b60)
    {
        int _0x8679ad05 = (_0xc0085977 * 7919) ^ (_0x4ed39b60 * 104729);
        System.Random _0xa15b8dca = new System.Random(_0x8679ad05);
        int[] _0x6a3538db = this._0xa58ed680(_0xa15b8dca);
        int[][] _0x84b2b2c1 = this._0xebab4bba(_0xa15b8dca, _0xc0085977);
        for (int _0x37d13337 = 0; _0x37d13337 < 20 && !this._0xe7759f0f(_0x84b2b2c1, _0x6a3538db); _0x37d13337++)
        {
            _0x84b2b2c1 = this._0xebab4bba(_0xa15b8dca, _0xc0085977);
        }

        if (!this._0xe7759f0f(_0x84b2b2c1, _0x6a3538db))
        {
            _0x84b2b2c1 = this._0x04f36d62();
            _0x6a3538db = new int[]
            {
                0,
                1,
                2,
                3,
                4
            };
        }

        {
#if B_LOGS
            {
                Debug.Log($"[act] seed={_0x8679ad05} act={_0xc0085977} session={_0x4ed39b60} lines={_0x6a3538db.Length}");
            }
#endif
        }

        return new _0xfe7794e1()._0x0b753199(_0xc0085977, _0x8679ad05, _0x84b2b2c1, _0x6a3538db, _0xa15b8dca.Next(0, 3));
    }

    private const float MaxHitRate = 0.48f;
    /// <summary>Per-act symbol weights: the opening act is gentle, the second louder.</summary>
    private int _0x742609a0(int _0x8752065c, int _0xf995423d)
    {
        int _0xb262c676 = _0xb4264be6.BaseWeight(_0xf995423d);
        if (_0x8752065c == 1)
        {
            if (_0xf995423d == _0xb4264be6.Wild)
            {
                _0xb262c676 += 1;
            }

            if (_0xf995423d == 4)
            {
                _0xb262c676 += 2;
            }

            if (_0xf995423d == 0)
            {
                _0xb262c676 -= 2;
            }
        }

        return _0xb262c676 < 1 ? 1 : _0xb262c676;
    }

    private const float MinExpectedStars = 10f;
    /// <summary>A balanced hand-made set. The guarantee behind the generator, not the game.</summary>
    private int[][] _0x04f36d62()
    {
        int[][] _0xd7ebbcba = new int[_0x2da34b06.ReelColumns][];
        _0xd7ebbcba[0] = new int[]
        {
            0,
            1,
            2,
            0,
            3,
            1,
            0,
            4,
            2,
            1,
            0,
            5,
            3,
            1,
            2,
            0,
            1,
            4,
            0,
            2,
            3,
            1,
            0,
            2
        };
        _0xd7ebbcba[1] = new int[]
        {
            1,
            0,
            3,
            2,
            0,
            1,
            5,
            2,
            0,
            4,
            1,
            3,
            0,
            2,
            1,
            0,
            3,
            1,
            2,
            0,
            4,
            1,
            0,
            2
        };
        _0xd7ebbcba[2] = new int[]
        {
            2,
            1,
            0,
            4,
            1,
            3,
            0,
            2,
            5,
            0,
            1,
            2,
            3,
            0,
            1,
            4,
            2,
            0,
            1,
            3,
            0,
            2,
            1,
            0
        };
        return _0xd7ebbcba;
    }

    private int[] _0x891a377a(System.Random _0x617fb382, int _0x05a00e75, int _0xf752702a)
    {
        int[] _0xd209d45e = new int[_0x2da34b06.StripStops];
        int _0x15b548a0 = 0;
        // The third act hangs two extra MASKs on the middle reel - a change the player
        // can see on the board, not only in a number.
        if (_0x05a00e75 == 2 && _0xf752702a == 1)
        {
            _0xd209d45e[_0x15b548a0++] = _0xb4264be6.Wild;
            _0xd209d45e[_0x15b548a0++] = _0xb4264be6.Wild;
        }

        int _0xa68a4b64 = 0;
        for (int _0xb546bdef = 0; _0xb546bdef < _0xb4264be6.SymbolCount; _0xb546bdef++)
        {
            _0xa68a4b64 += this._0x742609a0(_0x05a00e75, _0xb546bdef);
        }

        while (_0x15b548a0 < _0xd209d45e.Length)
        {
            int _0x87b2c9e6 = _0x617fb382.Next(0, _0xa68a4b64);
            int _0xa695cbb1 = 0;
            int _0x6f2a22fc = 0;
            for (int _0x557298bc = 0; _0x557298bc < _0xb4264be6.SymbolCount; _0x557298bc++)
            {
                _0xa695cbb1 += this._0x742609a0(_0x05a00e75, _0x557298bc);
                if (_0x87b2c9e6 < _0xa695cbb1)
                {
                    _0x6f2a22fc = _0x557298bc;
                    break;
                }
            }

            _0xd209d45e[_0x15b548a0++] = _0x6f2a22fc;
        }

        for (int _0x257672ea = _0xd209d45e.Length - 1; _0x257672ea > 0; _0x257672ea--)
        {
            int _0x2c98cb29 = _0x617fb382.Next(0, _0x257672ea + 1);
            int _0x4e965c70 = _0xd209d45e[_0x257672ea];
            _0xd209d45e[_0x257672ea] = _0xd209d45e[_0x2c98cb29];
            _0xd209d45e[_0x2c98cb29] = _0x4e965c70;
        }

        // No three identical stops in a row: a strip that clumps reads as a stuck reel.
        for (int _0x1870b57b = 2; _0x1870b57b < _0xd209d45e.Length; _0x1870b57b++)
        {
            if (_0xd209d45e[_0x1870b57b] == _0xd209d45e[_0x1870b57b - 1] && _0xd209d45e[_0x1870b57b] == _0xd209d45e[_0x1870b57b - 2])
            {
                int _0x46e0dd4d = _0x617fb382.Next(0, _0xd209d45e.Length);
                int _0xb11f21a4 = _0xd209d45e[_0x1870b57b];
                _0xd209d45e[_0x1870b57b] = _0xd209d45e[_0x46e0dd4d];
                _0xd209d45e[_0x46e0dd4d] = _0xb11f21a4;
            }
        }

        return _0xd209d45e;
    }

    private const int SimSpins = 400;
}