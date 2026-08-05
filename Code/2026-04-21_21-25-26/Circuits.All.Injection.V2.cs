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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<InputPortConfig> Inputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<OutputPortConfig> Outputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DB00", Offset = "0x2B2C500", VA = "0x182B2DB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2DBA0", Offset = "0x2B2C5A0", VA = "0x182B2DBA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		private sealed class LIXDUMZZAJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public string[] QQVBBMZKOGZ;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public LIXDUMZZAJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DA90", Offset = "0x2B2C490", VA = "0x182B2DA90")]
			internal string[] WINXAVTFWNN(NodeFilter a)
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
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IsBetaChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD6E8A0", Offset = "0xD6D2A0", VA = "0x180D6E8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsValidInRoom1
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF82FB0", Offset = "0xF819B0", VA = "0x180F82FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsValidInRoom2
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1AEC020", Offset = "0x1AEAA20", VA = "0x181AEC020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IsHiddenInPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2156BE0", Offset = "0x21555E0", VA = "0x182156BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IsDevChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF432C0", Offset = "0xF41CC0", VA = "0x180F432C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsStudioChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF43350", Offset = "0xF41D50", VA = "0x180F43350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsTrollingRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DFF0", Offset = "0x2B2C9F0", VA = "0x182B2DFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsRoleAssignmentRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B2DFE0", Offset = "0x2B2C9E0", VA = "0x182B2DFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ushort RequiredChips
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2581C70", Offset = "0x2580670", VA = "0x182581C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2DC00", Offset = "0x2B2C600", VA = "0x182B2DC00")]
		public string[][] GetFilters()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DD50", Offset = "0x2B2C750", VA = "0x182B2DD50")]
		private string[][] UTZDTCBZTAB(string[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DF70", Offset = "0x2B2C970", VA = "0x182B2DF70")]
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
				[Cpp2IlInjected.Address(RVA = "0x6945450", Offset = "0x6943E50", VA = "0x186945450", Slot = "4")]
				public override void ZMYCJYSZONZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x6474450", Offset = "0x6472E50", VA = "0x186474450")]
				public Kvp()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class KGMFPJNILMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public Comparer<string> DLGYJUCLCRE;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
				public KGMFPJNILMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x6847700", Offset = "0x6846100", VA = "0x186847700")]
				internal int FBDPLEKIWYP(Kvp a, Kvp b)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			protected override Comparison<Kvp> RYUHOSTFIWE
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x74F06C0", Offset = "0x74EF0C0", VA = "0x1874F06C0", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x74F0600", Offset = "0x74EF000", VA = "0x1874F0600", Slot = "14")]
			protected override string HQMNPCXPBIK(Kvp a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x74F07C0", Offset = "0x74EF1C0", VA = "0x1874F07C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74F0550", Offset = "0x74EEF50", VA = "0x1874F0550")]
		public bool TryGetPaletteItemConfig([In] Guid guid, [Out] T config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xDA5E70", Offset = "0xDA4870", VA = "0x180DA5E70")]
		protected PaletteConfigDirectory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class QUGFGEVVFRP : LABJXPUMTYX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly SpecificChipConfigDirectory BCXRNAYDFVE;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public abstract bool ZXFIUDHFAAY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public abstract bool GRDFWJDJDNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public abstract bool USJKCQQQZDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public abstract bool WKLMSNJSZDM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract bool TLORNLXNFCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract bool VXRMWIGDFQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected abstract int NNZDMSMXMZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		protected QUGFGEVVFRP(SpecificChipConfigDirectory a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract bool PCPJTXGNSAI(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract CanSaveObjectIntoInventionResultType FHYBNSAAEYR(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract bool QLAYCXJACWA(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "20")]
		protected abstract bool MXGCZWVNECO(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "21")]
		protected abstract bool GPOBCZAGFVB(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract bool DTZNDVSCPTU(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "23")]
		protected abstract bool RZMOPUMICQR(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E6A0", Offset = "0x2B2D0A0", VA = "0x182B2E6A0", Slot = "8")]
		public bool LJUSLRRQUYA(Id128<MIMXYJWAARO> nodeDefId, Id128<VFKNGTPUEMY>? legacyInnerGraphId, IReadOnlyDictionary<Id128<VFKNGTPUEMY>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E840", Offset = "0x2B2D240", VA = "0x182B2E840")]
		private bool LJUSLRRQUYA(Id128<MIMXYJWAARO> a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EED0", Offset = "0x2B2D8D0", VA = "0x182B2EED0")]
		protected bool OLVAISCVFZN(Id128<MIMXYJWAARO> a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EE10", Offset = "0x2B2D810", VA = "0x182B2EE10", Slot = "9")]
		public bool OLVAISCVFZN(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E280", Offset = "0x2B2CC80", VA = "0x182B2E280")]
		protected bool JPMABAPMGLN(Id128<MIMXYJWAARO> a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E4C0", Offset = "0x2B2CEC0", VA = "0x182B2E4C0", Slot = "10")]
		public bool JPMABAPMGLN(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B2ED40", Offset = "0x2B2D740", VA = "0x182B2ED40")]
		protected bool MSATTVHSGPZ(Id128<MIMXYJWAARO> a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E1E0", Offset = "0x2B2CBE0", VA = "0x182B2E1E0")]
		protected bool CCFANATFYQQ(Guid? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E000", Offset = "0x2B2CA00", VA = "0x182B2E000", Slot = "25")]
		public bool BXGZUHPINUP(Id128<MIMXYJWAARO> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F3B0", Offset = "0x2B2DDB0", VA = "0x182B2F3B0")]
		protected bool XZUHRDSPXBE(Guid a, Guid? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F190", Offset = "0x2B2DB90", VA = "0x182B2F190")]
		protected bool XZUHRDSPXBE(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F020", Offset = "0x2B2DA20", VA = "0x182B2F020")]
		private Guid? ONULLTMDMZG(Id128<VFKNGTPUEMY>? legacyInnerGraphId, IReadOnlyDictionary<Id128<VFKNGTPUEMY>, Guid>? graphToToolMappings)
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
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public NameSourceKind PaletteNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xF372E0", Offset = "0xF35CE0", VA = "0x180F372E0")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NameSourceKind ChipNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x154CB60", Offset = "0x154B560", VA = "0x18154CB60")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public SerializedGuid SerializeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B40", Offset = "0xD10540", VA = "0x180D11B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Guid NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2B2FAB0", Offset = "0x2B2E4B0", VA = "0x182B2FAB0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x12A9490", Offset = "0x12A7E90", VA = "0x1812A9490", Slot = "5")]
			get
			{
				return default(DeprecationStage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<NodeDescConfig> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xD1E8A0", Offset = "0xD1D2A0", VA = "0x180D1E8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool IsHiddenFromPaletteOnMicrophoneInputDisallowedPlatforms
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD7C6F0", Offset = "0xD7B0F0", VA = "0x180D7C6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F970", Offset = "0x2B2E370", VA = "0x182B2F970")]
		public bool TryGetNodeDesc(int index, [Out] NodeDescConfig nodeDescConfig)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F700", Offset = "0x2B2E100", VA = "0x182B2F700", Slot = "6")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FA10", Offset = "0x2B2E410", VA = "0x182B2FA10")]
		public SpecificChipConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SpecificChipConfigDirectory : PaletteConfigDirectory<SpecificChipConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F610", Offset = "0x2B2E010", VA = "0x182B2F610")]
		public bool TryGetSpecificChipConfig([In] Guid guid, [Out] SpecificChipConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F6C0", Offset = "0x2B2E0C0", VA = "0x182B2F6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B2D9E0", Offset = "0x2B2C3E0", VA = "0x182B2D9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xDA5E70", Offset = "0xDA4870", VA = "0x180DA5E70")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B2FAE0", Offset = "0x2B2E4E0", VA = "0x182B2FAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2B2FEA0", Offset = "0x2B2E8A0", VA = "0x182B2FEA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Id128<DFHUUHJHTNP> TemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D970", Offset = "0x2B2C370", VA = "0x182B2D970")]
			get
			{
				return default(Id128<DFHUUHJHTNP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D8E0", Offset = "0x2B2C2E0", VA = "0x182B2D8E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "5")]
			get
			{
				return default(DeprecationStage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D740", Offset = "0x2B2C140", VA = "0x182B2D740")]
		[AsyncStateMachine(typeof(<GetTemplateData>d__10))]
		public Task<CircuitTemplateRootData> GetTemplateData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D840", Offset = "0x2B2C240", VA = "0x182B2D840")]
		public CircuitTemplateConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CircuitTemplateConfigDirectory : PaletteConfigDirectory<CircuitTemplateConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D650", Offset = "0x2B2C050", VA = "0x182B2D650")]
		public bool TryGetCircuitTemplateConfig([In] Id128<DFHUUHJHTNP> guid, [Out] CircuitTemplateConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D700", Offset = "0x2B2C100", VA = "0x182B2D700")]
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
