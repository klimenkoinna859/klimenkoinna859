/// <summary>
/// Rank, experience, the lifetime ledger and the twelve collectable cards.
/// Stateless: every value lives in SaveStore, so the menu and the game scene always
/// agree without either of them owning a singleton.
/// </summary>
public static class _0xf7dacd0a
{
    public static int CardsOwned()
    {
        string _0x63ebbf51 = _0xdfbe9389._0xb85a95d5;
        int _0x49af7902 = 0;
        for (int _0x8bcebaa2 = 0; _0x8bcebaa2 < _0x63ebbf51.Length; _0x8bcebaa2++)
        {
            if (_0x63ebbf51[_0x8bcebaa2] == '1')
            {
                _0x49af7902++;
            }
        }

        return _0x49af7902;
    }

    public static string AliasName(int _0x72383b57)
    {
        switch (_0x72383b57)
        {
            case 0:
                return _0x99c75d46._0xa3e338f5(new byte[11] { 220, 219, 193, 199, 209, 180, 211, 193, 209, 199, 192 }, 148);
            case 1:
                return _0x99c75d46._0xa3e338f5(new byte[9] { 133, 145, 140, 141, 151, 227, 145, 140, 148 }, 195);
            case 2:
                return _0x99c75d46._0xa3e338f5(new byte[10] { 231, 252, 246, 247, 224, 225, 230, 231, 246, 235 }, 178);
            case 3:
                return _0x99c75d46._0xa3e338f5(new byte[9] { 135, 128, 149, 147, 145, 156, 149, 154, 144 }, 212);
            case 4:
                return _0x99c75d46._0xa3e338f5(new byte[9] { 52, 57, 61, 56, 48, 53, 50, 57, 46 }, 124);
            default:
                return _0x99c75d46._0xa3e338f5(new byte[9] { 19, 20, 26, 21, 9, 125, 18, 10, 17 }, 93);
        }
    }

    /// <summary>Adds experience and promotes when the bar fills. Returns ranks gained.</summary>
    public static int AddXp(int _0xc040934d)
    {
        if (_0xc040934d <= 0)
        {
            return 0;
        }

        int _0x3144b08c = _0xd708b43a;
        _0xdfbe9389._0xd8aee681 = _0xdfbe9389._0xd8aee681 + _0xc040934d;
        int _0xf96dff4a = 1 + _0xdfbe9389._0xd8aee681 / _0x2da34b06.XpPerRank;
        if (_0xf96dff4a > _0x2da34b06.MaxRank)
        {
            _0xf96dff4a = _0x2da34b06.MaxRank;
        }

        _0xdfbe9389._0x097060d8 = _0xf96dff4a;
        _0xdfbe9389.Flush();
        return _0xf96dff4a - _0x3144b08c;
    }

    public static int _0xcccce500
    {
        get
        {
            return _0x2da34b06.XpPerRank;
        }
    }

    public static bool ActUnlocked(int _0xf7e2eb5b)
    {
        return _0xd708b43a >= _0xfe7794e1.RequiredRank(_0xf7e2eb5b);
    }

    /// <summary>Grants one card the player does not own yet. Returns its index, or -1.</summary>
    public static int GrantCard(int _0x41766e0b)
    {
        string _0x9a9a3799 = _0xdfbe9389._0xb85a95d5;
        if (_0x9a9a3799.Length < _0x2da34b06.CardCount)
        {
            _0x9a9a3799 = _0x9a9a3799.PadRight(_0x2da34b06.CardCount, '0');
        }

        int _0xd2ab7a96 = _0x41766e0b < 0 ? 0 : _0x41766e0b % _0x2da34b06.CardCount;
        for (int _0xe2cd9705 = 0; _0xe2cd9705 < _0x2da34b06.CardCount; _0xe2cd9705++)
        {
            int _0x24032951 = (_0xd2ab7a96 + _0xe2cd9705) % _0x2da34b06.CardCount;
            if (_0x9a9a3799[_0x24032951] == '0')
            {
                char[] _0x2907a09b = _0x9a9a3799.ToCharArray();
                _0x2907a09b[_0x24032951] = '1';
                _0xdfbe9389._0xb85a95d5 = new string (_0x2907a09b);
                return _0x24032951;
            }
        }

        return -1;
    }

