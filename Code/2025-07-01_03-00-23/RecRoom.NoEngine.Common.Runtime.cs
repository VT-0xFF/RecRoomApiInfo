using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x810DF80", Offset = "0x810C580", VA = "0x18810DF80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LLIGJFKICMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x810D320", Offset = "0x810B920", VA = "0x18810D320")]
	public static string IEOBNAPBHHA(this Encoding GPFMLCIIHJI, [In] ReadOnlySequence<byte> IHNKIKDOAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAB60", Offset = "0x3BF9160", VA = "0x183BFAB60")]
	private static void JJEEGEGGDKI<T>(this ReadOnlySequence<T> JMCJBHCJINO, [Out] ReadOnlySpan<T> PIBLFPOLLKF, [Out] SequencePosition HBGAGONLKKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class LFIKDILMFEA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x810CB90", Offset = "0x810B190", VA = "0x18810CB90")]
	public LFIKDILMFEA(bool GOOIKOLILOK, string APBLKFIAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x810CC60", Offset = "0x810B260", VA = "0x18810CC60")]
	public LFIKDILMFEA(bool GOOIKOLILOK, params string[] AKNAALIKIFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DJEGPEKONJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PNGBPIGLBDM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ALLHBMGNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIJNCKHPMIL(string BLIBAMJKLIA, double KKGBKLFKCPO, [Optional] string? JJEHJBKGDLL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LLOEPPCADCN : LMJFBGECKIA, JJABFMBOGCP, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int ABKKABJGBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> INEJPGALGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double LPAMMAPPJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double CMGDLKAFPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double JGIEOMIDOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int JPKKDIGDJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double PPCNGPFKCIL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DEIHAKNKEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double ELLCNCIAFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x810D9E0", Offset = "0x810BFE0", VA = "0x18810D9E0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double PFBAIIHPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x56A6F00", Offset = "0x56A5500", VA = "0x1856A6F00", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double LHEIPICJAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28F5B30", Offset = "0x28F4130", VA = "0x1828F5B30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x810DBE0", Offset = "0x810C1E0", VA = "0x18810DBE0")]
	public LLOEPPCADCN(int NPHLLCEDBLP, double PPCNGPFKCIL = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x810DA40", Offset = "0x810C040", VA = "0x18810DA40", Slot = "7")]
	public void LLMHLGKKCOF(double FADBOFNILPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x810DB70", Offset = "0x810C170", VA = "0x18810DB70", Slot = "8")]
	public void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x810D8E0", Offset = "0x810BEE0", VA = "0x18810D8E0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ABNCGNFDGKD : LMJFBGECKIA, JJABFMBOGCP, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long FOAMCIPOLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double CGEAFHEPCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double CNAMBMCMKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double LNCJENGECJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double NIBCIBJKAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double LPAMMAPPJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double CMGDLKAFPEE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double PFBAIIHPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x73318C0", Offset = "0x732FEC0", VA = "0x1873318C0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double LHEIPICJAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7331900", Offset = "0x732FF00", VA = "0x187331900", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double AHMEFCAICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7331470", Offset = "0x732FA70", VA = "0x187331470")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double ELLCNCIAFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x30680B0", Offset = "0x30666B0", VA = "0x1830680B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8102CD0", Offset = "0x81012D0", VA = "0x188102CD0", Slot = "10")]
	public virtual void LLMHLGKKCOF(double FADBOFNILPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8102DF0", Offset = "0x81013F0", VA = "0x188102DF0", Slot = "11")]
	public virtual void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8102C60", Offset = "0x8101260", VA = "0x188102C60", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8102E30", Offset = "0x8101430", VA = "0x188102E30")]
	public ABNCGNFDGKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ILFNOHCKKOC : ABNCGNFDGKD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double APPEKFNDJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x73318F0", Offset = "0x732FEF0", VA = "0x1873318F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x73318E0", Offset = "0x732FEE0", VA = "0x1873318E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8109720", Offset = "0x8107D20", VA = "0x188109720", Slot = "10")]
	public override void LLMHLGKKCOF(double FADBOFNILPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8109850", Offset = "0x8107E50", VA = "0x188109850", Slot = "11")]
	public override void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8102E30", Offset = "0x8101430", VA = "0x188102E30")]
	public ILFNOHCKKOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LMJFBGECKIA : JJABFMBOGCP, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double ELLCNCIAFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double PFBAIIHPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double LHEIPICJAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DIOFOFPBDIA : JJABFMBOGCP, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double DGNFCAJGCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double GKKFENANEOP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8105230", Offset = "0x8103830", VA = "0x188105230")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D86380", Offset = "0x6D84980", VA = "0x186D86380", Slot = "4")]
	public void LLMHLGKKCOF(double FADBOFNILPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8105240", Offset = "0x8103840", VA = "0x188105240", Slot = "5")]
	public void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81051E0", Offset = "0x81037E0", VA = "0x1881051E0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DIOFOFPBDIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JJABFMBOGCP : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLMHLGKKCOF(double FADBOFNILPL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGCNIAHBIMM();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KMBKDFJLLIC : JJABFMBOGCP, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double KKGBKLFKCPO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4806990", Offset = "0x4804F90", VA = "0x184806990")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x566D100", Offset = "0x566B700", VA = "0x18566D100", Slot = "4")]
	public void LLMHLGKKCOF(double FADBOFNILPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x810CAB0", Offset = "0x810B0B0", VA = "0x18810CAB0", Slot = "5")]
	public void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x810CA60", Offset = "0x810B060", VA = "0x18810CA60", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KMBKDFJLLIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CDEGCBFGJIL<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> CIGKOLMMCMB(CancellationToken KMHHNOGHBLL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EEFCGDDCIBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CDEGCBFGJIL<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CIGKOLMMCMB taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x475F1B0", Offset = "0x475D7B0", VA = "0x18475F1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4760200", Offset = "0x475E800", VA = "0x184760200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource PCGMGJPANKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? OGJPPIDOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? GEDOANDDKJI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6795C60", Offset = "0x6794260", VA = "0x186795C60")]
	[AsyncStateMachine(typeof(CDEGCBFGJIL<>.EEFCGDDCIBG))]
	public Task<TResult> LBAIMDNIJFD(CIGKOLMMCMB KBCGBKALINO, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6795BF0", Offset = "0x67941F0", VA = "0x186795BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6795DA0", Offset = "0x67943A0", VA = "0x186795DA0")]
	public CDEGCBFGJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class FFHFCIJPDAF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> EBLDEAKPIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T IBMJNNAJGNM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4C04FE0", Offset = "0x4C035E0", VA = "0x184C04FE0")]
	public FFHFCIJPDAF([In] T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4C04170", Offset = "0x4C02770", VA = "0x184C04170", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C046E0", Offset = "0x4C02CE0", VA = "0x184C046E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4C04BF0", Offset = "0x4C031F0", VA = "0x184C04BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CMBMDDLLKEC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39504A0", Offset = "0x394EAA0", VA = "0x1839504A0")]
	public static FFHFCIJPDAF<T> BFOPDLPDKBM<T>([In] T KKGBKLFKCPO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ILAJFGGKOED
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x81096F0", Offset = "0x8107CF0", VA = "0x1881096F0")]
	public static void JGCDIHHHPFE(this CancellationTokenSource PCGMGJPANKK, bool AECEMFPPDCB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class BHLHPPHNLNG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
	public BHLHPPHNLNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class OAODFBDCNNK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
	public OAODFBDCNNK(string DONHPFBENMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NFJCBEKJDBH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C93B40", Offset = "0x3C92140", VA = "0x183C93B40")]
	public static GBFLIFHPBJG EMFKKAEDHOO<T>()
	{
		return default(GBFLIFHPBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x810DD00", Offset = "0x810C300", VA = "0x18810DD00")]
	public static GBFLIFHPBJG DNDCDIMHKDA([CallerMemberName] string IEDAJGLJHNI = "")
	{
		return default(GBFLIFHPBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C93D70", Offset = "0x3C92370", VA = "0x183C93D70")]
	public static GBFLIFHPBJG OOAOLOMKPHG<T>([CallerMemberName] string IEDAJGLJHNI = "") where T : notnull
	{
		return default(GBFLIFHPBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C93BC0", Offset = "0x3C921C0", VA = "0x183C93BC0")]
	public static GBFLIFHPBJG EMFKKAEDHOO<T>(this T HKKDKDDKEBF) where T : notnull
	{
		return default(GBFLIFHPBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C939F0", Offset = "0x3C91FF0", VA = "0x183C939F0")]
	public static GBFLIFHPBJG DNDCDIMHKDA<T>(this T HKKDKDDKEBF, [CallerMemberName] string IEDAJGLJHNI = "") where T : notnull
	{
		return default(GBFLIFHPBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C93E00", Offset = "0x3C92400", VA = "0x183C93E00")]
	public static GBFLIFHPBJG OOAOLOMKPHG<T>(this T PIKMBNLEPPK, [CallerMemberName] string IEDAJGLJHNI = "") where T : notnull
	{
		return default(GBFLIFHPBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x810DE00", Offset = "0x810C400", VA = "0x18810DE00")]
	public static GBFLIFHPBJG OOAOLOMKPHG(string NCGHDLMONKB, [CallerMemberName] string IEDAJGLJHNI = "")
	{
		return default(GBFLIFHPBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x810DD60", Offset = "0x810C360", VA = "0x18810DD60")]
	public static string HLNCLJEDJHL(this object PIKMBNLEPPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool FBNFLCDMBBH();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BHLHPPHNLNG]
public delegate long HFIJFFPEBPL();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class CGJPMJJEDKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly CGJPMJJEDKL FNIBPMLJKFE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CGJPMJJEDKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ODOHOPOGEDO
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static BNFDKBIKBNG PPKFNNBBIGL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static BNFDKBIKBNG IICDPOBEDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x810E300", Offset = "0x810C900", VA = "0x18810E300")]
		get
		{
			return default(BNFDKBIKBNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static IMEPHGPNJIJ DDPFAFPIEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x810E820", Offset = "0x810CE20", VA = "0x18810E820")]
		get
		{
			return default(IMEPHGPNJIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static HANKJMMHHCG COLDKNGCAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x810E210", Offset = "0x810C810", VA = "0x18810E210")]
		get
		{
			return default(HANKJMMHHCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool PFGGNADNECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x810E140", Offset = "0x810C740", VA = "0x18810E140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x810E3D0", Offset = "0x810C9D0", VA = "0x18810E3D0")]
	public static void KMAGHGFMMGN([In] BNFDKBIKBNG PFFJDCJOBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x810E6B0", Offset = "0x810CCB0", VA = "0x18810E6B0")]
	public static void OAAFJAHOMDO(string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x810E5E0", Offset = "0x810CBE0", VA = "0x18810E5E0")]
	public static void MLBKDBCFNPO(string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9510", Offset = "0x3CE7B10", VA = "0x183CE9510")]
	public static void MLBKDBCFNPO<T>(T DFPJDDAMCPC, MFKCOECNGJN<T> CJIMOMNMAGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x810E780", Offset = "0x810CD80", VA = "0x18810E780")]
	public static void PHLLJOHELBE(Exception CGONOPBDIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x810E1B0", Offset = "0x810C7B0", VA = "0x18810E1B0")]
	public static void DPKFCONPDDG(string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x810E580", Offset = "0x810CB80", VA = "0x18810E580")]
	public static void KNGLMOIPGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x810E350", Offset = "0x810C950", VA = "0x18810E350")]
	public static string HLNCLJEDJHL(object ODCICEDDLMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x810E000", Offset = "0x810C600", VA = "0x18810E000")]
	public static long AFOFALONPGH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x810E260", Offset = "0x810C860", VA = "0x18810E260")]
	public static bool ENAHLLCECKK(bool KCEOCGICBLB, string CJIMOMNMAGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x810E070", Offset = "0x810C670", VA = "0x18810E070")]
	public static double BLDCAPEHLBL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct BNFDKBIKBNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IMEPHGPNJIJ DDPFAFPIEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly HANKJMMHHCG COLDKNGCAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly MEHHFCEHOHO BNBDNPDGLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly HFIJFFPEBPL GEPEMIALGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly NLOBAHFNJCB LIBJDKMPAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly FBNFLCDMBBH MEKAAKHDKDC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MEHHFCEHOHO NMGMCPBAMHF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly HFIJFFPEBPL CNEOEHPMCOE;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly NLOBAHFNJCB PJICOLCFILL;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly FBNFLCDMBBH IFOCKHMNLPL;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly BNFDKBIKBNG PBMJKPJDLCC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NGPOKKIJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8103BB0", Offset = "0x81021B0", VA = "0x188103BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8104480", Offset = "0x8102A80", VA = "0x188104480")]
	public BNFDKBIKBNG([In] IMEPHGPNJIJ AEDIKBCEPGE, [In] HANKJMMHHCG GKFPEEENLDL, MEHHFCEHOHO FJAFGHEMAFO, HFIJFFPEBPL NPDMCPLGJKM, NLOBAHFNJCB IFPBNGJNKGL, FBNFLCDMBBH FNCAOKLPDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8103D50", Offset = "0x8102350", VA = "0x188103D50")]
	private static string MPJPPIMEPEB(object ODCICEDDLMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00")]
	private static long BBPHAFNPCDF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	private static string HAEJONBHOEB(string IKLHNGEBLBJ, string? GDFBBGHAAKG, bool PNBFFNGEODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
	private static bool KCPDGPJMDHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8103AA0", Offset = "0x81020A0", VA = "0x188103AA0")]
	private static BNFDKBIKBNG ILPNPGAONNP()
	{
		return default(BNFDKBIKBNG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface POBBFFFDEHJ
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBFFHAODLLB MJAODGLODJM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CBFFHAODLLB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LKLEAPMLHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFJAMJHMIHF();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ACFHDHCDOOM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CMCENAAFBJJ([In] T HOPHFOOKMCC);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void DLBHMKBAJKA<T>([In] T DFPJDDAMCPC);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct HIFKEOIAIOH<T> : IEquatable<HIFKEOIAIOH<T>>, ACFHDHCDOOM<HIFKEOIAIOH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T IBMJNNAJGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int BPENJJIEFOH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x29A6EB0", Offset = "0x29A54B0", VA = "0x1829A6EB0")]
	public HIFKEOIAIOH([In] T KKGBKLFKCPO, int KHMHPNKMLMD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA5A0", Offset = "0x4DF8BA0", VA = "0x184DFA5A0")]
	public static bool JKIBMILPCGE([In] HIFKEOIAIOH<T> DBDIOGELIIH, [In] HIFKEOIAIOH<T> LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9300", Offset = "0x4DF7900", VA = "0x184DF9300", Slot = "4")]
	public bool Equals(HIFKEOIAIOH<T> HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9380", Offset = "0x4DF7980", VA = "0x184DF9380", Slot = "0")]
	public override bool Equals(object HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9270", Offset = "0x4DF7870", VA = "0x184DF9270")]
	public bool CMCENAAFBJJ([In] HIFKEOIAIOH<T> HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA020", Offset = "0x4DF8620", VA = "0x184DFA020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4DFB3F0", Offset = "0x4DF99F0", VA = "0x184DFB3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4DF99D0", Offset = "0x4DF7FD0", VA = "0x184DF99D0")]
	public void GMJJAGOJIKC([Out] T KKGBKLFKCPO, [Out] int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4DFAA80", Offset = "0x4DF9080", VA = "0x184DFAA80")]
	public (T, int) MOAGODIFJPB()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9220", Offset = "0x4DF7820", VA = "0x184DF9220", Slot = "5")]
	private bool BAFMLIIEGFD([In] HIFKEOIAIOH<T> HOPHFOOKMCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NHHIJGAFGBI
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F2B0", Offset = "0x3C9D8B0", VA = "0x183C9F2B0")]
	public static HIFKEOIAIOH<T> BFOPDLPDKBM<T>([In] T KKGBKLFKCPO, int KHMHPNKMLMD) where T : notnull
	{
		return default(HIFKEOIAIOH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class HGNFILBIACE
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B60700", Offset = "0x3B5ED00", VA = "0x183B60700")]
	public static bool CMCENAAFBJJ<T, U>([In] T PIKMBNLEPPK, [In] U ODCICEDDLMB) where T : notnull, ACFHDHCDOOM<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult KOFNCBGMODC<T, out TResult>([In] T DFPJDDAMCPC);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KJKMJJJNGAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan EBPLBEFCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? AAGMMCKIJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BNJPFDALMCI();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHLLBBDMJJJ();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ELHJEAOCKOJ();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct IMEPHGPNJIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly BKBPBCKLPFJ JMIBMHBKFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly LMIJGKDMCOP KGMJDJDDNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly BKBPBCKLPFJ NMAALMHKPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly LMIJGKDMCOP FEJPPLGIGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly BKBPBCKLPFJ GMEHIMDAGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly LMIJGKDMCOP DKHKMKJDLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly AKGDEFKMOIC IMEIKBIKIFL;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly BKBPBCKLPFJ IBNEBDHCJIF;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly LMIJGKDMCOP HFIEODEKEAO;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly BKBPBCKLPFJ GBONHNIHBEG;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly LMIJGKDMCOP CJMOGEOJCGF;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly BKBPBCKLPFJ KJPHCEGBOCE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly LMIJGKDMCOP BBACILADOEH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly AKGDEFKMOIC AHPMDHCBOLI;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly IMEPHGPNJIJ PBMJKPJDLCC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly BKBPBCKLPFJ HILLAIEDJAG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool NGPOKKIJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8109B10", Offset = "0x8108110", VA = "0x188109B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xE31D30", Offset = "0xE30330", VA = "0x180E31D30")]
	public IMEPHGPNJIJ(BKBPBCKLPFJ NKIHBEKLEFL, LMIJGKDMCOP EKPEDDHCAPA, BKBPBCKLPFJ AEDGBEKOHPD, LMIJGKDMCOP PFDHHHMNLOL, BKBPBCKLPFJ PGONCDCPBIO, LMIJGKDMCOP NJMGGGEBCAI, AKGDEFKMOIC FNGAIAJAIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
	private static bool PGFBJOAEHJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void GBPJMBHHFDL(string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
	private static bool NIOAOJJMECM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void MHCNICMBFEL(string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450")]
	private static bool BADHGGINGPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void HJGBFODPLBH(string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void LLDPNCAIMKM(Exception CGONOPBDIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x81099D0", Offset = "0x8107FD0", VA = "0x1881099D0")]
	private static IMEPHGPNJIJ ILPNPGAONNP()
	{
		return default(IMEPHGPNJIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
	private static bool IJGJLJJMEGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8109E60", Offset = "0x8108460", VA = "0x188109E60")]
	public void OAAFJAHOMDO(object CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8109960", Offset = "0x8107F60", VA = "0x188109960")]
	public void GPFCFOHDADP(object CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8109D10", Offset = "0x8108310", VA = "0x188109D10")]
	public void MLBKDBCFNPO(object CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE3FAF0", Offset = "0xE3E0F0", VA = "0x180E3FAF0")]
	public void PHLLJOHELBE(Exception CGONOPBDIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8109D80", Offset = "0x8108380", VA = "0x188109D80")]
	public void MLBKDBCFNPO(FIODPKELMIN CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B83080", Offset = "0x3B81680", VA = "0x183B83080")]
	public void MLBKDBCFNPO<T>(T DFPJDDAMCPC, MFKCOECNGJN<T> CJIMOMNMAGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B83390", Offset = "0x3B81990", VA = "0x183B83390")]
	public void OAAFJAHOMDO<T>([In] T DFPJDDAMCPC, ECGCIBAOPFF<T> CJIMOMNMAGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B83150", Offset = "0x3B81750", VA = "0x183B83150")]
	public void MLBKDBCFNPO<T>([In] T DFPJDDAMCPC, ECGCIBAOPFF<T> CJIMOMNMAGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8109890", Offset = "0x8107E90", VA = "0x188109890")]
	public bool ENAHLLCECKK(bool KCEOCGICBLB, string CJIMOMNMAGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct GBFLIFHPBJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string IBMJNNAJGNM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xDE8A40", Offset = "0xDE7040", VA = "0x180DE8A40")]
	public GBFLIFHPBJG(string KKGBKLFKCPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
	public static string EIMKEBEILPD([In] GBFLIFHPBJG PIKMBNLEPPK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x135DC50", Offset = "0x135C250", VA = "0x18135DC50")]
	public static GBFLIFHPBJG EIMKEBEILPD(string HOPHFOOKMCC)
	{
		return default(GBFLIFHPBJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8107860", Offset = "0x8105E60", VA = "0x188107860")]
	public string DBLOAMCAFCJ(string BJIKALEHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x81078B0", Offset = "0x8105EB0", VA = "0x1881078B0")]
	public string GNAIOHBFIFE(object LDEHCLEKKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class KKKHBGDHDKB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
	public KKKHBGDHDKB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct DICNEKFFPEP : IEquatable<DICNEKFFPEP>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "4")]
	public bool Equals(DICNEKFFPEP HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8105150", Offset = "0x8103750", VA = "0x188105150", Slot = "0")]
	public override bool Equals(object HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x81051A0", Offset = "0x81037A0", VA = "0x1881051A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x81051B0", Offset = "0x81037B0", VA = "0x1881051B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CMBJJNOBAFP("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct ALKPLFJMODP<T> : IEquatable<ALKPLFJMODP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T IBMJNNAJGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool JGLJIDNKKNB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool HGCGHIILCMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4F904F0", Offset = "0x4F8EAF0", VA = "0x184F904F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F92880", Offset = "0x4F90E80", VA = "0x184F92880")]
	public ALKPLFJMODP([In] T KKGBKLFKCPO, bool APJGBNBBCIH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F91C20", Offset = "0x4F90220", VA = "0x184F91C20")]
	public static bool JKIBMILPCGE([In] ALKPLFJMODP<T> DBDIOGELIIH, [In] ALKPLFJMODP<T> LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F90520", Offset = "0x4F8EB20", VA = "0x184F90520", Slot = "4")]
	public bool Equals(ALKPLFJMODP<T> HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F90B40", Offset = "0x4F8F140", VA = "0x184F90B40", Slot = "0")]
	public override bool Equals(object? HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F91670", Offset = "0x4F8FC70", VA = "0x184F91670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4F92720", Offset = "0x4F90D20", VA = "0x184F92720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class JDBIGAGJBDF
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B9AF90", Offset = "0x3B99590", VA = "0x183B9AF90")]
	public static ALKPLFJMODP<T> IILOCBMCBDE<T>([In] T KKGBKLFKCPO) where T : notnull
	{
		return default(ALKPLFJMODP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B9ACA0", Offset = "0x3B992A0", VA = "0x183B9ACA0")]
	public static ALKPLFJMODP<T?> DHGFBGFOGDF<T>()
	{
		return default(ALKPLFJMODP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B9ADD0", Offset = "0x3B993D0", VA = "0x183B9ADD0")]
	public static bool EMOEFLGCEHP<T>([In] this ALKPLFJMODP<T> JEBNAIEFJCH, [Out][NotNullWhen(true)] T KKGBKLFKCPO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3B9AD60", Offset = "0x3B99360", VA = "0x183B9AD60")]
	public static bool EMOEFLGCEHP<T>([In] this ALKPLFJMODP<T> JEBNAIEFJCH, [Out][NotNullWhen(true)] T KKGBKLFKCPO, [Out] ALKPLFJMODP<T> MKEFFDKHNPI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3B9AE00", Offset = "0x3B99400", VA = "0x183B9AE00")]
	public static T? HIHONNLPEIP<T>([In] this ALKPLFJMODP<T> JEBNAIEFJCH, T? COMAGLLDBOM)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B9B020", Offset = "0x3B99620", VA = "0x183B9B020")]
	public static bool JKKBBJKIBEG<T>([In] this ALKPLFJMODP<T> JEBNAIEFJCH, T KKGBKLFKCPO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class DNFNDICOKNN
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x39A1C00", Offset = "0x39A0200", VA = "0x1839A1C00")]
	public static T JAHPELDDDJA<T>([In] this ALKPLFJMODP<T> JEBNAIEFJCH) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct HANKJMMHHCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr DPKFCONPDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr KNGLMOIPGBH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr NHDHBHEGGHJ;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr CEMCKIDOEHO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly HANKJMMHHCG PBMJKPJDLCC;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool NGPOKKIJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8108770", Offset = "0x8106D70", VA = "0x188108770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
	public HANKJMMHHCG(IntPtr OMFPADAOPMJ, IntPtr LBAOOLGDGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void NNANFLGJHLL(string IEDAJGLJHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void ICHLOEDLOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x81086E0", Offset = "0x8106CE0", VA = "0x1881086E0")]
	private static HANKJMMHHCG ILPNPGAONNP()
	{
		return default(HANKJMMHHCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct FGLPMMGJCCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr HBNLFIPGKCB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
	private FGLPMMGJCCI(IntPtr LBAOOLGDGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8107850", Offset = "0x8105E50", VA = "0x188107850")]
	public void DIGOPEEDGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8107770", Offset = "0x8105D70", VA = "0x188107770")]
	public static FGLPMMGJCCI BFOPDLPDKBM(string IEDAJGLJHNI)
	{
		return default(FGLPMMGJCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2981DD0", Offset = "0x29803D0", VA = "0x182981DD0")]
	public static FGLPMMGJCCI BFOPDLPDKBM([In] HANKJMMHHCG GKFPEEENLDL, string IEDAJGLJHNI)
	{
		return default(FGLPMMGJCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2981670", Offset = "0x297FC70", VA = "0x182981670")]
	public static FGLPMMGJCCI BFOPDLPDKBM([In] HANKJMMHHCG GKFPEEENLDL, Func<string> IEDAJGLJHNI)
	{
		return default(FGLPMMGJCCI);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class GJHONPACJCK : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? KIPPFFMALAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr GJLEAOCPOGI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool NMFHEKCPGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x81080B0", Offset = "0x81066B0", VA = "0x1881080B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8108510", Offset = "0x8106B10", VA = "0x188108510")]
	public static SHA256 MMBKOMPANAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8107F40", Offset = "0x8106540", VA = "0x188107F40")]
	private static extern int AMCDAEFOLHL();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8108040", Offset = "0x8106640", VA = "0x188108040")]
	private static extern IntPtr EBFDEHCAHKI();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8108590", Offset = "0x8106B90", VA = "0x188108590")]
	private static extern void OGBBKFIHGAF(IntPtr GJLEAOCPOGI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8108450", Offset = "0x8106A50", VA = "0x188108450")]
	private static extern void LOOEKOFMADD(IntPtr GJLEAOCPOGI, byte[] ACJFHCNBBBO, int MOBKDJHFHDL, int IDOMBDCDGEP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8108610", Offset = "0x8106C10", VA = "0x188108610")]
	private static extern void PBBAGKPFHGB(IntPtr GJLEAOCPOGI, byte[] PAALFBCEHOI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x81086B0", Offset = "0x8106CB0", VA = "0x1881086B0")]
	private GJHONPACJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x81081A0", Offset = "0x81067A0", VA = "0x1881081A0", Slot = "18")]
	protected override void HashCore(byte[] DDENONPPKCL, int OFBLIKDFGDK, int PCHGOKHLHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8108260", Offset = "0x8106860", VA = "0x188108260", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8108390", Offset = "0x8106990", VA = "0x188108390", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8107FB0", Offset = "0x81065B0", VA = "0x188107FB0", Slot = "13")]
	protected override void Dispose(bool DGAIMJLCBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KEKNKMIKBOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool PCGOOGBMHIN<in TInput, TResult>(TInput FCHACHIDAGA, [Out] TResult HPCDHGHHCOO);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class KDFLKLGPHFI : POBBFFFDEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class DLMIJJJOMEO : CBFFHAODLLB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly DLMIJJJOMEO FNIBPMLJKFE;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool LKLEAPMLHCO
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x8105250", Offset = "0x8103850", VA = "0x188105250", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x81052B0", Offset = "0x81038B0", VA = "0x1881052B0", Slot = "6")]
			public void OnCompleted(Action BFNBNGOBMJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
			public void OFJAMJHMIHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public DLMIJJJOMEO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly KDFLKLGPHFI FNIBPMLJKFE;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		private KDFLKLGPHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x810A610", Offset = "0x8108C10", VA = "0x18810A610", Slot = "4")]
		public CBFFHAODLLB MJAODGLODJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class LANKKBHGFPN : POBBFFFDEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class JOLDELBFFGO : CBFFHAODLLB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly JOLDELBFFGO FNIBPMLJKFE;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool LKLEAPMLHCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x810A520", Offset = "0x8108B20", VA = "0x18810A520", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x810A540", Offset = "0x8108B40", VA = "0x18810A540", Slot = "6")]
			public void OnCompleted(Action BFNBNGOBMJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
			public void OFJAMJHMIHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public JOLDELBFFGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly LANKKBHGFPN FNIBPMLJKFE;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		private LANKKBHGFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x810CAC0", Offset = "0x810B0C0", VA = "0x18810CAC0", Slot = "4")]
		public CBFFHAODLLB MJAODGLODJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class AIGLPICGLAO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AIGLPICGLAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4E26570", Offset = "0x4E24B70", VA = "0x184E26570")]
		internal void FLHEBBODPJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ANHNKPOMGMM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ANHNKPOMGMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4F96ED0", Offset = "0x4F954D0", VA = "0x184F96ED0")]
		internal void IENIHDLCIBG(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct OEBGHMPAKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x810E930", Offset = "0x810CF30", VA = "0x18810E930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct AKKEKAICFFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x81034B0", Offset = "0x8101AB0", VA = "0x1881034B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct CPGIBMPAHCB<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6888A20", Offset = "0x6887020", VA = "0x186888A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6888B90", Offset = "0x6887190", VA = "0x186888B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct NEAEFJAIHJF<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5687A40", Offset = "0x5686040", VA = "0x185687A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x56882B0", Offset = "0x56868B0", VA = "0x1856882B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct AIKAHDFOIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8102E60", Offset = "0x8101460", VA = "0x188102E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8103070", Offset = "0x8101670", VA = "0x188103070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class HMMBDKBJLFF<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HMMBDKBJLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4E26570", Offset = "0x4E24B70", VA = "0x184E26570")]
		internal void APBOEEFJKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4E265B0", Offset = "0x4E24BB0", VA = "0x184E265B0")]
		internal void BCCCJKBLPBE(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct OFBHCEADADA<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PCGOOGBMHIN<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x57BA1B0", Offset = "0x57B87B0", VA = "0x1857BA1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x57BA8A0", Offset = "0x57B8EA0", VA = "0x1857BA8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OIOGHFICOPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x810EDE0", Offset = "0x810D3E0", VA = "0x18810EDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x810F5E0", Offset = "0x810DBE0", VA = "0x18810F5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GGCJMANACCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8107990", Offset = "0x8105F90", VA = "0x188107990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8107EE0", Offset = "0x81064E0", VA = "0x188107EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct DMNMCKOCIBC<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6D29580", Offset = "0x6D27B80", VA = "0x186D29580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4C54C60", Offset = "0x4C53260", VA = "0x184C54C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class DPHAIIKHOID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<DICNEKFFPEP> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DPHAIIKHOID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8105490", Offset = "0x8103A90", VA = "0x188105490")]
		internal void FNNDMBKAJHB(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct PFCBKGMHDKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<IEnumerable<Task>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<Task> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Task[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x810F820", Offset = "0x810DE20", VA = "0x18810F820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x810FAA0", Offset = "0x810E0A0", VA = "0x18810FAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct KAFBINDEKBF<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x528DA70", Offset = "0x528C070", VA = "0x18528DA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x430B360", Offset = "0x4309960", VA = "0x18430B360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct HBKKKDNNALB<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4DD8C20", Offset = "0x4DD7220", VA = "0x184DD8C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x430A410", Offset = "0x4308A10", VA = "0x18430A410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct AKAMLKAONHP<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C280", Offset = "0x4F8A880", VA = "0x184F8C280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4F8CA90", Offset = "0x4F8B090", VA = "0x184F8CA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct HNLDFCOAKIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8108EA0", Offset = "0x81074A0", VA = "0x188108EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8109080", Offset = "0x8107680", VA = "0x188109080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct AJOGGACIDCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x81030E0", Offset = "0x81016E0", VA = "0x1881030E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8103450", Offset = "0x8101A50", VA = "0x188103450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct OHKFNCFPOCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x810EA90", Offset = "0x810D090", VA = "0x18810EA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x810ED80", Offset = "0x810D380", VA = "0x18810ED80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class ECFBOBOAJLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ECFBOBOAJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x81067D0", Offset = "0x8104DD0", VA = "0x1881067D0")]
		internal Task INKKOIOHOBF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct IAGOPJIJGBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x81090E0", Offset = "0x81076E0", VA = "0x1881090E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8109340", Offset = "0x8107940", VA = "0x188109340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct HCFMAIMLKNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x81089A0", Offset = "0x8106FA0", VA = "0x1881089A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8108B80", Offset = "0x8107180", VA = "0x188108B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct BBOEIBAAMOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x81035C0", Offset = "0x8101BC0", VA = "0x1881035C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8103920", Offset = "0x8101F20", VA = "0x188103920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct IELFGFBPFNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x81093A0", Offset = "0x81079A0", VA = "0x1881093A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8109690", Offset = "0x8107C90", VA = "0x188109690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class INKAFBFPNNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public INKAFBFPNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x810A4B0", Offset = "0x8108AB0", VA = "0x18810A4B0")]
		internal Task JIPCPANPCPP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct HKJBCBPCNFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8108BE0", Offset = "0x81071E0", VA = "0x188108BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8108E40", Offset = "0x8107440", VA = "0x188108E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct OKKLNONJIJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x810F640", Offset = "0x810DC40", VA = "0x18810F640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x810F7C0", Offset = "0x810DDC0", VA = "0x18810F7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct OLBGJANABMP<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x57D97C0", Offset = "0x57D7DC0", VA = "0x1857D97C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x57D9A80", Offset = "0x57D8080", VA = "0x1857D9A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct DPNFECGHDAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x81055A0", Offset = "0x8103BA0", VA = "0x1881055A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x81058D0", Offset = "0x8103ED0", VA = "0x1881058D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? LLKFJKPJEHH;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<DICNEKFFPEP> LGEKPAFMKOK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task AAKIDJIPIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x810C400", Offset = "0x810AA00", VA = "0x18810C400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x810C2D0", Offset = "0x810A8D0", VA = "0x18810C2D0")]
	public static bool LIBGCJNEABH(this Task NPLKHMALANM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA6D0", Offset = "0x3BC8CD0", VA = "0x183BCA6D0")]
	public static Task<T> BABHONNBIAP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x810AF00", Offset = "0x8109500", VA = "0x18810AF00")]
	public static Task EBBAGLOMBIE(this Task NPLKHMALANM, CancellationToken DKFMAIJGPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCE40", Offset = "0x3BCB440", VA = "0x183BCCE40")]
	public static Task<TResult> EBBAGLOMBIE<TResult>(this Task<TResult> NPLKHMALANM, CancellationToken DKFMAIJGPFL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD3C0", Offset = "0x3BCB9C0", VA = "0x183BCD3C0")]
	public static TaskCompletionSource<TResult> EBBAGLOMBIE<TResult>(this TaskCompletionSource<TResult> JGEAKLOFCKJ, CancellationToken DKFMAIJGPFL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x810B760", Offset = "0x8109D60", VA = "0x18810B760")]
	public static IDisposable? FIAACLFDHEC(CancellationToken NAAFAFFPEJP, CancellationToken CIGMBPNIOGM, [Out] CancellationToken JDFOKJKCIMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x810C8F0", Offset = "0x810AEF0", VA = "0x18810C8F0")]
	[AsyncStateMachine(typeof(OEBGHMPAKJK))]
	public static void PJEGOMMJIHN(this Task MMMCFFENLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x810BFD0", Offset = "0x810A5D0", VA = "0x18810BFD0")]
	[AsyncStateMachine(typeof(AKKEKAICFFC))]
	public static void HDAIBLEPHOJ(this Task MMMCFFENLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF870", Offset = "0x3BCDE70", VA = "0x183BCF870")]
	[AsyncStateMachine(typeof(CPGIBMPAHCB<>))]
	public static Task JFKMGFNOKMC<TException>(this Task MMMCFFENLAH) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3BCEE90", Offset = "0x3BCD490", VA = "0x183BCEE90")]
	[AsyncStateMachine(typeof(NEAEFJAIHJF<>))]
	public static Task<T> FHGNMOAKAJK<T>(this Task<T> PIKMBNLEPPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x810B160", Offset = "0x8109760", VA = "0x18810B160")]
	[AsyncStateMachine(typeof(AIKAHDFOIKF))]
	public static Task<TaskStatus> ELFHPBBKALK(this Task? PIKMBNLEPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BCEC50", Offset = "0x3BCD250", VA = "0x183BCEC50")]
	public static (Task<T?>?, Action<T?>?) EKDOMEHLIOL<T>([Optional] CancellationToken KMHHNOGHBLL)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3BCFB00", Offset = "0x3BCE100", VA = "0x183BCFB00")]
	[AsyncStateMachine(typeof(OFBHCEADADA<, >))]
	public static Task<List<TResult>> NGJKHNKNIHO<TResult, TInput>(this Task<List<TInput>> NPLKHMALANM, PCGOOGBMHIN<TInput, TResult> AIBHMFINPIA) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x810A6E0", Offset = "0x8108CE0", VA = "0x18810A6E0")]
	[AsyncStateMachine(typeof(OIOGHFICOPH))]
	public static Task AEPCFDKKAKH(Task MMMCFFENLAH, CancellationToken BACOGCKOPIE, Func<CancellationToken, Task> FAMCMLIBMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x810C080", Offset = "0x810A680", VA = "0x18810C080")]
	[AsyncStateMachine(typeof(GGCJMANACCI))]
	public static Task HJFBDBDHFAL(Func<CancellationToken, Task> LKDLEEGIIKE, TimeSpan GHMHNEFJOFM, [Optional] CancellationToken BACOGCKOPIE, [Optional] Action<OperationCanceledException>? GOJIAGMABOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF230", Offset = "0x3BCD830", VA = "0x183BCF230")]
	[AsyncStateMachine(typeof(DMNMCKOCIBC<>))]
	public static Task<T> HJFBDBDHFAL<T>(Func<CancellationToken, Task<T>> LKDLEEGIIKE, TimeSpan GHMHNEFJOFM, [Optional] CancellationToken BACOGCKOPIE, [Optional] Func<OperationCanceledException, T>? GOJIAGMABOG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x810B250", Offset = "0x8109850", VA = "0x18810B250")]
	public static Task FEJMGIPBPEJ(params Task[] DFMIMKJNFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x810B2A0", Offset = "0x81098A0", VA = "0x18810B2A0")]
	public static Task FEJMGIPBPEJ(IEnumerable<Task> DFMIMKJNFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x810C300", Offset = "0x810A900", VA = "0x18810C300")]
	[AsyncStateMachine(typeof(PFCBKGMHDKM))]
	public static Task<IEnumerable<Task>> LNNADDJFMLB(IEnumerable<Task> DFMIMKJNFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3BCFA20", Offset = "0x3BCE020", VA = "0x183BCFA20")]
	[AsyncStateMachine(typeof(KAFBINDEKBF<>))]
	public static Task<IEnumerable<Task<T>>> LNNADDJFMLB<T>(IEnumerable<Task<T>> DFMIMKJNFBI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF750", Offset = "0x3BCDD50", VA = "0x183BCF750")]
	[AsyncStateMachine(typeof(HBKKKDNNALB<, , >))]
	public static Task<(T1, T2, T3)> ILCCPDJBIHI<T1, T2, T3>(Task<T1> CMNCEJFLCEH, Task<T2> IOJDIDIGHGP, Task<T3> BKNMFJPLLBA) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF490", Offset = "0x3BCDA90", VA = "0x183BCF490")]
	[AsyncStateMachine(typeof(AKAMLKAONHP<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> ILCCPDJBIHI<T1, T2, T3, T4, T5>(Task<T1> CMNCEJFLCEH, Task<T2> IOJDIDIGHGP, Task<T3> BKNMFJPLLBA, Task<T4> ILMBMBGIFPI, Task<T5> DMAKDLFNIEP) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x810AAC0", Offset = "0x81090C0", VA = "0x18810AAC0")]
	[AsyncStateMachine(typeof(HNLDFCOAKIP))]
	public static Task CCEHMMKJFLJ(Func<bool> KCEOCGICBLB, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x810A9B0", Offset = "0x8108FB0", VA = "0x18810A9B0")]
	[AsyncStateMachine(typeof(AJOGGACIDCE))]
	public static Task CCEHMMKJFLJ(Func<bool> KCEOCGICBLB, TimeSpan HEPJEDEAEJF, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x810BB20", Offset = "0x810A120", VA = "0x18810BB20")]
	[AsyncStateMachine(typeof(OHKFNCFPOCD))]
	public static Task GMNEDEONFLJ(Func<bool> KCEOCGICBLB, TimeSpan GHMHNEFJOFM, [Optional] CancellationToken KMHHNOGHBLL, [Optional] Action<OperationCanceledException>? GOJIAGMABOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x810B9E0", Offset = "0x8109FE0", VA = "0x18810B9E0")]
	[AsyncStateMachine(typeof(IAGOPJIJGBK))]
	public static Task GMNEDEONFLJ(Func<bool> KCEOCGICBLB, TimeSpan GHMHNEFJOFM, TimeSpan HEPJEDEAEJF, [Optional] CancellationToken KMHHNOGHBLL, [Optional] Action<OperationCanceledException>? GOJIAGMABOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x810AC00", Offset = "0x8109200", VA = "0x18810AC00")]
	[AsyncStateMachine(typeof(HCFMAIMLKNA))]
	public static Task CIJAHPKACLP(Func<bool> KCEOCGICBLB, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x810ACF0", Offset = "0x81092F0", VA = "0x18810ACF0")]
	[AsyncStateMachine(typeof(BBOEIBAAMOC))]
	public static Task CIJAHPKACLP(Func<bool> KCEOCGICBLB, TimeSpan HEPJEDEAEJF, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x810C7C0", Offset = "0x810ADC0", VA = "0x18810C7C0")]
	[AsyncStateMachine(typeof(IELFGFBPFNL))]
	public static Task OPHCEHAFPBA(Func<bool> KCEOCGICBLB, TimeSpan GHMHNEFJOFM, [Optional] CancellationToken KMHHNOGHBLL, [Optional] Action<OperationCanceledException>? GOJIAGMABOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x810C680", Offset = "0x810AC80", VA = "0x18810C680")]
	[AsyncStateMachine(typeof(HKJBCBPCNFK))]
	public static Task OPHCEHAFPBA(Func<bool> KCEOCGICBLB, TimeSpan GHMHNEFJOFM, TimeSpan HEPJEDEAEJF, [Optional] CancellationToken KMHHNOGHBLL, [Optional] Action<OperationCanceledException>? GOJIAGMABOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x810B8F0", Offset = "0x8109EF0", VA = "0x18810B8F0")]
	[Obsolete]
	[AsyncStateMachine(typeof(OKKLNONJIJO))]
	public static Task GMAIGKLEPKE(this Task NPLKHMALANM, Action BNAOFEBJGMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF050", Offset = "0x3BCD650", VA = "0x183BCF050")]
	[AsyncStateMachine(typeof(OLBGJANABMP<>))]
	[Obsolete]
	public static Task GMAIGKLEPKE<T>(this Task<T> NPLKHMALANM, Action<T> BNAOFEBJGMM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x810AE00", Offset = "0x8109400", VA = "0x18810AE00")]
	private static void CJECJKGNKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x810BC50", Offset = "0x810A250", VA = "0x18810BC50")]
	public static bool GOLJNCPEMPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x810C470", Offset = "0x810AA70", VA = "0x18810C470")]
	private static void NKGKDEDHOHM(SynchronizationContext KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x810C1B0", Offset = "0x810A7B0", VA = "0x18810C1B0")]
	private static void IONBJFGBEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x810A8E0", Offset = "0x8108EE0", VA = "0x18810A8E0")]
	public static void CCANMKOMJHG([Optional] string? CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x810C600", Offset = "0x810AC00", VA = "0x18810C600")]
	public static void NOEOGHBNMIL([Optional] string? CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x810ABB0", Offset = "0x81091B0", VA = "0x18810ABB0")]
	public static POBBFFFDEHJ CIALJNMDOIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x810AEB0", Offset = "0x81094B0", VA = "0x18810AEB0")]
	public static POBBFFFDEHJ DLPBMLAFOIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x810A810", Offset = "0x8108E10", VA = "0x18810A810")]
	[AsyncStateMachine(typeof(DPNFECGHDAM))]
	public static Task BOLJFGGCNAF(Func<Task> OEPFDIIJHGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HIAEMPMDAHB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
	public HIAEMPMDAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class CPOADCGIJKN
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x81045B0", Offset = "0x8102BB0", VA = "0x1881045B0")]
	public static bool AJMJGFGJLJA(this HAADHJPIIJM JONGNHMEJFC, DateTime MABJOCFIJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x81046D0", Offset = "0x8102CD0", VA = "0x1881046D0")]
	public static TimeSpan NDPCHGHEAGC(this HAADHJPIIJM JONGNHMEJFC, DateTime MABJOCFIJPA)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BCHOGAEFPBK : HAADHJPIIJM
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly HAADHJPIIJM FNIBPMLJKFE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime ONHIDOCPJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x81039E0", Offset = "0x8101FE0", VA = "0x1881039E0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset LPALMNFFFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8103980", Offset = "0x8101F80", VA = "0x188103980", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public BCHOGAEFPBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface HAADHJPIIJM
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime ONHIDOCPJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset LPALMNFFFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class FDNDDCOJMBB
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long PENLHLCPNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8107390", Offset = "0x8105990", VA = "0x188107390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long KPIJOHHLIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8106F40", Offset = "0x8105540", VA = "0x188106F40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double GKMCJAOIHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8107190", Offset = "0x8105790", VA = "0x188107190")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double KKGEGEJDJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8106F90", Offset = "0x8105590", VA = "0x188106F90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double IPNOEFDPJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8106FE0", Offset = "0x81055E0", VA = "0x188106FE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double ABEDOLNPCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x81073E0", Offset = "0x81059E0", VA = "0x1881073E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8107300", Offset = "0x8105900", VA = "0x188107300")]
	public static double KGIOCCOKCLK(long ONGIFNKJHFG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x81071E0", Offset = "0x81057E0", VA = "0x1881071E0")]
	public static double JGBALDDLDBL(long ONGIFNKJHFG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8107270", Offset = "0x8105870", VA = "0x188107270")]
	public static double JLCEOOJKNOM(double PEBMKHJGDGA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8107030", Offset = "0x8105630", VA = "0x188107030")]
	public static long HJCDMMAFGID(long BKONJIDKCPP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8107490", Offset = "0x8105A90", VA = "0x188107490")]
	public static long PMDLPNLCGJF(long IMNJIJHANPK, long EHPICEJDGNB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x81070C0", Offset = "0x81056C0", VA = "0x1881070C0")]
	public static double IOECKJPMHAO(long IMNJIJHANPK, long EHPICEJDGNB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8107430", Offset = "0x8105A30", VA = "0x188107430")]
	public static double OKMPNMHFKDH(long IMNJIJHANPK, long EHPICEJDGNB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class ELDCGKLKMCF : KJKMJJJNGAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly TimeSpan APGLDJFFDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly System.Timers.Timer GPIJGKLDGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private TimeSpan GHMHNEFJOFM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan EBPLBEFCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8106840", Offset = "0x8104E40", VA = "0x188106840", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? AAGMMCKIJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8106C80", Offset = "0x8105280", VA = "0x188106C80")]
	[Preserve]
	public ELDCGKLKMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8106CF0", Offset = "0x81052F0", VA = "0x188106CF0")]
	public ELDCGKLKMCF(TimeSpan GHMHNEFJOFM, [Optional] Action? PKFOIBJKJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x81069A0", Offset = "0x8104FA0", VA = "0x1881069A0", Slot = "7")]
	public void BNJPFDALMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8106BA0", Offset = "0x81051A0", VA = "0x188106BA0", Slot = "8")]
	public void MHLLBBDMJJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8106B70", Offset = "0x8105170", VA = "0x188106B70", Slot = "9")]
	public void ELHJEAOCKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1209A10", Offset = "0x1208010", VA = "0x181209A10")]
	private void MEOCAOOPLBN(object HKKDKDDKEBF, ElapsedEventArgs PGNIJOABAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8106AD0", Offset = "0x81050D0", VA = "0x188106AD0")]
	private static void EGPEJBEKOIC(TimeSpan BDLFAIPEPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8106A30", Offset = "0x8105030", VA = "0x188106A30", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CMBJJNOBAFP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly string? HBHKBGCHJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly string JCLOOAICKLF;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1836240", Offset = "0x1834840", VA = "0x181836240")]
	public CMBJJNOBAFP(string LCNJPNDEDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5078180", Offset = "0x5076780", VA = "0x185078180")]
	public CMBJJNOBAFP(string MFGALGGOPCB, string LCNJPNDEDOK)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct EBGDFHFKLDP : IEquatable<EBGDFHFKLDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public uint KOKKJMHLEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public int JIPEKGBPDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float JGOOGOLNAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public ushort PFCJPNMNLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public ushort PFMMJMPCPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public short JDHLHPNCKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public short FDGHLDNBNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public char ABGNMDILHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public char LGEPKINABID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte HMNILDNCOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte KMDPGPHLGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte CAFJLIHFJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte ODLINOJCLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool PCDCEFKEJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool PDOCOFBPODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool POAPEBDPMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool ABNFHHEGOMI;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x202D230", Offset = "0x202B830", VA = "0x18202D230")]
	public static EBGDFHFKLDP OHFFJECIEJL(uint JCAGDEEAACM)
	{
		return default(EBGDFHFKLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x202D230", Offset = "0x202B830", VA = "0x18202D230")]
	public static EBGDFHFKLDP LNMPCBAIGPN(int JGOOJMKGFKA)
	{
		return default(EBGDFHFKLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8105930", Offset = "0x8103F30", VA = "0x188105930")]
	public static EBGDFHFKLDP BFJBAKJEEMH(float JIFIHDKAOEG)
	{
		return default(EBGDFHFKLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x81059C0", Offset = "0x8103FC0", VA = "0x1881059C0")]
	public static EBGDFHFKLDP KFHFEDMNMMM(byte OOLNGMGGHDP, byte GHNOFDHFHDJ, byte PEKAEEEDMDC, byte KIIBCHHCKOP)
	{
		return default(EBGDFHFKLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x81059C0", Offset = "0x8103FC0", VA = "0x1881059C0")]
	public static EBGDFHFKLDP OOEBDDBCOKM(bool KEIDPODKIAK, bool MMLKFOOLLEE, bool FGKCKLHMENI, bool FIKBOFDNKDD)
	{
		return default(EBGDFHFKLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x81059C0", Offset = "0x8103FC0", VA = "0x1881059C0")]
	public static EBGDFHFKLDP HLLNMBPHFPO(byte EGMKBLBEOAB, byte LEJOGNOAILI, byte OGMGHNJPPBK, byte IHINLCLCOII)
	{
		return default(EBGDFHFKLDP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x234F3C0", Offset = "0x234D9C0", VA = "0x18234F3C0")]
	public static bool JKIBMILPCGE(EBGDFHFKLDP IAPIHBICBOE, EBGDFHFKLDP FJDIHEBKFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x234F3A0", Offset = "0x234D9A0", VA = "0x18234F3A0", Slot = "4")]
	public bool Equals(EBGDFHFKLDP HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8105940", Offset = "0x8103F40", VA = "0x188105940", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x147DE10", Offset = "0x147C410", VA = "0x18147DE10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x81059E0", Offset = "0x8103FE0", VA = "0x1881059E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct MFELNLODHJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public ulong CBHDNGLMODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public long PPBLMAOACKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public double IGICELPDHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public uint GNBIJMJMFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public uint JFODLFLCEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public int KGFBONDKEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public int GFHDNBMPLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public float PKNJKIOCIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float IGJCGGHJEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public ushort PFCJPNMNLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public ushort PFMMJMPCPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public ushort LCEBGIOPNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public ushort KPMNMMLOBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public short JDHLHPNCKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public short FDGHLDNBNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public short GCAHNALIGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public short CCAIMNHHNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public char ABGNMDILHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public char LGEPKINABID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public char KEMDOFLLBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public char DPAHBIGAFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte HMNILDNCOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte KMDPGPHLGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte CAFJLIHFJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public byte ODLINOJCLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public byte GOJLMOHIIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public byte MANJIBPINLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public byte LBCHMHKANKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte LOBHEDLBKDJ;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static MFELNLODHJM BFOPDLPDKBM(long FCBDHIOKIHD)
	{
		return default(MFELNLODHJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x810DCB0", Offset = "0x810C2B0", VA = "0x18810DCB0")]
	public static MFELNLODHJM BFOPDLPDKBM(byte OOLNGMGGHDP, byte GHNOFDHFHDJ, byte PEKAEEEDMDC, byte KIIBCHHCKOP, byte KDMNLNJAMLA, byte EDNMDPDKEEK, byte ONAIGMPCPGH, byte IHFGFBELJKI)
	{
		return default(MFELNLODHJM);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct ABEHOGEJIAB : IEquatable<ABEHOGEJIAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte IEPLMGCILNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public bool BIELANFPFNE;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3086360", Offset = "0x3084960", VA = "0x183086360")]
	public static ABEHOGEJIAB KFHFEDMNMMM(byte KHKHAINANIK)
	{
		return default(ABEHOGEJIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3086360", Offset = "0x3084960", VA = "0x183086360")]
	public static ABEHOGEJIAB OOEBDDBCOKM(bool MHNPKFGJHOF)
	{
		return default(ABEHOGEJIAB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x81029F0", Offset = "0x8100FF0", VA = "0x1881029F0")]
	public static bool JKIBMILPCGE(ABEHOGEJIAB IAPIHBICBOE, ABEHOGEJIAB FJDIHEBKFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7001C50", Offset = "0x7000250", VA = "0x187001C50", Slot = "4")]
	public bool Equals(ABEHOGEJIAB HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8102950", Offset = "0x8100F50", VA = "0x188102950", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x81029E0", Offset = "0x8100FE0", VA = "0x1881029E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8102A00", Offset = "0x8101000", VA = "0x188102A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class JCFHJBDGAMI<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public readonly T LJOIGJADACK;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x516C400", Offset = "0x516AA00", VA = "0x18516C400")]
	public JCFHJBDGAMI(T ALCJKAPLHCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class PGLENBIAKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3C28390", Offset = "0x3C26990", VA = "0x183C28390")]
	public static IEnumerable<T> PLKFGAOAFFF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static T[] GKGAMNHPFEL<T>(params T[] BPKFNGFPAME) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static IEnumerable<T> DKCGHPIJAHH<T>(params T[] BPKFNGFPAME) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x39504A0", Offset = "0x394EAA0", VA = "0x1839504A0")]
	public static HashSet<T> JPBMJGONPEH<T>(params T[] BPKFNGFPAME) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC9A0", Offset = "0x3CFAFA0", VA = "0x183CFC9A0")]
	public static KeyValuePair<TKey, TValue> IGIGBGMEGCG<TKey, TValue>([In] TKey BLIBAMJKLIA, [In] TValue KKGBKLFKCPO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x39504A0", Offset = "0x394EAA0", VA = "0x1839504A0")]
	public static List<T> NGGPIGDLLKO<T>(IEnumerable<T> LKKBHMIMCBF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[AttributeUsage(AttributeTargets.All)]
public sealed class ICDNLKDGKKK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public readonly string CIJEGDMDECI;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
	public ICDNLKDGKKK(string LBDLCBINGPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object ECGCIBAOPFF<T>([In] T MMCAOMENGOP);
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object MFKCOECNGJN<T>(T MMCAOMENGOP);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[BHLHPPHNLNG]
public delegate string NLOBAHFNJCB(string IKLHNGEBLBJ, string? GDFBBGHAAKG, bool PNBFFNGEODH);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[BHLHPPHNLNG]
public delegate void LMIJGKDMCOP(string CJIMOMNMAGD);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[BHLHPPHNLNG]
public delegate void AKGDEFKMOIC(Exception CGONOPBDIAB);
[Cpp2IlInjected.Token(Token = "0x200006C")]
public delegate object FIODPKELMIN();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BHLHPPHNLNG]
public delegate bool BKBPBCKLPFJ();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[BHLHPPHNLNG]
public delegate string MEHHFCEHOHO(object ODCICEDDLMB);
[Cpp2IlInjected.Token(Token = "0x200006F")]
[AttributeUsage(AttributeTargets.Enum)]
public class FMHHBCDDNJO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
	public FMHHBCDDNJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class LIEBGAIOMEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct DCDKFIHMGDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x81047F0", Offset = "0x8102DF0", VA = "0x1881047F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x81050E0", Offset = "0x81036E0", VA = "0x1881050E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly TimerCallback GLEGCAHGNLG;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly Action<object?> NFOEPNGMDNA;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x810CDE0", Offset = "0x810B3E0", VA = "0x18810CDE0")]
	public static Task<bool> HHEEJEPOHAL(int NEHAOKCPCLK, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x810CCB0", Offset = "0x810B2B0", VA = "0x18810CCB0")]
	[AsyncStateMachine(typeof(DCDKFIHMGDB))]
	private static Task<bool> EMFAIIEFJMP(int NEHAOKCPCLK, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x810D0F0", Offset = "0x810B6F0", VA = "0x18810D0F0")]
	private static void MBCKOMCLCKO(object? DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x810D180", Offset = "0x810B780", VA = "0x18810D180")]
	private static void OIEKAOHFMIO(object? DCPJOMEJHIO)
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
