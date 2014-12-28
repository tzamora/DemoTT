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

		this.ttAppend (1f, delegate(){

			renderer.material.color = Color.yellow;

		});

		this.ttAppend (1f, delegate(){
			
			renderer.material.color = Color.red;
			
		});

		this.ttAppend (1f, delegate(){
			
			renderer.material.color = Color.green;
			
		});
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
		this.ttAppendLoop(1f, delegate(LoopHandler loop){
			
			transform.Rotate(new Vector3(0f, -1f, 0f) * speed * Time.deltaTime);
			
		});

		this.ttAppendLoop(1f, delegate(LoopHandler loop){
			
			transform.Rotate(new Vector3(0f, 1f, 0f) * speed * Time.deltaTime);
			
		});

		this.ttAppendLoop(1f, delegate(LoopHandler loop){
			
			transform.Rotate(new Vector3(0f, -1f, 0f) * speed * Time.deltaTime);
			
		});

		this.ttAppend(1f, delegate(){
		
			renderer.material.color = Color.red;
			
		});
	}

	void RotationRoutine()
	{

	}

	void MovementRoutine()
	{
		
	}

	void ChangeSizeRoutine()
	{
		
	}

}
