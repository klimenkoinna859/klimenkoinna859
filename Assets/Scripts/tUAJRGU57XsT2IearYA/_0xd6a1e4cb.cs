using TMPro;
using UnityEngine;

/// <summary>
/// One place that decides how every label in this game behaves.
///
/// §C.10: word wrapping OFF, line breaks only as an explicit \n in the string, autosize
/// ALWAYS on, and fontSizeMin never below the readability floor of 24 canvas units.
/// §C.65: a label built under an inactive parent has not run Awake, so it has no font and
/// no shared material. We hand it one BEFORE touching anything that would read the
/// material, and never read fontMaterial at all - the shared font SDF material already
/// carries the themed dark outline, which is what makes the light text read.
/// </summary>
public static class _0xd6a1e4cb
{
    /// <summary>
    /// Sets a string whose line breaks are placed by hand. Never let the engine decide
    /// where a line ends - the layout must be identical on every device.
    /// </summary>
    public static void SetText(TMP_Text _0x35ed4d32, string _0x11488f6e)
    {
        if (_0x35ed4d32 == null)
        {
            return;
        }

        Prepare(_0x35ed4d32);
        _0x35ed4d32.text = _0x11488f6e;
    }

    public static void Apply(TMP_Text _0x2bd6b5d2, Color _0x7f66d99c, float _0x681d4044, float _0x677f81fd)
    {
        if (_0x2bd6b5d2 == null)
        {
            return;
        }

        Prepare(_0x2bd6b5d2);
        _0x2bd6b5d2.textWrappingMode = TextWrappingModes.NoWrap;
        _0x2bd6b5d2.overflowMode = TextOverflowModes.Overflow;
        _0x2bd6b5d2.enableAutoSizing = true;
        _0x2bd6b5d2.fontSizeMin = _0x677f81fd < _0x2da34b06.CaptionMin ? _0x2da34b06.CaptionMin : _0x677f81fd;
        _0x2bd6b5d2.fontSizeMax = _0x681d4044;
        _0x2bd6b5d2.fontSize = _0x681d4044;
        _0x2bd6b5d2.color = _0x7f66d99c;
        _0x2bd6b5d2.raycastTarget = false;
    }

    public static void Prepare(TMP_Text _0xc91725e6)
    {
        if (_0xc91725e6 == null)
        {
            return;
        }

        if (_0xc91725e6.font == null)
        {
            _0xc91725e6.font = TMP_Settings.defaultFontAsset;
        }

        if (_0xc91725e6.fontSharedMaterial == null && _0xc91725e6.font != null)
        {
            _0xc91725e6.fontSharedMaterial = _0xc91725e6.font.material;
        }
    }
}