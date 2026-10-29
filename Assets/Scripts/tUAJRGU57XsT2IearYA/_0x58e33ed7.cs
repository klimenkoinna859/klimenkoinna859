using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// How an act works, what the symbols pay, which lines are live, and - said plainly -
/// that the credits are virtual and this is not gambling.
/// </summary>
public sealed class _0x58e33ed7 : MonoBehaviour, _0x5ed4f0d4
{
    private const float ContentHeight = 3180f;
    public void Refresh()
    {
    }

    private float _0x46e05f19(_0xe0927a8a _0x57afcd4f, Transform _0x976d01c4, float _0x90cadf20)
    {
        RectTransform _0x8525617a = _0x98589ea5.Node(_0x976d01c4, _0x6b238163._0x9622c329(new byte[5] { 194, 231, 224, 235, 253 }, 142), _0x98589ea5.TopCentre, new Vector2(0f, _0x90cadf20 - 230f), new Vector2(1040f, 460f));
        for (int _0xf5c2ff7f = 0; _0xf5c2ff7f < _0x2da34b06.CandidateLines; _0xf5c2ff7f++)
        {
            int[] _0x34ad330c = _0x89690aec.LineRows(_0xf5c2ff7f);
            RectTransform _0x321dc05f = _0x98589ea5.Node(_0x8525617a, _0x6b238163._0x9622c329(new byte[8] { 250, 223, 216, 211, 245, 215, 197, 211 }, 182), _0x98589ea5.Centre, new Vector2((_0xf5c2ff7f % 4 - 1.5f) * 250f, _0xf5c2ff7f < 4 ? 110f : -130f), new Vector2(220f, 190f));
            for (int _0xd3006932 = 0; _0xd3006932 < _0x2da34b06.ReelColumns; _0xd3006932++)
            {
                for (int _0x9695d3f3 = 0; _0x9695d3f3 < _0x2da34b06.ReelRows; _0x9695d3f3++)
                {
                    bool _0x3614dd7f = _0x34ad330c[_0xd3006932] == _0x9695d3f3;
                    _0x98589ea5.Plate(_0x321dc05f, _0x6b238163._0x9622c329(new byte[8] { 95, 122, 125, 118, 80, 118, 127, 127 }, 19), _0x57afcd4f._0xfa9196f7, _0x3614dd7f ? _0x3fe280fb.Gold : _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.55f), _0x98589ea5.Centre, new Vector2((_0xd3006932 - 1) * 52f, (1 - _0x9695d3f3) * 44f), new Vector2(44f, 36f), 1.4f);
                }
            }
        }

