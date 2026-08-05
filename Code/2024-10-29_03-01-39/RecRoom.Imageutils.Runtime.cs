using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5340", Offset = "0x6ED4340", VA = "0x186ED5340")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.Image
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6ED25B0", Offset = "0x6ED15B0", VA = "0x186ED25B0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum ENCGFHFCIGC
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HCBIEALPJBG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ENCGFHFCIGC AHNFMCJPOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FKNHBJBMGKH(VertexAttributeFormat PKNNBLNOLJP, int AGGMJNLJLFD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KLNHOMJLKPC
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5750", Offset = "0x6ED4750", VA = "0x186ED5750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5740", Offset = "0x6ED4740", VA = "0x186ED5740")]
		public Resolution(uint GOCMFEAMGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99A6C0", Offset = "0x9996C0", VA = "0x18099A6C0")]
		public Resolution(uint GOCMFEAMGHO, uint AEFHGLLPABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5650", Offset = "0x6ED4650", VA = "0x186ED5650")]
		public static Resolution KICADFKANDI(Resolution[] HKFJGLOCDGD, Resolution OAHEMDPBONJ, int FGPAGDLELDE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class BJLHFLCIAHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution KJEJMPKPCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? KIOJKBAFLDA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint GOCMFEAMGHO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED2000", Offset = "0x6ED1000", VA = "0x186ED2000")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution KPMAAKCLIOP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED2010", Offset = "0x6ED1010", VA = "0x186ED2010")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA2B700", Offset = "0xA2A700", VA = "0x180A2B700")]
		public BJLHFLCIAHN(Resolution KJEJMPKPCMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6ED2360", Offset = "0x6ED1360", VA = "0x186ED2360")]
		private static Resolution LBOCJFLIMJF(Resolution KIOJKBAFLDA, ENCGFHFCIGC JDDJHAONDEP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class FELDFADMLNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution LGPPFFIEPHM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution BOOCCDJHPAD;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution PIHPNACHOIB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution FOPPIIKBJBD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution HEHJOOPCAIB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OIMJNCDOOEC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] AMNMFBHDCCJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class AHJFPGGHPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution NIGODPHJNEK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution BCLFJJIAHBC;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution POAPNGOIPIH;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution ADDLPKPADBO;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution GNCDLAJODNM;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] AMNMFBHDCCJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1CE0", Offset = "0x6ED0CE0", VA = "0x186ED1CE0")]
		public static Resolution KCINJGNEIDM(uint IMBLFJLFJPK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution INMLGAFBNFE;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class DOCICFIILKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2EF0", Offset = "0x6ED1EF0", VA = "0x186ED2EF0")]
	public static bool MMDHOMBLMNP(byte[] CONAFKKIHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2C50", Offset = "0x6ED1C50", VA = "0x186ED2C50")]
	public static bool IBABKCOLDKF(byte[] CONAFKKIHKL, [Out] int IMBLFJLFJPK, [Out] int KJLGCHNIMAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2E60", Offset = "0x6ED1E60", VA = "0x186ED2E60")]
	private static int MHGFCOENIKJ(byte[] CONAFKKIHKL, int KECPKLHBJEB, [Out] ushort FMJPOLOENNN)
	{
		return default(int);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[Flags]
		public enum FNCPBKDNFHI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private class CIIBMLGCDFK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string DMCFPOLFNCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D HKBDFPPGPLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FNCPBKDNFHI KDONFEOHIDC;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6ED2560", Offset = "0x6ED1560", VA = "0x186ED2560")]
			public CIIBMLGCDFK(string DMCFPOLFNCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x467BE80", Offset = "0x467AE80", VA = "0x18467BE80")]
			public CIIBMLGCDFK(string DMCFPOLFNCF, Texture2D JKGKKEHABOF, FNCPBKDNFHI JAGJOHJPJJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6ED2520", Offset = "0x6ED1520", VA = "0x186ED2520", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class HELJEGHDEII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FNCPBKDNFHI textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public HELJEGHDEII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6ED3220", Offset = "0x6ED2220", VA = "0x186ED3220")]
			internal void DFJKJBFHBNO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class IGKEGCAKEBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public IGKEGCAKEBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED3260", Offset = "0x6ED2260", VA = "0x186ED3260")]
			internal HNNHLFIKIJD NKDFIAKCMAD(Texture2D t2d)
			{
				return default(HNNHLFIKIJD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JNMJKFIAJGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public JNMJKFIAJGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6ED32A0", Offset = "0x6ED22A0", VA = "0x186ED32A0")]
			internal void LBLJJNGDAND()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private OBJFFICJNII<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private CIIBMLGCDFK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private OBJFFICJNII<HNNHLFIKIJD> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private OBJFFICJNII<HNNHLFIKIJD> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x98E930", Offset = "0x98D930", VA = "0x18098E930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private CIIBMLGCDFK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4B60", Offset = "0x6ED3B60", VA = "0x186ED4B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4A90", Offset = "0x6ED3A90", VA = "0x186ED4A90")]
		public ManagedTexture(string DMCFPOLFNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4AF0", Offset = "0x6ED3AF0", VA = "0x186ED4AF0")]
		public ManagedTexture(string DMCFPOLFNCF, bool DENPDHOMAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED48C0", Offset = "0x6ED38C0", VA = "0x186ED48C0")]
		public void NCMPFAGOEPK(RenderTexture FGKBJGPHADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4080", Offset = "0x6ED3080", VA = "0x186ED4080")]
		public OBJFFICJNII<Texture2D> JKJMIIJNOBO(FNCPBKDNFHI JAGJOHJPJJD, bool KJNBMLJFGHM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4900", Offset = "0x6ED3900", VA = "0x186ED4900")]
		public OBJFFICJNII<HNNHLFIKIJD> PDOEPDKDMLM(bool KJNBMLJFGHM = false, int EDBBCFFPDBP = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3CE0", Offset = "0x6ED2CE0", VA = "0x186ED3CE0")]
		public OBJFFICJNII<HNNHLFIKIJD> BHLFDAHICAA(bool KJNBMLJFGHM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4370", Offset = "0x6ED3370", VA = "0x186ED4370")]
		private static OBJFFICJNII<Texture2D> NANEPJHNCHJ(string DMCFPOLFNCF, RenderTexture FGKBJGPHADB, Texture2D EEADILIHGME, bool KJNBMLJFGHM, FNCPBKDNFHI JGGCIMKCNGB = FNCPBKDNFHI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3FE0", Offset = "0x6ED2FE0", VA = "0x186ED3FE0")]
		public void HKNLHKBLACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3FD0", Offset = "0x6ED2FD0", VA = "0x186ED3FD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3C80", Offset = "0x6ED2C80", VA = "0x186ED3C80")]
		[CompilerGenerated]
		private OBJFFICJNII<byte[]> AJBMEJBAPIN(Texture2D ADJMJEAGIME)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KCKOLFGACFA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FOCPEAIOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3120", Offset = "0x6ED2120", VA = "0x186ED3120")]
		public unsafe static extern void CHDIJGBJPLC(void* IDGFJHPEHOE, void* EMIPIILANPP, bool IDGGAGMMPAG, bool NKFOCBJFAFE, bool ONBBKHFKCIK, [Out] int IMBLFJLFJPK, [Out] int KJLGCHNIMAK, [Out] bool MFNDEOMDAIM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KIAFPDAPBOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool bgr;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KIAFPDAPBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3680", Offset = "0x6ED2680", VA = "0x186ED3680")]
		internal void MGECEBAJJPO(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KKNBBAONDLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3820", Offset = "0x6ED2820", VA = "0x186ED3820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3A40", Offset = "0x6ED2A40", VA = "0x186ED3A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CCKADHKOJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public CCKADHKOJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED24E0", Offset = "0x6ED14E0", VA = "0x186ED24E0")]
		internal void GBAJCEECJBB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct NENPCMECEKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool hasAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private CCKADHKOJNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4C10", Offset = "0x6ED3C10", VA = "0x186ED4C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED52D0", Offset = "0x6ED42D0", VA = "0x186ED52D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool KHFKFKEBMAO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
	public static bool GHFGFIEOPFL(byte[] DMPHJKHIJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3500", Offset = "0x6ED2500", VA = "0x186ED3500")]
	[AsyncStateMachine(typeof(KKNBBAONDLI))]
	public static Task<Texture2D> MHDIADIMOOB(byte[] DMPHJKHIJPK, bool JFNKIFKNANO = false, bool BOKKLPONKNN = false, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6ED33B0", Offset = "0x6ED23B0", VA = "0x186ED33B0")]
	[AsyncStateMachine(typeof(NENPCMECEKG))]
	private static Task<Texture2D> FKMFOJLEPHA(int IMBLFJLFJPK, int KJLGCHNIMAK, bool FPCNAMNMCMK, bool JFNKIFKNANO, bool BOKKLPONKNN, Action<NativeArray<byte>> DCCBOOJCNJJ, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3320", Offset = "0x6ED2320", VA = "0x186ED3320")]
	private static TextureFormat ECNILBEGNCB(bool FPCNAMNMCMK)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum FPODADBLMHD
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	RGB,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	BGR,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	RGBA,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ABGR
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal static class DCPLIHANGPP
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED25D0", Offset = "0x6ED15D0", VA = "0x186ED25D0")]
	public static bool BDGIHCFKMCD(byte[] CONAFKKIHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2810", Offset = "0x6ED1810", VA = "0x186ED2810")]
	public static void CHCKOJDDHCI(byte[] CONAFKKIHKL, [Out] int IMBLFJLFJPK, [Out] int KJLGCHNIMAK, [Out] FPODADBLMHD PKNNBLNOLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2B20", Offset = "0x6ED1B20", VA = "0x186ED2B20")]
	private static uint PNPHIFFOKON(byte[] CONAFKKIHKL, int NOAHCMMOGGC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2610", Offset = "0x6ED1610", VA = "0x186ED2610")]
	private static ulong CEDEMNIICHE(byte[] CONAFKKIHKL, int NOAHCMMOGGC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OOOKKOCPCKC
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5420", Offset = "0x6ED4420", VA = "0x186ED5420")]
	public static RenderTexture JHKAEPLEFDF(int IMBLFJLFJPK, int KJLGCHNIMAK, int IIFLFJEDIFN, Camera LDOEPMDDGHA, RenderTextureMemoryless PGKMKABMBNL = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6ED53C0", Offset = "0x6ED43C0", VA = "0x186ED53C0")]
	public static void BABIILKPKHO(RenderTexture FGKBJGPHADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class HDLGCLPGCPF<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct HPDOLJGMBHM : IEquatable<HPDOLJGMBHM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId GFIHEDJKEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly HEAEFDFDBEO ABBDDBBJMIC;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x422BCA0", Offset = "0x422ACA0", VA = "0x18422BCA0")]
		public HPDOLJGMBHM(TImageId MLAECOMLIEC, HEAEFDFDBEO KBMCEBBDDIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x422B6F0", Offset = "0x422A6F0", VA = "0x18422B6F0", Slot = "4")]
		public bool Equals(HDLGCLPGCPF<TImageId>.HPDOLJGMBHM DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x422B880", Offset = "0x422A880", VA = "0x18422B880", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x422BA80", Offset = "0x422AA80", VA = "0x18422BA80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x422BB50", Offset = "0x422AB50", VA = "0x18422BB50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GANIOLBFNPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public CLCEBAEDACG<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GANIOLBFNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x40E0450", Offset = "0x40DF450", VA = "0x1840E0450")]
		internal void JBGAANDPPNC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct KIMDPEMKDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public HPDOLJGMBHM cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HDLGCLPGCPF<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private HEAEFDFDBEO <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x467CB30", Offset = "0x467BB30", VA = "0x18467CB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x467D220", Offset = "0x467C220", VA = "0x18467D220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct EHONLJAKAHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public HEAEFDFDBEO textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public HDLGCLPGCPF<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3C58F20", Offset = "0x3C57F20", VA = "0x183C58F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3C59630", Offset = "0x3C58630", VA = "0x183C59630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct ICOEJBOEOPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x42ECBA0", Offset = "0x42EBBA0", VA = "0x1842ECBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x42ECFC0", Offset = "0x42EBFC0", VA = "0x1842ECFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int FABPJNENIIA = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim KNBFEHDDJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? LCMLNPNKABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, HEAEFDFDBEO, CancellationToken, Task<Texture2D>>? LEOPADFGABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? JMJDBFNFPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly OAOFDKPFEAD<HPDOLJGMBHM, Texture2D> KMHBHONAMCF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x41DEC80", Offset = "0x41DDC80", VA = "0x1841DEC80")]
	public HDLGCLPGCPF(Func<TImageId, CancellationToken, Task<byte[]>> CGNBOAECGNJ, [Optional] Func<TImageId, string>? MDLMBMAOMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x41DECD0", Offset = "0x41DDCD0", VA = "0x1841DECD0")]
	public HDLGCLPGCPF(Func<TImageId, HEAEFDFDBEO, CancellationToken, Task<Texture2D>> OMDLKPPEJJC, [Optional] Func<TImageId, string>? MDLMBMAOMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x41DEEE0", Offset = "0x41DDEE0", VA = "0x1841DEEE0")]
	private HDLGCLPGCPF(Func<TImageId, CancellationToken, Task<byte[]>>? CGNBOAECGNJ, Func<TImageId, HEAEFDFDBEO, CancellationToken, Task<Texture2D>>? OMDLKPPEJJC, Func<TImageId, string>? MDLMBMAOMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x41DE550", Offset = "0x41DD550", VA = "0x1841DE550")]
	public DIHMDMOKEDJ<Texture2D> MAECCCILHJN(TImageId LFEPOCIIBNP, HEAEFDFDBEO FEILEDMPIOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x41DDD50", Offset = "0x41DCD50", VA = "0x1841DDD50")]
	public void ANOEIGBIOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x41DDFA0", Offset = "0x41DCFA0", VA = "0x1841DDFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41DE760", Offset = "0x41DD760", VA = "0x1841DE760")]
	[AsyncStateMachine(typeof(HDLGCLPGCPF<>.KIMDPEMKDAA))]
	private Task<Texture2D> OABCEHBCDAO(HPDOLJGMBHM PCNGBBMCPJN, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41DE1C0", Offset = "0x41DD1C0", VA = "0x1841DE1C0")]
	[AsyncStateMachine(typeof(HDLGCLPGCPF<>.EHONLJAKAHO))]
	private Task<Texture2D> LKALBABCHLL(byte[] DMPHJKHIJPK, HEAEFDFDBEO FEILEDMPIOD, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41DDDB0", Offset = "0x41DCDB0", VA = "0x1841DDDB0")]
	private void APFEFICCOKD(Texture2D JKGKKEHABOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41DE050", Offset = "0x41DD050", VA = "0x1841DE050")]
	private bool GILCBGIHLAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x41DEA10", Offset = "0x41DDA10", VA = "0x1841DEA10")]
	private bool OAIPJHJNFEE(byte[] DMPHJKHIJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41DDDC0", Offset = "0x41DCDC0", VA = "0x1841DDDC0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(HDLGCLPGCPF<>.ICOEJBOEOPC))]
	internal static Task CAMNANPDMHP(IDisposable MNKGNAKBIPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum HEAEFDFDBEO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CompressTexture = 4
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
