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
public class OHOCAKMMNPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 JPFNFMBLGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion OHIFHLJPHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 LOLMDLKOOKC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x518E470", Offset = "0x518D470", VA = "0x18518E470")]
	public bool BICDMNODMPD(Collider KAJNOOLOBOH, ref Bounds FIHIKEAJCJP, bool CODIOCALAJC, bool GPFHPKLCHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x518F870", Offset = "0x518E870", VA = "0x18518F870")]
	public bool KLIHIBOFLMH(Collider HEMCNHOJBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x518F890", Offset = "0x518E890", VA = "0x18518F890")]
	public bool KOAMEEOHLGO(Collider HEMCNHOJBJG, bool CODIOCALAJC, bool GPFHPKLCHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x518E9F0", Offset = "0x518D9F0", VA = "0x18518E9F0")]
	public void DJMJLMNFJBO(OHOCAKMMNPF GOAJJPLEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x518E360", Offset = "0x518D360", VA = "0x18518E360")]
	private static void BEJKGCAGOBI(ref Vector3 HKAKKDBNNKH, ref Vector3 OBPPMPNHIIG, Vector3 JFONNIHKMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x518FD30", Offset = "0x518ED30", VA = "0x18518FD30")]
	public static OHOCAKMMNPF POEHOGLJHGH(GameObject BHOMFIKIJGC, Quaternion OHIFHLJPHJJ, bool OFNBMOKICJN, bool HMGCOJIHNHI, bool CODIOCALAJC = false, bool GPFHPKLCHGI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public OHOCAKMMNPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LKMHIHGEHCE : byte
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
public class GLNJMCPNFGG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x518D410", Offset = "0x518C410", VA = "0x18518D410")]
	public GLNJMCPNFGG(string DDALMOPINCD, bool HAKGGLBOJLG, string BOFMKPFNBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class FGFOBAMDBPO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x518D3C0", Offset = "0x518C3C0", VA = "0x18518D3C0")]
	public FGFOBAMDBPO(string DDALMOPINCD, bool HAKGGLBOJLG)
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
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Texture value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class FloatProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public float value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class VectorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Vector4 value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public class ColorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Color value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public class MaterialEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string shaderName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public MaterialGlobalIlluminationFlags globalIlluminationFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public int renderQueue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public bool doubleSidedGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public TextureProperty[] texProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public FloatProperty[] floatProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public VectorProperty[] vecProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public ColorProperty[] colorProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private Dictionary<string, float> floatPropsDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Dictionary<int, float> floatPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private Dictionary<int, Texture> texPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private Dictionary<int, Vector4> vecPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private Dictionary<int, Color> colorPropIdDict;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x518D860", Offset = "0x518C860", VA = "0x18518D860")]
			public void FGGFPCMGDFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x518DD50", Offset = "0x518CD50", VA = "0x18518DD50")]
			public float GOEOHCGOINM(string IPJBPCNNBIO)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x518DDC0", Offset = "0x518CDC0", VA = "0x18518DDC0")]
			public float GOEOHCGOINM(int DPDDHIFJHOC)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x518DE30", Offset = "0x518CE30", VA = "0x18518DE30")]
			public Texture IGKABFMFGAG(int DPDDHIFJHOC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x518DCA0", Offset = "0x518CCA0", VA = "0x18518DCA0")]
			public Vector4 FKICAKDMKFN(int DPDDHIFJHOC)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x518D7D0", Offset = "0x518C7D0", VA = "0x18518D7D0")]
			public Color DCIGHEKIGLJ(int DPDDHIFJHOC)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static MaterialMap FHBJCKJIPHI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<MaterialEntry> MJOMBJLMMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Dictionary<Material, MaterialEntry> GPPLNIFPPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private HashSet<Material> HEOECDJJOFH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MaterialMap AOMOPIPEMFB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x518E0E0", Offset = "0x518D0E0", VA = "0x18518E0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MaterialEntry[] GFJPDOEMAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x518DEA0", Offset = "0x518CEA0", VA = "0x18518DEA0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x518E070", Offset = "0x518D070", VA = "0x18518E070")]
		public MaterialEntry GetEntryForMaterial(Material PDBMLOOCIIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public MaterialMap()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Field)]
public class BHHFMCAOPNL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F13E0", Offset = "0x6F03E0", VA = "0x1806F13E0")]
	public BHHFMCAOPNL()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class RecRoomAudioMixerRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string EKLMHFHPLIP = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string MPAJDJNBANE = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string MKKPHEENMDL = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly string LHPJMBJHACH;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly string BGKIKKMMLMM;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static RecRoomAudioMixerRegistry FHBJCKJIPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private AudioMixer sounds;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static RecRoomAudioMixerRegistry AOMOPIPEMFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x51902E0", Offset = "0x518F2E0", VA = "0x1851902E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AudioMixer LCJOMLMOEPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AudioMixer DAKOJPBPOPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AudioMixer JBDJIPDDNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5B60C0", Offset = "0x5B50C0", VA = "0x1805B60C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x518FE90", Offset = "0x518EE90", VA = "0x18518FE90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51900E0", Offset = "0x518F0E0", VA = "0x1851900E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x518FFA0", Offset = "0x518EFA0", VA = "0x18518FFA0")]
		public static bool IsValidOutputGroup(AudioMixerGroup LPHDMAPOEJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RecRoomBuiltInObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GEJJBAIFGME category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private byte[] persistenceViewData;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Guid LEMHPLBEHGE
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5190760", Offset = "0x518F760", VA = "0x185190760")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x51907F0", Offset = "0x518F7F0", VA = "0x1851907F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string KFKIJIIGHNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5B7D70", Offset = "0x5B6D70", VA = "0x1805B7D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public GEJJBAIFGME GJDPIHNEHHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x58E390", Offset = "0x58D390", VA = "0x18058E390")]
			get
			{
				return default(GEJJBAIFGME);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x797580", Offset = "0x796580", VA = "0x180797580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public byte[] PKEMIKHCNDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5B5A30", Offset = "0x5B4A30", VA = "0x1805B5A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LHNCBGHMCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5190710", Offset = "0x518F710", VA = "0x185190710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x51906E0", Offset = "0x518F6E0", VA = "0x1851906E0")]
		public void SetPersistenceViewData(EPCHCGCHMHF HAFLCPCGGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class RecRoomBuiltInObjectData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private RecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Dictionary<Guid, RecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<Guid, RecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5190560", Offset = "0x518F560", VA = "0x185190560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5190340", Offset = "0x518F340", VA = "0x185190340")]
		public void GLDOICOLNLL(IEnumerable<RecRoomBuiltInObject> HKLGJOBNKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x51903B0", Offset = "0x518F3B0", VA = "0x1851903B0")]
		public bool NHHHDIDPJMI(Guid OCDAGPDOOMI, out RecRoomBuiltInObject HHEDMFBIKFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xD62E50", Offset = "0xD61E50", VA = "0x180D62E50")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum GEJJBAIFGME
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Prop,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Gadget
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ALBPCCLPBHP]
	[DisallowMultipleComponent]
	public sealed class RecRoomObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[HideInInspector]
		[SerializeReference]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RecRoomObjectConfiguration DefaultConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5190FD0", Offset = "0x518FFD0", VA = "0x185190FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5190B70", Offset = "0x518FB70", VA = "0x185190B70")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5190C00", Offset = "0x518FC00", VA = "0x185190C00")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x26D7870", Offset = "0x26D6870", VA = "0x1826D7870")]
		private bool TryRaiseUnityEvent<T0, TEvent>(string eventName, T0 value) where TEvent : UnityEvent<T0>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x26D7950", Offset = "0x26D6950", VA = "0x1826D7950")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5190F70", Offset = "0x518FF70", VA = "0x185190F70")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5190DC0", Offset = "0x518FDC0", VA = "0x185190DC0")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5190C90", Offset = "0x518FC90", VA = "0x185190C90")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5190D60", Offset = "0x518FD60", VA = "0x185190D60")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5190CF0", Offset = "0x518FCF0", VA = "0x185190CF0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5190E20", Offset = "0x518FE20", VA = "0x185190E20")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5190F00", Offset = "0x518FF00", VA = "0x185190F00")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5190E90", Offset = "0x518FE90", VA = "0x185190E90")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x26D7740", Offset = "0x26D6740", VA = "0x1826D7740")]
		private static bool TryFindEvent<TEvent>(NamedUnityEventBase[] eventStorage, string eventName, out TEvent result) where TEvent : UnityEventBase, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2E0D0E0", Offset = "0x2E0C0E0", VA = "0x182E0D0E0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5191370", Offset = "0x5190370", VA = "0x185191370")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x51913B0", Offset = "0x51903B0", VA = "0x1851913B0")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x51913F0", Offset = "0x51903F0", VA = "0x1851913F0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5191470", Offset = "0x5190470", VA = "0x185191470")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5191430", Offset = "0x5190430", VA = "0x185191430")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x51914F0", Offset = "0x51904F0", VA = "0x1851914F0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51914B0", Offset = "0x51904B0", VA = "0x1851914B0")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5191530", Offset = "0x5190530", VA = "0x185191530")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ALBPCCLPBHP]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x518E160", Offset = "0x518D160", VA = "0x18518E160")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[Preserve]
	[ALBPCCLPBHP]
	public sealed class NamedUnityBooleanEvent : NamedUnityEventBase<UnityBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x518E120", Offset = "0x518D120", VA = "0x18518E120")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Preserve]
	[ALBPCCLPBHP]
	public sealed class NamedUnityFloatEvent : NamedUnityEventBase<UnityFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x518E1A0", Offset = "0x518D1A0", VA = "0x18518E1A0")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[ALBPCCLPBHP]
	[Preserve]
	public sealed class NamedUnityIntEvent : NamedUnityEventBase<UnityIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x518E1E0", Offset = "0x518D1E0", VA = "0x18518E1E0")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[Preserve]
	[ALBPCCLPBHP]
	public sealed class NamedUnityStringEvent : NamedUnityEventBase<UnityStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x518E260", Offset = "0x518D260", VA = "0x18518E260")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[ALBPCCLPBHP]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityEventBase<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x518E220", Offset = "0x518D220", VA = "0x18518E220")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[ALBPCCLPBHP]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityEventBase<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x518E2A0", Offset = "0x518D2A0", VA = "0x18518E2A0")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[Preserve]
	[ALBPCCLPBHP]
	public sealed class NamedUnityStringIntEvent : NamedUnityEventBase<UnityStringIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x518E2E0", Offset = "0x518D2E0", VA = "0x18518E2E0")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Preserve]
	[ALBPCCLPBHP]
	public sealed class NamedUnityStringStringEvent : NamedUnityEventBase<UnityStringStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x518E320", Offset = "0x518D320", VA = "0x18518E320")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		[BHHFMCAOPNL]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		[GLNJMCPNFGG("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		[GLNJMCPNFGG("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[Header("Physics")]
		private bool locomotionCollisionEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[FGFOBAMDBPO("isBuiltInObject", false)]
		private CPGHEMEOLDA physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[FGFOBAMDBPO("isShapeContainer", true)]
		private NHGIAHBPKMH shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[HideInInspector]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x60F8C0", Offset = "0x60E8C0", VA = "0x18060F8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5190860", Offset = "0x518F860", VA = "0x185190860")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum CPGHEMEOLDA
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum NHGIAHBPKMH
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Physical_Sticky = 2,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Physical = 4
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static RecRoomObjectPrefabRegistry FHBJCKJIPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static RecRoomObjectPrefabRegistry AOMOPIPEMFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5190B30", Offset = "0x518FB30", VA = "0x185190B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> CLMIMFIHABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5190A60", Offset = "0x518FA60", VA = "0x185190A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5190880", Offset = "0x518F880", VA = "0x185190880")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5190950", Offset = "0x518F950", VA = "0x185190950")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class RecRoomObjectPrefabEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public RecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct ADDMPOICAMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte[] MJBCCABCEEL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD170", VA = "0x1806CE170")]
	public ADDMPOICAMB(byte[] HPEACFNBKMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct IKJHOBLGHJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte[] MJBCCABCEEL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD170", VA = "0x1806CE170")]
	public IKJHOBLGHJE(byte[] HPEACFNBKMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class IBHCBOBABOA
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x518D470", Offset = "0x518C470", VA = "0x18518D470")]
	public static (ADDMPOICAMB, IKJHOBLGHJE) AOMOIKKECEH(Stream MEDAHDKGPEB)
	{
		return default((ADDMPOICAMB, IKJHOBLGHJE));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x518D660", Offset = "0x518C660", VA = "0x18518D660")]
	public static void IFJAPAKMCPI(Stream MEDAHDKGPEB, ADDMPOICAMB OHFMJPIIHIA, IKJHOBLGHJE KLAFOKDIACM)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x205B770", Offset = "0x205A770", VA = "0x18205B770")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x511B0E0", Offset = "0x511A0E0", VA = "0x18511B0E0")]
		public SerializedGuid(in Guid EMEFDKEMECG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x511B0B0", Offset = "0x511A0B0", VA = "0x18511B0B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x51911D0", Offset = "0x51901D0", VA = "0x1851911D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5191130", Offset = "0x5190130", VA = "0x185191130", Slot = "7")]
		public bool Equals(SerializedGuid GOAJJPLEOBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5191050", Offset = "0x5190050", VA = "0x185191050", Slot = "0")]
		public override bool Equals(object NHBCHHMAJOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x511AF70", Offset = "0x5119F70", VA = "0x18511AF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x511ACB0", Offset = "0x5119CB0", VA = "0x18511ACB0", Slot = "6")]
		public int CompareTo(SerializedGuid GOAJJPLEOBJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[AttributeUsage(AttributeTargets.Class)]
public class ALBPCCLPBHP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x58D480", Offset = "0x58C480", VA = "0x18058D480")]
	public ALBPCCLPBHP()
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
