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
public interface GLMLOKDOEPB<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NDKPKFNPKHL(TAction GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction CJOAJIOIJBB(TAction GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction BFEAMECDJIC(TAction GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> FKLFLEKKGMK(TAction GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AEPFKNFHDGA(TAction GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CLENIIPOMBD(TAction GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EDJJHLEIHLK(TAction GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool INDIBKOPIBG(TAction GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DAFBDEPBCFN(TAction GPNJNMLGIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MFPGEPDJDLB<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::IOJDDMIHILI<IBDPOCJOHKG> GKFEINNKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int ENENLNBCHMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJBNHHLKAGC();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JILLBFEJHGO(global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, TAction GPNJNMLGIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ILNBHOKGAOA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DPOCMFKIEBP(in TPartialSnapshot NJKIPCBEEFF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot BFIEMIMMIKL(TPartialSnapshot[] IAIJBMANEJF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KMANKBKIKOF<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult FAGLKLPEJDH(TAction GPNJNMLGIEN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] OPHHEMKDLEO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IBDPOCJOHKG
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class GGICLPCGLOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KJOKPBFJIIM<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::ILNBHOKGAOA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] FBBKKDEGCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int BNIPMFJGFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps FHGAMNFIHGP;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x23503E0", Offset = "0x234F5E0", VA = "0x1823503E0")]
	internal KJOKPBFJIIM(TPartialSnapshot[] LOAAFEIPPIN, int NMCGGPCDGOE, TDeps IAPGLFJKDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2350330", Offset = "0x234F530", VA = "0x182350330")]
	public static global::KJOKPBFJIIM<TPartialSnapshot, TFullSnapshot, TDeps> GDHAFJANMPF(TDeps IAPGLFJKDEF)
	{
		return default(global::KJOKPBFJIIM<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LGKNMOOAIHI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D68F00", Offset = "0x1D68100", VA = "0x181D68F00")]
	public static global::MBPMAHFIKHD<TFullSnapshot> BFNMBNCONIJ<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::KJOKPBFJIIM<TPartialSnapshot, TFullSnapshot, TDeps> PKCJMFFNILJ, TPartialSnapshot NJKIPCBEEFF) where TDeps : global::ILNBHOKGAOA<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::MBPMAHFIKHD<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D69240", Offset = "0x1D68440", VA = "0x181D69240")]
	public static bool PADOPFMBKDK<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::KJOKPBFJIIM<TPartialSnapshot, TFullSnapshot, TDeps> PKCJMFFNILJ, TPartialSnapshot NJKIPCBEEFF) where TDeps : global::ILNBHOKGAOA<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class EPKNNHPCJIP : NPKBEKPOKML
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xEB5F10", Offset = "0xEB5110", VA = "0x180EB5F10", Slot = "5")]
	public override string PPGCJLLFOLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xEB5F40", Offset = "0xEB5140", VA = "0x180EB5F40")]
	public EPKNNHPCJIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::KMANKBKIKOF<TAction, Task<global::OHFECDBHLHC<object, NPKBEKPOKML>>> where TActionDeps : global::GLMLOKDOEPB<TAction> where TStaticNetSysDeps : global::MFPGEPDJDLB<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface BDAOBHMDHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IOMBEPEDPDB(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NEEBPMMLAIH();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::OHFECDBHLHC<object, NPKBEKPOKML> OBKHCFNIAPL();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JOACAKCENPF(Exception AKCADADCFJN);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NLIIFLPMDBC : BDAOBHMDHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> LOKEANJFEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::OHFECDBHLHC<object, IOILPEPIEGB>> KNNNAPOPJFO;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3118310", Offset = "0x3117510", VA = "0x183118310")]
		private NLIIFLPMDBC(TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJHLJKEBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2350420", Offset = "0x234F620", VA = "0x182350420")]
		public static NLIIFLPMDBC GDHAFJANMPF(TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJHLJKEBAFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3118080", Offset = "0x3117280", VA = "0x183118080")]
		public void IOMBEPEDPDB(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3118180", Offset = "0x3117380", VA = "0x183118180", Slot = "5")]
		public void NEEBPMMLAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3118260", Offset = "0x3117460", VA = "0x183118260", Slot = "6")]
		public global::OHFECDBHLHC<object, NPKBEKPOKML> OBKHCFNIAPL()
		{
			return default(global::OHFECDBHLHC<object, NPKBEKPOKML>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3118120", Offset = "0x3117320", VA = "0x183118120", Slot = "7")]
		public void JOACAKCENPF(Exception AKCADADCFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x23505D0", Offset = "0x234F7D0", VA = "0x1823505D0", Slot = "4")]
		private void OGACGCACABD(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class KKBJFFFOAEM : BDAOBHMDHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> LOKEANJFEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private global::OHFECDBHLHC<object, NPKBEKPOKML> BPJOCMJIGHD;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1CD01B0", Offset = "0x1CCF3B0", VA = "0x181CD01B0")]
		private KKBJFFFOAEM(TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJHLJKEBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2350420", Offset = "0x234F620", VA = "0x182350420")]
		public static KKBJFFFOAEM GDHAFJANMPF(TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJHLJKEBAFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x23504F0", Offset = "0x234F6F0", VA = "0x1823504F0")]
		public void IOMBEPEDPDB(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2350570", Offset = "0x234F770", VA = "0x182350570", Slot = "5")]
		public void NEEBPMMLAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E8040", Offset = "0x6E7240", VA = "0x1806E8040", Slot = "6")]
		public global::OHFECDBHLHC<object, NPKBEKPOKML> OBKHCFNIAPL()
		{
			return default(global::OHFECDBHLHC<object, NPKBEKPOKML>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2350510", Offset = "0x234F710", VA = "0x182350510", Slot = "7")]
		public void JOACAKCENPF(Exception AKCADADCFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x23505D0", Offset = "0x234F7D0", VA = "0x1823505D0", Slot = "4")]
		private void OGACGCACABD(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class OEGAJHOGKHC : BDAOBHMDHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<global::OHFECDBHLHC<object, NPKBEKPOKML>> KNNNAPOPJFO;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3815AE0", Offset = "0x3814CE0", VA = "0x183815AE0")]
		private OEGAJHOGKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3041D60", Offset = "0x3040F60", VA = "0x183041D60")]
		public static OEGAJHOGKHC GDHAFJANMPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3815A20", Offset = "0x3814C20", VA = "0x183815A20")]
		public void IOMBEPEDPDB(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		public void NEEBPMMLAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3815A80", Offset = "0x3814C80", VA = "0x183815A80", Slot = "6")]
		public global::OHFECDBHLHC<object, NPKBEKPOKML> OBKHCFNIAPL()
		{
			return default(global::OHFECDBHLHC<object, NPKBEKPOKML>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
		public void JOACAKCENPF(Exception AKCADADCFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x23505D0", Offset = "0x234F7D0", VA = "0x1823505D0", Slot = "4")]
		private void OGACGCACABD(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class FNCAGBNJANC : BDAOBHMDHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private global::OHFECDBHLHC<object, NPKBEKPOKML> BPJOCMJIGHD;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		private FNCAGBNJANC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3041D60", Offset = "0x3040F60", VA = "0x183041D60")]
		public static FNCAGBNJANC GDHAFJANMPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x14062A0", Offset = "0x14054A0", VA = "0x1814062A0")]
		public void IOMBEPEDPDB(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		public void NEEBPMMLAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCCCFF0", Offset = "0xCCC1F0", VA = "0x180CCCFF0", Slot = "6")]
		public global::OHFECDBHLHC<object, NPKBEKPOKML> OBKHCFNIAPL()
		{
			return default(global::OHFECDBHLHC<object, NPKBEKPOKML>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "7")]
		public void JOACAKCENPF(Exception AKCADADCFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x23505D0", Offset = "0x234F7D0", VA = "0x1823505D0", Slot = "4")]
		private void OGACGCACABD(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ENJMBKJEGGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<global::OHFECDBHLHC<object, NPKBEKPOKML>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::IOJDDMIHILI<IBDPOCJOHKG> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public global::IOJDDMIHILI<GGICLPCGLOC> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<global::OHFECDBHLHC<object, NPKBEKPOKML>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1CF32B0", Offset = "0x1CF24B0", VA = "0x181CF32B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1CF3560", Offset = "0x1CF2760", VA = "0x181CF3560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HJGKHDCBIOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<global::OHFECDBHLHC<object, NPKBEKPOKML>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::IOJDDMIHILI<IBDPOCJOHKG> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public global::IOJDDMIHILI<GGICLPCGLOC> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private BDAOBHMDHNH <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2BE8EB0", Offset = "0x2BE80B0", VA = "0x182BE8EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BE9870", Offset = "0x2BE8A70", VA = "0x182BE9870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct AFKGFFBLNOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public BDAOBHMDHNH completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private BDAOBHMDHNH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<global::OHFECDBHLHC<object, NPKBEKPOKML>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD720", Offset = "0x2AAC920", VA = "0x182AAD720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6CF320", Offset = "0x6CE520", VA = "0x1806CF320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TActionReceiver BINKOJOBLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TActionDeps PINDPOOCJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TStaticNetSysDeps IBLKBNOFJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int DNCEPFJKDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int LDCDEEKHGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<global::IOJDDMIHILI<GGICLPCGLOC>, TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>>> MAMLMOIHKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private global::LDGPKJGIKBB<GGICLPCGLOC> BLADGJLFLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int AFHMLFIDEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task FDPOMAIKDDP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KPMLPINCGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76ACE0", Offset = "0x769EE0", VA = "0x18076ACE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76B490", Offset = "0x76A690", VA = "0x18076B490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32F2290", Offset = "0x32F1490", VA = "0x1832F2290")]
	protected GPHBPBOCDCO(TActionDeps MPBKKECLGHP, TStaticNetSysDeps POIILMOBKCM, int DKEMHCHHINN, int KPLKGOBDFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32F1B40", Offset = "0x32F0D40", VA = "0x1832F1B40")]
	public static global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> GDHAFJANMPF(TActionDeps MPBKKECLGHP, TStaticNetSysDeps POIILMOBKCM, [Optional] int? DKEMHCHHINN, [Optional] int? KPLKGOBDFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x32F1DC0", Offset = "0x32F0FC0", VA = "0x1832F1DC0")]
	public Task<global::OHFECDBHLHC<object, NPKBEKPOKML>> JILLBFEJHGO(in TAction GPNJNMLGIEN, bool HKEPEHPCOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32F19D0", Offset = "0x32F0BD0", VA = "0x1832F19D0")]
	public void DCCOMMDGIIL(in TActionReceiver EGIJMPKBLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32F19E0", Offset = "0x32F0BE0", VA = "0x1832F19E0")]
	[AsyncStateMachine(typeof(global::GPHBPBOCDCO<, , , >.ENJMBKJEGGP))]
	public Task<global::OHFECDBHLHC<object, NPKBEKPOKML>> FAGLKLPEJDH(global::IOJDDMIHILI<IBDPOCJOHKG> NOJAHDOHDIN, global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, TAction GPNJNMLGIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32F1860", Offset = "0x32F0A60", VA = "0x1832F1860")]
	[AsyncStateMachine(typeof(global::GPHBPBOCDCO<, , , >.HJGKHDCBIOB))]
	private Task<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJEOJLNAKGL(global::IOJDDMIHILI<IBDPOCJOHKG> NOJAHDOHDIN, global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, TAction GPNJNMLGIEN, Task ADJLGGKGFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32F1C80", Offset = "0x32F0E80", VA = "0x1832F1C80")]
	[AsyncStateMachine(typeof(global::GPHBPBOCDCO<, , , >.AFKGFFBLNOE))]
	private Task IGOFKODBIBL(TAction GPNJNMLGIEN, BDAOBHMDHNH JLKMOOIIHGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x32F2080", Offset = "0x32F1280", VA = "0x1832F2080")]
	private void MOPDAPOCEDC(TAction GPNJNMLGIEN, bool KLNCGOHHMMJ, bool JAJNBLFNKNM)
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
