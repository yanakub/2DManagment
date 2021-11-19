using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float Energy;
    public float maxEnergy;

    private Inventory inventory;

    [SerializeField] private UI_Inventory uiInventory;

    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }

    void Start()
    {
        maxEnergy = 100f;
        Energy = 80f;
        ChangeSlider();
    }

    

    public void AddEnergy(float energyPoints)
    {
        Energy += energyPoints;
        if (Energy >= maxEnergy)
        {
            Energy = maxEnergy;
        }
        ChangeSlider();
    }

    public void RemoveEnergy(float energyPoints)
    {
        Energy -= energyPoints;
        if (Energy <= 0)
        {
            Energy = 0;
        }
        ChangeSlider();
    }

    void ChangeSlider()
    {
        SliderScripts.singleton.SmoothBar(Energy);
    }
}
