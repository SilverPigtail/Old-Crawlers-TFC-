using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/***
 * This script allows the Unity editor to hide te tiles that compose the colliders of the map.
 */
public class HideColliderColor : MonoBehaviour
{
    /**
     * tilemapRenderer -> renderer of the colliders.
     */
    private TilemapRenderer tilemapRenderer;

    /***
     * This function gets the tilemap renderer when the scene loads
     */
    private void Awake()
    {
        tilemapRenderer = GetComponent<TilemapRenderer>();
        
    }

    /***
     * This function hides the colliders when the scene loads.
     */
    private void Start()
    {
        tilemapRenderer.enabled = false;
    }
}
