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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x762CF80", Offset = "0x762C180", VA = "0x18762CF80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
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
		[Cpp2IlInjected.Address(RVA = "0x762A990", Offset = "0x7629B90", VA = "0x18762A990")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class INNCCNDIOEN
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
			[Cpp2IlInjected.Address(RVA = "0x762D100", Offset = "0x762C300", VA = "0x18762D100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x762D0F0", Offset = "0x762C2F0", VA = "0x18762D0F0")]
		public Resolution(uint NNDJDIFFAID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC25680", Offset = "0xC24880", VA = "0x180C25680")]
		public Resolution(uint NNDJDIFFAID, uint AMFIBFNKFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x762D000", Offset = "0x762C200", VA = "0x18762D000")]
		public static Resolution LFNDIMDDPIK(Resolution[] ONCKKBCCJPH, Resolution IFJEMEIKAEK, int AHJJDBIBAGF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class NPLAJGIHJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution HCFPJFIIPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? DFIJEFCHHBK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint NNDJDIFFAID
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x762CF70", Offset = "0x762C170", VA = "0x18762CF70")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution MEEJDBCLHND
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x762CC20", Offset = "0x762BE20", VA = "0x18762CC20")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCF3180", Offset = "0xCF2380", VA = "0x180CF3180")]
		public NPLAJGIHJFB(Resolution HCFPJFIIPGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x762CAA0", Offset = "0x762BCA0", VA = "0x18762CAA0")]
		private static Resolution DPLCHPENDOB(Resolution DFIJEFCHHBK, CIHGHEEKAPD DMPKNNNGHFI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class BIDEHHJNICO
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution ABNHNAEHHNK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution MKCEDDGALLJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution BCMCADCJOCL;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution HLNNNFHJEFA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution GDGDEDGJFKA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution NHPDGMOEHKM;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] FGMGDBINCAG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class BDFIPBGCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LLMICDPGIAH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution OHDCHKAPHMK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CCPABFHFHPG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution BKJKBCBBKDJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HKANNONKLGA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] FGMGDBINCAG;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x762A440", Offset = "0x7629640", VA = "0x18762A440")]
		public static Resolution IHMAIDFHIBJ(uint KIGDGKLPLAM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution INCDJEHHOHO;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class JCHEFHILDIP
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x762B260", Offset = "0x762A460", VA = "0x18762B260")]
	public static bool APNAKNDHNGN(byte[] LJELDKAOCJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x762B330", Offset = "0x762A530", VA = "0x18762B330")]
	public static bool DHDJGIBCLOE(byte[] LJELDKAOCJM, [Out] int KIGDGKLPLAM, [Out] int CONNODFECMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x762B2A0", Offset = "0x762A4A0", VA = "0x18762B2A0")]
	private static int CDHIKLONELJ(byte[] LJELDKAOCJM, int JMHJAFCGEDO, [Out] ushort ICKAKAPLJLD)
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
		public enum HCODIAPCECP : byte
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
		private class KNHNLMIENIK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string MBDFMCIDAOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D CJIFKNGELEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HCODIAPCECP GOLLIPHJBFF;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x762B720", Offset = "0x762A920", VA = "0x18762B720")]
			public KNHNLMIENIK(string MBDFMCIDAOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4B59B70", Offset = "0x4B58D70", VA = "0x184B59B70")]
			public KNHNLMIENIK(string MBDFMCIDAOB, Texture2D GOADEEFLEJA, HCODIAPCECP FBOBBNKGCLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x762B6E0", Offset = "0x762A8E0", VA = "0x18762B6E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NCDPKGHJNMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public HCODIAPCECP textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public NCDPKGHJNMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x762CA60", Offset = "0x762BC60", VA = "0x18762CA60")]
			internal void MOIKBLAMOPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class BPPOMNLGNNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public BPPOMNLGNNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x762A950", Offset = "0x7629B50", VA = "0x18762A950")]
			internal AMAHFPHIMJA HPAMPIDIAIB(Texture2D t2d)
			{
				return default(AMAHFPHIMJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FNCCENNCOCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public FNCCENNCOCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x762AFD0", Offset = "0x762A1D0", VA = "0x18762AFD0")]
			internal void DPPJNDOFEIG()
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
		private JBBNLHPJHLB<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KNHNLMIENIK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JBBNLHPJHLB<AMAHFPHIMJA> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private JBBNLHPJHLB<AMAHFPHIMJA> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB96CC0", Offset = "0xB95EC0", VA = "0x180B96CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private KNHNLMIENIK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x762C9B0", Offset = "0x762BBB0", VA = "0x18762C9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x762C8E0", Offset = "0x762BAE0", VA = "0x18762C8E0")]
		public ManagedTexture(string MBDFMCIDAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x762C940", Offset = "0x762BB40", VA = "0x18762C940")]
		public ManagedTexture(string MBDFMCIDAOB, bool PMGJOJNFHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x762BD70", Offset = "0x762AF70", VA = "0x18762BD70")]
		public void NFJGJLIOFHN(RenderTexture EFAGDBACPEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x762C5F0", Offset = "0x762B7F0", VA = "0x18762C5F0")]
		public JBBNLHPJHLB<Texture2D> PMAEMNGIKDH(HCODIAPCECP FBOBBNKGCLI, bool MOBDECAKGBE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x762BBE0", Offset = "0x762ADE0", VA = "0x18762BBE0")]
		public JBBNLHPJHLB<AMAHFPHIMJA> EIEGOOHPPCD(bool MOBDECAKGBE = false, int JLMMMPLCDHH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x762BDB0", Offset = "0x762AFB0", VA = "0x18762BDB0")]
		public JBBNLHPJHLB<AMAHFPHIMJA> ODDPKGDGDHF(bool MOBDECAKGBE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x762C0A0", Offset = "0x762B2A0", VA = "0x18762C0A0")]
		private static JBBNLHPJHLB<Texture2D> PIJGMMJEPFJ(string MBDFMCIDAOB, RenderTexture EFAGDBACPEN, Texture2D GOBAKAHIEHI, bool MOBDECAKGBE, HCODIAPCECP DPJNDOLAGIH = HCODIAPCECP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x762BB30", Offset = "0x762AD30", VA = "0x18762BB30")]
		public void BGBDFHMGJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x762BBD0", Offset = "0x762ADD0", VA = "0x18762BBD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x762BAD0", Offset = "0x762ACD0", VA = "0x18762BAD0")]
		[CompilerGenerated]
		private JBBNLHPJHLB<byte[]> BCNHPKPDGFC(Texture2D DJMPONLLCJF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LJMDJAKICFC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct DJKHDEKNNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x762AC40", Offset = "0x7629E40", VA = "0x18762AC40")]
		public unsafe static extern void CIFJKFJPKJJ(void* BEFGDMOKGPC, void* NHGKIMEFJKJ, bool ENIALGAMAHM, bool HLKNLBCEKBK, bool MAKLHBECPFN, [Out] int KIGDGKLPLAM, [Out] int CONNODFECMD, [Out] bool KLGIILOBBBC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class KFDNEBABGPL
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
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KFDNEBABGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x762B540", Offset = "0x762A740", VA = "0x18762B540")]
		internal void CBHHFEHDLJP(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DHKENBDGKKD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x762A9B0", Offset = "0x7629BB0", VA = "0x18762A9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x762ABD0", Offset = "0x7629DD0", VA = "0x18762ABD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class GILBCHPOIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GILBCHPOIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x762B050", Offset = "0x762A250", VA = "0x18762B050")]
		internal void ACOGJDALMHM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct ADKGHAJNFBI : IAsyncStateMachine
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
		private GILBCHPOIKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7629690", Offset = "0x7628890", VA = "0x187629690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7629D50", Offset = "0x7628F50", VA = "0x187629D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool EFCLBAKEAKH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
	public static bool CJANGCNLDGC(byte[] KCDHCMOJGEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x762B770", Offset = "0x762A970", VA = "0x18762B770")]
	[AsyncStateMachine(typeof(DHKENBDGKKD))]
	public static Task<Texture2D> MHCCANDCALD(byte[] KCDHCMOJGEN, bool JBFJGPJNILJ = false, bool DPLHGHGIFFF = false, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x762B940", Offset = "0x762AB40", VA = "0x18762B940")]
	[AsyncStateMachine(typeof(ADKGHAJNFBI))]
	private static Task<Texture2D> PPLEBHANBCD(int KIGDGKLPLAM, int CONNODFECMD, bool FFBGFAHJPHE, bool JBFJGPJNILJ, bool DPLHGHGIFFF, Action<NativeArray<byte>> CDFHNMFCNNO, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x762B8B0", Offset = "0x762AAB0", VA = "0x18762B8B0")]
	private static TextureFormat OPLPKAAADME(bool FFBGFAHJPHE)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum GCOIMNEJMOC
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
internal static class BDDLBNKOPDL
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x762A200", Offset = "0x7629400", VA = "0x18762A200")]
	public static bool JLDMCHHDDEM(byte[] LJELDKAOCJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7629EF0", Offset = "0x76290F0", VA = "0x187629EF0")]
	public static void GOBMDFCDEMM(byte[] LJELDKAOCJM, [Out] int KIGDGKLPLAM, [Out] int CONNODFECMD, [Out] GCOIMNEJMOC FLMAPKGOONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7629DC0", Offset = "0x7628FC0", VA = "0x187629DC0")]
	private static uint CHOBIKEOLCK(byte[] LJELDKAOCJM, int MGKDKECOLOJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x762A240", Offset = "0x7629440", VA = "0x18762A240")]
	private static ulong PLHKBMOAHBB(byte[] LJELDKAOCJM, int MGKDKECOLOJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FJGHFOHBFEE
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x762AD40", Offset = "0x7629F40", VA = "0x18762AD40")]
	public static RenderTexture CKMGODJDPBL(int KIGDGKLPLAM, int CONNODFECMD, int FPNMGFDEILO, Camera NBEMGKCACGL, RenderTextureMemoryless KJNCLLHFBJM = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x762AF70", Offset = "0x762A170", VA = "0x18762AF70")]
	public static void GOCBAEGGFEA(RenderTexture EFAGDBACPEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class BIPLLOOPDKM<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct NHCHNMDCFDH : IEquatable<NHCHNMDCFDH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId FEHGMDHALEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly OJGLMGEDFJG JIJIFBCOCFI;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x15EF900", Offset = "0x15EEB00", VA = "0x1815EF900")]
		public NHCHNMDCFDH(TImageId MBDBONINAPC, OJGLMGEDFJG GLHMINFJJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4E32A40", Offset = "0x4E31C40", VA = "0x184E32A40", Slot = "4")]
		public bool Equals(BIPLLOOPDKM<TImageId>.NHCHNMDCFDH LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4E32930", Offset = "0x4E31B30", VA = "0x184E32930", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4E32C10", Offset = "0x4E31E10", VA = "0x184E32C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4E32DB0", Offset = "0x4E31FB0", VA = "0x184E32DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MEDINJAHFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OABDMFMONOH<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MEDINJAHFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4D9A170", Offset = "0x4D99370", VA = "0x184D9A170")]
		internal void IKBLBEBNGLN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct DFLBHMNPMGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NHCHNMDCFDH cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public BIPLLOOPDKM<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private OJGLMGEDFJG <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x638D090", Offset = "0x638C290", VA = "0x18638D090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x638DF20", Offset = "0x638D120", VA = "0x18638DF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct BBEBAMKEOND : IAsyncStateMachine
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
		public OJGLMGEDFJG textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BIPLLOOPDKM<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5895D80", Offset = "0x5894F80", VA = "0x185895D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5896BF0", Offset = "0x5895DF0", VA = "0x185896BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct MKMEPPKLPLI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4DAF5E0", Offset = "0x4DAE7E0", VA = "0x184DAF5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF7C0", Offset = "0x4DAE9C0", VA = "0x184DAF7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int ANMFEAMOKDA = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim GCLNNCPOMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? EKDGFPLGDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, OJGLMGEDFJG, CancellationToken, Task<Texture2D>>? KJELEPGGPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? COEHOOIDPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PGEPNDCGIJP<NHCHNMDCFDH, Texture2D> ANFJLIFADHJ;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x58B6C20", Offset = "0x58B5E20", VA = "0x1858B6C20")]
	public BIPLLOOPDKM(Func<TImageId, CancellationToken, Task<byte[]>> FMEGAMKGPFD, [Optional] Func<TImageId, string>? EIINMLCGOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x58B6BD0", Offset = "0x58B5DD0", VA = "0x1858B6BD0")]
	public BIPLLOOPDKM(Func<TImageId, OJGLMGEDFJG, CancellationToken, Task<Texture2D>> AJLLAEAHJJE, [Optional] Func<TImageId, string>? EIINMLCGOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x58B6E20", Offset = "0x58B6020", VA = "0x1858B6E20")]
	private BIPLLOOPDKM(Func<TImageId, CancellationToken, Task<byte[]>>? FMEGAMKGPFD, Func<TImageId, OJGLMGEDFJG, CancellationToken, Task<Texture2D>>? AJLLAEAHJJE, Func<TImageId, string>? EIINMLCGOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x58B6540", Offset = "0x58B5740", VA = "0x1858B6540")]
	public CAFFOJNOKAH<Texture2D> EIGKOAGBCIE(TImageId JNCBENBLCFC, OJGLMGEDFJG KPKIFCCKKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x58B6740", Offset = "0x58B5940", VA = "0x1858B6740")]
	public void FPLCEDCJIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x58B6280", Offset = "0x58B5480", VA = "0x1858B6280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x58B5D20", Offset = "0x58B4F20", VA = "0x1858B5D20")]
	[AsyncStateMachine(typeof(BIPLLOOPDKM<>.DFLBHMNPMGF))]
	private Task<Texture2D> DJIFGINBHEA(NHCHNMDCFDH EEJEPADMFFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x58B5FC0", Offset = "0x58B51C0", VA = "0x1858B5FC0")]
	[AsyncStateMachine(typeof(BIPLLOOPDKM<>.BBEBAMKEOND))]
	private Task<Texture2D> DMOEKIOIKHM(byte[] KCDHCMOJGEN, OJGLMGEDFJG KPKIFCCKKGP, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x58B6790", Offset = "0x58B5990", VA = "0x1858B6790")]
	private void IOGAOJDBDEH(Texture2D GOADEEFLEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x58B6730", Offset = "0x58B5930", VA = "0x1858B6730")]
	private bool FHEAHOIDBCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x58B6980", Offset = "0x58B5B80", VA = "0x1858B6980")]
	private bool PEJDEONLOAJ(byte[] KCDHCMOJGEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x58B67A0", Offset = "0x58B59A0", VA = "0x1858B67A0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(BIPLLOOPDKM<>.MKMEPPKLPLI))]
	internal static Task NPICEPEMHPC(IDisposable LDNPLHLMIKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum OJGLMGEDFJG : byte
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
