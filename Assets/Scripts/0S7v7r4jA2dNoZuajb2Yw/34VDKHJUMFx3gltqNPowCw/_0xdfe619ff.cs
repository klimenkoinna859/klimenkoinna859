using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xdfe619ff
{
    public static class _0xd23f50e2
    {
        public static int _0xf3225ca8
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x8fc739b8._0x4ea4ea10(new byte[5] { 164, 136, 142, 137, 148 }, 231)))
                    PlayerPrefs.SetInt(_0x8fc739b8._0x4ea4ea10(new byte[5] { 201, 229, 227, 228, 249 }, 138), 0);
                return PlayerPrefs.GetInt(_0x8fc739b8._0x4ea4ea10(new byte[5] { 98, 78, 72, 79, 82 }, 33));
            }

            set
            {
                PlayerPrefs.SetInt(_0x8fc739b8._0x4ea4ea10(new byte[5] { 148, 184, 190, 185, 164 }, 215), value);
                _0x44f9825a.Instance._0x08c8c9cb();
            }
        }
    }

    public static class _0xdfb977df
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0x89f3dc99
    {
        private static readonly _0x89f3dc99 _0x4a2ec54b = new();
        public static readonly _0x89f3dc99[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x4a2ec54b,
            _0x4a2ec54b,
            _0x4a2ec54b,
        };
        private int _0x3aee8b66 => 0;
        private int _0xf6261602 => 10;
        private string _0x0e7249ce => _0x8fc739b8._0x4ea4ea10(new byte[4] { 208, 248, 243, 232 }, 157);
        private string _0x66c0e6c7 => _0x8fc739b8._0x4ea4ea10(new byte[8] { 21, 28, 15, 28, 21, 34, 105, 36 }, 89);

        private int _0x4cdef6e4
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x8fc739b8._0x4ea4ea10(new byte[25] { 0, 54, 49, 49, 38, 45, 55, 4, 47, 44, 33, 34, 47, 0, 43, 34, 51, 55, 38, 49, 10, 45, 39, 38, 59 }, 67)))
                    PlayerPrefs.SetInt(_0x8fc739b8._0x4ea4ea10(new byte[25] { 71, 113, 118, 118, 97, 106, 112, 67, 104, 107, 102, 101, 104, 71, 108, 101, 116, 112, 97, 118, 77, 106, 96, 97, 124 }, 4), 0);
                return PlayerPrefs.GetInt(_0x8fc739b8._0x4ea4ea10(new byte[25] { 221, 235, 236, 236, 251, 240, 234, 217, 242, 241, 252, 255, 242, 221, 246, 255, 238, 234, 251, 236, 215, 240, 250, 251, 230 }, 158));
            }

            set => PlayerPrefs.SetInt(_0x8fc739b8._0x4ea4ea10(new byte[25] { 139, 189, 186, 186, 173, 166, 188, 143, 164, 167, 170, 169, 164, 139, 160, 169, 184, 188, 173, 186, 129, 166, 172, 173, 176 }, 200), value);
        }

        public int _0x8c192152
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x0e7249ce}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x0e7249ce}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x0e7249ce}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x0e7249ce}CurrentLevelIndex", value);
        }

        public int _0xcab2d2d4
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x0e7249ce}BestScore"))
                    this._0xcab2d2d4 = 0;
                return PlayerPrefs.GetInt($"{this._0x0e7249ce}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x0e7249ce}BestScore", value);
        }

        public bool _0x7a1b9f22
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x0e7249ce}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x0e7249ce}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x0e7249ce}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x0e7249ce}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xa6411e87
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x2cdb8663
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x8fc739b8
{
    internal static string _0x4ea4ea10(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}