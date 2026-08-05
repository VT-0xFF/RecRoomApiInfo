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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
	[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
	public NNOPKIIBCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class MFPHKIBKNDJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7517070", Offset = "0x7515670", VA = "0x187517070")]
	public MFPHKIBKNDJ(int IBMHAIHIDJJ, int HGEIIGKHPBG, int OJGAKAIOJEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class PJLBNLINHFC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
	public PJLBNLINHFC(bool DCMCALLAHNP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class KODEDAJDIBP : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7517020", Offset = "0x7515620", VA = "0x187517020")]
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
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1EFDD90", Offset = "0x1EFC390", VA = "0x181EFDD90")]
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
	[Cpp2IlInjected.Address(RVA = "0x401CFF0", Offset = "0x401B5F0", VA = "0x18401CFF0")]
	protected NOCHNAABEBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class EMPBJLOFPCC<T> : AMHHIJCEEFC<T>, ICNJHAAOBBE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4072B00", Offset = "0x4071100", VA = "0x184072B00")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected EMPBJLOFPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4072AC0", Offset = "0x40710C0", VA = "0x184072AC0", Slot = "4")]
	private void AOOFCOFDPOM([In] JHGLMHCLJME PECIEJIPKNF, T KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HHMCGHFPIEM<T> : AMHHIJCEEFC<NativeArray<T>>, ICNJHAAOBBE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4680680", Offset = "0x467EC80", VA = "0x184680680")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, NativeArray<T> KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x358C4A0", Offset = "0x358AAA0", VA = "0x18358C4A0")]
	public static ReadOnlySpan<T> DJGGCPNMMFA<T>(NativeArray<T> CJFOOLJEHLK) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected HHMCGHFPIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x46807F0", Offset = "0x467EDF0", VA = "0x1846807F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, JNPKCDFOCDA KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public IMLKANMGKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x75165C0", Offset = "0x7514BC0", VA = "0x1875165C0")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public EDIJLGPNNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7516910", Offset = "0x7514F10", VA = "0x187516910", Slot = "4")]
	private void GADAHLOKDIL([In] JHGLMHCLJME PECIEJIPKNF, string KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class PNDJEDOOCIB<T> : HOCFEBCKGLM<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x401CFF0", Offset = "0x401B5F0", VA = "0x18401CFF0")]
	protected PNDJEDOOCIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class HOCFEBCKGLM<T> : AMHHIJCEEFC<T>, ICNJHAAOBBE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x46C1630", Offset = "0x46BFC30", VA = "0x1846C1630")]
	public void CKKHKKGEFOO([In] JHGLMHCLJME PECIEJIPKNF, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected HOCFEBCKGLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4072AC0", Offset = "0x40710C0", VA = "0x184072AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x56D5170", Offset = "0x56D3770", VA = "0x1856D5170")]
		public OHLKHAIKIDK(JHGLMHCLJME PECIEJIPKNF, int FKKOBMJMIMP, int FDGNCGHNOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7517160", Offset = "0x7515760", VA = "0x187517160")]
		public OHLKHAIKIDK JJCKIJLOCHL(ReadOnlySpan<byte> GIDGOODJFLJ)
		{
			return default(OHLKHAIKIDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3B253F0", Offset = "0x3B239F0", VA = "0x183B253F0")]
		public OHLKHAIKIDK JJCKIJLOCHL<T>(T GIDGOODJFLJ) where T : struct
		{
			return default(OHLKHAIKIDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75170C0", Offset = "0x75156C0", VA = "0x1875170C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7516E50", Offset = "0x7515450", VA = "0x187516E50")]
	public JHGLMHCLJME(IHCNDEFBJMD ECAGFDLPMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x75169A0", Offset = "0x7514FA0", VA = "0x1875169A0")]
	public int AKDEIGODCEP(ICNJHAAOBBE HICOCDDBAMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7516CB0", Offset = "0x75152B0", VA = "0x187516CB0")]
	public OHLKHAIKIDK GELEBLFEOCM(ICNJHAAOBBE HICOCDDBAMJ)
	{
		return default(OHLKHAIKIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7516DA0", Offset = "0x75153A0", VA = "0x187516DA0")]
	public OHLKHAIKIDK GELEBLFEOCM(int JCAIGBMAHBA)
	{
		return default(OHLKHAIKIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7516B80", Offset = "0x7515180", VA = "0x187516B80")]
	public void EALCPPEDECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7516A80", Offset = "0x7515080", VA = "0x187516A80")]
	public JHGLMHCLJME APDCJKMBNFA()
	{
		return default(JHGLMHCLJME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7516B20", Offset = "0x7515120", VA = "0x187516B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class OLLLOFEBOKC
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x35F9960", Offset = "0x35F7F60", VA = "0x1835F9960")]
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
