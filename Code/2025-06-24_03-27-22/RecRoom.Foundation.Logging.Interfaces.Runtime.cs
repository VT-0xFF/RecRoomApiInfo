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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class DAJHLHDJJCC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
	public DAJHLHDJJCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class KPANKIGMMKK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE200", Offset = "0x7DDCE00", VA = "0x187DDE200")]
	public KPANKIGMMKK(int DKFJGBGJGBG, int PFMBMFKCOCP, int PHONMCNKGHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class ENCKECNEJMH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
	public ENCKECNEJMH(bool HHAABKHBOCD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class EEGLPEIFPAK : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDCE0", Offset = "0x7DDC8E0", VA = "0x187DDDCE0")]
	public EEGLPEIFPAK(string LAOCJKNALFF, string NFKNKHBBLBH = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class BCCLLEIMFDB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2312110", Offset = "0x2310D10", VA = "0x182312110")]
	public BCCLLEIMFDB(int OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum FGFFLMFPAEP
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
public interface EILPFCBDCMK
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GEPFMMMNJPE<T> : EILPFCBDCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOGICBDPBLD([In] APNGOIGBPIG ONDIHJGOKKJ, T OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MNDOBNLKHEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool AKCLHOMFGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DOOJLEJCODP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FJHJHMOLLAL(Type OPOPAMPKKGD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHFBAEOABIM(NativeParallelHashMap<int, HJOGNENAABH> BNCKDCNKIDE, NativeArray<byte> PEDMEJIDLNB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AHGJNPMOIHP
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CMNFMJNMLNI
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class PJKIBFNJIEF<T> : EJPMKCODEEH<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x42D10A0", Offset = "0x42CFCA0", VA = "0x1842D10A0")]
	protected PJKIBFNJIEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class EJPMKCODEEH<T> : GEPFMMMNJPE<T>, EILPFCBDCMK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4738450", Offset = "0x4737050", VA = "0x184738450")]
	public void JOGICBDPBLD([In] APNGOIGBPIG ONDIHJGOKKJ, T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	protected EJPMKCODEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4738430", Offset = "0x4737030", VA = "0x184738430", Slot = "4")]
	private void JFPNIBAFMHL([In] APNGOIGBPIG ONDIHJGOKKJ, T OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class AGJJAABMDIP<T> : GEPFMMMNJPE<NativeArray<T>>, EILPFCBDCMK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D64D70", Offset = "0x4D63970", VA = "0x184D64D70")]
	public void JOGICBDPBLD([In] APNGOIGBPIG ONDIHJGOKKJ, NativeArray<T> OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3025610", Offset = "0x3024210", VA = "0x183025610")]
	public static ReadOnlySpan<T> ELBFNGLDMHB<T>(NativeArray<T> IKALPCJBCLK) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	protected AGJJAABMDIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D64EC0", Offset = "0x4D63AC0", VA = "0x184D64EC0", Slot = "4")]
	private void PDIIANIFCHN([In] APNGOIGBPIG ONDIHJGOKKJ, NativeArray<T> OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JGMALEGBAPF : GEPFMMMNJPE<JGMALEGBAPF.HPAPNFNGOCD>, EILPFCBDCMK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct HPAPNFNGOCD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	public void JOGICBDPBLD([In] APNGOIGBPIG ONDIHJGOKKJ, HPAPNFNGOCD OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public JGMALEGBAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	private void EKEMBBDBMOP([In] APNGOIGBPIG ONDIHJGOKKJ, HPAPNFNGOCD OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FNGNCKHJKEK : GEPFMMMNJPE<string>, EILPFCBDCMK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly FNGNCKHJKEK LBPNLDGACAA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDD40", Offset = "0x7DDC940", VA = "0x187DDDD40")]
	public void JOGICBDPBLD([In] APNGOIGBPIG ONDIHJGOKKJ, string OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public FNGNCKHJKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDD30", Offset = "0x7DDC930", VA = "0x187DDDD30", Slot = "4")]
	private void EIMHEIPBCPO([In] APNGOIGBPIG ONDIHJGOKKJ, string OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class LKDGLKDKJHC<T> : KCPMOHGEKAF<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42D10A0", Offset = "0x42CFCA0", VA = "0x1842D10A0")]
	protected LKDGLKDKJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class KCPMOHGEKAF<T> : GEPFMMMNJPE<T>, EILPFCBDCMK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x51D1900", Offset = "0x51D0500", VA = "0x1851D1900")]
	public void JOGICBDPBLD([In] APNGOIGBPIG ONDIHJGOKKJ, T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	protected KCPMOHGEKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4738430", Offset = "0x4737030", VA = "0x184738430", Slot = "4")]
	private void JFPNIBAFMHL([In] APNGOIGBPIG ONDIHJGOKKJ, T OOHGFGHCOAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct APNGOIGBPIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct ILOHCKEEFNE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly APNGOIGBPIG ONDIHJGOKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int IMJOFJGBILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int FDNFPLFOEBG;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E01DD0", Offset = "0x5E009D0", VA = "0x185E01DD0")]
		public ILOHCKEEFNE(APNGOIGBPIG ONDIHJGOKKJ, int IMJOFJGBILA, int FDNFPLFOEBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE1A0", Offset = "0x7DDCDA0", VA = "0x187DDE1A0")]
		public ILOHCKEEFNE EFAIMLKFNCP(ReadOnlySpan<byte> PEDMEJIDLNB)
		{
			return default(ILOHCKEEFNE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x41A8060", Offset = "0x41A6C60", VA = "0x1841A8060")]
		public ILOHCKEEFNE EFAIMLKFNCP<T>(T PEDMEJIDLNB) where T : struct
		{
			return default(ILOHCKEEFNE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE100", Offset = "0x7DDCD00", VA = "0x187DDE100", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MNDOBNLKHEL KJKKCJEJMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, HJOGNENAABH> BNCKDCNKIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> PEDMEJIDLNB;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDB10", Offset = "0x7DDC710", VA = "0x187DDDB10")]
	public APNGOIGBPIG(MNDOBNLKHEL KJKKCJEJMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD7F0", Offset = "0x7DDC3F0", VA = "0x187DDD7F0")]
	public int HHAKMDDGEEL(EILPFCBDCMK PBIAIHKJAAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD8D0", Offset = "0x7DDC4D0", VA = "0x187DDD8D0")]
	public ILOHCKEEFNE KNCKKDKDOFM(EILPFCBDCMK PBIAIHKJAAI)
	{
		return default(ILOHCKEEFNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD9C0", Offset = "0x7DDC5C0", VA = "0x187DDD9C0")]
	public ILOHCKEEFNE KNCKKDKDOFM(int HPFNMOBOCGP)
	{
		return default(ILOHCKEEFNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD660", Offset = "0x7DDC260", VA = "0x187DDD660")]
	public void CJJJNINAOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDA70", Offset = "0x7DDC670", VA = "0x187DDDA70")]
	public APNGOIGBPIG LEAINMHIBHD()
	{
		return default(APNGOIGBPIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD790", Offset = "0x7DDC390", VA = "0x187DDD790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HBNEOAKKEND
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAD730", Offset = "0x3AAC330", VA = "0x183AAD730")]
	public static APNGOIGBPIG NKAMMCABBBC<T>([In] this APNGOIGBPIG ONDIHJGOKKJ, GEPFMMMNJPE<T> PBIAIHKJAAI, T OOHGFGHCOAJ)
	{
		return default(APNGOIGBPIG);
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
