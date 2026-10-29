using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Owns the menu scene. Everything it builds goes inside the template's own panels -
/// the splash body and PANELS.DEFAULT's Content - so there is no second canvas to
/// sort against the pops and the template's panel transitions still reveal it.
///
/// §C.59: set-up happens in Start, never Awake; the template fills its singletons in
/// Awake and a generated Awake would race them.
/// </summary>
public sealed class _0x1b843186 : MonoBehaviour
{
    private void _0x42e62a6b()
    {
        _0xdfbe9389._0x6f7325e5 = _0xdfbe9389._0x6f7325e5 + 1;
        _0xdfbe9389.Flush();
        _0xaf5af43d.Tick();
        _0x98589ea5.Press(this.transform);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    private void _0xc5835523()
    {
        if (_0xdfe619ff._0xa6411e87.DEFAULT >= _0x50b9d424.Instance.Panels.Count)
        {
            return;
        }

        _0x19fbab3b _0xa95a3bd2 = _0x50b9d424.Instance.Panels[_0xdfe619ff._0xa6411e87.DEFAULT];
        if (_0xa95a3bd2 == null || _0xa95a3bd2.Content == null)
        {
            return;
        }

        Transform _0x1234216c = _0xa95a3bd2.Content.transform;
        // The template's own scene-load button is the only Button in this Content before
        // we add ours, so this finds it without relying on a name. It stays the LAST
        // sibling, which is what draws its face above the page we insert below it.
        Button _0xbe489b9f = _0x1234216c.GetComponentInChildren<Button>(true);
        this._0x08156f26 = this.gameObject.AddComponent<_0xf84cb8b0>();
        RectTransform _0x422635ad = _0x98589ea5.Full(_0x1234216c, _0xd34c990d._0x49c3adcf(new byte[5] { 241, 192, 198, 196, 210 }, 161), 0f);
        _0x422635ad.SetAsFirstSibling();
        RectTransform _0xec1538c7 = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[11] { 167, 150, 144, 146, 182, 144, 146, 176, 150, 131, 146 }, 247), 0f);
        _0x902f16d6 _0x09ffb025 = _0xec1538c7.gameObject.AddComponent<_0x902f16d6>();
        _0x09ffb025._0xb44d0907(this._art, this._0x08156f26, this._sheetPrefab);
        this._0x08156f26._0x3f387105(_0xec1538c7, _0x09ffb025);
        RectTransform _0x8612b338 = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[9] { 11, 58, 60, 62, 23, 52, 57, 57, 34 }, 91), 0f);
        _0xee2f478c _0x9f0a3186 = _0x8612b338.gameObject.AddComponent<_0xee2f478c>();
        _0x9f0a3186._0xcbe50b66(this._art, this._0x08156f26, this._sheetPrefab);
        this._0x08156f26._0x3f387105(_0x8612b338, _0x9f0a3186);
        RectTransform _0x2d0faa2e = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[11] { 161, 144, 150, 148, 189, 152, 147, 131, 144, 131, 136 }, 241), 0f);
        _0x2a1e55ed _0xa62a63ed = _0x2d0faa2e.gameObject.AddComponent<_0x2a1e55ed>();
        _0xa62a63ed._0x73764c8b(this._art, this._0x08156f26, this._sheetPrefab);
        this._0x08156f26._0x3f387105(_0x2d0faa2e, _0xa62a63ed);
        RectTransform _0xa777d1e3 = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[8] { 216, 233, 239, 237, 207, 225, 238, 252 }, 136), 0f);
        _0x16434292 _0x325e2cd8 = _0xa777d1e3.gameObject.AddComponent<_0x16434292>();
        _0x325e2cd8._0x2d065ef4(this._art, this._0x08156f26, this._sheetPrefab, this._pipPrefab);
        this._0x08156f26._0x3f387105(_0xa777d1e3, _0x325e2cd8);
        RectTransform _0xa2679c48 = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[12] { 254, 207, 201, 203, 227, 199, 221, 221, 199, 193, 192, 221 }, 174), 0f);
        _0xf85afdd2 _0xed2db3bf = _0xa2679c48.gameObject.AddComponent<_0xf85afdd2>();
        _0xed2db3bf._0x6e501ccd(this._art, this._0x08156f26, this._sheetPrefab, this._pipPrefab);
        this._0x08156f26._0x3f387105(_0xa2679c48, _0xed2db3bf);
        RectTransform _0xcb964b2b = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[14] { 92, 109, 107, 105, 79, 99, 96, 96, 105, 111, 120, 101, 99, 98 }, 12), 0f);
        _0x2428d834 _0xa761dd48 = _0xcb964b2b.gameObject.AddComponent<_0x2428d834>();
        _0xa761dd48._0xbebf5c6d(this._art, this._0x08156f26, this._sheetPrefab);
        this._0x08156f26._0x3f387105(_0xcb964b2b, _0xa761dd48);
        RectTransform _0x239e70d7 = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[12] { 125, 76, 74, 72, 125, 95, 66, 74, 95, 72, 94, 94 }, 45), 0f);
        _0x2ac68753 _0xc9399829 = _0x239e70d7.gameObject.AddComponent<_0x2ac68753>();
        _0xc9399829._0x96c00100(this._art, this._0x08156f26, this._sheetPrefab, this._pipPrefab);
        this._0x08156f26._0x3f387105(_0x239e70d7, _0xc9399829);
        RectTransform _0x1fb0c1d9 = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[11] { 55, 6, 0, 2, 55, 21, 8, 1, 14, 11, 2 }, 103), 0f);
        _0xb0f7d03d _0xa56c0e39 = _0x1fb0c1d9.gameObject.AddComponent<_0xb0f7d03d>();
        _0xa56c0e39._0x74de3ffc(this._art, this._0x08156f26, this._sheetPrefab);
        this._0x08156f26._0x3f387105(_0x1fb0c1d9, _0xa56c0e39);
        RectTransform _0x33623825 = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[9] { 108, 93, 91, 89, 110, 73, 80, 89, 79 }, 60), 0f);
        _0x58e33ed7 _0x6c4512bb = _0x33623825.gameObject.AddComponent<_0x58e33ed7>();
        _0x6c4512bb._0x0ca39a59(this._art, this._0x08156f26, this._sheetPrefab);
        this._0x08156f26._0x3f387105(_0x33623825, _0x6c4512bb);
        RectTransform _0xd6a9ce6a = _0x98589ea5.Full(_0x422635ad, _0xd34c990d._0x49c3adcf(new byte[12] { 113, 64, 70, 68, 114, 68, 85, 85, 72, 79, 70, 82 }, 33), 0f);
        _0xe74f9aaa _0xfaec4c18 = _0xd6a9ce6a.gameObject.AddComponent<_0xe74f9aaa>();
        _0xfaec4c18._0x6ab07f20(this._art, this._0x08156f26, this._sheetPrefab);
        this._0x08156f26._0x3f387105(_0xd6a9ce6a, _0xfaec4c18);
        this._0x3473e460(_0xbe489b9f, _0x1234216c);
        this._0x08156f26.PageChanged += (_0x04ffca03) => this._0x2539f746(_0x04ffca03);
        _0x1a6ed7e6 _0x70397322 = this.gameObject.AddComponent<_0x1a6ed7e6>();
        _0x70397322._0x62f6649d();
        _0xb29ed313.EnsureToday();
        this._0x08156f26.Show(_0xdfbe9389._0x29469462 ? _0xf84cb8b0.PageLobby : _0xf84cb8b0.PageAgeGate);
        this._0x21b96bd7();
    }

    [SerializeField]
    private _0xe0927a8a _art;
    /// <summary>
    /// The template ships this button stretched across most of the panel with no face
    /// of its own: every layer that could draw is switched off in the EMPTY variant, and
    /// its one surviving graphic is tinted to nothing by the Button's own ColorTint. So
    /// the size is pinned (§G.3) and the face is drawn as the button's OWN children,
    /// with raycastTarget off so the tap still reaches the template Button underneath.
    /// </summary>
    private void _0x3473e460(Button _0x76e34fb4, Transform _0x56d6c69d)
    {
        if (_0x76e34fb4 == null)
        {
            return;
        }

        RectTransform _0x01b636e5 = (RectTransform)_0x76e34fb4.transform;
        _0x01b636e5.anchorMin = new Vector2(0.5f, 0.235f);
        _0x01b636e5.anchorMax = new Vector2(0.5f, 0.235f);
        _0x01b636e5.pivot = _0x98589ea5.Centre;
        _0x01b636e5.anchoredPosition = Vector2.zero;
        _0x01b636e5.sizeDelta = new Vector2(760f, 170f);
        _0x98589ea5.Plate(_0x01b636e5, _0xd34c990d._0x49c3adcf(new byte[10] { 64, 124, 113, 105, 67, 120, 113, 116, 127, 103 }, 16), this._art._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Ink, 0.45f), _0x98589ea5.Centre, new Vector2(0f, -12f), new Vector2(770f, 174f), 1.6f);
        _0x98589ea5.Plate(_0x01b636e5, _0xd34c990d._0x49c3adcf(new byte[9] { 26, 38, 43, 51, 26, 38, 43, 62, 47 }, 74), this._art._0x24421334, _0x3fe280fb.Gold, _0x98589ea5.Centre, Vector2.zero, new Vector2(760f, 170f), 1.6f);
        _0x98589ea5.Plate(_0x01b636e5, _0xd34c990d._0x49c3adcf(new byte[12] { 105, 85, 88, 64, 109, 86, 73, 117, 80, 94, 81, 77 }, 57), this._art._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.GoldLight, 0.55f), _0x98589ea5.Centre, new Vector2(0f, 48f), new Vector2(720f, 58f), 1.4f);
        _0x98589ea5.Picture(_0x01b636e5, _0xd34c990d._0x49c3adcf(new byte[9] { 224, 220, 209, 201, 247, 220, 201, 192, 216 }, 176), this._art._0x294d71d8(4), _0x3fe280fb.Cream, _0x98589ea5.Centre, new Vector2(-230f, 0f), new Vector2(70f, 70f));
        _0x98589ea5.Label(_0x01b636e5, _0xd34c990d._0x49c3adcf(new byte[11] { 147, 175, 162, 186, 128, 162, 179, 183, 170, 172, 173 }, 195), _0xd34c990d._0x49c3adcf(new byte[4] { 168, 180, 185, 161 }, 248), _0x2da34b06.ButtonMax, _0x2da34b06.ButtonMin, _0x3fe280fb.Cream, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(28f, 0f), new Vector2(520f, 104f));
        this._0x28176ee9 = _0x76e34fb4;
        this._0x0623baf2 = _0x98589ea5.Label(_0x56d6c69d, _0xd34c990d._0x49c3adcf(new byte[8] { 53, 9, 4, 28, 45, 12, 11, 17 }, 101), _0xd34c990d._0x49c3adcf(new byte[29] { 208, 209, 218, 191, 203, 222, 207, 191, 207, 202, 203, 204, 191, 203, 208, 209, 214, 216, 215, 203, 184, 204, 191, 222, 220, 203, 191, 208, 209 }, 159), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.235f), new Vector2(0f, -126f), new Vector2(1000f, 48f));
        _0x76e34fb4.onClick.AddListener(() => this._0x42e62a6b());
    }

    /// <summary>
    /// The lobby credit bar and tab captions have to be right every time the player
    /// comes back from a sub-page, so the router refreshes the page it shows.
    /// </summary>
    private void _0x21b96bd7()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[menu] built pages={_0xf84cb8b0.PageCount} credits={_0xdfbe9389._0x8d6a1c71} rank={_0xf7dacd0a._0xd708b43a}");
            }
