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
public class KCACOAOJNCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 GBMDDGDNICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion EIGPDNIOAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 GCAABALMEGA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6090610", Offset = "0x608F610", VA = "0x186090610")]
	public bool CKJEPMECHGE(Collider AMDPNFGBEBN, ref Bounds HJIDIDOFHFK, bool KJNNGCGPNDJ, bool PGEBOILJJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6090E40", Offset = "0x608FE40", VA = "0x186090E40")]
	public bool IIPJIBGBFKF(Collider NKNPGFCGIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x608F6B0", Offset = "0x608E6B0", VA = "0x18608F6B0")]
	public bool BDAPKLPFDML(Collider NKNPGFCGIPO, bool KJNNGCGPNDJ, bool PGEBOILJJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x608FB10", Offset = "0x608EB10", VA = "0x18608FB10")]
	public void CJNHACHFAHN(KCACOAOJNCF KICLNADFIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6090D10", Offset = "0x608FD10", VA = "0x186090D10")]
	private static void ICCNFDCOBAB(ref Vector3 AJMPIJJCLNC, ref Vector3 JFFGPOOCEHG, Vector3 NJAOOECBFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6090BA0", Offset = "0x608FBA0", VA = "0x186090BA0")]
	public static KCACOAOJNCF DNGPOFGAINK(GameObject JMLKLPJONJN, Quaternion EIGPDNIOAKK, bool BKEBANKBFBE, bool JMDFJMNFKON, bool KJNNGCGPNDJ = false, bool PGEBOILJJLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KCACOAOJNCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DOBALKKEDLC : byte
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
public class MEJFBBEJKDM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6090E60", Offset = "0x608FE60", VA = "0x186090E60")]
	public MEJFBBEJKDM(string AOKAOIOMMBG, bool LADIHGDIPOB, string JHHLGJHJEDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class FCHKOHLIJGP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x608F350", Offset = "0x608E350", VA = "0x18608F350")]
	public FCHKOHLIJGP(string AOKAOIOMMBG, bool LADIHGDIPOB)
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
			[Cpp2IlInjected.Address(RVA = "0x6090FA0", Offset = "0x608FFA0", VA = "0x186090FA0")]
			public void EKIIMHOOAPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6090EC0", Offset = "0x608FEC0", VA = "0x186090EC0")]
			public float CAJJMAICJEP(string IADPDEAGFAB)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6090F30", Offset = "0x608FF30", VA = "0x186090F30")]
			public float CAJJMAICJEP(int DLFEJOALJGM)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x60914C0", Offset = "0x60904C0", VA = "0x1860914C0")]
			public Texture IOKGECHNHHN(int DLFEJOALJGM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6091530", Offset = "0x6090530", VA = "0x186091530")]
			public Vector4 JNCNAFBHEDO(int DLFEJOALJGM)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x60915B0", Offset = "0x60905B0", VA = "0x1860915B0")]
			public Color KHHOPENHAJM(int DLFEJOALJGM)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static MaterialMap OMPFLELLCCN;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<MaterialEntry> FPKEEGBPIAP;

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
		private Dictionary<Material, MaterialEntry> AAEHLOGEIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HashSet<Material> IFBFPDFKELN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MaterialMap JKCIDAEDHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6091A80", Offset = "0x6090A80", VA = "0x186091A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MaterialEntry[] PLCMFKNJFNK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x60919F0", Offset = "0x60909F0", VA = "0x1860919F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6091670", Offset = "0x6090670", VA = "0x186091670")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6091950", Offset = "0x6090950", VA = "0x186091950")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60918E0", Offset = "0x60908E0", VA = "0x1860918E0")]
		public MaterialEntry GetEntryForMaterial(Material GIEMNGEHMIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6091630", Offset = "0x6090630", VA = "0x186091630")]
		public MaterialMapAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Field)]
public class DADDHJMIJKA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE0", Offset = "0x6E4CE0", VA = "0x1806E5CE0")]
	public DADDHJMIJKA()
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
		private const string JNOFFLMBNLC = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string BFOPDPBIIIL = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string OPNNICIEFOD = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly string OEBDNEIGINN;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly string PJEOJJOOGLC;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static RecRoomAudioMixerRegistry OMPFLELLCCN;

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
		public static RecRoomAudioMixerRegistry JKCIDAEDHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x60921D0", Offset = "0x60911D0", VA = "0x1860921D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AudioMixer MHILDGAPFBH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AudioMixer NGKILJNAHLP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AudioMixer HFKPFICOHAO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6091D00", Offset = "0x6090D00", VA = "0x186091D00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6091F90", Offset = "0x6090F90", VA = "0x186091F90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6091E30", Offset = "0x6090E30", VA = "0x186091E30")]
		public static bool IsValidOutputGroup(AudioMixerGroup PAMJNFANHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
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
		[DADDHJMIJKA]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[DADDHJMIJKA]
		private FIDCBPGHLAD category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[DADDHJMIJKA]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[DADDHJMIJKA]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[HideInInspector]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid OLJLFADECBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6092740", Offset = "0x6091740", VA = "0x186092740")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x60927D0", Offset = "0x60917D0", VA = "0x1860927D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GDINNMGOBPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x67F130", Offset = "0x67E130", VA = "0x18067F130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FIDCBPGHLAD BBBHMMFCFBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6A01B0", Offset = "0x69F1B0", VA = "0x1806A01B0")]
			get
			{
				return default(FIDCBPGHLAD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9C6CD0", Offset = "0x9C5CD0", VA = "0x1809C6CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BAGGILOEPEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x749540", Offset = "0x748540", VA = "0x180749540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8DC070", Offset = "0x8DB070", VA = "0x1808DC070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool AAJHHEJPDFO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9CA570", Offset = "0x9C9570", VA = "0x1809CA570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAD0420", Offset = "0xACF420", VA = "0x180AD0420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool NGNABGGINBO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x15A86C0", Offset = "0x15A76C0", VA = "0x1815A86C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x15A86D0", Offset = "0x15A76D0", VA = "0x1815A86D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool AGPIFKJENCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6092720", Offset = "0x6091720", VA = "0x186092720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DBKMKKCPDGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60926D0", Offset = "0x60916D0", VA = "0x1860926D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6092660", Offset = "0x6091660", VA = "0x186092660")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60926A0", Offset = "0x60916A0", VA = "0x1860926A0")]
		public void SetSpawnableTemplateData(CIDKOGGHOGP MEDKDLPFJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x17C7060", Offset = "0x17C6060", VA = "0x1817C7060")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
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
			[Cpp2IlInjected.Address(RVA = "0x60924A0", Offset = "0x60914A0", VA = "0x1860924A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6092430", Offset = "0x6091430", VA = "0x186092430")]
		public void NCHBPNKNJHO(IEnumerable<RecRoomBuiltInObject> CLBHMLEGFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6092230", Offset = "0x6091230", VA = "0x186092230")]
		public bool HADOILGNPLN(Guid CKOJMLPELOK, out RecRoomBuiltInObject JAGJJPBJLFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xDF0520", Offset = "0xDEF520", VA = "0x180DF0520")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FIDCBPGHLAD
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
	[NMEGDBDHHKM]
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
			[Cpp2IlInjected.Address(RVA = "0x6092FF0", Offset = "0x6091FF0", VA = "0x186092FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6092B90", Offset = "0x6091B90", VA = "0x186092B90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6092C80", Offset = "0x6091C80", VA = "0x186092C80")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C61D20", Offset = "0x3C60D20", VA = "0x183C61D20")]
		private bool TryRaiseUnityEvent<T0, TEvent>(string eventName, T0 value) where TEvent : UnityEvent<T0>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C61E00", Offset = "0x3C60E00", VA = "0x183C61E00")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6092E50", Offset = "0x6091E50", VA = "0x186092E50")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6092F90", Offset = "0x6091F90", VA = "0x186092F90")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6092D10", Offset = "0x6091D10", VA = "0x186092D10")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6092C20", Offset = "0x6091C20", VA = "0x186092C20")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6092EB0", Offset = "0x6091EB0", VA = "0x186092EB0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6092DE0", Offset = "0x6091DE0", VA = "0x186092DE0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6092D70", Offset = "0x6091D70", VA = "0x186092D70")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6092F20", Offset = "0x6091F20", VA = "0x186092F20")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3C61C10", Offset = "0x3C60C10", VA = "0x183C61C10")]
		private static bool TryFindEvent<TEvent>(NamedUnityEventBase[] eventStorage, string eventName, out TEvent result) where TEvent : UnityEventBase, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
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
			[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x462A4D0", Offset = "0x46294D0", VA = "0x18462A4D0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60933A0", Offset = "0x60923A0", VA = "0x1860933A0")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60933E0", Offset = "0x60923E0", VA = "0x1860933E0")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6093420", Offset = "0x6092420", VA = "0x186093420")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60934A0", Offset = "0x60924A0", VA = "0x1860934A0")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6093460", Offset = "0x6092460", VA = "0x186093460")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6093520", Offset = "0x6092520", VA = "0x186093520")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60934E0", Offset = "0x60924E0", VA = "0x1860934E0")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6093560", Offset = "0x6092560", VA = "0x186093560")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[NMEGDBDHHKM]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6091B00", Offset = "0x6090B00", VA = "0x186091B00")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[NMEGDBDHHKM]
	[Preserve]
	public sealed class NamedUnityBooleanEvent : NamedUnityEventBase<UnityBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6091AC0", Offset = "0x6090AC0", VA = "0x186091AC0")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[NMEGDBDHHKM]
	[Preserve]
	public sealed class NamedUnityFloatEvent : NamedUnityEventBase<UnityFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6091B40", Offset = "0x6090B40", VA = "0x186091B40")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[NMEGDBDHHKM]
	[Preserve]
	public sealed class NamedUnityIntEvent : NamedUnityEventBase<UnityIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6091B80", Offset = "0x6090B80", VA = "0x186091B80")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Preserve]
	[NMEGDBDHHKM]
	public sealed class NamedUnityStringEvent : NamedUnityEventBase<UnityStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6091C00", Offset = "0x6090C00", VA = "0x186091C00")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[NMEGDBDHHKM]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityEventBase<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6091BC0", Offset = "0x6090BC0", VA = "0x186091BC0")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[NMEGDBDHHKM]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityEventBase<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6091C40", Offset = "0x6090C40", VA = "0x186091C40")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[NMEGDBDHHKM]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityEventBase<UnityStringIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6091C80", Offset = "0x6090C80", VA = "0x186091C80")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[NMEGDBDHHKM]
	public sealed class NamedUnityStringStringEvent : NamedUnityEventBase<UnityStringStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6091CC0", Offset = "0x6090CC0", VA = "0x186091CC0")]
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
		[DADDHJMIJKA]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[MEJFBBEJKDM("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[MEJFBBEJKDM("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
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
		[FCHKOHLIJGP("isBuiltInObject", false)]
		private OCHGMFLIMJN physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[FCHKOHLIJGP("isShapeContainer", true)]
		private LHKKEMNGKID shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[HideInInspector]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x682270", Offset = "0x681270", VA = "0x180682270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6092840", Offset = "0x6091840", VA = "0x186092840")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum OCHGMFLIMJN
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum LHKKEMNGKID
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
		private static RecRoomObjectPrefabRegistry OMPFLELLCCN;

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
		public static RecRoomObjectPrefabRegistry JKCIDAEDHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6092B50", Offset = "0x6091B50", VA = "0x186092B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> OILKNPONMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6092AB0", Offset = "0x6091AB0", VA = "0x186092AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6092890", Offset = "0x6091890", VA = "0x186092890")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6092980", Offset = "0x6091980", VA = "0x186092980")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6092850", Offset = "0x6091850", VA = "0x186092850")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x25C3ED0", Offset = "0x25C2ED0", VA = "0x1825C3ED0")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct HHHAEFPMDMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public byte[] GOMOKJBFMDP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x851A00", Offset = "0x850A00", VA = "0x180851A00")]
	public HHHAEFPMDMC(byte[] BNKBFACGLIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct KFLKJNJHJOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte[] GOMOKJBFMDP;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x851A00", Offset = "0x850A00", VA = "0x180851A00")]
	public KFLKJNJHJOM(byte[] BNKBFACGLIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HMHEAKCAGAJ
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x608F3A0", Offset = "0x608E3A0", VA = "0x18608F3A0")]
	public static (HHHAEFPMDMC, KFLKJNJHJOM) BJCDECDKELK(Stream KJHFBEBKBIB)
	{
		return default((HHHAEFPMDMC, KFLKJNJHJOM));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x608F560", Offset = "0x608E560", VA = "0x18608F560")]
	public static void CKILACNAPMG(Stream KJHFBEBKBIB, HHHAEFPMDMC GPCLICNBEEG, KFLKJNJHJOM EFGJIFHPJPD)
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
			[Cpp2IlInjected.Address(RVA = "0x2C136B0", Offset = "0x2C126B0", VA = "0x182C136B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1DC0", Offset = "0x5FC0DC0", VA = "0x185FC1DC0")]
		public SerializedGuid(in Guid FBKLHONPMNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1D00", Offset = "0x5FC0D00", VA = "0x185FC1D00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6093200", Offset = "0x6092200", VA = "0x186093200", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6093150", Offset = "0x6092150", VA = "0x186093150", Slot = "7")]
		public bool Equals(SerializedGuid KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6093070", Offset = "0x6092070", VA = "0x186093070", Slot = "0")]
		public override bool Equals(object GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1AA0", Offset = "0x5FC0AA0", VA = "0x185FC1AA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5FC18E0", Offset = "0x5FC08E0", VA = "0x185FC18E0", Slot = "6")]
		public int CompareTo(SerializedGuid KICLNADFIEK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[AttributeUsage(AttributeTargets.Class)]
public class NMEGDBDHHKM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
	public NMEGDBDHHKM()
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
