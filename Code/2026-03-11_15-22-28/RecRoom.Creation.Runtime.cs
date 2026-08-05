using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Build;
using RecRoom.CircuitsV1.Protobuf;
using RecRoom.Core.Creation;
using RecRoom.DataLayer;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Algorithms;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.ObjectModel.Serialization;
using RecRoom.Persistence;
using RecRoom.Protobuf;
using RecRoom.RendererV1.DataProviders;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8404780", Offset = "0x8403780", VA = "0x188404780")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AOBJBLMOWAI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> QZWPMLSFSFE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> HCKKFYANFME;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> CVVNCCBQUPS;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> CJNNHXWRQIB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string IBVAZNTVFSH;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string HPVLWMMVPHY;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string TRCJMGCAXDZ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83F27D0", Offset = "0x83F17D0", VA = "0x1883F27D0")]
	public static bool SEPLMEYYVJM(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x83F2740", Offset = "0x83F1740", VA = "0x1883F2740")]
	public static bool NFSJBOOFFJI(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83F20C0", Offset = "0x83F10C0", VA = "0x1883F20C0")]
	public static string KZXNRDYXYTX(Guid a)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DisallowSerialization]
public enum SpawnableToolType
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	RANDOM_PAINTBALL_WEAPON = -2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	INVALID,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	AIR_CANNON,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	AVATAR_ITEM_DISPLAY,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ELEMENT_SNAP_POINT,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LAUNDRY_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_HAMMER,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PAINTBALLSPRAYCAN,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_DISCOVERY_POPUPSHOP,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_ROOM_BOOST_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	WEARABLE_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83F6010", Offset = "0x83F5010", VA = "0x1883F6010", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OLLXWODKVHH
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid LRZBNMNNHQK;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid RZXMODAQDKL;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid EMDBPMJKQZA;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid VKZZBEJSJME;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid AEKJSHTXHEQ;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid ESGDWNXKUKH;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid VSCDBCDTQQH;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid DJHOSDJCXMT;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid RSFFCBUFWUQ;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid ZFAYQOBWVFL;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid OZSXSUQZFTF;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid JZWISPWJFGD;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid UMYCYJZGTWM;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid JBOJFRDLLGH;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid MGNOZNNDQOQ;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid CVUTPQLRKOL;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid DLTZPEJVQMY;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid CCJEJULCZMJ;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid QWKLVPXZIKB;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid LEDBOLICPKY;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid GUIRXALUMVH;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid XBWFGTEZFAN;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid LEXCUWVZGWC;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid UBCIMDJKSTE;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid KCFEYIPCWFG;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid FNORLPLGEEC;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid JHMFWBICQUU;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid TGPFVDWOJVY;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid YSLXQUTMIIT;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid XMPTTBIDPHU;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid FDMMBZMOZWT;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid IBROAWCMJWP;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid ZCCBEEYZPFK;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid KXOLDOHHKFI;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid JOSFBLJCCLR;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid LOYACVMQUZM;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid FSWKZBGDIPX;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid AUSNHTKAWSL;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid JIEZTSTQNBF;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid JOUSSODHMCB;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid FPQWXPWISED;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid MGPOFIGPKUN;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid HMUVSKIZYVV;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid OOKFGBGTTFV;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid CMKSUBLXUCF;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid KANLFZMSWMU;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid FYFHIMAFRUV;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid CKQGLWTXPUC;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid AZWSFYQIAZI;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid WTZTKISQYDI;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid PIAKSDSOIZP;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid FVHVUGKYODS;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid LUZHCETHDQJ;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid HHGAUAODAKT;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid JXKSARZWOQM;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid FKSDJZLEKVO;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid UQDUVLUUYXO;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid KOJEZDXZVMR;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid URSADFRFLXP;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid APHGRSNSMGG;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid PKVZHXWXNSM;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid RXDPIHGRHGR;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid WKGQRUFUIMM;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid IZKHZPNBVHZ;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid MXHIVPGRQJR;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid DOHKFMBICIE;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid WBUFSMBZTZR;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid HLHGPUBWPLF;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid RLDAXXBENLW;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid IOAKZUZOKZW;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid JSZKJEENPYL;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid WORWAKMXKVY;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid FHGFMSLQLNT;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid MTUJJYQIBRW;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid IDSBURWTBUH;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid EECGMRWKPWN;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid NHGOHPUCRGQ;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid PBZGXVQZSDM;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid WOVLFEWQMYW;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid QYAWOEOMJSQ;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid UTIABWQBVMY;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid IAKOLIPYQIV;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid MMCSZBPXDOI;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid KCMBOPVTYVT;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid JRZDNELUOAQ;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid NVEYERHJACJ;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid DXUSMTWCDPR;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid VCIYBEUMTFL;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid SZPBSJPHWFY;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid LWFTXJKRJJR;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid BBIUIOSMRTL;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid OISQHTQHNFK;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid WLMIKXBTGZS;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid MRLVSZYGGWH;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid NEAMFQPZJSZ;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid TWGDNYKOHVR;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid LUBLPGASOWL;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid JNLSVFEFMMH;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid TCSZTORZXJQ;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid WHSFNXXNOAB;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid INLQICOJEOF;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid DNSQXFSCLHQ;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid YMNYUAILIVX;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid DBIYGRWZVLO;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid TPTMHVYFNUN;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid DBTMBFKUOIG;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid LTYFIWYLBGP;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid XWWAMMIOAPN;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid WMRDEULVYLG;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid YMOWDGLANNR;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid ULLWTILZNCY;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid YMZJXTYVGKJ;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid IATXYYWWDYK;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid YKDRKDGGEHN;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid BKFTSODTIGY;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid BMSGLNYIHFA;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid KQHLMAXXNMX;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid QGMUSETGPJV;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid XTMSFQNXACS;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid IRARBHFOWQJ;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid YBODGDVYGUN;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid GTJOYQXQOQW;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid DNCABLAOACZ;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid UKIBJWHFRTT;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid IEVSBZGNNRN;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid AFTWQPBRGMT;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid ILQMZXSBWPB;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid PJTSONJWAHV;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid NKRNSYJZLID;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid VHHNGSOUHJC;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid WOVXQMKWWPR;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid SXZFICHCRRV;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid HIKSOLFFYZR;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid IAUHTTDGLNE;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid UWUDHMUOXKR;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid ARMHMPFIOTY;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid KKLRZTXTCTK;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid FUIEHMDTHPV;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid MOHNEKHSTPL;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid YECFDABPORE;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid SCZJPBCWKRK;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid RLNLHXRIPOV;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid EPXVNTRXNBB;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid WSJQLCOUGPQ;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid MXKWBAQZUPG;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid AALBCOQPNDW;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid RCBODBQHQSC;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid OSHLUPAAGVR;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid WXMPHRUVDIT;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid WXRWEYOSMUC;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid WXXDCFIPWFL;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid WWMGVJZIIEA;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid WWRNSQTFRPJ;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid WWWUPXNDBAS;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid WXCBNEHAKMB;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid TTSCWIJDHXD;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid MENVRBFRZDH;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid JGJKSFRHWEU;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid EILHYGNQWTS;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid YWXZCRSVDOL;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid FUYHUROJQFQ;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid NIJGFFNKNNG;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid RSRZFDPOKEU;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid MYOCQLYHMSP;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid UIIPOQHBVRL;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid IVCHVTCGCRQ;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid HAPBGWFLWRT;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid CQQBNIVKNYY;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid GPPRQPIEKAA;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid LSPBGCLKYQF;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid PMCZARWOZIM;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid GQFMIJPWMIB;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid GQAFLCVZCWS;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid GQQACXDRFET;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid QZPBPZYUMUK;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid UEQXIYGKHMP;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid BKZRQTOQMTU;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid QZJUSTEXDJB;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid KORABUTFCXG;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid PHJRQXBMCIV;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid TQPNGMUUGZT;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid XUZTQTYTHSI;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid WZVVBVWCFOO;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid UQCTUFDPWXK;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid EDLUWCXBKYW;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid PGQTCQGQQGM;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid HCETTMUMCJR;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid XTHNVIRMXNU;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid PLSIJWJDTLT;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid QJLAXFIYFIJ;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid CEURMQNRFVD;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid FBTCBQPAZCJ;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid VPFIRAVAUAQ;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid RZXWYVWCUIQ;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid RKGDZMZOCXN;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid GEPBOBXTFKD;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid XQUWZJPXIBY;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid NVEUQXENXIJ;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid CTXDODCBFGN;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid IWGZGKMXUMA;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid HQXFRXFILKZ;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid EQVXANOIKKW;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid DHZWIZWOBWU;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid WUPJGJOEZJD;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid JGQDGNKGDPM;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid IJASBTVMCRL;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid RBDVCPRWRBD;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid VYHVBLIEIVZ;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid SBTUYJCPHUO;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid LRXPJEHDCUN;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid QDMYFFMBEMB;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid VMMRHPJYDDY;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid EENUQBVQQKW;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid FBTOINWQKRL;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid QJHBLBMQVYM;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid WBQKKBAIMPH;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid PCGCTURYPMG;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid GCXEKOVMUOM;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid GEIGUKFCGMG;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid PBUGQBNSZKA;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid HIMWIILJXBT;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid MRAGTADCNOD;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid NVYIBEURUNG;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid RPSPQLJDIKP;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid GDTUXBXDPTC;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid UZZKDHKDVVQ;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid ZQFGSCJZDIQ;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid VHQRPKJANBF;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid KEWQWOBRNBV;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid NFJEHSQBPMC;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid SNAVQIENMZR;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid NWVOFBOXNQO;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid EJVOLMUYOIB;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid AYDIECVJSSL;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid OKLVLTQBQEN;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid KCFSCRNDZMT;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid FKBRMVRZEMX;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid WGTOITWJMTZ;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid QRVNSVXGWYG;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid QFGDWZFZMOL;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid PNTFIAXTTDV;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid OLTVNHZKLLW;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid EVYNIIPACWJ;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid AVJFPAXHSGY;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid FDVZMHPNSKI;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid WIKMYBIQKTS;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid YXYLDSKKMBZ;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid JMNRMIEJTAI;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid BBDKWWMDKNX;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid CLHOPHNBPYR;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid MNVSYWKEJRY;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid BVKEFLAVNYH;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid IRRAWKLBCLT;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid VDYKCGTERVV;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid TILTTGTOYED;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid HMSXXTHJQFL;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid CIXKUMMFBFH;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid WZQXVLYCRHM;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid CQECCWFLEXA;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid KIBHWOXJDUD;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid VZBGGMIMXPE;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid OKNFPWWGWZX;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid ASVMOJUALVV;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid ADTKASEEPQE;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid GQDOSJLABTH;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid EQRYTTWYINP;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid LVWFLXMJLVX;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid CYIWCJHUPRH;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid TLGCBRJINYL;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid IYNKHGVVMGT;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid ODSUHVIQUJT;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid PZQMMVCMQSY;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid WCKFZQSZPSS;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid RLRABHGJHLL;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid SSERYMACCVA;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid ZSHOJWWOATN;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid FYFNZRBNOKF;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid RRMVZJDGBIO;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid XSXWRWOVIGN;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid PILHNGDWWJN;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid AHMENCNOCMT;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid DDDEHOYWUEO;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid SPAKCXZOPVO;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid XAKBHOOSFLE;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid UPTZIPDEXZV;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid PHKBLQLFREH;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid GVPANKZPKCZ;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid YCTTFCPSFYX;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid QVHTMHJRETS;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid KKLOYILTEMY;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid IDLQWPKIGFG;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid NRQDDBAXXDH;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid RLWQSSROYDH;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid MRDZECZJIWK;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid LUSJHUHUATG;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid ZAUFTVPBECD;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid FDLKXESMHIH;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid TBNJYXBDMLM;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid NARWDSQPBTJ;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid UPPFJOJVRVM;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid VPTQTJTNHEH;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid AHHCWWPVYDD;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid LSWLRLNTVXR;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid GDQWQASAIFA;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid UADVULUFLCC;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid JQZFJZUICCQ;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid UYNTVCDHYQB;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid YEOPUAQHGYY;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid JIVUFIUROEE;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid EHJLAUFSVWY;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid SHXPZWPQPEY;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid JBDATLCZBBN;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid QMWVEBUJSPZ;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid ITQMQKBZBYP;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid RHFRTBWQEYT;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid TTGCTKMQQWR;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid GZTHGRLXOLZ;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid HPMDRHOTUGY;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid WWPKLYITSTC;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid DKZRIMUBGWN;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid ZUGVOSVIMNU;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid MIIQBXJWOZY;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid KJUBODGUFSC;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid YXLZRHBCUVX;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid TALZNCUQYRD;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid GRFMYYTIUSE;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid GXISCKYZRVM;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid JVFDQQDROAM;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid QGVGPGLDKQW;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid QJTNJTVTTJX;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid RQFRHZJIAML;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid FCSOFOFVEYO;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid BGSRKBVCDOW;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid ZYUQKPVYVCQ;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid TZOHQQFFLWW;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid XWHEHWAZIID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid MHPZEAKEYFV;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid VIPCWDIGKMX;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid KWVVFDSSNBY;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid UBXYARLZXBK;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid QXIURXISCFP;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid QZDCCNUOBLX;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid ITKITZOUTXQ;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid QOEYQLQTDCW;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid VNMTZXBUIEP;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid RFOMXPVHCGA;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid EPNKECFYEGI;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid UGUBVUUOKJV;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid FGXFCPDELGI;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid BKJCPIZOEDQ;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid ZJHAITJYPKJ;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid XHOLXWRUVNK;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid GVQAJMLTKHR;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid JLXPEOCTKIW;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid LSUEUVTDEUK;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid MHHTCUMESBG;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid NCOBMFACOLQ;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid SYJYTCAMLPV;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid PTNZEROFOXJ;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid DOQHGOBXTFO;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid PNPDKSJKPID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid YGXFZMLXSMR;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid YOOOHCWERDP;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid DQCSWYEPRBM;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid VZFDBUJBLCR;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid XZWRFCXYFIS;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid SRWDPOXIHSL;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid MTBVNPCSXZE;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid CICOJUIJPRG;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid IOZODICTEON;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid ZBNBEHPOCXR;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid ULJXLAUNCEF;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid BHNMQJQLYYZ;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid ICXKOFDNKJZ;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid TMMDGVGUFAM;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid UCMXHACEPQN;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid GNQXNZQRAJM;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid PQHTXTYJQYF;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid GZTXXYSUWRU;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid FDHMZRAHOFR;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid CGDEYKGGXYU;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid OGIZXNSKSCN;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid RPVNEGOYBKC;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid ZLFLBTMIYYJ;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid ETRQXBCOWXC;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid MMWQWJDWSXA;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid EDZCNVOFDIT;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid RKXXSAZRLLW;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid MRNHPKTMGGJ;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid LKXSQEHHTUG;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid KNHFOLUABQI;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid JPTZDEBWEBS;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid AZSJTVBRPFQ;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid BGSFSTZGHAD;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid MBGAXMEXFFX;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid SPQXFJYKJAU;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid RGCHQIIPGEF;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid AHIOREOPPNO;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid HPAJYBVBCWW;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid ZPKOSAHIACM;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid GJCZOEXKUYS;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid YALHTRSKUHD;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid WPSZORVQRLI;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid KOQPPQVTEGP;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid GJRTJDMBHSD;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid FRMCSQVAFUI;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid ZFUBCEJPHQA;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid JCFCLESAPWJ;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid QNPORVUACPJ;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid JZBHYMFVVHB;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid EPBPOWTLMLY;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid FNRHEDPEFXX;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid VLDDEGVFAZU;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid MOKKLMGREEM;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid HQSQHPEFAKB;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid CNFGWAHXQBV;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid NKHOOTSBNMX;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid HDWACOJJWAI;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid TENHNUCSYDH;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid KRWZVKPZJRD;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid FFWSHOPNVQX;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid TVDNSHFIGYJ;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid FBXKIGXFIOV;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid BXPXVLRKXTQ;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid MWBZBIFWYIG;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid HNUPELPQOBN;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid BGMBSRHEDMZ;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid HNZWBSJNXMW;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid HOFCYZDLGYF;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid HMUGSDUDSWU;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid HMZNPKOBCID;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid HNEUMRHYLTM;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid HNKBJYBVVEV;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid HPFLLGYYCCY;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid HPKSINSVLOH;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid HPACRETKRAZ;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid BYZHWTHHWWL;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid RMVNAGBEJQK;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid NOQSYAPQBIK;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid RKNRVGEQGRQ;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid KDIVKDTXYKC;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid XEFZBHAPJKD;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid YOYMARHJLTR;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid PRIYNSVZGHM;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid NFMNHJKFYAU;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid OARZYXCUCAF;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid PUGGTXGMNKZ;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid RQUCEGBOTON;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid GNHDDXOMMDY;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid OVIDKMACGYF;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid FBSKVTKDJCX;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid GWQPHEVQDLA;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid JAXRCAIESIO;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid UBDLFHLYRSA;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid EQGKOKUHGCO;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid DTGMMIJPLAL;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid TCVEWFUSJXW;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid TDVNINQFFCP;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid ZYLBBQIMXVJ;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid GJZPBUNIPUI;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid OPKWEPTDDZN;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid YYINXRCMCAG;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid CUZRARXWJIY;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid OIKTEDAHMPR;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid MHUBBDQQKHL;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid PLCFZEFIYGD;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid UEYUXZVWDDB;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid MGRFAEOXWZX;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid ZKNWTCEMIVQ;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid FMOKSCVDIAH;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid OEHXWZDQPIB;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid CROIRVCSKTA;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid ZPQLDITQUUP;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid DSKOAKDQWRG;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid FLKXNOYXUZZ;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid UCLLYQKORHZ;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid QNBMLLOBTBO;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid UMIMTGSMTQD;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid SOIORATSIYF;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid ORJQBLPKKLL;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid HNOEAANIYCV;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid KEKYARFNGYM;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid WHBQMBQFKEQ;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid KLYMQWPIGTG;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid NFZLMFZAGMQ;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid JYYEBCZZVWS;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid ISAVCTGBHNI;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid UGYYXWUJUEP;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid LWBUROHMKRK;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid OIMHFPIBUMM;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid ACGAZGDOTVR;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid SMJSZJFICBL;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid HSWKNBDPZJU;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid JMJHSBXXGHR;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid TTQQXYIZNPM;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid NHRUYYTIRJQ;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid YMFRGFCAVGL;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid BDDWGALYVDR;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid SGASLFABDDT;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid HAFCFUXRDER;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid YJOXJRRWAUV;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid IDRSYVSDNEK;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid WQQQSFVUIOQ;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid KUIXFYIIQIP;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid FAGRHKZVELG;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid MTKGPVKOZIP;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid EQDOPDDKWYE;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid LJPVZSULFDX;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid KCJEGDTSWDC;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid CFVYQYBIVLV;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid VXUJPYAFAJE;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid OBEZATDFPMW;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid NAEPTBTHZVP;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid XMZJECAPQXZ;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid XHTWXJZBHJP;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid KKCEAOKNFVY;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid NDTHFYUGGQB;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid UHGKMIZVIFU;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid NZSKPZHTZUE;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid RPHLKWKSNXJ;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid IBSKDIEUMUJ;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid IBNDGBKXDJA;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid MPDXTJFJBAU;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid ISVPZYIDLDQ;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid NFXKTMEHTUV;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid TKNEPXXBSLP;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid QLNKGQMVVWN;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid VDFPSDIXKHK;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid JPLIGWCQQUD;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid RESGRVLHNXO;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid CWYNCRRZZIJ;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid PAZRDJOYYSD;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid PVLLRVCCXKU;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid ZLINVJHIJLP;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid BPCSLATWMSB;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid OUVPRELDLYB;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid UAAAIXLJOZS;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid KRRWGRMRDKQ;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid JVJLJLXYDMZ;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid LDJINQDQREJ;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid QSXEBYOBJAO;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid CTLPJCKNNFG;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid TPCSDSCIRGT;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid ASAWITCEXIZ;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid VERHYSRCJZJ;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid IABIZUVHNLD;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid AQPJQUQBTCP;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid LWHPARIIDZS;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid BGHEHRXXEEQ;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid BXLLYIZIBLP;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid TFDNEFJDQAQ;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid ARYFMKSTCUG;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid VJDWTGOUPPD;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid MIKPIGXFVGE;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid ZXALPLTTRYP;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid MLCRBIMZPLX;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid LKTNIUOWWGO;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid OAUXRTMPAJG;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid VLDLVRXFNMK;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid XLUTUPDYFKE;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid WJIQLSQLXFG;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid DDPLVAYRHRW;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid PADLQOGVYFL;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid FRKBNTDDXYY;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid KFEBETUPALX;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid RZGGBOXRGWR;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid MITMSSPQIPZ;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid AJKCMKJPDHN;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid IFMFZGORFBG;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid AZKHQZOJABX;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid PYFODCYBQOY;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid KRUSOCXCMEO;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid KRPLQWDFCTF;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid KRKETPJHTHW;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid ZIOAJKPERSV;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid WMSYFKCVNVL;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid WMDDNPVDLNK;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid TISERTDUSPA;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid BYXAEAFOQBW;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid NNINZLEDYFU;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid HQVARITWXPB;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid NXFJGTMFMPQ;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid QKWGGXTCCZC;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid PIQFZXTULXT;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid PQKOKZXFDPD;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid QZRGFQXYHMI;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid WFBJXTLKKGW;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid OBNAXEGHSTC;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid IPYUTNYOWTA;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid CQNWYINMWYX;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid HNVYEEZPUZH;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid AFPFJPBPKVS;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid KOMUNUBAFVA;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid GSGSZGBTTJB;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid IWOZMQJALKG;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid TIJXMKWXDLY;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid TMOXOPQJTQU;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid IZUGPBTVGGE;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid MQKLFBARJJJ;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid NZAVTILKLZM;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid GCGZLLVZSNX;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid XCTDNVTIMRV;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid IABYBGGBDFD;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid IQOHBUSLERG;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid TNJUWLGPDXO;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid VRXIKCIJITU;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid YXOUHDNMNEU;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid GZMFJPCJPRG;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid QCVTSVLJPFQ;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid DCNXVIJRBBY;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid FWCTLVQIPXV;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid XMMYPMZFJPO;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid AHASEVQLGWY;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid RALLXBLUXSZ;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid TTVDMBXCLUC;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid HETNROLTNSK;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid ZNMNKRTALMQ;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid WGKFTAEJJHS;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid MMIITFSENXQ;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid DCPFDFFLVUQ;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid WRHYITJCCFT;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid WUUUCNNMGHO;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid IEBRCBOXLYI;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid WRFYUXUBXAI;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid EITPABVQLCR;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid DHVVZORBBWH;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid GSPOSBFWGRT;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid MEZVSICQJNE;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid OMGWIROMOJL;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid YZTIJRTMWKK;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid OFHOXHICJRB;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid VIZRVCAOKEM;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid KZLKUCARYLO;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid JJXBSFPFHGG;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid VIUDJNUORNJ;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid HCONYWNCJJU;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid CDEDPYFMWWY;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid XYQVVPAHNZL;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid HTEQKMFAPIF;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid GRCVBZNMMZO;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid HQLXIOSXSNP;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid PQJJYKUOXJA;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid YARVFUNAFJL;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid QEJKTSBCBEO;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid VIYNROOJZZI;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid TXJLUHAEYKN;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid VTMLGONAWAH;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid KWYIHBBUSDI;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid PVJCMDXMYFB;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid PEFHFTESOAT;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid IJHFXQYJMPO;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid YLPEMANQRAZ;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid GIJRAQVBHGE;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid AAFLTGOFVRQ;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid BKIYOQVMYZP;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid QZMBWBGXXVX;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid ABFSXWTUYYG;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> ISJBURCKDAG;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> WJZOCTDNEDI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> GCHOWIMXYDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8404850", Offset = "0x8403850", VA = "0x188404850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> TBFIQIITGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8404800", Offset = "0x8403800", VA = "0x188404800")]
			get
			{
				return null;
			}
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class XUWHZQDADHY
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84057A0", Offset = "0x84047A0", VA = "0x1884057A0")]
		public static bool FXAZRAIKQFK(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8405390", Offset = "0x8404390", VA = "0x188405390")]
		private static bool FXAZRAIKQFK(DQREECIDSJF a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface JHSKPAJSNAW
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(UUFKLTCGIHU data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, VJLWNBCTMMK circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly ONSXKYCMZAP Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<YQOGBIMEPLB> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<YQOGBIMEPLB> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<YHQFEYRJQPY> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<QYHWLOYXTJM>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PTKZNRTTMYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84048A0", Offset = "0x84038A0", VA = "0x1884048A0")]
		public R1CreateTemplateParams(ONSXKYCMZAP circuits, IEnumerable<YQOGBIMEPLB> rootData, IReadOnlyList<YQOGBIMEPLB> allPersistableData, Id32<YHQFEYRJQPY> sourceGraphId, IReadOnlyList<Id128<QYHWLOYXTJM>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly ONSXKYCMZAP Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<YQOGBIMEPLB> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<YHQFEYRJQPY> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<QYHWLOYXTJM>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8404910", Offset = "0x8403910", VA = "0x188404910")]
		public R2CreateTemplateParams(ONSXKYCMZAP circuits, Id32<YHQFEYRJQPY> sourceGraphId, IReadOnlyList<Id128<QYHWLOYXTJM>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<YQOGBIMEPLB> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class UCCGRNKWTQS : HGRHTBHVQZC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid SCMWXZKCMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> MPOZVYAVJED;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4FC5470", Offset = "0x4FC4470", VA = "0x184FC5470")]
		private UCCGRNKWTQS(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8404B90", Offset = "0x8403B90", VA = "0x188404B90")]
		public static UCCGRNKWTQS New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8404D70", Offset = "0x8403D70", VA = "0x188404D70")]
		private static Dictionary<Guid, Guid> TNTKHUYVXSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8404980", Offset = "0x8403980", VA = "0x188404980")]
		public static UCCGRNKWTQS ASQCYIWNLDB(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84050A0", Offset = "0x84040A0", VA = "0x1884050A0")]
		public static UCCGRNKWTQS XOTQYACLXTG(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8404AB0", Offset = "0x8403AB0", VA = "0x188404AB0")]
		public Dictionary<Guid, Guid> DVXPFMKUPXE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
		public Dictionary<Guid, Guid> XQAJCKWOQZO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8404990", Offset = "0x8403990", VA = "0x188404990")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8404E20", Offset = "0x8403E20", VA = "0x188404E20")]
		public void TPCSMRGQSZH(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8404C20", Offset = "0x8403C20", VA = "0x188404C20")]
		public Guid OQATSJZBJYB([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8404A10", Offset = "0x8403A10", VA = "0x188404A10")]
		public Guid BILVRXGPTTW([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8404B20", Offset = "0x8403B20", VA = "0x188404B20")]
		public bool EJVBRCNNFRX([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8404B20", Offset = "0x8403B20", VA = "0x188404B20", Slot = "4")]
		private bool IMTRCEWGGDN([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface YERJBTYAXHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VBWOEXBDVVD(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YASIMTIUNRX(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OXLJEFKUAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<ByteString> GetValidRoomCurrencies();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<ByteString> GetValidRoomConsumables();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class NMEGWAPAOOY : YERJBTYAXHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KMHIHBUVIMB : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string IGNDDUPMRQO
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD9D550", Offset = "0xD9C550", VA = "0x180D9D550")]
			[DebuggerHidden]
			public KMHIHBUVIMB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x83F5F10", Offset = "0x83F4F10", VA = "0x1883F5F10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83F5FD0", Offset = "0x83F4FD0", VA = "0x1883F5FD0", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x83F5E80", Offset = "0x83F4E80", VA = "0x1883F5E80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> SZHOQXVBNDH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83F5E80", Offset = "0x83F4E80", VA = "0x1883F5E80", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? UFBVZQGOOAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? HASPUGJEMOU;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> UNXEBLINNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8404320", Offset = "0x8403320", VA = "0x188404320")]
			[IteratorStateMachine(typeof(KMHIHBUVIMB))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? FVNPQIGTKXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool CHOCHQVTKGM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool SBEGWDZNHTL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> EQVYCWQAODY(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool HGWFMMRMBOO(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8403EF0", Offset = "0x8402EF0", VA = "0x188403EF0")]
		public void FWCAWLHRQAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDC7100", Offset = "0xDC6100", VA = "0x180DC7100")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8404380", Offset = "0x8403380", VA = "0x188404380", Slot = "4")]
		public bool VBWOEXBDVVD(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8404630", Offset = "0x8403630", VA = "0x188404630", Slot = "5")]
		public bool YASIMTIUNRX(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8403E30", Offset = "0x8402E30", VA = "0x188403E30")]
		private bool EOKGACRTZVF(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8403CB0", Offset = "0x8402CB0", VA = "0x188403CB0")]
		protected List<Guid> BDDPHUBCADQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected NMEGWAPAOOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class MXIWYFNYXBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class BQLNVUWFXRV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public ONSXKYCMZAP IDNKAEPBDKV;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public BQLNVUWFXRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8405E00", Offset = "0x8404E00", VA = "0x188405E00")]
			internal Id32<ZLSSORBCQRX> OTVVEYQAGKL((Id32<YHQFEYRJQPY> GraphId, Id32<QYHWLOYXTJM> NodeId) i)
			{
				return default(Id32<ZLSSORBCQRX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int BPOUNXWVOOX = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<ZLSSORBCQRX>, MGUHXIHGKHD> YYSUOKLJQVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long GGRBXKBSHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long SAHGXAFXKAU;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<ZLSSORBCQRX, int?> WBPATWEEYRN;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long QMURIUZIEAN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long PVWHRJWXIQD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83F60D0", Offset = "0x83F50D0", VA = "0x1883F60D0")]
		public static MXIWYFNYXBC JJJRJFZQMKJ(ONSXKYCMZAP a, Id128<YHQFEYRJQPY> b, [Optional] MXIWYFNYXBC c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83F6610", Offset = "0x83F5610", VA = "0x1883F6610")]
		public static (long, long) OZHJVBNVLCR(ONSXKYCMZAP a, Id32<YHQFEYRJQPY> b, Id32<QYHWLOYXTJM> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83F69B0", Offset = "0x83F59B0", VA = "0x1883F69B0")]
		public static long UXBWJSUFDGO([In] ReadOnlySpan<Id32<ZLSSORBCQRX>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83F6AD0", Offset = "0x83F5AD0", VA = "0x1883F6AD0")]
		private static long XLHZEUCWLXN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8403C30", Offset = "0x8402C30", VA = "0x188403C30")]
		public MXIWYFNYXBC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class MGUHXIHGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long WNETLZWSODY
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xC231D0", Offset = "0xC221D0", VA = "0x180C231D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long YPDBBNIUBYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB7CD80", Offset = "0xB7BD80", VA = "0x180B7CD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F19930", Offset = "0x7F18930", VA = "0x187F19930")]
		public MGUHXIHGKHD(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class DPFRJBTDGKN
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> YULJVKKNZEU;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class MNABSRPIZTY
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class WUGBLCGTGCJ : IEnumerable<YQOGBIMEPLB>, IEnumerable, IEnumerator<YQOGBIMEPLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private YQOGBIMEPLB GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData VUBSDWYNLJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData YSVVFHNASPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams SSMLEFYNSCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams YOQOHYOYIPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int RRJFDMGHLWT;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private YQOGBIMEPLB PCBDPLRNKKK
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD9D550", Offset = "0xD9C550", VA = "0x180D9D550")]
			[DebuggerHidden]
			public WUGBLCGTGCJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8416CD0", Offset = "0x8415CD0", VA = "0x188416CD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8416DE0", Offset = "0x8415DE0", VA = "0x188416DE0", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8416B70", Offset = "0x8415B70", VA = "0x188416B70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YQOGBIMEPLB> SLZNFDDSOWZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8416B70", Offset = "0x8415B70", VA = "0x188416B70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84091F0", Offset = "0x84081F0", VA = "0x1884091F0")]
		public static SpawnableTemplateData GAXSIFRLFUZ([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8409370", Offset = "0x8408370", VA = "0x188409370")]
		public static SpawnableTemplateData GAXSIFRLFUZ([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x840A6D0", Offset = "0x84096D0", VA = "0x18840A6D0")]
		private static HashSet<Id128<URSCSJBQKKC>> QWNVCIXLQXV(IReadOnlyList<YQOGBIMEPLB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8409B90", Offset = "0x8408B90", VA = "0x188409B90")]
		private static void QKXTBZOOQLW(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84077D0", Offset = "0x84067D0", VA = "0x1884077D0")]
		public static Result<UCCGRNKWTQS, TryCloneTemplateError> DXVSUUQFMZZ(SpawnableTemplateData a, SpawnTemplateParams b, UCCGRNKWTQS? srcRemapper, bool c)
		{
			return default(Result<UCCGRNKWTQS, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84090E0", Offset = "0x84080E0", VA = "0x1884090E0")]
		[IteratorStateMachine(typeof(WUGBLCGTGCJ))]
		private static IEnumerable<YQOGBIMEPLB> EUERFCGTJRC(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x840AA70", Offset = "0x8409A70", VA = "0x18840AA70")]
		private static void TUGRKLZZDAD(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8409500", Offset = "0x8408500", VA = "0x188409500")]
		private static bool MNRSUZSZSCS(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8408DF0", Offset = "0x8407DF0", VA = "0x188408DF0")]
		private static Dictionary<Guid, DQREECIDSJF> EKBBIOTIJNI(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x840AD70", Offset = "0x8409D70", VA = "0x18840AD70")]
		private static void YNEDAQJALPK(bool a, YQOGBIMEPLB b, UCCGRNKWTQS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x840AAE0", Offset = "0x8409AE0", VA = "0x18840AAE0")]
		private static void YBGQVSCGCSM(YQOGBIMEPLB a, Guid b, SpawnTransformData? c, Dictionary<Guid, DQREECIDSJF> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x840A220", Offset = "0x8409220", VA = "0x18840A220")]
		private static void QPZUEYGBHTP(IEnumerable<YQOGBIMEPLB> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public ONSXKYCMZAP circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public OXLJEFKUAPM roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public JHSKPAJSNAW circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<YHQFEYRJQPY> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public KBQIDJEAJVG globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<YQOGBIMEPLB> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public UJFOVWSSSBM photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Matrix4x4 BJDMLQQTHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x84135E0", Offset = "0x84125E0", VA = "0x1884135E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS GMHSDKUXBJG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x84135A0", Offset = "0x84125A0", VA = "0x1884135A0")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1457100", Offset = "0x1456100", VA = "0x181457100")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84136E0", Offset = "0x84126E0", VA = "0x1884136E0")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8412F80", Offset = "0x8411F80", VA = "0x188412F80")]
		public static SpawnTransformData DZCGXADOBTA(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84137B0", Offset = "0x84127B0", VA = "0x1884137B0")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x84137D0", Offset = "0x84127D0", VA = "0x1884137D0")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8413510", Offset = "0x8412510", VA = "0x188413510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8413270", Offset = "0x8412270", VA = "0x188413270")]
		public SpawnTransformData JHSBDRYFIAA(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8413200", Offset = "0x8412200", VA = "0x188413200")]
		public static SpawnTransformData HKHJCMUPVIM(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8413480", Offset = "0x8412480", VA = "0x188413480")]
		public readonly CircuitsRigidTransform MLRCXCOJSZO()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private readonly IMZVXBWNFZH _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x171EEC0", Offset = "0x171DEC0", VA = "0x18171EEC0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, IMZVXBWNFZH innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8414640", Offset = "0x8413640", VA = "0x188414640")]
		public KTXQESFTWLM RIYHKHQSVEV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8414420", Offset = "0x8413420", VA = "0x188414420")]
		public static Result<UCCGRNKWTQS, TryCloneTemplateError> New(UGXTDRRGETJ<None> innerError)
		{
			return default(Result<UCCGRNKWTQS, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8414590", Offset = "0x8413590", VA = "0x188414590")]
		public static Result<UCCGRNKWTQS, TryCloneTemplateError> New(KTXQESFTWLM innerError)
		{
			return default(Result<UCCGRNKWTQS, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84144D0", Offset = "0x84134D0", VA = "0x1884144D0")]
		public static Result<UCCGRNKWTQS, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<UCCGRNKWTQS, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class PKWMALBGKRZ : IDisposable, HFFGMZVBWLU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> BPEKFPQTEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float BSMDBLLFKHA;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags NMDPLBVSOMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAD4F50", Offset = "0xAD3F50", VA = "0x180AD4F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool SIWBDVFPFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x840D480", Offset = "0x840C480", VA = "0x18840D480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JWZIVILQXTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x840D790", Offset = "0x840C790", VA = "0x18840D790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> QBJLOOGSVLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F60", Offset = "0xAD1F60", VA = "0x180AD2F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int IDHYURSRVWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x840D250", Offset = "0x840C250", VA = "0x18840D250", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CTDGKMOXLTN
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x840D340", Offset = "0x840C340", VA = "0x18840D340")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x840D7A0", Offset = "0x840C7A0", VA = "0x18840D7A0")]
		public PKWMALBGKRZ(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x840BF80", Offset = "0x840AF80", VA = "0x18840BF80", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x840C360", Offset = "0x840B360", VA = "0x18840C360")]
		public Vector3 KRHFEWICCRA(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x840CEE0", Offset = "0x840BEE0", VA = "0x18840CEE0", Slot = "6")]
		public Quaternion NEGVWFOKJML(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x840BEE0", Offset = "0x840AEE0", VA = "0x18840BEE0", Slot = "5")]
		public Vector3 DNVGKNAMCNY(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x840C2A0", Offset = "0x840B2A0", VA = "0x18840C2A0", Slot = "7")]
		public float IUCKGZTDIBZ(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x840AE00", Offset = "0x8409E00", VA = "0x18840AE00")]
		public void AJUSQLWSQMZ(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x840C300", Offset = "0x840B300", VA = "0x18840C300")]
		private bool JOSLSVYFISN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x840BFE0", Offset = "0x840AFE0", VA = "0x18840BFE0")]
		public void EDWIJPILUWL(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x840D010", Offset = "0x840C010", VA = "0x18840D010")]
		public void OOAKHTUAXSS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x840D490", Offset = "0x840C490", VA = "0x18840D490")]
		public void YXUSYGRQHDR(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x840D5E0", Offset = "0x840C5E0", VA = "0x18840D5E0")]
		public void ZDXGTQJCHSD(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x840D0A0", Offset = "0x840C0A0", VA = "0x18840D0A0")]
		public void PMWDBLJTBDX(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x840C140", Offset = "0x840B140", VA = "0x18840C140")]
		public void GWKBFIFVYBS(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x840B6E0", Offset = "0x840A6E0", VA = "0x18840B6E0")]
		public static Quaternion BBYNWHKCLXA(Quaternion a, int b, float c, HFFGMZVBWLU d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x840C830", Offset = "0x840B830", VA = "0x18840C830")]
		public Bounds NCOKNRTDZOO(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x840D1F0", Offset = "0x840C1F0", VA = "0x18840D1F0", Slot = "10")]
		public virtual void PRPTJFGJZTA(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x840D290", Offset = "0x840C290", VA = "0x18840D290")]
		public NativeList<CurvePointData> SVMAGOTJLSK(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8406420", Offset = "0x8405420", VA = "0x188406420")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8406070", Offset = "0x8405070", VA = "0x188406070")]
		public Quaternion QQODVRKLJMP(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8406130", Offset = "0x8405130", VA = "0x188406130")]
		public CurvePoint UFFGCENGPGX(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8405ED0", Offset = "0x8404ED0", VA = "0x188405ED0")]
		public FNTTJBKJCSK IJWJOGMFRWP(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class TDLWCKYSYOA : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84141F0", Offset = "0x84131F0", VA = "0x1884141F0", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8413990", Offset = "0x8412990", VA = "0x188413990")]
		private void CVDZGDCKRYH(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8413930", Offset = "0x8412930", VA = "0x188413930")]
		private void CVDZGDCKRYH(Dictionary<Guid, Guid> a, DYADTBZIWWU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8413F70", Offset = "0x8412F70", VA = "0x188413F70")]
		private void CVDZGDCKRYH(Dictionary<Guid, Guid> a, JCBBABLQXYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public TDLWCKYSYOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class QUWTMHXWDUN : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8412520", Offset = "0x8411520", VA = "0x188412520", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public QUWTMHXWDUN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class HLYBUNXBXOK : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8406A10", Offset = "0x8405A10", VA = "0x188406A10", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public HLYBUNXBXOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class MHJZLIFVXXG : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8407670", Offset = "0x8406670", VA = "0x188407670", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public MHJZLIFVXXG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class HSARTVUYLMG : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8406B70", Offset = "0x8405B70", VA = "0x188406B70", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public HSARTVUYLMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class ISYQHMNENRR : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8406D90", Offset = "0x8405D90", VA = "0x188406D90", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ISYQHMNENRR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class RNJKISTKECV : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x84125D0", Offset = "0x84115D0", VA = "0x1884125D0", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public RNJKISTKECV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class XHDYPESLXTE : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x84171C0", Offset = "0x84161C0", VA = "0x1884171C0", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public XHDYPESLXTE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class TQZUIZNCVCQ : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8414270", Offset = "0x8413270", VA = "0x188414270", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public TQZUIZNCVCQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class GQNZXLURGCQ : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8406860", Offset = "0x8405860", VA = "0x188406860", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public GQNZXLURGCQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class YGSRFRYYUII : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84172B0", Offset = "0x84162B0", VA = "0x1884172B0", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public YGSRFRYYUII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class ALYNSNXRRBV : JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly UKXWMUHVQIJ ACIBHCLUFYE;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x84057D0", Offset = "0x84047D0", VA = "0x1884057D0", Slot = "4")]
		public void UBHOUXKSCNQ(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ALYNSNXRRBV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public UJFOVWSSSBM photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface JBLZRNTQHZB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UBHOUXKSCNQ(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class UNOBPNNKKLK
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly JBLZRNTQHZB[] CROBLZAQIYI;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8414C90", Offset = "0x8413C90", VA = "0x188414C90")]
		public static void IMCMVKQQUQN(YQOGBIMEPLB a, UCCGRNKWTQS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8415180", Offset = "0x8414180", VA = "0x188415180")]
		public static void MULNULGUEIV(YQOGBIMEPLB? data, UCCGRNKWTQS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8414F10", Offset = "0x8413F10", VA = "0x188414F10")]
		public static void JOYQJPDTIAL(YQOGBIMEPLB? data, UCCGRNKWTQS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x84148A0", Offset = "0x84138A0", VA = "0x1884148A0")]
		public static void FXAZRAIKQFK(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public YQOGBIMEPLB viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x840D820", Offset = "0x840C820", VA = "0x18840D820")]
		public Guid WINDDGYJGZQ(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface UJFOVWSSSBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> EGNRVAZISEJ;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> QLNNFRXKGJN;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> NRGETRVODYD;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker DFVKQSNGFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> TMTUKSWHPRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> HUZVKZSIZLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> SYZEAHFPRAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> EFXYRYHXDSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> GHFFKWPYHNR;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> INGSOTZVLQO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> ONAPEKLOQRV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> NCVCHHTSOKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> KXEIWXTIAJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x840FE60", Offset = "0x840EE60", VA = "0x18840FE60")]
		public static void JMRFCPOWGRF(SpawnableTemplateData a, BKQBJUFQDBX b, UCCGRNKWTQS c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8411A40", Offset = "0x8410A40", VA = "0x188411A40")]
		public static PersistedRoomDataReferences XEQCBBDWYVR(PersistedRoomData a, BKQBJUFQDBX? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8411650", Offset = "0x8410650", VA = "0x188411650")]
		public static PersistedRoomDataReferences LFQPRHLBKCY(SpawnableTemplateData a, BKQBJUFQDBX? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8411980", Offset = "0x8410980", VA = "0x188411980")]
		public static PersistedRoomDataReferences VXCRMOARYAS(ZTDPOXWSYTQ a, DTSKQQGJHEC b, BKQBJUFQDBX? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8411CC0", Offset = "0x8410CC0", VA = "0x188411CC0")]
		public static PersistedRoomDataReferences YRWUSBQUWOL(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x84123C0", Offset = "0x84113C0", VA = "0x1884123C0")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x84121F0", Offset = "0x84111F0", VA = "0x1884121F0")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x840E1F0", Offset = "0x840D1F0", VA = "0x18840E1F0")]
		private void JLOBOFBUDFM(PersistedRoomData a, BKQBJUFQDBX? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x840EA70", Offset = "0x840DA70", VA = "0x18840EA70")]
		private void JLOBOFBUDFM(SpawnableTemplateData a, BKQBJUFQDBX? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x840D8C0", Offset = "0x840C8C0", VA = "0x18840D8C0")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x840ED80", Offset = "0x840DD80", VA = "0x18840ED80")]
		private void JLOBOFBUDFM(ZTDPOXWSYTQ? a, BKQBJUFQDBX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x840ED00", Offset = "0x840DD00", VA = "0x18840ED00")]
		private void JLOBOFBUDFM(DTSKQQGJHEC? a, BKQBJUFQDBX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x840E890", Offset = "0x840D890", VA = "0x18840E890")]
		private void JLOBOFBUDFM(VWSQLTXOMLM? a, BKQBJUFQDBX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8411AC0", Offset = "0x8410AC0", VA = "0x188411AC0")]
		private static bool YRCMJUDSCQR(VWSQLTXOMLM a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84116D0", Offset = "0x84106D0", VA = "0x1884116D0")]
		private static bool PZLBGDZAVHV(VWSQLTXOMLM a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8410860", Offset = "0x840F860", VA = "0x188410860")]
		private static void JMRFCPOWGRF(DTSKQQGJHEC? root, BKQBJUFQDBX a, UCCGRNKWTQS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8410930", Offset = "0x840F930", VA = "0x188410930")]
		private static void JMRFCPOWGRF(VWSQLTXOMLM? customProperties, BKQBJUFQDBX a, UCCGRNKWTQS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x840FAE0", Offset = "0x840EAE0", VA = "0x18840FAE0")]
		private static void JMRFCPOWGRF(ZTDPOXWSYTQ? root, BKQBJUFQDBX a, UCCGRNKWTQS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8411000", Offset = "0x8410000", VA = "0x188411000")]
		private static void JMRFCPOWGRF(CircuitsV2.Protobuf.CircuitNodeData? node, BKQBJUFQDBX a, UCCGRNKWTQS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x840F760", Offset = "0x840E760", VA = "0x18840F760")]
		private void JLOBOFBUDFM(CircuitsV2.Protobuf.CircuitNodeData? a, BKQBJUFQDBX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x840DE60", Offset = "0x840CE60", VA = "0x18840DE60")]
		private void GDNWHGGUPTQ(Guid? a, BKQBJUFQDBX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x840E490", Offset = "0x840D490", VA = "0x18840E490")]
		private void JLOBOFBUDFM(YQOGBIMEPLB? a, BKQBJUFQDBX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8410BC0", Offset = "0x840FBC0", VA = "0x188410BC0")]
		private static void JMRFCPOWGRF(YQOGBIMEPLB? viewData, BKQBJUFQDBX a, UCCGRNKWTQS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8411910", Offset = "0x8410910", VA = "0x188411910")]
		private void RUTRKNXLYPF(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x840E120", Offset = "0x840D120", VA = "0x18840E120")]
		private void JBQMZVBQAYZ(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x840E0D0", Offset = "0x840D0D0", VA = "0x18840E0D0")]
		private void JBQMZVBQAYZ(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x840E070", Offset = "0x840D070", VA = "0x18840E070")]
		private void JBQMZVBQAYZ(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class XEPONEUTWZG : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> KHNDFAWVTYV;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x8416FA0", Offset = "0x8415FA0", VA = "0x188416FA0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x8417060", Offset = "0x8416060", VA = "0x188417060", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x8417110", Offset = "0x8416110", VA = "0x188417110", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x8416EC0", Offset = "0x8415EC0", VA = "0x188416EC0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
			public XEPONEUTWZG(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8416E20", Offset = "0x8415E20", VA = "0x188416E20", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8416E70", Offset = "0x8415E70", VA = "0x188416E70", Slot = "9")]
			public void Reset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			[CompilerGenerated]
			private sealed class BBEGDTOCBNU : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int NNYUMBTASKT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry GLROCXYMSEU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts SULNKEFFSGR;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry MATNXWPDAPO
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xCE16B0", Offset = "0xCE06B0", VA = "0x180CE16B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object OPJHDGDZAVH
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x84058F0", Offset = "0x84048F0", VA = "0x1884058F0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
				[DebuggerHidden]
				public BBEGDTOCBNU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
				[DebuggerHidden]
				private void FQZHCUDIKGC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8405940", Offset = "0x8404940", VA = "0x188405940", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x8405A40", Offset = "0x8404A40", VA = "0x188405A40", Slot = "8")]
				[DebuggerHidden]
				private void SEWTXRYPVUP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private ICollection NVBMCNFVLAG
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x8412A00", Offset = "0x8411A00", VA = "0x188412A00", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x8412B20", Offset = "0x8411B20", VA = "0x188412B20", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x8412C00", Offset = "0x8411C00", VA = "0x188412C00", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool WHJSHLYLPRP
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x8412C90", Offset = "0x8411C90", VA = "0x188412C90", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool WDAOTTEFTXK
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x8412850", Offset = "0x8411850", VA = "0x188412850", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection HUAUFXFGSUM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x8412940", Offset = "0x8411940", VA = "0x188412940", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int KCSTGUDOQKJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x84127B0", Offset = "0x84117B0", VA = "0x1884127B0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool UZENCYLAQKQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x8412A80", Offset = "0x8411A80", VA = "0x188412A80", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object LGHQCLBBWPX
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x8412C40", Offset = "0x8411C40", VA = "0x188412C40", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8412990", Offset = "0x8411990", VA = "0x188412990")]
			[IteratorStateMachine(typeof(BBEGDTOCBNU))]
			private IEnumerator<DictionaryEntry> ORXFVHYGBBL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x84128A0", Offset = "0x84118A0", VA = "0x1884128A0", Slot = "19")]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8412CE0", Offset = "0x8411CE0", VA = "0x188412CE0", Slot = "13")]
			private IDictionaryEnumerator VZGKSMCCFDC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8412760", Offset = "0x8411760", VA = "0x188412760", Slot = "9")]
			private void AWVYPAGDVKF(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8412DB0", Offset = "0x8411DB0", VA = "0x188412DB0", Slot = "10")]
			private void XCCTOCCFWOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8412800", Offset = "0x8411800", VA = "0x188412800", Slot = "8")]
			private bool DMDUWCVLWKP(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8412AD0", Offset = "0x8411AD0", VA = "0x188412AD0", Slot = "14")]
			private void RMUSJZVIPYG(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8412E00", Offset = "0x8411E00", VA = "0x188412E00", Slot = "15")]
			private void ZLTKLITFIHA(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class EZQWNPEUXVY : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int NNYUMBTASKT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry GLROCXYMSEU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention SULNKEFFSGR;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry MATNXWPDAPO
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xCE16B0", Offset = "0xCE06B0", VA = "0x180CE16B0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object OPJHDGDZAVH
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x84066B0", Offset = "0x84056B0", VA = "0x1884066B0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
				[DebuggerHidden]
				public EZQWNPEUXVY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
				[DebuggerHidden]
				private void FQZHCUDIKGC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x8406700", Offset = "0x8405700", VA = "0x188406700", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x8406820", Offset = "0x8405820", VA = "0x188406820", Slot = "8")]
				[DebuggerHidden]
				private void SEWTXRYPVUP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ICollection NVBMCNFVLAG
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x8407150", Offset = "0x8406150", VA = "0x188407150", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x8407240", Offset = "0x8406240", VA = "0x188407240", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x8407350", Offset = "0x8406350", VA = "0x188407350", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool WHJSHLYLPRP
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x84073E0", Offset = "0x84063E0", VA = "0x1884073E0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool WDAOTTEFTXK
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x8406FC0", Offset = "0x8405FC0", VA = "0x188406FC0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection HUAUFXFGSUM
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x84070A0", Offset = "0x84060A0", VA = "0x1884070A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int KCSTGUDOQKJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x8406F20", Offset = "0x8405F20", VA = "0x188406F20", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool UZENCYLAQKQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x84071A0", Offset = "0x84061A0", VA = "0x1884071A0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object LGHQCLBBWPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x8407390", Offset = "0x8406390", VA = "0x188407390", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x290A050", Offset = "0x2909050", VA = "0x18290A050")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x84070F0", Offset = "0x84060F0", VA = "0x1884070F0")]
			[IteratorStateMachine(typeof(EZQWNPEUXVY))]
			private IEnumerator<DictionaryEntry> ORXFVHYGBBL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8407010", Offset = "0x8406010", VA = "0x188407010", Slot = "19")]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8407430", Offset = "0x8406430", VA = "0x188407430", Slot = "13")]
			private IDictionaryEnumerator VZGKSMCCFDC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8406ED0", Offset = "0x8405ED0", VA = "0x188406ED0", Slot = "9")]
			private void AWVYPAGDVKF(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8407500", Offset = "0x8406500", VA = "0x188407500", Slot = "10")]
			private void XCCTOCCFWOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8406F70", Offset = "0x8405F70", VA = "0x188406F70", Slot = "8")]
			private bool DMDUWCVLWKP(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x84071F0", Offset = "0x84061F0", VA = "0x1884071F0", Slot = "14")]
			private void RMUSJZVIPYG(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8407550", Offset = "0x8406550", VA = "0x188407550", Slot = "15")]
			private void ZLTKLITFIHA(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8416160", Offset = "0x8415160", VA = "0x188416160")]
		public static UgcRoomSaveStatsDetailed XEQCBBDWYVR(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84159B0", Offset = "0x84149B0", VA = "0x1884159B0")]
		[CompilerGenerated]
		internal static int CSACEWEBVJP([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8415AD0", Offset = "0x8414AD0", VA = "0x188415AD0")]
		[CompilerGenerated]
		internal static void KJIHJTCWTQB(int a, [In] ZTDPOXWSYTQ graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		ParticleVfx,
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		ConsumableItem
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class BKQBJUFQDBX
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid MWAZULPACWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> ONAPEKLOQRV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind GMGTQKAJVHL;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8416B10", Offset = "0x8415B10", VA = "0x188416B10")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly UCCGRNKWTQS PHUUDFDKWZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> MQKZSCZSNPQ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public UCCGRNKWTQS HJXNBQPSPXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8405A80", Offset = "0x8404A80", VA = "0x188405A80")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8405C80", Offset = "0x8404C80", VA = "0x188405C80")]
		public bool YZAMZPADBTE(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8405D70", Offset = "0x8404D70", VA = "0x188405D70")]
		public BKQBJUFQDBX()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
