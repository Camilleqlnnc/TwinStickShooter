using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] IntVariable _currentPlayerHP;
    [SerializeField] IntVariable _enemyCount;
    public GameObject winMenu;
    public GameObject winMenuFirstButton;
    #endregion

    #region Unity Life Cycle

    // Update is called once per frame
    void Awake()
    {
        _enemyCount._value = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
        
    void Update()
    {
        
    }
    #endregion
    //Toutes les fonctions créées par l'équipe
    #region Main Methods
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadNextLevel()
    {
        StartCoroutine(WaitForSceneLoad());
    }
    public void OpenWinMenu()
    {
        winMenu.SetActive(true);
        Time.timeScale = 0f;
        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set a new selected object
        EventSystem.current.SetSelectedGameObject(winMenuFirstButton);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Win()
    {
            FindObjectOfType<SoundManager>().Play("Victory");
            OpenWinMenu();
    }

    private void Lose()
    {
        Debug.Log("LOSE, TRY AGAIN");
        //audioSource.PlayOneShot(_lose);
    }
    #endregion

    //Les variables privées et protégées
    #region Private & Protected

    #endregion
}
