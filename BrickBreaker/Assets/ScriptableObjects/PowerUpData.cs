using UnityEngine;

[CreateAssetMenu(fileName = "New PowerUpData", menuName = "PowerUp Data")]
public class PowerUpData : ScriptableObject
{
    public string powerUpName;
    public Sprite icon;
    public float duration;
    public int bonusPoints;
    // Add more properties as needed for your power-ups.
}

//Code from ChatGBT