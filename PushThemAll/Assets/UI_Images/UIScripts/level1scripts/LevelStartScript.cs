using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LevelStartScript : MonoBehaviour
{
    public GameObject soundOn;
    public GameObject soundOff;
    public GameObject vibrateOn;
    public GameObject vibrateOff;
    public GameObject joystickOn;
    public GameObject joystickOff;

    public GameObject weapon;
    public Text weaponLevel;
    public Text weaponCost;

    public GameObject power;
    public Text powerLevel;
    public Text powerCost;

    public GameObject offline;
    public Text offlineLevel;
    public Text offlineEarn;
    public Text offlineCost;

    public GameObject weaponYellow;
    public GameObject powerYellow;
    public GameObject offlineYellow;
    public Text totalCoin;
    private int sound;
    private int vibrate;
    private int joystick;
    private bool open = false;
    // Start is called before the first frame update
    void Start()
    {/*
        PlayerPrefs.SetInt("TotalCoin", 0);
        PlayerPrefs.SetInt("WeaponCost", 50);
        PlayerPrefs.SetInt("WeaponLevel", 1);
        PlayerPrefs.SetInt("PowerCost", 50);
        PlayerPrefs.SetInt("PowerLevel", 1);
        PlayerPrefs.SetInt("OfflineCost", 50);
        PlayerPrefs.SetInt("OfflineLevel", 1);
        PlayerPrefs.SetInt("OfflineEarn", 0);*/
        if (PlayerPrefs.HasKey("CurrentLevel"))
        {
            
        }
        else
        {
            PlayerPrefs.SetInt("CurrentLevel", 1);
        }
        if (PlayerPrefs.HasKey("SoundPref"))
        {
            sound = PlayerPrefs.GetInt("SoundPref");
        }
        else
        {
            PlayerPrefs.SetInt("SoundPref", 1);
        }
        if (PlayerPrefs.HasKey("VibratePref"))
        {
            vibrate = PlayerPrefs.GetInt("VibratePref");
        }
        else
        {
            PlayerPrefs.SetInt("VibratePref", 1);
        }
        if (PlayerPrefs.HasKey("JoystickPref"))
        {
            joystick = PlayerPrefs.GetInt("JoystickPref");
        }
        else
        {
            PlayerPrefs.SetInt("JoystickPref", 1);
        }



        if (PlayerPrefs.HasKey("TotalCoin"))
        {
            totalCoin.text = PlayerPrefs.GetInt("TotalCoin").ToString();
        }
        else
        {
            PlayerPrefs.SetInt("TotalCoin", 0);
        }

        ////   LEVELS
        if (PlayerPrefs.HasKey("WeaponLevel"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("WeaponLevel", 1);
        }
        if (PlayerPrefs.HasKey("PowerLevel"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("PowerLevel", 1);
        }
        if (PlayerPrefs.HasKey("OfflineLevel"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("OfflineLevel", 1);
        }


        //// COSTSS
        if (PlayerPrefs.HasKey("WeaponCost"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("WeaponCost", 50);
        }
        if (PlayerPrefs.HasKey("PowerCost"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("PowerCost", 50);
        }
        if (PlayerPrefs.HasKey("OfflineCost"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("OfflineCost", 50);
        }

        ///  EARNNN
        if (PlayerPrefs.HasKey("OfflineEarn"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("OfflineEarn", 0);
        }
        weaponLevel.text = "Lvl. " + PlayerPrefs.GetInt("WeaponLevel").ToString();
        powerLevel.text = "Lvl. " + PlayerPrefs.GetInt("PowerLevel").ToString();
        offlineLevel.text = "Lvl. " + PlayerPrefs.GetInt("OfflineLevel").ToString();
        weaponCost.text = PlayerPrefs.GetInt("WeaponCost").ToString();
        powerCost.text = PlayerPrefs.GetInt("PowerCost").ToString();
        offlineCost.text = PlayerPrefs.GetInt("OfflineCost").ToString();
        offlineEarn.text = PlayerPrefs.GetInt("OfflineEarn").ToString();

        if (PlayerPrefs.GetInt("WeaponCost") > PlayerPrefs.GetInt("TotalCoin"))
        {
            weapon.SetActive(true);
            weaponYellow.SetActive(false);
        }
        else
        {
            weapon.SetActive(false);
            weaponYellow.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PowerCost") > PlayerPrefs.GetInt("TotalCoin"))
        {
            power.SetActive(true);
            powerYellow.SetActive(false);
        }
        else
        {
            power.SetActive(false);
            powerYellow.SetActive(true);
        }
        if (PlayerPrefs.GetInt("OfflineCost") > PlayerPrefs.GetInt("TotalCoin"))
        {
            offline.SetActive(true);
            offlineYellow.SetActive(false);
        }
        else
        {
            offline.SetActive(false);
            offlineYellow.SetActive(true);
        }
        soundOn.SetActive(false);
        soundOff.SetActive(false);
        vibrateOn.SetActive(false);
        vibrateOff.SetActive(false);
        joystickOn.SetActive(false);
        joystickOff.SetActive(false);

        totalCoin.text = PlayerPrefs.GetInt("TotalCoin").ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("CurrentLevel", 1);
        if (PlayerPrefs.GetInt("WeaponCost") > PlayerPrefs.GetInt("TotalCoin"))
        {
            weapon.SetActive(true);
            weaponYellow.SetActive(false);
        }
        else
        {
            weapon.SetActive(false);
            weaponYellow.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PowerCost") > PlayerPrefs.GetInt("TotalCoin"))
        {
            power.SetActive(true);
            powerYellow.SetActive(false);
        }
        else
        {
            power.SetActive(false);
            powerYellow.SetActive(true);
        }
        if (PlayerPrefs.GetInt("OfflineCost") > PlayerPrefs.GetInt("TotalCoin"))
        {
            offline.SetActive(true);
            offlineYellow.SetActive(false);
        }
        else
        {
            offline.SetActive(false);
            offlineYellow.SetActive(true);
        }

        totalCoin.text = PlayerPrefs.GetInt("TotalCoin").ToString();
    }

    public void SettingButton()
    {
        open = !open;
        if (open)
        {
            sound = PlayerPrefs.GetInt("SoundPref");
            vibrate = PlayerPrefs.GetInt("VibratePref");
            joystick = PlayerPrefs.GetInt("JoystickPref");
            if (sound == 1)
                soundOn.SetActive(true);
            else
                soundOff.SetActive(true);
            if (vibrate == 1)
                vibrateOn.SetActive(true);
            else
                vibrateOff.SetActive(true);
            if (joystick == 1)
                joystickOn.SetActive(true);
            else
                joystickOff.SetActive(true);
        }
        else
        {
            soundOn.SetActive(false);
            soundOff.SetActive(false);
            vibrateOn.SetActive(false);
            vibrateOff.SetActive(false);
            joystickOn.SetActive(false);
            joystickOff.SetActive(false);
        }
    }

    public void VibrateOn()
    {
        PlayerPrefs.SetInt("VibratePref", 0);
        vibrateOff.SetActive(true);
        vibrateOn.SetActive(false);
    }
    public void VibrateOff()
    {
        PlayerPrefs.SetInt("VibratePref", 1);
        vibrateOff.SetActive(false);
        vibrateOn.SetActive(true);
    }

    public void SoundOn()
    {
        PlayerPrefs.SetInt("SoundPref", 0);
        soundOff.SetActive(true);
        soundOn.SetActive(false);
    }
    public void SoundOff()
    {
        PlayerPrefs.SetInt("SoundPref", 1);
        soundOff.SetActive(false);
        soundOn.SetActive(true);
    }

    public void JoystickOn()
    {
        PlayerPrefs.SetInt("JoystickPref", 0);
        joystickOff.SetActive(true);
        joystickOn.SetActive(false);
    }
    public void JoystickOff()
    {
        PlayerPrefs.SetInt("JoystickPref", 1);
        joystickOff.SetActive(false);
        joystickOn.SetActive(true);
    }

    public void WeaponYellow()
    {
        int level = PlayerPrefs.GetInt("WeaponLevel");
        level++;
        PlayerPrefs.SetInt("WeaponLevel", level);
        weaponLevel.text = "Lvl. " + level.ToString();
        int coin = PlayerPrefs.GetInt("TotalCoin");
        int cost = PlayerPrefs.GetInt("WeaponCost");
        coin -= cost;
        PlayerPrefs.SetInt("TotalCoin", coin);
        PlayerPrefs.SetInt("WeaponCost", cost * 2);
        cost = 2*cost;
        weaponCost.text = cost.ToString();
    }

    public void PowerYellow()
    {
        int level = PlayerPrefs.GetInt("PowerLevel");
        level++;
        PlayerPrefs.SetInt("PowerLevel", level);
        powerLevel.text = "Lvl. " + level.ToString();
        int coin = PlayerPrefs.GetInt("TotalCoin");
        int cost = PlayerPrefs.GetInt("PowerCost");
        coin -= cost;
        PlayerPrefs.SetInt("TotalCoin", coin);
        PlayerPrefs.SetInt("PowerCost", cost * 2);
        cost = 2 * cost;
        powerCost.text = cost.ToString();
    }

    public void OfflineYellow()
    {
        int level = PlayerPrefs.GetInt("OfflineLevel");
        level++;
        PlayerPrefs.SetInt("OfflineLevel", level);
        offlineLevel.text = "Lvl. " + level.ToString();
        int coin = PlayerPrefs.GetInt("TotalCoin");
        int cost = PlayerPrefs.GetInt("OfflineCost");
        coin -= cost;
        PlayerPrefs.SetInt("TotalCoin", coin);
        PlayerPrefs.SetInt("OfflineCost", cost * 2);
        cost = 2 * cost;
        offlineCost.text = cost.ToString();
        if(level == 2)
        {
            offlineEarn.text = "6";
            PlayerPrefs.SetInt("OfflineEarn", 6);
        }
        else
        {
            PlayerPrefs.SetInt("OfflineEarn", (6 + 2 * (level - 2)));
            offlineEarn.text = PlayerPrefs.GetInt("OfflineEarn").ToString();
        }
    }
}
