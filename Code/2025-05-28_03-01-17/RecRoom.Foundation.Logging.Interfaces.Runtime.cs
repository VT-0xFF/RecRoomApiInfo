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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class GEJNCCKDOIH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
	public GEJNCCKDOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class IAMBADFPBFA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DB37A0", Offset = "0x7DB25A0", VA = "0x187DB37A0")]
	public IAMBADFPBFA(int ACINDEOBNPO, int JDDDCNMAAOG, int FIIJKNAAOPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class GNOBCBEPHLJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
	public GNOBCBEPHLJ(bool JHDPIMJPFEK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class LIOLMMKBFCO : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3EA0", Offset = "0x7DB2CA0", VA = "0x187DB3EA0")]
	public LIOLMMKBFCO(string IHGFMOMOADA, string CDDMBEEGKND = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class KAIDGMEKCNI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x21D0850", Offset = "0x21CF650", VA = "0x1821D0850")]
	public KAIDGMEKCNI(int OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum OJMIHHBLGGJ
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
public interface KGALNOIHAND
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EFFJFNNJJCM<T> : KGALNOIHAND
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EAMCFOEOOMO([In] KCOMIDCFFCP HDCKJGHCJID, T OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PCJCKAMOFPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JOJNIEGFDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ABCANDCDOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BGHKGNHKADO(Type AAFMBEEMJAC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IEIAMOCHJOE(NativeParallelHashMap<int, MAINECODIKP> MIBGBKPCNLH, NativeArray<byte> FFEMKICJPKP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OPAMBPHIAGA
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class DOGDFMMNMCE
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class APPOHPDFEAD<T> : FIOLFGMAOFH<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4592CE0", Offset = "0x4591AE0", VA = "0x184592CE0")]
	protected APPOHPDFEAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class FIOLFGMAOFH<T> : EFFJFNNJJCM<T>, KGALNOIHAND where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF490", Offset = "0x4ACE290", VA = "0x184ACF490")]
	public void EAMCFOEOOMO([In] KCOMIDCFFCP HDCKJGHCJID, T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected FIOLFGMAOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF570", Offset = "0x4ACE370", VA = "0x184ACF570", Slot = "4")]
	private void JECFDANKJOJ([In] KCOMIDCFFCP HDCKJGHCJID, T OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class PEJNDEFCCAC<T> : EFFJFNNJJCM<NativeArray<T>>, KGALNOIHAND where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57740D0", Offset = "0x5772ED0", VA = "0x1857740D0")]
	public void EAMCFOEOOMO([In] KCOMIDCFFCP HDCKJGHCJID, NativeArray<T> OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3ED0", Offset = "0x3AD2CD0", VA = "0x183AD3ED0")]
	public static ReadOnlySpan<T> JOJJDFCPHLF<T>(NativeArray<T> KNDCNOIHMGO) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected PEJNDEFCCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5774240", Offset = "0x5773040", VA = "0x185774240", Slot = "4")]
	private void GPALMLGPCNP([In] KCOMIDCFFCP HDCKJGHCJID, NativeArray<T> OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IDBJLLPBEKP : EFFJFNNJJCM<IDBJLLPBEKP.LHKFHJBEGAD>, KGALNOIHAND
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct LHKFHJBEGAD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	public void EAMCFOEOOMO([In] KCOMIDCFFCP HDCKJGHCJID, LHKFHJBEGAD OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IDBJLLPBEKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	private void LHPJMMNGPDE([In] KCOMIDCFFCP HDCKJGHCJID, LHKFHJBEGAD OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HEOLONKEKFH : EFFJFNNJJCM<string>, KGALNOIHAND
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HEOLONKEKFH ICOFMPPJNFC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DB33C0", Offset = "0x7DB21C0", VA = "0x187DB33C0")]
	public void EAMCFOEOOMO([In] KCOMIDCFFCP HDCKJGHCJID, string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HEOLONKEKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3710", Offset = "0x7DB2510", VA = "0x187DB3710", Slot = "4")]
	private void MLKEMEBCAIN([In] KCOMIDCFFCP HDCKJGHCJID, string OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class FAEIIJIKABA<T> : BEBLMPGKFEJ<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4592CE0", Offset = "0x4591AE0", VA = "0x184592CE0")]
	protected FAEIIJIKABA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class BEBLMPGKFEJ<T> : EFFJFNNJJCM<T>, KGALNOIHAND where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x607F1C0", Offset = "0x607DFC0", VA = "0x18607F1C0")]
	public void EAMCFOEOOMO([In] KCOMIDCFFCP HDCKJGHCJID, T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected BEBLMPGKFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4ACF570", Offset = "0x4ACE370", VA = "0x184ACF570", Slot = "4")]
	private void JECFDANKJOJ([In] KCOMIDCFFCP HDCKJGHCJID, T OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KCOMIDCFFCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct GJDKKNEEACK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly KCOMIDCFFCP HDCKJGHCJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int LPHACOCNBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int BLOAHMJLILP;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE230", Offset = "0x5DED030", VA = "0x185DEE230")]
		public GJDKKNEEACK(KCOMIDCFFCP HDCKJGHCJID, int LPHACOCNBCD, int BLOAHMJLILP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7DB32C0", Offset = "0x7DB20C0", VA = "0x187DB32C0")]
		public GJDKKNEEACK ABEAMNJEFOP(ReadOnlySpan<byte> FFEMKICJPKP)
		{
			return default(GJDKKNEEACK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x406F9C0", Offset = "0x406E7C0", VA = "0x18406F9C0")]
		public GJDKKNEEACK ABEAMNJEFOP<T>(T FFEMKICJPKP) where T : struct
		{
			return default(GJDKKNEEACK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3320", Offset = "0x7DB2120", VA = "0x187DB3320", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PCJCKAMOFPO NKOHJLKNDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, MAINECODIKP> MIBGBKPCNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> FFEMKICJPKP;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3CB0", Offset = "0x7DB2AB0", VA = "0x187DB3CB0")]
	public KCOMIDCFFCP(PCJCKAMOFPO NKOHJLKNDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3850", Offset = "0x7DB2650", VA = "0x187DB3850")]
	public int EHCAEEJJNBM(KGALNOIHAND NLHBNAANHME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3BC0", Offset = "0x7DB29C0", VA = "0x187DB3BC0")]
	public GJDKKNEEACK OOGAPJEKPFC(KGALNOIHAND NLHBNAANHME)
	{
		return default(GJDKKNEEACK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3B10", Offset = "0x7DB2910", VA = "0x187DB3B10")]
	public GJDKKNEEACK OOGAPJEKPFC(int MEECHLKLPEB)
	{
		return default(GJDKKNEEACK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DB39E0", Offset = "0x7DB27E0", VA = "0x187DB39E0")]
	public void ODFOIKANOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3940", Offset = "0x7DB2740", VA = "0x187DB3940")]
	public KCOMIDCFFCP JMFEKBCNPCJ()
	{
		return default(KCOMIDCFFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DB37F0", Offset = "0x7DB25F0", VA = "0x187DB37F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class FLKGAKBPGBA
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38EA4D0", Offset = "0x38E92D0", VA = "0x1838EA4D0")]
	public static KCOMIDCFFCP AIKICPLLADB<T>([In] this KCOMIDCFFCP HDCKJGHCJID, EFFJFNNJJCM<T> NLHBNAANHME, T OAIIHELJHLG)
	{
		return default(KCOMIDCFFCP);
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
