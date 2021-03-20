using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMCtrlByButton : MonoBehaviour
{
    [SerializeField] AudioSource m_ac = null;
    [SerializeField] KeyCode m_key = KeyCode.P;
    bool m_isPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        if (m_ac == null)
        {
            m_isPlayed = false;
            m_ac = GetComponent<AudioSource>();
        }        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(m_key))
        {
            if (m_isPlayed)
            {
                m_ac.Stop();
            }
            else
            {
                m_ac.Play();
            }
            m_isPlayed = !m_isPlayed;
        }        
    }
}
