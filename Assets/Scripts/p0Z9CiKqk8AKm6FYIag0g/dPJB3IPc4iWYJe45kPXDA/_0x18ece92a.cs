using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xdfe619ff;

public class _0x18ece92a : MonoBehaviour
{
    public List<int> LastPopIndexes = new();
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x84a83be7 _0x3d94db86 in this.Pops)
            if (_0x3d94db86 != null)
                _0x3d94db86.gameObject.SetActive(true);
    }

    public float ScaleDuration = 0.4f;
    public List<_0x84a83be7> Pops;
    public void _0x97e1675c(int _0x25d6fc7b)
    {
        this.CurrentPopIndex = _0x25d6fc7b;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xf165991a(true);
        this._0xbd81674e();
        this.Pops[_0x25d6fc7b].Show();
        foreach (GameObject _0x170fe5a0 in this.GameObjectsToHide)
            _0x170fe5a0.SetActive(false);
    }

    public List<GameObject> GameObjectsToHide;
    public GameObject BlurBackground;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public _0x84a83be7 _0xd86b69da(int _0x6e43d4a5)
    {
        return this.Pops[_0x6e43d4a5];
    }

    public void _0xb88f638f()
    {
        this.LastPopIndexes.Clear();
        this._0xf165991a();
        foreach (GameObject _0x95c5f15e in this.GameObjectsToHide)
            if (_0x95c5f15e != null)
                _0x95c5f15e.SetActive(true);
        this._0x76e9adac();
    }

    public static _0x18ece92a Instance;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x18ece92a>();
    }

    private void _0xbd81674e()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public int CurrentPopIndex;
    private void _0x76e9adac()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void _0xf165991a(bool _0x81fcd310 = false)
    {
        for (int _0x78ffdee7 = 0; _0x78ffdee7 < this.Pops.Count; ++_0x78ffdee7)
            if (this.Pops[_0x78ffdee7] != null && !(_0x78ffdee7 == this.CurrentPopIndex && _0x81fcd310))
                this.Pops[_0x78ffdee7]._0x606d29ea();
    }

    public void _0xe670cf8c()
    {
        this.LastPopIndexes.RemoveAll(_0x40359aea => _0x40359aea == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xb88f638f();
        else
            this._0x97e1675c(this.LastPopIndexes.Last());
    }
}