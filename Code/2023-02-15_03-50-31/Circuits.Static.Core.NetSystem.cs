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
	[Cpp2IlInjected.Address(RVA = "0x30E0020", Offset = "0x30DF420", VA = "0x1830E0020")]
	internal KJOKPBFJIIM(TPartialSnapshot[] LOAAFEIPPIN, int NMCGGPCDGOE, TDeps IAPGLFJKDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x30DFFC0", Offset = "0x30DF3C0", VA = "0x1830DFFC0")]
	public static global::KJOKPBFJIIM<TPartialSnapshot, TFullSnapshot, TDeps> GDHAFJANMPF(TDeps IAPGLFJKDEF)
	{
		return default(global::KJOKPBFJIIM<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LGKNMOOAIHI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2878070", Offset = "0x2877470", VA = "0x182878070")]
	public static global::MBPMAHFIKHD<TFullSnapshot> BFNMBNCONIJ<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::KJOKPBFJIIM<TPartialSnapshot, TFullSnapshot, TDeps> PKCJMFFNILJ, TPartialSnapshot NJKIPCBEEFF) where TDeps : global::ILNBHOKGAOA<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::MBPMAHFIKHD<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28783B0", Offset = "0x28777B0", VA = "0x1828783B0")]
	public static bool PADOPFMBKDK<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::KJOKPBFJIIM<TPartialSnapshot, TFullSnapshot, TDeps> PKCJMFFNILJ, TPartialSnapshot NJKIPCBEEFF) where TDeps : global::ILNBHOKGAOA<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class EPKNNHPCJIP : NPKBEKPOKML
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64A7EC0", Offset = "0x64A72C0", VA = "0x1864A7EC0", Slot = "5")]
	public override string PPGCJLLFOLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC150", Offset = "0x2AFB550", VA = "0x182AFC150")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B34E20", Offset = "0x3B34220", VA = "0x183B34E20")]
		private NLIIFLPMDBC(TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJHLJKEBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x29B39D0", Offset = "0x29B2DD0", VA = "0x1829B39D0")]
		public static NLIIFLPMDBC GDHAFJANMPF(TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJHLJKEBAFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B34B90", Offset = "0x3B33F90", VA = "0x183B34B90")]
		public void IOMBEPEDPDB(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3B34C90", Offset = "0x3B34090", VA = "0x183B34C90", Slot = "5")]
		public void NEEBPMMLAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3B34D70", Offset = "0x3B34170", VA = "0x183B34D70", Slot = "6")]
		public global::OHFECDBHLHC<object, NPKBEKPOKML> OBKHCFNIAPL()
		{
			return default(global::OHFECDBHLHC<object, NPKBEKPOKML>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3B34C30", Offset = "0x3B34030", VA = "0x183B34C30", Slot = "7")]
		public void JOACAKCENPF(Exception AKCADADCFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2600", Offset = "0x2DC1A00", VA = "0x182DC2600", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B7F450", Offset = "0x2B7E850", VA = "0x182B7F450")]
		private KKBJFFFOAEM(TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJHLJKEBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x29B39D0", Offset = "0x29B2DD0", VA = "0x1829B39D0")]
		public static KKBJFFFOAEM GDHAFJANMPF(TaskCompletionSource<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJHLJKEBAFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F30", Offset = "0x7C6330", VA = "0x1807C6F30")]
		public void IOMBEPEDPDB(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x30E00C0", Offset = "0x30DF4C0", VA = "0x1830E00C0", Slot = "5")]
		public void NEEBPMMLAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x760C90", Offset = "0x760090", VA = "0x180760C90", Slot = "6")]
		public global::OHFECDBHLHC<object, NPKBEKPOKML> OBKHCFNIAPL()
		{
			return default(global::OHFECDBHLHC<object, NPKBEKPOKML>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x30E0060", Offset = "0x30DF460", VA = "0x1830E0060", Slot = "7")]
		public void JOACAKCENPF(Exception AKCADADCFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2600", Offset = "0x2DC1A00", VA = "0x182DC2600", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x415C260", Offset = "0x415B660", VA = "0x18415C260")]
		private OEGAJHOGKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x30097A0", Offset = "0x3008BA0", VA = "0x1830097A0")]
		public static OEGAJHOGKHC GDHAFJANMPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x415C1A0", Offset = "0x415B5A0", VA = "0x18415C1A0")]
		public void IOMBEPEDPDB(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		public void NEEBPMMLAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x415C200", Offset = "0x415B600", VA = "0x18415C200", Slot = "6")]
		public global::OHFECDBHLHC<object, NPKBEKPOKML> OBKHCFNIAPL()
		{
			return default(global::OHFECDBHLHC<object, NPKBEKPOKML>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
		public void JOACAKCENPF(Exception AKCADADCFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2600", Offset = "0x2DC1A00", VA = "0x182DC2600", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		private FNCAGBNJANC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x30097A0", Offset = "0x3008BA0", VA = "0x1830097A0")]
		public static FNCAGBNJANC GDHAFJANMPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x752FF0", Offset = "0x7523F0", VA = "0x180752FF0")]
		public void IOMBEPEDPDB(in global::OHFECDBHLHC<object, NPKBEKPOKML> APCBFLNDMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		public void NEEBPMMLAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90", Slot = "6")]
		public global::OHFECDBHLHC<object, NPKBEKPOKML> OBKHCFNIAPL()
		{
			return default(global::OHFECDBHLHC<object, NPKBEKPOKML>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "7")]
		public void JOACAKCENPF(Exception AKCADADCFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2600", Offset = "0x2DC1A00", VA = "0x182DC2600", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3675F60", Offset = "0x3675360", VA = "0x183675F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3676210", Offset = "0x3675610", VA = "0x183676210", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x31C7450", Offset = "0x31C6850", VA = "0x1831C7450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x31C7E10", Offset = "0x31C7210", VA = "0x1831C7E10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33E18A0", Offset = "0x33E0CA0", VA = "0x1833E18A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x950210", Offset = "0x94F610", VA = "0x180950210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9509A0", Offset = "0x94FDA0", VA = "0x1809509A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4099AB0", Offset = "0x4098EB0", VA = "0x184099AB0")]
	protected GPHBPBOCDCO(TActionDeps MPBKKECLGHP, TStaticNetSysDeps POIILMOBKCM, int DKEMHCHHINN, int KPLKGOBDFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4099360", Offset = "0x4098760", VA = "0x184099360")]
	public static global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> GDHAFJANMPF(TActionDeps MPBKKECLGHP, TStaticNetSysDeps POIILMOBKCM, [Optional] int? DKEMHCHHINN, [Optional] int? KPLKGOBDFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x40995E0", Offset = "0x40989E0", VA = "0x1840995E0")]
	public Task<global::OHFECDBHLHC<object, NPKBEKPOKML>> JILLBFEJHGO(in TAction GPNJNMLGIEN, bool HKEPEHPCOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x40991F0", Offset = "0x40985F0", VA = "0x1840991F0")]
	public void DCCOMMDGIIL(in TActionReceiver EGIJMPKBLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4099200", Offset = "0x4098600", VA = "0x184099200")]
	[AsyncStateMachine(typeof(global::GPHBPBOCDCO<, , , >.ENJMBKJEGGP))]
	public Task<global::OHFECDBHLHC<object, NPKBEKPOKML>> FAGLKLPEJDH(global::IOJDDMIHILI<IBDPOCJOHKG> NOJAHDOHDIN, global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, TAction GPNJNMLGIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4099080", Offset = "0x4098480", VA = "0x184099080")]
	[AsyncStateMachine(typeof(global::GPHBPBOCDCO<, , , >.HJGKHDCBIOB))]
	private Task<global::OHFECDBHLHC<object, NPKBEKPOKML>> CJEOJLNAKGL(global::IOJDDMIHILI<IBDPOCJOHKG> NOJAHDOHDIN, global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, TAction GPNJNMLGIEN, Task ADJLGGKGFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x40994A0", Offset = "0x40988A0", VA = "0x1840994A0")]
	[AsyncStateMachine(typeof(global::GPHBPBOCDCO<, , , >.AFKGFFBLNOE))]
	private Task IGOFKODBIBL(TAction GPNJNMLGIEN, BDAOBHMDHNH JLKMOOIIHGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x40998A0", Offset = "0x4098CA0", VA = "0x1840998A0")]
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
