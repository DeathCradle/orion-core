﻿// Copyright (c) 2015-2019 Pryaxis & Orion Contributors
// 
// This file is part of Orion.
// 
// Orion is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Orion is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Orion.  If not, see <https://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;

namespace Orion.Entities {
    /// <summary>
    /// Represent's an item's type.
    /// </summary>
    public struct ItemType : IEquatable<ItemType> {
        #region Item Types

#pragma warning disable 1591
        public static readonly ItemType IronPickaxe = new ItemType(1);
        public static readonly ItemType DirtBlock = new ItemType(2);
        public static readonly ItemType StoneBlock = new ItemType(3);
        public static readonly ItemType IronBroadsword = new ItemType(4);
        public static readonly ItemType Mushroom = new ItemType(5);
        public static readonly ItemType IronShortsword = new ItemType(6);
        public static readonly ItemType IronHammer = new ItemType(7);
        public static readonly ItemType Torch = new ItemType(8);
        public static readonly ItemType Wood = new ItemType(9);
        public static readonly ItemType IronAxe = new ItemType(10);
        public static readonly ItemType IronOre = new ItemType(11);
        public static readonly ItemType CopperOre = new ItemType(12);
        public static readonly ItemType GoldOre = new ItemType(13);
        public static readonly ItemType SilverOre = new ItemType(14);
        public static readonly ItemType CopperWatch = new ItemType(15);
        public static readonly ItemType SilverWatch = new ItemType(16);
        public static readonly ItemType GoldWatch = new ItemType(17);
        public static readonly ItemType DepthMeter = new ItemType(18);
        public static readonly ItemType GoldBar = new ItemType(19);
        public static readonly ItemType CopperBar = new ItemType(20);
        public static readonly ItemType SilverBar = new ItemType(21);
        public static readonly ItemType IronBar = new ItemType(22);
        public static readonly ItemType Gel = new ItemType(23);
        public static readonly ItemType WoodenSword = new ItemType(24);
        public static readonly ItemType WoodenDoor = new ItemType(25);
        public static readonly ItemType StoneWall = new ItemType(26);
        public static readonly ItemType Acorn = new ItemType(27);
        public static readonly ItemType LesserHealingPotion = new ItemType(28);
        public static readonly ItemType LifeCrystal = new ItemType(29);
        public static readonly ItemType DirtWall = new ItemType(30);
        public static readonly ItemType Bottle = new ItemType(31);
        public static readonly ItemType WoodenTable = new ItemType(32);
        public static readonly ItemType Furnace = new ItemType(33);
        public static readonly ItemType WoodenChair = new ItemType(34);
        public static readonly ItemType IronAnvil = new ItemType(35);
        public static readonly ItemType WorkBench = new ItemType(36);
        public static readonly ItemType Goggles = new ItemType(37);
        public static readonly ItemType Lens = new ItemType(38);
        public static readonly ItemType WoodenBow = new ItemType(39);
        public static readonly ItemType WoodenArrow = new ItemType(40);
        public static readonly ItemType FlamingArrow = new ItemType(41);
        public static readonly ItemType Shuriken = new ItemType(42);
        public static readonly ItemType SuspiciousLookingEye = new ItemType(43);
        public static readonly ItemType DemonBow = new ItemType(44);
        public static readonly ItemType WarAxeOfTheNight = new ItemType(45);
        public static readonly ItemType LightsBane = new ItemType(46);
        public static readonly ItemType UnholyArrow = new ItemType(47);
        public static readonly ItemType Chest = new ItemType(48);
        public static readonly ItemType BandOfRegeneration = new ItemType(49);
        public static readonly ItemType MagicMirror = new ItemType(50);
        public static readonly ItemType JestersArrow = new ItemType(51);
        public static readonly ItemType AngelStatue = new ItemType(52);
        public static readonly ItemType CloudInABottle = new ItemType(53);
        public static readonly ItemType HermesBoots = new ItemType(54);
        public static readonly ItemType EnchantedBoomerang = new ItemType(55);
        public static readonly ItemType DemoniteOre = new ItemType(56);
        public static readonly ItemType DemoniteBar = new ItemType(57);
        public static readonly ItemType Heart = new ItemType(58);
        public static readonly ItemType CorruptSeeds = new ItemType(59);
        public static readonly ItemType VileMushroom = new ItemType(60);
        public static readonly ItemType EbonstoneBlock = new ItemType(61);
        public static readonly ItemType GrassSeeds = new ItemType(62);
        public static readonly ItemType Sunflower = new ItemType(63);
        public static readonly ItemType Vilethorn = new ItemType(64);
        public static readonly ItemType Starfury = new ItemType(65);
        public static readonly ItemType PurificationPowder = new ItemType(66);
        public static readonly ItemType VilePowder = new ItemType(67);
        public static readonly ItemType RottenChunk = new ItemType(68);
        public static readonly ItemType WormTooth = new ItemType(69);
        public static readonly ItemType WormFood = new ItemType(70);
        public static readonly ItemType CopperCoin = new ItemType(71);
        public static readonly ItemType SilverCoin = new ItemType(72);
        public static readonly ItemType GoldCoin = new ItemType(73);
        public static readonly ItemType PlatinumCoin = new ItemType(74);
        public static readonly ItemType FallenStar = new ItemType(75);
        public static readonly ItemType CopperGreaves = new ItemType(76);
        public static readonly ItemType IronGreaves = new ItemType(77);
        public static readonly ItemType SilverGreaves = new ItemType(78);
        public static readonly ItemType GoldGreaves = new ItemType(79);
        public static readonly ItemType CopperChainmail = new ItemType(80);
        public static readonly ItemType IronChainmail = new ItemType(81);
        public static readonly ItemType SilverChainmail = new ItemType(82);
        public static readonly ItemType GoldChainmail = new ItemType(83);
        public static readonly ItemType GrapplingHook = new ItemType(84);
        public static readonly ItemType Chain = new ItemType(85);
        public static readonly ItemType ShadowScale = new ItemType(86);
        public static readonly ItemType PiggyBank = new ItemType(87);
        public static readonly ItemType MiningHelmet = new ItemType(88);
        public static readonly ItemType CopperHelmet = new ItemType(89);
        public static readonly ItemType IronHelmet = new ItemType(90);
        public static readonly ItemType SilverHelmet = new ItemType(91);
        public static readonly ItemType GoldHelmet = new ItemType(92);
        public static readonly ItemType WoodWall = new ItemType(93);
        public static readonly ItemType WoodPlatform = new ItemType(94);
        public static readonly ItemType FlintlockPistol = new ItemType(95);
        public static readonly ItemType Musket = new ItemType(96);
        public static readonly ItemType MusketBall = new ItemType(97);
        public static readonly ItemType Minishark = new ItemType(98);
        public static readonly ItemType IronBow = new ItemType(99);
        public static readonly ItemType ShadowGreaves = new ItemType(100);
        public static readonly ItemType ShadowScalemail = new ItemType(101);
        public static readonly ItemType ShadowHelmet = new ItemType(102);
        public static readonly ItemType NightmarePickaxe = new ItemType(103);
        public static readonly ItemType TheBreaker = new ItemType(104);
        public static readonly ItemType Candle = new ItemType(105);
        public static readonly ItemType CopperChandelier = new ItemType(106);
        public static readonly ItemType SilverChandelier = new ItemType(107);
        public static readonly ItemType GoldChandelier = new ItemType(108);
        public static readonly ItemType ManaCrystal = new ItemType(109);
        public static readonly ItemType LesserManaPotion = new ItemType(110);
        public static readonly ItemType BandOfStarpower = new ItemType(111);
        public static readonly ItemType FlowerOfFire = new ItemType(112);
        public static readonly ItemType MagicMissile = new ItemType(113);
        public static readonly ItemType DirtRod = new ItemType(114);
        public static readonly ItemType ShadowOrb = new ItemType(115);
        public static readonly ItemType Meteorite = new ItemType(116);
        public static readonly ItemType MeteoriteBar = new ItemType(117);
        public static readonly ItemType Hook = new ItemType(118);
        public static readonly ItemType Flamarang = new ItemType(119);
        public static readonly ItemType MoltenFury = new ItemType(120);
        public static readonly ItemType FieryGreatsword = new ItemType(121);
        public static readonly ItemType MoltenPickaxe = new ItemType(122);
        public static readonly ItemType MeteorHelmet = new ItemType(123);
        public static readonly ItemType MeteorSuit = new ItemType(124);
        public static readonly ItemType MeteorLeggings = new ItemType(125);
        public static readonly ItemType BottledWater = new ItemType(126);
        public static readonly ItemType SpaceGun = new ItemType(127);
        public static readonly ItemType RocketBoots = new ItemType(128);
        public static readonly ItemType GrayBrick = new ItemType(129);
        public static readonly ItemType GrayBrickWall = new ItemType(130);
        public static readonly ItemType RedBrick = new ItemType(131);
        public static readonly ItemType RedBrickWall = new ItemType(132);
        public static readonly ItemType ClayBlock = new ItemType(133);
        public static readonly ItemType BlueBrick = new ItemType(134);
        public static readonly ItemType BlueBrickWall = new ItemType(135);
        public static readonly ItemType ChainLantern = new ItemType(136);
        public static readonly ItemType GreenBrick = new ItemType(137);
        public static readonly ItemType GreenBrickWall = new ItemType(138);
        public static readonly ItemType PinkBrick = new ItemType(139);
        public static readonly ItemType PinkBrickWall = new ItemType(140);
        public static readonly ItemType GoldBrick = new ItemType(141);
        public static readonly ItemType GoldBrickWall = new ItemType(142);
        public static readonly ItemType SilverBrick = new ItemType(143);
        public static readonly ItemType SilverBrickWall = new ItemType(144);
        public static readonly ItemType CopperBrick = new ItemType(145);
        public static readonly ItemType CopperBrickWall = new ItemType(146);
        public static readonly ItemType Spike = new ItemType(147);
        public static readonly ItemType WaterCandle = new ItemType(148);
        public static readonly ItemType Book = new ItemType(149);
        public static readonly ItemType Cobweb = new ItemType(150);
        public static readonly ItemType NecroHelmet = new ItemType(151);
        public static readonly ItemType NecroBreastplate = new ItemType(152);
        public static readonly ItemType NecroGreaves = new ItemType(153);
        public static readonly ItemType Bone = new ItemType(154);
        public static readonly ItemType Muramasa = new ItemType(155);
        public static readonly ItemType CobaltShield = new ItemType(156);
        public static readonly ItemType AquaScepter = new ItemType(157);
        public static readonly ItemType LuckyHorseshoe = new ItemType(158);
        public static readonly ItemType ShinyRedBalloon = new ItemType(159);
        public static readonly ItemType Harpoon = new ItemType(160);
        public static readonly ItemType SpikyBall = new ItemType(161);
        public static readonly ItemType BallOHurt = new ItemType(162);
        public static readonly ItemType BlueMoon = new ItemType(163);
        public static readonly ItemType Handgun = new ItemType(164);
        public static readonly ItemType WaterBolt = new ItemType(165);
        public static readonly ItemType Bomb = new ItemType(166);
        public static readonly ItemType Dynamite = new ItemType(167);
        public static readonly ItemType Grenade = new ItemType(168);
        public static readonly ItemType SandBlock = new ItemType(169);
        public static readonly ItemType Glass = new ItemType(170);
        public static readonly ItemType Sign = new ItemType(171);
        public static readonly ItemType AshBlock = new ItemType(172);
        public static readonly ItemType Obsidian = new ItemType(173);
        public static readonly ItemType Hellstone = new ItemType(174);
        public static readonly ItemType HellstoneBar = new ItemType(175);
        public static readonly ItemType MudBlock = new ItemType(176);
        public static readonly ItemType Sapphire = new ItemType(177);
        public static readonly ItemType Ruby = new ItemType(178);
        public static readonly ItemType Emerald = new ItemType(179);
        public static readonly ItemType Topaz = new ItemType(180);
        public static readonly ItemType Amethyst = new ItemType(181);
        public static readonly ItemType Diamond = new ItemType(182);
        public static readonly ItemType GlowingMushroom = new ItemType(183);
        public static readonly ItemType Star = new ItemType(184);
        public static readonly ItemType IvyWhip = new ItemType(185);
        public static readonly ItemType BreathingReed = new ItemType(186);
        public static readonly ItemType Flipper = new ItemType(187);
        public static readonly ItemType HealingPotion = new ItemType(188);
        public static readonly ItemType ManaPotion = new ItemType(189);
        public static readonly ItemType BladeOfGrass = new ItemType(190);
        public static readonly ItemType ThornChakram = new ItemType(191);
        public static readonly ItemType ObsidianBrick = new ItemType(192);
        public static readonly ItemType ObsidianSkull = new ItemType(193);
        public static readonly ItemType MushroomGrassSeeds = new ItemType(194);
        public static readonly ItemType JungleGrassSeeds = new ItemType(195);
        public static readonly ItemType WoodenHammer = new ItemType(196);
        public static readonly ItemType StarCannon = new ItemType(197);
        public static readonly ItemType BluePhaseblade = new ItemType(198);
        public static readonly ItemType RedPhaseblade = new ItemType(199);
        public static readonly ItemType GreenPhaseblade = new ItemType(200);
        public static readonly ItemType PurplePhaseblade = new ItemType(201);
        public static readonly ItemType WhitePhaseblade = new ItemType(202);
        public static readonly ItemType YellowPhaseblade = new ItemType(203);
        public static readonly ItemType MeteorHamaxe = new ItemType(204);
        public static readonly ItemType EmptyBucket = new ItemType(205);
        public static readonly ItemType WaterBucket = new ItemType(206);
        public static readonly ItemType LavaBucket = new ItemType(207);
        public static readonly ItemType JungleRose = new ItemType(208);
        public static readonly ItemType Stinger = new ItemType(209);
        public static readonly ItemType Vine = new ItemType(210);
        public static readonly ItemType FeralClaws = new ItemType(211);
        public static readonly ItemType AnkletOfTheWind = new ItemType(212);
        public static readonly ItemType StaffOfRegrowth = new ItemType(213);
        public static readonly ItemType HellstoneBrick = new ItemType(214);
        public static readonly ItemType WhoopieCushion = new ItemType(215);
        public static readonly ItemType Shackle = new ItemType(216);
        public static readonly ItemType MoltenHamaxe = new ItemType(217);
        public static readonly ItemType Flamelash = new ItemType(218);
        public static readonly ItemType PhoenixBlaster = new ItemType(219);
        public static readonly ItemType Sunfury = new ItemType(220);
        public static readonly ItemType Hellforge = new ItemType(221);
        public static readonly ItemType ClayPot = new ItemType(222);
        public static readonly ItemType NaturesGift = new ItemType(223);
        public static readonly ItemType Bed = new ItemType(224);
        public static readonly ItemType Silk = new ItemType(225);
        public static readonly ItemType LesserRestorationPotion = new ItemType(226);
        public static readonly ItemType RestorationPotion = new ItemType(227);
        public static readonly ItemType JungleHat = new ItemType(228);
        public static readonly ItemType JungleShirt = new ItemType(229);
        public static readonly ItemType JunglePants = new ItemType(230);
        public static readonly ItemType MoltenHelmet = new ItemType(231);
        public static readonly ItemType MoltenBreastplate = new ItemType(232);
        public static readonly ItemType MoltenGreaves = new ItemType(233);
        public static readonly ItemType MeteorShot = new ItemType(234);
        public static readonly ItemType StickyBomb = new ItemType(235);
        public static readonly ItemType BlackLens = new ItemType(236);
        public static readonly ItemType Sunglasses = new ItemType(237);
        public static readonly ItemType WizardHat = new ItemType(238);
        public static readonly ItemType TopHat = new ItemType(239);
        public static readonly ItemType TuxedoShirt = new ItemType(240);
        public static readonly ItemType TuxedoPants = new ItemType(241);
        public static readonly ItemType SummerHat = new ItemType(242);
        public static readonly ItemType BunnyHood = new ItemType(243);
        public static readonly ItemType PlumbersHat = new ItemType(244);
        public static readonly ItemType PlumbersShirt = new ItemType(245);
        public static readonly ItemType PlumbersPants = new ItemType(246);
        public static readonly ItemType HerosHat = new ItemType(247);
        public static readonly ItemType HerosShirt = new ItemType(248);
        public static readonly ItemType HerosPants = new ItemType(249);
        public static readonly ItemType FishBowl = new ItemType(250);
        public static readonly ItemType ArchaeologistsHat = new ItemType(251);
        public static readonly ItemType ArchaeologistsJacket = new ItemType(252);
        public static readonly ItemType ArchaeologistsPants = new ItemType(253);
        public static readonly ItemType BlackThread = new ItemType(254);
        public static readonly ItemType GreenThread = new ItemType(255);
        public static readonly ItemType NinjaHood = new ItemType(256);
        public static readonly ItemType NinjaShirt = new ItemType(257);
        public static readonly ItemType NinjaPants = new ItemType(258);
        public static readonly ItemType Leather = new ItemType(259);
        public static readonly ItemType RedHat = new ItemType(260);
        public static readonly ItemType Goldfish = new ItemType(261);
        public static readonly ItemType Robe = new ItemType(262);
        public static readonly ItemType RobotHat = new ItemType(263);
        public static readonly ItemType GoldCrown = new ItemType(264);
        public static readonly ItemType HellfireArrow = new ItemType(265);
        public static readonly ItemType Sandgun = new ItemType(266);
        public static readonly ItemType GuideVoodooDoll = new ItemType(267);
        public static readonly ItemType DivingHelmet = new ItemType(268);
        public static readonly ItemType FamiliarShirt = new ItemType(269);
        public static readonly ItemType FamiliarPants = new ItemType(270);
        public static readonly ItemType FamiliarWig = new ItemType(271);
        public static readonly ItemType DemonScythe = new ItemType(272);
        public static readonly ItemType NightsEdge = new ItemType(273);
        public static readonly ItemType DarkLance = new ItemType(274);
        public static readonly ItemType Coral = new ItemType(275);
        public static readonly ItemType Cactus = new ItemType(276);
        public static readonly ItemType Trident = new ItemType(277);
        public static readonly ItemType SilverBullet = new ItemType(278);
        public static readonly ItemType ThrowingKnife = new ItemType(279);
        public static readonly ItemType Spear = new ItemType(280);
        public static readonly ItemType Blowpipe = new ItemType(281);
        public static readonly ItemType Glowstick = new ItemType(282);
        public static readonly ItemType Seed = new ItemType(283);
        public static readonly ItemType WoodenBoomerang = new ItemType(284);
        public static readonly ItemType Aglet = new ItemType(285);
        public static readonly ItemType StickyGlowstick = new ItemType(286);
        public static readonly ItemType PoisonedKnife = new ItemType(287);
        public static readonly ItemType ObsidianSkinPotion = new ItemType(288);
        public static readonly ItemType RegenerationPotion = new ItemType(289);
        public static readonly ItemType SwiftnessPotion = new ItemType(290);
        public static readonly ItemType GillsPotion = new ItemType(291);
        public static readonly ItemType IronskinPotion = new ItemType(292);
        public static readonly ItemType ManaRegenerationPotion = new ItemType(293);
        public static readonly ItemType MagicPowerPotion = new ItemType(294);
        public static readonly ItemType FeatherfallPotion = new ItemType(295);
        public static readonly ItemType SpelunkerPotion = new ItemType(296);
        public static readonly ItemType InvisibilityPotion = new ItemType(297);
        public static readonly ItemType ShinePotion = new ItemType(298);
        public static readonly ItemType NightOwlPotion = new ItemType(299);
        public static readonly ItemType BattlePotion = new ItemType(300);
        public static readonly ItemType ThornsPotion = new ItemType(301);
        public static readonly ItemType WaterWalkingPotion = new ItemType(302);
        public static readonly ItemType ArcheryPotion = new ItemType(303);
        public static readonly ItemType HunterPotion = new ItemType(304);
        public static readonly ItemType GravitationPotion = new ItemType(305);
        public static readonly ItemType GoldChest = new ItemType(306);
        public static readonly ItemType DaybloomSeeds = new ItemType(307);
        public static readonly ItemType MoonglowSeeds = new ItemType(308);
        public static readonly ItemType BlinkrootSeeds = new ItemType(309);
        public static readonly ItemType DeathweedSeeds = new ItemType(310);
        public static readonly ItemType WaterleafSeeds = new ItemType(311);
        public static readonly ItemType FireblossomSeeds = new ItemType(312);
        public static readonly ItemType Daybloom = new ItemType(313);
        public static readonly ItemType Moonglow = new ItemType(314);
        public static readonly ItemType Blinkroot = new ItemType(315);
        public static readonly ItemType Deathweed = new ItemType(316);
        public static readonly ItemType Waterleaf = new ItemType(317);
        public static readonly ItemType Fireblossom = new ItemType(318);
        public static readonly ItemType SharkFin = new ItemType(319);
        public static readonly ItemType Feather = new ItemType(320);
        public static readonly ItemType Tombstone = new ItemType(321);
        public static readonly ItemType MimeMask = new ItemType(322);
        public static readonly ItemType AntlionMandible = new ItemType(323);
        public static readonly ItemType IllegalGunParts = new ItemType(324);
        public static readonly ItemType TheDoctorsShirt = new ItemType(325);
        public static readonly ItemType TheDoctorsPants = new ItemType(326);
        public static readonly ItemType GoldenKey = new ItemType(327);
        public static readonly ItemType ShadowChest = new ItemType(328);
        public static readonly ItemType ShadowKey = new ItemType(329);
        public static readonly ItemType ObsidianBrickWall = new ItemType(330);
        public static readonly ItemType JungleSpores = new ItemType(331);
        public static readonly ItemType Loom = new ItemType(332);
        public static readonly ItemType Piano = new ItemType(333);
        public static readonly ItemType Dresser = new ItemType(334);
        public static readonly ItemType Bench = new ItemType(335);
        public static readonly ItemType Bathtub = new ItemType(336);
        public static readonly ItemType RedBanner = new ItemType(337);
        public static readonly ItemType GreenBanner = new ItemType(338);
        public static readonly ItemType BlueBanner = new ItemType(339);
        public static readonly ItemType YellowBanner = new ItemType(340);
        public static readonly ItemType LampPost = new ItemType(341);
        public static readonly ItemType TikiTorch = new ItemType(342);
        public static readonly ItemType Barrel = new ItemType(343);
        public static readonly ItemType ChineseLantern = new ItemType(344);
        public static readonly ItemType CookingPot = new ItemType(345);
        public static readonly ItemType Safe = new ItemType(346);
        public static readonly ItemType SkullLantern = new ItemType(347);
        public static readonly ItemType TrashCan = new ItemType(348);
        public static readonly ItemType Candelabra = new ItemType(349);
        public static readonly ItemType PinkVase = new ItemType(350);
        public static readonly ItemType Mug = new ItemType(351);
        public static readonly ItemType Keg = new ItemType(352);
        public static readonly ItemType Ale = new ItemType(353);
        public static readonly ItemType Bookcase = new ItemType(354);
        public static readonly ItemType Throne = new ItemType(355);
        public static readonly ItemType Bowl = new ItemType(356);
        public static readonly ItemType BowlOfSoup = new ItemType(357);
        public static readonly ItemType Toilet = new ItemType(358);
        public static readonly ItemType GrandfatherClock = new ItemType(359);
        public static readonly ItemType ArmorStatue = new ItemType(360);
        public static readonly ItemType GoblinBattleStandard = new ItemType(361);
        public static readonly ItemType TatteredCloth = new ItemType(362);
        public static readonly ItemType Sawmill = new ItemType(363);
        public static readonly ItemType CobaltOre = new ItemType(364);
        public static readonly ItemType MythrilOre = new ItemType(365);
        public static readonly ItemType AdamantiteOre = new ItemType(366);
        public static readonly ItemType Pwnhammer = new ItemType(367);
        public static readonly ItemType Excalibur = new ItemType(368);
        public static readonly ItemType HallowedSeeds = new ItemType(369);
        public static readonly ItemType EbonsandBlock = new ItemType(370);
        public static readonly ItemType CobaltHat = new ItemType(371);
        public static readonly ItemType CobaltHelmet = new ItemType(372);
        public static readonly ItemType CobaltMask = new ItemType(373);
        public static readonly ItemType CobaltBreastplate = new ItemType(374);
        public static readonly ItemType CobaltLeggings = new ItemType(375);
        public static readonly ItemType MythrilHood = new ItemType(376);
        public static readonly ItemType MythrilHelmet = new ItemType(377);
        public static readonly ItemType MythrilHat = new ItemType(378);
        public static readonly ItemType MythrilChainmail = new ItemType(379);
        public static readonly ItemType MythrilGreaves = new ItemType(380);
        public static readonly ItemType CobaltBar = new ItemType(381);
        public static readonly ItemType MythrilBar = new ItemType(382);
        public static readonly ItemType CobaltChainsaw = new ItemType(383);
        public static readonly ItemType MythrilChainsaw = new ItemType(384);
        public static readonly ItemType CobaltDrill = new ItemType(385);
        public static readonly ItemType MythrilDrill = new ItemType(386);
        public static readonly ItemType AdamantiteChainsaw = new ItemType(387);
        public static readonly ItemType AdamantiteDrill = new ItemType(388);
        public static readonly ItemType DaoOfPow = new ItemType(389);
        public static readonly ItemType MythrilHalberd = new ItemType(390);
        public static readonly ItemType AdamantiteBar = new ItemType(391);
        public static readonly ItemType GlassWall = new ItemType(392);
        public static readonly ItemType Compass = new ItemType(393);
        public static readonly ItemType DivingGear = new ItemType(394);
        public static readonly ItemType Gps = new ItemType(395);
        public static readonly ItemType ObsidianHorseshoe = new ItemType(396);
        public static readonly ItemType ObsidianShield = new ItemType(397);
        public static readonly ItemType TinkerersWorkshop = new ItemType(398);
        public static readonly ItemType CloudInABalloon = new ItemType(399);
        public static readonly ItemType AdamantiteHeadgear = new ItemType(400);
        public static readonly ItemType AdamantiteHelmet = new ItemType(401);
        public static readonly ItemType AdamantiteMask = new ItemType(402);
        public static readonly ItemType AdamantiteBreastplate = new ItemType(403);
        public static readonly ItemType AdamantiteLeggings = new ItemType(404);
        public static readonly ItemType SpectreBoots = new ItemType(405);
        public static readonly ItemType AdamantiteGlaive = new ItemType(406);
        public static readonly ItemType Toolbelt = new ItemType(407);
        public static readonly ItemType PearlsandBlock = new ItemType(408);
        public static readonly ItemType PearlstoneBlock = new ItemType(409);
        public static readonly ItemType MiningShirt = new ItemType(410);
        public static readonly ItemType MiningPants = new ItemType(411);
        public static readonly ItemType PearlstoneBrick = new ItemType(412);
        public static readonly ItemType IridescentBrick = new ItemType(413);
        public static readonly ItemType MudstoneBrick = new ItemType(414);
        public static readonly ItemType CobaltBrick = new ItemType(415);
        public static readonly ItemType MythrilBrick = new ItemType(416);
        public static readonly ItemType PearlstoneBrickWall = new ItemType(417);
        public static readonly ItemType IridescentBrickWall = new ItemType(418);
        public static readonly ItemType MudstoneBrickWall = new ItemType(419);
        public static readonly ItemType CobaltBrickWall = new ItemType(420);
        public static readonly ItemType MythrilBrickWall = new ItemType(421);
        public static readonly ItemType HolyWater = new ItemType(422);
        public static readonly ItemType UnholyWater = new ItemType(423);
        public static readonly ItemType SiltBlock = new ItemType(424);
        public static readonly ItemType FairyBell = new ItemType(425);
        public static readonly ItemType BreakerBlade = new ItemType(426);
        public static readonly ItemType BlueTorch = new ItemType(427);
        public static readonly ItemType RedTorch = new ItemType(428);
        public static readonly ItemType GreenTorch = new ItemType(429);
        public static readonly ItemType PurpleTorch = new ItemType(430);
        public static readonly ItemType WhiteTorch = new ItemType(431);
        public static readonly ItemType YellowTorch = new ItemType(432);
        public static readonly ItemType DemonTorch = new ItemType(433);
        public static readonly ItemType ClockworkAssaultRifle = new ItemType(434);
        public static readonly ItemType CobaltRepeater = new ItemType(435);
        public static readonly ItemType MythrilRepeater = new ItemType(436);
        public static readonly ItemType DualHook = new ItemType(437);
        public static readonly ItemType StarStatue = new ItemType(438);
        public static readonly ItemType SwordStatue = new ItemType(439);
        public static readonly ItemType SlimeStatue = new ItemType(440);
        public static readonly ItemType GoblinStatue = new ItemType(441);
        public static readonly ItemType ShieldStatue = new ItemType(442);
        public static readonly ItemType BatStatue = new ItemType(443);
        public static readonly ItemType FishStatue = new ItemType(444);
        public static readonly ItemType BunnyStatue = new ItemType(445);
        public static readonly ItemType SkeletonStatue = new ItemType(446);
        public static readonly ItemType ReaperStatue = new ItemType(447);
        public static readonly ItemType WomanStatue = new ItemType(448);
        public static readonly ItemType ImpStatue = new ItemType(449);
        public static readonly ItemType GargoyleStatue = new ItemType(450);
        public static readonly ItemType GloomStatue = new ItemType(451);
        public static readonly ItemType HornetStatue = new ItemType(452);
        public static readonly ItemType BombStatue = new ItemType(453);
        public static readonly ItemType CrabStatue = new ItemType(454);
        public static readonly ItemType HammerStatue = new ItemType(455);
        public static readonly ItemType PotionStatue = new ItemType(456);
        public static readonly ItemType SpearStatue = new ItemType(457);
        public static readonly ItemType CrossStatue = new ItemType(458);
        public static readonly ItemType JellyfishStatue = new ItemType(459);
        public static readonly ItemType BowStatue = new ItemType(460);
        public static readonly ItemType BoomerangStatue = new ItemType(461);
        public static readonly ItemType BootStatue = new ItemType(462);
        public static readonly ItemType ChestStatue = new ItemType(463);
        public static readonly ItemType BirdStatue = new ItemType(464);
        public static readonly ItemType AxeStatue = new ItemType(465);
        public static readonly ItemType CorruptStatue = new ItemType(466);
        public static readonly ItemType TreeStatue = new ItemType(467);
        public static readonly ItemType AnvilStatue = new ItemType(468);
        public static readonly ItemType PickaxeStatue = new ItemType(469);
        public static readonly ItemType MushroomStatue = new ItemType(470);
        public static readonly ItemType EyeballStatue = new ItemType(471);
        public static readonly ItemType PillarStatue = new ItemType(472);
        public static readonly ItemType HeartStatue = new ItemType(473);
        public static readonly ItemType PotStatue = new ItemType(474);
        public static readonly ItemType SunflowerStatue = new ItemType(475);
        public static readonly ItemType KingStatue = new ItemType(476);
        public static readonly ItemType QueenStatue = new ItemType(477);
        public static readonly ItemType PiranhaStatue = new ItemType(478);
        public static readonly ItemType PlankedWall = new ItemType(479);
        public static readonly ItemType WoodenBeam = new ItemType(480);
        public static readonly ItemType AdamantiteRepeater = new ItemType(481);
        public static readonly ItemType AdamantiteSword = new ItemType(482);
        public static readonly ItemType CobaltSword = new ItemType(483);
        public static readonly ItemType MythrilSword = new ItemType(484);
        public static readonly ItemType MoonCharm = new ItemType(485);
        public static readonly ItemType Ruler = new ItemType(486);
        public static readonly ItemType CrystalBall = new ItemType(487);
        public static readonly ItemType DiscoBall = new ItemType(488);
        public static readonly ItemType SorcererEmblem = new ItemType(489);
        public static readonly ItemType WarriorEmblem = new ItemType(490);
        public static readonly ItemType RangerEmblem = new ItemType(491);
        public static readonly ItemType DemonWings = new ItemType(492);
        public static readonly ItemType AngelWings = new ItemType(493);
        public static readonly ItemType MagicalHarp = new ItemType(494);
        public static readonly ItemType RainbowRod = new ItemType(495);
        public static readonly ItemType IceRod = new ItemType(496);
        public static readonly ItemType NeptunesShell = new ItemType(497);
        public static readonly ItemType Mannequin = new ItemType(498);
        public static readonly ItemType GreaterHealingPotion = new ItemType(499);
        public static readonly ItemType GreaterManaPotion = new ItemType(500);
        public static readonly ItemType PixieDust = new ItemType(501);
        public static readonly ItemType CrystalShard = new ItemType(502);
        public static readonly ItemType ClownHat = new ItemType(503);
        public static readonly ItemType ClownShirt = new ItemType(504);
        public static readonly ItemType ClownPants = new ItemType(505);
        public static readonly ItemType Flamethrower = new ItemType(506);
        public static readonly ItemType Bell = new ItemType(507);
        public static readonly ItemType Harp = new ItemType(508);
        public static readonly ItemType RedWrench = new ItemType(509);
        public static readonly ItemType WireCutter = new ItemType(510);
        public static readonly ItemType ActiveStoneBlock = new ItemType(511);
        public static readonly ItemType InactiveStoneBlock = new ItemType(512);
        public static readonly ItemType Lever = new ItemType(513);
        public static readonly ItemType LaserRifle = new ItemType(514);
        public static readonly ItemType CrystalBullet = new ItemType(515);
        public static readonly ItemType HolyArrow = new ItemType(516);
        public static readonly ItemType MagicDagger = new ItemType(517);
        public static readonly ItemType CrystalStorm = new ItemType(518);
        public static readonly ItemType CursedFlames = new ItemType(519);
        public static readonly ItemType SoulOfLight = new ItemType(520);
        public static readonly ItemType SoulOfNight = new ItemType(521);
        public static readonly ItemType CursedFlame = new ItemType(522);
        public static readonly ItemType CursedTorch = new ItemType(523);
        public static readonly ItemType AdamantiteForge = new ItemType(524);
        public static readonly ItemType MythrilAnvil = new ItemType(525);
        public static readonly ItemType UnicornHorn = new ItemType(526);
        public static readonly ItemType DarkShard = new ItemType(527);
        public static readonly ItemType LightShard = new ItemType(528);
        public static readonly ItemType RedPressurePlate = new ItemType(529);
        public static readonly ItemType Wire = new ItemType(530);
        public static readonly ItemType SpellTome = new ItemType(531);
        public static readonly ItemType StarCloak = new ItemType(532);
        public static readonly ItemType Megashark = new ItemType(533);
        public static readonly ItemType Shotgun = new ItemType(534);
        public static readonly ItemType PhilosophersStone = new ItemType(535);
        public static readonly ItemType TitanGlove = new ItemType(536);
        public static readonly ItemType CobaltNaginata = new ItemType(537);
        public static readonly ItemType Switch = new ItemType(538);
        public static readonly ItemType DartTrap = new ItemType(539);
        public static readonly ItemType Boulder = new ItemType(540);
        public static readonly ItemType GreenPressurePlate = new ItemType(541);
        public static readonly ItemType GrayPressurePlate = new ItemType(542);
        public static readonly ItemType BrownPressurePlate = new ItemType(543);
        public static readonly ItemType MechanicalEye = new ItemType(544);
        public static readonly ItemType CursedArrow = new ItemType(545);
        public static readonly ItemType CursedBullet = new ItemType(546);
        public static readonly ItemType SoulOfFright = new ItemType(547);
        public static readonly ItemType SoulOfMight = new ItemType(548);
        public static readonly ItemType SoulOfSight = new ItemType(549);
        public static readonly ItemType Gungnir = new ItemType(550);
        public static readonly ItemType HallowedPlateMail = new ItemType(551);
        public static readonly ItemType HallowedGreaves = new ItemType(552);
        public static readonly ItemType HallowedHelmet = new ItemType(553);
        public static readonly ItemType CrossNecklace = new ItemType(554);
        public static readonly ItemType ManaFlower = new ItemType(555);
        public static readonly ItemType MechanicalWorm = new ItemType(556);
        public static readonly ItemType MechanicalSkull = new ItemType(557);
        public static readonly ItemType HallowedHeadgear = new ItemType(558);
        public static readonly ItemType HallowedMask = new ItemType(559);
        public static readonly ItemType SlimeCrown = new ItemType(560);
        public static readonly ItemType LightDisc = new ItemType(561);
        public static readonly ItemType MusicBoxOverworldDay = new ItemType(562);
        public static readonly ItemType MusicBoxEerie = new ItemType(563);
        public static readonly ItemType MusicBoxNight = new ItemType(564);
        public static readonly ItemType MusicBoxTitle = new ItemType(565);
        public static readonly ItemType MusicBoxUnderground = new ItemType(566);
        public static readonly ItemType MusicBoxBoss1 = new ItemType(567);
        public static readonly ItemType MusicBoxJungle = new ItemType(568);
        public static readonly ItemType MusicBoxCorruption = new ItemType(569);
        public static readonly ItemType MusicBoxUndergroundCorruption = new ItemType(570);
        public static readonly ItemType MusicBoxTheHallow = new ItemType(571);
        public static readonly ItemType MusicBoxBoss2 = new ItemType(572);
        public static readonly ItemType MusicBoxUndergroundHallow = new ItemType(573);
        public static readonly ItemType MusicBoxBoss3 = new ItemType(574);
        public static readonly ItemType SoulOfFlight = new ItemType(575);
        public static readonly ItemType MusicBox = new ItemType(576);
        public static readonly ItemType DemoniteBrick = new ItemType(577);
        public static readonly ItemType HallowedRepeater = new ItemType(578);
        public static readonly ItemType Drax = new ItemType(579);
        public static readonly ItemType Explosives = new ItemType(580);
        public static readonly ItemType InletPump = new ItemType(581);
        public static readonly ItemType OutletPump = new ItemType(582);
        public static readonly ItemType OneSecondTimer = new ItemType(583);
        public static readonly ItemType ThreeSecondTimer = new ItemType(584);
        public static readonly ItemType FiveSecondTimer = new ItemType(585);
        public static readonly ItemType CandyCaneBlock = new ItemType(586);
        public static readonly ItemType CandyCaneWall = new ItemType(587);
        public static readonly ItemType SantaHat = new ItemType(588);
        public static readonly ItemType SantaShirt = new ItemType(589);
        public static readonly ItemType SantaPants = new ItemType(590);
        public static readonly ItemType GreenCandyCaneBlock = new ItemType(591);
        public static readonly ItemType GreenCandyCaneWall = new ItemType(592);
        public static readonly ItemType SnowBlock = new ItemType(593);
        public static readonly ItemType SnowBrick = new ItemType(594);
        public static readonly ItemType SnowBrickWall = new ItemType(595);
        public static readonly ItemType BlueLight = new ItemType(596);
        public static readonly ItemType RedLight = new ItemType(597);
        public static readonly ItemType GreenLight = new ItemType(598);
        public static readonly ItemType BluePresent = new ItemType(599);
        public static readonly ItemType GreenPresent = new ItemType(600);
        public static readonly ItemType YellowPresent = new ItemType(601);
        public static readonly ItemType SnowGlobe = new ItemType(602);
        public static readonly ItemType Carrot = new ItemType(603);
        public static readonly ItemType AdamantiteBeam = new ItemType(604);
        public static readonly ItemType AdamantiteBeamWall = new ItemType(605);
        public static readonly ItemType DemoniteBrickWall = new ItemType(606);
        public static readonly ItemType SandstoneBrick = new ItemType(607);
        public static readonly ItemType SandstoneBrickWall = new ItemType(608);
        public static readonly ItemType EbonstoneBrick = new ItemType(609);
        public static readonly ItemType EbonstoneBrickWall = new ItemType(610);
        public static readonly ItemType RedStucco = new ItemType(611);
        public static readonly ItemType YellowStucco = new ItemType(612);
        public static readonly ItemType GreenStucco = new ItemType(613);
        public static readonly ItemType GrayStucco = new ItemType(614);
        public static readonly ItemType RedStuccoWall = new ItemType(615);
        public static readonly ItemType YellowStuccoWall = new ItemType(616);
        public static readonly ItemType GreenStuccoWall = new ItemType(617);
        public static readonly ItemType GrayStuccoWall = new ItemType(618);
        public static readonly ItemType Ebonwood = new ItemType(619);
        public static readonly ItemType RichMahogany = new ItemType(620);
        public static readonly ItemType Pearlwood = new ItemType(621);
        public static readonly ItemType EbonwoodWall = new ItemType(622);
        public static readonly ItemType RichMahoganyWall = new ItemType(623);
        public static readonly ItemType PearlwoodWall = new ItemType(624);
        public static readonly ItemType EbonwoodChest = new ItemType(625);
        public static readonly ItemType RichMahoganyChest = new ItemType(626);
        public static readonly ItemType PearlwoodChest = new ItemType(627);
        public static readonly ItemType EbonwoodChair = new ItemType(628);
        public static readonly ItemType RichMahoganyChair = new ItemType(629);
        public static readonly ItemType PearlwoodChair = new ItemType(630);
        public static readonly ItemType EbonwoodPlatform = new ItemType(631);
        public static readonly ItemType RichMahoganyPlatform = new ItemType(632);
        public static readonly ItemType PearlwoodPlatform = new ItemType(633);
        public static readonly ItemType BonePlatform = new ItemType(634);
        public static readonly ItemType EbonwoodWorkBench = new ItemType(635);
        public static readonly ItemType RichMahoganyWorkBench = new ItemType(636);
        public static readonly ItemType PearlwoodWorkBench = new ItemType(637);
        public static readonly ItemType EbonwoodTable = new ItemType(638);
        public static readonly ItemType RichMahoganyTable = new ItemType(639);
        public static readonly ItemType PearlwoodTable = new ItemType(640);
        public static readonly ItemType EbonwoodPiano = new ItemType(641);
        public static readonly ItemType RichMahoganyPiano = new ItemType(642);
        public static readonly ItemType PearlwoodPiano = new ItemType(643);
        public static readonly ItemType EbonwoodBed = new ItemType(644);
        public static readonly ItemType RichMahoganyBed = new ItemType(645);
        public static readonly ItemType PearlwoodBed = new ItemType(646);
        public static readonly ItemType EbonwoodDresser = new ItemType(647);
        public static readonly ItemType RichMahoganyDresser = new ItemType(648);
        public static readonly ItemType PearlwoodDresser = new ItemType(649);
        public static readonly ItemType EbonwoodDoor = new ItemType(650);
        public static readonly ItemType RichMahoganyDoor = new ItemType(651);
        public static readonly ItemType PearlwoodDoor = new ItemType(652);
        public static readonly ItemType EbonwoodSword = new ItemType(653);
        public static readonly ItemType EbonwoodHammer = new ItemType(654);
        public static readonly ItemType EbonwoodBow = new ItemType(655);
        public static readonly ItemType RichMahoganySword = new ItemType(656);
        public static readonly ItemType RichMahoganyHammer = new ItemType(657);
        public static readonly ItemType RichMahoganyBow = new ItemType(658);
        public static readonly ItemType PearlwoodSword = new ItemType(659);
        public static readonly ItemType PearlwoodHammer = new ItemType(660);
        public static readonly ItemType PearlwoodBow = new ItemType(661);
        public static readonly ItemType RainbowBrick = new ItemType(662);
        public static readonly ItemType RainbowBrickWall = new ItemType(663);
        public static readonly ItemType IceBlock = new ItemType(664);
        public static readonly ItemType RedsWings = new ItemType(665);
        public static readonly ItemType RedsHelmet = new ItemType(666);
        public static readonly ItemType RedsBreastplate = new ItemType(667);
        public static readonly ItemType RedsLeggings = new ItemType(668);
        public static readonly ItemType Fish = new ItemType(669);
        public static readonly ItemType IceBoomerang = new ItemType(670);
        public static readonly ItemType Keybrand = new ItemType(671);
        public static readonly ItemType Cutlass = new ItemType(672);
        public static readonly ItemType BorealWoodWorkBench = new ItemType(673);
        public static readonly ItemType TrueExcalibur = new ItemType(674);
        public static readonly ItemType TrueNightsEdge = new ItemType(675);
        public static readonly ItemType Frostbrand = new ItemType(676);
        public static readonly ItemType BorealWoodTable = new ItemType(677);
        public static readonly ItemType RedPotion = new ItemType(678);
        public static readonly ItemType TacticalShotgun = new ItemType(679);
        public static readonly ItemType IvyChest = new ItemType(680);
        public static readonly ItemType IceChest = new ItemType(681);
        public static readonly ItemType Marrow = new ItemType(682);
        public static readonly ItemType UnholyTrident = new ItemType(683);
        public static readonly ItemType FrostHelmet = new ItemType(684);
        public static readonly ItemType FrostBreastplate = new ItemType(685);
        public static readonly ItemType FrostLeggings = new ItemType(686);
        public static readonly ItemType TinHelmet = new ItemType(687);
        public static readonly ItemType TinChainmail = new ItemType(688);
        public static readonly ItemType TinGreaves = new ItemType(689);
        public static readonly ItemType LeadHelmet = new ItemType(690);
        public static readonly ItemType LeadChainmail = new ItemType(691);
        public static readonly ItemType LeadGreaves = new ItemType(692);
        public static readonly ItemType TungstenHelmet = new ItemType(693);
        public static readonly ItemType TungstenChainmail = new ItemType(694);
        public static readonly ItemType TungstenGreaves = new ItemType(695);
        public static readonly ItemType PlatinumHelmet = new ItemType(696);
        public static readonly ItemType PlatinumChainmail = new ItemType(697);
        public static readonly ItemType PlatinumGreaves = new ItemType(698);
        public static readonly ItemType TinOre = new ItemType(699);
        public static readonly ItemType LeadOre = new ItemType(700);
        public static readonly ItemType TungstenOre = new ItemType(701);
        public static readonly ItemType PlatinumOre = new ItemType(702);
        public static readonly ItemType TinBar = new ItemType(703);
        public static readonly ItemType LeadBar = new ItemType(704);
        public static readonly ItemType TungstenBar = new ItemType(705);
        public static readonly ItemType PlatinumBar = new ItemType(706);
        public static readonly ItemType TinWatch = new ItemType(707);
        public static readonly ItemType TungstenWatch = new ItemType(708);
        public static readonly ItemType PlatinumWatch = new ItemType(709);
        public static readonly ItemType TinChandelier = new ItemType(710);
        public static readonly ItemType TungstenChandelier = new ItemType(711);
        public static readonly ItemType PlatinumChandelier = new ItemType(712);
        public static readonly ItemType PlatinumCandle = new ItemType(713);
        public static readonly ItemType PlatinumCandelabra = new ItemType(714);
        public static readonly ItemType PlatinumCrown = new ItemType(715);
        public static readonly ItemType LeadAnvil = new ItemType(716);
        public static readonly ItemType TinBrick = new ItemType(717);
        public static readonly ItemType TungstenBrick = new ItemType(718);
        public static readonly ItemType PlatinumBrick = new ItemType(719);
        public static readonly ItemType TinBrickWall = new ItemType(720);
        public static readonly ItemType TungstenBrickWall = new ItemType(721);
        public static readonly ItemType PlatinumBrickWall = new ItemType(722);
        public static readonly ItemType BeamSword = new ItemType(723);
        public static readonly ItemType IceBlade = new ItemType(724);
        public static readonly ItemType IceBow = new ItemType(725);
        public static readonly ItemType FrostStaff = new ItemType(726);
        public static readonly ItemType WoodHelmet = new ItemType(727);
        public static readonly ItemType WoodBreastplate = new ItemType(728);
        public static readonly ItemType WoodGreaves = new ItemType(729);
        public static readonly ItemType EbonwoodHelmet = new ItemType(730);
        public static readonly ItemType EbonwoodBreastplate = new ItemType(731);
        public static readonly ItemType EbonwoodGreaves = new ItemType(732);
        public static readonly ItemType RichMahoganyHelmet = new ItemType(733);
        public static readonly ItemType RichMahoganyBreastplate = new ItemType(734);
        public static readonly ItemType RichMahoganyGreaves = new ItemType(735);
        public static readonly ItemType PearlwoodHelmet = new ItemType(736);
        public static readonly ItemType PearlwoodBreastplate = new ItemType(737);
        public static readonly ItemType PearlwoodGreaves = new ItemType(738);
        public static readonly ItemType AmethystStaff = new ItemType(739);
        public static readonly ItemType TopazStaff = new ItemType(740);
        public static readonly ItemType SapphireStaff = new ItemType(741);
        public static readonly ItemType EmeraldStaff = new ItemType(742);
        public static readonly ItemType RubyStaff = new ItemType(743);
        public static readonly ItemType DiamondStaff = new ItemType(744);
        public static readonly ItemType GrassWall = new ItemType(745);
        public static readonly ItemType JungleWall = new ItemType(746);
        public static readonly ItemType FlowerWall = new ItemType(747);
        public static readonly ItemType Jetpack = new ItemType(748);
        public static readonly ItemType ButterflyWings = new ItemType(749);
        public static readonly ItemType CactusWall = new ItemType(750);
        public static readonly ItemType Cloud = new ItemType(751);
        public static readonly ItemType CloudWall = new ItemType(752);
        public static readonly ItemType Seaweed = new ItemType(753);
        public static readonly ItemType RuneHat = new ItemType(754);
        public static readonly ItemType RuneRobe = new ItemType(755);
        public static readonly ItemType MushroomSpear = new ItemType(756);
        public static readonly ItemType TerraBlade = new ItemType(757);
        public static readonly ItemType GrenadeLauncher = new ItemType(758);
        public static readonly ItemType RocketLauncher = new ItemType(759);
        public static readonly ItemType ProximityMineLauncher = new ItemType(760);
        public static readonly ItemType FairyWings = new ItemType(761);
        public static readonly ItemType SlimeBlock = new ItemType(762);
        public static readonly ItemType FleshBlock = new ItemType(763);
        public static readonly ItemType MushroomWall = new ItemType(764);
        public static readonly ItemType RainCloud = new ItemType(765);
        public static readonly ItemType BoneBlock = new ItemType(766);
        public static readonly ItemType FrozenSlimeBlock = new ItemType(767);
        public static readonly ItemType BoneBlockWall = new ItemType(768);
        public static readonly ItemType SlimeBlockWall = new ItemType(769);
        public static readonly ItemType FleshBlockWall = new ItemType(770);
        public static readonly ItemType RocketI = new ItemType(771);
        public static readonly ItemType RocketIi = new ItemType(772);
        public static readonly ItemType RocketIii = new ItemType(773);
        public static readonly ItemType RocketIv = new ItemType(774);
        public static readonly ItemType AsphaltBlock = new ItemType(775);
        public static readonly ItemType CobaltPickaxe = new ItemType(776);
        public static readonly ItemType MythrilPickaxe = new ItemType(777);
        public static readonly ItemType AdamantitePickaxe = new ItemType(778);
        public static readonly ItemType Clentaminator = new ItemType(779);
        public static readonly ItemType GreenSolution = new ItemType(780);
        public static readonly ItemType BlueSolution = new ItemType(781);
        public static readonly ItemType PurpleSolution = new ItemType(782);
        public static readonly ItemType DarkBlueSolution = new ItemType(783);
        public static readonly ItemType RedSolution = new ItemType(784);
        public static readonly ItemType HarpyWings = new ItemType(785);
        public static readonly ItemType BoneWings = new ItemType(786);
        public static readonly ItemType Hammush = new ItemType(787);
        public static readonly ItemType NettleBurst = new ItemType(788);
        public static readonly ItemType AnkhBanner = new ItemType(789);
        public static readonly ItemType SnakeBanner = new ItemType(790);
        public static readonly ItemType OmegaBanner = new ItemType(791);
        public static readonly ItemType CrimsonHelmet = new ItemType(792);
        public static readonly ItemType CrimsonScalemail = new ItemType(793);
        public static readonly ItemType CrimsonGreaves = new ItemType(794);
        public static readonly ItemType BloodButcherer = new ItemType(795);
        public static readonly ItemType TendonBow = new ItemType(796);
        public static readonly ItemType FleshGrinder = new ItemType(797);
        public static readonly ItemType DeathbringerPickaxe = new ItemType(798);
        public static readonly ItemType BloodLustCluster = new ItemType(799);
        public static readonly ItemType TheUndertaker = new ItemType(800);
        public static readonly ItemType TheMeatball = new ItemType(801);
        public static readonly ItemType TheRottedFork = new ItemType(802);
        public static readonly ItemType EskimoHood = new ItemType(803);
        public static readonly ItemType EskimoCoat = new ItemType(804);
        public static readonly ItemType EskimoPants = new ItemType(805);
        public static readonly ItemType LivingWoodChair = new ItemType(806);
        public static readonly ItemType CactusChair = new ItemType(807);
        public static readonly ItemType BoneChair = new ItemType(808);
        public static readonly ItemType FleshChair = new ItemType(809);
        public static readonly ItemType MushroomChair = new ItemType(810);
        public static readonly ItemType BoneWorkBench = new ItemType(811);
        public static readonly ItemType CactusWorkBench = new ItemType(812);
        public static readonly ItemType FleshWorkBench = new ItemType(813);
        public static readonly ItemType MushroomWorkBench = new ItemType(814);
        public static readonly ItemType SlimeWorkBench = new ItemType(815);
        public static readonly ItemType CactusDoor = new ItemType(816);
        public static readonly ItemType FleshDoor = new ItemType(817);
        public static readonly ItemType MushroomDoor = new ItemType(818);
        public static readonly ItemType LivingWoodDoor = new ItemType(819);
        public static readonly ItemType BoneDoor = new ItemType(820);
        public static readonly ItemType FlameWings = new ItemType(821);
        public static readonly ItemType FrozenWings = new ItemType(822);
        public static readonly ItemType SpectreWings = new ItemType(823);
        public static readonly ItemType SunplateBlock = new ItemType(824);
        public static readonly ItemType DiscWall = new ItemType(825);
        public static readonly ItemType SkywareChair = new ItemType(826);
        public static readonly ItemType BoneTable = new ItemType(827);
        public static readonly ItemType FleshTable = new ItemType(828);
        public static readonly ItemType LivingWoodTable = new ItemType(829);
        public static readonly ItemType SkywareTable = new ItemType(830);
        public static readonly ItemType LivingWoodChest = new ItemType(831);
        public static readonly ItemType LivingWoodWand = new ItemType(832);
        public static readonly ItemType PurpleIceBlock = new ItemType(833);
        public static readonly ItemType PinkIceBlock = new ItemType(834);
        public static readonly ItemType RedIceBlock = new ItemType(835);
        public static readonly ItemType CrimstoneBlock = new ItemType(836);
        public static readonly ItemType SkywareDoor = new ItemType(837);
        public static readonly ItemType SkywareChest = new ItemType(838);
        public static readonly ItemType SteampunkHat = new ItemType(839);
        public static readonly ItemType SteampunkShirt = new ItemType(840);
        public static readonly ItemType SteampunkPants = new ItemType(841);
        public static readonly ItemType BeeHat = new ItemType(842);
        public static readonly ItemType BeeShirt = new ItemType(843);
        public static readonly ItemType BeePants = new ItemType(844);
        public static readonly ItemType WorldBanner = new ItemType(845);
        public static readonly ItemType SunBanner = new ItemType(846);
        public static readonly ItemType GravityBanner = new ItemType(847);
        public static readonly ItemType PharaohsMask = new ItemType(848);
        public static readonly ItemType Actuator = new ItemType(849);
        public static readonly ItemType BlueWrench = new ItemType(850);
        public static readonly ItemType GreenWrench = new ItemType(851);
        public static readonly ItemType BluePressurePlate = new ItemType(852);
        public static readonly ItemType YellowPressurePlate = new ItemType(853);
        public static readonly ItemType DiscountCard = new ItemType(854);
        public static readonly ItemType LuckyCoin = new ItemType(855);
        public static readonly ItemType UnicornonaStick = new ItemType(856);
        public static readonly ItemType SandstormInABottle = new ItemType(857);
        public static readonly ItemType BorealWoodSofa = new ItemType(858);
        public static readonly ItemType BeachBall = new ItemType(859);
        public static readonly ItemType CharmOfMyths = new ItemType(860);
        public static readonly ItemType MoonShell = new ItemType(861);
        public static readonly ItemType StarVeil = new ItemType(862);
        public static readonly ItemType WaterWalkingBoots = new ItemType(863);
        public static readonly ItemType Tiara = new ItemType(864);
        public static readonly ItemType PrincessDress = new ItemType(865);
        public static readonly ItemType PharaohsRobe = new ItemType(866);
        public static readonly ItemType GreenCap = new ItemType(867);
        public static readonly ItemType MushroomCap = new ItemType(868);
        public static readonly ItemType TamOShanter = new ItemType(869);
        public static readonly ItemType MummyMask = new ItemType(870);
        public static readonly ItemType MummyShirt = new ItemType(871);
        public static readonly ItemType MummyPants = new ItemType(872);
        public static readonly ItemType CowboyHat = new ItemType(873);
        public static readonly ItemType CowboyJacket = new ItemType(874);
        public static readonly ItemType CowboyPants = new ItemType(875);
        public static readonly ItemType PirateHat = new ItemType(876);
        public static readonly ItemType PirateShirt = new ItemType(877);
        public static readonly ItemType PiratePants = new ItemType(878);
        public static readonly ItemType VikingHelmet = new ItemType(879);
        public static readonly ItemType CrimtaneOre = new ItemType(880);
        public static readonly ItemType CactusSword = new ItemType(881);
        public static readonly ItemType CactusPickaxe = new ItemType(882);
        public static readonly ItemType IceBrick = new ItemType(883);
        public static readonly ItemType IceBrickWall = new ItemType(884);
        public static readonly ItemType AdhesiveBandage = new ItemType(885);
        public static readonly ItemType ArmorPolish = new ItemType(886);
        public static readonly ItemType Bezoar = new ItemType(887);
        public static readonly ItemType Blindfold = new ItemType(888);
        public static readonly ItemType FastClock = new ItemType(889);
        public static readonly ItemType Megaphone = new ItemType(890);
        public static readonly ItemType Nazar = new ItemType(891);
        public static readonly ItemType Vitamins = new ItemType(892);
        public static readonly ItemType TrifoldMap = new ItemType(893);
        public static readonly ItemType CactusHelmet = new ItemType(894);
        public static readonly ItemType CactusBreastplate = new ItemType(895);
        public static readonly ItemType CactusLeggings = new ItemType(896);
        public static readonly ItemType PowerGlove = new ItemType(897);
        public static readonly ItemType LightningBoots = new ItemType(898);
        public static readonly ItemType SunStone = new ItemType(899);
        public static readonly ItemType MoonStone = new ItemType(900);
        public static readonly ItemType ArmorBracing = new ItemType(901);
        public static readonly ItemType MedicatedBandage = new ItemType(902);
        public static readonly ItemType ThePlan = new ItemType(903);
        public static readonly ItemType CountercurseMantra = new ItemType(904);
        public static readonly ItemType CoinGun = new ItemType(905);
        public static readonly ItemType LavaCharm = new ItemType(906);
        public static readonly ItemType ObsidianWaterWalkingBoots = new ItemType(907);
        public static readonly ItemType LavaWaders = new ItemType(908);
        public static readonly ItemType PureWaterFountain = new ItemType(909);
        public static readonly ItemType DesertWaterFountain = new ItemType(910);
        public static readonly ItemType Shadewood = new ItemType(911);
        public static readonly ItemType ShadewoodDoor = new ItemType(912);
        public static readonly ItemType ShadewoodPlatform = new ItemType(913);
        public static readonly ItemType ShadewoodChest = new ItemType(914);
        public static readonly ItemType ShadewoodChair = new ItemType(915);
        public static readonly ItemType ShadewoodWorkBench = new ItemType(916);
        public static readonly ItemType ShadewoodTable = new ItemType(917);
        public static readonly ItemType ShadewoodDresser = new ItemType(918);
        public static readonly ItemType ShadewoodPiano = new ItemType(919);
        public static readonly ItemType ShadewoodBed = new ItemType(920);
        public static readonly ItemType ShadewoodSword = new ItemType(921);
        public static readonly ItemType ShadewoodHammer = new ItemType(922);
        public static readonly ItemType ShadewoodBow = new ItemType(923);
        public static readonly ItemType ShadewoodHelmet = new ItemType(924);
        public static readonly ItemType ShadewoodBreastplate = new ItemType(925);
        public static readonly ItemType ShadewoodGreaves = new ItemType(926);
        public static readonly ItemType ShadewoodWall = new ItemType(927);
        public static readonly ItemType Cannon = new ItemType(928);
        public static readonly ItemType Cannonball = new ItemType(929);
        public static readonly ItemType FlareGun = new ItemType(930);
        public static readonly ItemType Flare = new ItemType(931);
        public static readonly ItemType BoneWand = new ItemType(932);
        public static readonly ItemType LeafWand = new ItemType(933);
        public static readonly ItemType FlyingCarpet = new ItemType(934);
        public static readonly ItemType AvengerEmblem = new ItemType(935);
        public static readonly ItemType MechanicalGlove = new ItemType(936);
        public static readonly ItemType LandMine = new ItemType(937);
        public static readonly ItemType PaladinsShield = new ItemType(938);
        public static readonly ItemType WebSlinger = new ItemType(939);
        public static readonly ItemType JungleWaterFountain = new ItemType(940);
        public static readonly ItemType IcyWaterFountain = new ItemType(941);
        public static readonly ItemType CorruptWaterFountain = new ItemType(942);
        public static readonly ItemType CrimsonWaterFountain = new ItemType(943);
        public static readonly ItemType HallowedWaterFountain = new ItemType(944);
        public static readonly ItemType BloodWaterFountain = new ItemType(945);
        public static readonly ItemType Umbrella = new ItemType(946);
        public static readonly ItemType ChlorophyteOre = new ItemType(947);
        public static readonly ItemType SteampunkWings = new ItemType(948);
        public static readonly ItemType Snowball = new ItemType(949);
        public static readonly ItemType IceSkates = new ItemType(950);
        public static readonly ItemType SnowballLauncher = new ItemType(951);
        public static readonly ItemType WebCoveredChest = new ItemType(952);
        public static readonly ItemType ClimbingClaws = new ItemType(953);
        public static readonly ItemType AncientIronHelmet = new ItemType(954);
        public static readonly ItemType AncientGoldHelmet = new ItemType(955);
        public static readonly ItemType AncientShadowHelmet = new ItemType(956);
        public static readonly ItemType AncientShadowScalemail = new ItemType(957);
        public static readonly ItemType AncientShadowGreaves = new ItemType(958);
        public static readonly ItemType AncientNecroHelmet = new ItemType(959);
        public static readonly ItemType AncientCobaltHelmet = new ItemType(960);
        public static readonly ItemType AncientCobaltBreastplate = new ItemType(961);
        public static readonly ItemType AncientCobaltLeggings = new ItemType(962);
        public static readonly ItemType BlackBelt = new ItemType(963);
        public static readonly ItemType Boomstick = new ItemType(964);
        public static readonly ItemType Rope = new ItemType(965);
        public static readonly ItemType Campfire = new ItemType(966);
        public static readonly ItemType Marshmallow = new ItemType(967);
        public static readonly ItemType MarshmallowonaStick = new ItemType(968);
        public static readonly ItemType CookedMarshmallow = new ItemType(969);
        public static readonly ItemType RedRocket = new ItemType(970);
        public static readonly ItemType GreenRocket = new ItemType(971);
        public static readonly ItemType BlueRocket = new ItemType(972);
        public static readonly ItemType YellowRocket = new ItemType(973);
        public static readonly ItemType IceTorch = new ItemType(974);
        public static readonly ItemType ShoeSpikes = new ItemType(975);
        public static readonly ItemType TigerClimbingGear = new ItemType(976);
        public static readonly ItemType Tabi = new ItemType(977);
        public static readonly ItemType PinkEskimoHood = new ItemType(978);
        public static readonly ItemType PinkEskimoCoat = new ItemType(979);
        public static readonly ItemType PinkEskimoPants = new ItemType(980);
        public static readonly ItemType PinkThread = new ItemType(981);
        public static readonly ItemType ManaRegenerationBand = new ItemType(982);
        public static readonly ItemType SandstormInABalloon = new ItemType(983);
        public static readonly ItemType MasterNinjaGear = new ItemType(984);
        public static readonly ItemType RopeCoil = new ItemType(985);
        public static readonly ItemType Blowgun = new ItemType(986);
        public static readonly ItemType BlizzardInABottle = new ItemType(987);
        public static readonly ItemType FrostburnArrow = new ItemType(988);
        public static readonly ItemType EnchantedSword = new ItemType(989);
        public static readonly ItemType PickaxeAxe = new ItemType(990);
        public static readonly ItemType CobaltWaraxe = new ItemType(991);
        public static readonly ItemType MythrilWaraxe = new ItemType(992);
        public static readonly ItemType AdamantiteWaraxe = new ItemType(993);
        public static readonly ItemType EatersBone = new ItemType(994);
        public static readonly ItemType BlendOMatic = new ItemType(995);
        public static readonly ItemType MeatGrinder = new ItemType(996);
        public static readonly ItemType Extractinator = new ItemType(997);
        public static readonly ItemType Solidifier = new ItemType(998);
        public static readonly ItemType Amber = new ItemType(999);
        public static readonly ItemType ConfettiGun = new ItemType(1000);
        public static readonly ItemType ChlorophyteMask = new ItemType(1001);
        public static readonly ItemType ChlorophyteHelmet = new ItemType(1002);
        public static readonly ItemType ChlorophyteHeadgear = new ItemType(1003);
        public static readonly ItemType ChlorophytePlateMail = new ItemType(1004);
        public static readonly ItemType ChlorophyteGreaves = new ItemType(1005);
        public static readonly ItemType ChlorophyteBar = new ItemType(1006);
        public static readonly ItemType RedDye = new ItemType(1007);
        public static readonly ItemType OrangeDye = new ItemType(1008);
        public static readonly ItemType YellowDye = new ItemType(1009);
        public static readonly ItemType LimeDye = new ItemType(1010);
        public static readonly ItemType GreenDye = new ItemType(1011);
        public static readonly ItemType TealDye = new ItemType(1012);
        public static readonly ItemType CyanDye = new ItemType(1013);
        public static readonly ItemType SkyBlueDye = new ItemType(1014);
        public static readonly ItemType BlueDye = new ItemType(1015);
        public static readonly ItemType PurpleDye = new ItemType(1016);
        public static readonly ItemType VioletDye = new ItemType(1017);
        public static readonly ItemType PinkDye = new ItemType(1018);
        public static readonly ItemType RedandBlackDye = new ItemType(1019);
        public static readonly ItemType OrangeandBlackDye = new ItemType(1020);
        public static readonly ItemType YellowandBlackDye = new ItemType(1021);
        public static readonly ItemType LimeandBlackDye = new ItemType(1022);
        public static readonly ItemType GreenandBlackDye = new ItemType(1023);
        public static readonly ItemType TealandBlackDye = new ItemType(1024);
        public static readonly ItemType CyanandBlackDye = new ItemType(1025);
        public static readonly ItemType SkyBlueandBlackDye = new ItemType(1026);
        public static readonly ItemType BlueandBlackDye = new ItemType(1027);
        public static readonly ItemType PurpleandBlackDye = new ItemType(1028);
        public static readonly ItemType VioletandBlackDye = new ItemType(1029);
        public static readonly ItemType PinkandBlackDye = new ItemType(1030);
        public static readonly ItemType FlameDye = new ItemType(1031);
        public static readonly ItemType FlameandBlackDye = new ItemType(1032);
        public static readonly ItemType GreenFlameDye = new ItemType(1033);
        public static readonly ItemType GreenFlameandBlackDye = new ItemType(1034);
        public static readonly ItemType BlueFlameDye = new ItemType(1035);
        public static readonly ItemType BlueFlameandBlackDye = new ItemType(1036);
        public static readonly ItemType SilverDye = new ItemType(1037);
        public static readonly ItemType BrightRedDye = new ItemType(1038);
        public static readonly ItemType BrightOrangeDye = new ItemType(1039);
        public static readonly ItemType BrightYellowDye = new ItemType(1040);
        public static readonly ItemType BrightLimeDye = new ItemType(1041);
        public static readonly ItemType BrightGreenDye = new ItemType(1042);
        public static readonly ItemType BrightTealDye = new ItemType(1043);
        public static readonly ItemType BrightCyanDye = new ItemType(1044);
        public static readonly ItemType BrightSkyBlueDye = new ItemType(1045);
        public static readonly ItemType BrightBlueDye = new ItemType(1046);
        public static readonly ItemType BrightPurpleDye = new ItemType(1047);
        public static readonly ItemType BrightVioletDye = new ItemType(1048);
        public static readonly ItemType BrightPinkDye = new ItemType(1049);
        public static readonly ItemType BlackDye = new ItemType(1050);
        public static readonly ItemType RedandSilverDye = new ItemType(1051);
        public static readonly ItemType OrangeandSilverDye = new ItemType(1052);
        public static readonly ItemType YellowandSilverDye = new ItemType(1053);
        public static readonly ItemType LimeandSilverDye = new ItemType(1054);
        public static readonly ItemType GreenandSilverDye = new ItemType(1055);
        public static readonly ItemType TealandSilverDye = new ItemType(1056);
        public static readonly ItemType CyanandSilverDye = new ItemType(1057);
        public static readonly ItemType SkyBlueandSilverDye = new ItemType(1058);
        public static readonly ItemType BlueandSilverDye = new ItemType(1059);
        public static readonly ItemType PurpleandSilverDye = new ItemType(1060);
        public static readonly ItemType VioletandSilverDye = new ItemType(1061);
        public static readonly ItemType PinkandSilverDye = new ItemType(1062);
        public static readonly ItemType IntenseFlameDye = new ItemType(1063);
        public static readonly ItemType IntenseGreenFlameDye = new ItemType(1064);
        public static readonly ItemType IntenseBlueFlameDye = new ItemType(1065);
        public static readonly ItemType RainbowDye = new ItemType(1066);
        public static readonly ItemType IntenseRainbowDye = new ItemType(1067);
        public static readonly ItemType YellowGradientDye = new ItemType(1068);
        public static readonly ItemType CyanGradientDye = new ItemType(1069);
        public static readonly ItemType VioletGradientDye = new ItemType(1070);
        public static readonly ItemType Paintbrush = new ItemType(1071);
        public static readonly ItemType PaintRoller = new ItemType(1072);
        public static readonly ItemType RedPaint = new ItemType(1073);
        public static readonly ItemType OrangePaint = new ItemType(1074);
        public static readonly ItemType YellowPaint = new ItemType(1075);
        public static readonly ItemType LimePaint = new ItemType(1076);
        public static readonly ItemType GreenPaint = new ItemType(1077);
        public static readonly ItemType TealPaint = new ItemType(1078);
        public static readonly ItemType CyanPaint = new ItemType(1079);
        public static readonly ItemType SkyBluePaint = new ItemType(1080);
        public static readonly ItemType BluePaint = new ItemType(1081);
        public static readonly ItemType PurplePaint = new ItemType(1082);
        public static readonly ItemType VioletPaint = new ItemType(1083);
        public static readonly ItemType PinkPaint = new ItemType(1084);
        public static readonly ItemType DeepRedPaint = new ItemType(1085);
        public static readonly ItemType DeepOrangePaint = new ItemType(1086);
        public static readonly ItemType DeepYellowPaint = new ItemType(1087);
        public static readonly ItemType DeepLimePaint = new ItemType(1088);
        public static readonly ItemType DeepGreenPaint = new ItemType(1089);
        public static readonly ItemType DeepTealPaint = new ItemType(1090);
        public static readonly ItemType DeepCyanPaint = new ItemType(1091);
        public static readonly ItemType DeepSkyBluePaint = new ItemType(1092);
        public static readonly ItemType DeepBluePaint = new ItemType(1093);
        public static readonly ItemType DeepPurplePaint = new ItemType(1094);
        public static readonly ItemType DeepVioletPaint = new ItemType(1095);
        public static readonly ItemType DeepPinkPaint = new ItemType(1096);
        public static readonly ItemType BlackPaint = new ItemType(1097);
        public static readonly ItemType WhitePaint = new ItemType(1098);
        public static readonly ItemType GrayPaint = new ItemType(1099);
        public static readonly ItemType PaintScraper = new ItemType(1100);
        public static readonly ItemType LihzahrdBrick = new ItemType(1101);
        public static readonly ItemType LihzahrdBrickWall = new ItemType(1102);
        public static readonly ItemType SlushBlock = new ItemType(1103);
        public static readonly ItemType PalladiumOre = new ItemType(1104);
        public static readonly ItemType OrichalcumOre = new ItemType(1105);
        public static readonly ItemType TitaniumOre = new ItemType(1106);
        public static readonly ItemType TealMushroom = new ItemType(1107);
        public static readonly ItemType GreenMushroom = new ItemType(1108);
        public static readonly ItemType SkyBlueFlower = new ItemType(1109);
        public static readonly ItemType YellowMarigold = new ItemType(1110);
        public static readonly ItemType BlueBerries = new ItemType(1111);
        public static readonly ItemType LimeKelp = new ItemType(1112);
        public static readonly ItemType PinkPricklyPear = new ItemType(1113);
        public static readonly ItemType OrangeBloodroot = new ItemType(1114);
        public static readonly ItemType RedHusk = new ItemType(1115);
        public static readonly ItemType CyanHusk = new ItemType(1116);
        public static readonly ItemType VioletHusk = new ItemType(1117);
        public static readonly ItemType PurpleMucos = new ItemType(1118);
        public static readonly ItemType BlackInk = new ItemType(1119);
        public static readonly ItemType DyeVat = new ItemType(1120);
        public static readonly ItemType BeeGun = new ItemType(1121);
        public static readonly ItemType PossessedHatchet = new ItemType(1122);
        public static readonly ItemType BeeKeeper = new ItemType(1123);
        public static readonly ItemType Hive = new ItemType(1124);
        public static readonly ItemType HoneyBlock = new ItemType(1125);
        public static readonly ItemType HiveWall = new ItemType(1126);
        public static readonly ItemType CrispyHoneyBlock = new ItemType(1127);
        public static readonly ItemType HoneyBucket = new ItemType(1128);
        public static readonly ItemType HiveWand = new ItemType(1129);
        public static readonly ItemType Beenade = new ItemType(1130);
        public static readonly ItemType GravityGlobe = new ItemType(1131);
        public static readonly ItemType HoneyComb = new ItemType(1132);
        public static readonly ItemType Abeemination = new ItemType(1133);
        public static readonly ItemType BottledHoney = new ItemType(1134);
        public static readonly ItemType RainHat = new ItemType(1135);
        public static readonly ItemType RainCoat = new ItemType(1136);
        public static readonly ItemType LihzahrdDoor = new ItemType(1137);
        public static readonly ItemType DungeonDoor = new ItemType(1138);
        public static readonly ItemType LeadDoor = new ItemType(1139);
        public static readonly ItemType IronDoor = new ItemType(1140);
        public static readonly ItemType TempleKey = new ItemType(1141);
        public static readonly ItemType LihzahrdChest = new ItemType(1142);
        public static readonly ItemType LihzahrdChair = new ItemType(1143);
        public static readonly ItemType LihzahrdTable = new ItemType(1144);
        public static readonly ItemType LihzahrdWorkBench = new ItemType(1145);
        public static readonly ItemType SuperDartTrap = new ItemType(1146);
        public static readonly ItemType FlameTrap = new ItemType(1147);
        public static readonly ItemType SpikyBallTrap = new ItemType(1148);
        public static readonly ItemType SpearTrap = new ItemType(1149);
        public static readonly ItemType WoodenSpike = new ItemType(1150);
        public static readonly ItemType LihzahrdPressurePlate = new ItemType(1151);
        public static readonly ItemType LihzahrdStatue = new ItemType(1152);
        public static readonly ItemType LihzahrdWatcherStatue = new ItemType(1153);
        public static readonly ItemType LihzahrdGuardianStatue = new ItemType(1154);
        public static readonly ItemType WaspGun = new ItemType(1155);
        public static readonly ItemType PiranhaGun = new ItemType(1156);
        public static readonly ItemType PygmyStaff = new ItemType(1157);
        public static readonly ItemType PygmyNecklace = new ItemType(1158);
        public static readonly ItemType TikiMask = new ItemType(1159);
        public static readonly ItemType TikiShirt = new ItemType(1160);
        public static readonly ItemType TikiPants = new ItemType(1161);
        public static readonly ItemType LeafWings = new ItemType(1162);
        public static readonly ItemType BlizzardInABalloon = new ItemType(1163);
        public static readonly ItemType BundleOfBalloons = new ItemType(1164);
        public static readonly ItemType BatWings = new ItemType(1165);
        public static readonly ItemType BoneSword = new ItemType(1166);
        public static readonly ItemType HerculesBeetle = new ItemType(1167);
        public static readonly ItemType SmokeBomb = new ItemType(1168);
        public static readonly ItemType BoneKey = new ItemType(1169);
        public static readonly ItemType Nectar = new ItemType(1170);
        public static readonly ItemType TikiTotem = new ItemType(1171);
        public static readonly ItemType LizardEgg = new ItemType(1172);
        public static readonly ItemType GraveMarker = new ItemType(1173);
        public static readonly ItemType CrossGraveMarker = new ItemType(1174);
        public static readonly ItemType Headstone = new ItemType(1175);
        public static readonly ItemType Gravestone = new ItemType(1176);
        public static readonly ItemType Obelisk = new ItemType(1177);
        public static readonly ItemType LeafBlower = new ItemType(1178);
        public static readonly ItemType ChlorophyteBullet = new ItemType(1179);
        public static readonly ItemType ParrotCracker = new ItemType(1180);
        public static readonly ItemType StrangeGlowingMushroom = new ItemType(1181);
        public static readonly ItemType Seedling = new ItemType(1182);
        public static readonly ItemType WispInABottle = new ItemType(1183);
        public static readonly ItemType PalladiumBar = new ItemType(1184);
        public static readonly ItemType PalladiumSword = new ItemType(1185);
        public static readonly ItemType PalladiumPike = new ItemType(1186);
        public static readonly ItemType PalladiumRepeater = new ItemType(1187);
        public static readonly ItemType PalladiumPickaxe = new ItemType(1188);
        public static readonly ItemType PalladiumDrill = new ItemType(1189);
        public static readonly ItemType PalladiumChainsaw = new ItemType(1190);
        public static readonly ItemType OrichalcumBar = new ItemType(1191);
        public static readonly ItemType OrichalcumSword = new ItemType(1192);
        public static readonly ItemType OrichalcumHalberd = new ItemType(1193);
        public static readonly ItemType OrichalcumRepeater = new ItemType(1194);
        public static readonly ItemType OrichalcumPickaxe = new ItemType(1195);
        public static readonly ItemType OrichalcumDrill = new ItemType(1196);
        public static readonly ItemType OrichalcumChainsaw = new ItemType(1197);
        public static readonly ItemType TitaniumBar = new ItemType(1198);
        public static readonly ItemType TitaniumSword = new ItemType(1199);
        public static readonly ItemType TitaniumTrident = new ItemType(1200);
        public static readonly ItemType TitaniumRepeater = new ItemType(1201);
        public static readonly ItemType TitaniumPickaxe = new ItemType(1202);
        public static readonly ItemType TitaniumDrill = new ItemType(1203);
        public static readonly ItemType TitaniumChainsaw = new ItemType(1204);
        public static readonly ItemType PalladiumMask = new ItemType(1205);
        public static readonly ItemType PalladiumHelmet = new ItemType(1206);
        public static readonly ItemType PalladiumHeadgear = new ItemType(1207);
        public static readonly ItemType PalladiumBreastplate = new ItemType(1208);
        public static readonly ItemType PalladiumLeggings = new ItemType(1209);
        public static readonly ItemType OrichalcumMask = new ItemType(1210);
        public static readonly ItemType OrichalcumHelmet = new ItemType(1211);
        public static readonly ItemType OrichalcumHeadgear = new ItemType(1212);
        public static readonly ItemType OrichalcumBreastplate = new ItemType(1213);
        public static readonly ItemType OrichalcumLeggings = new ItemType(1214);
        public static readonly ItemType TitaniumMask = new ItemType(1215);
        public static readonly ItemType TitaniumHelmet = new ItemType(1216);
        public static readonly ItemType TitaniumHeadgear = new ItemType(1217);
        public static readonly ItemType TitaniumBreastplate = new ItemType(1218);
        public static readonly ItemType TitaniumLeggings = new ItemType(1219);
        public static readonly ItemType OrichalcumAnvil = new ItemType(1220);
        public static readonly ItemType TitaniumForge = new ItemType(1221);
        public static readonly ItemType PalladiumWaraxe = new ItemType(1222);
        public static readonly ItemType OrichalcumWaraxe = new ItemType(1223);
        public static readonly ItemType TitaniumWaraxe = new ItemType(1224);
        public static readonly ItemType HallowedBar = new ItemType(1225);
        public static readonly ItemType ChlorophyteClaymore = new ItemType(1226);
        public static readonly ItemType ChlorophyteSaber = new ItemType(1227);
        public static readonly ItemType ChlorophytePartisan = new ItemType(1228);
        public static readonly ItemType ChlorophyteShotbow = new ItemType(1229);
        public static readonly ItemType ChlorophytePickaxe = new ItemType(1230);
        public static readonly ItemType ChlorophyteDrill = new ItemType(1231);
        public static readonly ItemType ChlorophyteChainsaw = new ItemType(1232);
        public static readonly ItemType ChlorophyteGreataxe = new ItemType(1233);
        public static readonly ItemType ChlorophyteWarhammer = new ItemType(1234);
        public static readonly ItemType ChlorophyteArrow = new ItemType(1235);
        public static readonly ItemType AmethystHook = new ItemType(1236);
        public static readonly ItemType TopazHook = new ItemType(1237);
        public static readonly ItemType SapphireHook = new ItemType(1238);
        public static readonly ItemType EmeraldHook = new ItemType(1239);
        public static readonly ItemType RubyHook = new ItemType(1240);
        public static readonly ItemType DiamondHook = new ItemType(1241);
        public static readonly ItemType AmberMosquito = new ItemType(1242);
        public static readonly ItemType UmbrellaHat = new ItemType(1243);
        public static readonly ItemType NimbusRod = new ItemType(1244);
        public static readonly ItemType OrangeTorch = new ItemType(1245);
        public static readonly ItemType CrimsandBlock = new ItemType(1246);
        public static readonly ItemType BeeCloak = new ItemType(1247);
        public static readonly ItemType EyeOfTheGolem = new ItemType(1248);
        public static readonly ItemType HoneyBalloon = new ItemType(1249);
        public static readonly ItemType BlueHorseshoeBalloon = new ItemType(1250);
        public static readonly ItemType WhiteHorseshoeBalloon = new ItemType(1251);
        public static readonly ItemType YellowHorseshoeBalloon = new ItemType(1252);
        public static readonly ItemType FrozenTurtleShell = new ItemType(1253);
        public static readonly ItemType SniperRifle = new ItemType(1254);
        public static readonly ItemType VenusMagnum = new ItemType(1255);
        public static readonly ItemType CrimsonRod = new ItemType(1256);
        public static readonly ItemType CrimtaneBar = new ItemType(1257);
        public static readonly ItemType Stynger = new ItemType(1258);
        public static readonly ItemType FlowerPow = new ItemType(1259);
        public static readonly ItemType RainbowGun = new ItemType(1260);
        public static readonly ItemType StyngerBolt = new ItemType(1261);
        public static readonly ItemType ChlorophyteJackhammer = new ItemType(1262);
        public static readonly ItemType Teleporter = new ItemType(1263);
        public static readonly ItemType FlowerOfFrost = new ItemType(1264);
        public static readonly ItemType Uzi = new ItemType(1265);
        public static readonly ItemType MagnetSphere = new ItemType(1266);
        public static readonly ItemType PurpleStainedGlass = new ItemType(1267);
        public static readonly ItemType YellowStainedGlass = new ItemType(1268);
        public static readonly ItemType BlueStainedGlass = new ItemType(1269);
        public static readonly ItemType GreenStainedGlass = new ItemType(1270);
        public static readonly ItemType RedStainedGlass = new ItemType(1271);
        public static readonly ItemType MulticoloredStainedGlass = new ItemType(1272);
        public static readonly ItemType SkeletronHand = new ItemType(1273);
        public static readonly ItemType Skull = new ItemType(1274);
        public static readonly ItemType BallaHat = new ItemType(1275);
        public static readonly ItemType GangstaHat = new ItemType(1276);
        public static readonly ItemType SailorHat = new ItemType(1277);
        public static readonly ItemType EyePatch = new ItemType(1278);
        public static readonly ItemType SailorShirt = new ItemType(1279);
        public static readonly ItemType SailorPants = new ItemType(1280);
        public static readonly ItemType SkeletronMask = new ItemType(1281);
        public static readonly ItemType AmethystRobe = new ItemType(1282);
        public static readonly ItemType TopazRobe = new ItemType(1283);
        public static readonly ItemType SapphireRobe = new ItemType(1284);
        public static readonly ItemType EmeraldRobe = new ItemType(1285);
        public static readonly ItemType RubyRobe = new ItemType(1286);
        public static readonly ItemType DiamondRobe = new ItemType(1287);
        public static readonly ItemType WhiteTuxedoShirt = new ItemType(1288);
        public static readonly ItemType WhiteTuxedoPants = new ItemType(1289);
        public static readonly ItemType PanicNecklace = new ItemType(1290);
        public static readonly ItemType LifeFruit = new ItemType(1291);
        public static readonly ItemType LihzahrdAltar = new ItemType(1292);
        public static readonly ItemType LihzahrdPowerCell = new ItemType(1293);
        public static readonly ItemType Picksaw = new ItemType(1294);
        public static readonly ItemType HeatRay = new ItemType(1295);
        public static readonly ItemType StaffOfEarth = new ItemType(1296);
        public static readonly ItemType GolemFist = new ItemType(1297);
        public static readonly ItemType WaterChest = new ItemType(1298);
        public static readonly ItemType Binoculars = new ItemType(1299);
        public static readonly ItemType RifleScope = new ItemType(1300);
        public static readonly ItemType DestroyerEmblem = new ItemType(1301);
        public static readonly ItemType HighVelocityBullet = new ItemType(1302);
        public static readonly ItemType JellyfishNecklace = new ItemType(1303);
        public static readonly ItemType ZombieArm = new ItemType(1304);
        public static readonly ItemType TheAxe = new ItemType(1305);
        public static readonly ItemType IceSickle = new ItemType(1306);
        public static readonly ItemType ClothierVoodooDoll = new ItemType(1307);
        public static readonly ItemType PoisonStaff = new ItemType(1308);
        public static readonly ItemType SlimeStaff = new ItemType(1309);
        public static readonly ItemType PoisonDart = new ItemType(1310);
        public static readonly ItemType EyeSpring = new ItemType(1311);
        public static readonly ItemType ToySled = new ItemType(1312);
        public static readonly ItemType BookOfSkulls = new ItemType(1313);
        public static readonly ItemType KoCannon = new ItemType(1314);
        public static readonly ItemType PirateMap = new ItemType(1315);
        public static readonly ItemType TurtleHelmet = new ItemType(1316);
        public static readonly ItemType TurtleScaleMail = new ItemType(1317);
        public static readonly ItemType TurtleLeggings = new ItemType(1318);
        public static readonly ItemType SnowballCannon = new ItemType(1319);
        public static readonly ItemType BonePickaxe = new ItemType(1320);
        public static readonly ItemType MagicQuiver = new ItemType(1321);
        public static readonly ItemType MagmaStone = new ItemType(1322);
        public static readonly ItemType ObsidianRose = new ItemType(1323);
        public static readonly ItemType Bananarang = new ItemType(1324);
        public static readonly ItemType ChainKnife = new ItemType(1325);
        public static readonly ItemType RodOfDiscord = new ItemType(1326);
        public static readonly ItemType DeathSickle = new ItemType(1327);
        public static readonly ItemType TurtleShell = new ItemType(1328);
        public static readonly ItemType TissueSample = new ItemType(1329);
        public static readonly ItemType Vertebrae = new ItemType(1330);
        public static readonly ItemType BloodySpine = new ItemType(1331);
        public static readonly ItemType Ichor = new ItemType(1332);
        public static readonly ItemType IchorTorch = new ItemType(1333);
        public static readonly ItemType IchorArrow = new ItemType(1334);
        public static readonly ItemType IchorBullet = new ItemType(1335);
        public static readonly ItemType GoldenShower = new ItemType(1336);
        public static readonly ItemType BunnyCannon = new ItemType(1337);
        public static readonly ItemType ExplosiveBunny = new ItemType(1338);
        public static readonly ItemType VialOfVenom = new ItemType(1339);
        public static readonly ItemType FlaskOfVenom = new ItemType(1340);
        public static readonly ItemType VenomArrow = new ItemType(1341);
        public static readonly ItemType VenomBullet = new ItemType(1342);
        public static readonly ItemType FireGauntlet = new ItemType(1343);
        public static readonly ItemType Cog = new ItemType(1344);
        public static readonly ItemType Confetti = new ItemType(1345);
        public static readonly ItemType Nanites = new ItemType(1346);
        public static readonly ItemType ExplosivePowder = new ItemType(1347);
        public static readonly ItemType GoldDust = new ItemType(1348);
        public static readonly ItemType PartyBullet = new ItemType(1349);
        public static readonly ItemType NanoBullet = new ItemType(1350);
        public static readonly ItemType ExplodingBullet = new ItemType(1351);
        public static readonly ItemType GoldenBullet = new ItemType(1352);
        public static readonly ItemType FlaskOfCursedFlames = new ItemType(1353);
        public static readonly ItemType FlaskOfFire = new ItemType(1354);
        public static readonly ItemType FlaskOfGold = new ItemType(1355);
        public static readonly ItemType FlaskOfIchor = new ItemType(1356);
        public static readonly ItemType FlaskOfNanites = new ItemType(1357);
        public static readonly ItemType FlaskOfParty = new ItemType(1358);
        public static readonly ItemType FlaskOfPoison = new ItemType(1359);
        public static readonly ItemType EyeOfCthulhuTrophy = new ItemType(1360);
        public static readonly ItemType EaterOfWorldsTrophy = new ItemType(1361);
        public static readonly ItemType BrainOfCthulhuTrophy = new ItemType(1362);
        public static readonly ItemType SkeletronTrophy = new ItemType(1363);
        public static readonly ItemType QueenBeeTrophy = new ItemType(1364);
        public static readonly ItemType WallOfFleshTrophy = new ItemType(1365);
        public static readonly ItemType DestroyerTrophy = new ItemType(1366);
        public static readonly ItemType SkeletronPrimeTrophy = new ItemType(1367);
        public static readonly ItemType RetinazerTrophy = new ItemType(1368);
        public static readonly ItemType SpazmatismTrophy = new ItemType(1369);
        public static readonly ItemType PlanteraTrophy = new ItemType(1370);
        public static readonly ItemType GolemTrophy = new ItemType(1371);
        public static readonly ItemType BloodMoonRising = new ItemType(1372);
        public static readonly ItemType TheHangedMan = new ItemType(1373);
        public static readonly ItemType GloryOfTheFire = new ItemType(1374);
        public static readonly ItemType BoneWarp = new ItemType(1375);
        public static readonly ItemType WallSkeleton = new ItemType(1376);
        public static readonly ItemType HangingSkeleton = new ItemType(1377);
        public static readonly ItemType BlueSlabWall = new ItemType(1378);
        public static readonly ItemType BlueTiledWall = new ItemType(1379);
        public static readonly ItemType PinkSlabWall = new ItemType(1380);
        public static readonly ItemType PinkTiledWall = new ItemType(1381);
        public static readonly ItemType GreenSlabWall = new ItemType(1382);
        public static readonly ItemType GreenTiledWall = new ItemType(1383);
        public static readonly ItemType BlueBrickPlatform = new ItemType(1384);
        public static readonly ItemType PinkBrickPlatform = new ItemType(1385);
        public static readonly ItemType GreenBrickPlatform = new ItemType(1386);
        public static readonly ItemType MetalShelf = new ItemType(1387);
        public static readonly ItemType BrassShelf = new ItemType(1388);
        public static readonly ItemType WoodShelf = new ItemType(1389);
        public static readonly ItemType BrassLantern = new ItemType(1390);
        public static readonly ItemType CagedLantern = new ItemType(1391);
        public static readonly ItemType CarriageLantern = new ItemType(1392);
        public static readonly ItemType AlchemyLantern = new ItemType(1393);
        public static readonly ItemType DiabolistLamp = new ItemType(1394);
        public static readonly ItemType OilRagSconse = new ItemType(1395);
        public static readonly ItemType BlueDungeonChair = new ItemType(1396);
        public static readonly ItemType BlueDungeonTable = new ItemType(1397);
        public static readonly ItemType BlueDungeonWorkBench = new ItemType(1398);
        public static readonly ItemType GreenDungeonChair = new ItemType(1399);
        public static readonly ItemType GreenDungeonTable = new ItemType(1400);
        public static readonly ItemType GreenDungeonWorkBench = new ItemType(1401);
        public static readonly ItemType PinkDungeonChair = new ItemType(1402);
        public static readonly ItemType PinkDungeonTable = new ItemType(1403);
        public static readonly ItemType PinkDungeonWorkBench = new ItemType(1404);
        public static readonly ItemType BlueDungeonCandle = new ItemType(1405);
        public static readonly ItemType GreenDungeonCandle = new ItemType(1406);
        public static readonly ItemType PinkDungeonCandle = new ItemType(1407);
        public static readonly ItemType BlueDungeonVase = new ItemType(1408);
        public static readonly ItemType GreenDungeonVase = new ItemType(1409);
        public static readonly ItemType PinkDungeonVase = new ItemType(1410);
        public static readonly ItemType BlueDungeonDoor = new ItemType(1411);
        public static readonly ItemType GreenDungeonDoor = new ItemType(1412);
        public static readonly ItemType PinkDungeonDoor = new ItemType(1413);
        public static readonly ItemType BlueDungeonBookcase = new ItemType(1414);
        public static readonly ItemType GreenDungeonBookcase = new ItemType(1415);
        public static readonly ItemType PinkDungeonBookcase = new ItemType(1416);
        public static readonly ItemType Catacomb = new ItemType(1417);
        public static readonly ItemType DungeonShelf = new ItemType(1418);
        public static readonly ItemType SkellingtonJSkellingsworth = new ItemType(1419);
        public static readonly ItemType TheCursedMan = new ItemType(1420);
        public static readonly ItemType TheEyeSeesTheEnd = new ItemType(1421);
        public static readonly ItemType SomethingEvilIsWatchingYou = new ItemType(1422);
        public static readonly ItemType TheTwinsHaveAwoken = new ItemType(1423);
        public static readonly ItemType TheScreamer = new ItemType(1424);
        public static readonly ItemType GoblinsPlayingPoker = new ItemType(1425);
        public static readonly ItemType Dryadisque = new ItemType(1426);
        public static readonly ItemType Sunflowers = new ItemType(1427);
        public static readonly ItemType TerrarianGothic = new ItemType(1428);
        public static readonly ItemType Beanie = new ItemType(1429);
        public static readonly ItemType ImbuingStation = new ItemType(1430);
        public static readonly ItemType StarInABottle = new ItemType(1431);
        public static readonly ItemType EmptyBullet = new ItemType(1432);
        public static readonly ItemType Impact = new ItemType(1433);
        public static readonly ItemType PoweredByBirds = new ItemType(1434);
        public static readonly ItemType TheDestroyer = new ItemType(1435);
        public static readonly ItemType ThePersistencyOfEyes = new ItemType(1436);
        public static readonly ItemType UnicornCrossingTheHallows = new ItemType(1437);
        public static readonly ItemType GreatWave = new ItemType(1438);
        public static readonly ItemType StarryNight = new ItemType(1439);
        public static readonly ItemType GuidePicasso = new ItemType(1440);
        public static readonly ItemType TheGuardiansGaze = new ItemType(1441);
        public static readonly ItemType FatherOfSomeone = new ItemType(1442);
        public static readonly ItemType NurseLisa = new ItemType(1443);
        public static readonly ItemType ShadowbeamStaff = new ItemType(1444);
        public static readonly ItemType InfernoFork = new ItemType(1445);
        public static readonly ItemType SpectreStaff = new ItemType(1446);
        public static readonly ItemType WoodenFence = new ItemType(1447);
        public static readonly ItemType LeadFence = new ItemType(1448);
        public static readonly ItemType BubbleMachine = new ItemType(1449);
        public static readonly ItemType BubbleWand = new ItemType(1450);
        public static readonly ItemType MarchingBonesBanner = new ItemType(1451);
        public static readonly ItemType NecromanticSign = new ItemType(1452);
        public static readonly ItemType RustedCompanyStandard = new ItemType(1453);
        public static readonly ItemType RaggedBrotherhoodSigil = new ItemType(1454);
        public static readonly ItemType MoltenLegionFlag = new ItemType(1455);
        public static readonly ItemType DiabolicSigil = new ItemType(1456);
        public static readonly ItemType ObsidianPlatform = new ItemType(1457);
        public static readonly ItemType ObsidianDoor = new ItemType(1458);
        public static readonly ItemType ObsidianChair = new ItemType(1459);
        public static readonly ItemType ObsidianTable = new ItemType(1460);
        public static readonly ItemType ObsidianWorkBench = new ItemType(1461);
        public static readonly ItemType ObsidianVase = new ItemType(1462);
        public static readonly ItemType ObsidianBookcase = new ItemType(1463);
        public static readonly ItemType HellboundBanner = new ItemType(1464);
        public static readonly ItemType HellHammerBanner = new ItemType(1465);
        public static readonly ItemType HelltowerBanner = new ItemType(1466);
        public static readonly ItemType LostHopesOfManBanner = new ItemType(1467);
        public static readonly ItemType ObsidianWatcherBanner = new ItemType(1468);
        public static readonly ItemType LavaEruptsBanner = new ItemType(1469);
        public static readonly ItemType BlueDungeonBed = new ItemType(1470);
        public static readonly ItemType GreenDungeonBed = new ItemType(1471);
        public static readonly ItemType PinkDungeonBed = new ItemType(1472);
        public static readonly ItemType ObsidianBed = new ItemType(1473);
        public static readonly ItemType Waldo = new ItemType(1474);
        public static readonly ItemType Darkness = new ItemType(1475);
        public static readonly ItemType DarkSoulReaper = new ItemType(1476);
        public static readonly ItemType Land = new ItemType(1477);
        public static readonly ItemType TrappedGhost = new ItemType(1478);
        public static readonly ItemType DemonsEye = new ItemType(1479);
        public static readonly ItemType FindingGold = new ItemType(1480);
        public static readonly ItemType FirstEncounter = new ItemType(1481);
        public static readonly ItemType GoodMorning = new ItemType(1482);
        public static readonly ItemType UndergroundReward = new ItemType(1483);
        public static readonly ItemType ThroughTheWindow = new ItemType(1484);
        public static readonly ItemType PlaceAboveTheClouds = new ItemType(1485);
        public static readonly ItemType DoNotStepOnTheGrass = new ItemType(1486);
        public static readonly ItemType ColdWatersInTheWhiteLand = new ItemType(1487);
        public static readonly ItemType LightlessChasms = new ItemType(1488);
        public static readonly ItemType TheLandOfDeceivingLooks = new ItemType(1489);
        public static readonly ItemType Daylight = new ItemType(1490);
        public static readonly ItemType SecretOfTheSands = new ItemType(1491);
        public static readonly ItemType DeadlandComesAlive = new ItemType(1492);
        public static readonly ItemType EvilPresence = new ItemType(1493);
        public static readonly ItemType SkyGuardian = new ItemType(1494);
        public static readonly ItemType AmericanExplosive = new ItemType(1495);
        public static readonly ItemType Discover = new ItemType(1496);
        public static readonly ItemType HandEarth = new ItemType(1497);
        public static readonly ItemType OldMiner = new ItemType(1498);
        public static readonly ItemType Skelehead = new ItemType(1499);
        public static readonly ItemType FacingTheCerebralMastermind = new ItemType(1500);
        public static readonly ItemType LakeOfFire = new ItemType(1501);
        public static readonly ItemType TrioSuperHeroes = new ItemType(1502);
        public static readonly ItemType SpectreHood = new ItemType(1503);
        public static readonly ItemType SpectreRobe = new ItemType(1504);
        public static readonly ItemType SpectrePants = new ItemType(1505);
        public static readonly ItemType SpectrePickaxe = new ItemType(1506);
        public static readonly ItemType SpectreHamaxe = new ItemType(1507);
        public static readonly ItemType Ectoplasm = new ItemType(1508);
        public static readonly ItemType GothicChair = new ItemType(1509);
        public static readonly ItemType GothicTable = new ItemType(1510);
        public static readonly ItemType GothicWorkBench = new ItemType(1511);
        public static readonly ItemType GothicBookcase = new ItemType(1512);
        public static readonly ItemType PaladinsHammer = new ItemType(1513);
        public static readonly ItemType SwatHelmet = new ItemType(1514);
        public static readonly ItemType BeeWings = new ItemType(1515);
        public static readonly ItemType GiantHarpyFeather = new ItemType(1516);
        public static readonly ItemType BoneFeather = new ItemType(1517);
        public static readonly ItemType FireFeather = new ItemType(1518);
        public static readonly ItemType IceFeather = new ItemType(1519);
        public static readonly ItemType BrokenBatWing = new ItemType(1520);
        public static readonly ItemType TatteredBeeWing = new ItemType(1521);
        public static readonly ItemType LargeAmethyst = new ItemType(1522);
        public static readonly ItemType LargeTopaz = new ItemType(1523);
        public static readonly ItemType LargeSapphire = new ItemType(1524);
        public static readonly ItemType LargeEmerald = new ItemType(1525);
        public static readonly ItemType LargeRuby = new ItemType(1526);
        public static readonly ItemType LargeDiamond = new ItemType(1527);
        public static readonly ItemType JungleChest = new ItemType(1528);
        public static readonly ItemType CorruptionChest = new ItemType(1529);
        public static readonly ItemType CrimsonChest = new ItemType(1530);
        public static readonly ItemType HallowedChest = new ItemType(1531);
        public static readonly ItemType FrozenChest = new ItemType(1532);
        public static readonly ItemType JungleKey = new ItemType(1533);
        public static readonly ItemType CorruptionKey = new ItemType(1534);
        public static readonly ItemType CrimsonKey = new ItemType(1535);
        public static readonly ItemType HallowedKey = new ItemType(1536);
        public static readonly ItemType FrozenKey = new ItemType(1537);
        public static readonly ItemType ImpFace = new ItemType(1538);
        public static readonly ItemType OminousPresence = new ItemType(1539);
        public static readonly ItemType ShiningMoon = new ItemType(1540);
        public static readonly ItemType LivingGore = new ItemType(1541);
        public static readonly ItemType FlowingMagma = new ItemType(1542);
        public static readonly ItemType SpectrePaintbrush = new ItemType(1543);
        public static readonly ItemType SpectrePaintRoller = new ItemType(1544);
        public static readonly ItemType SpectrePaintScraper = new ItemType(1545);
        public static readonly ItemType ShroomiteHeadgear = new ItemType(1546);
        public static readonly ItemType ShroomiteMask = new ItemType(1547);
        public static readonly ItemType ShroomiteHelmet = new ItemType(1548);
        public static readonly ItemType ShroomiteBreastplate = new ItemType(1549);
        public static readonly ItemType ShroomiteLeggings = new ItemType(1550);
        public static readonly ItemType Autohammer = new ItemType(1551);
        public static readonly ItemType ShroomiteBar = new ItemType(1552);
        public static readonly ItemType Sdmg = new ItemType(1553);
        public static readonly ItemType CenxsTiara = new ItemType(1554);
        public static readonly ItemType CenxsBreastplate = new ItemType(1555);
        public static readonly ItemType CenxsLeggings = new ItemType(1556);
        public static readonly ItemType CrownosMask = new ItemType(1557);
        public static readonly ItemType CrownosBreastplate = new ItemType(1558);
        public static readonly ItemType CrownosLeggings = new ItemType(1559);
        public static readonly ItemType WillsHelmet = new ItemType(1560);
        public static readonly ItemType WillsBreastplate = new ItemType(1561);
        public static readonly ItemType WillsLeggings = new ItemType(1562);
        public static readonly ItemType JimsHelmet = new ItemType(1563);
        public static readonly ItemType JimsBreastplate = new ItemType(1564);
        public static readonly ItemType JimsLeggings = new ItemType(1565);
        public static readonly ItemType AaronsHelmet = new ItemType(1566);
        public static readonly ItemType AaronsBreastplate = new ItemType(1567);
        public static readonly ItemType AaronsLeggings = new ItemType(1568);
        public static readonly ItemType VampireKnives = new ItemType(1569);
        public static readonly ItemType BrokenHeroSword = new ItemType(1570);
        public static readonly ItemType ScourgeOfTheCorruptor = new ItemType(1571);
        public static readonly ItemType StaffOfTheFrostHydra = new ItemType(1572);
        public static readonly ItemType TheCreationOfTheGuide = new ItemType(1573);
        public static readonly ItemType TheMerchant = new ItemType(1574);
        public static readonly ItemType CrownoDevoursHisLunch = new ItemType(1575);
        public static readonly ItemType RareEnchantment = new ItemType(1576);
        public static readonly ItemType GloriousNight = new ItemType(1577);
        public static readonly ItemType SweetheartNecklace = new ItemType(1578);
        public static readonly ItemType FlurryBoots = new ItemType(1579);
        public static readonly ItemType DTownsHelmet = new ItemType(1580);
        public static readonly ItemType DTownsBreastplate = new ItemType(1581);
        public static readonly ItemType DTownsLeggings = new ItemType(1582);
        public static readonly ItemType DTownsWings = new ItemType(1583);
        public static readonly ItemType WillsWings = new ItemType(1584);
        public static readonly ItemType CrownosWings = new ItemType(1585);
        public static readonly ItemType CenxsWings = new ItemType(1586);
        public static readonly ItemType CenxsDress = new ItemType(1587);
        public static readonly ItemType CenxsDressPants = new ItemType(1588);
        public static readonly ItemType PalladiumColumn = new ItemType(1589);
        public static readonly ItemType PalladiumColumnWall = new ItemType(1590);
        public static readonly ItemType BubblegumBlock = new ItemType(1591);
        public static readonly ItemType BubblegumBlockWall = new ItemType(1592);
        public static readonly ItemType TitanstoneBlock = new ItemType(1593);
        public static readonly ItemType TitanstoneBlockWall = new ItemType(1594);
        public static readonly ItemType MagicCuffs = new ItemType(1595);
        public static readonly ItemType MusicBoxSnow = new ItemType(1596);
        public static readonly ItemType MusicBoxSpace = new ItemType(1597);
        public static readonly ItemType MusicBoxCrimson = new ItemType(1598);
        public static readonly ItemType MusicBoxBoss4 = new ItemType(1599);
        public static readonly ItemType MusicBoxAltOverworldDay = new ItemType(1600);
        public static readonly ItemType MusicBoxRain = new ItemType(1601);
        public static readonly ItemType MusicBoxIce = new ItemType(1602);
        public static readonly ItemType MusicBoxDesert = new ItemType(1603);
        public static readonly ItemType MusicBoxOcean = new ItemType(1604);
        public static readonly ItemType MusicBoxDungeon = new ItemType(1605);
        public static readonly ItemType MusicBoxPlantera = new ItemType(1606);
        public static readonly ItemType MusicBoxBoss5 = new ItemType(1607);
        public static readonly ItemType MusicBoxTemple = new ItemType(1608);
        public static readonly ItemType MusicBoxEclipse = new ItemType(1609);
        public static readonly ItemType MusicBoxMushrooms = new ItemType(1610);
        public static readonly ItemType ButterflyDust = new ItemType(1611);
        public static readonly ItemType AnkhCharm = new ItemType(1612);
        public static readonly ItemType AnkhShield = new ItemType(1613);
        public static readonly ItemType BlueFlare = new ItemType(1614);
        public static readonly ItemType AnglerFishBanner = new ItemType(1615);
        public static readonly ItemType AngryNimbusBanner = new ItemType(1616);
        public static readonly ItemType AnomuraFungusBanner = new ItemType(1617);
        public static readonly ItemType AntlionBanner = new ItemType(1618);
        public static readonly ItemType ArapaimaBanner = new ItemType(1619);
        public static readonly ItemType ArmoredSkeletonBanner = new ItemType(1620);
        public static readonly ItemType CaveBatBanner = new ItemType(1621);
        public static readonly ItemType BirdBanner = new ItemType(1622);
        public static readonly ItemType BlackRecluseBanner = new ItemType(1623);
        public static readonly ItemType BloodFeederBanner = new ItemType(1624);
        public static readonly ItemType BloodJellyBanner = new ItemType(1625);
        public static readonly ItemType BloodCrawlerBanner = new ItemType(1626);
        public static readonly ItemType BoneSerpentBanner = new ItemType(1627);
        public static readonly ItemType BunnyBanner = new ItemType(1628);
        public static readonly ItemType ChaosElementalBanner = new ItemType(1629);
        public static readonly ItemType MimicBanner = new ItemType(1630);
        public static readonly ItemType ClownBanner = new ItemType(1631);
        public static readonly ItemType CorruptBunnyBanner = new ItemType(1632);
        public static readonly ItemType CorruptGoldfishBanner = new ItemType(1633);
        public static readonly ItemType CrabBanner = new ItemType(1634);
        public static readonly ItemType CrimeraBanner = new ItemType(1635);
        public static readonly ItemType CrimsonAxeBanner = new ItemType(1636);
        public static readonly ItemType CursedHammerBanner = new ItemType(1637);
        public static readonly ItemType DemonBanner = new ItemType(1638);
        public static readonly ItemType DemonEyeBanner = new ItemType(1639);
        public static readonly ItemType DerplingBanner = new ItemType(1640);
        public static readonly ItemType EaterOfSoulsBanner = new ItemType(1641);
        public static readonly ItemType EnchantedSwordBanner = new ItemType(1642);
        public static readonly ItemType ZombieEskimoBanner = new ItemType(1643);
        public static readonly ItemType FaceMonsterBanner = new ItemType(1644);
        public static readonly ItemType FloatyGrossBanner = new ItemType(1645);
        public static readonly ItemType FlyingFishBanner = new ItemType(1646);
        public static readonly ItemType FlyingSnakeBanner = new ItemType(1647);
        public static readonly ItemType FrankensteinBanner = new ItemType(1648);
        public static readonly ItemType FungiBulbBanner = new ItemType(1649);
        public static readonly ItemType FungoFishBanner = new ItemType(1650);
        public static readonly ItemType GastropodBanner = new ItemType(1651);
        public static readonly ItemType GoblinThiefBanner = new ItemType(1652);
        public static readonly ItemType GoblinSorcererBanner = new ItemType(1653);
        public static readonly ItemType GoblinPeonBanner = new ItemType(1654);
        public static readonly ItemType GoblinScoutBanner = new ItemType(1655);
        public static readonly ItemType GoblinWarriorBanner = new ItemType(1656);
        public static readonly ItemType GoldfishBanner = new ItemType(1657);
        public static readonly ItemType HarpyBanner = new ItemType(1658);
        public static readonly ItemType HellbatBanner = new ItemType(1659);
        public static readonly ItemType HerplingBanner = new ItemType(1660);
        public static readonly ItemType HornetBanner = new ItemType(1661);
        public static readonly ItemType IceElementalBanner = new ItemType(1662);
        public static readonly ItemType IcyMermanBanner = new ItemType(1663);
        public static readonly ItemType FireImpBanner = new ItemType(1664);
        public static readonly ItemType BlueJellyfishBanner = new ItemType(1665);
        public static readonly ItemType JungleCreeperBanner = new ItemType(1666);
        public static readonly ItemType LihzahrdBanner = new ItemType(1667);
        public static readonly ItemType ManEaterBanner = new ItemType(1668);
        public static readonly ItemType MeteorHeadBanner = new ItemType(1669);
        public static readonly ItemType MothBanner = new ItemType(1670);
        public static readonly ItemType MummyBanner = new ItemType(1671);
        public static readonly ItemType MushiLadybugBanner = new ItemType(1672);
        public static readonly ItemType ParrotBanner = new ItemType(1673);
        public static readonly ItemType PigronBanner = new ItemType(1674);
        public static readonly ItemType PiranhaBanner = new ItemType(1675);
        public static readonly ItemType PirateDeckhandBanner = new ItemType(1676);
        public static readonly ItemType PixieBanner = new ItemType(1677);
        public static readonly ItemType RaincoatZombieBanner = new ItemType(1678);
        public static readonly ItemType ReaperBanner = new ItemType(1679);
        public static readonly ItemType SharkBanner = new ItemType(1680);
        public static readonly ItemType SkeletonBanner = new ItemType(1681);
        public static readonly ItemType DarkCasterBanner = new ItemType(1682);
        public static readonly ItemType BlueSlimeBanner = new ItemType(1683);
        public static readonly ItemType SnowFlinxBanner = new ItemType(1684);
        public static readonly ItemType WallCreeperBanner = new ItemType(1685);
        public static readonly ItemType SporeZombieBanner = new ItemType(1686);
        public static readonly ItemType SwampThingBanner = new ItemType(1687);
        public static readonly ItemType GiantTortoiseBanner = new ItemType(1688);
        public static readonly ItemType ToxicSludgeBanner = new ItemType(1689);
        public static readonly ItemType UmbrellaSlimeBanner = new ItemType(1690);
        public static readonly ItemType UnicornBanner = new ItemType(1691);
        public static readonly ItemType VampireBanner = new ItemType(1692);
        public static readonly ItemType VultureBanner = new ItemType(1693);
        public static readonly ItemType NymphBanner = new ItemType(1694);
        public static readonly ItemType WerewolfBanner = new ItemType(1695);
        public static readonly ItemType WolfBanner = new ItemType(1696);
        public static readonly ItemType WorldFeederBanner = new ItemType(1697);
        public static readonly ItemType WormBanner = new ItemType(1698);
        public static readonly ItemType WraithBanner = new ItemType(1699);
        public static readonly ItemType WyvernBanner = new ItemType(1700);
        public static readonly ItemType ZombieBanner = new ItemType(1701);
        public static readonly ItemType GlassPlatform = new ItemType(1702);
        public static readonly ItemType GlassChair = new ItemType(1703);
        public static readonly ItemType GoldenChair = new ItemType(1704);
        public static readonly ItemType GoldenToilet = new ItemType(1705);
        public static readonly ItemType BarStool = new ItemType(1706);
        public static readonly ItemType HoneyChair = new ItemType(1707);
        public static readonly ItemType SteampunkChair = new ItemType(1708);
        public static readonly ItemType GlassDoor = new ItemType(1709);
        public static readonly ItemType GoldenDoor = new ItemType(1710);
        public static readonly ItemType HoneyDoor = new ItemType(1711);
        public static readonly ItemType SteampunkDoor = new ItemType(1712);
        public static readonly ItemType GlassTable = new ItemType(1713);
        public static readonly ItemType BanquetTable = new ItemType(1714);
        public static readonly ItemType Bar = new ItemType(1715);
        public static readonly ItemType GoldenTable = new ItemType(1716);
        public static readonly ItemType HoneyTable = new ItemType(1717);
        public static readonly ItemType SteampunkTable = new ItemType(1718);
        public static readonly ItemType GlassBed = new ItemType(1719);
        public static readonly ItemType GoldenBed = new ItemType(1720);
        public static readonly ItemType HoneyBed = new ItemType(1721);
        public static readonly ItemType SteampunkBed = new ItemType(1722);
        public static readonly ItemType LivingWoodWall = new ItemType(1723);
        public static readonly ItemType FartInAJar = new ItemType(1724);
        public static readonly ItemType Pumpkin = new ItemType(1725);
        public static readonly ItemType PumpkinWall = new ItemType(1726);
        public static readonly ItemType Hay = new ItemType(1727);
        public static readonly ItemType HayWall = new ItemType(1728);
        public static readonly ItemType SpookyWood = new ItemType(1729);
        public static readonly ItemType SpookyWoodWall = new ItemType(1730);
        public static readonly ItemType PumpkinHelmet = new ItemType(1731);
        public static readonly ItemType PumpkinBreastplate = new ItemType(1732);
        public static readonly ItemType PumpkinLeggings = new ItemType(1733);
        public static readonly ItemType CandyApple = new ItemType(1734);
        public static readonly ItemType SoulCake = new ItemType(1735);
        public static readonly ItemType NurseHat = new ItemType(1736);
        public static readonly ItemType NurseShirt = new ItemType(1737);
        public static readonly ItemType NursePants = new ItemType(1738);
        public static readonly ItemType WizardsHat = new ItemType(1739);
        public static readonly ItemType GuyFawkesMask = new ItemType(1740);
        public static readonly ItemType DyeTraderRobe = new ItemType(1741);
        public static readonly ItemType SteampunkGoggles = new ItemType(1742);
        public static readonly ItemType CyborgHelmet = new ItemType(1743);
        public static readonly ItemType CyborgShirt = new ItemType(1744);
        public static readonly ItemType CyborgPants = new ItemType(1745);
        public static readonly ItemType CreeperMask = new ItemType(1746);
        public static readonly ItemType CreeperShirt = new ItemType(1747);
        public static readonly ItemType CreeperPants = new ItemType(1748);
        public static readonly ItemType CatMask = new ItemType(1749);
        public static readonly ItemType CatShirt = new ItemType(1750);
        public static readonly ItemType CatPants = new ItemType(1751);
        public static readonly ItemType GhostMask = new ItemType(1752);
        public static readonly ItemType GhostShirt = new ItemType(1753);
        public static readonly ItemType PumpkinMask = new ItemType(1754);
        public static readonly ItemType PumpkinShirt = new ItemType(1755);
        public static readonly ItemType PumpkinPants = new ItemType(1756);
        public static readonly ItemType RobotMask = new ItemType(1757);
        public static readonly ItemType RobotShirt = new ItemType(1758);
        public static readonly ItemType RobotPants = new ItemType(1759);
        public static readonly ItemType UnicornMask = new ItemType(1760);
        public static readonly ItemType UnicornShirt = new ItemType(1761);
        public static readonly ItemType UnicornPants = new ItemType(1762);
        public static readonly ItemType VampireMask = new ItemType(1763);
        public static readonly ItemType VampireShirt = new ItemType(1764);
        public static readonly ItemType VampirePants = new ItemType(1765);
        public static readonly ItemType WitchHat = new ItemType(1766);
        public static readonly ItemType LeprechaunHat = new ItemType(1767);
        public static readonly ItemType LeprechaunShirt = new ItemType(1768);
        public static readonly ItemType LeprechaunPants = new ItemType(1769);
        public static readonly ItemType PixieShirt = new ItemType(1770);
        public static readonly ItemType PixiePants = new ItemType(1771);
        public static readonly ItemType PrincessHat = new ItemType(1772);
        public static readonly ItemType PrincessDressHalloween = new ItemType(1773);
        public static readonly ItemType GoodieBag = new ItemType(1774);
        public static readonly ItemType WitchDress = new ItemType(1775);
        public static readonly ItemType WitchBoots = new ItemType(1776);
        public static readonly ItemType BrideOfFrankensteinMask = new ItemType(1777);
        public static readonly ItemType BrideOfFrankensteinDress = new ItemType(1778);
        public static readonly ItemType KarateTortoiseMask = new ItemType(1779);
        public static readonly ItemType KarateTortoiseShirt = new ItemType(1780);
        public static readonly ItemType KarateTortoisePants = new ItemType(1781);
        public static readonly ItemType CandyCornRifle = new ItemType(1782);
        public static readonly ItemType CandyCorn = new ItemType(1783);
        public static readonly ItemType JackOLanternLauncher = new ItemType(1784);
        public static readonly ItemType ExplosiveJackOLantern = new ItemType(1785);
        public static readonly ItemType Sickle = new ItemType(1786);
        public static readonly ItemType PumpkinPie = new ItemType(1787);
        public static readonly ItemType ScarecrowHat = new ItemType(1788);
        public static readonly ItemType ScarecrowShirt = new ItemType(1789);
        public static readonly ItemType ScarecrowPants = new ItemType(1790);
        public static readonly ItemType Cauldron = new ItemType(1791);
        public static readonly ItemType PumpkinChair = new ItemType(1792);
        public static readonly ItemType PumpkinDoor = new ItemType(1793);
        public static readonly ItemType PumpkinTable = new ItemType(1794);
        public static readonly ItemType PumpkinWorkBench = new ItemType(1795);
        public static readonly ItemType PumpkinPlatform = new ItemType(1796);
        public static readonly ItemType TatteredFairyWings = new ItemType(1797);
        public static readonly ItemType SpiderEgg = new ItemType(1798);
        public static readonly ItemType MagicalPumpkinSeed = new ItemType(1799);
        public static readonly ItemType BatHook = new ItemType(1800);
        public static readonly ItemType BatScepter = new ItemType(1801);
        public static readonly ItemType RavenStaff = new ItemType(1802);
        public static readonly ItemType HangingJackOLantern = new ItemType(1808);
        public static readonly ItemType RottenEgg = new ItemType(1809);
        public static readonly ItemType UnluckyYarn = new ItemType(1810);
        public static readonly ItemType BlackFairyDust = new ItemType(1811);
        public static readonly ItemType Jackelier = new ItemType(1812);
        public static readonly ItemType JackOLantern = new ItemType(1813);
        public static readonly ItemType SpookyChair = new ItemType(1814);
        public static readonly ItemType SpookyDoor = new ItemType(1815);
        public static readonly ItemType SpookyTable = new ItemType(1816);
        public static readonly ItemType SpookyWorkBench = new ItemType(1817);
        public static readonly ItemType SpookyPlatform = new ItemType(1818);
        public static readonly ItemType ReaperHood = new ItemType(1819);
        public static readonly ItemType ReaperRobe = new ItemType(1820);
        public static readonly ItemType FoxMask = new ItemType(1821);
        public static readonly ItemType FoxShirt = new ItemType(1822);
        public static readonly ItemType FoxPants = new ItemType(1823);
        public static readonly ItemType CatEars = new ItemType(1824);
        public static readonly ItemType BloodyMachete = new ItemType(1825);
        public static readonly ItemType TheHorsemansBlade = new ItemType(1826);
        public static readonly ItemType BladedGlove = new ItemType(1827);
        public static readonly ItemType PumpkinSeed = new ItemType(1828);
        public static readonly ItemType SpookyHook = new ItemType(1829);
        public static readonly ItemType SpookyWings = new ItemType(1830);
        public static readonly ItemType SpookyTwig = new ItemType(1831);
        public static readonly ItemType SpookyHelmet = new ItemType(1832);
        public static readonly ItemType SpookyBreastplate = new ItemType(1833);
        public static readonly ItemType SpookyLeggings = new ItemType(1834);
        public static readonly ItemType StakeLauncher = new ItemType(1835);
        public static readonly ItemType Stake = new ItemType(1836);
        public static readonly ItemType CursedSapling = new ItemType(1837);
        public static readonly ItemType SpaceCreatureMask = new ItemType(1838);
        public static readonly ItemType SpaceCreatureShirt = new ItemType(1839);
        public static readonly ItemType SpaceCreaturePants = new ItemType(1840);
        public static readonly ItemType WolfMask = new ItemType(1841);
        public static readonly ItemType WolfShirt = new ItemType(1842);
        public static readonly ItemType WolfPants = new ItemType(1843);
        public static readonly ItemType PumpkinMoonMedallion = new ItemType(1844);
        public static readonly ItemType NecromanticScroll = new ItemType(1845);
        public static readonly ItemType JackingSkeletron = new ItemType(1846);
        public static readonly ItemType BitterHarvest = new ItemType(1847);
        public static readonly ItemType BloodMoonCountess = new ItemType(1848);
        public static readonly ItemType HallowsEve = new ItemType(1849);
        public static readonly ItemType MorbidCuriosity = new ItemType(1850);
        public static readonly ItemType TreasureHunterShirt = new ItemType(1851);
        public static readonly ItemType TreasureHunterPants = new ItemType(1852);
        public static readonly ItemType DryadCoverings = new ItemType(1853);
        public static readonly ItemType DryadLoincloth = new ItemType(1854);
        public static readonly ItemType MourningWoodTrophy = new ItemType(1855);
        public static readonly ItemType PumpkingTrophy = new ItemType(1856);
        public static readonly ItemType JackOLanternMask = new ItemType(1857);
        public static readonly ItemType SniperScope = new ItemType(1858);
        public static readonly ItemType HeartLantern = new ItemType(1859);
        public static readonly ItemType JellyfishDivingGear = new ItemType(1860);
        public static readonly ItemType ArcticDivingGear = new ItemType(1861);
        public static readonly ItemType FrostsparkBoots = new ItemType(1862);
        public static readonly ItemType FartInABalloon = new ItemType(1863);
        public static readonly ItemType PapyrusScarab = new ItemType(1864);
        public static readonly ItemType CelestialStone = new ItemType(1865);
        public static readonly ItemType Hoverboard = new ItemType(1866);
        public static readonly ItemType CandyCane = new ItemType(1867);
        public static readonly ItemType SugarPlum = new ItemType(1868);
        public static readonly ItemType Present = new ItemType(1869);
        public static readonly ItemType RedRyder = new ItemType(1870);
        public static readonly ItemType FestiveWings = new ItemType(1871);
        public static readonly ItemType PineTreeBlock = new ItemType(1872);
        public static readonly ItemType ChristmasTree = new ItemType(1873);
        public static readonly ItemType StarTopper1 = new ItemType(1874);
        public static readonly ItemType StarTopper2 = new ItemType(1875);
        public static readonly ItemType StarTopper3 = new ItemType(1876);
        public static readonly ItemType BowTopper = new ItemType(1877);
        public static readonly ItemType WhiteGarland = new ItemType(1878);
        public static readonly ItemType WhiteandRedGarland = new ItemType(1879);
        public static readonly ItemType RedGarland = new ItemType(1880);
        public static readonly ItemType RedandGreenGarland = new ItemType(1881);
        public static readonly ItemType GreenGarland = new ItemType(1882);
        public static readonly ItemType GreenandWhiteGarland = new ItemType(1883);
        public static readonly ItemType MulticoloredBulb = new ItemType(1884);
        public static readonly ItemType RedBulb = new ItemType(1885);
        public static readonly ItemType YellowBulb = new ItemType(1886);
        public static readonly ItemType GreenBulb = new ItemType(1887);
        public static readonly ItemType RedandGreenBulb = new ItemType(1888);
        public static readonly ItemType YellowandGreenBulb = new ItemType(1889);
        public static readonly ItemType RedandYellowBulb = new ItemType(1890);
        public static readonly ItemType WhiteBulb = new ItemType(1891);
        public static readonly ItemType WhiteandRedBulb = new ItemType(1892);
        public static readonly ItemType WhiteandYellowBulb = new ItemType(1893);
        public static readonly ItemType WhiteandGreenBulb = new ItemType(1894);
        public static readonly ItemType MulticoloredLights = new ItemType(1895);
        public static readonly ItemType RedLights = new ItemType(1896);
        public static readonly ItemType GreenLights = new ItemType(1897);
        public static readonly ItemType BlueLights = new ItemType(1898);
        public static readonly ItemType YellowLights = new ItemType(1899);
        public static readonly ItemType RedandYellowLights = new ItemType(1900);
        public static readonly ItemType RedandGreenLights = new ItemType(1901);
        public static readonly ItemType YellowandGreenLights = new ItemType(1902);
        public static readonly ItemType BlueandGreenLights = new ItemType(1903);
        public static readonly ItemType RedandBlueLights = new ItemType(1904);
        public static readonly ItemType BlueandYellowLights = new ItemType(1905);
        public static readonly ItemType GiantBow = new ItemType(1906);
        public static readonly ItemType ReindeerAntlers = new ItemType(1907);
        public static readonly ItemType Holly = new ItemType(1908);
        public static readonly ItemType CandyCaneSword = new ItemType(1909);
        public static readonly ItemType ElfMelter = new ItemType(1910);
        public static readonly ItemType ChristmasPudding = new ItemType(1911);
        public static readonly ItemType Eggnog = new ItemType(1912);
        public static readonly ItemType StarAnise = new ItemType(1913);
        public static readonly ItemType ReindeerBells = new ItemType(1914);
        public static readonly ItemType CandyCaneHook = new ItemType(1915);
        public static readonly ItemType ChristmasHook = new ItemType(1916);
        public static readonly ItemType CandyCanePickaxe = new ItemType(1917);
        public static readonly ItemType FruitcakeChakram = new ItemType(1918);
        public static readonly ItemType SugarCookie = new ItemType(1919);
        public static readonly ItemType GingerbreadCookie = new ItemType(1920);
        public static readonly ItemType HandWarmer = new ItemType(1921);
        public static readonly ItemType Coal = new ItemType(1922);
        public static readonly ItemType Toolbox = new ItemType(1923);
        public static readonly ItemType PineDoor = new ItemType(1924);
        public static readonly ItemType PineChair = new ItemType(1925);
        public static readonly ItemType PineTable = new ItemType(1926);
        public static readonly ItemType DogWhistle = new ItemType(1927);
        public static readonly ItemType ChristmasTreeSword = new ItemType(1928);
        public static readonly ItemType ChainGun = new ItemType(1929);
        public static readonly ItemType Razorpine = new ItemType(1930);
        public static readonly ItemType BlizzardStaff = new ItemType(1931);
        public static readonly ItemType MrsClausHat = new ItemType(1932);
        public static readonly ItemType MrsClausShirt = new ItemType(1933);
        public static readonly ItemType MrsClausHeels = new ItemType(1934);
        public static readonly ItemType ParkaHood = new ItemType(1935);
        public static readonly ItemType ParkaCoat = new ItemType(1936);
        public static readonly ItemType ParkaPants = new ItemType(1937);
        public static readonly ItemType SnowHat = new ItemType(1938);
        public static readonly ItemType UglySweater = new ItemType(1939);
        public static readonly ItemType TreeMask = new ItemType(1940);
        public static readonly ItemType TreeShirt = new ItemType(1941);
        public static readonly ItemType TreeTrunks = new ItemType(1942);
        public static readonly ItemType ElfHat = new ItemType(1943);
        public static readonly ItemType ElfShirt = new ItemType(1944);
        public static readonly ItemType ElfPants = new ItemType(1945);
        public static readonly ItemType SnowmanCannon = new ItemType(1946);
        public static readonly ItemType NorthPole = new ItemType(1947);
        public static readonly ItemType ChristmasTreeWallpaper = new ItemType(1948);
        public static readonly ItemType OrnamentWallpaper = new ItemType(1949);
        public static readonly ItemType CandyCaneWallpaper = new ItemType(1950);
        public static readonly ItemType FestiveWallpaper = new ItemType(1951);
        public static readonly ItemType StarsWallpaper = new ItemType(1952);
        public static readonly ItemType SquigglesWallpaper = new ItemType(1953);
        public static readonly ItemType SnowflakeWallpaper = new ItemType(1954);
        public static readonly ItemType KrampusHornWallpaper = new ItemType(1955);
        public static readonly ItemType BluegreenWallpaper = new ItemType(1956);
        public static readonly ItemType GrinchFingerWallpaper = new ItemType(1957);
        public static readonly ItemType NaughtyPresent = new ItemType(1958);
        public static readonly ItemType BabyGrinchsMischiefWhistle = new ItemType(1959);
        public static readonly ItemType IceQueenTrophy = new ItemType(1960);
        public static readonly ItemType SantaNk1Trophy = new ItemType(1961);
        public static readonly ItemType EverscreamTrophy = new ItemType(1962);
        public static readonly ItemType MusicBoxPumpkinMoon = new ItemType(1963);
        public static readonly ItemType MusicBoxAltUnderground = new ItemType(1964);
        public static readonly ItemType MusicBoxFrostMoon = new ItemType(1965);
        public static readonly ItemType BrownPaint = new ItemType(1966);
        public static readonly ItemType ShadowPaint = new ItemType(1967);
        public static readonly ItemType NegativePaint = new ItemType(1968);
        public static readonly ItemType TeamDye = new ItemType(1969);
        public static readonly ItemType AmethystGemsparkBlock = new ItemType(1970);
        public static readonly ItemType TopazGemsparkBlock = new ItemType(1971);
        public static readonly ItemType SapphireGemsparkBlock = new ItemType(1972);
        public static readonly ItemType EmeraldGemsparkBlock = new ItemType(1973);
        public static readonly ItemType RubyGemsparkBlock = new ItemType(1974);
        public static readonly ItemType DiamondGemsparkBlock = new ItemType(1975);
        public static readonly ItemType AmberGemsparkBlock = new ItemType(1976);
        public static readonly ItemType LifeHairDye = new ItemType(1977);
        public static readonly ItemType ManaHairDye = new ItemType(1978);
        public static readonly ItemType DepthHairDye = new ItemType(1979);
        public static readonly ItemType MoneyHairDye = new ItemType(1980);
        public static readonly ItemType TimeHairDye = new ItemType(1981);
        public static readonly ItemType TeamHairDye = new ItemType(1982);
        public static readonly ItemType BiomeHairDye = new ItemType(1983);
        public static readonly ItemType PartyHairDye = new ItemType(1984);
        public static readonly ItemType RainbowHairDye = new ItemType(1985);
        public static readonly ItemType SpeedHairDye = new ItemType(1986);
        public static readonly ItemType AngelHalo = new ItemType(1987);
        public static readonly ItemType Fez = new ItemType(1988);
        public static readonly ItemType Womannequin = new ItemType(1989);
        public static readonly ItemType HairDyeRemover = new ItemType(1990);
        public static readonly ItemType BugNet = new ItemType(1991);
        public static readonly ItemType Firefly = new ItemType(1992);
        public static readonly ItemType FireflyInABottle = new ItemType(1993);
        public static readonly ItemType MonarchButterfly = new ItemType(1994);
        public static readonly ItemType PurpleEmperorButterfly = new ItemType(1995);
        public static readonly ItemType RedAdmiralButterfly = new ItemType(1996);
        public static readonly ItemType UlyssesButterfly = new ItemType(1997);
        public static readonly ItemType SulphurButterfly = new ItemType(1998);
        public static readonly ItemType TreeNymphButterfly = new ItemType(1999);
        public static readonly ItemType ZebraSwallowtailButterfly = new ItemType(2000);
        public static readonly ItemType JuliaButterfly = new ItemType(2001);
        public static readonly ItemType Worm = new ItemType(2002);
        public static readonly ItemType Mouse = new ItemType(2003);
        public static readonly ItemType LightningBug = new ItemType(2004);
        public static readonly ItemType LightningBugInABottle = new ItemType(2005);
        public static readonly ItemType Snail = new ItemType(2006);
        public static readonly ItemType GlowingSnail = new ItemType(2007);
        public static readonly ItemType FancyGrayWallpaper = new ItemType(2008);
        public static readonly ItemType IceFloeWallpaper = new ItemType(2009);
        public static readonly ItemType MusicWallpaper = new ItemType(2010);
        public static readonly ItemType PurpleRainWallpaper = new ItemType(2011);
        public static readonly ItemType RainbowWallpaper = new ItemType(2012);
        public static readonly ItemType SparkleStoneWallpaper = new ItemType(2013);
        public static readonly ItemType StarlitHeavenWallpaper = new ItemType(2014);
        public static readonly ItemType Bird = new ItemType(2015);
        public static readonly ItemType BlueJay = new ItemType(2016);
        public static readonly ItemType Cardinal = new ItemType(2017);
        public static readonly ItemType Squirrel = new ItemType(2018);
        public static readonly ItemType Bunny = new ItemType(2019);
        public static readonly ItemType CactusBookcase = new ItemType(2020);
        public static readonly ItemType EbonwoodBookcase = new ItemType(2021);
        public static readonly ItemType FleshBookcase = new ItemType(2022);
        public static readonly ItemType HoneyBookcase = new ItemType(2023);
        public static readonly ItemType SteampunkBookcase = new ItemType(2024);
        public static readonly ItemType GlassBookcase = new ItemType(2025);
        public static readonly ItemType RichMahoganyBookcase = new ItemType(2026);
        public static readonly ItemType PearlwoodBookcase = new ItemType(2027);
        public static readonly ItemType SpookyBookcase = new ItemType(2028);
        public static readonly ItemType SkywareBookcase = new ItemType(2029);
        public static readonly ItemType LihzahrdBookcase = new ItemType(2030);
        public static readonly ItemType FrozenBookcase = new ItemType(2031);
        public static readonly ItemType CactusLantern = new ItemType(2032);
        public static readonly ItemType EbonwoodLantern = new ItemType(2033);
        public static readonly ItemType FleshLantern = new ItemType(2034);
        public static readonly ItemType HoneyLantern = new ItemType(2035);
        public static readonly ItemType SteampunkLantern = new ItemType(2036);
        public static readonly ItemType GlassLantern = new ItemType(2037);
        public static readonly ItemType RichMahoganyLantern = new ItemType(2038);
        public static readonly ItemType PearlwoodLantern = new ItemType(2039);
        public static readonly ItemType FrozenLantern = new ItemType(2040);
        public static readonly ItemType LihzahrdLantern = new ItemType(2041);
        public static readonly ItemType SkywareLantern = new ItemType(2042);
        public static readonly ItemType SpookyLantern = new ItemType(2043);
        public static readonly ItemType FrozenDoor = new ItemType(2044);
        public static readonly ItemType CactusCandle = new ItemType(2045);
        public static readonly ItemType EbonwoodCandle = new ItemType(2046);
        public static readonly ItemType FleshCandle = new ItemType(2047);
        public static readonly ItemType GlassCandle = new ItemType(2048);
        public static readonly ItemType FrozenCandle = new ItemType(2049);
        public static readonly ItemType RichMahoganyCandle = new ItemType(2050);
        public static readonly ItemType PearlwoodCandle = new ItemType(2051);
        public static readonly ItemType LihzahrdCandle = new ItemType(2052);
        public static readonly ItemType SkywareCandle = new ItemType(2053);
        public static readonly ItemType PumpkinCandle = new ItemType(2054);
        public static readonly ItemType CactusChandelier = new ItemType(2055);
        public static readonly ItemType EbonwoodChandelier = new ItemType(2056);
        public static readonly ItemType FleshChandelier = new ItemType(2057);
        public static readonly ItemType HoneyChandelier = new ItemType(2058);
        public static readonly ItemType FrozenChandelier = new ItemType(2059);
        public static readonly ItemType RichMahoganyChandelier = new ItemType(2060);
        public static readonly ItemType PearlwoodChandelier = new ItemType(2061);
        public static readonly ItemType LihzahrdChandelier = new ItemType(2062);
        public static readonly ItemType SkywareChandelier = new ItemType(2063);
        public static readonly ItemType SpookyChandelier = new ItemType(2064);
        public static readonly ItemType GlassChandelier = new ItemType(2065);
        public static readonly ItemType CactusBed = new ItemType(2066);
        public static readonly ItemType FleshBed = new ItemType(2067);
        public static readonly ItemType FrozenBed = new ItemType(2068);
        public static readonly ItemType LihzahrdBed = new ItemType(2069);
        public static readonly ItemType SkywareBed = new ItemType(2070);
        public static readonly ItemType SpookyBed = new ItemType(2071);
        public static readonly ItemType CactusBathtub = new ItemType(2072);
        public static readonly ItemType EbonwoodBathtub = new ItemType(2073);
        public static readonly ItemType FleshBathtub = new ItemType(2074);
        public static readonly ItemType GlassBathtub = new ItemType(2075);
        public static readonly ItemType FrozenBathtub = new ItemType(2076);
        public static readonly ItemType RichMahoganyBathtub = new ItemType(2077);
        public static readonly ItemType PearlwoodBathtub = new ItemType(2078);
        public static readonly ItemType LihzahrdBathtub = new ItemType(2079);
        public static readonly ItemType SkywareBathtub = new ItemType(2080);
        public static readonly ItemType SpookyBathtub = new ItemType(2081);
        public static readonly ItemType CactusLamp = new ItemType(2082);
        public static readonly ItemType EbonwoodLamp = new ItemType(2083);
        public static readonly ItemType FleshLamp = new ItemType(2084);
        public static readonly ItemType GlassLamp = new ItemType(2085);
        public static readonly ItemType FrozenLamp = new ItemType(2086);
        public static readonly ItemType RichMahoganyLamp = new ItemType(2087);
        public static readonly ItemType PearlwoodLamp = new ItemType(2088);
        public static readonly ItemType LihzahrdLamp = new ItemType(2089);
        public static readonly ItemType SkywareLamp = new ItemType(2090);
        public static readonly ItemType SpookyLamp = new ItemType(2091);
        public static readonly ItemType CactusCandelabra = new ItemType(2092);
        public static readonly ItemType EbonwoodCandelabra = new ItemType(2093);
        public static readonly ItemType FleshCandelabra = new ItemType(2094);
        public static readonly ItemType HoneyCandelabra = new ItemType(2095);
        public static readonly ItemType SteampunkCandelabra = new ItemType(2096);
        public static readonly ItemType GlassCandelabra = new ItemType(2097);
        public static readonly ItemType RichMahoganyCandelabra = new ItemType(2098);
        public static readonly ItemType PearlwoodCandelabra = new ItemType(2099);
        public static readonly ItemType FrozenCandelabra = new ItemType(2100);
        public static readonly ItemType LihzahrdCandelabra = new ItemType(2101);
        public static readonly ItemType SkywareCandelabra = new ItemType(2102);
        public static readonly ItemType SpookyCandelabra = new ItemType(2103);
        public static readonly ItemType BrainOfCthulhuMask = new ItemType(2104);
        public static readonly ItemType WallOfFleshMask = new ItemType(2105);
        public static readonly ItemType TwinMask = new ItemType(2106);
        public static readonly ItemType SkeletronPrimeMask = new ItemType(2107);
        public static readonly ItemType QueenBeeMask = new ItemType(2108);
        public static readonly ItemType PlanteraMask = new ItemType(2109);
        public static readonly ItemType GolemMask = new ItemType(2110);
        public static readonly ItemType EaterOfWorldsMask = new ItemType(2111);
        public static readonly ItemType EyeOfCthulhuMask = new ItemType(2112);
        public static readonly ItemType DestroyerMask = new ItemType(2113);
        public static readonly ItemType BlacksmithRack = new ItemType(2114);
        public static readonly ItemType CarpentryRack = new ItemType(2115);
        public static readonly ItemType HelmetRack = new ItemType(2116);
        public static readonly ItemType SpearRack = new ItemType(2117);
        public static readonly ItemType SwordRack = new ItemType(2118);
        public static readonly ItemType StoneSlab = new ItemType(2119);
        public static readonly ItemType SandstoneSlab = new ItemType(2120);
        public static readonly ItemType Frog = new ItemType(2121);
        public static readonly ItemType MallardDuck = new ItemType(2122);
        public static readonly ItemType Duck = new ItemType(2123);
        public static readonly ItemType HoneyBathtub = new ItemType(2124);
        public static readonly ItemType SteampunkBathtub = new ItemType(2125);
        public static readonly ItemType LivingWoodBathtub = new ItemType(2126);
        public static readonly ItemType ShadewoodBathtub = new ItemType(2127);
        public static readonly ItemType BoneBathtub = new ItemType(2128);
        public static readonly ItemType HoneyLamp = new ItemType(2129);
        public static readonly ItemType SteampunkLamp = new ItemType(2130);
        public static readonly ItemType LivingWoodLamp = new ItemType(2131);
        public static readonly ItemType ShadewoodLamp = new ItemType(2132);
        public static readonly ItemType GoldenLamp = new ItemType(2133);
        public static readonly ItemType BoneLamp = new ItemType(2134);
        public static readonly ItemType LivingWoodBookcase = new ItemType(2135);
        public static readonly ItemType ShadewoodBookcase = new ItemType(2136);
        public static readonly ItemType GoldenBookcase = new ItemType(2137);
        public static readonly ItemType BoneBookcase = new ItemType(2138);
        public static readonly ItemType LivingWoodBed = new ItemType(2139);
        public static readonly ItemType BoneBed = new ItemType(2140);
        public static readonly ItemType LivingWoodChandelier = new ItemType(2141);
        public static readonly ItemType ShadewoodChandelier = new ItemType(2142);
        public static readonly ItemType GoldenChandelier = new ItemType(2143);
        public static readonly ItemType BoneChandelier = new ItemType(2144);
        public static readonly ItemType LivingWoodLantern = new ItemType(2145);
        public static readonly ItemType ShadewoodLantern = new ItemType(2146);
        public static readonly ItemType GoldenLantern = new ItemType(2147);
        public static readonly ItemType BoneLantern = new ItemType(2148);
        public static readonly ItemType LivingWoodCandelabra = new ItemType(2149);
        public static readonly ItemType ShadewoodCandelabra = new ItemType(2150);
        public static readonly ItemType GoldenCandelabra = new ItemType(2151);
        public static readonly ItemType BoneCandelabra = new ItemType(2152);
        public static readonly ItemType LivingWoodCandle = new ItemType(2153);
        public static readonly ItemType ShadewoodCandle = new ItemType(2154);
        public static readonly ItemType GoldenCandle = new ItemType(2155);
        public static readonly ItemType BlackScorpion = new ItemType(2156);
        public static readonly ItemType Scorpion = new ItemType(2157);
        public static readonly ItemType BubbleWallpaper = new ItemType(2158);
        public static readonly ItemType CopperPipeWallpaper = new ItemType(2159);
        public static readonly ItemType DuckyWallpaper = new ItemType(2160);
        public static readonly ItemType FrostCore = new ItemType(2161);
        public static readonly ItemType BunnyCage = new ItemType(2162);
        public static readonly ItemType SquirrelCage = new ItemType(2163);
        public static readonly ItemType MallardDuckCage = new ItemType(2164);
        public static readonly ItemType DuckCage = new ItemType(2165);
        public static readonly ItemType BirdCage = new ItemType(2166);
        public static readonly ItemType BlueJayCage = new ItemType(2167);
        public static readonly ItemType CardinalCage = new ItemType(2168);
        public static readonly ItemType WaterfallWall = new ItemType(2169);
        public static readonly ItemType LavafallWall = new ItemType(2170);
        public static readonly ItemType CrimsonSeeds = new ItemType(2171);
        public static readonly ItemType HeavyWorkBench = new ItemType(2172);
        public static readonly ItemType CopperPlating = new ItemType(2173);
        public static readonly ItemType SnailCage = new ItemType(2174);
        public static readonly ItemType GlowingSnailCage = new ItemType(2175);
        public static readonly ItemType ShroomiteDiggingClaw = new ItemType(2176);
        public static readonly ItemType AmmoBox = new ItemType(2177);
        public static readonly ItemType MonarchButterflyJar = new ItemType(2178);
        public static readonly ItemType PurpleEmperorButterflyJar = new ItemType(2179);
        public static readonly ItemType RedAdmiralButterflyJar = new ItemType(2180);
        public static readonly ItemType UlyssesButterflyJar = new ItemType(2181);
        public static readonly ItemType SulphurButterflyJar = new ItemType(2182);
        public static readonly ItemType TreeNymphButterflyJar = new ItemType(2183);
        public static readonly ItemType ZebraSwallowtailButterflyJar = new ItemType(2184);
        public static readonly ItemType JuliaButterflyJar = new ItemType(2185);
        public static readonly ItemType ScorpionCage = new ItemType(2186);
        public static readonly ItemType BlackScorpionCage = new ItemType(2187);
        public static readonly ItemType VenomStaff = new ItemType(2188);
        public static readonly ItemType SpectreMask = new ItemType(2189);
        public static readonly ItemType FrogCage = new ItemType(2190);
        public static readonly ItemType MouseCage = new ItemType(2191);
        public static readonly ItemType BoneWelder = new ItemType(2192);
        public static readonly ItemType FleshCloningVat = new ItemType(2193);
        public static readonly ItemType GlassKiln = new ItemType(2194);
        public static readonly ItemType LihzahrdFurnace = new ItemType(2195);
        public static readonly ItemType LivingLoom = new ItemType(2196);
        public static readonly ItemType SkyMill = new ItemType(2197);
        public static readonly ItemType IceMachine = new ItemType(2198);
        public static readonly ItemType BeetleHelmet = new ItemType(2199);
        public static readonly ItemType BeetleScaleMail = new ItemType(2200);
        public static readonly ItemType BeetleShell = new ItemType(2201);
        public static readonly ItemType BeetleLeggings = new ItemType(2202);
        public static readonly ItemType SteampunkBoiler = new ItemType(2203);
        public static readonly ItemType HoneyDispenser = new ItemType(2204);
        public static readonly ItemType Penguin = new ItemType(2205);
        public static readonly ItemType PenguinCage = new ItemType(2206);
        public static readonly ItemType WormCage = new ItemType(2207);
        public static readonly ItemType Terrarium = new ItemType(2208);
        public static readonly ItemType SuperManaPotion = new ItemType(2209);
        public static readonly ItemType EbonwoodFence = new ItemType(2210);
        public static readonly ItemType RichMahoganyFence = new ItemType(2211);
        public static readonly ItemType PearlwoodFence = new ItemType(2212);
        public static readonly ItemType ShadewoodFence = new ItemType(2213);
        public static readonly ItemType BrickLayer = new ItemType(2214);
        public static readonly ItemType ExtendoGrip = new ItemType(2215);
        public static readonly ItemType PaintSprayer = new ItemType(2216);
        public static readonly ItemType PortableCementMixer = new ItemType(2217);
        public static readonly ItemType BeetleHusk = new ItemType(2218);
        public static readonly ItemType CelestialMagnet = new ItemType(2219);
        public static readonly ItemType CelestialEmblem = new ItemType(2220);
        public static readonly ItemType CelestialCuffs = new ItemType(2221);
        public static readonly ItemType PeddlersHat = new ItemType(2222);
        public static readonly ItemType PulseBow = new ItemType(2223);
        public static readonly ItemType LargeDynastyLantern = new ItemType(2224);
        public static readonly ItemType DynastyLamp = new ItemType(2225);
        public static readonly ItemType DynastyLantern = new ItemType(2226);
        public static readonly ItemType LargeDynastyCandle = new ItemType(2227);
        public static readonly ItemType DynastyChair = new ItemType(2228);
        public static readonly ItemType DynastyWorkBench = new ItemType(2229);
        public static readonly ItemType DynastyChest = new ItemType(2230);
        public static readonly ItemType DynastyBed = new ItemType(2231);
        public static readonly ItemType DynastyBathtub = new ItemType(2232);
        public static readonly ItemType DynastyBookcase = new ItemType(2233);
        public static readonly ItemType DynastyCup = new ItemType(2234);
        public static readonly ItemType DynastyBowl = new ItemType(2235);
        public static readonly ItemType DynastyCandle = new ItemType(2236);
        public static readonly ItemType DynastyClock = new ItemType(2237);
        public static readonly ItemType GoldenClock = new ItemType(2238);
        public static readonly ItemType GlassClock = new ItemType(2239);
        public static readonly ItemType HoneyClock = new ItemType(2240);
        public static readonly ItemType SteampunkClock = new ItemType(2241);
        public static readonly ItemType FancyDishes = new ItemType(2242);
        public static readonly ItemType GlassBowl = new ItemType(2243);
        public static readonly ItemType WineGlass = new ItemType(2244);
        public static readonly ItemType LivingWoodPiano = new ItemType(2245);
        public static readonly ItemType FleshPiano = new ItemType(2246);
        public static readonly ItemType FrozenPiano = new ItemType(2247);
        public static readonly ItemType FrozenTable = new ItemType(2248);
        public static readonly ItemType HoneyChest = new ItemType(2249);
        public static readonly ItemType SteampunkChest = new ItemType(2250);
        public static readonly ItemType HoneyWorkBench = new ItemType(2251);
        public static readonly ItemType FrozenWorkBench = new ItemType(2252);
        public static readonly ItemType SteampunkWorkBench = new ItemType(2253);
        public static readonly ItemType GlassPiano = new ItemType(2254);
        public static readonly ItemType HoneyPiano = new ItemType(2255);
        public static readonly ItemType SteampunkPiano = new ItemType(2256);
        public static readonly ItemType HoneyCup = new ItemType(2257);
        public static readonly ItemType Chalice = new ItemType(2258);
        public static readonly ItemType DynastyTable = new ItemType(2259);
        public static readonly ItemType DynastyWood = new ItemType(2260);
        public static readonly ItemType RedDynastyShingles = new ItemType(2261);
        public static readonly ItemType BlueDynastyShingles = new ItemType(2262);
        public static readonly ItemType WhiteDynastyWall = new ItemType(2263);
        public static readonly ItemType BlueDynastyWall = new ItemType(2264);
        public static readonly ItemType DynastyDoor = new ItemType(2265);
        public static readonly ItemType Sake = new ItemType(2266);
        public static readonly ItemType PadThai = new ItemType(2267);
        public static readonly ItemType Pho = new ItemType(2268);
        public static readonly ItemType Revolver = new ItemType(2269);
        public static readonly ItemType Gatligator = new ItemType(2270);
        public static readonly ItemType ArcaneRuneWall = new ItemType(2271);
        public static readonly ItemType WaterGun = new ItemType(2272);
        public static readonly ItemType Katana = new ItemType(2273);
        public static readonly ItemType UltrabrightTorch = new ItemType(2274);
        public static readonly ItemType MagicHat = new ItemType(2275);
        public static readonly ItemType DiamondRing = new ItemType(2276);
        public static readonly ItemType Gi = new ItemType(2277);
        public static readonly ItemType Kimono = new ItemType(2278);
        public static readonly ItemType GypsyRobe = new ItemType(2279);
        public static readonly ItemType BeetleWings = new ItemType(2280);
        public static readonly ItemType TigerSkin = new ItemType(2281);
        public static readonly ItemType LeopardSkin = new ItemType(2282);
        public static readonly ItemType ZebraSkin = new ItemType(2283);
        public static readonly ItemType CrimsonCloak = new ItemType(2284);
        public static readonly ItemType MysteriousCape = new ItemType(2285);
        public static readonly ItemType RedCape = new ItemType(2286);
        public static readonly ItemType WinterCape = new ItemType(2287);
        public static readonly ItemType FrozenChair = new ItemType(2288);
        public static readonly ItemType WoodFishingPole = new ItemType(2289);
        public static readonly ItemType Bass = new ItemType(2290);
        public static readonly ItemType ReinforcedFishingPole = new ItemType(2291);
        public static readonly ItemType FiberglassFishingPole = new ItemType(2292);
        public static readonly ItemType FisherOfSouls = new ItemType(2293);
        public static readonly ItemType GoldenFishingRod = new ItemType(2294);
        public static readonly ItemType MechanicsRod = new ItemType(2295);
        public static readonly ItemType SittingDucksFishingPole = new ItemType(2296);
        public static readonly ItemType Trout = new ItemType(2297);
        public static readonly ItemType Salmon = new ItemType(2298);
        public static readonly ItemType AtlanticCod = new ItemType(2299);
        public static readonly ItemType Tuna = new ItemType(2300);
        public static readonly ItemType RedSnapper = new ItemType(2301);
        public static readonly ItemType NeonTetra = new ItemType(2302);
        public static readonly ItemType ArmoredCavefish = new ItemType(2303);
        public static readonly ItemType Damselfish = new ItemType(2304);
        public static readonly ItemType CrimsonTigerfish = new ItemType(2305);
        public static readonly ItemType FrostMinnow = new ItemType(2306);
        public static readonly ItemType PrincessFish = new ItemType(2307);
        public static readonly ItemType GoldenCarp = new ItemType(2308);
        public static readonly ItemType SpecularFish = new ItemType(2309);
        public static readonly ItemType Prismite = new ItemType(2310);
        public static readonly ItemType VariegatedLardfish = new ItemType(2311);
        public static readonly ItemType FlarefinKoi = new ItemType(2312);
        public static readonly ItemType DoubleCod = new ItemType(2313);
        public static readonly ItemType Honeyfin = new ItemType(2314);
        public static readonly ItemType Obsidifish = new ItemType(2315);
        public static readonly ItemType Shrimp = new ItemType(2316);
        public static readonly ItemType ChaosFish = new ItemType(2317);
        public static readonly ItemType Ebonkoi = new ItemType(2318);
        public static readonly ItemType Hemopiranha = new ItemType(2319);
        public static readonly ItemType Rockfish = new ItemType(2320);
        public static readonly ItemType Stinkfish = new ItemType(2321);
        public static readonly ItemType MiningPotion = new ItemType(2322);
        public static readonly ItemType HeartreachPotion = new ItemType(2323);
        public static readonly ItemType CalmingPotion = new ItemType(2324);
        public static readonly ItemType BuilderPotion = new ItemType(2325);
        public static readonly ItemType TitanPotion = new ItemType(2326);
        public static readonly ItemType FlipperPotion = new ItemType(2327);
        public static readonly ItemType SummoningPotion = new ItemType(2328);
        public static readonly ItemType DangersensePotion = new ItemType(2329);
        public static readonly ItemType PurpleClubberfish = new ItemType(2330);
        public static readonly ItemType ObsidianSwordfish = new ItemType(2331);
        public static readonly ItemType Swordfish = new ItemType(2332);
        public static readonly ItemType IronFence = new ItemType(2333);
        public static readonly ItemType WoodenCrate = new ItemType(2334);
        public static readonly ItemType IronCrate = new ItemType(2335);
        public static readonly ItemType GoldenCrate = new ItemType(2336);
        public static readonly ItemType OldShoe = new ItemType(2337);
        public static readonly ItemType SeaweedFishingJunk = new ItemType(2338);
        public static readonly ItemType TinCan = new ItemType(2339);
        public static readonly ItemType MinecartTrack = new ItemType(2340);
        public static readonly ItemType ReaverShark = new ItemType(2341);
        public static readonly ItemType SawtoothShark = new ItemType(2342);
        public static readonly ItemType Minecart = new ItemType(2343);
        public static readonly ItemType AmmoReservationPotion = new ItemType(2344);
        public static readonly ItemType LifeforcePotion = new ItemType(2345);
        public static readonly ItemType EndurancePotion = new ItemType(2346);
        public static readonly ItemType RagePotion = new ItemType(2347);
        public static readonly ItemType InfernoPotion = new ItemType(2348);
        public static readonly ItemType WrathPotion = new ItemType(2349);
        public static readonly ItemType RecallPotion = new ItemType(2350);
        public static readonly ItemType TeleportationPotion = new ItemType(2351);
        public static readonly ItemType LovePotion = new ItemType(2352);
        public static readonly ItemType StinkPotion = new ItemType(2353);
        public static readonly ItemType FishingPotion = new ItemType(2354);
        public static readonly ItemType SonarPotion = new ItemType(2355);
        public static readonly ItemType CratePotion = new ItemType(2356);
        public static readonly ItemType ShiverthornSeeds = new ItemType(2357);
        public static readonly ItemType Shiverthorn = new ItemType(2358);
        public static readonly ItemType WarmthPotion = new ItemType(2359);
        public static readonly ItemType FishHook = new ItemType(2360);
        public static readonly ItemType BeeHeadgear = new ItemType(2361);
        public static readonly ItemType BeeBreastplate = new ItemType(2362);
        public static readonly ItemType BeeGreaves = new ItemType(2363);
        public static readonly ItemType HornetStaff = new ItemType(2364);
        public static readonly ItemType ImpStaff = new ItemType(2365);
        public static readonly ItemType QueenSpiderStaff = new ItemType(2366);
        public static readonly ItemType AnglerHat = new ItemType(2367);
        public static readonly ItemType AnglerVest = new ItemType(2368);
        public static readonly ItemType AnglerPants = new ItemType(2369);
        public static readonly ItemType SpiderMask = new ItemType(2370);
        public static readonly ItemType SpiderBreastplate = new ItemType(2371);
        public static readonly ItemType SpiderGreaves = new ItemType(2372);
        public static readonly ItemType HighTestFishingLine = new ItemType(2373);
        public static readonly ItemType AnglerEarring = new ItemType(2374);
        public static readonly ItemType TackleBox = new ItemType(2375);
        public static readonly ItemType BlueDungeonPiano = new ItemType(2376);
        public static readonly ItemType GreenDungeonPiano = new ItemType(2377);
        public static readonly ItemType PinkDungeonPiano = new ItemType(2378);
        public static readonly ItemType GoldenPiano = new ItemType(2379);
        public static readonly ItemType ObsidianPiano = new ItemType(2380);
        public static readonly ItemType BonePiano = new ItemType(2381);
        public static readonly ItemType CactusPiano = new ItemType(2382);
        public static readonly ItemType SpookyPiano = new ItemType(2383);
        public static readonly ItemType SkywarePiano = new ItemType(2384);
        public static readonly ItemType LihzahrdPiano = new ItemType(2385);
        public static readonly ItemType BlueDungeonDresser = new ItemType(2386);
        public static readonly ItemType GreenDungeonDresser = new ItemType(2387);
        public static readonly ItemType PinkDungeonDresser = new ItemType(2388);
        public static readonly ItemType GoldenDresser = new ItemType(2389);
        public static readonly ItemType ObsidianDresser = new ItemType(2390);
        public static readonly ItemType BoneDresser = new ItemType(2391);
        public static readonly ItemType CactusDresser = new ItemType(2392);
        public static readonly ItemType SpookyDresser = new ItemType(2393);
        public static readonly ItemType SkywareDresser = new ItemType(2394);
        public static readonly ItemType HoneyDresser = new ItemType(2395);
        public static readonly ItemType LihzahrdDresser = new ItemType(2396);
        public static readonly ItemType Sofa = new ItemType(2397);
        public static readonly ItemType EbonwoodSofa = new ItemType(2398);
        public static readonly ItemType RichMahoganySofa = new ItemType(2399);
        public static readonly ItemType PearlwoodSofa = new ItemType(2400);
        public static readonly ItemType ShadewoodSofa = new ItemType(2401);
        public static readonly ItemType BlueDungeonSofa = new ItemType(2402);
        public static readonly ItemType GreenDungeonSofa = new ItemType(2403);
        public static readonly ItemType PinkDungeonSofa = new ItemType(2404);
        public static readonly ItemType GoldenSofa = new ItemType(2405);
        public static readonly ItemType ObsidianSofa = new ItemType(2406);
        public static readonly ItemType BoneSofa = new ItemType(2407);
        public static readonly ItemType CactusSofa = new ItemType(2408);
        public static readonly ItemType SpookySofa = new ItemType(2409);
        public static readonly ItemType SkywareSofa = new ItemType(2410);
        public static readonly ItemType HoneySofa = new ItemType(2411);
        public static readonly ItemType SteampunkSofa = new ItemType(2412);
        public static readonly ItemType MushroomSofa = new ItemType(2413);
        public static readonly ItemType GlassSofa = new ItemType(2414);
        public static readonly ItemType PumpkinSofa = new ItemType(2415);
        public static readonly ItemType LihzahrdSofa = new ItemType(2416);
        public static readonly ItemType SeashellHairpin = new ItemType(2417);
        public static readonly ItemType MermaidAdornment = new ItemType(2418);
        public static readonly ItemType MermaidTail = new ItemType(2419);
        public static readonly ItemType ZephyrFish = new ItemType(2420);
        public static readonly ItemType Fleshcatcher = new ItemType(2421);
        public static readonly ItemType HotlineFishingHook = new ItemType(2422);
        public static readonly ItemType FrogLeg = new ItemType(2423);
        public static readonly ItemType Anchor = new ItemType(2424);
        public static readonly ItemType CookedFish = new ItemType(2425);
        public static readonly ItemType CookedShrimp = new ItemType(2426);
        public static readonly ItemType Sashimi = new ItemType(2427);
        public static readonly ItemType FuzzyCarrot = new ItemType(2428);
        public static readonly ItemType ScalyTruffle = new ItemType(2429);
        public static readonly ItemType SlimySaddle = new ItemType(2430);
        public static readonly ItemType BeeWax = new ItemType(2431);
        public static readonly ItemType CopperPlatingWall = new ItemType(2432);
        public static readonly ItemType StoneSlabWall = new ItemType(2433);
        public static readonly ItemType Sail = new ItemType(2434);
        public static readonly ItemType CoralstoneBlock = new ItemType(2435);
        public static readonly ItemType BlueJellyfish = new ItemType(2436);
        public static readonly ItemType GreenJellyfish = new ItemType(2437);
        public static readonly ItemType PinkJellyfish = new ItemType(2438);
        public static readonly ItemType BlueJellyfishJar = new ItemType(2439);
        public static readonly ItemType GreenJellyfishJar = new ItemType(2440);
        public static readonly ItemType PinkJellyfishJar = new ItemType(2441);
        public static readonly ItemType LifePreserver = new ItemType(2442);
        public static readonly ItemType ShipsWheel = new ItemType(2443);
        public static readonly ItemType CompassRose = new ItemType(2444);
        public static readonly ItemType WallAnchor = new ItemType(2445);
        public static readonly ItemType GoldfishTrophy = new ItemType(2446);
        public static readonly ItemType BunnyfishTrophy = new ItemType(2447);
        public static readonly ItemType SwordfishTrophy = new ItemType(2448);
        public static readonly ItemType SharkteethTrophy = new ItemType(2449);
        public static readonly ItemType Batfish = new ItemType(2450);
        public static readonly ItemType BumblebeeTuna = new ItemType(2451);
        public static readonly ItemType Catfish = new ItemType(2452);
        public static readonly ItemType Cloudfish = new ItemType(2453);
        public static readonly ItemType Cursedfish = new ItemType(2454);
        public static readonly ItemType Dirtfish = new ItemType(2455);
        public static readonly ItemType DynamiteFish = new ItemType(2456);
        public static readonly ItemType EaterOfPlankton = new ItemType(2457);
        public static readonly ItemType FallenStarfish = new ItemType(2458);
        public static readonly ItemType TheFishOfCthulhu = new ItemType(2459);
        public static readonly ItemType Fishotron = new ItemType(2460);
        public static readonly ItemType Harpyfish = new ItemType(2461);
        public static readonly ItemType Hungerfish = new ItemType(2462);
        public static readonly ItemType Ichorfish = new ItemType(2463);
        public static readonly ItemType Jewelfish = new ItemType(2464);
        public static readonly ItemType MirageFish = new ItemType(2465);
        public static readonly ItemType MutantFlinxfin = new ItemType(2466);
        public static readonly ItemType Pengfish = new ItemType(2467);
        public static readonly ItemType Pixiefish = new ItemType(2468);
        public static readonly ItemType Spiderfish = new ItemType(2469);
        public static readonly ItemType TundraTrout = new ItemType(2470);
        public static readonly ItemType UnicornFish = new ItemType(2471);
        public static readonly ItemType GuideVoodooFish = new ItemType(2472);
        public static readonly ItemType Wyverntail = new ItemType(2473);
        public static readonly ItemType ZombieFish = new ItemType(2474);
        public static readonly ItemType AmanitiaFungifin = new ItemType(2475);
        public static readonly ItemType Angelfish = new ItemType(2476);
        public static readonly ItemType BloodyManowar = new ItemType(2477);
        public static readonly ItemType Bonefish = new ItemType(2478);
        public static readonly ItemType Bunnyfish = new ItemType(2479);
        public static readonly ItemType CapnTunabeard = new ItemType(2480);
        public static readonly ItemType Clownfish = new ItemType(2481);
        public static readonly ItemType DemonicHellfish = new ItemType(2482);
        public static readonly ItemType Derpfish = new ItemType(2483);
        public static readonly ItemType Fishron = new ItemType(2484);
        public static readonly ItemType InfectedScabbardfish = new ItemType(2485);
        public static readonly ItemType Mudfish = new ItemType(2486);
        public static readonly ItemType Slimefish = new ItemType(2487);
        public static readonly ItemType TropicalBarracuda = new ItemType(2488);
        public static readonly ItemType KingSlimeTrophy = new ItemType(2489);
        public static readonly ItemType ShipInABottle = new ItemType(2490);
        public static readonly ItemType HardySaddle = new ItemType(2491);
        public static readonly ItemType PressurePlateTrack = new ItemType(2492);
        public static readonly ItemType KingSlimeMask = new ItemType(2493);
        public static readonly ItemType FinWings = new ItemType(2494);
        public static readonly ItemType TreasureMap = new ItemType(2495);
        public static readonly ItemType SeaweedPlanter = new ItemType(2496);
        public static readonly ItemType PillaginMePixels = new ItemType(2497);
        public static readonly ItemType FishCostumeMask = new ItemType(2498);
        public static readonly ItemType FishCostumeShirt = new ItemType(2499);
        public static readonly ItemType FishCostumeFinskirt = new ItemType(2500);
        public static readonly ItemType GingerBeard = new ItemType(2501);
        public static readonly ItemType HoneyedGoggles = new ItemType(2502);
        public static readonly ItemType BorealWood = new ItemType(2503);
        public static readonly ItemType PalmWood = new ItemType(2504);
        public static readonly ItemType BorealWoodWall = new ItemType(2505);
        public static readonly ItemType PalmWoodWall = new ItemType(2506);
        public static readonly ItemType BorealWoodFence = new ItemType(2507);
        public static readonly ItemType PalmWoodFence = new ItemType(2508);
        public static readonly ItemType BorealWoodHelmet = new ItemType(2509);
        public static readonly ItemType BorealWoodBreastplate = new ItemType(2510);
        public static readonly ItemType BorealWoodGreaves = new ItemType(2511);
        public static readonly ItemType PalmWoodHelmet = new ItemType(2512);
        public static readonly ItemType PalmWoodBreastplate = new ItemType(2513);
        public static readonly ItemType PalmWoodGreaves = new ItemType(2514);
        public static readonly ItemType PalmWoodBow = new ItemType(2515);
        public static readonly ItemType PalmWoodHammer = new ItemType(2516);
        public static readonly ItemType PalmWoodSword = new ItemType(2517);
        public static readonly ItemType PalmWoodPlatform = new ItemType(2518);
        public static readonly ItemType PalmWoodBathtub = new ItemType(2519);
        public static readonly ItemType PalmWoodBed = new ItemType(2520);
        public static readonly ItemType PalmWoodBench = new ItemType(2521);
        public static readonly ItemType PalmWoodCandelabra = new ItemType(2522);
        public static readonly ItemType PalmWoodCandle = new ItemType(2523);
        public static readonly ItemType PalmWoodChair = new ItemType(2524);
        public static readonly ItemType PalmWoodChandelier = new ItemType(2525);
        public static readonly ItemType PalmWoodChest = new ItemType(2526);
        public static readonly ItemType PalmWoodSofa = new ItemType(2527);
        public static readonly ItemType PalmWoodDoor = new ItemType(2528);
        public static readonly ItemType PalmWoodDresser = new ItemType(2529);
        public static readonly ItemType PalmWoodLantern = new ItemType(2530);
        public static readonly ItemType PalmWoodPiano = new ItemType(2531);
        public static readonly ItemType PalmWoodTable = new ItemType(2532);
        public static readonly ItemType PalmWoodLamp = new ItemType(2533);
        public static readonly ItemType PalmWoodWorkBench = new ItemType(2534);
        public static readonly ItemType OpticStaff = new ItemType(2535);
        public static readonly ItemType PalmWoodBookcase = new ItemType(2536);
        public static readonly ItemType MushroomBathtub = new ItemType(2537);
        public static readonly ItemType MushroomBed = new ItemType(2538);
        public static readonly ItemType MushroomBench = new ItemType(2539);
        public static readonly ItemType MushroomBookcase = new ItemType(2540);
        public static readonly ItemType MushroomCandelabra = new ItemType(2541);
        public static readonly ItemType MushroomCandle = new ItemType(2542);
        public static readonly ItemType MushroomChandelier = new ItemType(2543);
        public static readonly ItemType MushroomChest = new ItemType(2544);
        public static readonly ItemType MushroomDresser = new ItemType(2545);
        public static readonly ItemType MushroomLantern = new ItemType(2546);
        public static readonly ItemType MushroomLamp = new ItemType(2547);
        public static readonly ItemType MushroomPiano = new ItemType(2548);
        public static readonly ItemType MushroomPlatform = new ItemType(2549);
        public static readonly ItemType MushroomTable = new ItemType(2550);
        public static readonly ItemType SpiderStaff = new ItemType(2551);
        public static readonly ItemType BorealWoodBathtub = new ItemType(2552);
        public static readonly ItemType BorealWoodBed = new ItemType(2553);
        public static readonly ItemType BorealWoodBookcase = new ItemType(2554);
        public static readonly ItemType BorealWoodCandelabra = new ItemType(2555);
        public static readonly ItemType BorealWoodCandle = new ItemType(2556);
        public static readonly ItemType BorealWoodChair = new ItemType(2557);
        public static readonly ItemType BorealWoodChandelier = new ItemType(2558);
        public static readonly ItemType BorealWoodChest = new ItemType(2559);
        public static readonly ItemType BorealWoodClock = new ItemType(2560);
        public static readonly ItemType BorealWoodDoor = new ItemType(2561);
        public static readonly ItemType BorealWoodDresser = new ItemType(2562);
        public static readonly ItemType BorealWoodLamp = new ItemType(2563);
        public static readonly ItemType BorealWoodLantern = new ItemType(2564);
        public static readonly ItemType BorealWoodPiano = new ItemType(2565);
        public static readonly ItemType BorealWoodPlatform = new ItemType(2566);
        public static readonly ItemType SlimeBathtub = new ItemType(2567);
        public static readonly ItemType SlimeBed = new ItemType(2568);
        public static readonly ItemType SlimeBookcase = new ItemType(2569);
        public static readonly ItemType SlimeCandelabra = new ItemType(2570);
        public static readonly ItemType SlimeCandle = new ItemType(2571);
        public static readonly ItemType SlimeChair = new ItemType(2572);
        public static readonly ItemType SlimeChandelier = new ItemType(2573);
        public static readonly ItemType SlimeChest = new ItemType(2574);
        public static readonly ItemType SlimeClock = new ItemType(2575);
        public static readonly ItemType SlimeDoor = new ItemType(2576);
        public static readonly ItemType SlimeDresser = new ItemType(2577);
        public static readonly ItemType SlimeLamp = new ItemType(2578);
        public static readonly ItemType SlimeLantern = new ItemType(2579);
        public static readonly ItemType SlimePiano = new ItemType(2580);
        public static readonly ItemType SlimePlatform = new ItemType(2581);
        public static readonly ItemType SlimeSofa = new ItemType(2582);
        public static readonly ItemType SlimeTable = new ItemType(2583);
        public static readonly ItemType PirateStaff = new ItemType(2584);
        public static readonly ItemType SlimeHook = new ItemType(2585);
        public static readonly ItemType StickyGrenade = new ItemType(2586);
        public static readonly ItemType TartarSauce = new ItemType(2587);
        public static readonly ItemType DukeFishronMask = new ItemType(2588);
        public static readonly ItemType DukeFishronTrophy = new ItemType(2589);
        public static readonly ItemType MolotovCocktail = new ItemType(2590);
        public static readonly ItemType BoneClock = new ItemType(2591);
        public static readonly ItemType CactusClock = new ItemType(2592);
        public static readonly ItemType EbonwoodClock = new ItemType(2593);
        public static readonly ItemType FrozenClock = new ItemType(2594);
        public static readonly ItemType LihzahrdClock = new ItemType(2595);
        public static readonly ItemType LivingWoodClock = new ItemType(2596);
        public static readonly ItemType RichMahoganyClock = new ItemType(2597);
        public static readonly ItemType FleshClock = new ItemType(2598);
        public static readonly ItemType MushroomClock = new ItemType(2599);
        public static readonly ItemType ObsidianClock = new ItemType(2600);
        public static readonly ItemType PalmWoodClock = new ItemType(2601);
        public static readonly ItemType PearlwoodClock = new ItemType(2602);
        public static readonly ItemType PumpkinClock = new ItemType(2603);
        public static readonly ItemType ShadewoodClock = new ItemType(2604);
        public static readonly ItemType SpookyClock = new ItemType(2605);
        public static readonly ItemType SkywareClock = new ItemType(2606);
        public static readonly ItemType SpiderFang = new ItemType(2607);
        public static readonly ItemType FalconBlade = new ItemType(2608);
        public static readonly ItemType FishronWings = new ItemType(2609);
        public static readonly ItemType SlimeGun = new ItemType(2610);
        public static readonly ItemType Flairon = new ItemType(2611);
        public static readonly ItemType GreenDungeonChest = new ItemType(2612);
        public static readonly ItemType PinkDungeonChest = new ItemType(2613);
        public static readonly ItemType BlueDungeonChest = new ItemType(2614);
        public static readonly ItemType BoneChest = new ItemType(2615);
        public static readonly ItemType CactusChest = new ItemType(2616);
        public static readonly ItemType FleshChest = new ItemType(2617);
        public static readonly ItemType ObsidianChest = new ItemType(2618);
        public static readonly ItemType PumpkinChest = new ItemType(2619);
        public static readonly ItemType SpookyChest = new ItemType(2620);
        public static readonly ItemType TempestStaff = new ItemType(2621);
        public static readonly ItemType RazorbladeTyphoon = new ItemType(2622);
        public static readonly ItemType BubbleGun = new ItemType(2623);
        public static readonly ItemType Tsunami = new ItemType(2624);
        public static readonly ItemType Seashell = new ItemType(2625);
        public static readonly ItemType Starfish = new ItemType(2626);
        public static readonly ItemType SteampunkPlatform = new ItemType(2627);
        public static readonly ItemType SkywarePlatform = new ItemType(2628);
        public static readonly ItemType LivingWoodPlatform = new ItemType(2629);
        public static readonly ItemType HoneyPlatform = new ItemType(2630);
        public static readonly ItemType SkywareWorkBench = new ItemType(2631);
        public static readonly ItemType GlassWorkBench = new ItemType(2632);
        public static readonly ItemType LivingWoodWorkBench = new ItemType(2633);
        public static readonly ItemType FleshSofa = new ItemType(2634);
        public static readonly ItemType FrozenSofa = new ItemType(2635);
        public static readonly ItemType LivingWoodSofa = new ItemType(2636);
        public static readonly ItemType PumpkinDresser = new ItemType(2637);
        public static readonly ItemType SteampunkDresser = new ItemType(2638);
        public static readonly ItemType GlassDresser = new ItemType(2639);
        public static readonly ItemType FleshDresser = new ItemType(2640);
        public static readonly ItemType PumpkinLantern = new ItemType(2641);
        public static readonly ItemType ObsidianLantern = new ItemType(2642);
        public static readonly ItemType PumpkinLamp = new ItemType(2643);
        public static readonly ItemType ObsidianLamp = new ItemType(2644);
        public static readonly ItemType BlueDungeonLamp = new ItemType(2645);
        public static readonly ItemType GreenDungeonLamp = new ItemType(2646);
        public static readonly ItemType PinkDungeonLamp = new ItemType(2647);
        public static readonly ItemType HoneyCandle = new ItemType(2648);
        public static readonly ItemType SteampunkCandle = new ItemType(2649);
        public static readonly ItemType SpookyCandle = new ItemType(2650);
        public static readonly ItemType ObsidianCandle = new ItemType(2651);
        public static readonly ItemType BlueDungeonChandelier = new ItemType(2652);
        public static readonly ItemType GreenDungeonChandelier = new ItemType(2653);
        public static readonly ItemType PinkDungeonChandelier = new ItemType(2654);
        public static readonly ItemType SteampunkChandelier = new ItemType(2655);
        public static readonly ItemType PumpkinChandelier = new ItemType(2656);
        public static readonly ItemType ObsidianChandelier = new ItemType(2657);
        public static readonly ItemType BlueDungeonBathtub = new ItemType(2658);
        public static readonly ItemType GreenDungeonBathtub = new ItemType(2659);
        public static readonly ItemType PinkDungeonBathtub = new ItemType(2660);
        public static readonly ItemType PumpkinBathtub = new ItemType(2661);
        public static readonly ItemType ObsidianBathtub = new ItemType(2662);
        public static readonly ItemType GoldenBathtub = new ItemType(2663);
        public static readonly ItemType BlueDungeonCandelabra = new ItemType(2664);
        public static readonly ItemType GreenDungeonCandelabra = new ItemType(2665);
        public static readonly ItemType PinkDungeonCandelabra = new ItemType(2666);
        public static readonly ItemType ObsidianCandelabra = new ItemType(2667);
        public static readonly ItemType PumpkinCandelabra = new ItemType(2668);
        public static readonly ItemType PumpkinBed = new ItemType(2669);
        public static readonly ItemType PumpkinBookcase = new ItemType(2670);
        public static readonly ItemType PumpkinPiano = new ItemType(2671);
        public static readonly ItemType SharkStatue = new ItemType(2672);
        public static readonly ItemType TruffleWorm = new ItemType(2673);
        public static readonly ItemType ApprenticeBait = new ItemType(2674);
        public static readonly ItemType JourneymanBait = new ItemType(2675);
        public static readonly ItemType MasterBait = new ItemType(2676);
        public static readonly ItemType AmberGemsparkWall = new ItemType(2677);
        public static readonly ItemType OfflineAmberGemsparkWall = new ItemType(2678);
        public static readonly ItemType AmethystGemsparkWall = new ItemType(2679);
        public static readonly ItemType OfflineAmethystGemsparkWall = new ItemType(2680);
        public static readonly ItemType DiamondGemsparkWall = new ItemType(2681);
        public static readonly ItemType OfflineDiamondGemsparkWall = new ItemType(2682);
        public static readonly ItemType EmeraldGemsparkWall = new ItemType(2683);
        public static readonly ItemType OfflineEmeraldGemsparkWall = new ItemType(2684);
        public static readonly ItemType RubyGemsparkWall = new ItemType(2685);
        public static readonly ItemType OfflineRubyGemsparkWall = new ItemType(2686);
        public static readonly ItemType SapphireGemsparkWall = new ItemType(2687);
        public static readonly ItemType OfflineSapphireGemsparkWall = new ItemType(2688);
        public static readonly ItemType TopazGemsparkWall = new ItemType(2689);
        public static readonly ItemType OfflineTopazGemsparkWall = new ItemType(2690);
        public static readonly ItemType TinPlatingWall = new ItemType(2691);
        public static readonly ItemType TinPlating = new ItemType(2692);
        public static readonly ItemType WaterfallBlock = new ItemType(2693);
        public static readonly ItemType LavafallBlock = new ItemType(2694);
        public static readonly ItemType ConfettiBlock = new ItemType(2695);
        public static readonly ItemType ConfettiWall = new ItemType(2696);
        public static readonly ItemType MidnightConfettiBlock = new ItemType(2697);
        public static readonly ItemType MidnightConfettiWall = new ItemType(2698);
        public static readonly ItemType WeaponRack = new ItemType(2699);
        public static readonly ItemType FireworksBox = new ItemType(2700);
        public static readonly ItemType LivingFireBlock = new ItemType(2701);
        public static readonly ItemType ZeroStatue = new ItemType(2702);
        public static readonly ItemType OneStatue = new ItemType(2703);
        public static readonly ItemType TwoStatue = new ItemType(2704);
        public static readonly ItemType ThreeStatue = new ItemType(2705);
        public static readonly ItemType FourStatue = new ItemType(2706);
        public static readonly ItemType FiveStatue = new ItemType(2707);
        public static readonly ItemType SixStatue = new ItemType(2708);
        public static readonly ItemType SevenStatue = new ItemType(2709);
        public static readonly ItemType EightStatue = new ItemType(2710);
        public static readonly ItemType NineStatue = new ItemType(2711);
        public static readonly ItemType AStatue = new ItemType(2712);
        public static readonly ItemType BStatue = new ItemType(2713);
        public static readonly ItemType CStatue = new ItemType(2714);
        public static readonly ItemType DStatue = new ItemType(2715);
        public static readonly ItemType EStatue = new ItemType(2716);
        public static readonly ItemType FStatue = new ItemType(2717);
        public static readonly ItemType GStatue = new ItemType(2718);
        public static readonly ItemType HStatue = new ItemType(2719);
        public static readonly ItemType IStatue = new ItemType(2720);
        public static readonly ItemType JStatue = new ItemType(2721);
        public static readonly ItemType KStatue = new ItemType(2722);
        public static readonly ItemType LStatue = new ItemType(2723);
        public static readonly ItemType MStatue = new ItemType(2724);
        public static readonly ItemType NStatue = new ItemType(2725);
        public static readonly ItemType OStatue = new ItemType(2726);
        public static readonly ItemType PStatue = new ItemType(2727);
        public static readonly ItemType QStatue = new ItemType(2728);
        public static readonly ItemType RStatue = new ItemType(2729);
        public static readonly ItemType SStatue = new ItemType(2730);
        public static readonly ItemType TStatue = new ItemType(2731);
        public static readonly ItemType UStatue = new ItemType(2732);
        public static readonly ItemType VStatue = new ItemType(2733);
        public static readonly ItemType WStatue = new ItemType(2734);
        public static readonly ItemType XStatue = new ItemType(2735);
        public static readonly ItemType YStatue = new ItemType(2736);
        public static readonly ItemType ZStatue = new ItemType(2737);
        public static readonly ItemType FireworkFountain = new ItemType(2738);
        public static readonly ItemType BoosterTrack = new ItemType(2739);
        public static readonly ItemType Grasshopper = new ItemType(2740);
        public static readonly ItemType GrasshopperCage = new ItemType(2741);
        public static readonly ItemType MusicBoxUndergroundCrimson = new ItemType(2742);
        public static readonly ItemType CactusTable = new ItemType(2743);
        public static readonly ItemType CactusPlatform = new ItemType(2744);
        public static readonly ItemType BorealWoodSword = new ItemType(2745);
        public static readonly ItemType BorealWoodHammer = new ItemType(2746);
        public static readonly ItemType BorealWoodBow = new ItemType(2747);
        public static readonly ItemType GlassChest = new ItemType(2748);
        public static readonly ItemType XenoStaff = new ItemType(2749);
        public static readonly ItemType MeteorStaff = new ItemType(2750);
        public static readonly ItemType LivingCursedFireBlock = new ItemType(2751);
        public static readonly ItemType LivingDemonFireBlock = new ItemType(2752);
        public static readonly ItemType LivingFrostFireBlock = new ItemType(2753);
        public static readonly ItemType LivingIchorBlock = new ItemType(2754);
        public static readonly ItemType LivingUltrabrightFireBlock = new ItemType(2755);
        public static readonly ItemType GenderChangePotion = new ItemType(2756);
        public static readonly ItemType VortexHelmet = new ItemType(2757);
        public static readonly ItemType VortexBreastplate = new ItemType(2758);
        public static readonly ItemType VortexLeggings = new ItemType(2759);
        public static readonly ItemType NebulaHelmet = new ItemType(2760);
        public static readonly ItemType NebulaBreastplate = new ItemType(2761);
        public static readonly ItemType NebulaLeggings = new ItemType(2762);
        public static readonly ItemType SolarFlareHelmet = new ItemType(2763);
        public static readonly ItemType SolarFlareBreastplate = new ItemType(2764);
        public static readonly ItemType SolarFlareLeggings = new ItemType(2765);
        public static readonly ItemType SolarTabletFragment = new ItemType(2766);
        public static readonly ItemType SolarTablet = new ItemType(2767);
        public static readonly ItemType DrillContainmentUnit = new ItemType(2768);
        public static readonly ItemType CosmicCarKey = new ItemType(2769);
        public static readonly ItemType MothronWings = new ItemType(2770);
        public static readonly ItemType BrainScrambler = new ItemType(2771);
        public static readonly ItemType VortexPickaxe = new ItemType(2776);
        public static readonly ItemType NebulaPickaxe = new ItemType(2781);
        public static readonly ItemType SolarFlarePickaxe = new ItemType(2786);
        public static readonly ItemType HoneyfallBlock = new ItemType(2787);
        public static readonly ItemType HoneyfallWall = new ItemType(2788);
        public static readonly ItemType ChlorophyteBrickWall = new ItemType(2789);
        public static readonly ItemType CrimtaneBrickWall = new ItemType(2790);
        public static readonly ItemType ShroomitePlatingWall = new ItemType(2791);
        public static readonly ItemType ChlorophyteBrick = new ItemType(2792);
        public static readonly ItemType CrimtaneBrick = new ItemType(2793);
        public static readonly ItemType ShroomitePlating = new ItemType(2794);
        public static readonly ItemType LaserMachinegun = new ItemType(2795);
        public static readonly ItemType ElectrosphereLauncher = new ItemType(2796);
        public static readonly ItemType Xenopopper = new ItemType(2797);
        public static readonly ItemType LaserDrill = new ItemType(2798);
        public static readonly ItemType MechanicalRuler = new ItemType(2799);
        public static readonly ItemType AntiGravityHook = new ItemType(2800);
        public static readonly ItemType MoonMask = new ItemType(2801);
        public static readonly ItemType SunMask = new ItemType(2802);
        public static readonly ItemType MartianCostumeMask = new ItemType(2803);
        public static readonly ItemType MartianCostumeShirt = new ItemType(2804);
        public static readonly ItemType MartianCostumePants = new ItemType(2805);
        public static readonly ItemType MartianUniformHelmet = new ItemType(2806);
        public static readonly ItemType MartianUniformTorso = new ItemType(2807);
        public static readonly ItemType MartianUniformPants = new ItemType(2808);
        public static readonly ItemType MartianAstroClock = new ItemType(2809);
        public static readonly ItemType MartianBathtub = new ItemType(2810);
        public static readonly ItemType MartianBed = new ItemType(2811);
        public static readonly ItemType MartianHoverChair = new ItemType(2812);
        public static readonly ItemType MartianChandelier = new ItemType(2813);
        public static readonly ItemType MartianChest = new ItemType(2814);
        public static readonly ItemType MartianDoor = new ItemType(2815);
        public static readonly ItemType MartianDresser = new ItemType(2816);
        public static readonly ItemType MartianHolobookcase = new ItemType(2817);
        public static readonly ItemType MartianHoverCandle = new ItemType(2818);
        public static readonly ItemType MartianLamppost = new ItemType(2819);
        public static readonly ItemType MartianLantern = new ItemType(2820);
        public static readonly ItemType MartianPiano = new ItemType(2821);
        public static readonly ItemType MartianPlatform = new ItemType(2822);
        public static readonly ItemType MartianSofa = new ItemType(2823);
        public static readonly ItemType MartianTable = new ItemType(2824);
        public static readonly ItemType MartianTableLamp = new ItemType(2825);
        public static readonly ItemType MartianWorkBench = new ItemType(2826);
        public static readonly ItemType WoodenSink = new ItemType(2827);
        public static readonly ItemType EbonwoodSink = new ItemType(2828);
        public static readonly ItemType RichMahoganySink = new ItemType(2829);
        public static readonly ItemType PearlwoodSink = new ItemType(2830);
        public static readonly ItemType BoneSink = new ItemType(2831);
        public static readonly ItemType FleshSink = new ItemType(2832);
        public static readonly ItemType LivingWoodSink = new ItemType(2833);
        public static readonly ItemType SkywareSink = new ItemType(2834);
        public static readonly ItemType ShadewoodSink = new ItemType(2835);
        public static readonly ItemType LihzahrdSink = new ItemType(2836);
        public static readonly ItemType BlueDungeonSink = new ItemType(2837);
        public static readonly ItemType GreenDungeonSink = new ItemType(2838);
        public static readonly ItemType PinkDungeonSink = new ItemType(2839);
        public static readonly ItemType ObsidianSink = new ItemType(2840);
        public static readonly ItemType MetalSink = new ItemType(2841);
        public static readonly ItemType GlassSink = new ItemType(2842);
        public static readonly ItemType GoldenSink = new ItemType(2843);
        public static readonly ItemType HoneySink = new ItemType(2844);
        public static readonly ItemType SteampunkSink = new ItemType(2845);
        public static readonly ItemType PumpkinSink = new ItemType(2846);
        public static readonly ItemType SpookySink = new ItemType(2847);
        public static readonly ItemType FrozenSink = new ItemType(2848);
        public static readonly ItemType DynastySink = new ItemType(2849);
        public static readonly ItemType PalmWoodSink = new ItemType(2850);
        public static readonly ItemType MushroomSink = new ItemType(2851);
        public static readonly ItemType BorealWoodSink = new ItemType(2852);
        public static readonly ItemType SlimeSink = new ItemType(2853);
        public static readonly ItemType CactusSink = new ItemType(2854);
        public static readonly ItemType MartianSink = new ItemType(2855);
        public static readonly ItemType SolarCultistHood = new ItemType(2856);
        public static readonly ItemType LunarCultistHood = new ItemType(2857);
        public static readonly ItemType SolarCultistRobe = new ItemType(2858);
        public static readonly ItemType LunarCultistRobe = new ItemType(2859);
        public static readonly ItemType MartianConduitPlating = new ItemType(2860);
        public static readonly ItemType MartianConduitWall = new ItemType(2861);
        public static readonly ItemType HiTekSunglasses = new ItemType(2862);
        public static readonly ItemType MartianHairDye = new ItemType(2863);
        public static readonly ItemType MartianDye = new ItemType(2864);
        public static readonly ItemType CastleMarsberg = new ItemType(2865);
        public static readonly ItemType MartiaLisa = new ItemType(2866);
        public static readonly ItemType TheTruthIsUpThere = new ItemType(2867);
        public static readonly ItemType SmokeBlock = new ItemType(2868);
        public static readonly ItemType LivingFlameDye = new ItemType(2869);
        public static readonly ItemType LivingRainbowDye = new ItemType(2870);
        public static readonly ItemType ShadowDye = new ItemType(2871);
        public static readonly ItemType NegativeDye = new ItemType(2872);
        public static readonly ItemType LivingOceanDye = new ItemType(2873);
        public static readonly ItemType BrownDye = new ItemType(2874);
        public static readonly ItemType BrownandBlackDye = new ItemType(2875);
        public static readonly ItemType BrightBrownDye = new ItemType(2876);
        public static readonly ItemType BrownandSilverDye = new ItemType(2877);
        public static readonly ItemType WispDye = new ItemType(2878);
        public static readonly ItemType PixieDye = new ItemType(2879);
        public static readonly ItemType InfluxWaver = new ItemType(2880);
        public static readonly ItemType ChargedBlasterCannon = new ItemType(2882);
        public static readonly ItemType ChlorophyteDye = new ItemType(2883);
        public static readonly ItemType UnicornWispDye = new ItemType(2884);
        public static readonly ItemType InfernalWispDye = new ItemType(2885);
        public static readonly ItemType ViciousPowder = new ItemType(2886);
        public static readonly ItemType ViciousMushroom = new ItemType(2887);
        public static readonly ItemType TheBeesKnees = new ItemType(2888);
        public static readonly ItemType GoldBird = new ItemType(2889);
        public static readonly ItemType GoldBunny = new ItemType(2890);
        public static readonly ItemType GoldButterfly = new ItemType(2891);
        public static readonly ItemType GoldFrog = new ItemType(2892);
        public static readonly ItemType GoldGrasshopper = new ItemType(2893);
        public static readonly ItemType GoldMouse = new ItemType(2894);
        public static readonly ItemType GoldWorm = new ItemType(2895);
        public static readonly ItemType StickyDynamite = new ItemType(2896);
        public static readonly ItemType AngryTrapperBanner = new ItemType(2897);
        public static readonly ItemType ArmoredVikingBanner = new ItemType(2898);
        public static readonly ItemType BlackSlimeBanner = new ItemType(2899);
        public static readonly ItemType BlueArmoredBonesBanner = new ItemType(2900);
        public static readonly ItemType BlueCultistArcherBanner = new ItemType(2901);
        public static readonly ItemType BlueCultistCasterBanner = new ItemType(2902);
        public static readonly ItemType BlueCultistFighterBanner = new ItemType(2903);
        public static readonly ItemType BoneLeeBanner = new ItemType(2904);
        public static readonly ItemType ClingerBanner = new ItemType(2905);
        public static readonly ItemType CochinealBeetleBanner = new ItemType(2906);
        public static readonly ItemType CorruptPenguinBanner = new ItemType(2907);
        public static readonly ItemType CorruptSlimeBanner = new ItemType(2908);
        public static readonly ItemType CorruptorBanner = new ItemType(2909);
        public static readonly ItemType CrimslimeBanner = new ItemType(2910);
        public static readonly ItemType CursedSkullBanner = new ItemType(2911);
        public static readonly ItemType CyanBeetleBanner = new ItemType(2912);
        public static readonly ItemType DevourerBanner = new ItemType(2913);
        public static readonly ItemType DiabolistBanner = new ItemType(2914);
        public static readonly ItemType DoctorBonesBanner = new ItemType(2915);
        public static readonly ItemType DungeonSlimeBanner = new ItemType(2916);
        public static readonly ItemType DungeonSpiritBanner = new ItemType(2917);
        public static readonly ItemType ElfArcherBanner = new ItemType(2918);
        public static readonly ItemType ElfCopterBanner = new ItemType(2919);
        public static readonly ItemType EyezorBanner = new ItemType(2920);
        public static readonly ItemType FlockoBanner = new ItemType(2921);
        public static readonly ItemType GhostBanner = new ItemType(2922);
        public static readonly ItemType GiantBatBanner = new ItemType(2923);
        public static readonly ItemType GiantCursedSkullBanner = new ItemType(2924);
        public static readonly ItemType GiantFlyingFoxBanner = new ItemType(2925);
        public static readonly ItemType GingerbreadManBanner = new ItemType(2926);
        public static readonly ItemType GoblinArcherBanner = new ItemType(2927);
        public static readonly ItemType GreenSlimeBanner = new ItemType(2928);
        public static readonly ItemType HeadlessHorsemanBanner = new ItemType(2929);
        public static readonly ItemType HellArmoredBonesBanner = new ItemType(2930);
        public static readonly ItemType HellhoundBanner = new ItemType(2931);
        public static readonly ItemType HoppinJackBanner = new ItemType(2932);
        public static readonly ItemType IceBatBanner = new ItemType(2933);
        public static readonly ItemType IceGolemBanner = new ItemType(2934);
        public static readonly ItemType IceSlimeBanner = new ItemType(2935);
        public static readonly ItemType IchorStickerBanner = new ItemType(2936);
        public static readonly ItemType IlluminantBatBanner = new ItemType(2937);
        public static readonly ItemType IlluminantSlimeBanner = new ItemType(2938);
        public static readonly ItemType JungleBatBanner = new ItemType(2939);
        public static readonly ItemType JungleSlimeBanner = new ItemType(2940);
        public static readonly ItemType KrampusBanner = new ItemType(2941);
        public static readonly ItemType LacBeetleBanner = new ItemType(2942);
        public static readonly ItemType LavaBatBanner = new ItemType(2943);
        public static readonly ItemType LavaSlimeBanner = new ItemType(2944);
        public static readonly ItemType MartianBrainscramblerBanner = new ItemType(2945);
        public static readonly ItemType MartianDroneBanner = new ItemType(2946);
        public static readonly ItemType MartianEngineerBanner = new ItemType(2947);
        public static readonly ItemType MartianGigazapperBanner = new ItemType(2948);
        public static readonly ItemType MartianGrayGruntBanner = new ItemType(2949);
        public static readonly ItemType MartianOfficerBanner = new ItemType(2950);
        public static readonly ItemType MartianRayGunnerBanner = new ItemType(2951);
        public static readonly ItemType MartianScutlixGunnerBanner = new ItemType(2952);
        public static readonly ItemType MartianTeslaTurretBanner = new ItemType(2953);
        public static readonly ItemType MisterStabbyBanner = new ItemType(2954);
        public static readonly ItemType MotherSlimeBanner = new ItemType(2955);
        public static readonly ItemType NecromancerBanner = new ItemType(2956);
        public static readonly ItemType NutcrackerBanner = new ItemType(2957);
        public static readonly ItemType PaladinBanner = new ItemType(2958);
        public static readonly ItemType PenguinBanner = new ItemType(2959);
        public static readonly ItemType PinkyBanner = new ItemType(2960);
        public static readonly ItemType PoltergeistBanner = new ItemType(2961);
        public static readonly ItemType PossessedArmorBanner = new ItemType(2962);
        public static readonly ItemType PresentMimicBanner = new ItemType(2963);
        public static readonly ItemType PurpleSlimeBanner = new ItemType(2964);
        public static readonly ItemType RaggedCasterBanner = new ItemType(2965);
        public static readonly ItemType RainbowSlimeBanner = new ItemType(2966);
        public static readonly ItemType RavenBanner = new ItemType(2967);
        public static readonly ItemType RedSlimeBanner = new ItemType(2968);
        public static readonly ItemType RuneWizardBanner = new ItemType(2969);
        public static readonly ItemType RustyArmoredBonesBanner = new ItemType(2970);
        public static readonly ItemType ScarecrowBanner = new ItemType(2971);
        public static readonly ItemType ScutlixBanner = new ItemType(2972);
        public static readonly ItemType SkeletonArcherBanner = new ItemType(2973);
        public static readonly ItemType SkeletonCommandoBanner = new ItemType(2974);
        public static readonly ItemType SkeletonSniperBanner = new ItemType(2975);
        public static readonly ItemType SlimerBanner = new ItemType(2976);
        public static readonly ItemType SnatcherBanner = new ItemType(2977);
        public static readonly ItemType SnowBallaBanner = new ItemType(2978);
        public static readonly ItemType SnowmanGangstaBanner = new ItemType(2979);
        public static readonly ItemType SpikedIceSlimeBanner = new ItemType(2980);
        public static readonly ItemType SpikedJungleSlimeBanner = new ItemType(2981);
        public static readonly ItemType SplinterlingBanner = new ItemType(2982);
        public static readonly ItemType SquidBanner = new ItemType(2983);
        public static readonly ItemType TacticalSkeletonBanner = new ItemType(2984);
        public static readonly ItemType TheGroomBanner = new ItemType(2985);
        public static readonly ItemType TimBanner = new ItemType(2986);
        public static readonly ItemType UndeadMinerBanner = new ItemType(2987);
        public static readonly ItemType UndeadVikingBanner = new ItemType(2988);
        public static readonly ItemType WhiteCultistArcherBanner = new ItemType(2989);
        public static readonly ItemType WhiteCultistCasterBanner = new ItemType(2990);
        public static readonly ItemType WhiteCultistFighterBanner = new ItemType(2991);
        public static readonly ItemType YellowSlimeBanner = new ItemType(2992);
        public static readonly ItemType YetiBanner = new ItemType(2993);
        public static readonly ItemType ZombieElfBanner = new ItemType(2994);
        public static readonly ItemType Sparky = new ItemType(2995);
        public static readonly ItemType VineRope = new ItemType(2996);
        public static readonly ItemType WormholePotion = new ItemType(2997);
        public static readonly ItemType SummonerEmblem = new ItemType(2998);
        public static readonly ItemType BewitchingTable = new ItemType(2999);
        public static readonly ItemType AlchemyTable = new ItemType(3000);
        public static readonly ItemType StrangeBrew = new ItemType(3001);
        public static readonly ItemType SpelunkerGlowstick = new ItemType(3002);
        public static readonly ItemType BoneArrow = new ItemType(3003);
        public static readonly ItemType BoneTorch = new ItemType(3004);
        public static readonly ItemType VineRopeCoil = new ItemType(3005);
        public static readonly ItemType LifeDrain = new ItemType(3006);
        public static readonly ItemType DartPistol = new ItemType(3007);
        public static readonly ItemType DartRifle = new ItemType(3008);
        public static readonly ItemType CrystalDart = new ItemType(3009);
        public static readonly ItemType CursedDart = new ItemType(3010);
        public static readonly ItemType IchorDart = new ItemType(3011);
        public static readonly ItemType ChainGuillotines = new ItemType(3012);
        public static readonly ItemType FetidBaghnakhs = new ItemType(3013);
        public static readonly ItemType ClingerStaff = new ItemType(3014);
        public static readonly ItemType PutridScent = new ItemType(3015);
        public static readonly ItemType FleshKnuckles = new ItemType(3016);
        public static readonly ItemType FlowerBoots = new ItemType(3017);
        public static readonly ItemType Seedler = new ItemType(3018);
        public static readonly ItemType HellwingBow = new ItemType(3019);
        public static readonly ItemType TendonHook = new ItemType(3020);
        public static readonly ItemType ThornHook = new ItemType(3021);
        public static readonly ItemType IlluminantHook = new ItemType(3022);
        public static readonly ItemType WormHook = new ItemType(3023);
        public static readonly ItemType SkiphssBlood = new ItemType(3024);
        public static readonly ItemType PurpleOozeDye = new ItemType(3025);
        public static readonly ItemType ReflectiveSilverDye = new ItemType(3026);
        public static readonly ItemType ReflectiveGoldDye = new ItemType(3027);
        public static readonly ItemType BlueAcidDye = new ItemType(3028);
        public static readonly ItemType DaedalusStormbow = new ItemType(3029);
        public static readonly ItemType FlyingKnife = new ItemType(3030);
        public static readonly ItemType BottomlessWaterBucket = new ItemType(3031);
        public static readonly ItemType SuperAbsorbantSponge = new ItemType(3032);
        public static readonly ItemType GoldRing = new ItemType(3033);
        public static readonly ItemType CoinRing = new ItemType(3034);
        public static readonly ItemType GreedyRing = new ItemType(3035);
        public static readonly ItemType FishFinder = new ItemType(3036);
        public static readonly ItemType WeatherRadio = new ItemType(3037);
        public static readonly ItemType HadesDye = new ItemType(3038);
        public static readonly ItemType TwilightDye = new ItemType(3039);
        public static readonly ItemType AcidDye = new ItemType(3040);
        public static readonly ItemType GlowingMushroomDye = new ItemType(3041);
        public static readonly ItemType PhaseDye = new ItemType(3042);
        public static readonly ItemType MagicLantern = new ItemType(3043);
        public static readonly ItemType MusicBoxLunarBoss = new ItemType(3044);
        public static readonly ItemType RainbowTorch = new ItemType(3045);
        public static readonly ItemType CursedCampfire = new ItemType(3046);
        public static readonly ItemType DemonCampfire = new ItemType(3047);
        public static readonly ItemType FrozenCampfire = new ItemType(3048);
        public static readonly ItemType IchorCampfire = new ItemType(3049);
        public static readonly ItemType RainbowCampfire = new ItemType(3050);
        public static readonly ItemType CrystalVileShard = new ItemType(3051);
        public static readonly ItemType ShadowflameBow = new ItemType(3052);
        public static readonly ItemType ShadowflameHexDoll = new ItemType(3053);
        public static readonly ItemType ShadowflameKnife = new ItemType(3054);
        public static readonly ItemType Acorns = new ItemType(3055);
        public static readonly ItemType ColdSnap = new ItemType(3056);
        public static readonly ItemType CursedSaint = new ItemType(3057);
        public static readonly ItemType Snowfellas = new ItemType(3058);
        public static readonly ItemType TheSeason = new ItemType(3059);
        public static readonly ItemType BoneRattle = new ItemType(3060);
        public static readonly ItemType ArchitectGizmoPack = new ItemType(3061);
        public static readonly ItemType CrimsonHeart = new ItemType(3062);
        public static readonly ItemType Meowmere = new ItemType(3063);
        public static readonly ItemType EnchantedSundial = new ItemType(3064);
        public static readonly ItemType StarWrath = new ItemType(3065);
        public static readonly ItemType SmoothMarbleBlock = new ItemType(3066);
        public static readonly ItemType HellstoneBrickWall = new ItemType(3067);
        public static readonly ItemType GuidetoPlantFiberCordage = new ItemType(3068);
        public static readonly ItemType WandOfSparking = new ItemType(3069);
        public static readonly ItemType GoldBirdCage = new ItemType(3070);
        public static readonly ItemType GoldBunnyCage = new ItemType(3071);
        public static readonly ItemType GoldButterflyJar = new ItemType(3072);
        public static readonly ItemType GoldFrogCage = new ItemType(3073);
        public static readonly ItemType GoldGrasshopperCage = new ItemType(3074);
        public static readonly ItemType GoldMouseCage = new ItemType(3075);
        public static readonly ItemType GoldWormCage = new ItemType(3076);
        public static readonly ItemType SilkRope = new ItemType(3077);
        public static readonly ItemType WebRope = new ItemType(3078);
        public static readonly ItemType SilkRopeCoil = new ItemType(3079);
        public static readonly ItemType WebRopeCoil = new ItemType(3080);
        public static readonly ItemType MarbleBlock = new ItemType(3081);
        public static readonly ItemType MarbleWall = new ItemType(3082);
        public static readonly ItemType SmoothMarbleWall = new ItemType(3083);
        public static readonly ItemType Radar = new ItemType(3084);
        public static readonly ItemType GoldenLockBox = new ItemType(3085);
        public static readonly ItemType GraniteBlock = new ItemType(3086);
        public static readonly ItemType SmoothGraniteBlock = new ItemType(3087);
        public static readonly ItemType GraniteWall = new ItemType(3088);
        public static readonly ItemType SmoothGraniteWall = new ItemType(3089);
        public static readonly ItemType RoyalGel = new ItemType(3090);
        public static readonly ItemType KeyOfNight = new ItemType(3091);
        public static readonly ItemType KeyOfLight = new ItemType(3092);
        public static readonly ItemType HerbBag = new ItemType(3093);
        public static readonly ItemType Javelin = new ItemType(3094);
        public static readonly ItemType TallyCounter = new ItemType(3095);
        public static readonly ItemType Sextant = new ItemType(3096);
        public static readonly ItemType ShieldOfCthulhu = new ItemType(3097);
        public static readonly ItemType ButchersChainsaw = new ItemType(3098);
        public static readonly ItemType Stopwatch = new ItemType(3099);
        public static readonly ItemType MeteoriteBrick = new ItemType(3100);
        public static readonly ItemType MeteoriteBrickWall = new ItemType(3101);
        public static readonly ItemType MetalDetector = new ItemType(3102);
        public static readonly ItemType EndlessQuiver = new ItemType(3103);
        public static readonly ItemType EndlessMusketPouch = new ItemType(3104);
        public static readonly ItemType ToxicFlask = new ItemType(3105);
        public static readonly ItemType PsychoKnife = new ItemType(3106);
        public static readonly ItemType NailGun = new ItemType(3107);
        public static readonly ItemType Nail = new ItemType(3108);
        public static readonly ItemType NightVisionHelmet = new ItemType(3109);
        public static readonly ItemType CelestialShell = new ItemType(3110);
        public static readonly ItemType PinkGel = new ItemType(3111);
        public static readonly ItemType BouncyGlowstick = new ItemType(3112);
        public static readonly ItemType PinkSlimeBlock = new ItemType(3113);
        public static readonly ItemType PinkTorch = new ItemType(3114);
        public static readonly ItemType BouncyBomb = new ItemType(3115);
        public static readonly ItemType BouncyGrenade = new ItemType(3116);
        public static readonly ItemType PeaceCandle = new ItemType(3117);
        public static readonly ItemType LifeformAnalyzer = new ItemType(3118);
        public static readonly ItemType DpsMeter = new ItemType(3119);
        public static readonly ItemType FishermansPocketGuide = new ItemType(3120);
        public static readonly ItemType GoblinTech = new ItemType(3121);
        public static readonly ItemType Rek3000 = new ItemType(3122);
        public static readonly ItemType Pda = new ItemType(3123);
        public static readonly ItemType CellPhone = new ItemType(3124);
        public static readonly ItemType GraniteChest = new ItemType(3125);
        public static readonly ItemType MeteoriteClock = new ItemType(3126);
        public static readonly ItemType MarbleClock = new ItemType(3127);
        public static readonly ItemType GraniteClock = new ItemType(3128);
        public static readonly ItemType MeteoriteDoor = new ItemType(3129);
        public static readonly ItemType MarbleDoor = new ItemType(3130);
        public static readonly ItemType GraniteDoor = new ItemType(3131);
        public static readonly ItemType MeteoriteDresser = new ItemType(3132);
        public static readonly ItemType MarbleDresser = new ItemType(3133);
        public static readonly ItemType GraniteDresser = new ItemType(3134);
        public static readonly ItemType MeteoriteLamp = new ItemType(3135);
        public static readonly ItemType MarbleLamp = new ItemType(3136);
        public static readonly ItemType GraniteLamp = new ItemType(3137);
        public static readonly ItemType MeteoriteLantern = new ItemType(3138);
        public static readonly ItemType MarbleLantern = new ItemType(3139);
        public static readonly ItemType GraniteLantern = new ItemType(3140);
        public static readonly ItemType MeteoritePiano = new ItemType(3141);
        public static readonly ItemType MarblePiano = new ItemType(3142);
        public static readonly ItemType GranitePiano = new ItemType(3143);
        public static readonly ItemType MeteoritePlatform = new ItemType(3144);
        public static readonly ItemType MarblePlatform = new ItemType(3145);
        public static readonly ItemType GranitePlatform = new ItemType(3146);
        public static readonly ItemType MeteoriteSink = new ItemType(3147);
        public static readonly ItemType MarbleSink = new ItemType(3148);
        public static readonly ItemType GraniteSink = new ItemType(3149);
        public static readonly ItemType MeteoriteSofa = new ItemType(3150);
        public static readonly ItemType MarbleSofa = new ItemType(3151);
        public static readonly ItemType GraniteSofa = new ItemType(3152);
        public static readonly ItemType MeteoriteTable = new ItemType(3153);
        public static readonly ItemType MarbleTable = new ItemType(3154);
        public static readonly ItemType GraniteTable = new ItemType(3155);
        public static readonly ItemType MeteoriteWorkBench = new ItemType(3156);
        public static readonly ItemType MarbleWorkBench = new ItemType(3157);
        public static readonly ItemType GraniteWorkBench = new ItemType(3158);
        public static readonly ItemType MeteoriteBathtub = new ItemType(3159);
        public static readonly ItemType MarbleBathtub = new ItemType(3160);
        public static readonly ItemType GraniteBathtub = new ItemType(3161);
        public static readonly ItemType MeteoriteBed = new ItemType(3162);
        public static readonly ItemType MarbleBed = new ItemType(3163);
        public static readonly ItemType GraniteBed = new ItemType(3164);
        public static readonly ItemType MeteoriteBookcase = new ItemType(3165);
        public static readonly ItemType MarbleBookcase = new ItemType(3166);
        public static readonly ItemType GraniteBookcase = new ItemType(3167);
        public static readonly ItemType MeteoriteCandelabra = new ItemType(3168);
        public static readonly ItemType MarbleCandelabra = new ItemType(3169);
        public static readonly ItemType GraniteCandelabra = new ItemType(3170);
        public static readonly ItemType MeteoriteCandle = new ItemType(3171);
        public static readonly ItemType MarbleCandle = new ItemType(3172);
        public static readonly ItemType GraniteCandle = new ItemType(3173);
        public static readonly ItemType MeteoriteChair = new ItemType(3174);
        public static readonly ItemType MarbleChair = new ItemType(3175);
        public static readonly ItemType GraniteChair = new ItemType(3176);
        public static readonly ItemType MeteoriteChandelier = new ItemType(3177);
        public static readonly ItemType MarbleChandelier = new ItemType(3178);
        public static readonly ItemType GraniteChandelier = new ItemType(3179);
        public static readonly ItemType MeteoriteChest = new ItemType(3180);
        public static readonly ItemType MarbleChest = new ItemType(3181);
        public static readonly ItemType MagicWaterDropper = new ItemType(3182);
        public static readonly ItemType GoldenBugNet = new ItemType(3183);
        public static readonly ItemType MagicLavaDropper = new ItemType(3184);
        public static readonly ItemType MagicHoneyDropper = new ItemType(3185);
        public static readonly ItemType EmptyDropper = new ItemType(3186);
        public static readonly ItemType GladiatorHelmet = new ItemType(3187);
        public static readonly ItemType GladiatorBreastplate = new ItemType(3188);
        public static readonly ItemType GladiatorLeggings = new ItemType(3189);
        public static readonly ItemType ReflectiveDye = new ItemType(3190);
        public static readonly ItemType EnchantedNightcrawler = new ItemType(3191);
        public static readonly ItemType Grubby = new ItemType(3192);
        public static readonly ItemType Sluggy = new ItemType(3193);
        public static readonly ItemType Buggy = new ItemType(3194);
        public static readonly ItemType GrubSoup = new ItemType(3195);
        public static readonly ItemType BombFish = new ItemType(3196);
        public static readonly ItemType FrostDaggerfish = new ItemType(3197);
        public static readonly ItemType SharpeningStation = new ItemType(3198);
        public static readonly ItemType IceMirror = new ItemType(3199);
        public static readonly ItemType SailfishBoots = new ItemType(3200);
        public static readonly ItemType TsunamiInABottle = new ItemType(3201);
        public static readonly ItemType TargetDummy = new ItemType(3202);
        public static readonly ItemType CorruptCrate = new ItemType(3203);
        public static readonly ItemType CrimsonCrate = new ItemType(3204);
        public static readonly ItemType DungeonCrate = new ItemType(3205);
        public static readonly ItemType SkyCrate = new ItemType(3206);
        public static readonly ItemType HallowedCrate = new ItemType(3207);
        public static readonly ItemType JungleCrate = new ItemType(3208);
        public static readonly ItemType CrystalSerpent = new ItemType(3209);
        public static readonly ItemType Toxikarp = new ItemType(3210);
        public static readonly ItemType Bladetongue = new ItemType(3211);
        public static readonly ItemType SharkToothNecklace = new ItemType(3212);
        public static readonly ItemType MoneyTrough = new ItemType(3213);
        public static readonly ItemType Bubble = new ItemType(3214);
        public static readonly ItemType DaybloomPlanterBox = new ItemType(3215);
        public static readonly ItemType MoonglowPlanterBox = new ItemType(3216);
        public static readonly ItemType DeathweedPlanterBox = new ItemType(3217);
        public static readonly ItemType DeathweedPlanterBoxCrimson = new ItemType(3218);
        public static readonly ItemType BlinkrootPlanterBox = new ItemType(3219);
        public static readonly ItemType WaterleafPlanterBox = new ItemType(3220);
        public static readonly ItemType ShiverthornPlanterBox = new ItemType(3221);
        public static readonly ItemType FireblossomPlanterBox = new ItemType(3222);
        public static readonly ItemType BrainOfConfusion = new ItemType(3223);
        public static readonly ItemType WormScarf = new ItemType(3224);
        public static readonly ItemType BalloonPufferfish = new ItemType(3225);
        public static readonly ItemType LazuresValkyrieCirclet = new ItemType(3226);
        public static readonly ItemType LazuresValkyrieCloak = new ItemType(3227);
        public static readonly ItemType LazuresBarrierPlatform = new ItemType(3228);
        public static readonly ItemType GoldenCrossGraveMarker = new ItemType(3229);
        public static readonly ItemType GoldenTombstone = new ItemType(3230);
        public static readonly ItemType GoldenGraveMarker = new ItemType(3231);
        public static readonly ItemType GoldenGravestone = new ItemType(3232);
        public static readonly ItemType GoldenHeadstone = new ItemType(3233);
        public static readonly ItemType CrystalBlock = new ItemType(3234);
        public static readonly ItemType MusicBoxMartianMadness = new ItemType(3235);
        public static readonly ItemType MusicBoxPirateInvasion = new ItemType(3236);
        public static readonly ItemType MusicBoxHell = new ItemType(3237);
        public static readonly ItemType CrystalBlockWall = new ItemType(3238);
        public static readonly ItemType TrapDoor = new ItemType(3239);
        public static readonly ItemType TallGate = new ItemType(3240);
        public static readonly ItemType SharkronBalloon = new ItemType(3241);
        public static readonly ItemType TaxCollectorsHat = new ItemType(3242);
        public static readonly ItemType TaxCollectorsSuit = new ItemType(3243);
        public static readonly ItemType TaxCollectorsPants = new ItemType(3244);
        public static readonly ItemType BoneGlove = new ItemType(3245);
        public static readonly ItemType ClothiersJacket = new ItemType(3246);
        public static readonly ItemType ClothiersPants = new ItemType(3247);
        public static readonly ItemType DyeTradersTurban = new ItemType(3248);
        public static readonly ItemType DeadlySphereStaff = new ItemType(3249);
        public static readonly ItemType GreenHorseshoeBalloon = new ItemType(3250);
        public static readonly ItemType AmberHorseshoeBalloon = new ItemType(3251);
        public static readonly ItemType PinkHorseshoeBalloon = new ItemType(3252);
        public static readonly ItemType LavaLamp = new ItemType(3253);
        public static readonly ItemType EnchantedNightcrawlerCage = new ItemType(3254);
        public static readonly ItemType BuggyCage = new ItemType(3255);
        public static readonly ItemType GrubbyCage = new ItemType(3256);
        public static readonly ItemType SluggyCage = new ItemType(3257);
        public static readonly ItemType SlapHand = new ItemType(3258);
        public static readonly ItemType TwilightHairDye = new ItemType(3259);
        public static readonly ItemType BlessedApple = new ItemType(3260);
        public static readonly ItemType SpectreBar = new ItemType(3261);
        public static readonly ItemType Code1 = new ItemType(3262);
        public static readonly ItemType BuccaneerBandana = new ItemType(3263);
        public static readonly ItemType BuccaneerTunic = new ItemType(3264);
        public static readonly ItemType BuccaneerPantaloons = new ItemType(3265);
        public static readonly ItemType ObsidianOutlawHat = new ItemType(3266);
        public static readonly ItemType ObsidianLongcoat = new ItemType(3267);
        public static readonly ItemType ObsidianPants = new ItemType(3268);
        public static readonly ItemType MedusaHead = new ItemType(3269);
        public static readonly ItemType ItemFrame = new ItemType(3270);
        public static readonly ItemType SandstoneBlock = new ItemType(3271);
        public static readonly ItemType HardenedSandBlock = new ItemType(3272);
        public static readonly ItemType HardenedEbonsandBlock = new ItemType(3274);
        public static readonly ItemType HardenedCrimsandBlock = new ItemType(3275);
        public static readonly ItemType EbonsandstoneBlock = new ItemType(3276);
        public static readonly ItemType CrimsandstoneBlock = new ItemType(3277);
        public static readonly ItemType WoodenYoyo = new ItemType(3278);
        public static readonly ItemType Malaise = new ItemType(3279);
        public static readonly ItemType Artery = new ItemType(3280);
        public static readonly ItemType Amazon = new ItemType(3281);
        public static readonly ItemType Cascade = new ItemType(3282);
        public static readonly ItemType Chik = new ItemType(3283);
        public static readonly ItemType Code2 = new ItemType(3284);
        public static readonly ItemType Rally = new ItemType(3285);
        public static readonly ItemType Yelets = new ItemType(3286);
        public static readonly ItemType RedsThrow = new ItemType(3287);
        public static readonly ItemType ValkyrieYoyo = new ItemType(3288);
        public static readonly ItemType Amarok = new ItemType(3289);
        public static readonly ItemType HelFire = new ItemType(3290);
        public static readonly ItemType Kraken = new ItemType(3291);
        public static readonly ItemType TheEyeOfCthulhu = new ItemType(3292);
        public static readonly ItemType RedString = new ItemType(3293);
        public static readonly ItemType OrangeString = new ItemType(3294);
        public static readonly ItemType YellowString = new ItemType(3295);
        public static readonly ItemType LimeString = new ItemType(3296);
        public static readonly ItemType GreenString = new ItemType(3297);
        public static readonly ItemType TealString = new ItemType(3298);
        public static readonly ItemType CyanString = new ItemType(3299);
        public static readonly ItemType SkyBlueString = new ItemType(3300);
        public static readonly ItemType BlueString = new ItemType(3301);
        public static readonly ItemType PurpleString = new ItemType(3302);
        public static readonly ItemType VioletString = new ItemType(3303);
        public static readonly ItemType PinkString = new ItemType(3304);
        public static readonly ItemType BrownString = new ItemType(3305);
        public static readonly ItemType WhiteString = new ItemType(3306);
        public static readonly ItemType RainbowString = new ItemType(3307);
        public static readonly ItemType BlackString = new ItemType(3308);
        public static readonly ItemType BlackCounterweight = new ItemType(3309);
        public static readonly ItemType BlueCounterweight = new ItemType(3310);
        public static readonly ItemType GreenCounterweight = new ItemType(3311);
        public static readonly ItemType PurpleCounterweight = new ItemType(3312);
        public static readonly ItemType RedCounterweight = new ItemType(3313);
        public static readonly ItemType YellowCounterweight = new ItemType(3314);
        public static readonly ItemType FormatC = new ItemType(3315);
        public static readonly ItemType Gradient = new ItemType(3316);
        public static readonly ItemType Valor = new ItemType(3317);
        public static readonly ItemType TreasureBagKingSlime = new ItemType(3318);
        public static readonly ItemType TreasureBagEyeOfCthulhu = new ItemType(3319);
        public static readonly ItemType TreasureBagEaterOfWorlds = new ItemType(3320);
        public static readonly ItemType TreasureBagBrainOfCthulhu = new ItemType(3321);
        public static readonly ItemType TreasureBagQueenBee = new ItemType(3322);
        public static readonly ItemType TreasureBagSkeletron = new ItemType(3323);
        public static readonly ItemType TreasureBagWallOfFlesh = new ItemType(3324);
        public static readonly ItemType TreasureBagTheDestroyer = new ItemType(3325);
        public static readonly ItemType TreasureBagTheTwins = new ItemType(3326);
        public static readonly ItemType TreasureBagSkeletronPrime = new ItemType(3327);
        public static readonly ItemType TreasureBagPlantera = new ItemType(3328);
        public static readonly ItemType TreasureBagGolem = new ItemType(3329);
        public static readonly ItemType TreasureBagDukeFishron = new ItemType(3330);
        public static readonly ItemType TreasureBagMoonLord = new ItemType(3332);
        public static readonly ItemType HivePack = new ItemType(3333);
        public static readonly ItemType YoyoGlove = new ItemType(3334);
        public static readonly ItemType DemonHeart = new ItemType(3335);
        public static readonly ItemType SporeSac = new ItemType(3336);
        public static readonly ItemType ShinyStone = new ItemType(3337);
        public static readonly ItemType HardenedPearlsandBlock = new ItemType(3338);
        public static readonly ItemType PearlsandstoneBlock = new ItemType(3339);
        public static readonly ItemType DesertFossil = new ItemType(3347);
        public static readonly ItemType DesertFossilWall = new ItemType(3348);
        public static readonly ItemType ExoticScimitar = new ItemType(3349);
        public static readonly ItemType PaintballGun = new ItemType(3350);
        public static readonly ItemType ClassyCane = new ItemType(3351);
        public static readonly ItemType StylishScissors = new ItemType(3352);
        public static readonly ItemType MechanicalCart = new ItemType(3353);
        public static readonly ItemType MechanicalWheelPiece = new ItemType(3354);
        public static readonly ItemType MechanicalWagonPiece = new ItemType(3355);
        public static readonly ItemType MechanicalBatteryPiece = new ItemType(3356);
        public static readonly ItemType AncientCultistTrophy = new ItemType(3357);
        public static readonly ItemType MartianSaucerTrophy = new ItemType(3358);
        public static readonly ItemType FlyingDutchmanTrophy = new ItemType(3359);
        public static readonly ItemType LivingMahoganyWand = new ItemType(3360);
        public static readonly ItemType RichMahoganyLeafWand = new ItemType(3361);
        public static readonly ItemType FallenTuxedoShirt = new ItemType(3362);
        public static readonly ItemType FallenTuxedoPants = new ItemType(3363);
        public static readonly ItemType Fireplace = new ItemType(3364);
        public static readonly ItemType Chimney = new ItemType(3365);
        public static readonly ItemType YoyoBag = new ItemType(3366);
        public static readonly ItemType ShrimpyTruffle = new ItemType(3367);
        public static readonly ItemType Arkhalis = new ItemType(3368);
        public static readonly ItemType ConfettiCannon = new ItemType(3369);
        public static readonly ItemType MusicBoxTheTowers = new ItemType(3370);
        public static readonly ItemType MusicBoxGoblinInvasion = new ItemType(3371);
        public static readonly ItemType AncientCultistMask = new ItemType(3372);
        public static readonly ItemType MoonLordMask = new ItemType(3373);
        public static readonly ItemType FossilHelmet = new ItemType(3374);
        public static readonly ItemType FossilPlate = new ItemType(3375);
        public static readonly ItemType FossilGreaves = new ItemType(3376);
        public static readonly ItemType AmberStaff = new ItemType(3377);
        public static readonly ItemType BoneJavelin = new ItemType(3378);
        public static readonly ItemType BoneThrowingKnife = new ItemType(3379);
        public static readonly ItemType SturdyFossil = new ItemType(3380);
        public static readonly ItemType StardustHelmet = new ItemType(3381);
        public static readonly ItemType StardustPlate = new ItemType(3382);
        public static readonly ItemType StardustLeggings = new ItemType(3383);
        public static readonly ItemType PortalGun = new ItemType(3384);
        public static readonly ItemType StrangePlantPurple = new ItemType(3385);
        public static readonly ItemType StrangePlantOrange = new ItemType(3386);
        public static readonly ItemType StrangePlantGreen = new ItemType(3387);
        public static readonly ItemType StrangePlantRed = new ItemType(3388);
        public static readonly ItemType Terrarian = new ItemType(3389);
        public static readonly ItemType GoblinSummonerBanner = new ItemType(3390);
        public static readonly ItemType SalamanderBanner = new ItemType(3391);
        public static readonly ItemType GiantShellyBanner = new ItemType(3392);
        public static readonly ItemType CrawdadBanner = new ItemType(3393);
        public static readonly ItemType FritzBanner = new ItemType(3394);
        public static readonly ItemType CreatureFromTheDeepBanner = new ItemType(3395);
        public static readonly ItemType DrManFlyBanner = new ItemType(3396);
        public static readonly ItemType MothronBanner = new ItemType(3397);
        public static readonly ItemType SeveredHandBanner = new ItemType(3398);
        public static readonly ItemType ThePossessedBanner = new ItemType(3399);
        public static readonly ItemType ButcherBanner = new ItemType(3400);
        public static readonly ItemType PsychoBanner = new ItemType(3401);
        public static readonly ItemType DeadlySphereBanner = new ItemType(3402);
        public static readonly ItemType NailheadBanner = new ItemType(3403);
        public static readonly ItemType PoisonousSporeBanner = new ItemType(3404);
        public static readonly ItemType MedusaBanner = new ItemType(3405);
        public static readonly ItemType HopliteBanner = new ItemType(3406);
        public static readonly ItemType GraniteElementalBanner = new ItemType(3407);
        public static readonly ItemType GraniteGolemBanner = new ItemType(3408);
        public static readonly ItemType BloodZombieBanner = new ItemType(3409);
        public static readonly ItemType DripplerBanner = new ItemType(3410);
        public static readonly ItemType TombCrawlerBanner = new ItemType(3411);
        public static readonly ItemType DuneSplicerBanner = new ItemType(3412);
        public static readonly ItemType AntlionSwarmerBanner = new ItemType(3413);
        public static readonly ItemType AntlionChargerBanner = new ItemType(3414);
        public static readonly ItemType GhoulBanner = new ItemType(3415);
        public static readonly ItemType LamiaBanner = new ItemType(3416);
        public static readonly ItemType DesertSpiritBanner = new ItemType(3417);
        public static readonly ItemType BasiliskBanner = new ItemType(3418);
        public static readonly ItemType SandPoacherBanner = new ItemType(3419);
        public static readonly ItemType StargazerBanner = new ItemType(3420);
        public static readonly ItemType MilkywayWeaverBanner = new ItemType(3421);
        public static readonly ItemType FlowInvaderBanner = new ItemType(3422);
        public static readonly ItemType TwinklePopperBanner = new ItemType(3423);
        public static readonly ItemType SmallStarCellBanner = new ItemType(3424);
        public static readonly ItemType StarCellBanner = new ItemType(3425);
        public static readonly ItemType CoriteBanner = new ItemType(3426);
        public static readonly ItemType SrollerBanner = new ItemType(3427);
        public static readonly ItemType CrawltipedeBanner = new ItemType(3428);
        public static readonly ItemType DrakomireRiderBanner = new ItemType(3429);
        public static readonly ItemType DrakomireBanner = new ItemType(3430);
        public static readonly ItemType SelenianBanner = new ItemType(3431);
        public static readonly ItemType PredictorBanner = new ItemType(3432);
        public static readonly ItemType BrainSucklerBanner = new ItemType(3433);
        public static readonly ItemType NebulaFloaterBanner = new ItemType(3434);
        public static readonly ItemType EvolutionBeastBanner = new ItemType(3435);
        public static readonly ItemType AlienLarvaBanner = new ItemType(3436);
        public static readonly ItemType AlienQueenBanner = new ItemType(3437);
        public static readonly ItemType AlienHornetBanner = new ItemType(3438);
        public static readonly ItemType VortexianBanner = new ItemType(3439);
        public static readonly ItemType StormDiverBanner = new ItemType(3440);
        public static readonly ItemType PirateCaptainBanner = new ItemType(3441);
        public static readonly ItemType PirateDeadeyeBanner = new ItemType(3442);
        public static readonly ItemType PirateCorsairBanner = new ItemType(3443);
        public static readonly ItemType PirateCrossbowerBanner = new ItemType(3444);
        public static readonly ItemType MartianWalkerBanner = new ItemType(3445);
        public static readonly ItemType RedDevilBanner = new ItemType(3446);
        public static readonly ItemType PinkJellyfishBanner = new ItemType(3447);
        public static readonly ItemType GreenJellyfishBanner = new ItemType(3448);
        public static readonly ItemType DarkMummyBanner = new ItemType(3449);
        public static readonly ItemType LightMummyBanner = new ItemType(3450);
        public static readonly ItemType AngryBonesBanner = new ItemType(3451);
        public static readonly ItemType IceTortoiseBanner = new ItemType(3452);
        public static readonly ItemType DamageBooster = new ItemType(3453);
        public static readonly ItemType LifeBooster = new ItemType(3454);
        public static readonly ItemType ManaBooster = new ItemType(3455);
        public static readonly ItemType VortexFragment = new ItemType(3456);
        public static readonly ItemType NebulaFragment = new ItemType(3457);
        public static readonly ItemType SolarFragment = new ItemType(3458);
        public static readonly ItemType StardustFragment = new ItemType(3459);
        public static readonly ItemType Luminite = new ItemType(3460);
        public static readonly ItemType LuminiteBrick = new ItemType(3461);
        public static readonly ItemType StardustPickaxe = new ItemType(3466);
        public static readonly ItemType LuminiteBar = new ItemType(3467);
        public static readonly ItemType SolarWings = new ItemType(3468);
        public static readonly ItemType VortexBooster = new ItemType(3469);
        public static readonly ItemType NebulaMantle = new ItemType(3470);
        public static readonly ItemType StardustWings = new ItemType(3471);
        public static readonly ItemType LuminiteBrickWall = new ItemType(3472);
        public static readonly ItemType SolarEruption = new ItemType(3473);
        public static readonly ItemType StardustCellStaff = new ItemType(3474);
        public static readonly ItemType VortexBeater = new ItemType(3475);
        public static readonly ItemType NebulaArcanum = new ItemType(3476);
        public static readonly ItemType BloodWater = new ItemType(3477);
        public static readonly ItemType WeddingVeil = new ItemType(3478);
        public static readonly ItemType WeddingDress = new ItemType(3479);
        public static readonly ItemType PlatinumBow = new ItemType(3480);
        public static readonly ItemType PlatinumHammer = new ItemType(3481);
        public static readonly ItemType PlatinumAxe = new ItemType(3482);
        public static readonly ItemType PlatinumShortsword = new ItemType(3483);
        public static readonly ItemType PlatinumBroadsword = new ItemType(3484);
        public static readonly ItemType PlatinumPickaxe = new ItemType(3485);
        public static readonly ItemType TungstenBow = new ItemType(3486);
        public static readonly ItemType TungstenHammer = new ItemType(3487);
        public static readonly ItemType TungstenAxe = new ItemType(3488);
        public static readonly ItemType TungstenShortsword = new ItemType(3489);
        public static readonly ItemType TungstenBroadsword = new ItemType(3490);
        public static readonly ItemType TungstenPickaxe = new ItemType(3491);
        public static readonly ItemType LeadBow = new ItemType(3492);
        public static readonly ItemType LeadHammer = new ItemType(3493);
        public static readonly ItemType LeadAxe = new ItemType(3494);
        public static readonly ItemType LeadShortsword = new ItemType(3495);
        public static readonly ItemType LeadBroadsword = new ItemType(3496);
        public static readonly ItemType LeadPickaxe = new ItemType(3497);
        public static readonly ItemType TinBow = new ItemType(3498);
        public static readonly ItemType TinHammer = new ItemType(3499);
        public static readonly ItemType TinAxe = new ItemType(3500);
        public static readonly ItemType TinShortsword = new ItemType(3501);
        public static readonly ItemType TinBroadsword = new ItemType(3502);
        public static readonly ItemType TinPickaxe = new ItemType(3503);
        public static readonly ItemType CopperBow = new ItemType(3504);
        public static readonly ItemType CopperHammer = new ItemType(3505);
        public static readonly ItemType CopperAxe = new ItemType(3506);
        public static readonly ItemType CopperShortsword = new ItemType(3507);
        public static readonly ItemType CopperBroadsword = new ItemType(3508);
        public static readonly ItemType CopperPickaxe = new ItemType(3509);
        public static readonly ItemType SilverBow = new ItemType(3510);
        public static readonly ItemType SilverHammer = new ItemType(3511);
        public static readonly ItemType SilverAxe = new ItemType(3512);
        public static readonly ItemType SilverShortsword = new ItemType(3513);
        public static readonly ItemType SilverBroadsword = new ItemType(3514);
        public static readonly ItemType SilverPickaxe = new ItemType(3515);
        public static readonly ItemType GoldBow = new ItemType(3516);
        public static readonly ItemType GoldHammer = new ItemType(3517);
        public static readonly ItemType GoldAxe = new ItemType(3518);
        public static readonly ItemType GoldShortsword = new ItemType(3519);
        public static readonly ItemType GoldBroadsword = new ItemType(3520);
        public static readonly ItemType GoldPickaxe = new ItemType(3521);
        public static readonly ItemType SolarFlareHamaxe = new ItemType(3522);
        public static readonly ItemType VortexHamaxe = new ItemType(3523);
        public static readonly ItemType NebulaHamaxe = new ItemType(3524);
        public static readonly ItemType StardustHamaxe = new ItemType(3525);
        public static readonly ItemType SolarDye = new ItemType(3526);
        public static readonly ItemType NebulaDye = new ItemType(3527);
        public static readonly ItemType VortexDye = new ItemType(3528);
        public static readonly ItemType StardustDye = new ItemType(3529);
        public static readonly ItemType VoidDye = new ItemType(3530);
        public static readonly ItemType StardustDragonStaff = new ItemType(3531);
        public static readonly ItemType Bacon = new ItemType(3532);
        public static readonly ItemType ShiftingSandsDye = new ItemType(3533);
        public static readonly ItemType MirageDye = new ItemType(3534);
        public static readonly ItemType ShiftingPearlsandsDye = new ItemType(3535);
        public static readonly ItemType VortexMonolith = new ItemType(3536);
        public static readonly ItemType NebulaMonolith = new ItemType(3537);
        public static readonly ItemType StardustMonolith = new ItemType(3538);
        public static readonly ItemType SolarMonolith = new ItemType(3539);
        public static readonly ItemType Phantasm = new ItemType(3540);
        public static readonly ItemType LastPrism = new ItemType(3541);
        public static readonly ItemType NebulaBlaze = new ItemType(3542);
        public static readonly ItemType Daybreak = new ItemType(3543);
        public static readonly ItemType SuperHealingPotion = new ItemType(3544);
        public static readonly ItemType Detonator = new ItemType(3545);
        public static readonly ItemType Celebration = new ItemType(3546);
        public static readonly ItemType BouncyDynamite = new ItemType(3547);
        public static readonly ItemType HappyGrenade = new ItemType(3548);
        public static readonly ItemType AncientManipulator = new ItemType(3549);
        public static readonly ItemType FlameandSilverDye = new ItemType(3550);
        public static readonly ItemType GreenFlameandSilverDye = new ItemType(3551);
        public static readonly ItemType BlueFlameandSilverDye = new ItemType(3552);
        public static readonly ItemType ReflectiveCopperDye = new ItemType(3553);
        public static readonly ItemType ReflectiveObsidianDye = new ItemType(3554);
        public static readonly ItemType ReflectiveMetalDye = new ItemType(3555);
        public static readonly ItemType MidnightRainbowDye = new ItemType(3556);
        public static readonly ItemType BlackandWhiteDye = new ItemType(3557);
        public static readonly ItemType BrightSilverDye = new ItemType(3558);
        public static readonly ItemType SilverandBlackDye = new ItemType(3559);
        public static readonly ItemType RedAcidDye = new ItemType(3560);
        public static readonly ItemType GelDye = new ItemType(3561);
        public static readonly ItemType PinkGelDye = new ItemType(3562);
        public static readonly ItemType RedSquirrel = new ItemType(3563);
        public static readonly ItemType GoldSquirrel = new ItemType(3564);
        public static readonly ItemType RedSquirrelCage = new ItemType(3565);
        public static readonly ItemType GoldSquirrelCage = new ItemType(3566);
        public static readonly ItemType LuminiteBullet = new ItemType(3567);
        public static readonly ItemType LuminiteArrow = new ItemType(3568);
        public static readonly ItemType LunarPortalStaff = new ItemType(3569);
        public static readonly ItemType LunarFlare = new ItemType(3570);
        public static readonly ItemType RainbowCrystalStaff = new ItemType(3571);
        public static readonly ItemType LunarHook = new ItemType(3572);
        public static readonly ItemType SolarFragmentBlock = new ItemType(3573);
        public static readonly ItemType VortexFragmentBlock = new ItemType(3574);
        public static readonly ItemType NebulaFragmentBlock = new ItemType(3575);
        public static readonly ItemType StardustFragmentBlock = new ItemType(3576);
        public static readonly ItemType SuspiciousLookingTentacle = new ItemType(3577);
        public static readonly ItemType Yoraiz0rsUniform = new ItemType(3578);
        public static readonly ItemType Yoraiz0rsSkirt = new ItemType(3579);
        public static readonly ItemType Yoraiz0rsSpell = new ItemType(3580);
        public static readonly ItemType Yoraiz0rsScowl = new ItemType(3581);
        public static readonly ItemType JimsWings = new ItemType(3582);
        public static readonly ItemType Yoraiz0rsRecoloredGoggles = new ItemType(3583);
        public static readonly ItemType LivingLeafWall = new ItemType(3584);
        public static readonly ItemType SkiphssMask = new ItemType(3585);
        public static readonly ItemType SkiphssSkin = new ItemType(3586);
        public static readonly ItemType SkiphssBearButt = new ItemType(3587);
        public static readonly ItemType SkiphssPaws = new ItemType(3588);
        public static readonly ItemType LokisHelmet = new ItemType(3589);
        public static readonly ItemType LokisBreastplate = new ItemType(3590);
        public static readonly ItemType LokisGreaves = new ItemType(3591);
        public static readonly ItemType LokisWings = new ItemType(3592);
        public static readonly ItemType SandSlimeBanner = new ItemType(3593);
        public static readonly ItemType SeaSnailBanner = new ItemType(3594);
        public static readonly ItemType MoonLordTrophy = new ItemType(3595);
        public static readonly ItemType NotaKidnoraSquid = new ItemType(3596);
        public static readonly ItemType BurningHadesDye = new ItemType(3597);
        public static readonly ItemType GrimDye = new ItemType(3598);
        public static readonly ItemType LokisDye = new ItemType(3599);
        public static readonly ItemType ShadowflameHadesDye = new ItemType(3600);
        public static readonly ItemType CelestialSigil = new ItemType(3601);
        public static readonly ItemType LogicGateLampOff = new ItemType(3602);
        public static readonly ItemType LogicGateAnd = new ItemType(3603);
        public static readonly ItemType LogicGateOr = new ItemType(3604);
        public static readonly ItemType LogicGateNand = new ItemType(3605);
        public static readonly ItemType LogicGateNor = new ItemType(3606);
        public static readonly ItemType LogicGateXor = new ItemType(3607);
        public static readonly ItemType LogicGateXnor = new ItemType(3608);
        public static readonly ItemType ConveyorBeltClockwise = new ItemType(3609);
        public static readonly ItemType ConveyorBeltCounterClockwise = new ItemType(3610);
        public static readonly ItemType TheGrandDesign = new ItemType(3611);
        public static readonly ItemType YellowWrench = new ItemType(3612);
        public static readonly ItemType LogicSensorDay = new ItemType(3613);
        public static readonly ItemType LogicSensorNight = new ItemType(3614);
        public static readonly ItemType LogicSensorPlayerAbove = new ItemType(3615);
        public static readonly ItemType JunctionBox = new ItemType(3616);
        public static readonly ItemType AnnouncementBox = new ItemType(3617);
        public static readonly ItemType LogicGateLampOn = new ItemType(3618);
        public static readonly ItemType MechanicalLens = new ItemType(3619);
        public static readonly ItemType ActuationRod = new ItemType(3620);
        public static readonly ItemType RedTeamBlock = new ItemType(3621);
        public static readonly ItemType RedTeamPlatform = new ItemType(3622);
        public static readonly ItemType StaticHook = new ItemType(3623);
        public static readonly ItemType Presserator = new ItemType(3624);
        public static readonly ItemType MulticolorWrench = new ItemType(3625);
        public static readonly ItemType PinkWeightedPressurePlate = new ItemType(3626);
        public static readonly ItemType EngineeringHelmet = new ItemType(3627);
        public static readonly ItemType CompanionCube = new ItemType(3628);
        public static readonly ItemType WireBulb = new ItemType(3629);
        public static readonly ItemType OrangeWeightedPressurePlate = new ItemType(3630);
        public static readonly ItemType PurpleWeightedPressurePlate = new ItemType(3631);
        public static readonly ItemType CyanWeightedPressurePlate = new ItemType(3632);
        public static readonly ItemType GreenTeamBlock = new ItemType(3633);
        public static readonly ItemType BlueTeamBlock = new ItemType(3634);
        public static readonly ItemType YellowTeamBlock = new ItemType(3635);
        public static readonly ItemType PinkTeamBlock = new ItemType(3636);
        public static readonly ItemType WhiteTeamBlock = new ItemType(3637);
        public static readonly ItemType GreenTeamPlatform = new ItemType(3638);
        public static readonly ItemType BlueTeamPlatform = new ItemType(3639);
        public static readonly ItemType YellowTeamPlatform = new ItemType(3640);
        public static readonly ItemType PinkTeamPlatform = new ItemType(3641);
        public static readonly ItemType WhiteTeamPlatform = new ItemType(3642);
        public static readonly ItemType LargeAmber = new ItemType(3643);
        public static readonly ItemType RubyGemLock = new ItemType(3644);
        public static readonly ItemType SapphireGemLock = new ItemType(3645);
        public static readonly ItemType EmeraldGemLock = new ItemType(3646);
        public static readonly ItemType TopazGemLock = new ItemType(3647);
        public static readonly ItemType AmethystGemLock = new ItemType(3648);
        public static readonly ItemType DiamondGemLock = new ItemType(3649);
        public static readonly ItemType AmberGemLock = new ItemType(3650);
        public static readonly ItemType SquirrelStatue = new ItemType(3651);
        public static readonly ItemType ButterflyStatue = new ItemType(3652);
        public static readonly ItemType WormStatue = new ItemType(3653);
        public static readonly ItemType FireflyStatue = new ItemType(3654);
        public static readonly ItemType ScorpionStatue = new ItemType(3655);
        public static readonly ItemType SnailStatue = new ItemType(3656);
        public static readonly ItemType GrasshopperStatue = new ItemType(3657);
        public static readonly ItemType MouseStatue = new ItemType(3658);
        public static readonly ItemType DuckStatue = new ItemType(3659);
        public static readonly ItemType PenguinStatue = new ItemType(3660);
        public static readonly ItemType FrogStatue = new ItemType(3661);
        public static readonly ItemType BuggyStatue = new ItemType(3662);
        public static readonly ItemType LogicGateLampFaulty = new ItemType(3663);
        public static readonly ItemType PortalGunStation = new ItemType(3664);
        public static readonly ItemType TrappedChest = new ItemType(3665);
        public static readonly ItemType TrappedGoldChest = new ItemType(3666);
        public static readonly ItemType TrappedShadowChest = new ItemType(3667);
        public static readonly ItemType TrappedEbonwoodChest = new ItemType(3668);
        public static readonly ItemType TrappedRichMahoganyChest = new ItemType(3669);
        public static readonly ItemType TrappedPearlwoodChest = new ItemType(3670);
        public static readonly ItemType TrappedIvyChest = new ItemType(3671);
        public static readonly ItemType TrappedIceChest = new ItemType(3672);
        public static readonly ItemType TrappedLivingWoodChest = new ItemType(3673);
        public static readonly ItemType TrappedSkywareChest = new ItemType(3674);
        public static readonly ItemType TrappedShadewoodChest = new ItemType(3675);
        public static readonly ItemType TrappedWebCoveredChest = new ItemType(3676);
        public static readonly ItemType TrappedLihzahrdChest = new ItemType(3677);
        public static readonly ItemType TrappedWaterChest = new ItemType(3678);
        public static readonly ItemType TrappedJungleChest = new ItemType(3679);
        public static readonly ItemType TrappedCorruptionChest = new ItemType(3680);
        public static readonly ItemType TrappedCrimsonChest = new ItemType(3681);
        public static readonly ItemType TrappedHallowedChest = new ItemType(3682);
        public static readonly ItemType TrappedFrozenChest = new ItemType(3683);
        public static readonly ItemType TrappedDynastyChest = new ItemType(3684);
        public static readonly ItemType TrappedHoneyChest = new ItemType(3685);
        public static readonly ItemType TrappedSteampunkChest = new ItemType(3686);
        public static readonly ItemType TrappedPalmWoodChest = new ItemType(3687);
        public static readonly ItemType TrappedMushroomChest = new ItemType(3688);
        public static readonly ItemType TrappedBorealWoodChest = new ItemType(3689);
        public static readonly ItemType TrappedSlimeChest = new ItemType(3690);
        public static readonly ItemType TrappedGreenDungeonChest = new ItemType(3691);
        public static readonly ItemType TrappedPinkDungeonChest = new ItemType(3692);
        public static readonly ItemType TrappedBlueDungeonChest = new ItemType(3693);
        public static readonly ItemType TrappedBoneChest = new ItemType(3694);
        public static readonly ItemType TrappedCactusChest = new ItemType(3695);
        public static readonly ItemType TrappedFleshChest = new ItemType(3696);
        public static readonly ItemType TrappedObsidianChest = new ItemType(3697);
        public static readonly ItemType TrappedPumpkinChest = new ItemType(3698);
        public static readonly ItemType TrappedSpookyChest = new ItemType(3699);
        public static readonly ItemType TrappedGlassChest = new ItemType(3700);
        public static readonly ItemType TrappedMartianChest = new ItemType(3701);
        public static readonly ItemType TrappedMeteoriteChest = new ItemType(3702);
        public static readonly ItemType TrappedGraniteChest = new ItemType(3703);
        public static readonly ItemType TrappedMarbleChest = new ItemType(3704);
        public static readonly ItemType TealPressurePad = new ItemType(3707);
        public static readonly ItemType WallCreeperStatue = new ItemType(3708);
        public static readonly ItemType UnicornStatue = new ItemType(3709);
        public static readonly ItemType DripplerStatue = new ItemType(3710);
        public static readonly ItemType WraithStatue = new ItemType(3711);
        public static readonly ItemType BoneSkeletonStatue = new ItemType(3712);
        public static readonly ItemType UndeadVikingStatue = new ItemType(3713);
        public static readonly ItemType MedusaStatue = new ItemType(3714);
        public static readonly ItemType HarpyStatue = new ItemType(3715);
        public static readonly ItemType PigronStatue = new ItemType(3716);
        public static readonly ItemType HopliteStatue = new ItemType(3717);
        public static readonly ItemType GraniteGolemStatue = new ItemType(3718);
        public static readonly ItemType ArmedZombieStatue = new ItemType(3719);
        public static readonly ItemType BloodZombieStatue = new ItemType(3720);
        public static readonly ItemType AnglerTackleBag = new ItemType(3721);
        public static readonly ItemType Geyser = new ItemType(3722);
        public static readonly ItemType UltraBrightCampfire = new ItemType(3723);
        public static readonly ItemType BoneCampfire = new ItemType(3724);
        public static readonly ItemType PixelBox = new ItemType(3725);
        public static readonly ItemType LiquidSensorWater = new ItemType(3726);
        public static readonly ItemType LiquidSensorLava = new ItemType(3727);
        public static readonly ItemType LiquidSensorHoney = new ItemType(3728);
        public static readonly ItemType LiquidSensorAny = new ItemType(3729);
        public static readonly ItemType BundledPartyBalloons = new ItemType(3730);
        public static readonly ItemType BalloonAnimal = new ItemType(3731);
        public static readonly ItemType PartyHat = new ItemType(3732);
        public static readonly ItemType SillySunflowerPetals = new ItemType(3733);
        public static readonly ItemType SillySunflowerTops = new ItemType(3734);
        public static readonly ItemType SillySunflowerBottoms = new ItemType(3735);
        public static readonly ItemType SillyPinkBalloon = new ItemType(3736);
        public static readonly ItemType SillyPurpleBalloon = new ItemType(3737);
        public static readonly ItemType SillyGreenBalloon = new ItemType(3738);
        public static readonly ItemType BlueStreamer = new ItemType(3739);
        public static readonly ItemType GreenStreamer = new ItemType(3740);
        public static readonly ItemType PinkStreamer = new ItemType(3741);
        public static readonly ItemType SillyBalloonMachine = new ItemType(3742);
        public static readonly ItemType SillyTiedBalloonPink = new ItemType(3743);
        public static readonly ItemType SillyTiedBalloonPurple = new ItemType(3744);
        public static readonly ItemType SillyTiedBalloonGreen = new ItemType(3745);
        public static readonly ItemType Pigronata = new ItemType(3746);
        public static readonly ItemType PartyCenter = new ItemType(3747);
        public static readonly ItemType SillyTiedBundleOfBalloons = new ItemType(3748);
        public static readonly ItemType PartyPresent = new ItemType(3749);
        public static readonly ItemType CogWall = new ItemType(3751);
        public static readonly ItemType SandfallWall = new ItemType(3752);
        public static readonly ItemType SnowfallWall = new ItemType(3753);
        public static readonly ItemType Sandfall = new ItemType(3754);
        public static readonly ItemType Snowfall = new ItemType(3755);
        public static readonly ItemType SnowCloud = new ItemType(3756);
        public static readonly ItemType PedguinsHood = new ItemType(3757);
        public static readonly ItemType PedguinsJacket = new ItemType(3758);
        public static readonly ItemType PedguinsTrousers = new ItemType(3759);
        public static readonly ItemType SillyPinkBalloonWall = new ItemType(3760);
        public static readonly ItemType SillyPurpleBalloonWall = new ItemType(3761);
        public static readonly ItemType SillyGreenBalloonWall = new ItemType(3762);
        public static readonly ItemType ZeroX33sAviators = new ItemType(3763);
        public static readonly ItemType BluePhasesaber = new ItemType(3764);
        public static readonly ItemType RedPhasesaber = new ItemType(3765);
        public static readonly ItemType GreenPhasesaber = new ItemType(3766);
        public static readonly ItemType PurplePhasesaber = new ItemType(3767);
        public static readonly ItemType WhitePhasesaber = new ItemType(3768);
        public static readonly ItemType YellowPhasesaber = new ItemType(3769);
        public static readonly ItemType DjinnsCurse = new ItemType(3770);
        public static readonly ItemType AncientHorn = new ItemType(3771);
        public static readonly ItemType MandibleBlade = new ItemType(3772);
        public static readonly ItemType AncientHeaddress = new ItemType(3773);
        public static readonly ItemType AncientGarments = new ItemType(3774);
        public static readonly ItemType AncientSlacks = new ItemType(3775);
        public static readonly ItemType ForbiddenMask = new ItemType(3776);
        public static readonly ItemType ForbiddenRobes = new ItemType(3777);
        public static readonly ItemType ForbiddenTreads = new ItemType(3778);
        public static readonly ItemType SpiritFlame = new ItemType(3779);
        public static readonly ItemType SandElementalBanner = new ItemType(3780);
        public static readonly ItemType PocketMirror = new ItemType(3781);
        public static readonly ItemType MagicSandDropper = new ItemType(3782);
        public static readonly ItemType ForbiddenFragment = new ItemType(3783);
        public static readonly ItemType LamiaTail = new ItemType(3784);
        public static readonly ItemType LamiaWraps = new ItemType(3785);
        public static readonly ItemType LamiaMask = new ItemType(3786);
        public static readonly ItemType SkyFracture = new ItemType(3787);
        public static readonly ItemType OnyxBlaster = new ItemType(3788);
        public static readonly ItemType SandSharkBanner = new ItemType(3789);
        public static readonly ItemType BoneBiterBanner = new ItemType(3790);
        public static readonly ItemType FleshReaverBanner = new ItemType(3791);
        public static readonly ItemType CrystalThresherBanner = new ItemType(3792);
        public static readonly ItemType AngryTumblerBanner = new ItemType(3793);
        public static readonly ItemType AncientCloth = new ItemType(3794);
        public static readonly ItemType DesertSpiritLamp = new ItemType(3795);
        public static readonly ItemType MusicBoxSandstorm = new ItemType(3796);
        public static readonly ItemType ApprenticesHat = new ItemType(3797);
        public static readonly ItemType ApprenticesRobe = new ItemType(3798);
        public static readonly ItemType ApprenticesTrousers = new ItemType(3799);
        public static readonly ItemType SquiresGreatHelm = new ItemType(3800);
        public static readonly ItemType SquiresPlating = new ItemType(3801);
        public static readonly ItemType SquiresGreaves = new ItemType(3802);
        public static readonly ItemType HuntresssWig = new ItemType(3803);
        public static readonly ItemType HuntresssJerkin = new ItemType(3804);
        public static readonly ItemType HuntresssPants = new ItemType(3805);
        public static readonly ItemType MonksBushyBrowBaldCap = new ItemType(3806);
        public static readonly ItemType MonksShirt = new ItemType(3807);
        public static readonly ItemType MonksPants = new ItemType(3808);
        public static readonly ItemType ApprenticesScarf = new ItemType(3809);
        public static readonly ItemType SquiresShield = new ItemType(3810);
        public static readonly ItemType HuntresssBuckler = new ItemType(3811);
        public static readonly ItemType MonksBelt = new ItemType(3812);
        public static readonly ItemType DefendersForge = new ItemType(3813);
        public static readonly ItemType WarTable = new ItemType(3814);
        public static readonly ItemType WarTableBanner = new ItemType(3815);
        public static readonly ItemType EterniaCrystalStand = new ItemType(3816);
        public static readonly ItemType DefenderMedal = new ItemType(3817);
        public static readonly ItemType FlameburstRod = new ItemType(3818);
        public static readonly ItemType FlameburstCane = new ItemType(3819);
        public static readonly ItemType FlameburstStaff = new ItemType(3820);
        public static readonly ItemType AleTosser = new ItemType(3821);
        public static readonly ItemType EtherianMana = new ItemType(3822);
        public static readonly ItemType BrandOfTheInferno = new ItemType(3823);
        public static readonly ItemType BallistaRod = new ItemType(3824);
        public static readonly ItemType BallistaCane = new ItemType(3825);
        public static readonly ItemType BallistaStaff = new ItemType(3826);
        public static readonly ItemType FlyingDragon = new ItemType(3827);
        public static readonly ItemType EterniaCrystal = new ItemType(3828);
        public static readonly ItemType LightningAuraRod = new ItemType(3829);
        public static readonly ItemType LightningAuraCane = new ItemType(3830);
        public static readonly ItemType LightningAuraStaff = new ItemType(3831);
        public static readonly ItemType ExplosiveTrapRod = new ItemType(3832);
        public static readonly ItemType ExplosiveTrapCane = new ItemType(3833);
        public static readonly ItemType ExplosiveTrapStaff = new ItemType(3834);
        public static readonly ItemType SleepyOctopod = new ItemType(3835);
        public static readonly ItemType GhastlyGlaive = new ItemType(3836);
        public static readonly ItemType EtherianGoblinBomberBanner = new ItemType(3837);
        public static readonly ItemType EtherianGoblinBanner = new ItemType(3838);
        public static readonly ItemType OldOnesSkeletonBanner = new ItemType(3839);
        public static readonly ItemType DrakinBanner = new ItemType(3840);
        public static readonly ItemType KoboldGliderBanner = new ItemType(3841);
        public static readonly ItemType KoboldBanner = new ItemType(3842);
        public static readonly ItemType WitherBeastBanner = new ItemType(3843);
        public static readonly ItemType EtherianWyvernBanner = new ItemType(3844);
        public static readonly ItemType EtherianJavelinThrowerBanner = new ItemType(3845);
        public static readonly ItemType EtherianLightningBugBanner = new ItemType(3846);
        public static readonly ItemType TomeOfInfiniteWisdom = new ItemType(3852);
        public static readonly ItemType PhantomPhoenix = new ItemType(3854);
        public static readonly ItemType GatoEgg = new ItemType(3855);
        public static readonly ItemType CreeperEgg = new ItemType(3856);
        public static readonly ItemType DragonEgg = new ItemType(3857);
        public static readonly ItemType SkyDragonsFury = new ItemType(3858);
        public static readonly ItemType AerialBane = new ItemType(3859);
        public static readonly ItemType TreasureBag = new ItemType(3860);
        public static readonly ItemType BetsyMask = new ItemType(3863);
        public static readonly ItemType DarkMageMask = new ItemType(3864);
        public static readonly ItemType OgreMask = new ItemType(3865);
        public static readonly ItemType BetsyTrophy = new ItemType(3866);
        public static readonly ItemType DarkMageTrophy = new ItemType(3867);
        public static readonly ItemType OgreTrophy = new ItemType(3868);
        public static readonly ItemType MusicBoxOldOnesArmy = new ItemType(3869);
        public static readonly ItemType BetsysWrath = new ItemType(3870);
        public static readonly ItemType ValhallaKnightsHelm = new ItemType(3871);
        public static readonly ItemType ValhallaKnightsBreastplate = new ItemType(3872);
        public static readonly ItemType ValhallaKnightsGreaves = new ItemType(3873);
        public static readonly ItemType DarkArtistsHat = new ItemType(3874);
        public static readonly ItemType DarkArtistsRobes = new ItemType(3875);
        public static readonly ItemType DarkArtistsLeggings = new ItemType(3876);
        public static readonly ItemType RedRidingHood = new ItemType(3877);
        public static readonly ItemType RedRidingDress = new ItemType(3878);
        public static readonly ItemType RedRidingLeggings = new ItemType(3879);
        public static readonly ItemType ShinobiInfiltratorsHelmet = new ItemType(3880);
        public static readonly ItemType ShinobiInfiltratorsTorso = new ItemType(3881);
        public static readonly ItemType ShinobiInfiltratorsPants = new ItemType(3882);
        public static readonly ItemType BetsysWings = new ItemType(3883);
        public static readonly ItemType CrystalChest = new ItemType(3884);
        public static readonly ItemType GoldenChest = new ItemType(3885);
        public static readonly ItemType TrappedCrystalChest = new ItemType(3886);
        public static readonly ItemType TrappedGoldenChest = new ItemType(3887);
        public static readonly ItemType CrystalDoor = new ItemType(3888);
        public static readonly ItemType CrystalChair = new ItemType(3889);
        public static readonly ItemType CrystalCandle = new ItemType(3890);
        public static readonly ItemType CrystalLantern = new ItemType(3891);
        public static readonly ItemType CrystalLamp = new ItemType(3892);
        public static readonly ItemType CrystalCandelabra = new ItemType(3893);
        public static readonly ItemType CrystalChandelier = new ItemType(3894);
        public static readonly ItemType CrystalBathtub = new ItemType(3895);
        public static readonly ItemType CrystalSink = new ItemType(3896);
        public static readonly ItemType CrystalBed = new ItemType(3897);
        public static readonly ItemType CrystalClock = new ItemType(3898);
        public static readonly ItemType SunplateClock = new ItemType(3899);
        public static readonly ItemType BlueDungeonClock = new ItemType(3900);
        public static readonly ItemType GreenDungeonClock = new ItemType(3901);
        public static readonly ItemType PinkDungeonClock = new ItemType(3902);
        public static readonly ItemType CrystalPlatform = new ItemType(3903);
        public static readonly ItemType GoldenPlatform = new ItemType(3904);
        public static readonly ItemType DynastyPlatform = new ItemType(3905);
        public static readonly ItemType LihzahrdPlatform = new ItemType(3906);
        public static readonly ItemType FleshPlatform = new ItemType(3907);
        public static readonly ItemType FrozenPlatform = new ItemType(3908);
        public static readonly ItemType CrystalWorkBench = new ItemType(3909);
        public static readonly ItemType GoldenWorkBench = new ItemType(3910);
        public static readonly ItemType CrystalDresser = new ItemType(3911);
        public static readonly ItemType DynastyDresser = new ItemType(3912);
        public static readonly ItemType FrozenDresser = new ItemType(3913);
        public static readonly ItemType LivingWoodDresser = new ItemType(3914);
        public static readonly ItemType CrystalPiano = new ItemType(3915);
        public static readonly ItemType DynastyPiano = new ItemType(3916);
        public static readonly ItemType CrystalBookcase = new ItemType(3917);
        public static readonly ItemType CrystalSofa = new ItemType(3918);
        public static readonly ItemType DynastySofa = new ItemType(3919);
        public static readonly ItemType CrystalTable = new ItemType(3920);
        public static readonly ItemType ArkhalissHood = new ItemType(3921);
        public static readonly ItemType ArkhalissBodice = new ItemType(3922);
        public static readonly ItemType ArkhalissTights = new ItemType(3923);
        public static readonly ItemType ArkhalissLightwings = new ItemType(3924);
        public static readonly ItemType LeinforsHairProtector = new ItemType(3925);
        public static readonly ItemType LeinforsExcessiveStyle = new ItemType(3926);
        public static readonly ItemType LeinforsFancypants = new ItemType(3927);
        public static readonly ItemType LeinforsPrehensileCloak = new ItemType(3928);
        public static readonly ItemType LeinforsLuxuryShampoo = new ItemType(3929);
#pragma warning restore 1591

