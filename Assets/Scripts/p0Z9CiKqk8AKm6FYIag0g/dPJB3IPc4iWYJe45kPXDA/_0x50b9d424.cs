using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xdfe619ff;

public class _0x50b9d424 : MonoBehaviour
{
    private void Start()
    {
        this._0xa396a91e();
    }

    public List<_0x19fbab3b> Panels;
    public float ScaleDuration = 0.4f;
    private _0x19fbab3b _0xa2ef36d2(int _0x9e276f3f)
    {
        return this.Panels[_0x9e276f3f];
    }

    public int CurrentPanelIndex;
    private void _0x2cf64141(int _0x2ecd9069)
    {
        this.LastPanelIndexes.Add(_0x2ecd9069);
        this.CurrentPanelIndex = _0x2ecd9069;
        for (int _0x65a86633 = 0; _0x65a86633 < this.Panels.Count; _0x65a86633++)
            if (_0x65a86633 != _0x2ecd9069 && this.Panels[_0x65a86633] != null)
                this.Panels[_0x65a86633]._0x50191284();
    }

    public void _0x36f446ad()
    {
        this.LastPanelIndexes.RemoveAll(_0x40359aea => _0x40359aea == this.CurrentPanelIndex);
        int _0xfad6053a = this.LastPanelIndexes.Last();
        this._0x3e241a89(_0xfad6053a);
        this._0x3222d53f(_0xfad6053a);
        this.CurrentPanelIndex = _0xfad6053a;
        this.Panels[_0xfad6053a].Show();
    }

    public bool IsShowSplashOnStart = true;
    private void _0x50e7d893(int _0xf3131436)
    {
        this._0x2cf64141(_0xf3131436);
        this._0x3e241a89(_0xf3131436);
        this.CurrentPanelIndex = _0xf3131436;
        this.Panels[_0xf3131436]._0x5789c04e();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0x19681e8b(int _0xacab0642)
    {
        this._0x2cf64141(_0xacab0642);
        this._0x3e241a89(_0xacab0642);
        this.CurrentPanelIndex = _0xacab0642;
        this.Panels[_0xacab0642].Show();
    }

    private void _0xa396a91e()
    {
        this._0x50e7d893(_0xa6411e87.SPLASH);
        if (_0x44f9825a.Instance._0x44bf2ec4 == _0x2cdb8663.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x40bf4df6.Instance.DefaultAnimationTime);
        }
    }

    private void _0x3222d53f(int _0x9f85a0c9)
    {
        this.LastPanelIndexes.Add(_0x9f85a0c9);
        this.CurrentPanelIndex = _0x9f85a0c9;
        for (int _0x9c2dd22f = 0; _0x9c2dd22f < this.Panels.Count; _0x9c2dd22f++)
            if (_0x9c2dd22f != _0x9f85a0c9 && this.Panels[_0x9c2dd22f] != null)
                this.Panels[_0x9c2dd22f]._0x50191284();
    }

    private void _0x3e241a89(int _0x081e4cc4)
    {
        if (_0x081e4cc4 == _0xa6411e87.SPLASH)
            _0x40bf4df6.Instance._0x874534a5();
        if (_0x44f9825a.Instance._0x44bf2ec4 == _0x2cdb8663.SCENE_0)
        {
        }
    }

    public void _0x91290ee6(int _0x1650ec2a)
    {
        if (_0x1650ec2a == _0xa6411e87.SPLASH && _0x44f9825a.Instance._0x44bf2ec4 != _0x2cdb8663.SCENE_0)
            _0x40bf4df6.Instance._0x4a6de6fb();
        if (_0x44f9825a.Instance._0x44bf2ec4 != _0x2cdb8663.SCENE_0)
        {
            if (_0x1650ec2a == _0xa6411e87.SPLASH || _0x1650ec2a == _0xa6411e87.TUTORIAL0)
                _0x44f9825a.Instance._0x787fc083(false);
            else if (_0x1650ec2a == _0xa6411e87.DEFAULT)
                _0x44f9825a.Instance._0x787fc083(true);
        }
    }

    private void SwitchSplash()
    {
        if (_0x7b20f5d1.Instance.IsTutorialEnabled && !_0x44f9825a._0x74fffb43._0x7a1b9f22)
            this._0x19681e8b(_0xa6411e87.TUTORIAL0);
        else
            this._0x19681e8b(_0xa6411e87.DEFAULT);
    }

    public float StaticBlurMaterialInitialValue;
    public static _0x50b9d424 Instance;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x50b9d424>();
    }
}