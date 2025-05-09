using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class adjustOffset : MonoBehaviour
{
    public Vector3 offset;
    public TMP_InputField Xoffset;
    public TMP_InputField Yoffset;
    public TMP_InputField Zoffset;
    float x;
    float y;
    float z;
    void start()
    {

    }

    public void setOffset()
    {
        x = float.Parse(Xoffset.text);
        y = float.Parse(Yoffset.text);
        z = float.Parse(Zoffset.text);

        offset = new Vector3(x, y, z);
    }
}
