using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
	public void SwitchScene(int scene)
	{
		SceneManager.LoadScene(scene);
	}
}
