/// <summary>
/// One generated act: its three reel strips, which five of the seven candidate lines
/// are live, and the cosmetic variation that makes two acts look different rather than
/// only read different in the HUD.
///
/// §C.59: no constructor anywhere. Build it with new ActProfile().Init(...).
/// </summary>
public sealed class _0xfe7794e1
{
    /// <summary>The act's name on the top bar. Theatre vocabulary, never the app's name.</summary>
    public string _0xa70fdacb()
    {
        switch (this._0x901217d8)
        {
            case 0:
                return _0x788502a6._0x42d39b04(new byte[15] { 131, 144, 153, 131, 144, 129, 245, 154, 131, 144, 135, 129, 128, 135, 144 }, 213);
            case 1:
                return _0x788502a6._0x42d39b04(new byte[10] { 247, 231, 244, 230, 230, 149, 242, 244, 249, 244 }, 181);
            default:
                return _0x788502a6._0x42d39b04(new byte[19] { 250, 254, 243, 249, 254, 240, 255, 227, 151, 250, 246, 228, 230, 226, 242, 229, 246, 243, 242 }, 183);
        }
    }

    public int _0x80e99c5c
    {
        get
        {
            return this._0x8331121d;
        }
    }

    private int[][] _0xfbd10c16;
    public _0xfe7794e1 _0x0b753199(int _0x5df8e6ca, int _0x04fefff7, int[][] _0x76e5c7f4, int[] _0x85979b48, int _0x4a732b52)
    {
        this._0x901217d8 = _0x5df8e6ca;
        this._0x8331121d = _0x04fefff7;
        this._0xfbd10c16 = _0x76e5c7f4;
        this._0x491d6872 = _0x85979b48;
        this._0x0af897d3 = _0x4a732b52;
        return this;
    }

    public int _0xe5af32a8
    {
        get
        {
            return this._0x0af897d3;
        }
    }

    /// <summary>Rank a player needs before this act opens.</summary>
    public static int RequiredRank(int _0x5a77de77)
    {
        switch (_0x5a77de77)
        {
            case 0:
                return 0;
            case 1:
                return 3;
            default:
                return 7;
        }
    }

    private int _0x0af897d3;
    public int[] _0xcacd9341
    {
        get
        {
            return this._0x491d6872;
        }
    }

    public int[][] _0x48ee6665
    {
        get
        {
            return this._0xfbd10c16;
        }
    }

    private int[] _0x491d6872;
    private int _0x901217d8;
    public static string Flavour(int _0x95a26dad)
    {
        switch (_0x95a26dad)
        {
            case 0:
                return _0x788502a6._0x42d39b04(new byte[29] { 181, 183, 188, 166, 190, 183, 210, 223, 210, 180, 160, 183, 163, 167, 183, 188, 166, 210, 161, 191, 179, 190, 190, 210, 190, 187, 188, 183, 161 }, 242);
            case 1:
                return _0x788502a6._0x42d39b04(new byte[28] { 36, 39, 61, 44, 45, 58, 72, 69, 72, 58, 41, 58, 45, 58, 68, 72, 42, 33, 47, 47, 45, 58, 72, 36, 33, 38, 45, 59 }, 104);
            default:
                return _0x788502a6._0x42d39b04(new byte[34] { 200, 203, 211, 188, 217, 196, 200, 206, 221, 188, 209, 221, 207, 215, 207, 188, 211, 210, 188, 200, 212, 217, 188, 209, 213, 216, 216, 208, 217, 188, 206, 217, 217, 208 }, 156);
        }
    }

    public int _0x3d535655
    {
        get
        {
            return this._0x901217d8;
        }
    }

    private int _0x8331121d;
}

internal static class _0x788502a6
{
    internal static string _0x42d39b04(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}