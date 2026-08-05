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
public class MIHHCGNHHPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 PIMNJLFIAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion IAPKIBMDFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 FMELHPLGFEA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6022650", Offset = "0x6021A50", VA = "0x186022650")]
	public bool BLPHAPABGMN(Collider MPOAAHNPLID, ref Bounds HGOHIFPNOAM, bool APFAFCLMBBF, bool EIPMNNCBCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60232E0", Offset = "0x60226E0", VA = "0x1860232E0")]
	public bool IIHFHLFDJDM(Collider LAPNDBKJOMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6022E80", Offset = "0x6022280", VA = "0x186022E80")]
	public bool IHPMJLAAONP(Collider LAPNDBKJOMI, bool APFAFCLMBBF, bool EIPMNNCBCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6023300", Offset = "0x6022700", VA = "0x186023300")]
	public void KBNNINLGHCD(MIHHCGNHHPN EPJIAIAEMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6022D50", Offset = "0x6022150", VA = "0x186022D50")]
	private static void GGPMBFPEDAF(ref Vector3 CMBNEELHPGN, ref Vector3 HKHDBDONGCO, Vector3 DJNOJJBOFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6022BE0", Offset = "0x6021FE0", VA = "0x186022BE0")]
	public static MIHHCGNHHPN EEFEMOIJELL(GameObject NMIIAOIKHMI, Quaternion IAPKIBMDFEP, bool NDKCHOMODPI, bool BJOHAFFMOGL, bool APFAFCLMBBF = false, bool EIPMNNCBCAG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MIHHCGNHHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NCCKGLDHHKI : byte
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
public class DKJDCINCGIM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60225A0", Offset = "0x60219A0", VA = "0x1860225A0")]
	public DKJDCINCGIM(string JLNILGJAKJL, bool CHMBFOAGKLB, string LKPKLKMLCHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class ELMGKCFMFJH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6022600", Offset = "0x6021A00", VA = "0x186022600")]
	public ELMGKCFMFJH(string JLNILGJAKJL, bool CHMBFOAGKLB)
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
			[Cpp2IlInjected.Address(RVA = "0x6023FD0", Offset = "0x60233D0", VA = "0x186023FD0")]
			public void JDCNLHBICKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6023E70", Offset = "0x6023270", VA = "0x186023E70")]
			public float GGKIEABEFLA(string DHKKANIEGMN)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6023E00", Offset = "0x6023200", VA = "0x186023E00")]
			public float GGKIEABEFLA(int FCLBEIEGADL)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6023EE0", Offset = "0x60232E0", VA = "0x186023EE0")]
			public Texture HIOIKJPMPGA(int FCLBEIEGADL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6023F50", Offset = "0x6023350", VA = "0x186023F50")]
			public Vector4 IAABKOKGLMG(int FCLBEIEGADL)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x60244F0", Offset = "0x60238F0", VA = "0x1860244F0")]
			public Color JPKJFPGAJBH(int FCLBEIEGADL)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static MaterialMap AGBKKGEFEHG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<MaterialEntry> BPHOHAIDBEG;

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
		private Dictionary<Material, MaterialEntry> DEDMBCBAECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HashSet<Material> HEGEGAHMGIF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MaterialMap KGKEDLDKCKD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x60249C0", Offset = "0x6023DC0", VA = "0x1860249C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MaterialEntry[] FLGNNEEHJED
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6024930", Offset = "0x6023D30", VA = "0x186024930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60245B0", Offset = "0x60239B0", VA = "0x1860245B0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6024890", Offset = "0x6023C90", VA = "0x186024890")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6024820", Offset = "0x6023C20", VA = "0x186024820")]
		public MaterialEntry GetEntryForMaterial(Material JOKMDEMCAFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6024570", Offset = "0x6023970", VA = "0x186024570")]
		public MaterialMapAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Field)]
public class ADBLBPLLBPD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0")]
	public ADBLBPLLBPD()
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
		private const string POIBOGLOJAF = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string HCBJKGHFFNC = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string MKALNHMGNFJ = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly string HNPDIJOOMMH;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly string OBHBFNKONFG;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static RecRoomAudioMixerRegistry AGBKKGEFEHG;

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
		public static RecRoomAudioMixerRegistry KGKEDLDKCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6025420", Offset = "0x6024820", VA = "0x186025420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AudioMixer PFNBHCFHJGP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AudioMixer FLDKMDBIBIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AudioMixer OOAAIDOMMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6024F50", Offset = "0x6024350", VA = "0x186024F50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60251E0", Offset = "0x60245E0", VA = "0x1860251E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6025080", Offset = "0x6024480", VA = "0x186025080")]
		public static bool IsValidOutputGroup(AudioMixerGroup HMKDECDGHFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
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
		[ADBLBPLLBPD]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[ADBLBPLLBPD]
		private NHFHEGNADGE category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[ADBLBPLLBPD]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[ADBLBPLLBPD]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[HideInInspector]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid KCGGHOGOAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6025990", Offset = "0x6024D90", VA = "0x186025990")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6025A20", Offset = "0x6024E20", VA = "0x186025A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HBNDJAAONPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NHFHEGNADGE NDPLHCLLOPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69A1B0", Offset = "0x6995B0", VA = "0x18069A1B0")]
			get
			{
				return default(NHFHEGNADGE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x82DDE0", Offset = "0x82D1E0", VA = "0x18082DDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OPDBIAGFKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x743540", Offset = "0x742940", VA = "0x180743540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x96BC90", Offset = "0x96B090", VA = "0x18096BC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IMCIBNLAGBO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA59D60", Offset = "0xA59160", VA = "0x180A59D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xBE8ED0", Offset = "0xBE82D0", VA = "0x180BE8ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HPOKIJDLGPG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xF37950", Offset = "0xF36D50", VA = "0x180F37950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xF37FC0", Offset = "0xF373C0", VA = "0x180F37FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool GHJALEPPJCE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6025970", Offset = "0x6024D70", VA = "0x186025970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool CCKKFPAOCDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6025920", Offset = "0x6024D20", VA = "0x186025920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60258B0", Offset = "0x6024CB0", VA = "0x1860258B0")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60258F0", Offset = "0x6024CF0", VA = "0x1860258F0")]
		public void SetSpawnableTemplateData(MLMDNBOHEEP AJBEEGFIHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB35A00", Offset = "0xB34E00", VA = "0x180B35A00")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x60256F0", Offset = "0x6024AF0", VA = "0x1860256F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6025480", Offset = "0x6024880", VA = "0x186025480")]
		public void ANOHOBIFIID(IEnumerable<RecRoomBuiltInObject> NMJALJOIOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60254F0", Offset = "0x60248F0", VA = "0x1860254F0")]
		public bool GAMCGCGFADK(Guid DNCFMIOIPEE, out RecRoomBuiltInObject IGDHMCCMBJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xEE1590", Offset = "0xEE0990", VA = "0x180EE1590")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NHFHEGNADGE
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
	[PEOPOCNLBKJ]
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
			[Cpp2IlInjected.Address(RVA = "0x6026240", Offset = "0x6025640", VA = "0x186026240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6025DE0", Offset = "0x60251E0", VA = "0x186025DE0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6025ED0", Offset = "0x60252D0", VA = "0x186025ED0")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3D82FF0", Offset = "0x3D823F0", VA = "0x183D82FF0")]
		private bool TryRaiseUnityEvent<T0, TEvent>(string eventName, T0 value) where TEvent : UnityEvent<T0>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3D830D0", Offset = "0x3D824D0", VA = "0x183D830D0")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60260A0", Offset = "0x60254A0", VA = "0x1860260A0")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60261E0", Offset = "0x60255E0", VA = "0x1860261E0")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6025F60", Offset = "0x6025360", VA = "0x186025F60")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6025E70", Offset = "0x6025270", VA = "0x186025E70")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6026100", Offset = "0x6025500", VA = "0x186026100")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6026030", Offset = "0x6025430", VA = "0x186026030")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6025FC0", Offset = "0x60253C0", VA = "0x186025FC0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6026170", Offset = "0x6025570", VA = "0x186026170")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3D82EE0", Offset = "0x3D822E0", VA = "0x183D82EE0")]
		private static bool TryFindEvent<TEvent>(NamedUnityEventBase[] eventStorage, string eventName, out TEvent result) where TEvent : UnityEventBase, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x39D67B0", Offset = "0x39D5BB0", VA = "0x1839D67B0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60265F0", Offset = "0x60259F0", VA = "0x1860265F0")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6026630", Offset = "0x6025A30", VA = "0x186026630")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6026670", Offset = "0x6025A70", VA = "0x186026670")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60266F0", Offset = "0x6025AF0", VA = "0x1860266F0")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60266B0", Offset = "0x6025AB0", VA = "0x1860266B0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6026770", Offset = "0x6025B70", VA = "0x186026770")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6026730", Offset = "0x6025B30", VA = "0x186026730")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60267B0", Offset = "0x6025BB0", VA = "0x1860267B0")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[PEOPOCNLBKJ]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6024A40", Offset = "0x6023E40", VA = "0x186024A40")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[PEOPOCNLBKJ]
	[Preserve]
	public sealed class NamedUnityBooleanEvent : NamedUnityEventBase<UnityBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6024A00", Offset = "0x6023E00", VA = "0x186024A00")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[PEOPOCNLBKJ]
	[Preserve]
	public sealed class NamedUnityFloatEvent : NamedUnityEventBase<UnityFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6024A80", Offset = "0x6023E80", VA = "0x186024A80")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[PEOPOCNLBKJ]
	[Preserve]
	public sealed class NamedUnityIntEvent : NamedUnityEventBase<UnityIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6024AC0", Offset = "0x6023EC0", VA = "0x186024AC0")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Preserve]
	[PEOPOCNLBKJ]
	public sealed class NamedUnityStringEvent : NamedUnityEventBase<UnityStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6024B40", Offset = "0x6023F40", VA = "0x186024B40")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[PEOPOCNLBKJ]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityEventBase<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6024B00", Offset = "0x6023F00", VA = "0x186024B00")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[PEOPOCNLBKJ]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityEventBase<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6024B80", Offset = "0x6023F80", VA = "0x186024B80")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[PEOPOCNLBKJ]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityEventBase<UnityStringIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6024BC0", Offset = "0x6023FC0", VA = "0x186024BC0")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[PEOPOCNLBKJ]
	public sealed class NamedUnityStringStringEvent : NamedUnityEventBase<UnityStringStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6024C00", Offset = "0x6024000", VA = "0x186024C00")]
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
		[ADBLBPLLBPD]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[DKJDCINCGIM("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[DKJDCINCGIM("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
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
		[ELMGKCFMFJH("isBuiltInObject", false)]
		private FNCMOFANJKF physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[ELMGKCFMFJH("isShapeContainer", true)]
		private KBOOAPFGFHB shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[HideInInspector]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x67C270", Offset = "0x67B670", VA = "0x18067C270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6025A90", Offset = "0x6024E90", VA = "0x186025A90")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum FNCMOFANJKF
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum KBOOAPFGFHB
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
		private static RecRoomObjectPrefabRegistry AGBKKGEFEHG;

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
		public static RecRoomObjectPrefabRegistry KGKEDLDKCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6025DA0", Offset = "0x60251A0", VA = "0x186025DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> HIJKMOJFEFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6025D00", Offset = "0x6025100", VA = "0x186025D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6025AE0", Offset = "0x6024EE0", VA = "0x186025AE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6025BD0", Offset = "0x6024FD0", VA = "0x186025BD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6025AA0", Offset = "0x6024EA0", VA = "0x186025AA0")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x26DE670", Offset = "0x26DDA70", VA = "0x1826DE670")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct FKJJJEGLOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public byte[] ADANCGEACAK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
	public FKJJJEGLOEJ(byte[] NEIPJLDAIJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct ELGHKGBCLJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte[] ADANCGEACAK;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
	public ELGHKGBCLJK(byte[] NEIPJLDAIJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PIFGFALPDHD
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6024C40", Offset = "0x6024040", VA = "0x186024C40")]
	public static (FKJJJEGLOEJ, ELGHKGBCLJK) BHJCOAINHBL(Stream DJGPEPEBOGE)
	{
		return default((FKJJJEGLOEJ, ELGHKGBCLJK));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6024E00", Offset = "0x6024200", VA = "0x186024E00")]
	public static void BPCKKMLKIGM(Stream DJGPEPEBOGE, FKJJJEGLOEJ EFAPNGJIOOF, ELGHKGBCLJK LHJAGPNOAJM)
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
			[Cpp2IlInjected.Address(RVA = "0x3015210", Offset = "0x3014610", VA = "0x183015210")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F727C0", Offset = "0x5F71BC0", VA = "0x185F727C0")]
		public SerializedGuid(in Guid NOCBJPFIBOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F72700", Offset = "0x5F71B00", VA = "0x185F72700", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6026450", Offset = "0x6025850", VA = "0x186026450", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60263A0", Offset = "0x60257A0", VA = "0x1860263A0", Slot = "7")]
		public bool Equals(SerializedGuid EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x60262C0", Offset = "0x60256C0", VA = "0x1860262C0", Slot = "0")]
		public override bool Equals(object JLBINKLPHKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5F72530", Offset = "0x5F71930", VA = "0x185F72530", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5F72370", Offset = "0x5F71770", VA = "0x185F72370", Slot = "6")]
		public int CompareTo(SerializedGuid EPJIAIAEMFF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[AttributeUsage(AttributeTargets.Class)]
public class PEOPOCNLBKJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
	public PEOPOCNLBKJ()
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
