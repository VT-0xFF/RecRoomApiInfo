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
using TMPro;
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
	public class LogRegistrationIndex : FEPIOKBKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7849660", Offset = "0x7848660", VA = "0x187849660", Slot = "4")]
		public override void EPIGOBOFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct JPNMNFDKPNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 GBMBLDFBAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion JKJHCABJJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 JLIODFHPCAP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7847710", Offset = "0x7846710", VA = "0x187847710")]
	public bool AANJNOENOEJ(Collider MMLIMBGJNAP, Bounds JOEJONILJIO, bool MOHIIIOKMGJ, bool AKLNBOFBAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7847C80", Offset = "0x7846C80", VA = "0x187847C80")]
	public bool HANJADFIEBN(Collider JGODMBGCENL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78481C0", Offset = "0x78471C0", VA = "0x1878481C0")]
	public bool MBLCFFMMJLC(Collider JGODMBGCENL, bool MOHIIIOKMGJ, bool AKLNBOFBAAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7847CA0", Offset = "0x7846CA0", VA = "0x187847CA0")]
	public void HDLENFHCCGA(Transform JJJGJKKAJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7848780", Offset = "0x7847780", VA = "0x187848780")]
	public void OIDCKMAKNOJ(JPNMNFDKPNC DFABCHNPEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7847D50", Offset = "0x7846D50", VA = "0x187847D50")]
	private static void IBNJOJNLOBA(Vector3 JCGGLMFLBCP, Vector3 PLFLOPDIPGH, Vector3 JADOFHDDGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7847DD0", Offset = "0x7846DD0", VA = "0x187847DD0")]
	public static JPNMNFDKPNC IKDABBEIMPD(GameObject BAOAKGNNKEP, Quaternion JKJHCABJJIO, bool ODMKGDMEBPB, bool IPNCBHEALGP, bool MOHIIIOKMGJ = false, bool AKLNBOFBAAG = false, bool KEDDEHDBDGJ = false)
	{
		return default(JPNMNFDKPNC);
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
public enum CGAEECEPKJO
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
public static class AHBDFCNCAIN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string KMEFKFPEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7842680", Offset = "0x7841680", VA = "0x187842680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string FJBEAFDNGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7842650", Offset = "0x7841650", VA = "0x187842650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string IEJJMCBCGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7842620", Offset = "0x7841620", VA = "0x187842620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x78426B0", Offset = "0x78416B0", VA = "0x1878426B0")]
	public static CGAEECEPKJO LNHEKOGPNDN(this CGAEECEPKJO HBGABPDKBEI)
	{
		return default(CGAEECEPKJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x78426B0", Offset = "0x78416B0", VA = "0x1878426B0")]
	public static int LNHEKOGPNDN(int HBGABPDKBEI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BMCFFHNCFCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	AudioMixerGroup NEOONJNCGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BMCFFHNCFCJ CDPDLODOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IReadOnlyList<BMCFFHNCFCJ> PNAPELGBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string AHNCEDPGMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CHPFKLEBIFG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class EAAPPDBKILJ : BMCFFHNCFCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal readonly List<BMCFFHNCFCJ> AOGGLHAMHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal readonly EAAPPDBKILJ KBGEBIEKMOH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BMCFFHNCFCJ CDPDLODOOCM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AudioMixerGroup NEOONJNCGNC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<BMCFFHNCFCJ> PNAPELGBIHP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string AHNCEDPGMBE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7847270", Offset = "0x7846270", VA = "0x187847270")]
		internal EAAPPDBKILJ(AudioMixerGroup OANGBAAODID, EAAPPDBKILJ JNLBEALAMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BMCFFHNCFCJ HGIKPJKEBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AudioMixer MDJBFGCHJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7843250", Offset = "0x7842250", VA = "0x187843250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	private CHPFKLEBIFG(EAAPPDBKILJ FDIFHDCBDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7843010", Offset = "0x7842010", VA = "0x187843010")]
	public static CHPFKLEBIFG NPGALDHHPJI(AudioMixer BDEFMMBABOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7842C70", Offset = "0x7841C70", VA = "0x187842C70")]
	public BMCFFHNCFCJ MHOMHFCDHLA(string OJLEBCHNGJF, bool NBKGGANHNAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x78429E0", Offset = "0x78419E0", VA = "0x1878429E0")]
	public BMCFFHNCFCJ MHOMHFCDHLA(AudioMixerGroup OANGBAAODID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7842960", Offset = "0x7841960", VA = "0x187842960")]
	private static int CJMAIIJJOKA(string MBDMHLKHKIH, int NOAHCMMOGGC)
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
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasBeenTranslated
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E50", Offset = "0x8B8E50", VA = "0x1808B9E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8BA040", Offset = "0x8B9040", VA = "0x1808BA040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x49A2210", Offset = "0x49A1210", VA = "0x1849A2210")]
		public MaterialEntry EJEHBCKLMFI(Material BIDMCIBAHOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x49A21E0", Offset = "0x49A11E0", VA = "0x1849A21E0")]
		public void DOGLDKIIMGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFEA0", Offset = "0x3CBEEA0", VA = "0x183CBFEA0")]
		public MaterialMapAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class MaterialMapBase<TMaterialMapAsset> : RecRoomUnitySceneSystemBase where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static MaterialMapBase<TMaterialMapAsset> DKOIJBOMAJG;

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
		public static MaterialMapBase<TMaterialMapAsset> LONLOOPDCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x49A27F0", Offset = "0x49A17F0", VA = "0x1849A27F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MaterialEntry[] AODBKHKDOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x49A2710", Offset = "0x49A1710", VA = "0x1849A2710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x49A2300", Offset = "0x49A1300", VA = "0x1849A2300")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x49A2620", Offset = "0x49A1620", VA = "0x1849A2620")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x49A2530", Offset = "0x49A1530", VA = "0x1849A2530")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x49A24E0", Offset = "0x49A14E0", VA = "0x1849A24E0")]
		public void ClearSceneMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D20A0", Offset = "0x8D10A0", VA = "0x1808D20A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x784FAB0", Offset = "0x784EAB0", VA = "0x18784FAB0", Slot = "4")]
		public bool Equals(TextureProperty DFABCHNPEEM)
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
		[Cpp2IlInjected.Address(RVA = "0x7847510", Offset = "0x7846510", VA = "0x187847510", Slot = "4")]
		public bool Equals(FloatProperty DFABCHNPEEM)
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
		[Cpp2IlInjected.Address(RVA = "0x7850050", Offset = "0x784F050", VA = "0x187850050", Slot = "4")]
		public bool Equals(VectorProperty DFABCHNPEEM)
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
		[Cpp2IlInjected.Address(RVA = "0x7846430", Offset = "0x7845430", VA = "0x187846430", Slot = "4")]
		public bool Equals(ColorProperty DFABCHNPEEM)
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
		[Cpp2IlInjected.Address(RVA = "0x78496F0", Offset = "0x78486F0", VA = "0x1878496F0")]
		public void CBILFGDKAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7849D60", Offset = "0x7848D60", VA = "0x187849D60")]
		public float NDFLDJCHAFE(int EICNKJDFBND)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7849D10", Offset = "0x7848D10", VA = "0x187849D10")]
		public Texture KPEJHFDLMJH(int EICNKJDFBND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7849A80", Offset = "0x7848A80", VA = "0x187849A80")]
		public Vector4 EJBLOILJKIN(int EICNKJDFBND)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7849C90", Offset = "0x7848C90", VA = "0x187849C90")]
		public Color HFHENBEMHNL(int EICNKJDFBND)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7849B30", Offset = "0x7848B30", VA = "0x187849B30", Slot = "4")]
		public bool Equals(MaterialEntry DFABCHNPEEM)
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
			[Cpp2IlInjected.Address(RVA = "0x4D75CF0", Offset = "0x4D74CF0", VA = "0x184D75CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x41629B0", Offset = "0x41619B0", VA = "0x1841629B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AddComponentMenu(null)]
	public abstract class RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> : RecRoomUnitySceneSystemBase where TAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> DKOIJBOMAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[ReadOnlyField]
		private TAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> LONLOOPDCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x49A27F0", Offset = "0x49A17F0", VA = "0x1849A27F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public TAudioClipRegistryAsset AODBKHKDOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IReadOnlyList<RecRoomAudioClipEntry> MJCDPNENOFM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4D75FF0", Offset = "0x4D74FF0", VA = "0x184D75FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D40", Offset = "0x4D74D40", VA = "0x184D75D40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4D75E70", Offset = "0x4D74E70", VA = "0x184D75E70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D20A0", Offset = "0x8D10A0", VA = "0x1808D20A0")]
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
		private static readonly Dictionary<AudioMixerGroupType, string> JGGMNOGKKOH;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string MMFLJHDFEPL = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string DONCCGHCMPC = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const string LLPDGKOCGMM = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly string LPLENJDLNHM;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string DDBIAJNEKMK;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static RecRoomAudioMixerRegistryBase DKOIJBOMAJG;

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
		[IntConditionallyVisibleField("version", 0, false)]
		[SerializeField]
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
		public static RecRoomAudioMixerRegistryBase LONLOOPDCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x784C0B0", Offset = "0x784B0B0", VA = "0x18784C0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AudioMixer FCHLICJBPEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool GIKNMPKMNJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x784C100", Offset = "0x784B100", VA = "0x18784C100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public MixerVersion ECKOFMKJNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390")]
			get
			{
				return default(MixerVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x784C250", Offset = "0x784B250", VA = "0x18784C250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x784B470", Offset = "0x784A470", VA = "0x18784B470")]
		public static string GetAudioGroupPath(AudioMixerGroupType JGAGAPHJNFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x784B590", Offset = "0x784A590", VA = "0x18784B590")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroupType JGAGAPHJNFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x784BD80", Offset = "0x784AD80", VA = "0x18784BD80")]
		private static AudioMixerGroup PMMFCGEFLKM(AudioMixer BDEFMMBABOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x784B1F0", Offset = "0x784A1F0", VA = "0x18784B1F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x784BC20", Offset = "0x784AC20", VA = "0x18784BC20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x784B770", Offset = "0x784A770", VA = "0x18784B770")]
		public bool IsValidOutputGroup(AudioMixerGroup PNPEFCMGGAE, [Out] string IPLILPPMPOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x784B300", Offset = "0x784A300", VA = "0x18784B300")]
		private bool BMEHBFPBHHO(AudioMixerGroup PNPEFCMGGAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x784B9B0", Offset = "0x784A9B0", VA = "0x18784B9B0")]
		private bool NMDJKFJOHBO(AudioMixerGroup BAHCLGOGNPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
		[SerializeField]
		[HideInInspector]
		private Transform deformationTransform;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Guid GFPLKADBNKC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x784C390", Offset = "0x784B390", VA = "0x18784C390")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x784C400", Offset = "0x784B400", VA = "0x18784C400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool MBGHGHKJEGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x784C370", Offset = "0x784B370", VA = "0x18784C370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool KOKGBIMGHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x784C320", Offset = "0x784B320", VA = "0x18784C320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Transform IDAJCDDAJJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8BA020", VA = "0x1808BB020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		public byte[] GetSpawnableTemplateData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
		public void SetSpawnableTemplateData(byte[] OIIFMHOHFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8E3010", Offset = "0x8E2010", VA = "0x1808E3010")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D76210", Offset = "0x4D75210", VA = "0x184D76210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IReadOnlyDictionary<Guid, TRecRoomBuiltInObject> AllBuiltInObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4072D30", Offset = "0x4071D30", VA = "0x184072D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4D761A0", Offset = "0x4D751A0", VA = "0x184D761A0")]
		public void MDAFFEOIPDD(IEnumerable<TRecRoomBuiltInObject> CHDPBCDNBDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4D760E0", Offset = "0x4D750E0", VA = "0x184D760E0")]
		public bool JIBJJFGCKGK(Guid JPIDHBIAICG, [Out] TRecRoomBuiltInObject DBEMDOJAODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x975580", VA = "0x180976580")]
		protected RecRoomBuiltInObjectDataBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class RecRoomObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class GCNMADLMMIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public bool value;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public GCNMADLMMIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7847570", Offset = "0x7846570", VA = "0x187847570")]
			internal bool BKPJBNLFOCL(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class BGIONMCNECF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float value;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public BGIONMCNECF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x78428B0", Offset = "0x78418B0", VA = "0x1878428B0")]
			internal bool BKPJBNLFOCL(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PGDMKAMPMNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public int value;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public PGDMKAMPMNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x784AF80", Offset = "0x7849F80", VA = "0x18784AF80")]
			internal bool BKPJBNLFOCL(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class HKONBHCEFLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public string value;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public HKONBHCEFLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x78475F0", Offset = "0x78465F0", VA = "0x1878475F0")]
			internal bool BKPJBNLFOCL(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class KNJLGHJNDCF : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DCF0", VA = "0x18090ECF0")]
			[DebuggerHidden]
			public KNJLGHJNDCF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7849070", Offset = "0x7848070", VA = "0x187849070", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7849220", Offset = "0x7848220", VA = "0x187849220", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7849160", Offset = "0x7848160", VA = "0x187849160", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7849160", Offset = "0x7848160", VA = "0x187849160", Slot = "5")]
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
		private Dictionary<string, RecRoomObjectProperty> FBAIKEHAGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		[HideInInspector]
		private StudioFunctionList studioFunctions;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RecRoomObjectProperty[] LBDIDFDPFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NamedUnityEventBase[] JLJNEIPFGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public RecRoomObjectConfiguration AOOPNAJEOEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x784D160", Offset = "0x784C160", VA = "0x18784D160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<StudioFunction> PAMOKNGIIPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObjectBase, string> ICAMIJJNLNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x784D0B0", Offset = "0x784C0B0", VA = "0x18784D0B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x784D1E0", Offset = "0x784C1E0", VA = "0x18784D1E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x784C740", Offset = "0x784B740", VA = "0x18784C740")]
		public bool TryGetProperty(string ODFHIAEGOOC, [Out] RecRoomObjectProperty EDBGKLDPNAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x784C720", Offset = "0x784B720", VA = "0x18784C720")]
		public void SendCircuitsEvent(string AFPIKPJILNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x784C900", Offset = "0x784B900", VA = "0x18784C900")]
		public bool TryRaiseUnityEvent(string AFPIKPJILNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3220F00", Offset = "0x321FF00", VA = "0x183220F00")]
		private bool KIDMDHDHMIE<T0, T1, TEvent>(string AFPIKPJILNJ, T0 IDOOBHKKHHD, T1 OJEDBBAAEME) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x784CEC0", Offset = "0x784BEC0", VA = "0x18784CEC0")]
		public bool TryRaiseUnityEvent(string AFPIKPJILNJ, bool BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x784CDE0", Offset = "0x784BDE0", VA = "0x18784CDE0")]
		public bool TryRaiseUnityEvent(string AFPIKPJILNJ, float BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x784CC30", Offset = "0x784BC30", VA = "0x18784CC30")]
		public bool TryRaiseUnityEvent(string AFPIKPJILNJ, int BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x784CAE0", Offset = "0x784BAE0", VA = "0x18784CAE0")]
		public bool TryRaiseUnityEvent(string AFPIKPJILNJ, string BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x784CD00", Offset = "0x784BD00", VA = "0x18784CD00")]
		public bool TryRaiseUnityEvent(string AFPIKPJILNJ, string IDOOBHKKHHD, bool OJEDBBAAEME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x784CF90", Offset = "0x784BF90", VA = "0x18784CF90")]
		public bool TryRaiseUnityEvent(string AFPIKPJILNJ, string IDOOBHKKHHD, float OJEDBBAAEME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x784CBC0", Offset = "0x784BBC0", VA = "0x18784CBC0")]
		public bool TryRaiseUnityEvent(string AFPIKPJILNJ, string IDOOBHKKHHD, int OJEDBBAAEME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x784CD70", Offset = "0x784BD70", VA = "0x18784CD70")]
		public bool TryRaiseUnityEvent(string AFPIKPJILNJ, string IDOOBHKKHHD, string OJEDBBAAEME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x784C480", Offset = "0x784B480", VA = "0x18784C480")]
		[IteratorStateMachine(typeof(KNJLGHJNDCF))]
		private IEnumerable<NamedUnityEventBase> DKHIIFIHFMG(string AFPIKPJILNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x784C520", Offset = "0x784B520", VA = "0x18784C520")]
		private bool HECBHMJBKLL(string AFPIKPJILNJ, Func<NamedUnityEventBase, bool> OEEIPOEKELP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x784D000", Offset = "0x784C000", VA = "0x18784D000")]
		protected RecRoomObjectBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x784FD10", Offset = "0x784ED10", VA = "0x18784FD10")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x784FD50", Offset = "0x784ED50", VA = "0x18784FD50")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x784FD90", Offset = "0x784ED90", VA = "0x18784FD90")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x784FE50", Offset = "0x784EE50", VA = "0x18784FE50")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x784FE10", Offset = "0x784EE10", VA = "0x18784FE10")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x784FED0", Offset = "0x784EED0", VA = "0x18784FED0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x784FE90", Offset = "0x784EE90", VA = "0x18784FE90")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x784FF10", Offset = "0x784EF10", VA = "0x18784FF10")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "5")]
		public virtual bool TryInvokeEvent(bool BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "6")]
		public virtual bool TryInvokeEvent(float BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "7")]
		public virtual bool TryInvokeEvent(int BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "8")]
		public virtual bool TryInvokeEvent(string BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4A04970", Offset = "0x4A03970", VA = "0x184A04970")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
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
		[Cpp2IlInjected.Address(RVA = "0x784A3B0", Offset = "0x78493B0", VA = "0x18784A3B0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x784A480", Offset = "0x7849480", VA = "0x18784A480")]
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
		[Cpp2IlInjected.Address(RVA = "0x41629B0", Offset = "0x41619B0", VA = "0x1841629B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x41629B0", Offset = "0x41619B0", VA = "0x1841629B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7849DB0", Offset = "0x7848DB0", VA = "0x187849DB0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7849E10", Offset = "0x7848E10", VA = "0x187849E10", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7849F70", Offset = "0x7848F70", VA = "0x187849F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7849FB0", Offset = "0x7848FB0", VA = "0x187849FB0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x784A010", Offset = "0x7849010", VA = "0x18784A010", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x784A170", Offset = "0x7849170", VA = "0x18784A170")]
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
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x784A1B0", Offset = "0x78491B0", VA = "0x18784A1B0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x784A210", Offset = "0x7849210", VA = "0x18784A210", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x784A370", Offset = "0x7849370", VA = "0x18784A370")]
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
		[Cpp2IlInjected.Address(RVA = "0x784A6F0", Offset = "0x78496F0", VA = "0x18784A6F0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x784A750", Offset = "0x7849750", VA = "0x18784A750", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x784A8B0", Offset = "0x78498B0", VA = "0x18784A8B0")]
		protected NamedUnityStringEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[UnityEngine.Scripting.Preserve]
	[SerializedTypeName]
	public abstract class NamedUnityStringBooleanEventBase : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x784A4C0", Offset = "0x78494C0", VA = "0x18784A4C0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x784A520", Offset = "0x7849520", VA = "0x18784A520", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x784A6B0", Offset = "0x78496B0", VA = "0x18784A6B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x784A8F0", Offset = "0x78498F0", VA = "0x18784A8F0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x784A950", Offset = "0x7849950", VA = "0x18784A950", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x784AAE0", Offset = "0x7849AE0", VA = "0x18784AAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x784AB20", Offset = "0x7849B20", VA = "0x18784AB20", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x784AB80", Offset = "0x7849B80", VA = "0x18784AB80", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x784AD10", Offset = "0x7849D10", VA = "0x18784AD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x784AD50", Offset = "0x7849D50", VA = "0x18784AD50", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x784ADB0", Offset = "0x7849DB0", VA = "0x18784ADB0", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x784AF40", Offset = "0x7849F40", VA = "0x18784AF40")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x41629B0", Offset = "0x41619B0", VA = "0x1841629B0")]
		public RecRoomObjectPrefabRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> : RecRoomUnitySceneSystemBase where TPrefabAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject>, new() where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> DKOIJBOMAJG;

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
		public static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> LONLOOPDCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x49A27F0", Offset = "0x49A17F0", VA = "0x1849A27F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<TPrefabEntry> DBBHOJLCKKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4D76AD0", Offset = "0x4D75AD0", VA = "0x184D76AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4D76820", Offset = "0x4D75820", VA = "0x184D76820")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4D76950", Offset = "0x4D75950", VA = "0x184D76950")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D20A0", Offset = "0x8D10A0", VA = "0x1808D20A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D76770", Offset = "0x4D75770", VA = "0x184D76770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RecRoomObjectPrefabObjectBoardTemplate ObjectBoardTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HasObjectBoardData
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x4D76710", Offset = "0x4D75710", VA = "0x184D76710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4D764A0", Offset = "0x4D754A0", VA = "0x184D764A0", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabEntryBase<TRecRoomObject> DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4D76620", Offset = "0x4D75620", VA = "0x184D76620", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4D766F0", Offset = "0x4D756F0", VA = "0x184D766F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] ObjectBoard
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x784D3E0", Offset = "0x784C3E0", VA = "0x18784D3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x784D320", Offset = "0x784C320", VA = "0x18784D320", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabObjectBoardTemplate DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x784D2A0", Offset = "0x784C2A0", VA = "0x18784D2A0")]
		private static bool BGHGMOIBGOG(byte[] HFMHIKDLBBN, byte[] BGAEMJIILPK)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class RecRoomStudioAnimatorSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public interface LAELKPMLHEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SetBoolParameterFromScript(string DMCFPOLFNCF, bool ADMAMDKLPIC);

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SetIntegerParameterFromScript(string DMCFPOLFNCF, int ADMAMDKLPIC);

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetFloatParameterFromScript(string DMCFPOLFNCF, float ADMAMDKLPIC);

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SetTriggerParameterFromScript(string DMCFPOLFNCF);
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public LAELKPMLHEC LKJIMBDFAHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x784D7F0", Offset = "0x784C7F0", VA = "0x18784D7F0")]
		public Animator GetControlledAnimator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x784D830", Offset = "0x784C830", VA = "0x18784D830")]
		public void SetBoolParameter(string DMCFPOLFNCF, bool ADMAMDKLPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x784D9C0", Offset = "0x784C9C0", VA = "0x18784D9C0")]
		public void SetIntegerParameter(string DMCFPOLFNCF, int ADMAMDKLPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x784D8F0", Offset = "0x784C8F0", VA = "0x18784D8F0")]
		public void SetFloatParameter(string DMCFPOLFNCF, float ADMAMDKLPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x784DA80", Offset = "0x784CA80", VA = "0x18784DA80")]
		public void SetTriggerParameter(string DMCFPOLFNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
		[Tooltip("If true, the object can look up/down to face the player (x-axis rotation)")]
		[SerializeField]
		private bool pitchRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("If true, the object can rotate clockwise/counter-clockwise to match the players rotation (z-axis rotation)")]
		[SerializeField]
		private bool rollRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		[Tooltip("If true, makes the player \"look through\" the object rather than \"look at\" the object to accomadate Unity UI expectations")]
		private bool faceAwayFromCamera;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CGCPLCFJBAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x9A7620", Offset = "0x9A6620", VA = "0x1809A7620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8BC650", Offset = "0x8BB650", VA = "0x1808BC650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool KEFDNIJMJFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xC5F1F0", Offset = "0xC5E1F0", VA = "0x180C5F1F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9781F0", Offset = "0x9771F0", VA = "0x1809781F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool GNOKHIGLDIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC5F1E0", Offset = "0xC5E1E0", VA = "0x180C5F1E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x24E8780", Offset = "0x24E7780", VA = "0x1824E8780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool LEDNBKMMJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xC5F1C0", Offset = "0xC5E1C0", VA = "0x180C5F1C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x4B1CC80", Offset = "0x4B1BC80", VA = "0x184B1CC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x784DB40", Offset = "0x784CB40", VA = "0x18784DB40")]
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
		[SerializeField]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		private bool isInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Allows the canvas to be anchored and framed to the screen")]
		[SerializeField]
		private bool canBeAnchored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[ConditionallyVisibleField("canBeAnchored", true, false)]
		[Tooltip("The way in which the menu frames up on screen")]
		[SerializeField]
		private AttachmentMode anchorAttachmentMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Optionally overwrite Rec Room's default behavior of when we show control hints while the cursor is over UI.")]
		[ConditionallyVisibleField("isInteractable", true, false)]
		[SerializeField]
		private ControlPromptBehaviorType controlPromptBehaviorOverride;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KPLOKCNDLLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9A7620", Offset = "0x9A6620", VA = "0x1809A7620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool EDPGFCMIHDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xC5F1F0", Offset = "0xC5E1F0", VA = "0x180C5F1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool FAFOIAAPGEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xC5F1E0", Offset = "0xC5E1E0", VA = "0x180C5F1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AttachmentMode JBKKJPPONGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8DDAC0", Offset = "0x8DCAC0", VA = "0x1808DDAC0")]
			get
			{
				return default(AttachmentMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public ControlPromptBehaviorType ALBNPONBDKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600")]
			get
			{
				return default(ControlPromptBehaviorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AttachmentMode> GENDLLDMLPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x784DB90", Offset = "0x784CB90", VA = "0x18784DB90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x784DCE0", Offset = "0x784CCE0", VA = "0x18784DCE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action IEKIKHCFEFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x784DC40", Offset = "0x784CC40", VA = "0x18784DC40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x784DD90", Offset = "0x784CD90", VA = "0x18784DD90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x784DB50", Offset = "0x784CB50", VA = "0x18784DB50")]
		public void AnchorCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x784DB70", Offset = "0x784CB70", VA = "0x18784DB70")]
		public void DetachCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
		public bool NCFCDBCKECJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1A15A20", Offset = "0x1A14A20", VA = "0x181A15A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		protected RecRoomStudioDisableRenderInShareCamPhotoBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class RecRoomStudioHudCanvasBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xA17190", Offset = "0xA16190", VA = "0x180A17190")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x784E120", Offset = "0x784D120", VA = "0x18784E120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x784DE30", Offset = "0x784CE30", VA = "0x18784DE30")]
		private void ApplyColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x784DFD0", Offset = "0x784CFD0", VA = "0x18784DFD0")]
		private void ClearColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x784DFA0", Offset = "0x784CFA0", VA = "0x18784DFA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		protected RecRoomStudioInstanceRecolorBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class RecRoomStudioPlatformTextFilterBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private TMP_Text textMeshPro;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private string lastText;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public TMP_Text TextMeshPro
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Action<string> SanitizeAndSetTextAction
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x784E990", Offset = "0x784D990", VA = "0x18784E990")]
		public void SetText(string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		protected RecRoomStudioPlatformTextFilterBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class RecRoomStudioRecNetImageBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		[Tooltip("If true, the image will be automatically cropped into a square.")]
		private bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private BHBPHFGDAAP IMKGDEGPOJE;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public BHBPHFGDAAP NENANHHGOIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x784EB70", Offset = "0x784DB70", VA = "0x18784EB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool DHKNNFHEPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9A7620", Offset = "0x9A6620", VA = "0x1809A7620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action MMLFBDIDDGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x784EA30", Offset = "0x784DA30", VA = "0x18784EA30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x784EAD0", Offset = "0x784DAD0", VA = "0x18784EAD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		protected RecRoomStudioRecNetImageBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class RecRoomUnitySceneSystemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		protected RecRoomUnitySceneSystemBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class RecRoomVisualPostProcessingBase : RecRoomUnitySceneSystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		[ReadOnlyField]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static RecRoomVisualPostProcessingBase DKOIJBOMAJG;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static RecRoomVisualPostProcessingBase LONLOOPDCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x784EDC0", Offset = "0x784DDC0", VA = "0x18784EDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x784EBB0", Offset = "0x784DBB0", VA = "0x18784EBB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x784EC90", Offset = "0x784DC90", VA = "0x18784EC90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		protected RecRoomVisualPostProcessingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyEnabledFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7847160", Offset = "0x7846160", VA = "0x187847160")]
		public ConditionallyEnabledFieldAttribute(string propertyName, bool propertyValue, string disabledTooltip)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class DJPNMFOKJDM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7847220", Offset = "0x7846220", VA = "0x187847220")]
	protected DJPNMFOKJDM(string ODFHIAEGOOC, bool DAPPHDLLBJN)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyVisibleFieldAttribute : DJPNMFOKJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x78471C0", Offset = "0x78461C0", VA = "0x1878471C0")]
		public ConditionallyVisibleFieldAttribute(string propertyName, bool propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class IntConditionallyVisibleFieldAttribute : DJPNMFOKJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7847670", Offset = "0x7846670", VA = "0x187847670")]
		public IntConditionallyVisibleFieldAttribute(string propertyName, int propertyValue, bool isReadOnly = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface BHBPHFGDAAP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string AALLCNPPOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface LPJAHHMLDCB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AttachMarkupComponent(T NLHNPMIAHFH, int BIDMFGDPFKA, bool OLENIMMEKFM);
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[SerializeField]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[ConditionallyEnabledField("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		[SerializeField]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[ConditionallyEnabledField("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		[SerializeField]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		private RecRoomObjectPhysicsMode physicsMode;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x784D290", Offset = "0x784C290", VA = "0x18784D290")]
		public RecRoomObjectConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public enum RecRoomObjectPhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Physical = 4
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x32219E0", Offset = "0x32209E0", VA = "0x1832219E0")]
		public bool JIBJJFGCKGK<T>([Out] T BJDKOHEGDOK, [Out] string IPLILPPMPOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x784D600", Offset = "0x784C600", VA = "0x18784D600")]
		public static string GBBCGBHGMCA(Type JJJGJKKAJDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private MethodInfo cachedTargetMethod;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x784D590", Offset = "0x784C590", VA = "0x18784D590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x784D430", Offset = "0x784C430", VA = "0x18784D430")]
		public MethodInfo BFBOMKCCHEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x784D4A0", Offset = "0x784C4A0", VA = "0x18784D4A0")]
		public string ICKMAPFCLHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public abstract class RecRoomStudioAutoCreatedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x975580", VA = "0x180976580")]
		protected RecRoomStudioAutoCreatedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class RecRoomStudioAutoGeneratedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x975580", VA = "0x180976580")]
		public RecRoomStudioAutoGeneratedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class RecRoomStudioNavMeshCutBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public const float MINIMUM_WIDTH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[Obsolete]
		[SerializeField]
		[HideInInspector]
		private float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[Obsolete]
		[SerializeField]
		[HideInInspector]
		private float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[ICAAAJFGMGG("When using a Nav Mesh Cut, you may also want to set NavMesh Generation Mode to Ignore in the configure menu so the associated Rec Room Object won't bake into the navmesh on its own.")]
		private Vector3 size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private Vector3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		[Header("Optimization")]
		[ICAAAJFGMGG("Ignoring rotation leads to better performance, but ignoring rotation also means that the box must be aligned with the X, Y, and Z axes.")]
		private bool ignoreRotationAndScale;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[Obsolete]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x784E4F0", Offset = "0x784D4F0", VA = "0x18784E4F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x784E810", Offset = "0x784D810", VA = "0x18784E810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[Obsolete]
		public float Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xC5F200", Offset = "0xC5E200", VA = "0x180C5F200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x784E770", Offset = "0x784D770", VA = "0x18784E770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool IgnoreRotationAndScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA24150", Offset = "0xA23150", VA = "0x180A24150")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x784E7F0", Offset = "0x784D7F0", VA = "0x18784E7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector3 Size
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x98CAB0", Offset = "0x98BAB0", VA = "0x18098CAB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x784E890", Offset = "0x784D890", VA = "0x18784E890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float HeightSizeY
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xC5F200", Offset = "0xC5E200", VA = "0x180C5F200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x784E770", Offset = "0x784D770", VA = "0x18784E770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float XZUniformSquareSize
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x784E910", Offset = "0x784D910", VA = "0x18784E910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 Center
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x98CAD0", Offset = "0x98BAD0", VA = "0x18098CAD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x784E6F0", Offset = "0x784D6F0", VA = "0x18784E6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action OnSettingsChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x784E450", Offset = "0x784D450", VA = "0x18784E450")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x784E650", Offset = "0x784D650", VA = "0x18784E650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OnForceUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x784E3B0", Offset = "0x784D3B0", VA = "0x18784E3B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x784E5B0", Offset = "0x784D5B0", VA = "0x18784E5B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<bool> OnEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x784E300", Offset = "0x784D300", VA = "0x18784E300")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x784E500", Offset = "0x784D500", VA = "0x18784E500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x784E1A0", Offset = "0x784D1A0", VA = "0x18784E1A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xB181D0", Offset = "0xB171D0", VA = "0x180B181D0")]
		[Obsolete]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xB181D0", Offset = "0xB171D0", VA = "0x180B181D0")]
		public void ForceQueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x784E290", Offset = "0x784D290", VA = "0x18784E290")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x784E290", Offset = "0x784D290", VA = "0x18784E290")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x784E2D0", Offset = "0x784D2D0", VA = "0x18784E2D0")]
		protected RecRoomStudioNavMeshCutBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct CCDCKPEHKHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public byte[] PKGMMHJMOKB;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	public CCDCKPEHKHM(byte[] NDBAHEIEDNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct FJIHCKBADML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public byte[] PKGMMHJMOKB;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	public FJIHCKBADML(byte[] NDBAHEIEDNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class COIEGADKOCI
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x78435E0", Offset = "0x78425E0", VA = "0x1878435E0")]
	public static (CCDCKPEHKHM, FJIHCKBADML) FPBAEDKBFPM(Stream DONEMIPDOAM)
	{
		return default((CCDCKPEHKHM, FJIHCKBADML));
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7843420", Offset = "0x7842420", VA = "0x187843420")]
	public static void EPCIBPCBAPI(Stream DONEMIPDOAM, CCDCKPEHKHM EBLANDLJNLN, FJIHCKBADML MOMPGFLGKNK)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x24ECA00", Offset = "0x24EBA00", VA = "0x1824ECA00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A7F0", Offset = "0x6E797F0", VA = "0x186E7A7F0")]
		public SerializedGuid([In] Guid EEKOILIMLBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A750", Offset = "0x6E79750", VA = "0x186E7A750", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x784EE90", Offset = "0x784DE90", VA = "0x18784EE90", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A5F0", Offset = "0x6E795F0", VA = "0x186E7A5F0", Slot = "7")]
		public bool Equals(SerializedGuid DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x784EE00", Offset = "0x784DE00", VA = "0x18784EE00", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A6C0", Offset = "0x6E796C0", VA = "0x186E7A6C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A4E0", Offset = "0x6E794E0", VA = "0x186E7A4E0", Slot = "6")]
		public int CompareTo(SerializedGuid DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x784EF10", Offset = "0x784DF10", VA = "0x18784EF10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SerializedTypeNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public SerializedTypeNameAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class COCIJGLKAJM
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static readonly CDBONJBDMGH EABMNEBNCGL;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly CDBONJBDMGH CPKBLOLADHF;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly CDBONJBDMGH HEGMGOMMNHP;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static readonly CDBONJBDMGH JAHBKGJDPFP;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static readonly CDBONJBDMGH PINIEAKPJHO;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly CDBONJBDMGH CGCPDAADAMO;
}
namespace RecRoom.Core.Studio.StudioFunctions
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly Argument Void;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Parameter Binding
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public Argument()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
		public Argument(string DMCFPOLFNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7842770", Offset = "0x7841770", VA = "0x187842770")]
		public object BFCDGEJDGOC(object[] PNGJAILLINP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x78427C0", Offset = "0x78417C0", VA = "0x1878427C0")]
		internal void DGNHFFMKPNI(IReadOnlyList<Parameter> IEEFMIOJLFJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument<T> : Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SerializeField]
		protected T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x472C8B0", Offset = "0x472B8B0", VA = "0x18472C8B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x472C3E0", Offset = "0x472B3E0", VA = "0x18472C3E0")]
		protected Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[UnityEngine.Scripting.Preserve]
	public sealed class VoidArgument : Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly VoidArgument Instance;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7850230", Offset = "0x784F230", VA = "0x187850230", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x78501B0", Offset = "0x784F1B0", VA = "0x1878501B0")]
		private VoidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4FE2820", Offset = "0x4FE1820", VA = "0x184FE2820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFEA0", Offset = "0x3CBEEA0", VA = "0x183CBFEA0")]
		protected ValueArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[SerializeField]
		protected string valueTypeAssemblyQualifiedName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x5AF6DA0", Offset = "0x5AF5DA0", VA = "0x185AF6DA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6AF0", Offset = "0x5AF5AF0", VA = "0x185AF6AF0")]
		private Type FIAFCMOMDNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3C36650", Offset = "0x3C35650", VA = "0x183C36650")]
		protected ClassArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolArgument : ValueArgument<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x78428E0", Offset = "0x78418E0", VA = "0x1878428E0")]
		public BoolArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorArgument : ValueArgument<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x78463B0", Offset = "0x78453B0", VA = "0x1878463B0")]
		public ColorArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Argument : ValueArgument<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7846330", Offset = "0x7845330", VA = "0x187846330")]
		public Color32Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[UnityEngine.Scripting.Preserve]
	public sealed class GuidArgument : ValueArgument<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x78475B0", Offset = "0x78465B0", VA = "0x1878475B0")]
		public GuidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatArgument : ValueArgument<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7847490", Offset = "0x7846490", VA = "0x187847490")]
		public FloatArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntArgument : ValueArgument<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7847630", Offset = "0x7846630", VA = "0x187847630")]
		public IntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ShortArgument : ValueArgument<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x784EF20", Offset = "0x784DF20", VA = "0x18784EF20")]
		public ShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringArgument : ValueArgument<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x784EF60", Offset = "0x784DF60", VA = "0x18784EF60")]
		public StringArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UIntArgument : ValueArgument<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x784FC90", Offset = "0x784EC90", VA = "0x18784FC90")]
		public UIntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UShortArgument : ValueArgument<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x784FCD0", Offset = "0x784ECD0", VA = "0x18784FCD0")]
		public UShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Argument : ValueArgument<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x784FF50", Offset = "0x784EF50", VA = "0x18784FF50")]
		public Vector2Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Argument : ValueArgument<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x784FFD0", Offset = "0x784EFD0", VA = "0x18784FFD0")]
		public Vector3Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionArgument : ValueArgument<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x784B0F0", Offset = "0x784A0F0", VA = "0x18784B0F0")]
		public QuaternionArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UnityObjectArgument : ClassArgument<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x784FDD0", Offset = "0x784EDD0", VA = "0x18784FDD0")]
		public UnityObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageArgument : ValueArgument<BHBPHFGDAAP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x784B170", Offset = "0x784A170", VA = "0x18784B170")]
		public RecNetImageArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void IJNFOBHJKBL(string FEOOECMBEFE, object[] PNGJAILLINP, object[] HEHNPHCLLDD);

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected internal abstract void BCIBOMPILIN(IReadOnlyList<Parameter> IEEFMIOJLFJ, IReadOnlyList<Parameter> INNMCPIJFBI);

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		protected Instruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
		public override void IJNFOBHJKBL(string FEOOECMBEFE, object[] PNGJAILLINP, object[] HEHNPHCLLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		protected internal override void BCIBOMPILIN(IReadOnlyList<Parameter> IEEFMIOJLFJ, IReadOnlyList<Parameter> INNMCPIJFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PlaceholderInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[UnityEngine.Scripting.Preserve]
	public sealed class CallInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private delegate void EEPBIFGCKBJ(UnityEngine.Object CECLKDDLGFE, MethodInfo HOHMPBGGGLF, object[] MDGEJBKJLPO);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[SerializeField]
		private UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeReference]
		private Argument[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeReference]
		private Argument result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private MethodInfo GAME_CLIENT_ONLY_resolvedMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly MethodInfo InvalidMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private static object[][] argumentValueArrays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private EEPBIFGCKBJ optimization;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly MethodInfo Animator_SetBool_name_value;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly MethodInfo Animator_SetBool_id_value;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly MethodInfo Animator_SetFloat_name_value;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private static readonly MethodInfo Animator_SetFloat_id_value;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private static readonly MethodInfo Animator_SetFloat_name_value_dampTime_deltaTime;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private static readonly MethodInfo Animator_SetFloat_id_value_dampTime_deltaTime;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly MethodInfo Animator_SetInteger_name_value;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly MethodInfo Animator_SetInteger_id_value;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private static readonly Dictionary<MethodInfo, EEPBIFGCKBJ> optimizations;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly Dictionary<string, int> cachedAnimatorStringToHashResults;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x78462B0", Offset = "0x78452B0", VA = "0x1878462B0")]
		public CallInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7844840", Offset = "0x7843840", VA = "0x187844840", Slot = "4")]
		public override void IJNFOBHJKBL(string FEOOECMBEFE, object[] PNGJAILLINP, object[] HEHNPHCLLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x78439D0", Offset = "0x78429D0", VA = "0x1878439D0")]
		private void ALEGBMOBPDG(object[] HEHNPHCLLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x78443F0", Offset = "0x78433F0", VA = "0x1878443F0")]
		private void GJLGMBLHLGG(object[] HEHNPHCLLDD, object IENENPIGMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7843A80", Offset = "0x7842A80", VA = "0x187843A80", Slot = "5")]
		protected internal override void BCIBOMPILIN(IReadOnlyList<Parameter> IEEFMIOJLFJ, IReadOnlyList<Parameter> INNMCPIJFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7845500", Offset = "0x7844500", VA = "0x187845500")]
		[UnityEngine.Scripting.Preserve]
		private static void NJJMLFKFDLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x78441D0", Offset = "0x78431D0", VA = "0x1878441D0")]
		private MethodInfo FMKCOMFOFKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7844E40", Offset = "0x7843E40", VA = "0x187844E40")]
		internal MethodInfo JBNBAONLPAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7845070", Offset = "0x7844070", VA = "0x187845070")]
		internal static bool NHODDHKAFKN(UnityEngine.Object CECLKDDLGFE, string HFPHKGCNGMN, Argument[] FPNICHIKLCC, [Out] MethodInfo HOHMPBGGGLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7844490", Offset = "0x7843490", VA = "0x187844490")]
		private static bool GKPIKAMMFPN(MethodInfo HOHMPBGGGLF, Type[] ENJCEGJMLMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7843810", Offset = "0x7842810", VA = "0x187843810")]
		private static object[] AIFIJBCNNOK(int NNJMBLDCALL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x78446D0", Offset = "0x78436D0", VA = "0x1878446D0")]
		private object[] HEOBHOKGDCE(object[] PNGJAILLINP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7843CE0", Offset = "0x7842CE0", VA = "0x187843CE0")]
		private void BIKFGKGILPI(object[] MDGEJBKJLPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x78445A0", Offset = "0x78435A0", VA = "0x1878445A0")]
		private static void HBKAIDOOHMM(UnityEngine.Object CECLKDDLGFE, MethodInfo HOHMPBGGGLF, object[] MDGEJBKJLPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7843BB0", Offset = "0x7842BB0", VA = "0x187843BB0")]
		private static void BFAFCFOIEEB(UnityEngine.Object CECLKDDLGFE, MethodInfo HOHMPBGGGLF, object[] MDGEJBKJLPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7844F40", Offset = "0x7843F40", VA = "0x187844F40")]
		private static void NHBGPHLJDLG(UnityEngine.Object CECLKDDLGFE, MethodInfo HOHMPBGGGLF, object[] MDGEJBKJLPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x78440A0", Offset = "0x78430A0", VA = "0x1878440A0")]
		private static void FKHOKAJNJDH(UnityEngine.Object CECLKDDLGFE, MethodInfo HOHMPBGGGLF, object[] MDGEJBKJLPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7843D40", Offset = "0x7842D40", VA = "0x187843D40")]
		private static MethodInfo BPOADOLNGDD(Type NDBJLGNBFFN, string HFPHKGCNGMN, params Type[] BKBLEDCPCNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7844300", Offset = "0x7843300", VA = "0x187844300")]
		private static int FPIFONBEPGK(string DMCFPOLFNCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7844ED0", Offset = "0x7843ED0", VA = "0x187844ED0")]
		public static void MPOIGELEOAN()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ConditionalInstruction : Instruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[SerializeField]
		private Condition[] conditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[SerializeReference]
		private Instruction[] @default;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x78470E0", Offset = "0x78460E0", VA = "0x1878470E0")]
		public ConditionalInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7846CB0", Offset = "0x7845CB0", VA = "0x187846CB0", Slot = "4")]
		public override void IJNFOBHJKBL(string FEOOECMBEFE, object[] PNGJAILLINP, object[] HEHNPHCLLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x78469B0", Offset = "0x78459B0", VA = "0x1878469B0", Slot = "5")]
		protected internal override void BCIBOMPILIN(IReadOnlyList<Parameter> IEEFMIOJLFJ, IReadOnlyList<Parameter> INNMCPIJFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7846C40", Offset = "0x7845C40", VA = "0x187846C40")]
		private void DGNHFFMKPNI(IReadOnlyList<Parameter> IEEFMIOJLFJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Condition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IReadOnlyList<Instruction> Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7846960", Offset = "0x7845960", VA = "0x187846960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x78468E0", Offset = "0x78458E0", VA = "0x1878468E0")]
		public Condition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x78467F0", Offset = "0x78457F0", VA = "0x1878467F0")]
		public static bool OKJPKIEEJCB(string BJDKOHEGDOK, [Out] bool LKJLJJJMBCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x78464C0", Offset = "0x78454C0", VA = "0x1878464C0")]
		public static bool GAEOFFJAAAK(string BJDKOHEGDOK, [Out] int KPOPCMABHJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7846590", Offset = "0x7845590", VA = "0x187846590")]
		public bool GALMDPCADAI(bool EFICFIHEGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7846710", Offset = "0x7845710", VA = "0x187846710")]
		public bool MDNPJFFFFKF(int BAOMCCHJCIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x78468C0", Offset = "0x78458C0", VA = "0x1878468C0")]
		public bool PCPKNOCBICM(string ACNJPOOAEDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7846680", Offset = "0x7845680", VA = "0x187846680")]
		public void IJNFOBHJKBL(string FEOOECMBEFE, object[] PNGJAILLINP, object[] HEHNPHCLLDD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xF144F0", Offset = "0xF134F0", VA = "0x180F144F0")]
		public Parameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x784AFB0", Offset = "0x7849FB0", VA = "0x18784AFB0")]
		internal void INNMGHKEJLM(int FJMFGODNMJM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderParameter : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x784B090", Offset = "0x784A090", VA = "0x18784B090", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter<T> : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4BF9390", Offset = "0x4BF8390", VA = "0x184BF9390")]
		protected Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5045CA0", Offset = "0x5044CA0", VA = "0x185045CA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFEA0", Offset = "0x3CBEEA0", VA = "0x183CBFEA0")]
		protected ValueParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		private string valueTypeFullName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Type valueType;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x5AF6ED0", Offset = "0x5AF5ED0", VA = "0x185AF6ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5AF6E10", Offset = "0x5AF5E10", VA = "0x185AF6E10")]
		private Type FIAFCMOMDNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C36650", Offset = "0x3C35650", VA = "0x183C36650")]
		protected ClassParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolParameter : ValueParameter<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7842920", Offset = "0x7841920", VA = "0x187842920")]
		public BoolParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorParameter : ValueParameter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x78463F0", Offset = "0x78453F0", VA = "0x1878463F0")]
		public ColorParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Parameter : ValueParameter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7846370", Offset = "0x7845370", VA = "0x187846370")]
		public Color32Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatParameter : ValueParameter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x78474D0", Offset = "0x78464D0", VA = "0x1878474D0")]
		public FloatParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntParameter : ValueParameter<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x78476D0", Offset = "0x78466D0", VA = "0x1878476D0")]
		public IntParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringParameter : ValueParameter<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x784EFA0", Offset = "0x784DFA0", VA = "0x18784EFA0")]
		public StringParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Parameter : ValueParameter<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x784FF90", Offset = "0x784EF90", VA = "0x18784FF90")]
		public Vector2Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Parameter : ValueParameter<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7850010", Offset = "0x784F010", VA = "0x187850010")]
		public Vector3Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionParameter : ValueParameter<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x784B130", Offset = "0x784A130", VA = "0x18784B130")]
		public QuaternionParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageParameter : ValueParameter<BHBPHFGDAAP>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x784B1B0", Offset = "0x784A1B0", VA = "0x18784B1B0")]
		public RecNetImageParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StudioFunction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeReference]
		private Parameter[] parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeReference]
		private Parameter[] results;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private bool GAME_CLIENT_ONLY_didAssignParameterIndices;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x784F9F0", Offset = "0x784E9F0", VA = "0x18784F9F0")]
		public StudioFunction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x784F500", Offset = "0x784E500", VA = "0x18784F500")]
		public void IJNFOBHJKBL(object[] PNGJAILLINP, object[] HEHNPHCLLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x784F6F0", Offset = "0x784E6F0", VA = "0x18784F6F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x784F3C0", Offset = "0x784E3C0", VA = "0x18784F3C0")]
		private void HNBGBOJHEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x784F350", Offset = "0x784E350", VA = "0x18784F350")]
		private void BCIBOMPILIN()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[UnityEngine.Scripting.Preserve]
	public class StudioFunctionList : IReadOnlyList<StudioFunction>, IEnumerable<StudioFunction>, IEnumerable, IReadOnlyCollection<StudioFunction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		[HideInInspector]
		private StudioFunction[] array;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private IReadOnlyList<StudioFunction> ReadOnlyList
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x784F300", Offset = "0x784E300", VA = "0x18784F300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x784F130", Offset = "0x784E130", VA = "0x18784F130", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public StudioFunction this[int KHAIDMGPIED]
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x784F220", Offset = "0x784E220", VA = "0x18784F220", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x784EFE0", Offset = "0x784DFE0", VA = "0x18784EFE0", Slot = "6")]
		public IEnumerator<StudioFunction> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x784F060", Offset = "0x784E060", VA = "0x18784F060", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x784F0E0", Offset = "0x784E0E0", VA = "0x18784F0E0")]
		public StudioFunctionList()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class LOKNOMOJKOK
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7849270", Offset = "0x7848270", VA = "0x187849270")]
	public static string BFABNHCODMB(this Type PFCMGBLCCPJ)
	{
		return null;
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public abstract class RecRoomStudioAvatarItemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
