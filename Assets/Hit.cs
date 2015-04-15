using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	public float lightTime = 0.3f;

	ParticleSystem particles;
	Light light;
	float timer;
	bool isPlaying;

	// Use this for initialization
	void Awake () {
		particles = GetComponent<ParticleSystem> ();
		light = GetComponent<Light> ();

		particles.Stop ();
		light.enabled = false;

		timer = 0;
		isPlaying = false;
	}

	void Update() {
		timer += Time.deltaTime;

		if (isPlaying && timer > lightTime) {
			isPlaying = false;
			light.enabled = false;
		}
	}

	public void PlayEffect () {

		isPlaying = true;
		timer = 0;

		light.enabled = true;
		particles.Play ();
	}

}
