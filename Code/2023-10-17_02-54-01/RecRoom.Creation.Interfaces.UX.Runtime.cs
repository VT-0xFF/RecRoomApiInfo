using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JHKIEAIBOAG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MPDEAHKALBC
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
public enum IPCCGGHPPBB
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
public enum EOJPEAMKILC
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
public enum KDPMNIECBBO
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	LongPress
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LMGIOMOEJDD : ushort
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
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5C77850", Offset = "0x5C76050", VA = "0x185C77850")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5C77830", Offset = "0x5C76030", VA = "0x185C77830")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5C777E0", Offset = "0x5C75FE0", VA = "0x185C777E0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5C77800", Offset = "0x5C76000", VA = "0x185C77800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5C777C0", Offset = "0x5C75FC0", VA = "0x185C777C0")]
		public CostInfo(int ILEIFMLAIIP = 0, int JLMOMLJIFPM = 0, int JECKBMOMFNA = 0, int JPFPBIFMEME = 0, int AMFAJJIMKAN = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C77550", Offset = "0x5C75D50", VA = "0x185C77550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5C77230", Offset = "0x5C75A30", VA = "0x185C77230", Slot = "0")]
		public override bool Equals(object CBBCDNDPNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5C772E0", Offset = "0x5C75AE0", VA = "0x185C772E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C771B0", Offset = "0x5C759B0", VA = "0x185C771B0")]
		public static bool BIBGNMIHGGC(CostInfo HMCGPNBPCEP, CostInfo LHHJADNIACD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C773F0", Offset = "0x5C75BF0", VA = "0x185C773F0")]
		public static CostInfo KMOGMICJDHO(CostInfo HMCGPNBPCEP, CostInfo LHHJADNIACD)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C77310", Offset = "0x5C75B10", VA = "0x185C77310")]
		public static PAPOFIBDOFD HHKNFLGOANH(LEFCOAFJBJE JIDLABOHFAA)
		{
			return default(PAPOFIBDOFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C77450", Offset = "0x5C75C50", VA = "0x185C77450")]
		public static string LDEAJIPOING(LEFCOAFJBJE KMHAEDONIKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C77380", Offset = "0x5C75B80", VA = "0x185C77380")]
		public LEFCOAFJBJE JNBPEFFKHIB(CostInfo AFAAHPNHKKB)
		{
			return default(LEFCOAFJBJE);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C77220", Offset = "0x5C75A20", VA = "0x185C77220")]
		public bool ECNGKOOPNBD(CostInfo AFAAHPNHKKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C77370", Offset = "0x5C75B70", VA = "0x185C77370")]
		public bool JEEFEIEDADH(CostInfo AFAAHPNHKKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C77210", Offset = "0x5C75A10", VA = "0x185C77210")]
		public bool DAKPCGHOIOK(CostInfo AFAAHPNHKKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5C77540", Offset = "0x5C75D40", VA = "0x185C77540")]
		public bool PJELPCDBFMJ(CostInfo AFAAHPNHKKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C77530", Offset = "0x5C75D30", VA = "0x185C77530")]
		public bool OPNCGOFDAIJ(CostInfo AFAAHPNHKKB)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LEFCOAFJBJE
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
[LDMOCPKBGGG]
public enum PAPOFIBDOFD
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
	Failure_DataTableSaveInsufficientPermissions
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DJAGPFBFPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C77860", Offset = "0x5C76060", VA = "0x185C77860")]
	public static string BABLHIPCFPH(PAPOFIBDOFD KMHAEDONIKI, JLNLBCDKCMG DGJJFAPHLNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HIMECIGALDD
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CIJCLMLJEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(IPCCGGHPPBB MALCGCJDOHD, Collider BJIDMFJACFC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OKNCFIMCPAB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGCGKNDNBMD(IPCCGGHPPBB MALCGCJDOHD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ICJOIKGIJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(IPCCGGHPPBB MALCGCJDOHD, Collider BJIDMFJACFC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HJFEJDOBALI
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotated();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaled();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformed(Vector3 MPPNDNOCJJH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BIFCICLNCDO
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateFinished();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateFinished();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformFinished();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AMLMKEPLJGN
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenTranslateStart();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnMakerPenRotateStart();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnMakerPenScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnMakerPenDeformStart();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LICLENLBBAL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CAANBFNPALO
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CAANBFNPALO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
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
