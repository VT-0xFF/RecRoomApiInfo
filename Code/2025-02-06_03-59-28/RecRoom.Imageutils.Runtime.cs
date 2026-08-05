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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A9BC0", Offset = "0x72A89C0", VA = "0x1872A9BC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A7090", Offset = "0x72A5E90", VA = "0x1872A7090")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ENJMFFBDCKH
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
			[Cpp2IlInjected.Address(RVA = "0x72A9D40", Offset = "0x72A8B40", VA = "0x1872A9D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72A9D30", Offset = "0x72A8B30", VA = "0x1872A9D30")]
		public Resolution(uint LBONEMFCDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
		public Resolution(uint LBONEMFCDEA, uint IOKFBHNPJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72A9C40", Offset = "0x72A8A40", VA = "0x1872A9C40")]
		public static Resolution JJFFEGPDIDD(Resolution[] IDEGCFOPFGC, Resolution DEFDOPPPLLD, int EICKOHBFBNB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class HGIGBHJDLBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution FEMDDIKFKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? PNBEKDEIAMM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint LBONEMFCDEA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x72A80B0", Offset = "0x72A6EB0", VA = "0x1872A80B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution FBANNCKMBCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x72A80C0", Offset = "0x72A6EC0", VA = "0x1872A80C0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCAD3F0", Offset = "0xCAC1F0", VA = "0x180CAD3F0")]
		public HGIGBHJDLBP(Resolution FEMDDIKFKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72A7F30", Offset = "0x72A6D30", VA = "0x1872A7F30")]
		private static Resolution IFGLMMFIIAP(Resolution PNBEKDEIAMM, GHDHDNIECEH COIBPKMLMFA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CEGFNDFKALA
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution OJOIPPJOGFB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution GODCAJOGAKL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution BFMGPKAKGCA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution MNHDODJHMMB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution FJDEEFCNKLM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution KFACFGGMMML;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] HKEBPHLNKFI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class BPNAJHGCFJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PMBBNLLOHFI;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution FCJLFNMFONH;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution APKIJPJNCIA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution LCMGODBAOHA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KELLCDCOKHM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] HKEBPHLNKFI;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72A6B20", Offset = "0x72A5920", VA = "0x1872A6B20")]
		public static Resolution BNDGFOOPAGI(uint EOFEIMAHCKE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution IIOHEJGICEC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class ACNEMFECPEF
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72A64D0", Offset = "0x72A52D0", VA = "0x1872A64D0")]
	public static bool PGAJNHAHEIJ(byte[] JOAPLPPIFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72A62C0", Offset = "0x72A50C0", VA = "0x1872A62C0")]
	public static bool JMBHBHLPOGO(byte[] JOAPLPPIFPC, [Out] int EOFEIMAHCKE, [Out] int BKMKGMAPJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72A6230", Offset = "0x72A5030", VA = "0x1872A6230")]
	private static int FAAKGBHDEEL(byte[] JOAPLPPIFPC, int GJCOHOCILFF, [Out] ushort PJLGLDCOIFO)
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
		public enum CEHEGCMFLJP : byte
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
		private class NOFOEKENCFI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string PPKJBGAOBJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D FDCLHEHIJLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public CEHEGCMFLJP AGLGBIPBJHF;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x72A9B70", Offset = "0x72A8970", VA = "0x1872A9B70")]
			public NOFOEKENCFI(string PPKJBGAOBJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x44E9740", Offset = "0x44E8540", VA = "0x1844E9740")]
			public NOFOEKENCFI(string PPKJBGAOBJL, Texture2D CEMDCHNHEAL, CEHEGCMFLJP AIFLLINAIMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x72A9B30", Offset = "0x72A8930", VA = "0x1872A9B30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JFGKEBJBKDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public CEHEGCMFLJP textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public JFGKEBJBKDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x72A8420", Offset = "0x72A7220", VA = "0x1872A8420")]
			internal void JONJDNBLJDL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GEDLNCHDGMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public GEDLNCHDGMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x72A7E70", Offset = "0x72A6C70", VA = "0x1872A7E70")]
			internal DCJKNAGHNOH GHIICCHIPNO(Texture2D t2d)
			{
				return default(DCJKNAGHNOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GNFIJBOPKIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public GNFIJBOPKIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x72A7EB0", Offset = "0x72A6CB0", VA = "0x1872A7EB0")]
			internal void KPFEDDMHACC()
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
		private MNHDJBCOCND<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NOFOEKENCFI _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private MNHDJBCOCND<DCJKNAGHNOH> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MNHDJBCOCND<DCJKNAGHNOH> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB4A960", Offset = "0xB49760", VA = "0x180B4A960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private NOFOEKENCFI memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72A9A80", Offset = "0x72A8880", VA = "0x1872A9A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72A99B0", Offset = "0x72A87B0", VA = "0x1872A99B0")]
		public ManagedTexture(string PPKJBGAOBJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72A9A10", Offset = "0x72A8810", VA = "0x1872A9A10")]
		public ManagedTexture(string PPKJBGAOBJL, bool GAFOJEFFBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72A9150", Offset = "0x72A7F50", VA = "0x1872A9150")]
		public void FILAGHJIDJA(RenderTexture FAHFACFBLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72A9320", Offset = "0x72A8120", VA = "0x1872A9320")]
		public MNHDJBCOCND<Texture2D> JLNHDKAOMHA(CEHEGCMFLJP AIFLLINAIMJ, bool MDGJPKLMBGH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72A9190", Offset = "0x72A7F90", VA = "0x1872A9190")]
		public MNHDJBCOCND<DCJKNAGHNOH> HKNKAGJNCBA(bool MDGJPKLMBGH = false, int EPGCPJPJBJA = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72A96B0", Offset = "0x72A84B0", VA = "0x1872A96B0")]
		public MNHDJBCOCND<DCJKNAGHNOH> OFKNMACMHFJ(bool MDGJPKLMBGH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72A8B90", Offset = "0x72A7990", VA = "0x1872A8B90")]
		private static MNHDJBCOCND<Texture2D> ABDMAGJMKEM(string PPKJBGAOBJL, RenderTexture FAHFACFBLGC, Texture2D LHIHFCKNBAB, bool MDGJPKLMBGH, CEHEGCMFLJP MLMGKCHOEML = CEHEGCMFLJP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72A9610", Offset = "0x72A8410", VA = "0x1872A9610")]
		public void JPHMEBIPFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72A9140", Offset = "0x72A7F40", VA = "0x1872A9140", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72A90E0", Offset = "0x72A7EE0", VA = "0x1872A90E0")]
		[CompilerGenerated]
		private MNHDJBCOCND<byte[]> BFDIAKDMDOH(Texture2D AJFJFAILBCB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ADGBLLEJLGF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct DEHCCEEOBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72A70B0", Offset = "0x72A5EB0", VA = "0x1872A70B0")]
		public unsafe static extern void CBDFNEHGNFL(void* KCDKCHKKFPG, void* COJIJIEDOKL, bool GHEKDHFDEEB, bool FBMHPIPENFJ, bool CIDNBNFMEOD, [Out] int EOFEIMAHCKE, [Out] int BKMKGMAPJDF, [Out] bool MOEHHBPANCC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FHEKHDKPFNO
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
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FHEKHDKPFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72A7C90", Offset = "0x72A6A90", VA = "0x1872A7C90")]
		internal void DKDDPODNODC(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DHGHOGPHGEB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x72A71B0", Offset = "0x72A5FB0", VA = "0x1872A71B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72A73D0", Offset = "0x72A61D0", VA = "0x1872A73D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FMOCMHJGKJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FMOCMHJGKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72A7E30", Offset = "0x72A6C30", VA = "0x1872A7E30")]
		internal void KKNCBIKFIPE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KABKPFMMNCF : IAsyncStateMachine
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
		private FMOCMHJGKJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72A8460", Offset = "0x72A7260", VA = "0x1872A8460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72A8B20", Offset = "0x72A7920", VA = "0x1872A8B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool IJPEJJOGMBD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
	public static bool ELFMEOGKCJI(byte[] OLLKIFLPNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72A6660", Offset = "0x72A5460", VA = "0x1872A6660")]
	[AsyncStateMachine(typeof(DHGHOGPHGEB))]
	public static Task<Texture2D> HDOLDPJNLOP(byte[] OLLKIFLPNPI, bool PPBBPHDNFBJ = false, bool AIDMAMPBCMG = false, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72A6510", Offset = "0x72A5310", VA = "0x1872A6510")]
	[AsyncStateMachine(typeof(KABKPFMMNCF))]
	private static Task<Texture2D> AOKDMMMJIOP(int EOFEIMAHCKE, int BKMKGMAPJDF, bool GNMFJKFJKDL, bool PPBBPHDNFBJ, bool AIDMAMPBCMG, Action<NativeArray<byte>> BGNJGPONDAC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72A67A0", Offset = "0x72A55A0", VA = "0x1872A67A0")]
	private static TextureFormat NKGAKANGNPJ(bool GNMFJKFJKDL)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum HLINCCOIAKD
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
internal static class DJIKDKONOJL
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72A7570", Offset = "0x72A6370", VA = "0x1872A7570")]
	public static bool HPAOAIOPIAH(byte[] JOAPLPPIFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72A75B0", Offset = "0x72A63B0", VA = "0x1872A75B0")]
	public static void IHKJDCBHJLK(byte[] JOAPLPPIFPC, [Out] int EOFEIMAHCKE, [Out] int BKMKGMAPJDF, [Out] HLINCCOIAKD IKCALPFNNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72A7440", Offset = "0x72A6240", VA = "0x1872A7440")]
	private static uint ANLHBMLIKPG(byte[] JOAPLPPIFPC, int EBKPEOBONHB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72A78C0", Offset = "0x72A66C0", VA = "0x1872A78C0")]
	private static ulong LBPCAJEDNPO(byte[] JOAPLPPIFPC, int EBKPEOBONHB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class BPKIKMMNNAH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72A6890", Offset = "0x72A5690", VA = "0x1872A6890")]
	public static RenderTexture EECAJEJOBKJ(int EOFEIMAHCKE, int BKMKGMAPJDF, int CFEGPOADILB, Camera IJAHNFGEONI, RenderTextureMemoryless HAFKDLGFBJD = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72A6AC0", Offset = "0x72A58C0", VA = "0x1872A6AC0")]
	public static void GHFLHJNNBEO(RenderTexture FAHFACFBLGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class KNNJMPICKFL<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct GAGJMNJKNMA : IEquatable<GAGJMNJKNMA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId AOHIIKOCEJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly FODBEHMLOMO EFNFKDBABIF;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x155A9B0", Offset = "0x15597B0", VA = "0x18155A9B0")]
		public GAGJMNJKNMA(TImageId FFOHLCGHDKA, FODBEHMLOMO CJMCDBMAONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x449FCE0", Offset = "0x449EAE0", VA = "0x18449FCE0", Slot = "4")]
		public bool Equals(KNNJMPICKFL<TImageId>.GAGJMNJKNMA LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x449FB70", Offset = "0x449E970", VA = "0x18449FB70", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x449FE50", Offset = "0x449EC50", VA = "0x18449FE50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x449FFF0", Offset = "0x449EDF0", VA = "0x18449FFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PJCGLILPJDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DHBMCMEBKMG<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PJCGLILPJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4F31A40", Offset = "0x4F30840", VA = "0x184F31A40")]
		internal void FFCIAIILGNO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct NGGLHDFMJFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GAGJMNJKNMA cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public KNNJMPICKFL<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private FODBEHMLOMO <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4D28940", Offset = "0x4D27740", VA = "0x184D28940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4D29770", Offset = "0x4D28570", VA = "0x184D29770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct DPHIEBLHDMB : IAsyncStateMachine
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
		public FODBEHMLOMO textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KNNJMPICKFL<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x612E500", Offset = "0x612D300", VA = "0x18612E500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x612EC00", Offset = "0x612DA00", VA = "0x18612EC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LNCPGGNMKJL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4AADA10", Offset = "0x4AAC810", VA = "0x184AADA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4AADC50", Offset = "0x4AACA50", VA = "0x184AADC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int KFCGEHOLOAB = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim PPLJLAEIHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? OKPPBMOHLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, FODBEHMLOMO, CancellationToken, Task<Texture2D>>? HFEJLFOBFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? AIOMOJBPGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly DJBHOJIJLJO<GAGJMNJKNMA, Texture2D> INCGLDKMCFH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49D92A0", Offset = "0x49D80A0", VA = "0x1849D92A0")]
	public KNNJMPICKFL(Func<TImageId, CancellationToken, Task<byte[]>> HJIHAGHEJEF, [Optional] Func<TImageId, string>? JIHEBCPEOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x49D8EF0", Offset = "0x49D7CF0", VA = "0x1849D8EF0")]
	public KNNJMPICKFL(Func<TImageId, FODBEHMLOMO, CancellationToken, Task<Texture2D>> JPHCNIPPOPP, [Optional] Func<TImageId, string>? JIHEBCPEOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x49D8F40", Offset = "0x49D7D40", VA = "0x1849D8F40")]
	private KNNJMPICKFL(Func<TImageId, CancellationToken, Task<byte[]>>? HJIHAGHEJEF, Func<TImageId, FODBEHMLOMO, CancellationToken, Task<Texture2D>>? JPHCNIPPOPP, Func<TImageId, string>? JIHEBCPEOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x49D8240", Offset = "0x49D7040", VA = "0x1849D8240")]
	public MEPEJIIMKOI<Texture2D> BNADELAIFIP(TImageId LLGIMAIFBOB, FODBEHMLOMO KAJLICHHHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x49D8430", Offset = "0x49D7230", VA = "0x1849D8430")]
	public void DBNFEHEBFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49D8480", Offset = "0x49D7280", VA = "0x1849D8480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x49D87F0", Offset = "0x49D75F0", VA = "0x1849D87F0")]
	[AsyncStateMachine(typeof(KNNJMPICKFL<>.NGGLHDFMJFL))]
	private Task<Texture2D> FGODJBMKAEH(GAGJMNJKNMA PADNBEPNLIP, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x49D8690", Offset = "0x49D7490", VA = "0x1849D8690")]
	[AsyncStateMachine(typeof(KNNJMPICKFL<>.DPHIEBLHDMB))]
	private Task<Texture2D> EILFKJOPALK(byte[] OLLKIFLPNPI, FODBEHMLOMO KAJLICHHHHD, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49D8A90", Offset = "0x49D7890", VA = "0x1849D8A90")]
	private void GANFIOPFNID(Texture2D CEMDCHNHEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49D8010", Offset = "0x49D6E10", VA = "0x1849D8010")]
	private bool BFMLMAMCDFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x49D8C80", Offset = "0x49D7A80", VA = "0x1849D8C80")]
	private bool NKICLFADPHO(byte[] OLLKIFLPNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x49D8B90", Offset = "0x49D7990", VA = "0x1849D8B90")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(KNNJMPICKFL<>.LNCPGGNMKJL))]
	internal static Task MHAIFAKHCIH(IDisposable KCHFJDMBOID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum FODBEHMLOMO : byte
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
