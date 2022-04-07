using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] IntVariable _playerCurrentHP;
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
        
    }
    #endregion
    //Toutes les fonctions créées par l'équipe
    #region Main Methods
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerCurrentHP._value--;
            Debug.Log("collision");
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Debug.Log("collision bullet");
        }
    }
    private void OnDestroy()
    {
        _enemyCount._value--;
        Debug.Log(_enemyCount._value);
    }
    #endregion

    //Les variables privées et protégées
    #region Private & Protected

    #endregion
}
