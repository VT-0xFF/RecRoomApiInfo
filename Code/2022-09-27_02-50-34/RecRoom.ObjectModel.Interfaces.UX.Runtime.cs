using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LDLGGAJKHJD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KJCODJONIJD
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
public enum IAOAKCGABMD
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
public enum IGEHMCBGCGL
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	StackPop
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PHCOJJFNFNP : ushort
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
			[Cpp2IlInjected.Address(RVA = "0x289AFD0", Offset = "0x289A1D0", VA = "0x18289AFD0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x289AFA0", Offset = "0x289A1A0", VA = "0x18289AFA0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x289AF40", Offset = "0x289A140", VA = "0x18289AF40")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x289AF70", Offset = "0x289A170", VA = "0x18289AF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x289AF20", Offset = "0x289A120", VA = "0x18289AF20")]
		public CostInfo(int IGAOOMMGGEC = 0, int HGGFHPIJCAO = 0, int GNAAFPNMEGD = 0, int FDNEGKPAOEF = 0, int EAAIBEAJFMP = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x289AC80", Offset = "0x2899E80", VA = "0x18289AC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x289A940", Offset = "0x2899B40", VA = "0x18289A940", Slot = "0")]
		public override bool Equals(object PBKPNJLDBOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x289AA00", Offset = "0x2899C00", VA = "0x18289AA00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x289A7D0", Offset = "0x28999D0", VA = "0x18289A7D0")]
		public static CostInfo ANJIEFFMCOH(CostInfo EEKKNFEKIDH, CostInfo IKFNBMEGJDC)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x289AC20", Offset = "0x2899E20", VA = "0x18289AC20")]
		public static MFLLLCEKAHD PCMBDCLELOK(MIDGNNOIBEO EANCPFCDNKA)
		{
			return default(MFLLLCEKAHD);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x289A860", Offset = "0x2899A60", VA = "0x18289A860")]
		public static string BBAFHMDOEPI(MIDGNNOIBEO LHPJBAGJLHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x289AA30", Offset = "0x2899C30", VA = "0x18289AA30")]
		public MIDGNNOIBEO JPEJMMHCBJM(CostInfo CMJCFDDBKPA)
		{
			return default(MIDGNNOIBEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x289A930", Offset = "0x2899B30", VA = "0x18289A930")]
		public bool DPGLHEPPJDO(CostInfo CMJCFDDBKPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x289AC00", Offset = "0x2899E00", VA = "0x18289AC00")]
		public bool OCHJHOPEOAP(CostInfo CMJCFDDBKPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x289A910", Offset = "0x2899B10", VA = "0x18289A910")]
		public bool DHDGCMKIDFF(CostInfo CMJCFDDBKPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x289ABE0", Offset = "0x2899DE0", VA = "0x18289ABE0")]
		public bool NOLOKCOLKFH(CostInfo CMJCFDDBKPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x289ABC0", Offset = "0x2899DC0", VA = "0x18289ABC0")]
		public bool NJGPCGEDEAF(CostInfo CMJCFDDBKPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x289AB30", Offset = "0x2899D30", VA = "0x18289AB30")]
		public static void MKFDCCHPJOF(KLJNHPCCJBI LIBGPCOHNDK, CostInfo FMLONMFLGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x289AAB0", Offset = "0x2899CB0", VA = "0x18289AAB0")]
		public static CostInfo KBDEICDJHDM(KLJNHPCCJBI LIBGPCOHNDK)
		{
			return default(CostInfo);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MIDGNNOIBEO
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
[DDHLINBIHCH]
public enum MFLLLCEKAHD
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
public interface CMHFKFLMOPC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IKNFEKLFFLE
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJENHOLFDBA(IAOAKCGABMD DHLALMFDKCG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FBBMIIFANOH
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(IAOAKCGABMD DHLALMFDKCG, Collider EPMOGACDOKL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DKKOOFONAKA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(IAOAKCGABMD DHLALMFDKCG, Collider EPMOGACDOKL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FPCFPEBDGDI
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
public interface AJIOLKHCOIP
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
public interface GGDJLGBIEIL
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
	void OnMakerPenDeformed(Vector3 FLMKNFAOGHD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HCKINPLKGON
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
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
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
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
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
