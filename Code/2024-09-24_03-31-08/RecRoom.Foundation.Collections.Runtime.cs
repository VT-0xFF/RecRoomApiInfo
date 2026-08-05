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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B911E0", Offset = "0x6B8FBE0", VA = "0x186B911E0", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KDFHGEDLKPL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B909F0", Offset = "0x6B8F3F0", VA = "0x186B909F0")]
	public static void HJBMEIBLDHA(this GameObject BICFCMICGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B90A90", Offset = "0x6B8F490", VA = "0x186B90A90")]
	public static void HJBMEIBLDHA(this Component ANHGADCFANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B90B30", Offset = "0x6B8F530", VA = "0x186B90B30")]
	public static void HJBMEIBLDHA(this ScriptableObject LAAHAEMKHHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LFPLPGFEGPH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B90C90", Offset = "0x6B8F690", VA = "0x186B90C90")]
	public static Span<byte> KHFGDPCJNGE(this NativeArray<byte> FEMJEOMOEIN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B90D40", Offset = "0x6B8F740", VA = "0x186B90D40")]
	public static ReadOnlySpan<byte> LBBFPCJMMEE(this NativeArray<byte> FEMJEOMOEIN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BC20", Offset = "0x2E1A620", VA = "0x182E1BC20")]
	public static NativeArray<T> DPMFCLOMMPH<T>(this NativeArray<T> FEMJEOMOEIN, LFJLIGLJDEF KFMCFDFMFGI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BBE0", Offset = "0x2E1A5E0", VA = "0x182E1BBE0")]
	public static NativeArray<T> DPMFCLOMMPH<T>(this NativeArray<T> FEMJEOMOEIN, int ICLEKBDIINO) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MMFAJKKPFFG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2E78F30", Offset = "0x2E77930", VA = "0x182E78F30")]
	public static string KMFDMECADCN<T>(this NativeArray<T> FEMJEOMOEIN, string APPFEECPGPM = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FBNLFJBGOFM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D4D6B0", Offset = "0x2D4C0B0", VA = "0x182D4D6B0")]
	public static T GJMIFHLLDMF<T>([In] this ReadOnlySpan<byte> BIKPLFALGJB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2D4DFF0", Offset = "0x2D4C9F0", VA = "0x182D4DFF0")]
	public static T GJMIFHLLDMF<T>([In] this Span<byte> BIKPLFALGJB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D4CF00", Offset = "0x2D4B900", VA = "0x182D4CF00")]
	public static NativeArray<T> BEGLAHFLGDJ<T>(this ReadOnlySpan<byte> BIKPLFALGJB) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E5E0", Offset = "0x2D4CFE0", VA = "0x182D4E5E0")]
	public static ReadOnlySpan<TTo> HBMBAKIPHGE<TTo, TFrom>(this ReadOnlySpan<TFrom> BIKPLFALGJB) where TTo : struct where TFrom : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E900", Offset = "0x2D4D300", VA = "0x182D4E900")]
	public static Span<byte> ODIPBPJKHHK<T>([In] this Span<byte> BIKPLFALGJB, T IPHMAHBENGI) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FE90", Offset = "0x6B8E890", VA = "0x186B8FE90")]
	private static Enum KHHHMHGIBLB([In] ReadOnlySpan<byte> BIKPLFALGJB, Type AFLNHAHPOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B90440", Offset = "0x6B8EE40", VA = "0x186B90440")]
	public static Enum LBODBOAOPPG([In] this Span<byte> BIKPLFALGJB, Type AFLNHAHPOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B904B0", Offset = "0x6B8EEB0", VA = "0x186B904B0")]
	public static void MEFDHBAMHPB([In] this Span<byte> BIKPLFALGJB, Enum OEDIDFDHHOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DLHFCLCJLHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct MMKLKHKOEHI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6B91270", Offset = "0x6B8FC70", VA = "0x186B91270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FD70", Offset = "0x6B8E770", VA = "0x186B8FD70")]
	[AsyncStateMachine(typeof(MMKLKHKOEHI))]
	public static void ELOFLLGLPPG(this Task NNEFLDDEJJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IDFDBCJBFDG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum LDJKMEFNLNE : short
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
	public struct HIHCFAIJLFL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly LDJKMEFNLNE COMNIKKFEEB;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x26DF530", Offset = "0x26DDF30", VA = "0x1826DF530")]
		public HIHCFAIJLFL(LDJKMEFNLNE COMNIKKFEEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory DDIOFMABBBG;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B90990", Offset = "0x6B8F390", VA = "0x186B90990")]
	static IDFDBCJBFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A55810", Offset = "0x2A54210", VA = "0x182A55810")]
	public static HIHCFAIJLFL DCCKIPPPNHB(LDJKMEFNLNE COMNIKKFEEB)
	{
		return default(HIHCFAIJLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void POAMCBIMOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public class HJLLEKJMPAN<THandle, TValue> : IDisposable where THandle : struct, JEDKKJGHJPP where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<THandle> MBFKMAJIOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<TValue> KIAGDMGGGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Func<TValue> HONLDLKONPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Action<TValue> KIEBEKBLPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int ADNIAALKCIN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TValue BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3FC1C80", Offset = "0x3FC0680", VA = "0x183FC1C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1EE0", Offset = "0x3FC08E0", VA = "0x183FC1EE0")]
	public HJLLEKJMPAN(Action<TValue> KIEBEKBLPKO, [Optional] Func<TValue> HONLDLKONPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1370", Offset = "0x3FBFD70", VA = "0x183FC1370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1A40", Offset = "0x3FC0440", VA = "0x183FC1A40")]
	public THandle KDCHLCHLBCK(TValue IPHMAHBENGI)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1B60", Offset = "0x3FC0560", VA = "0x183FC1B60")]
	public bool MOGENANDEFO(THandle DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1E20", Offset = "0x3FC0820", VA = "0x183FC1E20")]
	public bool OIOKEJAEGIB(THandle DKMIJDPJCBM, [Out] TValue IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1700", Offset = "0x3FC0100", VA = "0x183FC1700")]
	public TValue GJMIFHLLDMF(THandle DKMIJDPJCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3FC15F0", Offset = "0x3FBFFF0", VA = "0x183FC15F0")]
	public bool GHBEHEKGDOG(THandle DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3FC11B0", Offset = "0x3FBFBB0", VA = "0x183FC11B0")]
	private THandle BMGOGIIKDAL(int ENMILGHAHOM)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1B00", Offset = "0x3FC0500", VA = "0x183FC1B00")]
	private TValue LNFDLNBFLOL(int ENMILGHAHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1DD0", Offset = "0x3FC07D0", VA = "0x183FC1DD0")]
	private void NLONGGAECMD(int ENMILGHAHOM, [In] THandle DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1160", Offset = "0x3FBFB60", VA = "0x183FC1160")]
	private void BANKOIMGLDC(int ENMILGHAHOM, [In] TValue IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1440", Offset = "0x3FBFE40", VA = "0x183FC1440")]
	private THandle FJLKOBNEGCD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1CC0", Offset = "0x3FC06C0", VA = "0x183FC1CC0")]
	private void NJJMCNGGOKO(THandle DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1AF0", Offset = "0x3FC04F0", VA = "0x183FC1AF0")]
	private int LCOAMKEEMHC(int MOOGIOAAOOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1AE0", Offset = "0x3FC04E0", VA = "0x183FC1AE0")]
	private bool KEPENHKEEKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8890A0", Offset = "0x887AA0", VA = "0x1808890A0")]
	private void DGFFBDKAAIP(THandle DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1210", Offset = "0x3FBFC10", VA = "0x183FC1210")]
	private bool CBPFPMPAAJP([Out] THandle DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1910", Offset = "0x3FC0310", VA = "0x183FC1910")]
	private bool IPFBDLMHGMM([Out] THandle DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3FC12C0", Offset = "0x3FBFCC0", VA = "0x183FC12C0")]
	private void DJKHPJADIMK(THandle DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1760", Offset = "0x3FC0160", VA = "0x183FC1760")]
	private void HLFDJAFKDIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JEDKKJGHJPP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int PCGHHNFLFFH
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
public static class DAMNFPDLOFC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B88F50", Offset = "0x2B87950", VA = "0x182B88F50")]
	public static bool LBAKINMKJHJ<T>(this T DKMIJDPJCBM, T CGCLEIBHLHF) where T : struct, JEDKKJGHJPP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B88F40", Offset = "0x2B87940", VA = "0x182B88F40")]
	public static bool DDBKACNOMBL<T>(this T DKMIJDPJCBM) where T : struct, JEDKKJGHJPP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FC60", Offset = "0x6B8E660", VA = "0x186B8FC60")]
	public static string DDGDHMMCKOH(this JEDKKJGHJPP DKMIJDPJCBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public ref struct LHLKFGKGHKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly Type ALIKONEHBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Span<byte> BAKOMHCKKGD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4469820", Offset = "0x4468220", VA = "0x184469820")]
	public LHLKFGKGHKF(Type HEDNIOHCGLH, Span<byte> BIKPLFALGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CBA0", Offset = "0x2E1B5A0", VA = "0x182E1CBA0")]
	public static LHLKFGKGHKF IDOJPEKGCAG<T>(T IPHMAHBENGI) where T : struct
	{
		return default(LHLKFGKGHKF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B90DF0", Offset = "0x6B8F7F0", VA = "0x186B90DF0")]
	public static LJBEBGPAIAD DBMBPMAANBF([In] LHLKFGKGHKF CLCPGILFJHI)
	{
		return default(LJBEBGPAIAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C840", Offset = "0x2E1B240", VA = "0x182E1C840")]
	public T GJMIFHLLDMF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B90E70", Offset = "0x6B8F870", VA = "0x186B90E70")]
	public Enum LBODBOAOPPG(Type AFLNHAHPOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B650", Offset = "0x2E4A050", VA = "0x182E4B650")]
	public void ODIPBPJKHHK<T>([In] T IPHMAHBENGI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B90EF0", Offset = "0x6B8F8F0", VA = "0x186B90EF0")]
	public void MEFDHBAMHPB(Enum OEDIDFDHHOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public ref struct LJBEBGPAIAD
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private struct NOKGEHGIDCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private unsafe void* GEKGHJBEJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* MNJEFBFHHJN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Type ALIKONEHBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly ReadOnlySpan<byte> BAKOMHCKKGD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BKOAINILKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B90F00", Offset = "0x6B8F900", VA = "0x186B90F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4469820", Offset = "0x4468220", VA = "0x184469820")]
	public LJBEBGPAIAD(Type HEDNIOHCGLH, ReadOnlySpan<byte> BIKPLFALGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E1E0", Offset = "0x2E4CBE0", VA = "0x182E4E1E0")]
	public static LJBEBGPAIAD IDOJPEKGCAG<T>(T IPHMAHBENGI) where T : struct
	{
		return default(LJBEBGPAIAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E320", Offset = "0x2E4CD20", VA = "0x182E4E320")]
	public static LJBEBGPAIAD IDOJPEKGCAG<T>(NativeArray<T> IPHMAHBENGI) where T : struct
	{
		return default(LJBEBGPAIAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B91070", Offset = "0x6B8FA70", VA = "0x186B91070")]
	public void NJPICHJAHLD(Span<byte> NDLIAMCDAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6B910D0", Offset = "0x6B8FAD0", VA = "0x186B910D0")]
	public void NJPICHJAHLD(NativeArray<byte> NDLIAMCDAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D7F0", Offset = "0x2E4C1F0", VA = "0x182E4D7F0")]
	public T GJMIFHLLDMF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D7A0", Offset = "0x2E4C1A0", VA = "0x182E4D7A0")]
	public NativeArray<T> BEGLAHFLGDJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6B911A0", Offset = "0x6B8FBA0", VA = "0x186B911A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6B90F40", Offset = "0x6B8F940", VA = "0x186B90F40")]
	private object GMJMMFOBCNI()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EGKOINDKKGL
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB1B0", Offset = "0x2BC9BB0", VA = "0x182BCB1B0")]
	public static NativeArray<T> LKDGIMCKFMK<T>(T IPHMAHBENGI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB200", Offset = "0x2BC9C00", VA = "0x182BCB200")]
	public static NativeArray<T> PKPBFPHHCEL<T>(T IPHMAHBENGI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB160", Offset = "0x2BC9B60", VA = "0x182BCB160")]
	public static NativeArray<T> IDOJPEKGCAG<T>(T IPHMAHBENGI, bool KECCEDOIHIM) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DHBNMGDMAGD<Handle> where Handle : JEDKKJGHJPP, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct CJGFMKFAFIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly DHBNMGDMAGD<Handle> HMIMBMEPECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int ENMILGHAHOM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle LHDMOKFMGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x54DCEA0", Offset = "0x54DB8A0", VA = "0x1854DCEA0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x54DD1C0", Offset = "0x54DBBC0", VA = "0x1854DD1C0")]
		public CJGFMKFAFIA(DHBNMGDMAGD<Handle> HMIMBMEPECC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x54DD010", Offset = "0x54DBA10", VA = "0x1854DD010")]
		public PHCDKFBFLJM OOAFHJGKFEK([In] PHCDKFBFLJM DICHKFJDHIG)
		{
			return default(PHCDKFBFLJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x54DC980", Offset = "0x54DB380", VA = "0x1854DC980")]
		public bool AMKJJPKKBEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x54DD160", Offset = "0x54DBB60", VA = "0x1854DD160")]
		private Handle PDCMNDGFEND(string BBDGOIMNDJI)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct PHCDKFBFLJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private CJGFMKFAFIA BFANBBPFIDK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x49A8810", Offset = "0x49A7210", VA = "0x1849A8810")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x49A8900", Offset = "0x49A7300", VA = "0x1849A8900")]
		public PHCDKFBFLJM(DHBNMGDMAGD<Handle> HMIMBMEPECC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x49A8750", Offset = "0x49A7150", VA = "0x1849A8750")]
		public bool AMKJJPKKBEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x49A8890", Offset = "0x49A7290", VA = "0x1849A8890")]
		public PHCDKFBFLJM PBHEMGCNMMA()
		{
			return default(PHCDKFBFLJM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeList<int> OGPCCFHFHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> EOMEJCALLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int NKLLKIFBGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int HGDFBABNBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool JNOHJMFMKDF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OAKGABBNEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5A98EC0", Offset = "0x5A978C0", VA = "0x185A98EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PHCDKFBFLJM JNBPMBDJJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5A98710", Offset = "0x5A97110", VA = "0x185A98710")]
		get
		{
			return default(PHCDKFBFLJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5A9AFD0", Offset = "0x5A999D0", VA = "0x185A9AFD0")]
	public DHBNMGDMAGD(int BAMIDGGKEFN, Allocator MPFEIGMBFCP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5A9A280", Offset = "0x5A98C80", VA = "0x185A9A280")]
	public void NEECMKACHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1AAFFE0", Offset = "0x1AAE9E0", VA = "0x181AAFFE0")]
	public static int LCOAMKEEMHC(int NLEGDNPENLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x271C600", Offset = "0x271B000", VA = "0x18271C600")]
	public static bool BJJPHBINMCL(int NLEGDNPENLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5A9A710", Offset = "0x5A99110", VA = "0x185A9A710")]
	public bool NKNOFMADPPI(int ENMILGHAHOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5A98B50", Offset = "0x5A97550", VA = "0x185A98B50")]
	public bool BMDKFILMJND(Handle DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5A99920", Offset = "0x5A98320", VA = "0x185A99920")]
	public Handle GFJEBANEDOF()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5A98F00", Offset = "0x5A97900", VA = "0x185A98F00")]
	public void FOCNPKDIOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5A98970", Offset = "0x5A97370", VA = "0x185A98970")]
	public void BKKACFLEAAN(Handle DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5A9A070", Offset = "0x5A98A70", VA = "0x185A9A070")]
	public bool KPFHKPFFCHF(Handle DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9A6B00", Offset = "0x9A5500", VA = "0x1809A6B00")]
	private bool PDJDIEOLAIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5A9A580", Offset = "0x5A98F80", VA = "0x185A9A580")]
	private bool NGCFDHBLLEI(int ENMILGHAHOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5A9A970", Offset = "0x5A99370", VA = "0x185A9A970")]
	private void NLGDBNKFPCI([Out] int ENMILGHAHOM, [Out] int MOOGIOAAOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5A99D70", Offset = "0x5A98770", VA = "0x185A99D70")]
	private void HBODDFEOPGP(Handle DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5A987F0", Offset = "0x5A971F0", VA = "0x185A987F0")]
	private void BGAANPBPGHG(int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5A9AF20", Offset = "0x5A99920", VA = "0x185A9AF20")]
	private bool PFHDELJMGCJ([Out] int ENMILGHAHOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5A99FB0", Offset = "0x5A989B0", VA = "0x185A99FB0")]
	private static Handle JBDNHHJNKMB(int ENMILGHAHOM, int MOOGIOAAOOM)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct BKMJPONAGEP<Handle, T> where Handle : JEDKKJGHJPP, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private DHBNMGDMAGD<Handle> DDJDMOMGFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] ONJHPOPHBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Action<T> LIHKFIBGFGB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x50F45F0", Offset = "0x50F2FF0", VA = "0x1850F45F0")]
	public BKMJPONAGEP(int BAMIDGGKEFN, [Optional] Action<T> LIHKFIBGFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x50F4240", Offset = "0x50F2C40", VA = "0x1850F4240")]
	public void NEECMKACHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x50F43C0", Offset = "0x50F2DC0", VA = "0x1850F43C0")]
	public bool OIOKEJAEGIB(Handle DKMIJDPJCBM, [Out] T FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x50F39E0", Offset = "0x50F23E0", VA = "0x1850F39E0")]
	public Handle KDCHLCHLBCK(T FHFDEAHMMBI)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x50F2F60", Offset = "0x50F1960", VA = "0x1850F2F60")]
	public void CHPMMMFAADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x50F34B0", Offset = "0x50F1EB0", VA = "0x1850F34B0")]
	public void GDFNAHCIADO(Handle DKMIJDPJCBM, [Out] T BCGIFGLKMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x50F3590", Offset = "0x50F1F90", VA = "0x1850F3590")]
	public void GDFNAHCIADO(Handle DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x50F3CE0", Offset = "0x50F26E0", VA = "0x1850F3CE0")]
	public bool KDEKLKEJALP(Handle DKMIJDPJCBM, [Out] T BCGIFGLKMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x50F3C00", Offset = "0x50F2600", VA = "0x1850F3C00")]
	public bool KDEKLKEJALP(Handle DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x50F2CD0", Offset = "0x50F16D0", VA = "0x1850F2CD0")]
	private T CDFFICCMFMF(int ENMILGHAHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x50F4180", Offset = "0x50F2B80", VA = "0x1850F4180")]
	private void NCIICOBINCD(int PMGCHKHPBGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public struct GIFNFEJLKAG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T[] LNCKNHNHHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int CGDCIDKGGML;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x213C400", Offset = "0x213AE00", VA = "0x18213C400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2E08F10", Offset = "0x2E07910", VA = "0x182E08F10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> BAKOMHCKKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3EDAAF0", Offset = "0x3ED94F0", VA = "0x183EDAAF0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DOLICCCNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x10BD080", Offset = "0x10BBA80", VA = "0x1810BD080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3EDAE00", Offset = "0x3ED9800", VA = "0x183EDAE00")]
	public GIFNFEJLKAG(int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3EDAB90", Offset = "0x3ED9590", VA = "0x183EDAB90")]
	public int COKCFNJBHFI(T IPHMAHBENGI, int ICLEKBDIINO, int CMNDBGDABDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3EDAD00", Offset = "0x3ED9700", VA = "0x183EDAD00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct HNPDCOKHGBJ<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct HNNMKNBGLDL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private HNPDCOKHGBJ<T> GLCCIANLCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int ENMILGHAHOM;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3FD28A0", Offset = "0x3FD12A0", VA = "0x183FD28A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3FD2940", Offset = "0x3FD1340", VA = "0x183FD2940", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3FD2910", Offset = "0x3FD1310", VA = "0x183FD2910")]
		public HNNMKNBGLDL(HNPDCOKHGBJ<T> GLCCIANLCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3FD2810", Offset = "0x3FD1210", VA = "0x183FD2810", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3FD2850", Offset = "0x3FD1250", VA = "0x183FD2850", Slot = "8")]
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
	private GIFNFEJLKAG<T> LNCKNHNHHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int CGDCIDKGGML;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3FD34A0", Offset = "0x3FD1EA0", VA = "0x183FD34A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3460", Offset = "0x3FD1E60", VA = "0x183FD3460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OAKGABBNEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3000", Offset = "0x3FD1A00", VA = "0x183FD3000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DOLICCCNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3320", Offset = "0x3FD1D20", VA = "0x183FD3320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> BAKOMHCKKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3FD2E80", Offset = "0x3FD1880", VA = "0x183FD2E80")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3870", Offset = "0x3FD2270", VA = "0x183FD3870")]
	public HNPDCOKHGBJ(int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3530", Offset = "0x3FD1F30", VA = "0x183FD3530")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3360", Offset = "0x3FD1D60", VA = "0x183FD3360")]
	public void KDCHLCHLBCK(T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3030", Offset = "0x3FD1A30", VA = "0x183FD3030")]
	internal void FNAINDJCGDM(int PAODLCPDLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3590", Offset = "0x3FD1F90", VA = "0x183FD3590")]
	public void OHHHFNECKHG(int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3FD2C50", Offset = "0x3FD1650", VA = "0x183FD2C50")]
	public void AHAICPKOBMD(int FJAALDMBHLM, int BCIIGBDEKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3FD2F40", Offset = "0x3FD1940", VA = "0x183FD2F40")]
	public int COKCFNJBHFI(T IPHMAHBENGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3FD2FC0", Offset = "0x3FD19C0", VA = "0x183FD2FC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3260", Offset = "0x3FD1C60", VA = "0x183FD3260", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3FD37C0", Offset = "0x3FD21C0", VA = "0x183FD37C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3800", Offset = "0x3FD2200", VA = "0x183FD3800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3670", Offset = "0x3FD2070", VA = "0x183FD3670")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void PDDHPDDICPE(int IPHMAHBENGI, int CGDCIDKGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3FD2A40", Offset = "0x3FD1440", VA = "0x183FD2A40")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ADBLLGHLOEI(int FJAALDMBHLM, int BCIIGBDEKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LFJLIGLJDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int EDCGGCHLNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int CMNDBGDABDM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int DLIHEBHOHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x26E9F30", Offset = "0x26E8930", VA = "0x1826E9F30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5F64670", Offset = "0x5F63070", VA = "0x185F64670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int BIHABMODLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int OLCHHCBEFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6B90BF0", Offset = "0x6B8F5F0", VA = "0x186B90BF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6B90BD0", Offset = "0x6B8F5D0", VA = "0x186B90BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
	private LFJLIGLJDEF(int EDCGGCHLNEI, int CMNDBGDABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2149990", Offset = "0x2148390", VA = "0x182149990")]
	public static LFJLIGLJDEF GHFLKFINNAC(int EDCGGCHLNEI, int CMNDBGDABDM)
	{
		return default(LFJLIGLJDEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B90BE0", Offset = "0x6B8F5E0", VA = "0x186B90BE0")]
	public static LFJLIGLJDEF EILLPNAAOMF(int ICLEKBDIINO, int BCIIGBDEKKH)
	{
		return default(LFJLIGLJDEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B90C00", Offset = "0x6B8F600", VA = "0x186B90C00", Slot = "3")]
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
