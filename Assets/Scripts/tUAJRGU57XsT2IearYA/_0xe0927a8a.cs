using UnityEngine;

/// <summary>
/// The project's whole image budget, held as serialized references so obfuscation
/// cannot break them. Nothing here is looked up by name or path.
///
/// The art stage draws a FIXED set of files; these fields are exactly that set, given
/// the meaning this game needs:
///   _logo        the abstract brass half-mask emblem - brand mark AND the MASK wild symbol
///   _iconHome    brass chevron, used as BACK
///   _iconPause   two brass bars, used as PAUSE
///   _sprite1..5  the five ordinary reel symbols (star, ticket, bell, ruby, gold face)
///   _buttonRect  rectangular button plate     _buttonRound  round button plate
///   _plateRound  the template's own 9-slice rounded plate - can never dangle, so every
///                sheet, bar, pip and frame in this game is drawn with it and a tint
///   _bgMain / _bgGame  the two scene backdrops
/// </summary>
public sealed class _0xe0927a8a : MonoBehaviour
{
    [SerializeField]
    private Sprite _iconHome;
    public Sprite _0x9f010034
    {
        get
        {
            return this._logo;
        }
    }

    [SerializeField]
    private Sprite _buttonRect;
    [SerializeField]
    private Sprite _buttonRound;
    [SerializeField]
    private Sprite _sprite1;
    public Sprite _0xfa9196f7
    {
        get
        {
            return this._plateRound;
        }
    }

    [SerializeField]
    private Sprite _iconPause;
    [SerializeField]
    private Sprite _logo;
    [SerializeField]
    private Sprite _sprite3;
    public Sprite _0x64866bec
    {
        get
        {
            return this._bgGame;
        }
    }

    public Sprite _0x1d92e735
    {
        get
        {
            return this._iconPause;
        }
    }

    public Sprite _0xa5b7e3ab
    {
        get
        {
            return this._bgMain;
        }
    }

    [SerializeField]
    private Sprite _sprite5;
    [SerializeField]
    private Sprite _sprite4;
    [SerializeField]
    private Sprite _bgMain;
    public Sprite _0x58e49a6e
    {
        get
        {
            return this._iconHome;
        }
    }

    [SerializeField]
    private Sprite _sprite2;
    [SerializeField]
    private Sprite _bgGame;
    /// <summary>
    /// Reel symbol art by id. 0..4 are the ordinary symbols, 5 is MASK (the emblem).
    /// Falls back to the emblem rather than returning null, so no Image is ever left
    /// without a sprite (an unassigned Image renders as a solid white rectangle).
    /// </summary>
    public Sprite _0x294d71d8(int _0xfc3da5bf)
    {
        if (_0xfc3da5bf == 0)
        {
            return this._sprite1 != null ? this._sprite1 : this._logo;
        }

        if (_0xfc3da5bf == 1)
        {
            return this._sprite2 != null ? this._sprite2 : this._logo;
        }

        if (_0xfc3da5bf == 2)
        {
            return this._sprite3 != null ? this._sprite3 : this._logo;
        }

        if (_0xfc3da5bf == 3)
        {
            return this._sprite4 != null ? this._sprite4 : this._logo;
        }

        if (_0xfc3da5bf == 4)
        {
            return this._sprite5 != null ? this._sprite5 : this._logo;
        }

        return this._logo;
    }

    public Sprite _0x24421334
    {
        get
        {
            return this._buttonRect;
        }
    }

    [SerializeField]
    private Sprite _plateRound;
    public Sprite _0xb1d3c259
    {
        get
        {
            return this._buttonRound;
        }
    }
}