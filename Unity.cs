using UnityEngine;
using System.Collections.Generic;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ArucoModule;
using OpenCVForUnity.UnityUtils;

public class ArucoDetect : MonoBehaviour
{
    Dictionary dictionary;

    void Start()
    {
        dictionary = Aruco.getPredefinedDictionary(Aruco.DICT_6X6_250);
    }

    void Update()
    {
        Mat camImage = new Mat();

        List<Mat> corners = new List<Mat>();
        Mat ids = new Mat();

        Aruco.detectMarkers(camImage, dictionary, corners, ids);

        if(ids.total() > 0)
        {
            Debug.Log("Marker Detected");
        }
    }
}
