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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DD6190", Offset = "0x7DD4F90", VA = "0x187DD6190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DD32A0", Offset = "0x7DD20A0", VA = "0x187DD32A0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NKADNHJAPKI
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
			[Cpp2IlInjected.Address(RVA = "0x7DD6310", Offset = "0x7DD5110", VA = "0x187DD6310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6300", Offset = "0x7DD5100", VA = "0x187DD6300")]
		public Resolution(uint AJEEBBBAOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
		public Resolution(uint AJEEBBBAOKG, uint GJPKMHAOJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6210", Offset = "0x7DD5010", VA = "0x187DD6210")]
		public static Resolution MOAAHFNEEOI(Resolution[] FMKKHOLMGDF, Resolution JBNNGJNNAOP, int NFLEGCHHGPP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class NGPANCNFKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution GGCBDDDJAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? EBAEABAGIIG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint AJEEBBBAOKG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7DD5FB0", Offset = "0x7DD4DB0", VA = "0x187DD5FB0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution HANEFNLPCOH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7DD5AD0", Offset = "0x7DD48D0", VA = "0x187DD5AD0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xE05700", Offset = "0xE04500", VA = "0x180E05700")]
		public NGPANCNFKBN(Resolution GGCBDDDJAEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5E30", Offset = "0x7DD4C30", VA = "0x187DD5E30")]
		private static Resolution FIEDFGDLDKA(Resolution EBAEABAGIIG, EDKJILHPEMK MLIENBGJOCF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CIPOPHOCBPH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution LEGJHMMAHMP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution ONCBNPGADCB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution AOPOHBFBBAA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution IOFMIJLHIGH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HNAEHJJENKD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution CNOKLHJKHBK;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] IIOAJJOFNCG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class COENKPNNJLE
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PIHKOIDFOND;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution OJNACDMIPDH;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution IEKHDHPJGJN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution GKLNFNBHPHG;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution ELOPOBLAJDN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] IIOAJJOFNCG;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2F50", Offset = "0x7DD1D50", VA = "0x187DD2F50")]
		public static Resolution CLDKPCNEHHO(uint LFMBACGFNNA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution CKAMLIOHOLD;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class JHOANDBMEFA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4820", Offset = "0x7DD3620", VA = "0x187DD4820")]
	public static bool LHHELLBOABE(byte[] FFEMKICJPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4610", Offset = "0x7DD3410", VA = "0x187DD4610")]
	public static bool KAADAHFPLEN(byte[] FFEMKICJPKP, [Out] int LFMBACGFNNA, [Out] int OCGMIFIKGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4860", Offset = "0x7DD3660", VA = "0x187DD4860")]
	private static int LLKHJJMDLLD(byte[] FFEMKICJPKP, int AJOJFAFFHHF, [Out] ushort HKPEEAJICLH)
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
		public enum DGNPJMHAFAG : byte
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
		private class NBLBHMOJBBL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string IHGFMOMOADA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D LEDJLJNOILM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public DGNPJMHAFAG KMPKBBMIGFI;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7DD5A80", Offset = "0x7DD4880", VA = "0x187DD5A80")]
			public NBLBHMOJBBL(string IHGFMOMOADA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1A07990", Offset = "0x1A06790", VA = "0x181A07990")]
			public NBLBHMOJBBL(string IHGFMOMOADA, Texture2D FBFLLKLGAIO, DGNPJMHAFAG GFHFLGHNOMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7DD5A40", Offset = "0x7DD4840", VA = "0x187DD5A40", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GFMMLIFMIII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public DGNPJMHAFAG textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public GFMMLIFMIII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7DD45D0", Offset = "0x7DD33D0", VA = "0x187DD45D0")]
			internal void EJJGMOLIMFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class EFDBLCDMKKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public EFDBLCDMKKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7DD4070", Offset = "0x7DD2E70", VA = "0x187DD4070")]
			internal DNFKJANILEK PCMIMDCGPOJ(Texture2D t2d)
			{
				return default(DNFKJANILEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class CBCDIHLFGAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public CBCDIHLFGAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7DD2CB0", Offset = "0x7DD1AB0", VA = "0x187DD2CB0")]
			internal void GEGHOAHALLH()
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
		private HMBEFKLHMDK<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NBLBHMOJBBL _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HMBEFKLHMDK<DNFKJANILEK> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private HMBEFKLHMDK<DNFKJANILEK> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private NBLBHMOJBBL memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7DD57F0", Offset = "0x7DD45F0", VA = "0x187DD57F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5720", Offset = "0x7DD4520", VA = "0x187DD5720")]
		public ManagedTexture(string IHGFMOMOADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5780", Offset = "0x7DD4580", VA = "0x187DD5780")]
		public ManagedTexture(string IHGFMOMOADA, bool NAFHLAOFHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD51E0", Offset = "0x7DD3FE0", VA = "0x187DD51E0")]
		public void HAINHPDHDEP(RenderTexture NBNEPGNAKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD48F0", Offset = "0x7DD36F0", VA = "0x187DD48F0")]
		public HMBEFKLHMDK<Texture2D> CJBBOBDCAHL(DGNPJMHAFAG GFHFLGHNOMA, bool MHKCMDMPDEE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5220", Offset = "0x7DD4020", VA = "0x187DD5220")]
		public HMBEFKLHMDK<DNFKJANILEK> HEMOBFIGEGO(bool MHKCMDMPDEE = false, int COPBPAJCMDM = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD53C0", Offset = "0x7DD41C0", VA = "0x187DD53C0")]
		public HMBEFKLHMDK<DNFKJANILEK> IBBHHIGAGIO(bool MHKCMDMPDEE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4C90", Offset = "0x7DD3A90", VA = "0x187DD4C90")]
		private static HMBEFKLHMDK<Texture2D> FNPJFAMDBAN(string IHGFMOMOADA, RenderTexture NBNEPGNAKNI, Texture2D FEACPACPNAM, bool MHKCMDMPDEE, DGNPJMHAFAG OJGHKHPIHDD = DGNPJMHAFAG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4BF0", Offset = "0x7DD39F0", VA = "0x187DD4BF0")]
		public void EKGNIHNCEMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4BE0", Offset = "0x7DD39E0", VA = "0x187DD4BE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7DD56C0", Offset = "0x7DD44C0", VA = "0x187DD56C0")]
		[CompilerGenerated]
		private HMBEFKLHMDK<byte[]> JAEDOOIJBKJ(Texture2D ENLGCMNIBLH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class APFDGPOIPOF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct BKKIBGJBHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2BB0", Offset = "0x7DD19B0", VA = "0x187DD2BB0")]
		public unsafe static extern void EEFFNJFJKOD(void* FEDMFCDKKMN, void* BHBDEJBFADC, bool JIDHINBMCIB, bool MDEAKPLMAMJ, bool COMINBHOELA, [Out] int LFMBACGFNNA, [Out] int OCGMIFIKGJN, [Out] bool FDNELDEOIPK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NBDINCKKKLE
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
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NBDINCKKKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7DD58A0", Offset = "0x7DD46A0", VA = "0x187DD58A0")]
		internal void NKBJHDHKOFK(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FAKHFCBKMIF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DD40B0", Offset = "0x7DD2EB0", VA = "0x187DD40B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DD42D0", Offset = "0x7DD30D0", VA = "0x187DD42D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AIENIJDPHDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AIENIJDPHDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD27F0", Offset = "0x7DD15F0", VA = "0x187DD27F0")]
		internal void HHODBLHLDNL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct EENANHOPGAC : IAsyncStateMachine
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
		private AIENIJDPHDD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3940", Offset = "0x7DD2740", VA = "0x187DD3940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4000", Offset = "0x7DD2E00", VA = "0x187DD4000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool JCKDMDECGJE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	public static bool ALAKOGADOBI(byte[] LFMIFHPCJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2980", Offset = "0x7DD1780", VA = "0x187DD2980")]
	[AsyncStateMachine(typeof(FAKHFCBKMIF))]
	public static Task<Texture2D> HCEICAODLOC(byte[] LFMIFHPCJMO, bool NDNIEDGGIJL = false, bool PLDFFLHPEFB = false, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2830", Offset = "0x7DD1630", VA = "0x187DD2830")]
	[AsyncStateMachine(typeof(EENANHOPGAC))]
	private static Task<Texture2D> FONPHNBOEGI(int LFMBACGFNNA, int OCGMIFIKGJN, bool PNBNPNEKOJL, bool NDNIEDGGIJL, bool PLDFFLHPEFB, Action<NativeArray<byte>> CHMBLNLEDAH, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2AC0", Offset = "0x7DD18C0", VA = "0x187DD2AC0")]
	private static TextureFormat HLBHNLAHOGL(bool PNBNPNEKOJL)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum KKCOBJANOOA
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
internal static class EEAKHFFMODF
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3900", Offset = "0x7DD2700", VA = "0x187DD3900")]
	public static bool OGACEFCOAJK(byte[] FFEMKICJPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD32C0", Offset = "0x7DD20C0", VA = "0x187DD32C0")]
	public static void DEAGOJGADLB(byte[] FFEMKICJPKP, [Out] int LFMBACGFNNA, [Out] int OCGMIFIKGJN, [Out] KKCOBJANOOA HONGJHADKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD37D0", Offset = "0x7DD25D0", VA = "0x187DD37D0")]
	private static uint LEIOLKJHHLL(byte[] FFEMKICJPKP, int GNMMLFONKNO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DD35D0", Offset = "0x7DD23D0", VA = "0x187DD35D0")]
	private static ulong JHCFMHKPNKL(byte[] FFEMKICJPKP, int GNMMLFONKNO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class GBIINBLKAIB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4340", Offset = "0x7DD3140", VA = "0x187DD4340")]
	public static RenderTexture BKNGIMDJCGH(int LFMBACGFNNA, int OCGMIFIKGJN, int ALHBAGPHNCE, Camera DOAGHOOOPIO, RenderTextureMemoryless DKDLLFGIPFN = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4570", Offset = "0x7DD3370", VA = "0x187DD4570")]
	public static void DFCHLGLEFKN(RenderTexture NBNEPGNAKNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class LMBKJOCHKOE<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct PJGGENELCBM : IEquatable<PJGGENELCBM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId FDIMHFCJMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly IKGNFCJNNKG DIMJNAECEJA;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1803FC0", Offset = "0x1802DC0", VA = "0x181803FC0")]
		public PJGGENELCBM(TImageId MAKJJJECHHB, IKGNFCJNNKG EHHPEIDANBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5780E20", Offset = "0x577FC20", VA = "0x185780E20", Slot = "4")]
		public bool Equals(LMBKJOCHKOE<TImageId>.PJGGENELCBM HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5780FA0", Offset = "0x577FDA0", VA = "0x185780FA0", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5781190", Offset = "0x577FF90", VA = "0x185781190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5781260", Offset = "0x5780060", VA = "0x185781260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MBJKJJCKFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public MMLLOANHJIJ<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MBJKJJCKFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5399A60", Offset = "0x5398860", VA = "0x185399A60")]
		internal void ENPBKHNINDN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct HCMLADCJNFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PJGGENELCBM cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public LMBKJOCHKOE<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private IKGNFCJNNKG <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4C19000", Offset = "0x4C17E00", VA = "0x184C19000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4C19EA0", Offset = "0x4C18CA0", VA = "0x184C19EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct MJLKFHGCIIA : IAsyncStateMachine
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
		public IKGNFCJNNKG textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LMBKJOCHKOE<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x53C7BC0", Offset = "0x53C69C0", VA = "0x1853C7BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x53C82C0", Offset = "0x53C70C0", VA = "0x1853C82C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct MEEENACGAOC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x53B1A30", Offset = "0x53B0830", VA = "0x1853B1A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x53B1E50", Offset = "0x53B0C50", VA = "0x1853B1E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int ONLAECHFNOG = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim JIAODFIEFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? IJDMJKPCCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, IKGNFCJNNKG, CancellationToken, Task<Texture2D>>? KAAEIFPIMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? PMPOHIAIJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly GCCFCBBMFKB<PJGGENELCBM, Texture2D> PILINJFINDD;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x51AB230", Offset = "0x51AA030", VA = "0x1851AB230")]
	public LMBKJOCHKOE(Func<TImageId, CancellationToken, Task<byte[]>> LMFIJFKILGN, [Optional] Func<TImageId, string>? EANONJKLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x51AB280", Offset = "0x51AA080", VA = "0x1851AB280")]
	public LMBKJOCHKOE(Func<TImageId, IKGNFCJNNKG, CancellationToken, Task<Texture2D>> FNNBIGAJOLF, [Optional] Func<TImageId, string>? EANONJKLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x51AAED0", Offset = "0x51A9CD0", VA = "0x1851AAED0")]
	private LMBKJOCHKOE(Func<TImageId, CancellationToken, Task<byte[]>>? LMFIJFKILGN, Func<TImageId, IKGNFCJNNKG, CancellationToken, Task<Texture2D>>? FNNBIGAJOLF, Func<TImageId, string>? EANONJKLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x51AA360", Offset = "0x51A9160", VA = "0x1851AA360")]
	public EHIFMMNJMNN<Texture2D> DDMFCGNGLKI(TImageId JABJEEBCFJI, IKGNFCJNNKG NLKEKFEGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x51AACC0", Offset = "0x51A9AC0", VA = "0x1851AACC0")]
	public void NMDOMIGMDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x51AA780", Offset = "0x51A9580", VA = "0x1851AA780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x51AAB70", Offset = "0x51A9970", VA = "0x1851AAB70")]
	[AsyncStateMachine(typeof(LMBKJOCHKOE<>.HCMLADCJNFM))]
	private Task<Texture2D> HEDCJNDALLA(PJGGENELCBM PACALLJHMNM, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x51AA200", Offset = "0x51A9000", VA = "0x1851AA200")]
	[AsyncStateMachine(typeof(LMBKJOCHKOE<>.MJLKFHGCIIA))]
	private Task<Texture2D> CLJBKPKPABB(byte[] LFMIFHPCJMO, IKGNFCJNNKG NLKEKFEGNNA, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x51AA770", Offset = "0x51A9570", VA = "0x1851AA770")]
	private void DPOKMOAOLAE(Texture2D FBFLLKLGAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x51AA830", Offset = "0x51A9630", VA = "0x1851AA830")]
	private bool FDKCENILLCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51A9FF0", Offset = "0x51A8DF0", VA = "0x1851A9FF0")]
	private bool AFNIHNOHANG(byte[] LFMIFHPCJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x51AA840", Offset = "0x51A9640", VA = "0x1851AA840")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LMBKJOCHKOE<>.MEEENACGAOC))]
	internal static Task FJKPIKFEMFE(IDisposable DKKJFILBCHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum IKGNFCJNNKG : byte
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
