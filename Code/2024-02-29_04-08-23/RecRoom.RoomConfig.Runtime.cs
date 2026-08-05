using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JLOCBDNBAJP
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
		public JLOCBDNBAJP ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public bool EmptyOnSandboxClone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool CustomizationAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public ELLBJEMJDGD SupportedGameMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public GameTeamColorSettings GameTeamColorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DGIAIJHLAKA RewardGiftContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[BLNDILPAAIH]
		public ACDLDEACLCB LocationEnum;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6578910", Offset = "0x6577710", VA = "0x186578910")]
		public Location()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Room
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JLOCBDNBAJP ReleaseStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public RoomScene[] Scenes;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public Room()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RoomScene
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public string ReplicationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string RoomSceneLocationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JLOCBDNBAJP ReleaseStatus;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x65799C0", Offset = "0x65787C0", VA = "0x1865799C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x831660", Offset = "0x830460", VA = "0x180831660")]
	public AGRoomRuntimeConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NDGOKLKOKAC
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static AGRoomRuntimeConfig OHALMGHFMEC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool AIGLCAPEALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65793E0", Offset = "0x65781E0", VA = "0x1865793E0")]
	public static bool PAAKDMCDDPL(string AOIKHKIKFNC, [Out] ACDLDEACLCB CBJLPIEMMPH, [Out] int JHJGLPHLNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x65791A0", Offset = "0x6577FA0", VA = "0x1865791A0")]
	public static string OCJJKJJOGDM(ACDLDEACLCB CBJLPIEMMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6578B50", Offset = "0x6577950", VA = "0x186578B50")]
	public static string[] HGIKBKNIBFG(ACDLDEACLCB CBJLPIEMMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6578AE0", Offset = "0x65778E0", VA = "0x186578AE0")]
	public static int CPIAHPAGFEG(ACDLDEACLCB CBJLPIEMMPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6578D50", Offset = "0x6577B50", VA = "0x186578D50")]
	public static string HKOKJKFNNDI(ACDLDEACLCB CBJLPIEMMPH, int ENPOKNEMOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6579200", Offset = "0x6578000", VA = "0x186579200")]
	private static bool OEIPJPKDDOL(string FHNDHHKPPLA, [Out] AGRoomRuntimeConfig.Location HGJHIAIAAOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6578E40", Offset = "0x6577C40", VA = "0x186578E40")]
	public static bool LNCLLACLCFJ(string FHNDHHKPPLA, [Out] ACDLDEACLCB CBJLPIEMMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65798F0", Offset = "0x65786F0", VA = "0x1865798F0")]
	public static int PIMBINDJAJG(ACDLDEACLCB CBJLPIEMMPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65790C0", Offset = "0x6577EC0", VA = "0x1865790C0")]
	public static string NFCFDOGMILE(ACDLDEACLCB CBJLPIEMMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6578A60", Offset = "0x6577860", VA = "0x186578A60")]
	public static bool CMICOHBLIEG(ACDLDEACLCB CBJLPIEMMPH, ELLBJEMJDGD ACKDDJJGOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6579120", Offset = "0x6577F20", VA = "0x186579120")]
	public static bool NGFDHJGLKOD(ACDLDEACLCB CBJLPIEMMPH, [Out] GameTeamColorSettings GMLKHLPDLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6578DE0", Offset = "0x6577BE0", VA = "0x186578DE0")]
	public static DGIAIJHLAKA KIEPEOGEOGO(ACDLDEACLCB CBJLPIEMMPH)
	{
		return default(DGIAIJHLAKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6579060", Offset = "0x6577E60", VA = "0x186579060")]
	public static bool NAKLAKMGOKN(ACDLDEACLCB CBJLPIEMMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x65789C0", Offset = "0x65777C0", VA = "0x1865789C0")]
	public static bool BMEFPEOAJPI(ACDLDEACLCB CBJLPIEMMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x65789B0", Offset = "0x65777B0", VA = "0x1865789B0")]
	public static int ACEOODJFMBE(ACDLDEACLCB CBJLPIEMMPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6578BB0", Offset = "0x65779B0", VA = "0x186578BB0")]
	public static AGRoomRuntimeConfig.Location HKNGLFNBPAM(ACDLDEACLCB CBJLPIEMMPH)
	{
		return null;
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GameTeamColorSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public bool TeamOutfitColorEmissionEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float TeamOutfitColorEmissionAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TeamColor[] CustomTeamColors;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6578850", Offset = "0x6577650", VA = "0x186578850")]
	public bool FMNIGOLCBNK(ANPNCBIAKNC APEFKANPNIG, [Out] Color OLDELFAHHJB, bool GNCJAMCKIDC = false)
	{
		return default(bool);
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct TeamColor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ANPNCBIAKNC Team;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Color AlternateColor;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum ANPNCBIAKNC
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	TEAM_1 = 0,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	TEAM_2 = 1,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TEAM_3 = 2,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	TEAM_4 = 3,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	TEAM_5 = 4,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	TEAM_6 = 5,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	TEAM_7 = 6,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	TEAM_8 = 7,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	TEAM_9 = 8,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	TEAM_10 = 9,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TEAM_11 = 10,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	TEAM_12 = 11,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TEAM_13 = 12,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TEAM_14 = 13,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TEAM_15 = 14,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TEAM_16 = 15,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TEAM_17 = 16,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	TEAM_18 = 17,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	TEAM_19 = 18,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	TEAM_20 = 19,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	TEAM_21 = 20,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	TEAM_22 = 21,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	TEAM_23 = 22,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	TEAM_24 = 23,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	TEAM_25 = 24,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	TEAM_26 = 25,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	TEAM_27 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	TEAM_28 = 27,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	TEAM_29 = 28,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	TEAM_30 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	TEAM_31 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	TEAM_32 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	TEAM_33 = 32,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	TEAM_34 = 33,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	TEAM_35 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	TEAM_36 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	TEAM_37 = 36,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	TEAM_38 = 37,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	TEAM_39 = 38,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	TEAM_40 = 39,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	ANY = -1,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	MAX_VALUE = 39
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum ELLBJEMJDGD
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	MODE_1,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	MODE_2,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	MODE_3,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	MODE_4,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	MODE_5,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	MODE_6,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	MODE_7,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	MODE_8,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	MODE_9,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
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
