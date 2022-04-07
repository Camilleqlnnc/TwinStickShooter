using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] IntVariable _enemyStartHP;
    [SerializeField] IntVariable _enemyCurrentHP;
    #endregion

    #region Unity Life Cycle
    void Awake()
    {
        _enemyCurrentHP._value = _enemyStartHP._value;

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
