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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x7237460", Offset = "0x7236860", VA = "0x187237460")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct BHAFDKNFICO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind AOEMOPJFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload HBMHLBOIFBJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x205D9F0", Offset = "0x205CDF0", VA = "0x18205D9F0")]
	internal BHAFDKNFICO(TActionKind JKJMBIMADGI, in TPayload HOJNLEBJGLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GMNDKKJOOKG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x16E1B30", Offset = "0x16E0F30", VA = "0x1816E1B30")]
	public static BHAFDKNFICO<TActionKind, TPayload> NAILOIKCJEC<TActionKind, TPayload>(in TActionKind JKJMBIMADGI, in TPayload HOJNLEBJGLH)
	{
		return default(BHAFDKNFICO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface OFHMPPKBIHE<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ADOGIEMPLPD<object, NADLJLPONBH>> AMDCEGFLCBN(TDeps AEPKLFBJEML, TRoot AOCBEEBNJPK, TSerializedAction JJIANEMHPHL);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CJPPHBHLLGF<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GFLCBAAKLHD.AECNIKIALHF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HNNBMFJHBMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<ADOGIEMPLPD<object, NADLJLPONBH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CJPPHBHLLGF<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private ADOGIEMPLPD<object, NADLJLPONBH> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private OFHMPPKBIHE<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ADOGIEMPLPD<object, NADLJLPONBH> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<ADOGIEMPLPD<object, NADLJLPONBH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public HNNBMFJHBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2D22DF0", Offset = "0x2D221F0", VA = "0x182D22DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, OFHMPPKBIHE<TSerializedAction, TRoot, TDeps>> HLCNHCCHICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps PGFDLLBOOHB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xD06A00", Offset = "0xD05E00", VA = "0x180D06A00")]
	internal CJPPHBHLLGF(Dictionary<TActionKind, OFHMPPKBIHE<TSerializedAction, TRoot, TDeps>> KJEAOICFDHK, TDeps AEPKLFBJEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38350E0", Offset = "0x38344E0", VA = "0x1838350E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CJPPHBHLLGF<, , , >.HNNBMFJHBMF))]
	public Task<ADOGIEMPLPD<object, NADLJLPONBH>> AMDCEGFLCBN(TRoot AOCBEEBNJPK, TSerializedAction JJIANEMHPHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GFLCBAAKLHD
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface AECNIKIALHF<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind LMCOOCHLKHJ(TSerializedAction ODBHDBFBMOB);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IEDCMBDGJBH(TRoot AOCBEEBNJPK, TSerializedAction NDPBOAHDPLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x16D85F0", Offset = "0x16D79F0", VA = "0x1816D85F0")]
	internal static CJPPHBHLLGF<TActionKind, TSerializedAction, TRoot, TDeps> NAILOIKCJEC<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, OFHMPPKBIHE<TSerializedAction, TRoot, TDeps>> KJEAOICFDHK, TDeps AEPKLFBJEML) where TDeps : AECNIKIALHF<TActionKind, TSerializedAction, TRoot>
	{
		return default(CJPPHBHLLGF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate ADOGIEMPLPD<TOk, TErr> BFJPNNOHOBL<TRoot, TPayload, TOk, TErr>(TRoot AOCBEEBNJPK, in TPayload HOJNLEBJGLH);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class BHOADPMJCDC<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, OFHMPPKBIHE<TSerializedAction, TRoot, TDeps>> GDMCJHGEHKC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1314980", Offset = "0x1313D80", VA = "0x181314980")]
	private BHOADPMJCDC(Dictionary<TActionKind, OFHMPPKBIHE<TSerializedAction, TRoot, TDeps>> KJEAOICFDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x205FE20", Offset = "0x205F220", VA = "0x18205FE20")]
	public static BHOADPMJCDC<TActionKind, TSerializedAction, TRoot, TDeps> NAILOIKCJEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<ADOGIEMPLPD<TOk, TErr>> JGLABAEGMCD<TRoot, TPayload, TOk, TErr>(TRoot AOCBEEBNJPK, TPayload HOJNLEBJGLH);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GPDKCGNAEBE<TActionKind, TSerializedAction, TRoot, TDeps> : HCGGKOEMGBM where TDeps : GFLCBAAKLHD.AECNIKIALHF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps PGFDLLBOOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction HCALEOFIPEI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2C74940", Offset = "0x2C73D40", VA = "0x182C74940")]
	public GPDKCGNAEBE(in TDeps AEPKLFBJEML, in TSerializedAction JJIANEMHPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2C74770", Offset = "0x2C73B70", VA = "0x182C74770", Slot = "7")]
	public override string NBKNGDNHDKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate BHAFDKNFICO<TActionKind, TPayload> BEGAPIPHPIB<TActionKind, TSerializedAction, TPayload>(TSerializedAction JJIANEMHPHL);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MBLBMPEFCJM<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GFLCBAAKLHD.AECNIKIALHF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class DDNGAFJLMIP<TPayload, TOk, TErr> : OFHMPPKBIHE<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NADLJLPONBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly BEGAPIPHPIB<TActionKind, TSerializedAction, TPayload> HKLFHOJPGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BFJPNNOHOBL<TRoot, TPayload, TOk, TErr> EHHDNDGOIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool MJBGNLNJEDP;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x258F550", Offset = "0x258E950", VA = "0x18258F550")]
		public DDNGAFJLMIP(BEGAPIPHPIB<TActionKind, TSerializedAction, TPayload> CJJIPHDDDGO, BFJPNNOHOBL<TRoot, TPayload, TOk, TErr> KCHOLBFLDML, bool BNFMMFCNJOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x258E6D0", Offset = "0x258DAD0", VA = "0x18258E6D0", Slot = "4")]
		public Task<ADOGIEMPLPD<object, NADLJLPONBH>> AMDCEGFLCBN(TDeps AEPKLFBJEML, TRoot AOCBEEBNJPK, TSerializedAction JJIANEMHPHL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class ACHNBLDBOOD<TPayload, TOk, TErr> : OFHMPPKBIHE<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NADLJLPONBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class EIHPHHHCHIC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7697E0", Offset = "0x768BE0")]
			public AsyncTaskMethodBuilder<ADOGIEMPLPD<object, NADLJLPONBH>> <>t__builder;

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
			public ACHNBLDBOOD<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x769840", Offset = "0x768C40")]
			private ADOGIEMPLPD<object, NADLJLPONBH> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7698A0", Offset = "0x768CA0")]
			private BHAFDKNFICO<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x769900", Offset = "0x768D00")]
			private ADOGIEMPLPD<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x769960", Offset = "0x768D60")]
			private ADOGIEMPLPD<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7699C0", Offset = "0x768DC0")]
			private TaskAwaiter<ADOGIEMPLPD<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public EIHPHHHCHIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2B77860", Offset = "0x2B76C60", VA = "0x182B77860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly BEGAPIPHPIB<TActionKind, TSerializedAction, TPayload> HKLFHOJPGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly JGLABAEGMCD<TRoot, TPayload, TOk, TErr> EHHDNDGOIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool MJBGNLNJEDP;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x258F550", Offset = "0x258E950", VA = "0x18258F550")]
		public ACHNBLDBOOD(BEGAPIPHPIB<TActionKind, TSerializedAction, TPayload> CJJIPHDDDGO, JGLABAEGMCD<TRoot, TPayload, TOk, TErr> KCHOLBFLDML, bool BNFMMFCNJOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3137000", Offset = "0x3136400", VA = "0x183137000", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(ACHNBLDBOOD<, , >.EIHPHHHCHIC))]
		public Task<ADOGIEMPLPD<object, NADLJLPONBH>> AMDCEGFLCBN(TDeps AEPKLFBJEML, TRoot AOCBEEBNJPK, TSerializedAction JJIANEMHPHL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BHOADPMJCDC<TActionKind, TSerializedAction, TRoot, TDeps> DGILHPBNFGO;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
	private MBLBMPEFCJM(BHOADPMJCDC<TActionKind, TSerializedAction, TRoot, TDeps> CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x22EC770", Offset = "0x22EBB70", VA = "0x1822EC770")]
	public static MBLBMPEFCJM<TActionKind, TSerializedAction, TRoot, TDeps> NAILOIKCJEC()
	{
		return default(MBLBMPEFCJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1BC0940", Offset = "0x1BBFD40", VA = "0x181BC0940")]
	public MBLBMPEFCJM<TActionKind, TSerializedAction, TRoot, TDeps> DNLOCMOGBGF<TPayload, TOk, TErr>(TActionKind JKJMBIMADGI, BEGAPIPHPIB<TActionKind, TSerializedAction, TPayload> CJJIPHDDDGO, BFJPNNOHOBL<TRoot, TPayload, TOk, TErr> KCHOLBFLDML, bool BNFMMFCNJOF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NADLJLPONBH
	{
		return default(MBLBMPEFCJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1BC0940", Offset = "0x1BBFD40", VA = "0x181BC0940")]
	public MBLBMPEFCJM<TActionKind, TSerializedAction, TRoot, TDeps> LOLNIBONNBA<TPayload, TOk, TErr>(TActionKind JKJMBIMADGI, BEGAPIPHPIB<TActionKind, TSerializedAction, TPayload> CJJIPHDDDGO, JGLABAEGMCD<TRoot, TPayload, TOk, TErr> KCHOLBFLDML, bool BNFMMFCNJOF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NADLJLPONBH
	{
		return default(MBLBMPEFCJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x22EC800", Offset = "0x22EBC00", VA = "0x1822EC800")]
	public CJPPHBHLLGF<TActionKind, TSerializedAction, TRoot, TDeps> NPJNKCPHLIJ(TDeps AEPKLFBJEML)
	{
		return default(CJPPHBHLLGF<TActionKind, TSerializedAction, TRoot, TDeps>);
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
