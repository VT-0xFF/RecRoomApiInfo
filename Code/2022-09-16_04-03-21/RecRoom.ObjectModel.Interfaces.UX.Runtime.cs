using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MNDGADCPJDH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HCMFBCMKNCN
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Object = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Shape = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	CircuitsV1Group = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Animation = 3,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Curve = 4,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Circuits = 5,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Invalid = 65535
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KJJAKEEGNMK
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	CreateShape = 0,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Delete = 6,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Clone = 5,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Edit = 1,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Select = 2,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Scale = 4,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Move = 3,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Settings = 7,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Connect = 8,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	CreateObject = 9,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Repaint = 10,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Rotate = 12,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Disabled = 13,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Freeze = 14,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	OffHandCompanion = 15,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	CreateInventionInstance = 16,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Manipulate = 17,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	CreateInvention = 18,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CreateCircuitV2 = 19,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ClipboardPaste = 20,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Transform = 21,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Invalid = 65535
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CMIKKMKGLFC
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	StackPop
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HDKHAFBFCBJ : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	InvalidStateId = ushort.MaxValue
}
namespace RecRoom.Core.Creation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CostInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int inkCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int numChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int numCloudVariables;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CostInfo zero
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x4215080", Offset = "0x4213880", VA = "0x184215080")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x4215050", Offset = "0x4213850", VA = "0x184215050")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x4214FF0", Offset = "0x42137F0", VA = "0x184214FF0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4215020", Offset = "0x4213820", VA = "0x184215020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4214FD0", Offset = "0x42137D0", VA = "0x184214FD0")]
		public CostInfo(int KAKDOHHBCAM = 0, int LIPALHPJIND = 0, int FEDNIGACONC = 0, int ODJKCHMKPDA = 0, int DPBNLMCKPAH = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4214D30", Offset = "0x4213530", VA = "0x184214D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x42148E0", Offset = "0x42130E0", VA = "0x1842148E0", Slot = "0")]
		public override bool Equals(object DEGGOOGCHFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4214AC0", Offset = "0x42132C0", VA = "0x184214AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x42149A0", Offset = "0x42131A0", VA = "0x1842149A0")]
		public static CostInfo GAHCJAADICN(CostInfo JIOPFICDKKJ, CostInfo LIICKLLBPAE)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4214CB0", Offset = "0x42134B0", VA = "0x184214CB0")]
		public static FEEKEIIOJKL ODGEGOFLBNB(HCKFOHDECGK LHHDHFIBIHK)
		{
			return default(FEEKEIIOJKL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4214AF0", Offset = "0x42132F0", VA = "0x184214AF0")]
		public static string ILMNABOMLFJ(HCKFOHDECGK FNPLEFBJGJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4214C20", Offset = "0x4213420", VA = "0x184214C20")]
		public HCKFOHDECGK MKIDBPBGMJG(CostInfo MIOEJBDGNLN)
		{
			return default(HCKFOHDECGK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4214CA0", Offset = "0x42134A0", VA = "0x184214CA0")]
		public bool NFAHFLMEEIE(CostInfo MIOEJBDGNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4214880", Offset = "0x4213080", VA = "0x184214880")]
		public bool AMCBHDDAGCE(CostInfo MIOEJBDGNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4214D10", Offset = "0x4213510", VA = "0x184214D10")]
		public bool PMPFLANADKJ(CostInfo MIOEJBDGNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x42148A0", Offset = "0x42130A0", VA = "0x1842148A0")]
		public bool BFOMKMCGLEM(CostInfo MIOEJBDGNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x42148C0", Offset = "0x42130C0", VA = "0x1842148C0")]
		public bool DDJLGHMOFFP(CostInfo MIOEJBDGNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4214A30", Offset = "0x4213230", VA = "0x184214A30")]
		public static void GAIFFFPNLBG(BFPHBAFEECN DKGIMDGJHHP, CostInfo ADJPDHNIJBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4214BA0", Offset = "0x42133A0", VA = "0x184214BA0")]
		public static CostInfo MKGIMMLKPPH(BFPHBAFEECN DKGIMDGJHHP)
		{
			return default(CostInfo);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum HCKFOHDECGK
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Failure_OverInkLimit,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Failure_OverLightsLimit,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Failure_OverAiLimit,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Failure_OverChipLimit,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Failure_OverCloudVaraibleLimit
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AHABLEKJPML]
public enum FEEKEIIOJKL
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Failure_Generic,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Failure_NoAuthority,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Failure_ToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Failure_ObjectRequired,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Failure_ControlPanelRequired,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Failure_ConnectedToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Failure_LockedByOther,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Failure_HeldByOther,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Failure_SelectingFrozenTool,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Failure_SettingsChangedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Failure_InsufficientResources,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Failure_Parented,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Failure_ObjectDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Failure_ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Failure_ToolHeld,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Failure_NetworkError,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Failure_ObjectAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Failure_ToolNotEnabled,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Failure_PermissionDenied,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Failure_InvalidAction,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Failure_ObjectInUse,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Failure_MaxSpawnsUsed,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Failure_InsufficientLightResources,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Failure_ContainsDisallowedObjects,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Failure_ShapeContainerCapacity,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Failure_LockedByEditedGizmo,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Failure_InsufficientAiResources,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Failure_SpawnedObject,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Failure_CantEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Failure_InsufficientChipResources,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Failure_PlayerCantSpawnInventions,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Failure_InsufficientCloudVariableResources,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Failure_InventionContainsToolsThatExceedCreationLimit,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Failure_FeatureNotImplementedInObjectModel,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Failure_EmptyTemplate
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ELNBGPLGCPC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ALGEHPLKFIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CALAICLHOFI(KJJAKEEGNMK EIBICLOLALG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JBAOPAENEFB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(KJJAKEEGNMK EIBICLOLALG, Collider GMGOFDDELGL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BOFJKLDJJHG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(KJJAKEEGNMK EIBICLOLALG, Collider GMGOFDDELGL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NGKGOOMCEFO
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateFinished();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateFinished();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformFinished();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HDEBINNNFOM
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateStart();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateStart();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleStart();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformStart();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EMBNLECOKON
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotated();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaled();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformed(Vector3 GAIGPPCJABL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EPHAOIHEMNN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
