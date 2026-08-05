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
	[Cpp2IlInjected.Address(RVA = "0x63EF6C0", Offset = "0x63EEAC0", VA = "0x1863EF6C0")]
	public bool EAEJEOPOHDH(Collider NCCADNBJIIB, ref Bounds LIJLBDEDOGL, bool CGOBAKLPKEA, bool OOACFEMGCJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63F0220", Offset = "0x63EF620", VA = "0x1863F0220")]
	public bool GGCEBMKNIPF(Collider ECKJDAFJMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63EFC50", Offset = "0x63EF050", VA = "0x1863EFC50")]
	public bool FDFHMLKMGAG(Collider ECKJDAFJMBK, bool CGOBAKLPKEA, bool OOACFEMGCJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63EEBC0", Offset = "0x63EDFC0", VA = "0x1863EEBC0")]
	public void BFOKJMAJAFC(OJHJHPHOGML IHIJPIJNLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63F0240", Offset = "0x63EF640", VA = "0x1863F0240")]
	private static void JGJPMNGAMEJ(ref Vector3 LOOCNKEBNDJ, ref Vector3 KLDHGDMNHDJ, Vector3 CLGJADBGBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x63F00B0", Offset = "0x63EF4B0", VA = "0x1863F00B0")]
	public static OJHJHPHOGML GDJKGEKMHLD(GameObject LBGMPPHBAAC, Quaternion MCFIHGJCDCP, bool IGHGBNPCCBC, bool GGEELFGLOAH, bool CGOBAKLPKEA = false, bool OOACFEMGCJN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AudioMixerGroup OPIPILGKEFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string EIJDGODMFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x63ED1D0", Offset = "0x63EC5D0", VA = "0x1863ED1D0")]
		internal IDEHMJHALJL(AudioMixerGroup HMGHGFKHJGL, IDEHMJHALJL GPFONCECPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DEMIOJDJEDD JFKDKJJPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x63ED360", Offset = "0x63EC760", VA = "0x1863ED360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
	private IEMBKFEEAAM(IDEHMJHALJL KJINJFGHILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x63ED970", Offset = "0x63ECD70", VA = "0x1863ED970")]
	public static IEMBKFEEAAM NNICNMEINKL(AudioMixer AOPJJMPFAJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x63ED3C0", Offset = "0x63EC7C0", VA = "0x1863ED3C0")]
	public DEMIOJDJEDD IHGOIHKKABE(string OGKJDCPLFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63ED720", Offset = "0x63ECB20", VA = "0x1863ED720")]
	public DEMIOJDJEDD IHGOIHKKABE(AudioMixerGroup HMGHGFKHJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63ED2E0", Offset = "0x63EC6E0", VA = "0x1863ED2E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x63EE8C0", Offset = "0x63EDCC0", VA = "0x1863EE8C0")]
	public NGEILJIJFPH(string CGCMEEFENJL, bool AAKJHOMMFNF, string LFKOHDFEMNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class JJEEDCLMBLP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63EDC70", Offset = "0x63ED070", VA = "0x1863EDC70")]
	protected JJEEDCLMBLP(string CGCMEEFENJL, bool LPKIEPPBIHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class OCGDFBEOFAH : JJEEDCLMBLP
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63EEB60", Offset = "0x63EDF60", VA = "0x1863EEB60")]
	public OCGDFBEOFAH(string CGCMEEFENJL, bool AAKJHOMMFNF, bool LPKIEPPBIHF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Field)]
public class DKBDEHAOPPG : JJEEDCLMBLP
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63ED170", Offset = "0x63EC570", VA = "0x1863ED170")]
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
			[Cpp2IlInjected.Address(RVA = "0x63EDDA0", Offset = "0x63ED1A0", VA = "0x1863EDDA0")]
			public void FECBLCJFMLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63EDCC0", Offset = "0x63ED0C0", VA = "0x1863EDCC0")]
			public float EKFPAIJIDEO(string IGHJIHNAPBA)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x63EDD30", Offset = "0x63ED130", VA = "0x1863EDD30")]
			public float EKFPAIJIDEO(int MPKOBDPILJB)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63EE340", Offset = "0x63ED740", VA = "0x1863EE340")]
			public Texture LBDHNIIJGCM(int MPKOBDPILJB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63EE2C0", Offset = "0x63ED6C0", VA = "0x1863EE2C0")]
			public Vector4 KAJBLGEJCEG(int MPKOBDPILJB)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63EE3B0", Offset = "0x63ED7B0", VA = "0x1863EE3B0")]
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
		[HideInInspector]
		[SerializeField]
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
			[Cpp2IlInjected.Address(RVA = "0x63EE880", Offset = "0x63EDC80", VA = "0x1863EE880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MaterialEntry[] CEKGAMEFPON
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63EE7F0", Offset = "0x63EDBF0", VA = "0x1863EE7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63EE470", Offset = "0x63ED870", VA = "0x1863EE470")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63EE750", Offset = "0x63EDB50", VA = "0x1863EE750")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63EE6E0", Offset = "0x63EDAE0", VA = "0x1863EE6E0")]
		public MaterialEntry GetEntryForMaterial(Material IJMCIDCEJPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x63EE430", Offset = "0x63ED830", VA = "0x1863EE430")]
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
	[Cpp2IlInjected.Address(RVA = "0x8603E0", Offset = "0x85F7E0", VA = "0x1808603E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x63F12E0", Offset = "0x63F06E0", VA = "0x1863F12E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AudioMixer CDBGOBHJHEN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EIOIMMEOHBA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63F1340", Offset = "0x63F0740", VA = "0x1863F1340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ICIDGPEDMIA DMLEMNEAJDL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080")]
			get
			{
				return default(ICIDGPEDMIA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63F14B0", Offset = "0x63F08B0", VA = "0x1863F14B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63F0720", Offset = "0x63EFB20", VA = "0x1863F0720")]
		public static string GetAudioGroupPath(OPKEOBELBFG KPHFAPPDHMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63F0840", Offset = "0x63EFC40", VA = "0x1863F0840")]
		public AudioMixerGroup GetMixerGroup(OPKEOBELBFG KPHFAPPDHMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63F0A40", Offset = "0x63EFE40", VA = "0x1863F0A40")]
		private static AudioMixerGroup INFLCPFIMED(AudioMixer AOPJJMPFAJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63F0370", Offset = "0x63EF770", VA = "0x1863F0370")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63F0ED0", Offset = "0x63F02D0", VA = "0x1863F0ED0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63F0AF0", Offset = "0x63EFEF0", VA = "0x1863F0AF0")]
		public bool IsValidOutputGroup(AudioMixerGroup BCLPHHNIPBL, out string GNLLAOFLEDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x63F0D40", Offset = "0x63F0140", VA = "0x1863F0D40")]
		private bool NEMAMNBKLOK(AudioMixerGroup BCLPHHNIPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x63F04A0", Offset = "0x63EF8A0", VA = "0x1863F04A0")]
		private bool GMGBFOPLGEP(AudioMixerGroup FCFEDILIKPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
		[HideInInspector]
		[SerializeField]
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
		[SerializeField]
		[PPAIFPDLJAB]
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
			[Cpp2IlInjected.Address(RVA = "0x63F1A40", Offset = "0x63F0E40", VA = "0x1863F1A40")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63F1AD0", Offset = "0x63F0ED0", VA = "0x1863F1AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string HEOCCDCMFEI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7062B0", Offset = "0x7056B0", VA = "0x1807062B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public HPKOGMFCBFB IIKBMMPDKAM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F0AD0", Offset = "0x6EFED0", VA = "0x1806F0AD0")]
			get
			{
				return default(HPKOGMFCBFB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F0C30", Offset = "0x6F0030", VA = "0x1806F0C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool LNECELLNEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6E4370", Offset = "0x6E3770", VA = "0x1806E4370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6E43F0", Offset = "0x6E37F0", VA = "0x1806E43F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ADKOBEFMNGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6ECE40", Offset = "0x6EC240", VA = "0x1806ECE40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x811340", Offset = "0x810740", VA = "0x180811340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool EGGGJPDHCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6ECE50", Offset = "0x6EC250", VA = "0x1806ECE50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD5B550", Offset = "0xD5A950", VA = "0x180D5B550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool LBPDACEMMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x63F1A20", Offset = "0x63F0E20", VA = "0x1863F1A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool KCBNBFGHHEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63F19D0", Offset = "0x63F0DD0", VA = "0x1863F19D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63F1990", Offset = "0x63F0D90", VA = "0x1863F1990")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7530C0", Offset = "0x7524C0", VA = "0x1807530C0")]
		public void SetSpawnableTemplateData(byte[] EIPGFAKPKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8498D0", Offset = "0x848CD0", VA = "0x1808498D0")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
			[Cpp2IlInjected.Address(RVA = "0x63F17D0", Offset = "0x63F0BD0", VA = "0x1863F17D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x63F1760", Offset = "0x63F0B60", VA = "0x1863F1760")]
		public void PDKKHKBOKIJ(IEnumerable<RecRoomBuiltInObject> FPNKBKPFPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x63F1560", Offset = "0x63F0960", VA = "0x1863F1560")]
		public bool CPKINNFJFHF(Guid POFJMBABMDF, out RecRoomBuiltInObject MJHHNOHNEKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
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
		[HideInInspector]
		[SerializeReference]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NamedUnityEventBase[] UnityEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RecRoomObjectConfiguration DefaultConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63F22F0", Offset = "0x63F16F0", VA = "0x1863F22F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x63F1E90", Offset = "0x63F1290", VA = "0x1863F1E90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x63F1F80", Offset = "0x63F1380", VA = "0x1863F1F80")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9230", Offset = "0x3CF8630", VA = "0x183CF9230")]
		private bool TryRaiseUnityEvent<T0, TEvent>(string eventName, T0 value) where TEvent : UnityEvent<T0>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9310", Offset = "0x3CF8710", VA = "0x183CF9310")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x63F2150", Offset = "0x63F1550", VA = "0x1863F2150")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x63F2290", Offset = "0x63F1690", VA = "0x1863F2290")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63F2010", Offset = "0x63F1410", VA = "0x1863F2010")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63F1F20", Offset = "0x63F1320", VA = "0x1863F1F20")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x63F21B0", Offset = "0x63F15B0", VA = "0x1863F21B0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x63F20E0", Offset = "0x63F14E0", VA = "0x1863F20E0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x63F2070", Offset = "0x63F1470", VA = "0x1863F2070")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63F2220", Offset = "0x63F1620", VA = "0x1863F2220")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9120", Offset = "0x3CF8520", VA = "0x183CF9120")]
		private static bool TryFindEvent<TEvent>(NamedUnityEventBase[] eventStorage, string eventName, out TEvent result) where TEvent : UnityEventBase, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3B44EC0", Offset = "0x3B442C0", VA = "0x183B44EC0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63F26A0", Offset = "0x63F1AA0", VA = "0x1863F26A0")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x63F26E0", Offset = "0x63F1AE0", VA = "0x1863F26E0")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x63F2720", Offset = "0x63F1B20", VA = "0x1863F2720")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63F27A0", Offset = "0x63F1BA0", VA = "0x1863F27A0")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63F2760", Offset = "0x63F1B60", VA = "0x1863F2760")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63F2820", Offset = "0x63F1C20", VA = "0x1863F2820")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63F27E0", Offset = "0x63F1BE0", VA = "0x1863F27E0")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63F2860", Offset = "0x63F1C60", VA = "0x1863F2860")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[OFOABBIOCBC]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x63EE960", Offset = "0x63EDD60", VA = "0x1863EE960")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[OFOABBIOCBC]
	public sealed class NamedUnityBooleanEvent : NamedUnityEventBase<UnityBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63EE920", Offset = "0x63EDD20", VA = "0x1863EE920")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Preserve]
	[OFOABBIOCBC]
	public sealed class NamedUnityFloatEvent : NamedUnityEventBase<UnityFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63EE9A0", Offset = "0x63EDDA0", VA = "0x1863EE9A0")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Preserve]
	[OFOABBIOCBC]
	public sealed class NamedUnityIntEvent : NamedUnityEventBase<UnityIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63EE9E0", Offset = "0x63EDDE0", VA = "0x1863EE9E0")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[OFOABBIOCBC]
	[Preserve]
	public sealed class NamedUnityStringEvent : NamedUnityEventBase<UnityStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63EEA60", Offset = "0x63EDE60", VA = "0x1863EEA60")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[OFOABBIOCBC]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityEventBase<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63EEA20", Offset = "0x63EDE20", VA = "0x1863EEA20")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[Preserve]
	[OFOABBIOCBC]
	public sealed class NamedUnityStringFloatEvent : NamedUnityEventBase<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x63EEAA0", Offset = "0x63EDEA0", VA = "0x1863EEAA0")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[OFOABBIOCBC]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityEventBase<UnityStringIntEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63EEAE0", Offset = "0x63EDEE0", VA = "0x1863EEAE0")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	[OFOABBIOCBC]
	public sealed class NamedUnityStringStringEvent : NamedUnityEventBase<UnityStringStringEvent>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63EEB20", Offset = "0x63EDF20", VA = "0x1863EEB20")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[PPAIFPDLJAB]
		[SerializeField]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		[NGEILJIJFPH("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		[NGEILJIJFPH("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		[OCGDFBEOFAH("isBuiltInObject", false, false)]
		[Header("Physics")]
		private JOEBNEPBLPD physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[OCGDFBEOFAH("isShapeContainer", true, false)]
		private MCAGJINOLEF shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[HideInInspector]
		[SerializeField]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x75DD30", Offset = "0x75D130", VA = "0x18075DD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63F1B40", Offset = "0x63F0F40", VA = "0x1863F1B40")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public enum JOEBNEPBLPD
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum MCAGJINOLEF
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Physical_Sticky = 2,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Physical = 4
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[AddComponentMenu("")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static RecRoomObjectPrefabRegistry MPOGNODCFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[HideInInspector]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private RecRoomObjectPrefabRegistryAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RecRoomObjectPrefabRegistry HNEIEBONIJN
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x63F1E50", Offset = "0x63F1250", VA = "0x1863F1E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> GHNIKECJOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x63F1DB0", Offset = "0x63F11B0", VA = "0x1863F1DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63F1B90", Offset = "0x63F0F90", VA = "0x1863F1B90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63F1C80", Offset = "0x63F1080", VA = "0x1863F1C80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class RecRoomObjectPrefabEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public RecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class RecRoomObjectPrefabRegistryAsset : RecRoomStudioBuildAsset<RecRoomObjectPrefabRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public RecRoomObjectPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x63F1B50", Offset = "0x63F0F50", VA = "0x1863F1B50")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x30871F0", Offset = "0x30865F0", VA = "0x1830871F0")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct AGMFMILDAED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public byte[] MPBLDBHOKNB;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F00", Offset = "0x6E1300", VA = "0x1806E1F00")]
	public AGMFMILDAED(byte[] KBGLHNCEHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct NIIJOJLHBLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte[] MPBLDBHOKNB;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F00", Offset = "0x6E1300", VA = "0x1806E1F00")]
	public NIIJOJLHBLG(byte[] KBGLHNCEHFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AKMNFDFKDPH
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x63ECE60", Offset = "0x63EC260", VA = "0x1863ECE60")]
	public static (AGMFMILDAED, NIIJOJLHBLG) FDJAJDOLNJP(Stream DMEDBCCHBBH)
	{
		return default((AGMFMILDAED, NIIJOJLHBLG));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x63ED020", Offset = "0x63EC420", VA = "0x1863ED020")]
	public static void FENJLIEEGIM(Stream DMEDBCCHBBH, AGMFMILDAED GDKBHGNBDKI, NIIJOJLHBLG LAODEMMELPI)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA917F0", Offset = "0xA90BF0", VA = "0x180A917F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6395DC0", Offset = "0x63951C0", VA = "0x186395DC0")]
		public SerializedGuid(in Guid JHHPNHDNIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6395D90", Offset = "0x6395190", VA = "0x186395D90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63F2500", Offset = "0x63F1900", VA = "0x1863F2500", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63F2450", Offset = "0x63F1850", VA = "0x1863F2450", Slot = "7")]
		public bool Equals(SerializedGuid IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x63F2370", Offset = "0x63F1770", VA = "0x1863F2370", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6395BC0", Offset = "0x6394FC0", VA = "0x186395BC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6395970", Offset = "0x6394D70", VA = "0x186395970", Slot = "6")]
		public int CompareTo(SerializedGuid IHIJPIJNLJM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[AttributeUsage(AttributeTargets.Class)]
public class OFOABBIOCBC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
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
