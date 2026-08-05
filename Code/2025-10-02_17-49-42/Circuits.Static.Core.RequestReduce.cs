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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B7AAA0", Offset = "0x2B794A0", VA = "0x182B7AAA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate CBFKFEPLIFB<TActionKind, TPayload> OMBJOCJGPHM<TActionKind, TSerializedAction, TPayload>(TSerializedAction HKIOFJEOBAA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface CAEJPIIKOPN<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FEENKEDBOAD<object, DDLDMBFFDDA>> NDJMDCDHPJB(TDeps KPEJCAGFLDG, TRoot FAIGKPPBFHA, TSerializedAction HKIOFJEOBAA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BJOBGBPBNNN<TActionKind, TSerializedAction, TRoot, TDeps> : ICFOIJPFHAE where TDeps : HKNMNBDDBJB.NFPHANOBFEI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps KLALHCJBOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction CFOCPGPDKJO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6775C20", Offset = "0x6774620", VA = "0x186775C20")]
	public BJOBGBPBNNN([In] TDeps KPEJCAGFLDG, [In] TSerializedAction HKIOFJEOBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6775AF0", Offset = "0x67744F0", VA = "0x186775AF0", Slot = "7")]
	public override string NGBNCIGPFCK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CBFKFEPLIFB<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind OJHHABBMFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload GMIHGDDJAOL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8640", Offset = "0x6BF7040", VA = "0x186BF8640")]
	internal CBFKFEPLIFB(TActionKind CPDIKIAEILO, [In] TPayload IHHGLEDNONA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MCOCHCLKOFD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E955C0", Offset = "0x3E93FC0", VA = "0x183E955C0")]
	public static CBFKFEPLIFB<TActionKind, TPayload> KDBDJPAJKDJ<TActionKind, TPayload>([In] TActionKind CPDIKIAEILO, [In] TPayload IHHGLEDNONA)
	{
		return default(CBFKFEPLIFB<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<FEENKEDBOAD<TOk, TErr>> KGPGDPCGGIL<TRoot, TPayload, TOk, TErr>(TRoot FAIGKPPBFHA, TPayload IHHGLEDNONA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate FEENKEDBOAD<TOk, TErr> CAGGDFGNBIJ<TRoot, TPayload, TOk, TErr>(TRoot FAIGKPPBFHA, [In] TPayload IHHGLEDNONA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PPIFIGNEKJM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : HKNMNBDDBJB.NFPHANOBFEI<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KEBPJANPDAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<object?, DDLDMBFFDDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PPIFIGNEKJM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<FEENKEDBOAD<object, DDLDMBFFDDA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x564AA80", Offset = "0x5649480", VA = "0x18564AA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x564AF00", Offset = "0x5649900", VA = "0x18564AF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, CAEJPIIKOPN<TSerializedAction, TRoot, TDeps>> DGIFHGMFEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps KLALHCJBOKG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
	internal PPIFIGNEKJM(Dictionary<TActionKind, CAEJPIIKOPN<TSerializedAction, TRoot, TDeps>> PGMBOCPDCJJ, TDeps KPEJCAGFLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CD7D90", Offset = "0x5CD6790", VA = "0x185CD7D90")]
	[AsyncStateMachine(typeof(PPIFIGNEKJM<, , , >.KEBPJANPDAH))]
	public Task<FEENKEDBOAD<object, DDLDMBFFDDA>> NDJMDCDHPJB(TRoot FAIGKPPBFHA, TSerializedAction HKIOFJEOBAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HKNMNBDDBJB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NFPHANOBFEI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind NPAAJEONFKO(TSerializedAction DKGBCFDLMOI);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GPBEMDKFFJH(TRoot FAIGKPPBFHA, TSerializedAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CIHPIGEFPDM(TRoot FAIGKPPBFHA, TSerializedAction FCCCPABHDPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x32D28B0", Offset = "0x32D12B0", VA = "0x1832D28B0")]
	internal static PPIFIGNEKJM<TActionKind, TSerializedAction, TRoot, TDeps> KDBDJPAJKDJ<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, CAEJPIIKOPN<TSerializedAction, TRoot, TDeps>> PGMBOCPDCJJ, TDeps KPEJCAGFLDG) where TDeps : NFPHANOBFEI<TActionKind, TSerializedAction, TRoot>
	{
		return default(PPIFIGNEKJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class IACILLDAJJF<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, CAEJPIIKOPN<TSerializedAction, TRoot, TDeps>> IAAIHJECEGK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	private IACILLDAJJF(Dictionary<TActionKind, CAEJPIIKOPN<TSerializedAction, TRoot, TDeps>> PGMBOCPDCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x52CA450", Offset = "0x52C8E50", VA = "0x1852CA450")]
	public static IACILLDAJJF<TActionKind, TSerializedAction, TRoot, TDeps> KDBDJPAJKDJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DAENPBBOCJE<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, HKNMNBDDBJB.NFPHANOBFEI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MLAKGOOMBCF<TPayload, TOk, TErr> : CAEJPIIKOPN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DDLDMBFFDDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OMBJOCJGPHM<TActionKind, TSerializedAction, TPayload> KDALCPAHFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CAGGDFGNBIJ<TRoot, TPayload, TOk, TErr> ICEACACIIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool IHIJEGFNOKL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1D00DE0", Offset = "0x1CFF7E0", VA = "0x181D00DE0")]
		public MLAKGOOMBCF(OMBJOCJGPHM<TActionKind, TSerializedAction, TPayload> FIBOMOCCLBP, CAGGDFGNBIJ<TRoot, TPayload, TOk, TErr> IBPNMPGNOOI, bool ALDLNGGBCIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x59A25B0", Offset = "0x59A0FB0", VA = "0x1859A25B0", Slot = "4")]
		public Task<FEENKEDBOAD<object, DDLDMBFFDDA>> NDJMDCDHPJB(TDeps KPEJCAGFLDG, TRoot FAIGKPPBFHA, TSerializedAction HKIOFJEOBAA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class CJMBMADFEJA<TPayload, TOk, TErr> : CAEJPIIKOPN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DDLDMBFFDDA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct LKJAHEGAFAL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<FEENKEDBOAD<object?, DDLDMBFFDDA>> <>t__builder;

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
			public CJMBMADFEJA<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private FEENKEDBOAD<object?, DDLDMBFFDDA> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<FEENKEDBOAD<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x573E6E0", Offset = "0x573D0E0", VA = "0x18573E6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x573F4D0", Offset = "0x573DED0", VA = "0x18573F4D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OMBJOCJGPHM<TActionKind, TSerializedAction, TPayload> KDALCPAHFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly KGPGDPCGGIL<TRoot, TPayload, TOk, TErr> ICEACACIIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool IHIJEGFNOKL;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1D00DE0", Offset = "0x1CFF7E0", VA = "0x181D00DE0")]
		public CJMBMADFEJA(OMBJOCJGPHM<TActionKind, TSerializedAction, TPayload> FIBOMOCCLBP, KGPGDPCGGIL<TRoot, TPayload, TOk, TErr> IBPNMPGNOOI, bool ALDLNGGBCIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6CE9D80", Offset = "0x6CE8780", VA = "0x186CE9D80", Slot = "4")]
		[AsyncStateMachine(typeof(CJMBMADFEJA<, , >.LKJAHEGAFAL))]
		public Task<FEENKEDBOAD<object, DDLDMBFFDDA>> NDJMDCDHPJB(TDeps KPEJCAGFLDG, TRoot FAIGKPPBFHA, TSerializedAction HKIOFJEOBAA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IACILLDAJJF<TActionKind, TSerializedAction, TRoot, TDeps> CPMOFDFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
	private DAENPBBOCJE(IACILLDAJJF<TActionKind, TSerializedAction, TRoot, TDeps> BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x45CFE00", Offset = "0x45CE800", VA = "0x1845CFE00")]
	public static DAENPBBOCJE<TActionKind, TSerializedAction, TRoot, TDeps> KDBDJPAJKDJ()
	{
		return default(DAENPBBOCJE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F28C80", Offset = "0x3F27680", VA = "0x183F28C80")]
	public DAENPBBOCJE<TActionKind, TSerializedAction, TRoot, TDeps> MFCEKPCCEAL<TPayload, TOk, TErr>(TActionKind CPDIKIAEILO, OMBJOCJGPHM<TActionKind, TSerializedAction, TPayload> FIBOMOCCLBP, CAGGDFGNBIJ<TRoot, TPayload, TOk, TErr> IBPNMPGNOOI, bool ALDLNGGBCIH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DDLDMBFFDDA
	{
		return default(DAENPBBOCJE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F28C80", Offset = "0x3F27680", VA = "0x183F28C80")]
	public DAENPBBOCJE<TActionKind, TSerializedAction, TRoot, TDeps> GOIBEACCEKD<TPayload, TOk, TErr>(TActionKind CPDIKIAEILO, OMBJOCJGPHM<TActionKind, TSerializedAction, TPayload> FIBOMOCCLBP, KGPGDPCGGIL<TRoot, TPayload, TOk, TErr> IBPNMPGNOOI, bool ALDLNGGBCIH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DDLDMBFFDDA
	{
		return default(DAENPBBOCJE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x45CFE90", Offset = "0x45CE890", VA = "0x1845CFE90")]
	public PPIFIGNEKJM<TActionKind, TSerializedAction, TRoot, TDeps> PKAPPLHNNJG(TDeps KPEJCAGFLDG)
	{
		return default(PPIFIGNEKJM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
