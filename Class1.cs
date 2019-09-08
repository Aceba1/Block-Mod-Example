using Harmony;
using Nuterra.BlockInjector;
using System;
using System.Reflection;
using UnityEngine;

namespace CustomBlocks
{
    public class Class1
    {
        public static void CreateBlocks()
        {

#warning Change "mod.json" info

            //var harmony = HarmonyInstance.Create("examplepack.changethisname");
            //harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());

            new BlockPrefabBuilder(/*"GSO_Block_111", true*/) //Use a reference if you want quick functionality (explosion effects, etc)
                .SetBlockID(87532) //CHANGE THIS TO SOMETHING RANDOM
                .SetName("Block Name")
                .SetDescription("Description")
                .SetPrice(2000)
                .SetHP(100)
                .SetFaction(FactionSubTypes.SPE)
                .SetCategory(BlockCategories.Standard)
                .SetIcon(GameObjectJSON.SpriteFromImage(GameObjectJSON.ImageFromFile("Blocks/icon.png")))
                .SetMass(1f)
                .SetSize(IntVector3.one, BlockPrefabBuilder.AttachmentPoints.All)
                .SetModel(GameObjectJSON.MeshFromFile("Blocks/block.obj"), true, GameObjectJSON.GetObjectFromGameResources<Material>("GSO_Main"))  //"GC_Main", "HE_Main", "BF_Main", "VEN_Main"
                .RegisterLater();

        }
    }
}