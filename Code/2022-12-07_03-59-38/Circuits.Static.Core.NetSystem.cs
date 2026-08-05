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
public interface PFJAIGGCIOO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PAJEIHKIMDM(in TAction MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction EFFMKMOKHKC(in TAction MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction HAGGIHFOPGG(in TAction MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> AGCDGNGOCDH(in TAction MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BFCBHLAKIDP(in TAction MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ENOLLDNPCHJ(in TAction MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EJKBLCPBMEF(in TAction MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HBLLDANFCHJ(in TAction MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JCHFDDBMCFN(in TAction MNJNLIAKBME);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EGEPPKFBOAB<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::JMEFGJDEPFN<KPJMGPLJJBE> LMNAIFOJHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHGNEKDGIAH();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPONECAHMDM(global::JMEFGJDEPFN<POLNMNHKKHA> JLCECPGLFFH, in TAction MNJNLIAKBME);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OEBPAGLKOIL<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult DMONAEFNPIF(in TAction MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] IJJCFNIPGAA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JHLKDNDIOJH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PPFLNBBHOMC(TPartialSnapshot NAIMCEMKOEO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot BLGPDDEALNP(TPartialSnapshot[] MFAAJDEKCBC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class KPJMGPLJJBE
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class POLNMNHKKHA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PHMFOENONIN<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::OEBPAGLKOIL<TAction, Task<global::DGDFIFNFPJI<object, DLGHCKKHLGP>>> where TActionDeps : global::PFJAIGGCIOO<TAction> where TStaticNetSysDeps : global::EGEPPKFBOAB<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private interface OJDOBIPFOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void POACFENKDOD(in global::DGDFIFNFPJI<object, DLGHCKKHLGP> HJIMPKKMPML);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JEIMLNDEFMI();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::DGDFIFNFPJI<object, DLGHCKKHLGP> NCGEGCLBADC();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FHLDKFHLOFE(Exception CFGIDIAFBCD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class CNKOOIMPNMN : OJDOBIPFOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> FDHFMPJADFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> MNJEFIGHINM;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x30F5D50", Offset = "0x30F4950", VA = "0x1830F5D50")]
		private CNKOOIMPNMN(TaskCompletionSource<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> AMOHOGJPIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2C47E50", Offset = "0x2C46A50", VA = "0x182C47E50")]
		public static CNKOOIMPNMN GADFBDMBHED(TaskCompletionSource<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> AMOHOGJPIFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x30F5CF0", Offset = "0x30F48F0", VA = "0x1830F5CF0")]
		public void POACFENKDOD(in global::DGDFIFNFPJI<object, DLGHCKKHLGP> HJIMPKKMPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x30F5B60", Offset = "0x30F4760", VA = "0x1830F5B60", Slot = "5")]
		public void JEIMLNDEFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x30F5C40", Offset = "0x30F4840", VA = "0x1830F5C40", Slot = "6")]
		public global::DGDFIFNFPJI<object, DLGHCKKHLGP> NCGEGCLBADC()
		{
			return default(global::DGDFIFNFPJI<object, DLGHCKKHLGP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x30F5B00", Offset = "0x30F4700", VA = "0x1830F5B00", Slot = "7")]
		public void FHLDKFHLOFE(Exception CFGIDIAFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2D97610", Offset = "0x2D96210", VA = "0x182D97610", Slot = "4")]
		private void JMBPBELAFIJ(in global::DGDFIFNFPJI<object, DLGHCKKHLGP> HJIMPKKMPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class JFNBNLJLJOB : OJDOBIPFOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> FDHFMPJADFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::DGDFIFNFPJI<object, DLGHCKKHLGP> CLMBPJDELAP;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x26FDAA0", Offset = "0x26FC6A0", VA = "0x1826FDAA0")]
		private JFNBNLJLJOB(TaskCompletionSource<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> AMOHOGJPIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2C47E50", Offset = "0x2C46A50", VA = "0x182C47E50")]
		public static JFNBNLJLJOB GADFBDMBHED(TaskCompletionSource<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> AMOHOGJPIFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x77AF30", Offset = "0x779B30", VA = "0x18077AF30")]
		public void POACFENKDOD(in global::DGDFIFNFPJI<object, DLGHCKKHLGP> HJIMPKKMPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x31D5CE0", Offset = "0x31D48E0", VA = "0x1831D5CE0", Slot = "5")]
		public void JEIMLNDEFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x714C90", Offset = "0x713890", VA = "0x180714C90", Slot = "6")]
		public global::DGDFIFNFPJI<object, DLGHCKKHLGP> NCGEGCLBADC()
		{
			return default(global::DGDFIFNFPJI<object, DLGHCKKHLGP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x31D5C80", Offset = "0x31D4880", VA = "0x1831D5C80", Slot = "7")]
		public void FHLDKFHLOFE(Exception CFGIDIAFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2D97610", Offset = "0x2D96210", VA = "0x182D97610", Slot = "4")]
		private void JMBPBELAFIJ(in global::DGDFIFNFPJI<object, DLGHCKKHLGP> HJIMPKKMPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class AGBGKAIDHMA : OJDOBIPFOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> MNJEFIGHINM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3056CB0", Offset = "0x30558B0", VA = "0x183056CB0")]
		private AGBGKAIDHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3056B30", Offset = "0x3055730", VA = "0x183056B30")]
		public static AGBGKAIDHMA GADFBDMBHED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3056C50", Offset = "0x3055850", VA = "0x183056C50")]
		public void POACFENKDOD(in global::DGDFIFNFPJI<object, DLGHCKKHLGP> HJIMPKKMPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		public void JEIMLNDEFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3056BF0", Offset = "0x30557F0", VA = "0x183056BF0", Slot = "6")]
		public global::DGDFIFNFPJI<object, DLGHCKKHLGP> NCGEGCLBADC()
		{
			return default(global::DGDFIFNFPJI<object, DLGHCKKHLGP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
		public void FHLDKFHLOFE(Exception CFGIDIAFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2D97610", Offset = "0x2D96210", VA = "0x182D97610", Slot = "4")]
		private void JMBPBELAFIJ(in global::DGDFIFNFPJI<object, DLGHCKKHLGP> HJIMPKKMPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class CBFLGOHKIHG : OJDOBIPFOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::DGDFIFNFPJI<object, DLGHCKKHLGP> CLMBPJDELAP;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		private CBFLGOHKIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3056B30", Offset = "0x3055730", VA = "0x183056B30")]
		public static CBFLGOHKIHG GADFBDMBHED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x706FF0", Offset = "0x705BF0", VA = "0x180706FF0")]
		public void POACFENKDOD(in global::DGDFIFNFPJI<object, DLGHCKKHLGP> HJIMPKKMPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		public void JEIMLNDEFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D9C90", Offset = "0x6D8890", VA = "0x1806D9C90", Slot = "6")]
		public global::DGDFIFNFPJI<object, DLGHCKKHLGP> NCGEGCLBADC()
		{
			return default(global::DGDFIFNFPJI<object, DLGHCKKHLGP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
		public void FHLDKFHLOFE(Exception CFGIDIAFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2D97610", Offset = "0x2D96210", VA = "0x182D97610", Slot = "4")]
		private void JMBPBELAFIJ(in global::DGDFIFNFPJI<object, DLGHCKKHLGP> HJIMPKKMPML)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FHJDAGBFJME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::PHMFOENONIN<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::JMEFGJDEPFN<KPJMGPLJJBE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::JMEFGJDEPFN<POLNMNHKKHA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C7D0", Offset = "0x3A0B3D0", VA = "0x183A0C7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3A0CA80", Offset = "0x3A0B680", VA = "0x183A0CA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct ONIAGHNJOIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::PHMFOENONIN<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::JMEFGJDEPFN<KPJMGPLJJBE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::JMEFGJDEPFN<POLNMNHKKHA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OJDOBIPFOOI <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4620B30", Offset = "0x461F730", VA = "0x184620B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4621380", Offset = "0x461FF80", VA = "0x184621380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MKBDILCNHNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::PHMFOENONIN<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public OJDOBIPFOOI completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private OJDOBIPFOOI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3D97C00", Offset = "0x3D96800", VA = "0x183D97C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver HJDONPBJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps MLAJOFLMBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps MGOCPJNMOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int AFDPANPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int FCBCPOFOLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::JMEFGJDEPFN<POLNMNHKKHA>, TaskCompletionSource<global::DGDFIFNFPJI<object, DLGHCKKHLGP>>> KEFMDDOBIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private global::CMNANPAKKAP<POLNMNHKKHA> JBNJNHJLDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int KMBCGACCDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task ANNEMMKFIBE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ENKLPLAGLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D9480", Offset = "0x8D8080", VA = "0x1808D9480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D9C10", Offset = "0x8D8810", VA = "0x1808D9C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE960", Offset = "0x2DDD560", VA = "0x182DDE960")]
	protected PHMFOENONIN(TActionDeps CEBALFFNLCH, TStaticNetSysDeps HNDNEPFOGMI, int LBGHNJCFGHF, int PFKOEOEKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE1A0", Offset = "0x2DDCDA0", VA = "0x182DDE1A0")]
	public static global::PHMFOENONIN<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> GADFBDMBHED(TActionDeps CEBALFFNLCH, TStaticNetSysDeps HNDNEPFOGMI, [Optional] int? LBGHNJCFGHF, [Optional] int? PFKOEOEKFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE650", Offset = "0x2DDD250", VA = "0x182DDE650")]
	public Task<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> LPONECAHMDM(in TAction MNJNLIAKBME, bool CNDJAFLGADI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2DDDEF0", Offset = "0x2DDCAF0", VA = "0x182DDDEF0")]
	public void ACHOBBBJGHJ(in TActionReceiver DGNKOMAPBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE040", Offset = "0x2DDCC40", VA = "0x182DDE040")]
	[AsyncStateMachine(typeof(global::PHMFOENONIN<, , , >.FHJDAGBFJME))]
	public Task<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> DMONAEFNPIF(global::JMEFGJDEPFN<KPJMGPLJJBE> EAIIKDHHCAH, global::JMEFGJDEPFN<POLNMNHKKHA> JLCECPGLFFH, TAction MNJNLIAKBME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE4E0", Offset = "0x2DDD0E0", VA = "0x182DDE4E0")]
	[AsyncStateMachine(typeof(global::PHMFOENONIN<, , , >.ONIAGHNJOIK))]
	private Task<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> LIPDOHJIOGK(global::JMEFGJDEPFN<KPJMGPLJJBE> EAIIKDHHCAH, global::JMEFGJDEPFN<POLNMNHKKHA> JLCECPGLFFH, TAction MNJNLIAKBME, Task HEDODFLLDCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2DDDF00", Offset = "0x2DDCB00", VA = "0x182DDDF00")]
	[AsyncStateMachine(typeof(global::PHMFOENONIN<, , , >.MKBDILCNHNF))]
	private Task BHKMOIOBJNP(TAction MNJNLIAKBME, OJDOBIPFOOI OCNOFMHDBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE2E0", Offset = "0x2DDCEE0", VA = "0x182DDE2E0")]
	private void JFAJPMGGANK(TAction MNJNLIAKBME, bool ONFKKHMFPDC, bool MJKDAGCEIKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KGKNJECHCLC<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::JHLKDNDIOJH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] KMCANKABOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int BGIPPGDGKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps KGBPPPCHNGO;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D03350", Offset = "0x2D01F50", VA = "0x182D03350")]
	internal KGKNJECHCLC(TPartialSnapshot[] FIBEGOACELN, int AHNGKODOPAD, TDeps GCFJADAOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D02D00", Offset = "0x2D01900", VA = "0x182D02D00")]
	public global::FLKGEODDKIO<TFullSnapshot> BOPFINHPHMO(TPartialSnapshot NAIMCEMKOEO)
	{
		return default(global::FLKGEODDKIO<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D03180", Offset = "0x2D01D80", VA = "0x182D03180")]
	public bool ECLFGIOIIPN(TPartialSnapshot NAIMCEMKOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D032F0", Offset = "0x2D01EF0", VA = "0x182D032F0")]
	public static global::KGKNJECHCLC<TPartialSnapshot, TFullSnapshot, TDeps> GADFBDMBHED(TDeps GCFJADAOFIH)
	{
		return default(global::KGKNJECHCLC<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NFOGJFKBPJH : DLGHCKKHLGP
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x60A28C0", Offset = "0x60A14C0", VA = "0x1860A28C0", Slot = "5")]
	public override string NEIJODKECBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x27355E0", Offset = "0x27341E0", VA = "0x1827355E0")]
	public NFOGJFKBPJH()
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
