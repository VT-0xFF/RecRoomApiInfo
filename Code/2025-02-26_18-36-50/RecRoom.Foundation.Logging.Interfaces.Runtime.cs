using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class NNOPKIIBCJE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
	public NNOPKIIBCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class MFPHKIBKNDJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7478E40", Offset = "0x7478240", VA = "0x187478E40")]
	public MFPHKIBKNDJ(int IBMHAIHIDJJ, int HGEIIGKHPBG, int OJGAKAIOJEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class PJLBNLINHFC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
	public PJLBNLINHFC(bool DCMCALLAHNP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class KODEDAJDIBP : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7478DF0", Offset = "0x74781F0", VA = "0x187478DF0")]
	public KODEDAJDIBP(string OMOOEGOLALI, string GPFCOHGCDPH = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class OIGPMNJKHJL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1EDD560", Offset = "0x1EDC960", VA = "0x181EDD560")]
	public OIGPMNJKHJL(int KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum JDCFCNOKOBA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NonNetworked = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Incoming = 2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Outgoing = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Suppressed = 8,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	FastForward = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	CacheRemove = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Default = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	All = 0x3F
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ICNJHAAOBBE
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AMHHIJCEEFC<T> : ICNJHAAOBBE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, T KBGCCIOIGBD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IHCNDEFBJMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PPAAIGIGKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int BEOOEOEMIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GMOGPDLDPJM(Type BMIPLDLMPCD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNDMGCPNFPA(NativeParallelHashMap<int, AFAOEOIHAIH> OLCJMBGBODB, NativeArray<byte> GIDGOODJFLJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JHPALFLEFIK
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AEOGOBLNEPO
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class NOCHNAABEBL<T> : EMPBJLOFPCC<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FCA740", Offset = "0x3FC9B40", VA = "0x183FCA740")]
	protected NOCHNAABEBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class EMPBJLOFPCC<T> : AMHHIJCEEFC<T>, ICNJHAAOBBE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x401FE80", Offset = "0x401F280", VA = "0x18401FE80")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected EMPBJLOFPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x401FE40", Offset = "0x401F240", VA = "0x18401FE40", Slot = "4")]
	private void AOOFCOFDPOM([In] JHGLMHCLJME PECIEJIPKNF, T KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HHMCGHFPIEM<T> : AMHHIJCEEFC<NativeArray<T>>, ICNJHAAOBBE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4616990", Offset = "0x4615D90", VA = "0x184616990")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, NativeArray<T> KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34185A0", Offset = "0x34179A0", VA = "0x1834185A0")]
	public static ReadOnlySpan<T> DJGGCPNMMFA<T>(NativeArray<T> CJFOOLJEHLK) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected HHMCGHFPIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4616B00", Offset = "0x4615F00", VA = "0x184616B00", Slot = "4")]
	private void NFKEAGPFHBL([In] JHGLMHCLJME PECIEJIPKNF, NativeArray<T> KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IMLKANMGKCJ : AMHHIJCEEFC<IMLKANMGKCJ.JNPKCDFOCDA>, ICNJHAAOBBE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct JNPKCDFOCDA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, JNPKCDFOCDA KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public IMLKANMGKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
	private void PJBEJCDHGIL([In] JHGLMHCLJME PECIEJIPKNF, JNPKCDFOCDA KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EDIJLGPNNEL : AMHHIJCEEFC<string>, ICNJHAAOBBE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly EDIJLGPNNEL IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74782C0", Offset = "0x74776C0", VA = "0x1874782C0")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public EDIJLGPNNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7478610", Offset = "0x7477A10", VA = "0x187478610", Slot = "4")]
	private void GADAHLOKDIL([In] JHGLMHCLJME PECIEJIPKNF, string KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class PNDJEDOOCIB<T> : HOCFEBCKGLM<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3FCA740", Offset = "0x3FC9B40", VA = "0x183FCA740")]
	protected PNDJEDOOCIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class HOCFEBCKGLM<T> : AMHHIJCEEFC<T>, ICNJHAAOBBE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4668220", Offset = "0x4667620", VA = "0x184668220")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected HOCFEBCKGLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x401FE40", Offset = "0x401F240", VA = "0x18401FE40", Slot = "4")]
	private void AOOFCOFDPOM([In] JHGLMHCLJME PECIEJIPKNF, T KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JHGLMHCLJME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct OHLKHAIKIDK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly JHGLMHCLJME PECIEJIPKNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int FKKOBMJMIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int FDGNCGHNOFA;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5670930", Offset = "0x566FD30", VA = "0x185670930")]
		public OHLKHAIKIDK(JHGLMHCLJME PECIEJIPKNF, int FKKOBMJMIMP, int FDGNCGHNOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7478F30", Offset = "0x7478330", VA = "0x187478F30")]
		public OHLKHAIKIDK JJCKIJLOCHL(ReadOnlySpan<byte> GIDGOODJFLJ)
		{
			return default(OHLKHAIKIDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC380", Offset = "0x3AEB780", VA = "0x183AEC380")]
		public OHLKHAIKIDK JJCKIJLOCHL<T>(T GIDGOODJFLJ) where T : struct
		{
			return default(OHLKHAIKIDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7478E90", Offset = "0x7478290", VA = "0x187478E90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private IHCNDEFBJMD ECAGFDLPMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, AFAOEOIHAIH> OLCJMBGBODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7478C20", Offset = "0x7478020", VA = "0x187478C20")]
	public JHGLMHCLJME(IHCNDEFBJMD ECAGFDLPMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74786A0", Offset = "0x7477AA0", VA = "0x1874786A0")]
	public int AKDEIGODCEP(ICNJHAAOBBE HICOCDDBAMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7478A80", Offset = "0x7477E80", VA = "0x187478A80")]
	public OHLKHAIKIDK GELEBLFEOCM(ICNJHAAOBBE HICOCDDBAMJ)
	{
		return default(OHLKHAIKIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7478B70", Offset = "0x7477F70", VA = "0x187478B70")]
	public OHLKHAIKIDK GELEBLFEOCM(int JCAIGBMAHBA)
	{
		return default(OHLKHAIKIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7478980", Offset = "0x7477D80", VA = "0x187478980")]
	public void EALCPPEDECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7478780", Offset = "0x7477B80", VA = "0x187478780")]
	public JHGLMHCLJME APDCJKMBNFA()
	{
		return default(JHGLMHCLJME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7478920", Offset = "0x7477D20", VA = "0x187478920", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class OLLLOFEBOKC
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x35B5F50", Offset = "0x35B5350", VA = "0x1835B5F50")]
	public static JHGLMHCLJME HBHDBABAKDP<T>([In] this JHGLMHCLJME PECIEJIPKNF, AMHHIJCEEFC<T> HICOCDDBAMJ, T KBGCCIOIGBD)
	{
		return default(JHGLMHCLJME);
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
