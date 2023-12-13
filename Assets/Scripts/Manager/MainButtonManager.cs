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

    // ½ºÅÝ ¿­±â
    public void StatusBtn()
    {
        statusBtn.SetActive(false);
        inventoryBtn.SetActive(false);
        statusInfo.SetActive(true);
    }
    // ÀÎº¥Åä¸® ¿­±â
    public void InventoryBtn()
    {
        statusBtn.SetActive(false);
        inventoryBtn.SetActive(false);
        inventoryInfo.SetActive(true);
    }
    // ½ºÅÝ ´Ý±â
    public void StatusBackBtn()
    {
        statusBtn.SetActive(true);
        inventoryBtn.SetActive(true);
        statusInfo.SetActive(false);
    }
    // ÀÎº¥Åä¸® ´Ý±â
    public void InventoryBackBtn()
    {
        statusBtn.SetActive(true);
        inventoryBtn.SetActive(true);
        inventoryInfo.SetActive(false);
    }
    // ÀÎº¥Åä¸® ÆË¾÷Ã¢ ¿­±â
    public void InventoryPopUpBtn()
    {

    }
    // ÀÎº¥Åä¸® ÆË¾÷Ã¢ ÀåÂø
    public void InventoryPopUpEquipmentBtn()
    {

    }

    // ÀÎº¥Åä¸® ÆË¾÷Ã¢ ´Ý±â
    public void InventoryPopUpBackBtn()
    {

    }


    public void GameStartBtn()
    {
        // °ÔÀÓ ½ÃÀÛ
    }
}
