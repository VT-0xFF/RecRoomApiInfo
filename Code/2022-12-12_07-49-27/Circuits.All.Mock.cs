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
public sealed class BINIOJKFBJC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::AIFBJHBPEIG<TRpcParam> where TActionReceiver : global::LPEKEIDKFFK<TAction, Task<global::IKEELLNFFOM<object, IHHGNGPIMCG>>> where TActionDeps : global::ENKGGCLDLDO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class BGBNGEMJJLK
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
			public BGBNGEMJJLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::IKEELLNFFOM<object, IHHGNGPIMCG>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::IKEELLNFFOM<object, IHHGNGPIMCG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2DC95E0", Offset = "0x2DC7BE0", VA = "0x182DC95E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::BINIOJKFBJC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::IKEELLNFFOM<object, IHHGNGPIMCG>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public BGBNGEMJJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4BCFEF0", Offset = "0x4BCE4F0", VA = "0x184BCFEF0")]
		[AsyncStateMachine(typeof(global::BINIOJKFBJC<, , , , , >.BGBNGEMJJLK.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CLMOOCMNIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::GFOJEHCBKMK<EEFACAHEJEN>, global::GFOJEHCBKMK<JJOHJGHOLNH>> NGMGDEJCEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::GFOJEHCBKMK<EEFACAHEJEN>> ALODIEEFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::IICAPBLJHHK<int> JHEEFGMFPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::GFOJEHCBKMK<BNHJKKFKABK> ActorId, global::GFOJEHCBKMK<FLFBOMKKKAC> RequestId, TAction Action)> BFAIJIHFJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool GKFEJNHBNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> DEFMFGAPNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::GMIAMPIHODH<AGLNGEBFGFL, global::GFOJEHCBKMK<BNHJKKFKABK>, TRpcParam, TRpcReceiver, global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> AFGDGKOFOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> FILNEPGLEPA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool LGHMABMJCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3FA0E50", Offset = "0x3F9F450", VA = "0x183FA0E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::GFOJEHCBKMK<BNHJKKFKABK> GAMBFDBGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1090", Offset = "0x3F9F690", VA = "0x183FA1090")]
		get
		{
			return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3FA16F0", Offset = "0x3F9FCF0", VA = "0x183FA16F0")]
	private BINIOJKFBJC(global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> LCOMIHDGHCD, global::GMIAMPIHODH<AGLNGEBFGFL, global::GFOJEHCBKMK<BNHJKKFKABK>, TRpcParam, TRpcReceiver, global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> APINOCCLLLE, global::BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JIPDLIANOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0F20", Offset = "0x3F9F520", VA = "0x183FA0F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1480", Offset = "0x3F9FA80", VA = "0x183FA1480")]
	internal static global::BINIOJKFBJC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OJKIKDBCCPC(global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> LCOMIHDGHCD, global::GMIAMPIHODH<AGLNGEBFGFL, global::GFOJEHCBKMK<BNHJKKFKABK>, TRpcParam, TRpcReceiver, global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> APINOCCLLLE, global::BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JIPDLIANOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x341CB70", Offset = "0x341B170", VA = "0x18341CB70")]
	public global::GFOJEHCBKMK<JJOHJGHOLNH> DHFBPNPAJMG()
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3FA10F0", Offset = "0x3F9F6F0", VA = "0x183FA10F0")]
	internal global::GFOJEHCBKMK<JJOHJGHOLNH> HBCIIFKGDEA(global::GFOJEHCBKMK<EEFACAHEJEN> CBBOJGIJLHN, in AGLNGEBFGFL LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0DA0", Offset = "0x3F9F3A0", VA = "0x183FA0DA0")]
	internal void BKOMAIMHCPM(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0D10", Offset = "0x3F9F310", VA = "0x183FA0D10")]
	internal void AIPCCKKGIAH(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1420", Offset = "0x3F9FA20", VA = "0x183FA1420")]
	internal void OBLDEJOPFLF(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0F80", Offset = "0x3F9F580", VA = "0x183FA0F80")]
	internal void ENFJIGBIMBO(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0C20", Offset = "0x3F9F220", VA = "0x183FA0C20")]
	internal void AFDEDOLLDML(global::GFOJEHCBKMK<BEAFNHKLJOO> AMOJNABADGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1190", Offset = "0x3F9F790", VA = "0x183FA1190")]
	public global::GFOJEHCBKMK<JJOHJGHOLNH> JGAJDJBNHCL(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0EC0", Offset = "0x3F9F4C0", VA = "0x183FA0EC0")]
	public void CNIJMCOOONC(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0D70", Offset = "0x3F9F370", VA = "0x183FA0D70")]
	public void AMDOPNGNDGM(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0EF0", Offset = "0x3F9F4F0", VA = "0x183FA0EF0")]
	public void DFEAHKEDLNP(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0F50", Offset = "0x3F9F550", VA = "0x183FA0F50")]
	public void EJIIFOCOCHG(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3FA10C0", Offset = "0x3F9F6C0", VA = "0x183FA10C0")]
	public void HAEAAFAFGID(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcReceiver JLNEPCPFMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0CE0", Offset = "0x3F9F2E0", VA = "0x183FA0CE0")]
	public global::GFOJEHCBKMK<BNHJKKFKABK> AHLJJJICDDF(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1020", Offset = "0x3F9F620", VA = "0x183FA1020")]
	public bool FAMFILCLBIN(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, global::GFOJEHCBKMK<BNHJKKFKABK> PAIIMNGOMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3FA11F0", Offset = "0x3F9F7F0", VA = "0x183FA11F0")]
	public global::GFOJEHCBKMK<BEAFNHKLJOO> KDFAGNALDEL(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) IAHPHHNFGHI)
	{
		return default(global::GFOJEHCBKMK<BEAFNHKLJOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0E20", Offset = "0x3F9F420", VA = "0x183FA0E20")]
	public void CHCFBADACAC(global::GFOJEHCBKMK<BEAFNHKLJOO> PJGOPPMNMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1060", Offset = "0x3F9F660", VA = "0x183FA1060")]
	public void GONFONCILEI(global::GFOJEHCBKMK<BEAFNHKLJOO> PJGOPPMNMAI, in TSyncFieldValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1250", Offset = "0x3F9F850", VA = "0x183FA1250")]
	public Task<global::IKEELLNFFOM<object, IHHGNGPIMCG>> OAJINOHIBOB(in TAction PBOHOIMMGFG, bool EEEGNGIMIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1220", Offset = "0x3F9F820", VA = "0x183FA1220")]
	public void LCPFJNMBJAF(in TActionReceiver LCFDFEFIJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1560", Offset = "0x3F9FB60", VA = "0x183FA1560")]
	public void OLGHBIFFALO(global::GFOJEHCBKMK<BNHJKKFKABK> BDKOHAFBNID, global::GFOJEHCBKMK<FLFBOMKKKAC> CAEOMKLPFEI, in TAction PBOHOIMMGFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal sealed class BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::LKNNDNPAAMM<AGLNGEBFGFL, global::GFOJEHCBKMK<BNHJKKFKABK>, TRpcParam, global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::HDCIICIDGGM<TAction> where TRpcReceiver : global::AIFBJHBPEIG<TRpcParam> where TActionReceiver : global::LPEKEIDKFFK<TAction, Task<global::IKEELLNFFOM<object, IHHGNGPIMCG>>> where TActionDeps : global::ENKGGCLDLDO<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::ADHPELINCNG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HPKICOKBLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::GFOJEHCBKMK<BNHJKKFKABK> NMCPMBGGHDH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::GFOJEHCBKMK<BNHJKKFKABK> GAMBFDBGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600", Slot = "4")]
		get
		{
			return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::GFOJEHCBKMK<BNHJKKFKABK> OEBHMFJBOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600", Slot = "14")]
		get
		{
			return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA75A0", Offset = "0x3FA5BA0", VA = "0x183FA75A0")]
	private BKOEMANJOPF(global::ADHPELINCNG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GONEHAIFHNH, global::GFOJEHCBKMK<BNHJKKFKABK> CBBOJGIJLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3FA74A0", Offset = "0x3FA5AA0", VA = "0x183FA74A0")]
	public static global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OJKIKDBCCPC(global::GFOJEHCBKMK<BNHJKKFKABK> CBBOJGIJLHN, global::ADHPELINCNG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GONEHAIFHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3FA70A0", Offset = "0x3FA56A0", VA = "0x183FA70A0")]
	public global::GFOJEHCBKMK<JJOHJGHOLNH> DHFBPNPAJMG()
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6FB0", Offset = "0x3FA55B0", VA = "0x183FA6FB0")]
	public void CNIJMCOOONC(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6ED0", Offset = "0x3FA54D0", VA = "0x183FA6ED0")]
	public void AMDOPNGNDGM(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7020", Offset = "0x3FA5620", VA = "0x183FA7020")]
	public void DFEAHKEDLNP(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3FA70E0", Offset = "0x3FA56E0", VA = "0x183FA70E0")]
	public void EJIIFOCOCHG(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6E90", Offset = "0x3FA5490", VA = "0x183FA6E90")]
	public global::GFOJEHCBKMK<BNHJKKFKABK> AHLJJJICDDF(in AGLNGEBFGFL LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7160", Offset = "0x3FA5760", VA = "0x183FA7160")]
	public bool FAMFILCLBIN(in AGLNGEBFGFL LGKNNMGLNIA, global::GFOJEHCBKMK<BNHJKKFKABK> PAIIMNGOMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FA72F0", Offset = "0x3FA58F0", VA = "0x183FA72F0")]
	public global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> KDFAGNALDEL(global::GFOJEHCBKMK<BEAFNHKLJOO> AMOJNABADGD, in AGLNGEBFGFL IBHBGBEBHJM, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) IAHPHHNFGHI)
	{
		return default(global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6F50", Offset = "0x3FA5550", VA = "0x183FA6F50")]
	public void CHCFBADACAC(in global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA73C0", Offset = "0x3FA59C0", VA = "0x183FA73C0")]
	public void NDHGFAIAHEE(in global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> PJGOPPMNMAI, in TSyncFieldValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3610530", Offset = "0x360EB30", VA = "0x183610530", Slot = "15")]
	public void KMKOINPOIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7460", Offset = "0x3FA5A60", VA = "0x183FA7460")]
	public void OAJINOHIBOB(global::GFOJEHCBKMK<FLFBOMKKKAC> CAEOMKLPFEI, in TAction PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA6FF0", Offset = "0x3FA55F0", VA = "0x183FA6FF0", Slot = "5")]
	private void DCHFMKAEBAP(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3FA72C0", Offset = "0x3FA58C0", VA = "0x183FA72C0", Slot = "6")]
	private void JIADGOFLPMC(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3DB07A0", Offset = "0x3DAEDA0", VA = "0x183DB07A0", Slot = "7")]
	private void ANFEHAMEONG(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7430", Offset = "0x3FA5A30", VA = "0x183FA7430", Slot = "8")]
	private void NOJMBKMLELA(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7220", Offset = "0x3FA5820", VA = "0x183FA7220", Slot = "9")]
	private global::GFOJEHCBKMK<BNHJKKFKABK> IMIFHDHHDAG(in AGLNGEBFGFL LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3FA71F0", Offset = "0x3FA57F0", VA = "0x183FA71F0", Slot = "10")]
	private bool HICKGIFOPAO(in AGLNGEBFGFL LGKNNMGLNIA, global::GFOJEHCBKMK<BNHJKKFKABK> PAIIMNGOMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7250", Offset = "0x3FA5850", VA = "0x183FA7250", Slot = "11")]
	private global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> JDKOLAOIMCK(global::GFOJEHCBKMK<BEAFNHKLJOO> CBBOJGIJLHN, in AGLNGEBFGFL LGKNNMGLNIA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) IAHPHHNFGHI)
	{
		return default(global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFDC0", Offset = "0x3DAE3C0", VA = "0x183DAFDC0", Slot = "12")]
	private void CFGJDNHIDNJ(in global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3FA7570", Offset = "0x3FA5B70", VA = "0x183FA7570", Slot = "13")]
	private void OMJGDLKKHBE(in global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> PJGOPPMNMAI, in TSyncFieldValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3940820", Offset = "0x393EE20", VA = "0x183940820", Slot = "16")]
	private void EODEMMCEEDB(global::GFOJEHCBKMK<FLFBOMKKKAC> CAEOMKLPFEI, in TAction PBOHOIMMGFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ADHPELINCNG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::AIFBJHBPEIG<TRpcParam> where TActionReceiver : global::LPEKEIDKFFK<TAction, Task<global::IKEELLNFFOM<object, IHHGNGPIMCG>>> where TActionDeps : global::ENKGGCLDLDO<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::GFOJEHCBKMK<BNHJKKFKABK> LAFHLFLBGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::BGKBNBCOCPB<EEFACAHEJEN, global::HMECHHELLOK<BNHJKKFKABK>> PALCNGMHNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::LLIEBDNMCJE<BNHJKKFKABK, TSyncFieldValue>> KBCFIIGIJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::MDEOAKPENML<BNHJKKFKABK, global::BINIOJKFBJC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> HOIMFAIOOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps HDINDNDKEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::GFOJEHCBKMK<BNHJKKFKABK> ActorId, global::GFOJEHCBKMK<FLFBOMKKKAC> RequestId, TAction Action)> KDDJCFDHMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? JLDFIKKJNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? CMHKKFDAPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::GFOJEHCBKMK<BNHJKKFKABK> ActorId, global::GFOJEHCBKMK<FLFBOMKKKAC> RequestId, TAction Action)> DKBOGLJEPJM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::GFOJEHCBKMK<BNHJKKFKABK> IFKEMEBMPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x695660", Offset = "0x693C60", VA = "0x180695660")]
		get
		{
			return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x42841E0", Offset = "0x42827E0", VA = "0x1842841E0")]
	protected ADHPELINCNG(TActionDeps BOOFAKJMFNF, int? JLELKFPKCCO, int? ECKHDMNIIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4282270", Offset = "0x4280870", VA = "0x184282270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4282C10", Offset = "0x4281210", VA = "0x184282C10")]
	public global::BINIOJKFBJC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HMGBKNGKNEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4281DD0", Offset = "0x42803D0", VA = "0x184281DD0")]
	internal global::GFOJEHCBKMK<JJOHJGHOLNH> DHFBPNPAJMG(global::GFOJEHCBKMK<BNHJKKFKABK> EENAIJIEBAF)
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4281AF0", Offset = "0x42800F0", VA = "0x184281AF0")]
	internal void BHHFEICBEND(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4281AA0", Offset = "0x42800A0", VA = "0x184281AA0")]
	internal global::GFOJEHCBKMK<BNHJKKFKABK> AHLJJJICDDF(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4281D40", Offset = "0x4280340", VA = "0x184281D40")]
	internal void CCFEKFEPCFO(global::GFOJEHCBKMK<BNHJKKFKABK> EIIAHBBFOEO, global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4283CA0", Offset = "0x42822A0", VA = "0x184283CA0")]
	internal void KGHGNHKLHFO(global::GFOJEHCBKMK<BNHJKKFKABK> EEKIMOFEMMN, global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x42838C0", Offset = "0x4281EC0", VA = "0x1842838C0")]
	internal void JBELEHJAMCJ(global::GFOJEHCBKMK<BNHJKKFKABK> EIIAHBBFOEO, global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x42820D0", Offset = "0x42806D0", VA = "0x1842820D0")]
	internal global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> DLPGHEBCEMJ(global::GFOJEHCBKMK<BNHJKKFKABK> NDEEJFGJDMC, global::GFOJEHCBKMK<BEAFNHKLJOO> AMOJNABADGD, string AIGAKEKDKHM, in TSyncFieldValue MAKFNMHIJIF, Action ONHFNOPIIKL, Action<object> CHPIJMBKPKI, Func<bool> FBNNEIEHHJN)
	{
		return default(global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4283BB0", Offset = "0x42821B0", VA = "0x184283BB0")]
	internal void JMJMBNHCOID(global::GFOJEHCBKMK<BNHJKKFKABK> NDEEJFGJDMC, string AIGAKEKDKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4281880", Offset = "0x427FE80", VA = "0x184281880")]
	internal void AFDEDOLLDML(global::LLIEBDNMCJE<BNHJKKFKABK, TSyncFieldValue> AMOJNABADGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4283D10", Offset = "0x4282310", VA = "0x184283D10")]
	internal void KMKOINPOIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4283D50", Offset = "0x4282350", VA = "0x184283D50")]
	internal void OAJINOHIBOB(global::GFOJEHCBKMK<BNHJKKFKABK> BDKOHAFBNID, global::GFOJEHCBKMK<FLFBOMKKKAC> CAEOMKLPFEI, in TAction PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4283AE0", Offset = "0x42820E0", VA = "0x184283AE0")]
	[CompilerGenerated]
	private global::BINIOJKFBJC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JIINNNCHCME(global::GFOJEHCBKMK<BNHJKKFKABK> NNFCBMDBJBO)
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
