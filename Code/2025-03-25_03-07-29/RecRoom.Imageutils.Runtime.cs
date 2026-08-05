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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x7848F40", Offset = "0x7848340", VA = "0x187848F40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
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
		[Cpp2IlInjected.Address(RVA = "0x7846940", Offset = "0x7845D40", VA = "0x187846940")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PNHDLNDOCBL
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
			[Cpp2IlInjected.Address(RVA = "0x78496C0", Offset = "0x7848AC0", VA = "0x1878496C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78496B0", Offset = "0x7848AB0", VA = "0x1878496B0")]
		public Resolution(uint JFJPEDLJOKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC693D0", Offset = "0xC687D0", VA = "0x180C693D0")]
		public Resolution(uint JFJPEDLJOKC, uint MJINJIJLGDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78495C0", Offset = "0x78489C0", VA = "0x1878495C0")]
		public static Resolution KMKOBGLALNC(Resolution[] PJIJGMDDLKH, Resolution GKNAHDOAIDD, int MIMAGHGMOIA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class LNAIBJJJLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution EIANGHNHNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? KHPFJAEBFCE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint JFJPEDLJOKC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7847AC0", Offset = "0x7846EC0", VA = "0x187847AC0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution LHFHBGBLCOP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7847AD0", Offset = "0x7846ED0", VA = "0x187847AD0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD3FD70", Offset = "0xD3F170", VA = "0x180D3FD70")]
		public LNAIBJJJLIP(Resolution EIANGHNHNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7847E20", Offset = "0x7847220", VA = "0x187847E20")]
		private static Resolution NHIIAMFIALI(Resolution KHPFJAEBFCE, GFJIDAJHLOL MAFHFKFAFLF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class IKGMNFDAKFM
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution IOPOBKFCGKB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution GJDPADLJALL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution OLDKPJMBELJ;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution MHDNJOPJKHA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution EGFJDLOEJCO;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution PCCGCBDAPEI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] JBJCNDLAFJL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ACLFCDEKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution EGHGFJNIGHN;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution ILLOOMHONNA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution EMOAPMDOMKD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution DEKJDLELPNF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution EFOOOOOHLNL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] JBJCNDLAFJL;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7845C80", Offset = "0x7845080", VA = "0x187845C80")]
		public static Resolution NIHKAEODOFI(uint HDGBCJPFMHH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution MCFAFOBAMMD;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class CEPIBOPBFGH
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7846660", Offset = "0x7845A60", VA = "0x187846660")]
	public static bool DMGPAHNCGHJ(byte[] AMHCLKHIFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7846730", Offset = "0x7845B30", VA = "0x187846730")]
	public static bool MFDHFCMPPHK(byte[] AMHCLKHIFKH, [Out] int HDGBCJPFMHH, [Out] int KDOANPLAAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x78466A0", Offset = "0x7845AA0", VA = "0x1878466A0")]
	private static int KBMLBKDONNH(byte[] AMHCLKHIFKH, int FOGJBEMBBDP, [Out] ushort FNEDADLPOJM)
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
		public enum IMBOOBBLPPK : byte
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
		private class FLCPDNAEOLI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string MPGDCPPMNJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D MKNHMBEOIMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IMBOOBBLPPK POHJGLCIFNP;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7847250", Offset = "0x7846650", VA = "0x187847250")]
			public FLCPDNAEOLI(string MPGDCPPMNJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1859E50", Offset = "0x1859250", VA = "0x181859E50")]
			public FLCPDNAEOLI(string MPGDCPPMNJN, Texture2D HLPGJNCKNML, IMBOOBBLPPK KLPLFBHJMAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7847210", Offset = "0x7846610", VA = "0x187847210", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AJFDCOEPOLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IMBOOBBLPPK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public AJFDCOEPOLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7845FA0", Offset = "0x78453A0", VA = "0x187845FA0")]
			internal void AGNHDEJEDEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JBAMDJAEFDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public JBAMDJAEFDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7847720", Offset = "0x7846B20", VA = "0x187847720")]
			internal HLHFKBPCBEC KNJOFIJBDEK(Texture2D t2d)
			{
				return default(HLHFKBPCBEC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DONBFLDJIBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public DONBFLDJIBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7847090", Offset = "0x7846490", VA = "0x187847090")]
			internal void EMIGHIHJGOJ()
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
		private COLCOEKKCIF<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FLCPDNAEOLI _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private COLCOEKKCIF<HLHFKBPCBEC> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private COLCOEKKCIF<HLHFKBPCBEC> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBD2B40", Offset = "0xBD1F40", VA = "0x180BD2B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x991DF0", Offset = "0x9911F0", VA = "0x180991DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private FLCPDNAEOLI memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7848E90", Offset = "0x7848290", VA = "0x187848E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7848DC0", Offset = "0x78481C0", VA = "0x187848DC0")]
		public ManagedTexture(string MPGDCPPMNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7848E20", Offset = "0x7848220", VA = "0x187848E20")]
		public ManagedTexture(string MPGDCPPMNJN, bool PNBBCHANKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7847FA0", Offset = "0x78473A0", VA = "0x187847FA0")]
		public void AKNCEHKJJGM(RenderTexture KPKGHBNLDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78486D0", Offset = "0x7847AD0", VA = "0x1878486D0")]
		public COLCOEKKCIF<Texture2D> CNPLPBLPHDP(IMBOOBBLPPK KLPLFBHJMAL, bool GEPLGKNONJH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7848530", Offset = "0x7847930", VA = "0x187848530")]
		public COLCOEKKCIF<HLHFKBPCBEC> CBMKFNKJGIN(bool GEPLGKNONJH = false, int OBHEGDDHIGH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7848A70", Offset = "0x7847E70", VA = "0x187848A70")]
		public COLCOEKKCIF<HLHFKBPCBEC> NHOGKALOIOF(bool GEPLGKNONJH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7847FE0", Offset = "0x78473E0", VA = "0x187847FE0")]
		private static COLCOEKKCIF<Texture2D> BJKPLOOOPOB(string MPGDCPPMNJN, RenderTexture KPKGHBNLDHA, Texture2D EAKOIBPJDNG, bool GEPLGKNONJH, IMBOOBBLPPK EDNAEEAAGNI = IMBOOBBLPPK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78489D0", Offset = "0x7847DD0", VA = "0x1878489D0")]
		public void IBBCAPOEOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78489C0", Offset = "0x7847DC0", VA = "0x1878489C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7848D60", Offset = "0x7848160", VA = "0x187848D60")]
		[CompilerGenerated]
		private COLCOEKKCIF<byte[]> PLHMPNKFGMO(Texture2D FDADMOHHDOP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LEIHOHGCBOK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct EIEFJGIJNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7847110", Offset = "0x7846510", VA = "0x187847110")]
		public unsafe static extern void DFCKKPBJGMI(void* DEPJIMINBIN, void* DHFBCDKDEBC, bool ENDFABMDIEI, bool HCABMPNJGML, bool LCJLPFNAHEJ, [Out] int HDGBCJPFMHH, [Out] int KDOANPLAAOB, [Out] bool PAIPGINEFAN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PCOEOCBKICE
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
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PCOEOCBKICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7848FC0", Offset = "0x78483C0", VA = "0x187848FC0")]
		internal void CDHPDPOPOGJ(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct HIMPDGOPMDE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x78472A0", Offset = "0x78466A0", VA = "0x1878472A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78474C0", Offset = "0x78468C0", VA = "0x1878474C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AAAFMEMIPJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public AAAFMEMIPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7845C40", Offset = "0x7845040", VA = "0x187845C40")]
		internal void NCAMHHBGCDE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DAAJEIEGOOD : IAsyncStateMachine
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
		private AAAFMEMIPJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7846960", Offset = "0x7845D60", VA = "0x187846960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7847020", Offset = "0x7846420", VA = "0x187847020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool EGHHLDLJBCC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
	public static bool ADJPDNKCFBC(byte[] IFIPPOMKFLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x78478B0", Offset = "0x7846CB0", VA = "0x1878478B0")]
	[AsyncStateMachine(typeof(HIMPDGOPMDE))]
	public static Task<Texture2D> AJNGLDFDOAB(byte[] IFIPPOMKFLC, bool JFGKODPDDFM = false, bool JCGHCHPIBHG = false, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7847760", Offset = "0x7846B60", VA = "0x187847760")]
	[AsyncStateMachine(typeof(DAAJEIEGOOD))]
	private static Task<Texture2D> AHEKNDPEAKL(int HDGBCJPFMHH, int KDOANPLAAOB, bool ELMJLAFDOJC, bool JFGKODPDDFM, bool JCGHCHPIBHG, Action<NativeArray<byte>> MEAEBNCMPOO, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x78479F0", Offset = "0x7846DF0", VA = "0x1878479F0")]
	private static TextureFormat HHOOMEOCNFM(bool ELMJLAFDOJC)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum OKBADOCLBJK
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
internal static class CBEABLBIFPO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7845FE0", Offset = "0x78453E0", VA = "0x187845FE0")]
	public static bool CMIAJJOFPFG(byte[] AMHCLKHIFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7846350", Offset = "0x7845750", VA = "0x187846350")]
	public static void PKCEMLEJOFL(byte[] AMHCLKHIFKH, [Out] int HDGBCJPFMHH, [Out] int KDOANPLAAOB, [Out] OKBADOCLBJK LMHNLPFPEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7846220", Offset = "0x7845620", VA = "0x187846220")]
	private static uint MOJKLAKDONN(byte[] AMHCLKHIFKH, int LLNIGMDIFON)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7846020", Offset = "0x7845420", VA = "0x187846020")]
	private static ulong GDMDAMFGELA(byte[] AMHCLKHIFKH, int LLNIGMDIFON)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PNNPCGIOGLE
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7849330", Offset = "0x7848730", VA = "0x187849330")]
	public static RenderTexture DHPIMNLGCOP(int HDGBCJPFMHH, int KDOANPLAAOB, int BEPOPFMNGII, Camera HJODJFKAMBL, RenderTextureMemoryless DKNAAEBGOPC = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7849560", Offset = "0x7848960", VA = "0x187849560")]
	public static void JNPHMPHOCFI(RenderTexture KPKGHBNLDHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class NLLKLHGIKBA<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct PMNCBJPDKMA : IEquatable<PMNCBJPDKMA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId OELAAKMJIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly DGEPJDIEIFG GAHDGEAOFLK;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1681620", Offset = "0x1680A20", VA = "0x181681620")]
		public PMNCBJPDKMA(TImageId MCBJECJLDOM, DGEPJDIEIFG MDFKKKALBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x52F5330", Offset = "0x52F4730", VA = "0x1852F5330", Slot = "4")]
		public bool Equals(NLLKLHGIKBA<TImageId>.PMNCBJPDKMA JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x52F5420", Offset = "0x52F4820", VA = "0x1852F5420", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x52F56A0", Offset = "0x52F4AA0", VA = "0x1852F56A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x52F5770", Offset = "0x52F4B70", VA = "0x1852F5770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EHIGBEDIBHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IAMMFEOALJI<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EHIGBEDIBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x427E8B0", Offset = "0x427DCB0", VA = "0x18427E8B0")]
		internal void DGOPNGPILHI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct BFIKFOHICCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PMNCBJPDKMA cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NLLKLHGIKBA<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private DGEPJDIEIFG <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5C703B0", Offset = "0x5C6F7B0", VA = "0x185C703B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5C71250", Offset = "0x5C70650", VA = "0x185C71250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct KNBBJKHKBCH : IAsyncStateMachine
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
		public DGEPJDIEIFG textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NLLKLHGIKBA<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4CDFBC0", Offset = "0x4CDEFC0", VA = "0x184CDFBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4CE0330", Offset = "0x4CDF730", VA = "0x184CE0330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct DKDBFEKIMOP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x65EE3D0", Offset = "0x65ED7D0", VA = "0x1865EE3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x65EE610", Offset = "0x65EDA10", VA = "0x1865EE610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int JHMCGIIGJHJ = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim JLJBJIGGMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? CFOIPHCFIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, DGEPJDIEIFG, CancellationToken, Task<Texture2D>>? DHJHEMFCGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? EOCPGIIFGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PABJKCBDJJA<PMNCBJPDKMA, Texture2D> CGCACFDGOKL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x50364C0", Offset = "0x50358C0", VA = "0x1850364C0")]
	public NLLKLHGIKBA(Func<TImageId, CancellationToken, Task<byte[]>> PGELDFBFMOM, [Optional] Func<TImageId, string>? BGJBNDBDBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5036470", Offset = "0x5035870", VA = "0x185036470")]
	public NLLKLHGIKBA(Func<TImageId, DGEPJDIEIFG, CancellationToken, Task<Texture2D>> DAOLLBPHLIC, [Optional] Func<TImageId, string>? BGJBNDBDBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x50366C0", Offset = "0x5035AC0", VA = "0x1850366C0")]
	private NLLKLHGIKBA(Func<TImageId, CancellationToken, Task<byte[]>>? PGELDFBFMOM, Func<TImageId, DGEPJDIEIFG, CancellationToken, Task<Texture2D>>? DAOLLBPHLIC, Func<TImageId, string>? BGJBNDBDBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x50357E0", Offset = "0x5034BE0", VA = "0x1850357E0")]
	public FHGKGMPNNBH<Texture2D> ADMLOKEGAIO(TImageId DMKFJGJCDJM, DGEPJDIEIFG KADJMFOKKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x50359D0", Offset = "0x5034DD0", VA = "0x1850359D0")]
	public void AMMAAKGPILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5035A20", Offset = "0x5034E20", VA = "0x185035A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5035AD0", Offset = "0x5034ED0", VA = "0x185035AD0")]
	[AsyncStateMachine(typeof(NLLKLHGIKBA<>.BFIKFOHICCL))]
	private Task<Texture2D> IJCEAIPFNLM(PMNCBJPDKMA CKJNIFPMEBF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5035F90", Offset = "0x5035390", VA = "0x185035F90")]
	[AsyncStateMachine(typeof(NLLKLHGIKBA<>.KNBBJKHKBCH))]
	private Task<Texture2D> OLDMKCNFJNB(byte[] IFIPPOMKFLC, DGEPJDIEIFG KADJMFOKKLJ, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5035AC0", Offset = "0x5034EC0", VA = "0x185035AC0")]
	private void FLKLLOMPNBJ(Texture2D HLPGJNCKNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5035E20", Offset = "0x5035220", VA = "0x185035E20")]
	private bool OHODOEDCJCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5035D70", Offset = "0x5035170", VA = "0x185035D70")]
	private bool MPFIGJDKLIA(byte[] IFIPPOMKFLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x50360F0", Offset = "0x50354F0", VA = "0x1850360F0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(NLLKLHGIKBA<>.DKDBFEKIMOP))]
	internal static Task PAOCBMLBBOJ(IDisposable JPJFNMEINMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum DGEPJDIEIFG : byte
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
