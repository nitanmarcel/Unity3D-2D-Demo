using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainControl : MonoBehaviour
{

    public float isRainging = 0; // 0 == false 1 == true

    public AudioSource RainAudSource;
    public AudioSource NightAudSource;
    public List<ParticleSystem> partSystemList;
    // Start is called before the first frame update
    void Start()
    {
        isRainging = Random.Range(0, 2);
        if (isRainging == 1)
        {
            RainAudSource.Play();
            foreach (ParticleSystem partSystem in partSystemList)
            {
                partSystem.Play();
            }
        }
        else
        {
            NightAudSource.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
