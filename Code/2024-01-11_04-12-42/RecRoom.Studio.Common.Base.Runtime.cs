using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Studio.StudioFunctions;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct LMEIOIKMAJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 NKIHCCCONPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion KPKKBKKOGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 KLCIOBDPCEB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67136A0", Offset = "0x67120A0", VA = "0x1867136A0")]
	public bool MADJLDOIEEL(Collider BLBJIPJCMAO, Bounds CBIDNPMBEAJ, bool BAFEJCDEFAK, bool DCNCPGLIEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67128A0", Offset = "0x67112A0", VA = "0x1867128A0")]
	public bool CIPMBPOLGBD(Collider BDAHFBGOEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67122D0", Offset = "0x6710CD0", VA = "0x1867122D0")]
	public bool CGHDPNMLOKN(Collider BDAHFBGOEJD, bool BAFEJCDEFAK, bool DCNCPGLIEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6712CB0", Offset = "0x67116B0", VA = "0x186712CB0")]
	public void KPKKECAOCMF(Transform FIGFLJOONIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6712D60", Offset = "0x6711760", VA = "0x186712D60")]
	public void LNHFCIAGCFN(LMEIOIKMAJM CGDFJMJIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6712250", Offset = "0x6710C50", VA = "0x186712250")]
	private static void AOFBMNFDDNH(Vector3 NHJJBILLIAC, Vector3 GPOGCNJCGJN, Vector3 IIOMHHNKEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67128C0", Offset = "0x67112C0", VA = "0x1867128C0")]
	public static LMEIOIKMAJM EDIBHGELBFP(GameObject AJBLHMMPNNM, Quaternion KPKKBKKOGOG, bool LGKENECBMLI, bool AHIKKPGMCDB, bool BAFEJCDEFAK = false, bool DCNCPGLIEJO = false, bool ACPFHIJLPED = false)
	{
		return default(LMEIOIKMAJM);
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
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
		Playstation5
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CKHBDFGEOIF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AudioMixerGroup KEOHPBBLDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	CKHBDFGEOIF HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<CKHBDFGEOIF> PHBLENHDKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string EPPIKABLEBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KJMMHPMGCGO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class POJFIJKJPJE : CKHBDFGEOIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly List<CKHBDFGEOIF> DHAOOBGGGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly POJFIJKJPJE PICNAAGCEPE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CKHBDFGEOIF HOANOOGFEFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AudioMixerGroup KEOHPBBLDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<CKHBDFGEOIF> PHBLENHDKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string EPPIKABLEBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x67159B0", Offset = "0x67143B0", VA = "0x1867159B0")]
		internal POJFIJKJPJE(AudioMixerGroup IAFGCJPMAEC, POJFIJKJPJE CDMOGOKIPKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CKHBDFGEOIF DPJNOMDEKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AudioMixer GAAGHGCNDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67121F0", Offset = "0x6710BF0", VA = "0x1867121F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	private KJMMHPMGCGO(POJFIJKJPJE BLICENKGPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6711900", Offset = "0x6710300", VA = "0x186711900")]
	public static KJMMHPMGCGO BMNJCKNAMKL(AudioMixer CCIMKPBLDIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6711E50", Offset = "0x6710850", VA = "0x186711E50")]
	public CKHBDFGEOIF KJAFHFGMHBO(string DEEFDANJNFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6711BC0", Offset = "0x67105C0", VA = "0x186711BC0")]
	public CKHBDFGEOIF KJAFHFGMHBO(AudioMixerGroup IAFGCJPMAEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6711B40", Offset = "0x6710540", VA = "0x186711B40")]
	private static int CJDBKLMBABF(string FFGOGGNCCME, int OHBFODPGDGE)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MaterialMapAssetBase<TMaterialMapAsset> : RecRoomStudioBuildAsset<TMaterialMapAsset> where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MaterialEntry[] Entries
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E231D0", Offset = "0x3E21BD0", VA = "0x183E231D0")]
		public void PJNNJOBIKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x326D010", Offset = "0x326BA10", VA = "0x18326D010")]
		public MaterialMapAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MaterialMapBase<TMaterialMapAsset> : MonoBehaviour where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static MaterialMapBase<TMaterialMapAsset> BDFKMGIHPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[HideInInspector]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private TMaterialMapAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static MaterialMapBase<TMaterialMapAsset> KHPIFBDMEAA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x36F0DD0", Offset = "0x36EF7D0", VA = "0x1836F0DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public MaterialEntry[] GLOPKLKOGDA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3E235C0", Offset = "0x3E21FC0", VA = "0x183E235C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E23200", Offset = "0x3E21C00", VA = "0x183E23200")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E234D0", Offset = "0x3E21ED0", VA = "0x183E234D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E23420", Offset = "0x3E21E20", VA = "0x183E23420")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E233D0", Offset = "0x3E21DD0", VA = "0x183E233D0")]
		public void ClearSceneMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected MaterialMapBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class TextureProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Texture value;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FloatProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float value;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class VectorProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Vector4 value;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ColorProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public Color value;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MaterialEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public string shaderName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MaterialGlobalIlluminationFlags globalIlluminationFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int renderQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public bool doubleSidedGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TextureProperty[] texProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public FloatProperty[] floatProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public VectorProperty[] vecProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ColorProperty[] colorProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Dictionary<string, float> floatPropsDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Dictionary<int, float> floatPropIdDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Dictionary<int, Texture> texPropIdDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<int, Vector4> vecPropIdDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Dictionary<int, Color> colorPropIdDict;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6713F70", Offset = "0x6712970", VA = "0x186713F70")]
		public void OBBKDEMDBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6713ED0", Offset = "0x67128D0", VA = "0x186713ED0")]
		public float FMAANEEEMPA(int OBIGLBACPPM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6713F20", Offset = "0x6712920", VA = "0x186713F20")]
		public Texture HEOFGMOOGBA(int OBIGLBACPPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6713E20", Offset = "0x6712820", VA = "0x186713E20")]
		public Vector4 EBKKOJLNAHD(int OBIGLBACPPM)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6714300", Offset = "0x6712D00", VA = "0x186714300")]
		public Color POOCPCPHNLO(int OBIGLBACPPM)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset> : RecRoomStudioBuildAsset<TAudioClipRegistryAsset> where TAudioClipRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		internal RecRoomAudioClipEntry[] clips;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<RecRoomAudioClipEntry> Clips
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4211E50", Offset = "0x4210850", VA = "0x184211E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x326D010", Offset = "0x326BA10", VA = "0x18326D010")]
		public RecRoomAudioClipRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class RecRoomAudioClipEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AudioClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu(null)]
	public abstract class RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> : MonoBehaviour where TAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> BDFKMGIHPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private TAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> KHPIFBDMEAA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x36F0DD0", Offset = "0x36EF7D0", VA = "0x1836F0DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TAudioClipRegistryAsset GLOPKLKOGDA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyList<RecRoomAudioClipEntry> DONKPBCHBNP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4212160", Offset = "0x4210B60", VA = "0x184212160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4211EA0", Offset = "0x42108A0", VA = "0x184211EA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4211FD0", Offset = "0x42109D0", VA = "0x184211FD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomAudioClipRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class RecRoomAudioMixerRegistryBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum MixerVersion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public enum AudioMixerGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Ambience,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Sounds,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Voice,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Voice_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			Voice_HighPitch,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			Voice_Radio,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			Voice_Radio_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			Voice_Radio_HighPitch
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Dictionary<AudioMixerGroupType, string> MMFGDJMBCAF;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const string IJIMJFLMOPE = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string MIFLAJDHEDH = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string GBPGLOEBOAL = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly string KNKMEOGHAJO;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly string EKEMBNLOKNJ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static RecRoomAudioMixerRegistryBase BDFKMGIHPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		[ReadOnlyField]
		private MixerVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[IntConditionallyVisibleField("version", 0, false)]
		[SerializeField]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[IntConditionallyVisibleField("version", 1, false)]
		[SerializeField]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static RecRoomAudioMixerRegistryBase KHPIFBDMEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6716C60", Offset = "0x6715660", VA = "0x186716C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AudioMixer GIDJIIHHNBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool NDGHBLBODDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6716CB0", Offset = "0x67156B0", VA = "0x186716CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public MixerVersion MLKHALHFOCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7977F0", Offset = "0x7961F0", VA = "0x1807977F0")]
			get
			{
				return default(MixerVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6716E00", Offset = "0x6715800", VA = "0x186716E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6716270", Offset = "0x6714C70", VA = "0x186716270")]
		public static string GetAudioGroupPath(AudioMixerGroupType LOGGOOKHHFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6716390", Offset = "0x6714D90", VA = "0x186716390")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroupType LOGGOOKHHFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67167B0", Offset = "0x67151B0", VA = "0x1867167B0")]
		private static AudioMixerGroup LPAAFJBHHNN(AudioMixer CCIMKPBLDIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6715EF0", Offset = "0x67148F0", VA = "0x186715EF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6716850", Offset = "0x6715250", VA = "0x186716850")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6716570", Offset = "0x6714F70", VA = "0x186716570")]
		public bool IsValidOutputGroup(AudioMixerGroup PHLIGLKGADJ, [Out] string BNFACNGELAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6715D80", Offset = "0x6714780", VA = "0x186715D80")]
		private bool AOLHAEDIGJH(AudioMixerGroup PHLIGLKGADJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6716010", Offset = "0x6714A10", VA = "0x186716010")]
		private bool CALHKLHLFFO(AudioMixerGroup GJPOIIGEGDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomAudioMixerRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class RecRoomBuiltInObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[HideInInspector]
		[SerializeField]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[ReadOnlyField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[ReadOnlyField]
		private RecRoomBuiltInObjectCategory category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[HideInInspector]
		[SerializeField]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnlyField]
		[SerializeField]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[ReadOnlyField]
		private bool isCloneable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[ReadOnlyField]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		[SerializeField]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Guid AELGLOINNGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6716F40", Offset = "0x6715940", VA = "0x186716F40")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6716FB0", Offset = "0x67159B0", VA = "0x186716FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string NBMOENGHIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x790CA0", Offset = "0x78F6A0", VA = "0x180790CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RecRoomBuiltInObjectCategory NGAEKLDEOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7965A0", Offset = "0x794FA0", VA = "0x1807965A0")]
			get
			{
				return default(RecRoomBuiltInObjectCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x796620", Offset = "0x795020", VA = "0x180796620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool OEFJOPGPIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x814F20", Offset = "0x813920", VA = "0x180814F20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x814920", Offset = "0x813320", VA = "0x180814920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool DOPABDBPPNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x88A280", Offset = "0x888C80", VA = "0x18088A280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x889F40", Offset = "0x888940", VA = "0x180889F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool FBPOFKBPBAG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1A715D0", Offset = "0x1A6FFD0", VA = "0x181A715D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x11A35B0", Offset = "0x11A1FB0", VA = "0x1811A35B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool KEJLFDEFFLP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x56B4790", Offset = "0x56B3190", VA = "0x1856B4790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x58C7250", Offset = "0x58C5C50", VA = "0x1858C7250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool NNJMHALKKDF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6716F20", Offset = "0x6715920", VA = "0x186716F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool DHCLNNFCFNA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6716ED0", Offset = "0x67158D0", VA = "0x186716ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		public byte[] GetSpawnableTemplateData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0")]
		public void SetSpawnableTemplateData(byte[] IGANDLHFMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xE487F0", Offset = "0xE471F0", VA = "0x180E487F0")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomBuiltInObjectBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class RecRoomBuiltInObjectDataBase<TRecRoomBuiltInObject> : ScriptableObject where TRecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private TRecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Dictionary<Guid, TRecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Dictionary<Guid, TRecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4212320", Offset = "0x4210D20", VA = "0x184212320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IReadOnlyDictionary<Guid, TRecRoomBuiltInObject> AllBuiltInObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3631160", Offset = "0x362FB60", VA = "0x183631160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x42122C0", Offset = "0x4210CC0", VA = "0x1842122C0")]
		public void NMGLODDPJFL(IEnumerable<TRecRoomBuiltInObject> OHLHGLGPDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4212230", Offset = "0x4210C30", VA = "0x184212230")]
		public bool GFGJHMKHGPD(Guid LAHJDPIOAPO, [Out] TRecRoomBuiltInObject DNLPLIOBADA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81C660", Offset = "0x81B060", VA = "0x18081C660")]
		protected RecRoomBuiltInObjectDataBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum RecRoomBuiltInObjectCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Prop,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Gadget
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class RecRoomObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CCPNMNDGGJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool value;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public CCPNMNDGGJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x670F170", Offset = "0x670DB70", VA = "0x18670F170")]
			internal bool FAIMBJJNLOM(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HJNGJAAJNFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float value;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public HJNGJAAJNFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x67117C0", Offset = "0x67101C0", VA = "0x1867117C0")]
			internal bool FAIMBJJNLOM(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class JILLKHEPPCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public int value;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public JILLKHEPPCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x67118D0", Offset = "0x67102D0", VA = "0x1867118D0")]
			internal bool FAIMBJJNLOM(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class NDGDBGGCENM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public string value;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public NDGDBGGCENM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1D22150", Offset = "0x1D20B50", VA = "0x181D22150")]
			internal bool FAIMBJJNLOM(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class MDKAFJAGDPD : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private NamedUnityEventBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public RecRoomObjectBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private string eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public string <>3__eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private NamedUnityEventBase[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			NamedUnityEventBase IEnumerator<NamedUnityEventBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x930310", Offset = "0x92ED10", VA = "0x180930310")]
			[DebuggerHidden]
			public MDKAFJAGDPD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6713C20", Offset = "0x6712620", VA = "0x186713C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6713DD0", Offset = "0x67127D0", VA = "0x186713DD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6713D10", Offset = "0x6712710", VA = "0x186713D10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6713D10", Offset = "0x6712710", VA = "0x186713D10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		[HideInInspector]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[HideInInspector]
		[SerializeReference]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Dictionary<string, RecRoomObjectProperty> NLLHAFMPHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[HideInInspector]
		[SerializeField]
		private StudioFunctionList studioFunctions;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public RecRoomObjectProperty[] CEDHPFPINDF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NamedUnityEventBase[] BJFJNPJBHIK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public RecRoomObjectConfiguration AOAAKCHHJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6717DB0", Offset = "0x67167B0", VA = "0x186717DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<StudioFunction> BAKFOIIGOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x793D40", Offset = "0x792740", VA = "0x180793D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObjectBase, string> OAGJIDFLHEI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6717D00", Offset = "0x6716700", VA = "0x186717D00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6717E40", Offset = "0x6716840", VA = "0x186717E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67172D0", Offset = "0x6715CD0", VA = "0x1867172D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6717380", Offset = "0x6715D80", VA = "0x186717380")]
		public bool TryGetProperty(string JJCBBELMNJG, [Out] RecRoomObjectProperty NPDAMELJOLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6717360", Offset = "0x6715D60", VA = "0x186717360")]
		public void SendCircuitsEvent(string HHDAKFCMDBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6717550", Offset = "0x6715F50", VA = "0x186717550")]
		public bool TryRaiseUnityEvent(string HHDAKFCMDBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x284A2D0", Offset = "0x2848CD0", VA = "0x18284A2D0")]
		private bool GAGEGAMJCKD<T0, T1, TEvent>(string HHDAKFCMDBN, T0 OPHDDFPAJAN, T1 JIJOKKNPMNH) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6717B10", Offset = "0x6716510", VA = "0x186717B10")]
		public bool TryRaiseUnityEvent(string HHDAKFCMDBN, bool BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6717A30", Offset = "0x6716430", VA = "0x186717A30")]
		public bool TryRaiseUnityEvent(string HHDAKFCMDBN, float BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6717880", Offset = "0x6716280", VA = "0x186717880")]
		public bool TryRaiseUnityEvent(string HHDAKFCMDBN, int BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6717730", Offset = "0x6716130", VA = "0x186717730")]
		public bool TryRaiseUnityEvent(string HHDAKFCMDBN, string BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6717950", Offset = "0x6716350", VA = "0x186717950")]
		public bool TryRaiseUnityEvent(string HHDAKFCMDBN, string OPHDDFPAJAN, bool JIJOKKNPMNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6717BE0", Offset = "0x67165E0", VA = "0x186717BE0")]
		public bool TryRaiseUnityEvent(string HHDAKFCMDBN, string OPHDDFPAJAN, float JIJOKKNPMNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6717810", Offset = "0x6716210", VA = "0x186717810")]
		public bool TryRaiseUnityEvent(string HHDAKFCMDBN, string OPHDDFPAJAN, int JIJOKKNPMNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x67179C0", Offset = "0x67163C0", VA = "0x1867179C0")]
		public bool TryRaiseUnityEvent(string HHDAKFCMDBN, string OPHDDFPAJAN, string JIJOKKNPMNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6717030", Offset = "0x6715A30", VA = "0x186717030")]
		[IteratorStateMachine(typeof(MDKAFJAGDPD))]
		private IEnumerable<NamedUnityEventBase> EDJMNBOFGGJ(string HHDAKFCMDBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x67170D0", Offset = "0x6715AD0", VA = "0x1867170D0")]
		private bool LLELNHLHLAB(string HHDAKFCMDBN, Func<NamedUnityEventBase, bool> DLHIHAHPECP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6717C50", Offset = "0x6716650", VA = "0x186717C50")]
		protected RecRoomObjectBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x67197E0", Offset = "0x67181E0", VA = "0x1867197E0")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6719820", Offset = "0x6718220", VA = "0x186719820")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6719860", Offset = "0x6718260", VA = "0x186719860")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6719920", Offset = "0x6718320", VA = "0x186719920")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x67198E0", Offset = "0x67182E0", VA = "0x1867198E0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x67199A0", Offset = "0x67183A0", VA = "0x1867199A0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6719960", Offset = "0x6718360", VA = "0x186719960")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x67199E0", Offset = "0x67183E0", VA = "0x1867199E0")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "5")]
		public virtual bool TryInvokeEvent(bool BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "6")]
		public virtual bool TryInvokeEvent(float BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "7")]
		public virtual bool TryInvokeEvent(int BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "8")]
		public virtual bool TryInvokeEvent(string BEEGCHJLJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3EBB1D0", Offset = "0x3EB9BD0", VA = "0x183EBB1D0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[SerializedTypeName]
	[Preserve]
	public abstract class NamedUnityParameterlessEventBase : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67149B0", Offset = "0x67133B0", VA = "0x1867149B0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6714A80", Offset = "0x6713480", VA = "0x186714A80")]
		protected NamedUnityParameterlessEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[Preserve]
	[SerializedTypeName]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x326D010", Offset = "0x326BA10", VA = "0x18326D010")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	[SerializedTypeName]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x326D010", Offset = "0x326BA10", VA = "0x18326D010")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityBooleanEventBase : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6714380", Offset = "0x6712D80", VA = "0x186714380", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x67143E0", Offset = "0x6712DE0", VA = "0x1867143E0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6714550", Offset = "0x6712F50", VA = "0x186714550")]
		protected NamedUnityBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[SerializedTypeName]
	[Preserve]
	public abstract class NamedUnityFloatEventBase : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6714590", Offset = "0x6712F90", VA = "0x186714590", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x67145F0", Offset = "0x6712FF0", VA = "0x1867145F0", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6714760", Offset = "0x6713160", VA = "0x186714760")]
		protected NamedUnityFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityIntEventBase : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x67147A0", Offset = "0x67131A0", VA = "0x1867147A0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6714800", Offset = "0x6713200", VA = "0x186714800", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6714970", Offset = "0x6713370", VA = "0x186714970")]
		protected NamedUnityIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[SerializedTypeName]
	[Preserve]
	public abstract class NamedUnityStringEventBase : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6714D00", Offset = "0x6713700", VA = "0x186714D00", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6714D60", Offset = "0x6713760", VA = "0x186714D60", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6714ED0", Offset = "0x67138D0", VA = "0x186714ED0")]
		protected NamedUnityStringEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityStringBooleanEventBase : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6714AC0", Offset = "0x67134C0", VA = "0x186714AC0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6714B20", Offset = "0x6713520", VA = "0x186714B20", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6714CC0", Offset = "0x67136C0", VA = "0x186714CC0")]
		protected NamedUnityStringBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityStringFloatEventBase : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6714F10", Offset = "0x6713910", VA = "0x186714F10", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6714F70", Offset = "0x6713970", VA = "0x186714F70", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6715110", Offset = "0x6713B10", VA = "0x186715110")]
		protected NamedUnityStringFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityStringIntEventBase : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6715150", Offset = "0x6713B50", VA = "0x186715150", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x67151B0", Offset = "0x6713BB0", VA = "0x1867151B0", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6715350", Offset = "0x6713D50", VA = "0x186715350")]
		protected NamedUnityStringIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityStringStringEventBase : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6715390", Offset = "0x6713D90", VA = "0x186715390", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x67153F0", Offset = "0x6713DF0", VA = "0x1867153F0", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6715580", Offset = "0x6713F80", VA = "0x186715580")]
		protected NamedUnityStringStringEventBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> : RecRoomStudioBuildAsset<TPrefabRegistryAsset> where TPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public TPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x326D010", Offset = "0x326BA10", VA = "0x18326D010")]
		public RecRoomObjectPrefabRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> : MonoBehaviour where TPrefabAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject>, new() where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> BDFKMGIHPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[HideInInspector]
		[SerializeField]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private TPrefabAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> KHPIFBDMEAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x36F0DD0", Offset = "0x36EF7D0", VA = "0x1836F0DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IReadOnlyList<TPrefabEntry> LHFAKALLNAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x4212B00", Offset = "0x4211500", VA = "0x184212B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4212840", Offset = "0x4211240", VA = "0x184212840")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4212970", Offset = "0x4211370", VA = "0x184212970")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomObjectPrefabRegistryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public abstract class RecRoomObjectPrefabEntryBase<TRecRoomObject> : IEquatable<RecRoomObjectPrefabEntryBase<TRecRoomObject>> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private TRecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private GameObject prefabRoot;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public GameObject PrefabRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4212790", Offset = "0x4211190", VA = "0x184212790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4212580", Offset = "0x4210F80", VA = "0x184212580", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabEntryBase<TRecRoomObject> CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x42126C0", Offset = "0x42110C0", VA = "0x1842126C0", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4212770", Offset = "0x4211170", VA = "0x184212770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		protected RecRoomObjectPrefabEntryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class RecRoomStudioAnimatorSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public interface BHGLCFBDCEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SetBoolParameterFromScript(string CDHDOGOGPME, bool FJNMPOJLNAH);

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SetIntegerParameterFromScript(string CDHDOGOGPME, int FJNMPOJLNAH);

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetFloatParameterFromScript(string CDHDOGOGPME, float FJNMPOJLNAH);

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SetTriggerParameterFromScript(string CDHDOGOGPME);
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public BHGLCFBDCEN GABCMMNCDJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x790C90", Offset = "0x78F690", VA = "0x180790C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x67182D0", Offset = "0x6716CD0", VA = "0x1867182D0")]
		public Animator GetControlledAnimator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6718310", Offset = "0x6716D10", VA = "0x186718310")]
		public void SetBoolParameter(string CDHDOGOGPME, bool FJNMPOJLNAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67184A0", Offset = "0x6716EA0", VA = "0x1867184A0")]
		public void SetIntegerParameter(string CDHDOGOGPME, int FJNMPOJLNAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67183D0", Offset = "0x6716DD0", VA = "0x1867183D0")]
		public void SetFloatParameter(string CDHDOGOGPME, float FJNMPOJLNAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6718570", Offset = "0x6716F70", VA = "0x186718570")]
		public void SetTriggerParameter(string CDHDOGOGPME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomStudioAnimatorSynchronizerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class RecRoomStudioBillboardBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("If true, the object can turn left/right to face the player (y-axis rotation)")]
		[SerializeField]
		private bool isYawEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("If true, the object can look up/down to face the player (x-axis rotation)")]
		[SerializeField]
		private bool isPitchEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		[Tooltip("If true, the object can rotate clockwise/counter-clockwise to match the players rotation (z-axis rotation)")]
		private bool isRollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("If true, makes the player \"look through\" the object rather than \"look at\" the object to accomadate Unity UI expectations")]
		[SerializeField]
		private bool isInvertedForUI;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool LFILKNBNLNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x792750", Offset = "0x791150", VA = "0x180792750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FPNGDGJNBOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8AF870", Offset = "0x8AE270", VA = "0x1808AF870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8AF100", Offset = "0x8ADB00", VA = "0x1808AF100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KILHNDNLELL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x114F620", Offset = "0x114E020", VA = "0x18114F620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x1E6C710", Offset = "0x1E6B110", VA = "0x181E6C710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool HDPCNIJLICM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1B0BBD0", Offset = "0x1B0A5D0", VA = "0x181B0BBD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x32620A0", Offset = "0x3260AA0", VA = "0x1832620A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x211EFA0", Offset = "0x211D9A0", VA = "0x18211EFA0")]
		protected RecRoomStudioBillboardBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class RecRoomStudioCanvasInteractionBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		private bool isInteractable;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool IBEPPLIIBMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomStudioCanvasInteractionBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class RecRoomStudioDisableRenderInShareCamPhotoBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public enum DisableRenderOptions
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			NeverRender,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			OnlyDisableForJunior
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private DisableRenderOptions renderOptions;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool MPICAILADAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x11E8DE0", Offset = "0x11E77E0", VA = "0x1811E8DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomStudioDisableRenderInShareCamPhotoBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public abstract class RecRoomStudioHudCanvasBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomStudioHudCanvasBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public abstract class RecRoomStudioRecNetImageBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		[Tooltip("If true, the image will be automatically cropped into a square.")]
		private bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private DGCPHIDHFCI HMGLPMAIECO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public DGCPHIDHFCI CKNODCGHLEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x6718770", Offset = "0x6717170", VA = "0x186718770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool JNDCGDFPFOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NOOGBKNHIOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6718630", Offset = "0x6717030", VA = "0x186718630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x67186D0", Offset = "0x67170D0", VA = "0x1867186D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomStudioRecNetImageBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class RecRoomVisualPostProcessingBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		[ReadOnlyField]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static RecRoomVisualPostProcessingBase BDFKMGIHPBP;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static RecRoomVisualPostProcessingBase KHPIFBDMEAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x67189E0", Offset = "0x67173E0", VA = "0x1867189E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x67187B0", Offset = "0x67171B0", VA = "0x1867187B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x67188A0", Offset = "0x67172A0", VA = "0x1867188A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		protected RecRoomVisualPostProcessingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyEnabledFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6711250", Offset = "0x670FC50", VA = "0x186711250")]
		public ConditionallyEnabledFieldAttribute(string propertyName, bool propertyValue, string disabledTooltip)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public abstract class ALIDFEAKPCK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x670EF60", Offset = "0x670D960", VA = "0x18670EF60")]
	protected ALIDFEAKPCK(string JJCBBELMNJG, bool NHNDDCCGHAM)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyVisibleFieldAttribute : ALIDFEAKPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x67112B0", Offset = "0x670FCB0", VA = "0x1867112B0")]
		public ConditionallyVisibleFieldAttribute(string propertyName, bool propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class IntConditionallyVisibleFieldAttribute : ALIDFEAKPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6711830", Offset = "0x6710230", VA = "0x186711830")]
		public IntConditionallyVisibleFieldAttribute(string propertyName, int propertyValue, bool isReadOnly = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DGCPHIDHFCI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string HODIDIJCHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface OOGEKAENMJE<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AttachMarkupComponent(T NMMFOCHBBBN, int JDCGJNKIICE, bool IBMDHFMNGFB);
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[AttributeUsage(AttributeTargets.Field)]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79DB00", VA = "0x18079F100")]
		public ReadOnlyFieldAttribute()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[HideInInspector]
		[SerializeField]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Header("Basic Interactions")]
		[SerializeField]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		[ConditionallyEnabledField("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		[ConditionallyEnabledField("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[ConditionallyVisibleField("isBuiltInObject", false, false)]
		[Header("Physics")]
		[SerializeField]
		private RecRoomObjectPhysicsMode physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[ConditionallyVisibleField("isShapeContainer", true, false)]
		[SerializeField]
		private ShapeContainerPhysicsMode shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[HideInInspector]
		[SerializeField]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x97E930", Offset = "0x97D330", VA = "0x18097E930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6717EF0", Offset = "0x67168F0", VA = "0x186717EF0")]
		public RecRoomObjectConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum RecRoomObjectPhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		Physical = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum ShapeContainerPhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Physical = 4
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x284ACF0", Offset = "0x28496F0", VA = "0x18284ACF0")]
		public bool GFGJHMKHGPD<T>([Out] T BEEGCHJLJFC, [Out] string BNFACNGELAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x67180E0", Offset = "0x6716AE0", VA = "0x1867180E0")]
		public static string NAJFANPEPCO(Type FIGFLJOONIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6718070", Offset = "0x6716A70", VA = "0x186718070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6718000", Offset = "0x6716A00", VA = "0x186718000")]
		public MethodInfo FMBMEOLJHAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6717F10", Offset = "0x6716910", VA = "0x186717F10")]
		public string CAEIIHJPHED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x81C660", Offset = "0x81B060", VA = "0x18081C660")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct BDDAOOBMNGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public byte[] OEOJEJPDDPJ;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C00C0", VA = "0x1808C16C0")]
	public BDDAOOBMNGF(byte[] DNNAMOOCONL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct NDKKAMPBJNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public byte[] OEOJEJPDDPJ;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8C16C0", Offset = "0x8C00C0", VA = "0x1808C16C0")]
	public NDKKAMPBJNN(byte[] DNNAMOOCONL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class PIIDLKBFHHG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6715780", Offset = "0x6714180", VA = "0x186715780")]
	public static (BDDAOOBMNGF, NDKKAMPBJNN) POLDEPLDAKL(Stream MLLHHPADIME)
	{
		return default((BDDAOOBMNGF, NDKKAMPBJNN));
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x67155C0", Offset = "0x6713FC0", VA = "0x1867155C0")]
	public static void PHIFMKBLJLE(Stream MLLHHPADIME, BDDAOOBMNGF JIPHHKDPFBO, NDKKAMPBJNN OMPEBFIMNBO)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1E77650", Offset = "0x1E76050", VA = "0x181E77650")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6A50", Offset = "0x5FA5450", VA = "0x185FA6A50")]
		public SerializedGuid([In] Guid DMMBGEACBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6A20", Offset = "0x5FA5420", VA = "0x185FA6A20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6718AB0", Offset = "0x67174B0", VA = "0x186718AB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6770", Offset = "0x5FA5170", VA = "0x185FA6770", Slot = "7")]
		public bool Equals(SerializedGuid CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6718A20", Offset = "0x6717420", VA = "0x186718A20", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6840", Offset = "0x5FA5240", VA = "0x185FA6840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5FA6740", Offset = "0x5FA5140", VA = "0x185FA6740", Slot = "6")]
		public int CompareTo(SerializedGuid CGDFJMJIABO)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SerializedTypeNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		public SerializedTypeNameAttribute()
		{
		}
	}
}
namespace RecRoom.Core.Studio.StudioFunctions
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[Preserve]
	public abstract class Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public static readonly Argument Void;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Parameter Binding
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public Argument()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
		public Argument(string CDHDOGOGPME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x670F020", Offset = "0x670DA20", VA = "0x18670F020")]
		public object HMPKIECCEAP(object[] ACNMMHDGCHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x670EFB0", Offset = "0x670D9B0", VA = "0x18670EFB0")]
		internal void ADFJIGPEKPM(IReadOnlyList<Parameter> FLHMGGNKGKC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[Preserve]
	public abstract class Argument<T> : Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		protected T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3C248B0", Offset = "0x3C232B0", VA = "0x183C248B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3C243E0", Offset = "0x3C22DE0", VA = "0x183C243E0")]
		protected Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[Preserve]
	public sealed class VoidArgument : Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static readonly VoidArgument Instance;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x6719C80", Offset = "0x6718680", VA = "0x186719C80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6719C00", Offset = "0x6718600", VA = "0x186719C00")]
		private VoidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	public abstract class ValueArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x4441210", Offset = "0x443FC10", VA = "0x184441210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x32ADDB0", Offset = "0x32AC7B0", VA = "0x1832ADDB0")]
		protected ValueArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[Preserve]
	public abstract class ClassArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		protected string valueTypeAssemblyQualifiedName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x4D9D620", Offset = "0x4D9C020", VA = "0x184D9D620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4D9D370", Offset = "0x4D9BD70", VA = "0x184D9D370")]
		private Type MJMAOPIHLCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3226B70", Offset = "0x3225570", VA = "0x183226B70")]
		protected ClassArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[Preserve]
	public sealed class BoolArgument : ValueArgument<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x670F0F0", Offset = "0x670DAF0", VA = "0x18670F0F0")]
		public BoolArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	public sealed class ColorArgument : ValueArgument<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6710510", Offset = "0x670EF10", VA = "0x186710510")]
		public ColorArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[Preserve]
	public sealed class Color32Argument : ValueArgument<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6710490", Offset = "0x670EE90", VA = "0x186710490")]
		public Color32Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[Preserve]
	public sealed class GuidArgument : ValueArgument<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6711780", Offset = "0x6710180", VA = "0x186711780")]
		public GuidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	public sealed class FloatArgument : ValueArgument<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6711700", Offset = "0x6710100", VA = "0x186711700")]
		public FloatArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Preserve]
	public sealed class IntArgument : ValueArgument<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x67117F0", Offset = "0x67101F0", VA = "0x1867117F0")]
		public IntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[Preserve]
	public sealed class ShortArgument : ValueArgument<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6718B30", Offset = "0x6717530", VA = "0x186718B30")]
		public ShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[Preserve]
	public sealed class StringArgument : ValueArgument<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6718B70", Offset = "0x6717570", VA = "0x186718B70")]
		public StringArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[Preserve]
	public sealed class UIntArgument : ValueArgument<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6719760", Offset = "0x6718160", VA = "0x186719760")]
		public UIntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Preserve]
	public sealed class UShortArgument : ValueArgument<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x67197A0", Offset = "0x67181A0", VA = "0x1867197A0")]
		public UShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	public sealed class Vector2Argument : ValueArgument<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6719A20", Offset = "0x6718420", VA = "0x186719A20")]
		public Vector2Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[Preserve]
	public sealed class Vector3Argument : ValueArgument<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6719AA0", Offset = "0x67184A0", VA = "0x186719AA0")]
		public Vector3Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[Preserve]
	public sealed class QuaternionArgument : ValueArgument<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6715C80", Offset = "0x6714680", VA = "0x186715C80")]
		public QuaternionArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[Preserve]
	public sealed class UnityObjectArgument : ClassArgument<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x67198A0", Offset = "0x67182A0", VA = "0x1867198A0")]
		public UnityObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[Preserve]
	public sealed class RecNetImageArgument : ValueArgument<DGCPHIDHFCI>
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6715D00", Offset = "0x6714700", VA = "0x186715D00")]
		public RecNetImageArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[Preserve]
	public abstract class Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void EFFMPGPADHJ(string FFLFBDFPKHI, object[] ACNMMHDGCHB, object[] KPFMDOJAPHM);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected internal abstract void LJNGEIJAMAA(IReadOnlyList<Parameter> FLHMGGNKGKC, IReadOnlyList<Parameter> MPNPIBEFEKA);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		protected Instruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[Preserve]
	public sealed class PlaceholderInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "4")]
		public override void EFFMPGPADHJ(string FFLFBDFPKHI, object[] ACNMMHDGCHB, object[] KPFMDOJAPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		protected internal override void LJNGEIJAMAA(IReadOnlyList<Parameter> FLHMGGNKGKC, IReadOnlyList<Parameter> MPNPIBEFEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public PlaceholderInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[Preserve]
	public sealed class CallInstruction : Instruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeReference]
		private Argument[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeReference]
		private Argument result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private MethodInfo RUNTIME_ONLY_resolvedMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly MethodInfo InvalidMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static object[][] argumentValueArrays;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6710410", Offset = "0x670EE10", VA = "0x186710410")]
		public CallInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x670F2B0", Offset = "0x670DCB0", VA = "0x18670F2B0", Slot = "4")]
		public override void EFFMPGPADHJ(string FFLFBDFPKHI, object[] ACNMMHDGCHB, object[] KPFMDOJAPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x670FF80", Offset = "0x670E980", VA = "0x18670FF80")]
		private void MCGCKANAEMN(object[] KPFMDOJAPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x670F210", Offset = "0x670DC10", VA = "0x18670F210")]
		private void CMKNIIBLLBI(object[] KPFMDOJAPHM, object PPCPMPFAJEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x670FE50", Offset = "0x670E850", VA = "0x18670FE50", Slot = "5")]
		protected internal override void LJNGEIJAMAA(IReadOnlyList<Parameter> FLHMGGNKGKC, IReadOnlyList<Parameter> MPNPIBEFEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x670F1B0", Offset = "0x670DBB0", VA = "0x18670F1B0")]
		[Preserve]
		private static void BKIGDFAOEEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x670F750", Offset = "0x670E150", VA = "0x18670F750")]
		private MethodInfo GPOFMAFDABG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x670F960", Offset = "0x670E360", VA = "0x18670F960")]
		internal MethodInfo JPOFDKBDJAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6710030", Offset = "0x670EA30", VA = "0x186710030")]
		private static bool MFGHPHAKFPB(MethodInfo HGBIKNAGECF, Type[] CJIIBDIAFMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x670F790", Offset = "0x670E190", VA = "0x18670F790")]
		private static object[] IHJGMAINHIF(int GCGNKLBGDDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6710140", Offset = "0x670EB40", VA = "0x186710140")]
		private object[] NJEHMEGAOEP(object[] ACNMMHDGCHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x67102B0", Offset = "0x670ECB0", VA = "0x1867102B0")]
		private void OKEFEGOILEI(object[] MMBJKMPFECD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[Preserve]
	public sealed class ConditionalInstruction : Instruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private Condition[] conditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeReference]
		private Instruction[] @default;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x67111D0", Offset = "0x670FBD0", VA = "0x1867111D0")]
		public ConditionalInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6710B00", Offset = "0x670F500", VA = "0x186710B00", Slot = "4")]
		public override void EFFMPGPADHJ(string FFLFBDFPKHI, object[] ACNMMHDGCHB, object[] KPFMDOJAPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6710F30", Offset = "0x670F930", VA = "0x186710F30", Slot = "5")]
		protected internal override void LJNGEIJAMAA(IReadOnlyList<Parameter> FLHMGGNKGKC, IReadOnlyList<Parameter> MPNPIBEFEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6710A90", Offset = "0x670F490", VA = "0x186710A90")]
		private void ADFJIGPEKPM(IReadOnlyList<Parameter> FLHMGGNKGKC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[Preserve]
	public sealed class Condition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public IReadOnlyList<Instruction> Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x6710A40", Offset = "0x670F440", VA = "0x186710A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x67109C0", Offset = "0x670F3C0", VA = "0x1867109C0")]
		public Condition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6710590", Offset = "0x670EF90", VA = "0x186710590")]
		public static bool ABIAPBGIFPO(string BEEGCHJLJFC, [Out] bool MACMDOCFAJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x67108F0", Offset = "0x670F2F0", VA = "0x1867108F0")]
		public static bool PFKMOCOPPKF(string BEEGCHJLJFC, [Out] int EKENPHLLDNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6710740", Offset = "0x670F140", VA = "0x186710740")]
		public bool BHLAMNHKGML(bool IBFPMDMOOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6710660", Offset = "0x670F060", VA = "0x186710660")]
		public bool AKEJIFGCCCF(int MMFFINNCHEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x67108D0", Offset = "0x670F2D0", VA = "0x1867108D0")]
		public bool NGIGNNLLGAH(string FJOGAFFOKIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6710830", Offset = "0x670F230", VA = "0x186710830")]
		public void EFFMPGPADHJ(string FFLFBDFPKHI, object[] ACNMMHDGCHB, object[] KPFMDOJAPHM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[Preserve]
	public abstract class Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly string nameof_name;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x90C010", Offset = "0x90AA10", VA = "0x18090C010")]
		public Parameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6715AD0", Offset = "0x67144D0", VA = "0x186715AD0")]
		internal void KDBLFPCPBBJ(int BCJNBCPAIFI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Preserve]
	public sealed class PlaceholderParameter : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x6715C20", Offset = "0x6714620", VA = "0x186715C20", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Preserve]
	public abstract class Parameter<T> : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x40B1E10", Offset = "0x40B0810", VA = "0x1840B1E10")]
		protected Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Preserve]
	public abstract class ValueParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x44901E0", Offset = "0x448EBE0", VA = "0x1844901E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x32ADDB0", Offset = "0x32AC7B0", VA = "0x1832ADDB0")]
		protected ValueParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Preserve]
	public abstract class ClassParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		private string valueTypeFullName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x4D9D740", Offset = "0x4D9C140", VA = "0x184D9D740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4D9D680", Offset = "0x4D9C080", VA = "0x184D9D680")]
		private Type MJMAOPIHLCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3226B70", Offset = "0x3225570", VA = "0x183226B70")]
		protected ClassParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[Preserve]
	public sealed class BoolParameter : ValueParameter<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x670F130", Offset = "0x670DB30", VA = "0x18670F130")]
		public BoolParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[Preserve]
	public sealed class ColorParameter : ValueParameter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6710550", Offset = "0x670EF50", VA = "0x186710550")]
		public ColorParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[Preserve]
	public sealed class Color32Parameter : ValueParameter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x67104D0", Offset = "0x670EED0", VA = "0x1867104D0")]
		public Color32Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[Preserve]
	public sealed class FloatParameter : ValueParameter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6711740", Offset = "0x6710140", VA = "0x186711740")]
		public FloatParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[Preserve]
	public sealed class IntParameter : ValueParameter<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6711890", Offset = "0x6710290", VA = "0x186711890")]
		public IntParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[Preserve]
	public sealed class StringParameter : ValueParameter<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6718BB0", Offset = "0x67175B0", VA = "0x186718BB0")]
		public StringParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[Preserve]
	public sealed class Vector2Parameter : ValueParameter<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6719A60", Offset = "0x6718460", VA = "0x186719A60")]
		public Vector2Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[Preserve]
	public sealed class Vector3Parameter : ValueParameter<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6719AE0", Offset = "0x67184E0", VA = "0x186719AE0")]
		public Vector3Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[Preserve]
	public sealed class QuaternionParameter : ValueParameter<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6715CC0", Offset = "0x67146C0", VA = "0x186715CC0")]
		public QuaternionParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[Preserve]
	public sealed class RecNetImageParameter : ValueParameter<DGCPHIDHFCI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6715D40", Offset = "0x6714740", VA = "0x186715D40")]
		public RecNetImageParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[Preserve]
	public sealed class StudioFunction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeReference]
		private Parameter[] parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeReference]
		private Parameter[] results;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool RUNTIME_ONLY_didAssignParameterIndices;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6719620", Offset = "0x6718020", VA = "0x186719620")]
		public StudioFunction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6718F60", Offset = "0x6717960", VA = "0x186718F60")]
		public void EFFMPGPADHJ(object[] ACNMMHDGCHB, object[] KPFMDOJAPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6719320", Offset = "0x6717D20", VA = "0x186719320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6719160", Offset = "0x6717B60", VA = "0x186719160")]
		private void EPFMIMDCNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x67192A0", Offset = "0x6717CA0", VA = "0x1867192A0")]
		private void LJNGEIJAMAA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[Preserve]
	public class StudioFunctionList : IReadOnlyList<StudioFunction>, IEnumerable<StudioFunction>, IEnumerable, IReadOnlyCollection<StudioFunction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		[HideInInspector]
		private StudioFunction[] array;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private IReadOnlyList<StudioFunction> ReadOnlyList
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x6718F10", Offset = "0x6717910", VA = "0x186718F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x6718D40", Offset = "0x6717740", VA = "0x186718D40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public StudioFunction this[int BNALCEABILL]
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x6718E30", Offset = "0x6717830", VA = "0x186718E30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6718BF0", Offset = "0x67175F0", VA = "0x186718BF0", Slot = "6")]
		public IEnumerator<StudioFunction> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6718C70", Offset = "0x6717670", VA = "0x186718C70", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6718CF0", Offset = "0x67176F0", VA = "0x186718CF0")]
		public StudioFunctionList()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class DPELMDENLDG
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6711310", Offset = "0x670FD10", VA = "0x186711310")]
	public static string LJFLIDDDPHF(this Type AKDFFJNHJJN)
	{
		return null;
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
