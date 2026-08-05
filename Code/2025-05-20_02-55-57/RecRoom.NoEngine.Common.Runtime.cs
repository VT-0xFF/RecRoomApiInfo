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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DDB530", Offset = "0x7DDA730", VA = "0x187DDB530")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GLOKADKBEEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DD67C0", Offset = "0x7DD59C0", VA = "0x187DD67C0")]
	public static string NFNKLDLHFAN(this Encoding CMJIPLLGKEP, [In] ReadOnlySequence<byte> FONJAIMABAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3821AB0", Offset = "0x3820CB0", VA = "0x183821AB0")]
	private static void LPLBELLNIPG<T>(this ReadOnlySequence<T> JOEIEILCALI, [Out] ReadOnlySpan<T> BPDGCBPHPCH, [Out] SequencePosition IGOGNOGJADN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class LMFELGAHCOG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA920", Offset = "0x7DD9B20", VA = "0x187DDA920")]
	public LMFELGAHCOG(bool GGFNDPGLJMC, string LGOKGDAODGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA8D0", Offset = "0x7DD9AD0", VA = "0x187DDA8D0")]
	public LMFELGAHCOG(bool GGFNDPGLJMC, params string[] IPFNIEKDFEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OEHLKPNGAHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CEICGDANMAD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ALEFJCLKJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCJIIHPHIMH(string AGBHGDFILGO, double MLCDCHNOCFI, [Optional] string? LDFJGNLMDFI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PPBIGPHBEBB : DMKAMDJJGMJ, LBHDEGMBBKG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int HCMLPALBMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> FJDMJGLEBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double BCBBNNPFNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double IMCPMFMKKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double MJAJOLDLPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int FOBACGPECCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double CBOMAEOIJPP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AFPFJBBFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double FKCBJMPDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DDEA40", Offset = "0x7DDDC40", VA = "0x187DDEA40", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BCCDHJHPFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x499DAA0", Offset = "0x499CCA0", VA = "0x18499DAA0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double MDKFIBEPOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x273D3C0", Offset = "0x273C5C0", VA = "0x18273D3C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEBD0", Offset = "0x7DDDDD0", VA = "0x187DDEBD0")]
	public PPBIGPHBEBB(int JFAHBFBFANI, double CBOMAEOIJPP = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEAA0", Offset = "0x7DDDCA0", VA = "0x187DDEAA0", Slot = "7")]
	public void PMMEGHDPCJJ(double KFEGNKODPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE8D0", Offset = "0x7DDDAD0", VA = "0x187DDE8D0", Slot = "8")]
	public void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE940", Offset = "0x7DDDB40", VA = "0x187DDE940", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EMGPHPAJMII : DMKAMDJJGMJ, LBHDEGMBBKG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long KIFHGDECLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double HIIINDHHBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double ICLMFIEGNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double DJGKGMNFCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double GBPMMEPNMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double BCBBNNPFNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double IMCPMFMKKOG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BCCDHJHPFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x706F190", Offset = "0x706E390", VA = "0x18706F190", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MDKFIBEPOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x706F5F0", Offset = "0x706E7F0", VA = "0x18706F5F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JLDKCGHPLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x706F640", Offset = "0x706E840", VA = "0x18706F640")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double FKCBJMPDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2E21DD0", Offset = "0x2E20FD0", VA = "0x182E21DD0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4C60", Offset = "0x7DD3E60", VA = "0x187DD4C60", Slot = "10")]
	public virtual void PMMEGHDPCJJ(double KFEGNKODPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4BB0", Offset = "0x7DD3DB0", VA = "0x187DD4BB0", Slot = "11")]
	public virtual void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4BF0", Offset = "0x7DD3DF0", VA = "0x187DD4BF0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4D80", Offset = "0x7DD3F80", VA = "0x187DD4D80")]
	public EMGPHPAJMII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IAGKMBMBNBP : EMGPHPAJMII
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double GLOPGJHOIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x706F600", Offset = "0x706E800", VA = "0x18706F600")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x706F5D0", Offset = "0x706E7D0", VA = "0x18706F5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8880", Offset = "0x7DD7A80", VA = "0x187DD8880", Slot = "10")]
	public override void PMMEGHDPCJJ(double KFEGNKODPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8840", Offset = "0x7DD7A40", VA = "0x187DD8840", Slot = "11")]
	public override void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4D80", Offset = "0x7DD3F80", VA = "0x187DD4D80")]
	public IAGKMBMBNBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DMKAMDJJGMJ : LBHDEGMBBKG, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double FKCBJMPDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BCCDHJHPFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double MDKFIBEPOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MJOJCDHBNAN : LBHDEGMBBKG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double PDMJCMPMFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double BDMNDHHDKPF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB420", Offset = "0x7DDA620", VA = "0x187DDB420")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D0E350", Offset = "0x7D0D550", VA = "0x187D0E350", Slot = "4")]
	public void PMMEGHDPCJJ(double KFEGNKODPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB3C0", Offset = "0x7DDA5C0", VA = "0x187DDB3C0", Slot = "5")]
	public void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB3D0", Offset = "0x7DDA5D0", VA = "0x187DDB3D0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MJOJCDHBNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LBHDEGMBBKG : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMMEGHDPCJJ(double KFEGNKODPFP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJIPEHIHHNF();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MGCKANBABDN : LBHDEGMBBKG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double MLCDCHNOCFI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x45B6B40", Offset = "0x45B5D40", VA = "0x1845B6B40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53617E0", Offset = "0x53609E0", VA = "0x1853617E0", Slot = "4")]
	public void PMMEGHDPCJJ(double KFEGNKODPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB360", Offset = "0x7DDA560", VA = "0x187DDB360", Slot = "5")]
	public void AJIPEHIHHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB370", Offset = "0x7DDA570", VA = "0x187DDB370", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MGCKANBABDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MEBFJJMHBDC<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> HKPGHBOOEDD(CancellationToken HCELDNOKOAM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JKBBBDMPALD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MEBFJJMHBDC<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HKPGHBOOEDD taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4ECA460", Offset = "0x4EC9660", VA = "0x184ECA460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4ECB520", Offset = "0x4ECA720", VA = "0x184ECB520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource BDMFGMOCHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? DAKNHAMIKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? FEIJDNMHCOA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x52D84E0", Offset = "0x52D76E0", VA = "0x1852D84E0")]
	[AsyncStateMachine(typeof(MEBFJJMHBDC<>.JKBBBDMPALD))]
	public Task<TResult> EGAEDEBPKEN(HKPGHBOOEDD FKILGGAFOKH, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x52D8470", Offset = "0x52D7670", VA = "0x1852D8470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x52D8620", Offset = "0x52D7820", VA = "0x1852D8620")]
	public MEBFJJMHBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class LGPINKKNBPB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> JEMCFOMPLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T ABLHJAOAOGP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4990F40", Offset = "0x4990140", VA = "0x184990F40")]
	public LGPINKKNBPB([In] T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x50CBB30", Offset = "0x50CAD30", VA = "0x1850CBB30", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x50CC270", Offset = "0x50CB470", VA = "0x1850CC270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50CC760", Offset = "0x50CB960", VA = "0x1850CC760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CFNCDIGLGNA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3615CF0", Offset = "0x3614EF0", VA = "0x183615CF0")]
	public static LGPINKKNBPB<T> OIKMHICCLEP<T>([In] T MLCDCHNOCFI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AKGIHODLOAP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2110", Offset = "0x7DD1310", VA = "0x187DD2110")]
	public static void AOHJINPHHKD(this CancellationTokenSource BDMFGMOCHPG, bool BGIIFAHOMPB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class IHBPJECEBJC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
	public IHBPJECEBJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class PLKEPGJEPLK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
	public PLKEPGJEPLK(string DBONJEHEAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class FJGFIFAHCJF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37FAC20", Offset = "0x37F9E20", VA = "0x1837FAC20")]
	public static GMAEJBPCGCM MHPHPLAKCEI<T>()
	{
		return default(GMAEJBPCGCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x37FA950", Offset = "0x37F9B50", VA = "0x1837FA950")]
	public static GMAEJBPCGCM AFOBFDBBJJL<T>([CallerMemberName] string DGIAFBEDPNJ = "") where T : notnull
	{
		return default(GMAEJBPCGCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37FABA0", Offset = "0x37F9DA0", VA = "0x1837FABA0")]
	public static GMAEJBPCGCM MHPHPLAKCEI<T>(this T NIDPEFPJBOO) where T : notnull
	{
		return default(GMAEJBPCGCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37FACA0", Offset = "0x37F9EA0", VA = "0x1837FACA0")]
	public static GMAEJBPCGCM OICHOADLMCJ<T>(this T NIDPEFPJBOO, [CallerMemberName] string DGIAFBEDPNJ = "") where T : notnull
	{
		return default(GMAEJBPCGCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37FA9F0", Offset = "0x37F9BF0", VA = "0x1837FA9F0")]
	public static GMAEJBPCGCM AFOBFDBBJJL<T>(this T CEENCLMGJAM, [CallerMemberName] string DGIAFBEDPNJ = "") where T : notnull
	{
		return default(GMAEJBPCGCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5320", Offset = "0x7DD4520", VA = "0x187DD5320")]
	public static GMAEJBPCGCM AFOBFDBBJJL(string EODAALLEFCL, [CallerMemberName] string DGIAFBEDPNJ = "")
	{
		return default(GMAEJBPCGCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7DD53A0", Offset = "0x7DD45A0", VA = "0x187DD53A0")]
	public static string DPGIIPAIOJD(this object CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool EBDLFOFKJIN();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[IHBPJECEBJC]
public delegate long IKACOGKAKIH();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class MFELFODACLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly MFELFODACLP NDDGJHHDBNJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MFELFODACLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ILEPLJDJPIK
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static GFMKLKHGMLC NCJDGMPEOOH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static GFMKLKHGMLC LCLIEIPIEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7DD95A0", Offset = "0x7DD87A0", VA = "0x187DD95A0")]
		get
		{
			return default(GFMKLKHGMLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static ANBCIFAPNOB CCKFNPLEPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9500", Offset = "0x7DD8700", VA = "0x187DD9500")]
		get
		{
			return default(ANBCIFAPNOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static PDCJEIKIDDE LFPDNJPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9550", Offset = "0x7DD8750", VA = "0x187DD9550")]
		get
		{
			return default(PDCJEIKIDDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool JKOGPFJOCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9490", Offset = "0x7DD8690", VA = "0x187DD9490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9180", Offset = "0x7DD8380", VA = "0x187DD9180")]
	public static void ICHKGAJFHBK([In] GFMKLKHGMLC PINBDFJGGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8F90", Offset = "0x7DD8190", VA = "0x187DD8F90")]
	public static void GCMHLHCLEDM(string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8D70", Offset = "0x7DD7F70", VA = "0x187DD8D70")]
	public static void BFEGJAKAIFE(string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3850310", Offset = "0x384F510", VA = "0x183850310")]
	public static void BFEGJAKAIFE<T>(T HLMDGBFCIDH, NIMIBCOALNB<T> BDAAPBJEHGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7DD90E0", Offset = "0x7DD82E0", VA = "0x187DD90E0")]
	public static void HGBCOCGFNFC(Exception MJPFDOAJBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9060", Offset = "0x7DD8260", VA = "0x187DD9060")]
	public static void HDOBOIDDNPB(string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8E40", Offset = "0x7DD8040", VA = "0x187DD8E40")]
	public static void DJDCJPJJCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8EB0", Offset = "0x7DD80B0", VA = "0x187DD8EB0")]
	public static string DPGIIPAIOJD(object DBCLNEGBNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8F20", Offset = "0x7DD8120", VA = "0x187DD8F20")]
	public static long FOOBPKPELMB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD93F0", Offset = "0x7DD85F0", VA = "0x187DD93F0")]
	public static bool JPFMFLCNPOK(bool CKBDGPAFKOM, string BDAAPBJEHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9320", Offset = "0x7DD8520", VA = "0x187DD9320")]
	public static double IMPAOIJNJMN()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct GFMKLKHGMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly ANBCIFAPNOB CCKFNPLEPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly PDCJEIKIDDE LFPDNJPAGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly GDCCJEBEMON EDAJNFMCJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly IKACOGKAKIH DLDAHOFPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly MCOMMCPKONC KFPJIDMEEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly EBDLFOFKJIN NGGLOAEHKGH;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly GDCCJEBEMON IKKCHLGDALN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly IKACOGKAKIH DJBGKLFECNA;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly MCOMMCPKONC NGFKDLPNGHO;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly EBDLFOFKJIN DBAIEFBBBIL;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly GFMKLKHGMLC MLINAHCDIHH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BFALGEPOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5CA0", Offset = "0x7DD4EA0", VA = "0x187DD5CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6630", Offset = "0x7DD5830", VA = "0x187DD6630")]
	public GFMKLKHGMLC([In] ANBCIFAPNOB CFFEEFLMOGD, [In] PDCJEIKIDDE LLJELHMCEFP, GDCCJEBEMON CODDMOLIOIC, IKACOGKAKIH EAJJDEMEOGB, MCOMMCPKONC OLCMOGOKHAO, EBDLFOFKJIN OJAAPPLPEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5E30", Offset = "0x7DD5030", VA = "0x187DD5E30")]
	private static string FBFDEGIPMCN(object DBCLNEGBNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0")]
	private static long FMKGKIEEPHI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	private static string FENMKFELGLH(string AKCEGHPGLOG, string? GNKOKDLDGPC, bool HFBPOAJMIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
	private static bool PAHNDADIGBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5E70", Offset = "0x7DD5070", VA = "0x187DD5E70")]
	private static GFMKLKHGMLC LMADPBJDKDD()
	{
		return default(GFMKLKHGMLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ACNINDHIJEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEMOHLHDNHC LKNFDOKEILD();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IEMOHLHDNHC : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool INKNHIHBLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APOIGBHFMDN();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EALINKJBEFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LLEJKDDIKMK([In] T FNJGMJGALLH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void LBKHDKOMGFP<T>([In] T HLMDGBFCIDH);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct BIHLPJIKDEH<T> : IEquatable<BIHLPJIKDEH<T>>, EALINKJBEFP<BIHLPJIKDEH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T ABLHJAOAOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int PMLOAHGMFBB;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E91520", Offset = "0x5E90720", VA = "0x185E91520")]
	public BIHLPJIKDEH([In] T MLCDCHNOCFI, int NIBICIJAIGM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E90660", Offset = "0x5E8F860", VA = "0x185E90660")]
	public static bool NDBPPCEOMJH([In] BIHLPJIKDEH<T> MHEJPNNFCGC, [In] BIHLPJIKDEH<T> BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5397060", Offset = "0x5396260", VA = "0x185397060", Slot = "4")]
	public bool Equals(BIHLPJIKDEH<T> FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5101F60", Offset = "0x5101160", VA = "0x185101F60", Slot = "0")]
	public override bool Equals(object FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E905D0", Offset = "0x5E8F7D0", VA = "0x185E905D0")]
	public bool LLEJKDDIKMK([In] BIHLPJIKDEH<T> FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E90350", Offset = "0x5E8F550", VA = "0x185E90350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E90D80", Offset = "0x5E8FF80", VA = "0x185E90D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FD00", Offset = "0x5E8EF00", VA = "0x185E8FD00")]
	public void EFFIMEDBJAK([Out] T MLCDCHNOCFI, [Out] int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F690", Offset = "0x5E8E890", VA = "0x185E8F690")]
	public (T, int) DNOMEDLEJCL()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F3D0", Offset = "0x5E8E5D0", VA = "0x185E8F3D0", Slot = "5")]
	private bool CLPPFLEJCPN([In] BIHLPJIKDEH<T> FNJGMJGALLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LNIIPBENEBK
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x38C68F0", Offset = "0x38C5AF0", VA = "0x1838C68F0")]
	public static BIHLPJIKDEH<T> OIKMHICCLEP<T>([In] T MLCDCHNOCFI, int NIBICIJAIGM) where T : notnull
	{
		return default(BIHLPJIKDEH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FFELJKDJCOD
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x37F5C10", Offset = "0x37F4E10", VA = "0x1837F5C10")]
	public static bool LLEJKDDIKMK<T, U>([In] T CEENCLMGJAM, [In] U DBCLNEGBNLN) where T : notnull, EALINKJBEFP<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult IOFDBGMBBJK<T, out TResult>([In] T HLMDGBFCIDH);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GGKEFBHOOFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan LLOHIMFEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? HOLBLFGFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBLDJPNEDPM();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPGBNGNJLOM();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJEJKDBNPIP();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct ANBCIFAPNOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly FLBCHLLNDPO OOFBFBKONGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly HLGJCMCHAIC FHKIBFCAJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly FLBCHLLNDPO LDLJMMFKCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly HLGJCMCHAIC CJJOIFLOAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly FLBCHLLNDPO NABKODPNBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly HLGJCMCHAIC BFGKOLIOGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly EOHLODICHHC AJKKLGPBJHB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly FLBCHLLNDPO DFFDACKEMJE;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly HLGJCMCHAIC OHFBELDEKNC;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly FLBCHLLNDPO ELFNIBPLALI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly HLGJCMCHAIC CDEEDHFAAOA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly FLBCHLLNDPO EOJJHGCEOPO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly HLGJCMCHAIC FOAEIBPMPCD;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly EOHLODICHHC NHGHCMGPAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly ANBCIFAPNOB MLINAHCDIHH;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly FLBCHLLNDPO PLPCCCJGJOO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool BFALGEPOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2290", Offset = "0x7DD1490", VA = "0x187DD2290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xD721C0", Offset = "0xD713C0", VA = "0x180D721C0")]
	public ANBCIFAPNOB(FLBCHLLNDPO EKBNNEGOGGI, HLGJCMCHAIC DGAAIHFENHF, FLBCHLLNDPO MMKDGNFNNHF, HLGJCMCHAIC HPFFJCFFFNK, FLBCHLLNDPO LOFFCAJNANL, HLGJCMCHAIC MCPMGIHDEFH, EOHLODICHHC BGCMJCMOHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
	private static bool NBOFEBKIOAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void IMCECPDFEFH(string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
	private static bool FEDHNDDHCPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void FLNJJDJGDEA(string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
	private static bool CEOOGFFELIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void EEDIIABBPLA(string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void HCLFNKEOCBJ(Exception MJPFDOAJBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2620", Offset = "0x7DD1820", VA = "0x187DD2620")]
	private static ANBCIFAPNOB LMADPBJDKDD()
	{
		return default(ANBCIFAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
	private static bool FNALAEBCMCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD24E0", Offset = "0x7DD16E0", VA = "0x187DD24E0")]
	public void GCMHLHCLEDM(object BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2470", Offset = "0x7DD1670", VA = "0x187DD2470")]
	public void DHGJFAAOLJE(object BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2140", Offset = "0x7DD1340", VA = "0x187DD2140")]
	public void BFEGJAKAIFE(object BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xD7AA50", Offset = "0xD79C50", VA = "0x180D7AA50")]
	public void HGBCOCGFNFC(Exception MJPFDOAJBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7DD21B0", Offset = "0x7DD13B0", VA = "0x187DD21B0")]
	public void BFEGJAKAIFE(EIAHHHGIHBJ BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4019970", Offset = "0x4018B70", VA = "0x184019970")]
	public void BFEGJAKAIFE<T>(T HLMDGBFCIDH, NIMIBCOALNB<T> BDAAPBJEHGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4019CB0", Offset = "0x4018EB0", VA = "0x184019CB0")]
	public void GCMHLHCLEDM<T>([In] T HLMDGBFCIDH, KGHEKJMENFB<T> BDAAPBJEHGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x40198A0", Offset = "0x4018AA0", VA = "0x1840198A0")]
	public void BFEGJAKAIFE<T>([In] T HLMDGBFCIDH, KGHEKJMENFB<T> BDAAPBJEHGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2550", Offset = "0x7DD1750", VA = "0x187DD2550")]
	public bool JPFMFLCNPOK(bool CKBDGPAFKOM, string BDAAPBJEHGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct GMAEJBPCGCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string ABLHJAOAOGP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	public GMAEJBPCGCM(string MLCDCHNOCFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150")]
	public static string NEKLFDMHCNA([In] GMAEJBPCGCM CEENCLMGJAM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x22E7E00", Offset = "0x22E7000", VA = "0x1822E7E00")]
	public static GMAEJBPCGCM NEKLFDMHCNA(string FNJGMJGALLH)
	{
		return default(GMAEJBPCGCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6E60", Offset = "0x7DD6060", VA = "0x187DD6E60")]
	public string LAAJBNGFBCB(string NFEAHFMGOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6D80", Offset = "0x7DD5F80", VA = "0x187DD6D80")]
	public string IAOBNBIOBMH(object LEGJNCGODJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class JPCOMPBOBIH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
	public JPCOMPBOBIH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct GKPOGNMPJHG : IEquatable<GKPOGNMPJHG>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "4")]
	public bool Equals(GKPOGNMPJHG FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6730", Offset = "0x7DD5930", VA = "0x187DD6730", Slot = "0")]
	public override bool Equals(object FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6780", Offset = "0x7DD5980", VA = "0x187DD6780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6790", Offset = "0x7DD5990", VA = "0x187DD6790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CGDAAOOHDFB("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct CJILJFGJKPL<T> : IEquatable<CJILJFGJKPL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T ABLHJAOAOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool GOHPJMNGCLA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MJIELLAPFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x654DE00", Offset = "0x654D000", VA = "0x18654DE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x654EE50", Offset = "0x654E050", VA = "0x18654EE50")]
	public CJILJFGJKPL([In] T MLCDCHNOCFI, bool FAAKPCGHFMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x654DE30", Offset = "0x654D030", VA = "0x18654DE30")]
	public static bool NDBPPCEOMJH([In] CJILJFGJKPL<T> MHEJPNNFCGC, [In] CJILJFGJKPL<T> BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x654CFB0", Offset = "0x654C1B0", VA = "0x18654CFB0", Slot = "4")]
	public bool Equals(CJILJFGJKPL<T> FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x654D1B0", Offset = "0x654C3B0", VA = "0x18654D1B0", Slot = "0")]
	public override bool Equals(object? FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x654DB90", Offset = "0x654CD90", VA = "0x18654DB90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x654E700", Offset = "0x654D900", VA = "0x18654E700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class BIHAOPLFPAM
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x35B71F0", Offset = "0x35B63F0", VA = "0x1835B71F0")]
	public static CJILJFGJKPL<T> INNLBBAKIDI<T>([In] T MLCDCHNOCFI) where T : notnull
	{
		return default(CJILJFGJKPL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x35B6FE0", Offset = "0x35B61E0", VA = "0x1835B6FE0")]
	public static CJILJFGJKPL<T?> IEAMPDJOKHB<T>()
	{
		return default(CJILJFGJKPL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x35B7360", Offset = "0x35B6560", VA = "0x1835B7360")]
	public static bool KABMMLOEGGI<T>([In] this CJILJFGJKPL<T> EPNDBAOHGIM, [Out][NotNullWhen(true)] T MLCDCHNOCFI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x35B72F0", Offset = "0x35B64F0", VA = "0x1835B72F0")]
	public static bool KABMMLOEGGI<T>([In] this CJILJFGJKPL<T> EPNDBAOHGIM, [Out][NotNullWhen(true)] T MLCDCHNOCFI, [Out] CJILJFGJKPL<T> BPALPFKICNL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x35B6E80", Offset = "0x35B6080", VA = "0x1835B6E80")]
	public static T? EBNMGJJHCJE<T>([In] this CJILJFGJKPL<T> EPNDBAOHGIM, T? FAGKKFIFNNI)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x35B7390", Offset = "0x35B6590", VA = "0x1835B7390")]
	public static bool KECMKIKDBIK<T>([In] this CJILJFGJKPL<T> EPNDBAOHGIM, T MLCDCHNOCFI) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ODBLDIOPBLK
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x39DFFC0", Offset = "0x39DF1C0", VA = "0x1839DFFC0")]
	public static T LKACNAPNDNI<T>([In] this CJILJFGJKPL<T> EPNDBAOHGIM) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct PDCJEIKIDDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr HDOBOIDDNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr DJDCJPJJCOD;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr AAOFAJHHOIH;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr OFNOJAMJANO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly PDCJEIKIDDE MLINAHCDIHH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool BFALGEPOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC070", Offset = "0x7DDB270", VA = "0x187DDC070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
	public PDCJEIKIDDE(IntPtr OLONJOEOGLM, IntPtr EPHGHHBIMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void NIBGIIKOKAA(string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void FEBMFIJPODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC140", Offset = "0x7DDB340", VA = "0x187DDC140")]
	private static PDCJEIKIDDE LMADPBJDKDD()
	{
		return default(PDCJEIKIDDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct NLPDDHKILCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr AHFHAKFGBOK;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
	private NLPDDHKILCE(IntPtr EPHGHHBIMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB430", Offset = "0x7DDA630", VA = "0x187DDB430")]
	public void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB450", Offset = "0x7DDA650", VA = "0x187DDB450")]
	public static NLPDDHKILCE OIKMHICCLEP(string DGIAFBEDPNJ)
	{
		return default(NLPDDHKILCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x27C1620", Offset = "0x27C0820", VA = "0x1827C1620")]
	public static NLPDDHKILCE OIKMHICCLEP([In] PDCJEIKIDDE LLJELHMCEFP, string DGIAFBEDPNJ)
	{
		return default(NLPDDHKILCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x27C15C0", Offset = "0x27C07C0", VA = "0x1827C15C0")]
	public static NLPDDHKILCE OIKMHICCLEP([In] PDCJEIKIDDE LLJELHMCEFP, Func<string> DGIAFBEDPNJ)
	{
		return default(NLPDDHKILCE);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class IADHGDPHKEP : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? AJBEJNGLDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr PPCCKKJHLNB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool PDJMFHBOHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8400", Offset = "0x7DD7600", VA = "0x187DD8400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DD81F0", Offset = "0x7DD73F0", VA = "0x187DD81F0")]
	public static SHA256 EAIFKKLDBGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8270", Offset = "0x7DD7470", VA = "0x187DD8270")]
	private static extern int EIJEJBFFPDK();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD87A0", Offset = "0x7DD79A0", VA = "0x187DD87A0")]
	private static extern IntPtr OFBMDOOOPMG();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8380", Offset = "0x7DD7580", VA = "0x187DD8380")]
	private static extern void GJBOJFCAKKJ(IntPtr PPCCKKJHLNB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DD80A0", Offset = "0x7DD72A0", VA = "0x187DD80A0")]
	private static extern void AEKJMHOPEKO(IntPtr PPCCKKJHLNB, byte[] DHAOEHNLNON, int OEBFFKLMAPN, int CEDCEAGDEFA);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DD82E0", Offset = "0x7DD74E0", VA = "0x187DD82E0")]
	private static extern void FEAHBLPCKKH(IntPtr PPCCKKJHLNB, byte[] DMNFLNBBMPN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8810", Offset = "0x7DD7A10", VA = "0x187DD8810")]
	private IADHGDPHKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DD84F0", Offset = "0x7DD76F0", VA = "0x187DD84F0", Slot = "18")]
	protected override void HashCore(byte[] CABEAFGDMFF, int MECCPKAPKDE, int MMLJNKHHJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DD85B0", Offset = "0x7DD77B0", VA = "0x187DD85B0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DD86E0", Offset = "0x7DD78E0", VA = "0x187DD86E0", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8160", Offset = "0x7DD7360", VA = "0x187DD8160", Slot = "13")]
	protected override void Dispose(bool FGLACMFJBCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PGINOBNOHAF
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool FPGOKBOEOBM<in TInput, TResult>(TInput EEEOGOJIPGB, [Out] TResult IGGKBIDIAJL);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class BLBMDLHAJAK : ACNINDHIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class KHAENIAICIK : IEMOHLHDNHC, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly KHAENIAICIK NDDGJHHDBNJ;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool INKNHIHBLEB
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7DDA5A0", Offset = "0x7DD97A0", VA = "0x187DDA5A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7DDA600", Offset = "0x7DD9800", VA = "0x187DDA600", Slot = "6")]
			public void OnCompleted(Action KGOMEKGAMLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
			public void APOIGBHFMDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public KHAENIAICIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly BLBMDLHAJAK NDDGJHHDBNJ;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		private BLBMDLHAJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DD31C0", Offset = "0x7DD23C0", VA = "0x187DD31C0", Slot = "4")]
		public IEMOHLHDNHC LKNFDOKEILD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class BDFDNPABJAC : ACNINDHIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class BENCBMGAOKO : IEMOHLHDNHC, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly BENCBMGAOKO NDDGJHHDBNJ;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool INKNHIHBLEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x7DD2DD0", Offset = "0x7DD1FD0", VA = "0x187DD2DD0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7DD2DF0", Offset = "0x7DD1FF0", VA = "0x187DD2DF0", Slot = "6")]
			public void OnCompleted(Action KGOMEKGAMLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
			public void APOIGBHFMDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public BENCBMGAOKO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly BDFDNPABJAC NDDGJHHDBNJ;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		private BDFDNPABJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2D10", Offset = "0x7DD1F10", VA = "0x187DD2D10", Slot = "4")]
		public IEMOHLHDNHC LKNFDOKEILD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MLMIIDEMCPD<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MLMIIDEMCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5323DC0", Offset = "0x5322FC0", VA = "0x185323DC0")]
		internal void GGMMKLGCBIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ONHCKMLLGID<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ONHCKMLLGID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x55411C0", Offset = "0x55403C0", VA = "0x1855411C0")]
		internal void KNHIIFPHGOE(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct PAJCJONJCDH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7DDBF10", Offset = "0x7DDB110", VA = "0x187DDBF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct HOLAMAAKHPL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7DD70F0", Offset = "0x7DD62F0", VA = "0x187DD70F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct JHNPBEALPIL<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4EC58D0", Offset = "0x4EC4AD0", VA = "0x184EC58D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5A40", Offset = "0x4EC4C40", VA = "0x184EC5A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct ODPPFEIKGLA<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x54C34D0", Offset = "0x54C26D0", VA = "0x1854C34D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x54C3D20", Offset = "0x54C2F20", VA = "0x1854C3D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JAEMOBPPJHH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9C60", Offset = "0x7DD8E60", VA = "0x187DD9C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9E70", Offset = "0x7DD9070", VA = "0x187DD9E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DGALIGONFOJ<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DGALIGONFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5323DC0", Offset = "0x5322FC0", VA = "0x185323DC0")]
		internal void EFPMAFHAMFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6A21490", Offset = "0x6A20690", VA = "0x186A21490")]
		internal void HNJLDHMDMLJ(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct DDEKOANOCIG<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public FPGOKBOEOBM<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x69E1000", Offset = "0x69E0200", VA = "0x1869E1000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x69E1710", Offset = "0x69E0910", VA = "0x1869E1710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FKLHEIOPBFI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5440", Offset = "0x7DD4640", VA = "0x187DD5440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5C40", Offset = "0x7DD4E40", VA = "0x187DD5C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct JAABEMCMIGP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7DD96B0", Offset = "0x7DD88B0", VA = "0x187DD96B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9C00", Offset = "0x7DD8E00", VA = "0x187DD9C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JELMOGAGOGK<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4EB59C0", Offset = "0x4EB4BC0", VA = "0x184EB59C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4A5A540", Offset = "0x4A59740", VA = "0x184A5A540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class DHDFBGILMGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<GKPOGNMPJHG> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DHDFBGILMGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3D20", Offset = "0x7DD2F20", VA = "0x187DD3D20")]
		internal void MHDPJPCOGHA(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct JGMEFDLFDPL<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4EBE030", Offset = "0x4EBD230", VA = "0x184EBE030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x40C84D0", Offset = "0x40C76D0", VA = "0x1840C84D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PMBBKILECHI<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5637060", Offset = "0x5636260", VA = "0x185637060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x40C7580", Offset = "0x40C6780", VA = "0x1840C7580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct BBMLFKMLFNA<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

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
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A9D0", Offset = "0x5E69BD0", VA = "0x185E6A9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B8D0", Offset = "0x5E6AAD0", VA = "0x185E6B8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct FDDJFDHPCIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4E20", Offset = "0x7DD4020", VA = "0x187DD4E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5000", Offset = "0x7DD4200", VA = "0x187DD5000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct IEOFKBLELAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7DD89B0", Offset = "0x7DD7BB0", VA = "0x187DD89B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8D10", Offset = "0x7DD7F10", VA = "0x187DD8D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct DKPHFMCJNFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3E30", Offset = "0x7DD3030", VA = "0x187DD3E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4120", Offset = "0x7DD3320", VA = "0x187DD4120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EOLIPDECDOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EOLIPDECDOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4DB0", Offset = "0x7DD3FB0", VA = "0x187DD4DB0")]
		internal Task LPFNNBPDBNO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct BMEABHODFBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3280", Offset = "0x7DD2480", VA = "0x187DD3280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7DD34E0", Offset = "0x7DD26E0", VA = "0x187DD34E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct HKHAHGBHIJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6EB0", Offset = "0x7DD60B0", VA = "0x187DD6EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7090", Offset = "0x7DD6290", VA = "0x187DD7090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct CMKGJEMNGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3720", Offset = "0x7DD2920", VA = "0x187DD3720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3A80", Offset = "0x7DD2C80", VA = "0x187DD3A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct DMJAACPIGMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4180", Offset = "0x7DD3380", VA = "0x187DD4180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4470", Offset = "0x7DD3670", VA = "0x187DD4470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JFLOGMGAGBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JFLOGMGAGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9EE0", Offset = "0x7DD90E0", VA = "0x187DD9EE0")]
		internal Task EJKCHIFPJDA(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct FEFAAIEHCCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5060", Offset = "0x7DD4260", VA = "0x187DD5060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7DD52C0", Offset = "0x7DD44C0", VA = "0x187DD52C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct CDACFMPHALK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3540", Offset = "0x7DD2740", VA = "0x187DD3540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7DD36C0", Offset = "0x7DD28C0", VA = "0x187DD36C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct KOGNKIDELEC<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5024C90", Offset = "0x5023E90", VA = "0x185024C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5025150", Offset = "0x5024350", VA = "0x185025150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct PDNMLCOIFFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC310", Offset = "0x7DDB510", VA = "0x187DDC310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC640", Offset = "0x7DDB840", VA = "0x187DDC640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? CDIKDCIPLCG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<GKPOGNMPJHG> BBDAFANLHCP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task EHAEMJDGNLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD550", Offset = "0x7DDC750", VA = "0x187DDD550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC790", Offset = "0x7DDB990", VA = "0x187DDC790")]
	public static bool AJADJFJIKFL(this Task LDLKICLCOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A0EAF0", Offset = "0x3A0DCF0", VA = "0x183A0EAF0")]
	public static Task<T> AIMJPEJEHNO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD610", Offset = "0x7DDC810", VA = "0x187DDD610")]
	public static Task KPIOAJJGNNG(this Task LDLKICLCOAG, CancellationToken PPOILDCNBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A10550", Offset = "0x3A0F750", VA = "0x183A10550")]
	public static Task<TResult> KPIOAJJGNNG<TResult>(this Task<TResult> LDLKICLCOAG, CancellationToken PPOILDCNBFL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FBC0", Offset = "0x3A0EDC0", VA = "0x183A0FBC0")]
	public static TaskCompletionSource<TResult> KPIOAJJGNNG<TResult>(this TaskCompletionSource<TResult> JDJHNJLLIGB, CancellationToken PPOILDCNBFL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC7C0", Offset = "0x7DDB9C0", VA = "0x187DDC7C0")]
	public static IDisposable? AOGGPMPCILD(CancellationToken HLGBEPHKGEF, CancellationToken JKNLDAKONOL, [Out] CancellationToken BEDGFEHCMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCB50", Offset = "0x7DDBD50", VA = "0x187DDCB50")]
	[AsyncStateMachine(typeof(PAJCJONJCDH))]
	public static void BABHALBLMKO(this Task PNIEJJKFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD420", Offset = "0x7DDC620", VA = "0x187DDD420")]
	[AsyncStateMachine(typeof(HOLAMAAKHPL))]
	public static void HNOLNPPIFDF(this Task PNIEJJKFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A14920", Offset = "0x3A13B20", VA = "0x183A14920")]
	[AsyncStateMachine(typeof(JHNPBEALPIL<>))]
	public static Task PNMMOLEIIJN<TException>(this Task PNIEJJKFCEK) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A14740", Offset = "0x3A13940", VA = "0x183A14740")]
	[AsyncStateMachine(typeof(ODPPFEIKGLA<>))]
	public static Task<T> OLNBHCLAOFH<T>(this Task<T> CEENCLMGJAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC6A0", Offset = "0x7DDB8A0", VA = "0x187DDC6A0")]
	[AsyncStateMachine(typeof(JAEMOBPPJHH))]
	public static Task<TaskStatus> AGICOKHELDN(this Task? CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A0EC70", Offset = "0x3A0DE70", VA = "0x183A0EC70")]
	public static (Task<T?>?, Action<T?>?) BCAKGICGMGA<T>([Optional] CancellationToken HCELDNOKOAM)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F0D0", Offset = "0x3A0E2D0", VA = "0x183A0F0D0")]
	[AsyncStateMachine(typeof(DDEKOANOCIG<, >))]
	public static Task<List<TResult>> DCJGKBDHMLE<TResult, TInput>(this Task<List<TInput>> LDLKICLCOAG, FPGOKBOEOBM<TInput, TResult> GGDGHNJDPED) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD860", Offset = "0x7DDCA60", VA = "0x187DDD860")]
	[AsyncStateMachine(typeof(FKLHEIOPBFI))]
	public static Task LHHFCEPJCLL(Task PNIEJJKFCEK, CancellationToken DMKDGAIEPFB, Func<CancellationToken, Task> CABCMGMLFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCD40", Offset = "0x7DDBF40", VA = "0x187DDCD40")]
	[AsyncStateMachine(typeof(JAABEMCMIGP))]
	public static Task EDBIFFNMOCH(Func<CancellationToken, Task> PNMMBEAJIIE, TimeSpan KMMOMBOBGDN, [Optional] CancellationToken DMKDGAIEPFB, [Optional] Action<OperationCanceledException>? BDCMAFLADOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F5F0", Offset = "0x3A0E7F0", VA = "0x183A0F5F0")]
	[AsyncStateMachine(typeof(JELMOGAGOGK<>))]
	public static Task<T> EDBIFFNMOCH<T>(Func<CancellationToken, Task<T>> PNMMBEAJIIE, TimeSpan KMMOMBOBGDN, [Optional] CancellationToken DMKDGAIEPFB, [Optional] Func<OperationCanceledException, T>? BDCMAFLADOM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE6B0", Offset = "0x7DDD8B0", VA = "0x187DDE6B0")]
	public static Task PDENEPHCFJC(params Task[] PGFEJBDLIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE1F0", Offset = "0x7DDD3F0", VA = "0x187DDE1F0")]
	public static Task PDENEPHCFJC(IEnumerable<Task> PGFEJBDLIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A0EA00", Offset = "0x3A0DC00", VA = "0x183A0EA00")]
	[AsyncStateMachine(typeof(JGMEFDLFDPL<>))]
	public static Task<IEnumerable<Task<T>>> AHNJBIPPGHL<T>(IEnumerable<Task<T>> PGFEJBDLIHI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F4C0", Offset = "0x3A0E6C0", VA = "0x183A0F4C0")]
	[AsyncStateMachine(typeof(PMBBKILECHI<, , >))]
	public static Task<(T1, T2, T3)> DGNBCGANPOH<T1, T2, T3>(Task<T1> KJJKJKAMLCM, Task<T2> ILPNEEKPPCB, Task<T3> PKPPHNAMNLJ) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F1E0", Offset = "0x3A0E3E0", VA = "0x183A0F1E0")]
	[AsyncStateMachine(typeof(BBMLFKMLFNA<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> DGNBCGANPOH<T1, T2, T3, T4, T5>(Task<T1> KJJKJKAMLCM, Task<T2> ILPNEEKPPCB, Task<T3> PKPPHNAMNLJ, Task<T4> CFJPMDONDNP, Task<T5> AAPDFNEILJG) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDB10", Offset = "0x7DDCD10", VA = "0x187DDDB10")]
	[AsyncStateMachine(typeof(FDDJFDHPCIK))]
	public static Task NHJKICMJGNP(Func<bool> CKBDGPAFKOM, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDC00", Offset = "0x7DDCE00", VA = "0x187DDDC00")]
	[AsyncStateMachine(typeof(IEOFKBLELAK))]
	public static Task NHJKICMJGNP(Func<bool> CKBDGPAFKOM, TimeSpan DBJJKKEBNPB, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD2F0", Offset = "0x7DDC4F0", VA = "0x187DDD2F0")]
	[AsyncStateMachine(typeof(DKPHFMCJNFM))]
	public static Task HIFNBIKLAOK(Func<bool> CKBDGPAFKOM, TimeSpan KMMOMBOBGDN, [Optional] CancellationToken HCELDNOKOAM, [Optional] Action<OperationCanceledException>? BDCMAFLADOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD1B0", Offset = "0x7DDC3B0", VA = "0x187DDD1B0")]
	[AsyncStateMachine(typeof(BMEABHODFBA))]
	public static Task HIFNBIKLAOK(Func<bool> CKBDGPAFKOM, TimeSpan KMMOMBOBGDN, TimeSpan DBJJKKEBNPB, [Optional] CancellationToken HCELDNOKOAM, [Optional] Action<OperationCanceledException>? BDCMAFLADOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCA60", Offset = "0x7DDBC60", VA = "0x187DDCA60")]
	[AsyncStateMachine(typeof(HKHAHGBHIJF))]
	public static Task APOLGCOHBLI(Func<bool> CKBDGPAFKOM, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DDC950", Offset = "0x7DDBB50", VA = "0x187DDC950")]
	[AsyncStateMachine(typeof(CMKGJEMNGIG))]
	public static Task APOLGCOHBLI(Func<bool> CKBDGPAFKOM, TimeSpan DBJJKKEBNPB, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD080", Offset = "0x7DDC280", VA = "0x187DDD080")]
	[AsyncStateMachine(typeof(DMJAACPIGMP))]
	public static Task FCAIHPGGONB(Func<bool> CKBDGPAFKOM, TimeSpan KMMOMBOBGDN, [Optional] CancellationToken HCELDNOKOAM, [Optional] Action<OperationCanceledException>? BDCMAFLADOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCF40", Offset = "0x7DDC140", VA = "0x187DDCF40")]
	[AsyncStateMachine(typeof(FEFAAIEHCCP))]
	public static Task FCAIHPGGONB(Func<bool> CKBDGPAFKOM, TimeSpan KMMOMBOBGDN, TimeSpan DBJJKKEBNPB, [Optional] CancellationToken HCELDNOKOAM, [Optional] Action<OperationCanceledException>? BDCMAFLADOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCC00", Offset = "0x7DDBE00", VA = "0x187DDCC00")]
	[Obsolete]
	[AsyncStateMachine(typeof(CDACFMPHALK))]
	public static Task CLBFKKLOPMD(this Task LDLKICLCOAG, Action NMONDGKMIEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A0EEF0", Offset = "0x3A0E0F0", VA = "0x183A0EEF0")]
	[AsyncStateMachine(typeof(KOGNKIDELEC<>))]
	[Obsolete]
	public static Task CLBFKKLOPMD<T>(this Task<T> LDLKICLCOAG, Action<T> NMONDGKMIEF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE070", Offset = "0x7DDD270", VA = "0x187DDE070")]
	private static void OADAHIGNMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DDDD10", Offset = "0x7DDCF10", VA = "0x187DDDD10")]
	public static bool NMJLKMNLKFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD990", Offset = "0x7DDCB90", VA = "0x187DDD990")]
	private static void MKJNPDMFKFH(SynchronizationContext MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE700", Offset = "0x7DDD900", VA = "0x187DDE700")]
	private static void PIKLPMPJENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCE70", Offset = "0x7DDC070", VA = "0x187DDCE70")]
	public static void EPIFMMJEBLL([Optional] string? BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD4D0", Offset = "0x7DDC6D0", VA = "0x187DDD4D0")]
	public static void IFHLEMAIGPH([Optional] string? BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD5C0", Offset = "0x7DDC7C0", VA = "0x187DDD5C0")]
	public static ACNINDHIJEJ KMGJGFIAOFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCCF0", Offset = "0x7DDBEF0", VA = "0x187DDCCF0")]
	public static ACNINDHIJEJ DGJBPCFAKCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE120", Offset = "0x7DDD320", VA = "0x187DDE120")]
	[AsyncStateMachine(typeof(PDNMLCOIFFC))]
	public static Task OEIFLGKEHJC(Func<Task> OOKJGLKPPPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CFBFBMEJALB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
	public CFBFBMEJALB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DGMIDEJJLKM
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3C00", Offset = "0x7DD2E00", VA = "0x187DD3C00")]
	public static bool OPEOBIGHPFN(this OHHLIEHJBIN KMNNIFIEFOE, DateTime BBGMMPBMNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3AE0", Offset = "0x7DD2CE0", VA = "0x187DD3AE0")]
	public static TimeSpan EKFEHJGPDGL(this OHHLIEHJBIN KMNNIFIEFOE, DateTime BBGMMPBMNLM)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class KNDALDBIDHF : OHHLIEHJBIN
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly OHHLIEHJBIN NDDGJHHDBNJ;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime BNEIPCBAKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA7C0", Offset = "0x7DD99C0", VA = "0x187DDA7C0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset NMLHBNBLIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA800", Offset = "0x7DD9A00", VA = "0x187DDA800", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KNDALDBIDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface OHHLIEHJBIN
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime BNEIPCBAKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset NMLHBNBLIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class MFLAOFACAFL
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long KBEOHGNOCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAEE0", Offset = "0x7DDA0E0", VA = "0x187DDAEE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long NCNJHGMNLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAD70", Offset = "0x7DD9F70", VA = "0x187DDAD70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double DGOLEKPGPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAF30", Offset = "0x7DDA130", VA = "0x187DDAF30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double MKKCJNAFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB070", Offset = "0x7DDA270", VA = "0x187DDB070")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double OFMPCMADBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAD20", Offset = "0x7DD9F20", VA = "0x187DDAD20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double KCBLFJDCMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAC00", Offset = "0x7DD9E00", VA = "0x187DDAC00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7DDADC0", Offset = "0x7DD9FC0", VA = "0x187DDADC0")]
	public static double GJJIGBHEGIG(long OFILIPFKAGH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAE50", Offset = "0x7DDA050", VA = "0x187DDAE50")]
	public static double HBLLODEGOPN(long OFILIPFKAGH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAF80", Offset = "0x7DDA180", VA = "0x187DDAF80")]
	public static double LHJCMOBHFLF(double LPPGHLCBJPB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAB70", Offset = "0x7DD9D70", VA = "0x187DDAB70")]
	public static long BCHIJPDMDDD(long ODIBCCLKMAC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAB60", Offset = "0x7DD9D60", VA = "0x187DDAB60")]
	public static long ACGPJEFEIBA(long OJBLMJBOBMK, long PKBBNGOLHKI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAC50", Offset = "0x7DD9E50", VA = "0x187DDAC50")]
	public static double CPKNODGIHLL(long OJBLMJBOBMK, long PKBBNGOLHKI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB010", Offset = "0x7DDA210", VA = "0x187DDB010")]
	public static double NKJIJHHPJFA(long OJBLMJBOBMK, long PKBBNGOLHKI)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class EBKFCPFKJBO : GGKEFBHOOFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly TimeSpan IMDDNNMBIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly System.Timers.Timer AGHDGMNHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TimeSpan KMMOMBOBGDN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan LLOHIMFEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4730", Offset = "0x7DD3930", VA = "0x187DD4730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? HOLBLFGFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4900", Offset = "0x7DD3B00", VA = "0x187DD4900")]
	[Preserve]
	public EBKFCPFKJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4960", Offset = "0x7DD3B60", VA = "0x187DD4960")]
	public EBKFCPFKJBO(TimeSpan KMMOMBOBGDN, [Optional] Action? IHJCPMHDNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7DD46A0", Offset = "0x7DD38A0", VA = "0x187DD46A0", Slot = "7")]
	public void MBLDJPNEDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4630", Offset = "0x7DD3830", VA = "0x187DD4630", Slot = "8")]
	public void JPGBNGNJLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4600", Offset = "0x7DD3800", VA = "0x187DD4600", Slot = "9")]
	public void HJEJKDBNPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x11579E0", Offset = "0x1156BE0", VA = "0x1811579E0")]
	private void ELNNGMBOGNH(object NIDPEFPJBOO, ElapsedEventArgs BBEGIINIEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD44D0", Offset = "0x7DD36D0", VA = "0x187DD44D0")]
	private static void DCKBJPEDHIC(TimeSpan AKPOADOBELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4560", Offset = "0x7DD3760", VA = "0x187DD4560", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CGDAAOOHDFB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string? MAKNAOCMPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string BOAMNMPIPFN;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x16B4C30", Offset = "0x16B3E30", VA = "0x1816B4C30")]
	public CGDAAOOHDFB(string CMDDDPOOGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4C97360", Offset = "0x4C96560", VA = "0x184C97360")]
	public CGDAAOOHDFB(string LHAEPBBBCAO, string CMDDDPOOGFO)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct HOMKGHPABMN : IEquatable<HOMKGHPABMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public uint COGPGLLOOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int INLDHIPGGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float EHLANLOMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public ushort NGAFKJAMEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public ushort LBJBKHMPPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short CBHLLPKOAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public short GJIKDGIKPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char FEMKHJIIAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char LOIOKHBKCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte OAJJDEEILFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte HMAAKDOLBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte HHCIKHKDJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte HMNOBHIMAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool KFMKAIEEDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool PBMADDDMAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool OGJLEDALINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool MKLAIPJLHLC;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A8E0", Offset = "0x1E79AE0", VA = "0x181E7A8E0")]
	public static HOMKGHPABMN EMNACJEJFAD(uint CMFPMKKHMPA)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A8E0", Offset = "0x1E79AE0", VA = "0x181E7A8E0")]
	public static HOMKGHPABMN GMFNDKCOJGO(int OHFNCGNAANO)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7DD72A0", Offset = "0x7DD64A0", VA = "0x187DD72A0")]
	public static HOMKGHPABMN IBNOJOIHCCD(float KJBHHENNFBB)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7200", Offset = "0x7DD6400", VA = "0x187DD7200")]
	public static HOMKGHPABMN LKHFKFMDEHN(byte JPFBLCGMOMI, byte PBFPPGIPFNO, byte FEJGMCIFNJM, byte MDMKBINCNJF)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7200", Offset = "0x7DD6400", VA = "0x187DD7200")]
	public static HOMKGHPABMN EBPOMNNAMLM(bool FCGEFNEPKLN, bool DGCNABELBNN, bool JMIOFOFFKDK, bool BJEDDAGAECA)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7200", Offset = "0x7DD6400", VA = "0x187DD7200")]
	public static HOMKGHPABMN NAHOMOCJKHD(byte ALMLAABDNCP, byte JLEALMOIKPP, byte LIPHFMLDJPH, byte NBCEGEFDKGI)
	{
		return default(HOMKGHPABMN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2175BD0", Offset = "0x2174DD0", VA = "0x182175BD0")]
	public static bool NDBPPCEOMJH(HOMKGHPABMN OGNDHFPFEOJ, HOMKGHPABMN ABBPAGLDFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2175BB0", Offset = "0x2174DB0", VA = "0x182175BB0", Slot = "4")]
	public bool Equals(HOMKGHPABMN FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7220", Offset = "0x7DD6420", VA = "0x187DD7220", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x12D61D0", Offset = "0x12D53D0", VA = "0x1812D61D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD72B0", Offset = "0x7DD64B0", VA = "0x187DD72B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct GKHBIONDNEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ulong BCOMOGEKGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public long ECJIMFGCHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public double IDAANJCAICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public uint ELHJHGGMALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public uint KCBNGGLCGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public int BAGAOGCBEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public int JIODEKAEHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float COLGCMLFHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float EBIJPAGPOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public ushort NGAFKJAMEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public ushort LBJBKHMPPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public ushort IMIGEGABLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public ushort CJKKLNLFEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public short CBHLLPKOAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public short GJIKDGIKPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public short MMLBFJBJCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public short ADAGCFABJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public char FEMKHJIIAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public char LOIOKHBKCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public char PPKPICECBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public char JDKAJIEPHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public byte OAJJDEEILFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public byte HMAAKDOLBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public byte HHCIKHKDJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public byte HMNOBHIMAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public byte FPJDMLKNKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public byte IIMLOALIKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte FPOCKCAFKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte BCONJDAIAIP;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static GKHBIONDNEC OIKMHICCLEP(long BEMMMNHGFMB)
	{
		return default(GKHBIONDNEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD66E0", Offset = "0x7DD58E0", VA = "0x187DD66E0")]
	public static GKHBIONDNEC OIKMHICCLEP(byte JPFBLCGMOMI, byte PBFPPGIPFNO, byte FEJGMCIFNJM, byte MDMKBINCNJF, byte JNHKNGAPBPJ, byte PFDDAMNNMLA, byte DGPFCOGMKMM, byte KOAMEJJEEMP)
	{
		return default(GKHBIONDNEC);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct BFBNGFFAIFF : IEquatable<BFBNGFFAIFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte NHOPOKKFHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool MIACDNHNBEG;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2E48E40", Offset = "0x2E48040", VA = "0x182E48E40")]
	public static BFBNGFFAIFF LKHFKFMDEHN(byte GMCLMNLDPFF)
	{
		return default(BFBNGFFAIFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2E48E40", Offset = "0x2E48040", VA = "0x182E48E40")]
	public static BFBNGFFAIFF EBPOMNNAMLM(bool OLNDNEIBJOI)
	{
		return default(BFBNGFFAIFF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2F50", Offset = "0x7DD2150", VA = "0x187DD2F50")]
	public static bool NDBPPCEOMJH(BFBNGFFAIFF OGNDHFPFEOJ, BFBNGFFAIFF ABBPAGLDFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DF70", Offset = "0x6D3D170", VA = "0x186D3DF70", Slot = "4")]
	public bool Equals(BFBNGFFAIFF FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2EB0", Offset = "0x7DD20B0", VA = "0x187DD2EB0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2F40", Offset = "0x7DD2140", VA = "0x187DD2F40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2F60", Offset = "0x7DD2160", VA = "0x187DD2F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GGBNDFALNLL<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly T ANELCFKOJBP;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4A63C00", Offset = "0x4A62E00", VA = "0x184A63C00")]
	public GGBNDFALNLL(T FNECIIEKCKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class GKFEKMMKBBP
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x36725C0", Offset = "0x36717C0", VA = "0x1836725C0")]
	public static IEnumerable<T> PENCOEHMGFJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static T[] KFFKBDILCBH<T>(params T[] MAEAKHOKPNA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static IEnumerable<T> KMNJEILOKGI<T>(params T[] MAEAKHOKPNA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3615CF0", Offset = "0x3614EF0", VA = "0x183615CF0")]
	public static HashSet<T> LEONKHFDPBA<T>(params T[] MAEAKHOKPNA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3821850", Offset = "0x3820A50", VA = "0x183821850")]
	public static KeyValuePair<TKey, TValue> GNDDCIMAIFK<TKey, TValue>([In] TKey AGBHGDFILGO, [In] TValue MLCDCHNOCFI) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3615CF0", Offset = "0x3614EF0", VA = "0x183615CF0")]
	public static List<T> DGGEMPMLMFC<T>(IEnumerable<T> FOLAIIIFFFP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MIMDNFHLCKA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string AHHFJLLEAML;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
	public MIMDNFHLCKA(string HLCHGMIKLCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public delegate object KGHEKJMENFB<T>([In] T EFGHMCKPMHN);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object NIMIBCOALNB<T>(T EFGHMCKPMHN);
[Cpp2IlInjected.Token(Token = "0x2000068")]
[IHBPJECEBJC]
public delegate string MCOMMCPKONC(string AKCEGHPGLOG, string? GNKOKDLDGPC, bool HFBPOAJMIAG);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[IHBPJECEBJC]
public delegate void HLGJCMCHAIC(string BDAAPBJEHGD);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[IHBPJECEBJC]
public delegate void EOHLODICHHC(Exception MJPFDOAJBLF);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public delegate object EIAHHHGIHBJ();
[Cpp2IlInjected.Token(Token = "0x200006C")]
[IHBPJECEBJC]
public delegate bool FLBCHLLNDPO();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[IHBPJECEBJC]
public delegate string GDCCJEBEMON(object DBCLNEGBNLN);
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AttributeUsage(AttributeTargets.Enum)]
public class POLNAPEKNJG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
	public POLNAPEKNJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class JMINLDKAPPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct OCFCADFHEOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB5B0", Offset = "0x7DDA7B0", VA = "0x187DDB5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DDBEA0", Offset = "0x7DDB0A0", VA = "0x187DDBEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly TimerCallback FNOMMPEKEBN;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly Action<object?> HCMAAIKMMIM;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA110", Offset = "0x7DD9310", VA = "0x187DDA110")]
	public static Task<bool> KEALJPMKEFM(int HIOMOPOMGPF, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9FE0", Offset = "0x7DD91E0", VA = "0x187DD9FE0")]
	[AsyncStateMachine(typeof(OCFCADFHEOD))]
	private static Task<bool> IIFIFFJMMLE(int HIOMOPOMGPF, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA410", Offset = "0x7DD9610", VA = "0x187DDA410")]
	private static void NGOGCIPJFEE(object? HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9F50", Offset = "0x7DD9150", VA = "0x187DD9F50")]
	private static void HMOFKAOMJJF(object? HPAPEOOKLIH)
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
