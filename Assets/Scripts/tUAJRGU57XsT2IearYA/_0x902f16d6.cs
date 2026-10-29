using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The first screen of a first launch: who this is for and what the credits are not.
/// Shown once; after that the lobby is the home page.
/// </summary>
public sealed class _0x902f16d6 : MonoBehaviour, _0x5ed4f0d4
{
    private void _0xdeecbb74()
    {
        _0xdfbe9389._0x29469462 = true;
        if (this._0x703729dc != null && !_0xdfbe9389._0x5fbcf839)
        {
            this._0x703729dc.DOColor(_0x3fe280fb.Cream, 0.18f).SetLoops(2, LoopType.Yoyo).SetLink(this._0x703729dc.gameObject);
        }

        _0xaf5af43d.Tick();
        if (this._0xd51f0c55 != null)
        {
            this._0xd51f0c55._0x08ea87b9();
        }
    }

    private _0x9fb34e44 _0x01e8e611;
    private Image _0x703729dc;
    public void Refresh()
    {
    }

    public void _0xb44d0907(_0xe0927a8a _0x38c9e740, _0xf84cb8b0 _0xe947ae65, _0x9fb34e44 _0x6cf71738)
    {
        this._0xd51f0c55 = _0xe947ae65;
        RectTransform _0x5b632219 = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0x5b632219, _0x27af6682._0x19b88773(new byte[5] { 102, 65, 91, 93, 75 }, 46), _0x38c9e740._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0x5b632219, _0x27af6682._0x19b88773(new byte[5] { 167, 151, 134, 157, 153 }, 244), _0x38c9e740._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Ink, 0.82f), 0f, 2.0f);
        this._0x01e8e611 = Instantiate(_0x6cf71738, _0x5b632219, false);
        RectTransform _0xdc97cbac = this._0x01e8e611._0x7693cccd;
        _0xdc97cbac.anchorMin = new Vector2(0.5f, 0.60f);
        _0xdc97cbac.anchorMax = new Vector2(0.5f, 0.60f);
        _0xdc97cbac.anchoredPosition = Vector2.zero;
        this._0x01e8e611._0x0d1f6abd(new Vector2(1080f, 1420f));
        this._0x01e8e611._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0x6bb1c057 = this._0x01e8e611._0xf9550e0d;
        this._0x703729dc = _0x98589ea5.Picture(_0x6bb1c057, _0x27af6682._0x19b88773(new byte[5] { 158, 175, 184, 174, 169 }, 221), _0x38c9e740._0x9f010034, _0x3fe280fb.GoldLight, new Vector2(0.5f, 1f), new Vector2(0f, -190f), new Vector2(230f, 230f));
        _0x98589ea5.Label(_0x6bb1c057, _0x27af6682._0x19b88773(new byte[9] { 185, 136, 159, 137, 142, 183, 155, 136, 145 }, 250), _0x27af6682._0x19b88773(new byte[3] { 35, 42, 57 }, 18), _0x2da34b06.NumberMax, _0x2da34b06.NumberMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -352f), new Vector2(300f, 80f));
        _0x98589ea5.Label(_0x6bb1c057, _0x27af6682._0x19b88773(new byte[5] { 186, 135, 154, 130, 139 }, 238), _0x27af6682._0x19b88773(new byte[15] { 120, 125, 108, 117, 109, 106, 25, 118, 119, 117, 96, 51, 8, 1, 18 }, 57), _0x2da34b06.TitleMax, _0x2da34b06.TitleMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -500f), new Vector2(940f, 210f));
        _0x98589ea5.Label(_0x6bb1c057, _0x27af6682._0x19b88773(new byte[4] { 14, 35, 40, 53 }, 76), _0x27af6682._0x19b88773(new byte[201] { 205, 209, 208, 202, 185, 208, 202, 185, 216, 185, 202, 214, 218, 208, 216, 213, 185, 220, 215, 205, 220, 203, 205, 216, 208, 215, 212, 220, 215, 205, 185, 216, 201, 201, 183, 147, 218, 203, 220, 221, 208, 205, 202, 185, 216, 203, 220, 185, 207, 208, 203, 205, 204, 216, 213, 185, 216, 215, 221, 185, 223, 203, 220, 220, 183, 147, 215, 214, 205, 209, 208, 215, 222, 185, 209, 220, 203, 220, 185, 218, 216, 215, 185, 219, 220, 185, 219, 214, 204, 222, 209, 205, 181, 147, 206, 208, 205, 209, 221, 203, 216, 206, 215, 185, 214, 203, 185, 220, 193, 218, 209, 216, 215, 222, 220, 221, 183, 147, 215, 214, 185, 203, 220, 216, 213, 185, 212, 214, 215, 220, 192, 181, 185, 215, 214, 185, 201, 203, 208, 195, 220, 202, 183, 147, 147, 201, 203, 216, 218, 205, 208, 218, 220, 185, 209, 220, 203, 220, 185, 221, 214, 220, 202, 185, 215, 214, 205, 185, 201, 203, 220, 221, 208, 218, 205, 147, 202, 204, 218, 218, 220, 202, 202, 185, 216, 205, 185, 216, 215, 192, 205, 209, 208, 215, 222, 185, 220, 213, 202, 220, 183 }, 153), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0f, -900f), new Vector2(960f, 420f));
        _0x98589ea5.Label(_0x5b632219, _0x27af6682._0x19b88773(new byte[8] { 37, 18, 22, 4, 4, 2, 5, 18 }, 119), _0x27af6682._0x19b88773(new byte[37] { 77, 82, 73, 79, 78, 90, 87, 59, 88, 73, 94, 95, 82, 79, 72, 59, 84, 85, 87, 66, 59, 54, 59, 85, 84, 79, 83, 82, 85, 92, 59, 79, 84, 59, 89, 78, 66 }, 27), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Gold, TextAlignmentOptions.Center, new Vector2(0.5f, 0.245f), Vector2.zero, new Vector2(1060f, 58f));
        // Deliberately clear of the lobby's main-button band: the two screens must never
        // share a tap point, or a capture that skips the notice taps straight into the game.
        Button _0x892e4205 = _0x98589ea5.Cta(_0x5b632219, _0x27af6682._0x19b88773(new byte[6] { 114, 80, 80, 86, 67, 71 }, 51), _0x27af6682._0x19b88773(new byte[16] { 42, 67, 34, 46, 67, 82, 91, 67, 44, 49, 67, 44, 47, 39, 38, 49 }, 99), _0x38c9e740._0x24421334, null, _0x3fe280fb.Gold, _0x3fe280fb.Cream, new Vector2(0.5f, 0.135f), Vector2.zero, new Vector2(760f, 160f), 1.6f);
        _0x98589ea5.OnTap(_0x892e4205, () => this._0xdeecbb74());
        _0x98589ea5.Label(_0x5b632219, _0x27af6682._0x19b88773(new byte[5] { 63, 4, 14, 15, 24 }, 106), _0x27af6682._0x19b88773(new byte[33] { 237, 226, 225, 253, 235, 142, 250, 230, 235, 142, 239, 254, 254, 142, 231, 232, 142, 247, 225, 251, 142, 239, 252, 235, 142, 251, 224, 234, 235, 252, 142, 159, 150 }, 174), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.135f), new Vector2(0f, -120f), new Vector2(1000f, 52f));
    }

    private void OnDestroy()
    {
        if (this._0x703729dc != null)
        {
            DOTween.Kill(this._0x703729dc);
        }
    }

    private _0xf84cb8b0 _0xd51f0c55;
}

internal static class _0x27af6682
{
    internal static string _0x19b88773(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}