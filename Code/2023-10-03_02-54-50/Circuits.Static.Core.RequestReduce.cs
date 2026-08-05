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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C39650", Offset = "0x1C37E50", VA = "0x181C39650")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate KFEFILDMIDC<TActionKind, TPayload> MJAGKFHJDJE<TActionKind, TSerializedAction, TPayload>(TSerializedAction MLKEDENILHG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GODCLBLEFNC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ENHODGJKDIF<object, HFHKAILBFCH>> JKNNNGDNGMC(TDeps AGOMFIAFNMP, TRoot KLOAHFNCDKG, TSerializedAction MLKEDENILHG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OLIEJEMBKJO<TActionKind, TSerializedAction, TRoot, TDeps> : CDMBCFNGLDJ where TDeps : HCNIEOAFENP.NELKDFJFPAC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps CIFIMLEEDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction MIPHOBNBPOI;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC260", Offset = "0x3DCAA60", VA = "0x183DCC260")]
	public OLIEJEMBKJO([In] TDeps AGOMFIAFNMP, [In] TSerializedAction MLKEDENILHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC190", Offset = "0x3DCA990", VA = "0x183DCC190", Slot = "7")]
	public override string GLHFGNJEPCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KFEFILDMIDC<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind JPJBMJGOLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload BFBKNGPHBLM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x38D3E80", Offset = "0x38D2680", VA = "0x1838D3E80")]
	internal KFEFILDMIDC(TActionKind HJDEFAHLGNH, [In] TPayload AJPCNFDACDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GGFIHPJLOLG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x237BD20", Offset = "0x237A520", VA = "0x18237BD20")]
	public static KFEFILDMIDC<TActionKind, TPayload> MJLGMKKAMEE<TActionKind, TPayload>([In] TActionKind HJDEFAHLGNH, [In] TPayload AJPCNFDACDH)
	{
		return default(KFEFILDMIDC<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<ENHODGJKDIF<TOk, TErr>> KGJDJBMCGEN<TRoot, TPayload, TOk, TErr>(TRoot KLOAHFNCDKG, TPayload AJPCNFDACDH);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate ENHODGJKDIF<TOk, TErr> AFNJHDFIPBD<TRoot, TPayload, TOk, TErr>(TRoot KLOAHFNCDKG, [In] TPayload AJPCNFDACDH);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NKPIMNGALPK<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : HCNIEOAFENP.NELKDFJFPAC<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JNFKHIDOPGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<ENHODGJKDIF<object, HFHKAILBFCH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NKPIMNGALPK<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<ENHODGJKDIF<object, HFHKAILBFCH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x385C3A0", Offset = "0x385ABA0", VA = "0x18385C3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x385CCC0", Offset = "0x385B4C0", VA = "0x18385CCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, GODCLBLEFNC<TSerializedAction, TRoot, TDeps>> KMPKJGDFHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps CIFIMLEEDNI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F41F0", Offset = "0x7F29F0", VA = "0x1807F41F0")]
	internal NKPIMNGALPK(Dictionary<TActionKind, GODCLBLEFNC<TSerializedAction, TRoot, TDeps>> FOCEMGIFKMA, TDeps AGOMFIAFNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CAD620", Offset = "0x3CABE20", VA = "0x183CAD620")]
	[AsyncStateMachine(typeof(NKPIMNGALPK<, , , >.JNFKHIDOPGB))]
	public Task<ENHODGJKDIF<object, HFHKAILBFCH>> JKNNNGDNGMC(TRoot KLOAHFNCDKG, TSerializedAction MLKEDENILHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HCNIEOAFENP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NELKDFJFPAC<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind NCLOCKFLHPC(TSerializedAction CLEGCKJMIEA);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HMJLCHLKGKD(TRoot KLOAHFNCDKG, TSerializedAction POMIBLHGGHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x23808C0", Offset = "0x237F0C0", VA = "0x1823808C0")]
	internal static NKPIMNGALPK<TActionKind, TSerializedAction, TRoot, TDeps> MJLGMKKAMEE<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, GODCLBLEFNC<TSerializedAction, TRoot, TDeps>> FOCEMGIFKMA, TDeps AGOMFIAFNMP) where TDeps : NELKDFJFPAC<TActionKind, TSerializedAction, TRoot>
	{
		return default(NKPIMNGALPK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GEGDJGBJNFK<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, GODCLBLEFNC<TSerializedAction, TRoot, TDeps>> LMMAOBLGEEK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	private GEGDJGBJNFK(Dictionary<TActionKind, GODCLBLEFNC<TSerializedAction, TRoot, TDeps>> FOCEMGIFKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3489BF0", Offset = "0x34883F0", VA = "0x183489BF0")]
	public static GEGDJGBJNFK<TActionKind, TSerializedAction, TRoot, TDeps> MJLGMKKAMEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FMHNHEGMIHN<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, HCNIEOAFENP.NELKDFJFPAC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LPJLJIPABLO<TPayload, TOk, TErr> : GODCLBLEFNC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HFHKAILBFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MJAGKFHJDJE<TActionKind, TSerializedAction, TPayload> NCIEBGJOGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly AFNJHDFIPBD<TRoot, TPayload, TOk, TErr> LLJPKOOIFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool HPJDIECJKFL;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3842D40", Offset = "0x3841540", VA = "0x183842D40")]
		public LPJLJIPABLO(MJAGKFHJDJE<TActionKind, TSerializedAction, TPayload> PLMDDDCOJCG, AFNJHDFIPBD<TRoot, TPayload, TOk, TErr> DPFGHCBCDLC, bool GBAGKONAMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39C7EA0", Offset = "0x39C66A0", VA = "0x1839C7EA0", Slot = "4")]
		public Task<ENHODGJKDIF<object, HFHKAILBFCH>> JKNNNGDNGMC(TDeps AGOMFIAFNMP, TRoot KLOAHFNCDKG, TSerializedAction MLKEDENILHG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JEPAGBEHFCP<TPayload, TOk, TErr> : GODCLBLEFNC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HFHKAILBFCH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct PEMPOCFJHBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<ENHODGJKDIF<object?, HFHKAILBFCH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JEPAGBEHFCP<TPayload, TOk, TErr> <>4__this;

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
			private ENHODGJKDIF<object?, HFHKAILBFCH> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<ENHODGJKDIF<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3E760E0", Offset = "0x3E748E0", VA = "0x183E760E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3E771E0", Offset = "0x3E759E0", VA = "0x183E771E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly MJAGKFHJDJE<TActionKind, TSerializedAction, TPayload> NCIEBGJOGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly KGJDJBMCGEN<TRoot, TPayload, TOk, TErr> LLJPKOOIFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool HPJDIECJKFL;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3842D40", Offset = "0x3841540", VA = "0x183842D40")]
		public JEPAGBEHFCP(MJAGKFHJDJE<TActionKind, TSerializedAction, TPayload> PLMDDDCOJCG, KGJDJBMCGEN<TRoot, TPayload, TOk, TErr> DPFGHCBCDLC, bool GBAGKONAMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x38427C0", Offset = "0x3840FC0", VA = "0x1838427C0", Slot = "4")]
		[AsyncStateMachine(typeof(JEPAGBEHFCP<, , >.PEMPOCFJHBO))]
		public Task<ENHODGJKDIF<object, HFHKAILBFCH>> JKNNNGDNGMC(TDeps AGOMFIAFNMP, TRoot KLOAHFNCDKG, TSerializedAction MLKEDENILHG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GEGDJGBJNFK<TActionKind, TSerializedAction, TRoot, TDeps> JJLACGCPGEF;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8C0", Offset = "0x7EC0C0", VA = "0x1807ED8C0")]
	private FMHNHEGMIHN(GEGDJGBJNFK<TActionKind, TSerializedAction, TRoot, TDeps> KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x33B4AF0", Offset = "0x33B32F0", VA = "0x1833B4AF0")]
	public static FMHNHEGMIHN<TActionKind, TSerializedAction, TRoot, TDeps> MJLGMKKAMEE()
	{
		return default(FMHNHEGMIHN<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1690", Offset = "0x2BEFE90", VA = "0x182BF1690")]
	public FMHNHEGMIHN<TActionKind, TSerializedAction, TRoot, TDeps> IMKCGBNJHDF<TPayload, TOk, TErr>(TActionKind HJDEFAHLGNH, MJAGKFHJDJE<TActionKind, TSerializedAction, TPayload> PLMDDDCOJCG, AFNJHDFIPBD<TRoot, TPayload, TOk, TErr> DPFGHCBCDLC, bool GBAGKONAMDA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HFHKAILBFCH
	{
		return default(FMHNHEGMIHN<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1690", Offset = "0x2BEFE90", VA = "0x182BF1690")]
	public FMHNHEGMIHN<TActionKind, TSerializedAction, TRoot, TDeps> ABGBNJFBKKA<TPayload, TOk, TErr>(TActionKind HJDEFAHLGNH, MJAGKFHJDJE<TActionKind, TSerializedAction, TPayload> PLMDDDCOJCG, KGJDJBMCGEN<TRoot, TPayload, TOk, TErr> DPFGHCBCDLC, bool GBAGKONAMDA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HFHKAILBFCH
	{
		return default(FMHNHEGMIHN<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33B4A40", Offset = "0x33B3240", VA = "0x1833B4A40")]
	public NKPIMNGALPK<TActionKind, TSerializedAction, TRoot, TDeps> EOKLOOHPCNF(TDeps AGOMFIAFNMP)
	{
		return default(NKPIMNGALPK<TActionKind, TSerializedAction, TRoot, TDeps>);
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
