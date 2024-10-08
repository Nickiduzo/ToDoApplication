using UnityEngine;

public class ButtonSwitch : MonoBehaviour
{
    [SerializeField] private GameObject[] elements;

    public void Switch(string name)
    {
        foreach(var elem in elements)
        {
            if(elem.gameObject.name == name)
            {
                elem.SetActive(true);
            }
            else
            {
                elem.SetActive(false);
            }
        }
    }
}
