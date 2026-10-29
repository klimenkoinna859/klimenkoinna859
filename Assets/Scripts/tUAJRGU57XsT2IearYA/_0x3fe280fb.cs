using UnityEngine;

/// <summary>
/// The one palette of the app: preset CASINO_GOLD with the two mid surfaces
/// overridden to the brief's burgundy velvet and stage navy.
///
/// EVERY colour used as a TEXT colour here is light (Cream, CreamMuted, Gold,
/// GoldLight, white). The shared font material carries a dark outline, so a dark
/// face colour would merge with its own outline into a blot.
///
/// All fields are plain literals: nothing in this type is initialised from another
/// static field, so the declaration order cannot matter after obfuscation.
/// </summary>
public static class _0x3fe280fb
{
    public static readonly Color Navy = new Color(0.078f, 0.102f, 0.169f, 1f); // #141A2B
    public static readonly Color Ink = new Color(0.043f, 0.043f, 0.059f, 1f); // #0B0B0F
    /// <summary>Blend towards another colour; used for pressed / disabled states.</summary>
    public static Color Mix(Color _0x13bf93c2, Color _0xaf9e3c16, float _0x859e8a5b)
    {
        return new Color(_0x13bf93c2.r + (_0xaf9e3c16.r - _0x13bf93c2.r) * _0x859e8a5b, _0x13bf93c2.g + (_0xaf9e3c16.g - _0x13bf93c2.g) * _0x859e8a5b, _0x13bf93c2.b + (_0xaf9e3c16.b - _0x13bf93c2.b) * _0x859e8a5b, _0x13bf93c2.a + (_0xaf9e3c16.a - _0x13bf93c2.a) * _0x859e8a5b);
    }

    public static readonly Color GoldLight = new Color(0.961f, 0.843f, 0.478f, 1f); // #F5D77A
    public static readonly Color CreamMuted = new Color(0.796f, 0.722f, 0.580f, 1f); // #CBB894
    /// <summary>The same hue at a different alpha. Used for scrims, tracks and dimmed plates.</summary>
    public static Color Fade(Color _0x726c5d50, float _0xb0b4a764)
    {
        return new Color(_0x726c5d50.r, _0x726c5d50.g, _0x726c5d50.b, _0xb0b4a764);
    }

    public static readonly Color Brass = new Color(0.690f, 0.541f, 0.243f, 1f); // #B08A3E
    public static readonly Color BurgundyLit = new Color(0.431f, 0.106f, 0.188f, 1f); // #6E1B30
    public static readonly Color NavyDeep = new Color(0.055f, 0.075f, 0.125f, 1f); // #0E1320
    public static readonly Color Rose = new Color(0.878f, 0.400f, 0.541f, 1f); // #E0668A
    public static readonly Color Gold = new Color(0.831f, 0.686f, 0.216f, 1f); // #D4AF37
    public static readonly Color BurgundyDeep = new Color(0.227f, 0.047f, 0.098f, 1f); // #3A0C19
    public static readonly Color Burgundy = new Color(0.353f, 0.075f, 0.149f, 1f); // #5A1326
    public static readonly Color Cream = new Color(0.953f, 0.902f, 0.784f, 1f); // #F3E6C8
}