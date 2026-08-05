using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.All.Injection.V2;
using Cpp2IlInjected;
using RecRoom.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Circuits.All.Injection.V2
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
		[AGODPOIAGJL]
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
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
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
		[AGODPOIAGJL]
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
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<InputPortConfig> Inputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<OutputPortConfig> Outputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D77620", Offset = "0x1D76420", VA = "0x181D77620")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D776C0", Offset = "0x1D764C0", VA = "0x181D776C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
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
		[AGODPOIAGJL]
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
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public OutputPortConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class KNNLOBBAOEJ : ONKLMBLPJLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly SpecificChipConfigDirectory JMHHDNHLCEK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract bool AGHGPFFGDNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract bool MIOGHBNFKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract bool AKFMEIEGMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract bool DMFJFLBJHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected abstract int BLCOILCFAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	protected KNNLOBBAOEJ(SpecificChipConfigDirectory JMHHDNHLCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract bool DKFNMOIFBPI(Guid LCDDGPGNLOL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "18")]
	protected abstract bool DMNMNLIBLIK(Guid BKDJGPPNEAE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "19")]
	protected abstract bool NACKCKEJFJO(Guid MOPLABNDCOJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D77170", Offset = "0x1D75F70", VA = "0x181D77170", Slot = "9")]
	public bool OHFLEFDGEHC(GJGPLLBOCJG EEDANCJJEPL, IReadOnlyDictionary<GGCJJCNEEOD<NCFLANDMDIF>, Guid> PHOJIADJNKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D77410", Offset = "0x1D76210", VA = "0x181D77410")]
	protected bool OHFLEFDGEHC(Guid LCDDGPGNLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D76DD0", Offset = "0x1D75BD0", VA = "0x181D76DD0", Slot = "11")]
	public bool MMPDGONKOML(GJGPLLBOCJG EEDANCJJEPL, IReadOnlyDictionary<GGCJJCNEEOD<NCFLANDMDIF>, Guid> PHOJIADJNKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D76BE0", Offset = "0x1D759E0", VA = "0x181D76BE0")]
	protected bool MMPDGONKOML(Guid LCDDGPGNLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D76790", Offset = "0x1D75590", VA = "0x181D76790", Slot = "12")]
	public bool BIGKHBNLNCP(GGCJJCNEEOD<PCOEAHJLCJD> LCDDGPGNLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1D76980", Offset = "0x1D75780", VA = "0x181D76980", Slot = "10")]
	public bool FOKDFNGEHAL(GJGPLLBOCJG EEDANCJJEPL)
	{
		return default(bool);
	}
}
namespace Circuits.All.Injection.V2
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class SpecificChipConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PAONABJBNOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public string[] prefix;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public PAONABJBNOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1D77720", Offset = "0x1D76520", VA = "0x181D77720")]
			internal string[] JIGKNPBLJPE(NodeFilter i)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[AGODPOIAGJL]
		[SerializeField]
		private string paletteName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[AGODPOIAGJL]
		[SerializeField]
		private string chipName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[AGODPOIAGJL]
		[SerializeField]
		private string className;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private SerializedGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[Multiline(3)]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool isBetaChip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private bool isValidInRoom1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isValidInRoom2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool isHiddenInPalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private bool isDevChip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private bool isStudioChip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("If enabled, this chip will not be able to be spawned if the \"Remove Griefable Chips\" subroom setting is enabled")]
		private bool isTrollingRisk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("If enabled, this chip will not be able to be spawned by a user if their game role setting \"Can Spawn Role Assignment Chips\" is disabled")]
		private bool isRoleAssignmentRisk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private DeprecationStage deprecationStage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private NameSourceKind paletteNameSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private NameSourceKind chipNameSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private NodeDescConfig[] nodeDescs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private NodeFilter[] filters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("Toggle for all nodes and save in Unity to force them to reserialize. This field is unused in-game.")]
		private bool forceReserialize;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly string[] circuitsV2FilterPrefix;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int throughput;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string PaletteName
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string ChipName
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SerializedGuid SerializeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Guid NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1D78110", Offset = "0x1D76F10", VA = "0x181D78110")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B40", Offset = "0x7B7940", VA = "0x1807B8B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IsBetaChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x862FA0", Offset = "0x861DA0", VA = "0x180862FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IsValidInRoom1
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8045F0", Offset = "0x8033F0", VA = "0x1808045F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IsValidInRoom2
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE1B050", Offset = "0xE19E50", VA = "0x180E1B050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool IsHiddenInPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1386CE0", Offset = "0x1385AE0", VA = "0x181386CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IsDevChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAE2060", Offset = "0xAE0E60", VA = "0x180AE2060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IsStudioChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAE24E0", Offset = "0xAE12E0", VA = "0x180AE24E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool IsTrollingRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x117FCF0", Offset = "0x117EAF0", VA = "0x18117FCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IsRoleAssignmentRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1D78100", Offset = "0x1D76F00", VA = "0x181D78100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83C910", Offset = "0x83B710", VA = "0x18083C910")]
			get
			{
				return default(DeprecationStage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NameSourceKind PaletteNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x956FF0", Offset = "0x955DF0", VA = "0x180956FF0")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NameSourceKind ChipNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD57810", Offset = "0xD56610", VA = "0x180D57810")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<NodeDescConfig> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB8B0", Offset = "0x7BA6B0", VA = "0x1807BB8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1D77E60", Offset = "0x1D76C60", VA = "0x181D77E60")]
		public string[][] POMOBBJBADM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1D77A80", Offset = "0x1D76880", VA = "0x181D77A80")]
		private string[][] LKBCNFJODDI(string[] POBAGCACOMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1D77A20", Offset = "0x1D76820", VA = "0x181D77A20")]
		public bool IEMDCDBHGOP(int OHINPGIGDNE, [Out] NodeDescConfig MIHEEFPOKNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D77C20", Offset = "0x1D76A20", VA = "0x181D77C20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D780A0", Offset = "0x1D76EA0", VA = "0x181D780A0")]
		public SpecificChipConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SpecificChipConfigDirectory : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class SpecificChipConfigDictionary : EditableSerializedDictionary<SerializedGuid, SpecificChipConfig, SpecificChipConfigDictionary.Kvp>
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public sealed class Kvp : SerializedKeyVal<SerializedGuid, SpecificChipConfig>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				[AGODPOIAGJL]
				[SerializeField]
				public string Name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				[AGODPOIAGJL]
				[SerializeField]
				public string ClassName;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x1D774E0", Offset = "0x1D762E0", VA = "0x181D774E0", Slot = "4")]
				public override void JAPGCFCGHAE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x1D775E0", Offset = "0x1D763E0", VA = "0x181D775E0")]
				public Kvp()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class HDCCCAGNAHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public Comparer<string> comparer;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
				public HDCCCAGNAHC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x1D76750", Offset = "0x1D75550", VA = "0x181D76750")]
				internal int PBNECMOGDIP(Kvp lhs, Kvp rhs)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			protected override Comparison<Kvp> Comparison
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x1D778B0", Offset = "0x1D766B0", VA = "0x181D778B0", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1D77790", Offset = "0x1D76590", VA = "0x181D77790", Slot = "14")]
			protected override string IKDKLABNMLE(Kvp OICJCLJABGB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1D77870", Offset = "0x1D76670", VA = "0x181D77870")]
			public SpecificChipConfigDictionary()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private SpecificChipConfigDictionary specificChipConfigs;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyDictionary<SerializedGuid, SpecificChipConfig> SpecificChipConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1D77980", Offset = "0x1D76780", VA = "0x181D77980")]
		public bool JHLFKNAHPJJ([In] Guid MAAFBDMNKAP, [Out] SpecificChipConfig OMMMKKDJPJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8853D0", Offset = "0x8841D0", VA = "0x1808853D0")]
		public SpecificChipConfigDirectory()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class TypeParamConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[AGODPOIAGJL]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[AGODPOIAGJL]
		[SerializeField]
		private string type;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
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
