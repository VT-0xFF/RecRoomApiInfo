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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x81A98A0", Offset = "0x81A88A0", VA = "0x1881A98A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
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
		[Cpp2IlInjected.Address(RVA = "0x81A6F00", Offset = "0x81A5F00", VA = "0x1881A6F00")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KIOGDHOLPJN
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
			[Cpp2IlInjected.Address(RVA = "0x81AA9D0", Offset = "0x81A99D0", VA = "0x1881AA9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81AA9C0", Offset = "0x81A99C0", VA = "0x1881AA9C0")]
		public Resolution(uint OEFDFBLCHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE5E0E0", Offset = "0xE5D0E0", VA = "0x180E5E0E0")]
		public Resolution(uint OEFDFBLCHHF, uint GDBEEAKMPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81AA8D0", Offset = "0x81A98D0", VA = "0x1881AA8D0")]
		public static Resolution HJKJFNFILNC(Resolution[] EGBMNBJEHHO, Resolution IMBEFJDPIHG, int JOBOINPBNOA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class OFLOCOKGDLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution BAOKAICDDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? IOJFFBEBILI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint OEFDFBLCHHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x81AA150", Offset = "0x81A9150", VA = "0x1881AA150")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution OGBHCDANDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x81A9C70", Offset = "0x81A8C70", VA = "0x1881A9C70")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF1F8E0", Offset = "0xF1E8E0", VA = "0x180F1F8E0")]
		public OFLOCOKGDLA(Resolution BAOKAICDDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81A9FD0", Offset = "0x81A8FD0", VA = "0x1881A9FD0")]
		private static Resolution HMCCDDJLFAA(Resolution IOJFFBEBILI, HLEPJAMPDCC PMNMGINPLFI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class HALAEBDGALL
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution ONFOPPAOLIM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution MGCIJMKMJMD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution PEPANBIHIJI;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution ONGKIKJJLLK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution BONBGDIALAB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution OGJBMHGEIGM;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] EJPBGIAJDPP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ODFKFANLCDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution AOJGDNIECFF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution LLDLMNNMMKA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution LFODEBNJOEI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution EKLIKALPKNJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution PCEEAOPMFKD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] EJPBGIAJDPP;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81A9920", Offset = "0x81A8920", VA = "0x1881A9920")]
		public static Resolution NJAKGOHHOKF(uint HKKIEDPJFCC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution EBDEBOLMGAN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HDFAEEHOFCB
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81A7280", Offset = "0x81A6280", VA = "0x1881A7280")]
	public static bool DHIEMJNFIGA(byte[] INCJDDLACNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x81A72C0", Offset = "0x81A62C0", VA = "0x1881A72C0")]
	public static bool JJNPOOICAPC(byte[] INCJDDLACNP, [Out] int HKKIEDPJFCC, [Out] int DDEMLLBKHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81A74D0", Offset = "0x81A64D0", VA = "0x1881A74D0")]
	private static int OEGJJNGKEBP(byte[] INCJDDLACNP, int OBJODNIPNPB, [Out] ushort BEKMHKBNHOF)
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
		public enum KPKCDKELNHC : byte
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
		private class KNLLNEOEDAF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string HJLBILHBIIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D AHAKDEILDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public KPKCDKELNHC JFMCEDPJECP;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x81A82A0", Offset = "0x81A72A0", VA = "0x1881A82A0")]
			public KNLLNEOEDAF(string HJLBILHBIIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1C091C0", Offset = "0x1C081C0", VA = "0x181C091C0")]
			public KNLLNEOEDAF(string HJLBILHBIIC, Texture2D GHHJBAFAEIA, KPKCDKELNHC OCGKGGLCANB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x81A8260", Offset = "0x81A7260", VA = "0x1881A8260", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AIDJJEJKEEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public KPKCDKELNHC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public AIDJJEJKEEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x81A6EC0", Offset = "0x81A5EC0", VA = "0x1881A6EC0")]
			internal void NIFMJNMELOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FMMHIGKJCAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public FMMHIGKJCAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x81A6F20", Offset = "0x81A5F20", VA = "0x1881A6F20")]
			internal GFFHCDDACLE HFHCOJDEHIJ(Texture2D t2d)
			{
				return default(GFFHCDDACLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JMIFMKOHFND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public JMIFMKOHFND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x81A7D80", Offset = "0x81A6D80", VA = "0x1881A7D80")]
			internal void OKJENHDLLBD()
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
		private KPIPLFECKNC<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KNLLNEOEDAF _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KPIPLFECKNC<GFFHCDDACLE> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private KPIPLFECKNC<GFFHCDDACLE> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private KNLLNEOEDAF memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x81A97F0", Offset = "0x81A87F0", VA = "0x1881A97F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81A9720", Offset = "0x81A8720", VA = "0x1881A9720")]
		public ManagedTexture(string HJLBILHBIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81A9780", Offset = "0x81A8780", VA = "0x1881A9780")]
		public ManagedTexture(string HJLBILHBIIC, bool EABCDMOIGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81A8F00", Offset = "0x81A7F00", VA = "0x1881A8F00")]
		public void IIAJJNFMOII(RenderTexture DOKLHAFMNPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81A8900", Offset = "0x81A7900", VA = "0x1881A8900")]
		public KPIPLFECKNC<Texture2D> DKJGMLMHECN(KPKCDKELNHC OCGKGGLCANB, bool CONLKKLMHEN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81A9490", Offset = "0x81A8490", VA = "0x1881A9490")]
		public KPIPLFECKNC<GFFHCDDACLE> MOCIELJKBEN(bool CONLKKLMHEN = false, int GLAPPIGJBED = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81A8C00", Offset = "0x81A7C00", VA = "0x1881A8C00")]
		public KPIPLFECKNC<GFFHCDDACLE> HLABLHECEAH(bool CONLKKLMHEN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81A8F40", Offset = "0x81A7F40", VA = "0x1881A8F40")]
		private static KPIPLFECKNC<Texture2D> KMKDHPJOIHF(string HJLBILHBIIC, RenderTexture DOKLHAFMNPB, Texture2D HPHADJBAHJJ, bool CONLKKLMHEN, KPKCDKELNHC DFGJHNEFDFM = KPKCDKELNHC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81A9620", Offset = "0x81A8620", VA = "0x1881A9620")]
		public void NNFCNNAPJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81A8BF0", Offset = "0x81A7BF0", VA = "0x1881A8BF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81A96C0", Offset = "0x81A86C0", VA = "0x1881A96C0")]
		[CompilerGenerated]
		private KPIPLFECKNC<byte[]> OFGOLMPBOBP(Texture2D DOANKILEGBF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MHPBKJHGCGP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct HAJOFMCDOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81A6F60", Offset = "0x81A5F60", VA = "0x1881A6F60")]
		public unsafe static extern void MJCEDGGPDDG(void* FJMJCLMOGNJ, void* HCPHGFGFIBL, bool CGDELNNKLOD, bool GKDIPAAJKBE, bool FBMJINAECKI, [Out] int HKKIEDPJFCC, [Out] int DDEMLLBKHKN, [Out] bool AMEOHOLAFDI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IAMJPHMGFBN
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
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public IAMJPHMGFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81A7BE0", Offset = "0x81A6BE0", VA = "0x1881A7BE0")]
		internal void OEHPEHGDGJL(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LGFMPNCOLNA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x81A82F0", Offset = "0x81A72F0", VA = "0x1881A82F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81A8510", Offset = "0x81A7510", VA = "0x1881A8510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OPHCHFODPPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OPHCHFODPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81AA160", Offset = "0x81A9160", VA = "0x1881AA160")]
		internal void AEFMEGNCJEH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PGMBKCFGHEH : IAsyncStateMachine
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
		private OPHCHFODPPC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81AA1A0", Offset = "0x81A91A0", VA = "0x1881AA1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81AA860", Offset = "0x81A9860", VA = "0x1881AA860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool POEFJHNJLHO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0")]
	public static bool NIBJCNLMDOA(byte[] ACBKJGKAECC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81A8770", Offset = "0x81A7770", VA = "0x1881A8770")]
	[AsyncStateMachine(typeof(LGFMPNCOLNA))]
	public static Task<Texture2D> INNENFNALIB(byte[] ACBKJGKAECC, bool IEFILNIEAII = false, bool PMNHJMIMNEJ = false, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81A8620", Offset = "0x81A7620", VA = "0x1881A8620")]
	[AsyncStateMachine(typeof(PGMBKCFGHEH))]
	private static Task<Texture2D> GFIGIGMIJLM(int HKKIEDPJFCC, int DDEMLLBKHKN, bool OPLIFPCKOBA, bool IEFILNIEAII, bool PMNHJMIMNEJ, Action<NativeArray<byte>> MJAMBBJIPOD, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x81A8580", Offset = "0x81A7580", VA = "0x1881A8580")]
	private static TextureFormat EBCHGMEGGGB(bool OPLIFPCKOBA)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum ILKBOPBPKKP
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
internal static class HLPPOBLFBCC
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81A7890", Offset = "0x81A6890", VA = "0x1881A7890")]
	public static bool FMFDADMOGEE(byte[] INCJDDLACNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x81A78D0", Offset = "0x81A68D0", VA = "0x1881A78D0")]
	public static void OJGFAGKCHKN(byte[] INCJDDLACNP, [Out] int HKKIEDPJFCC, [Out] int DDEMLLBKHKN, [Out] ILKBOPBPKKP IEAPGIAMHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x81A7560", Offset = "0x81A6560", VA = "0x1881A7560")]
	private static uint ACEFGMJNNEN(byte[] INCJDDLACNP, int LMLEMDDGACN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x81A7690", Offset = "0x81A6690", VA = "0x1881A7690")]
	private static ulong AKMGGAHFDHP(byte[] INCJDDLACNP, int LMLEMDDGACN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KJNOJPKLHOA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x81A7FD0", Offset = "0x81A6FD0", VA = "0x1881A7FD0")]
	public static RenderTexture AMBEHCAMFDB(int HKKIEDPJFCC, int DDEMLLBKHKN, int DKKGJKLMNDM, Camera PBNOMALDNIM, RenderTextureMemoryless FMOODJJFMIP = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x81A8200", Offset = "0x81A7200", VA = "0x1881A8200")]
	public static void POBFNFFGDFB(RenderTexture DOKLHAFMNPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class OGOKANANPJK<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct GDHMMBPJNJA : IEquatable<GDHMMBPJNJA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId MNHMAEKBOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly BJNCHFHMLBM JDGFOFDHLEG;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1A08DD0", Offset = "0x1A07DD0", VA = "0x181A08DD0")]
		public GDHMMBPJNJA(TImageId DAKIIEIEKNI, BJNCHFHMLBM HOOANPEEEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3850", Offset = "0x4EA2850", VA = "0x184EA3850", Slot = "4")]
		public bool Equals(OGOKANANPJK<TImageId>.GDHMMBPJNJA EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3940", Offset = "0x4EA2940", VA = "0x184EA3940", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3B20", Offset = "0x4EA2B20", VA = "0x184EA3B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3BD0", Offset = "0x4EA2BD0", VA = "0x184EA3BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NKMFDDFHMFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DMEMIKDFAED<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public NKMFDDFHMFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5796ED0", Offset = "0x5795ED0", VA = "0x185796ED0")]
		internal void EDMAHFBCDOK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct BNPIEJBHBAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GDHMMBPJNJA cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public OGOKANANPJK<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private BJNCHFHMLBM <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6524200", Offset = "0x6523200", VA = "0x186524200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x65248E0", Offset = "0x65238E0", VA = "0x1865248E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct EGMMMAKFFIH : IAsyncStateMachine
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
		public BJNCHFHMLBM textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public OGOKANANPJK<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4900650", Offset = "0x48FF650", VA = "0x184900650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4901480", Offset = "0x4900480", VA = "0x184901480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct PMCAAOFIDCM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5A7EC20", Offset = "0x5A7DC20", VA = "0x185A7EC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5A7EE00", Offset = "0x5A7DE00", VA = "0x185A7EE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int FFCLLJPBINF = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim MAFCGADMEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? LGDJKKHGGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, BJNCHFHMLBM, CancellationToken, Task<Texture2D>>? PIDBOIHCCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? INBPIPKAMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly DGHFOCDINCJ<GDHMMBPJNJA, Texture2D> KHGEJDBCGJO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x58B3AD0", Offset = "0x58B2AD0", VA = "0x1858B3AD0")]
	public OGOKANANPJK(Func<TImageId, CancellationToken, Task<byte[]>> KILJKKFOKJE, [Optional] Func<TImageId, string>? NBBOONNKEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x58B3910", Offset = "0x58B2910", VA = "0x1858B3910")]
	public OGOKANANPJK(Func<TImageId, BJNCHFHMLBM, CancellationToken, Task<Texture2D>> PNNGDMCHOGB, [Optional] Func<TImageId, string>? NBBOONNKEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x58B3B00", Offset = "0x58B2B00", VA = "0x1858B3B00")]
	private OGOKANANPJK(Func<TImageId, CancellationToken, Task<byte[]>>? KILJKKFOKJE, Func<TImageId, BJNCHFHMLBM, CancellationToken, Task<Texture2D>>? PNNGDMCHOGB, Func<TImageId, string>? NBBOONNKEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x58B3580", Offset = "0x58B2580", VA = "0x1858B3580")]
	public PHNCGCCJBCF<Texture2D> LOMPPLNIHPJ(TImageId DDJCIMPEEFO, BJNCHFHMLBM GBKAEJMGLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x58B3350", Offset = "0x58B2350", VA = "0x1858B3350")]
	public void JKBCIEIEELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x58B2D50", Offset = "0x58B1D50", VA = "0x1858B2D50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x58B2DE0", Offset = "0x58B1DE0", VA = "0x1858B2DE0")]
	[AsyncStateMachine(typeof(OGOKANANPJK<>.BNPIEJBHBAD))]
	private Task<Texture2D> GDEGKNHKAHE(GDHMMBPJNJA OOENCEFPPHA, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x58B31E0", Offset = "0x58B21E0", VA = "0x1858B31E0")]
	[AsyncStateMachine(typeof(OGOKANANPJK<>.EGMMMAKFFIH))]
	private Task<Texture2D> HJADFIPKICP(byte[] ACBKJGKAECC, BJNCHFHMLBM GBKAEJMGLME, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x58B2D40", Offset = "0x58B1D40", VA = "0x1858B2D40")]
	private void COFNBFAOPCL(Texture2D GHHJBAFAEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x58B3340", Offset = "0x58B2340", VA = "0x1858B3340")]
	private bool IAODKIJENPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x58B2C90", Offset = "0x58B1C90", VA = "0x1858B2C90")]
	private bool BLMAIMLJANF(byte[] ACBKJGKAECC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x58B2AB0", Offset = "0x58B1AB0", VA = "0x1858B2AB0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(OGOKANANPJK<>.PMCAAOFIDCM))]
	internal static Task AHBJDGMBKCI(IDisposable DOMKPECGNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum BJNCHFHMLBM : byte
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
