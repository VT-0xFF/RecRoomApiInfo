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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7470", Offset = "0x6DD6870", VA = "0x186DD7470", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ECDNDDHMGGA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6CC0", Offset = "0x6DD60C0", VA = "0x186DD6CC0")]
	public static void ACCJLGOFJEA(this GameObject BCDDMHHPJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6E00", Offset = "0x6DD6200", VA = "0x186DD6E00")]
	public static void ACCJLGOFJEA(this Component GKPPNECBJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6D60", Offset = "0x6DD6160", VA = "0x186DD6D60")]
	public static void ACCJLGOFJEA(this ScriptableObject CHPECPJNPPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HLPDLCEJCMF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7250", Offset = "0x6DD6650", VA = "0x186DD7250")]
	public static Span<byte> FGNNPGAEMJA(this NativeArray<byte> IGGIDMIPNHL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7300", Offset = "0x6DD6700", VA = "0x186DD7300")]
	public static ReadOnlySpan<byte> MJEMPIHBNNA(this NativeArray<byte> IGGIDMIPNHL)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E75990", Offset = "0x2E74D90", VA = "0x182E75990")]
	public static NativeArray<T> CHFKPEDMFEK<T>(this NativeArray<T> IGGIDMIPNHL, KAGIILHFJGF HAIEMBCHPMF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2E75950", Offset = "0x2E74D50", VA = "0x182E75950")]
	public static NativeArray<T> CHFKPEDMFEK<T>(this NativeArray<T> IGGIDMIPNHL, int IJLPKFECKFC) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CNLFMFBGIPB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2C68DE0", Offset = "0x2C681E0", VA = "0x182C68DE0")]
	public static string JHLCDFMIAGG<T>(this NativeArray<T> IGGIDMIPNHL, string AOGLHAGFPCP = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OFLIBFDKHBC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2FFCF40", Offset = "0x2FFC340", VA = "0x182FFCF40")]
	public static T CADKKGPFCDD<T>([In] this ReadOnlySpan<byte> BDHOGCNFJMO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD650", Offset = "0x2FFCA50", VA = "0x182FFD650")]
	public static T CADKKGPFCDD<T>([In] this Span<byte> BDHOGCNFJMO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2FFDF30", Offset = "0x2FFD330", VA = "0x182FFDF30")]
	public static NativeArray<T> CIKADDKEPBO<T>(this ReadOnlySpan<byte> BDHOGCNFJMO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6120", Offset = "0x2BF5520", VA = "0x182BF6120")]
	public static ReadOnlySpan<TTo> LODHKMEGCFG<TTo, TFrom>(this ReadOnlySpan<TFrom> BDHOGCNFJMO) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2FFE890", Offset = "0x2FFDC90", VA = "0x182FFE890")]
	public static Span<byte> MCAKFOHFDBM<T>([In] this Span<byte> BDHOGCNFJMO, T EEPLCHCGAIN) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7950", Offset = "0x6DD6D50", VA = "0x186DD7950")]
	private static Enum BAIHGIPIMLI([In] ReadOnlySpan<byte> BDHOGCNFJMO, Type NELLBAIPLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7EF0", Offset = "0x6DD72F0", VA = "0x186DD7EF0")]
	public static Enum ECNBIMMECJL([In] this Span<byte> BDHOGCNFJMO, Type NELLBAIPLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7F60", Offset = "0x6DD7360", VA = "0x186DD7F60")]
	public static void EDFBHNOBAJG([In] this Span<byte> BDHOGCNFJMO, Enum GLEGKLPKAOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GPJEEEGHFHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HABJJFDCAAC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6DD6FC0", Offset = "0x6DD63C0", VA = "0x186DD6FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6EA0", Offset = "0x6DD62A0", VA = "0x186DD6EA0")]
	[AsyncStateMachine(typeof(HABJJFDCAAC))]
	public static void DGAFPHBPFKO(this Task KBFPLGGGODF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NNGKCBKHOOF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum OOLHIMCBKKI : short
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
	public struct ELBBLHDHNCL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly OOLHIMCBKKI OEOMDKHBDFI;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27CDEF0", Offset = "0x27CD2F0", VA = "0x1827CDEF0")]
		public ELBBLHDHNCL(OOLHIMCBKKI OEOMDKHBDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory KKCGFLAHKCD;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	public static void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DD78F0", Offset = "0x6DD6CF0", VA = "0x186DD78F0")]
	static NNGKCBKHOOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B58050", Offset = "0x2B57450", VA = "0x182B58050")]
	public static ELBBLHDHNCL FHCLPOFHJAJ(OOLHIMCBKKI OEOMDKHBDFI)
	{
		return default(ELBBLHDHNCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	public static void BNBLBNOIFKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class FKDOCEKLMOC<THandle, TValue> : IDisposable where THandle : struct, NLGMFENKCMI where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> PBBPAIDOHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> BFAMJIIMLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> GEDGHMFPBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> OCLAPJBNFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int POPPNNKNBEB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F48D50", Offset = "0x3F48150", VA = "0x183F48D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F48DE0", Offset = "0x3F481E0", VA = "0x183F48DE0")]
	public FKDOCEKLMOC(Action<TValue> OCLAPJBNFCB, [Optional] Func<TValue> GEDGHMFPBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3F48130", Offset = "0x3F47530", VA = "0x183F48130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3F48660", Offset = "0x3F47A60", VA = "0x183F48660")]
	public THandle LEFBGNCKNFL(TValue EEPLCHCGAIN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3F484D0", Offset = "0x3F478D0", VA = "0x183F484D0")]
	public bool KJDEEDGEPIJ(THandle KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3F48220", Offset = "0x3F47620", VA = "0x183F48220")]
	public bool FAKKNFFMHEG(THandle KNOJBNNAGCL, [Out] TValue EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3F480D0", Offset = "0x3F474D0", VA = "0x183F480D0")]
	public TValue CADKKGPFCDD(THandle KNOJBNNAGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3F47FB0", Offset = "0x3F473B0", VA = "0x183F47FB0")]
	public bool AJEFCBIPMCP(THandle KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3F48B30", Offset = "0x3F47F30", VA = "0x183F48B30")]
	private THandle NLJLMJMFCMK(int HAJICDLBEKC)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3F48600", Offset = "0x3F47A00", VA = "0x183F48600")]
	private TValue KNHFAJNBGBJ(int HAJICDLBEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3F48D90", Offset = "0x3F48190", VA = "0x183F48D90")]
	private void PLDPMKLICKD(int HAJICDLBEKC, [In] THandle KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3F48300", Offset = "0x3F47700", VA = "0x183F48300")]
	private void HDIAEBCMCGC(int HAJICDLBEKC, [In] TValue EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3F48B90", Offset = "0x3F47F90", VA = "0x183F48B90")]
	private THandle OIFIKCAPANP()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F48A10", Offset = "0x3F47E10", VA = "0x183F48A10")]
	private void MPHJJBEMEHN(THandle KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3F48210", Offset = "0x3F47610", VA = "0x183F48210")]
	private int EOIIHLIFMAB(int ABNEAOFINHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F482F0", Offset = "0x3F476F0", VA = "0x183F482F0")]
	private bool GJDKPKGPINH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8A0", Offset = "0x8ACCA0", VA = "0x1808AD8A0")]
	private void KBCMCKHIMIN(THandle KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3F48410", Offset = "0x3F47810", VA = "0x183F48410")]
	private bool KDPPJONEGLE([Out] THandle KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3F488D0", Offset = "0x3F47CD0", VA = "0x183F488D0")]
	private bool MACNHHEONBJ([Out] THandle KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3F48350", Offset = "0x3F47750", VA = "0x183F48350")]
	private void IECBNHHIJMG(THandle KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3F48710", Offset = "0x3F47B10", VA = "0x183F48710")]
	private void LNIDMOCEKFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NLGMFENKCMI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int KMIIBMECGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int GPEGCFLKPNF
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
public static class HILFPHKNNGP
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E72960", Offset = "0x2E71D60", VA = "0x182E72960")]
	public static bool EJLJCFDOGGI<T>(this T KNOJBNNAGCL, T KNLMODPGFOA) where T : struct, NLGMFENKCMI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E72950", Offset = "0x2E71D50", VA = "0x182E72950")]
	public static bool CPKPPJFCLGP<T>(this T KNOJBNNAGCL) where T : struct, NLGMFENKCMI
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7140", Offset = "0x6DD6540", VA = "0x186DD7140")]
	public static string EFPDFKLEEAF(this NLGMFENKCMI KNOJBNNAGCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct NJIHLEJAJJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type BGAAAOFGIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> NHDDFGNBBHO;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x456C280", Offset = "0x456B680", VA = "0x18456C280")]
	public NJIHLEJAJJC(Type JONIGCMCJBF, Span<byte> BDHOGCNFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2FBB5B0", Offset = "0x2FBA9B0", VA = "0x182FBB5B0")]
	public static NJIHLEJAJJC IIAGPKIJJME<T>(T EEPLCHCGAIN) where T : struct
	{
		return default(NJIHLEJAJJC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7590", Offset = "0x6DD6990", VA = "0x186DD7590")]
	public static NMBPLOPJKJI EGFECENGKHG([In] NJIHLEJAJJC BHJLLDMOPFC)
	{
		return default(NMBPLOPJKJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2FBAE10", Offset = "0x2FBA210", VA = "0x182FBAE10")]
	public T CADKKGPFCDD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7500", Offset = "0x6DD6900", VA = "0x186DD7500")]
	public Enum ECNBIMMECJL(Type NELLBAIPLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC560", Offset = "0x2FBB960", VA = "0x182FBC560")]
	public void MCAKFOHFDBM<T>([In] T EEPLCHCGAIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7580", Offset = "0x6DD6980", VA = "0x186DD7580")]
	public void EDFBHNOBAJG(Enum GLEGKLPKAOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct NMBPLOPJKJI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct FMAGLALPMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* MCPOGJOKKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* GMKCAEDFNLA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type BGAAAOFGIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> NHDDFGNBBHO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GDNEEEAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7870", Offset = "0x6DD6C70", VA = "0x186DD7870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x456C280", Offset = "0x456B680", VA = "0x18456C280")]
	public NMBPLOPJKJI(Type JONIGCMCJBF, ReadOnlySpan<byte> BDHOGCNFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2FC01A0", Offset = "0x2FBF5A0", VA = "0x182FC01A0")]
	public static NMBPLOPJKJI IIAGPKIJJME<T>(T EEPLCHCGAIN) where T : struct
	{
		return default(NMBPLOPJKJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2FC02E0", Offset = "0x2FBF6E0", VA = "0x182FC02E0")]
	public static NMBPLOPJKJI IIAGPKIJJME<T>(NativeArray<T> EEPLCHCGAIN) where T : struct
	{
		return default(NMBPLOPJKJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7610", Offset = "0x6DD6A10", VA = "0x186DD7610")]
	public void BOHHJANEDAD(Span<byte> NDOHMNMLNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7670", Offset = "0x6DD6A70", VA = "0x186DD7670")]
	public void BOHHJANEDAD(NativeArray<byte> NDOHMNMLNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2FBEF70", Offset = "0x2FBE370", VA = "0x182FBEF70")]
	public T CADKKGPFCDD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2FBF0D0", Offset = "0x2FBE4D0", VA = "0x182FBF0D0")]
	public NativeArray<T> CIKADDKEPBO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD78B0", Offset = "0x6DD6CB0", VA = "0x186DD78B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7740", Offset = "0x6DD6B40", VA = "0x186DD7740")]
	private object JCOMBCIAMCI()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FJFHIBIFPIC
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A180", Offset = "0x2E49580", VA = "0x182E4A180")]
	public static NativeArray<T> LOCPJBPBLNB<T>(T EEPLCHCGAIN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A0E0", Offset = "0x2E494E0", VA = "0x182E4A0E0")]
	public static NativeArray<T> GHBDHCONLMG<T>(T EEPLCHCGAIN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A130", Offset = "0x2E49530", VA = "0x182E4A130")]
	public static NativeArray<T> IIAGPKIJJME<T>(T EEPLCHCGAIN, bool NAPMJEFHEIK) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EMCIICEKNHC<Handle> where Handle : NLGMFENKCMI, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MKGMOGFGEEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly EMCIICEKNHC<Handle> OKEFGGEHACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int HAJICDLBEKC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle EEGGFAJJJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x4805B10", Offset = "0x4804F10", VA = "0x184805B10")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4806290", Offset = "0x4805690", VA = "0x184806290")]
		public MKGMOGFGEEI(EMCIICEKNHC<Handle> OKEFGGEHACK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x48058F0", Offset = "0x4804CF0", VA = "0x1848058F0")]
		public FAIOILCALCE AHLALEPNKFA([In] FAIOILCALCE EFCBJHHANBC)
		{
			return default(FAIOILCALCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4805F30", Offset = "0x4805330", VA = "0x184805F30")]
		public bool MOBDCELHOMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4805E10", Offset = "0x4805210", VA = "0x184805E10")]
		private Handle MGKCFAFMFLE(string MOKGCFCFCPE)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct FAIOILCALCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private MKGMOGFGEEI AFEJFPBEDFK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C9D0", Offset = "0x3F2BDD0", VA = "0x183F2C9D0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CA10", Offset = "0x3F2BE10", VA = "0x183F2CA10")]
		public FAIOILCALCE(EMCIICEKNHC<Handle> OKEFGGEHACK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C8D0", Offset = "0x3F2BCD0", VA = "0x183F2C8D0")]
		public bool MOBDCELHOMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C810", Offset = "0x3F2BC10", VA = "0x183F2C810")]
		public FAIOILCALCE JLDAKMOMDIF()
		{
			return default(FAIOILCALCE);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> ELHKBHCPLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> FGGLLPGBCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int HNEFOCDHECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int DNELCKJCJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool OALCPEFGCLN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GNOFLAKLIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2E00", Offset = "0x3BA2200", VA = "0x183BA2E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FAIOILCALCE KAKPNNOINCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3BA21B0", Offset = "0x3BA15B0", VA = "0x183BA21B0")]
		get
		{
			return default(FAIOILCALCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4640", Offset = "0x3BA3A40", VA = "0x183BA4640")]
	public EMCIICEKNHC(int GGAMCBCCCPF, Allocator HPLNAKONHEI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2030", Offset = "0x3BA1430", VA = "0x183BA2030")]
	public void BMHCCLKIAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1B64DA0", Offset = "0x1B641A0", VA = "0x181B64DA0")]
	public static int EOIIHLIFMAB(int IFLBFOHFIEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x280D2D0", Offset = "0x280C6D0", VA = "0x18280D2D0")]
	public static bool AAJPJDADAGP(int IFLBFOHFIEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3BA1E40", Offset = "0x3BA1240", VA = "0x183BA1E40")]
	public bool ANPKJDGLJHG(int HAJICDLBEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3190", Offset = "0x3BA2590", VA = "0x183BA3190")]
	public bool MBMEEABKMNM(Handle KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2680", Offset = "0x3BA1A80", VA = "0x183BA2680")]
	public Handle EHAPNBDPBBL()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3A10", Offset = "0x3BA2E10", VA = "0x183BA3A10")]
	public void OAJAEPNLKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2330", Offset = "0x3BA1730", VA = "0x183BA2330")]
	public void COEAHOANDLF(Handle KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3870", Offset = "0x3BA2C70", VA = "0x183BA3870")]
	public bool MLLKBBHKHHG(Handle KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9439B0", Offset = "0x942DB0", VA = "0x1809439B0")]
	private bool BBEPMPHJOAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2880", Offset = "0x3BA1C80", VA = "0x183BA2880")]
	private bool EIGFNCEFELD(int HAJICDLBEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2940", Offset = "0x3BA1D40", VA = "0x183BA2940")]
	private void GAPLEDKDPAJ([Out] int HAJICDLBEKC, [Out] int ABNEAOFINHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA35C0", Offset = "0x3BA29C0", VA = "0x183BA35C0")]
	private void MKBJHNJFDCM(Handle KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3BA39C0", Offset = "0x3BA2DC0", VA = "0x183BA39C0")]
	private void NHFAOGEHNEM(int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2450", Offset = "0x3BA1850", VA = "0x183BA2450")]
	private bool CPGEIBEHMHL([Out] int HAJICDLBEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3BA43C0", Offset = "0x3BA37C0", VA = "0x183BA43C0")]
	private static Handle OFIIBKMLDCH(int HAJICDLBEKC, int ABNEAOFINHP)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct PHHHHGHCNBO<Handle, T> where Handle : NLGMFENKCMI, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private EMCIICEKNHC<Handle> DMODOBKFIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] NIBNIKFBGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> MPEABJCLCJH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C990", Offset = "0x4B1BD90", VA = "0x184B1C990")]
	public PHHHHGHCNBO(int GGAMCBCCCPF, [Optional] Action<T> MPEABJCLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B870", Offset = "0x4B1AC70", VA = "0x184B1B870")]
	public void BMHCCLKIAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BBA0", Offset = "0x4B1AFA0", VA = "0x184B1BBA0")]
	public bool FAKKNFFMHEG(Handle KNOJBNNAGCL, [Out] T FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BC50", Offset = "0x4B1B050", VA = "0x184B1BC50")]
	public Handle LEFBGNCKNFL(T FMAFBHGACNM)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C1F0", Offset = "0x4B1B5F0", VA = "0x184B1C1F0")]
	public void MHNKGABEKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B310", Offset = "0x4B1A710", VA = "0x184B1B310")]
	public void BJFEGIDGDBE(Handle KNOJBNNAGCL, [Out] T JPHGBPGIJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B3F0", Offset = "0x4B1A7F0", VA = "0x184B1B3F0")]
	public void BJFEGIDGDBE(Handle KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B1AF50", Offset = "0x4B1A350", VA = "0x184B1AF50")]
	public bool ABPKPNBJPMP(Handle KNOJBNNAGCL, [Out] T JPHGBPGIJON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4B1AD60", Offset = "0x4B1A160", VA = "0x184B1AD60")]
	public bool ABPKPNBJPMP(Handle KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C750", Offset = "0x4B1BB50", VA = "0x184B1C750")]
	private T NFGGCLAOHHC(int HAJICDLBEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C690", Offset = "0x4B1BA90", VA = "0x184B1C690")]
	private void MLEPPMNLAOM(int HADGCONNHEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct COHHAEHBKBO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] AIKOCCMKKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int LOKMFEIHLAN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2224730", Offset = "0x2223B30", VA = "0x182224730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2E5A5E0", Offset = "0x2E599E0", VA = "0x182E5A5E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> NHDDFGNBBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5A78B10", Offset = "0x5A77F10", VA = "0x185A78B10")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool JDLMGHLFGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x114F960", Offset = "0x114ED60", VA = "0x18114F960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5A78BB0", Offset = "0x5A77FB0", VA = "0x185A78BB0")]
	public COHHAEHBKBO(int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5A78A60", Offset = "0x5A77E60", VA = "0x185A78A60")]
	public int EDNOBGFMLLB(T EEPLCHCGAIN, int IJLPKFECKFC, int HMELIAGANNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5A78880", Offset = "0x5A77C80", VA = "0x185A78880", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct KCGEJFGCIEC<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct GNAGOLJEAFN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private KCGEJFGCIEC<T> KDBAFFDDPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int HAJICDLBEKC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x40BDDD0", Offset = "0x40BD1D0", VA = "0x1840BDDD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x40BDE70", Offset = "0x40BD270", VA = "0x1840BDE70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x40BDE40", Offset = "0x40BD240", VA = "0x1840BDE40")]
		public GNAGOLJEAFN(KCGEJFGCIEC<T> KDBAFFDDPME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x40BDD40", Offset = "0x40BD140", VA = "0x1840BDD40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x40BDD80", Offset = "0x40BD180", VA = "0x1840BDD80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private COHHAEHBKBO<T> AIKOCCMKKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int LOKMFEIHLAN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x44FBD10", Offset = "0x44FB110", VA = "0x1844FBD10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x44FBB20", Offset = "0x44FAF20", VA = "0x1844FBB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int GNOFLAKLIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x44FBB70", Offset = "0x44FAF70", VA = "0x1844FBB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JDLMGHLFGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x44FB910", Offset = "0x44FAD10", VA = "0x1844FB910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> NHDDFGNBBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x44FBDA0", Offset = "0x44FB1A0", VA = "0x1844FBDA0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x44FBF10", Offset = "0x44FB310", VA = "0x1844FBF10")]
	public KCGEJFGCIEC(int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x44FBBA0", Offset = "0x44FAFA0", VA = "0x1844FBBA0")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x44FBC00", Offset = "0x44FB000", VA = "0x1844FBC00")]
	public void LEFBGNCKNFL(T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44FB400", Offset = "0x44FA800", VA = "0x1844FB400")]
	internal void APPEBDLPLEM(int BIMLHBENMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x44FBA30", Offset = "0x44FAE30", VA = "0x1844FBA30")]
	public void HOMCHKJBOIP(int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x44FB1B0", Offset = "0x44FA5B0", VA = "0x1844FB1B0")]
	public void AKPDDBCKHNA(int BPLPHJFFCGC, int LELDIOMELDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x44FB680", Offset = "0x44FAA80", VA = "0x1844FB680")]
	public int EDNOBGFMLLB(T EEPLCHCGAIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x44FB640", Offset = "0x44FAA40", VA = "0x1844FB640", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x44FB950", Offset = "0x44FAD50", VA = "0x1844FB950", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x44FBE60", Offset = "0x44FB260", VA = "0x1844FBE60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x44FBEA0", Offset = "0x44FB2A0", VA = "0x1844FBEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x44FB060", Offset = "0x44FA460", VA = "0x1844FB060")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void AGIJHIGEKJJ(int EEPLCHCGAIN, int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x44FB700", Offset = "0x44FAB00", VA = "0x1844FB700")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void EIPFMLBJBJB(int BPLPHJFFCGC, int LELDIOMELDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KAGIILHFJGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int OLMEFNCLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int HMELIAGANNM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NLMHBLNBBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x27EB090", Offset = "0x27EA490", VA = "0x1827EB090")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6183F60", Offset = "0x6183360", VA = "0x186183F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int LJILBNHJJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int KNNOOCDGMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD73C0", Offset = "0x6DD67C0", VA = "0x186DD73C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD73D0", Offset = "0x6DD67D0", VA = "0x186DD73D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
	private KAGIILHFJGF(int OLMEFNCLGNG, int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x223C1E0", Offset = "0x223B5E0", VA = "0x18223C1E0")]
	public static KAGIILHFJGF PKNBKHPLKLP(int OLMEFNCLGNG, int HMELIAGANNM)
	{
		return default(KAGIILHFJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6DD73B0", Offset = "0x6DD67B0", VA = "0x186DD73B0")]
	public static KAGIILHFJGF DHFCEAGBLOI(int IJLPKFECKFC, int LELDIOMELDE)
	{
		return default(KAGIILHFJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6DD73E0", Offset = "0x6DD67E0", VA = "0x186DD73E0", Slot = "3")]
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
