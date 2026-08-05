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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C650", Offset = "0x6C4B050", VA = "0x186C4C650", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LALMBMHKMAF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C3B0", Offset = "0x6C4ADB0", VA = "0x186C4C3B0")]
	public static void MFLGBDKLOCO(this GameObject MNKAGJEGJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C4F0", Offset = "0x6C4AEF0", VA = "0x186C4C4F0")]
	public static void MFLGBDKLOCO(this Component INEJDODHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C450", Offset = "0x6C4AE50", VA = "0x186C4C450")]
	public static void MFLGBDKLOCO(this ScriptableObject BOHKAIMJBDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FCHCIPFOAFL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B6A0", Offset = "0x6C4A0A0", VA = "0x186C4B6A0")]
	public static Span<byte> KAEINKEEFAE(this NativeArray<byte> DKEEEGEFALD)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B5F0", Offset = "0x6C49FF0", VA = "0x186C4B5F0")]
	public static ReadOnlySpan<byte> JKEOPFKCCGC(this NativeArray<byte> DKEEEGEFALD)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E540", Offset = "0x2D7CF40", VA = "0x182D7E540")]
	public static NativeArray<T> LKMOOADPKKB<T>(this NativeArray<T> DKEEEGEFALD, LIDAMMEOCHG PCIGIFGMPKJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E500", Offset = "0x2D7CF00", VA = "0x182D7E500")]
	public static NativeArray<T> LKMOOADPKKB<T>(this NativeArray<T> DKEEEGEFALD, int OENMMCMOJOM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JAEAPPOHKOJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BBE0", Offset = "0x2E1A5E0", VA = "0x182E1BBE0")]
	public static string IKKOFKFKDAK<T>(this NativeArray<T> DKEEEGEFALD, string DAHJFKGMDFP = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KHLBADKDNGM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E47180", Offset = "0x2E45B80", VA = "0x182E47180")]
	public static T PBGHNKGJFJB<T>([In] this ReadOnlySpan<byte> EBMIBGINKAH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2E47060", Offset = "0x2E45A60", VA = "0x182E47060")]
	public static T PBGHNKGJFJB<T>([In] this Span<byte> EBMIBGINKAH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E45720", Offset = "0x2E44120", VA = "0x182E45720")]
	public static NativeArray<T> ANALNAJCEPH<T>(this ReadOnlySpan<byte> EBMIBGINKAH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD99A0", Offset = "0x2DD83A0", VA = "0x182DD99A0")]
	public static ReadOnlySpan<TTo> JIHPFLIBHLD<TTo, TFrom>(this ReadOnlySpan<TFrom> EBMIBGINKAH) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E45F00", Offset = "0x2E44900", VA = "0x182E45F00")]
	public static Span<byte> ENCKAHEIPGI<T>([In] this Span<byte> EBMIBGINKAH, T KLABJGGMBGH) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BDA0", Offset = "0x6C4A7A0", VA = "0x186C4BDA0")]
	private static Enum GEHGAECLGCA([In] ReadOnlySpan<byte> EBMIBGINKAH, Type LKNKNGAOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C340", Offset = "0x6C4AD40", VA = "0x186C4C340")]
	public static Enum PKDHJHKIJLO([In] this Span<byte> EBMIBGINKAH, Type LKNKNGAOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B8C0", Offset = "0x6C4A2C0", VA = "0x186C4B8C0")]
	public static void FAMFJPAKBMO([In] this Span<byte> EBMIBGINKAH, Enum HBEFBGGFFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NMHKDJAGHME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BPPCOICOPAO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6C4B470", Offset = "0x6C49E70", VA = "0x186C4B470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C6E0", Offset = "0x6C4B0E0", VA = "0x186C4C6E0")]
	[AsyncStateMachine(typeof(BPPCOICOPAO))]
	public static void PAEGHBDLGGO(this Task KGPMLIHPPAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GCNFGIMJMLA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum GAOOKKMJHFC : short
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
	public struct OOPPGALFJFI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly GAOOKKMJHFC LFOBGDLOPID;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x26F52A0", Offset = "0x26F3CA0", VA = "0x1826F52A0")]
		public OOPPGALFJFI(GAOOKKMJHFC LFOBGDLOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory PDMFFKPECJB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	public static void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B860", Offset = "0x6C4A260", VA = "0x186C4B860")]
	static GCNFGIMJMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AD20", Offset = "0x2A59720", VA = "0x182A5AD20")]
	public static OOPPGALFJFI LBLNOHJNLJC(GAOOKKMJHFC LFOBGDLOPID)
	{
		return default(OOPPGALFJFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	public static void FOGCKMLELMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class GPDANAILPAE<THandle, TValue> : IDisposable where THandle : struct, EOIFKCNADCO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> ALLKFMONBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> ICLOFOKMOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> HLEEBDELFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> LHLDGOBOJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int EPDLGCOEDFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB710", Offset = "0x3EEA110", VA = "0x183EEB710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC2A0", Offset = "0x3EEACA0", VA = "0x183EEC2A0")]
	public GPDANAILPAE(Action<TValue> LHLDGOBOJJL, [Optional] Func<TValue> HLEEBDELFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB750", Offset = "0x3EEA150", VA = "0x183EEB750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB9F0", Offset = "0x3EEA3F0", VA = "0x183EEB9F0")]
	public THandle FABNFHGMHGJ(TValue KLABJGGMBGH)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB470", Offset = "0x3EE9E70", VA = "0x183EEB470")]
	public bool AGDCKPANMGG(THandle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBCF0", Offset = "0x3EEA6F0", VA = "0x183EEBCF0")]
	public bool JLNEIPDMCNA(THandle GPPOCIDKPII, [Out] TValue KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC120", Offset = "0x3EEAB20", VA = "0x183EEC120")]
	public TValue PBGHNKGJFJB(THandle GPPOCIDKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB5A0", Offset = "0x3EE9FA0", VA = "0x183EEB5A0")]
	public bool AOOFMIHDJBB(THandle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBB60", Offset = "0x3EEA560", VA = "0x183EEBB60")]
	private THandle IBJJHKKIGPD(int HGFDMIDEFHN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBC90", Offset = "0x3EEA690", VA = "0x183EEBC90")]
	private TValue JHMOEGIAFJJ(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB6C0", Offset = "0x3EEA0C0", VA = "0x183EEB6C0")]
	private void BBEPNAAAKJD(int HGFDMIDEFHN, [In] THandle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC0D0", Offset = "0x3EEAAD0", VA = "0x183EEC0D0")]
	private void OMPLFGPAEBL(int HGFDMIDEFHN, [In] TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBDC0", Offset = "0x3EEA7C0", VA = "0x183EEBDC0")]
	private THandle JNEMLDPLPCA()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC180", Offset = "0x3EEAB80", VA = "0x183EEC180")]
	private void PLINIAFMDDA(THandle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBF80", Offset = "0x3EEA980", VA = "0x183EEBF80")]
	private int LILGAIGAIME(int CJEHFDAEGCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBC80", Offset = "0x3EEA680", VA = "0x183EEBC80")]
	private bool IOGCDIODCPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8A5F70", Offset = "0x8A4970", VA = "0x1808A5F70")]
	private void PNAMGIEDGMA(THandle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBAA0", Offset = "0x3EEA4A0", VA = "0x183EEBAA0")]
	private bool FFPEMFOONAJ([Out] THandle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBF90", Offset = "0x3EEA990", VA = "0x183EEBF90")]
	private bool NJJCHDILAMH([Out] THandle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBBC0", Offset = "0x3EEA5C0", VA = "0x183EEBBC0")]
	private void IGALBFMLGPJ(THandle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB830", Offset = "0x3EEA230", VA = "0x183EEB830")]
	private void EDKMGGPOAJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EOIFKCNADCO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MFBBLPJBOGP
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
public static class BPAPIOEBAKP
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB280", Offset = "0x2AD9C80", VA = "0x182ADB280")]
	public static bool NDBEEGNEIKL<T>(this T GPPOCIDKPII, T PLNBHPCFEOK) where T : struct, EOIFKCNADCO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB2A0", Offset = "0x2AD9CA0", VA = "0x182ADB2A0")]
	public static bool OGCLLAHCFGD<T>(this T GPPOCIDKPII) where T : struct, EOIFKCNADCO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B360", Offset = "0x6C49D60", VA = "0x186C4B360")]
	public static string JDHBGLIAIFD(this EOIFKCNADCO GPPOCIDKPII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct FGNBBGCPHEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type MBMHEGAFHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> FBFLGOGMNFM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x44B3DE0", Offset = "0x44B27E0", VA = "0x1844B3DE0")]
	public FGNBBGCPHEE(Type KCMHHLDAACM, Span<byte> EBMIBGINKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2D81450", Offset = "0x2D7FE50", VA = "0x182D81450")]
	public static FGNBBGCPHEE IPHAGGDKEPB<T>(T KLABJGGMBGH) where T : struct
	{
		return default(FGNBBGCPHEE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B750", Offset = "0x6C4A150", VA = "0x186C4B750")]
	public static BMMILLGHHLI BIEOCAPMHCM([In] FGNBBGCPHEE CGJIPKMEOFC)
	{
		return default(BMMILLGHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2ADAB00", Offset = "0x2AD9500", VA = "0x182ADAB00")]
	public T PBGHNKGJFJB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B7E0", Offset = "0x6C4A1E0", VA = "0x186C4B7E0")]
	public Enum PKDHJHKIJLO(Type LKNKNGAOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D80C60", Offset = "0x2D7F660", VA = "0x182D80C60")]
	public void ENCKAHEIPGI<T>([In] T KLABJGGMBGH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B7D0", Offset = "0x6C4A1D0", VA = "0x186C4B7D0")]
	public void FAMFJPAKBMO(Enum HBEFBGGFFKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct BMMILLGHHLI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct GNGNDPBBJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* KJDKNBIDOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* DPFCBDOOEDH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type MBMHEGAFHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> FBFLGOGMNFM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KHAEIGABOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B1B0", Offset = "0x6C49BB0", VA = "0x186C4B1B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x44B3DE0", Offset = "0x44B27E0", VA = "0x1844B3DE0")]
	public BMMILLGHHLI(Type KCMHHLDAACM, ReadOnlySpan<byte> EBMIBGINKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8050", Offset = "0x2AD6A50", VA = "0x182AD8050")]
	public static BMMILLGHHLI IPHAGGDKEPB<T>(T KLABJGGMBGH) where T : struct
	{
		return default(BMMILLGHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7ED0", Offset = "0x2AD68D0", VA = "0x182AD7ED0")]
	public static BMMILLGHHLI IPHAGGDKEPB<T>(NativeArray<T> KLABJGGMBGH) where T : struct
	{
		return default(BMMILLGHHLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B150", Offset = "0x6C49B50", VA = "0x186C4B150")]
	public void IKLPEOJFMNH(Span<byte> GIEDJFEABAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B080", Offset = "0x6C49A80", VA = "0x186C4B080")]
	public void IKLPEOJFMNH(NativeArray<byte> GIEDJFEABAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2ADAB30", Offset = "0x2AD9530", VA = "0x182ADAB30")]
	public T PBGHNKGJFJB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD70C0", Offset = "0x2AD5AC0", VA = "0x182AD70C0")]
	public NativeArray<T> ANALNAJCEPH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B320", Offset = "0x6C49D20", VA = "0x186C4B320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B1F0", Offset = "0x6C49BF0", VA = "0x186C4B1F0")]
	private object PIOAGFEMFKM()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct IKBDFFLOPKK
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BB90", Offset = "0x2E0A590", VA = "0x182E0BB90")]
	public static NativeArray<T> DJJBKJFMCHA<T>(T KLABJGGMBGH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BC30", Offset = "0x2E0A630", VA = "0x182E0BC30")]
	public static NativeArray<T> NLNBFMALGMF<T>(T KLABJGGMBGH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BBE0", Offset = "0x2E0A5E0", VA = "0x182E0BBE0")]
	public static NativeArray<T> IPHAGGDKEPB<T>(T KLABJGGMBGH, bool MPKLOIOFKAG) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BOEJKFIDCCM<Handle> where Handle : EOIFKCNADCO, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct ADONKLANOEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly BOEJKFIDCCM<Handle> PNBHHBNOEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int HGFDMIDEFHN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle LGCJMABNOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3E78B30", Offset = "0x3E77530", VA = "0x183E78B30")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3E790D0", Offset = "0x3E77AD0", VA = "0x183E790D0")]
		public ADONKLANOEA(BOEJKFIDCCM<Handle> PNBHHBNOEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3E78A90", Offset = "0x3E77490", VA = "0x183E78A90")]
		public MMNMBFDKKIO GGBAHLJJLHO([In] MMNMBFDKKIO MNKBAIOBLHC)
		{
			return default(MMNMBFDKKIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3E78850", Offset = "0x3E77250", VA = "0x183E78850")]
		public bool AMEHHFPEGIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3E78FB0", Offset = "0x3E779B0", VA = "0x183E78FB0")]
		private Handle OJKEKBIEHMO(string KFAOBDLOMDC)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct MMNMBFDKKIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private ADONKLANOEA PCAFNOGJNOD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x478BBA0", Offset = "0x478A5A0", VA = "0x18478BBA0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x478BC20", Offset = "0x478A620", VA = "0x18478BC20")]
		public MMNMBFDKKIO(BOEJKFIDCCM<Handle> PNBHHBNOEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x478BA20", Offset = "0x478A420", VA = "0x18478BA20")]
		public bool AMEHHFPEGIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x478BAE0", Offset = "0x478A4E0", VA = "0x18478BAE0")]
		public MMNMBFDKKIO HNHGFOAAHAF()
		{
			return default(MMNMBFDKKIO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> AAMMEKMDFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> CJFFBLANGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int KNACGDGJJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int NKMOEMLMAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool EHJHBDKNMEH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JKEHIMLHIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5193790", Offset = "0x5192190", VA = "0x185193790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MMNMBFDKKIO GJFEMEEEFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x51946C0", Offset = "0x51930C0", VA = "0x1851946C0")]
		get
		{
			return default(MMNMBFDKKIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5195960", Offset = "0x5194360", VA = "0x185195960")]
	public BOEJKFIDCCM(int PNEOLMDLHBN, Allocator NPNPKHEIOHB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5194970", Offset = "0x5193370", VA = "0x185194970")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1ADC580", Offset = "0x1ADAF80", VA = "0x181ADC580")]
	public static int LILGAIGAIME(int LEKEIHPCIEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x272DB90", Offset = "0x272C590", VA = "0x18272DB90")]
	public static bool CDCMGNNAPMP(int LEKEIHPCIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x51939C0", Offset = "0x51923C0", VA = "0x1851939C0")]
	public bool EALEKBOMKFK(int HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5194420", Offset = "0x5192E20", VA = "0x185194420")]
	public bool GNJBIILFJOK(Handle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5193D50", Offset = "0x5192750", VA = "0x185193D50")]
	public Handle FBLOKHAGBOM()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5195630", Offset = "0x5194030", VA = "0x185195630")]
	public void OAFPCGKHPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5194030", Offset = "0x5192A30", VA = "0x185194030")]
	public void GHDDEOCPHBH(Handle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5194810", Offset = "0x5193210", VA = "0x185194810")]
	public bool KEHMJJHCKGN(Handle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9C3C00", Offset = "0x9C2600", VA = "0x1809C3C00")]
	private bool GOGLKNDDPDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5194660", Offset = "0x5193060", VA = "0x185194660")]
	private bool HCFIFCJJKHA(int HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x51932D0", Offset = "0x5191CD0", VA = "0x1851932D0")]
	private void BLJPOFEPHMF([Out] int HGFDMIDEFHN, [Out] int CJEHFDAEGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5194E60", Offset = "0x5193860", VA = "0x185194E60")]
	private void MFBLJDBGLEA(Handle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5193280", Offset = "0x5191C80", VA = "0x185193280")]
	private void AOFGLNJAHGK(int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5193130", Offset = "0x5191B30", VA = "0x185193130")]
	private bool ANLNEKBNDOJ([Out] int HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5193900", Offset = "0x5192300", VA = "0x185193900")]
	private static Handle CMGMNNIBKIO(int HGFDMIDEFHN, int CJEHFDAEGCE)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct CFAOFCPNGBH<Handle, T> where Handle : EOIFKCNADCO, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BOEJKFIDCCM<Handle> BNEDCDADPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] HAPJJBDKDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> IAPLAOKPJCA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55830A0", Offset = "0x5581AA0", VA = "0x1855830A0")]
	public CFAOFCPNGBH(int PNEOLMDLHBN, [Optional] Action<T> IAPLAOKPJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5582960", Offset = "0x5581360", VA = "0x185582960")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5582770", Offset = "0x5581170", VA = "0x185582770")]
	public bool JLNEIPDMCNA(Handle GPPOCIDKPII, [Out] T GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55822F0", Offset = "0x5580CF0", VA = "0x1855822F0")]
	public Handle FABNFHGMHGJ(T GHMNBJIOGAM)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5581E50", Offset = "0x5580850", VA = "0x185581E50")]
	public void DHNBBOCMLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5582B60", Offset = "0x5581560", VA = "0x185582B60")]
	public void MBEEDABKNGP(Handle GPPOCIDKPII, [Out] T HCBHCHHBBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5582A80", Offset = "0x5581480", VA = "0x185582A80")]
	public void MBEEDABKNGP(Handle GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5581B10", Offset = "0x5580510", VA = "0x185581B10")]
	public bool DHAPIEAKDFP(Handle GPPOCIDKPII, [Out] T HCBHCHHBBIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5581650", Offset = "0x5580050", VA = "0x185581650")]
	public bool DHAPIEAKDFP(Handle GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5582640", Offset = "0x5581040", VA = "0x185582640")]
	private T FDBDCLPINFK(int HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5582FE0", Offset = "0x55819E0", VA = "0x185582FE0")]
	private void PHBPFDOAJJA(int BAPDOMLMICH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct DCBPMLOKBLC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] JGCMECODHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int KHMKAEGDPPG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2154C90", Offset = "0x2153690", VA = "0x182154C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2EF62E0", Offset = "0x2EF4CE0", VA = "0x182EF62E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> FBFLGOGMNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5B2C1C0", Offset = "0x5B2ABC0", VA = "0x185B2C1C0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OADKJCMIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x10E6F10", Offset = "0x10E5910", VA = "0x1810E6F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5B2C3E0", Offset = "0x5B2ADE0", VA = "0x185B2C3E0")]
	public DCBPMLOKBLC(int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5B2C330", Offset = "0x5B2AD30", VA = "0x185B2C330")]
	public int OHCPFAOHMPG(T KLABJGGMBGH, int OENMMCMOJOM, int FIGHABPEBPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5B2C0B0", Offset = "0x5B2AAB0", VA = "0x185B2C0B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct FKPPMPJBOIP<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct ONMCCAHBPFE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private FKPPMPJBOIP<T> OLAPNOFMNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int HGFDMIDEFHN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x49099B0", Offset = "0x49083B0", VA = "0x1849099B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4909A50", Offset = "0x4908450", VA = "0x184909A50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4909A20", Offset = "0x4908420", VA = "0x184909A20")]
		public ONMCCAHBPFE(FKPPMPJBOIP<T> OLAPNOFMNPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4909920", Offset = "0x4908320", VA = "0x184909920", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4909960", Offset = "0x4908360", VA = "0x184909960", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private DCBPMLOKBLC<T> JGCMECODHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int KHMKAEGDPPG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3E05510", Offset = "0x3E03F10", VA = "0x183E05510")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8961A0", Offset = "0x894BA0", VA = "0x1808961A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3E05F60", Offset = "0x3E04960", VA = "0x183E05F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int JKEHIMLHIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3E055A0", Offset = "0x3E03FA0", VA = "0x183E055A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OADKJCMIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3E05FB0", Offset = "0x3E049B0", VA = "0x183E05FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> FBFLGOGMNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3E05930", Offset = "0x3E04330", VA = "0x183E05930")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3E06180", Offset = "0x3E04B80", VA = "0x183E06180")]
	public FKPPMPJBOIP(int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3E05FF0", Offset = "0x3E049F0", VA = "0x183E05FF0")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3E05820", Offset = "0x3E04220", VA = "0x183E05820")]
	public void FABNFHGMHGJ(T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3E05C40", Offset = "0x3E04640", VA = "0x183E05C40")]
	internal void GGAOOKOGIDC(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3E052D0", Offset = "0x3E03CD0", VA = "0x183E052D0")]
	public void AAOPJACGKPM(int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3E059F0", Offset = "0x3E043F0", VA = "0x183E059F0")]
	public void FLDGJIJJDHA(int LJPLCEIDCDB, int FOOPMAMGEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3E06050", Offset = "0x3E04A50", VA = "0x183E06050")]
	public int OHCPFAOHMPG(T KLABJGGMBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3E057E0", Offset = "0x3E041E0", VA = "0x183E057E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3E05E80", Offset = "0x3E04880", VA = "0x183E05E80", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3E060D0", Offset = "0x3E04AD0", VA = "0x183E060D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3E06110", Offset = "0x3E04B10", VA = "0x183E06110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3E053C0", Offset = "0x3E03DC0", VA = "0x183E053C0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void BNCPBJILNNI(int KLABJGGMBGH, int KHMKAEGDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3E055D0", Offset = "0x3E03FD0", VA = "0x183E055D0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void COGNEGJLDMJ(int LJPLCEIDCDB, int FOOPMAMGEIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LIDAMMEOCHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int IEHCONIHMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int FIGHABPEBPG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int FINIPIMGMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9F6230", Offset = "0x9F4C30", VA = "0x1809F6230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2710A10", Offset = "0x270F410", VA = "0x182710A10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6025520", Offset = "0x6023F20", VA = "0x186025520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int MGECPAAHDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6230", Offset = "0x9F4C30", VA = "0x1809F6230")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MIFABMICKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C590", Offset = "0x6C4AF90", VA = "0x186C4C590")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C5B0", Offset = "0x6C4AFB0", VA = "0x186C4C5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
	private LIDAMMEOCHG(int IEHCONIHMPO, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x216CC80", Offset = "0x216B680", VA = "0x18216CC80")]
	public static LIDAMMEOCHG CBAGAAFIGFG(int IEHCONIHMPO, int FIGHABPEBPG)
	{
		return default(LIDAMMEOCHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C5A0", Offset = "0x6C4AFA0", VA = "0x186C4C5A0")]
	public static LIDAMMEOCHG KNHHPKKGLKF(int OENMMCMOJOM, int FOOPMAMGEIK)
	{
		return default(LIDAMMEOCHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C5C0", Offset = "0x6C4AFC0", VA = "0x186C4C5C0", Slot = "3")]
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
