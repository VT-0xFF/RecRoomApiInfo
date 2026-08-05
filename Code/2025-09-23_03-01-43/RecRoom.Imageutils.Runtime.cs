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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x8537E10", Offset = "0x8536410", VA = "0x188537E10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
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
		[Cpp2IlInjected.Address(RVA = "0x8534F90", Offset = "0x8533590", VA = "0x188534F90")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CPKPABPGCMH
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
			[Cpp2IlInjected.Address(RVA = "0x8538570", Offset = "0x8536B70", VA = "0x188538570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8538560", Offset = "0x8536B60", VA = "0x188538560")]
		public Resolution(uint GBNAKFLHCOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
		public Resolution(uint GBNAKFLHCOE, uint ODEKEFJCIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8538470", Offset = "0x8536A70", VA = "0x188538470")]
		public static Resolution ODENFLGLKHE(Resolution[] PLMLGIGGGNL, Resolution IDNJACFFBFO, int HKBHFFANFFG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class DMFFFJFPJDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution OFIDMFLGBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? OCIPENLABEH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint GBNAKFLHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8535630", Offset = "0x8533C30", VA = "0x188535630")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution IPPNMNPBGOM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8535640", Offset = "0x8533C40", VA = "0x188535640")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF9F550", Offset = "0xF9DB50", VA = "0x180F9F550")]
		public DMFFFJFPJDM(Resolution OFIDMFLGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85354B0", Offset = "0x8533AB0", VA = "0x1885354B0")]
		private static Resolution IIDJMDEMPHC(Resolution OCIPENLABEH, NFHJOJBCEKF LJFHHJDEIPG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FAHDINNFIME
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution KCNEAEAAPHA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution PCBHFGBJKGN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution KJLFMBBCBLP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution LIGHLMHLBPO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution ADHPEPHJHHO;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution DCDIOMIIIAL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] MLCMMNNKCIE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class DGPPFPKOPJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution KCNEAEAAPHA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution PCBHFGBJKGN;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution KJLFMBBCBLP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution LIGHLMHLBPO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution ADHPEPHJHHO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution DCDIOMIIIAL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal static readonly Resolution[] MLCMMNNKCIE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class HEEGFCNOAKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution KCNEAEAAPHA;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution PCBHFGBJKGN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution KJLFMBBCBLP;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution LIGHLMHLBPO;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Resolution ADHPEPHJHHO;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly Resolution DCDIOMIIIAL;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal static readonly Resolution[] MLCMMNNKCIE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class PFOCKBADNFD
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly Resolution KCNEAEAAPHA;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly Resolution PCBHFGBJKGN;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly Resolution KJLFMBBCBLP;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly Resolution LIGHLMHLBPO;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly Resolution ADHPEPHJHHO;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static readonly Resolution DCDIOMIIIAL;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal static readonly Resolution[] MLCMMNNKCIE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class CNLGMAFOPBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly Resolution IKNHIONKOLB;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly Resolution DFLCCJMEFOI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly Resolution APALKNHHBEC;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly Resolution EFHBEOCFCPB;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly Resolution NKJEJDEPJGP;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly Resolution KCNEAEAAPHA;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly Resolution PCBHFGBJKGN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly Resolution KJLFMBBCBLP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly Resolution LIGHLMHLBPO;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly Resolution ADHPEPHJHHO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly Resolution DCDIOMIIIAL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal static readonly Resolution[] MLCMMNNKCIE;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85348C0", Offset = "0x8532EC0", VA = "0x1885348C0")]
		public static Resolution DJGOBMKELHO(uint EPJLFMHGDCC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution MHFNICDCCKC;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class DGEKIKOPOMH
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8534FB0", Offset = "0x85335B0", VA = "0x188534FB0")]
	public static bool GAKKDIMPOAH(byte[] CDDIADBJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8534FF0", Offset = "0x85335F0", VA = "0x188534FF0")]
	public static bool NBAPOIKDFIG(byte[] CDDIADBJAOB, [Out] int EPJLFMHGDCC, [Out] int GHDHPPBLHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8535200", Offset = "0x8533800", VA = "0x188535200")]
	private static int OPGMHEPIIKO(byte[] CDDIADBJAOB, int NDMFOILAFKD, [Out] ushort FPCHJKGGPNN)
	{
		return default(int);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[Flags]
		public enum HIGNGBIHIOM : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private class HBKHIBLOCOD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private string NDIENANOGEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public Texture2D JAKHKFPCPLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public HIGNGBIHIOM PPLCBMBDBOG;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8535C00", Offset = "0x8534200", VA = "0x188535C00")]
			public HBKHIBLOCOD(string NDIENANOGEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2010", Offset = "0x1CF0610", VA = "0x181CF2010")]
			public HBKHIBLOCOD(string NDIENANOGEK, Texture2D BDFJHOHMCFM, HIGNGBIHIOM GJACDPFPPIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8535BC0", Offset = "0x85341C0", VA = "0x188535BC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OJCANOJJHAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public HIGNGBIHIOM textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public OJCANOJJHAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8537E90", Offset = "0x8536490", VA = "0x188537E90")]
			internal void JMCKPNBBDHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class MPHPDDCBMME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public MPHPDDCBMME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8536D20", Offset = "0x8535320", VA = "0x188536D20")]
			internal KPLOBGALMKB NBOJGGCMJAM(Texture2D t2d)
			{
				return default(KPLOBGALMKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KPCOLJNOOGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public KPCOLJNOOGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8536CA0", Offset = "0x85352A0", VA = "0x188536CA0")]
			internal void ILACHNJADFE()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private EEOEHGFNDGC<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private HBKHIBLOCOD _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private EEOEHGFNDGC<KPLOBGALMKB> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private EEOEHGFNDGC<KPLOBGALMKB> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAFE8C0", Offset = "0xAFCEC0", VA = "0x180AFE8C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private HBKHIBLOCOD memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8537C60", Offset = "0x8536260", VA = "0x188537C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8537B90", Offset = "0x8536190", VA = "0x188537B90")]
		public ManagedTexture(string NDIENANOGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8537BF0", Offset = "0x85361F0", VA = "0x188537BF0")]
		public ManagedTexture(string NDIENANOGEK, bool EKCFIBIPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8536D60", Offset = "0x8535360", VA = "0x188536D60")]
		public void AMEINNNEMFB(RenderTexture FLPBINDAIKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8537840", Offset = "0x8535E40", VA = "0x188537840")]
		public EEOEHGFNDGC<Texture2D> JLLLJOPHKMM(HIGNGBIHIOM GJACDPFPPIA, bool OIACBNEMLLK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8536E40", Offset = "0x8535440", VA = "0x188536E40")]
		public EEOEHGFNDGC<KPLOBGALMKB> CDGKKPGPBNP(bool OIACBNEMLLK = false, int HMBDMADOFCK = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8536FE0", Offset = "0x85355E0", VA = "0x188536FE0")]
		public EEOEHGFNDGC<KPLOBGALMKB> DGEHJALPBJL(bool OIACBNEMLLK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85372F0", Offset = "0x85358F0", VA = "0x1885372F0")]
		private static EEOEHGFNDGC<Texture2D> HBAFBKHINMN(string NDIENANOGEK, RenderTexture FLPBINDAIKE, Texture2D PNJKLNKHPEJ, bool OIACBNEMLLK, HIGNGBIHIOM CAOLIPOOLHD = HIGNGBIHIOM.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8536DA0", Offset = "0x85353A0", VA = "0x188536DA0")]
		public void BKONPJNGOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85372E0", Offset = "0x85358E0", VA = "0x1885372E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8537B30", Offset = "0x8536130", VA = "0x188537B30")]
		[CompilerGenerated]
		private EEOEHGFNDGC<byte[]> MDEJOCCGLBL(Texture2D IJFJGCACPLD)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PEJHFFPKEED
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct NMJDHNFAKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8537D10", Offset = "0x8536310", VA = "0x188537D10")]
		public unsafe static extern void LBFMNGAIPHN(void* JLNNOPJMCHA, void* DNPKCGAKHLK, bool BBGKEIIEHHH, bool AHJCDCNKBEO, bool MIGKOJAIILH, [Out] int EPJLFMHGDCC, [Out] int GHDHPPBLHGA, [Out] bool BDMLBMDIPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class HHCOPMHAGLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool bgr;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HHCOPMHAGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8535E70", Offset = "0x8534470", VA = "0x188535E70")]
		internal void PPCGAOHKBEP(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HMFOOBGPFDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85362A0", Offset = "0x85348A0", VA = "0x1885362A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85364C0", Offset = "0x8534AC0", VA = "0x1885364C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KFBMHHIIJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KFBMHHIIJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8536C60", Offset = "0x8535260", VA = "0x188536C60")]
		internal void HMIIKEBCGHB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct HOGOKDCOKIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public bool hasAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private KFBMHHIIJGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8536530", Offset = "0x8534B30", VA = "0x188536530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8536BF0", Offset = "0x85351F0", VA = "0x188536BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly bool BKKPDBONFIG;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
	public static bool FGBANHHPLKE(byte[] KCIMOGGLEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8537ED0", Offset = "0x85364D0", VA = "0x188537ED0")]
	[AsyncStateMachine(typeof(HMFOOBGPFDP))]
	public static Task<Texture2D> AKDEACOMBJG(byte[] KCIMOGGLEEK, bool BBDAOJBBNBC = false, bool KOFABPNAEMH = false, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85380B0", Offset = "0x85366B0", VA = "0x1885380B0")]
	[AsyncStateMachine(typeof(HOGOKDCOKIB))]
	private static Task<Texture2D> EPJDCKAMBCB(int EPJLFMHGDCC, int GHDHPPBLHGA, bool CDLHCJNENPN, bool BBDAOJBBNBC, bool KOFABPNAEMH, Action<NativeArray<byte>> FMMOGFEIGMG, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8538010", Offset = "0x8536610", VA = "0x188538010")]
	private static TextureFormat CGCFBOGFICN(bool CDLHCJNENPN)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal enum OBLJNKFDEIG
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	RGB,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	BGR,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	RGBA,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ABGR
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class BEEEFBOPNJA
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8534240", Offset = "0x8532840", VA = "0x188534240")]
	public static bool FCGNHIIMDKL(byte[] CDDIADBJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x85345B0", Offset = "0x8532BB0", VA = "0x1885345B0")]
	public static void OGPPJGFOKCO(byte[] CDDIADBJAOB, [Out] int EPJLFMHGDCC, [Out] int GHDHPPBLHGA, [Out] OBLJNKFDEIG OFCLANOKPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8534280", Offset = "0x8532880", VA = "0x188534280")]
	private static uint GIJECFMGMIP(byte[] CDDIADBJAOB, int GHOFJOJMCOI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85343B0", Offset = "0x85329B0", VA = "0x1885343B0")]
	private static ulong MGJGAHLKCAK(byte[] CDDIADBJAOB, int GHOFJOJMCOI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HJLPFIBIIJP
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8536010", Offset = "0x8534610", VA = "0x188536010")]
	public static RenderTexture NCOPCIOHJIK(int EPJLFMHGDCC, int GHDHPPBLHGA, int NJPDGMBHEEB, Camera ADKEJHHNPHO, RenderTextureMemoryless BIBJKMHPMGN = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8536240", Offset = "0x8534840", VA = "0x188536240")]
	public static void OMKJDLEEKFI(RenderTexture FLPBINDAIKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class FLAHNBBMEFI<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private readonly struct KHKKINPLKBO : IEquatable<KHKKINPLKBO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly TImageId FPEABGLNMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly FGGLLNLCJFK FEODKMBJGMC;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1B0CD90", Offset = "0x1B0B390", VA = "0x181B0CD90")]
		public KHKKINPLKBO(TImageId HAELBKGFDIJ, FGGLLNLCJFK BHFJCPJMFOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x56796E0", Offset = "0x5677CE0", VA = "0x1856796E0", Slot = "4")]
		public bool Equals(FLAHNBBMEFI<TImageId>.KHKKINPLKBO AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x56795D0", Offset = "0x5677BD0", VA = "0x1856795D0", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x56797E0", Offset = "0x5677DE0", VA = "0x1856797E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5679A50", Offset = "0x5678050", VA = "0x185679A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JEFBPNBNBHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GCAHIIHOLJP<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JEFBPNBNBHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x54BBBC0", Offset = "0x54BA1C0", VA = "0x1854BBBC0")]
		internal void GLCEDGGGNGG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct ILNALIEBFAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KHKKINPLKBO cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public FLAHNBBMEFI<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private FGGLLNLCJFK <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x529D260", Offset = "0x529B860", VA = "0x18529D260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x529E080", Offset = "0x529C680", VA = "0x18529E080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct ACFKAMFFHEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FGGLLNLCJFK textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FLAHNBBMEFI<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool <usePointFiltering>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool <useClampWrapMode>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x531F6D0", Offset = "0x531DCD0", VA = "0x18531F6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x531FE20", Offset = "0x531E420", VA = "0x18531FE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct IPFNHPCGBPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x52AB540", Offset = "0x52A9B40", VA = "0x1852AB540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x52AB780", Offset = "0x52A9D80", VA = "0x1852AB780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private const int KNEMMOECKEK = 1;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly SemaphoreSlim FMNBEPOCJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? BDMEAFCECJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Func<TImageId, FGGLLNLCJFK, CancellationToken, Task<Texture2D>>? MANHCCDKHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly Func<TImageId, string>? JBPHOMDBDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly DCHHBFDIKBJ<KHKKINPLKBO, Texture2D> DAGAPICMIBL;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5021030", Offset = "0x501F630", VA = "0x185021030")]
	public FLAHNBBMEFI(Func<TImageId, CancellationToken, Task<byte[]>> MGIEAKICDFI, [Optional] Func<TImageId, string>? MAFKENKFKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5021060", Offset = "0x501F660", VA = "0x185021060")]
	public FLAHNBBMEFI(Func<TImageId, FGGLLNLCJFK, CancellationToken, Task<Texture2D>> EMCLOHJPCCE, [Optional] Func<TImageId, string>? MAFKENKFKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5021220", Offset = "0x501F820", VA = "0x185021220")]
	private FLAHNBBMEFI(Func<TImageId, CancellationToken, Task<byte[]>>? MGIEAKICDFI, Func<TImageId, FGGLLNLCJFK, CancellationToken, Task<Texture2D>>? EMCLOHJPCCE, Func<TImageId, string>? MAFKENKFKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5020A60", Offset = "0x501F060", VA = "0x185020A60")]
	public OFBDOHFHPFI<Texture2D> LPOKKBOJPBB(TImageId HMDHENFEMJM, FGGLLNLCJFK KBPBLFEJICP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5020780", Offset = "0x501ED80", VA = "0x185020780")]
	public void GIJHAKBDGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5020440", Offset = "0x501EA40", VA = "0x185020440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5020900", Offset = "0x501EF00", VA = "0x185020900")]
	[AsyncStateMachine(typeof(FLAHNBBMEFI<>.ILNALIEBFAM))]
	private Task<Texture2D> LPCBJHECJML(KHKKINPLKBO KAIPGEJNEGO, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x50202E0", Offset = "0x501E8E0", VA = "0x1850202E0")]
	[AsyncStateMachine(typeof(FLAHNBBMEFI<>.ACFKAMFFHEB))]
	private Task<Texture2D> CIDEPMABENM(byte[] KCIMOGGLEEK, FGGLLNLCJFK KBPBLFEJICP, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5020590", Offset = "0x501EB90", VA = "0x185020590")]
	private void EKIPMEADLEG(Texture2D BDFJHOHMCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5020E60", Offset = "0x501F460", VA = "0x185020E60")]
	private bool MNJMGMNLGLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x50204E0", Offset = "0x501EAE0", VA = "0x1850204E0")]
	private bool EHMGODGBBOC(byte[] KCIMOGGLEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5020690", Offset = "0x501EC90", VA = "0x185020690")]
	[AsyncStateMachine(typeof(FLAHNBBMEFI<>.IPFNHPCGBPP))]
	[CompilerGenerated]
	internal static Task GIIPCMBOBNN(IDisposable JHIJBKFDDAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[Flags]
public enum FGGLLNLCJFK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CompressTexture = 4,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	UseNearestTextureFiltering = 8,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
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
