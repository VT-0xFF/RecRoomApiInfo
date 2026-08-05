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
public interface NDEOHAHCJCG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LEMIOCJKJPN(in TAction MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction HBKGGFEEIFF(in TAction MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction IDCMOLHELAJ(in TAction MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> KGJBEJCKFPL(in TAction MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BDKALLIONGI(in TAction MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JOLEHNGDELA(in TAction MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IMFAOAGLMLP(in TAction MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HLBBEFFPHOF(in TAction MJHIGMCCOPA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PPHCGKBDNJF(in TAction MJHIGMCCOPA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FMJKPPOHNAD<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::LLEDGLIPIFE<DJNHAKHMLEM> NPGPCKIPPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJIDANCLDIA();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLDEAPOEMPP(in global::LLEDGLIPIFE<FKFGIOHEKCI> PGEOIOKCFAK, in TAction MJHIGMCCOPA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KOHNHMJJAAO<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BABHFLEGIDG(TPartialSnapshot NBNCFBGGEOO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot LFKEFFBDMLJ(TPartialSnapshot[] LHAEGKIOPPC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DJNHAKHMLEM
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class FKFGIOHEKCI
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IANHGEHMGLP<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::CMIJIIMELID<TAction, Task<global::BLBLJBFHAIG<object, KCPABLLBBLD>>, TActionReceiver> where TActionReceiver : global::BLBNBFBEILM<TAction, Task<global::BLBLJBFHAIG<object, KCPABLLBBLD>>> where TActionDeps : global::NDEOHAHCJCG<TAction> where TStaticNetSysDeps : global::FMJKPPOHNAD<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private interface PHNGGIIPFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EBMKAMMPLEC(in global::BLBLJBFHAIG<object, KCPABLLBBLD> FNPLEFBJGJC);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LIDEAEGJCKD();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::BLBLJBFHAIG<object, KCPABLLBBLD> DHLPGFPENHL();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ICNOLKCJAPK(Exception BMHFAHACLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class PJHDCIEPJNI : PHNGGIIPFMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::BLBLJBFHAIG<object, KCPABLLBBLD>> BINPLCODGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::BLBLJBFHAIG<object, KCPABLLBBLD>> HHOCODACAHF;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x536A230", Offset = "0x5368A30", VA = "0x18536A230")]
		private PJHDCIEPJNI(TaskCompletionSource<global::BLBLJBFHAIG<object, KCPABLLBBLD>> EPIMOIACNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE2C610", Offset = "0xE2AE10", VA = "0x180E2C610")]
		public static PJHDCIEPJNI DKPJNJAIMAF(TaskCompletionSource<global::BLBLJBFHAIG<object, KCPABLLBBLD>> EPIMOIACNCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x536A0B0", Offset = "0x53688B0", VA = "0x18536A0B0")]
		public void EBMKAMMPLEC(in global::BLBLJBFHAIG<object, KCPABLLBBLD> FNPLEFBJGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x536A170", Offset = "0x5368970", VA = "0x18536A170", Slot = "5")]
		public void LIDEAEGJCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x536A010", Offset = "0x5368810", VA = "0x18536A010", Slot = "6")]
		public global::BLBLJBFHAIG<object, KCPABLLBBLD> DHLPGFPENHL()
		{
			return default(global::BLBLJBFHAIG<object, KCPABLLBBLD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x536A110", Offset = "0x5368910", VA = "0x18536A110", Slot = "7")]
		public void ICNOLKCJAPK(Exception BMHFAHACLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0E40", Offset = "0x2DEF640", VA = "0x182DF0E40", Slot = "4")]
		private void GDJFMLBCKPN(in global::BLBLJBFHAIG<object, KCPABLLBBLD> FNPLEFBJGJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class KAFPFKKFJBM : PHNGGIIPFMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::BLBLJBFHAIG<object, KCPABLLBBLD>> BINPLCODGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::BLBLJBFHAIG<object, KCPABLLBBLD> IFOIBJCELDI;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xE2F290", Offset = "0xE2DA90", VA = "0x180E2F290")]
		private KAFPFKKFJBM(TaskCompletionSource<global::BLBLJBFHAIG<object, KCPABLLBBLD>> EPIMOIACNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE2C610", Offset = "0xE2AE10", VA = "0x180E2C610")]
		public static KAFPFKKFJBM DKPJNJAIMAF(TaskCompletionSource<global::BLBLJBFHAIG<object, KCPABLLBBLD>> EPIMOIACNCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE52EF0", Offset = "0xE516F0", VA = "0x180E52EF0")]
		public void EBMKAMMPLEC(in global::BLBLJBFHAIG<object, KCPABLLBBLD> FNPLEFBJGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5363EC0", Offset = "0x53626C0", VA = "0x185363EC0", Slot = "5")]
		public void LIDEAEGJCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570", Slot = "6")]
		public global::BLBLJBFHAIG<object, KCPABLLBBLD> DHLPGFPENHL()
		{
			return default(global::BLBLJBFHAIG<object, KCPABLLBBLD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5363E60", Offset = "0x5362660", VA = "0x185363E60", Slot = "7")]
		public void ICNOLKCJAPK(Exception BMHFAHACLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0E40", Offset = "0x2DEF640", VA = "0x182DF0E40", Slot = "4")]
		private void GDJFMLBCKPN(in global::BLBLJBFHAIG<object, KCPABLLBBLD> FNPLEFBJGJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class IJKNOOBGOAB : PHNGGIIPFMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::BLBLJBFHAIG<object, KCPABLLBBLD>> HHOCODACAHF;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5363D20", Offset = "0x5362520", VA = "0x185363D20")]
		private IJKNOOBGOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x53588E0", Offset = "0x53570E0", VA = "0x1853588E0")]
		public static IJKNOOBGOAB DKPJNJAIMAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5363CC0", Offset = "0x53624C0", VA = "0x185363CC0")]
		public void EBMKAMMPLEC(in global::BLBLJBFHAIG<object, KCPABLLBBLD> FNPLEFBJGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		public void LIDEAEGJCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5363C60", Offset = "0x5362460", VA = "0x185363C60", Slot = "6")]
		public global::BLBLJBFHAIG<object, KCPABLLBBLD> DHLPGFPENHL()
		{
			return default(global::BLBLJBFHAIG<object, KCPABLLBBLD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		public void ICNOLKCJAPK(Exception BMHFAHACLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0E40", Offset = "0x2DEF640", VA = "0x182DF0E40", Slot = "4")]
		private void GDJFMLBCKPN(in global::BLBLJBFHAIG<object, KCPABLLBBLD> FNPLEFBJGJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class DGLNLAJEIHN : PHNGGIIPFMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::BLBLJBFHAIG<object, KCPABLLBBLD> IFOIBJCELDI;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		private DGLNLAJEIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x53588E0", Offset = "0x53570E0", VA = "0x1853588E0")]
		public static DGLNLAJEIHN DKPJNJAIMAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC60", Offset = "0x6AA460", VA = "0x1806ABC60")]
		public void EBMKAMMPLEC(in global::BLBLJBFHAIG<object, KCPABLLBBLD> FNPLEFBJGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		public void LIDEAEGJCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEC0", Offset = "0x6AA6C0", VA = "0x1806ABEC0", Slot = "6")]
		public global::BLBLJBFHAIG<object, KCPABLLBBLD> DHLPGFPENHL()
		{
			return default(global::BLBLJBFHAIG<object, KCPABLLBBLD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		public void ICNOLKCJAPK(Exception BMHFAHACLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0E40", Offset = "0x2DEF640", VA = "0x182DF0E40", Slot = "4")]
		private void GDJFMLBCKPN(in global::BLBLJBFHAIG<object, KCPABLLBBLD> FNPLEFBJGJC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FELGEGEBCCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::BLBLJBFHAIG<object, KCPABLLBBLD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::IANHGEHMGLP<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::LLEDGLIPIFE<DJNHAKHMLEM> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::LLEDGLIPIFE<FKFGIOHEKCI> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::BLBLJBFHAIG<object, KCPABLLBBLD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5359510", Offset = "0x5357D10", VA = "0x185359510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5359790", Offset = "0x5357F90", VA = "0x185359790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DECAFFHDNHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::BLBLJBFHAIG<object, KCPABLLBBLD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::IANHGEHMGLP<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::LLEDGLIPIFE<DJNHAKHMLEM> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::LLEDGLIPIFE<FKFGIOHEKCI> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private PHNGGIIPFMH <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5358100", Offset = "0x5356900", VA = "0x185358100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5358890", Offset = "0x5357090", VA = "0x185358890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FPKCOIIGGPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::IANHGEHMGLP<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public PHNGGIIPFMH completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PHNGGIIPFMH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::BLBLJBFHAIG<object, KCPABLLBBLD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x535AD40", Offset = "0x5359540", VA = "0x18535AD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x814BA0", Offset = "0x8133A0", VA = "0x180814BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver BBDCNIDAIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps BBPBKODHJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps CABOMDAGPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int PEDPCINDLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int ADCGMCHJLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::LLEDGLIPIFE<FKFGIOHEKCI>, TaskCompletionSource<global::BLBLJBFHAIG<object, KCPABLLBBLD>>> KHCGGPNGGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::PPPBKELCOGF<FKFGIOHEKCI> BFEHGPOKOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool MPKNICCCDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int FGCFDPIPEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task NBOEGEDBLBO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x535D9B0", Offset = "0x535C1B0", VA = "0x18535D9B0")]
	protected IANHGEHMGLP(TActionDeps IFPOHPMMOCE, TStaticNetSysDeps MKJLGDAMGNF, int FIHIBGALAIL, int IOMOOOCMNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x535CF60", Offset = "0x535B760", VA = "0x18535CF60")]
	public static global::IANHGEHMGLP<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> DKPJNJAIMAF(TActionDeps IFPOHPMMOCE, TStaticNetSysDeps MKJLGDAMGNF, [Optional] int? FIHIBGALAIL, [Optional] int? IOMOOOCMNNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x535D1F0", Offset = "0x535B9F0", VA = "0x18535D1F0")]
	public Task<global::BLBLJBFHAIG<object, KCPABLLBBLD>> GLDEAPOEMPP(in TAction MJHIGMCCOPA, bool MKGHGPEHCPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x535D090", Offset = "0x535B890", VA = "0x18535D090")]
	public void EKFHKILHBCL(in TActionReceiver PKOIBPKJDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x535D0A0", Offset = "0x535B8A0", VA = "0x18535D0A0")]
	[AsyncStateMachine(typeof(global::IANHGEHMGLP<, , , >.FELGEGEBCCF))]
	public Task<global::BLBLJBFHAIG<object, KCPABLLBBLD>> GGHGEAOKEOP(global::LLEDGLIPIFE<DJNHAKHMLEM> BLIBBDMMEKO, global::LLEDGLIPIFE<FKFGIOHEKCI> PGEOIOKCFAK, TAction MJHIGMCCOPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x535D4F0", Offset = "0x535BCF0", VA = "0x18535D4F0")]
	[AsyncStateMachine(typeof(global::IANHGEHMGLP<, , , >.DECAFFHDNHN))]
	private Task<global::BLBLJBFHAIG<object, KCPABLLBBLD>> JKKCHGDKPEK(global::LLEDGLIPIFE<DJNHAKHMLEM> BLIBBDMMEKO, global::LLEDGLIPIFE<FKFGIOHEKCI> PGEOIOKCFAK, TAction MJHIGMCCOPA, Task FPADGKLPLND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x535D640", Offset = "0x535BE40", VA = "0x18535D640")]
	[AsyncStateMachine(typeof(global::IANHGEHMGLP<, , , >.FPKCOIIGGPF))]
	private Task JOKLPIEPEKG(TAction MJHIGMCCOPA, PHNGGIIPFMH HPAIDMJFNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x535D790", Offset = "0x535BF90", VA = "0x18535D790")]
	private void NIDIGPHNGID(TAction MJHIGMCCOPA, bool MMHEOGPPNBF, bool HCLLCPKENIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x50FC4F0", Offset = "0x50FACF0", VA = "0x1850FC4F0", Slot = "4")]
	private Task<global::BLBLJBFHAIG<object, KCPABLLBBLD>> FCLBMOADOLJ(in TAction MJHIGMCCOPA, bool MKGHGPEHCPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OONGLILPCPE<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::KOHNHMJJAAO<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] KFFJEFPEHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int HHOMDHCBNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps HPGIALJFKFL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x586BA20", Offset = "0x586A220", VA = "0x18586BA20")]
	internal OONGLILPCPE(TPartialSnapshot[] BIPLGHJBKGG, int OPIKOALAKLO, TDeps GHKOJEPNLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x586B590", Offset = "0x5869D90", VA = "0x18586B590")]
	public global::LMIAMFMFOHF<TFullSnapshot> GOAAMGNOGKF(TPartialSnapshot NBNCFBGGEOO)
	{
		return default(global::LMIAMFMFOHF<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x586B540", Offset = "0x5869D40", VA = "0x18586B540")]
	public bool GGFGJHBGJBN(TPartialSnapshot NBNCFBGGEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x586B3A0", Offset = "0x5869BA0", VA = "0x18586B3A0")]
	public static global::OONGLILPCPE<TPartialSnapshot, TFullSnapshot, TDeps> DKPJNJAIMAF(TDeps GHKOJEPNLEK)
	{
		return default(global::OONGLILPCPE<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LLALPAFKLDK : KCPABLLBBLD
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x421DFB0", Offset = "0x421C7B0", VA = "0x18421DFB0", Slot = "5")]
	public override string DHDHDAOGBCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x41F75C0", Offset = "0x41F5DC0", VA = "0x1841F75C0")]
	private LLALPAFKLDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4F48F70", Offset = "0x4F47770", VA = "0x184F48F70")]
	public static global::BLBLJBFHAIG<TOk, KCPABLLBBLD> DKPJNJAIMAF<TOk>()
	{
		return default(global::BLBLJBFHAIG<TOk, KCPABLLBBLD>);
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
