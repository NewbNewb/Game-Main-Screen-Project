using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonManager : MonoBehaviour
{
    public GameObject statusBtn;
    public GameObject inventoryBtn;
    public GameObject statusInfo;
    public GameObject inventoryInfo;
    public GameObject inventoryEquipmentInfo;

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
    // �κ��丮 �˾�â ����
    public void InventoryPopUpBtn()
    {

    }
    // �κ��丮 �˾�â ����
    public void InventoryPopUpEquipmentBtn()
    {

    }

    // �κ��丮 �˾�â �ݱ�
    public void InventoryPopUpBackBtn()
    {

    }


    public void GameStartBtn()
    {
        // ���� ����
    }
}
