using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NNIAOHONMPA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	EditorOnly,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	TestServersOnly,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ReleasedToProduction
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AGRoomRuntimeConfig : ScriptableObject
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Location
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Scene")]
		public string SceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public string[] RequiredSubSceneNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public string[] LevelRoomSubSceneNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[Header("Metadata")]
		public int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public NNIAOHONMPA ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public bool EmptyOnSandboxClone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool CustomizationAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public AJFEOCAFDGF SupportedGameMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public GameTeamColorSettings GameTeamColorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public FNEFDFLLFBO RewardGiftContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int UgcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[BJFFAJCDAAE]
		public LMOLJMDABJO LocationEnum;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F7EC70", Offset = "0x7F7E070", VA = "0x187F7EC70")]
		public Location()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Room
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NNIAOHONMPA ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public RoomScene[] Scenes;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public Room()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RoomScene
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string RoomSceneLocationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NNIAOHONMPA ReleaseStatus;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F7FCD0", Offset = "0x7F7F0D0", VA = "0x187F7FCD0")]
		public RoomScene()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	public Location[] Locations;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	public Room[] Rooms;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xAF7D80", Offset = "0xAF7180", VA = "0x180AF7D80")]
	public AGRoomRuntimeConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NLJCEHIJDDC
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static AGRoomRuntimeConfig PMIMDHPMIGH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool GENOEIJMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F7EF40", Offset = "0x7F7E340", VA = "0x187F7EF40")]
	public static bool BAPILGMJKJN(string CNIMAACIFLC, [Out] LMOLJMDABJO NGGDGEGELFB, [Out] int FIKGHMAAJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FC10", Offset = "0x7F7F010", VA = "0x187F7FC10")]
	public static string NJLPIIMAIAF(LMOLJMDABJO NGGDGEGELFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FB40", Offset = "0x7F7EF40", VA = "0x187F7FB40")]
	public static string[] MIJHPHOOBKF(LMOLJMDABJO NGGDGEGELFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FA70", Offset = "0x7F7EE70", VA = "0x187F7FA70")]
	public static int LHNAGMKKOCK(LMOLJMDABJO NGGDGEGELFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F9E0", Offset = "0x7F7EDE0", VA = "0x187F7F9E0")]
	public static string LBIABBLJNIL(LMOLJMDABJO NGGDGEGELFB, int KDCAMOIGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F4A0", Offset = "0x7F7E8A0", VA = "0x187F7F4A0")]
	private static bool CKNPDCHCDCC(string ICAMNCKAMGK, [Out] AGRoomRuntimeConfig.Location JEABEHHKCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F7ED20", Offset = "0x7F7E120", VA = "0x187F7ED20")]
	public static bool AGKGFKFFCHN(string ICAMNCKAMGK, [Out] LMOLJMDABJO NGGDGEGELFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F800", Offset = "0x7F7EC00", VA = "0x187F7F800")]
	public static int DNIEBHADAPG(LMOLJMDABJO NGGDGEGELFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F900", Offset = "0x7F7ED00", VA = "0x187F7F900")]
	public static string KFPFNJJKJHH(LMOLJMDABJO NGGDGEGELFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F960", Offset = "0x7F7ED60", VA = "0x187F7F960")]
	public static bool KKBJKPLDHAB(LMOLJMDABJO NGGDGEGELFB, AJFEOCAFDGF GIBAODGDMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F420", Offset = "0x7F7E820", VA = "0x187F7F420")]
	public static bool BHCMBEJPOEM(LMOLJMDABJO NGGDGEGELFB, [Out] GameTeamColorSettings FDDEHEMHPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FBA0", Offset = "0x7F7EFA0", VA = "0x187F7FBA0")]
	public static FNEFDFLLFBO NDJCOCNIGFB(LMOLJMDABJO NGGDGEGELFB)
	{
		return default(FNEFDFLLFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FAE0", Offset = "0x7F7EEE0", VA = "0x187F7FAE0")]
	public static bool LKGPGLCMNAC(LMOLJMDABJO NGGDGEGELFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F860", Offset = "0x7F7EC60", VA = "0x187F7F860")]
	public static bool EAFMBFINJFN(LMOLJMDABJO NGGDGEGELFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F7FC00", Offset = "0x7F7F000", VA = "0x187F7FC00")]
	public static int NGIHEJDFNKF(LMOLJMDABJO NGGDGEGELFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F7F670", Offset = "0x7F7EA70", VA = "0x187F7F670")]
	public static AGRoomRuntimeConfig.Location DIECEKFPKLJ(LMOLJMDABJO NGGDGEGELFB)
	{
		return null;
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GameTeamColorSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public bool TeamOutfitColorEmissionEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float TeamOutfitColorEmissionAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TeamColor[] CustomTeamColors;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F7EBB0", Offset = "0x7F7DFB0", VA = "0x187F7EBB0")]
	public bool JOFMFJHBBIP(NMBDOKAPHFA MHIOPACENKF, [Out] Color CKANMCILFBE, bool JHEDIMNLJOK = false)
	{
		return default(bool);
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct TeamColor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NMBDOKAPHFA Team;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Color AlternateColor;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NMBDOKAPHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	TEAM_1 = 0,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TEAM_2 = 1,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	TEAM_3 = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	TEAM_4 = 3,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	TEAM_5 = 4,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	TEAM_6 = 5,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	TEAM_7 = 6,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	TEAM_8 = 7,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	TEAM_9 = 8,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TEAM_10 = 9,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	TEAM_11 = 10,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TEAM_12 = 11,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TEAM_13 = 12,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TEAM_14 = 13,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TEAM_15 = 14,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TEAM_16 = 15,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	TEAM_17 = 16,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	TEAM_18 = 17,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	TEAM_19 = 18,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	TEAM_20 = 19,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	TEAM_21 = 20,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	TEAM_22 = 21,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	TEAM_23 = 22,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	TEAM_24 = 23,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	TEAM_25 = 24,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	TEAM_26 = 25,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	TEAM_27 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	TEAM_28 = 27,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	TEAM_29 = 28,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	TEAM_30 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	TEAM_31 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	TEAM_32 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	TEAM_33 = 32,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	TEAM_34 = 33,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	TEAM_35 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	TEAM_36 = 35,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	TEAM_37 = 36,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	TEAM_38 = 37,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	TEAM_39 = 38,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	TEAM_40 = 39,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	ANY = -1,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	MAX_VALUE = 39
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum AJFEOCAFDGF
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	MODE_1,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	MODE_2,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	MODE_3,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	MODE_4,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	MODE_5,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	MODE_6,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	MODE_7,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	MODE_8,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	MODE_9,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	MODE_10
}
namespace Cpp2IlInjected;

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
