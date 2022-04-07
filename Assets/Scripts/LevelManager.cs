using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] IntVariable _currentPlayerHP;
    [SerializeField] IntVariable _enemyCount;
    /*[SerializeField] AudioClip _win;
    [SerializeField] AudioClip _lose;
    AudioSource audioSource;*/
    #endregion

    #region Unity Life Cycle
    void Awake()
    {
        //audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_enemyCount._value <= 0)
        {
            Win();
        }
        else if(_currentPlayerHP._value <= 0)
        {
            Lose();
        }
    }
    #endregion
   //Toutes les fonctions créées par l'équipe
    #region Main Methods
    private void Win()
    {
        Debug.Log("WINNER");
        //audioSource.PlayOneShot(_win);
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
