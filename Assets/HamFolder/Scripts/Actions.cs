using UnityEngine;

public class Actions : MonoBehaviour
{

	// Script made by Brandon Foshe


	/* <summary>
	 * 
	 * void SetAngleOfLight: Changes direction of lighting to face the image the user is looking at
	 * void OnClick: Checks if text is active, then displays or closes text
	 * void DisableText: Gets rid of a picture's text
	 * 
	 * Serialize fields -
	 * angle: defines angle that gets added to light
	 * lightSource: lightSource that moves with angle
	 * textBox: text to be enabled / disabled on click
	 */

	[SerializeField]
	int angle;
	[SerializeField]
	Light lightSource;
	[SerializeField]
	GameObject text;

	private bool textActive = false;

	// Called when looking at object
	public void SetAngleOfLight()
	{
		lightSource.transform.rotation = Quaternion.Euler(15f, angle, 0f);
	}

	public void OnClick()
	{
		if (!textActive)
		{
			text.SetActive(true);
			textActive = true;
		}
		else
		{
			// Just cause I can call it I will :p
			DisableText();
			textActive = false;
		}
	}

	// Can be called on hover end or through OnClick if already active
	public void DisableText()
	{
		textActive = false;
		text.SetActive(false);
	}
}
