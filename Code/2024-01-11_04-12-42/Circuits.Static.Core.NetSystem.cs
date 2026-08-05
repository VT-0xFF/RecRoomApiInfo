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
public struct JGMLKPHGFBD<TPartialAction, TFullAction, TDeps> where TDeps : HFBIGGKGFJM.JIANHMFDPGL<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] DKMEJPLCEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int JJDOBJMBLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps DBPLOBJIGNL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x369B290", Offset = "0x3699C90", VA = "0x18369B290")]
	internal JGMLKPHGFBD(TPartialAction[] ADCICOOFCNB, int FOKFOCLDCLA, TDeps APDKDADOJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x369B1C0", Offset = "0x3699BC0", VA = "0x18369B1C0")]
	public static JGMLKPHGFBD<TPartialAction, TFullAction, TDeps> KBFODEGLBLG(TDeps APDKDADOJDA)
	{
		return default(JGMLKPHGFBD<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HFBIGGKGFJM
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JIANHMFDPGL<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AEFKIFHKKJH([In] TPartialAction FEDIPOMPLGA);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction HGNDIEJAFGD(TPartialAction[] AGKHBLEAIHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2615060", Offset = "0x2613A60", VA = "0x182615060")]
	public static GEHGOLLEGKI<TFullAction> OMCNJDIGAEP<TFullAction, TPartialAction, TDeps>(this JGMLKPHGFBD<TPartialAction, TFullAction, TDeps> JFFAAHPEFOB, TPartialAction FEDIPOMPLGA) where TDeps : JIANHMFDPGL<TPartialAction, TFullAction>
	{
		return default(GEHGOLLEGKI<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GCBMFPECPCJ<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : GGAHDJJDFKP.FCELHEMDIHJ<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] BBIHPJBICFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int AHCEIOOIKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps DBPLOBJIGNL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x369B290", Offset = "0x3699C90", VA = "0x18369B290")]
	internal GCBMFPECPCJ(TPartialSnapshot[] NBOINMGFBFH, int MDAEBIAAILI, TDeps APDKDADOJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x369B1C0", Offset = "0x3699BC0", VA = "0x18369B1C0")]
	public static GCBMFPECPCJ<TPartialSnapshot, TFullSnapshot, TDeps> KBFODEGLBLG(TDeps APDKDADOJDA)
	{
		return default(GCBMFPECPCJ<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GGAHDJJDFKP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FCELHEMDIHJ<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HNFABIBAIGO([In] TPartialSnapshot DNOLBBOFHOM);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot LHNKLHIGBOM(TPartialSnapshot[] GMAFPIPEJDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26094B0", Offset = "0x2607EB0", VA = "0x1826094B0")]
	public static GEHGOLLEGKI<TFullSnapshot> OMCNJDIGAEP<TFullSnapshot, TPartialSnapshot, TDeps>(this GCBMFPECPCJ<TPartialSnapshot, TFullSnapshot, TDeps> JFFAAHPEFOB, TPartialSnapshot DNOLBBOFHOM) where TDeps : FCELHEMDIHJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(GEHGOLLEGKI<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2609360", Offset = "0x2607D60", VA = "0x182609360")]
	public static bool DGGCHLFLIJL<TPartialSnapshot, TFullSnapshot, TDeps>(this GCBMFPECPCJ<TPartialSnapshot, TFullSnapshot, TDeps> JFFAAHPEFOB, TPartialSnapshot DNOLBBOFHOM) where TDeps : FCELHEMDIHJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class BHDLPJACLDC : IKLHIPCKMCK
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D1A930", Offset = "0x1D19330", VA = "0x181D1A930", Slot = "7")]
	public override string IIILAEFIJID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D1A960", Offset = "0x1D19360", VA = "0x181D1A960")]
	public BHDLPJACLDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class ILPLANOIPMJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : IDLPLCOFDAB.CBBODABHHKP<TAction, TNetSys> where TReceiverDeps : IDLPLCOFDAB.PGABNMHMJMG<TMActor, TAction, TReceiver> where TRootDeps : IDLPLCOFDAB.LCBJMGPFJIO<TMRequest, TMActor, TAction, TRoot> where TDeps : IDLPLCOFDAB.PDJDNDIHBOE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface KAJKNIIAADF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CKHBHCIBINM([In] GAFDMEJHKLE<object, HJEDPJFAAAL> JHJJOGFODKA);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IODGOOICLOH();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GAFDMEJHKLE<object, HJEDPJFAAAL> GNNLCKDGDEF();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JCPFCOPJCOO(Exception KHDPHPEGJEF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class IBLPNGOMCEK : KAJKNIIAADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<GAFDMEJHKLE<object, HJEDPJFAAAL>> JJEMDMEELIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<GAFDMEJHKLE<object, AJOFEFECHPF>> KOCAGAPIGGP;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x38169B0", Offset = "0x38153B0", VA = "0x1838169B0")]
		private IBLPNGOMCEK(TaskCompletionSource<GAFDMEJHKLE<object, HJEDPJFAAAL>> FMHAMHEBBNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x378A4F0", Offset = "0x3788EF0", VA = "0x18378A4F0")]
		public static IBLPNGOMCEK KBFODEGLBLG(TaskCompletionSource<GAFDMEJHKLE<object, HJEDPJFAAAL>> FMHAMHEBBNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x38164D0", Offset = "0x3814ED0", VA = "0x1838164D0")]
		public void CKHBHCIBINM([In] GAFDMEJHKLE<object, HJEDPJFAAAL> JHJJOGFODKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3816730", Offset = "0x3815130", VA = "0x183816730", Slot = "5")]
		public void IODGOOICLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3816680", Offset = "0x3815080", VA = "0x183816680", Slot = "6")]
		public GAFDMEJHKLE<object, HJEDPJFAAAL> GNNLCKDGDEF()
		{
			return default(GAFDMEJHKLE<object, HJEDPJFAAAL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3816950", Offset = "0x3815350", VA = "0x183816950", Slot = "7")]
		public void JCPFCOPJCOO(Exception KHDPHPEGJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x378A330", Offset = "0x3788D30", VA = "0x18378A330", Slot = "4")]
		private void AHFPHMIDEOM([In] GAFDMEJHKLE<object, HJEDPJFAAAL> JHJJOGFODKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class HLPHKJMNDHH : KAJKNIIAADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<GAFDMEJHKLE<object, HJEDPJFAAAL>> JJEMDMEELIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private GAFDMEJHKLE<object, HJEDPJFAAAL> OBGAAKKGKIE;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
		private HLPHKJMNDHH(TaskCompletionSource<GAFDMEJHKLE<object, HJEDPJFAAAL>> FMHAMHEBBNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x378A4F0", Offset = "0x3788EF0", VA = "0x18378A4F0")]
		public static HLPHKJMNDHH KBFODEGLBLG(TaskCompletionSource<GAFDMEJHKLE<object, HJEDPJFAAAL>> FMHAMHEBBNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x378A350", Offset = "0x3788D50", VA = "0x18378A350")]
		public void CKHBHCIBINM([In] GAFDMEJHKLE<object, HJEDPJFAAAL> JHJJOGFODKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x378A370", Offset = "0x3788D70", VA = "0x18378A370", Slot = "5")]
		public void IODGOOICLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA30D40", Offset = "0xA2F740", VA = "0x180A30D40", Slot = "6")]
		public GAFDMEJHKLE<object, HJEDPJFAAAL> GNNLCKDGDEF()
		{
			return default(GAFDMEJHKLE<object, HJEDPJFAAAL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x378A490", Offset = "0x3788E90", VA = "0x18378A490", Slot = "7")]
		public void JCPFCOPJCOO(Exception KHDPHPEGJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x378A330", Offset = "0x3788D30", VA = "0x18378A330", Slot = "4")]
		private void AHFPHMIDEOM([In] GAFDMEJHKLE<object, HJEDPJFAAAL> JHJJOGFODKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class KPDDCLNCDEP : KAJKNIIAADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<GAFDMEJHKLE<object, HJEDPJFAAAL>> KOCAGAPIGGP;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3B476B0", Offset = "0x3B460B0", VA = "0x183B476B0")]
		private KPDDCLNCDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x39F4650", Offset = "0x39F3050", VA = "0x1839F4650")]
		public static KPDDCLNCDEP KBFODEGLBLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3B47480", Offset = "0x3B45E80", VA = "0x183B47480")]
		public void CKHBHCIBINM([In] GAFDMEJHKLE<object, HJEDPJFAAAL> JHJJOGFODKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		public void IODGOOICLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3B47550", Offset = "0x3B45F50", VA = "0x183B47550", Slot = "6")]
		public GAFDMEJHKLE<object, HJEDPJFAAAL> GNNLCKDGDEF()
		{
			return default(GAFDMEJHKLE<object, HJEDPJFAAAL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3B47660", Offset = "0x3B46060", VA = "0x183B47660", Slot = "7")]
		[OHHDJMNEMGK("This may be terminal and should probably do more than discarding the exception.")]
		public void JCPFCOPJCOO(Exception KHDPHPEGJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x378A330", Offset = "0x3788D30", VA = "0x18378A330", Slot = "4")]
		private void AHFPHMIDEOM([In] GAFDMEJHKLE<object, HJEDPJFAAAL> JHJJOGFODKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class JDDEMBDIPPE : KAJKNIIAADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GAFDMEJHKLE<object, HJEDPJFAAAL> OBGAAKKGKIE;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private JDDEMBDIPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x39F4650", Offset = "0x39F3050", VA = "0x1839F4650")]
		public static JDDEMBDIPPE KBFODEGLBLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1473920", Offset = "0x1472320", VA = "0x181473920")]
		public void CKHBHCIBINM([In] GAFDMEJHKLE<object, HJEDPJFAAAL> JHJJOGFODKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		public void IODGOOICLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB51900", Offset = "0xB50300", VA = "0x180B51900", Slot = "6")]
		public GAFDMEJHKLE<object, HJEDPJFAAAL> GNNLCKDGDEF()
		{
			return default(GAFDMEJHKLE<object, HJEDPJFAAAL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x39F4600", Offset = "0x39F3000", VA = "0x1839F4600", Slot = "7")]
		[OHHDJMNEMGK("This may be terminal and should probably do more than discarding the exception.")]
		public void JCPFCOPJCOO(Exception KHDPHPEGJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x378A330", Offset = "0x3788D30", VA = "0x18378A330", Slot = "4")]
		private void AHFPHMIDEOM([In] GAFDMEJHKLE<object, HJEDPJFAAAL> JHJJOGFODKA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct MIDEFEICCBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::ILPLANOIPMJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MCAPNBAEEIC<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<GAFDMEJHKLE<object, HJEDPJFAAAL>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9D90", Offset = "0x3DD8790", VA = "0x183DD9D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA2D0", Offset = "0x3DD8CD0", VA = "0x183DDA2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PMOFOBHMMOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::ILPLANOIPMJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MCAPNBAEEIC<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x40A37E0", Offset = "0x40A21E0", VA = "0x1840A37E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x40A3C90", Offset = "0x40A2690", VA = "0x1840A3C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MOBMEGHHBMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::ILPLANOIPMJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MCAPNBAEEIC<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MCAPNBAEEIC<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3DF15C0", Offset = "0x3DEFFC0", VA = "0x183DF15C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3DF1920", Offset = "0x3DF0320", VA = "0x183DF1920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FLJNCIMNMNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::ILPLANOIPMJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MCAPNBAEEIC<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MCAPNBAEEIC<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private KAJKNIIAADF <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x35C9B10", Offset = "0x35C8510", VA = "0x1835C9B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x35CB470", Offset = "0x35C9E70", VA = "0x1835CB470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JNOINCCAJCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::ILPLANOIPMJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public KAJKNIIAADF completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private KAJKNIIAADF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<GAFDMEJHKLE<object, HJEDPJFAAAL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3A62440", Offset = "0x3A60E40", VA = "0x183A62440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3A641F0", Offset = "0x3A62BF0", VA = "0x183A641F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps DBPLOBJIGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<MCAPNBAEEIC<TMRequest>, TaskCompletionSource<GAFDMEJHKLE<object, HJEDPJFAAAL>>> DGBEAHPEPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private ELLAEEONIBH<TMRequest> GOHPPPKCOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int HMCDOMHCJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task JMDDCJDKAPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps BNFOBKGKLKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3848EC0", Offset = "0x38478C0", VA = "0x183848EC0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps PNJDKGAJNBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3847460", Offset = "0x3845E60", VA = "0x183847460")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps MFGEMJMNEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3848850", Offset = "0x3847250", VA = "0x183848850")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OLJKCKCACGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x11094A0", Offset = "0x1107EA0", VA = "0x1811094A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11094B0", Offset = "0x1107EB0", VA = "0x1811094B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KOLLJLMAANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1C009B0", Offset = "0x1BFF3B0", VA = "0x181C009B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1C00C90", Offset = "0x1BFF690", VA = "0x181C00C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DNCFBGDFFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7965A0", Offset = "0x794FA0", VA = "0x1807965A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3849200", Offset = "0x3847C00", VA = "0x183849200")]
	public ILPLANOIPMJ(TDeps APDKDADOJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3847750", Offset = "0x3846150", VA = "0x183847750")]
	public Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> FNAJFCCJLPC(TRoot AJBLHMMPNNM, TNetSys OKBHCECFANJ, MCAPNBAEEIC<TMActor> EDBGGPJNMLJ, TAction GMHPLHJININ, bool PABOKNHGHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3847A70", Offset = "0x3846470", VA = "0x183847A70")]
	[AsyncStateMachine(typeof(global::ILPLANOIPMJ<, , , , , , , , , >.MIDEFEICCBF))]
	private Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> FNAJFCCJLPC(TRoot AJBLHMMPNNM, MCAPNBAEEIC<TMActor> EDBGGPJNMLJ, TAction GMHPLHJININ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38475F0", Offset = "0x3845FF0", VA = "0x1838475F0")]
	[AsyncStateMachine(typeof(global::ILPLANOIPMJ<, , , , , , , , , >.PMOFOBHMMOL))]
	private Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> BACAGJGONBM(TRoot AJBLHMMPNNM, MCAPNBAEEIC<TMActor> EDBGGPJNMLJ, TAction[] PICFMMIBHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x38488D0", Offset = "0x38472D0", VA = "0x1838488D0")]
	[AsyncStateMachine(typeof(global::ILPLANOIPMJ<, , , , , , , , , >.MOBMEGHHBMD))]
	public Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> KHPOEIIHGMP(TRoot AJBLHMMPNNM, TNetSys FOIIGKALCEH, TReceiver LJKLAGCNGHO, MCAPNBAEEIC<TMActor> EDBGGPJNMLJ, MCAPNBAEEIC<TMRequest> NEEHAJCGMBG, TAction GMHPLHJININ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3848EF0", Offset = "0x38478F0", VA = "0x183848EF0")]
	[AsyncStateMachine(typeof(global::ILPLANOIPMJ<, , , , , , , , , >.FLJNCIMNMNF))]
	private Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> NAOFBHOOGOO(TRoot AJBLHMMPNNM, TNetSys FOIIGKALCEH, TReceiver LJKLAGCNGHO, MCAPNBAEEIC<TMActor> EDBGGPJNMLJ, MCAPNBAEEIC<TMRequest> NEEHAJCGMBG, TAction GMHPLHJININ, Task HDLPBOBJEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3848BC0", Offset = "0x38475C0", VA = "0x183848BC0")]
	[AsyncStateMachine(typeof(global::ILPLANOIPMJ<, , , , , , , , , >.JNOINCCAJCK))]
	private Task KNDKHMMJIJH(TRoot AJBLHMMPNNM, TNetSys FOIIGKALCEH, TReceiver LJKLAGCNGHO, TAction GMHPLHJININ, KAJKNIIAADF JLGFHIPOFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38481E0", Offset = "0x3846BE0", VA = "0x1838481E0")]
	private void HEHFJJALFPA(TRoot AJBLHMMPNNM, TNetSys FOIIGKALCEH, TReceiver LJKLAGCNGHO, MCAPNBAEEIC<TMActor> EDBGGPJNMLJ, TAction GMHPLHJININ, bool IDIEGJMJFHE, bool EMEBLHNOOPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IDLPLCOFDAB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface CBBODABHHKP<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NOLLCAPGEKM(TNetSys GABNAIJAADN, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction AMBKGBFKDBB(TNetSys GABNAIJAADN, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction EKDHFCAAHOO(TNetSys GABNAIJAADN, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> LBBFPIIAFAH(TNetSys GABNAIJAADN, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] FBAOFDEDKCB(TNetSys GABNAIJAADN, TAction GMHPLHJININ, int OCCFPOPLAOG);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GKHPMOOKLME(TNetSys GABNAIJAADN, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NPDIJJMCIBI(TNetSys GABNAIJAADN, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool CGHLFPOCNNI(TNetSys GABNAIJAADN, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool GCMOMGIMOOC(TNetSys GABNAIJAADN, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool MOHLDCJIJPP(TNetSys GABNAIJAADN, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool NKCEJMJPEGN(TNetSys GABNAIJAADN, TAction GMHPLHJININ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface PDJDNDIHBOE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps BNFOBKGKLKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps MFGEMJMNEBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps PNJDKGAJNBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface PGABNMHMJMG<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MCAPNBAEEIC<TMActor> ANPKEMFLECG(TReceiver LJKLAGCNGHO);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<GAFDMEJHKLE<object, HJEDPJFAAAL>> KHPOEIIHGMP(TReceiver LJKLAGCNGHO, TAction GMHPLHJININ);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] FOCLIBLADFA(TReceiver LJKLAGCNGHO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface LCBJMGPFJIO<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OIEKKAJOENA(TRoot AJBLHMMPNNM);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int PKEOJMFGNFO(TRoot AJBLHMMPNNM);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MACKKAMGOGL(TRoot AJBLHMMPNNM);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BCBEBALJAMB(TRoot AJBLHMMPNNM);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void INAGKDGPLKN(TRoot AJBLHMMPNNM);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task FNAJFCCJLPC(TRoot AJBLHMMPNNM, MCAPNBAEEIC<TMActor> EDBGGPJNMLJ, MCAPNBAEEIC<TMRequest> NEEHAJCGMBG, TAction GMHPLHJININ, bool MHOAPLFPNOE = true);
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
