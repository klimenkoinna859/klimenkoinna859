using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x40bf4df6 : MonoBehaviour
{
    public static _0x40bf4df6 Instance;
    public void _0x874534a5()
    {
        this._0xd7763896?.Kill();
        this.AnimationSlider.value = _0xfd58e629 ? this.SecondPassSliderValue : 0.05f;
    }

    public float FirstAnimationTime = 10.0f;
    public GameObject Background;
    private static bool _0xfd58e629 = false;
    public Slider AnimationSlider;
    public void _0xaa62707a()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xd7763896?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xfd58e629 = false;
    }

    public float DefaultAnimationTime = 0.4f;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xdfe619ff._0x2cdb8663.SCENE_0 && !_0xfd58e629)
        {
            this._0xf3170e0d();
        }
        else
        {
            this._0x4a6de6fb();
        }
    }

    private void _0xf3170e0d()
    {
        this.AnimationSlider.value = 0.05f;
        _0xfd58e629 = !_0xfd58e629;
        this._0xd7763896 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xe5d6df2a => this.AnimationSlider.value = _0xe5d6df2a, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x3fce9c43._0x7ff8141d?._0xd9e99330();
        });
    }

    public float SecondPassSliderValue = 0.5f;
    public GameObject Content;
    public void _0x08c531e6()
    {
        this._0xd7763896?.Pause();
    }

    public void _0x4a6de6fb()
    {
        this._0x874534a5();
        bool _0x2b19982b = _0xfd58e629;
        this._0xd7763896 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xe5d6df2a => this.AnimationSlider.value = _0xe5d6df2a, _0x2b19982b ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xfd58e629 = !_0xfd58e629;
    }

    public GameObject Error;
    private Sequence _0xd7763896;
    public void _0x8bf17f98()
    {
        this._0xd7763896?.Play();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x40bf4df6>();
    }
}