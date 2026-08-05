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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x78BA1D0", Offset = "0x78B95D0", VA = "0x1878BA1D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78B6F80", Offset = "0x78B6380", VA = "0x1878B6F80")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FJFKFKEFIHH
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
			[Cpp2IlInjected.Address(RVA = "0x78BA620", Offset = "0x78B9A20", VA = "0x1878BA620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78BA610", Offset = "0x78B9A10", VA = "0x1878BA610")]
		public Resolution(uint MEAMPLHPPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
		public Resolution(uint MEAMPLHPPKP, uint KDELALKKKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78BA520", Offset = "0x78B9920", VA = "0x1878BA520")]
		public static Resolution NBEBOJADJAF(Resolution[] FBCMGOKFCPJ, Resolution IOJBHLNJEBF, int FLMGMJFGNKF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class KPOCIPKNGPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution EDDMKODDMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? DHMPOMHNJAA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint MEAMPLHPPKP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x78B8B20", Offset = "0x78B7F20", VA = "0x1878B8B20")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution CMEPMMHIGDM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x78B8640", Offset = "0x78B7A40", VA = "0x1878B8640")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD49A10", Offset = "0xD48E10", VA = "0x180D49A10")]
		public KPOCIPKNGPB(Resolution EDDMKODDMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78B89A0", Offset = "0x78B7DA0", VA = "0x1878B89A0")]
		private static Resolution JBOJDAIPBNJ(Resolution DHMPOMHNJAA, DEJKIIKNJPH CIDOCKFCADF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class DJGHKILINOP
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution IAHCHFELDFI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution IAGAIHJPEFL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution OEIFPFCEFLD;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution KKBBILHAGID;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution JNNBHDHNFMK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution PGKOHAAGNFI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] LPOMEEOJCND;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class LENNKDDKMCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PBDCMPHOIHI;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DJKOKNPBIGO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DLMKFLGKGOO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution AJMHGDIJBPP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution AOMCKHMIIPP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] LPOMEEOJCND;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78B8B70", Offset = "0x78B7F70", VA = "0x1878B8B70")]
		public static Resolution FMDMKFLNCME(uint LFKDJGNAENO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution LNJGMANCGFF;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class LNODCNGBMPF
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x78B8EC0", Offset = "0x78B82C0", VA = "0x1878B8EC0")]
	public static bool CDDPHAKAOAH(byte[] HPMNBNLACCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x78B8F00", Offset = "0x78B8300", VA = "0x1878B8F00")]
	public static bool EIOAHDAFIIO(byte[] HPMNBNLACCC, [Out] int LFKDJGNAENO, [Out] int MOCGLJLLGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x78B9110", Offset = "0x78B8510", VA = "0x1878B9110")]
	private static int HBCFMKELPPJ(byte[] HPMNBNLACCC, int GNPKFMEIDNL, [Out] ushort HDKCOPNIALJ)
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
		public enum PHPMNPHDLKJ : byte
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
		private class KIHKPOAJBNO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string IGEPDAOOLBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D GJGOKGDEMCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public PHPMNPHDLKJ NCHICJIHGME;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x78B7EC0", Offset = "0x78B72C0", VA = "0x1878B7EC0")]
			public KIHKPOAJBNO(string IGEPDAOOLBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x18714B0", Offset = "0x18708B0", VA = "0x1818714B0")]
			public KIHKPOAJBNO(string IGEPDAOOLBO, Texture2D NPCKAAANCNE, PHPMNPHDLKJ BLHHMAHOLAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x78B7E80", Offset = "0x78B7280", VA = "0x1878B7E80", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OFJABFCGGIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public PHPMNPHDLKJ textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public OFJABFCGGIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x78BA250", Offset = "0x78B9650", VA = "0x1878BA250")]
			internal void GGJOKLFGAGE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class LDPFLMFCOMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public LDPFLMFCOMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x78B8B30", Offset = "0x78B7F30", VA = "0x1878B8B30")]
			internal MNBDLPDCMLE OHFHEEPHDJA(Texture2D t2d)
			{
				return default(MNBDLPDCMLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class MIHBOOLJMON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public MIHBOOLJMON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x78B91A0", Offset = "0x78B85A0", VA = "0x1878B91A0")]
			internal void ALPKDJBMFED()
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
		private GOBMEFCJDOP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KIHKPOAJBNO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GOBMEFCJDOP<MNBDLPDCMLE> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private GOBMEFCJDOP<MNBDLPDCMLE> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBE3960", Offset = "0xBE2D60", VA = "0x180BE3960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private KIHKPOAJBNO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x78BA120", Offset = "0x78B9520", VA = "0x1878BA120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78BA050", Offset = "0x78B9450", VA = "0x1878BA050")]
		public ManagedTexture(string IGEPDAOOLBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x78BA0B0", Offset = "0x78B94B0", VA = "0x1878BA0B0")]
		public ManagedTexture(string IGEPDAOOLBO, bool AJOFOHAMFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78B9920", Offset = "0x78B8D20", VA = "0x1878B9920")]
		public void NEPBHHIGMNH(RenderTexture DOPHDKBFGIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78B9630", Offset = "0x78B8A30", VA = "0x1878B9630")]
		public GOBMEFCJDOP<Texture2D> MDHPABLMDLO(PHPMNPHDLKJ BLHHMAHOLAO, bool DBDHLADOEFN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78B9960", Offset = "0x78B8D60", VA = "0x1878B9960")]
		public GOBMEFCJDOP<MNBDLPDCMLE> OGHHHIIHGKD(bool DBDHLADOEFN = false, int KEBDBBMJFKJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78B9330", Offset = "0x78B8730", VA = "0x1878B9330")]
		public GOBMEFCJDOP<MNBDLPDCMLE> JKHMMCBAJEH(bool DBDHLADOEFN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78B9B00", Offset = "0x78B8F00", VA = "0x1878B9B00")]
		private static GOBMEFCJDOP<Texture2D> OPNCONCLJPN(string IGEPDAOOLBO, RenderTexture DOPHDKBFGIH, Texture2D IJPBOPBCDDC, bool DBDHLADOEFN, PHPMNPHDLKJ OICOPJMPHPI = PHPMNPHDLKJ.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78B9290", Offset = "0x78B8690", VA = "0x1878B9290")]
		public void EJGMMDEOKAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78B9280", Offset = "0x78B8680", VA = "0x1878B9280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x78B9220", Offset = "0x78B8620", VA = "0x1878B9220")]
		[CompilerGenerated]
		private GOBMEFCJDOP<byte[]> BMOOAGBILON(Texture2D IBGAJBLLEBK)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BFDNNDCOKJE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct BCHINOMCLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x78B6B00", Offset = "0x78B5F00", VA = "0x1878B6B00")]
		public unsafe static extern void BBGEBDOPPFB(void* NOEEHEJCGHH, void* NOOEFABFCIC, bool ADGDPECMNHC, bool JBBINGFKOFG, bool EMKPJMFHDME, [Out] int LFKDJGNAENO, [Out] int MOCGLJLLGCL, [Out] bool KGDJGHMLDOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JHHICBGKNDM
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public JHHICBGKNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x78B7CE0", Offset = "0x78B70E0", VA = "0x1878B7CE0")]
		internal void DLGMHKFGAKE(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FGMFCAALDNJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x78B71C0", Offset = "0x78B65C0", VA = "0x1878B71C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78B73E0", Offset = "0x78B67E0", VA = "0x1878B73E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HMPDAEELCGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HMPDAEELCGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x78B7620", Offset = "0x78B6A20", VA = "0x1878B7620")]
		internal void OLKILNHDKKN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KOCIAPCHENK : IAsyncStateMachine
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
		private HMPDAEELCGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x78B7F10", Offset = "0x78B7310", VA = "0x1878B7F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x78B85D0", Offset = "0x78B79D0", VA = "0x1878B85D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool CNDEOMFDJDD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
	public static bool DNIDJMNHGHL(byte[] KIOLLAHAPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x78B6CA0", Offset = "0x78B60A0", VA = "0x1878B6CA0")]
	[AsyncStateMachine(typeof(FGMFCAALDNJ))]
	public static Task<Texture2D> HLJMPFFABBA(byte[] KIOLLAHAPFN, bool ACOLCCFIANK = false, bool OBKHIBFDDIB = false, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78B6DE0", Offset = "0x78B61E0", VA = "0x1878B6DE0")]
	[AsyncStateMachine(typeof(KOCIAPCHENK))]
	private static Task<Texture2D> LFCOMHBAJDH(int LFKDJGNAENO, int MOCGLJLLGCL, bool ALHBIIKKHMD, bool ACOLCCFIANK, bool OBKHIBFDDIB, Action<NativeArray<byte>> JAOLENMDBPE, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x78B6C00", Offset = "0x78B6000", VA = "0x1878B6C00")]
	private static TextureFormat FIECJGCKGDF(bool ALHBIIKKHMD)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum FCDEDENNOCJ
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
internal static class IGBBFHLGFIA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x78B7660", Offset = "0x78B6A60", VA = "0x1878B7660")]
	public static bool CKGEDDPGCIH(byte[] HPMNBNLACCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x78B79D0", Offset = "0x78B6DD0", VA = "0x1878B79D0")]
	public static void KCPMCCACNID(byte[] HPMNBNLACCC, [Out] int LFKDJGNAENO, [Out] int MOCGLJLLGCL, [Out] FCDEDENNOCJ HJPPOILPOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x78B78A0", Offset = "0x78B6CA0", VA = "0x1878B78A0")]
	private static uint JEJCIGBNLFE(byte[] HPMNBNLACCC, int HCJENEHBBIC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x78B76A0", Offset = "0x78B6AA0", VA = "0x1878B76A0")]
	private static ulong GKENCIDDHDO(byte[] HPMNBNLACCC, int HCJENEHBBIC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class OLAKIMKEHIP
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x78BA290", Offset = "0x78B9690", VA = "0x1878BA290")]
	public static RenderTexture AEGHNBPDLDL(int LFKDJGNAENO, int MOCGLJLLGCL, int IHBPOPJPJEO, Camera FDBJNHOEMAN, RenderTextureMemoryless NJHMCAJFFPF = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x78BA4C0", Offset = "0x78B98C0", VA = "0x1878BA4C0")]
	public static void GGAJEPICBPB(RenderTexture DOPHDKBFGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class KKGHGIOBDFN<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct KLIEIOHLKJK : IEquatable<KLIEIOHLKJK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId EBKBAEAJCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly NBCJGEFCKBL CHNCHFCPKBP;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1692140", Offset = "0x1691540", VA = "0x181692140")]
		public KLIEIOHLKJK(TImageId DJBLFBEBKGO, NBCJGEFCKBL BCJOPAJBMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4D86D80", Offset = "0x4D86180", VA = "0x184D86D80", Slot = "4")]
		public bool Equals(KKGHGIOBDFN<TImageId>.KLIEIOHLKJK KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4D86C70", Offset = "0x4D86070", VA = "0x184D86C70", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4D86F50", Offset = "0x4D86350", VA = "0x184D86F50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4D870F0", Offset = "0x4D864F0", VA = "0x184D870F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GDIBLNDMKIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OHGHKHJHGOP<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GDIBLNDMKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x482FB90", Offset = "0x482EF90", VA = "0x18482FB90")]
		internal void HGBGDNLOCPJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct PGKLMHPHPAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public KLIEIOHLKJK cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public KKGHGIOBDFN<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private NBCJGEFCKBL <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x52DCB80", Offset = "0x52DBF80", VA = "0x1852DCB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x52DDA20", Offset = "0x52DCE20", VA = "0x1852DDA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct MLLGNOCLJDF : IAsyncStateMachine
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
		public NBCJGEFCKBL textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KKGHGIOBDFN<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5065BE0", Offset = "0x5064FE0", VA = "0x185065BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x50669E0", Offset = "0x5065DE0", VA = "0x1850669E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct PNDONECIMAB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5326640", Offset = "0x5325A40", VA = "0x185326640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5326880", Offset = "0x5325C80", VA = "0x185326880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int AKJNOFIBPCM = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim AMDGNHKLKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? DMCFOBDFHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, NBCJGEFCKBL, CancellationToken, Task<Texture2D>>? OMKNOLMKMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? BCOGOEKEMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NJGLBGPNBMB<KLIEIOHLKJK, Texture2D> AGHDHGECBDE;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D81860", Offset = "0x4D80C60", VA = "0x184D81860")]
	public KKGHGIOBDFN(Func<TImageId, CancellationToken, Task<byte[]>> APCOCBOIINC, [Optional] Func<TImageId, string>? EGIEMIGGCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D81810", Offset = "0x4D80C10", VA = "0x184D81810")]
	public KKGHGIOBDFN(Func<TImageId, NBCJGEFCKBL, CancellationToken, Task<Texture2D>> CDKJEDPLHNO, [Optional] Func<TImageId, string>? EGIEMIGGCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D81660", Offset = "0x4D80A60", VA = "0x184D81660")]
	private KKGHGIOBDFN(Func<TImageId, CancellationToken, Task<byte[]>>? APCOCBOIINC, Func<TImageId, NBCJGEFCKBL, CancellationToken, Task<Texture2D>>? CDKJEDPLHNO, Func<TImageId, string>? EGIEMIGGCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4D80E00", Offset = "0x4D80200", VA = "0x184D80E00")]
	public HLFDOLJKNKL<Texture2D> NLKEOLDKCDH(TImageId IHEPGCHCABL, NBCJGEFCKBL KNMMEBLGLKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4D80840", Offset = "0x4D7FC40", VA = "0x184D80840")]
	public void EIKMHJEEHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4D80790", Offset = "0x4D7FB90", VA = "0x184D80790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4D80B50", Offset = "0x4D7FF50", VA = "0x184D80B50")]
	[AsyncStateMachine(typeof(KKGHGIOBDFN<>.PGKLMHPHPAP))]
	private Task<Texture2D> IKPOOMFOFFJ(KLIEIOHLKJK IMDENDBDIKN, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4D80890", Offset = "0x4D7FC90", VA = "0x184D80890")]
	[AsyncStateMachine(typeof(KKGHGIOBDFN<>.MLLGNOCLJDF))]
	private Task<Texture2D> GPAPCOJNJIJ(byte[] KIOLLAHAPFN, NBCJGEFCKBL KNMMEBLGLKD, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D80DF0", Offset = "0x4D801F0", VA = "0x184D80DF0")]
	private void ILJBOHHLMAC(Texture2D NPCKAAANCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4D80780", Offset = "0x4D7FB80", VA = "0x184D80780")]
	private bool AMLDBDCLPAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D81210", Offset = "0x4D80610", VA = "0x184D81210")]
	private bool OFMFPAHCEDP(byte[] KIOLLAHAPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4D812C0", Offset = "0x4D806C0", VA = "0x184D812C0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(KKGHGIOBDFN<>.PNDONECIMAB))]
	internal static Task POENKLIIGLB(IDisposable IBDPKELPCFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum NBCJGEFCKBL : byte
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
