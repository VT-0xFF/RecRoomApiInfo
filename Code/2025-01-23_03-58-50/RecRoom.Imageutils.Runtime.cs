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

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F77550", Offset = "0x6F75D50", VA = "0x186F77550")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F74120", Offset = "0x6F72920", VA = "0x186F74120")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JAFACHEDBCO
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6F779A0", Offset = "0x6F761A0", VA = "0x186F779A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F77990", Offset = "0x6F76190", VA = "0x186F77990")]
		public Resolution(uint KHINBLFKKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
		public Resolution(uint KHINBLFKKED, uint NCCBPIFKDGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F778A0", Offset = "0x6F760A0", VA = "0x186F778A0")]
		public static Resolution NHKKBFGFOCK(Resolution[] PJFCIKCGIIA, Resolution CENFPNKFNNH, int GMDMOBFHBPA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ICJGMDFDEEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution NHODLFGIFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? ALOFBCEIMIP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint KHINBLFKKED
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6F75190", Offset = "0x6F73990", VA = "0x186F75190")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution ELHMLAKHPJK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6F74E30", Offset = "0x6F73630", VA = "0x186F74E30")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9EFD40", VA = "0x1809F1540")]
		public ICJGMDFDEEI(Resolution NHODLFGIFCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F751A0", Offset = "0x6F739A0", VA = "0x186F751A0")]
		private static Resolution POMEPHFGILG(Resolution ALOFBCEIMIP, MEDLOLLILPO PIJCANBHCEK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MKFEIMBIBJA
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution BHGJFNNCBGP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution LAFEAHELKEM;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution MILMPPHJKEB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution NPGAOOPJPFG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution MPGMFCGEPMI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution IMMGJKAKDHD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] CPLAJHLBOGI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class DHDNGHFPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution HCFJPPEINDF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution ODNIOMKMNPK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution EEIOJOGCMEC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution AJGIMABCPKC;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution NOONFINIIEO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] CPLAJHLBOGI;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F74140", Offset = "0x6F72940", VA = "0x186F74140")]
		public static Resolution HDADLGANHOE(uint NNLGEFDHEAN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution LCMADEJLELL;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class NBDGHKKDNNO
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F77270", Offset = "0x6F75A70", VA = "0x186F77270")]
	public static bool NIKAHEGGHHD(byte[] EBNFOODJNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F772B0", Offset = "0x6F75AB0", VA = "0x186F772B0")]
	public static bool NKEJPAJMINL(byte[] EBNFOODJNOB, [Out] int NNLGEFDHEAN, [Out] int AKHNFOHBNBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F774C0", Offset = "0x6F75CC0", VA = "0x186F774C0")]
	private static int NMPKLEDEFMH(byte[] EBNFOODJNOB, int PPAKOENBJHH, [Out] ushort MMKJJNADKIG)
	{
		return default(int);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[Flags]
		public enum GAOIEEOEDID : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private class IIAMGCOMHNO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string IKMKCMDHFDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D PCBEOIDFFMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GAOIEEOEDID LBNPJKFOBAB;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F75360", Offset = "0x6F73B60", VA = "0x186F75360")]
			public IIAMGCOMHNO(string IKMKCMDHFDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E850", Offset = "0x4C4D050", VA = "0x184C4E850")]
			public IIAMGCOMHNO(string IKMKCMDHFDC, Texture2D NOCDIJBAKKD, GAOIEEOEDID JDPCMPMOMND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F75320", Offset = "0x6F73B20", VA = "0x186F75320", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HOFNNOCJODG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public GAOIEEOEDID textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public HOFNNOCJODG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F74DF0", Offset = "0x6F735F0", VA = "0x186F74DF0")]
			internal void JFHBNOBCOPI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class EFMDFEPMFBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public EFMDFEPMFBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F74490", Offset = "0x6F72C90", VA = "0x186F74490")]
			internal HDODNHCNBJO HJAAAKNKNPI(Texture2D t2d)
			{
				return default(HDODNHCNBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ILHAILOPAMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public ILHAILOPAMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F753B0", Offset = "0x6F73BB0", VA = "0x186F753B0")]
			internal void CEHKEMNHBPJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private AKLEHMINLPM<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IIAMGCOMHNO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private AKLEHMINLPM<HDODNHCNBJO> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private AKLEHMINLPM<HDODNHCNBJO> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ADD0", VA = "0x18095C5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private IIAMGCOMHNO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F771C0", Offset = "0x6F759C0", VA = "0x186F771C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F770F0", Offset = "0x6F758F0", VA = "0x186F770F0")]
		public ManagedTexture(string IKMKCMDHFDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F77150", Offset = "0x6F75950", VA = "0x186F77150")]
		public ManagedTexture(string IKMKCMDHFDC, bool PGOONJALELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F762E0", Offset = "0x6F74AE0", VA = "0x186F762E0")]
		public void FNFGCOCGNGA(RenderTexture FFJDHDDBCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F76850", Offset = "0x6F75050", VA = "0x186F76850")]
		public AKLEHMINLPM<Texture2D> OEDFHFIDMLG(GAOIEEOEDID JDPCMPMOMND, bool GNALNDDPEOE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F76620", Offset = "0x6F74E20", VA = "0x186F76620")]
		public AKLEHMINLPM<HDODNHCNBJO> MCMHHGIAPPD(bool GNALNDDPEOE = false, int BKJACEDFNCO = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F76320", Offset = "0x6F74B20", VA = "0x186F76320")]
		public AKLEHMINLPM<HDODNHCNBJO> LECGCEKGPFD(bool GNALNDDPEOE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F76BA0", Offset = "0x6F753A0", VA = "0x186F76BA0")]
		private static AKLEHMINLPM<Texture2D> PLBAJCJCKPF(string IKMKCMDHFDC, RenderTexture FFJDHDDBCKI, Texture2D KELKKJMOKGJ, bool GNALNDDPEOE, GAOIEEOEDID BKDAKGNGKBF = GAOIEEOEDID.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F767B0", Offset = "0x6F74FB0", VA = "0x186F767B0")]
		public void MPPPAICGCJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F762D0", Offset = "0x6F74AD0", VA = "0x186F762D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F76B40", Offset = "0x6F75340", VA = "0x186F76B40")]
		[CompilerGenerated]
		private AKLEHMINLPM<byte[]> PEFLKAIJLBK(Texture2D MENMHBCJADJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KHPDDHKOBKP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct GFODOOHFCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F74CF0", Offset = "0x6F734F0", VA = "0x186F74CF0")]
		public unsafe static extern void PPFAODNPLHK(void* KNJOPOAPHNN, void* CMEODCENMPF, bool DJDNPMCGGII, bool JBHGPNAJBPH, bool IMJENEAAOPP, [Out] int NNLGEFDHEAN, [Out] int AKHNFOHBNBN, [Out] bool GGNKMCKOEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GEBKDMDAPJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool bgr;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GEBKDMDAPJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F74B50", Offset = "0x6F73350", VA = "0x186F74B50")]
		internal void OBINKIHNCLM(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PLKBIOBBLMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F77610", Offset = "0x6F75E10", VA = "0x186F77610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F77830", Offset = "0x6F76030", VA = "0x186F77830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PEIKIMEIEJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public PEIKIMEIEJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6F775D0", Offset = "0x6F75DD0", VA = "0x186F775D0")]
		internal void DPAKDNNLENN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LDPJBFGKGKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public bool hasAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private PEIKIMEIEJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6F75980", Offset = "0x6F74180", VA = "0x186F75980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F76040", Offset = "0x6F74840", VA = "0x186F76040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool DKMAGOBNLBC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
	public static bool DAHMCGHKHIP(byte[] JEANLMHDGIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F757F0", Offset = "0x6F73FF0", VA = "0x186F757F0")]
	[AsyncStateMachine(typeof(PLKBIOBBLMK))]
	public static Task<Texture2D> NLGHDIJIIDB(byte[] JEANLMHDGIP, bool HMHEMMNAACD = false, bool ECFNCEFDKBA = false, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F756A0", Offset = "0x6F73EA0", VA = "0x186F756A0")]
	[AsyncStateMachine(typeof(LDPJBFGKGKM))]
	private static Task<Texture2D> DKPLCJPFHBA(int NNLGEFDHEAN, int AKHNFOHBNBN, bool BGJBOPDIAFK, bool HMHEMMNAACD, bool ECFNCEFDKBA, Action<NativeArray<byte>> CDHLHEJCHGM, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F75600", Offset = "0x6F73E00", VA = "0x186F75600")]
	private static TextureFormat DCJGJHECDDF(bool BGJBOPDIAFK)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum JODNHAPCJPL
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	RGB,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	BGR,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	RGBA,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	ABGR
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class FABPKIHODDN
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F74910", Offset = "0x6F73110", VA = "0x186F74910")]
	public static bool IIHEEGGPJLI(byte[] EBNFOODJNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F744D0", Offset = "0x6F72CD0", VA = "0x186F744D0")]
	public static void DPDKHNKHOEC(byte[] EBNFOODJNOB, [Out] int NNLGEFDHEAN, [Out] int AKHNFOHBNBN, [Out] JODNHAPCJPL AENEDEDOEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F747E0", Offset = "0x6F72FE0", VA = "0x186F747E0")]
	private static uint GNGCIPICAPC(byte[] EBNFOODJNOB, int EEPGNNLBJAH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F74950", Offset = "0x6F73150", VA = "0x186F74950")]
	private static ulong OPDGIMIMGEK(byte[] EBNFOODJNOB, int EEPGNNLBJAH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class AINHBBOFJGN
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F73EF0", Offset = "0x6F726F0", VA = "0x186F73EF0")]
	public static RenderTexture LJLMIHLABAG(int NNLGEFDHEAN, int AKHNFOHBNBN, int JILFJLKGLMC, Camera NIGNOFHNFLO, RenderTextureMemoryless FGHPPNODDDF = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F73E90", Offset = "0x6F72690", VA = "0x186F73E90")]
	public static void HNKHCKJAFGK(RenderTexture FFJDHDDBCKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class LNMKDGKHKIO<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct ABLEJDEIMFG : IEquatable<ABLEJDEIMFG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId GONIGCEPIHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly KCAJIIHHNBL DHEJOONHNFE;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x12CD500", Offset = "0x12CBD00", VA = "0x1812CD500")]
		public ABLEJDEIMFG(TImageId KCGKBDGKIOP, KCAJIIHHNBL OAKBEPDHIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x40F92D0", Offset = "0x40F7AD0", VA = "0x1840F92D0", Slot = "4")]
		public bool Equals(LNMKDGKHKIO<TImageId>.ABLEJDEIMFG LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x40F91C0", Offset = "0x40F79C0", VA = "0x1840F91C0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x40F9540", Offset = "0x40F7D40", VA = "0x1840F9540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x40F97C0", Offset = "0x40F7FC0", VA = "0x1840F97C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MKNAOIKKLAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DPGJMAFIAMJ<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MKNAOIKKLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x49DBFF0", Offset = "0x49DA7F0", VA = "0x1849DBFF0")]
		internal void CMIGMNOBGBO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct LJOPMMBHEHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ABLEJDEIMFG cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public LNMKDGKHKIO<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private KCAJIIHHNBL <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4742C20", Offset = "0x4741420", VA = "0x184742C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x47432F0", Offset = "0x4741AF0", VA = "0x1847432F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct AMNOCNAEILC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KCAJIIHHNBL textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LNMKDGKHKIO<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4479120", Offset = "0x4477920", VA = "0x184479120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4479820", Offset = "0x4478020", VA = "0x184479820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct PBJOOMIBFGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4C0F9E0", Offset = "0x4C0E1E0", VA = "0x184C0F9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4C0FE00", Offset = "0x4C0E600", VA = "0x184C0FE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int HNPEBFFANGD = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim JBMJNMAMLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? JMBCLCJMAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, KCAJIIHHNBL, CancellationToken, Task<Texture2D>>? NINPDGMANMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? HNPJEIMLGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly LFBBGDCJOMI<ABLEJDEIMFG, Texture2D> PFFAGENFIOI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x475DD10", Offset = "0x475C510", VA = "0x18475DD10")]
	public LNMKDGKHKIO(Func<TImageId, CancellationToken, Task<byte[]>> AKDEFLLAJJG, [Optional] Func<TImageId, string>? KCGFKHBHLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x475DF10", Offset = "0x475C710", VA = "0x18475DF10")]
	public LNMKDGKHKIO(Func<TImageId, KCAJIIHHNBL, CancellationToken, Task<Texture2D>> JLPBEIMECFL, [Optional] Func<TImageId, string>? KCGFKHBHLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x475DF60", Offset = "0x475C760", VA = "0x18475DF60")]
	private LNMKDGKHKIO(Func<TImageId, CancellationToken, Task<byte[]>>? AKDEFLLAJJG, Func<TImageId, KCAJIIHHNBL, CancellationToken, Task<Texture2D>>? JLPBEIMECFL, Func<TImageId, string>? KCGFKHBHLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x475D110", Offset = "0x475B910", VA = "0x18475D110")]
	public MGNFCCKNAGM<Texture2D> FPMCBLLCGJK(TImageId IFCPGJPEJAJ, KCAJIIHHNBL BNHEEFOLBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x475DB00", Offset = "0x475C300", VA = "0x18475DB00")]
	public void PFJBPCIOPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x475CE40", Offset = "0x475B640", VA = "0x18475CE40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x475D9B0", Offset = "0x475C1B0", VA = "0x18475D9B0")]
	[AsyncStateMachine(typeof(LNMKDGKHKIO<>.LJOPMMBHEHJ))]
	private Task<Texture2D> NFMPMIGEOCL(ABLEJDEIMFG IMKLPELFAIL, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x475D650", Offset = "0x475BE50", VA = "0x18475D650")]
	[AsyncStateMachine(typeof(LNMKDGKHKIO<>.AMNOCNAEILC))]
	private Task<Texture2D> JDMIICOIHHN(byte[] JEANLMHDGIP, KCAJIIHHNBL BNHEEFOLBPF, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x475D4E0", Offset = "0x475BCE0", VA = "0x18475D4E0")]
	private void INFAKJBPLND(Texture2D NOCDIJBAKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x475CE30", Offset = "0x475B630", VA = "0x18475CE30")]
	private bool CKOGCOFHLGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x475D7B0", Offset = "0x475BFB0", VA = "0x18475D7B0")]
	private bool KHGMODMPACJ(byte[] JEANLMHDGIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x475D300", Offset = "0x475BB00", VA = "0x18475D300")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LNMKDGKHKIO<>.PBJOOMIBFGL))]
	internal static Task IMJEFJOALOH(IDisposable CALEDLDKJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum KCAJIIHHNBL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
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
