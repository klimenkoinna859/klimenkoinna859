using UnityEngine;

/// <summary>
/// The one thing the settings page can really switch off. This game is silent by
/// design and ships no playback of any kind, so the settings row is given to
/// something that really does something the player can feel.
/// </summary>
public static class _0xaf5af43d
{
    public static void Tick()
    {
        if (!_0xdfbe9389._0xa93024f2)
        {
            return;
        }

        Handheld.Vibrate();
    }
}