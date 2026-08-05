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
public class KEOAHLEBDON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 ENADLNHEAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion CKFJFCLIANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 BKFKDLINIMA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6389370", Offset = "0x6388770", VA = "0x186389370")]
	public bool NJLGICCBDNE(Collider MHOODELGFIC, Bounds AKLEIOCDFMP, bool PLHNIOHIAMM, bool NGIJLGPMFCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6388D80", Offset = "0x6388180", VA = "0x186388D80")]
	public bool IOKMHEBDLNJ(Collider EEFMDFBJECO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6388DA0", Offset = "0x63881A0", VA = "0x186388DA0")]
	public bool KFKEKDDLLGO(Collider EEFMDFBJECO, bool PLHNIOHIAMM, bool NGIJLGPMFCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63898F0", Offset = "0x6388CF0", VA = "0x1863898F0")]
	public void NKHPAOCFBEJ(KEOAHLEBDON KEEHOGPOIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6388D00", Offset = "0x6388100", VA = "0x186388D00")]
	private static void DPCMCGGEHEP(Vector3 MAKCHOBJLOO, Vector3 NFJOIFHGCKE, Vector3 FJEACGMCDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6388940", Offset = "0x6387D40", VA = "0x186388940")]
	public static KEOAHLEBDON BFFMHHMBNCO(GameObject JMNDOLBKAMN, Quaternion CKFJFCLIANA, bool JCIGEEGCBLI, bool MEMLMOJOEJL, bool PLHNIOHIAMM = false, bool NGIJLGPMFCA = false, bool HDCHBFPGNDM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KEOAHLEBDON()
	{
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
public interface FJGDDPGIMKP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AudioMixerGroup MLPKJPNBKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FJGDDPGIMKP KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IReadOnlyList<FJGDDPGIMKP> JCAOBOKADOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string HGABLBNOPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CHPMNENMDAK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class KNLNKFLBANH : FJGDDPGIMKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly List<FJGDDPGIMKP> EBFBGGNNLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly KNLNKFLBANH GIKONIFCCBC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FJGDDPGIMKP KDDFGHHFEPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AudioMixerGroup MLPKJPNBKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IReadOnlyList<FJGDDPGIMKP> JCAOBOKADOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string HGABLBNOPEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x638A260", Offset = "0x6389660", VA = "0x18638A260")]
		internal KNLNKFLBANH(AudioMixerGroup DMBGGOLNLAM, KNLNKFLBANH DCLCDDGJKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FJGDDPGIMKP ILNJPFKKELC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AudioMixer MLMPFIFBCAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6386E60", Offset = "0x6386260", VA = "0x186386E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	private CHPMNENMDAK(KNLNKFLBANH KGMEBGDOGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6386C20", Offset = "0x6386020", VA = "0x186386C20")]
	public static CHPMNENMDAK LAGMEHMMKHG(AudioMixer IDGHCHHKEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6386880", Offset = "0x6385C80", VA = "0x186386880")]
	public FJGDDPGIMKP DNOABDJHNGP(string NCALKKOFLEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63865F0", Offset = "0x63859F0", VA = "0x1863865F0")]
	public FJGDDPGIMKP DNOABDJHNGP(AudioMixerGroup DMBGGOLNLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6386570", Offset = "0x6385970", VA = "0x186386570")]
	private static int DBPPLEIEGDB(string EOEPLCPMJAO, int CJJOHOENBLA)
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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD14DE0", Offset = "0xD141E0", VA = "0x180D14DE0")]
		public void MJNAFMDJJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x348DB40", Offset = "0x348CF40", VA = "0x18348DB40")]
		public MaterialMapAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MaterialMapBase<TMaterialMapAsset> : MonoBehaviour where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static MaterialMapBase<TMaterialMapAsset> CLFOAALEFAI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<MaterialEntry> AJIGEKDCHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[HideInInspector]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private TMaterialMapAsset entriesAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Dictionary<Material, MaterialEntry> KKDPOLJADHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private HashSet<Material> MMPDFALOCJP;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static MaterialMapBase<TMaterialMapAsset> OMCMBELJBID
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3BB7CC0", Offset = "0x3BB70C0", VA = "0x183BB7CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public MaterialEntry[] CCPKBGPPKAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3BB7C00", Offset = "0x3BB7000", VA = "0x183BB7C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7750", Offset = "0x3BB6B50", VA = "0x183BB7750")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7B10", Offset = "0x3BB6F10", VA = "0x183BB7B10")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BB79E0", Offset = "0x3BB6DE0", VA = "0x183BB79E0")]
		public MaterialEntry GetEntryForMaterial(Material ICCDCMPCLPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7990", Offset = "0x3BB6D90", VA = "0x183BB7990")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7600", Offset = "0x3BB6A00", VA = "0x183BB7600")]
		private void AOALJFELCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7A50", Offset = "0x3BB6E50", VA = "0x183BB7A50")]
		private void IKIBIHEMJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		protected MaterialMapBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class TextureProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Texture value;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FloatProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float value;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class VectorProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Vector4 value;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ColorProperty
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Color value;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MaterialEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public string shaderName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MaterialGlobalIlluminationFlags globalIlluminationFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int renderQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool doubleSidedGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TextureProperty[] texProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public FloatProperty[] floatProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public VectorProperty[] vecProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public ColorProperty[] colorProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, float> floatPropsDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Dictionary<int, float> floatPropIdDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<int, Texture> texPropIdDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Dictionary<int, Vector4> vecPropIdDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Dictionary<int, Color> colorPropIdDict;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x638A790", Offset = "0x6389B90", VA = "0x18638A790")]
		public void EGBBDNLDGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x638AC80", Offset = "0x638A080", VA = "0x18638AC80")]
		public float GGLAJIBCAKG(string DKFEAPHKBMP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x638ACF0", Offset = "0x638A0F0", VA = "0x18638ACF0")]
		public float GGLAJIBCAKG(int LNAKMGONIOO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x638AD60", Offset = "0x638A160", VA = "0x18638AD60")]
		public Texture MOGNAHOPIGI(int LNAKMGONIOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x638ADD0", Offset = "0x638A1D0", VA = "0x18638ADD0")]
		public Vector4 PKAHLBPNDHD(int LNAKMGONIOO)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x638A710", Offset = "0x6389B10", VA = "0x18638A710")]
		public Color EDBAEODPCJD(int LNAKMGONIOO)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset> : RecRoomStudioBuildAsset<TAudioClipRegistryAsset> where TAudioClipRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		internal RecRoomAudioClipEntry[] clips;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<RecRoomAudioClipEntry> Clips
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0C60", Offset = "0x3FF0060", VA = "0x183FF0C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x348DB40", Offset = "0x348CF40", VA = "0x18348DB40")]
		public RecRoomAudioClipRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class RecRoomAudioClipEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AudioClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu(null)]
	public abstract class RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> : MonoBehaviour where TAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> CLFOAALEFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private TAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> OMCMBELJBID
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3BB7CC0", Offset = "0x3BB70C0", VA = "0x183BB7CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TAudioClipRegistryAsset CCPKBGPPKAG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyList<RecRoomAudioClipEntry> KOBNCHBAEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0F70", Offset = "0x3FF0370", VA = "0x183FF0F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0CB0", Offset = "0x3FF00B0", VA = "0x183FF0CB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0DE0", Offset = "0x3FF01E0", VA = "0x183FF0DE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
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
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public enum AudioMixerGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Ambience,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			Sounds,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			Voice,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			Voice_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			Voice_HighPitch,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Voice_Radio,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Voice_Radio_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Voice_Radio_HighPitch
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly Dictionary<AudioMixerGroupType, string> AHKIIEFLOAD;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string BNJGKGJIAPK = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string PLOLDINHKCA = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string JJAOFOOKBHC = "Audio";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly string PHDMNEPMFME;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly string PMLENIMEHLD;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static RecRoomAudioMixerRegistryBase CLFOAALEFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[ReadOnlyField]
		[SerializeField]
		private MixerVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[IntConditionallyVisibleField("version", 0, false)]
		[SerializeField]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[IntConditionallyVisibleField("version", 0, false)]
		[SerializeField]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[IntConditionallyVisibleField("version", 1, false)]
		[SerializeField]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static RecRoomAudioMixerRegistryBase OMCMBELJBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x638D7E0", Offset = "0x638CBE0", VA = "0x18638D7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AudioMixer GNJPLNBJBPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JMGKFCEFHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x638D830", Offset = "0x638CC30", VA = "0x18638D830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public MixerVersion CIBDPGBBMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400")]
			get
			{
				return default(MixerVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x638D980", Offset = "0x638CD80", VA = "0x18638D980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x638CDF0", Offset = "0x638C1F0", VA = "0x18638CDF0")]
		public static string GetAudioGroupPath(AudioMixerGroupType KEJGFNGNMHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x638CF10", Offset = "0x638C310", VA = "0x18638CF10")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroupType KEJGFNGNMHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x638D330", Offset = "0x638C730", VA = "0x18638D330")]
		private static AudioMixerGroup NBBHLHICMBH(AudioMixer IDGHCHHKEKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x638C900", Offset = "0x638BD00", VA = "0x18638C900")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x638D3D0", Offset = "0x638C7D0", VA = "0x18638D3D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x638D0F0", Offset = "0x638C4F0", VA = "0x18638D0F0")]
		public bool IsValidOutputGroup(AudioMixerGroup OGDDOEJJENG, [Out] string NJAPBBBJJNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x638CA20", Offset = "0x638BE20", VA = "0x18638CA20")]
		private bool DHDGOHPPMEE(AudioMixerGroup OGDDOEJJENG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x638CB90", Offset = "0x638BF90", VA = "0x18638CB90")]
		private bool EANKBJHHJIH(AudioMixerGroup BEOPFLODBCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		protected RecRoomAudioMixerRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class RecRoomBuiltInObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[HideInInspector]
		[SerializeField]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[ReadOnlyField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnlyField]
		[SerializeField]
		private RecRoomBuiltInObjectCategory category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[ReadOnlyField]
		[SerializeField]
		private bool availableInMakerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[ReadOnlyField]
		private bool isCloneable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnlyField]
		[SerializeField]
		private bool isBetaItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[HideInInspector]
		[SerializeField]
		private bool availableToDevsOnly;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Guid INGPCEJEKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x638DAC0", Offset = "0x638CEC0", VA = "0x18638DAC0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x638DB30", Offset = "0x638CF30", VA = "0x18638DB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string NDGMEGMCDLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RecRoomBuiltInObjectCategory PEIHBJNOINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x76B420", Offset = "0x76A820", VA = "0x18076B420")]
			get
			{
				return default(RecRoomBuiltInObjectCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x76BB80", Offset = "0x76AF80", VA = "0x18076BB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool PIGHPOAFKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7E2C20", Offset = "0x7E2020", VA = "0x1807E2C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA5A2A0", Offset = "0xA596A0", VA = "0x180A5A2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool EJICCPHEJKF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9F3C40", Offset = "0x9F3040", VA = "0x1809F3C40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F7C0", Offset = "0xD0EBC0", VA = "0x180D0F7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool DDLCJANAEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x18379F0", Offset = "0x1836DF0", VA = "0x1818379F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x546AF90", Offset = "0x546A390", VA = "0x18546AF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool MBBEEHAMIKK
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x546AF80", Offset = "0x546A380", VA = "0x18546AF80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5612460", Offset = "0x5611860", VA = "0x185612460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool PONODIAKHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x638DAA0", Offset = "0x638CEA0", VA = "0x18638DAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool JIAHJFJOKEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x638DA50", Offset = "0x638CE50", VA = "0x18638DA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
		public byte[] GetSpawnableTemplateData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430")]
		public void SetSpawnableTemplateData(byte[] DOPFMEHBGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xD32630", Offset = "0xD31A30", VA = "0x180D32630")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		protected RecRoomBuiltInObjectBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class RecRoomBuiltInObjectDataBase<TRecRoomBuiltInObject> : ScriptableObject where TRecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private TRecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private Dictionary<Guid, TRecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Dictionary<Guid, TRecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3FF1130", Offset = "0x3FF0530", VA = "0x183FF1130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IReadOnlyDictionary<Guid, TRecRoomBuiltInObject> AllBuiltInObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3417160", Offset = "0x3416560", VA = "0x183417160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1040", Offset = "0x3FF0440", VA = "0x183FF1040")]
		public void HPPHMADNNNC(IEnumerable<TRecRoomBuiltInObject> BGOKDFOPMAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF10A0", Offset = "0x3FF04A0", VA = "0x183FF10A0")]
		public bool ICNJHDADGEL(Guid JFPFGPFDCKJ, [Out] TRecRoomBuiltInObject IHJPKHMMNAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x835CD0", Offset = "0x8350D0", VA = "0x180835CD0")]
		protected RecRoomBuiltInObjectDataBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum RecRoomBuiltInObjectCategory
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Prop,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Gadget
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class RecRoomObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ECJMOEDDCMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public bool value;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public ECJMOEDDCMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6388460", Offset = "0x6387860", VA = "0x186388460")]
			internal bool HNLGDKHMHHL(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class OGMOFBCOBEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float value;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public OGMOFBCOBEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x638C6A0", Offset = "0x638BAA0", VA = "0x18638C6A0")]
			internal bool HNLGDKHMHHL(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class BIGAAIGKDGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int value;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public BIGAAIGKDGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6386450", Offset = "0x6385850", VA = "0x186386450")]
			internal bool HNLGDKHMHHL(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GICBNMLEEBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public string value;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public GICBNMLEEBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1C2F4A0", Offset = "0x1C2E8A0", VA = "0x181C2F4A0")]
			internal bool HNLGDKHMHHL(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NDNFMBLEAEI : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private NamedUnityEventBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public RecRoomObjectBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private string eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public string <>3__eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private NamedUnityEventBase[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			NamedUnityEventBase IEnumerator<NamedUnityEventBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
			[DebuggerHidden]
			public NDNFMBLEAEI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x638B260", Offset = "0x638A660", VA = "0x18638B260", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x638B410", Offset = "0x638A810", VA = "0x18638B410", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x638B350", Offset = "0x638A750", VA = "0x18638B350", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x638B350", Offset = "0x638A750", VA = "0x18638B350", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[HideInInspector]
		[SerializeField]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[HideInInspector]
		[SerializeReference]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Dictionary<string, RecRoomObjectProperty> DOAIDHLIBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[HideInInspector]
		[SerializeField]
		private StudioFunctionList studioFunctions;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public RecRoomObjectProperty[] GLIHDJHBKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public NamedUnityEventBase[] AKEKDFOENMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public RecRoomObjectConfiguration GPEPGJEMABJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x638E880", Offset = "0x638DC80", VA = "0x18638E880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<StudioFunction> FADIBNNKBCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x638E910", Offset = "0x638DD10", VA = "0x18638E910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObjectBase, string> NININCBEFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x638E7D0", Offset = "0x638DBD0", VA = "0x18638E7D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x638E960", Offset = "0x638DD60", VA = "0x18638E960")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x638DE50", Offset = "0x638D250", VA = "0x18638DE50")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x638DF00", Offset = "0x638D300", VA = "0x18638DF00")]
		public bool TryGetProperty(string OKJGMJDJMMC, [Out] RecRoomObjectProperty OIBKEMMFJDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x638DEE0", Offset = "0x638D2E0", VA = "0x18638DEE0")]
		public void SendCircuitsEvent(string KMBLMHPABPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x638E0D0", Offset = "0x638D4D0", VA = "0x18638E0D0")]
		public bool TryRaiseUnityEvent(string KMBLMHPABPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2614820", Offset = "0x2613C20", VA = "0x182614820")]
		private bool NPLEFBGBMFG<T0, T1, TEvent>(string KMBLMHPABPD, T0 FDCIMAOIKHN, T1 NHFKCFLKDKP) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x638E690", Offset = "0x638DA90", VA = "0x18638E690")]
		public bool TryRaiseUnityEvent(string KMBLMHPABPD, bool LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x638E5B0", Offset = "0x638D9B0", VA = "0x18638E5B0")]
		public bool TryRaiseUnityEvent(string KMBLMHPABPD, float LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x638E400", Offset = "0x638D800", VA = "0x18638E400")]
		public bool TryRaiseUnityEvent(string KMBLMHPABPD, int LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x638E2B0", Offset = "0x638D6B0", VA = "0x18638E2B0")]
		public bool TryRaiseUnityEvent(string KMBLMHPABPD, string LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x638E4D0", Offset = "0x638D8D0", VA = "0x18638E4D0")]
		public bool TryRaiseUnityEvent(string KMBLMHPABPD, string FDCIMAOIKHN, bool NHFKCFLKDKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x638E760", Offset = "0x638DB60", VA = "0x18638E760")]
		public bool TryRaiseUnityEvent(string KMBLMHPABPD, string FDCIMAOIKHN, float NHFKCFLKDKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x638E390", Offset = "0x638D790", VA = "0x18638E390")]
		public bool TryRaiseUnityEvent(string KMBLMHPABPD, string FDCIMAOIKHN, int NHFKCFLKDKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x638E540", Offset = "0x638D940", VA = "0x18638E540")]
		public bool TryRaiseUnityEvent(string KMBLMHPABPD, string FDCIMAOIKHN, string NHFKCFLKDKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x638DBB0", Offset = "0x638CFB0", VA = "0x18638DBB0")]
		[IteratorStateMachine(typeof(NDNFMBLEAEI))]
		private IEnumerable<NamedUnityEventBase> DDKCOMAPANN(string KMBLMHPABPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x638DC50", Offset = "0x638D050", VA = "0x18638DC50")]
		private bool GFKIGFNHBDD(string KMBLMHPABPD, Func<NamedUnityEventBase, bool> ECIDLCONFEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		protected RecRoomObjectBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6390510", Offset = "0x638F910", VA = "0x186390510")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6390550", Offset = "0x638F950", VA = "0x186390550")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6390590", Offset = "0x638F990", VA = "0x186390590")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63906C0", Offset = "0x638FAC0", VA = "0x1863906C0")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6390680", Offset = "0x638FA80", VA = "0x186390680")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6390740", Offset = "0x638FB40", VA = "0x186390740")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6390700", Offset = "0x638FB00", VA = "0x186390700")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6390780", Offset = "0x638FB80", VA = "0x186390780")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "5")]
		public virtual bool TryInvokeEvent(bool LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "6")]
		public virtual bool TryInvokeEvent(float LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "7")]
		public virtual bool TryInvokeEvent(int LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "8")]
		public virtual bool TryInvokeEvent(string LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3C01E20", Offset = "0x3C01220", VA = "0x183C01E20")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityParameterlessEventBase : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x638BA90", Offset = "0x638AE90", VA = "0x18638BA90", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x638BB60", Offset = "0x638AF60", VA = "0x18638BB60")]
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
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x348DB40", Offset = "0x348CF40", VA = "0x18348DB40")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[SerializedTypeName]
	[Preserve]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x348DB40", Offset = "0x348CF40", VA = "0x18348DB40")]
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
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x638B460", Offset = "0x638A860", VA = "0x18638B460", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x638B4C0", Offset = "0x638A8C0", VA = "0x18638B4C0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x638B630", Offset = "0x638AA30", VA = "0x18638B630")]
		protected NamedUnityBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityFloatEventBase : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x638B670", Offset = "0x638AA70", VA = "0x18638B670", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x638B6D0", Offset = "0x638AAD0", VA = "0x18638B6D0", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x638B840", Offset = "0x638AC40", VA = "0x18638B840")]
		protected NamedUnityFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[SerializedTypeName]
	[Preserve]
	public abstract class NamedUnityIntEventBase : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x638B880", Offset = "0x638AC80", VA = "0x18638B880", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x638B8E0", Offset = "0x638ACE0", VA = "0x18638B8E0", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x638BA50", Offset = "0x638AE50", VA = "0x18638BA50")]
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
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x638BDE0", Offset = "0x638B1E0", VA = "0x18638BDE0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x638BE40", Offset = "0x638B240", VA = "0x18638BE40", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x638BFB0", Offset = "0x638B3B0", VA = "0x18638BFB0")]
		protected NamedUnityStringEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[SerializedTypeName]
	[Preserve]
	public abstract class NamedUnityStringBooleanEventBase : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x638BBA0", Offset = "0x638AFA0", VA = "0x18638BBA0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x638BC00", Offset = "0x638B000", VA = "0x18638BC00", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x638BDA0", Offset = "0x638B1A0", VA = "0x18638BDA0")]
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
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x638BFF0", Offset = "0x638B3F0", VA = "0x18638BFF0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x638C050", Offset = "0x638B450", VA = "0x18638C050", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x638C1F0", Offset = "0x638B5F0", VA = "0x18638C1F0")]
		protected NamedUnityStringFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[SerializedTypeName]
	[Preserve]
	public abstract class NamedUnityStringIntEventBase : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x638C230", Offset = "0x638B630", VA = "0x18638C230", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x638C290", Offset = "0x638B690", VA = "0x18638C290", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x638C430", Offset = "0x638B830", VA = "0x18638C430")]
		protected NamedUnityStringIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[SerializedTypeName]
	[Preserve]
	public abstract class NamedUnityStringStringEventBase : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static List<Type> inputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x638C470", Offset = "0x638B870", VA = "0x18638C470", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x638C4D0", Offset = "0x638B8D0", VA = "0x18638C4D0", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x638C660", Offset = "0x638BA60", VA = "0x18638C660")]
		protected NamedUnityStringStringEventBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> : RecRoomStudioBuildAsset<TPrefabRegistryAsset> where TPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public TPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x348DB40", Offset = "0x348CF40", VA = "0x18348DB40")]
		public RecRoomObjectPrefabRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> : MonoBehaviour where TPrefabAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject>, new() where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> CLFOAALEFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[HideInInspector]
		[SerializeField]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private TPrefabAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> OMCMBELJBID
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3BB7CC0", Offset = "0x3BB70C0", VA = "0x183BB7CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IReadOnlyList<TPrefabEntry> DNEJIKKJHPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x3FF1650", Offset = "0x3FF0A50", VA = "0x183FF1650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1390", Offset = "0x3FF0790", VA = "0x183FF1390")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3FF14C0", Offset = "0x3FF08C0", VA = "0x183FF14C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		protected RecRoomObjectPrefabRegistryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public abstract class RecRoomObjectPrefabEntryBase<TRecRoomObject> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public TRecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		protected RecRoomObjectPrefabEntryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class RecRoomStudioAnimatorSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public interface FLNODEKFNPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SetBoolParameterFromScript(string DKFEAPHKBMP, bool FLJKEGLJDCJ);

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SetIntegerParameterFromScript(string DKFEAPHKBMP, int FLJKEGLJDCJ);

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetFloatParameterFromScript(string DKFEAPHKBMP, float FLJKEGLJDCJ);

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SetTriggerParameterFromScript(string DKFEAPHKBMP);
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public FLNODEKFNPM BGIDGDOBJCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x638EDF0", Offset = "0x638E1F0", VA = "0x18638EDF0")]
		public Animator GetControlledAnimator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x638EE30", Offset = "0x638E230", VA = "0x18638EE30")]
		public void SetBoolParameter(string DKFEAPHKBMP, bool FLJKEGLJDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x638EFC0", Offset = "0x638E3C0", VA = "0x18638EFC0")]
		public void SetIntegerParameter(string DKFEAPHKBMP, int FLJKEGLJDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x638EEF0", Offset = "0x638E2F0", VA = "0x18638EEF0")]
		public void SetFloatParameter(string DKFEAPHKBMP, float FLJKEGLJDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x638F090", Offset = "0x638E490", VA = "0x18638F090")]
		public void SetTriggerParameter(string DKFEAPHKBMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		protected RecRoomStudioAnimatorSynchronizerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class RecRoomStudioBillboardBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		[Tooltip("If true, the object can turn left/right to face the player (y-axis rotation)")]
		private bool isYawEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		[Tooltip("If true, the object can look up/down to face the player (x-axis rotation)")]
		private bool isPitchEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		[Tooltip("If true, the object can rotate clockwise/counter-clockwise to match the players rotation (z-axis rotation)")]
		private bool isRollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("If true, makes the player \"look through\" the object rather than \"look at\" the object to accomadate Unity UI expectations")]
		[SerializeField]
		private bool isInvertedForUI;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool EGCCIKLDDLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x764440", Offset = "0x763840", VA = "0x180764440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AIGIAJMNJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8896F0", Offset = "0x888AF0", VA = "0x1808896F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x889700", Offset = "0x888B00", VA = "0x180889700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LKFIIMAEENP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x1F0C9D0", Offset = "0x1F0BDD0", VA = "0x181F0C9D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x106D690", Offset = "0x106CA90", VA = "0x18106D690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool PAENJIGNANH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x106CCE0", Offset = "0x106C0E0", VA = "0x18106CCE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x3AE89D0", Offset = "0x3AE7DD0", VA = "0x183AE89D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1F69600", Offset = "0x1F68A00", VA = "0x181F69600")]
		protected RecRoomStudioBillboardBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class RecRoomStudioCanvasInteractionBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		private bool isInteractable;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GOCAHGHPFBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		protected RecRoomStudioCanvasInteractionBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class RecRoomStudioChipMetadataBase : ScriptableObject, IEquatable<RecRoomStudioChipMetadataBase>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct IndividualChipMetadata : IEquatable<IndividualChipMetadata>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			[SerializeField]
			[HideInInspector]
			private SerializedGuid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			[SerializeField]
			public string ClassName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			[SerializeField]
			public string FriendlyName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			[SerializeField]
			public string Description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			[SerializeField]
			public List<string> Filters;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			[SerializeField]
			public bool IsBetaChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[SerializeField]
			public bool IsValidInRoom1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[SerializeField]
			public bool IsValidInRoom2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[SerializeField]
			public bool IsHiddenInPalette;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[SerializeField]
			public bool IsDevChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[SerializeField]
			public bool IsStudioChip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			[SerializeField]
			public bool IsTrollingRisk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[SerializeField]
			public bool IsRoleAssignmentRisk;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[SerializeField]
			public int DeprecationStage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[SerializeField]
			public List<PortDesc> InputPorts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[SerializeField]
			public List<PortDesc> OutputPorts;

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public Guid NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x63887F0", Offset = "0x6387BF0", VA = "0x1863887F0")]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6388560", Offset = "0x6387960", VA = "0x186388560", Slot = "4")]
			public bool Equals(IndividualChipMetadata KEEHOGPOIFD)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct PortDesc : IEquatable<PortDesc>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[SerializeField]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[SerializeField]
			public string Type;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x5A3B8C0", Offset = "0x5A3ACC0", VA = "0x185A3B8C0", Slot = "4")]
			public bool Equals(PortDesc KEEHOGPOIFD)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		public List<IndividualChipMetadata> MetadataList;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x638F150", Offset = "0x638E550", VA = "0x18638F150", Slot = "4")]
		public bool Equals(RecRoomStudioChipMetadataBase KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x638F3B0", Offset = "0x638E7B0", VA = "0x18638F3B0")]
		protected RecRoomStudioChipMetadataBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class RecRoomStudioHudCanvasBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		protected RecRoomStudioHudCanvasBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public abstract class RecRoomVisualPostProcessingBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		[ReadOnlyField]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static RecRoomVisualPostProcessingBase CLFOAALEFAI;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static RecRoomVisualPostProcessingBase OMCMBELJBID
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x638F670", Offset = "0x638EA70", VA = "0x18638F670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x638F440", Offset = "0x638E840", VA = "0x18638F440")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x638F530", Offset = "0x638E930", VA = "0x18638F530")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		protected RecRoomVisualPostProcessingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyEnabledFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x63883A0", Offset = "0x63877A0", VA = "0x1863883A0")]
		public ConditionallyEnabledFieldAttribute(string propertyName, bool propertyValue, string disabledTooltip)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class ACMILCPPGHA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x63862C0", Offset = "0x63856C0", VA = "0x1863862C0")]
	protected ACMILCPPGHA(string OKJGMJDJMMC, bool ACHJCHKHOEH)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyVisibleFieldAttribute : ACMILCPPGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6388400", Offset = "0x6387800", VA = "0x186388400")]
		public ConditionallyVisibleFieldAttribute(string propertyName, bool propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class IntConditionallyVisibleFieldAttribute : ACMILCPPGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x63888A0", Offset = "0x6387CA0", VA = "0x1863888A0")]
		public IntConditionallyVisibleFieldAttribute(string propertyName, int propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[AttributeUsage(AttributeTargets.Field)]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
		public ReadOnlyFieldAttribute()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[HideInInspector]
		[SerializeField]
		private bool isBuiltInObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		[Header("Basic Interactions")]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[ConditionallyEnabledField("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		[SerializeField]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		[ConditionallyEnabledField("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[Header("Physics")]
		[SerializeField]
		[ConditionallyVisibleField("isBuiltInObject", false, false)]
		private RecRoomObjectPhysicsMode physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[ConditionallyVisibleField("isShapeContainer", true, false)]
		[SerializeField]
		private ShapeContainerPhysicsMode shapePhysicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[HideInInspector]
		[SerializeField]
		private bool isShapeContainer;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IsBuiltInObject
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x889760", Offset = "0x888B60", VA = "0x180889760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x638EA10", Offset = "0x638DE10", VA = "0x18638EA10")]
		public RecRoomObjectConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum RecRoomObjectPhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		Physical = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum ShapeContainerPhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Physical = 4
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2615240", Offset = "0x2614640", VA = "0x182615240")]
		public bool ICNJHDADGEL<T>([Out] T LPCGJALKADL, [Out] string NJAPBBBJJNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x638EC00", Offset = "0x638E000", VA = "0x18638EC00")]
		public static string GJBCDBKMMNL(Type BFGAGBINHNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x638EB90", Offset = "0x638DF90", VA = "0x18638EB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x638EB20", Offset = "0x638DF20", VA = "0x18638EB20")]
		public MethodInfo LMDBNMJNCPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x638EA30", Offset = "0x638DE30", VA = "0x18638EA30")]
		public string DCCCHBCDJDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class RecRoomStudioBuildAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x835CD0", Offset = "0x8350D0", VA = "0x180835CD0")]
		public RecRoomStudioBuildAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DDELBBBAFKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public byte[] KDIIDOFFEKK;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	public DDELBBBAFKL(byte[] CJFCIOOMJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct DAMNNKJAKIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public byte[] KDIIDOFFEKK;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	public DAMNNKJAKIO(byte[] CJFCIOOMJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class NBNCMEAIKJF
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x638AE70", Offset = "0x638A270", VA = "0x18638AE70")]
	public static (DDELBBBAFKL, DAMNNKJAKIO) AMNEBBJPOOO(Stream BKMMHPCMIEO)
	{
		return default((DDELBBBAFKL, DAMNNKJAKIO));
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x638B0A0", Offset = "0x638A4A0", VA = "0x18638B0A0")]
	public static void NOLKEOAKNBI(Stream BKMMHPCMIEO, DDELBBBAFKL NDJHINJFLAD, DAMNNKJAKIO DHAFNCNBMBA)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1EF9EB0", Offset = "0x1EF92B0", VA = "0x181EF9EB0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9020", Offset = "0x5CA8420", VA = "0x185CA9020")]
		public SerializedGuid([In] Guid HILDEDLDEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8FF0", Offset = "0x5CA83F0", VA = "0x185CA8FF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x638F740", Offset = "0x638EB40", VA = "0x18638F740", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8DC0", Offset = "0x5CA81C0", VA = "0x185CA8DC0", Slot = "7")]
		public bool Equals(SerializedGuid KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x638F6B0", Offset = "0x638EAB0", VA = "0x18638F6B0", Slot = "0")]
		public override bool Equals(object IBBNLILJNEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8E90", Offset = "0x5CA8290", VA = "0x185CA8E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8D10", Offset = "0x5CA8110", VA = "0x185CA8D10", Slot = "6")]
		public int CompareTo(SerializedGuid KEEHOGPOIFD)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SerializedTypeNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public SerializedTypeNameAttribute()
		{
		}
	}
}
namespace RecRoom.Core.Studio.StudioFunctions
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[Preserve]
	public abstract class Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static readonly Argument Void;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Parameter Binding
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public Argument()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
		public Argument(string DKFEAPHKBMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6386380", Offset = "0x6385780", VA = "0x186386380")]
		public object FIDKODMNJHA(object[] MALPOOLMMMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6386310", Offset = "0x6385710", VA = "0x186386310")]
		internal void DCLLDJMDLPC(IReadOnlyList<Parameter> OJJNHGGGKOD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[Preserve]
	public abstract class Argument<T> : Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		protected T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3949770", Offset = "0x3948B70", VA = "0x183949770", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x39492A0", Offset = "0x39486A0", VA = "0x1839492A0")]
		protected Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[Preserve]
	public sealed class VoidArgument : Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static readonly VoidArgument Instance;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6390A20", Offset = "0x638FE20", VA = "0x186390A20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x63909A0", Offset = "0x638FDA0", VA = "0x1863909A0")]
		private VoidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[Preserve]
	public abstract class ValueArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x420E0A0", Offset = "0x420D4A0", VA = "0x18420E0A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x308FF90", Offset = "0x308F390", VA = "0x18308FF90")]
		protected ValueArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	public abstract class ClassArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		protected string valueTypeAssemblyQualifiedName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x4B3AAC0", Offset = "0x4B39EC0", VA = "0x184B3AAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A810", Offset = "0x4B39C10", VA = "0x184B3A810")]
		private Type PKELFLLEOFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x300F8F0", Offset = "0x300ECF0", VA = "0x18300F8F0")]
		protected ClassArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[Preserve]
	public sealed class BoolArgument : ValueArgument<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		internal static readonly string _nameof_defaultValue;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x63864F0", Offset = "0x63858F0", VA = "0x1863864F0")]
		public BoolArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[Preserve]
	public sealed class ColorArgument : ValueArgument<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6388320", Offset = "0x6387720", VA = "0x186388320")]
		public ColorArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	public sealed class Color32Argument : ValueArgument<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x63882A0", Offset = "0x63876A0", VA = "0x1863882A0")]
		public Color32Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[Preserve]
	public sealed class GuidArgument : ValueArgument<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6388520", Offset = "0x6387920", VA = "0x186388520")]
		public GuidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[Preserve]
	public sealed class FloatArgument : ValueArgument<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x63884A0", Offset = "0x63878A0", VA = "0x1863884A0")]
		public FloatArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	public sealed class IntArgument : ValueArgument<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6388860", Offset = "0x6387C60", VA = "0x186388860")]
		public IntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Preserve]
	public sealed class ShortArgument : ValueArgument<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x638F7C0", Offset = "0x638EBC0", VA = "0x18638F7C0")]
		public ShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[Preserve]
	public sealed class StringArgument : ValueArgument<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x638F800", Offset = "0x638EC00", VA = "0x18638F800")]
		public StringArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[Preserve]
	public sealed class UIntArgument : ValueArgument<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6390490", Offset = "0x638F890", VA = "0x186390490")]
		public UIntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[Preserve]
	public sealed class UShortArgument : ValueArgument<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x63904D0", Offset = "0x638F8D0", VA = "0x1863904D0")]
		public UShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Preserve]
	public sealed class Vector2Argument : ValueArgument<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x63907C0", Offset = "0x638FBC0", VA = "0x1863907C0")]
		public Vector2Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	public sealed class Vector3Argument : ValueArgument<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6390840", Offset = "0x638FC40", VA = "0x186390840")]
		public Vector3Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[Preserve]
	public sealed class QuaternionArgument : ValueArgument<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x638C880", Offset = "0x638BC80", VA = "0x18638C880")]
		public QuaternionArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[Preserve]
	public sealed class UnityObjectArgument : ClassArgument<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static readonly string nameof_valueTypeAssemblyQualifiedName;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6390640", Offset = "0x638FA40", VA = "0x186390640")]
		public UnityObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[Preserve]
	public abstract class Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void DFPIJIPLDKJ(string HJMMCMMGGOC, int OGOGKJMLPCG, object[] MALPOOLMMMA, object[] PLPGABICLLE);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected internal abstract void JOBBOMAIOMH(IReadOnlyList<Parameter> OJJNHGGGKOD, IReadOnlyList<Parameter> NHJNPIKLGEK);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		protected Instruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[Preserve]
	public sealed class PlaceholderInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
		public override void DFPIJIPLDKJ(string HJMMCMMGGOC, int OGOGKJMLPCG, object[] MALPOOLMMMA, object[] PLPGABICLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		protected internal override void JOBBOMAIOMH(IReadOnlyList<Parameter> OJJNHGGGKOD, IReadOnlyList<Parameter> NHJNPIKLGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public PlaceholderInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[Preserve]
	public sealed class CallInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static readonly string nameof_target;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static readonly string nameof_name;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static readonly string nameof_arguments;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static readonly string nameof_result;

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
		private static readonly MethodInfo InvalidMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private static object[][] argumentValueArrays;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6387470", Offset = "0x6386870", VA = "0x186387470", Slot = "4")]
		public override void DFPIJIPLDKJ(string HJMMCMMGGOC, int OGOGKJMLPCG, object[] MALPOOLMMMA, object[] PLPGABICLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6387BC0", Offset = "0x6386FC0", VA = "0x186387BC0")]
		private void IECNFBBDKFH(object[] PLPGABICLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x63879B0", Offset = "0x6386DB0", VA = "0x1863879B0")]
		private void EAFCMNGBEHD(object[] PLPGABICLLE, object HMPPEDOLJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6387CD0", Offset = "0x63870D0", VA = "0x186387CD0", Slot = "5")]
		protected internal override void JOBBOMAIOMH(IReadOnlyList<Parameter> OJJNHGGGKOD, IReadOnlyList<Parameter> NHJNPIKLGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6387C70", Offset = "0x6387070", VA = "0x186387C70")]
		[Preserve]
		private static void IPCHIBNADHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6387E00", Offset = "0x6387200", VA = "0x186387E00")]
		private MethodInfo NKNOHHCMCMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6386EC0", Offset = "0x63862C0", VA = "0x186386EC0")]
		internal MethodInfo BJKIMGJKGKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6387A50", Offset = "0x6386E50", VA = "0x186387A50")]
		private static bool GBJPNFJKKDE(MethodInfo DIPOPGLLDPF, Type[] GIGFBPCJJKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6387E40", Offset = "0x6387240", VA = "0x186387E40")]
		private static object[] PBLEONBAGED(int JCFEJHAKBPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6387300", Offset = "0x6386700", VA = "0x186387300")]
		private object[] CJHGFOAEEDK(object[] MALPOOLMMMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6387B60", Offset = "0x6386F60", VA = "0x186387B60")]
		private void IAOJLDJGPNH(object[] MFFCELAIHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6388220", Offset = "0x6387620", VA = "0x186388220")]
		public CallInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[Preserve]
	public abstract class Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static readonly string nameof_name;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x762180", Offset = "0x761580", VA = "0x180762180")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x82B0D0", Offset = "0x82A4D0", VA = "0x18082B0D0")]
		public Parameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x638C6D0", Offset = "0x638BAD0", VA = "0x18638C6D0")]
		internal void HLBBMMHNDJG(int JBIJDBCCPEK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[Preserve]
	public sealed class PlaceholderParameter : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x638C820", Offset = "0x638BC20", VA = "0x18638C820", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[Preserve]
	public abstract class Parameter<T> : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A980", Offset = "0x3E99D80", VA = "0x183E9A980")]
		protected Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[Preserve]
	public abstract class ValueParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x4268530", Offset = "0x4267930", VA = "0x184268530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x308FF90", Offset = "0x308F390", VA = "0x18308FF90")]
		protected ValueParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[Preserve]
	public abstract class ClassParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private string valueTypeFullName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x4B3ABE0", Offset = "0x4B39FE0", VA = "0x184B3ABE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4B3AB20", Offset = "0x4B39F20", VA = "0x184B3AB20")]
		private Type PKELFLLEOFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x300F8F0", Offset = "0x300ECF0", VA = "0x18300F8F0")]
		protected ClassParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Preserve]
	public sealed class BoolParameter : ValueParameter<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6386530", Offset = "0x6385930", VA = "0x186386530")]
		public BoolParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Preserve]
	public sealed class ColorParameter : ValueParameter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6388360", Offset = "0x6387760", VA = "0x186388360")]
		public ColorParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Preserve]
	public sealed class Color32Parameter : ValueParameter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x63882E0", Offset = "0x63876E0", VA = "0x1863882E0")]
		public Color32Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Preserve]
	public sealed class FloatParameter : ValueParameter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x63884E0", Offset = "0x63878E0", VA = "0x1863884E0")]
		public FloatParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[Preserve]
	public sealed class IntParameter : ValueParameter<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6388900", Offset = "0x6387D00", VA = "0x186388900")]
		public IntParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[Preserve]
	public sealed class StringParameter : ValueParameter<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x638F840", Offset = "0x638EC40", VA = "0x18638F840")]
		public StringParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[Preserve]
	public sealed class Vector2Parameter : ValueParameter<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6390800", Offset = "0x638FC00", VA = "0x186390800")]
		public Vector2Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[Preserve]
	public sealed class Vector3Parameter : ValueParameter<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6390880", Offset = "0x638FC80", VA = "0x186390880")]
		public Vector3Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[Preserve]
	public sealed class QuaternionParameter : ValueParameter<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x638C8C0", Offset = "0x638BCC0", VA = "0x18638C8C0")]
		public QuaternionParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[Preserve]
	public sealed class StudioFunction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeReference]
		private Parameter[] parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeReference]
		private Parameter[] results;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private bool RUNTIME_ONLY_didAssignParameterIndices;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x638FBA0", Offset = "0x638EFA0", VA = "0x18638FBA0")]
		public void DFPIJIPLDKJ(object[] MALPOOLMMMA, object[] PLPGABICLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x638FF60", Offset = "0x638F360", VA = "0x18638FF60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x638FDA0", Offset = "0x638F1A0", VA = "0x18638FDA0")]
		private void ELKMEKAKENK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x638FEE0", Offset = "0x638F2E0", VA = "0x18638FEE0")]
		private void JOBBOMAIOMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6390260", Offset = "0x638F660", VA = "0x186390260")]
		public StudioFunction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[Preserve]
	public struct StudioFunctionList : IReadOnlyList<StudioFunction>, IEnumerable<StudioFunction>, IEnumerable, IReadOnlyCollection<StudioFunction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		[HideInInspector]
		private StudioFunction[] array;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private IReadOnlyList<StudioFunction> ReadOnlyList
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x638FB50", Offset = "0x638EF50", VA = "0x18638FB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x638F980", Offset = "0x638ED80", VA = "0x18638F980", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public StudioFunction this[int JPEMHHILGGG]
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x638FA70", Offset = "0x638EE70", VA = "0x18638FA70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x638F880", Offset = "0x638EC80", VA = "0x18638F880", Slot = "6")]
		public IEnumerator<StudioFunction> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x638F900", Offset = "0x638ED00", VA = "0x18638F900", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class MFKKDBAOKBE
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x638A380", Offset = "0x6389780", VA = "0x18638A380")]
	public static string FLFCEEIOPCJ(this Type DJMKKNDNCBM)
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
