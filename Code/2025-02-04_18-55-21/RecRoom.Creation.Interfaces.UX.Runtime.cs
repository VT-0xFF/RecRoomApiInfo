using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum EMFLLDLDLPG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JFINDFFELNN
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
public enum ELICGFMBAFI
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
public enum CDFONNNKOFJ
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
public enum BBMONGBPDAC
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
			[Cpp2IlInjected.Address(RVA = "0x71D0E40", Offset = "0x71CFC40", VA = "0x1871D0E40")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x71D0E20", Offset = "0x71CFC20", VA = "0x1871D0E20")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x71D0DD0", Offset = "0x71CFBD0", VA = "0x1871D0DD0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x71D0DF0", Offset = "0x71CFBF0", VA = "0x1871D0DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x28D9DD0", Offset = "0x28D8BD0", VA = "0x1828D9DD0")]
		public CostInfo(int LDKHPLBDJMJ = 0, int EEEACGNOILH = 0, int KHGMPBOPDBE = 0, int KGKLFPLMLDF = 0, int NPBKEJPHCAI = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71D0800", Offset = "0x71CF600", VA = "0x1871D0800")]
		public static CostInfo EIIAACHALDK(int AEGCLEPNDCM)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71D0780", Offset = "0x71CF580", VA = "0x1871D0780")]
		public static CostInfo BFJNGIOCAKA(int PCPMCPCAHDJ)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71D0B50", Offset = "0x71CF950", VA = "0x1871D0B50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71D0810", Offset = "0x71CF610", VA = "0x1871D0810", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71D0A00", Offset = "0x71CF800", VA = "0x1871D0A00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71D07A0", Offset = "0x71CF5A0", VA = "0x1871D07A0")]
		public static bool BHDCHHANDIG(CostInfo KOEKLNGMMMO, CostInfo AGNMGAGFMNN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71D08C0", Offset = "0x71CF6C0", VA = "0x1871D08C0")]
		public static CostInfo FGBMGJFOFOB(CostInfo KOEKLNGMMMO, CostInfo AGNMGAGFMNN)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71D0A50", Offset = "0x71CF850", VA = "0x1871D0A50")]
		public static EFLLIDNLPAK LFHOCMCCPJC(CNMADMLMGKI KJDIAKNAOEA)
		{
			return default(EFLLIDNLPAK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71D0920", Offset = "0x71CF720", VA = "0x1871D0920")]
		public static string GOBKLINPOAA(CNMADMLMGKI LDEANEOLAOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71D0AD0", Offset = "0x71CF8D0", VA = "0x1871D0AD0")]
		public CNMADMLMGKI MMCBEBDEFDM(CostInfo DFKGDANEICC)
		{
			return default(CNMADMLMGKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71D0A40", Offset = "0x71CF840", VA = "0x1871D0A40")]
		public bool IJIACELFCII(CostInfo DFKGDANEICC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71D0A30", Offset = "0x71CF830", VA = "0x1871D0A30")]
		public bool HFCAAIEEGEI(CostInfo DFKGDANEICC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71D0AC0", Offset = "0x71CF8C0", VA = "0x1871D0AC0")]
		public bool MHIHCGJBMDE(CostInfo DFKGDANEICC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71D0B40", Offset = "0x71CF940", VA = "0x1871D0B40")]
		public bool OCHFJOLAKCF(CostInfo DFKGDANEICC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x71D0AB0", Offset = "0x71CF8B0", VA = "0x1871D0AB0")]
		public bool MCDGNNIMPPJ(CostInfo DFKGDANEICC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum CNMADMLMGKI
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
[LKHJBNCKCPE]
public enum EFLLIDNLPAK
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
	Failure_TooComplexToClone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EPJCFABACCL
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x71D0E50", Offset = "0x71CFC50", VA = "0x1871D0E50")]
	public static bool LAIHDCAPNIH(this EFLLIDNLPAK LDEANEOLAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x71D0E70", Offset = "0x71CFC70", VA = "0x1871D0E70")]
	public static bool MGCALBACOJH(this EFLLIDNLPAK LDEANEOLAOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class KHHFCKBKIAG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x71D0E90", Offset = "0x71CFC90", VA = "0x1871D0E90")]
	public static string IKBOKOKGPBK(EFLLIDNLPAK LDEANEOLAOA, NJGJGBGCLGP NPCNGFMDEKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PHJOKBNCAEP
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ILJEKLKKDOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(ELICGFMBAFI HLECICDDCCN, Collider OFCLIMBNIME);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KMBLNIAFKED
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBFOKHCGCFO(ELICGFMBAFI HLECICDDCCN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OCGMFBHBFHD
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(ELICGFMBAFI HLECICDDCCN, Collider OFCLIMBNIME);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MKJMGKFGMPD
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslated();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotated();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaled();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformed(Vector3 FCAMHKCPNDP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GMFBIJIIAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateFinished();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateFinished();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformFinished();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface POFKBJHOOCI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateStart();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateStart();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformStart();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BOLEJDGFPJA
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NKBGDEAEJLE
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedFromTemplate();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PINIBFHHCLA
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PINIBFHHCLA()
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
