using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xdfe619ff;

public class _0x44f9825a : MonoBehaviour
{
    public static bool IsAfterLevelFailed = false;
    public void _0x787fc083(bool _0x3c327f2b)
    {
        this._0xae412e4f = _0x3c327f2b;
        this._0x6f65afe2(!this._0xae412e4f);
        Physics2D.simulationMode = this._0xae412e4f ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xfcdc1f15(this.EnvironmentWithTweensToToggle);
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    [HideInInspector]
    public List<_0x5cc60f4d> MoneyCountContainers = new();
    public void _0x0e9ebb6d(int _0xa8e9b913)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x0a9e21c8(_0xa8e9b913));
    }

    public Canvas MainCanvas;
    private static void MakeGrid(List<RectTransform> _0x57080fdd, AspectRatioFitter _0x29704fec, float _0x9c68a265, int _0x0d0cf2d8, int _0x46c8b0eb)
    {
        _0x29704fec.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x29704fec.aspectRatio = _0x9c68a265;
        foreach (RectTransform _0x37feb510 in _0x57080fdd)
        {
            int _0x5393539c = _0x37feb510.transform.GetSiblingIndex();
            _0x37feb510.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x5393539c % _0x0d0cf2d8) * (1f / _0x0d0cf2d8), (_0x46c8b0eb - (Mathf.FloorToInt((float)_0x5393539c / _0x0d0cf2d8) % _0x46c8b0eb + 1f)) * (1f / _0x46c8b0eb));
            _0x37feb510.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x5393539c % _0x0d0cf2d8 + 1f) * (1f / _0x0d0cf2d8), (_0x46c8b0eb - Mathf.FloorToInt((float)_0x5393539c / _0x0d0cf2d8) % _0x46c8b0eb) * (1f / _0x46c8b0eb));
            _0x37feb510.offsetMin = Vector2.zero;
            _0x37feb510.offsetMax = Vector2.zero;
        }
    }

    private static _0x89f3dc99 _0xb3de542c => _0x89f3dc99.ALL_SCENES_SETTING_SINGLETONS[0];

    public void _0xf833d71b()
    {
        this._0x0e9ebb6d(SceneManager.GetActiveScene().buildIndex);
    }

    private void _0xfcdc1f15(Transform _0x72908b32)
    {
        Transform[] _0x0450f36d = _0x72908b32.GetComponentsInChildren<Transform>();
        foreach (Transform _0x65069eeb in _0x0450f36d)
            if (_0x65069eeb != null && DOTween.IsTweening(_0x65069eeb))
            {
                if (this._0xae412e4f)
                    DOTween.Play(_0x65069eeb);
                else
                    DOTween.Pause(_0x65069eeb);
            }
    }

    public static bool IsAfterLevelComplete;
    private IEnumerator _0x08f38be4(string _0x3970c24d)
    {
        _0x50b9d424.Instance._0x19681e8b(_0xa6411e87.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xeb5b1610 = SceneManager.LoadSceneAsync(_0x3970c24d);
        while (!_0xeb5b1610.isDone)
            yield return null;
    }

    public Transform EnvironmentWithTweensToToggle;
    public Button ShowResetTutorialButton;
    public void _0x08c8c9cb()
    {
        foreach (_0x5cc60f4d _0x6858511a in this.MoneyCountContainers)
            _0x6858511a._0x6a8a4ab4();
    }

    private static _0x89f3dc99 GAME_INDEX_SETTINGS(int _0x3afa8135)
    {
        return _0x89f3dc99.ALL_SCENES_SETTING_SINGLETONS[_0x3afa8135];
    }

    public static _0x89f3dc99 _0x74fffb43 => _0x89f3dc99.ALL_SCENES_SETTING_SINGLETONS[Instance._0x44bf2ec4];

    private void _0xfb6752d4()
    {
        IsAfterLevelComplete = true;
        Instance._0x0e9ebb6d(_0x2cdb8663.SCENE_0);
    }

    private IEnumerator _0x0a9e21c8(int _0x4e6c6e08)
    {
        _0x50b9d424.Instance._0x19681e8b(_0xa6411e87.SPLASH);
        AsyncOperation _0x430cbb1a = SceneManager.LoadSceneAsync(_0x4e6c6e08);
        while (!_0x430cbb1a.isDone)
            yield return null;
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x44f9825a>();
        this.RootGameObject = GameObject.FindWithTag(_0x3ed97459._0xd07bf449(new byte[4] { 180, 137, 137, 146 }, 230));
        if (this._0x44bf2ec4 == _0x2cdb8663.SCENE_0)
            this._0x787fc083(true);
        else
            this._0x787fc083(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x5cc60f4d>(true).ToList();
    }

    public static _0x44f9825a Instance;
    public Button DeleteProgressDataButton;
    public void _0x0f1c8f25()
    {
        _0x74fffb43._0x7a1b9f22 = true;
    }

    private void Start()
    {
        if (this._0x44bf2ec4 != _0x2cdb8663.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x0e9ebb6d(_0x2cdb8663.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x74fffb43._0x7a1b9f22 = false;
            _0x18ece92a.Instance._0xb88f638f();
            _0x50b9d424.Instance._0x19681e8b(_0xa6411e87.TUTORIAL0);
        });
    }

    private void _0x6f65afe2(bool _0x1c241251)
    {
        Rigidbody2D[] _0x2abe3c65 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x0a069553 in _0x2abe3c65)
            if (_0x1c241251)
                _0x0a069553.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x0a069553.constraints = RigidbodyConstraints2D.None;
    }

    public int _0x44bf2ec4 => SceneManager.GetActiveScene().buildIndex;

    public Transform Environment;
    public bool _0xae412e4f { get; private set; }
}

internal static class _0x3ed97459
{
    internal static string _0xd07bf449(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}