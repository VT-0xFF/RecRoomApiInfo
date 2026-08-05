using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RecRoom.AI.OpenAI.Realtime;
using RecRoom.Audio;
using RecRoom.DataLayer.Audio;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80D00A0", Offset = "0x80CEEA0", VA = "0x1880D00A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_AI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80C82B0", Offset = "0x80C70B0", VA = "0x1880C82B0", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class GDOLADAAJFP : IDisposable, BEFCPOPEJJO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct AJAILDANCPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GDOLADAAJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80B8520", Offset = "0x80B7320", VA = "0x1880B8520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BJAMHMFHDIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public GDOLADAAJFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80B9C30", Offset = "0x80B8A30", VA = "0x1880B9C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80B9ED0", Offset = "0x80B8CD0", VA = "0x1880B9ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected static readonly ALMLLDBPKBM ICNEBIIBIEE;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly TimeSpan PBOKDCJHPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource BBPCDKNJCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KADEKFHNILF MBGAMNDKKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly long KEGIKLDJHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly long LGPKCGBEGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private decimal DDAEBCDFFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Guid OOACNIPJMJJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public decimal AMDJGFCLEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1296C90", Offset = "0x1295A90", VA = "0x181296C90")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F901B0", Offset = "0x7F8EFB0", VA = "0x187F901B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80BE850", Offset = "0x80BD650", VA = "0x1880BE850")]
	public GDOLADAAJFP(KADEKFHNILF BAOIGCEOOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80BE4C0", Offset = "0x80BD2C0", VA = "0x1880BE4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80BE530", Offset = "0x80BD330", VA = "0x1880BE530")]
	[AsyncStateMachine(typeof(AJAILDANCPC))]
	private void IFNKCGNHCNJ(CancellationToken BKHGNHANFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80BE690", Offset = "0x80BD490", VA = "0x1880BE690")]
	[AsyncStateMachine(typeof(BJAMHMFHDIK))]
	private Task<bool> PMALGNBFNMH(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task<bool> TrySyncLatestCostInfo(KADEKFHNILF BAOIGCEOOCA, Guid CCNMAHKNGLG, long MDNJLMOPJKG, long FMOODPJPGFG, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80BE600", Offset = "0x80BD400", VA = "0x1880BE600", Slot = "5")]
	public void NDICIJOABIC(decimal HHOJDNJMKHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum DPCLMPIHPFJ
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Float,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	String
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FCBPHGHMKPI : IEquatable<FCBPHGHMKPI>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected virtual Type OEFOLDOCPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80BCD90", Offset = "0x80BBB90", VA = "0x1880BCD90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DPCLMPIHPFJ FOJLLEMFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(DPCLMPIHPFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JHIHDGKCPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string[]? ALELIOHAFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80BD6B0", Offset = "0x80BC4B0", VA = "0x1880BD6B0")]
	public FCBPHGHMKPI(DPCLMPIHPFJ FOJLLEMFFFA, string LBDOKALIJED, string LPOBFFEBNKG = "", bool JHIHDGKCPHI = false, [Optional] string[]? ALELIOHAFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x80BD530", Offset = "0x80BC330", VA = "0x1880BD530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80BCDF0", Offset = "0x80BBBF0", VA = "0x1880BCDF0", Slot = "6")]
	protected virtual bool EHGPOBJHANF(StringBuilder MFKHJJEIPDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1288840", Offset = "0x1287640", VA = "0x181288840")]
	public static bool GFAFFKCBFKA(FCBPHGHMKPI? LIBGDNFNANP, FCBPHGHMKPI? ABBNFCGILDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x12889A0", Offset = "0x12877A0", VA = "0x1812889A0")]
	public static bool IKIADGFKNFC(FCBPHGHMKPI? LIBGDNFNANP, FCBPHGHMKPI? ABBNFCGILDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x80BD2D0", Offset = "0x80BC0D0", VA = "0x1880BD2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80BD030", Offset = "0x80BBE30", VA = "0x1880BD030", Slot = "0")]
	public override bool Equals(object? ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80BD0C0", Offset = "0x80BBEC0", VA = "0x1880BD0C0", Slot = "7")]
	public virtual bool Equals(FCBPHGHMKPI? FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80BCCF0", Offset = "0x80BBAF0", VA = "0x1880BCCF0", Slot = "8")]
	public virtual FCBPHGHMKPI BFCPCOJEJLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80BD640", Offset = "0x80BC440", VA = "0x1880BD640")]
	protected FCBPHGHMKPI(FCBPHGHMKPI HGJABFBKDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80BD4D0", Offset = "0x80BC2D0", VA = "0x1880BD4D0")]
	public void MLOAOPFMIPK([Out] DPCLMPIHPFJ FOJLLEMFFFA, [Out] string LBDOKALIJED, [Out] string LPOBFFEBNKG, [Out] bool JHIHDGKCPHI, [Out] string[]? ALELIOHAFNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ELOCGHPEDEF : IEquatable<ELOCGHPEDEF>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	protected virtual Type OEFOLDOCPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x80BBFA0", Offset = "0x80BADA0", VA = "0x1880BBFA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JToken BIKAJNDLCFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FCBPHGHMKPI EBGLIPCIHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1275F20", Offset = "0x1274D20", VA = "0x181275F20")]
	public ELOCGHPEDEF(JToken BIKAJNDLCFH, FCBPHGHMKPI EBGLIPCIHFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80BC800", Offset = "0x80BB600", VA = "0x1880BC800")]
	public static int LKEGILCJKAA(ELOCGHPEDEF HGMAIPELJHM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x80BC980", Offset = "0x80BB780", VA = "0x1880BC980")]
	public static float LKEGILCJKAA(ELOCGHPEDEF HGMAIPELJHM)
	{
		return default(float);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80BC8C0", Offset = "0x80BB6C0", VA = "0x1880BC8C0")]
	public static bool LKEGILCJKAA(ELOCGHPEDEF HGMAIPELJHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80BC600", Offset = "0x80BB400", VA = "0x1880BC600")]
	public static string LKEGILCJKAA(ELOCGHPEDEF HGMAIPELJHM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80BC4F0", Offset = "0x80BB2F0", VA = "0x1880BC4F0")]
	public static int[] LKEGILCJKAA(ELOCGHPEDEF HGMAIPELJHM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80BC6F0", Offset = "0x80BB4F0", VA = "0x1880BC6F0")]
	public static float[] LKEGILCJKAA(ELOCGHPEDEF HGMAIPELJHM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80BC3E0", Offset = "0x80BB1E0", VA = "0x1880BC3E0")]
	public static bool[] LKEGILCJKAA(ELOCGHPEDEF HGMAIPELJHM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80BCA40", Offset = "0x80BB840", VA = "0x1880BCA40")]
	public static string[] LKEGILCJKAA(ELOCGHPEDEF HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80BCB90", Offset = "0x80BB990", VA = "0x1880BCB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80BC000", Offset = "0x80BAE00", VA = "0x1880BC000", Slot = "6")]
	protected virtual bool EHGPOBJHANF(StringBuilder MFKHJJEIPDE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1288840", Offset = "0x1287640", VA = "0x181288840")]
	public static bool GFAFFKCBFKA(ELOCGHPEDEF? LIBGDNFNANP, ELOCGHPEDEF? ABBNFCGILDI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x12889A0", Offset = "0x12877A0", VA = "0x1812889A0")]
	public static bool IKIADGFKNFC(ELOCGHPEDEF? LIBGDNFNANP, ELOCGHPEDEF? ABBNFCGILDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x80BC2C0", Offset = "0x80BB0C0", VA = "0x1880BC2C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x80BC0F0", Offset = "0x80BAEF0", VA = "0x1880BC0F0", Slot = "0")]
	public override bool Equals(object? ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80BC180", Offset = "0x80BAF80", VA = "0x1880BC180", Slot = "7")]
	public virtual bool Equals(ELOCGHPEDEF? FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80BBF10", Offset = "0x80BAD10", VA = "0x1880BBF10", Slot = "8")]
	public virtual ELOCGHPEDEF BFCPCOJEJLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80BCCA0", Offset = "0x80BBAA0", VA = "0x1880BCCA0")]
	protected ELOCGHPEDEF(ELOCGHPEDEF HGJABFBKDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x80BCB50", Offset = "0x80BB950", VA = "0x1880BCB50")]
	public void MLOAOPFMIPK([Out] JToken BIKAJNDLCFH, [Out] FCBPHGHMKPI EBGLIPCIHFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HHGCHEIFPMJ : GNDKAOLLPCE
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string CLBHBLLFOCG = "Open AI Realtime API";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string LMKEGFBAGKA = "endpoint";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly string LHAHJHNHPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly List<Func<JIKOFGEBOPP.OEDBBECBHPO, JIKOFGEBOPP.OEDBBECBHPO>> POBCGOHJFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<Func<JIKOFGEBOPP.OEDBBECBHPO, JIKOFGEBOPP.OEDBBECBHPO>> ENKCAMCNNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly KBGKIIMABID KCFPFCJEGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly BEFCPOPEJJO PAGGCHIIOEI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FJDHLHLCJMG? CNNKFAFBIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string BBOOOMFBNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool DMBIPBDGOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x80BF150", Offset = "0x80BDF50", VA = "0x1880BF150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80C0F30", Offset = "0x80BFD30", VA = "0x1880C0F30")]
	public HHGCHEIFPMJ(KBGKIIMABID EACEJLJBCCC, BEFCPOPEJJO AHFPKCOKGFF, string FBCJJDMMBMD, string POHDOCNOAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80BFE10", Offset = "0x80BEC10", VA = "0x1880BFE10")]
	private static JIKOFGEBOPP.OEDBBECBHPO HENCABPMLEP(string DGLBPEBDJGI, string HIICEENFHFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80BFB30", Offset = "0x80BE930", VA = "0x1880BFB30")]
	private JIKOFGEBOPP.OEDBBECBHPO FNOFAAHEJPN(string DGLBPEBDJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80C0490", Offset = "0x80BF290", VA = "0x1880C0490", Slot = "8")]
	public void LLAFJIEFGAN(string? JOJHHDMMADL, string DEDKKCEGKBE, string GPOPGDNMKNJ, float EABOGDKHFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80BFEA0", Offset = "0x80BECA0", VA = "0x1880BFEA0", Slot = "10")]
	public void HMFNFJBABBO(string? JOJHHDMMADL, ErrorEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80BF1F0", Offset = "0x80BDFF0", VA = "0x1880BF1F0", Slot = "11")]
	public void DPNMHLPGDBN(string? JOJHHDMMADL, decimal CBBANDGEEIF, string KKBNGKDBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x80BFBD0", Offset = "0x80BE9D0", VA = "0x1880BFBD0")]
	public static void GOLKPELFFJF(BEFCPOPEJJO AHFPKCOKGFF, string FNEAAIJJGGG, string HIICEENFHFH, decimal CBBANDGEEIF, string KKBNGKDBMPF, params (string key, string val)[] NEBLDBHHBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80BF450", Offset = "0x80BE250", VA = "0x1880BF450", Slot = "12")]
	public void ELOJMGLJOPO(string? JOJHHDMMADL, ConversationItemDTO IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x80BEBE0", Offset = "0x80BD9E0", VA = "0x1880BEBE0", Slot = "15")]
	public void BNIBDAOOLKO(string? JOJHHDMMADL, ResponseEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80C00C0", Offset = "0x80BEEC0", VA = "0x1880C00C0")]
	private (decimal?, string, string, string, string, string) JGFGOIJIEHO(ResponseEventDTO DHGJJBIPCOC)
	{
		return default((decimal?, string, string, string, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80C07C0", Offset = "0x80BF5C0", VA = "0x1880C07C0", Slot = "13")]
	public void PALDBMHFHEB(string? JOJHHDMMADL, ResponseEventDTO DHGJJBIPCOC, float? PHAPFAFFMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80C0760", Offset = "0x80BF560", VA = "0x1880C0760", Slot = "14")]
	public void PADGGHGBJLH(Func<JIKOFGEBOPP.OEDBBECBHPO, JIKOFGEBOPP.OEDBBECBHPO> DDDMJJKHOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x80BFB70", Offset = "0x80BE970", VA = "0x1880BFB70", Slot = "9")]
	public void FPLNONFEPJJ(Func<JIKOFGEBOPP.OEDBBECBHPO, JIKOFGEBOPP.OEDBBECBHPO> DDDMJJKHOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x80BF9C0", Offset = "0x80BE7C0", VA = "0x1880BF9C0", Slot = "16")]
	public void FAEEJJILDMG(string? JOJHHDMMADL, string BCDABHDFJPD, string? OHILBHJCCLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class GBCDNHKPCMA : GNDKAOLLPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FJDHLHLCJMG? CNNKFAFBIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public decimal AMDJGFCLEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x80BE410", Offset = "0x80BD210", VA = "0x1880BE410")]
		get
		{
			return default(decimal);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public string BBOOOMFBNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public KBGKIIMABID? LHKFKHNPJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
	public void LLAFJIEFGAN(string? JOJHHDMMADL, string DEDKKCEGKBE, string GPOPGDNMKNJ, float EABOGDKHFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "9")]
	public void FPLNONFEPJJ(Func<JIKOFGEBOPP.OEDBBECBHPO, JIKOFGEBOPP.OEDBBECBHPO> DDDMJJKHOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "10")]
	public void HMFNFJBABBO(string? JOJHHDMMADL, ErrorEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "11")]
	public void DPNMHLPGDBN(string? JOJHHDMMADL, decimal CBBANDGEEIF, string KKBNGKDBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "12")]
	public void ELOJMGLJOPO(string? JOJHHDMMADL, ConversationItemDTO IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "15")]
	public void BNIBDAOOLKO(string? JOJHHDMMADL, ResponseEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "13")]
	public void PALDBMHFHEB(string? JOJHHDMMADL, ResponseEventDTO DHGJJBIPCOC, float? PHAPFAFFMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "14")]
	public void PADGGHGBJLH(Func<JIKOFGEBOPP.OEDBBECBHPO, JIKOFGEBOPP.OEDBBECBHPO> DDDMJJKHOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "16")]
	public void FAEEJJILDMG(string? JOJHHDMMADL, string BCDABHDFJPD, string? OHILBHJCCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x80BE470", Offset = "0x80BD270", VA = "0x1880BE470")]
	public GBCDNHKPCMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MAIFKJANHOI : GDOLADAAJFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct EGCEGEBGGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KADEKFHNILF recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MAIFKJANHOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Guid spendSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<FBHBLFFAFNF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x80BBB20", Offset = "0x80BA920", VA = "0x1880BBB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x80BBEA0", Offset = "0x80BACA0", VA = "0x1880BBEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly string NGBDAGGPBBH;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x80C8520", Offset = "0x80C7320", VA = "0x1880C8520")]
	public MAIFKJANHOI(KADEKFHNILF BAOIGCEOOCA, string EFDAMCFDHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x80C83C0", Offset = "0x80C71C0", VA = "0x1880C83C0", Slot = "6")]
	[AsyncStateMachine(typeof(EGCEGEBGGOP))]
	protected override Task<bool> TrySyncLatestCostInfo(KADEKFHNILF BAOIGCEOOCA, Guid CCNMAHKNGLG, long MDNJLMOPJKG, long FMOODPJPGFG, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NDACHOEMGJO
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	GBCEOPMAPJH<ConversationItemDTO> MEOGCPLLEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IReadOnlyList<ConversationItemDTO> CDHJKLDDHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<string> BIFGGPNAMMA(ConversationItemDTO IIHDHELGAFA);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOEFBKBMCGE(string MJIAGEIMKKC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CLEFGJDCPFJ
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KBJDPMFGKAL(IReadOnlyCollection<string> DJIBBNCGOKE, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BCDDDKAACNE
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ToolDTO[] IEHJIOJFPOE();

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> EFCMPHHNJGO(string HLFOJCNGCCB, string OBIAPOOKFHF, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FHGIBBKKCIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KBGKIIMABID
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	const string KHPALAHIHAO = "gpt-4o-mini-realtime-preview-2024-12-17";

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	const string NNNNLGAHJIM = "gpt-4o-mini-transcribe";

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MKGKDIAGEPI FJNFPEHCGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	AudioSource OJDICELOIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	NDACHOEMGJO? AKGHOCPGFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CLEFGJDCPFJ? NIIKIBEMGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string? AGHJGEKMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool OONFPBCBEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IIGADPEIOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HJDIDKLFGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool FNGMEFDGFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PECGCMHLGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool MMELONHKGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GLEJDGCGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NBIFKEHIKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MNJGFOAHHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NEFDCPNNGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IFGLGCDMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool INACMECDBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GBCEOPMAPJH<bool> COCHCKLPCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	MKAEDPHCCBC CMJLCDOBIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MKAEDPHCCBC HHNIMNNPCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FLNBPEKPFIH<string, string> HFNFGADLGNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MKAEDPHCCBC GNLPPNMEBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MKAEDPHCCBC JGPHBDMBGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	GBCEOPMAPJH<List<ToolDTO>> IIHDONIIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	MKAEDPHCCBC NJCIIKKAAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FLNBPEKPFIH<float, string> DIPEFJEPJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GBCEOPMAPJH<string> BLBJJCCEDPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string BBOOOMFBNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool AAFPHJPFCPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task CCPHEEBLNBO(string KPDGHKFKEJM, VoiceOption JLKDEPFEJBD, float EABOGDKHFEA = 0.6f, string JJBMBLPJJCM = "gpt-4o-mini-realtime-preview-2024-12-17", string GPOPGDNMKNJ = "gpt-4o-mini-transcribe", [Optional] IReadOnlyCollection<string>? FHEAHBLMCMP, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GBGHIEODIJB();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task LNKHIIHEEMP(string KPDGHKFKEJM, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task LAIIGLKKMIO(float EABOGDKHFEA, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task BCKKJAAMNJM(bool GDNKPNFMPCI, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GLEADCEEENG(params FHGIBBKKCIF[] BNFJIBCOMOO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool JGIJOLPNBDD(FHGIBBKKCIF BKIIONCAMIB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KNCGKPJPBFI(params FHGIBBKKCIF[] BNFJIBCOMOO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void OEOKDDELBOE(NLFFFLJOFLP OBGCPOCPFIJ, bool BHMGIHEFJMN = false);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GCJMNKEFKNE(NLFFFLJOFLP OBGCPOCPFIJ, bool BHMGIHEFJMN = false);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void NHBGHINAMCD(NLFFFLJOFLP OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IALDONKHNHL(NLFFFLJOFLP OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void ACJIIOIKOPJ(decimal CBBANDGEEIF, string KKBNGKDBMPF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task NEMFBDCKEHB(byte[] OGPCIEPDEKO, string? HHJCCHIFFMK, [Optional] string? LPJMMHAFKCE, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task NEMFBDCKEHB(string JDFCBBCKOGJ, [Optional] string? LPJMMHAFKCE, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task HFEIPKCPJAN(string JDFCBBCKOGJ, [Optional] string? LPJMMHAFKCE, [Optional] string? PIIHCAPKOFB, bool MEJOLOECEOA = false, bool IIHKEJIGJPO = false, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task HOEFBKBMCGE(string LPJMMHAFKCE, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<ResponseDTO> NNGJLIJPONL(bool EOIBKOOBBEH = true, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<string> IEBFGBIMFIO(string KPDGHKFKEJM, [Optional] IReadOnlyList<ConversationItemDTO>? DJIBBNCGOKE, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<TOutput> IEBFGBIMFIO<TOutput>(string KPDGHKFKEJM, [Optional] IReadOnlyList<ConversationItemDTO>? DJIBBNCGOKE, [Optional] CancellationToken BKHGNHANFKK) where TOutput : class;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<List<ELOCGHPEDEF>> IEBFGBIMFIO(string KPDGHKFKEJM, IReadOnlyList<ConversationItemDTO>? DJIBBNCGOKE, IReadOnlyList<FCBPHGHMKPI> HMKOEAKFCAJ, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool IMCGGCKNAHK(string MJIAGEIMKKC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool BBBHDLJBCGF(string MJIAGEIMKKC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool KFLGANFMPCE(string CDJIFIJBGMH);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task MLIIFHDAPBM(bool BOLHOEADKLF, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "55")]
	IReadOnlyCollection<string> MJFDOHEBNBL();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GNDKAOLLPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FJDHLHLCJMG? CNNKFAFBIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string BBOOOMFBNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLAFJIEFGAN(string? JOJHHDMMADL, string DEDKKCEGKBE, string GPOPGDNMKNJ, float EABOGDKHFEA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPLNONFEPJJ(Func<JIKOFGEBOPP.OEDBBECBHPO, JIKOFGEBOPP.OEDBBECBHPO> DDDMJJKHOOJ);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HMFNFJBABBO(string? JOJHHDMMADL, ErrorEventDTO DHGJJBIPCOC);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DPNMHLPGDBN(string? JOJHHDMMADL, decimal CBBANDGEEIF, string KKBNGKDBMPF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ELOJMGLJOPO(string? JOJHHDMMADL, ConversationItemDTO IIHDHELGAFA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PALDBMHFHEB(string? JOJHHDMMADL, ResponseEventDTO DHGJJBIPCOC, float? PHAPFAFFMAD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PADGGHGBJLH(Func<JIKOFGEBOPP.OEDBBECBHPO, JIKOFGEBOPP.OEDBBECBHPO> DDDMJJKHOOJ);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BNIBDAOOLKO(string? JOJHHDMMADL, ResponseEventDTO DHGJJBIPCOC);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FAEEJJILDMG(string? JOJHHDMMADL, string BCDABHDFJPD, string? OHILBHJCCLG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LGFNLEGOCKN
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void GJLFBGNDOBL(ReadOnlySpan<float> KNIGABCLPKJ, int GBHDIJIKCIM, int FMAPGJELDND);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMDPDGONMLI(GJLFBGNDOBL GPIDHOODOPJ);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGECGHHHEKJ(GJLFBGNDOBL GPIDHOODOPJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface BEFCPOPEJJO
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDICIJOABIC(decimal HHOJDNJMKHA);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MEABCBPOBNE
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private enum EHDNGFHDLPD
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		array,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		boolean,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		@enum,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		integer,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		number,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		@object,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		@string
	}

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static ConcurrentDictionary<Type, JsonSchema> IDNHAMNBDGJ;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly Type[] CLCOEHLODBE;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly Type[] DJKOIGHDHHG;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DF93E0", Offset = "0x3DF81E0", VA = "0x183DF93E0")]
	public static JsonSchema DPMBHNJHJDJ<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x80C91D0", Offset = "0x80C7FD0", VA = "0x1880C91D0")]
	public static JsonSchema LOMKLFHLODC(IReadOnlyList<FCBPHGHMKPI> NPIEBNDMCBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x80C9650", Offset = "0x80C8450", VA = "0x1880C9650")]
	public static HFHDOGPCANB PGNILAKLPDA(string PFLDDMDPCBI, string? CDEPGINEGKG, JsonSchema EBPNOFIKAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3DF95A0", Offset = "0x3DF83A0", VA = "0x183DF95A0")]
	public static HFHDOGPCANB PGNILAKLPDA<T>(string PFLDDMDPCBI, string? CDEPGINEGKG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x80C9500", Offset = "0x80C8300", VA = "0x1880C9500")]
	public static HFHDOGPCANB PGNILAKLPDA(string PFLDDMDPCBI, string? CDEPGINEGKG, IReadOnlyList<FCBPHGHMKPI> NPIEBNDMCBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x80C8D90", Offset = "0x80C7B90", VA = "0x1880C8D90")]
	private static JsonSchema FGIOBLGFLMP(Type ADGMECOLKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x80C85A0", Offset = "0x80C73A0", VA = "0x1880C85A0")]
	private static JsonSchema AJIGFEHBAGF(Type ADGMECOLKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x80C9760", Offset = "0x80C8560", VA = "0x1880C9760")]
	private static EHDNGFHDLPD PLLNMCMNIEB(Type ADGMECOLKNH, [Out] Type? DJFIONKHNPB)
	{
		return default(EHDNGFHDLPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x80C8B20", Offset = "0x80C7920", VA = "0x1880C8B20")]
	private static bool BPPCHGBKFFB(Type ADGMECOLKNH, [Out][MaybeNullWhen(false)] Type HKKOEHKPCHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LIJILFHJAEH : FHGIBBKKCIF, BCDDDKAACNE
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<string> OFGBBIGHAOL(List<ELOCGHPEDEF> BNOPOAPPFBM);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate string BLLODAGONHE(List<ELOCGHPEDEF> BNOPOAPPFBM);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LFHFMOMJCIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public BLLODAGONHE handler;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LFHFMOMJCIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x80C77A0", Offset = "0x80C65A0", VA = "0x1880C77A0")]
		internal Task<string> LHBPIFBKPOF(List<ELOCGHPEDEF> invokedArgs)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct BHIELJALFIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public string methodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public LIJILFHJAEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string methodArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x80B9510", Offset = "0x80B8310", VA = "0x1880B9510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x80B9BC0", Offset = "0x80B89C0", VA = "0x1880B9BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly string FBGMEKFLBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly string LKJBPKELAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IReadOnlyList<FCBPHGHMKPI> DMGAJLCOGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly OFGBBIGHAOL NGJJIPPIDOB;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x10F4000", Offset = "0x10F2E00", VA = "0x1810F4000")]
	public LIJILFHJAEH(string PFLDDMDPCBI, string CDEPGINEGKG, IReadOnlyList<FCBPHGHMKPI> NPIEBNDMCBK, OFGBBIGHAOL PMJKNCNKPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x80C7AF0", Offset = "0x80C68F0", VA = "0x1880C7AF0")]
	public LIJILFHJAEH(string PFLDDMDPCBI, string CDEPGINEGKG, IReadOnlyList<FCBPHGHMKPI> NPIEBNDMCBK, BLLODAGONHE PMJKNCNKPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x80C7830", Offset = "0x80C6630", VA = "0x1880C7830", Slot = "4")]
	private ToolDTO[] CCOHDHEHBLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x80C79B0", Offset = "0x80C67B0", VA = "0x1880C79B0", Slot = "5")]
	[AsyncStateMachine(typeof(BHIELJALFIG))]
	private Task<string> JLIPHPPAAHA(string HLFOJCNGCCB, string OBIAPOOKFHF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class FINNMKFKMOD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public FINNMKFKMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OOIEPNCCBPO : Exception, KAKABGFKBDO
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string MMFCCDMLCFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x55F6C20", Offset = "0x55F5A20", VA = "0x1855F6C20", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x80D1380", Offset = "0x80D0180", VA = "0x1880D1380")]
	public OOIEPNCCBPO(string BBMJIEIMLIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class NKBGGJCHNAF : KBGKIIMABID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private enum NDHAFIFGAAA
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		NotConnected,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Connected
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct KBECDHAIFNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int? reconnectAttempt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private CancellationTokenSource <cts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private CancellationToken <originalCancellationToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IDisposable <combinedTokenDisposer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private string <instructions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private float <temperature>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<MKGKDIAGEPI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x80C3540", Offset = "0x80C2340", VA = "0x1880C3540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x80C5930", Offset = "0x80C4730", VA = "0x1880C5930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct AOMGBCAENIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public bool keepConversationHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x80B88D0", Offset = "0x80B76D0", VA = "0x1880B88D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x80B8AE0", Offset = "0x80B78E0", VA = "0x1880B8AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct ABFMJGMJCPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x80B7B60", Offset = "0x80B6960", VA = "0x1880B7B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x80B7D90", Offset = "0x80B6B90", VA = "0x1880B7D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct PMLMPPKNMBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public float temperature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x80D1930", Offset = "0x80D0730", VA = "0x1880D1930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x80D1B40", Offset = "0x80D0940", VA = "0x1880D1B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct GAJBJFFNFAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x80BE1A0", Offset = "0x80BCFA0", VA = "0x1880BE1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x80BE3B0", Offset = "0x80BD1B0", VA = "0x1880BE3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct NOCBKCIMNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x80CFD40", Offset = "0x80CEB40", VA = "0x1880CFD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x80D0040", Offset = "0x80CEE40", VA = "0x1880D0040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CMBNOMJMMBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public byte[] pcmAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string transcript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x80BAA70", Offset = "0x80B9870", VA = "0x1880BAA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x80BAEF0", Offset = "0x80B9CF0", VA = "0x1880BAEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct PBELBGCLFOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x80D1460", Offset = "0x80D0260", VA = "0x1880D1460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x80D18D0", Offset = "0x80D06D0", VA = "0x1880D18D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct MLLLAEDMAEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string conversationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool suppressFromConversationLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool excludeFromConversationPruning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public string previousItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x80C9F10", Offset = "0x80C8D10", VA = "0x1880C9F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x80CA460", Offset = "0x80C9260", VA = "0x1880CA460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ACEJKDIMJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public string convresationItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x80B7DF0", Offset = "0x80B6BF0", VA = "0x1880B7DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x80B8320", Offset = "0x80B7120", VA = "0x1880B8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class LBAPDDHAHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ResponseDTO response;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LBAPDDHAHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x80C7770", Offset = "0x80C6570", VA = "0x1880C7770")]
		internal bool JFJADDCGJCA(OutputAudioBufferEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BFBFPGOMONH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private LBAPDDHAHOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool waitForAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<OutputAudioBufferEventDTO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x80B8C50", Offset = "0x80B7A50", VA = "0x1880B8C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x80B94A0", Offset = "0x80B82A0", VA = "0x1880B94A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct JHHHGHICPHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x80C2980", Offset = "0x80C1780", VA = "0x1880C2980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x80C2F00", Offset = "0x80C1D00", VA = "0x1880C2F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct DKHNHAPFJPK<TOutput> : IAsyncStateMachine where TOutput : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncTaskMethodBuilder<TOutput> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x45721B0", Offset = "0x4570FB0", VA = "0x1845721B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4572A00", Offset = "0x4571800", VA = "0x184572A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct FFIOMHJOLKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder<List<ELOCGHPEDEF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public IReadOnlyList<FCBPHGHMKPI> responseArgSchemas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private TaskAwaiter<List<ConversationItemDTO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x80BD720", Offset = "0x80BC520", VA = "0x1880BD720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x80BDDF0", Offset = "0x80BCBF0", VA = "0x1880BDDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class DFBIEFNLLNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public ResponseCreateEventDTO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public string id;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DFBIEFNLLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x80BB510", Offset = "0x80BA310", VA = "0x1880BB510")]
		internal void DCBHMJJOAGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x80BB610", Offset = "0x80BA410", VA = "0x1880BB610")]
		internal bool JGLKOBEHIPN(ResponseEventDTO ev)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct IIDDIHPAEHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder<List<ConversationItemDTO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public string instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public IReadOnlyList<ConversationItemDTO> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public JsonSchema responseSchema;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter<ResponseEventDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x80C1060", Offset = "0x80BFE60", VA = "0x1880C1060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x80C18E0", Offset = "0x80C06E0", VA = "0x1880C18E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct JBMEDOIOPBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public DateTime expirationTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x80C2530", Offset = "0x80C1330", VA = "0x1880C2530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x80C2920", Offset = "0x80C1720", VA = "0x1880C2920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DHJECOCKGJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private List<ToolDTO> <tools>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x80BB6A0", Offset = "0x80BA4A0", VA = "0x1880BB6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x80BBAC0", Offset = "0x80BA8C0", VA = "0x1880BBAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct COBFODCGCHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public ResponseEventDTO ev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private string <responseId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x80BAF50", Offset = "0x80B9D50", VA = "0x1880BAF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HALNOJGAKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HALNOJGAKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x80BEAC0", Offset = "0x80BD8C0", VA = "0x1880BEAC0")]
		internal Task JHPOMLIMHMO(ConversationItemDTO outputItem)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KGDKLPINMPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public ResponseDTO response;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private HALNOJGAKPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x80C5990", Offset = "0x80C4790", VA = "0x1880C5990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x80C6130", Offset = "0x80C4F30", VA = "0x1880C6130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct FJLDIBEJMLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x80BDE60", Offset = "0x80BCC60", VA = "0x1880BDE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x80BE100", Offset = "0x80BCF00", VA = "0x1880BE100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct LNNABNJHADN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter<ResponseDTO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x80C7CE0", Offset = "0x80C6AE0", VA = "0x1880C7CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x80C8040", Offset = "0x80C6E40", VA = "0x1880C8040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct IJOPHBOFGFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder<ResponseDTO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NKBGGJCHNAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <cancellationToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private DateTime? <startTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter<ResponseDTO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x80C1950", Offset = "0x80C0750", VA = "0x1880C1950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x80C2470", Offset = "0x80C1270", VA = "0x1880C2470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly ALMLLDBPKBM ICNEBIIBIEE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private const ToolChoice DOJBNLOMOOB = ToolChoice.Auto;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private const float IIMEIFKGEEB = 0.01f;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly TimeSpan[] MNBIGPPHHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly TimeSpan OOBHMKNAPFF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly TimeSpan OEOHDDAOGAG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly TimeSpan ICHAIIHIFEF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly TimeSpan ACKMJAMJGJN;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly TimeSpan DHPAMBPMDNL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly TimeSpan DILLOKJNJJE;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private const string HCEKHEEBMPB = "out-of-band-id";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly IKFFBFOGBBE HNFBJHMLHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LGFNLEGOCKN DDFCLDFNKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	protected readonly KADEKFHNILF MBGAMNDKKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CJFHIMALPIM MONLNAFNKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly PJGOEGFNGHE LPENAFDBPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly PJGOEGFNGHE FKDDPNEMOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<string, DateTime> GKLLNADMNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Lazy<GNDKAOLLPCE> JGPLEFNHGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly JKAJGCDOAAD? EJGICJFOCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private string AOHLAIMBDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private VoiceOption HPAPPELLLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private float OJBIAPAIHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private string FGBPNFENMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private string BHEBANLOOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NDHAFIFGAAA HLCAKIGJPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CancellationTokenSource? BBPCDKNJCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected MKGKDIAGEPI? NDMICGBJDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private AudioSource DGMBPEFFPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private AudioSourceSimpleLevelMeter? GDJJHALFKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private KPHKKHCNCEI? NGGICBINKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private HKMAOKGOGME? BLKNFLHLGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private OKBDDBAHFOE? MDDJAJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private IKFBBNDKHGC? EBCOFIDDAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private IReadOnlyCollection<string> FMDCJCPBODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private DateTime? AEMKFDACKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Task<ResponseDTO>? DAOHJPILJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private uint HOBPONKKKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly HashSet<string> HGAIMODIKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly HashSet<string> BFFJOPJFNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly HashSet<string> CPCONAGCJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool AAJPKOBIJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NLFFFLJOFLP? GCELGOGEJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool EJOIENNKOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private CancellationTokenSource? NFIFNCHOLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private string? FGIGPBJCJAH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public MKGKDIAGEPI FJNFPEHCGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x80CD000", Offset = "0x80CBE00", VA = "0x1880CD000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string? AGHJGEKMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x80CBD90", Offset = "0x80CAB90", VA = "0x1880CBD90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public abstract bool OONFPBCBEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public abstract bool IIGADPEIOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract bool HJDIDKLFGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	protected abstract bool IFPFMICMIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected abstract string? EMGMJKJGDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected abstract string HDHGFPAMHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected abstract int FDDDJNALJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected abstract int GMABLOEEPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected abstract LGJGFMPBMCG HLNLNCNBPJA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	protected abstract string BIAEDIPDENM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	protected virtual bool AMDFLNBBMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool FNGMEFDGFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x80CE730", Offset = "0x80CD530", VA = "0x1880CE730", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool PECGCMHLGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x80CB8C0", Offset = "0x80CA6C0", VA = "0x1880CB8C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MMELONHKGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x80CE6A0", Offset = "0x80CD4A0", VA = "0x1880CE6A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool GLEJDGCGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xC10B20", Offset = "0xC0F920", VA = "0x180C10B20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC0C370", Offset = "0xC0B170", VA = "0x180C0C370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool NBIFKEHIKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x80CCEF0", Offset = "0x80CBCF0", VA = "0x1880CCEF0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool MNJGFOAHHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x80CF160", Offset = "0x80CDF60", VA = "0x1880CF160", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NEFDCPNNGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2884840", Offset = "0x2883640", VA = "0x182884840", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool IFGLGCDMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x80CED60", Offset = "0x80CDB60", VA = "0x1880CED60", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool INACMECDBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x80CCB30", Offset = "0x80CB930", VA = "0x1880CCB30", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private bool ILCPKOMAIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x80CD740", Offset = "0x80CC540", VA = "0x1880CD740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private bool HOLPBJFCGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x80CEEF0", Offset = "0x80CDCF0", VA = "0x1880CEEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private bool GELLCDPKPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x80CF140", Offset = "0x80CDF40", VA = "0x1880CF140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool AAFPHJPFCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x26AF0E0", Offset = "0x26ADEE0", VA = "0x1826AF0E0", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x80CF150", Offset = "0x80CDF50", VA = "0x1880CF150", Slot = "58")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private uint NIGFMFEHLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xB550F0", Offset = "0xB53EF0", VA = "0x180B550F0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x80CECB0", Offset = "0x80CDAB0", VA = "0x1880CECB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public AudioSource OJDICELOIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xB1E590", Offset = "0xB1D390", VA = "0x180B1E590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public NDACHOEMGJO? AKGHOCPGFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xB631C0", Offset = "0xB61FC0", VA = "0x180B631C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public CLEFGJDCPFJ? NIIKIBEMGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xAA3060", Offset = "0xAA1E60", VA = "0x180AA3060", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string BBOOOMFBNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x80CCBD0", Offset = "0x80CB9D0", VA = "0x1880CCBD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x80CEFB0", Offset = "0x80CDDB0", VA = "0x1880CEFB0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected virtual string? OIMJDFKGLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xB893F0", Offset = "0xB881F0", VA = "0x180B893F0", Slot = "73")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected virtual ALMLLDBPKBM? CIAHKAHDAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "74")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual ALMLLDBPKBM? LKDLLNDFFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "75")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public GBCEOPMAPJH<bool> COCHCKLPCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xC0BB10", Offset = "0xC0A910", VA = "0x180C0BB10", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public MKAEDPHCCBC CMJLCDOBIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xC0A400", Offset = "0xC09200", VA = "0x180C0A400", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public MKAEDPHCCBC HHNIMNNPCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xC11470", Offset = "0xC10270", VA = "0x180C11470", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public FLNBPEKPFIH<string, string> HFNFGADLGNE
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xC1CF50", Offset = "0xC1BD50", VA = "0x180C1CF50", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public GBCEOPMAPJH<List<ToolDTO>> IIHDONIIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xC0FA30", Offset = "0xC0E830", VA = "0x180C0FA30", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public MKAEDPHCCBC GNLPPNMEBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xC0CAA0", Offset = "0xC0B8A0", VA = "0x180C0CAA0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public MKAEDPHCCBC JGPHBDMBGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xC10420", Offset = "0xC0F220", VA = "0x180C10420", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public MKAEDPHCCBC NJCIIKKAAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xC1D100", Offset = "0xC1BF00", VA = "0x180C1D100", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public FLNBPEKPFIH<float, string> DIPEFJEPJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xC0E3F0", Offset = "0xC0D1F0", VA = "0x180C0E3F0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GBCEOPMAPJH<string> BLBJJCCEDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xC08F80", Offset = "0xC07D80", VA = "0x180C08F80", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x80CF4B0", Offset = "0x80CE2B0", VA = "0x1880CF4B0")]
	public NKBGGJCHNAF(IKFFBFOGBBE JHFMJAIJECJ, LGFNLEGOCKN OCJAEIANKDG, KADEKFHNILF BAOIGCEOOCA, [Optional] JKAJGCDOAAD? GGNGNLNBFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "61")]
	protected abstract GNDKAOLLPCE CreateDataReporter();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x80CAC60", Offset = "0x80C9A60", VA = "0x1880CAC60")]
	private void ADIHPDOEIJL(FHGIBBKKCIF LNCBLGCJBKL, BCDDDKAACNE? PMJKNCNKPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x80CB580", Offset = "0x80CA380", VA = "0x1880CB580", Slot = "31")]
	public Task CCPHEEBLNBO(string KPDGHKFKEJM, VoiceOption JLKDEPFEJBD, float EABOGDKHFEA, string JJBMBLPJJCM, string GPOPGDNMKNJ, [Optional] IReadOnlyCollection<string>? FHEAHBLMCMP, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x80CDB50", Offset = "0x80CC950", VA = "0x1880CDB50")]
	[AsyncStateMachine(typeof(KBECDHAIFNK))]
	private Task LMHCHDFEBFK(int? HLOHEANCIJE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x80CB830", Offset = "0x80CA630", VA = "0x1880CB830", Slot = "76")]
	protected virtual Task CheckAccess(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x80CF240", Offset = "0x80CE040", VA = "0x1880CF240", Slot = "77")]
	protected virtual Task<bool> UploadTranscriptsForModeration(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x80CBF00", Offset = "0x80CAD00", VA = "0x1880CBF00", Slot = "32")]
	public void GBGHIEODIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x80CE7A0", Offset = "0x80CD5A0", VA = "0x1880CE7A0", Slot = "55")]
	[AsyncStateMachine(typeof(AOMGBCAENIF))]
	public Task MLIIFHDAPBM(bool BOLHOEADKLF, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x80CBA40", Offset = "0x80CA840", VA = "0x1880CBA40", Slot = "78")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x80CDC70", Offset = "0x80CCA70", VA = "0x1880CDC70", Slot = "33")]
	[AsyncStateMachine(typeof(ABFMJGMJCPG))]
	public Task LNKHIIHEEMP(string KPDGHKFKEJM, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x80CD8D0", Offset = "0x80CC6D0", VA = "0x1880CD8D0", Slot = "34")]
	[AsyncStateMachine(typeof(PMLMPPKNMBI))]
	public Task LAIIGLKKMIO(float EABOGDKHFEA, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x80CA9F0", Offset = "0x80C97F0", VA = "0x1880CA9F0")]
	[AsyncStateMachine(typeof(GAJBJFFNFAM))]
	public Task ABKFCJOGOMG(bool GDNKPNFMPCI, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x80CB330", Offset = "0x80CA130", VA = "0x1880CB330", Slot = "35")]
	[AsyncStateMachine(typeof(NOCBKCIMNCH))]
	public Task BCKKJAAMNJM(bool GDNKPNFMPCI, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x80CCB50", Offset = "0x80CB950", VA = "0x1880CCB50", Slot = "36")]
	public void GLEADCEEENG(params FHGIBBKKCIF[] BNFJIBCOMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x80CD550", Offset = "0x80CC350", VA = "0x1880CD550", Slot = "37")]
	public bool JGIJOLPNBDD(FHGIBBKKCIF BKIIONCAMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x80CD850", Offset = "0x80CC650", VA = "0x1880CD850", Slot = "38")]
	public void KNCGKPJPBFI(params FHGIBBKKCIF[] BNFJIBCOMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x80CEF40", Offset = "0x80CDD40", VA = "0x1880CEF40", Slot = "39")]
	public void OEOKDDELBOE(NLFFFLJOFLP OBGCPOCPFIJ, bool BHMGIHEFJMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x80CCAC0", Offset = "0x80CB8C0", VA = "0x1880CCAC0", Slot = "40")]
	public void GCJMNKEFKNE(NLFFFLJOFLP OBGCPOCPFIJ, bool BHMGIHEFJMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x80CED20", Offset = "0x80CDB20", VA = "0x1880CED20", Slot = "41")]
	public void NHBGHINAMCD(NLFFFLJOFLP OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x80CCEB0", Offset = "0x80CBCB0", VA = "0x1880CCEB0", Slot = "42")]
	public void IALDONKHNHL(NLFFFLJOFLP OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x80CE740", Offset = "0x80CD540", VA = "0x1880CE740", Slot = "59")]
	public IReadOnlyCollection<string> MJFDOHEBNBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x80CAB00", Offset = "0x80C9900", VA = "0x1880CAB00", Slot = "43")]
	public void ACJIIOIKOPJ(decimal CBBANDGEEIF, string KKBNGKDBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x80CEB60", Offset = "0x80CD960", VA = "0x1880CEB60", Slot = "44")]
	[AsyncStateMachine(typeof(CMBNOMJMMBG))]
	public Task NEMFBDCKEHB(byte[] OGPCIEPDEKO, string? HHJCCHIFFMK, string? LPJMMHAFKCE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x80CEA20", Offset = "0x80CD820", VA = "0x1880CEA20", Slot = "45")]
	[AsyncStateMachine(typeof(PBELBGCLFOI))]
	public Task NEMFBDCKEHB(string JDFCBBCKOGJ, string? LPJMMHAFKCE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x80CCC40", Offset = "0x80CBA40", VA = "0x1880CCC40", Slot = "46")]
	[AsyncStateMachine(typeof(MLLLAEDMAEK))]
	public Task HFEIPKCPJAN(string JDFCBBCKOGJ, string? LPJMMHAFKCE, string? PIIHCAPKOFB, bool MEJOLOECEOA, bool IIHKEJIGJPO, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x80CCD90", Offset = "0x80CBB90", VA = "0x1880CCD90", Slot = "47")]
	[AsyncStateMachine(typeof(ACEJKDIMJJB))]
	public Task HOEFBKBMCGE(string FMPLCNDMOJN, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x80CD400", Offset = "0x80CC200", VA = "0x1880CD400", Slot = "52")]
	public bool IMCGGCKNAHK(string MJIAGEIMKKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x80CB2D0", Offset = "0x80CA0D0", VA = "0x1880CB2D0", Slot = "53")]
	public bool BBBHDLJBCGF(string MJIAGEIMKKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x80CD570", Offset = "0x80CC370", VA = "0x1880CD570", Slot = "54")]
	public bool KFLGANFMPCE(string CDJIFIJBGMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x80CEDB0", Offset = "0x80CDBB0", VA = "0x1880CEDB0", Slot = "48")]
	[AsyncStateMachine(typeof(BFBFPGOMONH))]
	public Task<ResponseDTO> NNGJLIJPONL(bool EOIBKOOBBEH = true, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x80CD0A0", Offset = "0x80CBEA0", VA = "0x1880CD0A0", Slot = "49")]
	[AsyncStateMachine(typeof(JHHHGHICPHA))]
	public Task<string> IEBFGBIMFIO(string KPDGHKFKEJM, [Optional] IReadOnlyList<ConversationItemDTO>? DJIBBNCGOKE, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3E76C20", Offset = "0x3E75A20", VA = "0x183E76C20", Slot = "50")]
	[AsyncStateMachine(typeof(DKHNHAPFJPK<>))]
	public Task<TOutput> IEBFGBIMFIO<TOutput>(string KPDGHKFKEJM, [Optional] IReadOnlyList<ConversationItemDTO>? DJIBBNCGOKE, [Optional] CancellationToken BKHGNHANFKK) where TOutput : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x80CD200", Offset = "0x80CC000", VA = "0x1880CD200", Slot = "51")]
	[AsyncStateMachine(typeof(FFIOMHJOLKG))]
	public Task<List<ELOCGHPEDEF>> IEBFGBIMFIO(string KPDGHKFKEJM, IReadOnlyList<ConversationItemDTO>? DJIBBNCGOKE, IReadOnlyList<FCBPHGHMKPI> HMKOEAKFCAJ, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x80CE8B0", Offset = "0x80CD6B0", VA = "0x1880CE8B0")]
	[AsyncStateMachine(typeof(IIDDIHPAEHC))]
	private Task<List<ConversationItemDTO>> MOGGHDIDMBP(string KPDGHKFKEJM, IReadOnlyList<ConversationItemDTO>? DJIBBNCGOKE, JsonSchema? NCNCDPLILFO, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x80CB930", Offset = "0x80CA730", VA = "0x1880CB930")]
	[AsyncStateMachine(typeof(JBMEDOIOPBN))]
	private Task DIGAADBBAMF(DateTime AGPDGJKFNCG, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x80CAFE0", Offset = "0x80C9DE0", VA = "0x1880CAFE0")]
	private bool AOCGCHHAPOM(ResponseDTO PNCENNMICLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x80CF0A0", Offset = "0x80CDEA0", VA = "0x1880CF0A0")]
	private void OKPICDBPJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x80CB230", Offset = "0x80CA030", VA = "0x1880CB230")]
	private void AOMIOBKLCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x80CB680", Offset = "0x80CA480", VA = "0x1880CB680")]
	[AsyncStateMachine(typeof(DHJECOCKGJL))]
	private Task CGLMLJGLMDP([Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x80CD460", Offset = "0x80CC260", VA = "0x1880CD460")]
	private void JFPPJDPIDOG(ReadOnlySpan<float> KNIGABCLPKJ, int GBHDIJIKCIM, int FMAPGJELDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x80CB770", Offset = "0x80CA570", VA = "0x1880CB770")]
	private void CJFPPOOHFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x80CCF30", Offset = "0x80CBD30", VA = "0x1880CCF30")]
	[AsyncStateMachine(typeof(COBFODCGCHK))]
	private void ICPPAMKLADI(ResponseEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x80CE560", Offset = "0x80CD360", VA = "0x1880CE560")]
	private void MEOGCPLLEIH(ConversationItemDTO IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3E76AE0", Offset = "0x3E758E0", VA = "0x183E76AE0")]
	private void HLHHCMAFOFP<T>(T DHGJJBIPCOC) where T : notnull, PLGDJDFNEBH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x80CDDB0", Offset = "0x80CCBB0", VA = "0x1880CDDB0")]
	private void MBEILGNHNAI(ResponseEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x80CD9E0", Offset = "0x80CC7E0", VA = "0x1880CD9E0")]
	private void LEDEIMFCLMC(string DEDKKCEGKBE, string GPOPGDNMKNJ, float EABOGDKHFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x80CBDE0", Offset = "0x80CABE0", VA = "0x1880CBDE0")]
	[AsyncStateMachine(typeof(KGDKLPINMPJ))]
	private Task GAECLMPJDGB(ResponseDTO PNCENNMICLF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x80CBC80", Offset = "0x80CAA80", VA = "0x1880CBC80")]
	[AsyncStateMachine(typeof(FJLDIBEJMLP))]
	private Task EFCMPHHNJGO(ConversationItemDTO IIHDHELGAFA, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x80CC9B0", Offset = "0x80CB7B0", VA = "0x1880CC9B0")]
	[AsyncStateMachine(typeof(LNNABNJHADN))]
	private Task<ResponseDTO> GCBHADIGGLB(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x80CBB70", Offset = "0x80CA970", VA = "0x1880CBB70")]
	[AsyncStateMachine(typeof(IJOPHBOFGFG))]
	private Task<ResponseDTO> ECLAICMLDJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x80CB440", Offset = "0x80CA240", VA = "0x1880CB440")]
	private void BMDIKLIAOPP(ErrorEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x80CDD80", Offset = "0x80CCB80", VA = "0x1880CDD80")]
	private void LNPKGDDGBBM(InputAudioBufferSpeechStartedEventDTO OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x80CF1B0", Offset = "0x80CDFB0", VA = "0x1880CF1B0")]
	private void PMINPJKEFPC(InputAudioBufferSpeechStoppedEventDTO OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x80CD5F0", Offset = "0x80CC3F0", VA = "0x1880CD5F0")]
	protected void KGEKFHPLJCF(string BCDABHDFJPD, [Optional] string? OHILBHJCCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x80CD390", Offset = "0x80CC190", VA = "0x1880CD390")]
	public static bool IINMHGFHGJA(ResponseDTO PNCENNMICLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x80CD370", Offset = "0x80CC170", VA = "0x1880CD370")]
	protected void IEMLHJKNKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x80CCEF0", Offset = "0x80CBCF0", VA = "0x1880CCEF0")]
	[CompilerGenerated]
	private bool NEJBDFIMLCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x80CB620", Offset = "0x80CA420", VA = "0x1880CB620")]
	[CompilerGenerated]
	private bool CFPONBLHNLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class LPFKPEALIKF : GDOLADAAJFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct MOGGIIOMMBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public KADEKFHNILF recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public LPFKPEALIKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public Guid spendSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter<FBHBLFFAFNF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x80CA4C0", Offset = "0x80C92C0", VA = "0x1880CA4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x80CA980", Offset = "0x80C9780", VA = "0x1880CA980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly KBGKIIMABID KCFPFCJEGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly string NGBDAGGPBBH;

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x80C8210", Offset = "0x80C7010", VA = "0x1880C8210")]
	public LPFKPEALIKF(KBGKIIMABID EACEJLJBCCC, KADEKFHNILF BAOIGCEOOCA, string EFDAMCFDHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x80C80B0", Offset = "0x80C6EB0", VA = "0x1880C80B0", Slot = "6")]
	[AsyncStateMachine(typeof(MOGGIIOMMBJ))]
	protected override Task<bool> TrySyncLatestCostInfo(KADEKFHNILF BAOIGCEOOCA, Guid CCNMAHKNGLG, long MDNJLMOPJKG, long FMOODPJPGFG, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public class JHJGPKKJCGC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public JHJGPKKJCGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface MCHPDCIGIKJ
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOHAOFILDFC(FHGIBBKKCIF BKIIONCAMIB, [Out] BCDDDKAACNE PMJKNCNKPFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class BMENKCJOHNP
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class AGCCMAFMJOD
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public PropertyInfo LPFBLFEBJMO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Type ANCILOBJLOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x7340410", Offset = "0x733F210", VA = "0x187340410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string NEHKDCLCGEK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool FHEIJJEMALC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Type? MKOLCKCEELD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x80B8380", Offset = "0x80B7180", VA = "0x1880B8380")]
		public AGCCMAFMJOD(PropertyInfo BLILJBLCICN, JsonPropertyAttribute? IEGBBEFBDMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly ConcurrentDictionary<Type, List<AGCCMAFMJOD>> ABPEFFHJOGK;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x80B9F40", Offset = "0x80B8D40", VA = "0x1880B9F40")]
	public static List<string> BBJOLEKFMOO(string FFEGLLCDOHA, Type PLNLFODIIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x80BA030", Offset = "0x80B8E30", VA = "0x1880BA030")]
	private static void DHCNIAKMACC(Type ADGMECOLKNH, JObject IOAHCDHPANA, List<string> OLODDCKLKBP, string POAKPJBJHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x80BA6F0", Offset = "0x80B94F0", VA = "0x1880BA6F0")]
	private static List<AGCCMAFMJOD> NKAEAEBCNPI(Type ADGMECOLKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x80BA640", Offset = "0x80B9440", VA = "0x1880BA640")]
	private static bool JPIJOLAPPPJ(Type ADGMECOLKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BMENKCJOHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class OKBDDBAHFOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class CPEKFABEFOA
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string? IBLCBIHMNHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public int CCPIIIJNFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public int OHAJFJDJDEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xED7EC0", Offset = "0xED6CC0", VA = "0x180ED7EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x80BB4F0", Offset = "0x80BA2F0", VA = "0x1880BB4F0")]
		public CPEKFABEFOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class ONCEPGBFGJP
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public string FBLHFPABBMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public ConversationItemType FOJLLEMFFFA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(ConversationItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string? HJAGHGKMMNM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string? LBDOKALIJED
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x80D1310", Offset = "0x80D0110", VA = "0x1880D1310")]
		public ONCEPGBFGJP(ConversationItemDTO IIHDHELGAFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class BCIINCCJLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public IEnumerable<string> functionNames;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BCIINCCJLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x80B8B40", Offset = "0x80B7940", VA = "0x1880B8B40")]
		internal bool EBAFAGFBBOB(ONCEPGBFGJP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class FMICAMAHLLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public ONCEPGBFGJP c;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FMICAMAHLLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x80BE160", Offset = "0x80BCF60", VA = "0x1880BE160")]
		internal bool BHEIKHKOOID(string n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class AAEKKOKFNIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public OKBDDBAHFOE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AAEKKOKFNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x80B7B20", Offset = "0x80B6920", VA = "0x1880B7B20")]
		internal bool FLOOKPKNGKA(string n)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x80B78B0", Offset = "0x80B66B0", VA = "0x1880B78B0")]
		internal bool FIBGIDKBEGN(ONCEPGBFGJP c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x80B7900", Offset = "0x80B6700", VA = "0x1880B7900")]
		internal void FJBAKKEGNGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class OGAIJCKJBCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public IEnumerable<string?> callIdsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public OGAIJCKJBCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x80D0120", Offset = "0x80CEF20", VA = "0x1880D0120")]
		internal bool MAOGFPBNDHF(ONCEPGBFGJP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class PACOEMHMKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public IEnumerable<string> idsToRemove;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PACOEMHMKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x80D1400", Offset = "0x80D0200", VA = "0x1880D1400")]
		internal bool ENKAPBACILA(ONCEPGBFGJP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JAMAHJFDJLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Func<bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JAMAHJFDJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x80C24E0", Offset = "0x80C12E0", VA = "0x1880C24E0")]
		internal bool CIDMNLPPNBA()
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct JKNHGCHGGNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public Queue<string> queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private JAMAHJFDJLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public OKBDDBAHFOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x80C2F70", Offset = "0x80C1D70", VA = "0x1880C2F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x80C34E0", Offset = "0x80C22E0", VA = "0x1880C34E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly KBGKIIMABID MHNDOKGAENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly NDACHOEMGJO NGGICBINKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly HashSet<string> NICOCMNPCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly CPEKFABEFOA KPPDJDDHHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly List<ONCEPGBFGJP> FMDCJCPBODL;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static Queue<string> HDBCHMNJNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly CancellationTokenSource INHPEDONMMJ;

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x80D0E10", Offset = "0x80CFC10", VA = "0x1880D0E10")]
	public OKBDDBAHFOE(KBGKIIMABID HMFBMLEKMPE, NDACHOEMGJO HAODKLEGGDP, CPEKFABEFOA PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x80D0370", Offset = "0x80CF170", VA = "0x1880D0370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x80D0190", Offset = "0x80CEF90", VA = "0x1880D0190")]
	public void CLHOJENGEJH(IEnumerable<string> GHFGMPAODBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x80D0570", Offset = "0x80CF370", VA = "0x1880D0570")]
	private void MEOGCPLLEIH(ConversationItemDTO IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x80D08F0", Offset = "0x80CF6F0", VA = "0x1880D08F0")]
	private void MFMLMNHAKFO(IEnumerable<string?> DGCLDHKLDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x80D0450", Offset = "0x80CF250", VA = "0x1880D0450")]
	[AsyncStateMachine(typeof(JKNHGCHGGNL))]
	private Task HABMNGIGBBA(Queue<string> CFBEEIBDCID, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class KPHKKHCNCEI : NDACHOEMGJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class AHMDNBNOBIM
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public ConversationItemDTO ABJADGGNFCH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool POMHHIHKLCG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xA93B80", Offset = "0xA92980", VA = "0x180A93B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x15D98B0", Offset = "0x15D86B0", VA = "0x1815D98B0")]
		public AHMDNBNOBIM(ConversationItemDTO IIHDHELGAFA, bool DFHDOCGKEFB = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class AAELHCHCMBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AAELHCHCMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x80D23D0", Offset = "0x80D11D0", VA = "0x1880D23D0")]
		internal bool PADBAAIDACN(AHMDNBNOBIM c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x80D2390", Offset = "0x80D1190", VA = "0x1880D2390")]
		internal bool AJECDLKAANC(AHMDNBNOBIM c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LHOAAEIJPCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LHOAAEIJPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x80D60A0", Offset = "0x80D4EA0", VA = "0x1880D60A0")]
		internal bool GILNOCEKGJL(AHMDNBNOBIM c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class CDDIKCAHAMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CDDIKCAHAMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x80D2390", Offset = "0x80D1190", VA = "0x1880D2390")]
		internal bool ODHGDIBBHJF(AHMDNBNOBIM c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class GINNHBIFDLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public ConversationItemDTO item;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GINNHBIFDLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x80D4270", Offset = "0x80D3070", VA = "0x1880D4270")]
		internal bool DIHKPKNOFGJ(AHMDNBNOBIM c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BCAHPGCIJPA : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private ConversationItemDTO item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public ConversationItemDTO <>3__item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public KPHKKHCNCEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private GINNHBIFDLI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<ConversationItemContentDTO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public BCAHPGCIJPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x80D2D70", Offset = "0x80D1B70", VA = "0x1880D2D70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x80D2420", Offset = "0x80D1220", VA = "0x1880D2420", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x80D2C10", Offset = "0x80D1A10", VA = "0x1880D2C10")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x80D2D20", Offset = "0x80D1B20", VA = "0x1880D2D20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x80D2C60", Offset = "0x80D1A60", VA = "0x1880D2C60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x80D2C60", Offset = "0x80D1A60", VA = "0x1880D2C60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LOHIFPGKHFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public string messageId;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LOHIFPGKHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x21CD720", Offset = "0x21CC520", VA = "0x1821CD720")]
		internal bool AKHONDPKPNF(ConversationItemDTO m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly NKBGGJCHNAF MHNDOKGAENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly MKGKDIAGEPI NDMICGBJDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly NLFFFLJOFLP IMLDECNOJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly List<AHMDNBNOBIM> IDLGNDHEHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly List<string> FMDCJCPBODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly List<ConversationItemDTO> AGFPDNGBLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private string? PNAKBEFJJCM;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GBCEOPMAPJH<ConversationItemDTO> MEOGCPLLEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IReadOnlyList<string> AAABHGPKOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IReadOnlyList<ConversationItemDTO> CDHJKLDDHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x80C72A0", Offset = "0x80C60A0", VA = "0x1880C72A0")]
	public KPHKKHCNCEI(NKBGGJCHNAF HMFBMLEKMPE, IReadOnlyCollection<string> BEEBDEFDEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x80C6220", Offset = "0x80C5020", VA = "0x1880C6220", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x80C6C30", Offset = "0x80C5A30", VA = "0x1880C6C30")]
	public List<string> MJFDOHEBNBL(bool ANJKLEBLIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x80C6E20", Offset = "0x80C5C20", VA = "0x1880C6E20")]
	private void OKOIEHDCCDA(ConversationItemCreatedEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x80C6980", Offset = "0x80C5780", VA = "0x1880C6980")]
	private void MBEILGNHNAI(ResponseEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x80C67C0", Offset = "0x80C55C0", VA = "0x1880C67C0")]
	private void IAOJMGGEJAD(ConversationItemInputAudioTranscriptionCompletedEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x80C64A0", Offset = "0x80C52A0", VA = "0x1880C64A0")]
	private void EMFFONOAECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x80C6190", Offset = "0x80C4F90", VA = "0x1880C6190", Slot = "6")]
	[IteratorStateMachine(typeof(BCAHPGCIJPA))]
	public IEnumerable<string> BIFGGPNAMMA(ConversationItemDTO IIHDHELGAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x80C66E0", Offset = "0x80C54E0", VA = "0x1880C66E0", Slot = "7")]
	public void HOEFBKBMCGE(string MJIAGEIMKKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class HKMAOKGOGME : CLEFGJDCPFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct MFMFKECCLPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public IReadOnlyCollection<string> conversation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public HKMAOKGOGME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x80D65C0", Offset = "0x80D53C0", VA = "0x1880D65C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x80D6A50", Offset = "0x80D5850", VA = "0x1880D6A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly NKBGGJCHNAF MHNDOKGAENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly string ENAHCHGAKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly int FLGHCGHOPHI;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB9A0", Offset = "0x5FBA7A0", VA = "0x185FBB9A0")]
	public HKMAOKGOGME(NKBGGJCHNAF HMFBMLEKMPE, string ABMOFDCBOCP, int LLEBHEBKMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x80D4500", Offset = "0x80D3300", VA = "0x1880D4500", Slot = "4")]
	[AsyncStateMachine(typeof(MFMFKECCLPC))]
	public Task KBJDPMFGKAL(IReadOnlyCollection<string> DJIBBNCGOKE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class NEBJKKJIHNP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Type BJJCLMDPNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xB1E590", Offset = "0xB1D390", VA = "0x180B1E590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public string ECJCBHAEDLO
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE60", Offset = "0xA9DC60", VA = "0x180A9EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x80D6AB0", Offset = "0x80D58B0", VA = "0x1880D6AB0")]
	public NEBJKKJIHNP(Type ABOPAODGHHJ, string FFEGLLCDOHA, Exception HDEBIKIKFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class CJFHIMALPIM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct OFPIEDMGHLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public string args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public CJFHIMALPIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private Dictionary<FHGIBBKKCIF, BCDDDKAACNE?>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private TaskAwaiter<string?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x80D6DB0", Offset = "0x80D5BB0", VA = "0x1880D6DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x80D7AC0", Offset = "0x80D68C0", VA = "0x1880D7AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly ALMLLDBPKBM ICNEBIIBIEE;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly List<MCHPDCIGIKJ> PCDLFMONOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly Dictionary<FHGIBBKKCIF, BCDDDKAACNE?> NKNJIMKLHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public readonly FLNBPEKPFIH<FHGIBBKKCIF, BCDDDKAACNE?> ADIHPDOEIJL;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x80D3AD0", Offset = "0x80D28D0", VA = "0x1880D3AD0")]
	static CJFHIMALPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x80D32C0", Offset = "0x80D20C0", VA = "0x1880D32C0")]
	public void GLEADCEEENG(params FHGIBBKKCIF[] BNFJIBCOMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x80D3570", Offset = "0x80D2370", VA = "0x1880D3570")]
	public bool JGIJOLPNBDD(FHGIBBKKCIF BKIIONCAMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x80D35D0", Offset = "0x80D23D0", VA = "0x1880D35D0")]
	public void KNCGKPJPBFI(params FHGIBBKKCIF[] BNFJIBCOMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x80D3230", Offset = "0x80D2030", VA = "0x1880D3230")]
	public void GJFIMEIAFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x80D30D0", Offset = "0x80D1ED0", VA = "0x1880D30D0")]
	[AsyncStateMachine(typeof(OFPIEDMGHLG))]
	public Task<string> EFCMPHHNJGO(string PFLDDMDPCBI, string NPIEBNDMCBK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x80D38E0", Offset = "0x80D26E0", VA = "0x1880D38E0")]
	public List<ToolDTO> OMFALOCEMFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x80D2E00", Offset = "0x80D1C00", VA = "0x1880D2E00")]
	private static BCDDDKAACNE DOLKCHKFDIK(FHGIBBKKCIF BKIIONCAMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x80D3E00", Offset = "0x80D2C00", VA = "0x1880D3E00")]
	public CJFHIMALPIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class HHNDBONGADF
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static JsonSerializerSettings NLHMEBOLOCE;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x80D42C0", Offset = "0x80D30C0", VA = "0x1880D42C0")]
	static HHNDBONGADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal class IKFBBNDKHGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class KGFGDOCGKHP
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public ConversationItemDTO ABJADGGNFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool POMHHIHKLCG
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA93B80", Offset = "0xA92980", VA = "0x180A93B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x15D98B0", Offset = "0x15D86B0", VA = "0x1815D98B0")]
		public KGFGDOCGKHP(ConversationItemDTO IIHDHELGAFA, bool DFHDOCGKEFB = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private abstract class COOMANKMGCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private readonly StringBuilder NNABGJIGEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private readonly TimeSpan FAFGLBOKCAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private DateTime LLJPKIHBPIC;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x80D4070", Offset = "0x80D2E70", VA = "0x1880D4070")]
		public COOMANKMGCD(TimeSpan EEECANNCKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x80D4020", Offset = "0x80D2E20", VA = "0x1880D4020")]
		public void GDJHBLAJMFH(string PBFGDMACHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x80D3EE0", Offset = "0x80D2CE0", VA = "0x1880D3EE0")]
		public void ANMHOMAPMKO(bool PPPGPLMAHNI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void JKPMBEPKEFG(string IMIIGPOLNDC);
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class LONOGCBNGJI : COOMANKMGCD
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly TimeSpan FFLKEMHKPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly string LNOKHFLJPBC;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x80D61C0", Offset = "0x80D4FC0", VA = "0x1880D61C0")]
		public LONOGCBNGJI(string GLIMJFLPLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x80D60E0", Offset = "0x80D4EE0", VA = "0x1880D60E0", Slot = "4")]
		protected override void JKPMBEPKEFG(string IMIIGPOLNDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class MABJBFEHFFE : COOMANKMGCD
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private static readonly TimeSpan FFLKEMHKPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private readonly KADEKFHNILF MBGAMNDKKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private readonly MKGKDIAGEPI NDMICGBJDIN;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x80D6520", Offset = "0x80D5320", VA = "0x1880D6520")]
		public MABJBFEHFFE(KADEKFHNILF BAOIGCEOOCA, MKGKDIAGEPI JLIHNHOJGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x80D6250", Offset = "0x80D5050", VA = "0x1880D6250", Slot = "4")]
		protected override void JKPMBEPKEFG(string IMIIGPOLNDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class EPOHJNCAPPK : COOMANKMGCD
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private static readonly TimeSpan FFLKEMHKPDG;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x80D4210", Offset = "0x80D3010", VA = "0x1880D4210")]
		public EPOHJNCAPPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x80D4120", Offset = "0x80D2F20", VA = "0x1880D4120", Slot = "4")]
		protected override void JKPMBEPKEFG(string IMIIGPOLNDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class DGDFMCEOEGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public ConversationItemCreatedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DGDFMCEOEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x80D2390", Offset = "0x80D1190", VA = "0x1880D2390")]
		internal bool PADBAAIDACN(KGFGDOCGKHP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class KCCFIDEECCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public ConversationItemDTO conversationItem;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KCCFIDEECCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x80D60A0", Offset = "0x80D4EA0", VA = "0x1880D60A0")]
		internal bool GILNOCEKGJL(KGFGDOCGKHP c)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class JJIPDLOAHFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public ConversationItemInputAudioTranscriptionCompletedEventDTO ev;

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JJIPDLOAHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x80D2390", Offset = "0x80D1190", VA = "0x1880D2390")]
		internal bool ODHGDIBBHJF(KGFGDOCGKHP c)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct OEGNLEJEOAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public IKFBBNDKHGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x80D6B80", Offset = "0x80D5980", VA = "0x1880D6B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x80D6D50", Offset = "0x80D5B50", VA = "0x1880D6D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly TimeSpan FFLKEMHKPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly NKBGGJCHNAF MHNDOKGAENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private readonly MKGKDIAGEPI NDMICGBJDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly KADEKFHNILF MBGAMNDKKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly NLFFFLJOFLP IMLDECNOJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly List<COOMANKMGCD> NCCDBNADCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly List<KGFGDOCGKHP> IDLGNDHEHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private string? PNAKBEFJJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private CancellationTokenSource? LHADIMJFBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private Task? IHIGMGGJPPP;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x80D5980", Offset = "0x80D4780", VA = "0x1880D5980")]
	public IKFBBNDKHGC(NKBGGJCHNAF HMFBMLEKMPE, KADEKFHNILF BAOIGCEOOCA, bool KHJJKMPIKNG, bool MOLDABDMBNJ, string? AFJCMPHDNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x80D4740", Offset = "0x80D3540", VA = "0x1880D4740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x80D5420", Offset = "0x80D4220", VA = "0x1880D5420")]
	private void OKOIEHDCCDA(ConversationItemCreatedEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x80D5170", Offset = "0x80D3F70", VA = "0x1880D5170")]
	private void MBEILGNHNAI(ResponseEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x80D4E90", Offset = "0x80D3C90", VA = "0x1880D4E90")]
	private void IAOJMGGEJAD(ConversationItemInputAudioTranscriptionCompletedEventDTO DHGJJBIPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x80D5050", Offset = "0x80D3E50", VA = "0x1880D5050")]
	private void IHJOPMHEMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x80D4A50", Offset = "0x80D3850", VA = "0x1880D4A50")]
	private void FOHHBONEEBH(ConversationItemDTO IIHDHELGAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x80D4CE0", Offset = "0x80D3AE0", VA = "0x1880D4CE0")]
	private void GDJHBLAJMFH(string PBFGDMACHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x80D5820", Offset = "0x80D4620", VA = "0x1880D5820")]
	[AsyncStateMachine(typeof(OEGNLEJEOAB))]
	private Task OODJHEKFPAF(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x80D4620", Offset = "0x80D3420", VA = "0x1880D4620")]
	private void ANOAAMJKLEB(bool PPPGPLMAHNI = false)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class EDFFLPDHNEN
{
	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EDFFLPDHNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7550F60", Offset = "0x754FD60", VA = "0x187550F60")]
	public static string IAPJDHPINOL(byte[] JBCIGBMHOPF, byte[] DKAEMMPPGGA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
