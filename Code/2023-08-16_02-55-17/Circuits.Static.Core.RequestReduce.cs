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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F84080", Offset = "0x6F83280", VA = "0x186F84080")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
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
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct KDDOJAECMMJ<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind BMPLLEEPDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload OJCLHCLFDKP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22D46B0", Offset = "0x22D38B0", VA = "0x1822D46B0")]
	internal KDDOJAECMMJ(TActionKind PPMALOGKNHB, in TPayload GJNKBDPFGGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MHEDEMAHCDP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1245720", Offset = "0x1244920", VA = "0x181245720")]
	public static KDDOJAECMMJ<TActionKind, TPayload> HBHNAKPOBBF<TActionKind, TPayload>(in TActionKind PPMALOGKNHB, in TPayload GJNKBDPFGGF)
	{
		return default(KDDOJAECMMJ<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface LGOHEOEJLBG<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PINPMIPFEPJ<object, OKKDIBLBODL>> BCNLOPJLHFI(TDeps NKPJOKLGAHM, TRoot MKADPIPCNMO, TSerializedAction MIJNPNDICBK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EMMEMCPIJPP<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : PMLHBCKFJGO.DFBLKPGNGBD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JLHFJFFHFJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<object, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public EMMEMCPIJPP<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LGOHEOEJLBG<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public JLHFJFFHFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x292BB10", Offset = "0x292AD10", VA = "0x18292BB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, LGOHEOEJLBG<TSerializedAction, TRoot, TDeps>> GELOMNOPOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps KBFCOPLBFPF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x949BA0", Offset = "0x948DA0", VA = "0x180949BA0")]
	internal EMMEMCPIJPP(Dictionary<TActionKind, LGOHEOEJLBG<TSerializedAction, TRoot, TDeps>> AAEOPKPCJHF, TDeps NKPJOKLGAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x163BC70", Offset = "0x163AE70", VA = "0x18163BC70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EMMEMCPIJPP<, , , >.JLHFJFFHFJL))]
	public Task<PINPMIPFEPJ<object, OKKDIBLBODL>> BCNLOPJLHFI(TRoot MKADPIPCNMO, TSerializedAction MIJNPNDICBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PMLHBCKFJGO
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface DFBLKPGNGBD<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind FGCAAKKMIIJ(TSerializedAction KPIHKJNPOFH);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DBDACJGPIIB(TRoot MKADPIPCNMO, TSerializedAction AMEKOPCKNIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x234EB80", Offset = "0x234DD80", VA = "0x18234EB80")]
	internal static EMMEMCPIJPP<TActionKind, TSerializedAction, TRoot, TDeps> HBHNAKPOBBF<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, LGOHEOEJLBG<TSerializedAction, TRoot, TDeps>> AAEOPKPCJHF, TDeps NKPJOKLGAHM) where TDeps : DFBLKPGNGBD<TActionKind, TSerializedAction, TRoot>
	{
		return default(EMMEMCPIJPP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate PINPMIPFEPJ<TOk, TErr> IJNGDNKPFMI<TRoot, TPayload, TOk, TErr>(TRoot MKADPIPCNMO, in TPayload GJNKBDPFGGF);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class FCENOIBJEHF<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, LGOHEOEJLBG<TSerializedAction, TRoot, TDeps>> NIGMCOLFDHB;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1C453A0", Offset = "0x1C445A0", VA = "0x181C453A0")]
	private FCENOIBJEHF(Dictionary<TActionKind, LGOHEOEJLBG<TSerializedAction, TRoot, TDeps>> AAEOPKPCJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1C67130", Offset = "0x1C66330", VA = "0x181C67130")]
	public static FCENOIBJEHF<TActionKind, TSerializedAction, TRoot, TDeps> HBHNAKPOBBF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<PINPMIPFEPJ<TOk, TErr>> DJBBCJMNLLI<TRoot, TPayload, TOk, TErr>(TRoot MKADPIPCNMO, TPayload GJNKBDPFGGF);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class ENFOOHGPJEJ<TActionKind, TSerializedAction, TRoot, TDeps> : IFCPLEGMLKF where TDeps : PMLHBCKFJGO.DFBLKPGNGBD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps KBFCOPLBFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction HKHHKJIMBPO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x163D1F0", Offset = "0x163C3F0", VA = "0x18163D1F0")]
	public ENFOOHGPJEJ(in TDeps NKPJOKLGAHM, in TSerializedAction MIJNPNDICBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x163D110", Offset = "0x163C310", VA = "0x18163D110", Slot = "7")]
	public override string MJGKCLCNGHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate KDDOJAECMMJ<TActionKind, TPayload> PECLGHAFLNA<TActionKind, TSerializedAction, TPayload>(TSerializedAction MIJNPNDICBK);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GANOHBDLJJM<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, PMLHBCKFJGO.DFBLKPGNGBD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class GDFLKJIGKKD<TPayload, TOk, TErr> : LGOHEOEJLBG<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OKKDIBLBODL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly PECLGHAFLNA<TActionKind, TSerializedAction, TPayload> FCGJEOLNMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly IJNGDNKPFMI<TRoot, TPayload, TOk, TErr> AFDFAGIPEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool FOGPIEBALOE;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C110", Offset = "0x2C2B310", VA = "0x182C2C110")]
		public GDFLKJIGKKD(PECLGHAFLNA<TActionKind, TSerializedAction, TPayload> BFBJEOEOIGA, IJNGDNKPFMI<TRoot, TPayload, TOk, TErr> MOKODEBCIMI, bool KJMCBBBIEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3A92110", Offset = "0x3A91310", VA = "0x183A92110", Slot = "4")]
		public Task<PINPMIPFEPJ<object, OKKDIBLBODL>> BCNLOPJLHFI(TDeps NKPJOKLGAHM, TRoot MKADPIPCNMO, TSerializedAction MIJNPNDICBK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class ECNHKECIADF<TPayload, TOk, TErr> : LGOHEOEJLBG<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OKKDIBLBODL
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class KLKEAIBAHID : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72B980", Offset = "0x72AD80")]
			public AsyncTaskMethodBuilder<PINPMIPFEPJ<object, OKKDIBLBODL>> <>t__builder;

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
			public ECNHKECIADF<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72B9E0", Offset = "0x72ADE0")]
			private PINPMIPFEPJ<object, OKKDIBLBODL> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72BA40", Offset = "0x72AE40")]
			private KDDOJAECMMJ<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72BAA0", Offset = "0x72AEA0")]
			private PINPMIPFEPJ<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72BB00", Offset = "0x72AF00")]
			private PINPMIPFEPJ<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72BB60", Offset = "0x72AF60")]
			private TaskAwaiter<PINPMIPFEPJ<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public KLKEAIBAHID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3281380", Offset = "0x3280580", VA = "0x183281380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly PECLGHAFLNA<TActionKind, TSerializedAction, TPayload> FCGJEOLNMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly DJBBCJMNLLI<TRoot, TPayload, TOk, TErr> AFDFAGIPEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool FOGPIEBALOE;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C110", Offset = "0x2C2B310", VA = "0x182C2C110")]
		public ECNHKECIADF(PECLGHAFLNA<TActionKind, TSerializedAction, TPayload> BFBJEOEOIGA, DJBBCJMNLLI<TRoot, TPayload, TOk, TErr> MOKODEBCIMI, bool KJMCBBBIEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2C2B7B0", Offset = "0x2C2A9B0", VA = "0x182C2B7B0", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(ECNHKECIADF<, , >.KLKEAIBAHID))]
		public Task<PINPMIPFEPJ<object, OKKDIBLBODL>> BCNLOPJLHFI(TDeps NKPJOKLGAHM, TRoot MKADPIPCNMO, TSerializedAction MIJNPNDICBK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FCENOIBJEHF<TActionKind, TSerializedAction, TRoot, TDeps> DCDNDCCJEJB;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	private GANOHBDLJJM(FCENOIBJEHF<TActionKind, TSerializedAction, TRoot, TDeps> JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x33201B0", Offset = "0x331F3B0", VA = "0x1833201B0")]
	public static GANOHBDLJJM<TActionKind, TSerializedAction, TRoot, TDeps> HBHNAKPOBBF()
	{
		return default(GANOHBDLJJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xF7B500", Offset = "0xF7A700", VA = "0x180F7B500")]
	public GANOHBDLJJM<TActionKind, TSerializedAction, TRoot, TDeps> DCLKACNJLIG<TPayload, TOk, TErr>(TActionKind PPMALOGKNHB, PECLGHAFLNA<TActionKind, TSerializedAction, TPayload> BFBJEOEOIGA, IJNGDNKPFMI<TRoot, TPayload, TOk, TErr> MOKODEBCIMI, bool KJMCBBBIEGJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OKKDIBLBODL
	{
		return default(GANOHBDLJJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xF7B500", Offset = "0xF7A700", VA = "0x180F7B500")]
	public GANOHBDLJJM<TActionKind, TSerializedAction, TRoot, TDeps> JANMCEIPIJB<TPayload, TOk, TErr>(TActionKind PPMALOGKNHB, PECLGHAFLNA<TActionKind, TSerializedAction, TPayload> BFBJEOEOIGA, DJBBCJMNLLI<TRoot, TPayload, TOk, TErr> MOKODEBCIMI, bool KJMCBBBIEGJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OKKDIBLBODL
	{
		return default(GANOHBDLJJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3320240", Offset = "0x331F440", VA = "0x183320240")]
	public EMMEMCPIJPP<TActionKind, TSerializedAction, TRoot, TDeps> IBBPKBDNAAG(TDeps NKPJOKLGAHM)
	{
		return default(EMMEMCPIJPP<TActionKind, TSerializedAction, TRoot, TDeps>);
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
