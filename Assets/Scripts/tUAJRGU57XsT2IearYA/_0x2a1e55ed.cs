using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The bill: three acts to choose from. Choosing one sets the act index, which seeds
/// the reel strips and the live lines, so the choice really changes the board.
/// </summary>
public sealed class _0x2a1e55ed : MonoBehaviour, _0x5ed4f0d4
{
    private readonly List<Image> _0xb5f458ee = new List<Image>();
    public void Refresh()
    {
        int _0x199d9fb4 = _0xdfbe9389._0xf4d88f87;
        _0xd6a1e4cb.SetText(this._0x49842edb, _0xf7dacd0a.UnlockedActCount() + _0x547366d7._0x1b69e35c(new byte[4] { 240, 159, 150, 240 }, 208) + _0x2da34b06.ActCount + _0x547366d7._0x1b69e35c(new byte[14] { 39, 70, 68, 83, 84, 39, 82, 73, 75, 72, 68, 76, 66, 67 }, 7));
        for (int _0x03cb39d0 = 0; _0x03cb39d0 < this._0x68abf693.Count; _0x03cb39d0++)
        {
            bool _0xe31d8b75 = _0xf7dacd0a.ActUnlocked(_0x03cb39d0);
            bool _0xc52cccf9 = _0xe31d8b75 && _0x03cb39d0 == _0x199d9fb4;
            this._0x68abf693[_0x03cb39d0]._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, _0xe31d8b75 ? 1f : 0.55f);
            this._0x68abf693[_0x03cb39d0]._0x3a14c276(_0xc52cccf9);
            if (_0x03cb39d0 < this._0xb5f458ee.Count && this._0xb5f458ee[_0x03cb39d0] != null)
            {
                this._0xb5f458ee[_0x03cb39d0].color = _0xe31d8b75 ? _0x3fe280fb.Fade(Color.white, _0xc52cccf9 ? 1f : 0.7f) : _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.6f);
            }

