using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	public static AudioManager instance;

	public AudioMixerGroup mixerGroup;

	public Sound[] sounds;

	void Awake()
	{
        DontDestroyOnLoad(gameObject);

        if (instance == null)
		{
            instance = this;
        }
		else
		{
            Destroy(gameObject);
        }

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();

			s.source.clip = s.clip;
			s.source.loop = s.loop;
			s.source.playOnAwake = false;

			s.source.outputAudioMixerGroup = mixerGroup;
		}
	}

    private void Start()
    {
        Play("Music");
    }


    public void Play(string sound)
	{
        //Check if sound is enabled
        if (SaveManager.instance.state.sound == true)
        {
            //Debug.Log("SoundPlayed");
            Sound s = Array.Find(sounds, item => item.name == sound);
            if (s == null)
            {
                Debug.LogWarning("Sound: " + name + " not found!");
                return;
            }

            s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
            s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));


            s.source.Play();
        }
	}

	public void Stop(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.source.Stop ();
	}
}
