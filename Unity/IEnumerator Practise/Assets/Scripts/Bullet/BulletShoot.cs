using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public GameObject objectToSpawn;
    [SerializeField] private float speed;

    private BoxCollider2D boxCollider;

    private float cooldownTimer = Mathf.Infinity;

    private float direction;
    private bool hit;
    private float lifetime;

    public Rigidbody rocketPrefab;
    public Transform barrelEnd;

    bool canShoot = true;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    public void Attack()
    {
        cooldownTimer = 0;

        float timer = 0f;
        float moveduration = 1f;

        while (timer < moveduration)
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
            timer += Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
        boxCollider.enabled = false;
    }
    public void SetDirection(float _direction)
    {
        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canShoot == false)
            {
                StartCoroutine("Loop");
            }
        }
    }

    IEnumerator Loop()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canShoot == false)
            {
                Rigidbody rocketInstance;
                rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
                rocketInstance.AddForce(barrelEnd.forward * 2000);

                yield return new WaitForSeconds(1f);

                canShoot = true;
                Destroy(gameObject, 1.5f);
            }
        }
    }


    public class RocketDestruction : MonoBehaviour
    {
        void Start()
        {
            Destroy(gameObject, 1.5f);
        }
    }

}
