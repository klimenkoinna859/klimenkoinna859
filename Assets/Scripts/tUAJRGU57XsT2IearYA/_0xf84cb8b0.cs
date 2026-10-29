using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Ten content pages inside the ONE template panel this template guarantees
/// (PANELS.DEFAULT). Only SPLASH, DEFAULT and the tutorial indices are known-good
/// here, so inventing panel indices for nine more screens would be a guess, and a
/// wrong index is a silently dead screen. The pages are this game's own objects and
/// the router switches exactly one of them on.
/// </summary>
public sealed class _0xf84cb8b0 : MonoBehaviour
{
    private readonly List<RectTransform> _0xe34b5a27 = new List<RectTransform>();
    public const int PageGift = 3;
    public int _0xd9be3f8a
    {
        get
        {
            return this._0xd369abce;
        }
    }

    private readonly List<_0x5ed4f0d4> _0x6cf0c5f7 = new List<_0x5ed4f0d4>();
    public const int PageLibrary = 2;
    public const int PageAgeGate = 0;
    public const int PageRules = 8;
    public const int PageMissions = 4;
    /// <summary>Switches to a page: the outgoing one slides out, the incoming one in.</summary>
    public void Show(int _0xf5317141)
    {
        if (_0xf5317141 < 0 || _0xf5317141 >= this._0xe34b5a27.Count)
        {
            return;
        }

        float _0xf8039020 = _0x2da34b06.PageOut * (_0xdfbe9389._0x5fbcf839 ? 0f : 1f);
        float _0x6b5020f2 = _0x2da34b06.PageIn * (_0xdfbe9389._0x5fbcf839 ? 0f : 1f);
        for (int _0x9a7e3cd9 = 0; _0x9a7e3cd9 < this._0xe34b5a27.Count; _0x9a7e3cd9++)
        {
            RectTransform _0xc92b8983 = this._0xe34b5a27[_0x9a7e3cd9];
            if (_0xc92b8983 == null)
            {
                continue;
            }

            if (_0x9a7e3cd9 == _0xf5317141)
            {
                continue;
            }

            if (_0xc92b8983.gameObject.activeSelf)
            {
                _0xc92b8983.DOKill(false);
                _0xc92b8983.gameObject.SetActive(false);
            }
        }

        RectTransform _0x96040f47 = this._0xe34b5a27[_0xf5317141];
        if (_0x96040f47 != null)
        {
            _0x96040f47.gameObject.SetActive(true);
            _0x96040f47.DOKill(false);
            _0x96040f47.anchoredPosition = new Vector2(0f, _0xdfbe9389._0x5fbcf839 ? 0f : 40f);
            _0x96040f47.DOAnchorPosY(0f, _0x6b5020f2).SetEase(Ease.OutCubic).SetLink(_0x96040f47.gameObject);
        }

        this._0xd369abce = _0xf5317141;
        if (this._0x6cf0c5f7[_0xf5317141] != null)
        {
            this._0x6cf0c5f7[_0xf5317141].Refresh();
        }

        if (this.PageChanged != null)
        {
            this.PageChanged(_0xf5317141);
        }

        {
#if B_LOGS
            {
                Debug.Log($"[menu] page={_0xf5317141} out={_0xf8039020} in={_0x6b5020f2}");
            }
#endif
        }
    }

    /// <summary>Back to the lobby - the single destination every sub-page returns to.</summary>
    public void _0x08ea87b9()
    {
        this.Show(PageLobby);
    }

    public const int PageSettings = 9;
    public const int PageCollection = 5;
    private int _0xd369abce = -1;
    public const int PageLobby = 1;
    public const int PageProfile = 7;
    /// <summary>
    /// A themed message for a list that has nothing in it. Never a blank area (§G).
    /// </summary>
    public static RectTransform EmptyState(Transform _0x87133cef, _0xe0927a8a _0xfcc044fc, string _0xa8555c76)
    {
        RectTransform _0xb7d3fd91 = _0x98589ea5.Node(_0x87133cef, _0x484565c2._0x7719136b(new byte[5] { 16, 56, 37, 33, 44 }, 85), _0x98589ea5.Centre, new Vector2(0f, -60f), new Vector2(980f, 520f));
        _0x98589ea5.Picture(_0xb7d3fd91, _0x484565c2._0x7719136b(new byte[9] { 98, 74, 87, 83, 94, 106, 70, 85, 76 }, 39), _0xfcc044fc._0x9f010034, _0x3fe280fb.Fade(Color.white, 0.32f), _0x98589ea5.Centre, new Vector2(0f, 120f), new Vector2(260f, 260f));
        _0x98589ea5.Label(_0xb7d3fd91, _0x484565c2._0x7719136b(new byte[9] { 88, 112, 109, 105, 100, 73, 120, 101, 105 }, 29), _0xa8555c76, _0x2da34b06.SectionMax, _0x2da34b06.SectionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, _0x98589ea5.Centre, new Vector2(0f, -140f), new Vector2(940f, 190f));
        return _0xb7d3fd91;
    }

    /// <summary>
    /// The shared page header: a back chevron on the left and the page title beside it.
    /// The chevron sits in its own x-band, clear of the title box (§C.25).
    /// </summary>
    public static TextMeshProUGUI Header(Transform _0xfa17307c, _0xe0927a8a _0x311a8027, _0xf84cb8b0 _0xeb0595c4, string _0x0a659ebf, string _0x72571aa2)
    {
        Button _0x9ea97489 = _0x98589ea5.IconButton(_0xfa17307c, _0x484565c2._0x7719136b(new byte[4] { 110, 77, 79, 71 }, 44), _0x311a8027._0xb1d3c259, _0x311a8027._0x58e49a6e, _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.92f), _0x3fe280fb.GoldLight, new Vector2(0f, 1f), new Vector2(118f, -148f), 132f, 1.1f);
        _0x98589ea5.OnTap(_0x9ea97489, () => _0xeb0595c4._0x08ea87b9());
        TextMeshProUGUI _0x0f7600a4 = _0x98589ea5.Label(_0xfa17307c, _0x484565c2._0x7719136b(new byte[5] { 57, 4, 25, 1, 8 }, 109), _0x0a659ebf, _0x2da34b06.TitleMax, _0x2da34b06.TitleMin, _0x3fe280fb.GoldLight, TextAlignmentOptions.Left, new Vector2(0f, 1f), new Vector2(238f + 440f, -148f), new Vector2(880f, 116f));
        if (!string.IsNullOrEmpty(_0x72571aa2))
        {
            _0x98589ea5.Label(_0xfa17307c, _0x484565c2._0x7719136b(new byte[6] { 20, 51, 38, 51, 50, 52 }, 71), _0x72571aa2, _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Left, new Vector2(0f, 1f), new Vector2(238f + 440f, -236f), new Vector2(880f, 48f));
        }

        return _0x0f7600a4;
    }

    public const int PageProgress = 6;
    public const int PageCount = 10;
    /// <summary>Raised with the page that is now up, so the menu director can show or
    /// hide the template's PLAY button - it belongs to the lobby and nowhere else.</summary>
    public event Action<int> PageChanged;
    public void _0x3f387105(RectTransform _0xa3e52783, _0x5ed4f0d4 _0xd8d9c3e4)
    {
        this._0xe34b5a27.Add(_0xa3e52783);
        this._0x6cf0c5f7.Add(_0xd8d9c3e4);
    }
}

internal static class _0x484565c2
{
    internal static string _0x7719136b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}