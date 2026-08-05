using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class OMMGCNHCFKJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
	public OMMGCNHCFKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class FKGKJAFIDID : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B40020", Offset = "0x7B3E820", VA = "0x187B40020")]
	public FKGKJAFIDID(int LBLAFDELPAC, int LNLIGBEDBFP, int IGDODBOHILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class CDLLMDGDFNN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
	public CDLLMDGDFNN(bool MAKLMCBPEEK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class HNJGAMOLPPA : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B40070", Offset = "0x7B3E870", VA = "0x187B40070")]
	public HNJGAMOLPPA(string GLGOHIJMLFB, string NIAMDMBDIJG = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class HDPHPBIBHME : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2112550", Offset = "0x2110D50", VA = "0x182112550")]
	public HDPHPBIBHME(int OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum JLIEKCLKFDF
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NonNetworked = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Incoming = 2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Outgoing = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Suppressed = 8,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	FastForward = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	CacheRemove = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Default = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	All = 0x3F
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OJJCMCLECBK
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GDHBICOIOFO<T> : OJJCMCLECBK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NELCJHCBLDE([In] BMIOLHIFBGO JPDHKCACAIK, T OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GLBCLPCAPGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MJAIPHKJPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DOBBEIMDEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HPCBLBHAAOE(Type PIJHKCJDAHO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GKEIKPEMOHJ(NativeParallelHashMap<int, CFCDJGMMHDE> LPANGBAAEHJ, NativeArray<byte> NFNBKNAJBPN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JJGHBDLJNMP
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AIGJAKHNKKL
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class MCHKIONKMJK<T> : IDIENJLGMPB<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x43AA000", Offset = "0x43A8800", VA = "0x1843AA000")]
	protected MCHKIONKMJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class IDIENJLGMPB<T> : GDHBICOIOFO<T>, OJJCMCLECBK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B5F620", Offset = "0x4B5DE20", VA = "0x184B5F620")]
	public void NELCJHCBLDE([In] BMIOLHIFBGO JPDHKCACAIK, T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected IDIENJLGMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B5F5E0", Offset = "0x4B5DDE0", VA = "0x184B5F5E0", Slot = "4")]
	private void GNBFCHCFHDK([In] BMIOLHIFBGO JPDHKCACAIK, T OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class OGJEHAJGAJI<T> : GDHBICOIOFO<NativeArray<T>>, OJJCMCLECBK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5471420", Offset = "0x546FC20", VA = "0x185471420")]
	public void NELCJHCBLDE([In] BMIOLHIFBGO JPDHKCACAIK, NativeArray<T> OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3938240", Offset = "0x3936A40", VA = "0x183938240")]
	public static ReadOnlySpan<T> NFKLJBIOMDD<T>(NativeArray<T> CPIDEKBKOPO) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected OGJEHAJGAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x54713D0", Offset = "0x546FBD0", VA = "0x1854713D0", Slot = "4")]
	private void DHOJLCKBMJK([In] BMIOLHIFBGO JPDHKCACAIK, NativeArray<T> OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ICDBHAGIEHI : GDHBICOIOFO<ICDBHAGIEHI.LLCFNOCIGGO>, OJJCMCLECBK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct LLCFNOCIGGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	public void NELCJHCBLDE([In] BMIOLHIFBGO JPDHKCACAIK, LLCFNOCIGGO OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public ICDBHAGIEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	private void MFABBNFMDEI([In] BMIOLHIFBGO JPDHKCACAIK, LLCFNOCIGGO OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DLCNBPNMKFM : GDHBICOIOFO<string>, OJJCMCLECBK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly DLCNBPNMKFM DJLOIKDDKCN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B3FC60", Offset = "0x7B3E460", VA = "0x187B3FC60")]
	public void NELCJHCBLDE([In] BMIOLHIFBGO JPDHKCACAIK, string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DLCNBPNMKFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B3FC50", Offset = "0x7B3E450", VA = "0x187B3FC50", Slot = "4")]
	private void JDCNNEPLJEB([In] BMIOLHIFBGO JPDHKCACAIK, string OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class JNBCLIFABDN<T> : PGECKGDHFFK<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x43AA000", Offset = "0x43A8800", VA = "0x1843AA000")]
	protected JNBCLIFABDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class PGECKGDHFFK<T> : GDHBICOIOFO<T>, OJJCMCLECBK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5558A30", Offset = "0x5557230", VA = "0x185558A30")]
	public void NELCJHCBLDE([In] BMIOLHIFBGO JPDHKCACAIK, T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected PGECKGDHFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B5F5E0", Offset = "0x4B5DDE0", VA = "0x184B5F5E0", Slot = "4")]
	private void GNBFCHCFHDK([In] BMIOLHIFBGO JPDHKCACAIK, T OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BMIOLHIFBGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DBBPDEMDDBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BMIOLHIFBGO JPDHKCACAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int GFEPONALANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int PBCBDAKAGEI;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5BB24B0", Offset = "0x5BB0CB0", VA = "0x185BB24B0")]
		public DBBPDEMDDBE(BMIOLHIFBGO JPDHKCACAIK, int GFEPONALANB, int PBCBDAKAGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B3FB50", Offset = "0x7B3E350", VA = "0x187B3FB50")]
		public DBBPDEMDDBE BPMIAFPKFBP(ReadOnlySpan<byte> NFNBKNAJBPN)
		{
			return default(DBBPDEMDDBE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3E87350", Offset = "0x3E85B50", VA = "0x183E87350")]
		public DBBPDEMDDBE BPMIAFPKFBP<T>(T NFNBKNAJBPN) where T : struct
		{
			return default(DBBPDEMDDBE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3FBB0", Offset = "0x7B3E3B0", VA = "0x187B3FBB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private GLBCLPCAPGH BBECHOEGLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, CFCDJGMMHDE> LPANGBAAEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> NFNBKNAJBPN;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B3F980", Offset = "0x7B3E180", VA = "0x187B3F980")]
	public BMIOLHIFBGO(GLBCLPCAPGH BBECHOEGLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B3F4D0", Offset = "0x7B3DCD0", VA = "0x187B3F4D0")]
	public int CBBFJEGBKLE(OJJCMCLECBK KKFPDDCHJNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B3F890", Offset = "0x7B3E090", VA = "0x187B3F890")]
	public DBBPDEMDDBE MOFFKKIDFDD(OJJCMCLECBK KKFPDDCHJNO)
	{
		return default(DBBPDEMDDBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B3F7E0", Offset = "0x7B3DFE0", VA = "0x187B3F7E0")]
	public DBBPDEMDDBE MOFFKKIDFDD(int HGDHGALMHHA)
	{
		return default(DBBPDEMDDBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7B3F610", Offset = "0x7B3DE10", VA = "0x187B3F610")]
	public void INCLKNPFIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B3F740", Offset = "0x7B3DF40", VA = "0x187B3F740")]
	public BMIOLHIFBGO MMGGKEIOFEE()
	{
		return default(BMIOLHIFBGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B3F5B0", Offset = "0x7B3DDB0", VA = "0x187B3F5B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ODEHKNKLBJD
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x395D980", Offset = "0x395C180", VA = "0x18395D980")]
	public static BMIOLHIFBGO OIHLAKEIFNH<T>([In] this BMIOLHIFBGO JPDHKCACAIK, GDHBICOIOFO<T> KKFPDDCHJNO, T OPMIAMEJKDH)
	{
		return default(BMIOLHIFBGO);
	}
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
