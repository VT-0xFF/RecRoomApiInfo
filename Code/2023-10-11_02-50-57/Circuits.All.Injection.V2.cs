using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.CircuitsV2.Config
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum DeprecationStage
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Active,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Deprecating,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Deprecated
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public sealed class InputPortConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[EKIEDNKDMJF]
		[SerializeField]
		private string type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private string description;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public InputPortConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum NameSourceKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		FirstNodeDesc,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Code
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class NodeDescConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[EKIEDNKDMJF]
		[SerializeField]
		private TypeParamConfig[] typeParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private InputPortConfig[] inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private OutputPortConfig[] outputs;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<InputPortConfig> Inputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<OutputPortConfig> Outputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C07910", Offset = "0x1C06710", VA = "0x181C07910")]
		public NodeDescConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct NodeFilter : ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[HideInInspector]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		public string[] FilterPath;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C079B0", Offset = "0x1C067B0", VA = "0x181C079B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class OutputPortConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[EKIEDNKDMJF]
		[SerializeField]
		private string type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private string description;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OutputPortConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class SpecificChipConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class FEKLGFDNINE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public string[] prefix;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public FEKLGFDNINE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1C078A0", Offset = "0x1C066A0", VA = "0x181C078A0")]
			internal string[] CPLFMLKHGEP(NodeFilter i)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[EKIEDNKDMJF]
		[SerializeField]
		private string paletteName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[EKIEDNKDMJF]
		[SerializeField]
		private string chipName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[EKIEDNKDMJF]
		[SerializeField]
		private string className;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private SerializedGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[Multiline(3)]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private bool isBetaChip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool isValidInRoom1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private bool isValidInRoom2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isHiddenInPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool isDevChip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private bool isStudioChip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Tooltip("If enabled, this chip will not be able to be spawned if the \"Remove Griefable Chips\" subroom setting is enabled")]
		private bool isTrollingRisk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("If enabled, this chip will not be able to be spawned by a user if their game role setting \"Can Spawn Role Assignment Chips\" is disabled")]
		private bool isRoleAssignmentRisk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private DeprecationStage deprecationStage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private NameSourceKind paletteNameSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private NameSourceKind chipNameSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private NodeDescConfig[] nodeDescs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private NodeFilter[] filters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[Tooltip("Toggle for all nodes and save in Unity to force them to reserialize. This field is unused in-game.")]
		private bool forceReserialize;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly string[] circuitsV2FilterPrefix;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int throughput;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string PaletteName
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string ChipName
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public SerializedGuid SerializeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1C080F0", Offset = "0x1C06EF0", VA = "0x181C080F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x768550", Offset = "0x767350", VA = "0x180768550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IsBetaChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x849F90", Offset = "0x848D90", VA = "0x180849F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsValidInRoom1
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xC93A70", Offset = "0xC92870", VA = "0x180C93A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsValidInRoom2
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC937B0", Offset = "0xC925B0", VA = "0x180C937B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsHiddenInPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x11E37E0", Offset = "0x11E25E0", VA = "0x1811E37E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IsDevChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x98FFE0", Offset = "0x98EDE0", VA = "0x18098FFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IsStudioChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9900A0", Offset = "0x98EEA0", VA = "0x1809900A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IsTrollingRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xFFCC60", Offset = "0xFFBA60", VA = "0x180FFCC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IsRoleAssignmentRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1A1E240", Offset = "0x1A1D040", VA = "0x181A1E240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xC4C5C0", Offset = "0xC4B3C0", VA = "0x180C4C5C0")]
			get
			{
				return default(DeprecationStage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NameSourceKind PaletteNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x841350", Offset = "0x840150", VA = "0x180841350")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NameSourceKind ChipNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xEB7870", Offset = "0xEB6670", VA = "0x180EB7870")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyList<NodeDescConfig> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x764C00", Offset = "0x763A00", VA = "0x180764C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1C07A10", Offset = "0x1C06810", VA = "0x181C07A10")]
		public string[][] DDLBCAOGIKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1C07BC0", Offset = "0x1C069C0", VA = "0x181C07BC0")]
		private string[][] LIMBAMKFONM(string[] NJLCOEPNOJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1C07B60", Offset = "0x1C06960", VA = "0x181C07B60")]
		public bool HDOOFFJGPDO(int DOJILIOCHKM, [Out] NodeDescConfig FDGDHEKBLEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1C07D60", Offset = "0x1C06B60", VA = "0x181C07D60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1C08090", Offset = "0x1C06E90", VA = "0x181C08090")]
		public SpecificChipConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class TypeParamConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[EKIEDNKDMJF]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[EKIEDNKDMJF]
		[SerializeField]
		private string type;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public TypeParamConfig()
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
