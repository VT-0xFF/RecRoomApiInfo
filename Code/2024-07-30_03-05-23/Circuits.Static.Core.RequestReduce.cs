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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x20164C0", Offset = "0x2014AC0", VA = "0x1820164C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate HPKKLOLKELF<TActionKind, TPayload> PJABABFNLAE<TActionKind, TSerializedAction, TPayload>(TSerializedAction FFBKFPCICCE);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface FDHMNGJEJEK<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CBDPDIPONCF<object, FBDDJIHDMAI>> MIMELGANJCJ(TDeps BPGHBBHBELB, TRoot OPJBDKMKMOF, TSerializedAction FFBKFPCICCE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CPKDFMIENCP<TActionKind, TSerializedAction, TRoot, TDeps> : IFONDHBKBCD where TDeps : JJGBIGJGLEO.DCMFKDFHIDD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps IMCLEPLPDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction AKAPAPOCHEN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x569BE60", Offset = "0x569A460", VA = "0x18569BE60")]
	public CPKDFMIENCP([In] TDeps BPGHBBHBELB, [In] TSerializedAction FFBKFPCICCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x569BC90", Offset = "0x569A290", VA = "0x18569BC90", Slot = "7")]
	public override string AFLHKEIDPKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HPKKLOLKELF<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind EMKOLLHIKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload BAMLPGNFGMC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA5C0", Offset = "0x3DB8BC0", VA = "0x183DBA5C0")]
	internal HPKKLOLKELF(TActionKind OKCLONGGCGC, [In] TPayload OGADPHAKNMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PLGJHKINCED
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CF80", Offset = "0x2D2B580", VA = "0x182D2CF80")]
	public static HPKKLOLKELF<TActionKind, TPayload> ENFOKLPNHAF<TActionKind, TPayload>([In] TActionKind OKCLONGGCGC, [In] TPayload OGADPHAKNMI)
	{
		return default(HPKKLOLKELF<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<CBDPDIPONCF<TOk, TErr>> PGAFOOBIDOE<TRoot, TPayload, TOk, TErr>(TRoot OPJBDKMKMOF, TPayload OGADPHAKNMI);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate CBDPDIPONCF<TOk, TErr> OAHNMGAKGFJ<TRoot, TPayload, TOk, TErr>(TRoot OPJBDKMKMOF, [In] TPayload OGADPHAKNMI);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DALDOBJLHKC<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : JJGBIGJGLEO.DCMFKDFHIDD<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct POMBNHMHMLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public DALDOBJLHKC<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4803730", Offset = "0x4801D30", VA = "0x184803730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4804070", Offset = "0x4802670", VA = "0x184804070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, FDHMNGJEJEK<TSerializedAction, TRoot, TDeps>> NGAPHMODPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps IMCLEPLPDAM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
	internal DALDOBJLHKC(Dictionary<TActionKind, FDHMNGJEJEK<TSerializedAction, TRoot, TDeps>> ALMMIBJECHD, TDeps BPGHBBHBELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x58A7EF0", Offset = "0x58A64F0", VA = "0x1858A7EF0")]
	[AsyncStateMachine(typeof(DALDOBJLHKC<, , , >.POMBNHMHMLC))]
	public Task<CBDPDIPONCF<object, FBDDJIHDMAI>> MIMELGANJCJ(TRoot OPJBDKMKMOF, TSerializedAction FFBKFPCICCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JJGBIGJGLEO
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DCMFKDFHIDD<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind FPOPJGIPLPD(TSerializedAction HLIDMKMINHN);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GAGHMKLMHJA(TRoot OPJBDKMKMOF, TSerializedAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MIAFMEBANBD(TRoot OPJBDKMKMOF, TSerializedAction PEMICEIPPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B85870", Offset = "0x2B83E70", VA = "0x182B85870")]
	internal static DALDOBJLHKC<TActionKind, TSerializedAction, TRoot, TDeps> ENFOKLPNHAF<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, FDHMNGJEJEK<TSerializedAction, TRoot, TDeps>> ALMMIBJECHD, TDeps BPGHBBHBELB) where TDeps : DCMFKDFHIDD<TActionKind, TSerializedAction, TRoot>
	{
		return default(DALDOBJLHKC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class JKGFFGCJIEI<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, FDHMNGJEJEK<TSerializedAction, TRoot, TDeps>> MFOPCBHHKMD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	private JKGFFGCJIEI(Dictionary<TActionKind, FDHMNGJEJEK<TSerializedAction, TRoot, TDeps>> ALMMIBJECHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4093C20", Offset = "0x4092220", VA = "0x184093C20")]
	public static JKGFFGCJIEI<TActionKind, TSerializedAction, TRoot, TDeps> ENFOKLPNHAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LCNOMMPGMCL<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, JJGBIGJGLEO.DCMFKDFHIDD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AIDGCKLIDBN<TPayload, TOk, TErr> : FDHMNGJEJEK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FBDDJIHDMAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PJABABFNLAE<TActionKind, TSerializedAction, TPayload> IGMHODIPHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly OAHNMGAKGFJ<TRoot, TPayload, TOk, TErr> NMKHEMJIPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool AGBJBLIKDPP;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5C40", Offset = "0x3CE4240", VA = "0x183CE5C40")]
		public AIDGCKLIDBN(PJABABFNLAE<TActionKind, TSerializedAction, TPayload> FIMIFDPHDGF, OAHNMGAKGFJ<TRoot, TPayload, TOk, TErr> DDCFDAHKPKL, bool EEDGFLIMDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3CDE5A0", Offset = "0x3CDCBA0", VA = "0x183CDE5A0", Slot = "4")]
		public Task<CBDPDIPONCF<object, FBDDJIHDMAI>> MIMELGANJCJ(TDeps BPGHBBHBELB, TRoot OPJBDKMKMOF, TSerializedAction FFBKFPCICCE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class IGCNJGBFJPO<TPayload, TOk, TErr> : FDHMNGJEJEK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FBDDJIHDMAI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DNDPNPCLDIP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<CBDPDIPONCF<object?, FBDDJIHDMAI>> <>t__builder;

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
			public IGCNJGBFJPO<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private CBDPDIPONCF<object?, FBDDJIHDMAI> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CBDPDIPONCF<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x58E1D50", Offset = "0x58E0350", VA = "0x1858E1D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x58E2CE0", Offset = "0x58E12E0", VA = "0x1858E2CE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly PJABABFNLAE<TActionKind, TSerializedAction, TPayload> IGMHODIPHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly PGAFOOBIDOE<TRoot, TPayload, TOk, TErr> NMKHEMJIPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool AGBJBLIKDPP;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5C40", Offset = "0x3CE4240", VA = "0x183CE5C40")]
		public IGCNJGBFJPO(PJABABFNLAE<TActionKind, TSerializedAction, TPayload> FIMIFDPHDGF, PGAFOOBIDOE<TRoot, TPayload, TOk, TErr> DDCFDAHKPKL, bool EEDGFLIMDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E68D10", Offset = "0x3E67310", VA = "0x183E68D10", Slot = "4")]
		[AsyncStateMachine(typeof(IGCNJGBFJPO<, , >.DNDPNPCLDIP))]
		public Task<CBDPDIPONCF<object, FBDDJIHDMAI>> MIMELGANJCJ(TDeps BPGHBBHBELB, TRoot OPJBDKMKMOF, TSerializedAction FFBKFPCICCE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JKGFFGCJIEI<TActionKind, TSerializedAction, TRoot, TDeps> HCGFEAPJOAO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	private LCNOMMPGMCL(JKGFFGCJIEI<TActionKind, TSerializedAction, TRoot, TDeps> MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42BA4F0", Offset = "0x42B8AF0", VA = "0x1842BA4F0")]
	public static LCNOMMPGMCL<TActionKind, TSerializedAction, TRoot, TDeps> ENFOKLPNHAF()
	{
		return default(LCNOMMPGMCL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC8A0", Offset = "0x2ADAEA0", VA = "0x182ADC8A0")]
	public LCNOMMPGMCL<TActionKind, TSerializedAction, TRoot, TDeps> GCELJOOJCBK<TPayload, TOk, TErr>(TActionKind OKCLONGGCGC, PJABABFNLAE<TActionKind, TSerializedAction, TPayload> FIMIFDPHDGF, OAHNMGAKGFJ<TRoot, TPayload, TOk, TErr> DDCFDAHKPKL, bool EEDGFLIMDMA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FBDDJIHDMAI
	{
		return default(LCNOMMPGMCL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC8A0", Offset = "0x2ADAEA0", VA = "0x182ADC8A0")]
	public LCNOMMPGMCL<TActionKind, TSerializedAction, TRoot, TDeps> PIPIIBHKICO<TPayload, TOk, TErr>(TActionKind OKCLONGGCGC, PJABABFNLAE<TActionKind, TSerializedAction, TPayload> FIMIFDPHDGF, PGAFOOBIDOE<TRoot, TPayload, TOk, TErr> DDCFDAHKPKL, bool EEDGFLIMDMA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FBDDJIHDMAI
	{
		return default(LCNOMMPGMCL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42BA430", Offset = "0x42B8A30", VA = "0x1842BA430")]
	public DALDOBJLHKC<TActionKind, TSerializedAction, TRoot, TDeps> CHPBHFGPOPP(TDeps BPGHBBHBELB)
	{
		return default(DALDOBJLHKC<TActionKind, TSerializedAction, TRoot, TDeps>);
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
