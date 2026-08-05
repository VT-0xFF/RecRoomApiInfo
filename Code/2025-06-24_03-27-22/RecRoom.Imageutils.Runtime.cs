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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DFFDA0", Offset = "0x7DFE9A0", VA = "0x187DFFDA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DFD1C0", Offset = "0x7DFBDC0", VA = "0x187DFD1C0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ICHMKCEDBMN
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
			[Cpp2IlInjected.Address(RVA = "0x7E00970", Offset = "0x7DFF570", VA = "0x187E00970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E00960", Offset = "0x7DFF560", VA = "0x187E00960")]
		public Resolution(uint KFGAJBKADFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
		public Resolution(uint KFGAJBKADFK, uint FEABMDLFEMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E00870", Offset = "0x7DFF470", VA = "0x187E00870")]
		public static Resolution ADMEADCOPJG(Resolution[] LEKHKJDBHCI, Resolution IDCMNADCEHF, int GGGHAMEDPGM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class PHAEPFAICGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution LLJGGJKMEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? NGIMLGHCPEA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint KFGAJBKADFK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7E005D0", Offset = "0x7DFF1D0", VA = "0x187E005D0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution ANPAOLFKPPM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7E00280", Offset = "0x7DFEE80", VA = "0x187E00280")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEA32A0", Offset = "0xEA1EA0", VA = "0x180EA32A0")]
		public PHAEPFAICGI(Resolution LLJGGJKMEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E00100", Offset = "0x7DFED00", VA = "0x187E00100")]
		private static Resolution CBFJEDINMDK(Resolution NGIMLGHCPEA, LMLLCBFPCMH IDGMPBENFOE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CJACGLMNJDD
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution APAMBCJBENC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution GIPPCCPIEAA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution MCJMJJIJEJM;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution LAAKMKBNPBM;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution DKFAMDDADEC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution EKBNNFHDBPP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] PFGLKNOOICL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ICIJAGKHGKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DJPEHDHCIID;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution CCOPCJKCKFP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution ALPEJFHFJME;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution MKADPIGPFPK;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OADCADFPKJL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] PFGLKNOOICL;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDA70", Offset = "0x7DFC670", VA = "0x187DFDA70")]
		public static Resolution MMGFPALPNBA(uint KHDFLCEFJLK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution NJHDNADILMI;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class OPILBKNHNGM
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DFFE20", Offset = "0x7DFEA20", VA = "0x187DFFE20")]
	public static bool AMNNFIEAEKO(byte[] PEDMEJIDLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7DFFE60", Offset = "0x7DFEA60", VA = "0x187DFFE60")]
	public static bool DAKDNNKBKHI(byte[] PEDMEJIDLNB, [Out] int KHDFLCEFJLK, [Out] int DNFPAMDBHCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E00070", Offset = "0x7DFEC70", VA = "0x187E00070")]
	private static int MNNICLDEINP(byte[] PEDMEJIDLNB, int DPCFFPEBOPM, [Out] ushort CCHGCHFEIHI)
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
		public enum HFNKKIBJIFL : byte
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
		private class AHKMAJIGPEP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string LAOCJKNALFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D GDPMNGNJLLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HFNKKIBJIFL LINAGNPILFL;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7DFCF40", Offset = "0x7DFBB40", VA = "0x187DFCF40")]
			public AHKMAJIGPEP(string LAOCJKNALFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1B203A0", Offset = "0x1B1EFA0", VA = "0x181B203A0")]
			public AHKMAJIGPEP(string LAOCJKNALFF, Texture2D BDAIEAKKDFD, HFNKKIBJIFL CAEECDABOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7DFCF00", Offset = "0x7DFBB00", VA = "0x187DFCF00", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EPIHJIGLMFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public HFNKKIBJIFL textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public EPIHJIGLMFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD1E0", Offset = "0x7DFBDE0", VA = "0x187DFD1E0")]
			internal void KGMECAFILKK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class CMGCPPAAKME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public CMGCPPAAKME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD180", Offset = "0x7DFBD80", VA = "0x187DFD180")]
			internal PAOGPHBLDNG ECIOCIBIFCN(Texture2D t2d)
			{
				return default(PAOGPHBLDNG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class NDPLCELOPMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public NDPLCELOPMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7DFFBE0", Offset = "0x7DFE7E0", VA = "0x187DFFBE0")]
			internal void PBLNNIMBLMK()
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
		private KLHBLGBFFDH<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private AHKMAJIGPEP _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KLHBLGBFFDH<PAOGPHBLDNG> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private KLHBLGBFFDH<PAOGPHBLDNG> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAA8AD0", Offset = "0xAA76D0", VA = "0x180AA8AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private AHKMAJIGPEP memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7DFFB30", Offset = "0x7DFE730", VA = "0x187DFFB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFA60", Offset = "0x7DFE660", VA = "0x187DFFA60")]
		public ManagedTexture(string LAOCJKNALFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFAC0", Offset = "0x7DFE6C0", VA = "0x187DFFAC0")]
		public ManagedTexture(string LAOCJKNALFF, bool EHPJMLKPPJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF730", Offset = "0x7DFE330", VA = "0x187DFF730")]
		public void MBGKFADDOHK(RenderTexture KOGCAGMECAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF770", Offset = "0x7DFE370", VA = "0x187DFF770")]
		public KLHBLGBFFDH<Texture2D> MNJNHDFFMHD(HFNKKIBJIFL CAEECDABOBH, bool LFACJMDIDHL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEF40", Offset = "0x7DFDB40", VA = "0x187DFEF40")]
		public KLHBLGBFFDH<PAOGPHBLDNG> DMGNBDCONMO(bool LFACJMDIDHL = false, int HGKNOMPFOKC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEC50", Offset = "0x7DFD850", VA = "0x187DFEC50")]
		public KLHBLGBFFDH<PAOGPHBLDNG> DIGNJLOBHHF(bool LFACJMDIDHL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF1E0", Offset = "0x7DFDDE0", VA = "0x187DFF1E0")]
		private static KLHBLGBFFDH<Texture2D> HEIINNAHKNP(string LAOCJKNALFF, RenderTexture KOGCAGMECAM, Texture2D IKNPNJNNEKI, bool LFACJMDIDHL, HFNKKIBJIFL JCOAOOCLABB = HFNKKIBJIFL.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF140", Offset = "0x7DFDD40", VA = "0x187DFF140")]
		public void FDCFCEMMCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF0D0", Offset = "0x7DFDCD0", VA = "0x187DFF0D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF0E0", Offset = "0x7DFDCE0", VA = "0x187DFF0E0")]
		[CompilerGenerated]
		private KLHBLGBFFDH<byte[]> EFCOBENHGMF(Texture2D OABFAMCIKPC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IJICOPECDOI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct NNMNECIFJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFCA0", Offset = "0x7DFE8A0", VA = "0x187DFFCA0")]
		public unsafe static extern void HBLIILBOGNF(void* CKDKPONBOFO, void* JAKICABDOHC, bool MKKJMEJLODE, bool GCPODJPFBCG, bool AJCOCKFCCJN, [Out] int KHDFLCEFJLK, [Out] int DNFPAMDBHCB, [Out] bool LJEHNPIHIBB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LMOFAJEPBJB
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
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LMOFAJEPBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE380", Offset = "0x7DFCF80", VA = "0x187DFE380")]
		internal void CGLFLEGNPIN(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JENAINDJBCE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DFE0F0", Offset = "0x7DFCCF0", VA = "0x187DFE0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE310", Offset = "0x7DFCF10", VA = "0x187DFE310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NHMKMIBKCDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public NHMKMIBKCDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFC60", Offset = "0x7DFE860", VA = "0x187DFFC60")]
		internal void MHFPMMAANNF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct MHCKAKJLKBH : IAsyncStateMachine
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
		private NHMKMIBKCDG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE520", Offset = "0x7DFD120", VA = "0x187DFE520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEBE0", Offset = "0x7DFD7E0", VA = "0x187DFEBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool DHKCNLJKKOO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	public static bool BCEIKJFBOEP(byte[] KMICHFMMLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDD90", Offset = "0x7DFC990", VA = "0x187DFDD90")]
	[AsyncStateMachine(typeof(JENAINDJBCE))]
	public static Task<Texture2D> GGDPCLPNBNP(byte[] KMICHFMMLPL, bool NCPICEHMLNH = false, bool OFPIGFFJKAD = false, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDED0", Offset = "0x7DFCAD0", VA = "0x187DFDED0")]
	[AsyncStateMachine(typeof(MHCKAKJLKBH))]
	private static Task<Texture2D> GKDPNBIKBGL(int KHDFLCEFJLK, int DNFPAMDBHCB, bool NILGBFFJCNG, bool NCPICEHMLNH, bool OFPIGFFJKAD, Action<NativeArray<byte>> FJJELNKBPJH, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE020", Offset = "0x7DFCC20", VA = "0x187DFE020")]
	private static TextureFormat KDDDCPNNIDB(bool NILGBFFJCNG)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum BPJBDALLAAP
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
internal static class GLBMINLEBKL
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD220", Offset = "0x7DFBE20", VA = "0x187DFD220")]
	public static bool AABBPFCKKDK(byte[] PEDMEJIDLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD260", Offset = "0x7DFBE60", VA = "0x187DFD260")]
	public static void HJKDLCMLBNH(byte[] PEDMEJIDLNB, [Out] int KHDFLCEFJLK, [Out] int DNFPAMDBHCB, [Out] BPJBDALLAAP GFCBDNDPEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD770", Offset = "0x7DFC370", VA = "0x187DFD770")]
	private static uint JJLKBFIDMFL(byte[] PEDMEJIDLNB, int EILAIOEPAPK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD570", Offset = "0x7DFC170", VA = "0x187DFD570")]
	private static ulong IJMOGNCAEOI(byte[] PEDMEJIDLNB, int EILAIOEPAPK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PKOLMNGKAII
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E00640", Offset = "0x7DFF240", VA = "0x187E00640")]
	public static RenderTexture OOIMIKLMNOM(int KHDFLCEFJLK, int DNFPAMDBHCB, int OBOHMHNKDAH, Camera DNKADDGBBMH, RenderTextureMemoryless PACHODBFHKM = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E005E0", Offset = "0x7DFF1E0", VA = "0x187E005E0")]
	public static void KCEEFJMADMD(RenderTexture KOGCAGMECAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class AEFEKHCMHPK<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct MIBEPDBGLOP : IEquatable<MIBEPDBGLOP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId HNDKKOHODJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly OKLFNCKBAJA HEHPGGFLPHN;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x193B530", Offset = "0x193A130", VA = "0x18193B530")]
		public MIBEPDBGLOP(TImageId MEPFFFGIFGB, OKLFNCKBAJA DGBNECAEHHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x54BB8E0", Offset = "0x54BA4E0", VA = "0x1854BB8E0", Slot = "4")]
		public bool Equals(AEFEKHCMHPK<TImageId>.MIBEPDBGLOP GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x54BB9D0", Offset = "0x54BA5D0", VA = "0x1854BB9D0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x54BBC40", Offset = "0x54BA840", VA = "0x1854BBC40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x54BBDC0", Offset = "0x54BA9C0", VA = "0x1854BBDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PMCMPKKHILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BDNPFNHIMPF<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PMCMPKKHILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x57E3CF0", Offset = "0x57E28F0", VA = "0x1857E3CF0")]
		internal void EELEDHDMFAN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct JBIBAHKJNNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public MIBEPDBGLOP cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AEFEKHCMHPK<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private OKLFNCKBAJA <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x50AECC0", Offset = "0x50AD8C0", VA = "0x1850AECC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x50AF3A0", Offset = "0x50ADFA0", VA = "0x1850AF3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct NOCGMALEBDL : IAsyncStateMachine
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
		public OKLFNCKBAJA textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AEFEKHCMHPK<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5543E60", Offset = "0x5542A60", VA = "0x185543E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5544C70", Offset = "0x5543870", VA = "0x185544C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct JNMFGENAFKC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x51111F0", Offset = "0x510FDF0", VA = "0x1851111F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x51115B0", Offset = "0x51101B0", VA = "0x1851115B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int AHNCJDOGCDP = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim ALBKKGPOOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? CDCEMAMAELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, OKLFNCKBAJA, CancellationToken, Task<Texture2D>>? NINPGAPBMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? HPCPEMCIDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly BPCCLLICIFH<MIBEPDBGLOP, Texture2D> KDGFPHGBLLA;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C490", Offset = "0x4D5B090", VA = "0x184D5C490")]
	public AEFEKHCMHPK(Func<TImageId, CancellationToken, Task<byte[]>> HKIFDDMAGLJ, [Optional] Func<TImageId, string>? FOIDPEIAIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C460", Offset = "0x4D5B060", VA = "0x184D5C460")]
	public AEFEKHCMHPK(Func<TImageId, OKLFNCKBAJA, CancellationToken, Task<Texture2D>> NGFGKLFDBAC, [Optional] Func<TImageId, string>? FOIDPEIAIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C650", Offset = "0x4D5B250", VA = "0x184D5C650")]
	private AEFEKHCMHPK(Func<TImageId, CancellationToken, Task<byte[]>>? HKIFDDMAGLJ, Func<TImageId, OKLFNCKBAJA, CancellationToken, Task<Texture2D>>? NGFGKLFDBAC, Func<TImageId, string>? FOIDPEIAIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4D5BC00", Offset = "0x4D5A800", VA = "0x184D5BC00")]
	public PHKGFEHMLBA<Texture2D> HEBIJECOELL(TImageId MMNOIAKBIKL, OKLFNCKBAJA GILPHBMPOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4D5BFD0", Offset = "0x4D5ABD0", VA = "0x184D5BFD0")]
	public void HIKFPKHNMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B8E0", Offset = "0x4D5A4E0", VA = "0x184D5B8E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C010", Offset = "0x4D5AC10", VA = "0x184D5C010")]
	[AsyncStateMachine(typeof(AEFEKHCMHPK<>.JBIBAHKJNNI))]
	private Task<Texture2D> JKNMDGFAFEA(MIBEPDBGLOP DBGCCCIOHHI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B780", Offset = "0x4D5A380", VA = "0x184D5B780")]
	[AsyncStateMachine(typeof(AEFEKHCMHPK<>.NOCGMALEBDL))]
	private Task<Texture2D> CMOMBFNAPOK(byte[] KMICHFMMLPL, OKLFNCKBAJA GILPHBMPOHL, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C000", Offset = "0x4D5AC00", VA = "0x184D5C000")]
	private void JFBFAOOOJGB(Texture2D BDAIEAKKDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C2B0", Offset = "0x4D5AEB0", VA = "0x184D5C2B0")]
	private bool LNIDNEJJFEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D5BB50", Offset = "0x4D5A750", VA = "0x184D5BB50")]
	private bool GOIKDNDPDAI(byte[] KMICHFMMLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4D5BA60", Offset = "0x4D5A660", VA = "0x184D5BA60")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(AEFEKHCMHPK<>.JNMFGENAFKC))]
	internal static Task GNLLBIFDBPM(IDisposable OJNCLJOKOKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum OKLFNCKBAJA : byte
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
