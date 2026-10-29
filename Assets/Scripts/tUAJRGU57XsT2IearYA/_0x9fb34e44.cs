using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The SHEET surface every card, row and panel of this game sits on: an ink shadow
/// under a burgundy-to-navy body with a brass rim. Spawned from
/// Prefabs/Generated/SheetPlate.prefab in shadow -> body -> wash -> rim order, so the
/// rim is never buried and the body never covers its own content.
/// </summary>
public sealed class _0x9fb34e44 : MonoBehaviour
{
    [SerializeField]
    private Image _rim;
    [SerializeField]
    private RectTransform _content;
    public RectTransform _0x7693cccd
    {
        get
        {
            return this._root != null ? this._root : (RectTransform)this.transform;
        }
    }

    public void _0xf065af12(Color _0x7b2bde0d, Color _0x98f9121d, Color _0x5a3284ec, float _0x26afefe2)
    {
        if (this._body != null)
        {
            this._body.color = _0x3fe280fb.Fade(_0x7b2bde0d, _0x7b2bde0d.a * _0x26afefe2);
        }

        if (this._wash != null)
        {
            this._wash.color = _0x3fe280fb.Fade(_0x98f9121d, _0x98f9121d.a * _0x26afefe2);
        }

        if (this._rim != null)
        {
            this._rim.color = _0x3fe280fb.Fade(_0x5a3284ec, _0x5a3284ec.a * _0x26afefe2);
        }

        if (this._shadow != null)
        {
            this._shadow.color = _0x3fe280fb.Fade(_0x3fe280fb.Ink, 0.45f * _0x26afefe2);
        }
    }

    [SerializeField]
    private RectTransform _root;
    /// <summary>Where callers put the card's own children. Never null after Resize.</summary>
    public RectTransform _0xf9550e0d
    {
        get
        {
            return this._content != null ? this._content : this._root;
        }
    }

    [SerializeField]
    private Image _body;
    public void _0x0d1f6abd(Vector2 _0x7a3f544b)
    {
        RectTransform _0xacda0e65 = this._0x7693cccd;
        _0xacda0e65.sizeDelta = _0x7a3f544b;
    }

    [SerializeField]
    private Image _shadow;
    /// <summary>A card with something to claim wears a brighter rim - visible on a frame.</summary>
    public void _0x3a14c276(bool _0x6ab286e7)
    {
        if (this._rim == null)
        {
            return;
        }

        this._rim.color = _0x6ab286e7 ? _0x3fe280fb.Fade(_0x3fe280fb.GoldLight, 0.90f) : _0x3fe280fb.Fade(_0x3fe280fb.Brass, 0.55f);
    }

    [SerializeField]
    private Image _wash;
}