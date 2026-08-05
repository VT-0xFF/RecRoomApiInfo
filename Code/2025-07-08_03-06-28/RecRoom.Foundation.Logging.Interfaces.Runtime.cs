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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class LPNGGMKAMDJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public LPNGGMKAMDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class MEELJMFIEEF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x80D0890", Offset = "0x80CF690", VA = "0x1880D0890")]
	public MEELJMFIEEF(int DFCCCGNJINK, int JBGACMEKIND, int OFILDDOHJNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class NDIGPLJOJDL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
	public NDIGPLJOJDL(bool GANDIEEKKBL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class HJMJMGGGAEJ : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80D0840", Offset = "0x80CF640", VA = "0x1880D0840")]
	public HJMJMGGGAEJ(string GGDFKFACHGG, string BKPMFKNMLEK = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class BGPFMOGGABB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HBDLGDLEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x23CF680", Offset = "0x23CE480", VA = "0x1823CF680")]
	public BGPFMOGGABB(int BNECONOIKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum FEBKDEKGIDG
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
public interface EEHAHLADPGB
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BIJILJIPFMD<T> : EEHAHLADPGB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFANMADPCOA([In] PGLHHJHEMCO EOHGHAHEKHI, T BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HJAJEKHBLNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OBPKPFKOJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int BGAMLCAGLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int DOHHMPBBDAA(Type DGPNPBEKOOD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMLIIEGLLJO(NativeParallelHashMap<int, PIHJPNGEKCI> FANOBLNBIII, NativeArray<byte> BOIPFNOKGBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IJKNHDOPFDM
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HKNJAFPHJNN
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class CHPDPNDHFEO<T> : EJFACOGOLPH<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x47D2410", Offset = "0x47D1210", VA = "0x1847D2410")]
	protected CHPDPNDHFEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class EJFACOGOLPH<T> : BIJILJIPFMD<T>, EEHAHLADPGB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4829A10", Offset = "0x4828810", VA = "0x184829A10")]
	public void JFANMADPCOA([In] PGLHHJHEMCO EOHGHAHEKHI, T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected EJFACOGOLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4829AF0", Offset = "0x48288F0", VA = "0x184829AF0", Slot = "4")]
	private void LDINLAFDOLL([In] PGLHHJHEMCO EOHGHAHEKHI, T BNECONOIKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class AHAMNJIODNH<T> : BIJILJIPFMD<NativeArray<T>>, EEHAHLADPGB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA8A0", Offset = "0x4FD96A0", VA = "0x184FDA8A0")]
	public void JFANMADPCOA([In] PGLHHJHEMCO EOHGHAHEKHI, NativeArray<T> BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x310E2D0", Offset = "0x310D0D0", VA = "0x18310E2D0")]
	public static ReadOnlySpan<T> JDPNDNCJKFL<T>(NativeArray<T> COPOPHFGNFG) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected AHAMNJIODNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA870", Offset = "0x4FD9670", VA = "0x184FDA870", Slot = "4")]
	private void ENCENECDMGJ([In] PGLHHJHEMCO EOHGHAHEKHI, NativeArray<T> BNECONOIKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PBDGGFKCIKI : BIJILJIPFMD<PBDGGFKCIKI.ANOMMIMOLPA>, EEHAHLADPGB
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct ANOMMIMOLPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	public void JFANMADPCOA([In] PGLHHJHEMCO EOHGHAHEKHI, ANOMMIMOLPA BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public PBDGGFKCIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	private void HEEKONBGPKB([In] PGLHHJHEMCO EOHGHAHEKHI, ANOMMIMOLPA BNECONOIKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MFFAEIHDJLP : BIJILJIPFMD<string>, EEHAHLADPGB
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly MFFAEIHDJLP ODAOEPEFKDK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80D08E0", Offset = "0x80CF6E0", VA = "0x1880D08E0")]
	public void JFANMADPCOA([In] PGLHHJHEMCO EOHGHAHEKHI, string BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public MFFAEIHDJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80D0C30", Offset = "0x80CFA30", VA = "0x1880D0C30", Slot = "4")]
	private void LBFJPOBECLL([In] PGLHHJHEMCO EOHGHAHEKHI, string BNECONOIKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class JKDDHIDJEFP<T> : NAFFAKGFJGK<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x47D2410", Offset = "0x47D1210", VA = "0x1847D2410")]
	protected JKDDHIDJEFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class NAFFAKGFJGK<T> : BIJILJIPFMD<T>, EEHAHLADPGB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x56CCA00", Offset = "0x56CB800", VA = "0x1856CCA00")]
	public void JFANMADPCOA([In] PGLHHJHEMCO EOHGHAHEKHI, T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected NAFFAKGFJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4829AF0", Offset = "0x48288F0", VA = "0x184829AF0", Slot = "4")]
	private void LDINLAFDOLL([In] PGLHHJHEMCO EOHGHAHEKHI, T BNECONOIKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PGLHHJHEMCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct NLCPFONKFDF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly PGLHHJHEMCO EOHGHAHEKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int MCFLOMJHKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int AIMJFKIFONJ;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6012990", Offset = "0x6011790", VA = "0x186012990")]
		public NLCPFONKFDF(PGLHHJHEMCO EOHGHAHEKHI, int MCFLOMJHKCN, int AIMJFKIFONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80D0D60", Offset = "0x80CFB60", VA = "0x1880D0D60")]
		public NLCPFONKFDF PFGAKGBJCPK(ReadOnlySpan<byte> BOIPFNOKGBJ)
		{
			return default(NLCPFONKFDF);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x42CCD10", Offset = "0x42CBB10", VA = "0x1842CCD10")]
		public NLCPFONKFDF PFGAKGBJCPK<T>(T BOIPFNOKGBJ) where T : struct
		{
			return default(NLCPFONKFDF);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80D0CC0", Offset = "0x80CFAC0", VA = "0x1880D0CC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HJAJEKHBLNK KFDCCKOHHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, PIHJPNGEKCI> FANOBLNBIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> BOIPFNOKGBJ;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80D1280", Offset = "0x80D0080", VA = "0x1880D1280")]
	public PGLHHJHEMCO(HJAJEKHBLNK KFDCCKOHHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80D0F50", Offset = "0x80CFD50", VA = "0x1880D0F50")]
	public int GAOPKLNJLHE(EEHAHLADPGB MHJAFOGOHPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80D1040", Offset = "0x80CFE40", VA = "0x1880D1040")]
	public NLCPFONKFDF NAFKDPGMCLF(EEHAHLADPGB MHJAFOGOHPI)
	{
		return default(NLCPFONKFDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80D1130", Offset = "0x80CFF30", VA = "0x1880D1130")]
	public NLCPFONKFDF NAFKDPGMCLF(int DODPPKFAICK)
	{
		return default(NLCPFONKFDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x80D0E20", Offset = "0x80CFC20", VA = "0x1880D0E20")]
	public void EACNAGEECPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80D11E0", Offset = "0x80CFFE0", VA = "0x1880D11E0")]
	public PGLHHJHEMCO PAEHAFKCBBG()
	{
		return default(PGLHHJHEMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x80D0DC0", Offset = "0x80CFBC0", VA = "0x1880D0DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BOCFNCMEMMM
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x393CB70", Offset = "0x393B970", VA = "0x18393CB70")]
	public static PGLHHJHEMCO OLHPIGGMIDE<T>([In] this PGLHHJHEMCO EOHGHAHEKHI, BIJILJIPFMD<T> MHJAFOGOHPI, T BNECONOIKOE)
	{
		return default(PGLHHJHEMCO);
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
