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
public struct BCLKMBLKBBB<TPartialAction, TFullAction, TDeps> where TDeps : KBKNGFMIHBJ.EFJFCPNHLMA<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] CMPOCFCFENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int OCGEBHDNCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps KKHHCBLJJJL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0620", Offset = "0x3ACEE20", VA = "0x183AD0620")]
	internal BCLKMBLKBBB(TPartialAction[] PNCOHEJFHCP, int IHFCOPFBLML, TDeps DNJOEPEBEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0500", Offset = "0x3ACED00", VA = "0x183AD0500")]
	public static BCLKMBLKBBB<TPartialAction, TFullAction, TDeps> OJFFIHPLODM(TDeps DNJOEPEBEMJ)
	{
		return default(BCLKMBLKBBB<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KBKNGFMIHBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EFJFCPNHLMA<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IPKJLBNEIMP([In] TPartialAction FOJJEODKFKL);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction LHNKINMGCEI(TPartialAction[] CBIGELEDANN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B21800", Offset = "0x2B20000", VA = "0x182B21800")]
	public static JPEFLPACLHE<TFullAction> JIKMDLAAAFL<TFullAction, TPartialAction, TDeps>(this BCLKMBLKBBB<TPartialAction, TFullAction, TDeps> EGJINJKGIAK, TPartialAction FOJJEODKFKL) where TDeps : EFJFCPNHLMA<TPartialAction, TFullAction>
	{
		return default(JPEFLPACLHE<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FDBIHECNLKD<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : CECLJKAAPLF.FBEBCEGOADC<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] LABIIAEKPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int JBACIEPNGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps KKHHCBLJJJL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0620", Offset = "0x3ACEE20", VA = "0x183AD0620")]
	internal FDBIHECNLKD(TPartialSnapshot[] DFKOOHIFAMJ, int LDILANFPBNF, TDeps DNJOEPEBEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0500", Offset = "0x3ACED00", VA = "0x183AD0500")]
	public static FDBIHECNLKD<TPartialSnapshot, TFullSnapshot, TDeps> OJFFIHPLODM(TDeps DNJOEPEBEMJ)
	{
		return default(FDBIHECNLKD<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CECLJKAAPLF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FBEBCEGOADC<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NFAOLGAPGGL([In] TPartialSnapshot PEDFGKDGNBE);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot EOOAGFPJADI(TPartialSnapshot[] ODLNFHJAJKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x289CA90", Offset = "0x289B290", VA = "0x18289CA90")]
	public static JPEFLPACLHE<TFullSnapshot> JIKMDLAAAFL<TFullSnapshot, TPartialSnapshot, TDeps>(this FDBIHECNLKD<TPartialSnapshot, TFullSnapshot, TDeps> EGJINJKGIAK, TPartialSnapshot PEDFGKDGNBE) where TDeps : FBEBCEGOADC<TPartialSnapshot, TFullSnapshot>
	{
		return default(JPEFLPACLHE<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x289CE90", Offset = "0x289B690", VA = "0x18289CE90")]
	public static bool PKLHBAKKOHM<TPartialSnapshot, TFullSnapshot, TDeps>(this FDBIHECNLKD<TPartialSnapshot, TFullSnapshot, TDeps> EGJINJKGIAK, TPartialSnapshot PEDFGKDGNBE) where TDeps : FBEBCEGOADC<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class EHMCFOCBDDC : FDKFIPGCOGB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F4D540", Offset = "0x1F4BD40", VA = "0x181F4D540", Slot = "7")]
	public override string ILHCPMBLOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F4D570", Offset = "0x1F4BD70", VA = "0x181F4D570")]
	public EHMCFOCBDDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HPNHIINLOMA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : CHGIKMOFLHD.CNDMEMJOEFP<TAction, TNetSys> where TReceiverDeps : CHGIKMOFLHD.EMGGKBOKKPF<TAction, TReceiver> where TRootDeps : CHGIKMOFLHD.LAKAOLKAEBM<TMRequest, TAction, TRoot> where TDeps : CHGIKMOFLHD.PKLJNPAEDLA<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface AKNILNHAAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NOKGHBFJGCI([In] MEKCEIEFNPI<object, MNGIPKBLGNG> KKBKNCNBBJP);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GLIJLFBKGHP();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MEKCEIEFNPI<object, MNGIPKBLGNG> BEDEGHIJPHF();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ICAAIKGEMDH(Exception BCGGAGLBPHE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class KCLFLPAPMOC : AKNILNHAAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<MEKCEIEFNPI<object, MNGIPKBLGNG>> AIAEJINJCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<MEKCEIEFNPI<object, DCIBOGBGGHI>> JNLOMJEOBAC;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4083D30", Offset = "0x4082530", VA = "0x184083D30")]
		private KCLFLPAPMOC(TaskCompletionSource<MEKCEIEFNPI<object, MNGIPKBLGNG>> EIMIBCHGJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3747810", Offset = "0x3746010", VA = "0x183747810")]
		public static KCLFLPAPMOC OJFFIHPLODM(TaskCompletionSource<MEKCEIEFNPI<object, MNGIPKBLGNG>> EIMIBCHGJKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4083AF0", Offset = "0x40822F0", VA = "0x184083AF0")]
		public void NOKGHBFJGCI([In] MEKCEIEFNPI<object, MNGIPKBLGNG> KKBKNCNBBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4083870", Offset = "0x4082070", VA = "0x184083870", Slot = "5")]
		public void GLIJLFBKGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4083710", Offset = "0x4081F10", VA = "0x184083710", Slot = "6")]
		public MEKCEIEFNPI<object, MNGIPKBLGNG> BEDEGHIJPHF()
		{
			return default(MEKCEIEFNPI<object, MNGIPKBLGNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4083A30", Offset = "0x4082230", VA = "0x184083A30", Slot = "7")]
		public void ICAAIKGEMDH(Exception BCGGAGLBPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8E00", Offset = "0x3BD7600", VA = "0x183BD8E00", Slot = "4")]
		private void DHGAIAKHKKD([In] MEKCEIEFNPI<object, MNGIPKBLGNG> KKBKNCNBBJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class JJEHIMAECLB : AKNILNHAAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<MEKCEIEFNPI<object, MNGIPKBLGNG>> AIAEJINJCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MEKCEIEFNPI<object, MNGIPKBLGNG> MCJNOICBODD;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
		private JJEHIMAECLB(TaskCompletionSource<MEKCEIEFNPI<object, MNGIPKBLGNG>> EIMIBCHGJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3747810", Offset = "0x3746010", VA = "0x183747810")]
		public static JJEHIMAECLB OJFFIHPLODM(TaskCompletionSource<MEKCEIEFNPI<object, MNGIPKBLGNG>> EIMIBCHGJKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6030", Offset = "0x3FA4830", VA = "0x183FA6030")]
		public void NOKGHBFJGCI([In] MEKCEIEFNPI<object, MNGIPKBLGNG> KKBKNCNBBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5F10", Offset = "0x3FA4710", VA = "0x183FA5F10", Slot = "5")]
		public void GLIJLFBKGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xBF3DE0", Offset = "0xBF25E0", VA = "0x180BF3DE0", Slot = "6")]
		public MEKCEIEFNPI<object, MNGIPKBLGNG> BEDEGHIJPHF()
		{
			return default(MEKCEIEFNPI<object, MNGIPKBLGNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5FD0", Offset = "0x3FA47D0", VA = "0x183FA5FD0", Slot = "7")]
		public void ICAAIKGEMDH(Exception BCGGAGLBPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8E00", Offset = "0x3BD7600", VA = "0x183BD8E00", Slot = "4")]
		private void DHGAIAKHKKD([In] MEKCEIEFNPI<object, MNGIPKBLGNG> KKBKNCNBBJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class MMOMANPIAOM : AKNILNHAAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<MEKCEIEFNPI<object, MNGIPKBLGNG>> JNLOMJEOBAC;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x43BC590", Offset = "0x43BAD90", VA = "0x1843BC590")]
		private MMOMANPIAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8EE0", Offset = "0x3BD76E0", VA = "0x183BD8EE0")]
		public static MMOMANPIAOM OJFFIHPLODM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x43BC420", Offset = "0x43BAC20", VA = "0x1843BC420")]
		public void NOKGHBFJGCI([In] MEKCEIEFNPI<object, MNGIPKBLGNG> KKBKNCNBBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public void GLIJLFBKGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x43BC1E0", Offset = "0x43BA9E0", VA = "0x1843BC1E0", Slot = "6")]
		public MEKCEIEFNPI<object, MNGIPKBLGNG> BEDEGHIJPHF()
		{
			return default(MEKCEIEFNPI<object, MNGIPKBLGNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x43BC2A0", Offset = "0x43BAAA0", VA = "0x1843BC2A0", Slot = "7")]
		[MJCEKHIGJMA("This may be terminal and should probably do more than discarding the exception.")]
		public void ICAAIKGEMDH(Exception BCGGAGLBPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8E00", Offset = "0x3BD7600", VA = "0x183BD8E00", Slot = "4")]
		private void DHGAIAKHKKD([In] MEKCEIEFNPI<object, MNGIPKBLGNG> KKBKNCNBBJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class GGODECALHKO : AKNILNHAAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private MEKCEIEFNPI<object, MNGIPKBLGNG> MCJNOICBODD;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private GGODECALHKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8EE0", Offset = "0x3BD76E0", VA = "0x183BD8EE0")]
		public static GGODECALHKO OJFFIHPLODM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1698AB0", Offset = "0x16972B0", VA = "0x181698AB0")]
		public void NOKGHBFJGCI([In] MEKCEIEFNPI<object, MNGIPKBLGNG> KKBKNCNBBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public void GLIJLFBKGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0", Slot = "6")]
		public MEKCEIEFNPI<object, MNGIPKBLGNG> BEDEGHIJPHF()
		{
			return default(MEKCEIEFNPI<object, MNGIPKBLGNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8E90", Offset = "0x3BD7690", VA = "0x183BD8E90", Slot = "7")]
		[MJCEKHIGJMA("This may be terminal and should probably do more than discarding the exception.")]
		public void ICAAIKGEMDH(Exception BCGGAGLBPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8E00", Offset = "0x3BD7600", VA = "0x183BD8E00", Slot = "4")]
		private void DHGAIAKHKKD([In] MEKCEIEFNPI<object, MNGIPKBLGNG> KKBKNCNBBJP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PLKPCDKPBKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HPNHIINLOMA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KPFGDODNFBO<DFFIIDMIKOJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<MEKCEIEFNPI<object, MNGIPKBLGNG>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4667360", Offset = "0x4665B60", VA = "0x184667360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x46678D0", Offset = "0x46660D0", VA = "0x1846678D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CNGNJCADAEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HPNHIINLOMA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public KPFGDODNFBO<DFFIIDMIKOJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5081DB0", Offset = "0x50805B0", VA = "0x185081DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x50822A0", Offset = "0x5080AA0", VA = "0x1850822A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BNDCJCALPGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public HPNHIINLOMA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public KPFGDODNFBO<DFFIIDMIKOJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public KPFGDODNFBO<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D3D330", Offset = "0x4D3BB30", VA = "0x184D3D330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D3DA00", Offset = "0x4D3C200", VA = "0x184D3DA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct POOHFFNFJLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HPNHIINLOMA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public KPFGDODNFBO<DFFIIDMIKOJ> senderId;

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
		public KPFGDODNFBO<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private AKNILNHAAKE <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4687DF0", Offset = "0x46865F0", VA = "0x184687DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4688B00", Offset = "0x4687300", VA = "0x184688B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HGDPKMIGEOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HPNHIINLOMA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AKNILNHAAKE completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private AKNILNHAAKE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3CA71E0", Offset = "0x3CA59E0", VA = "0x183CA71E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3CAB270", Offset = "0x3CA9A70", VA = "0x183CAB270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps KKHHCBLJJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<KPFGDODNFBO<TMRequest>, TaskCompletionSource<MEKCEIEFNPI<object, MNGIPKBLGNG>>> OJBKFPFJLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EEJDLNBJCLL<TMRequest> JPFHOMIHKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int EGKHDOAOMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task GDDCPDHJKJL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps DNNBBBCCHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2DC0", Offset = "0x3CD15C0", VA = "0x183CD2DC0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps PJNFLPKHMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2D40", Offset = "0x3CD1540", VA = "0x183CD2D40")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps KFJKEGKEMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0E50", Offset = "0x3CCF650", VA = "0x183CD0E50")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NMDCIOLIHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E26B0", Offset = "0x8E0EB0", VA = "0x1808E26B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1337CC0", Offset = "0x13364C0", VA = "0x181337CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LFJCDFIDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xEF17E0", Offset = "0xEEFFE0", VA = "0x180EF17E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1DFDFB0", Offset = "0x1DFC7B0", VA = "0x181DFDFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CPOIHMDANNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84CE60", Offset = "0x84B660", VA = "0x18084CE60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2F80", Offset = "0x3CD1780", VA = "0x183CD2F80")]
	public HPNHIINLOMA(TDeps DNJOEPEBEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CD16F0", Offset = "0x3CCFEF0", VA = "0x183CD16F0")]
	public Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> GLFCEICCAAA(TRoot AHKBBGKKCNK, TNetSys LHHJKBKAPIN, KPFGDODNFBO<DFFIIDMIKOJ> DEDFBLKFGCL, TAction BMOCGPMNBAF, bool IFCNCLOFHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0ED0", Offset = "0x3CCF6D0", VA = "0x183CD0ED0")]
	[AsyncStateMachine(typeof(HPNHIINLOMA<, , , , , , , , >.PLKPCDKPBKA))]
	private Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> GLFCEICCAAA(TRoot AHKBBGKKCNK, KPFGDODNFBO<DFFIIDMIKOJ> DEDFBLKFGCL, TAction BMOCGPMNBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2170", Offset = "0x3CD0970", VA = "0x183CD2170")]
	[AsyncStateMachine(typeof(HPNHIINLOMA<, , , , , , , , >.CNGNJCADAEB))]
	private Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> KHALGDGFCNJ(TRoot AHKBBGKKCNK, KPFGDODNFBO<DFFIIDMIKOJ> DEDFBLKFGCL, TAction[] GACINIPOCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1EA0", Offset = "0x3CD06A0", VA = "0x183CD1EA0")]
	[AsyncStateMachine(typeof(HPNHIINLOMA<, , , , , , , , >.BNDCJCALPGG))]
	public Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> JHLMFAEHBED(TRoot AHKBBGKKCNK, TNetSys ALBFODMNGOF, TReceiver GALEHIKOJBA, KPFGDODNFBO<DFFIIDMIKOJ> DEDFBLKFGCL, KPFGDODNFBO<TMRequest> EFNPOFGBGLO, TAction BMOCGPMNBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2460", Offset = "0x3CD0C60", VA = "0x183CD2460")]
	[AsyncStateMachine(typeof(HPNHIINLOMA<, , , , , , , , >.POOHFFNFJLH))]
	private Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> LDFPFMCEDJM(TRoot AHKBBGKKCNK, TNetSys ALBFODMNGOF, TReceiver GALEHIKOJBA, KPFGDODNFBO<DFFIIDMIKOJ> DEDFBLKFGCL, KPFGDODNFBO<TMRequest> EFNPOFGBGLO, TAction BMOCGPMNBAF, Task JHDJENPDFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1A70", Offset = "0x3CD0270", VA = "0x183CD1A70")]
	[AsyncStateMachine(typeof(HPNHIINLOMA<, , , , , , , , >.HGDPKMIGEOF))]
	private Task JABIPPIKIGM(TRoot AHKBBGKKCNK, TNetSys ALBFODMNGOF, TReceiver GALEHIKOJBA, TAction BMOCGPMNBAF, AKNILNHAAKE PHDMDLJGEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD25E0", Offset = "0x3CD0DE0", VA = "0x183CD25E0")]
	private void MBGEICKGFBL(TRoot AHKBBGKKCNK, TNetSys ALBFODMNGOF, TReceiver GALEHIKOJBA, KPFGDODNFBO<DFFIIDMIKOJ> DEDFBLKFGCL, TAction BMOCGPMNBAF, bool CCBBJHGBCAK, bool BHPOPJGBHNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CHGIKMOFLHD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface CNDMEMJOEFP<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CLFKLPPACHI(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction KLABIHKIBIF(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction DDCDNKBMAPM(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> HJHDFCEMEHD(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] KNDPFBFDFOE(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF, int BMJHLNEKCFG);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NFAPKBBIFLJ(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JKDHAECINDP(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool APOJIKCOKAF(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CDABCBJBDFE(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ALGJOBJOLGJ(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool EJNIHPOKOFA(TNetSys AFDJFGJJOLK, TAction BMOCGPMNBAF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface PKLJNPAEDLA<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps DNNBBBCCHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps KFJKEGKEMPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps PJNFLPKHMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EMGGKBOKKPF<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KPFGDODNFBO<DFFIIDMIKOJ> KBGADOGIAAN(TReceiver GALEHIKOJBA);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> JHLMFAEHBED(TReceiver GALEHIKOJBA, TAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] EODGDKJCOJD(TReceiver GALEHIKOJBA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface LAKAOLKAEBM<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GKNJDCLMMLL(TRoot AHKBBGKKCNK);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int HMGDPMCIHKM(TRoot AHKBBGKKCNK);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int DKBLMJGMCPO(TRoot AHKBBGKKCNK);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int GFPEOEIDKKA(TRoot AHKBBGKKCNK);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CLPNILOLJKO(TRoot AHKBBGKKCNK);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task GLFCEICCAAA(TRoot AHKBBGKKCNK, KPFGDODNFBO<DFFIIDMIKOJ> DEDFBLKFGCL, KPFGDODNFBO<TMRequest> EFNPOFGBGLO, TAction BMOCGPMNBAF, bool DOAENEBFCLH = true);
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
