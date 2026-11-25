using UnityEngine;

public class Egg : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void HideEggShowPlayer()
    {
        AudioManager.instance.PlayCrackEggClip();
        player.SetActive(true);
        gameObject.SetActive(false);
    }
}
