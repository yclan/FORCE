using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public AudioClip damage;
	public AudioClip bounce;
	public AudioClip getPowerUp;
	public AudioClip usePowerUp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playDamage()
	{
		audio.PlayOneShot(damage);
	}
	public void playGetPowerUp()
	{
		audio.PlayOneShot(getPowerUp);
	}
	public void playUsePowerUp()
	{
		audio.PlayOneShot(usePowerUp);
	}
	public void playBounce()
	{
		audio.PlayOneShot(bounce, 0.5F);
	}
}
