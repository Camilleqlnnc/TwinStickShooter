using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public GameObject titleMenu, controlMenu;
    public GameObject menuFirstButton, controlFirstButton, controlCloseButton;
    //Toutes les variables accessibles dans l'inspector
    #region Exposed

    #endregion

    #region Unity Life Cycle
    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
   //Toutes les fonctions créées par l'équipe
    #region Main Methods
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("quit game");
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

    //Les variables privées et protégées
    #region Private & Protected

    #endregion
}
