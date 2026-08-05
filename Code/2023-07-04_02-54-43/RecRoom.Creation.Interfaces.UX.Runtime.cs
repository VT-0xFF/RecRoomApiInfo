using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JBFCFHCDPMD : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	InvalidStateId = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JCPIEJDGMAA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[EHFCAELBLDP]
public enum BOEFACIMGNG
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
public interface KHGBHCHHOLM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(JOGFEADJNLC AKDIBLFNNAJ, Collider AGHAMLLNPID);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PCKFEJLGOHB
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
public interface KFIKHCIDIML
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(JOGFEADJNLC AKDIBLFNNAJ, Collider AGHAMLLNPID);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PNCGAGHAJKL
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
	void OnMakerPenDeformed(Vector3 PGGLIEIDIKC);
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
			[Cpp2IlInjected.Address(RVA = "0x7270720", Offset = "0x726ED20", VA = "0x187270720")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7270700", Offset = "0x726ED00", VA = "0x187270700")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x72706B0", Offset = "0x726ECB0", VA = "0x1872706B0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x72706D0", Offset = "0x726ECD0", VA = "0x1872706D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7270690", Offset = "0x726EC90", VA = "0x187270690")]
		public CostInfo(int DHNLPPJFOMN = 0, int GOLMHAIJHBL = 0, int CKNJBLCONJM = 0, int PCPNEDGIMJA = 0, int LEJJKDHFAFH = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72703E0", Offset = "0x726E9E0", VA = "0x1872703E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7270130", Offset = "0x726E730", VA = "0x187270130", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7270250", Offset = "0x726E850", VA = "0x187270250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7270330", Offset = "0x726E930", VA = "0x187270330")]
		public static bool MOJFGPLDDKP(CostInfo AIJOPANLKDO, CostInfo CEMPBBNBLMO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7270280", Offset = "0x726E880", VA = "0x187270280")]
		public static CostInfo HDDBLAAJMND(CostInfo AIJOPANLKDO, CostInfo CEMPBBNBLMO)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72701F0", Offset = "0x726E7F0", VA = "0x1872701F0")]
		public static BOEFACIMGNG GKHKOPPGBMK(PCKFEJLGOHB BPLFKFMLHDB)
		{
			return default(BOEFACIMGNG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7270050", Offset = "0x726E650", VA = "0x187270050")]
		public static string EAMOPGGHIHC(PCKFEJLGOHB COGPMIAOIBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x726FFE0", Offset = "0x726E5E0", VA = "0x18726FFE0")]
		public PCKFEJLGOHB CCJEOODNBDL(CostInfo HNENKCBGPPB)
		{
			return default(PCKFEJLGOHB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72703D0", Offset = "0x726E9D0", VA = "0x1872703D0")]
		public bool PLOLFEGMEMN(CostInfo HNENKCBGPPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72703B0", Offset = "0x726E9B0", VA = "0x1872703B0")]
		public bool PFBIMPBAKCC(CostInfo HNENKCBGPPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7270310", Offset = "0x726E910", VA = "0x187270310")]
		public bool MNFKLHEAACJ(CostInfo HNENKCBGPPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7270390", Offset = "0x726E990", VA = "0x187270390")]
		public bool OGDLEPLNDPN(CostInfo HNENKCBGPPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72702F0", Offset = "0x726E8F0", VA = "0x1872702F0")]
		public bool ICGNKNLANFM(CostInfo HNENKCBGPPB)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GOJBJBOAHDF
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
public interface EBKFKHBBDJO
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFEAJGFMKJN(JOGFEADJNLC AKDIBLFNNAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OONJEEBCCCL
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DKANFDCHFOJ
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
public enum JOGFEADJNLC
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
public enum HKDJPPNOKGE
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
public enum LAIGCIDAJEN
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum EFCLOFKOJBD
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
public enum LHLNNIPFCNL
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	LongPress
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
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
