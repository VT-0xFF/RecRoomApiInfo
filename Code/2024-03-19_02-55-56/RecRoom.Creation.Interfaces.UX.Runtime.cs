using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum DCOOGBOMJHL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BOAIEGEPPJJ
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
public enum HFEDJLHGAIF
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
	Configure = 7,
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
public enum GOENCHEJGFO
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
public enum BJMHHGMJNCC
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	LongPress
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JCNJPMJCOMK : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	InvalidStateId = ushort.MaxValue
}
namespace RecRoom.Core.Creation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CostInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int inkCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int numChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int numCloudVariables;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CostInfo zero
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x610BA10", Offset = "0x610AA10", VA = "0x18610BA10")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x610B9F0", Offset = "0x610A9F0", VA = "0x18610B9F0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x610B9A0", Offset = "0x610A9A0", VA = "0x18610B9A0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x610B9C0", Offset = "0x610A9C0", VA = "0x18610B9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4630F80", Offset = "0x462FF80", VA = "0x184630F80")]
		public CostInfo(int NDKBLMBNLGM = 0, int LPHHCGIMBHO = 0, int CIBBGILHNMF = 0, int HEGFIEOIBJN = 0, int LBKHLJELJLL = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x610B720", Offset = "0x610A720", VA = "0x18610B720")]
		public static CostInfo PJDNDAGNFAM(int ILPBLMDFMIF)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x610B730", Offset = "0x610A730", VA = "0x18610B730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x610B3F0", Offset = "0x610A3F0", VA = "0x18610B3F0", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x610B510", Offset = "0x610A510", VA = "0x18610B510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x610B620", Offset = "0x610A620", VA = "0x18610B620")]
		public static bool INAKJEGDKIC(CostInfo ANEDMBANDAA, CostInfo NNCKPICGEOG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x610B380", Offset = "0x610A380", VA = "0x18610B380")]
		public static CostInfo BGAMHHCLDBC(CostInfo ANEDMBANDAA, CostInfo NNCKPICGEOG)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x610B4A0", Offset = "0x610A4A0", VA = "0x18610B4A0")]
		public static NANAKHAEKCF FIMFMALGHOH(DPJMPGBGINA NMGNHNPAFDH)
		{
			return default(NANAKHAEKCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x610B540", Offset = "0x610A540", VA = "0x18610B540")]
		public static string IHBHGJJDJCC(DPJMPGBGINA HEOGODCLBDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x610B690", Offset = "0x610A690", VA = "0x18610B690")]
		public DPJMPGBGINA KKEAPICGMEO(CostInfo BPNMDBKJDHK)
		{
			return default(DPJMPGBGINA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x610B3E0", Offset = "0x610A3E0", VA = "0x18610B3E0")]
		public bool DKMNAMBNLAB(CostInfo BPNMDBKJDHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x610B700", Offset = "0x610A700", VA = "0x18610B700")]
		public bool MCCCGEIFGDO(CostInfo BPNMDBKJDHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x610B710", Offset = "0x610A710", VA = "0x18610B710")]
		public bool MEFJCNGLHKK(CostInfo BPNMDBKJDHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x610B500", Offset = "0x610A500", VA = "0x18610B500")]
		public bool GBINKCJKCPO(CostInfo BPNMDBKJDHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x610B680", Offset = "0x610A680", VA = "0x18610B680")]
		public bool KJHFMGHCKEF(CostInfo BPNMDBKJDHK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DPJMPGBGINA
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Failure_OverInkLimit,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Failure_OverLightsLimit,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Failure_OverAiLimit,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Failure_OverChipLimit,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Failure_OverCloudVaraibleLimit
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[CAPMMOEKEFJ]
public enum NANAKHAEKCF
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Failure_Generic,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Failure_NoAuthority,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Failure_ToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Failure_ObjectRequired,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Failure_ControlPanelRequired,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Failure_ConnectedToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Failure_LockedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Failure_HeldByOther,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Failure_SelectingFrozenTool,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Failure_SettingsChangedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Failure_InsufficientResources,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Failure_Parented,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Failure_ObjectDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Failure_ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Failure_ToolHeld,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Failure_NetworkError,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Failure_ObjectAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Failure_ToolNotEnabled,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Failure_PermissionDenied,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Failure_InvalidAction,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Failure_ObjectInUse,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Failure_MaxSpawnsUsed,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Failure_InsufficientLightResources,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Failure_ContainsDisallowedObjects,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Failure_ShapeContainerCapacity,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Failure_LockedByEditedGizmo,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Failure_InsufficientAiResources,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Failure_SpawnedObject,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Failure_CantEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Failure_InsufficientChipResources,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Failure_PlayerCantSpawnInventions,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Failure_InsufficientCloudVariableResources,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Failure_InventionContainsToolsThatExceedCreationLimit,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Failure_FeatureNotImplementedInObjectModel,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Failure_EmptyTemplate,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Failure_CorruptSubgraph,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Failure_RateLimit,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Failure_RequestAlreadyInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Failure_LockedByRoomContributor,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Failure_DataTableInTrial,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Failure_DataTableSaveDenied,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Failure_DataTableSaveInsufficientPermissions,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Failure_TooManyExternalCircuitInputs,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Failure_TooManyExternalCircuitOutputs,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Failure_TooManyNestedCircuitBoards,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Failure_ObjectModelInCircuitBoardScope,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Failure_UgcVersionMismatch,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PartialSuccess_AllObjectsNotRooms2Compatible,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	PartialSuccess_SomeObjectsNotRooms2Compatible
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DKCJHPCDDEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x610BA20", Offset = "0x610AA20", VA = "0x18610BA20")]
	public static bool IDLDHJOEEKM(this NANAKHAEKCF HEOGODCLBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x610BA40", Offset = "0x610AA40", VA = "0x18610BA40")]
	public static bool NBFLMIPGABI(this NANAKHAEKCF HEOGODCLBDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JBFDDOOGFOO
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x610BA60", Offset = "0x610AA60", VA = "0x18610BA60")]
	public static string BMCGJLPJFLG(NANAKHAEKCF HEOGODCLBDD, IDMICLLCMKN MDFEPKEICAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CBCDKEBOGFH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JNMMKKECFFH
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(HFEDJLHGAIF BNPEDECBJLE, Collider KHFDPPDIAJD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHIHMNHPNKL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDHNGPMGMEB(HFEDJLHGAIF BNPEDECBJLE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FDGJECFOBKN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(HFEDJLHGAIF BNPEDECBJLE, Collider KHFDPPDIAJD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HKGJKCIDHPD
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslated();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotated();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaled();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformed(Vector3 KDANJHEKOIA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OOEOFIGPEFA
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateFinished();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateFinished();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformFinished();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NCDPHHPPLHK
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateStart();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateStart();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformStart();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IHKLDCJFAKH
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LCCIMHLHFIH
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LCCIMHLHFIH()
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
