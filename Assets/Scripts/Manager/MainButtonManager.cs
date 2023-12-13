using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainButtonManager : MonoBehaviour
{
    public GameObject statusBtn;
    public GameObject inventoryBtn;
    public GameObject statusInfo;
    public GameObject inventoryInfo;
    public GameObject inventoryEquipmentInfo;
    public GameObject inventoryEquip;
    public GameObject inventoryEquipmentReleaseInfo;

    // ���� ����
    public void StatusBtn()
    {
        statusBtn.SetActive(false);
        inventoryBtn.SetActive(false);
        statusInfo.SetActive(true);
    }
    // �κ��丮 ����
    public void InventoryBtn()
    {
        statusBtn.SetActive(false);
        inventoryBtn.SetActive(false);
        inventoryInfo.SetActive(true);
    }
    // ���� �ݱ�
    public void StatusBackBtn()
    {
        statusBtn.SetActive(true);
        inventoryBtn.SetActive(true);
        statusInfo.SetActive(false);
    }
    // �κ��丮 �ݱ�
    public void InventoryBackBtn()
    {
        statusBtn.SetActive(true);
        inventoryBtn.SetActive(true);
        inventoryInfo.SetActive(false);
    }
    // �κ��丮 �˾�â ���� ���� ���� �� ���� ����
    public void InventoryPopUpBtn()
    {
        if (inventoryEquip.activeSelf == true)
        {
            inventoryEquipmentReleaseInfo.SetActive(true);
        }
        else
        {
            inventoryEquipmentInfo.SetActive(true);
        }
        
    }
    // �κ��丮 �˾�â ���� �� ����
    public void InventoryPopUpEquipmentBtn()
    {
        if (inventoryEquip.activeSelf == true)
        {
            inventoryEquipmentReleaseInfo.SetActive(false);
            inventoryEquip.SetActive(false);
        }
        else
        {
            inventoryEquipmentInfo.SetActive(false);
            inventoryEquip.SetActive(true);
        }
    }
    // �κ��丮 �˾�â �ݱ�
    public void InventoryPopUpEquipmentBackBtn()
    {
        if (inventoryEquip.activeSelf == true)
        {
            inventoryEquipmentReleaseInfo.SetActive(false);
        }
        else
        {
            inventoryEquipmentInfo.SetActive(false);
        }
    }
    public void GameStartBtn()
    {
        // ���� ����
    }
}
