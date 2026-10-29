using System;

/// <summary>
/// Three missions a day, drawn from a pool by the day's own seed - never a fixed list
/// (§C.11). Progress and claim state are packed into one SaveStore string so the two
/// scenes share them without a singleton.
/// </summary>
public static class _0xb29ed313
{
    public static int ClaimedCount()
    {
        int _0xbd0fda1d = 0;
        for (int _0x2e479d2b = 0; _0x2e479d2b < _0x2da34b06.MissionCount; _0x2e479d2b++)
        {
            if (Claimed(_0x2e479d2b))
            {
                _0xbd0fda1d++;
            }
        }

        return _0xbd0fda1d;
    }

    public static bool Complete(int _0xd5d71de4)
    {
        return Progress(_0xd5d71de4) >= GoalOf(_0xd5d71de4);
    }

    public static string TextOf(int _0x739fd2de)
    {
        int _0xef535e19 = GoalOf(_0x739fd2de);
        switch (KindOf(_0x739fd2de))
        {
            case 0:
                return _0xab45cc2e._0x16721892(new byte[5] { 105, 100, 107, 97, 5 }, 37) + _0xef535e19 + _0xab45cc2e._0x16721892(new byte[14] { 240, 135, 153, 158, 158, 153, 158, 151, 240, 156, 153, 158, 149, 131 }, 208);
            case 1:
                return _0xab45cc2e._0x16721892(new byte[5] { 40, 43, 50, 53, 91 }, 123) + _0xef535e19 + _0xab45cc2e._0x16721892(new byte[6] { 157, 233, 244, 240, 248, 238 }, 189);
            case 2:
                return _0xab45cc2e._0x16721892(new byte[8] { 209, 221, 222, 222, 215, 209, 198, 178 }, 146) + _0xef535e19 + _0xab45cc2e._0x16721892(new byte[13] { 176, 221, 209, 195, 219, 176, 195, 201, 221, 210, 223, 220, 195 }, 144);
            case 3:
                return _0xab45cc2e._0x16721892(new byte[6] { 40, 63, 59, 57, 50, 90 }, 122) + _0xef535e19 + _0xab45cc2e._0x16721892(new byte[10] { 157, 252, 254, 233, 157, 238, 233, 252, 239, 238 }, 189);
            case 4:
                return _0xab45cc2e._0x16721892(new byte[4] { 151, 137, 142, 224 }, 192) + _0xef535e19 + _0xab45cc2e._0x16721892(new byte[19] { 250, 153, 136, 159, 158, 147, 142, 137, 250, 147, 148, 250, 149, 148, 159, 250, 155, 153, 142 }, 218);
            case 5:
                return _0xab45cc2e._0x16721892(new byte[14] { 35, 47, 45, 48, 44, 37, 52, 37, 64, 81, 64, 33, 35, 52 }, 96);
            default:
                return _0xab45cc2e._0x16721892(new byte[5] { 178, 173, 184, 179, 221 }, 253) + _0xef535e19 + _0xab45cc2e._0x16721892(new byte[15] { 78, 42, 39, 40, 40, 43, 60, 43, 32, 58, 78, 47, 45, 58, 61 }, 110);
        }
    }

    public const int PoolSize = 7;
    /// <summary>The goal quantity for today's version of that mission.</summary>
    public static int GoalOf(int _0xee694fe9)
    {
        int _0x8002f5fd = KindOf(_0xee694fe9);
        System.Random _0xe704b5e9 = new System.Random(_0xdfbe9389.UtcDayNumber() * 97 + _0xee694fe9 * 13 + 5);
        switch (_0x8002f5fd)
        {
            case 0:
                return 4 + _0xe704b5e9.Next(0, 4); // LAND n WINNING LINES
            case 1:
                return 15 + _0xe704b5e9.Next(0, 11); // SPIN n TIMES
            case 2:
                return 2 + _0xe704b5e9.Next(0, 3); // COLLECT n MASK SYMBOLS
            case 3:
                return 6 + _0xe704b5e9.Next(0, 4); // REACH n ACT STARS
            case 4:
                return 300 + _0xe704b5e9.Next(0, 7) * 50; // WIN n CREDITS IN ONE ACT
            case 5:
                return 1; // COMPLETE 1 ACT
            default:
                return 2 + _0xe704b5e9.Next(0, 2); // OPEN n DIFFERENT ACTS
        }
    }

