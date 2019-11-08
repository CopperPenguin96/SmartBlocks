using System;
using System.Collections.Generic;

namespace GemBlocks.Blocks
{
    public class BlockRegistry
    {
        public static List<Block> Blocks;

        public static void Load()
        {
            Console.WriteLine("Load the Block Registry...");

            #region Blocks to Registry

            Blocks.Add(Air);
            Blocks.Add(Stone);
            Blocks.Add(Granite);
            Blocks.Add(PolishedGranite);
            Blocks.Add(Diorite);
            Blocks.Add(PolishedDiorite);
            Blocks.Add(Andesite);
            Blocks.Add(PolishedAndesite);
            Blocks.Add(GrassBlock);
            Blocks.Add(Dirt);
            Blocks.Add(CoarseDirt);
            Blocks.Add(Podzol);
            Blocks.Add(Cobblestone);
            Blocks.Add(OakWoodPlank);
            Blocks.Add(SpruceWoodPlank);
            Blocks.Add(BirchWoodPlank);
            Blocks.Add(JungleWoodPlank);
            Blocks.Add(AcaciaWoodPlank);
            Blocks.Add(DarkOakWoodPlank);
            Blocks.Add(OakSapling);
            Blocks.Add(SpruceSapling);
            Blocks.Add(BirchSapling);
            Blocks.Add(JungleSapling);
            Blocks.Add(AcaciaSapling);
            Blocks.Add(DarkOakSapling);
            Blocks.Add(Bedrock);
            Blocks.Add(FlowingWater);
            Blocks.Add(StillWater);
            Blocks.Add(FlowingLava);
            Blocks.Add(StillLava);
            Blocks.Add(Sand);
            Blocks.Add(RedSand);
            Blocks.Add(Gravel);
            Blocks.Add(GoldOre);
            Blocks.Add(IronOre);
            Blocks.Add(CoalOre);
            Blocks.Add(OakWood);
            Blocks.Add(SpruceWood);
            Blocks.Add(BirchWood);
            Blocks.Add(JungleWood);
            Blocks.Add(OakLeaves);
            Blocks.Add(SpruceLeaves);
            Blocks.Add(BirchLeaves);
            Blocks.Add(JungleLeaves);
            Blocks.Add(Sponge);
            Blocks.Add(WetSponge);
            Blocks.Add(Glass);
            Blocks.Add(LapisLazuliOre);
            Blocks.Add(LapisLazuliBlock);
            Blocks.Add(Dispenser);
            Blocks.Add(Sandstone);
            Blocks.Add(ChiseledSandstone);
            Blocks.Add(SmoothSandstone);
            Blocks.Add(NoteBlock);
            Blocks.Add(BedBlock);
            Blocks.Add(PoweredRail);
            Blocks.Add(DetectorRail);
            Blocks.Add(StickyPiston);
            Blocks.Add(Cobweb);
            Blocks.Add(DeadShrub);
            Blocks.Add(Grass);
            Blocks.Add(Fern);
            Blocks.Add(DeadBush);
            Blocks.Add(Piston);
            Blocks.Add(PistonHead);
            Blocks.Add(WhiteWool);
            Blocks.Add(OrangeWool);
            Blocks.Add(MagentaWool);
            Blocks.Add(LightBlueWool);
            Blocks.Add(YellowWool);
            Blocks.Add(LimeWool);
            Blocks.Add(PinkWool);
            Blocks.Add(GrayWool);
            Blocks.Add(LightGrayWool);
            Blocks.Add(CyanWool);
            Blocks.Add(PurpleWool);
            Blocks.Add(BlueWool);
            Blocks.Add(BrownWool);
            Blocks.Add(GreenWool);
            Blocks.Add(RedWool);
            Blocks.Add(BlackWool);
            Blocks.Add(Dandelion);
            Blocks.Add(Poppy);
            Blocks.Add(BlueOrchid);
            Blocks.Add(Allium);
            Blocks.Add(AzureBluet);
            Blocks.Add(RedTulip);
            Blocks.Add(OrangeTulip);
            Blocks.Add(WhiteTulip);
            Blocks.Add(PinkTulip);
            Blocks.Add(OxeyeDaisy);
            Blocks.Add(BrownMushroom);
            Blocks.Add(RedMushroom);
            Blocks.Add(GoldBlock);
            Blocks.Add(IronBlock);
            Blocks.Add(DoubleStoneSlab);
            Blocks.Add(DoubleSandstoneSlab);
            Blocks.Add(DoubleWoodenSlab);
            Blocks.Add(DoubleCobblestoneSlab);
            Blocks.Add(DoubleBrickSlab);
            Blocks.Add(DoubleStoneBrickSlab);
            Blocks.Add(DoubleNetherBrickSlab);
            Blocks.Add(DoubleQuartzSlab);
            Blocks.Add(StoneSlab);
            Blocks.Add(SandstoneSlab);
            Blocks.Add(WoodenSlab);
            Blocks.Add(CobblestoneSlab);
            Blocks.Add(BrickSlab);
            Blocks.Add(StoneBrickSlab);
            Blocks.Add(NetherBrickSlab);
            Blocks.Add(QuartzSlab);
            Blocks.Add(Bricks);
            Blocks.Add(TNT);
            Blocks.Add(Bookshelf);
            Blocks.Add(MossStone);
            Blocks.Add(Obsidian);
            Blocks.Add(Torch);
            Blocks.Add(Fire);
            Blocks.Add(MonsterSpawner);
            Blocks.Add(OakWoodStairs);
            Blocks.Add(Chest);
            Blocks.Add(RedstoneWire);
            Blocks.Add(DiamondOre);
            Blocks.Add(DiamondBlock);
            Blocks.Add(CraftingTable);
            Blocks.Add(WheatCrops);
            Blocks.Add(Farmland);
            Blocks.Add(Furnace);
            Blocks.Add(BurningFurnace);
            Blocks.Add(StandingSignBlock);
            Blocks.Add(OakDoorBlock);
            Blocks.Add(Ladder);
            Blocks.Add(Rail);
            Blocks.Add(CobblestoneStairs);
            Blocks.Add(WallMountedSign);
            Blocks.Add(Lever);
            Blocks.Add(StonePressurePlate);
            Blocks.Add(IronDoorBlock);
            Blocks.Add(WoodenPressurePlate);
            Blocks.Add(RedstoneOre);
            Blocks.Add(GlowingRedstoneOre);
            Blocks.Add(RedstoneTorchOff);
            Blocks.Add(RedstoneTorchOn);
            Blocks.Add(StoneButton);
            Blocks.Add(Snow);
            Blocks.Add(Ice);
            Blocks.Add(SnowBlock);
            Blocks.Add(Cactus);
            Blocks.Add(ClayBlock);
            Blocks.Add(SugarCanes);
            Blocks.Add(Jukebox);
            Blocks.Add(OakFence);
            Blocks.Add(Pumpkin);
            Blocks.Add(Netherrack);
            Blocks.Add(SoulSand);
            Blocks.Add(Glowstone);
            Blocks.Add(NetherPortal);
            Blocks.Add(JackOLantern);
            Blocks.Add(CakeBlock);
            Blocks.Add(RedstoneRepeaterBlockOff);
            Blocks.Add(RedstoneRepeaterBlockOn);
            Blocks.Add(WhiteStainedGlass);
            Blocks.Add(OrangeStainedGlass);
            Blocks.Add(MagentaStainedGlass);
            Blocks.Add(LightBlueStainedGlass);
            Blocks.Add(YellowStainedGlass);
            Blocks.Add(LimeStainedGlass);
            Blocks.Add(PinkStainedGlass);
            Blocks.Add(GrayStainedGlass);
            Blocks.Add(LightGrayStainedGlass);
            Blocks.Add(CyanStainedGlass);
            Blocks.Add(PurpleStainedGlass);
            Blocks.Add(BlueStainedGlass);
            Blocks.Add(BrownStainedGlass);
            Blocks.Add(GreenStainedGlass);
            Blocks.Add(RedStainedGlass);
            Blocks.Add(BlackStainedGlass);
            Blocks.Add(WoodenTrapdoor);
            Blocks.Add(StoneMonsterEgg);
            Blocks.Add(CobblestoneMonsterEgg);
            Blocks.Add(StoneBrickMonsterEgg);
            Blocks.Add(MossyStoneBrickMonsterEgg);
            Blocks.Add(CrackedStoneBrickMonsterEgg);
            Blocks.Add(ChiseledStoneBrickMonsterEgg);
            Blocks.Add(StoneBricks);
            Blocks.Add(MossyStoneBricks);
            Blocks.Add(CrackedStoneBricks);
            Blocks.Add(ChiseledStoneBricks);
            Blocks.Add(BrownMushroomBlock);
            Blocks.Add(RedMushroomBlock);
            Blocks.Add(IronBars);
            Blocks.Add(GlassPane);
            Blocks.Add(MelonBlock);
            Blocks.Add(PumpkinStem);
            Blocks.Add(MelonStem);
            Blocks.Add(Vines);
            Blocks.Add(OakFenceGate);
            Blocks.Add(BrickStairs);
            Blocks.Add(StoneBrickStairs);
            Blocks.Add(Mycelium);
            Blocks.Add(LilyPad);
            Blocks.Add(NetherBrickBlock);
            Blocks.Add(NetherBrickFence);
            Blocks.Add(NetherBrickStairs);
            Blocks.Add(NetherWart);
            Blocks.Add(EnchantmentTable);
            Blocks.Add(BrewingStand);
            Blocks.Add(Cauldron);
            Blocks.Add(EndPortal);
            Blocks.Add(EndPortalFrame);
            Blocks.Add(EndStone);
            Blocks.Add(DragonEgg);
            Blocks.Add(RedstoneLampInActive);
            Blocks.Add(RedstoneLampActive);
            Blocks.Add(DoubleOakWoodSlab);
            Blocks.Add(DoubleSpruceWoodSlab);
            Blocks.Add(DoubleBirchWoodSlab);
            Blocks.Add(DoubleJungleWoodSlab);
            Blocks.Add(DoubleAcaciaWoodSlab);
            Blocks.Add(DoubleDarkOakWoodSlab);
            Blocks.Add(OakWoodSlab);
            Blocks.Add(SpruceWoodSlab);
            Blocks.Add(BirchWoodSlab);
            Blocks.Add(JungleWoodSlab);
            Blocks.Add(AcaciaWoodSlab);
            Blocks.Add(DarkOakWoodSlab);
            Blocks.Add(Cocoa);
            Blocks.Add(SandstoneStairs);
            Blocks.Add(EmeraldOre);
            Blocks.Add(EnderChest);
            Blocks.Add(TripwireHook);
            Blocks.Add(Tripwire);
            Blocks.Add(EmeraldBlock);
            Blocks.Add(SpruceWoodStairs);
            Blocks.Add(BirchWoodStairs);
            Blocks.Add(JungleWoodStairs);
            Blocks.Add(CommandBlock);
            Blocks.Add(Beacon);
            Blocks.Add(CobblestoneWall);
            Blocks.Add(MossyCobblestoneWall);
            Blocks.Add(FlowerPot);
            Blocks.Add(Carrots);
            Blocks.Add(Potatoes);
            Blocks.Add(WoodenButton);
            Blocks.Add(MobHeadBlock);
            Blocks.Add(Anvil);
            Blocks.Add(TrappedChest);
            Blocks.Add(WeightedPressurePlateLight);
            Blocks.Add(WeightedPressurePlateHeavy);
            Blocks.Add(RedstoneComparatorInactive);
            Blocks.Add(RedstoneComparatorActive);
            Blocks.Add(DaylightSensor);
            Blocks.Add(RedstoneBlock);
            Blocks.Add(NetherQuartzOre);
            Blocks.Add(Hopper);
            Blocks.Add(QuartzBlock);
            Blocks.Add(ChiseledQuartzBlock);
            Blocks.Add(PillarQuartzBlock);
            Blocks.Add(QuartzStairs);
            Blocks.Add(ActivatorRail);
            Blocks.Add(Dropper);
            Blocks.Add(WhiteHardenedClay);
            Blocks.Add(OrangeHardenedClay);
            Blocks.Add(MagentaHardenedClay);
            Blocks.Add(LightBlueHardenedClay);
            Blocks.Add(YellowHardenedClay);
            Blocks.Add(LimeHardenedClay);
            Blocks.Add(PinkHardenedClay);
            Blocks.Add(GrayHardenedClay);
            Blocks.Add(LightGrayHardenedClay);
            Blocks.Add(CyanHardenedClay);
            Blocks.Add(PurpleHardenedClay);
            Blocks.Add(BlueHardenedClay);
            Blocks.Add(BrownHardenedClay);
            Blocks.Add(GreenHardenedClay);
            Blocks.Add(RedHardenedClay);
            Blocks.Add(BlackHardenedClay);
            Blocks.Add(WhiteStainedGlassPane);
            Blocks.Add(OrangeStainedGlassPane);
            Blocks.Add(MagentaStainedGlassPane);
            Blocks.Add(LightBlueStainedGlassPane);
            Blocks.Add(YellowStainedGlassPane);
            Blocks.Add(LimeStainedGlassPane);
            Blocks.Add(PinkStainedGlassPane);
            Blocks.Add(GrayStainedGlassPane);
            Blocks.Add(LightGrayStainedGlassPane);
            Blocks.Add(CyanStainedGlassPane);
            Blocks.Add(PurpleStainedGlassPane);
            Blocks.Add(BlueStainedGlassPane);
            Blocks.Add(BrownStainedGlassPane);
            Blocks.Add(GreenStainedGlassPane);
            Blocks.Add(RedStainedGlassPane);
            Blocks.Add(BlackStainedGlassPane);
            Blocks.Add(AcaciaLeaves);
            Blocks.Add(DarkOakLeaves);
            Blocks.Add(AcaciaWood);
            Blocks.Add(DarkOakWood);
            Blocks.Add(AcaciaWoodStairs);
            Blocks.Add(DarkOakWoodStairs);
            Blocks.Add(SlimeBlock);
            Blocks.Add(Barrier);
            Blocks.Add(IronTrapdoor);
            Blocks.Add(Prismarine);
            Blocks.Add(PrismarineBricks);
            Blocks.Add(DarkPrismarine);
            Blocks.Add(SeaLantern);
            Blocks.Add(HayBale);
            Blocks.Add(WhiteCarpet);
            Blocks.Add(OrangeCarpet);
            Blocks.Add(MagentaCarpet);
            Blocks.Add(LightBlueCarpet);
            Blocks.Add(YellowCarpet);
            Blocks.Add(LimeCarpet);
            Blocks.Add(PinkCarpet);
            Blocks.Add(GrayCarpet);
            Blocks.Add(LightGrayCarpet);
            Blocks.Add(CyanCarpet);
            Blocks.Add(PurpleCarpet);
            Blocks.Add(BlueCarpet);
            Blocks.Add(BrownCarpet);
            Blocks.Add(GreenCarpet);
            Blocks.Add(RedCarpet);
            Blocks.Add(BlackCarpet);
            Blocks.Add(HardenedClay);
            Blocks.Add(BlockofCoal);
            Blocks.Add(PackedIce);
            Blocks.Add(Sunflower);
            Blocks.Add(Lilac);
            Blocks.Add(DoubleTallgrass);
            Blocks.Add(LargeFern);
            Blocks.Add(RoseBush);
            Blocks.Add(Peony);
            Blocks.Add(FreeStandingBanner);
            Blocks.Add(WallMountedBanner);
            Blocks.Add(InvertedDaylightSensor);
            Blocks.Add(RedSandstone);
            Blocks.Add(ChiseledRedSandstone);
            Blocks.Add(SmoothRedSandstone);
            Blocks.Add(RedSandstoneStairs);
            Blocks.Add(DoubleRedSandstoneSlab);
            Blocks.Add(RedSandstoneSlab);
            Blocks.Add(SpruceFenceGate);
            Blocks.Add(BirchFenceGate);
            Blocks.Add(JungleFenceGate);
            Blocks.Add(DarkOakFenceGate);
            Blocks.Add(AcaciaFenceGate);
            Blocks.Add(SpruceFence);
            Blocks.Add(BirchFence);
            Blocks.Add(JungleFence);
            Blocks.Add(DarkOakFence);
            Blocks.Add(AcaciaFence);
            Blocks.Add(SpruceDoorBlock);
            Blocks.Add(BirchDoorBlock);
            Blocks.Add(JungleDoorBlock);
            Blocks.Add(AcaciaDoorBlock);
            Blocks.Add(DarkOakDoorBlock);
            Blocks.Add(EndRod);
            Blocks.Add(ChorusPlant);
            Blocks.Add(ChorusFlower);
            Blocks.Add(PurpurBlock);
            Blocks.Add(PurpurPillar);
            Blocks.Add(PurpurStairs);
            Blocks.Add(PurpurDoubleSlab);
            Blocks.Add(PurpurSlab);
            Blocks.Add(EndStoneBricks);
            Blocks.Add(BeetrootBlock);
            Blocks.Add(GrassPath);
            Blocks.Add(EndGateway);
            Blocks.Add(RepeatingCommandBlock);
            Blocks.Add(ChainCommandBlock);
            Blocks.Add(FrostedIce);
            Blocks.Add(MagmaBlock);
            Blocks.Add(NetherWartBlk);
            Blocks.Add(NetherWartBlock);
            Blocks.Add(RedNetherBrick);
            Blocks.Add(BoneBlock);
            Blocks.Add(StructureVoid);
            Blocks.Add(Observer);
            Blocks.Add(WhiteShulkerBox);
            Blocks.Add(OrangeShulkerBox);
            Blocks.Add(MagentaShulkerBox);
            Blocks.Add(LightBlueShulkerBox);
            Blocks.Add(YellowShulkerBox);
            Blocks.Add(LimeShulkerBox);
            Blocks.Add(PinkShulkerBox);
            Blocks.Add(GrayShulkerBox);
            Blocks.Add(LightGrayShulkerBox);
            Blocks.Add(CyanShulkerBox);
            Blocks.Add(PurpleShulkerBox);
            Blocks.Add(BlueShulkerBox);
            Blocks.Add(BrownShulkerBox);
            Blocks.Add(GreenShulkerBox);
            Blocks.Add(RedShulkerBox);
            Blocks.Add(BlackShulkerBox);
            Blocks.Add(WhiteGlazedTerracotta);
            Blocks.Add(OrangeGlazedTerracotta);
            Blocks.Add(MagentaGlazedTerracotta);
            Blocks.Add(LightBlueGlazedTerracotta);
            Blocks.Add(YellowGlazedTerracotta);
            Blocks.Add(LimeGlazedTerracotta);
            Blocks.Add(PinkGlazedTerracotta);
            Blocks.Add(GrayGlazedTerracotta);
            Blocks.Add(LightGrayGlazedTerracotta);
            Blocks.Add(CyanGlazedTerracotta);
            Blocks.Add(PurpleGlazedTerracotta);
            Blocks.Add(BlueGlazedTerracotta);
            Blocks.Add(BrownGlazedTerracotta);
            Blocks.Add(GreenGlazedTerracotta);
            Blocks.Add(RedGlazedTerracotta);
            Blocks.Add(BlackGlazedTerracotta);
            Blocks.Add(WhiteConcrete);
            Blocks.Add(OrangeConcrete);
            Blocks.Add(MagentaConcrete);
            Blocks.Add(LightBlueConcrete);
            Blocks.Add(YellowConcrete);
            Blocks.Add(LimeConcrete);
            Blocks.Add(PinkConcrete);
            Blocks.Add(GrayConcrete);
            Blocks.Add(LightGrayConcrete);
            Blocks.Add(CyanConcrete);
            Blocks.Add(PurpleConcrete);
            Blocks.Add(BlueConcrete);
            Blocks.Add(BrownConcrete);
            Blocks.Add(GreenConcrete);
            Blocks.Add(RedConcrete);
            Blocks.Add(BlackConcrete);
            Blocks.Add(WhiteConcretePowder);
            Blocks.Add(OrangeConcretePowder);
            Blocks.Add(MagentaConcretePowder);
            Blocks.Add(LightBlueConcretePowder);
            Blocks.Add(YellowConcretePowder);
            Blocks.Add(LimeConcretePowder);
            Blocks.Add(PinkConcretePowder);
            Blocks.Add(GrayConcretePowder);
            Blocks.Add(LightGrayConcretePowder);
            Blocks.Add(CyanConcretePowder);
            Blocks.Add(PurpleConcretePowder);
            Blocks.Add(BlueConcretePowder);
            Blocks.Add(BrownConcretePowder);
            Blocks.Add(GreenConcretePowder);
            Blocks.Add(RedConcretePowder);
            Blocks.Add(BlackConcretePowder);
            Blocks.Add(StructureBlock);
            Blocks.Add(IronShovel);
            Blocks.Add(IronPickaxe);
            Blocks.Add(IronAxe);
            Blocks.Add(FlintandSteel);
            Blocks.Add(Apple);
            Blocks.Add(Bow);
            Blocks.Add(Arrow);
            Blocks.Add(Coal);
            Blocks.Add(Charcoal);
            Blocks.Add(Diamond);
            Blocks.Add(IronIngot);
            Blocks.Add(GoldIngot);
            Blocks.Add(IronSword);
            Blocks.Add(WoodenSword);
            Blocks.Add(WoodenShovel);
            Blocks.Add(WoodenPickaxe);
            Blocks.Add(WoodenAxe);
            Blocks.Add(StoneSword);
            Blocks.Add(StoneShovel);
            Blocks.Add(StonePickaxe);
            Blocks.Add(StoneAxe);
            Blocks.Add(DiamondSword);
            Blocks.Add(DiamondShovel);
            Blocks.Add(DiamondPickaxe);
            Blocks.Add(DiamondAxe);
            Blocks.Add(Stick);
            Blocks.Add(Bowl);
            Blocks.Add(MushroomStew);
            Blocks.Add(GoldenSword);
            Blocks.Add(GoldenShovel);
            Blocks.Add(GoldenPickaxe);
            Blocks.Add(GoldenAxe);
            Blocks.Add(String);
            Blocks.Add(Feather);
            Blocks.Add(Gunpowder);
            Blocks.Add(WoodenHoe);
            Blocks.Add(StoneHoe);
            Blocks.Add(IronHoe);
            Blocks.Add(DiamondHoe);
            Blocks.Add(GoldenHoe);
            Blocks.Add(WheatSeeds);
            Blocks.Add(Wheat);
            Blocks.Add(Bread);
            Blocks.Add(LeatherHelmet);
            Blocks.Add(LeatherTunic);
            Blocks.Add(LeatherPants);
            Blocks.Add(LeatherBoots);
            Blocks.Add(ChainmailHelmet);
            Blocks.Add(ChainmailChestplate);
            Blocks.Add(ChainmailLeggings);
            Blocks.Add(ChainmailBoots);
            Blocks.Add(IronHelmet);
            Blocks.Add(IronChestplate);
            Blocks.Add(IronLeggings);
            Blocks.Add(IronBoots);
            Blocks.Add(DiamondHelmet);
            Blocks.Add(DiamondChestplate);
            Blocks.Add(DiamondLeggings);
            Blocks.Add(DiamondBoots);
            Blocks.Add(GoldenHelmet);
            Blocks.Add(GoldenChestplate);
            Blocks.Add(GoldenLeggings);
            Blocks.Add(GoldenBoots);
            Blocks.Add(Flint);
            Blocks.Add(RawPorkchop);
            Blocks.Add(CookedPorkchop);
            Blocks.Add(Painting);
            Blocks.Add(GoldenApple);
            Blocks.Add(EnchantedGoldenApple);
            Blocks.Add(Sign);
            Blocks.Add(OakDoor);
            Blocks.Add(Bucket);
            Blocks.Add(WaterBucket);
            Blocks.Add(LavaBucket);
            Blocks.Add(Minecart);
            Blocks.Add(Saddle);
            Blocks.Add(IronDoor);
            Blocks.Add(Redstone);
            Blocks.Add(Snowball);
            Blocks.Add(OakBoat);
            Blocks.Add(Leather);
            Blocks.Add(MilkBucket);
            Blocks.Add(Brick);
            Blocks.Add(Clay);
            Blocks.Add(SugarCanesBlock);
            Blocks.Add(Paper);
            Blocks.Add(Book);
            Blocks.Add(Slimeball);
            Blocks.Add(MinecartwithChest);
            Blocks.Add(MinecartwithFurnace);
            Blocks.Add(Egg);
            Blocks.Add(Compass);
            Blocks.Add(FishingRod);
            Blocks.Add(Clock);
            Blocks.Add(GlowstoneDust);
            Blocks.Add(RawFish);
            Blocks.Add(RawSalmon);
            Blocks.Add(Clownfish);
            Blocks.Add(Pufferfish);
            Blocks.Add(CookedFish);
            Blocks.Add(CookedSalmon);
            Blocks.Add(InkSack);
            Blocks.Add(RoseRed);
            Blocks.Add(CactusGreen);
            Blocks.Add(CocoBeans);
            Blocks.Add(LapisLazuli);
            Blocks.Add(PurpleDye);
            Blocks.Add(CyanDye);
            Blocks.Add(LightGrayDye);
            Blocks.Add(GrayDye);
            Blocks.Add(PinkDye);
            Blocks.Add(LimeDye);
            Blocks.Add(DandelionYellow);
            Blocks.Add(LightBlueDye);
            Blocks.Add(MagentaDye);
            Blocks.Add(OrangeDye);
            Blocks.Add(BoneMeal);
            Blocks.Add(Bone);
            Blocks.Add(Sugar);
            Blocks.Add(Cake);
            Blocks.Add(Bed);
            Blocks.Add(RedstoneRepeater);
            Blocks.Add(Cookie);
            Blocks.Add(Map);
            Blocks.Add(Shears);
            Blocks.Add(Melon);
            Blocks.Add(PumpkinSeeds);
            Blocks.Add(MelonSeeds);
            Blocks.Add(RawBeef);
            Blocks.Add(Steak);
            Blocks.Add(RawChicken);
            Blocks.Add(CookedChicken);
            Blocks.Add(RottenFlesh);
            Blocks.Add(EnderPearl);
            Blocks.Add(BlazeRod);
            Blocks.Add(GhastTear);
            Blocks.Add(GoldNugget);
            Blocks.Add(NetherWart);
            Blocks.Add(Potion);
            Blocks.Add(GlassBottle);
            Blocks.Add(SpiderEye);
            Blocks.Add(FermentedSpiderEye);
            Blocks.Add(BlazePowder);
            Blocks.Add(MagmaCream);
            Blocks.Add(BrewingStandBlock);
            Blocks.Add(CauldronBlock);
            Blocks.Add(EyeofEnder);
            Blocks.Add(GlisteringMelon);
            Blocks.Add(SpawnElderGuardian);
            Blocks.Add(SpawnWitherSkeleton);
            Blocks.Add(SpawnStray);
            Blocks.Add(SpawnHusk);
            Blocks.Add(SpawnZombieVillager);
            Blocks.Add(SpawnSkeletonHorse);
            Blocks.Add(SpawnZombieHorse);
            Blocks.Add(SpawnDonkey);
            Blocks.Add(SpawnMule);
            Blocks.Add(SpawnEvoker);
            Blocks.Add(SpawnVex);
            Blocks.Add(SpawnVindicator);
            Blocks.Add(SpawnCreeper);
            Blocks.Add(SpawnSkeleton);
            Blocks.Add(SpawnSpider);
            Blocks.Add(SpawnZombie);
            Blocks.Add(SpawnSlime);
            Blocks.Add(SpawnGhast);
            Blocks.Add(SpawnZombiePigman);
            Blocks.Add(SpawnEnderman);
            Blocks.Add(SpawnCaveSpider);
            Blocks.Add(SpawnSilverfish);
            Blocks.Add(SpawnBlaze);
            Blocks.Add(SpawnMagmaCube);
            Blocks.Add(SpawnBat);
            Blocks.Add(SpawnWitch);
            Blocks.Add(SpawnEndermite);
            Blocks.Add(SpawnGuardian);
            Blocks.Add(SpawnShulker);
            Blocks.Add(SpawnPig);
            Blocks.Add(SpawnSheep);
            Blocks.Add(SpawnCow);
            Blocks.Add(SpawnChicken);
            Blocks.Add(SpawnSquid);
            Blocks.Add(SpawnWolf);
            Blocks.Add(SpawnMooshroom);
            Blocks.Add(SpawnOcelot);
            Blocks.Add(SpawnHorse);
            Blocks.Add(SpawnRabbit);
            Blocks.Add(SpawnPolarBear);
            Blocks.Add(SpawnLlama);
            Blocks.Add(SpawnParrot);
            Blocks.Add(SpawnVillager);
            Blocks.Add(BottleOEnchanting);
            Blocks.Add(FireCharge);
            Blocks.Add(BookandQuill);
            Blocks.Add(WrittenBook);
            Blocks.Add(Emerald);
            Blocks.Add(ItemFrame);
            Blocks.Add(FlowerPotBlock);
            Blocks.Add(Carrot);
            Blocks.Add(Potato);
            Blocks.Add(BakedPotato);
            Blocks.Add(PoisonousPotato);
            Blocks.Add(EmptyMap);
            Blocks.Add(GoldenCarrot);
            Blocks.Add(MobHeadSkeleton);
            Blocks.Add(MobHeadWither);
            Blocks.Add(MobHeadZombie);
            Blocks.Add(MobHeadHuman);
            Blocks.Add(MobHeadCreeper);
            Blocks.Add(MobHeadDragon);
            Blocks.Add(CarrotonaStick);
            Blocks.Add(NetherStar);
            Blocks.Add(PumpkinPie);
            Blocks.Add(FireworkRocket);
            Blocks.Add(FireworkStar);
            Blocks.Add(EnchantedBook);
            Blocks.Add(RedstoneComparator);
            Blocks.Add(NetherBrick);
            Blocks.Add(NetherQuartz);
            Blocks.Add(MinecartwithTnt);
            Blocks.Add(MinecartwithHopper);
            Blocks.Add(PrismarineShard);
            Blocks.Add(PrismarineCrystals);
            Blocks.Add(RawRabbit);
            Blocks.Add(CookedRabbit);
            Blocks.Add(RabbitStew);
            Blocks.Add(RabbitFoot);
            Blocks.Add(RabbitHide);
            Blocks.Add(ArmorStand);
            Blocks.Add(IronHorseArmor);
            Blocks.Add(GoldenHorseArmor);
            Blocks.Add(DiamondHorseArmor);
            Blocks.Add(Lead);
            Blocks.Add(NameTag);
            Blocks.Add(MinecartwithCommandBlock);
            Blocks.Add(RawMutton);
            Blocks.Add(CookedMutton);
            Blocks.Add(Banner);
            Blocks.Add(EndCrystal);
            Blocks.Add(SpruceDoor);
            Blocks.Add(BirchDoor);
            Blocks.Add(JungleDoor);
            Blocks.Add(AcaciaDoor);
            Blocks.Add(DarkOakDoor);
            Blocks.Add(ChorusFruit);
            Blocks.Add(PoppedChorusFruit);
            Blocks.Add(Beetroot);
            Blocks.Add(BeetrootSeeds);
            Blocks.Add(BeetrootSoup);
            Blocks.Add(DragonBreath);
            Blocks.Add(SplashPotion);
            Blocks.Add(SpectralArrow);
            Blocks.Add(TippedArrow);
            Blocks.Add(LingeringPotion);
            Blocks.Add(Shield);
            Blocks.Add(Elytra);
            Blocks.Add(SpruceBoat);
            Blocks.Add(BirchBoat);
            Blocks.Add(JungleBoat);
            Blocks.Add(AcaciaBoat);
            Blocks.Add(DarkOakBoat);
            Blocks.Add(TotemofUndying);
            Blocks.Add(ShulkerShell);
            Blocks.Add(IronNugget);
            Blocks.Add(KnowledgeBook);
            Blocks.Add(Disc13);
            Blocks.Add(CatDisc);
            Blocks.Add(BlocksDisc);
            Blocks.Add(ChirpDisc);
            Blocks.Add(FarDisc);
            Blocks.Add(MallDisc);
            Blocks.Add(MellohiDisc);
            Blocks.Add(StalDisc);
            Blocks.Add(StradDisc);
            Blocks.Add(WardDisc);
            Blocks.Add(Disc11);
            Blocks.Add(WaitDisc);

            #endregion
        }

