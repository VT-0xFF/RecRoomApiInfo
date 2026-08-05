using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IILGIPDJFPC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OJFCPHKHDFK
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
public enum PMAGAGOBJMK
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
	NewMove = 22,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Palette = 23,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	None = 24
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum ALBNKIGJIPN
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	StackPop,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Force
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PEFKGOIPNDK
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	LongPress
}
namespace RecRoom.Core.Creation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CostInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int inkCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int numChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int numCloudVariables;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CostInfo zero
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x842EAA0", Offset = "0x842D0A0", VA = "0x18842EAA0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x842EA80", Offset = "0x842D080", VA = "0x18842EA80")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x842EA30", Offset = "0x842D030", VA = "0x18842EA30")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x842EA50", Offset = "0x842D050", VA = "0x18842EA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2FC81B0", Offset = "0x2FC67B0", VA = "0x182FC81B0")]
		public CostInfo(int CKJGDEADIIG = 0, int EPKBKNAENNG = 0, int HLNNHKMGNGE = 0, int NEJKICKHHAM = 0, int AEKNMMIJIGL = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x842E640", Offset = "0x842CC40", VA = "0x18842E640")]
		public static CostInfo KIHADLLDCAE(int MBEILCAGDDJ)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x842E7A0", Offset = "0x842CDA0", VA = "0x18842E7A0")]
		public static CostInfo PDMGIKLPJHO(int NPNDAGGLEEM)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x842E7C0", Offset = "0x842CDC0", VA = "0x18842E7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x842E450", Offset = "0x842CA50", VA = "0x18842E450", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x842E5E0", Offset = "0x842CBE0", VA = "0x18842E5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x842E730", Offset = "0x842CD30", VA = "0x18842E730")]
		public static bool MGLHCKHANFO(CostInfo BJFDGLBBJJA, CostInfo AFNIOONIAOP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x842E3F0", Offset = "0x842C9F0", VA = "0x18842E3F0")]
		public static CostInfo BGHMHPJMNJI(CostInfo BJFDGLBBJJA, CostInfo AFNIOONIAOP)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x842E500", Offset = "0x842CB00", VA = "0x18842E500")]
		public static OBDDAJBHKHI FEMKMNIMHKB(IKEFBCDJFEK DKEKCMCBDAD)
		{
			return default(OBDDAJBHKHI);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x842E650", Offset = "0x842CC50", VA = "0x18842E650")]
		public static string LLJIHEBMJEH(IKEFBCDJFEK FAKHJBCPGHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x842E560", Offset = "0x842CB60", VA = "0x18842E560")]
		public IKEFBCDJFEK FHCNNKFEINM(CostInfo ABGPKIOLCPA)
		{
			return default(IKEFBCDJFEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x842E620", Offset = "0x842CC20", VA = "0x18842E620")]
		public bool IJBMKLHIJEF(CostInfo ABGPKIOLCPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x842E5D0", Offset = "0x842CBD0", VA = "0x18842E5D0")]
		public bool FNJDPBIGBIO(CostInfo ABGPKIOLCPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x842E610", Offset = "0x842CC10", VA = "0x18842E610")]
		public bool IGLCIBJIGBN(CostInfo ABGPKIOLCPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x842E630", Offset = "0x842CC30", VA = "0x18842E630")]
		public bool JIHKIDAFJEC(CostInfo ABGPKIOLCPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x842E790", Offset = "0x842CD90", VA = "0x18842E790")]
		public bool OOFMKGIOMAN(CostInfo ABGPKIOLCPA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum IKEFBCDJFEK
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Failure_OverInkLimit,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Failure_OverLightsLimit,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Failure_OverAiLimit,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Failure_OverChipLimit,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Failure_OverCloudVaraibleLimit
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NLOGEJFOJJC]
public enum OBDDAJBHKHI
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Failure_Generic,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Failure_NoAuthority,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Failure_ToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Failure_ObjectRequired,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Failure_ControlPanelRequired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Failure_ConnectedToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Failure_LockedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Failure_HeldByOther,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Failure_SelectingFrozenTool,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Failure_SettingsChangedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Failure_InsufficientResources,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Failure_Parented,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Failure_ObjectDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Failure_ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Failure_ToolHeld,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Failure_NetworkError,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Failure_ObjectAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Failure_ToolNotEnabled,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Failure_PermissionDenied,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Failure_InvalidAction,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Failure_ObjectInUse,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Failure_MaxSpawnsUsed,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Failure_InsufficientLightResources,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Failure_ContainsDisallowedObjects,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Failure_ShapeContainerCapacity,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Failure_LockedByEditedGizmo,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Failure_InsufficientAiResources,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Failure_SpawnedObject,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Failure_CantEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Failure_InsufficientChipResources,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Failure_PlayerCantSpawnInventions,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Failure_InsufficientCloudVariableResources,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Failure_InventionContainsToolsThatExceedCreationLimit,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Failure_FeatureNotImplementedInObjectModel,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Failure_EmptyTemplate,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Failure_CorruptSubgraph,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Failure_RateLimit,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Failure_RequestAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Failure_LockedByRoomContributor,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Failure_DataTableInTrial,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Failure_DataTableSaveDenied,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Failure_DataTableSaveInsufficientPermissions,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Failure_TooManyExternalCircuitInputs,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Failure_TooManyExternalCircuitOutputs,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Failure_TooManyNestedCircuitBoards,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Failure_ObjectModelInCircuitBoardScope,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Failure_SpawningShapeWithoutValidShapeContainer,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Failure_UgcVersionMismatch,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	PartialSuccess_AllObjectsNotRooms2Compatible,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PartialSuccess_SomeObjectsNotRooms2Compatible,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Failure_CircuitsVersioning,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Failure_NodesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Failure_SyncedVariablesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Failure_Disembodied,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Failure_InventionRIOCopyFailure,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Failure_TooComplexToClone,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Failure_StudioContentNotReadyForDevice,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Failure_StudioContentDownloadFailed,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Failure_InventionCannotBeTokenSpawned,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Failure_InventionTokenInvalid
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class COGGFMCCHBC
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x842E3B0", Offset = "0x842C9B0", VA = "0x18842E3B0")]
	public static bool NOCBJMJGNPG(this OBDDAJBHKHI FAKHJBCPGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x842E3D0", Offset = "0x842C9D0", VA = "0x18842E3D0")]
	public static bool NOKJFMAJFFO(this OBDDAJBHKHI FAKHJBCPGHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OCPCHEJOIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x842EAB0", Offset = "0x842D0B0", VA = "0x18842EAB0")]
	public static string CNMGENPAMCO(OBDDAJBHKHI FAKHJBCPGHO, MEINMPIOLGA ALIOMIIGMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x842F3A0", Offset = "0x842D9A0", VA = "0x18842F3A0")]
	public static string FNGLIMMOAPM(LLABNDNDGDO BFKNPCBLOIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HJJIEHMGIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KJPHFDDBCGP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(PMAGAGOBJMK EMFDOBHEOON, Collider CCJNMHOFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FKAKPAEIDDP
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KNDMEKFLHPK(PMAGAGOBJMK EMFDOBHEOON);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IHAAKMCKJOE
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(PMAGAGOBJMK EMFDOBHEOON, Collider CCJNMHOFBOH);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FIOMKNEPGHJ
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
	void OnMakerPenDeformed(Vector3 EANHJGACELJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FFAJIDFBOCI
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
public interface BJPDBKDLAKD
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
public interface BEGJAFNPHOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FKCAINHDMIE
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedFromTemplate();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IDEENHLMJMC
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IDEENHLMJMC()
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
