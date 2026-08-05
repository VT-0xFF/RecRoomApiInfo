using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
public class ELMLGCOHLPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 OAJKJDMPILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion GCFIGFMOIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 ELCFFMHLBKP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1918CD0", Offset = "0x19180D0", VA = "0x181918CD0")]
	public bool LHEAKJFHOJG(Collider ECFBGBALBNM, ref Bounds BKEOBLCBLFH, bool GIKFKJKCMAC, bool OONOGCPEELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1919260", Offset = "0x1918660", VA = "0x181919260")]
	public bool NFFHHNMMGPJ(Collider JJJCLNDDKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1919280", Offset = "0x1918680", VA = "0x181919280")]
	public bool NMLHCOGNIPN(Collider JJJCLNDDKAD, bool GIKFKJKCMAC, bool OONOGCPEELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x19181D0", Offset = "0x19175D0", VA = "0x1819181D0")]
	public void KEMKAIFJBDB(ELMLGCOHLPJ FJLHJLAMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1917F30", Offset = "0x1917330", VA = "0x181917F30")]
	private static void FDFJLDJHIIL(ref Vector3 NEOBGLMFFNI, ref Vector3 OKNLCAAGMLN, Vector3 ALDCDDIJKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1918060", Offset = "0x1917460", VA = "0x181918060")]
	public static ELMLGCOHLPJ IKJMFFICPEJ(GameObject ALLJDBGIIHH, Quaternion GCFIGFMOIAL, bool CAAEGEBDBPC, bool JBOBDNDMBNJ, bool GIKFKJKCMAC = false, bool OONOGCPEELA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ELMLGCOHLPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ILLDDDGPNJK : byte
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
public interface DIIGPCHNJKN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AudioMixerGroup LMHMKEEOEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DIIGPCHNJKN DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<DIIGPCHNJKN> MKGCJNINDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string ANCIJCIPFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AOGHLLHMKED
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class EAKGCKCENPI : DIIGPCHNJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly List<DIIGPCHNJKN> GJNLAMNOICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly EAKGCKCENPI LEPLMGCPJNC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DIIGPCHNJKN DOOCCGCNAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AudioMixerGroup LMHMKEEOEOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<DIIGPCHNJKN> MKGCJNINDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ANCIJCIPFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1917E20", Offset = "0x1917220", VA = "0x181917E20")]
		internal EAKGCKCENPI(AudioMixerGroup MLMPFJIEGOP, EAKGCKCENPI CNDFBGEJOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DIIGPCHNJKN CLPAGBEIDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AudioMixer KAKFPOLMLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1917D40", Offset = "0x1917140", VA = "0x181917D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	private AOGHLLHMKED(EAKGCKCENPI HPIHCBCEKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1917A40", Offset = "0x1916E40", VA = "0x181917A40")]
	public static AOGHLLHMKED EKFKKKFEOHH(AudioMixer FJOAHNLJKCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x19176E0", Offset = "0x1916AE0", VA = "0x1819176E0")]
	public DIIGPCHNJKN ADHKBIBFFAE(string IBPHCCFNHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1917490", Offset = "0x1916890", VA = "0x181917490")]
	public DIIGPCHNJKN ADHKBIBFFAE(AudioMixerGroup MLMPFJIEGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1917DA0", Offset = "0x19171A0", VA = "0x181917DA0")]
	private static int KGJCJJDBGFP(string NMGICKMLDFI, int GJOFJPHNEOA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Field)]
public class PDFBNOJFOIE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x191B540", Offset = "0x191A940", VA = "0x18191B540")]
	public PDFBNOJFOIE(string MLBMAJEOEBG, bool LACEJKEMAIJ, string DCFCJKOFAJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class OAGEMBAJCCH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x191B4F0", Offset = "0x191A8F0", VA = "0x18191B4F0")]
	protected OAGEMBAJCCH(string MLBMAJEOEBG, bool PDFHGGAOKAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class PDGBOIBPNLF : OAGEMBAJCCH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x191B5A0", Offset = "0x191A9A0", VA = "0x18191B5A0")]
	public PDGBOIBPNLF(string MLBMAJEOEBG, bool LACEJKEMAIJ, bool PDFHGGAOKAG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Field)]
public class GMGCFHPCACE : OAGEMBAJCCH
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x19196E0", Offset = "0x1918AE0", VA = "0x1819196E0")]
	public GMGCFHPCACE(string MLBMAJEOEBG, int LACEJKEMAIJ, bool PDFHGGAOKAG = false)
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
			[Cpp2IlInjected.Address(RVA = "0x19197B0", Offset = "0x1918BB0", VA = "0x1819197B0")]
			public void DFKDLABAFFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1919D40", Offset = "0x1919140", VA = "0x181919D40")]
			public float ELPCLICCLAL(string LBEPPIIBMPA)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1919CD0", Offset = "0x19190D0", VA = "0x181919CD0")]
			public float ELPCLICCLAL(int IIMBCOAEFMJ)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1919740", Offset = "0x1918B40", VA = "0x181919740")]
			public Texture DDIAECNFFPL(int IIMBCOAEFMJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1919DB0", Offset = "0x19191B0", VA = "0x181919DB0")]
			public Vector4 JKEEBCGBPKH(int IIMBCOAEFMJ)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1919E30", Offset = "0x1919230", VA = "0x181919E30")]
			public Color NCAIMGAOBIP(int IIMBCOAEFMJ)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static MaterialMap GLONDIMDLCD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<MaterialEntry> BNMINLDDABK;

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
		private Dictionary<Material, MaterialEntry> NHDHIKFGCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HashSet<Material> PDCALKFFNBC;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static MaterialMap KGGJIHLJBIH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x191A300", Offset = "0x1919700", VA = "0x18191A300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MaterialEntry[] FNMJIKNIABB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x191A270", Offset = "0x1919670", VA = "0x18191A270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1919EF0", Offset = "0x19192F0", VA = "0x181919EF0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x191A1D0", Offset = "0x19195D0", VA = "0x18191A1D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x191A160", Offset = "0x1919560", VA = "0x18191A160")]
		public MaterialEntry GetEntryForMaterial(Material GFJAEJCHBJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1919EB0", Offset = "0x19192B0", VA = "0x181919EB0")]
		public MaterialMapAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[AttributeUsage(AttributeTargets.Field)]
public class KCMAKJMGFEL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640")]
	public KCMAKJMGFEL()
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AddComponentMenu("")]
	public sealed class RecRoomAudioClipRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static RecRoomAudioClipRegistry GLONDIMDLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private RecRoomAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static RecRoomAudioClipRegistry KGGJIHLJBIH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x191BC80", Offset = "0x191B080", VA = "0x18191BC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RecRoomAudioClipRegistryAsset FNMJIKNIABB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RecRoomAudioClipEntry> DIEEPKOGJKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x191BBC0", Offset = "0x191AFC0", VA = "0x18191BBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x191B9A0", Offset = "0x191ADA0", VA = "0x18191B9A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x191BA90", Offset = "0x191AE90", VA = "0x18191BA90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public RecRoomAudioClipRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class RecRoomAudioClipRegistryAsset : RecRoomStudioBuildAsset<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		internal RecRoomAudioClipEntry[] clips;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyList<RecRoomAudioClipEntry> Clips
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x191B950", Offset = "0x191AD50", VA = "0x18191B950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x191B910", Offset = "0x191AD10", VA = "0x18191B910")]
		public RecRoomAudioClipRegistryAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class RecRoomAudioClipEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AudioClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AddComponentMenu("")]
	public sealed class RecRoomAudioMixerRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum OONCNJBEFKB
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum MLLNFGMADAF
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Ambience,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Sounds,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			Voice,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Voice_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			Voice_HighPitch,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Voice_Radio,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			Voice_Radio_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Voice_Radio_HighPitch
		}

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly Dictionary<MLLNFGMADAF, string> ICKIMGPBJEP;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string PHALJGMEHEF = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const string KJADEIDDJGG = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string IGAIPJMCLPK = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string ODIEGMANBEI;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly string PNLGOCEHANF;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static RecRoomAudioMixerRegistry GLONDIMDLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		[KCMAKJMGFEL]
		private OONCNJBEFKB version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		[GMGCFHPCACE("version", 0, false)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		[GMGCFHPCACE("version", 0, false)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		[GMGCFHPCACE("version", 0, false)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		[GMGCFHPCACE("version", 1, false)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static RecRoomAudioMixerRegistry KGGJIHLJBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x191CC30", Offset = "0x191C030", VA = "0x18191CC30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AudioMixer LKFLAOJFLLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool BFCALEBFFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x191CC90", Offset = "0x191C090", VA = "0x18191CC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public OONCNJBEFKB OABDMKOGJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0")]
			get
			{
				return default(OONCNJBEFKB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x191CE00", Offset = "0x191C200", VA = "0x18191CE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x191BEA0", Offset = "0x191B2A0", VA = "0x18191BEA0")]
		public static string GetAudioGroupPath(MLLNFGMADAF FDLPOJGPBIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x191BFC0", Offset = "0x191B3C0", VA = "0x18191BFC0")]
		public AudioMixerGroup GetMixerGroup(MLLNFGMADAF FDLPOJGPBIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x191BDF0", Offset = "0x191B1F0", VA = "0x18191BDF0")]
		private static AudioMixerGroup EMPGDHPPOHC(AudioMixer FJOAHNLJKCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x191BCC0", Offset = "0x191B0C0", VA = "0x18191BCC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x191C820", Offset = "0x191BC20", VA = "0x18191C820")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x191C1C0", Offset = "0x191B5C0", VA = "0x18191C1C0")]
		public bool IsValidOutputGroup(AudioMixerGroup ADDBGHLNLHJ, out string MCGMECECHJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x191C410", Offset = "0x191B810", VA = "0x18191C410")]
		private bool KOBOIIDFCEH(AudioMixerGroup ADDBGHLNLHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x191C5A0", Offset = "0x191B9A0", VA = "0x18191C5A0")]
		private bool NANDNMLODKN(AudioMixerGroup EIFHJICHDIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[AddComponentMenu("")]
	public class RecRoomBuiltInObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[HideInInspector]
		[SerializeField]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[KCMAKJMGFEL]
		[SerializeField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[KCMAKJMGFEL]
		private BJIDANDEMNI category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		[SerializeField]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[KCMAKJMGFEL]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[KCMAKJMGFEL]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[HideInInspector]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Guid CFELHNDJMGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x191D390", Offset = "0x191C790", VA = "0x18191D390")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x191D420", Offset = "0x191C820", VA = "0x18191D420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string BPMBBFLJLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BJIDANDEMNI ABOEFOMGGEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x78F500", Offset = "0x78E900", VA = "0x18078F500")]
			get
			{
				return default(BJIDANDEMNI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x75DDF0", Offset = "0x75D1F0", VA = "0x18075DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool NKHKEPCFILP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x782DE0", Offset = "0x7821E0", VA = "0x180782DE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x782E60", Offset = "0x782260", VA = "0x180782E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IPLILIINFIB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x78B870", Offset = "0x78AC70", VA = "0x18078B870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x953B70", Offset = "0x952F70", VA = "0x180953B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool JNBMBICEBHM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x78B880", Offset = "0x78AC80", VA = "0x18078B880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x150C550", Offset = "0x150B950", VA = "0x18150C550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GAOBPMMEINB
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x191D370", Offset = "0x191C770", VA = "0x18191D370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool KMKLFMKHMAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x191D320", Offset = "0x191C720", VA = "0x18191D320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x191D2E0", Offset = "0x191C6E0", VA = "0x18191D2E0")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670")]
		public void SetSpawnableTemplateData(byte[] DDDFJFGELLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x12B9BE0", Offset = "0x12B8FE0", VA = "0x1812B9BE0")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RecRoomBuiltInObjectData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private RecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Dictionary<Guid, RecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Dictionary<Guid, RecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x191D120", Offset = "0x191C520", VA = "0x18191D120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x191CEB0", Offset = "0x191C2B0", VA = "0x18191CEB0")]
		public void HFBJEIBMOPM(IEnumerable<RecRoomBuiltInObject> ACGADCDDJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x191CF20", Offset = "0x191C320", VA = "0x18191CF20")]
		public bool MPHIBFICBKB(Guid FOFKBDOEFGE, out RecRoomBuiltInObject CLKHJAAHJGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x830720", Offset = "0x82FB20", VA = "0x180830720")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum BJIDANDEMNI
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Prop,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Gadget
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DisallowMultipleComponent]
	[APANDCELKMH]
	[AddComponentMenu("Rec Room Studio/Rec Room Object")]
	public sealed class RecRoomObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class <GetEventsWithName>d__22 : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private NamedUnityEventBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public RecRoomObject <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private string eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public string <>3__eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private NamedUnityEventBase[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			NamedUnityEventBase IEnumerator<NamedUnityEventBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
			[DebuggerHidden]
			public <GetEventsWithName>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x191EAC0", Offset = "0x191DEC0", VA = "0x18191EAC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x191EC60", Offset = "0x191E060", VA = "0x18191EC60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x191EBB0", Offset = "0x191DFB0", VA = "0x18191EBB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x191EBB0", Offset = "0x191DFB0", VA = "0x18191EBB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[HideInInspector]
		[SerializeField]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[HideInInspector]
		[SerializeReference]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private Dictionary<string, RecRoomObjectProperty> propertyLookup;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public RecRoomObjectProperty[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public NamedUnityEventBase[] UnityEvents
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public RecRoomObjectConfiguration DefaultConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x191E770", Offset = "0x191DB70", VA = "0x18191E770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x191DC60", Offset = "0x191D060", VA = "0x18191DC60")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x191DEB0", Offset = "0x191D2B0", VA = "0x18191DEB0")]
		public bool TryGetProperty(string propertyName, out RecRoomObjectProperty property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x191E170", Offset = "0x191D570", VA = "0x18191E170")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4B47290", Offset = "0x4B46690", VA = "0x184B47290")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x191E4D0", Offset = "0x191D8D0", VA = "0x18191E4D0")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x191E690", Offset = "0x191DA90", VA = "0x18191E690")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x191E310", Offset = "0x191D710", VA = "0x18191E310")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x191E090", Offset = "0x191D490", VA = "0x18191E090")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x191E5B0", Offset = "0x191D9B0", VA = "0x18191E5B0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x191E460", Offset = "0x191D860", VA = "0x18191E460")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x191E3F0", Offset = "0x191D7F0", VA = "0x18191E3F0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x191E620", Offset = "0x191DA20", VA = "0x18191E620")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x191DBD0", Offset = "0x191CFD0", VA = "0x18191DBD0")]
		[IteratorStateMachine(typeof(<GetEventsWithName>d__22))]
		private IEnumerable<NamedUnityEventBase> GetEventsWithName(string eventName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x191DCF0", Offset = "0x191D0F0", VA = "0x18191DCF0")]
		private bool TryFindAndInvoke(string eventName, Func<NamedUnityEventBase, bool> invoke)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "5")]
		public virtual bool TryInvokeEvent(bool FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "6")]
		public virtual bool TryInvokeEvent(float FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "7")]
		public virtual bool TryInvokeEvent(int FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "8")]
		public virtual bool TryInvokeEvent(string FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3363740", Offset = "0x3362B40", VA = "0x183363740")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x191EE90", Offset = "0x191E290", VA = "0x18191EE90")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x191EED0", Offset = "0x191E2D0", VA = "0x18191EED0")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x191EF10", Offset = "0x191E310", VA = "0x18191EF10")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x191EF90", Offset = "0x191E390", VA = "0x18191EF90")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x191EF50", Offset = "0x191E350", VA = "0x18191EF50")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x191F010", Offset = "0x191E410", VA = "0x18191F010")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x191EFD0", Offset = "0x191E3D0", VA = "0x18191EFD0")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x191F050", Offset = "0x191E450", VA = "0x18191F050")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Preserve]
	[APANDCELKMH]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x191A540", Offset = "0x1919940", VA = "0x18191A540", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x191A600", Offset = "0x1919A00", VA = "0x18191A600")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Preserve]
	[APANDCELKMH]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x21AEE40", Offset = "0x21AE240", VA = "0x1821AEE40")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[APANDCELKMH]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x21AEE40", Offset = "0x21AE240", VA = "0x1821AEE40")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Preserve]
	[APANDCELKMH]
	public sealed class NamedUnityBooleanEvent : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x191A340", Offset = "0x1919740", VA = "0x18191A340", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x191A3A0", Offset = "0x19197A0", VA = "0x18191A3A0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x191A500", Offset = "0x1919900", VA = "0x18191A500")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[APANDCELKMH]
	public sealed class NamedUnityFloatEvent : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x191A640", Offset = "0x1919A40", VA = "0x18191A640", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x191A6A0", Offset = "0x1919AA0", VA = "0x18191A6A0", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x191A800", Offset = "0x1919C00", VA = "0x18191A800")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Preserve]
	[APANDCELKMH]
	public sealed class NamedUnityIntEvent : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x191A840", Offset = "0x1919C40", VA = "0x18191A840", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x191A8A0", Offset = "0x1919CA0", VA = "0x18191A8A0", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x191AA00", Offset = "0x1919E00", VA = "0x18191AA00")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[APANDCELKMH]
	[Preserve]
	public sealed class NamedUnityStringEvent : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x191AC70", Offset = "0x191A070", VA = "0x18191AC70", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x191ACD0", Offset = "0x191A0D0", VA = "0x18191ACD0", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x191AE30", Offset = "0x191A230", VA = "0x18191AE30")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[APANDCELKMH]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x191AA40", Offset = "0x1919E40", VA = "0x18191AA40", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x191AAA0", Offset = "0x1919EA0", VA = "0x18191AAA0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x191AC30", Offset = "0x191A030", VA = "0x18191AC30")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Preserve]
	[APANDCELKMH]
	public sealed class NamedUnityStringFloatEvent : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x191AE70", Offset = "0x191A270", VA = "0x18191AE70", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x191AED0", Offset = "0x191A2D0", VA = "0x18191AED0", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x191B060", Offset = "0x191A460", VA = "0x18191B060")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[APANDCELKMH]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x191B0A0", Offset = "0x191A4A0", VA = "0x18191B0A0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x191B100", Offset = "0x191A500", VA = "0x18191B100", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x191B290", Offset = "0x191A690", VA = "0x18191B290")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[APANDCELKMH]
	[Preserve]
	public sealed class NamedUnityStringStringEvent : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x191B2D0", Offset = "0x191A6D0", VA = "0x18191B2D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x191B330", Offset = "0x191A730", VA = "0x18191B330", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x191B4B0", Offset = "0x191A8B0", VA = "0x18191B4B0")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[KCMAKJMGFEL]
		[SerializeField]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		[PDFBNOJFOIE("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		[PDFBNOJFOIE("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		[Header("Physics")]
		[PDGBOIBPNLF("isBuiltInObject", false, false)]
		private BFAECCHOEEF physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		[PDGBOIBPNLF("isShapeContainer", true, false)]
		private AMHJJBMINCL shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		[HideInInspector]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8262B0", Offset = "0x8256B0", VA = "0x1808262B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x191D490", Offset = "0x191C890", VA = "0x18191D490")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum BFAECCHOEEF
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum AMHJJBMINCL
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Physical_Sticky = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Physical = 4
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[AddComponentMenu("")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static RecRoomObjectPrefabRegistry GLONDIMDLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[HideInInspector]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private RecRoomObjectPrefabRegistryAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RecRoomObjectPrefabRegistry KGGJIHLJBIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x191D7A0", Offset = "0x191CBA0", VA = "0x18191D7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> KBEDEGLCOCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x191D700", Offset = "0x191CB00", VA = "0x18191D700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x191D4E0", Offset = "0x191C8E0", VA = "0x18191D4E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x191D5D0", Offset = "0x191C9D0", VA = "0x18191D5D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class RecRoomObjectPrefabEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public RecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class RecRoomObjectPrefabRegistryAsset : RecRoomStudioBuildAsset<RecRoomObjectPrefabRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public RecRoomObjectPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x191D4A0", Offset = "0x191C8A0", VA = "0x18191D4A0")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4B45490", Offset = "0x4B44890", VA = "0x184B45490")]
		public bool MPHIBFICBKB<T>(out T FPLJCBGEJAP, out string MCGMECECHJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x191D9C0", Offset = "0x191CDC0", VA = "0x18191D9C0")]
		public static string HGMLEONMCKD(Type MOGPOAHNFIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x191D950", Offset = "0x191CD50", VA = "0x18191D950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x191D8E0", Offset = "0x191CCE0", VA = "0x18191D8E0")]
		public MethodInfo KIDLBCCPAMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x191D7E0", Offset = "0x191CBE0", VA = "0x18191D7E0")]
		public string ALJHMNICAOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x32B7050", Offset = "0x32B6450", VA = "0x1832B7050")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct JHAPAJBBLPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public byte[] KIJNDIPNDMA;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7809C0", Offset = "0x77FDC0", VA = "0x1807809C0")]
	public JHAPAJBBLPN(byte[] OCMDFIDHJDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct MGJOIGALCGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public byte[] KIJNDIPNDMA;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7809C0", Offset = "0x77FDC0", VA = "0x1807809C0")]
	public MGJOIGALCGL(byte[] OCMDFIDHJDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class POEJAFMGIFL
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x191B750", Offset = "0x191AB50", VA = "0x18191B750")]
	public static (JHAPAJBBLPN, MGJOIGALCGL) KPFEIFICGCF(Stream LBMMCNGMDLI)
	{
		return default((JHAPAJBBLPN, MGJOIGALCGL));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x191B600", Offset = "0x191AA00", VA = "0x18191B600")]
	public static void DKAELLFKMDE(Stream LBMMCNGMDLI, JHAPAJBBLPN FOGLEECNIFC, MGJOIGALCGL GPCAHMAJMLI)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xB89D00", Offset = "0xB89100", VA = "0x180B89D00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x191EA90", Offset = "0x191DE90", VA = "0x18191EA90")]
		public SerializedGuid(in Guid CFOLAEKFCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x191EA60", Offset = "0x191DE60", VA = "0x18191EA60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x191E9C0", Offset = "0x191DDC0", VA = "0x18191E9C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x191E900", Offset = "0x191DD00", VA = "0x18191E900", Slot = "7")]
		public bool Equals(SerializedGuid FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x191E820", Offset = "0x191DC20", VA = "0x18191E820", Slot = "0")]
		public override bool Equals(object JGHFLANLLNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x191E9B0", Offset = "0x191DDB0", VA = "0x18191E9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x191E7F0", Offset = "0x191DBF0", VA = "0x18191E7F0", Slot = "6")]
		public int CompareTo(SerializedGuid FJLHJLAMLMA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[AttributeUsage(AttributeTargets.Class)]
public class APANDCELKMH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
	public APANDCELKMH()
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
