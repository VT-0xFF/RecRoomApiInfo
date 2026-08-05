using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct IBIEDNIACAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PJJAFJGOIGO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable, global::ACOFMMOHBHI<global::NIIAMMJDGBF<LFIMOPGKNHA>, global::NIIAMMJDGBF<LAIHPLCBCID>, TRpcParam, TRpcReceiver, global::NIIAMMJDGBF<MIHFMOMICGO>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::IAJNAKGDMGK<TAction, Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>>, TActionReceiver> where TRpcReceiver : global::CHCHKNIIJNE<TRpcParam> where TActionReceiver : global::AHGIFHHEOPA<TAction, Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>>> where TActionDeps : global::CJFJIFDKMJF<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class HNKBLKLOHDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::PJJAFJGOIGO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public HNKBLKLOHDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class ICFCJFMPCOE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public ICFCJFMPCOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskCompletionSource<global::FHODMMLKDCI<object, IJNOAGNJEPI>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private TaskAwaiter<global::FHODMMLKDCI<object, IJNOAGNJEPI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3730170", Offset = "0x372ED70", VA = "0x183730170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x77BFA0", Offset = "0x77ABA0", VA = "0x18077BFA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::FHODMMLKDCI<object, IJNOAGNJEPI>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HNKBLKLOHDN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		public ICFCJFMPCOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37270C0", Offset = "0x3725CC0", VA = "0x1837270C0")]
		[AsyncStateMachine(typeof(global::PJJAFJGOIGO<, , , , , >.ICFCJFMPCOE.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OGLFLFKGHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::NIIAMMJDGBF<IBIEDNIACAG>, global::NIIAMMJDGBF<LFIMOPGKNHA>> HMEJPJMCOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::NIIAMMJDGBF<IBIEDNIACAG>> ANALFBADMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::GICOKBCIMJP<int> NPOEHKPBJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::NIIAMMJDGBF<LAIHPLCBCID> ActorId, global::NIIAMMJDGBF<ILPDIEMIAFN> RequestId, TAction Action)> NGIHHHFCEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool NHOOONFPABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> AMDAINBLBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::BJBLHBACJBM<FAIOLPEPKDJ, global::NIIAMMJDGBF<LAIHPLCBCID>, TRpcParam, TRpcReceiver, global::FBPBJCKOLAK<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MKFJFIIBKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::MIIEDBEEEIH<TAction, TActionReceiver, TActionDeps, global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> FJBMKAECHDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool BGNOKPACJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x372A230", Offset = "0x3728E30", VA = "0x18372A230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::NIIAMMJDGBF<LAIHPLCBCID> KNPOIGBLIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x372A4A0", Offset = "0x37290A0", VA = "0x18372A4A0", Slot = "5")]
		get
		{
			return default(global::NIIAMMJDGBF<LAIHPLCBCID>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x372AA70", Offset = "0x3729670", VA = "0x18372AA70")]
	protected PJJAFJGOIGO(global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HGEKHAPOBPC, global::BJBLHBACJBM<FAIOLPEPKDJ, global::NIIAMMJDGBF<LAIHPLCBCID>, TRpcParam, TRpcReceiver, global::FBPBJCKOLAK<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OAKKJJDHHIC, global::MIIEDBEEEIH<TAction, TActionReceiver, TActionDeps, global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> GLMDDALCNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3729F00", Offset = "0x3728B00", VA = "0x183729F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3729F60", Offset = "0x3728B60", VA = "0x183729F60")]
	public static global::PJJAFJGOIGO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EEJCKKCGPGE(global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HGEKHAPOBPC, global::BJBLHBACJBM<FAIOLPEPKDJ, global::NIIAMMJDGBF<LAIHPLCBCID>, TRpcParam, TRpcReceiver, global::FBPBJCKOLAK<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OAKKJJDHHIC, global::MIIEDBEEEIH<TAction, TActionReceiver, TActionDeps, global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> GLMDDALCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3616F90", Offset = "0x3615B90", VA = "0x183616F90")]
	public global::NIIAMMJDGBF<LFIMOPGKNHA> MOHGFODLLFP()
	{
		return default(global::NIIAMMJDGBF<LFIMOPGKNHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x372A130", Offset = "0x3728D30", VA = "0x18372A130")]
	internal global::NIIAMMJDGBF<LFIMOPGKNHA> HLOOLLGCLKB(in global::NIIAMMJDGBF<IBIEDNIACAG> CPMOGHLIOBH, in FAIOLPEPKDJ KLDDDNGBABC)
	{
		return default(global::NIIAMMJDGBF<LFIMOPGKNHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x372A290", Offset = "0x3728E90", VA = "0x18372A290")]
	internal void HNFIGLNCIEN(in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x372A500", Offset = "0x3729100", VA = "0x18372A500")]
	internal void MLENCKMGBIL(in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x372A1D0", Offset = "0x3728DD0", VA = "0x18372A1D0")]
	internal void HMHBOKJMGJG(in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3729D70", Offset = "0x3728970", VA = "0x183729D70")]
	internal void AEIJAJIMNEI(in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x372A980", Offset = "0x3729580", VA = "0x18372A980")]
	internal void PLOCIALGBGH(in global::NIIAMMJDGBF<MIHFMOMICGO> BFKMIBIIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x372A410", Offset = "0x3729010", VA = "0x18372A410")]
	public global::NIIAMMJDGBF<LFIMOPGKNHA> KFBFHCNLBKO(in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC)
	{
		return default(global::NIIAMMJDGBF<LFIMOPGKNHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x372A560", Offset = "0x3729160", VA = "0x18372A560")]
	public void NIKMGGDENNN(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3729ED0", Offset = "0x3728AD0", VA = "0x183729ED0")]
	public void DBDBACEOEMF(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x372A5C0", Offset = "0x37291C0", VA = "0x18372A5C0")]
	public void OAAKMAFLJFB(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x372A4D0", Offset = "0x37290D0", VA = "0x18372A4D0")]
	public void MGPALIEGCLG(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3729E10", Offset = "0x3728A10", VA = "0x183729E10")]
	public void AJOBLHAFICK(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcReceiver MOPKGOJHCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x372A0A0", Offset = "0x3728CA0", VA = "0x18372A0A0")]
	public global::NIIAMMJDGBF<LAIHPLCBCID> GOJNGFIJPKH(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC)
	{
		return default(global::NIIAMMJDGBF<LAIHPLCBCID>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3729EA0", Offset = "0x3728AA0", VA = "0x183729EA0")]
	public bool CHJPDFOADBJ(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in global::NIIAMMJDGBF<LAIHPLCBCID> JEKHMAKJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3729E70", Offset = "0x3728A70", VA = "0x183729E70")]
	public global::NIIAMMJDGBF<MIHFMOMICGO> CECBEPLJCEG(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BMMKEAHNPAG)
	{
		return default(global::NIIAMMJDGBF<MIHFMOMICGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x372A0D0", Offset = "0x3728CD0", VA = "0x18372A0D0")]
	public void GOODKPJFIHL(in global::NIIAMMJDGBF<MIHFMOMICGO> CINGIEKIPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x372A070", Offset = "0x3728C70", VA = "0x18372A070")]
	public void GKAHHMDKIIO(in global::NIIAMMJDGBF<MIHFMOMICGO> CINGIEKIPNK, in TSyncFieldValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x372A780", Offset = "0x3729380", VA = "0x18372A780")]
	public Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>> PJOHLCJAPOM(in TAction LKFICPAOGAF, bool PKEKOJOLKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x372A470", Offset = "0x3729070", VA = "0x18372A470")]
	public void KMMEILOANOG(in TActionReceiver PFKFCIMCCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x372A5F0", Offset = "0x37291F0", VA = "0x18372A5F0")]
	public void OEGJEPEDMHG(in global::NIIAMMJDGBF<LAIHPLCBCID> GKPALPCHPGC, in global::NIIAMMJDGBF<ILPDIEMIAFN> LOPJAFGHKAB, in TAction LKFICPAOGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x372A040", Offset = "0x3728C40", VA = "0x18372A040", Slot = "6")]
	private void EKPOKHMLNKL(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x372A350", Offset = "0x3728F50", VA = "0x18372A350", Slot = "7")]
	private void IDHOFKDLGPL(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x372A320", Offset = "0x3728F20", VA = "0x18372A320", Slot = "8")]
	private void IBAOBGFLHLK(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3729F30", Offset = "0x3728B30", VA = "0x183729F30", Slot = "9")]
	private void ECHFJAPECEE(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x372A380", Offset = "0x3728F80", VA = "0x18372A380", Slot = "10")]
	private void JANHJMNHKBN(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcReceiver MOPKGOJHCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x372A100", Offset = "0x3728D00", VA = "0x18372A100", Slot = "11")]
	private global::NIIAMMJDGBF<LAIHPLCBCID> HGNNDCNHPEH(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC)
	{
		return default(global::NIIAMMJDGBF<LAIHPLCBCID>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x372AA40", Offset = "0x3729640", VA = "0x18372AA40", Slot = "12")]
	private bool PPKMHKIDGFK(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in global::NIIAMMJDGBF<LAIHPLCBCID> JEKHMAKJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3729E40", Offset = "0x3728A40", VA = "0x183729E40", Slot = "13")]
	private global::NIIAMMJDGBF<MIHFMOMICGO> AONPNLLNMKI(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BMMKEAHNPAG)
	{
		return default(global::NIIAMMJDGBF<MIHFMOMICGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x372A3E0", Offset = "0x3728FE0", VA = "0x18372A3E0", Slot = "14")]
	private void JFLFBOFMLOC(in global::NIIAMMJDGBF<MIHFMOMICGO> CINGIEKIPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x372A590", Offset = "0x3729190", VA = "0x18372A590", Slot = "15")]
	private void NOJOLIAJLJH(in global::NIIAMMJDGBF<MIHFMOMICGO> CINGIEKIPNK, in TSyncFieldValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x372A3B0", Offset = "0x3728FB0", VA = "0x18372A3B0", Slot = "16")]
	private Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>> JCJHMHCNCPA(in TAction LKFICPAOGAF, bool PKEKOJOLKLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::PBLDFABDFKL<FAIOLPEPKDJ, global::NIIAMMJDGBF<LAIHPLCBCID>, TRpcParam, global::FBPBJCKOLAK<TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::CAOCKBGGEFF<TAction> where TRpcReceiver : global::CHCHKNIIJNE<TRpcParam> where TActionReceiver : global::AHGIFHHEOPA<TAction, Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>>> where TActionDeps : global::CJFJIFDKMJF<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::FMHNPELBNMN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MDNCKBKOPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::NIIAMMJDGBF<LAIHPLCBCID> PPMIPLJCMJC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::NIIAMMJDGBF<LAIHPLCBCID> KNPOIGBLIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x552070", VA = "0x180553470", Slot = "4")]
		get
		{
			return default(global::NIIAMMJDGBF<LAIHPLCBCID>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::NIIAMMJDGBF<LAIHPLCBCID> NMECKOLAGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x552070", VA = "0x180553470", Slot = "14")]
		get
		{
			return default(global::NIIAMMJDGBF<LAIHPLCBCID>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xEEBC30", Offset = "0xEEA830", VA = "0x180EEBC30")]
	private JIEOIFPJDDF(global::FMHNPELBNMN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GHMBHPIEBNH, in global::NIIAMMJDGBF<LAIHPLCBCID> CPMOGHLIOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xEEB7A0", Offset = "0xEEA3A0", VA = "0x180EEB7A0")]
	public static global::JIEOIFPJDDF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EEJCKKCGPGE(in global::NIIAMMJDGBF<LAIHPLCBCID> CPMOGHLIOBH, global::FMHNPELBNMN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GHMBHPIEBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xEEBA10", Offset = "0xEEA610", VA = "0x180EEBA10")]
	public global::NIIAMMJDGBF<LFIMOPGKNHA> MOHGFODLLFP()
	{
		return default(global::NIIAMMJDGBF<LFIMOPGKNHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xEEBA80", Offset = "0xEEA680", VA = "0x180EEBA80")]
	public void NIKMGGDENNN(in FAIOLPEPKDJ KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xEEB6E0", Offset = "0xEEA2E0", VA = "0x180EEB6E0")]
	public void DBDBACEOEMF(in FAIOLPEPKDJ KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xEEBB30", Offset = "0xEEA730", VA = "0x180EEBB30")]
	public void OAAKMAFLJFB(in FAIOLPEPKDJ KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xEEB990", Offset = "0xEEA590", VA = "0x180EEB990")]
	public void MGPALIEGCLG(in FAIOLPEPKDJ KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xEEB8A0", Offset = "0xEEA4A0", VA = "0x180EEB8A0")]
	public global::NIIAMMJDGBF<LAIHPLCBCID> GOJNGFIJPKH(in FAIOLPEPKDJ KLDDDNGBABC)
	{
		return default(global::NIIAMMJDGBF<LAIHPLCBCID>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xEEB5A0", Offset = "0xEEA1A0", VA = "0x180EEB5A0")]
	public bool CHJPDFOADBJ(in FAIOLPEPKDJ KLDDDNGBABC, in global::NIIAMMJDGBF<LAIHPLCBCID> JEKHMAKJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xEEB4C0", Offset = "0xEEA0C0", VA = "0x180EEB4C0")]
	public global::FBPBJCKOLAK<TSyncFieldValue> CECBEPLJCEG(in global::NIIAMMJDGBF<MIHFMOMICGO> BFKMIBIIBHJ, in FAIOLPEPKDJ DMDOCLACLCB, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BMMKEAHNPAG)
	{
		return default(global::FBPBJCKOLAK<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xEEB8D0", Offset = "0xEEA4D0", VA = "0x180EEB8D0")]
	public void GOODKPJFIHL(in global::FBPBJCKOLAK<TSyncFieldValue> BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xEEB640", Offset = "0xEEA240", VA = "0x180EEB640")]
	public void CIAMDOPBPOH(in global::FBPBJCKOLAK<TSyncFieldValue> CINGIEKIPNK, in TSyncFieldValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xEEBA50", Offset = "0xEEA650", VA = "0x180EEBA50", Slot = "15")]
	public void MPFLKAIKADB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xEEBBF0", Offset = "0xEEA7F0", VA = "0x180EEBBF0")]
	public void PJOHLCJAPOM(in global::NIIAMMJDGBF<ILPDIEMIAFN> LOPJAFGHKAB, in TAction LKFICPAOGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xEEB870", Offset = "0xEEA470", VA = "0x180EEB870", Slot = "5")]
	private void EMHGKJLMGPO(in FAIOLPEPKDJ KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xEEB460", Offset = "0xEEA060", VA = "0x180EEB460", Slot = "6")]
	private void BEPLFECJEEJ(in FAIOLPEPKDJ KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xEEB490", Offset = "0xEEA090", VA = "0x180EEB490", Slot = "7")]
	private void BIDKCHCAKBH(in FAIOLPEPKDJ KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xEEB930", Offset = "0xEEA530", VA = "0x180EEB930", Slot = "8")]
	private void IDGKLNBMOAC(in FAIOLPEPKDJ KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xEEB770", Offset = "0xEEA370", VA = "0x180EEB770", Slot = "9")]
	private global::NIIAMMJDGBF<LAIHPLCBCID> DIHOMBAEDBL(in FAIOLPEPKDJ KLDDDNGBABC)
	{
		return default(global::NIIAMMJDGBF<LAIHPLCBCID>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xEEB960", Offset = "0xEEA560", VA = "0x180EEB960", Slot = "10")]
	private bool LHFMHKCJJIA(in FAIOLPEPKDJ KLDDDNGBABC, in global::NIIAMMJDGBF<LAIHPLCBCID> JEKHMAKJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xEEBAC0", Offset = "0xEEA6C0", VA = "0x180EEBAC0", Slot = "11")]
	private global::FBPBJCKOLAK<TSyncFieldValue> NMBCAHHKCDF(in global::NIIAMMJDGBF<MIHFMOMICGO> CGOFEAKINMF, in FAIOLPEPKDJ KLDDDNGBABC, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BMMKEAHNPAG)
	{
		return default(global::FBPBJCKOLAK<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xEEBBC0", Offset = "0xEEA7C0", VA = "0x180EEBBC0", Slot = "12")]
	private void ONEHEBJLFGO(in global::FBPBJCKOLAK<TSyncFieldValue> BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xEEB6B0", Offset = "0xEEA2B0", VA = "0x180EEB6B0", Slot = "13")]
	private void CJGFCIIOKKN(in global::FBPBJCKOLAK<TSyncFieldValue> CINGIEKIPNK, in TSyncFieldValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xEE57F0", Offset = "0xEE43F0", VA = "0x180EE57F0", Slot = "16")]
	private void NGLKPBDJFDP(in global::NIIAMMJDGBF<ILPDIEMIAFN> LOPJAFGHKAB, in TAction LKFICPAOGAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FMHNPELBNMN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::CHCHKNIIJNE<TRpcParam> where TActionReceiver : global::AHGIFHHEOPA<TAction, Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>>> where TActionDeps : global::CJFJIFDKMJF<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::NIIAMMJDGBF<LAIHPLCBCID> KKMHPLIKBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly global::KLHNENCECOM<IBIEDNIACAG, EMDCIJNKKCG> PDOILGKOOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<string, global::CEFMHGFPMOE<TSyncFieldValue>> LFHNJMAMCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly global::OCNOIIKJNOL<LAIHPLCBCID, global::PJJAFJGOIGO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> EPMJFPLLACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly TActionDeps EKHOPPEIJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly List<(global::NIIAMMJDGBF<LAIHPLCBCID> ActorId, global::NIIAMMJDGBF<ILPDIEMIAFN> RequestId, TAction Action)> PFEMKHOFBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? HMOLJDLBPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly int? OINCEEICLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Queue<(global::NIIAMMJDGBF<LAIHPLCBCID> ActorId, global::NIIAMMJDGBF<ILPDIEMIAFN> RequestId, TAction Action)> PEGFBKFIFCC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::NIIAMMJDGBF<LAIHPLCBCID> PKHIOCDMDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DC10", VA = "0x18054F010")]
		get
		{
			return default(global::NIIAMMJDGBF<LAIHPLCBCID>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x129E210", Offset = "0x129CE10", VA = "0x18129E210")]
	protected FMHNPELBNMN(TActionDeps DIFHAMJOHML, int? LPCCCAFCMOC, int? JOOJICHPOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x129C7B0", Offset = "0x129B3B0", VA = "0x18129C7B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x129CD00", Offset = "0x129B900", VA = "0x18129CD00")]
	public global::PJJAFJGOIGO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KNBEONCFJDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x129D420", Offset = "0x129C020", VA = "0x18129D420")]
	internal global::NIIAMMJDGBF<LFIMOPGKNHA> MOHGFODLLFP(in global::NIIAMMJDGBF<LAIHPLCBCID> ELAGMMAPPCH)
	{
		return default(global::NIIAMMJDGBF<LFIMOPGKNHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x129CAC0", Offset = "0x129B6C0", VA = "0x18129CAC0")]
	internal void IAGJHGKMIGP(in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x129CA60", Offset = "0x129B660", VA = "0x18129CA60")]
	internal global::NIIAMMJDGBF<LAIHPLCBCID> GOJNGFIJPKH(in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC)
	{
		return default(global::NIIAMMJDGBF<LAIHPLCBCID>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x129CC70", Offset = "0x129B870", VA = "0x18129CC70")]
	internal void JHJKHMEIDEC(in global::NIIAMMJDGBF<LAIHPLCBCID> KCPPAEKGKDA, in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x129C660", Offset = "0x129B260", VA = "0x18129C660")]
	internal void CGOPGNGPGOF(in global::NIIAMMJDGBF<LAIHPLCBCID> LPAKANAMKLG, in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x129D7E0", Offset = "0x129C3E0", VA = "0x18129D7E0")]
	internal void PIEIEMJCMPB(in global::NIIAMMJDGBF<LAIHPLCBCID> KCPPAEKGKDA, in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x129D190", Offset = "0x129BD90", VA = "0x18129D190")]
	internal global::FBPBJCKOLAK<TSyncFieldValue> LBIKGBBNOPG(global::NIIAMMJDGBF<LAIHPLCBCID> NNCDNGJCJEH, global::NIIAMMJDGBF<MIHFMOMICGO> BFKMIBIIBHJ, string GMCMHIFODNN, in TSyncFieldValue JHEBJPCMJGD, Action OMCIJDNLADG, Action<object> MMMPBEKANAE, Func<bool> GNIKCDOOECI)
	{
		return default(global::FBPBJCKOLAK<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x129D330", Offset = "0x129BF30", VA = "0x18129D330")]
	internal void MAFCMMAGCPE(global::NIIAMMJDGBF<LAIHPLCBCID> NNCDNGJCJEH, string GMCMHIFODNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x129DFC0", Offset = "0x129CBC0", VA = "0x18129DFC0")]
	internal void PLOCIALGBGH(global::CEFMHGFPMOE<TSyncFieldValue> BFKMIBIIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x129D7B0", Offset = "0x129C3B0", VA = "0x18129D7B0")]
	internal void MPFLKAIKADB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x129DA70", Offset = "0x129C670", VA = "0x18129DA70")]
	internal void PJOHLCJAPOM(in global::NIIAMMJDGBF<LAIHPLCBCID> GKPALPCHPGC, in global::NIIAMMJDGBF<ILPDIEMIAFN> LOPJAFGHKAB, in TAction LKFICPAOGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x129C6E0", Offset = "0x129B2E0", VA = "0x18129C6E0")]
	[CompilerGenerated]
	private global::PJJAFJGOIGO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DDKMOPKJCEJ(in global::NIIAMMJDGBF<LAIHPLCBCID> JGMCDBECEII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FAIOLPEPKDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly global::NIIAMMJDGBF<IBIEDNIACAG> IBJFKDDIMDG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x17EE960", Offset = "0x17ED560", VA = "0x1817EE960")]
	private FAIOLPEPKDJ(in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60B9D0", Offset = "0x60A5D0", VA = "0x18060B9D0")]
	public static FAIOLPEPKDJ EEJCKKCGPGE(in global::NIIAMMJDGBF<IBIEDNIACAG> KLDDDNGBABC)
	{
		return default(FAIOLPEPKDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EMDCIJNKKCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public global::NIIAMMJDGBF<LAIHPLCBCID> HHAMPAMAHCM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x17EE960", Offset = "0x17ED560", VA = "0x1817EE960")]
	private EMDCIJNKKCG(in global::NIIAMMJDGBF<LAIHPLCBCID> ELAGMMAPPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60B9D0", Offset = "0x60A5D0", VA = "0x18060B9D0")]
	public static EMDCIJNKKCG EEJCKKCGPGE(in global::NIIAMMJDGBF<LAIHPLCBCID> ELAGMMAPPCH)
	{
		return default(EMDCIJNKKCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FBPBJCKOLAK<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly NOALDPMAPLB ECAGEFBJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly global::CEFMHGFPMOE<TSyncFieldValue> FBOHFGAKIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Action FOHPBLOGPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Action<object> LNGHHCDNEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Func<bool> FIMBDNALECM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x12CC680", Offset = "0x12CB280", VA = "0x1812CC680")]
	private FBPBJCKOLAK(NOALDPMAPLB CFICOGLGHEE, global::CEFMHGFPMOE<TSyncFieldValue> CDJCABBAKPB, Action OMCIJDNLADG, Action<object> MMMPBEKANAE, Func<bool> GNIKCDOOECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x12CC520", Offset = "0x12CB120", VA = "0x1812CC520")]
	public static global::FBPBJCKOLAK<TSyncFieldValue> EEJCKKCGPGE(global::CEFMHGFPMOE<TSyncFieldValue> CDJCABBAKPB, Action OMCIJDNLADG, Action<object> MMMPBEKANAE, Func<bool> GNIKCDOOECI)
	{
		return default(global::FBPBJCKOLAK<TSyncFieldValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class CEFMHGFPMOE<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly string CGBHHKNJCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TSyncFieldValue EFFCIDNMALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly Dictionary<global::NIIAMMJDGBF<LAIHPLCBCID>, global::NIIAMMJDGBF<MIHFMOMICGO>> DMCMGFDHIBF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3B43560", Offset = "0x3B42160", VA = "0x183B43560")]
	private CEFMHGFPMOE(string GMCMHIFODNN, in TSyncFieldValue JHEBJPCMJGD, Dictionary<global::NIIAMMJDGBF<LAIHPLCBCID>, global::NIIAMMJDGBF<MIHFMOMICGO>> DOCNABPMMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B43440", Offset = "0x3B42040", VA = "0x183B43440")]
	public static global::CEFMHGFPMOE<TSyncFieldValue> EEJCKKCGPGE(string GMCMHIFODNN, in TSyncFieldValue JHEBJPCMJGD)
	{
		return null;
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
