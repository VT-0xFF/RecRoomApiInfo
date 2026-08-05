using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FOBOPILLIKH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HKBBCMCACCO
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
public enum HNNNPPHEKAD
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
public enum BNDNDDIOGCO
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
public enum AJCAHHIKMIC
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
			[Cpp2IlInjected.Address(RVA = "0x8424B50", Offset = "0x8423550", VA = "0x188424B50")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8424B30", Offset = "0x8423530", VA = "0x188424B30")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8424AE0", Offset = "0x84234E0", VA = "0x188424AE0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8424B00", Offset = "0x8423500", VA = "0x188424B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4A80", Offset = "0x2FC3480", VA = "0x182FC4A80")]
		public CostInfo(int DCOHDKJMHOF = 0, int NGOMNGHHCEL = 0, int HMDOCNHKFMA = 0, int PAIEOJPNIAP = 0, int IMPJPGMFBPD = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84247E0", Offset = "0x84231E0", VA = "0x1884247E0")]
		public static CostInfo OCNLLBAPHPE(int FFPILPOCLDL)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8424760", Offset = "0x8423160", VA = "0x188424760")]
		public static CostInfo NBHBPPNCBCF(int JNDOKHCGJMM)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8424870", Offset = "0x8423270", VA = "0x188424870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84245B0", Offset = "0x8422FB0", VA = "0x1884245B0", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8424660", Offset = "0x8423060", VA = "0x188424660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8424780", Offset = "0x8423180", VA = "0x188424780")]
		public static bool NOPNAEDOCOI(CostInfo IDMGEDGGKMC, CostInfo JEGNFJMODLN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8424700", Offset = "0x8423100", VA = "0x188424700")]
		public static CostInfo LGPEJBKKIPP(CostInfo IDMGEDGGKMC, CostInfo JEGNFJMODLN)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84246A0", Offset = "0x84230A0", VA = "0x1884246A0")]
		public static BHJAIHGBCJG LDENOLHGPHJ(NLCHICNJCIJ GLBIGAMCLHE)
		{
			return default(BHJAIHGBCJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84244C0", Offset = "0x8422EC0", VA = "0x1884244C0")]
		public static string EMJILJKFJKH(NLCHICNJCIJ GGIKEMCHAAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84247F0", Offset = "0x84231F0", VA = "0x1884247F0")]
		public NLCHICNJCIJ OOINPJCNEFF(CostInfo KHOJKEIIKAA)
		{
			return default(NLCHICNJCIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8424860", Offset = "0x8423260", VA = "0x188424860")]
		public bool PMLPOPPBIKO(CostInfo KHOJKEIIKAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84244A0", Offset = "0x8422EA0", VA = "0x1884244A0")]
		public bool CKLFBADPBDH(CostInfo KHOJKEIIKAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8424690", Offset = "0x8423090", VA = "0x188424690")]
		public bool KGCANLEBKLC(CostInfo KHOJKEIIKAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84244B0", Offset = "0x8422EB0", VA = "0x1884244B0")]
		public bool DFCLGDDOBNM(CostInfo KHOJKEIIKAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84245A0", Offset = "0x8422FA0", VA = "0x1884245A0")]
		public bool ENLDPEDFMJC(CostInfo KHOJKEIIKAA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NLCHICNJCIJ
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
[MEHDELHJEOO]
public enum BHJAIHGBCJG
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
public static class ANLOIBIHLGF
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8424480", Offset = "0x8422E80", VA = "0x188424480")]
	public static bool JADOKCAOJEK(this BHJAIHGBCJG GGIKEMCHAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8424460", Offset = "0x8422E60", VA = "0x188424460")]
	public static bool HEPPFBGFAEK(this BHJAIHGBCJG GGIKEMCHAAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IJCAKGGCPJP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8424B60", Offset = "0x8423560", VA = "0x188424B60")]
	public static string ACCANKLOPMD(BHJAIHGBCJG GGIKEMCHAAA, FNAEIBBBBBE FMEJEGFIBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8425440", Offset = "0x8423E40", VA = "0x188425440")]
	public static string FDDCGPOMFFE(JDGFAPGHPHD BPKNJHKFCNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EJIJDFAKJIE
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HMIMOALCKPG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(HNNNPPHEKAD EEKGJODEIOH, Collider CDDKGLFGLCL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AHKBGLIBEIE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MALOJONJDAF(HNNNPPHEKAD EEKGJODEIOH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PJKALEGGHEB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(HNNNPPHEKAD EEKGJODEIOH, Collider CDDKGLFGLCL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PLGALCHLKLL
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
	void OnMakerPenDeformed(Vector3 OOFHIMMNDGB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MDONKIILKIP
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
public interface AAGBKNKILGG
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
public interface HJHFELEJOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CNDAFFOHJNL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedFromTemplate();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HOMBPOKEPHI
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HOMBPOKEPHI()
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
