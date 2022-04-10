using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{

    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] float levelLoadDelay = 1f;
    public GameObject titleMenu, controlMenu;
    public GameObject menuFirstButton, controlFirstButton, controlCloseButton;
    #endregion

    #region Unity Life Cycle
    #endregion
    #region Main Methods

    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayGame()
    {
        StartCoroutine(WaitForSceneLoad());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenOptions()
    {
        controlMenu.SetActive(true);
        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set a new selected object
        EventSystem.current.SetSelectedGameObject(controlFirstButton);
    }

    public void CloseOptions()
    {
        controlMenu.SetActive(false);
        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set a new selected object
        EventSystem.current.SetSelectedGameObject(menuFirstButton);

    }
    #endregion
}
