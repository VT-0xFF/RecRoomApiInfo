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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C71480", Offset = "0x6C70080", VA = "0x186C71480")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C6EFE0", Offset = "0x6C6DBE0", VA = "0x186C6EFE0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EAPHNCOENHH
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
			[Cpp2IlInjected.Address(RVA = "0x6C71600", Offset = "0x6C70200", VA = "0x186C71600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C715F0", Offset = "0x6C701F0", VA = "0x186C715F0")]
		public Resolution(uint MBJABMPNEHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
		public Resolution(uint MBJABMPNEHF, uint MNMGCDILGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C71500", Offset = "0x6C70100", VA = "0x186C71500")]
		public static Resolution BNBKCOCNFCG(Resolution[] OGIKBJOPPCP, Resolution PALMJMMAIEC, int MDOLIGEHOJD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class BLJPCHEMILD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution LBGLNOCKNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? FLKELPJHDCM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint MBJABMPNEHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6C6EB50", Offset = "0x6C6D750", VA = "0x186C6EB50")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution DGKPDLHLNLD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6C6E800", Offset = "0x6C6D400", VA = "0x186C6E800")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1F695C0", Offset = "0x1F681C0", VA = "0x181F695C0")]
		public BLJPCHEMILD(Resolution LBGLNOCKNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E680", Offset = "0x6C6D280", VA = "0x186C6E680")]
		private static Resolution BDJLHFFEFOF(Resolution FLKELPJHDCM, HBPOIHNBAON IAFGKHHKBJD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CHMLENGEDGB
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution ABIDHKDPLFM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution GGHIIDPBCKH;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution CCHAODPMCFI;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution EBLNPOGOLKB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution EMEJDLAAHPB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution HKHCOLJKCMI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] AJNJFBEDBGC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class KPJECOLEGJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PHFBCJLKKII;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution KAKLPFGFNPC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution AKCAGABMEOK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution BPBKKICPIPL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution BDHMPNIFPOJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] AJNJFBEDBGC;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F410", Offset = "0x6C6E010", VA = "0x186C6F410")]
		public static Resolution JABEMMCMBIK(uint MBNEPKJJCNM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution FHACMJCCMCJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class BAIAGKIHFII
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E5B0", Offset = "0x6C6D1B0", VA = "0x186C6E5B0")]
	public static bool EJMFIOCMNDO(byte[] BFLLAIFBMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E3A0", Offset = "0x6C6CFA0", VA = "0x186C6E3A0")]
	public static bool CBMJAFNIOEK(byte[] BFLLAIFBMAJ, [Out] int MBNEPKJJCNM, [Out] int DEKKEALBCEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E5F0", Offset = "0x6C6D1F0", VA = "0x186C6E5F0")]
	private static int OHLPNKKAONN(byte[] BFLLAIFBMAJ, int HAOCJMNINJC, [Out] ushort ILIJPKIJFNN)
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
		public enum GPJKKMGNLKL : byte
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
		private class ABGOBIMKODN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string GMBAACDNNFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D NBELKKBEGID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GPJKKMGNLKL NEICOEOIPOD;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6C6DE50", Offset = "0x6C6CA50", VA = "0x186C6DE50")]
			public ABGOBIMKODN(string GMBAACDNNFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4586410", Offset = "0x4585010", VA = "0x184586410")]
			public ABGOBIMKODN(string GMBAACDNNFI, Texture2D NKCDINKPPDP, GPJKKMGNLKL IGEFPMPCBKC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6C6DE10", Offset = "0x6C6CA10", VA = "0x186C6DE10", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GOLLGIHDKNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public GPJKKMGNLKL textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public GOLLGIHDKNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6C6F350", Offset = "0x6C6DF50", VA = "0x186C6F350")]
			internal void CELDFLHEDBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JACAJADAMCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public JACAJADAMCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6C6F3D0", Offset = "0x6C6DFD0", VA = "0x186C6F3D0")]
			internal PAFLMOOHACI EFFJBKBJKLJ(Texture2D t2d)
			{
				return default(PAFLMOOHACI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DMFNJODFJCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public DMFNJODFJCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6C6F100", Offset = "0x6C6DD00", VA = "0x186C6F100")]
			internal void GGOOHJDMKLF()
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
		private HHDNLBNGHMC<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private ABGOBIMKODN _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HHDNLBNGHMC<PAFLMOOHACI> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private HHDNLBNGHMC<PAFLMOOHACI> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x935C80", Offset = "0x934880", VA = "0x180935C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private ABGOBIMKODN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6C70D50", Offset = "0x6C6F950", VA = "0x186C70D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C80", Offset = "0x6C6F880", VA = "0x186C70C80")]
		public ManagedTexture(string GMBAACDNNFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C70CE0", Offset = "0x6C6F8E0", VA = "0x186C70CE0")]
		public ManagedTexture(string GMBAACDNNFI, bool OOHJJHOLJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C703B0", Offset = "0x6C6EFB0", VA = "0x186C703B0")]
		public void AJIGENPHCOH(RenderTexture KFBFLGILNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C703F0", Offset = "0x6C6EFF0", VA = "0x186C703F0")]
		public HHDNLBNGHMC<Texture2D> BIGDDMHENGF(GPJKKMGNLKL IGEFPMPCBKC, bool PIAKGHFKDOF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C709E0", Offset = "0x6C6F5E0", VA = "0x186C709E0")]
		public HHDNLBNGHMC<PAFLMOOHACI> IHLFNILDKCM(bool PIAKGHFKDOF = false, int EHGIDCFLOCO = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C706F0", Offset = "0x6C6F2F0", VA = "0x186C706F0")]
		public HHDNLBNGHMC<PAFLMOOHACI> GCCLHDIJLAI(bool PIAKGHFKDOF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FE60", Offset = "0x6C6EA60", VA = "0x186C6FE60")]
		private static HHDNLBNGHMC<Texture2D> AFHEOPHJPJN(string GMBAACDNNFI, RenderTexture KFBFLGILNDH, Texture2D KIPEMIJJPOE, bool PIAKGHFKDOF, GPJKKMGNLKL MFKBNFMCENH = GPJKKMGNLKL.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C70B80", Offset = "0x6C6F780", VA = "0x186C70B80")]
		public void JHNKFELOOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C706E0", Offset = "0x6C6F2E0", VA = "0x186C706E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C20", Offset = "0x6C6F820", VA = "0x186C70C20")]
		[CompilerGenerated]
		private HHDNLBNGHMC<byte[]> KHOPBFMCFIL(Texture2D JEPHALJPAOM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AMCGKLJGNNO
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct DBNIDDGMPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F000", Offset = "0x6C6DC00", VA = "0x186C6F000")]
		public unsafe static extern void LKKJFLMINGH(void* COBFFPCAGDN, void* LMJFOHKAJHJ, bool NCNPFCKEMGC, bool HANCANCLDHI, bool NNNBACNLFJL, [Out] int MBNEPKJJCNM, [Out] int DEKKEALBCEP, [Out] bool IFGFDFNLDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class ALIDPGLBCAN
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
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ALIDPGLBCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C6DEA0", Offset = "0x6C6CAA0", VA = "0x186C6DEA0")]
		internal void LFLBNBLDCBP(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct AANOFFCIBNJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6C6DB80", Offset = "0x6C6C780", VA = "0x186C6DB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C6DDA0", Offset = "0x6C6C9A0", VA = "0x186C6DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HCGBLDFCMIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public HCGBLDFCMIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F390", Offset = "0x6C6DF90", VA = "0x186C6F390")]
		internal void ACJMDKDKPII()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LMBKCFEADJO : IAsyncStateMachine
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
		private HCGBLDFCMIP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F730", Offset = "0x6C6E330", VA = "0x186C6F730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FDF0", Offset = "0x6C6E9F0", VA = "0x186C6FDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool ICEGEMAOHPC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0")]
	public static bool BGJJCLPCKBG(byte[] JCAJIEAMPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E0D0", Offset = "0x6C6CCD0", VA = "0x186C6E0D0")]
	[AsyncStateMachine(typeof(AANOFFCIBNJ))]
	public static Task<Texture2D> DFDOMJKBCMG(byte[] JCAJIEAMPFE, bool IHBLEFDNNAK = false, bool LDDCKFABLDJ = false, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E210", Offset = "0x6C6CE10", VA = "0x186C6E210")]
	[AsyncStateMachine(typeof(LMBKCFEADJO))]
	private static Task<Texture2D> LMKBKJIPAJC(int MBNEPKJJCNM, int DEKKEALBCEP, bool ENCAGANJNLI, bool IHBLEFDNNAK, bool LDDCKFABLDJ, Action<NativeArray<byte>> FMLMCJDCNGL, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E040", Offset = "0x6C6CC40", VA = "0x186C6E040")]
	private static TextureFormat AOCBNCGIGIJ(bool ENCAGANJNLI)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum JOOFFGLBGDO
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
internal static class NGHEGFABEKO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C71000", Offset = "0x6C6FC00", VA = "0x186C71000")]
	public static bool JFINLBIAOAJ(byte[] BFLLAIFBMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C71040", Offset = "0x6C6FC40", VA = "0x186C71040")]
	public static void KLMFHPAFBAI(byte[] BFLLAIFBMAJ, [Out] int MBNEPKJJCNM, [Out] int DEKKEALBCEP, [Out] JOOFFGLBGDO DNBEJMJLODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C71350", Offset = "0x6C6FF50", VA = "0x186C71350")]
	private static uint OLLLFEHAKCP(byte[] BFLLAIFBMAJ, int GMEOEMGBEED)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C70E00", Offset = "0x6C6FA00", VA = "0x186C70E00")]
	private static ulong CHFMHNFJOBN(byte[] BFLLAIFBMAJ, int GMEOEMGBEED)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class COCPJPLGINH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EDB0", Offset = "0x6C6D9B0", VA = "0x186C6EDB0")]
	public static RenderTexture BLPDBJGOKED(int MBNEPKJJCNM, int DEKKEALBCEP, int DOMLIDIMPPO, Camera FDEJBGLBHHB, RenderTextureMemoryless NABFBFDBBMH = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED50", Offset = "0x6C6D950", VA = "0x186C6ED50")]
	public static void AMFCEPMHJMC(RenderTexture KFBFLGILNDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class COGMCEGLEKH<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct IDNEKNPLOOE : IEquatable<IDNEKNPLOOE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId DGBLPIMKPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly OFAIJPNINJM JNIHLLDANFC;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x10BF1C0", Offset = "0x10BDDC0", VA = "0x1810BF1C0")]
		public IDNEKNPLOOE(TImageId NONKDEOLPHL, OFAIJPNINJM JHFNPLFMBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x401A8C0", Offset = "0x40194C0", VA = "0x18401A8C0", Slot = "4")]
		public bool Equals(COGMCEGLEKH<TImageId>.IDNEKNPLOOE FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x401AB30", Offset = "0x4019730", VA = "0x18401AB30", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x401ACD0", Offset = "0x40198D0", VA = "0x18401ACD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x401AE80", Offset = "0x4019A80", VA = "0x18401AE80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FBHMOBDIANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LFNFGMGFLKN<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public FBHMOBDIANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3DE74E0", Offset = "0x3DE60E0", VA = "0x183DE74E0")]
		internal void MKBHPCMLNHD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct COKBIGJDMIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IDNEKNPLOOE cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public COGMCEGLEKH<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private OFAIJPNINJM <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x55E9EF0", Offset = "0x55E8AF0", VA = "0x1855E9EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x55EAD20", Offset = "0x55E9920", VA = "0x1855EAD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct EEBJLFOEIBE : IAsyncStateMachine
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
		public OFAIJPNINJM textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public COGMCEGLEKH<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3A65760", Offset = "0x3A64360", VA = "0x183A65760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3A65E60", Offset = "0x3A64A60", VA = "0x183A65E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct HAFLLELMEGF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x3F2D0E0", Offset = "0x3F2BCE0", VA = "0x183F2D0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D500", Offset = "0x3F2C100", VA = "0x183F2D500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int PAJPDIDHEGC = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim AHAEBHGOCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? KMHECBICNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, OFAIJPNINJM, CancellationToken, Task<Texture2D>>? PJLDNGIAFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? MGHDCDKBMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly AKKGBCJBMHJ<IDNEKNPLOOE, Texture2D> DFFBMPPCFKI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x55E9110", Offset = "0x55E7D10", VA = "0x1855E9110")]
	public COGMCEGLEKH(Func<TImageId, CancellationToken, Task<byte[]>> IFMDADFEDOK, [Optional] Func<TImageId, string>? LGDKKFGJGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x55E9160", Offset = "0x55E7D60", VA = "0x1855E9160")]
	public COGMCEGLEKH(Func<TImageId, OFAIJPNINJM, CancellationToken, Task<Texture2D>> MJGODKNKJPN, [Optional] Func<TImageId, string>? LGDKKFGJGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x55E91B0", Offset = "0x55E7DB0", VA = "0x1855E91B0")]
	private COGMCEGLEKH(Func<TImageId, CancellationToken, Task<byte[]>>? IFMDADFEDOK, Func<TImageId, OFAIJPNINJM, CancellationToken, Task<Texture2D>>? MJGODKNKJPN, Func<TImageId, string>? LGDKKFGJGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x55E8480", Offset = "0x55E7080", VA = "0x1855E8480")]
	public MGEGMLPKNPK<Texture2D> BACNPOGNLCL(TImageId PHGKANOANOB, OFAIJPNINJM ONGNJGAJNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x55E8C70", Offset = "0x55E7870", VA = "0x1855E8C70")]
	public void ONCBGJCMNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x55E8720", Offset = "0x55E7320", VA = "0x1855E8720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x55E8E20", Offset = "0x55E7A20", VA = "0x1855E8E20")]
	[AsyncStateMachine(typeof(COGMCEGLEKH<>.COKBIGJDMIB))]
	private Task<Texture2D> PPBBAPCPLGL(IDNEKNPLOOE EFGPCFMPHGL, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x55E8920", Offset = "0x55E7520", VA = "0x1855E8920")]
	[AsyncStateMachine(typeof(COGMCEGLEKH<>.EEBJLFOEIBE))]
	private Task<Texture2D> HFJKPCLIEDC(byte[] JCAJIEAMPFE, OFAIJPNINJM ONGNJGAJNIH, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x55E8CC0", Offset = "0x55E78C0", VA = "0x1855E8CC0")]
	private void OPNMJHCFNJB(Texture2D NKCDINKPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x55E8C60", Offset = "0x55E7860", VA = "0x1855E8C60")]
	private bool OFEDCCFLFOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x55E8670", Offset = "0x55E7270", VA = "0x1855E8670")]
	private bool CHEAKDNJMPH(byte[] JCAJIEAMPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x55E8A80", Offset = "0x55E7680", VA = "0x1855E8A80")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(COGMCEGLEKH<>.HAFLLELMEGF))]
	internal static Task JFKMAKENCPK(IDisposable FNOEPLKNDHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum OFAIJPNINJM : byte
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
