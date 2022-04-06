using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] Transform _playerTransform;
    [SerializeField] float r_speed = 10f;
    [SerializeField] float m_speed = 10f;


    #endregion

    #region Unity Life Cycle
    public void Awake()
    {
        enmyTransform = GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        // moteur physique
        // on utlise les inputs récupérés dans update pour appliquer la physique
        TurnTowardsPlayer();
        _rigidbody.velocity = enmyTransform.forward * m_speed;
    }
    #endregion
    //Toutes les fonctions créées par l'équipe
    #region Main Methods
    void TurnTowardsPlayer()
    {
        Vector3 relativePos = _playerTransform.position - enmyTransform.position;
        var step = r_speed * Time.deltaTime;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        enmyRotation = Quaternion.RotateTowards(rotation, _playerTransform.rotation, step);
        _rigidbody.MoveRotation(enmyRotation);
    }
    #endregion

    //Les variables privées et protégées
    #region Private & Protected
    Transform enmyTransform;
    Quaternion enmyRotation;
    private Rigidbody _rigidbody;
    #endregion
}
