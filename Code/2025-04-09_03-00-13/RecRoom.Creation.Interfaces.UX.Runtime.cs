using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CLMGAFAHGDN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MBKCKBJBMDL
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
public enum DJCDBLMPNIE
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
public enum ANHFLFDHLBN
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
public enum LHICOJKGJJJ
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
			[Cpp2IlInjected.Address(RVA = "0x7818B10", Offset = "0x7817F10", VA = "0x187818B10")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7818AF0", Offset = "0x7817EF0", VA = "0x187818AF0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7818AA0", Offset = "0x7817EA0", VA = "0x187818AA0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7818AC0", Offset = "0x7817EC0", VA = "0x187818AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2A22950", Offset = "0x2A21D50", VA = "0x182A22950")]
		public CostInfo(int DFEDNDHDHNB = 0, int POPBJNAJKHD = 0, int BJEAGKDNMJO = 0, int FGEPNBOFAMM = 0, int MOFGBEPKHKM = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7818460", Offset = "0x7817860", VA = "0x187818460")]
		public static CostInfo BECODLPCNHN(int BMJINMBFJON)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78185F0", Offset = "0x78179F0", VA = "0x1878185F0")]
		public static CostInfo MNGGEOLKHFL(int FDCBMBDJBFJ)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7818830", Offset = "0x7817C30", VA = "0x187818830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x78184E0", Offset = "0x78178E0", VA = "0x1878184E0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7818590", Offset = "0x7817990", VA = "0x187818590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78186F0", Offset = "0x7817AF0", VA = "0x1878186F0")]
		public static bool PEOCKCCHEIN(CostInfo EKMHDGFMJOE, CostInfo JBOHBLKFEFA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7818620", Offset = "0x7817A20", VA = "0x187818620")]
		public static CostInfo NEOOCHPFDCF(CostInfo EKMHDGFMJOE, CostInfo JBOHBLKFEFA)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7818480", Offset = "0x7817880", VA = "0x187818480")]
		public static IODGJBJINJG EMDIMCAEAFJ(GKOFKKLDMNE PDHPJAGGNIA)
		{
			return default(IODGJBJINJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7818750", Offset = "0x7817B50", VA = "0x187818750")]
		public static string PFBAOLCHAEJ(GKOFKKLDMNE HBALBIOOGIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7818680", Offset = "0x7817A80", VA = "0x187818680")]
		public GKOFKKLDMNE OGKLGLFIOLM(CostInfo EDDBIFCIPOC)
		{
			return default(GKOFKKLDMNE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78185D0", Offset = "0x78179D0", VA = "0x1878185D0")]
		public bool HIDIEIHIEOI(CostInfo EDDBIFCIPOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78185E0", Offset = "0x78179E0", VA = "0x1878185E0")]
		public bool LMOFOBMAOGE(CostInfo EDDBIFCIPOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7818610", Offset = "0x7817A10", VA = "0x187818610")]
		public bool NBGJBJGJEEI(CostInfo EDDBIFCIPOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78185C0", Offset = "0x78179C0", VA = "0x1878185C0")]
		public bool HANGNHNHJLL(CostInfo EDDBIFCIPOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7818470", Offset = "0x7817870", VA = "0x187818470")]
		public bool BJBHMOPDCBL(CostInfo EDDBIFCIPOC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GKOFKKLDMNE
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
[MGFFKDLKBDO]
public enum IODGJBJINJG
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
public static class IDPKMCCGIJM
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7818B40", Offset = "0x7817F40", VA = "0x187818B40")]
	public static bool GPHANBDOFHN(this IODGJBJINJG HBALBIOOGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7818B20", Offset = "0x7817F20", VA = "0x187818B20")]
	public static bool FMPGDFPNLEB(this IODGJBJINJG HBALBIOOGIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LJJHOGJBMIN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7818B60", Offset = "0x7817F60", VA = "0x187818B60")]
	public static string JJOGMHJIPHH(IODGJBJINJG HBALBIOOGIJ, DNIGIBHMBIB FEBPPIALOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7819410", Offset = "0x7818810", VA = "0x187819410")]
	public static string LBCEKGOGODE(FPBGJGMBMBK FHJAGNEGENL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NJJADOBINHE
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DOKEHHFHIKB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(DJCDBLMPNIE PJMCPKCEMAE, Collider LLHKIOPLDMB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NDIPNDEFKED
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDBLHHKLNEC(DJCDBLMPNIE PJMCPKCEMAE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OOBKBDFGAAM
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(DJCDBLMPNIE PJMCPKCEMAE, Collider LLHKIOPLDMB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CLAHHPOJJMG
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
	void OnMakerPenDeformed(Vector3 JBKJHPKGPCM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EKHGPMDKJIL
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
public interface EBMAAMIIPIK
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
public interface KANAPNGPFIK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PCPPFIHDGNJ
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedFromTemplate();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PLEFJCMKMIM
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public PLEFJCMKMIM()
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