        #endregion

        private static readonly ISet<ItemType> Accessories = new HashSet<ItemType> {
            CopperWatch,
            SilverWatch,
            GoldWatch,
            DepthMeter,
            BandOfRegeneration,
            CloudInABottle,
            HermesBoots,
            BandOfStarpower,
            RocketBoots,
            CobaltShield,
            LuckyHorseshoe,
            ShinyRedBalloon,
            Flipper,
            ObsidianSkull,
            FeralClaws,
            AnkletOfTheWind,
            Shackle,
            NaturesGift,
            GuideVoodooDoll,
            Aglet,
            Compass,
            DivingGear,
            Gps,
            ObsidianHorseshoe,
            ObsidianShield,
            CloudInABalloon,
            SpectreBoots,
            Toolbelt,
            MoonCharm,
            Ruler,
            SorcererEmblem,
            WarriorEmblem,
            RangerEmblem,
            DemonWings,
            AngelWings,
            NeptunesShell,
            StarCloak,
            PhilosophersStone,
            TitanGlove,
            CrossNecklace,
            ManaFlower,
            MusicBoxOverworldDay,
            MusicBoxEerie,
            MusicBoxNight,
            MusicBoxTitle,
            MusicBoxUnderground,
            MusicBoxBoss1,
            MusicBoxJungle,
            MusicBoxCorruption,
            MusicBoxUndergroundCorruption,
            MusicBoxTheHallow,
            MusicBoxBoss2,
            MusicBoxUndergroundHallow,
            MusicBoxBoss3,
            MusicBox,
            RedsWings,
            TinWatch,
            TungstenWatch,
            PlatinumWatch,
            Jetpack,
            ButterflyWings,
            FairyWings,
            HarpyWings,
            BoneWings,
            FlameWings,
            FrozenWings,
            SpectreWings,
            DiscountCard,
            LuckyCoin,
            SandstormInABottle,
            CharmOfMyths,
            MoonShell,
            StarVeil,
            WaterWalkingBoots,
            AdhesiveBandage,
            ArmorPolish,
            Bezoar,
            Blindfold,
            FastClock,
            Megaphone,
            Nazar,
            Vitamins,
            TrifoldMap,
            PowerGlove,
            LightningBoots,
            SunStone,
            MoonStone,
            ArmorBracing,
            MedicatedBandage,
            ThePlan,
            CountercurseMantra,
            LavaCharm,
            ObsidianWaterWalkingBoots,
            LavaWaders,
            FlyingCarpet,
            AvengerEmblem,
            MechanicalGlove,
            PaladinsShield,
            SteampunkWings,
            IceSkates,
            ClimbingClaws,
            BlackBelt,
            ShoeSpikes,
            TigerClimbingGear,
            Tabi,
            ManaRegenerationBand,
            SandstormInABalloon,
            MasterNinjaGear,
            BlizzardInABottle,
            GravityGlobe,
            HoneyComb,
            PygmyNecklace,
            LeafWings,
            BlizzardInABalloon,
            BundleOfBalloons,
            BatWings,
            HerculesBeetle,
            BeeCloak,
            EyeOfTheGolem,
            HoneyBalloon,
            BlueHorseshoeBalloon,
            WhiteHorseshoeBalloon,
            YellowHorseshoeBalloon,
            FrozenTurtleShell,
            PanicNecklace,
            RifleScope,
            DestroyerEmblem,
            JellyfishNecklace,
            ClothierVoodooDoll,
            MagicQuiver,
            MagmaStone,
            ObsidianRose,
            FireGauntlet,
            BeeWings,
            SweetheartNecklace,
            FlurryBoots,
            DTownsWings,
            WillsWings,
            CrownosWings,
            CenxsWings,
            MagicCuffs,
            MusicBoxSnow,
            MusicBoxSpace,
            MusicBoxCrimson,
            MusicBoxBoss4,
            MusicBoxAltOverworldDay,
            MusicBoxRain,
            MusicBoxIce,
            MusicBoxDesert,
            MusicBoxOcean,
            MusicBoxDungeon,
            MusicBoxPlantera,
            MusicBoxBoss5,
            MusicBoxTemple,
            MusicBoxEclipse,
            MusicBoxMushrooms,
            AnkhCharm,
            AnkhShield,
            FartInAJar,
            TatteredFairyWings,
            SpookyWings,
            NecromanticScroll,
            SniperScope,
            JellyfishDivingGear,
            ArcticDivingGear,
            FrostsparkBoots,
            FartInABalloon,
            PapyrusScarab,
            CelestialStone,
            Hoverboard,
            FestiveWings,
            HandWarmer,
            Toolbox,
            MusicBoxPumpkinMoon,
            MusicBoxAltUnderground,
            MusicBoxFrostMoon,
            AngelHalo,
            BrickLayer,
            ExtendoGrip,
            PaintSprayer,
            PortableCementMixer,
            CelestialMagnet,
            CelestialEmblem,
            CelestialCuffs,
            DiamondRing,
            BeetleWings,
            CrimsonCloak,
            MysteriousCape,
            RedCape,
            WinterCape,
            HighTestFishingLine,
            AnglerEarring,
            TackleBox,
            FrogLeg,
            FinWings,
            GingerBeard,
            FishronWings,
            MusicBoxUndergroundCrimson,
            MothronWings,
            MechanicalRuler,
            SummonerEmblem,
            PutridScent,
            FleshKnuckles,
            FlowerBoots,
            GoldRing,
            CoinRing,
            GreedyRing,
            FishFinder,
            WeatherRadio,
            MusicBoxLunarBoss,
            ArchitectGizmoPack,
            GuidetoPlantFiberCordage,
            Radar,
            RoyalGel,
            TallyCounter,
            Sextant,
            ShieldOfCthulhu,
            Stopwatch,
            MetalDetector,
            CelestialShell,
            LifeformAnalyzer,
            DpsMeter,
            FishermansPocketGuide,
            GoblinTech,
            Rek3000,
            Pda,
            SailfishBoots,
            TsunamiInABottle,
            SharkToothNecklace,
            BrainOfConfusion,
            WormScarf,
            BalloonPufferfish,
            LazuresBarrierPlatform,
            MusicBoxMartianMadness,
            MusicBoxPirateInvasion,
            MusicBoxHell,
            SharkronBalloon,
            GreenHorseshoeBalloon,
            AmberHorseshoeBalloon,
            PinkHorseshoeBalloon,
            RedString,
            OrangeString,
            YellowString,
            LimeString,
            GreenString,
            TealString,
            CyanString,
            SkyBlueString,
            BlueString,
            PurpleString,
            VioletString,
            PinkString,
            BrownString,
            WhiteString,
            RainbowString,
            BlackString,
            BlackCounterweight,
            BlueCounterweight,
            GreenCounterweight,
            PurpleCounterweight,
            RedCounterweight,
            YellowCounterweight,
            HivePack,
            YoyoGlove,
            SporeSac,
            ShinyStone,
            YoyoBag,
            MusicBoxTheTowers,
            MusicBoxGoblinInvasion,
            SolarWings,
            VortexBooster,
            NebulaMantle,
            StardustWings,
            Yoraiz0rsSpell,
            Yoraiz0rsScowl,
            JimsWings,
            SkiphssPaws,
            LokisWings,
            MechanicalLens,
            Presserator,
            AnglerTackleBag,
            BundledPartyBalloons,
            BalloonAnimal,
            PocketMirror,
            MusicBoxSandstorm,
            ApprenticesScarf,
            SquiresShield,
            HuntresssBuckler,
            MonksBelt,
            MusicBoxOldOnesArmy,
            BetsysWings,
            ArkhalissLightwings,
            LeinforsPrehensileCloak,
            LeinforsLuxuryShampoo
        };

