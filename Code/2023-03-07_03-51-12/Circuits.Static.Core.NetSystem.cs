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
public interface BKEOFJAIIEH<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ONMBEPICJIN(TAction EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction DPENDEKMLLF(TAction EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction HCAEIKBBFPA(TAction EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> KECIOJIJKAG(TAction EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MELHBNHGAKL(TAction EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OHKHOEMPLPH(TAction EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LCGBMLFKAFG(TAction EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DHEMALIAHEF(TAction EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CHDHPBDBMDJ(TAction EFFJGLADCMH);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ELPIHIFLEMB<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::MKGFFLLANNG<PNFGGCGFAAE> GKFMDPCMKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int HDLFCEDENJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIFEFLJHDEN();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LDGIBHLIJEP(global::MKGFFLLANNG<NHCPBGGICCO> OOOKBBDPMIM, TAction EFFJGLADCMH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LPFJAFFLJFI<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MJACPDMLANH(in TPartialSnapshot HAAPDKJPLFK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot JEDGCHPIJJP(TPartialSnapshot[] NPFKPNFODBM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LEKLLGEGOLH<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult ADICAPMKHIC(TAction EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] MLBFEGNOMCN();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class PNFGGCGFAAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NHCPBGGICCO
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GMEHIGMPDPL<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::LPFJAFFLJFI<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] HAKEENDCMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int PFDEJDCHJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps PPHNDGGADPC;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x33A9570", Offset = "0x33A8970", VA = "0x1833A9570")]
	internal GMEHIGMPDPL(TPartialSnapshot[] ALEBBLFPPKE, int AIBHEOCLOHF, TDeps DNELEABCBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x33A94A0", Offset = "0x33A88A0", VA = "0x1833A94A0")]
	public static global::GMEHIGMPDPL<TPartialSnapshot, TFullSnapshot, TDeps> GEGCLDEHDAN(TDeps DNELEABCBIJ)
	{
		return default(global::GMEHIGMPDPL<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class INOFOKEPHBA
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3896F30", Offset = "0x3896330", VA = "0x183896F30")]
	public static global::ELIEDAPLHCP<TFullSnapshot> OLPHCIHKGOE<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::GMEHIGMPDPL<TPartialSnapshot, TFullSnapshot, TDeps> COBPFFJEBON, TPartialSnapshot HAAPDKJPLFK) where TDeps : global::LPFJAFFLJFI<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::ELIEDAPLHCP<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3896E50", Offset = "0x3896250", VA = "0x183896E50")]
	public static bool KHFFENFPFEG<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::GMEHIGMPDPL<TPartialSnapshot, TFullSnapshot, TDeps> COBPFFJEBON, TPartialSnapshot HAAPDKJPLFK) where TDeps : global::LPFJAFFLJFI<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LHFOBHKGEEL : IGAAKPFEHJP
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1A6F170", Offset = "0x1A6E570", VA = "0x181A6F170", Slot = "5")]
	public override string HPLBNLEOGCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1A6F1A0", Offset = "0x1A6E5A0", VA = "0x181A6F1A0")]
	public LHFOBHKGEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EHCIGMNEMGK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::LEKLLGEGOLH<TAction, Task<global::DPAEKNFIIFN<object, IGAAKPFEHJP>>> where TActionDeps : global::BKEOFJAIIEH<TAction> where TStaticNetSysDeps : global::ELPIHIFLEMB<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface MMOJHEMOMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GNNABIEMGOG(in global::DPAEKNFIIFN<object, IGAAKPFEHJP> CGKNIAMFPAO);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PLIMGPJINHP();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::DPAEKNFIIFN<object, IGAAKPFEHJP> CFOHHALLKMM();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LDDCCCOOHBH(Exception ODLBKMKCIIL);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class BFPGCDCMOCN : MMOJHEMOMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> APFCMNOHAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::DPAEKNFIIFN<object, GKAEBCMEFAL>> AMCFHFIFONI;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x31D0510", Offset = "0x31CF910", VA = "0x1831D0510")]
		private BFPGCDCMOCN(TaskCompletionSource<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> CEDOJDMLLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x31D0230", Offset = "0x31CF630", VA = "0x1831D0230")]
		public static BFPGCDCMOCN GEGCLDEHDAN(TaskCompletionSource<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> CEDOJDMLLLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x31D0300", Offset = "0x31CF700", VA = "0x1831D0300")]
		public void GNNABIEMGOG(in global::DPAEKNFIIFN<object, IGAAKPFEHJP> CGKNIAMFPAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x31D0430", Offset = "0x31CF830", VA = "0x1831D0430", Slot = "5")]
		public void PLIMGPJINHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x31D0180", Offset = "0x31CF580", VA = "0x1831D0180", Slot = "6")]
		public global::DPAEKNFIIFN<object, IGAAKPFEHJP> CFOHHALLKMM()
		{
			return default(global::DPAEKNFIIFN<object, IGAAKPFEHJP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x31D03A0", Offset = "0x31CF7A0", VA = "0x1831D03A0", Slot = "7")]
		public void LDDCCCOOHBH(Exception ODLBKMKCIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x31D0400", Offset = "0x31CF800", VA = "0x1831D0400", Slot = "4")]
		private void MKGAFCIIMME(in global::DPAEKNFIIFN<object, IGAAKPFEHJP> CGKNIAMFPAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class JGMIEICIEEC : MMOJHEMOMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> APFCMNOHAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private global::DPAEKNFIIFN<object, IGAAKPFEHJP> ICDEKHJAKIH;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x280B190", Offset = "0x280A590", VA = "0x18280B190")]
		private JGMIEICIEEC(TaskCompletionSource<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> CEDOJDMLLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x31D0230", Offset = "0x31CF630", VA = "0x1831D0230")]
		public static JGMIEICIEEC GEGCLDEHDAN(TaskCompletionSource<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> CEDOJDMLLLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x328AC10", Offset = "0x328A010", VA = "0x18328AC10")]
		public void GNNABIEMGOG(in global::DPAEKNFIIFN<object, IGAAKPFEHJP> CGKNIAMFPAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x328AC90", Offset = "0x328A090", VA = "0x18328AC90", Slot = "5")]
		public void PLIMGPJINHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0", Slot = "6")]
		public global::DPAEKNFIIFN<object, IGAAKPFEHJP> CFOHHALLKMM()
		{
			return default(global::DPAEKNFIIFN<object, IGAAKPFEHJP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x328AC30", Offset = "0x328A030", VA = "0x18328AC30", Slot = "7")]
		public void LDDCCCOOHBH(Exception ODLBKMKCIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x31D0400", Offset = "0x31CF800", VA = "0x1831D0400", Slot = "4")]
		private void MKGAFCIIMME(in global::DPAEKNFIIFN<object, IGAAKPFEHJP> CGKNIAMFPAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class MIODFDCALOD : MMOJHEMOMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> AMCFHFIFONI;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x380FB10", Offset = "0x380EF10", VA = "0x18380FB10")]
		private MIODFDCALOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x380F9F0", Offset = "0x380EDF0", VA = "0x18380F9F0")]
		public static MIODFDCALOD GEGCLDEHDAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x380FAB0", Offset = "0x380EEB0", VA = "0x18380FAB0")]
		public void GNNABIEMGOG(in global::DPAEKNFIIFN<object, IGAAKPFEHJP> CGKNIAMFPAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		public void PLIMGPJINHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x380F990", Offset = "0x380ED90", VA = "0x18380F990", Slot = "6")]
		public global::DPAEKNFIIFN<object, IGAAKPFEHJP> CFOHHALLKMM()
		{
			return default(global::DPAEKNFIIFN<object, IGAAKPFEHJP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
		public void LDDCCCOOHBH(Exception ODLBKMKCIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x31D0400", Offset = "0x31CF800", VA = "0x1831D0400", Slot = "4")]
		private void MKGAFCIIMME(in global::DPAEKNFIIFN<object, IGAAKPFEHJP> CGKNIAMFPAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class LNPFNHOEMCA : MMOJHEMOMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private global::DPAEKNFIIFN<object, IGAAKPFEHJP> ICDEKHJAKIH;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		private LNPFNHOEMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x380F9F0", Offset = "0x380EDF0", VA = "0x18380F9F0")]
		public static LNPFNHOEMCA GEGCLDEHDAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81B5A0", Offset = "0x81A9A0", VA = "0x18081B5A0")]
		public void GNNABIEMGOG(in global::DPAEKNFIIFN<object, IGAAKPFEHJP> CGKNIAMFPAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		public void PLIMGPJINHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2A0", Offset = "0x7ED6A0", VA = "0x1807EE2A0", Slot = "6")]
		public global::DPAEKNFIIFN<object, IGAAKPFEHJP> CFOHHALLKMM()
		{
			return default(global::DPAEKNFIIFN<object, IGAAKPFEHJP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
		public void LDDCCCOOHBH(Exception ODLBKMKCIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x31D0400", Offset = "0x31CF800", VA = "0x1831D0400", Slot = "4")]
		private void MKGAFCIIMME(in global::DPAEKNFIIFN<object, IGAAKPFEHJP> CGKNIAMFPAO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DAPNNNCLDMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::EHCIGMNEMGK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::MKGFFLLANNG<PNFGGCGFAAE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public global::MKGFFLLANNG<NHCPBGGICCO> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x35038D0", Offset = "0x3502CD0", VA = "0x1835038D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3503B80", Offset = "0x3502F80", VA = "0x183503B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CGEPMHGKAKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public global::EHCIGMNEMGK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::MKGFFLLANNG<PNFGGCGFAAE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public global::MKGFFLLANNG<NHCPBGGICCO> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MMOJHEMOMIL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B764C0", Offset = "0x3B758C0", VA = "0x183B764C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3B76E80", Offset = "0x3B76280", VA = "0x183B76E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct MBNCAGDJJKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public global::EHCIGMNEMGK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public MMOJHEMOMIL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private MMOJHEMOMIL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E631D0", Offset = "0x3E625D0", VA = "0x183E631D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TActionReceiver BLFMLMIHBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TActionDeps HDNBNFMOIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TStaticNetSysDeps KGGPLLKKIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int EODEGGFNGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int LMHHFHNOILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<global::MKGFFLLANNG<NHCPBGGICCO>, TaskCompletionSource<global::DPAEKNFIIFN<object, IGAAKPFEHJP>>> NNDPEFBBFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private global::ALFIOIEEBGE<NHCPBGGICCO> HBEONHHHLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int PCPICNBKAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task GADNKAIOBMD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PHPOFLOBEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA9E510", Offset = "0xA9D910", VA = "0x180A9E510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x761570", Offset = "0x760970", VA = "0x180761570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B321E0", Offset = "0x3B315E0", VA = "0x183B321E0")]
	protected EHCIGMNEMGK(TActionDeps PFPFGJJHBFI, TStaticNetSysDeps CFMLBMIEFAB, int HFMECMKLADC, int GJFLHNHBPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B31A10", Offset = "0x3B30E10", VA = "0x183B31A10")]
	public static global::EHCIGMNEMGK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> GEGCLDEHDAN(TActionDeps PFPFGJJHBFI, TStaticNetSysDeps CFMLBMIEFAB, [Optional] int? HFMECMKLADC, [Optional] int? GJFLHNHBPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B31CA0", Offset = "0x3B310A0", VA = "0x183B31CA0")]
	public Task<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> LDGIBHLIJEP(in TAction EFFJGLADCMH, bool KJCDDHNCOPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B31C90", Offset = "0x3B31090", VA = "0x183B31C90")]
	public void JOFBDNMCKIM(in TActionReceiver PJGJKGCIKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3B31740", Offset = "0x3B30B40", VA = "0x183B31740")]
	[AsyncStateMachine(typeof(global::EHCIGMNEMGK<, , , >.DAPNNNCLDMI))]
	public Task<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> ADICAPMKHIC(global::MKGFFLLANNG<PNFGGCGFAAE> HBEOHAENGAI, global::MKGFFLLANNG<NHCPBGGICCO> OOOKBBDPMIM, TAction EFFJGLADCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B318A0", Offset = "0x3B30CA0", VA = "0x183B318A0")]
	[AsyncStateMachine(typeof(global::EHCIGMNEMGK<, , , >.CGEPMHGKAKE))]
	private Task<global::DPAEKNFIIFN<object, IGAAKPFEHJP>> FMIGCHDHJKI(global::MKGFFLLANNG<PNFGGCGFAAE> HBEOHAENGAI, global::MKGFFLLANNG<NHCPBGGICCO> OOOKBBDPMIM, TAction EFFJGLADCMH, Task BEGIOKJNIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B31B50", Offset = "0x3B30F50", VA = "0x183B31B50")]
	[AsyncStateMachine(typeof(global::EHCIGMNEMGK<, , , >.MBNCAGDJJKO))]
	private Task GJKNMHMCPPF(TAction EFFJGLADCMH, MMOJHEMOMIL HEMJJBGFCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3B31FD0", Offset = "0x3B313D0", VA = "0x183B31FD0")]
	private void MHLJOPILFOL(TAction EFFJGLADCMH, bool JEDEMHCFPHE, bool OCMMNEEJPOL)
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
