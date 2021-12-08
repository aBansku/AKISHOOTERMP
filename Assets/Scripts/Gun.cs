using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class Gun : MonoBehaviour
{
    public float damage = 10;
    public float range = 100f;
    public float fireRate = 10f;
    public Camera cam;
    public ParticleSystem muzzlerFlash;
    public bool isAuto;
    private float fireTime = 0f;
    public float clipSize;
    private float bullets;
    private void Start()
    {
        bullets = clipSize;
    }
    void Update()
    {

        if (isAuto)
        {
            if (Input.GetButton("Fire1") && Time.time >= fireTime && bullets != 0f)
            {
                fireTime = Time.time + 1f / fireRate;
                bullets -= 1;
                Debug.Log(bullets);
                Shoot();
            }
            else
            {
                muzzlerFlash.Stop();
            }
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (bullets == 0f || Input.GetKeyDown(KeyCode.R))
        {
            reload();
        }


    }

    private void Shoot()
    {
        muzzlerFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Player player = hit.transform.GetComponent<Player>();
            if (player != null)
            {
                player.takeDamage(damage);
            }
        }
    }
    private void reload()
    {
        StartCoroutine(reload(1));
    }

    private IEnumerator reload(float delay)
    {
        yield return new WaitForSeconds(delay);
        bullets = clipSize;

    }
}