    public static int RewardCredits(int _0xa7cbf74f)
    {
        return RewardOf(_0xa7cbf74f) == _0xab45cc2e._0x16721892(new byte[7] { 98, 120, 105, 10, 8, 27, 13 }, 73) ? 0 : 250;
    }

    public static bool Claimed(int _0xbbb82059)
    {
        int[] _0xa57909ec = Parse(_0xdfbe9389._0x9892d0c6, 1);
        return _0xbbb82059 >= 0 && _0xbbb82059 < _0xa57909ec.Length && _0xa57909ec[_0xbbb82059] == 1;
    }

    public static string RewardOf(int _0x8b805ddc)
    {
        int _0x747ff0c2 = KindOf(_0x8b805ddc);
        return _0x747ff0c2 == 2 || _0x747ff0c2 == 5 ? _0xab45cc2e._0x16721892(new byte[7] { 78, 84, 69, 38, 36, 55, 33 }, 101) : _0xab45cc2e._0x16721892(new byte[12] { 182, 175, 168, 173, 189, 222, 207, 216, 217, 212, 201, 206 }, 157);
    }

    /// <summary>Reports play towards every mission of the given kind.</summary>
    public static void Report(int _0x8ee6bb86, int _0x717da05a)
    {
        EnsureToday();
        int[] _0xe21effc9 = Parse(_0xdfbe9389._0x9892d0c6, 0);
        int[] _0xeccc6dff = Parse(_0xdfbe9389._0x9892d0c6, 1);
        bool _0xf30a65c0 = false;
        for (int _0xd8921dbd = 0; _0xd8921dbd < _0x2da34b06.MissionCount; _0xd8921dbd++)
        {
            if (KindOf(_0xd8921dbd) != _0x8ee6bb86 || _0xeccc6dff[_0xd8921dbd] == 1)
            {
                continue;
            }

            int _0x3156d512 = GoalOf(_0xd8921dbd);
            int _0xae398693 = _0xe21effc9[_0xd8921dbd] + _0x717da05a;
            _0xe21effc9[_0xd8921dbd] = _0xae398693 > _0x3156d512 ? _0x3156d512 : _0xae398693;
            _0xf30a65c0 = true;
        }

        if (_0xf30a65c0)
        {
            Write(_0xe21effc9, _0xeccc6dff);
        }
    }

    // ── state ─────────────────────────────────────────────────────────────────
    private static int[] Parse(string _0xbcd9a639, int _0xf16a76e2)
    {
        int[] _0xf7144987 = new int[_0x2da34b06.MissionCount];
        if (string.IsNullOrEmpty(_0xbcd9a639))
        {
            return _0xf7144987;
        }

        string[] _0xee37b04a = _0xbcd9a639.Split('|');
        if (_0xee37b04a.Length <= _0xf16a76e2)
        {
            return _0xf7144987;
        }

        string[] _0x02f3adcb = _0xee37b04a[_0xf16a76e2].Split(',');
        for (int _0xb8984c5e = 0; _0xb8984c5e < _0xf7144987.Length && _0xb8984c5e < _0x02f3adcb.Length; _0xb8984c5e++)
        {
            int _0x3352fa5c;
            _0xf7144987[_0xb8984c5e] = int.TryParse(_0x02f3adcb[_0xb8984c5e], out _0x3352fa5c) ? _0x3352fa5c : 0;
        }

        return _0xf7144987;
    }

    public static int Progress(int _0x20d24c4f)
    {
        int[] _0x7c02208f = Parse(_0xdfbe9389._0x9892d0c6, 0);
        return _0x20d24c4f >= 0 && _0x20d24c4f < _0x7c02208f.Length ? _0x7c02208f[_0x20d24c4f] : 0;
    }

    /// <summary>Reports an absolute best (stars in an act, credits in an act).</summary>
    public static void ReportBest(int _0xb18094e2, int _0xfa81f429)
    {
        EnsureToday();
        int[] _0xb82f23b3 = Parse(_0xdfbe9389._0x9892d0c6, 0);
        int[] _0xb892be22 = Parse(_0xdfbe9389._0x9892d0c6, 1);
        bool _0x800af4f9 = false;
        for (int _0xee0e7ac0 = 0; _0xee0e7ac0 < _0x2da34b06.MissionCount; _0xee0e7ac0++)
        {
            if (KindOf(_0xee0e7ac0) != _0xb18094e2 || _0xb892be22[_0xee0e7ac0] == 1 || _0xfa81f429 <= _0xb82f23b3[_0xee0e7ac0])
            {
                continue;
            }

            int _0x548ae3b2 = GoalOf(_0xee0e7ac0);
            _0xb82f23b3[_0xee0e7ac0] = _0xfa81f429 > _0x548ae3b2 ? _0x548ae3b2 : _0xfa81f429;
            _0x800af4f9 = true;
        }

        if (_0x800af4f9)
        {
            Write(_0xb82f23b3, _0xb892be22);
        }
    }

