using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineCam : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camma;
    private CinemachineTrackedDolly trackdolly;
    public float maxpos;
    void Start()
    {
        trackdolly = camma.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trackdolly.m_PathPosition > maxpos)
        {
            maxpos = trackdolly.m_PathPosition;
        }
        if (trackdolly.m_PathPosition < maxpos)
        {
            trackdolly.m_PathPosition = maxpos;
        }
    }
}
