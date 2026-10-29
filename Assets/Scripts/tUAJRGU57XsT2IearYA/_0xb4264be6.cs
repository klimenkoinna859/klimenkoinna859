/// <summary>
/// Symbol identities, their on-screen names and what three of them pay.
///
/// §C.52: this type holds NO static fields at all. Everything is a pure switch, so
/// Plana's string encryption plus declaration reordering has nothing to reorder and
/// the type can never die in its own static constructor.
///
/// Id 5 is MASK, the wild. Its art is the emblem; ids 0..4 are the five ordinary
/// symbols the art stage draws.
/// </summary>
public static class _0xb4264be6
{
    /// <summary>Multiplier paid for three of a kind on an active line.</summary>
    public static int Multiplier(int _0x9543dd99)
    {
        switch (_0x9543dd99)
        {
            case 0:
                return 3; // STAR
            case 1:
                return 5; // TICKET
            case 2:
                return 8; // BRASS BELL
            case 3:
                return 12; // RUBY
            case 4:
                return 20; // GOLD FACE
            default:
                return 50; // MASK
        }
    }

    public const int Wild = 5;
    public const int SymbolCount = 6;
    /// <summary>The caption shown in the paytable. Never the app's name.</summary>
    public static string DisplayName(int _0x8780682c)
    {
        switch (_0x8780682c)
        {
            case 0:
                return _0xb1509d67._0x04c4f789(new byte[4] { 45, 42, 63, 44 }, 126);
            case 1:
                return _0xb1509d67._0x04c4f789(new byte[6] { 41, 52, 62, 54, 56, 41 }, 125);
            case 2:
                return _0xb1509d67._0x04c4f789(new byte[10] { 239, 255, 236, 254, 254, 141, 239, 232, 225, 225 }, 173);
            case 3:
                return _0xb1509d67._0x04c4f789(new byte[4] { 176, 183, 160, 187 }, 226);
            case 4:
                return _0xb1509d67._0x04c4f789(new byte[9] { 91, 83, 80, 88, 60, 90, 93, 95, 89 }, 28);
            default:
                return _0xb1509d67._0x04c4f789(new byte[4] { 202, 198, 212, 204 }, 135);
        }
    }

    /// <summary>How often the symbol appears on a strip of the opening act.</summary>
    public static int BaseWeight(int _0x1767e452)
    {
        switch (_0x1767e452)
        {
            case 0:
                return 12;
            case 1:
                return 10;
            case 2:
                return 8;
            case 3:
                return 6;
            case 4:
                return 4;
            default:
                return 2;
        }
    }

    /// <summary>
    /// Stars earned by one winning line: one for the line, one more for a loud win,
    /// two more for a headline win. Twelve of these complete an act.
    /// </summary>
    public static int StarsFor(int _0xde8a47ae, int _0xc3dc6d5f)
    {
        if (_0xde8a47ae <= 0 || _0xc3dc6d5f <= 0)
        {
            return 0;
        }

        int _0xf5ec47fc = 1;
        if (_0xde8a47ae >= _0xc3dc6d5f * 8)
        {
            _0xf5ec47fc++;
        }

        if (_0xde8a47ae >= _0xc3dc6d5f * 20)
        {
            _0xf5ec47fc += 2;
        }

        return _0xf5ec47fc;
    }
}

internal static class _0xb1509d67
{
    internal static string _0x04c4f789(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}