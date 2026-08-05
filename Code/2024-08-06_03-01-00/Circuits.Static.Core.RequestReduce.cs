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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FFD4D0", Offset = "0x1FFBAD0", VA = "0x181FFD4D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate BLMIMLGDJPA<TActionKind, TPayload> ICHKBIKJDLJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction BCEGALANHDF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MNNNNIOOICF<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHANDHIMCMH<object, LOIFPCPCONK>> LOFMEEBENCB(TDeps MEELJJGMLGH, TRoot GOKNAIEAOEG, TSerializedAction BCEGALANHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CNOPCHDGAGG<TActionKind, TSerializedAction, TRoot, TDeps> : LPFOGJHKMBP where TDeps : FJIABIJAMOG.ANPLOJEBKIM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps JLNBNFBMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction LKFGLHDLNJF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x51C25E0", Offset = "0x51C0BE0", VA = "0x1851C25E0")]
	public CNOPCHDGAGG([In] TDeps MEELJJGMLGH, [In] TSerializedAction BCEGALANHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x51C24B0", Offset = "0x51C0AB0", VA = "0x1851C24B0", Slot = "7")]
	public override string DLMCGACMBKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BLMIMLGDJPA<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind HBIEFMNLECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload ILKKFDOMDBB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F34280", Offset = "0x4F32880", VA = "0x184F34280")]
	internal BLMIMLGDJPA(TActionKind NPDAKOMKNML, [In] TPayload JFHMMOFAOJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FNAPPNDAEMH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B5C260", Offset = "0x2B5A860", VA = "0x182B5C260")]
	public static BLMIMLGDJPA<TActionKind, TPayload> NKOJKFHACJH<TActionKind, TPayload>([In] TActionKind NPDAKOMKNML, [In] TPayload JFHMMOFAOJJ)
	{
		return default(BLMIMLGDJPA<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<HHANDHIMCMH<TOk, TErr>> JLDGEFNIPDE<TRoot, TPayload, TOk, TErr>(TRoot GOKNAIEAOEG, TPayload JFHMMOFAOJJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate HHANDHIMCMH<TOk, TErr> DOOKFOHNMAM<TRoot, TPayload, TOk, TErr>(TRoot GOKNAIEAOEG, [In] TPayload JFHMMOFAOJJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HFBLMPMPCHL<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : FJIABIJAMOG.ANPLOJEBKIM<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DBLLAOGCACN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<object, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HFBLMPMPCHL<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x585C980", Offset = "0x585AF80", VA = "0x18585C980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x585CE10", Offset = "0x585B410", VA = "0x18585CE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, MNNNNIOOICF<TSerializedAction, TRoot, TDeps>> JAPGBHNJPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps JLNBNFBMIEP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
	internal HFBLMPMPCHL(Dictionary<TActionKind, MNNNNIOOICF<TSerializedAction, TRoot, TDeps>> KHGEJBEJPIE, TDeps MEELJJGMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D39080", Offset = "0x3D37680", VA = "0x183D39080")]
	[AsyncStateMachine(typeof(HFBLMPMPCHL<, , , >.DBLLAOGCACN))]
	public Task<HHANDHIMCMH<object, LOIFPCPCONK>> LOFMEEBENCB(TRoot GOKNAIEAOEG, TSerializedAction BCEGALANHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FJIABIJAMOG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ANPLOJEBKIM<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind GBDMIPFFFAE(TSerializedAction ELMHNMGFNPC);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FKCBCLNIHPA(TRoot GOKNAIEAOEG, TSerializedAction IJDJHMGAIOM);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BMJELFHFCBI(TRoot GOKNAIEAOEG, TSerializedAction IJDJHMGAIOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29F6900", Offset = "0x29F4F00", VA = "0x1829F6900")]
	internal static HFBLMPMPCHL<TActionKind, TSerializedAction, TRoot, TDeps> NKOJKFHACJH<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MNNNNIOOICF<TSerializedAction, TRoot, TDeps>> KHGEJBEJPIE, TDeps MEELJJGMLGH) where TDeps : ANPLOJEBKIM<TActionKind, TSerializedAction, TRoot>
	{
		return default(HFBLMPMPCHL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LPBAPHKMHNM<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, MNNNNIOOICF<TSerializedAction, TRoot, TDeps>> DJJNFBJEEBB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	private LPBAPHKMHNM(Dictionary<TActionKind, MNNNNIOOICF<TSerializedAction, TRoot, TDeps>> KHGEJBEJPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4308610", Offset = "0x4306C10", VA = "0x184308610")]
	public static LPBAPHKMHNM<TActionKind, TSerializedAction, TRoot, TDeps> NKOJKFHACJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FAMFIOJDPLD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, FJIABIJAMOG.ANPLOJEBKIM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PAMLKJALION<TPayload, TOk, TErr> : MNNNNIOOICF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, LOIFPCPCONK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly ICHKBIKJDLJ<TActionKind, TSerializedAction, TPayload> CDKCPFAIDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly DOOKFOHNMAM<TRoot, TPayload, TOk, TErr> DDDCLOAKCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool NIMNJIOPPAN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4600630", Offset = "0x45FEC30", VA = "0x184600630")]
		public PAMLKJALION(ICHKBIKJDLJ<TActionKind, TSerializedAction, TPayload> DFAMGMEBCNH, DOOKFOHNMAM<TRoot, TPayload, TOk, TErr> BIEEJCFCGFE, bool NEDCBDOJICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x47E3970", Offset = "0x47E1F70", VA = "0x1847E3970", Slot = "4")]
		public Task<HHANDHIMCMH<object, LOIFPCPCONK>> LOFMEEBENCB(TDeps MEELJJGMLGH, TRoot GOKNAIEAOEG, TSerializedAction BCEGALANHDF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class NPBFEKMIIJG<TPayload, TOk, TErr> : MNNNNIOOICF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, LOIFPCPCONK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct CAAMHCOHPNC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<HHANDHIMCMH<object?, LOIFPCPCONK>> <>t__builder;

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
			public NPBFEKMIIJG<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HHANDHIMCMH<object?, LOIFPCPCONK> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<HHANDHIMCMH<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4FBD3D0", Offset = "0x4FBB9D0", VA = "0x184FBD3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4FBF240", Offset = "0x4FBD840", VA = "0x184FBF240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly ICHKBIKJDLJ<TActionKind, TSerializedAction, TPayload> CDKCPFAIDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly JLDGEFNIPDE<TRoot, TPayload, TOk, TErr> DDDCLOAKCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool NIMNJIOPPAN;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4600630", Offset = "0x45FEC30", VA = "0x184600630")]
		public NPBFEKMIIJG(ICHKBIKJDLJ<TActionKind, TSerializedAction, TPayload> DFAMGMEBCNH, JLDGEFNIPDE<TRoot, TPayload, TOk, TErr> BIEEJCFCGFE, bool NEDCBDOJICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4600210", Offset = "0x45FE810", VA = "0x184600210", Slot = "4")]
		[AsyncStateMachine(typeof(NPBFEKMIIJG<, , >.CAAMHCOHPNC))]
		public Task<HHANDHIMCMH<object, LOIFPCPCONK>> LOFMEEBENCB(TDeps MEELJJGMLGH, TRoot GOKNAIEAOEG, TSerializedAction BCEGALANHDF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LPBAPHKMHNM<TActionKind, TSerializedAction, TRoot, TDeps> CKHJEAIDNJA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	private FAMFIOJDPLD(LPBAPHKMHNM<TActionKind, TSerializedAction, TRoot, TDeps> JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B737B0", Offset = "0x3B71DB0", VA = "0x183B737B0")]
	public static FAMFIOJDPLD<TActionKind, TSerializedAction, TRoot, TDeps> NKOJKFHACJH()
	{
		return default(FAMFIOJDPLD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x274FF10", Offset = "0x274E510", VA = "0x18274FF10")]
	public FAMFIOJDPLD<TActionKind, TSerializedAction, TRoot, TDeps> KJKCPHJDHEJ<TPayload, TOk, TErr>(TActionKind NPDAKOMKNML, ICHKBIKJDLJ<TActionKind, TSerializedAction, TPayload> DFAMGMEBCNH, DOOKFOHNMAM<TRoot, TPayload, TOk, TErr> BIEEJCFCGFE, bool NEDCBDOJICE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, LOIFPCPCONK
	{
		return default(FAMFIOJDPLD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x274FF10", Offset = "0x274E510", VA = "0x18274FF10")]
	public FAMFIOJDPLD<TActionKind, TSerializedAction, TRoot, TDeps> GENFDHKJDOB<TPayload, TOk, TErr>(TActionKind NPDAKOMKNML, ICHKBIKJDLJ<TActionKind, TSerializedAction, TPayload> DFAMGMEBCNH, JLDGEFNIPDE<TRoot, TPayload, TOk, TErr> BIEEJCFCGFE, bool NEDCBDOJICE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, LOIFPCPCONK
	{
		return default(FAMFIOJDPLD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3B736F0", Offset = "0x3B71CF0", VA = "0x183B736F0")]
	public HFBLMPMPCHL<TActionKind, TSerializedAction, TRoot, TDeps> FPPJAIDLFLK(TDeps MEELJJGMLGH)
	{
		return default(HFBLMPMPCHL<TActionKind, TSerializedAction, TRoot, TDeps>);
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
