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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FE2010", Offset = "0x5FE0A10", VA = "0x185FE2010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FDEE30", Offset = "0x5FDD830", VA = "0x185FDEE30")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum MFFCBIABIIG
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
public interface NDOBKGLAFCD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MFFCBIABIIG BLNDDKANOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KMEGLIKLPEF(VertexAttributeFormat CLNBNIFIABA, int CNPOKNBLGKE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MOKEPKBPPLI
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
			[Cpp2IlInjected.Address(RVA = "0x5FE2500", Offset = "0x5FE0F00", VA = "0x185FE2500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE24F0", Offset = "0x5FE0EF0", VA = "0x185FE24F0")]
		public Resolution(uint LGHEBJJLAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E280", Offset = "0xA4CC80", VA = "0x180A4E280")]
		public Resolution(uint LGHEBJJLAGD, uint FGIFEPPMILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2400", Offset = "0x5FE0E00", VA = "0x185FE2400")]
		public static Resolution EEFJNOANPLC(Resolution[] HKFMBOCPCME, Resolution LFPNIKBLEHN, int KECPKKNBDNH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class IFKELFAKOHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution BMOLODKAAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? FKNKPMMFFFN;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint LGHEBJJLAGD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5FE0010", Offset = "0x5FDEA10", VA = "0x185FE0010")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint FGIFEPPMILE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5FDFB30", Offset = "0x5FDE530", VA = "0x185FDFB30")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution AJJCEKKAIEB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5FDFCD0", Offset = "0x5FDE6D0", VA = "0x185FDFCD0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1971A30", Offset = "0x1970430", VA = "0x181971A30")]
		public IFKELFAKOHH(Resolution BMOLODKAAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFB50", Offset = "0x5FDE550", VA = "0x185FDFB50")]
		private static Resolution JANMHOOJKPB(Resolution FKNKPMMFFFN, MFFCBIABIIG BMOJEHEGEKD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class GMOJMEHNFJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution MLLPAGDIKDH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OFICDCOGODK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DIKBHJMEODF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution NABGDCCAPMB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution BIMALCCCDBE;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution GNGHGCJKNLM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] IHIMAJPBHAC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class GHCJLPNIACK
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution LKOKIMPPLKM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution DJACCNLFMLF;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution PBNBFPJBMAO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution DOLBCEDBNBE;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution DHKEDKLELKA;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] IHIMAJPBHAC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF4C0", Offset = "0x5FDDEC0", VA = "0x185FDF4C0")]
		public static Resolution DMKLBNEPINK(uint MMNOGOIFKED)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution FFMAOCLBNOB;
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[Flags]
		public enum KCPCICILLKG : byte
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
		private class JGINFHDFMDN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string OMHHPMIDNAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D HMDJOLAPPJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KCPCICILLKG MOLHIHHFABL;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5FE0060", Offset = "0x5FDEA60", VA = "0x185FE0060")]
			public JGINFHDFMDN(string OMHHPMIDNAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3F0C3B0", Offset = "0x3F0ADB0", VA = "0x183F0C3B0")]
			public JGINFHDFMDN(string OMHHPMIDNAN, Texture2D MFNKOMGLOGE, KCPCICILLKG LOHACBPIOME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5FE0020", Offset = "0x5FDEA20", VA = "0x185FE0020", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MPFNFFCPGJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KCPCICILLKG textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public MPFNFFCPGJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5FE06B0", Offset = "0x5FDF0B0", VA = "0x185FE06B0")]
			internal void DOLIBKEPDOD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FKPDEEOLFCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public FKPDEEOLFCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5FDF480", Offset = "0x5FDDE80", VA = "0x185FDF480")]
			internal IBMNJNPMLGK NOPNJMEBIDG(Texture2D t2d)
			{
				return default(IBMNJNPMLGK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class BPLNCGMPOKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public BPLNCGMPOKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEDB0", Offset = "0x5FDD7B0", VA = "0x185FDEDB0")]
			internal void AEDFOJCNKLO()
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
		private JMGBCNAMNAH<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JGINFHDFMDN _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private JMGBCNAMNAH<IBMNJNPMLGK> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private JMGBCNAMNAH<IBMNJNPMLGK> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F4420", Offset = "0x7F2E20", VA = "0x1807F4420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private JGINFHDFMDN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x5FE15F0", Offset = "0x5FDFFF0", VA = "0x185FE15F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1520", Offset = "0x5FDFF20", VA = "0x185FE1520")]
		public ManagedTexture(string OMHHPMIDNAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1580", Offset = "0x5FDFF80", VA = "0x185FE1580")]
		public ManagedTexture(string OMHHPMIDNAN, bool OIPKLNLFGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1050", Offset = "0x5FDFA50", VA = "0x185FE1050")]
		public void FOFKLDEHFNN(RenderTexture HCEMBPBIHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1230", Offset = "0x5FDFC30", VA = "0x185FE1230")]
		public JMGBCNAMNAH<Texture2D> OMLIABKPLKJ(KCPCICILLKG LOHACBPIOME, bool GAOPFLJLPMH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1090", Offset = "0x5FDFA90", VA = "0x185FE1090")]
		public JMGBCNAMNAH<IBMNJNPMLGK> KCOMMPKCCAM(bool GAOPFLJLPMH = false, int PFGOCBJAHHH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE06F0", Offset = "0x5FDF0F0", VA = "0x185FE06F0")]
		public JMGBCNAMNAH<IBMNJNPMLGK> BKCJNJDHFKN(bool GAOPFLJLPMH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0A50", Offset = "0x5FDF450", VA = "0x185FE0A50")]
		private static JMGBCNAMNAH<Texture2D> DCLGEOPEHDK(string OMHHPMIDNAN, RenderTexture HCEMBPBIHAM, Texture2D LENKBGINFNK, bool GAOPFLJLPMH, KCPCICILLKG IIHDHLNMPLJ = KCPCICILLKG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0FB0", Offset = "0x5FDF9B0", VA = "0x185FE0FB0")]
		public void ELEFHIGOAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0FA0", Offset = "0x5FDF9A0", VA = "0x185FE0FA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5FE09F0", Offset = "0x5FDF3F0", VA = "0x185FE09F0")]
		[CompilerGenerated]
		private JMGBCNAMNAH<byte[]> CKAIGOIDIGP(Texture2D JELLDMOLDHI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OANMCPFJDEL
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct IEKCONPPKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFA30", Offset = "0x5FDE430", VA = "0x185FDFA30")]
		public unsafe static extern void KBHAOPHFGGI(void* NDAIJLPHKGP, void* EENKOEHACIN, bool DMIOGKFHIDI, bool JMOGNAFGJFI, bool AFNDLIMPGDK, [Out] int MMNOGOIFKED, [Out] int JEONDLHMPEC, [Out] bool GCHALDEHLOK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class MIAKJLJENEP
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public MIAKJLJENEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0340", Offset = "0x5FDED40", VA = "0x185FE0340")]
		internal void OBLKFHMPNBL(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LMAEOMMHCFK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5FE00B0", Offset = "0x5FDEAB0", VA = "0x185FE00B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5FE02D0", Offset = "0x5FDECD0", VA = "0x185FE02D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class NJIMNNLGBNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public NJIMNNLGBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1FD0", Offset = "0x5FE09D0", VA = "0x185FE1FD0")]
		internal void IAIALPKGAEG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct NAJAHACFNII : IAsyncStateMachine
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
		private NJIMNNLGBNO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE16A0", Offset = "0x5FE00A0", VA = "0x185FE16A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1D60", Offset = "0x5FE0760", VA = "0x185FE1D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool JJGKIAMKNDC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0")]
	public static bool IFPEGLEPLAN(byte[] KIKEPIGEGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FE21E0", Offset = "0x5FE0BE0", VA = "0x185FE21E0")]
	[AsyncStateMachine(typeof(LMAEOMMHCFK))]
	public static Task<Texture2D> DODMKLOKGJC(byte[] KIKEPIGEGAD, bool LGBLIKKPLGF = false, bool KOKPNGPLBMA = false, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2090", Offset = "0x5FE0A90", VA = "0x185FE2090")]
	[AsyncStateMachine(typeof(NAJAHACFNII))]
	private static Task<Texture2D> AKNLLGDKJGE(int MMNOGOIFKED, int JEONDLHMPEC, bool JEPKEKPABPM, bool LGBLIKKPLGF, bool KOKPNGPLBMA, Action<NativeArray<byte>> INGLEAGDJBE, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2320", Offset = "0x5FE0D20", VA = "0x185FE2320")]
	private static TextureFormat LILMEBPKKKL(bool JEPKEKPABPM)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal enum EHPFHLNOKLA
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
internal static class EDJCJELAMKE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5FDF180", Offset = "0x5FDDB80", VA = "0x185FDF180")]
	public static void NKPAOPJIKHC(byte[] MFNOAEFOKBK, [Out] int MMNOGOIFKED, [Out] int JEONDLHMPEC, [Out] EHPFHLNOKLA CLNBNIFIABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FDEE50", Offset = "0x5FDD850", VA = "0x185FDEE50")]
	private static uint CCKLGKJHEII(byte[] MFNOAEFOKBK, int AJOMPGHNEBN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FDEF80", Offset = "0x5FDD980", VA = "0x185FDEF80")]
	private static ulong NHGBPLLFANK(byte[] MFNOAEFOKBK, int AJOMPGHNEBN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NDDHABHJDBM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1E30", Offset = "0x5FE0830", VA = "0x185FE1E30")]
	public static RenderTexture NGJALMCKAGA(int MMNOGOIFKED, int JEONDLHMPEC, int JCOHLBKCNJN, Camera KIIMCIJEHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1DD0", Offset = "0x5FE07D0", VA = "0x185FE1DD0")]
	public static void FEGJNLKHMEE(RenderTexture HCEMBPBIHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class FFAPPIELCKA<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private readonly struct FKBHIGMHEKK : IEquatable<FKBHIGMHEKK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId DCGDEIKPLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly FDBEPJPLGJI OBFMHKEPIMI;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x35B9FD0", Offset = "0x35B89D0", VA = "0x1835B9FD0")]
		public FKBHIGMHEKK(TImageId KCGLPAPOILB, FDBEPJPLGJI JNLLMMBMJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x35B9B10", Offset = "0x35B8510", VA = "0x1835B9B10", Slot = "4")]
		public bool Equals(FFAPPIELCKA<TImageId>.FKBHIGMHEKK AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x35B9880", Offset = "0x35B8280", VA = "0x1835B9880", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x35B9D80", Offset = "0x35B8780", VA = "0x1835B9D80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x35B9E40", Offset = "0x35B8840", VA = "0x1835B9E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KHPNCJAHFOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public DKOAJFJKKBO<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public KHPNCJAHFOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3A9C880", Offset = "0x3A9B280", VA = "0x183A9C880")]
		internal void MBGNNGIBCNN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct BODDDMHDBOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FKBHIGMHEKK cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public FFAPPIELCKA<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private FDBEPJPLGJI <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x466CF80", Offset = "0x466B980", VA = "0x18466CF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x466DDA0", Offset = "0x466C7A0", VA = "0x18466DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct JOFAJDOIDHM : IAsyncStateMachine
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
		public FDBEPJPLGJI textureLoadOptions;

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
		[Cpp2IlInjected.Address(RVA = "0x3A36900", Offset = "0x3A35300", VA = "0x183A36900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3A36F90", Offset = "0x3A35990", VA = "0x183A36F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct LGDICGJJENL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x3B7CFC0", Offset = "0x3B7B9C0", VA = "0x183B7CFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3E0", Offset = "0x3B7BDE0", VA = "0x183B7D3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int CGPHGFNKNJJ = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim KNELMMLPMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? FBODKFDNKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, FDBEPJPLGJI, CancellationToken, Task<Texture2D>>? IHMDCMMMECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? DPIFJMCOGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BLIICMKNCDA<FKBHIGMHEKK, Texture2D> MLMOPCBIHDH;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35A73E0", Offset = "0x35A5DE0", VA = "0x1835A73E0")]
	public FFAPPIELCKA(Func<TImageId, CancellationToken, Task<byte[]>> FPDLLKCHMJA, [Optional] Func<TImageId, string>? BPPDNGJHJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35A73B0", Offset = "0x35A5DB0", VA = "0x1835A73B0")]
	public FFAPPIELCKA(Func<TImageId, FDBEPJPLGJI, CancellationToken, Task<Texture2D>> LHHFNDPPGFI, [Optional] Func<TImageId, string>? BPPDNGJHJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35A7220", Offset = "0x35A5C20", VA = "0x1835A7220")]
	private FFAPPIELCKA(Func<TImageId, CancellationToken, Task<byte[]>>? FPDLLKCHMJA, Func<TImageId, FDBEPJPLGJI, CancellationToken, Task<Texture2D>>? LHHFNDPPGFI, Func<TImageId, string>? BPPDNGJHJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35A6520", Offset = "0x35A4F20", VA = "0x1835A6520")]
	public DKOAJFJKKBO<Task<Texture2D>> CHLPPFFEBAE(TImageId EPHAPJJBFOC, FDBEPJPLGJI FIOPNGHGNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35A7030", Offset = "0x35A5A30", VA = "0x1835A7030")]
	public void MMNBAHCLFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35A6870", Offset = "0x35A5270", VA = "0x1835A6870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x35A6AF0", Offset = "0x35A54F0", VA = "0x1835A6AF0")]
	[AsyncStateMachine(typeof(FFAPPIELCKA<>.BODDDMHDBOF))]
	private Task<Texture2D> GKKIMJCKJAA(FKBHIGMHEKK JLHAOFBOAMO, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35A6DA0", Offset = "0x35A57A0", VA = "0x1835A6DA0")]
	[AsyncStateMachine(typeof(FFAPPIELCKA<>.JOFAJDOIDHM))]
	private Task<Texture2D> HHCLEDBIMPD(byte[] KIKEPIGEGAD, FDBEPJPLGJI FIOPNGHGNFD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35A7020", Offset = "0x35A5A20", VA = "0x1835A7020")]
	private void KNOLNIKHLHG(Texture2D MFNKOMGLOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x35A6A00", Offset = "0x35A5400", VA = "0x1835A6A00")]
	[AsyncStateMachine(typeof(FFAPPIELCKA<>.LGDICGJJENL))]
	[CompilerGenerated]
	internal static Task EFFACKDAMLH(IDisposable IMMALKHFCAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum FDBEPJPLGJI : byte
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
