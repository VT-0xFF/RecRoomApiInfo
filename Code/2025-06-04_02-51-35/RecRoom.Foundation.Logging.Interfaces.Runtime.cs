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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class KKHDPMKIKKK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
	public KKHDPMKIKKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class MLNMLPOCKMH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FB77A0", Offset = "0x7FB5FA0", VA = "0x187FB77A0")]
	public MLNMLPOCKMH(int GGIJOHIPOOO, int NCINIHKPEBG, int IPMFMAODLOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class GGNFEAKGMAP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
	public GGNFEAKGMAP(bool GGOEANBOJMP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class EFAILDFAGGC : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7380", Offset = "0x7FB5B80", VA = "0x187FB7380")]
	public EFAILDFAGGC(string HPANEBBHGAC, string LLAMBGFCPPC = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class MMBHDNECINK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x226E7D0", Offset = "0x226CFD0", VA = "0x18226E7D0")]
	public MMBHDNECINK(int MGONBEDEDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum GCGEGJLBNPD
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
public interface MALLDGKAFNP
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HLCGBBAHPIO<T> : MALLDGKAFNP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COLNFOKPACC([In] DCOCDKFIAPG LJHAFAJCJML, T MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BAOLPIPNJAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EFAECJIHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KELCEKEMKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GBKKFLFELIP(Type CEPGAJKBPDM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJGJCGKFLCN(NativeParallelHashMap<int, OFIADOPPLCJ> LGACFNJFHND, NativeArray<byte> IMINNNCPCJF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DLCDGEEBPJH
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CHAEJPNNDFO
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class NJDHDFKMAKJ<T> : DNMDDCFNFFE<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4665B70", Offset = "0x4664370", VA = "0x184665B70")]
	protected NJDHDFKMAKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class DNMDDCFNFFE<T> : HLCGBBAHPIO<T>, MALLDGKAFNP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF090", Offset = "0x4CED890", VA = "0x184CEF090")]
	public void COLNFOKPACC([In] DCOCDKFIAPG LJHAFAJCJML, T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected DNMDDCFNFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF420", Offset = "0x4CEDC20", VA = "0x184CEF420", Slot = "4")]
	private void HGEPKMOCOFA([In] DCOCDKFIAPG LJHAFAJCJML, T MGONBEDEDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class GMFADAMCAFP<T> : HLCGBBAHPIO<NativeArray<T>>, MALLDGKAFNP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4CA83A0", Offset = "0x4CA6BA0", VA = "0x184CA83A0")]
	public void COLNFOKPACC([In] DCOCDKFIAPG LJHAFAJCJML, NativeArray<T> MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B50930", Offset = "0x3B4F130", VA = "0x183B50930")]
	public static ReadOnlySpan<T> BDCOOOHFFND<T>(NativeArray<T> LPBOBEPEKNH) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected GMFADAMCAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8520", Offset = "0x4CA6D20", VA = "0x184CA8520", Slot = "4")]
	private void OBMAIEMEKCE([In] DCOCDKFIAPG LJHAFAJCJML, NativeArray<T> MGONBEDEDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IOCCCGFFGKL : HLCGBBAHPIO<IOCCCGFFGKL.AIDILOIFBJD>, MALLDGKAFNP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct AIDILOIFBJD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	public void COLNFOKPACC([In] DCOCDKFIAPG LJHAFAJCJML, AIDILOIFBJD MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IOCCCGFFGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	private void PDAOMCAIKFH([In] DCOCDKFIAPG LJHAFAJCJML, AIDILOIFBJD MGONBEDEDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GMOJMHOABJD : HLCGBBAHPIO<string>, MALLDGKAFNP
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly GMOJMHOABJD HPECEAELCLK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FB73D0", Offset = "0x7FB5BD0", VA = "0x187FB73D0")]
	public void COLNFOKPACC([In] DCOCDKFIAPG LJHAFAJCJML, string MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GMOJMHOABJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7720", Offset = "0x7FB5F20", VA = "0x187FB7720", Slot = "4")]
	private void MFCCBCODIIL([In] DCOCDKFIAPG LJHAFAJCJML, string MGONBEDEDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class IAFCEAEEOGN<T> : HBFCMHHONIK<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4665B70", Offset = "0x4664370", VA = "0x184665B70")]
	protected IAFCEAEEOGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class HBFCMHHONIK<T> : HLCGBBAHPIO<T>, MALLDGKAFNP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4CEEFB0", Offset = "0x4CED7B0", VA = "0x184CEEFB0")]
	public void COLNFOKPACC([In] DCOCDKFIAPG LJHAFAJCJML, T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected HBFCMHHONIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4CEF420", Offset = "0x4CEDC20", VA = "0x184CEF420", Slot = "4")]
	private void HGEPKMOCOFA([In] DCOCDKFIAPG LJHAFAJCJML, T MGONBEDEDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DCOCDKFIAPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct OGMOHBPCEPJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DCOCDKFIAPG LJHAFAJCJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int FIHDCPFIMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int HJPKEAFJKFO;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F13180", Offset = "0x5F11980", VA = "0x185F13180")]
		public OGMOHBPCEPJ(DCOCDKFIAPG LJHAFAJCJML, int FIHDCPFIMPC, int HJPKEAFJKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7890", Offset = "0x7FB6090", VA = "0x187FB7890")]
		public OGMOHBPCEPJ PNLAIMGFDFO(ReadOnlySpan<byte> IMINNNCPCJF)
		{
			return default(OGMOHBPCEPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x412D2A0", Offset = "0x412BAA0", VA = "0x18412D2A0")]
		public OGMOHBPCEPJ PNLAIMGFDFO<T>(T IMINNNCPCJF) where T : struct
		{
			return default(OGMOHBPCEPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FB77F0", Offset = "0x7FB5FF0", VA = "0x187FB77F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BAOLPIPNJAN NHFDBLECNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, OFIADOPPLCJ> LGACFNJFHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> IMINNNCPCJF;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FB71B0", Offset = "0x7FB59B0", VA = "0x187FB71B0")]
	public DCOCDKFIAPG(BAOLPIPNJAN NHFDBLECNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FB70D0", Offset = "0x7FB58D0", VA = "0x187FB70D0")]
	public int HNNAKBKNDKF(MALLDGKAFNP KDNIJMFFINB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6DB0", Offset = "0x7FB55B0", VA = "0x187FB6DB0")]
	public OGMOHBPCEPJ AONKDBKOEBA(MALLDGKAFNP KDNIJMFFINB)
	{
		return default(OGMOHBPCEPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6D00", Offset = "0x7FB5500", VA = "0x187FB6D00")]
	public OGMOHBPCEPJ AONKDBKOEBA(int NFIFLOPMBOM)
	{
		return default(OGMOHBPCEPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6FA0", Offset = "0x7FB57A0", VA = "0x187FB6FA0")]
	public void GGJCANIPOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6F00", Offset = "0x7FB5700", VA = "0x187FB6F00")]
	public DCOCDKFIAPG FBONGFMPKDI()
	{
		return default(DCOCDKFIAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6EA0", Offset = "0x7FB56A0", VA = "0x187FB6EA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AAJPJHMLLLI
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41DFD40", Offset = "0x41DE540", VA = "0x1841DFD40")]
	public static DCOCDKFIAPG GGGBGBDKNKJ<T>([In] this DCOCDKFIAPG LJHAFAJCJML, HLCGBBAHPIO<T> KDNIJMFFINB, T MGONBEDEDON)
	{
		return default(DCOCDKFIAPG);
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