        private static readonly ISet<ItemType> MeleeWeapons = new HashSet<ItemType> {
            IronPickaxe,
            IronBroadsword,
            IronShortsword,
            IronHammer,
            IronAxe,
            WoodenSword,
            WarAxeOfTheNight,
            LightsBane,
            EnchantedBoomerang,
            Starfury,
            NightmarePickaxe,
            TheBreaker,
            Flamarang,
            FieryGreatsword,
            MoltenPickaxe,
            Muramasa,
            BallOHurt,
            BlueMoon,
            BladeOfGrass,
            ThornChakram,
            WoodenHammer,
            BluePhaseblade,
            RedPhaseblade,
            GreenPhaseblade,
            PurplePhaseblade,
            WhitePhaseblade,
            YellowPhaseblade,
            MeteorHamaxe,
            StaffOfRegrowth,
            MoltenHamaxe,
            Sunfury,
            NightsEdge,
            DarkLance,
            Trident,
            Spear,
            WoodenBoomerang,
            Pwnhammer,
            Excalibur,
            CobaltChainsaw,
            MythrilChainsaw,
            CobaltDrill,
            MythrilDrill,
            AdamantiteChainsaw,
            AdamantiteDrill,
            DaoOfPow,
            MythrilHalberd,
            AdamantiteGlaive,
            BreakerBlade,
            AdamantiteSword,
            CobaltSword,
            MythrilSword,
            CobaltNaginata,
            Gungnir,
            LightDisc,
            Drax,
            EbonwoodSword,
            EbonwoodHammer,
            RichMahoganySword,
            RichMahoganyHammer,
            PearlwoodSword,
            PearlwoodHammer,
            IceBoomerang,
            Keybrand,
            Cutlass,
            TrueExcalibur,
            TrueNightsEdge,
            Frostbrand,
            BeamSword,
            IceBlade,
            MushroomSpear,
            TerraBlade,
            CobaltPickaxe,
            MythrilPickaxe,
            AdamantitePickaxe,
            Hammush,
            BloodButcherer,
            FleshGrinder,
            DeathbringerPickaxe,
            BloodLustCluster,
            TheMeatball,
            TheRottedFork,
            CactusSword,
            CactusPickaxe,
            ShadewoodSword,
            ShadewoodHammer,
            EnchantedSword,
            PickaxeAxe,
            CobaltWaraxe,
            MythrilWaraxe,
            AdamantiteWaraxe,
            PossessedHatchet,
            BeeKeeper,
            BoneSword,
            PalladiumSword,
            PalladiumPike,
            PalladiumPickaxe,
            PalladiumDrill,
            PalladiumChainsaw,
            OrichalcumSword,
            OrichalcumHalberd,
            OrichalcumPickaxe,
            OrichalcumDrill,
            OrichalcumChainsaw,
            TitaniumSword,
            TitaniumTrident,
            TitaniumPickaxe,
            TitaniumDrill,
            TitaniumChainsaw,
            PalladiumWaraxe,
            OrichalcumWaraxe,
            TitaniumWaraxe,
            ChlorophyteClaymore,
            ChlorophyteSaber,
            ChlorophytePartisan,
            ChlorophytePickaxe,
            ChlorophyteDrill,
            ChlorophyteChainsaw,
            ChlorophyteGreataxe,
            ChlorophyteWarhammer,
            FlowerPow,
            ChlorophyteJackhammer,
            Picksaw,
            GolemFist,
            ZombieArm,
            TheAxe,
            IceSickle,
            KoCannon,
            BonePickaxe,
            Bananarang,
            ChainKnife,
            DeathSickle,
            SpectrePickaxe,
            SpectreHamaxe,
            PaladinsHammer,
            VampireKnives,
            ScourgeOfTheCorruptor,
            Sickle,
            BloodyMachete,
            TheHorsemansBlade,
            BladedGlove,
            CandyCaneSword,
            CandyCanePickaxe,
            FruitcakeChakram,
            ChristmasTreeSword,
            NorthPole,
            ShroomiteDiggingClaw,
            Katana,
            Rockfish,
            PurpleClubberfish,
            ObsidianSwordfish,
            Swordfish,
            ReaverShark,
            SawtoothShark,
            Anchor,
            PalmWoodHammer,
            PalmWoodSword,
            FalconBlade,
            Flairon,
            BorealWoodSword,
            BorealWoodHammer,
            VortexPickaxe,
            NebulaPickaxe,
            SolarFlarePickaxe,
            LaserDrill,
            InfluxWaver,
            ChainGuillotines,
            FetidBaghnakhs,
            Seedler,
            FlyingKnife,
            ShadowflameKnife,
            Meowmere,
            StarWrath,
            ShieldOfCthulhu,
            ButchersChainsaw,
            PsychoKnife,
            Bladetongue,
            SlapHand,
            Code1,
            WoodenYoyo,
            Malaise,
            Artery,
            Amazon,
            Cascade,
            Chik,
            Code2,
            Rally,
            Yelets,
            RedsThrow,
            ValkyrieYoyo,
            Amarok,
            HelFire,
            Kraken,
            TheEyeOfCthulhu,
            FormatC,
            Gradient,
            Valor,
            ExoticScimitar,
            ClassyCane,
            StylishScissors,
            Arkhalis,
            Terrarian,
            StardustPickaxe,
            SolarEruption,
            PlatinumHammer,
            PlatinumAxe,
            PlatinumShortsword,
            PlatinumBroadsword,
            PlatinumPickaxe,
            TungstenHammer,
            TungstenAxe,
            TungstenShortsword,
            TungstenBroadsword,
            TungstenPickaxe,
            LeadHammer,
            LeadAxe,
            LeadShortsword,
            LeadBroadsword,
            LeadPickaxe,
            TinHammer,
            TinAxe,
            TinShortsword,
            TinBroadsword,
            TinPickaxe,
            CopperHammer,
            CopperAxe,
            CopperShortsword,
            CopperBroadsword,
            CopperPickaxe,
            SilverHammer,
            SilverAxe,
            SilverShortsword,
            SilverBroadsword,
            SilverPickaxe,
            GoldHammer,
            GoldAxe,
            GoldShortsword,
            GoldBroadsword,
            GoldPickaxe,
            SolarFlareHamaxe,
            VortexHamaxe,
            NebulaHamaxe,
            StardustHamaxe,
            Daybreak,
            BluePhasesaber,
            RedPhasesaber,
            GreenPhasesaber,
            PurplePhasesaber,
            WhitePhasesaber,
            YellowPhasesaber,
            MandibleBlade,
            BrandOfTheInferno,
            FlyingDragon,
            SleepyOctopod,
            GhastlyGlaive,
            SkyDragonsFury
        };

