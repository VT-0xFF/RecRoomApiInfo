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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8DD20", Offset = "0x7C8CF20", VA = "0x187C8DD20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8B1A0", Offset = "0x7C8A3A0", VA = "0x187C8B1A0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HNLONJMBJPB
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
			[Cpp2IlInjected.Address(RVA = "0x7C8E280", Offset = "0x7C8D480", VA = "0x187C8E280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E270", Offset = "0x7C8D470", VA = "0x187C8E270")]
		public Resolution(uint HGCMPGNMMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
		public Resolution(uint HGCMPGNMMIB, uint PIALGICKFLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E180", Offset = "0x7C8D380", VA = "0x187C8E180")]
		public static Resolution PLNHJBMALJO(Resolution[] AFJJJNJGALF, Resolution PCHJCBNILLK, int KNAFOBEKBII)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class DKGEHMOANNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution GGLGOIMGGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? LPMLPMIIGCA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint HGCMPGNMMIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7C8B1C0", Offset = "0x7C8A3C0", VA = "0x187C8B1C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution JPJFLABDDAI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7C8B1D0", Offset = "0x7C8A3D0", VA = "0x187C8B1D0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xE50430", Offset = "0xE4F630", VA = "0x180E50430")]
		public DKGEHMOANNN(Resolution GGLGOIMGGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C8B520", Offset = "0x7C8A720", VA = "0x187C8B520")]
		private static Resolution IEIJABDMNPG(Resolution LPMLPMIIGCA, MKKKJECFFBB AEHINIGEFGF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class KKMDDOOHNIO
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution FCFILEAPPEK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution POBKAMCKEMI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution CNGDPIABGBM;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution MEMMEMMBHPB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution MCOALFLGFDP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution JMAHDLKKHIO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] PMOHIEJOBEE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class BJIOKJGPMLL
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution JEJNGEEBNPE;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution LDBLHMJMGND;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution HICFFAIJHEA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution PJCCAIOFCLK;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution LJOGEDMPJPK;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] PMOHIEJOBEE;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C8A800", Offset = "0x7C89A00", VA = "0x187C8A800")]
		public static Resolution NDHJMAIDOCD(uint NIPKIDIFIFA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution BNMCKHIMPDJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class NDDOAMIGKEA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DA40", Offset = "0x7C8CC40", VA = "0x187C8DA40")]
	public static bool EBGECDANMHA(byte[] CAIGHLKIDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DA80", Offset = "0x7C8CC80", VA = "0x187C8DA80")]
	public static bool KIMLONGCPFA(byte[] CAIGHLKIDBF, [Out] int NIPKIDIFIFA, [Out] int PDMAOPMNGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DC90", Offset = "0x7C8CE90", VA = "0x187C8DC90")]
	private static int OGBPHKCMJMO(byte[] CAIGHLKIDBF, int KOKMPCAPCJD, [Out] ushort CGJOKMNKJFA)
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
		public enum GAJBFGDDIBF : byte
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
		private class OHJFJOBPHGA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string GBOCGPJOEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D BBPCNBDODJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GAJBFGDDIBF GBGLKJNOOJA;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7C8DDE0", Offset = "0x7C8CFE0", VA = "0x187C8DDE0")]
			public OHJFJOBPHGA(string GBOCGPJOEEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1AA05C0", Offset = "0x1A9F7C0", VA = "0x181AA05C0")]
			public OHJFJOBPHGA(string GBOCGPJOEEK, Texture2D NANHFKKMKAD, GAJBFGDDIBF NCJLFGOEMCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7C8DDA0", Offset = "0x7C8CFA0", VA = "0x187C8DDA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EGOEGCLMPDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public GAJBFGDDIBF textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public EGOEGCLMPDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7C8B6A0", Offset = "0x7C8A8A0", VA = "0x187C8B6A0")]
			internal void EIAAGCKHJEG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JMIKNPHHCPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public JMIKNPHHCPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7C8C040", Offset = "0x7C8B240", VA = "0x187C8C040")]
			internal GEOGNAKGHCP BCDFILFKBFB(Texture2D t2d)
			{
				return default(GEOGNAKGHCP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OLAGOJHACAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public OLAGOJHACAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7C8DE70", Offset = "0x7C8D070", VA = "0x187C8DE70")]
			internal void EBKIIEIOCLM()
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
		private GFHJFJDJPFP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OHJFJOBPHGA _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GFHJFJDJPFP<GEOGNAKGHCP> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private GFHJFJDJPFP<GEOGNAKGHCP> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA75190", Offset = "0xA74390", VA = "0x180A75190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private OHJFJOBPHGA memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7C8D990", Offset = "0x7C8CB90", VA = "0x187C8D990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D8C0", Offset = "0x7C8CAC0", VA = "0x187C8D8C0")]
		public ManagedTexture(string GBOCGPJOEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D920", Offset = "0x7C8CB20", VA = "0x187C8D920")]
		public ManagedTexture(string GBOCGPJOEEK, bool LJJDKJDGPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D880", Offset = "0x7C8CA80", VA = "0x187C8D880")]
		public void KIEICNDHEOF(RenderTexture AFCFGGMHNBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CCA0", Offset = "0x7C8BEA0", VA = "0x187C8CCA0")]
		public GFHJFJDJPFP<Texture2D> BKAKADFAGFO(GAJBFGDDIBF NCJLFGOEMCC, bool BEMBEGIKBAG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CB00", Offset = "0x7C8BD00", VA = "0x187C8CB00")]
		public GFHJFJDJPFP<GEOGNAKGHCP> AGMHIKDBJMD(bool BEMBEGIKBAG = false, int PBKCOMHKFLJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D4F0", Offset = "0x7C8C6F0", VA = "0x187C8D4F0")]
		public GFHJFJDJPFP<GEOGNAKGHCP> HPBDDHEHDIC(bool BEMBEGIKBAG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CFA0", Offset = "0x7C8C1A0", VA = "0x187C8CFA0")]
		private static GFHJFJDJPFP<Texture2D> EHGBGLFADMO(string GBOCGPJOEEK, RenderTexture AFCFGGMHNBC, Texture2D FOLKMAMJAND, bool BEMBEGIKBAG, GAJBFGDDIBF JHMBOBHDCNC = GAJBFGDDIBF.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D7E0", Offset = "0x7C8C9E0", VA = "0x187C8D7E0")]
		public void ILEHBHHHADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CF90", Offset = "0x7C8C190", VA = "0x187C8CF90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CAA0", Offset = "0x7C8BCA0", VA = "0x187C8CAA0")]
		[CompilerGenerated]
		private GFHJFJDJPFP<byte[]> ACBICAHDCOM(Texture2D PFFDOOKEGFI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HJMFLFGIOHM
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct MBDJFJKDAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C9A0", Offset = "0x7C8BBA0", VA = "0x187C8C9A0")]
		public unsafe static extern void FPOGAEHILKG(void* PFEMHOAKONC, void* MCOCJMBCCJG, bool DCKLMKMDCGM, bool FOBFACHNCII, bool KAJODGCGGCN, [Out] int NIPKIDIFIFA, [Out] int PDMAOPMNGEB, [Out] bool JJAJLABLEBB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GNNFGNOFANK
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
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GNNFGNOFANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C8B970", Offset = "0x7C8AB70", VA = "0x187C8B970")]
		internal void PNGADJGBCKC(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PHMFCENFELK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7C8DEF0", Offset = "0x7C8D0F0", VA = "0x187C8DEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E110", Offset = "0x7C8D310", VA = "0x187C8E110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OKMOOGJCGCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OKMOOGJCGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DE30", Offset = "0x7C8D030", VA = "0x187C8DE30")]
		internal void DLCCEPAOINH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LGPDPBBHMFM : IAsyncStateMachine
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
		private OKMOOGJCGCC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C270", Offset = "0x7C8B470", VA = "0x187C8C270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C930", Offset = "0x7C8BB30", VA = "0x187C8C930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool AANEGBIOHID;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
	public static bool LBGHEFKMHFP(byte[] CFGAJELGOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C8BBA0", Offset = "0x7C8ADA0", VA = "0x187C8BBA0")]
	[AsyncStateMachine(typeof(PHMFCENFELK))]
	public static Task<Texture2D> IACPIMCIEDO(byte[] CFGAJELGOFB, bool ILPGGAIMCHE = false, bool JPNIHOGECBE = false, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C8BCE0", Offset = "0x7C8AEE0", VA = "0x187C8BCE0")]
	[AsyncStateMachine(typeof(LGPDPBBHMFM))]
	private static Task<Texture2D> OGMGDMNAJHC(int NIPKIDIFIFA, int PDMAOPMNGEB, bool JBHHMCAKDDH, bool ILPGGAIMCHE, bool JPNIHOGECBE, Action<NativeArray<byte>> PMDMNEJPFPJ, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C8BB10", Offset = "0x7C8AD10", VA = "0x187C8BB10")]
	private static TextureFormat HBELFKHCJIJ(bool JBHHMCAKDDH)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum OEFEHPKCBEO
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
internal static class CMFPDENPLAB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B160", Offset = "0x7C8A360", VA = "0x187C8B160")]
	public static bool NKFECFHMHIK(byte[] CAIGHLKIDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AE50", Offset = "0x7C8A050", VA = "0x187C8AE50")]
	public static void NAHGDKOOLOJ(byte[] CAIGHLKIDBF, [Out] int NIPKIDIFIFA, [Out] int PDMAOPMNGEB, [Out] OEFEHPKCBEO LHADPGCGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AD20", Offset = "0x7C89F20", VA = "0x187C8AD20")]
	private static uint JDNKDFMHJNE(byte[] CAIGHLKIDBF, int EIGANLKFLHL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AB20", Offset = "0x7C89D20", VA = "0x187C8AB20")]
	private static ulong ENMDHMEEMEA(byte[] CAIGHLKIDBF, int EIGANLKFLHL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FPBFICIDGIO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B740", Offset = "0x7C8A940", VA = "0x187C8B740")]
	public static RenderTexture NKKNEKMJHEH(int NIPKIDIFIFA, int PDMAOPMNGEB, int CINPFKHDBFA, Camera HEKBGKAPFJN, RenderTextureMemoryless MOECDPHBNDJ = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B6E0", Offset = "0x7C8A8E0", VA = "0x187C8B6E0")]
	public static void MOINJMGNJFP(RenderTexture AFCFGGMHNBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class IINGBOBPOEO<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct EGJNOGLPCHM : IEquatable<EGJNOGLPCHM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId POHHLPFDGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly HANOHKDHMEL LMJMNIDLHAI;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x18CDBA0", Offset = "0x18CCDA0", VA = "0x1818CDBA0")]
		public EGJNOGLPCHM(TImageId MHDODBCCAJB, HANOHKDHMEL PPJMDPBKLLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x467AAE0", Offset = "0x4679CE0", VA = "0x18467AAE0", Slot = "4")]
		public bool Equals(IINGBOBPOEO<TImageId>.EGJNOGLPCHM CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x467A850", Offset = "0x4679A50", VA = "0x18467A850", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x467ACA0", Offset = "0x4679EA0", VA = "0x18467ACA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x467AD50", Offset = "0x4679F50", VA = "0x18467AD50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KACIIGFJJMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public MBFLJOFBBPA<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KACIIGFJJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5121DC0", Offset = "0x5120FC0", VA = "0x185121DC0")]
		internal void OBPCLIKJNCI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct JFCDHPIEMAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public EGJNOGLPCHM cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IINGBOBPOEO<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private HANOHKDHMEL <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x502FDF0", Offset = "0x502EFF0", VA = "0x18502FDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5030BD0", Offset = "0x502FDD0", VA = "0x185030BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct DJFANBAICJJ : IAsyncStateMachine
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
		public HANOHKDHMEL textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IINGBOBPOEO<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x42138E0", Offset = "0x4212AE0", VA = "0x1842138E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4214020", Offset = "0x4213220", VA = "0x184214020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct GLPMKMACMNN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4C22D80", Offset = "0x4C21F80", VA = "0x184C22D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4C231A0", Offset = "0x4C223A0", VA = "0x184C231A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int KHKCCCAJJJN = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim MELFOBDADHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? ALJGOLFNLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, HANOHKDHMEL, CancellationToken, Task<Texture2D>>? JBHMFMDPELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? IPLMFFFHMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CEJFLAGAABB<EGJNOGLPCHM, Texture2D> HOPDDMHNLHL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4DEFA10", Offset = "0x4DEEC10", VA = "0x184DEFA10")]
	public IINGBOBPOEO(Func<TImageId, CancellationToken, Task<byte[]>> IIDGNKDJIKB, [Optional] Func<TImageId, string>? EPLMBOAJMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4DEF9E0", Offset = "0x4DEEBE0", VA = "0x184DEF9E0")]
	public IINGBOBPOEO(Func<TImageId, HANOHKDHMEL, CancellationToken, Task<Texture2D>> ILGFDPFKPAH, [Optional] Func<TImageId, string>? EPLMBOAJMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4DEFBD0", Offset = "0x4DEEDD0", VA = "0x184DEFBD0")]
	private IINGBOBPOEO(Func<TImageId, CancellationToken, Task<byte[]>>? IIDGNKDJIKB, Func<TImageId, HANOHKDHMEL, CancellationToken, Task<Texture2D>>? ILGFDPFKPAH, Func<TImageId, string>? EPLMBOAJMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4DEEE60", Offset = "0x4DEE060", VA = "0x184DEEE60")]
	public HLHLINEFKHE<Texture2D> HCAEEHCCBEL(TImageId CIKAMKPFPNJ, HANOHKDHMEL GLIIPDBLFFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4DEEC50", Offset = "0x4DEDE50", VA = "0x184DEEC50")]
	public void GJGKLDJFELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4DEEBB0", Offset = "0x4DEDDB0", VA = "0x184DEEBB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4DEF6F0", Offset = "0x4DEE8F0", VA = "0x184DEF6F0")]
	[AsyncStateMachine(typeof(IINGBOBPOEO<>.JFCDHPIEMAI))]
	private Task<Texture2D> OJDOOPPNNJJ(EGJNOGLPCHM LMBJOMEGNFK, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4DEF230", Offset = "0x4DEE430", VA = "0x184DEF230")]
	[AsyncStateMachine(typeof(IINGBOBPOEO<>.DJFANBAICJJ))]
	private Task<Texture2D> JIAAFNCNOIK(byte[] CFGAJELGOFB, HANOHKDHMEL GLIIPDBLFFF, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4DEEBA0", Offset = "0x4DEDDA0", VA = "0x184DEEBA0")]
	private void CPEIDBEBBPB(Texture2D NANHFKKMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4DEEC40", Offset = "0x4DEDE40", VA = "0x184DEEC40")]
	private bool FCDODFPOENL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4DEF4F0", Offset = "0x4DEE6F0", VA = "0x184DEF4F0")]
	private bool NILFGGKLIDO(byte[] CFGAJELGOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4DEEC80", Offset = "0x4DEDE80", VA = "0x184DEEC80")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(IINGBOBPOEO<>.GLPMKMACMNN))]
	internal static Task GODBOCKPMMM(IDisposable CFCLIADJFGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum HANOHKDHMEL : byte
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
