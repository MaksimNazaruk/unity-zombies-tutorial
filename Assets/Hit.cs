using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	public float lightTime = 0.3f;

	ParticleSystem particles;
	Light hitLight;
	float timer;
	bool isPlaying;

	// Use this for initialization
	void Awake () {
		particles = GetComponent<ParticleSystem> ();
		hitLight = GetComponent<Light> ();

		particles.Stop ();
		hitLight.enabled = false;

		timer = 0;
		isPlaying = false;
	}

	void Update() {
		timer += Time.deltaTime;

		if (isPlaying && timer > lightTime) {
			isPlaying = false;
			hitLight.enabled = false;
			particles.Stop();
		}
	}

	public void PlayEffect () {

		isPlaying = true;
		timer = 0;

		hitLight.enabled = true;
		particles.Play ();
	}

}
