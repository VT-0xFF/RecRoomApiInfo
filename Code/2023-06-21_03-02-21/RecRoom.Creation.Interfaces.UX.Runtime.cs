using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PBIDDNALBNP : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	InvalidStateId = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EPHECNMCCND
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[FFMAGHJFEDC]
public enum PHNIEPLGADL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Failure_Generic,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Failure_NoAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Failure_ToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Failure_ObjectRequired,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Failure_ControlPanelRequired,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Failure_ConnectedToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Failure_LockedByOther,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Failure_HeldByOther,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Failure_SelectingFrozenTool,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Failure_SettingsChangedByOther,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Failure_InsufficientResources,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Failure_Parented,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Failure_ObjectDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Failure_ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Failure_ToolHeld,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Failure_NetworkError,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Failure_ObjectAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Failure_ToolNotEnabled,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Failure_PermissionDenied,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Failure_InvalidAction,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Failure_ObjectInUse,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Failure_MaxSpawnsUsed,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Failure_InsufficientLightResources,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Failure_ContainsDisallowedObjects,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Failure_ShapeContainerCapacity,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Failure_LockedByEditedGizmo,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Failure_InsufficientAiResources,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Failure_SpawnedObject,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Failure_CantEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Failure_InsufficientChipResources,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Failure_PlayerCantSpawnInventions,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Failure_InsufficientCloudVariableResources,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Failure_InventionContainsToolsThatExceedCreationLimit,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Failure_FeatureNotImplementedInObjectModel,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Failure_EmptyTemplate,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Failure_CorruptSubgraph,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Failure_RateLimit,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Failure_RequestAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Failure_LockedByRoomOwner,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Failure_DataTableInTrial,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Failure_DataTableSaveDenied,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Failure_DataTableSaveInsufficientPermissions
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EIFEDBPDHII
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(CAKKEGCFLLI GDGLAOBHAPA, Collider MHLCKEBLLCN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BJBFDOEOEJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Failure_OverInkLimit,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Failure_OverLightsLimit,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Failure_OverAiLimit,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Failure_OverChipLimit,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Failure_OverCloudVaraibleLimit
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ANKBIDLHLBE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(CAKKEGCFLLI GDGLAOBHAPA, Collider MHLCKEBLLCN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PKLGFACLFNH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotated();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaled();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformed(Vector3 NDCABHMAEMO);
}
namespace RecRoom.Core.Creation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct CostInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int inkCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int numChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int numCloudVariables;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CostInfo zero
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x15ABD70", Offset = "0x15AAF70", VA = "0x1815ABD70")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x15ABD50", Offset = "0x15AAF50", VA = "0x1815ABD50")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x15ABD00", Offset = "0x15AAF00", VA = "0x1815ABD00")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x15ABD20", Offset = "0x15AAF20", VA = "0x1815ABD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x15ABCE0", Offset = "0x15AAEE0", VA = "0x1815ABCE0")]
		public CostInfo(int JNBHNCJMLGH = 0, int GLLIPIAGEKF = 0, int HDCMHNKCBIG = 0, int DMNHHAHABHD = 0, int GFEIFGCBJKF = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x15ABA30", Offset = "0x15AAC30", VA = "0x1815ABA30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x15AB650", Offset = "0x15AA850", VA = "0x1815AB650", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15AB710", Offset = "0x15AA910", VA = "0x1815AB710", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x15AB840", Offset = "0x15AAA40", VA = "0x1815AB840")]
		public static bool JGKKLLGINAK(CostInfo DMGGEJPOAJH, CostInfo MPGHKEOFFAH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x15AB7D0", Offset = "0x15AA9D0", VA = "0x1815AB7D0")]
		public static CostInfo ILKGCPLNHIM(CostInfo DMGGEJPOAJH, CostInfo MPGHKEOFFAH)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x15AB9D0", Offset = "0x15AABD0", VA = "0x1815AB9D0")]
		public static PHNIEPLGADL OBPOFDICEGH(BJBFDOEOEJJ HHIBNJBOPKE)
		{
			return default(PHNIEPLGADL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x15AB8B0", Offset = "0x15AAAB0", VA = "0x1815AB8B0")]
		public static string LCFMCOKNPHP(BJBFDOEOEJJ GAFKIBJKPNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x15AB760", Offset = "0x15AA960", VA = "0x1815AB760")]
		public BJBFDOEOEJJ IIOCBIINJHM(CostInfo FBONCAONBDE)
		{
			return default(BJBFDOEOEJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x15AB8A0", Offset = "0x15AAAA0", VA = "0x1815AB8A0")]
		public bool KBLKHGBLEBF(CostInfo FBONCAONBDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x15AB9B0", Offset = "0x15AABB0", VA = "0x1815AB9B0")]
		public bool MCPEPAOBKPC(CostInfo FBONCAONBDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x15AB990", Offset = "0x15AAB90", VA = "0x1815AB990")]
		public bool LGANCJLODEH(CostInfo FBONCAONBDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x15AB740", Offset = "0x15AA940", VA = "0x1815AB740")]
		public bool HJBJAPNFHFH(CostInfo FBONCAONBDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15AB630", Offset = "0x15AA830", VA = "0x1815AB630")]
		public bool DMHNJDNFAAP(CostInfo FBONCAONBDE)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PEKHJIBCKHG
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateStart();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateStart();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleStart();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformStart();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OOEIHPGDGKP
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKDNNGFLBHN(CAKKEGCFLLI GDGLAOBHAPA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MLPNMJFJOOL
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EINDDHMMIDJ
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
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CAKKEGCFLLI
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CreateShape = 0,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Delete = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Clone = 5,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Edit = 1,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Select = 2,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Scale = 4,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Move = 3,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Configure = 7,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Connect = 8,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CreateObject = 9,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Repaint = 10,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Rotate = 12,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Disabled = 13,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Freeze = 14,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	OffHandCompanion = 15,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CreateInventionInstance = 16,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Manipulate = 17,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CreateInvention = 18,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CreateCircuitV2 = 19,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ClipboardPaste = 20,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Transform = 21,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Invalid = 65535
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum HOFEAGIHMND
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Object = 0,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Shape = 1,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CircuitsV1Group = 2,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Animation = 3,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Curve = 4,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Circuits = 5,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Invalid = 65535
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum IMMFLLNDKLN
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum ICFDLFNKODI
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	StackPop,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Force
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FPILJDAONBF
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	LongPress
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
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
