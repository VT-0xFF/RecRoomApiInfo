using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DFDE30", Offset = "0x1DFD030", VA = "0x181DFDE30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GJPKLMKHCJB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDGOHDGIALA<NFDBFOHCHGK> NLDJACAJHPL(int FFDPLKDJAHD, bool DPPIMFJLDAD = true);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GHPKBMBLGGG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGIEMHEELDO NCLOHOCEABC(int EIJINCDNFGK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FGCPLDEGBNL([In] KGIEMHEELDO GDDELEBMDEF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JHKHHGKFBNM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDGOHDGIALA<NFDBFOHCHGK> SetEnabled(GJPKLMKHCJB OGMFBLJMCMJ, bool JMAJNODCNMN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EDGOHDGIALA<T> : IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class PHLKMBJDGHN<U> : IEnumerator<U>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly EDGOHDGIALA<U> DJLNBIADEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool PGBGAFBKGGL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public U KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF5CD50", Offset = "0xF5BF50", VA = "0x180F5CD50", Slot = "4")]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x343CF10", Offset = "0x343C110", VA = "0x18343CF10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x41B3410", Offset = "0x41B2610", VA = "0x1841B3410")]
		public PHLKMBJDGHN([In] EDGOHDGIALA<U> IFJGEIAONPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x41B3100", Offset = "0x41B2300", VA = "0x1841B3100", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD270", Offset = "0x3CAC470", VA = "0x183CAD270", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly object BBLCGLKFLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly T GGBOAAAHPCL;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34030C0", Offset = "0x34022C0", VA = "0x1834030C0")]
	private EDGOHDGIALA(object BBLCGLKFLKL, [In] T GGBOAAAHPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x34025D0", Offset = "0x34017D0", VA = "0x1834025D0")]
	public static EDGOHDGIALA<T> OKIHAMDEOGN(object BBLCGLKFLKL)
	{
		return default(EDGOHDGIALA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3401F30", Offset = "0x3401130", VA = "0x183401F30")]
	public static EDGOHDGIALA<T> OHOHEKGLDJF([In] T GGBOAAAHPCL)
	{
		return default(EDGOHDGIALA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x266A140", Offset = "0x2669340", VA = "0x18266A140")]
	public EDGOHDGIALA<U?> OKAMHLJKKGP<U>()
	{
		return default(EDGOHDGIALA<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3401A70", Offset = "0x3400C70", VA = "0x183401A70")]
	public EDGOHDGIALA<NFDBFOHCHGK> NDNPPGKDPDM()
	{
		return default(EDGOHDGIALA<NFDBFOHCHGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3401470", Offset = "0x3400670", VA = "0x183401470", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3402720", Offset = "0x3401920", VA = "0x183402720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3402CE0", Offset = "0x3401EE0", VA = "0x183402CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BCHMEOAOHEH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26466C0", Offset = "0x26458C0", VA = "0x1826466C0")]
	public static EDGOHDGIALA<T> OKIHAMDEOGN<T>(object BBLCGLKFLKL) where T : notnull
	{
		return default(EDGOHDGIALA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DFDDD0", Offset = "0x1DFCFD0", VA = "0x181DFDDD0")]
	public static EDGOHDGIALA<NFDBFOHCHGK> OKIHAMDEOGN(object BBLCGLKFLKL)
	{
		return default(EDGOHDGIALA<NFDBFOHCHGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x26466C0", Offset = "0x26458C0", VA = "0x1826466C0")]
	public static EDGOHDGIALA<T> OHOHEKGLDJF<T>([In] T GGBOAAAHPCL) where T : notnull
	{
		return default(EDGOHDGIALA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DFDD70", Offset = "0x1DFCF70", VA = "0x181DFDD70")]
	public static EDGOHDGIALA<NFDBFOHCHGK> OHOHEKGLDJF()
	{
		return default(EDGOHDGIALA<NFDBFOHCHGK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FEIIMBOHDNL
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate U GIGBKJKHCNL<T, U, Args>([In] T GGBOAAAHPCL, [In] Args FJIDAJDLPID);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x286E130", Offset = "0x286D330", VA = "0x18286E130")]
	public static bool NNIKGJJMJKF<T>([In] this EDGOHDGIALA<T> AOFIGDLFNLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xCED820", Offset = "0xCECA20", VA = "0x180CED820")]
	public static bool EIHEBJDACGC<T>([In] this EDGOHDGIALA<T> AOFIGDLFNLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x286E020", Offset = "0x286D220", VA = "0x18286E020")]
	public static EDGOHDGIALA<U?> MFIPKIHBFMI<U, T>([In] this EDGOHDGIALA<T> AOFIGDLFNLH, [In] EDGOHDGIALA<U> GGBOAAAHPCL)
	{
		return default(EDGOHDGIALA<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x286D720", Offset = "0x286C920", VA = "0x18286D720")]
	public static EDGOHDGIALA<U?> FBMHMOCACNN<U, T, Args>([In] this EDGOHDGIALA<T> AOFIGDLFNLH, [In] Args FJIDAJDLPID, GIGBKJKHCNL<T, EDGOHDGIALA<U>, Args> GGBOAAAHPCL)
	{
		return default(EDGOHDGIALA<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x286DEA0", Offset = "0x286D0A0", VA = "0x18286DEA0")]
	public static T KMBIFKEOFKC<T>([In] this EDGOHDGIALA<T> AOFIGDLFNLH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x286D8E0", Offset = "0x286CAE0", VA = "0x18286D8E0")]
	public static bool GLGFONIGLHF<T>([In] this EDGOHDGIALA<T> AOFIGDLFNLH, [Out] EDGOHDGIALA<T> BKHFGIKBFNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x286D2D0", Offset = "0x286C4D0", VA = "0x18286D2D0")]
	public static bool AMEEOJPNNKO<T>([In] this EDGOHDGIALA<T> AOFIGDLFNLH, [Out] T GGBOAAAHPCL, [Out] EDGOHDGIALA<T> BKHFGIKBFNG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x286E140", Offset = "0x286D340", VA = "0x18286E140")]
	public static bool NPILLGCDIDA<T>([In] this EDGOHDGIALA<T> AOFIGDLFNLH, [Out] T GGBOAAAHPCL, [Out] EDGOHDGIALA<NFDBFOHCHGK> BKHFGIKBFNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x286D610", Offset = "0x286C810", VA = "0x18286D610")]
	public static bool CMAGEHJLNEH<T, E>([In] this EDGOHDGIALA<T> AOFIGDLFNLH, [Out] E BBLCGLKFLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x286DCE0", Offset = "0x286CEE0", VA = "0x18286DCE0")]
	public static EDGOHDGIALA<T?> KFHHCJCHPIH<T>([In] this EDGOHDGIALA<EDGOHDGIALA<T>> AOFIGDLFNLH)
	{
		return default(EDGOHDGIALA<T>);
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