            _0xd6a1e4cb.SetText(this._0xc8a5f75d[_0x03cb39d0], _0xe31d8b75 ? (_0xc52cccf9 ? _0x547366d7._0x1b69e35c(new byte[10] { 27, 26, 116, 0, 27, 26, 29, 19, 28, 0 }, 84) : _0x547366d7._0x1b69e35c(new byte[5] { 182, 161, 165, 160, 189 }, 228)) : _0x547366d7._0x1b69e35c(new byte[15] { 145, 138, 136, 139, 135, 143, 228, 133, 144, 228, 150, 133, 138, 143, 228 }, 196) + _0xfe7794e1.RequiredRank(_0x03cb39d0));
            Button _0x2ed02b10 = this._0x44859a15[_0x03cb39d0];
            if (_0x2ed02b10 != null)
            {
                _0x2ed02b10.interactable = _0xe31d8b75 && !_0xc52cccf9;
                Image _0xae5690ec = _0x2ed02b10.GetComponent<Image>();
                if (_0xae5690ec != null)
                {
                    _0xae5690ec.color = _0xe31d8b75 ? (_0xc52cccf9 ? _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.9f) : _0x3fe280fb.Gold) : _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.55f);
                }

                TMP_Text _0x7b2806b0 = _0x2ed02b10.GetComponentInChildren<TMP_Text>(true);
                if (_0x7b2806b0 != null)
                {
                    _0xd6a1e4cb.SetText(_0x7b2806b0, _0xe31d8b75 ? (_0xc52cccf9 ? _0x547366d7._0x1b69e35c(new byte[10] { 218, 219, 181, 193, 218, 219, 220, 210, 221, 193 }, 149) : _0x547366d7._0x1b69e35c(new byte[9] { 163, 166, 167, 211, 186, 167, 211, 188, 189 }, 243)) : _0x547366d7._0x1b69e35c(new byte[6] { 184, 187, 183, 191, 177, 176 }, 244));
                    _0x7b2806b0.color = _0xe31d8b75 ? _0x3fe280fb.Cream : _0x3fe280fb.CreamMuted;
                }
            }
        }
    }

    private TextMeshProUGUI _0x49842edb;
    public void _0x73764c8b(_0xe0927a8a _0xed8dc833, _0xf84cb8b0 _0xadb2eae9, _0x9fb34e44 _0x8408caef)
    {
        RectTransform _0xc0e67733 = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0xc0e67733, _0x547366d7._0x1b69e35c(new byte[5] { 23, 48, 42, 44, 58 }, 95), _0xed8dc833._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0xc0e67733, _0x547366d7._0x1b69e35c(new byte[4] { 239, 217, 203, 208 }, 184), _0xed8dc833._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.55f), 0f, 2.0f);
        _0xf84cb8b0.Header(_0xc0e67733, _0xed8dc833, _0xadb2eae9, _0x547366d7._0x1b69e35c(new byte[8] { 2, 30, 19, 118, 20, 31, 26, 26 }, 86), _0x547366d7._0x1b69e35c(new byte[31] { 86, 67, 82, 34, 67, 76, 34, 67, 65, 86, 34, 86, 77, 34, 82, 87, 86, 34, 75, 86, 34, 77, 76, 34, 86, 77, 76, 75, 69, 74, 86 }, 2));
        this._0x49842edb = _0x98589ea5.Label(_0xc0e67733, _0x547366d7._0x1b69e35c(new byte[8] { 140, 183, 181, 182, 186, 178, 188, 189 }, 217), _0x547366d7._0x1b69e35c(new byte[1] { 191 }, 146), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, -320f), new Vector2(1000f, 50f));
        for (int _0xfc0a1914 = 0; _0xfc0a1914 < _0x2da34b06.ActCount; _0xfc0a1914++)
        {
            this._0x17e144b6(_0xed8dc833, _0x8408caef, _0xc0e67733, _0xfc0a1914);
        }
    }

    private void _0x17e144b6(_0xe0927a8a _0xf87a698c, _0x9fb34e44 _0xb3c5466c, Transform _0x41ca4e18, int _0xc50d7641)
    {
        _0x9fb34e44 _0xf108927f = Instantiate(_0xb3c5466c, _0x41ca4e18, false);
        RectTransform _0xde887694 = _0xf108927f._0x7693cccd;
        _0xde887694.anchorMin = _0x98589ea5.TopCentre;
        _0xde887694.anchorMax = _0x98589ea5.TopCentre;
        _0xde887694.anchoredPosition = new Vector2(0f, -700f - _0xc50d7641 * 556f);
        _0xf108927f._0x0d1f6abd(new Vector2(1080f, 520f));
        _0xf108927f._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0xba6c2abc = _0xf108927f._0xf9550e0d;
        // Five brass pips in the gutter, one per payline. Gutter 41..83 from the card's
        // left edge; the text column starts at 129, so they never share an x-band.
        for (int _0x088a33ff = 0; _0x088a33ff < _0x2da34b06.ActiveLines; _0x088a33ff++)
        {
            float _0x840e07cb = 96f - _0x088a33ff * 48f;
            _0x98589ea5.Plate(_0xba6c2abc, _0x547366d7._0x1b69e35c(new byte[7] { 237, 200, 207, 196, 241, 200, 209 }, 161), _0xf87a698c._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.8f), _0x98589ea5.Centre, new Vector2(_0x2da34b06.GutterCentre - 540f, _0x840e07cb), new Vector2(_0x2da34b06.GutterWidth, 20f), 1.0f);
        }

        // Card body is 1080 wide. Text column 129..829 (700 wide), the act mark lives
        // alone in 325..475 measured from the centre - the two never share an x-band.
        const float _0x4760d2bf = 700f;
        float _0x66e7919d = _0x2da34b06.TextLeft + _0x4760d2bf * 0.5f - 540f;
        _0x98589ea5.Label(_0xba6c2abc, _0x547366d7._0x1b69e35c(new byte[7] { 115, 81, 70, 124, 83, 95, 87 }, 50), _0xfe7794e1.RequiredRank(_0xc50d7641) == 0 ? _0x547366d7._0x1b69e35c(new byte[15] { 102, 117, 124, 102, 117, 100, 16, 127, 102, 117, 98, 100, 101, 98, 117 }, 48) : (_0xc50d7641 == 1 ? _0x547366d7._0x1b69e35c(new byte[10] { 204, 220, 207, 221, 221, 174, 201, 207, 194, 207 }, 142) : _0x547366d7._0x1b69e35c(new byte[19] { 236, 232, 229, 239, 232, 230, 233, 245, 129, 236, 224, 242, 240, 244, 228, 243, 224, 229, 228 }, 161)), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(_0x66e7919d, 150f), new Vector2(_0x4760d2bf, 70f));
        _0x98589ea5.Label(_0xba6c2abc, _0x547366d7._0x1b69e35c(new byte[8] { 87, 117, 98, 69, 115, 98, 99, 102 }, 22), _0x547366d7._0x1b69e35c(new byte[17] { 86, 69, 55, 32, 32, 41, 54, 69, 72, 69, 80, 69, 41, 44, 43, 32, 54 }, 101), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(_0x66e7919d, 74f), new Vector2(_0x4760d2bf, 50f));
        _0x98589ea5.Label(_0xba6c2abc, _0x547366d7._0x1b69e35c(new byte[10] { 247, 213, 194, 240, 218, 215, 192, 217, 195, 196 }, 182), _0xfe7794e1.Flavour(_0xc50d7641), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(_0x66e7919d, 8f), new Vector2(_0x4760d2bf, 50f));
        Image _0xfd1a4764 = _0x98589ea5.Picture(_0xba6c2abc, _0x547366d7._0x1b69e35c(new byte[7] { 120, 90, 77, 116, 88, 75, 82 }, 57), _0xf87a698c._0x9f010034, _0x3fe280fb.Fade(Color.white, 0.85f), _0x98589ea5.Centre, new Vector2(400f, 112f), new Vector2(150f, 150f));
        TextMeshProUGUI _0x83acf6de = _0x98589ea5.Label(_0xba6c2abc, _0x547366d7._0x1b69e35c(new byte[8] { 19, 49, 38, 1, 38, 51, 38, 55 }, 82), _0x547366d7._0x1b69e35c(new byte[1] { 53 }, 24), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(_0x66e7919d, -60f), new Vector2(_0x4760d2bf, 46f));
        Button _0x7424e578 = _0x98589ea5.Cta(_0xba6c2abc, _0x547366d7._0x1b69e35c(new byte[6] { 156, 183, 176, 176, 172, 186 }, 223), _0x547366d7._0x1b69e35c(new byte[9] { 86, 83, 82, 38, 79, 82, 38, 73, 72 }, 6), _0xf87a698c._0x24421334, null, _0x3fe280fb.Gold, _0x3fe280fb.Cream, _0x98589ea5.Centre, new Vector2(_0x66e7919d - 60f, -150f), new Vector2(520f, 130f), 1.6f);
        int _0x72e601f0 = _0xc50d7641;
        _0x98589ea5.OnTap(_0x7424e578, () => this._0x5b7c0c16(_0x72e601f0));
        this._0x68abf693.Add(_0xf108927f);
        this._0xc8a5f75d.Add(_0x83acf6de);
        this._0xb5f458ee.Add(_0xfd1a4764);
        this._0x44859a15.Add(_0x7424e578);
    }

    private readonly List<TextMeshProUGUI> _0xc8a5f75d = new List<TextMeshProUGUI>();
    private void OnDestroy()
    {
        for (int _0xbdce691d = 0; _0xbdce691d < this._0xb5f458ee.Count; _0xbdce691d++)
        {
            if (this._0xb5f458ee[_0xbdce691d] != null)
            {
                DOTween.Kill(this._0xb5f458ee[_0xbdce691d].transform);
            }
        }
    }

    private readonly List<Button> _0x44859a15 = new List<Button>();
    private readonly List<_0x9fb34e44> _0x68abf693 = new List<_0x9fb34e44>();
    private void _0x5b7c0c16(int _0xbb2528a9)
    {
        if (!_0xf7dacd0a.ActUnlocked(_0xbb2528a9))
        {
            return;
        }

        _0xdfbe9389._0xf4d88f87 = _0xbb2528a9;
        _0xaf5af43d.Tick();
        this.Refresh();
        if (!_0xdfbe9389._0x5fbcf839 && _0xbb2528a9 < this._0xb5f458ee.Count && this._0xb5f458ee[_0xbb2528a9] != null)
        {
            this._0xb5f458ee[_0xbb2528a9].transform.DOPunchScale(new Vector3(0.2f, 0.2f, 0f), 0.3f, 6, 0.6f).SetLink(this._0xb5f458ee[_0xbb2528a9].gameObject);
        }
    }
}

internal static class _0x547366d7
{
    internal static string _0x1b69e35c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}