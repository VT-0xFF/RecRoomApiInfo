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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6872900", Offset = "0x6871100", VA = "0x186872900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
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
		[Cpp2IlInjected.Address(RVA = "0x686FB90", Offset = "0x686E390", VA = "0x18686FB90")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JHDMPNKCAFG
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
public interface CANMLLNEELM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JHDMPNKCAFG GMAPPMHLCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LMFMJHBBDGD(VertexAttributeFormat NFAJBIAKHPK, int KMNLBNJNOKK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BBDNILLBACI
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
			[Cpp2IlInjected.Address(RVA = "0x6872AC0", Offset = "0x68712C0", VA = "0x186872AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6872AB0", Offset = "0x68712B0", VA = "0x186872AB0")]
		public Resolution(uint PNGIKMLKECD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
		public Resolution(uint PNGIKMLKECD, uint MADKMAGKKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68729C0", Offset = "0x68711C0", VA = "0x1868729C0")]
		public static Resolution HBHJMBFCIJJ(Resolution[] KBIBKNJKDBF, Resolution LIMOBMHEFGG, int COCGELKLAML)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class JLABEKGOIJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution LOKINBCMAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? ABEEKPAPHBP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint PNGIKMLKECD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6871420", Offset = "0x686FC20", VA = "0x186871420")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution KBJPNABAKOO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x68715B0", Offset = "0x686FDB0", VA = "0x1868715B0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1036D30", Offset = "0x1035530", VA = "0x181036D30")]
		public JLABEKGOIJP(Resolution LOKINBCMAFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6871430", Offset = "0x686FC30", VA = "0x186871430")]
		private static Resolution NLJODLEAFIC(Resolution ABEEKPAPHBP, JHDMPNKCAFG KBBIEKHEJAJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class FPFAPNPMEIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution GGKOAELDJOF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution MMCJAGILAIN;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DHBENGCOHII;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CHMICPKLCKC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution OFEKBIBLGMO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KMFFIIHPGLH;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] ACAPFKBIPCB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class BDEDHAIGBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution CBGHPMPIBHI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution MHKKGINBPNI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution EJCBLHBKCFG;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution EBHLNFPFJCE;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution GCBKHJJGIGF;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] ACAPFKBIPCB;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x686F870", Offset = "0x686E070", VA = "0x18686F870")]
		public static Resolution LDIIHKIMJLI(uint OIMODFKJOJM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution DHINMGEAFHL;
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[Flags]
		public enum DGBLFAPPLDC : byte
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
		private class GFENAILBGEG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string GCDLMFGKKMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D EDKIHPBNCCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public DGBLFAPPLDC AENMNIGFEPO;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6870870", Offset = "0x686F070", VA = "0x186870870")]
			public GFENAILBGEG(string GCDLMFGKKMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3C916A0", Offset = "0x3C8FEA0", VA = "0x183C916A0")]
			public GFENAILBGEG(string GCDLMFGKKMH, Texture2D JHIAEMLCNGK, DGBLFAPPLDC OKOFCLDIDHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6870830", Offset = "0x686F030", VA = "0x186870830", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class NFMHINKIBBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public DGBLFAPPLDC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public NFMHINKIBBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68728C0", Offset = "0x68710C0", VA = "0x1868728C0")]
			internal void MDPFOIPJADA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ODEIKPGIJCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public ODEIKPGIJCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6872980", Offset = "0x6871180", VA = "0x186872980")]
			internal IKKDFOKDDAE LKMKMEIKCEM(Texture2D t2d)
			{
				return default(IKKDFOKDDAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class APFNMLDPMLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public APFNMLDPMLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x686F620", Offset = "0x686DE20", VA = "0x18686F620")]
			internal void GBPGFBGDKMD()
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
		private MOJHALOLCAP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private GFENAILBGEG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private MOJHALOLCAP<IKKDFOKDDAE> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MOJHALOLCAP<IKKDFOKDDAE> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x895EE0", Offset = "0x8946E0", VA = "0x180895EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x844F30", Offset = "0x843730", VA = "0x180844F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private GFENAILBGEG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6872810", Offset = "0x6871010", VA = "0x186872810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6872740", Offset = "0x6870F40", VA = "0x186872740")]
		public ManagedTexture(string GCDLMFGKKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x68727A0", Offset = "0x6870FA0", VA = "0x1868727A0")]
		public ManagedTexture(string GCDLMFGKKMH, bool NDKKIBIDKPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6872010", Offset = "0x6870810", VA = "0x186872010")]
		public void JONCLPGLFKK(RenderTexture DIONIANHKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6871920", Offset = "0x6870120", VA = "0x186871920")]
		public MOJHALOLCAP<Texture2D> ADHGGIECDBA(DGBLFAPPLDC OKOFCLDIDHP, bool MOGFIJOJOOP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6872050", Offset = "0x6870850", VA = "0x186872050")]
		public MOJHALOLCAP<IKKDFOKDDAE> KHPPFNJMEGF(bool MOGFIJOJOOP = false, int MOGIHNPDKBH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6871D20", Offset = "0x6870520", VA = "0x186871D20")]
		public MOJHALOLCAP<IKKDFOKDDAE> HEODMFPEHFO(bool MOGFIJOJOOP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x68721F0", Offset = "0x68709F0", VA = "0x1868721F0")]
		private static MOJHALOLCAP<Texture2D> MGHKPNDCLHB(string GCDLMFGKKMH, RenderTexture DIONIANHKFP, Texture2D MCNLCHFOBIO, bool MOGFIJOJOOP, DGBLFAPPLDC FDJEHEMOGFG = DGBLFAPPLDC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6871C10", Offset = "0x6870410", VA = "0x186871C10")]
		public void COOHGPDKKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6871CB0", Offset = "0x68704B0", VA = "0x186871CB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6871CC0", Offset = "0x68704C0", VA = "0x186871CC0")]
		[CompilerGenerated]
		private MOJHALOLCAP<byte[]> GFHLHPOLHLK(Texture2D FOONAMHJGMG)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DLMCNHMHMNP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct DHGELNHPBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x686FBB0", Offset = "0x686E3B0", VA = "0x18686FBB0")]
		public unsafe static extern void LOGPMOAENJF(void* NHPAMDFEFKA, void* OKKHHHCDIHJ, bool HIDLIAHPHBJ, bool FKBHGIJCOMN, bool GDAFLJEOOKH, [Out] int OIMODFKJOJM, [Out] int HNDAFEMONEJ, [Out] bool HNINNKFLJIK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class GMCLKMGGDNK
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

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public GMCLKMGGDNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68708C0", Offset = "0x686F0C0", VA = "0x1868708C0")]
		internal void CBJBJDGFGCB(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct ANMIIGIFDND : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x686F390", Offset = "0x686DB90", VA = "0x18686F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x686F5B0", Offset = "0x686DDB0", VA = "0x18686F5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LHDDKBJOLPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LHDDKBJOLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x68718E0", Offset = "0x68700E0", VA = "0x1868718E0")]
		internal void EIAOLDOIILC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HCBBPHDJLPC : IAsyncStateMachine
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
		private LHDDKBJOLPG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6870A60", Offset = "0x686F260", VA = "0x186870A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6871120", Offset = "0x686F920", VA = "0x186871120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool IEHDNLBJBMI;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
	public static bool EJGJGIDLGGB(byte[] PKPDHNENFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x686FE90", Offset = "0x686E690", VA = "0x18686FE90")]
	[AsyncStateMachine(typeof(ANMIIGIFDND))]
	public static Task<Texture2D> PBCONDPIGEC(byte[] PKPDHNENFKE, bool KPNMOCCIEDM = false, bool GJABGBPPPOO = false, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x686FD40", Offset = "0x686E540", VA = "0x18686FD40")]
	[AsyncStateMachine(typeof(HCBBPHDJLPC))]
	private static Task<Texture2D> OMKKDFAKKFC(int OIMODFKJOJM, int HNDAFEMONEJ, bool OLILIODIGKA, bool KPNMOCCIEDM, bool GJABGBPPPOO, Action<NativeArray<byte>> NFGFGBEAHOP, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x686FCB0", Offset = "0x686E4B0", VA = "0x18686FCB0")]
	private static TextureFormat NPPIHHIKLGE(bool OLILIODIGKA)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal enum NMEOBGEPNIJ
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
internal static class FFCLDMBPEHD
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6870140", Offset = "0x686E940", VA = "0x186870140")]
	public static void NCDCJEHOGPF(byte[] MLKNGAFFKGE, [Out] int OIMODFKJOJM, [Out] int HNDAFEMONEJ, [Out] NMEOBGEPNIJ NFAJBIAKHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6870010", Offset = "0x686E810", VA = "0x186870010")]
	private static uint LMDIOBGOMCJ(byte[] MLKNGAFFKGE, int CKMEAPHLBGJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6870440", Offset = "0x686EC40", VA = "0x186870440")]
	private static ulong OCLMEKKGAHC(byte[] MLKNGAFFKGE, int CKMEAPHLBGJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JJGOOOFKLOE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6871190", Offset = "0x686F990", VA = "0x186871190")]
	public static RenderTexture EDHMFPALJGG(int OIMODFKJOJM, int HNDAFEMONEJ, int ONJLNAPAMGB, Camera PPBNJJDFPOP, RenderTextureMemoryless FDENNMICHKN = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68713C0", Offset = "0x686FBC0", VA = "0x1868713C0")]
	public static void EKNACIOLEPA(RenderTexture DIONIANHKFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class HLJOJMNGLOF<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private readonly struct ODOCOMONHPP : IEquatable<ODOCOMONHPP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId PCKKANPGDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly KOFCOEKHCBB NJEENKBNOCK;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3D91D90", Offset = "0x3D90590", VA = "0x183D91D90")]
		public ODOCOMONHPP(TImageId JOEHGGMHBAA, KOFCOEKHCBB OIEFCHJEAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4548FE0", Offset = "0x45477E0", VA = "0x184548FE0", Slot = "4")]
		public bool Equals(HLJOJMNGLOF<TImageId>.ODOCOMONHPP OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4548D40", Offset = "0x4547540", VA = "0x184548D40", Slot = "0")]
		public override bool Equals(object GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4549260", Offset = "0x4547A60", VA = "0x184549260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4549400", Offset = "0x4547C00", VA = "0x184549400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HLGCPFOCLFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public HHIKLOPOAIH<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HLGCPFOCLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1900", Offset = "0x3CB0100", VA = "0x183CB1900")]
		internal void NPLNNJANFOO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct AMEPPIPLEPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public ODOCOMONHPP cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HLJOJMNGLOF<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private KOFCOEKHCBB <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3C52BC0", Offset = "0x3C513C0", VA = "0x183C52BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3C532B0", Offset = "0x3C51AB0", VA = "0x183C532B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct DLCMLIGHFGO : IAsyncStateMachine
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
		public KOFCOEKHCBB textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public HLJOJMNGLOF<TImageId> <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x577A1A0", Offset = "0x57789A0", VA = "0x18577A1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x577A8A0", Offset = "0x57790A0", VA = "0x18577A8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct KDNANHEGEJJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4086000", Offset = "0x4084800", VA = "0x184086000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4086420", Offset = "0x4084C20", VA = "0x184086420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int HJIAIPPMCOL = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim CPMGJAHLPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? DKFPMBABCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, KOFCOEKHCBB, CancellationToken, Task<Texture2D>>? MOOCNLMOHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? MBHFLAMCBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BBDHGHHNKHH<ODOCOMONHPP, Texture2D> DOHCKPJMKEJ;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2840", Offset = "0x3CB1040", VA = "0x183CB2840")]
	public HLJOJMNGLOF(Func<TImageId, CancellationToken, Task<byte[]>> LNPGNHLDLMM, [Optional] Func<TImageId, string>? OFHOMLHIKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2C10", Offset = "0x3CB1410", VA = "0x183CB2C10")]
	public HLJOJMNGLOF(Func<TImageId, KOFCOEKHCBB, CancellationToken, Task<Texture2D>> AGDHNBIGHFJ, [Optional] Func<TImageId, string>? OFHOMLHIKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2A50", Offset = "0x3CB1250", VA = "0x183CB2A50")]
	private HLJOJMNGLOF(Func<TImageId, CancellationToken, Task<byte[]>>? LNPGNHLDLMM, Func<TImageId, KOFCOEKHCBB, CancellationToken, Task<Texture2D>>? AGDHNBIGHFJ, Func<TImageId, string>? OFHOMLHIKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3CB19C0", Offset = "0x3CB01C0", VA = "0x183CB19C0")]
	public MJMNDKPKIPJ<Texture2D> CDLJBHELEOK(TImageId AFIDADBILHB, KOFCOEKHCBB OBFCBMDGLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2090", Offset = "0x3CB0890", VA = "0x183CB2090")]
	public void FDNPIMLJAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1FE0", Offset = "0x3CB07E0", VA = "0x183CB1FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2500", Offset = "0x3CB0D00", VA = "0x183CB2500")]
	[AsyncStateMachine(typeof(HLJOJMNGLOF<>.AMEPPIPLEPE))]
	private Task<Texture2D> IBAPIDJGOHA(ODOCOMONHPP DIODKLJFBKA, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2250", Offset = "0x3CB0A50", VA = "0x183CB2250")]
	[AsyncStateMachine(typeof(HLJOJMNGLOF<>.DLCMLIGHFGO))]
	private Task<Texture2D> HFAOEEGKLCA(byte[] PKPDHNENFKE, KOFCOEKHCBB OBFCBMDGLCJ, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2660", Offset = "0x3CB0E60", VA = "0x183CB2660")]
	private void MIMJEOBKFMK(Texture2D JHIAEMLCNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2670", Offset = "0x3CB0E70", VA = "0x183CB2670")]
	private bool MNGBLOIKLDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1E00", Offset = "0x3CB0600", VA = "0x183CB1E00")]
	[AsyncStateMachine(typeof(HLJOJMNGLOF<>.KDNANHEGEJJ))]
	[CompilerGenerated]
	internal static Task DJBGJDOPOCH(IDisposable GMNNKFFHLHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum KOFCOEKHCBB : byte
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
