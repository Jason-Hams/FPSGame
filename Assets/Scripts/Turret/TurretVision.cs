using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TurretVision : MonoBehaviour
{
    public UnityEvent ontargetscene, ontargetlost;
    [SerializeField] private float lazerrange;
    [SerializeField] private Transform lazerstartposition;
    [SerializeField] private LayerMask playerlayer, otherlayers;
    [SerializeField] private LineRenderer lineRenderer;
   

}
