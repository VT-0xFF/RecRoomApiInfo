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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x7275290", Offset = "0x7273890", VA = "0x187275290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct OKGLFCLBNDC<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind JHLAAJCIIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload GGAAIDPIDGG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x265EB10", Offset = "0x265D110", VA = "0x18265EB10")]
	internal OKGLFCLBNDC(TActionKind JGLPCLKCOBD, in TPayload OGLJJNFALNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CBIDFLBIDEL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x169E950", Offset = "0x169CF50", VA = "0x18169E950")]
	public static OKGLFCLBNDC<TActionKind, TPayload> JBGFDEKBNPE<TActionKind, TPayload>(in TActionKind JGLPCLKCOBD, in TPayload OGLJJNFALNA)
	{
		return default(OKGLFCLBNDC<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface NDEDJJKOMOM<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> NLBGACKMFGH(TDeps OBBCAGMEJPG, TRoot MPEICFNBKOF, TSerializedAction EOHIGEJKHHE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CIPGBAGLIGA<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GFNPIIOPFPB.GDPCDCDMFOG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HBINHPNMOBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CIPGBAGLIGA<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NDEDJJKOMOM<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public HBINHPNMOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2E4AA20", Offset = "0x2E49020", VA = "0x182E4AA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, NDEDJJKOMOM<TSerializedAction, TRoot, TDeps>> MCELKGEGDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps NENKFPBEKNA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xBBF9D0", Offset = "0xBBDFD0", VA = "0x180BBF9D0")]
	internal CIPGBAGLIGA(Dictionary<TActionKind, NDEDJJKOMOM<TSerializedAction, TRoot, TDeps>> NNEKNGNPBPP, TDeps OBBCAGMEJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5160", Offset = "0x2BB3760", VA = "0x182BB5160")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CIPGBAGLIGA<, , , >.HBINHPNMOBE))]
	public Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> NLBGACKMFGH(TRoot MPEICFNBKOF, TSerializedAction EOHIGEJKHHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GFNPIIOPFPB
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface GDPCDCDMFOG<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind LGNILPIPOEC(TSerializedAction PBJDHAKDMFG);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MCKCJIOHBMH(TRoot MPEICFNBKOF, TSerializedAction INJMGBDPOBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1B79AB0", Offset = "0x1B780B0", VA = "0x181B79AB0")]
	internal static CIPGBAGLIGA<TActionKind, TSerializedAction, TRoot, TDeps> JBGFDEKBNPE<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, NDEDJJKOMOM<TSerializedAction, TRoot, TDeps>> NNEKNGNPBPP, TDeps OBBCAGMEJPG) where TDeps : GDPCDCDMFOG<TActionKind, TSerializedAction, TRoot>
	{
		return default(CIPGBAGLIGA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate EGKNCMFMAMB<TOk, TErr> LFOJJMAGGGH<TRoot, TPayload, TOk, TErr>(TRoot MPEICFNBKOF, in TPayload OGLJJNFALNA);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class DJGJPMCEGLD<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, NDEDJJKOMOM<TSerializedAction, TRoot, TDeps>> GNBGKCHMOOF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x15BDFA0", Offset = "0x15BC5A0", VA = "0x1815BDFA0")]
	private DJGJPMCEGLD(Dictionary<TActionKind, NDEDJJKOMOM<TSerializedAction, TRoot, TDeps>> NNEKNGNPBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C8E0", Offset = "0x2F1AEE0", VA = "0x182F1C8E0")]
	public static DJGJPMCEGLD<TActionKind, TSerializedAction, TRoot, TDeps> JBGFDEKBNPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<EGKNCMFMAMB<TOk, TErr>> HKCFFBAEBFL<TRoot, TPayload, TOk, TErr>(TRoot MPEICFNBKOF, TPayload OGLJJNFALNA);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class ABIIGMBCPMA<TActionKind, TSerializedAction, TRoot, TDeps> : ONNGGILNJJP where TDeps : GFNPIIOPFPB.GDPCDCDMFOG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps NENKFPBEKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction CDPLPJOKFNO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x26CEB60", Offset = "0x26CD160", VA = "0x1826CEB60")]
	public ABIIGMBCPMA(in TDeps OBBCAGMEJPG, in TSerializedAction EOHIGEJKHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26CEA30", Offset = "0x26CD030", VA = "0x1826CEA30", Slot = "7")]
	public override string EIGPMPLDIJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate OKGLFCLBNDC<TActionKind, TPayload> BEFPPBIDOJE<TActionKind, TSerializedAction, TPayload>(TSerializedAction EOHIGEJKHHE);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FBMIPIIMLPA<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GFNPIIOPFPB.GDPCDCDMFOG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class JBIJONLHAOO<TPayload, TOk, TErr> : NDEDJJKOMOM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MNMNGBCAHAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly BEFPPBIDOJE<TActionKind, TSerializedAction, TPayload> EKLLOMIHFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly LFOJJMAGGGH<TRoot, TPayload, TOk, TErr> NKDLDBDAHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool MCKDNKOLHLG;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x121C8B0", Offset = "0x121AEB0", VA = "0x18121C8B0")]
		public JBIJONLHAOO(BEFPPBIDOJE<TActionKind, TSerializedAction, TPayload> HOHHALCKPFL, LFOJJMAGGGH<TRoot, TPayload, TOk, TErr> DCEPKHJKEOO, bool CIKFGGGANHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x23E9360", Offset = "0x23E7960", VA = "0x1823E9360", Slot = "4")]
		public Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> NLBGACKMFGH(TDeps OBBCAGMEJPG, TRoot MPEICFNBKOF, TSerializedAction EOHIGEJKHHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class EKCFHEEHBFD<TPayload, TOk, TErr> : NDEDJJKOMOM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MNMNGBCAHAO
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BJFKHEACFGN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78B4D0", Offset = "0x78A8D0")]
			public AsyncTaskMethodBuilder<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>t__builder;

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
			public EKCFHEEHBFD<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78B530", Offset = "0x78A930")]
			private EGKNCMFMAMB<object, MNMNGBCAHAO> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78B590", Offset = "0x78A990")]
			private OKGLFCLBNDC<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78B5F0", Offset = "0x78A9F0")]
			private EGKNCMFMAMB<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78B650", Offset = "0x78AA50")]
			private EGKNCMFMAMB<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x78B6B0", Offset = "0x78AAB0")]
			private TaskAwaiter<EGKNCMFMAMB<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public BJFKHEACFGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3927060", Offset = "0x3925660", VA = "0x183927060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly BEFPPBIDOJE<TActionKind, TSerializedAction, TPayload> EKLLOMIHFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly HKCFFBAEBFL<TRoot, TPayload, TOk, TErr> NKDLDBDAHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool MCKDNKOLHLG;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x121C8B0", Offset = "0x121AEB0", VA = "0x18121C8B0")]
		public EKCFHEEHBFD(BEFPPBIDOJE<TActionKind, TSerializedAction, TPayload> HOHHALCKPFL, HKCFFBAEBFL<TRoot, TPayload, TOk, TErr> DCEPKHJKEOO, bool CIKFGGGANHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x121C130", Offset = "0x121A730", VA = "0x18121C130", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(EKCFHEEHBFD<, , >.BJFKHEACFGN))]
		public Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> NLBGACKMFGH(TDeps OBBCAGMEJPG, TRoot MPEICFNBKOF, TSerializedAction EOHIGEJKHHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DJGJPMCEGLD<TActionKind, TSerializedAction, TRoot, TDeps> CHGPCLAOCIH;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
	private FBMIPIIMLPA(DJGJPMCEGLD<TActionKind, TSerializedAction, TRoot, TDeps> GOMDNNCBLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1658DB0", Offset = "0x16573B0", VA = "0x181658DB0")]
	public static FBMIPIIMLPA<TActionKind, TSerializedAction, TRoot, TDeps> JBGFDEKBNPE()
	{
		return default(FBMIPIIMLPA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1990F30", Offset = "0x198F530", VA = "0x181990F30")]
	public FBMIPIIMLPA<TActionKind, TSerializedAction, TRoot, TDeps> GAJMBLHGNCM<TPayload, TOk, TErr>(TActionKind JGLPCLKCOBD, BEFPPBIDOJE<TActionKind, TSerializedAction, TPayload> HOHHALCKPFL, LFOJJMAGGGH<TRoot, TPayload, TOk, TErr> DCEPKHJKEOO, bool CIKFGGGANHA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MNMNGBCAHAO
	{
		return default(FBMIPIIMLPA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1990F30", Offset = "0x198F530", VA = "0x181990F30")]
	public FBMIPIIMLPA<TActionKind, TSerializedAction, TRoot, TDeps> CBPELPOIHFO<TPayload, TOk, TErr>(TActionKind JGLPCLKCOBD, BEFPPBIDOJE<TActionKind, TSerializedAction, TPayload> HOHHALCKPFL, HKCFFBAEBFL<TRoot, TPayload, TOk, TErr> DCEPKHJKEOO, bool CIKFGGGANHA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MNMNGBCAHAO
	{
		return default(FBMIPIIMLPA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1658E40", Offset = "0x1657440", VA = "0x181658E40")]
	public CIPGBAGLIGA<TActionKind, TSerializedAction, TRoot, TDeps> OHMPHOIFEPD(TDeps OBBCAGMEJPG)
	{
		return default(CIPGBAGLIGA<TActionKind, TSerializedAction, TRoot, TDeps>);
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
