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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AA2540", Offset = "0x2AA1940", VA = "0x182AA2540")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate FHMCGKKMJCK<TActionKind, TPayload> AGABGDOAJOE<TActionKind, TSerializedAction, TPayload>(TSerializedAction LFHPINDDGIJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface OKKEELICBGF<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DGHPMJAIBNO<object, NKJBEJMGDBL>> FDNAJLLCONN(TDeps MOHOCDOOLDA, TRoot LDEPDDDHLLO, TSerializedAction LFHPINDDGIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NOMLDKNBACN<TActionKind, TSerializedAction, TRoot, TDeps> : HHKNPNNAIPG where TDeps : OODGBNEDCKP.KOENGABKLLM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps MGFGGPPDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction HBKAFCOCMCL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5849790", Offset = "0x5848B90", VA = "0x185849790")]
	public NOMLDKNBACN([In] TDeps MOHOCDOOLDA, [In] TSerializedAction LFHPINDDGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5849580", Offset = "0x5848980", VA = "0x185849580", Slot = "7")]
	public override string HFHAJICOHIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FHMCGKKMJCK<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind FKGEJBLENEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload KKJBBLHPFEJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E92380", Offset = "0x4E91780", VA = "0x184E92380")]
	internal FHMCGKKMJCK(TActionKind MEOKCBLKJHK, [In] TPayload JPPAFNCCIMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IJJLNBNGDHP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D23DC0", Offset = "0x3D231C0", VA = "0x183D23DC0")]
	public static FHMCGKKMJCK<TActionKind, TPayload> EJOLKNBPCJB<TActionKind, TPayload>([In] TActionKind MEOKCBLKJHK, [In] TPayload JPPAFNCCIMK)
	{
		return default(FHMCGKKMJCK<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<DGHPMJAIBNO<TOk, TErr>> LJEHFNNFEIL<TRoot, TPayload, TOk, TErr>(TRoot LDEPDDDHLLO, TPayload JPPAFNCCIMK);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate DGHPMJAIBNO<TOk, TErr> DFJBBJOHNAN<TRoot, TPayload, TOk, TErr>(TRoot LDEPDDDHLLO, [In] TPayload JPPAFNCCIMK);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct ANMBFPJKPOM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : OODGBNEDCKP.KOENGABKLLM<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PMJMEIEBHHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<DGHPMJAIBNO<object?, NKJBEJMGDBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public ANMBFPJKPOM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<DGHPMJAIBNO<object, NKJBEJMGDBL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5B11AF0", Offset = "0x5B10EF0", VA = "0x185B11AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5B11FC0", Offset = "0x5B113C0", VA = "0x185B11FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, OKKEELICBGF<TSerializedAction, TRoot, TDeps>> KOAHHGFFFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps MGFGGPPDFIP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
	internal ANMBFPJKPOM(Dictionary<TActionKind, OKKEELICBGF<TSerializedAction, TRoot, TDeps>> JHNFNKFMCKC, TDeps MOHOCDOOLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x52BEC10", Offset = "0x52BE010", VA = "0x1852BEC10")]
	[AsyncStateMachine(typeof(ANMBFPJKPOM<, , , >.PMJMEIEBHHJ))]
	public Task<DGHPMJAIBNO<object, NKJBEJMGDBL>> FDNAJLLCONN(TRoot LDEPDDDHLLO, TSerializedAction LFHPINDDGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OODGBNEDCKP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KOENGABKLLM<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind AJJAJOFDFCN(TSerializedAction DMFKPMONDPO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MEDCPEPILKA(TRoot LDEPDDDHLLO, TSerializedAction ENDEKEOKCCM);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LJFCOLHODJO(TRoot LDEPDDDHLLO, TSerializedAction ENDEKEOKCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3204270", Offset = "0x3203670", VA = "0x183204270")]
	internal static ANMBFPJKPOM<TActionKind, TSerializedAction, TRoot, TDeps> EJOLKNBPCJB<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, OKKEELICBGF<TSerializedAction, TRoot, TDeps>> JHNFNKFMCKC, TDeps MOHOCDOOLDA) where TDeps : KOENGABKLLM<TActionKind, TSerializedAction, TRoot>
	{
		return default(ANMBFPJKPOM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class PHFMGPPBIOP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, OKKEELICBGF<TSerializedAction, TRoot, TDeps>> GOAJNIFFCDG;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	private PHFMGPPBIOP(Dictionary<TActionKind, OKKEELICBGF<TSerializedAction, TRoot, TDeps>> JHNFNKFMCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5AC82C0", Offset = "0x5AC76C0", VA = "0x185AC82C0")]
	public static PHFMGPPBIOP<TActionKind, TSerializedAction, TRoot, TDeps> EJOLKNBPCJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct NKONFLMDJGF<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, OODGBNEDCKP.KOENGABKLLM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class OBDDHOAGEDM<TPayload, TOk, TErr> : OKKEELICBGF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NKJBEJMGDBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AGABGDOAJOE<TActionKind, TSerializedAction, TPayload> MJIAICDJOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly DFJBBJOHNAN<TRoot, TPayload, TOk, TErr> JALILKJLBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool JJPJIBMCIOA;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1C46B80", Offset = "0x1C45F80", VA = "0x181C46B80")]
		public OBDDHOAGEDM(AGABGDOAJOE<TActionKind, TSerializedAction, TPayload> EFBOCDHAEON, DFJBBJOHNAN<TRoot, TPayload, TOk, TErr> IFIPDDOEHBB, bool AHEECNJKJAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5951220", Offset = "0x5950620", VA = "0x185951220", Slot = "4")]
		public Task<DGHPMJAIBNO<object, NKJBEJMGDBL>> FDNAJLLCONN(TDeps MOHOCDOOLDA, TRoot LDEPDDDHLLO, TSerializedAction LFHPINDDGIJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KMCGPHBOKOG<TPayload, TOk, TErr> : OKKEELICBGF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NKJBEJMGDBL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct HDLDANEJIDH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<DGHPMJAIBNO<object?, NKJBEJMGDBL>> <>t__builder;

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
			public KMCGPHBOKOG<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private DGHPMJAIBNO<object?, NKJBEJMGDBL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DGHPMJAIBNO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4FAED00", Offset = "0x4FAE100", VA = "0x184FAED00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4FB0410", Offset = "0x4FAF810", VA = "0x184FB0410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AGABGDOAJOE<TActionKind, TSerializedAction, TPayload> MJIAICDJOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly LJEHFNNFEIL<TRoot, TPayload, TOk, TErr> JALILKJLBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool JJPJIBMCIOA;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1C46B80", Offset = "0x1C45F80", VA = "0x181C46B80")]
		public KMCGPHBOKOG(AGABGDOAJOE<TActionKind, TSerializedAction, TPayload> EFBOCDHAEON, LJEHFNNFEIL<TRoot, TPayload, TOk, TErr> IFIPDDOEHBB, bool AHEECNJKJAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5460360", Offset = "0x545F760", VA = "0x185460360", Slot = "4")]
		[AsyncStateMachine(typeof(KMCGPHBOKOG<, , >.HDLDANEJIDH))]
		public Task<DGHPMJAIBNO<object, NKJBEJMGDBL>> FDNAJLLCONN(TDeps MOHOCDOOLDA, TRoot LDEPDDDHLLO, TSerializedAction LFHPINDDGIJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly PHFMGPPBIOP<TActionKind, TSerializedAction, TRoot, TDeps> HEEDNJCIPMK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
	private NKONFLMDJGF(PHFMGPPBIOP<TActionKind, TSerializedAction, TRoot, TDeps> NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x581EAC0", Offset = "0x581DEC0", VA = "0x18581EAC0")]
	public static NKONFLMDJGF<TActionKind, TSerializedAction, TRoot, TDeps> EJOLKNBPCJB()
	{
		return default(NKONFLMDJGF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4464DB0", Offset = "0x44641B0", VA = "0x184464DB0")]
	public NKONFLMDJGF<TActionKind, TSerializedAction, TRoot, TDeps> FNOOHCLOEKD<TPayload, TOk, TErr>(TActionKind MEOKCBLKJHK, AGABGDOAJOE<TActionKind, TSerializedAction, TPayload> EFBOCDHAEON, DFJBBJOHNAN<TRoot, TPayload, TOk, TErr> IFIPDDOEHBB, bool AHEECNJKJAM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NKJBEJMGDBL
	{
		return default(NKONFLMDJGF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4464DB0", Offset = "0x44641B0", VA = "0x184464DB0")]
	public NKONFLMDJGF<TActionKind, TSerializedAction, TRoot, TDeps> JFEMJNHCEAO<TPayload, TOk, TErr>(TActionKind MEOKCBLKJHK, AGABGDOAJOE<TActionKind, TSerializedAction, TPayload> EFBOCDHAEON, LJEHFNNFEIL<TRoot, TPayload, TOk, TErr> IFIPDDOEHBB, bool AHEECNJKJAM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NKJBEJMGDBL
	{
		return default(NKONFLMDJGF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x581EB50", Offset = "0x581DF50", VA = "0x18581EB50")]
	public ANMBFPJKPOM<TActionKind, TSerializedAction, TRoot, TDeps> ILNENIFJGDP(TDeps MOHOCDOOLDA)
	{
		return default(ANMBFPJKPOM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