        public static readonly Block Air = new Block(0, 0)
        {
            Name = "Air",
            TextType = "air"
        };

        public static readonly Block Stone = new Block(1, 0)
        {
            Name = "Stone",
            TextType = "stone"
        };

        public static readonly Block Granite = new Block(1, 1)
        {
            Name = "Granite",
            TextType = "stone"
        };

        public static readonly Block PolishedGranite = new Block(1, 2)
        {
            Name = "PolishedGranite",
            TextType = "stone"
        };

        public static readonly Block Diorite = new Block(1, 3)
        {
            Name = "Diorite",
            TextType = "stone"
        };

        public static readonly Block PolishedDiorite = new Block(1, 4)
        {
            Name = "PolishedDiorite",
            TextType = "stone"
        };

        public static readonly Block Andesite = new Block(1, 5)
        {
            Name = "Andesite",
            TextType = "stone"
        };

        public static readonly Block PolishedAndesite = new Block(1, 6)
        {
            Name = "PolishedAndesite",
            TextType = "stone"
        };

        public static readonly Block GrassBlock = new Block(2, 0)
        {
            Name = "Grass",
            TextType = "grass"
        };

        public static readonly Block Dirt = new Block(3, 0)
        {
            Name = "Dirt",
            TextType = "dirt"
        };

