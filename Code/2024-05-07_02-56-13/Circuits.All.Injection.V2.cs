using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.All.Injection.V2;
using Cpp2IlInjected;
using RecRoom.Attributes;
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
		[ReadOnlyField]
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
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
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
		[ReadOnlyField]
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
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<InputPortConfig> Inputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<OutputPortConfig> Outputs
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E08FD0", Offset = "0x1E081D0", VA = "0x181E08FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E09070", Offset = "0x1E08270", VA = "0x181E09070", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
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
		[ReadOnlyField]
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
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OutputPortConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class NPMACEMILBG : BFBEDJMPKBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly SpecificChipConfigDirectory GDIOCLPAKMM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract bool JLBAANIEJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract bool FLJMPJBNLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract bool OJPJEOIOPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract bool AIFGMIMJNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected abstract int FNHFAFMNCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	protected NPMACEMILBG(SpecificChipConfigDirectory GDIOCLPAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract bool GOEAODGKAIA(Guid FFAJFFHPFIE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "18")]
	protected abstract bool KGAABIHINLJ(Guid BEAPKELGNOC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "19")]
	protected abstract bool FPCAJBGKMDP(Guid AMMKPMBNEED);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E08C60", Offset = "0x1E07E60", VA = "0x181E08C60", Slot = "9")]
	public bool PMMDPAMFAMF(LPOODDAHIAM FODGEDCJIDC, IReadOnlyDictionary<BCFHHBLPOPP<LOIIILALBLN>, Guid> GIFCMAFGAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E08F00", Offset = "0x1E08100", VA = "0x181E08F00")]
	protected bool PMMDPAMFAMF(Guid FFAJFFHPFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E086D0", Offset = "0x1E078D0", VA = "0x181E086D0", Slot = "11")]
	public bool JLNHNGMIHAD(LPOODDAHIAM FODGEDCJIDC, IReadOnlyDictionary<BCFHHBLPOPP<LOIIILALBLN>, Guid> GIFCMAFGAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E08A70", Offset = "0x1E07C70", VA = "0x181E08A70")]
	protected bool JLNHNGMIHAD(Guid FFAJFFHPFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E084E0", Offset = "0x1E076E0", VA = "0x181E084E0", Slot = "12")]
	public bool IMDDJJCALJD(BCFHHBLPOPP<ODLLPEBONPI> FFAJFFHPFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E08280", Offset = "0x1E07480", VA = "0x181E08280", Slot = "10")]
	public bool BLIGGLCPOHP(LPOODDAHIAM FODGEDCJIDC)
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
		private sealed class PMBEBIKNFDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public string[] prefix;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public PMBEBIKNFDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1E090D0", Offset = "0x1E082D0", VA = "0x181E090D0")]
			internal string[] IMAIKHIGIKH(NodeFilter i)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[ReadOnlyField]
		[SerializeField]
		private string paletteName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[ReadOnlyField]
		[SerializeField]
		private string chipName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[ReadOnlyField]
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
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string ChipName
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string ClassName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SerializedGuid SerializeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Guid NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1E09AB0", Offset = "0x1E08CB0", VA = "0x181E09AB0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IsBetaChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x89EB40", Offset = "0x89DD40", VA = "0x18089EB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IsValidInRoom1
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7FFC40", Offset = "0x7FEE40", VA = "0x1807FFC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IsValidInRoom2
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE63D20", Offset = "0xE62F20", VA = "0x180E63D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool IsHiddenInPalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x13FD470", Offset = "0x13FC670", VA = "0x1813FD470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool IsDevChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2E0", Offset = "0xB094E0", VA = "0x180B0A2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IsStudioChip
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB0A640", Offset = "0xB09840", VA = "0x180B0A640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool IsTrollingRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x11E4400", Offset = "0x11E3600", VA = "0x1811E4400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IsRoleAssignmentRisk
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E09AA0", Offset = "0x1E08CA0", VA = "0x181E09AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public DeprecationStage DeprecationStage
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x867E70", Offset = "0x867070", VA = "0x180867E70")]
			get
			{
				return default(DeprecationStage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NameSourceKind PaletteNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9C46D0", Offset = "0x9C38D0", VA = "0x1809C46D0")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NameSourceKind ChipNameSource
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xDCF750", Offset = "0xDCE950", VA = "0x180DCF750")]
			get
			{
				return default(NameSourceKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<NodeDescConfig> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CB0", Offset = "0x7B7EB0", VA = "0x1807B8CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1E095D0", Offset = "0x1E087D0", VA = "0x181E095D0")]
		public string[][] KLMDDKOBPHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1E09430", Offset = "0x1E08630", VA = "0x181E09430")]
		private string[][] ECIGJHDGGBI(string[] IDJMHOBOGAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1E093D0", Offset = "0x1E085D0", VA = "0x181E093D0")]
		public bool DOFGPEKIFGB(int HMFNCGHECPG, [Out] NodeDescConfig NDAGBPFCLPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1E09720", Offset = "0x1E08920", VA = "0x181E09720", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E09A40", Offset = "0x1E08C40", VA = "0x181E09A40")]
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
				[ReadOnlyField]
				[SerializeField]
				public string Name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				[ReadOnlyField]
				[SerializeField]
				public string ClassName;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x1E08140", Offset = "0x1E07340", VA = "0x181E08140", Slot = "4")]
				public override void DIDHNICJJNA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x1E08240", Offset = "0x1E07440", VA = "0x181E08240")]
				public Kvp()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class HIECPFCNPBD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public Comparer<string> comparer;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
				public HIECPFCNPBD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x1E08100", Offset = "0x1E07300", VA = "0x181E08100")]
				internal int BAMFKCGFDFN(Kvp lhs, Kvp rhs)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			protected override Comparison<Kvp> Comparison
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x1E09260", Offset = "0x1E08460", VA = "0x181E09260", Slot = "15")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1E09140", Offset = "0x1E08340", VA = "0x181E09140", Slot = "14")]
			protected override string HGNJEGDNJPF(Kvp JMPHEPIPJAO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1E09220", Offset = "0x1E08420", VA = "0x181E09220")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1E09330", Offset = "0x1E08530", VA = "0x181E09330")]
		public bool BAAJNHEGBLE([In] Guid IKOKEKHMFKH, [Out] SpecificChipConfig GPNOOFEABCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89ADA0", Offset = "0x899FA0", VA = "0x18089ADA0")]
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
		[ReadOnlyField]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[ReadOnlyField]
		[SerializeField]
		private string type;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
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
