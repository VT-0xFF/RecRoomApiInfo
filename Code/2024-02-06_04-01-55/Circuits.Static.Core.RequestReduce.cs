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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D4FAC0", Offset = "0x1D4EEC0", VA = "0x181D4FAC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate NJOABLHJPPJ<TActionKind, TPayload> OPFFJECAJAJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction GDEGENCFHLF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface BHNDHAGNOMF<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> JNOKEHCMGPO(TDeps MLLANHDPJEE, TRoot DHHBNGOGOPD, TSerializedAction GDEGENCFHLF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FMGHOGMDBOI<TActionKind, TSerializedAction, TRoot, TDeps> : MBFBMDOADGG where TDeps : PFMJMBIHEMD.PNIGIANKJKA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps ILLOCOKHCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction BIBBJCINFGG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x364E4C0", Offset = "0x364D8C0", VA = "0x18364E4C0")]
	public FMGHOGMDBOI([In] TDeps MLLANHDPJEE, [In] TSerializedAction GDEGENCFHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x364E290", Offset = "0x364D690", VA = "0x18364E290", Slot = "7")]
	public override string KHCKPFAHKDL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NJOABLHJPPJ<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BIAICKACJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload FAJPDMANEJO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED6800", Offset = "0x3ED5C00", VA = "0x183ED6800")]
	internal NJOABLHJPPJ(TActionKind GKLLLLNDMAP, [In] TPayload KFANGHDLFAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PDLGLGBILLL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x281FE60", Offset = "0x281F260", VA = "0x18281FE60")]
	public static NJOABLHJPPJ<TActionKind, TPayload> CPLKLKACALP<TActionKind, TPayload>([In] TActionKind GKLLLLNDMAP, [In] TPayload KFANGHDLFAN)
	{
		return default(NJOABLHJPPJ<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<IAPKJCHKLLD<TOk, TErr>> OGGBBDKKIFK<TRoot, TPayload, TOk, TErr>(TRoot DHHBNGOGOPD, TPayload KFANGHDLFAN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate IAPKJCHKLLD<TOk, TErr> HHJCOGBGMNO<TRoot, TPayload, TOk, TErr>(TRoot DHHBNGOGOPD, [In] TPayload KFANGHDLFAN);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LNAJOMJEKNC<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : PFMJMBIHEMD.PNIGIANKJKA<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PDFAPHJJBJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LNAJOMJEKNC<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x40879A0", Offset = "0x4086DA0", VA = "0x1840879A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4087E30", Offset = "0x4087230", VA = "0x184087E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, BHNDHAGNOMF<TSerializedAction, TRoot, TDeps>> OJGDKBGOLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps ILLOCOKHCDM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x87C050", Offset = "0x87B450", VA = "0x18087C050")]
	internal LNAJOMJEKNC(Dictionary<TActionKind, BHNDHAGNOMF<TSerializedAction, TRoot, TDeps>> FLBLFOICLFI, TDeps MLLANHDPJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEFB0", Offset = "0x3BDE3B0", VA = "0x183BDEFB0")]
	[AsyncStateMachine(typeof(LNAJOMJEKNC<, , , >.PDFAPHJJBJL))]
	public Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> JNOKEHCMGPO(TRoot DHHBNGOGOPD, TSerializedAction GDEGENCFHLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PFMJMBIHEMD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PNIGIANKJKA<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind KHGHNDIHENN(TSerializedAction LOMPFKEACIP);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DNBPLMMJJKP(TRoot DHHBNGOGOPD, TSerializedAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NBEBMDONAHJ(TRoot DHHBNGOGOPD, TSerializedAction HKJBPIINLDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2658DA0", Offset = "0x26581A0", VA = "0x182658DA0")]
	internal static LNAJOMJEKNC<TActionKind, TSerializedAction, TRoot, TDeps> CPLKLKACALP<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, BHNDHAGNOMF<TSerializedAction, TRoot, TDeps>> FLBLFOICLFI, TDeps MLLANHDPJEE) where TDeps : PNIGIANKJKA<TActionKind, TSerializedAction, TRoot>
	{
		return default(LNAJOMJEKNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class CBEFEBNLLPE<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, BHNDHAGNOMF<TSerializedAction, TRoot, TDeps>> GKKEIAGGIAG;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	private CBEFEBNLLPE(Dictionary<TActionKind, BHNDHAGNOMF<TSerializedAction, TRoot, TDeps>> FLBLFOICLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4833B70", Offset = "0x4832F70", VA = "0x184833B70")]
	public static CBEFEBNLLPE<TActionKind, TSerializedAction, TRoot, TDeps> CPLKLKACALP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JAMIIGBDJCD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, PFMJMBIHEMD.PNIGIANKJKA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class CHPHCAPMAKF<TPayload, TOk, TErr> : BHNDHAGNOMF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HDKPGPNEBBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OPFFJECAJAJ<TActionKind, TSerializedAction, TPayload> FKAGKMANLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly HHJCOGBGMNO<TRoot, TPayload, TOk, TErr> ODMEAAAHMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool NLPJEFCMBLO;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43F9D80", Offset = "0x43F9180", VA = "0x1843F9D80")]
		public CHPHCAPMAKF(OPFFJECAJAJ<TActionKind, TSerializedAction, TPayload> FKEEMAGGJCK, HHJCOGBGMNO<TRoot, TPayload, TOk, TErr> BPMJKAMDPCN, bool LOACMECALNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4937700", Offset = "0x4936B00", VA = "0x184937700", Slot = "4")]
		public Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> JNOKEHCMGPO(TDeps MLLANHDPJEE, TRoot DHHBNGOGOPD, TSerializedAction GDEGENCFHLF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class BIFFPGHALLL<TPayload, TOk, TErr> : BHNDHAGNOMF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HDKPGPNEBBO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct MJBGJEACFGL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<IAPKJCHKLLD<object?, HDKPGPNEBBO>> <>t__builder;

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
			public BIFFPGHALLL<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private IAPKJCHKLLD<object?, HDKPGPNEBBO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<IAPKJCHKLLD<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3DF4C30", Offset = "0x3DF4030", VA = "0x183DF4C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3DF5340", Offset = "0x3DF4740", VA = "0x183DF5340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OPFFJECAJAJ<TActionKind, TSerializedAction, TPayload> FKAGKMANLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly OGGBBDKKIFK<TRoot, TPayload, TOk, TErr> ODMEAAAHMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool NLPJEFCMBLO;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x43F9D80", Offset = "0x43F9180", VA = "0x1843F9D80")]
		public BIFFPGHALLL(OPFFJECAJAJ<TActionKind, TSerializedAction, TPayload> FKEEMAGGJCK, OGGBBDKKIFK<TRoot, TPayload, TOk, TErr> BPMJKAMDPCN, bool LOACMECALNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4731B90", Offset = "0x4730F90", VA = "0x184731B90", Slot = "4")]
		[AsyncStateMachine(typeof(BIFFPGHALLL<, , >.MJBGJEACFGL))]
		public Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> JNOKEHCMGPO(TDeps MLLANHDPJEE, TRoot DHHBNGOGOPD, TSerializedAction GDEGENCFHLF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CBEFEBNLLPE<TActionKind, TSerializedAction, TRoot, TDeps> MHDPHJDDLMF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
	private JAMIIGBDJCD(CBEFEBNLLPE<TActionKind, TSerializedAction, TRoot, TDeps> ALPLHOOHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x39B9250", Offset = "0x39B8650", VA = "0x1839B9250")]
	public static JAMIIGBDJCD<TActionKind, TSerializedAction, TRoot, TDeps> CPLKLKACALP()
	{
		return default(JAMIIGBDJCD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x23A2F10", Offset = "0x23A2310", VA = "0x1823A2F10")]
	public JAMIIGBDJCD<TActionKind, TSerializedAction, TRoot, TDeps> JOOJJDIHIAL<TPayload, TOk, TErr>(TActionKind GKLLLLNDMAP, OPFFJECAJAJ<TActionKind, TSerializedAction, TPayload> FKEEMAGGJCK, HHJCOGBGMNO<TRoot, TPayload, TOk, TErr> BPMJKAMDPCN, bool LOACMECALNA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HDKPGPNEBBO
	{
		return default(JAMIIGBDJCD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x23A2F10", Offset = "0x23A2310", VA = "0x1823A2F10")]
	public JAMIIGBDJCD<TActionKind, TSerializedAction, TRoot, TDeps> CIKGLBIPCPB<TPayload, TOk, TErr>(TActionKind GKLLLLNDMAP, OPFFJECAJAJ<TActionKind, TSerializedAction, TPayload> FKEEMAGGJCK, OGGBBDKKIFK<TRoot, TPayload, TOk, TErr> BPMJKAMDPCN, bool LOACMECALNA = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HDKPGPNEBBO
	{
		return default(JAMIIGBDJCD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x39B92E0", Offset = "0x39B86E0", VA = "0x1839B92E0")]
	public LNAJOMJEKNC<TActionKind, TSerializedAction, TRoot, TDeps> OHPJLJEBDEM(TDeps MLLANHDPJEE)
	{
		return default(LNAJOMJEKNC<TActionKind, TSerializedAction, TRoot, TDeps>);
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
