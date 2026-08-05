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
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Studio_Common_Base_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C36190", Offset = "0x7C35390", VA = "0x187C36190", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct HIJGECNDJDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Vector3 KPOPDEAOOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Quaternion EGIHDGHICMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Vector3 NADHPEFDILH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C359B0", Offset = "0x7C34BB0", VA = "0x187C359B0")]
	public bool PLMKJLIIEFC(Collider GIBMJBECLPO, Bounds OLDDHKAMBEN, bool LDNNOOOGFJL, bool GNPAIPMKLNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C34FE0", Offset = "0x7C341E0", VA = "0x187C34FE0")]
	public bool EALCPDJNKHH(Collider FDEJAKKFLHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C34990", Offset = "0x7C33B90", VA = "0x187C34990")]
	public bool DAKJDMHNEKA(Collider FDEJAKKFLHE, bool LDNNOOOGFJL, bool GNPAIPMKLNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C35900", Offset = "0x7C34B00", VA = "0x187C35900")]
	public void KAAPGJILOJM(Transform EBJDGDIMGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C35000", Offset = "0x7C34200", VA = "0x187C35000")]
	public void EDFKMCGEDKH(HIJGECNDJDE JAINJPLCLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C34F60", Offset = "0x7C34160", VA = "0x187C34F60")]
	private static void DMBHLIBLMKA(Vector3 KKNLKEIKANG, Vector3 HEMGJLGOHMA, Vector3 DLAJPPBHBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C345A0", Offset = "0x7C337A0", VA = "0x187C345A0")]
	public static HIJGECNDJDE CJEOENJKBOB(GameObject DONMCNODAED, Quaternion EGIHDGHICMO, bool GJIKCMPNKBP, bool ABDCEMDLLNE, bool LDNNOOOGFJL = false, bool GNPAIPMKLNH = false, bool KHPCIPFMBMC = false)
	{
		return default(HIJGECNDJDE);
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
public enum LGEJPABGPIN
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
public static class HLDBKMGBAON
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string LFBJLNMLLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C35F90", Offset = "0x7C35190", VA = "0x187C35F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string IEHGEJEAGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C35F60", Offset = "0x7C35160", VA = "0x187C35F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string KFPLHBDPILP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C35F30", Offset = "0x7C35130", VA = "0x187C35F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C35FC0", Offset = "0x7C351C0", VA = "0x187C35FC0")]
	public static LGEJPABGPIN ONPMPBHOMIP(this LGEJPABGPIN GDCMGFLNBJE)
	{
		return default(LGEJPABGPIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C35FC0", Offset = "0x7C351C0", VA = "0x187C35FC0")]
	public static int ONPMPBHOMIP(int GDCMGFLNBJE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BIHCMLBBOJG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	AudioMixerGroup MBDKLJCGPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BIHCMLBBOJG ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IReadOnlyList<BIHCMLBBOJG> ICEEGCEHMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string BBANOCKOKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BKHEPNHFHCO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class NOFJANFAJHL : BIHCMLBBOJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal readonly List<BIHCMLBBOJG> KNBKGDCLLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal readonly NOFJANFAJHL KAGKCPBHMFB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BIHCMLBBOJG ACBBFNLKNHG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AudioMixerGroup MBDKLJCGPNA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<BIHCMLBBOJG> ICEEGCEHMMH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string BBANOCKOKLO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C368E0", Offset = "0x7C35AE0", VA = "0x187C368E0")]
		internal NOFJANFAJHL(AudioMixerGroup GEDEGGCFAKO, NOFJANFAJHL DBEHKFODEEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BIHCMLBBOJG AKJCAIEOCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AudioMixer EFAKGFHCBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C2FDC0", Offset = "0x7C2EFC0", VA = "0x187C2FDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	private BKHEPNHFHCO(NOFJANFAJHL AOHGPIFIMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F550", Offset = "0x7C2E750", VA = "0x187C2F550")]
	public static BKHEPNHFHCO FMEEHIKJMIL(AudioMixer DLOOGOCMPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C2FA20", Offset = "0x7C2EC20", VA = "0x187C2FA20")]
	public BIHCMLBBOJG IJKNOOKJFIL(string MNODFBJNEMD, bool KCIAGEONCEF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F790", Offset = "0x7C2E990", VA = "0x187C2F790")]
	public BIHCMLBBOJG IJKNOOKJFIL(AudioMixerGroup GEDEGGCFAKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F4D0", Offset = "0x7C2E6D0", VA = "0x187C2F4D0")]
	private static int BDDJCFCFIKD(string BIIHNEHMDOI, int JEMCAHPLMGJ)
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasBeenTranslated
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0D0", Offset = "0x8FA2D0", VA = "0x1808FB0D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8FB090", Offset = "0x8FA290", VA = "0x1808FB090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4C50C10", Offset = "0x4C4FE10", VA = "0x184C50C10")]
		public MaterialEntry OHJLNJMLGBN(Material HGJFBFIMOOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4C50BE0", Offset = "0x4C4FDE0", VA = "0x184C50BE0")]
		public void FIHHJKJJKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3FAD2A0", Offset = "0x3FAC4A0", VA = "0x183FAD2A0")]
		public MaterialMapAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class MaterialMapBase<TMaterialMapAsset> : RecRoomUnitySceneSystemBase where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static MaterialMapBase<TMaterialMapAsset> IEFGENALBBO;

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
		public static MaterialMapBase<TMaterialMapAsset> CLACNPDFIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4C511E0", Offset = "0x4C503E0", VA = "0x184C511E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MaterialEntry[] GFPNKGJHOEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4C51100", Offset = "0x4C50300", VA = "0x184C51100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4C50D00", Offset = "0x4C4FF00", VA = "0x184C50D00")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4C51010", Offset = "0x4C50210", VA = "0x184C51010")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4C50F20", Offset = "0x4C50120", VA = "0x184C50F20")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4C50ED0", Offset = "0x4C500D0", VA = "0x184C50ED0")]
		public void ClearSceneMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x90FE00", Offset = "0x90F000", VA = "0x18090FE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C3C760", Offset = "0x7C3B960", VA = "0x187C3C760", Slot = "4")]
		public bool Equals(TextureProperty JAINJPLCLDO)
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
		[Cpp2IlInjected.Address(RVA = "0x7C33F30", Offset = "0x7C33130", VA = "0x187C33F30", Slot = "4")]
		public bool Equals(FloatProperty JAINJPLCLDO)
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
		[Cpp2IlInjected.Address(RVA = "0x7C3CD30", Offset = "0x7C3BF30", VA = "0x187C3CD30", Slot = "4")]
		public bool Equals(VectorProperty JAINJPLCLDO)
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
		[Cpp2IlInjected.Address(RVA = "0x7C33050", Offset = "0x7C32250", VA = "0x187C33050", Slot = "4")]
		public bool Equals(ColorProperty JAINJPLCLDO)
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
		[Cpp2IlInjected.Address(RVA = "0x7C36550", Offset = "0x7C35750", VA = "0x187C36550")]
		public void NDCCANANAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C36380", Offset = "0x7C35580", VA = "0x187C36380")]
		public float IHAKKLMOBOI(int MOHHJLOKICF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C36500", Offset = "0x7C35700", VA = "0x187C36500")]
		public Texture MECCKAPDAFI(int MOHHJLOKICF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C363D0", Offset = "0x7C355D0", VA = "0x187C363D0")]
		public Vector4 JBKIPHCKEPM(int MOHHJLOKICF)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C36480", Offset = "0x7C35680", VA = "0x187C36480")]
		public Color JEKGOMJDCGB(int MOHHJLOKICF)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C36220", Offset = "0x7C35420", VA = "0x187C36220", Slot = "4")]
		public bool Equals(MaterialEntry JAINJPLCLDO)
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
			[Cpp2IlInjected.Address(RVA = "0x50D1120", Offset = "0x50D0320", VA = "0x1850D1120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x42DEC80", Offset = "0x42DDE80", VA = "0x1842DEC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AddComponentMenu(null)]
	public abstract class RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> : RecRoomUnitySceneSystemBase where TAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> IEFGENALBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[ReadOnlyField]
		[SerializeField]
		private TAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> CLACNPDFIIL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x4C511E0", Offset = "0x4C503E0", VA = "0x184C511E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public TAudioClipRegistryAsset GFPNKGJHOEI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IReadOnlyList<RecRoomAudioClipEntry> MPAMBHDENPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x50D1420", Offset = "0x50D0620", VA = "0x1850D1420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50D1170", Offset = "0x50D0370", VA = "0x1850D1170")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x50D12A0", Offset = "0x50D04A0", VA = "0x1850D12A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x90FE00", Offset = "0x90F000", VA = "0x18090FE00")]
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
		private static readonly Dictionary<AudioMixerGroupType, string> AHOPPJLNNNN;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string MusicName = "Music";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string AmbienceName = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string SoundsName = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string HFAMAKFNGNB = "Assets";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string KJAIIOOFJJH = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const string CHLFPJAGKMH = "Audio";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly string GCGICCBCGIA;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string NFCJHPPHFHE;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static RecRoomAudioMixerRegistryBase IEFGENALBBO;

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
		public static RecRoomAudioMixerRegistryBase CLACNPDFIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7C38D80", Offset = "0x7C37F80", VA = "0x187C38D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AudioMixer EGOADCAMOMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool EHPNJBGMJGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7C38DD0", Offset = "0x7C37FD0", VA = "0x187C38DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public MixerVersion DCLMEHAOAAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30")]
			get
			{
				return default(MixerVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7C38F20", Offset = "0x7C38120", VA = "0x187C38F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C382B0", Offset = "0x7C374B0", VA = "0x187C382B0")]
		public static string GetAudioGroupPath(AudioMixerGroupType MDLJDGOOKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C383D0", Offset = "0x7C375D0", VA = "0x187C383D0")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroupType MDLJDGOOKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C38210", Offset = "0x7C37410", VA = "0x187C38210")]
		private static AudioMixerGroup GCABFGKDIBB(AudioMixer DLOOGOCMPFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C37E80", Offset = "0x7C37080", VA = "0x187C37E80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7C38970", Offset = "0x7C37B70", VA = "0x187C38970")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C385C0", Offset = "0x7C377C0", VA = "0x187C385C0")]
		public bool IsValidOutputGroup(AudioMixerGroup NEIANILGKLE, [Out] string GILNIHGCEJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C38800", Offset = "0x7C37A00", VA = "0x187C38800")]
		private bool MOOENIJIPLG(AudioMixerGroup NEIANILGKLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C37FA0", Offset = "0x7C371A0", VA = "0x187C37FA0")]
		private bool EJDFNCFFCHH(AudioMixerGroup KEKOMIBKCFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
		public Guid ENKHEAECNBM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C39060", Offset = "0x7C38260", VA = "0x187C39060")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7C390D0", Offset = "0x7C382D0", VA = "0x187C390D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IPIHHJPJIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7C39040", Offset = "0x7C38240", VA = "0x187C39040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool JDFALPEOAHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7C38FF0", Offset = "0x7C381F0", VA = "0x187C38FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Transform GCCPCFDAPLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8F85C0", Offset = "0x8F77C0", VA = "0x1808F85C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
		public byte[] GetSpawnableTemplateData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490")]
		public void SetSpawnableTemplateData(byte[] DKJABFPOANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x920D80", Offset = "0x91FF80", VA = "0x180920D80")]
		public void ClearSpawnableTemplateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D1640", Offset = "0x50D0840", VA = "0x1850D1640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IReadOnlyDictionary<Guid, TRecRoomBuiltInObject> AllBuiltInObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4389AF0", Offset = "0x4388CF0", VA = "0x184389AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x50D1510", Offset = "0x50D0710", VA = "0x1850D1510")]
		public void ABPOJMPHOCA(IEnumerable<TRecRoomBuiltInObject> KHHFCDPOLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x50D1580", Offset = "0x50D0780", VA = "0x1850D1580")]
		public bool EKHOHBPCPIG(Guid JIGDEHAPMAH, [Out] TRecRoomBuiltInObject PNGLNJCBPCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA59310", Offset = "0xA58510", VA = "0x180A59310")]
		protected RecRoomBuiltInObjectDataBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class RecRoomObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class AONNDPOALLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public bool value;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public AONNDPOALLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F150", Offset = "0x7C2E350", VA = "0x187C2F150")]
			internal bool JJANGKCAMEK(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class LNHHIHOBNKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float value;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public LNHHIHOBNKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7C36160", Offset = "0x7C35360", VA = "0x187C36160")]
			internal bool JJANGKCAMEK(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class FIBBJHPELNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public int value;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public FIBBJHPELNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7C33E80", Offset = "0x7C33080", VA = "0x187C33E80")]
			internal bool JJANGKCAMEK(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class EIFAPAGBOGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public string value;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public EIFAPAGBOGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7C33E40", Offset = "0x7C33040", VA = "0x187C33E40")]
			internal bool JJANGKCAMEK(NamedUnityEventBase e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class BKBLIPMDGCJ : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
			[DebuggerHidden]
			public BKBLIPMDGCJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F2D0", Offset = "0x7C2E4D0", VA = "0x187C2F2D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F480", Offset = "0x7C2E680", VA = "0x187C2F480", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F3C0", Offset = "0x7C2E5C0", VA = "0x187C2F3C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NamedUnityEventBase> IEnumerable<NamedUnityEventBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7C2F3C0", Offset = "0x7C2E5C0", VA = "0x187C2F3C0", Slot = "5")]
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
		private Dictionary<string, RecRoomObjectProperty> JAMGHLDPLJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[HideInInspector]
		[SerializeField]
		private StudioFunctionList studioFunctions;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RecRoomObjectProperty[] AABLBOEDPKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public NamedUnityEventBase[] MKFPEOHGOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public RecRoomObjectConfiguration BODEJJICNJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7C39E30", Offset = "0x7C39030", VA = "0x187C39E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<StudioFunction> MIFAGIHAJEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObjectBase, string> LOOCABJGEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7C39D80", Offset = "0x7C38F80", VA = "0x187C39D80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7C39EB0", Offset = "0x7C390B0", VA = "0x187C39EB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C39400", Offset = "0x7C38600", VA = "0x187C39400")]
		public bool TryGetProperty(string LFNMBEJGJCH, [Out] RecRoomObjectProperty FPOONLFOOIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C393E0", Offset = "0x7C385E0", VA = "0x187C393E0")]
		public void SendCircuitsEvent(string EHIDFGOLHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C395D0", Offset = "0x7C387D0", VA = "0x187C395D0")]
		public bool TryRaiseUnityEvent(string EHIDFGOLHLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x353B9B0", Offset = "0x353ABB0", VA = "0x18353B9B0")]
		private bool BLNIHAFOCAO<T0, T1, TEvent>(string EHIDFGOLHLB, T0 BFACADDNPLE, T1 EKJHCBIDNDF) where TEvent : UnityEvent<T0, T1>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C39B90", Offset = "0x7C38D90", VA = "0x187C39B90")]
		public bool TryRaiseUnityEvent(string EHIDFGOLHLB, bool OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C39AB0", Offset = "0x7C38CB0", VA = "0x187C39AB0")]
		public bool TryRaiseUnityEvent(string EHIDFGOLHLB, float OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C39900", Offset = "0x7C38B00", VA = "0x187C39900")]
		public bool TryRaiseUnityEvent(string EHIDFGOLHLB, int OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C397B0", Offset = "0x7C389B0", VA = "0x187C397B0")]
		public bool TryRaiseUnityEvent(string EHIDFGOLHLB, string OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C399D0", Offset = "0x7C38BD0", VA = "0x187C399D0")]
		public bool TryRaiseUnityEvent(string EHIDFGOLHLB, string BFACADDNPLE, bool EKJHCBIDNDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C39C60", Offset = "0x7C38E60", VA = "0x187C39C60")]
		public bool TryRaiseUnityEvent(string EHIDFGOLHLB, string BFACADDNPLE, float EKJHCBIDNDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C39890", Offset = "0x7C38A90", VA = "0x187C39890")]
		public bool TryRaiseUnityEvent(string EHIDFGOLHLB, string BFACADDNPLE, int EKJHCBIDNDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C39A40", Offset = "0x7C38C40", VA = "0x187C39A40")]
		public bool TryRaiseUnityEvent(string EHIDFGOLHLB, string BFACADDNPLE, string EKJHCBIDNDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C39340", Offset = "0x7C38540", VA = "0x187C39340")]
		[IteratorStateMachine(typeof(BKBLIPMDGCJ))]
		private IEnumerable<NamedUnityEventBase> EJICPFKOELH(string EHIDFGOLHLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C39150", Offset = "0x7C38350", VA = "0x187C39150")]
		private bool DJKNPDMMBPO(string EHIDFGOLHLB, Func<NamedUnityEventBase, bool> ILNHKGACDOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C39CD0", Offset = "0x7C38ED0", VA = "0x187C39CD0")]
		protected RecRoomObjectBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C9F0", Offset = "0x7C3BBF0", VA = "0x187C3C9F0")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CA30", Offset = "0x7C3BC30", VA = "0x187C3CA30")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CA70", Offset = "0x7C3BC70", VA = "0x187C3CA70")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CB30", Offset = "0x7C3BD30", VA = "0x187C3CB30")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CAF0", Offset = "0x7C3BCF0", VA = "0x187C3CAF0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CBB0", Offset = "0x7C3BDB0", VA = "0x187C3CBB0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CB70", Offset = "0x7C3BD70", VA = "0x187C3CB70")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CBF0", Offset = "0x7C3BDF0", VA = "0x187C3CBF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void InvokeEvent();

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "5")]
		public virtual bool TryInvokeEvent(bool OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "6")]
		public virtual bool TryInvokeEvent(float OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "7")]
		public virtual bool TryInvokeEvent(int OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "8")]
		public virtual bool TryInvokeEvent(string OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE4B0", Offset = "0x4CAD6B0", VA = "0x184CAE4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C37030", Offset = "0x7C36230", VA = "0x187C37030", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C37100", Offset = "0x7C36300", VA = "0x187C37100")]
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
		[Cpp2IlInjected.Address(RVA = "0x42DEC80", Offset = "0x42DDE80", VA = "0x1842DEC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x42DEC80", Offset = "0x42DDE80", VA = "0x1842DEC80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C36A00", Offset = "0x7C35C00", VA = "0x187C36A00", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C36A60", Offset = "0x7C35C60", VA = "0x187C36A60", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C36BD0", Offset = "0x7C35DD0", VA = "0x187C36BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C36C10", Offset = "0x7C35E10", VA = "0x187C36C10", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C36C70", Offset = "0x7C35E70", VA = "0x187C36C70", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C36DE0", Offset = "0x7C35FE0", VA = "0x187C36DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C36E20", Offset = "0x7C36020", VA = "0x187C36E20", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C36E80", Offset = "0x7C36080", VA = "0x187C36E80", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C36FF0", Offset = "0x7C361F0", VA = "0x187C36FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C37380", Offset = "0x7C36580", VA = "0x187C37380", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C373E0", Offset = "0x7C365E0", VA = "0x187C373E0", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C37550", Offset = "0x7C36750", VA = "0x187C37550")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C37140", Offset = "0x7C36340", VA = "0x187C37140", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C371A0", Offset = "0x7C363A0", VA = "0x187C371A0", Slot = "5")]
		public override bool TryInvokeEvent(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C37340", Offset = "0x7C36540", VA = "0x187C37340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C37590", Offset = "0x7C36790", VA = "0x187C37590", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C375F0", Offset = "0x7C367F0", VA = "0x187C375F0", Slot = "6")]
		public override bool TryInvokeEvent(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C37790", Offset = "0x7C36990", VA = "0x187C37790")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C377D0", Offset = "0x7C369D0", VA = "0x187C377D0", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C37830", Offset = "0x7C36A30", VA = "0x187C37830", Slot = "7")]
		public override bool TryInvokeEvent(int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C379D0", Offset = "0x7C36BD0", VA = "0x187C379D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C37A10", Offset = "0x7C36C10", VA = "0x187C37A10", Slot = "4")]
		public override void InvokeEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C37A70", Offset = "0x7C36C70", VA = "0x187C37A70", Slot = "8")]
		public override bool TryInvokeEvent(string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C37C00", Offset = "0x7C36E00", VA = "0x187C37C00")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x42DEC80", Offset = "0x42DDE80", VA = "0x1842DEC80")]
		public RecRoomObjectPrefabRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> : RecRoomUnitySceneSystemBase where TPrefabAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject>, new() where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> IEFGENALBBO;

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
		public static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> CLACNPDFIIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4C511E0", Offset = "0x4C503E0", VA = "0x184C511E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<TPrefabEntry> GIMJFOLMAIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x50D1EE0", Offset = "0x50D10E0", VA = "0x1850D1EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x50D1C30", Offset = "0x50D0E30", VA = "0x1850D1C30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x50D1D60", Offset = "0x50D0F60", VA = "0x1850D1D60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x90FE00", Offset = "0x90F000", VA = "0x18090FE00")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D1B80", Offset = "0x50D0D80", VA = "0x1850D1B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RecRoomObjectPrefabObjectBoardTemplate ObjectBoardTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HasObjectBoardData
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x50D1B20", Offset = "0x50D0D20", VA = "0x1850D1B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x50D18B0", Offset = "0x50D0AB0", VA = "0x1850D18B0", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabEntryBase<TRecRoomObject> JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x50D1A30", Offset = "0x50D0C30", VA = "0x1850D1A30", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x50D1B00", Offset = "0x50D0D00", VA = "0x1850D1B00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public byte[] ObjectBoard
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A0B0", Offset = "0x7C392B0", VA = "0x187C3A0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C39F70", Offset = "0x7C39170", VA = "0x187C39F70", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabObjectBoardTemplate JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A030", Offset = "0x7C39230", VA = "0x187C3A030")]
		private static bool GFPEDOIHKDA(byte[] NPLFAJOMJBI, byte[] JBBOJDFGDNL)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class RecRoomStudioAnimatorSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public interface IOGGPOKOIFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SetBoolParameterFromScript(string LMOANCJLHKC, bool IAPIOFHOONE);

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SetIntegerParameterFromScript(string LMOANCJLHKC, int IAPIOFHOONE);

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetFloatParameterFromScript(string LMOANCJLHKC, float IAPIOFHOONE);

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SetTriggerParameterFromScript(string LMOANCJLHKC);
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IOGGPOKOIFN PPLHLNKOKKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A4C0", Offset = "0x7C396C0", VA = "0x187C3A4C0")]
		public Animator GetControlledAnimator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A500", Offset = "0x7C39700", VA = "0x187C3A500")]
		public void SetBoolParameter(string LMOANCJLHKC, bool IAPIOFHOONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A690", Offset = "0x7C39890", VA = "0x187C3A690")]
		public void SetIntegerParameter(string LMOANCJLHKC, int IAPIOFHOONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A5C0", Offset = "0x7C397C0", VA = "0x187C3A5C0")]
		public void SetFloatParameter(string LMOANCJLHKC, float IAPIOFHOONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A750", Offset = "0x7C39950", VA = "0x187C3A750")]
		public void SetTriggerParameter(string LMOANCJLHKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
		[Tooltip("If true, the object can rotate clockwise/counter-clockwise to match the players rotation (z-axis rotation)")]
		[SerializeField]
		private bool rollRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("If true, makes the player \"look through\" the object rather than \"look at\" the object to accomadate Unity UI expectations")]
		[SerializeField]
		private bool faceAwayFromCamera;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool BDIMPBCAGEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBB5FE0", Offset = "0xBB51E0", VA = "0x180BB5FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8FA8F0", Offset = "0x8F9AF0", VA = "0x1808FA8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool OIBBDBICCFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xE8C820", Offset = "0xE8BA20", VA = "0x180E8C820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB9D780", Offset = "0xB9C980", VA = "0x180B9D780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool AMIOMDJCBFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xE8C810", Offset = "0xE8BA10", VA = "0x180E8C810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x271E080", Offset = "0x271D280", VA = "0x18271E080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IIJPLBJJANJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xE8C800", Offset = "0xE8BA00", VA = "0x180E8C800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x49F58D0", Offset = "0x49F4AD0", VA = "0x1849F58D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A800", Offset = "0x7C39A00", VA = "0x187C3A800")]
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
		[ConditionallyVisibleField("canBeAnchored", true, false)]
		[Tooltip("The way in which the menu frames up on screen")]
		[SerializeField]
		private AttachmentMode anchorAttachmentMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		[ConditionallyVisibleField("isInteractable", true, false)]
		[Tooltip("Optionally overwrite Rec Room's default behavior of when we show control hints while the cursor is over UI.")]
		private ControlPromptBehaviorType controlPromptBehaviorOverride;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool EILJMMCILBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xBB5FE0", Offset = "0xBB51E0", VA = "0x180BB5FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool OPGJJAOKLPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xE8C820", Offset = "0xE8BA20", VA = "0x180E8C820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool NDPLAGDFIIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xE8C810", Offset = "0xE8BA10", VA = "0x180E8C810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public AttachmentMode INHCCKHGNLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x91B6D0", Offset = "0x91A8D0", VA = "0x18091B6D0")]
			get
			{
				return default(AttachmentMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public ControlPromptBehaviorType LJBGOCDCKIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0")]
			get
			{
				return default(ControlPromptBehaviorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AttachmentMode> EDEJOCFNMLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A850", Offset = "0x7C39A50", VA = "0x187C3A850")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A9A0", Offset = "0x7C39BA0", VA = "0x187C3A9A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action EFGJIFACPJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A900", Offset = "0x7C39B00", VA = "0x187C3A900")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7C3AA50", Offset = "0x7C39C50", VA = "0x187C3AA50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A810", Offset = "0x7C39A10", VA = "0x187C3A810")]
		public void AnchorCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A830", Offset = "0x7C39A30", VA = "0x187C3A830")]
		public void DetachCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
		public bool IHLBCGCMNPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1D60F90", Offset = "0x1D60190", VA = "0x181D60F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		protected RecRoomStudioDisableRenderInShareCamPhotoBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class RecRoomStudioHudCanvasBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		protected RecRoomStudioHudCanvasBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class RecRoomStudioInstanceRecolorBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		[HideInInspector]
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
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB970", Offset = "0xAAAB70", VA = "0x180AAB970")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7C3ADE0", Offset = "0x7C39FE0", VA = "0x187C3ADE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AAF0", Offset = "0x7C39CF0", VA = "0x187C3AAF0")]
		private void ApplyColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AC90", Offset = "0x7C39E90", VA = "0x187C3AC90")]
		private void ClearColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AC60", Offset = "0x7C39E60", VA = "0x187C3AC60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Action<string> SanitizeAndSetTextAction
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B650", Offset = "0x7C3A850", VA = "0x187C3B650")]
		public void SetText(string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		protected RecRoomStudioPlatformTextFilterBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class RecRoomStudioRecNetImageBase : RawImage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[Tooltip("If true, the image will be automatically cropped into a square.")]
		[SerializeField]
		private bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private BGJBDFOKPCL EKNHJHIAMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private IJJCLGKGILP MIPHKGMEGLG;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IJJCLGKGILP FFGEEHIBEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA3A3D0", Offset = "0xA395D0", VA = "0x180A3A3D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA448A0", Offset = "0xA43AA0", VA = "0x180A448A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public BGJBDFOKPCL JHIDHINIPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA3A2E0", Offset = "0xA394E0", VA = "0x180A3A2E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B760", Offset = "0x7C3A960", VA = "0x187C3B760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool GLIKILBKLHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x98BB60", Offset = "0x98AD60", VA = "0x18098BB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B6F0", Offset = "0x7C3A8F0", VA = "0x187C3B6F0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B750", Offset = "0x7C3A950", VA = "0x187C3B750")]
		protected RecRoomStudioRecNetImageBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class RecRoomUnitySceneSystemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
		private static RecRoomVisualPostProcessingBase IEFGENALBBO;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static RecRoomVisualPostProcessingBase CLACNPDFIIL
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7C3BA70", Offset = "0x7C3AC70", VA = "0x187C3BA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B840", Offset = "0x7C3AA40", VA = "0x187C3B840")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B930", Offset = "0x7C3AB30", VA = "0x187C3B930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		protected RecRoomVisualPostProcessingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyEnabledFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7C33D80", Offset = "0x7C32F80", VA = "0x187C33D80")]
		public ConditionallyEnabledFieldAttribute(string propertyName, bool propertyValue, string disabledTooltip)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class GLIFNMPIONI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C34510", Offset = "0x7C33710", VA = "0x187C34510")]
	protected GLIFNMPIONI(string LFNMBEJGJCH, bool DKFPOAHKPFF)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ConditionallyVisibleFieldAttribute : GLIFNMPIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C33DE0", Offset = "0x7C32FE0", VA = "0x187C33DE0")]
		public ConditionallyVisibleFieldAttribute(string propertyName, bool propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class IntConditionallyVisibleFieldAttribute : GLIFNMPIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C360C0", Offset = "0x7C352C0", VA = "0x187C360C0")]
		public IntConditionallyVisibleFieldAttribute(string propertyName, int propertyValue, bool isReadOnly = false)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface BGJBDFOKPCL
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string HBJLPMKHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface IJJCLGKGILP
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOOADBDCABB();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOGJGILJKOH(BGJBDFOKPCL AEALMMMIOCP);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface HKNMPFFOODB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AttachMarkupComponent(T KOEALGOMPAM, int JDDGJKDAOJI, bool EIBDJAPPMDK);
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[SerializeField]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		[ConditionallyEnabledField("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		[ConditionallyEnabledField("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
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

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7C39F60", Offset = "0x7C39160", VA = "0x187C39F60")]
		public RecRoomObjectConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
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
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
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

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x353C450", Offset = "0x353B650", VA = "0x18353C450")]
		public bool EKHOHBPCPIG<T>([Out] T OMEFCJCOLII, [Out] string GILNIHGCEJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A2D0", Offset = "0x7C394D0", VA = "0x187C3A2D0")]
		public static string AEDLMMEIGHA(Type EBJDGDIMGBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
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

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private string FormattedPropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7C3A260", Offset = "0x7C39460", VA = "0x187C3A260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A1F0", Offset = "0x7C393F0", VA = "0x187C3A1F0")]
		public MethodInfo JJFEFKBIJGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A100", Offset = "0x7C39300", VA = "0x187C3A100")]
		public string IHHFHHJKFBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class RecRoomStudioAutoCreatedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA59310", Offset = "0xA58510", VA = "0x180A59310")]
		protected RecRoomStudioAutoCreatedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class RecRoomStudioAutoGeneratedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA59310", Offset = "0xA58510", VA = "0x180A59310")]
		public RecRoomStudioAutoGeneratedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class RecRoomStudioNavMeshCutBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public const float MINIMUM_WIDTH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[DOCGPFCJDCE("When using a Nav Mesh Cut, you may also want to set NavMesh Generation Mode to Ignore in the configure menu so the associated Rec Room Object won't bake into the navmesh on its own.")]
		[SerializeField]
		private Vector3 size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private Vector3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[DOCGPFCJDCE("Ignoring rotation leads to better performance, but ignoring rotation also means that the box must be aligned with the X, Y, and Z axes.")]
		[Header("Optimization")]
		[SerializeField]
		private bool ignoreRotationAndScale;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[Obsolete]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B1B0", Offset = "0x7C3A3B0", VA = "0x187C3B1B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B4D0", Offset = "0x7C3A6D0", VA = "0x187C3B4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[Obsolete]
		public float Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xE8C830", Offset = "0xE8BA30", VA = "0x180E8C830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B430", Offset = "0x7C3A630", VA = "0x187C3B430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool IgnoreRotationAndScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xC0B620", Offset = "0xC0A820", VA = "0x180C0B620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B4B0", Offset = "0x7C3A6B0", VA = "0x187C3B4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector3 Size
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xBB4930", Offset = "0xBB3B30", VA = "0x180BB4930")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B550", Offset = "0x7C3A750", VA = "0x187C3B550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float HeightSizeY
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xE8C830", Offset = "0xE8BA30", VA = "0x180E8C830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B430", Offset = "0x7C3A630", VA = "0x187C3B430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float XZUniformSquareSize
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B5D0", Offset = "0x7C3A7D0", VA = "0x187C3B5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector3 Center
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xBB4950", Offset = "0xBB3B50", VA = "0x180BB4950")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B3B0", Offset = "0x7C3A5B0", VA = "0x187C3B3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OnSettingsChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B110", Offset = "0x7C3A310", VA = "0x187C3B110")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B310", Offset = "0x7C3A510", VA = "0x187C3B310")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action OnForceUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B070", Offset = "0x7C3A270", VA = "0x187C3B070")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B270", Offset = "0x7C3A470", VA = "0x187C3B270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<bool> OnEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7C3AFC0", Offset = "0x7C3A1C0", VA = "0x187C3AFC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7C3B1C0", Offset = "0x7C3A3C0", VA = "0x187C3B1C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AE60", Offset = "0x7C3A060", VA = "0x187C3AE60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xD3A3E0", Offset = "0xD395E0", VA = "0x180D3A3E0")]
		[Obsolete]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xD3A3E0", Offset = "0xD395E0", VA = "0x180D3A3E0")]
		public void ForceQueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AF50", Offset = "0x7C3A150", VA = "0x187C3AF50")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AF50", Offset = "0x7C3A150", VA = "0x187C3AF50")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C3AF90", Offset = "0x7C3A190", VA = "0x187C3AF90")]
		protected RecRoomStudioNavMeshCutBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct NFOMMMKOPIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public byte[] DBAABDGHMBI;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	public NFOMMMKOPIO(byte[] OCPJHHIMKFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct ABOAKLBOLOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public byte[] DBAABDGHMBI;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	public ABOAKLBOLOA(byte[] OCPJHHIMKFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class GDDLMANMIIN
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7C33F90", Offset = "0x7C33190", VA = "0x187C33F90")]
	public static (NFOMMMKOPIO, ABOAKLBOLOA) HNGNFFDNFEE(Stream OPLAKFCFCLD)
	{
		return default((NFOMMMKOPIO, ABOAKLBOLOA));
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7C341C0", Offset = "0x7C333C0", VA = "0x187C341C0")]
	public static void MGEAHJEKKPJ(Stream OPLAKFCFCLD, NFOMMMKOPIO JPGPNLNCOHG, ABOAKLBOLOA KEOAELBKNOE)
	{
	}
}
namespace RecRoom.Core.Studio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
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

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x271D120", Offset = "0x271C320", VA = "0x18271D120")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x71EE230", Offset = "0x71ED430", VA = "0x1871EE230")]
		public SerializedGuid([In] Guid IBPGMNEANFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x71EE1A0", Offset = "0x71ED3A0", VA = "0x1871EE1A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BB40", Offset = "0x7C3AD40", VA = "0x187C3BB40", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x71EDFD0", Offset = "0x71ED1D0", VA = "0x1871EDFD0", Slot = "7")]
		public bool Equals(SerializedGuid JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BAB0", Offset = "0x7C3ACB0", VA = "0x187C3BAB0", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x71EE0A0", Offset = "0x71ED2A0", VA = "0x1871EE0A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x71EDFA0", Offset = "0x71ED1A0", VA = "0x1871EDFA0", Slot = "6")]
		public int CompareTo(SerializedGuid JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BBC0", Offset = "0x7C3ADC0", VA = "0x187C3BBC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SerializedTypeNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public SerializedTypeNameAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class GKPFBPPAABB
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public static readonly KJMCEDJMPPA CONGFHFMEAE;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly KJMCEDJMPPA CLDBGECLOON;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly KJMCEDJMPPA JEDOBFLJPBP;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public static readonly KJMCEDJMPPA CDAEMIJDGKC;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public static readonly KJMCEDJMPPA OGNBOBFGPNL;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly KJMCEDJMPPA IBHFIICPICF;
}
namespace RecRoom.Core.Studio.StudioFunctions
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
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

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Parameter Binding
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public Argument()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
		public Argument(string LMOANCJLHKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F190", Offset = "0x7C2E390", VA = "0x187C2F190")]
		public object HLOPAIACMKF(object[] GEELNMCDEPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F1E0", Offset = "0x7C2E3E0", VA = "0x187C2F1E0")]
		internal void IEAGKCLMGLH(IReadOnlyList<Parameter> HLJPDMABNJO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument<T> : Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SerializeField]
		protected T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x48F1F00", Offset = "0x48F1100", VA = "0x1848F1F00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x48F1A30", Offset = "0x48F0C30", VA = "0x1848F1A30")]
		protected Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[UnityEngine.Scripting.Preserve]
	public sealed class VoidArgument : Argument
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly VoidArgument Instance;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7C3CF20", Offset = "0x7C3C120", VA = "0x187C3CF20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CEA0", Offset = "0x7C3C0A0", VA = "0x187C3CEA0")]
		private VoidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x534C740", Offset = "0x534B940", VA = "0x18534C740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3FAD2A0", Offset = "0x3FAC4A0", VA = "0x183FAD2A0")]
		protected ValueArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
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

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x597E3E0", Offset = "0x597D5E0", VA = "0x18597E3E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x597E140", Offset = "0x597D340", VA = "0x18597E140")]
		private Type DCFDOIDCDOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3EC51A0", Offset = "0x3EC43A0", VA = "0x183EC51A0")]
		protected ClassArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolArgument : ValueArgument<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2FE20", Offset = "0x7C2F020", VA = "0x187C2FE20")]
		public BoolArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorArgument : ValueArgument<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7C32FD0", Offset = "0x7C321D0", VA = "0x187C32FD0")]
		public ColorArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Argument : ValueArgument<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7C32F50", Offset = "0x7C32150", VA = "0x187C32F50")]
		public Color32Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[UnityEngine.Scripting.Preserve]
	public sealed class GuidArgument : ValueArgument<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7C34560", Offset = "0x7C33760", VA = "0x187C34560")]
		public GuidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatArgument : ValueArgument<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7C33EB0", Offset = "0x7C330B0", VA = "0x187C33EB0")]
		public FloatArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntArgument : ValueArgument<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7C36080", Offset = "0x7C35280", VA = "0x187C36080")]
		public IntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ShortArgument : ValueArgument<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BBD0", Offset = "0x7C3ADD0", VA = "0x187C3BBD0")]
		public ShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringArgument : ValueArgument<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BC10", Offset = "0x7C3AE10", VA = "0x187C3BC10")]
		public StringArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UIntArgument : ValueArgument<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C970", Offset = "0x7C3BB70", VA = "0x187C3C970")]
		public UIntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UShortArgument : ValueArgument<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C9B0", Offset = "0x7C3BBB0", VA = "0x187C3C9B0")]
		public UShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Argument : ValueArgument<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CC30", Offset = "0x7C3BE30", VA = "0x187C3CC30")]
		public Vector2Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Argument : ValueArgument<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CCB0", Offset = "0x7C3BEB0", VA = "0x187C3CCB0")]
		public Vector3Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionArgument : ValueArgument<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7C37D80", Offset = "0x7C36F80", VA = "0x187C37D80")]
		public QuaternionArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UnityObjectArgument : ClassArgument<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CAB0", Offset = "0x7C3BCB0", VA = "0x187C3CAB0")]
		public UnityObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageArgument : ValueArgument<BGJBDFOKPCL>
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7C37E00", Offset = "0x7C37000", VA = "0x187C37E00")]
		public RecNetImageArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void HJOIGAOEAFJ(string PPEKKHDCOAD, object[] GEELNMCDEPJ, object[] AFPHNHPADFE);

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected internal abstract void FAHOOOAKJGP(IReadOnlyList<Parameter> HLJPDMABNJO, IReadOnlyList<Parameter> ELMABPNEBJP);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		protected Instruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
		public override void HJOIGAOEAFJ(string PPEKKHDCOAD, object[] GEELNMCDEPJ, object[] AFPHNHPADFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		protected internal override void FAHOOOAKJGP(IReadOnlyList<Parameter> HLJPDMABNJO, IReadOnlyList<Parameter> ELMABPNEBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PlaceholderInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[UnityEngine.Scripting.Preserve]
	public sealed class CallInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private delegate void CGEEBEAPPHG(UnityEngine.Object MKMPLOHPJDC, MethodInfo PGNIEFPKJMB, object[] IKIKJBDMING);

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
		private CGEEBEAPPHG optimization;

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
		private static readonly Dictionary<MethodInfo, CGEEBEAPPHG> optimizations;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly Dictionary<string, int> cachedAnimatorStringToHashResults;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7C32ED0", Offset = "0x7C320D0", VA = "0x187C32ED0")]
		public CallInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7C30BF0", Offset = "0x7C2FDF0", VA = "0x187C30BF0", Slot = "4")]
		public override void HJOIGAOEAFJ(string PPEKKHDCOAD, object[] GEELNMCDEPJ, object[] AFPHNHPADFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7C30950", Offset = "0x7C2FB50", VA = "0x187C30950")]
		private void FNNKFFGKLJA(object[] AFPHNHPADFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7C31200", Offset = "0x7C30400", VA = "0x187C31200")]
		private void IFMLEKPKOLA(object[] AFPHNHPADFE, object CIJFNKOADLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7C30790", Offset = "0x7C2F990", VA = "0x187C30790", Slot = "5")]
		protected internal override void FAHOOOAKJGP(IReadOnlyList<Parameter> HLJPDMABNJO, IReadOnlyList<Parameter> ELMABPNEBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7C312A0", Offset = "0x7C304A0", VA = "0x187C312A0")]
		[UnityEngine.Scripting.Preserve]
		private static void KGKKKFKGKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7C30650", Offset = "0x7C2F850", VA = "0x187C30650")]
		private MethodInfo CHIFALLADNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7C308C0", Offset = "0x7C2FAC0", VA = "0x187C308C0")]
		internal MethodInfo FJDNOOAAAPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7C31540", Offset = "0x7C30740", VA = "0x187C31540")]
		internal static bool OGAIDLIOKPE(UnityEngine.Object MKMPLOHPJDC, string ANDAJHNCLND, Argument[] GIMIPDCICCE, [Out] MethodInfo PGNIEFPKJMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7C31430", Offset = "0x7C30630", VA = "0x187C31430")]
		private static bool MDPJLAEJDLK(MethodInfo PGNIEFPKJMB, Type[] KMDHPOICOPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7C30390", Offset = "0x7C2F590", VA = "0x187C30390")]
		private static object[] AGECBMOFDHC(int PKDPKMFDAID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7C30A00", Offset = "0x7C2FC00", VA = "0x187C30A00")]
		private object[] HGBLLOMIBDD(object[] GEELNMCDEPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7C31F90", Offset = "0x7C31190", VA = "0x187C31F90")]
		private void PEPDGOOCCBA(object[] IKIKJBDMING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7C31FF0", Offset = "0x7C311F0", VA = "0x187C31FF0")]
		private static void PGPAMCEGFBP(UnityEngine.Object MKMPLOHPJDC, MethodInfo PGNIEFPKJMB, object[] IKIKJBDMING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7C319D0", Offset = "0x7C30BD0", VA = "0x187C319D0")]
		private static void OKNLOEKNMID(UnityEngine.Object MKMPLOHPJDC, MethodInfo PGNIEFPKJMB, object[] IKIKJBDMING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7C31E60", Offset = "0x7C31060", VA = "0x187C31E60")]
		private static void PCPPFJPMHBC(UnityEngine.Object MKMPLOHPJDC, MethodInfo PGNIEFPKJMB, object[] IKIKJBDMING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7C31300", Offset = "0x7C30500", VA = "0x187C31300")]
		private static void KKADAFAONKE(UnityEngine.Object MKMPLOHPJDC, MethodInfo PGNIEFPKJMB, object[] IKIKJBDMING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7C31B00", Offset = "0x7C30D00", VA = "0x187C31B00")]
		private static MethodInfo OPCDDBGGOPP(Type COCFDEALNDD, string ANDAJHNCLND, params Type[] FDEIDOEILNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7C30560", Offset = "0x7C2F760", VA = "0x187C30560")]
		private static int BKGNOADBFLE(string LMOANCJLHKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7C30B70", Offset = "0x7C2FD70", VA = "0x187C30B70")]
		public static void HIKCDOFLLHP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
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

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7C33D00", Offset = "0x7C32F00", VA = "0x187C33D00")]
		public ConditionalInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7C33860", Offset = "0x7C32A60", VA = "0x187C33860", Slot = "4")]
		public override void HJOIGAOEAFJ(string PPEKKHDCOAD, object[] GEELNMCDEPJ, object[] AFPHNHPADFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7C335D0", Offset = "0x7C327D0", VA = "0x187C335D0", Slot = "5")]
		protected internal override void FAHOOOAKJGP(IReadOnlyList<Parameter> HLJPDMABNJO, IReadOnlyList<Parameter> ELMABPNEBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7C33C90", Offset = "0x7C32E90", VA = "0x187C33C90")]
		private void IEAGKCLMGLH(IReadOnlyList<Parameter> HLJPDMABNJO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
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

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public IReadOnlyList<Instruction> Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7C33580", Offset = "0x7C32780", VA = "0x187C33580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7C33500", Offset = "0x7C32700", VA = "0x187C33500")]
		public Condition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7C33360", Offset = "0x7C32560", VA = "0x187C33360")]
		public static bool JKDJCFEDPGK(string OMEFCJCOLII, [Out] bool KPLNNFCPIKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7C33430", Offset = "0x7C32630", VA = "0x187C33430")]
		public static bool KLNKGOAEBAB(string OMEFCJCOLII, [Out] int HPCHIMLBENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7C33100", Offset = "0x7C32300", VA = "0x187C33100")]
		public bool EOMCMHCKHCM(bool ODHFLEMBKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7C331F0", Offset = "0x7C323F0", VA = "0x187C331F0")]
		public bool GJKAIMIHKNL(int AECHBINAIFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7C330E0", Offset = "0x7C322E0", VA = "0x187C330E0")]
		public bool BBFOENPHAPP(string AFJMEJNMLGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7C332D0", Offset = "0x7C324D0", VA = "0x187C332D0")]
		public void HJOIGAOEAFJ(string PPEKKHDCOAD, object[] GEELNMCDEPJ, object[] AFPHNHPADFE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
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

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x116FCC0", Offset = "0x116EEC0", VA = "0x18116FCC0")]
		public Parameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7C37C40", Offset = "0x7C36E40", VA = "0x187C37C40")]
		internal void LNFAMNDLIIA(int OKCJJLOLBFB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderParameter : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x7C37D20", Offset = "0x7C36F20", VA = "0x187C37D20", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter<T> : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4F659B0", Offset = "0x4F64BB0", VA = "0x184F659B0")]
		protected Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x53A1DE0", Offset = "0x53A0FE0", VA = "0x1853A1DE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3FAD2A0", Offset = "0x3FAC4A0", VA = "0x183FAD2A0")]
		protected ValueParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
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

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x597E510", Offset = "0x597D710", VA = "0x18597E510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x597E450", Offset = "0x597D650", VA = "0x18597E450")]
		private Type DCFDOIDCDOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EC51A0", Offset = "0x3EC43A0", VA = "0x183EC51A0")]
		protected ClassParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolParameter : ValueParameter<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C2FE60", Offset = "0x7C2F060", VA = "0x187C2FE60")]
		public BoolParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorParameter : ValueParameter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C33010", Offset = "0x7C32210", VA = "0x187C33010")]
		public ColorParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Parameter : ValueParameter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C32F90", Offset = "0x7C32190", VA = "0x187C32F90")]
		public Color32Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatParameter : ValueParameter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C33EF0", Offset = "0x7C330F0", VA = "0x187C33EF0")]
		public FloatParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntParameter : ValueParameter<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C36120", Offset = "0x7C35320", VA = "0x187C36120")]
		public IntParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringParameter : ValueParameter<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BC50", Offset = "0x7C3AE50", VA = "0x187C3BC50")]
		public StringParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Parameter : ValueParameter<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CC70", Offset = "0x7C3BE70", VA = "0x187C3CC70")]
		public Vector2Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Parameter : ValueParameter<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CCF0", Offset = "0x7C3BEF0", VA = "0x187C3CCF0")]
		public Vector3Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionParameter : ValueParameter<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C37DC0", Offset = "0x7C36FC0", VA = "0x187C37DC0")]
		public QuaternionParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageParameter : ValueParameter<BGJBDFOKPCL>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C37E40", Offset = "0x7C37040", VA = "0x187C37E40")]
		public RecNetImageParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
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

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C6A0", Offset = "0x7C3B8A0", VA = "0x187C3C6A0")]
		public StudioFunction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C070", Offset = "0x7C3B270", VA = "0x187C3C070")]
		public void HJOIGAOEAFJ(object[] GEELNMCDEPJ, object[] AFPHNHPADFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C3A0", Offset = "0x7C3B5A0", VA = "0x187C3C3A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C260", Offset = "0x7C3B460", VA = "0x187C3C260")]
		private void OMKJHPLAGCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C000", Offset = "0x7C3B200", VA = "0x187C3C000")]
		private void FAHOOOAKJGP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[UnityEngine.Scripting.Preserve]
	public class StudioFunctionList : IReadOnlyList<StudioFunction>, IEnumerable<StudioFunction>, IEnumerable, IReadOnlyCollection<StudioFunction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		[HideInInspector]
		private StudioFunction[] array;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private IReadOnlyList<StudioFunction> ReadOnlyList
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C3BFB0", Offset = "0x7C3B1B0", VA = "0x187C3BFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x7C3BDE0", Offset = "0x7C3AFE0", VA = "0x187C3BDE0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public StudioFunction this[int CPLNODNGKGB]
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x7C3BED0", Offset = "0x7C3B0D0", VA = "0x187C3BED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BC90", Offset = "0x7C3AE90", VA = "0x187C3BC90", Slot = "6")]
		public IEnumerator<StudioFunction> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BD10", Offset = "0x7C3AF10", VA = "0x187C3BD10", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BD90", Offset = "0x7C3AF90", VA = "0x187C3BD90")]
		public StudioFunctionList()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class CGMGNMKKIGJ
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C2FFA0", Offset = "0x7C2F1A0", VA = "0x187C2FFA0")]
	public static string LCMDPLBLOBA(this Type MDOOANEGCAH)
	{
		return null;
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public abstract class RecRoomStudioAvatarItemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
