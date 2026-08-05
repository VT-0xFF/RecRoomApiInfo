using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x25E0610", Offset = "0x25DF810", VA = "0x1825E0610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate JMKMBBDBNLG<TActionKind, TPayload> AJJPNCMLCJM<TActionKind, TSerializedAction, TPayload>(TSerializedAction NGMNNIEADLB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface BGHNHCGGHEC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CPEANPEHCAG<object, BBIMJBGJONM>> LFNDIMDDPIK(TDeps LAJMFENCBAB, TRoot BFPPPKIAFBG, TSerializedAction NGMNNIEADLB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PKABGLADMGP<TActionKind, TSerializedAction, TRoot, TDeps> : JMDJCEHKLNJ where TDeps : CPKBOKOBJLD.NLONICBLHMA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps PHEPOEOOCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction JMMHDGPIANB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x512FD20", Offset = "0x512EF20", VA = "0x18512FD20")]
	public PKABGLADMGP([In] TDeps LAJMFENCBAB, [In] TSerializedAction NGMNNIEADLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x512FB60", Offset = "0x512ED60", VA = "0x18512FB60", Slot = "7")]
	public override string JBKGPNGEPEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JMKMBBDBNLG<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BACBKCPBPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload CEAJIPCKDPD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x498DBF0", Offset = "0x498CDF0", VA = "0x18498DBF0")]
	internal JMKMBBDBNLG(TActionKind NEHMKBPKPDO, [In] TPayload FKKLLADNDBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FNCMPLCBMGK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x347E360", Offset = "0x347D560", VA = "0x18347E360")]
	public static JMKMBBDBNLG<TActionKind, TPayload> PEFMILKIAFF<TActionKind, TPayload>([In] TActionKind NEHMKBPKPDO, [In] TPayload FKKLLADNDBA)
	{
		return default(JMKMBBDBNLG<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<CPEANPEHCAG<TOk, TErr>> FIDFIDEFADK<TRoot, TPayload, TOk, TErr>(TRoot BFPPPKIAFBG, TPayload FKKLLADNDBA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate CPEANPEHCAG<TOk, TErr> CIEOHMHJLBK<TRoot, TPayload, TOk, TErr>(TRoot BFPPPKIAFBG, [In] TPayload FKKLLADNDBA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct OGPPBNCEAKF<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : CPKBOKOBJLD.NLONICBLHMA<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LMNMCPFANCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<object?, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public OGPPBNCEAKF<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<CPEANPEHCAG<object, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4B8AA30", Offset = "0x4B89C30", VA = "0x184B8AA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4B8AEC0", Offset = "0x4B8A0C0", VA = "0x184B8AEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, BGHNHCGGHEC<TSerializedAction, TRoot, TDeps>> DGPOJIOEGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps PHEPOEOOCBF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
	internal OGPPBNCEAKF(Dictionary<TActionKind, BGHNHCGGHEC<TSerializedAction, TRoot, TDeps>> KFPMJCENFEA, TDeps LAJMFENCBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5001980", Offset = "0x5000B80", VA = "0x185001980")]
	[AsyncStateMachine(typeof(OGPPBNCEAKF<, , , >.LMNMCPFANCH))]
	public Task<CPEANPEHCAG<object, BBIMJBGJONM>> LFNDIMDDPIK(TRoot BFPPPKIAFBG, TSerializedAction NGMNNIEADLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CPKBOKOBJLD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NLONICBLHMA<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind EIKNCDEBCDM(TSerializedAction NAELBAPCKEH);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MIHAHJEJFNC(TRoot BFPPPKIAFBG, TSerializedAction GJDAMJHNAPC);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JHAAFDGJDOL(TRoot BFPPPKIAFBG, TSerializedAction GJDAMJHNAPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x328BA40", Offset = "0x328AC40", VA = "0x18328BA40")]
	internal static OGPPBNCEAKF<TActionKind, TSerializedAction, TRoot, TDeps> PEFMILKIAFF<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, BGHNHCGGHEC<TSerializedAction, TRoot, TDeps>> KFPMJCENFEA, TDeps LAJMFENCBAB) where TDeps : NLONICBLHMA<TActionKind, TSerializedAction, TRoot>
	{
		return default(OGPPBNCEAKF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NLNEGIBNGLE<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, BGHNHCGGHEC<TSerializedAction, TRoot, TDeps>> HFIPMHFPDJM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	private NLNEGIBNGLE(Dictionary<TActionKind, BGHNHCGGHEC<TSerializedAction, TRoot, TDeps>> KFPMJCENFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E43170", Offset = "0x4E42370", VA = "0x184E43170")]
	public static NLNEGIBNGLE<TActionKind, TSerializedAction, TRoot, TDeps> PEFMILKIAFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GNAFELAGLIM<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, CPKBOKOBJLD.NLONICBLHMA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LGJMKNHOKFG<TPayload, TOk, TErr> : BGHNHCGGHEC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BBIMJBGJONM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AJJPNCMLCJM<TActionKind, TSerializedAction, TPayload> MKNCJEOPADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CIEOHMHJLBK<TRoot, TPayload, TOk, TErr> GCKBGCDJEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool NFALJKOMNFK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4B59B70", Offset = "0x4B58D70", VA = "0x184B59B70")]
		public LGJMKNHOKFG(AJJPNCMLCJM<TActionKind, TSerializedAction, TPayload> JBPOCGCIBCC, CIEOHMHJLBK<TRoot, TPayload, TOk, TErr> CNDGPOLPBKF, bool BILGHNHMCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4B51950", Offset = "0x4B50B50", VA = "0x184B51950", Slot = "4")]
		public Task<CPEANPEHCAG<object, BBIMJBGJONM>> LFNDIMDDPIK(TDeps LAJMFENCBAB, TRoot BFPPPKIAFBG, TSerializedAction NGMNNIEADLB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class DEIAEHJGAMH<TPayload, TOk, TErr> : BGHNHCGGHEC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BBIMJBGJONM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct LEEKGGIOAAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<CPEANPEHCAG<object?, BBIMJBGJONM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public DEIAEHJGAMH<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private CPEANPEHCAG<object?, BBIMJBGJONM> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CPEANPEHCAG<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4B39800", Offset = "0x4B38A00", VA = "0x184B39800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4B3A780", Offset = "0x4B39980", VA = "0x184B3A780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AJJPNCMLCJM<TActionKind, TSerializedAction, TPayload> MKNCJEOPADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly FIDFIDEFADK<TRoot, TPayload, TOk, TErr> GCKBGCDJEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool NFALJKOMNFK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4B59B70", Offset = "0x4B58D70", VA = "0x184B59B70")]
		public DEIAEHJGAMH(AJJPNCMLCJM<TActionKind, TSerializedAction, TPayload> JBPOCGCIBCC, FIDFIDEFADK<TRoot, TPayload, TOk, TErr> CNDGPOLPBKF, bool BILGHNHMCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6385C10", Offset = "0x6384E10", VA = "0x186385C10", Slot = "4")]
		[AsyncStateMachine(typeof(DEIAEHJGAMH<, , >.LEEKGGIOAAI))]
		public Task<CPEANPEHCAG<object, BBIMJBGJONM>> LFNDIMDDPIK(TDeps LAJMFENCBAB, TRoot BFPPPKIAFBG, TSerializedAction NGMNNIEADLB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NLNEGIBNGLE<TActionKind, TSerializedAction, TRoot, TDeps> LHJMAMJHDLK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	private GNAFELAGLIM(NLNEGIBNGLE<TActionKind, TSerializedAction, TRoot, TDeps> LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x461F560", Offset = "0x461E760", VA = "0x18461F560")]
	public static GNAFELAGLIM<TActionKind, TSerializedAction, TRoot, TDeps> PEFMILKIAFF()
	{
		return default(GNAFELAGLIM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x36D2F90", Offset = "0x36D2190", VA = "0x1836D2F90")]
	public GNAFELAGLIM<TActionKind, TSerializedAction, TRoot, TDeps> GOOPIAJANIA<TPayload, TOk, TErr>(TActionKind NEHMKBPKPDO, AJJPNCMLCJM<TActionKind, TSerializedAction, TPayload> JBPOCGCIBCC, CIEOHMHJLBK<TRoot, TPayload, TOk, TErr> CNDGPOLPBKF, bool BILGHNHMCFI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BBIMJBGJONM
	{
		return default(GNAFELAGLIM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x36D2F90", Offset = "0x36D2190", VA = "0x1836D2F90")]
	public GNAFELAGLIM<TActionKind, TSerializedAction, TRoot, TDeps> KKBIDPOEMAO<TPayload, TOk, TErr>(TActionKind NEHMKBPKPDO, AJJPNCMLCJM<TActionKind, TSerializedAction, TPayload> JBPOCGCIBCC, FIDFIDEFADK<TRoot, TPayload, TOk, TErr> CNDGPOLPBKF, bool BILGHNHMCFI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BBIMJBGJONM
	{
		return default(GNAFELAGLIM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x461F4A0", Offset = "0x461E6A0", VA = "0x18461F4A0")]
	public OGPPBNCEAKF<TActionKind, TSerializedAction, TRoot, TDeps> LEJEEGJNHCN(TDeps LAJMFENCBAB)
	{
		return default(OGPPBNCEAKF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
namespace Cpp2IlInjected
{
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
}
