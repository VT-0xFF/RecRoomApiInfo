using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecNet.Rooms;
using RecRoom.Build;
using RecRoom.Networking.DataTypes;
using RecRoom.Tools;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class XZYMFDMNRDD
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
	public XZYMFDMNRDD()
	{
	}
}
namespace RecRoom.Tools
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum ConstraintMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Free,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Constrained
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum TargetMode
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Object,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Shape,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		CircuitsV1Group,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		Animation,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Curve,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Circuits
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum ToolMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		CreateShape = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Delete = 6,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Clone = 5,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Edit = 1,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Select = 2,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Scale = 4,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Move = 3,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Configure = 7,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Connect = 8,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		CreateObject = 9,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Repaint = 10,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Rotate = 12,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Disabled = 13,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Freeze = 14,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		OffHandCompanion = 15,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		CreateInventionInstance = 16,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Manipulate = 17,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		CreateInvention = 18,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		CreateCircuitV2 = 19,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		ClipboardPaste = 20,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Transform = 21,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		NewMove = 22,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Palette = 23,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		None = 24
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ToolModeChangeReason
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		StackPush,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		StackPop,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Force
	}
}
namespace RecRoom.Tools.MakerPenTools
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum InteractionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		ShortPress,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		LongPress
	}
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
		public static CostInfo RIUZTZRAIKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8179480", Offset = "0x8177C80", VA = "0x188179480")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo JIEVDZSZQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8179A90", Offset = "0x8178290", VA = "0x188179A90")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo EJERNDDPOJS
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8179B10", Offset = "0x8178310", VA = "0x188179B10")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ITFGFDKMCTH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x81796E0", Offset = "0x8177EE0", VA = "0x1881796E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2D0DCF0", Offset = "0x2D0C4F0", VA = "0x182D0DCF0")]
		public CostInfo(int inkCost = 0, int lightsCost = 0, int aiCost = 0, int numChips = 0, int numCloudVariables = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8179720", Offset = "0x8177F20", VA = "0x188179720")]
		public static CostInfo KBAKORGILNP(int a)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8179790", Offset = "0x8177F90", VA = "0x188179790")]
		public static CostInfo RQBIIOJAFUW(int a)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8179820", Offset = "0x8178020", VA = "0x188179820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8179590", Offset = "0x8177D90", VA = "0x188179590", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81796B0", Offset = "0x8177EB0", VA = "0x1881796B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8179640", Offset = "0x8177E40", VA = "0x188179640")]
		public static bool FYOQTCVQVIR(CostInfo a, CostInfo b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8179AB0", Offset = "0x81782B0", VA = "0x188179AB0")]
		public static CostInfo VUDHLVIBKUN(CostInfo a, CostInfo b)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8179730", Offset = "0x8177F30", VA = "0x188179730")]
		public static CreationResult NVFYJLYIMVM(CostInfoResult a)
		{
			return default(CreationResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8179490", Offset = "0x8177C90", VA = "0x188179490")]
		public static string CGLKSMCOIEE(CostInfoResult a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81797B0", Offset = "0x8177FB0", VA = "0x1881797B0")]
		public CostInfoResult TEZMPNRGVYY(CostInfo a)
		{
			return default(CostInfoResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8179580", Offset = "0x8177D80", VA = "0x188179580")]
		public bool EOGTZRQIHXQ(CostInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8179B30", Offset = "0x8178330", VA = "0x188179B30")]
		public bool ZQJLBZIOBUD(CostInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81796A0", Offset = "0x8177EA0", VA = "0x1881796A0")]
		public bool GFXTOQCUOWO(CostInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8179570", Offset = "0x8177D70", VA = "0x188179570")]
		public bool DSKKJHYWXEO(CostInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8179710", Offset = "0x8177F10", VA = "0x188179710")]
		public bool IDLRLUBOWZP(CostInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum CostInfoResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Failure_OverInkLimit,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		Failure_OverLightsLimit,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Failure_OverAiLimit,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Failure_OverChipLimit,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Failure_OverCloudVaraibleLimit
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DisallowSerialization]
	public enum CreationResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Failure_Generic,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Failure_NoAuthority,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Failure_ToolFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Failure_ObjectRequired,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Failure_ControlPanelRequired,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Failure_ConnectedToolFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Failure_LockedByOther,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Failure_HeldByOther,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Failure_SelectingFrozenTool,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Failure_SettingsChangedByOther,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Failure_InsufficientResources,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Failure_Parented,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Failure_ObjectDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Failure_ParentChanged,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		Failure_ToolHeld,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Failure_NetworkError,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Failure_ObjectAlreadyExists,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Failure_ToolNotEnabled,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Failure_PermissionDenied,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Failure_InvalidAction,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Failure_ObjectInUse,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Failure_MaxSpawnsUsed,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Failure_InsufficientLightResources,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Failure_ContainsDisallowedObjects,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Failure_ShapeContainerCapacity,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Failure_LockedByEditedGizmo,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Failure_InsufficientAiResources,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Failure_SpawnedObject,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Failure_CantEditWithMakerPen,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Failure_InsufficientChipResources,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Failure_PlayerCantSpawnInventions,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Failure_InsufficientCloudVariableResources,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Failure_InventionContainsToolsThatExceedCreationLimit,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Failure_FeatureNotImplementedInObjectModel,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Failure_EmptyTemplate,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Failure_CorruptSubgraph,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Failure_RateLimit,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Failure_RequestAlreadyInProgress,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Failure_LockedByRoomContributor,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Failure_DataTableInTrial,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Failure_DataTableSaveDenied,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Failure_DataTableSaveInsufficientPermissions,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Failure_TooManyExternalCircuitInputs,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Failure_TooManyExternalCircuitOutputs,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Failure_TooManyNestedCircuitBoards,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Failure_ObjectModelInCircuitBoardScope,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Failure_SpawningShapeWithoutValidShapeContainer,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Failure_UgcVersionMismatch,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		PartialSuccess_AllObjectsNotRooms2Compatible,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		PartialSuccess_SomeObjectsNotRooms2Compatible,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Failure_CircuitsVersioning,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Failure_NodesNotAllowedInTargetGraph,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Failure_SyncedVariablesNotAllowedInTargetGraph,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Failure_Disembodied,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Failure_InventionRIOCopyFailure,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Failure_TooComplexToClone,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Failure_StudioContentNotReadyForDevice,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		Failure_StudioContentDownloadFailed,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Failure_InventionCannotBeTokenSpawned,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Failure_InventionTokenInvalid
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ECMKNMDNUEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8179B60", Offset = "0x8178360", VA = "0x188179B60")]
		public static bool Succeeded(this CreationResult result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8179B40", Offset = "0x8178340", VA = "0x188179B40")]
		public static bool Failed(this CreationResult result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class EZXMAWUILUL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8179B80", Offset = "0x8178380", VA = "0x188179B80")]
		public static string QEODVHICAFL(CreationResult a, RHIZVYSCBOY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x817A460", Offset = "0x8178C60", VA = "0x18817A460")]
		public static string QTYZMNJWDGJ(AssetBundleLoadSource a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface SWJHLIGDPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnCreatedBySpawning();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MCZKVCPTDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnMakerPenHovering(ToolMode toolMode, Collider hitCollider);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface CQRYDQPUGQZ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NHVVCSZMVPR(ToolMode a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface VQYAXKPBUHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnMakerPenHoverStart(ToolMode toolMode, Collider hitCollider);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface YBNIJDNNQNN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnMakerPenTranslated();

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnMakerPenRotated();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnMakerPenScaled();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnMakerPenDeformed(Vector3 previousPosition);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface EDBKSSTNMRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnMakerPenTranslateFinished();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnMakerPenRotateFinished();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnMakerPenScaleFinished();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnMakerPenDeformFinished();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface FTGEHNAULRD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnMakerPenTranslateStart();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnMakerPenRotateStart();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnMakerPenScaleStart();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnMakerPenDeformStart();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface GIVQUHRKZZM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnSelected();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnDeselected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface SYYSRPUEZFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnCreatedFromTemplate();
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
