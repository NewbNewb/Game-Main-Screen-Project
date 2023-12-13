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

    // 스텟 열기
    public void StatusBtn()
    {
        statusBtn.SetActive(false);
        inventoryBtn.SetActive(false);
        statusInfo.SetActive(true);
    }
    // 인벤토리 열기
    public void InventoryBtn()
    {
        statusBtn.SetActive(false);
        inventoryBtn.SetActive(false);
        inventoryInfo.SetActive(true);
    }
    // 스텟 닫기
    public void StatusBackBtn()
    {
        statusBtn.SetActive(true);
        inventoryBtn.SetActive(true);
        statusInfo.SetActive(false);
    }
    // 인벤토리 닫기
    public void InventoryBackBtn()
    {
        statusBtn.SetActive(true);
        inventoryBtn.SetActive(true);
        inventoryInfo.SetActive(false);
    }
    // 인벤토리 팝업창 장착 관리 열기 및 해제 관리
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
    // 인벤토리 팝업창 장착 및 해제
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
    // 인벤토리 팝업창 닫기
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
        // 게임 시작
    }
}
