using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Shooter : MonoBehaviour {
	public int Charged {get; set;}
	public bool OnCooldown {get; set;}
	public float cooldownTime;
	Transform transform;
	public Transform origin;
	public GameObject bullet;
	GameObject shot;
	// Use this for initialization
	void Start () {
		this.OnCooldown = false;
		this.Charged = 1;
		transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && this.Charged > 0){
			this.OnCooldown = true;
			shot = Fire();
			this.Charged -= 1;
			StartCoroutine(Cooldown());
		} else if(Input.GetButtonDown("Fire1") && this.OnCooldown == false){
			Recover();
		}
	}
	IEnumerator Cooldown(){
		yield return new WaitForSeconds(cooldownTime);
		this.OnCooldown = false;
	}

	void Recover (){
		Destroy(shot);
		this.Charged++;
	}

	GameObject Fire (){
		Quaternion rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
		return Instantiate(bullet, origin.position, rotation);
	}
}
