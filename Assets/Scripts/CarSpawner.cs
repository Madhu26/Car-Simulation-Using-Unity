using UnityEngine;
using System.Collections;
public class CarSpawner : MonoBehaviour{
		public GameObject car;
		public float maxPos=2.0f;
	    public float delayTimer=1f;
	      float timer;
	void Start()
	{
		timer=delayTimer;
	}
	
	void Update()
	{
		timer -= Time.deltaTime;
		if(timer<=0){
		Vector3 carPos= new Vector3(Random.Range(-1.9f, 2.0f), transform.position.y,transform.position.z);
		Instantiate(car, carPos, transform.rotation);
			timer=delayTimer;
		}
	}
	
	
}