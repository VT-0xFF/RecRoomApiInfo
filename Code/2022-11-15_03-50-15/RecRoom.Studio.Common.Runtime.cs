using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IEEGPFHAAPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 OHNMNBFBDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion IOCIEOJKCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 JEAIFEEIBNK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF690", Offset = "0x5FAE090", VA = "0x185FAF690")]
	public bool CLBPJJJHFDG(Collider JJEECJHLDGJ, ref Bounds DKDHAMFEDAG, bool PCCMOHLBAAN, bool KFKHABHFBGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFEC0", Offset = "0x5FAE8C0", VA = "0x185FAFEC0")]
	public bool FCEEJPPBAAI(Collider DANKALDMBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF230", Offset = "0x5FADC30", VA = "0x185FAF230")]
	public bool AFOPNNJGOMC(Collider DANKALDMBIP, bool PCCMOHLBAAN, bool KFKHABHFBGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFEE0", Offset = "0x5FAE8E0", VA = "0x185FAFEE0")]
	public void JDFDOCCNGEE(IEEGPFHAAPD BPKBHFMGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFD90", Offset = "0x5FAE790", VA = "0x185FAFD90")]
	private static void DJNBBGOHCIB(ref Vector3 IGJJHEFOMKI, ref Vector3 FMFHKMBBDJC, Vector3 DEFMLJAJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFC20", Offset = "0x5FAE620", VA = "0x185FAFC20")]
	public static IEEGPFHAAPD DIAEKMPPHNG(GameObject JBBMOMLGMKJ, Quaternion IOCIEOJKCCH, bool EALHJDMPAPL, bool NGPAIEGNNCG, bool PCCMOHLBAAN = false, bool KFKHABHFBGB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public IEEGPFHAAPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BDFBAHIOCOM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	WindowsDesktop,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	MobileIOS,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	MobileAndroid,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	OculusQuest,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Playstation4,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Playstation5
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class NHPFAPCBGCC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FB18F0", Offset = "0x5FB02F0", VA = "0x185FB18F0")]
	public NHPFAPCBGCC(string OKNFKAJADBM, bool LAKEICLINDF, string LCGNICGDHDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class FJNJABMJJFN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF1E0", Offset = "0x5FADBE0", VA = "0x185FAF1E0")]
	public FJNJABMJJFN(string OKNFKAJADBM, bool LAKEICLINDF)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class MaterialMap : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public class TextureProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Texture value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class FloatProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class VectorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Vector4 value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public class ColorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Color value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public class MaterialEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public string shaderName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public MaterialGlobalIlluminationFlags globalIlluminationFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int renderQueue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public bool doubleSidedGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public TextureProperty[] texProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public FloatProperty[] floatProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public VectorProperty[] vecProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ColorProperty[] colorProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Dictionary<string, float> floatPropsDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private Dictionary<int, float> floatPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private Dictionary<int, Texture> texPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private Dictionary<int, Vector4> vecPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private Dictionary<int, Color> colorPropIdDict;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5FB0E40", Offset = "0x5FAF840", VA = "0x185FB0E40")]
			public void JOHKNDHPEFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5FB0DD0", Offset = "0x5FAF7D0", VA = "0x185FB0DD0")]
			public float JFEOECMDDHC(string KKJOOAJGLJI)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5FB0D60", Offset = "0x5FAF760", VA = "0x185FB0D60")]
			public float JFEOECMDDHC(int EDNCKFCJECD)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5FB0CF0", Offset = "0x5FAF6F0", VA = "0x185FB0CF0")]
			public Texture IKGBMAPPPMK(int EDNCKFCJECD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5FB13E0", Offset = "0x5FAFDE0", VA = "0x185FB13E0")]
			public Vector4 NFBGNKPELNM(int EDNCKFCJECD)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5FB1360", Offset = "0x5FAFD60", VA = "0x185FB1360")]
			public Color MMNIEDIIOCN(int EDNCKFCJECD)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static MaterialMap LOGLKKHAEGG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<MaterialEntry> ECOBMIAJKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[HideInInspector]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private MaterialMapAsset entriesAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<Material, MaterialEntry> ONLJIBKIGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HashSet<Material> FPFIIACODML;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MaterialMap BLPHKNHCNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5FB18B0", Offset = "0x5FB02B0", VA = "0x185FB18B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MaterialEntry[] ANPJHAKANCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5FB1820", Offset = "0x5FB0220", VA = "0x185FB1820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB14A0", Offset = "0x5FAFEA0", VA = "0x185FB14A0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1780", Offset = "0x5FB0180", VA = "0x185FB1780")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1710", Offset = "0x5FB0110", VA = "0x185FB1710")]
		public MaterialEntry GetEntryForMaterial(Material NOKHEELPLEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public MaterialMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MaterialMapAsset : RecRoomStudioBuildAsset<MaterialMapAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private MaterialMap.MaterialEntry[] entries;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MaterialMap.MaterialEntry[] Entries
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1460", Offset = "0x5FAFE60", VA = "0x185FB1460")]
		public MaterialMapAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Field)]
public class POOOAMLKMKA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0")]
	public POOOAMLKMKA()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class RecRoomAudioMixerRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string MANMIDMOHJP = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string DEKEKNJJBHA = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string FLFBABKCEKD = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly string FFAAMBOOJDP;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly string HIJNMCABDOD;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static RecRoomAudioMixerRegistry LOGLKKHAEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private AudioMixer sounds;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static RecRoomAudioMixerRegistry BLPHKNHCNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5FB2060", Offset = "0x5FB0A60", VA = "0x185FB2060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AudioMixer HNEDEDLCEEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AudioMixer HMPFKOKJAAB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AudioMixer PJAOHJEOHCF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1B90", Offset = "0x5FB0590", VA = "0x185FB1B90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1E20", Offset = "0x5FB0820", VA = "0x185FB1E20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1CC0", Offset = "0x5FB06C0", VA = "0x185FB1CC0")]
		public static bool IsValidOutputGroup(AudioMixerGroup HNICMKLIKHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class RecRoomBuiltInObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		[HideInInspector]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		[POOOAMLKMKA]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[POOOAMLKMKA]
		private BDHKENHFMDM category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[POOOAMLKMKA]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[POOOAMLKMKA]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[HideInInspector]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid LEMEIMMKFID
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FB25D0", Offset = "0x5FB0FD0", VA = "0x185FB25D0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5FB2660", Offset = "0x5FB1060", VA = "0x185FB2660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OFPJGOGNFDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BDHKENHFMDM IAAADMFNOON
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6E1520", Offset = "0x6DFF20", VA = "0x1806E1520")]
			get
			{
				return default(BDHKENHFMDM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB81BC0", Offset = "0xB805C0", VA = "0x180B81BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KLOBFLKDAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7F1260", Offset = "0x7EFC60", VA = "0x1807F1260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7F1650", Offset = "0x7F0050", VA = "0x1807F1650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool EFLIGKGGBPC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x91AD80", Offset = "0x919780", VA = "0x18091AD80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x91A810", Offset = "0x919210", VA = "0x18091A810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool NCPPPFOMGNL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA40C60", Offset = "0xA3F660", VA = "0x180A40C60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA40C70", Offset = "0xA3F670", VA = "0x180A40C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ELMEMPDDBMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5FB25B0", Offset = "0x5FB0FB0", VA = "0x185FB25B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool AEELHCNOGNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5FB2560", Offset = "0x5FB0F60", VA = "0x185FB2560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB24F0", Offset = "0x5FB0EF0", VA = "0x185FB24F0")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2530", Offset = "0x5FB0F30", VA = "0x185FB2530")]
		public void SetSpawnableTemplateData(LEDHFCLAPEG KNHFCOCAMDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xBEB2F0", Offset = "0xBE9CF0", VA = "0x180BEB2F0")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class RecRoomBuiltInObjectData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private RecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Dictionary<Guid, RecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Dictionary<Guid, RecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5FB2330", Offset = "0x5FB0D30", VA = "0x185FB2330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FB22C0", Offset = "0x5FB0CC0", VA = "0x185FB22C0")]
		public void PBGNLDOADEB(IEnumerable<RecRoomBuiltInObject> KDFMIBEMBOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FB20C0", Offset = "0x5FB0AC0", VA = "0x185FB20C0")]
		public bool OHBNCLEBFJI(Guid JNIKMLAHBJN, out RecRoomBuiltInObject FKLHBBFPKPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x752960", Offset = "0x751360", VA = "0x180752960")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum BDHKENHFMDM
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Prop,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Gadget
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[DisallowMultipleComponent]
	[KHOMMNHAEGI]
	public sealed class RecRoomObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeReference]
		[HideInInspector]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public RecRoomObjectConfiguration DefaultConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5FB2E80", Offset = "0x5FB1880", VA = "0x185FB2E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2A20", Offset = "0x5FB1420", VA = "0x185FB2A20")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2B10", Offset = "0x5FB1510", VA = "0x185FB2B10")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x243C3F0", Offset = "0x243ADF0", VA = "0x18243C3F0")]
		private bool TryRaiseUnityEvent<T0, TEvent>(string eventName, T0 value) where TEvent : UnityEvent<T0>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x243C4D0", Offset = "0x243AED0", VA = "0x18243C4D0")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2CE0", Offset = "0x5FB16E0", VA = "0x185FB2CE0")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2E20", Offset = "0x5FB1820", VA = "0x185FB2E20")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2BA0", Offset = "0x5FB15A0", VA = "0x185FB2BA0")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2AB0", Offset = "0x5FB14B0", VA = "0x185FB2AB0")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2D40", Offset = "0x5FB1740", VA = "0x185FB2D40")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2C70", Offset = "0x5FB1670", VA = "0x185FB2C70")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2C00", Offset = "0x5FB1600", VA = "0x185FB2C00")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2DB0", Offset = "0x5FB17B0", VA = "0x185FB2DB0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x243C2E0", Offset = "0x243ACE0", VA = "0x18243C2E0")]
		private static bool TryFindEvent<TEvent>(NamedUnityEventBase[] eventStorage, string eventName, out TEvent result) where TEvent : UnityEventBase, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x32ED510", Offset = "0x32EBF10", VA = "0x1832ED510")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3230", Offset = "0x5FB1C30", VA = "0x185FB3230")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3270", Offset = "0x5FB1C70", VA = "0x185FB3270")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5FB32B0", Offset = "0x5FB1CB0", VA = "0x185FB32B0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3330", Offset = "0x5FB1D30", VA = "0x185FB3330")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FB32F0", Offset = "0x5FB1CF0", VA = "0x185FB32F0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5FB33B0", Offset = "0x5FB1DB0", VA = "0x185FB33B0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3370", Offset = "0x5FB1D70", VA = "0x185FB3370")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5FB33F0", Offset = "0x5FB1DF0", VA = "0x185FB33F0")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[KHOMMNHAEGI]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1990", Offset = "0x5FB0390", VA = "0x185FB1990")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[KHOMMNHAEGI]
	[Preserve]
	public sealed class NamedUnityBooleanEvent : NamedUnityEventBase<UnityBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1950", Offset = "0x5FB0350", VA = "0x185FB1950")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[KHOMMNHAEGI]
	[Preserve]
	public sealed class NamedUnityFloatEvent : NamedUnityEventBase<UnityFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5FB19D0", Offset = "0x5FB03D0", VA = "0x185FB19D0")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[KHOMMNHAEGI]
	[Preserve]
	public sealed class NamedUnityIntEvent : NamedUnityEventBase<UnityIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1A10", Offset = "0x5FB0410", VA = "0x185FB1A10")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Preserve]
	[KHOMMNHAEGI]
	public sealed class NamedUnityStringEvent : NamedUnityEventBase<UnityStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1A90", Offset = "0x5FB0490", VA = "0x185FB1A90")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[KHOMMNHAEGI]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityEventBase<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1A50", Offset = "0x5FB0450", VA = "0x185FB1A50")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[KHOMMNHAEGI]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityEventBase<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1AD0", Offset = "0x5FB04D0", VA = "0x185FB1AD0")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[KHOMMNHAEGI]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityEventBase<UnityStringIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1B10", Offset = "0x5FB0510", VA = "0x185FB1B10")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[KHOMMNHAEGI]
	public sealed class NamedUnityStringStringEvent : NamedUnityEventBase<UnityStringStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1B50", Offset = "0x5FB0550", VA = "0x185FB1B50")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		[POOOAMLKMKA]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[NHPFAPCBGCC("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[NHPFAPCBGCC("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[Header("Physics")]
		[FJNJABMJJFN("isBuiltInObject", false)]
		private MENIDNDHJPL physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[FJNJABMJJFN("isShapeContainer", true)]
		private FOKDILLCEFE shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[HideInInspector]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB40", Offset = "0x7DA540", VA = "0x1807DBB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5FB26D0", Offset = "0x5FB10D0", VA = "0x185FB26D0")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum MENIDNDHJPL
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum FOKDILLCEFE
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Physical_Sticky = 2,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Physical = 4
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static RecRoomObjectPrefabRegistry LOGLKKHAEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[HideInInspector]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private RecRoomObjectPrefabRegistryAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static RecRoomObjectPrefabRegistry BLPHKNHCNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5FB29E0", Offset = "0x5FB13E0", VA = "0x185FB29E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> CNPEDEOCFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5FB2940", Offset = "0x5FB1340", VA = "0x185FB2940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2720", Offset = "0x5FB1120", VA = "0x185FB2720")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2810", Offset = "0x5FB1210", VA = "0x185FB2810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class RecRoomObjectPrefabEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public RecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RecRoomObjectPrefabRegistryAsset : RecRoomStudioBuildAsset<RecRoomObjectPrefabRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RecRoomObjectPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5FB26E0", Offset = "0x5FB10E0", VA = "0x185FB26E0")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1E89650", Offset = "0x1E88050", VA = "0x181E89650")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct OMOHFKKONOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public byte[] DIAPLDMNKLO;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EC0", Offset = "0x6A38C0", VA = "0x1806A4EC0")]
	public OMOHFKKONOP(byte[] IKLIFLGKEBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct LMPMOEHONAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte[] DIAPLDMNKLO;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EC0", Offset = "0x6A38C0", VA = "0x1806A4EC0")]
	public LMPMOEHONAL(byte[] IKLIFLGKEBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LMONPCACNNK
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0B30", Offset = "0x5FAF530", VA = "0x185FB0B30")]
	public static (OMOHFKKONOP, LMPMOEHONAL) MEJKBBEMDJM(Stream PLHINEOBEDC)
	{
		return default((OMOHFKKONOP, LMPMOEHONAL));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB09E0", Offset = "0x5FAF3E0", VA = "0x185FB09E0")]
	public static void CFBFFKPECKM(Stream PLHINEOBEDC, OMOHFKKONOP ELDHAGPPPNA, LMPMOEHONAL MBBHIPKHHNC)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1867310", Offset = "0x1865D10", VA = "0x181867310")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E58F40", Offset = "0x5E57940", VA = "0x185E58F40")]
		public SerializedGuid(in Guid CAPPBFKKCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E58F10", Offset = "0x5E57910", VA = "0x185E58F10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3090", Offset = "0x5FB1A90", VA = "0x185FB3090", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2FE0", Offset = "0x5FB19E0", VA = "0x185FB2FE0", Slot = "7")]
		public bool Equals(SerializedGuid BPKBHFMGOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5FB2F00", Offset = "0x5FB1900", VA = "0x185FB2F00", Slot = "0")]
		public override bool Equals(object PDHKCBEBPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E58DD0", Offset = "0x5E577D0", VA = "0x185E58DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E58AF0", Offset = "0x5E574F0", VA = "0x185E58AF0", Slot = "6")]
		public int CompareTo(SerializedGuid BPKBHFMGOOF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[AttributeUsage(AttributeTargets.Class)]
public class KHOMMNHAEGI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
	public KHOMMNHAEGI()
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
