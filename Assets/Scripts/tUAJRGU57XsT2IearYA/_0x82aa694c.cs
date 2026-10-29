using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Brands the loading screen and makes it read as a different screen from the lobby:
/// a near-black house with one lit emblem, no chips, no tabs and no PLAY.
///
/// The body it builds into is the PANEL's Content (PanelController.Panels[SPLASH]),
/// not SplashPanel.Content - the latter ships unassigned on this template, and code
/// that brands through it draws nothing at all, silently.
///
/// SplashPanel.cs and MainThreadUtil.cs are never touched (§C.64). The bar is themed
/// through the Slider the template already wired, in the scene, from here.
/// </summary>
public sealed class _0x82aa694c : MonoBehaviour
{
    private Image _0x1d6d5674;
    public void _0x8f31eaa3(_0xe0927a8a _0x4700a7ce, Transform _0xe75835d6)
    {
        if (_0xe75835d6 == null || _0x4700a7ce == null)
        {
            return;
        }

        RectTransform _0x3e05fe53 = _0x98589ea5.Full(_0xe75835d6, _0xa380e9ec._0xa6c07bfb(new byte[10] { 163, 132, 158, 152, 142, 169, 153, 138, 133, 143 }, 235), 0f);
        _0x3e05fe53.SetAsFirstSibling();
        _0x98589ea5.Backdrop(_0x3e05fe53, _0xa380e9ec._0xa6c07bfb(new byte[5] { 138, 173, 183, 177, 167 }, 194), _0x4700a7ce._0xa5b7e3ab, _0x3fe280fb.Fade(Color.white, 1f));
        _0x98589ea5.PlateFull(_0x3e05fe53, _0xa380e9ec._0xa6c07bfb(new byte[10] { 51, 20, 26, 21, 9, 46, 30, 15, 20, 16 }, 125), _0x4700a7ce._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Ink, 0.88f), 0f, 2.0f);
        _0x98589ea5.PlateFull(_0x3e05fe53, _0xa380e9ec._0xa6c07bfb(new byte[10] { 235, 216, 209, 203, 216, 201, 234, 220, 206, 213 }, 189), _0x4700a7ce._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.BurgundyDeep, 0.35f), 0f, 2.0f);
        this._0x3df1aeb2 = _0x98589ea5.Plate(_0x3e05fe53, _0xa380e9ec._0xa6c07bfb(new byte[4] { 245, 220, 209, 210 }, 189), _0x4700a7ce._0xfa9196f7, _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.35f), new Vector2(0.5f, 0.58f), Vector2.zero, new Vector2(640f, 640f), 1.1f);
        this._0x1d6d5674 = _0x98589ea5.Picture(_0x3e05fe53, _0xa380e9ec._0xa6c07bfb(new byte[6] { 212, 252, 243, 253, 244, 252 }, 145), _0x4700a7ce._0x9f010034, Color.white, new Vector2(0.5f, 0.58f), Vector2.zero, new Vector2(520f, 520f));
        _0x98589ea5.Label(_0x3e05fe53, _0xa380e9ec._0xa6c07bfb(new byte[10] { 111, 77, 90, 76, 90, 81, 75, 86, 81, 88 }, 63), _0xa380e9ec._0xa6c07bfb(new byte[18] { 125, 127, 104, 126, 104, 99, 121, 100, 99, 106, 13, 121, 98, 99, 100, 106, 101, 121 }, 45), _0x2da34b06.BodyMax, _0x2da34b06.BodyMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.58f), new Vector2(0f, -330f), new Vector2(860f, 64f));
        _0x98589ea5.Label(_0x3e05fe53, _0xa380e9ec._0xa6c07bfb(new byte[7] { 140, 186, 169, 182, 178, 181, 188 }, 219), _0xa380e9ec._0xa6c07bfb(new byte[22] { 32, 54, 37, 58, 62, 57, 48, 87, 35, 63, 50, 87, 49, 56, 56, 35, 59, 62, 48, 63, 35, 36 }, 119), _0x2da34b06.CaptionMax, _0x2da34b06.CaptionMin, _0x3fe280fb.CreamMuted, TextAlignmentOptions.Center, new Vector2(0.5f, 0.22f), new Vector2(0f, -62f), new Vector2(860f, 52f));
        this._0x0d569f25();
        this._0x525c12b4();
    }

    private void OnDestroy()
    {
        if (this._0x1d6d5674 != null)
        {
            DOTween.Kill(this._0x1d6d5674.transform);
        }

        if (this._0x3df1aeb2 != null)
        {
            DOTween.Kill(this._0x3df1aeb2);
        }
    }

    private Image _0x3df1aeb2;
    /// <summary>
    /// Rule G: the fill takes the accent colour and the track a dark palette colour
    /// with real alpha. The template ships white fill on a track at alpha 1/255, which
    /// is a bar nobody can see at any size.
    /// </summary>
    private void _0x0d569f25()
    {
        Slider _0x917bf66a = _0x40bf4df6.Instance != null ? _0x40bf4df6.Instance.AnimationSlider : null;
        if (_0x917bf66a == null)
        {
            return;
        }

        Image _0x0779d53e = _0x917bf66a.GetComponent<Image>();
        if (_0x0779d53e != null)
        {
            _0x0779d53e.color = _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.85f);
        }

        RectTransform _0xb68a3fe1 = _0x917bf66a.fillRect;
        if (_0xb68a3fe1 != null)
        {
            Image _0xb795cfd7 = _0xb68a3fe1.GetComponent<Image>();
            if (_0xb795cfd7 != null)
            {
                _0xb795cfd7.color = _0x3fe280fb.Gold;
            }

            RectTransform _0xd98c8c16 = _0xb68a3fe1.parent as RectTransform;
            if (_0xd98c8c16 != null)
            {
                Image _0x0fd206f5 = _0xd98c8c16.GetComponent<Image>();
                if (_0x0fd206f5 != null)
                {
                    _0x0fd206f5.color = _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.85f);
                }
            }
        }

        if (_0x917bf66a.targetGraphic != null)
        {
            _0x917bf66a.targetGraphic.color = _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.85f);
        }
    }

    private void _0x525c12b4()
    {
        if (_0xdfbe9389._0x5fbcf839)
        {
            return;
        }

        if (this._0x1d6d5674 != null)
        {
            this._0x1d6d5674.transform.localScale = new Vector3(0.92f, 0.92f, 1f);
            this._0x1d6d5674.transform.DOScale(1f, 0.7f).SetEase(Ease.OutBack).SetLink(this._0x1d6d5674.gameObject);
            this._0x1d6d5674.transform.DOScale(1.03f, 2.6f).SetEase(Ease.InOutSine).SetDelay(0.7f).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x1d6d5674.gameObject);
        }

        if (this._0x3df1aeb2 != null)
        {
            this._0x3df1aeb2.DOFade(0.75f, 1.8f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x3df1aeb2.gameObject);
        }
    }
}

internal static class _0xa380e9ec
{
    internal static string _0xa6c07bfb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}