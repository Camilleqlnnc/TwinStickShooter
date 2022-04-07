using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _cannon;
    [SerializeField] float _bulletSpeed;
    [SerializeField] float delayBeforeBulletDestroyed;
    [SerializeField] float _delayBetweenShots;
    #endregion

    #region Unity Life Cycle
    void Awake()
    {
        _nextShotTime = Time.time;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= _nextShotTime && Input.GetAxisRaw("RightTrigger") != 0)
        {
            FireBullet();
            _nextShotTime = Time.time + _delayBetweenShots;
        }
    }
    #endregion
    //Toutes les fonctions créées par l'équipe
    #region Main Methods
    private void FireBullet()
    {  
        // Instantiate the projectile at the position and rotation of this transform
        Rigidbody newBullet;
        newBullet = Instantiate(_bulletPrefab.GetComponent<Rigidbody>(), _cannon.position, _cannon.rotation);
        // Give the cloned object an initial velocity along the current
        // object's Z axis
        newBullet.velocity = transform.TransformDirection(Vector3.forward * 10);
        Destroy(newBullet.gameObject, delayBeforeBulletDestroyed);
        Bullet _bullet = newBullet.GetComponent<Bullet>();
        _bullet.Shoot(_bulletSpeed);
        FindObjectOfType<SoundManager>().Play("PlayerShoot");

    }
    #endregion

    //Les variables privées et protégées
    #region Private & Protected
    private float _nextShotTime;
    #endregion
}