        public static readonly Block CoarseDirt = new Block(3, 1)
        {
            Name = "CoarseDirt",
            TextType = "dirt"
        };

        public static readonly Block Podzol = new Block(3, 2)
        {
            Name = "Podzol",
            TextType = "dirt"
        };

        public static readonly Block Cobblestone = new Block(4, 0)
        {
            Name = "Cobblestone",
            TextType = "cobblestone"
        };

        public static readonly Block OakWoodPlank = new Block(5, 0)
        {
            Name = "OakWoodPlank",
            TextType = "planks"
        };

        public static readonly Block SpruceWoodPlank = new Block(5, 1)
        {
            Name = "SpruceWoodPlank",
            TextType = "planks"
        };

        public static readonly Block BirchWoodPlank = new Block(5, 2)
        {
            Name = "BirchWoodPlank",
            TextType = "planks"
        };

        public static readonly Block JungleWoodPlank = new Block(5, 3)
        {
            Name = "JungleWoodPlank",
            TextType = "planks"
        };

        public static readonly Block AcaciaWoodPlank = new Block(5, 4)
        {
            Name = "AcaciaWoodPlank",
            TextType = "planks"
        };

        public static readonly Block DarkOakWoodPlank = new Block(5, 5)
        {
            Name = "DarkOakWoodPlank",
            TextType = "planks"
        };

        public static readonly Block OakSapling = new Block(6, 0)
        {
            Name = "OakSapling",
            TextType = "sapling"
        };

        public static readonly Block SpruceSapling = new Block(6, 1)
        {
            Name = "SpruceSapling",
            TextType = "sapling"
        };

        public static readonly Block BirchSapling = new Block(6, 2)
        {
            Name = "BirchSapling",
            TextType = "sapling"
        };

        public static readonly Block JungleSapling = new Block(6, 3)
        {
            Name = "JungleSapling",
            TextType = "sapling"
        };

        public static readonly Block AcaciaSapling = new Block(6, 4)
        {
            Name = "AcaciaSapling",
            TextType = "sapling"
        };

        public static readonly Block DarkOakSapling = new Block(6, 5)
        {
            Name = "DarkOakSapling",
            TextType = "sapling"
        };

        public static readonly Block Bedrock = new Block(7, 0)
        {
            Name = "Bedrock",
            TextType = "bedrock"
        };

        public static readonly Block FlowingWater = new Block(8, 0)
        {
            Name = "FlowingWater",
            TextType = "flowing_water"
        };

        public static readonly Block StillWater = new Block(9, 0)
        {
            Name = "StillWater",
            TextType = "water"
        };

        public static readonly Block FlowingLava = new Block(10, 0)
        {
            Name = "FlowingLava",
            TextType = "flowing_lava"
        };

        public static readonly Block StillLava = new Block(11, 0)
        {
            Name = "StillLava",
            TextType = "lava"
        };

        public static readonly Block Sand = new Block(12, 0)
        {
            Name = "Sand",
            TextType = "sand"
        };

        public static readonly Block RedSand = new Block(12, 1)
        {
            Name = "RedSand",
            TextType = "sand"
        };

        public static readonly Block Gravel = new Block(13, 0)
        {
            Name = "Gravel",
            TextType = "gravel"
        };

        public static readonly Block GoldOre = new Block(14, 0)
        {
            Name = "GoldOre",
            TextType = "gold_ore"
        };

        public static readonly Block IronOre = new Block(15, 0)
        {
            Name = "IronOre",
            TextType = "iron_ore"
        };

        public static readonly Block CoalOre = new Block(16, 0)
        {
            Name = "CoalOre",
            TextType = "coal_ore"
        };

        public static readonly Block OakWood = new Block(17, 0)
        {
            Name = "OakWood",
            TextType = "log"
        };

        public static readonly Block SpruceWood = new Block(17, 1)
        {
            Name = "SpruceWood",
            TextType = "log"
        };

        public static readonly Block BirchWood = new Block(17, 2)
        {
            Name = "BirchWood",
            TextType = "log"
        };

        public static readonly Block JungleWood = new Block(17, 3)
        {
            Name = "JungleWood",
            TextType = "log"
        };

        public static readonly Block OakLeaves = new Block(18, 0)
        {
            Name = "OakLeaves",
            TextType = "leaves"
        };

        public static readonly Block SpruceLeaves = new Block(18, 1)
        {
            Name = "SpruceLeaves",
            TextType = "leaves"
        };

        public static readonly Block BirchLeaves = new Block(18, 2)
        {
            Name = "BirchLeaves",
            TextType = "leaves"
        };

        public static readonly Block JungleLeaves = new Block(18, 3)
        {
            Name = "JungleLeaves",
            TextType = "leaves"
        };

        public static readonly Block Sponge = new Block(19, 0)
        {
            Name = "Sponge",
            TextType = "sponge"
        };

        public static readonly Block WetSponge = new Block(19, 1)
        {
            Name = "WetSponge",
            TextType = "sponge"
        };

        public static readonly Block Glass = new Block(20, 0)
        {
            Name = "Glass",
            TextType = "glass"
        };

        public static readonly Block LapisLazuliOre = new Block(21, 0)
        {
            Name = "LapisLazuliOre",
            TextType = "lapis_ore"
        };

        public static readonly Block LapisLazuliBlock = new Block(22, 0)
        {
            Name = "LapisLazuliBlock",
            TextType = "lapis_block"
        };

        public static readonly Block Dispenser = new Block(23, 0)
        {
            Name = "Dispenser",
            TextType = "dispenser"
        };

        public static readonly Block Sandstone = new Block(24, 0)
        {
            Name = "Sandstone",
            TextType = "sandstone"
        };

        public static readonly Block ChiseledSandstone = new Block(24, 1)
        {
            Name = "ChiseledSandstone",
            TextType = "sandstone"
        };

        public static readonly Block SmoothSandstone = new Block(24, 2)
        {
            Name = "SmoothSandstone",
            TextType = "sandstone"
        };

        public static readonly Block NoteBlock = new Block(25, 0)
        {
            Name = "NoteBlock",
            TextType = "noteblock"
        };

        public static readonly Block BedBlock = new Block(26, 0)
        {
            Name = "Bed",
            TextType = "bed"
        };

        public static readonly Block PoweredRail = new Block(27, 0)
        {
            Name = "PoweredRail",
            TextType = "golden_rail"
        };

        public static readonly Block DetectorRail = new Block(28, 0)
        {
            Name = "DetectorRail",
            TextType = "detector_rail"
        };

        public static readonly Block StickyPiston = new Block(29, 0)
        {
            Name = "StickyPiston",
            TextType = "sticky_piston"
        };

        public static readonly Block Cobweb = new Block(30, 0)
        {
            Name = "Cobweb",
            TextType = "web"
        };

        public static readonly Block DeadShrub = new Block(31, 0)
        {
            Name = "DeadShrub",
            TextType = "tallgrass"
        };

        public static readonly Block Grass = new Block(31, 1)
        {
            Name = "Grass",
            TextType = "tallgrass"
        };

        public static readonly Block Fern = new Block(31, 2)
        {
            Name = "Fern",
            TextType = "tallgrass"
        };

        public static readonly Block DeadBush = new Block(32, 0)
        {
            Name = "DeadBush",
            TextType = "deadbush"
        };

        public static readonly Block Piston = new Block(33, 0)
        {
            Name = "Piston",
            TextType = "piston"
        };

        public static readonly Block PistonHead = new Block(34, 0)
        {
            Name = "PistonHead",
            TextType = "piston_head"
        };

        public static readonly Block WhiteWool = new Block(35, 0)
        {
            Name = "WhiteWool",
            TextType = "wool"
        };

        public static readonly Block OrangeWool = new Block(35, 1)
        {
            Name = "OrangeWool",
            TextType = "wool"
        };

        public static readonly Block MagentaWool = new Block(35, 2)
        {
            Name = "MagentaWool",
            TextType = "wool"
        };

        public static readonly Block LightBlueWool = new Block(35, 3)
        {
            Name = "LightBlueWool",
            TextType = "wool"
        };

        public static readonly Block YellowWool = new Block(35, 4)
        {
            Name = "YellowWool",
            TextType = "wool"
        };

        public static readonly Block LimeWool = new Block(35, 5)
        {
            Name = "LimeWool",
            TextType = "wool"
        };

        public static readonly Block PinkWool = new Block(35, 6)
        {
            Name = "PinkWool",
            TextType = "wool"
        };

        public static readonly Block GrayWool = new Block(35, 7)
        {
            Name = "GrayWool",
            TextType = "wool"
        };

        public static readonly Block LightGrayWool = new Block(35, 8)
        {
            Name = "LightGrayWool",
            TextType = "wool"
        };

        public static readonly Block CyanWool = new Block(35, 9)
        {
            Name = "CyanWool",
            TextType = "wool"
        };

        public static readonly Block PurpleWool = new Block(35, 10)
        {
            Name = "PurpleWool",
            TextType = "wool"
        };

        public static readonly Block BlueWool = new Block(35, 11)
        {
            Name = "BlueWool",
            TextType = "wool"
        };

        public static readonly Block BrownWool = new Block(35, 12)
        {
            Name = "BrownWool",
            TextType = "wool"
        };

        public static readonly Block GreenWool = new Block(35, 13)
        {
            Name = "GreenWool",
            TextType = "wool"
        };

        public static readonly Block RedWool = new Block(35, 14)
        {
            Name = "RedWool",
            TextType = "wool"
        };

        public static readonly Block BlackWool = new Block(35, 15)
        {
            Name = "BlackWool",
            TextType = "wool"
        };

        public static readonly Block Dandelion = new Block(37, 0)
        {
            Name = "Dandelion",
            TextType = "yellow_flower"
        };

        public static readonly Block Poppy = new Block(38, 0)
        {
            Name = "Poppy",
            TextType = "red_flower"
        };

        public static readonly Block BlueOrchid = new Block(38, 1)
        {
            Name = "BlueOrchid",
            TextType = "red_flower"
        };

        public static readonly Block Allium = new Block(38, 2)
        {
            Name = "Allium",
            TextType = "red_flower"
        };

        public static readonly Block AzureBluet = new Block(38, 3)
        {
            Name = "AzureBluet",
            TextType = "red_flower"
        };

        public static readonly Block RedTulip = new Block(38, 4)
        {
            Name = "RedTulip",
            TextType = "red_flower"
        };

        public static readonly Block OrangeTulip = new Block(38, 5)
        {
            Name = "OrangeTulip",
            TextType = "red_flower"
        };

        public static readonly Block WhiteTulip = new Block(38, 6)
        {
            Name = "WhiteTulip",
            TextType = "red_flower"
        };

        public static readonly Block PinkTulip = new Block(38, 7)
        {
            Name = "PinkTulip",
            TextType = "red_flower"
        };

        public static readonly Block OxeyeDaisy = new Block(38, 8)
        {
            Name = "OxeyeDaisy",
            TextType = "red_flower"
        };

        public static readonly Block BrownMushroom = new Block(39, 0)
        {
            Name = "BrownMushroom",
            TextType = "brown_mushroom"
        };

        public static readonly Block RedMushroom = new Block(40, 0)
        {
            Name = "RedMushroom",
            TextType = "red_mushroom"
        };

        public static readonly Block GoldBlock = new Block(41, 0)
        {
            Name = "GoldBlock",
            TextType = "gold_block"
        };

        public static readonly Block IronBlock = new Block(42, 0)
        {
            Name = "IronBlock",
            TextType = "iron_block"
        };

        public static readonly Block DoubleStoneSlab = new Block(43, 0)
        {
            Name = "DoubleStoneSlab",
            TextType = "double_stone_slab"
        };

        public static readonly Block DoubleSandstoneSlab = new Block(43, 1)
        {
            Name = "DoubleSandstoneSlab",
            TextType = "double_stone_slab"
        };

        public static readonly Block DoubleWoodenSlab = new Block(43, 2)
        {
            Name = "DoubleWoodenSlab",
            TextType = "double_stone_slab"
        };

        public static readonly Block DoubleCobblestoneSlab = new Block(43, 3)
        {
            Name = "DoubleCobblestoneSlab",
            TextType = "double_stone_slab"
        };

        public static readonly Block DoubleBrickSlab = new Block(43, 4)
        {
            Name = "DoubleBrickSlab",
            TextType = "double_stone_slab"
        };

        public static readonly Block DoubleStoneBrickSlab = new Block(43, 5)
        {
            Name = "DoubleStoneBrickSlab",
            TextType = "double_stone_slab"
        };

        public static readonly Block DoubleNetherBrickSlab = new Block(43, 6)
        {
            Name = "DoubleNetherBrickSlab",
            TextType = "double_stone_slab"
        };

        public static readonly Block DoubleQuartzSlab = new Block(43, 7)
        {
            Name = "DoubleQuartzSlab",
            TextType = "double_stone_slab"
        };

        public static readonly Block StoneSlab = new Block(44, 0)
        {
            Name = "StoneSlab",
            TextType = "stone_slab"
        };

        public static readonly Block SandstoneSlab = new Block(44, 1)
        {
            Name = "SandstoneSlab",
            TextType = "stone_slab"
        };

        public static readonly Block WoodenSlab = new Block(44, 2)
        {
            Name = "WoodenSlab",
            TextType = "stone_slab"
        };

        public static readonly Block CobblestoneSlab = new Block(44, 3)
        {
            Name = "CobblestoneSlab",
            TextType = "stone_slab"
        };

        public static readonly Block BrickSlab = new Block(44, 4)
        {
            Name = "BrickSlab",
            TextType = "stone_slab"
        };

        public static readonly Block StoneBrickSlab = new Block(44, 5)
        {
            Name = "StoneBrickSlab",
            TextType = "stone_slab"
        };

        public static readonly Block NetherBrickSlab = new Block(44, 6)
        {
            Name = "NetherBrickSlab",
            TextType = "stone_slab"
        };

        public static readonly Block QuartzSlab = new Block(44, 7)
        {
            Name = "QuartzSlab",
            TextType = "stone_slab"
        };

        public static readonly Block Bricks = new Block(45, 0)
        {
            Name = "Bricks",
            TextType = "brick_block"
        };


        // ReSharper disable once InconsistentNaming
        public static readonly Block TNT = new Block(46, 0)
        {
            Name = "TNT",
            TextType = "tnt"
        };

        public static readonly Block Bookshelf = new Block(47, 0)
        {
            Name = "Bookshelf",
            TextType = "bookshelf"
        };

        public static readonly Block MossStone = new Block(48, 0)
        {
            Name = "MossStone",
            TextType = "mossy_cobblestone"
        };

        public static readonly Block Obsidian = new Block(49, 0)
        {
            Name = "Obsidian",
            TextType = "obsidian"
        };

        public static readonly Block Torch = new Block(50, 0)
        {
            Name = "Torch",
            TextType = "torch"
        };

        public static readonly Block Fire = new Block(51, 0)
        {
            Name = "Fire",
            TextType = "fire"
        };

        public static readonly Block MonsterSpawner = new Block(52, 0)
        {
            Name = "MonsterSpawner",
            TextType = "mob_spawner"
        };

