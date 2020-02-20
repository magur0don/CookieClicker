using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour
{
    /// <summary>
    /// クリックしたオブジェクト
    /// </summary>
    private GameObject m_clickedObject;

    /// <summary>
    /// メインカメラ
    /// </summary>
    [SerializeField]
    private Camera m_mainCamera;

    /// <summary>
    /// カメラから射出されるRay(光線)
    /// </summary>
    private Ray m_rayCast;

    /// <summary>
    /// Rayが当たった時の2D用の衝突判定
    /// </summary>
    private RaycastHit2D m_hit2D;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (m_mainCamera == null)
            {
                return;
            }

            m_clickedObject = null;

            m_rayCast = m_mainCamera.ScreenPointToRay(Input.mousePosition);

            m_hit2D = Physics2D.Raycast((Vector2)m_rayCast.origin, (Vector2)m_rayCast.direction);

            if (m_hit2D)
            {
                m_clickedObject = m_hit2D.transform.gameObject;
                Debug.Log(m_clickedObject.name);
            }
        }
    }
}