#endif
        }
    }

    [SerializeField]
    private _0xc5d7f584 _pipPrefab;
    [SerializeField]
    private _0x9fb34e44 _sheetPrefab;
    private Button _0x28176ee9;
    /// <summary>The main button is the lobby's; no other page shares its slot.</summary>
    private void _0x2539f746(int _0x792f7781)
    {
        bool _0xf9dbd5f6 = _0x792f7781 == _0xf84cb8b0.PageLobby;
        if (this._0x28176ee9 != null)
        {
            this._0x28176ee9.gameObject.SetActive(_0xf9dbd5f6);
        }

        if (this._0x0623baf2 != null)
        {
            this._0x0623baf2.gameObject.SetActive(_0xf9dbd5f6);
        }
    }

    private _0xf84cb8b0 _0x08156f26;
    private void _0xa43512f5()
    {
        if (_0xdfe619ff._0xa6411e87.SPLASH >= _0x50b9d424.Instance.Panels.Count)
        {
            return;
        }

        _0x19fbab3b _0xa5614f95 = _0x50b9d424.Instance.Panels[_0xdfe619ff._0xa6411e87.SPLASH];
        if (_0xa5614f95 == null || _0xa5614f95.Content == null)
        {
            return;
        }

        _0x82aa694c _0x951674aa = _0xa5614f95.gameObject.AddComponent<_0x82aa694c>();
        _0x951674aa._0x8f31eaa3(this._art, _0xa5614f95.Content.transform);
    }

    private void Start()
    {
        if (this._art == null || _0x50b9d424.Instance == null)
        {
            return;
        }

        this._0xa43512f5();
        this._0xc5835523();
    }

    private TextMeshProUGUI _0x0623baf2;
}

internal static class _0xd34c990d
{
    internal static string _0x49c3adcf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}