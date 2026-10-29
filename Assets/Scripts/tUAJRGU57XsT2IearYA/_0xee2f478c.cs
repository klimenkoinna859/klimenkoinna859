using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The home page: what you have, what tonight's bill is, and eight doors into the
/// rest of the house. The PLAY button itself is the template's own scene-load button,
/// dressed by the menu director - the lobby deliberately leaves its slot empty so two
/// elements never share one place.
/// </summary>
public sealed class _0xee2f478c : MonoBehaviour, _0x5ed4f0d4
{
    private readonly List<_0x9fb34e44> _0xa83d5012 = new List<_0x9fb34e44>();
    private void _0x6e99fdfd(int _0x4e775fae, string _0xf82af106, bool _0xc4f3c678)
    {
        if (_0x4e775fae < this._0xec1f247b.Count)
        {
            _0xd6a1e4cb.SetText(this._0xec1f247b[_0x4e775fae], _0xf82af106);
        }

        if (_0x4e775fae < this._0xa83d5012.Count)
        {
            this._0xa83d5012[_0x4e775fae]._0x3a14c276(_0xc4f3c678);
        }
    }

    /// <summary>The lobby settles in rather than snapping, so the first frame has life.</summary>
    private void _0xe3ebc8fc()
    {
        if (_0xdfbe9389._0x5fbcf839)
        {
            return;
        }

        for (int _0x01390135 = 0; _0x01390135 < this._0xa83d5012.Count; _0x01390135++)
        {
            Transform _0xf0da93df = this._0xa83d5012[_0x01390135]._0x7693cccd;
            _0xf0da93df.DOKill(false);
            _0xf0da93df.localScale = new Vector3(0.94f, 0.94f, 1f);
            _0xf0da93df.DOScale(1f, 0.38f).SetEase(Ease.OutBack).SetDelay(0.05f * _0x01390135).SetLink(_0xf0da93df.gameObject);
        }
    }

    private void _0xa2908706(int _0x07dafb75)
    {
        _0xaf5af43d.Tick();
        if (this._0x531d9c50 != null)
        {
            this._0x531d9c50.Show(_0x07dafb75);
        }
    }

    public void Refresh()
    {
        _0xb29ed313.EnsureToday();
        _0xd6a1e4cb.SetText(this._0xd3268307, _0x2da34b06.Grouped(_0xdfbe9389._0x8d6a1c71));
        _0xd6a1e4cb.SetText(this._0x47058d4b, _0xa833fd46._0x262ac57e(new byte[5] { 70, 85, 90, 95, 52 }, 20) + _0xf7dacd0a._0xd708b43a);
        _0xd6a1e4cb.SetText(this._0x1fa500f8, _0xa833fd46._0x262ac57e(new byte[17] { 54, 58, 56, 37, 57, 48, 33, 48, 85, 52, 59, 85, 52, 54, 33, 79, 85 }, 117) + _0x2da34b06.ActStarGoal + _0xa833fd46._0x262ac57e(new byte[10] { 104, 27, 28, 9, 26, 27, 104, 1, 6, 104 }, 72) + _0x2da34b06.SpinBudget + _0xa833fd46._0x262ac57e(new byte[6] { 214, 165, 166, 191, 184, 165 }, 246));
        bool _0x156dceff = _0x16434292.GiftReady();
        bool _0xbf438234 = _0xb29ed313.AnyClaimable();
        this._0x6e99fdfd(0, _0xf7dacd0a.UnlockedActCount() + _0xa833fd46._0x262ac57e(new byte[5] { 195, 162, 160, 183, 176 }, 227), false);
        this._0x6e99fdfd(1, _0x156dceff ? _0xa833fd46._0x262ac57e(new byte[5] { 60, 43, 47, 42, 55 }, 110) : _0x16434292.CooldownText(), _0x156dceff);
        this._0x6e99fdfd(2, _0xb29ed313.ClaimedCount() + _0xa833fd46._0x262ac57e(new byte[3] { 175, 160, 175 }, 143) + _0x2da34b06.MissionCount + _0xa833fd46._0x262ac57e(new byte[5] { 233, 141, 134, 135, 140 }, 201), _0xbf438234);
        this._0x6e99fdfd(3, _0xf7dacd0a.CardsOwned() + _0xa833fd46._0x262ac57e(new byte[3] { 141, 130, 141 }, 173) + _0x2da34b06.CardCount + _0xa833fd46._0x262ac57e(new byte[6] { 206, 173, 175, 188, 170, 189 }, 238), false);
        this._0x6e99fdfd(4, _0xa833fd46._0x262ac57e(new byte[5] { 243, 224, 239, 234, 129 }, 161) + _0xf7dacd0a._0xd708b43a, false);
        this._0x6e99fdfd(5, _0xf7dacd0a.AliasName(_0xdfbe9389._0xd3b1284a), false);
        this._0x6e99fdfd(6, _0xa833fd46._0x262ac57e(new byte[12] { 128, 135, 159, 232, 129, 156, 232, 159, 135, 154, 131, 155 }, 200), false);
        this._0x6e99fdfd(7, _0xa833fd46._0x262ac57e(new byte[11] { 74, 72, 95, 92, 95, 72, 95, 84, 89, 95, 73 }, 26), false);
        this._0xe3ebc8fc();
    }

