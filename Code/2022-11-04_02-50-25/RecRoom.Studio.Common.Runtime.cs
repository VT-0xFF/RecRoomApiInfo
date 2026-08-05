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
public class CPGIKPFGLDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 HFMBGEBILGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion BOMBFPIEJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 AFEFLEJODEH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F81780", Offset = "0x5F80B80", VA = "0x185F81780")]
	public bool HPKPMENEHHH(Collider HNEJPHOBPOM, ref Bounds JJOGFAELGAA, bool KPDMGBEKPOC, bool ICHBKIALPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F81D10", Offset = "0x5F81110", VA = "0x185F81D10")]
	public bool IPPBHAFPKAF(Collider CMLILENOEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F80820", Offset = "0x5F7FC20", VA = "0x185F80820")]
	public bool BAIDGANEEHI(Collider CMLILENOEPA, bool KPDMGBEKPOC, bool ICHBKIALPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F80C80", Offset = "0x5F80080", VA = "0x185F80C80")]
	public void EFOMLKCOLDI(CPGIKPFGLDH BKBGGIICJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F81EA0", Offset = "0x5F812A0", VA = "0x185F81EA0")]
	private static void OOHLBENPIBH(ref Vector3 KCAMANKDPPD, ref Vector3 PCCFFNKLAEE, Vector3 DDPAJGCOAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F81D30", Offset = "0x5F81130", VA = "0x185F81D30")]
	public static CPGIKPFGLDH KKEODANMICD(GameObject JAFNHFEOMPI, Quaternion BOMBFPIEJKJ, bool EPMLKGCAHKP, bool FHGJDNIPPNO, bool KPDMGBEKPOC = false, bool ICHBKIALPNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public CPGIKPFGLDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IDBLLOMOJAI : byte
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
public class JCEKOMMILON : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5F82020", Offset = "0x5F81420", VA = "0x185F82020")]
	public JCEKOMMILON(string KDNIDDIGOFK, bool FEMDIPAJGNC, string AJEHANECOFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class IMPOOABBGKD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5F81FD0", Offset = "0x5F813D0", VA = "0x185F81FD0")]
	public IMPOOABBGKD(string KDNIDDIGOFK, bool FEMDIPAJGNC)
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
			[Cpp2IlInjected.Address(RVA = "0x5F821E0", Offset = "0x5F815E0", VA = "0x185F821E0")]
			public void GLGIMGKNDMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5F82170", Offset = "0x5F81570", VA = "0x185F82170")]
			public float GFDBEKPJLGH(string JODEBEIHAPC)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5F82100", Offset = "0x5F81500", VA = "0x185F82100")]
			public float GFDBEKPJLGH(int FHKHLDOKDFM)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5F82700", Offset = "0x5F81B00", VA = "0x185F82700")]
			public Texture JPHGPNMMMJE(int FHKHLDOKDFM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5F82770", Offset = "0x5F81B70", VA = "0x185F82770")]
			public Vector4 NJINFMJHPAE(int FHKHLDOKDFM)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5F82080", Offset = "0x5F81480", VA = "0x185F82080")]
			public Color ADBDNLEMCAI(int FHKHLDOKDFM)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static MaterialMap AEBBMADEDFF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<MaterialEntry> EFKMMPBCLDG;

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
		private Dictionary<Material, MaterialEntry> GJFHKAFBPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HashSet<Material> KPKMJHOHMEG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MaterialMap PNBICMAKACI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5F82C40", Offset = "0x5F82040", VA = "0x185F82C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MaterialEntry[] IPKCFCAKNJI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5F82BB0", Offset = "0x5F81FB0", VA = "0x185F82BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F82830", Offset = "0x5F81C30", VA = "0x185F82830")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F82B10", Offset = "0x5F81F10", VA = "0x185F82B10")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F82AA0", Offset = "0x5F81EA0", VA = "0x185F82AA0")]
		public MaterialEntry GetEntryForMaterial(Material HFLIOKNDGCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F827F0", Offset = "0x5F81BF0", VA = "0x185F827F0")]
		public MaterialMapAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Field)]
public class LIKFAKMILGO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE0", Offset = "0x6D40E0", VA = "0x1806D4CE0")]
	public LIKFAKMILGO()
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
		private const string CJLJLCOHBIG = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string GKDNCHNLNHP = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string IDMBOKFCLBH = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly string BANNKKAFGCG;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly string KHHOFBGAGOE;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static RecRoomAudioMixerRegistry AEBBMADEDFF;

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
		public static RecRoomAudioMixerRegistry PNBICMAKACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5F83390", Offset = "0x5F82790", VA = "0x185F83390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AudioMixer NOCPHDCANAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AudioMixer IPMAHPBJDAN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AudioMixer JPDDECLDPDD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5F82EC0", Offset = "0x5F822C0", VA = "0x185F82EC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5F83150", Offset = "0x5F82550", VA = "0x185F83150")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F82FF0", Offset = "0x5F823F0", VA = "0x185F82FF0")]
		public static bool IsValidOutputGroup(AudioMixerGroup HGKDAOGNNHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
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
		[LIKFAKMILGO]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[LIKFAKMILGO]
		private OJCFNDHGDFE category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[LIKFAKMILGO]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[LIKFAKMILGO]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[HideInInspector]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid OOFALMKGPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5F83900", Offset = "0x5F82D00", VA = "0x185F83900")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5F83990", Offset = "0x5F82D90", VA = "0x185F83990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ACAFDBBHNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OJCFNDHGDFE GKANGMLNOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68F1B0", Offset = "0x68E5B0", VA = "0x18068F1B0")]
			get
			{
				return default(OJCFNDHGDFE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x822DE0", Offset = "0x8221E0", VA = "0x180822DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BDEPMFHBNLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x738540", Offset = "0x737940", VA = "0x180738540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x960C90", Offset = "0x960090", VA = "0x180960C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HEOJJEJKBME
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA6F350", Offset = "0xA6E750", VA = "0x180A6F350")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xBFE4B0", Offset = "0xBFD8B0", VA = "0x180BFE4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FPDLKCHIKAL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x134D8D0", Offset = "0x134CCD0", VA = "0x18134D8D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x134D8E0", Offset = "0x134CCE0", VA = "0x18134D8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool MEGLLFJBGKH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5F838E0", Offset = "0x5F82CE0", VA = "0x185F838E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IAOFJPPLMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5F83890", Offset = "0x5F82C90", VA = "0x185F83890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F83820", Offset = "0x5F82C20", VA = "0x185F83820")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F83860", Offset = "0x5F82C60", VA = "0x185F83860")]
		public void SetSpawnableTemplateData(BHAHIGHCAAL BEJOHNHOBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB4AFE0", Offset = "0xB4A3E0", VA = "0x180B4AFE0")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x5F83660", Offset = "0x5F82A60", VA = "0x185F83660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5F833F0", Offset = "0x5F827F0", VA = "0x185F833F0")]
		public void MDNCGNPODNH(IEnumerable<RecRoomBuiltInObject> JHAPIBIPHPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F83460", Offset = "0x5F82860", VA = "0x185F83460")]
		public bool MLNCJCFKCNK(Guid BKBPEKAJFGC, out RecRoomBuiltInObject AGMLCFOAHBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xF02880", Offset = "0xF01C80", VA = "0x180F02880")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum OJCFNDHGDFE
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
	[FKPOFLLNLIF]
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
			[Cpp2IlInjected.Address(RVA = "0x5F841B0", Offset = "0x5F835B0", VA = "0x185F841B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5F83D50", Offset = "0x5F83150", VA = "0x185F83D50")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F83E40", Offset = "0x5F83240", VA = "0x185F83E40")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x42060E0", Offset = "0x42054E0", VA = "0x1842060E0")]
		private bool TryRaiseUnityEvent<T0, TEvent>(string eventName, T0 value) where TEvent : UnityEvent<T0>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x42061C0", Offset = "0x42055C0", VA = "0x1842061C0")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F84010", Offset = "0x5F83410", VA = "0x185F84010")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F84150", Offset = "0x5F83550", VA = "0x185F84150")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F83ED0", Offset = "0x5F832D0", VA = "0x185F83ED0")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F83DE0", Offset = "0x5F831E0", VA = "0x185F83DE0")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F84070", Offset = "0x5F83470", VA = "0x185F84070")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F83FA0", Offset = "0x5F833A0", VA = "0x185F83FA0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5F83F30", Offset = "0x5F83330", VA = "0x185F83F30")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F840E0", Offset = "0x5F834E0", VA = "0x185F840E0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4205FD0", Offset = "0x42053D0", VA = "0x184205FD0")]
		private static bool TryFindEvent<TEvent>(NamedUnityEventBase[] eventStorage, string eventName, out TEvent result) where TEvent : UnityEventBase, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x35D2030", Offset = "0x35D1430", VA = "0x1835D2030")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5F84560", Offset = "0x5F83960", VA = "0x185F84560")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F845A0", Offset = "0x5F839A0", VA = "0x185F845A0")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5F845E0", Offset = "0x5F839E0", VA = "0x185F845E0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5F84660", Offset = "0x5F83A60", VA = "0x185F84660")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5F84620", Offset = "0x5F83A20", VA = "0x185F84620")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5F846E0", Offset = "0x5F83AE0", VA = "0x185F846E0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5F846A0", Offset = "0x5F83AA0", VA = "0x185F846A0")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5F84720", Offset = "0x5F83B20", VA = "0x185F84720")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[FKPOFLLNLIF]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5F82CC0", Offset = "0x5F820C0", VA = "0x185F82CC0")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[FKPOFLLNLIF]
	[Preserve]
	public sealed class NamedUnityBooleanEvent : NamedUnityEventBase<UnityBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5F82C80", Offset = "0x5F82080", VA = "0x185F82C80")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[FKPOFLLNLIF]
	[Preserve]
	public sealed class NamedUnityFloatEvent : NamedUnityEventBase<UnityFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5F82D00", Offset = "0x5F82100", VA = "0x185F82D00")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[FKPOFLLNLIF]
	[Preserve]
	public sealed class NamedUnityIntEvent : NamedUnityEventBase<UnityIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5F82D40", Offset = "0x5F82140", VA = "0x185F82D40")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Preserve]
	[FKPOFLLNLIF]
	public sealed class NamedUnityStringEvent : NamedUnityEventBase<UnityStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5F82DC0", Offset = "0x5F821C0", VA = "0x185F82DC0")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[FKPOFLLNLIF]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityEventBase<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5F82D80", Offset = "0x5F82180", VA = "0x185F82D80")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[FKPOFLLNLIF]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityEventBase<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5F82E00", Offset = "0x5F82200", VA = "0x185F82E00")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[FKPOFLLNLIF]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityEventBase<UnityStringIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5F82E40", Offset = "0x5F82240", VA = "0x185F82E40")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[FKPOFLLNLIF]
	public sealed class NamedUnityStringStringEvent : NamedUnityEventBase<UnityStringStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5F82E80", Offset = "0x5F82280", VA = "0x185F82E80")]
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
		[LIKFAKMILGO]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[JCEKOMMILON("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[JCEKOMMILON("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
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
		[IMPOOABBGKD("isBuiltInObject", false)]
		private BGAFKMFEGKB physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[IMPOOABBGKD("isShapeContainer", true)]
		private IOHNLONDANK shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[HideInInspector]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x671270", Offset = "0x670670", VA = "0x180671270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5F83A00", Offset = "0x5F82E00", VA = "0x185F83A00")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum BGAFKMFEGKB
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum IOHNLONDANK
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
		private static RecRoomObjectPrefabRegistry AEBBMADEDFF;

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
		public static RecRoomObjectPrefabRegistry PNBICMAKACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5F83D10", Offset = "0x5F83110", VA = "0x185F83D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> NGNCMGKKFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5F83C70", Offset = "0x5F83070", VA = "0x185F83C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5F83A50", Offset = "0x5F82E50", VA = "0x185F83A50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5F83B40", Offset = "0x5F82F40", VA = "0x185F83B40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5F83A10", Offset = "0x5F82E10", VA = "0x185F83A10")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x26643F0", Offset = "0x26637F0", VA = "0x1826643F0")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct BKPFPHLHMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public byte[] KMDDNICFCGP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x882B80", Offset = "0x881F80", VA = "0x180882B80")]
	public BKPFPHLHMPE(byte[] EGDJKJOHALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct HCJEHENEEJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte[] KMDDNICFCGP;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x882B80", Offset = "0x881F80", VA = "0x180882B80")]
	public HCJEHENEEJI(byte[] EGDJKJOHALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CBIHBGNNPAO
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5F80510", Offset = "0x5F7F910", VA = "0x185F80510")]
	public static (BKPFPHLHMPE, HCJEHENEEJI) FDJJIBLHJOK(Stream GHBMNGPKFNO)
	{
		return default((BKPFPHLHMPE, HCJEHENEEJI));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5F806D0", Offset = "0x5F7FAD0", VA = "0x185F806D0")]
	public static void LKBEHFANGHN(Stream GHBMNGPKFNO, BKPFPHLHMPE OAGMMIBDFHK, HCJEHENEEJI BLMFGCGNMBG)
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
			[Cpp2IlInjected.Address(RVA = "0x1EE5BB0", Offset = "0x1EE4FB0", VA = "0x181EE5BB0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8D20", Offset = "0x5ED8120", VA = "0x185ED8D20")]
		public SerializedGuid(in Guid KIDLKIGCBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8C60", Offset = "0x5ED8060", VA = "0x185ED8C60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5F843C0", Offset = "0x5F837C0", VA = "0x185F843C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5F84310", Offset = "0x5F83710", VA = "0x185F84310", Slot = "7")]
		public bool Equals(SerializedGuid BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5F84230", Offset = "0x5F83630", VA = "0x185F84230", Slot = "0")]
		public override bool Equals(object HKFNIHLBEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8A90", Offset = "0x5ED7E90", VA = "0x185ED8A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5ED88D0", Offset = "0x5ED7CD0", VA = "0x185ED88D0", Slot = "6")]
		public int CompareTo(SerializedGuid BKBGGIICJOJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[AttributeUsage(AttributeTargets.Class)]
public class FKPOFLLNLIF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
	public FKPOFLLNLIF()
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
