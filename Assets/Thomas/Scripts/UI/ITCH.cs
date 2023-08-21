using UnityEngine;

public class ITCH : MonoBehaviour
{
    public string ThomasURL, MaryamURL, SaheedURL, DillonURL, HannahURL, GeorgeURL;

    public void ThomasOpen()
    {
        Application.OpenURL(ThomasURL);
    }

    public void MaryamOpen()
    {
        Application.OpenURL(MaryamURL);
    }

    public void SaheedOpen()
    {
        Application.OpenURL(SaheedURL);
    }

    public void DillonOpen()
    {
        Application.OpenURL(DillonURL);
    }

    public void HannahOpen()
    {
        Application.OpenURL(HannahURL);
    }

    public void GeorgeOpen()
    {
        Application.OpenURL(GeorgeURL);
    }
}