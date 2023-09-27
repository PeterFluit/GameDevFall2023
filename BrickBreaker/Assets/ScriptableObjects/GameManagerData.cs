using UnityEngine;

[CreateAssetMenu(fileName = "GameManagerData", menuName = "ScriptableObjects/GameManagerData", order = 1)]
public class GameManagerData : ScriptableObject
{
    public int playerLives = 3;
    public int score = 0;
    public int currentLevel = 1;
    // Add more variables as needed
}

//Code from ChatGBT