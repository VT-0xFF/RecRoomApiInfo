using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OJHJHPHOGML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 ALABIEJADJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion MCFIHGJCDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 PJIEILELJLE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63C0E20", Offset = "0x63C0020", VA = "0x1863C0E20")]
	public bool EAEJEOPOHDH(Collider NCCADNBJIIB, ref Bounds LIJLBDEDOGL, bool CGOBAKLPKEA, bool OOACFEMGCJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63C1980", Offset = "0x63C0B80", VA = "0x1863C1980")]
	public bool GGCEBMKNIPF(Collider ECKJDAFJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63C13B0", Offset = "0x63C05B0", VA = "0x1863C13B0")]
	public bool FDFHMLKMGAG(Collider ECKJDAFJMBK, bool CGOBAKLPKEA, bool OOACFEMGCJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63C0320", Offset = "0x63BF520", VA = "0x1863C0320")]
	public void BFOKJMAJAFC(OJHJHPHOGML IHIJPIJNLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63C19A0", Offset = "0x63C0BA0", VA = "0x1863C19A0")]
	private static void JGJPMNGAMEJ(ref Vector3 LOOCNKEBNDJ, ref Vector3 KLDHGDMNHDJ, Vector3 CLGJADBGBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x63C1810", Offset = "0x63C0A10", VA = "0x1863C1810")]
	public static OJHJHPHOGML GDJKGEKMHLD(GameObject LBGMPPHBAAC, Quaternion MCFIHGJCDCP, bool IGHGBNPCCBC, bool GGEELFGLOAH, bool CGOBAKLPKEA = false, bool OOACFEMGCJN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public OJHJHPHOGML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FBLFJAEJNDC : byte
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
public interface DEMIOJDJEDD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AudioMixerGroup OPIPILGKEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DEMIOJDJEDD EMIBHNNCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<DEMIOJDJEDD> LILCAAEDFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string EIJDGODMFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IEMBKFEEAAM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class IDEHMJHALJL : DEMIOJDJEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly List<DEMIOJDJEDD> BBEHGLGEMJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly IDEHMJHALJL GAKLMOMBEEN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DEMIOJDJEDD EMIBHNNCMJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AudioMixerGroup OPIPILGKEFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<DEMIOJDJEDD> LILCAAEDFCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string EIJDGODMFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x63BE930", Offset = "0x63BDB30", VA = "0x1863BE930")]
		internal IDEHMJHALJL(AudioMixerGroup HMGHGFKHJGL, IDEHMJHALJL GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DEMIOJDJEDD JFKDKJJPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AudioMixer HLGOBPFEPND
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63BEAC0", Offset = "0x63BDCC0", VA = "0x1863BEAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F40", Offset = "0x6C7140", VA = "0x1806C7F40")]
	private IEMBKFEEAAM(IDEHMJHALJL KJINJFGHILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x63BF0D0", Offset = "0x63BE2D0", VA = "0x1863BF0D0")]
	public static IEMBKFEEAAM NNICNMEINKL(AudioMixer AOPJJMPFAJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x63BEB20", Offset = "0x63BDD20", VA = "0x1863BEB20")]
	public DEMIOJDJEDD IHGOIHKKABE(string OGKJDCPLFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63BEE80", Offset = "0x63BE080", VA = "0x1863BEE80")]
	public DEMIOJDJEDD IHGOIHKKABE(AudioMixerGroup HMGHGFKHJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63BEA40", Offset = "0x63BDC40", VA = "0x1863BEA40")]
	private static int CIANIHCHLBG(string BENGLHDIHMD, int IDCHKLCNMBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Field)]
public class NGEILJIJFPH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63C0020", Offset = "0x63BF220", VA = "0x1863C0020")]
	public NGEILJIJFPH(string CGCMEEFENJL, bool AAKJHOMMFNF, string LFKOHDFEMNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class JJEEDCLMBLP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63BF3D0", Offset = "0x63BE5D0", VA = "0x1863BF3D0")]
	protected JJEEDCLMBLP(string CGCMEEFENJL, bool LPKIEPPBIHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class OCGDFBEOFAH : JJEEDCLMBLP
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63C02C0", Offset = "0x63BF4C0", VA = "0x1863C02C0")]
	public OCGDFBEOFAH(string CGCMEEFENJL, bool AAKJHOMMFNF, bool LPKIEPPBIHF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Field)]
public class DKBDEHAOPPG : JJEEDCLMBLP
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63BE8D0", Offset = "0x63BDAD0", VA = "0x1863BE8D0")]
	public DKBDEHAOPPG(string CGCMEEFENJL, int AAKJHOMMFNF, bool LPKIEPPBIHF = false)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[AddComponentMenu("")]
	public class MaterialMap : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class TextureProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Texture value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class FloatProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class VectorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Vector4 value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class ColorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Color value;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class MaterialEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public string shaderName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public MaterialGlobalIlluminationFlags globalIlluminationFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int renderQueue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public bool doubleSidedGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public TextureProperty[] texProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FloatProperty[] floatProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public VectorProperty[] vecProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public ColorProperty[] colorProps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private Dictionary<string, float> floatPropsDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private Dictionary<int, float> floatPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private Dictionary<int, Texture> texPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Dictionary<int, Vector4> vecPropIdDict;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private Dictionary<int, Color> colorPropIdDict;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x63BF500", Offset = "0x63BE700", VA = "0x1863BF500")]
			public void FECBLCJFMLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63BF420", Offset = "0x63BE620", VA = "0x1863BF420")]
			public float EKFPAIJIDEO(string IGHJIHNAPBA)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x63BF490", Offset = "0x63BE690", VA = "0x1863BF490")]
			public float EKFPAIJIDEO(int MPKOBDPILJB)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63BFAA0", Offset = "0x63BECA0", VA = "0x1863BFAA0")]
			public Texture LBDHNIIJGCM(int MPKOBDPILJB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63BFA20", Offset = "0x63BEC20", VA = "0x1863BFA20")]
			public Vector4 KAJBLGEJCEG(int MPKOBDPILJB)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63BFB10", Offset = "0x63BED10", VA = "0x1863BFB10")]
			public Color NFNIKOELDOA(int MPKOBDPILJB)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static MaterialMap MPOGNODCFNK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<MaterialEntry> FEBOFKKCNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[HideInInspector]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private MaterialMapAsset entriesAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Dictionary<Material, MaterialEntry> DDCIPKMKIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HashSet<Material> PHDEPBFNKMG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static MaterialMap HNEIEBONIJN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63BFFE0", Offset = "0x63BF1E0", VA = "0x1863BFFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MaterialEntry[] CEKGAMEFPON
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63BFF50", Offset = "0x63BF150", VA = "0x1863BFF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63BFBD0", Offset = "0x63BEDD0", VA = "0x1863BFBD0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63BFEB0", Offset = "0x63BF0B0", VA = "0x1863BFEB0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63BFE40", Offset = "0x63BF040", VA = "0x1863BFE40")]
		public MaterialEntry GetEntryForMaterial(Material IJMCIDCEJPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public MaterialMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MaterialMapAsset : RecRoomStudioBuildAsset<MaterialMapAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private MaterialMap.MaterialEntry[] entries;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public MaterialMap.MaterialEntry[] Entries
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x63BFB90", Offset = "0x63BED90", VA = "0x1863BFB90")]
		public MaterialMapAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[AttributeUsage(AttributeTargets.Field)]
public class PPAIFPDLJAB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE0", Offset = "0x72DEE0", VA = "0x18072ECE0")]
	public PPAIFPDLJAB()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AddComponentMenu("")]
	public sealed class RecRoomAudioMixerRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum ICIDGPEDMIA
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum OPKEOBELBFG
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			Ambience,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			Sounds,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			Voice,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Voice_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Voice_HighPitch,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Voice_Radio,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Voice_Radio_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			Voice_Radio_HighPitch
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly Dictionary<OPKEOBELBFG, string> GMPDCIINAKM;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string PHJHKBIICNH = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string PHDNJMBEGNE = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string KCGNALMGOIB = "Audio";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly string LLPEBJOFOHK;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly string FPOOHHBEAGM;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static RecRoomAudioMixerRegistry MPOGNODCFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[PPAIFPDLJAB]
		private ICIDGPEDMIA version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[DKBDEHAOPPG("version", 0, true)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[DKBDEHAOPPG("version", 0, true)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[DKBDEHAOPPG("version", 0, true)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[DKBDEHAOPPG("version", 1, true)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static RecRoomAudioMixerRegistry HNEIEBONIJN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A40", Offset = "0x63C1C40", VA = "0x1863C2A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AudioMixer CDBGOBHJHEN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63C2AA0", Offset = "0x63C1CA0", VA = "0x1863C2AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ICIDGPEDMIA DMLEMNEAJDL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6C8BD0", Offset = "0x6C7DD0", VA = "0x1806C8BD0")]
			get
			{
				return default(ICIDGPEDMIA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63C2C10", Offset = "0x63C1E10", VA = "0x1863C2C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63C1E80", Offset = "0x63C1080", VA = "0x1863C1E80")]
		public static string GetAudioGroupPath(OPKEOBELBFG KPHFAPPDHMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63C1FA0", Offset = "0x63C11A0", VA = "0x1863C1FA0")]
		public AudioMixerGroup GetMixerGroup(OPKEOBELBFG KPHFAPPDHMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63C21A0", Offset = "0x63C13A0", VA = "0x1863C21A0")]
		private static AudioMixerGroup INFLCPFIMED(AudioMixer AOPJJMPFAJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63C1AD0", Offset = "0x63C0CD0", VA = "0x1863C1AD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63C2630", Offset = "0x63C1830", VA = "0x1863C2630")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63C2250", Offset = "0x63C1450", VA = "0x1863C2250")]
		public bool IsValidOutputGroup(AudioMixerGroup BCLPHHNIPBL, out string GNLLAOFLEDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x63C24A0", Offset = "0x63C16A0", VA = "0x1863C24A0")]
		private bool NEMAMNBKLOK(AudioMixerGroup BCLPHHNIPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x63C1C00", Offset = "0x63C0E00", VA = "0x1863C1C00")]
		private bool GMGBFOPLGEP(AudioMixerGroup FCFEDILIKPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AddComponentMenu("")]
	public class RecRoomBuiltInObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[HideInInspector]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[PPAIFPDLJAB]
		[SerializeField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[PPAIFPDLJAB]
		[SerializeField]
		private HPKOGMFCBFB category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		[SerializeField]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[PPAIFPDLJAB]
		[SerializeField]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[PPAIFPDLJAB]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[HideInInspector]
		[SerializeField]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid DLIHIMKOICP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x63C31A0", Offset = "0x63C23A0", VA = "0x1863C31A0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63C3230", Offset = "0x63C2430", VA = "0x1863C3230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string HEOCCDCMFEI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6C8130", Offset = "0x6C7330", VA = "0x1806C8130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public HPKOGMFCBFB IIKBMMPDKAM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6E91B0", Offset = "0x6E83B0", VA = "0x1806E91B0")]
			get
			{
				return default(HPKOGMFCBFB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA0ABA0", Offset = "0xA09DA0", VA = "0x180A0ABA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool LNECELLNEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x792540", Offset = "0x791740", VA = "0x180792540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9284A0", Offset = "0x9276A0", VA = "0x1809284A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ADKOBEFMNGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA0E440", Offset = "0xA0D640", VA = "0x180A0E440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB4FD40", Offset = "0xB4EF40", VA = "0x180B4FD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool EGGGJPDHCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xE78C50", Offset = "0xE77E50", VA = "0x180E78C50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xE79300", Offset = "0xE78500", VA = "0x180E79300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool LBPDACEMMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x63C3180", Offset = "0x63C2380", VA = "0x1863C3180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool KCBNBFGHHEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63C3130", Offset = "0x63C2330", VA = "0x1863C3130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63C30F0", Offset = "0x63C22F0", VA = "0x1863C30F0")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0")]
		public void SetSpawnableTemplateData(byte[] EIPGFAKPKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xACEF00", Offset = "0xACE100", VA = "0x180ACEF00")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class RecRoomBuiltInObjectData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private RecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Dictionary<Guid, RecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private Dictionary<Guid, RecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x63C2F30", Offset = "0x63C2130", VA = "0x1863C2F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x63C2EC0", Offset = "0x63C20C0", VA = "0x1863C2EC0")]
		public void PDKKHKBOKIJ(IEnumerable<RecRoomBuiltInObject> FPNKBKPFPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x63C2CC0", Offset = "0x63C1EC0", VA = "0x1863C2CC0")]
		public bool CPKINNFJFHF(Guid POFJMBABMDF, out RecRoomBuiltInObject MJHHNOHNEKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xE21BA0", Offset = "0xE20DA0", VA = "0x180E21BA0")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum HPKOGMFCBFB
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Prop,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Gadget
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[OFOABBIOCBC]
	[DisallowMultipleComponent]
	[AddComponentMenu("Rec Room Studio/Rec Room Object")]
	public sealed class RecRoomObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		[HideInInspector]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeReference]
		[HideInInspector]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Dictionary<string, RecRoomObjectProperty> propertyLookup;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NamedUnityEventBase[] UnityEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RecRoomObjectConfiguration DefaultConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63C4020", Offset = "0x63C3220", VA = "0x1863C4020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x63C39E0", Offset = "0x63C2BE0", VA = "0x1863C39E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x63C3A70", Offset = "0x63C2C70", VA = "0x1863C3A70")]
		public bool TryGetProperty(string propertyName, out RecRoomObjectProperty property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63C3CB0", Offset = "0x63C2EB0", VA = "0x1863C3CB0")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x45DE3D0", Offset = "0x45DD5D0", VA = "0x1845DE3D0")]
		private bool TryRaiseUnityEvent<T0, TEvent>(string eventName, T0 value) where TEvent : UnityEvent<T0>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x45DE4B0", Offset = "0x45DD6B0", VA = "0x1845DE4B0")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x63C3E80", Offset = "0x63C3080", VA = "0x1863C3E80")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63C3FC0", Offset = "0x63C31C0", VA = "0x1863C3FC0")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63C3D40", Offset = "0x63C2F40", VA = "0x1863C3D40")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x63C3C50", Offset = "0x63C2E50", VA = "0x1863C3C50")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x63C3EE0", Offset = "0x63C30E0", VA = "0x1863C3EE0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x63C3E10", Offset = "0x63C3010", VA = "0x1863C3E10")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63C3DA0", Offset = "0x63C2FA0", VA = "0x1863C3DA0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63C3F50", Offset = "0x63C3150", VA = "0x1863C3F50")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x45DE2C0", Offset = "0x45DD4C0", VA = "0x1845DE2C0")]
		private static bool TryFindEvent<TEvent>(NamedUnityEventBase[] eventStorage, string eventName, out TEvent result) where TEvent : UnityEventBase, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3128870", Offset = "0x3127A70", VA = "0x183128870")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63C4430", Offset = "0x63C3630", VA = "0x1863C4430")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63C4470", Offset = "0x63C3670", VA = "0x1863C4470")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63C44B0", Offset = "0x63C36B0", VA = "0x1863C44B0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63C4530", Offset = "0x63C3730", VA = "0x1863C4530")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x63C44F0", Offset = "0x63C36F0", VA = "0x1863C44F0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63C45B0", Offset = "0x63C37B0", VA = "0x1863C45B0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63C4570", Offset = "0x63C3770", VA = "0x1863C4570")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63C45F0", Offset = "0x63C37F0", VA = "0x1863C45F0")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[OFOABBIOCBC]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63C00C0", Offset = "0x63BF2C0", VA = "0x1863C00C0")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Preserve]
	[OFOABBIOCBC]
	public sealed class NamedUnityBooleanEvent : NamedUnityEventBase<UnityBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63C0080", Offset = "0x63BF280", VA = "0x1863C0080")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Preserve]
	[OFOABBIOCBC]
	public sealed class NamedUnityFloatEvent : NamedUnityEventBase<UnityFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x63C0100", Offset = "0x63BF300", VA = "0x1863C0100")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Preserve]
	[OFOABBIOCBC]
	public sealed class NamedUnityIntEvent : NamedUnityEventBase<UnityIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63C0140", Offset = "0x63BF340", VA = "0x1863C0140")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[OFOABBIOCBC]
	[Preserve]
	public sealed class NamedUnityStringEvent : NamedUnityEventBase<UnityStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63C01C0", Offset = "0x63BF3C0", VA = "0x1863C01C0")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[OFOABBIOCBC]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityEventBase<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x63C0180", Offset = "0x63BF380", VA = "0x1863C0180")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[OFOABBIOCBC]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityEventBase<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63C0200", Offset = "0x63BF400", VA = "0x1863C0200")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[OFOABBIOCBC]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityEventBase<UnityStringIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63C0240", Offset = "0x63BF440", VA = "0x1863C0240")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Preserve]
	[OFOABBIOCBC]
	public sealed class NamedUnityStringStringEvent : NamedUnityEventBase<UnityStringStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63C0280", Offset = "0x63BF480", VA = "0x1863C0280")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[PPAIFPDLJAB]
		[SerializeField]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		[NGEILJIJFPH("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[NGEILJIJFPH("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		[OCGDFBEOFAH("isBuiltInObject", false, false)]
		[Header("Physics")]
		private JOEBNEPBLPD physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		[OCGDFBEOFAH("isShapeContainer", true, false)]
		private MCAGJINOLEF shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[HideInInspector]
		[SerializeField]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6CB270", Offset = "0x6CA470", VA = "0x1806CB270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63C32A0", Offset = "0x63C24A0", VA = "0x1863C32A0")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum JOEBNEPBLPD
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public enum MCAGJINOLEF
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Physical_Sticky = 2,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Physical = 4
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[AddComponentMenu("")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static RecRoomObjectPrefabRegistry MPOGNODCFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[HideInInspector]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private RecRoomObjectPrefabRegistryAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RecRoomObjectPrefabRegistry HNEIEBONIJN
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x63C35B0", Offset = "0x63C27B0", VA = "0x1863C35B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> GHNIKECJOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x63C3510", Offset = "0x63C2710", VA = "0x1863C3510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x63C32F0", Offset = "0x63C24F0", VA = "0x1863C32F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x63C33E0", Offset = "0x63C25E0", VA = "0x1863C33E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class RecRoomObjectPrefabEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public RecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class RecRoomObjectPrefabRegistryAsset : RecRoomStudioBuildAsset<RecRoomObjectPrefabRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public RecRoomObjectPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x63C32B0", Offset = "0x63C24B0", VA = "0x1863C32B0")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class RecRoomObjectProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x45DC4C0", Offset = "0x45DB6C0", VA = "0x1845DC4C0")]
		public bool CPKINNFJFHF<T>(out T JFBPNBNBHOE, out string GNLLAOFLEDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63C37D0", Offset = "0x63C29D0", VA = "0x1863C37D0")]
		public static string EBJFLFOGKDM(Type EHIBGNPGILO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x63C3760", Offset = "0x63C2960", VA = "0x1863C3760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63C35F0", Offset = "0x63C27F0", VA = "0x1863C35F0")]
		public MethodInfo DANEIEIBMCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63C3660", Offset = "0x63C2860", VA = "0x1863C3660")]
		public string HHJHINMIIFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2712180", Offset = "0x2711380", VA = "0x182712180")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct AGMFMILDAED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public byte[] MPBLDBHOKNB;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x89DDB0", Offset = "0x89CFB0", VA = "0x18089DDB0")]
	public AGMFMILDAED(byte[] KBGLHNCEHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct NIIJOJLHBLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public byte[] MPBLDBHOKNB;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x89DDB0", Offset = "0x89CFB0", VA = "0x18089DDB0")]
	public NIIJOJLHBLG(byte[] KBGLHNCEHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class AKMNFDFKDPH
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x63BE5C0", Offset = "0x63BD7C0", VA = "0x1863BE5C0")]
	public static (AGMFMILDAED, NIIJOJLHBLG) FDJAJDOLNJP(Stream DMEDBCCHBBH)
	{
		return default((AGMFMILDAED, NIIJOJLHBLG));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63BE780", Offset = "0x63BD980", VA = "0x1863BE780")]
	public static void FENJLIEEGIM(Stream DMEDBCCHBBH, AGMFMILDAED GDKBHGNBDKI, NIIJOJLHBLG LAODEMMELPI)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2AB4740", Offset = "0x2AB3940", VA = "0x182AB4740")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6359660", Offset = "0x6358860", VA = "0x186359660")]
		public SerializedGuid(in Guid JHHPNHDNIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6359630", Offset = "0x6358830", VA = "0x186359630", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63C4230", Offset = "0x63C3430", VA = "0x1863C4230", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x63C4180", Offset = "0x63C3380", VA = "0x1863C4180", Slot = "7")]
		public bool Equals(SerializedGuid IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63C40A0", Offset = "0x63C32A0", VA = "0x1863C40A0", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6359460", Offset = "0x6358660", VA = "0x186359460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6359210", Offset = "0x6358410", VA = "0x186359210", Slot = "6")]
		public int CompareTo(SerializedGuid IHIJPIJNLJM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[AttributeUsage(AttributeTargets.Class)]
public class OFOABBIOCBC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
	public OFOABBIOCBC()
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
