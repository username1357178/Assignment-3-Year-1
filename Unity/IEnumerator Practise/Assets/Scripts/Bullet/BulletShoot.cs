using System.Collections;
using System.Collections.Generic;
using System.Threading;
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

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (hit) return;
        float movementSpeed = speed * Time.deltaTime * direction;
        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if (lifetime > 5) gameObject.SetActive(false);

        if (Input.GetMouseButton(0) && cooldownTimer > 1
            && Time.timeScale > 0)
            Attack();

        cooldownTimer += Time.deltaTime;
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
}
