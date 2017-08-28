using UnityEngine;

public class menu_creators : MonoBehaviour
{

    public GameObject menu;
    public GameObject menucreators;
    public bool toggle_main_menu;
    public bool toggle_creators_menu;

    void ShowCreators()
    {
        menu.SetActive(toggle_main_menu);
        menucreators.SetActive(toggle_creators_menu);
    }
}
