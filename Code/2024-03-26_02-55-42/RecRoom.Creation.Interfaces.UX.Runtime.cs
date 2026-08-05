using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MJNECLNIKFL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Free,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Constrained
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FCNIGEKHFJE
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
public enum JIKJBMAJPLG
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
public enum OHENCDEHDCK
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
public enum BLKBHCJNKCK
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ShortPress,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	LongPress
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OBLDIBJHNFD : ushort
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
			[Cpp2IlInjected.Address(RVA = "0x6136AB0", Offset = "0x6135EB0", VA = "0x186136AB0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo OneChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6136A90", Offset = "0x6135E90", VA = "0x186136A90")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo ConvertVariableToCloud
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6136A40", Offset = "0x6135E40", VA = "0x186136A40")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsEntirelyZeroOrNegative
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6136A60", Offset = "0x6135E60", VA = "0x186136A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x46835D0", Offset = "0x46829D0", VA = "0x1846835D0")]
		public CostInfo(int HGIOGJCDJDL = 0, int LNDKGOAFBLL = 0, int JJAFKEOONED = 0, int KLJMDAEBKGK = 0, int PNMLKPIFMNI = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6136440", Offset = "0x6135840", VA = "0x186136440")]
		public static CostInfo CJDPFKCOJII(int IJPGOHILDCH)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61367D0", Offset = "0x6135BD0", VA = "0x1861367D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6136450", Offset = "0x6135850", VA = "0x186136450", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6136510", Offset = "0x6135910", VA = "0x186136510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61365A0", Offset = "0x61359A0", VA = "0x1861365A0")]
		public static bool IDILALBKFJC(CostInfo GGFGGNDIALB, CostInfo NFEHMEFHPGG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6136760", Offset = "0x6135B60", VA = "0x186136760")]
		public static CostInfo LDGADLBOPAE(CostInfo GGFGGNDIALB, CostInfo NFEHMEFHPGG)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6136540", Offset = "0x6135940", VA = "0x186136540")]
		public static ABMMODGFBCM HMKJBMGBEED(NCFNNCKGLFG EMAEALOIJBC)
		{
			return default(ABMMODGFBCM);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6136610", Offset = "0x6135A10", VA = "0x186136610")]
		public static string JPFFDGGKPLD(NCFNNCKGLFG FEADNEEPDLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61366F0", Offset = "0x6135AF0", VA = "0x1861366F0")]
		public NCFNNCKGLFG KBPFDCOLLMD(CostInfo MIJDFNKHOGH)
		{
			return default(NCFNNCKGLFG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61367C0", Offset = "0x6135BC0", VA = "0x1861367C0")]
		public bool NBPJFOOANIF(CostInfo MIJDFNKHOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6136430", Offset = "0x6135830", VA = "0x186136430")]
		public bool BMKGAKMHHBI(CostInfo MIJDFNKHOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6136500", Offset = "0x6135900", VA = "0x186136500")]
		public bool GKNMMHCFODK(CostInfo MIJDFNKHOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6136600", Offset = "0x6135A00", VA = "0x186136600")]
		public bool JCIOPCMHIHG(CostInfo MIJDFNKHOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6136420", Offset = "0x6135820", VA = "0x186136420")]
		public bool APEGFKINECB(CostInfo MIJDFNKHOGH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NCFNNCKGLFG
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
[MCCBEADDPDN]
public enum ABMMODGFBCM
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
public static class IBCDONJGMCP
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6136AE0", Offset = "0x6135EE0", VA = "0x186136AE0")]
	public static bool IKOEIGNOOOE(this ABMMODGFBCM FEADNEEPDLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6136AC0", Offset = "0x6135EC0", VA = "0x186136AC0")]
	public static bool DDMKEKOAKHD(this ABMMODGFBCM FEADNEEPDLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MPMGCKNFCHB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6136B00", Offset = "0x6135F00", VA = "0x186136B00")]
	public static string ACKCABGGBPD(ABMMODGFBCM FEADNEEPDLO, MKFCBDEMMMH AECJDCDOGJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JJIGLNJEJAF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BNAIGCOOGID
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHovering(JIKJBMAJPLG OCEABMAKHGP, Collider JMFEFAKGIAH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DOBGJNFLOEM
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIANBIPNMIP(JIKJBMAJPLG OCEABMAKHGP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LFJDMEELFGD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnMakerPenHoverStart(JIKJBMAJPLG OCEABMAKHGP, Collider JMFEFAKGIAH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DMNAKCMIFGJ
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
	void OnMakerPenDeformed(Vector3 IBEDLKDEBAL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AOADJFLEFAE
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
public interface GEGJEPLAKGM
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
public interface GOAHODMJBOG
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
public class GGOHFKMAPDD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public GGOHFKMAPDD()
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
