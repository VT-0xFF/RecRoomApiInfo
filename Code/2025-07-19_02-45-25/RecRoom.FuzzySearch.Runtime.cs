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

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x81A4F40", Offset = "0x81A3F40", VA = "0x1881A4F40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81A4A80", Offset = "0x81A3A80", VA = "0x1881A4A80", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class DPIENCIPCKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DOEKLFOKFEI LGHFMHICOPJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81A1090", Offset = "0x81A0090", VA = "0x1881A1090")]
	public DPIENCIPCKG(IReadOnlyCollection<string> PMDGDGBONEH, [In] EBJKDIGDMEE KGDNAKPKMMC, [Optional] DOEKLFOKFEI.ICFMCMMKFMD DIAAAFAPLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81A0E50", Offset = "0x819FE50", VA = "0x1881A0E50")]
	public IReadOnlyList<MEHLEKHCIAA> INALMJLIPMO(string FGPPMKCJBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81A0CB0", Offset = "0x819FCB0", VA = "0x1881A0CB0")]
	public void ALJEOLOPJHF(string FGPPMKCJBPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DOEKLFOKFEI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int ICFMCMMKFMD(IReadOnlyList<char> FIPEPELCABN, int ANLFGCOMHMA, string AEKINMGOOOA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly EBJKDIGDMEE AJLLHGPGDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ICFMCMMKFMD BMGCOFGEKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] ANDKNKJFCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly MEHLEKHCIAA[] IJBEHPGCOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] GOOGMACFJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] DGMHFEGJOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly MEHLEKHCIAA[] DIBBLAEDCGE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530")]
	public static int JFCGNKPLBGO(IReadOnlyList<char> FIPEPELCABN, int ANLFGCOMHMA, string AEKINMGOOOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81A01C0", Offset = "0x819F1C0", VA = "0x1881A01C0")]
	public DOEKLFOKFEI(IReadOnlyCollection<string> PMDGDGBONEH, [In] EBJKDIGDMEE KGDNAKPKMMC, [Optional] ICFMCMMKFMD DIAAAFAPLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81A0130", Offset = "0x819F130", VA = "0x1881A0130")]
	public string LGIKJKDPPML(string FGPPMKCJBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x81A0120", Offset = "0x819F120", VA = "0x1881A0120")]
	public int JKDMLOCHIKC(int CLDABHMPPBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x819FB20", Offset = "0x819EB20", VA = "0x18819FB20")]
	public int ALJEOLOPJHF(string FGPPMKCJBPJ, int NLAJPOLMDMD, int HHKDBBHEHPN, int ANLFGCOMHMA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct EBJKDIGDMEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool FHIKIJNCDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool EFNNDODEGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int APPJLBPDNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int EKODGPOMDAI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly EBJKDIGDMEE IIIGGOCLMCE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EBJKDIGDMEE HPFHFAKCNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81A1140", Offset = "0x81A0140", VA = "0x1881A1140")]
		get
		{
			return default(EBJKDIGDMEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81A11F0", Offset = "0x81A01F0", VA = "0x1881A11F0")]
	public EBJKDIGDMEE(bool JIJMLDFCFOM, bool NIBLBKCHDCL, int EOJMIIDNPPH, int HMGMNMGPMHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct MEHLEKHCIAA : IEquatable<MEHLEKHCIAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int MKOCHPIICKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int ALJEOLOPJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int IAHEPIPIOCM;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xE503E0", Offset = "0xE4F3E0", VA = "0x180E503E0")]
	public MEHLEKHCIAA(int HLGKMAPOEBE, int OEBPMIKEAJL, int MJKLDIGKDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81A4B10", Offset = "0x81A3B10", VA = "0x1881A4B10")]
	public static int BHCBHIAGKLJ([In] MEHLEKHCIAA MLCJFBKFHOP, [In] MEHLEKHCIAA FPNPAOBAPAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28E88D0", Offset = "0x28E78D0", VA = "0x1828E88D0", Slot = "4")]
	public bool Equals(MEHLEKHCIAA EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81A4B30", Offset = "0x81A3B30", VA = "0x1881A4B30", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x81A4BE0", Offset = "0x81A3BE0", VA = "0x1881A4BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DNDGPEGCFNO
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAKDDEIFPLO(string FGPPMKCJBPJ, [Out][NotNullWhen(true)] IReadOnlyList<MFHAEAPNAJA>? MHPOCKAHOPH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ALLMECEFJLB : DNDGPEGCFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int EDLOLGBIOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<MFHAEAPNAJA> results)> HMLPKMOGHLI;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x819F290", Offset = "0x819E290", VA = "0x18819F290")]
	public ALLMECEFJLB(int EDLOLGBIOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x819F110", Offset = "0x819E110", VA = "0x18819F110", Slot = "4")]
	public bool FAKDDEIFPLO(string FGPPMKCJBPJ, [Out][NotNullWhen(true)] IReadOnlyList<MFHAEAPNAJA>? MHPOCKAHOPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HMGPEDOLBIG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void IMAEDBDBGMO(IReadOnlyList<MFHAEAPNAJA> MHPOCKAHOPH);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class KBPLFKFALPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public HMGPEDOLBIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KBPLFKFALPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81A3B50", Offset = "0x81A2B50", VA = "0x1881A3B50")]
		internal MFHAEAPNAJA[] JEFGDDLMAHB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JEDFECMHMIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HMGPEDOLBIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private KBPLFKFALPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IMAEDBDBGMO onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<MFHAEAPNAJA[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81A3730", Offset = "0x81A2730", VA = "0x1881A3730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JBELEKLGOCB FCIMPODEJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IKCPJMIFJMC GHPJPLACMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly OKAGFMOEENP.FBPHOMLPABA? PCFFANFICKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MFHAEAPNAJA[] ANIKPLDHJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? OKJNNIEFEBK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KKHOOGOMJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11FCCC0", Offset = "0x11FBCC0", VA = "0x1811FCCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81A3680", Offset = "0x81A2680", VA = "0x1881A3680")]
	public HMGPEDOLBIG(JBELEKLGOCB FCIMPODEJPB, IKCPJMIFJMC GHPJPLACMED, [Optional] OKAGFMOEENP.FBPHOMLPABA? PCFFANFICKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81A34C0", Offset = "0x81A24C0", VA = "0x1881A34C0")]
	[AsyncStateMachine(typeof(JEDFECMHMIB))]
	public void INALMJLIPMO(string FGPPMKCJBPJ, IMAEDBDBGMO LOLFDLKDOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81A35B0", Offset = "0x81A25B0", VA = "0x1881A35B0")]
	public void JAMDHJMFGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OKAGFMOEENP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int FBPHOMLPABA(ReadOnlySpan<char> FGPPMKCJBPJ, ReadOnlySpan<char> LFJBOFOGMKL, int ADMDPOBNILI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81A4FC0", Offset = "0x81A3FC0", VA = "0x1881A4FC0")]
	public static int FKCOIIHHIEC([In] MFHAEAPNAJA MLCJFBKFHOP, [In] MFHAEAPNAJA FPNPAOBAPAE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MFHAEAPNAJA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class ELHMKOBFIJF : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
		public MFHAEAPNAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public MFHAEAPNAJA <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1290C40", Offset = "0x128FC40", VA = "0x181290C40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x81A2380", Offset = "0x81A1380", VA = "0x1881A2380", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1364040", Offset = "0x1363040", VA = "0x181364040")]
		[DebuggerHidden]
		public ELHMKOBFIJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81A21D0", Offset = "0x81A11D0", VA = "0x1881A21D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81A2330", Offset = "0x81A1330", VA = "0x1881A2330", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81A2270", Offset = "0x81A1270", VA = "0x1881A2270", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81A2270", Offset = "0x81A1270", VA = "0x1881A2270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float ALJEOLOPJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int MKOCHPIICKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> LJFHBLBENJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray PELOKFHAEHB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> IGJAKGCHDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81A4C50", Offset = "0x81A3C50", VA = "0x1881A4C50")]
		[IteratorStateMachine(typeof(ELHMKOBFIJF))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81A4CE0", Offset = "0x81A3CE0", VA = "0x1881A4CE0")]
	public MFHAEAPNAJA(float OEBPMIKEAJL, int HLGKMAPOEBE, ReadOnlyMemory<char> AOJAHPGAGPO, IEnumerable<int> PELOKFHAEHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct EJPDBMKAOCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool FHIKIJNCDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool EFNNDODEGCL;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x48F90D0", Offset = "0x48F80D0", VA = "0x1848F90D0")]
	public EJPDBMKAOCA(bool IFLBLODDADM, bool NBLOBFCKCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81A2140", Offset = "0x81A1140", VA = "0x1881A2140")]
	public string KNIDNHNGIFE(string NGKMMOMPFOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IKCPJMIFJMC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float ALJEOLOPJHF(ReadOnlySpan<char> FGPPMKCJBPJ, ReadOnlySpan<char> LFJBOFOGMKL, [Optional] List<int>? HMGHMFBEMAM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GKJMEIHBBOK : IKCPJMIFJMC
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct EIGIIJIJLOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float IDENCFOFJJE;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2C874D0", Offset = "0x2C864D0", VA = "0x182C874D0")]
		public EIGIIJIJLOH(float ACNCMKNIONG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] FPIPLOMLAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] GMLKKPNNPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray KMDDJIOMFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly EIGIIJIJLOH KGDNAKPKMMC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x81A33E0", Offset = "0x81A23E0", VA = "0x1881A33E0")]
	public GKJMEIHBBOK([In] EIGIIJIJLOH KGDNAKPKMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x81A2B00", Offset = "0x81A1B00", VA = "0x1881A2B00", Slot = "4")]
	public float ALJEOLOPJHF(ReadOnlySpan<char> FGPPMKCJBPJ, ReadOnlySpan<char> LFJBOFOGMKL, [Optional] List<int>? HMGHMFBEMAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x81A3240", Offset = "0x81A2240", VA = "0x1881A3240")]
	private void HNDCGILBMCC(int BKLOHAHJLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81A2E80", Offset = "0x81A1E80", VA = "0x1881A2E80")]
	private float CLCLMBACINN(ReadOnlySpan<char> FGPPMKCJBPJ, ReadOnlySpan<char> LFJBOFOGMKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x81A32D0", Offset = "0x81A22D0", VA = "0x1881A32D0")]
	private int KLCEDIBCHEC(ReadOnlySpan<char> NMLEGPIHAMF, ReadOnlySpan<char> AOJAHPGAGPO, int GBCBMLJMOJP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BKOGDLPNMBO : IKCPJMIFJMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int EOJMIIDNPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? JNFPFACMKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] LPCKIHKEHLM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x819FA70", Offset = "0x819EA70", VA = "0x18819FA70")]
	public BKOGDLPNMBO(int EOJMIIDNPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x819F3C0", Offset = "0x819E3C0", VA = "0x18819F3C0", Slot = "4")]
	public float ALJEOLOPJHF(ReadOnlySpan<char> FGPPMKCJBPJ, ReadOnlySpan<char> LFJBOFOGMKL, [Optional] List<int>? HMGHMFBEMAM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface JBELEKLGOCB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> HMPOLNPPELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LDDKDIKDBFI : JBELEKLGOCB
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BJKGHDJCEHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public EJPDBMKAOCA settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BJKGHDJCEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x819F330", Offset = "0x819E330", VA = "0x18819F330")]
		internal string IPHOKKAPDOM(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GDCHADPGCOA : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
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
		public LDDKDIKDBFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<AACADNAKHPC<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x81A2A20", Offset = "0x81A1A20", VA = "0x1881A2A20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28D7E10", Offset = "0x28D6E10", VA = "0x1828D7E10")]
		[DebuggerHidden]
		public GDCHADPGCOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x81A2A70", Offset = "0x81A1A70", VA = "0x1881A2A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x81A2550", Offset = "0x81A1550", VA = "0x1881A2550", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x81A2500", Offset = "0x81A1500", VA = "0x1881A2500")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x81A29D0", Offset = "0x81A19D0", VA = "0x1881A29D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x81A2920", Offset = "0x81A1920", VA = "0x1881A2920", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x81A2920", Offset = "0x81A1920", VA = "0x1881A2920", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] MNIHLGNHPBM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> HMPOLNPPELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x81A4250", Offset = "0x81A3250", VA = "0x1881A4250", Slot = "4")]
		[IteratorStateMachine(typeof(GDCHADPGCOA))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x81A42D0", Offset = "0x81A32D0", VA = "0x1881A42D0")]
	public LDDKDIKDBFI(IEnumerable<string> FCIMPODEJPB, EJPDBMKAOCA KGDNAKPKMMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class ECPBNBCLLDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void NONFLAPDBBD(IReadOnlyList<MEHLEKHCIAA> MHPOCKAHOPH, IReadOnlyList<bool> CEPKCNDKDFK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly DNDGPEGCFNO? HMLPKMOGHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly HMGPEDOLBIG NMLEGPIHAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly EJPDBMKAOCA DDGAHKIHFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EBJKDIGDMEE KGDNAKPKMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NONFLAPDBBD HKBCGCHFMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly OKAGFMOEENP.FBPHOMLPABA? PCFFANFICKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IReadOnlyList<MEHLEKHCIAA> HBAMIOPJNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IReadOnlyList<bool> EKHCMCINNHB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<MEHLEKHCIAA> NOJLHEBBPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> PBIBMLEGPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KKHOOGOMJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x81A17B0", Offset = "0x81A07B0", VA = "0x1881A17B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x81A1CF0", Offset = "0x81A0CF0", VA = "0x1881A1CF0")]
	public ECPBNBCLLDF(IReadOnlyList<string> PMDGDGBONEH, [In] EBJKDIGDMEE KGDNAKPKMMC, NONFLAPDBBD LOLFDLKDOJB, [Optional] OKAGFMOEENP.FBPHOMLPABA? PCFFANFICKB, [Optional] IKCPJMIFJMC? MNIOJKONMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x81A1410", Offset = "0x81A0410", VA = "0x1881A1410")]
	public void KGNEFHFNNHF(string FGPPMKCJBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x81A17D0", Offset = "0x81A07D0", VA = "0x1881A17D0")]
	private void OLILHPMOAKI(IReadOnlyList<MFHAEAPNAJA> MHPOCKAHOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x81A1210", Offset = "0x81A0210", VA = "0x1881A1210")]
	private int ILABFBHEDMM(ReadOnlySpan<char> MKOOPFGGHLN, ReadOnlySpan<char> AOJAHPGAGPO, int PPONPOCELAL)
	{
		return default(int);
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
