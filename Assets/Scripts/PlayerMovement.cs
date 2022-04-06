using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    public float m_speed;
    #endregion

    //Toutes les fonctions Unity
    #region Unity Life Cycle
    public void Awake()
    {
        //Mon GameOBbject
        _rigidbody = GetComponent<Rigidbody>();
    }
    //Start is called before the first frame update
    void Start()
    {
        //recup d'infos d'autres GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // moteur graphique
        // ici on recup les inputs du joueur
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        float orientationHorizontal = Input.GetAxisRaw("RightStickX");
        float orientationVertical = Input.GetAxisRaw("RightStickY");
       
        _directionInput.x = horizontal;
        _directionInput.y = vertical;
        _orientationInput.x = orientationHorizontal;
        _orientationInput.y = orientationVertical;
    }

    void FixedUpdate()
    {
        // moteur physique
        // on utlise les inputs récupérés dans update pour appliquer la physique
        Vector3 orientation3D = new Vector3(_orientationInput.x, 0, _orientationInput.y);
        Vector3 direction3D = new Vector3(_directionInput.x, 0, _directionInput.y);
        Quaternion lookRotation = Quaternion.LookRotation(orientation3D);
        _rigidbody.velocity = direction3D * m_speed;
        if(_orientationInput != Vector3.zero)
        {
            _rigidbody.MoveRotation(lookRotation);
        }
        

    }
    #endregion

    //Toutes les fonctions créées par l'équipe
    #region Main Methods

    #endregion

    //Les variables privées et protégées
    #region Private & Protected

    private Vector2 _directionInput;
    private Vector3 _orientationInput;
    private Rigidbody _rigidbody;
    #endregion
}
