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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x6090FF0", Offset = "0x60903F0", VA = "0x186090FF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x608DB70", Offset = "0x608CF70", VA = "0x18608DB70")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum NFKBKPBDJKO
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
public interface BOMMFNMPKKL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NFKBKPBDJKO BIFHKHJCEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ILDLEBBNPIP(VertexAttributeFormat BBJFPPIECOB, int CNPDHFPIMPK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HODFAHHHMAF
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
			[Cpp2IlInjected.Address(RVA = "0x60911F0", Offset = "0x60905F0", VA = "0x1860911F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60911E0", Offset = "0x60905E0", VA = "0x1860911E0")]
		public Resolution(uint NEEBEKKMNIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA43A60", Offset = "0xA42E60", VA = "0x180A43A60")]
		public Resolution(uint NEEBEKKMNIB, uint IGHOLFEOMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60910F0", Offset = "0x60904F0", VA = "0x1860910F0")]
		public static Resolution JNOKEHCMGPO(Resolution[] GGBINCNBHKJ, Resolution CCCACMMDAKI, int BKEABGHBBOG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class JNEHLCPGENK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution KDKKHGPOEJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? MCGDCDKOFDJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint NEEBEKKMNIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x608EC20", Offset = "0x608E020", VA = "0x18608EC20")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint IGHOLFEOMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x608F0F0", Offset = "0x608E4F0", VA = "0x18608F0F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution GBMKIOKHJKL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x608EC30", Offset = "0x608E030", VA = "0x18608EC30")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1953140", Offset = "0x1952540", VA = "0x181953140")]
		public JNEHLCPGENK(Resolution KDKKHGPOEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x608EF70", Offset = "0x608E370", VA = "0x18608EF70")]
		private static Resolution JBEAJAGPHKM(Resolution MCGDCDKOFDJ, NFKBKPBDJKO PAELEPEKNPB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class EKFNIGJENIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution HBNKJAMDKJH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution BNNIBBKMGJO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution KJGAIFMFMCF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution NFAOOPBIFJB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution FFBLLEFHDOI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KEIEBCEAGOA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] JOIHJIFPEMK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class MOBMDNLJCGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution EFCMFPDCFGB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution HPCMLBMHIMO;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution CLEIMLOENNM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution IGKIDDNGCAH;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution OJLDACCMBFC;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] JOIHJIFPEMK;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x608F110", Offset = "0x608E510", VA = "0x18608F110")]
		public static Resolution HGFHFBFBPED(uint EKMHLMNPMCN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution NLMFNIFLOMC;
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[Flags]
		public enum NFGKKPMHAEK : byte
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

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class ACLADJJGBLB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string GFBABMFGHOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D LAFCMBANGJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NFGKKPMHAEK AFPOAMGMMFC;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x608DAE0", Offset = "0x608CEE0", VA = "0x18608DAE0")]
			public ACLADJJGBLB(string GFBABMFGHOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x43F9D80", Offset = "0x43F9180", VA = "0x1843F9D80")]
			public ACLADJJGBLB(string GFBABMFGHOJ, Texture2D OOHGPGNBBID, NFGKKPMHAEK LFNANEFHJIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x608DAA0", Offset = "0x608CEA0", VA = "0x18608DAA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class BGLAKIHHPLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NFGKKPMHAEK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public BGLAKIHHPLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x608DB30", Offset = "0x608CF30", VA = "0x18608DB30")]
			internal void NADBHMOABBA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ECFMKJCMGPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public ECFMKJCMGPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x608E360", Offset = "0x608D760", VA = "0x18608E360")]
			internal CGPNNAFNPEB MIPPPGODDHG(Texture2D t2d)
			{
				return default(CGPNNAFNPEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class PAHNHJCDCEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public PAHNHJCDCEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6091070", Offset = "0x6090470", VA = "0x186091070")]
			internal void OMPIPKGONON()
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
		private GKAGCLBDDCM<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ACLADJJGBLB _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private GKAGCLBDDCM<CGPNNAFNPEB> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GKAGCLBDDCM<CGPNNAFNPEB> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7EC020", Offset = "0x7EB420", VA = "0x1807EC020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7A2710", Offset = "0x7A1B10", VA = "0x1807A2710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ACLADJJGBLB memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6090460", Offset = "0x608F860", VA = "0x186090460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6090390", Offset = "0x608F790", VA = "0x186090390")]
		public ManagedTexture(string GFBABMFGHOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60903F0", Offset = "0x608F7F0", VA = "0x1860903F0")]
		public ManagedTexture(string GFBABMFGHOJ, bool EBAGIBPIOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x608F560", Offset = "0x608E960", VA = "0x18608F560")]
		public void AMNPKFAAION(RenderTexture EKHIFGPMGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x608FAB0", Offset = "0x608EEB0", VA = "0x18608FAB0")]
		public GKAGCLBDDCM<Texture2D> HJMCNIFINCG(NFGKKPMHAEK LFNANEFHJIA, bool AMOPNAEOKAG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x608F8B0", Offset = "0x608ECB0", VA = "0x18608F8B0")]
		public GKAGCLBDDCM<CGPNNAFNPEB> EIOGPDNONPB(bool AMOPNAEOKAG = false, int FJJAOGMMAEA = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x608F5B0", Offset = "0x608E9B0", VA = "0x18608F5B0")]
		public GKAGCLBDDCM<CGPNNAFNPEB> EGMPOCNECKP(bool AMOPNAEOKAG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x608FDA0", Offset = "0x608F1A0", VA = "0x18608FDA0")]
		private static GKAGCLBDDCM<Texture2D> HMFOEBLOOIB(string GFBABMFGHOJ, RenderTexture EKHIFGPMGLH, Texture2D KDJHLFIKHDL, bool AMOPNAEOKAG, NFGKKPMHAEK CGCFCEAPHBE = NFGKKPMHAEK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60902F0", Offset = "0x608F6F0", VA = "0x1860902F0")]
		public void KCGNGNPHLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x608F5A0", Offset = "0x608E9A0", VA = "0x18608F5A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x608FA50", Offset = "0x608EE50", VA = "0x18608FA50")]
		[CompilerGenerated]
		private GKAGCLBDDCM<byte[]> HCPNEFBIBLF(Texture2D PODGBIHIIFD)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NBPLHCPBLHE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MPHEPGBFJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x608F460", Offset = "0x608E860", VA = "0x18608F460")]
		public unsafe static extern void LGKPCJBHPOL(void* EHNJBGNKBGP, void* LHDFPPNLHJD, bool KAPAPEAAMJK, bool KMEIGHIBEMH, bool OCGKKBDGLEB, [Out] int EKMHLMNPMCN, [Out] int GEMHPEEAHOI, [Out] bool MBIDKLAIPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DAJEJGPOHOD
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

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public DAJEJGPOHOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x608DB90", Offset = "0x608CF90", VA = "0x18608DB90")]
		internal void HEGIEOBMMDG(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct GNJPBPMJOMG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x608E7C0", Offset = "0x608DBC0", VA = "0x18608E7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x608E9E0", Offset = "0x608DDE0", VA = "0x18608E9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class NJEGIBCIDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public NJEGIBCIDBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6090FB0", Offset = "0x60903B0", VA = "0x186090FB0")]
		internal void BICOGHDPHKD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct NFHDIAFLIJN : IAsyncStateMachine
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
		private NJEGIBCIDBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6090880", Offset = "0x608FC80", VA = "0x186090880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6090F40", Offset = "0x6090340", VA = "0x186090F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool GKGGBIAKMEB;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780")]
	public static bool JCJIFGMFOEA(byte[] AHILBPJJLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6090510", Offset = "0x608F910", VA = "0x186090510")]
	[AsyncStateMachine(typeof(GNJPBPMJOMG))]
	public static Task<Texture2D> EDEMIOKFAPM(byte[] AHILBPJJLLL, bool PEHALPAHNBG = false, bool FHFBGLJNKCC = false, [Optional] CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6090650", Offset = "0x608FA50", VA = "0x186090650")]
	[AsyncStateMachine(typeof(NFHDIAFLIJN))]
	private static Task<Texture2D> KBEAGBIKDML(int EKMHLMNPMCN, int GEMHPEEAHOI, bool BBEGKMGCNAN, bool PEHALPAHNBG, bool FHFBGLJNKCC, Action<NativeArray<byte>> AHLCBEOADDK, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60907A0", Offset = "0x608FBA0", VA = "0x1860907A0")]
	private static TextureFormat LKIKIAAOKID(bool BBEGKMGCNAN)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal enum IAPGPGNPGBG
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
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class DGMLLEPFFHI
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x608E060", Offset = "0x608D460", VA = "0x18608E060")]
	public static void FBEFIDMEGLP(byte[] ALPLHOOHPEL, [Out] int EKMHLMNPMCN, [Out] int GEMHPEEAHOI, [Out] IAPGPGNPGBG BBJFPPIECOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x608DF30", Offset = "0x608D330", VA = "0x18608DF30")]
	private static uint CGIANKJHPFG(byte[] ALPLHOOHPEL, int PKHCCBJJMMB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x608DD30", Offset = "0x608D130", VA = "0x18608DD30")]
	private static ulong BEGNOJHKDNC(byte[] ALPLHOOHPEL, int PKHCCBJJMMB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FLLNGCLFJGK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x608E620", Offset = "0x608DA20", VA = "0x18608E620")]
	public static RenderTexture GBBJDHNEJAH(int EKMHLMNPMCN, int GEMHPEEAHOI, int DGPPGOLOKKH, Camera MFIFMMPLJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x608E5C0", Offset = "0x608D9C0", VA = "0x18608E5C0")]
	public static void BCJKBKJJLKC(RenderTexture EKHIFGPMGLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class BBHMEFJNMJJ<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private readonly struct EBOIINNFGAB : IEquatable<EBOIINNFGAB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId LFGGDIOAEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly NFGOMEFEGBH BKLJGBFHMHK;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x32A1E60", Offset = "0x32A1260", VA = "0x1832A1E60")]
		public EBOIINNFGAB(TImageId GPGELODKPOB, NFGOMEFEGBH FODKAMDODIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x32A1A30", Offset = "0x32A0E30", VA = "0x1832A1A30", Slot = "4")]
		public bool Equals(BBHMEFJNMJJ<TImageId>.EBOIINNFGAB KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x32A1710", Offset = "0x32A0B10", VA = "0x1832A1710", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x32A1C10", Offset = "0x32A1010", VA = "0x1832A1C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x32A1DA0", Offset = "0x32A11A0", VA = "0x1832A1DA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PKEBDJENDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NJKEHFGOEOH<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public PKEBDJENDEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x40AAB10", Offset = "0x40A9F10", VA = "0x1840AAB10")]
		internal void MCIBAJBJBEI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct IIIIEAAGAGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public EBOIINNFGAB cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public BBHMEFJNMJJ<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NFGOMEFEGBH <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3828480", Offset = "0x3827880", VA = "0x183828480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3828B10", Offset = "0x3827F10", VA = "0x183828B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct EAHFLLEIDKD : IAsyncStateMachine
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
		public NFGOMEFEGBH textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x32A0060", Offset = "0x329F460", VA = "0x1832A0060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x32A0680", Offset = "0x329FA80", VA = "0x1832A0680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct CAAPDAAOLEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4832190", Offset = "0x4831590", VA = "0x184832190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x48323D0", Offset = "0x48317D0", VA = "0x1848323D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int PNCOJMMKHGI = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim JMLBKDAKIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? DHEJEJMJEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, NFGOMEFEGBH, CancellationToken, Task<Texture2D>>? EPILOAAIBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? LDMGJLPLOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly NBGFBJABEBO<EBOIINNFGAB, Texture2D> MLFAAGPLAHO;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x470F690", Offset = "0x470EA90", VA = "0x18470F690")]
	public BBHMEFJNMJJ(Func<TImageId, CancellationToken, Task<byte[]>> ONNHJLFMKJE, [Optional] Func<TImageId, string>? NMKDEICEADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x470F850", Offset = "0x470EC50", VA = "0x18470F850")]
	public BBHMEFJNMJJ(Func<TImageId, NFGOMEFEGBH, CancellationToken, Task<Texture2D>> KNAGHHKKIIN, [Optional] Func<TImageId, string>? NMKDEICEADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x470F6C0", Offset = "0x470EAC0", VA = "0x18470F6C0")]
	private BBHMEFJNMJJ(Func<TImageId, CancellationToken, Task<byte[]>>? ONNHJLFMKJE, Func<TImageId, NFGOMEFEGBH, CancellationToken, Task<Texture2D>>? KNAGHHKKIIN, Func<TImageId, string>? NMKDEICEADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x470EC60", Offset = "0x470E060", VA = "0x18470EC60")]
	public NJKEHFGOEOH<Task<Texture2D>> LOFIHHKAGED(TImageId MBAFOFFCCNB, NFGOMEFEGBH HDCMNJIAGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x470F310", Offset = "0x470E710", VA = "0x18470F310")]
	public void NEEHPPMEFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x470E9F0", Offset = "0x470DDF0", VA = "0x18470E9F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x470EE00", Offset = "0x470E200", VA = "0x18470EE00")]
	[AsyncStateMachine(typeof(BBHMEFJNMJJ<>.IIIIEAAGAGG))]
	private Task<Texture2D> MAHJCDOBNJG(EBOIINNFGAB FMMIOOAOPHB, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x470F1E0", Offset = "0x470E5E0", VA = "0x18470F1E0")]
	[AsyncStateMachine(typeof(BBHMEFJNMJJ<>.EAHFLLEIDKD))]
	private Task<Texture2D> MOPGPCFAHKB(byte[] AHILBPJJLLL, NFGOMEFEGBH HDCMNJIAGNP, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x470EA90", Offset = "0x470DE90", VA = "0x18470EA90")]
	private void KOCECMMMHGP(Texture2D OOHGPGNBBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x470E810", Offset = "0x470DC10", VA = "0x18470E810")]
	[AsyncStateMachine(typeof(BBHMEFJNMJJ<>.CAAPDAAOLEJ))]
	[CompilerGenerated]
	internal static Task BCCPFODHLJG(IDisposable FCFFOLOEBPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum NFGOMEFEGBH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
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
