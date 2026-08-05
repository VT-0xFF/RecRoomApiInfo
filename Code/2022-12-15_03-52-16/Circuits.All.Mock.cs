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
			[Cpp2IlInjected.Address(RVA = "0x1FD9CC0", Offset = "0x1FD86C0", VA = "0x181FD9CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public BGBNGEMJJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x45C8270", Offset = "0x45C6C70", VA = "0x1845C8270")]
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
		[Cpp2IlInjected.Address(RVA = "0x3427460", Offset = "0x3425E60", VA = "0x183427460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::GFOJEHCBKMK<BNHJKKFKABK> GAMBFDBGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x34276A0", Offset = "0x34260A0", VA = "0x1834276A0")]
		get
		{
			return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3427D00", Offset = "0x3426700", VA = "0x183427D00")]
	private BINIOJKFBJC(global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> LCOMIHDGHCD, global::GMIAMPIHODH<AGLNGEBFGFL, global::GFOJEHCBKMK<BNHJKKFKABK>, TRpcParam, TRpcReceiver, global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> APINOCCLLLE, global::BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JIPDLIANOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3427530", Offset = "0x3425F30", VA = "0x183427530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3427A90", Offset = "0x3426490", VA = "0x183427A90")]
	internal static global::BINIOJKFBJC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OJKIKDBCCPC(global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> LCOMIHDGHCD, global::GMIAMPIHODH<AGLNGEBFGFL, global::GFOJEHCBKMK<BNHJKKFKABK>, TRpcParam, TRpcReceiver, global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> APINOCCLLLE, global::BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JIPDLIANOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x264E6F0", Offset = "0x264D0F0", VA = "0x18264E6F0")]
	public global::GFOJEHCBKMK<JJOHJGHOLNH> DHFBPNPAJMG()
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3427700", Offset = "0x3426100", VA = "0x183427700")]
	internal global::GFOJEHCBKMK<JJOHJGHOLNH> HBCIIFKGDEA(global::GFOJEHCBKMK<EEFACAHEJEN> CBBOJGIJLHN, in AGLNGEBFGFL LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x34273B0", Offset = "0x3425DB0", VA = "0x1834273B0")]
	internal void BKOMAIMHCPM(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3427320", Offset = "0x3425D20", VA = "0x183427320")]
	internal void AIPCCKKGIAH(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3427A30", Offset = "0x3426430", VA = "0x183427A30")]
	internal void OBLDEJOPFLF(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3427590", Offset = "0x3425F90", VA = "0x183427590")]
	internal void ENFJIGBIMBO(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3427230", Offset = "0x3425C30", VA = "0x183427230")]
	internal void AFDEDOLLDML(global::GFOJEHCBKMK<BEAFNHKLJOO> AMOJNABADGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x34277A0", Offset = "0x34261A0", VA = "0x1834277A0")]
	public global::GFOJEHCBKMK<JJOHJGHOLNH> JGAJDJBNHCL(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x34274D0", Offset = "0x3425ED0", VA = "0x1834274D0")]
	public void CNIJMCOOONC(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3427380", Offset = "0x3425D80", VA = "0x183427380")]
	public void AMDOPNGNDGM(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3427500", Offset = "0x3425F00", VA = "0x183427500")]
	public void DFEAHKEDLNP(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3427560", Offset = "0x3425F60", VA = "0x183427560")]
	public void EJIIFOCOCHG(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x34276D0", Offset = "0x34260D0", VA = "0x1834276D0")]
	public void HAEAAFAFGID(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcReceiver JLNEPCPFMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34272F0", Offset = "0x3425CF0", VA = "0x1834272F0")]
	public global::GFOJEHCBKMK<BNHJKKFKABK> AHLJJJICDDF(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3427630", Offset = "0x3426030", VA = "0x183427630")]
	public bool FAMFILCLBIN(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, global::GFOJEHCBKMK<BNHJKKFKABK> PAIIMNGOMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3427800", Offset = "0x3426200", VA = "0x183427800")]
	public global::GFOJEHCBKMK<BEAFNHKLJOO> KDFAGNALDEL(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) IAHPHHNFGHI)
	{
		return default(global::GFOJEHCBKMK<BEAFNHKLJOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3427430", Offset = "0x3425E30", VA = "0x183427430")]
	public void CHCFBADACAC(global::GFOJEHCBKMK<BEAFNHKLJOO> PJGOPPMNMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3427670", Offset = "0x3426070", VA = "0x183427670")]
	public void GONFONCILEI(global::GFOJEHCBKMK<BEAFNHKLJOO> PJGOPPMNMAI, in TSyncFieldValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3427860", Offset = "0x3426260", VA = "0x183427860")]
	public Task<global::IKEELLNFFOM<object, IHHGNGPIMCG>> OAJINOHIBOB(in TAction PBOHOIMMGFG, bool EEEGNGIMIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3427830", Offset = "0x3426230", VA = "0x183427830")]
	public void LCPFJNMBJAF(in TActionReceiver LCFDFEFIJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3427B70", Offset = "0x3426570", VA = "0x183427B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0", Slot = "4")]
		get
		{
			return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::GFOJEHCBKMK<BNHJKKFKABK> OEBHMFJBOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0", Slot = "14")]
		get
		{
			return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x342DBC0", Offset = "0x342C5C0", VA = "0x18342DBC0")]
	private BKOEMANJOPF(global::ADHPELINCNG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GONEHAIFHNH, global::GFOJEHCBKMK<BNHJKKFKABK> CBBOJGIJLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x342DAC0", Offset = "0x342C4C0", VA = "0x18342DAC0")]
	public static global::BKOEMANJOPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OJKIKDBCCPC(global::GFOJEHCBKMK<BNHJKKFKABK> CBBOJGIJLHN, global::ADHPELINCNG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GONEHAIFHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x342D6C0", Offset = "0x342C0C0", VA = "0x18342D6C0")]
	public global::GFOJEHCBKMK<JJOHJGHOLNH> DHFBPNPAJMG()
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x342D5D0", Offset = "0x342BFD0", VA = "0x18342D5D0")]
	public void CNIJMCOOONC(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x342D4F0", Offset = "0x342BEF0", VA = "0x18342D4F0")]
	public void AMDOPNGNDGM(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x342D640", Offset = "0x342C040", VA = "0x18342D640")]
	public void DFEAHKEDLNP(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x342D700", Offset = "0x342C100", VA = "0x18342D700")]
	public void EJIIFOCOCHG(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x342D4B0", Offset = "0x342BEB0", VA = "0x18342D4B0")]
	public global::GFOJEHCBKMK<BNHJKKFKABK> AHLJJJICDDF(in AGLNGEBFGFL LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x342D780", Offset = "0x342C180", VA = "0x18342D780")]
	public bool FAMFILCLBIN(in AGLNGEBFGFL LGKNNMGLNIA, global::GFOJEHCBKMK<BNHJKKFKABK> PAIIMNGOMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x342D910", Offset = "0x342C310", VA = "0x18342D910")]
	public global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> KDFAGNALDEL(global::GFOJEHCBKMK<BEAFNHKLJOO> AMOJNABADGD, in AGLNGEBFGFL IBHBGBEBHJM, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) IAHPHHNFGHI)
	{
		return default(global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x342D570", Offset = "0x342BF70", VA = "0x18342D570")]
	public void CHCFBADACAC(in global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x342D9E0", Offset = "0x342C3E0", VA = "0x18342D9E0")]
	public void NDHGFAIAHEE(in global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> PJGOPPMNMAI, in TSyncFieldValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x285D450", Offset = "0x285BE50", VA = "0x18285D450", Slot = "15")]
	public void KMKOINPOIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x342DA80", Offset = "0x342C480", VA = "0x18342DA80")]
	public void OAJINOHIBOB(global::GFOJEHCBKMK<FLFBOMKKKAC> CAEOMKLPFEI, in TAction PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x342D610", Offset = "0x342C010", VA = "0x18342D610", Slot = "5")]
	private void DCHFMKAEBAP(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x342D8E0", Offset = "0x342C2E0", VA = "0x18342D8E0", Slot = "6")]
	private void JIADGOFLPMC(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x319BA70", Offset = "0x319A470", VA = "0x18319BA70", Slot = "7")]
	private void ANFEHAMEONG(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x342DA50", Offset = "0x342C450", VA = "0x18342DA50", Slot = "8")]
	private void NOJMBKMLELA(in AGLNGEBFGFL LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x342D840", Offset = "0x342C240", VA = "0x18342D840", Slot = "9")]
	private global::GFOJEHCBKMK<BNHJKKFKABK> IMIFHDHHDAG(in AGLNGEBFGFL LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x342D810", Offset = "0x342C210", VA = "0x18342D810", Slot = "10")]
	private bool HICKGIFOPAO(in AGLNGEBFGFL LGKNNMGLNIA, global::GFOJEHCBKMK<BNHJKKFKABK> PAIIMNGOMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x342D870", Offset = "0x342C270", VA = "0x18342D870", Slot = "11")]
	private global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> JDKOLAOIMCK(global::GFOJEHCBKMK<BEAFNHKLJOO> CBBOJGIJLHN, in AGLNGEBFGFL LGKNNMGLNIA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) IAHPHHNFGHI)
	{
		return default(global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x319B090", Offset = "0x3199A90", VA = "0x18319B090", Slot = "12")]
	private void CFGJDNHIDNJ(in global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x342DB90", Offset = "0x342C590", VA = "0x18342DB90", Slot = "13")]
	private void OMJGDLKKHBE(in global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> PJGOPPMNMAI, in TSyncFieldValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AE60", Offset = "0x2C09860", VA = "0x182C0AE60", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675A40", VA = "0x180677040")]
		get
		{
			return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x38B3F40", Offset = "0x38B2940", VA = "0x1838B3F40")]
	protected ADHPELINCNG(TActionDeps BOOFAKJMFNF, int? JLELKFPKCCO, int? ECKHDMNIIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38B1FD0", Offset = "0x38B09D0", VA = "0x1838B1FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x38B2970", Offset = "0x38B1370", VA = "0x1838B2970")]
	public global::BINIOJKFBJC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HMGBKNGKNEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x38B1B30", Offset = "0x38B0530", VA = "0x1838B1B30")]
	internal global::GFOJEHCBKMK<JJOHJGHOLNH> DHFBPNPAJMG(global::GFOJEHCBKMK<BNHJKKFKABK> EENAIJIEBAF)
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x38B1850", Offset = "0x38B0250", VA = "0x1838B1850")]
	internal void BHHFEICBEND(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38B1800", Offset = "0x38B0200", VA = "0x1838B1800")]
	internal global::GFOJEHCBKMK<BNHJKKFKABK> AHLJJJICDDF(global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<BNHJKKFKABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x38B1AA0", Offset = "0x38B04A0", VA = "0x1838B1AA0")]
	internal void CCFEKFEPCFO(global::GFOJEHCBKMK<BNHJKKFKABK> EIIAHBBFOEO, global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x38B3A00", Offset = "0x38B2400", VA = "0x1838B3A00")]
	internal void KGHGNHKLHFO(global::GFOJEHCBKMK<BNHJKKFKABK> EEKIMOFEMMN, global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38B3620", Offset = "0x38B2020", VA = "0x1838B3620")]
	internal void JBELEHJAMCJ(global::GFOJEHCBKMK<BNHJKKFKABK> EIIAHBBFOEO, global::GFOJEHCBKMK<EEFACAHEJEN> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x38B1E30", Offset = "0x38B0830", VA = "0x1838B1E30")]
	internal global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue> DLPGHEBCEMJ(global::GFOJEHCBKMK<BNHJKKFKABK> NDEEJFGJDMC, global::GFOJEHCBKMK<BEAFNHKLJOO> AMOJNABADGD, string AIGAKEKDKHM, in TSyncFieldValue MAKFNMHIJIF, Action ONHFNOPIIKL, Action<object> CHPIJMBKPKI, Func<bool> FBNNEIEHHJN)
	{
		return default(global::DLNCKAEEECF<BNHJKKFKABK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x38B3910", Offset = "0x38B2310", VA = "0x1838B3910")]
	internal void JMJMBNHCOID(global::GFOJEHCBKMK<BNHJKKFKABK> NDEEJFGJDMC, string AIGAKEKDKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x38B15E0", Offset = "0x38AFFE0", VA = "0x1838B15E0")]
	internal void AFDEDOLLDML(global::LLIEBDNMCJE<BNHJKKFKABK, TSyncFieldValue> AMOJNABADGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x38B3A70", Offset = "0x38B2470", VA = "0x1838B3A70")]
	internal void KMKOINPOIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x38B3AB0", Offset = "0x38B24B0", VA = "0x1838B3AB0")]
	internal void OAJINOHIBOB(global::GFOJEHCBKMK<BNHJKKFKABK> BDKOHAFBNID, global::GFOJEHCBKMK<FLFBOMKKKAC> CAEOMKLPFEI, in TAction PBOHOIMMGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x38B3840", Offset = "0x38B2240", VA = "0x1838B3840")]
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
