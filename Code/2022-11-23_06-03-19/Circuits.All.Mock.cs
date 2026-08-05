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
			[Cpp2IlInjected.Address(RVA = "0x24E8DE0", Offset = "0x24E7BE0", VA = "0x1824E8DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public PAKGEJDFGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3064750", Offset = "0x3063550", VA = "0x183064750")]
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
		[Cpp2IlInjected.Address(RVA = "0x259B220", Offset = "0x259A020", VA = "0x18259B220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::IBGINLNKKBK<BAALOOHBPAF> LEJJINNGNID
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x259B690", Offset = "0x259A490", VA = "0x18259B690")]
		get
		{
			return default(global::IBGINLNKKBK<BAALOOHBPAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x259BC30", Offset = "0x259AA30", VA = "0x18259BC30")]
	private IOCJBHNBBOI(global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HKPDNJBMEMK, global::DMKBBMIKBGL<NEIKAPDIANF, global::IBGINLNKKBK<BAALOOHBPAF>, TRpcParam, TRpcReceiver, global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CABJKGENCLP, global::AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JHGHFKCDGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x259B290", Offset = "0x259A090", VA = "0x18259B290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x259B7E0", Offset = "0x259A5E0", VA = "0x18259B7E0")]
	internal static global::IOCJBHNBBOI<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KCNAIILPDFM(global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HKPDNJBMEMK, global::DMKBBMIKBGL<NEIKAPDIANF, global::IBGINLNKKBK<BAALOOHBPAF>, TRpcParam, TRpcReceiver, global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CABJKGENCLP, global::AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JHGHFKCDGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x259BB50", Offset = "0x259A950", VA = "0x18259BB50")]
	public global::IBGINLNKKBK<IALNLOOMFAE> LBBLFNFOCLK()
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x259B2C0", Offset = "0x259A0C0", VA = "0x18259B2C0")]
	internal global::IBGINLNKKBK<IALNLOOMFAE> EKCKIKPLPBI(global::IBGINLNKKBK<NCGFGLKJDKB> GLGEGPNMJGF, in NEIKAPDIANF KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x259BB80", Offset = "0x259A980", VA = "0x18259BB80")]
	internal void OKEJJBDBGLM(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x259B3D0", Offset = "0x259A1D0", VA = "0x18259B3D0")]
	internal void EPIFJIOCMGO(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x259B1C0", Offset = "0x2599FC0", VA = "0x18259B1C0")]
	internal void DIJOPBHHGCK(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x259B5F0", Offset = "0x259A3F0", VA = "0x18259B5F0")]
	internal void HFHJJKGPCHB(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x259B8C0", Offset = "0x259A6C0", VA = "0x18259B8C0")]
	internal void KDCDKHLGFDJ(global::IBGINLNKKBK<LNJBBNNHEOH> GNHLNBEGIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x259B780", Offset = "0x259A580", VA = "0x18259B780")]
	public global::IBGINLNKKBK<IALNLOOMFAE> JPIFGLALGBA(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x259B130", Offset = "0x2599F30", VA = "0x18259B130")]
	public void AHIKNEGPDDH(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x259B6F0", Offset = "0x259A4F0", VA = "0x18259B6F0")]
	public void ICMNBPGKGLH(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x259B750", Offset = "0x259A550", VA = "0x18259B750")]
	public void JEGIICGBCBE(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x259BC00", Offset = "0x259AA00", VA = "0x18259BC00")]
	public void PHLLACMJJCG(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x259B160", Offset = "0x2599F60", VA = "0x18259B160")]
	public void CGJNEMMCPPL(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in TRpcReceiver OIJGODEOMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x259B5C0", Offset = "0x259A3C0", VA = "0x18259B5C0")]
	public global::IBGINLNKKBK<BAALOOHBPAF> GFOCHMDMHGF(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<BAALOOHBPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x259B390", Offset = "0x259A190", VA = "0x18259B390")]
	public bool EMELPOEBKLC(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, global::IBGINLNKKBK<BAALOOHBPAF> ELMPCHPADPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x259B360", Offset = "0x259A160", VA = "0x18259B360")]
	public global::IBGINLNKKBK<LNJBBNNHEOH> EKMGLAJJJAG(global::IBGINLNKKBK<IALNLOOMFAE> KMFLGGMLFJA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BHOMHPIPDNM)
	{
		return default(global::IBGINLNKKBK<LNJBBNNHEOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x259B720", Offset = "0x259A520", VA = "0x18259B720")]
	public void INBNMKLOHEK(global::IBGINLNKKBK<LNJBBNNHEOH> KOKKABCBPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x259B6C0", Offset = "0x259A4C0", VA = "0x18259B6C0")]
	public void IBNADGHDDNO(global::IBGINLNKKBK<LNJBBNNHEOH> KOKKABCBPKB, in TSyncFieldValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x259B980", Offset = "0x259A780", VA = "0x18259B980")]
	public Task<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> KJNEKOOMBGN(in TAction KDJGJCHCIKK, bool KICHIDDLKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x259B190", Offset = "0x2599F90", VA = "0x18259B190")]
	public void CKFFNBPFDNB(in TActionReceiver ELHGAKMGENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x259B430", Offset = "0x259A230", VA = "0x18259B430")]
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
		[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970", Slot = "4")]
		get
		{
			return default(global::IBGINLNKKBK<BAALOOHBPAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::IBGINLNKKBK<BAALOOHBPAF> ENMPOMDJDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970", Slot = "14")]
		get
		{
			return default(global::IBGINLNKKBK<BAALOOHBPAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x413E320", Offset = "0x413D120", VA = "0x18413E320")]
	private CBHHOOAKLBK(global::BIEBMLLGHGD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KMCOGBENCBH, global::IBGINLNKKBK<BAALOOHBPAF> GLGEGPNMJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x413E080", Offset = "0x413CE80", VA = "0x18413E080")]
	public static global::CBHHOOAKLBK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KCNAIILPDFM(global::IBGINLNKKBK<BAALOOHBPAF> GLGEGPNMJGF, global::BIEBMLLGHGD<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KMCOGBENCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x413E200", Offset = "0x413D000", VA = "0x18413E200")]
	public global::IBGINLNKKBK<IALNLOOMFAE> LBBLFNFOCLK()
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x413DC10", Offset = "0x413CA10", VA = "0x18413DC10")]
	public void AHIKNEGPDDH(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x413DF20", Offset = "0x413CD20", VA = "0x18413DF20")]
	public void ICMNBPGKGLH(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x413E000", Offset = "0x413CE00", VA = "0x18413E000")]
	public void JEGIICGBCBE(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x413E2A0", Offset = "0x413D0A0", VA = "0x18413E2A0")]
	public void PHLLACMJJCG(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x413DEE0", Offset = "0x413CCE0", VA = "0x18413DEE0")]
	public global::IBGINLNKKBK<BAALOOHBPAF> GFOCHMDMHGF(in NEIKAPDIANF KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<BAALOOHBPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x413DE50", Offset = "0x413CC50", VA = "0x18413DE50")]
	public bool EMELPOEBKLC(in NEIKAPDIANF KMFLGGMLFJA, global::IBGINLNKKBK<BAALOOHBPAF> ELMPCHPADPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x413DD80", Offset = "0x413CB80", VA = "0x18413DD80")]
	public global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> EKMGLAJJJAG(global::IBGINLNKKBK<LNJBBNNHEOH> GNHLNBEGIDP, in NEIKAPDIANF KBICBGPAOHG, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BHOMHPIPDNM)
	{
		return default(global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x413DFA0", Offset = "0x413CDA0", VA = "0x18413DFA0")]
	public void INBNMKLOHEK(in global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x413DCE0", Offset = "0x413CAE0", VA = "0x18413DCE0")]
	public void EGDHJAFLBJF(in global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> KOKKABCBPKB, in TSyncFieldValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x315D1F0", Offset = "0x315BFF0", VA = "0x18315D1F0", Slot = "15")]
	public void KALEDNEOMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x413E1C0", Offset = "0x413CFC0", VA = "0x18413E1C0")]
	public void KJNEKOOMBGN(global::IBGINLNKKBK<AHNKBHOFMFL> LJHJJDLEMKE, in TAction KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x413DC50", Offset = "0x413CA50", VA = "0x18413DC50", Slot = "5")]
	private void ALIFHCIANDG(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x413DD50", Offset = "0x413CB50", VA = "0x18413DD50", Slot = "6")]
	private void EGHFPGFLJPF(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x39C34F0", Offset = "0x39C22F0", VA = "0x1839C34F0", Slot = "7")]
	private void FAFHMFJDLBB(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x413DCB0", Offset = "0x413CAB0", VA = "0x18413DCB0", Slot = "8")]
	private void DOFBEHLBNNP(in NEIKAPDIANF KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x413DC80", Offset = "0x413CA80", VA = "0x18413DC80", Slot = "9")]
	private global::IBGINLNKKBK<BAALOOHBPAF> CJPODHGEECC(in NEIKAPDIANF KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<BAALOOHBPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x413E240", Offset = "0x413D040", VA = "0x18413E240", Slot = "10")]
	private bool NDKCACNFPJF(in NEIKAPDIANF KMFLGGMLFJA, global::IBGINLNKKBK<BAALOOHBPAF> ELMPCHPADPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x413E150", Offset = "0x413CF50", VA = "0x18413E150", Slot = "11")]
	private global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> KDMLJMLOCLN(global::IBGINLNKKBK<LNJBBNNHEOH> GLGEGPNMJGF, in NEIKAPDIANF KMFLGGMLFJA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) BHOMHPIPDNM)
	{
		return default(global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2F44020", Offset = "0x2F42E20", VA = "0x182F44020", Slot = "12")]
	private void DIJJPGJGAKE(in global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x413E270", Offset = "0x413D070", VA = "0x18413E270", Slot = "13")]
	private void NHGKFCCCMOD(in global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> KOKKABCBPKB, in TSyncFieldValue GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x334DBE0", Offset = "0x334C9E0", VA = "0x18334DBE0", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0")]
		get
		{
			return default(global::IBGINLNKKBK<BAALOOHBPAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D112D0", Offset = "0x2D100D0", VA = "0x182D112D0")]
	protected BIEBMLLGHGD(TActionDeps IFKAMKEANKJ, int? AKAMMNLMNAB, int? AEHOCNEAIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E970", Offset = "0x2D0D770", VA = "0x182D0E970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F4C0", Offset = "0x2D0E2C0", VA = "0x182D0F4C0")]
	public global::IOCJBHNBBOI<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JMNOAILMKON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2D10860", Offset = "0x2D0F660", VA = "0x182D10860")]
	internal global::IBGINLNKKBK<IALNLOOMFAE> LBBLFNFOCLK(global::IBGINLNKKBK<BAALOOHBPAF> GCKPNMMCGOM)
	{
		return default(global::IBGINLNKKBK<IALNLOOMFAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D11080", Offset = "0x2D0FE80", VA = "0x182D11080")]
	internal void PAHKHPEICKF(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F400", Offset = "0x2D0E200", VA = "0x182D0F400")]
	internal global::IBGINLNKKBK<BAALOOHBPAF> GFOCHMDMHGF(global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA)
	{
		return default(global::IBGINLNKKBK<BAALOOHBPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D10FF0", Offset = "0x2D0FDF0", VA = "0x182D10FF0")]
	internal void MJPNNEBALAN(global::IBGINLNKKBK<BAALOOHBPAF> AEAIJLJDJLP, global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F450", Offset = "0x2D0E250", VA = "0x182D0F450")]
	internal void JGEJKPOFABM(global::IBGINLNKKBK<BAALOOHBPAF> DJMNOINLALJ, global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D10B60", Offset = "0x2D0F960", VA = "0x182D10B60")]
	internal void LCGLLBIENFK(global::IBGINLNKKBK<BAALOOHBPAF> AEAIJLJDJLP, global::IBGINLNKKBK<NCGFGLKJDKB> KMFLGGMLFJA, in TRpcParam BHOMHPIPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D10E50", Offset = "0x2D0FC50", VA = "0x182D10E50")]
	internal global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue> MHECAFLBMAI(global::IBGINLNKKBK<BAALOOHBPAF> NNLFAGIIGNB, global::IBGINLNKKBK<LNJBBNNHEOH> GNHLNBEGIDP, string BIMCDHOFDCP, in TSyncFieldValue GKFICKKHACC, Action PKPGAEOFIGD, Action<object> FHCIEFJEFHC, Func<bool> JNDNMAIHAGE)
	{
		return default(global::HFNMNBALIAD<BAALOOHBPAF, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F310", Offset = "0x2D0E110", VA = "0x182D0F310")]
	internal void EGEDIPKCKJF(global::IBGINLNKKBK<BAALOOHBPAF> NNLFAGIIGNB, string BIMCDHOFDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D101B0", Offset = "0x2D0EFB0", VA = "0x182D101B0")]
	internal void KDCDKHLGFDJ(global::CHLJDFHOPGD<BAALOOHBPAF, TSyncFieldValue> GNHLNBEGIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D10170", Offset = "0x2D0EF70", VA = "0x182D10170")]
	internal void KALEDNEOMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D103D0", Offset = "0x2D0F1D0", VA = "0x182D103D0")]
	internal void KJNEKOOMBGN(global::IBGINLNKKBK<BAALOOHBPAF> KOKPOEFBIML, global::IBGINLNKKBK<AHNKBHOFMFL> LJHJJDLEMKE, in TAction KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2D10D80", Offset = "0x2D0FB80", VA = "0x182D10D80")]
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
