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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x22AE550", Offset = "0x22ACF50", VA = "0x1822AE550")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate LJJMNEDJEOL<TActionKind, TPayload> DKOIFFEECIH<TActionKind, TSerializedAction, TPayload>(TSerializedAction PGHAABCEJKJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MJNJGPKBFMJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> JMMDEJACDLH(TDeps JOIGIEDFOGO, TRoot ELFANOAFHKM, TSerializedAction PGHAABCEJKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HBCMFMCBGIN<TActionKind, TSerializedAction, TRoot, TDeps> : GEKPLBFPNLN where TDeps : APMCLBELNPF.GJEGCBPMDFF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps HMOBFPGDOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction BOAKLFCIEKN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4171F80", Offset = "0x4170980", VA = "0x184171F80")]
	public HBCMFMCBGIN([In] TDeps JOIGIEDFOGO, [In] TSerializedAction PGHAABCEJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4171DB0", Offset = "0x41707B0", VA = "0x184171DB0", Slot = "7")]
	public override string BGELNEMCJAG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LJJMNEDJEOL<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind ACELGDOBBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload LPEEBFDMHOK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4673060", Offset = "0x4671A60", VA = "0x184673060")]
	internal LJJMNEDJEOL(TActionKind BIGFJADKDPF, [In] TPayload ELHNCLABHAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IGPILOPCHNI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F26000", Offset = "0x2F24A00", VA = "0x182F26000")]
	public static LJJMNEDJEOL<TActionKind, TPayload> AELHPDENENI<TActionKind, TPayload>([In] TActionKind BIGFJADKDPF, [In] TPayload ELHNCLABHAD)
	{
		return default(LJJMNEDJEOL<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<OKPKCEBGDLD<TOk, TErr>> IMPJJEMMODC<TRoot, TPayload, TOk, TErr>(TRoot ELFANOAFHKM, TPayload ELHNCLABHAD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate OKPKCEBGDLD<TOk, TErr> ILLJAIEBBKC<TRoot, TPayload, TOk, TErr>(TRoot ELFANOAFHKM, [In] TPayload ELHNCLABHAD);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NMDDIJILECK<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : APMCLBELNPF.GJEGCBPMDFF<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PLBNDJNLCLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NMDDIJILECK<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4B80ED0", Offset = "0x4B7F8D0", VA = "0x184B80ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4B813E0", Offset = "0x4B7FDE0", VA = "0x184B813E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, MJNJGPKBFMJ<TSerializedAction, TRoot, TDeps>> LEEBAFAHLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps HMOBFPGDOND;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
	internal NMDDIJILECK(Dictionary<TActionKind, MJNJGPKBFMJ<TSerializedAction, TRoot, TDeps>> LGPDPFPNMOA, TDeps JOIGIEDFOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x494BC60", Offset = "0x494A660", VA = "0x18494BC60")]
	[AsyncStateMachine(typeof(NMDDIJILECK<, , , >.PLBNDJNLCLH))]
	public Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> JMMDEJACDLH(TRoot ELFANOAFHKM, TSerializedAction PGHAABCEJKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class APMCLBELNPF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GJEGCBPMDFF<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind KAMJIKPGJCN(TSerializedAction PCBICLOONMH);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OGAPHOHOMLH(TRoot ELFANOAFHKM, TSerializedAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MGOMMHPDAOA(TRoot ELFANOAFHKM, TSerializedAction EFFBNJEBEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2CE99C0", Offset = "0x2CE83C0", VA = "0x182CE99C0")]
	internal static NMDDIJILECK<TActionKind, TSerializedAction, TRoot, TDeps> AELHPDENENI<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MJNJGPKBFMJ<TSerializedAction, TRoot, TDeps>> LGPDPFPNMOA, TDeps JOIGIEDFOGO) where TDeps : GJEGCBPMDFF<TActionKind, TSerializedAction, TRoot>
	{
		return default(NMDDIJILECK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GAPKAEBBIKC<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, MJNJGPKBFMJ<TSerializedAction, TRoot, TDeps>> JFLIHMNKPKC;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	private GAPKAEBBIKC(Dictionary<TActionKind, MJNJGPKBFMJ<TSerializedAction, TRoot, TDeps>> LGPDPFPNMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x40D1CF0", Offset = "0x40D06F0", VA = "0x1840D1CF0")]
	public static GAPKAEBBIKC<TActionKind, TSerializedAction, TRoot, TDeps> AELHPDENENI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct PIMFGPKDBAH<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, APMCLBELNPF.GJEGCBPMDFF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class KBLCHHGNJLO<TPayload, TOk, TErr> : MJNJGPKBFMJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NJDGKLFLKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DKOIFFEECIH<TActionKind, TSerializedAction, TPayload> MKPOMLDENCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly ILLJAIEBBKC<TRoot, TPayload, TOk, TErr> DNLCEDFHAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool MCLBEGPLDLL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4446BC0", Offset = "0x44455C0", VA = "0x184446BC0")]
		public KBLCHHGNJLO(DKOIFFEECIH<TActionKind, TSerializedAction, TPayload> NOHGIHIELFL, ILLJAIEBBKC<TRoot, TPayload, TOk, TErr> EKMHGCFFDAN, bool IDLANNGKJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x44FA510", Offset = "0x44F8F10", VA = "0x1844FA510", Slot = "4")]
		public Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> JMMDEJACDLH(TDeps JOIGIEDFOGO, TRoot ELFANOAFHKM, TSerializedAction PGHAABCEJKJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JPGEGHGPPJJ<TPayload, TOk, TErr> : MJNJGPKBFMJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NJDGKLFLKEH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct PLGEIEINGBJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<OKPKCEBGDLD<object?, NJDGKLFLKEH>> <>t__builder;

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
			public JPGEGHGPPJJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private OKPKCEBGDLD<object?, NJDGKLFLKEH> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OKPKCEBGDLD<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4B83F20", Offset = "0x4B82920", VA = "0x184B83F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4B84410", Offset = "0x4B82E10", VA = "0x184B84410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DKOIFFEECIH<TActionKind, TSerializedAction, TPayload> MKPOMLDENCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly IMPJJEMMODC<TRoot, TPayload, TOk, TErr> DNLCEDFHAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool MCLBEGPLDLL;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4446BC0", Offset = "0x44455C0", VA = "0x184446BC0")]
		public JPGEGHGPPJJ(DKOIFFEECIH<TActionKind, TSerializedAction, TPayload> NOHGIHIELFL, IMPJJEMMODC<TRoot, TPayload, TOk, TErr> EKMHGCFFDAN, bool IDLANNGKJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x44464E0", Offset = "0x4444EE0", VA = "0x1844464E0", Slot = "4")]
		[AsyncStateMachine(typeof(JPGEGHGPPJJ<, , >.PLGEIEINGBJ))]
		public Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> JMMDEJACDLH(TDeps JOIGIEDFOGO, TRoot ELFANOAFHKM, TSerializedAction PGHAABCEJKJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GAPKAEBBIKC<TActionKind, TSerializedAction, TRoot, TDeps> CIOOIMGPMPC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	private PIMFGPKDBAH(GAPKAEBBIKC<TActionKind, TSerializedAction, TRoot, TDeps> GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B732F0", Offset = "0x4B71CF0", VA = "0x184B732F0")]
	public static PIMFGPKDBAH<TActionKind, TSerializedAction, TRoot, TDeps> AELHPDENENI()
	{
		return default(PIMFGPKDBAH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3245840", Offset = "0x3244240", VA = "0x183245840")]
	public PIMFGPKDBAH<TActionKind, TSerializedAction, TRoot, TDeps> IMMIEHGEDKH<TPayload, TOk, TErr>(TActionKind BIGFJADKDPF, DKOIFFEECIH<TActionKind, TSerializedAction, TPayload> NOHGIHIELFL, ILLJAIEBBKC<TRoot, TPayload, TOk, TErr> EKMHGCFFDAN, bool IDLANNGKJJH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NJDGKLFLKEH
	{
		return default(PIMFGPKDBAH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3245840", Offset = "0x3244240", VA = "0x183245840")]
	public PIMFGPKDBAH<TActionKind, TSerializedAction, TRoot, TDeps> MBDEKOILCPI<TPayload, TOk, TErr>(TActionKind BIGFJADKDPF, DKOIFFEECIH<TActionKind, TSerializedAction, TPayload> NOHGIHIELFL, IMPJJEMMODC<TRoot, TPayload, TOk, TErr> EKMHGCFFDAN, bool IDLANNGKJJH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NJDGKLFLKEH
	{
		return default(PIMFGPKDBAH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B73390", Offset = "0x4B71D90", VA = "0x184B73390")]
	public NMDDIJILECK<TActionKind, TSerializedAction, TRoot, TDeps> DFFPFFBGDNP(TDeps JOIGIEDFOGO)
	{
		return default(NMDDIJILECK<TActionKind, TSerializedAction, TRoot, TDeps>);
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
