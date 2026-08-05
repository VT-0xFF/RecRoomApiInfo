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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class BLLGIPNOANK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
	public BLLGIPNOANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class KPBMMDBMOAP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F6B0", Offset = "0x7D5E0B0", VA = "0x187D5F6B0")]
	public KPBMMDBMOAP(int OPKPFANIILK, int FNJJGIBEPBI, int DGGCKOAIJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LCEPHAMEBJC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
	public LCEPHAMEBJC(bool KBFODDPANKA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class BAGMCMBMDID : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D5EBF0", Offset = "0x7D5D5F0", VA = "0x187D5EBF0")]
	public BAGMCMBMDID(string GBCFHNGPBLM, string NLIGMLKPGCH = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class LCAKFLABJBB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x22DE1E0", Offset = "0x22DCBE0", VA = "0x1822DE1E0")]
	public LCAKFLABJBB(int PCDAHJCDHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum JGFNNKEKNLL
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
public interface PKHFFMFMALB
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OFIELNFCDMC<T> : PKHFFMFMALB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPPPCFEBBMH([In] DJAHKKFHNJP MAPDHHGCEEM, T PCDAHJCDHHF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NLEMDJOCJLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BAJLDGBKKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int JIAKFAHDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BOHMNCAFADF(Type HHCAOFMCNLG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ADHCNNJDFNL(NativeParallelHashMap<int, JOGKEMLKOOJ> GMBPOMFEMOJ, NativeArray<byte> HPGIDELCODH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OCFCACFLDBE
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CLMKGPHPIOA
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class FHKHNHLOPAG<T> : KGKFEILCBIG<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x465BD60", Offset = "0x465A760", VA = "0x18465BD60")]
	protected FHKHNHLOPAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class KGKFEILCBIG<T> : OFIELNFCDMC<T>, PKHFFMFMALB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x51BDF10", Offset = "0x51BC910", VA = "0x1851BDF10")]
	public void GPPPCFEBBMH([In] DJAHKKFHNJP MAPDHHGCEEM, T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected KGKFEILCBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x51BDEF0", Offset = "0x51BC8F0", VA = "0x1851BDEF0", Slot = "4")]
	private void GEGAKJIHMGJ([In] DJAHKKFHNJP MAPDHHGCEEM, T PCDAHJCDHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class ONIMLBOACPO<T> : OFIELNFCDMC<NativeArray<T>>, PKHFFMFMALB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x569FA20", Offset = "0x569E420", VA = "0x18569FA20")]
	public void GPPPCFEBBMH([In] DJAHKKFHNJP MAPDHHGCEEM, NativeArray<T> PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6F80", Offset = "0x3BC5980", VA = "0x183BC6F80")]
	public static ReadOnlySpan<T> IBGJCCKMCID<T>(NativeArray<T> KLDOGKPLNJA) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected ONIMLBOACPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x569FB70", Offset = "0x569E570", VA = "0x18569FB70", Slot = "4")]
	private void PJLLCAHALIO([In] DJAHKKFHNJP MAPDHHGCEEM, NativeArray<T> PCDAHJCDHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IPAFELIFJOK : OFIELNFCDMC<IPAFELIFJOK.APACPPHPFAP>, PKHFFMFMALB
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct APACPPHPFAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	public void GPPPCFEBBMH([In] DJAHKKFHNJP MAPDHHGCEEM, APACPPHPFAP PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public IPAFELIFJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	private void BMDOPGKEFCK([In] DJAHKKFHNJP MAPDHHGCEEM, APACPPHPFAP PCDAHJCDHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HNGBEFKGIIB : OFIELNFCDMC<string>, PKHFFMFMALB
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HNGBEFKGIIB FDCAMNOGINK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F2E0", Offset = "0x7D5DCE0", VA = "0x187D5F2E0")]
	public void GPPPCFEBBMH([In] DJAHKKFHNJP MAPDHHGCEEM, string PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public HNGBEFKGIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F630", Offset = "0x7D5E030", VA = "0x187D5F630", Slot = "4")]
	private void KDPDIALAJLE([In] DJAHKKFHNJP MAPDHHGCEEM, string PCDAHJCDHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class IABGFFCJJMK<T> : MOHBKDHJLLM<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x465BD60", Offset = "0x465A760", VA = "0x18465BD60")]
	protected IABGFFCJJMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class MOHBKDHJLLM<T> : OFIELNFCDMC<T>, PKHFFMFMALB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x54AB080", Offset = "0x54A9A80", VA = "0x1854AB080")]
	public void GPPPCFEBBMH([In] DJAHKKFHNJP MAPDHHGCEEM, T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected MOHBKDHJLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x51BDEF0", Offset = "0x51BC8F0", VA = "0x1851BDEF0", Slot = "4")]
	private void GEGAKJIHMGJ([In] DJAHKKFHNJP MAPDHHGCEEM, T PCDAHJCDHHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DJAHKKFHNJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct MPMGFKADJJG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DJAHKKFHNJP MAPDHHGCEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int AMIJGLCLFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int MPGHINJDACO;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D9BC20", Offset = "0x5D9A620", VA = "0x185D9BC20")]
		public MPMGFKADJJG(DJAHKKFHNJP MAPDHHGCEEM, int AMIJGLCLFDC, int MPGHINJDACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D5F7A0", Offset = "0x7D5E1A0", VA = "0x187D5F7A0")]
		public MPMGFKADJJG JKCBLMLJDDD(ReadOnlySpan<byte> HPGIDELCODH)
		{
			return default(MPMGFKADJJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x418A2D0", Offset = "0x4188CD0", VA = "0x18418A2D0")]
		public MPMGFKADJJG JKCBLMLJDDD<T>(T HPGIDELCODH) where T : struct
		{
			return default(MPMGFKADJJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7D5F700", Offset = "0x7D5E100", VA = "0x187D5F700", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private NLEMDJOCJLM FIEKIDOEOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, JOGKEMLKOOJ> GMBPOMFEMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> HPGIDELCODH;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F100", Offset = "0x7D5DB00", VA = "0x187D5F100")]
	public DJAHKKFHNJP(NLEMDJOCJLM FIEKIDOEOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D5ECA0", Offset = "0x7D5D6A0", VA = "0x187D5ECA0")]
	public int GGAFHPOBHAN(PKHFFMFMALB IKCNAPIHBJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D5EEE0", Offset = "0x7D5D8E0", VA = "0x187D5EEE0")]
	public MPMGFKADJJG MMCGDNALPKE(PKHFFMFMALB IKCNAPIHBJG)
	{
		return default(MPMGFKADJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D5EE30", Offset = "0x7D5D830", VA = "0x187D5EE30")]
	public MPMGFKADJJG MMCGDNALPKE(int IGLMBACPDJA)
	{
		return default(MPMGFKADJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D5EFD0", Offset = "0x7D5D9D0", VA = "0x187D5EFD0")]
	public void OOFIDCNAHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D5ED90", Offset = "0x7D5D790", VA = "0x187D5ED90")]
	public DJAHKKFHNJP JCMHGMGGFCA()
	{
		return default(DJAHKKFHNJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D5EC40", Offset = "0x7D5D640", VA = "0x187D5EC40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ENBCNPDILPK
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38FD2C0", Offset = "0x38FBCC0", VA = "0x1838FD2C0")]
	public static DJAHKKFHNJP PBDMKLNODMP<T>([In] this DJAHKKFHNJP MAPDHHGCEEM, OFIELNFCDMC<T> IKCNAPIHBJG, T PCDAHJCDHHF)
	{
		return default(DJAHKKFHNJP);
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