        private static readonly ISet<ItemType> RangedWeapons = new HashSet<ItemType> {
            WoodenBow,
            DemonBow,
            FlintlockPistol,
            Musket,
            Minishark,
            IronBow,
            MoltenFury,
            Harpoon,
            Handgun,
            StarCannon,
            PhoenixBlaster,
            Sandgun,
            Blowpipe,
            ClockworkAssaultRifle,
            CobaltRepeater,
            MythrilRepeater,
            AdamantiteRepeater,
            Flamethrower,
            Megashark,
            Shotgun,
            HallowedRepeater,
            EbonwoodBow,
            RichMahoganyBow,
            PearlwoodBow,
            TacticalShotgun,
            Marrow,
            IceBow,
            GrenadeLauncher,
            RocketLauncher,
            ProximityMineLauncher,
            TendonBow,
            TheUndertaker,
            CoinGun,
            ShadewoodBow,
            Boomstick,
            Blowgun,
            ConfettiGun,
            PiranhaGun,
            PalladiumRepeater,
            OrichalcumRepeater,
            TitaniumRepeater,
            ChlorophyteShotbow,
            SniperRifle,
            VenusMagnum,
            Stynger,
            Uzi,
            SnowballCannon,
            Sdmg,
            CandyCornRifle,
            JackOLanternLauncher,
            StakeLauncher,
            RedRyder,
            ElfMelter,
            ChainGun,
            SnowmanCannon,
            PulseBow,
            Revolver,
            Gatligator,
            PalmWoodBow,
            Tsunami,
            BorealWoodBow,
            ElectrosphereLauncher,
            Xenopopper,
            TheBeesKnees,
            DartPistol,
            DartRifle,
            HellwingBow,
            DaedalusStormbow,
            ShadowflameBow,
            NailGun,
            Toxikarp,
            PaintballGun,
            VortexBeater,
            PlatinumBow,
            TungstenBow,
            LeadBow,
            TinBow,
            CopperBow,
            SilverBow,
            GoldBow,
            Phantasm,
            Celebration,
            OnyxBlaster,
            PhantomPhoenix,
            AerialBane
        };

