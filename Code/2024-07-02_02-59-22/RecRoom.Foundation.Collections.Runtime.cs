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
		[Cpp2IlInjected.Address(RVA = "0x6969E80", Offset = "0x6968E80", VA = "0x186969E80", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DLANHEHANNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6969890", Offset = "0x6968890", VA = "0x186969890")]
	public static void PJEKICCMOOJ(this GameObject INALOLPJOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69697F0", Offset = "0x69687F0", VA = "0x1869697F0")]
	public static void PJEKICCMOOJ(this Component ADPKHCOJMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6969930", Offset = "0x6968930", VA = "0x186969930")]
	public static void PJEKICCMOOJ(this ScriptableObject ICFBLOLJBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HBLHGMEDNGD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6969B90", Offset = "0x6968B90", VA = "0x186969B90")]
	public static Span<byte> NEGGMDEBKKF(this NativeArray<byte> GGEMIJICFPG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6969AE0", Offset = "0x6968AE0", VA = "0x186969AE0")]
	public static ReadOnlySpan<byte> EILLHPFPLGG(this NativeArray<byte> GGEMIJICFPG)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F3A0", Offset = "0x2B1E3A0", VA = "0x182B1F3A0")]
	public static NativeArray<T> NJINCAFIMHP<T>(this NativeArray<T> GGEMIJICFPG, LEKMELECFFF FKCOHIKICFN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F360", Offset = "0x2B1E360", VA = "0x182B1F360")]
	public static NativeArray<T> NJINCAFIMHP<T>(this NativeArray<T> GGEMIJICFPG, int ODFMKGCLIGE) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CLMNCEAPOCH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2934DF0", Offset = "0x2933DF0", VA = "0x182934DF0")]
	public static string NNHIHKJNFDI<T>(this NativeArray<T> GGEMIJICFPG, string HDNJOPANICE = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ONIFMECBPCG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD300", Offset = "0x2CBC300", VA = "0x182CBD300")]
	public static T BDJJCDMMBKL<T>([In] this ReadOnlySpan<byte> JICGBMLKCNG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2CBE2F0", Offset = "0x2CBD2F0", VA = "0x182CBE2F0")]
	public static NativeArray<T> KJJJMFDNFGM<T>(this ReadOnlySpan<byte> JICGBMLKCNG) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2934A40", Offset = "0x2933A40", VA = "0x182934A40")]
	public static ReadOnlySpan<TTo> CBPOEADOKPF<TTo, TFrom>(this ReadOnlySpan<TFrom> JICGBMLKCNG) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2CBEB20", Offset = "0x2CBDB20", VA = "0x182CBEB20")]
	public static Span<byte> LHLEJLJODIO<T>([In] this Span<byte> JICGBMLKCNG, T CBAEIEAPLIH) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x696A0A0", Offset = "0x69690A0", VA = "0x18696A0A0")]
	private static Enum EAOAPBDKJJG([In] ReadOnlySpan<byte> JICGBMLKCNG, Type LDPJJJAKFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x696A030", Offset = "0x6969030", VA = "0x18696A030")]
	public static Enum AOHMDEJFOML([In] this Span<byte> JICGBMLKCNG, Type LDPJJJAKFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x696A640", Offset = "0x6969640", VA = "0x18696A640")]
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
		[Cpp2IlInjected.Address(RVA = "0x6969C40", Offset = "0x6968C40", VA = "0x186969C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6969F10", Offset = "0x6968F10", VA = "0x186969F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2545300", Offset = "0x2544300", VA = "0x182545300")]
		public DLHHACBKAFI(FFLGMPCOAIB BHEIPBKEDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory CMLHNBIJFFM;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	public static void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6969670", Offset = "0x6968670", VA = "0x186969670")]
	static CGOHPHAAIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2832C40", Offset = "0x2831C40", VA = "0x182832C40")]
	public static DLHHACBKAFI AJKABNCPGDA(FFLGMPCOAIB BHEIPBKEDLG)
	{
		return default(DLHHACBKAFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CC8FD0", Offset = "0x3CC7FD0", VA = "0x183CC8FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC95C0", Offset = "0x3CC85C0", VA = "0x183CC95C0")]
	public ABAOMCFLGJB(Action<TValue> PFPNDOEOKEF, [Optional] Func<TValue> BHNABLFJBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8AF0", Offset = "0x3CC7AF0", VA = "0x183CC8AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC92A0", Offset = "0x3CC82A0", VA = "0x183CC92A0")]
	public THandle MJFEDCBJOBF(TValue CBAEIEAPLIH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8840", Offset = "0x3CC7840", VA = "0x183CC8840")]
	public bool BKCGKDNFFIN(THandle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CC9010", Offset = "0x3CC8010", VA = "0x183CC9010")]
	public bool KCOKGBINLEI(THandle JNKGLDBBIBB, [Out] TValue CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3CC87E0", Offset = "0x3CC77E0", VA = "0x183CC87E0")]
	public TValue BDJJCDMMBKL(THandle JNKGLDBBIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8EB0", Offset = "0x3CC7EB0", VA = "0x183CC8EB0")]
	public bool EKGDBOHPAIM(THandle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8970", Offset = "0x3CC7970", VA = "0x183CC8970")]
	private THandle BNBJNABMDIO(int LLPJHIPCNFD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CC89D0", Offset = "0x3CC79D0", VA = "0x183CC89D0")]
	private TValue CMHCDGKNPKK(int LLPJHIPCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3CC9350", Offset = "0x3CC8350", VA = "0x183CC9350")]
	private void MMIDOMNHCAF(int LLPJHIPCNFD, [In] THandle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8790", Offset = "0x3CC7790", VA = "0x183CC8790")]
	private void AKJKJJBMIND(int LLPJHIPCNFD, [In] TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3CC90E0", Offset = "0x3CC80E0", VA = "0x183CC90E0")]
	private THandle MDHEAICIAHO()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8D90", Offset = "0x3CC7D90", VA = "0x183CC8D90")]
	private void EDFAFDAPPMC(THandle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC93A0", Offset = "0x3CC83A0", VA = "0x183CC93A0")]
	private int MNIMCALHFAL(int HNNOPDLCPBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC93B0", Offset = "0x3CC83B0", VA = "0x183CC93B0")]
	private bool NEJNPGGMKAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x870C60", Offset = "0x86FC60", VA = "0x180870C60")]
	private void EFODOEIFFHE(THandle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8A30", Offset = "0x3CC7A30", VA = "0x183CC8A30")]
	private bool DECDHMAMBKA([Out] THandle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC93C0", Offset = "0x3CC83C0", VA = "0x183CC93C0")]
	private bool NHMDJPICHGF([Out] THandle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC9500", Offset = "0x3CC8500", VA = "0x183CC9500")]
	private void OGMJCGDKLDM(THandle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8BD0", Offset = "0x3CC7BD0", VA = "0x183CC8BD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B0C370", Offset = "0x2B0B370", VA = "0x182B0C370")]
	public static bool DLJNIJABJFI<T>(this T JNKGLDBBIBB, T LJAAPFIIPOF) where T : struct, BNGFLHDNNIJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B0C360", Offset = "0x2B0B360", VA = "0x182B0C360")]
	public static bool DJDJJCHPPBF<T>(this T JNKGLDBBIBB) where T : struct, BNGFLHDNNIJ
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69699D0", Offset = "0x69689D0", VA = "0x1869699D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x42B3CC0", Offset = "0x42B2CC0", VA = "0x1842B3CC0")]
	public COADBPFMFML(Type OIPFCDCFKKJ, Span<byte> JICGBMLKCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2946000", Offset = "0x2945000", VA = "0x182946000")]
	public static COADBPFMFML ICICDJFMCPH<T>(T CBAEIEAPLIH) where T : struct
	{
		return default(COADBPFMFML);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6969760", Offset = "0x6968760", VA = "0x186969760")]
	public static BBEAFPNMONC CPPJIHNILOM([In] COADBPFMFML LJNBPEFJOFE)
	{
		return default(BBEAFPNMONC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69696E0", Offset = "0x69686E0", VA = "0x1869696E0")]
	public Enum AOHMDEJFOML(Type LDPJJJAKFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29470C0", Offset = "0x29460C0", VA = "0x1829470C0")]
	public void LHLEJLJODIO<T>([In] T CBAEIEAPLIH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69697E0", Offset = "0x69687E0", VA = "0x1869697E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69693F0", Offset = "0x69683F0", VA = "0x1869693F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x42B3CC0", Offset = "0x42B2CC0", VA = "0x1842B3CC0")]
	public BBEAFPNMONC(Type OIPFCDCFKKJ, ReadOnlySpan<byte> JICGBMLKCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28B9CA0", Offset = "0x28B8CA0", VA = "0x1828B9CA0")]
	public static BBEAFPNMONC ICICDJFMCPH<T>(T CBAEIEAPLIH) where T : struct
	{
		return default(BBEAFPNMONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28B9B20", Offset = "0x28B8B20", VA = "0x1828B9B20")]
	public static BBEAFPNMONC ICICDJFMCPH<T>(NativeArray<T> CBAEIEAPLIH) where T : struct
	{
		return default(BBEAFPNMONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6969560", Offset = "0x6968560", VA = "0x186969560")]
	public void FNIBGALIMHE(NativeArray<byte> GKHPOHDNBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28B8C00", Offset = "0x28B7C00", VA = "0x1828B8C00")]
	public T BDJJCDMMBKL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28BC420", Offset = "0x28BB420", VA = "0x1828BC420")]
	public NativeArray<T> KJJJMFDNFGM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6969630", Offset = "0x6968630", VA = "0x186969630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6969430", Offset = "0x6968430", VA = "0x186969430")]
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
	[Cpp2IlInjected.Address(RVA = "0x28C1F00", Offset = "0x28C0F00", VA = "0x1828C1F00")]
	public static NativeArray<T> HEGEPBIOIOO<T>(T CBAEIEAPLIH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28C1F50", Offset = "0x28C0F50", VA = "0x1828C1F50")]
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
			[Cpp2IlInjected.Address(RVA = "0x582FA00", Offset = "0x582EA00", VA = "0x18582FA00")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x58303A0", Offset = "0x582F3A0", VA = "0x1858303A0")]
		public DJAAGPNOOAJ(IFPEAOCNNKC<Handle> LELPBFPMPGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x582FFA0", Offset = "0x582EFA0", VA = "0x18582FFA0")]
		public GIFIGFAPOOA HCLFOFEHDJP([In] GIFIGFAPOOA JLMICGLMAKN)
		{
			return default(GIFIGFAPOOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5830040", Offset = "0x582F040", VA = "0x185830040")]
		public bool IEOEAKHLKGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x582FF40", Offset = "0x582EF40", VA = "0x18582FF40")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D42D30", Offset = "0x3D41D30", VA = "0x183D42D30")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3D42E70", Offset = "0x3D41E70", VA = "0x183D42E70")]
		public GIFIGFAPOOA(IFPEAOCNNKC<Handle> LELPBFPMPGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3D42E30", Offset = "0x3D41E30", VA = "0x183D42E30")]
		public bool IEOEAKHLKGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3D42C70", Offset = "0x3D41C70", VA = "0x183D42C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EC9940", Offset = "0x3EC8940", VA = "0x183EC9940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GIFIGFAPOOA IMKIHBFFPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3EC96D0", Offset = "0x3EC86D0", VA = "0x183EC96D0")]
		get
		{
			return default(GIFIGFAPOOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9EC0", Offset = "0x3EC8EC0", VA = "0x183EC9EC0")]
	public IFPEAOCNNKC(int MFMBBAGJHLE, Allocator IDMGOAKOEDG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9BD0", Offset = "0x3EC8BD0", VA = "0x183EC9BD0")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x18D4790", Offset = "0x18D3790", VA = "0x1818D4790")]
	public static int MNIMCALHFAL(int DCMJEJAEEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2571D00", Offset = "0x2570D00", VA = "0x182571D00")]
	public static bool LPLAGGILNMN(int DCMJEJAEEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9400", Offset = "0x3EC8400", VA = "0x183EC9400")]
	public bool FGABBONKOFI(int LLPJHIPCNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9A50", Offset = "0x3EC8A50", VA = "0x183EC9A50")]
	public bool LHFECJMFPMK(Handle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9980", Offset = "0x3EC8980", VA = "0x183EC9980")]
	public Handle JHIFEBBJNML()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9060", Offset = "0x3EC8060", VA = "0x183EC9060")]
	public void BBKCBODNMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9390", Offset = "0x3EC8390", VA = "0x183EC9390")]
	public void CBJACBHGCNH(Handle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9C90", Offset = "0x3EC8C90", VA = "0x183EC9C90")]
	public bool OFAKLMBCLCM(Handle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA7BEE0", Offset = "0xA7AEE0", VA = "0x180A7BEE0")]
	private bool CMDLKAJPLFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3EC98E0", Offset = "0x3EC88E0", VA = "0x183EC98E0")]
	private bool HMHCKFDEMDH(int LLPJHIPCNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9D40", Offset = "0x3EC8D40", VA = "0x183EC9D40")]
	private void OFPLKDMKLHN([Out] int LLPJHIPCNFD, [Out] int HNNOPDLCPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9530", Offset = "0x3EC8530", VA = "0x183EC9530")]
	private void FKOHGLHBLEF(Handle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9680", Offset = "0x3EC8680", VA = "0x183EC9680")]
	private void GEEHMDBEIJF(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9770", Offset = "0x3EC8770", VA = "0x183EC9770")]
	private bool HJIANMBEHPN([Out] int LLPJHIPCNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9820", Offset = "0x3EC8820", VA = "0x183EC9820")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C61630", Offset = "0x3C60630", VA = "0x183C61630")]
	public FJOOEIFJBJH(int MFMBBAGJHLE, [Optional] Action<T> OEIKNGELFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3C61330", Offset = "0x3C60330", VA = "0x183C61330")]
	public void NNOPBDMPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3C60020", Offset = "0x3C5F020", VA = "0x183C60020")]
	public bool KCOKGBINLEI(Handle JNKGLDBBIBB, [Out] T HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3C61190", Offset = "0x3C60190", VA = "0x183C61190")]
	public Handle MJFEDCBJOBF(T HBFCGFKGCAF)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3C606F0", Offset = "0x3C5F6F0", VA = "0x183C606F0")]
	public void KPKDGGIFEIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3C5FF40", Offset = "0x3C5EF40", VA = "0x183C5FF40")]
	public void GAGDAFIMOPK(Handle JNKGLDBBIBB, [Out] T OBFBHIHANJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3C5FAC0", Offset = "0x3C5EAC0", VA = "0x183C5FAC0")]
	public void GAGDAFIMOPK(Handle JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3C609A0", Offset = "0x3C5F9A0", VA = "0x183C609A0")]
	public bool LLEOAAEPAKH(Handle JNKGLDBBIBB, [Out] T OBFBHIHANJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3C60A90", Offset = "0x3C5FA90", VA = "0x183C60A90")]
	public bool LLEOAAEPAKH(Handle JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3C60940", Offset = "0x3C5F940", VA = "0x183C60940")]
	private T LICPGDGLNME(int LLPJHIPCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3C5FA00", Offset = "0x3C5EA00", VA = "0x183C5FA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FEFC50", Offset = "0x1FEEC50", VA = "0x181FEFC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B2B2C0", Offset = "0x2B2A2C0", VA = "0x182B2B2C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> COAMMLIIBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x422D420", Offset = "0x422C420", VA = "0x18422D420")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool NEIPGPKBIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE8A190", Offset = "0xE89190", VA = "0x180E8A190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x422D570", Offset = "0x422C570", VA = "0x18422D570")]
	public KMEKNAGEFPM(int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x422D4C0", Offset = "0x422C4C0", VA = "0x18422D4C0")]
	public int KNGEDAAOIAE(T CBAEIEAPLIH, int ODFMKGCLIGE, int JPBPNOCHNLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x422D310", Offset = "0x422C310", VA = "0x18422D310", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C43270", Offset = "0x3C42270", VA = "0x183C43270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3C43310", Offset = "0x3C42310", VA = "0x183C43310", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3C432E0", Offset = "0x3C422E0", VA = "0x183C432E0")]
		public FIANLPCHABN(GOOAPFACFOD<T> DNOAHHGKGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3C431E0", Offset = "0x3C421E0", VA = "0x183C431E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3C43220", Offset = "0x3C42220", VA = "0x183C43220", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D619D0", Offset = "0x3D609D0", VA = "0x183D619D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x8641A0", VA = "0x1808651A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3D61B40", Offset = "0x3D60B40", VA = "0x183D61B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BDJKBNBIKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3D61B90", Offset = "0x3D60B90", VA = "0x183D61B90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NEIPGPKBIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3D61BC0", Offset = "0x3D60BC0", VA = "0x183D61BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> COAMMLIIBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3D61910", Offset = "0x3D60910", VA = "0x183D61910")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3D62530", Offset = "0x3D61530", VA = "0x183D62530")]
	public GOOAPFACFOD(int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3D62210", Offset = "0x3D61210", VA = "0x183D62210")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3D61FB0", Offset = "0x3D60FB0", VA = "0x183D61FB0")]
	public void MJFEDCBJOBF(T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3D61D70", Offset = "0x3D60D70", VA = "0x183D61D70")]
	internal void MDBPKHBOFKD(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D61C80", Offset = "0x3D60C80", VA = "0x183D61C80")]
	public void MAFLKMDCAIA(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3D61680", Offset = "0x3D60680", VA = "0x183D61680")]
	public void AEKFOPIDBLN(int GCGBBJOEDNF, int EACEIFBMGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D61C00", Offset = "0x3D60C00", VA = "0x183D61C00")]
	public int KNGEDAAOIAE(T CBAEIEAPLIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3D618D0", Offset = "0x3D608D0", VA = "0x183D618D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3D61A60", Offset = "0x3D60A60", VA = "0x183D61A60", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D62480", Offset = "0x3D61480", VA = "0x183D62480", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D624C0", Offset = "0x3D614C0", VA = "0x183D624C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D620C0", Offset = "0x3D610C0", VA = "0x183D620C0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NENOPODPLBD(int CBAEIEAPLIH, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D62270", Offset = "0x3D61270", VA = "0x183D62270")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8D560", Offset = "0xA8C560", VA = "0x180A8D560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2550DE0", Offset = "0x254FDE0", VA = "0x182550DE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D54330", Offset = "0x5D53330", VA = "0x185D54330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int AKMFCEKHOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA8D560", Offset = "0xA8C560", VA = "0x180A8D560")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA8D540", Offset = "0xA8C540", VA = "0x180A8D540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LDKKJADJJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6969DC0", Offset = "0x6968DC0", VA = "0x186969DC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6969DE0", Offset = "0x6968DE0", VA = "0x186969DE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC57490", Offset = "0xC56490", VA = "0x180C57490")]
	private LEKMELECFFF(int ANNLKNNLIGI, int JPBPNOCHNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD29C0", Offset = "0x1FD19C0", VA = "0x181FD29C0")]
	public static LEKMELECFFF GNIIIMJMDOO(int ANNLKNNLIGI, int JPBPNOCHNLG)
	{
		return default(LEKMELECFFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6969DD0", Offset = "0x6968DD0", VA = "0x186969DD0")]
	public static LEKMELECFFF OLOEEFPIHBG(int ODFMKGCLIGE, int EACEIFBMGMC)
	{
		return default(LEKMELECFFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6969DF0", Offset = "0x6968DF0", VA = "0x186969DF0", Slot = "3")]
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
