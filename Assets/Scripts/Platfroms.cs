using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfroms : MonoBehaviour
{
    [SerializeField] private List<GameObject> redPlatforms;
    [SerializeField] private List<GameObject> greenPlatforms;

    [SerializeField] private bool redPlatformActive = true;

    [SerializeField] private movement movement;
    [SerializeField] private movement2 movement2;

    void SwitchPlatforms()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (redPlatformActive)
            {
                foreach (var redPlatform in redPlatforms)
                {
                    redPlatform.SetActive(false);
                    movement.playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
                }

                foreach (var greenPlatform in greenPlatforms)
                {
                    greenPlatform.SetActive(true);
                    movement2.playerRb.constraints = RigidbodyConstraints2D.None;
                }

                Debug.Log("Switched");
                redPlatformActive = false;
            }

            else 
            {
                foreach (var greenPlatform in greenPlatforms)
                {
                    greenPlatform.SetActive(false);
                    movement2.playerRb.constraints = RigidbodyConstraints2D.FreezeAll;
                }

                foreach (var redPlatform in redPlatforms)
                {
                    redPlatform.SetActive(true);
                    movement.playerRb.constraints = RigidbodyConstraints2D.None;
                }

                redPlatformActive = true;
            }
        }
    }

    private void Update()
    {
        SwitchPlatforms();
    }
}
