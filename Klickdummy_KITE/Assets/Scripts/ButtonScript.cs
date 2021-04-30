using System.Collections;
using System.Collections.Generic;
using Naninovel;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
	bool isPlayed = false;
	public AudioSource audioSource;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void OpenPopup(GameObject _popupWindow){
		_popupWindow.SetActive(true);
	}
	
	public async void StartButton(){
		isPlayed = true;
		var player = Engine.GetService<IScriptPlayer> ();
        await player.PreloadAndPlayAsync ("KlickdummyDialoge", label: "startDialogue");
	}
	
	public void PopupEnd(GameObject _popupWindow){
		if(isPlayed){
			_popupWindow.SetActive(true);
		}
	}
	
	public void ClosePopup(GameObject _popupWindow){
		_popupWindow.SetActive(false);
	}
	
	public void GiveStar(GameObject _star){
		_star.SetActive(true);
		
	}
	
	public void PlaySound(AudioClip _audio){
		audioSource.PlayOneShot(_audio);
		
	}
	
	public void PlayWinningSound(AudioClip _audio){
		if(isPlayed){
			audioSource.PlayOneShot(_audio);
		}
	}
	
	public async void EndButton(){
		isPlayed = true;
		var player = Engine.GetService<IScriptPlayer> ();
        await player.PreloadAndPlayAsync ("KlickdummyDialoge", label: "endKlickdummy");
	}
}
