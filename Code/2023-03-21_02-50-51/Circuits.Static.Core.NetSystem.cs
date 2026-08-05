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
public interface FPOHMACHGHF<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GGNBKEELMGM(TAction BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction CFIICIFLBGB(TAction BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction OBBJIGFCKAF(TAction BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> COEAFBJJLCB(TAction BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BLNCJEICLBN(TAction BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PLMHMDHJFED(TAction BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DNLBIOAHBPP(TAction BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BMDKIGGALJA(TAction BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HNKLJOJPACE(TAction BEHJPKINPFB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LCPGOOKKMEA<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::DKJLBCAIGHC<JCCBLIBFBHJ> HKMFPNBEJHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int HEHHDILPANE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOMLFLKJAPP();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAOENBBPGHO(global::DKJLBCAIGHC<LJKOFEGPGAA> GLGBEAFMMEG, TAction BEHJPKINPFB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HEEHNOAJHBG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JLBNCICAAOH(in TPartialSnapshot BCFDNKCLOCI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot AGDOCOFJPIA(TPartialSnapshot[] LBAEFFAMOMM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BPGMLMJKPDK<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult KCOLKKDDFCC(TAction BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] CEOAEFOMECO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JCCBLIBFBHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LJKOFEGPGAA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MBCBEONKMBN<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::HEEHNOAJHBG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] GHJOJCKDIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int PDPKJJNMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps BDHFHIDFEEB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2D98CD0", Offset = "0x2D974D0", VA = "0x182D98CD0")]
	internal MBCBEONKMBN(TPartialSnapshot[] NGBLCOOBCEO, int MHMILCADMKD, TDeps JIFFNOBMAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2D98C00", Offset = "0x2D97400", VA = "0x182D98C00")]
	public static global::MBCBEONKMBN<TPartialSnapshot, TFullSnapshot, TDeps> HHEHBEMBBBF(TDeps JIFFNOBMAPO)
	{
		return default(global::MBCBEONKMBN<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NPLDPIHMGKC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x35EE230", Offset = "0x35ECA30", VA = "0x1835EE230")]
	public static global::PLKADEAGMGD<TFullSnapshot> IKAFJAMBHHL<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::MBCBEONKMBN<TPartialSnapshot, TFullSnapshot, TDeps> DCJNPPINKOA, TPartialSnapshot BCFDNKCLOCI) where TDeps : global::HEEHNOAJHBG<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::PLKADEAGMGD<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x35EE150", Offset = "0x35EC950", VA = "0x1835EE150")]
	public static bool GBEBOEKFKLE<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::MBCBEONKMBN<TPartialSnapshot, TFullSnapshot, TDeps> DCJNPPINKOA, TPartialSnapshot BCFDNKCLOCI) where TDeps : global::HEEHNOAJHBG<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class MIAFKOAFCHN : IOEHGADFNAP
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xEA2380", Offset = "0xEA0B80", VA = "0x180EA2380", Slot = "5")]
	public override string NNBNGPPOEHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xEA23B0", Offset = "0xEA0BB0", VA = "0x180EA23B0")]
	public MIAFKOAFCHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MEAGHEPCDLH<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::BPGMLMJKPDK<TAction, Task<global::IMDNOFMHNPP<object, IOEHGADFNAP>>> where TActionDeps : global::FPOHMACHGHF<TAction> where TStaticNetSysDeps : global::LCPGOOKKMEA<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface MGEPKCMDGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CAIMLMIADCE(in global::IMDNOFMHNPP<object, IOEHGADFNAP> KGFIMLECODA);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FPABLHOEAGB();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::IMDNOFMHNPP<object, IOEHGADFNAP> NLCJCJENOML();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EGPHDBNPHNE(Exception OKIPNJPPODK);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class IGBMBEEHIHK : MGEPKCMDGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<global::IMDNOFMHNPP<object, IOEHGADFNAP>> PMKAIFBAPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::IMDNOFMHNPP<object, JGDNADHAHMP>> PAKPAAPMPBH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1811BA0", Offset = "0x18103A0", VA = "0x181811BA0")]
		private IGBMBEEHIHK(TaskCompletionSource<global::IMDNOFMHNPP<object, IOEHGADFNAP>> BIMAJFMDPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x18119F0", Offset = "0x18101F0", VA = "0x1818119F0")]
		public static IGBMBEEHIHK HHEHBEMBBBF(TaskCompletionSource<global::IMDNOFMHNPP<object, IOEHGADFNAP>> BIMAJFMDPAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1811810", Offset = "0x1810010", VA = "0x181811810")]
		public void CAIMLMIADCE(in global::IMDNOFMHNPP<object, IOEHGADFNAP> KGFIMLECODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1811910", Offset = "0x1810110", VA = "0x181811910", Slot = "5")]
		public void FPABLHOEAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1811AF0", Offset = "0x18102F0", VA = "0x181811AF0", Slot = "6")]
		public global::IMDNOFMHNPP<object, IOEHGADFNAP> NLCJCJENOML()
		{
			return default(global::IMDNOFMHNPP<object, IOEHGADFNAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x18118B0", Offset = "0x18100B0", VA = "0x1818118B0", Slot = "7")]
		public void EGPHDBNPHNE(Exception OKIPNJPPODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1811AC0", Offset = "0x18102C0", VA = "0x181811AC0", Slot = "4")]
		private void NAAMBKLLCNH(in global::IMDNOFMHNPP<object, IOEHGADFNAP> KGFIMLECODA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class KPLJFCFJBMK : MGEPKCMDGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<global::IMDNOFMHNPP<object, IOEHGADFNAP>> PMKAIFBAPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private global::IMDNOFMHNPP<object, IOEHGADFNAP> DNCEOCCEBPB;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1C56F20", Offset = "0x1C55720", VA = "0x181C56F20")]
		private KPLJFCFJBMK(TaskCompletionSource<global::IMDNOFMHNPP<object, IOEHGADFNAP>> BIMAJFMDPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x18119F0", Offset = "0x18101F0", VA = "0x1818119F0")]
		public static KPLJFCFJBMK HHEHBEMBBBF(TaskCompletionSource<global::IMDNOFMHNPP<object, IOEHGADFNAP>> BIMAJFMDPAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x26F2730", Offset = "0x26F0F30", VA = "0x1826F2730")]
		public void CAIMLMIADCE(in global::IMDNOFMHNPP<object, IOEHGADFNAP> KGFIMLECODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FA90", Offset = "0x2A3E290", VA = "0x182A3FA90", Slot = "5")]
		public void FPABLHOEAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040", Slot = "6")]
		public global::IMDNOFMHNPP<object, IOEHGADFNAP> NLCJCJENOML()
		{
			return default(global::IMDNOFMHNPP<object, IOEHGADFNAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FA30", Offset = "0x2A3E230", VA = "0x182A3FA30", Slot = "7")]
		public void EGPHDBNPHNE(Exception OKIPNJPPODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1811AC0", Offset = "0x18102C0", VA = "0x181811AC0", Slot = "4")]
		private void NAAMBKLLCNH(in global::IMDNOFMHNPP<object, IOEHGADFNAP> KGFIMLECODA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class HINNCAAFIPL : MGEPKCMDGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<global::IMDNOFMHNPP<object, IOEHGADFNAP>> PAKPAAPMPBH;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x39E7860", Offset = "0x39E6060", VA = "0x1839E7860")]
		private HINNCAAFIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x364E320", Offset = "0x364CB20", VA = "0x18364E320")]
		public static HINNCAAFIPL HHEHBEMBBBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x39E77A0", Offset = "0x39E5FA0", VA = "0x1839E77A0")]
		public void CAIMLMIADCE(in global::IMDNOFMHNPP<object, IOEHGADFNAP> KGFIMLECODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		public void FPABLHOEAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x39E7800", Offset = "0x39E6000", VA = "0x1839E7800", Slot = "6")]
		public global::IMDNOFMHNPP<object, IOEHGADFNAP> NLCJCJENOML()
		{
			return default(global::IMDNOFMHNPP<object, IOEHGADFNAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
		public void EGPHDBNPHNE(Exception OKIPNJPPODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1811AC0", Offset = "0x18102C0", VA = "0x181811AC0", Slot = "4")]
		private void NAAMBKLLCNH(in global::IMDNOFMHNPP<object, IOEHGADFNAP> KGFIMLECODA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class HBPFCFDANLK : MGEPKCMDGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private global::IMDNOFMHNPP<object, IOEHGADFNAP> DNCEOCCEBPB;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		private HBPFCFDANLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x364E320", Offset = "0x364CB20", VA = "0x18364E320")]
		public static HBPFCFDANLK HHEHBEMBBBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x21AE900", Offset = "0x21AD100", VA = "0x1821AE900")]
		public void CAIMLMIADCE(in global::IMDNOFMHNPP<object, IOEHGADFNAP> KGFIMLECODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		public void FPABLHOEAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0", Slot = "6")]
		public global::IMDNOFMHNPP<object, IOEHGADFNAP> NLCJCJENOML()
		{
			return default(global::IMDNOFMHNPP<object, IOEHGADFNAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
		public void EGPHDBNPHNE(Exception OKIPNJPPODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1811AC0", Offset = "0x18102C0", VA = "0x181811AC0", Slot = "4")]
		private void NAAMBKLLCNH(in global::IMDNOFMHNPP<object, IOEHGADFNAP> KGFIMLECODA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MDDAKAFIHEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<global::IMDNOFMHNPP<object, IOEHGADFNAP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::MEAGHEPCDLH<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::DKJLBCAIGHC<JCCBLIBFBHJ> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public global::DKJLBCAIGHC<LJKOFEGPGAA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<global::IMDNOFMHNPP<object, IOEHGADFNAP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC380", Offset = "0x2DAAB80", VA = "0x182DAC380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC630", Offset = "0x2DAAE30", VA = "0x182DAC630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MPKPNPKPCAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<global::IMDNOFMHNPP<object, IOEHGADFNAP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public global::MEAGHEPCDLH<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::DKJLBCAIGHC<JCCBLIBFBHJ> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public global::DKJLBCAIGHC<LJKOFEGPGAA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MGEPKCMDGHK <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28E78F0", Offset = "0x28E60F0", VA = "0x1828E78F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28E82B0", Offset = "0x28E6AB0", VA = "0x1828E82B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LKNBLDJCOMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public global::MEAGHEPCDLH<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public MGEPKCMDGHK completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private MGEPKCMDGHK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<global::IMDNOFMHNPP<object, IOEHGADFNAP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2FE6980", Offset = "0x2FE5180", VA = "0x182FE6980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TActionReceiver OCIMHKLGHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TActionDeps MDKHHELHDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TStaticNetSysDeps EOPACMAHGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int LNIMGHKDDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int HFFJPPJMGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<global::DKJLBCAIGHC<LJKOFEGPGAA>, TaskCompletionSource<global::IMDNOFMHNPP<object, IOEHGADFNAP>>> JNABAIOHMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private global::DJHFIFCFCAN<LJKOFEGPGAA> JMFGEJPJFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int BMGBGJALNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task PGJJMKODECF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NNOJOPOCCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x778D00", Offset = "0x777500", VA = "0x180778D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7794B0", Offset = "0x777CB0", VA = "0x1807794B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD580", Offset = "0x2DABD80", VA = "0x182DAD580")]
	protected MEAGHEPCDLH(TActionDeps PLEAONMNIIF, TStaticNetSysDeps AJEBFEAIIGP, int AHPCHJFFKDK, int GEBNGMECKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2DACD80", Offset = "0x2DAB580", VA = "0x182DACD80")]
	public static global::MEAGHEPCDLH<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> HHEHBEMBBBF(TActionDeps PLEAONMNIIF, TStaticNetSysDeps AJEBFEAIIGP, [Optional] int? AHPCHJFFKDK, [Optional] int? GEBNGMECKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD060", Offset = "0x2DAB860", VA = "0x182DAD060")]
	public Task<global::IMDNOFMHNPP<object, IOEHGADFNAP>> KAOENBBPGHO(in TAction BEHJPKINPFB, bool LMFECHAOGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2DACC30", Offset = "0x2DAB430", VA = "0x182DACC30")]
	public void DIGOLKFJBHM(in TActionReceiver KKDEKAFFNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD2B0", Offset = "0x2DABAB0", VA = "0x182DAD2B0")]
	[AsyncStateMachine(typeof(global::MEAGHEPCDLH<, , , >.MDDAKAFIHEN))]
	public Task<global::IMDNOFMHNPP<object, IOEHGADFNAP>> KCOLKKDDFCC(global::DKJLBCAIGHC<JCCBLIBFBHJ> PGFCNIKGMKP, global::DKJLBCAIGHC<LJKOFEGPGAA> GLGBEAFMMEG, TAction BEHJPKINPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD410", Offset = "0x2DABC10", VA = "0x182DAD410")]
	[AsyncStateMachine(typeof(global::MEAGHEPCDLH<, , , >.MPKPNPKPCAM))]
	private Task<global::IMDNOFMHNPP<object, IOEHGADFNAP>> PLPNLIBNMHA(global::DKJLBCAIGHC<JCCBLIBFBHJ> PGFCNIKGMKP, global::DKJLBCAIGHC<LJKOFEGPGAA> GLGBEAFMMEG, TAction BEHJPKINPFB, Task CIMKBFMCHKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2DACC40", Offset = "0x2DAB440", VA = "0x182DACC40")]
	[AsyncStateMachine(typeof(global::MEAGHEPCDLH<, , , >.LKNBLDJCOMP))]
	private Task DOJJNGPCOHE(TAction BEHJPKINPFB, MGEPKCMDGHK LDPPJJLCKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2DACEC0", Offset = "0x2DAB6C0", VA = "0x182DACEC0")]
	private void JNEELFKIPJB(TAction BEHJPKINPFB, bool HEGGOKPLJAH, bool MAPPDOJFCEP)
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
