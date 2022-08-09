using UnityEngine;

public static class GameObjectExtensions
{
    public static bool IsInLayer(this GameObject go, LayerMask layer)
    {
        return layer == (layer | 1 << go.layer);
    }
    public static void ChangeColorByType(this GameObject go, ColorType color)
    {
        var sprite = go.GetComponent<SpriteRenderer>();
        if (sprite == null) return;

        switch (color)
        {
            case ColorType.Red:
                sprite.color = Color.red;
                break;
            case ColorType.Blue:
                sprite.color = Color.blue;
                break;
            case ColorType.Green:
                sprite.color = Color.green;
                break;
        }
    }
}
