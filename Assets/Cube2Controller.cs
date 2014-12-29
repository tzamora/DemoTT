using UnityEngine;
using System.Collections;

public class Cube2Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		NiceEffectsRoutine();

	}

	public void NiceEffectsRoutine(){

		this.ttAppendLoop (1f, delegate(LoopHandler loop){

			transform.Rotate(new Vector3(0f, -1f, 0f), Time.deltaTime * 200f);

		}).ttAppendLoop (1f, delegate(LoopHandler loop){
			
			transform.Rotate(new Vector3(0f, 1f, 0f), Time.deltaTime * 200f);
			
		}).ttAppendLoop (1f, delegate(LoopHandler loop){
			
			transform.Rotate(new Vector3(0f, 1f, 0f), Time.deltaTime * 200f);
			
		}).ttAppendLoop (1f, delegate(LoopHandler loop){
			
			transform.Rotate(new Vector3(0f, -1f, 0f), Time.deltaTime * 200f);
			
		});

	}


}
