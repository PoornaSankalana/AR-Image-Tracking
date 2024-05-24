using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PrefabCreator : MonoBehaviour
{
    [SerializeField] private GameObject dragonPrefab;
    [SerializeField] private Vector3 prefabOffset;

    private GameObject dragon;
    private ARTrackedImageManager aRTrackedImageManager;

    private void OnEnable()
    {
        aRTrackedImageManager = GetComponent<ARTrackedImageManager>();
        aRTrackedImageManager.trackedImagesChanged += OnImagesChanged;
    }

    private void OnImagesChanged(ARTrackedImagesChangedEventArgs obj)
    {
        foreach (ARTrackedImage image in obj.added)
        {
            if (dragonPrefab != null)
            {
                dragon = Instantiate(dragonPrefab, image.transform.position, Quaternion.identity);
                dragon.transform.position += prefabOffset;
            }
            else
            {
                Debug.LogWarning("Dragon Prefab is not assigned in the inspector.");
            }
        }
    }
}
