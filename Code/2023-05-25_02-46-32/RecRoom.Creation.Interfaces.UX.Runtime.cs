using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HBBCAFHMAKI : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	InvalidStateId = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GOPLACDOEOO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CBONMDLGKNK]
public enum MHPBAPDBIDB
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
	Failure_LockedByRoomOwner
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EEHHFADGEFE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(GJHMODBNPKH GHOALGBLJJE, Collider CPGMLAAKKBC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CIOMIPKDENP
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Failure_OverInkLimit,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Failure_OverLightsLimit,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Failure_OverAiLimit,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Failure_OverChipLimit,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Failure_OverCloudVaraibleLimit
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FBJCIJMKOND
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(GJHMODBNPKH GHOALGBLJJE, Collider CPGMLAAKKBC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HMGHJIMPBMD
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
	void OnMakerPenDeformed(Vector3 NFPBFHMMAJA);
}
namespace RecRoom.Core.Creation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct CostInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int inkCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int numChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int numCloudVariables;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CostInfo zero
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x16916A0", Offset = "0x168FEA0", VA = "0x1816916A0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1691680", Offset = "0x168FE80", VA = "0x181691680")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1691630", Offset = "0x168FE30", VA = "0x181691630")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1691650", Offset = "0x168FE50", VA = "0x181691650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1691610", Offset = "0x168FE10", VA = "0x181691610")]
		public CostInfo(int IGIFMKGMABC = 0, int CGHCDANHKIM = 0, int JAJDFCBAIJO = 0, int JHFCNPDFNFN = 0, int JLLHCMDOKEL = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1691360", Offset = "0x168FB60", VA = "0x181691360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1690F00", Offset = "0x168F700", VA = "0x181690F00", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1691050", Offset = "0x168F850", VA = "0x181691050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1690FD0", Offset = "0x168F7D0", VA = "0x181690FD0")]
		public static bool FMMDKFLNNFA(CostInfo BBCEOOINHKL, CostInfo NKOJKMHBJPI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x16912D0", Offset = "0x168FAD0", VA = "0x1816912D0")]
		public static CostInfo OGNHPCPAOIL(CostInfo BBCEOOINHKL, CostInfo NKOJKMHBJPI)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x16910F0", Offset = "0x168F8F0", VA = "0x1816910F0")]
		public static MHPBAPDBIDB LBJCPFCHDBJ(CIOMIPKDENP CCNABFOCIEH)
		{
			return default(MHPBAPDBIDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1691150", Offset = "0x168F950", VA = "0x181691150")]
		public static string LHIEOHNHOPL(CIOMIPKDENP IIMBBHEIGGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1691230", Offset = "0x168FA30", VA = "0x181691230")]
		public CIOMIPKDENP LIKNEOHNDKK(CostInfo BOFKKMOCJDN)
		{
			return default(CIOMIPKDENP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1691080", Offset = "0x168F880", VA = "0x181691080")]
		public bool HFONNNDMIKD(CostInfo BOFKKMOCJDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x16912B0", Offset = "0x168FAB0", VA = "0x1816912B0")]
		public bool LPCBGKEFOPF(CostInfo BOFKKMOCJDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x16910B0", Offset = "0x168F8B0", VA = "0x1816910B0")]
		public bool JEFHEGACICF(CostInfo BOFKKMOCJDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1691090", Offset = "0x168F890", VA = "0x181691090")]
		public bool IBKNNBGHDIH(CostInfo BOFKKMOCJDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x16910D0", Offset = "0x168F8D0", VA = "0x1816910D0")]
		public bool KBBFHOEENBI(CostInfo BOFKKMOCJDN)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DPGIKKOJGCL
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
public interface OICMKCCBGGP
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFDNFFJMPKG(GJHMODBNPKH GHOALGBLJJE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HAPLOGGLFDA
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FFIAFBCKBLO
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
public enum GJHMODBNPKH
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CreateShape = 0,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Delete = 6,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Clone = 5,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Edit = 1,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Select = 2,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Scale = 4,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Move = 3,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Configure = 7,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Connect = 8,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CreateObject = 9,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Repaint = 10,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Rotate = 12,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Disabled = 13,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Freeze = 14,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	OffHandCompanion = 15,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CreateInventionInstance = 16,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Manipulate = 17,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CreateInvention = 18,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CreateCircuitV2 = 19,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ClipboardPaste = 20,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Transform = 21,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Invalid = 65535
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum HLDBEMHOAON
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Object = 0,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Shape = 1,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CircuitsV1Group = 2,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Animation = 3,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Curve = 4,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Circuits = 5,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Invalid = 65535
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum POECPKMFIJK
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum MDNJALCPGHD
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	StackPop,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Force
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FIBPDFDOBGG
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	LongPress
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
