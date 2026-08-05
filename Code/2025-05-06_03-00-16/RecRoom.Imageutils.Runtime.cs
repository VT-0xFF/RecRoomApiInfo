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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B5EC30", Offset = "0x7B5D430", VA = "0x187B5EC30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B5C340", Offset = "0x7B5AB40", VA = "0x187B5C340")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LCGBOBBAFEE
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
			[Cpp2IlInjected.Address(RVA = "0x7B5F310", Offset = "0x7B5DB10", VA = "0x187B5F310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F300", Offset = "0x7B5DB00", VA = "0x187B5F300")]
		public Resolution(uint LEFBJAGNHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCEB9D0", Offset = "0xCEA1D0", VA = "0x180CEB9D0")]
		public Resolution(uint LEFBJAGNHCD, uint LLGPJHIECFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F210", Offset = "0x7B5DA10", VA = "0x187B5F210")]
		public static Resolution GPFOEJOAFKH(Resolution[] AKIEDMONOFM, Resolution ENHJEBHPLIO, int JFIJPLILKAM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class PAABJCGPOBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution MOOPLIDMJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? NLFDHKIFJDH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint LEFBJAGNHCD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7B5ECF0", Offset = "0x7B5D4F0", VA = "0x187B5ECF0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution MNJGNPIDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7B5EE80", Offset = "0x7B5D680", VA = "0x187B5EE80")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDC41C0", Offset = "0xDC29C0", VA = "0x180DC41C0")]
		public PAABJCGPOBJ(Resolution MOOPLIDMJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5ED00", Offset = "0x7B5D500", VA = "0x187B5ED00")]
		private static Resolution KIDHFLNIEKN(Resolution NLFDHKIFJDH, PPMAGMCOEIB HMPAMLLKFCN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class LAADLGCMFPF
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution JIJFFKBBMMM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution LJELOGNLLAP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution BKBPPGDDCMA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution GABLGBOBLON;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution EAMCGAHGAIE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution MDLKFCBCEFA;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] FBLDAAELJMF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class GJIGHIIILLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution IBPHGFCPMFL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution EGEKEFAOAGI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution GCDNADHOAKB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution ADJPFNNDCAG;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KMMLMKFENFA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] FBLDAAELJMF;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CA60", Offset = "0x7B5B260", VA = "0x187B5CA60")]
		public static Resolution PAEFHNGGKED(uint AJBHLEPGOLA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution GEKCPCHADHC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class AEJHMBKKMIK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B8A0", Offset = "0x7B5A0A0", VA = "0x187B5B8A0")]
	public static bool LECAOJAJGBM(byte[] NFNBKNAJBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B8E0", Offset = "0x7B5A0E0", VA = "0x187B5B8E0")]
	public static bool NAIIMDLKPFC(byte[] NFNBKNAJBPN, [Out] int AJBHLEPGOLA, [Out] int OKDHCGBPBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BAF0", Offset = "0x7B5A2F0", VA = "0x187B5BAF0")]
	private static int POHAJOELIID(byte[] NFNBKNAJBPN, int IFOFOJHAFEG, [Out] ushort HGKMDJINEHC)
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
		public enum BADHGEJOAHD : byte
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
		private class EKEMEMONDAL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string GLGOHIJMLFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D PPIFCFIECMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public BADHGEJOAHD GNPOHHIJFAD;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7B5C700", Offset = "0x7B5AF00", VA = "0x187B5C700")]
			public EKEMEMONDAL(string GLGOHIJMLFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1954220", Offset = "0x1952A20", VA = "0x181954220")]
			public EKEMEMONDAL(string GLGOHIJMLFB, Texture2D OAGLIKEGCPE, BADHGEJOAHD BDNHMOABJHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7B5C6C0", Offset = "0x7B5AEC0", VA = "0x187B5C6C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PKJDNCIPLOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public BADHGEJOAHD textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public PKJDNCIPLOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7B5F1D0", Offset = "0x7B5D9D0", VA = "0x187B5F1D0")]
			internal void OGJFEGGICMD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OLEMPCADFPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public OLEMPCADFPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7B5ECB0", Offset = "0x7B5D4B0", VA = "0x187B5ECB0")]
			internal BLFOIAIFCLK GEJNHMHOOEO(Texture2D t2d)
			{
				return default(BLFOIAIFCLK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GBFEICAENAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public GBFEICAENAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7B5C750", Offset = "0x7B5AF50", VA = "0x187B5C750")]
			internal void NGOIABLGPGA()
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
		private KJPDFMLMKLI<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private EKEMEMONDAL _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KJPDFMLMKLI<BLFOIAIFCLK> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private KJPDFMLMKLI<BLFOIAIFCLK> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private EKEMEMONDAL memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7B5EB80", Offset = "0x7B5D380", VA = "0x187B5EB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EAB0", Offset = "0x7B5D2B0", VA = "0x187B5EAB0")]
		public ManagedTexture(string GLGOHIJMLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EB10", Offset = "0x7B5D310", VA = "0x187B5EB10")]
		public ManagedTexture(string GLGOHIJMLFB, bool NEGGGFJMLBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DCA0", Offset = "0x7B5C4A0", VA = "0x187B5DCA0")]
		public void CCOIAKJPFCD(RenderTexture PNHGGLOJLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E430", Offset = "0x7B5CC30", VA = "0x187B5E430")]
		public KJPDFMLMKLI<Texture2D> IPKBHFKKFEP(BADHGEJOAHD BDNHMOABJHO, bool EOLEJMMGLPC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E290", Offset = "0x7B5CA90", VA = "0x187B5E290")]
		public KJPDFMLMKLI<BLFOIAIFCLK> DOEBOPJKBFK(bool EOLEJMMGLPC = false, int KDAGDLPEMMC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E720", Offset = "0x7B5CF20", VA = "0x187B5E720")]
		public KJPDFMLMKLI<BLFOIAIFCLK> JCHOAGBODKI(bool EOLEJMMGLPC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DD40", Offset = "0x7B5C540", VA = "0x187B5DD40")]
		private static KJPDFMLMKLI<Texture2D> COIPCINDJIN(string GLGOHIJMLFB, RenderTexture PNHGGLOJLAG, Texture2D BGPKKBPGPPD, bool EOLEJMMGLPC, BADHGEJOAHD LLKGFCLBHDB = BADHGEJOAHD.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EA10", Offset = "0x7B5D210", VA = "0x187B5EA10")]
		public void NAKPPBGELPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E420", Offset = "0x7B5CC20", VA = "0x187B5E420", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DCE0", Offset = "0x7B5C4E0", VA = "0x187B5DCE0")]
		[CompilerGenerated]
		private KJPDFMLMKLI<byte[]> CHNLOLAGOFO(Texture2D BBDLMENIBIH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DCDNCDCDKAI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct CCJPGKFJGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BBC0", Offset = "0x7B5A3C0", VA = "0x187B5BBC0")]
		public unsafe static extern void KBHFONNLHNL(void* ADEGNNIAMPF, void* EFGFBKMBCFL, bool MDOGIEPFBIN, bool IKMABFGCLEP, bool FHCNDBGLPCD, [Out] int AJBHLEPGOLA, [Out] int OKDHCGBPBDJ, [Out] bool PBEBEBKPBFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class MHMMMJADCOE
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
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MHMMMJADCOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DB00", Offset = "0x7B5C300", VA = "0x187B5DB00")]
		internal void LGJEEKBCEBO(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MBLMCGBEJIF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7B5D870", Offset = "0x7B5C070", VA = "0x187B5D870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DA90", Offset = "0x7B5C290", VA = "0x187B5DA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AMDEFJDFAJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AMDEFJDFAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BB80", Offset = "0x7B5A380", VA = "0x187B5BB80")]
		internal void PIHBMMMANNC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KLAIGENHHKG : IAsyncStateMachine
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
		private AMDEFJDFAJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CD80", Offset = "0x7B5B580", VA = "0x187B5CD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D440", Offset = "0x7B5BC40", VA = "0x187B5D440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool JEKKPKEMCOD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
	public static bool ANFBGNFNLPE(byte[] LFDHPBNOLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C4B0", Offset = "0x7B5ACB0", VA = "0x187B5C4B0")]
	[AsyncStateMachine(typeof(MBLMCGBEJIF))]
	public static Task<Texture2D> CKJHBCDNHIK(byte[] LFDHPBNOLAL, bool IMHAKOOIKKM = false, bool KJKKBHGFJKB = false, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C360", Offset = "0x7B5AB60", VA = "0x187B5C360")]
	[AsyncStateMachine(typeof(KLAIGENHHKG))]
	private static Task<Texture2D> AFLOEIOPDLL(int AJBHLEPGOLA, int OKDHCGBPBDJ, bool AHHEBDDIDDF, bool IMHAKOOIKKM, bool KJKKBHGFJKB, Action<NativeArray<byte>> PDKPCNHLHHM, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C5F0", Offset = "0x7B5ADF0", VA = "0x187B5C5F0")]
	private static TextureFormat OKPGDEBPKPB(bool AHHEBDDIDDF)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum EAKEMMBOHEN
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
internal static class CKGLAELPEHB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C100", Offset = "0x7B5A900", VA = "0x187B5C100")]
	public static bool FKIFDDPEFMI(byte[] NFNBKNAJBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BDF0", Offset = "0x7B5A5F0", VA = "0x187B5BDF0")]
	public static void EFDHJOPIGDK(byte[] NFNBKNAJBPN, [Out] int AJBHLEPGOLA, [Out] int OKDHCGBPBDJ, [Out] EAKEMMBOHEN CGJBGKAIMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BCC0", Offset = "0x7B5A4C0", VA = "0x187B5BCC0")]
	private static uint DIJNGDDIFOO(byte[] NFNBKNAJBPN, int MLFBDFDDHEO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C140", Offset = "0x7B5A940", VA = "0x187B5C140")]
	private static ulong ILEBNKFHHGA(byte[] NFNBKNAJBPN, int MLFBDFDDHEO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class GBJDBKIBKCN
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C7D0", Offset = "0x7B5AFD0", VA = "0x187B5C7D0")]
	public static RenderTexture DALMEGGGICC(int AJBHLEPGOLA, int OKDHCGBPBDJ, int CAHCGLMGIAO, Camera DJHBAGBEEIN, RenderTextureMemoryless GJJNBKIHDFA = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7B5CA00", Offset = "0x7B5B200", VA = "0x187B5CA00")]
	public static void GFLMCBFBEKH(RenderTexture PNHGGLOJLAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class GPMODFOKKIJ<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct GHGLKKEJAFI : IEquatable<GHGLKKEJAFI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId NGICPMEDIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly BNDDCMMELHP EAKJFEPLCDH;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1774470", Offset = "0x1772C70", VA = "0x181774470")]
		public GHGLKKEJAFI(TImageId BELIEAFHDAH, BNDDCMMELHP LGPJDEILGDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4999310", Offset = "0x4997B10", VA = "0x184999310", Slot = "4")]
		public bool Equals(GPMODFOKKIJ<TImageId>.GHGLKKEJAFI PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4999200", Offset = "0x4997A00", VA = "0x184999200", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4999580", Offset = "0x4997D80", VA = "0x184999580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4999730", Offset = "0x4997F30", VA = "0x184999730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PKGLJDGLACK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JMLHEDJNIFJ<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PKGLJDGLACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5575FB0", Offset = "0x55747B0", VA = "0x185575FB0")]
		internal void GEONOLEKILI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct PBBHBJALGHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GHGLKKEJAFI cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GPMODFOKKIJ<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private BNDDCMMELHP <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x553F7C0", Offset = "0x553DFC0", VA = "0x18553F7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x553FF00", Offset = "0x553E700", VA = "0x18553FF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct EDKCCKJDILA : IAsyncStateMachine
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
		public BNDDCMMELHP textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GPMODFOKKIJ<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x43E7B70", Offset = "0x43E6370", VA = "0x1843E7B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x43E89E0", Offset = "0x43E71E0", VA = "0x1843E89E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct DGDDGKHIDBL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x68D02E0", Offset = "0x68CEAE0", VA = "0x1868D02E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x68D04C0", Offset = "0x68CECC0", VA = "0x1868D04C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int BFJNPEOJEIK = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim LLEGDJGKJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? OCNAKPPEEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, BNDDCMMELHP, CancellationToken, Task<Texture2D>>? KDMKKFNFFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? BLNCLMONJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly GNDJEFKFJMI<GHGLKKEJAFI, Texture2D> MKHCMNLPKHB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49DE010", Offset = "0x49DC810", VA = "0x1849DE010")]
	public GPMODFOKKIJ(Func<TImageId, CancellationToken, Task<byte[]>> JAMPMLFBNEN, [Optional] Func<TImageId, string>? JPAEGBNDHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x49DDE10", Offset = "0x49DC610", VA = "0x1849DDE10")]
	public GPMODFOKKIJ(Func<TImageId, BNDDCMMELHP, CancellationToken, Task<Texture2D>> HBFKLOBAGHN, [Optional] Func<TImageId, string>? JPAEGBNDHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x49DE060", Offset = "0x49DC860", VA = "0x1849DE060")]
	private GPMODFOKKIJ(Func<TImageId, CancellationToken, Task<byte[]>>? JAMPMLFBNEN, Func<TImageId, BNDDCMMELHP, CancellationToken, Task<Texture2D>>? HBFKLOBAGHN, Func<TImageId, string>? JPAEGBNDHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x49DD860", Offset = "0x49DC060", VA = "0x1849DD860")]
	public GOANNPAHNKI<Texture2D> OOPEOBNCHCJ(TImageId PFAPKLDCEOE, BNDDCMMELHP PDGLBJJJOBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x49DD490", Offset = "0x49DBC90", VA = "0x1849DD490")]
	public void ELFFAHMMPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49DD3F0", Offset = "0x49DBBF0", VA = "0x1849DD3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x49DD140", Offset = "0x49DB940", VA = "0x1849DD140")]
	[AsyncStateMachine(typeof(GPMODFOKKIJ<>.PBBHBJALGHL))]
	private Task<Texture2D> COPDDLLNMHC(GHGLKKEJAFI IEALGDFHJLA, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x49DD4E0", Offset = "0x49DBCE0", VA = "0x1849DD4E0")]
	[AsyncStateMachine(typeof(GPMODFOKKIJ<>.EDKCCKJDILA))]
	private Task<Texture2D> FDECMNIGHPM(byte[] LFDHPBNOLAL, BNDDCMMELHP PDGLBJJJOBH, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49DD850", Offset = "0x49DC050", VA = "0x1849DD850")]
	private void IMBDBIADENG(Texture2D OAGLIKEGCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49DD3E0", Offset = "0x49DBBE0", VA = "0x1849DD3E0")]
	private bool CPBCGKEJGFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x49DD7A0", Offset = "0x49DBFA0", VA = "0x1849DD7A0")]
	private bool HONONOOLIFA(byte[] LFDHPBNOLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x49DD050", Offset = "0x49DB850", VA = "0x1849DD050")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GPMODFOKKIJ<>.DGDDGKHIDBL))]
	internal static Task ABKMFGBKNCG(IDisposable KCGCJKKNDBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum BNDDCMMELHP : byte
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
