using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {

	static public GameObject target; // the target that the camera should look at
	public AudioSource[] sources;

	void Start () {
		sources = GameObject.FindSceneObjectsOfType(typeof(AudioSource)) as AudioSource[];
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}
	
	// Update is called once per frame
	void Update () {
		foreach(AudioSource source in sources){
			source.volume = 0.3f;
		}
		if (target)

			if(target.tag == "AudioSource"){
				target.GetComponent<AudioSource>().volume = 0.6f;
			}
			transform.LookAt(target.transform);
	}
}
