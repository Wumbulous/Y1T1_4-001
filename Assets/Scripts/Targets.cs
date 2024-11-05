using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    [SerializeField] private int HealthPoints;

    public int GetHealthPoints()
    { return HealthPoints; }
}
