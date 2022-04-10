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
    public GameObject winMenu;
    public GameObject winMenuFirstButton;
    #endregion

    #region Unity Life Cycle
    void Awake()
    {
        _enemyHealth = _enemyStartHP._value;
        _enemyCount._value = GameObject.FindGameObjectsWithTag("Enemy").Length;
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

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            this._enemyHealth--;
            FindObjectOfType<SoundManager>().Play("EnemyImpact");
            if (this._enemyHealth <= 0)
            {
                FindObjectOfType<SoundManager>().Stop("EnemyImpact");
                FindObjectOfType<SoundManager>().Play("EnemyDeath");
                Destroy(gameObject);
                
            }
        }
    }
    private void OnDestroy()
    {
        _enemyCount._value--;
        if(_enemyCount._value <= 0)
        {
            FindObjectOfType<SoundManager>().Play("Victory");
            winMenu.SetActive(true);
        }
    }
    
    #endregion

    //Les variables privées et protégées
    #region Private & Protected
    private float _enemyHealth;
    #endregion
}
