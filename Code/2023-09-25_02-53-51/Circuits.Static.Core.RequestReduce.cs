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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C29BC0", Offset = "0x1C28FC0", VA = "0x181C29BC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
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
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate KEACEFCODEA<TActionKind, TPayload> KCFBMLJHAOD<TActionKind, TSerializedAction, TPayload>(TSerializedAction OLADKLAOCKF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface LGEAGJJPNGI<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> FMOCGKBELJJ(TDeps KELDMPHCCLC, TRoot JMNDOLBKAMN, TSerializedAction OLADKLAOCKF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DMMFIAAFENA<TActionKind, TSerializedAction, TRoot, TDeps> : PEPMMDADFIO where TDeps : OJLPDABNGCI.LHGAIJCJEMO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps BOAEKCBHIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction LMEFIPPLKKM;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4D1BFD0", Offset = "0x4D1B3D0", VA = "0x184D1BFD0")]
	public DMMFIAAFENA([In] TDeps KELDMPHCCLC, [In] TSerializedAction OLADKLAOCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4D1BE00", Offset = "0x4D1B200", VA = "0x184D1BE00", Slot = "7")]
	public override string EAPOOJKPODL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KEACEFCODEA<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind AKICALLKOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload KDIIDOFFEKK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x37E8C50", Offset = "0x37E8050", VA = "0x1837E8C50")]
	internal KEACEFCODEA(TActionKind GEJBEPDAOCB, [In] TPayload CJFCIOOMJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EMNBJKKJKCF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x225A600", Offset = "0x2259A00", VA = "0x18225A600")]
	public static KEACEFCODEA<TActionKind, TPayload> CLFIPFKIGEN<TActionKind, TPayload>([In] TActionKind GEJBEPDAOCB, [In] TPayload CJFCIOOMJGN)
	{
		return default(KEACEFCODEA<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<MEEAMGFNJIM<TOk, TErr>> MAKIEGLNPFK<TRoot, TPayload, TOk, TErr>(TRoot JMNDOLBKAMN, TPayload CJFCIOOMJGN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate MEEAMGFNJIM<TOk, TErr> NDFADIOGILE<TRoot, TPayload, TOk, TErr>(TRoot JMNDOLBKAMN, [In] TPayload CJFCIOOMJGN);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PBLGPDHPCBC<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : OJLPDABNGCI.LHGAIJCJEMO<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LMCPLEACJJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PBLGPDHPCBC<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<MEEAMGFNJIM<object, DBNOAAMPCCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3918410", Offset = "0x3917810", VA = "0x183918410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3918910", Offset = "0x3917D10", VA = "0x183918910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, LGEAGJJPNGI<TSerializedAction, TRoot, TDeps>> EGHDHLPCPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps BOAEKCBHIIP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7CF750", Offset = "0x7CEB50", VA = "0x1807CF750")]
	internal PBLGPDHPCBC(Dictionary<TActionKind, LGEAGJJPNGI<TSerializedAction, TRoot, TDeps>> KBKOLGPINKD, TDeps KELDMPHCCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3DA37F0", Offset = "0x3DA2BF0", VA = "0x183DA37F0")]
	[AsyncStateMachine(typeof(PBLGPDHPCBC<, , , >.LMCPLEACJJC))]
	public Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> FMOCGKBELJJ(TRoot JMNDOLBKAMN, TSerializedAction OLADKLAOCKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OJLPDABNGCI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LHGAIJCJEMO<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind HIILFDGPLOL(TSerializedAction CLFMFOEGLFG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JEGAMOFFBDM(TRoot JMNDOLBKAMN, TSerializedAction PAFFKHOCLGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x225BA10", Offset = "0x225AE10", VA = "0x18225BA10")]
	internal static PBLGPDHPCBC<TActionKind, TSerializedAction, TRoot, TDeps> CLFIPFKIGEN<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, LGEAGJJPNGI<TSerializedAction, TRoot, TDeps>> KBKOLGPINKD, TDeps KELDMPHCCLC) where TDeps : LHGAIJCJEMO<TActionKind, TSerializedAction, TRoot>
	{
		return default(PBLGPDHPCBC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BEOGNENPOBK<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, LGEAGJJPNGI<TSerializedAction, TRoot, TDeps>> MGMPEKEKPFF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	private BEOGNENPOBK(Dictionary<TActionKind, LGEAGJJPNGI<TSerializedAction, TRoot, TDeps>> KBKOLGPINKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4499CD0", Offset = "0x44990D0", VA = "0x184499CD0")]
	public static BEOGNENPOBK<TActionKind, TSerializedAction, TRoot, TDeps> CLFIPFKIGEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct PPHKPIDMIPE<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, OJLPDABNGCI.LHGAIJCJEMO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LLNEINDGAOJ<TPayload, TOk, TErr> : LGEAGJJPNGI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DBNOAAMPCCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KCFBMLJHAOD<TActionKind, TSerializedAction, TPayload> DELKAPHEEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly NDFADIOGILE<TRoot, TPayload, TOk, TErr> OAAIIBMIBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool DIJMEFIKIAC;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x35B2DA0", Offset = "0x35B21A0", VA = "0x1835B2DA0")]
		public LLNEINDGAOJ(KCFBMLJHAOD<TActionKind, TSerializedAction, TPayload> HONPONJPALE, NDFADIOGILE<TRoot, TPayload, TOk, TErr> HCMBLOFFOMG, bool GEEKEHNPCEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39026F0", Offset = "0x3901AF0", VA = "0x1839026F0", Slot = "4")]
		public Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> FMOCGKBELJJ(TDeps KELDMPHCCLC, TRoot JMNDOLBKAMN, TSerializedAction OLADKLAOCKF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class IALEGLLEBMG<TPayload, TOk, TErr> : LGEAGJJPNGI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DBNOAAMPCCP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DEHEAGEMOOA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<MEEAMGFNJIM<object?, DBNOAAMPCCP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IALEGLLEBMG<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private MEEAMGFNJIM<object?, DBNOAAMPCCP> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MEEAMGFNJIM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4CE68A0", Offset = "0x4CE5CA0", VA = "0x184CE68A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4CE7190", Offset = "0x4CE6590", VA = "0x184CE7190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly KCFBMLJHAOD<TActionKind, TSerializedAction, TPayload> DELKAPHEEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly MAKIEGLNPFK<TRoot, TPayload, TOk, TErr> OAAIIBMIBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool DIJMEFIKIAC;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x35B2DA0", Offset = "0x35B21A0", VA = "0x1835B2DA0")]
		public IALEGLLEBMG(KCFBMLJHAOD<TActionKind, TSerializedAction, TPayload> HONPONJPALE, MAKIEGLNPFK<TRoot, TPayload, TOk, TErr> HCMBLOFFOMG, bool GEEKEHNPCEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x35B2C40", Offset = "0x35B2040", VA = "0x1835B2C40", Slot = "4")]
		[AsyncStateMachine(typeof(IALEGLLEBMG<, , >.DEHEAGEMOOA))]
		public Task<MEEAMGFNJIM<object, DBNOAAMPCCP>> FMOCGKBELJJ(TDeps KELDMPHCCLC, TRoot JMNDOLBKAMN, TSerializedAction OLADKLAOCKF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BEOGNENPOBK<TActionKind, TSerializedAction, TRoot, TDeps> APCNFDFKIAP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	private PPHKPIDMIPE(BEOGNENPOBK<TActionKind, TSerializedAction, TRoot, TDeps> OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E93720", Offset = "0x3E92B20", VA = "0x183E93720")]
	public static PPHKPIDMIPE<TActionKind, TSerializedAction, TRoot, TDeps> CLFIPFKIGEN()
	{
		return default(PPHKPIDMIPE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22FBE10", Offset = "0x22FB210", VA = "0x1822FBE10")]
	public PPHKPIDMIPE<TActionKind, TSerializedAction, TRoot, TDeps> FMFHGPGDFGC<TPayload, TOk, TErr>(TActionKind GEJBEPDAOCB, KCFBMLJHAOD<TActionKind, TSerializedAction, TPayload> HONPONJPALE, NDFADIOGILE<TRoot, TPayload, TOk, TErr> HCMBLOFFOMG, bool GEEKEHNPCEA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DBNOAAMPCCP
	{
		return default(PPHKPIDMIPE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22FBE10", Offset = "0x22FB210", VA = "0x1822FBE10")]
	public PPHKPIDMIPE<TActionKind, TSerializedAction, TRoot, TDeps> IENEKAPLLGF<TPayload, TOk, TErr>(TActionKind GEJBEPDAOCB, KCFBMLJHAOD<TActionKind, TSerializedAction, TPayload> HONPONJPALE, MAKIEGLNPFK<TRoot, TPayload, TOk, TErr> HCMBLOFFOMG, bool GEEKEHNPCEA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DBNOAAMPCCP
	{
		return default(PPHKPIDMIPE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3E937B0", Offset = "0x3E92BB0", VA = "0x183E937B0")]
	public PBLGPDHPCBC<TActionKind, TSerializedAction, TRoot, TDeps> DBBNOGJCDCC(TDeps KELDMPHCCLC)
	{
		return default(PBLGPDHPCBC<TActionKind, TSerializedAction, TRoot, TDeps>);
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
