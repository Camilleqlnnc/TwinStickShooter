using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
            Debug.Log("collision");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Debug.Log("collision bullet");
        }
    }
    #endregion

    //Les variables privées et protégées
    #region Private & Protected

    #endregion
}
