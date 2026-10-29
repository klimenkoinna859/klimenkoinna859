using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Three missions, drawn fresh from the pool by the day's own seed. When all three
/// are claimed the list is replaced by a themed message, never a blank area.
/// </summary>
public sealed class _0xf85afdd2 : MonoBehaviour, _0x5ed4f0d4
{
    public void _0x6e501ccd(_0xe0927a8a _0xa11415f1, _0xf84cb8b0 _0x2eda787a, _0x9fb34e44 _0xbd4f62ad, _0xc5d7f584 _0xd339bf32)
    {
        RectTransform _0x1316a363 = (RectTransform)this.transform;
        _0x98589ea5.Backdrop(_0x1316a363, _0xadc7913f._0x244cf529(new byte[5] { 54, 17, 11, 13, 27 }, 126), _0xa11415f1._0xa5b7e3ab, Color.white);
        _0x98589ea5.PlateFull(_0x1316a363, _0xadc7913f._0x244cf529(new byte[4] { 241, 199, 213, 206 }, 166), _0xa11415f1._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.55f), 0f, 2.0f);
        _0xf84cb8b0.Header(_0x1316a363, _0xa11415f1, _0x2eda787a, _0xadc7913f._0x244cf529(new byte[8] { 64, 68, 94, 94, 68, 66, 67, 94 }, 13), _0xadc7913f._0x244cf529(new byte[32] { 46, 50, 40, 63, 63, 90, 63, 44, 63, 40, 35, 90, 62, 59, 35, 86, 90, 52, 63, 45, 90, 59, 46, 90, 55, 51, 62, 52, 51, 61, 50, 46 }, 122));
        this._0x73a877bc = _0x98589ea5.Label(_0x1316a363, _0xadc7913f._0x244cf529(new byte[7] { 218, 245, 248, 240, 244, 252, 253 }, 153), _0xadc7913f._0x244cf529(new byte[1] { 207 }, 226), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.TopCentre, new Vector2(0f, -320f), new Vector2(1000f, 50f));
        this._0x105636a0 = _0x98589ea5.Full(_0x1316a363, _0xadc7913f._0x244cf529(new byte[4] { 185, 156, 134, 129 }, 245), 0f);
        this._0x338ee1bb = _0xf84cb8b0.EmptyState(_0x1316a363, _0xa11415f1, _0xadc7913f._0x244cf529(new byte[43] { 14, 3, 3, 111, 11, 0, 1, 10, 111, 9, 0, 29, 111, 27, 0, 11, 14, 22, 69, 1, 10, 24, 111, 2, 6, 28, 28, 6, 0, 1, 28, 111, 14, 27, 111, 2, 6, 11, 1, 6, 8, 7, 27 }, 79));
        this._0x338ee1bb.gameObject.SetActive(false);
        for (int _0x2e2b9d47 = 0; _0x2e2b9d47 < _0x2da34b06.MissionCount; _0x2e2b9d47++)
        {
            this._0xf5fe2611(_0xa11415f1, _0xbd4f62ad, _0xd339bf32, this._0x105636a0, _0x2e2b9d47);
        }
    }

    private readonly List<TextMeshProUGUI> _0x5ca2bcdf = new List<TextMeshProUGUI>();
    private readonly List<TextMeshProUGUI> _0x398ef484 = new List<TextMeshProUGUI>();
    private readonly List<List<_0xc5d7f584>> _0x182023d0 = new List<List<_0xc5d7f584>>();
    public void Refresh()
    {
        _0xb29ed313.EnsureToday();
        int _0x3e7f5ce2 = _0xb29ed313.ClaimedCount();
        _0xd6a1e4cb.SetText(this._0x73a877bc, _0x3e7f5ce2 + _0xadc7913f._0x244cf529(new byte[3] { 159, 144, 159 }, 191) + _0x2da34b06.MissionCount + _0xadc7913f._0x244cf529(new byte[8] { 171, 200, 199, 202, 194, 198, 206, 207 }, 139));
        bool _0x6ec25808 = _0x3e7f5ce2 >= _0x2da34b06.MissionCount;
        if (this._0x105636a0 != null)
        {
            this._0x105636a0.gameObject.SetActive(!_0x6ec25808);
        }

        if (this._0x338ee1bb != null)
        {
            this._0x338ee1bb.gameObject.SetActive(_0x6ec25808);
        }

        if (_0x6ec25808)
        {
            return;
        }

        const float _0x34742c52 = 640f;
        for (int _0x9a232b1c = 0; _0x9a232b1c < this._0x072d22cf.Count; _0x9a232b1c++)
        {
            int _0xee60afcd = _0xb29ed313.GoalOf(_0x9a232b1c);
            int _0x4803eac7 = _0xb29ed313.Progress(_0x9a232b1c);
            bool _0xe67f91f0 = _0xb29ed313.Complete(_0x9a232b1c);
            bool _0x1ff534a4 = _0xb29ed313.Claimed(_0x9a232b1c);
            _0xd6a1e4cb.SetText(this._0x398ef484[_0x9a232b1c], _0xb29ed313.TextOf(_0x9a232b1c));
            _0xd6a1e4cb.SetText(this._0x7f0f10f4[_0x9a232b1c], _0x4803eac7 + _0xadc7913f._0x244cf529(new byte[3] { 226, 237, 226 }, 194) + _0xee60afcd);
            _0xd6a1e4cb.SetText(this._0x5ca2bcdf[_0x9a232b1c], _0xb29ed313.RewardOf(_0x9a232b1c));
            float _0x69d1c97d = _0xee60afcd <= 0 ? 0f : (float)_0x4803eac7 / _0xee60afcd;
            RectTransform _0x12935cd9 = (RectTransform)this._0x181ad638[_0x9a232b1c].transform;
            _0x12935cd9.sizeDelta = new Vector2(Mathf.Max(10f, _0x34742c52 * Mathf.Clamp01(_0x69d1c97d)), 18f);
            List<_0xc5d7f584> _0x75f5dbe6 = this._0x182023d0[_0x9a232b1c];
            for (int _0x8095914a = 0; _0x8095914a < _0x75f5dbe6.Count; _0x8095914a++)
            {
                _0x75f5dbe6[_0x8095914a]._0x68264ad1(_0x69d1c97d >= (_0x8095914a + 1) * 0.25f, _0x3fe280fb.Gold);
            }

            if (this._0xd0e487b8[_0x9a232b1c] != null)
            {
                this._0xd0e487b8[_0x9a232b1c].color = _0x1ff534a4 ? _0x3fe280fb.Rose : _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.45f);
            }

            Button _0x766e555d = this._0x4df7b549[_0x9a232b1c];
            Image _0x8380154d = _0x766e555d != null ? _0x766e555d.GetComponent<Image>() : null;
            TMP_Text _0xa088dd05 = _0x766e555d != null ? _0x766e555d.GetComponentInChildren<TMP_Text>(true) : null;
            _0x98589ea5.SetEnabled(_0x766e555d, _0x8380154d, _0xa088dd05, _0xe67f91f0 && !_0x1ff534a4, _0x3fe280fb.Gold, _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.55f), _0x3fe280fb.Cream, _0x3fe280fb.CreamMuted);
            _0xd6a1e4cb.SetText(_0xa088dd05, _0x1ff534a4 ? _0xadc7913f._0x244cf529(new byte[4] { 106, 97, 96, 107 }, 46) : (_0xe67f91f0 ? _0xadc7913f._0x244cf529(new byte[5] { 41, 38, 43, 35, 39 }, 106) : _0xadc7913f._0x244cf529(new byte[6] { 13, 14, 2, 10, 4, 5 }, 65)));
            this._0x072d22cf[_0x9a232b1c]._0x3a14c276(_0xe67f91f0 && !_0x1ff534a4);
        }
    }

    private readonly List<Image> _0xd0e487b8 = new List<Image>();
    private void _0xf5fe2611(_0xe0927a8a _0x1e08c0fc, _0x9fb34e44 _0x363d1a92, _0xc5d7f584 _0x1a73a8da, Transform _0x9530a0a5, int _0xb9f6e80b)
    {
        _0x9fb34e44 _0x702e5ffd = Instantiate(_0x363d1a92, _0x9530a0a5, false);
        RectTransform _0x67618812 = _0x702e5ffd._0x7693cccd;
        _0x67618812.anchorMin = _0x98589ea5.TopCentre;
        _0x67618812.anchorMax = _0x98589ea5.TopCentre;
        _0x67618812.anchoredPosition = new Vector2(0f, -620f - _0xb9f6e80b * 328f);
        _0x702e5ffd._0x0d1f6abd(new Vector2(1080f, 300f));
        _0x702e5ffd._0xf065af12(_0x3fe280fb.Burgundy, _0x3fe280fb.Navy, _0x3fe280fb.Brass, 1f);
        Transform _0x9f8079be = _0x702e5ffd._0xf9550e0d;
        // Gutter 41..83 from the row's left edge; text column starts at 129.
        List<_0xc5d7f584> _0x58e15cd2 = new List<_0xc5d7f584>();
        for (int _0x36530af3 = 0; _0x36530af3 < 4; _0x36530af3++)
        {
            _0xc5d7f584 _0xfd3e426e = Instantiate(_0x1a73a8da, _0x9f8079be, false);
            RectTransform _0x27779ae7 = (RectTransform)_0xfd3e426e.transform;
            _0x27779ae7.anchorMin = _0x98589ea5.Centre;
            _0x27779ae7.anchorMax = _0x98589ea5.Centre;
            _0x27779ae7.sizeDelta = new Vector2(_0x2da34b06.GutterWidth, _0x2da34b06.GutterWidth);
            _0x27779ae7.anchoredPosition = new Vector2(_0x2da34b06.GutterCentre - 540f, 72f - _0x36530af3 * 48f);
            _0x58e15cd2.Add(_0xfd3e426e);
        }

        const float _0xdd27c833 = 640f;
        float _0x2e7cc7b8 = _0x2da34b06.TextLeft + _0xdd27c833 * 0.5f - 540f;
        TextMeshProUGUI _0xafb3f83e = _0x98589ea5.Label(_0x9f8079be, _0xadc7913f._0x244cf529(new byte[4] { 173, 133, 139, 134 }, 234), _0xadc7913f._0x244cf529(new byte[1] { 231 }, 202), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.Cream, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(_0x2e7cc7b8, 86f), new Vector2(_0xdd27c833, 52f));
        TextMeshProUGUI _0xba97d123 = _0x98589ea5.Label(_0x9f8079be, _0xadc7913f._0x244cf529(new byte[8] { 149, 183, 170, 162, 183, 160, 182, 182 }, 197), _0xadc7913f._0x244cf529(new byte[1] { 131 }, 174), _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(_0x2e7cc7b8, 18f), new Vector2(_0xdd27c833, 60f));
        _0x98589ea5.Plate(_0x9f8079be, _0xadc7913f._0x244cf529(new byte[5] { 208, 246, 229, 231, 239 }, 132), _0x1e08c0fc._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.85f), _0x98589ea5.Centre, new Vector2(_0x2e7cc7b8, -42f), new Vector2(_0xdd27c833, 18f), 1.0f);
        RectTransform _0x28dc2211 = _0x98589ea5.Node(_0x9f8079be, _0xadc7913f._0x244cf529(new byte[8] { 165, 138, 143, 143, 171, 140, 144, 151 }, 227), _0x98589ea5.Centre, new Vector2(_0x2e7cc7b8 - _0xdd27c833 * 0.5f, -42f), new Vector2(0f, 18f));
        Image _0x4a5043a4 = _0x98589ea5.Plate(_0x28dc2211, _0xadc7913f._0x244cf529(new byte[4] { 231, 200, 205, 205 }, 161), _0x1e08c0fc._0xfa9196f7, _0x3fe280fb.Gold, _0x98589ea5.Centre, Vector2.zero, new Vector2(10f, 18f), 1.0f);
        RectTransform _0x69649410 = (RectTransform)_0x4a5043a4.transform;
        _0x69649410.pivot = new Vector2(0f, 0.5f);
        _0x69649410.anchoredPosition = Vector2.zero;
        TextMeshProUGUI _0x5d5b86db = _0x98589ea5.Label(_0x9f8079be, _0xadc7913f._0x244cf529(new byte[6] { 250, 205, 223, 201, 218, 204 }, 168), _0xadc7913f._0x244cf529(new byte[1] { 237 }, 192), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Left, _0x98589ea5.Centre, new Vector2(_0x2e7cc7b8, -96f), new Vector2(_0xdd27c833, 44f));
        Image _0x5d3d2802 = _0x98589ea5.Picture(_0x9f8079be, _0xadc7913f._0x244cf529(new byte[4] { 65, 124, 118, 126 }, 21), _0x1e08c0fc._0x294d71d8(0), _0x3fe280fb.Rose, _0x98589ea5.Centre, new Vector2(430f, 86f), new Vector2(60f, 60f));
        Button _0x738fec21 = _0x98589ea5.Cta(_0x9f8079be, _0xadc7913f._0x244cf529(new byte[8] { 185, 150, 155, 147, 151, 168, 149, 141 }, 250), _0xadc7913f._0x244cf529(new byte[5] { 94, 81, 92, 84, 80 }, 29), _0x1e08c0fc._0x24421334, null, _0x3fe280fb.Gold, _0x3fe280fb.Cream, _0x98589ea5.Centre, new Vector2(380f, -58f), new Vector2(250f, 108f), 1.6f);
        int _0x9fbf4748 = _0xb9f6e80b;
        _0x98589ea5.OnTap(_0x738fec21, () => this._0x080e6f38(_0x9fbf4748));
        this._0x072d22cf.Add(_0x702e5ffd);
        this._0x398ef484.Add(_0xafb3f83e);
        this._0x7f0f10f4.Add(_0xba97d123);
        this._0x5ca2bcdf.Add(_0x5d5b86db);
        this._0x181ad638.Add(_0x4a5043a4);
        this._0xd0e487b8.Add(_0x5d3d2802);
        this._0x4df7b549.Add(_0x738fec21);
        this._0x182023d0.Add(_0x58e15cd2);
    }

    private RectTransform _0x105636a0;
    private void OnDestroy()
    {
        for (int _0x6236acda = 0; _0x6236acda < this._0xd0e487b8.Count; _0x6236acda++)
        {
            if (this._0xd0e487b8[_0x6236acda] != null)
            {
                DOTween.Kill(this._0xd0e487b8[_0x6236acda].transform);
            }
        }
    }

    private readonly List<TextMeshProUGUI> _0x7f0f10f4 = new List<TextMeshProUGUI>();
    private RectTransform _0x338ee1bb;
    private TextMeshProUGUI _0x73a877bc;
    private readonly List<Image> _0x181ad638 = new List<Image>();
    private void _0x080e6f38(int _0x6340a6b7)
    {
        if (!_0xb29ed313.Complete(_0x6340a6b7) || _0xb29ed313.Claimed(_0x6340a6b7))
        {
            return;
        }

        _0xb29ed313.Claim(_0x6340a6b7);
        _0xaf5af43d.Tick();
        if (!_0xdfbe9389._0x5fbcf839 && _0x6340a6b7 < this._0xd0e487b8.Count && this._0xd0e487b8[_0x6340a6b7] != null)
        {
            this._0xd0e487b8[_0x6340a6b7].transform.localScale = Vector3.zero;
            this._0xd0e487b8[_0x6340a6b7].transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack).SetLink(this._0xd0e487b8[_0x6340a6b7].gameObject);
        }

        this.Refresh();
    }

    private readonly List<_0x9fb34e44> _0x072d22cf = new List<_0x9fb34e44>();
    private readonly List<Button> _0x4df7b549 = new List<Button>();
}

internal static class _0xadc7913f
{
    internal static string _0x244cf529(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}