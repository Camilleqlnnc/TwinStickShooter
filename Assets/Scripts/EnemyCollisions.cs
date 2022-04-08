using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] IntVariable _playerCurrentHP;
    [SerializeField] IntVariable _enemyCount;
    [SerializeField] IntVariable _enemyStartHP;


    #endregion

    #region Unity Life Cycle
    void Awake()
    {
        _enemyHealth = _enemyStartHP._value;
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
    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerCurrentHP._value--;
            if (_playerCurrentHP._value <= 0)
            {
                gameObject.SetActive(false);
                FindObjectOfType<SoundManager>().Stop("Theme");
                FindObjectOfType<SoundManager>().Play("PlayerDeath");
                //GetComponent<Movement>().enabled = false;

            }
        }

    }*/
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            this._enemyHealth--;
            if(this._enemyHealth <= 0)
            {
                FindObjectOfType<SoundManager>().Play("EnemyDeath");
                Destroy(gameObject);
            }
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
    private float _enemyHealth;
    #endregion
}
