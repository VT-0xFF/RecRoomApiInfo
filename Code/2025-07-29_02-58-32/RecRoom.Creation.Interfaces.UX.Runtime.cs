using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BMLLJCCLIKB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HNFFLMGMEBB
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
public enum OKMKFILIGJN
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
	None = 22,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Palette = 23
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum ABAMHLKFGEB
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	StackPop,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Force
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HHAMEAPOGFI
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	LongPress
}
namespace RecRoom.Core.Creation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CostInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int inkCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int numChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int numCloudVariables;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CostInfo zero
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8238580", Offset = "0x8236F80", VA = "0x188238580")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8238560", Offset = "0x8236F60", VA = "0x188238560")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8238510", Offset = "0x8236F10", VA = "0x188238510")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8238530", Offset = "0x8236F30", VA = "0x188238530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2E99DD0", Offset = "0x2E987D0", VA = "0x182E99DD0")]
		public CostInfo(int DMBBCIAICBC = 0, int EJINFGOFEJC = 0, int AOJKKEHHMIA = 0, int NOJCFFGALGB = 0, int BBJDMNJMPMD = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8237EF0", Offset = "0x82368F0", VA = "0x188237EF0")]
		public static CostInfo BHCJGAJDEDN(int BKGIKIFBKOJ)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8237ED0", Offset = "0x82368D0", VA = "0x188237ED0")]
		public static CostInfo BANFACDGEJH(int LALAKIFCLAN)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82382A0", Offset = "0x8236CA0", VA = "0x1882382A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8238080", Offset = "0x8236A80", VA = "0x188238080", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8238140", Offset = "0x8236B40", VA = "0x188238140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8238180", Offset = "0x8236B80", VA = "0x188238180")]
		public static bool JJNADAGGMDE(CostInfo DPHJMMGEACO, CostInfo EJGAKEGCFCG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82381E0", Offset = "0x8236BE0", VA = "0x1882381E0")]
		public static CostInfo LCKFBKBKBME(CostInfo DPHJMMGEACO, CostInfo EJGAKEGCFCG)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8238240", Offset = "0x8236C40", VA = "0x188238240")]
		public static JKBAJCFPDKG OJCPICOLHBI(OFODNFEECJC HMNGGBHGNMK)
		{
			return default(JKBAJCFPDKG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8237F10", Offset = "0x8236910", VA = "0x188237F10")]
		public static string DBDBJMNDGJK(OFODNFEECJC AEAMJGPOBKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8237FF0", Offset = "0x82369F0", VA = "0x188237FF0")]
		public OFODNFEECJC DCILELAJOGP(CostInfo AKCLGFCIMEJ)
		{
			return default(OFODNFEECJC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8237F00", Offset = "0x8236900", VA = "0x188237F00")]
		public bool CHMMGIGMPAF(CostInfo AKCLGFCIMEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8238130", Offset = "0x8236B30", VA = "0x188238130")]
		public bool GHBEFCDEECG(CostInfo AKCLGFCIMEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8238060", Offset = "0x8236A60", VA = "0x188238060")]
		public bool DLMFMDIODGI(CostInfo AKCLGFCIMEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8238070", Offset = "0x8236A70", VA = "0x188238070")]
		public bool DPPBFGCFIIC(CostInfo AKCLGFCIMEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8238170", Offset = "0x8236B70", VA = "0x188238170")]
		public bool IHCEDINFBDM(CostInfo AKCLGFCIMEJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OFODNFEECJC
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Failure_OverInkLimit,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Failure_OverLightsLimit,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Failure_OverAiLimit,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Failure_OverChipLimit,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Failure_OverCloudVaraibleLimit
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ECBNLFMBINN]
public enum JKBAJCFPDKG
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Failure_Generic,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Failure_NoAuthority,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Failure_ToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Failure_ObjectRequired,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Failure_ControlPanelRequired,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Failure_ConnectedToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Failure_LockedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Failure_HeldByOther,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Failure_SelectingFrozenTool,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Failure_SettingsChangedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Failure_InsufficientResources,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Failure_Parented,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Failure_ObjectDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Failure_ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Failure_ToolHeld,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Failure_NetworkError,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Failure_ObjectAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Failure_ToolNotEnabled,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Failure_PermissionDenied,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Failure_InvalidAction,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Failure_ObjectInUse,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Failure_MaxSpawnsUsed,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Failure_InsufficientLightResources,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Failure_ContainsDisallowedObjects,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Failure_ShapeContainerCapacity,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Failure_LockedByEditedGizmo,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Failure_InsufficientAiResources,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Failure_SpawnedObject,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Failure_CantEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Failure_InsufficientChipResources,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Failure_PlayerCantSpawnInventions,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Failure_InsufficientCloudVariableResources,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Failure_InventionContainsToolsThatExceedCreationLimit,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Failure_FeatureNotImplementedInObjectModel,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Failure_EmptyTemplate,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Failure_CorruptSubgraph,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Failure_RateLimit,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Failure_RequestAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Failure_LockedByRoomContributor,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Failure_DataTableInTrial,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Failure_DataTableSaveDenied,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Failure_DataTableSaveInsufficientPermissions,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Failure_TooManyExternalCircuitInputs,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Failure_TooManyExternalCircuitOutputs,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Failure_TooManyNestedCircuitBoards,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Failure_ObjectModelInCircuitBoardScope,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Failure_SpawningShapeWithoutValidShapeContainer,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Failure_UgcVersionMismatch,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	PartialSuccess_AllObjectsNotRooms2Compatible,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	PartialSuccess_SomeObjectsNotRooms2Compatible,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Failure_CircuitsVersioning,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Failure_NodesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Failure_SyncedVariablesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Failure_Disembodied,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Failure_InventionRIOCopyFailure,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Failure_TooComplexToClone,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Failure_StudioContentNotReadyForDevice,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Failure_StudioContentDownloadFailed,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Failure_InventionCannotBeTokenSpawned,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Failure_InventionTokenInvalid
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HBCECNOKMMP
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82385B0", Offset = "0x8236FB0", VA = "0x1882385B0")]
	public static bool KGGLAKMMINK(this JKBAJCFPDKG AEAMJGPOBKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8238590", Offset = "0x8236F90", VA = "0x188238590")]
	public static bool DALKPEMLMBP(this JKBAJCFPDKG AEAMJGPOBKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class KCFPLONJHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82385D0", Offset = "0x8236FD0", VA = "0x1882385D0")]
	public static string FMPGFDEKPNB(JKBAJCFPDKG AEAMJGPOBKI, POIAKMBAMML ABDDBLLJDLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8238EC0", Offset = "0x82378C0", VA = "0x188238EC0")]
	public static string GKNPOFFGDLH(PCPIEKJCMFL AHABFDNECCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CPHDMKIPMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BKKJNPFELFL
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(OKMKFILIGJN FHPECEFKIBM, Collider JOENJLJLKNB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BMKAJPPHPEK
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIHIPLFLIEI(OKMKFILIGJN FHPECEFKIBM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DNKFDCJGPOL
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(OKMKFILIGJN FHPECEFKIBM, Collider JOENJLJLKNB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FKGEMOGMNOG
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
	void OnMakerPenDeformed(Vector3 INLKDFBHNDD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IMOCHMKAMKD
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
public interface OLHEJPPGABN
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
public interface BPCHJIMFMJG
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OEJMNMILLIC
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedFromTemplate();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IFNBIANOKDF
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IFNBIANOKDF()
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
