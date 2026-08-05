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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x751C540", Offset = "0x751AF40", VA = "0x18751C540", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct GLKLIFCLHDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 HMDHFGCBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion PCIAHIPKDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 DHJEIIDICAN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7519740", Offset = "0x7518140", VA = "0x187519740")]
	public bool EILCFLGDLKL(Collider CFMHFMLEKHC, Bounds OBOMBLGEGIE, bool JEBCCBANDKN, bool HJMHODCAHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x751A1E0", Offset = "0x7518BE0", VA = "0x18751A1E0")]
	public bool LFEGLGMKOEP(Collider JGMIDFFABNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x751AAF0", Offset = "0x75194F0", VA = "0x18751AAF0")]
	public bool PGACANCCMCB(Collider JGMIDFFABNN, bool JEBCCBANDKN, bool HJMHODCAHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x751A130", Offset = "0x7518B30", VA = "0x18751A130")]
	public void ILKLFBGBJHL(Transform NNEFLDDEJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x751A200", Offset = "0x7518C00", VA = "0x18751A200")]
	public void LGKEEIGILFM(GLKLIFCLHDN CGCLEIBHLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x751A0B0", Offset = "0x7518AB0", VA = "0x18751A0B0")]
	private static void GEFIBMNHLCK(Vector3 INMICDHDKLG, Vector3 LACIJCNPAEP, Vector3 BJFHPDFPFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7519CC0", Offset = "0x75186C0", VA = "0x187519CC0")]
	public static GLKLIFCLHDN EKBFPLFMILK(GameObject BAFHJDFHJHD, Quaternion PCIAHIPKDFG, bool OPJMMHPELBJ, bool LGDDGHHAJHD, bool JEBCCBANDKN = false, bool HJMHODCAHAN = false, bool CDKCGJDMNNF = false)
	{
		return default(GLKLIFCLHDN);
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
public enum ELHGGJLOMGA
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
public static class IBGOPCCIJBG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string LDEOMCJPHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x751B2F0", Offset = "0x7519CF0", VA = "0x18751B2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string JIJOFKOGNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x751B410", Offset = "0x7519E10", VA = "0x18751B410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string OLICODPFGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x751B3E0", Offset = "0x7519DE0", VA = "0x18751B3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x751B320", Offset = "0x7519D20", VA = "0x18751B320")]
	public static ELHGGJLOMGA HBCPIPIIHMO(this ELHGGJLOMGA HHODEMGPJAL)
	{
		return default(ELHGGJLOMGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x751B320", Offset = "0x7519D20", VA = "0x18751B320")]
	public static int HBCPIPIIHMO(int HHODEMGPJAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FHJNPLIIIEI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	AudioMixerGroup FIHEPBDDFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FHJNPLIIIEI JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IReadOnlyList<FHJNPLIIIEI> EGPJBHPFBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string MIEIIJDFEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IJMOMFLDNMK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class EOAPNFPCPIN : FHJNPLIIIEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal readonly List<FHJNPLIIIEI> ENBDLLGMAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal readonly EOAPNFPCPIN EKFPIEDABKJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FHJNPLIIIEI JEBILDNGPEC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AudioMixerGroup FIHEPBDDFMM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<FHJNPLIIIEI> EGPJBHPFBGO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string MIEIIJDFEDN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x75194F0", Offset = "0x7517EF0", VA = "0x1875194F0")]
		internal EOAPNFPCPIN(AudioMixerGroup FGKAOJPFKBO, EOAPNFPCPIN KMAENCDMJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FHJNPLIIIEI DBLONLCMGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AudioMixer PHJCILJEOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x751B470", Offset = "0x7519E70", VA = "0x18751B470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	private IJMOMFLDNMK(EOAPNFPCPIN CGCNIOBNLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x751BB80", Offset = "0x751A580", VA = "0x18751BB80")]
	public static IJMOMFLDNMK NFFGKJODABO(AudioMixer GALOFHGBBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x751B4D0", Offset = "0x7519ED0", VA = "0x18751B4D0")]
	public FHJNPLIIIEI DOEDHEAKCFC(string PGKDNBILMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x751B870", Offset = "0x751A270", VA = "0x18751B870")]
	public FHJNPLIIIEI DOEDHEAKCFC(AudioMixerGroup FGKAOJPFKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x751BB00", Offset = "0x751A500", VA = "0x18751BB00")]
	private static int MCPIGJFKHEO(string KCEMGCAKHDC, int ICLEKBDIINO)
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasBeenTranslated
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x88B230", Offset = "0x889C30", VA = "0x18088B230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x88B250", Offset = "0x889C50", VA = "0x18088B250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x476E2E0", Offset = "0x476CCE0", VA = "0x18476E2E0")]
		public MaterialEntry KBKLCKLLICN(Material PPFNGNPGEKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x476E2B0", Offset = "0x476CCB0", VA = "0x18476E2B0")]
		public void EKFBPJMHHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3A92B20", Offset = "0x3A91520", VA = "0x183A92B20")]
		public MaterialMapAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class MaterialMapBase<TMaterialMapAsset> : RecRoomUnitySceneSystemBase where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static MaterialMapBase<TMaterialMapAsset> MHOPBKMJKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[HideInInspector]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private TMaterialMapAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static MaterialMapBase<TMaterialMapAsset> GHBFIIGNNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3E96200", Offset = "0x3E94C00", VA = "0x183E96200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MaterialEntry[] JJKECNNPEDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x476E7C0", Offset = "0x476D1C0", VA = "0x18476E7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x476E3D0", Offset = "0x476CDD0", VA = "0x18476E3D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x476E6E0", Offset = "0x476D0E0", VA = "0x18476E6E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x476E5F0", Offset = "0x476CFF0", VA = "0x18476E5F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x476E5A0", Offset = "0x476CFA0", VA = "0x18476E5A0")]
		public void ClearSceneMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A0AF0", Offset = "0x89F4F0", VA = "0x1808A0AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75228F0", Offset = "0x75212F0", VA = "0x1875228F0", Slot = "4")]
		public bool Equals(TextureProperty CGCLEIBHLHF)
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
		[Cpp2IlInjected.Address(RVA = "0x7519690", Offset = "0x7518090", VA = "0x187519690", Slot = "4")]
		public bool Equals(FloatProperty CGCLEIBHLHF)
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
		[Cpp2IlInjected.Address(RVA = "0x7522E90", Offset = "0x7521890", VA = "0x187522E90", Slot = "4")]
		public bool Equals(VectorProperty CGCLEIBHLHF)
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
		[Cpp2IlInjected.Address(RVA = "0x7518700", Offset = "0x7517100", VA = "0x187518700", Slot = "4")]
		public bool Equals(ColorProperty CGCLEIBHLHF)
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
		[Cpp2IlInjected.Address(RVA = "0x751C800", Offset = "0x751B200", VA = "0x18751C800")]
		public void FPPDOFBOJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x751CC40", Offset = "0x751B640", VA = "0x18751CC40")]
		public float HHCMKODEPKN(int MEOOGDKENOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x751C5D0", Offset = "0x751AFD0", VA = "0x18751C5D0")]
		public Texture CFFINLJJDJE(int MEOOGDKENOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x751CB90", Offset = "0x751B590", VA = "0x18751CB90")]
		public Vector4 HBKLGMHNAOE(int MEOOGDKENOH)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x751C620", Offset = "0x751B020", VA = "0x18751C620")]
		public Color DCMKIBMFBKH(int MEOOGDKENOH)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x751C6A0", Offset = "0x751B0A0", VA = "0x18751C6A0", Slot = "4")]
		public bool Equals(MaterialEntry CGCLEIBHLHF)
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
			[Cpp2IlInjected.Address(RVA = "0x4B3E7C0", Offset = "0x4B3D1C0", VA = "0x184B3E7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3DE89D0", Offset = "0x3DE73D0", VA = "0x183DE89D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AddComponentMenu(null)]
	public abstract class RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> : RecRoomUnitySceneSystemBase where TAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> MHOPBKMJKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[ReadOnlyField]
		[SerializeField]
		private TAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> GHBFIIGNNDE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x3E96200", Offset = "0x3E94C00", VA = "0x183E96200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public TAudioClipRegistryAsset JJKECNNPEDM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IReadOnlyList<RecRoomAudioClipEntry> LABBJKGAEPD
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4B3EAA0", Offset = "0x4B3D4A0", VA = "0x184B3EAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E810", Offset = "0x4B3D210", VA = "0x184B3E810")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E930", Offset = "0x4B3D330", VA = "0x184B3E930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A0AF0", Offset = "0x89F4F0", VA = "0x1808A0AF0")]
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
		private static readonly Dictionary<AudioMixerGroupType, string> EBKEFIGEBIM;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string IDOHBPAELHG = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string EPBKKEMBKJM = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const string GGNMMGADDEO = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly string NDBEDCKGBCF;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string NOGOFDFBPPH;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static RecRoomAudioMixerRegistryBase MHOPBKMJKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[ReadOnlyField]
		[SerializeField]
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
		[IntConditionallyVisibleField("version", 0, false)]
		[SerializeField]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 1, false)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static RecRoomAudioMixerRegistryBase GHBFIIGNNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x751EF90", Offset = "0x751D990", VA = "0x18751EF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AudioMixer ECMAKEIMEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool HACHFHFHEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x751EFE0", Offset = "0x751D9E0", VA = "0x18751EFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public MixerVersion PCGHHNFLFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
			get
			{
				return default(MixerVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x751F130", Offset = "0x751DB30", VA = "0x18751F130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x751E450", Offset = "0x751CE50", VA = "0x18751E450")]
		public static string GetAudioGroupPath(AudioMixerGroupType LOPHNCNFIDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x751E570", Offset = "0x751CF70", VA = "0x18751E570")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroupType LOPHNCNFIDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x751E990", Offset = "0x751D390", VA = "0x18751E990")]
		private static AudioMixerGroup LGPIMMJFFEC(AudioMixer GALOFHGBBMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x751E0D0", Offset = "0x751CAD0", VA = "0x18751E0D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x751EBA0", Offset = "0x751D5A0", VA = "0x18751EBA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x751E750", Offset = "0x751D150", VA = "0x18751E750")]
		public bool IsValidOutputGroup(AudioMixerGroup BBLFJICGMAO, [Out] string EJIIMGEBDBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x751EA30", Offset = "0x751D430", VA = "0x18751EA30")]
		private bool MGJPMFOKIJC(AudioMixerGroup BBLFJICGMAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x751E1E0", Offset = "0x751CBE0", VA = "0x18751E1E0")]
		private bool BPCCOEDANAM(AudioMixerGroup NGMEKEBOJDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected RecRoomAudioMixerRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class RecRoomBuiltInObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[HideInInspector]
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
		public Guid KENNGNFFMKG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x751F270", Offset = "0x751DC70", VA = "0x18751F270")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x751F2E0", Offset = "0x751DCE0", VA = "0x18751F2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool EEPEJOENIBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x751F250", Offset = "0x751DC50", VA = "0x18751F250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool BCKKNIEOKHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x751F200", Offset = "0x751DC00", VA = "0x18751F200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Transform AJAAKEBINJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8892C0", Offset = "0x887CC0", VA = "0x1808892C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		public byte[] GetSpawnableTemplateData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
		public void SetSpawnableTemplateData(byte[] MNJPHDCFGAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B1050", Offset = "0x8AFA50", VA = "0x1808B1050")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B3ECC0", Offset = "0x4B3D6C0", VA = "0x184B3ECC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IReadOnlyDictionary<Guid, TRecRoomBuiltInObject> AllBuiltInObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3E60220", Offset = "0x3E5EC20", VA = "0x183E60220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4B3EC50", Offset = "0x4B3D650", VA = "0x184B3EC50")]
		public void HJANGFCIHOC(IEnumerable<TRecRoomBuiltInObject> OJNHPEGLHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4B3EB90", Offset = "0x4B3D590", VA = "0x184B3EB90")]
		public bool FJHIBPMOMDE(Guid KEMPCBHBOAG, [Out] TRecRoomBuiltInObject OLNAJPLAHGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x994550", Offset = "0x992F50", VA = "0x180994550")]
		protected RecRoomBuiltInObjectDataBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class RecRoomObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class KIBGHDOJBML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public bool value;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public KIBGHDOJBML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x751C010", Offset = "0x751AA10", VA = "0x18751C010")]
			internal bool BMLOCCJNNLE(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IIIKIILBDIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float value;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public IIIKIILBDIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x751B440", Offset = "0x7519E40", VA = "0x18751B440")]
			internal bool BMLOCCJNNLE(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NJICKOIBJLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public int value;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public NJICKOIBJLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x751CC90", Offset = "0x751B690", VA = "0x18751CC90")]
			internal bool BMLOCCJNNLE(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BIJKCFKCHEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public string value;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public BIJKCFKCHEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7515630", Offset = "0x7514030", VA = "0x187515630")]
			internal bool BMLOCCJNNLE(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class GPDOLKELEEE : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
			[DebuggerHidden]
			public GPDOLKELEEE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x751B0B0", Offset = "0x7519AB0", VA = "0x18751B0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x751B260", Offset = "0x7519C60", VA = "0x18751B260", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x751B1A0", Offset = "0x7519BA0", VA = "0x18751B1A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x751B1A0", Offset = "0x7519BA0", VA = "0x18751B1A0", Slot = "5")]
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
		[SerializeReference]
		[HideInInspector]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Dictionary<string, RecRoomObjectProperty> BLKNKIAEKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[HideInInspector]
		[SerializeField]
		private StudioFunctionList studioFunctions;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RecRoomObjectProperty[] CGDMGMALMID
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NamedUnityEventBase[] AJAOELLEBGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public RecRoomObjectConfiguration PAODGJOBKKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7520040", Offset = "0x751EA40", VA = "0x187520040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<StudioFunction> NPMCIPPMEGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObjectBase, string> PLJAHNCDANL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x751FF90", Offset = "0x751E990", VA = "0x18751FF90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x75200C0", Offset = "0x751EAC0", VA = "0x1875200C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x751F620", Offset = "0x751E020", VA = "0x18751F620")]
		public bool TryGetProperty(string PCFKMOBOMBL, [Out] RecRoomObjectProperty GDCGGGDDADM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x751F600", Offset = "0x751E000", VA = "0x18751F600")]
		public void SendCircuitsEvent(string GAAMAPOEHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x751F7E0", Offset = "0x751E1E0", VA = "0x18751F7E0")]
		public bool TryRaiseUnityEvent(string GAAMAPOEHNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2FFB900", Offset = "0x2FFA300", VA = "0x182FFB900")]
		private bool POPBLFOPOPF<T0, T1, TEvent>(string GAAMAPOEHNE, T0 CIOEJMLCDON, T1 JIPKFICGLPJ) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x751FDA0", Offset = "0x751E7A0", VA = "0x18751FDA0")]
		public bool TryRaiseUnityEvent(string GAAMAPOEHNE, bool IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x751FCC0", Offset = "0x751E6C0", VA = "0x18751FCC0")]
		public bool TryRaiseUnityEvent(string GAAMAPOEHNE, float IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x751FB10", Offset = "0x751E510", VA = "0x18751FB10")]
		public bool TryRaiseUnityEvent(string GAAMAPOEHNE, int IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x751F9C0", Offset = "0x751E3C0", VA = "0x18751F9C0")]
		public bool TryRaiseUnityEvent(string GAAMAPOEHNE, string IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x751FBE0", Offset = "0x751E5E0", VA = "0x18751FBE0")]
		public bool TryRaiseUnityEvent(string GAAMAPOEHNE, string CIOEJMLCDON, bool JIPKFICGLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x751FE70", Offset = "0x751E870", VA = "0x18751FE70")]
		public bool TryRaiseUnityEvent(string GAAMAPOEHNE, string CIOEJMLCDON, float JIPKFICGLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x751FAA0", Offset = "0x751E4A0", VA = "0x18751FAA0")]
		public bool TryRaiseUnityEvent(string GAAMAPOEHNE, string CIOEJMLCDON, int JIPKFICGLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x751FC50", Offset = "0x751E650", VA = "0x18751FC50")]
		public bool TryRaiseUnityEvent(string GAAMAPOEHNE, string CIOEJMLCDON, string JIPKFICGLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x751F560", Offset = "0x751DF60", VA = "0x18751F560")]
		[IteratorStateMachine(typeof(GPDOLKELEEE))]
		private IEnumerable<NamedUnityEventBase> KEPMLAKGCMC(string GAAMAPOEHNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x751F360", Offset = "0x751DD60", VA = "0x18751F360")]
		private bool DFPJGNBECPK(string GAAMAPOEHNE, Func<NamedUnityEventBase, bool> DFHBHDPCNGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x751FEE0", Offset = "0x751E8E0", VA = "0x18751FEE0")]
		protected RecRoomObjectBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7522B50", Offset = "0x7521550", VA = "0x187522B50")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7522B90", Offset = "0x7521590", VA = "0x187522B90")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7522BD0", Offset = "0x75215D0", VA = "0x187522BD0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7522C90", Offset = "0x7521690", VA = "0x187522C90")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7522C50", Offset = "0x7521650", VA = "0x187522C50")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7522D10", Offset = "0x7521710", VA = "0x187522D10")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7522CD0", Offset = "0x75216D0", VA = "0x187522CD0")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7522D50", Offset = "0x7521750", VA = "0x187522D50")]
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
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "5")]
		public virtual bool TryInvokeEvent(bool IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "6")]
		public virtual bool TryInvokeEvent(float IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "7")]
		public virtual bool TryInvokeEvent(int IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "8")]
		public virtual bool TryInvokeEvent(string IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x47FDEB0", Offset = "0x47FC8B0", VA = "0x1847FDEB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x751D2C0", Offset = "0x751BCC0", VA = "0x18751D2C0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x751D390", Offset = "0x751BD90", VA = "0x18751D390")]
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
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE89D0", Offset = "0x3DE73D0", VA = "0x183DE89D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DE89D0", Offset = "0x3DE73D0", VA = "0x183DE89D0")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityBooleanEventBase : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x751CCC0", Offset = "0x751B6C0", VA = "0x18751CCC0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x751CD20", Offset = "0x751B720", VA = "0x18751CD20", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x751CE80", Offset = "0x751B880", VA = "0x18751CE80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x751CEC0", Offset = "0x751B8C0", VA = "0x18751CEC0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x751CF20", Offset = "0x751B920", VA = "0x18751CF20", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x751D080", Offset = "0x751BA80", VA = "0x18751D080")]
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
		[Cpp2IlInjected.Address(RVA = "0x751D0C0", Offset = "0x751BAC0", VA = "0x18751D0C0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x751D120", Offset = "0x751BB20", VA = "0x18751D120", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x751D280", Offset = "0x751BC80", VA = "0x18751D280")]
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
		[Cpp2IlInjected.Address(RVA = "0x751D600", Offset = "0x751C000", VA = "0x18751D600", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x751D660", Offset = "0x751C060", VA = "0x18751D660", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x751D7C0", Offset = "0x751C1C0", VA = "0x18751D7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x751D3D0", Offset = "0x751BDD0", VA = "0x18751D3D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x751D430", Offset = "0x751BE30", VA = "0x18751D430", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x751D5C0", Offset = "0x751BFC0", VA = "0x18751D5C0")]
		protected NamedUnityStringBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityStringFloatEventBase : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x751D800", Offset = "0x751C200", VA = "0x18751D800", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x751D860", Offset = "0x751C260", VA = "0x18751D860", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x751D9F0", Offset = "0x751C3F0", VA = "0x18751D9F0")]
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
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x751DA30", Offset = "0x751C430", VA = "0x18751DA30", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x751DA90", Offset = "0x751C490", VA = "0x18751DA90", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x751DC20", Offset = "0x751C620", VA = "0x18751DC20")]
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
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x751DC60", Offset = "0x751C660", VA = "0x18751DC60", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x751DCC0", Offset = "0x751C6C0", VA = "0x18751DCC0", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x751DE50", Offset = "0x751C850", VA = "0x18751DE50")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DE89D0", Offset = "0x3DE73D0", VA = "0x183DE89D0")]
		public RecRoomObjectPrefabRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> : RecRoomUnitySceneSystemBase where TPrefabAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject>, new() where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> MHOPBKMJKKN;

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
		public static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> GHBFIIGNNDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x3E96200", Offset = "0x3E94C00", VA = "0x183E96200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<TPrefabEntry> DPNEOMEOJOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4B3F540", Offset = "0x4B3DF40", VA = "0x184B3F540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4B3F2B0", Offset = "0x4B3DCB0", VA = "0x184B3F2B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4B3F3D0", Offset = "0x4B3DDD0", VA = "0x184B3F3D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8A0AF0", Offset = "0x89F4F0", VA = "0x1808A0AF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B3F200", Offset = "0x4B3DC00", VA = "0x184B3F200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RecRoomObjectPrefabObjectBoardTemplate ObjectBoardTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HasObjectBoardData
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x4B3F1A0", Offset = "0x4B3DBA0", VA = "0x184B3F1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4B3EF30", Offset = "0x4B3D930", VA = "0x184B3EF30", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabEntryBase<TRecRoomObject> CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4B3F0B0", Offset = "0x4B3DAB0", VA = "0x184B3F0B0", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4B3F180", Offset = "0x4B3DB80", VA = "0x184B3F180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] ObjectBoard
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x75202C0", Offset = "0x751ECC0", VA = "0x1875202C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7520200", Offset = "0x751EC00", VA = "0x187520200", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabObjectBoardTemplate CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7520180", Offset = "0x751EB80", VA = "0x187520180")]
		private static bool ELPHLFCOINA(byte[] KOAJOPBCAGN, byte[] GEMGBFENCEL)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class RecRoomStudioAnimatorSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public interface OCPMHHEPAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SetBoolParameterFromScript(string DDDMPLCOGIM, bool POCLHBJGKBH);

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SetIntegerParameterFromScript(string DDDMPLCOGIM, int POCLHBJGKBH);

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetFloatParameterFromScript(string DDDMPLCOGIM, float POCLHBJGKBH);

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SetTriggerParameterFromScript(string DDDMPLCOGIM);
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public OCPMHHEPAHJ JGOALMINFLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x75206D0", Offset = "0x751F0D0", VA = "0x1875206D0")]
		public Animator GetControlledAnimator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7520710", Offset = "0x751F110", VA = "0x187520710")]
		public void SetBoolParameter(string DDDMPLCOGIM, bool POCLHBJGKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x75208A0", Offset = "0x751F2A0", VA = "0x1875208A0")]
		public void SetIntegerParameter(string DDDMPLCOGIM, int POCLHBJGKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x75207D0", Offset = "0x751F1D0", VA = "0x1875207D0")]
		public void SetFloatParameter(string DDDMPLCOGIM, float POCLHBJGKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7520960", Offset = "0x751F360", VA = "0x187520960")]
		public void SetTriggerParameter(string DDDMPLCOGIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
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
		public bool JBGOONGKDDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x88CDB0", Offset = "0x88B7B0", VA = "0x18088CDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AGDEHAKELPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xAAC090", Offset = "0xAAAA90", VA = "0x180AAC090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xBB7810", Offset = "0xBB6210", VA = "0x180BB7810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HHPLGFFEOOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xAAC080", Offset = "0xAAAA80", VA = "0x180AAC080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x232B4F0", Offset = "0x2329EF0", VA = "0x18232B4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KIDNJAJGHNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAC050", Offset = "0xAAAA50", VA = "0x180AAC050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x51022C0", Offset = "0x5100CC0", VA = "0x1851022C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7520A20", Offset = "0x751F420", VA = "0x187520A20")]
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
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[Tooltip("For screens and mobile players, moves the camera to frame the canvas.")]
			FrameScreensCanvas,
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[Tooltip("For screens and mobile players, moves the canvas and anchors it onto the camera.")]
			AnchorCanvasAsMenu
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public enum ControlPromptBehaviorType
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			[Tooltip("Let Rec Room decide whether or not to show control prompts for this UI.")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[Tooltip("Ensure all platforms see control prompts when looking at this UI.")]
			ForceOnAllPlatforms,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[Tooltip("No platforms will ever see control prompts when looking at this UI")]
			ForceSuppressAllPlatforms
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
		[Tooltip("The way in which the menu frames up on screen")]
		[ConditionallyVisibleField("canBeAnchored", true, false)]
		[SerializeField]
		private AttachmentMode anchorAttachmentMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[ConditionallyVisibleField("isInteractable", true, false)]
		[Tooltip("Optionally overwrite Rec Room's default behavior of when we show control hints while the cursor is over UI.")]
		[SerializeField]
		private ControlPromptBehaviorType controlPromptBehaviorOverride;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LELPJEAKKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool ADGMBLIGADI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC090", Offset = "0xAAAA90", VA = "0x180AAC090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool LJEIHMELDJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAAC080", Offset = "0xAAAA80", VA = "0x180AAC080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AttachmentMode PLEFPEFFAPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8AC4A0", Offset = "0x8AAEA0", VA = "0x1808AC4A0")]
			get
			{
				return default(AttachmentMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public ControlPromptBehaviorType AKDJCCBCMCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80")]
			get
			{
				return default(ControlPromptBehaviorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AttachmentMode> FOGFOHMHJNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7520A70", Offset = "0x751F470", VA = "0x187520A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7520BC0", Offset = "0x751F5C0", VA = "0x187520BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action DPAODPPLDDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7520B20", Offset = "0x751F520", VA = "0x187520B20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7520C70", Offset = "0x751F670", VA = "0x187520C70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7520A30", Offset = "0x751F430", VA = "0x187520A30")]
		public void AnchorCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7520A50", Offset = "0x751F450", VA = "0x187520A50")]
		public void DetachCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected RecRoomStudioCanvasInteractionBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public abstract class RecRoomStudioDisableRenderInShareCamPhotoBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public enum DisableRenderOptions
		{
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			NeverRender,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			OnlyDisableForJunior
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private DisableRenderOptions renderOptions;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool LCGKDFMKLHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x17B13C0", Offset = "0x17AFDC0", VA = "0x1817B13C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected RecRoomStudioDisableRenderInShareCamPhotoBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class RecRoomStudioHudCanvasBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected RecRoomStudioHudCanvasBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class RecRoomStudioInstanceRecolorBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[HideInInspector]
		[SerializeField]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private MeshRenderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static readonly int instanceColorID;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public IReadOnlyList<MeshRenderer> Renderers
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xE738F0", Offset = "0xE722F0", VA = "0x180E738F0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7521000", Offset = "0x751FA00", VA = "0x187521000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7520D10", Offset = "0x751F710", VA = "0x187520D10")]
		private void ApplyColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7520EB0", Offset = "0x751F8B0", VA = "0x187520EB0")]
		private void ClearColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7520E80", Offset = "0x751F880", VA = "0x187520E80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected RecRoomStudioInstanceRecolorBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class RecRoomStudioRecNetImageBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Tooltip("If true, the image will be automatically cropped into a square.")]
		[SerializeField]
		private bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private HOLFAJBKNAO ILMGPFPKNLC;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public HOLFAJBKNAO MAOJENHEFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x75219B0", Offset = "0x75203B0", VA = "0x1875219B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool BPMJJODJPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action JLCNPDMAOJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7521870", Offset = "0x7520270", VA = "0x187521870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7521910", Offset = "0x7520310", VA = "0x187521910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected RecRoomStudioRecNetImageBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class RecRoomUnitySceneSystemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected RecRoomUnitySceneSystemBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class RecRoomVisualPostProcessingBase : RecRoomUnitySceneSystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[ReadOnlyField]
		[SerializeField]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static RecRoomVisualPostProcessingBase MHOPBKMJKKN;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static RecRoomVisualPostProcessingBase GHBFIIGNNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7521C00", Offset = "0x7520600", VA = "0x187521C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x75219F0", Offset = "0x75203F0", VA = "0x1875219F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7521AD0", Offset = "0x75204D0", VA = "0x187521AD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected RecRoomVisualPostProcessingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyEnabledFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7519430", Offset = "0x7517E30", VA = "0x187519430")]
		public ConditionallyEnabledFieldAttribute(string propertyName, bool propertyValue, string disabledTooltip)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class GJBJFCDNKDK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x75196F0", Offset = "0x75180F0", VA = "0x1875196F0")]
	protected GJBJFCDNKDK(string PCFKMOBOMBL, bool KECCEDOIHIM)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyVisibleFieldAttribute : GJBJFCDNKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7519490", Offset = "0x7517E90", VA = "0x187519490")]
		public ConditionallyVisibleFieldAttribute(string propertyName, bool propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class IntConditionallyVisibleFieldAttribute : GJBJFCDNKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x751BF70", Offset = "0x751A970", VA = "0x18751BF70")]
		public IntConditionallyVisibleFieldAttribute(string propertyName, int propertyValue, bool isReadOnly = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface HOLFAJBKNAO
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string FMBKJIKKDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface DCCCHHIJCKI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AttachMarkupComponent(T KMMLNADJCOL, int CJBGEDHDMHO, bool LAFEIDEBPIJ);
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[ConditionallyEnabledField("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		[SerializeField]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[SerializeField]
		[ConditionallyEnabledField("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private RecRoomObjectPhysicsMode physicsMode;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7520170", Offset = "0x751EB70", VA = "0x187520170")]
		public RecRoomObjectConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum RecRoomObjectPhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
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
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC3E0", Offset = "0x2FFADE0", VA = "0x182FFC3E0")]
		public bool FJHIBPMOMDE<T>([Out] T IPHMAHBENGI, [Out] string EJIIMGEBDBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x75204E0", Offset = "0x751EEE0", VA = "0x1875204E0")]
		public static string LPCMIOCOMIA(Type NNEFLDDEJJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7520470", Offset = "0x751EE70", VA = "0x187520470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7520310", Offset = "0x751ED10", VA = "0x187520310")]
		public MethodInfo AIGHGBMOJMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7520380", Offset = "0x751ED80", VA = "0x187520380")]
		public string GHHOIONNEMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public abstract class RecRoomStudioAutoCreatedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x994550", Offset = "0x992F50", VA = "0x180994550")]
		protected RecRoomStudioAutoCreatedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class RecRoomStudioAutoGeneratedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x994550", Offset = "0x992F50", VA = "0x180994550")]
		public RecRoomStudioAutoGeneratedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class RecRoomStudioNavMeshCutBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public const float MINIMUM_WIDTH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[HideInInspector]
		[SerializeField]
		[Obsolete]
		private float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		[MGLMNFGHEGL("When using a Nav Mesh Cut, you may also want to set NavMesh Generation Mode to Ignore in the configure menu so the associated Rec Room Object won't bake into the navmesh on its own.")]
		private Vector3 size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private Vector3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		[Header("Optimization")]
		[MGLMNFGHEGL("Ignoring rotation leads to better performance, but ignoring rotation also means that the box must be aligned with the X, Y, and Z axes.")]
		private bool ignoreRotationAndScale;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[Obsolete]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x75213D0", Offset = "0x751FDD0", VA = "0x1875213D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x75216F0", Offset = "0x75200F0", VA = "0x1875216F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		[Obsolete]
		public float Height
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0A0", Offset = "0xAAAAA0", VA = "0x180AAC0A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7521650", Offset = "0x7520050", VA = "0x187521650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool IgnoreRotationAndScale
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x92EC70", Offset = "0x92D670", VA = "0x18092EC70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x75216D0", Offset = "0x75200D0", VA = "0x1875216D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Vector3 Size
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x916A30", Offset = "0x915430", VA = "0x180916A30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7521770", Offset = "0x7520170", VA = "0x187521770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float HeightSizeY
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0A0", Offset = "0xAAAAA0", VA = "0x180AAC0A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7521650", Offset = "0x7520050", VA = "0x187521650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public float XZUniformSquareSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x75217F0", Offset = "0x75201F0", VA = "0x1875217F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector3 Center
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xD77E90", Offset = "0xD76890", VA = "0x180D77E90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x75215D0", Offset = "0x751FFD0", VA = "0x1875215D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action OnSettingsChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7521330", Offset = "0x751FD30", VA = "0x187521330")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7521530", Offset = "0x751FF30", VA = "0x187521530")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OnForceUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7521290", Offset = "0x751FC90", VA = "0x187521290")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7521490", Offset = "0x751FE90", VA = "0x187521490")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> OnEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x75211E0", Offset = "0x751FBE0", VA = "0x1875211E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x75213E0", Offset = "0x751FDE0", VA = "0x1875213E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7521080", Offset = "0x751FA80", VA = "0x187521080")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x98CF00", Offset = "0x98B900", VA = "0x18098CF00")]
		[Obsolete]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x98CF00", Offset = "0x98B900", VA = "0x18098CF00")]
		public void ForceQueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7521170", Offset = "0x751FB70", VA = "0x187521170")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7521170", Offset = "0x751FB70", VA = "0x187521170")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x75211B0", Offset = "0x751FBB0", VA = "0x1875211B0")]
		protected RecRoomStudioNavMeshCutBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GMNNMKDHOIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public byte[] GDPEJEMCKCO;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	public GMNNMKDHOIA(byte[] HDOCILHNNDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct CHJJDKPOBNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public byte[] GDPEJEMCKCO;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	public CHJJDKPOBNJ(byte[] HDOCILHNNDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CKGGHIKJEGG
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x75156F0", Offset = "0x75140F0", VA = "0x1875156F0")]
	public static (GMNNMKDHOIA, CHJJDKPOBNJ) JOEHMDICHDD(Stream ECOBFOEFDNF)
	{
		return default((GMNNMKDHOIA, CHJJDKPOBNJ));
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7515920", Offset = "0x7514320", VA = "0x187515920")]
	public static void MKCPAGMKAFA(Stream ECOBFOEFDNF, GMNNMKDHOIA HCKNFILJEND, CHJJDKPOBNJ NDNMMDDAEMJ)
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
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x232A2C0", Offset = "0x2328CC0", VA = "0x18232A2C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E140", Offset = "0x6B6CB40", VA = "0x186B6E140")]
		public SerializedGuid([In] Guid OKMPNEEAGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E110", Offset = "0x6B6CB10", VA = "0x186B6E110", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7521CD0", Offset = "0x75206D0", VA = "0x187521CD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DEC0", Offset = "0x6B6C8C0", VA = "0x186B6DEC0", Slot = "7")]
		public bool Equals(SerializedGuid CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7521C40", Offset = "0x7520640", VA = "0x187521C40", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E000", Offset = "0x6B6CA00", VA = "0x186B6E000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DE30", Offset = "0x6B6C830", VA = "0x186B6DE30", Slot = "6")]
		public int CompareTo(SerializedGuid CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7521D50", Offset = "0x7520750", VA = "0x187521D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SerializedTypeNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public SerializedTypeNameAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class IPKJIEFCLPO
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static readonly CAFGMNLACIN EDBBENBJJPP;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly CAFGMNLACIN PAJBKMLAPHN;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public static readonly CAFGMNLACIN MDLFDBBHHNO;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static readonly CAFGMNLACIN NACIIEBFBNK;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly CAFGMNLACIN DGNPHPBPCDP;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly CAFGMNLACIN GGFMPNKBOML;
}
namespace RecRoom.Core.Studio.StudioFunctions
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static readonly Argument Void;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Parameter Binding
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public Argument()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
		public Argument(string DDDMPLCOGIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x75154F0", Offset = "0x7513EF0", VA = "0x1875154F0")]
		public object IOFDKNNPLLI(object[] FLNBBMKOHNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7515540", Offset = "0x7513F40", VA = "0x187515540")]
		internal void KPGPBNFBPAI(IReadOnlyList<Parameter> LFOFLLOHBIA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument<T> : Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		protected T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4436920", Offset = "0x4435320", VA = "0x184436920", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4436450", Offset = "0x4434E50", VA = "0x184436450")]
		protected Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[UnityEngine.Scripting.Preserve]
	public sealed class VoidArgument : Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static readonly VoidArgument Instance;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x7523070", Offset = "0x7521A70", VA = "0x187523070", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7522FF0", Offset = "0x75219F0", VA = "0x187522FF0")]
		private VoidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x4DA0870", Offset = "0x4D9F270", VA = "0x184DA0870", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3A92B20", Offset = "0x3A91520", VA = "0x183A92B20")]
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
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SerializeField]
		protected string valueTypeAssemblyQualifiedName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x589A910", Offset = "0x5899310", VA = "0x18589A910", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x589A670", Offset = "0x5899070", VA = "0x18589A670")]
		private Type KOBMHDJLLFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x39F2D50", Offset = "0x39F1750", VA = "0x1839F2D50")]
		protected ClassArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolArgument : ValueArgument<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7515670", Offset = "0x7514070", VA = "0x187515670")]
		public BoolArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorArgument : ValueArgument<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7518680", Offset = "0x7517080", VA = "0x187518680")]
		public ColorArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Argument : ValueArgument<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7518600", Offset = "0x7517000", VA = "0x187518600")]
		public Color32Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[UnityEngine.Scripting.Preserve]
	public sealed class GuidArgument : ValueArgument<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x751B2B0", Offset = "0x7519CB0", VA = "0x18751B2B0")]
		public GuidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatArgument : ValueArgument<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7519610", Offset = "0x7518010", VA = "0x187519610")]
		public FloatArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntArgument : ValueArgument<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x751BF30", Offset = "0x751A930", VA = "0x18751BF30")]
		public IntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ShortArgument : ValueArgument<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7521D60", Offset = "0x7520760", VA = "0x187521D60")]
		public ShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringArgument : ValueArgument<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7521DA0", Offset = "0x75207A0", VA = "0x187521DA0")]
		public StringArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UIntArgument : ValueArgument<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7522AD0", Offset = "0x75214D0", VA = "0x187522AD0")]
		public UIntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UShortArgument : ValueArgument<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7522B10", Offset = "0x7521510", VA = "0x187522B10")]
		public UShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Argument : ValueArgument<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7522D90", Offset = "0x7521790", VA = "0x187522D90")]
		public Vector2Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Argument : ValueArgument<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7522E10", Offset = "0x7521810", VA = "0x187522E10")]
		public Vector3Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionArgument : ValueArgument<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x751DFD0", Offset = "0x751C9D0", VA = "0x18751DFD0")]
		public QuaternionArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UnityObjectArgument : ClassArgument<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7522C10", Offset = "0x7521610", VA = "0x187522C10")]
		public UnityObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageArgument : ValueArgument<HOLFAJBKNAO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x751E050", Offset = "0x751CA50", VA = "0x18751E050")]
		public RecNetImageArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void CPLCIOOIDJC(string CJIAPFOBJOD, object[] FLNBBMKOHNM, object[] ODMIGPCMBOC);

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected internal abstract void GJDLOPFOGIN(IReadOnlyList<Parameter> LFOFLLOHBIA, IReadOnlyList<Parameter> KDEIPJICKNJ);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		protected Instruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		public override void CPLCIOOIDJC(string CJIAPFOBJOD, object[] FLNBBMKOHNM, object[] ODMIGPCMBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		protected internal override void GJDLOPFOGIN(IReadOnlyList<Parameter> LFOFLLOHBIA, IReadOnlyList<Parameter> KDEIPJICKNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PlaceholderInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[UnityEngine.Scripting.Preserve]
	public sealed class CallInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private delegate void KOMOMGOCCLL(UnityEngine.Object CDHECNAFHCH, MethodInfo GNGBIGNGMGD, object[] NHIKKGCDHBD);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[SerializeField]
		private UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[SerializeReference]
		private Argument[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[SerializeReference]
		private Argument result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private MethodInfo GAME_CLIENT_ONLY_resolvedMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static readonly MethodInfo InvalidMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private static object[][] argumentValueArrays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private KOMOMGOCCLL optimization;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private static readonly MethodInfo Animator_SetBool_name_value;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private static readonly MethodInfo Animator_SetBool_id_value;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private static readonly MethodInfo Animator_SetFloat_name_value;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly MethodInfo Animator_SetFloat_id_value;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly MethodInfo Animator_SetFloat_name_value_dampTime_deltaTime;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly MethodInfo Animator_SetFloat_id_value_dampTime_deltaTime;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private static readonly MethodInfo Animator_SetInteger_name_value;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private static readonly MethodInfo Animator_SetInteger_id_value;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private static readonly Dictionary<MethodInfo, KOMOMGOCCLL> optimizations;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly Dictionary<string, int> cachedAnimatorStringToHashResults;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7518580", Offset = "0x7516F80", VA = "0x187518580")]
		public CallInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x75161D0", Offset = "0x7514BD0", VA = "0x1875161D0", Slot = "4")]
		public override void CPLCIOOIDJC(string CJIAPFOBJOD, object[] FLNBBMKOHNM, object[] ODMIGPCMBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7516CC0", Offset = "0x75156C0", VA = "0x187516CC0")]
		private void IJNMDJBKHGK(object[] ODMIGPCMBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7517270", Offset = "0x7515C70", VA = "0x187517270")]
		private void LFBFKHNKAIJ(object[] ODMIGPCMBOC, object PPBJHAHNJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x75169D0", Offset = "0x75153D0", VA = "0x1875169D0", Slot = "5")]
		protected internal override void GJDLOPFOGIN(IReadOnlyList<Parameter> LFOFLLOHBIA, IReadOnlyList<Parameter> KDEIPJICKNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x75177D0", Offset = "0x75161D0", VA = "0x1875177D0")]
		[UnityEngine.Scripting.Preserve]
		private static void PNBDCLJPFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7517530", Offset = "0x7515F30", VA = "0x187517530")]
		private MethodInfo PFAOEEBLKMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x75171E0", Offset = "0x7515BE0", VA = "0x1875171E0")]
		internal MethodInfo KGJEKMKPHLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7515AE0", Offset = "0x75144E0", VA = "0x187515AE0")]
		internal static bool AEGDBNJLODG(UnityEngine.Object CDHECNAFHCH, string ODEIKLCGKJP, Argument[] PKMHPILPCEB, [Out] MethodInfo GNGBIGNGMGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7516D70", Offset = "0x7515770", VA = "0x187516D70")]
		private static bool IMCDIKHEHMP(MethodInfo GNGBIGNGMGD, Type[] BLKMACMKFHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7516B00", Offset = "0x7515500", VA = "0x187516B00")]
		private static object[] HPCMOMFCLII(int LMDNJBKJCFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7517660", Offset = "0x7516060", VA = "0x187517660")]
		private object[] PGCDIAKNKHA(object[] FLNBBMKOHNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x75167D0", Offset = "0x75151D0", VA = "0x1875167D0")]
		private void DOJLHOLHFKB(object[] NHIKKGCDHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x75160A0", Offset = "0x7514AA0", VA = "0x1875160A0")]
		private static void CLLJONPEALA(UnityEngine.Object CDHECNAFHCH, MethodInfo GNGBIGNGMGD, object[] NHIKKGCDHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7515F70", Offset = "0x7514970", VA = "0x187515F70")]
		private static void BJLJJKLPJKL(UnityEngine.Object CDHECNAFHCH, MethodInfo GNGBIGNGMGD, object[] NHIKKGCDHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7516830", Offset = "0x7515230", VA = "0x187516830")]
		private static void DOMEJBKMDEJ(UnityEngine.Object CDHECNAFHCH, MethodInfo GNGBIGNGMGD, object[] NHIKKGCDHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7517400", Offset = "0x7515E00", VA = "0x187517400")]
		private static void ODMCJHIFMKF(UnityEngine.Object CDHECNAFHCH, MethodInfo GNGBIGNGMGD, object[] NHIKKGCDHBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7516E80", Offset = "0x7515880", VA = "0x187516E80")]
		private static MethodInfo JKFMBEJOFLI(Type MDPMDIOLJGM, string ODEIKLCGKJP, params Type[] DMGCBHFEKHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7517310", Offset = "0x7515D10", VA = "0x187517310")]
		private static int MGLFOKJIKLJ(string DDDMPLCOGIM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7516960", Offset = "0x7515360", VA = "0x187516960")]
		public static void FKDGLFPFJPG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ConditionalInstruction : Instruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private Condition[] conditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeReference]
		private Instruction[] @default;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x75193B0", Offset = "0x7517DB0", VA = "0x1875193B0")]
		public ConditionalInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7518C80", Offset = "0x7517680", VA = "0x187518C80", Slot = "4")]
		public override void CPLCIOOIDJC(string CJIAPFOBJOD, object[] FLNBBMKOHNM, object[] ODMIGPCMBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x75190B0", Offset = "0x7517AB0", VA = "0x1875190B0", Slot = "5")]
		protected internal override void GJDLOPFOGIN(IReadOnlyList<Parameter> LFOFLLOHBIA, IReadOnlyList<Parameter> KDEIPJICKNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7519340", Offset = "0x7517D40", VA = "0x187519340")]
		private void KPGPBNFBPAI(IReadOnlyList<Parameter> LFOFLLOHBIA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Condition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public IReadOnlyList<Instruction> Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7518C30", Offset = "0x7517630", VA = "0x187518C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7518BB0", Offset = "0x75175B0", VA = "0x187518BB0")]
		public Condition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7518900", Offset = "0x7517300", VA = "0x187518900")]
		public static bool GALBCPDBAKE(string IPHMAHBENGI, [Out] bool IGEMGFOOOBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7518AE0", Offset = "0x75174E0", VA = "0x187518AE0")]
		public static bool OCLCGLDOHAI(string IPHMAHBENGI, [Out] int CNGEJFLBKEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x75189D0", Offset = "0x75173D0", VA = "0x1875189D0")]
		public bool HAOHHGIMKIL(bool JEDHOLIJMJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7518820", Offset = "0x7517220", VA = "0x187518820")]
		public bool ECOFBNAKFBL(int DGAGBCOINMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7518AC0", Offset = "0x75174C0", VA = "0x187518AC0")]
		public bool NJLIEAGLMMM(string ACDEPBCNCIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7518790", Offset = "0x7517190", VA = "0x187518790")]
		public void CPLCIOOIDJC(string CJIAPFOBJOD, object[] FLNBBMKOHNM, object[] ODMIGPCMBOC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xD6B100", Offset = "0xD69B00", VA = "0x180D6B100")]
		public Parameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x751DE90", Offset = "0x751C890", VA = "0x18751DE90")]
		internal void MNKLHHCHGGM(int MFDOCMEONNC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderParameter : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x751DF70", Offset = "0x751C970", VA = "0x18751DF70", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter<T> : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x49CED20", Offset = "0x49CD720", VA = "0x1849CED20")]
		protected Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x4DFEB20", Offset = "0x4DFD520", VA = "0x184DFEB20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3A92B20", Offset = "0x3A91520", VA = "0x183A92B20")]
		protected ValueParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private string valueTypeFullName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x589AA40", Offset = "0x5899440", VA = "0x18589AA40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x589A980", Offset = "0x5899380", VA = "0x18589A980")]
		private Type KOBMHDJLLFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x39F2D50", Offset = "0x39F1750", VA = "0x1839F2D50")]
		protected ClassParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolParameter : ValueParameter<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x75156B0", Offset = "0x75140B0", VA = "0x1875156B0")]
		public BoolParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorParameter : ValueParameter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x75186C0", Offset = "0x75170C0", VA = "0x1875186C0")]
		public ColorParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Parameter : ValueParameter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7518640", Offset = "0x7517040", VA = "0x187518640")]
		public Color32Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatParameter : ValueParameter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7519650", Offset = "0x7518050", VA = "0x187519650")]
		public FloatParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntParameter : ValueParameter<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x751BFD0", Offset = "0x751A9D0", VA = "0x18751BFD0")]
		public IntParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringParameter : ValueParameter<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7521DE0", Offset = "0x75207E0", VA = "0x187521DE0")]
		public StringParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Parameter : ValueParameter<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7522DD0", Offset = "0x75217D0", VA = "0x187522DD0")]
		public Vector2Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Parameter : ValueParameter<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7522E50", Offset = "0x7521850", VA = "0x187522E50")]
		public Vector3Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionParameter : ValueParameter<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x751E010", Offset = "0x751CA10", VA = "0x18751E010")]
		public QuaternionParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageParameter : ValueParameter<HOLFAJBKNAO>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x751E090", Offset = "0x751CA90", VA = "0x18751E090")]
		public RecNetImageParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StudioFunction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeReference]
		private Parameter[] parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeReference]
		private Parameter[] results;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private bool GAME_CLIENT_ONLY_didAssignParameterIndices;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7522830", Offset = "0x7521230", VA = "0x187522830")]
		public StudioFunction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x75222D0", Offset = "0x7520CD0", VA = "0x1875222D0")]
		public void CPLCIOOIDJC(object[] FLNBBMKOHNM, object[] ODMIGPCMBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7522530", Offset = "0x7520F30", VA = "0x187522530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7522190", Offset = "0x7520B90", VA = "0x187522190")]
		private void BCKAEEIJGNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x75224C0", Offset = "0x7520EC0", VA = "0x1875224C0")]
		private void GJDLOPFOGIN()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[UnityEngine.Scripting.Preserve]
	public class StudioFunctionList : IReadOnlyList<StudioFunction>, IEnumerable<StudioFunction>, IEnumerable, IReadOnlyCollection<StudioFunction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		[HideInInspector]
		private StudioFunction[] array;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private IReadOnlyList<StudioFunction> ReadOnlyList
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x7522140", Offset = "0x7520B40", VA = "0x187522140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x7521F70", Offset = "0x7520970", VA = "0x187521F70", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public StudioFunction this[int ENMILGHAHOM]
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x7522060", Offset = "0x7520A60", VA = "0x187522060", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7521E20", Offset = "0x7520820", VA = "0x187521E20", Slot = "6")]
		public IEnumerator<StudioFunction> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7521EA0", Offset = "0x75208A0", VA = "0x187521EA0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7521F20", Offset = "0x7520920", VA = "0x187521F20")]
		public StudioFunctionList()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class KJAGDLMDAIO
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x751C050", Offset = "0x751AA50", VA = "0x18751C050")]
	public static string JNCFJCNILOO(this Type AOGCIMANLIJ)
	{
		return null;
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class RecRoomStudioAvatarItemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
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
