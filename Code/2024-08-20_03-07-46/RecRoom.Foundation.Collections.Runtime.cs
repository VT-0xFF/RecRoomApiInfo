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
	public class LogRegistrationIndex : AGBKNAFJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6974040", Offset = "0x6973040", VA = "0x186974040", Slot = "4")]
		public override void GGLLICMBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JEAHMMLKGCN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6973300", Offset = "0x6972300", VA = "0x186973300")]
	public static void OMGGGHGPJFH(this GameObject IDHOMJBMFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69731C0", Offset = "0x69721C0", VA = "0x1869731C0")]
	public static void OMGGGHGPJFH(this Component EMPBMFAFICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6973260", Offset = "0x6972260", VA = "0x186973260")]
	public static void OMGGGHGPJFH(this ScriptableObject KGKADHCEEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FGJEKELIOPK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6972E90", Offset = "0x6971E90", VA = "0x186972E90")]
	public static Span<byte> CIOFCDFEFFA(this NativeArray<byte> IKONNGGNFPH)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6972F40", Offset = "0x6971F40", VA = "0x186972F40")]
	public static ReadOnlySpan<byte> IGBJLECCOBF(this NativeArray<byte> IKONNGGNFPH)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7190", Offset = "0x2BA6190", VA = "0x182BA7190")]
	public static NativeArray<T> LHNBPHFCPPI<T>(this NativeArray<T> IKONNGGNFPH, HPLFBCPLACJ EKCCFIDJBEH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2BA71D0", Offset = "0x2BA61D0", VA = "0x182BA71D0")]
	public static NativeArray<T> LHNBPHFCPPI<T>(this NativeArray<T> IKONNGGNFPH, int KKONFBKDDLI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PJDPFMBGFNK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BB90", Offset = "0x2D7AB90", VA = "0x182D7BB90")]
	public static string HKEKPNOCJOJ<T>(this NativeArray<T> IKONNGGNFPH, string AMHGOEIHNBH = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JIBLPJNMPHK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CDD0", Offset = "0x2C1BDD0", VA = "0x182C1CDD0")]
	public static T MKHPGHPCCLG<T>([In] this ReadOnlySpan<byte> BJHMMIELEHD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CCC0", Offset = "0x2C1BCC0", VA = "0x182C1CCC0")]
	public static T MKHPGHPCCLG<T>([In] this Span<byte> BJHMMIELEHD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B2D0", Offset = "0x2C1A2D0", VA = "0x182C1B2D0")]
	public static NativeArray<T> BNPBOBIONOJ<T>(this ReadOnlySpan<byte> BJHMMIELEHD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB3E0", Offset = "0x2BDA3E0", VA = "0x182BDB3E0")]
	public static ReadOnlySpan<TTo> FBKDJHNKLJP<TTo, TFrom>(this ReadOnlySpan<TFrom> BJHMMIELEHD) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BBA0", Offset = "0x2C1ABA0", VA = "0x182C1BBA0")]
	public static Span<byte> HACKMLKKHNE<T>([In] this Span<byte> BJHMMIELEHD, T JJCEIJMGOAB) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6973920", Offset = "0x6972920", VA = "0x186973920")]
	private static Enum LLEOEHGMMGN([In] ReadOnlySpan<byte> BJHMMIELEHD, Type OOJEFOLNJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69733A0", Offset = "0x69723A0", VA = "0x1869733A0")]
	public static Enum ENJJFPFDLMB([In] this Span<byte> BJHMMIELEHD, Type OOJEFOLNJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6973410", Offset = "0x6972410", VA = "0x186973410")]
	public static void FEJIPEGLKIF([In] this Span<byte> BJHMMIELEHD, Enum EIIABACMOFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PEEAGKLNKJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct KGEFEAFKJOB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6973EC0", Offset = "0x6972EC0", VA = "0x186973EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6974140", Offset = "0x6973140", VA = "0x186974140")]
	[AsyncStateMachine(typeof(KGEFEAFKJOB))]
	public static void KNNPOOHCFPP(this Task IGKMAMABJBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NPEHDFJCEAL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum EBKKFEEFNOP : short
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
	public struct NGLBALNEJIF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly EBKKFEEFNOP GMFCIHEFPPO;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x259D140", Offset = "0x259C140", VA = "0x18259D140")]
		public NGLBALNEJIF(EBKKFEEFNOP GMFCIHEFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory GPJFFGOADGD;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	public static void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69740D0", Offset = "0x69730D0", VA = "0x1869740D0")]
	static NPEHDFJCEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28D0890", Offset = "0x28CF890", VA = "0x1828D0890")]
	public static NGLBALNEJIF EJCBMECBAEL(EBKKFEEFNOP GMFCIHEFPPO)
	{
		return default(NGLBALNEJIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	public static void ABBDGMMPFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class FBFDFFMKKCJ<THandle, TValue> : IDisposable where THandle : struct, GONNAKCGBMI where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> DFCFMCAFJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> ADLAOOMHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> OMDPJDKNNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> LKDDCPHBINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int JFGDEACGPFH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C20A30", Offset = "0x3C1FA30", VA = "0x183C20A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C215C0", Offset = "0x3C205C0", VA = "0x183C215C0")]
	public FBFDFFMKKCJ(Action<TValue> LKDDCPHBINJ, [Optional] Func<TValue> OMDPJDKNNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C20CA0", Offset = "0x3C1FCA0", VA = "0x183C20CA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C20F50", Offset = "0x3C1FF50", VA = "0x183C20F50")]
	public THandle GKAGDNHKNII(TValue JJCEIJMGOAB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C20A70", Offset = "0x3C1FA70", VA = "0x183C20A70")]
	public bool CANECBKHGDE(THandle EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C21210", Offset = "0x3C20210", VA = "0x183C21210")]
	public bool KBNDOKPPALD(THandle EFPCBKOLOGB, [Out] TValue JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3C21570", Offset = "0x3C20570", VA = "0x183C21570")]
	public TValue MKHPGHPCCLG(THandle EFPCBKOLOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C20FF0", Offset = "0x3C1FFF0", VA = "0x183C20FF0")]
	public bool HDJFKMFFGDE(THandle EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C21150", Offset = "0x3C20150", VA = "0x183C21150")]
	private THandle INEKHBHOPGO(int HCALFJOJKJO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C211B0", Offset = "0x3C201B0", VA = "0x183C211B0")]
	private TValue JFBGKIODNAI(int HCALFJOJKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C21100", Offset = "0x3C20100", VA = "0x183C21100")]
	private void HFEEHFAAFOA(int HCALFJOJKJO, [In] THandle EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C21380", Offset = "0x3C20380", VA = "0x183C21380")]
	private void LMLMPGDBJPL(int HCALFJOJKJO, [In] TValue JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C20890", Offset = "0x3C1F890", VA = "0x183C20890")]
	private THandle AEGOEKDHKDD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C20B90", Offset = "0x3C1FB90", VA = "0x183C20B90")]
	private void DPIKJOGFGPG(THandle EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C20B80", Offset = "0x3C1FB80", VA = "0x183C20B80")]
	private int CEFOABJPKNL(int FFOAGBHJNBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C20E20", Offset = "0x3C1FE20", VA = "0x183C20E20")]
	private bool FKHABCNLOFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x859750", Offset = "0x858750", VA = "0x180859750")]
	private void OKLBCJPJFAA(THandle EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C20D70", Offset = "0x3C1FD70", VA = "0x183C20D70")]
	private bool EFDPNAFENFP([Out] THandle EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3C20E30", Offset = "0x3C1FE30", VA = "0x183C20E30")]
	private bool FOBGPMCNBFD([Out] THandle EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C212D0", Offset = "0x3C202D0", VA = "0x183C212D0")]
	private void LAMLKJOKKHC(THandle EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C213D0", Offset = "0x3C203D0", VA = "0x183C213D0")]
	private void MHJOFMMONGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GONNAKCGBMI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int LCNJIFOOGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int BPAJHBABCHA
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
public static class GMMPGHOONMD
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB580", Offset = "0x2BBA580", VA = "0x182BBB580")]
	public static bool KDIPPGEJGFK<T>(this T EFPCBKOLOGB, T ACBLPNJDJBF) where T : struct, GONNAKCGBMI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB5A0", Offset = "0x2BBA5A0", VA = "0x182BBB5A0")]
	public static bool KJINILEJGLO<T>(this T EFPCBKOLOGB) where T : struct, GONNAKCGBMI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6972FF0", Offset = "0x6971FF0", VA = "0x186972FF0")]
	public static string GNCENDCBKHI(this GONNAKCGBMI EFPCBKOLOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct CCGKOGPBOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type DJAGLMJMPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> ELCNGNDPLFF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x42B1CD0", Offset = "0x42B0CD0", VA = "0x1842B1CD0")]
	public CCGKOGPBOEK(Type AJPMKNHFJGF, Span<byte> BJHMMIELEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2993F10", Offset = "0x2992F10", VA = "0x182993F10")]
	public static CCGKOGPBOEK CJEJKMLBKEL<T>(T JJCEIJMGOAB) where T : struct
	{
		return default(CCGKOGPBOEK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6972E10", Offset = "0x6971E10", VA = "0x186972E10")]
	public static ADBKJBNECHF GCCHPLCKKEJ([In] CCGKOGPBOEK IELHIIDGIMN)
	{
		return default(ADBKJBNECHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2994D70", Offset = "0x2993D70", VA = "0x182994D70")]
	public T MKHPGHPCCLG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6972D80", Offset = "0x6971D80", VA = "0x186972D80")]
	public Enum ENJJFPFDLMB(Type OOJEFOLNJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2994C30", Offset = "0x2993C30", VA = "0x182994C30")]
	public void HACKMLKKHNE<T>([In] T JJCEIJMGOAB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6972E00", Offset = "0x6971E00", VA = "0x186972E00")]
	public void FEJIPEGLKIF(Enum EIIABACMOFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct ADBKJBNECHF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct PHICCADCMHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* NPNNJKEBENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* NLCAFLCHKIL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type DJAGLMJMPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> ELCNGNDPLFF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ODOBBFBPIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6972BD0", Offset = "0x6971BD0", VA = "0x186972BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x42B1CD0", Offset = "0x42B0CD0", VA = "0x1842B1CD0")]
	public ADBKJBNECHF(Type AJPMKNHFJGF, ReadOnlySpan<byte> BJHMMIELEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3264060", Offset = "0x3263060", VA = "0x183264060")]
	public static ADBKJBNECHF CJEJKMLBKEL<T>(T JJCEIJMGOAB) where T : struct
	{
		return default(ADBKJBNECHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3264190", Offset = "0x3263190", VA = "0x183264190")]
	public static ADBKJBNECHF CJEJKMLBKEL<T>(NativeArray<T> JJCEIJMGOAB) where T : struct
	{
		return default(ADBKJBNECHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6972AA0", Offset = "0x6971AA0", VA = "0x186972AA0")]
	public void CCCKDJJGLNN(Span<byte> ICAFJPMNOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6972B00", Offset = "0x6971B00", VA = "0x186972B00")]
	public void CCCKDJJGLNN(NativeArray<byte> ICAFJPMNOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3266100", Offset = "0x3265100", VA = "0x183266100")]
	public T MKHPGHPCCLG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3262A90", Offset = "0x3261A90", VA = "0x183262A90")]
	public NativeArray<T> BNPBOBIONOJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6972D40", Offset = "0x6971D40", VA = "0x186972D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6972C10", Offset = "0x6971C10", VA = "0x186972C10")]
	private object HOPAICEKCJI()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FIDIHJPHMIJ
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA80A0", Offset = "0x2BA70A0", VA = "0x182BA80A0")]
	public static NativeArray<T> AEIIKCHLKOP<T>(T JJCEIJMGOAB) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8130", Offset = "0x2BA7130", VA = "0x182BA8130")]
	public static NativeArray<T> CLNJCPGNCEC<T>(T JJCEIJMGOAB) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA80E0", Offset = "0x2BA70E0", VA = "0x182BA80E0")]
	public static NativeArray<T> CJEJKMLBKEL<T>(T JJCEIJMGOAB, bool OGAMNNKBJIP) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ECKDLJJFNGJ<Handle> where Handle : GONNAKCGBMI, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OKMELNFLADG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ECKDLJJFNGJ<Handle> ELCGDHICFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int HCALFJOJKJO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle IOGKMBCODGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x46F7CB0", Offset = "0x46F6CB0", VA = "0x1846F7CB0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x46F84A0", Offset = "0x46F74A0", VA = "0x1846F84A0")]
		public OKMELNFLADG(ECKDLJJFNGJ<Handle> ELCGDHICFJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x46F7F90", Offset = "0x46F6F90", VA = "0x1846F7F90")]
		public MGODEIPAKEG GAKCNKPJGEK([In] MGODEIPAKEG PGMBMLICCAI)
		{
			return default(MGODEIPAKEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x46F8380", Offset = "0x46F7380", VA = "0x1846F8380")]
		public bool KNNBHONEFAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x46F80E0", Offset = "0x46F70E0", VA = "0x1846F80E0")]
		private Handle GANOJDAJDGK(string KKHEHGHPOAA)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct MGODEIPAKEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private OKMELNFLADG EICGADGNBFD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x44E8700", Offset = "0x44E7700", VA = "0x1844E8700")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x44E8870", Offset = "0x44E7870", VA = "0x1844E8870")]
		public MGODEIPAKEG(ECKDLJJFNGJ<Handle> ELCGDHICFJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x44E8830", Offset = "0x44E7830", VA = "0x1844E8830")]
		public bool KNNBHONEFAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x44E8740", Offset = "0x44E7740", VA = "0x1844E8740")]
		public MGODEIPAKEG EAJKDCOBAGF()
		{
			return default(MGODEIPAKEG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> EKJDBBJGMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> IEILNHKKPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int KPFFGEFINAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int AEBNAAAKHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool FELKBFFJJPO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MANBHPILCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3886B20", Offset = "0x3885B20", VA = "0x183886B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MGODEIPAKEG PKPEKFOACMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3884770", Offset = "0x3883770", VA = "0x183884770")]
		get
		{
			return default(MGODEIPAKEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x38871D0", Offset = "0x38861D0", VA = "0x1838871D0")]
	public ECKDLJJFNGJ(int DJEFMBABFDG, Allocator OOMMBGGEBLM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3886D60", Offset = "0x3885D60", VA = "0x183886D60")]
	public void NNJJIJJFMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x19806D0", Offset = "0x197F6D0", VA = "0x1819806D0")]
	public static int CEFOABJPKNL(int CKOKPBDJPNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x25D13F0", Offset = "0x25D03F0", VA = "0x1825D13F0")]
	public static bool AHKGKDCEOCE(int CKOKPBDJPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3884B40", Offset = "0x3883B40", VA = "0x183884B40")]
	public bool EBDJAOIJCCH(int HCALFJOJKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3885DD0", Offset = "0x3884DD0", VA = "0x183885DD0")]
	public bool KLPDADLPMAK(Handle EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3885630", Offset = "0x3884630", VA = "0x183885630")]
	public Handle GGIPIHEKPCK()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38863C0", Offset = "0x38853C0", VA = "0x1838863C0")]
	public void MFBGHEILBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3885BE0", Offset = "0x3884BE0", VA = "0x183885BE0")]
	public void KIKEGJACBBF(Handle EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3886E20", Offset = "0x3885E20", VA = "0x183886E20")]
	public bool OIEGIDOEOLB(Handle EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xB4A400", Offset = "0xB49400", VA = "0x180B4A400")]
	private bool GHGNMNDCLAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3886AC0", Offset = "0x3885AC0", VA = "0x183886AC0")]
	private bool MFDBEPHACLK(int HCALFJOJKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x38851B0", Offset = "0x38841B0", VA = "0x1838851B0")]
	private void GAGALMDEAOP([Out] int HCALFJOJKJO, [Out] int FFOAGBHJNBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3885700", Offset = "0x3884700", VA = "0x183885700")]
	private void GHDHDPLPBKN(Handle EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3884DA0", Offset = "0x3883DA0", VA = "0x183884DA0")]
	private void FFPJDOGNDHJ(int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3884960", Offset = "0x3883960", VA = "0x183884960")]
	private bool EAMKKONMMPL([Out] int HCALFJOJKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3884E90", Offset = "0x3883E90", VA = "0x183884E90")]
	private static Handle FNBEJKIAJDM(int HCALFJOJKJO, int FFOAGBHJNBO)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct CLNLOHJEKJN<Handle, T> where Handle : GONNAKCGBMI, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private ECKDLJJFNGJ<Handle> CHGOPNBBGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] FAFNOJKFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> GIENKCLOHGK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5535DA0", Offset = "0x5534DA0", VA = "0x185535DA0")]
	public CLNLOHJEKJN(int DJEFMBABFDG, [Optional] Action<T> GIENKCLOHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5535CA0", Offset = "0x5534CA0", VA = "0x185535CA0")]
	public void NNJJIJJFMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5535360", Offset = "0x5534360", VA = "0x185535360")]
	public bool KBNDOKPPALD(Handle EFPCBKOLOGB, [Out] T NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5534AC0", Offset = "0x5533AC0", VA = "0x185534AC0")]
	public Handle GKAGDNHKNII(T NOPFNIKINJA)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5535590", Offset = "0x5534590", VA = "0x185535590")]
	public void KLNCHHDPPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5534630", Offset = "0x5533630", VA = "0x185534630")]
	public void FFDBNDOHLIO(Handle EFPCBKOLOGB, [Out] T AOCNEPIJNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55348D0", Offset = "0x55338D0", VA = "0x1855348D0")]
	public void FFDBNDOHLIO(Handle EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5534DE0", Offset = "0x5533DE0", VA = "0x185534DE0")]
	public bool HNKGAJCENFD(Handle EFPCBKOLOGB, [Out] T AOCNEPIJNLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5534ED0", Offset = "0x5533ED0", VA = "0x185534ED0")]
	public bool HNKGAJCENFD(Handle EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x55349A0", Offset = "0x55339A0", VA = "0x1855349A0")]
	private T FPMFBAADEOI(int HCALFJOJKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5534A00", Offset = "0x5533A00", VA = "0x185534A00")]
	private void GHBAHHNHKAK(int GCFHLEOOJIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct LJMGLECLOHM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] AHGAPHMJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int IGIHBEMLMOK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2032730", Offset = "0x2031730", VA = "0x182032730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2A30B20", Offset = "0x2A2FB20", VA = "0x182A30B20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> ELCNGNDPLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x42FB650", Offset = "0x42FA650", VA = "0x1842FB650")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool COGFBBOENKD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xF6F950", Offset = "0xF6E950", VA = "0x180F6F950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x42FB6F0", Offset = "0x42FA6F0", VA = "0x1842FB6F0")]
	public LJMGLECLOHM(int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x42FB3E0", Offset = "0x42FA3E0", VA = "0x1842FB3E0")]
	public int CBDGBGLBFJH(T JJCEIJMGOAB, int KKONFBKDDLI, int DOPPKGNLPAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x42FB550", Offset = "0x42FA550", VA = "0x1842FB550", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct FFHDOOGPBPF<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct HDDGBGEILNL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private FFHDOOGPBPF<T> IEKJOJONGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int HCALFJOJKJO;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3DC3780", Offset = "0x3DC2780", VA = "0x183DC3780", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3DC3820", Offset = "0x3DC2820", VA = "0x183DC3820", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3DC37F0", Offset = "0x3DC27F0", VA = "0x183DC37F0")]
		public HDDGBGEILNL(FFHDOOGPBPF<T> IEKJOJONGFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3DC36F0", Offset = "0x3DC26F0", VA = "0x183DC36F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3730", Offset = "0x3DC2730", VA = "0x183DC3730", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private LJMGLECLOHM<T> AHGAPHMJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int IGIHBEMLMOK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BA00", Offset = "0x3C2AA00", VA = "0x183C2BA00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C6F0", Offset = "0x3C2B6F0", VA = "0x183C2C6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int MANBHPILCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C570", Offset = "0x3C2B570", VA = "0x183C2C570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool COGFBBOENKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BD60", Offset = "0x3C2AD60", VA = "0x183C2BD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> ELCNGNDPLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C4B0", Offset = "0x3C2B4B0", VA = "0x183C2C4B0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C840", Offset = "0x3C2B840", VA = "0x183C2C840")]
	public FFHDOOGPBPF(int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C730", Offset = "0x3C2B730", VA = "0x183C2C730")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C200", Offset = "0x3C2B200", VA = "0x183C2C200")]
	public void GKAGDNHKNII(T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BDA0", Offset = "0x3C2ADA0", VA = "0x183C2BDA0")]
	internal void GDFOELMFEBD(int BPIECAEAGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C300", Offset = "0x3C2B300", VA = "0x183C2C300")]
	public void GNBFOHFDCGD(int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BFD0", Offset = "0x3C2AFD0", VA = "0x183C2BFD0")]
	public void GFFPLEEIKED(int KFBCBLMILDP, int NBLBDKMENFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BCA0", Offset = "0x3C2ACA0", VA = "0x183C2BCA0")]
	public int CBDGBGLBFJH(T JJCEIJMGOAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BD20", Offset = "0x3C2AD20", VA = "0x183C2BD20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C3E0", Offset = "0x3C2B3E0", VA = "0x183C2C3E0", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C790", Offset = "0x3C2B790", VA = "0x183C2C790", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C7D0", Offset = "0x3C2B7D0", VA = "0x183C2C7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C5A0", Offset = "0x3C2B5A0", VA = "0x183C2C5A0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void NFBELGFJFEP(int JJCEIJMGOAB, int IGIHBEMLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BA90", Offset = "0x3C2AA90", VA = "0x183C2BA90")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void AOGKONFPEHM(int KFBCBLMILDP, int NBLBDKMENFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HPLFBCPLACJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int BEMLKOBANDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int DOPPKGNLPAC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int IEOGBNCKHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x25ADC50", Offset = "0x25ACC50", VA = "0x1825ADC50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D41F50", Offset = "0x5D40F50", VA = "0x185D41F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int KHMCHMPEFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int AOJAOMOLLEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6973120", Offset = "0x6972120", VA = "0x186973120")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6973110", Offset = "0x6972110", VA = "0x186973110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
	private HPLFBCPLACJ(int BEMLKOBANDO, int DOPPKGNLPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2016EC0", Offset = "0x2015EC0", VA = "0x182016EC0")]
	public static HPLFBCPLACJ JHCMAFBFOAF(int BEMLKOBANDO, int DOPPKGNLPAC)
	{
		return default(HPLFBCPLACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6973100", Offset = "0x6972100", VA = "0x186973100")]
	public static HPLFBCPLACJ DHIKGBIANPI(int KKONFBKDDLI, int NBLBDKMENFD)
	{
		return default(HPLFBCPLACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6973130", Offset = "0x6972130", VA = "0x186973130", Slot = "3")]
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
