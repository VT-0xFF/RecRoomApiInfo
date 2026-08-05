using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum OLBLBEDEPGK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FLKDGNEKAFC
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Object,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Shape,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	CircuitsV1Group,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Animation,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Curve,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Circuits
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KLEINPMDINN
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	CreateShape = 0,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Delete = 6,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Clone = 5,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Edit = 1,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Select = 2,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Scale = 4,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Move = 3,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Configure = 7,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Connect = 8,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CreateObject = 9,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Repaint = 10,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Rotate = 12,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Disabled = 13,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Freeze = 14,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	OffHandCompanion = 15,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	CreateInventionInstance = 16,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Manipulate = 17,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CreateInvention = 18,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	CreateCircuitV2 = 19,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ClipboardPaste = 20,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Transform = 21,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	None = 22
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GAJONIGJEPA
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	StackPop,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Force
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JIBNCODMNHL
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	LongPress
}
namespace RecRoom.Core.Creation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CostInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int inkCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int numChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int numCloudVariables;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CostInfo zero
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7A6D390", Offset = "0x7A6BB90", VA = "0x187A6D390")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7A6D370", Offset = "0x7A6BB70", VA = "0x187A6D370")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7A6D320", Offset = "0x7A6BB20", VA = "0x187A6D320")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7A6D340", Offset = "0x7A6BB40", VA = "0x187A6D340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CAB0", Offset = "0x2B0B2B0", VA = "0x182B0CAB0")]
		public CostInfo(int HBOHPOBHAPA = 0, int EFGNOHOHKLL = 0, int KAEBJMBDPOG = 0, int DAHMFBAHFKN = 0, int EGBCLHPCGAI = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CF60", Offset = "0x7A6B760", VA = "0x187A6CF60")]
		public static CostInfo KCHDKGIMHNO(int ONPBCJGLBAB)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CF30", Offset = "0x7A6B730", VA = "0x187A6CF30")]
		public static CostInfo HHBBAKHFAPO(int KIKIFPMKONA)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D0B0", Offset = "0x7A6B8B0", VA = "0x187A6D0B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CCE0", Offset = "0x7A6B4E0", VA = "0x187A6CCE0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CEF0", Offset = "0x7A6B6F0", VA = "0x187A6CEF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D050", Offset = "0x7A6B850", VA = "0x187A6D050")]
		public static bool NIDGPKKMDPO(CostInfo EBGDEFLHMCK, CostInfo DHDDPGANNHL)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CFD0", Offset = "0x7A6B7D0", VA = "0x187A6CFD0")]
		public static CostInfo LGJHMHOMCNN(CostInfo EBGDEFLHMCK, CostInfo DHDDPGANNHL)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CF70", Offset = "0x7A6B770", VA = "0x187A6CF70")]
		public static GBAGLFMEAKA KEAJHMBBCEO(KBPKGMOKMMK GEMBDOADKEM)
		{
			return default(GBAGLFMEAKA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CE10", Offset = "0x7A6B610", VA = "0x187A6CE10")]
		public static string GOMPPGLKOHE(KBPKGMOKMMK HLPIAOANGMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CDA0", Offset = "0x7A6B5A0", VA = "0x187A6CDA0")]
		public KBPKGMOKMMK GHEONJIGHKO(CostInfo KIKIGKAPIEH)
		{
			return default(KBPKGMOKMMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D030", Offset = "0x7A6B830", VA = "0x187A6D030")]
		public bool LLDPBIJMAMC(CostInfo KIKIGKAPIEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CD90", Offset = "0x7A6B590", VA = "0x187A6CD90")]
		public bool FNIGHHOOFCE(CostInfo KIKIGKAPIEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CF20", Offset = "0x7A6B720", VA = "0x187A6CF20")]
		public bool HGIDPNHKOGG(CostInfo KIKIGKAPIEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D040", Offset = "0x7A6B840", VA = "0x187A6D040")]
		public bool MPEJPBJKICD(CostInfo KIKIGKAPIEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CF50", Offset = "0x7A6B750", VA = "0x187A6CF50")]
		public bool JKJBALOLCEG(CostInfo KIKIGKAPIEH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KBPKGMOKMMK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Failure_OverInkLimit,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Failure_OverLightsLimit,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Failure_OverAiLimit,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Failure_OverChipLimit,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Failure_OverCloudVaraibleLimit
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ELGGHCEIMJH]
public enum GBAGLFMEAKA
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Failure_Generic,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Failure_NoAuthority,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Failure_ToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Failure_ObjectRequired,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Failure_ControlPanelRequired,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Failure_ConnectedToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Failure_LockedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Failure_HeldByOther,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Failure_SelectingFrozenTool,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Failure_SettingsChangedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Failure_InsufficientResources,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Failure_Parented,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Failure_ObjectDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Failure_ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Failure_ToolHeld,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Failure_NetworkError,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Failure_ObjectAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Failure_ToolNotEnabled,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Failure_PermissionDenied,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Failure_InvalidAction,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Failure_ObjectInUse,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Failure_MaxSpawnsUsed,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Failure_InsufficientLightResources,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Failure_ContainsDisallowedObjects,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Failure_ShapeContainerCapacity,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Failure_LockedByEditedGizmo,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Failure_InsufficientAiResources,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Failure_SpawnedObject,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Failure_CantEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Failure_InsufficientChipResources,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Failure_PlayerCantSpawnInventions,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Failure_InsufficientCloudVariableResources,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Failure_InventionContainsToolsThatExceedCreationLimit,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Failure_FeatureNotImplementedInObjectModel,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Failure_EmptyTemplate,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Failure_CorruptSubgraph,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Failure_RateLimit,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Failure_RequestAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Failure_LockedByRoomContributor,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Failure_DataTableInTrial,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Failure_DataTableSaveDenied,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Failure_DataTableSaveInsufficientPermissions,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Failure_TooManyExternalCircuitInputs,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Failure_TooManyExternalCircuitOutputs,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Failure_TooManyNestedCircuitBoards,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Failure_ObjectModelInCircuitBoardScope,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Failure_SpawningShapeWithoutValidShapeContainer,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Failure_UgcVersionMismatch,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PartialSuccess_AllObjectsNotRooms2Compatible,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	PartialSuccess_SomeObjectsNotRooms2Compatible,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Failure_CircuitsVersioning,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Failure_NodesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Failure_SyncedVariablesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Failure_Disembodied,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Failure_InventionRIOCopyFailure,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Failure_TooComplexToClone,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Failure_StudioContentNotReadyForDevice,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Failure_StudioContentDownloadFailed
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OMNKGOHMNJE
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DCD0", Offset = "0x7A6C4D0", VA = "0x187A6DCD0")]
	public static bool DJPDKMBICJB(this GBAGLFMEAKA HLPIAOANGMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DCF0", Offset = "0x7A6C4F0", VA = "0x187A6DCF0")]
	public static bool NJBKNLIKJAE(this GBAGLFMEAKA HLPIAOANGMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class INFHICMIEAL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A6D430", Offset = "0x7A6BC30", VA = "0x187A6D430")]
	public static string ICKILNCDOPD(GBAGLFMEAKA HLPIAOANGMD, GFEBJDBBDID OCIHCAFFEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A6D3A0", Offset = "0x7A6BBA0", VA = "0x187A6D3A0")]
	public static string CKDKMJCKBAD(LFPHHGOEBDM MIGICMHBMEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HDLNKLCINAL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BJGKJPIKLEJ
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(KLEINPMDINN MFPLILPACGK, Collider OLFFCMGLGOF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EALCOKHOMIH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEDKIEBBLNH(KLEINPMDINN MFPLILPACGK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JIKFAHNLFLN
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(KLEINPMDINN MFPLILPACGK, Collider OLFFCMGLGOF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DKFJCJPLFFD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslated();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotated();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaled();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformed(Vector3 CFLCGMJMPLD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KGJBBHMNIHM
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateFinished();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateFinished();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformFinished();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HBGHBJLAJGC
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateStart();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateStart();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformStart();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CGOAKIEKKPF
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AKEDIGABPCN
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedFromTemplate();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AICHEIEOLIK
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AICHEIEOLIK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
