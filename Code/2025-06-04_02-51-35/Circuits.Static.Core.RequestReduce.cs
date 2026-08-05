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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28A6970", Offset = "0x28A5170", VA = "0x1828A6970")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate IIHKIPKHHOH<TActionKind, TPayload> DCKEGAEAMPI<TActionKind, TSerializedAction, TPayload>(TSerializedAction IEAJKOMIAMP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface CDBEJFDHGFF<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AOGODOAGAAO<object, DLBBNMCGCPF>> IKMIEIAGBNM(TDeps GGLINDGLEPB, TRoot MJAMEBJFAIN, TSerializedAction IEAJKOMIAMP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class MHGJKDMGIJN<TActionKind, TSerializedAction, TRoot, TDeps> : CNLJJPMFMBN where TDeps : EGKJPHCNJEL.BNJPLLOIJEN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps OFNAGCEIFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction KKEDIGFCHNB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5540FC0", Offset = "0x553F7C0", VA = "0x185540FC0")]
	public MHGJKDMGIJN([In] TDeps GGLINDGLEPB, [In] TSerializedAction IEAJKOMIAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5540EF0", Offset = "0x553F6F0", VA = "0x185540EF0", Slot = "7")]
	public override string JKBFHJHLJNK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct IIHKIPKHHOH<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind FGANAIEDPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload EOPDIKEPJGJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BAB0", Offset = "0x4E7A2B0", VA = "0x184E7BAB0")]
	internal IIHKIPKHHOH(TActionKind MEKIDAHGLGG, [In] TPayload OILJBDLKBKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OIOGCKMPEOG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3B7F3E0", Offset = "0x3B7DBE0", VA = "0x183B7F3E0")]
	public static IIHKIPKHHOH<TActionKind, TPayload> CCPKJDCALBG<TActionKind, TPayload>([In] TActionKind MEKIDAHGLGG, [In] TPayload OILJBDLKBKC)
	{
		return default(IIHKIPKHHOH<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<AOGODOAGAAO<TOk, TErr>> DFALIOKEGFM<TRoot, TPayload, TOk, TErr>(TRoot MJAMEBJFAIN, TPayload OILJBDLKBKC);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate AOGODOAGAAO<TOk, TErr> EAOKEGABKKC<TRoot, TPayload, TOk, TErr>(TRoot MJAMEBJFAIN, [In] TPayload OILJBDLKBKC);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PEDNMPNIDMI<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : EGKJPHCNJEL.BNJPLLOIJEN<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JCGIIPBHJHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<object?, DLBBNMCGCPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PEDNMPNIDMI<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<AOGODOAGAAO<object, DLBBNMCGCPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x50A71B0", Offset = "0x50A59B0", VA = "0x1850A71B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50A7AF0", Offset = "0x50A62F0", VA = "0x1850A7AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, CDBEJFDHGFF<TSerializedAction, TRoot, TDeps>> GKCPHPJNGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps OFNAGCEIFKB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
	internal PEDNMPNIDMI(Dictionary<TActionKind, CDBEJFDHGFF<TSerializedAction, TRoot, TDeps>> FHGMMGJEADJ, TDeps GGLINDGLEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x582F870", Offset = "0x582E070", VA = "0x18582F870")]
	[AsyncStateMachine(typeof(PEDNMPNIDMI<, , , >.JCGIIPBHJHH))]
	public Task<AOGODOAGAAO<object, DLBBNMCGCPF>> IKMIEIAGBNM(TRoot MJAMEBJFAIN, TSerializedAction IEAJKOMIAMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EGKJPHCNJEL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface BNJPLLOIJEN<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind EMAPOMMMKFN(TSerializedAction DKBBJFIDEGB);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HGEMNAEHHGB(TRoot MJAMEBJFAIN, TSerializedAction AMNCPNDDCLP);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CLKGICFBDBP(TRoot MJAMEBJFAIN, TSerializedAction AMNCPNDDCLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37F6F10", Offset = "0x37F5710", VA = "0x1837F6F10")]
	internal static PEDNMPNIDMI<TActionKind, TSerializedAction, TRoot, TDeps> CCPKJDCALBG<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, CDBEJFDHGFF<TSerializedAction, TRoot, TDeps>> FHGMMGJEADJ, TDeps GGLINDGLEPB) where TDeps : BNJPLLOIJEN<TActionKind, TSerializedAction, TRoot>
	{
		return default(PEDNMPNIDMI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HOMLGEHHBHE<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, CDBEJFDHGFF<TSerializedAction, TRoot, TDeps>> HNEABDCEFCA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	private HOMLGEHHBHE(Dictionary<TActionKind, CDBEJFDHGFF<TSerializedAction, TRoot, TDeps>> FHGMMGJEADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D32200", Offset = "0x4D30A00", VA = "0x184D32200")]
	public static HOMLGEHHBHE<TActionKind, TSerializedAction, TRoot, TDeps> CCPKJDCALBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MLDGMPNBDOG<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, EGKJPHCNJEL.BNJPLLOIJEN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class DKCLKIHACJI<TPayload, TOk, TErr> : CDBEJFDHGFF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DLBBNMCGCPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DCKEGAEAMPI<TActionKind, TSerializedAction, TPayload> NOKEKKCKAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly EAOKEGABKKC<TRoot, TPayload, TOk, TErr> JOBNKAOJPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool DKBNHLKLBJB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4CD0", Offset = "0x1AA34D0", VA = "0x181AA4CD0")]
		public DKCLKIHACJI(DCKEGAEAMPI<TActionKind, TSerializedAction, TPayload> LLHOANFOPLA, EAOKEGABKKC<TRoot, TPayload, TOk, TErr> JLCEFDHBGCN, bool ONPGNIIDFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D195C0", Offset = "0x6D17DC0", VA = "0x186D195C0", Slot = "4")]
		public Task<AOGODOAGAAO<object, DLBBNMCGCPF>> IKMIEIAGBNM(TDeps GGLINDGLEPB, TRoot MJAMEBJFAIN, TSerializedAction IEAJKOMIAMP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class IJMGJEOHPHJ<TPayload, TOk, TErr> : CDBEJFDHGFF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DLBBNMCGCPF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct IEHCAJAHHPD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<AOGODOAGAAO<object?, DLBBNMCGCPF>> <>t__builder;

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
			public IJMGJEOHPHJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private AOGODOAGAAO<object?, DLBBNMCGCPF> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<AOGODOAGAAO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DCE0", Offset = "0x4E6C4E0", VA = "0x184E6DCE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4E6F0B0", Offset = "0x4E6D8B0", VA = "0x184E6F0B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DCKEGAEAMPI<TActionKind, TSerializedAction, TPayload> NOKEKKCKAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly DFALIOKEGFM<TRoot, TPayload, TOk, TErr> JOBNKAOJPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool DKBNHLKLBJB;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4CD0", Offset = "0x1AA34D0", VA = "0x181AA4CD0")]
		public IJMGJEOHPHJ(DCKEGAEAMPI<TActionKind, TSerializedAction, TPayload> LLHOANFOPLA, DFALIOKEGFM<TRoot, TPayload, TOk, TErr> JLCEFDHBGCN, bool ONPGNIIDFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4E83B50", Offset = "0x4E82350", VA = "0x184E83B50", Slot = "4")]
		[AsyncStateMachine(typeof(IJMGJEOHPHJ<, , >.IEHCAJAHHPD))]
		public Task<AOGODOAGAAO<object, DLBBNMCGCPF>> IKMIEIAGBNM(TDeps GGLINDGLEPB, TRoot MJAMEBJFAIN, TSerializedAction IEAJKOMIAMP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HOMLGEHHBHE<TActionKind, TSerializedAction, TRoot, TDeps> IKHGGPKDGDH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
	private MLDGMPNBDOG(HOMLGEHHBHE<TActionKind, TSerializedAction, TRoot, TDeps> IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5548F50", Offset = "0x5547750", VA = "0x185548F50")]
	public static MLDGMPNBDOG<TActionKind, TSerializedAction, TRoot, TDeps> CCPKJDCALBG()
	{
		return default(MLDGMPNBDOG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4186C10", Offset = "0x4185410", VA = "0x184186C10")]
	public MLDGMPNBDOG<TActionKind, TSerializedAction, TRoot, TDeps> MILBALFFFAK<TPayload, TOk, TErr>(TActionKind MEKIDAHGLGG, DCKEGAEAMPI<TActionKind, TSerializedAction, TPayload> LLHOANFOPLA, EAOKEGABKKC<TRoot, TPayload, TOk, TErr> JLCEFDHBGCN, bool ONPGNIIDFNB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DLBBNMCGCPF
	{
		return default(MLDGMPNBDOG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4186C10", Offset = "0x4185410", VA = "0x184186C10")]
	public MLDGMPNBDOG<TActionKind, TSerializedAction, TRoot, TDeps> JCPGJAACIGJ<TPayload, TOk, TErr>(TActionKind MEKIDAHGLGG, DCKEGAEAMPI<TActionKind, TSerializedAction, TPayload> LLHOANFOPLA, DFALIOKEGFM<TRoot, TPayload, TOk, TErr> JLCEFDHBGCN, bool ONPGNIIDFNB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DLBBNMCGCPF
	{
		return default(MLDGMPNBDOG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5548E90", Offset = "0x5547690", VA = "0x185548E90")]
	public PEDNMPNIDMI<TActionKind, TSerializedAction, TRoot, TDeps> AEOJNBIMJLB(TDeps GGLINDGLEPB)
	{
		return default(PEDNMPNIDMI<TActionKind, TSerializedAction, TRoot, TDeps>);
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
