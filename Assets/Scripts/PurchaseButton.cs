using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
    public enum PurchaseType {removeAds, hourglass1, hourglass2, hourglass5};
    public PurchaseType purchaseType;
    public void ClickPurchaseButton() {
        switch (purchaseType) {
            case PurchaseType.removeAds:
                IAPManager.instance.BuyRemoveAds();
                break;
            case PurchaseType.hourglass1:
                IAPManager.instance.BuyHourglass1();
                break;
            case PurchaseType.hourglass2:
                IAPManager.instance.BuyHourglass2();
                break;
            case PurchaseType.hourglass5:
                IAPManager.instance.BuyHourglass5();
                break;
        }
    }
}
