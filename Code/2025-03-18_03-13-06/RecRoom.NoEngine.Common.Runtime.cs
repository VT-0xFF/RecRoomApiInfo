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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7710090", Offset = "0x770F290", VA = "0x187710090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MMAPKALCBFM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x770EEB0", Offset = "0x770E0B0", VA = "0x18770EEB0")]
	public static string CJNLBIKKJAP(this Encoding GHEAIIDOIKB, [In] ReadOnlySequence<byte> GJKPEEJCIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35A66E0", Offset = "0x35A58E0", VA = "0x1835A66E0")]
	private static void CBKFFPGIAHA<T>(this ReadOnlySequence<T> GKFEAOLLEBA, [Out] ReadOnlySpan<T> IPCIEPJLFDJ, [Out] SequencePosition ABBANNGAIGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class AJDGNGKPDAC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7704530", Offset = "0x7703730", VA = "0x187704530")]
	public AJDGNGKPDAC(bool MGDNPABLGJI, string KGEMFKFMBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x17DAB30", Offset = "0x17D9D30", VA = "0x1817DAB30")]
	public AJDGNGKPDAC(bool MGDNPABLGJI, params string[] JBAJLEMLMHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KLANNHBOJHL
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MDDIGMFIJPM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DLNOFHKMGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOIHMEKBPLI(string MBDBONINAPC, double OMFJNFBDJCA, [Optional] string? FGPFIHCEFNP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EJIBMBADIHL : MOMOCGPMKKG, EFBNEIOOJKJ, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int BLGIELKMEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> OLHLMMEKEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double CDNAEODPMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double PLIBGNKHNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double NHHEMFHDGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int JEPEHDODNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double FNBDKHELJDO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KEOPBDLHPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x980830", Offset = "0x97FA30", VA = "0x180980830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double OAKOHPICOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7706CB0", Offset = "0x7705EB0", VA = "0x187706CB0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double IGDPMPOJLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x465CC10", Offset = "0x465BE10", VA = "0x18465CC10", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double NPLAJLEGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x255BA00", Offset = "0x255AC00", VA = "0x18255BA00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7706D10", Offset = "0x7705F10", VA = "0x187706D10")]
	public EJIBMBADIHL(int GKFPFEKCBJJ, double FNBDKHELJDO = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7706B80", Offset = "0x7705D80", VA = "0x187706B80", Slot = "7")]
	public void GMLBDIDIEAB(double HBMPJOCKNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7706B10", Offset = "0x7705D10", VA = "0x187706B10", Slot = "8")]
	public void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7706A10", Offset = "0x7705C10", VA = "0x187706A10", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HFJIGFNJJNC : MOMOCGPMKKG, EFBNEIOOJKJ, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long IPBKHOJKHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double HPAPDJDCJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double AOFGBOBOHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double BHOIAHEECEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double JPEOEIIJJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double CDNAEODPMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double PLIBGNKHNME;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double IGDPMPOJLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E520", Offset = "0x6A6D720", VA = "0x186A6E520", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NPLAJLEGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E550", Offset = "0x6A6D750", VA = "0x186A6E550", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double OGFOCKECPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E510", Offset = "0x6A6D710", VA = "0x186A6E510")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double OAKOHPICOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BEEC90", Offset = "0x2BEDE90", VA = "0x182BEEC90", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77088F0", Offset = "0x7707AF0", VA = "0x1877088F0", Slot = "10")]
	public virtual void GMLBDIDIEAB(double HBMPJOCKNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x77088B0", Offset = "0x7707AB0", VA = "0x1877088B0", Slot = "11")]
	public virtual void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7708840", Offset = "0x7707A40", VA = "0x187708840", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7708A10", Offset = "0x7707C10", VA = "0x187708A10")]
	public HFJIGFNJJNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PBCABNAAAAC : HFJIGFNJJNC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double DCMPCAKNNGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E4D0", Offset = "0x6A6D6D0", VA = "0x186A6E4D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E4B0", Offset = "0x6A6D6B0", VA = "0x186A6E4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7710210", Offset = "0x770F410", VA = "0x187710210", Slot = "10")]
	public override void GMLBDIDIEAB(double HBMPJOCKNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77101D0", Offset = "0x770F3D0", VA = "0x1877101D0", Slot = "11")]
	public override void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7708A10", Offset = "0x7707C10", VA = "0x187708A10")]
	public PBCABNAAAAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MOMOCGPMKKG : EFBNEIOOJKJ, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double OAKOHPICOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double IGDPMPOJLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double NPLAJLEGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LJOOGJPEODL : EFBNEIOOJKJ, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double GPLAPMNHILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double BFGIIBMHCOD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x770DC40", Offset = "0x770CE40", VA = "0x18770DC40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x766D040", Offset = "0x766C240", VA = "0x18766D040", Slot = "4")]
	public void GMLBDIDIEAB(double HBMPJOCKNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x770DCA0", Offset = "0x770CEA0", VA = "0x18770DCA0", Slot = "5")]
	public void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x770DC50", Offset = "0x770CE50", VA = "0x18770DC50", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public LJOOGJPEODL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EFBNEIOOJKJ : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMLBDIDIEAB(double HBMPJOCKNNL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DICECPNPBPH();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MMOIGBMKBPD : EFBNEIOOJKJ, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double OMFJNFBDJCA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4187F60", Offset = "0x4187160", VA = "0x184187F60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E067C0", Offset = "0x4E059C0", VA = "0x184E067C0", Slot = "4")]
	public void GMLBDIDIEAB(double HBMPJOCKNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x770F4B0", Offset = "0x770E6B0", VA = "0x18770F4B0", Slot = "5")]
	public void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x770F460", Offset = "0x770E660", VA = "0x18770F460", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public MMOIGBMKBPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OADKFCAHKFH<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> EEHBAOKPBDH(CancellationToken KPIINMODKFJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OPDFFPIMNEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public OADKFCAHKFH<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public EEHBAOKPBDH taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x501D9B0", Offset = "0x501CBB0", VA = "0x18501D9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x501EA50", Offset = "0x501DC50", VA = "0x18501EA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource IFEDHDENNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? NPGABPJCEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? AGBMNJCJFCF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4F435A0", Offset = "0x4F427A0", VA = "0x184F435A0")]
	[AsyncStateMachine(typeof(OADKFCAHKFH<>.OPDFFPIMNEC))]
	public Task<TResult> GKDBIIKKOCH(EEHBAOKPBDH OGIEIDIOPAE, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4F43530", Offset = "0x4F42730", VA = "0x184F43530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4F436E0", Offset = "0x4F428E0", VA = "0x184F436E0")]
	public OADKFCAHKFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CFEIPLIFCBG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> GOBAIJDLHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T CADNOMLIGCM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x476E1F0", Offset = "0x476D3F0", VA = "0x18476E1F0")]
	public CFEIPLIFCBG([In] T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x59FD5A0", Offset = "0x59FC7A0", VA = "0x1859FD5A0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x59FD8B0", Offset = "0x59FCAB0", VA = "0x1859FD8B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x59FD990", Offset = "0x59FCB90", VA = "0x1859FD990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class MKOLNJNKGLN
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x32C8ED0", Offset = "0x32C80D0", VA = "0x1832C8ED0")]
	public static CFEIPLIFCBG<T> PEFMILKIAFF<T>([In] T OMFJNFBDJCA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OMBAEHELHGC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x77101A0", Offset = "0x770F3A0", VA = "0x1877101A0")]
	public static void DOKNNOCCBIA(this CancellationTokenSource IFEDHDENNPG, bool AEFNFFMJPOJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class CCFGIEANGJL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
	public CCFGIEANGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FMCICLBDIIN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
	public FMCICLBDIIN(string HDJFDKNLNEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class KCLFKCPKJFA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3522000", Offset = "0x3521200", VA = "0x183522000")]
	public static BCDPHFMLIHC JNMNDOKDGDK<T>()
	{
		return default(BCDPHFMLIHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35221D0", Offset = "0x35213D0", VA = "0x1835221D0")]
	public static BCDPHFMLIHC MCKDMPCGCDN<T>([CallerMemberName] string MBDFMCIDAOB = "") where T : notnull
	{
		return default(BCDPHFMLIHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3521F80", Offset = "0x3521180", VA = "0x183521F80")]
	public static BCDPHFMLIHC JNMNDOKDGDK<T>(this T JEBOOCGPANP) where T : notnull
	{
		return default(BCDPHFMLIHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3522320", Offset = "0x3521520", VA = "0x183522320")]
	public static BCDPHFMLIHC NANAKECOHNN<T>(this T JEBOOCGPANP, [CallerMemberName] string MBDFMCIDAOB = "") where T : notnull
	{
		return default(BCDPHFMLIHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3522270", Offset = "0x3521470", VA = "0x183522270")]
	public static BCDPHFMLIHC MCKDMPCGCDN<T>(this T NAELBAPCKEH, [CallerMemberName] string MBDFMCIDAOB = "") where T : notnull
	{
		return default(BCDPHFMLIHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x770CB90", Offset = "0x770BD90", VA = "0x18770CB90")]
	public static BCDPHFMLIHC MCKDMPCGCDN(string IALAGLJGHJO, [CallerMemberName] string MBDFMCIDAOB = "")
	{
		return default(BCDPHFMLIHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x770CC10", Offset = "0x770BE10", VA = "0x18770CC10")]
	public static string OIHKGBAFBFJ(this object NAELBAPCKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool FHOCDJIBDDE();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CCFGIEANGJL]
public delegate long NDEGNBBKHLP();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FFBFIOFNNFP
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static LMCGCACIAGP KFMCJOEKALB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static LMCGCACIAGP IPFBNPFKMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x77075F0", Offset = "0x77067F0", VA = "0x1877075F0")]
		get
		{
			return default(LMCGCACIAGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static NJFMBEPMDGP HFJCJFIDMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7707270", Offset = "0x7706470", VA = "0x187707270")]
		get
		{
			return default(NJFMBEPMDGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static BPMBEBKDPOB OPLBJHEMOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7707180", Offset = "0x7706380", VA = "0x187707180")]
		get
		{
			return default(BPMBEBKDPOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool OMKOCBJABHI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x77074B0", Offset = "0x77066B0", VA = "0x1877074B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7706F10", Offset = "0x7706110", VA = "0x187706F10")]
	public static void CFBEOFMICPK([In] LMCGCACIAGP HJGGFMCIAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x77072C0", Offset = "0x77064C0", VA = "0x1877072C0")]
	public static void IPKFDHIOJFD(string DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7707520", Offset = "0x7706720", VA = "0x187707520")]
	public static void LOMKKPGBMOB(string DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x343BC40", Offset = "0x343AE40", VA = "0x18343BC40")]
	public static void LOMKKPGBMOB<T>(T DLGGINKGFFM, HKHBAAHOMEA<T> DCEACFEGBDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7707410", Offset = "0x7706610", VA = "0x187707410")]
	public static void KJMCJKCLCJP(Exception GMEDNHNLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7707390", Offset = "0x7706590", VA = "0x187707390")]
	public static void JKFFCNDMPED(string MBDFMCIDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7706EA0", Offset = "0x77060A0", VA = "0x187706EA0")]
	public static void BPCGPAGDHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7707640", Offset = "0x7706840", VA = "0x187707640")]
	public static string OIHKGBAFBFJ(object ONELFPFEALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7706E30", Offset = "0x7706030", VA = "0x187706E30")]
	public static long BDLJKBFDLOJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x77071D0", Offset = "0x77063D0", VA = "0x1877071D0")]
	public static bool FFPKNIECDJF(bool FPPMNPIKPAP, string DCEACFEGBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x77070B0", Offset = "0x77062B0", VA = "0x1877070B0")]
	public static double CNIGDPHMKDH()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct LMCGCACIAGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly NJFMBEPMDGP HFJCJFIDMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly BPMBEBKDPOB OPLBJHEMOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly AGFIJKALKCP JCONNMAMJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NDEGNBBKHLP GHGJEAIPDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly BEFKEOACEKH BKOJIMKMKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly FHOCDJIBDDE FLNFCLIIHDN;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly AGFIJKALKCP KAEDAGJFGFN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly NDEGNBBKHLP PJGJKLJCICK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly BEFKEOACEKH NFDFKLFGPGD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly FHOCDJIBDDE NDOHHDCLHBH;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly LMCGCACIAGP CENLOHBLGNG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KHBFGBFEAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x770DDF0", Offset = "0x770CFF0", VA = "0x18770DDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x770E640", Offset = "0x770D840", VA = "0x18770E640")]
	public LMCGCACIAGP([In] NJFMBEPMDGP EPOAELJAKEM, [In] BPMBEBKDPOB BCJKJDBCLMB, AGFIJKALKCP OIAOFIINACO, NDEGNBBKHLP CHLKCFCMPKO, BEFKEOACEKH OGFONDFEFFB, FHOCDJIBDDE IKPGHMEBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x770DCB0", Offset = "0x770CEB0", VA = "0x18770DCB0")]
	private static string BKNPJNOBDFN(object ONELFPFEALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10")]
	private static long PNCKJKKFLBB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	private static string ENONGCFKEAG(string BKOPBBHMJGH, string? OKHEDFBAINB, bool BCHADAFBOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
	private static bool ABAOGNIGHPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x770DCF0", Offset = "0x770CEF0", VA = "0x18770DCF0")]
	private static LMCGCACIAGP EGDBFFAJBKH()
	{
		return default(LMCGCACIAGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JCIJEJLJKMK
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDACIDHHEMB KJDMAOPKNEK();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EDACIDHHEMB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CMJCGBCLKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFFOABONJJM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KIIJBEBJMFN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBLDBPFONFF([In] T LDKNLBHIGFL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void PJJGLELHLCK<T>([In] T DLGGINKGFFM);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct NMNBPCLDDOM<T> : IEquatable<NMNBPCLDDOM<T>>, KIIJBEBJMFN<NMNBPCLDDOM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T CADNOMLIGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int PGEMEJBADFN;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25E0D40", Offset = "0x25DFF40", VA = "0x1825E0D40")]
	public NMNBPCLDDOM([In] T OMFJNFBDJCA, int KOOLKCPAFBB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4E4D770", Offset = "0x4E4C970", VA = "0x184E4D770")]
	public static bool GJNOMHNHJKL([In] NMNBPCLDDOM<T> MGBGOAGHGOJ, [In] NMNBPCLDDOM<T> FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4E4D420", Offset = "0x4E4C620", VA = "0x184E4D420", Slot = "4")]
	public bool Equals(NMNBPCLDDOM<T> LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x47742D0", Offset = "0x47734D0", VA = "0x1847742D0", Slot = "0")]
	public override bool Equals(object LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4E4D390", Offset = "0x4E4C590", VA = "0x184E4D390")]
	public bool EBLDBPFONFF([In] NMNBPCLDDOM<T> LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4E4DBD0", Offset = "0x4E4CDD0", VA = "0x184E4DBD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4E4F010", Offset = "0x4E4E210", VA = "0x184E4F010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4E4E320", Offset = "0x4E4D520", VA = "0x184E4E320")]
	public void LMCCANMANFL([Out] T OMFJNFBDJCA, [Out] int KOOLKCPAFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4E4EC20", Offset = "0x4E4DE20", VA = "0x184E4EC20")]
	public (T, int) MAAFBPJNKJH()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4E4D540", Offset = "0x4E4C740", VA = "0x184E4D540", Slot = "5")]
	private bool GJLJEOJAKHB([In] NMNBPCLDDOM<T> LDKNLBHIGFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LGAEJPAAOOP
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x35303C0", Offset = "0x352F5C0", VA = "0x1835303C0")]
	public static NMNBPCLDDOM<T> PEFMILKIAFF<T>([In] T OMFJNFBDJCA, int KOOLKCPAFBB) where T : notnull
	{
		return default(NMNBPCLDDOM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HJKLPKIDPOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x34B7340", Offset = "0x34B6540", VA = "0x1834B7340")]
	public static bool EBLDBPFONFF<T, U>([In] T NAELBAPCKEH, [In] U ONELFPFEALD) where T : notnull, KIIJBEBJMFN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult DGMGEKNALFP<T, out TResult>([In] T DLGGINKGFFM);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MOODNHIFOBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan FIFMAEEPLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? PJFEFPGPIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHDCILGNCOK();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDPAFPINIJD();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIJAHPJBMHM();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct NJFMBEPMDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly HANMBBDBLLA IJKFOEBKEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly JGNGNAEJKFK NFKKFCJKCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly HANMBBDBLLA FIDNOMHPBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly JGNGNAEJKFK ELENHGGCGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly HANMBBDBLLA AHHFCPCDJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly JGNGNAEJKFK AHKKDAJHDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly FEBNDAJCNBN MNGPKPIKCOL;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly HANMBBDBLLA GAKBLINHFDL;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly JGNGNAEJKFK NEGFBAGPIDC;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly HANMBBDBLLA IOMGLICLFHO;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly JGNGNAEJKFK IDPHOLJNGLP;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly HANMBBDBLLA BOMBLLOOIJD;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JGNGNAEJKFK JNDJOBJBPIN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly FEBNDAJCNBN PMEOJAPKJHL;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly NJFMBEPMDGP CENLOHBLGNG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly HANMBBDBLLA BNEPPILCCBP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KHBFGBFEAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x770F6D0", Offset = "0x770E8D0", VA = "0x18770F6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xC5F2C0", Offset = "0xC5E4C0", VA = "0x180C5F2C0")]
	public NJFMBEPMDGP(HANMBBDBLLA EJFIILJKNGF, JGNGNAEJKFK FFJELCGDNLB, HANMBBDBLLA JPNIAMFLBCN, JGNGNAEJKFK DNJDFFPLLLP, HANMBBDBLLA MOKOAANANNK, JGNGNAEJKFK DGIJPKJGAIJ, FEBNDAJCNBN EHMOEBPEMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
	private static bool JGLAGHNIFJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private static void MDPAIBNAIHM(string DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
	private static bool AJJJMDPKFBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private static void PGLLGNKJCOO(string DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
	private static bool BJONKKCOIHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private static void NDKLNKAEMIN(string DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private static void KAKKAKDFHHD(Exception GMEDNHNLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x770F4C0", Offset = "0x770E6C0", VA = "0x18770F4C0")]
	private static NJFMBEPMDGP EGDBFFAJBKH()
	{
		return default(NJFMBEPMDGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0")]
	private static bool PMDJODLNDKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x770F8B0", Offset = "0x770EAB0", VA = "0x18770F8B0")]
	public void IPKFDHIOJFD(object DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x770F920", Offset = "0x770EB20", VA = "0x18770F920")]
	public void JDDNCEBMKIO(object DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x770F990", Offset = "0x770EB90", VA = "0x18770F990")]
	public void LOMKKPGBMOB(object DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC5DBD0", Offset = "0xC5CDD0", VA = "0x180C5DBD0")]
	public void KJMCJKCLCJP(Exception GMEDNHNLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x770FA00", Offset = "0x770EC00", VA = "0x18770FA00")]
	public void LOMKKPGBMOB(NALHAEHOCBH DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3610FB0", Offset = "0x36101B0", VA = "0x183610FB0")]
	public void LOMKKPGBMOB<T>(T DLGGINKGFFM, HKHBAAHOMEA<T> DCEACFEGBDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3610C70", Offset = "0x360FE70", VA = "0x183610C70")]
	public void IPKFDHIOJFD<T>([In] T DLGGINKGFFM, PLCFDPHJIKN<T> DCEACFEGBDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3610E10", Offset = "0x3610010", VA = "0x183610E10")]
	public void LOMKKPGBMOB<T>([In] T DLGGINKGFFM, PLCFDPHJIKN<T> DCEACFEGBDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x770F600", Offset = "0x770E800", VA = "0x18770F600")]
	public bool FFPKNIECDJF(bool FPPMNPIKPAP, string DCEACFEGBDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct BCDPHFMLIHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string CADNOMLIGCM;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	public BCDPHFMLIHC(string OMFJNFBDJCA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
	public static string AJAOLMPMCKD([In] BCDPHFMLIHC NAELBAPCKEH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2095D30", Offset = "0x2094F30", VA = "0x182095D30")]
	public static BCDPHFMLIHC AJAOLMPMCKD(string LDKNLBHIGFL)
	{
		return default(BCDPHFMLIHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7704AB0", Offset = "0x7703CB0", VA = "0x187704AB0")]
	public string PMGEFPADPPC(string IBICKAMBFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x77049D0", Offset = "0x7703BD0", VA = "0x1877049D0")]
	public string KGMOIMIKKIL(object OFDHKBOMHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class KDPJIIBNIOJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
	public KDPJIIBNIOJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct OJADAPCHIGK : IEquatable<OJADAPCHIGK>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "4")]
	public bool Equals(OJADAPCHIGK LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7710110", Offset = "0x770F310", VA = "0x187710110", Slot = "0")]
	public override bool Equals(object LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7710160", Offset = "0x770F360", VA = "0x187710160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7710170", Offset = "0x770F370", VA = "0x187710170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CFNIPKDPJMF("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct KKDJJBAIPEC<T> : IEquatable<KKDJJBAIPEC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T CADNOMLIGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool DEJCFMCMNPM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool KACKIPIJIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4A97590", Offset = "0x4A96790", VA = "0x184A97590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4A97ED0", Offset = "0x4A970D0", VA = "0x184A97ED0")]
	public KKDJJBAIPEC([In] T OMFJNFBDJCA, bool KKPONNJPDGG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4A966F0", Offset = "0x4A958F0", VA = "0x184A966F0")]
	public static bool GJNOMHNHJKL([In] KKDJJBAIPEC<T> MGBGOAGHGOJ, [In] KKDJJBAIPEC<T> FCFMBBJABHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4A95F20", Offset = "0x4A95120", VA = "0x184A95F20", Slot = "4")]
	public bool Equals(KKDJJBAIPEC<T> LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4A95B10", Offset = "0x4A94D10", VA = "0x184A95B10", Slot = "0")]
	public override bool Equals(object? LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4A96E40", Offset = "0x4A96040", VA = "0x184A96E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A97840", Offset = "0x4A96A40", VA = "0x184A97840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class OKJKKBCFMIC
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3654840", Offset = "0x3653A40", VA = "0x183654840")]
	public static KKDJJBAIPEC<T> AGNHOFLCPEG<T>([In] T OMFJNFBDJCA) where T : notnull
	{
		return default(KKDJJBAIPEC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3654C50", Offset = "0x3653E50", VA = "0x183654C50")]
	public static KKDJJBAIPEC<T?> OEMNLMEOAGO<T>()
	{
		return default(KKDJJBAIPEC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3654A80", Offset = "0x3653C80", VA = "0x183654A80")]
	public static bool DGEKBIAPLDA<T>([In] this KKDJJBAIPEC<T> CIFGPEOEMID, [Out][NotNullWhen(true)] T OMFJNFBDJCA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3654A40", Offset = "0x3653C40", VA = "0x183654A40")]
	public static bool DGEKBIAPLDA<T>([In] this KKDJJBAIPEC<T> CIFGPEOEMID, [Out][NotNullWhen(true)] T OMFJNFBDJCA, [Out] KKDJJBAIPEC<T> MBCLMNPGAKK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3654AB0", Offset = "0x3653CB0", VA = "0x183654AB0")]
	public static T? FFDKMIIOHHE<T>([In] this KKDJJBAIPEC<T> CIFGPEOEMID, T? OGPHJJMKHNA)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3654910", Offset = "0x3653B10", VA = "0x183654910")]
	public static bool CMHMELOFAJI<T>([In] this KKDJJBAIPEC<T> CIFGPEOEMID, T OMFJNFBDJCA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class PPHJNOJLEKA
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3679410", Offset = "0x3678610", VA = "0x183679410")]
	public static T APCMPLPCEDK<T>([In] this KKDJJBAIPEC<T> CIFGPEOEMID) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BPMBEBKDPOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr JKFFCNDMPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr BPCGPAGDHMI;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr NJIFNCOJCBD;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr EPGMAAOIANG;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly BPMBEBKDPOB CENLOHBLGNG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool KHBFGBFEAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7705960", Offset = "0x7704B60", VA = "0x187705960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
	public BPMBEBKDPOB(IntPtr DAKCMLFEJIO, IntPtr CHCKIIJBNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private static void PABPLHBIFIJ(string MBDFMCIDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private static void EILGHNFIPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x77058D0", Offset = "0x7704AD0", VA = "0x1877058D0")]
	private static BPMBEBKDPOB EGDBFFAJBKH()
	{
		return default(BPMBEBKDPOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct LNODNMKAKPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr MHKNFLPDLMF;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
	private LNODNMKAKPE(IntPtr CHCKIIJBNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x770E6F0", Offset = "0x770D8F0", VA = "0x18770E6F0")]
	public void GNPGDFFJFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x770E710", Offset = "0x770D910", VA = "0x18770E710")]
	public static LNODNMKAKPE PEFMILKIAFF(string MBDFMCIDAOB)
	{
		return default(LNODNMKAKPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x25BCDF0", Offset = "0x25BBFF0", VA = "0x1825BCDF0")]
	public static LNODNMKAKPE PEFMILKIAFF([In] BPMBEBKDPOB BCJKJDBCLMB, string MBDFMCIDAOB)
	{
		return default(LNODNMKAKPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x25BD0C0", Offset = "0x25BC2C0", VA = "0x1825BD0C0")]
	public static LNODNMKAKPE PEFMILKIAFF([In] BPMBEBKDPOB BCJKJDBCLMB, Func<string> MBDFMCIDAOB)
	{
		return default(LNODNMKAKPE);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JGINPKAFLIC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate bool ANOFEJLJKEJ<in TInput, TResult>(TInput GEDAGNGPIPL, [Out] TResult CMLOHOMLNDL);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class GEAMKMMBEIP : JCIJEJLJKMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class CMKAIDLKKHM : EDACIDHHEMB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly CMKAIDLKKHM JLGHKLNHGNO;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool CMJCGBCLKGA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x7705C50", Offset = "0x7704E50", VA = "0x187705C50", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7705CB0", Offset = "0x7704EB0", VA = "0x187705CB0", Slot = "6")]
			public void OnCompleted(Action AEDLOEEBJMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
			public void LFFOABONJJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public CMKAIDLKKHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly GEAMKMMBEIP JLGHKLNHGNO;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		private GEAMKMMBEIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7707880", Offset = "0x7706A80", VA = "0x187707880", Slot = "4")]
		public EDACIDHHEMB KJDMAOPKNEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class AGCADHBHMNM : JCIJEJLJKMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private sealed class CJHLLOCKDCH : EDACIDHHEMB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly CJHLLOCKDCH JLGHKLNHGNO;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool CMJCGBCLKGA
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x7705B70", Offset = "0x7704D70", VA = "0x187705B70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7705B90", Offset = "0x7704D90", VA = "0x187705B90", Slot = "6")]
			public void OnCompleted(Action AEDLOEEBJMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
			public void LFFOABONJJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public CJHLLOCKDCH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly AGCADHBHMNM JLGHKLNHGNO;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		private AGCADHBHMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7704470", Offset = "0x7703670", VA = "0x187704470", Slot = "4")]
		public EDACIDHHEMB KJDMAOPKNEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class CPHKEDNEJNN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CPHKEDNEJNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5891B30", Offset = "0x5890D30", VA = "0x185891B30")]
		internal void DMNJHELNAAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class LEMPDKOABBG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LEMPDKOABBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4B274B0", Offset = "0x4B266B0", VA = "0x184B274B0")]
		internal void DPKCIAJDEPM(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MHIFOAJKBEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x770EA30", Offset = "0x770DC30", VA = "0x18770EA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct BJFMLKGKPNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7705400", Offset = "0x7704600", VA = "0x187705400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct CLIJPHIMAHN<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3D80", Offset = "0x5CE2F80", VA = "0x185CE3D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3EF0", Offset = "0x5CE30F0", VA = "0x185CE3EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct EAFFPNCIFJL<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x40D2A60", Offset = "0x40D1C60", VA = "0x1840D2A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x40D2E90", Offset = "0x40D2090", VA = "0x1840D2E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct PBCJCKBPMPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7710340", Offset = "0x770F540", VA = "0x187710340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7710550", Offset = "0x770F750", VA = "0x187710550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BAMKCOHKCHN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BAMKCOHKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5891B30", Offset = "0x5890D30", VA = "0x185891B30")]
		internal void LMBAHMHHDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5891B90", Offset = "0x5890D90", VA = "0x185891B90")]
		internal void OMFEAAFEAKA(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JAALIJKPFPL<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public ANOFEJLJKEJ<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4952340", Offset = "0x4951540", VA = "0x184952340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4952A50", Offset = "0x4951C50", VA = "0x184952A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct GFADIOPCOML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7707940", Offset = "0x7706B40", VA = "0x187707940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7708130", Offset = "0x7707330", VA = "0x187708130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GNEODCFMNBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x77082A0", Offset = "0x77074A0", VA = "0x1877082A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x77087E0", Offset = "0x77079E0", VA = "0x1877087E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JPCJICLAKDP<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x49A61E0", Offset = "0x49A53E0", VA = "0x1849A61E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x49A7150", Offset = "0x49A6350", VA = "0x1849A7150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class GFBFFAOHFLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public TaskCompletionSource<OJADAPCHIGK> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GFBFFAOHFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7708190", Offset = "0x7707390", VA = "0x187708190")]
		internal void KEJJAPIEOFL(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct GHDDLDKOABJ<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x460A480", Offset = "0x4609680", VA = "0x18460A480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3D73880", Offset = "0x3D72A80", VA = "0x183D73880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct BHOCAEGBACJ<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x58B1C70", Offset = "0x58B0E70", VA = "0x1858B1C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x58B2B70", Offset = "0x58B1D70", VA = "0x1858B2B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IJENOFPJCDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x77096A0", Offset = "0x77088A0", VA = "0x1877096A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7709880", Offset = "0x7708A80", VA = "0x187709880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BKPDAIBDLFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7705510", Offset = "0x7704710", VA = "0x187705510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7705870", Offset = "0x7704A70", VA = "0x187705870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct HGOPJOHGMEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7708A40", Offset = "0x7707C40", VA = "0x187708A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7708D30", Offset = "0x7707F30", VA = "0x187708D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class ECEBINKLEGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ECEBINKLEGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x77069A0", Offset = "0x7705BA0", VA = "0x1877069A0")]
		internal Task JAKECBIBJNM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct ILAAAAAAEFK : IAsyncStateMachine
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
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x77098E0", Offset = "0x7708AE0", VA = "0x1877098E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7709B40", Offset = "0x7708D40", VA = "0x187709B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct MAJCODJGIMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x770E7F0", Offset = "0x770D9F0", VA = "0x18770E7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x770E9D0", Offset = "0x770DBD0", VA = "0x18770E9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AJGDHGMMEKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7704610", Offset = "0x7703810", VA = "0x187704610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7704970", Offset = "0x7703B70", VA = "0x187704970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct JCALFJMBMGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7709BA0", Offset = "0x7708DA0", VA = "0x187709BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7709E90", Offset = "0x7709090", VA = "0x187709E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class KJGEHCFHLKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KJGEHCFHLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x770CCB0", Offset = "0x770BEB0", VA = "0x18770CCB0")]
		internal Task PEODBHGJFHL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct IBLLDCPFDOJ : IAsyncStateMachine
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
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x77093E0", Offset = "0x77085E0", VA = "0x1877093E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7709640", Offset = "0x7708840", VA = "0x187709640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct DAKLBIHKICP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7705E70", Offset = "0x7705070", VA = "0x187705E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7705FF0", Offset = "0x77051F0", VA = "0x187705FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct NHLKLEEALDO<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4E33D70", Offset = "0x4E32F70", VA = "0x184E33D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4E33FD0", Offset = "0x4E331D0", VA = "0x184E33FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct JDPCNAINMJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7709EF0", Offset = "0x77090F0", VA = "0x187709EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x770A220", Offset = "0x7709420", VA = "0x18770A220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static SynchronizationContext? BHBPODAMDFL;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly TaskCompletionSource<OJADAPCHIGK> NLDIHJNADNK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static Task GIDFCDDBMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x770AEE0", Offset = "0x770A0E0", VA = "0x18770AEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x770B650", Offset = "0x770A850", VA = "0x18770B650")]
	public static bool LJLOKMAPFNP(this Task JJCLBODJJAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x34F0AE0", Offset = "0x34EFCE0", VA = "0x1834F0AE0")]
	public static Task<T> DDIAOHFEBKJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x770BF30", Offset = "0x770B130", VA = "0x18770BF30")]
	public static Task OAOILFLFCJG(this Task JJCLBODJJAC, CancellationToken GIIKHLJPAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x34F3180", Offset = "0x34F2380", VA = "0x1834F3180")]
	public static Task<TResult> OAOILFLFCJG<TResult>(this Task<TResult> JJCLBODJJAC, CancellationToken GIIKHLJPAKH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x34F4710", Offset = "0x34F3910", VA = "0x1834F4710")]
	public static TaskCompletionSource<TResult> OAOILFLFCJG<TResult>(this TaskCompletionSource<TResult> ABHKCMFILHN, CancellationToken GIIKHLJPAKH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x770BCB0", Offset = "0x770AEB0", VA = "0x18770BCB0")]
	public static IDisposable? NFMEGCBNIKA(CancellationToken PDLOMGPLMJL, CancellationToken OHGDPEAGICI, [Out] CancellationToken NOFPLIHLBME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x770B5A0", Offset = "0x770A7A0", VA = "0x18770B5A0")]
	[AsyncStateMachine(typeof(MHIFOAJKBEO))]
	public static void LEMIICCLAGP(this Task FDDEDLKEPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x770ACF0", Offset = "0x7709EF0", VA = "0x18770ACF0")]
	[AsyncStateMachine(typeof(BJFMLKGKPNN))]
	public static void FNMBOCEOPPO(this Task FDDEDLKEPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x34F0900", Offset = "0x34EFB00", VA = "0x1834F0900")]
	[AsyncStateMachine(typeof(CLIJPHIMAHN<>))]
	public static Task CMNANNJMLCN<TException>(this Task FDDEDLKEPIJ) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x34F0440", Offset = "0x34EF640", VA = "0x1834F0440")]
	[AsyncStateMachine(typeof(EAFFPNCIFJL<>))]
	public static Task<T> ANNHNHDIAID<T>(this Task<T> NAELBAPCKEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x770ADF0", Offset = "0x7709FF0", VA = "0x18770ADF0")]
	[AsyncStateMachine(typeof(PBCJCKBPMPF))]
	public static Task<TaskStatus> GHCOBOMEFPC(this Task? NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x34F50A0", Offset = "0x34F42A0", VA = "0x1834F50A0")]
	public static (Task<T?>?, Action<T?>?) PFDJGEDIHGK<T>([Optional] CancellationToken KPIINMODKFJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x34F09D0", Offset = "0x34EFBD0", VA = "0x1834F09D0")]
	[AsyncStateMachine(typeof(JAALIJKPFPL<, >))]
	public static Task<List<TResult>> CNHOHFJFPDD<TResult, TInput>(this Task<List<TInput>> JJCLBODJJAC, ANOFEJLJKEJ<TInput, TResult> NPOHDHFMBIC) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x770A3B0", Offset = "0x77095B0", VA = "0x18770A3B0")]
	[AsyncStateMachine(typeof(GFADIOPCOML))]
	public static Task AGKNGNDIENP(Task FDDEDLKEPIJ, CancellationToken BAIPNBEOGFG, Func<CancellationToken, Task> ALBOMGIIGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x770A280", Offset = "0x7709480", VA = "0x18770A280")]
	[AsyncStateMachine(typeof(GNEODCFMNBK))]
	public static Task AEIEPKHFNDH(Func<CancellationToken, Task> BDBLHJDLOGM, TimeSpan KLKCOGKAFBL, [Optional] CancellationToken BAIPNBEOGFG, [Optional] Action<OperationCanceledException>? GDLKJINPJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x34F01C0", Offset = "0x34EF3C0", VA = "0x1834F01C0")]
	[AsyncStateMachine(typeof(JPCJICLAKDP<>))]
	public static Task<T> AEIEPKHFNDH<T>(Func<CancellationToken, Task<T>> BDBLHJDLOGM, TimeSpan KLKCOGKAFBL, [Optional] CancellationToken BAIPNBEOGFG, [Optional] Func<OperationCanceledException, T>? GDLKJINPJGG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x770A4E0", Offset = "0x77096E0", VA = "0x18770A4E0")]
	public static Task BOACAPKNIMJ(params Task[] EEGEOOOEEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x770A530", Offset = "0x7709730", VA = "0x18770A530")]
	public static Task BOACAPKNIMJ(IEnumerable<Task> EEGEOOOEEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34F0D50", Offset = "0x34EFF50", VA = "0x1834F0D50")]
	[AsyncStateMachine(typeof(GHDDLDKOABJ<>))]
	public static Task<IEnumerable<Task<T>>> IHDGNADCMCA<T>(IEnumerable<Task<T>> EEGEOOOEEAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x34F0620", Offset = "0x34EF820", VA = "0x1834F0620")]
	[AsyncStateMachine(typeof(BHOCAEGBACJ<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> CCJCOKDLEHC<T1, T2, T3, T4, T5>(Task<T1> IAKGLDKCPOA, Task<T2> HLPMEGDHCID, Task<T3> BALCICJIDHN, Task<T4> MMDBBEBOACF, Task<T5> NEAEFKOMANE) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x770AFA0", Offset = "0x770A1A0", VA = "0x18770AFA0")]
	[AsyncStateMachine(typeof(IJENOFPJCDA))]
	public static Task ILKCPDFCKEL(Func<bool> FPPMNPIKPAP, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x770B090", Offset = "0x770A290", VA = "0x18770B090")]
	[AsyncStateMachine(typeof(BKPDAIBDLFM))]
	public static Task ILKCPDFCKEL(Func<bool> FPPMNPIKPAP, TimeSpan EJPLHOKPBHN, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x770B1A0", Offset = "0x770A3A0", VA = "0x18770B1A0")]
	[AsyncStateMachine(typeof(HGOPJOHGMEB))]
	public static Task INMHOLNGLPG(Func<bool> FPPMNPIKPAP, TimeSpan KLKCOGKAFBL, [Optional] CancellationToken KPIINMODKFJ, [Optional] Action<OperationCanceledException>? GDLKJINPJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x770B2D0", Offset = "0x770A4D0", VA = "0x18770B2D0")]
	[AsyncStateMachine(typeof(ILAAAAAAEFK))]
	public static Task INMHOLNGLPG(Func<bool> FPPMNPIKPAP, TimeSpan KLKCOGKAFBL, TimeSpan EJPLHOKPBHN, [Optional] CancellationToken KPIINMODKFJ, [Optional] Action<OperationCanceledException>? GDLKJINPJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x770BAB0", Offset = "0x770ACB0", VA = "0x18770BAB0")]
	[AsyncStateMachine(typeof(MAJCODJGIMD))]
	public static Task MODNLNOLEPJ(Func<bool> FPPMNPIKPAP, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x770BBA0", Offset = "0x770ADA0", VA = "0x18770BBA0")]
	[AsyncStateMachine(typeof(AJGDHGMMEKN))]
	public static Task MODNLNOLEPJ(Func<bool> FPPMNPIKPAP, TimeSpan EJPLHOKPBHN, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x770C180", Offset = "0x770B380", VA = "0x18770C180")]
	[AsyncStateMachine(typeof(JCALFJMBMGJ))]
	public static Task ONJEPLFAHAE(Func<bool> FPPMNPIKPAP, TimeSpan KLKCOGKAFBL, [Optional] CancellationToken KPIINMODKFJ, [Optional] Action<OperationCanceledException>? GDLKJINPJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x770C2B0", Offset = "0x770B4B0", VA = "0x18770C2B0")]
	[AsyncStateMachine(typeof(IBLLDCPFDOJ))]
	public static Task ONJEPLFAHAE(Func<bool> FPPMNPIKPAP, TimeSpan KLKCOGKAFBL, TimeSpan EJPLHOKPBHN, [Optional] CancellationToken KPIINMODKFJ, [Optional] Action<OperationCanceledException>? GDLKJINPJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x770BE40", Offset = "0x770B040", VA = "0x18770BE40")]
	[AsyncStateMachine(typeof(DAKLBIHKICP))]
	[Obsolete]
	public static Task NJECANICKKC(this Task JJCLBODJJAC, Action LDPBDEGOJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x34F0E40", Offset = "0x34F0040", VA = "0x1834F0E40")]
	[AsyncStateMachine(typeof(NHLKLEEALDO<>))]
	[Obsolete]
	public static Task NJECANICKKC<T>(this Task<T> JJCLBODJJAC, Action<T> LDPBDEGOJFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x770AAC0", Offset = "0x7709CC0", VA = "0x18770AAC0")]
	private static void CMGGKNMFGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x770B750", Offset = "0x770A950", VA = "0x18770B750")]
	public static bool MDLKPMKEHFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x770AB70", Offset = "0x7709D70", VA = "0x18770AB70")]
	private static void DBDHHGEMCNE(SynchronizationContext OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x770B490", Offset = "0x770A690", VA = "0x18770B490")]
	private static void JKCBGAMNEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x770B680", Offset = "0x770A880", VA = "0x18770B680")]
	public static void LOPFNCJPIPK([Optional] string? DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x770B410", Offset = "0x770A610", VA = "0x18770B410")]
	public static void IPPKPCOLBGG([Optional] string? DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x770ADA0", Offset = "0x7709FA0", VA = "0x18770ADA0")]
	public static JCIJEJLJKMK FPAKFDJPDCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x770AF50", Offset = "0x770A150", VA = "0x18770AF50")]
	public static JCIJEJLJKMK IAJCGGMONAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x770A9F0", Offset = "0x7709BF0", VA = "0x18770A9F0")]
	[AsyncStateMachine(typeof(JDPCNAINMJB))]
	public static Task CGGPFIKEPFK(Func<Task> GGGDPGAGPON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class ALDPDJHMICB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
	public ALDPDJHMICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class FGFONLFPOAI : ICFBCDCCAGF
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static readonly ICFBCDCCAGF JLGHKLNHGNO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime EAJFNIDJEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x77077D0", Offset = "0x77069D0", VA = "0x1877077D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset LLPLBPKNDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7707770", Offset = "0x7706970", VA = "0x187707770", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public FGFONLFPOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface ICFBCDCCAGF
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DateTime EAJFNIDJEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTimeOffset LLPLBPKNDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class BGCHFBMMMJI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static long EFIAMOBLKOK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x77050B0", Offset = "0x77042B0", VA = "0x1877050B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long GMIJBOALMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7704CE0", Offset = "0x7703EE0", VA = "0x187704CE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static double LEGABBNNHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7704F30", Offset = "0x7704130", VA = "0x187704F30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double PBKAOKCOKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7704E50", Offset = "0x7704050", VA = "0x187704E50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double CNMJHCFGDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7704C90", Offset = "0x7703E90", VA = "0x187704C90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double GHLHGNDDNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7704F80", Offset = "0x7704180", VA = "0x187704F80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7704DC0", Offset = "0x7703FC0", VA = "0x187704DC0")]
	public static double GJFHLNALEGE(long AFKEKHAFIGC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7704EA0", Offset = "0x77040A0", VA = "0x187704EA0")]
	public static double JOKGCLBHMGA(long AFKEKHAFIGC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7704D30", Offset = "0x7703F30", VA = "0x187704D30")]
	public static double GFJACLOAKDB(double PBEMGDFFBID)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7704C00", Offset = "0x7703E00", VA = "0x187704C00")]
	public static long BGLHDOCEFJA(long KDJGAOFKCEM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x77050A0", Offset = "0x77042A0", VA = "0x1877050A0")]
	public static long NJGHNCHJLMM(long GNKKKPCBKLJ, long LICJGFOAHLC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7704FD0", Offset = "0x77041D0", VA = "0x187704FD0")]
	public static double MEEHIBKIOGA(long GNKKKPCBKLJ, long LICJGFOAHLC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7705100", Offset = "0x7704300", VA = "0x187705100")]
	public static double PEMBMGOOOKN(long GNKKKPCBKLJ, long LICJGFOAHLC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class KCFPHKNPAAI : MOODNHIFOBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly TimeSpan NEJNEPODNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly System.Timers.Timer MLINJELIMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private TimeSpan KLKCOGKAFBL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TimeSpan FIFMAEEPLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x770C710", Offset = "0x770B910", VA = "0x18770C710", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? PJFEFPGPIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x770C8E0", Offset = "0x770BAE0", VA = "0x18770C8E0")]
	[Preserve]
	public KCFPHKNPAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x770C940", Offset = "0x770BB40", VA = "0x18770C940")]
	public KCFPHKNPAAI(TimeSpan KLKCOGKAFBL, [Optional] Action? MMJBCGEMAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x770C4B0", Offset = "0x770B6B0", VA = "0x18770C4B0", Slot = "7")]
	public void CHDCILGNCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x770C6A0", Offset = "0x770B8A0", VA = "0x18770C6A0", Slot = "8")]
	public void LDPAFPINIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x770C670", Offset = "0x770B870", VA = "0x18770C670", Slot = "9")]
	public void JIJAHPJBMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xFC9E60", Offset = "0xFC9060", VA = "0x180FC9E60")]
	private void OGGHLNEJODE(object JEBOOCGPANP, ElapsedEventArgs MACKLOHNGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x770C5E0", Offset = "0x770B7E0", VA = "0x18770C5E0")]
	private static void HIKAKHKEIHJ(TimeSpan MCEMFPBHANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x770C540", Offset = "0x770B740", VA = "0x18770C540", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CFNIPKDPJMF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly string? PKLLPFENPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly string DJHOCCKHGLB;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x70B7850", Offset = "0x70B6A50", VA = "0x1870B7850")]
	public CFNIPKDPJMF(string BIGHOOCGPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x48683C0", Offset = "0x48675C0", VA = "0x1848683C0")]
	public CFNIPKDPJMF(string DIOGKKBMGFI, string BIGHOOCGPMA)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KKADPMMIMJJ : IEquatable<KKADPMMIMJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint FNLEGIPMBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int OJCIEDCEODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float ONJBCFKLDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort DJLBHNEFKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort GNFINLAMCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short AJFKGHMDFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short LGLMFLJPLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public char JAKJIHIJCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public char ABGLCCOAOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte GDIEFGFOMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte MLMOCCAADOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte BKLMGIFLBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte MDCKJIIBDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public bool KJCDAOPGGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool EDCHGJHJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool DFBKAJLHLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool FDFAMPKBDCM;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1C8B720", Offset = "0x1C8A920", VA = "0x181C8B720")]
	public static KKADPMMIMJJ NLFDFOPPOAC(uint PIEGHFGINAI)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1C8B720", Offset = "0x1C8A920", VA = "0x181C8B720")]
	public static KKADPMMIMJJ DGEHEPPNDCE(int DBLBHIPMHDJ)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x770CD20", Offset = "0x770BF20", VA = "0x18770CD20")]
	public static KKADPMMIMJJ AEIFGBPDIIP(float LPEGMIGCGCM)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x770CD30", Offset = "0x770BF30", VA = "0x18770CD30")]
	public static KKADPMMIMJJ LLGHCDPKDOK(byte KFMGBIDPPMD, byte GHMAKOILAHD, byte OJLHNCLBMFC, byte CFNEBJGEEJO)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x770CD30", Offset = "0x770BF30", VA = "0x18770CD30")]
	public static KKADPMMIMJJ GMHDMNBGBPD(bool OMMEMJCLKAC, bool IELJGPPCIGJ, bool LNGNDBNPMEI, bool DABMHEIOBAI)
	{
		return default(KKADPMMIMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x770CD30", Offset = "0x770BF30", VA = "0x18770CD30")]
	public static KKADPMMIMJJ EOPKCIHJHJN(byte NPBJFJBNMMH, byte PDDAJHHDEEH, byte IEKGMGOJGKF, byte CKGHMGCJPEN)
	{
		return default(KKADPMMIMJJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1F61D40", Offset = "0x1F60F40", VA = "0x181F61D40")]
	public static bool GJNOMHNHJKL(KKADPMMIMJJ DOEPDJPJMCB, KKADPMMIMJJ DHHGPPJBNNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1F61D20", Offset = "0x1F60F20", VA = "0x181F61D20", Slot = "4")]
	public bool Equals(KKADPMMIMJJ LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x770CD50", Offset = "0x770BF50", VA = "0x18770CD50", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x1152400", Offset = "0x1151600", VA = "0x181152400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x770CDE0", Offset = "0x770BFE0", VA = "0x18770CDE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct EMHIEBBIMML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public ulong HOCCGJJNNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public long MKADDICFKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public double HFACDEIKDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint IPGJIBEEDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public uint JCLDPKAIJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int HJCMGKJGLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int NJGBFLEHCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float FAABKLEJPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float MPAHKKPEJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort DJLBHNEFKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public ushort GNFINLAMCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort OFNPINBCPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public ushort DFMELPKKMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public short AJFKGHMDFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public short LGLMFLJPLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short EGGDNPNACEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public short BGOAMHFBPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public char JAKJIHIJCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public char ABGLCCOAOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char MNIKLJLKKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public char BHBFAPCCBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte GDIEFGFOMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte MLMOCCAADOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte BKLMGIFLBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte MDCKJIIBDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte KDBBECGCPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte AGLCDBGBMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte BFGDNKPIAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte COAIFGBDEJA;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static EMHIEBBIMML PEFMILKIAFF(long DGLNKPJJKHP)
	{
		return default(EMHIEBBIMML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7706DE0", Offset = "0x7705FE0", VA = "0x187706DE0")]
	public static EMHIEBBIMML PEFMILKIAFF(byte KFMGBIDPPMD, byte GHMAKOILAHD, byte OJLHNCLBMFC, byte CFNEBJGEEJO, byte CAMCJBMFPME, byte CMHEOJMIADN, byte GOMPAHEHDJH, byte JBMOMGOFIDB)
	{
		return default(EMHIEBBIMML);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct MIEENOIGDPE : IEquatable<MIEENOIGDPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public byte KOFOEKCJBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool PDMLPPJIFFJ;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2C12440", Offset = "0x2C11640", VA = "0x182C12440")]
	public static MIEENOIGDPE LLGHCDPKDOK(byte NJILNKLEACF)
	{
		return default(MIEENOIGDPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2C12440", Offset = "0x2C11640", VA = "0x182C12440")]
	public static MIEENOIGDPE GMHDMNBGBPD(bool ELKENBPFKLN)
	{
		return default(MIEENOIGDPE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x770EC20", Offset = "0x770DE20", VA = "0x18770EC20")]
	public static bool GJNOMHNHJKL(MIEENOIGDPE DOEPDJPJMCB, MIEENOIGDPE DHHGPPJBNNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6741F20", Offset = "0x6741120", VA = "0x186741F20", Slot = "4")]
	public bool Equals(MIEENOIGDPE LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x770EB90", Offset = "0x770DD90", VA = "0x18770EB90", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x770EC30", Offset = "0x770DE30", VA = "0x18770EC30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x770EC40", Offset = "0x770DE40", VA = "0x18770EC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JJPLHDOLEJA<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly T NJELOCBMBLK;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x498B520", Offset = "0x498A720", VA = "0x18498B520")]
	public JJPLHDOLEJA(T DFLODLMJCHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class HDBAMIOPFMA
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x32D1FF0", Offset = "0x32D11F0", VA = "0x1832D1FF0")]
	public static IEnumerable<T> JKNADFDIABM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static T[] KGIBEEPACNF<T>(params T[] FMJAPMMIDGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static IEnumerable<T> IABELMGCCKE<T>(params T[] FMJAPMMIDGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x32C8ED0", Offset = "0x32C80D0", VA = "0x1832C8ED0")]
	public static HashSet<T> OGOEELJNOPB<T>(params T[] FMJAPMMIDGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x34A4D60", Offset = "0x34A3F60", VA = "0x1834A4D60")]
	public static KeyValuePair<TKey, TValue> OAEEHDPAMEK<TKey, TValue>([In] TKey MBDBONINAPC, [In] TValue OMFJNFBDJCA) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x32C8ED0", Offset = "0x32C80D0", VA = "0x1832C8ED0")]
	public static List<T> FFCGEEFOGOC<T>(IEnumerable<T> IDDPONMNMLO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All)]
public sealed class AIEIPBFJACJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string DDCGJFOOODD;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
	public AIEIPBFJACJ(string ONKLBOFODCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate object PLCFDPHJIKN<T>([In] T MEDGLPBHGFL);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object HKHBAAHOMEA<T>(T MEDGLPBHGFL);
[Cpp2IlInjected.Token(Token = "0x2000064")]
[CCFGIEANGJL]
public delegate string BEFKEOACEKH(string BKOPBBHMJGH, string? OKHEDFBAINB, bool BCHADAFBOEL);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[CCFGIEANGJL]
public delegate void JGNGNAEJKFK(string DCEACFEGBDC);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[CCFGIEANGJL]
public delegate void FEBNDAJCNBN(Exception GMEDNHNLLCJ);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object NALHAEHOCBH();
[Cpp2IlInjected.Token(Token = "0x2000068")]
[CCFGIEANGJL]
public delegate bool HANMBBDBLLA();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[CCFGIEANGJL]
public delegate string AGFIJKALKCP(object ONELFPFEALD);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AttributeUsage(AttributeTargets.Enum)]
public class DENMCBKOHOK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
	public DENMCBKOHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class HJIPMAFPBJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct DJFNDEIELNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7706050", Offset = "0x7705250", VA = "0x187706050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7706930", Offset = "0x7705B30", VA = "0x187706930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly TimerCallback HKFECLKIAKO;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly Action<object?> ILGBDONICAJ;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7708FE0", Offset = "0x77081E0", VA = "0x187708FE0")]
	public static Task<bool> MDMIMFCOBNA(int CAKBOHMCLDN, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7708EB0", Offset = "0x77080B0", VA = "0x187708EB0")]
	[AsyncStateMachine(typeof(DJFNDEIELNE))]
	private static Task<bool> DHBFHKJAMEK(int CAKBOHMCLDN, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7708D90", Offset = "0x7707F90", VA = "0x187708D90")]
	private static void CMBBEOJAKKH(object? LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7708E20", Offset = "0x7708020", VA = "0x187708E20")]
	private static void DBKCBGKFFJK(object? LEOMHHEDCFC)
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