    // ── collection ────────────────────────────────────────────────────────────
    public static bool CardOwned(int _0xfaa4b8f7)
    {
        string _0x54bb0bb1 = _0xdfbe9389._0xb85a95d5;
        return _0xfaa4b8f7 >= 0 && _0xfaa4b8f7 < _0x54bb0bb1.Length && _0x54bb0bb1[_0xfaa4b8f7] == '1';
    }

    public static string CardName(int _0x1b2dbccb)
    {
        switch (_0x1b2dbccb % 4)
        {
            case 0:
                return _0x99c75d46._0xa3e338f5(new byte[10] { 131, 159, 146, 247, 159, 146, 133, 150, 155, 147 }, 215);
            case 1:
                return _0x99c75d46._0xa3e338f5(new byte[8] { 129, 157, 144, 245, 152, 156, 152, 144 }, 213);
            case 2:
                return _0x99c75d46._0xa3e338f5(new byte[9] { 141, 145, 156, 249, 155, 156, 149, 149, 138 }, 217);
            default:
                return _0x99c75d46._0xa3e338f5(new byte[10] { 40, 52, 57, 92, 57, 50, 63, 51, 46, 57 }, 124);
        }
    }

    public static string CardFlavour(int _0x3e18101f)
    {
        switch (_0x3e18101f % 4)
        {
            case 0:
                return _0x99c75d46._0xa3e338f5(new byte[30] { 183, 168, 189, 182, 171, 216, 189, 174, 189, 170, 161, 216, 186, 177, 180, 180, 212, 216, 172, 185, 179, 189, 171, 216, 182, 183, 216, 186, 183, 175 }, 248);
            case 1:
                return _0x99c75d46._0xa3e338f5(new byte[28] { 157, 143, 151, 157, 238, 128, 129, 154, 134, 135, 128, 137, 226, 238, 157, 154, 129, 158, 157, 238, 154, 134, 139, 238, 156, 129, 129, 131 }, 206);
            case 2:
                return _0x99c75d46._0xa3e338f5(new byte[23] { 173, 177, 171, 188, 188, 217, 183, 182, 173, 188, 170, 213, 217, 182, 183, 188, 217, 184, 183, 170, 174, 188, 171 }, 249);
            default:
                return _0x99c75d46._0xa3e338f5(new byte[29] { 103, 96, 117, 109, 103, 20, 99, 124, 113, 122, 20, 96, 124, 113, 20, 120, 125, 115, 124, 96, 103, 20, 115, 123, 20, 112, 123, 99, 122 }, 52);
        }
    }

    public static int UnlockedActCount()
    {
        int _0x0ad308d6 = 0;
        for (int _0xea15368b = 0; _0xea15368b < _0x2da34b06.ActCount; _0xea15368b++)
        {
            if (ActUnlocked(_0xea15368b))
            {
                _0x0ad308d6++;
            }
        }

        return _0x0ad308d6;
    }

    public static int _0xd708b43a
    {
        get
        {
            int _0x1de037c5 = _0xdfbe9389._0x097060d8;
            if (_0x1de037c5 < 1)
            {
                return 1;
            }

            return _0x1de037c5 > _0x2da34b06.MaxRank ? _0x2da34b06.MaxRank : _0x1de037c5;
        }
    }

    public static string CardSuite(int _0xbe82a854)
    {
        if (_0xbe82a854 < 4)
        {
            return _0x99c75d46._0xa3e338f5(new byte[6] { 172, 191, 182, 172, 191, 174 }, 250);
        }

        return _0xbe82a854 < 8 ? _0x99c75d46._0xa3e338f5(new byte[5] { 78, 94, 77, 95, 95 }, 12) : _0x99c75d46._0xa3e338f5(new byte[8] { 246, 242, 255, 245, 242, 252, 243, 239 }, 187);
    }

    public static int _0x21d3c738
    {
        get
        {
            return _0xdfbe9389._0xd8aee681 % _0x2da34b06.XpPerRank;
        }
    }
}

internal static class _0x99c75d46
{
    internal static string _0xa3e338f5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}