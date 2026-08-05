using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CNOOMCKGCHF
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
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Header("Scene")]
		public string SceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public string[] RequiredSubSceneNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public string[] LevelRoomSubSceneNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Header("Metadata")]
		public int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CNOOMCKGCHF ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool EmptyOnSandboxClone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public bool CustomizationAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public BBIIBENECPG SupportedGameMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GameTeamColorSettings GameTeamColorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public IPAJFKBAJFI RewardGiftContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int UgcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[HFNDOHMNDKN]
		public AHKCDLBPKNG LocationEnum;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83F9EA0", Offset = "0x83F8EA0", VA = "0x1883F9EA0")]
		public Location()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Room
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CNOOMCKGCHF ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public RoomScene[] Scenes;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public Room()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RoomScene
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string RoomSceneLocationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CNOOMCKGCHF ReleaseStatus;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83F9F50", Offset = "0x83F8F50", VA = "0x1883F9F50")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[HFNDOHMNDKN]
	public AHKCDLBPKNG[] LocationsExcludedFromBuild;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x83F8CD0", Offset = "0x83F7CD0", VA = "0x1883F8CD0")]
	public AGRoomRuntimeConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JGALNKBGAJI
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static AGRoomRuntimeConfig EBBFMAFDBDK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool NIJPHBDBLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83F9220", Offset = "0x83F8220", VA = "0x1883F9220")]
	public static bool GABHEHOIGGL(string NHHGKEDIJJG, [Out] AHKCDLBPKNG GIJNGCIEONA, [Out] int HLFJDEFDKAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x83F9030", Offset = "0x83F8030", VA = "0x1883F9030")]
	public static bool DOEEDEEEPIG(AHKCDLBPKNG GIJNGCIEONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83F98A0", Offset = "0x83F88A0", VA = "0x1883F98A0")]
	public static string INHAMBEEDOI(AHKCDLBPKNG GIJNGCIEONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83F8FD0", Offset = "0x83F7FD0", VA = "0x1883F8FD0")]
	public static string[] CLGKHGGNPLB(AHKCDLBPKNG GIJNGCIEONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83F9730", Offset = "0x83F8730", VA = "0x1883F9730")]
	public static int GNDAOCGEMPP(AHKCDLBPKNG GIJNGCIEONA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x83F9130", Offset = "0x83F8130", VA = "0x1883F9130")]
	public static string ECLIAFDDKEI(AHKCDLBPKNG GIJNGCIEONA, int OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x83F8DF0", Offset = "0x83F7DF0", VA = "0x1883F8DF0")]
	private static bool CHGHOOKOJLH(string IHBFCGEJCNB, [Out] AGRoomRuntimeConfig.Location JALGNENABHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83F9900", Offset = "0x83F8900", VA = "0x1883F9900")]
	public static bool KCMKHOFLICC(string IHBFCGEJCNB, [Out] AHKCDLBPKNG GIJNGCIEONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x83F9DC0", Offset = "0x83F8DC0", VA = "0x1883F9DC0")]
	public static int OEGECHPOKEL(AHKCDLBPKNG GIJNGCIEONA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x83F91C0", Offset = "0x83F81C0", VA = "0x1883F91C0")]
	public static string FEGIOLECNHA(AHKCDLBPKNG GIJNGCIEONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x83F9B20", Offset = "0x83F8B20", VA = "0x1883F9B20")]
	public static bool KGHPKPDDGMN(AHKCDLBPKNG GIJNGCIEONA, BBIIBENECPG CPGFNBONOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x83F9D40", Offset = "0x83F8D40", VA = "0x1883F9D40")]
	public static bool NAODDALFPDJ(AHKCDLBPKNG GIJNGCIEONA, [Out] GameTeamColorSettings KGBOBLHGBOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x83F90D0", Offset = "0x83F80D0", VA = "0x1883F90D0")]
	public static IPAJFKBAJFI EBAOHGNCCJD(AHKCDLBPKNG GIJNGCIEONA)
	{
		return default(IPAJFKBAJFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x83F9840", Offset = "0x83F8840", VA = "0x1883F9840")]
	public static bool HNJMBEJDHCB(AHKCDLBPKNG GIJNGCIEONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83F97A0", Offset = "0x83F87A0", VA = "0x1883F97A0")]
	public static bool HECIDHBAFKE(AHKCDLBPKNG GIJNGCIEONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x83F9E20", Offset = "0x83F8E20", VA = "0x1883F9E20")]
	public static int OGNCKMFBKCI(AHKCDLBPKNG GIJNGCIEONA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x83F9BA0", Offset = "0x83F8BA0", VA = "0x1883F9BA0")]
	public static AGRoomRuntimeConfig.Location LGPMANDOHGP(AHKCDLBPKNG GIJNGCIEONA)
	{
		return null;
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GameTeamColorSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool TeamOutfitColorEmissionEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float TeamOutfitColorEmissionAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TeamColor[] CustomTeamColors;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83F8D30", Offset = "0x83F7D30", VA = "0x1883F8D30")]
	public bool KNICAMBLOPI(DLCANLADEOI ONEPODNDDIJ, [Out] Color NGGKCKILBNF, bool HODEDOJCIDE = false)
	{
		return default(bool);
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct TeamColor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public DLCANLADEOI Team;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Color AlternateColor;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DLCANLADEOI
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TEAM_1 = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	TEAM_2 = 1,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	TEAM_3 = 2,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	TEAM_4 = 3,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	TEAM_5 = 4,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	TEAM_6 = 5,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	TEAM_7 = 6,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	TEAM_8 = 7,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TEAM_9 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	TEAM_10 = 9,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TEAM_11 = 10,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TEAM_12 = 11,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TEAM_13 = 12,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TEAM_14 = 13,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TEAM_15 = 14,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	TEAM_16 = 15,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	TEAM_17 = 16,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	TEAM_18 = 17,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	TEAM_19 = 18,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	TEAM_20 = 19,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	TEAM_21 = 20,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	TEAM_22 = 21,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	TEAM_23 = 22,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	TEAM_24 = 23,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	TEAM_25 = 24,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	TEAM_26 = 25,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	TEAM_27 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	TEAM_28 = 27,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	TEAM_29 = 28,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	TEAM_30 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	TEAM_31 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	TEAM_32 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	TEAM_33 = 32,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	TEAM_34 = 33,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	TEAM_35 = 34,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	TEAM_36 = 35,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	TEAM_37 = 36,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	TEAM_38 = 37,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	TEAM_39 = 38,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	TEAM_40 = 39,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ANY = -1,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	MAX_VALUE = 39
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum BBIIBENECPG
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	MODE_1,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	MODE_2,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	MODE_3,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	MODE_4,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	MODE_5,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	MODE_6,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	MODE_7,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	MODE_8,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	MODE_9,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
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
