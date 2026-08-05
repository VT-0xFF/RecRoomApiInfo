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
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
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
			[Cpp2IlInjected.Address(RVA = "0x3417DE0", Offset = "0x34167E0", VA = "0x183417DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x834B50", Offset = "0x833550", VA = "0x180834B50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public ONBMLFBEKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x340DD40", Offset = "0x340C740", VA = "0x18340DD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x3403570", Offset = "0x3401F70", VA = "0x183403570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> CNPKAMFLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x34037A0", Offset = "0x34021A0", VA = "0x1834037A0", Slot = "5")]
		get
		{
			return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3403E70", Offset = "0x3402870", VA = "0x183403E70")]
	protected GLLAMIFCGAE(global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CMIHJGBLBEB, global::IDLDHCFCKIH<GECMFGAGDHF, global::ACAPOMDGPAA<LPKMDKCOBLF>, TRpcParam, TRpcReceiver, global::HEMGIPPLBMO<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CELMGHMCICJ, global::GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JINDDPKKFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2DBBEB0", Offset = "0x2DBA8B0", VA = "0x182DBBEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x34037D0", Offset = "0x34021D0", VA = "0x1834037D0")]
	public static global::GLLAMIFCGAE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IHEMFNLEEFI(global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CMIHJGBLBEB, global::IDLDHCFCKIH<GECMFGAGDHF, global::ACAPOMDGPAA<LPKMDKCOBLF>, TRpcParam, TRpcReceiver, global::HEMGIPPLBMO<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CELMGHMCICJ, global::GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JINDDPKKFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8160", VA = "0x1828D9760")]
	public global::ACAPOMDGPAA<JPCAOFLMHIK> DDDNEFNBPPJ()
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x34036A0", Offset = "0x34020A0", VA = "0x1834036A0")]
	internal global::ACAPOMDGPAA<JPCAOFLMHIK> GMGDOLIBIJC(in global::ACAPOMDGPAA<CGNJKHCCHHK> AKGOJHKMAIK, in GECMFGAGDHF FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3403A00", Offset = "0x3402400", VA = "0x183403A00")]
	internal void KLJEFKHDEGP(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3403510", Offset = "0x3401F10", VA = "0x183403510")]
	internal void FJKNBFFAIFK(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34038E0", Offset = "0x34022E0", VA = "0x1834038E0")]
	internal void IOMKMLMOHFJ(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x34035D0", Offset = "0x3401FD0", VA = "0x1834035D0")]
	internal void GLHPEDADODN(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3403940", Offset = "0x3402340", VA = "0x183403940")]
	internal void JIIOMPBMDDK(in global::ACAPOMDGPAA<AFPMIBPJNBH> HIMIACGHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3403AF0", Offset = "0x34024F0", VA = "0x183403AF0")]
	public global::ACAPOMDGPAA<JPCAOFLMHIK> MDFJLIDDMJN(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3403D50", Offset = "0x3402750", VA = "0x183403D50")]
	public void NBDEBEFHCCK(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3403E10", Offset = "0x3402810", VA = "0x183403E10")]
	public void NONMCMEDCEE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3403420", Offset = "0x3401E20", VA = "0x183403420")]
	public void EHPNBGELKAE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3403200", Offset = "0x3401C00", VA = "0x183403200")]
	public void CJAPIIHALOB(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x34033F0", Offset = "0x3401DF0", VA = "0x1834033F0")]
	public void EEDGNPHKPBA(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3403770", Offset = "0x3402170", VA = "0x183403770")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> HHCKAAMFPDF(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3403AC0", Offset = "0x34024C0", VA = "0x183403AC0")]
	public bool LPCBLJOGCIK(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in global::ACAPOMDGPAA<LPKMDKCOBLF> LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3403480", Offset = "0x3401E80", VA = "0x183403480")]
	public global::ACAPOMDGPAA<AFPMIBPJNBH> EILANHMALCC(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BGOKFFKFKBE)
	{
		return default(global::ACAPOMDGPAA<AFPMIBPJNBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3403D80", Offset = "0x3402780", VA = "0x183403D80")]
	public void NCLBJEAIKDC(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34034B0", Offset = "0x3401EB0", VA = "0x1834034B0")]
	public void ENIBBEDGLBF(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3403B50", Offset = "0x3402550", VA = "0x183403B50")]
	public Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> MHHMJIGOIHB(in TAction APBFEHIGAIL, bool LJIIOCMODBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3403DB0", Offset = "0x34027B0", VA = "0x183403DB0")]
	public void NDGNENBHONJ(in TActionReceiver NMJEEJIPCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3403230", Offset = "0x3401C30", VA = "0x183403230")]
	public void CNNKOOJIBIC(in global::ACAPOMDGPAA<LPKMDKCOBLF> MFEJPJDDMMA, in global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, in TAction APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3403740", Offset = "0x3402140", VA = "0x183403740", Slot = "6")]
	private void GNLHKCDNAGE(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x34031A0", Offset = "0x3401BA0", VA = "0x1834031A0", Slot = "7")]
	private void BGJHFKLNOLA(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3403450", Offset = "0x3401E50", VA = "0x183403450", Slot = "8")]
	private void EIGIHKNKGPI(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x34034E0", Offset = "0x3401EE0", VA = "0x1834034E0", Slot = "9")]
	private void FJJNNJALAEF(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34038B0", Offset = "0x34022B0", VA = "0x1834038B0", Slot = "10")]
	private void IJOEECLHFJC(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in TRpcReceiver CDPLICEKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x34031D0", Offset = "0x3401BD0", VA = "0x1834031D0", Slot = "11")]
	private global::ACAPOMDGPAA<LPKMDKCOBLF> BKKOHEPIKIN(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3403670", Offset = "0x3402070", VA = "0x183403670", Slot = "12")]
	private bool GMCBPEDBPEI(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in global::ACAPOMDGPAA<LPKMDKCOBLF> LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3403A90", Offset = "0x3402490", VA = "0x183403A90", Slot = "13")]
	private global::ACAPOMDGPAA<AFPMIBPJNBH> LGOBICGMMFD(in global::ACAPOMDGPAA<JPCAOFLMHIK> FBOGCDJOCBP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BGOKFFKFKBE)
	{
		return default(global::ACAPOMDGPAA<AFPMIBPJNBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3403E40", Offset = "0x3402840", VA = "0x183403E40", Slot = "14")]
	private void PBOMELOHCPK(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x34033C0", Offset = "0x3401DC0", VA = "0x1834033C0", Slot = "15")]
	private void EAPIIKGGNDE(in global::ACAPOMDGPAA<AFPMIBPJNBH> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3403DE0", Offset = "0x34027E0", VA = "0x183403DE0", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x551E70", VA = "0x180553470", Slot = "4")]
		get
		{
			return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> BBAHDCPGGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x551E70", VA = "0x180553470", Slot = "14")]
		get
		{
			return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x36BCA30", Offset = "0x36BB430", VA = "0x1836BCA30")]
	private DNHGPEFCILN(global::NJEKECNGEPL<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> ADGDOJLBDLJ, in global::ACAPOMDGPAA<LPKMDKCOBLF> AKGOJHKMAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x36BC680", Offset = "0x36BB080", VA = "0x1836BC680")]
	public static global::DNHGPEFCILN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IHEMFNLEEFI(in global::ACAPOMDGPAA<LPKMDKCOBLF> AKGOJHKMAIK, global::NJEKECNGEPL<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> ADGDOJLBDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x36BC3A0", Offset = "0x36BADA0", VA = "0x1836BC3A0")]
	public global::ACAPOMDGPAA<JPCAOFLMHIK> DDDNEFNBPPJ()
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x36BC8D0", Offset = "0x36BB2D0", VA = "0x1836BC8D0")]
	public void NBDEBEFHCCK(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x36BC970", Offset = "0x36BB370", VA = "0x1836BC970")]
	public void NONMCMEDCEE(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x36BC3E0", Offset = "0x36BADE0", VA = "0x1836BC3E0")]
	public void EHPNBGELKAE(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x36BC320", Offset = "0x36BAD20", VA = "0x1836BC320")]
	public void CJAPIIHALOB(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2F26550", Offset = "0x2F24F50", VA = "0x182F26550")]
	public global::ACAPOMDGPAA<LPKMDKCOBLF> HHCKAAMFPDF(in GECMFGAGDHF FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x36BC7C0", Offset = "0x36BB1C0", VA = "0x1836BC7C0")]
	public bool LPCBLJOGCIK(in GECMFGAGDHF FBOGCDJOCBP, in global::ACAPOMDGPAA<LPKMDKCOBLF> LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x36BC470", Offset = "0x36BAE70", VA = "0x1836BC470")]
	public global::HEMGIPPLBMO<TSyncFieldValue> EILANHMALCC(in global::ACAPOMDGPAA<AFPMIBPJNBH> HIMIACGHJCP, in GECMFGAGDHF HHCBHHNLICO, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BGOKFFKFKBE)
	{
		return default(global::HEMGIPPLBMO<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x36BC910", Offset = "0x36BB310", VA = "0x1836BC910")]
	public void NCLBJEAIKDC(in global::HEMGIPPLBMO<TSyncFieldValue> BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x36BC5B0", Offset = "0x36BAFB0", VA = "0x1836BC5B0")]
	public void FKMAAFJFGJL(in global::HEMGIPPLBMO<TSyncFieldValue> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x36BCA00", Offset = "0x36BB400", VA = "0x1836BCA00", Slot = "15")]
	public void OFJMJKHECPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x36BC860", Offset = "0x36BB260", VA = "0x1836BC860")]
	public void MHHMJIGOIHB(in global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, in TAction APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x36BC550", Offset = "0x36BAF50", VA = "0x1836BC550", Slot = "5")]
	private void FGNMMKKMBNO(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36BC580", Offset = "0x36BAF80", VA = "0x1836BC580", Slot = "6")]
	private void FIIKGFIGOKL(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29D69D0", Offset = "0x29D53D0", VA = "0x1829D69D0", Slot = "7")]
	private void NFPAEAJNJLD(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x36BC650", Offset = "0x36BB050", VA = "0x1836BC650", Slot = "8")]
	private void HENEDPKNNJL(in GECMFGAGDHF FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36BC620", Offset = "0x36BB020", VA = "0x1836BC620", Slot = "9")]
	private global::ACAPOMDGPAA<LPKMDKCOBLF> GLMGOCIMJEH(in GECMFGAGDHF FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35FE610", Offset = "0x35FD010", VA = "0x1835FE610", Slot = "10")]
	private bool HPOCODNEODI(in GECMFGAGDHF FBOGCDJOCBP, in global::ACAPOMDGPAA<LPKMDKCOBLF> LIIIKAIOJCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36BC750", Offset = "0x36BB150", VA = "0x1836BC750", Slot = "11")]
	private global::HEMGIPPLBMO<TSyncFieldValue> JJFIOIKLNDI(in global::ACAPOMDGPAA<AFPMIBPJNBH> EPEDGGPALGC, in GECMFGAGDHF FBOGCDJOCBP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BGOKFFKFKBE)
	{
		return default(global::HEMGIPPLBMO<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x29D6160", Offset = "0x29D4B60", VA = "0x1829D6160", Slot = "12")]
	private void EKLLMGJJHBJ(in global::HEMGIPPLBMO<TSyncFieldValue> BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35FE640", Offset = "0x35FD040", VA = "0x1835FE640", Slot = "13")]
	private void ABEEFHDCPKI(in global::HEMGIPPLBMO<TSyncFieldValue> OCJCHAADOHL, in TSyncFieldValue HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36BC8A0", Offset = "0x36BB2A0", VA = "0x1836BC8A0", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DA10", VA = "0x18054F010")]
		get
		{
			return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28CA5A0", Offset = "0x28C8FA0", VA = "0x1828CA5A0")]
	protected NJEKECNGEPL(TActionDeps ELGHPOOBFNO, int? GJLJCALNDOH, int? JCABPMMPKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28C8E70", Offset = "0x28C7870", VA = "0x1828C8E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28C9E70", Offset = "0x28C8870", VA = "0x1828C9E70")]
	public global::GLLAMIFCGAE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MMKOKBCPHNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28C8AE0", Offset = "0x28C74E0", VA = "0x1828C8AE0")]
	internal global::ACAPOMDGPAA<JPCAOFLMHIK> DDDNEFNBPPJ(in global::ACAPOMDGPAA<LPKMDKCOBLF> BBHINPCLGGA)
	{
		return default(global::ACAPOMDGPAA<JPCAOFLMHIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28C9210", Offset = "0x28C7C10", VA = "0x1828C9210")]
	internal void IEPJPMCFIEI(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28C91B0", Offset = "0x28C7BB0", VA = "0x1828C91B0")]
	internal global::ACAPOMDGPAA<LPKMDKCOBLF> HHCKAAMFPDF(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
		return default(global::ACAPOMDGPAA<LPKMDKCOBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28C9120", Offset = "0x28C7B20", VA = "0x1828C9120")]
	internal void FEBFPBJEDCA(in global::ACAPOMDGPAA<LPKMDKCOBLF> PIAKIACPLOH, in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28C9610", Offset = "0x28C8010", VA = "0x1828C9610")]
	internal void KDOLOKJKFIK(in global::ACAPOMDGPAA<LPKMDKCOBLF> BJBFHNPOMAO, in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x28C9690", Offset = "0x28C8090", VA = "0x1828C9690")]
	internal void KHMNHLJEFKG(in global::ACAPOMDGPAA<LPKMDKCOBLF> PIAKIACPLOH, in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP, in TRpcParam BGOKFFKFKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x28CA300", Offset = "0x28C8D00", VA = "0x1828CA300")]
	internal global::HEMGIPPLBMO<TSyncFieldValue> NCEALPEDGLL(global::ACAPOMDGPAA<LPKMDKCOBLF> DCODONNOOLL, global::ACAPOMDGPAA<AFPMIBPJNBH> HIMIACGHJCP, string IPKOPOLJGIA, in TSyncFieldValue HPIAFNBPEPC, Action JJBCELLHKLO, Action<object> KGKDNBNNLMD, Func<bool> FOGBIENDONA)
	{
		return default(global::HEMGIPPLBMO<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x28C89F0", Offset = "0x28C73F0", VA = "0x1828C89F0")]
	internal void CDNAHBEIGIE(global::ACAPOMDGPAA<LPKMDKCOBLF> DCODONNOOLL, string IPKOPOLJGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28C93C0", Offset = "0x28C7DC0", VA = "0x1828C93C0")]
	internal void JIIOMPBMDDK(global::OHMNCAKNEMM<TSyncFieldValue> HIMIACGHJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28CA570", Offset = "0x28C8F70", VA = "0x1828CA570")]
	internal void OFJMJKHECPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x28C9920", Offset = "0x28C8320", VA = "0x1828C9920")]
	internal void MHHMJIGOIHB(in global::ACAPOMDGPAA<LPKMDKCOBLF> MFEJPJDDMMA, in global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, in TAction APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x28CA4A0", Offset = "0x28C8EA0", VA = "0x1828CA4A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x101E2F0", Offset = "0x101CCF0", VA = "0x18101E2F0")]
	private GECMFGAGDHF(in global::ACAPOMDGPAA<CGNJKHCCHHK> FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6043F0", Offset = "0x602DF0", VA = "0x1806043F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x101E2F0", Offset = "0x101CCF0", VA = "0x18101E2F0")]
	private HBOIJDDKOPJ(in global::ACAPOMDGPAA<LPKMDKCOBLF> BBHINPCLGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6043F0", Offset = "0x602DF0", VA = "0x1806043F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x35D4C40", Offset = "0x35D3640", VA = "0x1835D4C40")]
	private HEMGIPPLBMO(MNJOJABCHIF KGHCCKFFBIB, global::OHMNCAKNEMM<TSyncFieldValue> NAOAFKBLJHC, Action JJBCELLHKLO, Action<object> KGKDNBNNLMD, Func<bool> FOGBIENDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x35D4AE0", Offset = "0x35D34E0", VA = "0x1835D4AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2689300", Offset = "0x2687D00", VA = "0x182689300")]
	private OHMNCAKNEMM(string IPKOPOLJGIA, in TSyncFieldValue HPIAFNBPEPC, Dictionary<global::ACAPOMDGPAA<LPKMDKCOBLF>, global::ACAPOMDGPAA<AFPMIBPJNBH>> KKFMKIFBJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26891E0", Offset = "0x2687BE0", VA = "0x1826891E0")]
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
