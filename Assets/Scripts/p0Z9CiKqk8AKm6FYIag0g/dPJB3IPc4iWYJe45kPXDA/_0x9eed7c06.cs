using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x9eed7c06 : MonoBehaviour
{
    public BoxCollider2D CameraTouchBounds;
    private void _0xa5c97ea3(Touch? _0xe7f9cfad)
    {
        if (!_0x44f9825a.Instance._0xae412e4f)
        {
            _0xe7f9cfad = null;
            return;
        }

        int _0xcc305ddc = _0xe7f9cfad.Value.touchId;
        _0xe7f9cfad = Touch.activeTouches.FirstOrDefault(_0x3b023bb9 => _0x3b023bb9.touchId == _0xcc305ddc);
        if (!this._0x8cb061c9(_0xe7f9cfad.Value))
            _0xe7f9cfad = null;
    }

    private Touch? _0x673bea02()
    {
        if (!_0x44f9825a.Instance._0xae412e4f)
            return null;
        foreach (Touch _0xf255b248 in Touch.activeTouches)
            if (_0xf255b248.ended)
                if (this._0x8cb061c9(_0xf255b248))
                    return _0xf255b248;
        return null;
    }

    private Touch? _0x80c3f614(Bounds _0xf57c7eef)
    {
        if (!_0x44f9825a.Instance._0xae412e4f)
            return null;
        foreach (Touch _0x2aba52de in Touch.activeTouches)
            if (!_0x2aba52de.ended)
            {
                Vector3 _0x75e22569 = Camera.main.ScreenToWorldPoint(_0x2aba52de.screenPosition);
                Vector3 _0xb6bd8273 = new(_0x75e22569.x, _0x75e22569.y, _0xf57c7eef.center.z);
                if (_0xf57c7eef.Contains(_0xb6bd8273) && this._0x8cb061c9(_0x2aba52de))
                    return _0x2aba52de;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xe9ea3555 = this.gameObject.GetComponent<_0x9eed7c06>();
    }

    private Touch? _0x42b0ef57(Bounds _0x503fd0ca, TouchPhase _0x151a2f37)
    {
        if (!_0x44f9825a.Instance._0xae412e4f)
            return null;
        foreach (Touch _0x03fd0b1d in Touch.activeTouches)
            if (_0x03fd0b1d.phase == _0x151a2f37)
            {
                Vector3 _0xbd5b7ff1 = Camera.main.ScreenToWorldPoint(_0x03fd0b1d.screenPosition);
                Vector3 _0xb6f71be8 = new(_0xbd5b7ff1.x, _0xbd5b7ff1.y, _0x503fd0ca.center.z);
                if (_0x503fd0ca.Contains(_0xb6f71be8) && this._0x8cb061c9(_0x03fd0b1d))
                    return _0x03fd0b1d;
            }

        return null;
    }

    private Touch? _0x86c56b62()
    {
        if (!_0x44f9825a.Instance._0xae412e4f)
            return null;
        foreach (Touch _0x76cf4952 in Touch.activeTouches)
            if (!_0x76cf4952.ended)
                if (this._0x8cb061c9(_0x76cf4952))
                    return _0x76cf4952;
        return null;
    }

    private Touch? _0xf5e0a4fd(Bounds _0x9da39104)
    {
        if (!_0x44f9825a.Instance._0xae412e4f)
            return null;
        foreach (Touch _0x9dea5acc in Touch.activeTouches)
            if (_0x9dea5acc.ended)
            {
                Vector3 _0xfa86a50f = Camera.main.ScreenToWorldPoint(_0x9dea5acc.screenPosition);
                Vector3 _0xf0857ae1 = new(_0xfa86a50f.x, _0xfa86a50f.y, _0x9da39104.center.z);
                if (_0x9da39104.Contains(_0xf0857ae1) && this._0x8cb061c9(_0x9dea5acc))
                    return _0x9dea5acc;
            }

        return null;
    }

    private bool _0x8cb061c9(Touch? _0x18ed4017)
    {
        if (!_0x18ed4017.HasValue)
            return false;
        Vector3 _0xaa7f03e5 = Camera.main.ScreenToWorldPoint(_0x18ed4017.Value.screenPosition);
        Vector3 _0x1a05729b = _0xaa7f03e5;
        _0x1a05729b.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x1a05729b))
            return true;
        _0x18ed4017 = null;
        return false;
    }

    private static _0x9eed7c06 _0xe9ea3555;
    private bool _0x2d1d8e1c(Touch? _0xe3c68e5f, Bounds _0xc85329b4, TouchPhase _0x98bbb819)
    {
        if (!_0x44f9825a.Instance._0xae412e4f)
        {
            _0xe3c68e5f = null;
            return false;
        }

        if (_0xe3c68e5f != null)
            if (_0xe3c68e5f.Value.phase == _0x98bbb819)
            {
                Vector3 _0xe211b9f4 = Camera.main.ScreenToWorldPoint(_0xe3c68e5f.Value.screenPosition);
                Vector3 _0xeaf929a8 = new(_0xe211b9f4.x, _0xe211b9f4.y, _0xc85329b4.center.z);
                if (_0xc85329b4.Contains(_0xeaf929a8) && this._0x8cb061c9(_0xe3c68e5f.Value))
                    return true;
            }

        return false;
    }
}