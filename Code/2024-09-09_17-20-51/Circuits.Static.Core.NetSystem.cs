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
public struct PPMFJJMLPMN<TPartialAction, TFullAction, TDeps> where TDeps : JGACIGOPMKG.KBKOACPPCHI<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] BBGNFOPFKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int DIKIAKKNNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps GBEKAPOEJCH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x49097A0", Offset = "0x49081A0", VA = "0x1849097A0")]
	internal PPMFJJMLPMN(TPartialAction[] GGJPKBFPDDD, int HCNNKKFIICK, TDeps HBFCALFCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4909730", Offset = "0x4908130", VA = "0x184909730")]
	public static PPMFJJMLPMN<TPartialAction, TFullAction, TDeps> OOAFHJGKFEK(TDeps HBFCALFCDLO)
	{
		return default(PPMFJJMLPMN<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JGACIGOPMKG
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface KBKOACPPCHI<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AHFNMKBHDPJ([In] TPartialAction LMHIPCBJMMO);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction PAJLEINJMFM(TPartialAction[] KJONIHBDAGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7CB0", Offset = "0x2BC66B0", VA = "0x182BC7CB0")]
	public static CPOGLEEFNCN<TFullAction> DFBGJPGHLDD<TFullAction, TPartialAction, TDeps>(this PPMFJJMLPMN<TPartialAction, TFullAction, TDeps> NKCEKILMAAM, TPartialAction LMHIPCBJMMO) where TDeps : KBKOACPPCHI<TPartialAction, TFullAction>
	{
		return default(CPOGLEEFNCN<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OLNCCHFEDMA<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : EAILNJEAAHK.KFBIGMCBFCK<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] FIAGDINEGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int ENBBLPEDNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps GBEKAPOEJCH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x49097F0", Offset = "0x49081F0", VA = "0x1849097F0")]
	internal OLNCCHFEDMA(TPartialSnapshot[] LLLJABCJEGH, int DGGDEBPGGIM, TDeps HBFCALFCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x49096D0", Offset = "0x49080D0", VA = "0x1849096D0")]
	public static OLNCCHFEDMA<TPartialSnapshot, TFullSnapshot, TDeps> OOAFHJGKFEK(TDeps HBFCALFCDLO)
	{
		return default(OLNCCHFEDMA<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EAILNJEAAHK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KFBIGMCBFCK<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AFHKAFJPKHL([In] TPartialSnapshot JHEDMCNFEIE);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot HCENHIBLALA(TPartialSnapshot[] GIODPEIHDDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7B30", Offset = "0x2BC6530", VA = "0x182BC7B30")]
	public static CPOGLEEFNCN<TFullSnapshot> DFBGJPGHLDD<TFullSnapshot, TPartialSnapshot, TDeps>(this OLNCCHFEDMA<TPartialSnapshot, TFullSnapshot, TDeps> NKCEKILMAAM, TPartialSnapshot JHEDMCNFEIE) where TDeps : KFBIGMCBFCK<TPartialSnapshot, TFullSnapshot>
	{
		return default(CPOGLEEFNCN<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7F20", Offset = "0x2BC6920", VA = "0x182BC7F20")]
	public static bool JKPPMHFKFJP<TPartialSnapshot, TFullSnapshot, TDeps>(this OLNCCHFEDMA<TPartialSnapshot, TFullSnapshot, TDeps> NKCEKILMAAM, TPartialSnapshot JHEDMCNFEIE) where TDeps : KFBIGMCBFCK<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class CBGAJFGHEMG : ILCEMBFLKNK
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x215CCC0", Offset = "0x215B6C0", VA = "0x18215CCC0", Slot = "7")]
	public override string OIFECEDJIAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x215CCF0", Offset = "0x215B6F0", VA = "0x18215CCF0")]
	public CBGAJFGHEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HEPFNCDDLGG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : PNEKFBGJCCL.KGDGBFNNNOA<TAction, TNetSys> where TReceiverDeps : PNEKFBGJCCL.LDOMONGBNEC<TAction, TReceiver> where TRootDeps : PNEKFBGJCCL.FFFLEKCCDOL<TMRequest, TAction, TRoot> where TDeps : PNEKFBGJCCL.KOPLKJEDJMB<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface GHGIHJOKJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NNOMDJAPCFB([In] CDOLGFBAJII<object, IDHCEFLHBPO> NLAECIHBKHE);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JFAHICENIIH();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CDOLGFBAJII<object, IDHCEFLHBPO> FFJGMKIEHNM();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EKLPHBGCBFH(Exception JCOJOLLOCIG);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class MFHIEJDELJD : GHGIHJOKJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<CDOLGFBAJII<object, IDHCEFLHBPO>> LACLLDLJKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<CDOLGFBAJII<object, NEIFONLMJBM>> NOCHGDNAGNB;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4693E90", Offset = "0x4692890", VA = "0x184693E90")]
		private MFHIEJDELJD(TaskCompletionSource<CDOLGFBAJII<object, IDHCEFLHBPO>> FEMNMDPKHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E09A00", Offset = "0x3E08400", VA = "0x183E09A00")]
		public static MFHIEJDELJD OOAFHJGKFEK(TaskCompletionSource<CDOLGFBAJII<object, IDHCEFLHBPO>> FEMNMDPKHGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4693D70", Offset = "0x4692770", VA = "0x184693D70")]
		public void NNOMDJAPCFB([In] CDOLGFBAJII<object, IDHCEFLHBPO> NLAECIHBKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4693A90", Offset = "0x4692490", VA = "0x184693A90", Slot = "5")]
		public void JFAHICENIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x46939E0", Offset = "0x46923E0", VA = "0x1846939E0", Slot = "6")]
		public CDOLGFBAJII<object, IDHCEFLHBPO> FFJGMKIEHNM()
		{
			return default(CDOLGFBAJII<object, IDHCEFLHBPO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4693870", Offset = "0x4692270", VA = "0x184693870", Slot = "7")]
		public void EKLPHBGCBFH(Exception JCOJOLLOCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3E06790", Offset = "0x3E05190", VA = "0x183E06790", Slot = "4")]
		private void AGAMJBDNJJC([In] CDOLGFBAJII<object, IDHCEFLHBPO> NLAECIHBKHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class CAKOLIJHDCM : GHGIHJOKJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<CDOLGFBAJII<object, IDHCEFLHBPO>> LACLLDLJKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CDOLGFBAJII<object, IDHCEFLHBPO> EOKJICMHOFO;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
		private CAKOLIJHDCM(TaskCompletionSource<CDOLGFBAJII<object, IDHCEFLHBPO>> FEMNMDPKHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3E09A00", Offset = "0x3E08400", VA = "0x183E09A00")]
		public static CAKOLIJHDCM OOAFHJGKFEK(TaskCompletionSource<CDOLGFBAJII<object, IDHCEFLHBPO>> FEMNMDPKHGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x50974F0", Offset = "0x5095EF0", VA = "0x1850974F0")]
		public void NNOMDJAPCFB([In] CDOLGFBAJII<object, IDHCEFLHBPO> NLAECIHBKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x53DAFB0", Offset = "0x53D99B0", VA = "0x1853DAFB0", Slot = "5")]
		public void JFAHICENIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE738F0", Offset = "0xE722F0", VA = "0x180E738F0", Slot = "6")]
		public CDOLGFBAJII<object, IDHCEFLHBPO> FFJGMKIEHNM()
		{
			return default(CDOLGFBAJII<object, IDHCEFLHBPO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x53DAE90", Offset = "0x53D9890", VA = "0x1853DAE90", Slot = "7")]
		public void EKLPHBGCBFH(Exception JCOJOLLOCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E06790", Offset = "0x3E05190", VA = "0x183E06790", Slot = "4")]
		private void AGAMJBDNJJC([In] CDOLGFBAJII<object, IDHCEFLHBPO> NLAECIHBKHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class FOBOGBPMJCK : GHGIHJOKJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<CDOLGFBAJII<object, IDHCEFLHBPO>> NOCHGDNAGNB;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E06BB0", Offset = "0x3E055B0", VA = "0x183E06BB0")]
		private FOBOGBPMJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3E06AF0", Offset = "0x3E054F0", VA = "0x183E06AF0")]
		public static FOBOGBPMJCK OOAFHJGKFEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3E06930", Offset = "0x3E05330", VA = "0x183E06930")]
		public void NNOMDJAPCFB([In] CDOLGFBAJII<object, IDHCEFLHBPO> NLAECIHBKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void JFAHICENIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3E06870", Offset = "0x3E05270", VA = "0x183E06870", Slot = "6")]
		public CDOLGFBAJII<object, IDHCEFLHBPO> FFJGMKIEHNM()
		{
			return default(CDOLGFBAJII<object, IDHCEFLHBPO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3E067D0", Offset = "0x3E051D0", VA = "0x183E067D0", Slot = "7")]
		[EMMEDCCEFKJ("This may be terminal and should probably do more than discarding the exception.")]
		public void EKLPHBGCBFH(Exception JCOJOLLOCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E06790", Offset = "0x3E05190", VA = "0x183E06790", Slot = "4")]
		private void AGAMJBDNJJC([In] CDOLGFBAJII<object, IDHCEFLHBPO> NLAECIHBKHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class LJAGLKEFJAA : GHGIHJOKJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CDOLGFBAJII<object, IDHCEFLHBPO> EOKJICMHOFO;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		private LJAGLKEFJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3E06AF0", Offset = "0x3E054F0", VA = "0x183E06AF0")]
		public static LJAGLKEFJAA OOAFHJGKFEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1A69780", Offset = "0x1A68180", VA = "0x181A69780")]
		public void NNOMDJAPCFB([In] CDOLGFBAJII<object, IDHCEFLHBPO> NLAECIHBKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void JFAHICENIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9F9DB0", VA = "0x1809FB3B0", Slot = "6")]
		public CDOLGFBAJII<object, IDHCEFLHBPO> FFJGMKIEHNM()
		{
			return default(CDOLGFBAJII<object, IDHCEFLHBPO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4498130", Offset = "0x4496B30", VA = "0x184498130", Slot = "7")]
		[EMMEDCCEFKJ("This may be terminal and should probably do more than discarding the exception.")]
		public void EKLPHBGCBFH(Exception JCOJOLLOCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3E06790", Offset = "0x3E05190", VA = "0x183E06790", Slot = "4")]
		private void AGAMJBDNJJC([In] CDOLGFBAJII<object, IDHCEFLHBPO> NLAECIHBKHE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct AFJOMFKJDBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HEPFNCDDLGG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public OPGJAFEOJCM<POCJNEBPFKP> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<CDOLGFBAJII<object, IDHCEFLHBPO>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E953F0", Offset = "0x3E93DF0", VA = "0x183E953F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E958D0", Offset = "0x3E942D0", VA = "0x183E958D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CDAGGADMHCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HEPFNCDDLGG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OPGJAFEOJCM<POCJNEBPFKP> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x53E2480", Offset = "0x53E0E80", VA = "0x1853E2480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x53E28E0", Offset = "0x53E12E0", VA = "0x1853E28E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LGGDDEFJOMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public HEPFNCDDLGG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public OPGJAFEOJCM<POCJNEBPFKP> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public OPGJAFEOJCM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x448B320", Offset = "0x4489D20", VA = "0x18448B320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x448B700", Offset = "0x448A100", VA = "0x18448B700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PODJDDPHEGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HEPFNCDDLGG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OPGJAFEOJCM<POCJNEBPFKP> senderId;

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
		public OPGJAFEOJCM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private GHGIHJOKJKN <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x49C3680", Offset = "0x49C2080", VA = "0x1849C3680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x49C4330", Offset = "0x49C2D30", VA = "0x1849C4330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct INCMMALEAHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HEPFNCDDLGG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public GHGIHJOKJKN completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private GHGIHJOKJKN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x40AEF10", Offset = "0x40AD910", VA = "0x1840AEF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x40B0E10", Offset = "0x40AF810", VA = "0x1840B0E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps GBEKAPOEJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<OPGJAFEOJCM<TMRequest>, TaskCompletionSource<CDOLGFBAJII<object, IDHCEFLHBPO>>> BOKGJINFGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private JBHOAHEJNPG<TMRequest> LKJOGMKIEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int EADAFCDGBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task NPNNDEGHFIH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps EHOAAKOMLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3F51590", Offset = "0x3F4FF90", VA = "0x183F51590")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps JBJKJENDJND
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F50730", Offset = "0x3F4F130", VA = "0x183F50730")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps PHNOIAHCEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F52270", Offset = "0x3F50C70", VA = "0x183F52270")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MFGGENFLPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB6A4C0", Offset = "0xB68EC0", VA = "0x180B6A4C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x16D15A0", Offset = "0x16CFFA0", VA = "0x1816D15A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MPLOKJCABLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x118EC20", Offset = "0x118D620", VA = "0x18118EC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2002B40", Offset = "0x2001540", VA = "0x182002B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PLFELHGMDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884030", VA = "0x180885630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F525B0", Offset = "0x3F50FB0", VA = "0x183F525B0")]
	public HEPFNCDDLGG(TDeps HBFCALFCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3F50CD0", Offset = "0x3F4F6D0", VA = "0x183F50CD0")]
	public Task<CDOLGFBAJII<object, IDHCEFLHBPO>> EKMPNAJLHLH(TRoot BAFHJDFHJHD, TNetSys FMPMPLIPEOA, OPGJAFEOJCM<POCJNEBPFKP> MMMJCJNILOD, TAction GGEEGOKOMKJ, bool BGANBAIIPIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3F50B70", Offset = "0x3F4F570", VA = "0x183F50B70")]
	[AsyncStateMachine(typeof(HEPFNCDDLGG<, , , , , , , , >.AFJOMFKJDBO))]
	private Task<CDOLGFBAJII<object, IDHCEFLHBPO>> EKMPNAJLHLH(TRoot BAFHJDFHJHD, OPGJAFEOJCM<POCJNEBPFKP> MMMJCJNILOD, TAction GGEEGOKOMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F51DE0", Offset = "0x3F507E0", VA = "0x183F51DE0")]
	[AsyncStateMachine(typeof(HEPFNCDDLGG<, , , , , , , , >.CDAGGADMHCE))]
	private Task<CDOLGFBAJII<object, IDHCEFLHBPO>> HAGAALJDKKE(TRoot BAFHJDFHJHD, OPGJAFEOJCM<POCJNEBPFKP> MMMJCJNILOD, TAction[] HENJBBKOCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3F51F40", Offset = "0x3F50940", VA = "0x183F51F40")]
	[AsyncStateMachine(typeof(HEPFNCDDLGG<, , , , , , , , >.LGGDDEFJOMJ))]
	public Task<CDOLGFBAJII<object, IDHCEFLHBPO>> JBACHCPNJLB(TRoot BAFHJDFHJHD, TNetSys FAOOPFMHONA, TReceiver KEFFHAHOJNE, OPGJAFEOJCM<POCJNEBPFKP> MMMJCJNILOD, OPGJAFEOJCM<TMRequest> CHCOAFEDHAF, TAction GGEEGOKOMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F522A0", Offset = "0x3F50CA0", VA = "0x183F522A0")]
	[AsyncStateMachine(typeof(HEPFNCDDLGG<, , , , , , , , >.PODJDDPHEGL))]
	private Task<CDOLGFBAJII<object, IDHCEFLHBPO>> KNFMOLNHOIH(TRoot BAFHJDFHJHD, TNetSys FAOOPFMHONA, TReceiver KEFFHAHOJNE, OPGJAFEOJCM<POCJNEBPFKP> MMMJCJNILOD, OPGJAFEOJCM<TMRequest> CHCOAFEDHAF, TAction GGEEGOKOMKJ, Task HFLLLIAHIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F508C0", Offset = "0x3F4F2C0", VA = "0x183F508C0")]
	[AsyncStateMachine(typeof(HEPFNCDDLGG<, , , , , , , , >.INCMMALEAHN))]
	private Task DLBNFGDOFFA(TRoot BAFHJDFHJHD, TNetSys FAOOPFMHONA, TReceiver KEFFHAHOJNE, TAction GGEEGOKOMKJ, GHGIHJOKJKN KFMHKHABBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F515C0", Offset = "0x3F4FFC0", VA = "0x183F515C0")]
	private void GPHIKOLCNDH(TRoot BAFHJDFHJHD, TNetSys FAOOPFMHONA, TReceiver KEFFHAHOJNE, OPGJAFEOJCM<POCJNEBPFKP> MMMJCJNILOD, TAction GGEEGOKOMKJ, bool LPBEIBBNBKG, bool NIAKDFPCIJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PNEKFBGJCCL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KGDGBFNNNOA<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NBKBBADGAGE(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction HCDOLCAFGGL(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction CHCLAHIDCBB(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> BGALOOOEPJP(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] CFAGPGHNGJM(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ, int JMAGMPLKGDL);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GFNDCINPGKA(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool BPEMKAKLPEB(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LLMMABFHAJL(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool PKJHGGAPEFH(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool JCNDPADPLKN(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool ENGLCGGJJLF(TNetSys PJAMCMOCBJH, TAction GGEEGOKOMKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KOPLKJEDJMB<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps EHOAAKOMLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps PHNOIAHCEGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps JBJKJENDJND
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface LDOMONGBNEC<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OPGJAFEOJCM<POCJNEBPFKP> JBBGMPMFMJK(TReceiver KEFFHAHOJNE);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CDOLGFBAJII<object, IDHCEFLHBPO>> JBACHCPNJLB(TReceiver KEFFHAHOJNE, TAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] LHOHJDNGINO(TReceiver KEFFHAHOJNE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface FFFLEKCCDOL<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ALEONHPJOJE(TRoot BAFHJDFHJHD);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LLJGNCNKIPM(TRoot BAFHJDFHJHD);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int OFFMNCLGAIL(TRoot BAFHJDFHJHD);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int ONPPPHIDBAB(TRoot BAFHJDFHJHD);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EJKJKMKMBMG(TRoot BAFHJDFHJHD);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task EKMPNAJLHLH(TRoot BAFHJDFHJHD, OPGJAFEOJCM<POCJNEBPFKP> MMMJCJNILOD, OPGJAFEOJCM<TMRequest> CHCOAFEDHAF, TAction GGEEGOKOMKJ, bool MHDELAGCGAF = true);
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
