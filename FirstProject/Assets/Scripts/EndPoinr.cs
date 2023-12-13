
using UnityEngine;

public class EndPoinr : MonoBehaviour

{
    public GameManager Manager;
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Manager.Compelete();
    }
}
