using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GCHJBCJDCEC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FGKIPHHKFKK
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
public enum PKMFAGDOMLM
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
public enum BNAKJJOGKIH
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	StackPop
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GOJAACCMOOP : ushort
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
			[Cpp2IlInjected.Address(RVA = "0x58589C0", Offset = "0x58579C0", VA = "0x1858589C0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5858990", Offset = "0x5857990", VA = "0x185858990")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5858930", Offset = "0x5857930", VA = "0x185858930")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5858960", Offset = "0x5857960", VA = "0x185858960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5858910", Offset = "0x5857910", VA = "0x185858910")]
		public CostInfo(int NPMKEMNCJNA = 0, int OKDOJDGBKGN = 0, int OHOLBBFHMDD = 0, int ECHGDPBPFEN = 0, int LBFNPFADAPP = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5858670", Offset = "0x5857670", VA = "0x185858670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x58582B0", Offset = "0x58572B0", VA = "0x1858582B0", Slot = "0")]
		public override bool Equals(object MDAEAKFNGDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5858490", Offset = "0x5857490", VA = "0x185858490", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x58584C0", Offset = "0x58574C0", VA = "0x1858584C0")]
		public static CostInfo JCNGAANMENI(CostInfo JNJHAIDBMPL, CostInfo NGMKGMLIPAC)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5858570", Offset = "0x5857570", VA = "0x185858570")]
		public static GMIJJNFBJGA OOGIMKDEKFL(EHOJGKLKBAN JMPIBKEEMGC)
		{
			return default(GMIJJNFBJGA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x58581C0", Offset = "0x58571C0", VA = "0x1858581C0")]
		public static string BCMDLMDEJLN(EHOJGKLKBAN HCBFPGACPND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x58585F0", Offset = "0x58575F0", VA = "0x1858585F0")]
		public EHOJGKLKBAN PECDLNHOGIB(CostInfo KOOOLJDBHII)
		{
			return default(EHOJGKLKBAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5858480", Offset = "0x5857480", VA = "0x185858480")]
		public bool GBPDIIPBAAL(CostInfo KOOOLJDBHII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x58585D0", Offset = "0x58575D0", VA = "0x1858585D0")]
		public bool OPDDFDODDAA(CostInfo KOOOLJDBHII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5858290", Offset = "0x5857290", VA = "0x185858290")]
		public bool EDLIJHKLGHN(CostInfo KOOOLJDBHII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5858550", Offset = "0x5857550", VA = "0x185858550")]
		public bool KOLPJFIGKOE(CostInfo KOOOLJDBHII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5858270", Offset = "0x5857270", VA = "0x185858270")]
		public bool CIFALGKCJPF(CostInfo KOOOLJDBHII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x58583F0", Offset = "0x58573F0", VA = "0x1858583F0")]
		public static void FDIGCMAHEKM(FDIABGHMJIL PFEKJBNMPPM, CostInfo MIDFFODNPGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5858370", Offset = "0x5857370", VA = "0x185858370")]
		public static CostInfo FCKMMDJIHKF(FDIABGHMJIL PFEKJBNMPPM)
		{
			return default(CostInfo);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum EHOJGKLKBAN
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
[PNEMNJLACAG]
public enum GMIJJNFBJGA
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
	Failure_FeatureNotImplementedInObjectModel
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AJEKBJDKLAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KJCFDHPGDDP
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAIONKLAOHB(PKMFAGDOMLM OCJOAADOLIA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LGFBOKGGCEG
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(PKMFAGDOMLM OCJOAADOLIA, Collider BKOENGBELGL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AMAGMENGFII
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(PKMFAGDOMLM OCJOAADOLIA, Collider BKOENGBELGL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JFOEOBDCABI
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
public interface FDFIIHDOGAD
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
public interface IGOMBENFNNI
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
	void OnMakerPenDeformed(Vector3 OIMFAPKJMMA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JBPCEGBGIBK
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
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
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

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
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