        private static readonly ISet<ItemType> MagicWeapons = new HashSet<ItemType> {
            Vilethorn,
            FlowerOfFire,
            MagicMissile,
            SpaceGun,
            AquaScepter,
            WaterBolt,
            Flamelash,
            DemonScythe,
            MagicalHarp,
            RainbowRod,
            IceRod,
            LaserRifle,
            MagicDagger,
            CrystalStorm,
            CursedFlames,
            UnholyTrident,
            FrostStaff,
            AmethystStaff,
            TopazStaff,
            SapphireStaff,
            EmeraldStaff,
            RubyStaff,
            DiamondStaff,
            NettleBurst,
            BeeGun,
            WaspGun,
            LeafBlower,
            NimbusRod,
            CrimsonRod,
            RainbowGun,
            FlowerOfFrost,
            MagnetSphere,
            HeatRay,
            StaffOfEarth,
            PoisonStaff,
            BookOfSkulls,
            GoldenShower,
            ShadowbeamStaff,
            InfernoFork,
            SpectreStaff,
            BatScepter,
            Razorpine,
            BlizzardStaff,
            VenomStaff,
            RazorbladeTyphoon,
            BubbleGun,
            MeteorStaff,
            LaserMachinegun,
            ChargedBlasterCannon,
            LifeDrain,
            ClingerStaff,
            CrystalVileShard,
            ShadowflameHexDoll,
            WandOfSparking,
            ToxicFlask,
            CrystalSerpent,
            MedusaHead,
            AmberStaff,
            NebulaArcanum,
            LastPrism,
            NebulaBlaze,
            LunarFlare,
            SpiritFlame,
            SkyFracture,
            TomeOfInfiniteWisdom,
            BetsysWrath
        };

