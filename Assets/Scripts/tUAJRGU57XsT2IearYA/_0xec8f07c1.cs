using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One cell of a reel column: a tinted plate with the symbol drawn on top at its own
/// proportions. Spawned from Prefabs/Generated/ReelSymbolCell.prefab, so the plate and
/// the glyph arrive already sized and in the right draw order (plate first).
/// </summary>
public sealed class _0xec8f07c1 : MonoBehaviour
{
    public void _0xd0d7d76a(int _0xc98af228, Sprite _0x9155d3de)
    {
        this._0xf890ceba = _0xc98af228;
        if (this._glyph != null)
        {
            this._glyph.sprite = _0x9155d3de;
            this._glyph.preserveAspect = true;
            this._glyph.color = Color.white;
        }

        this._0x2c28cfaf(false);
    }

    [SerializeField]
    private Image _plate;
    [SerializeField]
    private Image _glyph;
    /// <summary>A matched cell punches once so the win is visible on a frame.</summary>
    public void _0x8c5ddc14()
    {
        this._0x2c28cfaf(true);
        if (_0xdfbe9389._0x5fbcf839)
        {
            return;
        }

        this.transform.DOPunchScale(new Vector3(0.12f, 0.12f, 0f), 0.35f, 6, 0.6f).SetLink(this.gameObject);
    }

    public void _0x2c28cfaf(bool _0x1aac5506)
    {
        if (this._plate == null)
        {
            return;
        }

        this._plate.color = _0x1aac5506 ? _0x3fe280fb.Fade(_0x3fe280fb.Gold, 0.42f) : _0x3fe280fb.Fade(_0x3fe280fb.NavyDeep, 0.55f);
    }

    private int _0xf890ceba = -1;
    /// <summary>The idle breath that tells the player the board is alive, not frozen.</summary>
    public void _0x4af8c0c5(float _0xbbdbf786)
    {
        if (_0xdfbe9389._0x5fbcf839)
        {
            return;
        }

        this.transform.DOScale(1.012f, 1.9f).SetEase(Ease.InOutSine).SetDelay(_0xbbdbf786).SetLoops(-1, LoopType.Yoyo).SetLink(this.gameObject);
    }

    public int _0xa47e64ef
    {
        get
        {
            return this._0xf890ceba;
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }
}