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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DFD730", Offset = "0x6DFCB30", VA = "0x186DFD730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DFA880", Offset = "0x6DF9C80", VA = "0x186DFA880")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PGFNDADEIDD
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
public interface JEIPKIBEAJE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PGFNDADEIDD MDOKPCNLDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGNOFMCBEIN(VertexAttributeFormat BIFHNMDIJFJ, int OMHGPECPMNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MAGMECMJILD
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
			[Cpp2IlInjected.Address(RVA = "0x6DFDF30", Offset = "0x6DFD330", VA = "0x186DFDF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6DFDF20", Offset = "0x6DFD320", VA = "0x186DFDF20")]
		public Resolution(uint LBEGFJJGJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
		public Resolution(uint LBEGFJJGJFP, uint GAMIAAAKNPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DFDE30", Offset = "0x6DFD230", VA = "0x186DFDE30")]
		public static Resolution JGMEIPOPKPO(Resolution[] ALOJIDNACGI, Resolution LFFNLIOMBFE, int KOPLFDIGBJE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class GNBEOLABFDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution PNAICIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? OINDBFGHMED;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint LBEGFJJGJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6DFAE50", Offset = "0x6DFA250", VA = "0x186DFAE50")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution NOPGHJINDFH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6DFAE60", Offset = "0x6DFA260", VA = "0x186DFAE60")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x93DA20", Offset = "0x93CE20", VA = "0x18093DA20")]
		public GNBEOLABFDC(Resolution PNAICIMFOBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DFB1B0", Offset = "0x6DFA5B0", VA = "0x186DFB1B0")]
		private static Resolution NACOHABOGBI(Resolution OINDBFGHMED, PGFNDADEIDD OMDIIJEEGMD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class HJNKNOPEIAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution JKODKMPLCBD;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution FPMJKMEINOF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution LFMCMGDBCOE;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution OAFEKMKKEKK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution BKBJAKKPGMO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution GHDCIALIOHP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] NFCHMPBBMPI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class KCDCBMDELIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution LEFPNNONGPL;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution DCDPJOFNDOM;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution KIEIEJHFLNK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution HKMEINAIHKG;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution DIHOFNCGHKK;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] NFCHMPBBMPI;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DFB520", Offset = "0x6DFA920", VA = "0x186DFB520")]
		public static Resolution IICINFKDKCC(uint MPCPDNDCONE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution EPAIJHFGDIK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class DBJHFBPLDEB
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DFA930", Offset = "0x6DF9D30", VA = "0x186DFA930")]
	public static bool OAOPMFKFJNF(byte[] AIKOCCMKKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6DFA970", Offset = "0x6DF9D70", VA = "0x186DFA970")]
	public static bool PNFHKIMJLGO(byte[] AIKOCCMKKAE, [Out] int MPCPDNDCONE, [Out] int GHAMDAHJBAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DFA8A0", Offset = "0x6DF9CA0", VA = "0x186DFA8A0")]
	private static int GCHEHDDNHFC(byte[] AIKOCCMKKAE, int PGAHHGFJKBL, [Out] ushort MNIMCDGAEMG)
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
		public enum GDIJPIHOCEF : byte
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
		private class NHIOBDMIGIN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string DDDHPCNFCEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D FCDPELFMJDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GDIJPIHOCEF JLOBKCIABNN;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6DFD6E0", Offset = "0x6DFCAE0", VA = "0x186DFD6E0")]
			public NHIOBDMIGIN(string DDDHPCNFCEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x442A5B0", Offset = "0x44299B0", VA = "0x18442A5B0")]
			public NHIOBDMIGIN(string DDDHPCNFCEK, Texture2D NAKFIPIKBBJ, GDIJPIHOCEF CKOPIOHOHPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DFD6A0", Offset = "0x6DFCAA0", VA = "0x186DFD6A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FFEPELKKBJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public GDIJPIHOCEF textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public FFEPELKKBJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6DFAB80", Offset = "0x6DF9F80", VA = "0x186DFAB80")]
			internal void BMGFICEFNHI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class NEKJCPBIABA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public NEKJCPBIABA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6DFCF30", Offset = "0x6DFC330", VA = "0x186DFCF30")]
			internal GAAGHBMDKKG CFMHEDJIKPF(Texture2D t2d)
			{
				return default(GAAGHBMDKKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MOEILHMENKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public MOEILHMENKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6DFBF10", Offset = "0x6DFB310", VA = "0x186DFBF10")]
			internal void FFIAMDMGOOJ()
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
		private MJGAHFINLMO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NHIOBDMIGIN _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private MJGAHFINLMO<GAAGHBMDKKG> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MJGAHFINLMO<GAAGHBMDKKG> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x946390", Offset = "0x945790", VA = "0x180946390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private NHIOBDMIGIN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6DFCE80", Offset = "0x6DFC280", VA = "0x186DFCE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCDB0", Offset = "0x6DFC1B0", VA = "0x186DFCDB0")]
		public ManagedTexture(string DDDHPCNFCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE10", Offset = "0x6DFC210", VA = "0x186DFCE10")]
		public ManagedTexture(string DDDHPCNFCEK, bool NEBDHPLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DFBF90", Offset = "0x6DFB390", VA = "0x186DFBF90")]
		public void CJFEBAHNNCM(RenderTexture BAHOLLCLDKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DFBFD0", Offset = "0x6DFB3D0", VA = "0x186DFBFD0")]
		public MJGAHFINLMO<Texture2D> DHGPKJGHIAC(GDIJPIHOCEF CKOPIOHOHPM, bool BEOPHDMJKPJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC370", Offset = "0x6DFB770", VA = "0x186DFC370")]
		public MJGAHFINLMO<GAAGHBMDKKG> KBBHNILLLIP(bool BEOPHDMJKPJ = false, int PJOPCCEPIAJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCA60", Offset = "0x6DFBE60", VA = "0x186DFCA60")]
		public MJGAHFINLMO<GAAGHBMDKKG> NPIMEJCALOF(bool BEOPHDMJKPJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC510", Offset = "0x6DFB910", VA = "0x186DFC510")]
		private static MJGAHFINLMO<Texture2D> LNNHAEMAKIC(string DDDHPCNFCEK, RenderTexture BAHOLLCLDKG, Texture2D EPFKFLFGMML, bool BEOPHDMJKPJ, GDIJPIHOCEF MAFOCOFGAPN = GDIJPIHOCEF.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC2D0", Offset = "0x6DFB6D0", VA = "0x186DFC2D0")]
		public void JIAOGCCIDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6DFC2C0", Offset = "0x6DFB6C0", VA = "0x186DFC2C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCD50", Offset = "0x6DFC150", VA = "0x186DFCD50")]
		[CompilerGenerated]
		private MJGAHFINLMO<byte[]> OCEPEBNBPOP(Texture2D IBGKHJOOAOJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MLICBBLOELE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct BJNNCBPOEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DFA4B0", Offset = "0x6DF98B0", VA = "0x186DFA4B0")]
		public unsafe static extern void CBOACMMDABL(void* HGMBCADJECC, void* CJFFIHKDKOL, bool JFAFFBLDJLO, bool ADDLIECBGMK, bool CFNHGLEMPGG, [Out] int MPCPDNDCONE, [Out] int GHAMDAHJBAG, [Out] bool ABDMFBFKBDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class MBNMBDDDPCP
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
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MBNMBDDDPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6DFBA10", Offset = "0x6DFAE10", VA = "0x186DFBA10")]
		internal void JLCIAHMIGCO(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct CDOMBDNDKAB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6DFA5F0", Offset = "0x6DF99F0", VA = "0x186DFA5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DFA810", Offset = "0x6DF9C10", VA = "0x186DFA810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BLNCLNMMBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BLNCLNMMBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6DFA5B0", Offset = "0x6DF99B0", VA = "0x186DFA5B0")]
		internal void LCMOAKPOMDM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct NGFKBMJMEOL : IAsyncStateMachine
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
		private BLNCLNMMBEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCF70", Offset = "0x6DFC370", VA = "0x186DFCF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD630", Offset = "0x6DFCA30", VA = "0x186DFD630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool KAPIEFLPNPF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
	public static bool BGAOGOAKKKL(byte[] DBIOBHIPMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DFBD90", Offset = "0x6DFB190", VA = "0x186DFBD90")]
	[AsyncStateMachine(typeof(CDOMBDNDKAB))]
	public static Task<Texture2D> KEHHLMBLGLO(byte[] DBIOBHIPMOP, bool BNPHKJHFMIB = false, bool GKGPCHOFEPM = false, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DFBBB0", Offset = "0x6DFAFB0", VA = "0x186DFBBB0")]
	[AsyncStateMachine(typeof(NGFKBMJMEOL))]
	private static Task<Texture2D> HCIFBHIJBPO(int MPCPDNDCONE, int GHAMDAHJBAG, bool HCGNODNFKLF, bool BNPHKJHFMIB, bool GKGPCHOFEPM, Action<NativeArray<byte>> COECPOALPGE, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DFBD00", Offset = "0x6DFB100", VA = "0x186DFBD00")]
	private static TextureFormat HFJKEHOCBOD(bool HCGNODNFKLF)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum COFDEFEBNFL
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
internal static class OFKHHFINOEG
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DFDAC0", Offset = "0x6DFCEC0", VA = "0x186DFDAC0")]
	public static bool FECLBKOCKJG(byte[] AIKOCCMKKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DFD7B0", Offset = "0x6DFCBB0", VA = "0x186DFD7B0")]
	public static void FDIJMHDJHAO(byte[] AIKOCCMKKAE, [Out] int MPCPDNDCONE, [Out] int GHAMDAHJBAG, [Out] COFDEFEBNFL BIFHNMDIJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DFDB00", Offset = "0x6DFCF00", VA = "0x186DFDB00")]
	private static uint HFNLPJNIEMJ(byte[] AIKOCCMKKAE, int IJLPKFECKFC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6DFDC30", Offset = "0x6DFD030", VA = "0x186DFDC30")]
	private static ulong JDDIAHOEKEB(byte[] AIKOCCMKKAE, int IJLPKFECKFC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class GACGKEKABDH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DFAC20", Offset = "0x6DFA020", VA = "0x186DFAC20")]
	public static RenderTexture JECKFGBJLBH(int MPCPDNDCONE, int GHAMDAHJBAG, int BDOPOCAJCCN, Camera EMNPAABKIAH, RenderTextureMemoryless GJCELIAACIO = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DFABC0", Offset = "0x6DF9FC0", VA = "0x186DFABC0")]
	public static void ELALAMBAFMN(RenderTexture BAHOLLCLDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class GIBHMGCACHO<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct DLHFEBBKDHO : IEquatable<DLHFEBBKDHO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId IFBGHMMGDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly NNNBHGHMDIA IKHAGKLFNIL;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0420", Offset = "0x3BBF820", VA = "0x183BC0420")]
		public DLHFEBBKDHO(TImageId OEOMDKHBDFI, NNNBHGHMDIA MNNLCLMBNGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5CAC030", Offset = "0x5CAB430", VA = "0x185CAC030", Slot = "4")]
		public bool Equals(GIBHMGCACHO<TImageId>.DLHFEBBKDHO KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5CABE20", Offset = "0x5CAB220", VA = "0x185CABE20", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5CAC350", Offset = "0x5CAB750", VA = "0x185CAC350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5CAC4F0", Offset = "0x5CAB8F0", VA = "0x185CAC4F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NBOKBNEPEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public KEACOJOOGKI<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NBOKBNEPEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x48B6B90", Offset = "0x48B5F90", VA = "0x1848B6B90")]
		internal void MBGPBIBJJAL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LNDBBNKAHNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public DLHFEBBKDHO cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public GIBHMGCACHO<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NNNBHGHMDIA <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x45E9A70", Offset = "0x45E8E70", VA = "0x1845E9A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x45EA160", Offset = "0x45E9560", VA = "0x1845EA160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct FGNJOGPKBHL : IAsyncStateMachine
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
		public NNNBHGHMDIA textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public GIBHMGCACHO<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3F399C0", Offset = "0x3F38DC0", VA = "0x183F399C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3F3A7E0", Offset = "0x3F39BE0", VA = "0x183F3A7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct DOIPLKGIGNE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5CC7E00", Offset = "0x5CC7200", VA = "0x185CC7E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8040", Offset = "0x5CC7440", VA = "0x185CC8040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int EMPBJILAOIO = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim CGMIEIIKLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? KCKINKNKGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, NNNBHGHMDIA, CancellationToken, Task<Texture2D>>? DEEAJEBLNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? NGOHIHEBBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly IPJNHCBKGPM<DLHFEBBKDHO, Texture2D> GANGLIJHHFF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x40A7250", Offset = "0x40A6650", VA = "0x1840A7250")]
	public GIBHMGCACHO(Func<TImageId, CancellationToken, Task<byte[]>> PLMNCFKFHGI, [Optional] Func<TImageId, string>? BPBFONLLGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x40A72A0", Offset = "0x40A66A0", VA = "0x1840A72A0")]
	public GIBHMGCACHO(Func<TImageId, NNNBHGHMDIA, CancellationToken, Task<Texture2D>> DMAAFJJLNGB, [Optional] Func<TImageId, string>? BPBFONLLGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x40A74B0", Offset = "0x40A68B0", VA = "0x1840A74B0")]
	private GIBHMGCACHO(Func<TImageId, CancellationToken, Task<byte[]>>? PLMNCFKFHGI, Func<TImageId, NNNBHGHMDIA, CancellationToken, Task<Texture2D>>? DMAAFJJLNGB, Func<TImageId, string>? BPBFONLLGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x40A6980", Offset = "0x40A5D80", VA = "0x1840A6980")]
	public GHMLKDLFDEG<Texture2D> LHBELHOKPEJ(TImageId LCINHKILPJF, NNNBHGHMDIA HNPLLGPBNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x40A6920", Offset = "0x40A5D20", VA = "0x1840A6920")]
	public void JNBIDEBDAON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x40A67C0", Offset = "0x40A5BC0", VA = "0x1840A67C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x40A6470", Offset = "0x40A5870", VA = "0x1840A6470")]
	[AsyncStateMachine(typeof(GIBHMGCACHO<>.LNDBBNKAHNF))]
	private Task<Texture2D> BEHFJBGAMFD(DLHFEBBKDHO JFMMGIJOFEJ, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40A6DD0", Offset = "0x40A61D0", VA = "0x1840A6DD0")]
	[AsyncStateMachine(typeof(GIBHMGCACHO<>.FGNJOGPKBHL))]
	private Task<Texture2D> PHKDCFBLPKO(byte[] DBIOBHIPMOP, NNNBHGHMDIA HNPLLGPBNPG, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40A6DC0", Offset = "0x40A61C0", VA = "0x1840A6DC0")]
	private void LPGIGOHMOGP(Texture2D NAKFIPIKBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x40A67B0", Offset = "0x40A5BB0", VA = "0x1840A67B0")]
	private bool DOPPLELHBAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x40A6870", Offset = "0x40A5C70", VA = "0x1840A6870")]
	private bool EGOIOINFHBN(byte[] DBIOBHIPMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x40A66C0", Offset = "0x40A5AC0", VA = "0x1840A66C0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GIBHMGCACHO<>.DOIPLKGIGNE))]
	internal static Task DDAALCEPLIN(IDisposable OPMCLMOAJGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum NNNBHGHMDIA : byte
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
