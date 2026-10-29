using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x4a9b13df : MonoBehaviour
{
    private new Camera _0xa52a1623;
    private Vector3 _0xfeb28f99 { get; set; }
    private Vector3 _0xbd607cab { get; set; }
    private Vector3 _0xc327a262 { get; set; }
    private Vector3 _0x5ff1ac12 { get; set; }
    private Vector3 _0x0b4f780b { get; set; }

    public enum _0x254cf90d
    {
        Landscape,
        Portrait
    }

    private float _0x32073634 = 1;
    private float _0x25aeaf2d { get; set; }
    private Vector3 _0xbd64a384 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x9404ecc1;
        Matrix4x4 _0xf4ba1b62 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xa52a1623.orthographic)
        {
            float _0x37f1e1b3 = this._0xa52a1623.farClipPlane - this._0xa52a1623.nearClipPlane;
            float _0xdfe3cc0c = (this._0xa52a1623.farClipPlane + this._0xa52a1623.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xdfe3cc0c), new Vector3(this._0xa52a1623.orthographicSize * 2 * this._0xa52a1623.aspect, this._0xa52a1623.orthographicSize * 2, _0x37f1e1b3));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xa52a1623.fieldOfView, this._0xa52a1623.farClipPlane, this._0xa52a1623.nearClipPlane, this._0xa52a1623.aspect);
        }

        Gizmos.matrix = _0xf4ba1b62;
    }

    private void Awake()
    {
        this._0xa52a1623 = this.GetComponent<Camera>();
        _0xa209b6fc = this;
        this._0xb056fb5b();
    }

    private Vector3 _0x52fc5b8e { get; set; }
    private Vector3 _0x2213a380 { get; set; }

    private _0x254cf90d _0xa092ee95 = _0x254cf90d.Portrait;
    private Vector3 _0x92b638d2 { get; set; }
    //public bool executeInUpdate;
    private float _0x3ffeb1e9 { get; set; }

    private static _0x4a9b13df _0xa209b6fc;
    private void _0xb056fb5b()
    {
        float _0x5c4fdfe3, _0xd024d6bb, _0x4b7957be, _0xe88bf9e1;
        if (this._0xa092ee95 == _0x254cf90d.Landscape)
            this._0xa52a1623.orthographicSize = 1f / this._0xa52a1623.aspect * this._0x32073634 / 2f;
        else
            this._0xa52a1623.orthographicSize = this._0x32073634 / 2f;
        this._0x25aeaf2d = 2f * this._0xa52a1623.orthographicSize;
        this._0x3ffeb1e9 = this._0x25aeaf2d * this._0xa52a1623.aspect;
        float _0xce5b65d9 = this._0xa52a1623.transform.position.x;
        float _0xc4d5357d = this._0xa52a1623.transform.position.y;
        _0x5c4fdfe3 = _0xce5b65d9 - this._0x3ffeb1e9 / 2;
        _0xd024d6bb = _0xce5b65d9 + this._0x3ffeb1e9 / 2;
        _0x4b7957be = _0xc4d5357d + this._0x25aeaf2d / 2;
        _0xe88bf9e1 = _0xc4d5357d - this._0x25aeaf2d / 2;
        this._0xbd607cab = new Vector3(_0x5c4fdfe3, _0xe88bf9e1, 0);
        this._0xc327a262 = new Vector3(_0xce5b65d9, _0xe88bf9e1, 0);
        this._0xbd64a384 = new Vector3(_0xd024d6bb, _0xe88bf9e1, 0);
        this._0x52fc5b8e = new Vector3(_0x5c4fdfe3, _0xc4d5357d, 0);
        this._0x2213a380 = new Vector3(_0xce5b65d9, _0xc4d5357d, 0);
        this._0xfeb28f99 = new Vector3(_0xd024d6bb, _0xc4d5357d, 0);
        this._0x92b638d2 = new Vector3(_0x5c4fdfe3, _0x4b7957be, 0);
        this._0x0b4f780b = new Vector3(_0xce5b65d9, _0x4b7957be, 0);
        this._0x5ff1ac12 = new Vector3(_0xd024d6bb, _0x4b7957be, 0);
    }

    private Color _0x9404ecc1 = Color.white;
}