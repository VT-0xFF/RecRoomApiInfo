using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DFB040", Offset = "0x7DF9C40", VA = "0x187DFB040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_FuzzySearch_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAB00", Offset = "0x7DF9700", VA = "0x187DFAB00", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IDLHBPCCEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IHIBBDKEBPB DGEOKDEKGPB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8FD0", Offset = "0x7DF7BD0", VA = "0x187DF8FD0")]
	public IDLHBPCCEIM(IReadOnlyCollection<string> ADKCIHDJKAD, [In] IBKHEMIBDJA FDABCNCAEIC, [Optional] IHIBBDKEBPB.GCCKKPDLJEP GJCLAOLACJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8D90", Offset = "0x7DF7990", VA = "0x187DF8D90")]
	public IReadOnlyList<DEKLFJHBICB> KHJBMBGEECP(string HLCBCLACCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8BF0", Offset = "0x7DF77F0", VA = "0x187DF8BF0")]
	public void HCAFKGHNHEN(string HLCBCLACCNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IHIBBDKEBPB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int GCCKKPDLJEP(IReadOnlyList<char> NIIOJDILCHH, int IFIDPODMMJK, string AMLAEEOGINO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IBKHEMIBDJA FADJGNMFONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GCCKKPDLJEP GOFEEDKEDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] CHIPIFNMMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly DEKLFJHBICB[] BFGAMFNDOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] KABELCGHOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] JHMKKOCEJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly DEKLFJHBICB[] AFMHBKFCKEG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90")]
	public static int POBACEFJDNC(IReadOnlyList<char> NIIOJDILCHH, int IFIDPODMMJK, string AMLAEEOGINO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9D20", Offset = "0x7DF8920", VA = "0x187DF9D20")]
	public IHIBBDKEBPB(IReadOnlyCollection<string> ADKCIHDJKAD, [In] IBKHEMIBDJA FDABCNCAEIC, [Optional] GCCKKPDLJEP GJCLAOLACJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9C80", Offset = "0x7DF8880", VA = "0x187DF9C80")]
	public string OGLIFBMLHDK(string HLCBCLACCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9D10", Offset = "0x7DF8910", VA = "0x187DF9D10")]
	public int PCGPEPEKEOM(int KIOECDPLLAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF9680", Offset = "0x7DF8280", VA = "0x187DF9680")]
	public int HCAFKGHNHEN(string HLCBCLACCNL, int HPAGDOGJEPA, int HABHFCHCNOF, int IFIDPODMMJK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct IBKHEMIBDJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool KGDACFFFDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool LBCKFNCMDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int HFNFBFCEBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int JGNIBEDCBBP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IBKHEMIBDJA PIMDFDAIMPH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IBKHEMIBDJA DIACPKGMELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8B20", Offset = "0x7DF7720", VA = "0x187DF8B20")]
		get
		{
			return default(IBKHEMIBDJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8BD0", Offset = "0x7DF77D0", VA = "0x187DF8BD0")]
	public IBKHEMIBDJA(bool COJOLFIHKLC, bool KMIHHFLLNEP, int AGIFNOHNACI, int HFHCHEJDEDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct DEKLFJHBICB : IEquatable<DEKLFJHBICB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int FCJKCAOMEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int HCAFKGHNHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int KLFPBAMFEOH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xDDDC50", Offset = "0xDDC850", VA = "0x180DDDC50")]
	public DEKLFJHBICB(int EMMACFPOKFB, int CBIAAOFOKNE, int KGECKFGNNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6BE0", Offset = "0x7DF57E0", VA = "0x187DF6BE0")]
	public static int COJAJHEGCDC([In] DEKLFJHBICB HLPEBKMLKLE, [In] DEKLFJHBICB MAELALMKOEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27DD7B0", Offset = "0x27DC3B0", VA = "0x1827DD7B0", Slot = "4")]
	public bool Equals(DEKLFJHBICB GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6C00", Offset = "0x7DF5800", VA = "0x187DF6C00", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6CB0", Offset = "0x7DF58B0", VA = "0x187DF6CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OMCAGMDEFEG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ACFLJGMAGGL(string HLCBCLACCNL, [Out][NotNullWhen(true)] IReadOnlyList<HJAHJGPDGFO>? HECIKPJEDLM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HCEKAFHBHBF : OMCAGMDEFEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int PGIEIEBGJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<HJAHJGPDGFO> results)> AFHEFLCAFIP;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8790", Offset = "0x7DF7390", VA = "0x187DF8790")]
	public HCEKAFHBHBF(int PGIEIEBGJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF8610", Offset = "0x7DF7210", VA = "0x187DF8610", Slot = "4")]
	public bool ACFLJGMAGGL(string HLCBCLACCNL, [Out][NotNullWhen(true)] IReadOnlyList<HJAHJGPDGFO>? HECIKPJEDLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JAEBJFIABMG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void CBKNJJBAIJE(IReadOnlyList<HJAHJGPDGFO> HECIKPJEDLM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GGGJKEILCGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JAEBJFIABMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GGGJKEILCGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7DF76E0", Offset = "0x7DF62E0", VA = "0x187DF76E0")]
		internal HJAHJGPDGFO[] EBLDBAKABLL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MDNKJPKJADG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JAEBJFIABMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GGGJKEILCGD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CBKNJJBAIJE onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<HJAHJGPDGFO[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAB90", Offset = "0x7DF9790", VA = "0x187DFAB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly FKGNBABOCCB IJOCDKGENOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NHCHFJCPCKJ HHMPBAMLNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly KMBLCKBELCL.BEOMPKJAJOE? OOGDMKJMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HJAHJGPDGFO[] ECHDNJHLFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? CMAEPNBICHI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KDMKLIMPCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x113F1E0", Offset = "0x113DDE0", VA = "0x18113F1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA9C0", Offset = "0x7DF95C0", VA = "0x187DFA9C0")]
	public JAEBJFIABMG(FKGNBABOCCB IJOCDKGENOK, NHCHFJCPCKJ HHMPBAMLNCM, [Optional] KMBLCKBELCL.BEOMPKJAJOE? OOGDMKJMGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA810", Offset = "0x7DF9410", VA = "0x187DFA810")]
	[AsyncStateMachine(typeof(MDNKJPKJADG))]
	public void KHJBMBGEECP(string HLCBCLACCNL, CBKNJJBAIJE FHOOJOBOIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DFA900", Offset = "0x7DF9500", VA = "0x187DFA900")]
	public void LEAINMHIBHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KMBLCKBELCL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int BEOMPKJAJOE(ReadOnlySpan<char> HLCBCLACCNL, ReadOnlySpan<char> PHMCMDMMCAM, int BOEANCKIGME);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAA70", Offset = "0x7DF9670", VA = "0x187DFAA70")]
	public static int LJFNFDMJKEH([In] HJAHJGPDGFO HLPEBKMLKLE, [In] HJAHJGPDGFO MAELALMKOEM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HJAHJGPDGFO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CJFAFLNNEHL : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public HJAHJGPDGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public HJAHJGPDGFO <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x11D3510", Offset = "0x11D2110", VA = "0x1811D3510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7DF6B90", Offset = "0x7DF5790", VA = "0x187DF6B90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x13E8B50", Offset = "0x13E7750", VA = "0x1813E8B50")]
		[DebuggerHidden]
		public CJFAFLNNEHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7DF69E0", Offset = "0x7DF55E0", VA = "0x187DF69E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6B40", Offset = "0x7DF5740", VA = "0x187DF6B40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6A80", Offset = "0x7DF5680", VA = "0x187DF6A80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6A80", Offset = "0x7DF5680", VA = "0x187DF6A80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float HCAFKGHNHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int FCJKCAOMEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> JIEHKKGHIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray NCOCHLMAJAL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> DOLKAMFLOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8830", Offset = "0x7DF7430", VA = "0x187DF8830")]
		[IteratorStateMachine(typeof(CJFAFLNNEHL))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF88C0", Offset = "0x7DF74C0", VA = "0x187DF88C0")]
	public HJAHJGPDGFO(float CBIAAOFOKNE, int EMMACFPOKFB, ReadOnlyMemory<char> MDKAAPLMLKG, IEnumerable<int> NCOCHLMAJAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct OEMJPMLGINO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool KGDACFFFDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool LBCKFNCMDKK;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E81180", Offset = "0x4E7FD80", VA = "0x184E81180")]
	public OEMJPMLGINO(bool OLKDHEKKLAM, bool AOPCIHIGAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7DFB0C0", Offset = "0x7DF9CC0", VA = "0x187DFB0C0")]
	public string NAAFCGABPIL(string KMCLKBGAPBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NHCHFJCPCKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float HCAFKGHNHEN(ReadOnlySpan<char> HLCBCLACCNL, ReadOnlySpan<char> PHMCMDMMCAM, [Optional] List<int>? FMLLEMKGHJC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FLJKOFPPJPC : NHCHFJCPCKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct PMDOJGGNMAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float DCPKPHJFDCE;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B69B50", Offset = "0x2B68750", VA = "0x182B69B50")]
		public PMDOJGGNMAN(float IDECFCGHEPH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] AOGPHBBADGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] CMJBLFJBEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray PNJICOEIOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PMDOJGGNMAN FDABCNCAEIC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7600", Offset = "0x7DF6200", VA = "0x187DF7600")]
	public FLJKOFPPJPC([In] PMDOJGGNMAN FDABCNCAEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6E30", Offset = "0x7DF5A30", VA = "0x187DF6E30", Slot = "4")]
	public float HCAFKGHNHEN(ReadOnlySpan<char> HLCBCLACCNL, ReadOnlySpan<char> PHMCMDMMCAM, [Optional] List<int>? FMLLEMKGHJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7DF71B0", Offset = "0x7DF5DB0", VA = "0x187DF71B0")]
	private void LFGPAACEADM(int DKFJGBGJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7240", Offset = "0x7DF5E40", VA = "0x187DF7240")]
	private float PPNNFGLMGNF(ReadOnlySpan<char> HLCBCLACCNL, ReadOnlySpan<char> PHMCMDMMCAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6D20", Offset = "0x7DF5920", VA = "0x187DF6D20")]
	private int CNOAHIKGDMJ(ReadOnlySpan<char> DCOPGJAJLLG, ReadOnlySpan<char> MDKAAPLMLKG, int NMAJOKCEKCP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BOLDABAAIOJ : NHCHFJCPCKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int AGIFNOHNACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? PEHEJPJNFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] FGCOKNKDHKK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6930", Offset = "0x7DF5530", VA = "0x187DF6930")]
	public BOLDABAAIOJ(int AGIFNOHNACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6280", Offset = "0x7DF4E80", VA = "0x187DF6280", Slot = "4")]
	public float HCAFKGHNHEN(ReadOnlySpan<char> HLCBCLACCNL, ReadOnlySpan<char> PHMCMDMMCAM, [Optional] List<int>? FMLLEMKGHJC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FKGNBABOCCB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> DMFNOGHOMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GMGIDIPFMGL : FKGNBABOCCB
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MFEJJFJLKLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public OEMJPMLGINO settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MFEJJFJLKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAFB0", Offset = "0x7DF9BB0", VA = "0x187DFAFB0")]
		internal string LGBCCJOCEAA(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IEBOHLGFKFP : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ReadOnlyMemory<char> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public GMGIDIPFMGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<CNFNHDKIAIK<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCADF90", Offset = "0xCACB90", VA = "0x180CADF90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ReadOnlyMemory<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7DF95A0", Offset = "0x7DF81A0", VA = "0x187DF95A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x27CCED0", Offset = "0x27CBAD0", VA = "0x1827CCED0")]
		[DebuggerHidden]
		public IEBOHLGFKFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7DF95F0", Offset = "0x7DF81F0", VA = "0x187DF95F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DF90D0", Offset = "0x7DF7CD0", VA = "0x187DF90D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9080", Offset = "0x7DF7C80", VA = "0x187DF9080")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF9550", Offset = "0x7DF8150", VA = "0x187DF9550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF94A0", Offset = "0x7DF80A0", VA = "0x187DF94A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7DF94A0", Offset = "0x7DF80A0", VA = "0x187DF94A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] LGLFNEBBNHL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> DMFNOGHOMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7DE0", Offset = "0x7DF69E0", VA = "0x187DF7DE0", Slot = "4")]
		[IteratorStateMachine(typeof(IEBOHLGFKFP))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7DF7E60", Offset = "0x7DF6A60", VA = "0x187DF7E60")]
	public GMGIDIPFMGL(IEnumerable<string> IJOCDKGENOK, OEMJPMLGINO FDABCNCAEIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class NPKFDPKODOJ<TSchedulerContext> : IDisposable where TSchedulerContext : notnull, MonoBehaviour, MIGNIEJDGMD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void BKKPBNJGBGH(IReadOnlyList<DEKLFJHBICB> HECIKPJEDLM, IReadOnlyList<bool> PPFGFOIKKCG);

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private const string NJFEGLPNEEI = "r2adoption_2025q2_better_palette_search";

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private const string EPGKDJKDJCM = "algorithm";

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static AHEAEJOKBNI? BKHLAMDGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly OMCAGMDEFEG? AFHEFLCAFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly JAEBJFIABMG DCOPGJAJLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly OEMJPMLGINO KDOMILABNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly IBKHEMIBDJA FDABCNCAEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly BKKPBNJGBGH OHDFBIFKDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly KMBLCKBELCL.BEOMPKJAJOE? OOGDMKJMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private IReadOnlyList<DEKLFJHBICB> AINOJMHPDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private IReadOnlyList<bool> JBLEEPBFJOP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<DEKLFJHBICB> LAEDEIJOBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> KBKFLONMLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KDMKLIMPCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5556820", Offset = "0x5555420", VA = "0x185556820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5556F50", Offset = "0x5555B50", VA = "0x185556F50")]
	public NPKFDPKODOJ(IReadOnlyList<string> ADKCIHDJKAD, [In] IBKHEMIBDJA FDABCNCAEIC, BKKPBNJGBGH FHOOJOBOIEJ, [Optional] KMBLCKBELCL.BEOMPKJAJOE? OOGDMKJMGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5556DD0", Offset = "0x55559D0", VA = "0x185556DD0")]
	public void NLBHJMKKKMA(string HLCBCLACCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x55562C0", Offset = "0x5554EC0", VA = "0x1855562C0")]
	private void BCCGKGJNLCH(IReadOnlyList<HJAHJGPDGFO> HECIKPJEDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5556BD0", Offset = "0x55557D0", VA = "0x185556BD0")]
	private int LJMJHCOCEIF(ReadOnlySpan<char> GBEGHJIHKEG, ReadOnlySpan<char> MDKAAPLMLKG, int NEJDDKNLOAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5556840", Offset = "0x5555440", VA = "0x185556840")]
	private NHCHFJCPCKJ FIAMJHDLABA()
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
