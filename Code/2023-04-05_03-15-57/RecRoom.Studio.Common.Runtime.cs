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
public class EALIPDDOIIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 MNKJLHEGDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion OLBDAPNGDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 CAFKOGEEDMG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x654F0D0", Offset = "0x654E0D0", VA = "0x18654F0D0")]
	public bool IOIEOLNEEPO(Collider MMNMMMMCHOC, ref Bounds BNIHLJDPCCG, bool FPGHGBBDONA, bool LDLPEIBBOHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x654EF40", Offset = "0x654DF40", VA = "0x18654EF40")]
	public bool AIBDAOOJLLH(Collider FILONMPFNJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6550160", Offset = "0x654F160", VA = "0x186550160")]
	public bool LDFJJNAHFCP(Collider FILONMPFNJD, bool FPGHGBBDONA, bool LDLPEIBBOHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x654F660", Offset = "0x654E660", VA = "0x18654F660")]
	public void KFDGEGDGKON(EALIPDDOIIE JHMCLPBFJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x654EE10", Offset = "0x654DE10", VA = "0x18654EE10")]
	private static void ADMEDMOFBKH(ref Vector3 EKDCKLAKFJN, ref Vector3 IBFPNBPAEOD, Vector3 GACKECGDAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x654EF60", Offset = "0x654DF60", VA = "0x18654EF60")]
	public static EALIPDDOIIE FMFLOEBFIIK(GameObject IGJDJDNFANI, Quaternion OLBDAPNGDPL, bool CPNIACDEHHD, bool IKHHINMPJNK, bool FPGHGBBDONA = false, bool LDLPEIBBOHE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public EALIPDDOIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CADEJFFEAME : byte
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
public interface OHALFLGKNPB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AudioMixerGroup CPPDOGBHFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OHALFLGKNPB AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<OHALFLGKNPB> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string KBMCDCNPBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EKHAOHAFIFD
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class FIBNGGEBIMJ : OHALFLGKNPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly List<OHALFLGKNPB> OOBGDOIIGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly FIBNGGEBIMJ MMCKELIAPIK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OHALFLGKNPB AKKGLHPPJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AudioMixerGroup CPPDOGBHFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<OHALFLGKNPB> BIMGCBEFPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string KBMCDCNPBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6550F50", Offset = "0x654FF50", VA = "0x186550F50")]
		internal FIBNGGEBIMJ(AudioMixerGroup DEGOBDGJJPK, FIBNGGEBIMJ OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OHALFLGKNPB AFGNJBPFCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AudioMixer IDACDALPLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6550940", Offset = "0x654F940", VA = "0x186550940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	private EKHAOHAFIFD(FIBNGGEBIMJ PCHDELPBNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65505C0", Offset = "0x654F5C0", VA = "0x1865505C0")]
	public static EKHAOHAFIFD BLLNHKHBPEE(AudioMixer PANPGGJJBPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6550BF0", Offset = "0x654FBF0", VA = "0x186550BF0")]
	public OHALFLGKNPB KCBDJMELDOO(string OMCDNBADAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x65509A0", Offset = "0x654F9A0", VA = "0x1865509A0")]
	public OHALFLGKNPB KCBDJMELDOO(AudioMixerGroup DEGOBDGJJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x65508C0", Offset = "0x654F8C0", VA = "0x1865508C0")]
	private static int FBDJCBPNJGC(string NEIBENCLOEC, int GODLNPABGMH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Field)]
public class PPNPFEEDAOC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65531E0", Offset = "0x65521E0", VA = "0x1865531E0")]
	public PPNPFEEDAOC(string GPBJNICHLBB, bool AOAMFPFIIDK, string FNGLKFIJFDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class DBKKIJIGPNP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x654EDC0", Offset = "0x654DDC0", VA = "0x18654EDC0")]
	protected DBKKIJIGPNP(string GPBJNICHLBB, bool BHCHPGOJODJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field)]
public class JJIDHDBIIJH : DBKKIJIGPNP
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6551370", Offset = "0x6550370", VA = "0x186551370")]
	public JJIDHDBIIJH(string GPBJNICHLBB, bool AOAMFPFIIDK, bool BHCHPGOJODJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Field)]
public class OIDOEIMLJGM : DBKKIJIGPNP
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6553180", Offset = "0x6552180", VA = "0x186553180")]
	public OIDOEIMLJGM(string GPBJNICHLBB, int AOAMFPFIIDK, bool BHCHPGOJODJ = false)
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
			[Cpp2IlInjected.Address(RVA = "0x6551540", Offset = "0x6550540", VA = "0x186551540")]
			public void NAEGLKGLGOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6551A60", Offset = "0x6550A60", VA = "0x186551A60")]
			public float NKMMELDGLPH(string GOENAEMJAON)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6551AD0", Offset = "0x6550AD0", VA = "0x186551AD0")]
			public float NKMMELDGLPH(int AOKMGDODDPA)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x65513D0", Offset = "0x65503D0", VA = "0x1865513D0")]
			public Texture APLLIJBMOPD(int AOKMGDODDPA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6551440", Offset = "0x6550440", VA = "0x186551440")]
			public Vector4 BBKJDFIGALI(int AOKMGDODDPA)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x65514C0", Offset = "0x65504C0", VA = "0x1865514C0")]
			public Color JGCACONJAKL(int AOKMGDODDPA)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static MaterialMap NMHCDAEEFOA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<MaterialEntry> DKMIEPFECJH;

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
		private Dictionary<Material, MaterialEntry> POKEBJFJGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HashSet<Material> DNBBBMOOBNK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static MaterialMap FDNKALDKIIB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6551F90", Offset = "0x6550F90", VA = "0x186551F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MaterialEntry[] KMGLAFHFFBG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6551F00", Offset = "0x6550F00", VA = "0x186551F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6551B80", Offset = "0x6550B80", VA = "0x186551B80")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6551E60", Offset = "0x6550E60", VA = "0x186551E60")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6551DF0", Offset = "0x6550DF0", VA = "0x186551DF0")]
		public MaterialEntry GetEntryForMaterial(Material CKKAOJLFENB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6551B40", Offset = "0x6550B40", VA = "0x186551B40")]
		public MaterialMapAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[AttributeUsage(AttributeTargets.Field)]
public class DLFNDHAOBBM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x746C20", Offset = "0x745C20", VA = "0x180746C20")]
	public DLFNDHAOBBM()
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
		private static RecRoomAudioClipRegistry NMHCDAEEFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private RecRoomAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static RecRoomAudioClipRegistry FDNKALDKIIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x65535B0", Offset = "0x65525B0", VA = "0x1865535B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RecRoomAudioClipRegistryAsset KMGLAFHFFBG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RecRoomAudioClipEntry> AIKALOGPNGP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x65534F0", Offset = "0x65524F0", VA = "0x1865534F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x65532D0", Offset = "0x65522D0", VA = "0x1865532D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x65533C0", Offset = "0x65523C0", VA = "0x1865533C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x6553280", Offset = "0x6552280", VA = "0x186553280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6553240", Offset = "0x6552240", VA = "0x186553240")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AddComponentMenu("")]
	public sealed class RecRoomAudioMixerRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum FMCHAAMBJAI
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum EJIIHPIGOLK
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
		private static readonly Dictionary<EJIIHPIGOLK, string> ACHCMPIELDK;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string NEGAKKMHEFC = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const string BFEHJMPCLBH = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string GMNFMMDJMED = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string GIDECKECDLJ;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly string LDGIMKEMAMM;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static RecRoomAudioMixerRegistry NMHCDAEEFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		[DLFNDHAOBBM]
		private FMCHAAMBJAI version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		[OIDOEIMLJGM("version", 0, false)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		[OIDOEIMLJGM("version", 0, false)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		[OIDOEIMLJGM("version", 0, false)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		[OIDOEIMLJGM("version", 1, false)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static RecRoomAudioMixerRegistry FDNKALDKIIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6554560", Offset = "0x6553560", VA = "0x186554560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AudioMixer GJIIAKCKCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LCLDHDEMAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x65545C0", Offset = "0x65535C0", VA = "0x1865545C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public FMCHAAMBJAI CONDCHODOCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6E0BD0", Offset = "0x6DFBD0", VA = "0x1806E0BD0")]
			get
			{
				return default(FMCHAAMBJAI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6554730", Offset = "0x6553730", VA = "0x186554730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6553A50", Offset = "0x6552A50", VA = "0x186553A50")]
		public static string GetAudioGroupPath(EJIIHPIGOLK DFIOBIPMIIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6553B70", Offset = "0x6552B70", VA = "0x186553B70")]
		public AudioMixerGroup GetMixerGroup(EJIIHPIGOLK DFIOBIPMIIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x65539A0", Offset = "0x65529A0", VA = "0x1865539A0")]
		private static AudioMixerGroup FLMNFFCIMLF(AudioMixer PANPGGJJBPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6553870", Offset = "0x6552870", VA = "0x186553870")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6554150", Offset = "0x6553150", VA = "0x186554150")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6553D70", Offset = "0x6552D70", VA = "0x186553D70")]
		public bool IsValidOutputGroup(AudioMixerGroup KMNKBIDAGNP, out string CNMFEBEOFOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6553FC0", Offset = "0x6552FC0", VA = "0x186553FC0")]
		private bool NBGKFLKPLBA(AudioMixerGroup KMNKBIDAGNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x65535F0", Offset = "0x65525F0", VA = "0x1865535F0")]
		private bool AMNFJMGLCLM(AudioMixerGroup PDFPHKFCGCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
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
		[DLFNDHAOBBM]
		[SerializeField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[DLFNDHAOBBM]
		private KGOGIDAKGKA category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[DLFNDHAOBBM]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[DLFNDHAOBBM]
		[SerializeField]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[HideInInspector]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Guid BMNKIGCHGBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6554CC0", Offset = "0x6553CC0", VA = "0x186554CC0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6554D50", Offset = "0x6553D50", VA = "0x186554D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string ACGAIIDMAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KGOGIDAKGKA PFIEIEKHNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7011B0", Offset = "0x7001B0", VA = "0x1807011B0")]
			get
			{
				return default(KGOGIDAKGKA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA22B00", Offset = "0xA21B00", VA = "0x180A22B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ENEHFBGKBCL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7AA560", Offset = "0x7A9560", VA = "0x1807AA560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x940400", Offset = "0x93F400", VA = "0x180940400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool FMLBNBKKKAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA263A0", Offset = "0xA253A0", VA = "0x180A263A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xB67CA0", Offset = "0xB66CA0", VA = "0x180B67CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool COHDHHLHAAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xE67D50", Offset = "0xE66D50", VA = "0x180E67D50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xE68400", Offset = "0xE67400", VA = "0x180E68400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool OKAOKCDDJOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6554CA0", Offset = "0x6553CA0", VA = "0x186554CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GICEGDAAHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6554C50", Offset = "0x6553C50", VA = "0x186554C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6554C10", Offset = "0x6553C10", VA = "0x186554C10")]
		public byte[] GetSpawnableTemplateDataCopy()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
		public void SetSpawnableTemplateData(byte[] ENLEHFBJKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAE6E60", Offset = "0xAE5E60", VA = "0x180AE6E60")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x6554A50", Offset = "0x6553A50", VA = "0x186554A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x65547E0", Offset = "0x65537E0", VA = "0x1865547E0")]
		public void KJNBENKDMHC(IEnumerable<RecRoomBuiltInObject> FLFJHKPMOIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6554850", Offset = "0x6553850", VA = "0x186554850")]
		public bool OHBANFGHGGE(Guid KMPJLPNGNII, out RecRoomBuiltInObject JLGEMPHHGNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE23C60", Offset = "0xE22C60", VA = "0x180E23C60")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum KGOGIDAKGKA
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
	[ABHHBIJFLPD]
	[AddComponentMenu("Rec Room Studio/Rec Room Object")]
	public sealed class RecRoomObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class <GetEventsWithName>d__26 : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private NamedUnityEventBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public RecRoomObject <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private string eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public string <>3__eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private NamedUnityEventBase[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			NamedUnityEventBase IEnumerator<NamedUnityEventBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8BA110", Offset = "0x8B9110", VA = "0x1808BA110")]
			[DebuggerHidden]
			public <GetEventsWithName>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6556570", Offset = "0x6555570", VA = "0x186556570", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6556710", Offset = "0x6555710", VA = "0x186556710", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6556660", Offset = "0x6555660", VA = "0x186556660", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6556660", Offset = "0x6555660", VA = "0x186556660", Slot = "5")]
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
		[SerializeReference]
		[HideInInspector]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Dictionary<string, RecRoomObjectProperty> propertyLookup;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public RecRoomObjectProperty[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public NamedUnityEventBase[] UnityEvents
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public RecRoomObjectConfiguration DefaultConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x65561A0", Offset = "0x65551A0", VA = "0x1865561A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObject, string> OnSendCircuitsEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6556100", Offset = "0x6555100", VA = "0x186556100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6556220", Offset = "0x6555220", VA = "0x186556220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6555590", Offset = "0x6554590", VA = "0x186555590")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6555840", Offset = "0x6554840", VA = "0x186555840")]
		public bool TryGetProperty(string propertyName, out RecRoomObjectProperty property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6555B00", Offset = "0x6554B00", VA = "0x186555B00")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6555620", Offset = "0x6554620", VA = "0x186555620")]
		public void SendCircuitsEvent(string eventName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x34F1210", Offset = "0x34F0210", VA = "0x1834F1210")]
		private bool TryRaiseUnityEvent<T0, T1, TEvent>(string eventName, T0 value0, T1 value1) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6555E60", Offset = "0x6554E60", VA = "0x186555E60")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6556020", Offset = "0x6555020", VA = "0x186556020")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6555CA0", Offset = "0x6554CA0", VA = "0x186555CA0")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6555A20", Offset = "0x6554A20", VA = "0x186555A20")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6555F40", Offset = "0x6554F40", VA = "0x186555F40")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6555DF0", Offset = "0x6554DF0", VA = "0x186555DF0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6555D80", Offset = "0x6554D80", VA = "0x186555D80")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6555FB0", Offset = "0x6554FB0", VA = "0x186555FB0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6555500", Offset = "0x6554500", VA = "0x186555500")]
		[IteratorStateMachine(typeof(<GetEventsWithName>d__26))]
		private IEnumerable<NamedUnityEventBase> GetEventsWithName(string eventName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6555680", Offset = "0x6554680", VA = "0x186555680")]
		private bool TryFindAndInvoke(string eventName, Func<NamedUnityEventBase, bool> invoke)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "5")]
		public virtual bool TryInvokeEvent(bool KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "6")]
		public virtual bool TryInvokeEvent(float KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "7")]
		public virtual bool TryInvokeEvent(int KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "8")]
		public virtual bool TryInvokeEvent(string KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x29D02C0", Offset = "0x29CF2C0", VA = "0x1829D02C0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6556940", Offset = "0x6555940", VA = "0x186556940")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6556980", Offset = "0x6555980", VA = "0x186556980")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x65569C0", Offset = "0x65559C0", VA = "0x1865569C0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6556A40", Offset = "0x6555A40", VA = "0x186556A40")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6556A00", Offset = "0x6555A00", VA = "0x186556A00")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6556AC0", Offset = "0x6555AC0", VA = "0x186556AC0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6556A80", Offset = "0x6555A80", VA = "0x186556A80")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6556B00", Offset = "0x6555B00", VA = "0x186556B00")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Preserve]
	[ABHHBIJFLPD]
	public sealed class NamedUnityEvent : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x65521D0", Offset = "0x65511D0", VA = "0x1865521D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6552290", Offset = "0x6551290", VA = "0x186552290")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Preserve]
	[ABHHBIJFLPD]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1116660", Offset = "0x1115660", VA = "0x181116660")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[ABHHBIJFLPD]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1116660", Offset = "0x1115660", VA = "0x181116660")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Preserve]
	[ABHHBIJFLPD]
	public sealed class NamedUnityBooleanEvent : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6551FD0", Offset = "0x6550FD0", VA = "0x186551FD0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6552030", Offset = "0x6551030", VA = "0x186552030", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6552190", Offset = "0x6551190", VA = "0x186552190")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[ABHHBIJFLPD]
	[Preserve]
	public sealed class NamedUnityFloatEvent : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x65522D0", Offset = "0x65512D0", VA = "0x1865522D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6552330", Offset = "0x6551330", VA = "0x186552330", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6552490", Offset = "0x6551490", VA = "0x186552490")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[ABHHBIJFLPD]
	[Preserve]
	public sealed class NamedUnityIntEvent : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x65524D0", Offset = "0x65514D0", VA = "0x1865524D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6552530", Offset = "0x6551530", VA = "0x186552530", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6552690", Offset = "0x6551690", VA = "0x186552690")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ABHHBIJFLPD]
	[Preserve]
	public sealed class NamedUnityStringEvent : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6552900", Offset = "0x6551900", VA = "0x186552900", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6552960", Offset = "0x6551960", VA = "0x186552960", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6552AC0", Offset = "0x6551AC0", VA = "0x186552AC0")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ABHHBIJFLPD]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x65526D0", Offset = "0x65516D0", VA = "0x1865526D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6552730", Offset = "0x6551730", VA = "0x186552730", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65528C0", Offset = "0x65518C0", VA = "0x1865528C0")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Preserve]
	[ABHHBIJFLPD]
	public sealed class NamedUnityStringFloatEvent : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6552B00", Offset = "0x6551B00", VA = "0x186552B00", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6552B60", Offset = "0x6551B60", VA = "0x186552B60", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6552CF0", Offset = "0x6551CF0", VA = "0x186552CF0")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[ABHHBIJFLPD]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6552D30", Offset = "0x6551D30", VA = "0x186552D30", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6552D90", Offset = "0x6551D90", VA = "0x186552D90", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6552F20", Offset = "0x6551F20", VA = "0x186552F20")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ABHHBIJFLPD]
	[Preserve]
	public sealed class NamedUnityStringStringEvent : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6552F60", Offset = "0x6551F60", VA = "0x186552F60", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6552FC0", Offset = "0x6551FC0", VA = "0x186552FC0", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6553140", Offset = "0x6552140", VA = "0x186553140")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[DLFNDHAOBBM]
		[SerializeField]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		[PPNPFEEDAOC("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		[PPNPFEEDAOC("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		[Header("Physics")]
		[JJIDHDBIIJH("isBuiltInObject", false, false)]
		private BCIDBNNNOOO physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		[JJIDHDBIIJH("isShapeContainer", true, false)]
		private IOFDJLKKEDL shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		[HideInInspector]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6E3270", Offset = "0x6E2270", VA = "0x1806E3270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6554DC0", Offset = "0x6553DC0", VA = "0x186554DC0")]
		public RecRoomObjectConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum BCIDBNNNOOO
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Physical = 4
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum IOFDJLKKEDL
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Environment = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Decoration = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Physical_Sticky = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Physical = 4
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[AddComponentMenu("")]
	public sealed class RecRoomObjectPrefabRegistry : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static RecRoomObjectPrefabRegistry NMHCDAEEFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		[HideInInspector]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private RecRoomObjectPrefabRegistryAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RecRoomObjectPrefabRegistry FDNKALDKIIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x65550D0", Offset = "0x65540D0", VA = "0x1865550D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public IReadOnlyList<RecRoomObjectPrefabEntry> OHOMCMIJJEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6555030", Offset = "0x6554030", VA = "0x186555030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6554E10", Offset = "0x6553E10", VA = "0x186554E10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6554F00", Offset = "0x6553F00", VA = "0x186554F00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class RecRoomObjectPrefabEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public RecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class RecRoomObjectPrefabRegistryAsset : RecRoomStudioBuildAsset<RecRoomObjectPrefabRegistryAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private RecRoomObjectPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public RecRoomObjectPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6554DD0", Offset = "0x6553DD0", VA = "0x186554DD0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x34EF410", Offset = "0x34EE410", VA = "0x1834EF410")]
		public bool OHBANFGHGGE<T>(out T KPPLMEOMNGF, out string CNMFEBEOFOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x65552F0", Offset = "0x65542F0", VA = "0x1865552F0")]
		public static string MMMPJJHIAAN(Type JELHNILOKLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6555280", Offset = "0x6554280", VA = "0x186555280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6555110", Offset = "0x6554110", VA = "0x186555110")]
		public MethodInfo CNANCDKPNLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6555180", Offset = "0x6554180", VA = "0x186555180")]
		public string KLNFGBPPNBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2687530", Offset = "0x2686530", VA = "0x182687530")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[RequireComponent(typeof(Canvas))]
	public sealed class RecRoomStudioCanvasInteraction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		private bool isInteractable;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LPGPBONCNNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public RecRoomStudioCanvasInteraction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class RecRoomStudioChipMetadata : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct IndividualChipMetadata
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			[SerializeField]
			public string ClassName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[SerializeField]
			public string FriendlyName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[SerializeField]
			public string Description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[SerializeField]
			public List<string> Filters;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			[SerializeField]
			public bool IsBetaChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[SerializeField]
			public bool IsHiddenInPalette;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[SerializeField]
			public bool IsDevChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			[SerializeField]
			public bool IsStudioChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			[SerializeField]
			public bool IsTrollingRisk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[SerializeField]
			public bool IsRoleAssignmentRisk;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		public List<IndividualChipMetadata> MetadataList;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x65562C0", Offset = "0x65552C0", VA = "0x1865562C0")]
		public RecRoomStudioChipMetadata()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct FEHMEAFANPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public byte[] NDPPPPIFPGJ;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8B5D70", Offset = "0x8B4D70", VA = "0x1808B5D70")]
	public FEHMEAFANPL(byte[] OBBOCNIOLOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct NGNNMCBHKPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public byte[] NDPPPPIFPGJ;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8B5D70", Offset = "0x8B4D70", VA = "0x1808B5D70")]
	public NGNNMCBHKPD(byte[] OBBOCNIOLOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class HFMECAOLGNC
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6551060", Offset = "0x6550060", VA = "0x186551060")]
	public static (FEHMEAFANPL, NGNNMCBHKPD) IKHDCCDJIFG(Stream BBKJOBCNEOF)
	{
		return default((FEHMEAFANPL, NGNNMCBHKPD));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6551220", Offset = "0x6550220", VA = "0x186551220")]
	public static void JAACLCNLJFE(Stream BBKJOBCNEOF, FEHMEAFANPL AONKGPLDMJF, NGNNMCBHKPD JMMKMFBNDLE)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2FB6F30", Offset = "0x2FB5F30", VA = "0x182FB6F30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6532740", Offset = "0x6531740", VA = "0x186532740")]
		public SerializedGuid(in Guid DBODHDCBMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6532710", Offset = "0x6531710", VA = "0x186532710", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x65564D0", Offset = "0x65554D0", VA = "0x1865564D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6556420", Offset = "0x6555420", VA = "0x186556420", Slot = "7")]
		public bool Equals(SerializedGuid JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6556340", Offset = "0x6555340", VA = "0x186556340", Slot = "0")]
		public override bool Equals(object AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x65324B0", Offset = "0x65314B0", VA = "0x1865324B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x65322F0", Offset = "0x65312F0", VA = "0x1865322F0", Slot = "6")]
		public int CompareTo(SerializedGuid JHMCLPBFJBC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.Class)]
public class ABHHBIJFLPD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
	public ABHHBIJFLPD()
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
