using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] IntVariable _currentPlayerHP;
    [SerializeField] IntVariable _enemyCount;


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
    }

    private void Lose()
    {
        Debug.Log("LOSE, TRY AGAIN");
    }
    #endregion

    //Les variables privées et protégées
    #region Private & Protected

    #endregion
}
