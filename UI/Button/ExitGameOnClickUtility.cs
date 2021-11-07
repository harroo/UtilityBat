
using UnityEngine;

public class ExitGameOnClickUtility : MonoBehaviour {

	private void Start () {

		Button button = GetComponent<Button>();

		button.onClick.AddListener(delegate{
			Application.Quit();
		});
	}
}
