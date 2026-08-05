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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FFE610", Offset = "0x6FFCC10", VA = "0x186FFE610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct PELCPHJCILN<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind HMLOKFFFLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload LMEFIFKGFGJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F0F650", Offset = "0x1F0DC50", VA = "0x181F0F650")]
	internal PELCPHJCILN(TActionKind FAKJPMLEPNP, in TPayload GFHGIIOIPBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PIOIIJEGDBN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2308720", Offset = "0x2306D20", VA = "0x182308720")]
	public static PELCPHJCILN<TActionKind, TPayload> OGNDBCBGIDA<TActionKind, TPayload>(in TActionKind FAKJPMLEPNP, in TPayload GFHGIIOIPBN)
	{
		return default(PELCPHJCILN<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface FJDCFMGMHJI<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GLOEKJIOMHK<object, EKJAOIMOODA>> GKDMFBNGFFM(TDeps IAFBKNNAACG, TRoot AIMNENJKCBP, TSerializedAction HCPDOEIDHDM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct AGPOGEDCCII<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : ILLEHKNENGB.MIACHIBEEKI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OJBJBNCDHPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<object, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AGPOGEDCCII<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private FJDCFMGMHJI<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public OJBJBNCDHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2F32DD0", Offset = "0x2F313D0", VA = "0x182F32DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, FJDCFMGMHJI<TSerializedAction, TRoot, TDeps>> GNDJEMBFOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps FGEFLJHGFAG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xBEFA40", Offset = "0xBEE040", VA = "0x180BEFA40")]
	internal AGPOGEDCCII(Dictionary<TActionKind, FJDCFMGMHJI<TSerializedAction, TRoot, TDeps>> INLPBMHBCHK, TDeps IAFBKNNAACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29E2CA0", Offset = "0x29E12A0", VA = "0x1829E2CA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGPOGEDCCII<, , , >.OJBJBNCDHPN))]
	public Task<GLOEKJIOMHK<object, EKJAOIMOODA>> GKDMFBNGFFM(TRoot AIMNENJKCBP, TSerializedAction HCPDOEIDHDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class ILLEHKNENGB
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface MIACHIBEEKI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind GHLDCAHMBCP(TSerializedAction CDBMADFDGCE);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FCOKBJPDICD(TRoot AIMNENJKCBP, TSerializedAction ILLCNPCAHGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x11DF490", Offset = "0x11DDA90", VA = "0x1811DF490")]
	internal static AGPOGEDCCII<TActionKind, TSerializedAction, TRoot, TDeps> OGNDBCBGIDA<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, FJDCFMGMHJI<TSerializedAction, TRoot, TDeps>> INLPBMHBCHK, TDeps IAFBKNNAACG) where TDeps : MIACHIBEEKI<TActionKind, TSerializedAction, TRoot>
	{
		return default(AGPOGEDCCII<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate GLOEKJIOMHK<TOk, TErr> CGOCEHGDJIC<TRoot, TPayload, TOk, TErr>(TRoot AIMNENJKCBP, in TPayload GFHGIIOIPBN);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class GICNOPKNMIM<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, FJDCFMGMHJI<TSerializedAction, TRoot, TDeps>> PFMOLCIGAOA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F085A0", Offset = "0x1F06BA0", VA = "0x181F085A0")]
	private GICNOPKNMIM(Dictionary<TActionKind, FJDCFMGMHJI<TSerializedAction, TRoot, TDeps>> INLPBMHBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24EC2B0", Offset = "0x24EA8B0", VA = "0x1824EC2B0")]
	public static GICNOPKNMIM<TActionKind, TSerializedAction, TRoot, TDeps> OGNDBCBGIDA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<GLOEKJIOMHK<TOk, TErr>> HKNFKJEDJOP<TRoot, TPayload, TOk, TErr>(TRoot AIMNENJKCBP, TPayload GFHGIIOIPBN);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MHOAOLJPBBC<TActionKind, TSerializedAction, TRoot, TDeps> : EFMPBCAAJAD where TDeps : ILLEHKNENGB.MIACHIBEEKI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps FGEFLJHGFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction JBLPNIGOPNF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C330", Offset = "0x2B4A930", VA = "0x182B4C330")]
	public MHOAOLJPBBC(in TDeps IAFBKNNAACG, in TSerializedAction HCPDOEIDHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C160", Offset = "0x2B4A760", VA = "0x182B4C160", Slot = "7")]
	public override string KDCKINHCHKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate PELCPHJCILN<TActionKind, TPayload> HJPKJBMBHLD<TActionKind, TSerializedAction, TPayload>(TSerializedAction HCPDOEIDHDM);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct PPBNKPLHMKG<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, ILLEHKNENGB.MIACHIBEEKI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BBGINJHILKD<TPayload, TOk, TErr> : FJDCFMGMHJI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EKJAOIMOODA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HJPKJBMBHLD<TActionKind, TSerializedAction, TPayload> LGFMJKBEIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CGOCEHGDJIC<TRoot, TPayload, TOk, TErr> AKDBEOCPLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool BELMBPJILLE;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x250AE90", Offset = "0x2509490", VA = "0x18250AE90")]
		public BBGINJHILKD(HJPKJBMBHLD<TActionKind, TSerializedAction, TPayload> DJHLGKPEGIP, CGOCEHGDJIC<TRoot, TPayload, TOk, TErr> EALONOBGMGD, bool KMMAIHDLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2FEF930", Offset = "0x2FEDF30", VA = "0x182FEF930", Slot = "4")]
		public Task<GLOEKJIOMHK<object, EKJAOIMOODA>> GKDMFBNGFFM(TDeps IAFBKNNAACG, TRoot AIMNENJKCBP, TSerializedAction HCPDOEIDHDM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JJNMDKEACIP<TPayload, TOk, TErr> : FJDCFMGMHJI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EKJAOIMOODA
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CJBLBFDDFEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733C60", Offset = "0x733060")]
			public AsyncTaskMethodBuilder<GLOEKJIOMHK<object, EKJAOIMOODA>> <>t__builder;

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
			public JJNMDKEACIP<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733CC0", Offset = "0x7330C0")]
			private GLOEKJIOMHK<object, EKJAOIMOODA> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733D20", Offset = "0x733120")]
			private PELCPHJCILN<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733D80", Offset = "0x733180")]
			private GLOEKJIOMHK<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733DE0", Offset = "0x7331E0")]
			private GLOEKJIOMHK<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733E40", Offset = "0x733240")]
			private TaskAwaiter<GLOEKJIOMHK<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public CJBLBFDDFEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x29C6670", Offset = "0x29C4C70", VA = "0x1829C6670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly HJPKJBMBHLD<TActionKind, TSerializedAction, TPayload> LGFMJKBEIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly HKNFKJEDJOP<TRoot, TPayload, TOk, TErr> AKDBEOCPLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool BELMBPJILLE;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x250AE90", Offset = "0x2509490", VA = "0x18250AE90")]
		public JJNMDKEACIP(HJPKJBMBHLD<TActionKind, TSerializedAction, TPayload> DJHLGKPEGIP, HKNFKJEDJOP<TRoot, TPayload, TOk, TErr> EALONOBGMGD, bool KMMAIHDLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8010", Offset = "0x2CF6610", VA = "0x182CF8010", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(JJNMDKEACIP<, , >.CJBLBFDDFEA))]
		public Task<GLOEKJIOMHK<object, EKJAOIMOODA>> GKDMFBNGFFM(TDeps IAFBKNNAACG, TRoot AIMNENJKCBP, TSerializedAction HCPDOEIDHDM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly GICNOPKNMIM<TActionKind, TSerializedAction, TRoot, TDeps> LPFNCJMMFPB;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C05F0", VA = "0x1809C1FF0")]
	private PPBNKPLHMKG(GICNOPKNMIM<TActionKind, TSerializedAction, TRoot, TDeps> JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2242AE0", Offset = "0x22410E0", VA = "0x182242AE0")]
	public static PPBNKPLHMKG<TActionKind, TSerializedAction, TRoot, TDeps> OGNDBCBGIDA()
	{
		return default(PPBNKPLHMKG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1C92810", Offset = "0x1C90E10", VA = "0x181C92810")]
	public PPBNKPLHMKG<TActionKind, TSerializedAction, TRoot, TDeps> POADJAILDHH<TPayload, TOk, TErr>(TActionKind FAKJPMLEPNP, HJPKJBMBHLD<TActionKind, TSerializedAction, TPayload> DJHLGKPEGIP, CGOCEHGDJIC<TRoot, TPayload, TOk, TErr> EALONOBGMGD, bool KMMAIHDLKFG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EKJAOIMOODA
	{
		return default(PPBNKPLHMKG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1C92810", Offset = "0x1C90E10", VA = "0x181C92810")]
	public PPBNKPLHMKG<TActionKind, TSerializedAction, TRoot, TDeps> BAEPAIBKEPK<TPayload, TOk, TErr>(TActionKind FAKJPMLEPNP, HJPKJBMBHLD<TActionKind, TSerializedAction, TPayload> DJHLGKPEGIP, HKNFKJEDJOP<TRoot, TPayload, TOk, TErr> EALONOBGMGD, bool KMMAIHDLKFG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EKJAOIMOODA
	{
		return default(PPBNKPLHMKG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2242A30", Offset = "0x2241030", VA = "0x182242A30")]
	public AGPOGEDCCII<TActionKind, TSerializedAction, TRoot, TDeps> JFHEJCIOGOO(TDeps IAFBKNNAACG)
	{
		return default(AGPOGEDCCII<TActionKind, TSerializedAction, TRoot, TDeps>);
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
