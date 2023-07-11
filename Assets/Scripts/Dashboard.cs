using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dashboard : MonoBehaviour
{

    private TMP_Text textInfo;

    private string[] info = { "1.390.000 Km\n\n0 Km\n\n5503 °C\n\n27 g 6 h 36 min\n\n1.993 m/s",
                              "4.880 Km\n\n58.000.000 Km\n\n167 °C\n\n58 g 15 h\n\n3,0256 m/s",
                              "12.103 Km\n\n108.000.000 Km\n\n464 °C\n\n243 g 16 h\n\n1,81 m/s",
                              "12.756 Km\n\n150.000.000 Km\n\n15 °C\n\n23 h 55 min\n\n465,11 m/s",
                              "6.794 Km\n\n228.000.000 Km\n\n-63 °C\n\n21 h 10 min\n\n241,17 m/s",
                              "142.984 Km\n\n778.000.000 Km\n\n-121 °C\n\n9 h 55 min\n\n12.580 m/s",
                              "120.536 Km\n\n1.427.000.000 Km\n\n-130 °C\n\n10 h 33 min\n\n9.849 m/s",
                              "51.118 Km\n\n2.870.000.000 Km\n\n-205 °C\n\n17 h 14 min\n\n2.590 m/s",
                              "49.532 Km\n\n4.497.000.000 Km\n\n-220 °C\n\n16 h 6 min\n\n2.680 m/s" };

    public void Start()
    {
        textInfo = GameObject.Find("DashboardInfo").GetComponent<TMP_Text>();
    }

    public void SetInfo(int index)
    {
        textInfo.SetText(info[index]);
    }
}
