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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x80F4300", Offset = "0x80F3100", VA = "0x1880F4300")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x80F2300", Offset = "0x80F1100", VA = "0x1880F2300")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FHGLKJEAPHA
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
			[Cpp2IlInjected.Address(RVA = "0x80F52F0", Offset = "0x80F40F0", VA = "0x1880F52F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80F52E0", Offset = "0x80F40E0", VA = "0x1880F52E0")]
		public Resolution(uint DHOMBGCEEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
		public Resolution(uint DHOMBGCEEAK, uint EDBCCDDDLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80F51F0", Offset = "0x80F3FF0", VA = "0x1880F51F0")]
		public static Resolution KPBAABMIMML(Resolution[] LHBNHKOPIFM, Resolution DLAFDMCOAEE, int OCDJNLOOGFM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GCCOBMPLEEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution JEPPGIIDIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? BDFAJOHKLAM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint DHOMBGCEEAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x80F2A10", Offset = "0x80F1810", VA = "0x1880F2A10")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution MBDAIDGLPEG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x80F2530", Offset = "0x80F1330", VA = "0x1880F2530")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF175F0", Offset = "0xF163F0", VA = "0x180F175F0")]
		public GCCOBMPLEEO(Resolution JEPPGIIDIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80F2890", Offset = "0x80F1690", VA = "0x1880F2890")]
		private static Resolution IDJNLNBDPOL(Resolution BDFAJOHKLAM, EOANFGHOMLK LCABEKFKJCA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class BEOPFOHJEPF
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution OEIOCHMBCEA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution GKEEBPGLELJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution MNFMGAIPAEP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution BCBNMACIDFK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution CGMAMKBOHBD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution DIPOOECGDJL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] MAMMHGCOHNJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class OFCMCKDPFHH
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution NJPCFGLHAIE;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DGMIOFHMKCN;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution OMCBCFCMJLH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution EINFGFENEND;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution LNLMKJDCMLD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] MAMMHGCOHNJ;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80F4380", Offset = "0x80F3180", VA = "0x1880F4380")]
		public static Resolution OKPCEAONNCI(uint GLIFAAMMBIN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution EPOILJBGPNG;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class PNHCCONIOAF
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x80F51B0", Offset = "0x80F3FB0", VA = "0x1880F51B0")]
	public static bool LAPFIDELJKH(byte[] BOIPFNOKGBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x80F4FA0", Offset = "0x80F3DA0", VA = "0x1880F4FA0")]
	public static bool IGLLOGMMCEM(byte[] BOIPFNOKGBJ, [Out] int GLIFAAMMBIN, [Out] int AAILBPBKGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80F4F10", Offset = "0x80F3D10", VA = "0x1880F4F10")]
	private static int ALICADBJCJI(byte[] BOIPFNOKGBJ, int HBNCFIPENFO, [Out] ushort KMIHBJCAEEI)
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
		public enum ODEELHNDNLA : byte
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
		private class PBINNMBGDKP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string GGDFKFACHGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D LCGMKOCLFJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public ODEELHNDNLA EDKPACLDONL;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x80F4790", Offset = "0x80F3590", VA = "0x1880F4790")]
			public PBINNMBGDKP(string GGDFKFACHGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1BC9170", Offset = "0x1BC7F70", VA = "0x181BC9170")]
			public PBINNMBGDKP(string GGDFKFACHGG, Texture2D HINEJAGCAOK, ODEELHNDNLA LKPPEAPAOJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x80F4750", Offset = "0x80F3550", VA = "0x1880F4750", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MOGELEADFKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public ODEELHNDNLA textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public MOGELEADFKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x80F3310", Offset = "0x80F2110", VA = "0x1880F3310")]
			internal void ECLFDHIBLGA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GAMKGLIAMAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public GAMKGLIAMAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x80F24F0", Offset = "0x80F12F0", VA = "0x1880F24F0")]
			internal KLOAFGMCNLB HJCCHIFDMIK(Texture2D t2d)
			{
				return default(KLOAFGMCNLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OMCALDPGKJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public OMCALDPGKJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x80F46D0", Offset = "0x80F34D0", VA = "0x1880F46D0")]
			internal void MDJIJADMAOC()
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
		private CEBCBDBEPBJ<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PBINNMBGDKP _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CEBCBDBEPBJ<KLOAFGMCNLB> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private CEBCBDBEPBJ<KLOAFGMCNLB> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB2CDD0", Offset = "0xB2BBD0", VA = "0x180B2CDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private PBINNMBGDKP memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x80F4250", Offset = "0x80F3050", VA = "0x1880F4250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80F4180", Offset = "0x80F2F80", VA = "0x1880F4180")]
		public ManagedTexture(string GGDFKFACHGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80F41E0", Offset = "0x80F2FE0", VA = "0x1880F41E0")]
		public ManagedTexture(string GGDFKFACHGG, bool ANMIGAJDPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80F38B0", Offset = "0x80F26B0", VA = "0x1880F38B0")]
		public void EGJMANOFIOF(RenderTexture IEEHJNEMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80F3E90", Offset = "0x80F2C90", VA = "0x1880F3E90")]
		public CEBCBDBEPBJ<Texture2D> ONNALKNLCMG(ODEELHNDNLA LKPPEAPAOJM, bool OPGDOPHAHNH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80F3C50", Offset = "0x80F2A50", VA = "0x1880F3C50")]
		public CEBCBDBEPBJ<KLOAFGMCNLB> IBPKCNEAELL(bool OPGDOPHAHNH = false, int ANGHBHJBJLC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80F38F0", Offset = "0x80F26F0", VA = "0x1880F38F0")]
		public CEBCBDBEPBJ<KLOAFGMCNLB> FLCLAPBBAMK(bool OPGDOPHAHNH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80F3350", Offset = "0x80F2150", VA = "0x1880F3350")]
		private static CEBCBDBEPBJ<Texture2D> CEKEAAICAMN(string GGDFKFACHGG, RenderTexture IEEHJNEMLJL, Texture2D DOEPNKLLNNJ, bool OPGDOPHAHNH, ODEELHNDNLA BCHNIEHJGII = ODEELHNDNLA.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80F3DF0", Offset = "0x80F2BF0", VA = "0x1880F3DF0")]
		public void NPIMCJBMFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80F38A0", Offset = "0x80F26A0", VA = "0x1880F38A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80F3BF0", Offset = "0x80F29F0", VA = "0x1880F3BF0")]
		[CompilerGenerated]
		private CEBCBDBEPBJ<byte[]> GAHFIHDCABL(Texture2D JBGEAMCOBEP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JCNPJMOLBDJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct GCJMOPDFILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80F2A20", Offset = "0x80F1820", VA = "0x1880F2A20")]
		public unsafe static extern void LKNBCBCCNLI(void* FNELBCJELMF, void* KDLKIOAIFBA, bool IFLGHLIODPO, bool CHCMBLNAPFL, bool OHJPIPMPMON, [Out] int GLIFAAMMBIN, [Out] int AAILBPBKGGD, [Out] bool DEGGILJNOBO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LHCFPGCPCKI
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LHCFPGCPCKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80F3170", Offset = "0x80F1F70", VA = "0x1880F3170")]
		internal void MJOGPNIFGMJ(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct CKMDCDKNLEF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80F2070", Offset = "0x80F0E70", VA = "0x1880F2070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80F2290", Offset = "0x80F1090", VA = "0x1880F2290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KOIKMIPGJNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KOIKMIPGJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80F3130", Offset = "0x80F1F30", VA = "0x1880F3130")]
		internal void PLNIKJGDHLL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PFFEGLHOKDD : IAsyncStateMachine
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
		private KOIKMIPGJNB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80F47E0", Offset = "0x80F35E0", VA = "0x1880F47E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x80F4EA0", Offset = "0x80F3CA0", VA = "0x1880F4EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool CDKLKMEPPPE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
	public static bool EHMNPMLCCOH(byte[] DFPILHDHBNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80F2FA0", Offset = "0x80F1DA0", VA = "0x1880F2FA0")]
	[AsyncStateMachine(typeof(CKMDCDKNLEF))]
	public static Task<Texture2D> OEBPFKHEPLJ(byte[] DFPILHDHBNK, bool NIDBNGBIDFH = false, bool IADGCCLOCOD = false, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80F2E50", Offset = "0x80F1C50", VA = "0x1880F2E50")]
	[AsyncStateMachine(typeof(PFFEGLHOKDD))]
	private static Task<Texture2D> IGNBPCPDCFL(int GLIFAAMMBIN, int AAILBPBKGGD, bool MIECMDNDHPD, bool NIDBNGBIDFH, bool IADGCCLOCOD, Action<NativeArray<byte>> OMNOFEJKJGF, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x80F2DB0", Offset = "0x80F1BB0", VA = "0x1880F2DB0")]
	private static TextureFormat HFBDBECNGJP(bool MIECMDNDHPD)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum CAKAEOHOPOB
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
internal static class CDPCPCLCJHH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80F19F0", Offset = "0x80F07F0", VA = "0x1880F19F0")]
	public static bool CPODBBPKIGO(byte[] BOIPFNOKGBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80F1A30", Offset = "0x80F0830", VA = "0x1880F1A30")]
	public static void DLBBMMCBKLO(byte[] BOIPFNOKGBJ, [Out] int GLIFAAMMBIN, [Out] int AAILBPBKGGD, [Out] CAKAEOHOPOB PEIENLIDFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80F1F40", Offset = "0x80F0D40", VA = "0x1880F1F40")]
	private static uint LJLAAMJBDBD(byte[] BOIPFNOKGBJ, int DKBLEPBOJIC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80F1D40", Offset = "0x80F0B40", VA = "0x1880F1D40")]
	private static ulong FHLHJKMKEBC(byte[] BOIPFNOKGBJ, int DKBLEPBOJIC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class GLFAJLCDLCK
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80F2B20", Offset = "0x80F1920", VA = "0x1880F2B20")]
	public static RenderTexture FOKNAHENOAG(int GLIFAAMMBIN, int AAILBPBKGGD, int EAJIAOCDNJN, Camera NODAPINLHKL, RenderTextureMemoryless IHKHNBHGONP = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80F2D50", Offset = "0x80F1B50", VA = "0x1880F2D50")]
	public static void LPJMKAKOJIN(RenderTexture IEEHJNEMLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class CPOFNKBEPEN<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct GABMKFMIDDH : IEquatable<GABMKFMIDDH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId MCABOBLDEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly KIIEBBGCPNL AEIHALPJBKH;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x19D5B50", Offset = "0x19D4950", VA = "0x1819D5B50")]
		public GABMKFMIDDH(TImageId MAHBBBBCDEL, KIIEBBGCPNL EFCLIEKAFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4D70450", Offset = "0x4D6F250", VA = "0x184D70450", Slot = "4")]
		public bool Equals(CPOFNKBEPEN<TImageId>.GABMKFMIDDH LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4D70340", Offset = "0x4D6F140", VA = "0x184D70340", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4D70760", Offset = "0x4D6F560", VA = "0x184D70760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4D709D0", Offset = "0x4D6F7D0", VA = "0x184D709D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BDGFLMMHADM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BFMFPOLFIAF<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BDGFLMMHADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6250940", Offset = "0x624F740", VA = "0x186250940")]
		internal void DKJIPOJHMCA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct NLFNBOGLEOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GABMKFMIDDH cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CPOFNKBEPEN<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private KIIEBBGCPNL <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x570A250", Offset = "0x5709050", VA = "0x18570A250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x570B070", Offset = "0x5709E70", VA = "0x18570B070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct NFPBANNFMEE : IAsyncStateMachine
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
		public KIIEBBGCPNL textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CPOFNKBEPEN<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x56E0830", Offset = "0x56DF630", VA = "0x1856E0830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x56E1680", Offset = "0x56E0480", VA = "0x1856E1680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct DCAJODFGMBC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6DC5980", Offset = "0x6DC4780", VA = "0x186DC5980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5D40", Offset = "0x6DC4B40", VA = "0x186DC5D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int PKKOJDHMDDM = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim BNODKKAAGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? NGGKINJEGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, KIIEBBGCPNL, CancellationToken, Task<Texture2D>>? LNGFOJMNPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? HPGEABLDKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OKFFMCIBPAN<GABMKFMIDDH, Texture2D> NFDPADLKIIN;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69BB4A0", Offset = "0x69BA2A0", VA = "0x1869BB4A0")]
	public CPOFNKBEPEN(Func<TImageId, CancellationToken, Task<byte[]>> IKIBOKKFLPK, [Optional] Func<TImageId, string>? JFJFEEJMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69BB470", Offset = "0x69BA270", VA = "0x1869BB470")]
	public CPOFNKBEPEN(Func<TImageId, KIIEBBGCPNL, CancellationToken, Task<Texture2D>> OIEMEMBLIIB, [Optional] Func<TImageId, string>? JFJFEEJMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69BB2E0", Offset = "0x69BA0E0", VA = "0x1869BB2E0")]
	private CPOFNKBEPEN(Func<TImageId, CancellationToken, Task<byte[]>>? IKIBOKKFLPK, Func<TImageId, KIIEBBGCPNL, CancellationToken, Task<Texture2D>>? OIEMEMBLIIB, Func<TImageId, string>? JFJFEEJMOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69BADA0", Offset = "0x69B9BA0", VA = "0x1869BADA0")]
	public NONKHMPPJIB<Texture2D> PHAEBEKFBAF(TImageId EACKIKMAMBC, KIIEBBGCPNL CENHIJOLOHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69BA350", Offset = "0x69B9150", VA = "0x1869BA350")]
	public void FGIKEBEANOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69BA2B0", Offset = "0x69B90B0", VA = "0x1869BA2B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69BA4D0", Offset = "0x69B92D0", VA = "0x1869BA4D0")]
	[AsyncStateMachine(typeof(CPOFNKBEPEN<>.NLFNBOGLEOA))]
	private Task<Texture2D> GCOBMPHGDJL(GABMKFMIDDH ANEBGMAHJJK, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69BA790", Offset = "0x69B9590", VA = "0x1869BA790")]
	[AsyncStateMachine(typeof(CPOFNKBEPEN<>.NFPBANNFMEE))]
	private Task<Texture2D> HBDGBBPBAKG(byte[] DFPILHDHBNK, KIIEBBGCPNL CENHIJOLOHJ, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69BA8F0", Offset = "0x69B96F0", VA = "0x1869BA8F0")]
	private void IGKFKIAEKIK(Texture2D HINEJAGCAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69BA2A0", Offset = "0x69B90A0", VA = "0x1869BA2A0")]
	private bool DKMKHFICAHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69BAAE0", Offset = "0x69B98E0", VA = "0x1869BAAE0")]
	private bool NENADLOKNEN(byte[] DFPILHDHBNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69BA900", Offset = "0x69B9700", VA = "0x1869BA900")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(CPOFNKBEPEN<>.DCAJODFGMBC))]
	internal static Task KCKMKBPDFNI(IDisposable IKJBDAFJFKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum KIIEBBGCPNL : byte
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
