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
public class BGILOGOBJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 PJKNHAFEKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion BHCPPAMLLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 CDILOBFKDGL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6484000", Offset = "0x6482E00", VA = "0x186484000")]
	public bool OHDAIDIHGLP(Collider OGJBFFBMNFC, ref Bounds EIJJIFHMJFI, bool APHGLMALMPB, bool FIPJIBOOMME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64833B0", Offset = "0x64821B0", VA = "0x1864833B0")]
	public bool BIHGGHGHKCD(Collider LIHKCCBKPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6484590", Offset = "0x6483390", VA = "0x186484590")]
	public bool PFOAPCJFMKK(Collider LIHKCCBKPDL, bool APHGLMALMPB, bool FIPJIBOOMME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6483500", Offset = "0x6482300", VA = "0x186483500")]
	public void MFGKDBOAGAB(BGILOGOBJJJ BNIMMCIKNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64833D0", Offset = "0x64821D0", VA = "0x1864833D0")]
	private static void KFPPBHMMKAK(ref Vector3 CDJGLGILJHJ, ref Vector3 KIDJEKPKJJM, Vector3 HDBKKDGKJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64849F0", Offset = "0x64837F0", VA = "0x1864849F0")]
	public static BGILOGOBJJJ POIOGKMIFFN(GameObject OJIIPOMCHKP, Quaternion BHCPPAMLLMB, bool JLAPDJNFEPJ, bool MMNPBJAMINF, bool APHGLMALMPB = false, bool FIPJIBOOMME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public BGILOGOBJJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OJLGGLIAPJM : byte
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
public class NMGKMNFFKFG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6485AC0", Offset = "0x64848C0", VA = "0x186485AC0")]
	public NMGKMNFFKFG(string MEBPKBJLLDI, bool KJAPLKCEHFB, string COACFDLGALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class NHFJHAMFFBB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6485A70", Offset = "0x6484870", VA = "0x186485A70")]
	public NHFJHAMFFBB(string MEBPKBJLLDI, bool KJAPLKCEHFB)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AddComponentMenu("")]
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
			[Cpp2IlInjected.Address(RVA = "0x64850C0", Offset = "0x6483EC0", VA = "0x1864850C0")]
			public void PAPIJKFFCHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6484EF0", Offset = "0x6483CF0", VA = "0x186484EF0")]
			public float ICHFDFNPJMI(string CCEKFDNIAPD)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6484F60", Offset = "0x6483D60", VA = "0x186484F60")]
			public float ICHFDFNPJMI(int JFGKEENDEHE)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6485050", Offset = "0x6483E50", VA = "0x186485050")]
			public Texture LIOFKIPOEGI(int JFGKEENDEHE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6484E70", Offset = "0x6483C70", VA = "0x186484E70")]
			public Vector4 CBCPNHHHPAL(int JFGKEENDEHE)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6484FD0", Offset = "0x6483DD0", VA = "0x186484FD0")]
			public Color IFINHDMAKED(int JFGKEENDEHE)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static MaterialMap BINMOAHIPCO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<MaterialEntry> GFBAPIECFFB;

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
		private Dictionary<Material, MaterialEntry> ALLIAGAJKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HashSet<Material> KHPMLNJFLDP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MaterialMap GEHLGJGIEOF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6485A30", Offset = "0x6484830", VA = "0x186485A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MaterialEntry[] IMBCOGFFKHB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x64859A0", Offset = "0x64847A0", VA = "0x1864859A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6485620", Offset = "0x6484420", VA = "0x186485620")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6485900", Offset = "0x6484700", VA = "0x186485900")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6485890", Offset = "0x6484690", VA = "0x186485890")]
		public MaterialEntry GetEntryForMaterial(Material GMKOMOLOOFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64855E0", Offset = "0x64843E0", VA = "0x1864855E0")]
		public MaterialMapAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Field)]
public class AANAGPOECAI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA2B0", VA = "0x1808AB4B0")]
	public AANAGPOECAI()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[AddComponentMenu("")]
	public sealed class RecRoomAudioMixerRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string NBHEJFJOFJE = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string ODPBLAMBHIH = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string NHMFAOABJIM = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly string CJOBADCILMM;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly string IGHPHHOJOFD;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static RecRoomAudioMixerRegistry BINMOAHIPCO;

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
		public static RecRoomAudioMixerRegistry GEHLGJGIEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6486230", Offset = "0x6485030", VA = "0x186486230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AudioMixer PMNDGFNCAJE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AudioMixer JLNIBDANCKK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AudioMixer PIGFCMLCIDA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6485D60", Offset = "0x6484B60", VA = "0x186485D60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6485FF0", Offset = "0x6484DF0", VA = "0x186485FF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6485E90", Offset = "0x6484C90", VA = "0x186485E90")]
		public static bool IsValidOutputGroup(AudioMixerGroup CEMGHBNOOBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AddComponentMenu("")]
	public class RecRoomBuiltInObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		[HideInInspector]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[AANAGPOECAI]
		[SerializeField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[AANAGPOECAI]
		private CBJFCJOKEDP category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[HideInInspector]
		[SerializeField]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[AANAGPOECAI]
		[SerializeField]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[AANAGPOECAI]
		[SerializeField]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[HideInInspector]
		[SerializeField]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid ABCIGINJDHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6486770", Offset = "0x6485570", VA = "0x186486770")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6486800", Offset = "0x6485600", VA = "0x186486800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HCDIFBBJJCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CBJFCJOKEDP OKKPJLPFAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6C5CE0", Offset = "0x6C4AE0", VA = "0x1806C5CE0")]
			get
			{
				return default(CBJFCJOKEDP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DBF60", Offset = "0x6DAD60", VA = "0x1806DBF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OGJGJBAIIGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BC0", Offset = "0x6CF9C0", VA = "0x1806D0BC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BF0", Offset = "0x6CF9F0", VA = "0x1806D0BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NPNKBPHMEHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x96E900", Offset = "0x96D700", VA = "0x18096E900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xB18520", Offset = "0xB17320", VA = "0x180B18520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KCLBNPONHPD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x96E910", Offset = "0x96D710", VA = "0x18096E910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x11A77C0", Offset = "0x11A65C0", VA = "0x1811A77C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool LAKKNKNHABG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6486750", Offset = "0x6485550", VA = "0x186486750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HKGBEKECAKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6486700", Offset = "0x6485500", VA = "0x186486700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x64866C0", Offset = "0x64854C0", VA = "0x1864866C0")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BD0", Offset = "0x6CF9D0", VA = "0x1806D0BD0")]
		public void SetSpawnableTemplateData(byte[] BCPKFIFMIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83B750", Offset = "0x83A550", VA = "0x18083B750")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6486500", Offset = "0x6485300", VA = "0x186486500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6486290", Offset = "0x6485090", VA = "0x186486290")]
		public void EFLJBOIIDCB(IEnumerable<RecRoomBuiltInObject> AECIGNICGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6486300", Offset = "0x6485100", VA = "0x186486300")]
		public bool ICLIDKMCOMO(Guid PCDIOELNFHF, out RecRoomBuiltInObject MJOINGLPNIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x71DC30", Offset = "0x71CA30", VA = "0x18071DC30")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum CBJFCJOKEDP
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
	[HNEGAHJBNEE]
	[AddComponentMenu("Rec Room Studio/Rec Room Object")]
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
			[Cpp2IlInjected.Address(RVA = "0x6487020", Offset = "0x6485E20", VA = "0x186487020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6486BC0", Offset = "0x64859C0", VA = "0x186486BC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6486CB0", Offset = "0x6485AB0", VA = "0x186486CB0")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x41F8AD0", Offset = "0x41F78D0", VA = "0x1841F8AD0")]
		private bool TryRaiseUnityEvent<T0, TEvent>(string eventName, T0 value) where TEvent : UnityEvent<T0>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x41F8BB0", Offset = "0x41F79B0", VA = "0x1841F8BB0")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6486E80", Offset = "0x6485C80", VA = "0x186486E80")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6486FC0", Offset = "0x6485DC0", VA = "0x186486FC0")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6486D40", Offset = "0x6485B40", VA = "0x186486D40")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6486C50", Offset = "0x6485A50", VA = "0x186486C50")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6486EE0", Offset = "0x6485CE0", VA = "0x186486EE0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6486E10", Offset = "0x6485C10", VA = "0x186486E10")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6486DA0", Offset = "0x6485BA0", VA = "0x186486DA0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6486F50", Offset = "0x6485D50", VA = "0x186486F50")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x41F89C0", Offset = "0x41F77C0", VA = "0x1841F89C0")]
		private static bool TryFindEvent<TEvent>(NamedUnityEventBase[] eventStorage, string eventName, out TEvent result) where TEvent : UnityEventBase, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x49F18F0", Offset = "0x49F06F0", VA = "0x1849F18F0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64873D0", Offset = "0x64861D0", VA = "0x1864873D0")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6487410", Offset = "0x6486210", VA = "0x186487410")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6487450", Offset = "0x6486250", VA = "0x186487450")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x64874D0", Offset = "0x64862D0", VA = "0x1864874D0")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6487490", Offset = "0x6486290", VA = "0x186487490")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6487550", Offset = "0x6486350", VA = "0x186487550")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6487510", Offset = "0x6486310", VA = "0x186487510")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6487590", Offset = "0x6486390", VA = "0x186487590")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[Preserve]
	[HNEGAHJBNEE]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6485B60", Offset = "0x6484960", VA = "0x186485B60")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Preserve]
	[HNEGAHJBNEE]
	public sealed class NamedUnityBooleanEvent : NamedUnityEventBase<UnityBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6485B20", Offset = "0x6484920", VA = "0x186485B20")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[HNEGAHJBNEE]
	[Preserve]
	public sealed class NamedUnityFloatEvent : NamedUnityEventBase<UnityFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6485BA0", Offset = "0x64849A0", VA = "0x186485BA0")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[HNEGAHJBNEE]
	[Preserve]
	public sealed class NamedUnityIntEvent : NamedUnityEventBase<UnityIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6485BE0", Offset = "0x64849E0", VA = "0x186485BE0")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Preserve]
	[HNEGAHJBNEE]
	public sealed class NamedUnityStringEvent : NamedUnityEventBase<UnityStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6485C60", Offset = "0x6484A60", VA = "0x186485C60")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[HNEGAHJBNEE]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityEventBase<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6485C20", Offset = "0x6484A20", VA = "0x186485C20")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[HNEGAHJBNEE]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityEventBase<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6485CA0", Offset = "0x6484AA0", VA = "0x186485CA0")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[HNEGAHJBNEE]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityEventBase<UnityStringIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6485CE0", Offset = "0x6484AE0", VA = "0x186485CE0")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[HNEGAHJBNEE]
	[Preserve]
	public sealed class NamedUnityStringStringEvent : NamedUnityEventBase<UnityStringStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6485D20", Offset = "0x6484B20", VA = "0x186485D20")]
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
		[AANAGPOECAI]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[NMGKMNFFKFG("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[NMGKMNFFKFG("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
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
		[NHFJHAMFFBB("isBuiltInObject", false)]
		[Header("Physics")]
		private CCFGKCGFMKO physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[NHFJHAMFFBB("isShapeContainer", true)]
		private PLDHPCOCCLF shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		[SerializeField]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8FE020", Offset = "0x8FCE20", VA = "0x1808FE020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6486870", Offset = "0x6485670", VA = "0x186486870")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum CCFGKCGFMKO
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum PLDHPCOCCLF
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
	[AddComponentMenu("")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static RecRoomObjectPrefabRegistry BINMOAHIPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[HideInInspector]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private RecRoomObjectPrefabRegistryAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static RecRoomObjectPrefabRegistry GEHLGJGIEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6486B80", Offset = "0x6485980", VA = "0x186486B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> BCBLPCPCNLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6486AE0", Offset = "0x64858E0", VA = "0x186486AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64868C0", Offset = "0x64856C0", VA = "0x1864868C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64869B0", Offset = "0x64857B0", VA = "0x1864869B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6486880", Offset = "0x6485680", VA = "0x186486880")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x37FBA40", Offset = "0x37FA840", VA = "0x1837FBA40")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct PDDJLLJGMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public byte[] CDCCANONDPI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x963B70", Offset = "0x962970", VA = "0x180963B70")]
	public PDDJLLJGMHK(byte[] GGOKHMJBGJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct FNMDJHJCPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte[] CDCCANONDPI;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x963B70", Offset = "0x962970", VA = "0x180963B70")]
	public FNMDJHJCPHC(byte[] GGOKHMJBGJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KPBFAFMNGCC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6484CB0", Offset = "0x6483AB0", VA = "0x186484CB0")]
	public static (PDDJLLJGMHK, FNMDJHJCPHC) NDIIIHNHFIO(Stream PIJFOMBKKIM)
	{
		return default((PDDJLLJGMHK, FNMDJHJCPHC));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6484B60", Offset = "0x6483960", VA = "0x186484B60")]
	public static void AFFPDLDKMIF(Stream PIJFOMBKKIM, PDDJLLJGMHK HOHNOADIOEC, FNMDJHJCPHC MLCGLMJOMKE)
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
			[Cpp2IlInjected.Address(RVA = "0xDE4FC0", Offset = "0xDE3DC0", VA = "0x180DE4FC0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8C00", Offset = "0x1FE7A00", VA = "0x181FE8C00")]
		public SerializedGuid(in Guid KFIPLDEPOPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8B40", Offset = "0x1FE7940", VA = "0x181FE8B40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6487230", Offset = "0x6486030", VA = "0x186487230", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6487180", Offset = "0x6485F80", VA = "0x186487180", Slot = "7")]
		public bool Equals(SerializedGuid BNIMMCIKNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x64870A0", Offset = "0x6485EA0", VA = "0x1864870A0", Slot = "0")]
		public override bool Equals(object LOPIEGGIDMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1FE88E0", Offset = "0x1FE76E0", VA = "0x181FE88E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8720", Offset = "0x1FE7520", VA = "0x181FE8720", Slot = "6")]
		public int CompareTo(SerializedGuid BNIMMCIKNIE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[AttributeUsage(AttributeTargets.Class)]
public class HNEGAHJBNEE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
	public HNEGAHJBNEE()
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
