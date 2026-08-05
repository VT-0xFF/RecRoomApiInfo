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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82E53C0", Offset = "0x82E47C0", VA = "0x1882E53C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x82E23E0", Offset = "0x82E17E0", VA = "0x1882E23E0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JAGKALAEBNH
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
			[Cpp2IlInjected.Address(RVA = "0x82E5980", Offset = "0x82E4D80", VA = "0x1882E5980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82E5970", Offset = "0x82E4D70", VA = "0x1882E5970")]
		public Resolution(uint FNBJHADJBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
		public Resolution(uint FNBJHADJBNG, uint MODFPFNICHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82E5880", Offset = "0x82E4C80", VA = "0x1882E5880")]
		public static Resolution FDNAJLLCONN(Resolution[] LFFPIIDBFOJ, Resolution IAMINJLEJOI, int HALABAAPLEK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class CGEAOIIHCNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution HIKKBBGMCLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? FJKNHIMEBJP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint FNBJHADJBNG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x82E2250", Offset = "0x82E1650", VA = "0x1882E2250")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution JLNJCBNAKCI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x82E1EF0", Offset = "0x82E12F0", VA = "0x1882E1EF0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF30E60", Offset = "0xF30260", VA = "0x180F30E60")]
		public CGEAOIIHCNN(Resolution HIKKBBGMCLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82E2260", Offset = "0x82E1660", VA = "0x1882E2260")]
		private static Resolution KGDIENNDAAG(Resolution FJKNHIMEBJP, BOPNBIPBEKJ PKNGLBDEDDN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OPHNKIGGGDG
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution CJFPNFNMJIK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution OJEDKMDIDJG;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution NNOOLKEINCN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution GNOHOJCCADL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution FDNEGALCHLJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution AEEBCDNPCHB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] DHPHJOCBBMF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class KAFMBCGMOIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution IMAHELIAEHC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution CNDMLOBHAFN;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution HJKBFIIGNKN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution EIGDJAOOPIJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KHJMDOHOGJP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] DHPHJOCBBMF;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82E36C0", Offset = "0x82E2AC0", VA = "0x1882E36C0")]
		public static Resolution MCOLCLJPPNO(uint FGPFDBGIFDN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution ENDJIPLGEOI;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class JEONMBIBNAP
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82E33E0", Offset = "0x82E27E0", VA = "0x1882E33E0")]
	public static bool HEINAPILCGF(byte[] NGIAGNLBILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82E3420", Offset = "0x82E2820", VA = "0x1882E3420")]
	public static bool HFIPNLBLDOB(byte[] NGIAGNLBILI, [Out] int FGPFDBGIFDN, [Out] int MFIDIIHOELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82E3630", Offset = "0x82E2A30", VA = "0x1882E3630")]
	private static int OLHHPCJGEOG(byte[] NGIAGNLBILI, int FDIBAFEDFOG, [Out] ushort EJDPPDMMAPL)
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
		public enum BJLIDCDPGPD : byte
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
		private class GFMOIHLJLPC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string HDNPPEBJPAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D HGHKHPLOOBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public BJLIDCDPGPD LFMLNBCGMAF;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x82E2480", Offset = "0x82E1880", VA = "0x1882E2480")]
			public GFMOIHLJLPC(string HDNPPEBJPAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1C46B80", Offset = "0x1C45F80", VA = "0x181C46B80")]
			public GFMOIHLJLPC(string HDNPPEBJPAE, Texture2D IOFLDLKHGCB, BJLIDCDPGPD IIGLAPEMKCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x82E2440", Offset = "0x82E1840", VA = "0x1882E2440", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AKFKMFHBBBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public BJLIDCDPGPD textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public AKFKMFHBBBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x82E1E70", Offset = "0x82E1270", VA = "0x1882E1E70")]
			internal void BBABKJEKAHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class BNLCPGCBOAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public BNLCPGCBOAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x82E1EB0", Offset = "0x82E12B0", VA = "0x1882E1EB0")]
			internal ODFKOOMFCJO OJDEFHEEPIH(Texture2D t2d)
			{
				return default(ODFKOOMFCJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class PJMCBEDIBOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public PJMCBEDIBOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82E5800", Offset = "0x82E4C00", VA = "0x1882E5800")]
			internal void BNEABIODEMA()
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
		private FHMCAMOMJOP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GFMOIHLJLPC _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private FHMCAMOMJOP<ODFKOOMFCJO> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private FHMCAMOMJOP<ODFKOOMFCJO> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private GFMOIHLJLPC memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x82E5310", Offset = "0x82E4710", VA = "0x1882E5310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82E5240", Offset = "0x82E4640", VA = "0x1882E5240")]
		public ManagedTexture(string HDNPPEBJPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82E52A0", Offset = "0x82E46A0", VA = "0x1882E52A0")]
		public ManagedTexture(string HDNPPEBJPAE, bool BGGIBPBGPHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82E4530", Offset = "0x82E3930", VA = "0x1882E4530")]
		public void EJMEGCDHLLC(RenderTexture PAABFJFKFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82E4570", Offset = "0x82E3970", VA = "0x1882E4570")]
		public FHMCAMOMJOP<Texture2D> EMHPJMFAEAG(BJLIDCDPGPD IIGLAPEMKCO, bool DMMAHACLNCC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82E4DB0", Offset = "0x82E41B0", VA = "0x1882E4DB0")]
		public FHMCAMOMJOP<ODFKOOMFCJO> NDHGMFBNMLG(bool DMMAHACLNCC = false, int NNLNNDPOIHC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82E4F40", Offset = "0x82E4340", VA = "0x1882E4F40")]
		public FHMCAMOMJOP<ODFKOOMFCJO> OJOIGCANCPO(bool DMMAHACLNCC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82E4860", Offset = "0x82E3C60", VA = "0x1882E4860")]
		private static FHMCAMOMJOP<Texture2D> IKEFINLDPHA(string HDNPPEBJPAE, RenderTexture PAABFJFKFJA, Texture2D MCJKNEGDCIP, bool DMMAHACLNCC, BJLIDCDPGPD EKMAOLGBFIO = BJLIDCDPGPD.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82E4480", Offset = "0x82E3880", VA = "0x1882E4480")]
		public void DCEOLNLLIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82E4520", Offset = "0x82E3920", VA = "0x1882E4520", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82E4420", Offset = "0x82E3820", VA = "0x1882E4420")]
		[CompilerGenerated]
		private FHMCAMOMJOP<byte[]> AJJCLPHBPFP(Texture2D FBNFDFHCNBO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HLAOGHMGPDC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct LFGCFBKDKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82E4090", Offset = "0x82E3490", VA = "0x1882E4090")]
		public unsafe static extern void JNDJJEKPGBO(void* KNJECJHJIJI, void* MBAOOPBKPLE, bool NNKOFHLCLMB, bool JMEAADAHLKI, bool IOGOIDCPAOL, [Out] int FGPFDBGIFDN, [Out] int MFIDIIHOELB, [Out] bool LKILCMHFJPE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PFIKGFNPFBA
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
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PFIKGFNPFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82E5660", Offset = "0x82E4A60", VA = "0x1882E5660")]
		internal void ELAAHPBJFIN(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JECGHFOLIOO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82E3150", Offset = "0x82E2550", VA = "0x1882E3150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82E3370", Offset = "0x82E2770", VA = "0x1882E3370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class EDGJIIBLDDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EDGJIIBLDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82E2400", Offset = "0x82E1800", VA = "0x1882E2400")]
		internal void POGGODAIDIG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HKCBOAJNJDJ : IAsyncStateMachine
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
		private EDGJIIBLDDI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82E24D0", Offset = "0x82E18D0", VA = "0x1882E24D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82E2B90", Offset = "0x82E1F90", VA = "0x1882E2B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool EHIGPLHBHKB;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
	public static bool JNGGPJBPCLG(byte[] JFCAKFJAMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82E2D50", Offset = "0x82E2150", VA = "0x1882E2D50")]
	[AsyncStateMachine(typeof(JECGHFOLIOO))]
	public static Task<Texture2D> JCDKBDDHJKD(byte[] JFCAKFJAMKM, bool BHOIGJIBLJI = false, bool AECEDHBBJKN = false, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82E2C00", Offset = "0x82E2000", VA = "0x1882E2C00")]
	[AsyncStateMachine(typeof(HKCBOAJNJDJ))]
	private static Task<Texture2D> FNHGIBPJHFK(int FGPFDBGIFDN, int MFIDIIHOELB, bool BAEFKHKLCOH, bool BHOIGJIBLJI, bool AECEDHBBJKN, Action<NativeArray<byte>> KJHHANNCBIO, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82E2E90", Offset = "0x82E2290", VA = "0x1882E2E90")]
	private static TextureFormat JPJICHMMJPN(bool BAEFKHKLCOH)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum ECELFIGMHLL
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
internal static class KNPCHEABBBP
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82E3E50", Offset = "0x82E3250", VA = "0x1882E3E50")]
	public static bool MFIBGOPJBDD(byte[] NGIAGNLBILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82E3A10", Offset = "0x82E2E10", VA = "0x1882E3A10")]
	public static void GPLIBBDLIPI(byte[] NGIAGNLBILI, [Out] int FGPFDBGIFDN, [Out] int MFIDIIHOELB, [Out] ECELFIGMHLL LKPDHLBCOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82E3D20", Offset = "0x82E3120", VA = "0x1882E3D20")]
	private static uint KHAHIKKMIJO(byte[] NGIAGNLBILI, int FEMDGHMCLCC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82E3E90", Offset = "0x82E3290", VA = "0x1882E3E90")]
	private static ulong PPKHNCGJOPE(byte[] NGIAGNLBILI, int FEMDGHMCLCC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class LKOLHCOHHAM
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82E41F0", Offset = "0x82E35F0", VA = "0x1882E41F0")]
	public static RenderTexture PMAJHDFIHHK(int FGPFDBGIFDN, int MFIDIIHOELB, int BCKDECOKDAE, Camera MLFNHNIBMNH, RenderTextureMemoryless MOMABIGIEAA = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x82E4190", Offset = "0x82E3590", VA = "0x1882E4190")]
	public static void HJGANDJIMID(RenderTexture PAABFJFKFJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class GOFDOFEILIO<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct CFKEAOABNDH : IEquatable<CFKEAOABNDH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId DIAODCJCBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly LMCHIGAEEAF GOEFHOODKID;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1A68C90", Offset = "0x1A68090", VA = "0x181A68C90")]
		public CFKEAOABNDH(TImageId PEENICAIFOP, LMCHIGAEEAF HMMJDBOJLNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C9B600", Offset = "0x6C9AA00", VA = "0x186C9B600", Slot = "4")]
		public bool Equals(GOFDOFEILIO<TImageId>.CFKEAOABNDH LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C9B2E0", Offset = "0x6C9A6E0", VA = "0x186C9B2E0", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C9B6F0", Offset = "0x6C9AAF0", VA = "0x186C9B6F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C9B870", Offset = "0x6C9AC70", VA = "0x186C9B870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JFHJOGLAEMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public GDOFCMCMKJK<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JFHJOGLAEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x530CCC0", Offset = "0x530C0C0", VA = "0x18530CCC0")]
		internal void EINIDPAFPOH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct OIDGPAGPONC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CFKEAOABNDH cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GOFDOFEILIO<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private LMCHIGAEEAF <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x59CF690", Offset = "0x59CEA90", VA = "0x1859CF690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x59CFD00", Offset = "0x59CF100", VA = "0x1859CFD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct KLEHKJLIIGE : IAsyncStateMachine
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
		public LMCHIGAEEAF textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GOFDOFEILIO<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x545C7E0", Offset = "0x545BBE0", VA = "0x18545C7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x545D640", Offset = "0x545CA40", VA = "0x18545D640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct EJMEFJCGMPA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x49E3BD0", Offset = "0x49E2FD0", VA = "0x1849E3BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x49E3E10", Offset = "0x49E3210", VA = "0x1849E3E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LCHADIHBMEP = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim ANFLLMEBBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? AEILMMAKGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, LMCHIGAEEAF, CancellationToken, Task<Texture2D>>? OLBKFPCIPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? EAJOJIGGMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly LMIGCBLKHKA<CFKEAOABNDH, Texture2D> NJKKLLAFJGO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F67FA0", Offset = "0x4F673A0", VA = "0x184F67FA0")]
	public GOFDOFEILIO(Func<TImageId, CancellationToken, Task<byte[]>> POPACJDFGMN, [Optional] Func<TImageId, string>? KIOFLBCALAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4F68160", Offset = "0x4F67560", VA = "0x184F68160")]
	public GOFDOFEILIO(Func<TImageId, LMCHIGAEEAF, CancellationToken, Task<Texture2D>> INMPCJOHLLM, [Optional] Func<TImageId, string>? KIOFLBCALAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F67E10", Offset = "0x4F67210", VA = "0x184F67E10")]
	private GOFDOFEILIO(Func<TImageId, CancellationToken, Task<byte[]>>? POPACJDFGMN, Func<TImageId, LMCHIGAEEAF, CancellationToken, Task<Texture2D>>? INMPCJOHLLM, Func<TImageId, string>? KIOFLBCALAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F66FB0", Offset = "0x4F663B0", VA = "0x184F66FB0")]
	public JAKNEJKGEIC<Texture2D> ALLNKMDMIAE(TImageId GEMGGBHDAAP, LMCHIGAEEAF CIGFBGJDJHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4F67390", Offset = "0x4F66790", VA = "0x184F67390")]
	public void BLEAMPGIOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4F673C0", Offset = "0x4F667C0", VA = "0x184F673C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4F675A0", Offset = "0x4F669A0", VA = "0x184F675A0")]
	[AsyncStateMachine(typeof(GOFDOFEILIO<>.OIDGPAGPONC))]
	private Task<Texture2D> IFDDOGOCAAH(CFKEAOABNDH AEPHGJBOGJL, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4F67990", Offset = "0x4F66D90", VA = "0x184F67990")]
	[AsyncStateMachine(typeof(GOFDOFEILIO<>.KLEHKJLIIGE))]
	private Task<Texture2D> NPJBLGHFCFL(byte[] JFCAKFJAMKM, LMCHIGAEEAF CIGFBGJDJHH, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4F67380", Offset = "0x4F66780", VA = "0x184F67380")]
	private void BGMGIAEFDDC(Texture2D IOFLDLKHGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4F677A0", Offset = "0x4F66BA0", VA = "0x184F677A0")]
	private bool JJHBMELPAAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4F676F0", Offset = "0x4F66AF0", VA = "0x184F676F0")]
	private bool JICMOCIHPFF(byte[] JFCAKFJAMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4F678A0", Offset = "0x4F66CA0", VA = "0x184F678A0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GOFDOFEILIO<>.EJMEFJCGMPA))]
	internal static Task MOJNKNOMIGO(IDisposable KBPIMPGDHGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum LMCHIGAEEAF : byte
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
