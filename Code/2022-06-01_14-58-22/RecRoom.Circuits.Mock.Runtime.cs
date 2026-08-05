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
public readonly struct CGNJKHCCHHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GLLAMIFCGAE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable, global::OPLBCEGOAND<global::ACAPOMDGPAA<JPCAOFLMHIK>, global::ACAPOMDGPAA<LPKMDKCOBLF>, TRpcParam, TRpcReceiver, global::ACAPOMDGPAA<AFPMIBPJNBH>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::EEBKPMLCADJ<TAction, Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>>, TActionReceiver> where TRpcReceiver : global::CCCIDAFANDK<TRpcParam> where TActionReceiver : global::HFFCJGBPKDN<TAction, Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>>> where TActionDeps : global::LLAGNHGGBGM<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class GKPGHAHJJPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::GLLAMIFCGAE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public GKPGHAHJJPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class ONBMLFBEKKL
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
			public ONBMLFBEKKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskCompletionSource<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private TaskAwaiter<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x38B9FB0", Offset = "0x38B89B0", VA = "0x1838B9FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GKPGHAHJJPN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public ONBMLFBEKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x38B9DE0", Offset = "0x38B87E0", VA = "0x1838B9DE0")]
		[AsyncStateMachine(typeof(global::GLLAMIFCGAE<, , , , , >.ONBMLFBEKKL.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> NEODHPLBLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::ACAPOMDGPAA<CGNJKHCCHHK>, global::ACAPOMDGPAA<JPCAOFLMHIK>> MPEIDDHHJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::ACAPOMDGPAA<CGNJKHCCHHK>> GBMAIGAIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::LKDMMBKCNAC<int> GPPIIPMFIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::ACAPOMDGPAA<LPKMDKCOBLF> ActorId, global::ACAPOMDGPAA<GGPGFFFAEAI> RequestId, TAction Action)> KFCFBFPPGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool MIEBBKLFEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> JHDAMLDCABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::IDLDHCFCKIH<GECMFGAGDHF, global::ACAPOMDGPAA<LPKMDKCOBLF>, TRpcParam, TRpcReceiver, global::HEMGIPPLBMO<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OCLBDEMEOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BCEACBICPCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool NCMHDNADBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x38B3A40", Offset = "0x38B2440", VA = "0x1838B3A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> CNPKAMFLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x38B3C70", Offset = "0x38B2670", VA = "0x1838B3C70", Slot = "5")]
		get
		{
			return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38B4340", Offset = "0x38B2D40", VA = "0x1838B4340")]
	protected GLLAMIFCGAE(global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CMIHJGBLBEB, global::IDLDHCFCKIH<GECMFGAGDHF, global::ACAPOMDGPAA<LPKMDKCOBLF>, TRpcParam, TRpcReceiver, global::HEMGIPPLBMO<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CELMGHMCICJ, global::GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JINDDPKKFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x34FBD40", Offset = "0x34FA740", VA = "0x1834FBD40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x38B3CA0", Offset = "0x38B26A0", VA = "0x1838B3CA0")]
	public static global::GLLAMIFCGAE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IHEMFNLEEFI(global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CMIHJGBLBEB, global::IDLDHCFCKIH<GECMFGAGDHF, global::ACAPOMDGPAA<LPKMDKCOBLF>, TRpcParam, TRpcReceiver, global::HEMGIPPLBMO<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CELMGHMCICJ, global::GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JINDDPKKFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BEC0", Offset = "0x2E0A8C0", VA = "0x182E0BEC0")]
	public global::ACAPOMDGPAA<JPCAOFLMHIK> DDDNEFNBPPJ()
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x38B3B70", Offset = "0x38B2570", VA = "0x1838B3B70")]
	internal global::ACAPOMDGPAA<JPCAOFLMHIK> GMGDOLIBIJC(in global::ACAPOMDGPAA<CGNJKHCCHHK> AKGOJHKMAIK, in GECMFGAGDHF FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38B3ED0", Offset = "0x38B28D0", VA = "0x1838B3ED0")]
	internal void KLJEFKHDEGP(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38B39E0", Offset = "0x38B23E0", VA = "0x1838B39E0")]
	internal void FJKNBFFAIFK(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38B3DB0", Offset = "0x38B27B0", VA = "0x1838B3DB0")]
	internal void IOMKMLMOHFJ(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x38B3AA0", Offset = "0x38B24A0", VA = "0x1838B3AA0")]
	internal void GLHPEDADODN(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x38B3E10", Offset = "0x38B2810", VA = "0x1838B3E10")]
	internal void JIIOMPBMDDK(in global::ACAPOMDGPAA<AFPMIBPJNBH> HIMIACGHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x38B3FC0", Offset = "0x38B29C0", VA = "0x1838B3FC0")]
	public global::ACAPOMDGPAA<JPCAOFLMHIK> MDFJLIDDMJN(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x38B4220", Offset = "0x38B2C20", VA = "0x1838B4220")]
	public void NBDEBEFHCCK(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x38B42E0", Offset = "0x38B2CE0", VA = "0x1838B42E0")]
	public void NONMCMEDCEE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x38B38F0", Offset = "0x38B22F0", VA = "0x1838B38F0")]
	public void EHPNBGELKAE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x38B36D0", Offset = "0x38B20D0", VA = "0x1838B36D0")]
	public void CJAPIIHALOB(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x38B38C0", Offset = "0x38B22C0", VA = "0x1838B38C0")]
	public void EEDGNPHKPBA(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38B3C40", Offset = "0x38B2640", VA = "0x1838B3C40")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> HHCKAAMFPDF(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38B3F90", Offset = "0x38B2990", VA = "0x1838B3F90")]
	public bool LPCBLJOGCIK(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in global::ACAPOMDGPAA<LPKMDKCOBLF> LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x38B3950", Offset = "0x38B2350", VA = "0x1838B3950")]
	public global::ACAPOMDGPAA<AFPMIBPJNBH> EILANHMALCC(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BGOKFFKFKBE)
	{
		return default(global::ACAPOMDGPAA<AFPMIBPJNBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x38B4250", Offset = "0x38B2C50", VA = "0x1838B4250")]
	public void NCLBJEAIKDC(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x38B3980", Offset = "0x38B2380", VA = "0x1838B3980")]
	public void ENIBBEDGLBF(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x38B4020", Offset = "0x38B2A20", VA = "0x1838B4020")]
	public Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> MHHMJIGOIHB(in TAction APBFEHIGAIL, bool LJIIOCMODBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38B4280", Offset = "0x38B2C80", VA = "0x1838B4280")]
	public void NDGNENBHONJ(in TActionReceiver NMJEEJIPCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x38B3700", Offset = "0x38B2100", VA = "0x1838B3700")]
	public void CNNKOOJIBIC(in global::ACAPOMDGPAA<LPKMDKCOBLF> MFEJPJDDMMA, in global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, in TAction APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38B3C10", Offset = "0x38B2610", VA = "0x1838B3C10", Slot = "6")]
	private void GNLHKCDNAGE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38B3670", Offset = "0x38B2070", VA = "0x1838B3670", Slot = "7")]
	private void BGJHFKLNOLA(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38B3920", Offset = "0x38B2320", VA = "0x1838B3920", Slot = "8")]
	private void EIGIHKNKGPI(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38B39B0", Offset = "0x38B23B0", VA = "0x1838B39B0", Slot = "9")]
	private void FJJNNJALAEF(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38B3D80", Offset = "0x38B2780", VA = "0x1838B3D80", Slot = "10")]
	private void IJOEECLHFJC(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38B36A0", Offset = "0x38B20A0", VA = "0x1838B36A0", Slot = "11")]
	private global::ACAPOMDGPAA<LPKMDKCOBLF> BKKOHEPIKIN(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x38B3B40", Offset = "0x38B2540", VA = "0x1838B3B40", Slot = "12")]
	private bool GMCBPEDBPEI(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in global::ACAPOMDGPAA<LPKMDKCOBLF> LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x38B3F60", Offset = "0x38B2960", VA = "0x1838B3F60", Slot = "13")]
	private global::ACAPOMDGPAA<AFPMIBPJNBH> LGOBICGMMFD(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BGOKFFKFKBE)
	{
		return default(global::ACAPOMDGPAA<AFPMIBPJNBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x38B4310", Offset = "0x38B2D10", VA = "0x1838B4310", Slot = "14")]
	private void PBOMELOHCPK(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x38B3890", Offset = "0x38B2290", VA = "0x1838B3890", Slot = "15")]
	private void EAPIIKGGNDE(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x38B42B0", Offset = "0x38B2CB0", VA = "0x1838B42B0", Slot = "16")]
	private Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> NGPFDLPFJBM(in TAction APBFEHIGAIL, bool LJIIOCMODBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::FICKIIKHLFD<GECMFGAGDHF, global::ACAPOMDGPAA<LPKMDKCOBLF>, TRpcParam, global::HEMGIPPLBMO<TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::BDGKJIBINMJ<TAction> where TRpcReceiver : global::CCCIDAFANDK<TRpcParam> where TActionReceiver : global::HFFCJGBPKDN<TAction, Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>>> where TActionDeps : global::LLAGNHGGBGM<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::NJEKECNGEPL<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> APGIIPEDADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::ACAPOMDGPAA<LPKMDKCOBLF> ILEHLABILCA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> CNPKAMFLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x564470", Offset = "0x562E70", VA = "0x180564470", Slot = "4")]
		get
		{
			return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> BBAHDCPGGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x564470", Offset = "0x562E70", VA = "0x180564470", Slot = "14")]
		get
		{
			return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3A16BB0", Offset = "0x3A155B0", VA = "0x183A16BB0")]
	private DNHGPEFCILN(global::NJEKECNGEPL<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> ADGDOJLBDLJ, in global::ACAPOMDGPAA<LPKMDKCOBLF> AKGOJHKMAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3A16830", Offset = "0x3A15230", VA = "0x183A16830")]
	public static global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IHEMFNLEEFI(in global::ACAPOMDGPAA<LPKMDKCOBLF> AKGOJHKMAIK, global::NJEKECNGEPL<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> ADGDOJLBDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3A164F0", Offset = "0x3A14EF0", VA = "0x183A164F0")]
	public global::ACAPOMDGPAA<JPCAOFLMHIK> DDDNEFNBPPJ()
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3A16A80", Offset = "0x3A15480", VA = "0x183A16A80")]
	public void NBDEBEFHCCK(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3A16B20", Offset = "0x3A15520", VA = "0x183A16B20")]
	public void NONMCMEDCEE(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3A16530", Offset = "0x3A14F30", VA = "0x183A16530")]
	public void EHPNBGELKAE(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3A16470", Offset = "0x3A14E70", VA = "0x183A16470")]
	public void CJAPIIHALOB(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3A167D0", Offset = "0x3A151D0", VA = "0x183A167D0")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> HHCKAAMFPDF(in GECMFGAGDHF FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3A16970", Offset = "0x3A15370", VA = "0x183A16970")]
	public bool LPCBLJOGCIK(in GECMFGAGDHF FBOGCDJOCBP, in global::ACAPOMDGPAA<LPKMDKCOBLF> LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3A165C0", Offset = "0x3A14FC0", VA = "0x183A165C0")]
	public global::HEMGIPPLBMO<TSyncFieldValue> EILANHMALCC(in global::ACAPOMDGPAA<AFPMIBPJNBH> HIMIACGHJCP, in GECMFGAGDHF HHCBHHNLICO, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BGOKFFKFKBE)
	{
		return default(global::HEMGIPPLBMO<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3A16AC0", Offset = "0x3A154C0", VA = "0x183A16AC0")]
	public void NCLBJEAIKDC(in global::HEMGIPPLBMO<TSyncFieldValue> BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3A16700", Offset = "0x3A15100", VA = "0x183A16700")]
	public void FKMAAFJFGJL(in global::HEMGIPPLBMO<TSyncFieldValue> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3207540", Offset = "0x3205F40", VA = "0x183207540", Slot = "15")]
	public void OFJMJKHECPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3A16A10", Offset = "0x3A15410", VA = "0x183A16A10")]
	public void MHHMJIGOIHB(in global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, in TAction APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A166A0", Offset = "0x3A150A0", VA = "0x183A166A0", Slot = "5")]
	private void FGNMMKKMBNO(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3A166D0", Offset = "0x3A150D0", VA = "0x183A166D0", Slot = "6")]
	private void FIIKGFIGOKL(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3739530", Offset = "0x3737F30", VA = "0x183739530", Slot = "7")]
	private void NFPAEAJNJLD(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3A167A0", Offset = "0x3A151A0", VA = "0x183A167A0", Slot = "8")]
	private void HENEDPKNNJL(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A16770", Offset = "0x3A15170", VA = "0x183A16770", Slot = "9")]
	private global::ACAPOMDGPAA<LPKMDKCOBLF> GLMGOCIMJEH(in GECMFGAGDHF FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3A16800", Offset = "0x3A15200", VA = "0x183A16800", Slot = "10")]
	private bool HPOCODNEODI(in GECMFGAGDHF FBOGCDJOCBP, in global::ACAPOMDGPAA<LPKMDKCOBLF> LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3A16900", Offset = "0x3A15300", VA = "0x183A16900", Slot = "11")]
	private global::HEMGIPPLBMO<TSyncFieldValue> JJFIOIKLNDI(in global::ACAPOMDGPAA<AFPMIBPJNBH> EPEDGGPALGC, in GECMFGAGDHF FBOGCDJOCBP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BGOKFFKFKBE)
	{
		return default(global::HEMGIPPLBMO<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x32C6050", Offset = "0x32C4A50", VA = "0x1832C6050", Slot = "12")]
	private void EKLLMGJJHBJ(in global::HEMGIPPLBMO<TSyncFieldValue> BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A16440", Offset = "0x3A14E40", VA = "0x183A16440", Slot = "13")]
	private void ABEEFHDCPKI(in global::HEMGIPPLBMO<TSyncFieldValue> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3A16A50", Offset = "0x3A15450", VA = "0x183A16A50", Slot = "16")]
	private void MNCHPPBGNFO(in global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, in TAction APBFEHIGAIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NJEKECNGEPL<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::CCCIDAFANDK<TRpcParam> where TActionReceiver : global::HFFCJGBPKDN<TAction, Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>>> where TActionDeps : global::LLAGNHGGBGM<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::ACAPOMDGPAA<LPKMDKCOBLF> JCLFACAGBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly global::JIOGIJKAOLL<CGNJKHCCHHK, HBOIJDDKOPJ> FFLOKLOGPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<string, global::OHMNCAKNEMM<TSyncFieldValue>> OEBLCHPHEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly global::ACPCPEDDOCB<LPKMDKCOBLF, global::GLLAMIFCGAE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MEIDPFLOJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly TActionDeps MGKNOONMDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly List<(global::ACAPOMDGPAA<LPKMDKCOBLF> ActorId, global::ACAPOMDGPAA<GGPGFFFAEAI> RequestId, TAction Action)> IJANOBNFACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? MIIMCNGPHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly int? EBDMDFHNFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Queue<(global::ACAPOMDGPAA<LPKMDKCOBLF> ActorId, global::ACAPOMDGPAA<GGPGFFFAEAI> RequestId, TAction Action)> HGNJMFPHKDN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::ACAPOMDGPAA<LPKMDKCOBLF> NMNILDJDFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x560010", Offset = "0x55EA10", VA = "0x180560010")]
		get
		{
			return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C810", Offset = "0x3E0B210", VA = "0x183E0C810")]
	protected NJEKECNGEPL(TActionDeps ELGHPOOBFNO, int? GJLJCALNDOH, int? JCABPMMPKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B0E0", Offset = "0x3E09AE0", VA = "0x183E0B0E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C0E0", Offset = "0x3E0AAE0", VA = "0x183E0C0E0")]
	public global::GLLAMIFCGAE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MMKOKBCPHNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E0AD50", Offset = "0x3E09750", VA = "0x183E0AD50")]
	internal global::ACAPOMDGPAA<JPCAOFLMHIK> DDDNEFNBPPJ(in global::ACAPOMDGPAA<LPKMDKCOBLF> BBHINPCLGGA)
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B480", Offset = "0x3E09E80", VA = "0x183E0B480")]
	internal void IEPJPMCFIEI(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B420", Offset = "0x3E09E20", VA = "0x183E0B420")]
	internal global::ACAPOMDGPAA<LPKMDKCOBLF> HHCKAAMFPDF(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B390", Offset = "0x3E09D90", VA = "0x183E0B390")]
	internal void FEBFPBJEDCA(in global::ACAPOMDGPAA<LPKMDKCOBLF> PIAKIACPLOH, in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B880", Offset = "0x3E0A280", VA = "0x183E0B880")]
	internal void KDOLOKJKFIK(in global::ACAPOMDGPAA<LPKMDKCOBLF> BJBFHNPOMAO, in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B900", Offset = "0x3E0A300", VA = "0x183E0B900")]
	internal void KHMNHLJEFKG(in global::ACAPOMDGPAA<LPKMDKCOBLF> PIAKIACPLOH, in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C570", Offset = "0x3E0AF70", VA = "0x183E0C570")]
	internal global::HEMGIPPLBMO<TSyncFieldValue> NCEALPEDGLL(global::ACAPOMDGPAA<LPKMDKCOBLF> DCODONNOOLL, global::ACAPOMDGPAA<AFPMIBPJNBH> HIMIACGHJCP, string IPKOPOLJGIA, in TSyncFieldValue HPIAFNBPEPC, Action JJBCELLHKLO, Action<object> KGKDNBNNLMD, Func<bool> FOGBIENDONA)
	{
		return default(global::HEMGIPPLBMO<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3E0AC60", Offset = "0x3E09660", VA = "0x183E0AC60")]
	internal void CDNAHBEIGIE(global::ACAPOMDGPAA<LPKMDKCOBLF> DCODONNOOLL, string IPKOPOLJGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B630", Offset = "0x3E0A030", VA = "0x183E0B630")]
	internal void JIIOMPBMDDK(global::OHMNCAKNEMM<TSyncFieldValue> HIMIACGHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C7E0", Offset = "0x3E0B1E0", VA = "0x183E0C7E0")]
	internal void OFJMJKHECPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BB90", Offset = "0x3E0A590", VA = "0x183E0BB90")]
	internal void MHHMJIGOIHB(in global::ACAPOMDGPAA<LPKMDKCOBLF> MFEJPJDDMMA, in global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, in TAction APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C710", Offset = "0x3E0B110", VA = "0x183E0C710")]
	[CompilerGenerated]
	private global::GLLAMIFCGAE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> ODMOBGNMOCO(in global::ACAPOMDGPAA<LPKMDKCOBLF> OMEPNDMCDBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GECMFGAGDHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly global::ACAPOMDGPAA<CGNJKHCCHHK> PJELALKEFJC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x13A8CE0", Offset = "0x13A76E0", VA = "0x1813A8CE0")]
	private GECMFGAGDHF(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x631210", Offset = "0x62FC10", VA = "0x180631210")]
	public static GECMFGAGDHF IHEMFNLEEFI(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
		return default(GECMFGAGDHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HBOIJDDKOPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> ECGNFMDAFJJ;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x13A8CE0", Offset = "0x13A76E0", VA = "0x1813A8CE0")]
	private HBOIJDDKOPJ(in global::ACAPOMDGPAA<LPKMDKCOBLF> BBHINPCLGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x631210", Offset = "0x62FC10", VA = "0x180631210")]
	public static HBOIJDDKOPJ IHEMFNLEEFI(in global::ACAPOMDGPAA<LPKMDKCOBLF> BBHINPCLGGA)
	{
		return default(HBOIJDDKOPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HEMGIPPLBMO<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly MNJOJABCHIF OBKMHCFEFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly global::OHMNCAKNEMM<TSyncFieldValue> EEEPPBOFCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Action FHMPNHDDGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Action<object> CAEPEJLLOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Func<bool> PMNOBHAPOPG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x39D8C70", Offset = "0x39D7670", VA = "0x1839D8C70")]
	private HEMGIPPLBMO(MNJOJABCHIF KGHCCKFFBIB, global::OHMNCAKNEMM<TSyncFieldValue> NAOAFKBLJHC, Action JJBCELLHKLO, Action<object> KGKDNBNNLMD, Func<bool> FOGBIENDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x39D8B10", Offset = "0x39D7510", VA = "0x1839D8B10")]
	public static global::HEMGIPPLBMO<TSyncFieldValue> IHEMFNLEEFI(global::OHMNCAKNEMM<TSyncFieldValue> NAOAFKBLJHC, Action JJBCELLHKLO, Action<object> KGKDNBNNLMD, Func<bool> FOGBIENDONA)
	{
		return default(global::HEMGIPPLBMO<TSyncFieldValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class OHMNCAKNEMM<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly string OBDCJIABNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TSyncFieldValue CKLNJLLILCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly Dictionary<global::ACAPOMDGPAA<LPKMDKCOBLF>, global::ACAPOMDGPAA<AFPMIBPJNBH>> GHDGENOOIIL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28F4B20", Offset = "0x28F3520", VA = "0x1828F4B20")]
	private OHMNCAKNEMM(string IPKOPOLJGIA, in TSyncFieldValue HPIAFNBPEPC, Dictionary<global::ACAPOMDGPAA<LPKMDKCOBLF>, global::ACAPOMDGPAA<AFPMIBPJNBH>> KKFMKIFBJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28F4A00", Offset = "0x28F3400", VA = "0x1828F4A00")]
	public static global::OHMNCAKNEMM<TSyncFieldValue> IHEMFNLEEFI(string IPKOPOLJGIA, in TSyncFieldValue HPIAFNBPEPC)
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
