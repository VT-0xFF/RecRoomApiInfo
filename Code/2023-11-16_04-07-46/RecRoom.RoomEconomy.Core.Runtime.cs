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
public interface KAECFHBLNDP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HBHGPBJIHFN(TimeSpan MHLLEOJIGID, CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KPJCGAJHOLM : KAECFHBLNDP
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x63A0E30", Offset = "0x639FE30", VA = "0x1863A0E30")]
	[PKDJMILODMH(OPHHJIDIAGK.Root, OMIAJJHDDGO.GameOnly)]
	private static void DFABGLAHNPD(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	[Preserve]
	public KPJCGAJHOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x63A0F30", Offset = "0x639FF30", VA = "0x1863A0F30", Slot = "4")]
	public Task HBHGPBJIHFN(TimeSpan MHLLEOJIGID, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MHPDGBGAFPL<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId MDLHGGMMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int ECMMIKLPIHL;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C976E0", Offset = "0x3C966E0", VA = "0x183C976E0")]
	public MHPDGBGAFPL(TItemId PJBGLHBBLJH, int EONCDFNJNJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PEMJFAHLCEO<TItemId, TResult> : DGDIODMLPIG<MHPDGBGAFPL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x372DCE0", Offset = "0x372CCE0", VA = "0x18372DCE0")]
	public PEMJFAHLCEO(ONHNCDKBMHO<MHPDGBGAFPL<TItemId>, TResult> HHEPJFGEAJC, TimeSpan EBIIEEGJGBN, [Optional] KAECFHBLNDP LGGCFFGCGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA770", Offset = "0x3EA9770", VA = "0x183EAA770")]
	public Task<TResult> PKGKFGLGOHD(TItemId BGNGIHJEFLM, int EONCDFNJNJB, [Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DGDIODMLPIG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct FFLJPPPEBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest IOICHNDCGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> MJJBMLKLIEC;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E80", Offset = "0x7F6E80", VA = "0x1807F7E80")]
		public FFLJPPPEBPI(TRequest ICLPGCHCHFB, TaskCompletionSource<TResult> FKPIILDBMBC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CCEMIEPHFHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DGDIODMLPIG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x47F0690", Offset = "0x47EF690", VA = "0x1847F0690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x47F0BD0", Offset = "0x47EFBD0", VA = "0x1847F0BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GFIDHJOLPIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public DGDIODMLPIG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3511200", Offset = "0x3510200", VA = "0x183511200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x35115D0", Offset = "0x35105D0", VA = "0x1835115D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IGJHHCKNBEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DGDIODMLPIG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3734C50", Offset = "0x3733C50", VA = "0x183734C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37350F0", Offset = "0x37340F0", VA = "0x1837350F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BFMMHNCAIOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DGDIODMLPIG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x45526D0", Offset = "0x45516D0", VA = "0x1845526D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4553610", Offset = "0x4552610", VA = "0x184553610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ONHNCDKBMHO<TRequest, TResult> HHEPJFGEAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float EBIIEEGJGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KAECFHBLNDP LGGCFFGCGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<FFLJPPPEBPI> MEEGNMOGOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource JKDLLKHHDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource LPJMFAOHOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task FFCOCIKFAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float OGIENBIMFEK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OAFFKLKKCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB490", Offset = "0x9EA490", VA = "0x1809EB490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9EA540", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8B40", Offset = "0x4DA7B40", VA = "0x184DA8B40")]
	public DGDIODMLPIG(ONHNCDKBMHO<TRequest, TResult> HHEPJFGEAJC, TimeSpan EBIIEEGJGBN, [Optional] KAECFHBLNDP LGGCFFGCGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8210", Offset = "0x4DA7210", VA = "0x184DA8210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8A20", Offset = "0x4DA7A20", VA = "0x184DA8A20")]
	[AsyncStateMachine(typeof(DGDIODMLPIG<, >.CCEMIEPHFHO))]
	public Task<TResult> PKGKFGLGOHD(TRequest ICLPGCHCHFB, [Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8860", Offset = "0x4DA7860", VA = "0x184DA8860")]
	public Task LIDHCONKBCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DA84C0", Offset = "0x4DA74C0", VA = "0x184DA84C0")]
	[AsyncStateMachine(typeof(DGDIODMLPIG<, >.GFIDHJOLPIJ))]
	private Task GBCNFHJMAIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8740", Offset = "0x4DA7740", VA = "0x184DA8740")]
	[AsyncStateMachine(typeof(DGDIODMLPIG<, >.IGJHHCKNBEF))]
	private Task KANBNLJAGAI(CancellationToken OOALAELOAIP, CancellationToken BHNCBHLLAOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8920", Offset = "0x4DA7920", VA = "0x184DA8920")]
	[AsyncStateMachine(typeof(DGDIODMLPIG<, >.BFMMHNCAIOM))]
	private Task MGGBIDBMAKI(CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8140", Offset = "0x4DA7140", VA = "0x184DA8140")]
	private TimeSpan BEJINJNFPBJ()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8630", Offset = "0x4DA7630", VA = "0x184DA8630")]
	private Task<List<TResult>> JHEJEHGJAPC(IReadOnlyList<TRequest> EBOJCBEJPBL, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8420", Offset = "0x4DA7420", VA = "0x184DA8420")]
	private float EKJCDDIJMLM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4DA85A0", Offset = "0x4DA75A0", VA = "0x184DA85A0")]
	private void GFFPLONJFHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PJFAPEKODBM<TItemId, TResult> : ONHNCDKBMHO<MHPDGBGAFPL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> KBMGKEPILKH(Dictionary<TItemId, int> EBOJCBEJPBL, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CFIKGGFHKGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public CFIKGGFHKGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x47F5F60", Offset = "0x47F4F60", VA = "0x1847F5F60")]
		internal TResult GFOEAAPKIBF(MHPDGBGAFPL<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IBIOAPNBMDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<MHPDGBGAFPL<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PJFAPEKODBM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private CFIKGGFHKGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x371C790", Offset = "0x371B790", VA = "0x18371C790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x371D4E0", Offset = "0x371C4E0", VA = "0x18371D4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly KBMGKEPILKH DHPHJMFPHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> ABOMPCEIBOE;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37319D0", Offset = "0x37309D0", VA = "0x1837319D0")]
	public PJFAPEKODBM(KBMGKEPILKH DHPHJMFPHDM, [Optional] IEqualityComparer<TItemId> ABOMPCEIBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4B70", Offset = "0x3EB3B70", VA = "0x183EB4B70", Slot = "4")]
	[AsyncStateMachine(typeof(PJFAPEKODBM<, >.IBIOAPNBMDI))]
	public Task<List<TResult>> LPLBHGNLKCH(IReadOnlyList<MHPDGBGAFPL<TItemId>> EBOJCBEJPBL, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IEHPEEDAJKF<TRequest, TResult> : ONHNCDKBMHO<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> BOBFPHAIMFB(IEnumerable<TRequest> GLFJEGIEBJE, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IGHHIMKBCLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public IGHHIMKBCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x311EF70", Offset = "0x311DF70", VA = "0x18311EF70")]
		internal TResult GFOEAAPKIBF(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct IJJIFPPCJPA : IAsyncStateMachine
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
		public IEHPEEDAJKF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private IGHHIMKBCLD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3747670", Offset = "0x3746670", VA = "0x183747670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x37484A0", Offset = "0x37474A0", VA = "0x1837484A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BOBFPHAIMFB DHPHJMFPHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> ABOMPCEIBOE;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37319D0", Offset = "0x37309D0", VA = "0x1837319D0")]
	public IEHPEEDAJKF(BOBFPHAIMFB DHPHJMFPHDM, [Optional] IEqualityComparer<TRequest> ABOMPCEIBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3731880", Offset = "0x3730880", VA = "0x183731880", Slot = "4")]
	[AsyncStateMachine(typeof(IEHPEEDAJKF<, >.IJJIFPPCJPA))]
	public Task<List<TResult>> LPLBHGNLKCH(IReadOnlyList<TRequest> EBOJCBEJPBL, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ONHNCDKBMHO<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> LPLBHGNLKCH(IReadOnlyList<TRequest> EBOJCBEJPBL, CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FLFFJNGBGGF<TItemId, TResult> : ONHNCDKBMHO<KIDOBJHDLDF<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task MGJAGFKBDEL(IReadOnlyDictionary<TItemId, KIDOBJHDLDF<TItemId>.JKCPMPGOPDF> EBOJCBEJPBL, CancellationToken JEBPNJAPHEL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LPEJMIFOMFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public FLFFJNGBGGF<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<KIDOBJHDLDF<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B680", Offset = "0x3A9A680", VA = "0x183A9B680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3A9BBB0", Offset = "0x3A9ABB0", VA = "0x183A9BBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MGJAGFKBDEL ICEIIODOELI;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	public FLFFJNGBGGF(MGJAGFKBDEL ICEIIODOELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3468AF0", Offset = "0x3467AF0", VA = "0x183468AF0", Slot = "4")]
	[AsyncStateMachine(typeof(FLFFJNGBGGF<, >.LPEJMIFOMFK))]
	public Task<List<object>> LPLBHGNLKCH(IReadOnlyList<KIDOBJHDLDF<TItemId>> EBOJCBEJPBL, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3468680", Offset = "0x3467680", VA = "0x183468680")]
	private IReadOnlyDictionary<TItemId, KIDOBJHDLDF<TItemId>.JKCPMPGOPDF> KPIAFGGJKCK(IReadOnlyList<KIDOBJHDLDF<TItemId>> KKCJIFFAODG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NBFDEEGCBID<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, EPJAFLBMDAL> GPBALPEPEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> HCOHALAHDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> DJKJDJDEEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> AFNGIPLKBMG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, EPJAFLBMDAL> CALFHOBIHMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> HGFPFLEEEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MKLNNONPEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8620A0", Offset = "0x8610A0", VA = "0x1808620A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8620C0", Offset = "0x8610C0", VA = "0x1808620C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D08FA0", Offset = "0x3D07FA0", VA = "0x183D08FA0")]
	public NBFDEEGCBID(Func<IEnumerable<T>> DJKJDJDEEKC, Func<T, string> AFNGIPLKBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D08D20", Offset = "0x3D07D20", VA = "0x183D08D20")]
	public void HOEJNKLEAPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NGHBHENHGOB<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid HPDKIOPIJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> PHFGMOHOPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KDMCGOOALKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface LNMEHBFJKAI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int IEAOCBPAAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool EPJKJHCNBLK<TParam>(TParam APPJEOKOGAK);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PJCMBMLFEAG(Exception BALOPCFMODO);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NKOMOPDEMOD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class IIKBBEPIJBE<TResult> : LNMEHBFJKAI, NGHBHENHGOB<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> JHNAGPPLNOK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid HPDKIOPIJFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAF06A0", Offset = "0xAEF6A0", VA = "0x180AF06A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int IEAOCBPAAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8620A0", Offset = "0x8610A0", VA = "0x1808620A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> PHFGMOHOPIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3746630", Offset = "0x3745630", VA = "0x183746630", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x37466F0", Offset = "0x37456F0", VA = "0x1837466F0")]
		public IIKBBEPIJBE(int KFKDNILGNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x23A27A0", Offset = "0x23A17A0", VA = "0x1823A27A0", Slot = "5")]
		public bool EPJKJHCNBLK<TParam>(TParam APPJEOKOGAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x37466B0", Offset = "0x37456B0", VA = "0x1837466B0", Slot = "6")]
		public bool PJCMBMLFEAG(Exception BALOPCFMODO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3746670", Offset = "0x3745670", VA = "0x183746670", Slot = "7")]
		public bool NKOMOPDEMOD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string MLMJPJBDJHE = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, LNMEHBFJKAI> NKGJMALKBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly PNGCGLNIPND BJGCIILIICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool OHHPNMBGFHO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x63A0D60", Offset = "0x639FD60", VA = "0x1863A0D60")]
	public KDMCGOOALKC([Optional] PNGCGLNIPND BJGCIILIICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x63A0640", Offset = "0x639F640", VA = "0x1863A0640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x253AD00", Offset = "0x2539D00", VA = "0x18253AD00")]
	public NGHBHENHGOB<TResult> OGJLIHIGHCL<TResult>(int CCPHLCNHHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x253AFA0", Offset = "0x2539FA0", VA = "0x18253AFA0")]
	public bool PPCPEBDJEFJ<TResult>(Guid KBNMFHADFEA, TResult BBMBCGDLBEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x63A0C40", Offset = "0x639FC40", VA = "0x1863A0C40")]
	private void OGOKFBFHIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x63A0640", Offset = "0x639F640", VA = "0x1863A0640")]
	private void AEIGLKKIOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63A0750", Offset = "0x639F750", VA = "0x1863A0750")]
	private void BBDPEAAHGPI(int KFKDNILGNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63A0A40", Offset = "0x639FA40", VA = "0x1863A0A40")]
	private void DJGCENJFBHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum DCHFJMLGFMI
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KIDOBJHDLDF<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class JKCPMPGOPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int LGHOPPEMKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int BCOOIOCEMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int EJBOEDOHIOJ;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public JKCPMPGOPDF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId MDLHGGMMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int ECMMIKLPIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public DCHFJMLGFMI KGOOFJIHGLC;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xDD1EE0", Offset = "0xDD0EE0", VA = "0x180DD1EE0")]
	public KIDOBJHDLDF(TItemId PJBGLHBBLJH, int EONCDFNJNJB, DCHFJMLGFMI ONDDMEPBDDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LCLCENEKLFG<TItemId, TResult> : DGDIODMLPIG<KIDOBJHDLDF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x372DCE0", Offset = "0x372CCE0", VA = "0x18372DCE0")]
	public LCLCENEKLFG(ONHNCDKBMHO<KIDOBJHDLDF<TItemId>, TResult> HHEPJFGEAJC, TimeSpan EBIIEEGJGBN, [Optional] KAECFHBLNDP LGGCFFGCGME)
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
