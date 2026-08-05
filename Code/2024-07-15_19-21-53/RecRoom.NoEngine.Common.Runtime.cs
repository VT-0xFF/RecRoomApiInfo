using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69A9E60", Offset = "0x69A8660", VA = "0x1869A9E60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C1C0", VA = "0x18087D9C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C200", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DNBIDNACMAN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69A2E50", Offset = "0x69A1650", VA = "0x1869A2E50")]
	public static string IBIKDEAMEBM(this Encoding EJCHCJDBNEL, [In] ReadOnlySequence<byte> DDNKCFIIBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x297F800", Offset = "0x297E000", VA = "0x18297F800")]
	private static void NDJJMKILAFN<T>(this ReadOnlySequence<T> BJMHIIGPDHE, [Out] ReadOnlySpan<T> GFBFAKABLEL, [Out] SequencePosition DPHPOBDCMJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class HOGDKDBDNKL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69A6B30", Offset = "0x69A5330", VA = "0x1869A6B30")]
	public HOGDKDBDNKL(bool GFGBDALIPEC, string PFDPCDCJPOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PMKFAPLFECJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LGJNCKMGIDF<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate Task<TResult> GGCMIGNEFGE(CancellationToken MPLGBOFHPLM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct LJMCMLFDOKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public LGJNCKMGIDF<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GGCMIGNEFGE taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4265E40", Offset = "0x4264640", VA = "0x184265E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4266EF0", Offset = "0x42656F0", VA = "0x184266EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? ICOEFJFJCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? JDCDBPOHPMP;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x423CBF0", Offset = "0x423B3F0", VA = "0x18423CBF0")]
	[AsyncStateMachine(typeof(LGJNCKMGIDF<>.LJMCMLFDOKM))]
	public Task<TResult> IKAMMKEFNCB(GGCMIGNEFGE FCCDOIIADHM, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x423CB80", Offset = "0x423B380", VA = "0x18423CB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x423CD30", Offset = "0x423B530", VA = "0x18423CD30")]
	public LGJNCKMGIDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class DMHCLCFLKEP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> MHFOFOHLOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T JNHPIMBJPMJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C79400", Offset = "0x3C77C00", VA = "0x183C79400")]
	public DMHCLCFLKEP([In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5771C10", Offset = "0x5770410", VA = "0x185771C10", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5772020", Offset = "0x5770820", VA = "0x185772020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57723F0", Offset = "0x5770BF0", VA = "0x1857723F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class ABDBEMJMHPI
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FF50", Offset = "0x2B5E750", VA = "0x182B5FF50")]
	public static DMHCLCFLKEP<T> FJAAFKPDAIA<T>([In] T JMDCGOKJIDA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DCOALHIPFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69A24C0", Offset = "0x69A0CC0", VA = "0x1869A24C0")]
	public static void HPIFAHPIGMG(this CancellationTokenSource NPCICLIMLAO, bool KLJHLCEFCAH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class OOKFMGIPCHO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
	public OOKFMGIPCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class PEHALAEOKAF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
	public PEHALAEOKAF(string EFDIBOPNAHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CLPDHPCEDGA
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x293C2A0", Offset = "0x293AAA0", VA = "0x18293C2A0")]
	public static PNCHJNCCPFE AEOIOIEMNCE<T>()
	{
		return default(PNCHJNCCPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x293C570", Offset = "0x293AD70", VA = "0x18293C570")]
	public static PNCHJNCCPFE NDIPDCDHLGP<T>([CallerMemberName] string BHFPKCCDEEC = "") where T : notnull
	{
		return default(PNCHJNCCPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x293C220", Offset = "0x293AA20", VA = "0x18293C220")]
	public static PNCHJNCCPFE AEOIOIEMNCE<T>(this T LMDEKGEENAI) where T : notnull
	{
		return default(PNCHJNCCPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x293C320", Offset = "0x293AB20", VA = "0x18293C320")]
	public static PNCHJNCCPFE JICKIJFPGDK<T>(this T LMDEKGEENAI, [CallerMemberName] string BHFPKCCDEEC = "") where T : notnull
	{
		return default(PNCHJNCCPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x293C4C0", Offset = "0x293ACC0", VA = "0x18293C4C0")]
	public static PNCHJNCCPFE NDIPDCDHLGP<T>(this T HIKEOGPAJAF, [CallerMemberName] string BHFPKCCDEEC = "") where T : notnull
	{
		return default(PNCHJNCCPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69A2440", Offset = "0x69A0C40", VA = "0x1869A2440")]
	public static PNCHJNCCPFE NDIPDCDHLGP(string MOPHJFICFLB, [CallerMemberName] string BHFPKCCDEEC = "")
	{
		return default(PNCHJNCCPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69A23A0", Offset = "0x69A0BA0", VA = "0x1869A23A0")]
	public static string HGNEPDOAAJF(this object HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate bool DKGPHICKHLB();
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OOKFMGIPCHO]
public delegate long JGEOJHOOOHH();
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GNLNINJCLDG
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static HJJFNJFIPKN HBEGKNFCDCD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HJJFNJFIPKN GHDJMMHMNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69A52B0", Offset = "0x69A3AB0", VA = "0x1869A52B0")]
		get
		{
			return default(HJJFNJFIPKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LCGCCPHPOMO GKHHHALGIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69A58A0", Offset = "0x69A40A0", VA = "0x1869A58A0")]
		get
		{
			return default(LCGCCPHPOMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JHFCLFEAMAG HDGADMKLJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69A5850", Offset = "0x69A4050", VA = "0x1869A5850")]
		get
		{
			return default(JHFCLFEAMAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool LOGHFMNNAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x69A5670", Offset = "0x69A3E70", VA = "0x1869A5670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69A53D0", Offset = "0x69A3BD0", VA = "0x1869A53D0")]
	public static void GDLABJGCJKC([In] HJJFNJFIPKN JBGLBBHHNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69A58F0", Offset = "0x69A40F0", VA = "0x1869A58F0")]
	public static void MGFMJHPPHBP(string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69A5300", Offset = "0x69A3B00", VA = "0x1869A5300")]
	public static void BMLAECFBIAL(string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B31190", Offset = "0x2B2F990", VA = "0x182B31190")]
	public static void BMLAECFBIAL<T>(T BGLHKLFFJEP, JLNEBPBAHKH<T> JNNDBFGKHHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69A56E0", Offset = "0x69A3EE0", VA = "0x1869A56E0")]
	public static void JOOIPPFNPKN(Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69A59C0", Offset = "0x69A41C0", VA = "0x1869A59C0")]
	public static void MLMHNCBNPCF(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69A5A40", Offset = "0x69A4240", VA = "0x1869A5A40")]
	public static void PAMBMNGADHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69A55F0", Offset = "0x69A3DF0", VA = "0x1869A55F0")]
	public static string HGNEPDOAAJF(object MEAFIMADMKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69A5580", Offset = "0x69A3D80", VA = "0x1869A5580")]
	public static long HDINOGPBMOA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69A5210", Offset = "0x69A3A10", VA = "0x1869A5210")]
	public static bool AHBIEMPEPON(bool NGPBJNKHNBB, string JNNDBFGKHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69A5780", Offset = "0x69A3F80", VA = "0x1869A5780")]
	public static double KGFKDPDHDEB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct HJJFNJFIPKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly LCGCCPHPOMO GKHHHALGIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly JHFCLFEAMAG HDGADMKLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly LENMAMIDEIM GFIKKAOOFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly JGEOJHOOOHH DGAPNECCIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly BAEHDBHNCBE CKEEHNCDOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly DKGPHICKHLB GGOMEHEBNID;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly LENMAMIDEIM MCOEEHPGIIC;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly JGEOJHOOOHH FOLEAFFLGMC;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly BAEHDBHNCBE LHHBNFEDHIB;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly DKGPHICKHLB NPGPALGJEGH;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly HJJFNJFIPKN ENKECPBOOIC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CFHDDGLKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69A60A0", Offset = "0x69A48A0", VA = "0x1869A60A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69A6A80", Offset = "0x69A5280", VA = "0x1869A6A80")]
	public HJJFNJFIPKN([In] LCGCCPHPOMO EKPDCOBDOCA, [In] JHFCLFEAMAG BDKBEKGLMAE, LENMAMIDEIM AGFFKCEAMOO, JGEOJHOOOHH ALEIFFMLFOL, BAEHDBHNCBE LIIENAFDHIN, DKGPHICKHLB OKOELIPHIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x69A6240", Offset = "0x69A4A40", VA = "0x1869A6240")]
	private static string IKFHAAOLEMC(object MEAFIMADMKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0")]
	private static long GJCEKEPEBLG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460")]
	private static string EFLDGGKAIOI(string GMHAEBALLKB, string? NNJFFKDDDDA, bool GFPCLPEDKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0")]
	private static bool OANNHFIKCKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69A6280", Offset = "0x69A4A80", VA = "0x1869A6280")]
	private static HJJFNJFIPKN LGEFIKAIAMK()
	{
		return default(HJJFNJFIPKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DADMFKKHJKH
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLMEAEGMDDP HGMNODJPCNM();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PLMEAEGMDDP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IOIGEPJKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKCJMOMAIOA();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HHDDKAPPENK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHIKIMDODOO([In] T OKGBBGMIACH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate void BDIMDGLFELB<T>([In] T BGLHKLFFJEP);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct DPKNNHGNADJ<T> : IEquatable<DPKNNHGNADJ<T>>, HHDDKAPPENK<DPKNNHGNADJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T JNHPIMBJPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int LINJEMEJAMF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6C90", Offset = "0x1FE5490", VA = "0x181FE6C90")]
	public DPKNNHGNADJ([In] T JMDCGOKJIDA, int DHNLEFJCEAH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x57B73A0", Offset = "0x57B5BA0", VA = "0x1857B73A0")]
	public static bool KBKLEFBHIDJ([In] DPKNNHGNADJ<T> IIILBPDHGHN, [In] DPKNNHGNADJ<T> CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x476CD10", Offset = "0x476B510", VA = "0x18476CD10", Slot = "4")]
	public bool Equals(DPKNNHGNADJ<T> OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3CFBF30", Offset = "0x3CFA730", VA = "0x183CFBF30", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x57B6BB0", Offset = "0x57B53B0", VA = "0x1857B6BB0")]
	public bool CHIKIMDODOO([In] DPKNNHGNADJ<T> OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x57B6E90", Offset = "0x57B5690", VA = "0x1857B6E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x57B7EF0", Offset = "0x57B66F0", VA = "0x1857B7EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x57B69D0", Offset = "0x57B51D0", VA = "0x1857B69D0")]
	public void ACGMCNJANLE([Out] T JMDCGOKJIDA, [Out] int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x57B7850", Offset = "0x57B6050", VA = "0x1857B7850")]
	public (T, int) KHDLPPMGLNF()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x57B7B00", Offset = "0x57B6300", VA = "0x1857B7B00", Slot = "5")]
	private bool LKNBAIKDIKE([In] DPKNNHGNADJ<T> OKGBBGMIACH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class LLCJMNJDOHE
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2C09480", Offset = "0x2C07C80", VA = "0x182C09480")]
	public static DPKNNHGNADJ<T> FJAAFKPDAIA<T>([In] T JMDCGOKJIDA, int DHNLEFJCEAH) where T : notnull
	{
		return default(DPKNNHGNADJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GGCMDJFIODB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B24280", Offset = "0x2B22A80", VA = "0x182B24280")]
	public static bool CHIKIMDODOO<T, U>([In] T HIKEOGPAJAF, [In] U MEAFIMADMKA) where T : notnull, HHDDKAPPENK<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate TResult OJOANALFDFD<T, out TResult>([In] T BGLHKLFFJEP);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FICPEACAEJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan JKCDDHGAGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? CCNMEKNMGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PGKLFDNLGPL();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLCONFGBIHL();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKNIGDBJONP();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct LCGCCPHPOMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly MOGKGCPKBNO ABEJNLMAHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly KGLLJHJHDMK AIDDDNPBONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly MOGKGCPKBNO LDEJGAMNAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly KGLLJHJHDMK DKEGFPLLMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly MOGKGCPKBNO MPHNIPBJPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly KGLLJHJHDMK MJGHBAOGIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly LOPPIOKENPJ KPEFIFMJJMO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly MOGKGCPKBNO PDIGHJKOGBB;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KGLLJHJHDMK PBILMKOGENC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly MOGKGCPKBNO CGMNKFPCCAA;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KGLLJHJHDMK GNKMIAELHKI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MOGKGCPKBNO JJBENLLAOOI;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly KGLLJHJHDMK KPBKHEIEMME;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly LOPPIOKENPJ BGMEJOJBHCA;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly LCGCCPHPOMO ENKECPBOOIC;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly MOGKGCPKBNO KBGAAKHBAJF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CFHDDGLKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69A7E50", Offset = "0x69A6650", VA = "0x1869A7E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB1E5F0", Offset = "0xB1CDF0", VA = "0x180B1E5F0")]
	public LCGCCPHPOMO(MOGKGCPKBNO HDFODPOCODG, KGLLJHJHDMK MNIEPJAPMKD, MOGKGCPKBNO EDPJMHBBCAG, KGLLJHJHDMK IBHNMECFCGG, MOGKGCPKBNO FFNEBLGHBNB, KGLLJHJHDMK AACOHMIFEKO, LOPPIOKENPJ ELNFFHEBPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0")]
	private static bool MGLCDPKIMGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void KHILCHOKDEG(string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0")]
	private static bool POJPKNGPFMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void OIMMMENGAOM(string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0")]
	private static bool LHLOHGIJBAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void HBMMAMICJPM(string JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void IEMKKIJEPIO(Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69A8050", Offset = "0x69A6850", VA = "0x1869A8050")]
	private static LCGCCPHPOMO LGEFIKAIAMK()
	{
		return default(LCGCCPHPOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0")]
	private static bool OHDCCLBNALO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69A8190", Offset = "0x69A6990", VA = "0x1869A8190")]
	public void MGFMJHPPHBP(object JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69A7DE0", Offset = "0x69A65E0", VA = "0x1869A7DE0")]
	public void BMLAECFBIAL(object JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1BEDCD0", Offset = "0x1BEC4D0", VA = "0x181BEDCD0")]
	public void JOOIPPFNPKN(Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69A7D00", Offset = "0x69A6500", VA = "0x1869A7D00")]
	public void BMLAECFBIAL(IBCFNKHBFJP JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2C06B60", Offset = "0x2C05360", VA = "0x182C06B60")]
	public void BMLAECFBIAL<T>(T BGLHKLFFJEP, JLNEBPBAHKH<T> JNNDBFGKHHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2C06D00", Offset = "0x2C05500", VA = "0x182C06D00")]
	public void MGFMJHPPHBP<T>([In] T BGLHKLFFJEP, FKEDAHKJJLN<T> JNNDBFGKHHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C06A90", Offset = "0x2C05290", VA = "0x182C06A90")]
	public void BMLAECFBIAL<T>([In] T BGLHKLFFJEP, FKEDAHKJJLN<T> JNNDBFGKHHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69A7C30", Offset = "0x69A6430", VA = "0x1869A7C30")]
	public bool AHBIEMPEPON(bool NGPBJNKHNBB, string JNNDBFGKHHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct PNCHJNCCPFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string JNHPIMBJPMJ;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x924F80", VA = "0x180926780")]
	public PNCHJNCCPFE(string JMDCGOKJIDA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
	public static string GCLAHEGAFFN([In] PNCHJNCCPFE HIKEOGPAJAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x96F7E0", Offset = "0x96DFE0", VA = "0x18096F7E0")]
	public static PNCHJNCCPFE GCLAHEGAFFN(string OKGBBGMIACH)
	{
		return default(PNCHJNCCPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69AA9A0", Offset = "0x69A91A0", VA = "0x1869AA9A0")]
	public string DNFAFKAIGIC(string JBNNPFLCMMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69AA9F0", Offset = "0x69A91F0", VA = "0x1869AA9F0")]
	public string DPDAFBEHFPK(object KKLNEJLIDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct MOOMEEOMEEK : IEquatable<MOOMEEOMEEK>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "4")]
	public bool Equals(MOOMEEOMEEK OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69A8E40", Offset = "0x69A7640", VA = "0x1869A8E40", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69A8E90", Offset = "0x69A7690", VA = "0x1869A8E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69A8EA0", Offset = "0x69A76A0", VA = "0x1869A8EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[EGHHEKDFLLK("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct PLBAMKEJCKB<T> : IEquatable<PLBAMKEJCKB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T JNHPIMBJPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool CCGHGMEEAEI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DPMAMPNLOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x476D690", Offset = "0x476BE90", VA = "0x18476D690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x476DDF0", Offset = "0x476C5F0", VA = "0x18476DDF0")]
	public PLBAMKEJCKB([In] T JMDCGOKJIDA, bool JNCLDJEAFJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x476D6A0", Offset = "0x476BEA0", VA = "0x18476D6A0")]
	public static bool KBKLEFBHIDJ([In] PLBAMKEJCKB<T> IIILBPDHGHN, [In] PLBAMKEJCKB<T> CLEBPGFBBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x476CD10", Offset = "0x476B510", VA = "0x18476CD10", Slot = "4")]
	public bool Equals(PLBAMKEJCKB<T> OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x476CBA0", Offset = "0x476B3A0", VA = "0x18476CBA0", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x476D380", Offset = "0x476BB80", VA = "0x18476D380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x476DA30", Offset = "0x476C230", VA = "0x18476DA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MPAGKCOHKNE
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2C338D0", Offset = "0x2C320D0", VA = "0x182C338D0")]
	public static PLBAMKEJCKB<T> GLLENGJADED<T>([In] T JMDCGOKJIDA) where T : notnull
	{
		return default(PLBAMKEJCKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2C339F0", Offset = "0x2C321F0", VA = "0x182C339F0")]
	public static PLBAMKEJCKB<T?> JHJHHIDHPNG<T>()
	{
		return default(PLBAMKEJCKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2C33AE0", Offset = "0x2C322E0", VA = "0x182C33AE0")]
	public static bool NJDLJMMPNCJ<T>([In] this PLBAMKEJCKB<T> GMNPEFACPJA, [Out][NotNullWhen(true)] T JMDCGOKJIDA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct JHFCLFEAMAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr MLMHNCBNPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr PAMBMNGADHH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr IAAMIALAKIB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr IEKIHOENDBI;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly JHFCLFEAMAG ENKECPBOOIC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CFHDDGLKNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69A75A0", Offset = "0x69A5DA0", VA = "0x1869A75A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAAFE00", VA = "0x180AB1600")]
	public JHFCLFEAMAG(IntPtr JMAOMNJMBLG, IntPtr AJBCOCAAEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void EECMFLDDIIB(string BHFPKCCDEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void MDJPAFMOMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69A7680", Offset = "0x69A5E80", VA = "0x1869A7680")]
	private static JHFCLFEAMAG LGEFIKAIAMK()
	{
		return default(JHFCLFEAMAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct JGADEFNHFJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr LIGHLENBNEH;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x924F80", VA = "0x180926780")]
	private JGADEFNHFJG(IntPtr AJBCOCAAEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x69A7480", Offset = "0x69A5C80", VA = "0x1869A7480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69A74A0", Offset = "0x69A5CA0", VA = "0x1869A74A0")]
	public static JGADEFNHFJG FJAAFKPDAIA(string BHFPKCCDEEC)
	{
		return default(JGADEFNHFJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD1E0", Offset = "0x1FBB9E0", VA = "0x181FBD1E0")]
	public static JGADEFNHFJG FJAAFKPDAIA([In] JHFCLFEAMAG BDKBEKGLMAE, string BHFPKCCDEEC)
	{
		return default(JGADEFNHFJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBCC20", Offset = "0x1FBB420", VA = "0x181FBCC20")]
	public static JGADEFNHFJG FJAAFKPDAIA([In] JHFCLFEAMAG BDKBEKGLMAE, Func<string> BHFPKCCDEEC)
	{
		return default(JGADEFNHFJG);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class AKOICJJCJIM
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate bool PPPJPCNIOAH<in TInput, TResult>(TInput PMPNIONIFNI, [Out] TResult ADPMAHMCGNH);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class OEPHJJIPBOF : DADMFKKHJKH
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class ECKFNDIHFIE : PLMEAEGMDDP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly ECKFNDIHFIE MJFJCBEEADM;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool IOIGEPJKPJN
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x69A3410", Offset = "0x69A1C10", VA = "0x1869A3410", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x69A3470", Offset = "0x69A1C70", VA = "0x1869A3470", Slot = "6")]
			public void OnCompleted(Action KFANDDBANJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			public void NKCJMOMAIOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public ECKFNDIHFIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly OEPHJJIPBOF MJFJCBEEADM;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		private OEPHJJIPBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69AA120", Offset = "0x69A8920", VA = "0x1869AA120", Slot = "4")]
		public PLMEAEGMDDP HGMNODJPCNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private sealed class CBCMHPHINPH : DADMFKKHJKH
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private sealed class KLHBJLHIJAH : PLMEAEGMDDP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly KLHBJLHIJAH MJFJCBEEADM;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool IOIGEPJKPJN
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x69A7B40", Offset = "0x69A6340", VA = "0x1869A7B40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x69A7B60", Offset = "0x69A6360", VA = "0x1869A7B60", Slot = "6")]
			public void OnCompleted(Action KFANDDBANJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			public void NKCJMOMAIOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public KLHBJLHIJAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly CBCMHPHINPH MJFJCBEEADM;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		private CBCMHPHINPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69A19E0", Offset = "0x69A01E0", VA = "0x1869A19E0", Slot = "4")]
		public PLMEAEGMDDP HGMNODJPCNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class EMKDAKFNGBF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public EMKDAKFNGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3801740", Offset = "0x37FFF40", VA = "0x183801740")]
		internal void OCFOKBDCBIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KBJCMIBPECK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KBJCMIBPECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D05980", Offset = "0x3D04180", VA = "0x183D05980")]
		internal void PNLMCEMDMKF(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct HCDJKNFJCPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69A5F40", Offset = "0x69A4740", VA = "0x1869A5F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB410", Offset = "0x9E9C10", VA = "0x1809EB410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PCLKGNDBKIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x69AA1F0", Offset = "0x69A89F0", VA = "0x1869AA1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9EB410", Offset = "0x9E9C10", VA = "0x1809EB410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HNGDDGNDHDL<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EFA0", Offset = "0x3D2D7A0", VA = "0x183D2EFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F110", Offset = "0x3D2D910", VA = "0x183D2F110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EMDLOLJAPOG<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x37FDF30", Offset = "0x37FC730", VA = "0x1837FDF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x37FE780", Offset = "0x37FCF80", VA = "0x1837FE780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct KDACLECGBDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x69A7860", Offset = "0x69A6060", VA = "0x1869A7860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x69A7A60", Offset = "0x69A6260", VA = "0x1869A7A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class PPFOLDPOHJP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PPFOLDPOHJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3801740", Offset = "0x37FFF40", VA = "0x183801740")]
		internal void IHNKBFICLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4776DB0", Offset = "0x47755B0", VA = "0x184776DB0")]
		internal void JAHANCNEOJE(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DADCMIFLDIB<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public PPPJPCNIOAH<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x573CE30", Offset = "0x573B630", VA = "0x18573CE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x573D540", Offset = "0x573BD40", VA = "0x18573D540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FMKFLAGOPLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x69A3FA0", Offset = "0x69A27A0", VA = "0x1869A3FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x69A4790", Offset = "0x69A2F90", VA = "0x1869A4790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct CBFHNMOFCDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x69A1AB0", Offset = "0x69A02B0", VA = "0x1869A1AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x69A1FF0", Offset = "0x69A07F0", VA = "0x1869A1FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct JDPJONECFLH<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x40882F0", Offset = "0x4086AF0", VA = "0x1840882F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4088AC0", Offset = "0x40872C0", VA = "0x184088AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MGEKIHOFIOD<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4490EC0", Offset = "0x448F6C0", VA = "0x184490EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x356F050", Offset = "0x356D850", VA = "0x18356F050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct IIMJAPPDEFI<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E62340", Offset = "0x3E60B40", VA = "0x183E62340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E63040", Offset = "0x3E61840", VA = "0x183E63040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct OAKBABMAFAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x69A9EE0", Offset = "0x69A86E0", VA = "0x1869A9EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x69AA0C0", Offset = "0x69A88C0", VA = "0x1869AA0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct JAOIHJCDKKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x69A6DF0", Offset = "0x69A55F0", VA = "0x1869A6DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x69A7160", Offset = "0x69A5960", VA = "0x1869A7160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct CENOPPNEFEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x69A2050", Offset = "0x69A0850", VA = "0x1869A2050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x69A2340", Offset = "0x69A0B40", VA = "0x1869A2340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class KFCBBKNKAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KFCBBKNKAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69A7AD0", Offset = "0x69A62D0", VA = "0x1869A7AD0")]
		internal Task BKJCOPFKKCG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JFELNDJHIIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x69A71C0", Offset = "0x69A59C0", VA = "0x1869A71C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x69A7420", Offset = "0x69A5C20", VA = "0x1869A7420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct PKMOGNNBOCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x69AA300", Offset = "0x69A8B00", VA = "0x1869AA300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x69AA4E0", Offset = "0x69A8CE0", VA = "0x1869AA4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GONAAKAJIPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x69A5B70", Offset = "0x69A4370", VA = "0x1869A5B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x69A5EE0", Offset = "0x69A46E0", VA = "0x1869A5EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MMAAOBGBJIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x69A8AF0", Offset = "0x69A72F0", VA = "0x1869A8AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69A8DE0", Offset = "0x69A75E0", VA = "0x1869A8DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class NCDJMBPMBME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public NCDJMBPMBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x69A8ED0", Offset = "0x69A76D0", VA = "0x1869A8ED0")]
		internal Task EIEMBFHNIED(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct MGBAKPLEICL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x69A8830", Offset = "0x69A7030", VA = "0x1869A8830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69A8A90", Offset = "0x69A7290", VA = "0x1869A8A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct IGHNAODIEIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69A6C10", Offset = "0x69A5410", VA = "0x1869A6C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x69A6D90", Offset = "0x69A5590", VA = "0x1869A6D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IFOCEDELGDA<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3E56EC0", Offset = "0x3E556C0", VA = "0x183E56EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3E57120", Offset = "0x3E55920", VA = "0x183E57120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PLIDJKKMLBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69AA540", Offset = "0x69A8D40", VA = "0x1869AA540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x69AA940", Offset = "0x69A9140", VA = "0x1869AA940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? EHKNLACLMIN;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<MOOMEEOMEEK> EEEPIMKMFJO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task DELHKHOJGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x69A04B0", Offset = "0x699ECB0", VA = "0x1869A04B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69A0480", Offset = "0x699EC80", VA = "0x1869A0480")]
	public static bool DKEHMGONONG(this Task LEDCCMOCHJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x31D48F0", Offset = "0x31D30F0", VA = "0x1831D48F0")]
	public static Task<T> PPBIEGGJILJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x69A0220", Offset = "0x699EA20", VA = "0x1869A0220")]
	public static Task DGDBDGDCMFM(this Task LEDCCMOCHJB, CancellationToken EOCJCEFCOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x31D26D0", Offset = "0x31D0ED0", VA = "0x1831D26D0")]
	public static Task<TResult> DGDBDGDCMFM<TResult>(this Task<TResult> LEDCCMOCHJB, CancellationToken EOCJCEFCOOA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x31D3320", Offset = "0x31D1B20", VA = "0x1831D3320")]
	public static TaskCompletionSource<TResult> DGDBDGDCMFM<TResult>(this TaskCompletionSource<TResult> HGLIGDFKLOI, CancellationToken EOCJCEFCOOA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x69A0010", Offset = "0x699E810", VA = "0x1869A0010")]
	public static IDisposable? CNBPAIANHOL(CancellationToken GEGECJBKLOD, CancellationToken GNKNMDDAMLI, [Out] CancellationToken GEMJIHFAENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x69A1770", Offset = "0x699FF70", VA = "0x1869A1770")]
	[AsyncStateMachine(typeof(HCDJKNFJCPB))]
	public static void MGBMNGIKHIE(this Task DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x69A1570", Offset = "0x699FD70", VA = "0x1869A1570")]
	[AsyncStateMachine(typeof(PCLKGNDBKIH))]
	public static void LDPJFKGEGBN(this Task DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x31D4560", Offset = "0x31D2D60", VA = "0x1831D4560")]
	[AsyncStateMachine(typeof(HNGDDGNDHDL<>))]
	public static Task NFCIABCDKBK<TException>(this Task DOGPFNGIKMO) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x31D3C80", Offset = "0x31D2480", VA = "0x1831D3C80")]
	[AsyncStateMachine(typeof(EMDLOLJAPOG<>))]
	public static Task<T> GPPMDMNMLEA<T>(this Task<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x69A0C30", Offset = "0x699F430", VA = "0x1869A0C30")]
	[AsyncStateMachine(typeof(KDACLECGBDA))]
	public static Task<TaskStatus> IMFCMFNPHEL(this Task HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x31D3E60", Offset = "0x31D2660", VA = "0x1831D3E60")]
	public static (Task<T?>?, Action<T?>?) ICEAADFCAAC<T>([Optional] CancellationToken MPLGBOFHPLM)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31D41D0", Offset = "0x31D29D0", VA = "0x1831D41D0")]
	[AsyncStateMachine(typeof(DADCMIFLDIB<, >))]
	public static Task<List<TResult>> JPAKAKJPOFG<TResult, TInput>(this Task<List<TInput>> LEDCCMOCHJB, PPPJPCNIOAH<TInput, TResult> CLNKHJIOFCD) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x69A1310", Offset = "0x699FB10", VA = "0x1869A1310")]
	[AsyncStateMachine(typeof(FMKFLAGOPLC))]
	public static Task JMDDHDGDLBL(Task DOGPFNGIKMO, CancellationToken LJPECIOGMKH, Func<CancellationToken, Task> IOBKFGPBIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x69A1440", Offset = "0x699FC40", VA = "0x1869A1440")]
	[AsyncStateMachine(typeof(CBFHNMOFCDE))]
	public static Task KBJCNJFBALI(Func<CancellationToken, Task> LDEAEONJEHG, TimeSpan CENAAPAKFCO, [Optional] CancellationToken LJPECIOGMKH, [Optional] Action<OperationCanceledException>? OEOENKDGJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x31D42E0", Offset = "0x31D2AE0", VA = "0x1831D42E0")]
	[AsyncStateMachine(typeof(JDPJONECFLH<>))]
	public static Task<T> KBJCNJFBALI<T>(Func<CancellationToken, Task<T>> LDEAEONJEHG, TimeSpan CENAAPAKFCO, [Optional] CancellationToken LJPECIOGMKH, [Optional] Func<OperationCanceledException, T>? OEOENKDGJGG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x31D06E0", Offset = "0x31CEEE0", VA = "0x1831D06E0")]
	[AsyncStateMachine(typeof(MGEKIHOFIOD<>))]
	public static Task<IEnumerable<Task<T>>> BLJHPKBDAFC<T>(IEnumerable<Task<T>> JIHPMMHAMDA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x31D4630", Offset = "0x31D2E30", VA = "0x1831D4630")]
	[AsyncStateMachine(typeof(IIMJAPPDEFI<, , , >))]
	public static Task<(T1, T2, T3, T4)> OLCPPCDFOHI<T1, T2, T3, T4>(Task<T1> ACICOHHKOIF, Task<T2> OBECMBEOEPP, Task<T3> KOLGJHCBILI, Task<T4> CEFHEIJHFNH) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x69A0840", Offset = "0x699F040", VA = "0x1869A0840")]
	[AsyncStateMachine(typeof(OAKBABMAFAE))]
	public static Task FFJPMGBLKGA(Func<bool> NGPBJNKHNBB, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x69A0930", Offset = "0x699F130", VA = "0x1869A0930")]
	[AsyncStateMachine(typeof(JAOIHJCDKKO))]
	public static Task FFJPMGBLKGA(Func<bool> NGPBJNKHNBB, TimeSpan DJBIPFMLONE, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69A11E0", Offset = "0x699F9E0", VA = "0x1869A11E0")]
	[AsyncStateMachine(typeof(CENOPPNEFEE))]
	public static Task JHDCIGGPJLO(Func<bool> NGPBJNKHNBB, TimeSpan CENAAPAKFCO, [Optional] CancellationToken MPLGBOFHPLM, [Optional] Action<OperationCanceledException>? OEOENKDGJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69A10A0", Offset = "0x699F8A0", VA = "0x1869A10A0")]
	[AsyncStateMachine(typeof(JFELNDJHIIE))]
	public static Task JHDCIGGPJLO(Func<bool> NGPBJNKHNBB, TimeSpan CENAAPAKFCO, TimeSpan DJBIPFMLONE, [Optional] CancellationToken MPLGBOFHPLM, [Optional] Action<OperationCanceledException>? OEOENKDGJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69A0520", Offset = "0x699ED20", VA = "0x1869A0520")]
	[AsyncStateMachine(typeof(PKMOGNNBOCO))]
	public static Task ELHKCFMPECG(Func<bool> NGPBJNKHNBB, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69A0610", Offset = "0x699EE10", VA = "0x1869A0610")]
	[AsyncStateMachine(typeof(GONAAKAJIPH))]
	public static Task ELHKCFMPECG(Func<bool> NGPBJNKHNBB, TimeSpan DJBIPFMLONE, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x699FEE0", Offset = "0x699E6E0", VA = "0x18699FEE0")]
	[AsyncStateMachine(typeof(MMAAOBGBJIJ))]
	public static Task BCEHOMNLAAA(Func<bool> NGPBJNKHNBB, TimeSpan CENAAPAKFCO, [Optional] CancellationToken MPLGBOFHPLM, [Optional] Action<OperationCanceledException>? OEOENKDGJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x699FDA0", Offset = "0x699E5A0", VA = "0x18699FDA0")]
	[AsyncStateMachine(typeof(MGBAKPLEICL))]
	public static Task BCEHOMNLAAA(Func<bool> NGPBJNKHNBB, TimeSpan CENAAPAKFCO, TimeSpan DJBIPFMLONE, [Optional] CancellationToken MPLGBOFHPLM, [Optional] Action<OperationCanceledException>? OEOENKDGJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69A0B40", Offset = "0x699F340", VA = "0x1869A0B40")]
	[AsyncStateMachine(typeof(IGHNAODIEIK))]
	[Obsolete]
	public static Task IJIFFLNPDEH(this Task LEDCCMOCHJB, Action PHINNLGDFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x31D40E0", Offset = "0x31D28E0", VA = "0x1831D40E0")]
	[Obsolete]
	[AsyncStateMachine(typeof(IFOCEDELGDA<>))]
	public static Task IJIFFLNPDEH<T>(this Task<T> LEDCCMOCHJB, Action<T> PHINNLGDFEF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x69A0A90", Offset = "0x699F290", VA = "0x1869A0A90")]
	private static void HMIGIHIKALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x69A0D20", Offset = "0x699F520", VA = "0x1869A0D20")]
	public static bool IOIDBKOBJDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x699FC10", Offset = "0x699E410", VA = "0x18699FC10")]
	private static void AKHAPDEOPKI(SynchronizationContext JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69A0720", Offset = "0x699EF20", VA = "0x1869A0720")]
	private static void FEGLAODKLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x69A0150", Offset = "0x699E950", VA = "0x1869A0150")]
	public static void DEFMMJIJLNO([Optional] string? JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x69A1620", Offset = "0x699FE20", VA = "0x1869A1620")]
	public static void LLJBLLCGBIO([Optional] string? JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x699FBC0", Offset = "0x699E3C0", VA = "0x18699FBC0")]
	public static DADMFKKHJKH AAMCCOIDIFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x69A0A40", Offset = "0x699F240", VA = "0x1869A0A40")]
	public static DADMFKKHJKH GKAAIBNCBHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69A16A0", Offset = "0x699FEA0", VA = "0x1869A16A0")]
	[AsyncStateMachine(typeof(PLIDJKKMLBO))]
	public static Task MDBIKAAAFGG(Func<Task> GPJOKKOGGOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class OJAAPNLEIHM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
	public OJAAPNLEIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class EJBNPANDMNH : FFIMJELAHLM
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly FFIMJELAHLM MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime ODFPNJKMLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x69A36B0", Offset = "0x69A1EB0", VA = "0x1869A36B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset IMOCEOFPIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x69A3650", Offset = "0x69A1E50", VA = "0x1869A3650", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public EJBNPANDMNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface FFIMJELAHLM
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime ODFPNJKMLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset IMOCEOFPIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class ENMANPBNEMI
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long MGPIKIMEFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x69A3770", Offset = "0x69A1F70", VA = "0x1869A3770")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long KEMEJOBKBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69A39F0", Offset = "0x69A21F0", VA = "0x1869A39F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double LNOBOJPNNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x69A3810", Offset = "0x69A2010", VA = "0x1869A3810")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double DLNDCPHKOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x69A37C0", Offset = "0x69A1FC0", VA = "0x1869A37C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double LJCIADPBJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x69A39A0", Offset = "0x69A21A0", VA = "0x1869A39A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double KPAPIBGLBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69A3A40", Offset = "0x69A2240", VA = "0x1869A3A40")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x69A3C40", Offset = "0x69A2440", VA = "0x1869A3C40")]
	public static double OKNPGKGEMMB(long KPOHNGMKBNL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x69A3B20", Offset = "0x69A2320", VA = "0x1869A3B20")]
	public static double NKGCEGKOPFP(long KPOHNGMKBNL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x69A3A90", Offset = "0x69A2290", VA = "0x1869A3A90")]
	public static double MFAMJPJPDIM(double EJCNBMEMBLN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x69A3BB0", Offset = "0x69A23B0", VA = "0x1869A3BB0")]
	public static long OEIHNMCLLAM(long IOCCJIJEELD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x69A3990", Offset = "0x69A2190", VA = "0x1869A3990")]
	public static long HJHOALHJOIG(long DPPIBHJFLFA, long HHBDNCNCDOG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x69A38C0", Offset = "0x69A20C0", VA = "0x1869A38C0")]
	public static double HFMNCNMLOCD(long DPPIBHJFLFA, long HHBDNCNCDOG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x69A3860", Offset = "0x69A2060", VA = "0x1869A3860")]
	public static double GONLFMOBKHF(long DPPIBHJFLFA, long HHBDNCNCDOG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class FPCFALMJIPC : FICPEACAEJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan BBFDEPMPLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan CENAAPAKFCO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan JKCDDHGAGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x69A4930", Offset = "0x69A3130", VA = "0x1869A4930", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? CCNMEKNMGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8518F0", VA = "0x1808530F0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x69A4C30", Offset = "0x69A3430", VA = "0x1869A4C30")]
	[Preserve]
	public FPCFALMJIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x69A4CA0", Offset = "0x69A34A0", VA = "0x1869A4CA0")]
	public FPCFALMJIPC(TimeSpan CENAAPAKFCO, [Optional] Action? MFDINNHJEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x69A4B00", Offset = "0x69A3300", VA = "0x1869A4B00", Slot = "7")]
	public void PGKLFDNLGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x69A4A90", Offset = "0x69A3290", VA = "0x1869A4A90", Slot = "8")]
	public void FLCONFGBIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x69A4B90", Offset = "0x69A3390", VA = "0x1869A4B90", Slot = "9")]
	public void PKNIGDBJONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x92AEA0", Offset = "0x9296A0", VA = "0x18092AEA0")]
	private void OHBPHJNGNIE(object LMDEKGEENAI, ElapsedEventArgs HOCPMOOGMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x69A47F0", Offset = "0x69A2FF0", VA = "0x1869A47F0")]
	private static void BCEJLHOEINP(TimeSpan MPGLAMNCCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x69A4890", Offset = "0x69A3090", VA = "0x1869A4890", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class EGHHEKDFLLK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? LAHMNFJBNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string PGAAPEIPKAC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1D1A0A0", Offset = "0x1D188A0", VA = "0x181D1A0A0")]
	public EGHHEKDFLLK(string OLBMKMHMAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3D20ED0", Offset = "0x3D1F6D0", VA = "0x183D20ED0")]
	public EGHHEKDFLLK(string LCFMJNPOPEB, string OLBMKMHMAID)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct NKFCAEJKJCA : IEquatable<NKFCAEJKJCA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint KFEOGKOHLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int JCFDBOLHOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float OMJICHDDBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort OBPJGKGLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort NNKPBNHJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short EGGMAHBEEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short BEPECNJEBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char MBOCOACIMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char NLOLHPJHFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte DCOJHKKMBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte ODOACOPLEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte GEBJGKDCDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte FMMKHICMGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool FJINPKEMECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool DLMIJMMOBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool KAKENJBPDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool ABEHKBPCHBP;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0xE11F10", Offset = "0xE10710", VA = "0x180E11F10")]
	public static NKFCAEJKJCA MLCLBCBPDFF(uint JPBMNIJNCFD)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xE11F10", Offset = "0xE10710", VA = "0x180E11F10")]
	public static NKFCAEJKJCA BALFBEIGGAI(int JKCDGJHMGDA)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x69A8FD0", Offset = "0x69A77D0", VA = "0x1869A8FD0")]
	public static NKFCAEJKJCA IJLFLAEHPKJ(float BAGIEELOHCG)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x69A8FE0", Offset = "0x69A77E0", VA = "0x1869A8FE0")]
	public static NKFCAEJKJCA MKPHOILOOAP(byte NNFFFCMAOOO, byte CJPILJDAAKA, byte JDFODJOBGAH, byte FNCPHGEMHJC)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x69A8FE0", Offset = "0x69A77E0", VA = "0x1869A8FE0")]
	public static NKFCAEJKJCA JABOIDEKDDB(bool BOODJPOAKLN, bool OBGMELJJPGM, bool AHEGKJGEJMD, bool LNENOHGHLEI)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x69A8FE0", Offset = "0x69A77E0", VA = "0x1869A8FE0")]
	public static NKFCAEJKJCA PLBMPEGELPA(byte FKIIBHALLMG, byte BJEPAFFOBKI, byte LOELFLGPEAL, byte NBENBHPBOLL)
	{
		return default(NKFCAEJKJCA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1A7E560", Offset = "0x1A7CD60", VA = "0x181A7E560")]
	public static bool KBKLEFBHIDJ(NKFCAEJKJCA DIAAOCPNHKC, NKFCAEJKJCA LLLBDLGIMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9E8AC0", Offset = "0x9E72C0", VA = "0x1809E8AC0", Slot = "4")]
	public bool Equals(NKFCAEJKJCA OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x69A8F40", Offset = "0x69A7740", VA = "0x1869A8F40", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xAADF70", Offset = "0xAAC770", VA = "0x180AADF70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x69A9000", Offset = "0x69A7800", VA = "0x1869A9000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct MBGHEHEEKEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong HPIOHMMHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long BFNJDELIHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double AJEGIDHNBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint FNLCBAEAFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint BCOFBKDPBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int FEPKIJDGCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int BFONNHFOKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float CMOJFBJGIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float GPEBJGNBBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort OBPJGKGLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort NNKPBNHJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort NMAFIALKCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort MINELLCJGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short EGGMAHBEEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short BEPECNJEBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short CGLJHFJDLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short OPOPBNOKIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char MBOCOACIMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char NLOLHPJHFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char GEDLHPJFLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char GHEECJJAKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte DCOJHKKMBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte ODOACOPLEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte GEBJGKDCDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte FMMKHICMGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte OBKPACIPKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte NIHFHHNNHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte KDJCGFKJDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte FHKOPNBDKMB;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x69A87E0", Offset = "0x69A6FE0", VA = "0x1869A87E0")]
	public static MBGHEHEEKEE FJAAFKPDAIA(byte NNFFFCMAOOO, byte CJPILJDAAKA, byte JDFODJOBGAH, byte FNCPHGEMHJC, byte IFJDGMAHJFI, byte CDOCONCFBIF, byte NEINBPKFEDN, byte GIJFMINKCHI)
	{
		return default(MBGHEHEEKEE);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct GMFDEBELDHP : IEquatable<GMFDEBELDHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte JFKOAIMBDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool MLLEAOMDEPL;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x257D7B0", Offset = "0x257BFB0", VA = "0x18257D7B0")]
	public static GMFDEBELDHP MKPHOILOOAP(byte DEBGINHADJB)
	{
		return default(GMFDEBELDHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x257D7B0", Offset = "0x257BFB0", VA = "0x18257D7B0")]
	public static GMFDEBELDHP JABOIDEKDDB(bool AKBADEMAGHC)
	{
		return default(GMFDEBELDHP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x69A4F90", Offset = "0x69A3790", VA = "0x1869A4F90")]
	public static bool KBKLEFBHIDJ(GMFDEBELDHP DIAAOCPNHKC, GMFDEBELDHP LLLBDLGIMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B0A0", Offset = "0x5B398A0", VA = "0x185B3B0A0", Slot = "4")]
	public bool Equals(GMFDEBELDHP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69A4EF0", Offset = "0x69A36F0", VA = "0x1869A4EF0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x69A4F80", Offset = "0x69A3780", VA = "0x1869A4F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x69A4FA0", Offset = "0x69A37A0", VA = "0x1869A4FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GDOPMIHLCIC<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T MECEFIOIOMA;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4980", Offset = "0x3CA3180", VA = "0x183CA4980")]
	public GDOPMIHLCIC(T ILGFDCILGHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class HFIKMDBEEPP
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FE30", Offset = "0x2B5E630", VA = "0x182B5FE30")]
	public static IEnumerable<T> EIEOLPGNGHI<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460")]
	public static T[] IALBEDLLFII<T>(params T[] LLHCNBBFPGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460")]
	public static IEnumerable<T> KJFFDCEDHMA<T>(params T[] LLHCNBBFPGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FF50", Offset = "0x2B5E750", VA = "0x182B5FF50")]
	public static HashSet<T> FGFPKMPACEG<T>(params T[] LLHCNBBFPGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FE60", Offset = "0x2B5E660", VA = "0x182B5FE60")]
	public static KeyValuePair<TKey, TValue> FDDBKHDAAHJ<TKey, TValue>([In] TKey NDDCLPHCEEO, [In] TValue JMDCGOKJIDA) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FF50", Offset = "0x2B5E750", VA = "0x182B5FF50")]
	public static List<T> NACGOHFLEMH<T>(IEnumerable<T> FDPJMKODKPJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.All)]
public sealed class HFDAAELKEAM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string DDCDFACIFND;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C1C0", VA = "0x18087D9C0")]
	public HFDAAELKEAM(string GIEIMDLAKLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate object FKEDAHKJJLN<T>([In] T FJCOFFFFCFE);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object JLNEBPBAHKH<T>(T FJCOFFFFCFE);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[OOKFMGIPCHO]
public delegate string BAEHDBHNCBE(string GMHAEBALLKB, string? NNJFFKDDDDA, bool GFPCLPEDKGP);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[OOKFMGIPCHO]
public delegate void KGLLJHJHDMK(string JNNDBFGKHHD);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[OOKFMGIPCHO]
public delegate void LOPPIOKENPJ(Exception PBAHBFAICPK);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate object IBCFNKHBFJP();
[Cpp2IlInjected.Token(Token = "0x200005D")]
[OOKFMGIPCHO]
public delegate bool MOGKGCPKBNO();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[OOKFMGIPCHO]
public delegate string LENMAMIDEIM(object MEAFIMADMKA);
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.Enum)]
public class OFOCAEGDGHB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
	public OFOCAEGDGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class AIMFBOMFIGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct DKIJFBMJCGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x69A24F0", Offset = "0x69A0CF0", VA = "0x1869A24F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x69A2DE0", Offset = "0x69A15E0", VA = "0x1869A2DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly TimerCallback EINDPMDGMAP;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Action<object?> HKNAMNBKDLN;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x699F710", Offset = "0x699DF10", VA = "0x18699F710")]
	public static Task<bool> KNJLDFJHOPG(int PEEDGFAKDJC, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x699F5E0", Offset = "0x699DDE0", VA = "0x18699F5E0")]
	[AsyncStateMachine(typeof(DKIJFBMJCGC))]
	private static Task<bool> JCMOKPOFMCL(int PEEDGFAKDJC, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x699F550", Offset = "0x699DD50", VA = "0x18699F550")]
	private static void GKGGJEHGCJO(object? DMDDBNBIFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x699FA20", Offset = "0x699E220", VA = "0x18699FA20")]
	private static void OBEOHDHIKJO(object? DMDDBNBIFMI)
	{
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
