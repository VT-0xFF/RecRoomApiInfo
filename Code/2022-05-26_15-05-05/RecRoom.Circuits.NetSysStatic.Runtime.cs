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
public interface KLIDNCPFLJP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FELGKDDPGEA(in TAction BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction DKGDPDKOOFL(in TAction BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction EHPDDKGKKCC(in TAction BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> GMHHIEDGKCF(in TAction BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NAHDEFHKDPI(in TAction BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IEKGELLOEGO(in TAction BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KPFDDBHBPHH(in TAction BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ILMBEJJJFAI(in TAction BKCLKIJOKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NLAKMDDABME<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::JIJCDEFKIBB<FOOOECCBPJE> FIKMAKNIACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIKECHNMBEG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFGPCGOPNEJ(in global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, in TAction BKCLKIJOKLP);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct FOOOECCBPJE
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct HNMDOHCOCOP
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> : global::DIKDCIOLEEN<TAction, Task<global::COPPIENFOJP<object, GIGPDIEHPEM>>, TActionReceiver> where TActionReceiver : global::GCCGPNAOPPH<TAction, Task<global::COPPIENFOJP<object, GIGPDIEHPEM>>> where TActionDeps : global::KLIDNCPFLJP<TAction> where TNetSysStaticDeps : global::NLAKMDDABME<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface DNDJHPMKLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IBOLPNFGNFI(in global::COPPIENFOJP<object, GIGPDIEHPEM> AEOILPMENGG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void POPOJPGEDOC();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::COPPIENFOJP<object, GIGPDIEHPEM> NEFNKDDKMDG();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void APMKCCLPOFC(Exception ALOGJNLCMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class DEPKMGKCHKP : DNDJHPMKLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::COPPIENFOJP<object, GIGPDIEHPEM>> EGJNJJPGNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::COPPIENFOJP<object, GIGPDIEHPEM>> JONNPFGAHBA;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8400", Offset = "0x2FD6A00", VA = "0x182FD8400")]
		private DEPKMGKCHKP(TaskCompletionSource<global::COPPIENFOJP<object, GIGPDIEHPEM>> HBDDKAGOBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2F3B470", Offset = "0x2F39A70", VA = "0x182F3B470")]
		public static DEPKMGKCHKP CIAOGEOFBKG(TaskCompletionSource<global::COPPIENFOJP<object, GIGPDIEHPEM>> HBDDKAGOBLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8210", Offset = "0x2FD6810", VA = "0x182FD8210")]
		public void IBOLPNFGNFI(in global::COPPIENFOJP<object, GIGPDIEHPEM> AEOILPMENGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8340", Offset = "0x2FD6940", VA = "0x182FD8340", Slot = "5")]
		public void POPOJPGEDOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8270", Offset = "0x2FD6870", VA = "0x182FD8270", Slot = "6")]
		public global::COPPIENFOJP<object, GIGPDIEHPEM> NEFNKDDKMDG()
		{
			return default(global::COPPIENFOJP<object, GIGPDIEHPEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2FD81B0", Offset = "0x2FD67B0", VA = "0x182FD81B0", Slot = "7")]
		public void APMKCCLPOFC(Exception ALOGJNLCMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8310", Offset = "0x2FD6910", VA = "0x182FD8310", Slot = "4")]
		private void NOMJIJDNNJN(in global::COPPIENFOJP<object, GIGPDIEHPEM> AEOILPMENGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class KGFGLLICDLD : DNDJHPMKLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::COPPIENFOJP<object, GIGPDIEHPEM>> EGJNJJPGNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::COPPIENFOJP<object, GIGPDIEHPEM> LOBFKKMAFFL;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x20B8150", Offset = "0x20B6750", VA = "0x1820B8150")]
		private KGFGLLICDLD(TaskCompletionSource<global::COPPIENFOJP<object, GIGPDIEHPEM>> HBDDKAGOBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2F3B470", Offset = "0x2F39A70", VA = "0x182F3B470")]
		public static KGFGLLICDLD CIAOGEOFBKG(TaskCompletionSource<global::COPPIENFOJP<object, GIGPDIEHPEM>> HBDDKAGOBLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x20B6550", Offset = "0x20B4B50", VA = "0x1820B6550")]
		public void IBOLPNFGNFI(in global::COPPIENFOJP<object, GIGPDIEHPEM> AEOILPMENGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE550", Offset = "0x2FDCB50", VA = "0x182FDE550", Slot = "5")]
		public void POPOJPGEDOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x561000", Offset = "0x55F600", VA = "0x180561000", Slot = "6")]
		public global::COPPIENFOJP<object, GIGPDIEHPEM> NEFNKDDKMDG()
		{
			return default(global::COPPIENFOJP<object, GIGPDIEHPEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE4F0", Offset = "0x2FDCAF0", VA = "0x182FDE4F0", Slot = "7")]
		public void APMKCCLPOFC(Exception ALOGJNLCMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8310", Offset = "0x2FD6910", VA = "0x182FD8310", Slot = "4")]
		private void NOMJIJDNNJN(in global::COPPIENFOJP<object, GIGPDIEHPEM> AEOILPMENGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class MEIFPFOMLFH : DNDJHPMKLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::COPPIENFOJP<object, GIGPDIEHPEM>> JONNPFGAHBA;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF000", Offset = "0x2FDD600", VA = "0x182FDF000")]
		private MEIFPFOMLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE430", Offset = "0x2FDCA30", VA = "0x182FDE430")]
		public static MEIFPFOMLFH CIAOGEOFBKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEF40", Offset = "0x2FDD540", VA = "0x182FDEF40")]
		public void IBOLPNFGNFI(in global::COPPIENFOJP<object, GIGPDIEHPEM> AEOILPMENGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		public void POPOJPGEDOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEFA0", Offset = "0x2FDD5A0", VA = "0x182FDEFA0", Slot = "6")]
		public global::COPPIENFOJP<object, GIGPDIEHPEM> NEFNKDDKMDG()
		{
			return default(global::COPPIENFOJP<object, GIGPDIEHPEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
		public void APMKCCLPOFC(Exception ALOGJNLCMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8310", Offset = "0x2FD6910", VA = "0x182FD8310", Slot = "4")]
		private void NOMJIJDNNJN(in global::COPPIENFOJP<object, GIGPDIEHPEM> AEOILPMENGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class JAFBELAHECF : DNDJHPMKLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::COPPIENFOJP<object, GIGPDIEHPEM> LOBFKKMAFFL;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		private JAFBELAHECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE430", Offset = "0x2FDCA30", VA = "0x182FDE430")]
		public static JAFBELAHECF CIAOGEOFBKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xDBB3C0", Offset = "0xDB99C0", VA = "0x180DBB3C0")]
		public void IBOLPNFGNFI(in global::COPPIENFOJP<object, GIGPDIEHPEM> AEOILPMENGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		public void POPOJPGEDOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83A090", Offset = "0x838690", VA = "0x18083A090", Slot = "6")]
		public global::COPPIENFOJP<object, GIGPDIEHPEM> NEFNKDDKMDG()
		{
			return default(global::COPPIENFOJP<object, GIGPDIEHPEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
		public void APMKCCLPOFC(Exception ALOGJNLCMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8310", Offset = "0x2FD6910", VA = "0x182FD8310", Slot = "4")]
		private void NOMJIJDNNJN(in global::COPPIENFOJP<object, GIGPDIEHPEM> AEOILPMENGG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct MPFKNCDMFJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::COPPIENFOJP<object, GIGPDIEHPEM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::JIJCDEFKIBB<FOOOECCBPJE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::JIJCDEFKIBB<HNMDOHCOCOP> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::COPPIENFOJP<object, GIGPDIEHPEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF070", Offset = "0x2FDD670", VA = "0x182FDF070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF2A0", Offset = "0x2FDD8A0", VA = "0x182FDF2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KJOJJDINCBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::COPPIENFOJP<object, GIGPDIEHPEM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::JIJCDEFKIBB<FOOOECCBPJE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::JIJCDEFKIBB<HNMDOHCOCOP> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DNDJHPMKLJP <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE5B0", Offset = "0x2FDCBB0", VA = "0x182FDE5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2FDED40", Offset = "0x2FDD340", VA = "0x182FDED40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IJHALFPIGAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public DNDJHPMKLJP completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DNDJHPMKLJP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::COPPIENFOJP<object, GIGPDIEHPEM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2FDDA90", Offset = "0x2FDC090", VA = "0x182FDDA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver IFLMFCMJFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps DGJMHNBPLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TNetSysStaticDeps BOOJLJEOIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int BHELHLMBJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int JOIHKELBOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::JIJCDEFKIBB<HNMDOHCOCOP>, TaskCompletionSource<global::COPPIENFOJP<object, GIGPDIEHPEM>>> HLLFAGBFELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::MBFPHPBLMMI<HNMDOHCOCOP> FICPMOGKKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool IPICIDODKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int DECNDMBAEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task OIMMOOEJJKK;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7780", Offset = "0x2FD5D80", VA = "0x182FD7780")]
	protected BPAEAECMIMP(TActionDeps ELNLDKFLDHC, TNetSysStaticDeps BGHJHNMANPB, int FGOLMPKJGGM, int BOFGHPAOMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6F20", Offset = "0x2FD5520", VA = "0x182FD6F20")]
	public static global::BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> CIAOGEOFBKG(TActionDeps ELNLDKFLDHC, TNetSysStaticDeps BGHJHNMANPB, [Optional] int? FGOLMPKJGGM, [Optional] int? BOFGHPAOMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7480", Offset = "0x2FD5A80", VA = "0x182FD7480")]
	public Task<global::COPPIENFOJP<object, GIGPDIEHPEM>> KFGPCGOPNEJ(in TAction BKCLKIJOKLP, bool GNMNBNFPAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2FD71D0", Offset = "0x2FD57D0", VA = "0x182FD71D0")]
	public void FCDBIJHHPEM(in TActionReceiver NEDAGCALOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2FD71E0", Offset = "0x2FD57E0", VA = "0x182FD71E0")]
	[AsyncStateMachine(typeof(global::BPAEAECMIMP<, , , >.MPFKNCDMFJG))]
	public Task<global::COPPIENFOJP<object, GIGPDIEHPEM>> FFNBNIMAOLF(global::JIJCDEFKIBB<FOOOECCBPJE> PLFEGFLMJIJ, global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, TAction BKCLKIJOKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6DD0", Offset = "0x2FD53D0", VA = "0x182FD6DD0")]
	[AsyncStateMachine(typeof(global::BPAEAECMIMP<, , , >.KJOJJDINCBN))]
	private Task<global::COPPIENFOJP<object, GIGPDIEHPEM>> CABEKHIAKME(global::JIJCDEFKIBB<FOOOECCBPJE> PLFEGFLMJIJ, global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, TAction BKCLKIJOKLP, Task MICBAPBLLNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7330", Offset = "0x2FD5930", VA = "0x182FD7330")]
	[AsyncStateMachine(typeof(global::BPAEAECMIMP<, , , >.IJHALFPIGAJ))]
	private Task IAAJBNBEAEK(TAction BKCLKIJOKLP, DNDJHPMKLJP CGKCLEKPEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7050", Offset = "0x2FD5650", VA = "0x182FD7050")]
	private void CPOOCPLNHCB(TAction BKCLKIJOKLP, bool GNJNDCLEILK, bool IKBIEGKHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2695770", Offset = "0x2693D70", VA = "0x182695770", Slot = "4")]
	private Task<global::COPPIENFOJP<object, GIGPDIEHPEM>> HBCCPLECAFG(in TAction BKCLKIJOKLP, bool GNMNBNFPAII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class AGEIEKDPOEN : GIGPDIEHPEM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xCE5D30", Offset = "0xCE4330", VA = "0x180CE5D30", Slot = "4")]
	public override string FHJFBLCMFLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xCE5D60", Offset = "0xCE4360", VA = "0x180CE5D60")]
	private AGEIEKDPOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1C183B0", Offset = "0x1C169B0", VA = "0x181C183B0")]
	public static global::COPPIENFOJP<TOk, GIGPDIEHPEM> CIAOGEOFBKG<TOk>()
	{
		return default(global::COPPIENFOJP<TOk, GIGPDIEHPEM>);
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
