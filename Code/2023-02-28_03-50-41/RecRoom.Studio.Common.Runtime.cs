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
public class OHBLDCNCAHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 DIJOEKCHGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion HOOCPOKGFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 LIMPIHDAEGE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63A1B00", Offset = "0x63A0500", VA = "0x1863A1B00")]
	public bool ADOIOMGOBIN(Collider FGPOCJNLNLF, ref Bounds NFOBGIKPBLF, bool OFLJKLOFECD, bool OFCHBNPMCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63A3160", Offset = "0x63A1B60", VA = "0x1863A3160")]
	public bool IOAMEDKPMED(Collider LKLPGHLLEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63A2D00", Offset = "0x63A1700", VA = "0x1863A2D00")]
	public bool FDNOFOEAEHK(Collider LKLPGHLLEIM, bool OFLJKLOFECD, bool OFCHBNPMCII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63A2200", Offset = "0x63A0C00", VA = "0x1863A2200")]
	public void EJENDHGBEEC(OHBLDCNCAHO DFHJPOKNFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63A3180", Offset = "0x63A1B80", VA = "0x1863A3180")]
	private static void KCDMNILDPDP(ref Vector3 MMCAICBMAII, ref Vector3 OPOPHNBOOKJ, Vector3 LGGBCCHKBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x63A2090", Offset = "0x63A0A90", VA = "0x1863A2090")]
	public static OHBLDCNCAHO EBFENPBKLNC(GameObject OFMDHDILEHM, Quaternion HOOCPOKGFMC, bool GPDIKLIGGDD, bool MKIKCINLMON, bool OFLJKLOFECD = false, bool OFCHBNPMCII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OHBLDCNCAHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BCFNKDOMPAA : byte
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
public interface FDHGDLGKHLC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AudioMixerGroup OJILHNJKNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FDHGDLGKHLC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<FDHGDLGKHLC> DLHGIFABMAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string LEJCJGNKKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IJMMCADPDJD
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class ECMPCBLOPCC : FDHGDLGKHLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly List<FDHGDLGKHLC> FIMLCMAIPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly ECMPCBLOPCC FKOPNFENJDJ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FDHGDLGKHLC NNHCCDNOHNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AudioMixerGroup OJILHNJKNBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<FDHGDLGKHLC> DLHGIFABMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string LEJCJGNKKIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x639EEE0", Offset = "0x639D8E0", VA = "0x18639EEE0")]
		internal ECMPCBLOPCC(AudioMixerGroup EAGMPINEKBM, ECMPCBLOPCC ELGBIOMPEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FDHGDLGKHLC JHACOJABLMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AudioMixer AKFINCDGABF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x639F050", Offset = "0x639DA50", VA = "0x18639F050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	private IJMMCADPDJD(ECMPCBLOPCC CFMIJBJBBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x639F6E0", Offset = "0x639E0E0", VA = "0x18639F6E0")]
	public static IJMMCADPDJD KJLHNGKNMGF(AudioMixer PNDBOEBICIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x639F380", Offset = "0x639DD80", VA = "0x18639F380")]
	public FDHGDLGKHLC JMBICHAPJID(string CFCACEMILIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x639F130", Offset = "0x639DB30", VA = "0x18639F130")]
	public FDHGDLGKHLC JMBICHAPJID(AudioMixerGroup EAGMPINEKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x639F0B0", Offset = "0x639DAB0", VA = "0x18639F0B0")]
	private static int FNJALHGCJGF(string NKNOOFILFKG, int AGNHLFMCFOJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Field)]
public class GDANAGOAKPK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x639EFF0", Offset = "0x639D9F0", VA = "0x18639EFF0")]
	public GDANAGOAKPK(string IJEJFFCLBDM, bool KAHEHAKLOCN, string KMMODJPBAJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class OHINPDOPDBH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63A32B0", Offset = "0x63A1CB0", VA = "0x1863A32B0")]
	protected OHINPDOPDBH(string IJEJFFCLBDM, bool IJLDOICDBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class MEDHFLFCAIE : OHINPDOPDBH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x639FCF0", Offset = "0x639E6F0", VA = "0x18639FCF0")]
	public MEDHFLFCAIE(string IJEJFFCLBDM, bool KAHEHAKLOCN, bool IJLDOICDBDC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Field)]
public class CBIDHDJLDLG : OHINPDOPDBH
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x639EE80", Offset = "0x639D880", VA = "0x18639EE80")]
	public CBIDHDJLDLG(string IJEJFFCLBDM, int KAHEHAKLOCN, bool IJLDOICDBDC = false)
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
			[Cpp2IlInjected.Address(RVA = "0x639FF20", Offset = "0x639E920", VA = "0x18639FF20")]
			public void LIPLFJGBIOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x639FD50", Offset = "0x639E750", VA = "0x18639FD50")]
			public float JIAFKAOJIHG(string ANJJEPIBAGI)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x639FDC0", Offset = "0x639E7C0", VA = "0x18639FDC0")]
			public float JIAFKAOJIHG(int ILFNNAAOJHE)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x639FEB0", Offset = "0x639E8B0", VA = "0x18639FEB0")]
			public Texture LFDBLCIOANC(int ILFNNAAOJHE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x639FE30", Offset = "0x639E830", VA = "0x18639FE30")]
			public Vector4 KHCLHOPKBKO(int ILFNNAAOJHE)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63A0440", Offset = "0x639EE40", VA = "0x1863A0440")]
			public Color MCCMHGLGIMC(int ILFNNAAOJHE)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static MaterialMap AIDJCJOCGNF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<MaterialEntry> NBBBKMMJPHO;

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
		private Dictionary<Material, MaterialEntry> PCBEPLKHLPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HashSet<Material> OGABFILAIEG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static MaterialMap FMAHKEPPCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63A0910", Offset = "0x639F310", VA = "0x1863A0910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MaterialEntry[] EOEACPCJOGK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63A0880", Offset = "0x639F280", VA = "0x1863A0880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63A0500", Offset = "0x639EF00", VA = "0x1863A0500")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63A07E0", Offset = "0x639F1E0", VA = "0x1863A07E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63A0770", Offset = "0x639F170", VA = "0x1863A0770")]
		public MaterialEntry GetEntryForMaterial(Material BJMPGLOEHJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x63A04C0", Offset = "0x639EEC0", VA = "0x1863A04C0")]
		public MaterialMapAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[AttributeUsage(AttributeTargets.Field)]
public class CNEANMPFNII : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0")]
	public CNEANMPFNII()
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
		public enum PKGJEOKLLHH
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum CEGCGIJAJHH
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
		private static readonly Dictionary<CEGCGIJAJHH, string> HEBCBHLBINI;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string DLBPAOAOONO = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string KPAOEEABBEI = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string GHPEIENPCNG = "Audio";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly string ALFKJLFHNDA;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly string HDJGMBCCKPC;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static RecRoomAudioMixerRegistry AIDJCJOCGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[CNEANMPFNII]
		[SerializeField]
		private PKGJEOKLLHH version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[CBIDHDJLDLG("version", 0, true)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[CBIDHDJLDLG("version", 0, true)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[CBIDHDJLDLG("version", 0, true)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[CBIDHDJLDLG("version", 1, true)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static RecRoomAudioMixerRegistry FMAHKEPPCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63A4270", Offset = "0x63A2C70", VA = "0x1863A4270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AudioMixer GOEHHJKPKPG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HNCHBAEIKCG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63A42D0", Offset = "0x63A2CD0", VA = "0x1863A42D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PKGJEOKLLHH BNNADFINGPC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0")]
			get
			{
				return default(PKGJEOKLLHH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63A4440", Offset = "0x63A2E40", VA = "0x1863A4440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63A34E0", Offset = "0x63A1EE0", VA = "0x1863A34E0")]
		public static string GetAudioGroupPath(CEGCGIJAJHH AIOGCNBJCAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63A3600", Offset = "0x63A2000", VA = "0x1863A3600")]
		public AudioMixerGroup GetMixerGroup(CEGCGIJAJHH AIOGCNBJCAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63A3300", Offset = "0x63A1D00", VA = "0x1863A3300")]
		private static AudioMixerGroup AOBKDDIGKDI(AudioMixer PNDBOEBICIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63A33B0", Offset = "0x63A1DB0", VA = "0x1863A33B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63A3E60", Offset = "0x63A2860", VA = "0x1863A3E60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63A3A80", Offset = "0x63A2480", VA = "0x1863A3A80")]
		public bool IsValidOutputGroup(AudioMixerGroup LMCGLLJGOCC, out string IMHLNJJFNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x63A3CD0", Offset = "0x63A26D0", VA = "0x1863A3CD0")]
		private bool OKFGDEPMJNB(AudioMixerGroup LMCGLLJGOCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x63A3800", Offset = "0x63A2200", VA = "0x1863A3800")]
		private bool IOLGPJHGAKI(AudioMixerGroup GELHKCGPBAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
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
		[CNEANMPFNII]
		[SerializeField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[CNEANMPFNII]
		[SerializeField]
		private AGMLABDHLFI category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[CNEANMPFNII]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[CNEANMPFNII]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[HideInInspector]
		[SerializeField]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Guid AOACHEOJIPP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x63A49D0", Offset = "0x63A33D0", VA = "0x1863A49D0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63A4A60", Offset = "0x63A3460", VA = "0x1863A4A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string CFJGBOECNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public AGMLABDHLFI GKCFGFINHKB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6E31B0", Offset = "0x6E1BB0", VA = "0x1806E31B0")]
			get
			{
				return default(AGMLABDHLFI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA04B40", Offset = "0xA03540", VA = "0x180A04B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool LEJGPJLOIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x78C540", Offset = "0x78AF40", VA = "0x18078C540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x922440", Offset = "0x920E40", VA = "0x180922440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool OEABGGGDBLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA083E0", Offset = "0xA06DE0", VA = "0x180A083E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB49CE0", Offset = "0xB486E0", VA = "0x180B49CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool CMMAFFOHKJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xE73060", Offset = "0xE71A60", VA = "0x180E73060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xE73710", Offset = "0xE72110", VA = "0x180E73710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool IFBKECDLBHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x63A49B0", Offset = "0x63A33B0", VA = "0x1863A49B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool BJCLPMPBNHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63A4960", Offset = "0x63A3360", VA = "0x1863A4960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63A4920", Offset = "0x63A3320", VA = "0x1863A4920")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
		public void SetSpawnableTemplateData(byte[] HCDIJOAAFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xAC8EA0", Offset = "0xAC78A0", VA = "0x180AC8EA0")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
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
			[Cpp2IlInjected.Address(RVA = "0x63A4760", Offset = "0x63A3160", VA = "0x1863A4760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x63A44F0", Offset = "0x63A2EF0", VA = "0x1863A44F0")]
		public void CIAEJHOFGEF(IEnumerable<RecRoomBuiltInObject> DAMLIGIBLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x63A4560", Offset = "0x63A2F60", VA = "0x1863A4560")]
		public bool CKMNFEFPOIP(Guid MDGBEHMLOFC, out RecRoomBuiltInObject COIMGLJKEIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xE1BFB0", Offset = "0xE1A9B0", VA = "0x180E1BFB0")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum AGMLABDHLFI
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Prop,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Gadget
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[PEHKLHCCJFN]
	[DisallowMultipleComponent]
	[AddComponentMenu("Rec Room Studio/Rec Room Object")]
	public sealed class RecRoomObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class <GetEventsWithName>d__22 : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private NamedUnityEventBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RecRoomObject <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private string eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public string <>3__eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private NamedUnityEventBase[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			NamedUnityEventBase IEnumerator<NamedUnityEventBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
			[DebuggerHidden]
			public <GetEventsWithName>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x63A6060", Offset = "0x63A4A60", VA = "0x1863A6060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x63A6200", Offset = "0x63A4C00", VA = "0x1863A6200", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x63A6150", Offset = "0x63A4B50", VA = "0x1863A6150", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x63A6150", Offset = "0x63A4B50", VA = "0x1863A6150", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

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
		public RecRoomObjectProperty[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NamedUnityEventBase[] UnityEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RecRoomObjectConfiguration DefaultConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63A5DB0", Offset = "0x63A47B0", VA = "0x1863A5DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x63A52A0", Offset = "0x63A3CA0", VA = "0x1863A52A0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63A54F0", Offset = "0x63A3EF0", VA = "0x1863A54F0")]
		public bool TryGetProperty(string propertyName, out RecRoomObjectProperty property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x63A57B0", Offset = "0x63A41B0", VA = "0x1863A57B0")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x451B3C0", Offset = "0x4519DC0", VA = "0x18451B3C0")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x63A5B10", Offset = "0x63A4510", VA = "0x1863A5B10")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63A5CD0", Offset = "0x63A46D0", VA = "0x1863A5CD0")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63A5950", Offset = "0x63A4350", VA = "0x1863A5950")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x63A56D0", Offset = "0x63A40D0", VA = "0x1863A56D0")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x63A5BF0", Offset = "0x63A45F0", VA = "0x1863A5BF0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x63A5AA0", Offset = "0x63A44A0", VA = "0x1863A5AA0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63A5A30", Offset = "0x63A4430", VA = "0x1863A5A30")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63A5C60", Offset = "0x63A4660", VA = "0x1863A5C60")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63A5210", Offset = "0x63A3C10", VA = "0x1863A5210")]
		[IteratorStateMachine(typeof(<GetEventsWithName>d__22))]
		private IEnumerable<NamedUnityEventBase> GetEventsWithName(string eventName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x63A5330", Offset = "0x63A3D30", VA = "0x1863A5330")]
		private bool TryFindAndInvoke(string eventName, Func<NamedUnityEventBase, bool> invoke)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "5")]
		public virtual bool TryInvokeEvent(bool MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "6")]
		public virtual bool TryInvokeEvent(float MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "7")]
		public virtual bool TryInvokeEvent(int MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "8")]
		public virtual bool TryInvokeEvent(string MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B880", Offset = "0x3A9A280", VA = "0x183A9B880")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x63A6430", Offset = "0x63A4E30", VA = "0x1863A6430")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x63A6470", Offset = "0x63A4E70", VA = "0x1863A6470")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63A64B0", Offset = "0x63A4EB0", VA = "0x1863A64B0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63A6530", Offset = "0x63A4F30", VA = "0x1863A6530")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x63A64F0", Offset = "0x63A4EF0", VA = "0x1863A64F0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x63A65B0", Offset = "0x63A4FB0", VA = "0x1863A65B0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x63A6570", Offset = "0x63A4F70", VA = "0x1863A6570")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63A65F0", Offset = "0x63A4FF0", VA = "0x1863A65F0")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[Preserve]
	[PEHKLHCCJFN]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63A0B50", Offset = "0x639F550", VA = "0x1863A0B50", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63A0C10", Offset = "0x639F610", VA = "0x1863A0C10")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	[PEHKLHCCJFN]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1757C60", Offset = "0x1756660", VA = "0x181757C60")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[PEHKLHCCJFN]
	[Preserve]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1757C60", Offset = "0x1756660", VA = "0x181757C60")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[Preserve]
	[PEHKLHCCJFN]
	public sealed class NamedUnityBooleanEvent : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x63A0950", Offset = "0x639F350", VA = "0x1863A0950", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63A09B0", Offset = "0x639F3B0", VA = "0x1863A09B0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x63A0B10", Offset = "0x639F510", VA = "0x1863A0B10")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[PEHKLHCCJFN]
	[Preserve]
	public sealed class NamedUnityFloatEvent : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x63A0C50", Offset = "0x639F650", VA = "0x1863A0C50", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x63A0CB0", Offset = "0x639F6B0", VA = "0x1863A0CB0", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x63A0E10", Offset = "0x639F810", VA = "0x1863A0E10")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[PEHKLHCCJFN]
	[Preserve]
	public sealed class NamedUnityIntEvent : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63A0E50", Offset = "0x639F850", VA = "0x1863A0E50", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x63A0EB0", Offset = "0x639F8B0", VA = "0x1863A0EB0", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63A1010", Offset = "0x639FA10", VA = "0x1863A1010")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Preserve]
	[PEHKLHCCJFN]
	public sealed class NamedUnityStringEvent : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x63A1280", Offset = "0x639FC80", VA = "0x1863A1280", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x63A12E0", Offset = "0x639FCE0", VA = "0x1863A12E0", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x63A1440", Offset = "0x639FE40", VA = "0x1863A1440")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[PEHKLHCCJFN]
	public sealed class NamedUnityStringBooleanEvent : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x63A1050", Offset = "0x639FA50", VA = "0x1863A1050", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x63A10B0", Offset = "0x639FAB0", VA = "0x1863A10B0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x63A1240", Offset = "0x639FC40", VA = "0x1863A1240")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Preserve]
	[PEHKLHCCJFN]
	public sealed class NamedUnityStringFloatEvent : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x63A1480", Offset = "0x639FE80", VA = "0x1863A1480", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x63A14E0", Offset = "0x639FEE0", VA = "0x1863A14E0", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x63A1670", Offset = "0x63A0070", VA = "0x1863A1670")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	[PEHKLHCCJFN]
	public sealed class NamedUnityStringIntEvent : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x63A16B0", Offset = "0x63A00B0", VA = "0x1863A16B0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x63A1710", Offset = "0x63A0110", VA = "0x1863A1710", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x63A18A0", Offset = "0x63A02A0", VA = "0x1863A18A0")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Preserve]
	[PEHKLHCCJFN]
	public sealed class NamedUnityStringStringEvent : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x63A18E0", Offset = "0x63A02E0", VA = "0x1863A18E0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x63A1940", Offset = "0x63A0340", VA = "0x1863A1940", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x63A1AC0", Offset = "0x63A04C0", VA = "0x1863A1AC0")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		[CNEANMPFNII]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		[GDANAGOAKPK("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		[GDANAGOAKPK("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		[Header("Physics")]
		[MEDHFLFCAIE("isBuiltInObject", false, false)]
		private MJBJBBAGALO physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		[MEDHFLFCAIE("isShapeContainer", true, false)]
		private HFKDEJNLKFH shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[HideInInspector]
		[SerializeField]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6C5270", Offset = "0x6C3C70", VA = "0x1806C5270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x63A4AD0", Offset = "0x63A34D0", VA = "0x1863A4AD0")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum MJBJBBAGALO
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum HFKDEJNLKFH
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Physical_Sticky = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Physical = 4
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[AddComponentMenu("")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static RecRoomObjectPrefabRegistry AIDJCJOCGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		[HideInInspector]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private RecRoomObjectPrefabRegistryAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RecRoomObjectPrefabRegistry FMAHKEPPCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x63A4DE0", Offset = "0x63A37E0", VA = "0x1863A4DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> FLAFOGHNOPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x63A4D40", Offset = "0x63A3740", VA = "0x1863A4D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x63A4B20", Offset = "0x63A3520", VA = "0x1863A4B20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x63A4C10", Offset = "0x63A3610", VA = "0x1863A4C10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class RecRoomObjectPrefabEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public RecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class RecRoomObjectPrefabRegistryAsset : RecRoomStudioBuildAsset<RecRoomObjectPrefabRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public RecRoomObjectPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x63A4AE0", Offset = "0x63A34E0", VA = "0x1863A4AE0")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x45195C0", Offset = "0x4517FC0", VA = "0x1845195C0")]
		public bool CKMNFEFPOIP<T>(out T MNIAGKNOHEJ, out string IMHLNJJFNDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x63A5000", Offset = "0x63A3A00", VA = "0x1863A5000")]
		public static string PIFKFEMKKCN(Type KNGDLMLNDII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x63A4F90", Offset = "0x63A3990", VA = "0x1863A4F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x63A4E20", Offset = "0x63A3820", VA = "0x1863A4E20")]
		public MethodInfo CLEEMMPIIIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x63A4E90", Offset = "0x63A3890", VA = "0x1863A4E90")]
		public string JONNGDCANNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x25A29B0", Offset = "0x25A13B0", VA = "0x1825A29B0")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct IGBIFHLMPEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public byte[] CBNKGLFPDMA;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
	public IGBIFHLMPEP(byte[] EONCDECCEBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct CHCHLOKIDIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public byte[] CBNKGLFPDMA;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
	public CHCHLOKIDIP(byte[] EONCDECCEBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class KMKFHFKANIN
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x639FB30", Offset = "0x639E530", VA = "0x18639FB30")]
	public static (IGBIFHLMPEP, CHCHLOKIDIP) NAOAMOIEFMM(Stream BODAGHDNFBD)
	{
		return default((IGBIFHLMPEP, CHCHLOKIDIP));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x639F9E0", Offset = "0x639E3E0", VA = "0x18639F9E0")]
	public static void CHKEGNCMPNF(Stream BODAGHDNFBD, IGBIFHLMPEP FGCBFOCODMG, CHCHLOKIDIP NOKMNHEPOPP)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x1E86B20", Offset = "0x1E85520", VA = "0x181E86B20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x636A7B0", Offset = "0x63691B0", VA = "0x18636A7B0")]
		public SerializedGuid(in Guid CKAFGMOJCKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x636A780", Offset = "0x6369180", VA = "0x18636A780", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x63A5FC0", Offset = "0x63A49C0", VA = "0x1863A5FC0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x63A5F10", Offset = "0x63A4910", VA = "0x1863A5F10", Slot = "7")]
		public bool Equals(SerializedGuid DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x63A5E30", Offset = "0x63A4830", VA = "0x1863A5E30", Slot = "0")]
		public override bool Equals(object LAFPICAOEAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x636A520", Offset = "0x6368F20", VA = "0x18636A520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x636A2D0", Offset = "0x6368CD0", VA = "0x18636A2D0", Slot = "6")]
		public int CompareTo(SerializedGuid DFHJPOKNFFB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class)]
public class PEHKLHCCJFN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
	public PEHKLHCCJFN()
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
