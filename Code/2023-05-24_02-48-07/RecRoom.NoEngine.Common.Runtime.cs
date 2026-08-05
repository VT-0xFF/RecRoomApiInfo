using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FD80", Offset = "0x6F5E980", VA = "0x186F5FD80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x852750", Offset = "0x851350", VA = "0x180852750")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC81930", Offset = "0xC80530", VA = "0x180C81930")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class NEFDIDCKCBL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC81930", Offset = "0xC80530", VA = "0x180C81930")]
	public NEFDIDCKCBL(bool IEMHIOOBJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class KDNNMIKGJNK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xC81930", Offset = "0xC80530", VA = "0x180C81930")]
	public KDNNMIKGJNK(bool IEMHIOOBJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class AEIDOAEHPPH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B6E0", Offset = "0x6F5A2E0", VA = "0x186F5B6E0")]
	public AEIDOAEHPPH(bool IEMHIOOBJPD, string KPFOPAHJGOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.All)]
public class KPFEFEMPEAJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string JAIHBJHBALG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x852750", Offset = "0x851350", VA = "0x180852750")]
	public KPFEFEMPEAJ(string IDCNODJDCJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HKHBBOALFPG
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BCCLJANHCKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BCCLJANHCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B910", Offset = "0x6F5A510", VA = "0x186F5B910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E200", Offset = "0x6F5CE00", VA = "0x186F5E200")]
	public static Task<TaskStatus> OEOELENCOHL(this Task GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B650", Offset = "0x2B7A250", VA = "0x182B7B650")]
	public static Task<T> AMNHNGMHMJC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DFD0", Offset = "0x6F5CBD0", VA = "0x186F5DFD0")]
	public static Task MADHFCMCIFL(this Task GAKDIIFBLNI, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C250", Offset = "0x2B7AE50", VA = "0x182B7C250")]
	public static Task<TResult> MADHFCMCIFL<TResult>(this Task<TResult> GAKDIIFBLNI, CancellationToken FLDJLPKNKKO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DE80", Offset = "0x6F5CA80", VA = "0x186F5DE80")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(BCCLJANHCKF))]
	internal static Task<TaskStatus> LAFEBGMPFLJ(Task MDKOFFIJFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LCFIAEELDFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan BGBJBIPOPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? HAIALGNNHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FJGIPGEKOLP();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGIMABCMDOF();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAJNNIEMKJJ();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct AHIOEJCKGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly string MHGNIJCIFFL;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xAF3280", Offset = "0xAF1E80", VA = "0x180AF3280")]
	public AHIOEJCKGHM(string ECNGHFJBIJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0")]
	public static string DGIADCHILCD(in AHIOEJCKGHM GPOCLJBKMHA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x12C9FC0", Offset = "0x12C8BC0", VA = "0x1812C9FC0")]
	public static AHIOEJCKGHM DGIADCHILCD(string MDHJAFNLPON)
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B8C0", Offset = "0x6F5A4C0", VA = "0x186F5B8C0")]
	public string LNDGPDJIGJO(string IJAKCFMLLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B7C0", Offset = "0x6F5A3C0", VA = "0x186F5B7C0")]
	public string HLEKLDDJDEP(object EMENJDCGEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x835FF0", Offset = "0x834BF0", VA = "0x180835FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FDBENDDJJIN<T> : IEquatable<global::FDBENDDJJIN<T>>, global::KELNLDHHLCN<global::FDBENDDJJIN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T MHGNIJCIFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int OJOINFOLDPA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2681BE0", Offset = "0x26807E0", VA = "0x182681BE0")]
	public FDBENDDJJIN(in T ECNGHFJBIJL, int NHHNPPKPBIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA920", Offset = "0x2BD9520", VA = "0x182BDA920")]
	public static bool FMMDKFLNNFA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF4B0", Offset = "0x7AE8B0")] in global::FDBENDDJJIN<T> FDMHBFLJJHC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF520", Offset = "0x7AE920")] in global::FDBENDDJJIN<T> DNGDHCADJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x28893A0", Offset = "0x2887FA0", VA = "0x1828893A0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF590", Offset = "0x7AE990")] global::FDBENDDJJIN<T> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA7D0", Offset = "0x2BD93D0", VA = "0x182BDA7D0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB1A0", Offset = "0x2BD9DA0", VA = "0x182BDB1A0")]
	public bool OECIFILCLOC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF5F0", Offset = "0x7AE9F0")] in global::FDBENDDJJIN<T> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2BDADC0", Offset = "0x2BD99C0", VA = "0x182BDADC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2BDC160", Offset = "0x2BDAD60", VA = "0x182BDC160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB230", Offset = "0x2BD9E30", VA = "0x182BDB230")]
	public void PLOLBHIBFDI(out T ECNGHFJBIJL, out int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB9E0", Offset = "0x2BDA5E0", VA = "0x182BDB9E0")]
	public (T, int) PNBGCPOCGEL()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA780", Offset = "0x2BD9380", VA = "0x182BDA780", Slot = "5")]
	private bool ELIODBLNKOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF660", Offset = "0x7AEA60")] in global::FDBENDDJJIN<T> MDHJAFNLPON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LGPPBGNIAGA
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32BF0A0", Offset = "0x32BDCA0", VA = "0x1832BF0A0")]
	public static global::FDBENDDJJIN<T> DOBPLOGGNLM<T>(in T ECNGHFJBIJL, int NHHNPPKPBIA) where T : notnull
	{
		return default(global::FDBENDDJJIN<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DPIJIKFEAOC : IEquatable<DPIJIKFEAOC>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00", Slot = "4")]
	public bool Equals(DPIJIKFEAOC MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D170", Offset = "0x6F5BD70", VA = "0x186F5D170", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D1C0", Offset = "0x6F5BDC0", VA = "0x186F5D1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D1D0", Offset = "0x6F5BDD0", VA = "0x186F5D1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct JMIOBPDNDFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly KLJIFOKILDG DLBLDGGLHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly GILFKHMIONP MIKHHILFLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly HAPFCOLIGEJ GMOOKMHKFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly HMGNJKGPCOJ FPLDKDDJFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly MFBGNCDOMAP OEEFAIGLIOP;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly HAPFCOLIGEJ CPDNPDLPJOO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly HMGNJKGPCOJ DLGGFJNIFDH;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly MFBGNCDOMAP LBDIMMGNHEL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly JMIOBPDNDFO DGAPNEIIHNG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OKHCPHKNICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F5E490", Offset = "0x6F5D090", VA = "0x186F5E490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EA60", Offset = "0x6F5D660", VA = "0x186F5EA60")]
	public JMIOBPDNDFO(in KLJIFOKILDG OLGNMNNGODM, in GILFKHMIONP JBGDJLFDHDK, HAPFCOLIGEJ FMJEEJBJOHK, HMGNJKGPCOJ GEPMKKEGFLL, MFBGNCDOMAP JCJMOLOIMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E5D0", Offset = "0x6F5D1D0", VA = "0x186F5E5D0")]
	private static string MAPHHEDCIOC(object HHNPCHNMLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83E700", Offset = "0x83D300", VA = "0x18083E700")]
	private static long INKDBOKADIM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
	private static string HABHBMADGID(string EIJFOGFJFOP, string? ECGMNPFIIPH, bool KCAOEADDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E610", Offset = "0x6F5D210", VA = "0x186F5E610")]
	private static JMIOBPDNDFO OFDHHOGOACB()
	{
		return default(JMIOBPDNDFO);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OPPPAAFODNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public ulong CNADBJMMKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public long MJODBOFNDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public double PJFPFNDNGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public uint BCIDMEBOIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public uint EAGEJDIKBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int ECKMIBKOKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int NJCIIFNIAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float IIFICOJKGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float DOMJHEANIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public ushort IMDGHHLBBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public ushort CGNMOHOEOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public ushort GKPCFNIBCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ushort EHNBOKDJONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public short PAPCGIIKNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public short OPKNGPBPKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public short HAKHMGDABNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public short OPMEAFHBNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public char EAGEHHCDJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public char MKIBDEAPBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public char KPIIPNDJECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public char BBICHJPJMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public byte IPHJFPNCGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte JJIEMOCFGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public byte LFHBDDCKNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte GMLPJHEPIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte IKNDEEMHCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public byte PMDKOAPIGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte HFGKFBKPEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public byte FPCOBLHLDCP;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FE10", Offset = "0x6F5EA10", VA = "0x186F5FE10")]
	public static OPPPAAFODNC DOBPLOGGNLM(byte FEEBOAEBMMK, byte MGLAKJDFHDE, byte FDHBIKHEEKA, byte CNFGPJHOHLH, byte EDKBOBFCCCA, byte PHEAOICLKIG, byte CIKLKLBADMC, byte HKEHDOPGDDB)
	{
		return default(OPPPAAFODNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct KLJIFOKILDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly AJGINBCHPFH IDGKILFEKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly EGKBOHKDEOJ HMFNNHIEOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly AJGINBCHPFH OOKCEBPMLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly EGKBOHKDEOJ LDIDGAHJHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly AJGINBCHPFH JOENDHHDBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly EGKBOHKDEOJ CBCAPAIIHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly COCIDEIEIAK OAODJGACNGP;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly AJGINBCHPFH BBCIKHNFEMC;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly EGKBOHKDEOJ MOMMJBLMHIH;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly AJGINBCHPFH HAKKAFKMNIN;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly EGKBOHKDEOJ FADLKGMHPPG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly AJGINBCHPFH KMIPLOIBLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly EGKBOHKDEOJ MMBGHNDEEAP;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly COCIDEIEIAK EJBOPNHNABE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly KLJIFOKILDG DGAPNEIIHNG;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly AJGINBCHPFH MMBKMMIIBPL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OKHCPHKNICN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5ECB0", Offset = "0x6F5D8B0", VA = "0x186F5ECB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x207BE30", Offset = "0x207AA30", VA = "0x18207BE30")]
	public KLJIFOKILDG(AJGINBCHPFH PCPPAFFHIMF, EGKBOHKDEOJ EOFKAIMJEOP, AJGINBCHPFH JDGDALPKKKC, EGKBOHKDEOJ BKLPBDDACKK, AJGINBCHPFH HDBDCAODMJE, EGKBOHKDEOJ FHDKEOBFIOL, COCIDEIEIAK OCEGJANDHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0")]
	private static bool IGPPLCFKDAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	private static void NJKDOJHBPLC(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0")]
	private static bool DFBBKCHGCAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	private static void MIFLIEICBKG(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CA0", Offset = "0x7F18A0", VA = "0x1807F2CA0")]
	private static bool MPNHHNJHDEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	private static void DJFGEIHHPEE(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	private static void PFEJBLEHEIF(Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EF60", Offset = "0x6F5DB60", VA = "0x186F5EF60")]
	private static KLJIFOKILDG OFDHHOGOACB()
	{
		return default(KLJIFOKILDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D00", Offset = "0x7F1900", VA = "0x1807F2D00")]
	private static bool GPOPPAILJHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EC40", Offset = "0x6F5D840", VA = "0x186F5EC40")]
	public void JGIMFEIAGIB(object DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EEF0", Offset = "0x6F5DAF0", VA = "0x186F5EEF0")]
	public void NJNHBMLMKAJ(object DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EC20", Offset = "0x6F5D820", VA = "0x186F5EC20")]
	public void FCDHDKBAJAE(Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x366CE70", Offset = "0x366BA70", VA = "0x18366CE70")]
	public void NJNHBMLMKAJ<T>(T AIMHDAMIMIL, global::OKHAEKBAKMG<T> DKIECHCHJFL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x366CD70", Offset = "0x366B970", VA = "0x18366CD70")]
	public void JGIMFEIAGIB<T>(in T AIMHDAMIMIL, global::LNLPKOJBGAI<T> DKIECHCHJFL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EBA0", Offset = "0x6F5D7A0", VA = "0x186F5EBA0")]
	public bool CPDBGEABNJJ(bool PEAFIALKKOC, string DKIECHCHJFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EBBHJNPGDDO
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x262ACF0", Offset = "0x26298F0", VA = "0x18262ACF0")]
	public static IEnumerable<T> POEDBAPJBNJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
	public static T[] AGGJLKMNGMN<T>(params T[] BJKIJFHLHFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0")]
	public static IEnumerable<T> BMIEOPJELID<T>(params T[] BJKIJFHLHFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2058240", Offset = "0x2056E40", VA = "0x182058240")]
	public static HashSet<T> MGFHNOOIOIK<T>(params T[] BJKIJFHLHFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C895A0", Offset = "0x2C881A0", VA = "0x182C895A0")]
	public static KeyValuePair<TKey, TValue> NNAJMFPNLEO<TKey, TValue>(in TKey BDFCACLHAFA, in TValue ECNGHFJBIJL) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2058240", Offset = "0x2056E40", VA = "0x182058240")]
	public static List<T> DPJPKFDBEMJ<T>(IEnumerable<T> IHGFGANOELJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[AttributeUsage(AttributeTargets.All)]
public sealed class JLDMLEBKGGC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly string INKHNLNLHMK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x852750", Offset = "0x851350", VA = "0x180852750")]
	public JLDMLEBKGGC(string DNFOFIHCAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JIIBAAHNEOE
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x25CDC10", Offset = "0x25CC810", VA = "0x1825CDC10")]
	public static AHIOEJCKGHM PBMPKCBABKL<T>()
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25CDA10", Offset = "0x25CC610", VA = "0x1825CDA10")]
	public static AHIOEJCKGHM ENEHJEOGOEH<T>([CallerMemberName] string BPOKAAOBIOI = "") where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x25CDCA0", Offset = "0x25CC8A0", VA = "0x1825CDCA0")]
	public static AHIOEJCKGHM PBMPKCBABKL<T>(this T HDCPFIKNJDE) where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25CDAA0", Offset = "0x25CC6A0", VA = "0x1825CDAA0")]
	public static AHIOEJCKGHM JFJBDKOGDMM<T>(this T HDCPFIKNJDE, [CallerMemberName] string BPOKAAOBIOI = "") where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25CD970", Offset = "0x25CC570", VA = "0x1825CD970")]
	public static AHIOEJCKGHM ENEHJEOGOEH<T>(this T GPOCLJBKMHA, [CallerMemberName] string BPOKAAOBIOI = "") where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E410", Offset = "0x6F5D010", VA = "0x186F5E410")]
	public static AHIOEJCKGHM ENEHJEOGOEH(string FBMEGMBPHGH, [CallerMemberName] string BPOKAAOBIOI = "")
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E350", Offset = "0x6F5CF50", VA = "0x186F5E350")]
	public static string BJHJPLIGHDJ(this object GPOCLJBKMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[JEPPACIIAKC]
public delegate long HMGNJKGPCOJ();
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate void FEAMGIEAJKK<T>(in T AIMHDAMIMIL);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class KOIMFPHFEKC
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static JMIOBPDNDFO DNFALOOINGO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JMIOBPDNDFO CMDGIENFMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F5A0", Offset = "0x6F5E1A0", VA = "0x186F5F5A0")]
		get
		{
			return default(JMIOBPDNDFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KLJIFOKILDG DLBLDGGLHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FB80", Offset = "0x6F5E780", VA = "0x186F5FB80")]
		get
		{
			return default(KLJIFOKILDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static GILFKHMIONP MIKHHILFLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FBE0", Offset = "0x6F5E7E0", VA = "0x186F5FBE0")]
		get
		{
			return default(GILFKHMIONP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F760", Offset = "0x6F5E360", VA = "0x186F5F760")]
	public static void FGABHDDHFBC(in JMIOBPDNDFO AACCKMFILGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FA20", Offset = "0x6F5E620", VA = "0x186F5FA20")]
	public static void JGIMFEIAGIB(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FAD0", Offset = "0x6F5E6D0", VA = "0x186F5FAD0")]
	public static void NJNHBMLMKAJ(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x26287E0", Offset = "0x26273E0", VA = "0x1826287E0")]
	public static void NJNHBMLMKAJ<T>(T AIMHDAMIMIL, global::OKHAEKBAKMG<T> DKIECHCHJFL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F6E0", Offset = "0x6F5E2E0", VA = "0x186F5F6E0")]
	public static void FCDHDKBAJAE(Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F520", Offset = "0x6F5E120", VA = "0x186F5F520")]
	public static string BJHJPLIGHDJ(object HHNPCHNMLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F8C0", Offset = "0x6F5E4C0", VA = "0x186F5F8C0")]
	public static long GJPABLEJFLO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F600", Offset = "0x6F5E200", VA = "0x186F5F600")]
	public static bool CPDBGEABNJJ(bool PEAFIALKKOC, string DKIECHCHJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F930", Offset = "0x6F5E530", VA = "0x186F5F930")]
	public static double HNLELMOOMNE()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KKENKPCNBDB : LBDODDEEMPP
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly LBDODDEEMPP EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime NOOMFHNGOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5EAF0", Offset = "0x6F5D6F0", VA = "0x186F5EAF0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public KKENKPCNBDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class JEPPACIIAKC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
	public JEPPACIIAKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate TResult MLBPKFAHLJI<T, out TResult>(in T AIMHDAMIMIL);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult CLGHNELLHKC<T1, T2, out TResult>(in T1 EPJMNIPCFDJ, in T2 DCHBMHJPHKI);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class CCFPGIGIOPG : LCFIAEELDFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly TimeSpan IADDOJKEFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly System.Timers.Timer IDIJCJCNEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private TimeSpan OJHABJHLHAL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan BGBJBIPOPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BCF0", Offset = "0x6F5A8F0", VA = "0x186F5BCF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? HAIALGNNHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C0D0", Offset = "0x6F5ACD0", VA = "0x186F5C0D0")]
	[Preserve]
	public CCFPGIGIOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BEB0", Offset = "0x6F5AAB0", VA = "0x186F5BEB0")]
	public CCFPGIGIOPG(TimeSpan OJHABJHLHAL, [Optional] Action? NFKHMLNANLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BBA0", Offset = "0x6F5A7A0", VA = "0x186F5BBA0", Slot = "7")]
	public void FJGIPGEKOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BC80", Offset = "0x6F5A880", VA = "0x186F5BC80", Slot = "8")]
	public void IGIMABCMDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BCC0", Offset = "0x6F5A8C0", VA = "0x186F5BCC0", Slot = "9")]
	public void KAJNNIEMKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1821C80", Offset = "0x1820880", VA = "0x181821C80")]
	private void CCMIIEIFJED(object HDCPFIKNJDE, ElapsedEventArgs DOMDKMDGPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BC00", Offset = "0x6F5A800", VA = "0x186F5BC00")]
	private static void GPEAAMGGGEP(ref TimeSpan FMKOGHAFEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BB00", Offset = "0x6F5A700", VA = "0x186F5BB00", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Class)]
public class JIAMBIICBFF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
	public JIAMBIICBFF()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class PFABLHCCGAA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
	public PFABLHCCGAA(string PIJCAGFKEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface LBDODDEEMPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime NOOMFHNGOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct CDFDIKBCLLO : IEquatable<CDFDIKBCLLO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public uint IGFMJCGELKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int CBBALNADFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public float OHFINCEKBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public ushort IMDGHHLBBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public ushort CGNMOHOEOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public short PAPCGIIKNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public short OPKNGPBPKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public char EAGEHHCDJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public char MKIBDEAPBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public byte IPHJFPNCGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public byte JJIEMOCFGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public byte LFHBDDCKNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte GMLPJHEPIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool NBJHJDDKCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool KOBDENOLIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool KNLPPHLHGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool MHBDNAELDFK;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA92A00", Offset = "0xA91600", VA = "0x180A92A00")]
	public static CDFDIKBCLLO BMNEMIDKOOD(uint MIDLFDJEFKI)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA92A00", Offset = "0xA91600", VA = "0x180A92A00")]
	public static CDFDIKBCLLO PJEOJLHMHAJ(int GJDPNDOOJJE)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1036D80", Offset = "0x1035980", VA = "0x181036D80")]
	public static CDFDIKBCLLO AADPCLLMHNJ(float LFDKOLFODOG)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C140", Offset = "0x6F5AD40", VA = "0x186F5C140")]
	public static CDFDIKBCLLO ACGLACJFOPD(byte FEEBOAEBMMK, byte MGLAKJDFHDE, byte FDHBIKHEEKA, byte CNFGPJHOHLH)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C140", Offset = "0x6F5AD40", VA = "0x186F5C140")]
	public static CDFDIKBCLLO AAPOANHHNCN(bool LGKAFKMNLDM, bool EECFLAOLECI, bool GPCJGKDCCBO, bool AFGKIKKDCKA)
	{
		return default(CDFDIKBCLLO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x55E50C0", Offset = "0x55E3CC0", VA = "0x1855E50C0")]
	public static bool FMMDKFLNNFA(CDFDIKBCLLO EOEOFNCKKHJ, CDFDIKBCLLO AOEAFBFCPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xA90E40", Offset = "0xA8FA40", VA = "0x180A90E40", Slot = "4")]
	public bool Equals(CDFDIKBCLLO MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C160", Offset = "0x6F5AD60", VA = "0x186F5C160", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xC79500", Offset = "0xC78100", VA = "0x180C79500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C1F0", Offset = "0x6F5ADF0", VA = "0x186F5C1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[KPFEFEMPEAJ("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct NBIGGEBJMFN<T> : IEquatable<global::NBIGGEBJMFN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly T MHGNIJCIFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly bool LNEEOBOGIAA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DCGIGACHDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x288A800", Offset = "0x2889400", VA = "0x18288A800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x288AD90", Offset = "0x2889990", VA = "0x18288AD90")]
	public NBIGGEBJMFN(in T ECNGHFJBIJL, bool EFEABKGIBID)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2889FB0", Offset = "0x2888BB0", VA = "0x182889FB0")]
	public static bool FMMDKFLNNFA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AF9D0", Offset = "0x7AEDD0")] in global::NBIGGEBJMFN<T> FDMHBFLJJHC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AFA40", Offset = "0x7AEE40")] in global::NBIGGEBJMFN<T> DNGDHCADJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x28899D0", Offset = "0x28885D0", VA = "0x1828899D0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AFAB0", Offset = "0x7AEEB0")] global::NBIGGEBJMFN<T> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x28895A0", Offset = "0x28881A0", VA = "0x1828895A0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x288A780", Offset = "0x2889380", VA = "0x18288A780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x288AA10", Offset = "0x2889610", VA = "0x18288AA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LAKLAGNBOJK
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x262AD60", Offset = "0x2629960", VA = "0x18262AD60")]
	public static global::NBIGGEBJMFN<T> AFDJJHJKIGO<T>(in T ECNGHFJBIJL) where T : notnull
	{
		return default(global::NBIGGEBJMFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x262AE80", Offset = "0x2629A80", VA = "0x18262AE80")]
	public static global::NBIGGEBJMFN<T?> FNKNEKGCHCP<T>()
	{
		return default(global::NBIGGEBJMFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x262AF80", Offset = "0x2629B80", VA = "0x18262AF80")]
	public static bool JNNFHGBEAEE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7AFB50", Offset = "0x7AEF50")] this in global::NBIGGEBJMFN<T> PJNCIFGMLCL, [NEFDIDCKCBL(true)] out T ECNGHFJBIJL) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KELNLDHHLCN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OECIFILCLOC(in T MDHJAFNLPON);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct GILFKHMIONP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly EGOPNIBJDMK JEKBNOHBIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly BJJEKJIBNBK LCIAFPFHKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly EGOPNIBJDMK DPHFHBMOOLN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly BJJEKJIBNBK GGCCOACGCHA;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly GILFKHMIONP DGAPNEIIHNG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool OKHCPHKNICN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F5DB90", Offset = "0x6F5C790", VA = "0x186F5DB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x96B830", Offset = "0x96A430", VA = "0x18096B830")]
	public GILFKHMIONP(EGOPNIBJDMK HGGCLNACJBC, BJJEKJIBNBK HOOFGJFDPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	private static void EELNJPGADMA(string BPOKAAOBIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
	private static void BDAPFFLBHDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F5DC60", Offset = "0x6F5C860", VA = "0x186F5DC60")]
	private static GILFKHMIONP OFDHHOGOACB()
	{
		return default(GILFKHMIONP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KFBMKMFINLC
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3655860", Offset = "0x3654460", VA = "0x183655860")]
	public static bool OECIFILCLOC<T, U>(in T GPOCLJBKMHA, in U HHNPCHNMLMA) where T : notnull, global::KELNLDHHLCN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class IGKCFAAAOEO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly EqualityComparer<T> BCCHHDPCFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public T MHGNIJCIFFL;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1A13060", Offset = "0x1A11C60", VA = "0x181A13060")]
	public IGKCFAAAOEO(in T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1A12A80", Offset = "0x1A11680", VA = "0x181A12A80", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1A12C10", Offset = "0x1A11810", VA = "0x181A12C10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1A12E70", Offset = "0x1A11A70", VA = "0x181A12E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class EOLIPBHIHFF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long CEEEDEJCGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D410", Offset = "0x6F5C010", VA = "0x186F5D410")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long BNBBFAHFJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D700", Offset = "0x6F5C300", VA = "0x186F5D700")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double BIANIEIKHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D6A0", Offset = "0x6F5C2A0", VA = "0x186F5D6A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double PKKFELCHAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D470", Offset = "0x6F5C070", VA = "0x186F5D470")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double NEIIFGGNPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D760", Offset = "0x6F5C360", VA = "0x186F5D760")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double JPAHPEHJPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5D300", Offset = "0x6F5BF00", VA = "0x186F5D300")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D7D0", Offset = "0x6F5C3D0", VA = "0x186F5D7D0")]
	public static double OOOJNPDKKHB(long LJEMDOOBDKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D5F0", Offset = "0x6F5C1F0", VA = "0x186F5D5F0")]
	public static double KAAKPHCEBJC(long LJEMDOOBDKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D540", Offset = "0x6F5C140", VA = "0x186F5D540")]
	public static double IECNLGKKJLH(double FEEJMBIENJJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D360", Offset = "0x6F5BF60", VA = "0x186F5D360")]
	public static long DHFEEMDJAKD(long JJEEOOEDFIC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D7C0", Offset = "0x6F5C3C0", VA = "0x186F5D7C0")]
	public static long NGPOCKMDBHI(long FCDCOMAOJAN, long OBFPOLGFFMO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D200", Offset = "0x6F5BE00", VA = "0x186F5D200")]
	public static double AHFHIJOPNHD(long FCDCOMAOJAN, long OBFPOLGFFMO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D4D0", Offset = "0x6F5C0D0", VA = "0x186F5D4D0")]
	public static double IAHCLIABHCK(long FCDCOMAOJAN, long OBFPOLGFFMO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[JEPPACIIAKC]
public delegate void EGKBOHKDEOJ(string DKIECHCHJFL);
[Cpp2IlInjected.Token(Token = "0x200002D")]
[JEPPACIIAKC]
public delegate string HAPFCOLIGEJ(object HHNPCHNMLMA);
[Cpp2IlInjected.Token(Token = "0x200002E")]
[JEPPACIIAKC]
public delegate void BJJEKJIBNBK();
[Cpp2IlInjected.Token(Token = "0x200002F")]
public delegate object LNLPKOJBGAI<T>(in T PFFFGKKOEPM);
[Cpp2IlInjected.Token(Token = "0x2000030")]
public delegate object PEKPPGFHMFL();
[Cpp2IlInjected.Token(Token = "0x2000031")]
[JEPPACIIAKC]
public delegate string MFBGNCDOMAP(string EIJFOGFJFOP, string? ECGMNPFIIPH, bool KCAOEADDHDC);
[Cpp2IlInjected.Token(Token = "0x2000032")]
[JEPPACIIAKC]
public delegate bool AJGINBCHPFH();
[Cpp2IlInjected.Token(Token = "0x2000033")]
public delegate object OKHAEKBAKMG<T>(T PFFFGKKOEPM);
[Cpp2IlInjected.Token(Token = "0x2000034")]
[JEPPACIIAKC]
public delegate void EGOPNIBJDMK(string BPOKAAOBIOI);
[Cpp2IlInjected.Token(Token = "0x2000035")]
[JEPPACIIAKC]
public delegate void COCIDEIEIAK(Exception BPFOEEABMGN);
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
