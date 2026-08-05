using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E29C80", Offset = "0x6E29080", VA = "0x186E29C80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DPOOKEMFOPA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E21530", Offset = "0x6E20930", VA = "0x186E21530")]
	public static string ELKHKOCNMHE(this Encoding LGFMNEJKJAP, [In] ReadOnlySequence<byte> HFBIMFCNCFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CFAE30", Offset = "0x2CFA230", VA = "0x182CFAE30")]
	private static void LIDDPNNENHK<T>(this ReadOnlySequence<T> ABPICDIBEMO, [Out] ReadOnlySpan<T> OKAKBKLHGED, [Out] SequencePosition EEPPBMFKKMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class BBDKBJECBJA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F8E0", Offset = "0x6E1ECE0", VA = "0x186E1F8E0")]
	public BBDKBJECBJA(bool JBIOPKDEIOB, string MCAPDNBDNBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NKMPMNLPFOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ENEHJJIIJNE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EHNHNOBGAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGDCFDCIDKK(string PBFBBOFLBNL, double PFKKDHPJFEH, [Optional] string? HFBCBBGBJKN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class POICDDNDICB<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> PKJDPFOAHIH(CancellationToken GBOOEEMCFEA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CJBOHBDOCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public POICDDNDICB<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public PKJDPFOAHIH taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x563B840", Offset = "0x563AC40", VA = "0x18563B840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x563C900", Offset = "0x563BD00", VA = "0x18563C900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource JGOKKKADFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? KHMEPFOGJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? CKDICFBLFFF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C020", Offset = "0x4B4B420", VA = "0x184B4C020")]
	[AsyncStateMachine(typeof(POICDDNDICB<>.CJBOHBDOCFD))]
	public Task<TResult> IHJNDAMPNMC(PKJDPFOAHIH FAOIONLDIKC, [Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B4BFB0", Offset = "0x4B4B3B0", VA = "0x184B4BFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B4C160", Offset = "0x4B4B560", VA = "0x184B4C160")]
	public POICDDNDICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class CFFDFFFMOAF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> COKCDDPFHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T FDJCHKNOIDG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3F4F750", Offset = "0x3F4EB50", VA = "0x183F4F750")]
	public CFFDFFFMOAF([In] T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5550580", Offset = "0x554F980", VA = "0x185550580", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5550680", Offset = "0x554FA80", VA = "0x185550680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x55506D0", Offset = "0x554FAD0", VA = "0x1855506D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class OLMAPKMECPM
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2C470C0", Offset = "0x2C464C0", VA = "0x182C470C0")]
	public static CFFDFFFMOAF<T> GIIIFAJNKEL<T>([In] T PFKKDHPJFEH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HKKEBEDDFNN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E237B0", Offset = "0x6E22BB0", VA = "0x186E237B0")]
	public static void MKEHPPODABN(this CancellationTokenSource JGOKKKADFHH, bool JEOBGGJADKO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FOABBCIMGMG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
	public FOABBCIMGMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class ICFJKDIIEFO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
	public ICFJKDIIEFO(string MDMOKACGJME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LPPMIEPMDMD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8F60", Offset = "0x2FA8360", VA = "0x182FA8F60")]
	public static CFPHNJHCPKH KMEGNNICHLD<T>()
	{
		return default(CFPHNJHCPKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8C90", Offset = "0x2FA8090", VA = "0x182FA8C90")]
	public static CFPHNJHCPKH IAJAJHKBKPC<T>([CallerMemberName] string ACDGEPBIBHJ = "") where T : notnull
	{
		return default(CFPHNJHCPKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8EE0", Offset = "0x2FA82E0", VA = "0x182FA8EE0")]
	public static CFPHNJHCPKH KMEGNNICHLD<T>(this T KGHCPOJBNFM) where T : notnull
	{
		return default(CFPHNJHCPKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8AF0", Offset = "0x2FA7EF0", VA = "0x182FA8AF0")]
	public static CFPHNJHCPKH BHMLOGNCKAA<T>(this T KGHCPOJBNFM, [CallerMemberName] string ACDGEPBIBHJ = "") where T : notnull
	{
		return default(CFPHNJHCPKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8D30", Offset = "0x2FA8130", VA = "0x182FA8D30")]
	public static CFPHNJHCPKH IAJAJHKBKPC<T>(this T EAFEIEDNLNL, [CallerMemberName] string ACDGEPBIBHJ = "") where T : notnull
	{
		return default(CFPHNJHCPKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E26B80", Offset = "0x6E25F80", VA = "0x186E26B80")]
	public static CFPHNJHCPKH IAJAJHKBKPC(string ACIMEBFLEGD, [CallerMemberName] string ACDGEPBIBHJ = "")
	{
		return default(CFPHNJHCPKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E26C00", Offset = "0x6E26000", VA = "0x186E26C00")]
	public static string PHBANGBKKLI(this object EAFEIEDNLNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool JFNHHBJIOIE();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FOABBCIMGMG]
public delegate long KPPNDFPANDA();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class AOHGIHHNKJH
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static JJANGMIAPKA BGBKEHDHJHB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JJANGMIAPKA AONPKFLIFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F6B0", Offset = "0x6E1EAB0", VA = "0x186E1F6B0")]
		get
		{
			return default(JJANGMIAPKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IOMAAPBMLCO DGIEFIPKMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F570", Offset = "0x6E1E970", VA = "0x186E1F570")]
		get
		{
			return default(IOMAAPBMLCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DEPHANMOGLG EOMNIHBEFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EFF0", Offset = "0x6E1E3F0", VA = "0x186E1EFF0")]
		get
		{
			return default(DEPHANMOGLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool JEJAALDPLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F430", Offset = "0x6E1E830", VA = "0x186E1F430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F0E0", Offset = "0x6E1E4E0", VA = "0x186E1F0E0")]
	public static void CNKDFENKNOL([In] JJANGMIAPKA KKGIIONBBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F4A0", Offset = "0x6E1E8A0", VA = "0x186E1F4A0")]
	public static void JEHEHFEFLHD(string NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F290", Offset = "0x6E1E690", VA = "0x186E1F290")]
	public static void DGGLCCHCDIG(string NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x35D4910", Offset = "0x35D3D10", VA = "0x1835D4910")]
	public static void DGGLCCHCDIG<T>(T IDJEKAFFOBD, LBMNKKEMHDM<T> NFKMLKNHFEM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F040", Offset = "0x6E1E440", VA = "0x186E1F040")]
	public static void APBIIKEIEAI(Exception BDBOMDMKJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F5C0", Offset = "0x6E1E9C0", VA = "0x186E1F5C0")]
	public static void KHAIABHLJMC(string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F640", Offset = "0x6E1EA40", VA = "0x186E1F640")]
	public static void LOKNAPMEFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F7A0", Offset = "0x6E1EBA0", VA = "0x186E1F7A0")]
	public static string PHBANGBKKLI(object FAKGLFFOLFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EF80", Offset = "0x6E1E380", VA = "0x186E1EF80")]
	public static long AMIALCEABPM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F700", Offset = "0x6E1EB00", VA = "0x186E1F700")]
	public static bool PCDNJHBFBBF(bool NAFCJPGDPLL, string NFKMLKNHFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F360", Offset = "0x6E1E760", VA = "0x186E1F360")]
	public static double ECLMBBAGPHO()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct JJANGMIAPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly IOMAAPBMLCO DGIEFIPKMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DEPHANMOGLG EOMNIHBEFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly NNFLKDCGHBG CMKGABPALIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly KPPNDFPANDA BFMJBFDMANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly NPFJILLMGMJ HKCPEDDCIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly JFNHHBJIOIE DMCAIEFIIFN;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NNFLKDCGHBG IGHFFCPFAGO;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly KPPNDFPANDA MPODBHBJBND;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly NPFJILLMGMJ EIJMBGGPLJE;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly JFNHHBJIOIE LCCPBKIBEEK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly JJANGMIAPKA HABKGKOFNKB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FKFNLLHBIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E249E0", Offset = "0x6E23DE0", VA = "0x186E249E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E25270", Offset = "0x6E24670", VA = "0x186E25270")]
	public JJANGMIAPKA([In] IOMAAPBMLCO BJPBIBIMFCP, [In] DEPHANMOGLG HJANJAHEOKH, NNFLKDCGHBG AOLKFFLJMPC, KPPNDFPANDA BBLLKBFGFAI, NPFJILLMGMJ BEGPKNHKHKG, JFNHHBJIOIE OAAAJDAJENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E249A0", Offset = "0x6E23DA0", VA = "0x186E249A0")]
	private static string NHDHECIOEFL(object FAKGLFFOLFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40")]
	private static long KPPGBNOKJOE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
	private static string MKMJJKHGECB(string BBLEEPEBKMO, string? PKIPCCDIHFG, bool IPECANLIAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0")]
	private static bool OKJGBANBBDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E24890", Offset = "0x6E23C90", VA = "0x186E24890")]
	private static JJANGMIAPKA DFKKFCHNGHB()
	{
		return default(JJANGMIAPKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KINJHPNBDCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KBPBACJOCMI IGCCDNCCHKD();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KBPBACJOCMI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool EBKHGCJIJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIBBLPNLAHG();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FADLILBKPAO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NIPJNKKLBEI([In] T OGKFFDCECEL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void KIKEDDIIIAB<T>([In] T IDJEKAFFOBD);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct HNIOEALEKLD<T> : IEquatable<HNIOEALEKLD<T>>, FADLILBKPAO<HNIOEALEKLD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T FDJCHKNOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int DIJEOHGLGIA;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2297B60", Offset = "0x2296F60", VA = "0x182297B60")]
	public HNIOEALEKLD([In] T PFKKDHPJFEH, int OBFJPFHENMC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4164D30", Offset = "0x4164130", VA = "0x184164D30")]
	public static bool LIIBJCIOAJF([In] HNIOEALEKLD<T> CGCHNDGEIJH, [In] HNIOEALEKLD<T> LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4164330", Offset = "0x4163730", VA = "0x184164330", Slot = "4")]
	public bool Equals(HNIOEALEKLD<T> OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4000900", Offset = "0x3FFFD00", VA = "0x184000900", Slot = "0")]
	public override bool Equals(object OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x41652E0", Offset = "0x41646E0", VA = "0x1841652E0")]
	public bool NIPJNKKLBEI([In] HNIOEALEKLD<T> OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41644A0", Offset = "0x41638A0", VA = "0x1841644A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4165C10", Offset = "0x4165010", VA = "0x184165C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4165460", Offset = "0x4164860", VA = "0x184165460")]
	public void NKENCEMDNGD([Out] T PFKKDHPJFEH, [Out] int OBFJPFHENMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41648F0", Offset = "0x4163CF0", VA = "0x1841648F0")]
	public (T, int) KIHLJCKLJEM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4165290", Offset = "0x4164690", VA = "0x184165290", Slot = "5")]
	private bool MJKPMPOHNPI([In] HNIOEALEKLD<T> OGKFFDCECEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JCICALMAADG
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2F04700", Offset = "0x2F03B00", VA = "0x182F04700")]
	public static HNIOEALEKLD<T> GIIIFAJNKEL<T>([In] T PFKKDHPJFEH, int OBFJPFHENMC) where T : notnull
	{
		return default(HNIOEALEKLD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ODNCJFFOBAI
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3087610", Offset = "0x3086A10", VA = "0x183087610")]
	public static bool NIPJNKKLBEI<T, U>([In] T EAFEIEDNLNL, [In] U FAKGLFFOLFI) where T : notnull, FADLILBKPAO<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult OHFFKAOOHLB<T, out TResult>([In] T IDJEKAFFOBD);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HJIJLIPJCIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan GJNLPLMHKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? DIHPGKEOOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEDCOPEMPIE();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPAMKENPGNI();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFENALFAFOO();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct IOMAAPBMLCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly NOKCOLPBILG GPIIJNIFMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly NHFPPJMIAHM KFHAFAOLKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly NOKCOLPBILG JPJJIKJJIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly NHFPPJMIAHM AGPPNLDCBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly NOKCOLPBILG IIHBJPLBHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly NHFPPJMIAHM OHMMKALEOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly FOFAFMAIJOE BKKPEACPNJC;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly NOKCOLPBILG HIDDPAPIMDM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly NHFPPJMIAHM GMJJNPFANEJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly NOKCOLPBILG HKFLKIGFIIH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly NHFPPJMIAHM FMCLLKJMDBD;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly NOKCOLPBILG IEDMMIFLCBK;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly NHFPPJMIAHM MEJICLHJOCG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly FOFAFMAIJOE AGFKHPICMAJ;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly IOMAAPBMLCO HABKGKOFNKB;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly NOKCOLPBILG KKNGLBPCDCD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FKFNLLHBIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E23F90", Offset = "0x6E23390", VA = "0x186E23F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x9266F0", Offset = "0x925AF0", VA = "0x1809266F0")]
	public IOMAAPBMLCO(NOKCOLPBILG DMHHPPJEKPG, NHFPPJMIAHM KOFEBKOBFBP, NOKCOLPBILG IHPIPKIGFAA, NHFPPJMIAHM LKOOHNEOPOA, NOKCOLPBILG EFNJJHJLPAH, NHFPPJMIAHM KHIGDACINOI, FOFAFMAIJOE HBEBIOFHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0")]
	private static bool MDNGKOADHPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void NELMBAJIGIE(string NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0")]
	private static bool FDOFMFMDMJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void OOBIOCEJMKL(string NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0")]
	private static bool PHOBKHDOLHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void GMCMMLEJLCE(string NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void AHAJJPEBAOC(Exception BDBOMDMKJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E23C90", Offset = "0x6E23090", VA = "0x186E23C90")]
	private static IOMAAPBMLCO DFKKFCHNGHB()
	{
		return default(IOMAAPBMLCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510")]
	private static bool ODJBLECGCAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E23F20", Offset = "0x6E23320", VA = "0x186E23F20")]
	public void JEHEHFEFLHD(object NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E23EB0", Offset = "0x6E232B0", VA = "0x186E23EB0")]
	public void DGGLCCHCDIG(object NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x930870", Offset = "0x92FC70", VA = "0x180930870")]
	public void APBIIKEIEAI(Exception BDBOMDMKJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E23DD0", Offset = "0x6E231D0", VA = "0x186E23DD0")]
	public void DGGLCCHCDIG(EBOOIHPDMID NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0D30", Offset = "0x2EF0130", VA = "0x182EF0D30")]
	public void DGGLCCHCDIG<T>(T IDJEKAFFOBD, LBMNKKEMHDM<T> NFKMLKNHFEM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0ED0", Offset = "0x2EF02D0", VA = "0x182EF0ED0")]
	public void JEHEHFEFLHD<T>([In] T IDJEKAFFOBD, ABOIPPPDKPM<T> NFKMLKNHFEM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0B90", Offset = "0x2EEFF90", VA = "0x182EF0B90")]
	public void DGGLCCHCDIG<T>([In] T IDJEKAFFOBD, ABOIPPPDKPM<T> NFKMLKNHFEM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E24190", Offset = "0x6E23590", VA = "0x186E24190")]
	public bool PCDNJHBFBBF(bool NAFCJPGDPLL, string NFKMLKNHFEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct CFPHNJHCPKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string FDJCHKNOIDG;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	public CFPHNJHCPKH(string PFKKDHPJFEH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270")]
	public static string NMFIIIJGOAJ([In] CFPHNJHCPKH EAFEIEDNLNL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xCC0DC0", Offset = "0xCC01C0", VA = "0x180CC0DC0")]
	public static CFPHNJHCPKH NMFIIIJGOAJ(string OGKFFDCECEL)
	{
		return default(CFPHNJHCPKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E20AD0", Offset = "0x6E1FED0", VA = "0x186E20AD0")]
	public string DHIJGOLDGBP(string BHGJJKCLFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E20B20", Offset = "0x6E1FF20", VA = "0x186E20B20")]
	public string PGIBINPNAKL(object DAKJDJPEGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct FHMPKELNMGN : IEquatable<FHMPKELNMGN>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "4")]
	public bool Equals(FHMPKELNMGN OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E22770", Offset = "0x6E21B70", VA = "0x186E22770", Slot = "0")]
	public override bool Equals(object OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E227C0", Offset = "0x6E21BC0", VA = "0x186E227C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E227D0", Offset = "0x6E21BD0", VA = "0x186E227D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[GDCDIKCGJKC("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct BLOKLLOGIFH<T> : IEquatable<BLOKLLOGIFH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T FDJCHKNOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool EBNFCFCJFDD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LFHHAFMJALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5255E00", Offset = "0x5255200", VA = "0x185255E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5257AD0", Offset = "0x5256ED0", VA = "0x185257AD0")]
	public BLOKLLOGIFH([In] T PFKKDHPJFEH, bool IGPBOADCNFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5256EC0", Offset = "0x52562C0", VA = "0x185256EC0")]
	public static bool LIIBJCIOAJF([In] BLOKLLOGIFH<T> CGCHNDGEIJH, [In] BLOKLLOGIFH<T> LEGMFFDGEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4164330", Offset = "0x4163730", VA = "0x184164330", Slot = "4")]
	public bool Equals(BLOKLLOGIFH<T> OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5256210", Offset = "0x5255610", VA = "0x185256210", Slot = "0")]
	public override bool Equals(object OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5256C30", Offset = "0x5256030", VA = "0x185256C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5257570", Offset = "0x5256970", VA = "0x185257570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class POCKNADLHKO
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x30A6E70", Offset = "0x30A6270", VA = "0x1830A6E70")]
	public static BLOKLLOGIFH<T> JOADDGIDGAJ<T>([In] T PFKKDHPJFEH) where T : notnull
	{
		return default(BLOKLLOGIFH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30A6CD0", Offset = "0x30A60D0", VA = "0x1830A6CD0")]
	public static BLOKLLOGIFH<T?> GJDFGOMAPIG<T>()
	{
		return default(BLOKLLOGIFH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x30A6BE0", Offset = "0x30A5FE0", VA = "0x1830A6BE0")]
	public static bool EIKOIPKPOLG<T>([In] this BLOKLLOGIFH<T> OEGCNJJKBEF, [Out][NotNullWhen(true)] T PFKKDHPJFEH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x30A6F40", Offset = "0x30A6340", VA = "0x1830A6F40")]
	public static T? LDNHGLOJGFD<T>([In] this BLOKLLOGIFH<T> OEGCNJJKBEF, T? POOOEFHFGKB)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct DEPHANMOGLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr KHAIABHLJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr LOKNAPMEFEF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr MEHAPHJPMIB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr ABDAIGMIKDH;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly DEPHANMOGLG HABKGKOFNKB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FKFNLLHBIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E21300", Offset = "0x6E20700", VA = "0x186E21300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
	public DEPHANMOGLG(IntPtr OBHMEDDBENJ, IntPtr BDHJGLDAKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void EAGPFNBBAFB(string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void IKKECJMMFMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E21270", Offset = "0x6E20670", VA = "0x186E21270")]
	private static DEPHANMOGLG DFKKFCHNGHB()
	{
		return default(DEPHANMOGLG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MFGJFAOFLAJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr MEPLKHCIMFB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	private MFGJFAOFLAJ(IntPtr BDHJGLDAKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6E28FF0", Offset = "0x6E283F0", VA = "0x186E28FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E29010", Offset = "0x6E28410", VA = "0x186E29010")]
	public static MFGJFAOFLAJ GIIIFAJNKEL(string ACDGEPBIBHJ)
	{
		return default(MFGJFAOFLAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2271850", Offset = "0x2270C50", VA = "0x182271850")]
	public static MFGJFAOFLAJ GIIIFAJNKEL([In] DEPHANMOGLG HJANJAHEOKH, string ACDGEPBIBHJ)
	{
		return default(MFGJFAOFLAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2272090", Offset = "0x2271490", VA = "0x182272090")]
	public static MFGJFAOFLAJ GIIIFAJNKEL([In] DEPHANMOGLG HJANJAHEOKH, Func<string> ACDGEPBIBHJ)
	{
		return default(MFGJFAOFLAJ);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MAFEODDGACJ
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool MIPFAFNHPGL<in TInput, TResult>(TInput CMILLOOAKEN, [Out] TResult HCMJFDLGOJF);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class HMOAPEHFGGD : KINJHPNBDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class KIMOOKIDCFA : KBPBACJOCMI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly KIMOOKIDCFA GHDNHBBFDEB;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool EBKHGCJIJHE
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x6E259F0", Offset = "0x6E24DF0", VA = "0x186E259F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6E25A50", Offset = "0x6E24E50", VA = "0x186E25A50", Slot = "6")]
			public void OnCompleted(Action BFKGOPJEEDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			public void NIBBLPNLAHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public KIMOOKIDCFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly HMOAPEHFGGD GHDNHBBFDEB;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		private HMOAPEHFGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E237E0", Offset = "0x6E22BE0", VA = "0x186E237E0", Slot = "4")]
		public KBPBACJOCMI IGCCDNCCHKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class MFDBMOFGGGD : KINJHPNBDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class EOEPPMPLLBC : KBPBACJOCMI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly EOEPPMPLLBC GHDNHBBFDEB;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool EBKHGCJIJHE
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x6E22330", Offset = "0x6E21730", VA = "0x186E22330", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6E22350", Offset = "0x6E21750", VA = "0x186E22350", Slot = "6")]
			public void OnCompleted(Action BFKGOPJEEDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			public void NIBBLPNLAHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public EOEPPMPLLBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly MFDBMOFGGGD GHDNHBBFDEB;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		private MFDBMOFGGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E28F20", Offset = "0x6E28320", VA = "0x186E28F20", Slot = "4")]
		public KBPBACJOCMI IGCCDNCCHKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PBJMELPHBIN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public PBJMELPHBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x45EB2C0", Offset = "0x45EA6C0", VA = "0x1845EB2C0")]
		internal void BEAOLIDPAMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NOJDBBLFCAF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public NOJDBBLFCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x48CF8B0", Offset = "0x48CECB0", VA = "0x1848CF8B0")]
		internal void LNEGABOJGHO(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JPDJAOKKJHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E256B0", Offset = "0x6E24AB0", VA = "0x186E256B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NECKLKJBDKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6E29A70", Offset = "0x6E28E70", VA = "0x186E29A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct JCDPFJNHCKC<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x43D8CE0", Offset = "0x43D80E0", VA = "0x1843D8CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x43D8E50", Offset = "0x43D8250", VA = "0x1843D8E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct LKDOJGONEBJ<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x46711A0", Offset = "0x46705A0", VA = "0x1846711A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x46719F0", Offset = "0x4670DF0", VA = "0x1846719F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BKKEFNCDCGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E202A0", Offset = "0x6E1F6A0", VA = "0x186E202A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6E204A0", Offset = "0x6E1F8A0", VA = "0x186E204A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class LFEOGLACLHJ<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public LFEOGLACLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x45EB2C0", Offset = "0x45EA6C0", VA = "0x1845EB2C0")]
		internal void CFFMKEGGJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x45EB320", Offset = "0x45EA720", VA = "0x1845EB320")]
		internal void KOBAIJIEHGC(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct JBKJBPICFAH<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public MIPFAFNHPGL<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x43D19A0", Offset = "0x43D0DA0", VA = "0x1843D19A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x43D20B0", Offset = "0x43D14B0", VA = "0x1843D20B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LMCJDGMAHEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E26330", Offset = "0x6E25730", VA = "0x186E26330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E26B20", Offset = "0x6E25F20", VA = "0x186E26B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BIGKPNJBCGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6E1FD00", Offset = "0x6E1F100", VA = "0x186E1FD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E20240", Offset = "0x6E1F640", VA = "0x186E20240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EBFCKKFOMEP<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3B665D0", Offset = "0x3B659D0", VA = "0x183B665D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3B66DC0", Offset = "0x3B661C0", VA = "0x183B66DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class GIEGGMAFDEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<FHMPKELNMGN> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public GIEGGMAFDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6E22800", Offset = "0x6E21C00", VA = "0x186E22800")]
		internal void PANMGDDDFCF(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JIBFAKOKLMK<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x442CCC0", Offset = "0x442C0C0", VA = "0x18442CCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x38B8BC0", Offset = "0x38B7FC0", VA = "0x1838B8BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct FHNEBNNILHM<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DDD0", Offset = "0x3F3D1D0", VA = "0x183F3DDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E4E0", Offset = "0x3F3D8E0", VA = "0x183F3E4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct OEKMFIPCAOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E29D00", Offset = "0x6E29100", VA = "0x186E29D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6E29EE0", Offset = "0x6E292E0", VA = "0x186E29EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct LLHFPFFEOLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6E25F60", Offset = "0x6E25360", VA = "0x186E25F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E262D0", Offset = "0x6E256D0", VA = "0x186E262D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct FADDDJCIBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E22420", Offset = "0x6E21820", VA = "0x186E22420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E22710", Offset = "0x6E21B10", VA = "0x186E22710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KKJNCIAFHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public KKJNCIAFHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E25EF0", Offset = "0x6E252F0", VA = "0x186E25EF0")]
		internal Task LLLKDMGHFNO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct KKAHCIPJLGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6E25C30", Offset = "0x6E25030", VA = "0x186E25C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E25E90", Offset = "0x6E25290", VA = "0x186E25E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BLCELNGDCMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E20510", Offset = "0x6E1F910", VA = "0x186E20510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E206F0", Offset = "0x6E1FAF0", VA = "0x186E206F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PIMHMLPCNLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A640", Offset = "0x6E29A40", VA = "0x186E2A640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A9B0", Offset = "0x6E29DB0", VA = "0x186E2A9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct BFAHJECIPBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F9B0", Offset = "0x6E1EDB0", VA = "0x186E1F9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6E1FCA0", Offset = "0x6E1F0A0", VA = "0x186E1FCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class CFOCMHCNDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public CFOCMHCNDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6E20A60", Offset = "0x6E1FE60", VA = "0x186E20A60")]
		internal Task EPNPGFNNBPO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct HPCPMBCEPFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6E239D0", Offset = "0x6E22DD0", VA = "0x186E239D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6E23C30", Offset = "0x6E23030", VA = "0x186E23C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct KCLHAGMMCGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6E25810", Offset = "0x6E24C10", VA = "0x186E25810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6E25990", Offset = "0x6E24D90", VA = "0x186E25990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct FAEMBPMGNEI<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3F166D0", Offset = "0x3F15AD0", VA = "0x183F166D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3F16930", Offset = "0x3F15D30", VA = "0x183F16930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct JKLCFGNAFPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6E25320", Offset = "0x6E24720", VA = "0x186E25320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6E25650", Offset = "0x6E24A50", VA = "0x186E25650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? MGDFBOEDDBM;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<FHMPKELNMGN> EGNGPGBFGBN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task HFBKMPBCFND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E28690", Offset = "0x6E27A90", VA = "0x186E28690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E28150", Offset = "0x6E27550", VA = "0x186E28150")]
	public static bool KMAGKCHCPFA(this Task FFKGFPJNCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6210", Offset = "0x2FB5610", VA = "0x182FB6210")]
	public static Task<T> DAEIHJKOBJH<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E28700", Offset = "0x6E27B00", VA = "0x186E28700")]
	public static Task MJKLDBPLEHA(this Task FFKGFPJNCFN, CancellationToken CFGHNHCDKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2FB9120", Offset = "0x2FB8520", VA = "0x182FB9120")]
	public static Task<TResult> MJKLDBPLEHA<TResult>(this Task<TResult> FFKGFPJNCFN, CancellationToken CFGHNHCDKCN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2FBA090", Offset = "0x2FB9490", VA = "0x182FBA090")]
	public static TaskCompletionSource<TResult> MJKLDBPLEHA<TResult>(this TaskCompletionSource<TResult> AEJJDMNDMNA, CancellationToken CFGHNHCDKCN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E27270", Offset = "0x6E26670", VA = "0x186E27270")]
	public static IDisposable? EEGIGDNNAGK(CancellationToken DLBLLFDBOJG, CancellationToken EEABKDFJGAP, [Out] CancellationToken OJGJIGNEMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6E28A50", Offset = "0x6E27E50", VA = "0x186E28A50")]
	[AsyncStateMachine(typeof(JPDJAOKKJHF))]
	public static void NODAMJMEHPD(this Task BNBMPMKBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6E26CA0", Offset = "0x6E260A0", VA = "0x186E26CA0")]
	[AsyncStateMachine(typeof(NECKLKJBDKA))]
	public static void BEIJIACADBO(this Task BNBMPMKBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6A90", Offset = "0x2FB5E90", VA = "0x182FB6A90")]
	[AsyncStateMachine(typeof(JCDPFJNHCKC<>))]
	public static Task KPKOHPPBFIM<TException>(this Task BNBMPMKBBFO) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6630", Offset = "0x2FB5A30", VA = "0x182FB6630")]
	[AsyncStateMachine(typeof(LKDOJGONEBJ<>))]
	public static Task<T> HEGNJHBHHLN<T>(this Task<T> EAFEIEDNLNL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6E28960", Offset = "0x6E27D60", VA = "0x186E28960")]
	[AsyncStateMachine(typeof(BKKEFNCDCGE))]
	public static Task<TaskStatus> NJNLADBHJKL(this Task EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6810", Offset = "0x2FB5C10", VA = "0x182FB6810")]
	public static (Task<T?>?, Action<T?>?) KKFJIBJOHNH<T>([Optional] CancellationToken GBOOEEMCFEA)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2FBAB10", Offset = "0x2FB9F10", VA = "0x182FBAB10")]
	[AsyncStateMachine(typeof(JBKJBPICFAH<, >))]
	public static Task<List<TResult>> OEHMEIMJJNN<TResult, TInput>(this Task<List<TInput>> FFKGFPJNCFN, MIPFAFNHPGL<TInput, TResult> HKHHBLGHGJF) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E27710", Offset = "0x6E26B10", VA = "0x186E27710")]
	[AsyncStateMachine(typeof(LMCJDGMAHEO))]
	public static Task HBMDILNJDCO(Task BNBMPMKBBFO, CancellationToken FJFHCIBPLHE, Func<CancellationToken, Task> NLIFDLEOJJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E275E0", Offset = "0x6E269E0", VA = "0x186E275E0")]
	[AsyncStateMachine(typeof(BIGKPNJBCGD))]
	public static Task FGFEKCFEGII(Func<CancellationToken, Task> MACOAEAICEH, TimeSpan CGABKENFOHF, [Optional] CancellationToken FJFHCIBPLHE, [Optional] Action<OperationCanceledException>? LPAEKJBKLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6390", Offset = "0x2FB5790", VA = "0x182FB6390")]
	[AsyncStateMachine(typeof(EBFCKKFOMEP<>))]
	public static Task<T> FGFEKCFEGII<T>(Func<CancellationToken, Task<T>> MACOAEAICEH, TimeSpan CGABKENFOHF, [Optional] CancellationToken FJFHCIBPLHE, [Optional] Func<OperationCanceledException, T>? LPAEKJBKLBH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6E28180", Offset = "0x6E27580", VA = "0x186E28180")]
	public static Task LPBDJOBLGLA(params Task[] EEICCLIAFNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E281D0", Offset = "0x6E275D0", VA = "0x186E281D0")]
	public static Task LPBDJOBLGLA(IEnumerable<Task> EEICCLIAFNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2FBAFD0", Offset = "0x2FBA3D0", VA = "0x182FBAFD0")]
	[AsyncStateMachine(typeof(JIBFAKOKLMK<>))]
	public static Task<IEnumerable<Task<T>>> PFJNGJGOEMF<T>(IEnumerable<Task<T>> EEICCLIAFNP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2FBAC20", Offset = "0x2FBA020", VA = "0x182FBAC20")]
	[AsyncStateMachine(typeof(FHNEBNNILHM<, , , >))]
	public static Task<(T1, T2, T3, T4)> OOEAELJALHI<T1, T2, T3, T4>(Task<T1> MFPOLHOFMHN, Task<T2> GPGBOJEDAGC, Task<T3> EFFKKCLBPHH, Task<T4> LHAJBKOPBMO) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E26E20", Offset = "0x6E26220", VA = "0x186E26E20")]
	[AsyncStateMachine(typeof(OEKMFIPCAOI))]
	public static Task CJFBGDOFEPI(Func<bool> NAFCJPGDPLL, [Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E26F10", Offset = "0x6E26310", VA = "0x186E26F10")]
	[AsyncStateMachine(typeof(LLHFPFFEOLF))]
	public static Task CJFBGDOFEPI(Func<bool> NAFCJPGDPLL, TimeSpan HGBHFIDLEBE, [Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6E27EE0", Offset = "0x6E272E0", VA = "0x186E27EE0")]
	[AsyncStateMachine(typeof(FADDDJCIBOI))]
	public static Task KBMKFPNEJMP(Func<bool> NAFCJPGDPLL, TimeSpan CGABKENFOHF, [Optional] CancellationToken GBOOEEMCFEA, [Optional] Action<OperationCanceledException>? LPAEKJBKLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6E28010", Offset = "0x6E27410", VA = "0x186E28010")]
	[AsyncStateMachine(typeof(KKAHCIPJLGI))]
	public static Task KBMKFPNEJMP(Func<bool> NAFCJPGDPLL, TimeSpan CGABKENFOHF, TimeSpan HGBHFIDLEBE, [Optional] CancellationToken GBOOEEMCFEA, [Optional] Action<OperationCanceledException>? LPAEKJBKLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E27130", Offset = "0x6E26530", VA = "0x186E27130")]
	[AsyncStateMachine(typeof(BLCELNGDCMJ))]
	public static Task CNGOIOEDEON(Func<bool> NAFCJPGDPLL, [Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E27020", Offset = "0x6E26420", VA = "0x186E27020")]
	[AsyncStateMachine(typeof(PIMHMLPCNLF))]
	public static Task CNGOIOEDEON(Func<bool> NAFCJPGDPLL, TimeSpan HGBHFIDLEBE, [Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E28BF0", Offset = "0x6E27FF0", VA = "0x186E28BF0")]
	[AsyncStateMachine(typeof(BFAHJECIPBK))]
	public static Task OJHAFPPFDAI(Func<bool> NAFCJPGDPLL, TimeSpan CGABKENFOHF, [Optional] CancellationToken GBOOEEMCFEA, [Optional] Action<OperationCanceledException>? LPAEKJBKLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E28D20", Offset = "0x6E28120", VA = "0x186E28D20")]
	[AsyncStateMachine(typeof(HPCPMBCEPFJ))]
	public static Task OJHAFPPFDAI(Func<bool> NAFCJPGDPLL, TimeSpan CGABKENFOHF, TimeSpan HGBHFIDLEBE, [Optional] CancellationToken GBOOEEMCFEA, [Optional] Action<OperationCanceledException>? LPAEKJBKLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E28B00", Offset = "0x6E27F00", VA = "0x186E28B00")]
	[AsyncStateMachine(typeof(KCLHAGMMCGB))]
	[Obsolete]
	public static Task OAFBGGHPNPC(this Task FFKGFPJNCFN, Action KALOIICAEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2FBAA20", Offset = "0x2FB9E20", VA = "0x182FBAA20")]
	[Obsolete]
	[AsyncStateMachine(typeof(FAEMBPMGNEI<>))]
	public static Task OAFBGGHPNPC<T>(this Task<T> FFKGFPJNCFN, Action<T> KALOIICAEML) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E27CE0", Offset = "0x6E270E0", VA = "0x186E27CE0")]
	private static void IEODNJJKALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E27960", Offset = "0x6E26D60", VA = "0x186E27960")]
	public static bool HPFELKBOOON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6E27450", Offset = "0x6E26850", VA = "0x186E27450")]
	private static void FGADNBJAALB(SynchronizationContext PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E27840", Offset = "0x6E26C40", VA = "0x186E27840")]
	private static void HDPOHCLPHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E26D50", Offset = "0x6E26150", VA = "0x186E26D50")]
	public static void CCMHAKCJNIJ([Optional] string? NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E27D90", Offset = "0x6E27190", VA = "0x186E27D90")]
	public static void JEPHPINDDBG([Optional] string? NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6E27400", Offset = "0x6E26800", VA = "0x186E27400")]
	public static KINJHPNBDCJ FDMPFIBFPPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E27220", Offset = "0x6E26620", VA = "0x186E27220")]
	public static KINJHPNBDCJ DIGCLHMFAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6E27E10", Offset = "0x6E27210", VA = "0x186E27E10")]
	[AsyncStateMachine(typeof(JKLCFGNAFPK))]
	public static Task JGIOJFIKJMM(Func<Task> FDHGHLDCDAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MMCIGIHMOCH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
	public MMCIGIHMOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class HNDBOJLHHKM : HEAAEJIOBID
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly HEAAEJIOBID GHDNHBBFDEB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime AEDEIIGMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6E23910", Offset = "0x6E22D10", VA = "0x186E23910", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset DOPHIGBIHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6E238B0", Offset = "0x6E22CB0", VA = "0x186E238B0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public HNDBOJLHHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface HEAAEJIOBID
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime AEDEIIGMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset DOPHIGBIHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class EAFOBMPCACI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long DLCGDIAPIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6E21B00", Offset = "0x6E20F00", VA = "0x186E21B00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long OEOCFPGJBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6E22010", Offset = "0x6E21410", VA = "0x186E22010")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double ECFHBPLEBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6E21FC0", Offset = "0x6E213C0", VA = "0x186E21FC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double KOJOCBKGOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6E21C80", Offset = "0x6E21080", VA = "0x186E21C80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double BJNOEELBAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6E21DF0", Offset = "0x6E211F0", VA = "0x186E21DF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double OECOCDLKBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6E21EE0", Offset = "0x6E212E0", VA = "0x186E21EE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E21F30", Offset = "0x6E21330", VA = "0x186E21F30")]
	public static double OHFGEHPDCJL(long GMNPKDGMLLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E21CD0", Offset = "0x6E210D0", VA = "0x186E21CD0")]
	public static double BGNFFKBLAKG(long GMNPKDGMLLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E21E40", Offset = "0x6E21240", VA = "0x186E21E40")]
	public static double HELJHPKHACG(double BDDEENPFHIG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E21D60", Offset = "0x6E21160", VA = "0x186E21D60")]
	public static long GDPBEOCJACK(long FOPCLCJOGBF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6E21ED0", Offset = "0x6E212D0", VA = "0x186E21ED0")]
	public static long IFNEOMHCBLO(long JNJNIFIMLAD, long PLHLEDKFGBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6E21BB0", Offset = "0x6E20FB0", VA = "0x186E21BB0")]
	public static double BDIAEOFPFIH(long JNJNIFIMLAD, long PLHLEDKFGBA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E21B50", Offset = "0x6E20F50", VA = "0x186E21B50")]
	public static double ACKAFOHJILJ(long JNJNIFIMLAD, long PLHLEDKFGBA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class PFGIDEEPHEJ : HJIJLIPJCIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly TimeSpan NPPFGKMPEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly System.Timers.Timer PJIAIBMJLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private TimeSpan CGABKENFOHF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan GJNLPLMHKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A070", Offset = "0x6E29470", VA = "0x186E2A070", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? DIHPGKEOOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A5D0", Offset = "0x6E299D0", VA = "0x186E2A5D0")]
	[Preserve]
	public PFGIDEEPHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A380", Offset = "0x6E29780", VA = "0x186E2A380")]
	public PFGIDEEPHEJ(TimeSpan CGABKENFOHF, [Optional] Action? PPOBFNAFAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E29FE0", Offset = "0x6E293E0", VA = "0x186E29FE0", Slot = "7")]
	public void HEDCOPEMPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A2A0", Offset = "0x6E296A0", VA = "0x186E2A2A0", Slot = "8")]
	public void PPAMKENPGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A1D0", Offset = "0x6E295D0", VA = "0x186E2A1D0", Slot = "9")]
	public void LFENALFAFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xC6F730", Offset = "0xC6EB30", VA = "0x180C6F730")]
	private void PDPIHBGKNKI(object KGHCPOJBNFM, ElapsedEventArgs DHFOGEGCGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2A200", Offset = "0x6E29600", VA = "0x186E2A200")]
	private static void MPIJCECJMBK(TimeSpan KPGECJIADMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6E29F40", Offset = "0x6E29340", VA = "0x186E29F40", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class GDCDIKCGJKC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string? CHJLLEEPJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string GFOFDBBPHPJ;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0xA35740", Offset = "0xA34B40", VA = "0x180A35740")]
	public GDCDIKCGJKC(string ICNGJIJIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4315AF0", Offset = "0x4314EF0", VA = "0x184315AF0")]
	public GDCDIKCGJKC(string CHOCLJFEHKE, string ICNGJIJIACL)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct GOIMCPNPDHP : IEquatable<GOIMCPNPDHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint GOAPPPMLIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int BMNOEJPNCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float LPFCONILIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public ushort BEAGBFDHKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ushort IOKDKDLKDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public short LAIFMIGPDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public short ECDOMGJJAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public char CLOJECCJGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public char CCGAHDNLEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte CLLMJEKAJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public byte JDLOLCJJMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public byte HEJNOKPNGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte BFDPMMAAMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool POIFIIEHJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool HDNDHJOPJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool AKLCKGOLNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool DBBBAPHGMIP;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x17111F0", Offset = "0x17105F0", VA = "0x1817111F0")]
	public static GOIMCPNPDHP FGGACLBJKBC(uint GOHKPEEOELL)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x17111F0", Offset = "0x17105F0", VA = "0x1817111F0")]
	public static GOIMCPNPDHP OANLBHMNMEJ(int NIOKHLOKBOL)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E229B0", Offset = "0x6E21DB0", VA = "0x186E229B0")]
	public static GOIMCPNPDHP LDIIEHLCIFD(float CJPMOLOJMKK)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E22910", Offset = "0x6E21D10", VA = "0x186E22910")]
	public static GOIMCPNPDHP OGEDIBOECIE(byte GEEEFBAPKII, byte BKMBAMMDBMJ, byte MGKFHNMBAPG, byte GNIHLONKLBJ)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6E22910", Offset = "0x6E21D10", VA = "0x186E22910")]
	public static GOIMCPNPDHP GIGKGEDGJAF(bool OGEJDOMDNBG, bool GCJDCIGKCGK, bool LHIEFBFPBLI, bool NIIJJECFLHC)
	{
		return default(GOIMCPNPDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6E22910", Offset = "0x6E21D10", VA = "0x186E22910")]
	public static GOIMCPNPDHP DPBBONFFMBC(byte DOAFPMNCOAP, byte PNBKCFLPKBD, byte LDHJCIFLICD, byte GGBBGBCMHNO)
	{
		return default(GOIMCPNPDHP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2B90", Offset = "0x1FF1F90", VA = "0x181FF2B90")]
	public static bool LIIBJCIOAJF(GOIMCPNPDHP MMHCOKHACHF, GOIMCPNPDHP DEOGINMLLDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xD2E5E0", Offset = "0xD2D9E0", VA = "0x180D2E5E0", Slot = "4")]
	public bool Equals(GOIMCPNPDHP OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6E22930", Offset = "0x6E21D30", VA = "0x186E22930", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xDED660", Offset = "0xDECA60", VA = "0x180DED660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6E229C0", Offset = "0x6E21DC0", VA = "0x186E229C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct JIHDFBKBGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public ulong PIACAHPPLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public long CKJBIFCBONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public double NINKHAJGLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint KAKLAKIGINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint LENMINBBCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int KAEBFEHKKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int PAOEJCLDOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float LDGOLINHGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float JCIIBOEIKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort BEAGBFDHKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public ushort IOKDKDLKDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public ushort KJNOAJFPFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public ushort LBOFLBBHEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short LAIFMIGPDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public short ECDOMGJJAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public short OIFCAFOPINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short GPDCGIPMCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char CLOJECCJGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char CCGAHDNLEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char MEIEDIIIAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public char CKIJABAHACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte CLLMJEKAJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte JDLOLCJJMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte HEJNOKPNGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte BFDPMMAAMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte OBDEBLPMGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte HLKNNMCOBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte DPPMFAJAIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte DPCCGDKEGHD;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
	public static JIHDFBKBGMJ GIIIFAJNKEL(long FKBLBGAAGNC)
	{
		return default(JIHDFBKBGMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6E24840", Offset = "0x6E23C40", VA = "0x186E24840")]
	public static JIHDFBKBGMJ GIIIFAJNKEL(byte GEEEFBAPKII, byte BKMBAMMDBMJ, byte MGKFHNMBAPG, byte GNIHLONKLBJ, byte FKHDGECDPBF, byte JNAJHKBCGND, byte ABDDKDMKKNM, byte AOGPOPEIDJJ)
	{
		return default(JIHDFBKBGMJ);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct BODEDDJJNGN : IEquatable<BODEDDJJNGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte JLGELFOCLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool KJFGLNOLOBG;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2863420", Offset = "0x2862820", VA = "0x182863420")]
	public static BODEDDJJNGN OGEDIBOECIE(byte DHCLCLJAKFM)
	{
		return default(BODEDDJJNGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2863420", Offset = "0x2862820", VA = "0x182863420")]
	public static BODEDDJJNGN GIGKGEDGJAF(bool HKLLFLHJBOP)
	{
		return default(BODEDDJJNGN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6E207F0", Offset = "0x6E1FBF0", VA = "0x186E207F0")]
	public static bool LIIBJCIOAJF(BODEDDJJNGN MMHCOKHACHF, BODEDDJJNGN DEOGINMLLDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5F79F80", Offset = "0x5F79380", VA = "0x185F79F80", Slot = "4")]
	public bool Equals(BODEDDJJNGN OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E20750", Offset = "0x6E1FB50", VA = "0x186E20750", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6E207E0", Offset = "0x6E1FBE0", VA = "0x186E207E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E20800", Offset = "0x6E1FC00", VA = "0x186E20800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NBLAMLCGFPC<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly T LOEHNLOIGDO;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x492EBB0", Offset = "0x492DFB0", VA = "0x18492EBB0")]
	public NBLAMLCGFPC(T GGAEAKDCOPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class AKPGGNBAHNN
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD490", Offset = "0x2ECC890", VA = "0x182ECD490")]
	public static IEnumerable<T> JIKBPDJGHIO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
	public static T[] JMJPCGOKELN<T>(params T[] EIAKLJFCEKE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
	public static IEnumerable<T> PFCLHKFEGEJ<T>(params T[] EIAKLJFCEKE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2C470C0", Offset = "0x2C464C0", VA = "0x182C470C0")]
	public static HashSet<T> LDLJOJGDDFH<T>(params T[] EIAKLJFCEKE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x35D0820", Offset = "0x35CFC20", VA = "0x1835D0820")]
	public static KeyValuePair<TKey, TValue> AJLNHCBOMAN<TKey, TValue>([In] TKey PBFBBOFLBNL, [In] TValue PFKKDHPJFEH) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2C470C0", Offset = "0x2C464C0", VA = "0x182C470C0")]
	public static List<T> GDCCKJMCJOB<T>(IEnumerable<T> AKAPKCMHDAP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[AttributeUsage(AttributeTargets.All)]
public sealed class GFCMOGLFEEB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly string FGCHCBHFCJO;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
	public GFCMOGLFEEB(string FMMMPENKMMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object ABOIPPPDKPM<T>([In] T KCHFAPGLICB);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object LBMNKKEMHDM<T>(T KCHFAPGLICB);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[FOABBCIMGMG]
public delegate string NPFJILLMGMJ(string BBLEEPEBKMO, string? PKIPCCDIHFG, bool IPECANLIAKJ);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[FOABBCIMGMG]
public delegate void NHFPPJMIAHM(string NFKMLKNHFEM);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[FOABBCIMGMG]
public delegate void FOFAFMAIJOE(Exception BDBOMDMKJJK);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public delegate object EBOOIHPDMID();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[FOABBCIMGMG]
public delegate bool NOKCOLPBILG();
[Cpp2IlInjected.Token(Token = "0x2000060")]
[FOABBCIMGMG]
public delegate string NNFLKDCGHBG(object FAKGLFFOLFI);
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.Enum)]
public class NPMGJPHOGEG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
	public NPMGJPHOGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class CMLCMHMHDIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct MGIPPCINJCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6E29110", Offset = "0x6E28510", VA = "0x186E29110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6E29A00", Offset = "0x6E28E00", VA = "0x186E29A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly TimerCallback CHJHKMFNLOJ;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Action<object?> IGLAFHAFOFJ;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6E20E50", Offset = "0x6E20250", VA = "0x186E20E50")]
	public static Task<bool> NMPBPPBMNOG(int NCFNMLEFONP, [Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E20D20", Offset = "0x6E20120", VA = "0x186E20D20")]
	[AsyncStateMachine(typeof(MGIPPCINJCI))]
	private static Task<bool> GOPJHEBEHLF(int NCFNMLEFONP, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E20C00", Offset = "0x6E20000", VA = "0x186E20C00")]
	private static void CNECAKPJDFG(object? GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6E20C90", Offset = "0x6E20090", VA = "0x186E20C90")]
	private static void FKGDLOLHGGD(object? GCJJLPMGMAA)
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
