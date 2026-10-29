using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The only way this game builds UI. Everything is uGUI on the template's own canvases,
/// so there is no second canvas to sort against the pops and no world sprite to keep
/// inside the -19..-1 corridor.
///
/// Draw order is sibling order (§C.13/§E.1): callers create background -> frame ->
/// content -> label, in that order, so a plate never covers its own caption.
/// </summary>
public static class _0x98589ea5
{
    /// <summary>Counts a number up so a credit change is visible, not instantaneous.</summary>
    public static void CountTo(TMP_Text _0x05392115, int _0x08419c4e, int _0xe9a4d9df, string _0x67db730a)
    {
        if (_0x05392115 == null)
        {
            return;
        }

        if (_0xdfbe9389._0x5fbcf839)
        {
            _0xd6a1e4cb.SetText(_0x05392115, _0x67db730a + _0x2da34b06.Grouped(_0xe9a4d9df));
            return;
        }

        int _0x152e0111 = _0x08419c4e;
        DOTween.To(() => _0x152e0111, _0x40359aea =>
        {
            _0x152e0111 = _0x40359aea;
            _0xd6a1e4cb.SetText(_0x05392115, _0x67db730a + _0x2da34b06.Grouped(_0x152e0111));
        }, _0xe9a4d9df, _0x2da34b06.CountUp).SetEase(Ease.OutCubic).SetLink(_0x05392115.gameObject);
    }

    /// <summary>Enabled / disabled look for a button whose action is not available yet.</summary>
    public static void SetEnabled(Button _0xc9a01448, Image _0xec688d29, TMP_Text _0x57af4ec3, bool _0xe499e45a, Color _0xf96b290c, Color _0x5cd9891a, Color _0x830569c8, Color _0x71c65452)
    {
        if (_0xc9a01448 != null)
        {
            _0xc9a01448.interactable = _0xe499e45a;
        }

        if (_0xec688d29 != null)
        {
            _0xec688d29.color = _0xe499e45a ? _0xf96b290c : _0x5cd9891a;
        }

        if (_0x57af4ec3 != null)
        {
            _0x57af4ec3.color = _0xe499e45a ? _0x830569c8 : _0x71c65452;
        }
    }

    public static readonly Vector2 Stretch1 = new Vector2(1f, 1f);
    /// <summary>An empty rect. `anchor` is used for both min and max (a point anchor).</summary>
    public static RectTransform Node(Transform _0x33bfd9ce, string _0xfec0f278, Vector2 _0x8f5d8350, Vector2 _0x7a0a8d27, Vector2 _0xde4abb19)
    {
        GameObject _0x25748d60 = new GameObject(_0xfec0f278, typeof(RectTransform));
        _0x25748d60.layer = _0x33bfd9ce != null ? _0x33bfd9ce.gameObject.layer : 5;
        RectTransform _0xb6941579 = _0x25748d60.GetComponent<RectTransform>();
        _0xb6941579.SetParent(_0x33bfd9ce, false);
        _0xb6941579.anchorMin = _0x8f5d8350;
        _0xb6941579.anchorMax = _0x8f5d8350;
        _0xb6941579.pivot = Centre;
        _0xb6941579.anchoredPosition = _0x7a0a8d27;
        _0xb6941579.sizeDelta = _0xde4abb19;
        _0xb6941579.localScale = Vector3.one;
        return _0xb6941579;
    }

    /// <summary>A full-bleed backdrop. The one place preserveAspect is wrong: it must cover.</summary>
    public static Image Backdrop(Transform _0xafa738c9, string _0x4ff16835, Sprite _0x5b8b5d8c, Color _0xc8f8f13f)
    {
        RectTransform _0x67e65e38 = Full(_0xafa738c9, _0x4ff16835, 0f);
        Image _0x61ec7c44 = _0x67e65e38.gameObject.AddComponent<Image>();
        _0x61ec7c44.sprite = _0x5b8b5d8c;
        _0x61ec7c44.type = Image.Type.Simple;
        _0x61ec7c44.preserveAspect = false;
        _0x61ec7c44.color = _0xc8f8f13f;
        _0x61ec7c44.raycastTarget = false;
        return _0x61ec7c44;
    }

