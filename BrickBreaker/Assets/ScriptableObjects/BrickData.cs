using UnityEngine;

[CreateAssetMenu(fileName = "New Brick Data", menuName = "Brick Breaker/Brick Data")]
public class BrickData : ScriptableObject
{
    public int health = 1;
    public Color brickColor = Color.white;
    public GameObject destructionEffect;

}

//Code from ChatGBT