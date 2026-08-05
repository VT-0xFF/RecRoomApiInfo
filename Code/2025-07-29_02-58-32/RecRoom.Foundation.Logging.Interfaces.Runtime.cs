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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class BIEFGLPCNKJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public BIEFGLPCNKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class APCLMGBDDBE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8318570", Offset = "0x8316F70", VA = "0x188318570")]
	public APCLMGBDDBE(int CGAAPEOHPIP, int KKFFLCKNLOL, int NBGGNKOHCHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class NNFMPLIKEHH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
	public NNFMPLIKEHH(bool NNBHAJBAIKL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class IOJCOPIIMDP : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8319120", Offset = "0x8317B20", VA = "0x188319120")]
	public IOJCOPIIMDP(string FLBFBHGDBLM, string IGEOMPONAKK = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class JFPDKLENIHG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x245ACC0", Offset = "0x24596C0", VA = "0x18245ACC0")]
	public JFPDKLENIHG(int PDKJBMPOMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum CMFEIMOOLMG
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
public interface EEDDMENCIIL
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CMONKHILJEG<T> : EEDDMENCIIL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHMAHHIJADL([In] CJCDFLLANBL ENKHHCDFHBC, T PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KIDLLAFFPLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LBAAGMNJNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int GKCDMHLMAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IJPHLIOEHEJ(Type AEOGKDPPBBE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNCFMCPGFEN(NativeParallelHashMap<int, NFNHCBCLHDC> OPPACCCPKCM, NativeArray<byte> GPCDCFCPGFK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GOGGCAOJJNE
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EHFONBGONMF
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class FAOONJMIMJH<T> : JMEINJAJIJP<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48D4670", Offset = "0x48D3070", VA = "0x1848D4670")]
	protected FAOONJMIMJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class JMEINJAJIJP<T> : CMONKHILJEG<T>, EEDDMENCIIL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4915100", Offset = "0x4913B00", VA = "0x184915100")]
	public void AHMAHHIJADL([In] CJCDFLLANBL ENKHHCDFHBC, T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected JMEINJAJIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4914FC0", Offset = "0x49139C0", VA = "0x184914FC0", Slot = "4")]
	private void AHBHHOOAPMO([In] CJCDFLLANBL ENKHHCDFHBC, T PDKJBMPOMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HKBLFEIEPPO<T> : CMONKHILJEG<NativeArray<T>>, EEDDMENCIIL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5050DB0", Offset = "0x504F7B0", VA = "0x185050DB0")]
	public void AHMAHHIJADL([In] CJCDFLLANBL ENKHHCDFHBC, NativeArray<T> PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3E1A850", Offset = "0x3E19250", VA = "0x183E1A850")]
	public static ReadOnlySpan<T> EMDBELDILGC<T>(NativeArray<T> JCEJMKLBKKB) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected HKBLFEIEPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5050F10", Offset = "0x504F910", VA = "0x185050F10", Slot = "4")]
	private void BNONOCBKLDO([In] CJCDFLLANBL ENKHHCDFHBC, NativeArray<T> PDKJBMPOMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class INKJCIELMEK : CMONKHILJEG<INKJCIELMEK.MGHBGEPGHKH>, EEDDMENCIIL
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct MGHBGEPGHKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	public void AHMAHHIJADL([In] CJCDFLLANBL ENKHHCDFHBC, MGHBGEPGHKH PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public INKJCIELMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	private void OAOHDINMNAG([In] CJCDFLLANBL ENKHHCDFHBC, MGHBGEPGHKH PDKJBMPOMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GMICLOEKAED : CMONKHILJEG<string>, EEDDMENCIIL
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly GMICLOEKAED NDAIDGNOFDA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8318D40", Offset = "0x8317740", VA = "0x188318D40")]
	public void AHMAHHIJADL([In] CJCDFLLANBL ENKHHCDFHBC, string PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GMICLOEKAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8319090", Offset = "0x8317A90", VA = "0x188319090", Slot = "4")]
	private void NHBIIKHNJAB([In] CJCDFLLANBL ENKHHCDFHBC, string PDKJBMPOMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class KGFBBJLGIOI<T> : EBDBMHGEBGH<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x48D4670", Offset = "0x48D3070", VA = "0x1848D4670")]
	protected KGFBBJLGIOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class EBDBMHGEBGH<T> : CMONKHILJEG<T>, EEDDMENCIIL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4915020", Offset = "0x4913A20", VA = "0x184915020")]
	public void AHMAHHIJADL([In] CJCDFLLANBL ENKHHCDFHBC, T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected EBDBMHGEBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4914FC0", Offset = "0x49139C0", VA = "0x184914FC0", Slot = "4")]
	private void AHBHHOOAPMO([In] CJCDFLLANBL ENKHHCDFHBC, T PDKJBMPOMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CJCDFLLANBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DOPBBPLHGGM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CJCDFLLANBL ENKHHCDFHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int NLJMAACPAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int CMHJDPAFEJG;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61BF940", Offset = "0x61BE340", VA = "0x1861BF940")]
		public DOPBBPLHGGM(CJCDFLLANBL ENKHHCDFHBC, int NLJMAACPAOK, int CMHJDPAFEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8318CE0", Offset = "0x83176E0", VA = "0x188318CE0")]
		public DOPBBPLHGGM KHJOCGEFPPO(ReadOnlySpan<byte> GPCDCFCPGFK)
		{
			return default(DOPBBPLHGGM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x43C7A60", Offset = "0x43C6460", VA = "0x1843C7A60")]
		public DOPBBPLHGGM KHJOCGEFPPO<T>(T GPCDCFCPGFK) where T : struct
		{
			return default(DOPBBPLHGGM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8318C40", Offset = "0x8317640", VA = "0x188318C40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private KIDLLAFFPLB EHEGBKOFLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, NFNHCBCLHDC> OPPACCCPKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> GPCDCFCPGFK;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8318A70", Offset = "0x8317470", VA = "0x188318A70")]
	public CJCDFLLANBL(KIDLLAFFPLB EHEGBKOFLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8318990", Offset = "0x8317390", VA = "0x188318990")]
	public int PDPPFIGJNIK(EEDDMENCIIL OEPNAGFCALD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83185C0", Offset = "0x8316FC0", VA = "0x1883185C0")]
	public DOPBBPLHGGM BJPLHKDFJJK(EEDDMENCIIL OEPNAGFCALD)
	{
		return default(DOPBBPLHGGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83186B0", Offset = "0x83170B0", VA = "0x1883186B0")]
	public DOPBBPLHGGM BJPLHKDFJJK(int EHMNDNPONPN)
	{
		return default(DOPBBPLHGGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8318860", Offset = "0x8317260", VA = "0x188318860")]
	public void GPEHLCFJCHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83187C0", Offset = "0x83171C0", VA = "0x1883187C0")]
	public CJCDFLLANBL EHCJELPFFAO()
	{
		return default(CJCDFLLANBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8318760", Offset = "0x8317160", VA = "0x188318760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class JPKFOBLOIJE
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D06C20", Offset = "0x3D05620", VA = "0x183D06C20")]
	public static CJCDFLLANBL MJGPLOFFIKO<T>([In] this CJCDFLLANBL ENKHHCDFHBC, CMONKHILJEG<T> OEPNAGFCALD, T PDKJBMPOMNC)
	{
		return default(CJCDFLLANBL);
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
