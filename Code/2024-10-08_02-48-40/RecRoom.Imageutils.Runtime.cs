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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C91B50", Offset = "0x6C90D50", VA = "0x186C91B50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8E910", Offset = "0x6C8DB10", VA = "0x186C8E910")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JOCJOEIAHJB
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
public interface JGOAOKLIBCL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JOCJOEIAHJB LGILKEMDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBIIPLNNHPD(VertexAttributeFormat EAJPHFGLPOO, int JKIALHMLKGH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class APHHNAJFMEA
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
			[Cpp2IlInjected.Address(RVA = "0x6C91DE0", Offset = "0x6C90FE0", VA = "0x186C91DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C91DD0", Offset = "0x6C90FD0", VA = "0x186C91DD0")]
		public Resolution(uint AKHPALIKFFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A040", Offset = "0xA09240", VA = "0x180A0A040")]
		public Resolution(uint AKHPALIKFFK, uint PGLPHKNNCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C91CE0", Offset = "0x6C90EE0", VA = "0x186C91CE0")]
		public static Resolution BBMBAHICDII(Resolution[] PCHCKDDGLBA, Resolution LHBDNFBGEFD, int CKLJELFDKIM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class GOGEOKEIAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution AGJGEHKOOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? CMOHDNJHPIE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint AKHPALIKFFK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8FE10", Offset = "0x6C8F010", VA = "0x186C8FE10")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution NKPFGJEJLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6C8FE20", Offset = "0x6C8F020", VA = "0x186C8FE20")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x931770", Offset = "0x930970", VA = "0x180931770")]
		public GOGEOKEIAPC(Resolution AGJGEHKOOCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C8FC90", Offset = "0x6C8EE90", VA = "0x186C8FC90")]
		private static Resolution BNLJIIHCKAK(Resolution CMOHDNJHPIE, JOCJOEIAHJB OIAELAGDFPD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class MBIEPCLNPFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution GHOODHHNJFE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LLEMKCNGMIO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution CPFEIPJFPAK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CHFEPFPNNHD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution MJLFADFCCOB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution GMCBJOAHAON;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] DMNBPKJILKB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class IDNDFMKLKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution AHDKOONDKHC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution MDCNMHGJKIO;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution FAMIKKBELIM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution BGBHJBMFBME;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution DBEPHKLOPBN;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] DMNBPKJILKB;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C90270", Offset = "0x6C8F470", VA = "0x186C90270")]
		public static Resolution NNGEDEPPDML(uint OFMCKDAMODD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution EONHMFGDECN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class EIGKLICCNOI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F0A0", Offset = "0x6C8E2A0", VA = "0x186C8F0A0")]
	public static bool KEOADMDKAEB(byte[] LJIEGDEDOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F170", Offset = "0x6C8E370", VA = "0x186C8F170")]
	public static bool MANCODEEDFD(byte[] LJIEGDEDOHM, [Out] int OFMCKDAMODD, [Out] int AAKHKDILCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F0E0", Offset = "0x6C8E2E0", VA = "0x186C8F0E0")]
	private static int LIHFHHGMAFI(byte[] LJIEGDEDOHM, int GFHPFKLIAOK, [Out] ushort HAHPKKKMAFK)
	{
		return default(int);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[Flags]
		public enum FOMLLAAHCGL : byte
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

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private class OCFBOFCEPKD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string EPPPGDEIJCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D ACKHAOBGDGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FOMLLAAHCGL OOPFIAAOOKP;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6C91C10", Offset = "0x6C90E10", VA = "0x186C91C10")]
			public OCFBOFCEPKD(string EPPPGDEIJCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x47CA190", Offset = "0x47C9390", VA = "0x1847CA190")]
			public OCFBOFCEPKD(string EPPPGDEIJCI, Texture2D AIEGELCMLNA, FOMLLAAHCGL HHKDMBGHMAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6C91BD0", Offset = "0x6C90DD0", VA = "0x186C91BD0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PAKCBECBHDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FOMLLAAHCGL textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public PAKCBECBHDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6C91CA0", Offset = "0x6C90EA0", VA = "0x186C91CA0")]
			internal void NAIIEEFKPIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ONIGBHIPAHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public ONIGBHIPAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6C91C60", Offset = "0x6C90E60", VA = "0x186C91C60")]
			internal PCEMLAIOGNP KNGEJEBKKMB(Texture2D t2d)
			{
				return default(PCEMLAIOGNP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CIPGLGOJBFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public CIPGLGOJBFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E530", Offset = "0x6C8D730", VA = "0x186C8E530")]
			internal void ACKGIOBIHFO()
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
		private PIHPPMDHIHB<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OCFBOFCEPKD _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private PIHPPMDHIHB<PCEMLAIOGNP> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private PIHPPMDHIHB<PCEMLAIOGNP> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x931B60", Offset = "0x930D60", VA = "0x180931B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private OCFBOFCEPKD memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6C91810", Offset = "0x6C90A10", VA = "0x186C91810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C91740", Offset = "0x6C90940", VA = "0x186C91740")]
		public ManagedTexture(string EPPPGDEIJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C917A0", Offset = "0x6C909A0", VA = "0x186C917A0")]
		public ManagedTexture(string EPPPGDEIJCI, bool CNDNPGPDOEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C91700", Offset = "0x6C90900", VA = "0x186C91700")]
		public void MDCKMBLGODF(RenderTexture FMCMPFBDEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6C90DB0", Offset = "0x6C8FFB0", VA = "0x186C90DB0")]
		public PIHPPMDHIHB<Texture2D> CMPBOHDGOBG(FOMLLAAHCGL HHKDMBGHMAB, bool FIJGOKNKPGN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C90C10", Offset = "0x6C8FE10", VA = "0x186C90C10")]
		public PIHPPMDHIHB<PCEMLAIOGNP> BKEJADIEGLG(bool FIJGOKNKPGN = false, int MKMNENNEBGM = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C90920", Offset = "0x6C8FB20", VA = "0x186C90920")]
		public PIHPPMDHIHB<PCEMLAIOGNP> BHLBGGBEEBN(bool FIJGOKNKPGN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C910B0", Offset = "0x6C902B0", VA = "0x186C910B0")]
		private static PIHPPMDHIHB<Texture2D> HKENPABEPCJ(string EPPPGDEIJCI, RenderTexture FMCMPFBDEIN, Texture2D FABNMPAEPGH, bool FIJGOKNKPGN, FOMLLAAHCGL AEPBMMMBMOG = FOMLLAAHCGL.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C91600", Offset = "0x6C90800", VA = "0x186C91600")]
		public void HNGHEOAGGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C910A0", Offset = "0x6C902A0", VA = "0x186C910A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C916A0", Offset = "0x6C908A0", VA = "0x186C916A0")]
		[CompilerGenerated]
		private PIHPPMDHIHB<byte[]> KHMEAPJJEAE(Texture2D DAFLPICICPN)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CLDGJFMNELN
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HLAPLMKAHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C90170", Offset = "0x6C8F370", VA = "0x186C90170")]
		public unsafe static extern void JFILHBCJIKJ(void* GKIHGJOEEAO, void* OPBMEKKEPKH, bool ELPIOADEOPH, bool MHMLKOLHHML, bool DNEHGKHPCGC, [Out] int OFMCKDAMODD, [Out] int AAKHKDILCDN, [Out] bool GHDOEKEAGIG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class JBFEDLIOLFA
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

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public JBFEDLIOLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C90590", Offset = "0x6C8F790", VA = "0x186C90590")]
		internal void OFGJJPHAHNI(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct GHKAMCLMDHL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C8FA00", Offset = "0x6C8EC00", VA = "0x186C8FA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8FC20", Offset = "0x6C8EE20", VA = "0x186C8FC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DEHEMDHBKHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public DEHEMDHBKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E930", Offset = "0x6C8DB30", VA = "0x186C8E930")]
		internal void BEDMHMIGABG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct DOOGCCMFLKE : IAsyncStateMachine
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
		private DEHEMDHBKHJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E970", Offset = "0x6C8DB70", VA = "0x186C8E970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F030", Offset = "0x6C8E230", VA = "0x186C8F030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool JDFCAIONPBK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80")]
	public static bool FNOILNJKJCM(byte[] LEMIKFGMOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E5B0", Offset = "0x6C8D7B0", VA = "0x186C8E5B0")]
	[AsyncStateMachine(typeof(GHKAMCLMDHL))]
	public static Task<Texture2D> FDHNMGOFGDH(byte[] LEMIKFGMOIE, bool HBMJKDLAGDK = false, bool KNLAIFIJLOI = false, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E6F0", Offset = "0x6C8D8F0", VA = "0x186C8E6F0")]
	[AsyncStateMachine(typeof(DOOGCCMFLKE))]
	private static Task<Texture2D> JKAHPPEDBMF(int OFMCKDAMODD, int AAKHKDILCDN, bool KHAADLHLOCA, bool HBMJKDLAGDK, bool KNLAIFIJLOI, Action<NativeArray<byte>> CMNLOGJIDAB, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E840", Offset = "0x6C8DA40", VA = "0x186C8E840")]
	private static TextureFormat OHFGCFOEIBP(bool KHAADLHLOCA)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum IIKDFNJHMDE
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
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal static class FMLNHOKPAMO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F890", Offset = "0x6C8EA90", VA = "0x186C8F890")]
	public static bool ILAGDBIFCLD(byte[] LJIEGDEDOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F380", Offset = "0x6C8E580", VA = "0x186C8F380")]
	public static void FAMCKMIMAFA(byte[] LJIEGDEDOHM, [Out] int OFMCKDAMODD, [Out] int AAKHKDILCDN, [Out] IIKDFNJHMDE EAJPHFGLPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F8D0", Offset = "0x6C8EAD0", VA = "0x186C8F8D0")]
	private static uint NKBOEBFDBBJ(byte[] LJIEGDEDOHM, int NJJFLJLDLKI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F690", Offset = "0x6C8E890", VA = "0x186C8F690")]
	private static ulong HOKMGKCKMML(byte[] LJIEGDEDOHM, int NJJFLJLDLKI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NOOANHGGHBP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C918C0", Offset = "0x6C90AC0", VA = "0x186C918C0")]
	public static RenderTexture GALMJAJLHBI(int OFMCKDAMODD, int AAKHKDILCDN, int BGKNAPNDCNH, Camera MPMEEHICOGB, RenderTextureMemoryless FLHHPOMHBIH = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C91AF0", Offset = "0x6C90CF0", VA = "0x186C91AF0")]
	public static void IHKOCMHNKDC(RenderTexture FMCMPFBDEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class DELAOPIBOGB<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct OLHPGLCLCFK : IEquatable<OLHPGLCLCFK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId MGCPMEGDPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly NCCIJFPDDLD NJNFAFFEGHF;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4526CD0", Offset = "0x4525ED0", VA = "0x184526CD0")]
		public OLHPGLCLCFK(TImageId CPBLLDDDHEE, NCCIJFPDDLD BMCIAOGMBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x497AF30", Offset = "0x497A130", VA = "0x18497AF30", Slot = "4")]
		public bool Equals(DELAOPIBOGB<TImageId>.OLHPGLCLCFK KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x497AE20", Offset = "0x497A020", VA = "0x18497AE20", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x497B310", Offset = "0x497A510", VA = "0x18497B310", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x497B4B0", Offset = "0x497A6B0", VA = "0x18497B4B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LMCDPCAGOBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public GENINCKMOLO<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public LMCDPCAGOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4560F10", Offset = "0x4560110", VA = "0x184560F10")]
		internal void MOADPENIGNJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct BNGCEDMCIKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public OLHPGLCLCFK cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public DELAOPIBOGB<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NCCIJFPDDLD <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x52EBCA0", Offset = "0x52EAEA0", VA = "0x1852EBCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x52ECAD0", Offset = "0x52EBCD0", VA = "0x1852ECAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct APEHICPBOHA : IAsyncStateMachine
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
		public NCCIJFPDDLD textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public DELAOPIBOGB<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x447D6F0", Offset = "0x447C8F0", VA = "0x18447D6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x447E4F0", Offset = "0x447D6F0", VA = "0x18447E4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct KICKLBIJLJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x44A49B0", Offset = "0x44A3BB0", VA = "0x1844A49B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x44A4D70", Offset = "0x44A3F70", VA = "0x1844A4D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int HAICKGCINDB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim PGHNGPCAAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? FIPEDKBALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, NCCIJFPDDLD, CancellationToken, Task<Texture2D>>? KHJJNDLACML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? GKHJJLOEENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly AEEPOAHLHPA<OLHPGLCLCFK, Texture2D> BAKHIGNEFHM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5B2A210", Offset = "0x5B29410", VA = "0x185B2A210")]
	public DELAOPIBOGB(Func<TImageId, CancellationToken, Task<byte[]>> GNFHFDJEAHM, [Optional] Func<TImageId, string>? MNOAIIFHODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5B2A410", Offset = "0x5B29610", VA = "0x185B2A410")]
	public DELAOPIBOGB(Func<TImageId, NCCIJFPDDLD, CancellationToken, Task<Texture2D>> PJFJGAFALMO, [Optional] Func<TImageId, string>? MNOAIIFHODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5B2A060", Offset = "0x5B29260", VA = "0x185B2A060")]
	private DELAOPIBOGB(Func<TImageId, CancellationToken, Task<byte[]>>? GNFHFDJEAHM, Func<TImageId, NCCIJFPDDLD, CancellationToken, Task<Texture2D>>? PJFJGAFALMO, Func<TImageId, string>? MNOAIIFHODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5B293D0", Offset = "0x5B285D0", VA = "0x185B293D0")]
	public NMANDIAIDGE<Texture2D> BPLLHBCLFLF(TImageId HDECDPOHILC, NCCIJFPDDLD HCOOOBMACNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5B295C0", Offset = "0x5B287C0", VA = "0x185B295C0")]
	public void BPOAAOHNIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5B298D0", Offset = "0x5B28AD0", VA = "0x185B298D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B29CC0", Offset = "0x5B28EC0", VA = "0x185B29CC0")]
	[AsyncStateMachine(typeof(DELAOPIBOGB<>.BNGCEDMCIKB))]
	private Task<Texture2D> OHLLCPBFJPJ(OLHPGLCLCFK MLKPBJMLLBK, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5B29770", Offset = "0x5B28970", VA = "0x185B29770")]
	[AsyncStateMachine(typeof(DELAOPIBOGB<>.APEHICPBOHA))]
	private Task<Texture2D> DGHCJIKKAAB(byte[] LEMIKFGMOIE, NCCIJFPDDLD HCOOOBMACNB, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5B29B60", Offset = "0x5B28D60", VA = "0x185B29B60")]
	private void NHOFAGJCCKO(Texture2D AIEGELCMLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5B29B50", Offset = "0x5B28D50", VA = "0x185B29B50")]
	private bool GBEIACJHINE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5B29E10", Offset = "0x5B29010", VA = "0x185B29E10")]
	private bool OMOHKIICDFP(byte[] LEMIKFGMOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5B29970", Offset = "0x5B28B70", VA = "0x185B29970")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DELAOPIBOGB<>.KICKLBIJLJK))]
	internal static Task EELGJKCALAN(IDisposable OIGGIIFIDDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum NCCIJFPDDLD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
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
