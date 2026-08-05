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
	public class LogRegistrationIndex : DLJCNHBICIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x725B110", Offset = "0x725A510", VA = "0x18725B110", Slot = "4")]
		public override void NLGJOIAOEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct KKAOFEFILPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 GCHKCHLHOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion MGJIDJKDGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 MMCIGIDHMBK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x725AB40", Offset = "0x7259F40", VA = "0x18725AB40")]
	public bool OCFDEMLFLKM(Collider PIBBHKFDPAH, Bounds EOHHKBPCFGC, bool GONLDNMCDAJ, bool PDONMFHDFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72596F0", Offset = "0x7258AF0", VA = "0x1872596F0")]
	public bool BLLDICDKHPE(Collider HHIGDOHOLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7259B80", Offset = "0x7258F80", VA = "0x187259B80")]
	public bool IFBCDLMFABK(Collider HHIGDOHOLEF, bool GONLDNMCDAJ, bool PDONMFHDFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x725AA90", Offset = "0x7259E90", VA = "0x18725AA90")]
	public void NCJBHACNCKN(Transform JILAKCNFFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x725A150", Offset = "0x7259550", VA = "0x18725A150")]
	public void KPFIDAJCDKK(KKAOFEFILPO IEDCHGMDIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7259B00", Offset = "0x7258F00", VA = "0x187259B00")]
	private static void GMGFLHFJAAE(Vector3 DNLNJGFKFHE, Vector3 JDOCBGNCGMI, Vector3 DHLCOAONPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7259710", Offset = "0x7258B10", VA = "0x187259710")]
	public static KKAOFEFILPO BMMEHHJGFGB(GameObject MILPLABKJCF, Quaternion MGJIDJKDGAB, bool BJPFICHJEKG, bool ANPFJKIMGHJ, bool GONLDNMCDAJ = false, bool PDONMFHDFGP = false, bool GPAJCNBJIED = false)
	{
		return default(KKAOFEFILPO);
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
		[Obsolete("SwitchLZMA should not be used.  Use Switch instead", true)]
		SwitchLZMA,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Switch
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MPGPEBLNFMF
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[Obsolete]
	InitialRelease_Unity_2019_4_26f1,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Obsolete]
	Unity_2020_3_33f1,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Obsolete]
	Unity_2021_3_19f1,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Unity_2021_3_29f1,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Unity_2021_3_29f1_AvatarItemMaterialBundle
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CCKCIPLKAIE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string OBHJNHJBCGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7256BB0", Offset = "0x7255FB0", VA = "0x187256BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string DGFPNCOIGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7256BE0", Offset = "0x7255FE0", VA = "0x187256BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string DDDIEIKEKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7256C10", Offset = "0x7256010", VA = "0x187256C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7256C40", Offset = "0x7256040", VA = "0x187256C40")]
	public static MPGPEBLNFMF PPLGPIFDHPG(this MPGPEBLNFMF NEMIBGHBJIL)
	{
		return default(MPGPEBLNFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7256C40", Offset = "0x7256040", VA = "0x187256C40")]
	public static int PPLGPIFDHPG(int NEMIBGHBJIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LNLFHMDIBPI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	AudioMixerGroup HFMNNBJGBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LNLFHMDIBPI EOCBFDAOCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IReadOnlyList<LNLFHMDIBPI> BKLBHPKCBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string DAOABCCHOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AHNOIPMLAKA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class HAJCMDONPLK : LNLFHMDIBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal readonly List<LNLFHMDIBPI> CCMALMCJIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal readonly HAJCMDONPLK PACPNLBOCLM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LNLFHMDIBPI EOCBFDAOCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AudioMixerGroup HFMNNBJGBAB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<LNLFHMDIBPI> BKLBHPKCBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string DAOABCCHOML
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72592C0", Offset = "0x72586C0", VA = "0x1872592C0")]
		internal HAJCMDONPLK(AudioMixerGroup BNALJMOIAEM, HAJCMDONPLK KOBAADDGPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LNLFHMDIBPI PGLMKHNCFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AudioMixer LLPHFKHAKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7256330", Offset = "0x7255730", VA = "0x187256330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	private AHNOIPMLAKA(HAJCMDONPLK LDCKLNEALNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7256070", Offset = "0x7255470", VA = "0x187256070")]
	public static AHNOIPMLAKA AEJMGKEHCLP(AudioMixer ECLAEOJDDOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7256390", Offset = "0x7255790", VA = "0x187256390")]
	public LNLFHMDIBPI PEMJIKPANBL(string IONKPFDPHOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7256730", Offset = "0x7255B30", VA = "0x187256730")]
	public LNLFHMDIBPI PEMJIKPANBL(AudioMixerGroup BNALJMOIAEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72562B0", Offset = "0x72556B0", VA = "0x1872562B0")]
	private static int MNEENLPDGBB(string EMHGIKAPEJF, int DEABOIPAFEI)
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
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MaterialEntry[] Entries
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasBeenTranslated
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x854200", Offset = "0x853600", VA = "0x180854200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x853FA0", Offset = "0x8533A0", VA = "0x180853FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x44B3A50", Offset = "0x44B2E50", VA = "0x1844B3A50")]
		public MaterialEntry HAGHBCKDMLO(Material JOFMGPCHADM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x44B3A20", Offset = "0x44B2E20", VA = "0x1844B3A20")]
		public void ADPCGCLDHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38EF990", Offset = "0x38EED90", VA = "0x1838EF990")]
		public MaterialMapAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class MaterialMapBase<TMaterialMapAsset> : RecRoomUnitySceneSystemBase where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static MaterialMapBase<TMaterialMapAsset> GHLPOEBBIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[HideInInspector]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private TMaterialMapAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static MaterialMapBase<TMaterialMapAsset> CLHFPJDPLGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x44B4020", Offset = "0x44B3420", VA = "0x1844B4020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MaterialEntry[] IFHLOEOIHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x44B3F40", Offset = "0x44B3340", VA = "0x1844B3F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x44B3B40", Offset = "0x44B2F40", VA = "0x1844B3B40")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x44B3E50", Offset = "0x44B3250", VA = "0x1844B3E50")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x44B3D60", Offset = "0x44B3160", VA = "0x1844B3D60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x44B3D10", Offset = "0x44B3110", VA = "0x1844B3D10")]
		public void ClearSceneMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x868090", Offset = "0x867490", VA = "0x180868090")]
		protected MaterialMapBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class TextureProperty : IEquatable<TextureProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Texture value;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7261DB0", Offset = "0x72611B0", VA = "0x187261DB0", Slot = "4")]
		public bool Equals(TextureProperty IEDCHGMDIML)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class FloatProperty : IEquatable<FloatProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7259220", Offset = "0x7258620", VA = "0x187259220", Slot = "4")]
		public bool Equals(FloatProperty IEDCHGMDIML)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VectorProperty : IEquatable<VectorProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Vector4 value;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7262300", Offset = "0x7261700", VA = "0x187262300", Slot = "4")]
		public bool Equals(VectorProperty IEDCHGMDIML)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ColorProperty : IEquatable<ColorProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Color value;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7258220", Offset = "0x7257620", VA = "0x187258220", Slot = "4")]
		public bool Equals(ColorProperty IEDCHGMDIML)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MaterialEntry : IEquatable<MaterialEntry>
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

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x725B8C0", Offset = "0x725ACC0", VA = "0x18725B8C0")]
		public void PIGDONJPKNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x725B6F0", Offset = "0x725AAF0", VA = "0x18725B6F0")]
		public float LAENCKPHAPC(int MKMLIBNPMMN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x725B870", Offset = "0x725AC70", VA = "0x18725B870")]
		public Texture OHHHGIMDGHL(int MKMLIBNPMMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x725B740", Offset = "0x725AB40", VA = "0x18725B740")]
		public Vector4 LLPHJDOBFLA(int MKMLIBNPMMN)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x725B7F0", Offset = "0x725ABF0", VA = "0x18725B7F0")]
		public Color NNDHMAIIFLA(int MKMLIBNPMMN)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x725B590", Offset = "0x725A990", VA = "0x18725B590", Slot = "4")]
		public bool Equals(MaterialEntry IEDCHGMDIML)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset> : RecRoomStudioAutoCreatedAsset<TAudioClipRegistryAsset> where TAudioClipRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		internal RecRoomAudioClipEntry[] clips;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<RecRoomAudioClipEntry> Clips
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x496B470", Offset = "0x496A870", VA = "0x18496B470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D19900", Offset = "0x3D18D00", VA = "0x183D19900")]
		public RecRoomAudioClipRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RecRoomAudioClipEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AudioClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AddComponentMenu(null)]
	public abstract class RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> : RecRoomUnitySceneSystemBase where TAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> GHLPOEBBIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[ReadOnlyField]
		[SerializeField]
		private TAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> CLHFPJDPLGI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x44B4020", Offset = "0x44B3420", VA = "0x1844B4020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public TAudioClipRegistryAsset IFHLOEOIHEF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IReadOnlyList<RecRoomAudioClipEntry> JNFGNLMODBO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x496B770", Offset = "0x496AB70", VA = "0x18496B770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x496B4C0", Offset = "0x496A8C0", VA = "0x18496B4C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x496B5F0", Offset = "0x496A9F0", VA = "0x18496B5F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x868090", Offset = "0x867490", VA = "0x180868090")]
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
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum AudioMixerGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Ambience,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Sounds,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Voice,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			Voice_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Voice_HighPitch,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			Voice_Radio,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Voice_Radio_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			Voice_Radio_HighPitch
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static readonly Dictionary<AudioMixerGroupType, string> CHAADABNPKL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string AKJGBONBMME = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string DICNAOEFHIH = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const string LIGFAKGBLKC = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly string BCMDCCCJALJ;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string DPMHDNDHFBI;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static RecRoomAudioMixerRegistryBase GHLPOEBBIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[ReadOnlyField]
		private MixerVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 1, false)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static RecRoomAudioMixerRegistryBase CLHFPJDPLGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x725E420", Offset = "0x725D820", VA = "0x18725E420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AudioMixer CFOOOCHGMMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ADBLGJPBPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x725E470", Offset = "0x725D870", VA = "0x18725E470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public MixerVersion JAGCLOHPBDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0")]
			get
			{
				return default(MixerVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x725E5C0", Offset = "0x725D9C0", VA = "0x18725E5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x725D7D0", Offset = "0x725CBD0", VA = "0x18725D7D0")]
		public static string GetAudioGroupPath(AudioMixerGroupType HFKEAKKJNNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x725D8F0", Offset = "0x725CCF0", VA = "0x18725D8F0")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroupType HFKEAKKJNNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x725DF70", Offset = "0x725D370", VA = "0x18725DF70")]
		private static AudioMixerGroup NKBGFAJPMAJ(AudioMixer ECLAEOJDDOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x725D540", Offset = "0x725C940", VA = "0x18725D540")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x725E010", Offset = "0x725D410", VA = "0x18725E010")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x725DAD0", Offset = "0x725CED0", VA = "0x18725DAD0")]
		public bool IsValidOutputGroup(AudioMixerGroup DLJGNKFGDKL, [Out] string ODIFAFDGMDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x725D660", Offset = "0x725CA60", VA = "0x18725D660")]
		private bool FJOEGFFOAFB(AudioMixerGroup DLJGNKFGDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x725DD10", Offset = "0x725D110", VA = "0x18725DD10")]
		private bool KOMCFPHCPNI(AudioMixerGroup NCBHCAKCNBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		protected RecRoomAudioMixerRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class RecRoomBuiltInObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		[SerializeField]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[HideInInspector]
		[SerializeField]
		private Transform deformationTransform;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Guid NHDJCJHNKIL
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x725E700", Offset = "0x725DB00", VA = "0x18725E700")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x725E770", Offset = "0x725DB70", VA = "0x18725E770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IHMFLDBOBPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x725E6E0", Offset = "0x725DAE0", VA = "0x18725E6E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool JOLOKCJLIKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x725E690", Offset = "0x725DA90", VA = "0x18725E690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Transform JEBGDODDHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x852800", Offset = "0x851C00", VA = "0x180852800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		public byte[] GetSpawnableTemplateData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
		public void SetSpawnableTemplateData(byte[] GKDOGDOFDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x878F80", Offset = "0x878380", VA = "0x180878F80")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		protected RecRoomBuiltInObjectBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class RecRoomBuiltInObjectDataBase<TRecRoomBuiltInObject> : ScriptableObject where TRecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private TRecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Dictionary<Guid, TRecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Dictionary<Guid, TRecRoomBuiltInObject> Lookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x496B990", Offset = "0x496AD90", VA = "0x18496B990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IReadOnlyDictionary<Guid, TRecRoomBuiltInObject> AllBuiltInObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B560", Offset = "0x3C8A960", VA = "0x183C8B560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x496B860", Offset = "0x496AC60", VA = "0x18496B860")]
		public void CBBBAFPFDOK(IEnumerable<TRecRoomBuiltInObject> FOKOINHOFOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x496B8D0", Offset = "0x496ACD0", VA = "0x18496B8D0")]
		public bool LPPDNPILAFJ(Guid GNIICFDBCOK, [Out] TRecRoomBuiltInObject DLNKFKCOJLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x931280", Offset = "0x930680", VA = "0x180931280")]
		protected RecRoomBuiltInObjectDataBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class RecRoomObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class NAKIGGBIDID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public bool value;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public NAKIGGBIDID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x725BC50", Offset = "0x725B050", VA = "0x18725BC50")]
			internal bool CHAMMOIOOEB(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class HHEKMNEBECD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float value;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public HHEKMNEBECD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x72593E0", Offset = "0x72587E0", VA = "0x1872593E0")]
			internal bool CHAMMOIOOEB(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class AMNCPNCOMBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public int value;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public AMNCPNCOMBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x72569C0", Offset = "0x7255DC0", VA = "0x1872569C0")]
			internal bool CHAMMOIOOEB(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class OHFAOFNLGPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public string value;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public OHFAOFNLGPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x725CED0", Offset = "0x725C2D0", VA = "0x18725CED0")]
			internal bool CHAMMOIOOEB(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class JIBGMHFNALI : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private NamedUnityEventBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public RecRoomObjectBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private string eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public string <>3__eventName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private NamedUnityEventBase[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			NamedUnityEventBase IEnumerator<NamedUnityEventBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x89EDF0", Offset = "0x89E1F0", VA = "0x18089EDF0")]
			[DebuggerHidden]
			public JIBGMHFNALI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x72594F0", Offset = "0x72588F0", VA = "0x1872594F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x72596A0", Offset = "0x7258AA0", VA = "0x1872596A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x72595E0", Offset = "0x72589E0", VA = "0x1872595E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x72595E0", Offset = "0x72589E0", VA = "0x1872595E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[HideInInspector]
		[SerializeField]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[HideInInspector]
		[SerializeReference]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Dictionary<string, RecRoomObjectProperty> KNEHFICIHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[HideInInspector]
		private StudioFunctionList studioFunctions;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RecRoomObjectProperty[] KGBIFIIMGPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NamedUnityEventBase[] KCOCKPECHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public RecRoomObjectConfiguration APGDODEEDPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x725F4E0", Offset = "0x725E8E0", VA = "0x18725F4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<StudioFunction> OFFEMGOJFKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x857620", Offset = "0x856A20", VA = "0x180857620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObjectBase, string> CMBECKFLHMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x725F430", Offset = "0x725E830", VA = "0x18725F430")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x725F560", Offset = "0x725E960", VA = "0x18725F560")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x725EAB0", Offset = "0x725DEB0", VA = "0x18725EAB0")]
		public bool TryGetProperty(string DHNNKKAIOAA, [Out] RecRoomObjectProperty GEGAKMCPGBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x725EA90", Offset = "0x725DE90", VA = "0x18725EA90")]
		public void SendCircuitsEvent(string GKGIBNLOHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x725EC80", Offset = "0x725E080", VA = "0x18725EC80")]
		public bool TryRaiseUnityEvent(string GKGIBNLOHML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2E0E190", Offset = "0x2E0D590", VA = "0x182E0E190")]
		private bool OEJNHIOMLGC<T0, T1, TEvent>(string GKGIBNLOHML, T0 ILLKNHCHEED, T1 NJEMPKJEDJB) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x725F240", Offset = "0x725E640", VA = "0x18725F240")]
		public bool TryRaiseUnityEvent(string GKGIBNLOHML, bool OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x725F160", Offset = "0x725E560", VA = "0x18725F160")]
		public bool TryRaiseUnityEvent(string GKGIBNLOHML, float OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x725EFB0", Offset = "0x725E3B0", VA = "0x18725EFB0")]
		public bool TryRaiseUnityEvent(string GKGIBNLOHML, int OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x725EE60", Offset = "0x725E260", VA = "0x18725EE60")]
		public bool TryRaiseUnityEvent(string GKGIBNLOHML, string OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x725F080", Offset = "0x725E480", VA = "0x18725F080")]
		public bool TryRaiseUnityEvent(string GKGIBNLOHML, string ILLKNHCHEED, bool NJEMPKJEDJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x725F310", Offset = "0x725E710", VA = "0x18725F310")]
		public bool TryRaiseUnityEvent(string GKGIBNLOHML, string ILLKNHCHEED, float NJEMPKJEDJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x725EF40", Offset = "0x725E340", VA = "0x18725EF40")]
		public bool TryRaiseUnityEvent(string GKGIBNLOHML, string ILLKNHCHEED, int NJEMPKJEDJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x725F0F0", Offset = "0x725E4F0", VA = "0x18725F0F0")]
		public bool TryRaiseUnityEvent(string GKGIBNLOHML, string ILLKNHCHEED, string NJEMPKJEDJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x725E9F0", Offset = "0x725DDF0", VA = "0x18725E9F0")]
		[IteratorStateMachine(typeof(JIBGMHFNALI))]
		private IEnumerable<NamedUnityEventBase> HHPEFNMMBLA(string GKGIBNLOHML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x725E7F0", Offset = "0x725DBF0", VA = "0x18725E7F0")]
		private bool EBDBEKCABNJ(string GKGIBNLOHML, Func<NamedUnityEventBase, bool> KDGCMHGOHEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x725F380", Offset = "0x725E780", VA = "0x18725F380")]
		protected RecRoomObjectBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7261FC0", Offset = "0x72613C0", VA = "0x187261FC0")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7262000", Offset = "0x7261400", VA = "0x187262000")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7262040", Offset = "0x7261440", VA = "0x187262040")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7262100", Offset = "0x7261500", VA = "0x187262100")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x72620C0", Offset = "0x72614C0", VA = "0x1872620C0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7262180", Offset = "0x7261580", VA = "0x187262180")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7262140", Offset = "0x7261540", VA = "0x187262140")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x72621C0", Offset = "0x72615C0", VA = "0x1872621C0")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "5")]
		public virtual bool TryInvokeEvent(bool OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "6")]
		public virtual bool TryInvokeEvent(float OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "7")]
		public virtual bool TryInvokeEvent(int OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "8")]
		public virtual bool TryInvokeEvent(string OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x45904A0", Offset = "0x458F8A0", VA = "0x1845904A0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x725C2C0", Offset = "0x725B6C0", VA = "0x18725C2C0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x725C390", Offset = "0x725B790", VA = "0x18725C390")]
		protected NamedUnityParameterlessEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3D19900", Offset = "0x3D18D00", VA = "0x183D19900")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3D19900", Offset = "0x3D18D00", VA = "0x183D19900")]
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
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x725BC90", Offset = "0x725B090", VA = "0x18725BC90", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x725BCF0", Offset = "0x725B0F0", VA = "0x18725BCF0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x725BE60", Offset = "0x725B260", VA = "0x18725BE60")]
		protected NamedUnityBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityFloatEventBase : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x725BEA0", Offset = "0x725B2A0", VA = "0x18725BEA0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x725BF00", Offset = "0x725B300", VA = "0x18725BF00", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x725C070", Offset = "0x725B470", VA = "0x18725C070")]
		protected NamedUnityFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityIntEventBase : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x725C0B0", Offset = "0x725B4B0", VA = "0x18725C0B0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x725C110", Offset = "0x725B510", VA = "0x18725C110", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x725C280", Offset = "0x725B680", VA = "0x18725C280")]
		protected NamedUnityIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringEventBase : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x725C610", Offset = "0x725BA10", VA = "0x18725C610", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x725C670", Offset = "0x725BA70", VA = "0x18725C670", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x725C7E0", Offset = "0x725BBE0", VA = "0x18725C7E0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x725C3D0", Offset = "0x725B7D0", VA = "0x18725C3D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x725C430", Offset = "0x725B830", VA = "0x18725C430", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x725C5D0", Offset = "0x725B9D0", VA = "0x18725C5D0")]
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
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x725C820", Offset = "0x725BC20", VA = "0x18725C820", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x725C880", Offset = "0x725BC80", VA = "0x18725C880", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x725CA20", Offset = "0x725BE20", VA = "0x18725CA20")]
		protected NamedUnityStringFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringIntEventBase : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x725CA60", Offset = "0x725BE60", VA = "0x18725CA60", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x725CAC0", Offset = "0x725BEC0", VA = "0x18725CAC0", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x725CC60", Offset = "0x725C060", VA = "0x18725CC60")]
		protected NamedUnityStringIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityStringStringEventBase : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x725CCA0", Offset = "0x725C0A0", VA = "0x18725CCA0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x725CD00", Offset = "0x725C100", VA = "0x18725CD00", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x725CE90", Offset = "0x725C290", VA = "0x18725CE90")]
		protected NamedUnityStringStringEventBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> : RecRoomStudioAutoGeneratedAsset<TPrefabRegistryAsset> where TPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TPrefabEntry[] Prefabs
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D19900", Offset = "0x3D18D00", VA = "0x183D19900")]
		public RecRoomObjectPrefabRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> : RecRoomUnitySceneSystemBase where TPrefabAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject>, new() where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> GHLPOEBBIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		[HideInInspector]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private TPrefabAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> CLHFPJDPLGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x44B4020", Offset = "0x44B3420", VA = "0x1844B4020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<TPrefabEntry> IPELACMGONC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x496C230", Offset = "0x496B630", VA = "0x18496C230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x496BF80", Offset = "0x496B380", VA = "0x18496BF80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x496C0B0", Offset = "0x496B4B0", VA = "0x18496C0B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x868090", Offset = "0x867490", VA = "0x180868090")]
		protected RecRoomObjectPrefabRegistryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public abstract class RecRoomObjectPrefabEntryBase<TRecRoomObject> : IEquatable<RecRoomObjectPrefabEntryBase<TRecRoomObject>> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private TRecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private GameObject prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private RecRoomObjectPrefabObjectBoardTemplate objectBoardTemplate;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public GameObject PrefabRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x496BED0", Offset = "0x496B2D0", VA = "0x18496BED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RecRoomObjectPrefabObjectBoardTemplate ObjectBoardTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HasObjectBoardData
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x496BE70", Offset = "0x496B270", VA = "0x18496BE70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x496BC00", Offset = "0x496B000", VA = "0x18496BC00", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabEntryBase<TRecRoomObject> IEDCHGMDIML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x496BD80", Offset = "0x496B180", VA = "0x18496BD80", Slot = "0")]
		public override bool Equals(object LALIGKIKEBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x496BE50", Offset = "0x496B250", VA = "0x18496BE50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		protected RecRoomObjectPrefabEntryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class RecRoomObjectPrefabObjectBoardTemplate : IEquatable<RecRoomObjectPrefabObjectBoardTemplate>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private string signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private byte[] objectBoard;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string Signature
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] ObjectBoard
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x725F760", Offset = "0x725EB60", VA = "0x18725F760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x725F6A0", Offset = "0x725EAA0", VA = "0x18725F6A0", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabObjectBoardTemplate IEDCHGMDIML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x725F620", Offset = "0x725EA20", VA = "0x18725F620")]
		private static bool BFMCDMKGLOL(byte[] MHPKDFDFKGD, byte[] PMENNIKODFA)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class RecRoomStudioAnimatorSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public interface JFFOBANCIFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SetBoolParameterFromScript(string FIKHOKLHCII, bool ELOBPEFBAOG);

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SetIntegerParameterFromScript(string FIKHOKLHCII, int ELOBPEFBAOG);

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetFloatParameterFromScript(string FIKHOKLHCII, float ELOBPEFBAOG);

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SetTriggerParameterFromScript(string FIKHOKLHCII);
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public JFFOBANCIFF LJFHNAJKGGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x725FB70", Offset = "0x725EF70", VA = "0x18725FB70")]
		public Animator GetControlledAnimator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x725FBB0", Offset = "0x725EFB0", VA = "0x18725FBB0")]
		public void SetBoolParameter(string FIKHOKLHCII, bool ELOBPEFBAOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x725FD40", Offset = "0x725F140", VA = "0x18725FD40")]
		public void SetIntegerParameter(string FIKHOKLHCII, int ELOBPEFBAOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x725FC70", Offset = "0x725F070", VA = "0x18725FC70")]
		public void SetFloatParameter(string FIKHOKLHCII, float ELOBPEFBAOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x725FE10", Offset = "0x725F210", VA = "0x18725FE10")]
		public void SetTriggerParameter(string FIKHOKLHCII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		protected RecRoomStudioAnimatorSynchronizerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class RecRoomStudioBillboardBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		[Tooltip("If true, the object can turn left/right to face the player (y-axis rotation)")]
		private bool yawRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		[Tooltip("If true, the object can look up/down to face the player (x-axis rotation)")]
		private bool pitchRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		[Tooltip("If true, the object can rotate clockwise/counter-clockwise to match the players rotation (z-axis rotation)")]
		private bool rollRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		[Tooltip("If true, makes the player \"look through\" the object rather than \"look at\" the object to accomadate Unity UI expectations")]
		private bool faceAwayFromCamera;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JBJFEOBLJDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x854F60", Offset = "0x854360", VA = "0x180854F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DNKMKCMKDFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x95D4E0", Offset = "0x95C8E0", VA = "0x18095D4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB71B80", Offset = "0xB70F80", VA = "0x180B71B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool DCGNCJKEKIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x95D4B0", Offset = "0x95C8B0", VA = "0x18095D4B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x21D4090", Offset = "0x21D3490", VA = "0x1821D4090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool FFCCJBABBNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x95D450", Offset = "0x95C850", VA = "0x18095D450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x452AE00", Offset = "0x452A200", VA = "0x18452AE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x725FED0", Offset = "0x725F2D0", VA = "0x18725FED0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[Tooltip("For screens and mobile players, moves the camera to frame the canvas.")]
			FrameScreensCanvas,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[Tooltip("For screens and mobile players, moves the canvas and anchors it onto the camera.")]
			AnchorCanvasAsMenu
		}

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public bool isAnchored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		[SerializeField]
		private bool isInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Allows the canvas to be anchored and framed to the screen")]
		[SerializeField]
		private bool canBeAnchored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[ConditionallyVisibleField("canBeAnchored", true, false)]
		[SerializeField]
		[Tooltip("The way in which the menu frames up on screen")]
		private AttachmentMode anchorAttachmentMode;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool HJHFBMDJHPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool GINJEJCBHBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x95D4E0", Offset = "0x95C8E0", VA = "0x18095D4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool EIHECFFLJBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x95D4B0", Offset = "0x95C8B0", VA = "0x18095D4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AttachmentMode KKGPCDBKOMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x873980", Offset = "0x872D80", VA = "0x180873980")]
			get
			{
				return default(AttachmentMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AttachmentMode> NIICNNAGFBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x725FF20", Offset = "0x725F320", VA = "0x18725FF20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7260070", Offset = "0x725F470", VA = "0x187260070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action IBEJGLCICAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x725FFD0", Offset = "0x725F3D0", VA = "0x18725FFD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7260120", Offset = "0x725F520", VA = "0x187260120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x725FEE0", Offset = "0x725F2E0", VA = "0x18725FEE0")]
		public void AnchorCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x725FF00", Offset = "0x725F300", VA = "0x18725FF00")]
		public void DetachCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
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
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			NeverRender,
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			OnlyDisableForJunior
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private DisableRenderOptions renderOptions;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool GGCMBDEIKOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x15327C0", Offset = "0x1531BC0", VA = "0x1815327C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		protected RecRoomStudioDisableRenderInShareCamPhotoBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class RecRoomStudioHudCanvasBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		protected RecRoomStudioHudCanvasBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class RecRoomStudioInstanceRecolorBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[HideInInspector]
		[SerializeField]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private MeshRenderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly int instanceColorID;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public IReadOnlyList<MeshRenderer> Renderers
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xD2CB60", Offset = "0xD2BF60", VA = "0x180D2CB60")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x72604B0", Offset = "0x725F8B0", VA = "0x1872604B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x72601C0", Offset = "0x725F5C0", VA = "0x1872601C0")]
		private void ApplyColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7260360", Offset = "0x725F760", VA = "0x187260360")]
		private void ClearColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7260330", Offset = "0x725F730", VA = "0x187260330")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		protected RecRoomStudioInstanceRecolorBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class RecRoomStudioRecNetImageBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		[Tooltip("If true, the image will be automatically cropped into a square.")]
		private bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private DJMEOKHLCBO JCNCNNDCHGO;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public DJMEOKHLCBO FNDNJIFOIJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7260E60", Offset = "0x7260260", VA = "0x187260E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool BHGPICGNFOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CJBMNBNHGNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7260D20", Offset = "0x7260120", VA = "0x187260D20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7260DC0", Offset = "0x72601C0", VA = "0x187260DC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		protected RecRoomStudioRecNetImageBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class RecRoomUnitySceneSystemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		protected RecRoomUnitySceneSystemBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class RecRoomVisualPostProcessingBase : RecRoomUnitySceneSystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[ReadOnlyField]
		[SerializeField]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static RecRoomVisualPostProcessingBase GHLPOEBBIHE;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static RecRoomVisualPostProcessingBase CLHFPJDPLGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x72610D0", Offset = "0x72604D0", VA = "0x1872610D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7260EA0", Offset = "0x72602A0", VA = "0x187260EA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7260F90", Offset = "0x7260390", VA = "0x187260F90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		protected RecRoomVisualPostProcessingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyEnabledFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7258F50", Offset = "0x7258350", VA = "0x187258F50")]
		public ConditionallyEnabledFieldAttribute(string propertyName, bool propertyValue, string disabledTooltip)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class LBPAMLIHNAD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x725B0C0", Offset = "0x725A4C0", VA = "0x18725B0C0")]
	protected LBPAMLIHNAD(string DHNNKKAIOAA, bool KEGIADFCPCA)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyVisibleFieldAttribute : LBPAMLIHNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7258FB0", Offset = "0x72583B0", VA = "0x187258FB0")]
		public ConditionallyVisibleFieldAttribute(string propertyName, bool propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class IntConditionallyVisibleFieldAttribute : LBPAMLIHNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7259450", Offset = "0x7258850", VA = "0x187259450")]
		public IntConditionallyVisibleFieldAttribute(string propertyName, int propertyValue, bool isReadOnly = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface DJMEOKHLCBO
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string CHBMFCIJACF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface OIJLBBLGHMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AttachMarkupComponent(T GOPOAMMAFAF, int OJPKBNGAOOM, bool GPBMKJKEIAG);
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
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
		[SerializeField]
		[ConditionallyEnabledField("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
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

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x725F610", Offset = "0x725EA10", VA = "0x18725F610")]
		public RecRoomObjectConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
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
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
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

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2E0EC70", Offset = "0x2E0E070", VA = "0x182E0EC70")]
		public bool LPPDNPILAFJ<T>([Out] T OBEEJPGJPFD, [Out] string ODIFAFDGMDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x725F980", Offset = "0x725ED80", VA = "0x18725F980")]
		public static string AFCKEBHCGFI(Type JILAKCNFFBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
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

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x725F910", Offset = "0x725ED10", VA = "0x18725F910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x725F7B0", Offset = "0x725EBB0", VA = "0x18725F7B0")]
		public MethodInfo CBJODHPEJAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x725F820", Offset = "0x725EC20", VA = "0x18725F820")]
		public string IEMBIGLIHGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public abstract class RecRoomStudioAutoCreatedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x931280", Offset = "0x930680", VA = "0x180931280")]
		protected RecRoomStudioAutoCreatedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class RecRoomStudioAutoGeneratedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x931280", Offset = "0x930680", VA = "0x180931280")]
		public RecRoomStudioAutoGeneratedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public abstract class RecRoomStudioNavMeshCutBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public const float MINIMUM_WIDTH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		[AJKOOALDNGP("When using a Nav Mesh Cut, you may also want to set NavMesh Generation Mode to Ignore in the configure menu so the associated Rec Room Object won't bake into the navmesh on its own.")]
		private Vector3 size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private Vector3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		[Header("Optimization")]
		[AJKOOALDNGP("Ignoring rotation leads to better performance, but ignoring rotation also means that the box must be aligned with the X, Y, and Z axes.")]
		private bool ignoreRotationAndScale;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		[Obsolete]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7260880", Offset = "0x725FC80", VA = "0x187260880")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7260BA0", Offset = "0x725FFA0", VA = "0x187260BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[Obsolete]
		public float Height
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x95D4F0", Offset = "0x95C8F0", VA = "0x18095D4F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7260B00", Offset = "0x725FF00", VA = "0x187260B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool IgnoreRotationAndScale
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x95D4A0", Offset = "0x95C8A0", VA = "0x18095D4A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7260B80", Offset = "0x725FF80", VA = "0x187260B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Vector3 Size
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xD18B20", Offset = "0xD17F20", VA = "0x180D18B20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7260C20", Offset = "0x7260020", VA = "0x187260C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float HeightSizeY
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x95D4F0", Offset = "0x95C8F0", VA = "0x18095D4F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7260B00", Offset = "0x725FF00", VA = "0x187260B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float XZUniformSquareSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7260CA0", Offset = "0x72600A0", VA = "0x187260CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector3 Center
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xBF5CF0", Offset = "0xBF50F0", VA = "0x180BF5CF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7260A80", Offset = "0x725FE80", VA = "0x187260A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action OnSettingsChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x72607E0", Offset = "0x725FBE0", VA = "0x1872607E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x72609E0", Offset = "0x725FDE0", VA = "0x1872609E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OnForceUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7260740", Offset = "0x725FB40", VA = "0x187260740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7260940", Offset = "0x725FD40", VA = "0x187260940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> OnEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7260690", Offset = "0x725FA90", VA = "0x187260690")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7260890", Offset = "0x725FC90", VA = "0x187260890")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7260530", Offset = "0x725F930", VA = "0x187260530")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9745F0", Offset = "0x9739F0", VA = "0x1809745F0")]
		[Obsolete]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9745F0", Offset = "0x9739F0", VA = "0x1809745F0")]
		public void ForceQueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7260620", Offset = "0x725FA20", VA = "0x187260620")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7260620", Offset = "0x725FA20", VA = "0x187260620")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7260660", Offset = "0x725FA60", VA = "0x187260660")]
		protected RecRoomStudioNavMeshCutBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct MEILHMMPJLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public byte[] IFHNAFPHHCL;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	public MEILHMMPJLK(byte[] OGPKCLEACHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GGLLMDLDJLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public byte[] IFHNAFPHHCL;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	public GGLLMDLDJLC(byte[] OGPKCLEACHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class PAAEDDJEOHI
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x725D0D0", Offset = "0x725C4D0", VA = "0x18725D0D0")]
	public static (MEILHMMPJLK, GGLLMDLDJLC) PJCFFGELACN(Stream GJNAAJIEDPE)
	{
		return default((MEILHMMPJLK, GGLLMDLDJLC));
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x725CF10", Offset = "0x725C310", VA = "0x18725CF10")]
	public static void MOMHBIPGKDF(Stream GJNAAJIEDPE, MEILHMMPJLK AFNMBPMIHMN, GGLLMDLDJLC EOKIOHKOINI)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
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

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x21EB8A0", Offset = "0x21EACA0", VA = "0x1821EB8A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x68CC730", Offset = "0x68CBB30", VA = "0x1868CC730")]
		public SerializedGuid([In] Guid HLKHAOEDAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x68CC690", Offset = "0x68CBA90", VA = "0x1868CC690", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x72611A0", Offset = "0x72605A0", VA = "0x1872611A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x68CC4D0", Offset = "0x68CB8D0", VA = "0x1868CC4D0", Slot = "7")]
		public bool Equals(SerializedGuid IEDCHGMDIML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7261110", Offset = "0x7260510", VA = "0x187261110", Slot = "0")]
		public override bool Equals(object LALIGKIKEBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x68CC5A0", Offset = "0x68CB9A0", VA = "0x1868CC5A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x68CC420", Offset = "0x68CB820", VA = "0x1868CC420", Slot = "6")]
		public int CompareTo(SerializedGuid IEDCHGMDIML)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7261220", Offset = "0x7260620", VA = "0x187261220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SerializedTypeNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public SerializedTypeNameAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DMGPIOJKPJP
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly BADOKLEEAHE FHCEGKGMODC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static readonly BADOKLEEAHE CAHPGGGHOIB;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static readonly BADOKLEEAHE MAOOOKOHDIB;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static readonly BADOKLEEAHE FMNKFMNBIDA;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly BADOKLEEAHE MEFMLCGGPFC;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static readonly BADOKLEEAHE NICLNDJHKHH;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7259010", Offset = "0x7258410", VA = "0x187259010")]
	static DMGPIOJKPJP()
	{
	}
}
namespace RecRoom.Core.Studio.StudioFunctions
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
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

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Parameter Binding
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public Argument()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
		public Argument(string FIKHOKLHCII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7256A60", Offset = "0x7255E60", VA = "0x187256A60")]
		public object CMPMEDMCOHL(object[] HNPAIPEPJAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x72569F0", Offset = "0x7255DF0", VA = "0x1872569F0")]
		internal void AOLMCNCIMLP(IReadOnlyList<Parameter> GLODDHJJLAG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument<T> : Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		protected T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x416DF30", Offset = "0x416D330", VA = "0x18416DF30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x416DA60", Offset = "0x416CE60", VA = "0x18416DA60")]
		protected Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class VoidArgument : Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static readonly VoidArgument Instance;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x72624F0", Offset = "0x72618F0", VA = "0x1872624F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7262470", Offset = "0x7261870", VA = "0x187262470")]
		private VoidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4BC0360", Offset = "0x4BBF760", VA = "0x184BC0360", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x38EF990", Offset = "0x38EED90", VA = "0x1838EF990")]
		protected ValueArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
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

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x512F410", Offset = "0x512E810", VA = "0x18512F410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x512F170", Offset = "0x512E570", VA = "0x18512F170")]
		private Type HFLIGHHANHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x37D4550", Offset = "0x37D3950", VA = "0x1837D4550")]
		protected ClassArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolArgument : ValueArgument<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7256B30", Offset = "0x7255F30", VA = "0x187256B30")]
		public BoolArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorArgument : ValueArgument<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x72581A0", Offset = "0x72575A0", VA = "0x1872581A0")]
		public ColorArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Argument : ValueArgument<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7258120", Offset = "0x7257520", VA = "0x187258120")]
		public Color32Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[UnityEngine.Scripting.Preserve]
	public sealed class GuidArgument : ValueArgument<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7259280", Offset = "0x7258680", VA = "0x187259280")]
		public GuidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatArgument : ValueArgument<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x72591A0", Offset = "0x72585A0", VA = "0x1872591A0")]
		public FloatArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntArgument : ValueArgument<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7259410", Offset = "0x7258810", VA = "0x187259410")]
		public IntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ShortArgument : ValueArgument<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7261230", Offset = "0x7260630", VA = "0x187261230")]
		public ShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringArgument : ValueArgument<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7261270", Offset = "0x7260670", VA = "0x187261270")]
		public StringArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UIntArgument : ValueArgument<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7261F40", Offset = "0x7261340", VA = "0x187261F40")]
		public UIntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UShortArgument : ValueArgument<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7261F80", Offset = "0x7261380", VA = "0x187261F80")]
		public UShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Argument : ValueArgument<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7262200", Offset = "0x7261600", VA = "0x187262200")]
		public Vector2Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Argument : ValueArgument<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7262280", Offset = "0x7261680", VA = "0x187262280")]
		public Vector3Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionArgument : ValueArgument<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x725D440", Offset = "0x725C840", VA = "0x18725D440")]
		public QuaternionArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UnityObjectArgument : ClassArgument<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7262080", Offset = "0x7261480", VA = "0x187262080")]
		public UnityObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageArgument : ValueArgument<DJMEOKHLCBO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x725D4C0", Offset = "0x725C8C0", VA = "0x18725D4C0")]
		public RecNetImageArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void KGLFFAEFCMK(string NAAHEAAKBLD, object[] HNPAIPEPJAE, object[] NKBAGHANDAK);

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected internal abstract void KMBJKPMCDGM(IReadOnlyList<Parameter> GLODDHJJLAG, IReadOnlyList<Parameter> GPGINNNNBLE);

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		protected Instruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
		public override void KGLFFAEFCMK(string NAAHEAAKBLD, object[] HNPAIPEPJAE, object[] NKBAGHANDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		protected internal override void KMBJKPMCDGM(IReadOnlyList<Parameter> GLODDHJJLAG, IReadOnlyList<Parameter> GPGINNNNBLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public PlaceholderInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
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

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x72580A0", Offset = "0x72574A0", VA = "0x1872580A0")]
		public CallInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x72574B0", Offset = "0x72568B0", VA = "0x1872574B0", Slot = "4")]
		public override void KGLFFAEFCMK(string NAAHEAAKBLD, object[] HNPAIPEPJAE, object[] NKBAGHANDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7257090", Offset = "0x7256490", VA = "0x187257090")]
		private void FAPJCGAMBGH(object[] NKBAGHANDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7256F30", Offset = "0x7256330", VA = "0x187256F30")]
		private void DECNMBPGANG(object[] NKBAGHANDAK, object OEMFNHJGBJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x72579F0", Offset = "0x7256DF0", VA = "0x1872579F0", Slot = "5")]
		protected internal override void KMBJKPMCDGM(IReadOnlyList<Parameter> GLODDHJJLAG, IReadOnlyList<Parameter> GPGINNNNBLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7256D00", Offset = "0x7256100", VA = "0x187256D00")]
		[UnityEngine.Scripting.Preserve]
		private static void AAEKBABNGGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7256FD0", Offset = "0x72563D0", VA = "0x187256FD0")]
		private MethodInfo ELAMNECBFNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7257310", Offset = "0x7256710", VA = "0x187257310")]
		internal MethodInfo IDKBKPEOBBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7257B20", Offset = "0x7256F20", VA = "0x187257B20")]
		internal static bool PGJJHLBCAAM(UnityEngine.Object KMCPIOGEAKL, string PNMIOLMDIEK, Argument[] OELDEOCNNMP, [Out] MethodInfo PHOMCNEPCEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x72573A0", Offset = "0x72567A0", VA = "0x1872573A0")]
		private static bool IOMOFIPEMOF(MethodInfo PHOMCNEPCEM, Type[] DKBNJNFCBIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7257140", Offset = "0x7256540", VA = "0x187257140")]
		private static object[] GKGJDGMEBEJ(int JKNJACIKFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7256DC0", Offset = "0x72561C0", VA = "0x187256DC0")]
		private object[] CIKLKPDKKAJ(object[] HNPAIPEPJAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7256D60", Offset = "0x7256160", VA = "0x187256D60")]
		private void AGACCGELGGP(object[] KHOFBHOFOPH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
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

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7258ED0", Offset = "0x72582D0", VA = "0x187258ED0")]
		public ConditionalInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7258810", Offset = "0x7257C10", VA = "0x187258810", Slot = "4")]
		public override void KGLFFAEFCMK(string NAAHEAAKBLD, object[] HNPAIPEPJAE, object[] NKBAGHANDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7258C40", Offset = "0x7258040", VA = "0x187258C40", Slot = "5")]
		protected internal override void KMBJKPMCDGM(IReadOnlyList<Parameter> GLODDHJJLAG, IReadOnlyList<Parameter> GPGINNNNBLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x72587A0", Offset = "0x7257BA0", VA = "0x1872587A0")]
		private void AOLMCNCIMLP(IReadOnlyList<Parameter> GLODDHJJLAG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
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

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public IReadOnlyList<Instruction> Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x7258750", Offset = "0x7257B50", VA = "0x187258750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x72586D0", Offset = "0x7257AD0", VA = "0x1872586D0")]
		public Condition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7258600", Offset = "0x7257A00", VA = "0x187258600")]
		public static bool MMJOKGINLCN(string OBEEJPGJPFD, [Out] bool CFEMIGNDCHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7258530", Offset = "0x7257930", VA = "0x187258530")]
		public static bool KNDFLCFJIAE(string OBEEJPGJPFD, [Out] int HMHLEJDPHDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x72582B0", Offset = "0x72576B0", VA = "0x1872582B0")]
		public bool BHLFNNMPPDM(bool FGJIKKAOCLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x72583A0", Offset = "0x72577A0", VA = "0x1872583A0")]
		public bool DBAKKAHIDHF(int MHEJHFIGLLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7258480", Offset = "0x7257880", VA = "0x187258480")]
		public bool GIGPAFCCCOO(string CPPKBHHIPGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x72584A0", Offset = "0x72578A0", VA = "0x1872584A0")]
		public void KGLFFAEFCMK(string NAAHEAAKBLD, object[] HNPAIPEPJAE, object[] NKBAGHANDAK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
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

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xBF38F0", Offset = "0xBF2CF0", VA = "0x180BF38F0")]
		public Parameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x725D300", Offset = "0x725C700", VA = "0x18725D300")]
		internal void FGKGAOCEDDM(int NBPBJGCJNPC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderParameter : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x725D3E0", Offset = "0x725C7E0", VA = "0x18725D3E0", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter<T> : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x47FE5D0", Offset = "0x47FD9D0", VA = "0x1847FE5D0")]
		protected Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4C22620", Offset = "0x4C21A20", VA = "0x184C22620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x38EF990", Offset = "0x38EED90", VA = "0x1838EF990")]
		protected ValueParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
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

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x512F540", Offset = "0x512E940", VA = "0x18512F540", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x512F480", Offset = "0x512E880", VA = "0x18512F480")]
		private Type HFLIGHHANHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x37D4550", Offset = "0x37D3950", VA = "0x1837D4550")]
		protected ClassParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolParameter : ValueParameter<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7256B70", Offset = "0x7255F70", VA = "0x187256B70")]
		public BoolParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorParameter : ValueParameter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x72581E0", Offset = "0x72575E0", VA = "0x1872581E0")]
		public ColorParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Parameter : ValueParameter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7258160", Offset = "0x7257560", VA = "0x187258160")]
		public Color32Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatParameter : ValueParameter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x72591E0", Offset = "0x72585E0", VA = "0x1872591E0")]
		public FloatParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntParameter : ValueParameter<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x72594B0", Offset = "0x72588B0", VA = "0x1872594B0")]
		public IntParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringParameter : ValueParameter<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x72612B0", Offset = "0x72606B0", VA = "0x1872612B0")]
		public StringParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Parameter : ValueParameter<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7262240", Offset = "0x7261640", VA = "0x187262240")]
		public Vector2Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Parameter : ValueParameter<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x72622C0", Offset = "0x72616C0", VA = "0x1872622C0")]
		public Vector3Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionParameter : ValueParameter<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x725D480", Offset = "0x725C880", VA = "0x18725D480")]
		public QuaternionParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageParameter : ValueParameter<DJMEOKHLCBO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x725D500", Offset = "0x725C900", VA = "0x18725D500")]
		public RecNetImageParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
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

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7261CF0", Offset = "0x72610F0", VA = "0x187261CF0")]
		public StudioFunction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x72617A0", Offset = "0x7260BA0", VA = "0x1872617A0")]
		public void KGLFFAEFCMK(object[] HNPAIPEPJAE, object[] NKBAGHANDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x72619F0", Offset = "0x7260DF0", VA = "0x1872619F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7261660", Offset = "0x7260A60", VA = "0x187261660")]
		private void BBGFPDPCILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7261980", Offset = "0x7260D80", VA = "0x187261980")]
		private void KMBJKPMCDGM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[UnityEngine.Scripting.Preserve]
	public class StudioFunctionList : IReadOnlyList<StudioFunction>, IEnumerable<StudioFunction>, IEnumerable, IReadOnlyCollection<StudioFunction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		[HideInInspector]
		private StudioFunction[] array;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private IReadOnlyList<StudioFunction> ReadOnlyList
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x7261610", Offset = "0x7260A10", VA = "0x187261610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7261440", Offset = "0x7260840", VA = "0x187261440", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public StudioFunction this[int AGAGKNBDCIG]
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x7261530", Offset = "0x7260930", VA = "0x187261530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x72612F0", Offset = "0x72606F0", VA = "0x1872612F0", Slot = "6")]
		public IEnumerator<StudioFunction> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7261370", Offset = "0x7260770", VA = "0x187261370", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x72613F0", Offset = "0x72607F0", VA = "0x1872613F0")]
		public StudioFunctionList()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class MPBANAOFHIC
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x725B1A0", Offset = "0x725A5A0", VA = "0x18725B1A0")]
	public static string KLPDJDLPCHG(this Type EPPKBKJHHHJ)
	{
		return null;
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class RecRoomStudioAvatarItemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
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
