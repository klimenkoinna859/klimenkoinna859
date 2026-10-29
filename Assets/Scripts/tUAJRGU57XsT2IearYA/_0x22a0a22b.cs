using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// Dresses the three pops this template guarantees - PAUSE 6, WIN 7, LOSE 8 - in this
/// game's own words and colours.
///
/// Three traps this works around, all of them silent:
///  * Pop.Awake leaves Content INACTIVE, and a TMP label built into a dead hierarchy
///    has never run Awake. Content is woken before anything is built into it.
///  * Pop.Show kills the body's tweens with complete:true, which fires a half-finished
///    Hide and switches the body straight back off. The body is killed without
///    completing and its scale reset before the pop is raised.
///  * The template's own action buttons already carry drivers (reload this scene, hide
///    the pop, load scene 0). Adding listeners here would double-fire them, so their
///    captions are set in the scene and their behaviour is left exactly as it ships.
/// </summary>
public sealed class _0x22a0a22b : MonoBehaviour
{
    private readonly List<int> _0x05a3d9a8 = new List<int>();
    public void _0x2406c1e9(int _0x1550b586, int _0xf0c167e4)
    {
        if (_0x18ece92a.Instance == null)
        {
            return;
        }

        _0x84a83be7 _0x987b0510 = _0x18ece92a.Instance._0xd86b69da(_0xdfe619ff._0xdfb977df.WIN);
        this._0xde4c04f9(_0xdfe619ff._0xdfb977df.WIN, _0x987b0510, _0x10bab297._0x67d4b257(new byte[12] { 37, 51, 52, 50, 39, 47, 40, 70, 37, 39, 42, 42 }, 102), _0x10bab297._0x67d4b257(new byte[12] { 103, 101, 114, 6, 101, 105, 107, 118, 106, 99, 114, 99 }, 38), _0x1550b586 + _0x10bab297._0x67d4b257(new byte[6] { 144, 227, 228, 241, 226, 227 }, 176), _0x10bab297._0x67d4b257(new byte[15] { 108, 112, 125, 24, 112, 119, 109, 107, 125, 24, 104, 121, 113, 124, 24 }, 56) + _0x2da34b06.Grouped(_0xf0c167e4) + _0x10bab297._0x67d4b257(new byte[16] { 55, 84, 69, 82, 83, 94, 67, 68, 55, 67, 88, 89, 94, 80, 95, 67 }, 23));
        _0x18ece92a.Instance._0x97e1675c(_0xdfe619ff._0xdfb977df.WIN);
        _0xaf5af43d.Tick();
    }

    private readonly Dictionary<int, TextMeshProUGUI> _0x9351c374 = new Dictionary<int, TextMeshProUGUI>();
    public void _0xd170bdd8(int _0xd10f0550, int _0x5a5f32c5)
    {
        if (_0x18ece92a.Instance == null)
        {
            return;
        }

        _0x84a83be7 _0x166e4c26 = _0x18ece92a.Instance._0xd86b69da(_0xdfe619ff._0xdfb977df.LOSE);
        this._0xde4c04f9(_0xdfe619ff._0xdfb977df.LOSE, _0x166e4c26, _0x10bab297._0x67d4b257(new byte[10] { 11, 30, 20, 26, 127, 30, 127, 29, 16, 8 }, 95), _0x10bab297._0x67d4b257(new byte[14] { 129, 131, 148, 224, 149, 142, 134, 137, 142, 137, 147, 136, 133, 132 }, 192), _0xd10f0550 + _0x10bab297._0x67d4b257(new byte[3] { 2, 13, 2 }, 34) + _0x2da34b06.ActStarGoal + _0x10bab297._0x67d4b257(new byte[6] { 89, 42, 45, 56, 43, 42 }, 121), _0x5a5f32c5 + _0x10bab297._0x67d4b257(new byte[32] { 242, 133, 155, 156, 156, 155, 156, 149, 242, 158, 155, 156, 151, 129, 242, 255, 242, 147, 158, 158, 242, 129, 130, 155, 156, 129, 242, 129, 130, 151, 156, 134 }, 210));
        _0x18ece92a.Instance._0x97e1675c(_0xdfe619ff._0xdfb977df.LOSE);
        _0xaf5af43d.Tick();
    }

