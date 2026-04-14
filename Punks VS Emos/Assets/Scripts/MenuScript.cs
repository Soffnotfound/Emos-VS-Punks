using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private GameObject currentState;

    public enum MenuStates
    {
        Main,
        Levels,
        Options,
        Credits,
        Controls,
    };

    public GameObject mainMenu;
    public GameObject levelMenu;
    public GameObject optionsMenu;
    public GameObject creditsMenu;
    public GameObject controlsMenu;

    void Start()
    {
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
        controlsMenu.SetActive(false);
    }

    public void back()
    {
        Debug.Log("back to main menu");
        switchMenu(MenuStates.Main);
    }

    public void menu()
    {
        Debug.Log("go to menu");
        switchMenu(MenuStates.Main);
    }

    public void levels()
    {
        Debug.Log("levels selected");
        switchMenu(MenuStates.Levels);
    }

    public void options()
    {
        Debug.Log("options selected");
        switchMenu(MenuStates.Options);
    }

    public void credits()
    {
        Debug.Log("credits selected");
        switchMenu(MenuStates.Credits);
    }

    public void controls()
    {
        Debug.Log("controls selected");
        switchMenu(MenuStates.Controls);
    }

    public void levelOne()
    {
        Debug.Log("level 1 selected");
        SceneManager.LoadScene("GameplayLV1");
    }

    public void quit()
    {
        Debug.Log("quitting game");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void switchMenu(MenuStates menu)
    {
        GameObject newState;

        switch (menu)
        {
            case MenuStates.Main:
                newState = mainMenu;
                break;
            case MenuStates.Levels:
                newState = levelMenu;
                break;
            case MenuStates.Options:
                newState = optionsMenu;
                break;
            case MenuStates.Credits:
                newState = creditsMenu;
                break;
            case MenuStates.Controls:
                newState = controlsMenu;
                break;
            default:
                newState = mainMenu;
                break;
        }

        // Desactivar el menú anterior antes de cambiar
        if (currentState != null)
            currentState.SetActive(false);

        currentState = newState;
        currentState.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey("return") && mainMenu.activeSelf)
        {
            levels();
        }

        if (Input.GetKeyDown("escape"))
        {
            if (mainMenu.activeSelf)
            {
                Application.Quit();
                Debug.Log("Saliendo del juego");
            }
            else
            {
                menu();
            }
        }
    }
}
