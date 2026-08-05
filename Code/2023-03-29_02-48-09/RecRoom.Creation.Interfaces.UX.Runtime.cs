using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JKLPIOIEENL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KACBCADPMAP
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
public enum PEKAACNJCJM
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
public enum DJDMMKPELGM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	StackPop
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum COMMOPLNNFN
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	LongPress
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JMAJBHGNLFD : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	InvalidStateId = ushort.MaxValue
}
namespace RecRoom.Core.Creation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CostInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int inkCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int numChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int numCloudVariables;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static CostInfo zero
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x663E210", Offset = "0x663D010", VA = "0x18663E210")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x663E1F0", Offset = "0x663CFF0", VA = "0x18663E1F0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x663E1A0", Offset = "0x663CFA0", VA = "0x18663E1A0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x663E1C0", Offset = "0x663CFC0", VA = "0x18663E1C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x663E180", Offset = "0x663CF80", VA = "0x18663E180")]
		public CostInfo(int IDEBHIDPBMB = 0, int FKMMPDEBEDJ = 0, int FFGFPLHGKBE = 0, int PCOEIGIIHPK = 0, int FGMIECLODBJ = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x663DED0", Offset = "0x663CCD0", VA = "0x18663DED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x663DB60", Offset = "0x663C960", VA = "0x18663DB60", Slot = "0")]
		public override bool Equals(object BLIKPCIFNNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x663DC20", Offset = "0x663CA20", VA = "0x18663DC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x663DAC0", Offset = "0x663C8C0", VA = "0x18663DAC0")]
		public static CostInfo DHHECOJPLIP(CostInfo LDKAJLPHENP, CostInfo IIKHNLNCKBC)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x663DC50", Offset = "0x663CA50", VA = "0x18663DC50")]
		public static BIOMIAEILNL ILPAFPDFPOI(APJHJINKDOK IEPMOKEBCEB)
		{
			return default(BIOMIAEILNL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x663DD60", Offset = "0x663CB60", VA = "0x18663DD60")]
		public static string NPMDEOOBOAP(APJHJINKDOK DGEANHLCFIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x663DA40", Offset = "0x663C840", VA = "0x18663DA40")]
		public APJHJINKDOK ANKFEPAOKEL(CostInfo EKHKCCDCCNK)
		{
			return default(APJHJINKDOK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x663DCD0", Offset = "0x663CAD0", VA = "0x18663DCD0")]
		public bool KIFDKGNGJLC(CostInfo EKHKCCDCCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x663DA00", Offset = "0x663C800", VA = "0x18663DA00")]
		public bool AIFAMKFJCGL(CostInfo EKHKCCDCCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x663DCB0", Offset = "0x663CAB0", VA = "0x18663DCB0")]
		public bool JOIMACJEHNF(CostInfo EKHKCCDCCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x663DB40", Offset = "0x663C940", VA = "0x18663DB40")]
		public bool DLONEDHKPHP(CostInfo EKHKCCDCCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x663DA20", Offset = "0x663C820", VA = "0x18663DA20")]
		public bool ANBABFHOMLM(CostInfo EKHKCCDCCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x663DE40", Offset = "0x663CC40", VA = "0x18663DE40")]
		public static void PPPABFGDOPB(AIDLDPNCNPK BNIDHINABIH, CostInfo PFLDDMPBBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x663DCE0", Offset = "0x663CAE0", VA = "0x18663DCE0")]
		public static CostInfo LEOJOGDGNIH(AIDLDPNCNPK BNIDHINABIH)
		{
			return default(CostInfo);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum APJHJINKDOK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Failure_OverInkLimit,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Failure_OverLightsLimit,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Failure_OverAiLimit,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Failure_OverChipLimit,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Failure_OverCloudVaraibleLimit
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[JNIDHNELDBK]
public enum BIOMIAEILNL
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Failure_Generic,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Failure_NoAuthority,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Failure_ToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Failure_ObjectRequired,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Failure_ControlPanelRequired,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Failure_ConnectedToolFrozen,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Failure_LockedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Failure_HeldByOther,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Failure_SelectingFrozenTool,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Failure_SettingsChangedByOther,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Failure_InsufficientResources,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Failure_Parented,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Failure_ObjectDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Failure_ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Failure_ToolHeld,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Failure_NetworkError,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Failure_ObjectAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Failure_ToolNotEnabled,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Failure_PermissionDenied,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Failure_InvalidAction,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Failure_ObjectInUse,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Failure_MaxSpawnsUsed,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Failure_InsufficientLightResources,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Failure_ContainsDisallowedObjects,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Failure_ShapeContainerCapacity,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Failure_LockedByEditedGizmo,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Failure_InsufficientAiResources,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Failure_SpawnedObject,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Failure_CantEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Failure_InsufficientChipResources,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Failure_PlayerCantSpawnInventions,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Failure_InsufficientCloudVariableResources,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Failure_InventionContainsToolsThatExceedCreationLimit,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Failure_FeatureNotImplementedInObjectModel,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Failure_EmptyTemplate,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Failure_CorruptSubgraph,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Failure_RateLimit,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Failure_RequestAlreadyInProgress
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AJDFHFGJMEC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AOOPPPBAGJG
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBFJPFCMAIK(PEKAACNJCJM BPNFPPBBEBL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NHOFELONMDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(PEKAACNJCJM BPNFPPBBEBL, Collider BDNKKMLBEFO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EABIJGNEDEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(PEKAACNJCJM BPNFPPBBEBL, Collider BDNKKMLBEFO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DEJNCNGMCBF
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
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PPCAHCJABKF
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
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KCPONIMNNLH
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
	void OnMakerPenDeformed(Vector3 DDAMABBCJAG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PEEPPOEGJEH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
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