        public static readonly Block OakWoodStairs = new Block(53, 0)
        {
            Name = "OakWoodStairs",
            TextType = "oak_stairs"
        };

        public static readonly Block Chest = new Block(54, 0)
        {
            Name = "Chest",
            TextType = "chest"
        };

        public static readonly Block RedstoneWire = new Block(55, 0)
        {
            Name = "RedstoneWire",
            TextType = "redstone_wire"
        };

        public static readonly Block DiamondOre = new Block(56, 0)
        {
            Name = "DiamondOre",
            TextType = "diamond_ore"
        };

        public static readonly Block DiamondBlock = new Block(57, 0)
        {
            Name = "DiamondBlock",
            TextType = "diamond_block"
        };

        public static readonly Block CraftingTable = new Block(58, 0)
        {
            Name = "CraftingTable",
            TextType = "crafting_table"
        };

        public static readonly Block WheatCrops = new Block(59, 0)
        {
            Name = "WheatCrops",
            TextType = "wheat"
        };

        public static readonly Block Farmland = new Block(60, 0)
        {
            Name = "Farmland",
            TextType = "farmland"
        };

        public static readonly Block Furnace = new Block(61, 0)
        {
            Name = "Furnace",
            TextType = "furnace"
        };

        public static readonly Block BurningFurnace = new Block(62, 0)
        {
            Name = "BurningFurnace",
            TextType = "lit_furnace"
        };

        public static readonly Block StandingSignBlock = new Block(63, 0)
        {
            Name = "StandingSignBlock",
            TextType = "standing_sign"
        };

        public static readonly Block OakDoorBlock = new Block(64, 0)
        {
            Name = "OakDoorBlock",
            TextType = "wooden_door"
        };

        public static readonly Block Ladder = new Block(65, 0)
        {
            Name = "Ladder",
            TextType = "ladder"
        };

        public static readonly Block Rail = new Block(66, 0)
        {
            Name = "Rail",
            TextType = "rail"
        };

        public static readonly Block CobblestoneStairs = new Block(67, 0)
        {
            Name = "CobblestoneStairs",
            TextType = "stone_stairs"
        };

        public static readonly Block WallMountedSign = new Block(68, 0)
        {
            Name = "Wall-mountedSignBlock",
            TextType = "wall_sign"
        };

        public static readonly Block Lever = new Block(69, 0)
        {
            Name = "Lever",
            TextType = "lever"
        };

        public static readonly Block StonePressurePlate = new Block(70, 0)
        {
            Name = "StonePressurePlate",
            TextType = "stone_pressure_plate"
        };

        public static readonly Block IronDoorBlock = new Block(71, 0)
        {
            Name = "IronDoorBlock",
            TextType = "iron_door"
        };

        public static readonly Block WoodenPressurePlate = new Block(72, 0)
        {
            Name = "WoodenPressurePlate",
            TextType = "wooden_pressure_plate"
        };

        public static readonly Block RedstoneOre = new Block(73, 0)
        {
            Name = "RedstoneOre",
            TextType = "redstone_ore"
        };

        public static readonly Block GlowingRedstoneOre = new Block(74, 0)
        {
            Name = "GlowingRedstoneOre",
            TextType = "lit_redstone_ore"
        };

        public static readonly Block RedstoneTorchOff = new Block(75, 0)
        {
            Name = "RedstoneTorch(off)",
            TextType = "unlit_redstone_torch"
        };

        public static readonly Block RedstoneTorchOn = new Block(76, 0)
        {
            Name = "RedstoneTorch(on)",
            TextType = "redstone_torch"
        };

        public static readonly Block StoneButton = new Block(77, 0)
        {
            Name = "StoneButton",
            TextType = "stone_button"
        };

        public static readonly Block Snow = new Block(78, 0)
        {
            Name = "Snow",
            TextType = "snow_layer"
        };

        public static readonly Block Ice = new Block(79, 0)
        {
            Name = "Ice",
            TextType = "ice"
        };

        public static readonly Block SnowBlock = new Block(80, 0)
        {
            Name = "SnowBlock",
            TextType = "snow"
        };

        public static readonly Block Cactus = new Block(81, 0)
        {
            Name = "Cactus",
            TextType = "cactus"
        };

        public static readonly Block ClayBlock = new Block(82, 0)
        {
            Name = "Clay",
            TextType = "clay"
        };

        public static readonly Block SugarCanesBlock = new Block(83, 0)
        {
            Name = "SugarCanes",
            TextType = "reeds"
        };

        public static readonly Block Jukebox = new Block(84, 0)
        {
            Name = "Jukebox",
            TextType = "jukebox"
        };

        public static readonly Block OakFence = new Block(85, 0)
        {
            Name = "OakFence",
            TextType = "fence"
        };

        public static readonly Block Pumpkin = new Block(86, 0)
        {
            Name = "Pumpkin",
            TextType = "pumpkin"
        };

        public static readonly Block Netherrack = new Block(87, 0)
        {
            Name = "Netherrack",
            TextType = "netherrack"
        };

        public static readonly Block SoulSand = new Block(88, 0)
        {
            Name = "SoulSand",
            TextType = "soul_sand"
        };

        public static readonly Block Glowstone = new Block(89, 0)
        {
            Name = "Glowstone",
            TextType = "glowstone"
        };

        public static readonly Block NetherPortal = new Block(90, 0)
        {
            Name = "NetherPortal",
            TextType = "portal"
        };

        public static readonly Block JackOLantern = new Block(91, 0)
        {
            Name = "Jacko'Lantern",
            TextType = "lit_pumpkin"
        };

        public static readonly Block CakeBlock = new Block(92, 0)
        {
            Name = "CakeBlock",
            TextType = "cake"
        };

        public static readonly Block RedstoneRepeaterBlockOff = new Block(93, 0)
        {
            Name = "RedstoneRepeaterBlock(off)",
            TextType = "unpowered_repeater"
        };

        public static readonly Block RedstoneRepeaterBlockOn = new Block(94, 0)
        {
            Name = "RedstoneRepeaterBlock(on)",
            TextType = "powered_repeater"
        };

