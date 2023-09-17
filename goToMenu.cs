using UnityEngine;

public class goToMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject CONTR;
    public void enterMenu()
    {
        CONTR.SetActive(true);
        menu.SetActive(false);
    }
}
