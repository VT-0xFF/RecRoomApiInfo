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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x979BC10", Offset = "0x979AA10", VA = "0x18979BC10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LRNYUJDOYAG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> VOJIKSLTHVG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> WJYBBLTRVDU;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> DXKNIHQEIVI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> ZVBMVDXZNJN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string TMOXZKLIHPH;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string JADQUDSHJXK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string WSHSOKDBJBL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9797890", Offset = "0x9796690", VA = "0x189797890")]
	public static bool BDAIFIHKQAM(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9798060", Offset = "0x9796E60", VA = "0x189798060")]
	public static bool ZUYOPUMQWUU(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9797990", Offset = "0x9796790", VA = "0x189797990")]
	public static string BUBCANWGVYL(Guid a)
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
		[Cpp2IlInjected.Address(RVA = "0x979BA90", Offset = "0x979A890", VA = "0x18979BA90", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NYTMXJTFTJB
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid WRIKEBYICKA;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid KXKDEQCPKNX;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid JNTQVRZNYJK;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid ILASPMIETCC;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid ITSAXNAXWTM;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid GVCCURPTOSN;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid DHHVHMKXIEZ;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid UZEKURPIWXD;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid HNHPYZVZAQK;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid QHWNGEIQCEX;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid DGHXWNPQTYN;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid BRKJEWOWIKF;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid GNAMHWTURYG;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid DTGDUGPIISZ;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid ZHFXCYNYJYC;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid LKERZPOCFWR;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid LRPKMCEBFTI;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid MRQTZXPHCUX;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid LZOQGXJXNYD;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid QUKAFFJNKVI;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid GQFSHVCPQDZ;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid XVMDSKRPGUT;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid FMBSFMLIVAY;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid UWNJRRDZDUM;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid JRDHXDCLMJI;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid KVFYRWHWLYI;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid PWWFUPSNIMC;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid RUZISLDLPCM;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid UOVXKZRJKUF;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid VGUWIRQMPYM;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid YMVYXZPRJYZ;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid FNIGMMZZJNP;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid NBLPSQEFUSC;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid RLQSSZKMONG;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid GJDRSTGWPZH;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid WLMTDPJEQBW;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid TBFHPEQRIAT;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid XXTYILGNTHL;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid BRFOPZZVHMB;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid TOMNUNCYBNJ;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid VVGIHRQVYBT;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid SKKDOALUGXV;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid KZNVXSOGGZH;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid FMDCMCZIMRX;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid WXRKQLWXMWD;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid DUPWRJBHDUS;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid XURBCODPWBZ;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid VZTLGDNAAGY;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid AYMLQOHXTXC;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid ORUWRSVUODC;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid WFXXNPXJDNB;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid HTULVNLNFOG;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid ALWHFQLPWYH;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid DDOBBEFNYSJ;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid EJTZOTCRMLI;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid MMDSACBKPHE;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid PYMTGSZOAGO;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid XLHWHAPZASD;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid IFLZAPKWPYH;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid WJHDBWDMDPS;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid GKYDAYCLDVM;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid MQJIMLCZSBR;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid VFMEAPLOYUG;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid JZGUJPLHAVL;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid LXRMFLNZWYF;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid XWNCFZNXJOO;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid BRQOOXGPFKB;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid HQBQGBOQYIJ;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid WCMWLZKQNDQ;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid YHMYVFMZKJY;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid KLNARYMAGTD;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid TBIIWLOXMLW;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid HDYTGVJAXIH;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid SEXBWNOFFJY;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid IUPVLMCBAND;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid YOYRZOQKSXR;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid KFNLSSBZHWW;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid XVRMBWCYQII;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid MVSZFZBWTSM;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid JUUHYHOHVKS;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid RJRUTDGYZQG;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid STPPTGZZAZR;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid MGYNERRRRIW;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid CJTDQDQGBBJ;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid REDZATMAPOO;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid ASFGBXNKBVJ;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid BAGGAZPSDGZ;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid TUPFNGTCOVJ;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid ZOQAMHMPBJK;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid PCASKJSXSOF;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid GLBHBJCCSUD;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid NQOHNODRJDU;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid NLRLCJOJYKK;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid KYYIXHRCCMZ;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid XPSQBEZZHOL;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid BANSTFCPHPH;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid FAYCRBSGWDT;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid VRGGQDMPDRT;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid TUPUCFYPVHS;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid NMPAAVPRCQT;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid QIVTETAHNNV;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid HFFLHQLXZPC;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid KUVTNLMRFWT;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid ANWHMZEJSKC;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid QZUCIFKPFFB;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid ANLTSLQOZNK;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid GWQVFULTAQR;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid TTRPEPJASQV;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid JANNUMOMJAS;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid LVXUDKGFQIR;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid YAKJTIYVJBE;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid LVNGIWSKXLZ;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid RSPLCKXAGFS;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid LYIYWNKZZOV;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid FHGVXRQJAMW;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid IGCJSEFOKSA;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid HPGZJXSUPOZ;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid ORJYEMAGASR;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid WEVCSBTBTYA;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid LLKZSERYUTN;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid KIRGVGQRZXN;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid OSADCIWFMRO;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid DMHWDIVDSPV;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid GGWAQMUCSQP;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid PBDDWQUZGSR;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid HDKPXPUZKWF;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid ERLPLZJLBBX;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid RVHNOSIIMMV;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid ALYJZSDNLVP;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid HKZHNZAGGVU;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid YNBXKANEFVX;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid TZEZLVJNOJT;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid MZYEBAXZBDH;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid KEBJLXDFAII;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid MJUZHCUYSMH;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid XLCLDPOWAYM;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid PFBJKVAYVVA;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid ITBRHIMGSMZ;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid RHCMXZYVEQP;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid TASHTEFCMQM;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid YGQMCWLJMLU;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid WSCGXCOKJXN;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid GLCXOKRCIUV;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid IBUEXCKIPRS;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid KCVZOCLGXSO;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid AYNEJYAFZTM;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid HTQJHJMAGZK;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid RKIDXMMUAMV;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid YCPRPKUAHEB;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid YBZWXQMIEWA;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid YCFDUXGFOHJ;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid YBPJDCYNLZI;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid YBUQAJSKVKR;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid YBEVIPKSTCQ;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid YBKCFWEQCNZ;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid SYIEYVLEAXV;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid DAKBIQXVTFB;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid DUNFNLUWLZE;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid OIPGINYMRAC;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid PAJYBZOMPPH;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid NFJMFEJPQYA;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid AVNFKLALZVQ;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid ZHJEMOUVKYO;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid MZQRXWPNYOR;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid LCNFVKNGFDV;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid WJXKEFOKYMA;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid SYJOCAQSMUP;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid DCYLLIAAQYK;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid JHKAXJGVHHQ;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid RIPWYSDMXHZ;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid TCTXFPXPYVQ;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid JHEUACMXXWH;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid JGZNCVTAOKY;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid JGUGFOZDEZP;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid TQGVUMPPFIQ;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid PODRAILOQFH;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid TXGKSPPDZIA;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid TQWQMGXHHQR;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid DGNCKYVRQQO;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid EDGEAWNZFGL;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid NQHHRCDYGDR;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid APIJMOCVQAO;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid LHKESJSSJQE;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid WZDXSEMBJNU;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid ZHWYBZSHQQU;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid EAAUGYSYZCW;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid YXKLZFSRXPL;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid ZWVXWUKDJZO;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid VYMVWSVYDTF;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid ARUGBDIHGQH;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid QCRKWTJJPTV;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid MWICHFRMTXN;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid EAWSQJSNRNQ;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid SPUZASDHOAO;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid FMUOAEYUURT;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid EBZBBKPOMKN;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid YKXBEUDNDHW;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid XWTZMPJYQEL;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid XXXPVWOWAGX;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid OTUCFMFYMBU;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid WAECYGYRGUX;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid FDKTJWZWSVG;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid MBYWAQKFONY;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid RIVHRGZBHEX;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid OPRPJKYULWU;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid JSFANBSVDGD;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid HNLDDSQKWVN;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid ZUETSVHXROF;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid KWQWSZAZHLC;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid BBDGUGBPZOP;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid OEHHXPFGUTJ;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid LTOFDCQHHQY;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid KCMIXVDNSCY;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid OOFLUAMCQXZ;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid RNQQZEDCFZA;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid CJECFWDUQWD;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid PCHYDAFALYU;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid BPFAKPTPHOC;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid FNQGYZMDBQI;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid KMTWGADNLEW;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid DSLIOGAESUL;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid QSJSSZCMNEB;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid YOUEDLTZSCG;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid WAZAIMLSZIF;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid YTGWUTZVDZM;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid OEXTIVVGSOE;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid UGIKCQNJTVY;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid WAGEFZNXRGZ;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid SEXUAQXBMPL;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid DKSHHLSCIGA;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid OBLXYRZURZT;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid DMYKQUASBAI;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid TEGCSZUTGAT;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid VCEGXQAOWCV;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid HTFEEDSCRED;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid WRMFCFTKHUR;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid JJMPTZHBKRP;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid WTLSLRWNJLP;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid LYEVOJEUAAA;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid COHNFAKXHQJ;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid TLZPKYJXQHD;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid JFSCCPYVQYK;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid KDAXGSUXWIT;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid HGOZVIUWOUS;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid QEJESXEGPOW;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid ALNPRBAGEJI;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid KRDUSKZYBIN;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid WZGUFTZRURE;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid CSERVXFGIHZ;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid XBKFEFVYVOL;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid YLDWWBMXHCY;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid YBGFXZHODZT;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid KVHBCWWDTLJ;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid WEYVUZJMGEV;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid NSMQSLTOSCJ;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid GFIVZJXBJKT;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid THSLNIGYRKP;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid PJMIBPGYZVO;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid DAPSPJTRRGY;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid FBBCJSEEWPH;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid MTLNLRVAVBG;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid OULRLZWSHSL;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid MRXWFQEVXAN;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid OUXIGCJNLQO;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid IQCTQNAYGAL;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid LOTXJELETWX;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid ASITWWFYFOX;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid MAFQKDGOJNR;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid BDGLJPVOJEF;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid DAZMLYODKPH;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid HNIPOFTCSVJ;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid FAUDYNQMOAW;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid VYEZQTOCUYM;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid ZENORJSYKPB;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid HKJAYXFZILG;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid SMPTOJAHOIR;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid LLUHWVMMKZB;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid HPWGPXUXLJO;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid DJSVCOODOVN;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid CSERBOVKIDP;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid XNJTTYLCDFX;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid FNOZVITRUTG;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid KSZARIASMIG;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid UVIUMZWCVFG;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid LRVMHAIALRD;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid PXPNWHMLHUN;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid BOOOIVIDQCL;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid DBGMRGSKUFH;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid PHQFAQTQFJY;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid IIEPKATBNXM;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid CGMKCAEMOUK;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid YNNYTRIASZZ;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid FBKWIEFESZB;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid JTNJYUOWWIE;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid CJPDBWRTVWG;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid VYRQQMFQEYF;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid UCOSXDMFKSN;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid TXUQOXAAKOE;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid ODBNGSAZOAJ;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid RYIYVBSZFNW;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid PQSREXDEPAV;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid OTTSLEGLWBJ;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid WFFBLEUXXUR;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid NGKGMEHJRNW;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid GEGQYBMZQBK;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid LFDEADHCKGW;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid DMSRMJGTZAL;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid YYOJYQTEAHQ;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid LZTMCMMVLDU;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid IDFTHNKVLSG;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid MNLEISNEZJE;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid IBPJUGEQYJP;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid EQYPIJBKPWR;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid XAGULKMQCQJ;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid OAGDCKFRJIJ;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid PNNTUVBVEXZ;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid BRAEHZKPFFH;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid NTCDTJFTGUW;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid WFMCCNYAIRQ;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid EELLNSZCKLJ;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid OKUKNVKLAWM;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid BOECOOYQEPS;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid QGHXJIZNDUQ;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid TNTRCFPDUMH;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid SNJIPBQFJHF;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid FXYEPEJMQKS;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid VNPEYKPQBBS;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid LJBBAPDHPFY;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid POXSCTSVMQQ;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid QZARLKOCLAP;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid VJYDTIAZUKF;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid XCBFHDTTUOI;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid EXIJBALIERC;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid MFURPBBKDOW;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid YKWFTUKSHRS;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid USYVLQOHHIB;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid WIMKZRFCMIB;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid XXCIGHGMEYV;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid YYRLAMVMQRO;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid OPPTWQTDOLE;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid ZYJPOXZJXDJ;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid IIDSNNZZPWD;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid AZYZWYIKVYU;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid BKTRABNVBZC;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid NWLEVVWOTTD;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid WNJWRSKQMFM;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid ETRXLJATAHA;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid YNKUKLGYJCF;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid PKPWTVRJHRU;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid YNCLFLOTVDS;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid DTLHAXCSSFB;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid LYHIBVGQZZY;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid NAYMERNHRLT;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid NQSPJFLRBSQ;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid HIYBTQNNAAU;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid SSFCYHXNFWS;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid SSUIGOFLOKE;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid SGNDISCHEHH;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid CHRMHLFSRHL;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid NUGRVINNCQC;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid XKJFJJMLJIZ;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid QMCLTVUIXRJ;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid TWMMHKWJTGH;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid TFDQYIDHOQY;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid ULBESMSNLYT;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid FFCLTIFYBCQ;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid SZJKNVSKOEV;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid EYGNPHWBLGY;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid RAHKHXBCACS;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid XJNSEPLPOFB;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid HSKQDTLFVYJ;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid KZNDDTLOPSH;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid OGVIOQUKLWX;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid UAXZFAUFFJH;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid BBLFBAUHIRY;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid JWNDJCKRTOL;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid EDIGZCEMPGU;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid FCIXWBEIXNR;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid XJCFQIAWEWE;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid KLAIEOEKWPT;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid JZGPWTAXDHU;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid GJNFXKHQEIP;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid UIZBUKIDLLO;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid TFIFZOIDKYL;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid ZEDLHDWKIRA;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid HPTDJYHFWUU;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid NUQMZTHTILL;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid OVSLEHQZALY;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid KMGHMZPZVOT;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid TXCCLWFIZLW;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid GJKPGEFNXHY;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid NOMQWHEJPVU;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid PVYCBTJTQFC;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid FZSCAQKZILT;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid JOJAWAZNZYT;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid WHYYSYQDTLM;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid JTMACVILJEH;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid NBWSJMLOZAC;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid UUMKXSMXSEA;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid FUVDBCJAPLQ;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid MVRSOKQSSQM;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid MBSLCSXIHVF;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid GEXNKIFASQQ;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid KPKHXXLZHIZ;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid KUNYSVTEZGZ;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid FFSESMITLHQ;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid GQYMPHBGCZY;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid BSGZEIPXNSX;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid CQSGNCFSLCZ;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid WUDHBGSODCR;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid ZDXLQAZDGSU;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid KAHTEYZFABJ;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid MEOKKDSDRLO;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid OQQVUOJESLM;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid LQHKIQWYYOX;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid LOKPTAKNREZ;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid PRWDABPYRJH;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid VOGOIFHNBKC;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid ZSGRJFBQWNV;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid MJQZAMGWPHV;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid JYWVPYUFFMF;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid FGGPWQZVOLV;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid VVMKPMYBVDF;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid QMMGGILKSUE;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid PHCRDRRSOGQ;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid GSIPCUSNSNT;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid GFKXWAOBANF;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid GRSULAKVQFS;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid GRYBIHESZRB;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid GRIGQMXAXJA;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid GRNNNTQYGUJ;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid GQXSVZJGEMI;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid GRCZTGDDNXR;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid GTTLJQBVGPE;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid GTYSGWVSQAN;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid YJUMDOVMWDJ;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid CWWWYHDWBTT;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid FNBGPCZBNEE;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid TTOAMXTCJLK;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid MAYFMMJWTCA;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid QJKFGLUVLKY;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid XBYTLIIFRDL;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid QHVSDMWLUCN;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid QRJKGBICGXC;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid EHWCQNWGSHA;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid XTGXAUTYHYP;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid VBGYALHTQTJ;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid STDLZPMVCJR;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid CBIMONFNBKU;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid IZTTLWTGEHJ;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid LEONLYUOTWJ;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid TKHCUSSNJNK;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid QUVRHFKAPTS;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid KRCZIVQMBAS;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid CYVZVDKPYQM;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid GHTVMQJTHAB;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid HAOKBIABIBQ;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid GZYPJNSJFTP;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid NGQBJRQNNQN;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid BVIYFFUNYRA;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid UOTNNXCYQUZ;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid AVLDNCQDVCA;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid UVWQOYSDXCG;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid EDSNBQUMWFT;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid DMNYZRWYLGP;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid WRCKWIFYVIR;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid FAXIVYGEDVT;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid TTSFJDDMMDN;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid JLIZXGKMATG;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid BAPQVQNJYHX;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid DQKGCNKXJXR;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid MBHGUPMOPDC;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid QTICHJNXKKR;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid HSOKSRXGIPI;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid HSFSNPDFEIZ;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid MESGCUSXCXH;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid SLHQXHKJLFA;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid NTEVPSRHORL;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid KDVGDQDGJTV;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid OXIIBNIWYBF;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid SKNAHNNEXNR;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid EFISXGNCQKK;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid WHTDHWFDGFQ;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid YGCEKBYXXMW;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid RFTPMRGTTHY;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid GKZCAWJFRGQ;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid URCTQDKOLFG;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid LNGBRXFUPWB;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid HRCNODDCUUG;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid IXYZXQEFZYS;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid UOJIQQHQXSR;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid PMLJVLMFESD;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid KQWMOMNZVDG;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid BXNWPQRPTVH;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid ATXXPICVPMM;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid PBQCWCEZRNG;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid DYACVVXGHKF;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid ROMKAFOHFEJ;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid OZTQSPNAUIH;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid DCYZOTJHJDV;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid DJAFZZGHQVR;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid GQQCMSPDMLG;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid GLKEUSQULBQ;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid HNJTYZZJNUJ;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid HITBESSIIBI;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid RRXOSIOQFGN;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid ZTNEPVJYOEO;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid ZQCOLOPBCCX;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid ONJJGBNFKIK;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid KXVQZGQPDNH;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid NLPADOJCKVK;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid OSHARZCTJDK;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid LVMVEPRGLXV;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid SYMROEWPCPP;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid BUSMGCYNWHR;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid IKCUJPOSSGU;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid ZGWDPJHILIX;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid KIRSKEJUZMU;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid UKPBKWVQILQ;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid WIVPLYELSYF;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid XNZTJQYNDML;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid XNUMMKEPUBC;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid RDVXEJMSDVQ;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid ASNXCMXZRFS;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid VKWZORISRDZ;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid ULVPKNMKCNZ;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid UHVQMLIUHTJ;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid OWUGGXXGLXM;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid IJVBVUXHICZ;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid DIWNJPBNMMC;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid ANLHKFGIJXZ;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid AVGEMDVDXUJ;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid GUMKUMANRPY;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid VIROPLNUPXR;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid DYUOMYZDCXR;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid RETOCPVLJVV;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid GYRATFMMZQW;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid ZVTXBDLKIFY;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid WCALRJOHDLF;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid VZBQKLJQGRR;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid AJPGMQRZKKQ;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid IKOPAQYNVIW;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid AXDDUUHINVX;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid OPNREZTZFGP;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid NERTCXJVJQN;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid OQSEZFXBPRB;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid ZYWFQDAPTOV;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid SYGVAMIVJJY;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid ZAUCVQYTEWG;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid YFKPQRFZKVV;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid OQOMXZPKXVY;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid PGJJNRDMKFO;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid HROYITLXQQD;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid ZLMSGDZALJQ;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid CAEAUZKMVRX;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid EIMFWPIZQXB;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid MFMQGWOSAYQ;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid RDOHLQSCNCC;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid LQGHVUHDSHG;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid ZZATKXDZDLE;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid WNLFNDWPYFA;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid NDRZODZMIVI;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid SBVNJEQBWHF;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid CXKXYYVNTOO;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid JEKIZCPEGTB;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid GKLNKVYQSUT;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid IOPQLRHZSLP;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid WWWDQSISOIJ;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid LVFSXVSVTNY;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid DCNETJZPQKD;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid NVCUEWYROHU;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid HQWBFCTNHGI;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid HRLVWXBFJOJ;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid HRGOZQHIADA;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid YAEXQLIUSJJ;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid FHZVYIZMREX;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid FIFCVPTKAQG;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid ESKLXEHOXXK;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid OJUHUIUEIUO;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid FGFFDMSSWOQ;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid APYIAPHJSJT;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid HZHWAYLESQU;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid ABFBKPMWPYO;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid PLDOHJRGNTF;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid ROCJHPYLBDB;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid UXAQAQHPULY;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid YJZYYPZICQY;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid RMPVEKPSNGG;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid DDOREASQROI;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid SCGAZMZDADH;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid DPQYFLNLUJZ;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid HIHDUZXHCYG;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid JLPHRNIXPLG;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid QXDDALJUFMJ;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid KDNDZTITLJC;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid TNCBIOJIUEI;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid HVRIYJXZNEC;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid QARFIXABLRU;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid ETEGBHXMDVL;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid XQJJPNNPNIE;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid SVZWVAWFQQX;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid FFCFBPKDRAJ;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid VXLDENRFNGH;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid UQIVXOWWRXA;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid PBGHYMSVAVU;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid BKKZQGPKVMY;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid UFPOUFDQDCK;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid LGALCYYUFCS;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid ZHQBBCZBTKI;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid KELRJGQLPDC;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid HFEMSTJIYEV;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid OIIBUJECZWO;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid EJMIEOAHICS;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid PZEQFHQIOMT;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid UWNXDECQNVK;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid WTEWLZYNHXS;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid HVGLLBFTFCW;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid FYMLXJNEVQK;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid KCMVIYAGTWM;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid GERGDDGWKUG;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid LGGCLFHRVZB;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid DXMOKBYIRPQ;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid ZUSODYYIZJM;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid JLRKRLDGINI;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid CGVAOUOIPFN;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid QFYQDXWRZMF;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid HEDLWJGZZRR;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid GYOPLVRFNAA;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid JCPJUAWRWWT;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid KNKDFAMFCAI;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid UCLZIARNGPX;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid EFRKKOQERSO;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid NEYTWPYFVEO;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid GDJRSKEDMNK;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid DHAQXSZOLGR;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid TTDAEHJHHTS;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid BELTLYRRNHM;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid RRDJBCPDETF;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid FSMKDYYPDFF;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid LPYQCHQPORM;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid BWGKCQQZGTV;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid INNKDJLAQNW;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid KDCWKGLNIPZ;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid CHBTFFEBDMQ;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid NFYXVYIZYMQ;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid BULTKOVYXXZ;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid JCXWCIBFXXX;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid CQHMSSWCYTO;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid VMJSHAMFGCB;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public static readonly Guid GPRNPAQZQIV;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public static readonly Guid KYABBBSGHCS;

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public static readonly Guid TZXQDMBHVJN;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public static readonly Guid SYGFWHWIQRA;

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public static readonly Guid DCQPKIUXGBK;

		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public static readonly Guid RHMVXADGYDR;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public static readonly Guid JUVHPPZOHQT;

		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public static readonly Guid LFOWBVSHNMA;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Dictionary<Guid, SpawnableToolType> OMYIDNXRHIM;

		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private static readonly Dictionary<SpawnableToolType, Guid> SQLTEIPEYRK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> EQFIOLIVLVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x979BB50", Offset = "0x979A950", VA = "0x18979BB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> FKFVNZKGXNF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x979BBB0", Offset = "0x979A9B0", VA = "0x18979BBB0")]
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
	public static class ILGIANVJVMU
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9796D90", Offset = "0x9795B90", VA = "0x189796D90")]
		public static bool QSPUGXFKBBU(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9796980", Offset = "0x9795780", VA = "0x189796980")]
		private static bool QSPUGXFKBBU(SCPBEECOAOZ a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface QOGUOSZKYHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(GFWAESAKTBS data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, LUCIKMULRKE circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly JOTUAXHHOSV Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IEnumerable<PBCTZJZFZQR> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly IReadOnlyList<PBCTZJZFZQR> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly Id32<VFKNGTPUEMY> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly IReadOnlyList<Id128<MVBOYPURKWM>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JHNGEPODDGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x979C6A0", Offset = "0x979B4A0", VA = "0x18979C6A0")]
		public R1CreateTemplateParams(JOTUAXHHOSV circuits, IEnumerable<PBCTZJZFZQR> rootData, IReadOnlyList<PBCTZJZFZQR> allPersistableData, Id32<VFKNGTPUEMY> sourceGraphId, IReadOnlyList<Id128<MVBOYPURKWM>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public readonly JOTUAXHHOSV Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public readonly IReadOnlyList<PBCTZJZFZQR> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public readonly Id32<VFKNGTPUEMY> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public readonly IReadOnlyList<Id128<MVBOYPURKWM>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x979C710", Offset = "0x979B510", VA = "0x18979C710")]
		public R2CreateTemplateParams(JOTUAXHHOSV circuits, Id32<VFKNGTPUEMY> sourceGraphId, IReadOnlyList<Id128<MVBOYPURKWM>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<PBCTZJZFZQR> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PSUXQTTNTSE : HHVVIZHZCPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly Guid WAQFUVQBYTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Guid, Guid> EEVVFEZVAXH;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x63DFAF0", Offset = "0x63DE8F0", VA = "0x1863DFAF0")]
		private PSUXQTTNTSE(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x979C290", Offset = "0x979B090", VA = "0x18979C290")]
		public static PSUXQTTNTSE New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x979C550", Offset = "0x979B350", VA = "0x18979C550")]
		private static Dictionary<Guid, Guid> VDDMJKZXZQG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x979BD10", Offset = "0x979AB10", VA = "0x18979BD10")]
		public static PSUXQTTNTSE BJTYVYKLWNP(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x979BD20", Offset = "0x979AB20", VA = "0x18979BD20")]
		public static PSUXQTTNTSE BZBBRSDMKES(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x979C4E0", Offset = "0x979B2E0", VA = "0x18979C4E0")]
		public Dictionary<Guid, Guid> SUFGMSJXSHW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
		public Dictionary<Guid, Guid> OBDUCBKTIIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x979BC90", Offset = "0x979AA90", VA = "0x18979BC90")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x979C010", Offset = "0x979AE10", VA = "0x18979C010")]
		public void LRLGQRNFBDJ(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x979C390", Offset = "0x979B190", VA = "0x18979C390")]
		public Guid OWREJLDEVYT([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x979C600", Offset = "0x979B400", VA = "0x18979C600")]
		public Guid WWFSFTPJMDM([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x979C320", Offset = "0x979B120", VA = "0x18979C320")]
		public bool WJWWMGMQYBF([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x979C320", Offset = "0x979B120", VA = "0x18979C320", Slot = "4")]
		private bool OJYOWMBQTFX([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface LDNCFWPUYWY
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XRZZPXYBGVN(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MICLCVGKVRB(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface VSCBUVJOSPO
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
	public abstract class KKVWJROFUFI : LDNCFWPUYWY
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class XTAPOZHJLJR : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private string OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string ALEULOWHDAE
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public XTAPOZHJLJR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x979C780", Offset = "0x979B580", VA = "0x18979C780", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x979C840", Offset = "0x979B640", VA = "0x18979C840", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x979C880", Offset = "0x979B680", VA = "0x18979C880", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> RDNWMZXGDML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x979C880", Offset = "0x979B680", VA = "0x18979C880", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private Dictionary<string, HashSet<Guid>>? DLXALEXKRSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		protected Dictionary<string, string>? NQPJYMDVKKS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> OMFCDHDAIRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9796DC0", Offset = "0x9795BC0", VA = "0x189796DC0")]
			[IteratorStateMachine(typeof(XTAPOZHJLJR))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? TFEUZWSLWXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool IHENTAJXVSO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool WAIMQKRKCSL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> UPRMLZMOSIY(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool FGGNUAOIANG(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9796E20", Offset = "0x9795C20", VA = "0x189796E20")]
		public void JFCNRDWNFXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1025A60", Offset = "0x1024860", VA = "0x181025A60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9797550", Offset = "0x9796350", VA = "0x189797550", Slot = "4")]
		public bool XRZZPXYBGVN(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9797250", Offset = "0x9796050", VA = "0x189797250", Slot = "5")]
		public bool MICLCVGKVRB(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9797490", Offset = "0x9796290", VA = "0x189797490")]
		private bool VUAHSCSSCIZ(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9797320", Offset = "0x9796120", VA = "0x189797320")]
		protected List<Guid> PEUZAXPBRPO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected KKVWJROFUFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class HNUBHMKOIES
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class SFJDTQTBFER
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public JOTUAXHHOSV HTUJMSSOATJ;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public SFJDTQTBFER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x97ABA10", Offset = "0x97AA810", VA = "0x1897ABA10")]
			internal Id32<CELSXRFYLJZ> AFWHOCOTLTP((Id32<VFKNGTPUEMY> GraphId, Id32<MVBOYPURKWM> NodeId) i)
			{
				return default(Id32<CELSXRFYLJZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const int FWAFJQWGKGZ = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private readonly Dictionary<Id32<CELSXRFYLJZ>, JOPWRRTPNQL> KLHTLLPFUJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private long VVPXRDNAITZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private long STKNSLDCHXE;

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly ReadOnlyIdArray<CELSXRFYLJZ, int?> XDAWKDLBFQF;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly long NUXMGBGTDXN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long GLSSWDIBGFT
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9789250", Offset = "0x9788050", VA = "0x189789250")]
		public static HNUBHMKOIES WIXNWAHXINJ(JOTUAXHHOSV a, Id128<VFKNGTPUEMY> b, [Optional] HNUBHMKOIES c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9788EB0", Offset = "0x9787CB0", VA = "0x189788EB0")]
		public static (long, long) OPGKTWKKNIX(JOTUAXHHOSV a, Id32<VFKNGTPUEMY> b, Id32<MVBOYPURKWM> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9788D80", Offset = "0x9787B80", VA = "0x189788D80")]
		public static long LHQNQLVCPVO([In] ReadOnlySpan<Id32<CELSXRFYLJZ>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9789790", Offset = "0x9788590", VA = "0x189789790")]
		private static long YWIZOBQJGWN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9796900", Offset = "0x9795700", VA = "0x189796900")]
		public HNUBHMKOIES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class JOPWRRTPNQL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xE7DCE0", Offset = "0xE7CAE0", VA = "0x180E7DCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long WVXWECXFOOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xDDD2F0", Offset = "0xDDC0F0", VA = "0x180DDD2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x92A5150", Offset = "0x92A3F50", VA = "0x1892A5150")]
		public JOPWRRTPNQL(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class FGAZRIQDUDZ
	{
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public static readonly HashSet<SpawnableToolType> MGFQESJJKSS;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class NBSZUPYMIGQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class UZKBJVQOIVZ : IEnumerable<PBCTZJZFZQR>, IEnumerable, IEnumerator<PBCTZJZFZQR>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			private PBCTZJZFZQR OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private SpawnableTemplateData JLPYCXUSVWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public SpawnableTemplateData RRIGUJCMCRR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private SpawnTemplateParams ELNUHKKZHLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public SpawnTemplateParams OCYNMQTUJEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private int GQKQQFHGMTL;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private PBCTZJZFZQR GBUGRRFKEZG
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public UZKBJVQOIVZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x97ACC40", Offset = "0x97ABA40", VA = "0x1897ACC40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x97ACD50", Offset = "0x97ABB50", VA = "0x1897ACD50", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x97ACAE0", Offset = "0x97AB8E0", VA = "0x1897ACAE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PBCTZJZFZQR> IFPJROJVZID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x97ACAE0", Offset = "0x97AB8E0", VA = "0x1897ACAE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x97A1450", Offset = "0x97A0250", VA = "0x1897A1450")]
		public static SpawnableTemplateData NGOTMNYEFVZ([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x97A15E0", Offset = "0x97A03E0", VA = "0x1897A15E0")]
		public static SpawnableTemplateData NGOTMNYEFVZ([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x97A0470", Offset = "0x979F270", VA = "0x1897A0470")]
		private static HashSet<Id128<AUVZLDEFMDS>> BSDEGTLNITT(IReadOnlyList<PBCTZJZFZQR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x97A3080", Offset = "0x97A1E80", VA = "0x1897A3080")]
		private static void SZSLJLEHDAO(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x97A1A60", Offset = "0x97A0860", VA = "0x1897A1A60")]
		public static Result<PSUXQTTNTSE, TryCloneTemplateError> RJKKQFKFGGZ(SpawnableTemplateData a, SpawnTemplateParams b, PSUXQTTNTSE? srcRemapper, bool c)
		{
			return default(Result<PSUXQTTNTSE, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x97A0810", Offset = "0x979F610", VA = "0x1897A0810")]
		[IteratorStateMachine(typeof(UZKBJVQOIVZ))]
		private static IEnumerable<PBCTZJZFZQR> ESYTONKAGXM(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x97A3710", Offset = "0x97A2510", VA = "0x1897A3710")]
		private static void UHIQTBKAYVP(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x97A0920", Offset = "0x979F720", VA = "0x1897A0920")]
		private static bool FLTREFYHZQA(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x97A1770", Offset = "0x97A0570", VA = "0x1897A1770")]
		private static Dictionary<Guid, SCPBEECOAOZ> QGCTPUBRLUI(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x97A3A10", Offset = "0x97A2810", VA = "0x1897A3A10")]
		private static void YSIEWOJXYQK(bool a, PBCTZJZFZQR b, PSUXQTTNTSE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x97A3780", Offset = "0x97A2580", VA = "0x1897A3780")]
		private static void YIZHAJFSXHM(PBCTZJZFZQR a, Guid b, SpawnTransformData? c, Dictionary<Guid, SCPBEECOAOZ> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x97A0FA0", Offset = "0x979FDA0", VA = "0x1897A0FA0")]
		private static void KDJOZKEONMD(IEnumerable<PBCTZJZFZQR> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
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
		public JOTUAXHHOSV circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public VSCBUVJOSPO roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public QOGUOSZKYHG circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public Id128<VFKNGTPUEMY> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public VECMIZPXZIC globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public List<PBCTZJZFZQR> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public LGGUNXCZUFK photonIdToPersistenceViewIdProvider;
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
		public Matrix4x4 DSEFIPJTYMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x97ABB50", Offset = "0x97AA950", VA = "0x1897ABB50")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS XHBWZPAFLDE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x97AC180", Offset = "0x97AAF80", VA = "0x1897AC180")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16BEA40", Offset = "0x16BD840", VA = "0x1816BEA40")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x97AC250", Offset = "0x97AB050", VA = "0x1897AC250")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x97ABE70", Offset = "0x97AAC70", VA = "0x1897ABE70")]
		public static SpawnTransformData PIKEDYRYMCU(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x97AC320", Offset = "0x97AB120", VA = "0x1897AC320")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x97AC340", Offset = "0x97AB140", VA = "0x1897AC340")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x97AC0F0", Offset = "0x97AAEF0", VA = "0x1897AC0F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x97ABC60", Offset = "0x97AAA60", VA = "0x1897ABC60")]
		public SpawnTransformData OLPMSEMTVWS(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x97ABAE0", Offset = "0x97AA8E0", VA = "0x1897ABAE0")]
		public static SpawnTransformData DXWFCTQZNSG(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x97AC1C0", Offset = "0x97AAFC0", VA = "0x1897AC1C0")]
		public readonly CircuitsRigidTransform XPYPEKFQMTM()
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
		private readonly SEZYOHJZPUT _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x19870F0", Offset = "0x1985EF0", VA = "0x1819870F0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, SEZYOHJZPUT innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x97AC6C0", Offset = "0x97AB4C0", VA = "0x1897AC6C0")]
		public KTYXBBLRCBW YEWIHWUYVYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x97AC4A0", Offset = "0x97AB2A0", VA = "0x1897AC4A0")]
		public static Result<PSUXQTTNTSE, TryCloneTemplateError> New(VHZLZADBJAF<None> innerError)
		{
			return default(Result<PSUXQTTNTSE, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x97AC550", Offset = "0x97AB350", VA = "0x1897AC550")]
		public static Result<PSUXQTTNTSE, TryCloneTemplateError> New(KTYXBBLRCBW innerError)
		{
			return default(Result<PSUXQTTNTSE, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x97AC600", Offset = "0x97AB400", VA = "0x1897AC600")]
		public static Result<PSUXQTTNTSE, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<PSUXQTTNTSE, TryCloneTemplateError>);
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
	public class OSFXRWNOYMF : IDisposable, AZLKMPTKMDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private NativeList<CurvePointData> XPLMNRHHWLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float MRDJOWCJWDC;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags HEOPSLBTJHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCE8F30", Offset = "0xCE7D30", VA = "0x180CE8F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OEWOYJMGQHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x97A4E70", Offset = "0x97A3C70", VA = "0x1897A4E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MEAUXQPKGOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x97A3B00", Offset = "0x97A2900", VA = "0x1897A3B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> XSYJADAXDMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int PHKVXFMHLZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x97A3B10", Offset = "0x97A2910", VA = "0x1897A3B10", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float BTTQUBXYKUB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x97A43C0", Offset = "0x97A31C0", VA = "0x1897A43C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x97A6450", Offset = "0x97A5250", VA = "0x1897A6450")]
		public OSFXRWNOYMF(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x97A4360", Offset = "0x97A3160", VA = "0x1897A4360", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x97A4500", Offset = "0x97A3300", VA = "0x1897A4500")]
		public Vector3 EYMBOVELGWA(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x97A5760", Offset = "0x97A4560", VA = "0x1897A5760", Slot = "6")]
		public Quaternion RQCKRCHURUB(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x97A49D0", Offset = "0x97A37D0", VA = "0x1897A49D0", Slot = "5")]
		public Vector3 GWQPQYUJYKE(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x97A6150", Offset = "0x97A4F50", VA = "0x1897A6150", Slot = "7")]
		public float VSWPMEUJIPD(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x97A4E80", Offset = "0x97A3C80", VA = "0x1897A4E80")]
		public void QGJRSGAUWZN(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x97A3AA0", Offset = "0x97A28A0", VA = "0x1897A3AA0")]
		private bool ARFXAHFOCNB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x97A5890", Offset = "0x97A4690", VA = "0x1897A5890")]
		public void SCNYEPHSXQV(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x97A6210", Offset = "0x97A5010", VA = "0x1897A6210")]
		public void ZNFYQYTULJO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x97A4BD0", Offset = "0x97A39D0", VA = "0x1897A4BD0")]
		public void LJQDBCZUPHD(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x97A62A0", Offset = "0x97A50A0", VA = "0x1897A62A0")]
		public void ZXOSUMDWYIJ(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x97A4D20", Offset = "0x97A3B20", VA = "0x1897A4D20")]
		public void MNHPYGBBTPB(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x97A4A70", Offset = "0x97A3870", VA = "0x1897A4A70")]
		public void KDUZQJECEDI(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x97A3B50", Offset = "0x97A2950", VA = "0x1897A3B50")]
		public static Quaternion DRSFILQMOOU(Quaternion a, int b, float c, AZLKMPTKMDC d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x97A59F0", Offset = "0x97A47F0", VA = "0x1897A59F0")]
		public Bounds TICHHSONOJC(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x97A61B0", Offset = "0x97A4FB0", VA = "0x1897A61B0", Slot = "10")]
		public virtual void XWVHKOUIPHS(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x97A60A0", Offset = "0x97A4EA0", VA = "0x1897A60A0")]
		public NativeList<CurvePointData> VGVHTXOZEEI(float a = 1f)
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
		[Cpp2IlInjected.Address(RVA = "0x979F0F0", Offset = "0x979DEF0", VA = "0x18979F0F0")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x979EE90", Offset = "0x979DC90", VA = "0x18979EE90")]
		public Quaternion CJBULQZDJPD(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x979EBA0", Offset = "0x979D9A0", VA = "0x18979EBA0")]
		public CurvePoint BDWJSPSNYCB(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x979EF50", Offset = "0x979DD50", VA = "0x18979EF50")]
		public FFBMFZKXNAA GFJMWJLLGQZ(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class BBABTHLNHPU : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x979DA50", Offset = "0x979C850", VA = "0x18979DA50", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x979DDB0", Offset = "0x979CBB0", VA = "0x18979DDB0")]
		private void PTEWVZFCXTT(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x979DAD0", Offset = "0x979C8D0", VA = "0x18979DAD0")]
		private void PTEWVZFCXTT(Dictionary<Guid, Guid> a, AHTBKILDYLI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x979DB30", Offset = "0x979C930", VA = "0x18979DB30")]
		private void PTEWVZFCXTT(Dictionary<Guid, Guid> a, IJUBKEYABSD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public BBABTHLNHPU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class VVLRNJFXYRZ : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x97AE200", Offset = "0x97AD000", VA = "0x1897AE200", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public VVLRNJFXYRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class VIVUGAPMONS : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x97AE0A0", Offset = "0x97ACEA0", VA = "0x1897AE0A0", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public VIVUGAPMONS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class XBNTGATSQWC : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x97AE2B0", Offset = "0x97AD0B0", VA = "0x1897AE2B0", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public XBNTGATSQWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class KMPAFZSHNKM : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x979FFB0", Offset = "0x979EDB0", VA = "0x18979FFB0", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public KMPAFZSHNKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class DVQARVXZEYN : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x979F300", Offset = "0x979E100", VA = "0x18979F300", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public DVQARVXZEYN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class YFVJBREYGOT : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x97AE410", Offset = "0x97AD210", VA = "0x1897AE410", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public YFVJBREYGOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class KNFVWWNPWFG : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x97A01D0", Offset = "0x979EFD0", VA = "0x1897A01D0", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public KNFVWWNPWFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class HBRKSAWOFSO : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x979F650", Offset = "0x979E450", VA = "0x18979F650", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public HBRKSAWOFSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class UASTADCNRCO : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x97AC920", Offset = "0x97AB720", VA = "0x1897AC920", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public UASTADCNRCO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class BMLVIATKXBU : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x979E380", Offset = "0x979D180", VA = "0x18979E380", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public BMLVIATKXBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class VALOATPCCEF : NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public static readonly ZNKNTDLJNFV JBOJCAGWOHI;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x97ADF70", Offset = "0x97ACD70", VA = "0x1897ADF70", Slot = "4")]
		public void FUBJTEBXFIM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public VALOATPCCEF()
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
		public LGGUNXCZUFK photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface NAUBONETRBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FUBJTEBXFIM(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class APKYUTAGNNA
	{
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly NAUBONETRBL[] JRMTEOBWQEG;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x979CF70", Offset = "0x979BD70", VA = "0x18979CF70")]
		public static void SICCVFCAKNJ(PBCTZJZFZQR a, PSUXQTTNTSE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x979D1F0", Offset = "0x979BFF0", VA = "0x18979D1F0")]
		public static void YJRVLABPWJZ(PBCTZJZFZQR? data, PSUXQTTNTSE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x979C910", Offset = "0x979B710", VA = "0x18979C910")]
		public static void KNJDWNJCKEN(PBCTZJZFZQR? data, PSUXQTTNTSE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x979CB80", Offset = "0x979B980", VA = "0x18979CB80")]
		public static void QSPUGXFKBBU(PersistableCloneParams a)
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
		public PBCTZJZFZQR viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x97A64D0", Offset = "0x97A52D0", VA = "0x1897A64D0")]
		public Guid DQDZLZEGXRO(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface LGGUNXCZUFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly HashSet<Guid> VRZIOVHQQRB;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly HashSet<Guid> GDUAIBTBNER;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly HashSet<Guid> CLKYDYGSFQV;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private static readonly ProfilerMarker UYRKRUUGGOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private readonly HashSet<string> SNWMFHOBWDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private readonly Dictionary<long, int> DBFSVPJOSIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private readonly HashSet<Guid> JMCWSPTTCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private readonly HashSet<Guid> SQQBXJXLGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private readonly HashSet<Guid> UUXPNUBZJXP;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> QPGGOUXHZGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> FIZPEMQJKBX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> GTLGOXONECL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> QCGUVIIVJGV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x97A9450", Offset = "0x97A8250", VA = "0x1897A9450")]
		public static void ZNPQQOMKYDT(SpawnableTemplateData a, COAEGJGWGDV b, PSUXQTTNTSE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x97A6E20", Offset = "0x97A5C20", VA = "0x1897A6E20")]
		public static PersistedRoomDataReferences FDAMHWXRCCJ(PersistedRoomData a, COAEGJGWGDV? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x97A8F80", Offset = "0x97A7D80", VA = "0x1897A8F80")]
		public static PersistedRoomDataReferences UYIWZHAHXGO(SpawnableTemplateData a, COAEGJGWGDV? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x97A6580", Offset = "0x97A5380", VA = "0x1897A6580")]
		public static PersistedRoomDataReferences APNXYFMNKCQ(XXNMIZBSSLG a, DLEBFLADMAU b, COAEGJGWGDV? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x97A8980", Offset = "0x97A7780", VA = "0x1897A8980")]
		public static PersistedRoomDataReferences KYRURAJLFBP(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x97AB070", Offset = "0x97A9E70", VA = "0x1897AB070")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x97AAEA0", Offset = "0x97A9CA0", VA = "0x1897AAEA0")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x97A7F00", Offset = "0x97A6D00", VA = "0x1897A7F00")]
		private void GWXSXEMUREY(PersistedRoomData a, COAEGJGWGDV? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x97A6F20", Offset = "0x97A5D20", VA = "0x1897A6F20")]
		private void GWXSXEMUREY(SpawnableTemplateData a, COAEGJGWGDV? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x97A6880", Offset = "0x97A5680", VA = "0x1897A6880")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x97A7530", Offset = "0x97A6330", VA = "0x1897A7530")]
		private void GWXSXEMUREY(XXNMIZBSSLG? a, COAEGJGWGDV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x97A6EA0", Offset = "0x97A5CA0", VA = "0x1897A6EA0")]
		private void GWXSXEMUREY(DLEBFLADMAU? a, COAEGJGWGDV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x97A81A0", Offset = "0x97A6FA0", VA = "0x1897A81A0")]
		private void GWXSXEMUREY(LORVUGTDNRC? a, COAEGJGWGDV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x97A8780", Offset = "0x97A7580", VA = "0x1897A8780")]
		private static bool KULYMGVZXID(LORVUGTDNRC a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x97A6640", Offset = "0x97A5440", VA = "0x1897A6640")]
		private static bool ESNIFJSYHHH(LORVUGTDNRC a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x97AAA80", Offset = "0x97A9880", VA = "0x1897AAA80")]
		private static void ZNPQQOMKYDT(DLEBFLADMAU? root, COAEGJGWGDV a, PSUXQTTNTSE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x97AA1A0", Offset = "0x97A8FA0", VA = "0x1897AA1A0")]
		private static void ZNPQQOMKYDT(LORVUGTDNRC? customProperties, COAEGJGWGDV a, PSUXQTTNTSE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x97A9E30", Offset = "0x97A8C30", VA = "0x1897A9E30")]
		private static void ZNPQQOMKYDT(XXNMIZBSSLG? root, COAEGJGWGDV a, PSUXQTTNTSE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x97AA430", Offset = "0x97A9230", VA = "0x1897AA430")]
		private static void ZNPQQOMKYDT(CircuitsV2.Protobuf.CircuitNodeData? node, COAEGJGWGDV a, PSUXQTTNTSE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x97A71B0", Offset = "0x97A5FB0", VA = "0x1897A71B0")]
		private void GWXSXEMUREY(CircuitsV2.Protobuf.CircuitNodeData? a, COAEGJGWGDV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x97A8B80", Offset = "0x97A7980", VA = "0x1897A8B80")]
		private void MTZJJOFDPCE(Guid? a, COAEGJGWGDV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x97A8380", Offset = "0x97A7180", VA = "0x1897A8380")]
		private void GWXSXEMUREY(PBCTZJZFZQR? a, COAEGJGWGDV? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x97A9000", Offset = "0x97A7E00", VA = "0x1897A9000")]
		private static void ZNPQQOMKYDT(PBCTZJZFZQR? viewData, COAEGJGWGDV a, PSUXQTTNTSE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x97A8F10", Offset = "0x97A7D10", VA = "0x1897A8F10")]
		private void SYBCOTLYHVX(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x97A8D90", Offset = "0x97A7B90", VA = "0x1897A8D90")]
		private void RXZNEUNMJVB(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x97A8EC0", Offset = "0x97A7CC0", VA = "0x1897A8EC0")]
		private void RXZNEUNMJVB(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x97A8E60", Offset = "0x97A7C60", VA = "0x1897A8E60")]
		private void RXZNEUNMJVB(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class BWYSXCHRJQW : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private readonly IEnumerator<DictionaryEntry> VDIUHASHHIX;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x979E600", Offset = "0x979D400", VA = "0x18979E600", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x979E6C0", Offset = "0x979D4C0", VA = "0x18979E6C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x979E770", Offset = "0x979D570", VA = "0x18979E770", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x979E520", Offset = "0x979D320", VA = "0x18979E520", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
			public BWYSXCHRJQW(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x979E480", Offset = "0x979D280", VA = "0x18979E480", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x979E4D0", Offset = "0x979D2D0", VA = "0x18979E4D0", Slot = "9")]
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
			private sealed class DQCGYTKVIJW : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				private int AKEYILDVZEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000594")]
				private DictionaryEntry OCEUOVLOMMW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000595")]
				public RoomObjectCounts XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry AJCJZLXDGTU
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object ELQJLQJBXAL
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x979F170", Offset = "0x979DF70", VA = "0x18979F170", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public DQCGYTKVIJW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
				[DebuggerHidden]
				private void QRJGYHJVBJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x979F1C0", Offset = "0x979DFC0", VA = "0x18979F1C0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x979F2C0", Offset = "0x979E0C0", VA = "0x18979F2C0", Slot = "8")]
				[DebuggerHidden]
				private void QWPEWWNKZVD()
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
			private ICollection SXCEUXQUVGU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x97AB270", Offset = "0x97AA070", VA = "0x1897AB270", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x97AB5A0", Offset = "0x97AA3A0", VA = "0x1897AB5A0", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x97AB680", Offset = "0x97AA480", VA = "0x1897AB680", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool AANUMDDQZGL
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x97AB490", Offset = "0x97AA290", VA = "0x1897AB490", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool EFVIMCIIICC
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x97AB440", Offset = "0x97AA240", VA = "0x1897AB440", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection MRUHFKSSAIG
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x97AB3A0", Offset = "0x97AA1A0", VA = "0x1897AB3A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int RMZVOKHVIAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x97AB220", Offset = "0x97AA020", VA = "0x1897AB220", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool OCRVKPQDIJY
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x97AB300", Offset = "0x97AA100", VA = "0x1897AB300", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object CJDYXIEELUP
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x97AB350", Offset = "0x97AA150", VA = "0x1897AB350", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x97AB4E0", Offset = "0x97AA2E0", VA = "0x1897AB4E0")]
			[IteratorStateMachine(typeof(DQCGYTKVIJW))]
			private IEnumerator<DictionaryEntry> QJWCSYZYTTV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x97AB6C0", Offset = "0x97AA4C0", VA = "0x1897AB6C0", Slot = "19")]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x97AB800", Offset = "0x97AA600", VA = "0x1897AB800", Slot = "13")]
			private IDictionaryEnumerator ZPAPQSWHNPM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x97AB7B0", Offset = "0x97AA5B0", VA = "0x1897AB7B0", Slot = "9")]
			private void ZEQQXUTEZQP(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x97AB3F0", Offset = "0x97AA1F0", VA = "0x1897AB3F0", Slot = "10")]
			private void NJRJMJJYVSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x97AB760", Offset = "0x97AA560", VA = "0x1897AB760", Slot = "8")]
			private bool YUMUHWQDCON(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x97AB1D0", Offset = "0x97A9FD0", VA = "0x1897AB1D0", Slot = "14")]
			private void EQXCVYHTXDW(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x97AB550", Offset = "0x97AA350", VA = "0x1897AB550", Slot = "15")]
			private void RKDGGXEKOKU(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class MUONRMUOCVW : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000599")]
				private int AKEYILDVZEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400059A")]
				private DictionaryEntry OCEUOVLOMMW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400059B")]
				public Invention XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry AJCJZLXDGTU
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object ELQJLQJBXAL
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x97A02C0", Offset = "0x979F0C0", VA = "0x1897A02C0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public MUONRMUOCVW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
				[DebuggerHidden]
				private void QRJGYHJVBJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x97A0310", Offset = "0x979F110", VA = "0x1897A0310", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x97A0430", Offset = "0x979F230", VA = "0x1897A0430", Slot = "8")]
				[DebuggerHidden]
				private void QWPEWWNKZVD()
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
			private ICollection SXCEUXQUVGU
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x979F8B0", Offset = "0x979E6B0", VA = "0x18979F8B0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x979FB90", Offset = "0x979E990", VA = "0x18979FB90", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x979FCA0", Offset = "0x979EAA0", VA = "0x18979FCA0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool AANUMDDQZGL
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x979FA90", Offset = "0x979E890", VA = "0x18979FA90", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool EFVIMCIIICC
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x979FA40", Offset = "0x979E840", VA = "0x18979FA40", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection MRUHFKSSAIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x979F9A0", Offset = "0x979E7A0", VA = "0x18979F9A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int RMZVOKHVIAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x979F860", Offset = "0x979E660", VA = "0x18979F860", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool OCRVKPQDIJY
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x979F900", Offset = "0x979E700", VA = "0x18979F900", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object CJDYXIEELUP
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x979F950", Offset = "0x979E750", VA = "0x18979F950", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E450", Offset = "0x2B5D250", VA = "0x182B5E450")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x979FAE0", Offset = "0x979E8E0", VA = "0x18979FAE0")]
			[IteratorStateMachine(typeof(MUONRMUOCVW))]
			private IEnumerator<DictionaryEntry> QJWCSYZYTTV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x979FCE0", Offset = "0x979EAE0", VA = "0x18979FCE0", Slot = "19")]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x979FE10", Offset = "0x979EC10", VA = "0x18979FE10", Slot = "13")]
			private IDictionaryEnumerator ZPAPQSWHNPM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x979FDC0", Offset = "0x979EBC0", VA = "0x18979FDC0", Slot = "9")]
			private void ZEQQXUTEZQP(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x979F9F0", Offset = "0x979E7F0", VA = "0x18979F9F0", Slot = "10")]
			private void NJRJMJJYVSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x979FD70", Offset = "0x979EB70", VA = "0x18979FD70", Slot = "8")]
			private bool YUMUHWQDCON(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x979F810", Offset = "0x979E610", VA = "0x18979F810", Slot = "14")]
			private void EQXCVYHTXDW(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x979FB40", Offset = "0x979E940", VA = "0x18979FB40", Slot = "15")]
			private void RKDGGXEKOKU(Array a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x97ACD90", Offset = "0x97ABB90", VA = "0x1897ACD90")]
		public static UgcRoomSaveStatsDetailed FDAMHWXRCCJ(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x97AD760", Offset = "0x97AC560", VA = "0x1897AD760")]
		[CompilerGenerated]
		internal static int GEJFSGZFPJR([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x97AD880", Offset = "0x97AC680", VA = "0x1897AD880")]
		[CompilerGenerated]
		internal static void XKKYNHPIOEH(int a, [In] XXNMIZBSSLG graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
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
	public sealed class COAEGJGWGDV
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public readonly Guid COUQCAEDKUP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public readonly IReadOnlyList<Guid> FIZPEMQJKBX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public readonly UnitySubAssetKind DAPXUDJAJEL;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x97ADF10", Offset = "0x97ACD10", VA = "0x1897ADF10")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private readonly PSUXQTTNTSE SHWHFNCFKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private readonly Dictionary<Guid, UnitySubAsset> FAXGSPLLLDO;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public PSUXQTTNTSE RSKUWGVYZBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x979E820", Offset = "0x979D620", VA = "0x18979E820")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x979EA20", Offset = "0x979D820", VA = "0x18979EA20")]
		public bool LBCDWHMJRSE(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x979EB10", Offset = "0x979D910", VA = "0x18979EB10")]
		public COAEGJGWGDV()
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
