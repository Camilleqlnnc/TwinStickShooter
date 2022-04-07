using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    public string levelName;
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
    public void LoadLevel()
    {
        SceneManager.LoadScene(levelName);
    }
    #endregion

    //Les variables privées et protégées
    #region Private & Protected

    #endregion
}
