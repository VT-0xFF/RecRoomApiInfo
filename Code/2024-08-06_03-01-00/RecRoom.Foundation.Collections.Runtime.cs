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
	public class LogRegistrationIndex : MHGCIIOBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69A8F20", Offset = "0x69A7520", VA = "0x1869A8F20", Slot = "4")]
		public override void OOMCOBOGONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class INMDIPGDOAK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69A8C80", Offset = "0x69A7280", VA = "0x1869A8C80")]
	public static void GFFFFMKIBOF(this GameObject BBKKNFIIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69A8D20", Offset = "0x69A7320", VA = "0x1869A8D20")]
	public static void GFFFFMKIBOF(this Component NNFKLCEBDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69A8BE0", Offset = "0x69A71E0", VA = "0x1869A8BE0")]
	public static void GFFFFMKIBOF(this ScriptableObject KDDCDLMPJMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JIPJFHPBAAE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69A8E70", Offset = "0x69A7470", VA = "0x1869A8E70")]
	public static Span<byte> OODBKNAOMOM(this NativeArray<byte> NMHOKLPDKBK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69A8DC0", Offset = "0x69A73C0", VA = "0x1869A8DC0")]
	public static ReadOnlySpan<byte> IMLCGKNHLCD(this NativeArray<byte> NMHOKLPDKBK)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDFD0", Offset = "0x2BBC5D0", VA = "0x182BBDFD0")]
	public static NativeArray<T> NIGOOJOGKIC<T>(this NativeArray<T> NMHOKLPDKBK, HHILMKFNIKP LBJFABAANBI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDF90", Offset = "0x2BBC590", VA = "0x182BBDF90")]
	public static NativeArray<T> NIGOOJOGKIC<T>(this NativeArray<T> NMHOKLPDKBK, int KKKICJLJANF) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BDKIJIHBCKI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28F2CD0", Offset = "0x28F12D0", VA = "0x1828F2CD0")]
	public static string FPFMBBABBJD<T>(this NativeArray<T> NMHOKLPDKBK, string ACFFPIIIBLF = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HIJLLBEDBBN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B88B60", Offset = "0x2B87160", VA = "0x182B88B60")]
	public static T BJJBEHDKBAF<T>([In] this ReadOnlySpan<byte> FAOMDALPLFC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2B8AF60", Offset = "0x2B89560", VA = "0x182B8AF60")]
	public static NativeArray<T> PJHANDDGBFJ<T>(this ReadOnlySpan<byte> FAOMDALPLFC) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8ABC0", Offset = "0x2B891C0", VA = "0x182B8ABC0")]
	public static ReadOnlySpan<TTo> NMNLDMKOHAB<TTo, TFrom>(this ReadOnlySpan<TFrom> FAOMDALPLFC) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B89CF0", Offset = "0x2B882F0", VA = "0x182B89CF0")]
	public static Span<byte> FNIGGHLNDBN<T>([In] this Span<byte> FAOMDALPLFC, T FEBGGALLBNN) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69A8530", Offset = "0x69A6B30", VA = "0x1869A8530")]
	private static Enum JDGMGIJFDEM([In] ReadOnlySpan<byte> FAOMDALPLFC, Type HFAFLGFODND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69A7FE0", Offset = "0x69A65E0", VA = "0x1869A7FE0")]
	public static Enum EHHMBANLBIF([In] this Span<byte> FAOMDALPLFC, Type HFAFLGFODND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69A8050", Offset = "0x69A6650", VA = "0x1869A8050")]
	public static void HCOFOAIAMIB([In] this Span<byte> FAOMDALPLFC, Enum FKJJEAOFBOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DGFFBNALANM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DEDCDKFFDDB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69A7A00", Offset = "0x69A6000", VA = "0x1869A7A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69A7B80", Offset = "0x69A6180", VA = "0x1869A7B80")]
	[AsyncStateMachine(typeof(DEDCDKFFDDB))]
	public static void CENHNAOAMJP(this Task GJMDIBEDCBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ACNIOBFKALP
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MGNHMMCALDC : short
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
	public struct COFMKJBJLHN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly MGNHMMCALDC MNBFPOFIDHA;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2568D40", Offset = "0x2567340", VA = "0x182568D40")]
		public COFMKJBJLHN(MGNHMMCALDC MNBFPOFIDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory MKHBOOCEGJF;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	public static void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69A79A0", Offset = "0x69A5FA0", VA = "0x1869A79A0")]
	static ACNIOBFKALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2872030", Offset = "0x2870630", VA = "0x182872030")]
	public static COFMKJBJLHN ILAAMALAEJB(MGNHMMCALDC MNBFPOFIDHA)
	{
		return default(COFMKJBJLHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	public static void KJABBIDNPFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class CNAADHDMEOL<THandle, TValue> : IDisposable where THandle : struct, BGKDNKIMIFC where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> HPALBJPGOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> EGCOBBLGNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> GHMPCDHPKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> OCKKBHKCKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int AILECAAFHGH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x51B9F40", Offset = "0x51B8540", VA = "0x1851B9F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x51BA220", Offset = "0x51B8820", VA = "0x1851BA220")]
	public CNAADHDMEOL(Action<TValue> OCKKBHKCKHM, [Optional] Func<TValue> GHMPCDHPKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x51B9830", Offset = "0x51B7E30", VA = "0x1851B9830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x51B93F0", Offset = "0x51B79F0", VA = "0x1851B93F0")]
	public THandle AGMNBECNIJC(TValue FEBGGALLBNN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x51B9560", Offset = "0x51B7B60", VA = "0x1851B9560")]
	public bool AMMOOILDICF(THandle NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x51B9750", Offset = "0x51B7D50", VA = "0x1851B9750")]
	public bool CBPJGMGJFOI(THandle NNBIOLHDGAK, [Out] TValue FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x51B9690", Offset = "0x51B7C90", VA = "0x1851B9690")]
	public TValue BJJBEHDKBAF(THandle NNBIOLHDGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x51BA100", Offset = "0x51B8700", VA = "0x1851BA100")]
	public bool PIFOANKJMPH(THandle NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x51B9D50", Offset = "0x51B8350", VA = "0x1851B9D50")]
	private THandle KGJKLOFILON(int EBDMAJMOJLN)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x51B96F0", Offset = "0x51B7CF0", VA = "0x1851B96F0")]
	private TValue BKBHIMDHMLK(int EBDMAJMOJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51B9EF0", Offset = "0x51B84F0", VA = "0x1851B9EF0")]
	private void MHODMIHCIOE(int EBDMAJMOJLN, [In] THandle NNBIOLHDGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x51BA0B0", Offset = "0x51B86B0", VA = "0x1851BA0B0")]
	private void PGBPILIJKHH(int EBDMAJMOJLN, [In] TValue FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x51B99D0", Offset = "0x51B7FD0", VA = "0x1851B99D0")]
	private THandle GJPMIKKMIIC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x51B9F90", Offset = "0x51B8590", VA = "0x1851B9F90")]
	private void PEAKGKNMJJC(THandle NNBIOLHDGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x51B9F80", Offset = "0x51B8580", VA = "0x1851B9F80")]
	private int ODADMLKJKIB(int PKICDAADPKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51B9820", Offset = "0x51B7E20", VA = "0x1851B9820")]
	private bool CCPBNLOEBOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8632F0", Offset = "0x8618F0", VA = "0x1808632F0")]
	private void GHACNLKEOMK(THandle NNBIOLHDGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x51B94A0", Offset = "0x51B7AA0", VA = "0x1851B94A0")]
	private bool AIOMGHMPNMC([Out] THandle NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x51B9DB0", Offset = "0x51B83B0", VA = "0x1851B9DB0")]
	private bool KKDNCFILKGL([Out] THandle NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x51B9910", Offset = "0x51B7F10", VA = "0x1851B9910")]
	private void FFEAMFNFHDK(THandle NNBIOLHDGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x51B9B90", Offset = "0x51B8190", VA = "0x1851B9B90")]
	private void JJJHCIBKLNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BGKDNKIMIFC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int JPOHIBGABMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int DDMNNMLGMAO
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
public static class MMEMNLDLAKO
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C618C0", Offset = "0x2C5FEC0", VA = "0x182C618C0")]
	public static bool LPFMNLAIKFM<T>(this T NNBIOLHDGAK, T OGEIJLCLBIC) where T : struct, BGKDNKIMIFC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C618E0", Offset = "0x2C5FEE0", VA = "0x182C618E0")]
	public static bool NEEAOKHHHDA<T>(this T NNBIOLHDGAK) where T : struct, BGKDNKIMIFC
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69A8FB0", Offset = "0x69A75B0", VA = "0x1869A8FB0")]
	public static string GMOPIPOELFC(this BGKDNKIMIFC NNBIOLHDGAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct IIJMDPEFOIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type HJNJAKLMJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> FLOBPNMJHBK;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x42826B0", Offset = "0x4280CB0", VA = "0x1842826B0")]
	public IIJMDPEFOIG(Type KABFPLHGFFP, Span<byte> FAOMDALPLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D010", Offset = "0x2B9B610", VA = "0x182B9D010")]
	public static IIJMDPEFOIG AINDKFFJENA<T>(T FEBGGALLBNN) where T : struct
	{
		return default(IIJMDPEFOIG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69A8B60", Offset = "0x69A7160", VA = "0x1869A8B60")]
	public static EMHJONJGKLA IHCIOHJGPAF([In] IIJMDPEFOIG IIMGHHPJFMO)
	{
		return default(EMHJONJGKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69A8AD0", Offset = "0x69A70D0", VA = "0x1869A8AD0")]
	public Enum EHHMBANLBIF(Type HFAFLGFODND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E120", Offset = "0x2B9C720", VA = "0x182B9E120")]
	public void FNIGGHLNDBN<T>([In] T FEBGGALLBNN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69A8B50", Offset = "0x69A7150", VA = "0x1869A8B50")]
	public void HCOFOAIAMIB(Enum FKJJEAOFBOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct EMHJONJGKLA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct DNDDFOPMNEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* MMMIPKJLFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* IMDMIHKKBNC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type HJNJAKLMJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> FLOBPNMJHBK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BONHNBEOKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69A7EA0", Offset = "0x69A64A0", VA = "0x1869A7EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x42826B0", Offset = "0x4280CB0", VA = "0x1842826B0")]
	public EMHJONJGKLA(Type KABFPLHGFFP, ReadOnlySpan<byte> FAOMDALPLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29F8BD0", Offset = "0x29F71D0", VA = "0x1829F8BD0")]
	public static EMHJONJGKLA AINDKFFJENA<T>(T FEBGGALLBNN) where T : struct
	{
		return default(EMHJONJGKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29F8A50", Offset = "0x29F7050", VA = "0x1829F8A50")]
	public static EMHJONJGKLA AINDKFFJENA<T>(NativeArray<T> FEBGGALLBNN) where T : struct
	{
		return default(EMHJONJGKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69A7DD0", Offset = "0x69A63D0", VA = "0x1869A7DD0")]
	public void NFOKJEMMIBI(NativeArray<byte> IFKICKEJMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x29FB3E0", Offset = "0x29F99E0", VA = "0x1829FB3E0")]
	public T BJJBEHDKBAF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29FB530", Offset = "0x29F9B30", VA = "0x1829FB530")]
	public NativeArray<T> PJHANDDGBFJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69A7EE0", Offset = "0x69A64E0", VA = "0x1869A7EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69A7CA0", Offset = "0x69A62A0", VA = "0x1869A7CA0")]
	private object HNMLMOJGCAN()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HNPEHACJIFM
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B8CE70", Offset = "0x2B8B470", VA = "0x182B8CE70")]
	public static NativeArray<T> JPAIKHOOCEE<T>(T FEBGGALLBNN) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8CE20", Offset = "0x2B8B420", VA = "0x182B8CE20")]
	public static NativeArray<T> AINDKFFJENA<T>(T FEBGGALLBNN, bool DEAFLLGNHNI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KMECLMNNPLB<Handle> where Handle : BGKDNKIMIFC, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct NPNENOGAMKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly KMECLMNNPLB<Handle> HFEKFICPOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int EBDMAJMOJLN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle PAHNBIDIGON
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x46020D0", Offset = "0x46006D0", VA = "0x1846020D0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4602950", Offset = "0x4600F50", VA = "0x184602950")]
		public NPNENOGAMKE(KMECLMNNPLB<Handle> HFEKFICPOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x46028B0", Offset = "0x4600EB0", VA = "0x1846028B0")]
		public CNBOLGLBKLF NKOJKFHACJH([In] CNBOLGLBKLF CEBMDGFHLLP)
		{
			return default(CNBOLGLBKLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4602790", Offset = "0x4600D90", VA = "0x184602790")]
		public bool LEKDILHCHKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4602070", Offset = "0x4600670", VA = "0x184602070")]
		private Handle IJDJCGEDEPC(string DICMABMCPKO)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct CNBOLGLBKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private NPNENOGAMKE FMNDEJANOBE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x51BA7D0", Offset = "0x51B8DD0", VA = "0x1851BA7D0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x51BA950", Offset = "0x51B8F50", VA = "0x1851BA950")]
		public CNBOLGLBKLF(KMECLMNNPLB<Handle> HFEKFICPOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x51BA8D0", Offset = "0x51B8ED0", VA = "0x1851BA8D0")]
		public bool LEKDILHCHKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x51BA810", Offset = "0x51B8E10", VA = "0x1851BA810")]
		public CNBOLGLBKLF CPHKKMADKBM()
		{
			return default(CNBOLGLBKLF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> BDFPAPNDALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> ILEPLDJLFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int GHDOJHBOLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int BDNCGBIGJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool NAPJMJFLIOE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HLDGGDLOPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4213570", Offset = "0x4211B70", VA = "0x184213570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CNBOLGLBKLF IFEENFFNCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x42119D0", Offset = "0x420FFD0", VA = "0x1842119D0")]
		get
		{
			return default(CNBOLGLBKLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4214100", Offset = "0x4212700", VA = "0x184214100")]
	public KMECLMNNPLB(int HMGCDCANKDC, Allocator JKHEKCINHDP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4211B30", Offset = "0x4210130", VA = "0x184211B30")]
	public void BEBGJICOPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x19703A0", Offset = "0x196E9A0", VA = "0x1819703A0")]
	public static int ODADMLKJKIB(int ONOKCMNNMGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2590070", Offset = "0x258E670", VA = "0x182590070")]
	public static bool FOBNBLPFNNI(int ONOKCMNNMGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4213760", Offset = "0x4211D60", VA = "0x184213760")]
	public bool OJACDJJANLG(int EBDMAJMOJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4213260", Offset = "0x4211860", VA = "0x184213260")]
	public bool MPJGGPOCHEK(Handle NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4212BE0", Offset = "0x42111E0", VA = "0x184212BE0")]
	public Handle EKNGMCDMDGO()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4211FB0", Offset = "0x42105B0", VA = "0x184211FB0")]
	public void DAFPHMCHLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4213070", Offset = "0x4211670", VA = "0x184213070")]
	public void FGJEBGENODB(Handle NNBIOLHDGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4211E10", Offset = "0x4210410", VA = "0x184211E10")]
	public bool CAJLOHOEBMN(Handle NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xB4FA90", Offset = "0xB4E090", VA = "0x180B4FA90")]
	private bool AAECIKIAPJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x42139C0", Offset = "0x4211FC0", VA = "0x1842139C0")]
	private bool PDCGHPNEOAN(int EBDMAJMOJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4213AE0", Offset = "0x42120E0", VA = "0x184213AE0")]
	private void PGPDIGFIDMN([Out] int EBDMAJMOJLN, [Out] int PKICDAADPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x42115D0", Offset = "0x420FBD0", VA = "0x1842115D0")]
	private void ACJMCKJNDKH(Handle NNBIOLHDGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4211F10", Offset = "0x4210510", VA = "0x184211F10")]
	private void CCBFHHNLBAD(int EBDMAJMOJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4212D80", Offset = "0x4211380", VA = "0x184212D80")]
	private bool EMELBBOBFEE([Out] int EBDMAJMOJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4212A50", Offset = "0x4211050", VA = "0x184212A50")]
	private static Handle EKHIKJBBHMO(int EBDMAJMOJLN, int PKICDAADPKG)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct LDPKHHFLEIH<Handle, T> where Handle : BGKDNKIMIFC, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KMECLMNNPLB<Handle> EMNPHPFJDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] HILGFOEPHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> OCAMNNOHPOA;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x429FD40", Offset = "0x429E340", VA = "0x18429FD40")]
	public LDPKHHFLEIH(int HMGCDCANKDC, [Optional] Action<T> OCAMNNOHPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x429E6A0", Offset = "0x429CCA0", VA = "0x18429E6A0")]
	public void BEBGJICOPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x429E850", Offset = "0x429CE50", VA = "0x18429E850")]
	public bool CBPJGMGJFOI(Handle NNBIOLHDGAK, [Out] T CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x429E400", Offset = "0x429CA00", VA = "0x18429E400")]
	public Handle AGMNBECNIJC(T CDBNFNMIHPK)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x429F4D0", Offset = "0x429DAD0", VA = "0x18429F4D0")]
	public void MECNMMOGPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x429FBA0", Offset = "0x429E1A0", VA = "0x18429FBA0")]
	public void PJEMHMBEIPM(Handle NNBIOLHDGAK, [Out] T KIDEHIAMBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x429FAC0", Offset = "0x429E0C0", VA = "0x18429FAC0")]
	public void PJEMHMBEIPM(Handle NNBIOLHDGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x429EE50", Offset = "0x429D450", VA = "0x18429EE50")]
	public bool INENMFAMDKI(Handle NNBIOLHDGAK, [Out] T KIDEHIAMBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x429EB80", Offset = "0x429D180", VA = "0x18429EB80")]
	public bool INENMFAMDKI(Handle NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x429E640", Offset = "0x429CC40", VA = "0x18429E640")]
	private T BAPGLNEOIJA(int EBDMAJMOJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x429FC80", Offset = "0x429E280", VA = "0x18429FC80")]
	private void PKMDOKANHHG(int OPOKAKNHJLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct KFMELIKNNLP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] JHLEMCFOEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int KDDFOIMAIHK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int BANKGEHECOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2C495C0", Offset = "0x2C47BC0", VA = "0x182C495C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> FLOBPNMJHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x41DB1E0", Offset = "0x41D97E0", VA = "0x1841DB1E0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool PNMIFIKLJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xF60210", Offset = "0xF5E810", VA = "0x180F60210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x41DB400", Offset = "0x41D9A00", VA = "0x1841DB400")]
	public KFMELIKNNLP(int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x41DB280", Offset = "0x41D9880", VA = "0x1841DB280")]
	public int LDAKPMBGKGF(T FEBGGALLBNN, int KKKICJLJANF, int FDDANCOAHOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x41DB0D0", Offset = "0x41D96D0", VA = "0x1841DB0D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct JPIFDHEJDJL<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct PPNKADDJICP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private JPIFDHEJDJL<T> MNNCEMFBNNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int EBDMAJMOJLN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x483E2D0", Offset = "0x483C8D0", VA = "0x18483E2D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x483E370", Offset = "0x483C970", VA = "0x18483E370", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x483E340", Offset = "0x483C940", VA = "0x18483E340")]
		public PPNKADDJICP(JPIFDHEJDJL<T> MNNCEMFBNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x483E240", Offset = "0x483C840", VA = "0x18483E240", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x483E280", Offset = "0x483C880", VA = "0x18483E280", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KFMELIKNNLP<T> JHLEMCFOEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int KDDFOIMAIHK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4109710", Offset = "0x4107D10", VA = "0x184109710")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BANKGEHECOP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85D1A0", Offset = "0x85B7A0", VA = "0x18085D1A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4108D20", Offset = "0x4107320", VA = "0x184108D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int HLDGGDLOPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x41097A0", Offset = "0x4107DA0", VA = "0x1841097A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool PNMIFIKLJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x41095F0", Offset = "0x4107BF0", VA = "0x1841095F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> FLOBPNMJHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4108FC0", Offset = "0x41075C0", VA = "0x184108FC0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4109AC0", Offset = "0x41080C0", VA = "0x184109AC0")]
	public JPIFDHEJDJL(int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4109630", Offset = "0x4107C30", VA = "0x184109630")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4108C10", Offset = "0x4107210", VA = "0x184108C10")]
	public void AGMNBECNIJC(T FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x41097D0", Offset = "0x4107DD0", VA = "0x1841097D0")]
	internal void NIIBDLMKCAG(int HDGFIGFBKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4109420", Offset = "0x4107A20", VA = "0x184109420")]
	public void FBCKHABHFCF(int EBDMAJMOJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4109080", Offset = "0x4107680", VA = "0x184109080")]
	public void EJKKMDAMPLE(int DMJONIAKNKJ, int MDHDJKJDJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4109690", Offset = "0x4107C90", VA = "0x184109690")]
	public int LDAKPMBGKGF(T FEBGGALLBNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4108F80", Offset = "0x4107580", VA = "0x184108F80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4109510", Offset = "0x4107B10", VA = "0x184109510", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4109A10", Offset = "0x4108010", VA = "0x184109A10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4109A50", Offset = "0x4108050", VA = "0x184109A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x41092D0", Offset = "0x41078D0", VA = "0x1841092D0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void EKEHONBALDH(int FEBGGALLBNN, int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4108D70", Offset = "0x4107370", VA = "0x184108D70")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CMJJGFHNDMP(int DMJONIAKNKJ, int MDHDJKJDJJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HHILMKFNIKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int LHOLHMCKPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int FDDANCOAHOL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AMCGEKKJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC10", Offset = "0xB5D210", VA = "0x180B5EC10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2587140", Offset = "0x2585740", VA = "0x182587140")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D948D0", Offset = "0x5D92ED0", VA = "0x185D948D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int CINPMHEKJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC10", Offset = "0xB5D210", VA = "0x180B5EC10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int FPPJAIDLFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69A7F30", Offset = "0x69A6530", VA = "0x1869A7F30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69A7F40", Offset = "0x69A6540", VA = "0x1869A7F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
	private HHILMKFNIKP(int LHOLHMCKPEO, int FDDANCOAHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3790", Offset = "0x1FF1D90", VA = "0x181FF3790")]
	public static HHILMKFNIKP LJEMELIPIHN(int LHOLHMCKPEO, int FDDANCOAHOL)
	{
		return default(HHILMKFNIKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69A7F20", Offset = "0x69A6520", VA = "0x1869A7F20")]
	public static HHILMKFNIKP BNHDFAGBLMH(int KKKICJLJANF, int MDHDJKJDJJA)
	{
		return default(HHILMKFNIKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69A7F50", Offset = "0x69A6550", VA = "0x1869A7F50", Slot = "3")]
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
