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
public sealed class IOCJBHNBBOI<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::HKMJIMJOIFA<TRpcParam> where TActionReceiver : global::EFPEKFLCOKL<TAction, Task<global::EMFHPGMFAOO<object, BMIGOOHOEBL>>> where TActionDeps : global::DGDJOLLFMAJ<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PAKGEJDFGNG
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
			public PAKGEJDFGNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5760", Offset = "0x1FB4360", VA = "0x181FB5760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::IOCJBHNBBOI<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public PAKGEJDFGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B419E0", Offset = "0x2B405E0", VA = "0x182B419E0")]
		[AsyncStateMachine(typeof(global::IOCJBHNBBOI<, , , , , >.PAKGEJDFGNG.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DPDFKNGGDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::IBGINLNKKBK<NCGFGLKJDKB>, global::IBGINLNKKBK<IALNLOOMFAE>> CKMPEAHLEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::IBGINLNKKBK<NCGFGLKJDKB>> NIPECNALCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::NIBGAACNLKK<int> JBGPCDBFCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::IBGINLNKKBK<BAALOOHBPAF> ActorId, global::IBGINLNKKBK<AHNKBHOFMFL> RequestId, TAction Action)> AFEFLFBHDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool HOFBBHLAFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> LFEBHGDAFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::DMKBBMIKBGL<NEIKAPDIANF, global::IBGINLNKKBK<BAALOOHBPAF>, TRpcParam, TRpcReceiver, global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JKOIAOEAICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JPOAHBBJNFK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool NJJMCILFLDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x180BC50", Offset = "0x180A850", VA = "0x18180BC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::IBGINLNKKBK<BAALOOHBPAF> LEJJINNGNID
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x180C0C0", Offset = "0x180ACC0", VA = "0x18180C0C0")]
		get
		{
			return default(global::IBGINLNKKBK<BAALOOHBPAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x180C660", Offset = "0x180B260", VA = "0x18180C660")]
	private IOCJBHNBBOI(global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HKPDNJBMEMK, global::DMKBBMIKBGL<NEIKAPDIANF, global::IBGINLNKKBK<BAALOOHBPAF>, TRpcParam, TRpcReceiver, global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CABJKGENCLP, global::AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JHGHFKCDGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x180BCC0", Offset = "0x180A8C0", VA = "0x18180BCC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x180C210", Offset = "0x180AE10", VA = "0x18180C210")]
	internal static global::IOCJBHNBBOI<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KCNAIILPDFM(global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HKPDNJBMEMK, global::DMKBBMIKBGL<NEIKAPDIANF, global::IBGINLNKKBK<BAALOOHBPAF>, TRpcParam, TRpcReceiver, global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CABJKGENCLP, global::AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JHGHFKCDGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x180C580", Offset = "0x180B180", VA = "0x18180C580")]
	public global::IBGINLNKKBK<IALNLOOMFAE> LBBLFNFOCLK()
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x180BCF0", Offset = "0x180A8F0", VA = "0x18180BCF0")]
	internal global::IBGINLNKKBK<IALNLOOMFAE> EKCKIKPLPBI(global::IBGINLNKKBK<NCGFGLKJDKB> GLGEGPNMJGF, in NEIKAPDIANF KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x180C5B0", Offset = "0x180B1B0", VA = "0x18180C5B0")]
	internal void OKEJJBDBGLM(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x180BE00", Offset = "0x180AA00", VA = "0x18180BE00")]
	internal void EPIFJIOCMGO(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x180BBF0", Offset = "0x180A7F0", VA = "0x18180BBF0")]
	internal void DIJOPBHHGCK(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x180C020", Offset = "0x180AC20", VA = "0x18180C020")]
	internal void HFHJJKGPCHB(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x180C2F0", Offset = "0x180AEF0", VA = "0x18180C2F0")]
	internal void KDCDKHLGFDJ(global::IBGINLNKKBK<LNJBBNNHEOH> GNHLNBEGIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x180C1B0", Offset = "0x180ADB0", VA = "0x18180C1B0")]
	public global::IBGINLNKKBK<IALNLOOMFAE> JPIFGLALGBA(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x180BB60", Offset = "0x180A760", VA = "0x18180BB60")]
	public void AHIKNEGPDDH(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x180C120", Offset = "0x180AD20", VA = "0x18180C120")]
	public void ICMNBPGKGLH(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x180C180", Offset = "0x180AD80", VA = "0x18180C180")]
	public void JEGIICGBCBE(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x180C630", Offset = "0x180B230", VA = "0x18180C630")]
	public void PHLLACMJJCG(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x180BB90", Offset = "0x180A790", VA = "0x18180BB90")]
	public void CGJNEMMCPPL(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcReceiver OIJGODEOMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x180BFF0", Offset = "0x180ABF0", VA = "0x18180BFF0")]
	public global::IBGINLNKKBK<BAALOOHBPAF> GFOCHMDMHGF(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<BAALOOHBPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x180BDC0", Offset = "0x180A9C0", VA = "0x18180BDC0")]
	public bool EMELPOEBKLC(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, global::IBGINLNKKBK<BAALOOHBPAF> ELMPCHPADPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x180BD90", Offset = "0x180A990", VA = "0x18180BD90")]
	public global::IBGINLNKKBK<LNJBBNNHEOH> EKMGLAJJJAG(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BHOMHPIPDNM)
	{
		return default(global::IBGINLNKKBK<LNJBBNNHEOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x180C150", Offset = "0x180AD50", VA = "0x18180C150")]
	public void INBNMKLOHEK(global::IBGINLNKKBK<LNJBBNNHEOH> KOKKABCBPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x180C0F0", Offset = "0x180ACF0", VA = "0x18180C0F0")]
	public void IBNADGHDDNO(global::IBGINLNKKBK<LNJBBNNHEOH> KOKKABCBPKB, in TSyncFieldValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x180C3B0", Offset = "0x180AFB0", VA = "0x18180C3B0")]
	public Task<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> KJNEKOOMBGN(in TAction KDJGJCHCIKK, bool KICHIDDLKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x180BBC0", Offset = "0x180A7C0", VA = "0x18180BBC0")]
	public void CKFFNBPFDNB(in TActionReceiver ELHGAKMGENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x180BE60", Offset = "0x180AA60", VA = "0x18180BE60")]
	public void EPLGEBJLJFE(global::IBGINLNKKBK<BAALOOHBPAF> KOKPOEFBIML, global::IBGINLNKKBK<AHNKBHOFMFL> LJHJJDLEMKE, in TAction KDJGJCHCIKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal sealed class CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::MLPOEGBNDEA<NEIKAPDIANF, global::IBGINLNKKBK<BAALOOHBPAF>, TRpcParam, global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::IFPNJANAJPP<TAction> where TRpcReceiver : global::HKMJIMJOIFA<TRpcParam> where TActionReceiver : global::EFPEKFLCOKL<TAction, Task<global::EMFHPGMFAOO<object, BMIGOOHOEBL>>> where TActionDeps : global::DGDJOLLFMAJ<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::BIEBMLLGHGD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DEGLFEOJPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::IBGINLNKKBK<BAALOOHBPAF> GJPMOAHJPEJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::IBGINLNKKBK<BAALOOHBPAF> LEJJINNGNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0", Slot = "4")]
		get
		{
			return default(global::IBGINLNKKBK<BAALOOHBPAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::IBGINLNKKBK<BAALOOHBPAF> ENMPOMDJDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0", Slot = "14")]
		get
		{
			return default(global::IBGINLNKKBK<BAALOOHBPAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39BB1C0", Offset = "0x39B9DC0", VA = "0x1839BB1C0")]
	private CBHHOOAKLBK(global::BIEBMLLGHGD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KMCOGBENCBH, global::IBGINLNKKBK<BAALOOHBPAF> GLGEGPNMJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39BAEF0", Offset = "0x39B9AF0", VA = "0x1839BAEF0")]
	public static global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KCNAIILPDFM(global::IBGINLNKKBK<BAALOOHBPAF> GLGEGPNMJGF, global::BIEBMLLGHGD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KMCOGBENCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x39BB070", Offset = "0x39B9C70", VA = "0x1839BB070")]
	public global::IBGINLNKKBK<IALNLOOMFAE> LBBLFNFOCLK()
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x39BAA80", Offset = "0x39B9680", VA = "0x1839BAA80")]
	public void AHIKNEGPDDH(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x39BAD90", Offset = "0x39B9990", VA = "0x1839BAD90")]
	public void ICMNBPGKGLH(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x39BAE70", Offset = "0x39B9A70", VA = "0x1839BAE70")]
	public void JEGIICGBCBE(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x39BB140", Offset = "0x39B9D40", VA = "0x1839BB140")]
	public void PHLLACMJJCG(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x39BAD50", Offset = "0x39B9950", VA = "0x1839BAD50")]
	public global::IBGINLNKKBK<BAALOOHBPAF> GFOCHMDMHGF(in NEIKAPDIANF KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<BAALOOHBPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x39BACC0", Offset = "0x39B98C0", VA = "0x1839BACC0")]
	public bool EMELPOEBKLC(in NEIKAPDIANF KMFLGGMLFJA, global::IBGINLNKKBK<BAALOOHBPAF> ELMPCHPADPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x39BABF0", Offset = "0x39B97F0", VA = "0x1839BABF0")]
	public global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> EKMGLAJJJAG(global::IBGINLNKKBK<LNJBBNNHEOH> GNHLNBEGIDP, in NEIKAPDIANF KBICBGPAOHG, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BHOMHPIPDNM)
	{
		return default(global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x39BAE10", Offset = "0x39B9A10", VA = "0x1839BAE10")]
	public void INBNMKLOHEK(in global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x39BAB50", Offset = "0x39B9750", VA = "0x1839BAB50")]
	public void EGDHJAFLBJF(in global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> KOKKABCBPKB, in TSyncFieldValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30FF8E0", Offset = "0x30FE4E0", VA = "0x1830FF8E0", Slot = "15")]
	public void KALEDNEOMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x39BB030", Offset = "0x39B9C30", VA = "0x1839BB030")]
	public void KJNEKOOMBGN(global::IBGINLNKKBK<AHNKBHOFMFL> LJHJJDLEMKE, in TAction KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x39BAAC0", Offset = "0x39B96C0", VA = "0x1839BAAC0", Slot = "5")]
	private void ALIFHCIANDG(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x39BABC0", Offset = "0x39B97C0", VA = "0x1839BABC0", Slot = "6")]
	private void EGHFPGFLJPF(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x363FA60", Offset = "0x363E660", VA = "0x18363FA60", Slot = "7")]
	private void FAFHMFJDLBB(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x39BAB20", Offset = "0x39B9720", VA = "0x1839BAB20", Slot = "8")]
	private void DOFBEHLBNNP(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x39BAAF0", Offset = "0x39B96F0", VA = "0x1839BAAF0", Slot = "9")]
	private global::IBGINLNKKBK<BAALOOHBPAF> CJPODHGEECC(in NEIKAPDIANF KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<BAALOOHBPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x39BB0B0", Offset = "0x39B9CB0", VA = "0x1839BB0B0", Slot = "10")]
	private bool NDKCACNFPJF(in NEIKAPDIANF KMFLGGMLFJA, global::IBGINLNKKBK<BAALOOHBPAF> ELMPCHPADPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x39BAFC0", Offset = "0x39B9BC0", VA = "0x1839BAFC0", Slot = "11")]
	private global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> KDMLJMLOCLN(global::IBGINLNKKBK<LNJBBNNHEOH> GLGEGPNMJGF, in NEIKAPDIANF KMFLGGMLFJA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BHOMHPIPDNM)
	{
		return default(global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A41030", Offset = "0x2A3FC30", VA = "0x182A41030", Slot = "12")]
	private void DIJJPGJGAKE(in global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x39BB0E0", Offset = "0x39B9CE0", VA = "0x1839BB0E0", Slot = "13")]
	private void NHGKFCCCMOD(in global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> KOKKABCBPKB, in TSyncFieldValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x39BB110", Offset = "0x39B9D10", VA = "0x1839BB110", Slot = "16")]
	private void NPPOCALDBPH(global::IBGINLNKKBK<AHNKBHOFMFL> LJHJJDLEMKE, in TAction KDJGJCHCIKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BIEBMLLGHGD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::HKMJIMJOIFA<TRpcParam> where TActionReceiver : global::EFPEKFLCOKL<TAction, Task<global::EMFHPGMFAOO<object, BMIGOOHOEBL>>> where TActionDeps : global::DGDJOLLFMAJ<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::IBGINLNKKBK<BAALOOHBPAF> MOFBMPMDIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::HJBNDEPHGEO<NCGFGLKJDKB, global::EAKBMMKMBHI<BAALOOHBPAF>> KBAIAPNFKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::CHLJDFHOPGD<BAALOOHBPAF, TSyncFieldValue>> ELCBPPEOJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::DDDKPBOPANI<BAALOOHBPAF, global::IOCJBHNBBOI<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> PLADCPAONEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps MKOHEBIEOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::IBGINLNKKBK<BAALOOHBPAF> ActorId, global::IBGINLNKKBK<AHNKBHOFMFL> RequestId, TAction Action)> KHALEMFLCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? NAJCEOHIDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? OKPCLLEGBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::IBGINLNKKBK<BAALOOHBPAF> ActorId, global::IBGINLNKKBK<AHNKBHOFMFL> RequestId, TAction Action)> HNOLKDFNCON;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::IBGINLNKKBK<BAALOOHBPAF> BEJJILCOPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040")]
		get
		{
			return default(global::IBGINLNKKBK<BAALOOHBPAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2881900", Offset = "0x2880500", VA = "0x182881900")]
	protected BIEBMLLGHGD(TActionDeps IFKAMKEANKJ, int? AKAMMNLMNAB, int? AEHOCNEAIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x287EFA0", Offset = "0x287DBA0", VA = "0x18287EFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x287FAF0", Offset = "0x287E6F0", VA = "0x18287FAF0")]
	public global::IOCJBHNBBOI<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JMNOAILMKON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2880E90", Offset = "0x287FA90", VA = "0x182880E90")]
	internal global::IBGINLNKKBK<IALNLOOMFAE> LBBLFNFOCLK(global::IBGINLNKKBK<BAALOOHBPAF> GCKPNMMCGOM)
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28816B0", Offset = "0x28802B0", VA = "0x1828816B0")]
	internal void PAHKHPEICKF(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x287FA30", Offset = "0x287E630", VA = "0x18287FA30")]
	internal global::IBGINLNKKBK<BAALOOHBPAF> GFOCHMDMHGF(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<BAALOOHBPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2881620", Offset = "0x2880220", VA = "0x182881620")]
	internal void MJPNNEBALAN(global::IBGINLNKKBK<BAALOOHBPAF> AEAIJLJDJLP, global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x287FA80", Offset = "0x287E680", VA = "0x18287FA80")]
	internal void JGEJKPOFABM(global::IBGINLNKKBK<BAALOOHBPAF> DJMNOINLALJ, global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2881190", Offset = "0x287FD90", VA = "0x182881190")]
	internal void LCGLLBIENFK(global::IBGINLNKKBK<BAALOOHBPAF> AEAIJLJDJLP, global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2881480", Offset = "0x2880080", VA = "0x182881480")]
	internal global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> MHECAFLBMAI(global::IBGINLNKKBK<BAALOOHBPAF> NNLFAGIIGNB, global::IBGINLNKKBK<LNJBBNNHEOH> GNHLNBEGIDP, string BIMCDHOFDCP, in TSyncFieldValue GKFICKKHACC, Action PKPGAEOFIGD, Action<object> FHCIEFJEFHC, Func<bool> JNDNMAIHAGE)
	{
		return default(global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x287F940", Offset = "0x287E540", VA = "0x18287F940")]
	internal void EGEDIPKCKJF(global::IBGINLNKKBK<BAALOOHBPAF> NNLFAGIIGNB, string BIMCDHOFDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x28807E0", Offset = "0x287F3E0", VA = "0x1828807E0")]
	internal void KDCDKHLGFDJ(global::CHLJDFHOPGD<BAALOOHBPAF, TSyncFieldValue> GNHLNBEGIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28807A0", Offset = "0x287F3A0", VA = "0x1828807A0")]
	internal void KALEDNEOMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2880A00", Offset = "0x287F600", VA = "0x182880A00")]
	internal void KJNEKOOMBGN(global::IBGINLNKKBK<BAALOOHBPAF> KOKPOEFBIML, global::IBGINLNKKBK<AHNKBHOFMFL> LJHJJDLEMKE, in TAction KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28813B0", Offset = "0x287FFB0", VA = "0x1828813B0")]
	[CompilerGenerated]
	private global::IOCJBHNBBOI<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> LDLMBPJBCBA(global::IBGINLNKKBK<BAALOOHBPAF> NCLPHDIGPIO)
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
