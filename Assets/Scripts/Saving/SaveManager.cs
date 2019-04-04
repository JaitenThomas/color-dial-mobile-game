using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour 
{
	public static SaveManager instance;
	public SaveState state;

	public bool resetSave;

	private void Awake()
	{		

		DontDestroyOnLoad (gameObject);

		if (instance == null) {
            instance = this;
		} else {
			Destroy (gameObject);
		}

		if(resetSave == true)
		{
			PlayerPrefs.DeleteAll ();
		}
		Load ();

		//Debug.Log (Helper.Serialize<SaveState>(state));
		//Debug.Log (Helper.Encrypt("Hello"));
		//Debug.Log (Helper.Decrypt("XdutraFM7CA="));
	}
		
	//Save the whole state of this saveState script to the player pref
	public void Save()
	{
		PlayerPrefs.SetString ("save", Helper.Encrypt(Helper.Serialize<SaveState>(state)));
	}

	//Load the previous saved state from the player prefs
	public void Load()
	{
		//Do we already have a save?
		if(PlayerPrefs.HasKey("save"))
		{
			//Debug.Log (PlayerPrefs.GetString("save"));
			state = Helper.Deserialize <SaveState>(Helper.Decrypt(PlayerPrefs.GetString("save")));
		}
		else 
		{
			state = new SaveState();
			Save();
			Debug.Log("No save found. Creating a new one");
		}
	}
}
