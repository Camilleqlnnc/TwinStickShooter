using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed;
    [SerializeField] float _bulletSpeed;
    #endregion

    #region Unity Life Cycle
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
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
        Vector3 velocity = _transform.forward * _bulletSpeed;
        Vector3 movementStep = velocity * Time.fixedDeltaTime;
        Vector3 newPos = _transform.position + movementStep;
        _rigidbody.MovePosition(newPos);
    }
    #endregion
    //Toutes les fonctions créées par l'équipe
    #region Main Methods
    public void Shoot(float speed)
    {
        _bulletSpeed = speed;
    }
    #endregion

    //Les variables privées et protégées
    #region Private & Protected
    Transform _transform;
    Rigidbody _rigidbody;

    #endregion
}
