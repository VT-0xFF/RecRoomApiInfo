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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x25AB9B0", Offset = "0x25A9FB0", VA = "0x1825AB9B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate FAGPPDKBBNO<TActionKind, TPayload> PHGINOJMBNM<TActionKind, TSerializedAction, TPayload>(TSerializedAction PMKDFNINDPP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface EIFECJLHCKL<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IAKLNGNNDFI(TDeps GKFDJGEMKAB, TRoot JGHOOBNHEJB, TSerializedAction PMKDFNINDPP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class ANPAFHJOLKP<TActionKind, TSerializedAction, TRoot, TDeps> : MPAEBDCEOBD where TDeps : NOEGOOCAILH.NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps JDFKOKOAHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction LBKIJMMADHD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4993F20", Offset = "0x4992520", VA = "0x184993F20")]
	public ANPAFHJOLKP([In] TDeps GKFDJGEMKAB, [In] TSerializedAction PMKDFNINDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4993E00", Offset = "0x4992400", VA = "0x184993E00", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FAGPPDKBBNO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind POHGDLLAMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload HBBGBNNJCHH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x440A170", Offset = "0x4408770", VA = "0x18440A170")]
	internal FAGPPDKBBNO(TActionKind LCLDCHNIOPM, [In] TPayload GOAPBALNOKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MKMEHDIIMFN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3519700", Offset = "0x3517D00", VA = "0x183519700")]
	public static FAGPPDKBBNO<TActionKind, TPayload> FEOBEKOIKMG<TActionKind, TPayload>([In] TActionKind LCLDCHNIOPM, [In] TPayload GOAPBALNOKD)
	{
		return default(FAGPPDKBBNO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<JOFBNNGKBOO<TOk, TErr>> DHPDIFBEPOA<TRoot, TPayload, TOk, TErr>(TRoot JGHOOBNHEJB, TPayload GOAPBALNOKD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate JOFBNNGKBOO<TOk, TErr> CJDCNLPPIIL<TRoot, TPayload, TOk, TErr>(TRoot JGHOOBNHEJB, [In] TPayload GOAPBALNOKD);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : NOEGOOCAILH.NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EOHLNHBKJGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4076F00", Offset = "0x4075500", VA = "0x184076F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4077380", Offset = "0x4075980", VA = "0x184077380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> FHLPBIGELML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps JDFKOKOAHAA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
	internal NKBPINFEMPK(Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> PDKBPOECKEG, TDeps GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB6E0", Offset = "0x4ED9CE0", VA = "0x184EDB6E0")]
	[AsyncStateMachine(typeof(NKBPINFEMPK<, , , >.EOHLNHBKJGC))]
	public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IAKLNGNNDFI(TRoot JGHOOBNHEJB, TSerializedAction PMKDFNINDPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NOEGOOCAILH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind ECMMNNHBDPD(TSerializedAction JDCFMPOHCEA);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NFOKJFBPIHF(TRoot JGHOOBNHEJB, TSerializedAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KFCGHNNPOPA(TRoot JGHOOBNHEJB, TSerializedAction PJDAFKMDDCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x34B9950", Offset = "0x34B7F50", VA = "0x1834B9950")]
	internal static NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps> FEOBEKOIKMG<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> PDKBPOECKEG, TDeps GKFDJGEMKAB) where TDeps : NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
	{
		return default(NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DHJBGGOPKLA<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> BCENBNFJLKH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	private DHJBGGOPKLA(Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> PDKBPOECKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6310490", Offset = "0x630EA90", VA = "0x186310490")]
	public static DHJBGGOPKLA<TActionKind, TSerializedAction, TRoot, TDeps> FEOBEKOIKMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, NOEGOOCAILH.NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class GOJFKHHPLJE<TPayload, TOk, TErr> : EIFECJLHCKL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, PPAGHPBHFJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CEJCOHLIKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CJDCNLPPIIL<TRoot, TPayload, TOk, TErr> FKJLFCNBFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool NOIPDGIKDLE;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4570AB0", Offset = "0x456F0B0", VA = "0x184570AB0")]
		public GOJFKHHPLJE(PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CPGEKIIILGL, CJDCNLPPIIL<TRoot, TPayload, TOk, TErr> FNOCJCOOMEG, bool PDGKKPABECG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4570390", Offset = "0x456E990", VA = "0x184570390", Slot = "4")]
		public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IAKLNGNNDFI(TDeps GKFDJGEMKAB, TRoot JGHOOBNHEJB, TSerializedAction PMKDFNINDPP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class OLBHBPGEHCJ<TPayload, TOk, TErr> : EIFECJLHCKL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, PPAGHPBHFJD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct AFKAHFHAHNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>t__builder;

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
			public OLBHBPGEHCJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private JOFBNNGKBOO<object?, PPAGHPBHFJD> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<JOFBNNGKBOO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x47D1970", Offset = "0x47CFF70", VA = "0x1847D1970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x47D2340", Offset = "0x47D0940", VA = "0x1847D2340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CEJCOHLIKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly DHPDIFBEPOA<TRoot, TPayload, TOk, TErr> FKJLFCNBFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool NOIPDGIKDLE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4570AB0", Offset = "0x456F0B0", VA = "0x184570AB0")]
		public OLBHBPGEHCJ(PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CPGEKIIILGL, DHPDIFBEPOA<TRoot, TPayload, TOk, TErr> FNOCJCOOMEG, bool PDGKKPABECG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x501E6E0", Offset = "0x501CCE0", VA = "0x18501E6E0", Slot = "4")]
		[AsyncStateMachine(typeof(OLBHBPGEHCJ<, , >.AFKAHFHAHNL))]
		public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IAKLNGNNDFI(TDeps GKFDJGEMKAB, TRoot JGHOOBNHEJB, TSerializedAction PMKDFNINDPP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DHJBGGOPKLA<TActionKind, TSerializedAction, TRoot, TDeps> NGLBBEFFGIM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	private HMHNOMGHDBI(DHJBGGOPKLA<TActionKind, TSerializedAction, TRoot, TDeps> GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4699FF0", Offset = "0x46985F0", VA = "0x184699FF0")]
	public static HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps> FEOBEKOIKMG()
	{
		return default(HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x358C620", Offset = "0x358AC20", VA = "0x18358C620")]
	public HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps> ANDDNGMAEGK<TPayload, TOk, TErr>(TActionKind LCLDCHNIOPM, PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CPGEKIIILGL, CJDCNLPPIIL<TRoot, TPayload, TOk, TErr> FNOCJCOOMEG, bool PDGKKPABECG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, PPAGHPBHFJD
	{
		return default(HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x358C620", Offset = "0x358AC20", VA = "0x18358C620")]
	public HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps> LDFLMAEJFBE<TPayload, TOk, TErr>(TActionKind LCLDCHNIOPM, PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CPGEKIIILGL, DHPDIFBEPOA<TRoot, TPayload, TOk, TErr> FNOCJCOOMEG, bool PDGKKPABECG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, PPAGHPBHFJD
	{
		return default(HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4699F30", Offset = "0x4698530", VA = "0x184699F30")]
	public NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps> BMHADMIFCBL(TDeps GKFDJGEMKAB)
	{
		return default(NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps>);
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
