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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x60FC300", Offset = "0x60FB100", VA = "0x1860FC300")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
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
		[Cpp2IlInjected.Address(RVA = "0x60F9790", Offset = "0x60F8590", VA = "0x1860F9790")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LNAICECHMEA
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
public interface KPIMMFMODFE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LNAICECHMEA PMFICKIDAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFKJDNOEJNO(VertexAttributeFormat JNKFGFMNPLJ, int FMILAPCDHFK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OAGIBPDJPPA
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
			[Cpp2IlInjected.Address(RVA = "0x60FC650", Offset = "0x60FB450", VA = "0x1860FC650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60FC640", Offset = "0x60FB440", VA = "0x1860FC640")]
		public Resolution(uint BJKAJHEJDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB8D0", Offset = "0xAAA6D0", VA = "0x180AAB8D0")]
		public Resolution(uint BJKAJHEJDMP, uint FPNMMAJHCIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60FC550", Offset = "0x60FB350", VA = "0x1860FC550")]
		public static Resolution BBJMGGGHFJJ(Resolution[] BAELEFOBFMO, Resolution GEJCDCCGFIP, int BKDAGCKGPIC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class NEKPPCDBCDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution KKNDJHDPIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? ONECGJFODJK;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint BJKAJHEJDMP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x60FBD80", Offset = "0x60FAB80", VA = "0x1860FBD80")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint FPNMMAJHCIF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x60FBF10", Offset = "0x60FAD10", VA = "0x1860FBF10")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution ONEPMOPKABF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60FBF30", Offset = "0x60FAD30", VA = "0x1860FBF30")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x19F9FB0", Offset = "0x19F8DB0", VA = "0x1819F9FB0")]
		public NEKPPCDBCDK(Resolution KKNDJHDPIGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x60FBD90", Offset = "0x60FAB90", VA = "0x1860FBD90")]
		private static Resolution DLDOADGOPPE(Resolution ONECGJFODJK, LNAICECHMEA LBDPNKDKIOC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class CPEEMCOLBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OPIGBFJJFHK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution NOBCIKLJNFH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution AKKPGDOPEOC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CFCNMELJAPJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution EJJOIMNBGDO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution CGDGCEMOIIB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] BMHEDCBPMAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class JHLECPJFCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution JKBOBHOEKFG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution JMKOHGMHGDN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution GCDBIFCJBCI;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution HDJMAHOHLAH;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution MMNFGIGIHAH;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] BMHEDCBPMAD;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x60FA380", Offset = "0x60F9180", VA = "0x1860FA380")]
		public static Resolution IFEDJIIGHIO(uint DCPJBMNOHJP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution GOCBPMLAHBG;
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[Flags]
		public enum JEEKMAFLFCF : byte
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
		private class NIKNCLFGBLG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string OCCHBLONHPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D INJEECPNGAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JEEKMAFLFCF LKMNLHKNCJM;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x60FC2B0", Offset = "0x60FB0B0", VA = "0x1860FC2B0")]
			public NIKNCLFGBLG(string OCCHBLONHPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3779FC0", Offset = "0x3778DC0", VA = "0x183779FC0")]
			public NIKNCLFGBLG(string OCCHBLONHPL, Texture2D MJKCCMHJFJF, JEEKMAFLFCF MOAAFNKIBEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60FC270", Offset = "0x60FB070", VA = "0x1860FC270", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class EFDHINMKOEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JEEKMAFLFCF textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public EFDHINMKOEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x60F9950", Offset = "0x60F8750", VA = "0x1860F9950")]
			internal void DDBFHJHDLLA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BOIHLFCCLIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public BOIHLFCCLIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x60F8F00", Offset = "0x60F7D00", VA = "0x1860F8F00")]
			internal MFAAEIBAHGL EKIAGGGGMNM(Texture2D t2d)
			{
				return default(MFAAEIBAHGL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class EFLKHKBKGIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public EFLKHKBKGIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x60F9990", Offset = "0x60F8790", VA = "0x1860F9990")]
			internal void DMGIAJJJEFG()
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
		private IEONLNEHMOD<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NIKNCLFGBLG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private IEONLNEHMOD<MFAAEIBAHGL> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IEONLNEHMOD<MFAAEIBAHGL> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x80B180", Offset = "0x809F80", VA = "0x18080B180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F00", Offset = "0x7B7D00", VA = "0x1807B8F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NIKNCLFGBLG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x60FBCD0", Offset = "0x60FAAD0", VA = "0x1860FBCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60FBC00", Offset = "0x60FAA00", VA = "0x1860FBC00")]
		public ManagedTexture(string OCCHBLONHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60FBC60", Offset = "0x60FAA60", VA = "0x1860FBC60")]
		public ManagedTexture(string OCCHBLONHPL, bool DJNOGAIFKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60FB370", Offset = "0x60FA170", VA = "0x1860FB370")]
		public void HCNNPKCCNDE(RenderTexture JDCOLHLMNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60FAE30", Offset = "0x60F9C30", VA = "0x1860FAE30")]
		public IEONLNEHMOD<Texture2D> BNMJHFIJGDD(JEEKMAFLFCF MOAAFNKIBEC, bool PILGKIPGFFK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x60FB130", Offset = "0x60F9F30", VA = "0x1860FB130")]
		public IEONLNEHMOD<MFAAEIBAHGL> EHFKHKOJANG(bool PILGKIPGFFK = false, int KKBOFDDCDDE = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60FB3B0", Offset = "0x60FA1B0", VA = "0x1860FB3B0")]
		public IEONLNEHMOD<MFAAEIBAHGL> KCJIDANJMEB(bool PILGKIPGFFK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60FB6B0", Offset = "0x60FA4B0", VA = "0x1860FB6B0")]
		private static IEONLNEHMOD<Texture2D> MFGFGLHMKOI(string OCCHBLONHPL, RenderTexture JDCOLHLMNOJ, Texture2D JKBGDCKJLID, bool PILGKIPGFFK, JEEKMAFLFCF EHBGCIOCJKI = JEEKMAFLFCF.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60FB2D0", Offset = "0x60FA0D0", VA = "0x1860FB2D0")]
		public void FNNDCMAAJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60FB120", Offset = "0x60F9F20", VA = "0x1860FB120", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60FADD0", Offset = "0x60F9BD0", VA = "0x1860FADD0")]
		[CompilerGenerated]
		private IEONLNEHMOD<byte[]> AOHMDAPALIP(Texture2D INGPFAHIALB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KHJOOCDMJDH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MNBJBJBNPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60FACD0", Offset = "0x60F9AD0", VA = "0x1860FACD0")]
		public unsafe static extern void LINCLLLPPPO(void* CNLDICIBFKB, void* LBGOLPFMFDA, bool GHLGLAEIOIB, bool PENCAOMLIEF, bool PIAGGKJKJGI, [Out] int DCPJBMNOHJP, [Out] int FHODMJAEPGE, [Out] bool MGKHAJFBGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DNMBFPBHIOA
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
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public DNMBFPBHIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60F97B0", Offset = "0x60F85B0", VA = "0x1860F97B0")]
		internal void IIKBJBAMKPL(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MINNNIBENJB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x60FAA40", Offset = "0x60F9840", VA = "0x1860FAA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x60FAC60", Offset = "0x60F9A60", VA = "0x1860FAC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class INKKLGDAFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public INKKLGDAFFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60FA140", Offset = "0x60F8F40", VA = "0x1860FA140")]
		internal void IBBKKJIMKHH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct IBBHKJLPMCJ : IAsyncStateMachine
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
		private INKKLGDAFFJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x60F9A10", Offset = "0x60F8810", VA = "0x1860F9A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60FA0D0", Offset = "0x60F8ED0", VA = "0x1860FA0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool NIJDENLFJOK;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0")]
	public static bool EIBEINFBKJG(byte[] KHKEGCEALOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60FA8C0", Offset = "0x60F96C0", VA = "0x1860FA8C0")]
	[AsyncStateMachine(typeof(MINNNIBENJB))]
	public static Task<Texture2D> PAOENIPLEBD(byte[] KHKEGCEALOB, bool JANAOACLKBL = false, bool ONNFEFNOAFF = false, [Optional] CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60FA770", Offset = "0x60F9570", VA = "0x1860FA770")]
	[AsyncStateMachine(typeof(IBBHKJLPMCJ))]
	private static Task<Texture2D> OIHGGCEGHOP(int DCPJBMNOHJP, int FHODMJAEPGE, bool BMBKOKPOPOJ, bool JANAOACLKBL, bool ONNFEFNOAFF, Action<NativeArray<byte>> MPEHDPNAIFM, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60FA6D0", Offset = "0x60F94D0", VA = "0x1860FA6D0")]
	private static TextureFormat FEPPAHAELBN(bool BMBKOKPOPOJ)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal enum GALJBJICMAO
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
internal static class CDEHLAMEOPF
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60F9070", Offset = "0x60F7E70", VA = "0x1860F9070")]
	public static void FEBKBGLBIDG(byte[] EEDANCJJEPL, [Out] int DCPJBMNOHJP, [Out] int FHODMJAEPGE, [Out] GALJBJICMAO JNKFGFMNPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60F8F40", Offset = "0x60F7D40", VA = "0x1860F8F40")]
	private static uint CCPJCENODAB(byte[] EEDANCJJEPL, int CJNJFDOAKGB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60F9370", Offset = "0x60F8170", VA = "0x1860F9370")]
	private static ulong GEEPACHBBDH(byte[] EEDANCJJEPL, int CJNJFDOAKGB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JHGNBCGLLAP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x60FA180", Offset = "0x60F8F80", VA = "0x1860FA180")]
	public static RenderTexture FMCGOIHIIPJ(int DCPJBMNOHJP, int FHODMJAEPGE, int NBANIMBJCEB, Camera JMAPMJOABDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60FA320", Offset = "0x60F9120", VA = "0x1860FA320")]
	public static void IACJMALEHGO(RenderTexture JDCOLHLMNOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class CBFJOODCKIO<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private readonly struct LMNHFGMJACK : IEquatable<LMNHFGMJACK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId ICPHIEHEEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly KKIHGIKOPMF BDKONCDJPIJ;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x378C4E0", Offset = "0x378B2E0", VA = "0x18378C4E0")]
		public LMNHFGMJACK(TImageId ONOECNHBCDA, KKIHGIKOPMF EHMLLLPPFOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3C37300", Offset = "0x3C36100", VA = "0x183C37300", Slot = "4")]
		public bool Equals(CBFJOODCKIO<TImageId>.LMNHFGMJACK EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3C371F0", Offset = "0x3C35FF0", VA = "0x183C371F0", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3C376F0", Offset = "0x3C364F0", VA = "0x183C376F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C377B0", Offset = "0x3C365B0", VA = "0x183C377B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MLPAFNMOMCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LOHPMIAJHKJ<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public MLPAFNMOMCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E800", Offset = "0x3E2D600", VA = "0x183E2E800")]
		internal void MIJLAMDCJNK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct PNIPDOGEIDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public LMNHFGMJACK cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CBFJOODCKIO<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private KKIHGIKOPMF <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x40C6960", Offset = "0x40C5760", VA = "0x1840C6960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x40C6FF0", Offset = "0x40C5DF0", VA = "0x1840C6FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct JGLEPIFACAK : IAsyncStateMachine
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
		public KKIHGIKOPMF textureLoadOptions;

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
		[Cpp2IlInjected.Address(RVA = "0x3A66F30", Offset = "0x3A65D30", VA = "0x183A66F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3A67550", Offset = "0x3A66350", VA = "0x183A67550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct MNIOPDIDJEF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x3E35AF0", Offset = "0x3E348F0", VA = "0x183E35AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3E35F10", Offset = "0x3E34D10", VA = "0x183E35F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int FCOCBGHICAN = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim DCOEJMEHINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? LCJGGMGFJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, KKIHGIKOPMF, CancellationToken, Task<Texture2D>>? OOCGAMCOBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? LNNJLNFGOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly EJNDJMGJEDH<LMNHFGMJACK, Texture2D> BLAJMJMAOLL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4B7ED50", Offset = "0x4B7DB50", VA = "0x184B7ED50")]
	public CBFJOODCKIO(Func<TImageId, CancellationToken, Task<byte[]>> JBLBLCFMFGP, [Optional] Func<TImageId, string>? IJLGCNOALAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4B7EF10", Offset = "0x4B7DD10", VA = "0x184B7EF10")]
	public CBFJOODCKIO(Func<TImageId, KKIHGIKOPMF, CancellationToken, Task<Texture2D>> EOANGNLBLNL, [Optional] Func<TImageId, string>? IJLGCNOALAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B7ED80", Offset = "0x4B7DB80", VA = "0x184B7ED80")]
	private CBFJOODCKIO(Func<TImageId, CancellationToken, Task<byte[]>>? JBLBLCFMFGP, Func<TImageId, KKIHGIKOPMF, CancellationToken, Task<Texture2D>>? EOANGNLBLNL, Func<TImageId, string>? IJLGCNOALAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E6A0", Offset = "0x4B7D4A0", VA = "0x184B7E6A0")]
	public LOHPMIAJHKJ<Task<Texture2D>> NJLMLDPHJOK(TImageId DHKPICPAEOF, KKIHGIKOPMF MPJLLNJAFFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DF50", Offset = "0x4B7CD50", VA = "0x184B7DF50")]
	public void EFHCPNNIJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DEB0", Offset = "0x4B7CCB0", VA = "0x184B7DEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E540", Offset = "0x4B7D340", VA = "0x184B7E540")]
	[AsyncStateMachine(typeof(CBFJOODCKIO<>.PNIPDOGEIDC))]
	private Task<Texture2D> NCHAAKKBKIK(LMNHFGMJACK MIEIIDHDNFL, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E170", Offset = "0x4B7CF70", VA = "0x184B7E170")]
	[AsyncStateMachine(typeof(CBFJOODCKIO<>.JGLEPIFACAK))]
	private Task<Texture2D> KEHJCPJGGJF(byte[] KHKEGCEALOB, KKIHGIKOPMF MPJLLNJAFFG, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DF80", Offset = "0x4B7CD80", VA = "0x184B7DF80")]
	private void HJAAALGPFOM(Texture2D MJKCCMHJFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4B7DF90", Offset = "0x4B7CD90", VA = "0x184B7DF90")]
	[AsyncStateMachine(typeof(CBFJOODCKIO<>.MNIOPDIDJEF))]
	[CompilerGenerated]
	internal static Task HJOAMGKAHEK(IDisposable OBKPPBHCHCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum KKIHGIKOPMF : byte
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
