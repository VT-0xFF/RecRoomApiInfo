using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NANJGBCNBNJ<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OBMEEHMPLFJ(in TAction DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction FDJGDKDLKDN(in TAction DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction ADJMMGOIMGG(in TAction DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> BKMDFKDCION(in TAction DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GGGDAGJPDPM(in TAction DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OAJIOCIANII(in TAction DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DNMFPDMABGK(in TAction DINDBGHHKFD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ODMPIMMKGKB(in TAction DINDBGHHKFD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KEANGNNKEAJ<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::OHLMNAGCLLG<KJIKBBHJGOJ> DNINCGGINNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPBIILNBEPE();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNHOJLDCKCE(in global::OHLMNAGCLLG<OJOKFKDKKOK> MJLAKODJCLP, in TAction DINDBGHHKFD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class KJIKBBHJGOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class OJOKFKDKKOK
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LGNJGBELLIE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::KHIKGOFOEPF<TAction, Task<global::OINADPKEOOE<object, GLCHJOHDFCN>>, TActionReceiver> where TActionReceiver : global::CMKLCHNPLIC<TAction, Task<global::OINADPKEOOE<object, GLCHJOHDFCN>>> where TActionDeps : global::NANJGBCNBNJ<TAction> where TStaticNetSysDeps : global::KEANGNNKEAJ<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface AHAEBDIKDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NBCDDACMJJE(in global::OINADPKEOOE<object, GLCHJOHDFCN> HPCDOCAJMAG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CFPLEOFHHMD();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::OINADPKEOOE<object, GLCHJOHDFCN> JLCKLEMLEDK();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NKOHHHAPGJC(Exception JCDAGKOMEPG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class PFPOKNBPBKO : AHAEBDIKDCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::OINADPKEOOE<object, GLCHJOHDFCN>> MMCOHLMCAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::OINADPKEOOE<object, GLCHJOHDFCN>> LMLPHDFEGMI;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D08680", Offset = "0x1D07880", VA = "0x181D08680")]
		private PFPOKNBPBKO(TaskCompletionSource<global::OINADPKEOOE<object, GLCHJOHDFCN>> KGLIDGKFIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1CF54C0", Offset = "0x1CF46C0", VA = "0x181CF54C0")]
		public static PFPOKNBPBKO ECPJFBMNCEK(TaskCompletionSource<global::OINADPKEOOE<object, GLCHJOHDFCN>> KGLIDGKFIOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D085C0", Offset = "0x1D077C0", VA = "0x181D085C0")]
		public void NBCDDACMJJE(in global::OINADPKEOOE<object, GLCHJOHDFCN> HPCDOCAJMAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1D08460", Offset = "0x1D07660", VA = "0x181D08460", Slot = "5")]
		public void CFPLEOFHHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1D08520", Offset = "0x1D07720", VA = "0x181D08520", Slot = "6")]
		public global::OINADPKEOOE<object, GLCHJOHDFCN> JLCKLEMLEDK()
		{
			return default(global::OINADPKEOOE<object, GLCHJOHDFCN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1D08620", Offset = "0x1D07820", VA = "0x181D08620", Slot = "7")]
		public void NKOHHHAPGJC(Exception JCDAGKOMEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5590", Offset = "0x1CF4790", VA = "0x181CF5590", Slot = "4")]
		private void GIMCCAGHCAM(in global::OINADPKEOOE<object, GLCHJOHDFCN> HPCDOCAJMAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class FNLDKLLBHNG : AHAEBDIKDCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::OINADPKEOOE<object, GLCHJOHDFCN>> MMCOHLMCAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::OINADPKEOOE<object, GLCHJOHDFCN> PGJGAABGDCN;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5640", Offset = "0x1CF4840", VA = "0x181CF5640")]
		private FNLDKLLBHNG(TaskCompletionSource<global::OINADPKEOOE<object, GLCHJOHDFCN>> KGLIDGKFIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1CF54C0", Offset = "0x1CF46C0", VA = "0x181CF54C0")]
		public static FNLDKLLBHNG ECPJFBMNCEK(TaskCompletionSource<global::OINADPKEOOE<object, GLCHJOHDFCN>> KGLIDGKFIOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1CF55C0", Offset = "0x1CF47C0", VA = "0x181CF55C0")]
		public void NBCDDACMJJE(in global::OINADPKEOOE<object, GLCHJOHDFCN> HPCDOCAJMAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5460", Offset = "0x1CF4660", VA = "0x181CF5460", Slot = "5")]
		public void CFPLEOFHHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x637160", Offset = "0x636360", VA = "0x180637160", Slot = "6")]
		public global::OINADPKEOOE<object, GLCHJOHDFCN> JLCKLEMLEDK()
		{
			return default(global::OINADPKEOOE<object, GLCHJOHDFCN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1CF55E0", Offset = "0x1CF47E0", VA = "0x181CF55E0", Slot = "7")]
		public void NKOHHHAPGJC(Exception JCDAGKOMEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5590", Offset = "0x1CF4790", VA = "0x181CF5590", Slot = "4")]
		private void GIMCCAGHCAM(in global::OINADPKEOOE<object, GLCHJOHDFCN> HPCDOCAJMAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class FPLCNHKPLOM : AHAEBDIKDCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::OINADPKEOOE<object, GLCHJOHDFCN>> LMLPHDFEGMI;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5800", Offset = "0x1CF4A00", VA = "0x181CF5800")]
		private FPLCNHKPLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5680", Offset = "0x1CF4880", VA = "0x181CF5680")]
		public static FPLCNHKPLOM ECPJFBMNCEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1CF57A0", Offset = "0x1CF49A0", VA = "0x181CF57A0")]
		public void NBCDDACMJJE(in global::OINADPKEOOE<object, GLCHJOHDFCN> HPCDOCAJMAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "5")]
		public void CFPLEOFHHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5740", Offset = "0x1CF4940", VA = "0x181CF5740", Slot = "6")]
		public global::OINADPKEOOE<object, GLCHJOHDFCN> JLCKLEMLEDK()
		{
			return default(global::OINADPKEOOE<object, GLCHJOHDFCN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
		public void NKOHHHAPGJC(Exception JCDAGKOMEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5590", Offset = "0x1CF4790", VA = "0x181CF5590", Slot = "4")]
		private void GIMCCAGHCAM(in global::OINADPKEOOE<object, GLCHJOHDFCN> HPCDOCAJMAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class NJDJNFEODAF : AHAEBDIKDCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::OINADPKEOOE<object, GLCHJOHDFCN> PGJGAABGDCN;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		private NJDJNFEODAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5680", Offset = "0x1CF4880", VA = "0x181CF5680")]
		public static NJDJNFEODAF ECPJFBMNCEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xC9BAF0", Offset = "0xC9ACF0", VA = "0x180C9BAF0")]
		public void NBCDDACMJJE(in global::OINADPKEOOE<object, GLCHJOHDFCN> HPCDOCAJMAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "5")]
		public void CFPLEOFHHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6457F0", Offset = "0x6449F0", VA = "0x1806457F0", Slot = "6")]
		public global::OINADPKEOOE<object, GLCHJOHDFCN> JLCKLEMLEDK()
		{
			return default(global::OINADPKEOOE<object, GLCHJOHDFCN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
		public void NKOHHHAPGJC(Exception JCDAGKOMEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5590", Offset = "0x1CF4790", VA = "0x181CF5590", Slot = "4")]
		private void GIMCCAGHCAM(in global::OINADPKEOOE<object, GLCHJOHDFCN> HPCDOCAJMAG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NELCOKJCEPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::OINADPKEOOE<object, GLCHJOHDFCN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::LGNJGBELLIE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::OHLMNAGCLLG<KJIKBBHJGOJ> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::OHLMNAGCLLG<OJOKFKDKKOK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::OINADPKEOOE<object, GLCHJOHDFCN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D081E0", Offset = "0x1D073E0", VA = "0x181D081E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D08410", Offset = "0x1D07610", VA = "0x181D08410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IOGMNPPFKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::OINADPKEOOE<object, GLCHJOHDFCN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::LGNJGBELLIE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::OHLMNAGCLLG<KJIKBBHJGOJ> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::OHLMNAGCLLG<OJOKFKDKKOK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private AHAEBDIKDCJ <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5A70", Offset = "0x1CF4C70", VA = "0x181CF5A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1CF6200", Offset = "0x1CF5400", VA = "0x181CF6200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LLIPEACAJEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::LGNJGBELLIE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AHAEBDIKDCJ completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private AHAEBDIKDCJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::OINADPKEOOE<object, GLCHJOHDFCN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D01DC0", Offset = "0x1D00FC0", VA = "0x181D01DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver ACBGAGKEONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps INOHNKAMBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps JGDJKAPGBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int CNBDJCIKHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int OKCPGALLOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::OHLMNAGCLLG<OJOKFKDKKOK>, TaskCompletionSource<global::OINADPKEOOE<object, GLCHJOHDFCN>>> CNPPCEFMBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::EAHPBDMKKLD<OJOKFKDKKOK> GKPFMAOLPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool PNMILFMAGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int MNKLOBOLFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task PMGNDOCALAP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9AC0", Offset = "0x1CF8CC0", VA = "0x181CF9AC0")]
	protected LGNJGBELLIE(TActionDeps ILEOKJOLIEJ, TStaticNetSysDeps OOCJLIGCILN, int KHABGKJKLMF, int EBFHBHIEHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9560", Offset = "0x1CF8760", VA = "0x181CF9560")]
	public static global::LGNJGBELLIE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> ECPJFBMNCEK(TActionDeps ILEOKJOLIEJ, TStaticNetSysDeps OOCJLIGCILN, [Optional] int? KHABGKJKLMF, [Optional] int? EBFHBHIEHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9260", Offset = "0x1CF8460", VA = "0x181CF9260")]
	public Task<global::OINADPKEOOE<object, GLCHJOHDFCN>> DNHOJLDCKCE(in TAction DINDBGHHKFD, bool LNGLOJMGHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9810", Offset = "0x1CF8A10", VA = "0x181CF9810")]
	public void JLAJKJCJFEG(in TActionReceiver IMKBBCCEEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9970", Offset = "0x1CF8B70", VA = "0x181CF9970")]
	[AsyncStateMachine(typeof(global::LGNJGBELLIE<, , , >.NELCOKJCEPG))]
	public Task<global::OINADPKEOOE<object, GLCHJOHDFCN>> OHABMPJICMG(global::OHLMNAGCLLG<KJIKBBHJGOJ> FHAPEIAFAEO, global::OHLMNAGCLLG<OJOKFKDKKOK> MJLAKODJCLP, TAction DINDBGHHKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9110", Offset = "0x1CF8310", VA = "0x181CF9110")]
	[AsyncStateMachine(typeof(global::LGNJGBELLIE<, , , >.IOGMNPPFKBK))]
	private Task<global::OINADPKEOOE<object, GLCHJOHDFCN>> DADECNBMCFD(global::OHLMNAGCLLG<KJIKBBHJGOJ> FHAPEIAFAEO, global::OHLMNAGCLLG<OJOKFKDKKOK> MJLAKODJCLP, TAction DINDBGHHKFD, Task FKPEGPEEBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9820", Offset = "0x1CF8A20", VA = "0x181CF9820")]
	[AsyncStateMachine(typeof(global::LGNJGBELLIE<, , , >.LLIPEACAJEB))]
	private Task LGOEGKAOKCB(TAction DINDBGHHKFD, AHAEBDIKDCJ DMAAADPJJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9690", Offset = "0x1CF8890", VA = "0x181CF9690")]
	private void HPAHHANCFJE(TAction DINDBGHHKFD, bool PALGEFNCPJN, bool PIINBDANIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1CF75C0", Offset = "0x1CF67C0", VA = "0x181CF75C0", Slot = "4")]
	private Task<global::OINADPKEOOE<object, GLCHJOHDFCN>> KNNFIAFLEGA(in TAction DINDBGHHKFD, bool LNGLOJMGHNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GDCCEHJOPCI : GLCHJOHDFCN
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8C53F0", Offset = "0x8C45F0", VA = "0x1808C53F0", Slot = "4")]
	public override string IFPPEBIJMBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8C5420", Offset = "0x8C4620", VA = "0x1808C5420")]
	private GDCCEHJOPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x19252F0", Offset = "0x19244F0", VA = "0x1819252F0")]
	public static global::OINADPKEOOE<TOk, GLCHJOHDFCN> ECPJFBMNCEK<TOk>()
	{
		return default(global::OINADPKEOOE<TOk, GLCHJOHDFCN>);
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
