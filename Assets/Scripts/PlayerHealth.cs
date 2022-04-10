using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] IntVariable _playerStartHP;
    [SerializeField] IntVariable _playerCurrentHP;
    public GameObject _leftWing;
    public GameObject _rightWing;
    public GameObject loseMenu;
    #endregion

    #region Unity Life Cycle
    void Awake()
    {
        _playerCurrentHP._value = _playerStartHP._value;
    }
    #endregion
    //Toutes les fonctions créées par l'équipe
    #region Main Methods
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _playerCurrentHP._value--;
            FindObjectOfType<SoundManager>().Play("PlayerImpact");
        }
        if(_playerCurrentHP._value <= 2)
        {
            _rightWing.SetActive(false);
        }
        if(_playerCurrentHP._value <= 1)
        {
            _leftWing.SetActive(false);
        }
        if(_playerCurrentHP._value <= 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<SoundManager>().Stop("Theme");
            FindObjectOfType<SoundManager>().Play("PlayerDeath");
            OpenLoseMenu();

        }
    }
    public void OpenLoseMenu()
    {
        loseMenu.SetActive(true);
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    public void LoadTitleMenu()
    {
        StartCoroutine(WaitForReloadTitleMenu());

    }

    public void QuitGame()
    {
        Application.Quit();
    }
    #endregion
    private IEnumerator WaitForReloadTitleMenu()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("TitleMenu");
    }
    //Les variables privées et protégées
    #region Private & Protected

    #endregion
}
