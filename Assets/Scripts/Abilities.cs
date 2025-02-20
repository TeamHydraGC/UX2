using UnityEngine;

public class Abilities : MonoBehaviour
{

    public float cdTime = 2;
    private float nextUseTime = 0;

    private void Update()
    {
        if (Time.time > nextUseTime)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                print("yep");
                nextUseTime = Time.time + cdTime;
            }
        }
    }

}
