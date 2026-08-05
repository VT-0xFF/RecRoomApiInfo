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
	public class LogRegistrationIndex : DAMGOKPKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69371E0", Offset = "0x69357E0", VA = "0x1869371E0", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DLANHEHANNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6936BF0", Offset = "0x69351F0", VA = "0x186936BF0")]
	public static void PJEKICCMOOJ(this GameObject INALOLPJOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6936B50", Offset = "0x6935150", VA = "0x186936B50")]
	public static void PJEKICCMOOJ(this Component ADPKHCOJMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6936C90", Offset = "0x6935290", VA = "0x186936C90")]
	public static void PJEKICCMOOJ(this ScriptableObject ICFBLOLJBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HBLHGMEDNGD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6936EF0", Offset = "0x69354F0", VA = "0x186936EF0")]
	public static Span<byte> NEGGMDEBKKF(this NativeArray<byte> GGEMIJICFPG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6936E40", Offset = "0x6935440", VA = "0x186936E40")]
	public static ReadOnlySpan<byte> EILLHPFPLGG(this NativeArray<byte> GGEMIJICFPG)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B06670", Offset = "0x2B04C70", VA = "0x182B06670")]
	public static NativeArray<T> NJINCAFIMHP<T>(this NativeArray<T> GGEMIJICFPG, LEKMELECFFF FKCOHIKICFN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B06630", Offset = "0x2B04C30", VA = "0x182B06630")]
	public static NativeArray<T> NJINCAFIMHP<T>(this NativeArray<T> GGEMIJICFPG, int ODFMKGCLIGE) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CLMNCEAPOCH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29244F0", Offset = "0x2922AF0", VA = "0x1829244F0")]
	public static string NNHIHKJNFDI<T>(this NativeArray<T> GGEMIJICFPG, string HDNJOPANICE = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ONIFMECBPCG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3920", Offset = "0x2CA1F20", VA = "0x182CA3920")]
	public static T BDJJCDMMBKL<T>([In] this ReadOnlySpan<byte> JICGBMLKCNG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4910", Offset = "0x2CA2F10", VA = "0x182CA4910")]
	public static NativeArray<T> KJJJMFDNFGM<T>(this ReadOnlySpan<byte> JICGBMLKCNG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2924140", Offset = "0x2922740", VA = "0x182924140")]
	public static ReadOnlySpan<TTo> CBPOEADOKPF<TTo, TFrom>(this ReadOnlySpan<TFrom> JICGBMLKCNG) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5140", Offset = "0x2CA3740", VA = "0x182CA5140")]
	public static Span<byte> LHLEJLJODIO<T>([In] this Span<byte> JICGBMLKCNG, T CBAEIEAPLIH) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6937400", Offset = "0x6935A00", VA = "0x186937400")]
	private static Enum EAOAPBDKJJG([In] ReadOnlySpan<byte> JICGBMLKCNG, Type LDPJJJAKFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6937390", Offset = "0x6935990", VA = "0x186937390")]
	public static Enum AOHMDEJFOML([In] this Span<byte> JICGBMLKCNG, Type LDPJJJAKFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69379A0", Offset = "0x6935FA0", VA = "0x1869379A0")]
	public static void NKCIDOBKNOG([In] this Span<byte> JICGBMLKCNG, Enum HEJFAMNFDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NOBBHNPPPNE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HEKMOJNPBPB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6936FA0", Offset = "0x69355A0", VA = "0x186936FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6937270", Offset = "0x6935870", VA = "0x186937270")]
	[AsyncStateMachine(typeof(HEKMOJNPBPB))]
	public static void BEDHIMEMHIH(this Task LBKJPGMAINP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CGOHPHAAIHE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum FFLGMPCOAIB : short
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
	public struct DLHHACBKAFI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly FFLGMPCOAIB BHEIPBKEDLG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x25366F0", Offset = "0x2534CF0", VA = "0x1825366F0")]
		public DLHHACBKAFI(FFLGMPCOAIB BHEIPBKEDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory CMLHNBIJFFM;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	public static void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69369D0", Offset = "0x6934FD0", VA = "0x1869369D0")]
	static CGOHPHAAIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2829F70", Offset = "0x2828570", VA = "0x182829F70")]
	public static DLHHACBKAFI AJKABNCPGDA(FFLGMPCOAIB BHEIPBKEDLG)
	{
		return default(DLHHACBKAFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	public static void FOKGOEIABGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class ABAOMCFLGJB<THandle, TValue> : IDisposable where THandle : struct, BNGFLHDNNIJ where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> PJJDBOLIJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> CNNODMDOLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> BHNABLFJBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> PFPNDOEOKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int NIMOJEPAPBI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEDE0", Offset = "0x3CAD3E0", VA = "0x183CAEDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF3D0", Offset = "0x3CAD9D0", VA = "0x183CAF3D0")]
	public ABAOMCFLGJB(Action<TValue> PFPNDOEOKEF, [Optional] Func<TValue> BHNABLFJBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE900", Offset = "0x3CACF00", VA = "0x183CAE900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF0B0", Offset = "0x3CAD6B0", VA = "0x183CAF0B0")]
	public THandle MJFEDCBJOBF(TValue CBAEIEAPLIH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE650", Offset = "0x3CACC50", VA = "0x183CAE650")]
	public bool BKCGKDNFFIN(THandle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CAEE20", Offset = "0x3CAD420", VA = "0x183CAEE20")]
	public bool KCOKGBINLEI(THandle JNKGLDBBIBB, [Out] TValue CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE5F0", Offset = "0x3CACBF0", VA = "0x183CAE5F0")]
	public TValue BDJJCDMMBKL(THandle JNKGLDBBIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3CAECC0", Offset = "0x3CAD2C0", VA = "0x183CAECC0")]
	public bool EKGDBOHPAIM(THandle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE780", Offset = "0x3CACD80", VA = "0x183CAE780")]
	private THandle BNBJNABMDIO(int LLPJHIPCNFD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE7E0", Offset = "0x3CACDE0", VA = "0x183CAE7E0")]
	private TValue CMHCDGKNPKK(int LLPJHIPCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF160", Offset = "0x3CAD760", VA = "0x183CAF160")]
	private void MMIDOMNHCAF(int LLPJHIPCNFD, [In] THandle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE5A0", Offset = "0x3CACBA0", VA = "0x183CAE5A0")]
	private void AKJKJJBMIND(int LLPJHIPCNFD, [In] TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3CAEEF0", Offset = "0x3CAD4F0", VA = "0x183CAEEF0")]
	private THandle MDHEAICIAHO()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3CAEBA0", Offset = "0x3CAD1A0", VA = "0x183CAEBA0")]
	private void EDFAFDAPPMC(THandle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF1B0", Offset = "0x3CAD7B0", VA = "0x183CAF1B0")]
	private int MNIMCALHFAL(int HNNOPDLCPBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF1C0", Offset = "0x3CAD7C0", VA = "0x183CAF1C0")]
	private bool NEJNPGGMKAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86DC60", Offset = "0x86C260", VA = "0x18086DC60")]
	private void EFODOEIFFHE(THandle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE840", Offset = "0x3CACE40", VA = "0x183CAE840")]
	private bool DECDHMAMBKA([Out] THandle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF1D0", Offset = "0x3CAD7D0", VA = "0x183CAF1D0")]
	private bool NHMDJPICHGF([Out] THandle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CAF310", Offset = "0x3CAD910", VA = "0x183CAF310")]
	private void OGMJCGDKLDM(THandle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE9E0", Offset = "0x3CACFE0", VA = "0x183CAE9E0")]
	private void EACLMHIILPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BNGFLHDNNIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int FPNFNABMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int HJHABCPEMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FLIKGPPMMLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3A20", Offset = "0x2AF2020", VA = "0x182AF3A20")]
	public static bool DLJNIJABJFI<T>(this T JNKGLDBBIBB, T LJAAPFIIPOF) where T : struct, BNGFLHDNNIJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3A10", Offset = "0x2AF2010", VA = "0x182AF3A10")]
	public static bool DJDJJCHPPBF<T>(this T JNKGLDBBIBB) where T : struct, BNGFLHDNNIJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6936D30", Offset = "0x6935330", VA = "0x186936D30")]
	public static string JELKNGDMJEG(this BNGFLHDNNIJ JNKGLDBBIBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct COADBPFMFML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type DIOODNCLIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> COAMMLIIBEK;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4298590", Offset = "0x4296B90", VA = "0x184298590")]
	public COADBPFMFML(Type OIPFCDCFKKJ, Span<byte> JICGBMLKCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29356B0", Offset = "0x2933CB0", VA = "0x1829356B0")]
	public static COADBPFMFML ICICDJFMCPH<T>(T CBAEIEAPLIH) where T : struct
	{
		return default(COADBPFMFML);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6936AC0", Offset = "0x69350C0", VA = "0x186936AC0")]
	public static BBEAFPNMONC CPPJIHNILOM([In] COADBPFMFML LJNBPEFJOFE)
	{
		return default(BBEAFPNMONC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6936A40", Offset = "0x6935040", VA = "0x186936A40")]
	public Enum AOHMDEJFOML(Type LDPJJJAKFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2936770", Offset = "0x2934D70", VA = "0x182936770")]
	public void LHLEJLJODIO<T>([In] T CBAEIEAPLIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6936B40", Offset = "0x6935140", VA = "0x186936B40")]
	public void NKCIDOBKNOG(Enum HEJFAMNFDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct BBEAFPNMONC
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct BGMEGGDAFLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* AJIMMDNMCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* DMILAJJMCNH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type DIOODNCLIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> COAMMLIIBEK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PMILGDKKIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6936750", Offset = "0x6934D50", VA = "0x186936750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4298590", Offset = "0x4296B90", VA = "0x184298590")]
	public BBEAFPNMONC(Type OIPFCDCFKKJ, ReadOnlySpan<byte> JICGBMLKCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28AA770", Offset = "0x28A8D70", VA = "0x1828AA770")]
	public static BBEAFPNMONC ICICDJFMCPH<T>(T CBAEIEAPLIH) where T : struct
	{
		return default(BBEAFPNMONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28AA5F0", Offset = "0x28A8BF0", VA = "0x1828AA5F0")]
	public static BBEAFPNMONC ICICDJFMCPH<T>(NativeArray<T> CBAEIEAPLIH) where T : struct
	{
		return default(BBEAFPNMONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69368C0", Offset = "0x6934EC0", VA = "0x1869368C0")]
	public void FNIBGALIMHE(NativeArray<byte> GKHPOHDNBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28A96D0", Offset = "0x28A7CD0", VA = "0x1828A96D0")]
	public T BDJJCDMMBKL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28ACEF0", Offset = "0x28AB4F0", VA = "0x1828ACEF0")]
	public NativeArray<T> KJJJMFDNFGM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6936990", Offset = "0x6934F90", VA = "0x186936990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6936790", Offset = "0x6934D90", VA = "0x186936790")]
	private object EPIMKOBBELA()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BGDIGPLPNOI
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28B29D0", Offset = "0x28B0FD0", VA = "0x1828B29D0")]
	public static NativeArray<T> HEGEPBIOIOO<T>(T CBAEIEAPLIH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28B2A20", Offset = "0x28B1020", VA = "0x1828B2A20")]
	public static NativeArray<T> ICICDJFMCPH<T>(T CBAEIEAPLIH, bool HMEODBHHKLA) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IFPEAOCNNKC<Handle> where Handle : BNGFLHDNNIJ, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct DJAAGPNOOAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly IFPEAOCNNKC<Handle> LELPBFPMPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int LLPJHIPCNFD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle HCIOAOOFFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5807890", Offset = "0x5805E90", VA = "0x185807890")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5808230", Offset = "0x5806830", VA = "0x185808230")]
		public DJAAGPNOOAJ(IFPEAOCNNKC<Handle> LELPBFPMPGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5807E30", Offset = "0x5806430", VA = "0x185807E30")]
		public GIFIGFAPOOA HCLFOFEHDJP([In] GIFIGFAPOOA JLMICGLMAKN)
		{
			return default(GIFIGFAPOOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5807ED0", Offset = "0x58064D0", VA = "0x185807ED0")]
		public bool IEOEAKHLKGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5807DD0", Offset = "0x58063D0", VA = "0x185807DD0")]
		private Handle FAPHJGMILIM(string NFOHONOFFAP)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct GIFIGFAPOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DJAAGPNOOAJ NAIHEONCCHJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3D28AB0", Offset = "0x3D270B0", VA = "0x183D28AB0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3D28BF0", Offset = "0x3D271F0", VA = "0x183D28BF0")]
		public GIFIGFAPOOA(IFPEAOCNNKC<Handle> LELPBFPMPGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3D28BB0", Offset = "0x3D271B0", VA = "0x183D28BB0")]
		public bool IEOEAKHLKGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3D289F0", Offset = "0x3D26FF0", VA = "0x183D289F0")]
		public GIFIGFAPOOA AKHPNFMFJMK()
		{
			return default(GIFIGFAPOOA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> MKOJCAOOEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> HAOIFFGICLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int DDIDHPDHHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int DKOCPMLILDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool HEHKOKPHECF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BDJKBNBIKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3EAD240", Offset = "0x3EAB840", VA = "0x183EAD240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GIFIGFAPOOA IMKIHBFFPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3EACCC0", Offset = "0x3EAB2C0", VA = "0x183EACCC0")]
		get
		{
			return default(GIFIGFAPOOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE2D0", Offset = "0x3EAC8D0", VA = "0x183EAE2D0")]
	public IFPEAOCNNKC(int MFMBBAGJHLE, Allocator IDMGOAKOEDG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EADA00", Offset = "0x3EAC000", VA = "0x183EADA00")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x18C2520", Offset = "0x18C0B20", VA = "0x1818C2520")]
	public static int MNIMCALHFAL(int DCMJEJAEEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x25630F0", Offset = "0x25616F0", VA = "0x1825630F0")]
	public static bool LPLAGGILNMN(int DCMJEJAEEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3EAC440", Offset = "0x3EAAA40", VA = "0x183EAC440")]
	public bool FGABBONKOFI(int LLPJHIPCNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD880", Offset = "0x3EABE80", VA = "0x183EAD880")]
	public bool LHFECJMFPMK(Handle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD3D0", Offset = "0x3EAB9D0", VA = "0x183EAD3D0")]
	public Handle JHIFEBBJNML()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3EABFC0", Offset = "0x3EAA5C0", VA = "0x183EABFC0")]
	public void BBKCBODNMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3EAC2F0", Offset = "0x3EAA8F0", VA = "0x183EAC2F0")]
	public void CBJACBHGCNH(Handle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3EADCF0", Offset = "0x3EAC2F0", VA = "0x183EADCF0")]
	public bool OFAKLMBCLCM(Handle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA774A0", Offset = "0xA75AA0", VA = "0x180A774A0")]
	private bool CMDLKAJPLFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD1E0", Offset = "0x3EAB7E0", VA = "0x183EAD1E0")]
	private bool HMHCKFDEMDH(int LLPJHIPCNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3EADFD0", Offset = "0x3EAC5D0", VA = "0x183EADFD0")]
	private void OFPLKDMKLHN([Out] int LLPJHIPCNFD, [Out] int HNNOPDLCPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3EACA80", Offset = "0x3EAB080", VA = "0x183EACA80")]
	private void FKOHGLHBLEF(Handle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3EACC20", Offset = "0x3EAB220", VA = "0x183EACC20")]
	private void GEEHMDBEIJF(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3EACEC0", Offset = "0x3EAB4C0", VA = "0x183EACEC0")]
	private bool HJIANMBEHPN([Out] int LLPJHIPCNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3EACF70", Offset = "0x3EAB570", VA = "0x183EACF70")]
	private static Handle HKBMLDJEMPF(int LLPJHIPCNFD, int HNNOPDLCPBM)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct FJOOEIFJBJH<Handle, T> where Handle : BNGFLHDNNIJ, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private IFPEAOCNNKC<Handle> OLKJJEIOOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] GGAGHMELKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> OEIKNGELFAK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3C46C40", Offset = "0x3C45240", VA = "0x183C46C40")]
	public FJOOEIFJBJH(int MFMBBAGJHLE, [Optional] Action<T> OEIKNGELFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3C46940", Offset = "0x3C44F40", VA = "0x183C46940")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3C45630", Offset = "0x3C43C30", VA = "0x183C45630")]
	public bool KCOKGBINLEI(Handle JNKGLDBBIBB, [Out] T HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3C467A0", Offset = "0x3C44DA0", VA = "0x183C467A0")]
	public Handle MJFEDCBJOBF(T HBFCGFKGCAF)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3C45D00", Offset = "0x3C44300", VA = "0x183C45D00")]
	public void KPKDGGIFEIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3C45550", Offset = "0x3C43B50", VA = "0x183C45550")]
	public void GAGDAFIMOPK(Handle JNKGLDBBIBB, [Out] T OBFBHIHANJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3C450D0", Offset = "0x3C436D0", VA = "0x183C450D0")]
	public void GAGDAFIMOPK(Handle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3C45FB0", Offset = "0x3C445B0", VA = "0x183C45FB0")]
	public bool LLEOAAEPAKH(Handle JNKGLDBBIBB, [Out] T OBFBHIHANJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3C460A0", Offset = "0x3C446A0", VA = "0x183C460A0")]
	public bool LLEOAAEPAKH(Handle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3C45F50", Offset = "0x3C44550", VA = "0x183C45F50")]
	private T LICPGDGLNME(int LLPJHIPCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3C45010", Offset = "0x3C43610", VA = "0x183C45010")]
	private void EGEAHNJKAIA(int IOBCCADJPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct KMEKNAGEFPM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] FHNKDHIILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int DOIKAIEGGLD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2270", Offset = "0x1FE0870", VA = "0x181FE2270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B12590", Offset = "0x2B10B90", VA = "0x182B12590")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> COAMMLIIBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x420EF60", Offset = "0x420D560", VA = "0x18420EF60")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool NEIPGPKBIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE82A60", Offset = "0xE81060", VA = "0x180E82A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x420F0B0", Offset = "0x420D6B0", VA = "0x18420F0B0")]
	public KMEKNAGEFPM(int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x420F000", Offset = "0x420D600", VA = "0x18420F000")]
	public int KNGEDAAOIAE(T CBAEIEAPLIH, int ODFMKGCLIGE, int JPBPNOCHNLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x420EE50", Offset = "0x420D450", VA = "0x18420EE50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct GOOAPFACFOD<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct FIANLPCHABN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private GOOAPFACFOD<T> DNOAHHGKGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int LLPJHIPCNFD;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3C284F0", Offset = "0x3C26AF0", VA = "0x183C284F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3C28590", Offset = "0x3C26B90", VA = "0x183C28590", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3C28560", Offset = "0x3C26B60", VA = "0x183C28560")]
		public FIANLPCHABN(GOOAPFACFOD<T> DNOAHHGKGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3C28460", Offset = "0x3C26A60", VA = "0x183C28460", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3C284A0", Offset = "0x3C26AA0", VA = "0x183C284A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KMEKNAGEFPM<T> FHNKDHIILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int DOIKAIEGGLD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B150", Offset = "0x3D49750", VA = "0x183D4B150")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8621A0", Offset = "0x8607A0", VA = "0x1808621A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B2C0", Offset = "0x3D498C0", VA = "0x183D4B2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BDJKBNBIKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B310", Offset = "0x3D49910", VA = "0x183D4B310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NEIPGPKBIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B340", Offset = "0x3D49940", VA = "0x183D4B340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> COAMMLIIBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B090", Offset = "0x3D49690", VA = "0x183D4B090")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BCB0", Offset = "0x3D4A2B0", VA = "0x183D4BCB0")]
	public GOOAPFACFOD(int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B990", Offset = "0x3D49F90", VA = "0x183D4B990")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B730", Offset = "0x3D49D30", VA = "0x183D4B730")]
	public void MJFEDCBJOBF(T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B4F0", Offset = "0x3D49AF0", VA = "0x183D4B4F0")]
	internal void MDBPKHBOFKD(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B400", Offset = "0x3D49A00", VA = "0x183D4B400")]
	public void MAFLKMDCAIA(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3D4AE00", Offset = "0x3D49400", VA = "0x183D4AE00")]
	public void AEKFOPIDBLN(int GCGBBJOEDNF, int EACEIFBMGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B380", Offset = "0x3D49980", VA = "0x183D4B380")]
	public int KNGEDAAOIAE(T CBAEIEAPLIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B050", Offset = "0x3D49650", VA = "0x183D4B050", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B1E0", Offset = "0x3D497E0", VA = "0x183D4B1E0", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BC00", Offset = "0x3D4A200", VA = "0x183D4BC00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BC40", Offset = "0x3D4A240", VA = "0x183D4BC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B840", Offset = "0x3D49E40", VA = "0x183D4B840")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NENOPODPLBD(int CBAEIEAPLIH, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B9F0", Offset = "0x3D49FF0", VA = "0x183D4B9F0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PPCLBPFAAJA(int GCGBBJOEDNF, int EACEIFBMGMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LEKMELECFFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int ANNLKNNLIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int JPBPNOCHNLG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int IFJJLDMODPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA882D0", Offset = "0xA868D0", VA = "0x180A882D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x25421D0", Offset = "0x25407D0", VA = "0x1825421D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B720", Offset = "0x5D29D20", VA = "0x185D2B720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AKMFCEKHOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA882D0", Offset = "0xA868D0", VA = "0x180A882D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA882B0", Offset = "0xA868B0", VA = "0x180A882B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LDKKJADJJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6937120", Offset = "0x6935720", VA = "0x186937120")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6937140", Offset = "0x6935740", VA = "0x186937140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC515B0", Offset = "0xC4FBB0", VA = "0x180C515B0")]
	private LEKMELECFFF(int ANNLKNNLIGI, int JPBPNOCHNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4FE0", Offset = "0x1FC35E0", VA = "0x181FC4FE0")]
	public static LEKMELECFFF GNIIIMJMDOO(int ANNLKNNLIGI, int JPBPNOCHNLG)
	{
		return default(LEKMELECFFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6937130", Offset = "0x6935730", VA = "0x186937130")]
	public static LEKMELECFFF OLOEEFPIHBG(int ODFMKGCLIGE, int EACEIFBMGMC)
	{
		return default(LEKMELECFFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6937150", Offset = "0x6935750", VA = "0x186937150", Slot = "3")]
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