    public static readonly Vector2 BottomCentre = new Vector2(0.5f, 0f);
    /// <summary>
    /// A themed button: plate -> optional icon -> caption, caption LAST so it is on top.
    /// The returned Button is the tap target; the caller subscribes with a lambda.
    /// </summary>
    public static Button Cta(Transform _0x54d812be, string _0xdfe2057c, string _0x38ea350c, Sprite _0xc8a6987e, Sprite _0xa3168bbe, Color _0x4c59d9ba, Color _0x61dfe8b9, Vector2 _0xec521fe0, Vector2 _0x2927dad2, Vector2 _0x6900a17e, float _0x69a2319c)
    {
        RectTransform _0x1236f25f = Node(_0x54d812be, _0xdfe2057c, _0xec521fe0, _0x2927dad2, _0x6900a17e);
        Image _0x9d0d0d65 = _0x1236f25f.gameObject.AddComponent<Image>();
        _0x9d0d0d65.sprite = _0xc8a6987e;
        _0x9d0d0d65.type = Image.Type.Sliced;
        _0x9d0d0d65.pixelsPerUnitMultiplier = _0x69a2319c;
        _0x9d0d0d65.color = _0x4c59d9ba;
        _0x9d0d0d65.raycastTarget = true;
        Button _0xe62e2596 = _0x1236f25f.gameObject.AddComponent<Button>();
        _0xe62e2596.targetGraphic = _0x9d0d0d65;
        _0xe62e2596.transition = Selectable.Transition.ColorTint;
        ColorBlock _0xd261d47a = _0xe62e2596.colors;
        _0xd261d47a.normalColor = Color.white;
        _0xd261d47a.highlightedColor = new Color(1f, 1f, 1f, 1f);
        _0xd261d47a.pressedColor = new Color(0.80f, 0.80f, 0.80f, 1f);
        _0xd261d47a.selectedColor = Color.white;
        _0xd261d47a.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.75f);
        _0xd261d47a.fadeDuration = 0.08f;
        _0xe62e2596.colors = _0xd261d47a;
        float _0x900612ce = 28f;
        if (_0xa3168bbe != null)
        {
            float _0xda05b362 = _0x6900a17e.y * 0.42f;
            Picture(_0x1236f25f, _0x1923ede4._0xad6371fd(new byte[5] { 99, 72, 93, 84, 76 }, 36), _0xa3168bbe, _0x61dfe8b9, Centre, new Vector2(-_0x6900a17e.x * 0.5f + _0xda05b362 * 0.75f + 18f, 0f), new Vector2(_0xda05b362, _0xda05b362));
            _0x900612ce = _0xda05b362 + 54f;
        }

