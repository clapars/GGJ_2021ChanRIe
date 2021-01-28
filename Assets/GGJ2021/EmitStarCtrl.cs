using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GGJ2012
{
    public class EmitStarCtrl : MonoBehaviour
    {
        [SerializeField] GameObject m_efcPrefb = null;
        [SerializeField, Range(1f, 100f)] float m_dispRange = 20f;
        [SerializeField, Range(0f, 1f)] float m_emitRate = 0.2f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Random.value < m_emitRate)
            {
                Vector3 pos = Random.insideUnitCircle* m_dispRange;
                Quaternion rot = Quaternion.AngleAxis(Random.Range(0f, 90f), Vector3.forward);
                GameObject go = Instantiate(m_efcPrefb,transform);
                go.transform.localPosition = pos;
                go.transform.localRotation = rot;

            }
        }
    }
}
