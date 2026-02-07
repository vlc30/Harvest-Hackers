using UnityEngine;

public class Collectable : MonoBehaviour
{
    public CollectableType type;
    //player walks into collectable
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        //add collectable to player
        if (player)
        {
            player.inventory.Add(type);
            //delete colelctable from screen
            Destroy(this.gameObject);
        }
    }

}
public enum CollectableType
    {
        NONE, CARROT_SEED, TOMATO_SEED, BROCCOLI_SEED
    }