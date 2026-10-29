using System;
using UnityEngine;

/// <summary>
/// Local, offline persistence. Keys are stable string literals that do not depend on
/// any C# name, so obfuscation cannot move a player's progress.
///
/// §C.52: no static lookup table is built from string constants. Every key is written
/// inline in the accessor that uses it, so nothing here runs at static-initialiser time.
/// </summary>
public static class _0xdfbe9389
{
    /// <summary>Day number the mission trio was drawn for; a change re-rolls them.</summary>
    public static int _0x711d2829
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 140, 129, 152, 197, 134, 130, 152, 152, 130, 132, 133, 197, 143, 138, 146 }, 235), -1);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 215, 218, 195, 158, 221, 217, 195, 195, 217, 223, 222, 158, 212, 209, 201 }, 176), value);
        }
    }

    public static int _0xd3b1284a
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[17] { 197, 200, 209, 140, 210, 208, 205, 196, 203, 206, 199, 140, 195, 206, 203, 195, 209 }, 162), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[17] { 139, 134, 159, 194, 156, 158, 131, 138, 133, 128, 137, 194, 141, 128, 133, 141, 159 }, 236), value);
            PlayerPrefs.Save();
        }
    }

    /// <summary>Twelve collectable cards as a 12-character mask of '0' and '1'.</summary>
    public static string _0xb85a95d5
    {
        get
        {
            return PlayerPrefs.GetString(_0x87f3ac34._0x0b6d1332(new byte[9] { 250, 247, 238, 179, 254, 252, 239, 249, 238 }, 157), _0x87f3ac34._0x0b6d1332(new byte[12] { 114, 114, 114, 114, 114, 114, 114, 114, 114, 114, 114, 114 }, 66));
        }

        set
        {
            PlayerPrefs.SetString(_0x87f3ac34._0x0b6d1332(new byte[9] { 246, 251, 226, 191, 242, 240, 227, 245, 226 }, 145), value);
            PlayerPrefs.Save();
        }
    }

    public static int _0x2d763bef
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[14] { 143, 130, 155, 198, 155, 156, 137, 156, 198, 155, 152, 129, 134, 155 }, 232), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[14] { 146, 159, 134, 219, 134, 129, 148, 129, 219, 134, 133, 156, 155, 134 }, 245), value);
        }
    }

    /// <summary>Whole days since the epoch, UTC - the mission/gift day key. No network.</summary>
    public static int UtcDayNumber()
    {
        return (int)(DateTime.UtcNow.Ticks / TimeSpan.TicksPerDay);
    }

    public static int _0xbed946ee
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[13] { 6, 11, 18, 79, 18, 21, 0, 21, 79, 0, 2, 21, 18 }, 97), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[13] { 181, 184, 161, 252, 161, 166, 179, 166, 252, 179, 177, 166, 161 }, 210), value);
        }
    }

    public static int _0xe1ff0088
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 55, 58, 35, 126, 35, 36, 49, 36, 126, 35, 36, 34, 53, 49, 59 }, 80), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 80, 93, 68, 25, 68, 67, 86, 67, 25, 68, 67, 69, 82, 86, 92 }, 55), value);
        }
    }

    /// <summary>Per-mission progress and claim state, packed as "p,p,p|c,c,c".</summary>
    public static string _0x9892d0c6
    {
        get
        {
            return PlayerPrefs.GetString(_0x87f3ac34._0x0b6d1332(new byte[17] { 209, 220, 197, 152, 219, 223, 197, 197, 223, 217, 216, 152, 197, 194, 215, 194, 211 }, 182), _0x87f3ac34._0x0b6d1332(new byte[11] { 211, 207, 211, 207, 211, 159, 211, 207, 211, 207, 211 }, 227));
        }

        set
        {
            PlayerPrefs.SetString(_0x87f3ac34._0x0b6d1332(new byte[17] { 114, 127, 102, 59, 120, 124, 102, 102, 124, 122, 123, 59, 102, 97, 116, 97, 112 }, 21), value);
            PlayerPrefs.Save();
        }
    }

    public static int _0xd8aee681
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[6] { 116, 121, 96, 61, 107, 99 }, 19), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[6] { 167, 170, 179, 238, 184, 176 }, 192), value);
        }
    }

    public static int _0x0eb1c673
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[9] { 244, 249, 224, 189, 224, 231, 242, 248, 246 }, 147), _0x2da34b06.DefaultStake);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[9] { 116, 121, 96, 61, 96, 103, 114, 120, 118 }, 19), value);
        }
    }

    public static bool _0xa93024f2
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 223, 210, 203, 150, 203, 221, 204, 150, 208, 217, 200, 204, 209, 219, 203 }, 184), 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 6, 11, 18, 79, 18, 4, 21, 79, 9, 0, 17, 21, 8, 2, 18 }, 97), value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    public static bool _0x29469462
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[11] { 167, 170, 179, 238, 161, 167, 165, 238, 161, 163, 171 }, 192), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[11] { 151, 154, 131, 222, 145, 151, 149, 222, 145, 147, 155 }, 240), value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    public static void Flush()
    {
        PlayerPrefs.Save();
    }

    public static int _0x097060d8
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[8] { 114, 127, 102, 59, 103, 116, 123, 126 }, 21), 1);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[8] { 193, 204, 213, 136, 212, 199, 200, 205 }, 166), value);
        }
    }

    public static int _0xf4d88f87
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[13] { 67, 78, 87, 10, 69, 71, 80, 10, 77, 74, 64, 65, 92 }, 36), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[13] { 178, 191, 166, 251, 180, 182, 161, 251, 188, 187, 177, 176, 173 }, 213), value);
            PlayerPrefs.Save();
        }
    }

    public static long _0x7d5e939c
    {
        get
        {
            string _0x96d59033 = PlayerPrefs.GetString(_0x87f3ac34._0x0b6d1332(new byte[13] { 174, 163, 186, 231, 174, 160, 175, 189, 231, 165, 168, 186, 189 }, 201), _0x87f3ac34._0x0b6d1332(new byte[1] { 217 }, 233));
            long _0xa1d74479;
            return long.TryParse(_0x96d59033, out _0xa1d74479) ? _0xa1d74479 : 0L;
        }

        set
        {
            PlayerPrefs.SetString(_0x87f3ac34._0x0b6d1332(new byte[13] { 210, 223, 198, 155, 210, 220, 211, 193, 155, 217, 212, 198, 193 }, 181), value.ToString());
            PlayerPrefs.Save();
        }
    }

    public static int _0xa862c4d3
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[16] { 118, 123, 98, 63, 97, 99, 126, 119, 120, 125, 116, 63, 101, 120, 127, 101 }, 17), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[16] { 108, 97, 120, 37, 123, 121, 100, 109, 98, 103, 110, 37, 127, 98, 101, 127 }, 11), value);
            PlayerPrefs.Save();
        }
    }

    public static int _0x9b16a414
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[13] { 183, 186, 163, 254, 163, 164, 177, 164, 254, 178, 181, 163, 164 }, 208), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[13] { 116, 121, 96, 61, 96, 103, 114, 103, 61, 113, 118, 96, 103 }, 19), value);
        }
    }

    public static bool _0x967a3f5c
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[17] { 26, 23, 14, 83, 14, 24, 9, 83, 27, 28, 14, 9, 15, 24, 24, 17, 14 }, 125), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[17] { 59, 54, 47, 114, 47, 57, 40, 114, 58, 61, 47, 40, 46, 57, 57, 48, 47 }, 92), value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    public static int _0x0f985d80
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[13] { 79, 66, 91, 6, 91, 92, 73, 92, 6, 95, 65, 70, 91 }, 40), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[13] { 128, 141, 148, 201, 148, 147, 134, 147, 201, 144, 142, 137, 148 }, 231), value);
        }
    }

    /// <summary>RESET PROGRESS: clears every gjs.* key and the template's own coin mirror.</summary>
    public static void WipeAll()
    {
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[11] { 196, 201, 208, 141, 194, 196, 198, 141, 194, 192, 200 }, 163));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[11] { 42, 39, 62, 99, 46, 63, 40, 41, 36, 57, 62 }, 77));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[9] { 23, 26, 3, 94, 3, 4, 17, 27, 21 }, 112));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[8] { 249, 244, 237, 176, 236, 255, 240, 245 }, 158));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[6] { 199, 202, 211, 142, 216, 208 }, 160));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[13] { 63, 50, 43, 118, 57, 59, 44, 118, 49, 54, 60, 61, 32 }, 88));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[15] { 43, 38, 63, 98, 45, 47, 56, 98, 63, 41, 63, 63, 37, 35, 34 }, 76));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[13] { 17, 28, 5, 88, 17, 31, 16, 2, 88, 26, 23, 5, 2 }, 118));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[15] { 215, 218, 195, 158, 215, 217, 214, 196, 158, 195, 196, 194, 213, 209, 219 }, 176));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[15] { 82, 95, 70, 27, 88, 92, 70, 70, 92, 90, 91, 27, 81, 84, 76 }, 53));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[17] { 223, 210, 203, 150, 213, 209, 203, 203, 209, 215, 214, 150, 203, 204, 217, 204, 221 }, 184));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[9] { 91, 86, 79, 18, 95, 93, 78, 88, 79 }, 60));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[16] { 221, 208, 201, 148, 202, 200, 213, 220, 211, 214, 223, 148, 206, 211, 212, 206 }, 186));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[17] { 109, 96, 121, 36, 122, 120, 101, 108, 99, 102, 111, 36, 107, 102, 99, 107, 121 }, 10));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[15] { 225, 236, 245, 168, 245, 227, 242, 168, 238, 231, 246, 242, 239, 229, 245 }, 134));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[14] { 170, 167, 190, 227, 190, 168, 185, 227, 160, 162, 185, 164, 162, 163 }, 205));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[17] { 236, 225, 248, 165, 248, 238, 255, 165, 237, 234, 248, 255, 249, 238, 238, 231, 248 }, 139));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[13] { 136, 133, 156, 193, 156, 155, 142, 155, 193, 142, 140, 155, 156 }, 239));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[13] { 214, 219, 194, 159, 194, 197, 208, 197, 159, 198, 216, 223, 194 }, 177));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[14] { 176, 189, 164, 249, 164, 163, 182, 163, 249, 164, 167, 190, 185, 164 }, 215));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[13] { 146, 159, 134, 219, 134, 129, 148, 129, 219, 151, 144, 134, 129 }, 245));
        PlayerPrefs.DeleteKey(_0x87f3ac34._0x0b6d1332(new byte[15] { 121, 116, 109, 48, 109, 106, 127, 106, 48, 109, 106, 108, 123, 127, 117 }, 30));
        PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[5] { 248, 212, 210, 213, 200 }, 187), 0);
        PlayerPrefs.Save();
    }

    public static int _0xbb0a7f51
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 120, 117, 108, 49, 120, 118, 121, 107, 49, 108, 107, 109, 122, 126, 116 }, 31), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 106, 103, 126, 35, 106, 100, 107, 121, 35, 126, 121, 127, 104, 108, 102 }, 13), value);
        }
    }

    public static bool _0x5fbcf839
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[14] { 205, 192, 217, 132, 217, 207, 222, 132, 199, 197, 222, 195, 197, 196 }, 170), 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[14] { 165, 168, 177, 236, 177, 167, 182, 236, 175, 173, 182, 171, 173, 172 }, 194), value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    public static int _0x6f7325e5
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 33, 44, 53, 104, 39, 37, 50, 104, 53, 35, 53, 53, 47, 41, 40 }, 70), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[15] { 1, 12, 21, 72, 7, 5, 18, 72, 21, 3, 21, 21, 15, 9, 8 }, 102), value);
        }
    }

    public static int _0x8d6a1c71
    {
        get
        {
            return PlayerPrefs.GetInt(_0x87f3ac34._0x0b6d1332(new byte[11] { 196, 201, 208, 141, 192, 209, 198, 199, 202, 215, 208 }, 163), _0x2da34b06.StartingCredits);
        }

        set
        {
            PlayerPrefs.SetInt(_0x87f3ac34._0x0b6d1332(new byte[11] { 1, 12, 21, 72, 5, 20, 3, 2, 15, 18, 21 }, 102), value < 0 ? 0 : value);
        }
    }
}

internal static class _0x87f3ac34
{
    internal static string _0x0b6d1332(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}