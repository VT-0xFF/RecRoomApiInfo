using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum KKNLLNEJFDO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GLCKBJNILDH
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
public enum APJOALEHJND
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
public enum BIPAJFHHMJE
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
public enum IIAHLDDEEBG
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
			[Cpp2IlInjected.Address(RVA = "0x73FBF40", Offset = "0x73FAB40", VA = "0x1873FBF40")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x73FBF20", Offset = "0x73FAB20", VA = "0x1873FBF20")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x73FBED0", Offset = "0x73FAAD0", VA = "0x1873FBED0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x73FBEF0", Offset = "0x73FAAF0", VA = "0x1873FBEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x28DD710", Offset = "0x28DC310", VA = "0x1828DD710")]
		public CostInfo(int PNIICDMIBDN = 0, int MCKIBENNHPP = 0, int ECOADEIGCHH = 0, int HCLJJJHFOMK = 0, int HFCJKMGAFKF = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x73FB880", Offset = "0x73FA480", VA = "0x1873FB880")]
		public static CostInfo AOMCGGFCMLH(int DMOEMHEPNOM)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x73FBAA0", Offset = "0x73FA6A0", VA = "0x1873FBAA0")]
		public static CostInfo GACJMEBDGAG(int GGHLKFDDIJF)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x73FBC50", Offset = "0x73FA850", VA = "0x1873FBC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73FB980", Offset = "0x73FA580", VA = "0x1873FB980", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73FBAC0", Offset = "0x73FA6C0", VA = "0x1873FBAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73FBB50", Offset = "0x73FA750", VA = "0x1873FBB50")]
		public static bool LBLECGDECIN(CostInfo NDGIPLAKDIP, CostInfo FFNEAKBLKGF)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x73FBBF0", Offset = "0x73FA7F0", VA = "0x1873FBBF0")]
		public static CostInfo OMKCABOBHEN(CostInfo NDGIPLAKDIP, CostInfo FFNEAKBLKGF)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73FBAF0", Offset = "0x73FA6F0", VA = "0x1873FBAF0")]
		public static PIOJPIDCLBF HDELLCFBLOH(IENFGIBCEMK JIEOFDOELLL)
		{
			return default(PIOJPIDCLBF);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x73FB890", Offset = "0x73FA490", VA = "0x1873FB890")]
		public static string DHHKGJKCMAG(IENFGIBCEMK HBANOBDOKBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x73FBA30", Offset = "0x73FA630", VA = "0x1873FBA30")]
		public IENFGIBCEMK FLHKEDDJFJG(CostInfo BLGILIKKAOK)
		{
			return default(IENFGIBCEMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x73FBBB0", Offset = "0x73FA7B0", VA = "0x1873FBBB0")]
		public bool LBOCKLDHAAP(CostInfo BLGILIKKAOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x73FBBE0", Offset = "0x73FA7E0", VA = "0x1873FBBE0")]
		public bool NNHEFNBNLAL(CostInfo BLGILIKKAOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x73FBBD0", Offset = "0x73FA7D0", VA = "0x1873FBBD0")]
		public bool MHJIDCJLGKJ(CostInfo BLGILIKKAOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x73FBBC0", Offset = "0x73FA7C0", VA = "0x1873FBBC0")]
		public bool LHHEEDCNEEE(CostInfo BLGILIKKAOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x73FB970", Offset = "0x73FA570", VA = "0x1873FB970")]
		public bool EENNIIAFKEK(CostInfo BLGILIKKAOK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum IENFGIBCEMK
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
[BALEJJMDFEO]
public enum PIOJPIDCLBF
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
public static class EHLCFNOMFFM
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73FBF70", Offset = "0x73FAB70", VA = "0x1873FBF70")]
	public static bool LIAHONMOEIA(this PIOJPIDCLBF HBANOBDOKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x73FBF50", Offset = "0x73FAB50", VA = "0x1873FBF50")]
	public static bool HJBEENLJIGK(this PIOJPIDCLBF HBANOBDOKBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EKIOEDBAPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x73FBF90", Offset = "0x73FAB90", VA = "0x1873FBF90")]
	public static string MJBBEJHAFAM(PIOJPIDCLBF HBANOBDOKBJ, GDNMNFALBCN EKJCILFAGIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FFECHBPMALK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KECPFLLBICA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(APJOALEHJND FCJKIGPIMCK, Collider NEGBGHBIJLI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BKMHHGKPIEI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEACJIPINPN(APJOALEHJND FCJKIGPIMCK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FDLFLHABILF
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(APJOALEHJND FCJKIGPIMCK, Collider NEGBGHBIJLI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HEIFPAHMEII
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
	void OnMakerPenDeformed(Vector3 GMCBCIEBJHE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CIECEEKFHPG
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
public interface DLJCNBMOAGJ
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
public interface KBNMEPBNPHE
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EKJPHOIFJEJ
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedFromTemplate();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DLABOHGMBLK
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DLABOHGMBLK()
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
