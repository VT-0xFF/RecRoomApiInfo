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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x200CB50", Offset = "0x200BF50", VA = "0x18200CB50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate ODDKBFGDCGO<TActionKind, TPayload> OPBPLFGFILI<TActionKind, TSerializedAction, TPayload>(TSerializedAction BILEGCOILLH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface KPBEDDLOGBB<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NNKIHJJJOOI<object, FAGGAEGFGFH>> BGEOPOFDMAO(TDeps GPENJAMDJGM, TRoot MILPLABKJCF, TSerializedAction BILEGCOILLH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KOGAMKGKGKB<TActionKind, TSerializedAction, TRoot, TDeps> : JNABADLMAMC where TDeps : OBGDBKNLLKJ.CNGLPAHDFPL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps FNNPADDAENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction AJCNLCCPJDP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x41AE7E0", Offset = "0x41ADBE0", VA = "0x1841AE7E0")]
	public KOGAMKGKGKB([In] TDeps GPENJAMDJGM, [In] TSerializedAction BILEGCOILLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x41AE6C0", Offset = "0x41ADAC0", VA = "0x1841AE6C0", Slot = "7")]
	public override string GBCPGMBELKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ODDKBFGDCGO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind ONEIOJIPDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload IFHNAFPHHCL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4672480", Offset = "0x4671880", VA = "0x184672480")]
	internal ODDKBFGDCGO(TActionKind EPOIJCIENBM, [In] TPayload OGPKCLEACHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KMJOKMABAOA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C29990", Offset = "0x2C28D90", VA = "0x182C29990")]
	public static ODDKBFGDCGO<TActionKind, TPayload> DDEJLDFANAB<TActionKind, TPayload>([In] TActionKind EPOIJCIENBM, [In] TPayload OGPKCLEACHE)
	{
		return default(ODDKBFGDCGO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<NNKIHJJJOOI<TOk, TErr>> OFPDCNJLLBF<TRoot, TPayload, TOk, TErr>(TRoot MILPLABKJCF, TPayload OGPKCLEACHE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate NNKIHJJJOOI<TOk, TErr> HBJLMMMKJPM<TRoot, TPayload, TOk, TErr>(TRoot MILPLABKJCF, [In] TPayload OGPKCLEACHE);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NJGPIJLJNOL<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : OBGDBKNLLKJ.CNGLPAHDFPL<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CAKMECELBLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NJGPIJLJNOL<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<NNKIHJJJOOI<object, FAGGAEGFGFH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4F3EB80", Offset = "0x4F3DF80", VA = "0x184F3EB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F000", Offset = "0x4F3E400", VA = "0x184F3F000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, KPBEDDLOGBB<TSerializedAction, TRoot, TDeps>> FCJHGIAPPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps FNNPADDAENM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB83E50", Offset = "0xB83250", VA = "0x180B83E50")]
	internal NJGPIJLJNOL(Dictionary<TActionKind, KPBEDDLOGBB<TSerializedAction, TRoot, TDeps>> OGLMHDLAKPP, TDeps GPENJAMDJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x45296F0", Offset = "0x4528AF0", VA = "0x1845296F0")]
	[AsyncStateMachine(typeof(NJGPIJLJNOL<, , , >.CAKMECELBLI))]
	public Task<NNKIHJJJOOI<object, FAGGAEGFGFH>> BGEOPOFDMAO(TRoot MILPLABKJCF, TSerializedAction BILEGCOILLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OBGDBKNLLKJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CNGLPAHDFPL<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind KNABBLFKFCE(TSerializedAction ABPJKOBADEP);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BEKJKCHJOOF(TRoot MILPLABKJCF, TSerializedAction FADGJFNLBLP);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JLAMJIKCBGC(TRoot MILPLABKJCF, TSerializedAction FADGJFNLBLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B51200", Offset = "0x2B50600", VA = "0x182B51200")]
	internal static NJGPIJLJNOL<TActionKind, TSerializedAction, TRoot, TDeps> DDEJLDFANAB<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, KPBEDDLOGBB<TSerializedAction, TRoot, TDeps>> OGLMHDLAKPP, TDeps GPENJAMDJGM) where TDeps : CNGLPAHDFPL<TActionKind, TSerializedAction, TRoot>
	{
		return default(NJGPIJLJNOL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class CGDIFBMLOGC<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, KPBEDDLOGBB<TSerializedAction, TRoot, TDeps>> FIODLNCCNML;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	private CGDIFBMLOGC(Dictionary<TActionKind, KPBEDDLOGBB<TSerializedAction, TRoot, TDeps>> OGLMHDLAKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x502C620", Offset = "0x502BA20", VA = "0x18502C620")]
	public static CGDIFBMLOGC<TActionKind, TSerializedAction, TRoot, TDeps> DDEJLDFANAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KGJMNALECGB<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, OBGDBKNLLKJ.CNGLPAHDFPL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class IJHAHMFJPGE<TPayload, TOk, TErr> : KPBEDDLOGBB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FAGGAEGFGFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OPBPLFGFILI<TActionKind, TSerializedAction, TPayload> EOJPJLBPNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly HBJLMMMKJPM<TRoot, TPayload, TOk, TErr> PLFDMHHBMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool OINAJLPOMKK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B620", Offset = "0x3D5AA20", VA = "0x183D5B620")]
		public IJHAHMFJPGE(OPBPLFGFILI<TActionKind, TSerializedAction, TPayload> LGBOGJFDMLE, HBJLMMMKJPM<TRoot, TPayload, TOk, TErr> KCIBHJEDOHM, bool IAFKCDMIDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E65A40", Offset = "0x3E64E40", VA = "0x183E65A40", Slot = "4")]
		public Task<NNKIHJJJOOI<object, FAGGAEGFGFH>> BGEOPOFDMAO(TDeps GPENJAMDJGM, TRoot MILPLABKJCF, TSerializedAction BILEGCOILLH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HHNMGLPPGAL<TPayload, TOk, TErr> : KPBEDDLOGBB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FAGGAEGFGFH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct LEHMMKIFAGO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<NNKIHJJJOOI<object?, FAGGAEGFGFH>> <>t__builder;

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
			public HHNMGLPPGAL<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private NNKIHJJJOOI<object?, FAGGAEGFGFH> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<NNKIHJJJOOI<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x422FA20", Offset = "0x422EE20", VA = "0x18422FA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x42300A0", Offset = "0x422F4A0", VA = "0x1842300A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OPBPLFGFILI<TActionKind, TSerializedAction, TPayload> EOJPJLBPNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly OFPDCNJLLBF<TRoot, TPayload, TOk, TErr> PLFDMHHBMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool OINAJLPOMKK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B620", Offset = "0x3D5AA20", VA = "0x183D5B620")]
		public HHNMGLPPGAL(OPBPLFGFILI<TActionKind, TSerializedAction, TPayload> LGBOGJFDMLE, OFPDCNJLLBF<TRoot, TPayload, TOk, TErr> KCIBHJEDOHM, bool IAFKCDMIDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B380", Offset = "0x3D5A780", VA = "0x183D5B380", Slot = "4")]
		[AsyncStateMachine(typeof(HHNMGLPPGAL<, , >.LEHMMKIFAGO))]
		public Task<NNKIHJJJOOI<object, FAGGAEGFGFH>> BGEOPOFDMAO(TDeps GPENJAMDJGM, TRoot MILPLABKJCF, TSerializedAction BILEGCOILLH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CGDIFBMLOGC<TActionKind, TSerializedAction, TRoot, TDeps> BFJEEJKDNCL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	private KGJMNALECGB(CGDIFBMLOGC<TActionKind, TSerializedAction, TRoot, TDeps> LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x41834C0", Offset = "0x41828C0", VA = "0x1841834C0")]
	public static KGJMNALECGB<TActionKind, TSerializedAction, TRoot, TDeps> DDEJLDFANAB()
	{
		return default(KGJMNALECGB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2ABB480", Offset = "0x2ABA880", VA = "0x182ABB480")]
	public KGJMNALECGB<TActionKind, TSerializedAction, TRoot, TDeps> JFAPJKFBKPG<TPayload, TOk, TErr>(TActionKind EPOIJCIENBM, OPBPLFGFILI<TActionKind, TSerializedAction, TPayload> LGBOGJFDMLE, HBJLMMMKJPM<TRoot, TPayload, TOk, TErr> KCIBHJEDOHM, bool IAFKCDMIDMN = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FAGGAEGFGFH
	{
		return default(KGJMNALECGB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2ABB480", Offset = "0x2ABA880", VA = "0x182ABB480")]
	public KGJMNALECGB<TActionKind, TSerializedAction, TRoot, TDeps> JLIPKCNMIKG<TPayload, TOk, TErr>(TActionKind EPOIJCIENBM, OPBPLFGFILI<TActionKind, TSerializedAction, TPayload> LGBOGJFDMLE, OFPDCNJLLBF<TRoot, TPayload, TOk, TErr> KCIBHJEDOHM, bool IAFKCDMIDMN = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FAGGAEGFGFH
	{
		return default(KGJMNALECGB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4183560", Offset = "0x4182960", VA = "0x184183560")]
	public NJGPIJLJNOL<TActionKind, TSerializedAction, TRoot, TDeps> DKMKGDDFHGG(TDeps GPENJAMDJGM)
	{
		return default(NJGPIJLJNOL<TActionKind, TSerializedAction, TRoot, TDeps>);
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
