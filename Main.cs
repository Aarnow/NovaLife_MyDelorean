using Life;
using Life.Network;
using UnityEngine;
using UIPanelManager;

namespace MyDelorean
{
    public class MyDelorean : Plugin
    {
        public MyDelorean(IGameAPI api) : base(api)
        {
            new SChatCommand("/mydelorean", "Permet d'activer l'animation de la delorean", "/mydelorean", (player, arg) =>
            {
                player.setup.NetworkisVal = !player.setup.NetworkisVal;
                if (player.setup.NetworkisVal) PanelManager.Notification(player, "Succès", "Vous pouvez activer la Delorean", NotificationManager.Type.Success);
                else PanelManager.Notification(player, "Attention", "Vous ne pouvez plus activer la Delorean", NotificationManager.Type.Warning);
            }).Register();

            Debug.Log($"Plugin \"MyDelorean\" initialisé avec succès.");
        }
    }
}