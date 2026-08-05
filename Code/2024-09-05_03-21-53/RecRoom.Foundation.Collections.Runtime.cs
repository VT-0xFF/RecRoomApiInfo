using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Foundation_Collections_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BA3B10", Offset = "0x6BA2510", VA = "0x186BA3B10", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IPMMMJPOJLA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BA36F0", Offset = "0x6BA20F0", VA = "0x186BA36F0")]
	public static void FKPJGAHOMGC(this GameObject EABKFLBGOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3650", Offset = "0x6BA2050", VA = "0x186BA3650")]
	public static void FKPJGAHOMGC(this Component PHMJIJLHMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3790", Offset = "0x6BA2190", VA = "0x186BA3790")]
	public static void FKPJGAHOMGC(this ScriptableObject KHEJPNPICPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IOKOHJOFFJK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3540", Offset = "0x6BA1F40", VA = "0x186BA3540")]
	public static Span<byte> LPIAOIOODEH(this NativeArray<byte> FNCIFDCGDBA)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3490", Offset = "0x6BA1E90", VA = "0x186BA3490")]
	public static ReadOnlySpan<byte> DDCGBLLLEDH(this NativeArray<byte> FNCIFDCGDBA)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7AE0", Offset = "0x2CE64E0", VA = "0x182CE7AE0")]
	public static NativeArray<T> LBOMDLPLCPJ<T>(this NativeArray<T> FNCIFDCGDBA, FHFJABPJBIK IMMNAIPHFMF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7AA0", Offset = "0x2CE64A0", VA = "0x182CE7AA0")]
	public static NativeArray<T> LBOMDLPLCPJ<T>(this NativeArray<T> FNCIFDCGDBA, int PJOMFOPGCGL) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IAMNHBBNLGN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2CCAB80", Offset = "0x2CC9580", VA = "0x182CCAB80")]
	public static string NDBHBMMIPKH<T>(this NativeArray<T> FNCIFDCGDBA, string KNLJKPLPEGB = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HOAIJMNBGAG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CBE320", Offset = "0x2CBCD20", VA = "0x182CBE320")]
	public static T PHNOCPFLPNG<T>([In] this ReadOnlySpan<byte> NDDLKNGECEN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2CBEAC0", Offset = "0x2CBD4C0", VA = "0x182CBEAC0")]
	public static T PHNOCPFLPNG<T>([In] this Span<byte> NDDLKNGECEN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC8F0", Offset = "0x2CBB2F0", VA = "0x182CBC8F0")]
	public static NativeArray<T> CGNMBCFOPFH<T>(this ReadOnlySpan<byte> NDDLKNGECEN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2C812C0", Offset = "0x2C7FCC0", VA = "0x182C812C0")]
	public static ReadOnlySpan<TTo> CIKOGIKHJLA<TTo, TFrom>(this ReadOnlySpan<TFrom> NDDLKNGECEN) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD120", Offset = "0x2CBBB20", VA = "0x182CBD120")]
	public static Span<byte> IDPEEMDPGBG<T>([In] this Span<byte> NDDLKNGECEN, T CLMKDBDPNNH) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2DD0", Offset = "0x6BA17D0", VA = "0x186BA2DD0")]
	private static Enum OOBLEIFICDN([In] ReadOnlySpan<byte> NDDLKNGECEN, Type MMMHMMDBHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2D60", Offset = "0x6BA1760", VA = "0x186BA2D60")]
	public static Enum MNOLOONDGAM([In] this Span<byte> NDDLKNGECEN, Type MMMHMMDBHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2850", Offset = "0x6BA1250", VA = "0x186BA2850")]
	public static void KDLKPFIKHLB([In] this Span<byte> NDDLKNGECEN, Enum NPGBIOOADNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GEAFIIPHEEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GDJBAEBHEFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6BA25B0", Offset = "0x6BA0FB0", VA = "0x186BA25B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2730", Offset = "0x6BA1130", VA = "0x186BA2730")]
	[AsyncStateMachine(typeof(GDJBAEBHEFD))]
	public static void HFANMLLNLBH(this Task LJDCGGEFKLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IPGIGJJCMNI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum NCGOFGJALCP : short
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Uncategorized = 4,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		ObjectModel,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		SplineWrapper,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Scalability,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		UpdateAllocator,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Snapshot,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		ShadowEntities,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		PostLoadNetworkIdSystem,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Singleton,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		COUNT
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct AKAMLHJCGKF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly NCGOFGJALCP JODEIIFHAPK;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2648E10", Offset = "0x2647810", VA = "0x182648E10")]
		public AKAMLHJCGKF(NCGOFGJALCP JODEIIFHAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory PMPHJFMHGDH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6BA35F0", Offset = "0x6BA1FF0", VA = "0x186BA35F0")]
	static IPGIGJJCMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29AFDB0", Offset = "0x29AE7B0", VA = "0x1829AFDB0")]
	public static AKAMLHJCGKF LDKCFDCKOBE(NCGOFGJALCP JODEIIFHAPK)
	{
		return default(AKAMLHJCGKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void NDMOGAPHMJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class HOGHJPHDJNN<THandle, TValue> : IDisposable where THandle : struct, LCMEFFHGKGH where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> AJBLMIKCHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> ACOKCANBLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> DJDOABDPDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> FDBADCCBEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int CDPLCOKMICF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3EF72A0", Offset = "0x3EF5CA0", VA = "0x183EF72A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7FC0", Offset = "0x3EF69C0", VA = "0x183EF7FC0")]
	public HOGHJPHDJNN(Action<TValue> FDBADCCBEPD, [Optional] Func<TValue> DJDOABDPDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF72E0", Offset = "0x3EF5CE0", VA = "0x183EF72E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF73C0", Offset = "0x3EF5DC0", VA = "0x183EF73C0")]
	public THandle EGHPKMGPEOO(TValue CLMKDBDPNNH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7680", Offset = "0x3EF6080", VA = "0x183EF7680")]
	public bool EPGEGEJNIJO(THandle OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7CA0", Offset = "0x3EF66A0", VA = "0x183EF7CA0")]
	public bool MJGHNDKEOOO(THandle OMKGKCDECFC, [Out] TValue CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7EA0", Offset = "0x3EF68A0", VA = "0x183EF7EA0")]
	public TValue PHNOCPFLPNG(THandle OMKGKCDECFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7B10", Offset = "0x3EF6510", VA = "0x183EF7B10")]
	public bool KAMLGAEHELA(THandle OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7C30", Offset = "0x3EF6630", VA = "0x183EF7C30")]
	private THandle KECELNKEKAP(int EBDDHAPIAHH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EF77B0", Offset = "0x3EF61B0", VA = "0x183EF77B0")]
	private TValue FBCNBGDNDPI(int EBDDHAPIAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7470", Offset = "0x3EF5E70", VA = "0x183EF7470")]
	private void EGKJNIKEOCK(int EBDDHAPIAHH, [In] THandle OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7250", Offset = "0x3EF5C50", VA = "0x183EF7250")]
	private void DLCIEAOOIGC(int EBDDHAPIAHH, [In] TValue CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EF74C0", Offset = "0x3EF5EC0", VA = "0x183EF74C0")]
	private THandle EOOIKMMJJAO()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7D80", Offset = "0x3EF6780", VA = "0x183EF7D80")]
	private void PHNHFMKKKAE(THandle OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7C90", Offset = "0x3EF6690", VA = "0x183EF7C90")]
	private int MDOFELCAMEJ(int DHAIIPINBBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7D70", Offset = "0x3EF6770", VA = "0x183EF7D70")]
	private bool NHDKGHHKNHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x886980", Offset = "0x885380", VA = "0x180886980")]
	private void OPNNKAFJGIL(THandle OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7F00", Offset = "0x3EF6900", VA = "0x183EF7F00")]
	private bool PNMGLIDHAMB([Out] THandle OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7810", Offset = "0x3EF6210", VA = "0x183EF7810")]
	private bool FPACLIJGGNF([Out] THandle OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7190", Offset = "0x3EF5B90", VA = "0x183EF7190")]
	private void CIOGLLNFDKP(THandle OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7950", Offset = "0x3EF6350", VA = "0x183EF7950")]
	private void IBLCEAMMFMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LCMEFFHGKGH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int MOMFAOPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int EBJFPPIDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HPMKAINECII
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2CC07F0", Offset = "0x2CBF1F0", VA = "0x182CC07F0")]
	public static bool NOFLCBHGJNJ<T>(this T OMKGKCDECFC, T AIPFCMFLDKG) where T : struct, LCMEFFHGKGH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2CC07E0", Offset = "0x2CBF1E0", VA = "0x182CC07E0")]
	public static bool IMCHLNDGPGF<T>(this T OMKGKCDECFC) where T : struct, LCMEFFHGKGH
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3380", Offset = "0x6BA1D80", VA = "0x186BA3380")]
	public static string HBPKDFLHFPN(this LCMEFFHGKGH OMKGKCDECFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct DIHDMLIICIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type LBDKHKPGIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> DEMNGAHLHCI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x44078F0", Offset = "0x44062F0", VA = "0x1844078F0")]
	public DIHDMLIICIG(Type DKFFFIFLBCK, Span<byte> NDDLKNGECEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEAF0", Offset = "0x2AFD4F0", VA = "0x182AFEAF0")]
	public static DIHDMLIICIG KPJFEGJLPPI<T>(T CLMKDBDPNNH) where T : struct
	{
		return default(DIHDMLIICIG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2470", Offset = "0x6BA0E70", VA = "0x186BA2470")]
	public static LNHCPJIMKAE PFMAFNCLKDD([In] DIHDMLIICIG FJIOIPCNGKD)
	{
		return default(LNHCPJIMKAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFBF0", Offset = "0x2AFE5F0", VA = "0x182AFFBF0")]
	public T PHNOCPFLPNG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BA23F0", Offset = "0x6BA0DF0", VA = "0x186BA23F0")]
	public Enum MNOLOONDGAM(Type MMMHMMDBHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE3C0", Offset = "0x2AFCDC0", VA = "0x182AFE3C0")]
	public void IDPEEMDPGBG<T>([In] T CLMKDBDPNNH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BA23E0", Offset = "0x6BA0DE0", VA = "0x186BA23E0")]
	public void KDLKPFIKHLB(Enum NPGBIOOADNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct LNHCPJIMKAE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct NBHOGNPPFOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* GIECACIBMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* LIPHJHKEMKG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type LBDKHKPGIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> DEMNGAHLHCI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GCMPBODBNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6BA3830", Offset = "0x6BA2230", VA = "0x186BA3830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x44078F0", Offset = "0x44062F0", VA = "0x1844078F0")]
	public LNHCPJIMKAE(Type DKFFFIFLBCK, ReadOnlySpan<byte> NDDLKNGECEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D433A0", Offset = "0x2D41DA0", VA = "0x182D433A0")]
	public static LNHCPJIMKAE KPJFEGJLPPI<T>(T CLMKDBDPNNH) where T : struct
	{
		return default(LNHCPJIMKAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D43220", Offset = "0x2D41C20", VA = "0x182D43220")]
	public static LNHCPJIMKAE KPJFEGJLPPI<T>(NativeArray<T> CLMKDBDPNNH) where T : struct
	{
		return default(LNHCPJIMKAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BA39A0", Offset = "0x6BA23A0", VA = "0x186BA39A0")]
	public void LNEHFAGGEJB(Span<byte> KJGHHJDIMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3A00", Offset = "0x6BA2400", VA = "0x186BA3A00")]
	public void LNEHFAGGEJB(NativeArray<byte> KJGHHJDIMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D460F0", Offset = "0x2D44AF0", VA = "0x182D460F0")]
	public T PHNOCPFLPNG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2D426D0", Offset = "0x2D410D0", VA = "0x182D426D0")]
	public NativeArray<T> CGNMBCFOPFH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3AD0", Offset = "0x6BA24D0", VA = "0x186BA3AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BA3870", Offset = "0x6BA2270", VA = "0x186BA3870")]
	private object JJEIHOPDDGE()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OMAJLBMIFOF
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2E16A30", Offset = "0x2E15430", VA = "0x182E16A30")]
	public static NativeArray<T> LGBAPJMAHFJ<T>(T CLMKDBDPNNH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E16990", Offset = "0x2E15390", VA = "0x182E16990")]
	public static NativeArray<T> JKEJHMHAFIG<T>(T CLMKDBDPNNH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E169E0", Offset = "0x2E153E0", VA = "0x182E169E0")]
	public static NativeArray<T> KPJFEGJLPPI<T>(T CLMKDBDPNNH, bool POLJDPHJFMD) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IMMFPKIOCBC<Handle> where Handle : LCMEFFHGKGH, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct BOJHOAOCMGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly IMMFPKIOCBC<Handle> EFIHMNMKKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int EBDDHAPIAHH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle AEBGDBCFPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x50714B0", Offset = "0x506FEB0", VA = "0x1850714B0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5071A30", Offset = "0x5070430", VA = "0x185071A30")]
		public BOJHOAOCMGA(IMMFPKIOCBC<Handle> EFIHMNMKKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5071630", Offset = "0x5070030", VA = "0x185071630")]
		public FHPEHIDALII MMKGNMBHOIH([In] FHPEHIDALII AHPMMDKKKFB)
		{
			return default(FHPEHIDALII);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5071910", Offset = "0x5070310", VA = "0x185071910")]
		public bool NFOMNEMJJDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5071150", Offset = "0x506FB50", VA = "0x185071150")]
		private Handle FFHLGLLLDCE(string MEBLNPKEJMN)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct FHPEHIDALII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private BOJHOAOCMGA JPKJNJLENNO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3D4C9B0", Offset = "0x3D4B3B0", VA = "0x183D4C9B0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3D4CAB0", Offset = "0x3D4B4B0", VA = "0x183D4CAB0")]
		public FHPEHIDALII(IMMFPKIOCBC<Handle> EFIHMNMKKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4CA70", Offset = "0x3D4B470", VA = "0x183D4CA70")]
		public bool NFOMNEMJJDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C8B0", Offset = "0x3D4B2B0", VA = "0x183D4C8B0")]
		public FHPEHIDALII BPGPEIEKEPK()
		{
			return default(FHPEHIDALII);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> KGHEOFMCPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> IDGPNECLBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int NADIOEAIJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int KBIAFOOGPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool ELHCCLADJJJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EGBHAHKNAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4029780", Offset = "0x4028180", VA = "0x184029780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FHPEHIDALII PMCMMFOOGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4029DE0", Offset = "0x40287E0", VA = "0x184029DE0")]
		get
		{
			return default(FHPEHIDALII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x402B120", Offset = "0x4029B20", VA = "0x18402B120")]
	public IMMFPKIOCBC(int GPFHCNENELE, Allocator MDICAPEDFAK = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x402A480", Offset = "0x4028E80", VA = "0x18402A480")]
	public void LCECLFEFOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1A28D90", Offset = "0x1A27790", VA = "0x181A28D90")]
	public static int MDOFELCAMEJ(int OEHMKJHGMIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x267D5C0", Offset = "0x267BFC0", VA = "0x18267D5C0")]
	public static bool KFEPLIJGANK(int OEHMKJHGMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x402A8F0", Offset = "0x40292F0", VA = "0x18402A8F0")]
	public bool LLHGFEAAEMJ(int EBDDHAPIAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4028AD0", Offset = "0x40274D0", VA = "0x184028AD0")]
	public bool DBJMBFKJBHA(Handle OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4029F50", Offset = "0x4028950", VA = "0x184029F50")]
	public Handle JBPLJFGFOCF()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4029450", Offset = "0x4027E50", VA = "0x184029450")]
	public void DMILHAIIOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x402A540", Offset = "0x4028F40", VA = "0x18402A540")]
	public void LGLJKCIOJNK(Handle OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x402A250", Offset = "0x4028C50", VA = "0x18402A250")]
	public bool JJIEKIOHNKH(Handle OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8FEDF0", Offset = "0x8FD7F0", VA = "0x1808FEDF0")]
	private bool KFOFOLOBGAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4029D80", Offset = "0x4028780", VA = "0x184029D80")]
	private bool FPKBLGJMEBJ(int EBDDHAPIAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x40299C0", Offset = "0x40283C0", VA = "0x1840299C0")]
	private void FNADJEGLMDP([Out] int EBDDHAPIAHH, [Out] int DHAIIPINBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x402ACD0", Offset = "0x40296D0", VA = "0x18402ACD0")]
	private void NOPOIEPDGIJ(Handle OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x402B080", Offset = "0x4029A80", VA = "0x18402B080")]
	private void PAJCKFAACOC(int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x402AF80", Offset = "0x4029980", VA = "0x18402AF80")]
	private bool OKOCFKFKBBF([Out] int EBDDHAPIAHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4028790", Offset = "0x4027190", VA = "0x184028790")]
	private static Handle BIOMBENKGBA(int EBDDHAPIAHH, int DHAIIPINBBD)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct PMDDMLENNFO<Handle, T> where Handle : LCMEFFHGKGH, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private IMMFPKIOCBC<Handle> JONLNCOMLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] MCCFEGCOMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> NHKHPOCLCGD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x493A540", Offset = "0x4938F40", VA = "0x18493A540")]
	public PMDDMLENNFO(int GPFHCNENELE, [Optional] Action<T> NHKHPOCLCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4939B10", Offset = "0x4938510", VA = "0x184939B10")]
	public void LCECLFEFOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x493A220", Offset = "0x4938C20", VA = "0x18493A220")]
	public bool MJGHNDKEOOO(Handle OMKGKCDECFC, [Out] T GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4938FB0", Offset = "0x49379B0", VA = "0x184938FB0")]
	public Handle EGHPKMGPEOO(T GIGIFGONEAO)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4939360", Offset = "0x4937D60", VA = "0x184939360")]
	public void KNDKFICDNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4939EA0", Offset = "0x49388A0", VA = "0x184939EA0")]
	public void MIOFMOMIMDC(Handle OMKGKCDECFC, [Out] T GNKDOAMAMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x493A140", Offset = "0x4938B40", VA = "0x18493A140")]
	public void MIOFMOMIMDC(Handle OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4938AF0", Offset = "0x49374F0", VA = "0x184938AF0")]
	public bool CMHOELCPHFG(Handle OMKGKCDECFC, [Out] T GNKDOAMAMHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4938DC0", Offset = "0x49377C0", VA = "0x184938DC0")]
	public bool CMHOELCPHFG(Handle OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4939300", Offset = "0x4937D00", VA = "0x184939300")]
	private T GFOJIDBFMJC(int EBDDHAPIAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4939A50", Offset = "0x4938450", VA = "0x184939A50")]
	private void KNPKFNELOJF(int DCIHBINMBDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct DOOBIIMPONE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] OIGMDCDEKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int OMBKDMFPMFJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x20DE2D0", Offset = "0x20DCCD0", VA = "0x1820DE2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2AB74A0", Offset = "0x2AB5EA0", VA = "0x182AB74A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> DEMNGAHLHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5A9B010", Offset = "0x5A99A10", VA = "0x185A9B010")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DNMEJBJAJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1030C10", Offset = "0x102F610", VA = "0x181030C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5A9B230", Offset = "0x5A99C30", VA = "0x185A9B230")]
	public DOOBIIMPONE(int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5A9B0B0", Offset = "0x5A99AB0", VA = "0x185A9B0B0")]
	public int FKEKIHAMDBP(T CLMKDBDPNNH, int PJOMFOPGCGL, int KFBJHPBJLOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5A9AF00", Offset = "0x5A99900", VA = "0x185A9AF00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct HMEICMNDOOE<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct LMMODMPDABK : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private HMEICMNDOOE<T> JNHGBAGBHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int EBDDHAPIAHH;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x443E470", Offset = "0x443CE70", VA = "0x18443E470", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x443E510", Offset = "0x443CF10", VA = "0x18443E510", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x443E4E0", Offset = "0x443CEE0", VA = "0x18443E4E0")]
		public LMMODMPDABK(HMEICMNDOOE<T> JNHGBAGBHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x443E3E0", Offset = "0x443CDE0", VA = "0x18443E3E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x443E420", Offset = "0x443CE20", VA = "0x18443E420", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private DOOBIIMPONE<T> OIGMDCDEKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int OMBKDMFPMFJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF720", Offset = "0x3EEE120", VA = "0x183EEF720")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3EEFCE0", Offset = "0x3EEE6E0", VA = "0x183EEFCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int EGBHAHKNAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF9C0", Offset = "0x3EEE3C0", VA = "0x183EEF9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DNMEJBJAJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3EEFC40", Offset = "0x3EEE640", VA = "0x183EEFC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> DEMNGAHLHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF900", Offset = "0x3EEE300", VA = "0x183EEF900")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0170", Offset = "0x3EEEB70", VA = "0x183EF0170")]
	public HMEICMNDOOE(int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3EEFC80", Offset = "0x3EEE680", VA = "0x183EEFC80")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF7F0", Offset = "0x3EEE1F0", VA = "0x183EEF7F0")]
	public void EGHPKMGPEOO(T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3EEFE80", Offset = "0x3EEE880", VA = "0x183EEFE80")]
	internal void OGDNNCBEOBI(int HBMOJAPOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3EEFA70", Offset = "0x3EEE470", VA = "0x183EEFA70")]
	public void GMDLAMIAKHP(int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF2C0", Offset = "0x3EEDCC0", VA = "0x183EEF2C0")]
	public void ABDPBIGLDDM(int PONKDNGCGIF, int OAACEGBODFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF9F0", Offset = "0x3EEE3F0", VA = "0x183EEF9F0")]
	public int FKEKIHAMDBP(T CLMKDBDPNNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF7B0", Offset = "0x3EEE1B0", VA = "0x183EEF7B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3EEFB60", Offset = "0x3EEE560", VA = "0x183EEFB60", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF00C0", Offset = "0x3EEEAC0", VA = "0x183EF00C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0100", Offset = "0x3EEEB00", VA = "0x183EF0100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3EEFD30", Offset = "0x3EEE730", VA = "0x183EEFD30")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void OBCPCGNNJLL(int CLMKDBDPNNH, int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF510", Offset = "0x3EEDF10", VA = "0x183EEF510")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void BPBKANHBBDD(int PONKDNGCGIF, int OAACEGBODFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FHFJABPJBIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int ELDAPMPELBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int KFBJHPBJLOG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int JGJBOLABHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2664280", Offset = "0x2662C80", VA = "0x182664280")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5F77A80", Offset = "0x5F76480", VA = "0x185F77A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EJCIFOMGCAH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JNJBOFHMEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA2510", Offset = "0x6BA0F10", VA = "0x186BA2510")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA24F0", Offset = "0x6BA0EF0", VA = "0x186BA24F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
	private FHFJABPJBIK(int ELDAPMPELBH, int KFBJHPBJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x20BF570", Offset = "0x20BDF70", VA = "0x1820BF570")]
	public static FHFJABPJBIK BCFPJNJDJDP(int ELDAPMPELBH, int KFBJHPBJLOG)
	{
		return default(FHFJABPJBIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2500", Offset = "0x6BA0F00", VA = "0x186BA2500")]
	public static FHFJABPJBIK HGGLKGHHKAH(int PJOMFOPGCGL, int OAACEGBODFP)
	{
		return default(FHFJABPJBIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2520", Offset = "0x6BA0F20", VA = "0x186BA2520", Slot = "3")]
	public override string ToString()
	{
		return null;
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
