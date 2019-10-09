using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class IOS13Bug : MonoBehaviour
{
	public UnityEngine.UI.Text text;

	[DllImport("__Internal")]
	private static extern void IOS13BannerTestScript_ShowController();

	public void ShowController()
	{
		Debug.Log("ShowController");
		IOS13BannerTestScript_ShowController();
	}

    // Update is called once per frame
    void Update()
    {
        text.text = $"safeArea x: {Screen.safeArea.x} y: {Screen.safeArea.y} w: {Screen.safeArea.width} h: {Screen.safeArea.height}";
    }
}
