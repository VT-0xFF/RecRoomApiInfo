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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C00", Offset = "0x7FD8400", VA = "0x187FD9C00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD6990", Offset = "0x7FD5190", VA = "0x187FD6990")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JDCOCIDLBHC
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
			[Cpp2IlInjected.Address(RVA = "0x7FDA0A0", Offset = "0x7FD88A0", VA = "0x187FDA0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA090", Offset = "0x7FD8890", VA = "0x187FDA090")]
		public Resolution(uint BDGPJOKJNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
		public Resolution(uint BDGPJOKJNIL, uint HDAFCDJNHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9FA0", Offset = "0x7FD87A0", VA = "0x187FD9FA0")]
		public static Resolution IKMIEIAGBNM(Resolution[] OJJIDCCJBBN, Resolution PMHIACBHCIG, int HHIKJJFAJNC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class LJAMPNBJGMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution ICEPFLEKLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? CAMPGIDLHBO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint BDGPJOKJNIL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7FD8230", Offset = "0x7FD6A30", VA = "0x187FD8230")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution KHHECMFFJPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7FD83C0", Offset = "0x7FD6BC0", VA = "0x187FD83C0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xE69310", Offset = "0xE67B10", VA = "0x180E69310")]
		public LJAMPNBJGMC(Resolution ICEPFLEKLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8240", Offset = "0x7FD6A40", VA = "0x187FD8240")]
		private static Resolution DDGFKCHDEHB(Resolution CAMPGIDLHBO, PMOBJAHCFJI IFJJGMMBAJC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class JNLBPIJPOGI
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution PJLFDCEDEOM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution PLNPIMGOMPD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution KAJEPMLDKCL;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution ABGICHDACPG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution CCPEJLCOAFA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution DHLJDBNPOEH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] CHEJKBKBABP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class KONOPIMEPNO
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution BPNEOKPGANH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution CEJMOJHADIL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CEJLBKINHLG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution EOPFEPDJHMJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution ALJNHGJMJLA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] CHEJKBKBABP;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7ED0", Offset = "0x7FD66D0", VA = "0x187FD7ED0")]
		public static Resolution ANEJINOLMLP(uint GPMLECINMDG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution NDJKOJCIFMN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class PDNMPNHDFAI
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C80", Offset = "0x7FD8480", VA = "0x187FD9C80")]
	public static bool ECFGONGODCE(byte[] IMINNNCPCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9CC0", Offset = "0x7FD84C0", VA = "0x187FD9CC0")]
	public static bool GOOEHFNCEOP(byte[] IMINNNCPCJF, [Out] int GPMLECINMDG, [Out] int DMFNFGGJFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9ED0", Offset = "0x7FD86D0", VA = "0x187FD9ED0")]
	private static int GPIHPEKBFHJ(byte[] IMINNNCPCJF, int COEFDMIBPJJ, [Out] ushort PAJEJNGGGDB)
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
		public enum BNPLLGOPGHK : byte
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
		private class HMILKEGOELD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string HPANEBBHGAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D IKEIPNLMNGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public BNPLLGOPGHK MKGELOJKJOF;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7FD7340", Offset = "0x7FD5B40", VA = "0x187FD7340")]
			public HMILKEGOELD(string HPANEBBHGAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1AA4CD0", Offset = "0x1AA34D0", VA = "0x181AA4CD0")]
			public HMILKEGOELD(string HPANEBBHGAC, Texture2D AILALHOICPD, BNPLLGOPGHK CBIKMOFHGEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7FD7300", Offset = "0x7FD5B00", VA = "0x187FD7300", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class KPDHCLNCBND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public BNPLLGOPGHK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public KPDHCLNCBND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7FD81F0", Offset = "0x7FD69F0", VA = "0x187FD81F0")]
			internal void IGAJIIACIFH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class PGJACAFDBFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public PGJACAFDBFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9F60", Offset = "0x7FD8760", VA = "0x187FD9F60")]
			internal PBNKDKNJHNM ANJOLKKGJLN(Texture2D t2d)
			{
				return default(PBNKDKNJHNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DMFBMJLEAAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public DMFBMJLEAAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7FD69B0", Offset = "0x7FD51B0", VA = "0x187FD69B0")]
			internal void FJLCJIFGPJI()
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
		private BFIFKPBFBML<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HMILKEGOELD _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private BFIFKPBFBML<PBNKDKNJHNM> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private BFIFKPBFBML<PBNKDKNJHNM> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private HMILKEGOELD memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9B10", Offset = "0x7FD8310", VA = "0x187FD9B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9A40", Offset = "0x7FD8240", VA = "0x187FD9A40")]
		public ManagedTexture(string HPANEBBHGAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9AA0", Offset = "0x7FD82A0", VA = "0x187FD9AA0")]
		public ManagedTexture(string HPANEBBHGAC, bool NAAINLPFGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8FC0", Offset = "0x7FD77C0", VA = "0x187FD8FC0")]
		public void DEBOLDCNFFL(RenderTexture OIIOPEDHLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9750", Offset = "0x7FD7F50", VA = "0x187FD9750")]
		public BFIFKPBFBML<Texture2D> NBCJLBLJHKI(BNPLLGOPGHK CBIKMOFHGEC, bool DDEDAPALCGM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD95C0", Offset = "0x7FD7DC0", VA = "0x187FD95C0")]
		public BFIFKPBFBML<PBNKDKNJHNM> MKOMLOOCAKC(bool DDEDAPALCGM = false, int IBNFGGAEDCM = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8CD0", Offset = "0x7FD74D0", VA = "0x187FD8CD0")]
		public BFIFKPBFBML<PBNKDKNJHNM> CKCHHPNNKLN(bool DDEDAPALCGM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9010", Offset = "0x7FD7810", VA = "0x187FD9010")]
		private static BFIFKPBFBML<Texture2D> FICMCNIFHMO(string HPANEBBHGAC, RenderTexture OIIOPEDHLGG, Texture2D GLCFBENDEEA, bool DDEDAPALCGM, BNPLLGOPGHK HBPINLCGMHB = BNPLLGOPGHK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8C30", Offset = "0x7FD7430", VA = "0x187FD8C30")]
		public void BMEKNNINHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9000", Offset = "0x7FD7800", VA = "0x187FD9000", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9560", Offset = "0x7FD7D60", VA = "0x187FD9560")]
		[CompilerGenerated]
		private BFIFKPBFBML<byte[]> HAIAHEMCJOE(Texture2D EIOHMDJEFPP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ABOBBMPALNI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct JAGJMDANOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7390", Offset = "0x7FD5B90", VA = "0x187FD7390")]
		public unsafe static extern void GINKBGMPNDB(void* NMAECOLJIGJ, void* NMNMOFPMJKK, bool HEBBEJOJIJA, bool CHLPJJEGOFI, bool AEHCBFBAFOD, [Out] int GPMLECINMDG, [Out] int DMFNFGGJFBG, [Out] bool JLPBJLJHMLN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FODCFIFFBAJ
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
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FODCFIFFBAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6A30", Offset = "0x7FD5230", VA = "0x187FD6A30")]
		internal void FJEAAJDLHOH(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MFBDPCFAMIE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7FD8710", Offset = "0x7FD6F10", VA = "0x187FD8710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8930", Offset = "0x7FD7130", VA = "0x187FD8930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NBEECDDOFOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NBEECDDOFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9BC0", Offset = "0x7FD83C0", VA = "0x187FD9BC0")]
		internal void POCFDBBDDOF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HHDHOBEENII : IAsyncStateMachine
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
		private NBEECDDOFOD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6BD0", Offset = "0x7FD53D0", VA = "0x187FD6BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7290", Offset = "0x7FD5A90", VA = "0x187FD7290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool KCHLBNKCBKM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
	public static bool FMDIDOGAOAO(byte[] LBKPNIMFKGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6810", Offset = "0x7FD5010", VA = "0x187FD6810")]
	[AsyncStateMachine(typeof(MFBDPCFAMIE))]
	public static Task<Texture2D> KBIGEONLJJE(byte[] LBKPNIMFKGC, bool FLKGLIKDCMB = false, bool DOEECNKMDFC = false, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6630", Offset = "0x7FD4E30", VA = "0x187FD6630")]
	[AsyncStateMachine(typeof(HHDHOBEENII))]
	private static Task<Texture2D> CAJDDJPPJML(int GPMLECINMDG, int DMFNFGGJFBG, bool CLPIGPJILLK, bool FLKGLIKDCMB, bool DOEECNKMDFC, Action<NativeArray<byte>> NOMCEMGBFJC, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6780", Offset = "0x7FD4F80", VA = "0x187FD6780")]
	private static TextureFormat FBBMHIPKAKO(bool CLPIGPJILLK)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum LKBLNKFMPHI
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
internal static class JJHJAMLGADA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7CA0", Offset = "0x7FD64A0", VA = "0x187FD7CA0")]
	public static bool KPJCGPOPLGH(byte[] IMINNNCPCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7660", Offset = "0x7FD5E60", VA = "0x187FD7660")]
	public static void CIOIEOCOBJJ(byte[] IMINNNCPCJF, [Out] int GPMLECINMDG, [Out] int DMFNFGGJFBG, [Out] LKBLNKFMPHI HKOGDKBPFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7970", Offset = "0x7FD6170", VA = "0x187FD7970")]
	private static uint GIPEOADHLED(byte[] IMINNNCPCJF, int BAGLBFCLNDM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7AA0", Offset = "0x7FD62A0", VA = "0x187FD7AA0")]
	private static ulong IHGBAELHDJH(byte[] IMINNNCPCJF, int BAGLBFCLNDM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MNPLEBKGOLM
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8A00", Offset = "0x7FD7200", VA = "0x187FD8A00")]
	public static RenderTexture JPJBFHOEFCL(int GPMLECINMDG, int DMFNFGGJFBG, int FODPGBDGFAK, Camera KBMHMGBHCFM, RenderTextureMemoryless FADMPFHIIII = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7FD89A0", Offset = "0x7FD71A0", VA = "0x187FD89A0")]
	public static void IELDDDCBLHM(RenderTexture OIIOPEDHLGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class PNNHNKJJHDN<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct NMLMIDJMBFD : IEquatable<NMLMIDJMBFD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId FOFDICJJEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly IJKBKBANHOL MGJOKGLEKJN;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x18D8EE0", Offset = "0x18D76E0", VA = "0x1818D8EE0")]
		public NMLMIDJMBFD(TImageId MNMCNOJCKAF, IJKBKBANHOL GEPNKBAIIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x55E3290", Offset = "0x55E1A90", VA = "0x1855E3290", Slot = "4")]
		public bool Equals(PNNHNKJJHDN<TImageId>.NMLMIDJMBFD KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x55E3380", Offset = "0x55E1B80", VA = "0x1855E3380", Slot = "0")]
		public override bool Equals(object HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x55E3580", Offset = "0x55E1D80", VA = "0x1855E3580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x55E3720", Offset = "0x55E1F20", VA = "0x1855E3720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MMEPOJFNFJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KMBNNOIKNHN<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MMEPOJFNFJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x554DDB0", Offset = "0x554C5B0", VA = "0x18554DDB0")]
		internal void GCCKFOFLGGG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct IOEGMCLBCCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NMLMIDJMBFD cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public PNNHNKJJHDN<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private IJKBKBANHOL <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4E92130", Offset = "0x4E90930", VA = "0x184E92130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4E92FA0", Offset = "0x4E917A0", VA = "0x184E92FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct KELPKFNEFKB : IAsyncStateMachine
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
		public IJKBKBANHOL textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PNNHNKJJHDN<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x519E530", Offset = "0x519CD30", VA = "0x18519E530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x519ECB0", Offset = "0x519D4B0", VA = "0x18519ECB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct BDEJBKMCBOF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6163B40", Offset = "0x6162340", VA = "0x186163B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6163F00", Offset = "0x6162700", VA = "0x186163F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int BIPDJMOOKIH = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim GDKPBNCFGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? CMDOANJBFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, IJKBKBANHOL, CancellationToken, Task<Texture2D>>? CEJFKPMJDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? EGFMKILJPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly FLKAIJPABOG<NMLMIDJMBFD, Texture2D> JOFIHDPMGEM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x58CA8F0", Offset = "0x58C90F0", VA = "0x1858CA8F0")]
	public PNNHNKJJHDN(Func<TImageId, CancellationToken, Task<byte[]>> OEPNFCJKKLP, [Optional] Func<TImageId, string>? GGOIOJBKIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x58CA940", Offset = "0x58C9140", VA = "0x1858CA940")]
	public PNNHNKJJHDN(Func<TImageId, IJKBKBANHOL, CancellationToken, Task<Texture2D>> JFOPLPIOLPN, [Optional] Func<TImageId, string>? GGOIOJBKIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x58CA990", Offset = "0x58C9190", VA = "0x1858CA990")]
	private PNNHNKJJHDN(Func<TImageId, CancellationToken, Task<byte[]>>? OEPNFCJKKLP, Func<TImageId, IJKBKBANHOL, CancellationToken, Task<Texture2D>>? JFOPLPIOLPN, Func<TImageId, string>? GGOIOJBKIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x58C9BB0", Offset = "0x58C83B0", VA = "0x1858C9BB0")]
	public OBKOLGEFKBC<Texture2D> HPMGOHHMHCH(TImageId GOLIPMMFMHN, IJKBKBANHOL JOEHNPOEKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x58C9B40", Offset = "0x58C8340", VA = "0x1858C9B40")]
	public void HGLBJNKBHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x58C99E0", Offset = "0x58C81E0", VA = "0x1858C99E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x58CA140", Offset = "0x58C8940", VA = "0x1858CA140")]
	[AsyncStateMachine(typeof(PNNHNKJJHDN<>.IOEGMCLBCCB))]
	private Task<Texture2D> KKBMPCJFKEH(NMLMIDJMBFD MHLEAJOKLMG, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x58CA410", Offset = "0x58C8C10", VA = "0x1858CA410")]
	[AsyncStateMachine(typeof(PNNHNKJJHDN<>.KELPKFNEFKB))]
	private Task<Texture2D> PDGMGNJJMDD(byte[] LBKPNIMFKGC, IJKBKBANHOL JOEHNPOEKEF, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x58C9BA0", Offset = "0x58C83A0", VA = "0x1858C9BA0")]
	private void HGPIBMPHMFG(Texture2D AILALHOICPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x58CA2A0", Offset = "0x58C8AA0", VA = "0x1858CA2A0")]
	private bool ONEGACKFNOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x58C9A90", Offset = "0x58C8290", VA = "0x1858C9A90")]
	private bool HFPOEGFHECD(byte[] LBKPNIMFKGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x58C98F0", Offset = "0x58C80F0", VA = "0x1858C98F0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(PNNHNKJJHDN<>.BDEJBKMCBOF))]
	internal static Task DLKBALPPCJJ(IDisposable PFAPNGBONJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum IJKBKBANHOL : byte
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
