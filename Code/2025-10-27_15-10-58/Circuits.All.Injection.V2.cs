using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.All.Injection.V2;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
}
namespace Circuits.All.Injection.V2
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum DeprecationStage
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Active,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Deprecating,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Deprecated
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class InputPortConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[ReadOnlyField]
		[SerializeField]
		private string type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private string description;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public InputPortConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum NameSourceKind
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		FirstNodeDesc,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Code
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class NodeDescConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[ReadOnlyField]
		[SerializeField]
		private TypeParamConfig[] typeParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private InputPortConfig[] inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private OutputPortConfig[] outputs;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<InputPortConfig> Inputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<OutputPortConfig> Outputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7BC0", Offset = "0x2AF6BC0", VA = "0x182AF7BC0")]
		public NodeDescConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NodeFilter : ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[HideInInspector]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		public string[] FilterPath;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7C60", Offset = "0x2AF6C60", VA = "0x182AF7C60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class OutputPortConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ReadOnlyField]
		[SerializeField]
		private string type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private string description;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public OutputPortConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class PaletteItemConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class GKVBADAJPPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public string[] LYDYNCRJNCV;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public GKVBADAJPPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6530", Offset = "0x2AF5530", VA = "0x182AF6530")]
			internal string[] BJVURLLWCOD(NodeFilter a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Header("Palette Item")]
		[SerializeField]
		protected string paletteName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[Multiline(3)]
		protected string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		protected bool isBetaChip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		protected bool isValidInRoom1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		protected bool isValidInRoom2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		protected bool isHiddenInPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		protected bool isDevChip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		protected bool isStudioChip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Tooltip("If enabled, this chip will not be able to be spawned if the \"Remove Griefable Chips\" subroom setting is enabled")]
		protected bool isTrollingRisk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		[Tooltip("If enabled, this chip will not be able to be spawned by a user if their game role setting \"Can Spawn Role Assignment Chips\" is disabled")]
		protected bool isRoleAssignmentRisk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[ReadOnlyField]
		[SerializeField]
		protected ushort requiredChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		protected NodeFilter[] filters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("Toggle for all nodes and save in Unity to force them to reserialize. This field is unused in-game.")]
		private bool forceReserialize;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly string[] circuitsV2FilterPrefix;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string PaletteName
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IsBetaChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB31A30", Offset = "0xB30A30", VA = "0x180B31A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsValidInRoom1
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1024EC0", Offset = "0x1023EC0", VA = "0x181024EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsValidInRoom2
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1BAA230", Offset = "0x1BA9230", VA = "0x181BAA230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IsHiddenInPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x23B2330", Offset = "0x23B1330", VA = "0x1823B2330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IsDevChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xFEA550", Offset = "0xFE9550", VA = "0x180FEA550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsStudioChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xFEA0C0", Offset = "0xFE90C0", VA = "0x180FEA0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsTrollingRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2AF80B0", Offset = "0x2AF70B0", VA = "0x182AF80B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsRoleAssignmentRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2AF80A0", Offset = "0x2AF70A0", VA = "0x182AF80A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ushort RequiredChips
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x27B2510", Offset = "0x27B1510", VA = "0x1827B2510")]
			get
			{
				return default(ushort);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public abstract string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public abstract DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7CC0", Offset = "0x2AF6CC0", VA = "0x182AF7CC0")]
		public string[][] GetFilters()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7E10", Offset = "0x2AF6E10", VA = "0x182AF7E10")]
		private string[][] LPDTNTPIQCJ(string[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8030", Offset = "0x2AF7030", VA = "0x182AF8030")]
		protected PaletteItemConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public abstract class PaletteConfigDirectory<T> : ScriptableObject where T : PaletteItemConfig
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public sealed class PaletteItemConfigDictionary : EditableSerializedDictionary<SerializedGuid, T, PaletteItemConfigDictionary.Kvp>
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public sealed class Kvp : SerializedKeyVal<SerializedGuid, T>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				[ReadOnlyField]
				[SerializeField]
				public string ClassName;

				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x55C7510", Offset = "0x55C6510", VA = "0x1855C7510", Slot = "4")]
				public override void SYNCFMGXUBR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x5207320", Offset = "0x5206320", VA = "0x185207320")]
				public Kvp()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public Comparer<string> JDBHMZKKSZE;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x4235A50", Offset = "0x4234A50", VA = "0x184235A50")]
				internal int NKXAOUPLWXJ(Kvp a, Kvp b)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			protected override Comparison<Kvp> AMBLXBYUPIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x5DC1130", Offset = "0x5DC0130", VA = "0x185DC1130", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DC1230", Offset = "0x5DC0230", VA = "0x185DC1230", Slot = "14")]
			protected override string UXUXIRSOUQO(Kvp a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5DC12F0", Offset = "0x5DC02F0", VA = "0x185DC12F0")]
			public PaletteItemConfigDictionary()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		protected PaletteItemConfigDictionary paletteItemConfigs;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyDictionary<SerializedGuid, T> PaletteItemConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1080", Offset = "0x5DC0080", VA = "0x185DC1080")]
		public bool TryGetPaletteItemConfig([In] Guid guid, [Out] T config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xE15560", Offset = "0xE14560", VA = "0x180E15560")]
		protected PaletteConfigDirectory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class NXGQURYCNVX : DHDIWDIOMXF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly SpecificChipConfigDirectory NFDUUMTEXOC;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public abstract bool DDTWZZVEOAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public abstract bool AFLRROSRXKG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public abstract bool QNKWPUJJEDE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public abstract bool EWRAWICTZPE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract bool UMSMZCISEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract bool QEJMVDHKKZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected abstract int BEQCYFPXBRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		protected NXGQURYCNVX(SpecificChipConfigDirectory a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract bool FJACGZPPPRS(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract CanSaveObjectIntoInventionResultType ZQXOSHLARLH(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract bool LLOWHWFFRLS(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "20")]
		protected abstract bool AKAXPSPWHPQ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "21")]
		protected abstract bool MQYRMRRTMMP(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract bool BDQRUCLPMXI(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract bool BNQSLTKYCMB(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7800", Offset = "0x2AF6800", VA = "0x182AF7800", Slot = "8")]
		public bool TNNAFHOBQEI(Id128<ZOMVBRTCATC> nodeDefId, Id128<LNVRVOESCOU>? legacyInnerGraphId, IReadOnlyDictionary<Id128<LNVRVOESCOU>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7300", Offset = "0x2AF6300", VA = "0x182AF7300")]
		private bool TNNAFHOBQEI(Id128<ZOMVBRTCATC> a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF79B0", Offset = "0x2AF69B0", VA = "0x182AF79B0")]
		protected bool ZLQKNTFAQCH(Id128<ZOMVBRTCATC> a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7B00", Offset = "0x2AF6B00", VA = "0x182AF7B00", Slot = "9")]
		public bool ZLQKNTFAQCH(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF70C0", Offset = "0x2AF60C0", VA = "0x182AF70C0")]
		protected bool QVINZTYTAML(Id128<ZOMVBRTCATC> a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6EE0", Offset = "0x2AF5EE0", VA = "0x182AF6EE0", Slot = "10")]
		public bool QVINZTYTAML(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6780", Offset = "0x2AF5780", VA = "0x182AF6780")]
		protected bool AJLVQONCGDJ(Id128<ZOMVBRTCATC> a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6CD0", Offset = "0x2AF5CD0", VA = "0x182AF6CD0")]
		protected bool EICCTEPDIHC(Guid? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2AF65A0", Offset = "0x2AF55A0", VA = "0x182AF65A0", Slot = "25")]
		public bool ADYTEGLXYRB(Id128<ZOMVBRTCATC> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6850", Offset = "0x2AF5850", VA = "0x182AF6850")]
		protected bool CBXQLDIZRYO(Guid a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6AB0", Offset = "0x2AF5AB0", VA = "0x182AF6AB0")]
		protected bool CBXQLDIZRYO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6D70", Offset = "0x2AF5D70", VA = "0x182AF6D70")]
		private Guid? JDPZFVBMZXW(Id128<LNVRVOESCOU>? legacyInnerGraphId, IReadOnlyDictionary<Id128<LNVRVOESCOU>, Guid>? graphToToolMappings)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class SpecificChipConfig : PaletteItemConfig, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[ReadOnlyField]
		[SerializeField]
		private string chipName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private NameSourceKind paletteNameSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private NameSourceKind chipNameSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[ReadOnlyField]
		[SerializeField]
		private string className;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private SerializedGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private DeprecationStage deprecationStage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private NodeDescConfig[] nodeDescs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private bool isHiddenFromPaletteOnMicrophoneInputDisallowedPlatforms;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static int throughput;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string ChipName
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xACEE90", Offset = "0xACDE90", VA = "0x180ACEE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public NameSourceKind PaletteNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xFD7160", Offset = "0xFD6160", VA = "0x180FD7160")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NameSourceKind ChipNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x1F237B0", Offset = "0x1F227B0", VA = "0x181F237B0")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xACEBF0", Offset = "0xACDBF0", VA = "0x180ACEBF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public SerializedGuid SerializeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xACEBE0", Offset = "0xACDBE0", VA = "0x180ACEBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Guid NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8560", Offset = "0x2AF7560", VA = "0x182AF8560")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1351A90", Offset = "0x1350A90", VA = "0x181351A90", Slot = "5")]
			get
			{
				return default(DeprecationStage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<NodeDescConfig> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAD6740", Offset = "0xAD5740", VA = "0x180AD6740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool IsHiddenFromPaletteOnMicrophoneInputDisallowedPlatforms
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xE2C130", Offset = "0xE2B130", VA = "0x180E2C130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8420", Offset = "0x2AF7420", VA = "0x182AF8420")]
		public bool TryGetNodeDesc(int index, [Out] NodeDescConfig nodeDescConfig)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2AF81B0", Offset = "0x2AF71B0", VA = "0x182AF81B0", Slot = "6")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2AF84C0", Offset = "0x2AF74C0", VA = "0x182AF84C0")]
		public SpecificChipConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SpecificChipConfigDirectory : PaletteConfigDirectory<SpecificChipConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2AF80C0", Offset = "0x2AF70C0", VA = "0x182AF80C0")]
		public bool TryGetSpecificChipConfig([In] Guid guid, [Out] SpecificChipConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8170", Offset = "0x2AF7170", VA = "0x182AF8170")]
		public SpecificChipConfigDirectory()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class TypeParamConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[ReadOnlyField]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[ReadOnlyField]
		[SerializeField]
		private string type;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public TypeParamConfig()
		{
		}
	}
}
namespace RecRoom.CircuitsV2
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AssetReferenceCircuitTemplate : AssetReferenceT<CircuitsV2TemplateSerializedState>
	{
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class CircuitsV2TemplateSerializedState : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[HideInInspector]
		private byte[] template;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public CircuitTemplateRootData Template
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6480", Offset = "0x2AF5480", VA = "0x182AF6480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE15560", Offset = "0xE14560", VA = "0x180E15560")]
		public CircuitsV2TemplateSerializedState()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class CircuitTemplateConfig : PaletteItemConfig
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <GetTemplateData>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder<CircuitTemplateRootData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public CircuitTemplateConfig <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private AsyncOperationHandle<CircuitsV2TemplateSerializedState> <handle>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter<CircuitsV2TemplateSerializedState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8590", Offset = "0x2AF7590", VA = "0x182AF8590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8950", Offset = "0x2AF7950", VA = "0x182AF8950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Header("Template")]
		[SerializeField]
		private AssetReferenceCircuitTemplate templateAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private SerializedGuid templateId;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public SerializedGuid SerializeTemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xACEE70", Offset = "0xACDE70", VA = "0x180ACEE70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Id128<LDGFRKYMMZT> TemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6410", Offset = "0x2AF5410", VA = "0x182AF6410")]
			get
			{
				return default(Id128<LDGFRKYMMZT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6380", Offset = "0x2AF5380", VA = "0x182AF6380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "5")]
			get
			{
				return default(DeprecationStage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF61E0", Offset = "0x2AF51E0", VA = "0x182AF61E0")]
		[AsyncStateMachine(typeof(<GetTemplateData>d__10))]
		public Task<CircuitTemplateRootData> GetTemplateData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF62E0", Offset = "0x2AF52E0", VA = "0x182AF62E0")]
		public CircuitTemplateConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CircuitTemplateConfigDirectory : PaletteConfigDirectory<CircuitTemplateConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2AF60F0", Offset = "0x2AF50F0", VA = "0x182AF60F0")]
		public bool TryGetCircuitTemplateConfig([In] Id128<LDGFRKYMMZT> guid, [Out] CircuitTemplateConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2AF61A0", Offset = "0x2AF51A0", VA = "0x182AF61A0")]
		public CircuitTemplateConfigDirectory()
		{
		}
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
