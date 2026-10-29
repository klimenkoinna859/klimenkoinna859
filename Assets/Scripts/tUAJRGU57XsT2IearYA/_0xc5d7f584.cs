using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One pip of the act meter, the daily streak row or the rank ladder: a brass ring
/// with a core that lights when the pip is earned. Spawned from
/// Prefabs/Generated/StarPip.prefab (ring first, core second - ring behind core).
/// </summary>
public sealed class _0xc5d7f584 : MonoBehaviour
{
    [SerializeField]
    private Image _core;
    [SerializeField]
    private Image _ring;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    /// <summary>The current pip breathes so the player can see where they are.</summary>
    public void _0x93f8b400()
    {
        if (_0xdfbe9389._0x5fbcf839)
        {
            return;
        }

        this.transform.DOScale(1.14f, 0.8f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this.gameObject);
    }

    public void _0x68264ad1(bool _0x0ee4ef86, Color _0x139d4176)
    {
        if (this._ring != null)
        {
            this._ring.color = _0x0ee4ef86 ? _0x139d4176 : _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.45f);
        }

        if (this._core != null)
        {
            this._core.color = _0x0ee4ef86 ? _0x139d4176 : _0x3fe280fb.Fade(_0x3fe280fb.Navy, 0.40f);
        }
    }

    /// <summary>A freshly earned pip pops in, so a star is visible the moment it lands.</summary>
    public void _0x131241aa()
    {
        if (_0xdfbe9389._0x5fbcf839)
        {
            return;
        }

        this.transform.localScale = Vector3.zero;
        this.transform.DOScale(1f, 0.30f).SetEase(Ease.OutBack).SetLink(this.gameObject);
    }
}