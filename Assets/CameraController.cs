using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] CinemachineFreeLook CmFreeLook;
    public void SetInputActive(bool value)
    {
        if(value)
        {
            CmFreeLook.m_XAxis.m_InputAxisName = "Mouse X";
            CmFreeLook.m_YAxis.m_InputAxisName = "Mouse Y";
        }
        else
        {
            CmFreeLook.m_XAxis.m_InputAxisName = "";
            CmFreeLook.m_YAxis.m_InputAxisName = "";

            CmFreeLook.m_XAxis.m_InputAxisValue = 0;
            CmFreeLook.m_YAxis.m_InputAxisValue = 0;
        }
    }
}
