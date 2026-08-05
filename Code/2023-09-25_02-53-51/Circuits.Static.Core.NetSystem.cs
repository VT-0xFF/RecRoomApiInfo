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
public struct AKKCLDONNMO<TPartialAction, TFullAction, TDeps> where TDeps : HHKPBEBABPA.JHAHCKBGKFB<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] LOKPDJHJFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int LHHLAMNEAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps BOAEKCBHIIP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3015FF0", Offset = "0x30153F0", VA = "0x183015FF0")]
	internal AKKCLDONNMO(TPartialAction[] BIOJJLPBEGD, int OMNEPBJPBKI, TDeps KELDMPHCCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3015ED0", Offset = "0x30152D0", VA = "0x183015ED0")]
	public static AKKCLDONNMO<TPartialAction, TFullAction, TDeps> CLFIPFKIGEN(TDeps KELDMPHCCLC)
	{
		return default(AKKCLDONNMO<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HHKPBEBABPA
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JHAHCKBGKFB<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NKHOMMFKPKE([In] TPartialAction LFOHHIOCADA);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction LIJDHLKCCNB(TPartialAction[] JJKICGPJGEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23DB3D0", Offset = "0x23DA7D0", VA = "0x1823DB3D0")]
	public static GDILPCKNMEE<TFullAction> MIDHCANIOFP<TFullAction, TPartialAction, TDeps>(this AKKCLDONNMO<TPartialAction, TFullAction, TDeps> CLFMFOEGLFG, TPartialAction LFOHHIOCADA) where TDeps : JHAHCKBGKFB<TPartialAction, TFullAction>
	{
		return default(GDILPCKNMEE<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EBJHNJMMFML<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : KEPLOFOGCPD.AFGFEPEIMIO<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] EDFMFDPLBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int LFIKACEHPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps BOAEKCBHIIP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3015FF0", Offset = "0x30153F0", VA = "0x183015FF0")]
	internal EBJHNJMMFML(TPartialSnapshot[] OHNGLHLPPEJ, int POIHGFGELPK, TDeps KELDMPHCCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3015ED0", Offset = "0x30152D0", VA = "0x183015ED0")]
	public static EBJHNJMMFML<TPartialSnapshot, TFullSnapshot, TDeps> CLFIPFKIGEN(TDeps KELDMPHCCLC)
	{
		return default(EBJHNJMMFML<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KEPLOFOGCPD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface AFGFEPEIMIO<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LCMMHEFHGFG([In] TPartialSnapshot LNHPBLNPKIG);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot ICHBFBEMBOK(TPartialSnapshot[] CBAHIBDBJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x242D670", Offset = "0x242CA70", VA = "0x18242D670")]
	public static GDILPCKNMEE<TFullSnapshot> MIDHCANIOFP<TFullSnapshot, TPartialSnapshot, TDeps>(this EBJHNJMMFML<TPartialSnapshot, TFullSnapshot, TDeps> CLFMFOEGLFG, TPartialSnapshot LNHPBLNPKIG) where TDeps : AFGFEPEIMIO<TPartialSnapshot, TFullSnapshot>
	{
		return default(GDILPCKNMEE<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x242D520", Offset = "0x242C920", VA = "0x18242D520")]
	public static bool HFMIOACJCIP<TPartialSnapshot, TFullSnapshot, TDeps>(this EBJHNJMMFML<TPartialSnapshot, TFullSnapshot, TDeps> CLFMFOEGLFG, TPartialSnapshot LNHPBLNPKIG) where TDeps : AFGFEPEIMIO<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class OLIEJKMOOGE : PEPMMDADFIO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C29B80", Offset = "0x1C28F80", VA = "0x181C29B80", Slot = "7")]
	public override string EAPOOJKPODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C29BB0", Offset = "0x1C28FB0", VA = "0x181C29BB0")]
	public OLIEJKMOOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DHIGJPEHAKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FJCNHIKCJBH.PLICBKEIOIM<TAction, TNetSys> where TReceiverDeps : FJCNHIKCJBH.MPHHBHCLNBJ<TMActor, TAction, TReceiver> where TRootDeps : FJCNHIKCJBH.BMAPOIKIPJP<TMRequest, TMActor, TAction, TRoot> where TDeps : FJCNHIKCJBH.PJGIDNLLBCD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface FOJFDJELJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CKJPCJHCLKN([In] MEEAMGFNJIM<object, DBNOAAMPCCP> BBHPNPGLHIG);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CMDBOCACFBH();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MEEAMGFNJIM<object, DBNOAAMPCCP> DPNGLEHMICL();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GKHMNDEKMCF(Exception FLMBJDOBLFE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class PICEKKJPFOH : FOJFDJELJOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<MEEAMGFNJIM<object, DBNOAAMPCCP>> GKAAKHOJCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<MEEAMGFNJIM<object, IEAOACDDPEG>> OPFGCCGOBKM;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DA60", Offset = "0x3E4CE60", VA = "0x183E4DA60")]
		private PICEKKJPFOH(TaskCompletionSource<MEEAMGFNJIM<object, DBNOAAMPCCP>> BPFHLDFGALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3468FA0", Offset = "0x34683A0", VA = "0x183468FA0")]
		public static PICEKKJPFOH CLFIPFKIGEN(TaskCompletionSource<MEEAMGFNJIM<object, DBNOAAMPCCP>> BPFHLDFGALC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E4D480", Offset = "0x3E4C880", VA = "0x183E4D480")]
		public void CKJPCJHCLKN([In] MEEAMGFNJIM<object, DBNOAAMPCCP> BBHPNPGLHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E4D760", Offset = "0x3E4CB60", VA = "0x183E4D760", Slot = "5")]
		public void CMDBOCACFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E4D840", Offset = "0x3E4CC40", VA = "0x183E4D840", Slot = "6")]
		public MEEAMGFNJIM<object, DBNOAAMPCCP> DPNGLEHMICL()
		{
			return default(MEEAMGFNJIM<object, DBNOAAMPCCP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DA00", Offset = "0x3E4CE00", VA = "0x183E4DA00", Slot = "7")]
		public void GKHMNDEKMCF(Exception FLMBJDOBLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37A0E40", Offset = "0x37A0240", VA = "0x1837A0E40", Slot = "4")]
		private void FIMIEEBKKOC([In] MEEAMGFNJIM<object, DBNOAAMPCCP> BBHPNPGLHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class KMLIAJEGAHG : FOJFDJELJOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<MEEAMGFNJIM<object, DBNOAAMPCCP>> GKAAKHOJCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MEEAMGFNJIM<object, DBNOAAMPCCP> LMKLLBEELJN;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
		private KMLIAJEGAHG(TaskCompletionSource<MEEAMGFNJIM<object, DBNOAAMPCCP>> BPFHLDFGALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3468FA0", Offset = "0x34683A0", VA = "0x183468FA0")]
		public static KMLIAJEGAHG CLFIPFKIGEN(TaskCompletionSource<MEEAMGFNJIM<object, DBNOAAMPCCP>> BPFHLDFGALC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3829C30", Offset = "0x3829030", VA = "0x183829C30")]
		public void CKJPCJHCLKN([In] MEEAMGFNJIM<object, DBNOAAMPCCP> BBHPNPGLHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3829CB0", Offset = "0x38290B0", VA = "0x183829CB0", Slot = "5")]
		public void CMDBOCACFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x93E0D0", Offset = "0x93D4D0", VA = "0x18093E0D0", Slot = "6")]
		public MEEAMGFNJIM<object, DBNOAAMPCCP> DPNGLEHMICL()
		{
			return default(MEEAMGFNJIM<object, DBNOAAMPCCP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3829D10", Offset = "0x3829110", VA = "0x183829D10", Slot = "7")]
		public void GKHMNDEKMCF(Exception FLMBJDOBLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37A0E40", Offset = "0x37A0240", VA = "0x1837A0E40", Slot = "4")]
		private void FIMIEEBKKOC([In] MEEAMGFNJIM<object, DBNOAAMPCCP> BBHPNPGLHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class KGEMFKLFKEH : FOJFDJELJOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<MEEAMGFNJIM<object, DBNOAAMPCCP>> OPFGCCGOBKM;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37ED5E0", Offset = "0x37EC9E0", VA = "0x1837ED5E0")]
		private KGEMFKLFKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37ED460", Offset = "0x37EC860", VA = "0x1837ED460")]
		public static KGEMFKLFKEH CLFIPFKIGEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x37ED390", Offset = "0x37EC790", VA = "0x1837ED390")]
		public void CKJPCJHCLKN([In] MEEAMGFNJIM<object, DBNOAAMPCCP> BBHPNPGLHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		public void CMDBOCACFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37ED520", Offset = "0x37EC920", VA = "0x1837ED520", Slot = "6")]
		public MEEAMGFNJIM<object, DBNOAAMPCCP> DPNGLEHMICL()
		{
			return default(MEEAMGFNJIM<object, DBNOAAMPCCP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		public void GKHMNDEKMCF(Exception FLMBJDOBLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37A0E40", Offset = "0x37A0240", VA = "0x1837A0E40", Slot = "4")]
		private void FIMIEEBKKOC([In] MEEAMGFNJIM<object, DBNOAAMPCCP> BBHPNPGLHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class DCHJNFILGFC : FOJFDJELJOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private MEEAMGFNJIM<object, DBNOAAMPCCP> LMKLLBEELJN;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		private DCHJNFILGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37ED460", Offset = "0x37EC860", VA = "0x1837ED460")]
		public static DCHJNFILGFC CLFIPFKIGEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A920", Offset = "0x3C69D20", VA = "0x183C6A920")]
		public void CKJPCJHCLKN([In] MEEAMGFNJIM<object, DBNOAAMPCCP> BBHPNPGLHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		public void CMDBOCACFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA40000", Offset = "0xA3F400", VA = "0x180A40000", Slot = "6")]
		public MEEAMGFNJIM<object, DBNOAAMPCCP> DPNGLEHMICL()
		{
			return default(MEEAMGFNJIM<object, DBNOAAMPCCP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		public void GKHMNDEKMCF(Exception FLMBJDOBLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37A0E40", Offset = "0x37A0240", VA = "0x1837A0E40", Slot = "4")]
		private void FIMIEEBKKOC([In] MEEAMGFNJIM<object, DBNOAAMPCCP> BBHPNPGLHIG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HLCICLLPMMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::DHIGJPEHAKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public OKFPGADAGCG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<MEEAMGFNJIM<object, DBNOAAMPCCP>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3522D00", Offset = "0x3522100", VA = "0x183522D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3523240", Offset = "0x3522640", VA = "0x183523240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HKINCJCNOLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::DHIGJPEHAKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OKFPGADAGCG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3521CF0", Offset = "0x35210F0", VA = "0x183521CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3522570", Offset = "0x3521970", VA = "0x183522570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JMLOHIFOHDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::DHIGJPEHAKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public OKFPGADAGCG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public OKFPGADAGCG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x37A27F0", Offset = "0x37A1BF0", VA = "0x1837A27F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x37A2B50", Offset = "0x37A1F50", VA = "0x1837A2B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AELAPGIKEBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::DHIGJPEHAKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OKFPGADAGCG<TMActor> senderId;

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
		public OKFPGADAGCG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private FOJFDJELJOH <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3445FC0", Offset = "0x34453C0", VA = "0x183445FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3446B80", Offset = "0x3445F80", VA = "0x183446B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct BDAEGFCMEDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::DHIGJPEHAKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FOJFDJELJOH completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FOJFDJELJOH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4480150", Offset = "0x447F550", VA = "0x184480150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4481EA0", Offset = "0x44812A0", VA = "0x184481EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps BOAEKCBHIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<OKFPGADAGCG<TMRequest>, TaskCompletionSource<MEEAMGFNJIM<object, DBNOAAMPCCP>>> NFOMEBFLACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OBAOKPLIFFL<TMRequest> IBFKJPEPFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int OFDGEIEFACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task HFDLEJINNGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps CDAGHPEHGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9020", Offset = "0x4CF8420", VA = "0x184CF9020")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps NBBCBBJCJLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9C70", Offset = "0x4CF9070", VA = "0x184CF9C70")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps IJCIECLFCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9CA0", Offset = "0x4CF90A0", VA = "0x184CF9CA0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MNJLKMCOILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xFD84B0", Offset = "0xFD78B0", VA = "0x180FD84B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xFD84C0", Offset = "0xFD78C0", VA = "0x180FD84C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CINHGPJFCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B18B90", Offset = "0x1B17F90", VA = "0x181B18B90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1B18E70", Offset = "0x1B18270", VA = "0x181B18E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FHPGDDDOONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76B420", Offset = "0x76A820", VA = "0x18076B420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9E80", Offset = "0x4CF9280", VA = "0x184CF9E80")]
	public DHIGJPEHAKJ(TDeps KELDMPHCCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4CF8520", Offset = "0x4CF7920", VA = "0x184CF8520")]
	public Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> CFMKIDHDPIC(TRoot JMNDOLBKAMN, TNetSys CJLBMHOCHHI, OKFPGADAGCG<TMActor> IBKDIOPCGFF, TAction PAFFKHOCLGN, bool LBEBPDMECAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4CF8840", Offset = "0x4CF7C40", VA = "0x184CF8840")]
	[AsyncStateMachine(typeof(global::DHIGJPEHAKJ<, , , , , , , , , >.HLCICLLPMMG))]
	private Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> CFMKIDHDPIC(TRoot JMNDOLBKAMN, OKFPGADAGCG<TMActor> IBKDIOPCGFF, TAction PAFFKHOCLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9960", Offset = "0x4CF8D60", VA = "0x184CF9960")]
	[AsyncStateMachine(typeof(global::DHIGJPEHAKJ<, , , , , , , , , >.HKINCJCNOLI))]
	private Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> KGFKLEJGJII(TRoot JMNDOLBKAMN, OKFPGADAGCG<TMActor> IBKDIOPCGFF, TAction[] HIKGMMOGGPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4CF8230", Offset = "0x4CF7630", VA = "0x184CF8230")]
	[AsyncStateMachine(typeof(global::DHIGJPEHAKJ<, , , , , , , , , >.JMLOHIFOHDH))]
	public Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> BICAKAGMPEO(TRoot JMNDOLBKAMN, TNetSys MNEINNEMOJC, TReceiver EIDGHHFIPHF, OKFPGADAGCG<TMActor> IBKDIOPCGFF, OKFPGADAGCG<TMRequest> NDCIEIBPMPI, TAction PAFFKHOCLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4CF7F20", Offset = "0x4CF7320", VA = "0x184CF7F20")]
	[AsyncStateMachine(typeof(global::DHIGJPEHAKJ<, , , , , , , , , >.AELAPGIKEBG))]
	private Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> AJOOMIMANFJ(TRoot JMNDOLBKAMN, TNetSys MNEINNEMOJC, TReceiver EIDGHHFIPHF, OKFPGADAGCG<TMActor> IBKDIOPCGFF, OKFPGADAGCG<TMRequest> NDCIEIBPMPI, TAction PAFFKHOCLGN, Task CNDMBMDOPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4CF96B0", Offset = "0x4CF8AB0", VA = "0x184CF96B0")]
	[AsyncStateMachine(typeof(global::DHIGJPEHAKJ<, , , , , , , , , >.BDAEGFCMEDG))]
	private Task JFOJNBOGEGP(TRoot JMNDOLBKAMN, TNetSys MNEINNEMOJC, TReceiver EIDGHHFIPHF, TAction PAFFKHOCLGN, FOJFDJELJOH HHKJMBCCAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4CF9410", Offset = "0x4CF8810", VA = "0x184CF9410")]
	private void IMAFBBEBFJA(TRoot JMNDOLBKAMN, TNetSys MNEINNEMOJC, TReceiver EIDGHHFIPHF, OKFPGADAGCG<TMActor> IBKDIOPCGFF, TAction PAFFKHOCLGN, bool CEPECMBPLJH, bool HIFLDPMGKLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FJCNHIKCJBH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface PLICBKEIOIM<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LPLGDLGLBLI(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction ICHGBOPLIPL(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction BDNHEMOJLDF(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> OHLGPADNBAF(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] HMEDMKEFGPD(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN, int DANGDNPMMNH);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CMAJDPKOOPH(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EAADENOOILO(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool JCAMEKENFAK(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool BLGMNMILFPN(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool AGLNLBAKGNL(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool FCEPCEMIALG(TNetSys CIFCOCHIFFA, TAction PAFFKHOCLGN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface PJGIDNLLBCD<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps CDAGHPEHGJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps IJCIECLFCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps NBBCBBJCJLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MPHHBHCLNBJ<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OKFPGADAGCG<TMActor> IMEJIMFFAEK(TReceiver EIDGHHFIPHF);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> BICAKAGMPEO(TReceiver EIDGHHFIPHF, TAction PAFFKHOCLGN);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] IAFAEEEMPIE(TReceiver EIDGHHFIPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface BMAPOIKIPJP<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KNMNPBGMKGF(TRoot JMNDOLBKAMN);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int BCAGDKGGFHG(TRoot JMNDOLBKAMN);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int CKODMNDBCDG(TRoot JMNDOLBKAMN);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JDADHNANPJF(TRoot JMNDOLBKAMN);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NDJJCCFNNJI(TRoot JMNDOLBKAMN);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task CFMKIDHDPIC(TRoot JMNDOLBKAMN, OKFPGADAGCG<TMActor> IBKDIOPCGFF, OKFPGADAGCG<TMRequest> NDCIEIBPMPI, TAction PAFFKHOCLGN, bool PGHFCIJFGPI = true);
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
