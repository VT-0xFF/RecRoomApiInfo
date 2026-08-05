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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BB69A0", Offset = "0x6BB53A0", VA = "0x186BB69A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BB4330", Offset = "0x6BB2D30", VA = "0x186BB4330")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DIPDOKDGDNJ
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
public interface OCJHHKFBJDH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DIPDOKDGDNJ HNAJDPCBFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLAKDNILFKC(VertexAttributeFormat EPLBBPBANLK, int KFMNLOMGBGI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AEBJPABOMAL
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
			[Cpp2IlInjected.Address(RVA = "0x6BB6B20", Offset = "0x6BB5520", VA = "0x186BB6B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6B10", Offset = "0x6BB5510", VA = "0x186BB6B10")]
		public Resolution(uint OFCNMBDJPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
		public Resolution(uint OFCNMBDJPHM, uint CONCKFNNMJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6A20", Offset = "0x6BB5420", VA = "0x186BB6A20")]
		public static Resolution NGKMHBIDPIH(Resolution[] JIEJKJIJPFC, Resolution OFNAMIIHFHK, int IJLODHIBCKA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EIGNANFJIDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution FMBLMEIPPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? LGGFDBEPJAM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint OFCNMBDJPHM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4B40", Offset = "0x6BB3540", VA = "0x186BB4B40")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution MKMHEEOFKIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6BB47F0", Offset = "0x6BB31F0", VA = "0x186BB47F0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE040", Offset = "0x1FDCA40", VA = "0x181FDE040")]
		public EIGNANFJIDP(Resolution FMBLMEIPPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4670", Offset = "0x6BB3070", VA = "0x186BB4670")]
		private static Resolution CBCBBCNHIII(Resolution LGGFDBEPJAM, DIPDOKDGDNJ LLJNHMFODEL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class BNHNHGELHGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution MHHJCHNABGB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution FANDPDEEJPM;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution AOODKNAJBFJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution MJJALFNBGPI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution AAHMDKKONPI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HNMJNFBPNFB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] ECNGLEINNMB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class DCICHLAABAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution AJJJIHCCKNA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution LFBGJDHBKOG;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution HOOOEMEGDIB;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution BBLBDHGHIDG;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution FJCEJJLCOFD;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] ECNGLEINNMB;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4350", Offset = "0x6BB2D50", VA = "0x186BB4350")]
		public static Resolution AIDIOOBKNFF(uint GLAECBJDJFJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution BHKEINNNCNG;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class GMHDAEGMHBL
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4F80", Offset = "0x6BB3980", VA = "0x186BB4F80")]
	public static bool PBLGNDFNPHO(byte[] LNCKNHNHHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4D70", Offset = "0x6BB3770", VA = "0x186BB4D70")]
	public static bool LLOBGMGMEDO(byte[] LNCKNHNHHDF, [Out] int GLAECBJDJFJ, [Out] int GBFKBKLFFAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4CE0", Offset = "0x6BB36E0", VA = "0x186BB4CE0")]
	private static int CGBLPEOOCAC(byte[] LNCKNHNHHDF, int BHLKMIGNPBH, [Out] ushort AOGOILDNAHK)
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
		public enum POMGGOCDHGF : byte
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
		private class FHMPJANLGLF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string DDDMPLCOGIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D HJOKAOLFFKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public POMGGOCDHGF FLFHHAGCLFK;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4BD0", Offset = "0x6BB35D0", VA = "0x186BB4BD0")]
			public FHMPJANLGLF(string DDDMPLCOGIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3A036E0", Offset = "0x3A020E0", VA = "0x183A036E0")]
			public FHMPJANLGLF(string DDDMPLCOGIM, Texture2D CGILPHBKMOF, POMGGOCDHGF BMMJHDACOGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4B90", Offset = "0x6BB3590", VA = "0x186BB4B90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FGJOKBFCHLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public POMGGOCDHGF textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public FGJOKBFCHLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4B50", Offset = "0x6BB3550", VA = "0x186BB4B50")]
			internal void FFMCLMNKAEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GCJNHCJNKPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public GCJNHCJNKPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4CA0", Offset = "0x6BB36A0", VA = "0x186BB4CA0")]
			internal GLNIGDBJEFO BNAGGBHNDIB(Texture2D t2d)
			{
				return default(GLNIGDBJEFO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class GCIFBFJIPIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public GCIFBFJIPIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4C20", Offset = "0x6BB3620", VA = "0x186BB4C20")]
			internal void MKFLGCHIEGC()
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
		private HABLMKCEIGL<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private FHMPJANLGLF _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private HABLMKCEIGL<GLNIGDBJEFO> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private HABLMKCEIGL<GLNIGDBJEFO> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x913F50", Offset = "0x912950", VA = "0x180913F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private FHMPJANLGLF memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6BB68F0", Offset = "0x6BB52F0", VA = "0x186BB68F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6820", Offset = "0x6BB5220", VA = "0x186BB6820")]
		public ManagedTexture(string DDDMPLCOGIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6880", Offset = "0x6BB5280", VA = "0x186BB6880")]
		public ManagedTexture(string DDDMPLCOGIM, bool AKDLAMLIPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5EA0", Offset = "0x6BB48A0", VA = "0x186BB5EA0")]
		public void EEDMGDLPIGN(RenderTexture POAEEBPJHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6530", Offset = "0x6BB4F30", VA = "0x186BB6530")]
		public HABLMKCEIGL<Texture2D> MNHIOHGILGN(POMGGOCDHGF BMMJHDACOGB, bool AAJAEEKLEEN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5D00", Offset = "0x6BB4700", VA = "0x186BB5D00")]
		public HABLMKCEIGL<GLNIGDBJEFO> CNEAMGBHOCC(bool AAJAEEKLEEN = false, int GEIGEPJKCNB = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5A10", Offset = "0x6BB4410", VA = "0x186BB5A10")]
		public HABLMKCEIGL<GLNIGDBJEFO> CBHDJAHOHID(bool AAJAEEKLEEN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5FE0", Offset = "0x6BB49E0", VA = "0x186BB5FE0")]
		private static HABLMKCEIGL<Texture2D> MFMEIEKCPOE(string DDDMPLCOGIM, RenderTexture POAEEBPJHMD, Texture2D ECJOKHPFGLA, bool AAJAEEKLEEN, POMGGOCDHGF ENPGMGIEDFG = POMGGOCDHGF.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5EE0", Offset = "0x6BB48E0", VA = "0x186BB5EE0")]
		public void EKKBIHPEOIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5E90", Offset = "0x6BB4890", VA = "0x186BB5E90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5F80", Offset = "0x6BB4980", VA = "0x186BB5F80")]
		[CompilerGenerated]
		private HABLMKCEIGL<byte[]> HAOGGPJMEDL(Texture2D CAFNEMLCPKH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BEHOPGPPNOO
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct JPNLJAFFOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5250", Offset = "0x6BB3C50", VA = "0x186BB5250")]
		public unsafe static extern void INJKDGIICID(void* JOGFKNPLOGB, void* NMMHFBINDGD, bool BBNLILOJMIL, bool GLBJGNEAOPG, bool NDPHFLDOMAK, [Out] int GLAECBJDJFJ, [Out] int GBFKBKLFFAE, [Out] bool JBPPMPKNKIK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class COOKPKNOFOJ
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
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public COOKPKNOFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4190", Offset = "0x6BB2B90", VA = "0x186BB4190")]
		internal void GMCFHNIODHA(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct CJFOANDLHOE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6BB3F00", Offset = "0x6BB2900", VA = "0x186BB3F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4120", Offset = "0x6BB2B20", VA = "0x186BB4120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LIDLNMAPKMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LIDLNMAPKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB59D0", Offset = "0x6BB43D0", VA = "0x186BB59D0")]
		internal void IONGOADGIPA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct BNMCFMKGPAM : IAsyncStateMachine
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
		private LIDLNMAPKMM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB37D0", Offset = "0x6BB21D0", VA = "0x186BB37D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3E90", Offset = "0x6BB2890", VA = "0x186BB3E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool CJIOHJGJINP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
	public static bool BEFGDABHBKM(byte[] KIFLPEFPBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3460", Offset = "0x6BB1E60", VA = "0x186BB3460")]
	[AsyncStateMachine(typeof(CJFOANDLHOE))]
	public static Task<Texture2D> MFIBKEGIBAC(byte[] KIFLPEFPBMB, bool GKIKPLCIPHG = false, bool PIGKJGMGKOM = false, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3280", Offset = "0x6BB1C80", VA = "0x186BB3280")]
	[AsyncStateMachine(typeof(BNMCFMKGPAM))]
	private static Task<Texture2D> GBEKCCIAEEJ(int GLAECBJDJFJ, int GBFKBKLFFAE, bool EACJCDFFDMP, bool GKIKPLCIPHG, bool PIGKJGMGKOM, Action<NativeArray<byte>> MHKNPNBJINA, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BB33D0", Offset = "0x6BB1DD0", VA = "0x186BB33D0")]
	private static TextureFormat GKDOHHGCNOI(bool EACJCDFFDMP)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum AJBBJBPIOKK
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
internal static class LHLLDKJKAAH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5990", Offset = "0x6BB4390", VA = "0x186BB5990")]
	public static bool OBHFCGCECBD(byte[] LNCKNHNHHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5550", Offset = "0x6BB3F50", VA = "0x186BB5550")]
	public static void MECLLJAINPG(byte[] LNCKNHNHHDF, [Out] int GLAECBJDJFJ, [Out] int GBFKBKLFFAE, [Out] AJBBJBPIOKK EPLBBPBANLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5860", Offset = "0x6BB4260", VA = "0x186BB5860")]
	private static uint MGMOELJMEGA(byte[] LNCKNHNHHDF, int ICLEKBDIINO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5350", Offset = "0x6BB3D50", VA = "0x186BB5350")]
	private static ulong MBEHHLEELKK(byte[] LNCKNHNHHDF, int ICLEKBDIINO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HMBNNCPFMBF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4FC0", Offset = "0x6BB39C0", VA = "0x186BB4FC0")]
	public static RenderTexture BGNMHOEOJPC(int GLAECBJDJFJ, int GBFKBKLFFAE, int PHFLJEEIDLB, Camera LPMABFPOKDA, RenderTextureMemoryless OLAKJAOINMI = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BB51F0", Offset = "0x6BB3BF0", VA = "0x186BB51F0")]
	public static void HNPKPAJBKBJ(RenderTexture POAEEBPJHMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class MNDMKLKOINM<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct LHNNBLMHHOJ : IEquatable<LHNNBLMHHOJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId GNDJCELBDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly HKPGJGACGBP HDICLOEJEAM;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x446E310", Offset = "0x446CD10", VA = "0x18446E310")]
		public LHNNBLMHHOJ(TImageId COMNIKKFEEB, HKPGJGACGBP KLBKMINDEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4496DF0", Offset = "0x44957F0", VA = "0x184496DF0", Slot = "4")]
		public bool Equals(MNDMKLKOINM<TImageId>.LHNNBLMHHOJ CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4496CE0", Offset = "0x44956E0", VA = "0x184496CE0", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4496EE0", Offset = "0x44958E0", VA = "0x184496EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4497090", Offset = "0x4495A90", VA = "0x184497090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CGEPDGBGMKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public JOELGMAPIIB<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CGEPDGBGMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x54D16F0", Offset = "0x54D00F0", VA = "0x1854D16F0")]
		internal void OHOHDKLBFKD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct CGHIGOKFJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public LHNNBLMHHOJ cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public MNDMKLKOINM<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private HKPGJGACGBP <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x54D1870", Offset = "0x54D0270", VA = "0x1854D1870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x54D26A0", Offset = "0x54D10A0", VA = "0x1854D26A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct IMFDAKPIDLA : IAsyncStateMachine
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
		public HKPGJGACGBP textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public MNDMKLKOINM<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x40AA3C0", Offset = "0x40A8DC0", VA = "0x1840AA3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x40AAAC0", Offset = "0x40A94C0", VA = "0x1840AAAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct MBDDOFDKDCF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4676E70", Offset = "0x4675870", VA = "0x184676E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4677230", Offset = "0x4675C30", VA = "0x184677230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int JFJDKFJPJGP = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim DKFGIFNGDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? CMHEKDIDPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, HKPGJGACGBP, CancellationToken, Task<Texture2D>>? FCFFGLDPIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? BKHHBEDDFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FCBLFPACJGL<LHNNBLMHHOJ, Texture2D> NBOHHOODHHF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x473EF50", Offset = "0x473D950", VA = "0x18473EF50")]
	public MNDMKLKOINM(Func<TImageId, CancellationToken, Task<byte[]>> GNIOLLGAMEK, [Optional] Func<TImageId, string>? IMNPMDJBNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x473ED50", Offset = "0x473D750", VA = "0x18473ED50")]
	public MNDMKLKOINM(Func<TImageId, HKPGJGACGBP, CancellationToken, Task<Texture2D>> AEFFDPEHJDD, [Optional] Func<TImageId, string>? IMNPMDJBNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x473EDA0", Offset = "0x473D7A0", VA = "0x18473EDA0")]
	private MNDMKLKOINM(Func<TImageId, CancellationToken, Task<byte[]>>? GNIOLLGAMEK, Func<TImageId, HKPGJGACGBP, CancellationToken, Task<Texture2D>>? AEFFDPEHJDD, Func<TImageId, string>? IMNPMDJBNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x473E260", Offset = "0x473CC60", VA = "0x18473E260")]
	public NNLLBGLJADF<Texture2D> HGDOPKCICEN(TImageId HPJLKKIKNBF, HKPGJGACGBP DCCKKAJIDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x473E6F0", Offset = "0x473D0F0", VA = "0x18473E6F0")]
	public void NBDCFPALFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x473DFA0", Offset = "0x473C9A0", VA = "0x18473DFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x473DE40", Offset = "0x473C840", VA = "0x18473DE40")]
	[AsyncStateMachine(typeof(MNDMKLKOINM<>.CGHIGOKFJKJ))]
	private Task<Texture2D> ABHFHMABJJD(LHNNBLMHHOJ LOHNBJHDMGO, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x473E740", Offset = "0x473D140", VA = "0x18473E740")]
	[AsyncStateMachine(typeof(MNDMKLKOINM<>.IMFDAKPIDLA))]
	private Task<Texture2D> PIKAJBLCBPH(byte[] KIFLPEFPBMB, HKPGJGACGBP DCCKKAJIDDH, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x473DF90", Offset = "0x473C990", VA = "0x18473DF90")]
	private void CDCFBJCHPJG(Texture2D CGILPHBKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x473E450", Offset = "0x473CE50", VA = "0x18473E450")]
	private bool JIALCFCGNJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x473E640", Offset = "0x473D040", VA = "0x18473E640")]
	private bool LGIOLEPPEIN(byte[] KIFLPEFPBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x473E550", Offset = "0x473CF50", VA = "0x18473E550")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(MNDMKLKOINM<>.MBDDOFDKDCF))]
	internal static Task JJCAEOCIJOA(IDisposable BMBFOHMIDIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum HKPGJGACGBP : byte
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
