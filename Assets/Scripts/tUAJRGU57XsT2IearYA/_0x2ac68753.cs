using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The rank ledger. A fresh profile shows zeros and a line telling the player how the
/// ledger starts - the rows are never left blank.
/// </summary>
public sealed class _0x2ac68753 : MonoBehaviour, _0x5ed4f0d4
{
    private TextMeshProUGUI _0xe8b4fa63;
    private readonly List<_0xc5d7f584> _0xe5ce4b07 = new List<_0xc5d7f584>();
    private void _0x41fa6e57(_0xe0927a8a _0x9c5cd5f2, _0x9fb34e44 _0xdbdeceaa, Transform _0x45052818, int _0x19e051ba, string _0xac24a8be)
    {
        _0x9fb34e44 _0x37c85310 = Instantiate(_0xdbdeceaa, _0x45052818, false);
        RectTransform _0x1d0a69fa = _0x37c85310._0x7693cccd;
        _0x1d0a69fa.anchorMin = _0x98589ea5.TopCentre;
        _0x1d0a69fa.anchorMax = _0x98589ea5.TopCentre;
        _0x1d0a69fa.anchoredPosition = new Vector2(0f, -840f - _0x19e051ba * 150f);
        _0x37c85310._0x0d1f6abd(new Vector2(1080f, 130f));
        _0x37c85310._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0x464d2867 = _0x37c85310._0xf9550e0d;
        // Gutter 41..83, label column 129..649, value column 709..1020 - three bands,
        // none of them touching (§C.25).
        _0x98589ea5.Plate(_0x464d2867, _0x43c61430._0x6a2a1ae7(new byte[3] { 255, 198, 223 }, 175), _0x9c5cd5f2._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.85f), _0x98589ea5.Centre, new Vector2(_0x2da34b06.GutterCentre - 540f, 0f), new Vector2(_0x2da34b06.GutterWidth, 46f), 1.0f);
        _0x98589ea5.Label(_0x464d2867, _0x43c61430._0x6a2a1ae7(new byte[8] { 130, 165, 176, 165, 159, 176, 188, 180 }, 209), _0xac24a8be, _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(129f + 260f - 540f, 0f), new Vector2(520f, 56f));
        TextMeshProUGUI _0x9ee950a5 = _0x98589ea5.Label(_0x464d2867, _0x43c61430._0x6a2a1ae7(new byte[9] { 81, 118, 99, 118, 84, 99, 110, 119, 103 }, 2), _0x43c61430._0x6a2a1ae7(new byte[1] { 250 }, 215), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Right, _0x98589ea5.Centre, new Vector2(864f - 540f, 0f), new Vector2(311f, 62f));
        this._0x66c46785.Add(_0x9ee950a5);
    }

    public void _0x96c00100(_0xe0927a8a _0x6fd68b45, _0xf84cb8b0 _0x6351f6bf, _0x9fb34e44 _0xf55aa0c5, _0xc5d7f584 _0x2884ea80)
    {
        RectTransform _0xccbe7991 = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0xccbe7991, _0x43c61430._0x6a2a1ae7(new byte[5] { 245, 210, 200, 206, 216 }, 189), _0x6fd68b45._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0xccbe7991, _0x43c61430._0x6a2a1ae7(new byte[4] { 97, 87, 69, 94 }, 54), _0x6fd68b45._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.58f), 0f, 2.0f);
        _0xf84cb8b0.Header(_0xccbe7991, _0x6fd68b45, _0x6351f6bf, _0x43c61430._0x6a2a1ae7(new byte[8] { 201, 203, 214, 222, 203, 220, 202, 202 }, 153), _0x43c61430._0x6a2a1ae7(new byte[37] { 118, 101, 106, 111, 4, 103, 107, 105, 97, 119, 4, 98, 118, 107, 105, 4, 116, 104, 101, 125, 109, 106, 99, 8, 4, 106, 107, 112, 108, 109, 106, 99, 4, 97, 104, 119, 97 }, 36));
        _0x9fb34e44 _0x00afcedc = Instantiate(_0xf55aa0c5, _0xccbe7991, false);
        RectTransform _0x56b55ff0 = _0x00afcedc._0x7693cccd;
        _0x56b55ff0.anchorMin = _0x98589ea5.TopCentre;
        _0x56b55ff0.anchorMax = _0x98589ea5.TopCentre;
        _0x56b55ff0.anchoredPosition = new Vector2(0f, -560f);
        _0x00afcedc._0x0d1f6abd(new Vector2(1080f, 360f));
        _0x00afcedc._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0xc2dac915 = _0x00afcedc._0xf9550e0d;
        this._0xe401603d = _0x98589ea5.Label(_0xc2dac915, _0x43c61430._0x6a2a1ae7(new byte[9] { 3, 48, 63, 58, 7, 48, 61, 36, 52 }, 81), _0x43c61430._0x6a2a1ae7(new byte[6] { 171, 184, 183, 178, 217, 200 }, 249), _0x2da34b06.NumberMax, _0x2da34b06.NumberMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, 98f), new Vector2(900f, 86f));
        _0x98589ea5.Plate(_0xc2dac915, _0x43c61430._0x6a2a1ae7(new byte[7] { 96, 72, 108, 74, 89, 91, 83 }, 56), _0x6fd68b45._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.85f), _0x98589ea5.Centre, new Vector2(0f, 10f), new Vector2(XpBarWidth, 26f), 1.0f);
        RectTransform _0x5ddc5720 = _0x98589ea5.Node(_0xc2dac915, _0x43c61430._0x6a2a1ae7(new byte[10] { 16, 56, 14, 33, 36, 36, 0, 39, 59, 60 }, 72), _0x98589ea5.Centre, new Vector2(-XpBarWidth * 0.5f, 10f), new Vector2(0f, 26f));
        this._0xe0906f5f = _0x98589ea5.Plate(_0x5ddc5720, _0x43c61430._0x6a2a1ae7(new byte[6] { 139, 163, 149, 186, 191, 191 }, 211), _0x6fd68b45._0xfa9196f7, _0x3fe280fb.Gold, _0x98589ea5.Centre, Vector2.zero, new Vector2(12f, 26f), 1.0f);
        RectTransform _0x6d33073d = (RectTransform)this._0xe0906f5f.transform;
        _0x6d33073d.pivot = new Vector2(0f, 0.5f);
        _0x6d33073d.anchoredPosition = Vector2.zero;
        this._0xe8b4fa63 = _0x98589ea5.Label(_0xc2dac915, _0x43c61430._0x6a2a1ae7(new byte[9] { 147, 187, 136, 170, 187, 191, 162, 164, 165 }, 203), _0x43c61430._0x6a2a1ae7(new byte[1] { 244 }, 217), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, -70f), new Vector2(980f, 52f));
        string[] _0x36918c46 = new string[]
        {
            _0x43c61430._0x6a2a1ae7(new byte[11] { 212, 214, 193, 198, 181, 218, 197, 208, 219, 208, 209 }, 149),
            _0x43c61430._0x6a2a1ae7(new byte[14] { 114, 112, 103, 96, 19, 112, 124, 126, 99, 127, 118, 103, 118, 119 }, 51),
            _0x43c61430._0x6a2a1ae7(new byte[11] { 143, 148, 143, 154, 151, 251, 136, 139, 146, 149, 136 }, 219),
            _0x43c61430._0x6a2a1ae7(new byte[11] { 183, 176, 166, 161, 213, 165, 180, 172, 186, 160, 161 }, 245),
            _0x43c61430._0x6a2a1ae7(new byte[14] { 7, 4, 5, 12, 14, 24, 31, 107, 24, 31, 25, 14, 10, 0 }, 75),
            _0x43c61430._0x6a2a1ae7(new byte[11] { 105, 107, 120, 110, 121, 10, 101, 125, 100, 111, 110 }, 42)
        };
        for (int _0x74bf58d1 = 0; _0x74bf58d1 < _0x36918c46.Length; _0x74bf58d1++)
        {
            this._0x41fa6e57(_0x6fd68b45, _0xf55aa0c5, _0xccbe7991, _0x74bf58d1, _0x36918c46[_0x74bf58d1]);
        }

        _0x98589ea5.Label(_0xccbe7991, _0x43c61430._0x6a2a1ae7(new byte[13] { 185, 148, 145, 145, 144, 135, 182, 148, 133, 129, 156, 154, 155 }, 245), _0x43c61430._0x6a2a1ae7(new byte[11] { 72, 91, 84, 81, 58, 86, 91, 94, 94, 95, 72 }, 26), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, -1760f), new Vector2(1000f, 46f));
        for (int _0x8d378b18 = 0; _0x8d378b18 < _0x2da34b06.MaxRank; _0x8d378b18++)
        {
            _0xc5d7f584 _0xe59166af = Instantiate(_0x2884ea80, _0xccbe7991, false);
            RectTransform _0x89009a73 = (RectTransform)_0xe59166af.transform;
            _0x89009a73.anchorMin = _0x98589ea5.TopCentre;
            _0x89009a73.anchorMax = _0x98589ea5.TopCentre;
            _0x89009a73.sizeDelta = new Vector2(40f, 40f);
            _0x89009a73.anchoredPosition = new Vector2((_0x8d378b18 - 9.5f) * 54f, -1840f);
            this._0xe5ce4b07.Add(_0xe59166af);
        }

        this._0xfb82d5b6 = _0x98589ea5.Label(_0xccbe7991, _0x43c61430._0x6a2a1ae7(new byte[10] { 109, 68, 69, 70, 68, 83, 105, 72, 79, 85 }, 33), _0x43c61430._0x6a2a1ae7(new byte[1] { 13 }, 32), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, -1950f), new Vector2(1040f, 54f));
    }

    private Image _0xe0906f5f;
    private readonly List<TextMeshProUGUI> _0x66c46785 = new List<TextMeshProUGUI>();
    private void _0x47559f67(int _0x9cce0627, string _0x2131441b)
    {
        if (_0x9cce0627 < this._0x66c46785.Count)
        {
            _0xd6a1e4cb.SetText(this._0x66c46785[_0x9cce0627], _0x2131441b);
        }
    }

    public void Refresh()
    {
        int _0x4ec463c7 = _0xf7dacd0a._0xd708b43a;
        _0xd6a1e4cb.SetText(this._0xe401603d, _0x43c61430._0x6a2a1ae7(new byte[5] { 63, 44, 35, 38, 77 }, 109) + _0x4ec463c7);
        _0xd6a1e4cb.SetText(this._0xe8b4fa63, _0x2da34b06.Grouped(_0xf7dacd0a._0x21d3c738) + _0x43c61430._0x6a2a1ae7(new byte[3] { 150, 153, 150 }, 182) + _0x2da34b06.Grouped(_0xf7dacd0a._0xcccce500) + _0x43c61430._0x6a2a1ae7(new byte[12] { 119, 15, 7, 119, 3, 24, 119, 5, 22, 25, 28, 119 }, 87) + (_0x4ec463c7 + 1 > _0x2da34b06.MaxRank ? _0x2da34b06.MaxRank : _0x4ec463c7 + 1));
        float _0x2691abdb = _0xf7dacd0a._0xcccce500 <= 0 ? 0f : (float)_0xf7dacd0a._0x21d3c738 / _0xf7dacd0a._0xcccce500;
        RectTransform _0x719ee654 = (RectTransform)this._0xe0906f5f.transform;
        _0x719ee654.sizeDelta = new Vector2(Mathf.Max(12f, XpBarWidth * Mathf.Clamp01(_0x2691abdb)), 26f);
        this._0x47559f67(0, _0xdfbe9389._0xbed946ee.ToString());
        this._0x47559f67(1, _0xdfbe9389._0x0f985d80.ToString());
        this._0x47559f67(2, _0x2da34b06.Grouped(_0xdfbe9389._0x2d763bef));
        this._0x47559f67(3, _0xdfbe9389._0x9b16a414 > 0 ? _0x43c61430._0x6a2a1ae7(new byte[1] { 49 }, 73) + _0xdfbe9389._0x9b16a414 : _0x43c61430._0x6a2a1ae7(new byte[1] { 229 }, 200));
        this._0x47559f67(4, _0xdfbe9389._0xe1ff0088 + _0x43c61430._0x6a2a1ae7(new byte[5] { 124, 24, 29, 5, 15 }, 92));
        this._0x47559f67(5, _0xf7dacd0a.CardsOwned() + _0x43c61430._0x6a2a1ae7(new byte[3] { 78, 65, 78 }, 110) + _0x2da34b06.CardCount);
        for (int _0xbf82015b = 0; _0xbf82015b < this._0xe5ce4b07.Count; _0xbf82015b++)
        {
            this._0xe5ce4b07[_0xbf82015b]._0x68264ad1(_0xbf82015b < _0x4ec463c7, _0x3fe280fb.Gold);
        }

        if (_0x4ec463c7 - 1 >= 0 && _0x4ec463c7 - 1 < this._0xe5ce4b07.Count)
        {
            this._0xe5ce4b07[_0x4ec463c7 - 1]._0x93f8b400();
        }

        bool _0xd4f374db = _0xdfbe9389._0xbed946ee == 0 && _0xdfbe9389._0x2d763bef == 0;
        _0xd6a1e4cb.SetText(this._0xfb82d5b6, _0xd4f374db ? _0x43c61430._0x6a2a1ae7(new byte[31] { 236, 240, 253, 229, 156, 253, 242, 156, 253, 255, 232, 156, 232, 243, 156, 239, 232, 253, 238, 232, 156, 232, 244, 249, 156, 240, 249, 248, 251, 249, 238 }, 188) : _0x43c61430._0x6a2a1ae7(new byte[36] { 183, 164, 183, 160, 171, 210, 161, 162, 187, 188, 210, 179, 188, 182, 210, 183, 164, 183, 160, 171, 210, 190, 187, 188, 183, 210, 179, 182, 182, 161, 210, 166, 189, 210, 187, 166 }, 242));
    }

    private TextMeshProUGUI _0xe401603d;
    private const float XpBarWidth = 940f;
    private TextMeshProUGUI _0xfb82d5b6;
}

internal static class _0x43c61430
{
    internal static string _0x6a2a1ae7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}