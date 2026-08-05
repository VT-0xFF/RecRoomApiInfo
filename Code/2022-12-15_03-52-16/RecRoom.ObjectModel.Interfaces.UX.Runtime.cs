using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum KJHFDCMLMND
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DEIBFPCHOHE
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
public enum LJAIHEPCGBK
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
public enum NAOIONBPDHH
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	StackPush,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	StackPop
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DDIMCEDLDCI : ushort
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
			[Cpp2IlInjected.Address(RVA = "0x609E8F0", Offset = "0x609D2F0", VA = "0x18609E8F0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x609E8D0", Offset = "0x609D2D0", VA = "0x18609E8D0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x609E880", Offset = "0x609D280", VA = "0x18609E880")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x609E8A0", Offset = "0x609D2A0", VA = "0x18609E8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x609E860", Offset = "0x609D260", VA = "0x18609E860")]
		public CostInfo(int CODHCJLFGIJ = 0, int GCLPJEILDDB = 0, int MGIFHEKNDHL = 0, int BGJHHJIEPPE = 0, int FFDNGJCJGLF = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x609E5B0", Offset = "0x609CFB0", VA = "0x18609E5B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x609E210", Offset = "0x609CC10", VA = "0x18609E210", Slot = "0")]
		public override bool Equals(object LGKNNMGLNIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x609E2D0", Offset = "0x609CCD0", VA = "0x18609E2D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x609E0E0", Offset = "0x609CAE0", VA = "0x18609E0E0")]
		public static CostInfo CPMGNAGFNGK(CostInfo ELOMOAANDAG, CostInfo LNCCLGDBCCL)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x609E550", Offset = "0x609CF50", VA = "0x18609E550")]
		public static GPDEFGLGABL LAHEGIONMNI(ANPIANKMDDD PFOBNCGLBFL)
		{
			return default(GPDEFGLGABL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x609E300", Offset = "0x609CD00", VA = "0x18609E300")]
		public static string HEEJBJMMLLE(ANPIANKMDDD BIDLMNEFHJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x609E4B0", Offset = "0x609CEB0", VA = "0x18609E4B0")]
		public ANPIANKMDDD JCCBACBBKGI(CostInfo IIEGBBGOHPK)
		{
			return default(ANPIANKMDDD);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x609E180", Offset = "0x609CB80", VA = "0x18609E180")]
		public bool DNEBKDJDMAI(CostInfo IIEGBBGOHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x609E160", Offset = "0x609CB60", VA = "0x18609E160")]
		public bool DGDOGOFDAPA(CostInfo IIEGBBGOHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x609E530", Offset = "0x609CF30", VA = "0x18609E530")]
		public bool JGPFMAFIMFL(CostInfo IIEGBBGOHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x609E490", Offset = "0x609CE90", VA = "0x18609E490")]
		public bool IHIJLFMFGDI(CostInfo IIEGBBGOHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x609E470", Offset = "0x609CE70", VA = "0x18609E470")]
		public bool IAKIBDNOMBL(CostInfo IIEGBBGOHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x609E3E0", Offset = "0x609CDE0", VA = "0x18609E3E0")]
		public static void HGEAPFIOPCC(PBIBIEGBJNI GKKMJLOKFKK, CostInfo DADFNPOPGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x609E190", Offset = "0x609CB90", VA = "0x18609E190")]
		public static CostInfo ELMNFJOMGJO(PBIBIEGBJNI GKKMJLOKFKK)
		{
			return default(CostInfo);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ANPIANKMDDD
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
[LILEEFHPLJA]
public enum GPDEFGLGABL
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
	Failure_EmptyTemplate,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Failure_CorruptSubgraph
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OGGPKGNKNOI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IAGNMGEIJEI
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFJIMHIAJEK(LJAIHEPCGBK NJHOKIAFKOI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HCKFHDCECPL
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(LJAIHEPCGBK NJHOKIAFKOI, Collider FGGPPABNNNE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NHIHAKEHOBI
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(LJAIHEPCGBK NJHOKIAFKOI, Collider FGGPPABNNNE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ELFPNBNAKND
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
public interface OFBOIOBJGJO
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
public interface DAPBNLLODCF
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
	void OnMakerPenDeformed(Vector3 BECIPDCMBPD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IPMPPNKBAKA
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
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
