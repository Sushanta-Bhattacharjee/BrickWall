using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform ProjectileSpawn;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10;
    private float moveSpeed, dirX, dirY;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 30f;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var projectile = Instantiate(projectilePrefab, ProjectileSpawn.position, ProjectileSpawn.rotation);
            projectile.GetComponent<Rigidbody>().velocity = ProjectileSpawn.forward * projectileSpeed;
        }

        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        dirY = Input.GetAxisRaw("Vertical") * moveSpeed;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 1.0f, 20.5f), Mathf.Clamp(transform.position.y, 0.8f, 7.0f), transform.position.z);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }

   

    
}
