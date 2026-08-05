using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.All.Injection.V2;
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
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
		[SerializeField]
		[ReadOnlyField]
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
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<InputPortConfig> Inputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<OutputPortConfig> Outputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2903DA0", Offset = "0x29023A0", VA = "0x182903DA0")]
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
		[HideInInspector]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		public string[] FilterPath;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2903E40", Offset = "0x2902440", VA = "0x182903E40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
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
		[SerializeField]
		[ReadOnlyField]
		private string type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private string description;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
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
		private sealed class IIOIPFPHAKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public string[] prefix;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public IIOIPFPHAKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2903D30", Offset = "0x2902330", VA = "0x182903D30")]
			internal string[] PINDLCLOJGD(NodeFilter i)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[Header("Palette Item")]
		protected string paletteName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Multiline(3)]
		[SerializeField]
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
		[Tooltip("If enabled, this chip will not be able to be spawned if the \"Remove Griefable Chips\" subroom setting is enabled")]
		[SerializeField]
		protected bool isTrollingRisk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("If enabled, this chip will not be able to be spawned by a user if their game role setting \"Can Spawn Role Assignment Chips\" is disabled")]
		[SerializeField]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IsBetaChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA73440", Offset = "0xA71A40", VA = "0x180A73440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsValidInRoom1
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xE83260", Offset = "0xE81860", VA = "0x180E83260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsValidInRoom2
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1BC3390", Offset = "0x1BC1990", VA = "0x181BC3390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IsHiddenInPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x29042E0", Offset = "0x29028E0", VA = "0x1829042E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IsDevChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xE34390", Offset = "0xE32990", VA = "0x180E34390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsStudioChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE34150", Offset = "0xE32750", VA = "0x180E34150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsTrollingRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1562D70", Offset = "0x1561370", VA = "0x181562D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsRoleAssignmentRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x29042F0", Offset = "0x29028F0", VA = "0x1829042F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ushort RequiredChips
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xDE8720", Offset = "0xDE6D20", VA = "0x180DE8720")]
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
		[Cpp2IlInjected.Address(RVA = "0x2904040", Offset = "0x2902640", VA = "0x182904040")]
		public string[][] GAAEPOCEEPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2903EA0", Offset = "0x29024A0", VA = "0x182903EA0")]
		private string[][] AGLBGEELKNE(string[] GDFBBGHAAKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2904270", Offset = "0x2902870", VA = "0x182904270")]
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
				[Cpp2IlInjected.Address(RVA = "0x53751B0", Offset = "0x53737B0", VA = "0x1853751B0", Slot = "4")]
				public override void OBKJHPNJODD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x4725CD0", Offset = "0x47242D0", VA = "0x184725CD0")]
				public Kvp()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class JONPNBNHPHH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public Comparer<string> comparer;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
				public JONPNBNHPHH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x51E17F0", Offset = "0x51DFDF0", VA = "0x1851E17F0")]
				internal int EMDDNFKEAIK(Kvp lhs, Kvp rhs)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			protected override Comparison<Kvp> Comparison
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x5903E40", Offset = "0x5902440", VA = "0x185903E40", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5903D10", Offset = "0x5902310", VA = "0x185903D10", Slot = "14")]
			protected override string DBONEJCGIOD(Kvp MNOLBPAADFA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4D53D10", Offset = "0x4D52310", VA = "0x184D53D10")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5903C50", Offset = "0x5902250", VA = "0x185903C50")]
		public bool EHCEFKDKBNN([In] Guid PPIICOOCLEP, [Out] T HHBGHAKIGCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xC6D2F0", Offset = "0xC6B8F0", VA = "0x180C6D2F0")]
		protected PaletteConfigDirectory()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class ACCEBLIHMFO : AGPIHLAMICJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly SpecificChipConfigDirectory JKJDANENAEE;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public abstract bool JABEOOHALHG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public abstract bool GCALFEPEKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public abstract bool PCIOLGLABBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public abstract bool KIEIHCPPNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public abstract bool KGJKOBIKHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public abstract bool ABIBEKGCGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	protected abstract int PBAHFGIJAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	protected ACCEBLIHMFO(SpecificChipConfigDirectory JKJDANENAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract bool KJEGLICLEGE(Guid LEMAKPGJGOP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract PKNMNEHLDIC GAMNMGBBBII(Guid GPKHINBGHAM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "19")]
	protected abstract bool HCJOBGNOBPO(Guid FGGJHGIJDIE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "20")]
	protected abstract bool ENBKLFOBLAN(Guid ENHGJCJNGCO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "21")]
	protected abstract bool HAGHEHHKJIN(Guid FGGJHGIJDIE);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "22")]
	protected abstract bool IFDAELOMLHB(Guid ENHGJCJNGCO);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "23")]
	protected abstract bool POIMDKPGHEB(Guid DCFCGMLPJCL);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2902300", Offset = "0x2900900", VA = "0x182902300", Slot = "8")]
	public bool HIBILNGNGID(MGAFLBIECIE<HJNJCLLNAIM> BLKFKDBPJFL, MGAFLBIECIE<DMMBIHDCELP>? EFAAANCBNJL, IReadOnlyDictionary<MGAFLBIECIE<DMMBIHDCELP>, Guid>? MAAIJHGMENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x29024B0", Offset = "0x2900AB0", VA = "0x1829024B0")]
	private bool HIBILNGNGID(MGAFLBIECIE<HJNJCLLNAIM> LEMAKPGJGOP, Guid? ENHGJCJNGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29029B0", Offset = "0x2900FB0", VA = "0x1829029B0")]
	protected bool IFDOPEKOHNC(MGAFLBIECIE<HJNJCLLNAIM> LEMAKPGJGOP, Guid? ENHGJCJNGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2902B00", Offset = "0x2901100", VA = "0x182902B00", Slot = "9")]
	public bool IFDOPEKOHNC(Guid LEMAKPGJGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2902DA0", Offset = "0x29013A0", VA = "0x182902DA0")]
	protected bool JFGFFKEDBMN(MGAFLBIECIE<HJNJCLLNAIM> LEMAKPGJGOP, Guid? ENHGJCJNGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2902BC0", Offset = "0x29011C0", VA = "0x182902BC0", Slot = "10")]
	public bool JFGFFKEDBMN(Guid LEMAKPGJGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29033D0", Offset = "0x29019D0", VA = "0x1829033D0")]
	protected bool PLHINGDELIH(MGAFLBIECIE<HJNJCLLNAIM> LEMAKPGJGOP, Guid? ENHGJCJNGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2903150", Offset = "0x2901750", VA = "0x182903150")]
	protected bool PGJHMABGLJA(Guid? ENHGJCJNGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x29031F0", Offset = "0x29017F0", VA = "0x1829031F0", Slot = "25")]
	public bool PIONKOBGACC(MGAFLBIECIE<HJNJCLLNAIM> LEMAKPGJGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2901E80", Offset = "0x2900480", VA = "0x182901E80")]
	protected bool CBCAICIJBDI(Guid PPIICOOCLEP, Guid? ENHGJCJNGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29020E0", Offset = "0x29006E0", VA = "0x1829020E0")]
	protected bool CBCAICIJBDI(Guid PPIICOOCLEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2902FE0", Offset = "0x29015E0", VA = "0x182902FE0")]
	private Guid? PACENPFFPJI(MGAFLBIECIE<DMMBIHDCELP>? EFAAANCBNJL, IReadOnlyDictionary<MGAFLBIECIE<DMMBIHDCELP>, Guid>? MAAIJHGMENO)
	{
		return null;
	}
}
namespace Circuits.All.Injection.V2
{
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
			[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public NameSourceKind PaletteNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA9EE0", Offset = "0xAA84E0", VA = "0x180AA9EE0")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NameSourceKind ChipNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xF3BA50", Offset = "0xF3A050", VA = "0x180F3BA50")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public SerializedGuid SerializeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Guid NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2904780", Offset = "0x2902D80", VA = "0x182904780")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA6CC40", Offset = "0xA6B240", VA = "0x180A6CC40", Slot = "5")]
			get
			{
				return default(DeprecationStage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<NodeDescConfig> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4E0", Offset = "0xA4AAE0", VA = "0x180A4C4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool IsHiddenFromPaletteOnMicrophoneInputDisallowedPlatforms
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xC9F9A0", Offset = "0xC9DFA0", VA = "0x180C9F9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x29043F0", Offset = "0x29029F0", VA = "0x1829043F0")]
		public bool ONFPMLOAHBM(int KHMHPNKMLMD, [Out] NodeDescConfig MEIEAENFECH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2904450", Offset = "0x2902A50", VA = "0x182904450", Slot = "6")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x29046E0", Offset = "0x2902CE0", VA = "0x1829046E0")]
		public SpecificChipConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SpecificChipConfigDirectory : PaletteConfigDirectory<SpecificChipConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2904300", Offset = "0x2902900", VA = "0x182904300")]
		public bool BELJOMCKJPH([In] Guid PPIICOOCLEP, [Out] SpecificChipConfig HHBGHAKIGCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x29043B0", Offset = "0x29029B0", VA = "0x1829043B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
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
		public KOFKNOCCJAB Template
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2903840", Offset = "0x2901E40", VA = "0x182903840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC6D2F0", Offset = "0xC6B8F0", VA = "0x180C6D2F0")]
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
		private struct HKNEBKHMPBL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder<KOFKNOCCJAB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public CircuitTemplateConfig <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private AsyncOperationHandle<CircuitsV2TemplateSerializedState> <handle>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter<CircuitsV2TemplateSerializedState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x29038F0", Offset = "0x2901EF0", VA = "0x1829038F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2903CC0", Offset = "0x29022C0", VA = "0x182903CC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MGAFLBIECIE<CDDGGDMKOOA> TemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x29037D0", Offset = "0x2901DD0", VA = "0x1829037D0")]
			get
			{
				return default(MGAFLBIECIE<CDDGGDMKOOA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2903740", Offset = "0x2901D40", VA = "0x182903740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "5")]
			get
			{
				return default(DeprecationStage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2903590", Offset = "0x2901B90", VA = "0x182903590")]
		[AsyncStateMachine(typeof(HKNEBKHMPBL))]
		public Task<KOFKNOCCJAB> MLPAAJCICFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x29036A0", Offset = "0x2901CA0", VA = "0x1829036A0")]
		public CircuitTemplateConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class CircuitTemplateConfigDirectory : PaletteConfigDirectory<CircuitTemplateConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x29034A0", Offset = "0x2901AA0", VA = "0x1829034A0")]
		public bool MCNDFBCCPAF([In] MGAFLBIECIE<CDDGGDMKOOA> PPIICOOCLEP, [Out] CircuitTemplateConfig HHBGHAKIGCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2903550", Offset = "0x2901B50", VA = "0x182903550")]
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
