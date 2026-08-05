using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FLHDLKHNKFN : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	InvalidStateId = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IHCMIPOGJDM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnDeselected();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[OGEPINIJGHJ]
public enum NJCONGMGGHJ
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
public interface NLJNEOCHIOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(DECOELBKPDM KHJHBGPDKIE, Collider MEGCMHCOMNK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum NPIHLCIJMBI
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
public interface OPAFIGKLJPF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(DECOELBKPDM KHJHBGPDKIE, Collider MEGCMHCOMNK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JLPODMBJPCF
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
	void OnMakerPenDeformed(Vector3 JEOCDCCAFKO);
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
			[Cpp2IlInjected.Address(RVA = "0x1941380", Offset = "0x1940180", VA = "0x181941380")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1941360", Offset = "0x1940160", VA = "0x181941360")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1941310", Offset = "0x1940110", VA = "0x181941310")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1941330", Offset = "0x1940130", VA = "0x181941330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x19412F0", Offset = "0x19400F0", VA = "0x1819412F0")]
		public CostInfo(int PGLNBOFOHIL = 0, int EEPOHEIGFDG = 0, int LDGDOMBILII = 0, int MOHOEIKBEFN = 0, int LEMDCKHNGOL = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1941040", Offset = "0x193FE40", VA = "0x181941040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1940D30", Offset = "0x193FB30", VA = "0x181940D30", Slot = "0")]
		public override bool Equals(object GNOEFMFMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1940E00", Offset = "0x193FC00", VA = "0x181940E00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1940C90", Offset = "0x193FA90", VA = "0x181940C90")]
		public static bool DDONPFMGGHF(CostInfo BKBNIEPHJOF, CostInfo ABGBEEGMBEI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1940C00", Offset = "0x193FA00", VA = "0x181940C00")]
		public static CostInfo COHLNPJMOAO(CostInfo BKBNIEPHJOF, CostInfo ABGBEEGMBEI)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1940F60", Offset = "0x193FD60", VA = "0x181940F60")]
		public static NJCONGMGGHJ NCMJKBPKFBH(NPIHLCIJMBI NLHDIIHHJCL)
		{
			return default(NJCONGMGGHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1940E50", Offset = "0x193FC50", VA = "0x181940E50")]
		public static string KMGDDALCKGL(NPIHLCIJMBI IFKOGMJAAJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1940FC0", Offset = "0x193FDC0", VA = "0x181940FC0")]
		public NPIHLCIJMBI NDEOEFKPIFD(CostInfo AOGIMNFPMCM)
		{
			return default(NPIHLCIJMBI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1940F50", Offset = "0x193FD50", VA = "0x181940F50")]
		public bool NABFHPKONAI(CostInfo AOGIMNFPMCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1940E30", Offset = "0x193FC30", VA = "0x181940E30")]
		public bool JFJADMKNJNG(CostInfo AOGIMNFPMCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1940F30", Offset = "0x193FD30", VA = "0x181940F30")]
		public bool MGDAPGJIHHP(CostInfo AOGIMNFPMCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1940BE0", Offset = "0x193F9E0", VA = "0x181940BE0")]
		public bool BDHOKBEGODN(CostInfo AOGIMNFPMCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1940D10", Offset = "0x193FB10", VA = "0x181940D10")]
		public bool DPPIDIFMNCB(CostInfo AOGIMNFPMCM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PAHDKAJOAPK
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
public interface GIKGKFNNLBI
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHDOJCENALI(DECOELBKPDM KHJHBGPDKIE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GNCPGFJAMPD
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OGHHIAOOMNP
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
public enum DECOELBKPDM
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
public enum MALCIHFMDJN
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
public enum LBPMCGDIDAA
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum GKOMLAPCEFC
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
public enum DMOCEGEPKPE
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	LongPress
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
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