        Label(_0x1236f25f, _0x1923ede4._0xad6371fd(new byte[7] { 140, 174, 191, 187, 166, 160, 161 }, 207), _0x38ea350c, _0x2da34b06.ButtonMax, _0x2da34b06.ButtonMin, _0x61dfe8b9, TextAlignmentOptions.Center, Centre, new Vector2(_0xa3168bbe != null ? _0x900612ce * 0.5f : 0f, 0f), new Vector2(_0x6900a17e.x - _0x900612ce * 2f, _0x6900a17e.y * 0.62f));
        return _0xe62e2596;
    }

    /// <summary>Scale feedback on press, so a tap is visible on a screenshot (§C.7).</summary>
    public static void Press(Transform _0xfcad166d)
    {
        if (_0xfcad166d == null)
        {
            return;
        }

        float _0x7559a308 = _0x2da34b06.PressTime * (_0xdfbe9389._0x5fbcf839 ? 0.5f : 1f);
        _0xfcad166d.DOKill(false);
        _0xfcad166d.localScale = Vector3.one;
        _0xfcad166d.DOScale(_0x2da34b06.PressScale, _0x7559a308).SetEase(Ease.OutQuad).SetLoops(2, LoopType.Yoyo).SetLink(_0xfcad166d.gameObject);
    }

    public static readonly Vector2 TopCentre = new Vector2(0.5f, 1f);
    /// <summary>
    /// A vertical scroll area with a clipped viewport. Returns the content rect the
    /// caller fills; its height is given, never inferred, so the layout is predictable.
    /// </summary>
    public static RectTransform ScrollArea(Transform _0xedf69635, string _0x26166ead, Vector2 _0x1ffa8ad4, Vector2 _0x3f91fe54, Vector2 _0x5edafabe, float _0x64e4a00a)
    {
        RectTransform _0x9bd5d54e = Node(_0xedf69635, _0x26166ead, _0x1ffa8ad4, _0x3f91fe54, _0x5edafabe);
        ScrollRect _0x94c36c0f = _0x9bd5d54e.gameObject.AddComponent<ScrollRect>();
        _0x94c36c0f.horizontal = false;
        _0x94c36c0f.vertical = true;
        _0x94c36c0f.movementType = ScrollRect.MovementType.Elastic;
        _0x94c36c0f.elasticity = 0.1f;
        _0x94c36c0f.scrollSensitivity = 40f;
        RectTransform _0xb7a39a90 = Full(_0x9bd5d54e, _0x1923ede4._0xad6371fd(new byte[8] { 141, 178, 190, 172, 171, 180, 169, 175 }, 219), 0f);
        _0xb7a39a90.gameObject.AddComponent<RectMask2D>();
        Image _0xdbde634e = _0xb7a39a90.gameObject.AddComponent<Image>();
        _0xdbde634e.color = new Color(1f, 1f, 1f, 0f);
        _0xdbde634e.raycastTarget = true;
        RectTransform _0x881e9909 = Node(_0xb7a39a90, _0x1923ede4._0xad6371fd(new byte[7] { 223, 243, 242, 232, 249, 242, 232 }, 156), TopCentre, new Vector2(0f, -_0x64e4a00a * 0.5f), new Vector2(_0x5edafabe.x, _0x64e4a00a));
        _0x94c36c0f.viewport = _0xb7a39a90;
        _0x94c36c0f.content = _0x881e9909;
        return _0x881e9909;
    }

    /// <summary>A rect stretched to its parent, optionally inset on all sides.</summary>
    public static RectTransform Full(Transform _0x741d3cdb, string _0x5dbb8676, float _0x766c5b22)
    {
        GameObject _0xe98cd8f3 = new GameObject(_0x5dbb8676, typeof(RectTransform));
        _0xe98cd8f3.layer = _0x741d3cdb != null ? _0x741d3cdb.gameObject.layer : 5;
        RectTransform _0x04e14cf0 = _0xe98cd8f3.GetComponent<RectTransform>();
        _0x04e14cf0.SetParent(_0x741d3cdb, false);
        _0x04e14cf0.anchorMin = Stretch0;
        _0x04e14cf0.anchorMax = Stretch1;
        _0x04e14cf0.pivot = Centre;
        _0x04e14cf0.anchoredPosition = Vector2.zero;
        _0x04e14cf0.sizeDelta = new Vector2(-_0x766c5b22 * 2f, -_0x766c5b22 * 2f);
        _0x04e14cf0.localScale = Vector3.one;
        return _0x04e14cf0;
    }

    /// <summary>
    /// A 9-sliced tinted surface. `ppu` is the corner-radius lever: lower is rounder.
    /// Sliced is the point of these plates, so they deliberately do NOT preserve aspect.
    /// </summary>
    public static Image Plate(Transform _0x1693e42f, string _0x9c6594d5, Sprite _0xc8a4ec66, Color _0x824d2fc4, Vector2 _0x0f59c8f3, Vector2 _0x03ccb446, Vector2 _0xf1f5c5cd, float _0x9c559d63)
    {
        RectTransform _0x9cf38f3e = Node(_0x1693e42f, _0x9c6594d5, _0x0f59c8f3, _0x03ccb446, _0xf1f5c5cd);
        Image _0x31e4945d = _0x9cf38f3e.gameObject.AddComponent<Image>();
        _0x31e4945d.sprite = _0xc8a4ec66;
        _0x31e4945d.type = Image.Type.Sliced;
        _0x31e4945d.pixelsPerUnitMultiplier = _0x9c559d63;
        _0x31e4945d.color = _0x824d2fc4;
        _0x31e4945d.raycastTarget = false;
        return _0x31e4945d;
    }

    /// <summary>
    /// Generated art drawn at its own proportions (§F.2a). The second side is never
    /// typed by hand: preserveAspect keeps whatever the PNG really is.
    /// </summary>
    public static Image Picture(Transform _0xc437725b, string _0xa4f3304e, Sprite _0xbc503863, Color _0x09a213b5, Vector2 _0x26f6acc0, Vector2 _0xf6f810d4, Vector2 _0xe96ec6ae)
    {
        RectTransform _0x79181e41 = Node(_0xc437725b, _0xa4f3304e, _0x26f6acc0, _0xf6f810d4, _0xe96ec6ae);
        Image _0x23b6a8e9 = _0x79181e41.gameObject.AddComponent<Image>();
        _0x23b6a8e9.sprite = _0xbc503863;
        _0x23b6a8e9.type = Image.Type.Simple;
        _0x23b6a8e9.preserveAspect = true;
        _0x23b6a8e9.color = _0x09a213b5;
        _0x23b6a8e9.raycastTarget = false;
        return _0x23b6a8e9;
    }

    public static readonly Vector2 TopLeft = new Vector2(0f, 1f);
    /// <summary>A round, caption-less button: plate first, glyph on top and centred.</summary>
    public static Button IconButton(Transform _0x3ba58203, string _0xe82ef7b9, Sprite _0xc71c1000, Sprite _0x98484efb, Color _0x0aa8ae16, Color _0x4498a18b, Vector2 _0x62ab2d2c, Vector2 _0x545a729a, float _0x207d7e98, float _0xf52611f2)
    {
        RectTransform _0x93bced3b = Node(_0x3ba58203, _0xe82ef7b9, _0x62ab2d2c, _0x545a729a, new Vector2(_0x207d7e98, _0x207d7e98));
        Image _0x27cf218b = _0x93bced3b.gameObject.AddComponent<Image>();
        _0x27cf218b.sprite = _0xc71c1000;
        _0x27cf218b.type = Image.Type.Sliced;
        _0x27cf218b.pixelsPerUnitMultiplier = _0xf52611f2;
        _0x27cf218b.color = _0x0aa8ae16;
        _0x27cf218b.raycastTarget = true;
        Button _0x590344d3 = _0x93bced3b.gameObject.AddComponent<Button>();
        _0x590344d3.targetGraphic = _0x27cf218b;
        _0x590344d3.transition = Selectable.Transition.ColorTint;
        ColorBlock _0x3b57655e = _0x590344d3.colors;
        _0x3b57655e.normalColor = Color.white;
        _0x3b57655e.highlightedColor = Color.white;
        _0x3b57655e.pressedColor = new Color(0.80f, 0.80f, 0.80f, 1f);
        _0x3b57655e.selectedColor = Color.white;
        _0x3b57655e.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.75f);
        _0x590344d3.colors = _0x3b57655e;
        Picture(_0x93bced3b, _0x1923ede4._0xad6371fd(new byte[5] { 250, 209, 196, 205, 213 }, 189), _0x98484efb, _0x4498a18b, Centre, Vector2.zero, new Vector2(_0x207d7e98 * 0.52f, _0x207d7e98 * 0.52f));
        return _0x590344d3;
    }

    /// <summary>Wires a button and gives it its press feedback in one place.</summary>
    public static void OnTap(Button _0x60b1b58f, Action _0xd13b26f6)
    {
        if (_0x60b1b58f == null)
        {
            return;
        }

        _0x60b1b58f.onClick.AddListener(() => Press(_0x60b1b58f.transform));
        if (_0xd13b26f6 != null)
        {
            _0x60b1b58f.onClick.AddListener(() => _0xd13b26f6());
        }
    }

    public static TextMeshProUGUI Label(Transform _0xafb99be6, string _0x18452d4c, string _0x5a4846a2, float _0x1adea5da, float _0xd57904f5, Color _0x41f728f2, TextAlignmentOptions _0x7a07259d, Vector2 _0xf2186955, Vector2 _0x3417046a, Vector2 _0x49de0c93)
    {
        RectTransform _0x5609d122 = Node(_0xafb99be6, _0x18452d4c, _0xf2186955, _0x3417046a, _0x49de0c93);
        TextMeshProUGUI _0x6348e085 = _0x5609d122.gameObject.AddComponent<TextMeshProUGUI>();
        _0xd6a1e4cb.Apply(_0x6348e085, _0x41f728f2, _0x1adea5da, _0xd57904f5);
        _0x6348e085.alignment = _0x7a07259d;
        _0xd6a1e4cb.SetText(_0x6348e085, _0x5a4846a2);
        return _0x6348e085;
    }

    public static readonly Vector2 Centre = new Vector2(0.5f, 0.5f);
    /// <summary>A plate stretched over its parent (a backdrop or a scrim).</summary>
    public static Image PlateFull(Transform _0x888ba124, string _0xc199e43c, Sprite _0x63c8da7a, Color _0x7bb412df, float _0x007b0522, float _0x34110399)
    {
        RectTransform _0x8b8026a7 = Full(_0x888ba124, _0xc199e43c, _0x007b0522);
        Image _0xa7e808c4 = _0x8b8026a7.gameObject.AddComponent<Image>();
        _0xa7e808c4.sprite = _0x63c8da7a;
        _0xa7e808c4.type = Image.Type.Sliced;
        _0xa7e808c4.pixelsPerUnitMultiplier = _0x34110399;
        _0xa7e808c4.color = _0x7bb412df;
        _0xa7e808c4.raycastTarget = false;
        return _0xa7e808c4;
    }

    public static readonly Vector2 Stretch0 = new Vector2(0f, 0f);
}

internal static class _0x1923ede4
{
    internal static string _0xad6371fd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}