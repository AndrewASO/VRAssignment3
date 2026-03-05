using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnHome : MonoBehaviour
{

	// Script made by Brandon Foshe


	/* <summary>
	 * 
	 * Only Responsible for taking you back to the start page
	 */


	public void GoHome()
	{
		SceneManager.LoadScene("Start");
	}
}
