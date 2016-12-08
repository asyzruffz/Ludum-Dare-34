using UnityEngine;
using UnityEngine.UI;

public class DisplayUIState : MonoBehaviour {

	Text state;

	void Start () {
		state = GetComponent<Text> ();
	}
	
	void Update () {
		state.text = GameMaster.UIState.ToString ();
	}
}
