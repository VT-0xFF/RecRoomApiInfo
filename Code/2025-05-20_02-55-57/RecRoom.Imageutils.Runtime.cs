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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCDC10", Offset = "0x7CCCE10", VA = "0x187CCDC10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CCA8D0", Offset = "0x7CC9AD0", VA = "0x187CCA8D0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FNENMIPLDBH
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
			[Cpp2IlInjected.Address(RVA = "0x7CCE0B0", Offset = "0x7CCD2B0", VA = "0x187CCE0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE0A0", Offset = "0x7CCD2A0", VA = "0x187CCE0A0")]
		public Resolution(uint CCOLDGJALNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
		public Resolution(uint CCOLDGJALNH, uint JCBKIOEHCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CCDFB0", Offset = "0x7CCD1B0", VA = "0x187CCDFB0")]
		public static Resolution KHFEAELDEDF(Resolution[] KDLGPMFPDII, Resolution OIAFDPOGLJP, int GGBCDIEKNKG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class HGBJCFCNENN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution JJIMCGEOCEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? MKCGFHEEIKM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint CCOLDGJALNH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7CCB880", Offset = "0x7CCAA80", VA = "0x187CCB880")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution HJLMPOKNCIF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7CCB890", Offset = "0x7CCAA90", VA = "0x187CCB890")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDF31A0", Offset = "0xDF23A0", VA = "0x180DF31A0")]
		public HGBJCFCNENN(Resolution JJIMCGEOCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7CCBBE0", Offset = "0x7CCADE0", VA = "0x187CCBBE0")]
		private static Resolution LBKMHOHKMON(Resolution MKCGFHEEIKM, MGJJDGFIBME DDJEFNNGODN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FPDABJPFIDN
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution BOMDGMGDMNF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution AFBLIIHHIMK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution GFPBBLKBMED;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution JLEFNFGMMJG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution GBKHFIMEGCI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution CHAIANDNHEA;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] FHBHNBAKFAM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ODDFOIPENGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OJEIBMLNMEK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution NAIPADOLLFL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution FOHLKIJHKFO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution KFIAPPEBJAC;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution APBOOCDOBAN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] FHBHNBAKFAM;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CCDC90", Offset = "0x7CCCE90", VA = "0x187CCDC90")]
		public static Resolution NLMCAINGBED(uint GMGIBIFALPD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution BPLBIABEBCM;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GBGELGKDPFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB840", Offset = "0x7CCAA40", VA = "0x187CCB840")]
	public static bool PBJECMPBCKH(byte[] DHAOEHNLNON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB5A0", Offset = "0x7CCA7A0", VA = "0x187CCB5A0")]
	public static bool BLAOCMEDIOP(byte[] DHAOEHNLNON, [Out] int GMGIBIFALPD, [Out] int PKHBHCLOCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB7B0", Offset = "0x7CCA9B0", VA = "0x187CCB7B0")]
	private static int LIIJFCBJFJN(byte[] DHAOEHNLNON, int AIGLIPKHKOK, [Out] ushort LFCIJNKIIJO)
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
		public enum DJILMHCAECA : byte
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
		private class KBDHMFGLCME : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string DGIAFBEDPNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D LFJIKAJNPEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public DJILMHCAECA DKOLLLANPMN;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7CCC420", Offset = "0x7CCB620", VA = "0x187CCC420")]
			public KBDHMFGLCME(string DGIAFBEDPNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x19BF950", Offset = "0x19BEB50", VA = "0x1819BF950")]
			public KBDHMFGLCME(string DGIAFBEDPNJ, Texture2D BEFHHDCIDIH, DJILMHCAECA PFLGGOFKLKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7CCC3E0", Offset = "0x7CCB5E0", VA = "0x187CCC3E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FLKHHFLCMMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public DJILMHCAECA textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public FLKHHFLCMMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7CCB1A0", Offset = "0x7CCA3A0", VA = "0x187CCB1A0")]
			internal void BPBLMNFGJAD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FHKFLOLAILA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public FHKFLOLAILA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7CCAA30", Offset = "0x7CC9C30", VA = "0x187CCAA30")]
			internal FAPOCLNGNDE FAMAJAGCHFJ(Texture2D t2d)
			{
				return default(FAPOCLNGNDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class MMFCHLMGIKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public MMFCHLMGIKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7CCC8A0", Offset = "0x7CCBAA0", VA = "0x187CCC8A0")]
			internal void NDOGAPKKNJP()
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
		private CMEBMOPMCFP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KBDHMFGLCME _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CMEBMOPMCFP<FAPOCLNGNDE> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private CMEBMOPMCFP<FAPOCLNGNDE> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private KBDHMFGLCME memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7CCD800", Offset = "0x7CCCA00", VA = "0x187CCD800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD730", Offset = "0x7CCC930", VA = "0x187CCD730")]
		public ManagedTexture(string DGIAFBEDPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD790", Offset = "0x7CCC990", VA = "0x187CCD790")]
		public ManagedTexture(string DGIAFBEDPNJ, bool IFBMOJGBMML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD6F0", Offset = "0x7CCC8F0", VA = "0x187CCD6F0")]
		public void PMOICFGLKHK(RenderTexture PMHKGBLCIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7CCCB20", Offset = "0x7CCBD20", VA = "0x187CCCB20")]
		public CMEBMOPMCFP<Texture2D> HDBDPGJHONB(DJILMHCAECA PFLGGOFKLKE, bool EPDMDLNCFEM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7CCC980", Offset = "0x7CCBB80", VA = "0x187CCC980")]
		public CMEBMOPMCFP<FAPOCLNGNDE> COFKHPNEBEP(bool EPDMDLNCFEM = false, int PIIOJJINABG = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7CCCEB0", Offset = "0x7CCC0B0", VA = "0x187CCCEB0")]
		public CMEBMOPMCFP<FAPOCLNGNDE> LAGMKPDOPBE(bool EPDMDLNCFEM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD1A0", Offset = "0x7CCC3A0", VA = "0x187CCD1A0")]
		private static CMEBMOPMCFP<Texture2D> OCIKHKEBMHC(string DGIAFBEDPNJ, RenderTexture PMHKGBLCIPJ, Texture2D CKGMFJAFBOA, bool EPDMDLNCFEM, DJILMHCAECA KFMEBMDKDPN = DJILMHCAECA.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7CCCE10", Offset = "0x7CCC010", VA = "0x187CCCE10")]
		public void IBNCGNDJIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7CCCB10", Offset = "0x7CCBD10", VA = "0x187CCCB10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7CCC920", Offset = "0x7CCBB20", VA = "0x187CCC920")]
		[CompilerGenerated]
		private CMEBMOPMCFP<byte[]> BLNAHOLBGPH(Texture2D IDCOBOHHALE)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NBOLPGGIIIP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct DDKJGJMBBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA8F0", Offset = "0x7CC9AF0", VA = "0x187CCA8F0")]
		public unsafe static extern void INFLLGGLHKK(void* MEAFCOPCLDJ, void* PDBEAHFDFJA, bool FFIDKFBHFEC, bool AFMGGLKCEGE, bool MKEFPBBAIPJ, [Out] int GMGIBIFALPD, [Out] int PKHBHCLOCLA, [Out] bool DMOIGCKPBLD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LJFBBNPBELD
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
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LJFBBNPBELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7CCC700", Offset = "0x7CCB900", VA = "0x187CCC700")]
		internal void LDBBECMPMPJ(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LDIFBICHEGB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7CCC470", Offset = "0x7CCB670", VA = "0x187CCC470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7CCC690", Offset = "0x7CCB890", VA = "0x187CCC690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class EDBFMDNELDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EDBFMDNELDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA9F0", Offset = "0x7CC9BF0", VA = "0x187CCA9F0")]
		internal void FGJFFEBEHLD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FLIMPHBNKHM : IAsyncStateMachine
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
		private EDBFMDNELDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7CCAA70", Offset = "0x7CC9C70", VA = "0x187CCAA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7CCB130", Offset = "0x7CCA330", VA = "0x187CCB130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool EMMOMLCGODO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
	public static bool FBNFDOFKLAL(byte[] MLJFEJHLMNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDA90", Offset = "0x7CCCC90", VA = "0x187CCDA90")]
	[AsyncStateMachine(typeof(LDIFBICHEGB))]
	public static Task<Texture2D> JPIFELPOGPJ(byte[] MLJFEJHLMNK, bool HMPDPODGKEO = false, bool BHPJAFKEOLC = false, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD8B0", Offset = "0x7CCCAB0", VA = "0x187CCD8B0")]
	[AsyncStateMachine(typeof(FLIMPHBNKHM))]
	private static Task<Texture2D> BPEPBHKBPHI(int GMGIBIFALPD, int PKHBHCLOCLA, bool MGMBMHLKADD, bool HMPDPODGKEO, bool BHPJAFKEOLC, Action<NativeArray<byte>> EJOBCELBKMC, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDA00", Offset = "0x7CCCC00", VA = "0x187CCDA00")]
	private static TextureFormat EHOMHGALHNN(bool MGMBMHLKADD)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum NHICKEPHHPH
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
internal static class ICLIOKPEJGM
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CCBD60", Offset = "0x7CCAF60", VA = "0x187CCBD60")]
	public static bool CFIHOILPMMH(byte[] DHAOEHNLNON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CCBDA0", Offset = "0x7CCAFA0", VA = "0x187CCBDA0")]
	public static void DHPECDMMNFL(byte[] DHAOEHNLNON, [Out] int GMGIBIFALPD, [Out] int PKHBHCLOCLA, [Out] NHICKEPHHPH HPCBECKKHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC2B0", Offset = "0x7CCB4B0", VA = "0x187CCC2B0")]
	private static uint PENOBMEEOOO(byte[] DHAOEHNLNON, int CAECICLJFEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC0B0", Offset = "0x7CCB2B0", VA = "0x187CCC0B0")]
	private static ulong FEFALDHHEAB(byte[] DHAOEHNLNON, int CAECICLJFEI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CDIDCIFGGJP
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA640", Offset = "0x7CC9840", VA = "0x187CCA640")]
	public static RenderTexture IJMCAJLKIHG(int GMGIBIFALPD, int PKHBHCLOCLA, int BPNBLFJDIIK, Camera KGPBHINDLND, RenderTextureMemoryless ICGHGFBBJNC = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA870", Offset = "0x7CC9A70", VA = "0x187CCA870")]
	public static void OJOLIEHABJN(RenderTexture PMHKGBLCIPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class IFAKKKMGIHN<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct MILAABADFPI : IEquatable<MILAABADFPI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId OOJHPGKHCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly NFJCNGKBGAM GKANACBFAAO;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x17BD360", Offset = "0x17BC560", VA = "0x1817BD360")]
		public MILAABADFPI(TImageId AGBHGDFILGO, NFJCNGKBGAM LDNGHLGGIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x52EC330", Offset = "0x52EB530", VA = "0x1852EC330", Slot = "4")]
		public bool Equals(IFAKKKMGIHN<TImageId>.MILAABADFPI FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x52EC220", Offset = "0x52EB420", VA = "0x1852EC220", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x52EC500", Offset = "0x52EB700", VA = "0x1852EC500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x52EC5D0", Offset = "0x52EB7D0", VA = "0x1852EC5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DAEMDDJBCNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LGILIJIJPGJ<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DAEMDDJBCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x69C6A30", Offset = "0x69C5C30", VA = "0x1869C6A30")]
		internal void LKLEFJMPDPA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct HKONKGNOIBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public MILAABADFPI cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IFAKKKMGIHN<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private NFJCNGKBGAM <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2C40", Offset = "0x4BA1E40", VA = "0x184BA2C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4BA3380", Offset = "0x4BA2580", VA = "0x184BA3380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct ONPFBBHGNOM : IAsyncStateMachine
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
		public NFJCNGKBGAM textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IFAKKKMGIHN<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x55436E0", Offset = "0x55428E0", VA = "0x1855436E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x55444E0", Offset = "0x55436E0", VA = "0x1855444E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct CGPDOOGIGBN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x653BAE0", Offset = "0x653ACE0", VA = "0x18653BAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x653BEA0", Offset = "0x653B0A0", VA = "0x18653BEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int BFHJKBEDIPM = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim CBCKHDPBPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? JOLJEICNFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, NFJCNGKBGAM, CancellationToken, Task<Texture2D>>? NGFINLJDHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? AEGILFONDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly KACGMINCHLD<MILAABADFPI, Texture2D> CNFNCINOEDC;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4C769A0", Offset = "0x4C75BA0", VA = "0x184C769A0")]
	public IFAKKKMGIHN(Func<TImageId, CancellationToken, Task<byte[]>> AOBKGKKADOP, [Optional] Func<TImageId, string>? EDPPBCHDNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4C765F0", Offset = "0x4C757F0", VA = "0x184C765F0")]
	public IFAKKKMGIHN(Func<TImageId, NFJCNGKBGAM, CancellationToken, Task<Texture2D>> JFEAMBMGGFG, [Optional] Func<TImageId, string>? EDPPBCHDNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4C767F0", Offset = "0x4C759F0", VA = "0x184C767F0")]
	private IFAKKKMGIHN(Func<TImageId, CancellationToken, Task<byte[]>>? AOBKGKKADOP, Func<TImageId, NFJCNGKBGAM, CancellationToken, Task<Texture2D>>? JFEAMBMGGFG, Func<TImageId, string>? EDPPBCHDNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4C76260", Offset = "0x4C75460", VA = "0x184C76260")]
	public PAACHOBIIFN<Texture2D> OGCDKJLAAHO(TImageId OJMKBCNGCEA, NFJCNGKBGAM COBMDBOLEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4C757E0", Offset = "0x4C749E0", VA = "0x184C757E0")]
	public void FANGCAGBFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4C75740", Offset = "0x4C74940", VA = "0x184C75740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4C75A10", Offset = "0x4C74C10", VA = "0x184C75A10")]
	[AsyncStateMachine(typeof(IFAKKKMGIHN<>.HKONKGNOIBI))]
	private Task<Texture2D> HBGEJNPCDCO(MILAABADFPI AAHHAPOLENF, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4C75CB0", Offset = "0x4C74EB0", VA = "0x184C75CB0")]
	[AsyncStateMachine(typeof(IFAKKKMGIHN<>.ONPFBBHGNOM))]
	private Task<Texture2D> JCALOPCCPOA(byte[] MLJFEJHLMNK, NFJCNGKBGAM COBMDBOLEJL, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C76030", Offset = "0x4C75230", VA = "0x184C76030")]
	private void OFDDJPEBONG(Texture2D BEFHHDCIDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C75F70", Offset = "0x4C75170", VA = "0x184C75F70")]
	private bool KIILCBEOCGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C75F80", Offset = "0x4C75180", VA = "0x184C75F80")]
	private bool NOOOMFOOEKB(byte[] MLJFEJHLMNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4C75920", Offset = "0x4C74B20", VA = "0x184C75920")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(IFAKKKMGIHN<>.CGPDOOGIGBN))]
	internal static Task GPJPOAHBOMA(IDisposable DFNFKIOLFOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum NFJCNGKBGAM : byte
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
