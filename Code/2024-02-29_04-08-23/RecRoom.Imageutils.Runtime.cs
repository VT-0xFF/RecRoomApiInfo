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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6012930", Offset = "0x6011730", VA = "0x186012930")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
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
		[Cpp2IlInjected.Address(RVA = "0x600FF50", Offset = "0x600ED50", VA = "0x18600FF50")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum AHKPPKGNKPM
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
public interface EIGPPEBEGCE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AHKPPKGNKPM EKEDFHMBJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BGICFOFLEGO(VertexAttributeFormat GDBGIPNHFLM, int OEJAHHLNOBG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DIFEMOKAIDJ
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
			[Cpp2IlInjected.Address(RVA = "0x6012B30", Offset = "0x6011930", VA = "0x186012B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6012B20", Offset = "0x6011920", VA = "0x186012B20")]
		public Resolution(uint AHPBAINPGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA58C60", Offset = "0xA57A60", VA = "0x180A58C60")]
		public Resolution(uint AHPBAINPGNA, uint KMGCEBLELOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6012A30", Offset = "0x6011830", VA = "0x186012A30")]
		public static Resolution FPLCDEOCDCK(Resolution[] BAPOGPMCDNA, Resolution CGPKKCDAEHB, int AGKJMJNKAAE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class BMMAEGDGCCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution BPNLAEIEGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? PKDLNDFKGNF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint AHPBAINPGNA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x600F7C0", Offset = "0x600E5C0", VA = "0x18600F7C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint KMGCEBLELOI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x600FC90", Offset = "0x600EA90", VA = "0x18600FC90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution LJEPAPGDIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x600F7D0", Offset = "0x600E5D0", VA = "0x18600F7D0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE80E10", Offset = "0xE7FC10", VA = "0x180E80E10")]
		public BMMAEGDGCCK(Resolution BPNLAEIEGDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x600FB10", Offset = "0x600E910", VA = "0x18600FB10")]
		private static Resolution KIDHIOHECGC(Resolution PKDLNDFKGNF, AHKPPKGNKPM CNFOGBGEGPG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class LOKPMFCDHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution LMGDNJILGFM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution KLGIEKFPECO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution BDJDGNDGKHA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution LDMEDONIHAM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution LJOBJHPKINB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution GFOMHNFDEGN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] APKOLLEAHHH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class BILHLFDAOKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution KLDNHEFFAGI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution EACNBMAMPBB;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution DCFNENMIDPJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution LGMGKHJMKJD;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution FCOMGIPMNIA;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] APKOLLEAHHH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x600F470", Offset = "0x600E270", VA = "0x18600F470")]
		public static Resolution FKDMGLJKKPJ(uint LILDALMGEEJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution HHHOCELGADM;
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[Flags]
		public enum PACGPPAFINJ : byte
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
		private class BGOEFKCECGC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string OHHBGJPCFJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D FIJBHBNFEFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public PACGPPAFINJ HBMCLFDMDCD;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x600F420", Offset = "0x600E220", VA = "0x18600F420")]
			public BGOEFKCECGC(string OHHBGJPCFJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3D70", Offset = "0x3AB2B70", VA = "0x183AB3D70")]
			public BGOEFKCECGC(string OHHBGJPCFJD, Texture2D BNLLLONAGAK, PACGPPAFINJ ELHLKDAAIFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x600F3E0", Offset = "0x600E1E0", VA = "0x18600F3E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class LGECEFNOGPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public PACGPPAFINJ textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public LGECEFNOGPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x60113B0", Offset = "0x60101B0", VA = "0x1860113B0")]
			internal void MEEOELGGIAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class HNIDNFAHCLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public HNIDNFAHCLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6011130", Offset = "0x600FF30", VA = "0x186011130")]
			internal CLDDOHFKNOP FAMDEGNFDJI(Texture2D t2d)
			{
				return default(CLDDOHFKNOP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ODBLMJMHBPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public ODBLMJMHBPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x60129B0", Offset = "0x60117B0", VA = "0x1860129B0")]
			internal void HOBKDLBNMDJ()
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
		private DOPLGHLIBGN<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private BGOEFKCECGC _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private DOPLGHLIBGN<CLDDOHFKNOP> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private DOPLGHLIBGN<CLDDOHFKNOP> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F6320", Offset = "0x7F5120", VA = "0x1807F6320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BGOEFKCECGC memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6012510", Offset = "0x6011310", VA = "0x186012510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6012440", Offset = "0x6011240", VA = "0x186012440")]
		public ManagedTexture(string OHHBGJPCFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60124A0", Offset = "0x60112A0", VA = "0x1860124A0")]
		public ManagedTexture(string OHHBGJPCFJD, bool MBNOOJJBBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6012000", Offset = "0x6010E00", VA = "0x186012000")]
		public void EBGPGIAJMNL(RenderTexture DEFAOJHOPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6011D00", Offset = "0x6010B00", VA = "0x186011D00")]
		public DOPLGHLIBGN<Texture2D> CAGFPPINJJO(PACGPPAFINJ ELHLKDAAIFK, bool CCJGCHPOCDL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6011B60", Offset = "0x6010960", VA = "0x186011B60")]
		public DOPLGHLIBGN<CLDDOHFKNOP> ALIEPBMMIJG(bool CCJGCHPOCDL = false, int BMHCFONALEJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6012140", Offset = "0x6010F40", VA = "0x186012140")]
		public DOPLGHLIBGN<CLDDOHFKNOP> NHEBACLPJME(bool CCJGCHPOCDL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6011610", Offset = "0x6010410", VA = "0x186011610")]
		private static DOPLGHLIBGN<Texture2D> AAKCBEBGIIO(string OHHBGJPCFJD, RenderTexture DEFAOJHOPAN, Texture2D CODPLLDBDLO, bool CCJGCHPOCDL, PACGPPAFINJ FJBGMKCJAMD = PACGPPAFINJ.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60120A0", Offset = "0x6010EA0", VA = "0x1860120A0")]
		public void JPIFOAJHPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6011FF0", Offset = "0x6010DF0", VA = "0x186011FF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6012040", Offset = "0x6010E40", VA = "0x186012040")]
		[CompilerGenerated]
		private DOPLGHLIBGN<byte[]> GEGMAOBEGEL(Texture2D CNPAPGLAEJL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NNGNIJGHMPA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct CFAIDBBKLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x600FE50", Offset = "0x600EC50", VA = "0x18600FE50")]
		public unsafe static extern void HJHHNMGONKE(void* KBFJLDAOAJP, void* JJHNOAEPPEK, bool IAPPPJDEIHO, bool JHLMPDDEBKK, bool OCBLKNNHFAB, [Out] int LILDALMGEEJ, [Out] int MCENAHCKOAK, [Out] bool DOBKAKIDPLD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CCPBKBNOJDI
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
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CCPBKBNOJDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x600FCB0", Offset = "0x600EAB0", VA = "0x18600FCB0")]
		internal void AFLNBIINAPG(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct DCEIJHIHMIC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x600FF70", Offset = "0x600ED70", VA = "0x18600FF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6010190", Offset = "0x600EF90", VA = "0x186010190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LDOEJBFALFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LDOEJBFALFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6011370", Offset = "0x6010170", VA = "0x186011370")]
		internal void MJHCDDNEJOF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HEMHIFJNALM : IAsyncStateMachine
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
		private LDOEJBFALFM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6010A00", Offset = "0x600F800", VA = "0x186010A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60110C0", Offset = "0x600FEC0", VA = "0x1860110C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool KPILOBJAAIJ;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	public static bool EOLBOJJJNPF(byte[] GOODJIFNCAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6012660", Offset = "0x6011460", VA = "0x186012660")]
	[AsyncStateMachine(typeof(DCEIJHIHMIC))]
	public static Task<Texture2D> DPLJMMLPJGK(byte[] GOODJIFNCAC, bool PKOLAFDHPEA = false, bool JEIPPEPFKNL = false, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60127A0", Offset = "0x60115A0", VA = "0x1860127A0")]
	[AsyncStateMachine(typeof(HEMHIFJNALM))]
	private static Task<Texture2D> KJAKCADNANO(int LILDALMGEEJ, int MCENAHCKOAK, bool EAGFAEHOHDD, bool PKOLAFDHPEA, bool JEIPPEPFKNL, Action<NativeArray<byte>> NJMDLKPHOAO, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60125C0", Offset = "0x60113C0", VA = "0x1860125C0")]
	private static TextureFormat BNOAFEPLJID(bool EAGFAEHOHDD)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal enum DFNBPKFGLNL
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
internal static class DOPHIFEODML
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60105D0", Offset = "0x600F3D0", VA = "0x1860105D0")]
	public static void GGABKJOAOMJ(byte[] OMHIFBJFAGA, [Out] int LILDALMGEEJ, [Out] int MCENAHCKOAK, [Out] DFNBPKFGLNL GDBGIPNHFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60108D0", Offset = "0x600F6D0", VA = "0x1860108D0")]
	private static uint GLELHLCHKNP(byte[] OMHIFBJFAGA, int IFADIJDFJBM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60103D0", Offset = "0x600F1D0", VA = "0x1860103D0")]
	private static ulong EFFIGDCMADF(byte[] OMHIFBJFAGA, int IFADIJDFJBM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KFNPBOBDGFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6011170", Offset = "0x600FF70", VA = "0x186011170")]
	public static RenderTexture EHNCNIEHJHA(int LILDALMGEEJ, int MCENAHCKOAK, int OCFGNBFHNAN, Camera MPBFBPKALIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6011310", Offset = "0x6010110", VA = "0x186011310")]
	public static void GPLIAIJOONH(RenderTexture DEFAOJHOPAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class MNJKINHNHKA<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private readonly struct NDFMEGBJKFI : IEquatable<NDFMEGBJKFI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId MCDPKLFLLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly OJMDAFAHIJP NOKJODFCLON;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3B96140", Offset = "0x3B94F40", VA = "0x183B96140")]
		public NDFMEGBJKFI(TImageId JCMGBFKGKLO, OJMDAFAHIJP MOPDPGBDKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3E5F720", Offset = "0x3E5E520", VA = "0x183E5F720", Slot = "4")]
		public bool Equals(MNJKINHNHKA<TImageId>.NDFMEGBJKFI FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3E5F7C0", Offset = "0x3E5E5C0", VA = "0x183E5F7C0", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3E5F9D0", Offset = "0x3E5E7D0", VA = "0x183E5F9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E5FB70", Offset = "0x3E5E970", VA = "0x183E5FB70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EMLNHHNFLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public PPOFINEEFFF<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EMLNHHNFLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3259150", Offset = "0x3257F50", VA = "0x183259150")]
		internal void CEEMPEKNGIE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct NBBJOPNLLJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NDFMEGBJKFI cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public MNJKINHNHKA<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private OJMDAFAHIJP <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3E4C4A0", Offset = "0x3E4B2A0", VA = "0x183E4C4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3E4CBA0", Offset = "0x3E4B9A0", VA = "0x183E4CBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct EILHJKFFMCM : IAsyncStateMachine
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
		public OJMDAFAHIJP textureLoadOptions;

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
		[Cpp2IlInjected.Address(RVA = "0x324B1C0", Offset = "0x3249FC0", VA = "0x18324B1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x324B850", Offset = "0x324A650", VA = "0x18324B850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct HOFPJDEKKFH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x37B8210", Offset = "0x37B7010", VA = "0x1837B8210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x37B85D0", Offset = "0x37B73D0", VA = "0x1837B85D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int AAEHLNNJHLL = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim KNKDNADBCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? MIFFBANAJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, OJMDAFAHIJP, CancellationToken, Task<Texture2D>>? GGCGBHBNPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? JAHDACFKBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly INMKHCLBMGI<NDFMEGBJKFI, Texture2D> NHCAKBMIDEF;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFCD0", Offset = "0x3DFEAD0", VA = "0x183DFFCD0")]
	public MNJKINHNHKA(Func<TImageId, CancellationToken, Task<byte[]>> KGJADBKNHHG, [Optional] Func<TImageId, string>? JCBOGNFPPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFCA0", Offset = "0x3DFEAA0", VA = "0x183DFFCA0")]
	public MNJKINHNHKA(Func<TImageId, OJMDAFAHIJP, CancellationToken, Task<Texture2D>> FNGBDLBCINN, [Optional] Func<TImageId, string>? JCBOGNFPPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFD00", Offset = "0x3DFEB00", VA = "0x183DFFD00")]
	private MNJKINHNHKA(Func<TImageId, CancellationToken, Task<byte[]>>? KGJADBKNHHG, Func<TImageId, OJMDAFAHIJP, CancellationToken, Task<Texture2D>>? FNGBDLBCINN, Func<TImageId, string>? JCBOGNFPPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF530", Offset = "0x3DFE330", VA = "0x183DFF530")]
	public PPOFINEEFFF<Task<Texture2D>> JBIMBFCKBJC(TImageId LMOCCFFILJG, OJMDAFAHIJP LNMOJMMLDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DFEEA0", Offset = "0x3DFDCA0", VA = "0x183DFEEA0")]
	public void EECIBLFBFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DFEE00", Offset = "0x3DFDC00", VA = "0x183DFEE00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF020", Offset = "0x3DFDE20", VA = "0x183DFF020")]
	[AsyncStateMachine(typeof(MNJKINHNHKA<>.NBBJOPNLLJK))]
	private Task<Texture2D> EJPHOOFPICO(NDFMEGBJKFI ICMGPMFJFCH, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF6D0", Offset = "0x3DFE4D0", VA = "0x183DFF6D0")]
	[AsyncStateMachine(typeof(MNJKINHNHKA<>.EILHJKFFMCM))]
	private Task<Texture2D> NIMIKINGPPL(byte[] GOODJIFNCAC, OJMDAFAHIJP LNMOJMMLDKI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF180", Offset = "0x3DFDF80", VA = "0x183DFF180")]
	private void EKOOPKKKFIC(Texture2D BNLLLONAGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF190", Offset = "0x3DFDF90", VA = "0x183DFF190")]
	[AsyncStateMachine(typeof(MNJKINHNHKA<>.HOFPJDEKKFH))]
	[CompilerGenerated]
	internal static Task GICBMJGJGME(IDisposable OGDKEFDHPIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum OJMDAFAHIJP : byte
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