    private static void Write(int[] _0xe166e578, int[] _0x654d142a)
    {
        _0xdfbe9389._0x9892d0c6 = string.Join(_0xab45cc2e._0x16721892(new byte[1] { 141 }, 161), Array.ConvertAll(_0xe166e578, _0x40359aea => _0x40359aea.ToString())) + _0xab45cc2e._0x16721892(new byte[1] { 210 }, 174) + string.Join(_0xab45cc2e._0x16721892(new byte[1] { 12 }, 32), Array.ConvertAll(_0x654d142a, _0x40359aea => _0x40359aea.ToString()));
    }

    /// <summary>Which pool entry mission `slot` is today. No repeats inside a day.</summary>
    public static int KindOf(int _0xf6d748e7)
    {
        System.Random _0xc16f685e = new System.Random(_0xdfbe9389.UtcDayNumber() * 31 + 17);
        int[] _0x50956b2a = new int[PoolSize];
        for (int _0xa4e83e30 = 0; _0xa4e83e30 < PoolSize; _0xa4e83e30++)
        {
            _0x50956b2a[_0xa4e83e30] = _0xa4e83e30;
        }

        for (int _0x9d3971ec = PoolSize - 1; _0x9d3971ec > 0; _0x9d3971ec--)
        {
            int _0xdba67b63 = _0xc16f685e.Next(0, _0x9d3971ec + 1);
            int _0x8e8bc5ae = _0x50956b2a[_0x9d3971ec];
            _0x50956b2a[_0x9d3971ec] = _0x50956b2a[_0xdba67b63];
            _0x50956b2a[_0xdba67b63] = _0x8e8bc5ae;
        }

        return _0x50956b2a[_0xf6d748e7 % PoolSize];
    }

    public static bool AnyClaimable()
    {
        for (int _0x4d19d587 = 0; _0x4d19d587 < _0x2da34b06.MissionCount; _0x4d19d587++)
        {
            if (Complete(_0x4d19d587) && !Claimed(_0x4d19d587))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>Re-rolls the trio when the UTC day changes. Safe to call every time.</summary>
    public static void EnsureToday()
    {
        int _0x23031c16 = _0xdfbe9389.UtcDayNumber();
        if (_0xdfbe9389._0x711d2829 == _0x23031c16)
        {
            return;
        }

        _0xdfbe9389._0x711d2829 = _0x23031c16;
        _0xdfbe9389._0x9892d0c6 = _0xab45cc2e._0x16721892(new byte[11] { 121, 101, 121, 101, 121, 53, 121, 101, 121, 101, 121 }, 73);
    }

    /// <summary>Marks a mission claimed. Returns the credits it paid.</summary>
    public static int Claim(int _0xfdfa450c)
    {
        if (!Complete(_0xfdfa450c) || Claimed(_0xfdfa450c))
        {
            return 0;
        }

        int[] _0x1029e130 = Parse(_0xdfbe9389._0x9892d0c6, 0);
        int[] _0x23cfc76b = Parse(_0xdfbe9389._0x9892d0c6, 1);
        _0x23cfc76b[_0xfdfa450c] = 1;
        Write(_0x1029e130, _0x23cfc76b);
        int _0x5371d1dd = RewardCredits(_0xfdfa450c);
        if (_0x5371d1dd > 0)
        {
            _0xdfbe9389._0x8d6a1c71 = _0xdfbe9389._0x8d6a1c71 + _0x5371d1dd;
        }
        else
        {
            _0xf7dacd0a.GrantCard(_0xdfbe9389.UtcDayNumber() + _0xfdfa450c);
        }

        _0xdfbe9389.Flush();
        return _0x5371d1dd;
    }
}

internal static class _0xab45cc2e
{
    internal static string _0x16721892(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}