        public static readonly Block WhiteStainedGlass = new Block(95, 0)
        {
            Name = "WhiteStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block OrangeStainedGlass = new Block(95, 1)
        {
            Name = "OrangeStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block MagentaStainedGlass = new Block(95, 2)
        {
            Name = "MagentaStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block LightBlueStainedGlass = new Block(95, 3)
        {
            Name = "LightBlueStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block YellowStainedGlass = new Block(95, 4)
        {
            Name = "YellowStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block LimeStainedGlass = new Block(95, 5)
        {
            Name = "LimeStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block PinkStainedGlass = new Block(95, 6)
        {
            Name = "PinkStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block GrayStainedGlass = new Block(95, 7)
        {
            Name = "GrayStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block LightGrayStainedGlass = new Block(95, 8)
        {
            Name = "LightGrayStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block CyanStainedGlass = new Block(95, 9)
        {
            Name = "CyanStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block PurpleStainedGlass = new Block(95, 10)
        {
            Name = "PurpleStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block BlueStainedGlass = new Block(95, 11)
        {
            Name = "BlueStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block BrownStainedGlass = new Block(95, 12)
        {
            Name = "BrownStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block GreenStainedGlass = new Block(95, 13)
        {
            Name = "GreenStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block RedStainedGlass = new Block(95, 14)
        {
            Name = "RedStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block BlackStainedGlass = new Block(95, 15)
        {
            Name = "BlackStainedGlass",
            TextType = "stained_glass"
        };

        public static readonly Block WoodenTrapdoor = new Block(96, 0)
        {
            Name = "WoodenTrapdoor",
            TextType = "trapdoor"
        };

        public static readonly Block StoneMonsterEgg = new Block(97, 0)
        {
            Name = "StoneMonsterEgg",
            TextType = "monster_egg"
        };

        public static readonly Block CobblestoneMonsterEgg = new Block(97, 1)
        {
            Name = "CobblestoneMonsterEgg",
            TextType = "monster_egg"
        };

        public static readonly Block StoneBrickMonsterEgg = new Block(97, 2)
        {
            Name = "StoneBrickMonsterEgg",
            TextType = "monster_egg"
        };

        public static readonly Block MossyStoneBrickMonsterEgg = new Block(97, 3)
        {
            Name = "MossyStoneBrickMonsterEgg",
            TextType = "monster_egg"
        };

        public static readonly Block CrackedStoneBrickMonsterEgg = new Block(97, 4)
        {
            Name = "CrackedStoneBrickMonsterEgg",
            TextType = "monster_egg"
        };

        public static readonly Block ChiseledStoneBrickMonsterEgg = new Block(97, 5)
        {
            Name = "ChiseledStoneBrickMonsterEgg",
            TextType = "monster_egg"
        };

        public static readonly Block StoneBricks = new Block(98, 0)
        {
            Name = "StoneBricks",
            TextType = "stonebrick"
        };

        public static readonly Block MossyStoneBricks = new Block(98, 1)
        {
            Name = "MossyStoneBricks",
            TextType = "stonebrick"
        };

        public static readonly Block CrackedStoneBricks = new Block(98, 2)
        {
            Name = "CrackedStoneBricks",
            TextType = "stonebrick"
        };

        public static readonly Block ChiseledStoneBricks = new Block(98, 3)
        {
            Name = "ChiseledStoneBricks",
            TextType = "stonebrick"
        };

        public static readonly Block BrownMushroomBlock = new Block(99, 0)
        {
            Name = "BrownMushroomBlock",
            TextType = "brown_mushroom_block"
        };

        public static readonly Block RedMushroomBlock = new Block(100, 0)
        {
            Name = "RedMushroomBlock",
            TextType = "red_mushroom_block"
        };

        public static readonly Block IronBars = new Block(101, 0)
        {
            Name = "IronBars",
            TextType = "iron_bars"
        };

        public static readonly Block GlassPane = new Block(102, 0)
        {
            Name = "GlassPane",
            TextType = "glass_pane"
        };

        public static readonly Block MelonBlock = new Block(103, 0)
        {
            Name = "MelonBlock",
            TextType = "melon_block"
        };

        public static readonly Block PumpkinStem = new Block(104, 0)
        {
            Name = "PumpkinStem",
            TextType = "pumpkin_stem"
        };

        public static readonly Block MelonStem = new Block(105, 0)
        {
            Name = "MelonStem",
            TextType = "melon_stem"
        };

        public static readonly Block Vines = new Block(106, 0)
        {
            Name = "Vines",
            TextType = "vine"
        };

        public static readonly Block OakFenceGate = new Block(107, 0)
        {
            Name = "OakFenceGate",
            TextType = "fence_gate"
        };

        public static readonly Block BrickStairs = new Block(108, 0)
        {
            Name = "BrickStairs",
            TextType = "brick_stairs"
        };

        public static readonly Block StoneBrickStairs = new Block(109, 0)
        {
            Name = "StoneBrickStairs",
            TextType = "stone_brick_stairs"
        };

        public static readonly Block Mycelium = new Block(110, 0)
        {
            Name = "Mycelium",
            TextType = "mycelium"
        };

        public static readonly Block LilyPad = new Block(111, 0)
        {
            Name = "LilyPad",
            TextType = "waterlily"
        };

        public static readonly Block NetherBrickBlock = new Block(112, 0)
        {
            Name = "NetherBrick",
            TextType = "nether_brick"
        };

        public static readonly Block NetherBrickFence = new Block(113, 0)
        {
            Name = "NetherBrickFence",
            TextType = "nether_brick_fence"
        };

        public static readonly Block NetherBrickStairs = new Block(114, 0)
        {
            Name = "NetherBrickStairs",
            TextType = "nether_brick_stairs"
        };

        public static readonly Block NetherWartBlk = new Block(115, 0)
        {
            Name = "NetherWart",
            TextType = "nether_wart"
        };

        public static readonly Block EnchantmentTable = new Block(116, 0)
        {
            Name = "EnchantmentTable",
            TextType = "enchanting_table"
        };

        public static readonly Block BrewingStandBlock = new Block(117, 0)
        {
            Name = "BrewingStand",
            TextType = "brewing_stand"
        };

        public static readonly Block CauldronBlock = new Block(118, 0)
        {
            Name = "Cauldron",
            TextType = "cauldron"
        };

        public static readonly Block EndPortal = new Block(119, 0)
        {
            Name = "EndPortal",
            TextType = "end_portal"
        };

        public static readonly Block EndPortalFrame = new Block(120, 0)
        {
            Name = "EndPortalFrame",
            TextType = "end_portal_frame"
        };

        public static readonly Block EndStone = new Block(121, 0)
        {
            Name = "EndStone",
            TextType = "end_stone"
        };

        public static readonly Block DragonEgg = new Block(122, 0)
        {
            Name = "DragonEgg",
            TextType = "dragon_egg"
        };

        public static readonly Block RedstoneLampInActive = new Block(123, 0)
        {
            Name = "RedstoneLamp(inactive)",
            TextType = "redstone_lamp"
        };

        public static readonly Block RedstoneLampActive = new Block(124, 0)
        {
            Name = "RedstoneLamp(active)",
            TextType = "lit_redstone_lamp"
        };

        public static readonly Block DoubleOakWoodSlab = new Block(125, 0)
        {
            Name = "DoubleOakWoodSlab",
            TextType = "double_wooden_slab"
        };

        public static readonly Block DoubleSpruceWoodSlab = new Block(125, 1)
        {
            Name = "DoubleSpruceWoodSlab",
            TextType = "double_wooden_slab"
        };

        public static readonly Block DoubleBirchWoodSlab = new Block(125, 2)
        {
            Name = "DoubleBirchWoodSlab",
            TextType = "double_wooden_slab"
        };

        public static readonly Block DoubleJungleWoodSlab = new Block(125, 3)
        {
            Name = "DoubleJungleWoodSlab",
            TextType = "double_wooden_slab"
        };

        public static readonly Block DoubleAcaciaWoodSlab = new Block(125, 4)
        {
            Name = "DoubleAcaciaWoodSlab",
            TextType = "double_wooden_slab"
        };

        public static readonly Block DoubleDarkOakWoodSlab = new Block(125, 5)
        {
            Name = "DoubleDarkOakWoodSlab",
            TextType = "double_wooden_slab"
        };

        public static readonly Block OakWoodSlab = new Block(126, 0)
        {
            Name = "OakWoodSlab",
            TextType = "wooden_slab"
        };

        public static readonly Block SpruceWoodSlab = new Block(126, 1)
        {
            Name = "SpruceWoodSlab",
            TextType = "wooden_slab"
        };

        public static readonly Block BirchWoodSlab = new Block(126, 2)
        {
            Name = "BirchWoodSlab",
            TextType = "wooden_slab"
        };

        public static readonly Block JungleWoodSlab = new Block(126, 3)
        {
            Name = "JungleWoodSlab",
            TextType = "wooden_slab"
        };

        public static readonly Block AcaciaWoodSlab = new Block(126, 4)
        {
            Name = "AcaciaWoodSlab",
            TextType = "wooden_slab"
        };

        public static readonly Block DarkOakWoodSlab = new Block(126, 5)
        {
            Name = "DarkOakWoodSlab",
            TextType = "wooden_slab"
        };

        public static readonly Block Cocoa = new Block(127, 0)
        {
            Name = "Cocoa",
            TextType = "cocoa"
        };

        public static readonly Block SandstoneStairs = new Block(128, 0)
        {
            Name = "SandstoneStairs",
            TextType = "sandstone_stairs"
        };

        public static readonly Block EmeraldOre = new Block(129, 0)
        {
            Name = "EmeraldOre",
            TextType = "emerald_ore"
        };

        public static readonly Block EnderChest = new Block(130, 0)
        {
            Name = "EnderChest",
            TextType = "ender_chest"
        };

        public static readonly Block TripwireHook = new Block(131, 0)
        {
            Name = "TripwireHook",
            TextType = "tripwire_hook"
        };

        public static readonly Block Tripwire = new Block(132, 0)
        {
            Name = "Tripwire",
            TextType = "tripwire_hook"
        };

        public static readonly Block EmeraldBlock = new Block(133, 0)
        {
            Name = "EmeraldBlock",
            TextType = "emerald_block"
        };

        public static readonly Block SpruceWoodStairs = new Block(134, 0)
        {
            Name = "SpruceWoodStairs",
            TextType = "spruce_stairs"
        };

        public static readonly Block BirchWoodStairs = new Block(135, 0)
        {
            Name = "BirchWoodStairs",
            TextType = "birch_stairs"
        };

        public static readonly Block JungleWoodStairs = new Block(136, 0)
        {
            Name = "JungleWoodStairs",
            TextType = "jungle_stairs"
        };

        public static readonly Block CommandBlock = new Block(137, 0)
        {
            Name = "CommandBlock",
            TextType = "command_block"
        };

        public static readonly Block Beacon = new Block(138, 0)
        {
            Name = "Beacon",
            TextType = "beacon"
        };

        public static readonly Block CobblestoneWall = new Block(139, 0)
        {
            Name = "CobblestoneWall",
            TextType = "cobblestone_wall"
        };

        public static readonly Block MossyCobblestoneWall = new Block(139, 1)
        {
            Name = "MossyCobblestoneWall",
            TextType = "cobblestone_wall"
        };

        public static readonly Block FlowerPotBlock = new Block(140, 0)
        {
            Name = "FlowerPot",
            TextType = "flower_pot"
        };

        public static readonly Block Carrots = new Block(141, 0)
        {
            Name = "Carrots",
            TextType = "carrots"
        };

        public static readonly Block Potatoes = new Block(142, 0)
        {
            Name = "Potatoes",
            TextType = "potatoes"
        };

        public static readonly Block WoodenButton = new Block(143, 0)
        {
            Name = "WoodenButton",
            TextType = "wooden_button"
        };

        public static readonly Block MobHeadBlock = new Block(144, 0)
        {
            Name = "MobHead",
            TextType = "skull"
        };

        public static readonly Block Anvil = new Block(145, 0)
        {
            Name = "Anvil",
            TextType = "anvil"
        };

        public static readonly Block TrappedChest = new Block(146, 0)
        {
            Name = "TrappedChest",
            TextType = "trapped_chest"
        };

        public static readonly Block WeightedPressurePlateLight = new Block(147, 0)
        {
            Name = "WeightedPressurePlate(light)",
            TextType = "light_weighted_pressure_plate"
        };

        public static readonly Block WeightedPressurePlateHeavy = new Block(148, 0)
        {
            Name = "WeightedPressurePlate(heavy)",
            TextType = "heavy_weighted_pressure_plate"
        };

        public static readonly Block RedstoneComparatorInactive = new Block(149, 0)
        {
            Name = "RedstoneComparator(inactive)",
            TextType = "unpowered_comparator"
        };

        public static readonly Block RedstoneComparatorActive = new Block(150, 0)
        {
            Name = "RedstoneComparator(active)",
            TextType = "powered_comparator"
        };

        public static readonly Block DaylightSensor = new Block(151, 0)
        {
            Name = "DaylightSensor",
            TextType = "daylight_detector"
        };

        public static readonly Block RedstoneBlock = new Block(152, 0)
        {
            Name = "RedstoneBlock",
            TextType = "redstone_block"
        };

        public static readonly Block NetherQuartzOre = new Block(153, 0)
        {
            Name = "NetherQuartzOre",
            TextType = "quartz_ore"
        };

        public static readonly Block Hopper = new Block(154, 0)
        {
            Name = "Hopper",
            TextType = "hopper"
        };

        public static readonly Block QuartzBlock = new Block(155, 0)
        {
            Name = "QuartzBlock",
            TextType = "quartz_block"
        };

        public static readonly Block ChiseledQuartzBlock = new Block(155, 1)
        {
            Name = "ChiseledQuartzBlock",
            TextType = "quartz_block"
        };

        public static readonly Block PillarQuartzBlock = new Block(155, 2)
        {
            Name = "PillarQuartzBlock",
            TextType = "quartz_block"
        };

        public static readonly Block QuartzStairs = new Block(156, 0)
        {
            Name = "QuartzStairs",
            TextType = "quartz_stairs"
        };

        public static readonly Block ActivatorRail = new Block(157, 0)
        {
            Name = "ActivatorRail",
            TextType = "activator_rail"
        };

        public static readonly Block Dropper = new Block(158, 0)
        {
            Name = "Dropper",
            TextType = "dropper"
        };

        public static readonly Block WhiteHardenedClay = new Block(159, 0)
        {
            Name = "WhiteHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block OrangeHardenedClay = new Block(159, 1)
        {
            Name = "OrangeHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block MagentaHardenedClay = new Block(159, 2)
        {
            Name = "MagentaHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block LightBlueHardenedClay = new Block(159, 3)
        {
            Name = "LightBlueHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block YellowHardenedClay = new Block(159, 4)
        {
            Name = "YellowHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block LimeHardenedClay = new Block(159, 5)
        {
            Name = "LimeHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block PinkHardenedClay = new Block(159, 6)
        {
            Name = "PinkHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block GrayHardenedClay = new Block(159, 7)
        {
            Name = "GrayHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block LightGrayHardenedClay = new Block(159, 8)
        {
            Name = "LightGrayHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block CyanHardenedClay = new Block(159, 9)
        {
            Name = "CyanHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block PurpleHardenedClay = new Block(159, 10)
        {
            Name = "PurpleHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block BlueHardenedClay = new Block(159, 11)
        {
            Name = "BlueHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block BrownHardenedClay = new Block(159, 12)
        {
            Name = "BrownHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block GreenHardenedClay = new Block(159, 13)
        {
            Name = "GreenHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block RedHardenedClay = new Block(159, 14)
        {
            Name = "RedHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block BlackHardenedClay = new Block(159, 15)
        {
            Name = "BlackHardenedClay",
            TextType = "stained_hardened_clay"
        };

        public static readonly Block WhiteStainedGlassPane = new Block(160, 0)
        {
            Name = "WhiteStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block OrangeStainedGlassPane = new Block(160, 1)
        {
            Name = "OrangeStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block MagentaStainedGlassPane = new Block(160, 2)
        {
            Name = "MagentaStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block LightBlueStainedGlassPane = new Block(160, 3)
        {
            Name = "LightBlueStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block YellowStainedGlassPane = new Block(160, 4)
        {
            Name = "YellowStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block LimeStainedGlassPane = new Block(160, 5)
        {
            Name = "LimeStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block PinkStainedGlassPane = new Block(160, 6)
        {
            Name = "PinkStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block GrayStainedGlassPane = new Block(160, 7)
        {
            Name = "GrayStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block LightGrayStainedGlassPane = new Block(160, 8)
        {
            Name = "LightGrayStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block CyanStainedGlassPane = new Block(160, 9)
        {
            Name = "CyanStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block PurpleStainedGlassPane = new Block(160, 10)
        {
            Name = "PurpleStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block BlueStainedGlassPane = new Block(160, 11)
        {
            Name = "BlueStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block BrownStainedGlassPane = new Block(160, 12)
        {
            Name = "BrownStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block GreenStainedGlassPane = new Block(160, 13)
        {
            Name = "GreenStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block RedStainedGlassPane = new Block(160, 14)
        {
            Name = "RedStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block BlackStainedGlassPane = new Block(160, 15)
        {
            Name = "BlackStainedGlassPane",
            TextType = "stained_glass_pane"
        };

        public static readonly Block AcaciaLeaves = new Block(161, 0)
        {
            Name = "AcaciaLeaves",
            TextType = "leaves2"
        };

        public static readonly Block DarkOakLeaves = new Block(161, 1)
        {
            Name = "DarkOakLeaves",
            TextType = "leaves2"
        };

        public static readonly Block AcaciaWood = new Block(162, 0)
        {
            Name = "AcaciaWood",
            TextType = "log2"
        };

        public static readonly Block DarkOakWood = new Block(162, 1)
        {
            Name = "DarkOakWood",
            TextType = "log2"
        };

        public static readonly Block AcaciaWoodStairs = new Block(163, 0)
        {
            Name = "AcaciaWoodStairs",
            TextType = "acacia_stairs"
        };

        public static readonly Block DarkOakWoodStairs = new Block(164, 0)
        {
            Name = "DarkOakWoodStairs",
            TextType = "dark_oak_stairs"
        };

        public static readonly Block SlimeBlock = new Block(165, 0)
        {
            Name = "SlimeBlock",
            TextType = "slime"
        };

        public static readonly Block Barrier = new Block(166, 0)
        {
            Name = "Barrier",
            TextType = "barrier"
        };

        public static readonly Block IronTrapdoor = new Block(167, 0)
        {
            Name = "IronTrapdoor",
            TextType = "iron_trapdoor"
        };

        public static readonly Block Prismarine = new Block(168, 0)
        {
            Name = "Prismarine",
            TextType = "prismarine"
        };

        public static readonly Block PrismarineBricks = new Block(168, 1)
        {
            Name = "PrismarineBricks",
            TextType = "prismarine"
        };

        public static readonly Block DarkPrismarine = new Block(168, 2)
        {
            Name = "DarkPrismarine",
            TextType = "prismarine"
        };

        public static readonly Block SeaLantern = new Block(169, 0)
        {
            Name = "SeaLantern",
            TextType = "sea_lantern"
        };

        public static readonly Block HayBale = new Block(170, 0)
        {
            Name = "HayBale",
            TextType = "hay_block"
        };

        public static readonly Block WhiteCarpet = new Block(171, 0)
        {
            Name = "WhiteCarpet",
            TextType = "carpet"
        };

        public static readonly Block OrangeCarpet = new Block(171, 1)
        {
            Name = "OrangeCarpet",
            TextType = "carpet"
        };

        public static readonly Block MagentaCarpet = new Block(171, 2)
        {
            Name = "MagentaCarpet",
            TextType = "carpet"
        };

        public static readonly Block LightBlueCarpet = new Block(171, 3)
        {
            Name = "LightBlueCarpet",
            TextType = "carpet"
        };

        public static readonly Block YellowCarpet = new Block(171, 4)
        {
            Name = "YellowCarpet",
            TextType = "carpet"
        };

        public static readonly Block LimeCarpet = new Block(171, 5)
        {
            Name = "LimeCarpet",
            TextType = "carpet"
        };

        public static readonly Block PinkCarpet = new Block(171, 6)
        {
            Name = "PinkCarpet",
            TextType = "carpet"
        };

        public static readonly Block GrayCarpet = new Block(171, 7)
        {
            Name = "GrayCarpet",
            TextType = "carpet"
        };

        public static readonly Block LightGrayCarpet = new Block(171, 8)
        {
            Name = "LightGrayCarpet",
            TextType = "carpet"
        };

        public static readonly Block CyanCarpet = new Block(171, 9)
        {
            Name = "CyanCarpet",
            TextType = "carpet"
        };

        public static readonly Block PurpleCarpet = new Block(171, 10)
        {
            Name = "PurpleCarpet",
            TextType = "carpet"
        };

        public static readonly Block BlueCarpet = new Block(171, 11)
        {
            Name = "BlueCarpet",
            TextType = "carpet"
        };

        public static readonly Block BrownCarpet = new Block(171, 12)
        {
            Name = "BrownCarpet",
            TextType = "carpet"
        };

        public static readonly Block GreenCarpet = new Block(171, 13)
        {
            Name = "GreenCarpet",
            TextType = "carpet"
        };

        public static readonly Block RedCarpet = new Block(171, 14)
        {
            Name = "RedCarpet",
            TextType = "carpet"
        };

        public static readonly Block BlackCarpet = new Block(171, 15)
        {
            Name = "BlackCarpet",
            TextType = "carpet"
        };

        public static readonly Block HardenedClay = new Block(172, 0)
        {
            Name = "HardenedClay",
            TextType = "hardened_clay"
        };

        public static readonly Block BlockofCoal = new Block(173, 0)
        {
            Name = "BlockofCoal",
            TextType = "coal_block"
        };

        public static readonly Block PackedIce = new Block(174, 0)
        {
            Name = "PackedIce",
            TextType = "packed_ice"
        };

        public static readonly Block Sunflower = new Block(175, 0)
        {
            Name = "Sunflower",
            TextType = "double_plant"
        };

        public static readonly Block Lilac = new Block(175, 1)
        {
            Name = "Lilac",
            TextType = "double_plant"
        };

        public static readonly Block DoubleTallgrass = new Block(175, 2)
        {
            Name = "DoubleTallgrass",
            TextType = "double_plant"
        };

        public static readonly Block LargeFern = new Block(175, 3)
        {
            Name = "LargeFern",
            TextType = "double_plant"
        };

        public static readonly Block RoseBush = new Block(175, 4)
        {
            Name = "RoseBush",
            TextType = "double_plant"
        };

        public static readonly Block Peony = new Block(175, 5)
        {
            Name = "Peony",
            TextType = "double_plant"
        };

        public static readonly Block FreeStandingBanner = new Block(176, 0)
        {
            Name = "Free-standingBanner",
            TextType = "standing_banner"
        };

        public static readonly Block WallMountedBanner = new Block(177, 0)
        {
            Name = "Wall-mountedBanner",
            TextType = "wall_banner"
        };

        public static readonly Block InvertedDaylightSensor = new Block(178, 0)
        {
            Name = "InvertedDaylightSensor",
            TextType = "daylight_detector_inverted"
        };

        public static readonly Block RedSandstone = new Block(179, 0)
        {
            Name = "RedSandstone",
            TextType = "red_sandstone"
        };

        public static readonly Block ChiseledRedSandstone = new Block(179, 1)
        {
            Name = "ChiseledRedSandstone",
            TextType = "red_sandstone"
        };

        public static readonly Block SmoothRedSandstone = new Block(179, 2)
        {
            Name = "SmoothRedSandstone",
            TextType = "red_sandstone"
        };

        public static readonly Block RedSandstoneStairs = new Block(180, 0)
        {
            Name = "RedSandstoneStairs",
            TextType = "red_sandstone_stairs"
        };

        public static readonly Block DoubleRedSandstoneSlab = new Block(181, 0)
        {
            Name = "DoubleRedSandstoneSlab",
            TextType = "double_stone_slab2"
        };

        public static readonly Block RedSandstoneSlab = new Block(182, 0)
        {
            Name = "RedSandstoneSlab",
            TextType = "stone_slab2"
        };

        public static readonly Block SpruceFenceGate = new Block(183, 0)
        {
            Name = "SpruceFenceGate",
            TextType = "spruce_fence_gate"
        };

        public static readonly Block BirchFenceGate = new Block(184, 0)
        {
            Name = "BirchFenceGate",
            TextType = "birch_fence_gate"
        };

        public static readonly Block JungleFenceGate = new Block(185, 0)
        {
            Name = "JungleFenceGate",
            TextType = "jungle_fence_gate"
        };

        public static readonly Block DarkOakFenceGate = new Block(186, 0)
        {
            Name = "DarkOakFenceGate",
            TextType = "dark_oak_fence_gate"
        };

        public static readonly Block AcaciaFenceGate = new Block(187, 0)
        {
            Name = "AcaciaFenceGate",
            TextType = "acacia_fence_gate"
        };

        public static readonly Block SpruceFence = new Block(188, 0)
        {
            Name = "SpruceFence",
            TextType = "spruce_fence"
        };

        public static readonly Block BirchFence = new Block(189, 0)
        {
            Name = "BirchFence",
            TextType = "birch_fence"
        };

        public static readonly Block JungleFence = new Block(190, 0)
        {
            Name = "JungleFence",
            TextType = "jungle_fence"
        };

        public static readonly Block DarkOakFence = new Block(191, 0)
        {
            Name = "DarkOakFence",
            TextType = "dark_oak_fence"
        };

        public static readonly Block AcaciaFence = new Block(192, 0)
        {
            Name = "AcaciaFence",
            TextType = "acacia_fence"
        };

        public static readonly Block SpruceDoorBlock = new Block(193, 0)
        {
            Name = "SpruceDoorBlock",
            TextType = "spruce_door"
        };

        public static readonly Block BirchDoorBlock = new Block(194, 0)
        {
            Name = "BirchDoorBlock",
            TextType = "birch_door"
        };

        public static readonly Block JungleDoorBlock = new Block(195, 0)
        {
            Name = "JungleDoorBlock",
            TextType = "jungle_door"
        };

        public static readonly Block AcaciaDoorBlock = new Block(196, 0)
        {
            Name = "AcaciaDoorBlock",
            TextType = "acacia_door"
        };

        public static readonly Block DarkOakDoorBlock = new Block(197, 0)
        {
            Name = "DarkOakDoorBlock",
            TextType = "dark_oak_door"
        };

        public static readonly Block EndRod = new Block(198, 0)
        {
            Name = "EndRod",
            TextType = "end_rod"
        };

        public static readonly Block ChorusPlant = new Block(199, 0)
        {
            Name = "ChorusPlant",
            TextType = "chorus_plant"
        };

        public static readonly Block ChorusFlower = new Block(200, 0)
        {
            Name = "ChorusFlower",
            TextType = "chorus_flower"
        };

        public static readonly Block PurpurBlock = new Block(201, 0)
        {
            Name = "PurpurBlock",
            TextType = "purpur_block"
        };

        public static readonly Block PurpurPillar = new Block(202, 0)
        {
            Name = "PurpurPillar",
            TextType = "purpur_pillar"
        };

        public static readonly Block PurpurStairs = new Block(203, 0)
        {
            Name = "PurpurStairs",
            TextType = "purpur_stairs"
        };

        public static readonly Block PurpurDoubleSlab = new Block(204, 0)
        {
            Name = "PurpurDoubleSlab",
            TextType = "purpur_double_slab"
        };

        public static readonly Block PurpurSlab = new Block(205, 0)
        {
            Name = "PurpurSlab",
            TextType = "purpur_slab"
        };

        public static readonly Block EndStoneBricks = new Block(206, 0)
        {
            Name = "EndStoneBricks",
            TextType = "end_bricks"
        };

        public static readonly Block BeetrootBlock = new Block(207, 0)
        {
            Name = "BeetrootBlock",
            TextType = "beetroots"
        };

        public static readonly Block GrassPath = new Block(208, 0)
        {
            Name = "GrassPath",
            TextType = "grass_path"
        };

        public static readonly Block EndGateway = new Block(209, 0)
        {
            Name = "EndGateway",
            TextType = "end_gateway"
        };

        public static readonly Block RepeatingCommandBlock = new Block(210, 0)
        {
            Name = "RepeatingCommandBlock",
            TextType = "repeating_command_block"
        };

        public static readonly Block ChainCommandBlock = new Block(211, 0)
        {
            Name = "ChainCommandBlock",
            TextType = "chain_command_block"
        };

        public static readonly Block FrostedIce = new Block(212, 0)
        {
            Name = "FrostedIce",
            TextType = "frosted_ice"
        };

        public static readonly Block MagmaBlock = new Block(213, 0)
        {
            Name = "MagmaBlock",
            TextType = "magma"
        };

        public static readonly Block NetherWartBlock = new Block(214, 0)
        {
            Name = "NetherWartBlock",
            TextType = "nether_wart_block"
        };

        public static readonly Block RedNetherBrick = new Block(215, 0)
        {
            Name = "RedNetherBrick",
            TextType = "red_nether_brick"
        };

        public static readonly Block BoneBlock = new Block(216, 0)
        {
            Name = "BoneBlock",
            TextType = "bone_block"
        };

        public static readonly Block StructureVoid = new Block(217, 0)
        {
            Name = "StructureVoid",
            TextType = "structure_void"
        };

        public static readonly Block Observer = new Block(218, 0)
        {
            Name = "Observer",
            TextType = "observer"
        };

        public static readonly Block WhiteShulkerBox = new Block(219, 0)
        {
            Name = "WhiteShulkerBox",
            TextType = "white_shulker_box"
        };

        public static readonly Block OrangeShulkerBox = new Block(220, 0)
        {
            Name = "OrangeShulkerBox",
            TextType = "orange_shulker_box"
        };

        public static readonly Block MagentaShulkerBox = new Block(221, 0)
        {
            Name = "MagentaShulkerBox",
            TextType = "magenta_shulker_box"
        };

        public static readonly Block LightBlueShulkerBox = new Block(222, 0)
        {
            Name = "LightBlueShulkerBox",
            TextType = "light_blue_shulker_box"
        };

        public static readonly Block YellowShulkerBox = new Block(223, 0)
        {
            Name = "YellowShulkerBox",
            TextType = "yellow_shulker_box"
        };

        public static readonly Block LimeShulkerBox = new Block(224, 0)
        {
            Name = "LimeShulkerBox",
            TextType = "lime_shulker_box"
        };

        public static readonly Block PinkShulkerBox = new Block(225, 0)
        {
            Name = "PinkShulkerBox",
            TextType = "pink_shulker_box"
        };

        public static readonly Block GrayShulkerBox = new Block(226, 0)
        {
            Name = "GrayShulkerBox",
            TextType = "gray_shulker_box"
        };

        public static readonly Block LightGrayShulkerBox = new Block(227, 0)
        {
            Name = "LightGrayShulkerBox",
            TextType = "silver_shulker_box"
        };

        public static readonly Block CyanShulkerBox = new Block(228, 0)
        {
            Name = "CyanShulkerBox",
            TextType = "cyan_shulker_box"
        };

        public static readonly Block PurpleShulkerBox = new Block(229, 0)
        {
            Name = "PurpleShulkerBox",
            TextType = "purple_shulker_box"
        };

        public static readonly Block BlueShulkerBox = new Block(230, 0)
        {
            Name = "BlueShulkerBox",
            TextType = "blue_shulker_box"
        };

        public static readonly Block BrownShulkerBox = new Block(231, 0)
        {
            Name = "BrownShulkerBox",
            TextType = "brown_shulker_box"
        };

        public static readonly Block GreenShulkerBox = new Block(232, 0)
        {
            Name = "GreenShulkerBox",
            TextType = "green_shulker_box"
        };

        public static readonly Block RedShulkerBox = new Block(233, 0)
        {
            Name = "RedShulkerBox",
            TextType = "red_shulker_box"
        };

        public static readonly Block BlackShulkerBox = new Block(234, 0)
        {
            Name = "BlackShulkerBox",
            TextType = "black_shulker_box"
        };

        public static readonly Block WhiteGlazedTerracotta = new Block(235, 0)
        {
            Name = "WhiteGlazedTerracotta",
            TextType = "white_glazed_terracotta"
        };

        public static readonly Block OrangeGlazedTerracotta = new Block(236, 0)
        {
            Name = "OrangeGlazedTerracotta",
            TextType = "orange_glazed_terracotta"
        };

        public static readonly Block MagentaGlazedTerracotta = new Block(237, 0)
        {
            Name = "MagentaGlazedTerracotta",
            TextType = "magenta_glazed_terracotta"
        };

        public static readonly Block LightBlueGlazedTerracotta = new Block(238, 0)
        {
            Name = "LightBlueGlazedTerracotta",
            TextType = "light_blue_glazed_terracotta"
        };

        public static readonly Block YellowGlazedTerracotta = new Block(239, 0)
        {
            Name = "YellowGlazedTerracotta",
            TextType = "yellow_glazed_terracotta"
        };

        public static readonly Block LimeGlazedTerracotta = new Block(240, 0)
        {
            Name = "LimeGlazedTerracotta",
            TextType = "lime_glazed_terracotta"
        };

        public static readonly Block PinkGlazedTerracotta = new Block(241, 0)
        {
            Name = "PinkGlazedTerracotta",
            TextType = "pink_glazed_terracotta"
        };

        public static readonly Block GrayGlazedTerracotta = new Block(242, 0)
        {
            Name = "GrayGlazedTerracotta",
            TextType = "gray_glazed_terracotta"
        };

        public static readonly Block LightGrayGlazedTerracotta = new Block(243, 0)
        {
            Name = "LightGrayGlazedTerracotta",
            TextType = "light_gray_glazed_terracotta"
        };

        public static readonly Block CyanGlazedTerracotta = new Block(244, 0)
        {
            Name = "CyanGlazedTerracotta",
            TextType = "cyan_glazed_terracotta"
        };

        public static readonly Block PurpleGlazedTerracotta = new Block(245, 0)
        {
            Name = "PurpleGlazedTerracotta",
            TextType = "purple_glazed_terracotta"
        };

        public static readonly Block BlueGlazedTerracotta = new Block(246, 0)
        {
            Name = "BlueGlazedTerracotta",
            TextType = "blue_glazed_terracotta"
        };

        public static readonly Block BrownGlazedTerracotta = new Block(247, 0)
        {
            Name = "BrownGlazedTerracotta",
            TextType = "brown_glazed_terracotta"
        };

        public static readonly Block GreenGlazedTerracotta = new Block(248, 0)
        {
            Name = "GreenGlazedTerracotta",
            TextType = "green_glazed_terracotta"
        };

        public static readonly Block RedGlazedTerracotta = new Block(249, 0)
        {
            Name = "RedGlazedTerracotta",
            TextType = "red_glazed_terracotta"
        };

        public static readonly Block BlackGlazedTerracotta = new Block(250, 0)
        {
            Name = "BlackGlazedTerracotta",
            TextType = "black_glazed_terracotta"
        };

        public static readonly Block WhiteConcrete = new Block(251, 0)
        {
            Name = "WhiteConcrete",
            TextType = "concrete"
        };

        public static readonly Block OrangeConcrete = new Block(251, 1)
        {
            Name = "OrangeConcrete",
            TextType = "concrete"
        };

        public static readonly Block MagentaConcrete = new Block(251, 2)
        {
            Name = "MagentaConcrete",
            TextType = "concrete"
        };

        public static readonly Block LightBlueConcrete = new Block(251, 3)
        {
            Name = "LightBlueConcrete",
            TextType = "concrete"
        };

        public static readonly Block YellowConcrete = new Block(251, 4)
        {
            Name = "YellowConcrete",
            TextType = "concrete"
        };

        public static readonly Block LimeConcrete = new Block(251, 5)
        {
            Name = "LimeConcrete",
            TextType = "concrete"
        };

        public static readonly Block PinkConcrete = new Block(251, 6)
        {
            Name = "PinkConcrete",
            TextType = "concrete"
        };

        public static readonly Block GrayConcrete = new Block(251, 7)
        {
            Name = "GrayConcrete",
            TextType = "concrete"
        };

        public static readonly Block LightGrayConcrete = new Block(251, 8)
        {
            Name = "LightGrayConcrete",
            TextType = "concrete"
        };

        public static readonly Block CyanConcrete = new Block(251, 9)
        {
            Name = "CyanConcrete",
            TextType = "concrete"
        };

        public static readonly Block PurpleConcrete = new Block(251, 10)
        {
            Name = "PurpleConcrete",
            TextType = "concrete"
        };

        public static readonly Block BlueConcrete = new Block(251, 11)
        {
            Name = "BlueConcrete",
            TextType = "concrete"
        };

        public static readonly Block BrownConcrete = new Block(251, 12)
        {
            Name = "BrownConcrete",
            TextType = "concrete"
        };

        public static readonly Block GreenConcrete = new Block(251, 13)
        {
            Name = "GreenConcrete",
            TextType = "concrete"
        };

        public static readonly Block RedConcrete = new Block(251, 14)
        {
            Name = "RedConcrete",
            TextType = "concrete"
        };

        public static readonly Block BlackConcrete = new Block(251, 15)
        {
            Name = "BlackConcrete",
            TextType = "concrete"
        };

        public static readonly Block WhiteConcretePowder = new Block(252, 0)
        {
            Name = "WhiteConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block OrangeConcretePowder = new Block(252, 1)
        {
            Name = "OrangeConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block MagentaConcretePowder = new Block(252, 2)
        {
            Name = "MagentaConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block LightBlueConcretePowder = new Block(252, 3)
        {
            Name = "LightBlueConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block YellowConcretePowder = new Block(252, 4)
        {
            Name = "YellowConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block LimeConcretePowder = new Block(252, 5)
        {
            Name = "LimeConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block PinkConcretePowder = new Block(252, 6)
        {
            Name = "PinkConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block GrayConcretePowder = new Block(252, 7)
        {
            Name = "GrayConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block LightGrayConcretePowder = new Block(252, 8)
        {
            Name = "LightGrayConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block CyanConcretePowder = new Block(252, 9)
        {
            Name = "CyanConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block PurpleConcretePowder = new Block(252, 10)
        {
            Name = "PurpleConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block BlueConcretePowder = new Block(252, 11)
        {
            Name = "BlueConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block BrownConcretePowder = new Block(252, 12)
        {
            Name = "BrownConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block GreenConcretePowder = new Block(252, 13)
        {
            Name = "GreenConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block RedConcretePowder = new Block(252, 14)
        {
            Name = "RedConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block BlackConcretePowder = new Block(252, 15)
        {
            Name = "BlackConcretePowder",
            TextType = "concrete_powder"
        };

        public static readonly Block StructureBlock = new Block(255, 0)
        {
            Name = "StructureBlock",
            TextType = "structure_block"
        };

        public static readonly Block IronShovel = new Block(256, 0)
        {
            Name = "IronShovel",
            TextType = "iron_shovel"
        };

        public static readonly Block IronPickaxe = new Block(257, 0)
        {
            Name = "IronPickaxe",
            TextType = "iron_pickaxe"
        };

        public static readonly Block IronAxe = new Block(258, 0)
        {
            Name = "IronAxe",
            TextType = "iron_axe"
        };

        public static readonly Block FlintandSteel = new Block(259, 0)
        {
            Name = "FlintandSteel",
            TextType = "flint_and_steel"
        };

        public static readonly Block Apple = new Block(260, 0)
        {
            Name = "Apple",
            TextType = "apple"
        };

        public static readonly Block Bow = new Block(261, 0)
        {
            Name = "Bow",
            TextType = "bow"
        };

        public static readonly Block Arrow = new Block(262, 0)
        {
            Name = "Arrow",
            TextType = "arrow"
        };

        public static readonly Block Coal = new Block(263, 0)
        {
            Name = "Coal",
            TextType = "coal"
        };

        public static readonly Block Charcoal = new Block(263, 1)
        {
            Name = "Charcoal",
            TextType = "coal"
        };

        public static readonly Block Diamond = new Block(264, 0)
        {
            Name = "Diamond",
            TextType = "diamond"
        };

        public static readonly Block IronIngot = new Block(265, 0)
        {
            Name = "IronIngot",
            TextType = "iron_ingot"
        };

        public static readonly Block GoldIngot = new Block(266, 0)
        {
            Name = "GoldIngot",
            TextType = "gold_ingot"
        };

        public static readonly Block IronSword = new Block(267, 0)
        {
            Name = "IronSword",
            TextType = "iron_sword"
        };

        public static readonly Block WoodenSword = new Block(268, 0)
        {
            Name = "WoodenSword",
            TextType = "wooden_sword"
        };

        public static readonly Block WoodenShovel = new Block(269, 0)
        {
            Name = "WoodenShovel",
            TextType = "wooden_shovel"
        };

        public static readonly Block WoodenPickaxe = new Block(270, 0)
        {
            Name = "WoodenPickaxe",
            TextType = "wooden_pickaxe"
        };

        public static readonly Block WoodenAxe = new Block(271, 0)
        {
            Name = "WoodenAxe",
            TextType = "wooden_axe"
        };

        public static readonly Block StoneSword = new Block(272, 0)
        {
            Name = "StoneSword",
            TextType = "stone_sword"
        };

        public static readonly Block StoneShovel = new Block(273, 0)
        {
            Name = "StoneShovel",
            TextType = "stone_shovel"
        };

        public static readonly Block StonePickaxe = new Block(274, 0)
        {
            Name = "StonePickaxe",
            TextType = "stone_pickaxe"
        };

        public static readonly Block StoneAxe = new Block(275, 0)
        {
            Name = "StoneAxe",
            TextType = "stone_axe"
        };

        public static readonly Block DiamondSword = new Block(276, 0)
        {
            Name = "DiamondSword",
            TextType = "diamond_sword"
        };

        public static readonly Block DiamondShovel = new Block(277, 0)
        {
            Name = "DiamondShovel",
            TextType = "diamond_shovel"
        };

        public static readonly Block DiamondPickaxe = new Block(278, 0)
        {
            Name = "DiamondPickaxe",
            TextType = "diamond_pickaxe"
        };

        public static readonly Block DiamondAxe = new Block(279, 0)
        {
            Name = "DiamondAxe",
            TextType = "diamond_axe"
        };

        public static readonly Block Stick = new Block(280, 0)
        {
            Name = "Stick",
            TextType = "stick"
        };

        public static readonly Block Bowl = new Block(281, 0)
        {
            Name = "Bowl",
            TextType = "bowl"
        };

        public static readonly Block MushroomStew = new Block(282, 0)
        {
            Name = "MushroomStew",
            TextType = "mushroom_stew"
        };

        public static readonly Block GoldenSword = new Block(283, 0)
        {
            Name = "GoldenSword",
            TextType = "golden_sword"
        };

        public static readonly Block GoldenShovel = new Block(284, 0)
        {
            Name = "GoldenShovel",
            TextType = "golden_shovel"
        };

        public static readonly Block GoldenPickaxe = new Block(285, 0)
        {
            Name = "GoldenPickaxe",
            TextType = "golden_pickaxe"
        };

        public static readonly Block GoldenAxe = new Block(286, 0)
        {
            Name = "GoldenAxe",
            TextType = "golden_axe"
        };

        public static readonly Block String = new Block(287, 0)
        {
            Name = "String",
            TextType = "string"
        };

        public static readonly Block Feather = new Block(288, 0)
        {
            Name = "Feather",
            TextType = "feather"
        };

        public static readonly Block Gunpowder = new Block(289, 0)
        {
            Name = "Gunpowder",
            TextType = "gunpowder"
        };

        public static readonly Block WoodenHoe = new Block(290, 0)
        {
            Name = "WoodenHoe",
            TextType = "wooden_hoe"
        };

        public static readonly Block StoneHoe = new Block(291, 0)
        {
            Name = "StoneHoe",
            TextType = "stone_hoe"
        };

        public static readonly Block IronHoe = new Block(292, 0)
        {
            Name = "IronHoe",
            TextType = "iron_hoe"
        };

        public static readonly Block DiamondHoe = new Block(293, 0)
        {
            Name = "DiamondHoe",
            TextType = "diamond_hoe"
        };

        public static readonly Block GoldenHoe = new Block(294, 0)
        {
            Name = "GoldenHoe",
            TextType = "golden_hoe"
        };

        public static readonly Block WheatSeeds = new Block(295, 0)
        {
            Name = "WheatSeeds",
            TextType = "wheat_seeds"
        };

        public static readonly Block Wheat = new Block(296, 0)
        {
            Name = "Wheat",
            TextType = "wheat"
        };

        public static readonly Block Bread = new Block(297, 0)
        {
            Name = "Bread",
            TextType = "bread"
        };

        public static readonly Block LeatherHelmet = new Block(298, 0)
        {
            Name = "LeatherHelmet",
            TextType = "leather_helmet"
        };

        public static readonly Block LeatherTunic = new Block(299, 0)
        {
            Name = "LeatherTunic",
            TextType = "leather_chestplate"
        };

        public static readonly Block LeatherPants = new Block(300, 0)
        {
            Name = "LeatherPants",
            TextType = "leather_leggings"
        };

        public static readonly Block LeatherBoots = new Block(301, 0)
        {
            Name = "LeatherBoots",
            TextType = "leather_boots"
        };

        public static readonly Block ChainmailHelmet = new Block(302, 0)
        {
            Name = "ChainmailHelmet",
            TextType = "chainmail_helmet"
        };

        public static readonly Block ChainmailChestplate = new Block(303, 0)
        {
            Name = "ChainmailChestplate",
            TextType = "chainmail_chestplate"
        };

        public static readonly Block ChainmailLeggings = new Block(304, 0)
        {
            Name = "ChainmailLeggings",
            TextType = "chainmail_leggings"
        };

        public static readonly Block ChainmailBoots = new Block(305, 0)
        {
            Name = "ChainmailBoots",
            TextType = "chainmail_boots"
        };

        public static readonly Block IronHelmet = new Block(306, 0)
        {
            Name = "IronHelmet",
            TextType = "iron_helmet"
        };

        public static readonly Block IronChestplate = new Block(307, 0)
        {
            Name = "IronChestplate",
            TextType = "iron_chestplate"
        };

        public static readonly Block IronLeggings = new Block(308, 0)
        {
            Name = "IronLeggings",
            TextType = "iron_leggings"
        };

        public static readonly Block IronBoots = new Block(309, 0)
        {
            Name = "IronBoots",
            TextType = "iron_boots"
        };

        public static readonly Block DiamondHelmet = new Block(310, 0)
        {
            Name = "DiamondHelmet",
            TextType = "diamond_helmet"
        };

        public static readonly Block DiamondChestplate = new Block(311, 0)
        {
            Name = "DiamondChestplate",
            TextType = "diamond_chestplate"
        };

        public static readonly Block DiamondLeggings = new Block(312, 0)
        {
            Name = "DiamondLeggings",
            TextType = "diamond_leggings"
        };

        public static readonly Block DiamondBoots = new Block(313, 0)
        {
            Name = "DiamondBoots",
            TextType = "diamond_boots"
        };

        public static readonly Block GoldenHelmet = new Block(314, 0)
        {
            Name = "GoldenHelmet",
            TextType = "golden_helmet"
        };

        public static readonly Block GoldenChestplate = new Block(315, 0)
        {
            Name = "GoldenChestplate",
            TextType = "golden_chestplate"
        };

        public static readonly Block GoldenLeggings = new Block(316, 0)
        {
            Name = "GoldenLeggings",
            TextType = "golden_leggings"
        };

        public static readonly Block GoldenBoots = new Block(317, 0)
        {
            Name = "GoldenBoots",
            TextType = "golden_boots"
        };

        public static readonly Block Flint = new Block(318, 0)
        {
            Name = "Flint",
            TextType = "flint"
        };

        public static readonly Block RawPorkchop = new Block(319, 0)
        {
            Name = "RawPorkchop",
            TextType = "porkchop"
        };

        public static readonly Block CookedPorkchop = new Block(320, 0)
        {
            Name = "CookedPorkchop",
            TextType = "cooked_porkchop"
        };

        public static readonly Block Painting = new Block(321, 0)
        {
            Name = "Painting",
            TextType = "painting"
        };

        public static readonly Block GoldenApple = new Block(322, 0)
        {
            Name = "GoldenApple",
            TextType = "golden_apple"
        };

        public static readonly Block EnchantedGoldenApple = new Block(322, 1)
        {
            Name = "EnchantedGoldenApple",
            TextType = "golden_apple"
        };

        public static readonly Block Sign = new Block(323, 0)
        {
            Name = "Sign",
            TextType = "sign"
        };

        public static readonly Block OakDoor = new Block(324, 0)
        {
            Name = "OakDoor",
            TextType = "wooden_door"
        };

        public static readonly Block Bucket = new Block(325, 0)
        {
            Name = "Bucket",
            TextType = "bucket"
        };

        public static readonly Block WaterBucket = new Block(326, 0)
        {
            Name = "WaterBucket",
            TextType = "water_bucket"
        };

        public static readonly Block LavaBucket = new Block(327, 0)
        {
            Name = "LavaBucket",
            TextType = "lava_bucket"
        };

        public static readonly Block Minecart = new Block(328, 0)
        {
            Name = "Minecart",
            TextType = "minecart"
        };

        public static readonly Block Saddle = new Block(329, 0)
        {
            Name = "Saddle",
            TextType = "saddle"
        };

        public static readonly Block IronDoor = new Block(330, 0)
        {
            Name = "IronDoor",
            TextType = "iron_door"
        };

        public static readonly Block Redstone = new Block(331, 0)
        {
            Name = "Redstone",
            TextType = "redstone"
        };

        public static readonly Block Snowball = new Block(332, 0)
        {
            Name = "Snowball",
            TextType = "snowball"
        };

        public static readonly Block OakBoat = new Block(333, 0)
        {
            Name = "OakBoat",
            TextType = "boat"
        };

        public static readonly Block Leather = new Block(334, 0)
        {
            Name = "Leather",
            TextType = "leather"
        };

        public static readonly Block MilkBucket = new Block(335, 0)
        {
            Name = "MilkBucket",
            TextType = "milk_bucket"
        };

        public static readonly Block Brick = new Block(336, 0)
        {
            Name = "Brick",
            TextType = "brick"
        };

        public static readonly Block Clay = new Block(337, 0)
        {
            Name = "Clay",
            TextType = "clay_ball"
        };

        public static readonly Block SugarCanes = new Block(338, 0)
        {
            Name = "SugarCanes",
            TextType = "reeds"
        };

        public static readonly Block Paper = new Block(339, 0)
        {
            Name = "Paper",
            TextType = "paper"
        };

        public static readonly Block Book = new Block(340, 0)
        {
            Name = "Book",
            TextType = "book"
        };

        public static readonly Block Slimeball = new Block(341, 0)
        {
            Name = "Slimeball",
            TextType = "slime_ball"
        };

        public static readonly Block MinecartwithChest = new Block(342, 0)
        {
            Name = "MinecartwithChest",
            TextType = "chest_minecart"
        };

        public static readonly Block MinecartwithFurnace = new Block(343, 0)
        {
            Name = "MinecartwithFurnace",
            TextType = "furnace_minecart"
        };

        public static readonly Block Egg = new Block(344, 0)
        {
            Name = "Egg",
            TextType = "egg"
        };

        public static readonly Block Compass = new Block(345, 0)
        {
            Name = "Compass",
            TextType = "compass"
        };

        public static readonly Block FishingRod = new Block(346, 0)
        {
            Name = "FishingRod",
            TextType = "fishing_rod"
        };

        public static readonly Block Clock = new Block(347, 0)
        {
            Name = "Clock",
            TextType = "clock"
        };

        public static readonly Block GlowstoneDust = new Block(348, 0)
        {
            Name = "GlowstoneDust",
            TextType = "glowstone_dust"
        };

        public static readonly Block RawFish = new Block(349, 0)
        {
            Name = "RawFish",
            TextType = "fish"
        };

        public static readonly Block RawSalmon = new Block(349, 1)
        {
            Name = "RawSalmon",
            TextType = "fish"
        };

        public static readonly Block Clownfish = new Block(349, 2)
        {
            Name = "Clownfish",
            TextType = "fish"
        };

        public static readonly Block Pufferfish = new Block(349, 3)
        {
            Name = "Pufferfish",
            TextType = "fish"
        };

        public static readonly Block CookedFish = new Block(350, 0)
        {
            Name = "CookedFish",
            TextType = "cooked_fish"
        };

        public static readonly Block CookedSalmon = new Block(350, 1)
        {
            Name = "CookedSalmon",
            TextType = "cooked_fish"
        };

        public static readonly Block InkSack = new Block(351, 0)
        {
            Name = "InkSack",
            TextType = "dye"
        };

        public static readonly Block RoseRed = new Block(351, 1)
        {
            Name = "RoseRed",
            TextType = "dye"
        };

        public static readonly Block CactusGreen = new Block(351, 2)
        {
            Name = "CactusGreen",
            TextType = "dye"
        };

        public static readonly Block CocoBeans = new Block(351, 3)
        {
            Name = "CocoBeans",
            TextType = "dye"
        };

        public static readonly Block LapisLazuli = new Block(351, 4)
        {
            Name = "LapisLazuli",
            TextType = "dye"
        };

        public static readonly Block PurpleDye = new Block(351, 5)
        {
            Name = "PurpleDye",
            TextType = "dye"
        };

        public static readonly Block CyanDye = new Block(351, 6)
        {
            Name = "CyanDye",
            TextType = "dye"
        };

        public static readonly Block LightGrayDye = new Block(351, 7)
        {
            Name = "LightGrayDye",
            TextType = "dye"
        };

        public static readonly Block GrayDye = new Block(351, 8)
        {
            Name = "GrayDye",
            TextType = "dye"
        };

        public static readonly Block PinkDye = new Block(351, 9)
        {
            Name = "PinkDye",
            TextType = "dye"
        };

        public static readonly Block LimeDye = new Block(351, 10)
        {
            Name = "LimeDye",
            TextType = "dye"
        };

        public static readonly Block DandelionYellow = new Block(351, 11)
        {
            Name = "DandelionYellow",
            TextType = "dye"
        };

        public static readonly Block LightBlueDye = new Block(351, 12)
        {
            Name = "LightBlueDye",
            TextType = "dye"
        };

        public static readonly Block MagentaDye = new Block(351, 13)
        {
            Name = "MagentaDye",
            TextType = "dye"
        };

        public static readonly Block OrangeDye = new Block(351, 14)
        {
            Name = "OrangeDye",
            TextType = "dye"
        };

        public static readonly Block BoneMeal = new Block(351, 15)
        {
            Name = "BoneMeal",
            TextType = "dye"
        };

        public static readonly Block Bone = new Block(352, 0)
        {
            Name = "Bone",
            TextType = "bone"
        };

        public static readonly Block Sugar = new Block(353, 0)
        {
            Name = "Sugar",
            TextType = "sugar"
        };

        public static readonly Block Cake = new Block(354, 0)
        {
            Name = "Cake",
            TextType = "cake"
        };

        public static readonly Block Bed = new Block(355, 0)
        {
            Name = "Bed",
            TextType = "bed"
        };

        public static readonly Block RedstoneRepeater = new Block(356, 0)
        {
            Name = "RedstoneRepeater",
            TextType = "repeater"
        };

        public static readonly Block Cookie = new Block(357, 0)
        {
            Name = "Cookie",
            TextType = "cookie"
        };

        public static readonly Block Map = new Block(358, 0)
        {
            Name = "Map",
            TextType = "filled_map"
        };

        public static readonly Block Shears = new Block(359, 0)
        {
            Name = "Shears",
            TextType = "shears"
        };

        public static readonly Block Melon = new Block(360, 0)
        {
            Name = "Melon",
            TextType = "melon"
        };

        public static readonly Block PumpkinSeeds = new Block(361, 0)
        {
            Name = "PumpkinSeeds",
            TextType = "pumpkin_seeds"
        };

        public static readonly Block MelonSeeds = new Block(362, 0)
        {
            Name = "MelonSeeds",
            TextType = "melon_seeds"
        };

        public static readonly Block RawBeef = new Block(363, 0)
        {
            Name = "RawBeef",
            TextType = "beef"
        };

        public static readonly Block Steak = new Block(364, 0)
        {
            Name = "Steak",
            TextType = "cooked_beef"
        };

        public static readonly Block RawChicken = new Block(365, 0)
        {
            Name = "RawChicken",
            TextType = "chicken"
        };

        public static readonly Block CookedChicken = new Block(366, 0)
        {
            Name = "CookedChicken",
            TextType = "cooked_chicken"
        };

        public static readonly Block RottenFlesh = new Block(367, 0)
        {
            Name = "RottenFlesh",
            TextType = "rotten_flesh"
        };

        public static readonly Block EnderPearl = new Block(368, 0)
        {
            Name = "EnderPearl",
            TextType = "ender_pearl"
        };

        public static readonly Block BlazeRod = new Block(369, 0)
        {
            Name = "BlazeRod",
            TextType = "blaze_rod"
        };

        public static readonly Block GhastTear = new Block(370, 0)
        {
            Name = "GhastTear",
            TextType = "ghast_tear"
        };

        public static readonly Block GoldNugget = new Block(371, 0)
        {
            Name = "GoldNugget",
            TextType = "gold_nugget"
        };

        public static readonly Block NetherWart = new Block(372, 0)
        {
            Name = "NetherWart",
            TextType = "nether_wart"
        };

        public static readonly Block Potion = new Block(373, 0)
        {
            Name = "Potion",
            TextType = "potion"
        };

        public static readonly Block GlassBottle = new Block(374, 0)
        {
            Name = "GlassBottle",
            TextType = "glass_bottle"
        };

        public static readonly Block SpiderEye = new Block(375, 0)
        {
            Name = "SpiderEye",
            TextType = "spider_eye"
        };

        public static readonly Block FermentedSpiderEye = new Block(376, 0)
        {
            Name = "FermentedSpiderEye",
            TextType = "fermented_spider_eye"
        };

        public static readonly Block BlazePowder = new Block(377, 0)
        {
            Name = "BlazePowder",
            TextType = "blaze_powder"
        };

        public static readonly Block MagmaCream = new Block(378, 0)
        {
            Name = "MagmaCream",
            TextType = "magma_cream"
        };

        public static readonly Block BrewingStand = new Block(379, 0)
        {
            Name = "BrewingStand",
            TextType = "brewing_stand"
        };

        public static readonly Block Cauldron = new Block(380, 0)
        {
            Name = "Cauldron",
            TextType = "cauldron"
        };

        public static readonly Block EyeofEnder = new Block(381, 0)
        {
            Name = "EyeofEnder",
            TextType = "ender_eye"
        };

        public static readonly Block GlisteringMelon = new Block(382, 0)
        {
            Name = "GlisteringMelon",
            TextType = "speckled_melon"
        };

        public static readonly Block SpawnElderGuardian = new Block(383, 4)
        {
            Name = "SpawnElderGuardian",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnWitherSkeleton = new Block(383, 5)
        {
            Name = "SpawnWitherSkeleton",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnStray = new Block(383, 6)
        {
            Name = "SpawnStray",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnHusk = new Block(383, 23)
        {
            Name = "SpawnHusk",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnZombieVillager = new Block(383, 27)
        {
            Name = "SpawnZombieVillager",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnSkeletonHorse = new Block(383, 28)
        {
            Name = "SpawnSkeletonHorse",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnZombieHorse = new Block(383, 29)
        {
            Name = "SpawnZombieHorse",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnDonkey = new Block(383, 31)
        {
            Name = "SpawnDonkey",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnMule = new Block(383, 32)
        {
            Name = "SpawnMule",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnEvoker = new Block(383, 34)
        {
            Name = "SpawnEvoker",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnVex = new Block(383, 35)
        {
            Name = "SpawnVex",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnVindicator = new Block(383, 36)
        {
            Name = "SpawnVindicator",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnCreeper = new Block(383, 50)
        {
            Name = "SpawnCreeper",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnSkeleton = new Block(383, 51)
        {
            Name = "SpawnSkeleton",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnSpider = new Block(383, 52)
        {
            Name = "SpawnSpider",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnZombie = new Block(383, 54)
        {
            Name = "SpawnZombie",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnSlime = new Block(383, 55)
        {
            Name = "SpawnSlime",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnGhast = new Block(383, 56)
        {
            Name = "SpawnGhast",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnZombiePigman = new Block(383, 57)
        {
            Name = "SpawnZombiePigman",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnEnderman = new Block(383, 58)
        {
            Name = "SpawnEnderman",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnCaveSpider = new Block(383, 59)
        {
            Name = "SpawnCaveSpider",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnSilverfish = new Block(383, 60)
        {
            Name = "SpawnSilverfish",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnBlaze = new Block(383, 61)
        {
            Name = "SpawnBlaze",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnMagmaCube = new Block(383, 62)
        {
            Name = "SpawnMagmaCube",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnBat = new Block(383, 65)
        {
            Name = "SpawnBat",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnWitch = new Block(383, 66)
        {
            Name = "SpawnWitch",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnEndermite = new Block(383, 67)
        {
            Name = "SpawnEndermite",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnGuardian = new Block(383, 68)
        {
            Name = "SpawnGuardian",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnShulker = new Block(383, 69)
        {
            Name = "SpawnShulker",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnPig = new Block(383, 90)
        {
            Name = "SpawnPig",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnSheep = new Block(383, 91)
        {
            Name = "SpawnSheep",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnCow = new Block(383, 92)
        {
            Name = "SpawnCow",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnChicken = new Block(383, 93)
        {
            Name = "SpawnChicken",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnSquid = new Block(383, 94)
        {
            Name = "SpawnSquid",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnWolf = new Block(383, 95)
        {
            Name = "SpawnWolf",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnMooshroom = new Block(383, 96)
        {
            Name = "SpawnMooshroom",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnOcelot = new Block(383, 98)
        {
            Name = "SpawnOcelot",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnHorse = new Block(383, 100)
        {
            Name = "SpawnHorse",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnRabbit = new Block(383, 101)
        {
            Name = "SpawnRabbit",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnPolarBear = new Block(383, 102)
        {
            Name = "SpawnPolarBear",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnLlama = new Block(383, 103)
        {
            Name = "SpawnLlama",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnParrot = new Block(383, 105)
        {
            Name = "SpawnParrot",
            TextType = "spawn_egg"
        };

        public static readonly Block SpawnVillager = new Block(383, 120)
        {
            Name = "SpawnVillager",
            TextType = "spawn_egg"
        };

        public static readonly Block BottleOEnchanting = new Block(384, 0)
        {
            Name = "Bottleo'Enchanting",
            TextType = "experience_bottle"
        };

        public static readonly Block FireCharge = new Block(385, 0)
        {
            Name = "FireCharge",
            TextType = "fire_charge"
        };

        public static readonly Block BookandQuill = new Block(386, 0)
        {
            Name = "BookandQuill",
            TextType = "writable_book"
        };

        public static readonly Block WrittenBook = new Block(387, 0)
        {
            Name = "WrittenBook",
            TextType = "written_book"
        };

        public static readonly Block Emerald = new Block(388, 0)
        {
            Name = "Emerald",
            TextType = "emerald"
        };

        public static readonly Block ItemFrame = new Block(389, 0)
        {
            Name = "ItemFrame",
            TextType = "item_frame"
        };

        public static readonly Block FlowerPot = new Block(390, 0)
        {
            Name = "FlowerPot",
            TextType = "flower_pot"
        };

        public static readonly Block Carrot = new Block(391, 0)
        {
            Name = "Carrot",
            TextType = "carrot"
        };

        public static readonly Block Potato = new Block(392, 0)
        {
            Name = "Potato",
            TextType = "potato"
        };

        public static readonly Block BakedPotato = new Block(393, 0)
        {
            Name = "BakedPotato",
            TextType = "baked_potato"
        };

        public static readonly Block PoisonousPotato = new Block(394, 0)
        {
            Name = "PoisonousPotato",
            TextType = "poisonous_potato"
        };

        public static readonly Block EmptyMap = new Block(395, 0)
        {
            Name = "EmptyMap",
            TextType = "map"
        };

        public static readonly Block GoldenCarrot = new Block(396, 0)
        {
            Name = "GoldenCarrot",
            TextType = "golden_carrot"
        };

        public static readonly Block MobHeadSkeleton = new Block(397, 0)
        {
            Name = "MobHead(Skeleton)",
            TextType = "skull"
        };

        public static readonly Block MobHeadWither = new Block(397, 1)
        {
            Name = "MobHead(WitherSkeleton)",
            TextType = "skull"
        };

        public static readonly Block MobHeadZombie = new Block(397, 2)
        {
            Name = "MobHead(Zombie)",
            TextType = "skull"
        };

        public static readonly Block MobHeadHuman = new Block(397, 3)
        {
            Name = "MobHead(Human)",
            TextType = "skull"
        };

        public static readonly Block MobHeadCreeper = new Block(397, 4)
        {
            Name = "MobHead(Creeper)",
            TextType = "skull"
        };

        public static readonly Block MobHeadDragon = new Block(397, 5)
        {
            Name = "MobHead(Dragon)",
            TextType = "skull"
        };

        public static readonly Block CarrotonaStick = new Block(398, 0)
        {
            Name = "CarrotonaStick",
            TextType = "carrot_on_a_stick"
        };

        public static readonly Block NetherStar = new Block(399, 0)
        {
            Name = "NetherStar",
            TextType = "nether_star"
        };

        public static readonly Block PumpkinPie = new Block(400, 0)
        {
            Name = "PumpkinPie",
            TextType = "pumpkin_pie"
        };

        public static readonly Block FireworkRocket = new Block(401, 0)
        {
            Name = "FireworkRocket",
            TextType = "fireworks"
        };

        public static readonly Block FireworkStar = new Block(402, 0)
        {
            Name = "FireworkStar",
            TextType = "firework_charge"
        };

        public static readonly Block EnchantedBook = new Block(403, 0)
        {
            Name = "EnchantedBook",
            TextType = "enchanted_book"
        };

        public static readonly Block RedstoneComparator = new Block(404, 0)
        {
            Name = "RedstoneComparator",
            TextType = "comparator"
        };

        public static readonly Block NetherBrick = new Block(405, 0)
        {
            Name = "NetherBrick",
            TextType = "netherbrick"
        };

        public static readonly Block NetherQuartz = new Block(406, 0)
        {
            Name = "NetherQuartz",
            TextType = "quartz"
        };

        public static readonly Block MinecartwithTnt = new Block(407, 0)
        {
            Name = "MinecartwithTNT",
            TextType = "tnt_minecart"
        };

        public static readonly Block MinecartwithHopper = new Block(408, 0)
        {
            Name = "MinecartwithHopper",
            TextType = "hopper_minecart"
        };

        public static readonly Block PrismarineShard = new Block(409, 0)
        {
            Name = "PrismarineShard",
            TextType = "prismarine_shard"
        };

        public static readonly Block PrismarineCrystals = new Block(410, 0)
        {
            Name = "PrismarineCrystals",
            TextType = "prismarine_crystals"
        };

        public static readonly Block RawRabbit = new Block(411, 0)
        {
            Name = "RawRabbit",
            TextType = "rabbit"
        };

        public static readonly Block CookedRabbit = new Block(412, 0)
        {
            Name = "CookedRabbit",
            TextType = "cooked_rabbit"
        };

        public static readonly Block RabbitStew = new Block(413, 0)
        {
            Name = "RabbitStew",
            TextType = "rabbit_stew"
        };

        public static readonly Block RabbitFoot = new Block(414, 0)
        {
            Name = "Rabbit'sFoot",
            TextType = "rabbit_foot"
        };

        public static readonly Block RabbitHide = new Block(415, 0)
        {
            Name = "RabbitHide",
            TextType = "rabbit_hide"
        };

        public static readonly Block ArmorStand = new Block(416, 0)
        {
            Name = "ArmorStand",
            TextType = "armor_stand"
        };

        public static readonly Block IronHorseArmor = new Block(417, 0)
        {
            Name = "IronHorseArmor",
            TextType = "iron_horse_armor"
        };

        public static readonly Block GoldenHorseArmor = new Block(418, 0)
        {
            Name = "GoldenHorseArmor",
            TextType = "golden_horse_armor"
        };

        public static readonly Block DiamondHorseArmor = new Block(419, 0)
        {
            Name = "DiamondHorseArmor",
            TextType = "diamond_horse_armor"
        };

        public static readonly Block Lead = new Block(420, 0)
        {
            Name = "Lead",
            TextType = "lead"
        };

        public static readonly Block NameTag = new Block(421, 0)
        {
            Name = "NameTag",
            TextType = "name_tag"
        };

        public static readonly Block MinecartwithCommandBlock = new Block(422, 0)
        {
            Name = "MinecartwithCommandBlock",
            TextType = "command_block_minecart"
        };

        public static readonly Block RawMutton = new Block(423, 0)
        {
            Name = "RawMutton",
            TextType = "mutton"
        };

        public static readonly Block CookedMutton = new Block(424, 0)
        {
            Name = "CookedMutton",
            TextType = "cooked_mutton"
        };

        public static readonly Block Banner = new Block(425, 0)
        {
            Name = "Banner",
            TextType = "banner"
        };

        public static readonly Block EndCrystal = new Block(426, 0)
        {
            Name = "EndCrystal",
            TextType = "end_crystal"
        };

        public static readonly Block SpruceDoor = new Block(427, 0)
        {
            Name = "SpruceDoor",
            TextType = "spruce_door"
        };

        public static readonly Block BirchDoor = new Block(428, 0)
        {
            Name = "BirchDoor",
            TextType = "birch_door"
        };

        public static readonly Block JungleDoor = new Block(429, 0)
        {
            Name = "JungleDoor",
            TextType = "jungle_door"
        };

        public static readonly Block AcaciaDoor = new Block(430, 0)
        {
            Name = "AcaciaDoor",
            TextType = "acacia_door"
        };

        public static readonly Block DarkOakDoor = new Block(431, 0)
        {
            Name = "DarkOakDoor",
            TextType = "dark_oak_door"
        };

        public static readonly Block ChorusFruit = new Block(432, 0)
        {
            Name = "ChorusFruit",
            TextType = "chorus_fruit"
        };

        public static readonly Block PoppedChorusFruit = new Block(433, 0)
        {
            Name = "PoppedChorusFruit",
            TextType = "popped_chorus_fruit"
        };

        public static readonly Block Beetroot = new Block(434, 0)
        {
            Name = "Beetroot",
            TextType = "beetroot"
        };

        public static readonly Block BeetrootSeeds = new Block(435, 0)
        {
            Name = "BeetrootSeeds",
            TextType = "beetroot_seeds"
        };

        public static readonly Block BeetrootSoup = new Block(436, 0)
        {
            Name = "BeetrootSoup",
            TextType = "beetroot_soup"
        };

        public static readonly Block DragonBreath = new Block(437, 0)
        {
            Name = "Dragon'sBreath",
            TextType = "dragon_breath"
        };

        public static readonly Block SplashPotion = new Block(438, 0)
        {
            Name = "SplashPotion",
            TextType = "splash_potion"
        };

        public static readonly Block SpectralArrow = new Block(439, 0)
        {
            Name = "SpectralArrow",
            TextType = "spectral_arrow"
        };

        public static readonly Block TippedArrow = new Block(440, 0)
        {
            Name = "TippedArrow",
            TextType = "tipped_arrow"
        };

        public static readonly Block LingeringPotion = new Block(441, 0)
        {
            Name = "LingeringPotion",
            TextType = "lingering_potion"
        };

        public static readonly Block Shield = new Block(442, 0)
        {
            Name = "Shield",
            TextType = "shield"
        };

        public static readonly Block Elytra = new Block(443, 0)
        {
            Name = "Elytra",
            TextType = "elytra"
        };

        public static readonly Block SpruceBoat = new Block(444, 0)
        {
            Name = "SpruceBoat",
            TextType = "spruce_boat"
        };

        public static readonly Block BirchBoat = new Block(445, 0)
        {
            Name = "BirchBoat",
            TextType = "birch_boat"
        };

        public static readonly Block JungleBoat = new Block(446, 0)
        {
            Name = "JungleBoat",
            TextType = "jungle_boat"
        };

        public static readonly Block AcaciaBoat = new Block(447, 0)
        {
            Name = "AcaciaBoat",
            TextType = "acacia_boat"
        };

        public static readonly Block DarkOakBoat = new Block(448, 0)
        {
            Name = "DarkOakBoat",
            TextType = "dark_oak_boat"
        };

        public static readonly Block TotemofUndying = new Block(449, 0)
        {
            Name = "TotemofUndying",
            TextType = "totem_of_undying"
        };

        public static readonly Block ShulkerShell = new Block(450, 0)
        {
            Name = "ShulkerShell",
            TextType = "shulker_shell"
        };

        public static readonly Block IronNugget = new Block(452, 0)
        {
            Name = "IronNugget",
            TextType = "iron_nugget"
        };

        public static readonly Block KnowledgeBook = new Block(453, 0)
        {
            Name = "KnowledgeBook",
            TextType = "knowledge_book"
        };

        public static readonly Block Disc13 = new Block(2256, 0)
        {
            Name = "13Disc",
            TextType = "record_13"
        };

        public static readonly Block CatDisc = new Block(2257, 0)
        {
            Name = "CatDisc",
            TextType = "record_cat"
        };

        public static readonly Block BlocksDisc = new Block(2258, 0)
        {
            Name = "BlocksDisc",
            TextType = "record_blocks"
        };

        public static readonly Block ChirpDisc = new Block(2259, 0)
        {
            Name = "ChirpDisc",
            TextType = "record_chirp"
        };

        public static readonly Block FarDisc = new Block(2260, 0)
        {
            Name = "FarDisc",
            TextType = "record_far"
        };

        public static readonly Block MallDisc = new Block(2261, 0)
        {
            Name = "MallDisc",
            TextType = "record_mall"
        };

        public static readonly Block MellohiDisc = new Block(2262, 0)
        {
            Name = "MellohiDisc",
            TextType = "record_mellohi"
        };

        public static readonly Block StalDisc = new Block(2263, 0)
        {
            Name = "StalDisc",
            TextType = "record_stal"
        };

        public static readonly Block StradDisc = new Block(2264, 0)
        {
            Name = "StradDisc",
            TextType = "record_strad"
        };

        public static readonly Block WardDisc = new Block(2265, 0)
        {
            Name = "WardDisc",
            TextType = "record_ward"
        };

        public static readonly Block Disc11 = new Block(2266, 0)
        {
            Name = "11Disc",
            TextType = "record_11"
        };

        public static readonly Block WaitDisc = new Block(2267, 0)
        {
            Name = "WaitDisc",
            TextType = "record_wait"
        };


    }


}