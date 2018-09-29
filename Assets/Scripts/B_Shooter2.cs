using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Shooter2 : MonoBehaviour {

    private int Charged = 1;

    public bool OnCooldown { get; set; }
    public float cooldownTime;
    public Transform origin;
    public GameObject bullet;

    GameObject shot;
    Transform transform;
    SpriteRenderer sRenderer;



    private int i = 0;

    // Use this for initialization
    void Start()
    {
        this.OnCooldown = false;
        transform = gameObject.GetComponent<Transform>();
        sRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && this.Charged > 0)
        {
            this.OnCooldown = true;
            shot = Fire();
            this.Charged -= 1;
            sRenderer.color = Color.red;
            StartCoroutine(Cooldown());
        }
        else if (Input.GetButtonDown("Fire2") && this.OnCooldown == false)
        {
            Recover();
            sRenderer.color = Color.grey;
        }
    }
    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(cooldownTime);
        this.OnCooldown = false;
        sRenderer.color = Color.green;
    }

    void Recover()
    {
        Destroy(shot);
        this.Charged++;
    }

    GameObject Fire()
    {
        Quaternion rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        return Instantiate(bullet, origin.position, rotation);
    }
}