        _0x98589ea5.Label(_0x8525617a, _0x6b238163._0x9622c329(new byte[9] { 89, 124, 123, 112, 102, 91, 122, 97, 112 }, 21), _0x6b238163._0x9622c329(new byte[40] { 97, 110, 113, 98, 7, 104, 97, 7, 115, 111, 98, 116, 98, 7, 116, 98, 113, 98, 105, 7, 102, 117, 98, 7, 107, 110, 113, 98, 7, 110, 105, 7, 98, 102, 100, 111, 7, 102, 100, 115 }, 39), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, -210f), new Vector2(1000f, 46f));
        return _0x90cadf20 - 500f;
    }

    public void _0x0ca39a59(_0xe0927a8a _0x0b66de91, _0xf84cb8b0 _0xfc58255e, _0x9fb34e44 _0x9bff1df6)
    {
        RectTransform _0x9cdd7d25 = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0x9cdd7d25, _0x6b238163._0x9622c329(new byte[5] { 14, 41, 51, 53, 35 }, 70), _0x0b66de91._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0x9cdd7d25, _0x6b238163._0x9622c329(new byte[4] { 47, 25, 11, 16 }, 120), _0x0b66de91._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.62f), 0f, 2.0f);
        _0xf84cb8b0.Header(_0x9cdd7d25, _0x0b66de91, _0xfc58255e, _0x6b238163._0x9622c329(new byte[5] { 162, 165, 188, 181, 163 }, 240), _0x6b238163._0x9622c329(new byte[19] { 91, 92, 68, 51, 71, 91, 86, 51, 91, 92, 70, 64, 86, 51, 68, 92, 65, 88, 64 }, 19));
        RectTransform _0x48dea662 = _0x98589ea5.ScrollArea(_0x9cdd7d25, _0x6b238163._0x9622c329(new byte[6] { 166, 150, 135, 154, 153, 153 }, 245), _0x98589ea5.TopCentre, new Vector2(0f, -1480f), new Vector2(1120f, 2180f), ContentHeight);
        float _0x96d020f4 = -40f;
        _0x96d020f4 = this._0x696c853b(_0x48dea662, _0x6b238163._0x9622c329(new byte[16] { 137, 142, 150, 225, 128, 143, 225, 128, 130, 149, 225, 150, 142, 147, 138, 146 }, 193), _0x96d020f4);
        _0x96d020f4 = this._0xfc1ba33d(_0x48dea662, _0x6b238163._0x9622c329(new byte[138] { 91, 95, 93, 86, 62, 95, 93, 74, 62, 89, 87, 72, 91, 77, 62, 71, 81, 75, 62, 44, 43, 62, 77, 78, 87, 80, 77, 48, 20, 91, 95, 76, 80, 62, 47, 44, 62, 77, 74, 95, 76, 77, 62, 74, 81, 62, 93, 81, 83, 78, 82, 91, 74, 91, 62, 87, 74, 48, 20, 81, 80, 91, 62, 77, 74, 95, 76, 62, 78, 91, 76, 62, 73, 87, 80, 80, 87, 80, 89, 62, 82, 87, 80, 91, 50, 20, 81, 80, 91, 62, 83, 81, 76, 91, 62, 95, 74, 62, 38, 102, 62, 71, 81, 75, 76, 62, 77, 74, 95, 85, 91, 50, 20, 74, 73, 81, 62, 83, 81, 76, 91, 62, 95, 74, 62, 44, 46, 102, 62, 81, 76, 62, 95, 92, 81, 72, 91, 48 }, 30), _0x96d020f4, 260f);
        _0x96d020f4 = this._0x696c853b(_0x48dea662, _0x6b238163._0x9622c329(new byte[8] { 225, 240, 232, 229, 240, 243, 253, 244 }, 177), _0x96d020f4);
        for (int _0x17485f2c = _0xb4264be6.SymbolCount - 1; _0x17485f2c >= 0; _0x17485f2c--)
        {
            _0x96d020f4 = this._0xeb16c51b(_0x0b66de91, _0x48dea662, _0x17485f2c, _0x96d020f4);
        }

        _0x96d020f4 = this._0xfc1ba33d(_0x48dea662, _0x6b238163._0x9622c329(new byte[60] { 25, 21, 7, 31, 116, 7, 1, 22, 7, 0, 29, 0, 1, 0, 17, 7, 116, 18, 27, 6, 116, 21, 26, 13, 116, 7, 13, 25, 22, 27, 24, 122, 94, 0, 3, 27, 116, 25, 21, 7, 31, 7, 116, 27, 26, 116, 21, 116, 24, 29, 26, 17, 116, 4, 21, 13, 116, 102, 44, 122 }, 84), _0x96d020f4, 120f);
        _0x96d020f4 = this._0x696c853b(_0x48dea662, _0x6b238163._0x9622c329(new byte[5] { 199, 194, 197, 206, 216 }, 139), _0x96d020f4);
        _0x96d020f4 = this._0x46e05f19(_0x0b66de91, _0x48dea662, _0x96d020f4);
        _0x96d020f4 = this._0x696c853b(_0x48dea662, _0x6b238163._0x9622c329(new byte[7] { 174, 191, 168, 169, 164, 185, 190 }, 237), _0x96d020f4);
        _0x96d020f4 = this._0xfc1ba33d(_0x48dea662, _0x6b238163._0x9622c329(new byte[132] { 219, 202, 221, 220, 209, 204, 203, 184, 217, 202, 221, 184, 206, 209, 202, 204, 205, 217, 212, 184, 217, 214, 220, 184, 222, 202, 221, 221, 182, 146, 204, 208, 221, 193, 184, 219, 217, 214, 214, 215, 204, 184, 218, 221, 184, 218, 215, 205, 223, 208, 204, 180, 184, 203, 215, 212, 220, 180, 146, 207, 209, 204, 208, 220, 202, 217, 207, 214, 184, 215, 202, 184, 221, 192, 219, 208, 217, 214, 223, 221, 220, 182, 146, 209, 222, 184, 193, 215, 205, 184, 202, 205, 214, 184, 212, 215, 207, 180, 184, 204, 208, 221, 184, 208, 215, 205, 203, 221, 146, 204, 215, 200, 203, 184, 193, 215, 205, 184, 205, 200, 184, 217, 204, 184, 214, 215, 184, 219, 215, 203, 204, 182 }, 152), _0x96d020f4, 260f);
        _0x96d020f4 = this._0x696c853b(_0x48dea662, _0x6b238163._0x9622c329(new byte[9] { 127, 120, 112, 107, 25, 105, 117, 120, 96 }, 57), _0x96d020f4);
        this._0xfc1ba33d(_0x48dea662, _0x6b238163._0x9622c329(new byte[108] { 126, 100, 101, 114, 126, 124, 116, 98, 17, 112, 99, 116, 17, 117, 116, 114, 120, 117, 116, 117, 17, 115, 104, 17, 112, 59, 98, 116, 116, 117, 116, 117, 17, 99, 112, 127, 117, 126, 124, 17, 118, 116, 127, 116, 99, 112, 101, 126, 99, 31, 59, 101, 121, 120, 98, 17, 120, 98, 17, 116, 127, 101, 116, 99, 101, 112, 120, 127, 124, 116, 127, 101, 17, 126, 127, 125, 104, 59, 112, 127, 117, 17, 120, 98, 17, 127, 126, 101, 17, 118, 112, 124, 115, 125, 120, 127, 118, 31, 59, 0, 9, 26, 17, 126, 127, 125, 104, 31 }, 49), _0x96d020f4, 260f);
    }

    private float _0x696c853b(Transform _0x49e402cc, string _0xf704a8d3, float _0x736a34ad)
    {
        _0x98589ea5.Label(_0x49e402cc, _0x6b238163._0x9622c329(new byte[7] { 254, 200, 206, 217, 196, 194, 195 }, 173), _0xf704a8d3, _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.Gold, TextAlignmentOptions.Left, _0x98589ea5.TopCentre, new Vector2(-20f, _0x736a34ad - 36f), new Vector2(1000f, 70f));
        return _0x736a34ad - 108f;
    }

    private float _0xfc1ba33d(Transform _0xee62c5d8, string _0x412897c7, float _0x5cff8219, float height)
    {
        _0x98589ea5.Label(_0xee62c5d8, _0x6b238163._0x9622c329(new byte[4] { 225, 204, 199, 218 }, 163), _0x412897c7, _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.TopLeft, _0x98589ea5.TopCentre, new Vector2(-20f, _0x5cff8219 - height * 0.5f), new Vector2(1000f, height));
        return _0x5cff8219 - height - 40f;
    }

    private float _0xeb16c51b(_0xe0927a8a _0xf70bbbf2, Transform _0xa407dd04, int _0x673c1a72, float _0xf647ff49)
    {
        // Icon gutter 0..110, name from 134, multiplier in its own right-hand band.
        RectTransform _0x4e9acf87 = _0x98589ea5.Node(_0xa407dd04, _0x6b238163._0x9622c329(new byte[6] { 7, 54, 46, 5, 56, 32 }, 87), _0x98589ea5.TopCentre, new Vector2(0f, _0xf647ff49 - 56f), new Vector2(1040f, 112f));
        _0x98589ea5.Picture(_0x4e9acf87, _0x6b238163._0x9622c329(new byte[9] { 174, 159, 135, 173, 135, 147, 156, 145, 146 }, 254), _0xf70bbbf2._0x294d71d8(_0x673c1a72), Color.white, _0x98589ea5.Centre, new Vector2(-465f, 0f), new Vector2(96f, 96f));
        _0x98589ea5.Label(_0x4e9acf87, _0x6b238163._0x9622c329(new byte[7] { 127, 78, 86, 97, 78, 66, 74 }, 47), _0xb4264be6.DisplayName(_0x673c1a72) + (_0x673c1a72 == _0xb4264be6.Wild ? _0x6b238163._0x9622c329(new byte[7] { 222, 214, 169, 183, 178, 186, 215 }, 254) : string.Empty), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(-110f, 0f), new Vector2(560f, 54f));
        _0x98589ea5.Label(_0x4e9acf87, _0x6b238163._0x9622c329(new byte[8] { 69, 116, 108, 67, 116, 121, 96, 112 }, 21), _0x6b238163._0x9622c329(new byte[1] { 253 }, 133) + _0xb4264be6.Multiplier(_0x673c1a72), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Right, _0x98589ea5.Centre, new Vector2(380f, 0f), new Vector2(240f, 60f));
        return _0xf647ff49 - 124f;
    }
}

internal static class _0x6b238163
{
    internal static string _0x9622c329(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}