        private static readonly ISet<ItemType> SummonWeapons = new HashSet<ItemType> {
            PygmyStaff,
            SlimeStaff,
            StaffOfTheFrostHydra,
            RavenStaff,
            HornetStaff,
            ImpStaff,
            QueenSpiderStaff,
            OpticStaff,
            SpiderStaff,
            PirateStaff,
            TempestStaff,
            XenoStaff,
            DeadlySphereStaff,
            StardustCellStaff,
            StardustDragonStaff,
            LunarPortalStaff,
            RainbowCrystalStaff,
            FlameburstRod,
            FlameburstCane,
            FlameburstStaff,
            BallistaRod,
            BallistaCane,
            BallistaStaff,
            LightningAuraRod,
            LightningAuraCane,
            LightningAuraStaff,
            ExplosiveTrapRod,
            ExplosiveTrapCane,
            ExplosiveTrapStaff
        };

        private static readonly ISet<ItemType> ThrownWeapons = new HashSet<ItemType> {
            Shuriken,
            Bone,
            SpikyBall,
            Grenade,
            ThrowingKnife,
            PoisonedKnife,
            Snowball,
            Beenade,
            RottenEgg,
            StarAnise,
            StickyGrenade,
            MolotovCocktail,
            Javelin,
            BouncyGrenade,
            FrostDaggerfish,
            BoneGlove,
            BoneJavelin,
            BoneThrowingKnife,
            HappyGrenade,
            AleTosser
        };

