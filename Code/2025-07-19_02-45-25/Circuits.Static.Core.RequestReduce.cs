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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A5AFB0", Offset = "0x2A59FB0", VA = "0x182A5AFB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate MCLIEMBCOMM<TActionKind, TPayload> NCMEONMLICK<TActionKind, TSerializedAction, TPayload>(TSerializedAction NDBDBFGPPBG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface BMOJGMLDIGM<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DAFIFKKNPFP<object, AGMCGONFHKP>> HJKJFNFILNC(TDeps APEKGFIAPNC, TRoot NKBKNNLLHKF, TSerializedAction NDBDBFGPPBG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BGKDBIDBIMK<TActionKind, TSerializedAction, TRoot, TDeps> : NFLHKGJKCPB where TDeps : FNCDEJOHKBL.OEOEAPIGJAO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps AEIHNHECOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction IOHCMOHPIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6433B10", Offset = "0x6432B10", VA = "0x186433B10")]
	public BGKDBIDBIMK([In] TDeps APEKGFIAPNC, [In] TSerializedAction NDBDBFGPPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6433A40", Offset = "0x6432A40", VA = "0x186433A40", Slot = "7")]
	public override string OFBAEHEOPOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct MCLIEMBCOMM<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind MOKEPILBBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload PBMDBLKBENO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5699120", Offset = "0x5698120", VA = "0x185699120")]
	internal MCLIEMBCOMM(TActionKind OIEPFAKFIBM, [In] TPayload MBAGIDFJGJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PFBPENEOEKE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E37AE0", Offset = "0x3E36AE0", VA = "0x183E37AE0")]
	public static MCLIEMBCOMM<TActionKind, TPayload> MPFKOOIPONO<TActionKind, TPayload>([In] TActionKind OIEPFAKFIBM, [In] TPayload MBAGIDFJGJL)
	{
		return default(MCLIEMBCOMM<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<DAFIFKKNPFP<TOk, TErr>> KNIDGOCLLLH<TRoot, TPayload, TOk, TErr>(TRoot NKBKNNLLHKF, TPayload MBAGIDFJGJL);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate DAFIFKKNPFP<TOk, TErr> IGAIMCHFDDI<TRoot, TPayload, TOk, TErr>(TRoot NKBKNNLLHKF, [In] TPayload MBAGIDFJGJL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NKAEGKCHLIM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : FNCDEJOHKBL.OEOEAPIGJAO<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BHPAOJFCJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<object?, AGMCGONFHKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NKAEGKCHLIM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<DAFIFKKNPFP<object, AGMCGONFHKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x643BE40", Offset = "0x643AE40", VA = "0x18643BE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x643C2C0", Offset = "0x643B2C0", VA = "0x18643C2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, BMOJGMLDIGM<TSerializedAction, TRoot, TDeps>> BNNJCCLJOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps AEIHNHECOOB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
	internal NKAEGKCHLIM(Dictionary<TActionKind, BMOJGMLDIGM<TSerializedAction, TRoot, TDeps>> PANCDDFIEMP, TDeps APEKGFIAPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5793D80", Offset = "0x5792D80", VA = "0x185793D80")]
	[AsyncStateMachine(typeof(NKAEGKCHLIM<, , , >.BHPAOJFCJOJ))]
	public Task<DAFIFKKNPFP<object, AGMCGONFHKP>> HJKJFNFILNC(TRoot NKBKNNLLHKF, TSerializedAction NDBDBFGPPBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FNCDEJOHKBL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OEOEAPIGJAO<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind JAMGDMGPLKD(TSerializedAction OLHDOIOOPGE);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GJBFODHLKEM(TRoot NKBKNNLLHKF, TSerializedAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BDADFIDMEBJ(TRoot NKBKNNLLHKF, TSerializedAction DMHPHEGJKMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C2FEE0", Offset = "0x3C2EEE0", VA = "0x183C2FEE0")]
	internal static NKAEGKCHLIM<TActionKind, TSerializedAction, TRoot, TDeps> MPFKOOIPONO<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, BMOJGMLDIGM<TSerializedAction, TRoot, TDeps>> PANCDDFIEMP, TDeps APEKGFIAPNC) where TDeps : OEOEAPIGJAO<TActionKind, TSerializedAction, TRoot>
	{
		return default(NKAEGKCHLIM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NOCOMEHIGNK<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, BMOJGMLDIGM<TSerializedAction, TRoot, TDeps>> FCEAKFNECCK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	private NOCOMEHIGNK(Dictionary<TActionKind, BMOJGMLDIGM<TSerializedAction, TRoot, TDeps>> PANCDDFIEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x579DA20", Offset = "0x579CA20", VA = "0x18579DA20")]
	public static NOCOMEHIGNK<TActionKind, TSerializedAction, TRoot, TDeps> MPFKOOIPONO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GBFIJCNBFII<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, FNCDEJOHKBL.OEOEAPIGJAO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LKCCCFBIAOF<TPayload, TOk, TErr> : BMOJGMLDIGM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AGMCGONFHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly NCMEONMLICK<TActionKind, TSerializedAction, TPayload> CILDIOIJPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly IGAIMCHFDDI<TRoot, TPayload, TOk, TErr> PNNLFDJMIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool AHLJHOJAFKA;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1C091C0", Offset = "0x1C081C0", VA = "0x181C091C0")]
		public LKCCCFBIAOF(NCMEONMLICK<TActionKind, TSerializedAction, TPayload> OGNBOOEDAKJ, IGAIMCHFDDI<TRoot, TPayload, TOk, TErr> COFHECLDADO, bool CBGGHIKMAGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x54856C0", Offset = "0x54846C0", VA = "0x1854856C0", Slot = "4")]
		public Task<DAFIFKKNPFP<object, AGMCGONFHKP>> HJKJFNFILNC(TDeps APEKGFIAPNC, TRoot NKBKNNLLHKF, TSerializedAction NDBDBFGPPBG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class EMAHFKOLEDE<TPayload, TOk, TErr> : BMOJGMLDIGM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AGMCGONFHKP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct AKNGABGFFMM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<DAFIFKKNPFP<object?, AGMCGONFHKP>> <>t__builder;

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
			public EMAHFKOLEDE<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private DAFIFKKNPFP<object?, AGMCGONFHKP> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DAFIFKKNPFP<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x526D8E0", Offset = "0x526C8E0", VA = "0x18526D8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x526F420", Offset = "0x526E420", VA = "0x18526F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly NCMEONMLICK<TActionKind, TSerializedAction, TPayload> CILDIOIJPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly KNIDGOCLLLH<TRoot, TPayload, TOk, TErr> PNNLFDJMIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool AHLJHOJAFKA;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1C091C0", Offset = "0x1C081C0", VA = "0x181C091C0")]
		public EMAHFKOLEDE(NCMEONMLICK<TActionKind, TSerializedAction, TPayload> OGNBOOEDAKJ, KNIDGOCLLLH<TRoot, TPayload, TOk, TErr> COFHECLDADO, bool CBGGHIKMAGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4919B80", Offset = "0x4918B80", VA = "0x184919B80", Slot = "4")]
		[AsyncStateMachine(typeof(EMAHFKOLEDE<, , >.AKNGABGFFMM))]
		public Task<DAFIFKKNPFP<object, AGMCGONFHKP>> HJKJFNFILNC(TDeps APEKGFIAPNC, TRoot NKBKNNLLHKF, TSerializedAction NDBDBFGPPBG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NOCOMEHIGNK<TActionKind, TSerializedAction, TRoot, TDeps> LGHFMHICOPJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4F960", VA = "0x180E50960")]
	private GBFIJCNBFII(NOCOMEHIGNK<TActionKind, TSerializedAction, TRoot, TDeps> INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E4CA50", Offset = "0x4E4BA50", VA = "0x184E4CA50")]
	public static GBFIJCNBFII<TActionKind, TSerializedAction, TRoot, TDeps> MPFKOOIPONO()
	{
		return default(GBFIJCNBFII<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D72290", Offset = "0x3D71290", VA = "0x183D72290")]
	public GBFIJCNBFII<TActionKind, TSerializedAction, TRoot, TDeps> BIOGOMINPLM<TPayload, TOk, TErr>(TActionKind OIEPFAKFIBM, NCMEONMLICK<TActionKind, TSerializedAction, TPayload> OGNBOOEDAKJ, IGAIMCHFDDI<TRoot, TPayload, TOk, TErr> COFHECLDADO, bool CBGGHIKMAGM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AGMCGONFHKP
	{
		return default(GBFIJCNBFII<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D72290", Offset = "0x3D71290", VA = "0x183D72290")]
	public GBFIJCNBFII<TActionKind, TSerializedAction, TRoot, TDeps> PHAANDAINEE<TPayload, TOk, TErr>(TActionKind OIEPFAKFIBM, NCMEONMLICK<TActionKind, TSerializedAction, TPayload> OGNBOOEDAKJ, KNIDGOCLLLH<TRoot, TPayload, TOk, TErr> COFHECLDADO, bool CBGGHIKMAGM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AGMCGONFHKP
	{
		return default(GBFIJCNBFII<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E4C9A0", Offset = "0x4E4B9A0", VA = "0x184E4C9A0")]
	public NKAEGKCHLIM<TActionKind, TSerializedAction, TRoot, TDeps> KJPCIMAPFIP(TDeps APEKGFIAPNC)
	{
		return default(NKAEGKCHLIM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
