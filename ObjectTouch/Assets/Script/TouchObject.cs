using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class TouchObject : MonoBehaviour
{
    public CookieGameManager m_cookieGameManager = null;

    public SpriteAtlas CookieAtlas = null;

    private SpriteRenderer m_cookieSprite = null;

    private int count = 0;

    private void Start()
    {
        count = 0;
        m_cookieSprite = this.GetComponent<SpriteRenderer>();
        Debug.Log(CookieAtlas.GetSprite("CookieTextures_0"));
        m_cookieSprite.sprite = CookieAtlas.GetSprite("CookieTextures_0");
        TouchCount();
    }

    public void TouchedObject()
    {
        count++;
        TouchCount();
    }
    private void TouchCount()
    {
        m_cookieGameManager.CountText.text = string.Format("Count: {0}", count);

        switch (count)
        {

            case 10:
                m_cookieSprite.sprite = CookieAtlas.GetSprite("CookieTextures_1");
                break;
            case 20:
                m_cookieSprite.sprite = CookieAtlas.GetSprite("CookieTextures_2");
                break;
            case 40:
                m_cookieSprite.sprite = CookieAtlas.GetSprite("CookieTextures_3");
                break;
            case 75:
                m_cookieSprite.sprite = CookieAtlas.GetSprite("CookieTextures_4");
                break;
            case 100:
                m_cookieSprite.sprite = CookieAtlas.GetSprite("CookieTextures_5");
                break;
            case 200:
                m_cookieSprite.sprite = null;
                Destroy(this.GetComponent<BoxCollider2D>());
                break;

        }

    }
}

