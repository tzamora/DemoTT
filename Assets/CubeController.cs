using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	public float speed = 2f;

	public float timeSinceStart = 0f;

	// Use this for initialization
	void Start () 
	{
		//Example1 ();

		//Example2 ();

		//Example3 ();
	}

	void Update()
	{
		timeSinceStart += Time.deltaTime;
	}

	public void Example1()
	{
		// Yo le cambiaria el nombre a ttAppendDelay

//		this.ttAppendLoop (2f, delegate(LoopHandler loop){
//
//			transform.Rotate(new Vector3(0f, -1f, 0f) * Time.deltaTime * 200f);
//
//		});

		this.ttAppendLoop (2f, delegate(LoopHandler loop){

			transform.localScale = Vector3.Lerp(new Vector3(1f, 1f, 1f), new Vector3(2f, 2f, 2f), loop.t);

		}).ttNow(1f, delegate(){

			renderer.material.color = Color.red;

		}).ttAppendLoop (2f, delegate(LoopHandler loop){
			
			transform.localScale = Vector3.Lerp(new Vector3(2f, 2f, 2f),new Vector3(1f, 1f, 1f), loop.t);
			
		});




//		this.ttAppend (1f, delegate(){
//
//			renderer.material.color = Color.yellow;
//
//		});
//
//		this.ttAppend (1f, delegate(){
//			
//			renderer.material.color = Color.red;
//			
//		});
//
//		this.ttAppend (1f, delegate(){
//			
//			renderer.material.color = Color.green;
//			
//		});
	}

	public void Example2()
	{
		this.ttAppend (1f, delegate(){

			print ("Append set yellow color at: " + (Time.time - timeSinceStart));
			
			renderer.material.color = Color.yellow;
			
		});
		
		this.ttAppend (1f, delegate(){

			renderer.material.color = Color.red;
			
		});

		this.ttNow(1f, delegate(){

			transform.localScale = transform.localScale * 2f;
			
		});

		this.ttAppend (1f, delegate(){

			renderer.material.color = Color.green;
			
		});
	}

	public void Example3()
	{
		// loop by certain time
		this.ttAppendLoop(1f, delegate(LoopHandler loop){
			
			transform.Rotate(new Vector3(0f, -1f, 0f) * speed * Time.deltaTime);
			
		});

		// infinite loop
		this.ttAppendLoop (delegate(LoopHandler rootLoop) {

			transform.Rotate(new Vector3(0f, 1f, 0f) * speed * Time.deltaTime);

			if(rootLoop.timeSinceStart > 2f)
			{
				renderer.material.color = Color.red;
				
				rootLoop.ExitLoop ();
			}

		});

		this.ttAppendLoop(2f, delegate(LoopHandler loop){
					
			transform.Rotate(new Vector3(0f, -1f, 0f) * speed * Time.deltaTime);
			
		}).ttAppend(2f, delegate(){

			renderer.material.color = Color.blue;

		});
	}

	public void Example4()
	{
		Vector3 defaultScale = new Vector3 (1f, 1f, 1f);

		// loop by certain time
		this.ttAppendLoop(1f, delegate(LoopHandler loop){
			
			//transform.Rotate(new Vector3(0f, -1f, 0f) * speed * Time.deltaTime);

			transform.localScale = Vector3.Lerp(defaultScale, defaultScale * 2f, loop.t);
			
		}).ttAppendLoop(1f, delegate(LoopHandler loop){
			
			transform.localScale = Vector3.Lerp(defaultScale * 2f, defaultScale, loop.t);
			
		});
	}

	public void Example5()
	{

	}
}
