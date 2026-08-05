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
public struct OGGLLGDGBBE<TPartialAction, TFullAction, TDeps> where TDeps : ENJIJLDDFEF.ABCCCIAEMIJ<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] LGANAKNBFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int LLKGKPKODON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps GOGJLAAIIKE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x41FAD90", Offset = "0x41F9790", VA = "0x1841FAD90")]
	internal OGGLLGDGBBE(TPartialAction[] OMBBGGNPHDP, int EHCDPOJBLIL, TDeps COBDDACEALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x41FACC0", Offset = "0x41F96C0", VA = "0x1841FACC0")]
	public static OGGLLGDGBBE<TPartialAction, TFullAction, TDeps> OLCPJHCMOKI(TDeps COBDDACEALE)
	{
		return default(OGGLLGDGBBE<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ENJIJLDDFEF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface ABCCCIAEMIJ<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int APAPJGLHDEJ([In] TPartialAction FCCHFBENICN);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction POMKHPMLFGM(TPartialAction[] EFCKNPEIOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x280E7D0", Offset = "0x280D1D0", VA = "0x18280E7D0")]
	public static GLKIBNECMOM<TFullAction> DGHMJCBAOMN<TFullAction, TPartialAction, TDeps>(this OGGLLGDGBBE<TPartialAction, TFullAction, TDeps> CMJEIEIDHIK, TPartialAction FCCHFBENICN) where TDeps : ABCCCIAEMIJ<TPartialAction, TFullAction>
	{
		return default(GLKIBNECMOM<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OBCJBFGFDBF<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : BCBECCBEHKG.KIDJOAMJLPJ<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] BBGCELIDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int OIGGHHOKOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps GOGJLAAIIKE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x41FAD90", Offset = "0x41F9790", VA = "0x1841FAD90")]
	internal OBCJBFGFDBF(TPartialSnapshot[] NAJLHDNIMDF, int CAIMLBFNHPA, TDeps COBDDACEALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x41FACC0", Offset = "0x41F96C0", VA = "0x1841FACC0")]
	public static OBCJBFGFDBF<TPartialSnapshot, TFullSnapshot, TDeps> OLCPJHCMOKI(TDeps COBDDACEALE)
	{
		return default(OBCJBFGFDBF<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BCBECCBEHKG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KIDJOAMJLPJ<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BKJOODOIMOD([In] TPartialSnapshot NKIONPLADAF);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot LEDOAHAJNIP(TPartialSnapshot[] CONKIBBMAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2715160", Offset = "0x2713B60", VA = "0x182715160")]
	public static GLKIBNECMOM<TFullSnapshot> DGHMJCBAOMN<TFullSnapshot, TPartialSnapshot, TDeps>(this OBCJBFGFDBF<TPartialSnapshot, TFullSnapshot, TDeps> CMJEIEIDHIK, TPartialSnapshot NKIONPLADAF) where TDeps : KIDJOAMJLPJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(GLKIBNECMOM<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2715020", Offset = "0x2713A20", VA = "0x182715020")]
	public static bool CHKAFJPFELC<TPartialSnapshot, TFullSnapshot, TDeps>(this OBCJBFGFDBF<TPartialSnapshot, TFullSnapshot, TDeps> CMJEIEIDHIK, TPartialSnapshot NKIONPLADAF) where TDeps : KIDJOAMJLPJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class MNCJGDADAEK : BPHLMNENOKN
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E89DF0", Offset = "0x1E887F0", VA = "0x181E89DF0", Slot = "7")]
	public override string BLGDHPMKGMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E89E20", Offset = "0x1E88820", VA = "0x181E89E20")]
	public MNCJGDADAEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class PLNELFLJKAD<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : BFBIFBHLOKO.EDBHPBHJBAD<TAction, TNetSys> where TReceiverDeps : BFBIFBHLOKO.PJCNBMKOGME<TAction, TReceiver> where TRootDeps : BFBIFBHLOKO.KCLNEAGJFEM<TMRequest, TAction, TRoot> where TDeps : BFBIFBHLOKO.GHHHEHGMHDH<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface BDDDJJCNLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CDHELGBAPPD([In] LGGHGMLBJFM<object, DGFMPJAMJNO> LKBGEIGOHEF);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PBHHBCFIOKM();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LGGHGMLBJFM<object, DGFMPJAMJNO> NHKNGNMMOFB();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LMOEKNBGMHO(Exception PBPEDJNJMOI);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class BPBNKOPAKPM : BDDDJJCNLJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<LGGHGMLBJFM<object, DGFMPJAMJNO>> PDHNEHOJGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<LGGHGMLBJFM<object, CEAFENKMCFB>> DNHNKHLLCIP;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4972E00", Offset = "0x4971800", VA = "0x184972E00")]
		private BPBNKOPAKPM(TaskCompletionSource<LGGHGMLBJFM<object, DGFMPJAMJNO>> GMDHFJHLOJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D69B60", Offset = "0x3D68560", VA = "0x183D69B60")]
		public static BPBNKOPAKPM OLCPJHCMOKI(TaskCompletionSource<LGGHGMLBJFM<object, DGFMPJAMJNO>> GMDHFJHLOJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4972780", Offset = "0x4971180", VA = "0x184972780")]
		public void CDHELGBAPPD([In] LGGHGMLBJFM<object, DGFMPJAMJNO> LKBGEIGOHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4972C80", Offset = "0x4971680", VA = "0x184972C80", Slot = "5")]
		public void PBHHBCFIOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4972AF0", Offset = "0x49714F0", VA = "0x184972AF0", Slot = "6")]
		public LGGHGMLBJFM<object, DGFMPJAMJNO> NHKNGNMMOFB()
		{
			return default(LGGHGMLBJFM<object, DGFMPJAMJNO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x49729E0", Offset = "0x49713E0", VA = "0x1849729E0", Slot = "7")]
		public void LMOEKNBGMHO(Exception PBPEDJNJMOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x39F86B0", Offset = "0x39F70B0", VA = "0x1839F86B0", Slot = "4")]
		private void FEJHIFEAEGI([In] LGGHGMLBJFM<object, DGFMPJAMJNO> LKBGEIGOHEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class KIKBNCIKMFC : BDDDJJCNLJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<LGGHGMLBJFM<object, DGFMPJAMJNO>> PDHNEHOJGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private LGGHGMLBJFM<object, DGFMPJAMJNO> NCABLMNPIEP;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
		private KIKBNCIKMFC(TaskCompletionSource<LGGHGMLBJFM<object, DGFMPJAMJNO>> GMDHFJHLOJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D69B60", Offset = "0x3D68560", VA = "0x183D69B60")]
		public static KIKBNCIKMFC OLCPJHCMOKI(TaskCompletionSource<LGGHGMLBJFM<object, DGFMPJAMJNO>> GMDHFJHLOJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D69A80", Offset = "0x3D68480", VA = "0x183D69A80")]
		public void CDHELGBAPPD([In] LGGHGMLBJFM<object, DGFMPJAMJNO> LKBGEIGOHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D69C80", Offset = "0x3D68680", VA = "0x183D69C80", Slot = "5")]
		public void PBHHBCFIOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB019B0", Offset = "0xB003B0", VA = "0x180B019B0", Slot = "6")]
		public LGGHGMLBJFM<object, DGFMPJAMJNO> NHKNGNMMOFB()
		{
			return default(LGGHGMLBJFM<object, DGFMPJAMJNO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D69AA0", Offset = "0x3D684A0", VA = "0x183D69AA0", Slot = "7")]
		public void LMOEKNBGMHO(Exception PBPEDJNJMOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x39F86B0", Offset = "0x39F70B0", VA = "0x1839F86B0", Slot = "4")]
		private void FEJHIFEAEGI([In] LGGHGMLBJFM<object, DGFMPJAMJNO> LKBGEIGOHEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class HJAOOCLCLHD : BDDDJJCNLJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<LGGHGMLBJFM<object, DGFMPJAMJNO>> DNHNKHLLCIP;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39F88E0", Offset = "0x39F72E0", VA = "0x1839F88E0")]
		private HJAOOCLCLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x39F8830", Offset = "0x39F7230", VA = "0x1839F8830")]
		public static HJAOOCLCLHD OLCPJHCMOKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x39F85E0", Offset = "0x39F6FE0", VA = "0x1839F85E0")]
		public void CDHELGBAPPD([In] LGGHGMLBJFM<object, DGFMPJAMJNO> LKBGEIGOHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void PBHHBCFIOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x39F8770", Offset = "0x39F7170", VA = "0x1839F8770", Slot = "6")]
		public LGGHGMLBJFM<object, DGFMPJAMJNO> NHKNGNMMOFB()
		{
			return default(LGGHGMLBJFM<object, DGFMPJAMJNO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x39F86D0", Offset = "0x39F70D0", VA = "0x1839F86D0", Slot = "7")]
		[OKMJKJEMLAC("This may be terminal and should probably do more than discarding the exception.")]
		public void LMOEKNBGMHO(Exception PBPEDJNJMOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x39F86B0", Offset = "0x39F70B0", VA = "0x1839F86B0", Slot = "4")]
		private void FEJHIFEAEGI([In] LGGHGMLBJFM<object, DGFMPJAMJNO> LKBGEIGOHEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class MJIBOFPNHOM : BDDDJJCNLJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LGGHGMLBJFM<object, DGFMPJAMJNO> NCABLMNPIEP;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		private MJIBOFPNHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x39F8830", Offset = "0x39F7230", VA = "0x1839F8830")]
		public static MJIBOFPNHOM OLCPJHCMOKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x158C740", Offset = "0x158B140", VA = "0x18158C740")]
		public void CDHELGBAPPD([In] LGGHGMLBJFM<object, DGFMPJAMJNO> LKBGEIGOHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void PBHHBCFIOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85BFA0", Offset = "0x85A9A0", VA = "0x18085BFA0", Slot = "6")]
		public LGGHGMLBJFM<object, DGFMPJAMJNO> NHKNGNMMOFB()
		{
			return default(LGGHGMLBJFM<object, DGFMPJAMJNO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x40444A0", Offset = "0x4042EA0", VA = "0x1840444A0", Slot = "7")]
		[OKMJKJEMLAC("This may be terminal and should probably do more than discarding the exception.")]
		public void LMOEKNBGMHO(Exception PBPEDJNJMOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x39F86B0", Offset = "0x39F70B0", VA = "0x1839F86B0", Slot = "4")]
		private void FEJHIFEAEGI([In] LGGHGMLBJFM<object, DGFMPJAMJNO> LKBGEIGOHEF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JBHDEHHHLOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PLNELFLJKAD<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BOLDNJBHEHG<JNFDKKBIGJN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<LGGHGMLBJFM<object, DGFMPJAMJNO>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C64FA0", Offset = "0x3C639A0", VA = "0x183C64FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C654F0", Offset = "0x3C63EF0", VA = "0x183C654F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct OFLHHMIANKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public PLNELFLJKAD<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BOLDNJBHEHG<JNFDKKBIGJN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x42098F0", Offset = "0x42082F0", VA = "0x1842098F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4209D20", Offset = "0x4208720", VA = "0x184209D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GHCMOALEOLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public PLNELFLJKAD<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public BOLDNJBHEHG<JNFDKKBIGJN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public BOLDNJBHEHG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3983B60", Offset = "0x3982560", VA = "0x183983B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3984200", Offset = "0x3982C00", VA = "0x183984200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IFPDNIGPGGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PLNELFLJKAD<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public BOLDNJBHEHG<JNFDKKBIGJN> senderId;

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
		public BOLDNJBHEHG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private BDDDJJCNLJM <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3BC0", Offset = "0x3AB25C0", VA = "0x183AB3BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5370", Offset = "0x3AB3D70", VA = "0x183AB5370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DNBPNFLLNEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public PLNELFLJKAD<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public BDDDJJCNLJM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private BDDDJJCNLJM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5275520", Offset = "0x5273F20", VA = "0x185275520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5277470", Offset = "0x5275E70", VA = "0x185277470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps GOGJLAAIIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<BOLDNJBHEHG<TMRequest>, TaskCompletionSource<LGGHGMLBJFM<object, DGFMPJAMJNO>>> KIEMNPOJGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OMNCMLNCOAJ<TMRequest> FALKDPCDCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int PGEGOJOBEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task NMELMNBNGJD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps ODGAFHKMBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4311410", Offset = "0x430FE10", VA = "0x184311410")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps OCPMCEJFGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x43110E0", Offset = "0x430FAE0", VA = "0x1843110E0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps GHNODFAGPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x43127E0", Offset = "0x43111E0", VA = "0x1843127E0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KHPPLGFCGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xE0E300", Offset = "0xE0CD00", VA = "0x180E0E300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12115F0", Offset = "0x120FFF0", VA = "0x1812115F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LAJGCPHNPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE17CE0", Offset = "0xE166E0", VA = "0x180E17CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F510", Offset = "0x1D4DF10", VA = "0x181D4F510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PNDGKDPBKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C87B0", Offset = "0x7C71B0", VA = "0x1807C87B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4312F50", Offset = "0x4311950", VA = "0x184312F50")]
	public PLNELFLJKAD(TDeps COBDDACEALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4311A50", Offset = "0x4310450", VA = "0x184311A50")]
	public Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> GEIIGKOCGIH(TRoot AKBOHBAKCNP, TNetSys CGCJGAKHOCM, BOLDNJBHEHG<JNFDKKBIGJN> HJCOBICJDBA, TAction HKIJJKKNOIF, bool GDDNBDKGFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4312020", Offset = "0x4310A20", VA = "0x184312020")]
	[AsyncStateMachine(typeof(PLNELFLJKAD<, , , , , , , , >.JBHDEHHHLOI))]
	private Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> GEIIGKOCGIH(TRoot AKBOHBAKCNP, BOLDNJBHEHG<JNFDKKBIGJN> HJCOBICJDBA, TAction HKIJJKKNOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4312830", Offset = "0x4311230", VA = "0x184312830")]
	[AsyncStateMachine(typeof(PLNELFLJKAD<, , , , , , , , >.OFLHHMIANKE))]
	private Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> OOPKDFKKPFC(TRoot AKBOHBAKCNP, BOLDNJBHEHG<JNFDKKBIGJN> HJCOBICJDBA, TAction[] LCNHLGGJHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4311600", Offset = "0x4310000", VA = "0x184311600")]
	[AsyncStateMachine(typeof(PLNELFLJKAD<, , , , , , , , >.GHCMOALEOLD))]
	public Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> EPMMFPHOCHC(TRoot AKBOHBAKCNP, TNetSys EJIANFOCAPD, TReceiver PENEHNLEHJA, BOLDNJBHEHG<JNFDKKBIGJN> HJCOBICJDBA, BOLDNJBHEHG<TMRequest> HHFNHFOBMEF, TAction HKIJJKKNOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4312C70", Offset = "0x4311670", VA = "0x184312C70")]
	[AsyncStateMachine(typeof(PLNELFLJKAD<, , , , , , , , >.IFPDNIGPGGJ))]
	private Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> PHHPMEGPKKI(TRoot AKBOHBAKCNP, TNetSys EJIANFOCAPD, TReceiver PENEHNLEHJA, BOLDNJBHEHG<JNFDKKBIGJN> HJCOBICJDBA, BOLDNJBHEHG<TMRequest> HHFNHFOBMEF, TAction HKIJJKKNOIF, Task MLEILPAJOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x43112B0", Offset = "0x430FCB0", VA = "0x1843112B0")]
	[AsyncStateMachine(typeof(PLNELFLJKAD<, , , , , , , , >.DNBPNFLLNEK))]
	private Task ADPBNDKKKBE(TRoot AKBOHBAKCNP, TNetSys EJIANFOCAPD, TReceiver PENEHNLEHJA, TAction HKIJJKKNOIF, BDDDJJCNLJM KDPADKNGEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4312440", Offset = "0x4310E40", VA = "0x184312440")]
	private void KIGIFDGJEGP(TRoot AKBOHBAKCNP, TNetSys EJIANFOCAPD, TReceiver PENEHNLEHJA, BOLDNJBHEHG<JNFDKKBIGJN> HJCOBICJDBA, TAction HKIJJKKNOIF, bool BNBLMKKKIJI, bool PCHGNBPFMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BFBIFBHLOKO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface EDBHPBHJBAD<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AODMFPABJNE(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction NADIJJEMGJP(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction AEPDHCGPIBH(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> HIBBOOOAJOL(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] JHEBGNCNHEF(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF, int JFFMKAFAFNM);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NAABNLKHGAK(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JNEHNDGKLNK(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EDOFENGACLI(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool NGBIFFJPPEG(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FGJCDLBGJMC(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool AAKCLCICPJK(TNetSys CJPLBPAGEKE, TAction HKIJJKKNOIF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface GHHHEHGMHDH<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps ODGAFHKMBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps GHNODFAGPFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps OCPMCEJFGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface PJCNBMKOGME<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BOLDNJBHEHG<JNFDKKBIGJN> NHLKGKOEMEO(TReceiver PENEHNLEHJA);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> EPMMFPHOCHC(TReceiver PENEHNLEHJA, TAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] LPKBKBMPFBC(TReceiver PENEHNLEHJA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface KCLNEAGJFEM<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OPIOGDOEPND(TRoot AKBOHBAKCNP);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LMKJMLMOMIB(TRoot AKBOHBAKCNP);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int DELIMPGMOIE(TRoot AKBOHBAKCNP);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BIFJLOCEOPI(TRoot AKBOHBAKCNP);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OIPPHBFKABJ(TRoot AKBOHBAKCNP);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task GEIIGKOCGIH(TRoot AKBOHBAKCNP, BOLDNJBHEHG<JNFDKKBIGJN> HJCOBICJDBA, BOLDNJBHEHG<TMRequest> HHFNHFOBMEF, TAction HKIJJKKNOIF, bool PABCPDBAIOE = true);
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
