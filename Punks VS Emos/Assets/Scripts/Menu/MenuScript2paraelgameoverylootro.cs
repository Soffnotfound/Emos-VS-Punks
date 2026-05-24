using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript2paraelgameoverylootro : MonoBehaviour
{
    public void RestartGame()
    {
        Debug.Log("Returning to Gameplay Lv1...");
        SceneManager.LoadScene("GameplayLv1");
    }

    public void ReturnToMainMenu()
    {
        Debug.Log("Returning to Main Menu...");
        SceneManager.LoadScene("StartMenu");
    }
}
