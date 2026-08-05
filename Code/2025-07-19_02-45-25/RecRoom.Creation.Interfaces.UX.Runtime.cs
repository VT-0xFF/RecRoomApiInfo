using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ABJIDDHACFI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GPBOEHJDANA
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
public enum FGNANMBDCMP
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
public enum IMGPBEFKALK
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
public enum IBBFDIBANKC
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
			[Cpp2IlInjected.Address(RVA = "0x80A7460", Offset = "0x80A6460", VA = "0x1880A7460")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x80A7440", Offset = "0x80A6440", VA = "0x1880A7440")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x80A73F0", Offset = "0x80A63F0", VA = "0x1880A73F0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x80A7410", Offset = "0x80A6410", VA = "0x1880A7410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2E5D910", Offset = "0x2E5C910", VA = "0x182E5D910")]
		public CostInfo(int ANLDIEPECKO = 0, int JJMOKOEINNH = 0, int APJMCIBJPMO = 0, int MMBIGIOEMFH = 0, int AFMJNIGNFEH = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80A6DA0", Offset = "0x80A5DA0", VA = "0x1880A6DA0")]
		public static CostInfo ANMLIMNAHMK(int JNLMBIMBBKL)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80A6DC0", Offset = "0x80A5DC0", VA = "0x1880A6DC0")]
		public static CostInfo DJKCFLNAEMP(int BDJJHOEHDGN)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80A7170", Offset = "0x80A6170", VA = "0x1880A7170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80A6E60", Offset = "0x80A5E60", VA = "0x1880A6E60", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80A6F20", Offset = "0x80A5F20", VA = "0x1880A6F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80A70B0", Offset = "0x80A60B0", VA = "0x1880A70B0")]
		public static bool PHGIAKEDBEK(CostInfo IKDLFNLJEDB, CostInfo KNMFPMEABCD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80A6E00", Offset = "0x80A5E00", VA = "0x1880A6E00")]
		public static CostInfo EHAFMEMPAKB(CostInfo IKDLFNLJEDB, CostInfo KNMFPMEABCD)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80A7110", Offset = "0x80A6110", VA = "0x1880A7110")]
		public static BFHGLCFOFPD PIEPHIGLJNP(BFMMIICBNPH JAPHHHMPNDK)
		{
			return default(BFHGLCFOFPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80A6FC0", Offset = "0x80A5FC0", VA = "0x1880A6FC0")]
		public static string NKACDIBOPBF(BFMMIICBNPH BGOCMPMGKKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80A6F50", Offset = "0x80A5F50", VA = "0x1880A6F50")]
		public BFMMIICBNPH HAJDKAMCEMI(CostInfo KCEPOKGKEGI)
		{
			return default(BFMMIICBNPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80A6F10", Offset = "0x80A5F10", VA = "0x1880A6F10")]
		public bool GDFEBCABMFN(CostInfo KCEPOKGKEGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80A6DB0", Offset = "0x80A5DB0", VA = "0x1880A6DB0")]
		public bool DCAGGMGFEHJ(CostInfo KCEPOKGKEGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80A6DF0", Offset = "0x80A5DF0", VA = "0x1880A6DF0")]
		public bool EFIDDAPDOAA(CostInfo KCEPOKGKEGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80A6DE0", Offset = "0x80A5DE0", VA = "0x1880A6DE0")]
		public bool DLOHPAOEHBN(CostInfo KCEPOKGKEGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80A70A0", Offset = "0x80A60A0", VA = "0x1880A70A0")]
		public bool OJDFEEHNPMN(CostInfo KCEPOKGKEGI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BFMMIICBNPH
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
[HJGMAGCACGC]
public enum BFHGLCFOFPD
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
	Failure_StudioContentDownloadFailed,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Failure_InventionCannotBeTokenSpawned,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Failure_InventionTokenInvalid
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HCIEHOOPCHO
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80A7490", Offset = "0x80A6490", VA = "0x1880A7490")]
	public static bool PFLOLJIAHLK(this BFHGLCFOFPD BGOCMPMGKKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80A7470", Offset = "0x80A6470", VA = "0x1880A7470")]
	public static bool MGLGPHCPCKJ(this BFHGLCFOFPD BGOCMPMGKKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MCJJCBKMGFG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80A7540", Offset = "0x80A6540", VA = "0x1880A7540")]
	public static string LLBMPAOCKPB(BFHGLCFOFPD BGOCMPMGKKI, IALDHONKEJC AICNDIJBNEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80A74B0", Offset = "0x80A64B0", VA = "0x1880A74B0")]
	public static string BEEDNGBNCEP(JNILEFJFFJD EPFCJNIODEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GBCLHBOEJFM
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FKFCKLKPNIJ
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(FGNANMBDCMP DMGNFNHDFGA, Collider CPAJNCPNAED);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ECLBPFHHDMM
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IENPKLIHLGP(FGNANMBDCMP DMGNFNHDFGA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EGDNNGMACJF
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(FGNANMBDCMP DMGNFNHDFGA, Collider CPAJNCPNAED);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HLJAJMGICFN
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
	void OnMakerPenDeformed(Vector3 BKPFMPJNAGN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PDHLFJFEBIN
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
public interface NGAIMMMHOKI
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
public interface MBICEHKFAGC
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EBHCOKBICIL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedFromTemplate();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HLGNEFPMHEK
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HLGNEFPMHEK()
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
