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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E89E30", Offset = "0x1E88830", VA = "0x181E89E30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate OJPADOANHHB<TActionKind, TPayload> IPJOMENKODG<TActionKind, TSerializedAction, TPayload>(TSerializedAction MJDNALCEEIE);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface PJFECEJNIAJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> DGFGFAMKDPC(TDeps COBDDACEALE, TRoot AKBOHBAKCNP, TSerializedAction MJDNALCEEIE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PIMIDBEICAI<TActionKind, TSerializedAction, TRoot, TDeps> : BPHLMNENOKN where TDeps : LBFJEAANEBJ.IHFHEHLCCJG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps GOGJLAAIIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction FDEKICGDMHC;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4303A50", Offset = "0x4302450", VA = "0x184303A50")]
	public PIMIDBEICAI([In] TDeps COBDDACEALE, [In] TSerializedAction MJDNALCEEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4303890", Offset = "0x4302290", VA = "0x184303890", Slot = "7")]
	public override string BLGDHPMKGMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OJPADOANHHB<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind AOIFIGBDHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload HBHCBPKFLPK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4219850", Offset = "0x4218250", VA = "0x184219850")]
	internal OJPADOANHHB(TActionKind ABIOBJLDAHL, [In] TPayload PEFGDLBLMMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OKMOFHCFKMC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6970", Offset = "0x2AB5370", VA = "0x182AB6970")]
	public static OJPADOANHHB<TActionKind, TPayload> OLCPJHCMOKI<TActionKind, TPayload>([In] TActionKind ABIOBJLDAHL, [In] TPayload PEFGDLBLMMP)
	{
		return default(OJPADOANHHB<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<LGGHGMLBJFM<TOk, TErr>> GDEAKPEGDHJ<TRoot, TPayload, TOk, TErr>(TRoot AKBOHBAKCNP, TPayload PEFGDLBLMMP);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate LGGHGMLBJFM<TOk, TErr> LEOAGNOEBKG<TRoot, TPayload, TOk, TErr>(TRoot AKBOHBAKCNP, [In] TPayload PEFGDLBLMMP);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IDBBNLNJKEH<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : LBFJEAANEBJ.IHFHEHLCCJG<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BIIAOPBFPKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IDBBNLNJKEH<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<LGGHGMLBJFM<object, DGFMPJAMJNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x494F5F0", Offset = "0x494DFF0", VA = "0x18494F5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x494FED0", Offset = "0x494E8D0", VA = "0x18494FED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, PJFECEJNIAJ<TSerializedAction, TRoot, TDeps>> MPOOENNNIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps GOGJLAAIIKE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x95C330", Offset = "0x95AD30", VA = "0x18095C330")]
	internal IDBBNLNJKEH(Dictionary<TActionKind, PJFECEJNIAJ<TSerializedAction, TRoot, TDeps>> EAEFILJDFMD, TDeps COBDDACEALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6830", Offset = "0x3AA5230", VA = "0x183AA6830")]
	[AsyncStateMachine(typeof(IDBBNLNJKEH<, , , >.BIIAOPBFPKH))]
	public Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> DGFGFAMKDPC(TRoot AKBOHBAKCNP, TSerializedAction MJDNALCEEIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LBFJEAANEBJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IHFHEHLCCJG<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind CADHCMMBGHN(TSerializedAction CMJEIEIDHIK);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CPGCMJAHMAP(TRoot AKBOHBAKCNP, TSerializedAction HKIJJKKNOIF);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ODNGHFCGHBI(TRoot AKBOHBAKCNP, TSerializedAction HKIJJKKNOIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x293A150", Offset = "0x2938B50", VA = "0x18293A150")]
	internal static IDBBNLNJKEH<TActionKind, TSerializedAction, TRoot, TDeps> OLCPJHCMOKI<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, PJFECEJNIAJ<TSerializedAction, TRoot, TDeps>> EAEFILJDFMD, TDeps COBDDACEALE) where TDeps : IHFHEHLCCJG<TActionKind, TSerializedAction, TRoot>
	{
		return default(IDBBNLNJKEH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FDNFHJNBNLM<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, PJFECEJNIAJ<TSerializedAction, TRoot, TDeps>> NJEBCIPOPFP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	private FDNFHJNBNLM(Dictionary<TActionKind, PJFECEJNIAJ<TSerializedAction, TRoot, TDeps>> EAEFILJDFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x387A920", Offset = "0x3879320", VA = "0x18387A920")]
	public static FDNFHJNBNLM<TActionKind, TSerializedAction, TRoot, TDeps> OLCPJHCMOKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CAJHKKDKNDJ<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, LBFJEAANEBJ.IHFHEHLCCJG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AEFPIHEJEIE<TPayload, TOk, TErr> : PJFECEJNIAJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DGFMPJAMJNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IPJOMENKODG<TActionKind, TSerializedAction, TPayload> HHIEEJFFDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly LEOAGNOEBKG<TRoot, TPayload, TOk, TErr> OOCIHAJFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool HHDGHMGLFLE;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x393CE70", Offset = "0x393B870", VA = "0x18393CE70")]
		public AEFPIHEJEIE(IPJOMENKODG<TActionKind, TSerializedAction, TPayload> GMPPHLPGNLN, LEOAGNOEBKG<TRoot, TPayload, TOk, TErr> OPMDOLAOBOJ, bool FOEKNKADCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3935480", Offset = "0x3933E80", VA = "0x183935480", Slot = "4")]
		public Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> DGFGFAMKDPC(TDeps COBDDACEALE, TRoot AKBOHBAKCNP, TSerializedAction MJDNALCEEIE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class IOCFOMLMLHD<TPayload, TOk, TErr> : PJFECEJNIAJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DGFMPJAMJNO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NFMKANBEBLH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<LGGHGMLBJFM<object?, DGFMPJAMJNO>> <>t__builder;

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
			public IOCFOMLMLHD<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private LGGHGMLBJFM<object?, DGFMPJAMJNO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<LGGHGMLBJFM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x40CF820", Offset = "0x40CE220", VA = "0x1840CF820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x40D0630", Offset = "0x40CF030", VA = "0x1840D0630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly IPJOMENKODG<TActionKind, TSerializedAction, TPayload> HHIEEJFFDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly GDEAKPEGDHJ<TRoot, TPayload, TOk, TErr> OOCIHAJFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool HHDGHMGLFLE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x393CE70", Offset = "0x393B870", VA = "0x18393CE70")]
		public IOCFOMLMLHD(IPJOMENKODG<TActionKind, TSerializedAction, TPayload> GMPPHLPGNLN, GDEAKPEGDHJ<TRoot, TPayload, TOk, TErr> OPMDOLAOBOJ, bool FOEKNKADCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6740", Offset = "0x3AD5140", VA = "0x183AD6740", Slot = "4")]
		[AsyncStateMachine(typeof(IOCFOMLMLHD<, , >.NFMKANBEBLH))]
		public Task<LGGHGMLBJFM<object, DGFMPJAMJNO>> DGFGFAMKDPC(TDeps COBDDACEALE, TRoot AKBOHBAKCNP, TSerializedAction MJDNALCEEIE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FDNFHJNBNLM<TActionKind, TSerializedAction, TRoot, TDeps> NOHGJHABJOB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	private CAJHKKDKNDJ(FDNFHJNBNLM<TActionKind, TSerializedAction, TRoot, TDeps> ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6F70", Offset = "0x4AA5970", VA = "0x184AA6F70")]
	public static CAJHKKDKNDJ<TActionKind, TSerializedAction, TRoot, TDeps> OLCPJHCMOKI()
	{
		return default(CAJHKKDKNDJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2416A80", Offset = "0x2415480", VA = "0x182416A80")]
	public CAJHKKDKNDJ<TActionKind, TSerializedAction, TRoot, TDeps> PIAAMLCFNPF<TPayload, TOk, TErr>(TActionKind ABIOBJLDAHL, IPJOMENKODG<TActionKind, TSerializedAction, TPayload> GMPPHLPGNLN, LEOAGNOEBKG<TRoot, TPayload, TOk, TErr> OPMDOLAOBOJ, bool FOEKNKADCEH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DGFMPJAMJNO
	{
		return default(CAJHKKDKNDJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2416A80", Offset = "0x2415480", VA = "0x182416A80")]
	public CAJHKKDKNDJ<TActionKind, TSerializedAction, TRoot, TDeps> HCCKNJDBPMC<TPayload, TOk, TErr>(TActionKind ABIOBJLDAHL, IPJOMENKODG<TActionKind, TSerializedAction, TPayload> GMPPHLPGNLN, GDEAKPEGDHJ<TRoot, TPayload, TOk, TErr> OPMDOLAOBOJ, bool FOEKNKADCEH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DGFMPJAMJNO
	{
		return default(CAJHKKDKNDJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6EC0", Offset = "0x4AA58C0", VA = "0x184AA6EC0")]
	public IDBBNLNJKEH<TActionKind, TSerializedAction, TRoot, TDeps> IPCDMOCNHML(TDeps COBDDACEALE)
	{
		return default(IDBBNLNJKEH<TActionKind, TSerializedAction, TRoot, TDeps>);
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
