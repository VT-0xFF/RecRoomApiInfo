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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x29A67F0", Offset = "0x29A4DF0", VA = "0x1829A67F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate BIHIJNNEMHN<TActionKind, TPayload> OANNBHLPHME<TActionKind, TSerializedAction, TPayload>(TSerializedAction GHCBDNMCOBI);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MAKCFEPFIOD<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FANMKCKHALG<object, GNLHMHNEEGO>> JFDEJBBFDPB(TDeps GMIGKAKBDIM, TRoot CMAFOEIBEKN, TSerializedAction GHCBDNMCOBI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FMNIMKAJKAD<TActionKind, TSerializedAction, TRoot, TDeps> : CKEJBHKCKAO where TDeps : JOFHCLKFCCI.KJBNKHOHKAH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps ODPIHOLNHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction BKFAJCAAOHN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C58D40", Offset = "0x4C57340", VA = "0x184C58D40")]
	public FMNIMKAJKAD([In] TDeps GMIGKAKBDIM, [In] TSerializedAction GHCBDNMCOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C58B10", Offset = "0x4C57110", VA = "0x184C58B10", Slot = "7")]
	public override string GNDOFJNNOIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BIHIJNNEMHN<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind IGHGIBOEEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload JCCHIHDADDM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61FC760", Offset = "0x61FAD60", VA = "0x1861FC760")]
	internal BIHIJNNEMHN(TActionKind PFPDAHLOMPL, [In] TPayload INCLIAEIKDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GJEAELHAIDK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3B4EB00", Offset = "0x3B4D100", VA = "0x183B4EB00")]
	public static BIHIJNNEMHN<TActionKind, TPayload> BFOPDLPDKBM<TActionKind, TPayload>([In] TActionKind PFPDAHLOMPL, [In] TPayload INCLIAEIKDJ)
	{
		return default(BIHIJNNEMHN<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<FANMKCKHALG<TOk, TErr>> OCNDIDHFKGD<TRoot, TPayload, TOk, TErr>(TRoot CMAFOEIBEKN, TPayload INCLIAEIKDJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate FANMKCKHALG<TOk, TErr> MPONDLALJLO<TRoot, TPayload, TOk, TErr>(TRoot CMAFOEIBEKN, [In] TPayload INCLIAEIKDJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MDBODCLFPME<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : JOFHCLKFCCI.KJBNKHOHKAH<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FCMHGGPHMHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<object?, GNLHMHNEEGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MDBODCLFPME<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<FANMKCKHALG<object, GNLHMHNEEGO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4BF4820", Offset = "0x4BF2E20", VA = "0x184BF4820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4BF5190", Offset = "0x4BF3790", VA = "0x184BF5190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, MAKCFEPFIOD<TSerializedAction, TRoot, TDeps>> CLFPHBJDPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps ODPIHOLNHGM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
	internal MDBODCLFPME(Dictionary<TActionKind, MAKCFEPFIOD<TSerializedAction, TRoot, TDeps>> KAHAGPGNLBC, TDeps GMIGKAKBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x55FF2D0", Offset = "0x55FD8D0", VA = "0x1855FF2D0")]
	[AsyncStateMachine(typeof(MDBODCLFPME<, , , >.FCMHGGPHMHG))]
	public Task<FANMKCKHALG<object, GNLHMHNEEGO>> JFDEJBBFDPB(TRoot CMAFOEIBEKN, TSerializedAction GHCBDNMCOBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JOFHCLKFCCI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KJBNKHOHKAH<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind JCMLMNMLAAB(TSerializedAction PIKMBNLEPPK);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PENKMLFJHHH(TRoot CMAFOEIBEKN, TSerializedAction CJDOILFHDJI);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EDLNPJFEDGE(TRoot CMAFOEIBEKN, TSerializedAction CJDOILFHDJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38D09C0", Offset = "0x38CEFC0", VA = "0x1838D09C0")]
	internal static MDBODCLFPME<TActionKind, TSerializedAction, TRoot, TDeps> BFOPDLPDKBM<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MAKCFEPFIOD<TSerializedAction, TRoot, TDeps>> KAHAGPGNLBC, TDeps GMIGKAKBDIM) where TDeps : KJBNKHOHKAH<TActionKind, TSerializedAction, TRoot>
	{
		return default(MDBODCLFPME<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GNMDFEIKOBE<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, MAKCFEPFIOD<TSerializedAction, TRoot, TDeps>> ANFHNEPFLKI;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	private GNMDFEIKOBE(Dictionary<TActionKind, MAKCFEPFIOD<TSerializedAction, TRoot, TDeps>> KAHAGPGNLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D9DE90", Offset = "0x4D9C490", VA = "0x184D9DE90")]
	public static GNMDFEIKOBE<TActionKind, TSerializedAction, TRoot, TDeps> BFOPDLPDKBM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct BNMBOAKHKJF<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, JOFHCLKFCCI.KJBNKHOHKAH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class DIHBGDIEHIM<TPayload, TOk, TErr> : MAKCFEPFIOD<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, GNLHMHNEEGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OANNBHLPHME<TActionKind, TSerializedAction, TPayload> JLKEFNOKGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MPONDLALJLO<TRoot, TPayload, TOk, TErr> IFJJCAJEGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool BHEDGKMGCEL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1B5BAA0", Offset = "0x1B5A0A0", VA = "0x181B5BAA0")]
		public DIHBGDIEHIM(OANNBHLPHME<TActionKind, TSerializedAction, TPayload> GJIFMOPAPEP, MPONDLALJLO<TRoot, TPayload, TOk, TErr> IEKPONPIHFN, bool PFGDCAOKIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6CE32A0", Offset = "0x6CE18A0", VA = "0x186CE32A0", Slot = "4")]
		public Task<FANMKCKHALG<object, GNLHMHNEEGO>> JFDEJBBFDPB(TDeps GMIGKAKBDIM, TRoot CMAFOEIBEKN, TSerializedAction GHCBDNMCOBI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HLHMBNDNAFJ<TPayload, TOk, TErr> : MAKCFEPFIOD<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, GNLHMHNEEGO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct KEJBABAJDKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<FANMKCKHALG<object?, GNLHMHNEEGO>> <>t__builder;

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
			public HLHMBNDNAFJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private FANMKCKHALG<object?, GNLHMHNEEGO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<FANMKCKHALG<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5297D50", Offset = "0x5296350", VA = "0x185297D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5299CD0", Offset = "0x52982D0", VA = "0x185299CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OANNBHLPHME<TActionKind, TSerializedAction, TPayload> JLKEFNOKGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly OCNDIDHFKGD<TRoot, TPayload, TOk, TErr> IFJJCAJEGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool BHEDGKMGCEL;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1B5BAA0", Offset = "0x1B5A0A0", VA = "0x181B5BAA0")]
		public HLHMBNDNAFJ(OANNBHLPHME<TActionKind, TSerializedAction, TPayload> GJIFMOPAPEP, OCNDIDHFKGD<TRoot, TPayload, TOk, TErr> IEKPONPIHFN, bool PFGDCAOKIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D900", Offset = "0x4E1BF00", VA = "0x184E1D900", Slot = "4")]
		[AsyncStateMachine(typeof(HLHMBNDNAFJ<, , >.KEJBABAJDKO))]
		public Task<FANMKCKHALG<object, GNLHMHNEEGO>> JFDEJBBFDPB(TDeps GMIGKAKBDIM, TRoot CMAFOEIBEKN, TSerializedAction GHCBDNMCOBI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GNMDFEIKOBE<TActionKind, TSerializedAction, TRoot, TDeps> ACKBIKMHOKC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xDE8A40", Offset = "0xDE7040", VA = "0x180DE8A40")]
	private BNMBOAKHKJF(GNMDFEIKOBE<TActionKind, TSerializedAction, TRoot, TDeps> ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62F5EA0", Offset = "0x62F44A0", VA = "0x1862F5EA0")]
	public static BNMBOAKHKJF<TActionKind, TSerializedAction, TRoot, TDeps> BFOPDLPDKBM()
	{
		return default(BNMBOAKHKJF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C915D0", Offset = "0x3C8FBD0", VA = "0x183C915D0")]
	public BNMBOAKHKJF<TActionKind, TSerializedAction, TRoot, TDeps> LAAEDGFPIJN<TPayload, TOk, TErr>(TActionKind PFPDAHLOMPL, OANNBHLPHME<TActionKind, TSerializedAction, TPayload> GJIFMOPAPEP, MPONDLALJLO<TRoot, TPayload, TOk, TErr> IEKPONPIHFN, bool PFGDCAOKIGJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, GNLHMHNEEGO
	{
		return default(BNMBOAKHKJF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C915D0", Offset = "0x3C8FBD0", VA = "0x183C915D0")]
	public BNMBOAKHKJF<TActionKind, TSerializedAction, TRoot, TDeps> IDNECDCKGDM<TPayload, TOk, TErr>(TActionKind PFPDAHLOMPL, OANNBHLPHME<TActionKind, TSerializedAction, TPayload> GJIFMOPAPEP, OCNDIDHFKGD<TRoot, TPayload, TOk, TErr> IEKPONPIHFN, bool PFGDCAOKIGJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, GNLHMHNEEGO
	{
		return default(BNMBOAKHKJF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x62F5F30", Offset = "0x62F4530", VA = "0x1862F5F30")]
	public MDBODCLFPME<TActionKind, TSerializedAction, TRoot, TDeps> JKOBIMNAGJL(TDeps GMIGKAKBDIM)
	{
		return default(MDBODCLFPME<TActionKind, TSerializedAction, TRoot, TDeps>);
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
