using DG.Tweening;
using UnityEngine;

/// <summary>
/// Owns the game scene. Builds the HUD and the cabinet inside PANELS.DEFAULT's own
/// Content, generates the act, and keeps the run and the pops in step.
///
/// §C.59: everything happens in Start. The template fills BasicController,
/// PanelController and PopsController in Awake, and a generated Awake would race them.
/// </summary>
public sealed class _0x94bb4b1e : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private _0x69cd18a4 _0x178a6ab7;
    private void _0x69b8a4c6()
    {
        if (this._0x178a6ab7 != null)
        {
            this._0x178a6ab7._0x966935c8();
        }
    }

    private _0x22a0a22b _0xa312475a;
    private void _0x62ce99a8(int _0x51d84788, int _0xd3365153, bool _0xfed894d9)
    {
        if (this._0x756c906a != null && this._0xeaaf5686)
        {
            this._0x756c906a._0x2291d38d(_0x51d84788, _0xd3365153);
        }
    }

    private void _0xc4c6f8fb(int _0xd2d23283, int _0xe6b9c3d9, bool _0x10957f28)
    {
        if (this._0x756c906a != null)
        {
            this._0x756c906a._0x1ba174cc(_0xd2d23283, _0xe6b9c3d9, _0x10957f28);
        }
    }

    /// <summary>
    /// The template's RESUME button only hides the pop - nothing tells the game. The
    /// pop dimmer going down is the one signal that is true whichever way the pop was
    /// closed, so the run is never left frozen behind a pop that is no longer there.
    /// </summary>
    private void Update()
    {
        if (!this._0xeaaf5686 || this._0x178a6ab7 == null || this._0x178a6ab7._0x489508e7 != _0x69cd18a4.StatePaused)
        {
            return;
        }

        if (_0x18ece92a.Instance == null || _0x18ece92a.Instance.BlurBackground == null)
        {
            return;
        }

        if (!_0x18ece92a.Instance.BlurBackground.activeSelf)
        {
            this._0x178a6ab7._0xfbc0977d();
        }
    }

    [SerializeField]
    private _0xe0927a8a _art;
    private bool _0xeaaf5686;
    private _0xa8c064dc _0x7a6a47f4;
    private void _0x77808acb()
    {
        if (this._0x178a6ab7 != null)
        {
            this._0x178a6ab7._0x5752994f();
        }
    }

    private void _0x6dff7c5f(int _0x6b2218f1)
    {
        if (this._0xdf7256d8 == null)
        {
            return;
        }

        this._0xdf7256d8._0x6d835d64(_0x6b2218f1);
        _0xaf5af43d.Tick();
        this._0x0ce72717();
    }

    [SerializeField]
    private _0xec8f07c1 _cellPrefab;
    private void _0xf4eff7f4()
    {
        if (_0xdfe619ff._0xa6411e87.SPLASH >= _0x50b9d424.Instance.Panels.Count)
        {
            return;
        }

        _0x19fbab3b _0x33ae7c6e = _0x50b9d424.Instance.Panels[_0xdfe619ff._0xa6411e87.SPLASH];
        if (_0x33ae7c6e == null || _0x33ae7c6e.Content == null)
        {
            return;
        }

        _0x82aa694c _0x3fd73f4b = _0x33ae7c6e.gameObject.AddComponent<_0x82aa694c>();
        _0x3fd73f4b._0x8f31eaa3(this._art, _0x33ae7c6e.Content.transform);
    }

    private void _0x0ce72717()
    {
        if (!this._0xeaaf5686 || this._0x756c906a == null || this._0x178a6ab7 == null)
        {
            return;
        }

        while (this._0x9a5ec9eb < this._0x178a6ab7._0xaad3d859 && this._0x9a5ec9eb < _0x2da34b06.ActStarGoal)
        {
            this._0x756c906a._0x3449bc38(this._0x9a5ec9eb);
            this._0x9a5ec9eb++;
        }

        this._0x756c906a.Refresh(this._0x178a6ab7, _0xdfbe9389._0x8d6a1c71);
    }

    private void Start()
    {
        if (this._art == null || _0x50b9d424.Instance == null)
        {
            return;
        }

        this._0xf4eff7f4();
        this._0x9af56c3a();
    }

    private _0xd7901260 _0x756c906a;
    private int _0x9a5ec9eb;
    private _0x236224c8 _0xdf7256d8;
    [SerializeField]
    private _0xc5d7f584 _pipPrefab;
    private void _0x9af56c3a()
    {
        if (_0xdfe619ff._0xa6411e87.DEFAULT >= _0x50b9d424.Instance.Panels.Count)
        {
            return;
        }

        _0x19fbab3b _0x9cbf7001 = _0x50b9d424.Instance.Panels[_0xdfe619ff._0xa6411e87.DEFAULT];
        if (_0x9cbf7001 == null || _0x9cbf7001.Content == null)
        {
            return;
        }

        // Anything the template still has in this body is its own placeholder set; our
        // HUD goes in as the first sibling so it never sits on top of the template's
        // chrome, and the cleaner blanks whatever text is left over.
        RectTransform _0x6d57aaf6 = _0x98589ea5.Full(_0x9cbf7001.Content.transform, _0xd23db338._0x10ca1d1b(new byte[8] { 82, 112, 103, 64, 103, 114, 116, 118 }, 19), 0f);
        _0x6d57aaf6.SetAsFirstSibling();
        this._0xdf7256d8 = this.gameObject.AddComponent<_0x236224c8>();
        this._0xdf7256d8._0xff7f2904();
        this._0xa312475a = this.gameObject.AddComponent<_0x22a0a22b>();
        this._0xa312475a._0xec087e36(this._art);
        this._0x756c906a = _0x6d57aaf6.gameObject.AddComponent<_0xd7901260>();
        this._0x756c906a._0x11420b04(this._art, this._pipPrefab, () => this._0x69b8a4c6(), () => this._0x77808acb(), (_0x881f7439) => this._0x6dff7c5f(_0x881f7439));
        this._0x7a6a47f4 = this._0x756c906a._0xc1ff266a.gameObject.AddComponent<_0xa8c064dc>();
        this._0x7a6a47f4._0xc830b945(this._art, this._cellPrefab);
        _0xb6165fcc _0xac0f2371 = this.gameObject.AddComponent<_0xb6165fcc>();
        _0xfe7794e1 _0x99d4a0fc = _0xac0f2371._0x30dee124(_0xdfbe9389._0xf4d88f87, _0xdfbe9389._0x6f7325e5);
        this._0x178a6ab7 = this.gameObject.AddComponent<_0x69cd18a4>();
        this._0x178a6ab7.Changed += () => this._0x0ce72717();
        this._0x178a6ab7.SpinResolved += (_0x86af46a9, _0x52684def, _0x3cf4ab8c) => this._0xc4c6f8fb(_0x86af46a9, _0x52684def, _0x3cf4ab8c);
        this._0xdf7256d8.Changed += (_0x0d7a6462, _0x2f0a3efd, _0x3cf4ab8c) => this._0x62ce99a8(_0x0d7a6462, _0x2f0a3efd, _0x3cf4ab8c);
        this._0x178a6ab7._0x63e58808(_0x99d4a0fc, this._0x7a6a47f4, this._0xdf7256d8, this._0xa312475a);
        _0x1a6ed7e6 _0xb13a6975 = this.gameObject.AddComponent<_0x1a6ed7e6>();
        _0xb13a6975._0x62f6649d();
        this._0xeaaf5686 = true;
        this._0x0ce72717();
    }
}

internal static class _0xd23db338
{
    internal static string _0x10ca1d1b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}