    private TextMeshProUGUI _0x47058d4b;
    public void _0xcbe50b66(_0xe0927a8a _0x20db3026, _0xf84cb8b0 _0xc8dd8e3b, _0x9fb34e44 _0x50257729)
    {
        this._0x531d9c50 = _0xc8dd8e3b;
        this._0xb0e66c16 = _0x20db3026;
        RectTransform _0xe06f2f9a = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0xe06f2f9a, _0xa833fd46._0x262ac57e(new byte[5] { 132, 163, 185, 191, 169 }, 204), _0x20db3026._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0xe06f2f9a, _0xa833fd46._0x262ac57e(new byte[9] { 75, 108, 118, 112, 102, 84, 98, 112, 107 }, 3), _0x20db3026._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.42f), 0f, 2.0f);
        this._0x1f504057(_0x20db3026, _0x50257729, _0xe06f2f9a);
        _0x98589ea5.Picture(_0xe06f2f9a, _0xa833fd46._0x262ac57e(new byte[6] { 137, 161, 174, 160, 169, 161 }, 204), _0x20db3026._0x9f010034, Color.white, _0x98589ea5.TopCentre, new Vector2(0f, -430f), new Vector2(280f, 280f));
        _0x98589ea5.Label(_0xe06f2f9a, _0xa833fd46._0x262ac57e(new byte[4] { 166, 141, 136, 136 }, 228), _0xa833fd46._0x262ac57e(new byte[14] { 196, 223, 222, 217, 215, 216, 196, 183, 195, 176, 210, 217, 220, 220 }, 144), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.Gold, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, -600f), new Vector2(860f, 66f));
        this._0x1a2d21c2(_0x20db3026, _0x50257729, _0xe06f2f9a);
        this._0x1fa500f8 = _0x98589ea5.Label(_0xe06f2f9a, _0xa833fd46._0x262ac57e(new byte[9] { 169, 132, 140, 131, 133, 146, 143, 144, 131 }, 230), _0xa833fd46._0x262ac57e(new byte[37] { 68, 72, 74, 87, 75, 66, 83, 66, 39, 70, 73, 39, 70, 68, 83, 61, 39, 54, 53, 39, 84, 83, 70, 85, 84, 39, 78, 73, 39, 53, 50, 39, 84, 87, 78, 73, 84 }, 7), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, -1730f), new Vector2(1060f, 58f));
        // The footlight strip fills the floor under the main button instead of dead space.
        _0x98589ea5.Plate(_0xe06f2f9a, _0xa833fd46._0x262ac57e(new byte[10] { 129, 168, 168, 179, 171, 174, 160, 175, 179, 180 }, 199), _0x20db3026._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Gold, 0.09f), _0x98589ea5.BottomCentre, new Vector2(0f, 110f), new Vector2(1242f, 260f), 1.2f);
        _0x98589ea5.Plate(_0xe06f2f9a, _0xa833fd46._0x262ac57e(new byte[9] { 89, 105, 122, 104, 104, 73, 110, 119, 126 }, 27), _0x20db3026._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.50f), _0x98589ea5.BottomCentre, new Vector2(0f, 300f), new Vector2(1000f, 5f), 1.0f);
        _0x98589ea5.Label(_0xe06f2f9a, _0xa833fd46._0x262ac57e(new byte[6] { 187, 146, 146, 137, 152, 143 }, 253), _0xa833fd46._0x262ac57e(new byte[36] { 228, 251, 224, 230, 231, 243, 254, 146, 241, 224, 247, 246, 251, 230, 225, 146, 253, 252, 254, 235, 146, 159, 146, 252, 253, 146, 224, 247, 243, 254, 146, 255, 253, 252, 247, 235 }, 178), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.BottomCentre, new Vector2(0f, 120f), new Vector2(1060f, 52f));
    }

    private void _0x1a2d21c2(_0xe0927a8a _0x206f731d, _0x9fb34e44 _0x54e796bb, Transform _0x9da7d708)
    {
        string[] _0x5dc14c7d = new string[]
        {
            _0xa833fd46._0x262ac57e(new byte[7] { 124, 121, 114, 98, 113, 98, 105 }, 48),
            _0xa833fd46._0x262ac57e(new byte[10] { 149, 144, 152, 157, 136, 241, 150, 152, 151, 133 }, 209),
            _0xa833fd46._0x262ac57e(new byte[8] { 84, 80, 74, 74, 80, 86, 87, 74 }, 25),
            _0xa833fd46._0x262ac57e(new byte[10] { 43, 39, 36, 36, 45, 43, 60, 33, 39, 38 }, 104),
            _0xa833fd46._0x262ac57e(new byte[8] { 252, 254, 227, 235, 254, 233, 255, 255 }, 172),
            _0xa833fd46._0x262ac57e(new byte[7] { 210, 208, 205, 196, 203, 206, 199 }, 130),
            _0xa833fd46._0x262ac57e(new byte[5] { 208, 215, 206, 199, 209 }, 130),
            _0xa833fd46._0x262ac57e(new byte[8] { 8, 30, 15, 15, 18, 21, 28, 8 }, 91)
        };
        int[] _0x233e9b53 = new int[]
        {
            _0xf84cb8b0.PageLibrary,
            _0xf84cb8b0.PageGift,
            _0xf84cb8b0.PageMissions,
            _0xf84cb8b0.PageCollection,
            _0xf84cb8b0.PageProgress,
            _0xf84cb8b0.PageProfile,
            _0xf84cb8b0.PageRules,
            _0xf84cb8b0.PageSettings
        };
        for (int _0xf3557424 = 0; _0xf3557424 < _0x5dc14c7d.Length; _0xf3557424++)
        {
            int _0x80fe1fe4 = _0xf3557424 % 2;
            int _0xa8321a32 = _0xf3557424 / 2;
            float _0x68dfc8b8 = _0x80fe1fe4 == 0 ? -275f : 275f;
            float _0x2124c4ab = -787.5f - _0xa8321a32 * 245f;
            _0x9fb34e44 _0x512d737e = Instantiate(_0x54e796bb, _0x9da7d708, false);
            RectTransform _0xf8cb2cbf = _0x512d737e._0x7693cccd;
            _0xf8cb2cbf.anchorMin = _0x98589ea5.TopCentre;
            _0xf8cb2cbf.anchorMax = _0x98589ea5.TopCentre;
            _0xf8cb2cbf.anchoredPosition = new Vector2(_0x68dfc8b8, _0x2124c4ab);
            _0x512d737e._0x0d1f6abd(new Vector2(520f, 215f));
            _0x512d737e._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
            Transform _0xac98fc1a = _0x512d737e._0xf9550e0d;
            // Indicator gutter and text column never share an x-band (§C.25):
            // the pip ends at -190, the text box starts at -164.
            _0x98589ea5.Plate(_0xac98fc1a, _0xa833fd46._0x262ac57e(new byte[3] { 215, 238, 247 }, 135), _0x206f731d._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Gold, 0.85f), _0x98589ea5.Centre, new Vector2(-200f, 0f), new Vector2(20f, 86f), 1.0f);
            _0x98589ea5.Label(_0xac98fc1a, _0xa833fd46._0x262ac57e(new byte[4] { 51, 28, 16, 24 }, 125), _0x5dc14c7d[_0xf3557424], _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(36f, 30f), new Vector2(400f, 54f));
            TextMeshProUGUI _0xf15a632f = _0x98589ea5.Label(_0xac98fc1a, _0xa833fd46._0x262ac57e(new byte[6] { 117, 82, 71, 82, 83, 85 }, 38), _0xa833fd46._0x262ac57e(new byte[1] { 241 }, 220), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(36f, -36f), new Vector2(400f, 44f));
            Image _0x71691f5e = _0xac98fc1a.gameObject.AddComponent<Image>();
            _0x71691f5e.sprite = _0x206f731d._0xfa9196f7;
            _0x71691f5e.type = Image.Type.Sliced;
            _0x71691f5e.pixelsPerUnitMultiplier = 2.2f;
            _0x71691f5e.color = new Color(1f, 1f, 1f, 0f);
            _0x71691f5e.raycastTarget = true;
            Button _0xbbad59ff = _0xac98fc1a.gameObject.AddComponent<Button>();
            _0xbbad59ff.targetGraphic = _0x71691f5e;
            _0xbbad59ff.transition = Selectable.Transition.None;
            int _0xfe4a5c53 = _0x233e9b53[_0xf3557424];
            _0x98589ea5.OnTap(_0xbbad59ff, () => this._0xa2908706(_0xfe4a5c53));
            this._0xa83d5012.Add(_0x512d737e);
            this._0xec1f247b.Add(_0xf15a632f);
        }
    }

    private _0xe0927a8a _0xb0e66c16;
    private readonly List<TextMeshProUGUI> _0xec1f247b = new List<TextMeshProUGUI>();
    private TextMeshProUGUI _0x1fa500f8;
    private TextMeshProUGUI _0xd3268307;
    private _0xf84cb8b0 _0x531d9c50;
    private void _0x1f504057(_0xe0927a8a _0x46e533e9, _0x9fb34e44 _0x1c992a85, Transform _0x8f7e4ce6)
    {
        _0x9fb34e44 _0x8d631e1f = Instantiate(_0x1c992a85, _0x8f7e4ce6, false);
        RectTransform _0x55bb3603 = _0x8d631e1f._0x7693cccd;
        _0x55bb3603.anchorMin = _0x98589ea5.TopCentre;
        _0x55bb3603.anchorMax = _0x98589ea5.TopCentre;
        _0x55bb3603.anchoredPosition = new Vector2(0f, -160f);
        _0x8d631e1f._0x0d1f6abd(new Vector2(1080f, 150f));
        _0x8d631e1f._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0xe6800a21 = _0x8d631e1f._0xf9550e0d;
        _0x98589ea5.Picture(_0xe6800a21, _0xa833fd46._0x262ac57e(new byte[4] { 140, 167, 166, 191 }, 207), _0x46e533e9._0x294d71d8(0), _0x3fe280fb.GoldLight, _0x98589ea5.Centre, new Vector2(-460f, 0f), new Vector2(72f, 72f));
        _0x98589ea5.Label(_0xe6800a21, _0xa833fd46._0x262ac57e(new byte[14] { 164, 149, 130, 131, 142, 147, 148, 164, 134, 151, 147, 142, 136, 137 }, 231), _0xa833fd46._0x262ac57e(new byte[7] { 98, 115, 100, 101, 104, 117, 114 }, 33), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(-250f, 34f), new Vector2(280f, 40f));
        this._0xd3268307 = _0x98589ea5.Label(_0xe6800a21, _0xa833fd46._0x262ac57e(new byte[12] { 221, 236, 251, 250, 247, 234, 237, 200, 255, 242, 235, 251 }, 158), _0xa833fd46._0x262ac57e(new byte[1] { 111 }, 95), _0x2da34b06.NumberMax, _0x2da34b06.NumberMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(-230f, -26f), new Vector2(320f, 74f));
        _0x98589ea5.Plate(_0xe6800a21, _0xa833fd46._0x262ac57e(new byte[7] { 158, 173, 162, 167, 156, 165, 188 }, 204), _0x46e533e9._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.75f), _0x98589ea5.Centre, new Vector2(150f, 0f), new Vector2(26f, 26f), 1.0f);
        this._0x47058d4b = _0x98589ea5.Label(_0xe6800a21, _0xa833fd46._0x262ac57e(new byte[9] { 189, 142, 129, 132, 185, 142, 131, 154, 138 }, 239), _0xa833fd46._0x262ac57e(new byte[6] { 53, 38, 41, 44, 71, 86 }, 103), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Right, _0x98589ea5.Centre, new Vector2(330f, 0f), new Vector2(300f, 56f));
    }

    private void OnDestroy()
    {
        for (int _0x7c6596b7 = 0; _0x7c6596b7 < this._0xa83d5012.Count; _0x7c6596b7++)
        {
            if (this._0xa83d5012[_0x7c6596b7] != null)
            {
                DOTween.Kill(this._0xa83d5012[_0x7c6596b7]._0x7693cccd);
            }
        }
    }
}

internal static class _0xa833fd46
{
    internal static string _0x262ac57e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}