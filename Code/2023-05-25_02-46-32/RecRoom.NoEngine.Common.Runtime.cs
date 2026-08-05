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
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F987C0", Offset = "0x6F96FC0", VA = "0x186F987C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C6D40", VA = "0x1808C8540")]
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
		[Cpp2IlInjected.Address(RVA = "0xD79980", Offset = "0xD78180", VA = "0x180D79980")]
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
	[Cpp2IlInjected.Address(RVA = "0xD79980", Offset = "0xD78180", VA = "0x180D79980")]
	public NEFDIDCKCBL(bool IEMHIOOBJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class KDNNMIKGJNK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xD79980", Offset = "0xD78180", VA = "0x180D79980")]
	public KDNNMIKGJNK(bool IEMHIOOBJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class AEIDOAEHPPH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F94120", Offset = "0x6F92920", VA = "0x186F94120")]
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
	[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C6D40", VA = "0x1808C8540")]
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BCCLJANHCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F94350", Offset = "0x6F92B50", VA = "0x186F94350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F96C40", Offset = "0x6F95440", VA = "0x186F96C40")]
	public static Task<TaskStatus> OEOELENCOHL(this Task GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB070", Offset = "0x2DD9870", VA = "0x182DDB070")]
	public static Task<T> AMNHNGMHMJC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F96A10", Offset = "0x6F95210", VA = "0x186F96A10")]
	public static Task MADHFCMCIFL(this Task GAKDIIFBLNI, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBC70", Offset = "0x2DDA470", VA = "0x182DDBC70")]
	public static Task<TResult> MADHFCMCIFL<TResult>(this Task<TResult> GAKDIIFBLNI, CancellationToken FLDJLPKNKKO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F968C0", Offset = "0x6F950C0", VA = "0x186F968C0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
	public AHIOEJCKGHM(string ECNGHFJBIJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
	public static string DGIADCHILCD(in AHIOEJCKGHM GPOCLJBKMHA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x14F2960", Offset = "0x14F1160", VA = "0x1814F2960")]
	public static AHIOEJCKGHM DGIADCHILCD(string MDHJAFNLPON)
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F94300", Offset = "0x6F92B00", VA = "0x186F94300")]
	public string LNDGPDJIGJO(string IJAKCFMLLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F94200", Offset = "0x6F92A00", VA = "0x186F94200")]
	public string HLEKLDDJDEP(object EMENJDCGEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x14F25E0", Offset = "0x14F0DE0", VA = "0x1814F25E0")]
	public FDBENDDJJIN(in T ECNGHFJBIJL, int NHHNPPKPBIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x260A270", Offset = "0x2608A70", VA = "0x18260A270")]
	public static bool FMMDKFLNNFA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9240", Offset = "0x7B8640")] in global::FDBENDDJJIN<T> FDMHBFLJJHC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B92B0", Offset = "0x7B86B0")] in global::FDBENDDJJIN<T> DNGDHCADJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x260A090", Offset = "0x2608890", VA = "0x18260A090", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9320", Offset = "0x7B8720")] global::FDBENDDJJIN<T> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x260A000", Offset = "0x2608800", VA = "0x18260A000", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x260AAF0", Offset = "0x26092F0", VA = "0x18260AAF0")]
	public bool OECIFILCLOC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9380", Offset = "0x7B8780")] in global::FDBENDDJJIN<T> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x260A710", Offset = "0x2608F10", VA = "0x18260A710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x260BAB0", Offset = "0x260A2B0", VA = "0x18260BAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x260AB80", Offset = "0x2609380", VA = "0x18260AB80")]
	public void PLOLBHIBFDI(out T ECNGHFJBIJL, out int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x260B330", Offset = "0x2609B30", VA = "0x18260B330")]
	public (T, int) PNBGCPOCGEL()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2609FB0", Offset = "0x26087B0", VA = "0x182609FB0", Slot = "5")]
	private bool ELIODBLNKOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B93F0", Offset = "0x7B87F0")] in global::FDBENDDJJIN<T> MDHJAFNLPON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LGPPBGNIAGA
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3547C00", Offset = "0x3546400", VA = "0x183547C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "4")]
	public bool Equals(DPIJIKFEAOC MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F95BB0", Offset = "0x6F943B0", VA = "0x186F95BB0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F95C00", Offset = "0x6F94400", VA = "0x186F95C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F95C10", Offset = "0x6F94410", VA = "0x186F95C10", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F96ED0", Offset = "0x6F956D0", VA = "0x186F96ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F974A0", Offset = "0x6F95CA0", VA = "0x186F974A0")]
	public JMIOBPDNDFO(in KLJIFOKILDG OLGNMNNGODM, in GILFKHMIONP JBGDJLFDHDK, HAPFCOLIGEJ FMJEEJBJOHK, HMGNJKGPCOJ GEPMKKEGFLL, MFBGNCDOMAP JCJMOLOIMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F97010", Offset = "0x6F95810", VA = "0x186F97010")]
	private static string MAPHHEDCIOC(object HHNPCHNMLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F1E10", VA = "0x1807F3610")]
	private static long INKDBOKADIM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x94BA40", Offset = "0x94A240", VA = "0x18094BA40")]
	private static string HABHBMADGID(string EIJFOGFJFOP, string? ECGMNPFIIPH, bool KCAOEADDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F97050", Offset = "0x6F95850", VA = "0x186F97050")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F98850", Offset = "0x6F97050", VA = "0x186F98850")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F976F0", Offset = "0x6F95EF0", VA = "0x186F976F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2348E50", Offset = "0x2347650", VA = "0x182348E50")]
	public KLJIFOKILDG(AJGINBCHPFH PCPPAFFHIMF, EGKBOHKDEOJ EOFKAIMJEOP, AJGINBCHPFH JDGDALPKKKC, EGKBOHKDEOJ BKLPBDDACKK, AJGINBCHPFH HDBDCAODMJE, EGKBOHKDEOJ FHDKEOBFIOL, COCIDEIEIAK OCEGJANDHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0")]
	private static bool IGPPLCFKDAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	private static void NJKDOJHBPLC(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0")]
	private static bool DFBBKCHGCAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	private static void MIFLIEICBKG(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0")]
	private static bool MPNHHNJHDEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	private static void DJFGEIHHPEE(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	private static void PFEJBLEHEIF(Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F979A0", Offset = "0x6F961A0", VA = "0x186F979A0")]
	private static KLJIFOKILDG OFDHHOGOACB()
	{
		return default(KLJIFOKILDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740")]
	private static bool GPOPPAILJHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F97680", Offset = "0x6F95E80", VA = "0x186F97680")]
	public void JGIMFEIAGIB(object DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F97930", Offset = "0x6F96130", VA = "0x186F97930")]
	public void NJNHBMLMKAJ(object DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F97660", Offset = "0x6F95E60", VA = "0x186F97660")]
	public void FCDHDKBAJAE(Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x394CDA0", Offset = "0x394B5A0", VA = "0x18394CDA0")]
	public void NJNHBMLMKAJ<T>(T AIMHDAMIMIL, global::OKHAEKBAKMG<T> DKIECHCHJFL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x394CCA0", Offset = "0x394B4A0", VA = "0x18394CCA0")]
	public void JGIMFEIAGIB<T>(in T AIMHDAMIMIL, global::LNLPKOJBGAI<T> DKIECHCHJFL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F975E0", Offset = "0x6F95DE0", VA = "0x186F975E0")]
	public bool CPDBGEABNJJ(bool PEAFIALKKOC, string DKIECHCHJFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EBBHJNPGDDO
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28F4750", Offset = "0x28F2F50", VA = "0x1828F4750")]
	public static IEnumerable<T> POEDBAPJBNJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x94BA40", Offset = "0x94A240", VA = "0x18094BA40")]
	public static T[] AGGJLKMNGMN<T>(params T[] BJKIJFHLHFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x94BA40", Offset = "0x94A240", VA = "0x18094BA40")]
	public static IEnumerable<T> BMIEOPJELID<T>(params T[] BJKIJFHLHFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2325260", Offset = "0x2323A60", VA = "0x182325260")]
	public static HashSet<T> MGFHNOOIOIK<T>(params T[] BJKIJFHLHFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2F49FB0", Offset = "0x2F487B0", VA = "0x182F49FB0")]
	public static KeyValuePair<TKey, TValue> NNAJMFPNLEO<TKey, TValue>(in TKey BDFCACLHAFA, in TValue ECNGHFJBIJL) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2325260", Offset = "0x2323A60", VA = "0x182325260")]
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
	[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C6D40", VA = "0x1808C8540")]
	public JLDMLEBKGGC(string DNFOFIHCAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JIIBAAHNEOE
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2937980", Offset = "0x2936180", VA = "0x182937980")]
	public static AHIOEJCKGHM PBMPKCBABKL<T>()
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2937780", Offset = "0x2935F80", VA = "0x182937780")]
	public static AHIOEJCKGHM ENEHJEOGOEH<T>([CallerMemberName] string BPOKAAOBIOI = "") where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2937A10", Offset = "0x2936210", VA = "0x182937A10")]
	public static AHIOEJCKGHM PBMPKCBABKL<T>(this T HDCPFIKNJDE) where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2937810", Offset = "0x2936010", VA = "0x182937810")]
	public static AHIOEJCKGHM JFJBDKOGDMM<T>(this T HDCPFIKNJDE, [CallerMemberName] string BPOKAAOBIOI = "") where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29376E0", Offset = "0x2935EE0", VA = "0x1829376E0")]
	public static AHIOEJCKGHM ENEHJEOGOEH<T>(this T GPOCLJBKMHA, [CallerMemberName] string BPOKAAOBIOI = "") where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F96E50", Offset = "0x6F95650", VA = "0x186F96E50")]
	public static AHIOEJCKGHM ENEHJEOGOEH(string FBMEGMBPHGH, [CallerMemberName] string BPOKAAOBIOI = "")
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F96D90", Offset = "0x6F95590", VA = "0x186F96D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F97FE0", Offset = "0x6F967E0", VA = "0x186F97FE0")]
		get
		{
			return default(JMIOBPDNDFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KLJIFOKILDG DLBLDGGLHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F985C0", Offset = "0x6F96DC0", VA = "0x186F985C0")]
		get
		{
			return default(KLJIFOKILDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static GILFKHMIONP MIKHHILFLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F98620", Offset = "0x6F96E20", VA = "0x186F98620")]
		get
		{
			return default(GILFKHMIONP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F981A0", Offset = "0x6F969A0", VA = "0x186F981A0")]
	public static void FGABHDDHFBC(in JMIOBPDNDFO AACCKMFILGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F98460", Offset = "0x6F96C60", VA = "0x186F98460")]
	public static void JGIMFEIAGIB(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F98510", Offset = "0x6F96D10", VA = "0x186F98510")]
	public static void NJNHBMLMKAJ(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x28F20D0", Offset = "0x28F08D0", VA = "0x1828F20D0")]
	public static void NJNHBMLMKAJ<T>(T AIMHDAMIMIL, global::OKHAEKBAKMG<T> DKIECHCHJFL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F98120", Offset = "0x6F96920", VA = "0x186F98120")]
	public static void FCDHDKBAJAE(Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F97F60", Offset = "0x6F96760", VA = "0x186F97F60")]
	public static string BJHJPLIGHDJ(object HHNPCHNMLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F98300", Offset = "0x6F96B00", VA = "0x186F98300")]
	public static long GJPABLEJFLO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F98040", Offset = "0x6F96840", VA = "0x186F98040")]
	public static bool CPDBGEABNJJ(bool PEAFIALKKOC, string DKIECHCHJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F98370", Offset = "0x6F96B70", VA = "0x186F98370")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F97530", Offset = "0x6F95D30", VA = "0x186F97530", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public KKENKPCNBDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class JEPPACIIAKC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F94730", Offset = "0x6F92F30", VA = "0x186F94730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? HAIALGNNHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F94B10", Offset = "0x6F93310", VA = "0x186F94B10")]
	[Preserve]
	public CCFPGIGIOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F948F0", Offset = "0x6F930F0", VA = "0x186F948F0")]
	public CCFPGIGIOPG(TimeSpan OJHABJHLHAL, [Optional] Action? NFKHMLNANLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F945E0", Offset = "0x6F92DE0", VA = "0x186F945E0", Slot = "7")]
	public void FJGIPGEKOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F946C0", Offset = "0x6F92EC0", VA = "0x186F946C0", Slot = "8")]
	public void IGIMABCMDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F94700", Offset = "0x6F92F00", VA = "0x186F94700", Slot = "9")]
	public void KAJNNIEMKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1AFE1F0", Offset = "0x1AFC9F0", VA = "0x181AFE1F0")]
	private void CCMIIEIFJED(object HDCPFIKNJDE, ElapsedEventArgs DOMDKMDGPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F94640", Offset = "0x6F92E40", VA = "0x186F94640")]
	private static void GPEAAMGGGEP(ref TimeSpan FMKOGHAFEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F94540", Offset = "0x6F92D40", VA = "0x186F94540", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Class)]
public class JIAMBIICBFF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
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
	[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
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
	[Cpp2IlInjected.Address(RVA = "0xB30AD0", Offset = "0xB2F2D0", VA = "0x180B30AD0")]
	public static CDFDIKBCLLO BMNEMIDKOOD(uint MIDLFDJEFKI)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xB30AD0", Offset = "0xB2F2D0", VA = "0x180B30AD0")]
	public static CDFDIKBCLLO PJEOJLHMHAJ(int GJDPNDOOJJE)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x12033B0", Offset = "0x1201BB0", VA = "0x1812033B0")]
	public static CDFDIKBCLLO AADPCLLMHNJ(float LFDKOLFODOG)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F94B80", Offset = "0x6F93380", VA = "0x186F94B80")]
	public static CDFDIKBCLLO ACGLACJFOPD(byte FEEBOAEBMMK, byte MGLAKJDFHDE, byte FDHBIKHEEKA, byte CNFGPJHOHLH)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F94B80", Offset = "0x6F93380", VA = "0x186F94B80")]
	public static CDFDIKBCLLO AAPOANHHNCN(bool LGKAFKMNLDM, bool EECFLAOLECI, bool GPCJGKDCCBO, bool AFGKIKKDCKA)
	{
		return default(CDFDIKBCLLO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x57A8C10", Offset = "0x57A7410", VA = "0x1857A8C10")]
	public static bool FMMDKFLNNFA(CDFDIKBCLLO EOEOFNCKKHJ, CDFDIKBCLLO AOEAFBFCPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xB2EF10", Offset = "0xB2D710", VA = "0x180B2EF10", Slot = "4")]
	public bool Equals(CDFDIKBCLLO MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F94BA0", Offset = "0x6F933A0", VA = "0x186F94BA0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xD71550", Offset = "0xD6FD50", VA = "0x180D71550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F94C30", Offset = "0x6F93430", VA = "0x186F94C30", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x341E0D0", Offset = "0x341C8D0", VA = "0x18341E0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x341E660", Offset = "0x341CE60", VA = "0x18341E660")]
	public NBIGGEBJMFN(in T ECNGHFJBIJL, bool EFEABKGIBID)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x341D880", Offset = "0x341C080", VA = "0x18341D880")]
	public static bool FMMDKFLNNFA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9760", Offset = "0x7B8B60")] in global::NBIGGEBJMFN<T> FDMHBFLJJHC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B97D0", Offset = "0x7B8BD0")] in global::NBIGGEBJMFN<T> DNGDHCADJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x260A120", Offset = "0x2608920", VA = "0x18260A120", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9840", Offset = "0x7B8C40")] global::NBIGGEBJMFN<T> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x341CF00", Offset = "0x341B700", VA = "0x18341CF00", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x341E050", Offset = "0x341C850", VA = "0x18341E050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x341E2E0", Offset = "0x341CAE0", VA = "0x18341E2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LAKLAGNBOJK
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x28F47C0", Offset = "0x28F2FC0", VA = "0x1828F47C0")]
	public static global::NBIGGEBJMFN<T> AFDJJHJKIGO<T>(in T ECNGHFJBIJL) where T : notnull
	{
		return default(global::NBIGGEBJMFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x28F48E0", Offset = "0x28F30E0", VA = "0x1828F48E0")]
	public static global::NBIGGEBJMFN<T?> FNKNEKGCHCP<T>()
	{
		return default(global::NBIGGEBJMFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x28F49E0", Offset = "0x28F31E0", VA = "0x1828F49E0")]
	public static bool JNNFHGBEAEE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B98E0", Offset = "0x7B8CE0")] this in global::NBIGGEBJMFN<T> PJNCIFGMLCL, [NEFDIDCKCBL(true)] out T ECNGHFJBIJL) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6F965D0", Offset = "0x6F94DD0", VA = "0x186F965D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9E1370", Offset = "0x9DFB70", VA = "0x1809E1370")]
	public GILFKHMIONP(EGOPNIBJDMK HGGCLNACJBC, BJJEKJIBNBK HOOFGJFDPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	private static void EELNJPGADMA(string BPOKAAOBIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
	private static void BDAPFFLBHDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F966A0", Offset = "0x6F94EA0", VA = "0x186F966A0")]
	private static GILFKHMIONP OFDHHOGOACB()
	{
		return default(GILFKHMIONP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KFBMKMFINLC
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3935790", Offset = "0x3933F90", VA = "0x183935790")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CA7330", Offset = "0x1CA5B30", VA = "0x181CA7330")]
	public IGKCFAAAOEO(in T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6D50", Offset = "0x1CA5550", VA = "0x181CA6D50", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6EE0", Offset = "0x1CA56E0", VA = "0x181CA6EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1CA7140", Offset = "0x1CA5940", VA = "0x181CA7140", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F95E50", Offset = "0x6F94650", VA = "0x186F95E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F96140", Offset = "0x6F94940", VA = "0x186F96140")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F960E0", Offset = "0x6F948E0", VA = "0x186F960E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F95EB0", Offset = "0x6F946B0", VA = "0x186F95EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F961A0", Offset = "0x6F949A0", VA = "0x186F961A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F95D40", Offset = "0x6F94540", VA = "0x186F95D40")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F96210", Offset = "0x6F94A10", VA = "0x186F96210")]
	public static double OOOJNPDKKHB(long LJEMDOOBDKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F96030", Offset = "0x6F94830", VA = "0x186F96030")]
	public static double KAAKPHCEBJC(long LJEMDOOBDKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F95F80", Offset = "0x6F94780", VA = "0x186F95F80")]
	public static double IECNLGKKJLH(double FEEJMBIENJJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F95DA0", Offset = "0x6F945A0", VA = "0x186F95DA0")]
	public static long DHFEEMDJAKD(long JJEEOOEDFIC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F96200", Offset = "0x6F94A00", VA = "0x186F96200")]
	public static long NGPOCKMDBHI(long FCDCOMAOJAN, long OBFPOLGFFMO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F95C40", Offset = "0x6F94440", VA = "0x186F95C40")]
	public static double AHFHIJOPNHD(long FCDCOMAOJAN, long OBFPOLGFFMO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F95F10", Offset = "0x6F94710", VA = "0x186F95F10")]
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
