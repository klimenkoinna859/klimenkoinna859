using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Twelve decorative cards in three suites. Purely cosmetic: nothing here is bought,
/// sold or traded - they are earned by finishing acts, by the day-seven streak and by
/// one of the mission rewards.
/// </summary>
public sealed class _0x2428d834 : MonoBehaviour, _0x5ed4f0d4
{
    public void Refresh()
    {
        int _0xe1c4817e = _0xf7dacd0a.CardsOwned();
        _0xd6a1e4cb.SetText(this._0x1e85393c, _0xe1c4817e + _0xd4e0b4a5._0xd8cbd2be(new byte[3] { 175, 160, 175 }, 143) + _0x2da34b06.CardCount);
        bool _0x41939a1b = _0xe1c4817e == 0;
        if (this._0xc7d6f826 != null)
        {
            this._0xc7d6f826.gameObject.SetActive(!_0x41939a1b);
        }

        if (this._0x77aaf2a3 != null)
        {
            this._0x77aaf2a3.gameObject.SetActive(_0x41939a1b);
        }

        this._0x4ef5dd25();
        if (_0x41939a1b)
        {
            return;
        }

        for (int _0x752d93cf = 0; _0x752d93cf < this._0xedb58985.Count; _0x752d93cf++)
        {
            bool _0x9974bc14 = _0xf7dacd0a.CardOwned(_0x752d93cf);
            this._0xedb58985[_0x752d93cf]._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, _0x9974bc14 ? 1f : 0.6f);
            this._0xedb58985[_0x752d93cf]._0x3a14c276(_0x9974bc14);
            if (this._0x690ab017[_0x752d93cf] != null)
            {
                this._0x690ab017[_0x752d93cf].color = _0x9974bc14 ? Color.white : _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.55f);
            }

