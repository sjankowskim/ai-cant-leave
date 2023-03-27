using ThunderRoad;
using UnityEngine;

namespace AICantLeave
{
    public class AICantLeave : ThunderScript
    {
        public override void ScriptLoaded(ModManager.ModData modData)
        {
            base.ScriptLoaded(modData);
            EventManager.OnPlayerSpawner += OnPlayerSpawner;

        }

        private void OnPlayerSpawner(PlayerSpawner playerSpawner, EventTime eventTime)
        {
            FleePoint.list.Clear();
        }
    }
}
