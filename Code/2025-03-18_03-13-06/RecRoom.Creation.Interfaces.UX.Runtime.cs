using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BMPCADBDMIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AFNCDIEPJDL
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
public enum KMIBGMMJDOC
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
	Transform = 21
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LCBMDCGLDCK
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	StackPop,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Force
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FFFHAHCCDIK
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	LongPress
}
namespace RecRoom.Core.Creation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CostInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int inkCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int numChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int numCloudVariables;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CostInfo zero
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7546500", Offset = "0x7545700", VA = "0x187546500")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x75464E0", Offset = "0x75456E0", VA = "0x1875464E0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7546490", Offset = "0x7545690", VA = "0x187546490")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x75464B0", Offset = "0x75456B0", VA = "0x1875464B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2965EA0", Offset = "0x29650A0", VA = "0x182965EA0")]
		public CostInfo(int LBBKKCFBPOM = 0, int INIAHMPNBJO = 0, int AFMJOKFCHOC = 0, int ONOEIPOIAHK = 0, int FPGDFGOCDHP = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7546110", Offset = "0x7545310", VA = "0x187546110")]
		public static CostInfo JEIADJFKOBG(int FMDIJDECDEI)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7545EA0", Offset = "0x75450A0", VA = "0x187545EA0")]
		public static CostInfo BMLPLPPFAFB(int LOAEPPDFOKH)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7546210", Offset = "0x7545410", VA = "0x187546210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7545EE0", Offset = "0x75450E0", VA = "0x187545EE0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75460D0", Offset = "0x75452D0", VA = "0x1875460D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7546070", Offset = "0x7545270", VA = "0x187546070")]
		public static bool GJNOMHNHJKL(CostInfo HJJALGIPDGP, CostInfo JMNOJOJCJKD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75461A0", Offset = "0x75453A0", VA = "0x1875461A0")]
		public static CostInfo NDMCJKDJPCM(CostInfo HJJALGIPDGP, CostInfo JMNOJOJCJKD)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7545E40", Offset = "0x7545040", VA = "0x187545E40")]
		public static NNLCAMNPEJB AGNOKMFKIDC(NHBBNOBEJJP ILNJPNNKANM)
		{
			return default(NNLCAMNPEJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7545F90", Offset = "0x7545190", VA = "0x187545F90")]
		public static string GJLJIPMAAJC(NHBBNOBEJJP CMLOHOMLNDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7546130", Offset = "0x7545330", VA = "0x187546130")]
		public NHBBNOBEJJP LDNAMGHECDD(CostInfo FFFFGHFGFJD)
		{
			return default(NHBBNOBEJJP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7546200", Offset = "0x7545400", VA = "0x187546200")]
		public bool OPEMPJKPCLO(CostInfo FFFFGHFGFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7545EC0", Offset = "0x75450C0", VA = "0x187545EC0")]
		public bool DBKGECBIONJ(CostInfo FFFFGHFGFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7546100", Offset = "0x7545300", VA = "0x187546100")]
		public bool HGDPBMEJOCP(CostInfo FFFFGHFGFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7546120", Offset = "0x7545320", VA = "0x187546120")]
		public bool KPNKACMFCKP(CostInfo FFFFGHFGFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7545ED0", Offset = "0x75450D0", VA = "0x187545ED0")]
		public bool DDEPLMJLCKM(CostInfo FFFFGHFGFJD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NHBBNOBEJJP
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Failure_OverInkLimit,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Failure_OverLightsLimit,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Failure_OverAiLimit,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Failure_OverChipLimit,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Failure_OverCloudVaraibleLimit
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HLBPOAABFBO]
public enum NNLCAMNPEJB
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Failure_Generic,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Failure_NoAuthority,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Failure_ToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Failure_ObjectRequired,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Failure_ControlPanelRequired,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Failure_ConnectedToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Failure_LockedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Failure_HeldByOther,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Failure_SelectingFrozenTool,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Failure_SettingsChangedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Failure_InsufficientResources,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Failure_Parented,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Failure_ObjectDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Failure_ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Failure_ToolHeld,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Failure_NetworkError,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Failure_ObjectAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Failure_ToolNotEnabled,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Failure_PermissionDenied,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Failure_InvalidAction,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Failure_ObjectInUse,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Failure_MaxSpawnsUsed,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Failure_InsufficientLightResources,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Failure_ContainsDisallowedObjects,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Failure_ShapeContainerCapacity,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Failure_LockedByEditedGizmo,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Failure_InsufficientAiResources,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Failure_SpawnedObject,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Failure_CantEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Failure_InsufficientChipResources,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Failure_PlayerCantSpawnInventions,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Failure_InsufficientCloudVariableResources,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Failure_InventionContainsToolsThatExceedCreationLimit,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Failure_FeatureNotImplementedInObjectModel,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Failure_EmptyTemplate,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Failure_CorruptSubgraph,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Failure_RateLimit,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Failure_RequestAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Failure_LockedByRoomContributor,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Failure_DataTableInTrial,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Failure_DataTableSaveDenied,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Failure_DataTableSaveInsufficientPermissions,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Failure_TooManyExternalCircuitInputs,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Failure_TooManyExternalCircuitOutputs,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Failure_TooManyNestedCircuitBoards,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Failure_ObjectModelInCircuitBoardScope,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Failure_SpawningShapeWithoutValidShapeContainer,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Failure_UgcVersionMismatch,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	PartialSuccess_AllObjectsNotRooms2Compatible,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PartialSuccess_SomeObjectsNotRooms2Compatible,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Failure_CircuitsVersioning,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Failure_NodesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Failure_SyncedVariablesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Failure_Disembodied,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Failure_InventionRIOCopyFailure,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Failure_TooComplexToClone,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Failure_StudioContentNotReadyForDevice,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Failure_StudioContentDownloadFailed
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BEPJOPOAANG
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7545E00", Offset = "0x7545000", VA = "0x187545E00")]
	public static bool GKJJGKBCPJD(this NNLCAMNPEJB CMLOHOMLNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7545E20", Offset = "0x7545020", VA = "0x187545E20")]
	public static bool KCIJOKIHGBB(this NNLCAMNPEJB CMLOHOMLNDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DDIDLFMBICM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7546510", Offset = "0x7545710", VA = "0x187546510")]
	public static string FFGAAPCDIAJ(NNLCAMNPEJB CMLOHOMLNDL, GJGNFGDHFCI DCHEMFOIIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7546DB0", Offset = "0x7545FB0", VA = "0x187546DB0")]
	public static string FMLLNIHDAGO(DKPHJPNIPLK JAIFHLIDLDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CFPJILNCHKH
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PDIMPBIBBEK
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(KMIBGMMJDOC AOENBKCOJAP, Collider KNPGPPHPGKO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OEBEMHELAKK
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFIJKLLHGCK(KMIBGMMJDOC AOENBKCOJAP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JKCCKEAOCID
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(KMIBGMMJDOC AOENBKCOJAP, Collider KNPGPPHPGKO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HFCHLADLAIP
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
	void OnMakerPenDeformed(Vector3 GANGNJLJLDO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KDBMJOHJKFM
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
public interface KIGKDNJKBKL
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
public interface JDCCNINDLCA
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LBIDGPHCHEB
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedFromTemplate();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DCKHMIAOKJO
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DCKHMIAOKJO()
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
