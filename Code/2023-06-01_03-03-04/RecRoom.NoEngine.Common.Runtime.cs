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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F5B030", Offset = "0x6F59C30", VA = "0x186F5B030")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83E010", Offset = "0x83CC10", VA = "0x18083E010")]
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
		[Cpp2IlInjected.Address(RVA = "0xBF6D90", Offset = "0xBF5990", VA = "0x180BF6D90")]
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
	[Cpp2IlInjected.Address(RVA = "0xBF6D90", Offset = "0xBF5990", VA = "0x180BF6D90")]
	public NEFDIDCKCBL(bool IEMHIOOBJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class KDNNMIKGJNK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xBF6D90", Offset = "0xBF5990", VA = "0x180BF6D90")]
	public KDNNMIKGJNK(bool IEMHIOOBJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class AEIDOAEHPPH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F56990", Offset = "0x6F55590", VA = "0x186F56990")]
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
	[Cpp2IlInjected.Address(RVA = "0x83E010", Offset = "0x83CC10", VA = "0x18083E010")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BCCLJANHCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F56BC0", Offset = "0x6F557C0", VA = "0x186F56BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F594B0", Offset = "0x6F580B0", VA = "0x186F594B0")]
	public static Task<TaskStatus> OEOELENCOHL(this Task GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x291AF60", Offset = "0x2919B60", VA = "0x18291AF60")]
	public static Task<T> AMNHNGMHMJC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F59280", Offset = "0x6F57E80", VA = "0x186F59280")]
	public static Task MADHFCMCIFL(this Task GAKDIIFBLNI, CancellationToken FLDJLPKNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x291BB60", Offset = "0x291A760", VA = "0x18291BB60")]
	public static Task<TResult> MADHFCMCIFL<TResult>(this Task<TResult> GAKDIIFBLNI, CancellationToken FLDJLPKNKKO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F59130", Offset = "0x6F57D30", VA = "0x186F59130")]
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
	[Cpp2IlInjected.Address(RVA = "0xB1CC20", Offset = "0xB1B820", VA = "0x180B1CC20")]
	public AHIOEJCKGHM(string ECNGHFJBIJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8638C0", Offset = "0x8624C0", VA = "0x1808638C0")]
	public static string DGIADCHILCD(in AHIOEJCKGHM GPOCLJBKMHA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x14241C0", Offset = "0x1422DC0", VA = "0x1814241C0")]
	public static AHIOEJCKGHM DGIADCHILCD(string MDHJAFNLPON)
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F56B70", Offset = "0x6F55770", VA = "0x186F56B70")]
	public string LNDGPDJIGJO(string IJAKCFMLLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F56A70", Offset = "0x6F55670", VA = "0x186F56A70")]
	public string HLEKLDDJDEP(object EMENJDCGEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8638C0", Offset = "0x8624C0", VA = "0x1808638C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FDBENDDJJIN<T> : IEquatable<FDBENDDJJIN<T>>, KELNLDHHLCN<FDBENDDJJIN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T MHGNIJCIFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int OJOINFOLDPA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D63F70", Offset = "0x1D62B70", VA = "0x181D63F70")]
	public FDBENDDJJIN(in T ECNGHFJBIJL, int NHHNPPKPBIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1D625B0", Offset = "0x1D611B0", VA = "0x181D625B0")]
	public static bool FMMDKFLNNFA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8960", Offset = "0x7A7D60")] in FDBENDDJJIN<T> FDMHBFLJJHC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A89D0", Offset = "0x7A7DD0")] in FDBENDDJJIN<T> DNGDHCADJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1D62520", Offset = "0x1D61120", VA = "0x181D62520", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8A40", Offset = "0x7A7E40")] FDBENDDJJIN<T> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1D62490", Offset = "0x1D61090", VA = "0x181D62490", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1D62EF0", Offset = "0x1D61AF0", VA = "0x181D62EF0")]
	public bool OECIFILCLOC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8AA0", Offset = "0x7A7EA0")] in FDBENDDJJIN<T> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1D62CE0", Offset = "0x1D618E0", VA = "0x181D62CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1D63B20", Offset = "0x1D62720", VA = "0x181D63B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1D63140", Offset = "0x1D61D40", VA = "0x181D63140")]
	public void PLOLBHIBFDI(out T ECNGHFJBIJL, out int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1D63650", Offset = "0x1D62250", VA = "0x181D63650")]
	public (T, int) PNBGCPOCGEL()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1D623B0", Offset = "0x1D60FB0", VA = "0x181D623B0", Slot = "5")]
	private bool ELIODBLNKOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8B10", Offset = "0x7A7F10")] in FDBENDDJJIN<T> MDHJAFNLPON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LGPPBGNIAGA
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30843E0", Offset = "0x3082FE0", VA = "0x1830843E0")]
	public static FDBENDDJJIN<T> DOBPLOGGNLM<T>(in T ECNGHFJBIJL, int NHHNPPKPBIA) where T : notnull
	{
		return default(FDBENDDJJIN<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DPIJIKFEAOC : IEquatable<DPIJIKFEAOC>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D00", Offset = "0x7F4900", VA = "0x1807F5D00", Slot = "4")]
	public bool Equals(DPIJIKFEAOC MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F58420", Offset = "0x6F57020", VA = "0x186F58420", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F58470", Offset = "0x6F57070", VA = "0x186F58470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F58480", Offset = "0x6F57080", VA = "0x186F58480", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F59740", Offset = "0x6F58340", VA = "0x186F59740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F59D10", Offset = "0x6F58910", VA = "0x186F59D10")]
	public JMIOBPDNDFO(in KLJIFOKILDG OLGNMNNGODM, in GILFKHMIONP JBGDJLFDHDK, HAPFCOLIGEJ FMJEEJBJOHK, HMGNJKGPCOJ GEPMKKEGFLL, MFBGNCDOMAP JCJMOLOIMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F59880", Offset = "0x6F58480", VA = "0x186F59880")]
	private static string MAPHHEDCIOC(object HHNPCHNMLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83D520", Offset = "0x83C120", VA = "0x18083D520")]
	private static long INKDBOKADIM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x9C6D70", Offset = "0x9C5970", VA = "0x1809C6D70")]
	private static string HABHBMADGID(string EIJFOGFJFOP, string? ECGMNPFIIPH, bool KCAOEADDHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F598C0", Offset = "0x6F584C0", VA = "0x186F598C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F5B0C0", Offset = "0x6F59CC0", VA = "0x186F5B0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F59F60", Offset = "0x6F58B60", VA = "0x186F59F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E347A0", Offset = "0x1E333A0", VA = "0x181E347A0")]
	public KLJIFOKILDG(AJGINBCHPFH PCPPAFFHIMF, EGKBOHKDEOJ EOFKAIMJEOP, AJGINBCHPFH JDGDALPKKKC, EGKBOHKDEOJ BKLPBDDACKK, AJGINBCHPFH HDBDCAODMJE, EGKBOHKDEOJ FHDKEOBFIOL, COCIDEIEIAK OCEGJANDHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0")]
	private static bool IGPPLCFKDAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	private static void NJKDOJHBPLC(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0")]
	private static bool DFBBKCHGCAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	private static void MIFLIEICBKG(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0")]
	private static bool MPNHHNJHDEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	private static void DJFGEIHHPEE(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	private static void PFEJBLEHEIF(Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A210", Offset = "0x6F58E10", VA = "0x186F5A210")]
	private static KLJIFOKILDG OFDHHOGOACB()
	{
		return default(KLJIFOKILDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D00", Offset = "0x7F4900", VA = "0x1807F5D00")]
	private static bool GPOPPAILJHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F59EF0", Offset = "0x6F58AF0", VA = "0x186F59EF0")]
	public void JGIMFEIAGIB(object DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A1A0", Offset = "0x6F58DA0", VA = "0x186F5A1A0")]
	public void NJNHBMLMKAJ(object DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F59ED0", Offset = "0x6F58AD0", VA = "0x186F59ED0")]
	public void FCDHDKBAJAE(Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x348B270", Offset = "0x3489E70", VA = "0x18348B270")]
	public void NJNHBMLMKAJ<T>(T AIMHDAMIMIL, OKHAEKBAKMG<T> DKIECHCHJFL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x348B170", Offset = "0x3489D70", VA = "0x18348B170")]
	public void JGIMFEIAGIB<T>(in T AIMHDAMIMIL, LNLPKOJBGAI<T> DKIECHCHJFL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F59E50", Offset = "0x6F58A50", VA = "0x186F59E50")]
	public bool CPDBGEABNJJ(bool PEAFIALKKOC, string DKIECHCHJFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EBBHJNPGDDO
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x236CFD0", Offset = "0x236BBD0", VA = "0x18236CFD0")]
	public static IEnumerable<T> POEDBAPJBNJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x9C6D70", Offset = "0x9C5970", VA = "0x1809C6D70")]
	public static T[] AGGJLKMNGMN<T>(params T[] BJKIJFHLHFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9C6D70", Offset = "0x9C5970", VA = "0x1809C6D70")]
	public static IEnumerable<T> BMIEOPJELID<T>(params T[] BJKIJFHLHFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E70190", Offset = "0x1E6ED90", VA = "0x181E70190")]
	public static HashSet<T> MGFHNOOIOIK<T>(params T[] BJKIJFHLHFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A53870", Offset = "0x2A52470", VA = "0x182A53870")]
	public static KeyValuePair<TKey, TValue> NNAJMFPNLEO<TKey, TValue>(in TKey BDFCACLHAFA, in TValue ECNGHFJBIJL) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1E70190", Offset = "0x1E6ED90", VA = "0x181E70190")]
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
	[Cpp2IlInjected.Address(RVA = "0x83E010", Offset = "0x83CC10", VA = "0x18083E010")]
	public JLDMLEBKGGC(string DNFOFIHCAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JIIBAAHNEOE
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2389760", Offset = "0x2388360", VA = "0x182389760")]
	public static AHIOEJCKGHM PBMPKCBABKL<T>()
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2389560", Offset = "0x2388160", VA = "0x182389560")]
	public static AHIOEJCKGHM ENEHJEOGOEH<T>([CallerMemberName] string BPOKAAOBIOI = "") where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23897F0", Offset = "0x23883F0", VA = "0x1823897F0")]
	public static AHIOEJCKGHM PBMPKCBABKL<T>(this T HDCPFIKNJDE) where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x23895F0", Offset = "0x23881F0", VA = "0x1823895F0")]
	public static AHIOEJCKGHM JFJBDKOGDMM<T>(this T HDCPFIKNJDE, [CallerMemberName] string BPOKAAOBIOI = "") where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23894C0", Offset = "0x23880C0", VA = "0x1823894C0")]
	public static AHIOEJCKGHM ENEHJEOGOEH<T>(this T GPOCLJBKMHA, [CallerMemberName] string BPOKAAOBIOI = "") where T : notnull
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F596C0", Offset = "0x6F582C0", VA = "0x186F596C0")]
	public static AHIOEJCKGHM ENEHJEOGOEH(string FBMEGMBPHGH, [CallerMemberName] string BPOKAAOBIOI = "")
	{
		return default(AHIOEJCKGHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F59600", Offset = "0x6F58200", VA = "0x186F59600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F5A850", Offset = "0x6F59450", VA = "0x186F5A850")]
		get
		{
			return default(JMIOBPDNDFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KLJIFOKILDG DLBLDGGLHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F5AE30", Offset = "0x6F59A30", VA = "0x186F5AE30")]
		get
		{
			return default(KLJIFOKILDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static GILFKHMIONP MIKHHILFLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F5AE90", Offset = "0x6F59A90", VA = "0x186F5AE90")]
		get
		{
			return default(GILFKHMIONP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F5AA10", Offset = "0x6F59610", VA = "0x186F5AA10")]
	public static void FGABHDDHFBC(in JMIOBPDNDFO AACCKMFILGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F5ACD0", Offset = "0x6F598D0", VA = "0x186F5ACD0")]
	public static void JGIMFEIAGIB(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F5AD80", Offset = "0x6F59980", VA = "0x186F5AD80")]
	public static void NJNHBMLMKAJ(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x236A950", Offset = "0x2369550", VA = "0x18236A950")]
	public static void NJNHBMLMKAJ<T>(T AIMHDAMIMIL, OKHAEKBAKMG<T> DKIECHCHJFL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A990", Offset = "0x6F59590", VA = "0x186F5A990")]
	public static void FCDHDKBAJAE(Exception BPFOEEABMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A7D0", Offset = "0x6F593D0", VA = "0x186F5A7D0")]
	public static string BJHJPLIGHDJ(object HHNPCHNMLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5AB70", Offset = "0x6F59770", VA = "0x186F5AB70")]
	public static long GJPABLEJFLO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A8B0", Offset = "0x6F594B0", VA = "0x186F5A8B0")]
	public static bool CPDBGEABNJJ(bool PEAFIALKKOC, string DKIECHCHJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5ABE0", Offset = "0x6F597E0", VA = "0x186F5ABE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F59DA0", Offset = "0x6F589A0", VA = "0x186F59DA0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public KKENKPCNBDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class JEPPACIIAKC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F56FA0", Offset = "0x6F55BA0", VA = "0x186F56FA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? HAIALGNNHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x842A50", Offset = "0x841650", VA = "0x180842A50", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F57380", Offset = "0x6F55F80", VA = "0x186F57380")]
	[Preserve]
	public CCFPGIGIOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F57160", Offset = "0x6F55D60", VA = "0x186F57160")]
	public CCFPGIGIOPG(TimeSpan OJHABJHLHAL, [Optional] Action? NFKHMLNANLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F56E50", Offset = "0x6F55A50", VA = "0x186F56E50", Slot = "7")]
	public void FJGIPGEKOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F56F30", Offset = "0x6F55B30", VA = "0x186F56F30", Slot = "8")]
	public void IGIMABCMDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F56F70", Offset = "0x6F55B70", VA = "0x186F56F70", Slot = "9")]
	public void KAJNNIEMKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1588C40", Offset = "0x1587840", VA = "0x181588C40")]
	private void CCMIIEIFJED(object HDCPFIKNJDE, ElapsedEventArgs DOMDKMDGPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F56EB0", Offset = "0x6F55AB0", VA = "0x186F56EB0")]
	private static void GPEAAMGGGEP(ref TimeSpan FMKOGHAFEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F56DB0", Offset = "0x6F559B0", VA = "0x186F56DB0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Class)]
public class JIAMBIICBFF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
	[Cpp2IlInjected.Address(RVA = "0xA45E70", Offset = "0xA44A70", VA = "0x180A45E70")]
	public static CDFDIKBCLLO BMNEMIDKOOD(uint MIDLFDJEFKI)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA45E70", Offset = "0xA44A70", VA = "0x180A45E70")]
	public static CDFDIKBCLLO PJEOJLHMHAJ(int GJDPNDOOJJE)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xF14460", Offset = "0xF13060", VA = "0x180F14460")]
	public static CDFDIKBCLLO AADPCLLMHNJ(float LFDKOLFODOG)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F573F0", Offset = "0x6F55FF0", VA = "0x186F573F0")]
	public static CDFDIKBCLLO ACGLACJFOPD(byte FEEBOAEBMMK, byte MGLAKJDFHDE, byte FDHBIKHEEKA, byte CNFGPJHOHLH)
	{
		return default(CDFDIKBCLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F573F0", Offset = "0x6F55FF0", VA = "0x186F573F0")]
	public static CDFDIKBCLLO AAPOANHHNCN(bool LGKAFKMNLDM, bool EECFLAOLECI, bool GPCJGKDCCBO, bool AFGKIKKDCKA)
	{
		return default(CDFDIKBCLLO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5478970", Offset = "0x5477570", VA = "0x185478970")]
	public static bool FMMDKFLNNFA(CDFDIKBCLLO EOEOFNCKKHJ, CDFDIKBCLLO AOEAFBFCPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xA442B0", Offset = "0xA42EB0", VA = "0x180A442B0", Slot = "4")]
	public bool Equals(CDFDIKBCLLO MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F57410", Offset = "0x6F56010", VA = "0x186F57410", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xBEE950", Offset = "0xBED550", VA = "0x180BEE950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F574A0", Offset = "0x6F560A0", VA = "0x186F574A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[KPFEFEMPEAJ("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct NBIGGEBJMFN<T> : IEquatable<NBIGGEBJMFN<T>> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x2F86B80", Offset = "0x2F85780", VA = "0x182F86B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2F870A0", Offset = "0x2F85CA0", VA = "0x182F870A0")]
	public NBIGGEBJMFN(in T ECNGHFJBIJL, bool EFEABKGIBID)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2F866F0", Offset = "0x2F852F0", VA = "0x182F866F0")]
	public static bool FMMDKFLNNFA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8E80", Offset = "0x7A8280")] in NBIGGEBJMFN<T> FDMHBFLJJHC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8EF0", Offset = "0x7A82F0")] in NBIGGEBJMFN<T> DNGDHCADJJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1D62400", Offset = "0x1D61000", VA = "0x181D62400", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8F60", Offset = "0x7A8360")] NBIGGEBJMFN<T> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2F85840", Offset = "0x2F84440", VA = "0x182F85840", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2F86A70", Offset = "0x2F85670", VA = "0x182F86A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2F86C00", Offset = "0x2F85800", VA = "0x182F86C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LAKLAGNBOJK
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x236D0B0", Offset = "0x236BCB0", VA = "0x18236D0B0")]
	public static NBIGGEBJMFN<T> AFDJJHJKIGO<T>(in T ECNGHFJBIJL) where T : notnull
	{
		return default(NBIGGEBJMFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x236D1F0", Offset = "0x236BDF0", VA = "0x18236D1F0")]
	public static NBIGGEBJMFN<T?> FNKNEKGCHCP<T>()
	{
		return default(NBIGGEBJMFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x236D260", Offset = "0x236BE60", VA = "0x18236D260")]
	public static bool JNNFHGBEAEE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A9000", Offset = "0x7A8400")] this in NBIGGEBJMFN<T> PJNCIFGMLCL, [NEFDIDCKCBL(true)] out T ECNGHFJBIJL) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6F58E40", Offset = "0x6F57A40", VA = "0x186F58E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
	public GILFKHMIONP(EGOPNIBJDMK HGGCLNACJBC, BJJEKJIBNBK HOOFGJFDPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	private static void EELNJPGADMA(string BPOKAAOBIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	private static void BDAPFFLBHDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F58F10", Offset = "0x6F57B10", VA = "0x186F58F10")]
	private static GILFKHMIONP OFDHHOGOACB()
	{
		return default(GILFKHMIONP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KFBMKMFINLC
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3473C60", Offset = "0x3472860", VA = "0x183473C60")]
	public static bool OECIFILCLOC<T, U>(in T GPOCLJBKMHA, in U HHNPCHNMLMA) where T : notnull, KELNLDHHLCN<T> where U : notnull
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
	[Cpp2IlInjected.Address(RVA = "0x1C79850", Offset = "0x1C78450", VA = "0x181C79850")]
	public IGKCFAAAOEO(in T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1C79270", Offset = "0x1C77E70", VA = "0x181C79270", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1C793C0", Offset = "0x1C77FC0", VA = "0x181C793C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1C795A0", Offset = "0x1C781A0", VA = "0x181C795A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F586C0", Offset = "0x6F572C0", VA = "0x186F586C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F589B0", Offset = "0x6F575B0", VA = "0x186F589B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F58950", Offset = "0x6F57550", VA = "0x186F58950")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F58720", Offset = "0x6F57320", VA = "0x186F58720")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F58A10", Offset = "0x6F57610", VA = "0x186F58A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F585B0", Offset = "0x6F571B0", VA = "0x186F585B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F58A80", Offset = "0x6F57680", VA = "0x186F58A80")]
	public static double OOOJNPDKKHB(long LJEMDOOBDKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F588A0", Offset = "0x6F574A0", VA = "0x186F588A0")]
	public static double KAAKPHCEBJC(long LJEMDOOBDKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F587F0", Offset = "0x6F573F0", VA = "0x186F587F0")]
	public static double IECNLGKKJLH(double FEEJMBIENJJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F58610", Offset = "0x6F57210", VA = "0x186F58610")]
	public static long DHFEEMDJAKD(long JJEEOOEDFIC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F58A70", Offset = "0x6F57670", VA = "0x186F58A70")]
	public static long NGPOCKMDBHI(long FCDCOMAOJAN, long OBFPOLGFFMO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F584B0", Offset = "0x6F570B0", VA = "0x186F584B0")]
	public static double AHFHIJOPNHD(long FCDCOMAOJAN, long OBFPOLGFFMO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F58780", Offset = "0x6F57380", VA = "0x186F58780")]
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
