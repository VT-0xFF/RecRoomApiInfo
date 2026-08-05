using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Attributes;
using RecRoom.Core.Studio.StudioFunctions;
using RecRoom.Logging.Attributes;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Studio_Common_Base_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : MKCMLEJGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7233680", Offset = "0x7232080", VA = "0x187233680", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct MJMBINKCMII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 GOPLNKKAHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion LCDJINCAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 EMNNLKOKJAK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72346C0", Offset = "0x72330C0", VA = "0x1872346C0")]
	public bool NBJBEMMKPFE(Collider LKIKJGEBEHP, Bounds LIPHIKJKPFE, bool LMGLEIPELIG, bool BKIMLCMNPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7233790", Offset = "0x7232190", VA = "0x187233790")]
	public bool BKBDKHDBGCL(Collider DDJHOHBDMLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72340F0", Offset = "0x7232AF0", VA = "0x1872340F0")]
	public bool LAGKAIFEJNB(Collider DDJHOHBDMLF, bool LMGLEIPELIG, bool BKIMLCMNPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7235030", Offset = "0x7233A30", VA = "0x187235030")]
	public void OJPACDPDPAG(Transform DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72337B0", Offset = "0x72321B0", VA = "0x1872337B0")]
	public void EJDHLJKBLGN(MJMBINKCMII OKGBBGMIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7233710", Offset = "0x7232110", VA = "0x187233710")]
	private static void BGINIPHNCJH(Vector3 ILMEANFNINA, Vector3 PLJHMOFCKBP, Vector3 BCPGICOCGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7234C40", Offset = "0x7233640", VA = "0x187234C40")]
	public static MJMBINKCMII NLICMPDOPKA(GameObject GFFCILHEGII, Quaternion LCDJINCAHMD, bool AEJPJHFLJPH, bool CEBOCGJFEFA, bool LMGLEIPELIG = false, bool BKIMLCMNPCH = false, bool AAPAPJLDNIO = false)
	{
		return default(MJMBINKCMII);
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum AssetBundleType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		WindowsDesktop,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		MobileIOS,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		MobileAndroid,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Obsolete("Quest bundles are Obsolete.  Use MobileAndroid instead", true)]
		OculusQuest,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Playstation4,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Playstation5,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Switch
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GNEOBHKDFJN
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Obsolete]
	InitialRelease_Unity_2019_4_26f1,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[Obsolete]
	Unity_2020_3_33f1,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Obsolete]
	Unity_2021_3_19f1,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Unity_2021_3_29f1,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Unity_2021_3_29f1_AvatarItemMaterialBundle
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LMALANCMMEL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string NEBFMOFMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7233590", Offset = "0x7231F90", VA = "0x187233590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string KCFHCHELOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7233560", Offset = "0x7231F60", VA = "0x187233560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string ICEKMJECBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7233530", Offset = "0x7231F30", VA = "0x187233530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72335C0", Offset = "0x7231FC0", VA = "0x1872335C0")]
	public static GNEOBHKDFJN NJPNOGDLNIC(this GNEOBHKDFJN KODMNBHABPL)
	{
		return default(GNEOBHKDFJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72335C0", Offset = "0x7231FC0", VA = "0x1872335C0")]
	public static int NJPNOGDLNIC(int KODMNBHABPL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OPAAGFMACGP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	AudioMixerGroup IHJEHDDIIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OPAAGFMACGP EJAGAMOLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IReadOnlyList<OPAAGFMACGP> PEPBBOEMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string ABMNGGOLFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GAPDGJPPFHI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class OGDKIIGECCP : OPAAGFMACGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly List<OPAAGFMACGP> PDEMGOFEBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal readonly OGDKIIGECCP DJEIHEPCOAN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OPAAGFMACGP EJAGAMOLJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AudioMixerGroup IHJEHDDIIIH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<OPAAGFMACGP> PEPBBOEMMMB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string ABMNGGOLFPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7236E50", Offset = "0x7235850", VA = "0x187236E50")]
		internal OGDKIIGECCP(AudioMixerGroup MFNJKEIOLKE, OGDKIIGECCP BMBBFJPOJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OPAAGFMACGP APALMDILNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AudioMixer OALJHLNEIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7232D00", Offset = "0x7231700", VA = "0x187232D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	private GAPDGJPPFHI(OGDKIIGECCP CFBAFJFENHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7232AC0", Offset = "0x72314C0", VA = "0x187232AC0")]
	public static GAPDGJPPFHI AILDDHACLGF(AudioMixer FKJDODLBCCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7232FF0", Offset = "0x72319F0", VA = "0x187232FF0")]
	public OPAAGFMACGP EJBBAHMBHBD(string IJLPEGHHALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7232D60", Offset = "0x7231760", VA = "0x187232D60")]
	public OPAAGFMACGP EJBBAHMBHBD(AudioMixerGroup MFNJKEIOLKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7233390", Offset = "0x7231D90", VA = "0x187233390")]
	private static int KNNJPLGCIJC(string BECGFNBELMK, int GBALKPFEDAI)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MaterialMapAssetBase<TMaterialMapAsset> : RecRoomStudioAutoGeneratedAsset<TMaterialMapAsset> where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MaterialEntry[] Entries
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x44DD3B0", Offset = "0x44DBDB0", VA = "0x1844DD3B0")]
		public MaterialEntry JPJBLILEKDE(Material GIIKGEKINDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x44DD4A0", Offset = "0x44DBEA0", VA = "0x1844DD4A0")]
		public void MKIMKCAIDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x384D6C0", Offset = "0x384C0C0", VA = "0x18384D6C0")]
		public MaterialMapAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class MaterialMapBase<TMaterialMapAsset> : RecRoomUnitySceneSystemBase where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static MaterialMapBase<TMaterialMapAsset> BOLGDNNEFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[HideInInspector]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private TMaterialMapAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static MaterialMapBase<TMaterialMapAsset> MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x44DD990", Offset = "0x44DC390", VA = "0x1844DD990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MaterialEntry[] HPJMFJNEJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x44DD8C0", Offset = "0x44DC2C0", VA = "0x1844DD8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x44DD4D0", Offset = "0x44DBED0", VA = "0x1844DD4D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x44DD7D0", Offset = "0x44DC1D0", VA = "0x1844DD7D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x44DD6F0", Offset = "0x44DC0F0", VA = "0x1844DD6F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x44DD6A0", Offset = "0x44DC0A0", VA = "0x1844DD6A0")]
		public void ClearSceneMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86F0F0", Offset = "0x86DAF0", VA = "0x18086F0F0")]
		protected MaterialMapBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class TextureProperty : IEquatable<TextureProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Texture value;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x723BBC0", Offset = "0x723A5C0", VA = "0x18723BBC0", Slot = "4")]
		public bool Equals(TextureProperty OKGBBGMIACH)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class FloatProperty : IEquatable<FloatProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7232A60", Offset = "0x7231460", VA = "0x187232A60", Slot = "4")]
		public bool Equals(FloatProperty OKGBBGMIACH)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VectorProperty : IEquatable<VectorProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Vector4 value;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x723C1E0", Offset = "0x723ABE0", VA = "0x18723C1E0", Slot = "4")]
		public bool Equals(VectorProperty OKGBBGMIACH)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ColorProperty : IEquatable<ColorProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Color value;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7231420", Offset = "0x722FE20", VA = "0x187231420", Slot = "4")]
		public bool Equals(ColorProperty OKGBBGMIACH)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MaterialEntry : IEquatable<MaterialEntry>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string shaderName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MaterialGlobalIlluminationFlags globalIlluminationFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int renderQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public bool doubleSidedGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TextureProperty[] texProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public FloatProperty[] floatProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public VectorProperty[] vecProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ColorProperty[] colorProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Dictionary<string, float> floatPropsDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Dictionary<int, float> floatPropIdDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Dictionary<int, Texture> texPropIdDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<int, Vector4> vecPropIdDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Dictionary<int, Color> colorPropIdDict;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7235340", Offset = "0x7233D40", VA = "0x187235340")]
		public void FEGCHCJGFKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7235780", Offset = "0x7234180", VA = "0x187235780")]
		public float HBAAEIHNOFH(int AOOLGPHJJIF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7235190", Offset = "0x7233B90", VA = "0x187235190")]
		public Texture DMDDNPJDMIK(int AOOLGPHJJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72356D0", Offset = "0x72340D0", VA = "0x1872356D0")]
		public Vector4 GJNLFEAPHCP(int AOOLGPHJJIF)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7235110", Offset = "0x7233B10", VA = "0x187235110")]
		public Color BCIHOMKPDAC(int AOOLGPHJJIF)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72351E0", Offset = "0x7233BE0", VA = "0x1872351E0", Slot = "4")]
		public bool Equals(MaterialEntry OKGBBGMIACH)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset> : RecRoomStudioAutoCreatedAsset<TAudioClipRegistryAsset> where TAudioClipRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		internal RecRoomAudioClipEntry[] clips;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyList<RecRoomAudioClipEntry> Clips
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x48E9730", Offset = "0x48E8130", VA = "0x1848E9730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D05AF0", Offset = "0x3D044F0", VA = "0x183D05AF0")]
		public RecRoomAudioClipRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RecRoomAudioClipEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AudioClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AddComponentMenu(null)]
	public abstract class RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> : RecRoomUnitySceneSystemBase where TAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> BOLGDNNEFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[ReadOnlyField]
		private TAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x44DD990", Offset = "0x44DC390", VA = "0x1844DD990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public TAudioClipRegistryAsset HPJMFJNEJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<RecRoomAudioClipEntry> JHDNHKMDEEB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x48E9A30", Offset = "0x48E8430", VA = "0x1848E9A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x48E9780", Offset = "0x48E8180", VA = "0x1848E9780")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x48E98B0", Offset = "0x48E82B0", VA = "0x1848E98B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86F0F0", Offset = "0x86DAF0", VA = "0x18086F0F0")]
		protected RecRoomAudioClipRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class RecRoomAudioMixerRegistryBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum MixerVersion
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum AudioMixerGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			Ambience,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Sounds,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Voice,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Voice_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Voice_HighPitch,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			Voice_Radio,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Voice_Radio_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			Voice_Radio_HighPitch
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<AudioMixerGroupType, string> HAAKMCABDCO;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string NJKGDOOGCON = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string PICEELACDNJ = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string BHEPIGENFPD = "Audio";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly string BELFGMBDIAH;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly string AHDODEOHFIH;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static RecRoomAudioMixerRegistryBase BOLGDNNEFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[ReadOnlyField]
		[SerializeField]
		private MixerVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[IntConditionallyVisibleField("version", 0, false)]
		[SerializeField]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[IntConditionallyVisibleField("version", 0, false)]
		[SerializeField]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[IntConditionallyVisibleField("version", 1, false)]
		[SerializeField]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static RecRoomAudioMixerRegistryBase MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x72380D0", Offset = "0x7236AD0", VA = "0x1872380D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public AudioMixer LLIFKHGNBCB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855360", VA = "0x180856960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HPJBMFGHLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7238120", Offset = "0x7236B20", VA = "0x187238120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MixerVersion GIOOEBIGKMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E710", VA = "0x18085FD10")]
			get
			{
				return default(MixerVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7238270", Offset = "0x7236C70", VA = "0x187238270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7237310", Offset = "0x7235D10", VA = "0x187237310")]
		public static string GetAudioGroupPath(AudioMixerGroupType ALJKHDHMEEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7237430", Offset = "0x7235E30", VA = "0x187237430")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroupType ALJKHDHMEEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72379C0", Offset = "0x72363C0", VA = "0x1872379C0")]
		private static AudioMixerGroup MHKEOMAHEOC(AudioMixer FKJDODLBCCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72371F0", Offset = "0x7235BF0", VA = "0x1872371F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7237CC0", Offset = "0x72366C0", VA = "0x187237CC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7237610", Offset = "0x7236010", VA = "0x187237610")]
		public bool IsValidOutputGroup(AudioMixerGroup NOHNHKLMDHI, [Out] string GGEHLADLJHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7237850", Offset = "0x7236250", VA = "0x187237850")]
		private bool JFHJONIBNID(AudioMixerGroup NOHNHKLMDHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7237A60", Offset = "0x7236460", VA = "0x187237A60")]
		private bool NIPMCGHOICN(AudioMixerGroup FCFADMNBADH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomAudioMixerRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class RecRoomBuiltInObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[HideInInspector]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		[SerializeField]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[HideInInspector]
		private Transform deformationTransform;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Guid BADBCEFLKEM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x72383B0", Offset = "0x7236DB0", VA = "0x1872383B0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7238420", Offset = "0x7236E20", VA = "0x187238420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool CPLGFEKKNAO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7238390", Offset = "0x7236D90", VA = "0x187238390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool CPFMGMBNDDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7238340", Offset = "0x7236D40", VA = "0x187238340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Transform JIEGLDJCDBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8579C0", VA = "0x180858FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
		public byte[] GetSpawnableTemplateData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870")]
		public void SetSpawnableTemplateData(byte[] CDGFPMKAKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5935BE0", Offset = "0x59345E0", VA = "0x185935BE0")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomBuiltInObjectBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class RecRoomBuiltInObjectDataBase<TRecRoomBuiltInObject> : ScriptableObject where TRecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private TRecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Dictionary<Guid, TRecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private Dictionary<Guid, TRecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x48E9C40", Offset = "0x48E8640", VA = "0x1848E9C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyDictionary<Guid, TRecRoomBuiltInObject> AllBuiltInObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3C42230", Offset = "0x3C40C30", VA = "0x183C42230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x48E9BD0", Offset = "0x48E85D0", VA = "0x1848E9BD0")]
		public void JKNAPFIKJPB(IEnumerable<TRecRoomBuiltInObject> PHHFFPPHMDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x48E9B20", Offset = "0x48E8520", VA = "0x1848E9B20")]
		public bool AKPHPFIGELN(Guid GOGHIBAALEE, [Out] TRecRoomBuiltInObject HKHLDKDPHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAE0", Offset = "0x8BD4E0", VA = "0x1808BEAE0")]
		protected RecRoomBuiltInObjectDataBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class RecRoomObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class OKLFCEGAODM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public bool value;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public OKLFCEGAODM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7236F70", Offset = "0x7235970", VA = "0x187236F70")]
			internal bool DNNKACBEOIJ(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CMCEMGMJNGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float value;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public CMCEMGMJNGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x722FEC0", Offset = "0x722E8C0", VA = "0x18722FEC0")]
			internal bool DNNKACBEOIJ(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class MLFFPLKLNKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int value;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public MLFFPLKLNKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x72350E0", Offset = "0x7233AE0", VA = "0x1872350E0")]
			internal bool DNNKACBEOIJ(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FEBLMBPCOOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string value;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public FEBLMBPCOOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x72329A0", Offset = "0x72313A0", VA = "0x1872329A0")]
			internal bool DNNKACBEOIJ(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class EKKCBNAEPCK : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private NamedUnityEventBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public RecRoomObjectBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private string eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public string <>3__eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private NamedUnityEventBase[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			NamedUnityEventBase IEnumerator<NamedUnityEventBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E700", VA = "0x18089FD00")]
			[DebuggerHidden]
			public EKKCBNAEPCK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x72327A0", Offset = "0x72311A0", VA = "0x1872327A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7232950", Offset = "0x7231350", VA = "0x187232950", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7232890", Offset = "0x7231290", VA = "0x187232890", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7232890", Offset = "0x7231290", VA = "0x187232890", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[HideInInspector]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[HideInInspector]
		[SerializeReference]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Dictionary<string, RecRoomObjectProperty> OBJAOPCLLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		[HideInInspector]
		private StudioFunctionList studioFunctions;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public RecRoomObjectProperty[] OLEHCIIPMEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public NamedUnityEventBase[] IPNOICOHDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public RecRoomObjectConfiguration LLLFDFINKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7239190", Offset = "0x7237B90", VA = "0x187239190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<StudioFunction> JHMKOADDADN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8554B0", VA = "0x180856AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObjectBase, string> FLEODHKCKJP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x72390E0", Offset = "0x7237AE0", VA = "0x1872390E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7239210", Offset = "0x7237C10", VA = "0x187239210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7238760", Offset = "0x7237160", VA = "0x187238760")]
		public bool TryGetProperty(string LMFCCDBJMHJ, [Out] RecRoomObjectProperty FMACLHMOMLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7238740", Offset = "0x7237140", VA = "0x187238740")]
		public void SendCircuitsEvent(string HNELEFLILPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7238930", Offset = "0x7237330", VA = "0x187238930")]
		public bool TryRaiseUnityEvent(string HNELEFLILPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2DB8500", Offset = "0x2DB6F00", VA = "0x182DB8500")]
		private bool HFNMODAHOIM<T0, T1, TEvent>(string HNELEFLILPG, T0 MAAGFDEEGBB, T1 JGCDIGHDPJC) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7238EF0", Offset = "0x72378F0", VA = "0x187238EF0")]
		public bool TryRaiseUnityEvent(string HNELEFLILPG, bool JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7238E10", Offset = "0x7237810", VA = "0x187238E10")]
		public bool TryRaiseUnityEvent(string HNELEFLILPG, float JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7238C60", Offset = "0x7237660", VA = "0x187238C60")]
		public bool TryRaiseUnityEvent(string HNELEFLILPG, int JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7238B10", Offset = "0x7237510", VA = "0x187238B10")]
		public bool TryRaiseUnityEvent(string HNELEFLILPG, string JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7238D30", Offset = "0x7237730", VA = "0x187238D30")]
		public bool TryRaiseUnityEvent(string HNELEFLILPG, string MAAGFDEEGBB, bool JGCDIGHDPJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7238FC0", Offset = "0x72379C0", VA = "0x187238FC0")]
		public bool TryRaiseUnityEvent(string HNELEFLILPG, string MAAGFDEEGBB, float JGCDIGHDPJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7238BF0", Offset = "0x72375F0", VA = "0x187238BF0")]
		public bool TryRaiseUnityEvent(string HNELEFLILPG, string MAAGFDEEGBB, int JGCDIGHDPJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7238DA0", Offset = "0x72377A0", VA = "0x187238DA0")]
		public bool TryRaiseUnityEvent(string HNELEFLILPG, string MAAGFDEEGBB, string JGCDIGHDPJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x72386A0", Offset = "0x72370A0", VA = "0x1872386A0")]
		[IteratorStateMachine(typeof(EKKCBNAEPCK))]
		private IEnumerable<NamedUnityEventBase> OCKHCBKFMMP(string HNELEFLILPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x72384A0", Offset = "0x7236EA0", VA = "0x1872384A0")]
		private bool BNPFGGDOCEP(string HNELEFLILPG, Func<NamedUnityEventBase, bool> BGDJPEHELDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7239030", Offset = "0x7237A30", VA = "0x187239030")]
		protected RecRoomObjectBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x723BEA0", Offset = "0x723A8A0", VA = "0x18723BEA0")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x723BEE0", Offset = "0x723A8E0", VA = "0x18723BEE0")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x723BF20", Offset = "0x723A920", VA = "0x18723BF20")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x723BFE0", Offset = "0x723A9E0", VA = "0x18723BFE0")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x723BFA0", Offset = "0x723A9A0", VA = "0x18723BFA0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x723C060", Offset = "0x723AA60", VA = "0x18723C060")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x723C020", Offset = "0x723AA20", VA = "0x18723C020")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x723C0A0", Offset = "0x723AAA0", VA = "0x18723C0A0")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "5")]
		public virtual bool TryInvokeEvent(bool JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "6")]
		public virtual bool TryInvokeEvent(float JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "7")]
		public virtual bool TryInvokeEvent(int JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "8")]
		public virtual bool TryInvokeEvent(string JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x453A850", Offset = "0x4539250", VA = "0x18453A850")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityParameterlessEventBase : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7235E50", Offset = "0x7234850", VA = "0x187235E50", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7235F20", Offset = "0x7234920", VA = "0x187235F20")]
		protected NamedUnityParameterlessEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3D05AF0", Offset = "0x3D044F0", VA = "0x183D05AF0")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3D05AF0", Offset = "0x3D044F0", VA = "0x183D05AF0")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityBooleanEventBase : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7235820", Offset = "0x7234220", VA = "0x187235820", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7235880", Offset = "0x7234280", VA = "0x187235880", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x72359F0", Offset = "0x72343F0", VA = "0x1872359F0")]
		protected NamedUnityBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityFloatEventBase : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7235A30", Offset = "0x7234430", VA = "0x187235A30", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7235A90", Offset = "0x7234490", VA = "0x187235A90", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7235C00", Offset = "0x7234600", VA = "0x187235C00")]
		protected NamedUnityFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityIntEventBase : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7235C40", Offset = "0x7234640", VA = "0x187235C40", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7235CA0", Offset = "0x72346A0", VA = "0x187235CA0", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7235E10", Offset = "0x7234810", VA = "0x187235E10")]
		protected NamedUnityIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityStringEventBase : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x72361A0", Offset = "0x7234BA0", VA = "0x1872361A0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7236200", Offset = "0x7234C00", VA = "0x187236200", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7236370", Offset = "0x7234D70", VA = "0x187236370")]
		protected NamedUnityStringEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringBooleanEventBase : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7235F60", Offset = "0x7234960", VA = "0x187235F60", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7235FC0", Offset = "0x72349C0", VA = "0x187235FC0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7236160", Offset = "0x7234B60", VA = "0x187236160")]
		protected NamedUnityStringBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringFloatEventBase : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72363B0", Offset = "0x7234DB0", VA = "0x1872363B0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7236410", Offset = "0x7234E10", VA = "0x187236410", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72365B0", Offset = "0x7234FB0", VA = "0x1872365B0")]
		protected NamedUnityStringFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityStringIntEventBase : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72365F0", Offset = "0x7234FF0", VA = "0x1872365F0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7236650", Offset = "0x7235050", VA = "0x187236650", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72367F0", Offset = "0x72351F0", VA = "0x1872367F0")]
		protected NamedUnityStringIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringStringEventBase : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7236830", Offset = "0x7235230", VA = "0x187236830", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7236890", Offset = "0x7235290", VA = "0x187236890", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7236A20", Offset = "0x7235420", VA = "0x187236A20")]
		protected NamedUnityStringStringEventBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> : RecRoomStudioAutoGeneratedAsset<TPrefabRegistryAsset> where TPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public TPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D05AF0", Offset = "0x3D044F0", VA = "0x183D05AF0")]
		public RecRoomObjectPrefabRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> : RecRoomUnitySceneSystemBase where TPrefabAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject>, new() where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> BOLGDNNEFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[HideInInspector]
		[SerializeField]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private TPrefabAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x44DD990", Offset = "0x44DC390", VA = "0x1844DD990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public IReadOnlyList<TPrefabEntry> APJPFCHPBLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x48EA4E0", Offset = "0x48E8EE0", VA = "0x1848EA4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x48EA230", Offset = "0x48E8C30", VA = "0x1848EA230")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x48EA360", Offset = "0x48E8D60", VA = "0x1848EA360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86F0F0", Offset = "0x86DAF0", VA = "0x18086F0F0")]
		protected RecRoomObjectPrefabRegistryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public abstract class RecRoomObjectPrefabEntryBase<TRecRoomObject> : IEquatable<RecRoomObjectPrefabEntryBase<TRecRoomObject>> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private TRecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private GameObject prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private RecRoomObjectPrefabObjectBoardTemplate objectBoardTemplate;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public GameObject PrefabRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x48EA180", Offset = "0x48E8B80", VA = "0x1848EA180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public RecRoomObjectPrefabObjectBoardTemplate ObjectBoardTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool HasObjectBoardData
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x48EA120", Offset = "0x48E8B20", VA = "0x1848EA120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x48E9EB0", Offset = "0x48E88B0", VA = "0x1848E9EB0", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabEntryBase<TRecRoomObject> OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x48EA030", Offset = "0x48E8A30", VA = "0x1848EA030", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x48EA100", Offset = "0x48E8B00", VA = "0x1848EA100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		protected RecRoomObjectPrefabEntryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class RecRoomObjectPrefabObjectBoardTemplate : IEquatable<RecRoomObjectPrefabObjectBoardTemplate>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private string signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private byte[] objectBoard;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string Signature
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public byte[] ObjectBoard
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7239410", Offset = "0x7237E10", VA = "0x187239410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x72392D0", Offset = "0x7237CD0", VA = "0x1872392D0", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabObjectBoardTemplate OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7239390", Offset = "0x7237D90", VA = "0x187239390")]
		private static bool NGDKAOCAKAO(byte[] OHIBEAKEHOF, byte[] DLCECMLMLMI)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class RecRoomStudioAnimatorSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public interface FPLLAKOCKMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SetBoolParameterFromScript(string BHFPKCCDEEC, bool GPBAFILNEOM);

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SetIntegerParameterFromScript(string BHFPKCCDEEC, int GPBAFILNEOM);

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetFloatParameterFromScript(string BHFPKCCDEEC, float GPBAFILNEOM);

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SetTriggerParameterFromScript(string BHFPKCCDEEC);
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public FPLLAKOCKMD FAEJJCGBDMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851290", VA = "0x180852890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7239820", Offset = "0x7238220", VA = "0x187239820")]
		public Animator GetControlledAnimator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7239860", Offset = "0x7238260", VA = "0x187239860")]
		public void SetBoolParameter(string BHFPKCCDEEC, bool GPBAFILNEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x72399F0", Offset = "0x72383F0", VA = "0x1872399F0")]
		public void SetIntegerParameter(string BHFPKCCDEEC, int GPBAFILNEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7239920", Offset = "0x7238320", VA = "0x187239920")]
		public void SetFloatParameter(string BHFPKCCDEEC, float GPBAFILNEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7239AB0", Offset = "0x72384B0", VA = "0x187239AB0")]
		public void SetTriggerParameter(string BHFPKCCDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomStudioAnimatorSynchronizerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class RecRoomStudioBillboardBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("If true, the object can turn left/right to face the player (y-axis rotation)")]
		[SerializeField]
		private bool yawRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		[Tooltip("If true, the object can look up/down to face the player (x-axis rotation)")]
		private bool pitchRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		[Tooltip("If true, the object can rotate clockwise/counter-clockwise to match the players rotation (z-axis rotation)")]
		private bool rollRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		[Tooltip("If true, makes the player \"look through\" the object rather than \"look at\" the object to accomadate Unity UI expectations")]
		private bool faceAwayFromCamera;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NOOJKBGPJLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E7A0", VA = "0x18091FDA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x854CE0", Offset = "0x8536E0", VA = "0x180854CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MNPHGELMCKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x974460", Offset = "0x972E60", VA = "0x180974460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA9D3E0", Offset = "0xA9BDE0", VA = "0x180A9D3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool EGFLMKACLON
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xF3FF10", Offset = "0xF3E910", VA = "0x180F3FF10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x21A81A0", Offset = "0x21A6BA0", VA = "0x1821A81A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool NHDFIHKIAEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xF3FEF0", Offset = "0xF3E8F0", VA = "0x180F3FEF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x3E1B9A0", Offset = "0x3E1A3A0", VA = "0x183E1B9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7239B70", Offset = "0x7238570", VA = "0x187239B70")]
		protected RecRoomStudioBillboardBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public abstract class RecRoomStudioCanvasInteractionBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public enum AttachmentMode
		{
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			[Tooltip("For screens and mobile players, moves the camera to frame the canvas.")]
			FrameScreensCanvas,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[Tooltip("For screens and mobile players, moves the canvas and anchors it onto the camera.")]
			AnchorCanvasAsMenu
		}

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public bool isAnchored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		private bool isInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("Allows the canvas to be anchored and framed to the screen")]
		[SerializeField]
		private bool canBeAnchored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[ConditionallyVisibleField("canBeAnchored", true, false)]
		[Tooltip("The way in which the menu frames up on screen")]
		[SerializeField]
		private AttachmentMode anchorAttachmentMode;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KBLBMPGFBJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E7A0", VA = "0x18091FDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GIEKHEAOLKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x974460", Offset = "0x972E60", VA = "0x180974460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool HPEPDLPNNPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xF3FF10", Offset = "0xF3E910", VA = "0x180F3FF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AttachmentMode CCMFNAALOIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x87A9F0", Offset = "0x8793F0", VA = "0x18087A9F0")]
			get
			{
				return default(AttachmentMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AttachmentMode> MKDBJMFPKCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7239BC0", Offset = "0x72385C0", VA = "0x187239BC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7239D10", Offset = "0x7238710", VA = "0x187239D10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action NEFEFLDDKAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7239C70", Offset = "0x7238670", VA = "0x187239C70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7239DC0", Offset = "0x72387C0", VA = "0x187239DC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7239B80", Offset = "0x7238580", VA = "0x187239B80")]
		public void AnchorCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7239BA0", Offset = "0x72385A0", VA = "0x187239BA0")]
		public void DetachCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomStudioCanvasInteractionBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class RecRoomStudioDisableRenderInShareCamPhotoBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public enum DisableRenderOptions
		{
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			NeverRender,
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			OnlyDisableForJunior
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private DisableRenderOptions renderOptions;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool LJCGFAGGKPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1454380", Offset = "0x1452D80", VA = "0x181454380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomStudioDisableRenderInShareCamPhotoBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class RecRoomStudioHudCanvasBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomStudioHudCanvasBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class RecRoomStudioInstanceRecolorBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Renderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly int EFODIBKFLFC;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public IReadOnlyList<Renderer> OKLGICAEGJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Color GMOFENMBBNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34280", VA = "0x180C35880")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x723A2C0", Offset = "0x7238CC0", VA = "0x18723A2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x723A100", Offset = "0x7238B00", VA = "0x18723A100")]
		public void RemoveMissingRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7239E90", Offset = "0x7238890", VA = "0x187239E90")]
		private void JPLKLFIOBGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x723A000", Offset = "0x7238A00", VA = "0x18723A000")]
		private void KNNEKIEPONE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7239E60", Offset = "0x7238860", VA = "0x187239E60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomStudioInstanceRecolorBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class RecRoomStudioRecNetImageBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		[Tooltip("If true, the image will be automatically cropped into a square.")]
		private bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private CJEAPMFINPC CNFANCJNKCM;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public CJEAPMFINPC MNCAJHNJOIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x723AC70", Offset = "0x7239670", VA = "0x18723AC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool DFOBMOHOLCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E7A0", VA = "0x18091FDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CNMBJKPOAPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x723AB30", Offset = "0x7239530", VA = "0x18723AB30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x723ABD0", Offset = "0x72395D0", VA = "0x18723ABD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomStudioRecNetImageBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class RecRoomUnitySceneSystemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomUnitySceneSystemBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class RecRoomVisualPostProcessingBase : RecRoomUnitySceneSystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[ReadOnlyField]
		[SerializeField]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static RecRoomVisualPostProcessingBase BOLGDNNEFAC;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static RecRoomVisualPostProcessingBase MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x723AEE0", Offset = "0x72398E0", VA = "0x18723AEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x723ACB0", Offset = "0x72396B0", VA = "0x18723ACB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x723ADA0", Offset = "0x72397A0", VA = "0x18723ADA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomVisualPostProcessingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyEnabledFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7232160", Offset = "0x7230B60", VA = "0x187232160")]
		public ConditionallyEnabledFieldAttribute(string propertyName, bool propertyValue, string disabledTooltip)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class NJNBADBAJPJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x72357D0", Offset = "0x72341D0", VA = "0x1872357D0")]
	protected NJNBADBAJPJ(string LMFCCDBJMHJ, bool HKNKBAEFAJL)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyVisibleFieldAttribute : NJNBADBAJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x72321C0", Offset = "0x7230BC0", VA = "0x1872321C0")]
		public ConditionallyVisibleFieldAttribute(string propertyName, bool propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class IntConditionallyVisibleFieldAttribute : NJNBADBAJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7233490", Offset = "0x7231E90", VA = "0x187233490")]
		public IntConditionallyVisibleFieldAttribute(string propertyName, int propertyValue, bool isReadOnly = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface CJEAPMFINPC
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string PPEHHPCLBOC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface HEMLOHDGBKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AttachMarkupComponent(T EOHGCJFJCPI, int EPNDGGJFDLK, bool BPJKKCCAGCI);
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[ConditionallyEnabledField("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		[SerializeField]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[ConditionallyEnabledField("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		[SerializeField]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private RecRoomObjectPhysicsMode physicsMode;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x72392C0", Offset = "0x7237CC0", VA = "0x1872392C0")]
		public RecRoomObjectConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum RecRoomObjectPhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Physical = 4
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2DB8FB0", Offset = "0x2DB79B0", VA = "0x182DB8FB0")]
		public bool AKPHPFIGELN<T>([Out] T JMDCGOKJIDA, [Out] string GGEHLADLJHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7239630", Offset = "0x7238030", VA = "0x187239630")]
		public static string CNGGJCKOOGJ(Type DOGPFNGIKMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x72395C0", Offset = "0x7237FC0", VA = "0x1872395C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7239550", Offset = "0x7237F50", VA = "0x187239550")]
		public MethodInfo LBEDFDDAPLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7239460", Offset = "0x7237E60", VA = "0x187239460")]
		public string FHOGPNFHMDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public abstract class RecRoomStudioAutoCreatedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAE0", Offset = "0x8BD4E0", VA = "0x1808BEAE0")]
		protected RecRoomStudioAutoCreatedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class RecRoomStudioAutoGeneratedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAE0", Offset = "0x8BD4E0", VA = "0x1808BEAE0")]
		public RecRoomStudioAutoGeneratedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class RecRoomStudioNavMeshCutBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public const float MINIMUM_WIDTH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		[Obsolete]
		[HideInInspector]
		private float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[FEKFPFLNFOJ("When using a Nav Mesh Cut, you may also want to set NavMesh Generation Mode to Ignore in the configure menu so the associated Rec Room Object won't bake into the navmesh on its own.")]
		[SerializeField]
		private Vector3 size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private Vector3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[Header("Optimization")]
		[FEKFPFLNFOJ("Ignoring rotation leads to better performance, but ignoring rotation also means that the box must be aligned with the X, Y, and Z axes.")]
		[SerializeField]
		private bool ignoreRotationAndScale;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		[Obsolete]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x723A690", Offset = "0x7239090", VA = "0x18723A690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x723A9B0", Offset = "0x72393B0", VA = "0x18723A9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		[Obsolete]
		public float Height
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAC0", Offset = "0x8BD4C0", VA = "0x1808BEAC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x723A910", Offset = "0x7239310", VA = "0x18723A910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool IgnoreRotationAndScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9E1740", Offset = "0x9E0140", VA = "0x1809E1740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x723A990", Offset = "0x7239390", VA = "0x18723A990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Vector3 Size
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xCB8250", Offset = "0xCB6C50", VA = "0x180CB8250")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x723AA30", Offset = "0x7239430", VA = "0x18723AA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public float HeightSizeY
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAC0", Offset = "0x8BD4C0", VA = "0x1808BEAC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x723A910", Offset = "0x7239310", VA = "0x18723A910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float XZUniformSquareSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x723AAB0", Offset = "0x72394B0", VA = "0x18723AAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Vector3 Center
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xB08D00", Offset = "0xB07700", VA = "0x180B08D00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x723A890", Offset = "0x7239290", VA = "0x18723A890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action OnSettingsChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x723A5F0", Offset = "0x7238FF0", VA = "0x18723A5F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x723A7F0", Offset = "0x72391F0", VA = "0x18723A7F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OnForceUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x723A550", Offset = "0x7238F50", VA = "0x18723A550")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x723A750", Offset = "0x7239150", VA = "0x18723A750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> OnEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x723A4A0", Offset = "0x7238EA0", VA = "0x18723A4A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x723A6A0", Offset = "0x72390A0", VA = "0x18723A6A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x723A340", Offset = "0x7238D40", VA = "0x18723A340")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1743710", Offset = "0x1742110", VA = "0x181743710")]
		[Obsolete]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1743710", Offset = "0x1742110", VA = "0x181743710")]
		public void ForceQueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x723A430", Offset = "0x7238E30", VA = "0x18723A430")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x723A430", Offset = "0x7238E30", VA = "0x18723A430")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x723A470", Offset = "0x7238E70", VA = "0x18723A470")]
		protected RecRoomStudioNavMeshCutBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GLMLDAHEKHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public byte[] PPFBACGMLII;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
	public GLMLDAHEKHP(byte[] MIJPDJDOIDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct PNDOGKOJHHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public byte[] PPFBACGMLII;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
	public PNDOGKOJHHJ(byte[] MIJPDJDOIDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DGCEKEMOKGA
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x72323E0", Offset = "0x7230DE0", VA = "0x1872323E0")]
	public static (GLMLDAHEKHP, PNDOGKOJHHJ) PLAACOKMHHM(Stream EDOGOHPOPNO)
	{
		return default((GLMLDAHEKHP, PNDOGKOJHHJ));
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7232220", Offset = "0x7230C20", VA = "0x187232220")]
	public static void HOHJEBJDHBO(Stream EDOGOHPOPNO, GLMLDAHEKHP FCMADEBOIJK, PNDOGKOJHHJ PNMECAEFMNK)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x21A6A60", Offset = "0x21A5460", VA = "0x1821A6A60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x68AD100", Offset = "0x68ABB00", VA = "0x1868AD100")]
		public SerializedGuid([In] Guid BMIGIGGJPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x68AD0D0", Offset = "0x68ABAD0", VA = "0x1868AD0D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x723AFB0", Offset = "0x72399B0", VA = "0x18723AFB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x68ACE80", Offset = "0x68AB880", VA = "0x1868ACE80", Slot = "7")]
		public bool Equals(SerializedGuid OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x723AF20", Offset = "0x7239920", VA = "0x18723AF20", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF50", Offset = "0x68AB950", VA = "0x1868ACF50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x68ACE50", Offset = "0x68AB850", VA = "0x1868ACE50", Slot = "6")]
		public int CompareTo(SerializedGuid OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x723B030", Offset = "0x7239A30", VA = "0x18723B030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SerializedTypeNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
		public SerializedTypeNameAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class EAGLMNIBJPC
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly CDLNJDLNIPA POJOAODEGGJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static readonly CDLNJDLNIPA ICPHOCJAFLC;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static readonly CDLNJDLNIPA DHAIOBNPBEO;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static readonly CDLNJDLNIPA NPBJBDEPKBL;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly CDLNJDLNIPA OOPMEFLEILH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static readonly CDLNJDLNIPA INPFICLLAOI;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7232610", Offset = "0x7231010", VA = "0x187232610")]
	static EAGLMNIBJPC()
	{
	}
}
namespace RecRoom.Core.Studio.StudioFunctions
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static readonly Argument Void;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Parameter Binding
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public Argument()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
		public Argument(string BHFPKCCDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x722FD70", Offset = "0x722E770", VA = "0x18722FD70")]
		public object FNEDDDIBHBA(object[] IKBEDOBPOAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x722FD00", Offset = "0x722E700", VA = "0x18722FD00")]
		internal void BIBCPGMNKLA(IReadOnlyList<Parameter> LDMPLMIKDPA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument<T> : Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		protected T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4025470", Offset = "0x4023E70", VA = "0x184025470", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4024FA0", Offset = "0x40239A0", VA = "0x184024FA0")]
		protected Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[UnityEngine.Scripting.Preserve]
	public sealed class VoidArgument : Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static readonly VoidArgument Instance;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x723C3D0", Offset = "0x723ADD0", VA = "0x18723C3D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x723C350", Offset = "0x723AD50", VA = "0x18723C350")]
		private VoidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4B3ECF0", Offset = "0x4B3D6F0", VA = "0x184B3ECF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x384D6C0", Offset = "0x384C0C0", VA = "0x18384D6C0")]
		protected ValueArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		protected string valueTypeAssemblyQualifiedName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x52D8CA0", Offset = "0x52D76A0", VA = "0x1852D8CA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x52D8A00", Offset = "0x52D7400", VA = "0x1852D8A00")]
		private Type FJJJHEMHDAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x37C8020", Offset = "0x37C6A20", VA = "0x1837C8020")]
		protected ClassArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolArgument : ValueArgument<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x722FE40", Offset = "0x722E840", VA = "0x18722FE40")]
		public BoolArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorArgument : ValueArgument<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x72313A0", Offset = "0x722FDA0", VA = "0x1872313A0")]
		public ColorArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Argument : ValueArgument<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7231320", Offset = "0x722FD20", VA = "0x187231320")]
		public Color32Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[UnityEngine.Scripting.Preserve]
	public sealed class GuidArgument : ValueArgument<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7233410", Offset = "0x7231E10", VA = "0x187233410")]
		public GuidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatArgument : ValueArgument<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x72329E0", Offset = "0x72313E0", VA = "0x1872329E0")]
		public FloatArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntArgument : ValueArgument<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7233450", Offset = "0x7231E50", VA = "0x187233450")]
		public IntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ShortArgument : ValueArgument<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x723B040", Offset = "0x7239A40", VA = "0x18723B040")]
		public ShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringArgument : ValueArgument<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x723B080", Offset = "0x7239A80", VA = "0x18723B080")]
		public StringArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UIntArgument : ValueArgument<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x723BE20", Offset = "0x723A820", VA = "0x18723BE20")]
		public UIntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UShortArgument : ValueArgument<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x723BE60", Offset = "0x723A860", VA = "0x18723BE60")]
		public UShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Argument : ValueArgument<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x723C0E0", Offset = "0x723AAE0", VA = "0x18723C0E0")]
		public Vector2Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Argument : ValueArgument<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x723C160", Offset = "0x723AB60", VA = "0x18723C160")]
		public Vector3Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionArgument : ValueArgument<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x72370F0", Offset = "0x7235AF0", VA = "0x1872370F0")]
		public QuaternionArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UnityObjectArgument : ClassArgument<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x723BF60", Offset = "0x723A960", VA = "0x18723BF60")]
		public UnityObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageArgument : ValueArgument<CJEAPMFINPC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7237170", Offset = "0x7235B70", VA = "0x187237170")]
		public RecNetImageArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void APPOJKGPLJE(string JCOPMGPGEJM, object[] IKBEDOBPOAP, object[] FFLFELCHDGH);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected internal abstract void MHMPEMDCPFN(IReadOnlyList<Parameter> LDMPLMIKDPA, IReadOnlyList<Parameter> GENNLFGNPCA);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		protected Instruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
		public override void APPOJKGPLJE(string JCOPMGPGEJM, object[] IKBEDOBPOAP, object[] FFLFELCHDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		protected internal override void MHMPEMDCPFN(IReadOnlyList<Parameter> LDMPLMIKDPA, IReadOnlyList<Parameter> GENNLFGNPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PlaceholderInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[UnityEngine.Scripting.Preserve]
	public sealed class CallInstruction : Instruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SerializeReference]
		private Argument[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SerializeReference]
		private Argument result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private MethodInfo RUNTIME_ONLY_resolvedMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static readonly MethodInfo InvalidMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private static object[][] argumentValueArrays;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x72312A0", Offset = "0x722FCA0", VA = "0x1872312A0")]
		public CallInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x722FF80", Offset = "0x722E980", VA = "0x18722FF80", Slot = "4")]
		public override void APPOJKGPLJE(string JCOPMGPGEJM, object[] IKBEDOBPOAP, object[] FFLFELCHDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7230A50", Offset = "0x722F450", VA = "0x187230A50")]
		private void CLFFIECBAPP(object[] FFLFELCHDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x72309B0", Offset = "0x722F3B0", VA = "0x1872309B0")]
		private void CDFCECAPAPE(object[] FFLFELCHDGH, object JOEPCGDHKKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7231080", Offset = "0x722FA80", VA = "0x187231080", Slot = "5")]
		protected internal override void MHMPEMDCPFN(IReadOnlyList<Parameter> LDMPLMIKDPA, IReadOnlyList<Parameter> GENNLFGNPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7230B00", Offset = "0x722F500", VA = "0x187230B00")]
		[UnityEngine.Scripting.Preserve]
		private static void EADLHBMIFMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7230D40", Offset = "0x722F740", VA = "0x187230D40")]
		private MethodInfo GHJEJGGFBEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x722FEF0", Offset = "0x722E8F0", VA = "0x18722FEF0")]
		internal MethodInfo AMKHOFJJJAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7230520", Offset = "0x722EF20", VA = "0x187230520")]
		internal static bool BMDMBLNIINO(UnityEngine.Object CGKANMHMCOJ, string GCNKICMJHEF, Argument[] AHNMHBFDPAL, [Out] MethodInfo NKCFICHAONK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7230F70", Offset = "0x722F970", VA = "0x187230F70")]
		private static bool LLELHEGMLFA(MethodInfo NKCFICHAONK, Type[] CPNKALIACNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7230B60", Offset = "0x722F560", VA = "0x187230B60")]
		private static object[] GGKMKBJMDBK(int NJCCLKNBFHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7230E00", Offset = "0x722F800", VA = "0x187230E00")]
		private object[] LEKCAPNKDLD(object[] IKBEDOBPOAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x72304C0", Offset = "0x722EEC0", VA = "0x1872304C0")]
		private void BIKHJPLPEOP(object[] KALBJFBHCCA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ConditionalInstruction : Instruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[SerializeField]
		private Condition[] conditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeReference]
		private Instruction[] @default;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x72320E0", Offset = "0x7230AE0", VA = "0x1872320E0")]
		public ConditionalInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x72319A0", Offset = "0x72303A0", VA = "0x1872319A0", Slot = "4")]
		public override void APPOJKGPLJE(string JCOPMGPGEJM, object[] IKBEDOBPOAP, object[] FFLFELCHDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7231E50", Offset = "0x7230850", VA = "0x187231E50", Slot = "5")]
		protected internal override void MHMPEMDCPFN(IReadOnlyList<Parameter> LDMPLMIKDPA, IReadOnlyList<Parameter> GENNLFGNPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7231DE0", Offset = "0x72307E0", VA = "0x187231DE0")]
		private void BIBCPGMNKLA(IReadOnlyList<Parameter> LDMPLMIKDPA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Condition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public IReadOnlyList<Instruction> Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7231950", Offset = "0x7230350", VA = "0x187231950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x72318D0", Offset = "0x72302D0", VA = "0x1872318D0")]
		public Condition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x72314B0", Offset = "0x722FEB0", VA = "0x1872314B0")]
		public static bool APFNLDOAKNH(string JMDCGOKJIDA, [Out] bool PDGCCBEJPHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7231800", Offset = "0x7230200", VA = "0x187231800")]
		public static bool NGNMGOLKFPK(string JMDCGOKJIDA, [Out] int EOHIGKOGJIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7231630", Offset = "0x7230030", VA = "0x187231630")]
		public bool FFLCMKNBLAM(bool DNMBKFMGCNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7231720", Offset = "0x7230120", VA = "0x187231720")]
		public bool GHIABGELPJB(int ADCACDKIMNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7231610", Offset = "0x7230010", VA = "0x187231610")]
		public bool FFEMNJADENJ(string IHAJEOKDCAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7231580", Offset = "0x722FF80", VA = "0x187231580")]
		public void APPOJKGPLJE(string JCOPMGPGEJM, object[] IKBEDOBPOAP, object[] FFLFELCHDGH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xB05CB0", Offset = "0xB046B0", VA = "0x180B05CB0")]
		public Parameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7236FB0", Offset = "0x72359B0", VA = "0x187236FB0")]
		internal void JNDBMEJPDLM(int DBNCJKKLBPK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderParameter : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7237090", Offset = "0x7235A90", VA = "0x187237090", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter<T> : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x477EB20", Offset = "0x477D520", VA = "0x18477EB20")]
		protected Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4BB7D00", Offset = "0x4BB6700", VA = "0x184BB7D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x384D6C0", Offset = "0x384C0C0", VA = "0x18384D6C0")]
		protected ValueParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeField]
		private string valueTypeFullName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x52D8DD0", Offset = "0x52D77D0", VA = "0x1852D8DD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x52D8D10", Offset = "0x52D7710", VA = "0x1852D8D10")]
		private Type FJJJHEMHDAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x37C8020", Offset = "0x37C6A20", VA = "0x1837C8020")]
		protected ClassParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolParameter : ValueParameter<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x722FE80", Offset = "0x722E880", VA = "0x18722FE80")]
		public BoolParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorParameter : ValueParameter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x72313E0", Offset = "0x722FDE0", VA = "0x1872313E0")]
		public ColorParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Parameter : ValueParameter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7231360", Offset = "0x722FD60", VA = "0x187231360")]
		public Color32Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatParameter : ValueParameter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7232A20", Offset = "0x7231420", VA = "0x187232A20")]
		public FloatParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntParameter : ValueParameter<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x72334F0", Offset = "0x7231EF0", VA = "0x1872334F0")]
		public IntParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringParameter : ValueParameter<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x723B0C0", Offset = "0x7239AC0", VA = "0x18723B0C0")]
		public StringParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Parameter : ValueParameter<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x723C120", Offset = "0x723AB20", VA = "0x18723C120")]
		public Vector2Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Parameter : ValueParameter<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x723C1A0", Offset = "0x723ABA0", VA = "0x18723C1A0")]
		public Vector3Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionParameter : ValueParameter<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7237130", Offset = "0x7235B30", VA = "0x187237130")]
		public QuaternionParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageParameter : ValueParameter<CJEAPMFINPC>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x72371B0", Offset = "0x7235BB0", VA = "0x1872371B0")]
		public RecNetImageParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StudioFunction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeReference]
		private Parameter[] parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeReference]
		private Parameter[] results;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private bool RUNTIME_ONLY_didAssignParameterIndices;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x723BB00", Offset = "0x723A500", VA = "0x18723BB00")]
		public StudioFunction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x723B470", Offset = "0x7239E70", VA = "0x18723B470")]
		public void APPOJKGPLJE(object[] IKBEDOBPOAP, object[] FFLFELCHDGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x723B800", Offset = "0x723A200", VA = "0x18723B800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x723B650", Offset = "0x723A050", VA = "0x18723B650")]
		private void CFKJPAFBMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x723B790", Offset = "0x723A190", VA = "0x18723B790")]
		private void MHMPEMDCPFN()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[UnityEngine.Scripting.Preserve]
	public class StudioFunctionList : IReadOnlyList<StudioFunction>, IEnumerable<StudioFunction>, IEnumerable, IReadOnlyCollection<StudioFunction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		[HideInInspector]
		private StudioFunction[] array;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private IReadOnlyList<StudioFunction> ReadOnlyList
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x723B420", Offset = "0x7239E20", VA = "0x18723B420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x723B250", Offset = "0x7239C50", VA = "0x18723B250", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public StudioFunction this[int DHNLEFJCEAH]
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x723B340", Offset = "0x7239D40", VA = "0x18723B340", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x723B100", Offset = "0x7239B00", VA = "0x18723B100", Slot = "6")]
		public IEnumerator<StudioFunction> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x723B180", Offset = "0x7239B80", VA = "0x18723B180", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x723B200", Offset = "0x7239C00", VA = "0x18723B200")]
		public StudioFunctionList()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class OBBIKMIGHJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7236A60", Offset = "0x7235460", VA = "0x187236A60")]
	public static string JIMBNKDCGLO(this Type NCMHJNKFAGH)
	{
		return null;
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public abstract class RecRoomStudioAvatarItemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
		protected RecRoomStudioAvatarItemBase()
		{
		}
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
