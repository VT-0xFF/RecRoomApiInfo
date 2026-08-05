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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x833C660", Offset = "0x833B060", VA = "0x18833C660")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
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
		[Cpp2IlInjected.Address(RVA = "0x8339AD0", Offset = "0x83384D0", VA = "0x188339AD0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DNKNOHFPNFC
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
			[Cpp2IlInjected.Address(RVA = "0x833D310", Offset = "0x833BD10", VA = "0x18833D310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x833D300", Offset = "0x833BD00", VA = "0x18833D300")]
		public Resolution(uint IECENJOJFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
		public Resolution(uint IECENJOJFJH, uint OFOCBNJJIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x833D210", Offset = "0x833BC10", VA = "0x18833D210")]
		public static Resolution IIPBDKMNNFK(Resolution[] HHMKDMNANOF, Resolution FJLGAOCOHCJ, int HHHDIEJDCEF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FPGNHOJLIDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution MNPNLFEJHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? AGEFMHPEIPE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint IECENJOJFJH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8339E90", Offset = "0x8338890", VA = "0x188339E90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution JLAJGHHCDEE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x833A020", Offset = "0x8338A20", VA = "0x18833A020")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF488E0", Offset = "0xF472E0", VA = "0x180F488E0")]
		public FPGNHOJLIDP(Resolution MNPNLFEJHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8339EA0", Offset = "0x83388A0", VA = "0x188339EA0")]
		private static Resolution PACHFICDHNM(Resolution AGEFMHPEIPE, GALHFJCKMPP FCGPIGBFDJG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PIEOGJEGDLE
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution AGNMFHCFKOK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution OAABEEHONDE;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution OPGFADCNKEH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution GBDCGADLCNP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution PNAKAGIJGJF;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution OIJAOMANCBL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] JCIPFPDOGFO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class JLHBOMICFML
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OJEIIEKAEIB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution JEMMLNDJFNL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CMBDBEHPACN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution BDIFNACFECI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OEMOINIMICN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] JCIPFPDOGFO;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x833AF30", Offset = "0x8339930", VA = "0x18833AF30")]
		public static Resolution DIGODFAGJBK(uint OFMOKEHMKFL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution DDLHCGBCCOA;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GPIIEHKMELL
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x833A410", Offset = "0x8338E10", VA = "0x18833A410")]
	public static bool JJHCBEPBOPF(byte[] GPCDCFCPGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x833A450", Offset = "0x8338E50", VA = "0x18833A450")]
	public static bool LGNHLBBHOKP(byte[] GPCDCFCPGFK, [Out] int OFMOKEHMKFL, [Out] int CNPILOHIEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x833A380", Offset = "0x8338D80", VA = "0x18833A380")]
	private static int CIOAALGIAGH(byte[] GPCDCFCPGFK, int EMMDOKDGNJD, [Out] ushort HPFFOJMKCCG)
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
		public enum DAFLLMELNIB : byte
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
		private class FJFINKFCHHM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string FLBFBHGDBLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D IBEMOGNKKEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public DAFLLMELNIB KKOCIHMLKPD;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8339E00", Offset = "0x8338800", VA = "0x188339E00")]
			public FJFINKFCHHM(string FLBFBHGDBLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1C40840", Offset = "0x1C3F240", VA = "0x181C40840")]
			public FJFINKFCHHM(string FLBFBHGDBLM, Texture2D GIAGKAKEOKD, DAFLLMELNIB JFMMKEHDMPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8339DC0", Offset = "0x83387C0", VA = "0x188339DC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MFIAIMDAOBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public DAFLLMELNIB textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public MFIAIMDAOBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x833B680", Offset = "0x833A080", VA = "0x18833B680")]
			internal void AIPMANNBBCB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FMENDCAGBGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public FMENDCAGBGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8339E50", Offset = "0x8338850", VA = "0x188339E50")]
			internal MFKBPJAHJLH BFFKKLAFPBA(Texture2D t2d)
			{
				return default(MFKBPJAHJLH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KJOLMCKCJPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public KJOLMCKCJPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x833B280", Offset = "0x8339C80", VA = "0x18833B280")]
			internal void CHJGLPDNBGF()
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
		private DPMDGLGHBHJ<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FJFINKFCHHM _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DPMDGLGHBHJ<MFKBPJAHJLH> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private DPMDGLGHBHJ<MFKBPJAHJLH> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB50B70", Offset = "0xB4F570", VA = "0x180B50B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private FJFINKFCHHM memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x833C5B0", Offset = "0x833AFB0", VA = "0x18833C5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x833C4E0", Offset = "0x833AEE0", VA = "0x18833C4E0")]
		public ManagedTexture(string FLBFBHGDBLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x833C540", Offset = "0x833AF40", VA = "0x18833C540")]
		public ManagedTexture(string FLBFBHGDBLM, bool DKBFIEIFOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x833BFB0", Offset = "0x833A9B0", VA = "0x18833BFB0")]
		public void HMIBFDCAPNE(RenderTexture BAEBJICDNHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x833BCC0", Offset = "0x833A6C0", VA = "0x18833BCC0")]
		public DPMDGLGHBHJ<Texture2D> EKHDBEFNNOB(DAFLLMELNIB JFMMKEHDMPL, bool KACICMDHNEC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x833C050", Offset = "0x833AA50", VA = "0x18833C050")]
		public DPMDGLGHBHJ<MFKBPJAHJLH> KCNGOENDCJF(bool KACICMDHNEC = false, int GGFHKHKAIBH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x833C1E0", Offset = "0x833ABE0", VA = "0x18833C1E0")]
		public DPMDGLGHBHJ<MFKBPJAHJLH> MOPGGCAKILC(bool KACICMDHNEC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x833B6C0", Offset = "0x833A0C0", VA = "0x18833B6C0")]
		private static DPMDGLGHBHJ<Texture2D> DABHLOJJNAM(string FLBFBHGDBLM, RenderTexture BAEBJICDNHB, Texture2D JNNHJPCJAHG, bool KACICMDHNEC, DAFLLMELNIB DAHCIIGJBGH = DAFLLMELNIB.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x833BC10", Offset = "0x833A610", VA = "0x18833BC10")]
		public void DHAALHCEBKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x833BCB0", Offset = "0x833A6B0", VA = "0x18833BCB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x833BFF0", Offset = "0x833A9F0", VA = "0x18833BFF0")]
		[CompilerGenerated]
		private DPMDGLGHBHJ<byte[]> HPBECMLIDDC(Texture2D PLKFEMGBLEL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LMDNDFGCLAH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct FDBFNPMFMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8339CC0", Offset = "0x83386C0", VA = "0x188339CC0")]
		public unsafe static extern void KCLPPNHOFCL(void* LDMFBCDGHEB, void* ADMLFNMDFNO, bool KDPCLDIKBEF, bool CPBFDOIGNOE, bool KBNDELEONIP, [Out] int OFMOKEHMKFL, [Out] int CNPILOHIEFC, [Out] bool AMNHJJGIEFL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JHCOGIBLCPJ
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
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JHCOGIBLCPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x833AD90", Offset = "0x8339790", VA = "0x18833AD90")]
		internal void IFOCCIPEOGM(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct BANJDBHKMEM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8339840", Offset = "0x8338240", VA = "0x188339840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8339A60", Offset = "0x8338460", VA = "0x188339A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AIKFHBHFCGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AIKFHBHFCGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8339800", Offset = "0x8338200", VA = "0x188339800")]
		internal void DMLLJGIBAHM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct IHJJFAAEPPM : IAsyncStateMachine
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
		private AIKFHBHFCGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x833A660", Offset = "0x8339060", VA = "0x18833A660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x833AD20", Offset = "0x8339720", VA = "0x18833AD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool LEBFILHNBAN;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
	public static bool BFHIPBHDAMD(byte[] HCDCNNHNDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x833B300", Offset = "0x8339D00", VA = "0x18833B300")]
	[AsyncStateMachine(typeof(BANJDBHKMEM))]
	public static Task<Texture2D> EAEFPPPFHGC(byte[] HCDCNNHNDML, bool KIAJNKNDFLO = false, bool IEGCADLPABF = false, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x833B440", Offset = "0x8339E40", VA = "0x18833B440")]
	[AsyncStateMachine(typeof(IHJJFAAEPPM))]
	private static Task<Texture2D> EJEDEIBJBEE(int OFMOKEHMKFL, int CNPILOHIEFC, bool HKLHHDFHJBP, bool KIAJNKNDFLO, bool IEGCADLPABF, Action<NativeArray<byte>> GBALCCLBPCI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x833B590", Offset = "0x8339F90", VA = "0x18833B590")]
	private static TextureFormat HALAMAMEBOO(bool HKLHHDFHJBP)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum KKFCAAJEOJA
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
internal static class PFCLEGFKNND
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x833C6E0", Offset = "0x833B0E0", VA = "0x18833C6E0")]
	public static bool BELJIHHDMIN(byte[] GPCDCFCPGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x833CA50", Offset = "0x833B450", VA = "0x18833CA50")]
	public static void MBLAODFHFFL(byte[] GPCDCFCPGFK, [Out] int OFMOKEHMKFL, [Out] int CNPILOHIEFC, [Out] KKFCAAJEOJA NANAIMNHOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x833C920", Offset = "0x833B320", VA = "0x18833C920")]
	private static uint KJDPEKGKJPA(byte[] GPCDCFCPGFK, int PAEPPOFDFDK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x833C720", Offset = "0x833B120", VA = "0x18833C720")]
	private static ulong KIEDPFLPHKB(byte[] GPCDCFCPGFK, int PAEPPOFDFDK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PNEOJIOINDA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x833CF80", Offset = "0x833B980", VA = "0x18833CF80")]
	public static RenderTexture CJAHHBMOHAE(int OFMOKEHMKFL, int CNPILOHIEFC, int KPCKPNKHKME, Camera MJKCGJBIPGM, RenderTextureMemoryless DBKGLIINHBD = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x833D1B0", Offset = "0x833BBB0", VA = "0x18833D1B0")]
	public static void OMKOOLMJEGK(RenderTexture BAEBJICDNHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class FNPAAIKDKKJ<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct POJMKEPALIH : IEquatable<POJMKEPALIH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId LIEFPLADKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly LNDLKLOGEJI PGJPIKGLIFA;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1A64500", Offset = "0x1A62F00", VA = "0x181A64500")]
		public POJMKEPALIH(TImageId LNBCHJPEENA, LNDLKLOGEJI CCPNJMNBJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5B61070", Offset = "0x5B5FA70", VA = "0x185B61070", Slot = "4")]
		public bool Equals(FNPAAIKDKKJ<TImageId>.POJMKEPALIH EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5B60EF0", Offset = "0x5B5F8F0", VA = "0x185B60EF0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5B61320", Offset = "0x5B5FD20", VA = "0x185B61320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5B614C0", Offset = "0x5B5FEC0", VA = "0x185B614C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NFDKPDJPCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public GBIBCLBHEOL<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NFDKPDJPCEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x58B1C20", Offset = "0x58B0620", VA = "0x1858B1C20")]
		internal void GCMIELPMODH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct PBANMICDHFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public POJMKEPALIH cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FNPAAIKDKKJ<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private LNDLKLOGEJI <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDD40", Offset = "0x5AEC740", VA = "0x185AEDD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE3D0", Offset = "0x5AECDD0", VA = "0x185AEE3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct DKIBBNAMIMP : IAsyncStateMachine
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
		public LNDLKLOGEJI textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FNPAAIKDKKJ<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool <usePointFiltering>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool <useClampWrapMode>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x70068C0", Offset = "0x70052C0", VA = "0x1870068C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7007080", Offset = "0x7005A80", VA = "0x187007080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct MGNHBDFDMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5825240", Offset = "0x5823C40", VA = "0x185825240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5825600", Offset = "0x5824000", VA = "0x185825600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LLJOKHPAHLC = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim MCIJACPBDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? CJDFEGIMODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, LNDLKLOGEJI, CancellationToken, Task<Texture2D>>? JFCNIBCPEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? PBAOIBAFPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly JEIBALHAAGC<POJMKEPALIH, Texture2D> DFACLCDOAEM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4E51090", Offset = "0x4E4FA90", VA = "0x184E51090")]
	public FNPAAIKDKKJ(Func<TImageId, CancellationToken, Task<byte[]>> EHOPLGHJKPE, [Optional] Func<TImageId, string>? NJNKECFDNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E51060", Offset = "0x4E4FA60", VA = "0x184E51060")]
	public FNPAAIKDKKJ(Func<TImageId, LNDLKLOGEJI, CancellationToken, Task<Texture2D>> BGPLNBBPHIH, [Optional] Func<TImageId, string>? NJNKECFDNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4E51250", Offset = "0x4E4FC50", VA = "0x184E51250")]
	private FNPAAIKDKKJ(Func<TImageId, CancellationToken, Task<byte[]>>? EHOPLGHJKPE, Func<TImageId, LNDLKLOGEJI, CancellationToken, Task<Texture2D>>? BGPLNBBPHIH, Func<TImageId, string>? NJNKECFDNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4E50260", Offset = "0x4E4EC60", VA = "0x184E50260")]
	public FDLGIOOGFEJ<Texture2D> GIIOOEECEFJ(TImageId MPIMMLMNAEI, LNDLKLOGEJI BPOJNPKDIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4E50710", Offset = "0x4E4F110", VA = "0x184E50710")]
	public void IPDOGILKIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4E501B0", Offset = "0x4E4EBB0", VA = "0x184E501B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4E50B60", Offset = "0x4E4F560", VA = "0x184E50B60")]
	[AsyncStateMachine(typeof(FNPAAIKDKKJ<>.PBANMICDHFH))]
	private Task<Texture2D> PFCHNAMHNPD(POJMKEPALIH DPMAHEFJMND, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4E508A0", Offset = "0x4E4F2A0", VA = "0x184E508A0")]
	[AsyncStateMachine(typeof(FNPAAIKDKKJ<>.DKIBBNAMIMP))]
	private Task<Texture2D> MLEADAJEAPE(byte[] HCDCNNHNDML, LNDLKLOGEJI BPOJNPKDIML, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4E50A00", Offset = "0x4E4F400", VA = "0x184E50A00")]
	private void OOLCNHFJPIJ(Texture2D GIAGKAKEOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4E50250", Offset = "0x4E4EC50", VA = "0x184E50250")]
	private bool EBFLNFPECCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E50660", Offset = "0x4E4F060", VA = "0x184E50660")]
	private bool HMCNKAMKLFP(byte[] HCDCNNHNDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4E50DB0", Offset = "0x4E4F7B0", VA = "0x184E50DB0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(FNPAAIKDKKJ<>.MGNHBDFDMIN))]
	internal static Task PLDPEBNGKHD(IDisposable MOAFMMNDKEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum LNDLKLOGEJI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	CompressTexture = 4,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	UseNearestTextureFiltering = 8,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	UseClampWrapMode = 0x10
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
