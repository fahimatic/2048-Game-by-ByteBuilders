using UnityEngine;

[CreateAssetMenu(menuName = "Tile State")]
public class TileState : ScriptableObject
{
    public Color backgroundColor;
    public Color textColor;

    public static int Length { get; internal set; }
}
