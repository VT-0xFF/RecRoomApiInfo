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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x71864D0", Offset = "0x7184AD0", VA = "0x1871864D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class NODIKJAOIGH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
	public NODIKJAOIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class CHGAFDMGLNB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
	public CHGAFDMGLNB(bool KLGJFJJLHJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class FDFMICFDLIC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
	public FDFMICFDLIC(bool KLGJFJJLHJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class DAKGFHDLJFO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
	public DAKGFHDLJFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class JKLNIBFJALJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x71859A0", Offset = "0x7183FA0", VA = "0x1871859A0")]
	public JKLNIBFJALJ(bool KLGJFJJLHJJ, string JAFJGFPEHMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.All)]
public class GFNBIBHBBNO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string DHJNLBPEBJE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
	public GFNBIBHBBNO(string DEBBCDLKFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JGICOCIGMBO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ICPOMMLEEMG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public ICPOMMLEEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1ACE910", Offset = "0x1ACCF10", VA = "0x181ACE910")]
		internal void LFJALOIKCJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KLDLJNBGDND<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public KLDLJNBGDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x261F130", Offset = "0x261D730", VA = "0x18261F130")]
		internal void KDOPMHFJNIN(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class LAPLMGOJFOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LAPLMGOJFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7186220", Offset = "0x7184820", VA = "0x187186220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7185850", Offset = "0x7183E50", VA = "0x187185850")]
	public static Task<TaskStatus> PJCKBFKOOFI(this Task PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x19F4600", Offset = "0x19F2C00", VA = "0x1819F4600")]
	public static Task<T> GKACBLKKCOB<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7185620", Offset = "0x7183C20", VA = "0x187185620")]
	public static Task KCELLPIFBAP(this Task DNEHMOFNGIO, CancellationToken LODBJLOKBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x19F5CA0", Offset = "0x19F42A0", VA = "0x1819F5CA0")]
	public static Task<TResult> KCELLPIFBAP<TResult>(this Task<TResult> DNEHMOFNGIO, CancellationToken LODBJLOKBLP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x19F6640", Offset = "0x19F4C40", VA = "0x1819F6640")]
	public static TaskCompletionSource<TResult> KCELLPIFBAP<TResult>(this TaskCompletionSource<TResult> MBJNFNPEPOE, CancellationToken LODBJLOKBLP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x71854D0", Offset = "0x7183AD0", VA = "0x1871854D0")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LAPLMGOJFOO))]
	internal static Task<TaskStatus> GBABBAEJLAP(Task DEDDJIPCAMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CBJNDDADOGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan NNFAJKCJDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? PGOALKIDMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFPPCFCIDEC();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJIFICDIGJJ();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HLFKIMJFMKM();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct PLIAICDACKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string CNODGJBIHLH;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
	public PLIAICDACKL(string FEBHELIDNED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
	public static string BJIOOOHFEFG(in PLIAICDACKL PBJDHAKDMFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xB18D60", Offset = "0xB17360", VA = "0x180B18D60")]
	public static PLIAICDACKL BJIOOOHFEFG(string EJECOGCICOM)
	{
		return default(PLIAICDACKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7187F20", Offset = "0x7186520", VA = "0x187187F20")]
	public string DIPKNPGDJJG(string ANMADMEGBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7187F70", Offset = "0x7186570", VA = "0x187187F70")]
	public string OGHBGNKBHBB(object NFEONNKMGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct BBCKCHJBLNA<T> : IEquatable<BBCKCHJBLNA<T>>, IKGEBLJKMLJ<BBCKCHJBLNA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T CNODGJBIHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int IKGMLJIBDML;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x15C46D0", Offset = "0x15C2CD0", VA = "0x1815C46D0")]
	public BBCKCHJBLNA(in T FEBHELIDNED, int IIOMOLKAONM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D487F0", Offset = "0x4D46DF0", VA = "0x184D487F0")]
	public static bool MOJFGPLDDKP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742A80", Offset = "0x741E80")] in BBCKCHJBLNA<T> CNCLMHODMJG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742AF0", Offset = "0x741EF0")] in BBCKCHJBLNA<T> ECNLMNDOGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x372DAA0", Offset = "0x372C0A0", VA = "0x18372DAA0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742B60", Offset = "0x741F60")] BBCKCHJBLNA<T> EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D47730", Offset = "0x4D45D30", VA = "0x184D47730", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D477B0", Offset = "0x4D45DB0", VA = "0x184D477B0")]
	public bool FNAMDMFDIAO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742BC0", Offset = "0x741FC0")] in BBCKCHJBLNA<T> EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D47B50", Offset = "0x4D46150", VA = "0x184D47B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4D48D00", Offset = "0x4D47300", VA = "0x184D48D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D481F0", Offset = "0x4D467F0", VA = "0x184D481F0")]
	public void LJFEBDDDADJ(out T FEBHELIDNED, out int IIOMOLKAONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4D47CA0", Offset = "0x4D462A0", VA = "0x184D47CA0")]
	public (T, int) LGPKDEMLBEH()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D476E0", Offset = "0x4D45CE0", VA = "0x184D476E0", Slot = "5")]
	private bool BOHGIGNMGLD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742C30", Offset = "0x742030")] in BBCKCHJBLNA<T> EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AGMDOFBAAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1022670", Offset = "0x1020C70", VA = "0x181022670")]
	public static BBCKCHJBLNA<T> JBGFDEKBNPE<T>(in T FEBHELIDNED, int IIOMOLKAONM) where T : notnull
	{
		return default(BBCKCHJBLNA<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct DABEAPPDAMA : IEquatable<DABEAPPDAMA>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "4")]
	public bool Equals(DABEAPPDAMA EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x71842B0", Offset = "0x71828B0", VA = "0x1871842B0", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7184300", Offset = "0x7182900", VA = "0x187184300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7184310", Offset = "0x7182910", VA = "0x187184310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct KKAOFFEGHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly OEAEMAHGIAO IKLEGHOHNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly GLKACJINLDI HPNKOCPHPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly KHHFDOKJIFB AGNPOCPJKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly PBJBFOFOFBL EADHBHDHKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IFEJCHELIPD EBKJGEACALJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly KHHFDOKJIFB JBLLMLCAOEL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly PBJBFOFOFBL IFBBMKMCOKL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly IFEJCHELIPD LDEOFELHCJE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly KKAOFFEGHAF JKPLIBNKDEM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DDCPNIBOGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7185A80", Offset = "0x7184080", VA = "0x187185A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7186050", Offset = "0x7184650", VA = "0x187186050")]
	public KKAOFFEGHAF(in OEAEMAHGIAO FMLFBDOHOHB, in GLKACJINLDI IFNPFBDCDBF, KHHFDOKJIFB IMJJLOHIJJM, PBJBFOFOFBL OHLCBPACJKP, IFEJCHELIPD INOLAEEIICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7185CE0", Offset = "0x71842E0", VA = "0x187185CE0")]
	private static string OHJLDBKGKHB(object IAMEECMGPIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0")]
	private static long OBIIOILODPN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
	private static string AFABEDOMDFP(string CCOKELEMEOM, string? MNMCPADHKHA, bool LFDIGBOECDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7185BC0", Offset = "0x71841C0", VA = "0x187185BC0")]
	private static KKAOFFEGHAF KHKBEGPKPDC()
	{
		return default(KKAOFFEGHAF);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CLGOMJKNPEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ulong AKNDCCCBDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public long IACOEBPDIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public double JEEPCKIBIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public uint MFAODNNPOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public uint AKJHPDMMAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int KNHEPPAAEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int MMOFHCMKNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float MJNAMCKDCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float ANINHLPNLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ushort CPBMCBNKKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public ushort DMAKCCEHJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public ushort NPAPECCNIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public ushort GOCNCBJDAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public short MBBKKAFNFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public short MHFHMGNLBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public short MPPLAOCGLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public short BCNFEJOBPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public char FMOGKPEMBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public char FOJBNNNFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public char ANNFMBHKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public char ILKOOPBLAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte LMLAKIAFKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte CNEKEPDLBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public byte EHKOMOPJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte HDPNCFKFEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public byte JPMIGJOCMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte BOCJKJJKGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public byte DJOEKEPBHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public byte INNJBDGILCF;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7184250", Offset = "0x7182850", VA = "0x187184250")]
	public static CLGOMJKNPEL JBGFDEKBNPE(byte FKEHAGKFMHC, byte CEEDGLFEAPL, byte LDDANGMBEGC, byte GAILFPJALGO, byte CFEKFHCLAGK, byte ELINPJCMFOM, byte ADJKKMNCOIP, byte CMFHAABENJM)
	{
		return default(CLGOMJKNPEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct OEAEMAHGIAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly JFBGIFFIGEE GOHFHBANLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly GBPPAAPGDOJ GAGNNKJJKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly JFBGIFFIGEE MMDDNNBHKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly GBPPAAPGDOJ DEICOIKKMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly JFBGIFFIGEE OFCHAICOPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly GBPPAAPGDOJ EHFKJAMIEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly HAOABCKLACI FBGOLLFBFKK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JFBGIFFIGEE OFDKDKEMBBP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly GBPPAAPGDOJ PPMEIEHMKMD;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JFBGIFFIGEE LBHLDNDGBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly GBPPAAPGDOJ HEJLJLCLLBI;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly JFBGIFFIGEE JGDKICKFGOB;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GBPPAAPGDOJ ILPLMOFOELK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly HAOABCKLACI PKIJEIMBCMP;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly OEAEMAHGIAO JKPLIBNKDEM;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly JFBGIFFIGEE CJFJCBEOHGD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DDCPNIBOGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71865D0", Offset = "0x7184BD0", VA = "0x1871865D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x951490", Offset = "0x94FA90", VA = "0x180951490")]
	public OEAEMAHGIAO(JFBGIFFIGEE PGMAGCNDMAK, GBPPAAPGDOJ AHMLKKPOKOP, JFBGIFFIGEE AGCGBJMGHLM, GBPPAAPGDOJ PGAMODCIACE, JFBGIFFIGEE OPHHGMIDNLD, GBPPAAPGDOJ JCMEKIHIDJO, HAOABCKLACI KFHOIEGOICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250")]
	private static bool CEJLFDFDLMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	private static void IJONLJDFNAF(string JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250")]
	private static bool LLNGGHCACCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	private static void FOLFNMDNJFF(string JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250")]
	private static bool HIAJGBACNIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	private static void DNADIEMEADE(string JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	private static void EMJEJOPKMBB(Exception IOPPNPIHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7186890", Offset = "0x7184E90", VA = "0x187186890")]
	private static OEAEMAHGIAO KHKBEGPKPDC()
	{
		return default(OEAEMAHGIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0")]
	private static bool DLJFBFMODPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7186560", Offset = "0x7184B60", VA = "0x187186560")]
	public void BKMKBHBEAIO(object JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x71869D0", Offset = "0x7184FD0", VA = "0x1871869D0")]
	public void KLCOOAGHEOI(object JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7186A40", Offset = "0x7185040", VA = "0x187186A40")]
	public void KNGKPMNNBEF(Exception IOPPNPIHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3A87230", Offset = "0x3A85830", VA = "0x183A87230")]
	public void KLCOOAGHEOI<T>(T NPIEBOHJFEN, GEBGFDMJIAN<T> JIEHBANCLJP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3A87130", Offset = "0x3A85730", VA = "0x183A87130")]
	public void BKMKBHBEAIO<T>(in T NPIEBOHJFEN, PFDHEFGGCEH<T> JIEHBANCLJP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7186810", Offset = "0x7184E10", VA = "0x187186810")]
	public bool JDFGOAFJBGL(bool JDNFFFIDLDI, string JIEHBANCLJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class JPKKNIOCEJC
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x15F9820", Offset = "0x15F7E20", VA = "0x1815F9820")]
	public static IEnumerable<T> NIOIPDCJIEG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
	public static T[] HACKKDDOFMH<T>(params T[] NOKKEFMFGAC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
	public static IEnumerable<T> GIDCMAFKMOI<T>(params T[] NOKKEFMFGAC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x15F9BA0", Offset = "0x15F81A0", VA = "0x1815F9BA0")]
	public static HashSet<T> ADBPINIOEGG<T>(params T[] NOKKEFMFGAC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x15F9C00", Offset = "0x15F8200", VA = "0x1815F9C00")]
	public static KeyValuePair<TKey, TValue> OEMIGJIGNNJ<TKey, TValue>(in TKey NAJDAPHOGEH, in TValue FEBHELIDNED) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x15F9BA0", Offset = "0x15F81A0", VA = "0x1815F9BA0")]
	public static List<T> KCKLMDOLBLJ<T>(IEnumerable<T> NEGBPLHGJID) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[AttributeUsage(AttributeTargets.All)]
public sealed class CFKMPDHPJNN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string AJKMADONBJC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
	public CFKMPDHPJNN(string FEBMHINNMEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KPHCPLBBILF
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x388A990", Offset = "0x3888F90", VA = "0x18388A990")]
	public static PLIAICDACKL AMOEIAPFOIG<T>()
	{
		return default(PLIAICDACKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2301970", Offset = "0x22FFF70", VA = "0x182301970")]
	public static PLIAICDACKL DBFJOOAAFIN<T>([CallerMemberName] string HNPIEGONNBC = "") where T : notnull
	{
		return default(PLIAICDACKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2301710", Offset = "0x22FFD10", VA = "0x182301710")]
	public static PLIAICDACKL AMOEIAPFOIG<T>(this T HHOBHGKDNLP) where T : notnull
	{
		return default(PLIAICDACKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2301A00", Offset = "0x2300000", VA = "0x182301A00")]
	public static PLIAICDACKL DONMPKCDFJO<T>(this T HHOBHGKDNLP, [CallerMemberName] string HNPIEGONNBC = "") where T : notnull
	{
		return default(PLIAICDACKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x23018D0", Offset = "0x22FFED0", VA = "0x1823018D0")]
	public static PLIAICDACKL DBFJOOAAFIN<T>(this T PBJDHAKDMFG, [CallerMemberName] string HNPIEGONNBC = "") where T : notnull
	{
		return default(PLIAICDACKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x71860E0", Offset = "0x71846E0", VA = "0x1871860E0")]
	public static PLIAICDACKL DBFJOOAAFIN(string BCFOFMNBDOL, [CallerMemberName] string HNPIEGONNBC = "")
	{
		return default(PLIAICDACKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7186160", Offset = "0x7184760", VA = "0x187186160")]
	public static string DHCMKIDDJKF(this object PBJDHAKDMFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[LLCGFMFCOAC]
public delegate long PBJBFOFOFBL();
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate void ACACEJNOFNM<T>(in T NPIEBOHJFEN);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class IPIPPNBMPFM
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static KKAOFFEGHAF JBPPFNGILEJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static KKAOFFEGHAF PJMLJGBFHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7184F00", Offset = "0x7183500", VA = "0x187184F00")]
		get
		{
			return default(KKAOFFEGHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static OEAEMAHGIAO IKLEGHOHNMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7184D00", Offset = "0x7183300", VA = "0x187184D00")]
		get
		{
			return default(OEAEMAHGIAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static GLKACJINLDI HPNKOCPHPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7185260", Offset = "0x7183860", VA = "0x187185260")]
		get
		{
			return default(GLKACJINLDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71852C0", Offset = "0x71838C0", VA = "0x1871852C0")]
	public static void MJLBMNOLALG(in KKAOFFEGHAF ENLOOHOMIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7184E50", Offset = "0x7183450", VA = "0x187184E50")]
	public static void BKMKBHBEAIO(string JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7185130", Offset = "0x7183730", VA = "0x187185130")]
	public static void KLCOOAGHEOI(string JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2169FA0", Offset = "0x21685A0", VA = "0x182169FA0")]
	public static void KLCOOAGHEOI<T>(T NPIEBOHJFEN, GEBGFDMJIAN<T> JIEHBANCLJP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71851E0", Offset = "0x71837E0", VA = "0x1871851E0")]
	public static void KNGKPMNNBEF(Exception IOPPNPIHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7184F60", Offset = "0x7183560", VA = "0x187184F60")]
	public static string DHCMKIDDJKF(object IAMEECMGPIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7184FE0", Offset = "0x71835E0", VA = "0x187184FE0")]
	public static long IMMPDFCFDLP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7185050", Offset = "0x7183650", VA = "0x187185050")]
	public static bool JDFGOAFJBGL(bool JDNFFFIDLDI, string JIEHBANCLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7184D60", Offset = "0x7183360", VA = "0x187184D60")]
	public static double BAIIKALJKCD()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MKCNIIHIBAM : ILNOIBLCLBA
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly ILNOIBLCLBA FBBAELKBDJK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime EGIFJMIKAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7186420", Offset = "0x7184A20", VA = "0x187186420", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public MKCNIIHIBAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class LLCGFMFCOAC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
	public LLCGFMFCOAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate TResult GNHHEMIOHNJ<T, out TResult>(in T NPIEBOHJFEN);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate TResult GFHGBDHHALP<T1, T2, out TResult>(in T1 PDMGNBEKIPJ, in T2 KLDANEBHLJO);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class INAPONAEGDI : CBJNDDADOGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly TimeSpan MLDDPAGOGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly System.Timers.Timer BCLLAMGBKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private TimeSpan FPFPGODCNAC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan NNFAJKCJDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x71846C0", Offset = "0x7182CC0", VA = "0x1871846C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? PGOALKIDMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7184A70", Offset = "0x7183070", VA = "0x187184A70")]
	[Preserve]
	public INAPONAEGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7184AE0", Offset = "0x71830E0", VA = "0x187184AE0")]
	public INAPONAEGDI(TimeSpan FPFPGODCNAC, [Optional] Action? GIDLGCPDDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7184970", Offset = "0x7182F70", VA = "0x187184970", Slot = "7")]
	public void GFPPCFCIDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x71848B0", Offset = "0x7182EB0", VA = "0x1871848B0", Slot = "8")]
	public void EJIFICDIGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x71849D0", Offset = "0x7182FD0", VA = "0x1871849D0", Slot = "9")]
	public void HLFKIMJFMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x94CC50", Offset = "0x94B250", VA = "0x18094CC50")]
	private void CMFNAADGMIE(object HHOBHGKDNLP, ElapsedEventArgs PBMHOFLDKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x71848F0", Offset = "0x7182EF0", VA = "0x1871848F0")]
	private static void GEBHJIJMMGL(ref TimeSpan KDNPLEEACMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7184810", Offset = "0x7182E10", VA = "0x187184810", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[AttributeUsage(AttributeTargets.Class)]
public class GGHJLFJGPPO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
	public GGHJLFJGPPO()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class PFAOENEDMII : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
	public PFAOENEDMII(string FFLLLKMMEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface ILNOIBLCLBA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime EGIFJMIKAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OKPFBOMPGAF : IEquatable<OKPFBOMPGAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint IDEFCHCBCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int EMPDMKCJFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float BBPKKELOBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort CPBMCBNKKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort DMAKCCEHJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short MBBKKAFNFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short MHFHMGNLBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char FMOGKPEMBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char FOJBNNNFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte LMLAKIAFKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte CNEKEPDLBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte EHKOMOPJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte HDPNCFKFEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool NGAGJEHNDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool IMMCAKKILFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool BMDNMJHIKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool OJOBFJGBBFJ;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1E7C230", Offset = "0x1E7A830", VA = "0x181E7C230")]
	public static OKPFBOMPGAF JMJNCKCEIOO(uint NIHLKALNKFP)
	{
		return default(OKPFBOMPGAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1E7C230", Offset = "0x1E7A830", VA = "0x181E7C230")]
	public static OKPFBOMPGAF PCMJCGHDFFE(int HKPLNGMNKFO)
	{
		return default(OKPFBOMPGAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7186F90", Offset = "0x7185590", VA = "0x187186F90")]
	public static OKPFBOMPGAF PELPOGDDPAK(float IKGHFKGDHMP)
	{
		return default(OKPFBOMPGAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7186EE0", Offset = "0x71854E0", VA = "0x187186EE0")]
	public static OKPFBOMPGAF MMDKEFJDDFF(byte FKEHAGKFMHC, byte CEEDGLFEAPL, byte LDDANGMBEGC, byte GAILFPJALGO)
	{
		return default(OKPFBOMPGAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7186EE0", Offset = "0x71854E0", VA = "0x187186EE0")]
	public static OKPFBOMPGAF AHNAMPJLFAM(bool APABMKMPGFH, bool ENONJDBNONL, bool KHJBILEPLOB, bool CCKEICIGIMA)
	{
		return default(OKPFBOMPGAF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x519C370", Offset = "0x519A970", VA = "0x18519C370")]
	public static bool MOJFGPLDDKP(OKPFBOMPGAF NNCBKOEDDGO, OKPFBOMPGAF IHJFFGMGNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3EEE550", Offset = "0x3EECB50", VA = "0x183EEE550", Slot = "4")]
	public bool Equals(OKPFBOMPGAF EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7186F00", Offset = "0x7185500", VA = "0x187186F00", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x19D9E40", Offset = "0x19D8440", VA = "0x1819D9E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7186FA0", Offset = "0x71855A0", VA = "0x187186FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[GFNBIBHBBNO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct JJBGMPOBLPN<T> : IEquatable<JJBGMPOBLPN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly T CNODGJBIHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool CHHLCIKPJIN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool PPJEBOIKDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x372DA70", Offset = "0x372C070", VA = "0x18372DA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x372F380", Offset = "0x372D980", VA = "0x18372F380")]
	public JJBGMPOBLPN(in T FEBHELIDNED, bool OGOLEFHFMHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x372ECC0", Offset = "0x372D2C0", VA = "0x18372ECC0")]
	public static bool MOJFGPLDDKP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x742FA0", Offset = "0x7423A0")] in JJBGMPOBLPN<T> CNCLMHODMJG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743010", Offset = "0x742410")] in JJBGMPOBLPN<T> ECNLMNDOGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x372E120", Offset = "0x372C720", VA = "0x18372E120", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743080", Offset = "0x742480")] JJBGMPOBLPN<T> EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x372E490", Offset = "0x372CA90", VA = "0x18372E490", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x372E610", Offset = "0x372CC10", VA = "0x18372E610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x372F220", Offset = "0x372D820", VA = "0x18372F220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class BFFNPOCHNGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EEC0", Offset = "0x1D0D4C0", VA = "0x181D0EEC0")]
	public static JJBGMPOBLPN<T> ANAEOCGMAPE<T>(in T FEBHELIDNED) where T : notnull
	{
		return default(JJBGMPOBLPN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F030", Offset = "0x1D0D630", VA = "0x181D0F030")]
	public static JJBGMPOBLPN<T?> JMJKENHHKIP<T>()
	{
		return default(JJBGMPOBLPN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EFC0", Offset = "0x1D0D5C0", VA = "0x181D0EFC0")]
	public static bool HLLMEGBAANL<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x743120", Offset = "0x742520")] this in JJBGMPOBLPN<T> BEOJMGINHGE, [CHGAFDMGLNB(true)] out T FEBHELIDNED) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IKGEBLJKMLJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNAMDMFDIAO(in T EJECOGCICOM);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct GLKACJINLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly ACGEPEANAJD NPLCOAKLNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly EHCCCEKPHCG GPBKKKLDEHD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly ACGEPEANAJD CKFIMOIBEPL;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly EHCCCEKPHCG DCIBCLHLEPB;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly GLKACJINLDI JKPLIBNKDEM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DDCPNIBOGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7184340", Offset = "0x7182940", VA = "0x187184340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xBBF9D0", Offset = "0xBBDFD0", VA = "0x180BBF9D0")]
	public GLKACJINLDI(ACGEPEANAJD DBAMLDNAHPP, EHCCCEKPHCG ELPABELLDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	private static void ALJOFBCEJNH(string HNPIEGONNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	private static void LJNODHPFJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7184410", Offset = "0x7182A10", VA = "0x187184410")]
	private static GLKACJINLDI KHKBEGPKPDC()
	{
		return default(GLKACJINLDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class DEPCKLKEDOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2999CA0", Offset = "0x29982A0", VA = "0x182999CA0")]
	public static bool FNAMDMFDIAO<T, U>(in T PBJDHAKDMFG, in U IAMEECMGPIF) where T : notnull, IKGEBLJKMLJ<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class GHMDGBDOHIH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly EqualityComparer<T> GGLCAGMHFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public T CNODGJBIHLH;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2579F00", Offset = "0x2578500", VA = "0x182579F00")]
	public GHMDGBDOHIH(in T FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2650", Offset = "0x2DC0C50", VA = "0x182DC2650", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2DC29A0", Offset = "0x2DC0FA0", VA = "0x182DC29A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2B20", Offset = "0x2DC1120", VA = "0x182DC2B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class AGJJCNNMIKK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long BENOJOCIPHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7183E30", Offset = "0x7182430", VA = "0x187183E30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long GJPHMBDPDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7183C70", Offset = "0x7182270", VA = "0x187183C70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double KHHDAILDBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x71839D0", Offset = "0x7181FD0", VA = "0x1871839D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double JNIFMCGPCHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7183970", Offset = "0x7181F70", VA = "0x187183970")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double JCBOPMKDLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7183AA0", Offset = "0x71820A0", VA = "0x187183AA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double ANBJJMEAMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7183DD0", Offset = "0x71823D0", VA = "0x187183DD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7183E90", Offset = "0x7182490", VA = "0x187183E90")]
	public static double MJNIKOLDDAF(long KONFIBKPOOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7183B00", Offset = "0x7182100", VA = "0x187183B00")]
	public static double FPOBMFOIFJF(long KONFIBKPOOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x71838C0", Offset = "0x7181EC0", VA = "0x1871838C0")]
	public static double AHGGLHIIHGJ(double PNJGBDBCJID)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7183BC0", Offset = "0x71821C0", VA = "0x187183BC0")]
	public static long IHDNGLPBKCG(long HCHPBOOIDPB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7183BB0", Offset = "0x71821B0", VA = "0x187183BB0")]
	public static long HGCDEJNHJMM(long CJIILCFAGJD, long NLALKCMAHPA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7183CD0", Offset = "0x71822D0", VA = "0x187183CD0")]
	public static double JFODOEHCPCE(long CJIILCFAGJD, long NLALKCMAHPA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7183A30", Offset = "0x7182030", VA = "0x187183A30")]
	public static double ENNJNAOLKMA(long CJIILCFAGJD, long NLALKCMAHPA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[LLCGFMFCOAC]
public delegate void GBPPAAPGDOJ(string JIEHBANCLJP);
[Cpp2IlInjected.Token(Token = "0x2000031")]
[LLCGFMFCOAC]
public delegate string KHHFDOKJIFB(object IAMEECMGPIF);
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LLCGFMFCOAC]
public delegate void EHCCCEKPHCG();
[Cpp2IlInjected.Token(Token = "0x2000033")]
public delegate object PFDHEFGGCEH<T>(in T GDDHAFPALIL);
[Cpp2IlInjected.Token(Token = "0x2000034")]
public delegate object LGNDNLAFIPB();
[Cpp2IlInjected.Token(Token = "0x2000035")]
[LLCGFMFCOAC]
public delegate string IFEJCHELIPD(string CCOKELEMEOM, string? MNMCPADHKHA, bool LFDIGBOECDD);
[Cpp2IlInjected.Token(Token = "0x2000036")]
[LLCGFMFCOAC]
public delegate bool JFBGIFFIGEE();
[Cpp2IlInjected.Token(Token = "0x2000037")]
public delegate object GEBGFDMJIAN<T>(T GDDHAFPALIL);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[LLCGFMFCOAC]
public delegate void ACGEPEANAJD(string HNPIEGONNBC);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[LLCGFMFCOAC]
public delegate void HAOABCKLACI(Exception IOPPNPIHIME);
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
