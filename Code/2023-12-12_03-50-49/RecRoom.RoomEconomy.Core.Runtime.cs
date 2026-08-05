using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BKJEGCCJEAC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BGGODNMFLKO(int FJHCPAIOJGD, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BGGODNMFLKO(TimeSpan NLBNBEPNDHE, CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HJIKHJPDEGM : BKJEGCCJEAC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x63BFAF0", Offset = "0x63BE2F0", VA = "0x1863BFAF0")]
	[IOOPNJKFHOG(JJAMOFEKMEH.Root, FICJCHGEBPC.GameOnly)]
	private static void PIAOHNCICLB(PHIPPCBHDOE EFKPBKMFDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	[Preserve]
	public HJIKHJPDEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x63BFA90", Offset = "0x63BE290", VA = "0x1863BFA90", Slot = "4")]
	public Task BGGODNMFLKO(int FJHCPAIOJGD, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63BFA30", Offset = "0x63BE230", VA = "0x1863BFA30", Slot = "5")]
	public Task BGGODNMFLKO(TimeSpan NLBNBEPNDHE, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FEIPCBFBCDD<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId BGNKGPOJMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int KCOFBOABBDC;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x345C4E0", Offset = "0x345ACE0", VA = "0x18345C4E0")]
	public FEIPCBFBCDD(TItemId BDENKEEOPEA, int AAEHEHHJFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OHLHGFFDDEF<TItemId, TResult> : AKOPFIABHFD<FEIPCBFBCDD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3657D50", Offset = "0x3656550", VA = "0x183657D50")]
	public OHLHGFFDDEF(AMFJONEHDDK<FEIPCBFBCDD<TItemId>, TResult> GPCOGCDOAEO, TimeSpan OHGKHOPIEOF, [Optional] BKJEGCCJEAC BIJPDLLHELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E137C0", Offset = "0x3E11FC0", VA = "0x183E137C0")]
	public Task<TResult> HNGBNMBHCAL(TItemId EMBEECDJLJB, int AAEHEHHJFMP, [Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AKOPFIABHFD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct OGEOAHFAIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest FDADPCFDFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> FOKOCMNDIBJ;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8384B0", Offset = "0x836CB0", VA = "0x1808384B0")]
		public OGEOAHFAIJJ(TRequest KOFJNFGLAFK, TaskCompletionSource<TResult> HDOBCOGKHBC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CAHCGGJAEDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AKOPFIABHFD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x48DA900", Offset = "0x48D9100", VA = "0x1848DA900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x48DAE40", Offset = "0x48D9640", VA = "0x1848DAE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NBOBAFLMDPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AKOPFIABHFD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7C50", Offset = "0x3CF6450", VA = "0x183CF7C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8020", Offset = "0x3CF6820", VA = "0x183CF8020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OKCIEMCKBPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AKOPFIABHFD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BC60", Offset = "0x3E1A460", VA = "0x183E1BC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C100", Offset = "0x3E1A900", VA = "0x183E1C100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KCMJCCPELLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AKOPFIABHFD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x38E3800", Offset = "0x38E2000", VA = "0x1838E3800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x38E4740", Offset = "0x38E2F40", VA = "0x1838E4740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AMFJONEHDDK<TRequest, TResult> GPCOGCDOAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float OHGKHOPIEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BKJEGCCJEAC BIJPDLLHELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<OGEOAHFAIJJ> LPOIOLANENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource CNOIJAFIDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource IGFAIOJGOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task JGGCOABADMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float HPEINBPCIOE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MGKHEKGJIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1B6E0", Offset = "0xA19EE0", VA = "0x180A1B6E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1BA00", Offset = "0xA1A200", VA = "0x180A1BA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x365C150", Offset = "0x365A950", VA = "0x18365C150")]
	public AKOPFIABHFD(AMFJONEHDDK<TRequest, TResult> GPCOGCDOAEO, TimeSpan OHGKHOPIEOF, [Optional] BKJEGCCJEAC BIJPDLLHELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x365B820", Offset = "0x365A020", VA = "0x18365B820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x365BCF0", Offset = "0x365A4F0", VA = "0x18365BCF0")]
	[AsyncStateMachine(typeof(AKOPFIABHFD<, >.CAHCGGJAEDA))]
	public Task<TResult> HNGBNMBHCAL(TRequest KOFJNFGLAFK, [Optional] CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x365C090", Offset = "0x365A890", VA = "0x18365C090")]
	public Task OOEPMJEJHHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x365BE10", Offset = "0x365A610", VA = "0x18365BE10")]
	[AsyncStateMachine(typeof(AKOPFIABHFD<, >.NBOBAFLMDPK))]
	private Task JEONALJMNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x365BA30", Offset = "0x365A230", VA = "0x18365BA30")]
	[AsyncStateMachine(typeof(AKOPFIABHFD<, >.OKCIEMCKBPD))]
	private Task FIELDFCMAIG(CancellationToken FGBEDFCLANK, CancellationToken DABMEIHFOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x365BBF0", Offset = "0x365A3F0", VA = "0x18365BBF0")]
	[AsyncStateMachine(typeof(AKOPFIABHFD<, >.KCMJCCPELLG))]
	private Task HGIDNDDIJBF(CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x365B750", Offset = "0x3659F50", VA = "0x18365B750")]
	private TimeSpan BOGDANDOHNH()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x365BF80", Offset = "0x365A780", VA = "0x18365BF80")]
	private Task<List<TResult>> JPGIPDLCOLK(IReadOnlyList<TRequest> MODPINCOIGB, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x365BB50", Offset = "0x365A350", VA = "0x18365BB50")]
	private float GMHBCECPJLJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x365BEF0", Offset = "0x365A6F0", VA = "0x18365BEF0")]
	private void JHKLJJGDPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GLENKAMHHEB<TItemId, TResult> : AMFJONEHDDK<FEIPCBFBCDD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> JFEGBOMLCDI(Dictionary<TItemId, int> MODPINCOIGB, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GAOPDEBEPEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GAOPDEBEPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3514A70", Offset = "0x3513270", VA = "0x183514A70")]
		internal TResult JIOKHKFFDCM(FEIPCBFBCDD<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LLCAMMMDMID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<FEIPCBFBCDD<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public GLENKAMHHEB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private GAOPDEBEPEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E470", Offset = "0x3A6CC70", VA = "0x183A6E470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F1C0", Offset = "0x3A6D9C0", VA = "0x183A6F1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly JFEGBOMLCDI JCDLLKFPHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> LPAEICJJCCK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x35286D0", Offset = "0x3526ED0", VA = "0x1835286D0")]
	public GLENKAMHHEB(JFEGBOMLCDI JCDLLKFPHKO, [Optional] IEqualityComparer<TItemId> LPAEICJJCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x35282E0", Offset = "0x3526AE0", VA = "0x1835282E0", Slot = "4")]
	[AsyncStateMachine(typeof(GLENKAMHHEB<, >.LLCAMMMDMID))]
	public Task<List<TResult>> CGFKCCBDGID(IReadOnlyList<FEIPCBFBCDD<TItemId>> MODPINCOIGB, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HJFOPLKNNEC<TRequest, TResult> : AMFJONEHDDK<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> CJJNNADFBGA(IEnumerable<TRequest> NELKNKCIMIB, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GHBIAEEFNIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GHBIAEEFNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x351C760", Offset = "0x351AF60", VA = "0x18351C760")]
		internal TResult JIOKHKFFDCM(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HJFDOHFJJNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public HJFOPLKNNEC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private GHBIAEEFNIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x35A2D40", Offset = "0x35A1540", VA = "0x1835A2D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x35A3B70", Offset = "0x35A2370", VA = "0x1835A3B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CJJNNADFBGA JCDLLKFPHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> LPAEICJJCCK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x35286D0", Offset = "0x3526ED0", VA = "0x1835286D0")]
	public HJFOPLKNNEC(CJJNNADFBGA JCDLLKFPHKO, [Optional] IEqualityComparer<TRequest> LPAEICJJCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x35A3E20", Offset = "0x35A2620", VA = "0x1835A3E20", Slot = "4")]
	[AsyncStateMachine(typeof(HJFOPLKNNEC<, >.HJFDOHFJJNP))]
	public Task<List<TResult>> CGFKCCBDGID(IReadOnlyList<TRequest> MODPINCOIGB, CancellationToken GANAOLJLMGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AMFJONEHDDK<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> CGFKCCBDGID(IReadOnlyList<TRequest> MODPINCOIGB, CancellationToken GANAOLJLMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NOIOKEOFFPF<TItemId, TResult> : AMFJONEHDDK<ALIOMNDKCFD<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task JNBLMLDAABL(IReadOnlyDictionary<TItemId, ALIOMNDKCFD<TItemId>.BNEFPCEPCAF> MODPINCOIGB, CancellationToken GANAOLJLMGA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct GNBOPOENJNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NOIOKEOFFPF<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<ALIOMNDKCFD<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3528760", Offset = "0x3526F60", VA = "0x183528760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3528C90", Offset = "0x3527490", VA = "0x183528C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JNBLMLDAABL NOMGJGAFHDH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public NOIOKEOFFPF(JNBLMLDAABL NOMGJGAFHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D44820", Offset = "0x3D43020", VA = "0x183D44820", Slot = "4")]
	[AsyncStateMachine(typeof(NOIOKEOFFPF<, >.GNBOPOENJNF))]
	public Task<List<object>> CGFKCCBDGID(IReadOnlyList<ALIOMNDKCFD<TItemId>> MODPINCOIGB, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D44960", Offset = "0x3D43160", VA = "0x183D44960")]
	private IReadOnlyDictionary<TItemId, ALIOMNDKCFD<TItemId>.BNEFPCEPCAF> ECMNFPBNIAA(IReadOnlyList<ALIOMNDKCFD<TItemId>> DOKDAGENKDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FPMBPNPPDDD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, MLEFGOJIALB> PADEPLEGADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> GIIKFPEFCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> OPOHDCHHMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> EJACFDFEKIF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, MLEFGOJIALB> OJLEAAMPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> FOCHPNKKALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KEJKOGPKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x89AF10", Offset = "0x899710", VA = "0x18089AF10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x89AF20", Offset = "0x899720", VA = "0x18089AF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x348BDE0", Offset = "0x348A5E0", VA = "0x18348BDE0")]
	public FPMBPNPPDDD(Func<IEnumerable<T>> OPOHDCHHMPH, Func<T, string> EJACFDFEKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x348BB60", Offset = "0x348A360", VA = "0x18348BB60")]
	public void OMANMGAMPNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FEGLMPPPLAG<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid NDGGCDDLEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> EMLANCIAMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PIECBHPNICM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface MNGMJHJBFIG
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int DDKCKFNIDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool INENGPBIDAA<TParam>(TParam DOLICEBFIPF);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HBNALMICKGI(Exception GKFJGAEIAFC);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool HHNKBMFGBBA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class OLKNBKDJELE<TResult> : MNGMJHJBFIG, FEGLMPPPLAG<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> MJGKNEPNLPB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid NDGGCDDLEAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB2AA00", Offset = "0xB29200", VA = "0x180B2AA00", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int DDKCKFNIDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x89AF10", Offset = "0x899710", VA = "0x18089AF10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> EMLANCIAMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3CE8A10", Offset = "0x3CE7210", VA = "0x183CE8A10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C920", Offset = "0x3E2B120", VA = "0x183E2C920")]
		public OLKNBKDJELE(int HGPEJJDAECD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2426830", Offset = "0x2425030", VA = "0x182426830", Slot = "5")]
		public bool INENGPBIDAA<TParam>(TParam DOLICEBFIPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C8A0", Offset = "0x3E2B0A0", VA = "0x183E2C8A0", Slot = "6")]
		public bool HBNALMICKGI(Exception GKFJGAEIAFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C8E0", Offset = "0x3E2B0E0", VA = "0x183E2C8E0", Slot = "7")]
		public bool HHNKBMFGBBA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string LKLJJBKOPPN = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, MNGMJHJBFIG> HIFAKIFDMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BBMLAPPJBMJ KIBCMAIGFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool FCMGGHBPOEE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x63C0310", Offset = "0x63BEB10", VA = "0x1863C0310")]
	public PIECBHPNICM([Optional] BBMLAPPJBMJ KIBCMAIGFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x63BFBF0", Offset = "0x63BE3F0", VA = "0x1863BFBF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2655A40", Offset = "0x2654240", VA = "0x182655A40")]
	public FEGLMPPPLAG<TResult> HEBAEELKNKC<TResult>(int PDNLDLDKDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2655CE0", Offset = "0x26544E0", VA = "0x182655CE0")]
	public bool PDELEHCBKBJ<TResult>(Guid HGCENGMCDHK, TResult MLABNLLFODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63BFF00", Offset = "0x63BE700", VA = "0x1863BFF00")]
	private void LOBDGPIJGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63BFBF0", Offset = "0x63BE3F0", VA = "0x1863BFBF0")]
	private void KCHKOOOHGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63C0020", Offset = "0x63BE820", VA = "0x1863C0020")]
	private void MACFLMOBFKB(int HGPEJJDAECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63BFD00", Offset = "0x63BE500", VA = "0x1863BFD00")]
	private void JGIFKBKPPKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum OOFICLHBHEO
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ALIOMNDKCFD<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class BNEFPCEPCAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int LIDDMKBFCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int FIAECPOEIJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int NOHPIDOCLPH;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public BNEFPCEPCAF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId BGNKGPOJMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int KCOFBOABBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public OOFICLHBHEO NOKODIELPJB;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xE0C670", Offset = "0xE0AE70", VA = "0x180E0C670")]
	public ALIOMNDKCFD(TItemId BDENKEEOPEA, int AAEHEHHJFMP, OOFICLHBHEO PCNNAKCFNJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class IFMBAHJEMHC<TItemId, TResult> : AKOPFIABHFD<ALIOMNDKCFD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3657D50", Offset = "0x3656550", VA = "0x183657D50")]
	public IFMBAHJEMHC(AMFJONEHDDK<ALIOMNDKCFD<TItemId>, TResult> GPCOGCDOAEO, TimeSpan OHGKHOPIEOF, [Optional] BKJEGCCJEAC BIJPDLLHELL)
	{
	}
}
namespace Cpp2IlInjected;

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
