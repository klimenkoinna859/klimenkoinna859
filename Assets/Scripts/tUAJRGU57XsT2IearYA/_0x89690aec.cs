/// <summary>
/// Walks the five live lines over the 3x3 grid and says what the spin is worth.
/// Pure arithmetic, no Unity types - which is what lets the strip generator simulate
/// four hundred spins with it before the player ever sees the act.
/// </summary>
public static class _0x89690aec
{
    /// <summary>
    /// Evaluates every live line. `payouts` and `stars` are filled per line so the
    /// presentation can light exactly the lines that paid.
    /// </summary>
    public static int Resolve(int[] _0xf0d5c3fc, int[] _0x56f2ec5f, int _0xea45d5d6, int[] _0xe76c9fea, int[] _0x4797318b)
    {
        int _0xfdabc210 = 0;
        for (int _0x5517c4d4 = 0; _0x5517c4d4 < _0x56f2ec5f.Length; _0x5517c4d4++)
        {
            int[] _0xc22d7ec0 = LineRows(_0x56f2ec5f[_0x5517c4d4]);
            int pay = Payout(_0xf0d5c3fc, _0xc22d7ec0, _0xea45d5d6);
            _0xe76c9fea[_0x5517c4d4] = pay;
            _0x4797318b[_0x5517c4d4] = _0xb4264be6.StarsFor(pay, _0xea45d5d6);
            _0xfdabc210 += pay;
        }

        return _0xfdabc210;
    }

    /// <summary>
    /// payout = 0                        fewer than three matching (MASK substitutes)
    ///        = stake * table[symbol]    three of a kind, wild-assisted or not
    ///        = stake * 2                exactly two MASKs and one other symbol
    /// </summary>
    public static int Payout(int[] _0x54532652, int[] _0x0b1eb8e6, int _0xd7219589)
    {
        int _0xc68e2429 = _0x54532652[_0x0b1eb8e6[0] * _0x2da34b06.ReelColumns];
        int _0xc0a0151b = _0x54532652[_0x0b1eb8e6[1] * _0x2da34b06.ReelColumns + 1];
        int _0xee3f3aab = _0x54532652[_0x0b1eb8e6[2] * _0x2da34b06.ReelColumns + 2];
        int _0x7a0fe7ea = 0;
        if (_0xc68e2429 == _0xb4264be6.Wild)
        {
            _0x7a0fe7ea++;
        }

        if (_0xc0a0151b == _0xb4264be6.Wild)
        {
            _0x7a0fe7ea++;
        }

        if (_0xee3f3aab == _0xb4264be6.Wild)
        {
            _0x7a0fe7ea++;
        }

        if (_0x7a0fe7ea == 3)
        {
            return _0xd7219589 * _0xb4264be6.Multiplier(_0xb4264be6.Wild);
        }

        if (_0x7a0fe7ea == 2)
        {
            return _0xd7219589 * 2;
        }

        int _0x550671a5 = _0xc68e2429 != _0xb4264be6.Wild ? _0xc68e2429 : (_0xc0a0151b != _0xb4264be6.Wild ? _0xc0a0151b : _0xee3f3aab);
        bool _0x21a477f3 = (_0xc68e2429 == _0xb4264be6.Wild || _0xc68e2429 == _0x550671a5) && (_0xc0a0151b == _0xb4264be6.Wild || _0xc0a0151b == _0x550671a5) && (_0xee3f3aab == _0xb4264be6.Wild || _0xee3f3aab == _0x550671a5);
        return _0x21a477f3 ? _0xd7219589 * _0xb4264be6.Multiplier(_0x550671a5) : 0;
    }

    /// <summary>
    /// The seven candidate lines, each three row indices (one per column).
    /// 0,1,2 are the rows; 3,4 the diagonals; 5,6 the two V shapes.
    /// </summary>
    public static int[] LineRows(int _0xab65e6fc)
    {
        switch (_0xab65e6fc)
        {
            case 0:
                return new int[]
                {
                    0,
                    0,
                    0
                };
            case 1:
                return new int[]
                {
                    1,
                    1,
                    1
                };
            case 2:
                return new int[]
                {
                    2,
                    2,
                    2
                };
            case 3:
                return new int[]
                {
                    0,
                    1,
                    2
                };
            case 4:
                return new int[]
                {
                    2,
                    1,
                    0
                };
            case 5:
                return new int[]
                {
                    0,
                    1,
                    0
                };
            default:
                return new int[]
                {
                    2,
                    1,
                    2
                };
        }
    }

    /// <summary>Which cells of the grid belong to a line - used to punch the winners.</summary>
    public static void CellsOf(int[] _0xc3fa4c34, int[] _0xf00d808a)
    {
        for (int _0x3f4b93dc = 0; _0x3f4b93dc < _0x2da34b06.ReelColumns; _0x3f4b93dc++)
        {
            _0xf00d808a[_0x3f4b93dc] = _0xc3fa4c34[_0x3f4b93dc] * _0x2da34b06.ReelColumns + _0x3f4b93dc;
        }
    }
}