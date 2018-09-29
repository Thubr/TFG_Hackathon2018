using UnityEngine;

public class platRot : MonoBehaviour 
{
	public Transform t;
	public float angSpeed = 0.00000000001f;

	void Update () 
	{
		angSpeed += angSpeed;
		t.Rotate(new Vector3(0,0,angSpeed*Time.deltaTime));
	}
}
