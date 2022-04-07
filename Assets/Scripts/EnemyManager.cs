using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] IntVariable _enemyCount;
    #endregion

    #region Unity Life Cycle
    void Awake()
    {
        int currentNbEnemy;
        currentNbEnemy = GameObject.FindGameObjectsWithTag("Enemy").Length;
        _enemyCount._value = currentNbEnemy;
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

    #endregion

    //Les variables privées et protégées
    #region Private & Protected
    #endregion
}
