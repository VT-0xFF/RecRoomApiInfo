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
public sealed class PFOHFACMAOO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::ANEOOMECFNA<TRpcParam> where TActionReceiver : global::JLDHDAPDKIO<TAction, Task<global::NCCJCEGIOLD<object, PEOIGJADBLL>>> where TActionDeps : global::KFKKAONGEGD<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class NKMGEGBCEFK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public NKMGEGBCEFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::NCCJCEGIOLD<object, PEOIGJADBLL>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::NCCJCEGIOLD<object, PEOIGJADBLL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2F9C960", Offset = "0x2F9B760", VA = "0x182F9C960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::PFOHFACMAOO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::NCCJCEGIOLD<object, PEOIGJADBLL>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public NKMGEGBCEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x395DF60", Offset = "0x395CD60", VA = "0x18395DF60")]
		[AsyncStateMachine(typeof(global::PFOHFACMAOO<, , , , , >.NKMGEGBCEFK.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PDHCOEFNNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::FGACGKAHALI<HNOFIDEAKCO>, global::FGACGKAHALI<ELFLOMEHAPG>> AMIKKBOLKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::FGACGKAHALI<HNOFIDEAKCO>> HFDLIFAGPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::FLKGDOLJLDJ<int> PIGCGJEAJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::FGACGKAHALI<AGLHAAEPCAC> ActorId, global::FGACGKAHALI<NEBBOHMCCLE> RequestId, TAction Action)> ENANKOFEJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool FODKOIMLPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> BIELHHIIOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::AJBLCDNLONH<NFDNAIJBAGP, global::FGACGKAHALI<AGLHAAEPCAC>, TRpcParam, TRpcReceiver, global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> IJGJPPJPFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::LOALLONCDKK<TAction, TActionReceiver, TActionDeps, global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BBCFPEEDJON;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool NJDCEOLLPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0DE0", Offset = "0x3FBFBE0", VA = "0x183FC0DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::FGACGKAHALI<AGLHAAEPCAC> HBKKADHCODF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x327C100", Offset = "0x327AF00", VA = "0x18327C100")]
		get
		{
			return default(global::FGACGKAHALI<AGLHAAEPCAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1250", Offset = "0x3FC0050", VA = "0x183FC1250")]
	private PFOHFACMAOO(global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OKLHHFIFADA, global::AJBLCDNLONH<NFDNAIJBAGP, global::FGACGKAHALI<AGLHAAEPCAC>, TRpcParam, TRpcReceiver, global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OEALBACGMLI, global::LOALLONCDKK<TAction, TActionReceiver, TActionDeps, global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> LDJJNPMLOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3284880", Offset = "0x3283680", VA = "0x183284880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1170", Offset = "0x3FBFF70", VA = "0x183FC1170")]
	internal static global::PFOHFACMAOO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PKGIDMHJGMJ(global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OKLHHFIFADA, global::AJBLCDNLONH<NFDNAIJBAGP, global::FGACGKAHALI<AGLHAAEPCAC>, TRpcParam, TRpcReceiver, global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OEALBACGMLI, global::LOALLONCDKK<TAction, TActionReceiver, TActionDeps, global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> LDJJNPMLOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37160F0", Offset = "0x3714EF0", VA = "0x1837160F0")]
	public global::FGACGKAHALI<ELFLOMEHAPG> CBHBOMIKKGP()
	{
		return default(global::FGACGKAHALI<ELFLOMEHAPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A40", Offset = "0x3FBF840", VA = "0x183FC0A40")]
	internal global::FGACGKAHALI<ELFLOMEHAPG> DFNAMAFIAAD(global::FGACGKAHALI<HNOFIDEAKCO> FCIFBDBBENJ, in NFDNAIJBAGP LOPIEGGIDMF)
	{
		return default(global::FGACGKAHALI<ELFLOMEHAPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0D60", Offset = "0x3FBFB60", VA = "0x183FC0D60")]
	internal void GOEDCMFPHKF(global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0D00", Offset = "0x3FBFB00", VA = "0x183FC0D00")]
	internal void GGOKDFGFNBD(global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0F80", Offset = "0x3FBFD80", VA = "0x183FC0F80")]
	internal void JKCABDEHAKB(global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1010", Offset = "0x3FBFE10", VA = "0x183FC1010")]
	internal void MCLIIKCKING(global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0E80", Offset = "0x3FBFC80", VA = "0x183FC0E80")]
	internal void IMLJAMDGHDP(global::FGACGKAHALI<DJKAHBIKDBL> MLGIEMDGEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1110", Offset = "0x3FBFF10", VA = "0x183FC1110")]
	public global::FGACGKAHALI<ELFLOMEHAPG> PAIOMIDKIFK(global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF)
	{
		return default(global::FGACGKAHALI<ELFLOMEHAPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FC10E0", Offset = "0x3FBFEE0", VA = "0x183FC10E0")]
	public void OECFLKHKNII(global::FGACGKAHALI<ELFLOMEHAPG> LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0E50", Offset = "0x3FBFC50", VA = "0x183FC0E50")]
	public void HMGBLKCFHBO(global::FGACGKAHALI<ELFLOMEHAPG> LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0AE0", Offset = "0x3FBF8E0", VA = "0x183FC0AE0")]
	public void DJPNPDGELEK(global::FGACGKAHALI<ELFLOMEHAPG> LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0A10", Offset = "0x3FBF810", VA = "0x183FC0A10")]
	public void CPAEBGANBPA(global::FGACGKAHALI<ELFLOMEHAPG> LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0FE0", Offset = "0x3FBFDE0", VA = "0x183FC0FE0")]
	public void KNJKGLIDBNH(global::FGACGKAHALI<ELFLOMEHAPG> LOPIEGGIDMF, in TRpcReceiver NIHFHAMIECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FC09E0", Offset = "0x3FBF7E0", VA = "0x183FC09E0")]
	public global::FGACGKAHALI<AGLHAAEPCAC> COEICGCINNF(global::FGACGKAHALI<ELFLOMEHAPG> LOPIEGGIDMF)
	{
		return default(global::FGACGKAHALI<AGLHAAEPCAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0F40", Offset = "0x3FBFD40", VA = "0x183FC0F40")]
	public bool JFCMDFEJHAE(global::FGACGKAHALI<ELFLOMEHAPG> LOPIEGGIDMF, global::FGACGKAHALI<AGLHAAEPCAC> OLKBPPLJAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0B10", Offset = "0x3FBF910", VA = "0x183FC0B10")]
	public global::FGACGKAHALI<DJKAHBIKDBL> DNLEKBIHJMI(global::FGACGKAHALI<ELFLOMEHAPG> LOPIEGGIDMF, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) HNDKIKCHCLJ)
	{
		return default(global::FGACGKAHALI<DJKAHBIKDBL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0B40", Offset = "0x3FBF940", VA = "0x183FC0B40")]
	public void DOKFFJMKPBP(global::FGACGKAHALI<DJKAHBIKDBL> JBBPDEDDJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FC07E0", Offset = "0x3FBF5E0", VA = "0x183FC07E0")]
	public void BFHHNHDFEIC(global::FGACGKAHALI<DJKAHBIKDBL> JBBPDEDDJDA, in TSyncFieldValue DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0810", Offset = "0x3FBF610", VA = "0x183FC0810")]
	public Task<global::NCCJCEGIOLD<object, PEOIGJADBLL>> BHJMCJLADFA(in TAction CIAILAMJPDB, bool LHKDMIGNNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3FC10B0", Offset = "0x3FBFEB0", VA = "0x183FC10B0")]
	public void NPOPHIGEGAC(in TActionReceiver HNFGNPPLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0B70", Offset = "0x3FBF970", VA = "0x183FC0B70")]
	public void FJEHDMONNKF(global::FGACGKAHALI<AGLHAAEPCAC> BKKGIODOEGK, global::FGACGKAHALI<NEBBOHMCCLE> HPIKIBFKIMD, in TAction CIAILAMJPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::JHNNMMJHKLK<NFDNAIJBAGP, global::FGACGKAHALI<AGLHAAEPCAC>, TRpcParam, global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::GNOOIKFIBHK<TAction> where TRpcReceiver : global::ANEOOMECFNA<TRpcParam> where TActionReceiver : global::JLDHDAPDKIO<TAction, Task<global::NCCJCEGIOLD<object, PEOIGJADBLL>>> where TActionDeps : global::KFKKAONGEGD<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::KKIBCKLBAFD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> AADBHEIBEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::FGACGKAHALI<AGLHAAEPCAC> DPNMHJPGFNA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::FGACGKAHALI<AGLHAAEPCAC> HBKKADHCODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30", Slot = "4")]
		get
		{
			return default(global::FGACGKAHALI<AGLHAAEPCAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::FGACGKAHALI<AGLHAAEPCAC> OIPHLGDFNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x770E30", Offset = "0x76FC30", VA = "0x180770E30", Slot = "14")]
		get
		{
			return default(global::FGACGKAHALI<AGLHAAEPCAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CHLODFKOMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6CE7A0", Offset = "0x6CD5A0", VA = "0x1806CE7A0", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x40B3CD0", Offset = "0x40B2AD0", VA = "0x1840B3CD0")]
	private AFLEOALOEIB(global::KKIBCKLBAFD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PJBPHNEKLHE, global::FGACGKAHALI<AGLHAAEPCAC> FCIFBDBBENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x40B3C00", Offset = "0x40B2A00", VA = "0x1840B3C00")]
	public static global::AFLEOALOEIB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PKGIDMHJGMJ(global::FGACGKAHALI<AGLHAAEPCAC> FCIFBDBBENJ, global::KKIBCKLBAFD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PJBPHNEKLHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x40B3600", Offset = "0x40B2400", VA = "0x1840B3600")]
	public global::FGACGKAHALI<ELFLOMEHAPG> CBHBOMIKKGP()
	{
		return default(global::FGACGKAHALI<ELFLOMEHAPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x40B3BC0", Offset = "0x40B29C0", VA = "0x1840B3BC0")]
	public void OECFLKHKNII(in NFDNAIJBAGP LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x40B39B0", Offset = "0x40B27B0", VA = "0x1840B39B0")]
	public void HMGBLKCFHBO(in NFDNAIJBAGP LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x40B3730", Offset = "0x40B2530", VA = "0x1840B3730")]
	public void DJPNPDGELEK(in NFDNAIJBAGP LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x40B3680", Offset = "0x40B2480", VA = "0x1840B3680")]
	public void CPAEBGANBPA(in NFDNAIJBAGP LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40B3640", Offset = "0x40B2440", VA = "0x1840B3640")]
	public global::FGACGKAHALI<AGLHAAEPCAC> COEICGCINNF(in NFDNAIJBAGP LOPIEGGIDMF)
	{
		return default(global::FGACGKAHALI<AGLHAAEPCAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40B3A30", Offset = "0x40B2830", VA = "0x1840B3A30")]
	public bool JFCMDFEJHAE(in NFDNAIJBAGP LOPIEGGIDMF, global::FGACGKAHALI<AGLHAAEPCAC> OLKBPPLJAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40B37B0", Offset = "0x40B25B0", VA = "0x1840B37B0")]
	public global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue> DNLEKBIHJMI(global::FGACGKAHALI<DJKAHBIKDBL> MLGIEMDGEBP, in NFDNAIJBAGP KNNMPBLOADI, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) HNDKIKCHCLJ)
	{
		return default(global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x40B3880", Offset = "0x40B2680", VA = "0x1840B3880")]
	public void DOKFFJMKPBP(in global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue> HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40B3AF0", Offset = "0x40B28F0", VA = "0x1840B3AF0")]
	public void MCMPNOGIJOE(in global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue> JBBPDEDDJDA, in TSyncFieldValue DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x39ED920", Offset = "0x39EC720", VA = "0x1839ED920", Slot = "15")]
	public void JMIPGHKGGEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x40B3580", Offset = "0x40B2380", VA = "0x1840B3580", Slot = "16")]
	public void BHJMCJLADFA(global::FGACGKAHALI<NEBBOHMCCLE> HPIKIBFKIMD, TAction CIAILAMJPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x40B35D0", Offset = "0x40B23D0", VA = "0x1840B35D0", Slot = "5")]
	private void BHKIKDGAALC(in NFDNAIJBAGP LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40B3B90", Offset = "0x40B2990", VA = "0x1840B3B90", Slot = "6")]
	private void NOEEMAPOJHC(in NFDNAIJBAGP LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x40B3B60", Offset = "0x40B2960", VA = "0x1840B3B60", Slot = "7")]
	private void MGBEGDKCFFL(in NFDNAIJBAGP LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x40B3980", Offset = "0x40B2780", VA = "0x1840B3980", Slot = "8")]
	private void HDPPFNOGOKK(in NFDNAIJBAGP LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x40B38E0", Offset = "0x40B26E0", VA = "0x1840B38E0", Slot = "9")]
	private global::FGACGKAHALI<AGLHAAEPCAC> EEEKGNJMBIH(in NFDNAIJBAGP LOPIEGGIDMF)
	{
		return default(global::FGACGKAHALI<AGLHAAEPCAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x40B3AC0", Offset = "0x40B28C0", VA = "0x1840B3AC0", Slot = "10")]
	private bool LHHLKABFLNB(in NFDNAIJBAGP LOPIEGGIDMF, global::FGACGKAHALI<AGLHAAEPCAC> OLKBPPLJAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x40B3910", Offset = "0x40B2710", VA = "0x1840B3910", Slot = "11")]
	private global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue> FGLCBACPKON(global::FGACGKAHALI<DJKAHBIKDBL> FCIFBDBBENJ, in NFDNAIJBAGP LOPIEGGIDMF, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) HNDKIKCHCLJ)
	{
		return default(global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x40AAC80", Offset = "0x40A9A80", VA = "0x1840AAC80", Slot = "12")]
	private void NCFHDHPJOLG(in global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue> HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x40B3700", Offset = "0x40B2500", VA = "0x1840B3700", Slot = "13")]
	private void DAKEGDNKPGG(in global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue> JBBPDEDDJDA, in TSyncFieldValue DPJGMDFEIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KKIBCKLBAFD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::ANEOOMECFNA<TRpcParam> where TActionReceiver : global::JLDHDAPDKIO<TAction, Task<global::NCCJCEGIOLD<object, PEOIGJADBLL>>> where TActionDeps : global::KFKKAONGEGD<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::FGACGKAHALI<AGLHAAEPCAC> GJPEKCLGCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::OHOPBFBDHLP<HNOFIDEAKCO, global::HDHKDEGACPF<AGLHAAEPCAC>> NPDECIFPMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::JDCLALKINJD<AGLHAAEPCAC, TSyncFieldValue>> AGCKOOPLBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::JHCBHLDFHPI<AGLHAAEPCAC, global::PFOHFACMAOO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> POOLJHLBGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps JJKEEMBEGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::FGACGKAHALI<AGLHAAEPCAC> ActorId, global::FGACGKAHALI<NEBBOHMCCLE> RequestId, TAction Action)> LIOOMEHNDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? GDNKOEEFLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? AHPGDAFFFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::FGACGKAHALI<AGLHAAEPCAC> ActorId, global::FGACGKAHALI<NEBBOHMCCLE> RequestId, TAction Action)> MFHPGAONLMA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal global::FGACGKAHALI<AGLHAAEPCAC> AKBCLOCHKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380")]
		get
		{
			return default(global::FGACGKAHALI<AGLHAAEPCAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4372620", Offset = "0x4371420", VA = "0x184372620")]
	protected KKIBCKLBAFD(TActionDeps FNAGNMEPBDH, int? PCJJBLKMCIG, int? DADCENNNJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4370890", Offset = "0x436F690", VA = "0x184370890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4371970", Offset = "0x4370770", VA = "0x184371970")]
	public global::PFOHFACMAOO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MGLKPGDOEJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x43702F0", Offset = "0x436F0F0", VA = "0x1843702F0")]
	internal global::FGACGKAHALI<ELFLOMEHAPG> CBHBOMIKKGP(global::FGACGKAHALI<AGLHAAEPCAC> BFEBCIKFBNJ)
	{
		return default(global::FGACGKAHALI<ELFLOMEHAPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4370640", Offset = "0x436F440", VA = "0x184370640")]
	internal void DJPALPFNMAG(global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x43705F0", Offset = "0x436F3F0", VA = "0x1843705F0")]
	internal global::FGACGKAHALI<AGLHAAEPCAC> COEICGCINNF(global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF)
	{
		return default(global::FGACGKAHALI<AGLHAAEPCAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x43712A0", Offset = "0x43700A0", VA = "0x1843712A0")]
	internal void FFJDBBIHAGO(global::FGACGKAHALI<AGLHAAEPCAC> LJANOOFLEEC, global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4371230", Offset = "0x4370030", VA = "0x184371230")]
	internal void EPBACPJJDFA(global::FGACGKAHALI<AGLHAAEPCAC> JKEAIGMKJOM, global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4371400", Offset = "0x4370200", VA = "0x184371400")]
	internal void HGCPFEHJCIJ(global::FGACGKAHALI<AGLHAAEPCAC> LJANOOFLEEC, global::FGACGKAHALI<HNOFIDEAKCO> LOPIEGGIDMF, in TRpcParam HNDKIKCHCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x436FCC0", Offset = "0x436EAC0", VA = "0x18436FCC0")]
	internal global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue> BANLJMKBDCO(global::FGACGKAHALI<AGLHAAEPCAC> ICPFMCAHNLK, global::FGACGKAHALI<DJKAHBIKDBL> MLGIEMDGEBP, string CKMEBFKEHMO, in TSyncFieldValue DPJGMDFEIDL, Action JAKHBAJPHJL, Action<object> OJMDDKLONNF, Func<bool> DOPOANPBGCK)
	{
		return default(global::HGBLLJFGEFO<AGLHAAEPCAC, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4371880", Offset = "0x4370680", VA = "0x184371880")]
	internal void LOGJEKFAOAP(global::FGACGKAHALI<AGLHAAEPCAC> ICPFMCAHNLK, string CKMEBFKEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4371620", Offset = "0x4370420", VA = "0x184371620")]
	internal void IMLJAMDGHDP(global::JDCLALKINJD<AGLHAAEPCAC, TSyncFieldValue> MLGIEMDGEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4371840", Offset = "0x4370640", VA = "0x184371840")]
	internal void JMIPGHKGGEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x436FE60", Offset = "0x436EC60", VA = "0x18436FE60")]
	internal void BHJMCJLADFA(global::FGACGKAHALI<AGLHAAEPCAC> BKKGIODOEGK, global::FGACGKAHALI<NEBBOHMCCLE> HPIKIBFKIMD, in TAction CIAILAMJPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4371330", Offset = "0x4370130", VA = "0x184371330")]
	[CompilerGenerated]
	private global::PFOHFACMAOO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GBOKKNHLJFG(global::FGACGKAHALI<AGLHAAEPCAC> GMGAMCOBCEH)
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
