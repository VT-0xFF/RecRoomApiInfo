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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x695D330", Offset = "0x695B930", VA = "0x18695D330")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
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
		[Cpp2IlInjected.Address(RVA = "0x695A120", Offset = "0x6958720", VA = "0x18695A120")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum NFMGHBCIAKP
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
public interface EPJPFJPNPID
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NFMGHBCIAKP FMJFKBCNIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NFFJDFIILJC(VertexAttributeFormat JFOBPJMAIKI, int JNIIKNIJHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CEMNOGHBOMC
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
			[Cpp2IlInjected.Address(RVA = "0x695D670", Offset = "0x695BC70", VA = "0x18695D670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x695D660", Offset = "0x695BC60", VA = "0x18695D660")]
		public Resolution(uint OOALEDCPNBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC515B0", Offset = "0xC4FBB0", VA = "0x180C515B0")]
		public Resolution(uint OOALEDCPNBJ, uint HDFOCKKCOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x695D570", Offset = "0x695BB70", VA = "0x18695D570")]
		public static Resolution MPNMBGCPMBC(Resolution[] HEBGDGGBJPN, Resolution HKGEONOEPCI, int ICGLDECLCAL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EFPLNBHJGAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution NGDNKBHCIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? LAPJPIGOHPF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint OOALEDCPNBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x695AC40", Offset = "0x6959240", VA = "0x18695AC40")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution IKFBDEPCFFB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x695A780", Offset = "0x6958D80", VA = "0x18695A780")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1C51390", Offset = "0x1C4F990", VA = "0x181C51390")]
		public EFPLNBHJGAO(Resolution NGDNKBHCIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x695AAC0", Offset = "0x69590C0", VA = "0x18695AAC0")]
		private static Resolution FNELLKMAEID(Resolution LAPJPIGOHPF, NFMGHBCIAKP EICHCCOIHCN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class BFAJGANLJFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution JIHLGLHBKOD;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution AOEJIOHKDOK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution AIGHHIJLILD;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution LFKBIBPIKGK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution JIEBENGIBCP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution PJPIEPPFKNB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] JNHDHBPKCMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class LKDIOGMJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution BBFONGJFFGM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution AOJMDHJMHEG;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution LOJHFPLMCMO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution HBFGNKPBIGM;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution JKPAEINFLNC;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] JNHDHBPKCMJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x695B870", Offset = "0x6959E70", VA = "0x18695B870")]
		public static Resolution FCOCOKLLMLI(uint LLKEJNDKCDC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution IOFLEJEKDGI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class HFIIHJPOJHE
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x695AE60", Offset = "0x6959460", VA = "0x18695AE60")]
	public static bool LBIACNKIJOM(byte[] FHNKDHIILBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x695AC50", Offset = "0x6959250", VA = "0x18695AC50")]
	public static bool DLFOLKEBOEC(byte[] FHNKDHIILBL, [Out] int LLKEJNDKCDC, [Out] int HIHOMDFABKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x695AEA0", Offset = "0x69594A0", VA = "0x18695AEA0")]
	private static int NGMAJAJGOBD(byte[] FHNKDHIILBL, int GEIGDPFELPO, [Out] ushort LPEADLIENGO)
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
		public enum EOHFNLINKNP : byte
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
		private class NGNMCFFANNF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string LCLKDNPLMED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D HCPDGDFHMFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public EOHFNLINKNP BCBAHBHIALG;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x695CBB0", Offset = "0x695B1B0", VA = "0x18695CBB0")]
			public NGNMCFFANNF(string LCLKDNPLMED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3CC7F80", Offset = "0x3CC6580", VA = "0x183CC7F80")]
			public NGNMCFFANNF(string LCLKDNPLMED, Texture2D ODAFHLABAMN, EOHFNLINKNP AFFMLPDCPEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x695CB70", Offset = "0x695B170", VA = "0x18695CB70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class LHEGLDNIHFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public EOHFNLINKNP textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public LHEGLDNIHFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x695B830", Offset = "0x6959E30", VA = "0x18695B830")]
			internal void OPLIBCJJEII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OAKBHOAMAOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public OAKBHOAMAOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x695D3B0", Offset = "0x695B9B0", VA = "0x18695D3B0")]
			internal DMHBNJNFFJP JDKPDPEGFBD(Texture2D t2d)
			{
				return default(DMHBNJNFFJP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class OONJJHHDHKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public OONJJHHDHKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x695D3F0", Offset = "0x695B9F0", VA = "0x18695D3F0")]
			internal void CIGIKEDDLBC()
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
		private HCGNNEJAOHI<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NGNMCFFANNF _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private HCGNNEJAOHI<DMHBNJNFFJP> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private HCGNNEJAOHI<DMHBNJNFFJP> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B5660", Offset = "0x8B3C60", VA = "0x1808B5660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x864E00", Offset = "0x863400", VA = "0x180864E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private NGNMCFFANNF memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x695CAC0", Offset = "0x695B0C0", VA = "0x18695CAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x695C9F0", Offset = "0x695AFF0", VA = "0x18695C9F0")]
		public ManagedTexture(string LCLKDNPLMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x695CA50", Offset = "0x695B050", VA = "0x18695CA50")]
		public ManagedTexture(string LCLKDNPLMED, bool JNJDPFNFIDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x695C460", Offset = "0x695AA60", VA = "0x18695C460")]
		public void IAJLCAHMGHJ(RenderTexture PNMGAIOOBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x695C170", Offset = "0x695A770", VA = "0x18695C170")]
		public HCGNNEJAOHI<Texture2D> GPMILMHOOMG(EOHFNLINKNP AFFMLPDCPEL, bool KBFIPOLEDHC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x695BF60", Offset = "0x695A560", VA = "0x18695BF60")]
		public HCGNNEJAOHI<DMHBNJNFFJP> DJOHKLHLICP(bool KBFIPOLEDHC = false, int FAOIHJAGHHE = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x695BC60", Offset = "0x695A260", VA = "0x18695BC60")]
		public HCGNNEJAOHI<DMHBNJNFFJP> CPGLGCCFPLA(bool KBFIPOLEDHC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x695C4A0", Offset = "0x695AAA0", VA = "0x18695C4A0")]
		private static HCGNNEJAOHI<Texture2D> KIEAIOFFNMK(string LCLKDNPLMED, RenderTexture PNMGAIOOBPI, Texture2D PLHPKGACIFB, bool KBFIPOLEDHC, EOHFNLINKNP KKGILNKDEBI = EOHFNLINKNP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x695BBC0", Offset = "0x695A1C0", VA = "0x18695BBC0")]
		public void CFBCALGIPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x695C100", Offset = "0x695A700", VA = "0x18695C100", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x695C110", Offset = "0x695A710", VA = "0x18695C110")]
		[CompilerGenerated]
		private HCGNNEJAOHI<byte[]> GCBOALMOAMN(Texture2D OHIPPDIPDKC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DIFJAPILEPN
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct PBIMAIEGCMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x695D470", Offset = "0x695BA70", VA = "0x18695D470")]
		public unsafe static extern void NIECGDJCJHG(void* BPNNLKMMBFE, void* FIEEIAHPDIF, bool PBCMGLCDAHA, bool MIMJDMGCDPB, bool NIEGIMOBCIJ, [Out] int LLKEJNDKCDC, [Out] int HIHOMDFABKJ, [Out] bool FPOOMLCKGNF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BIFBBLCNFLJ
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
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BIFBBLCNFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6959DB0", Offset = "0x69583B0", VA = "0x186959DB0")]
		internal void LLJHFEHCGHI(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KCDAFLPCEEG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x695B5A0", Offset = "0x6959BA0", VA = "0x18695B5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x695B7C0", Offset = "0x6959DC0", VA = "0x18695B7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DEIDGEBKLCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DEIDGEBKLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x695A140", Offset = "0x6958740", VA = "0x18695A140")]
		internal void FLPEADIOFDH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct NKAJLAGOIFD : IAsyncStateMachine
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
		private DEIDGEBKLCG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x695CC00", Offset = "0x695B200", VA = "0x18695CC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x695D2C0", Offset = "0x695B8C0", VA = "0x18695D2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool DHDFKJOEAAO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0")]
	public static bool GMICPDPFKFM(byte[] LBLMOOIFDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x695A180", Offset = "0x6958780", VA = "0x18695A180")]
	[AsyncStateMachine(typeof(KCDAFLPCEEG))]
	public static Task<Texture2D> IIEMMLHKEDE(byte[] LBLMOOIFDDB, bool GKJDHMBJAAE = false, bool HBMEMEIBNKI = false, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x695A2C0", Offset = "0x69588C0", VA = "0x18695A2C0")]
	[AsyncStateMachine(typeof(NKAJLAGOIFD))]
	private static Task<Texture2D> JGHMBHGMEDK(int LLKEJNDKCDC, int HIHOMDFABKJ, bool LJJCPCOIPNP, bool GKJDHMBJAAE, bool HBMEMEIBNKI, Action<NativeArray<byte>> FJHJOMPMMHO, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x695A410", Offset = "0x6958A10", VA = "0x18695A410")]
	private static TextureFormat PEGIGOGHAIL(bool LJJCPCOIPNP)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum BOJLFBOHMLF
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
internal static class KACOMEMGPND
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x695B230", Offset = "0x6959830", VA = "0x18695B230")]
	public static bool IIAINMCFLBF(byte[] FHNKDHIILBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x695AF30", Offset = "0x6959530", VA = "0x18695AF30")]
	public static void BIFGBLKNEKL(byte[] FHNKDHIILBL, [Out] int LLKEJNDKCDC, [Out] int HIHOMDFABKJ, [Out] BOJLFBOHMLF JFOBPJMAIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x695B270", Offset = "0x6959870", VA = "0x18695B270")]
	private static uint JJIOOGDLEJN(byte[] FHNKDHIILBL, int ODFMKGCLIGE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x695B3A0", Offset = "0x69599A0", VA = "0x18695B3A0")]
	private static ulong ODKOMEMHGHD(byte[] FHNKDHIILBL, int ODFMKGCLIGE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class EBPNKGLDBBC
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x695A4F0", Offset = "0x6958AF0", VA = "0x18695A4F0")]
	public static RenderTexture EMCAHNIKPKG(int LLKEJNDKCDC, int HIHOMDFABKJ, int BIEKFBHNJPE, Camera CMPADPIDKEM, RenderTextureMemoryless HLJPBIFFCNH = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x695A720", Offset = "0x6958D20", VA = "0x18695A720")]
	public static void LGDHNJIFHEH(RenderTexture PNMGAIOOBPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class ONLDAMIDLOI<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct GGHKMMHDDOO : IEquatable<GGHKMMHDDOO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId PNLBFEDGBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly DLHENFGBHJG IBMEGKNLFGE;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3D20E20", Offset = "0x3D1F420", VA = "0x183D20E20")]
		public GGHKMMHDDOO(TImageId BHEIPBKEDLG, DLHENFGBHJG JNNOCNGABCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3D20860", Offset = "0x3D1EE60", VA = "0x183D20860", Slot = "4")]
		public bool Equals(ONLDAMIDLOI<TImageId>.GGHKMMHDDOO LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3D206E0", Offset = "0x3D1ECE0", VA = "0x183D206E0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3D20C00", Offset = "0x3D1F200", VA = "0x183D20C00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3D20DA0", Offset = "0x3D1F3A0", VA = "0x183D20DA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DKFMAIPOBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public BCBDLBGONLF<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DKFMAIPOBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x582DB90", Offset = "0x582C190", VA = "0x18582DB90")]
		internal void HKNMCBOJGLL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LJPLOFHHABE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public GGHKMMHDDOO cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ONLDAMIDLOI<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private DLHENFGBHJG <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x42C8DD0", Offset = "0x42C73D0", VA = "0x1842C8DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x42C9C30", Offset = "0x42C8230", VA = "0x1842C9C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct LECIHCHNFLL : IAsyncStateMachine
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
		public DLHENFGBHJG textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public ONLDAMIDLOI<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x42A7250", Offset = "0x42A5850", VA = "0x1842A7250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x42A7970", Offset = "0x42A5F70", VA = "0x1842A7970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct EABCFAHIDBD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x37C2620", Offset = "0x37C0C20", VA = "0x1837C2620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x37C29E0", Offset = "0x37C0FE0", VA = "0x1837C29E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int KEMJAOGCOEB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim BMPJBACKOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? KPLGEIGNKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, DLHENFGBHJG, CancellationToken, Task<Texture2D>>? BOFEDJJECDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? ABMGKPPHKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly KMPILIIFONB<GGHKMMHDDOO, Texture2D> OLOAKIJKJEP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x46A2600", Offset = "0x46A0C00", VA = "0x1846A2600")]
	public ONLDAMIDLOI(Func<TImageId, CancellationToken, Task<byte[]>> GHAHPHCBCPI, [Optional] Func<TImageId, string>? AIPNPKBNNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x46A25B0", Offset = "0x46A0BB0", VA = "0x1846A25B0")]
	public ONLDAMIDLOI(Func<TImageId, DLHENFGBHJG, CancellationToken, Task<Texture2D>> LCCAIJBGAKJ, [Optional] Func<TImageId, string>? AIPNPKBNNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x46A2650", Offset = "0x46A0C50", VA = "0x1846A2650")]
	private ONLDAMIDLOI(Func<TImageId, CancellationToken, Task<byte[]>>? GHAHPHCBCPI, Func<TImageId, DLHENFGBHJG, CancellationToken, Task<Texture2D>>? LCCAIJBGAKJ, Func<TImageId, string>? AIPNPKBNNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x46A19D0", Offset = "0x469FFD0", VA = "0x1846A19D0")]
	public FMHOFFFMGIN<Texture2D> ECLIHBNIDDO(TImageId EKDHMPINGII, DLHENFGBHJG OJGHEHPOFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x46A20D0", Offset = "0x46A06D0", VA = "0x1846A20D0")]
	public void MNLMFOIGPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x46A1920", Offset = "0x469FF20", VA = "0x1846A1920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46A1F70", Offset = "0x46A0570", VA = "0x1846A1F70")]
	[AsyncStateMachine(typeof(ONLDAMIDLOI<>.LJPLOFHHABE))]
	private Task<Texture2D> INHCLDCGPGK(GGHKMMHDDOO LAGEFHPKEIC, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x46A2290", Offset = "0x46A0890", VA = "0x1846A2290")]
	[AsyncStateMachine(typeof(ONLDAMIDLOI<>.LECIHCHNFLL))]
	private Task<Texture2D> NODDIBGJNAP(byte[] LBLMOOIFDDB, DLHENFGBHJG OJGHEHPOFMO, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46A1910", Offset = "0x469FF10", VA = "0x1846A1910")]
	private void BLNLFJGNOCG(Texture2D ODAFHLABAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x46A1E10", Offset = "0x46A0410", VA = "0x1846A1E10")]
	private bool IHEBHJALMEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46A1860", Offset = "0x469FE60", VA = "0x1846A1860")]
	private bool BILPNABCDFJ(byte[] LBLMOOIFDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46A1680", Offset = "0x469FC80", VA = "0x1846A1680")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(ONLDAMIDLOI<>.EABCFAHIDBD))]
	internal static Task ACFLLDDJONG(IDisposable BFIGCJGPGNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum DLHENFGBHJG : byte
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