            _0xd6a1e4cb.SetText(this._0x42cd74b9[_0x752d93cf], _0x9974bc14 ? _0xf7dacd0a.CardName(_0x752d93cf) : _0xd4e0b4a5._0xd8cbd2be(new byte[6] { 159, 156, 144, 152, 150, 151 }, 211));
            this._0x42cd74b9[_0x752d93cf].color = _0x9974bc14 ? _0x3fe280fb.Cream : _0x3fe280fb.CreamMuted;
        }
    }

    private void _0x725bed5e(_0xe0927a8a _0xaf68e236, _0x9fb34e44 _0x7ca20052, Transform _0xfd7eba1d)
    {
        this._0x37a3d0ad = _0x98589ea5.Full(_0xfd7eba1d, _0xd4e0b4a5._0xd8cbd2be(new byte[6] { 121, 88, 73, 92, 84, 81 }, 61), 0f);
        Image _0x354c8be9 = _0x98589ea5.PlateFull(this._0x37a3d0ad, _0xd4e0b4a5._0xd8cbd2be(new byte[11] { 204, 237, 252, 233, 225, 228, 219, 235, 250, 225, 229 }, 136), _0xaf68e236._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Ink, 0.72f), 0f, 2.0f);
        _0x354c8be9.raycastTarget = true;
        Button _0xef0aee94 = this._0x37a3d0ad.gameObject.AddComponent<Button>();
        _0xef0aee94.targetGraphic = _0x354c8be9;
        _0xef0aee94.transition = Selectable.Transition.None;
        _0x98589ea5.OnTap(_0xef0aee94, () => this._0x4ef5dd25());
        _0x9fb34e44 _0x42e84ea0 = Instantiate(_0x7ca20052, this._0x37a3d0ad, false);
        RectTransform _0x6c6812b9 = _0x42e84ea0._0x7693cccd;
        _0x6c6812b9.anchorMin = _0x98589ea5.Centre;
        _0x6c6812b9.anchorMax = _0x98589ea5.Centre;
        _0x6c6812b9.anchoredPosition = Vector2.zero;
        _0x42e84ea0._0x0d1f6abd(new Vector2(760f, 980f));
        _0x42e84ea0._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        _0x42e84ea0._0x3a14c276(true);
        Transform _0x82f17086 = _0x42e84ea0._0xf9550e0d;
        this._0x77959d78 = _0x98589ea5.Picture(_0x82f17086, _0xd4e0b4a5._0xd8cbd2be(new byte[9] { 133, 164, 181, 160, 168, 173, 128, 179, 181 }, 193), _0xaf68e236._0x9f010034, Color.white, _0x98589ea5.Centre, new Vector2(0f, 150f), new Vector2(420f, 420f));
        this._0x0f7cdac1 = _0x98589ea5.Label(_0x82f17086, _0xd4e0b4a5._0xd8cbd2be(new byte[10] { 81, 112, 97, 116, 124, 121, 91, 116, 120, 112 }, 21), _0xd4e0b4a5._0xd8cbd2be(new byte[1] { 64 }, 109), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, -140f), new Vector2(680f, 70f));
        this._0x7a5024b8 = _0x98589ea5.Label(_0x82f17086, _0xd4e0b4a5._0xd8cbd2be(new byte[13] { 207, 238, 255, 234, 226, 231, 205, 231, 234, 253, 228, 254, 249 }, 139), _0xd4e0b4a5._0xd8cbd2be(new byte[1] { 181 }, 152), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, -230f), new Vector2(680f, 60f));
        _0x98589ea5.Label(_0x82f17086, _0xd4e0b4a5._0xd8cbd2be(new byte[10] { 222, 255, 238, 251, 243, 246, 210, 243, 244, 238 }, 154), _0xd4e0b4a5._0xd8cbd2be(new byte[21] { 149, 128, 145, 225, 128, 143, 152, 150, 137, 132, 147, 132, 225, 149, 142, 225, 130, 141, 142, 146, 132 }, 193), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, -370f), new Vector2(680f, 48f));
        this._0x37a3d0ad.gameObject.SetActive(false);
    }

    private Image _0x77959d78;
    private void _0xf6cbf57d(_0xe0927a8a _0xb0bded02, _0x9fb34e44 _0xf5dcb8f6, Transform _0xc009a8da, int _0x54cb4234)
    {
        // Four columns, three rows - one suite per row, so a suite header never has to
        // cut a row in half. Card 268x360, gap 24: 4*268 + 3*24 = 1144 inside 1242.
        int _0xa7da868c = _0x54cb4234 % 4;
        int _0x2d7492e1 = _0x54cb4234 / 4;
        float _0x1088d7ec = (_0xa7da868c - 1.5f) * 292f;
        float _0xcb23cd76 = -700f - _0x2d7492e1 * 490f;
        if (_0xa7da868c == 0)
        {
            float _0xb4be3d70 = _0xcb23cd76 + 230f;
            _0x98589ea5.Label(_0xc009a8da, _0xd4e0b4a5._0xd8cbd2be(new byte[5] { 144, 182, 170, 183, 166 }, 195), _0xf7dacd0a.CardSuite(_0x54cb4234), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Gold, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, _0xb4be3d70), new Vector2(360f, 52f));
            _0x98589ea5.Plate(_0xc009a8da, _0xd4e0b4a5._0xd8cbd2be(new byte[10] { 0, 38, 58, 39, 54, 1, 38, 63, 54, 31 }, 83), _0xb0bded02._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.55f), _0x98589ea5.TopCentre, new Vector2(-394f, _0xb4be3d70), new Vector2(340f, 4f), 1.0f);
            _0x98589ea5.Plate(_0xc009a8da, _0xd4e0b4a5._0xd8cbd2be(new byte[10] { 244, 210, 206, 211, 194, 245, 210, 203, 194, 245 }, 167), _0xb0bded02._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.55f), _0x98589ea5.TopCentre, new Vector2(394f, _0xb4be3d70), new Vector2(340f, 4f), 1.0f);
        }

        _0x9fb34e44 _0x1e06b3be = Instantiate(_0xf5dcb8f6, _0xc009a8da, false);
        RectTransform _0x044d34fc = _0x1e06b3be._0x7693cccd;
        _0x044d34fc.anchorMin = _0x98589ea5.TopCentre;
        _0x044d34fc.anchorMax = _0x98589ea5.TopCentre;
        _0x044d34fc.anchoredPosition = new Vector2(_0x1088d7ec, _0xcb23cd76);
        _0x1e06b3be._0x0d1f6abd(new Vector2(268f, 360f));
        _0x1e06b3be._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0x4c87efae = _0x1e06b3be._0xf9550e0d;
        Image _0x0a2f197c = _0x98589ea5.Picture(_0x4c87efae, _0xd4e0b4a5._0xd8cbd2be(new byte[4] { 244, 211, 209, 215 }, 178), _0xb0bded02._0x9f010034, Color.white, _0x98589ea5.Centre, new Vector2(0f, 42f), new Vector2(170f, 170f));
        TextMeshProUGUI _0x211a11b2 = _0x98589ea5.Label(_0x4c87efae, _0xd4e0b4a5._0xd8cbd2be(new byte[8] { 103, 69, 86, 64, 106, 69, 73, 65 }, 36), _0xd4e0b4a5._0xd8cbd2be(new byte[1] { 43 }, 6), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, -116f), new Vector2(236f, 46f));
        Image _0xafc143e0 = _0x4c87efae.gameObject.AddComponent<Image>();
        _0xafc143e0.sprite = _0xb0bded02._0xfa9196f7;
        _0xafc143e0.type = Image.Type.Sliced;
        _0xafc143e0.pixelsPerUnitMultiplier = 2.2f;
        _0xafc143e0.color = new Color(1f, 1f, 1f, 0f);
        _0xafc143e0.raycastTarget = true;
        Button _0xd9310acc = _0x4c87efae.gameObject.AddComponent<Button>();
        _0xd9310acc.targetGraphic = _0xafc143e0;
        _0xd9310acc.transition = Selectable.Transition.None;
        int _0xeefaa551 = _0x54cb4234;
        _0x98589ea5.OnTap(_0xd9310acc, () => this._0x8bda94fb(_0xeefaa551));
        this._0xedb58985.Add(_0x1e06b3be);
        this._0x690ab017.Add(_0x0a2f197c);
        this._0x42cd74b9.Add(_0x211a11b2);
    }

    private TextMeshProUGUI _0x1e85393c;
    private TextMeshProUGUI _0x7a5024b8;
    private void OnDestroy()
    {
        if (this._0x77959d78 != null)
        {
            DOTween.Kill(this._0x77959d78.transform);
        }
    }

    private void _0x8bda94fb(int _0xfc22723f)
    {
        if (!_0xf7dacd0a.CardOwned(_0xfc22723f) || this._0x37a3d0ad == null)
        {
            return;
        }

        _0xaf5af43d.Tick();
        _0xd6a1e4cb.SetText(this._0x0f7cdac1, _0xf7dacd0a.CardSuite(_0xfc22723f) + _0xd4e0b4a5._0xd8cbd2be(new byte[3] { 107, 102, 107 }, 75) + _0xf7dacd0a.CardName(_0xfc22723f));
        _0xd6a1e4cb.SetText(this._0x7a5024b8, _0xf7dacd0a.CardFlavour(_0xfc22723f));
        this._0x37a3d0ad.gameObject.SetActive(true);
        if (!_0xdfbe9389._0x5fbcf839 && this._0x77959d78 != null)
        {
            this._0x77959d78.transform.localScale = new Vector3(0.8f, 0.8f, 1f);
            this._0x77959d78.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack).SetLink(this._0x77959d78.gameObject);
        }
    }

    private readonly List<TextMeshProUGUI> _0x42cd74b9 = new List<TextMeshProUGUI>();
    private readonly List<_0x9fb34e44> _0xedb58985 = new List<_0x9fb34e44>();
    public void _0xbebf5c6d(_0xe0927a8a _0xf8539ef6, _0xf84cb8b0 _0x6e3877b4, _0x9fb34e44 _0xd1818739)
    {
        RectTransform _0xf7b01aac = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0xf7b01aac, _0xd4e0b4a5._0xd8cbd2be(new byte[5] { 135, 160, 186, 188, 170 }, 207), _0xf8539ef6._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0xf7b01aac, _0xd4e0b4a5._0xd8cbd2be(new byte[4] { 16, 38, 52, 47 }, 71), _0xf8539ef6._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.58f), 0f, 2.0f);
        _0xf84cb8b0.Header(_0xf7b01aac, _0xf8539ef6, _0x6e3877b4, _0xd4e0b4a5._0xd8cbd2be(new byte[10] { 235, 231, 228, 228, 237, 235, 252, 225, 231, 230 }, 168), _0xd4e0b4a5._0xd8cbd2be(new byte[31] { 49, 53, 38, 58, 49, 48, 84, 54, 45, 84, 36, 56, 53, 45, 61, 58, 51, 88, 84, 58, 49, 34, 49, 38, 84, 54, 59, 33, 51, 60, 32 }, 116));
        this._0x1e85393c = _0x98589ea5.Label(_0xf7b01aac, _0xd4e0b4a5._0xd8cbd2be(new byte[5] { 241, 201, 208, 219, 218 }, 190), _0xd4e0b4a5._0xd8cbd2be(new byte[1] { 194 }, 239), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, -330f), new Vector2(1000f, 62f));
        this._0xc7d6f826 = _0x98589ea5.Full(_0xf7b01aac, _0xd4e0b4a5._0xd8cbd2be(new byte[4] { 99, 86, 77, 64 }, 36), 0f);
        this._0x77aaf2a3 = _0xf84cb8b0.EmptyState(_0xf7b01aac, _0xf8539ef6, _0xd4e0b4a5._0xd8cbd2be(new byte[40] { 117, 116, 27, 120, 122, 105, 127, 104, 27, 98, 126, 111, 49, 120, 116, 118, 107, 119, 126, 111, 126, 27, 122, 117, 27, 122, 120, 111, 27, 111, 116, 27, 126, 122, 105, 117, 27, 116, 117, 126 }, 59));
        this._0x77aaf2a3.gameObject.SetActive(false);
        for (int _0x187c0e5d = 0; _0x187c0e5d < _0x2da34b06.CardCount; _0x187c0e5d++)
        {
            this._0xf6cbf57d(_0xf8539ef6, _0xd1818739, this._0xc7d6f826, _0x187c0e5d);
        }

        this._0x725bed5e(_0xf8539ef6, _0xd1818739, _0xf7b01aac);
    }

    private readonly List<Image> _0x690ab017 = new List<Image>();
    private TextMeshProUGUI _0x0f7cdac1;
    private RectTransform _0xc7d6f826;
    private RectTransform _0x37a3d0ad;
    private void _0x4ef5dd25()
    {
        if (this._0x37a3d0ad != null)
        {
            this._0x37a3d0ad.gameObject.SetActive(false);
        }
    }

    private RectTransform _0x77aaf2a3;
}

internal static class _0xd4e0b4a5
{
    internal static string _0xd8cbd2be(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}