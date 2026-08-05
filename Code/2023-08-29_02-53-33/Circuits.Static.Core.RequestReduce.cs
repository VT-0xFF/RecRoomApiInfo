using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1740", Offset = "0x6FB0B40", VA = "0x186FB1740")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct HELEFHKANPP<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind CBPDFLDNFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload EOAEECGHHKK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x202B040", Offset = "0x202A440", VA = "0x18202B040")]
	internal HELEFHKANPP(TActionKind BEJPFJCMIOE, in TPayload KBLLMJIHKAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OCAFLADOLPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x12C2540", Offset = "0x12C1940", VA = "0x1812C2540")]
	public static HELEFHKANPP<TActionKind, TPayload> OHIOHLNJBHE<TActionKind, TPayload>(in TActionKind BEJPFJCMIOE, in TPayload KBLLMJIHKAK)
	{
		return default(HELEFHKANPP<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface GNFDLOIPLML<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FKHOBCEMFFK<object, ODEJFAIDODH>> MLDMFNLPNOK(TDeps NMBFMOECKBE, TRoot COMCNEGAGFF, TSerializedAction GOJNCKHKDBI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OOIHGHNMHKJ<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : AHJFEEEKKKI.OFJALPHOILD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FEEFFEHAIIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<FKHOBCEMFFK<object, ODEJFAIDODH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public OOIHGHNMHKJ<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private FKHOBCEMFFK<object, ODEJFAIDODH> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GNFDLOIPLML<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FKHOBCEMFFK<object, ODEJFAIDODH> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<FKHOBCEMFFK<object, ODEJFAIDODH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public FEEFFEHAIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x19481D0", Offset = "0x19475D0", VA = "0x1819481D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, GNFDLOIPLML<TSerializedAction, TRoot, TDeps>> KLICFGKCFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps DDCOEMJKCBD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xD82A00", Offset = "0xD81E00", VA = "0x180D82A00")]
	internal OOIHGHNMHKJ(Dictionary<TActionKind, GNFDLOIPLML<TSerializedAction, TRoot, TDeps>> LNJOIKNPOCL, TDeps NMBFMOECKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37AE130", Offset = "0x37AD530", VA = "0x1837AE130")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OOIHGHNMHKJ<, , , >.FEEFFEHAIIF))]
	public Task<FKHOBCEMFFK<object, ODEJFAIDODH>> MLDMFNLPNOK(TRoot COMCNEGAGFF, TSerializedAction GOJNCKHKDBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AHJFEEEKKKI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface OFJALPHOILD<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind NOJPFBPNDJM(TSerializedAction JCOLBAAGCGE);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EEOJLMMMIJH(TRoot COMCNEGAGFF, TSerializedAction FJBAKNFCPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B880", Offset = "0x1D6AC80", VA = "0x181D6B880")]
	internal static OOIHGHNMHKJ<TActionKind, TSerializedAction, TRoot, TDeps> OHIOHLNJBHE<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, GNFDLOIPLML<TSerializedAction, TRoot, TDeps>> LNJOIKNPOCL, TDeps NMBFMOECKBE) where TDeps : OFJALPHOILD<TActionKind, TSerializedAction, TRoot>
	{
		return default(OOIHGHNMHKJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate FKHOBCEMFFK<TOk, TErr> ECGLPIOGIOM<TRoot, TPayload, TOk, TErr>(TRoot COMCNEGAGFF, in TPayload KBLLMJIHKAK);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class FAJGMAJKDHB<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, GNFDLOIPLML<TSerializedAction, TRoot, TDeps>> LNOBIGOMABK;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x16C90C0", Offset = "0x16C84C0", VA = "0x1816C90C0")]
	private FAJGMAJKDHB(Dictionary<TActionKind, GNFDLOIPLML<TSerializedAction, TRoot, TDeps>> LNJOIKNPOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x193B980", Offset = "0x193AD80", VA = "0x18193B980")]
	public static FAJGMAJKDHB<TActionKind, TSerializedAction, TRoot, TDeps> OHIOHLNJBHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<FKHOBCEMFFK<TOk, TErr>> JGLCFJJKLHA<TRoot, TPayload, TOk, TErr>(TRoot COMCNEGAGFF, TPayload KBLLMJIHKAK);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class ACHAEHFGBNN<TActionKind, TSerializedAction, TRoot, TDeps> : ENFHEJLIMCP where TDeps : AHJFEEEKKKI.OFJALPHOILD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps DDCOEMJKCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction OLMCLLDJCMN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3971D40", Offset = "0x3971140", VA = "0x183971D40")]
	public ACHAEHFGBNN(in TDeps NMBFMOECKBE, in TSerializedAction GOJNCKHKDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3971B20", Offset = "0x3970F20", VA = "0x183971B20", Slot = "7")]
	public override string APIKMAODCDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate HELEFHKANPP<TActionKind, TPayload> LAHLEJBPDMD<TActionKind, TSerializedAction, TPayload>(TSerializedAction GOJNCKHKDBI);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OBCPHENOOOC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, AHJFEEEKKKI.OFJALPHOILD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class DCEGJAIONDB<TPayload, TOk, TErr> : GNFDLOIPLML<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, ODEJFAIDODH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly LAHLEJBPDMD<TActionKind, TSerializedAction, TPayload> MKMMFMHKOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly ECGLPIOGIOM<TRoot, TPayload, TOk, TErr> DFBPOEBGMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool KKMNKCINJMM;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2354FA0", Offset = "0x23543A0", VA = "0x182354FA0")]
		public DCEGJAIONDB(LAHLEJBPDMD<TActionKind, TSerializedAction, TPayload> NBAJNGLEHIH, ECGLPIOGIOM<TRoot, TPayload, TOk, TErr> PLJDCEGABAK, bool KDHOFMDKDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2AF87D0", Offset = "0x2AF7BD0", VA = "0x182AF87D0", Slot = "4")]
		public Task<FKHOBCEMFFK<object, ODEJFAIDODH>> MLDMFNLPNOK(TDeps NMBFMOECKBE, TRoot COMCNEGAGFF, TSerializedAction GOJNCKHKDBI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class IPENMILFDEB<TPayload, TOk, TErr> : GNFDLOIPLML<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, ODEJFAIDODH
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class GLOCCEBPGOL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x731C50", Offset = "0x731050")]
			public AsyncTaskMethodBuilder<FKHOBCEMFFK<object, ODEJFAIDODH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IPENMILFDEB<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x731CB0", Offset = "0x7310B0")]
			private FKHOBCEMFFK<object, ODEJFAIDODH> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x731D10", Offset = "0x731110")]
			private HELEFHKANPP<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x731D70", Offset = "0x731170")]
			private FKHOBCEMFFK<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x731DD0", Offset = "0x7311D0")]
			private FKHOBCEMFFK<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x731E30", Offset = "0x731230")]
			private TaskAwaiter<FKHOBCEMFFK<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
			public GLOCCEBPGOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x27493B0", Offset = "0x27487B0", VA = "0x1827493B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly LAHLEJBPDMD<TActionKind, TSerializedAction, TPayload> MKMMFMHKOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly JGLCFJJKLHA<TRoot, TPayload, TOk, TErr> DFBPOEBGMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool KKMNKCINJMM;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2354FA0", Offset = "0x23543A0", VA = "0x182354FA0")]
		public IPENMILFDEB(LAHLEJBPDMD<TActionKind, TSerializedAction, TPayload> NBAJNGLEHIH, JGLCFJJKLHA<TRoot, TPayload, TOk, TErr> PLJDCEGABAK, bool KDHOFMDKDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2354A00", Offset = "0x2353E00", VA = "0x182354A00", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(IPENMILFDEB<, , >.GLOCCEBPGOL))]
		public Task<FKHOBCEMFFK<object, ODEJFAIDODH>> MLDMFNLPNOK(TDeps NMBFMOECKBE, TRoot COMCNEGAGFF, TSerializedAction GOJNCKHKDBI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FAJGMAJKDHB<TActionKind, TSerializedAction, TRoot, TDeps> HCJPJHMMCJD;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9EA8F0", Offset = "0x9E9CF0", VA = "0x1809EA8F0")]
	private OBCPHENOOOC(FAJGMAJKDHB<TActionKind, TSerializedAction, TRoot, TDeps> KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x27032F0", Offset = "0x27026F0", VA = "0x1827032F0")]
	public static OBCPHENOOOC<TActionKind, TSerializedAction, TRoot, TDeps> OHIOHLNJBHE()
	{
		return default(OBCPHENOOOC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x139F300", Offset = "0x139E700", VA = "0x18139F300")]
	public OBCPHENOOOC<TActionKind, TSerializedAction, TRoot, TDeps> PCLKIBMIJPG<TPayload, TOk, TErr>(TActionKind BEJPFJCMIOE, LAHLEJBPDMD<TActionKind, TSerializedAction, TPayload> NBAJNGLEHIH, ECGLPIOGIOM<TRoot, TPayload, TOk, TErr> PLJDCEGABAK, bool KDHOFMDKDNF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, ODEJFAIDODH
	{
		return default(OBCPHENOOOC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x139F300", Offset = "0x139E700", VA = "0x18139F300")]
	public OBCPHENOOOC<TActionKind, TSerializedAction, TRoot, TDeps> JCCCKNEJAGA<TPayload, TOk, TErr>(TActionKind BEJPFJCMIOE, LAHLEJBPDMD<TActionKind, TSerializedAction, TPayload> NBAJNGLEHIH, JGLCFJJKLHA<TRoot, TPayload, TOk, TErr> PLJDCEGABAK, bool KDHOFMDKDNF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, ODEJFAIDODH
	{
		return default(OBCPHENOOOC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2703240", Offset = "0x2702640", VA = "0x182703240")]
	public OOIHGHNMHKJ<TActionKind, TSerializedAction, TRoot, TDeps> NALFHPNKMGH(TDeps NMBFMOECKBE)
	{
		return default(OOIHGHNMHKJ<TActionKind, TSerializedAction, TRoot, TDeps>);
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