    private void _0xde4c04f9(int _0xbd9d7809, _0x84a83be7 _0xcd9841ba, string _0xff83ae5d, string _0x7b685e6d, string _0xcdffb2a1, string _0x0218bcc7)
    {
        if (_0xcd9841ba == null)
        {
            return;
        }

        this._0xb0f191f2(_0xbd9d7809, _0xcd9841ba);
        _0xd6a1e4cb.SetText(_0xcd9841ba.ContentHeaderText, _0xff83ae5d);
        _0xd6a1e4cb.SetText(_0xcd9841ba.ContentMainText, _0x7b685e6d);
        _0xd6a1e4cb.SetText(_0xcd9841ba.ContentAdditionalText, _0xcdffb2a1);
        TextMeshProUGUI _0xb47a6698;
        if (this._0x9351c374.TryGetValue(_0xbd9d7809, out _0xb47a6698))
        {
            _0xd6a1e4cb.SetText(_0xb47a6698, _0x0218bcc7);
        }

        if (_0xcd9841ba.Content != null)
        {
            DOTween.Kill(_0xcd9841ba.Content.transform);
            _0xcd9841ba.Content.SetActive(true);
            _0xcd9841ba.Content.transform.localScale = Vector3.zero;
        }
    }

    /// <summary>Themes one pop once: a card in this game's colours plus an extra line.</summary>
    private void _0xb0f191f2(int _0x3a8621dc, _0x84a83be7 _0x41fd645e)
    {
        if (_0x41fd645e == null || _0x41fd645e.Content == null || this._0x05a3d9a8.Contains(_0x3a8621dc))
        {
            return;
        }

        this._0x05a3d9a8.Add(_0x3a8621dc);
        _0x41fd645e.Content.SetActive(true);
        Transform _0x2dc5372a = _0x41fd645e.Content.transform;
        // The card: our own object, inserted just above the template's backing plate so
        // the pop reads as this game whatever the shared BASE_PANEL looks like.
        RectTransform _0x3df3cbb6 = _0x98589ea5.Node(_0x2dc5372a, _0x10bab297._0x67d4b257(new byte[7] { 193, 227, 244, 195, 225, 242, 228 }, 128), _0x98589ea5.Centre, Vector2.zero, new Vector2(1118f, 1011f));
        _0x3df3cbb6.SetSiblingIndex(1);
        _0x98589ea5.Plate(_0x3df3cbb6, _0x10bab297._0x67d4b257(new byte[10] { 1, 35, 48, 38, 17, 42, 35, 38, 45, 53 }, 66), this._0x27efd194._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Ink, 0.45f), _0x98589ea5.Centre, new Vector2(0f, -14f), new Vector2(1130f, 1020f), 2.0f);
        _0x98589ea5.Plate(_0x3df3cbb6, _0x10bab297._0x67d4b257(new byte[8] { 241, 211, 192, 214, 240, 221, 214, 203 }, 178), this._0x27efd194._0xfa9196f7, _0x3fe280fb.Burgundy, _0x98589ea5.Centre, Vector2.zero, new Vector2(1118f, 1011f), 2.2f);
        _0x98589ea5.Plate(_0x3df3cbb6, _0x10bab297._0x67d4b257(new byte[8] { 216, 250, 233, 255, 204, 250, 232, 243 }, 155), this._0x27efd194._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.55f), _0x98589ea5.Centre, new Vector2(0f, -250f), new Vector2(1094f, 500f), 2.4f);
        _0x98589ea5.Plate(_0x3df3cbb6, _0x10bab297._0x67d4b257(new byte[7] { 206, 236, 255, 233, 223, 228, 224 }, 141), this._0x27efd194._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.55f), _0x98589ea5.Centre, Vector2.zero, new Vector2(1118f, 1011f), 2.6f);
        _0x98589ea5.Picture(_0x3df3cbb6, _0x10bab297._0x67d4b257(new byte[8] { 237, 207, 220, 202, 227, 207, 220, 197 }, 174), this._0x27efd194._0x9f010034, _0x3fe280fb.Fade(Color.white, 0.20f), _0x98589ea5.Centre, new Vector2(0f, 170f), new Vector2(400f, 400f));
        TextMeshProUGUI _0x68d6f7d9 = _0x98589ea5.Label(_0x2dc5372a, _0x10bab297._0x67d4b257(new byte[9] { 12, 49, 61, 59, 40, 5, 32, 39, 44 }, 73), _0x10bab297._0x67d4b257(new byte[1] { 235 }, 198), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, -120f), new Vector2(960f, 60f));
        this._0x9351c374[_0x3a8621dc] = _0x68d6f7d9;
        this._0x2f09e491(_0x41fd645e);
        this._0x0318f885(_0x41fd645e.ContentHeaderText, _0x3fe280fb.GoldLight, _0x2da34b06.TitleMax, _0x2da34b06.TitleMin);
        this._0x0318f885(_0x41fd645e.ContentMainText, _0x3fe280fb.Cream, _0x2da34b06.SectionMax, _0x2da34b06.SectionMin);
        this._0x0318f885(_0x41fd645e.ContentAdditionalText, _0x3fe280fb.GoldLight, _0x2da34b06.SectionMax, _0x2da34b06.SectionMin);
    }

    private void _0x0318f885(TMP_Text _0xaced0278, Color _0xd87ac00e, float _0x91d04a67, float _0xf723eab6)
    {
        if (_0xaced0278 == null)
        {
            return;
        }

        _0xd6a1e4cb.Apply(_0xaced0278, _0xd87ac00e, _0x91d04a67, _0xf723eab6);
        _0xaced0278.alignment = TextAlignmentOptions.Center;
    }

    private _0xe0927a8a _0x27efd194;
    /// <summary>
    /// The template hangs the header on the card's very top edge, where a two-word
    /// title overhangs it. Pull it down inside the card.
    /// </summary>
    private void _0x2f09e491(_0x84a83be7 _0x5c85f386)
    {
        if (_0x5c85f386.ContentHeaderText == null)
        {
            return;
        }

        RectTransform _0x28edc593 = _0x5c85f386.ContentHeaderText.rectTransform;
        _0x28edc593.anchorMin = _0x98589ea5.Centre;
        _0x28edc593.anchorMax = _0x98589ea5.Centre;
        _0x28edc593.anchoredPosition = new Vector2(0f, 340f);
        _0x28edc593.sizeDelta = new Vector2(960f, 130f);
    }

    public void _0xec087e36(_0xe0927a8a _0x071a1286)
    {
        this._0x27efd194 = _0x071a1286;
        if (_0x18ece92a.Instance == null || _0x18ece92a.Instance.Pops == null)
        {
            return;
        }

        this._0xb0f191f2(_0xdfe619ff._0xdfb977df.PAUSE, _0x18ece92a.Instance._0xd86b69da(_0xdfe619ff._0xdfb977df.PAUSE));
        this._0xb0f191f2(_0xdfe619ff._0xdfb977df.WIN, _0x18ece92a.Instance._0xd86b69da(_0xdfe619ff._0xdfb977df.WIN));
        this._0xb0f191f2(_0xdfe619ff._0xdfb977df.LOSE, _0x18ece92a.Instance._0xd86b69da(_0xdfe619ff._0xdfb977df.LOSE));
    }

    public void _0xdfb3824b(int _0xcecd07ee, int _0xc1f0ab66)
    {
        if (_0x18ece92a.Instance == null)
        {
            return;
        }

        _0x84a83be7 _0xfb8f1adc = _0x18ece92a.Instance._0xd86b69da(_0xdfe619ff._0xdfb977df.PAUSE);
        this._0xde4c04f9(_0xdfe619ff._0xdfb977df.PAUSE, _0xfb8f1adc, _0x10bab297._0x67d4b257(new byte[12] { 136, 143, 149, 132, 147, 140, 136, 146, 146, 136, 142, 143 }, 193), _0x10bab297._0x67d4b257(new byte[19] { 46, 50, 63, 90, 50, 53, 47, 41, 63, 90, 45, 51, 54, 54, 90, 45, 59, 51, 46 }, 122), string.Empty, _0x10bab297._0x67d4b257(new byte[8] { 203, 218, 205, 204, 193, 220, 219, 168 }, 136) + _0x2da34b06.Grouped(_0xcecd07ee) + _0x10bab297._0x67d4b257(new byte[9] { 65, 76, 65, 50, 53, 32, 51, 50, 65 }, 97) + _0xc1f0ab66 + _0x10bab297._0x67d4b257(new byte[3] { 42, 37, 42 }, 10) + _0x2da34b06.ActStarGoal);
        _0x18ece92a.Instance._0x97e1675c(_0xdfe619ff._0xdfb977df.PAUSE);
        _0xaf5af43d.Tick();
    }
}

internal static class _0x10bab297
{
    internal static string _0x67d4b257(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}