        /// <summary>
        /// Gets the item type's ID.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets a value indicating whether the item type is an accessory.
        /// </summary>
        public bool IsAccessory => Accessories.Contains(this);

        /// <summary>
        /// Gets a value indicating whether the item type is a melee weapon.
        /// </summary>
        public bool IsMeleeWeapon => MeleeWeapons.Contains(this);

        /// <summary>
        /// Gets a value indicating whether the item type is a ranged weapon.
        /// </summary>
        public bool IsRangedWeapon => RangedWeapons.Contains(this);

        /// <summary>
        /// Gets a value indicating whether the item type is a magic weapon.
        /// </summary>
        public bool IsMagicWeapon => MagicWeapons.Contains(this);

        /// <summary>
        /// Gets a value indicating whether the item type is a summon weapon.
        /// </summary>
        public bool IsSummonWeapon => SummonWeapons.Contains(this);

        /// <summary>
        /// Gets a value indicating whether the item type is a thrown weapon.
        /// </summary>
        public bool IsThrownWeapon => ThrownWeapons.Contains(this);

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemType"/> structure with the specified ID.
        /// </summary>
        /// <param name="id">The ID.</param>
        public ItemType(int id) {
            Id = id;
        }

        /// <inheritdoc />
        public bool Equals(ItemType other) => Id == other.Id;

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is ItemType other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode() => Id;

        /// <summary>
        /// Returns whether two item types are equal.
        /// </summary>
        /// <param name="left">The first item type.</param>
        /// <param name="right">The second item type.</param>
        /// <returns>A value indicating whether the two item types are equal.</returns>
        public static bool operator ==(ItemType left, ItemType right) => left.Equals(right);
        
        /// <summary>
        /// Returns whether two item types are not equal.
        /// </summary>
        /// <param name="left">The first item type.</param>
        /// <param name="right">The second item type.</param>
        /// <returns>A value indicating whether the two item types are not equal.</returns>
        public static bool operator !=(ItemType left, ItemType right) => !left.Equals(right);
    }
}
