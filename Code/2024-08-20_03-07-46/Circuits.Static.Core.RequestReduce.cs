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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2022450", Offset = "0x2021450", VA = "0x182022450")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate CAOIGAEMJKC<TActionKind, TPayload> EDFKLDDCMBN<TActionKind, TSerializedAction, TPayload>(TSerializedAction IIPFIBEACPN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface IJLNEHPAOMP<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> NNHJJMFIHOC(TDeps HPGJLJLFPIH, TRoot JMCFDCHCIPI, TSerializedAction IIPFIBEACPN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LMNHAKFEPHG<TActionKind, TSerializedAction, TRoot, TDeps> : LPIPGCLHAKC where TDeps : CPPIEJKJJPO.PGABJALLGMN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps OMOPLBNHPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction LOENKHHBNFL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4306AE0", Offset = "0x4305AE0", VA = "0x184306AE0")]
	public LMNHAKFEPHG([In] TDeps HPGJLJLFPIH, [In] TSerializedAction IIPFIBEACPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43069C0", Offset = "0x43059C0", VA = "0x1843069C0", Slot = "7")]
	public override string DODDKOCHLNI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CAOIGAEMJKC<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind EDEIFCHELAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload OIICDCOEHJM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50A8A80", Offset = "0x50A7A80", VA = "0x1850A8A80")]
	internal CAOIGAEMJKC(TActionKind NCBFLHJFHDD, [In] TPayload KLINFCCHIED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LBHPOBNDCNF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C757B0", Offset = "0x2C747B0", VA = "0x182C757B0")]
	public static CAOIGAEMJKC<TActionKind, TPayload> GAKCNKPJGEK<TActionKind, TPayload>([In] TActionKind NCBFLHJFHDD, [In] TPayload KLINFCCHIED)
	{
		return default(CAOIGAEMJKC<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<DFAHBLOKBPH<TOk, TErr>> ICDGCMGPEFO<TRoot, TPayload, TOk, TErr>(TRoot JMCFDCHCIPI, TPayload KLINFCCHIED);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate DFAHBLOKBPH<TOk, TErr> JIPPCCDDDOF<TRoot, TPayload, TOk, TErr>(TRoot JMCFDCHCIPI, [In] TPayload KLINFCCHIED);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PAEDLKDBPDM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : CPPIEJKJJPO.PGABJALLGMN<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OOCKLFOBJEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PAEDLKDBPDM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x46FA730", Offset = "0x46F9730", VA = "0x1846FA730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x46FABC0", Offset = "0x46F9BC0", VA = "0x1846FABC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, IJLNEHPAOMP<TSerializedAction, TRoot, TDeps>> HLNEJJKNDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps OMOPLBNHPIH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
	internal PAEDLKDBPDM(Dictionary<TActionKind, IJLNEHPAOMP<TSerializedAction, TRoot, TDeps>> GAEFONMCLPD, TDeps HPGJLJLFPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x478CFE0", Offset = "0x478BFE0", VA = "0x18478CFE0")]
	[AsyncStateMachine(typeof(PAEDLKDBPDM<, , , >.OOCKLFOBJEK))]
	public Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> NNHJJMFIHOC(TRoot JMCFDCHCIPI, TSerializedAction IIPFIBEACPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CPPIEJKJJPO
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PGABJALLGMN<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind PCLNFJBLPDN(TSerializedAction KALCJEIICGB);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OCFPPJHHNLO(TRoot JMCFDCHCIPI, TSerializedAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LLKAHBJIAFO(TRoot JMCFDCHCIPI, TSerializedAction JFOAFIPDIOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x299B8A0", Offset = "0x299A8A0", VA = "0x18299B8A0")]
	internal static PAEDLKDBPDM<TActionKind, TSerializedAction, TRoot, TDeps> GAKCNKPJGEK<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, IJLNEHPAOMP<TSerializedAction, TRoot, TDeps>> GAEFONMCLPD, TDeps HPGJLJLFPIH) where TDeps : PGABJALLGMN<TActionKind, TSerializedAction, TRoot>
	{
		return default(PAEDLKDBPDM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class ACGEHCLDIPF<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, IJLNEHPAOMP<TSerializedAction, TRoot, TDeps>> PBHGDLGFDMK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	private ACGEHCLDIPF(Dictionary<TActionKind, IJLNEHPAOMP<TSerializedAction, TRoot, TDeps>> GAEFONMCLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC7A0", Offset = "0x3CEB7A0", VA = "0x183CEC7A0")]
	public static ACGEHCLDIPF<TActionKind, TSerializedAction, TRoot, TDeps> GAKCNKPJGEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LFFDDJPJHBH<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, CPPIEJKJJPO.PGABJALLGMN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class CAEPOFHGNDK<TPayload, TOk, TErr> : IJLNEHPAOMP<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHMJGLAPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EDFKLDDCMBN<TActionKind, TSerializedAction, TPayload> AGHBHJEIMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly JIPPCCDDDOF<TRoot, TPayload, TOk, TErr> IOMJOPNNCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool ENCDOAPPDHK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4AE4A70", Offset = "0x4AE3A70", VA = "0x184AE4A70")]
		public CAEPOFHGNDK(EDFKLDDCMBN<TActionKind, TSerializedAction, TPayload> PLLPCBNMDDM, JIPPCCDDDOF<TRoot, TPayload, TOk, TErr> JIFPIDFLOPL, bool KAJNKNDFKFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB510", Offset = "0x4FAA510", VA = "0x184FAB510", Slot = "4")]
		public Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> NNHJJMFIHOC(TDeps HPGJLJLFPIH, TRoot JMCFDCHCIPI, TSerializedAction IIPFIBEACPN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class BMJHEIBKDGF<TPayload, TOk, TErr> : IJLNEHPAOMP<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHMJGLAPL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct PAPGKHFMDHC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<DFAHBLOKBPH<object?, CKBHMJGLAPL>> <>t__builder;

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
			public BMJHEIBKDGF<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private DFAHBLOKBPH<object?, CKBHMJGLAPL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DFAHBLOKBPH<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4792440", Offset = "0x4791440", VA = "0x184792440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4792FB0", Offset = "0x4791FB0", VA = "0x184792FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly EDFKLDDCMBN<TActionKind, TSerializedAction, TPayload> AGHBHJEIMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly ICDGCMGPEFO<TRoot, TPayload, TOk, TErr> IOMJOPNNCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool ENCDOAPPDHK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4AE4A70", Offset = "0x4AE3A70", VA = "0x184AE4A70")]
		public BMJHEIBKDGF(EDFKLDDCMBN<TActionKind, TSerializedAction, TPayload> PLLPCBNMDDM, ICDGCMGPEFO<TRoot, TPayload, TOk, TErr> JIFPIDFLOPL, bool KAJNKNDFKFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D450", Offset = "0x4E9C450", VA = "0x184E9D450", Slot = "4")]
		[AsyncStateMachine(typeof(BMJHEIBKDGF<, , >.PAPGKHFMDHC))]
		public Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> NNHJJMFIHOC(TDeps HPGJLJLFPIH, TRoot JMCFDCHCIPI, TSerializedAction IIPFIBEACPN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly ACGEHCLDIPF<TActionKind, TSerializedAction, TRoot, TDeps> IKBIPBFMBBH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	private LFFDDJPJHBH(ACGEHCLDIPF<TActionKind, TSerializedAction, TRoot, TDeps> AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42E7800", Offset = "0x42E6800", VA = "0x1842E7800")]
	public static LFFDDJPJHBH<TActionKind, TSerializedAction, TRoot, TDeps> GAKCNKPJGEK()
	{
		return default(LFFDDJPJHBH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEABE0", Offset = "0x2AE9BE0", VA = "0x182AEABE0")]
	public LFFDDJPJHBH<TActionKind, TSerializedAction, TRoot, TDeps> AIIDMFKDHCG<TPayload, TOk, TErr>(TActionKind NCBFLHJFHDD, EDFKLDDCMBN<TActionKind, TSerializedAction, TPayload> PLLPCBNMDDM, JIPPCCDDDOF<TRoot, TPayload, TOk, TErr> JIFPIDFLOPL, bool KAJNKNDFKFE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHMJGLAPL
	{
		return default(LFFDDJPJHBH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2AEABE0", Offset = "0x2AE9BE0", VA = "0x182AEABE0")]
	public LFFDDJPJHBH<TActionKind, TSerializedAction, TRoot, TDeps> CHNCNKOLACP<TPayload, TOk, TErr>(TActionKind NCBFLHJFHDD, EDFKLDDCMBN<TActionKind, TSerializedAction, TPayload> PLLPCBNMDDM, ICDGCMGPEFO<TRoot, TPayload, TOk, TErr> JIFPIDFLOPL, bool KAJNKNDFKFE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHMJGLAPL
	{
		return default(LFFDDJPJHBH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42E7740", Offset = "0x42E6740", VA = "0x1842E7740")]
	public PAEDLKDBPDM<TActionKind, TSerializedAction, TRoot, TDeps> AOJAOMOLLEG(TDeps HPGJLJLFPIH)
	{
		return default(PAEDLKDBPDM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
