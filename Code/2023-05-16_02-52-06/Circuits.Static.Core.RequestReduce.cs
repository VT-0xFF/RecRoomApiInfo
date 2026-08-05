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
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xF0CA10", Offset = "0xF0B810", VA = "0x180F0CA10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate global::JLCGFKKDKNA<TActionKind, TPayload> HFEJLONGFMJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction LJKIFKFGKPK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface KJHDKHDCCNJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> KJJDIMPOPGE(TDeps HJHJNAMIAKE, TRoot LFLMFMLCFKL, TSerializedAction LJKIFKFGKPK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JOHFFODNFLC<TActionKind, TSerializedAction, TRoot, TDeps> : LGBLFKJLIPF where TDeps : HJMPGKAJHMC.OLBGHBALDOL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps DDAEJNDNJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction AGENDNDFLPC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x233D580", Offset = "0x233C380", VA = "0x18233D580")]
	public JOHFFODNFLC(in TDeps HJHJNAMIAKE, in TSerializedAction LJKIFKFGKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x233D350", Offset = "0x233C150", VA = "0x18233D350", Slot = "7")]
	public override string HKMFFLPHOOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JLCGFKKDKNA<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BNBLHMJAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload NLCMIFCKBPJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x26C52A0", Offset = "0x26C40A0", VA = "0x1826C52A0")]
	internal JLCGFKKDKNA(TActionKind PBFONJCHEPI, in TPayload HIHKKNOLPAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KDDAPGDAMBO
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x16560B0", Offset = "0x1654EB0", VA = "0x1816560B0")]
	public static global::JLCGFKKDKNA<TActionKind, TPayload> AIJMFKKLHCC<TActionKind, TPayload>(in TActionKind PBFONJCHEPI, in TPayload HIHKKNOLPAP)
	{
		return default(global::JLCGFKKDKNA<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<global::AEGPCPFJGKN<TOk, TErr>> KGMICAPHGEE<TRoot, TPayload, TOk, TErr>(TRoot LFLMFMLCFKL, TPayload HIHKKNOLPAP);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate global::AEGPCPFJGKN<TOk, TErr> JEPNDCBMCOG<TRoot, TPayload, TOk, TErr>(TRoot LFLMFMLCFKL, in TPayload HIHKKNOLPAP);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BHDGHHONPJN<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : HJMPGKAJHMC.OLBGHBALDOL<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JDCGPMKLJPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::BHDGHHONPJN<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x35FE610", Offset = "0x35FD410", VA = "0x1835FE610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x35FEDD0", Offset = "0x35FDBD0", VA = "0x1835FEDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, global::KJHDKHDCCNJ<TSerializedAction, TRoot, TDeps>> LIHPOEIPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps DDAEJNDNJLK;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x809110", Offset = "0x807F10", VA = "0x180809110")]
	internal BHDGHHONPJN(Dictionary<TActionKind, global::KJHDKHDCCNJ<TSerializedAction, TRoot, TDeps>> INNDHNPAIDJ, TDeps HJHJNAMIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2C94570", Offset = "0x2C93370", VA = "0x182C94570")]
	[AsyncStateMachine(typeof(global::BHDGHHONPJN<, , , >.JDCGPMKLJPH))]
	public Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> KJJDIMPOPGE(TRoot LFLMFMLCFKL, TSerializedAction LJKIFKFGKPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HJMPGKAJHMC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OLBGHBALDOL<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind AILMEGIKEEI(TSerializedAction LCNEHOGIJPK);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EKJKCBIDHEH(TRoot LFLMFMLCFKL, TSerializedAction JBJAGOLOBKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2663950", Offset = "0x2662750", VA = "0x182663950")]
	internal static global::BHDGHHONPJN<TActionKind, TSerializedAction, TRoot, TDeps> AIJMFKKLHCC<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, global::KJHDKHDCCNJ<TSerializedAction, TRoot, TDeps>> INNDHNPAIDJ, TDeps HJHJNAMIAKE) where TDeps : OLBGHBALDOL<TActionKind, TSerializedAction, TRoot>
	{
		return default(global::BHDGHHONPJN<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BKAGAPDGLGF<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, global::KJHDKHDCCNJ<TSerializedAction, TRoot, TDeps>> APDLMEIEEJN;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1050770", Offset = "0x104F570", VA = "0x181050770")]
	private BKAGAPDGLGF(Dictionary<TActionKind, global::KJHDKHDCCNJ<TSerializedAction, TRoot, TDeps>> INNDHNPAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C98070", Offset = "0x2C96E70", VA = "0x182C98070")]
	public static global::BKAGAPDGLGF<TActionKind, TSerializedAction, TRoot, TDeps> AIJMFKKLHCC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LFCDBNLOFHL<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, HJMPGKAJHMC.OLBGHBALDOL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class KODEMJGJBOG<TPayload, TOk, TErr> : global::KJHDKHDCCNJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MKFDOIHNKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly global::HFEJLONGFMJ<TActionKind, TSerializedAction, TPayload> HKBCPBHIING;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly global::JEPNDCBMCOG<TRoot, TPayload, TOk, TErr> MMCLOPBBNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool IDKLFANHHNM;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x301C7C0", Offset = "0x301B5C0", VA = "0x18301C7C0")]
		public KODEMJGJBOG(global::HFEJLONGFMJ<TActionKind, TSerializedAction, TPayload> CDPMFNIONAG, global::JEPNDCBMCOG<TRoot, TPayload, TOk, TErr> HPBGBJAMKJL, bool OBKFPCIJNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x301CD90", Offset = "0x301BB90", VA = "0x18301CD90", Slot = "4")]
		public Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> KJJDIMPOPGE(TDeps HJHJNAMIAKE, TRoot LFLMFMLCFKL, TSerializedAction LJKIFKFGKPK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KNPFGPNBANC<TPayload, TOk, TErr> : global::KJHDKHDCCNJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MKFDOIHNKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly global::HFEJLONGFMJ<TActionKind, TSerializedAction, TPayload> HKBCPBHIING;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly global::KGMICAPHGEE<TRoot, TPayload, TOk, TErr> MMCLOPBBNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool IDKLFANHHNM;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x301C7C0", Offset = "0x301B5C0", VA = "0x18301C7C0")]
		public KNPFGPNBANC(global::HFEJLONGFMJ<TActionKind, TSerializedAction, TPayload> CDPMFNIONAG, global::KGMICAPHGEE<TRoot, TPayload, TOk, TErr> HPBGBJAMKJL, bool OBKFPCIJNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x301C650", Offset = "0x301B450", VA = "0x18301C650", Slot = "4")]
		[AsyncStateMachine(typeof(NMENMNKFNKG))]
		public Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> KJJDIMPOPGE(TDeps HJHJNAMIAKE, TRoot LFLMFMLCFKL, TSerializedAction LJKIFKFGKPK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly global::BKAGAPDGLGF<TActionKind, TSerializedAction, TRoot, TDeps> PGGHIALJNHH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x918E40", Offset = "0x917C40", VA = "0x180918E40")]
	private LFCDBNLOFHL(global::BKAGAPDGLGF<TActionKind, TSerializedAction, TRoot, TDeps> MMJOHADFCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE730", Offset = "0x2BED530", VA = "0x182BEE730")]
	public static global::LFCDBNLOFHL<TActionKind, TSerializedAction, TRoot, TDeps> AIJMFKKLHCC()
	{
		return default(global::LFCDBNLOFHL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1BED2D0", Offset = "0x1BEC0D0", VA = "0x181BED2D0")]
	public global::LFCDBNLOFHL<TActionKind, TSerializedAction, TRoot, TDeps> PNFNKDJJIIF<TPayload, TOk, TErr>(TActionKind PBFONJCHEPI, global::HFEJLONGFMJ<TActionKind, TSerializedAction, TPayload> CDPMFNIONAG, global::JEPNDCBMCOG<TRoot, TPayload, TOk, TErr> HPBGBJAMKJL, bool OBKFPCIJNNP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MKFDOIHNKMJ
	{
		return default(global::LFCDBNLOFHL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1BED2D0", Offset = "0x1BEC0D0", VA = "0x181BED2D0")]
	public global::LFCDBNLOFHL<TActionKind, TSerializedAction, TRoot, TDeps> CGDFAMIMBLO<TPayload, TOk, TErr>(TActionKind PBFONJCHEPI, global::HFEJLONGFMJ<TActionKind, TSerializedAction, TPayload> CDPMFNIONAG, global::KGMICAPHGEE<TRoot, TPayload, TOk, TErr> HPBGBJAMKJL, bool OBKFPCIJNNP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MKFDOIHNKMJ
	{
		return default(global::LFCDBNLOFHL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE7D0", Offset = "0x2BED5D0", VA = "0x182BEE7D0")]
	public global::BHDGHHONPJN<TActionKind, TSerializedAction, TRoot, TDeps> MLNNFPABIPN(TDeps HJHJNAMIAKE)
	{
		return default(global::BHDGHHONPJN<TActionKind, TSerializedAction, TRoot, TDeps>);
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
