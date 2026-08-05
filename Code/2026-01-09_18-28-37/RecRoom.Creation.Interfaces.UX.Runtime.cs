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
internal class TSDLEFRRTSA
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
	[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
	public TSDLEFRRTSA()
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
		public static CostInfo LEOVPOMMEOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8149880", Offset = "0x8148C80", VA = "0x188149880")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CostInfo ZTIDRCODXJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x81499C0", Offset = "0x8148DC0", VA = "0x1881499C0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static CostInfo TEMPZBJJMAR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x81497F0", Offset = "0x8148BF0", VA = "0x1881497F0")]
			get
			{
				return default(CostInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MULHFBOXXTK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8149980", Offset = "0x8148D80", VA = "0x188149980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2D18B00", Offset = "0x2D17F00", VA = "0x182D18B00")]
		public CostInfo(int inkCost = 0, int lightsCost = 0, int aiCost = 0, int numChips = 0, int numCloudVariables = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8149A50", Offset = "0x8148E50", VA = "0x188149A50")]
		public static CostInfo OGFELXUBAWS(int a)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8149A60", Offset = "0x8148E60", VA = "0x188149A60")]
		public static CostInfo QVLGJCCWHFP(int a)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8149AF0", Offset = "0x8148EF0", VA = "0x188149AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8149890", Offset = "0x8148C90", VA = "0x188149890", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8149950", Offset = "0x8148D50", VA = "0x188149950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81499E0", Offset = "0x8148DE0", VA = "0x1881499E0")]
		public static bool NAQFJJXEQSO(CostInfo a, CostInfo b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8149A90", Offset = "0x8148E90", VA = "0x188149A90")]
		public static CostInfo SYVIVGFMWIG(CostInfo a, CostInfo b)
		{
			return default(CostInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8149D70", Offset = "0x8149170", VA = "0x188149D70")]
		public static CreationResult ZFCHUZNFSRR(CostInfoResult a)
		{
			return default(CreationResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8149710", Offset = "0x8148B10", VA = "0x188149710")]
		public static string BGHQBAHKWQX(CostInfoResult a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8149810", Offset = "0x8148C10", VA = "0x188149810")]
		public CostInfoResult EIAIYVHEJET(CostInfo a)
		{
			return default(CostInfoResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8149A40", Offset = "0x8148E40", VA = "0x188149A40")]
		public bool ODSFVSRJIBZ(CostInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8149940", Offset = "0x8148D40", VA = "0x188149940")]
		public bool FRCGYMGYCAA(CostInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81499B0", Offset = "0x8148DB0", VA = "0x1881499B0")]
		public bool HPNFIJQFEWV(CostInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8149A80", Offset = "0x8148E80", VA = "0x188149A80")]
		public bool RXBVGSMXOTH(CostInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8149D60", Offset = "0x8149160", VA = "0x188149D60")]
		public bool YYSAXTHXDSM(CostInfo a)
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
	public static class YXUNYNZHPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x814A760", Offset = "0x8149B60", VA = "0x18814A760")]
		public static bool Succeeded(this CreationResult result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x814A740", Offset = "0x8149B40", VA = "0x18814A740")]
		public static bool Failed(this CreationResult result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class SZSHPVYXYLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8149DD0", Offset = "0x81491D0", VA = "0x188149DD0")]
		public static string GSUVAXXURWS(CreationResult a, JDMCEZTJJPL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x814A6B0", Offset = "0x8149AB0", VA = "0x18814A6B0")]
		public static string LUVFQQQDRHW(AssetBundleLoadSource a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface LBLZYPWTXWS
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnCreatedBySpawning();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FELHQZJYOHY
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnMakerPenHovering(ToolMode toolMode, Collider hitCollider);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface CNBBAADQOWQ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HQZAPVXCADK(ToolMode a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface QOSIDLCDTUO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnMakerPenHoverStart(ToolMode toolMode, Collider hitCollider);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface GNWWRCFIRRE
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
	public interface UJYCLDBEYGU
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
	public interface QQYFPKAXOPY
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
	public interface KZXUXUUHHKR
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnSelected();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnDeselected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KJNLDJRAEON
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
